using CapaRN;
using DevComponents.DotNetBar.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace SistemaDeInventario2026
{
    public partial class FRMCompra_Registrar : Form
    {
        #region Variables
        // Ajusta estos nombres a tus clases reales de la CapaRN / CapaAD
        private aproved proveedor = new aproved();
        private bool proveedorOk = false;
        private aproduc producto = new aproduc();
        private bool productoOk = false;
        private lcompra lCompra = new lcompra();
        private acompra acompra = new acompra();
        private xnumcor correlativo = new xnumcor();
        public bool actualizar = false;

        // Variable para mantener el efecto hover en el ListView
        private ListViewItem filaAnteriorListView = null;
        #endregion
        public FRMCompra_Registrar()
        {
            InitializeComponent();
        }
        #region Metodos
        private bool VerificarIntegridad()
        {
            bool respuesta = true;

            
            if (TXTCompraProveedor.Text.Replace(" ", "") == "")
            {
                MessageBox.Show("Introduzca el proveedor", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TXTCompraProveedor.Focus();
                respuesta = false;
            }
            
            else if (TXTCompraProveedorCelular.Text.Replace(" ", "") == "")
            {
                MessageBox.Show("Introduzca el celular de la proveedor", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TXTCompraProveedorCelular.Focus();
                respuesta = false;
            }
            else if (TXTCompraFactura.Text.Replace(" ", "") == "")
            {
                MessageBox.Show("Introduzca el NÚMERO DE FACTURA", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TXTCompraFactura.Focus();
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
            else if (LTVCarrito.Items.Count == 0)
            {
                MessageBox.Show("El carrito de compras está vacío. Agregue al menos un producto.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TXTCompraProductoEncontrado.Focus();
                respuesta = false;
            }

            return respuesta;
        }

        private void LimpiarCasillas()
        {
            TXTCompraProveedor.Text = "";
            TXTCompraFactura.Text = "";
            TXTCompraProveedorCelular.Text = "";
            //DTIFecha.Value = DateTime.Now;
            
            TXTCompraProductoEncontrado.Text = "";
            NUDCantidad.Value = 1;
            NUDPrecio.Value = 0;

            LTVCarrito.Items.Clear();
            LBLTotal.Text = "Total: 0.00";
        }
        private void CalcularTotal()
        {
            decimal total = 0;
            foreach (ListViewItem item in LTVCarrito.Items)
            {
                if (decimal.TryParse(item.SubItems[3].Text, out decimal subtotal))
                {
                    total += subtotal;
                }
            }
            LBLTotal.Text = $"Total: {total:F2}";

        }

        private void AgregarAlCarrito()
        {
            string producto = TXTCompraProductoEncontrado.Text;
            int cantidad = (int)NUDCantidad.Value;
            decimal precio = NUDPrecio.Value;
            decimal subtotal = cantidad * precio;

            ListViewItem item = new ListViewItem(producto);
            item.SubItems.Add(cantidad.ToString());           // Columna 1: Cant.
            item.SubItems.Add(precio.ToString("F2"));         // Columna 2: Precio
            item.SubItems.Add(subtotal.ToString("F2"));       // Columna 3: Subtotal
            item.SubItems.Add("✕");                          // Columna 4: Botón Eliminar
            item.Tag = this.producto.papdcodpro;              // Columna 5: Código del producto (para referencia al guardar en BD) // NUEVA (inciso a)
            // Guardamos el código del producto en el Tag por si necesitamos guardar en BD después
            // item.Tag = CMBProducto.SelectedValue.ToString(); 

            LTVCarrito.Items.Add(item);
            CalcularTotal();
        }
        private void ConfigurarListView()
        {
            // Las columnas ya están definidas en el diseñador, pero podemos ajustar propiedades
            LTVCarrito.View = View.Details;
            LTVCarrito.FullRowSelect = true;
            LTVCarrito.GridLines = true;  // Ya está en true en el diseñador
            LTVCarrito.HeaderStyle = ColumnHeaderStyle.Nonclickable;
            LTVCarrito.MultiSelect = false;
            LTVCarrito.Scrollable = true;

            // Ajustar el ancho de la columna 5 (la X) si es necesario
            if (LTVCarrito.Columns.Count >= 5)
            {
                LTVCarrito.Columns[4].Width = 50; // Ancho para el botón X
            }
        }
        #endregion
        private void FRMCompra_Registrar_Load(object sender, EventArgs e)
        {
            LimpiarCasillas();
            ConfigurarListView();
        }

        private void FRMCompra_Registrar_FormClosing(object sender, FormClosingEventArgs e)
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
            if (LTVCarrito.Items.Count > 0)
            {
                if (MessageBox.Show("¿Está seguro de vaciar el carrito?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    LTVCarrito.Items.Clear();
                    CalcularTotal();
                }
            }
        }

        private void BTNRegistrarCompra_Click(object sender, EventArgs e)
        {
            if (VerificarIntegridad())
            {
                acompra = new acompra();

                // Generar el correlativo de compra
                correlativo.pxnctipcor = "acompra";
                if (correlativo.ObtenerSiguiente())
                {
                    acompra.papccodcom = correlativo.pxnctipcor + "-" +
                                        correlativo.cxncnumcor.ToString("D12");
                }
                else
                {
                    MessageBox.Show("Error al generar el código de compra.",
                                    "Error",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                    return;
                }

                // Generar los correlativos de los detalles: uno por cada fila del carrito
                int cantidadFilas = LTVCarrito.Items.Count;
                xnumcor correlativoDetalle = new xnumcor();
                correlativoDetalle.pxnctipcor = "adetcompra";
                if (!correlativoDetalle.ObtenerSiguiente(cantidadFilas))
                {
                    MessageBox.Show("Error al generar los códigos del detalle de compra.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                int numeroDetalle = correlativoDetalle.cxncnumcor - cantidadFilas + 1; // primer número reservado



                // Asignar datos de la cabecera de la compra
                // compra.capdfeccom = DateTime.Now; // Si tienes campo de fecha
                acompra.capdfaccom = TXTCompraFactura.Text;

                // Asignar proveedor (si usas ValueMember con el código)
                if (TXTCompraProveedor.Text != "")
                {
                    // acompra.faprcodpro = TXTCompraProveedor.Text;
                    acompra.faprcodpro = proveedor.paprcodpro;
                }
                else
                {
                    MessageBox.Show("Por favor, seleccione un proveedor válido de la lista.",
                                    "Advertencia",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Warning);
                    return; // Detiene la ejecución para que no intente guardar vacío
                }

                acompra.faprcodpro = proveedor.paprcodpro; // NUEVA (inciso b)

                // Asignar el total de la compra
                acompra.capctotcom = decimal.TryParse(LBLTotal.Text, out decimal total) ? total : 0.0m;
                acompra.capctotcom = LTVCarrito.Items.Cast<ListViewItem>().Sum(i => decimal.Parse(i.SubItems[3].Text));   // NUEVA (inciso c)

                // Grabar la cabecera de la compra
                if (acompra.Grabar())
                {
                    // Grabar los detalles de la compra (productos del carrito)
                    bool detallesGrabados = true;

                    foreach (ListViewItem item in LTVCarrito.Items)
                    {
                        adetcompra detalle = new adetcompra(); // Ajusta al nombre real de tu clase de detalle

                        // Asignar el código de compra (foránea)
                        detalle.fapdcodcom = acompra.papccodcom;

                        // Generar el código del detalle usando el correlativo
                        detalle.papdcoddet = correlativoDetalle.pxnctipcor + "-" + numeroDetalle.ToString("D12");
                        numeroDetalle++;

                        // Asignar el producto (si guardaste el código en el Tag del ListViewItem)
                        if (item.Tag != null)
                        {
                            detalle.fapdcodpro = item.Tag.ToString();
                        }
                        else
                        {
                            // Si no usas Tag, puedes buscar el producto por nombre
                            // detalle.fapdcodpro = ObtenerCodigoProducto(item.Text);
                        }

                        // Asignar cantidad y precio desde el ListView
                        detalle.capdcandet = int.TryParse(item.SubItems[1].Text, out int cantidad) ? cantidad : 0;
                        detalle.capdprecom = decimal.TryParse(item.SubItems[2].Text, out decimal precio) ? precio : 0.0m;
                        detalle.capdsubtot = decimal.TryParse(item.SubItems[3].Text, out decimal subtotal) ? subtotal : 0.0m;

                        // Grabar el detalle
                        if (!detalle.Grabar())
                        {
                            detallesGrabados = false;
                            break; // Salir del bucle si hay error
                        }
                        // NUEVO: aumentar el stock del producto comprado
                        aproduc productoStock = new aproduc();
                        productoStock.papdcodpro = detalle.fapdcodpro;
                        if (productoStock.ObtenerDatos())
                        {
                            productoStock.capdstopro += detalle.capdcandet;
                            productoStock.capdfecmod = DateTime.Now;
                            productoStock.Modificar();
                        }
                    }

                    if (detallesGrabados)
                    {
                        MessageBox.Show("Compra registrada correctamente!!",
                                        "Mensaje",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Information);
                        LimpiarCasillas();
                        this.actualizar = true;
                        this.FormClosing -= FRMCompra_Registrar_FormClosing;
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("La compra se registró pero hubo un error al guardar los detalles.",
                                        "Advertencia",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Warning);
                        LimpiarCasillas();
                        this.actualizar = true;
                        this.FormClosing -= FRMCompra_Registrar_FormClosing;
                        this.Close();
                    }
                }
                else
                {
                    MessageBox.Show("La compra no se pudo registrar!!",
                                    "Error",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Warning);
                }
            }
        }

        private void LTVCarrito_MouseMove(object sender, MouseEventArgs e)
        {
            ListViewItem item = LTVCarrito.GetItemAt(e.X, e.Y);

            // Restaurar color de la fila anterior
            if (filaAnteriorListView != null && filaAnteriorListView != item)
            {
                filaAnteriorListView.BackColor = Color.White;
                foreach (ListViewItem.ListViewSubItem sub in filaAnteriorListView.SubItems)
                {
                    sub.BackColor = Color.White;
                    sub.ForeColor = Color.Black;
                }
            }

            if (item != null)
            {
                Color hoverColor = Color.FromArgb(245, 245, 245);
                item.BackColor = hoverColor;
                foreach (ListViewItem.ListViewSubItem sub in item.SubItems)
                {
                    sub.BackColor = hoverColor;
                }
                filaAnteriorListView = item;

                // Verificar si el mouse está sobre la columna 4 (la "X" - índice 4)
                ListViewItem.ListViewSubItem subItem = item.GetSubItemAt(e.X, e.Y);
                int columnIndex = item.SubItems.IndexOf(subItem);

                if (columnIndex == 4)
                {
                    LTVCarrito.Cursor = Cursors.Hand;
                    subItem.ForeColor = Color.Red;
                    subItem.Font = new Font(LTVCarrito.Font, FontStyle.Bold);
                }
                else
                {
                    LTVCarrito.Cursor = Cursors.Default;
                }
            }
            else
            {
                LTVCarrito.Cursor = Cursors.Default;
                filaAnteriorListView = null;
            }
        }

        private void LTVCarrito_MouseClick(object sender, MouseEventArgs e)
        {
            ListViewItem item = LTVCarrito.GetItemAt(e.X, e.Y);

            if (item != null)
            {
                ListViewItem.ListViewSubItem subItem = item.GetSubItemAt(e.X, e.Y);
                int columnIndex = item.SubItems.IndexOf(subItem);

                // Si se hizo clic en la columna 4 (la "X" - índice 4)
                if (columnIndex == 4)
                {
                    DialogResult resultado = MessageBox.Show(
                        $"¿Eliminar '{item.Text}' del carrito?",
                        "Confirmar eliminación",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question);

                    if (resultado == DialogResult.Yes)
                    {
                        LTVCarrito.Items.Remove(item);
                        CalcularTotal();
                    }
                }
            }
        }

        private void LTVCarrito_MouseLeave(object sender, EventArgs e)
        {
            if (filaAnteriorListView != null)
            {
                filaAnteriorListView.BackColor = Color.White;
                foreach (ListViewItem.ListViewSubItem sub in filaAnteriorListView.SubItems)
                {
                    sub.BackColor = Color.White;
                    sub.ForeColor = Color.Black;
                }
                filaAnteriorListView = null;
            }
            LTVCarrito.Cursor = Cursors.Default;
        }

        private void CMBCompraProveedor_Enter(object sender, EventArgs e)
        {
            ComboBoxEx a = (ComboBoxEx)sender;
            a.SelectAll();
        }

        private void TXTCompraFactura_Enter(object sender, EventArgs e)
        {
            TextBox a = (TextBox)sender;
            a.SelectAll();
        }

        private void CMBCompraProducto_Enter(object sender, EventArgs e)
        {
            ComboBoxEx a = (ComboBoxEx)sender;
            a.SelectAll();
        }

        private void TXTCompraFactura_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = char.ToUpper(e.KeyChar);
        }

        private void BTNBuscarProveedorCompra_Click(object sender, EventArgs e)
        {
            FRMProveedor_Buscar a = new FRMProveedor_Buscar();
            a.ShowDialog();
            if (a.seleccionadoOk)
            {
                this.proveedor = a.proveedor;
                this.proveedorOk = true;
                TXTCompraProveedorCelular.Text = proveedor.caprnumcel;
                TXTCompraProveedor.Text = proveedor.caprsocpro;
                BTNBuscarProveedorCompra.Enabled = false; // Deshabilitar el botón después de seleccionar un proveedor
                /*TXTContacto.Text = persona.capsapepat + " " +
                                  persona.capsapemat + " " +
                                  persona.capsnomper;
                */
            }
            else
            {
                this.proveedorOk = false;
                TXTCompraProveedorCelular.Text = "";
                TXTCompraProveedor.Text = "Nombre Completo";
                //TXTContacto.Text = "Contacto";
            }
        }

        private void BTNBuscarProductoCompra_Click(object sender, EventArgs e)
        {
            FRMProducto_Buscar a = new FRMProducto_Buscar();
            a.ShowDialog();
            if (a.seleccionadoOk)
            {
                this.producto = a.producto;
                this.productoOk = true;
                TXTCompraProductoEncontrado.Text = producto.capdnompro + " - " + 
                                                   producto.capdcolpro + " - " + 
                                                   producto.capdtalpro + " - " + 
                                                   producto.capdmarpro + " - " +
                                                   producto.capdgenpro;
                //TXTCompraProveedor.Text = proveedor.caprsocpro;

                /*TXTContacto.Text = persona.capsapepat + " " +
                                  persona.capsapemat + " " +
                                  persona.capsnomper;
                */
            }
            else
            {
                this.productoOk = false;
                TXTCompraProductoEncontrado.Text = "Producto No Encontrado";
                //TXTContacto.Text = "Contacto";
            }
        }

        private void BTNAgregarProductoAlCarrito_Click(object sender, EventArgs e)
        {
            bool respuesta = true;
            if (TXTCompraProveedor.Text.Replace(" ", "") == "")
            {
                MessageBox.Show("Debe elegir un proveedor, es requisito. Recuerde que solo es un proveedor por compra, caso contrario emita una Nueva", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TXTCompraProveedor.Focus();
                respuesta = false;
            }
            else if (TXTCompraProveedorCelular.Text.Replace(" ", "") == "")
            {
                MessageBox.Show("Procure ingresar el celular del proveedor elegido, Es requisito", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TXTCompraProveedorCelular.Focus();
                respuesta = false;
            }
            else if (TXTCompraFactura.Text.Replace(" ", "") == "")
            {
                MessageBox.Show("Para esta compra se debe mantener el mismo NÚMERO DE FACTURA, caso contrario continúe el registro de la compra si lo desea y emita una Nueva", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TXTCompraFactura.Focus();
                respuesta = false;
            }
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
            else if (NUDPrecio.Value <= 0)
            {
                MessageBox.Show("Introduzca el PRECIO MÍNIMO del producto", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                NUDPrecio.Focus();
                respuesta = false;
            }
            else if((TXTCompraProductoEncontrado.Text.Replace(" ", "") != "") && (NUDCantidad.Text.Replace(" ", "") != "") && (NUDPrecio.Value > 0))
            {
                AgregarAlCarrito();
                // Limpiar solo los campos del producto para agregar otro rápidamente
                TXTCompraProductoEncontrado.Text = "";
                NUDCantidad.Value = 1;
                NUDPrecio.Value = 0;
                TXTCompraProductoEncontrado.Focus();
            }

            // Limpiar solo los campos del producto para agregar otro rápidamente
            //TXTCompraProductoEncontrado.Text = "";
            //NUDCantidad.Value = 1;
            //NUDPrecio.Value = 0;
            //TXTCompraProductoEncontrado.Focus();
        }
    }
}
