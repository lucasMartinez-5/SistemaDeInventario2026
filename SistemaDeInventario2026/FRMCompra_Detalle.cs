using CapaRN;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaDeInventario2026
{
    public partial class FRMCompra_Detalle : Form
    {
        #region Variables
        private acompra compra;
        private string nombreProveedor;

        // Impresión (PDF)
        private const int CUADRO_PDF = 60;          // lado del cuadro gris
        private const int ALTO_FILA_PDF = 26;       // alto de cada fila de la tabla
        private readonly float[] anchosPDF = { 0.28f, 0.09f, 0.14f, 0.14f, 0.11f, 0.12f, 0.12f };   // proporción de cada columna
        private int filaPDF;
        private bool primeraPaginaPDF;
        private bool detallePendientePDF;
        private Font fRecibo, fBloque, fNegrita, fTexto;
        private SolidBrush bTexto, bGris, bCuadro;
        #endregion

        #region Constructor
        public FRMCompra_Detalle(acompra compra, string proveedor)
        {
            InitializeComponent();
            this.compra = compra;
            this.nombreProveedor = proveedor;
            CargarDatos();
        }
        #endregion

        #region Métodos
        private string Bs(decimal valor)
        {
            return "Bs. " + valor.ToString("N2");
        }

        // Muestra en el diseño los datos reales de la compra elegida
        private void CargarDatos()
        {
            // Proveedor (razón social y NIT)
            string nit = "";
            aproved proveedor = new aproved();
            proveedor.paprcodpro = compra.faprcodpro;
            if (proveedor.ObtenerDatos())
            {
                nombreProveedor = proveedor.caprsocpro;
                nit = Convert.ToString(proveedor.caprnitpro);
            }

            // Datos de la compra (acompra)
            LBLFecha.Text = compra.capcfeccom.ToString("dd/MM/yyyy");
            LBLFactura.Text = "N° Factura: " + compra.capdfaccom;
            LBLProveedor.Text = nombreProveedor;
            LBLNIT.Text = "NIT: " + nit;
            LBLTotal.Text = Bs(compra.capctotcom);

            // Logo (opcional): si existe el archivo logo.png junto al .exe se muestra en el cuadro
            try
            {
                string ruta = Path.Combine(Application.StartupPath, "logo.png");
                if (File.Exists(ruta))
                {
                    using (Image temporal = Image.FromFile(ruta))
                    {
                        PBXLogo.Image = new Bitmap(temporal);
                    }
                }
            }
            catch { }

            // Líneas de la compra (adetcompra) + datos de sus productos (aproduc) en una sola consulta
            DTGDetalle.Rows.Clear();
            List<adetcompra> detalles = new adetcompra().Lista("fapdcodcom = '" + compra.papccodcom + "' order by papdcoddet");
            Dictionary<string, aproduc> productos = new Dictionary<string, aproduc>();
            if (detalles.Count > 0)
            {
                string codigos = string.Join(",", detalles.Select(d => "'" + d.fapdcodpro + "'").Distinct());
                productos = new aproduc().Lista("papdcodpro in (" + codigos + ")").ToDictionary(p => p.papdcodpro, p => p);
            }

            foreach (adetcompra d in detalles)
            {
                DTGDetalle.Rows.Add();
                int f = DTGDetalle.Rows.Count - 1;

                aproduc p;
                if (productos.TryGetValue(d.fapdcodpro, out p))
                {
                    DTGDetalle[0, f].Value = p.capdnompro;                  // Producto
                    DTGDetalle[1, f].Value = p.capdtalpro;                  // Talla
                    DTGDetalle[2, f].Value = p.capdcolpro;                  // Color
                    DTGDetalle[3, f].Value = p.capdgenpro;                  // Género
                }
                else
                {
                    DTGDetalle[0, f].Value = d.fapdcodpro;
                }

                decimal cantidad = Convert.ToDecimal(d.capdcandet);
                DTGDetalle[4, f].Value = cantidad.ToString("0.##");         // Cantidad
                DTGDetalle[5, f].Value = d.capdprecom.ToString("N2");       // Precio (compra unitario)
                DTGDetalle[6, f].Value = (cantidad * d.capdprecom).ToString("N2");   // Sub total = cantidad x precio
            }
        }
        private string Celda(int fila, int columna)
        {
            object valor = DTGDetalle[columna, fila].Value;
            return valor == null ? "" : valor.ToString();
        }

        private void PrepararImpresion()
        {
            FontFamily familia = this.Font.FontFamily;
            fRecibo = new Font(familia, 22F, FontStyle.Bold);
            fBloque = new Font(familia, 12F, FontStyle.Bold);
            fNegrita = new Font(familia, 9F, FontStyle.Bold);
            fTexto = new Font(familia, 9F);
            bTexto = new SolidBrush(LBLTituloFecha.ForeColor);
            bGris = new SolidBrush(LBLNIT.ForeColor);
            bCuadro = new SolidBrush(PNLCuadroFecha.BackColor);
            filaPDF = 0;
            primeraPaginaPDF = true;
            detallePendientePDF = true;
        }

        private void LiberarImpresion()
        {
            if (fRecibo != null) fRecibo.Dispose();
            if (fBloque != null) fBloque.Dispose();
            if (fNegrita != null) fNegrita.Dispose();
            if (fTexto != null) fTexto.Dispose();
            if (bTexto != null) bTexto.Dispose();
            if (bGris != null) bGris.Dispose();
            if (bCuadro != null) bCuadro.Dispose();
        }

        // Dibuja un bloque del recibo (cuadro gris + título + líneas) y devuelve la posición Y del siguiente
        private int DibujarBloque(Graphics g, Rectangle m, int y, string titulo, string[] lineas, bool[] grises, Image imagen)
        {
            int xTexto = m.Left + CUADRO_PDF + 20;
            int ancho = m.Width - CUADRO_PDF - 20;

            g.FillRectangle(bCuadro, m.Left, y, CUADRO_PDF, CUADRO_PDF);
            if (imagen != null)
            {
                g.DrawImage(imagen, new Rectangle(m.Left, y, CUADRO_PDF, CUADRO_PDF));
            }
            g.DrawString(titulo, fBloque, bTexto, xTexto, y);

            float yy = y + 26;
            for (int i = 0; i < lineas.Length; i++)
            {
                float h = g.MeasureString(lineas[i], fTexto, ancho).Height;
                g.DrawString(lineas[i], fTexto, grises[i] ? bGris : bTexto, new RectangleF(xTexto, yy, ancho, h + 2));
                yy += h + 2;
            }
            return (int)Math.Max(y + CUADRO_PDF, yy) + 24;
        }

        // Dibuja una fila de la tabla de artículos
        private void DibujarFilaTabla(Graphics g, float x, float y, float ancho, string[] celdas, bool encabezado)
        {
            float xc = x;
            for (int i = 0; i < celdas.Length; i++)
            {
                float w = ancho * anchosPDF[i];
                using (StringFormat sf = new StringFormat())
                {
                    sf.Trimming = StringTrimming.EllipsisCharacter;
                    sf.FormatFlags = StringFormatFlags.NoWrap;
                    sf.LineAlignment = StringAlignment.Center;
                    sf.Alignment = (i >= 4) ? StringAlignment.Far : StringAlignment.Near;
                    g.DrawString(celdas[i], encabezado ? fNegrita : fTexto, bTexto,
                                 new RectangleF(xc + 2, y, w - 6, ALTO_FILA_PDF), sf);
                }
                xc += w;
            }
            using (Pen linea = new Pen(encabezado ? bTexto.Color : Color.Gainsboro, 1))
            {
                g.DrawLine(linea, x, y + ALTO_FILA_PDF, x + ancho, y + ALTO_FILA_PDF);
            }
        }
        #endregion

        #region Eventos
        private void BTNImprimir_Click(object sender, EventArgs e)
        {
            SaveFileDialog guardar = new SaveFileDialog();
            guardar.Filter = "Archivo PDF (*.pdf)|*.pdf";
            guardar.FileName = "Recibo_Compra_" + compra.capdfaccom;
            if (guardar.ShowDialog() != DialogResult.OK) return;

            try
            {
                PrintDocument doc = new PrintDocument();
                doc.PrinterSettings.PrinterName = "Microsoft Print to PDF";    // impresora PDF de Windows 10 / 11
                if (!doc.PrinterSettings.IsValid)
                {
                    MessageBox.Show("No se encontró la impresora \"Microsoft Print to PDF\" en este equipo.\n" +
                                    "Actívala en Windows: Configuración > Dispositivos > Impresoras y escáneres.",
                                    "No se puede generar el PDF", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                doc.PrinterSettings.PrintToFile = true;
                doc.PrinterSettings.PrintFileName = guardar.FileName;
                doc.DocumentName = "Recibo de compra " + compra.capdfaccom;
                doc.DefaultPageSettings.Margins = new Margins(70, 70, 70, 70);
                doc.PrintController = new StandardPrintController();           // sin ventana de progreso
                doc.BeginPrint += (s, a) => PrepararImpresion();
                doc.EndPrint += (s, a) => LiberarImpresion();
                doc.PrintPage += Doc_PrintPage;
                doc.Print();

                MessageBox.Show("El recibo se guardó como PDF en:\n" + guardar.FileName,
                                "PDF generado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo generar el PDF.\n" + ex.Message,
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // Dibuja el recibo con la misma distribución del diseño
        private void Doc_PrintPage(object sender, PrintPageEventArgs e)
        {
            Graphics g = e.Graphics;
            Rectangle m = e.MarginBounds;
            int y = m.Top;
            int xTabla = m.Left + CUADRO_PDF + 20;
            int anchoTabla = m.Width - CUADRO_PDF - 20;

            if (primeraPaginaPDF)
            {
                g.DrawString("Recibo de compra", fRecibo, bTexto, m.Left, y);
                y += 60;

                y = DibujarBloque(g, m, y, LBLTituloFecha.Text,
                                  new string[] { LBLFecha.Text }, new bool[] { true }, null);
                y = DibujarBloque(g, m, y, LBLTituloLocal.Text,
                                  new string[] { LBLRecibo.Text, LBLFactura.Text }, new bool[] { false, true }, PBXLogo.Image);
                y = DibujarBloque(g, m, y, LBLTituloProveedor.Text,
                                  new string[] { LBLProveedor.Text, LBLNIT.Text }, new bool[] { false, true }, null);

                // Encabezado del bloque "Detalle de artículo"
                g.FillRectangle(bCuadro, m.Left, y, CUADRO_PDF, CUADRO_PDF);
                g.DrawString(LBLTituloDetalle.Text, fBloque, bTexto, xTabla, y);
                y += 30;
                primeraPaginaPDF = false;
            }

            // Tabla de artículos (si no caben todas las filas, continúa en la página siguiente)
            if (detallePendientePDF)
            {
                string[] encabezados = new string[DTGDetalle.Columns.Count];
                for (int i = 0; i < encabezados.Length; i++) encabezados[i] = DTGDetalle.Columns[i].HeaderText;
                DibujarFilaTabla(g, xTabla, y, anchoTabla, encabezados, true);
                y += ALTO_FILA_PDF;

                while (filaPDF < DTGDetalle.Rows.Count)
                {
                    if (y + ALTO_FILA_PDF > m.Bottom)
                    {
                        e.HasMorePages = true;
                        return;
                    }
                    string[] celdas = new string[DTGDetalle.Columns.Count];
                    for (int i = 0; i < celdas.Length; i++) celdas[i] = Celda(filaPDF, i);
                    DibujarFilaTabla(g, xTabla, y, anchoTabla, celdas, false);
                    y += ALTO_FILA_PDF;
                    filaPDF++;
                }
                detallePendientePDF = false;
                y += 24;
            }

            // Monto total
            if (y + CUADRO_PDF > m.Bottom && y > m.Top)
            {
                e.HasMorePages = true;       // el total pasa a la página siguiente
                return;
            }
            DibujarBloque(g, m, y, LBLTituloTotal.Text, new string[] { LBLTotal.Text }, new bool[] { false }, null);
            e.HasMorePages = false;
        }
        #endregion
    }
}
