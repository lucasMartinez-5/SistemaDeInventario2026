using System;
using System.Collections;
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

            AplicarAlertaStock(stock);      // NUEVO: muestra la alerta si están activadas
        }
        // NUEVO
        private void AplicarAlertaStock(string stock)
        {
            int minimo = FRMProducto_Alerta_Stock.StockMinimo;
            if (minimo <= 0) return;        // sin cantidad mínima guardada: no hay alertas

            int cantidad;
            int.TryParse(stock, out cantidad);

            if (cantidad <= 0)
            {
                LBLStock.Text = LBLStock.Text + " (Agotado)";
                LBLStock.ForeColor = Color.Red;
            }
            else if (cantidad <= minimo)
            {
                LBLStock.Text = LBLStock.Text + " (Stock bajo)";
                LBLStock.ForeColor = Color.Orange;
            }
            else
            {
                LBLStock.ForeColor = Color.Green;
            }
        }
        #endregion
        private void UCLProductoCard_Load(object sender, EventArgs e)
        {
            //FRMProducto_Alerta_Stock alertaStock = new FRMProducto_Alerta_Stock();
            /*
            int minimo = FRMProducto_Alerta_Stock.StockMinimo;
            if (minimo <= 0) return;      // sin cantidad mínima guardada: no hay alertas

            int stock;
            int.TryParse(LBLStock.Text.Replace("Stock:", "").Trim(), out stock);

            if (stock <= 0)
            {
                LBLStock.Text = LBLStock.Text + " (Agotado)";
                LBLStock.ForeColor = Color.Red;
            }
            else if (stock <= minimo)
            {
                LBLStock.Text = LBLStock.Text + " (Stock bajo)";
                LBLStock.ForeColor = Color.Orange;
            }
            else
            {
                LBLStock.ForeColor = Color.Green;
            }
            */
        }

        private void BTNModificarUCLProducto_Click(object sender, EventArgs e)
        {
            
            FRMProducto_Registrar a = new FRMProducto_Registrar();
            a.codProMod = this.Tag.ToString();
            a.ShowDialog();
            //actualizar el catalogo de productos despues de modificar un producto
            /*
            if (a.actualizar)
            {
                FRMProducto_Lista b = new FRMProducto_Lista();
                b.ActualizarCatalogo();
            }
            */

            if (a.actualizar)
            {
                FRMProducto_Lista lista = this.FindForm() as FRMProducto_Lista;   // el catálogo que está en pantalla
                if (lista != null) lista.ActualizarCatalogo();
            }
            
        }
    }
}
