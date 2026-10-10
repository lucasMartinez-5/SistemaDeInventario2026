using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaRN;

namespace SistemaDeInventario2026
{
    public partial class FRMCompra_Historial_Grafico : Form
    {
        private readonly string[] nombresMeses = { "Ene", "Feb", "Mar", "Abr", "May", "Jun", "Jul", "Ago", "Sep", "Oct", "Nov", "Dic" };
        public FRMCompra_Historial_Grafico()
        {
            InitializeComponent();
        }
        private void CargarGrafico(int anio)
        {
            List<acompra> compras = new acompra().Lista("extract(year from capcfeccom) = " + anio);
            foreach (var s in CHTCompra_HistorialGrafico.Series) s.Points.Clear();
            for (int m = 1; m <= 12; m++)
            {
                decimal total = compras.Where(c => c.capcfeccom.Month == m).Sum(c => c.capctotcom);
                foreach (var s in CHTCompra_HistorialGrafico.Series) s.Points.AddXY(nombresMeses[m - 1], (double)total);
            }
            decimal totalAnio = compras.Sum(c => c.capctotcom);                     // NUEVA
            LBLSubTitulo.Text = "Cantidad (Bs.): " + totalAnio.ToString("N2");     // NUEVA
        }
        private void CHTCompra_HistorialGrafico_Click(object sender, EventArgs e)
        {

        }

        private void FRMCompra_Historial_Grafico_Load(object sender, EventArgs e)
        {
            /*string[] meses = { "Ene", "Feb", "Mar", "Abr", "May", "Jun", "Jul", "Ago", "Sep", "Oct", "Nov", "Dic" };
            double[] montos = { 5200, 4100, 2600, 1800, 3400, 3900, 3600, 4800, 5600, 4700, 4300, 3500 };   // datos de prueba
            for (int i = 0; i < meses.Length; i++)
            {
                CHTCompra_HistorialGrafico.Series["Area"].Points.AddXY(meses[i], montos[i]);
                CHTCompra_HistorialGrafico.Series["Linea"].Points.AddXY(meses[i], montos[i]);
            }
            */
            NUDAnio.Value = DateTime.Now.Year;
            CargarGrafico((int)NUDAnio.Value);
        }

        private void BTNSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void NUDAnio_ValueChanged(object sender, EventArgs e)
        {

        }

        private void BTNConsultar_Click(object sender, EventArgs e)
        {
            CargarGrafico((int)NUDAnio.Value);
        }
    }
}
