using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace SistemaDeInventario2026
{
    public partial class FRMProveedor_Epica : Form
    {
        #region Variables
        #endregion

        #region Constructor
        public FRMProveedor_Epica()
        {
            InitializeComponent();
            /*if (this.BTNDirectorio.Image != null)
            {
                this.BTNDirectorio.Image = new Bitmap(this.BTNDirectorio.Image, new Size(40, 40));
            }
            if (this.BTNPuntoDeVenta.Image != null)
            {
                this.BTNPuntoDeVenta.Image = new Bitmap(this.BTNPuntoDeVenta.Image, new Size(32, 32));
            }
            if (this.BTNAdministracionUsuarios.Image != null)
            {
                this.BTNAdministracionUsuarios.Image = new Bitmap(this.BTNAdministracionUsuarios.Image, new Size(32, 32));
            }
            if (this.BTNBusquedaAvanzada.Image != null)
            {
                this.BTNBusquedaAvanzada.Image = new Bitmap(this.BTNBusquedaAvanzada.Image, new Size(24, 24));
            }
            */
            LBLGestionProveedor.ForeColor = System.Drawing.Color.Black;
            LBLGestionProveedorInvPro.ForeColor = System.Drawing.Color.Black;
            this.PPrincipal.Cursor = Cursors.Default;
        }
        #endregion

        #region Metodos
        #endregion

        #region Eventos
        private void BTNRegistrar_Click(object sender, EventArgs e)
        {
            FRMProveedor_Registrar a = new FRMProveedor_Registrar();
            a.ShowDialog();
            
        }

        private void BTNVer_Click(object sender, EventArgs e)
        {
            FRMDirectorioProveedor a = new FRMDirectorioProveedor();
            a.Show();
        }

        private void BTNModificar_Click(object sender, EventArgs e)
        {
            FRMDirectorioProveedor a = new FRMDirectorioProveedor();
            MessageBox.Show("Elija un proveedor de la lista haciendo doble clic en él.");
            a.ShowDialog();
            
        }
        #endregion

        private void PPrincipal_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BTNInventario_Click(object sender, EventArgs e)
        {
            FRMProducto_Epica a = new FRMProducto_Epica();
            a.ShowDialog();
        }

        private void BTNCostoRegistros_Click(object sender, EventArgs e)
        {
            FRMCompra_Registrar a = new FRMCompra_Registrar();
            a.ShowDialog();
        }
    }
}
