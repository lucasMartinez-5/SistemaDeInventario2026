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
    public partial class UCLProductoCard : UserControl
    {
        public UCLProductoCard()
        {
            InitializeComponent();
        }

        #region Metodos
        public void CargarDatos(
        string nombre,
        string talla,
        string color,
        string precio,
        string stock,
        Image imagen)
        {
            LBLNombre.Text = nombre;
            LBLTallaColor.Text = "Talla: " + talla + ", Color: " + color;
            LBLPrecio.Text = precio;
            LBLStock.Text = "Stock: " + stock;

            PCBImagen.Image = imagen;
            PCBImagen.SizeMode = PictureBoxSizeMode.Zoom;
        }
        #endregion
        private void UCLProductoCard_Load(object sender, EventArgs e)
        {

        }

        private void BTNModificarUCLProducto_Click(object sender, EventArgs e)
        {
            FRMProducto_Registrar a = new FRMProducto_Registrar();
            a.codProMod = this.Tag.ToString();
            a.ShowDialog();

            //actualizar el catalogo de productos despues de modificar un producto
            
            
            if (a.actualizar)
            {
                FRMProducto_Lista b = new FRMProducto_Lista();
                b.ActualizarCatalogo();
            }
        }
    }
}
