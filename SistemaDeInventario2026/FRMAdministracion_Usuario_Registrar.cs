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

namespace SistemaDeInventario2026
{
    public partial class FRMAdministracion_Usuario_Registrar : Form
    {
        #region Variables
        private aususis usuario = new aususis();
        private aperson persona = new aperson();
        private bool personaOk = false;
        private xnumcor correlativo = new xnumcor();
        public bool modificar = false;
        public String codUsuMod = "";
        public bool actualizar = false;
        #endregion

        #region Constructor
        public FRMAdministracion_Usuario_Registrar()
        {
            InitializeComponent();
        }
        #endregion

        #region Métodos
        private bool VerificarIntegridad()
        {
            bool respuesta = true;

            aususis usuario2 = new aususis();
            usuario2.causnomlog = TXTLoginUsuario.Text;
            aperson persona2 = new aperson();
            persona2.capsnumcid = TXTCI.Text;

            if (TXTCI.Text.Replace(" ", "") == "")
            {
                MessageBox.Show("Introduzca el CI de la persona", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TXTCI.Focus();
                respuesta = false;
            }
            else if (TXTLoginUsuario.Text.Replace(" ", "") == "")
            {
                MessageBox.Show("Introduzca el LOGIN del usuario", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TXTLoginUsuario.Focus();
                respuesta = false;
            }// condicion para retringir LOGIN ajeno al modificar o registrar
            else if (usuario2.ObtenerDatosLogin(modificar, usuario.causnomlog))
            {
                MessageBox.Show("Ya existe una persona con ese LOGIN", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TXTLoginUsuario.Focus();
                respuesta = false;
            }
            else if (TXTRol.Text.Replace(" ", "") == "")
            {
                MessageBox.Show("Introduzca el rol del usuario", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TXTRol.Focus();
                respuesta = false;
            }
            else if (TXTNombreCompleto.Text.Replace(" ", "") == "")
            {
                MessageBox.Show("Introduzca el nombre completo de la persona", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TXTNombreCompleto.Focus();
                respuesta = false;
            }

            return respuesta;
        }
        private void LimpiarCasillas()
        {
            SWBEstado.Value = true;
            TXTRol.Text = "";
            TXTCI.Text = "";
            TXTNombreCompleto.Text = "Nombre Completo";
            TXTLoginUsuario.Text = "";
            DPECHuellas.EnrolledFingerMask = 0;
            TXTLoginUsuario.Focus();
        }
        private void JalarDatos()
        {
            usuario.pauscodusu = this.codUsuMod;
            usuario.ObtenerDatos();
            persona.papscodper = usuario.fauscodper;
            persona.ObtenerDatos();
            SWBEstado.Value = usuario.causestusu;
            TXTCI.Text = persona.capsnumcid;
            TXTNombreCompleto.Text = persona.capsapepat + " " +
                                persona.capsapemat + " " +
                                persona.capsnomper;
            DPECHuellas.EnrolledFingerMask = usuario.causmashue;
            TXTLoginUsuario.Text = usuario.causnomlog;
            TXTRol.Text = usuario.causrolusu;
        }

        #endregion

        private void BTNSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FRMAdministracion_Usuario_Registrar_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("¿Está seguro que desea cerrar el formulario?",
                                "Pregunta",
                                MessageBoxButtons.YesNo,
                                MessageBoxIcon.Question,
                                MessageBoxDefaultButton.Button2) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
        /*
        private void TXTCI_Enter(object sender, EventArgs e)
        {
            TextBoxX a = (TextBoxX)sender;
            a.SelectAll();
        }
        */

        private void FRMAdministracion_Usuario_Registrar_Load(object sender, EventArgs e)
        {
            if (this.modificar)
            {
                JalarDatos();
                BTNGrabar.Text = "&Modificar";
                this.Text = "Modificar Usuario";
                PAgregar_Usuario.Text = "Modificar Usuario";
                TXTCI.Focus();
            }
            else
            {
                LimpiarCasillas();
                BTNGrabar.Text = "&Guardar";
                this.Text = "Registrar Usuario";
                PAgregar_Usuario.Text = "Registrar Usuario";
                TXTCI.Focus();
            }
        }

        private void TXTLoginUsuario_KeyDown(object sender, KeyEventArgs e)
        {
            bool teclaValida = false;

            if ((e.KeyCode >= Keys.NumPad0) && (e.KeyCode <= Keys.NumPad9))
                teclaValida = true;
            else if ((e.KeyCode >= Keys.D0) && (e.KeyCode <= Keys.D9) && !e.Shift)
                teclaValida = true;
            else if ((e.KeyCode >= Keys.A) && (e.KeyCode <= Keys.Z) && (!e.Alt))
                teclaValida = true;
            else if ((e.KeyCode == Keys.Subtract) ||
                (e.KeyCode == Keys.Back) ||
                (e.KeyCode == Keys.Delete) ||
                (e.KeyCode == Keys.Left) ||
                (e.KeyCode == Keys.Right) ||
                ((e.KeyCode == Keys.OemMinus) && !e.Shift))
                teclaValida = true;

            if (!teclaValida)
            {
                e.SuppressKeyPress = true;
            }
        }

        private void BTNBuscarUsuario_Click(object sender, EventArgs e)
        {
            FRMPersona_Buscar a = new FRMPersona_Buscar();
            a.ShowDialog();
            if (a.seleccionadoOk)
            {
                this.persona = a.persona;
                this.personaOk = true;
                TXTCI.Text = persona.capsnumcid;
                TXTNombreCompleto.Text = persona.capsapepat + " " +
                                  persona.capsapemat + " " +
                                  persona.capsnomper;
            }
            else
            {
                this.personaOk = false;
                TXTCI.Text = "";
                TXTNombreCompleto.Text = "Nombre Completo";
            }
        }

        private void BTNGrabar_Click(object sender, EventArgs e)
        {
            if (VerificarIntegridad())
            {

                if (!this.modificar)
                {
                    //Generar el correlativo
                    correlativo.pxnctipcor = "aususis";
                    if (correlativo.ObtenerSiguiente())
                    {
                        usuario.pauscodusu = correlativo.pxnctipcor + "-" +
                                             correlativo.cxncnumcor.ToString("D12");
                    }
                }
                else
                {
                    usuario.causestusu = SWBEstado.Value;
                }
                usuario.causactpas = false;
                usuario.causnomlog = TXTLoginUsuario.Text;
                usuario.causrolusu = TXTRol.Text;

                if (!modificar)
                {
                    usuario.causactpas = true;
                }
                usuario.causmashue = DPECHuellas.EnrolledFingerMask;
                usuario.fauscodper = persona.papscodper;

                if (!this.modificar)
                {
                    if (usuario.Grabar())
                    {
                        MessageBox.Show("Usuario guardado correctamente!!",
                                        "Mensaje",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Information);
                        LimpiarCasillas();
                        this.actualizar = true;
                        this.FormClosing -= FRMAdministracion_Usuario_Registrar_FormClosing;
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Usuario no se pudo guardar!!",
                                        "Error",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    if (usuario.ModificarDatos())
                    {
                        MessageBox.Show("Usuario modificado correctamente!!",
                                        "Mensaje",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Information);
                        LimpiarCasillas();
                        this.actualizar = true;
                        this.FormClosing -= FRMAdministracion_Usuario_Registrar_FormClosing;
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Usuario no se pudo modificar!!",
                                            "Error",
                                            MessageBoxButtons.OK,
                                            MessageBoxIcon.Warning);
                    }
                }
            }
        }

        private void DPECHuellas_OnDelete(object Control, int FingerMask, ref DPFP.Gui.EventHandlerStatus EventHandlerStatus)
        {
            if (usuario.causnumhu1 == FingerMask)
            {
                usuario.causnumhu1 = 0;
                usuario.causcodhu1 = "";
            }
            else if (usuario.causnumhu2 == FingerMask)
            {
                usuario.causnumhu2 = 0;
                usuario.causcodhu2 = "";
            }
            else if (usuario.causnumhu3 == FingerMask)
            {
                usuario.causnumhu3 = 0;
                usuario.causcodhu3 = "";
            }
        }

        private void DPECHuellas_OnEnroll(object Control, int FingerMask, DPFP.Template Template, ref DPFP.Gui.EventHandlerStatus EventHandlerStatus)
        {
            byte[] aux = new byte[1700];
            Template.Serialize(ref aux);
            string cadena = Convert.ToBase64String(aux);

            if (usuario.causnumhu1 == 0)
            {
                usuario.causnumhu1 = FingerMask;
                usuario.causcodhu1 = cadena;
            }
            else if (usuario.causnumhu2 == 0)
            {
                usuario.causnumhu2 = FingerMask;
                usuario.causcodhu2 = cadena;
            }
            else if (usuario.causnumhu3 == 0)
            {
                usuario.causnumhu3 = FingerMask;
                usuario.causcodhu3 = cadena;
            }
        }
    }
}
