using CapaRN;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaDeInventario2026
{
    public partial class FRMAdministracion_Venta_Detalle_Auditoria : Form
    {
        #region Variables
        private Image imgMarca;
        private aventa venta;
        private string nombreCliente;

        // Impresión (PDF)
        private const int CUADRO_PDF = 60;          // lado del cuadro gris
        private const int ALTO_FILA_PDF = 26;       // alto de cada fila de la tabla
        //private readonly float[] anchosPDF = { 0.28f, 0.09f, 0.14f, 0.14f, 0.11f, 0.12f, 0.12f };   // proporción de cada columna
        private readonly float[] anchosPDF = { 0.19f, 0.07f, 0.11f, 0.10f, 0.11f, 0.11f, 0.13f, 0.18f };
        private int filaPDF;
        private bool primeraPaginaPDF;
        private bool detallePendientePDF;
        private Font fRecibo, fBloque, fNegrita, fTexto;
        private SolidBrush bTexto, bGris, bCuadro;
        #endregion
        public FRMAdministracion_Venta_Detalle_Auditoria(aventa venta, string cliente)
        {
            InitializeComponent();
            this.venta = venta;
            this.nombreCliente = cliente;
            CargarDatos();
        }

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
            aclient cliente = new aclient();
            cliente.paclcodcli = venta.fapvcodcli;
            if (cliente.ObtenerDatos())
            {
                nombreCliente = cliente.caclsoccli;
                nit = Convert.ToString(cliente.caclnitcli);
            }

            // Datos de la compra (acompra)
            LBLFecha.Text = venta.capvfecven.ToString("dd/MM/yyyy");
            LBLCliente.Text = nombreCliente;
            LBLNIT.Text = "NIT: " + nit;
            LBLTotal.Text = Bs(venta.capvtotven);

            LBLObservacionesVenta.Text = venta.capvobsven;

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
            DTGDetalleAuditoria.Rows.Clear();
            List<adetventa> detalles = new adetventa().Lista("fapwcodven = '" + venta.papvcodven + "' order by papwcoddet");
            Dictionary<string, aproduc> productos = new Dictionary<string, aproduc>();
            if (detalles.Count > 0)
            {
                string codigos = string.Join(",", detalles.Select(d => "'" + d.fapwcodpro + "'").Distinct());
                productos = new aproduc().Lista("papdcodpro in (" + codigos + ")").ToDictionary(p => p.papdcodpro, p => p);
            }

            foreach (adetventa d in detalles)
            {
                DTGDetalleAuditoria.Rows.Add();
                int f = DTGDetalleAuditoria.Rows.Count - 1;

                aproduc p;
                if (productos.TryGetValue(d.fapwcodpro, out p))
                {
                    DTGDetalleAuditoria[0, f].Value = p.capdnompro;                  // Producto
                    DTGDetalleAuditoria[1, f].Value = p.capdtalpro;                  // Talla
                    DTGDetalleAuditoria[2, f].Value = p.capdcolpro;                  // Color
                    DTGDetalleAuditoria[3, f].Value = p.capdgenpro;                  // Género
                }
                else
                {
                    DTGDetalleAuditoria[0, f].Value = d.fapwcodpro;
                }

                decimal cantidad = Convert.ToDecimal(d.capwcandet);
                DTGDetalleAuditoria[4, f].Value = cantidad.ToString("0.##");         // Cantidad
                DTGDetalleAuditoria[5, f].Value = d.capwpreven.ToString("N2");       // Precio (venta unitario)
                DTGDetalleAuditoria[6, f].Value = (cantidad * d.capwpreven).ToString("N2");   // Sub total = cantidad x precio
                DTGDetalleAuditoria[7, f].Value = string.IsNullOrEmpty(d.capwobsdet) ? "-" : d.capwobsdet;   // Tipo de precio
            }
            LBLFechaAuditoria.Text = LBLFecha.Text;
            LBLClienteAuditoria.Text = LBLCliente.Text;
            LBLNITAuditoria.Text = LBLNIT.Text;
            LBLTotalAuditoria.Text = LBLTotal.Text;
        }
        private string Celda(int fila, int columna)
        {
            object valor = DTGDetalleAuditoria[columna, fila].Value;
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

            imgMarca = null;
            try
            {
                string rutaMarca = Path.Combine(Application.StartupPath, "logo.png");
                if (File.Exists(rutaMarca))
                {
                    using (Image temporal = Image.FromFile(rutaMarca))
                    {
                        imgMarca = new Bitmap(temporal);
                    }
                }
            }
            catch { }
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

            if (imgMarca != null) imgMarca.Dispose();
        }

        private void DibujarMarcaDeAgua(Graphics g, Rectangle pagina)
        {
            if (imgMarca == null) return;

            float escala = Math.Min(pagina.Width * 0.6f / imgMarca.Width, pagina.Height * 0.6f / imgMarca.Height);
            int w = (int)(imgMarca.Width * escala);
            int h = (int)(imgMarca.Height * escala);
            Rectangle destino = new Rectangle(pagina.Left + (pagina.Width - w) / 2,
                                              pagina.Top + (pagina.Height - h) / 2, w, h);

            using (ImageAttributes atributos = new ImageAttributes())
            {
                ColorMatrix matriz = new ColorMatrix();
                matriz.Matrix33 = 0.10f;      // opacidad: 0.10 = 10 % (sube a 0.15 si la quieres más visible)
                atributos.SetColorMatrix(matriz, ColorMatrixFlag.Default, ColorAdjustType.Bitmap);
                g.DrawImage(imgMarca, destino, 0, 0, imgMarca.Width, imgMarca.Height, GraphicsUnit.Pixel, atributos);
            }
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

                    //sf.Alignment = (i >= 4) ? StringAlignment.Far : StringAlignment.Near;
                    sf.Alignment = (i >= 4 && i <= 6) ? StringAlignment.Far : StringAlignment.Near;

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

        private void BTNImprimir_Click(object sender, EventArgs e)
        {
            SaveFileDialog guardar = new SaveFileDialog();
            guardar.Filter = "Archivo PDF (*.pdf)|*.pdf";
            //guardar.FileName = "Recibo_Venta_" + venta.capdfaccom;
            guardar.FileName = "Recibo_Venta_" + venta.papvcodven;
            //
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
                //doc.DocumentName = "Recibo de venta " + venta.capdfaccom;
                doc.DocumentName = "Recibo de venta " + venta.papvcodven;
                //
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
            //
            DibujarMarcaDeAgua(g, e.PageBounds);
            //
            if (primeraPaginaPDF)
            {
                g.DrawString("Recibo de venta", fRecibo, bTexto, m.Left, y);
                y += 60;

                y = DibujarBloque(g, m, y, LBLTituloFecha.Text,
                                  new string[] { LBLFecha.Text }, new bool[] { true }, null);
                y = DibujarBloque(g, m, y, LBLTituloLocal.Text,
                  new string[] { LBLRecibo.Text }, new bool[] { false }, PBXLogo.Image);
                y = DibujarBloque(g, m, y, LBLTituloCliente.Text,
                                  new string[] { LBLCliente.Text, LBLNIT.Text }, new bool[] { false, true }, null);

                // Encabezado del bloque "Detalle de artículo"
                g.FillRectangle(bCuadro, m.Left, y, CUADRO_PDF, CUADRO_PDF);
                g.DrawString(LBLTituloDetalle.Text, fBloque, bTexto, xTabla, y);
                y += 30;
                primeraPaginaPDF = false;
            }

            // Tabla de artículos (si no caben todas las filas, continúa en la página siguiente)
            if (detallePendientePDF)
            {
                string[] encabezados = new string[DTGDetalleAuditoria.Columns.Count];
                for (int i = 0; i < encabezados.Length; i++) encabezados[i] = DTGDetalleAuditoria.Columns[i].HeaderText;
                DibujarFilaTabla(g, xTabla, y, anchoTabla, encabezados, true);
                y += ALTO_FILA_PDF;

                while (filaPDF < DTGDetalleAuditoria.Rows.Count)
                {
                    if (y + ALTO_FILA_PDF > m.Bottom)
                    {
                        e.HasMorePages = true;
                        return;
                    }
                    string[] celdas = new string[DTGDetalleAuditoria.Columns.Count];
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
    }
}
