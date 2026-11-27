using CapaRN;
using SistemaDeGestion2026;
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
    public partial class FRMProducto_Lista : Form
    {
        #region Variables
        public string filtro = ""; // Filtro para mostrar solo productos habilitados // condición del catálogo (por defecto, la de siempre)
        private lproduc lproducto = new lproduc();
        private aproduc aproducto = new aproduc();
        private List<lproduc> lista_productos = new List<lproduc>();
        #endregion
        public FRMProducto_Lista()
        {
            InitializeComponent();
        }
        #region Métodos
        public void ActualizarCatalogo()
        {
            FLPCatalogo.Controls.Clear();

            //lista_productos = lproducto.Lista("capdestpro = true");
            lista_productos = lproducto.Lista(filtro);

            foreach (lproduc p in lista_productos)
            {
                UCLProductoCard tarjeta = new UCLProductoCard();
                tarjeta.Tag = p.papdcodpro;

                Image imagen;

                if (p.capdfotpro == "")
                {
                    imagen = Properties.Resources.no_image;
                }
                else
                {
                    imagen = MetodosGenerales.ConvertBase64StringToImage(p.capdfotpro);
                }

                tarjeta.CargarDatos(
                    p.capdnompro,
                    p.capdtalpro,
                    p.capdcolpro,
                    "Bs. " + p.capdpreven.ToString("N2"),
                    p.capdstopro.ToString(),
                    imagen
                );

                FLPCatalogo.Controls.Add(tarjeta);
            }
        }

        private void DesplazarCatalogo(int distancia)
        {
            int posicionActual = -FLPCatalogo.AutoScrollPosition.X;

            int posicionMaxima = Math.Max(
                0,
                FLPCatalogo.DisplayRectangle.Width -
                FLPCatalogo.ClientSize.Width
            );

            int nuevaPosicion = Math.Max(
                0,
                Math.Min(posicionActual + distancia, posicionMaxima)
            );

            FLPCatalogo.AutoScrollPosition =
                new Point(nuevaPosicion, 0);
        }
        #endregion

        private void BTNAnterior_Click(object sender, EventArgs e)
        {
            DesplazarCatalogo(-200);
        }

        private void BTNSiguiente_Click(object sender, EventArgs e)
        {
            DesplazarCatalogo(200);
        }

        private void FRMProducto_Lista_Load(object sender, EventArgs e)
        {
            ActualizarCatalogo();
        }

        private void BTNSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BTNReporte_Click(object sender, EventArgs e)
        {
            xreport reporte = new xreport();
            reporte.titulo = "Reporte de Productos";
            reporte.descripcion = "Listado de Productos registrados en el sistema surmarket";
            reporte.hoja = false;
            reporte.orientacion = true;
            reporte.letra = 12;
            int col = 16;
            float[] anchoColumnas = { 15, 15, 18, 13, 20, 22, 18, 15, 15, 18, 15, 15, 19, 19, 12, 15 };
            List<string> titulosColumnas = new List<string>() { "Código", "Estado", "Nombre", "Talla", "Color", "Marca", "Modelo",
                                                                "Género", "Material" ,"Categoría", "Pre. Min", "Pre. Venta","Fec. Cre", "Fec. Mod", "Stock", "Cod. Bar" };
            reporte.GenerarReporte(col, anchoColumnas, titulosColumnas, lista_productos);
        }
    }
}
