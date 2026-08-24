using AForge.Video;
using AForge.Video.DirectShow;
using CapaRN;
using DevComponents.DotNetBar.Controls;
using SistemaDeInventario2026.Properties;
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
    public partial class FRMProveedor_Registrar : DevComponents.DotNetBar.Office2007Form
    {
        #region Variables
        private rproved proveedor = new rproved();
        private xnumcor correlativo = new xnumcor();
        public bool modificar = false;
        public String codPvdMod = "";
        public bool actualizar = false;
        //Variables para la camara
        private FilterInfoCollection CaptureDevice; // list of webcam
        private VideoCaptureDevice FinalFrame;
        private bool TieneFoto = false;
        #endregion

        #region
        public FRMProveedor_Registrar()
        {
            InitializeComponent();
            DetectarCamaras();
        }
        #endregion

        #region Metodos
        private bool VerificarIntegridad()
        {
            bool respuesta = true;
            rproved proveedor2 = new rproved();
            proveedor2.crprnumcid = TXTCI.Text;
            //string cianterior = proveedor.capsnumcid;                           
            //proveedor.capsnumcid = TXTCI.Text;

            if (TXTCI.Text.Replace(" ", "") == "")
            {
                MessageBox.Show("Introduzca el CI del proveedor", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TXTCI.Focus();
                respuesta = false;
            }
            else if (proveedor2.ObtenerDatosCI(modificar, proveedor.crprnumcid))
            {
                MessageBox.Show("Ya existe un proveedor con ese CI", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TXTCI.Focus();
                respuesta = false;
            }
            else if ((TXTApellidoPaterno.Text.Replace(" ", "") == "") &&
                     (TXTApellidoMaterno.Text.Replace(" ", "") == ""))
            {
                MessageBox.Show("Introduzca uno de los APELLIDOS del proveedor", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TXTApellidoPaterno.Focus();
                respuesta = false;
            }
            else if (TXTNombres.Text.Replace(" ", "") == "")
            {
                MessageBox.Show("Introduzca los NOMBRES del proveedor", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TXTNombres.Focus();
                respuesta = false;
            }
            else if (TXTCelular.Text.Replace(" ", "") == "")
            {
                MessageBox.Show("Introduzca el CELULAR del proveedor", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TXTCelular.Focus();
                respuesta = false;
            }
            else if (TXTCorreoElectronico.Text.Replace(" ", "") == "")
            {
                MessageBox.Show("Introduzca un CORREO VÁLIDO del proveedor", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TXTCorreoElectronico.Focus();
                respuesta = false;
            }
            else if (!xgeneral.emailIsValid(TXTCorreoElectronico.Text))
            {
                MessageBox.Show("Introduzca un CORREO VÁLIDO del proveedor", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TXTCorreoElectronico.Focus();
                respuesta = false;
            }
            else if (TXTDireccion.Text.Replace(" ", "") == "")
            {
                MessageBox.Show("Introduzca la DIRECCIÓN del proveedor", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TXTDireccion.Focus();
                respuesta = false;
            }


            return respuesta;
        }

        private void LimpiarCasillas()
        {
            SWBEstado.Value = true;
            TXTCI.Text = "";
        }

        private void JalarDatos()
        {
            proveedor.prprcodpro = this.codPvdMod;
            proveedor.ObtenerDatos();
            SWBEstado.Value = proveedor.crprestpro;
            TXTCI.Text = proveedor.crprnumcid;
            SWBSexo.Value = proveedor.crprsexpro;
            TXTApellidoPaterno.Text = proveedor.crprapepat;
            TXTApellidoMaterno.Text = proveedor.crprapemat;
            TXTNombres.Text = proveedor.crprnompro;
            TXTCelular.Text = proveedor.crprnumcel;
            TXTCorreoElectronico.Text = proveedor.crprcorele;
            TXTDireccion.Text = proveedor.crprdirpro;

            if (proveedor.crprfotpro == "")
            {
                TieneFoto = false;
                PCBFotografia.Image = Resources.no_image;
            }
            else
            {
                TieneFoto = true;
                PCBFotografia.Image = MetodosGenerales.ConvertBase64StringToImage(proveedor.crprfotpro);
            }
        }
        #endregion

        #region Eventos
        private void FRMProveedor_Registrar_Load(object sender, EventArgs e)
        {
            IniciarCamara();
            if (this.modificar)
            {
                JalarDatos();
                BTNGrabar.Text = "&Modificar";
                this.Text = "Modificar Proveedor";
                GPPanelPrincipal.Text = "Modificar Proveedor";
                TXTCI.Focus();
            }
            else
            {
                LimpiarCasillas();
                BTNGrabar.Text = "&Guardar";
                this.Text = "Registrar Proveedor";
                GPPanelPrincipal.Text = "Registrar Proveedor";
                TXTCI.Focus();
            }
        }

        private void BTNSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FRMProveedor_Registrar_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("¿Está seguro que desea cerrar el formulario?",
                                "Pregunta",
                                MessageBoxButtons.YesNo,
                                MessageBoxIcon.Question,
                                MessageBoxDefaultButton.Button2) == DialogResult.No)
            {
                e.Cancel = true;
            }
            else
            {
                ApagarCamara();
            }
        }

        private void TXTCI_Enter(object sender, EventArgs e)
        {
            TextBoxX a = (TextBoxX)sender;
            a.SelectAll();
        }

        private void TXTCelular_TextChanged(object sender, EventArgs e)
        {

        }

        private void TXTCelular_KeyDown(object sender, KeyEventArgs e)
        {
            bool teclaValida = false;

            if ((e.KeyCode >= Keys.NumPad0) && (e.KeyCode <= Keys.NumPad9))
                teclaValida = true;
            else if ((e.KeyCode >= Keys.D0) && (e.KeyCode <= Keys.D9) && !e.Shift)
                teclaValida = true;
            else if
                ((e.KeyCode == Keys.Back) ||
                (e.KeyCode == Keys.Delete) ||
                (e.KeyCode == Keys.Left) ||
                (e.KeyCode == Keys.Right))
                teclaValida = true;

            if (!teclaValida)
            {
                e.SuppressKeyPress = true;
            }
        }

        private void TXTCI_KeyDown(object sender, KeyEventArgs e)
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

        private void TXTApellidoPaterno_KeyDown(object sender, KeyEventArgs e)
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

        private void TXTApellidoMaterno_KeyDown(object sender, KeyEventArgs e)
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

        private void TXTCorreoElectronico_KeyDown(object sender, KeyEventArgs e)
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
                (e.KeyCode == Keys.OemPeriod) ||
                ((e.KeyCode == Keys.OemMinus) && e.Shift) ||
                (e.KeyCode == Keys.Decimal) ||
                ((e.KeyCode == Keys.Q) && e.Alt) ||
                ((e.KeyCode == Keys.Oemplus) && !e.Shift && !e.Alt) ||
                (e.KeyCode == Keys.Add) ||
                ((e.KeyCode == Keys.OemMinus) && !e.Shift))
                teclaValida = true;

            if (!teclaValida)
            {
                e.SuppressKeyPress = true;
            }
        }

        private void BTNGrabar_Click(object sender, EventArgs e)
        {
            if (VerificarIntegridad())
            {
                proveedor = new rproved();

                if (!this.modificar)
                {
                    //Generar el correlativo
                    correlativo.pxnctipcor = "rproved";
                    if (correlativo.ObtenerSiguiente())
                    {
                        proveedor.prprcodpro = correlativo.pxnctipcor + "-" +
                                             correlativo.cxncnumcor.ToString("D12");
                    }
                }
                else
                {
                    proveedor.prprcodpro = this.codPvdMod;
                }
                proveedor.crprestpro = SWBEstado.Value;
                proveedor.crprsexpro = SWBSexo.Value;
                proveedor.crprnumcid = TXTCI.Text;
                proveedor.crprapepat = TXTApellidoPaterno.Text;
                proveedor.crprapemat = TXTApellidoMaterno.Text;
                proveedor.crprnompro = TXTNombres.Text;
                proveedor.crprnumcel = TXTCelular.Text;
                proveedor.crprcorele = TXTCorreoElectronico.Text;
                proveedor.crprdirpro = TXTDireccion.Text;

                //Fotografia del producto
                if (TieneFoto)
                {
                    proveedor.crprfotpro = MetodosGenerales.ConvertImageToBase64String(PCBFotografia.Image);
                }
                else
                {
                    proveedor.crprfotpro = "";
                }

                if (!this.modificar)
                {
                    if (proveedor.Grabar())
                    {
                        MessageBox.Show("proveedor guardada correctamente!!",
                                        "Mensaje",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Information);
                        LimpiarCasillas();
                        this.actualizar = true;
                        this.FormClosing -= FRMProveedor_Registrar_FormClosing;
                        ApagarCamara();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("proveedor no se pudo guardar!!",
                                        "Error",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    if (proveedor.Modificar())
                    {
                        MessageBox.Show("proveedor modificada correctamente!!",
                                        "Mensaje",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Information);
                        LimpiarCasillas();
                        this.actualizar = true;
                        this.FormClosing -= FRMProveedor_Registrar_FormClosing;
                        ApagarCamara();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("proveedor no se pudo modificar!!",
                                            "Error",
                                            MessageBoxButtons.OK,
                                            MessageBoxIcon.Warning);
                    }
                }
            }
        }

        private void BTNAbrirFoto_Click(object sender, EventArgs e)
        {
            if (OFDElegirImagen.ShowDialog() == DialogResult.OK)
            {
                PCBFotografia.ImageLocation = OFDElegirImagen.FileName;
                TieneFoto = true;
            }
        }
        #endregion

        #region Metodos para la Cámara
        private void DetectarCamaras()
        {
            CaptureDevice = new FilterInfoCollection(FilterCategory.VideoInputDevice);//constructor            
            FinalFrame = new VideoCaptureDevice();
        }

        private void IniciarCamara()
        {
            try
            {
                FinalFrame = new VideoCaptureDevice(CaptureDevice[1].MonikerString);// specified web cam and its filter moniker string
                FinalFrame.NewFrame += new NewFrameEventHandler(FinalFrame_NewFrame);// click button event is fired, 
                FinalFrame.Start();
            }
            catch
            {
                MessageBox.Show("No se tiene una cámara conectada al equipo",
                    "Error de cámara",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        void FinalFrame_NewFrame(object sender, NewFrameEventArgs eventArgs) // must be void so that it can be accessed everywhere.
                                                                             // New Frame Event Args is an constructor of a class
        {
            PCBCamara.Image = (Bitmap)eventArgs.Frame.Clone();// clone the bitmap
        }

        private void ApagarCamara()
        {
            if (FinalFrame.IsRunning == true) FinalFrame.Stop();
        }
        #endregion

        private void BTNLimpiarFoto_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Está seguro que desea borrar la imagen?",
                            "Pregunta",
                            MessageBoxButtons.YesNo,
                            MessageBoxIcon.Question,
                            MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                TieneFoto = false;
                PCBFotografia.Image = Resources.no_image;
            }
        }

        private void BTNCapturarFoto_Click(object sender, EventArgs e)
        {
            PCBFotografia.Image = PCBCamara.Image;
            TieneFoto = true;
        }

        private void BTNLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCasillas();
        }
    }
}
