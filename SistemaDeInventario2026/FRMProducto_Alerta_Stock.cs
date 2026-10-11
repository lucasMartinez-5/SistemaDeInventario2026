using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaDeInventario2026
{
    public partial class FRMProducto_Alerta_Stock : Form
    {
        #region Variables
        public string cantidadMinima;
        public static int StockMinimo = 0;    // compartido por todo el programa: 0 = sin alertas
        #endregion

        #region Constructor
        public FRMProducto_Alerta_Stock()
        {
            InitializeComponent();
        }
        #endregion

        #region Configuración guardada en archivo
        private static string RutaConfiguracion
        {
            get
            {
                string carpeta = Path.Combine(
                    Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData),
                    "SistemaDeInventario2026");
                return Path.Combine(carpeta, "alerta_stock.txt");
            }
        }

        // Se ejecuta una sola vez: recupera el último valor guardado (0 = sin alertas)
        static FRMProducto_Alerta_Stock()
        {
            try
            {
                if (File.Exists(RutaConfiguracion))
                {
                    int valor;
                    if (int.TryParse(File.ReadAllText(RutaConfiguracion).Trim(), out valor) && valor > 0)
                    {
                        StockMinimo = valor;
                    }
                }
            }
            catch
            {
                StockMinimo = 0;
            }
        }

        private static void GuardarStockMinimo(int valor)
        {
            try
            {
                Directory.CreateDirectory(Path.GetDirectoryName(RutaConfiguracion));
                File.WriteAllText(RutaConfiguracion, valor.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo guardar la configuración de alertas.\n" + ex.Message,
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        #endregion

        public void BTNGuardar_Click(object sender, EventArgs e)
        {
            //cantidadMinima = NUDCantidadMinima.Value.ToString();
            if (NUDCantidadMinima.Value <= 0)
            {
                MessageBox.Show("Ingrese una cantidad mínima mayor a 0 para activar las alertas.", "Validación",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                NUDCantidadMinima.Focus();
                return;
            }
            cantidadMinima = NUDCantidadMinima.Value.ToString();
            StockMinimo = (int)NUDCantidadMinima.Value;
            GuardarStockMinimo(StockMinimo);
            MessageBox.Show("Alertas activadas. Se avisará cuando el stock sea igual o menor a " + cantidadMinima + ".",
                            "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void FRMProducto_Alerta_Stock_Load(object sender, EventArgs e)
        {
            //NUDCantidadMinima.Value = int.Parse(cantidadMinima);
            NUDCantidadMinima.Value = StockMinimo;
        }

        private void BTNCancelar_Click(object sender, EventArgs e)
        {
            StockMinimo = 0;
            GuardarStockMinimo(0);
            NUDCantidadMinima.Value = 0;
            cantidadMinima = "0";
            MessageBox.Show("Alertas desactivadas.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BTNSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
