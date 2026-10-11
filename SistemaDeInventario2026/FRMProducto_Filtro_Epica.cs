using AForge.Video.DirectShow;
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
using System;

namespace SistemaDeInventario2026
{
    public partial class FRMProducto_Filtro_Epica : Form
    {
        #region Variables
        private bool lectorCBHabilitado = false;
        private lproduc lproducto = new lproduc();
        private aproduc producto = new aproduc();
        private xnumcor correlativo = new xnumcor();
        public bool modificar = false;
        public String codProMod = "";
        public bool actualizar = false;
        private Control pantallaActual = null;
        #endregion

        #region Constructor
        public FRMProducto_Filtro_Epica()
        {
            InitializeComponent();
        }
        #endregion

        #region Metodos
        // Metodos para mandar la condición de filtrado al formulario de listado de productos
        private string Texto(ComboBox combo)
        {
            return combo.Text.Trim().Replace("'", "''");
        }

        private string ConstruirFiltro()
        {
            string where = "capdestpro = true";

            if (Texto(CMBProductoNombre) != "")
                where += " and capdnompro ilike '%" + Texto(CMBProductoNombre) + "%'";
            if (Texto(CMBMarca) != "")
                where += " and capdmarpro ilike '%" + Texto(CMBMarca) + "%'";
            if (Texto(CMBTalla) != "")
                where += " and lower(capdtalpro) = lower('" + Texto(CMBTalla) + "')";
            if (Texto(CMBColor) != "")
                where += " and lower(capdcolpro) = lower('" + Texto(CMBColor) + "')";
            if (Texto(CMBCategoria) != "")
                where += " and lower(cacpnomcat) = lower('" + Texto(CMBCategoria) + "')";

            return where;
        }
        // Cierre de Metodos para mandar la condición de filtrado al formulario de listado de productos
        private bool CerrarActual()
        {
            if (pantallaActual == null) return true;
            if (pantallaActual is Form f) { f.Close(); if (!f.IsDisposed) return false; }
            else pantallaActual.Dispose();
            pantallaActual = null;
            return true;
        }
        private void AbrirEnPanel(Control c)
        {
            if (!CerrarActual()) return;
            if (c is Form f) { f.TopLevel = false; f.FormBorderStyle = FormBorderStyle.None; }
            c.Dock = DockStyle.Fill;
            PFiltradoAvanzado_Producto.Visible = false;
            PFiltradoAvanzado_Producto.Parent.Controls.Add(c);
            c.BringToFront(); pantallaActual = c;
            c.Disposed += PantallaCerrada; c.Show();
        }
        private void PantallaCerrada(object sender, EventArgs e)
        {
            if (IsDisposed || Disposing) return;
            if (pantallaActual == sender) pantallaActual = null;
            PFiltradoAvanzado_Producto.Visible = true;
        }
        
        /* private bool VerificarIntegridad()
        {
            bool respuesta = true;
            if (CMBProductoNombre.Text.Replace(" ", "") == "" && CMBProductoNombre.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione el nombre de la prenda", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                CMBProductoNombre.Focus();
                respuesta = false;
            }
            else if (CMBMarca.Text.Replace(" ", "") == "" && CMBMarca.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione una marca para la prenda", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                CMBMarca.Focus();
                respuesta = false;
            }
            else if (CMBColor.Text.Replace(" ", "") == "" && CMBColor.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione el color de la prenda", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                CMBColor.Focus();
                respuesta = false;
            }
            else if (CMBTalla.Text.Replace(" ", "") == "" && CMBTalla.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione la talla de la prenda", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                CMBTalla.Focus();
                respuesta = false;
            }
            else if (CMBCategoria.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione una categoria de la prenda", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                CMBCategoria.Focus();
                respuesta = false;
            }
            return respuesta;
        }
        */

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
            CMBProductoNombre.Text = "";
            CMBMarca.Text = "";
            CMBColor.Text = "";
            CMBTalla.Text = "";
            CMBCategoria.SelectedIndex = -1;
        }
        #endregion

        private void FRMProducto_Filtro_Epica_Load(object sender, EventArgs e)
        {
            CargarComboCategorias();
            CargarCombo("capdnompro", CMBProductoNombre);
            CargarCombo("capdmarpro", CMBMarca);
            CargarCombo("capdcolpro", CMBColor);
            CargarCombo("capdtalpro", CMBTalla);
        }

        private void BTNSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FRMProducto_Filtro_Epica_FormClosing(object sender, FormClosingEventArgs e)
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

        private void BTNLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCasillas();
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

        private void BTNBuscar_Click(object sender, EventArgs e)
        {
            //FRMProducto_Lista a = new FRMProducto_Lista();
            //a.ShowDialog();
            FRMProducto_Lista lista = new FRMProducto_Lista();
            lista.filtro = ConstruirFiltro();
            AbrirEnPanel(lista);
        }
    }
}
