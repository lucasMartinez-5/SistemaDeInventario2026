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
    public partial class FRMVenta_Epica : Form
    {
        private Control pantallaActual = null;
        public FRMVenta_Epica()
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
            PMenu_Venta.Visible = false;
            PMenu_Venta.Parent.Controls.Add(c);
            c.BringToFront(); pantallaActual = c;
            c.Disposed += PantallaCerrada; c.Show();
        }
        private void PantallaCerrada(object sender, EventArgs e)
        {
            if (IsDisposed || Disposing) return;   // la ventana base se está cerrando
            if (pantallaActual == sender) pantallaActual = null;
            PMenu_Venta.Visible = true;
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
        private void AbrirModificarCliente(string codigo)
        {
            FRMCliente_Registrar reg = new FRMCliente_Registrar();
            reg.modificar = true;
            reg.codCliMod = codigo;
            AbrirEnPanelConRetorno(reg, () => CrearLista());
        }
        private FRMCliente_Lista CrearLista()
        {
            FRMCliente_Lista lista = new FRMCliente_Lista();
            lista.ClienteElegido += AbrirModificarCliente;
            return lista;
        }
        private void BTNRegistrar_Click(object sender, EventArgs e)
        {
            AbrirEnPanel(new FRMCliente_Registrar());
            return;
        }

        private void BTNVer_Click(object sender, EventArgs e)
        {
            AbrirEnPanel(CrearLista());
        }

        private void BTNModificar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Elija un cliente de la lista haciendo doble clic en él.");
            //AbrirEnPanel(new FRMProveedor_Lista());
            AbrirEnPanel(CrearLista());
        }

        private void BTNCostoRegistros_Click(object sender, EventArgs e)
        {
            //FRMCompra_Registrar a = new FRMCompra_Registrar();
            //a.ShowDialog();
            AbrirEnPanel(new FRMVenta_Registrar());
            return;
        }

        private void BTNVenta_Lista_Click(object sender, EventArgs e)
        {
            AbrirEnPanel(new FRMVenta_Lista());
        }
    }
}
