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
    public partial class FRMProducto_Epica : Form
    {
        private Control pantallaActual = null;
        public FRMProducto_Epica()
        {
            InitializeComponent();
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
            PMenu_Producto.Visible = false;
            PMenu_Producto.Parent.Controls.Add(c);
            c.BringToFront(); pantallaActual = c;
            c.Disposed += PantallaCerrada; c.Show();
        }
        private void PantallaCerrada(object sender, EventArgs e)
        {
            if (IsDisposed || Disposing) return;
            if (pantallaActual == sender) pantallaActual = null;
            PMenu_Producto.Visible = true;
        }

        private void FRMProducto_Epica_Load(object sender, EventArgs e)
        {

        }

        private void BTNDirectorio_Click(object sender, EventArgs e)
        {
            FRMProveedor_Registrar a = new FRMProveedor_Registrar();
            a.ShowDialog();
        }

        private void PCBLista_Producto_Click(object sender, EventArgs e)
        {
            //FRMProducto_Lista a = new FRMProducto_Lista();
            //a.ShowDialog();
            AbrirEnPanel(new FRMProducto_Lista());
            return;
        }

        private void PCBAgregar_Producto_Click(object sender, EventArgs e)
        {
            //FRMProducto_Registrar a = new FRMProducto_Registrar();
            //a.ShowDialog();
            AbrirEnPanel(new FRMProducto_Registrar());
            return;
        }
    }
}
