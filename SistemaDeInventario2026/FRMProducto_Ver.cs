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
    public partial class FRMProducto_Ver : Form
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
        public FRMProducto_Ver()
        {
            InitializeComponent();
        }
        private void CargarComboCategorias()
        {
            List<acatpro> ListaCategorias = new List<acatpro>();
            acatpro categoria = new acatpro();
            ListaCategorias = categoria.Lista("cacpestcat = true order by cacpnomcat");
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
            CMBCategoria.Text = producto.fapdcodcat;
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

        private void FRMProducto_Ver_Load(object sender, EventArgs e)
        {
            LBLRegistrarProducto.Text = "Detalles del Producto";
            LBLRegistrarProducto.ForeColor = Color.Black;
            JalarDatos();
        }

        private void BTNSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
