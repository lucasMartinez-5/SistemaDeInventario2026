using System;
using CapaRN;
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
    public partial class FRMCompra_Resumen : Form
    {
        #region Variables
        private Control pantallaActual = null;
        private DateTime desde = DateTime.Today;
        private DateTime hasta = DateTime.Today;
        private ToolStripDropDown popupCalendario;
        private MonthCalendar CALFechas;
        #endregion
        public FRMCompra_Resumen()
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
            PCompra_Resumen.Visible = false;
            PCompra_Resumen.Parent.Controls.Add(c);
            c.BringToFront(); pantallaActual = c;
            c.Disposed += PantallaCerrada; c.Show();
        }
        private void PantallaCerrada(object sender, EventArgs e)
        {
            if (IsDisposed || Disposing) return;   // la ventana base se está cerrando
            if (pantallaActual == sender) pantallaActual = null;
            PCompra_Resumen.Visible = true;
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

        private void CargarTotal()
        {
            decimal total = new acompra().Lista("").Sum(c => c.capctotcom);
            LBLMontoInverstionTotal.Text = "Bs. " + total.ToString("N2");
        }
        private void CargarPeriodo()
        {
            string where = "capcfeccom >= '" + 
                            desde.ToString("yyyy-MM-dd") + 
                            "' and capcfeccom < '" + 
                            hasta.AddDays(1).ToString("yyyy-MM-dd") + 
                            "'";
            decimal total = new acompra().Lista(where).Sum(c => c.capctotcom);
            LBLMontoInversionFecha.Text = "Bs. " + total.ToString("N2");
            string f = "dd/MM/yyyy";
            //LBLRangoFechas.Text = desde == hasta ? (desde == DateTime.Today ? "Hoy: " + desde.ToString(f) : desde.ToString(f)) : "Del " + desde.ToString(f) + " al " + hasta.ToString(f);
        }

        private void FRMCompra_Resumen_Load(object sender, EventArgs e)
        {
            
            CALFechas = new MonthCalendar { MaxSelectionCount = 366, FirstDayOfWeek = Day.Monday, Visible = false };
            CALFechas.KeyDown += CALFechas_KeyDown;
            CALFechas.Leave += (s, ev) => CALFechas.Visible = false;
            //BTNElegirFecha.Parent.Controls.Add(CALFechas);
            this.Controls.Add(CALFechas);
            CargarTotal();      // total de todas las compras
            CargarPeriodo();    // por defecto: el día de hoy
        }
        private void CALFechas_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                desde = CALFechas.SelectionStart.Date;
                hasta = CALFechas.SelectionEnd.Date;
                CALFechas.Visible = false;
                CargarPeriodo();
                e.SuppressKeyPress = true;
                LBLRangoFechas.Text = desde == hasta ? (desde == DateTime.Today ? "Hoy: " + desde.ToString("dd/MM/yyyy") : desde.ToString("dd/MM/yyyy")) : "Del " + desde.ToString("dd/MM/yyyy") + " al " + hasta.ToString("dd/MM/yyyy");
            }
            else if (e.KeyCode == Keys.Escape) CALFechas.Visible = false;
        }

        private void BTNElegirFecha_Click(object sender, EventArgs e)
        {
            /*
            CALFechas.Location = new Point(Math.Max(4, Math.Min(BTNElegirFecha.Left, BTNElegirFecha.Parent.ClientSize.Width - CALFechas.Width - 4)), BTNElegirFecha.Bottom + 4);
            CALFechas.SelectionRange = new SelectionRange(desde, hasta);
            CALFechas.Visible = true;
            CALFechas.BringToFront();
            CALFechas.Focus();
            */
            CALFechas.SelectionRange = new SelectionRange(desde, hasta);
            Point p = this.PointToClient(BTNElegirFecha.Parent.PointToScreen(new Point(BTNElegirFecha.Left, BTNElegirFecha.Bottom + 4)));
            CALFechas.Visible = true;                       // al mostrarse toma su tamaño real
            CALFechas.Location = new Point(Math.Max(4, Math.Min(p.X, ClientSize.Width - CALFechas.Width - 4)), Math.Min(p.Y, ClientSize.Height - CALFechas.Height - 4));
            CALFechas.BringToFront();
            CALFechas.Focus();
        }

        private void CALFechas_DateSelected(object sender, DateRangeEventArgs e)
        {
            desde = e.Start.Date;
            hasta = e.End.Date;
            CargarPeriodo();
            MessageBox.Show(e.Start.ToString("dd/MM/yyyy") + " - " + e.End.ToString("dd/MM/yyyy"));
        }

        private void BTNVerDetalles_Click(object sender, EventArgs e)
        {
            AbrirEnPanel(new FRMCompra_Lista_Filtro());
            FRMCompra_Lista_Filtro lista = new FRMCompra_Lista_Filtro();
            lista.desde = desde;     // fecha inicial elegida (o hoy por defecto)
            lista.hasta = hasta;     // fecha final elegida (o hoy por defecto)
            AbrirEnPanel(lista);
        }
    }
}
