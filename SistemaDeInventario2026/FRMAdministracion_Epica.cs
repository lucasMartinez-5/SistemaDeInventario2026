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
    public partial class FRMAdministracion_Epica : Form
    {
        #region Variables
        private Control pantallaActual = null;
        #endregion
        public FRMAdministracion_Epica()
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
            PMenu_Administracion.Visible = false;
            PMenu_Administracion.Parent.Controls.Add(c);
            c.BringToFront(); pantallaActual = c;
            c.Disposed += PantallaCerrada; c.Show();
        }
        private void PantallaCerrada(object sender, EventArgs e)
        {
            if (IsDisposed || Disposing) return;   // la ventana base se está cerrando
            if (pantallaActual == sender) pantallaActual = null;
            PMenu_Administracion.Visible = true;
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
        private void AbrirModificarUsuario(string codigo)
        {
            FRMUsuario_Registrar reg = new FRMUsuario_Registrar();
            reg.modificar = true;
            reg.codUsuMod = codigo;
            AbrirEnPanelConRetorno(reg, () => CrearLista());
        }
        private FRMAdministracion_Usuario_Lista CrearLista()
        {
            FRMAdministracion_Usuario_Lista lista = new FRMAdministracion_Usuario_Lista();
            lista.UsuarioElegido += AbrirModificarUsuario;
            return lista;
        }
        private void BTNRegistrar_Click(object sender, EventArgs e)
        {
            AbrirEnPanel(new FRMAdministracion_Usuario_Registrar());
            return;
        }

        private void BTNVer_Click(object sender, EventArgs e)
        {
            //AbrirEnPanel(new FRMProveedor_Lista());
            AbrirEnPanel(CrearLista());
        }

        private void BTNModificar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Elija un usuario de la lista haciendo doble clic en él.");
            //AbrirEnPanel(new FRMUsuario_Lista());
            AbrirEnPanel(CrearLista());
        }

        private void BTNExtracto_Venta_Click(object sender, EventArgs e)
        {
            AbrirEnPanel(new FRMAdministracion_Extracto_Fecha());
        }
    }
}
