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
    public partial class FRMProveedor_Lista : DevComponents.DotNetBar.Office2007Form
    {
        #region Variables
        private rproved proveedor = new rproved();
        private List<rproved> lista_proveedores = new List<rproved>();
        #endregion

        #region Constructor
        public FRMProveedor_Lista()
        {
            InitializeComponent();
        }
        #endregion

        #region Metodos
        private void ActualizarGrid()
        {
            DTGLista.Rows.Clear();
            lista_proveedores.Clear();
            lista_proveedores = proveedor.Lista("crprnumcid like '%" + TXTFiltrar.Text + "%' or " +
                                           "crprapepat like '%" + TXTFiltrar.Text + "%' or " +
                                           "crprapemat like '%" + TXTFiltrar.Text + "%' or " +
                                           "crprnompro like '%" + TXTFiltrar.Text + "%' limit " +
                                           IINFilas.Value.ToString()
                                           );
            foreach (rproved a in lista_proveedores)
            {
                DTGLista.Rows.Add();

                if (a.crprestpro)
                {
                    if (DTGLista.Rows.Count %2==0)
                    {
                        DTGLista.Rows[DTGLista.Rows.Count - 1].DefaultCellStyle.BackColor = Color.LightSkyBlue;
                    }
                }
                else
                {
                    DTGLista.Rows[DTGLista.Rows.Count - 1].DefaultCellStyle.BackColor = Color.Salmon;
                }

                DTGLista[0, DTGLista.Rows.Count - 1].Value = a.prprcodpro;
                DTGLista[1, DTGLista.Rows.Count - 1].Value = a.crprestpro;
                DTGLista[2, DTGLista.Rows.Count - 1].Value = a.crprnumcid;
                DTGLista[3, DTGLista.Rows.Count - 1].Value = a.crprapepat;
                DTGLista[4, DTGLista.Rows.Count - 1].Value = a.crprapemat;
                DTGLista[5, DTGLista.Rows.Count - 1].Value = a.crprnompro;
                if (a.crprsexpro)
                {
                    DTGLista[6, DTGLista.Rows.Count - 1].Value = "M";
                }
                else
                {
                    DTGLista[6, DTGLista.Rows.Count - 1].Value = "F";
                }

                DTGLista[7, DTGLista.Rows.Count - 1].Value = a.crprnumcel;

            }

        }
        #endregion

        private void FRMProveedor_Lista_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            ActualizarGrid();
        }

        private void BTNRegistrar_Click(object sender, EventArgs e)
        {
            FRMProveedor_Registrar a = new FRMProveedor_Registrar();
            a.ShowDialog();
            if (a.actualizar)
            {
                ActualizarGrid();
            }
        }

        private void BTNModificar_Click(object sender, EventArgs e)
        {
            if (DTGLista.SelectedRows.Count > 0)
            {
                FRMProveedor_Registrar F1 = new FRMProveedor_Registrar();
                F1.modificar = true;
                F1.codPvdMod = DTGLista[0, DTGLista.SelectedRows[0].Index].Value.ToString();
                F1.ShowDialog();
                if (F1.actualizar)
                {
                    ActualizarGrid();
                }
            }
        }

        private void modificarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (DTGLista.SelectedRows.Count > 0)
            {
                FRMProveedor_Registrar F1 = new FRMProveedor_Registrar();
                F1.modificar = true;
                F1.codPvdMod = DTGLista[0, DTGLista.SelectedRows[0].Index].Value.ToString();
                F1.ShowDialog();
                if (F1.actualizar)
                {
                    ActualizarGrid();
                }
            }
        }

        private void DTGLista_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ActualizarGrid();
        }

        private void inhabilitarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (DTGLista.SelectedRows.Count > 0)
            {
                proveedor.prprcodpro = DTGLista[0, DTGLista.SelectedRows[0].Index].Value.ToString();
                if (proveedor.ObtenerDatos())
                {
                    proveedor.crprestpro = false;
                    if (proveedor.Modificar())
                    {
                        MessageBox.Show("Proveedor Inhabilitado correctamente");
                        ActualizarGrid();
                    }
                }
            }
        }

        private void CMSMenu_Opening(object sender, CancelEventArgs e)
        {
            if (DTGLista.SelectedRows.Count > 0)
            {
                proveedor.prprcodpro = DTGLista[0, DTGLista.SelectedRows[0].Index].Value.ToString();
                if (proveedor.ObtenerDatos())
                {

                    if (proveedor.crprestpro)
                    {
                        CMSMenu.Items[2].Visible = false;
                        CMSMenu.Items[1].Visible = true;
                    }
                    else
                    {
                        CMSMenu.Items[2].Visible = true;
                        CMSMenu.Items[1].Visible = false;
                    }
                }

            }
        }

        private void habilitarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (DTGLista.SelectedRows.Count > 0)
            {
                proveedor.prprcodpro = DTGLista[0, DTGLista.SelectedRows[0].Index].Value.ToString();
                if (proveedor.ObtenerDatos())
                {
                    proveedor.crprestpro = true;
                    if (proveedor.Modificar())
                    {
                        MessageBox.Show("Proveedor Habilitado correctamente");
                        ActualizarGrid();
                    }
                }
            }
        }

        private void TXTFiltrar_Enter(object sender, EventArgs e)
        {
            TXTFiltrar.SelectAll();
        }

        private void DTGLista_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (DTGLista.SelectedRows.Count > 0)
                {
                    FRMProveedor_Registrar F1 = new FRMProveedor_Registrar();
                    F1.modificar = true;
                    F1.codPvdMod = DTGLista[0, e.RowIndex].Value.ToString();
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
