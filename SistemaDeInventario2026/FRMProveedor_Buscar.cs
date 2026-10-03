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
    public partial class FRMProveedor_Buscar : DevComponents.DotNetBar.Office2007Form
    {   
        #region Variables
        // Proveedor seleccionado que se devolverá al formulario anterior
        public aproved proveedor = new aproved();
        // Clase para listar proveedores junto con sus datos de persona
        private lproved lproveedor = new lproved();
        private List<lproved> lista_proveedores = new List<lproved>();
        // Indica si se seleccionó correctamente un proveedor
        public bool seleccionadoOk = false;
        #endregion

        #region Constructor
        public FRMProveedor_Buscar()
        {
            InitializeComponent();
        }
        #endregion

        #region Métodos
        private void ActualizarGrid()
        {
            DTGLista.Rows.Clear();
            lista_proveedores.Clear();

            String soloProveedor = "caprestpro=true";

            lista_proveedores = lproveedor.Lista(
                        soloProveedor +
                        " and (caprnitpro like '%" + TXTFiltrar.Text + "%' or " +
                        "caprsocpro like '%" + TXTFiltrar.Text + "%') " +
                        "order by caprsocpro " +
                        "limit " + IINFilas.Value.ToString()
                        );


            foreach (lproved p in lista_proveedores)
            {
                DTGLista.Rows.Add();

                if (p.caprestpro)
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

                DTGLista[0, DTGLista.Rows.Count - 1].Value = p.paprcodpro;
                DTGLista[1, DTGLista.Rows.Count - 1].Value = p.caprestpro;
                DTGLista[2, DTGLista.Rows.Count - 1].Value = p.caprnitpro;
                DTGLista[3, DTGLista.Rows.Count - 1].Value = p.caprsocpro;
                DTGLista[4, DTGLista.Rows.Count - 1].Value = p.caprnumcel;
            }
        }
        #endregion

        private void FRMProveedor_Buscar_Load(object sender, EventArgs e)
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

        private void BTNAgregarProveedor_Click(object sender, EventArgs e)
        {
            FRMProveedor_Registrar a = new FRMProveedor_Registrar();
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
                proveedor.paprcodpro = DTGLista[0, DTGLista.SelectedRows[0].Index].Value?.ToString();
                if (proveedor.ObtenerDatos())
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
                    FRMProveedor_Registrar F1 = new FRMProveedor_Registrar();
                    F1.modificar = true;
                    F1.codPveMod = DTGLista[0, e.RowIndex].Value.ToString();
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
