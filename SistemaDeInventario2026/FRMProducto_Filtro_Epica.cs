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

            if (Texto(CMBProductoNombre.ComboBox) != "")
                where += " and capdnompro ilike '%" + Texto(CMBProductoNombre.ComboBox) + "%'";
            if (Texto(CMBMarca.ComboBox) != "")
                where += " and capdmarpro ilike '%" + Texto(CMBMarca.ComboBox) + "%'";
            if (Texto(CMBTalla.ComboBox) != "")
                where += " and lower(capdtalpro) = lower('" + Texto(CMBTalla.ComboBox) + "')";
            if (Texto(CMBColor.ComboBox) != "")
                where += " and lower(capdcolpro) = lower('" + Texto(CMBColor.ComboBox) + "')";
            if (Texto(CMBCategoria.ComboBox) != "")
                where += " and lower(cacpnomcat) = lower('" + Texto(CMBCategoria.ComboBox) + "')";

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

        public void ComboBoxEx_DrawItem(object sender, DrawItemEventArgs e, Color colorSeleccion, Color colorTexto)
        {
            ComboBoxEx combo = (ComboBoxEx)sender;

            // Fondo por defecto (blanco)
            e.DrawBackground();

            // Si el item está seleccionado o el mouse está sobre él
            if ((e.State & DrawItemState.Selected) == DrawItemState.Selected ||
                (e.State & DrawItemState.Focus) == DrawItemState.Focus)
            {
                // Pintar fondo azul sólido
                using (SolidBrush brush = new SolidBrush(colorSeleccion))
                {
                    e.Graphics.FillRectangle(brush, e.Bounds);
                }
            }
            else
            {
                // Fondo blanco normal
                using (SolidBrush brush = new SolidBrush(Color.White))
                {
                    e.Graphics.FillRectangle(brush, e.Bounds);
                }
            }

            // Dibujar el texto
            string texto = combo.Items[e.Index]?.ToString() ?? "";
            using (SolidBrush textBrush = new SolidBrush(colorTexto))
            {
                e.Graphics.DrawString(texto, e.Font, textBrush, e.Bounds.X + 2, e.Bounds.Y + 2);
            }

            // Dibujar borde de foco (opcional)
            e.DrawFocusRectangle();
        }
        #endregion

        private void FRMProducto_Filtro_Epica_Load(object sender, EventArgs e)
        {
            // Color azul sólido (igual que tus grids)
            Color colorAzul = Color.DodgerBlue;
            Color colorTexto = Color.Black;

            // Configurar todos los KryptonComboBox del formulario
            foreach (Control c in this.Controls)
            {
                if (c is Krypton.Toolkit.KryptonComboBox combo)
                {
                    // Color de fondo cuando el mouse está sobre el item (hover)
                    combo.StateTracking.Item.Back.Color1 = colorAzul;
                    combo.StateTracking.Item.Back.Color2 = colorAzul; // Mismo color para evitar degradado
                    combo.StateTracking.Item.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;

                    // Color del texto cuando el mouse está sobre el item
                    combo.StateTracking.Item.Content.ShortText.Color1 = colorTexto;
                    combo.StateTracking.Item.Content.ShortText.Color2 = colorTexto;

                    // Color de fondo normal (cuando no hay hover)
                    combo.StateCommon.Item.Back.Color1 = Color.White;
                    combo.StateCommon.Item.Back.Color2 = Color.White;
                    combo.StateCommon.Item.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;

                    // Color del texto normal
                    combo.StateCommon.Item.Content.ShortText.Color1 = colorTexto;
                    combo.StateCommon.Item.Content.ShortText.Color2 = colorTexto;
                }
            }

            LBLBuscarPor.ForeColor = Color.Black;
            LBLOpcionesFiltro.ForeColor = Color.Black;
            CargarComboCategorias();
            CargarCombo("capdnompro", CMBProductoNombre.ComboBox);
            CargarCombo("capdmarpro", CMBMarca.ComboBox);
            CargarCombo("capdcolpro", CMBColor.ComboBox);
            CargarCombo("capdtalpro", CMBTalla.ComboBox);
        }

        private void BTNSalir_Click(object sender, EventArgs e)
        {
            this.Close();
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
            //ComboBox a = (ComboBox)sender;
            //a.SelectAll();
            if (sender is ComboBox a)
            {
                a.SelectAll();
            }
            else if (sender is Krypton.Toolkit.KryptonComboBox ka)
            {
                ka.SelectAll();
            }
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
