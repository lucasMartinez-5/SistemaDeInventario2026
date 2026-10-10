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
    public partial class FRMCompra_Lista_Filtro : Form
    {
        #region Variables
        private acompra compra = new acompra();
        private List<acompra> lista_compras = new List<acompra>();
        public DateTime desde = DateTime.Today;
        public DateTime hasta = DateTime.Today;
        #endregion

        #region Constructor
        public FRMCompra_Lista_Filtro()
        {
            InitializeComponent();
        }
        #endregion

        #region Métodos
        private string NombreProveedor(string codigo)
        {
            aproved proveedor = new aproved();
            proveedor.paprcodpro = codigo;
            if (proveedor.ObtenerDatos())
            {
                return proveedor.caprsocpro;
            }
            return codigo;
        }

        private void ActualizarGrid()
        {
            DTGLista.Rows.Clear();
            lista_compras.Clear();
            lista_compras = compra.Lista("capcfeccom >= '" + desde.ToString("yyyy-MM-dd") + "' and " +
                                         "capcfeccom < '" + hasta.AddDays(1).ToString("yyyy-MM-dd") + "' and " +
                                         "(capdfaccom like '%" + TXTFiltrar.Text + "%' or " +
                                         "faprcodpro in (select paprcodpro from aproved where caprsocpro like '%" + TXTFiltrar.Text + "%')) " +
                                         "order by capcfeccom desc limit " +
                                         IINFilas.Value.ToString()
                                         );
            foreach (acompra a in lista_compras)
            {
                DTGLista.Rows.Add();

                if (DTGLista.Rows.Count % 2 == 0)
                {
                    DTGLista.Rows[DTGLista.Rows.Count - 1].DefaultCellStyle.BackColor = Color.LightSkyBlue;
                }

                DTGLista[0, DTGLista.Rows.Count - 1].Value = a.papccodcom;                  // Código (columna oculta)
                DTGLista[1, DTGLista.Rows.Count - 1].Value = a.capdfaccom;                  // N° Factura
                DTGLista[2, DTGLista.Rows.Count - 1].Value = NombreProveedor(a.faprcodpro); // Proveedor
                DTGLista[3, DTGLista.Rows.Count - 1].Value = a.capctotcom.ToString("N2");   // Total
                //DTGLista[5, DTGLista.Rows.Count - 1].Value = a.capcfeccom.ToString("dd/MM/yyyy");   // Fecha (solo si agregas esa columna)
            }
        }
        #endregion

        private void BTNSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FRMCompra_Lista_Filtro_Load(object sender, EventArgs e)
        {
            ActualizarGrid();
        }

        private void BTNFiltrar_Click(object sender, EventArgs e)
        {
            ActualizarGrid();
        }

        private void DTGLista_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == 4)      // 4 = columna Acciones (botón)
            {
                acompra seleccionada = new acompra();

                seleccionada.papccodcom = DTGLista[0, e.RowIndex].Value?.ToString();

                if (seleccionada.ObtenerDatos())
                {
                    FRMCompra_Detalle F1 = new FRMCompra_Detalle(seleccionada, NombreProveedor(seleccionada.faprcodpro));
                    F1.ShowDialog();
                }
            }
        }
    }
}
