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
    public partial class FRMCliente_Buscar : Form
    {

        #region Variables
        // Cliente seleccionado que se devolverá al formulario anterior
        public aclient cliente = new aclient();
        // Clase para listar clientes junto con sus datos de persona
        private lclient lcliente = new lclient();
        private List<lclient> lista_clientes = new List<lclient>();
        // Indica si se seleccionó correctamente un cliente
        public bool seleccionadoOk = false;
        #endregion
        public FRMCliente_Buscar()
        {
            InitializeComponent();
        }

        #region Métodos
        private void ActualizarGrid()
        {
            DTGLista.Rows.Clear();
            lista_clientes.Clear();

            String soloCliente = "caclestcli=true";

            lista_clientes = lcliente.Lista(
                        soloCliente +
                        " and (caclnitcli like '%" + TXTFiltrar.Text + "%' or " +
                        "caclsoccli like '%" + TXTFiltrar.Text + "%') " +
                        "order by caclsoccli " +
                        "limit " + IINFilas.Value.ToString()
                        );


            foreach (lclient c in lista_clientes)
            {
                DTGLista.Rows.Add();

                if (c.caclestcli)
                {
                    if (DTGLista.Rows.Count % 2 == 0)
                    {
                        DTGLista.Rows[DTGLista.Rows.Count - 1].DefaultCellStyle.BackColor = Color.LightSkyBlue;
                    }
                }
                else
                {
                    DTGLista.Rows[DTGLista.Rows.Count - 1].DefaultCellStyle.BackColor = Color.Salmon;
                }

                DTGLista[0, DTGLista.Rows.Count - 1].Value = c.paclcodcli;
                DTGLista[1, DTGLista.Rows.Count - 1].Value = c.caclestcli;
                DTGLista[2, DTGLista.Rows.Count - 1].Value = c.caclnitcli;
                DTGLista[3, DTGLista.Rows.Count - 1].Value = c.caclsoccli;
                DTGLista[4, DTGLista.Rows.Count - 1].Value = c.caclnumcel;
            }
        }
        #endregion

        private void FRMCliente_Buscar_Load(object sender, EventArgs e)
        {
            ActualizarGrid();
        }

        private void BTNFiltrar_Click(object sender, EventArgs e)
        {
            ActualizarGrid();
        }

        private void TXTFiltrar_Enter(object sender, EventArgs e)
        {
            TXTFiltrar.SelectAll();
        }

        private void BTNAgregarCliente_Click(object sender, EventArgs e)
        {
            FRMCliente_Registrar a = new FRMCliente_Registrar();
            a.ShowDialog();
            if (a.actualizar)
            {
                ActualizarGrid();
            }
        }

        private void BTNAceptar_Click(object sender, EventArgs e)
        {
            if (DTGLista.SelectedRows.Count == 1)
            {
                cliente.paclcodcli = DTGLista[0, DTGLista.SelectedRows[0].Index].Value?.ToString();
                if (cliente.ObtenerDatos())
                {
                    seleccionadoOk = true;
                    this.Close();
                }
            }
        }

        private void DTGLista_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (DTGLista.SelectedRows.Count > 0)
                {
                    FRMCliente_Registrar F1 = new FRMCliente_Registrar();
                    F1.modificar = true;
                    F1.codCliMod = DTGLista[0, e.RowIndex].Value.ToString();
                    F1.ShowDialog();
                    if (F1.actualizar)
                    {
                        ActualizarGrid();
                    }
                }
            }
        }
    }
}
