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
    public partial class FRMInicioPrincipal : Form
    {
        private Control pantallaActual = null;
        public FRMInicioPrincipal()
        {
            InitializeComponent();
        }

        private void PrecalentarBD()
        {
            try { new CapaRN.aproved().Lista("1 = 0"); } catch { }   // consulta vacía: solo abre y cierra una conexión
        }
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

        private void BTNInventario_Click(object sender, EventArgs e)
        {
            AbrirEnPanel(new FRMProducto_Epica());
            return;
        }

        private void BTNDirectorio_Click(object sender, EventArgs e)
        {
            AbrirEnPanel(new FRMProveedor_Epica());
            return;
        }

        private void FRMInicioPrincipal_Load(object sender, EventArgs e)
        {
            PrecalentarBD();
        }

        private void BTNPuntoDeVenta_Click(object sender, EventArgs e)
        {
            AbrirEnPanel(new FRMVenta_Epica());
            return;
        }

        private void BTNBusquedaAvanzada_Click(object sender, EventArgs e)
        {
            AbrirEnPanel(new FRMProducto_Filtro_Epica());
            return;
        }
    }
}
