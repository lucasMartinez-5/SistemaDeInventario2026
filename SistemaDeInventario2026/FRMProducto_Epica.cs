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
    public partial class FRMProducto_Epica : Form
    {
        public FRMProducto_Epica()
        {
            InitializeComponent();
        }

        private void FRMProducto_Epica_Load(object sender, EventArgs e)
        {

        }

        private void BTNDirectorio_Click(object sender, EventArgs e)
        {
            FRMProveedor_Registrar a = new FRMProveedor_Registrar();
            a.ShowDialog();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            FRMProducto_Lista a = new FRMProducto_Lista();
            a.ShowDialog();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            FRMProducto_Registrar a = new FRMProducto_Registrar();
            a.ShowDialog();
        }
    }
}
