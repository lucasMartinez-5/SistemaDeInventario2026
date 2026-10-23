using CapaRN;
using SistemaDeGestion2026;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaDeInventario2026
{
    public partial class FRMVenta_Registrar : Form
    {
        #region Variables
        // Ajusta estos nombres a tus clases reales de la CapaRN / CapaAD
        private aclient cliente = new aclient();
        private bool clienteOk = false;
        private aproduc producto = new aproduc();
        private bool productoOk = false;
        private lventa lventa = new lventa();
        private aventa venta = new aventa();
        private xnumcor correlativo = new xnumcor();
        public bool actualizar = false;
        #endregion

        #region Constructor
        public FRMVenta_Registrar()
        {
            InitializeComponent();
        }
        #endregion

        #region Metodos
        private bool VerificarIntegridad()
        {
            bool respuesta = true;


            if (TXTCliente.Text.Replace(" ", "") == "")
            {
                MessageBox.Show("Introduzca el cliente", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TXTCliente.Focus();
                respuesta = false;
            }

            else if (TXTCelular.Text.Replace(" ", "") == "")
            {
                MessageBox.Show("Introduzca el celular del cliente", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TXTCelular.Focus();
                respuesta = false;
            }
            else if (TXTNIT.Text.Replace(" ", "") == "")
            {
                MessageBox.Show("Introduzca el NÚMERO DE FACTURA", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TXTNIT.Focus();
                respuesta = false;
            }
            /*
            else if (TXTCompraProductoEncontrado.Text.Replace(" ", "") == "")
            {
                MessageBox.Show("Ingrese el producto", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TXTCompraProductoEncontrado.Focus();
                respuesta = false;
            }
            
            else if (NUDCantidad.Text.Replace(" ", "") == "")
            {
                MessageBox.Show("Ingrese una cantidad", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                NUDCantidad.Focus();
                respuesta = false;
            }
            else if ((NUDPrecio.Value <= 0))
            {
                MessageBox.Show("Introduzca el PRECIO MÍNIMO del producto", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                NUDPrecio.Focus();
                respuesta = false;
            }
            */
            /*
            else if (DTGCarrito.Items.Count == 0)
            {
                MessageBox.Show("El carrito de compras está vacío. Agregue al menos un producto.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TXTProducto.Focus();
                respuesta = false;
            }
            */
            else if (DTGCarrito.RowCount == 0)
            {
                MessageBox.Show("El carrito de compras está vacío. Agregue al menos un producto.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TXTProducto.Focus();
                respuesta = false;
            }
            else if (!VerificarStockActual())
            {
                respuesta = false;
            }
            return respuesta;
        }

        private void LimpiarCasillas()
        {
            TXTCliente.Text = "";
            TXTNIT.Text = "";
            TXTCelular.Text = "";
            //DTIFecha.Value = DateTime.Now;

            TXTProducto.Text = "";
            NUDCantidad.Value = 1;
            //NUDPrecio.Value = 0;

            TXTObservaciones.Text = "";

            DTGCarrito.Rows.Clear();
            LBLTotal.Text = "Total: 0.00";
        }
        private void CalcularTotal()
        {
            decimal total = 0;
            foreach (DataGridViewRow fila in DTGCarrito.Rows)
            {
                total += Convert.ToDecimal(fila.Cells[4].Value);
            }
            LBLTotal.Text = $"Total: {total:F2}";

        }
        private int CantidadEnCarrito(string codigoProducto, int filaExcluida)
        {
            int total = 0;
            foreach (DataGridViewRow fila in DTGCarrito.Rows)
            {
                if (fila.Index == filaExcluida) continue;
                if (((string[])fila.Tag)[0] == codigoProducto)
                {
                    total += Convert.ToInt32(fila.Cells[2].Value);
                }
            }
            return total;
        }

        // Escribe en Observaciones el tipo de precio de cada producto del carrito.
        // Respeta lo que el usuario escriba a mano (las líneas que no empiezan con "Precio - ").
        private void ActualizarObservaciones()
        {
            const string prefijo = "Precio - ";
            List<string> lineas = new List<string>();

            foreach (string linea in TXTObservaciones.Lines)
            {
                if (linea.Trim() != "" && !linea.StartsWith(prefijo))
                    lineas.Add(linea);
            }
            foreach (DataGridViewRow fila in DTGCarrito.Rows)
            {
                lineas.Add(prefijo + fila.Cells[1].Value + " - " + ((string[])fila.Tag)[1]);
            }
            //TXTObservaciones.Text = string.Join(Environment.NewLine, lineas.ToArray());
        }

        // Vuelve a leer el stock en la base de datos antes de registrar la venta
        private bool VerificarStockActual()
        {
            foreach (DataGridViewRow fila in DTGCarrito.Rows)
            {
                string codigo = ((string[])fila.Tag)[0];
                aproduc p = new aproduc();
                p.papdcodpro = codigo;
                if (!p.ObtenerDatos())
                {
                    MessageBox.Show("El producto '" + fila.Cells[1].Value + "' ya no existe.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
                int pedido = CantidadEnCarrito(codigo, -1);   // suma todas las filas de ese producto
                if (pedido > p.capdstopro)
                {
                    MessageBox.Show("Stock insuficiente de '" + fila.Cells[1].Value + "'.\nPedido: " + pedido + " - Disponible: " + p.capdstopro,
                                    "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
            }
            return true;
        }
        private void AgregarAlCarrito()
        {
            int cantidad = (int)NUDCantidad.Value;
            decimal precio = decimal.Parse(TXTPrecioUnitario.Text);   // el precio que muestra TXTPrecioUnitario
            string tipoPrecio = CMBTipoPrecio.Text;

            // Si el producto ya está en el carrito con el mismo tipo de precio, se suma la cantidad
            foreach (DataGridViewRow fila in DTGCarrito.Rows)
            {
                string[] datos = (string[])fila.Tag;
                if (datos[0] == this.producto.papdcodpro && datos[1] == tipoPrecio)
                {
                    int nueva = Convert.ToInt32(fila.Cells[2].Value) + cantidad;
                    fila.Cells[2].Value = nueva;
                    fila.Cells[4].Value = nueva * Convert.ToDecimal(fila.Cells[3].Value);
                    CalcularTotal();
                    return;
                }
            }

            // Foto del producto (si no tiene, la imagen por defecto)
            Image foto;
            if (producto.capdfotpro == "")
                foto = Properties.Resources.no_image;
            else
                foto = MetodosGenerales.ConvertBase64StringToImage(producto.capdfotpro);

            // Un valor por cada columna: 0 Foto, 1 Producto, 2 Cantidad, 3 Precio, 4 Sub Total, 5 X
            int indice = DTGCarrito.Rows.Add(foto, TXTProducto.Text, cantidad, precio, cantidad * precio, "X");

            // Tag de la fila: [0] código del producto, [1] tipo de precio (solo para auditoría, no se ve en el carrito)
            DTGCarrito.Rows[indice].Tag = new string[] { this.producto.papdcodpro, tipoPrecio };

            ActualizarObservaciones();   // anota el tipo de precio en Observaciones
            CalcularTotal();
        }
        #endregion

        #region Eventos

        #endregion

        private void FRMVenta_Registrar_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("¿Está seguro que desea cerrar el formulario?",
                                "Pregunta",
                                MessageBoxButtons.YesNo,
                                MessageBoxIcon.Question,
                                MessageBoxDefaultButton.Button2) == DialogResult.No)
            {
                e.Cancel = true;
            }
            else
            {
                //ApagarCamara();
            }
        }

        private void BTNSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BTNVaciarCarrito_Click(object sender, EventArgs e)
        {
            if (DTGCarrito.Rows.Count > 0)
            {
                if (MessageBox.Show("¿Está seguro de vaciar el carrito?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    DTGCarrito.Rows.Clear();
                    ActualizarObservaciones();
                    CalcularTotal();
                }
            }
        }

        private void BTNRegistrarVenta_Click(object sender, EventArgs e)
        {
            if (VerificarIntegridad())
            {
                venta = new aventa();

                // Generar el correlativo de compra
                correlativo.pxnctipcor = "aventa";
                if (correlativo.ObtenerSiguiente())
                {
                    venta.papvcodven = correlativo.pxnctipcor + "-" +
                                        correlativo.cxncnumcor.ToString("D12");
                }
                else
                {
                    MessageBox.Show("Error al generar el código de venta.",
                                    "Error",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                    return;
                }

                // Generar los correlativos de los detalles: uno por cada fila del carrito
                int cantidadFilas = DTGCarrito.Rows.Count;
                xnumcor correlativoDetalle = new xnumcor();
                correlativoDetalle.pxnctipcor = "adetventa";
                if (!correlativoDetalle.ObtenerSiguiente(cantidadFilas))
                {
                    MessageBox.Show("Error al generar los códigos del detalle de venta.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                int numeroDetalle = correlativoDetalle.cxncnumcor - cantidadFilas + 1; // primer número reservado

                // Asignar proveedor (si usas ValueMember con el código)
                if (TXTCliente.Text != "")
                {
                    // acompra.faprcodpro = TXTCompraProveedor.Text;
                    venta.fapvcodcli = cliente.paclcodcli;
                }
                else
                {
                    MessageBox.Show("Por favor, seleccione un cliente válido de la lista.",
                                    "Advertencia",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Warning);
                    return; // Detiene la ejecución para que no intente guardar vacío
                }

                venta.fapvcodcli = cliente.paclcodcli; // NUEVA (inciso b)
                venta.capvfecven = DateTime.Now;
                venta.fapvcodusu = SesionActual.CodigoUsuario;     // solo para auditoría
                venta.capvobsven = TXTObservaciones.Text.Trim();   // solo para auditoría

                // Asignar el total de la compra
                venta.capvtotven = decimal.TryParse(LBLTotal.Text, out decimal total) ? total : 0.0m;
                venta.capvtotven = DTGCarrito.Rows.Cast<DataGridViewRow>().Sum(r => decimal.Parse(r.Cells[4].Value.ToString()));   // NUEVA (inciso c)

                // Grabar la cabecera de la compra
                if (venta.Grabar())
                {
                    // Grabar los detalles de la compra (productos del carrito)
                    bool detallesGrabados = true;

                    foreach (DataGridViewRow fila in DTGCarrito.Rows)
                    {
                        adetventa detalle = new adetventa();

                        // Asignar el código de venta (foránea)
                        detalle.fapwcodven = venta.papvcodven;

                        // Generar el código del detalle usando el correlativo
                        detalle.papwcoddet = correlativoDetalle.pxnctipcor + "-" + numeroDetalle.ToString("D12");
                        numeroDetalle++;

                        // Asignar el producto (su código está en el Tag de la fila)
                        detalle.fapwcodpro = ((string[])fila.Tag)[0];

                        // Asignar cantidad y precio desde el carrito
                        detalle.capwcandet = Convert.ToInt32(fila.Cells[2].Value);
                        detalle.capwpreven = Convert.ToDecimal(fila.Cells[3].Value);
                        detalle.capwsubtot = Convert.ToDecimal(fila.Cells[4].Value);

                        // Grabar el detalle
                        if (!detalle.Grabar())
                        {
                            detallesGrabados = false;
                            break; // Salir del bucle si hay error
                        }
                        // NUEVO: disminuir el stock del producto vendido
                        aproduc productoStock = new aproduc();
                        productoStock.papdcodpro = detalle.fapwcodpro;
                        if (productoStock.ObtenerDatos())
                        {
                            productoStock.capdstopro -= detalle.capwcandet;
                            if (productoStock.capdstopro < 0) productoStock.capdstopro = 0;
                            productoStock.capdfecmod = DateTime.Now;
                            productoStock.Modificar();
                        }
                    }

                    if (detallesGrabados)
                    {
                        MessageBox.Show("Venta registrada correctamente!!",
                                        "Mensaje",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Information);
                        LimpiarCasillas();
                        this.actualizar = true;
                        //
                        
                        //
                        this.FormClosing -= FRMVenta_Registrar_FormClosing;
                        this.Close();
                        FRMVenta_Detalle v = new FRMVenta_Detalle();
                        v.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("La venta se registró pero hubo un error al guardar los detalles.",
                                        "Advertencia",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Warning);
                        LimpiarCasillas();
                        this.actualizar = true;
                        this.FormClosing -= FRMVenta_Registrar_FormClosing;
                        this.Close();
                    }
                }
                else
                {
                    MessageBox.Show("La venta no se pudo registrar!!",
                                    "Error",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Warning);
                }
            }
        }

        private void BTNBuscarCliente_Click(object sender, EventArgs e)
        {
            FRMCliente_Buscar a = new FRMCliente_Buscar();
            a.ShowDialog();
            if (a.seleccionadoOk)
            {
                this.cliente = a.cliente;
                this.clienteOk = true;
                TXTCelular.Text = cliente.caclnumcel;
                TXTCliente.Text = cliente.caclsoccli;
                TXTNIT.Text = cliente.caclnitcli;
                BTNBuscarCliente.Enabled = false; // Deshabilitar el botón después de seleccionar un cliente
                /*TXTContacto.Text = persona.capsapepat + " " +
                                  persona.capsapemat + " " +
                                  persona.capsnomper;
                */
            }
            else
            {
                this.clienteOk = false;
                TXTCelular.Text = "";
                TXTCliente.Text = "Nombre Completo";
                //TXTContacto.Text = "Contacto";
            }
        }

        private void BTNBuscarProducto_Click(object sender, EventArgs e)
        {
            if(CMBTipoPrecio.SelectedIndex == -1)
            {
                MessageBox.Show("Por favor, seleccione un tipo de precio.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                CMBTipoPrecio.Focus();
                return;
            }
            else if (CMBTipoPrecio.SelectedIndex == 0 || CMBTipoPrecio.SelectedIndex == 1)
            {
                FRMProducto_Buscar a = new FRMProducto_Buscar();
                a.ShowDialog();
                if (a.seleccionadoOk)
                {
                    this.producto = a.producto;
                    this.productoOk = true;
                    TXTProducto.Text = producto.capdnompro + " - " +
                                                       producto.capdcolpro + " - " +
                                                       producto.capdtalpro + " - " +
                                                       producto.capdmarpro + " - " +
                                                       producto.capdgenpro;
                    TXTStockDisponible.Text = producto.capdstopro.ToString();
                    TXTPrecioUnitario.Text = (CMBTipoPrecio.SelectedIndex == 0) ? producto.capdpremin.ToString("F2") : producto.capdpreven.ToString("F2");
                    if (CMBTipoPrecio.SelectedIndex == 0) // Precio Unitario
                    {
                        
                        // Anotar el tipo de precio de este producto (solo para auditoría)
                        TXTObservaciones.Text += "(" + TXTProducto.Text + " - " + CMBTipoPrecio.Text + Environment.NewLine + ")";
                    }
                    else if (CMBTipoPrecio.SelectedIndex == 1) // Precio Mayorista
                    {
                        //TXTPrecioUnitario.Text = producto.capdpreven.ToString("F2");
                        //TXTObservaciones.Text = producto.papdcodpro + " - " + "Precio Normal," + " ";

                        // Anotar el tipo de precio de este producto (solo para auditoría)
                        TXTObservaciones.Text += "(" + TXTProducto.Text + " - " + CMBTipoPrecio.Text + Environment.NewLine + ")";
                    }
                }
                else
                {
                    this.productoOk = false;
                    TXTProducto.Text = "Producto No Encontrado";
                    //TXTContacto.Text = "Contacto";
                }
            }
            /*
            FRMProducto_Buscar a = new FRMProducto_Buscar();
            a.ShowDialog();
            if (a.seleccionadoOk)
            {
                this.producto = a.producto;
                this.productoOk = true;
                TXTProducto.Text = producto.capdnompro + " - " +
                                                   producto.capdcolpro + " - " +
                                                   producto.capdtalpro + " - " +
                                                   producto.capdmarpro + " - " +
                                                   producto.capdgenpro;
                if(CMBTipoPrecio.SelectedIndex == 0) // Precio Unitario
                {
                    TXTPrecioUnitario.Text = producto.capdpremin.ToString("F2");
                    TXTObservaciones.Text = producto.papdcodpro + " - " + "Precio Descuento," + " ";
                }
                else if (CMBTipoPrecio.SelectedIndex == 1) // Precio Mayorista
                {
                    TXTPrecioUnitario.Text = producto.capdpreven.ToString("F2");
                    TXTObservaciones.Text = producto.papdcodpro + " - " + "Precio Normal," + " ";
                }

                TXTStockDisponible.Text = producto.capdstopro.ToString();
            }
            else
            {
                this.productoOk = false;
                TXTProducto.Text = "Producto No Encontrado";
                //TXTContacto.Text = "Contacto";
            }
            */
        }

        private void BTNAgregarCarrito_Click(object sender, EventArgs e)
        {
            bool respuesta = true;
            if (TXTCliente.Text.Replace(" ", "") == "")
            {
                MessageBox.Show("Debe elegir un cliente, es requisito. Recuerde que solo es un cliente por venta, caso contrario emita una Nueva", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TXTCliente.Focus();
                respuesta = false;
            }
            else if (TXTCelular.Text.Replace(" ", "") == "")
            {
                MessageBox.Show("Procure ingresar el celular del cliente elegido, Es requisito", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TXTCelular.Focus();
                respuesta = false;
            }
            else if (TXTNIT.Text.Replace(" ", "") == "")
            {
                MessageBox.Show("Para esta compra debe mantener el mismo NÚMERO DE IDENTIFICACIÓN TRIBUTARIA (NIT), caso contrario continúe el registro de la compra si lo desea y emita una Nueva", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TXTNIT.Focus();
                respuesta = false;
            }
            else if (TXTProducto.Text.Replace(" ", "") == "")
            {
                MessageBox.Show("Ingrese el producto", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TXTProducto.Focus();
                respuesta = false;
            }
            else if (NUDCantidad.Value <= 0)
            {
                MessageBox.Show("Ingrese una cantidad válida", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                NUDCantidad.Focus();
                respuesta = false;
            }
            else if ((int)NUDCantidad.Value > producto.capdstopro - CantidadEnCarrito(producto.papdcodpro, -1))
            {
                MessageBox.Show("Stock insuficiente. Disponible para agregar: " + (producto.capdstopro - CantidadEnCarrito(producto.papdcodpro, -1)), "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                NUDCantidad.Focus();
                respuesta = false;
            }
            else if (TXTPrecioUnitario.Text.Replace(" ", "") == "" || decimal.Parse(TXTPrecioUnitario.Text) <= 0)
            {
                MessageBox.Show("El Producto no tiene registrado su/s precio/s", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TXTPrecioUnitario.Focus();
                respuesta = false;
            }
            else if ((TXTProducto.Text.Replace(" ", "") != "") && (NUDCantidad.Text.Replace(" ", "") != "") && (TXTPrecioUnitario.Text.Replace(" ", "") != "") && (decimal.Parse(TXTPrecioUnitario.Text) > 0))
            {
                AgregarAlCarrito();
                // Limpiar solo los campos del producto para agregar otro rápidamente
                TXTProducto.Text = "";
                NUDCantidad.Value = 0;
                TXTPrecioUnitario.Text = "";
                TXTStockDisponible.Text = "";
                TXTProducto.Focus();
                CMBTipoPrecio.SelectedIndex = -1;
            }

            // Limpiar solo los campos del producto para agregar otro rápidamente
            //TXTCompraProductoEncontrado.Text = "";
            //NUDCantidad.Value = 1;
            //NUDPrecio.Value = 0;
            //TXTCompraProductoEncontrado.Focus();
        }

        private void DTGCarrito_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == 5)   // columna 5: X
            {
                DataGridViewRow fila = DTGCarrito.Rows[e.RowIndex];
                DialogResult resultado = MessageBox.Show(
                    $"¿Eliminar '{fila.Cells[1].Value}' del carrito?",
                    "Confirmar eliminación",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (resultado == DialogResult.Yes)
                {
                    DTGCarrito.Rows.RemoveAt(e.RowIndex);
                    ActualizarObservaciones();   // quita la línea de ese producto
                    CalcularTotal();
                }
            }
        }

        private void DTGCarrito_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex != 2) return;   // columna 2: Cantidad

            DataGridViewRow fila = DTGCarrito.Rows[e.RowIndex];
            string codigo = ((string[])fila.Tag)[0];

            int cantidad;
            if (!int.TryParse(Convert.ToString(fila.Cells[2].Value), out cantidad) || cantidad < 1)
                cantidad = 1;

            // No permitir más del stock disponible (descontando lo que hay en otras filas del mismo producto)
            aproduc p = new aproduc();
            p.papdcodpro = codigo;
            if (p.ObtenerDatos())
            {
                int disponible = p.capdstopro - CantidadEnCarrito(codigo, e.RowIndex);
                if (cantidad > disponible)
                {
                    MessageBox.Show("Solo hay " + disponible + " unidades disponibles de este producto.",
                                    "Stock insuficiente", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    cantidad = Math.Max(disponible, 1);
                }
            }

            fila.Cells[2].Value = cantidad;
            fila.Cells[4].Value = cantidad * Convert.ToDecimal(fila.Cells[3].Value);   // Sub Total = Cantidad x Precio
            CalcularTotal();
        }

        private void CMBTipoPrecio_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!productoOk || TXTProducto.Text.Replace(" ", "") == "") return;

            if (CMBTipoPrecio.SelectedIndex == 0)        // Precio Descuento
                TXTPrecioUnitario.Text = producto.capdpremin.ToString("F2");
            else if (CMBTipoPrecio.SelectedIndex == 1)   // Precio Normal
                TXTPrecioUnitario.Text = producto.capdpreven.ToString("F2");
        }
    }
}
