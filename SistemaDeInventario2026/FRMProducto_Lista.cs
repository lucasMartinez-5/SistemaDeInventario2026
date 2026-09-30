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

            lista_productos = lproducto.Lista("capdestpro = true");

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
    }
}
