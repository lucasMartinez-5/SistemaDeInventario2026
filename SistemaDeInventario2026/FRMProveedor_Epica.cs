using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SistemaDeInventario2026
{
    public partial class FRMProveedor_Epica : Form
    {
        #region Variables
        private Control pantallaActual = null;
        #endregion

        #region Constructor
        public FRMProveedor_Epica()
        {
            InitializeComponent();
            LBLGestionProveedor.ForeColor = System.Drawing.Color.Black;
            LBLGestionProveedorInvPro.ForeColor = System.Drawing.Color.Black;
            this.PPrincipal.Cursor = Cursors.Default;
        }
        #endregion

        #region Metodos
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
            PMenu_Proveedor.Visible = false;
            PMenu_Proveedor.Parent.Controls.Add(c);
            c.BringToFront(); pantallaActual = c;
            c.Disposed += PantallaCerrada; c.Show();
        }
        private void PantallaCerrada(object sender, EventArgs e)
        {
            if (IsDisposed || Disposing) return;   // la ventana base se está cerrando
            if (pantallaActual == sender) pantallaActual = null;
            PMenu_Proveedor.Visible = true;
        }
        private void AbrirEnPanelConRetorno(Control c, Func<Control> anterior)
        {
            AbrirEnPanel(c);
            c.Disposed -= PantallaCerrada;      // este reemplaza al de siempre
            c.Disposed += (s, e) =>
            {
                if (pantallaActual == (Control)s) pantallaActual = null;
                if (!IsDisposed && !Disposing) BeginInvoke(new Action(() => AbrirEnPanel(anterior())));
            };
        }
        private void AbrirModificarProveedor(string codigo)
        {
            FRMProveedor_Registrar reg = new FRMProveedor_Registrar();
            reg.modificar = true;
            reg.codPveMod = codigo;
            AbrirEnPanelConRetorno(reg, () => CrearLista());
        }
        private FRMProveedor_Lista CrearLista()
        {
            FRMProveedor_Lista lista = new FRMProveedor_Lista();
            lista.ProveedorElegido += AbrirModificarProveedor;
            return lista;
        }
        
        
        #endregion

        #region Eventos
        #endregion

        private void PPrincipal_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BTNInventario_Click(object sender, EventArgs e)
        {
            AbrirEnPanel(new FRMProducto_Epica());
        }

        private void BTNCostoRegistros_Click(object sender, EventArgs e)
        {
            //FRMCompra_Registrar a = new FRMCompra_Registrar();
            //a.ShowDialog();
            AbrirEnPanel(new FRMCompra_Registrar());
            return;
        }

        private void BTNRegistrar_Click(object sender, EventArgs e)
        {
            AbrirEnPanel(new FRMProveedor_Registrar());
            return;
        }

        private void BTNVer_Click(object sender, EventArgs e)
        {
            //AbrirEnPanel(new FRMProveedor_Lista());
            AbrirEnPanel(CrearLista());
        }

        private void BTNModificar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Elija un proveedor de la lista haciendo doble clic en él.");
            //AbrirEnPanel(new FRMProveedor_Lista());
            AbrirEnPanel(CrearLista());
        }

        private void BTNDirectorio_Click(object sender, EventArgs e)
        {

        }
    }
}
