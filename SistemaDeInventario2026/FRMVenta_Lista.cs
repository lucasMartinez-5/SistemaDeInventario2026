using CapaRN;
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
    public partial class FRMVenta_Lista : Form
    {
        #region Variables
        private aventa venta = new aventa();
        private List<aventa> lista_ventas = new List<aventa>();
        #endregion
        public FRMVenta_Lista()
        {
            InitializeComponent();
        }
                
        #region Métodos
        private string NombreCliente(string codigo)
        {
            aclient cliente = new aclient();
            cliente.paclcodcli = codigo;
            if (cliente.ObtenerDatos())
            {
                return cliente.caclsoccli;
            }
            return codigo;
        }

        private void ActualizarGrid()
        {
            DTGLista.Rows.Clear();
            lista_ventas.Clear();
            lista_ventas = venta.Lista("(papvcodven like '%" + TXTFiltrar.Text + "%' or " +
                                              "fapvcodcli like '%" + TXTFiltrar.Text + "%') limit " +
                                           IINFilas.Value.ToString()
                                           );
            foreach (aventa a in lista_ventas)
            {
                DTGLista.Rows.Add();

                if (DTGLista.Rows.Count % 2 == 0)
                {
                    DTGLista.Rows[DTGLista.Rows.Count - 1].DefaultCellStyle.BackColor = Color.LightSkyBlue;
                }

                DTGLista[0, DTGLista.Rows.Count - 1].Value = a.papvcodven;                  // Código (columna oculta)
                DTGLista[1, DTGLista.Rows.Count - 1].Value = NombreCliente(a.fapvcodcli);   // Cliente
                DTGLista[2, DTGLista.Rows.Count - 1].Value = a.capvfecven;                  // Fecha de Venta
                DTGLista[3, DTGLista.Rows.Count - 1].Value = a.capvtotven.ToString("N2");   // Total
                //DTGLista[5, DTGLista.Rows.Count - 1].Value = a.capcfeccom.ToString("dd/MM/yyyy");   // Fecha (solo si agregas esa columna)
            }                                         
        }
        #endregion

        private void FRMVenta_Lista_Load(object sender, EventArgs e)
        {
            ActualizarGrid();
        }

        private void BTNSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BTNFiltrar_Click(object sender, EventArgs e)
        {
            ActualizarGrid();
        }

        private void DTGLista_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == 4)      // 4 = columna Acciones (botón)
            {
                aventa seleccionada = new aventa();

                seleccionada.papvcodven = DTGLista[0, e.RowIndex].Value?.ToString();

                if (seleccionada.ObtenerDatos())
                {
                    FRMVenta_Detalle F1 = new FRMVenta_Detalle(seleccionada, NombreCliente(seleccionada.fapvcodcli));
                    F1.ShowDialog();
                }
            }
        }
    }
}
