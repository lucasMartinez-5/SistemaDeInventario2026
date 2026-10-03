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
    public partial class FRMProducto_Buscar : DevComponents.DotNetBar.Office2007Form
    {
        #region Variables
        // Producto seleccionado que se devolverá al formulario anterior
        public aproduc producto = new aproduc();
        // Clase para listar productos junto con sus datos
        private lproduc lproducto = new lproduc();
        private List<lproduc> lista_productos = new List<lproduc>();
        // Indica si se seleccionó correctamente un producto
        public bool seleccionadoOk = false;
        #endregion

        #region Constructor
        public FRMProducto_Buscar()
        {
            InitializeComponent();
        }
        #endregion

        #region Métodos
        private void ActualizarGrid()
        {
            DTGLista.Rows.Clear();
            lista_productos.Clear();

            String soloProducto = "capdestpro=true";

            lista_productos = lproducto.Lista(
                        soloProducto +
                        " and (papdcodpro like '%" + TXTFiltrar.Text + "%' or " +
                        "capdnompro like '%" + TXTFiltrar.Text + "%') " +
                        "order by capdnompro " +
                        "limit " + IINFilas.Value.ToString()
                        );


            foreach (lproduc p in lista_productos)
            {
                DTGLista.Rows.Add();

                if (p.capdestpro)
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

                DTGLista[0, DTGLista.Rows.Count - 1].Value = p.papdcodpro;
                DTGLista[1, DTGLista.Rows.Count - 1].Value = p.capdestpro;
                DTGLista[2, DTGLista.Rows.Count - 1].Value = p.capdnompro;
                DTGLista[3, DTGLista.Rows.Count - 1].Value = p.capdtalpro;
                DTGLista[4, DTGLista.Rows.Count - 1].Value = p.capdcolpro;
                DTGLista[5, DTGLista.Rows.Count - 1].Value = p.capdmarpro;
                DTGLista[6, DTGLista.Rows.Count - 1].Value = p.capdmodpro;
                DTGLista[7, DTGLista.Rows.Count - 1].Value = p.capdgenpro;
                DTGLista[8, DTGLista.Rows.Count - 1].Value = p.capdmatpro;
                //DTGLista[9, DTGLista.Rows.Count - 1].Value = p.fapdcodcat;
                DTGLista[9, DTGLista.Rows.Count - 1].Value = p.cacpnomcat;
                DTGLista[10, DTGLista.Rows.Count - 1].Value = p.capdpreven;
                DTGLista[11, DTGLista.Rows.Count - 1].Value = p.capdpremin;
                DTGLista[12, DTGLista.Rows.Count - 1].Value = p.capdfeccre;
                DTGLista[13, DTGLista.Rows.Count - 1].Value = p.capdfecmod;
                DTGLista[14, DTGLista.Rows.Count - 1].Value = p.capdstopro;
                DTGLista[15, DTGLista.Rows.Count - 1].Value = p.capddespro;
            }
        }
        #endregion

        private void FRMProducto_Buscar_Load(object sender, EventArgs e)
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

        private void BTNAgregarProducto_Click(object sender, EventArgs e)
        {
            FRMProducto_Registrar a = new FRMProducto_Registrar();
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
                producto.papdcodpro = DTGLista[0, DTGLista.SelectedRows[0].Index].Value?.ToString();
                if (producto.ObtenerDatos())
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
                    FRMProducto_Registrar F1 = new FRMProducto_Registrar();
                    F1.modificar = true;
                    F1.codProMod = DTGLista[0, e.RowIndex].Value.ToString();
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
