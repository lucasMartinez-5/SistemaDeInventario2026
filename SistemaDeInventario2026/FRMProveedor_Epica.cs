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
    public partial class FRMProveedor_Epica : Form
    {
        public FRMProveedor_Epica()
        {
            InitializeComponent();
            if (this.BTNDirectorio.Image != null)
            {
                this.BTNDirectorio.Image = new Bitmap(this.BTNDirectorio.Image, new Size(24, 24));
            }
            if (this.BTNInventario.Image != null)
            {
                this.BTNInventario.Image = new Bitmap(this.BTNInventario.Image, new Size(24, 24));
            }
            if (this.BTNPuntoDeVenta.Image != null)
            {
                this.BTNPuntoDeVenta.Image = new Bitmap(this.BTNPuntoDeVenta.Image, new Size(24, 24));
            }
            if (this.BTNAdministracionUsuarios.Image != null)
            {
                this.BTNAdministracionUsuarios.Image = new Bitmap(this.BTNAdministracionUsuarios.Image, new Size(24, 24));
            }
            if (this.BTNBusquedaAvanzada.Image != null)
            {
                this.BTNBusquedaAvanzada.Image = new Bitmap(this.BTNBusquedaAvanzada.Image, new Size(24, 24));
            }

            this.PPrincipal.Cursor = Cursors.Default;
        }

        private void materialLabel3_Click(object sender, EventArgs e)
        {

        }

        private void TXTNIT_TextChanged(object sender, EventArgs e)
        {

        }

        private void BTNRegistrar_Click(object sender, EventArgs e)
        {
            FRMProveedor_Registrar a = new FRMProveedor_Registrar();
            a.ShowDialog();
            
        }

        private void BTNVer_Click(object sender, EventArgs e)
        {
            
            FRMProveedor_Lista a = new FRMProveedor_Lista();
            a.Show();
        }

        private void BTNModificar_Click(object sender, EventArgs e)
        {
            FRMProveedor_Lista a = new FRMProveedor_Lista();
            MessageBox.Show("Elija un proveedor de la lista haciendo doble clic en él.");
            a.ShowDialog();
            
        }
    }
}
