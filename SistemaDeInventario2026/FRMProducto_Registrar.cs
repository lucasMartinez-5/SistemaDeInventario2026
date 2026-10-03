using AForge.Video;
using AForge.Video.DirectShow;
using CapaRN;
using DevComponents.DotNetBar.Controls;
using SistemaDeGestion2026;
using SistemaDeInventario2026.Properties;
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
    public partial class FRMProducto_Registrar : Form
    {
        #region Variables
        private bool lectorCBHabilitado = false;
        private lproduc lproducto = new lproduc();
        private aproduc producto = new aproduc();
        private xnumcor correlativo = new xnumcor();
        public bool modificar = false;
        public String codProMod = "";
        public bool actualizar = false;
        //Variables para la camara*/
        private FilterInfoCollection CaptureDevice; // list of webcam
        private VideoCaptureDevice FinalFrame;
        private bool TieneFoto = false;
        #endregion

        #region Constructor
        public FRMProducto_Registrar()
        {
            InitializeComponent();
            DetectarCamaras();
        }
        #endregion

        #region Metodos
        private bool VerificarIntegridad()
        {
            bool respuesta = true;
            aproduc producto2 = new aproduc();
            producto2.capdcodbar = LBLCodigoDeBarras.Text;
            if (CMBProductoNombre.Text.Replace(" ", "") == "" && CMBProductoNombre.SelectedIndex == -1)
            {
                MessageBox.Show("Introduzca el nombre de la prenda", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                CMBProductoNombre.Focus();
                respuesta = false;
            }
            else if (CMBMarca.Text.Replace(" ", "") == "")
            {
                MessageBox.Show("Introduzca la MARCA del producto", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                CMBMarca.Focus();
                respuesta = false;
            }
            else if (CMBMarca.Text.Replace(" ", "") == "" && CMBMarca.SelectedIndex == -1)
            {
                MessageBox.Show("Introduzca un marca para la prenda", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                CMBMarca.Focus();
                respuesta = false;
            }
            else if (CMBColor.Text.Replace(" ", "") == "" && CMBColor.SelectedIndex == -1)
            {
                MessageBox.Show("Introduzca el color de la prenda", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                CMBColor.Focus();
                respuesta = false;
            }
            else if (CMBTalla.Text.Replace(" ", "") == "" && CMBTalla.SelectedIndex == -1)
            {
                MessageBox.Show("Introduzca la talla de la prenda", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                CMBTalla.Focus();
                respuesta = false;
            }
            else if (CMBMaterial.Text.Replace(" ", "") == "" && CMBMaterial.SelectedIndex == -1)
            {
                MessageBox.Show("Introduzca el material de la prenda", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                CMBMaterial.Focus();
                respuesta = false;
            }
            else if (TXTModelo.Text.Replace(" ", "") == "")
            {
                MessageBox.Show("Introduzca el MODELO del producto", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TXTModelo.Focus();
                respuesta = false;
            }
            else if (CMBGenero.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione un genero para la prenda", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                CMBGenero.Focus();
                respuesta = false;
            }
            else if (CMBCategoria.SelectedIndex == -1)
            {
                MessageBox.Show("Introduzca una categoria de la prenda", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                CMBCategoria.Focus();
                respuesta = false;
            }
            else if (producto2.ObtenerDatosCodBarra(modificar, producto.capdcodbar))
            {
                MessageBox.Show("Ya existe un producto con ese código de barras", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                BTNCodigoDeBarras.Focus();
                respuesta = false;
            }
            
            else if (NUDStockActual.Text.Replace(" ", "") == "")
            {
                MessageBox.Show("Introduzca el STOCK del producto", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                NUDStockActual.Focus();
                respuesta = false;
            }
            else if (NUDPrecioVenta.Value <= 0)
            {
                MessageBox.Show("Introduzca el PRECIO DE VENTA del producto", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                NUDPrecioVenta.Focus();
                respuesta = false;
            }
            else if ((NUDPrecioMinVenta.Value <= 0) && (NUDPrecioMinVenta.Value > NUDPrecioVenta.Value))
            {
                MessageBox.Show("Introduzca el PRECIO MÍNIMO del producto", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                NUDPrecioMinVenta.Focus();
                respuesta = false;
            }
            else if (CMBCategoria.Text.Replace(" ", "") == "")
            {
                MessageBox.Show("Introduzca la CATEGORÍA del producto", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                CMBCategoria.Focus();
                respuesta = false;
            }
            return respuesta;
        }

        //Nuevo
        private void CargarComboCategorias()
        {
            List<acatpro> ListaCategorias = new List<acatpro>();
            acatpro categoria = new acatpro();
            ListaCategorias = categoria.Lista("cacpestcat = true order by cacpnomcat");
            CMBCategoria.Items.Clear();
            CMBCategoria.DisplayMember = "cacpnomcat";
            CMBCategoria.ValueMember = "pacpcodcat";
            CMBCategoria.DataSource = ListaCategorias;
            CMBCategoria.SelectedIndex = -1;
        }
        //Nuevo
        private void CargarCombo(String campo, ComboBox combo)
        {
            List<String> ListaNombresProducto = new List<String>();
            ListaNombresProducto = producto.Combo(campo);
            combo.Items.Clear();
            combo.DisplayMember = campo;
            combo.DataSource = ListaNombresProducto;
            combo.SelectedIndex = -1;

        }

        private void LimpiarCasillas()
        {
            SWBEstadoStock.Value = true;

            LBLCodigoDeBarras.Text = "SIN CODIGO";
            CMBProductoNombre.Text = "";
            CMBMarca.Text = "";
            CMBColor.Text = "";
            CMBTalla.Text = "";
            CMBMaterial.Text = "";
            TXTModelo.Text = "";
            CMBGenero.SelectedIndex = -1;
            CMBCategoria.SelectedIndex = -1;
            NUDStockActual.Text = "";
            NUDPrecioVenta.Text = "";
            NUDPrecioMinVenta.Text = "";
            TXTProductoDescripcion.Text = "";
            PCBFotografia.Image = Resources.no_image;
        }

        private void JalarDatos()
        {
            producto.papdcodpro = this.codProMod;
            producto.ObtenerDatos();
            SWBEstadoStock.Value = producto.capdestpro;
            CMBProductoNombre.Text = producto.capdnompro;
            CMBMarca.Text = producto.capdmarpro;
            CMBColor.Text = producto.capdcolpro;
            CMBTalla.Text = producto.capdtalpro;
            CMBMaterial.Text = producto.capdmatpro;
            TXTModelo.Text = producto.capdmodpro;
            CMBGenero.Text = producto.capdgenpro;
            LBLCodigoDeBarras.Text = producto.capdcodbar;
            if (producto.capdcodbar == "")
            {
                LBLCodigoDeBarras.Text = "SIN CODIGO";
                LBLCodigoDeBarras.BackColor = Color.Salmon;
            }
            else
            {
                LBLCodigoDeBarras.Text = producto.capdcodbar;
                LBLCodigoDeBarras.BackColor = Color.PaleGreen;
            }
            // CORRECCIÓN: Asignar los valores del objeto producto a los TextBox
            NUDStockActual.Text = producto.capdstopro.ToString();
            NUDPrecioMinVenta.Text = producto.capdpremin.ToString();
            NUDPrecioVenta.Text = producto.capdpreven.ToString();
            //CMBCategoria.SelectedItem = producto.cacpnomcat;
            CMBCategoria.SelectedValue = producto.fapdcodcat;
            TXTProductoDescripcion.Text = producto.capddespro;
            if (producto.capdfotpro == "")
            {
                TieneFoto = false;
                PCBFotografia.Image = Resources.no_image;
            }
            else
            {
                TieneFoto = true;
                PCBFotografia.Image = MetodosGenerales.ConvertBase64StringToImage(producto.capdfotpro);
            }
        }

        #endregion

        #region Eventos
        private void BTNSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FRMProducto_Registrar_FormClosing(object sender, FormClosingEventArgs e)
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
                ApagarCamara();
            }
        }

        private void FRMProducto_Registrar_Load(object sender, EventArgs e)
        {
            CargarComboCategorias();
            CargarCombo("capdnompro", CMBProductoNombre);
            CargarCombo("capdmarpro", CMBMarca);
            CargarCombo("capdmatpro", CMBMaterial);
            CargarCombo("capdcolpro", CMBColor);
            CargarCombo("capdtalpro", CMBTalla);

            IniciarCamara();
            if (codProMod != "")
            {
                this.modificar = true;
                JalarDatos();
                LBLRegistrarProducto.Text = "Modificar Producto";
                BTNGrabar.Text = "&Modificar";
                this.Text = "Modificar Producto";
                PPrincipal.Text = "Modificar Producto";
                LBLCodigoDeBarras.Focus();
                if (LBLCodigoDeBarras.Text == "SIN CÓDIGO")
                {
                    LBLCodigoDeBarras.BackColor = Color.Salmon;
                }
            }
            else
            {
                this.modificar = false;
                LimpiarCasillas();
                BTNGrabar.Text = "&Guardar";
                this.Text = "Registrar Producto";
                PPrincipal.Text = "Registrar Producto";
                LBLCodigoDeBarras.Focus();
            }
        }

        private void BTNGrabar_Click(object sender, EventArgs e)
        {
            if (VerificarIntegridad())
            {
                producto = new aproduc();

                if (!this.modificar)
                {
                    //Generar el correlativo
                    correlativo.pxnctipcor = "aproduc";
                    if (correlativo.ObtenerSiguiente())
                    {
                        producto.papdcodpro = correlativo.pxnctipcor + "-" +
                                               correlativo.cxncnumcor.ToString("D12");
                    }
                }
                else
                {
                    producto.papdcodpro = this.codProMod;
                }
                producto.capdestpro = SWBEstadoStock.Value;
                producto.capdgenpro = CMBGenero.Text;
                producto.capdnompro = CMBProductoNombre.Text;
                producto.capddespro = TXTProductoDescripcion.Text;
                producto.capdpreven = decimal.TryParse(NUDPrecioVenta.Text, out decimal precioVenta) ? precioVenta : 0.0m;
                producto.capdpremin = decimal.TryParse(NUDPrecioMinVenta.Text, out decimal precioMinimo) ? precioMinimo : 0.0m;
                producto.capdstopro = int.TryParse(NUDStockActual.Text, out int stock) ? stock : 0;
                //producto.capdfeccre = DTIProductoFechaCreacion.Value;
                //producto.capdfecmod = DTIProductoFechaModificacion.Value;
                producto.capdmarpro = CMBMarca.Text;
                producto.capdcolpro = CMBColor.Text;
                producto.capdtalpro = CMBTalla.Text;
                producto.capdmatpro = CMBMaterial.Text;
                producto.capdmodpro = TXTModelo.Text;
                producto.capdcodbar = LBLCodigoDeBarras.Text;
                if (CMBCategoria.SelectedValue != null)
                {
                    producto.fapdcodcat = CMBCategoria.SelectedValue.ToString();
                }
                else
                {
                    MessageBox.Show("Por favor, seleccione una categoría válida de la lista.",
                                    "Advertencia",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Warning);
                    return; // Detiene la ejecución para que no intente guardar vacío
                }

                //Fotografia del producto
                if (TieneFoto)
                {
                    producto.capdfotpro = MetodosGenerales.ConvertImageToBase64String(PCBFotografia.Image);
                }
                else
                {
                    producto.capdfotpro = "";
                }

                if (codProMod == "")
                {
                    if (producto.Grabar())
                    {
                        MessageBox.Show("Producto guardado correctamente!!",
                                        "Mensaje",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Information);
                        LimpiarCasillas();
                        this.actualizar = true;
                        this.FormClosing -= FRMProducto_Registrar_FormClosing;
                        ApagarCamara();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Producto no se pudo guardar!!",
                                        "Error",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    if (producto.Modificar())
                    {
                        MessageBox.Show("Producto modificado correctamente!!",
                                        "Mensaje",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Information);
                        LimpiarCasillas();
                        this.actualizar = true;
                        this.FormClosing -= FRMProducto_Registrar_FormClosing;
                        ApagarCamara();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Producto no se pudo modificar!!",
                                            "Error",
                                            MessageBoxButtons.OK,
                                            MessageBoxIcon.Warning);
                    }
                }
            }
        }

        private void BTNAbrirFoto_Click(object sender, EventArgs e)
        {
            if (OFDElegirImagen.ShowDialog() == DialogResult.OK)
            {
                PCBFotografia.ImageLocation = OFDElegirImagen.FileName;
                TieneFoto = true;
            }
        }
        #endregion

        #region Metodos para la Camara
        private void DetectarCamaras()
        {
            CaptureDevice = new FilterInfoCollection(FilterCategory.VideoInputDevice);//constructor            
            FinalFrame = new VideoCaptureDevice();
        }

        private void IniciarCamara()
        {
            try
            {
                FinalFrame = new VideoCaptureDevice(CaptureDevice[1].MonikerString);// specified web cam and its filter moniker string
                FinalFrame.NewFrame += new NewFrameEventHandler(FinalFrame_NewFrame);// click button event is fired, 
                FinalFrame.Start();
            }
            catch
            {
                MessageBox.Show("No se tiene una cámara conectada al equipo",
                    "Error de cámara",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void ApagarCamara()
        {
            if (FinalFrame.IsRunning == true) FinalFrame.Stop();
        }
        #endregion

        private void BTNLimpiarFoto_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Está seguro que desea borrar la imagen?",
                            "Pregunta",
                            MessageBoxButtons.YesNo,
                            MessageBoxIcon.Question,
                            MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                TieneFoto = false;
                PCBFotografia.Image = Resources.no_image;
            }
        }
        void FinalFrame_NewFrame(object sender, NewFrameEventArgs eventArgs) // must be void so that it can be accessed everywhere.
                                                                             // New Frame Event Args is an constructor of a class
        {
            PCBCamara.Image = (Bitmap)eventArgs.Frame.Clone();// clone the bitmap
        }

        private void BTNCapturarFoto_Click(object sender, EventArgs e)
        {
            PCBFotografia.Image = PCBCamara.Image;
            TieneFoto = true;
        }

        private void CMBMarca_KeyDown(object sender, KeyEventArgs e)
        {
            bool teclaValida = false;

            if ((e.KeyCode >= Keys.A) && (e.KeyCode <= Keys.Z) && (!e.Alt))
                teclaValida = true;
            else if ((e.KeyCode == Keys.Space) ||
                (e.KeyCode == Keys.Back) ||
                (e.KeyCode == Keys.Delete) ||
                (e.KeyCode == Keys.Left) ||
                (e.KeyCode == Keys.Right) ||
                ((e.KeyCode == Keys.Oem4) && !e.Shift))
                teclaValida = true;
            if (!teclaValida)
            {
                e.SuppressKeyPress = true;
            }
        }

        private void CMBProductoNombre_KeyDown(object sender, KeyEventArgs e)
        {
            bool teclaValida = false;

            if ((e.KeyCode >= Keys.A) && (e.KeyCode <= Keys.Z) && (!e.Alt))
                teclaValida = true;
            else if ((e.KeyCode == Keys.Space) ||
                (e.KeyCode == Keys.Back) ||
                (e.KeyCode == Keys.Delete) ||
                (e.KeyCode == Keys.Left) ||
                (e.KeyCode == Keys.Right) ||
                ((e.KeyCode == Keys.Oem4) && !e.Shift))
                teclaValida = true;
            if (!teclaValida)
            {
                e.SuppressKeyPress = true;
            }
        }

        private void CMBMaterial_KeyDown(object sender, KeyEventArgs e)
        {
            bool teclaValida = false;

            if ((e.KeyCode >= Keys.A) && (e.KeyCode <= Keys.Z) && (!e.Alt))
                teclaValida = true;
            else if ((e.KeyCode == Keys.Space) ||
                (e.KeyCode == Keys.Back) ||
                (e.KeyCode == Keys.Delete) ||
                (e.KeyCode == Keys.Left) ||
                (e.KeyCode == Keys.Right) ||
                ((e.KeyCode == Keys.Oem4) && !e.Shift))
                teclaValida = true;
            if (!teclaValida)
            {
                e.SuppressKeyPress = true;
            }
        }

        private void CMBColor_KeyDown(object sender, KeyEventArgs e)
        {
            bool teclaValida = false;

            if ((e.KeyCode >= Keys.A) && (e.KeyCode <= Keys.Z) && (!e.Alt))
                teclaValida = true;
            else if ((e.KeyCode == Keys.Space) ||
                (e.KeyCode == Keys.Back) ||
                (e.KeyCode == Keys.Delete) ||
                (e.KeyCode == Keys.Left) ||
                (e.KeyCode == Keys.Right) ||
                ((e.KeyCode == Keys.Oem4) && !e.Shift))
                teclaValida = true;
            if (!teclaValida)
            {
                e.SuppressKeyPress = true;
            }
        }

        private void CMBCategoria_KeyDown(object sender, KeyEventArgs e)
        {
            bool teclaValida = false;

            if ((e.KeyCode >= Keys.A) && (e.KeyCode <= Keys.Z) && (!e.Alt))
                teclaValida = true;
            else if ((e.KeyCode == Keys.Space) ||
                (e.KeyCode == Keys.Back) ||
                (e.KeyCode == Keys.Delete) ||
                (e.KeyCode == Keys.Left) ||
                (e.KeyCode == Keys.Right) ||
                ((e.KeyCode == Keys.Oem4) && !e.Shift))
                teclaValida = true;
            if (!teclaValida)
            {
                e.SuppressKeyPress = true;
            }
        }

        private void SWBEstadoStock_ValueChanged(object sender, EventArgs e)
        {
            if (NUDStockActual.Text == "0") SWBEstadoStock.Enabled = false; else SWBEstadoStock.Enabled = true;
        }

        private void BTNLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCasillas();
        }

        private void BTNCodigoDeBarras_Click(object sender, EventArgs e)
        {
            if (!lectorCBHabilitado)
            {
                lectorCBHabilitado = true;
                LBLCodigoDeBarras.Text = "LECTOR ACTIVO";
                LBLCodigoDeBarras.BackColor = Color.PaleGreen;
            }
            else
            {
                if (LBLCodigoDeBarras.Text == "LECTOR ACTIVO")
                {
                    LBLCodigoDeBarras.Text = "SIN CÓDIGO";
                    LBLCodigoDeBarras.BackColor = Color.Salmon;
                }
                else
                {
                    LBLCodigoDeBarras.BackColor = Color.LightBlue;
                }
                lectorCBHabilitado = false;
                TXTModelo.Focus();
            }
        }

        private void BTNCodigoDeBarras_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (LBLCodigoDeBarras.Text == "LECTOR ACTIVO")
            {
                LBLCodigoDeBarras.Text = "" + e.KeyChar;
            }
            else
            {
                LBLCodigoDeBarras.Text += e.KeyChar;
            }
        }

        private void CMBProductoNombre_Enter(object sender, EventArgs e)
        {
            ComboBoxEx a = (ComboBoxEx)sender;
            a.SelectAll();
        }

        private void CMBProductoNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = char.ToUpper(e.KeyChar);
        }

        private void TXTModelo_Enter(object sender, EventArgs e)
        {
            TextBox a = (TextBox)sender;
            a.SelectAll();
        }
    }
}
