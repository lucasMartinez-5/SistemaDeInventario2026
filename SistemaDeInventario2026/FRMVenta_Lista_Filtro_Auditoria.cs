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
    public partial class FRMVenta_Lista_Filtro_Auditoria : Form
    {
        #region Variables
        private lventa lventa = new lventa();
        private aventa aventa = new aventa();
        //private List<lventa> lista_ventas = new List<lventa>();
        private List<aventa> lista_ventas = new List<aventa>();
        public DateTime desde = DateTime.Today;
        public DateTime hasta = DateTime.Today;
        #endregion

        public FRMVenta_Lista_Filtro_Auditoria()
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
        private string NombreUsuario(string codigo)
        {
            aususis usuario = new aususis();
            usuario.pauscodusu = codigo;
            if (usuario.ObtenerDatos())
            {
                return usuario.causnomlog;
            }
            return codigo;
        }
        private void ActualizarGrid()
        {
            DTGLista.Rows.Clear();
            lista_ventas.Clear();
            //lista_ventas = lventa.Lista("capvfecven >= '" + desde.ToString("yyyy-MM-dd") + "' and " +
            lista_ventas = aventa.Lista("capvfecven >= '" + desde.ToString("yyyy-MM-dd") + "' and " +
                                         "capvfecven < '" + hasta.AddDays(1).ToString("yyyy-MM-dd") + "' and " +
                                         "(fapvcodcli in (select paclcodcli from aclient where caclsoccli like '%" + TXTFiltrar.Text + "%') " +
                                         "or fapvcodusu in (select pauscodusu from aususis where causnomlog like '%" + TXTFiltrar.Text + "%')) " +
                                         "order by capvfecven desc limit " +
                                         IINFilas.Value.ToString()
                                         );
            //foreach (lventa a in lista_ventas)
            foreach (aventa a in lista_ventas)
            {
                DTGLista.Rows.Add();
                DTGLista[0, DTGLista.Rows.Count - 1].Value = a.papvcodven;
                DTGLista[1, DTGLista.Rows.Count - 1].Value = NombreUsuario(a.fapvcodusu);
                DTGLista[2, DTGLista.Rows.Count - 1].Value = NombreCliente(a.fapvcodcli);   // Cliente
                DTGLista[3, DTGLista.Rows.Count - 1].Value = a.capvfecven;                  // Fecha de Venta
                DTGLista[4, DTGLista.Rows.Count - 1].Value = a.capvtotven.ToString("N2");   // Total
            }
        }
        #endregion
        private void FRMVenta_Lista_Filtro_Auditoria_Load(object sender, EventArgs e)
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
            if (e.RowIndex >= 0 && e.ColumnIndex == 5)      // 5 = columna Acciones (botón)
            {
                aventa seleccionada = new aventa();

                seleccionada.papvcodven = DTGLista[0, e.RowIndex].Value?.ToString();

                if (seleccionada.ObtenerDatos())
                {
                    FRMAdministracion_Venta_Detalle_Auditoria F1 = new FRMAdministracion_Venta_Detalle_Auditoria(seleccionada, NombreCliente(seleccionada.fapvcodcli));
                    F1.ShowDialog();
                }
            }
        }
    }
}
