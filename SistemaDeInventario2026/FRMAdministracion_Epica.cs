using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;

namespace SistemaDeInventario2026
{
    public partial class FRMAdministracion_Epica : Form
    {
        #region Variables
        private Control pantallaActual = null;

        //variables de conexión a la base de datos
        string servidor = ConfigurationManager.AppSettings.Get("SV");
        string puerto = ConfigurationManager.AppSettings.Get("PT");
        string usuario = ConfigurationManager.AppSettings.Get("US");
        string clave = ConfigurationManager.AppSettings.Get("PW");
        string baseDatos = ConfigurationManager.AppSettings.Get("BD");
        /*
        private const string PG_SERVIDOR = "127.0.0.1";
        private const string PG_PUERTO = "5433";
        private const string PG_USUARIO = "postgres";
        private const string PG_CLAVE = "uajms";
        private const string PG_BASE = "inventario2026";
        */
        private const int DIAS_ALERTA = 7;
        #endregion
        public FRMAdministracion_Epica()
        {
            InitializeComponent();
        }

        #region Métodos de respaldo DataBase
        private string CarpetaRespaldos()
        {
            string ruta = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "Respaldos Local de Dieter");
            Directory.CreateDirectory(ruta); // si ya existe no hace nada
            return ruta;
        }

