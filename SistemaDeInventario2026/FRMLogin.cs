using CapaRN;
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
    public partial class FRMLogin : Form
    {
        #region Variables
        public aususis usuario = new aususis();
        public aperson persona = new aperson();
        public bool loginExitoso = false;
        public bool actualizarPassword = false;

        private Control pantallaActual = null;
        #endregion

        public FRMLogin()
        {
            InitializeComponent();
        }

        #region Metodos
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
            PLogin.Visible = false;
            PLogin.Parent.Controls.Add(c);
            c.BringToFront(); pantallaActual = c;
            c.Disposed += PantallaCerrada; c.Show();
        }
        private void PantallaCerrada(object sender, EventArgs e)
        {
            /*
            if (IsDisposed || Disposing) return;   // la ventana base se está cerrando
            if (pantallaActual == sender) pantallaActual = null;
            PLogin.Visible = true;
            */
            if (IsDisposed || Disposing) return;   // la ventana base se está cerrando
            if (pantallaActual == sender) pantallaActual = null;

            // AGREGADO: huella reconocida -> entrar al sistema
            FRMLogin_Huella huella = sender as FRMLogin_Huella;
            if (huella != null && huella.loginExitoso)
            {
                this.BeginInvoke(new Action(IngresarConHuella));
                return;
            }

            PLogin.Visible = true;
        }
        private bool VerificarIntegridad()
        {
            bool respuesta = true;

            if (TXTLoginUsuario.Text.Replace(" ", "") == "")
            {
                MessageBox.Show("Introduzca el LOGIN del usuario", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TXTLoginUsuario.Focus();
                respuesta = false;
            }
            else if (TXTPassword.Text.Replace(" ", "") == "")
            {
                MessageBox.Show("Introduzca el PASSWORD del usuario", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TXTPassword.Focus();
                respuesta = false;
            }

            return respuesta;
        }

        private void AplicarPrivilegios()
        {
            panel2.Enabled = true;
            BTNDirectorio.Visible = SesionActual.PuedeAcceder(SesionActual.SECCION_INVERSION);
            BTNInventario.Visible = SesionActual.PuedeAcceder(SesionActual.SECCION_INVENTARIO);
            BTNBusquedaAvanzada.Visible = SesionActual.PuedeAcceder(SesionActual.SECCION_BUSQUEDA);
            BTNPuntoDeVenta.Visible = SesionActual.PuedeAcceder(SesionActual.SECCION_VENTAS);
            BTNAdministracionUsuarios.Visible = SesionActual.PuedeAcceder(SesionActual.SECCION_USUARIOS);
        }
        private void IngresarConHuella()
        {
            loginExitoso = true;
            actualizarPassword = false;
            AplicarPrivilegios();
            AbrirEnPanel(new FRMInicioPrincipal());
        }
        #endregion

        #region Eventos

        private void BTNCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BTNMostrarPassword_Click(object sender, EventArgs e)
        {
            if (TXTPassword.PasswordChar == '*')
            {
                TXTPassword.PasswordChar = '\0';
            }
            else
            {
                TXTPassword.PasswordChar = '*';
            }
        }

        #endregion

        private void BTNIngresar_Click(object sender, EventArgs e)
        {

            if (VerificarIntegridad())
            {
                usuario.causnomlog = TXTLoginUsuario.Text;
                if (!usuario.ObtenerDatosLogin(false, TXTLoginUsuario.Text))
                {
                    MessageBox.Show("El usuario no existe", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    TXTLoginUsuario.Focus();
                    return;
                }
                if (!usuario.causestusu)
                {
                    MessageBox.Show("El usuario está deshabilitado. Comuníquese con el administrador", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    TXTLoginUsuario.Focus();
                    return;
                }

                persona.papscodper = usuario.fauscodper;
                persona.ObtenerDatos();

                if (usuario.causactpas)
                {
                    if (TXTPassword.Text == persona.capsnumcid)
                    {
                        MessageBox.Show("Bienvenido " + persona.capsnomper + " " +
                                                        persona.capsapepat + " " +
                                                        persona.capsapemat,
                                        "Validación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        loginExitoso = true;
                        actualizarPassword = true;
                        FRMAdministracion_Modificar_Contraseña cambioPassword = new FRMAdministracion_Modificar_Contraseña();
                        cambioPassword.ausuario = usuario;
                        AbrirEnPanel(cambioPassword);
                    }
                    else
                    {
                        MessageBox.Show("Contraseña incorrecta", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        TXTPassword.Focus();
                    }
                }
                else
                {
                    if ((TXTPassword.Text == usuario.causpasswo) && (TXTPassword.Text != persona.capsnumcid))
                    {
                        MessageBox.Show("Bienvenido " + persona.capsnomper + " " +
                                                        persona.capsapepat + " " +
                                                        persona.capsapemat,
                                        "Validación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        loginExitoso = true;
                        actualizarPassword = false;
                        SesionActual.CodigoUsuario = usuario.pauscodusu;
                        SesionActual.NombreUsuario = usuario.causnomlog;
                        SesionActual.Rol = usuario.causrolusu;
                        AplicarPrivilegios();
                        SesionActual.NombreUsuario = persona.capsapepat + " " + persona.capsapemat + " " + persona.capsnomper;
                        AbrirEnPanel(new FRMInicioPrincipal());
                        LBLUsuario_Sesion.Text = "Usuario: " + SesionActual.NombreUsuario;
                        /*
                        LBLUsuario_Sesion.Text = "Usuario: " +
                            persona.capsapepat + " " +
                            persona.capsapemat + " " +
                            persona.capsnomper;
                        */
                    }
                    else
                    {
                        MessageBox.Show("Contraseña incorrecta", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        TXTPassword.Focus();
                    }
                }
            }
        }

        private void FRMLogin_Load(object sender, EventArgs e)
        {
            PrecalentarBD();
            TMReloj.Enabled = true;
            /*
            LBLUsuario_Sesion.Text = "Usuario: " +
                            persona.capsapepat + " " +
                            persona.capsapemat + " " +
                            persona.capsnomper;
            */
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

        private void BTNAdministracionUsuarios_Click(object sender, EventArgs e)
        {
            AbrirEnPanel(new FRMAdministracion_Epica());
            return;
        }

        private void BTNLoginHuella_Click(object sender, EventArgs e)
        {
            AbrirEnPanel(new FRMLogin_Huella());
            
        }

        private void TMReloj_Tick(object sender, EventArgs e)
        {
            LBLFecha_Sesion.Text = DateTime.Now.ToString("F");
        }
    }
}