        private string BuscarPgDump()
        {
            /* Metodo primero
            string[] raices = new string[] {
            Environment.GetEnvironmentVariable("ProgramW6432"),
            Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles),
            Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86) };

            foreach (string raiz in raices)
            {
                if (string.IsNullOrEmpty(raiz)) continue;
                string carpetaPg = Path.Combine(raiz, "PostgreSQL");
                if (!Directory.Exists(carpetaPg)) continue;

                foreach (string version in Directory.GetDirectories(carpetaPg).OrderByDescending(d => d))
                {
                    string exe = Path.Combine(version, "bin", "pg_dump.exe");
                    if (File.Exists(exe)) return exe;
                }
            }
            return null;
            */

            // 1. PRIORIDAD: Leer la ruta desde App.config (la solución definitiva)
            string rutaConfig = ConfigurationManager.AppSettings.Get("PG_DUMP");
            if (!string.IsNullOrEmpty(rutaConfig) && File.Exists(rutaConfig))
            {
                return rutaConfig;
            }

            // 2. RESPALDO: Buscar en el PATH de Windows (si el instalador lo registró)
            string path = Environment.GetEnvironmentVariable("PATH") ?? "";
            foreach (string dir in path.Split(';'))
            {
                if (string.IsNullOrWhiteSpace(dir)) continue;
                try
                {
                    string exe = Path.Combine(dir.Trim(), "pg_dump.exe");
                    if (File.Exists(exe)) return exe;
                }
                catch { }
            }
            // 3. RESPALDO: Buscar en el Registro de Windows (donde PostgreSQL se auto-registra)
            try
            {
                using (var key = Microsoft.Win32.Registry.LocalMachine.OpenSubKey(@"SOFTWARE\PostgreSQL\InstallPaths"))
                {
                    if (key != null)
                    {
                        foreach (string sub in key.GetSubKeyNames())
                        {
                            string baseDir = key.OpenSubKey(sub)?.GetValue("Base") as string;
                            if (string.IsNullOrEmpty(baseDir)) continue;
                            string exe = Path.Combine(baseDir, "bin", "pg_dump.exe");
                            if (File.Exists(exe)) return exe;
                        }
                    }
                }
            }
            catch { }
            // 4. RESPALDO: Buscar en unidades C:, D:, E: (por si acaso no se usó el App.config)
            string[] raices = new string[] { @"C:\", @"D:\", @"E:\" };
            foreach (string raiz in raices)
            {
                try
                {
                    // Busca carpetas que empiecen con "POSTGRESQL" (ignora mayúsculas/minúsculas)
                    foreach (string sub in Directory.GetDirectories(raiz, "POSTGRESQL*"))
                    {
                        string exe = Path.Combine(sub, "bin", "pg_dump.exe");
                        if (File.Exists(exe)) return exe;

                        // Por si hay una carpeta de versión intermedia (ej. POSTGRESQL 4\16\bin)
                        foreach (string version in Directory.GetDirectories(sub))
                        {
                            string exeVer = Path.Combine(version, "bin", "pg_dump.exe");
                            if (File.Exists(exeVer)) return exeVer;
                        }
                    }
                }
                catch { }
            }

            return null; // No se encontró en ningún lado
        }

        private void MostrarEstado()
        {
            FileInfo ultimo = new DirectoryInfo(CarpetaRespaldos())
                .GetFiles("*.backup")
                .OrderByDescending(f => f.LastWriteTime)
                .FirstOrDefault();

            if (ultimo == null)
            {
                LBL.ForeColor = Color.Firebrick;
                // Mostrando en Mensaje en vez de LBL.Text para que sea más visible al usuario
                MessageBox.Show("Aún no se realizó ninguna copia de seguridad.");
                //LBL.Text = "Aún no se realizó ninguna copia de seguridad.";
                return;
            }

            int dias = (int)(DateTime.Now - ultimo.LastWriteTime).TotalDays;
            string hace = dias == 0 ? "hoy" : (dias == 1 ? "hace 1 día" : "hace " + dias + " días");

            LBL.ForeColor = dias <= DIAS_ALERTA ? Color.SeaGreen : Color.Firebrick;
            // Mostrando en Mensaje en vez de LBL.Text para que sea más visible al usuario
            MessageBox.Show("Última copia: " + ultimo.LastWriteTime.ToString("dd/MM/yyyy HH:mm") + " (" + hace + ")" + Environment.NewLine +
                             "Tamaño: " + (ultimo.Length / 1024.0 / 1024.0).ToString("0.00") + " MB" + Environment.NewLine +
                             "Carpeta: " + ultimo.DirectoryName);
            /*
            LBL.Text = "Última copia: " + ultimo.LastWriteTime.ToString("dd/MM/yyyy HH:mm") + " (" + hace + ")" + Environment.NewLine +
                             "Tamaño: " + (ultimo.Length / 1024.0 / 1024.0).ToString("0.00") + " MB" + Environment.NewLine +
                             "Carpeta: " + ultimo.DirectoryName;
            */
            if (dias > DIAS_ALERTA)
                LBL.Text += Environment.NewLine + "Se recomienda crear una copia nueva.";
        }
        #endregion

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
            FRMAdministracion_Usuario_Registrar reg = new FRMAdministracion_Usuario_Registrar();
            reg.modificar = true;
            reg.codUsuMod = codigo;
            AbrirEnPanelConRetorno(reg, () => CrearLista());
        }
        private void AbrirModificarPersona(string codigo)
        {
            FRMPersona_Registrar reg = new FRMPersona_Registrar();
            reg.modificar = true;
            reg.codPerMod = codigo;
            AbrirEnPanelConRetorno(reg, () => CrearListaPersona());
        }
        private FRMAdministracion_Usuario_Lista CrearLista()
        {
            FRMAdministracion_Usuario_Lista lista = new FRMAdministracion_Usuario_Lista();
            lista.UsuarioElegido += AbrirModificarUsuario;
            return lista;
        }
        private FRMPersona_Lista CrearListaPersona()
        {
            FRMPersona_Lista lista = new FRMPersona_Lista();
            lista.PersonaElegida += AbrirModificarPersona;
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

        private void BTNCopiaSeguridad_Click(object sender, EventArgs e)
        {
            string pgDump = BuscarPgDump();
            if (pgDump == null)
            {
                MessageBox.Show("No se encontró PostgreSQL (pg_dump.exe) en este equipo.", "Copia de seguridad", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string archivo = Path.Combine(CarpetaRespaldos(), "LocalDeDieter_" + DateTime.Now.ToString("yyyyMMdd_HHmmss") + ".backup");

            ProcessStartInfo psi = new ProcessStartInfo();
            psi.FileName = pgDump;
            //psi.Arguments = "-h " + PG_SERVIDOR + " -p " + PG_PUERTO + " -U " + PG_USUARIO + " -w -F c -f \"" + archivo + "\" " + PG_BASE;
            psi.Arguments = "-h " + servidor + " -p " + puerto + " -U " + usuario + " -w -F c -f \"" + archivo + "\" " + baseDatos;
            psi.UseShellExecute = false;
            psi.CreateNoWindow = true;
            psi.RedirectStandardError = true;
            psi.EnvironmentVariables["PGPASSWORD"] = clave;

            BTNCopiaSeguridad.Enabled = false;
            this.Cursor = Cursors.WaitCursor;
            try
            {
                using (Process p = Process.Start(psi))
                {
                    string error = p.StandardError.ReadToEnd();
                    p.WaitForExit();

                    if (p.ExitCode == 0 && File.Exists(archivo) && new FileInfo(archivo).Length > 0)
                    {
                        MessageBox.Show("Copia de seguridad realizada correctamente.", "Copia de seguridad", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        MostrarEstado();
                    }
                    else
                    {
                        if (File.Exists(archivo)) File.Delete(archivo);
                        MessageBox.Show("No se pudo crear la copia de seguridad." + Environment.NewLine + error, "Copia de seguridad", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al realizar la copia de seguridad: " + ex.Message, "Copia de seguridad", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                this.Cursor = Cursors.Default;
                BTNCopiaSeguridad.Enabled = true;
            }
        }

        private void BTNEstadoCopiaSeguridad_Click(object sender, EventArgs e)
        {
            MostrarEstado();
        }

        private void BTNVerPersona_Click(object sender, EventArgs e)
        {
            AbrirEnPanel(CrearListaPersona());
        }

        private void BTNRegistrarPersona_Click(object sender, EventArgs e)
        {
            AbrirEnPanel(new FRMPersona_Registrar());
            return;
        }

        private void BTNModificarPersona_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Elija una persona de la lista haciendo doble clic en él.");
            //AbrirEnPanel(new FRMUsuario_Lista());
            AbrirEnPanel(CrearListaPersona());
        }
    }
}
