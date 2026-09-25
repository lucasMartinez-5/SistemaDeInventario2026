using CapaRN;
using MaterialSkin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static MaterialSkin.Controls.MaterialForm;

namespace SistemaDeInventario2026
{
    public partial class FRMProveedor_Lista : Form
    {
        #region Variables
        private lproved lproveedor = new lproved();
        private aproved aproveedor = new aproved();
        private List<lproved> lista_proveedores = new List<lproved>();
        #endregion

        #region Constructor
        public FRMProveedor_Lista()
        {
            InitializeComponent();
            if (this.BTNDirectorio.Image != null)
            {
                this.BTNDirectorio.Image = new Bitmap(this.BTNDirectorio.Image, new Size(24, 24));
            }
            if (this.BTNInventario.Image != null)
            {
                this.BTNInventario.Image = new Bitmap(this.BTNInventario.Image, new Size(24, 24));
            }
            if (this.BTNPuntoDeVenta.Image != null)
            {
                this.BTNPuntoDeVenta.Image = new Bitmap(this.BTNPuntoDeVenta.Image, new Size(24, 24));
            }
            if (this.BTNAdministracionUsuarios.Image != null)
            {
                this.BTNAdministracionUsuarios.Image = new Bitmap(this.BTNAdministracionUsuarios.Image, new Size(24, 24));
            }
            if (this.BTNBusquedaAvanzada.Image != null)
            {
                this.BTNBusquedaAvanzada.Image = new Bitmap(this.BTNBusquedaAvanzada.Image, new Size(24, 24));
            }
        }
        #endregion

        #region Métodos
        private void ActualizarGrid()
        {
            DTGLista.Rows.Clear();
            lista_proveedores.Clear();
            lista_proveedores = lproveedor.Lista("(capsnumcid like '%" + TXTFiltrar.Text + "%' or " +
                                           "capsapepat like '%" + TXTFiltrar.Text + "%' or " +
                                           "capsapemat like '%" + TXTFiltrar.Text + "%' or " +
                                           "capsnomper like '%" + TXTFiltrar.Text + "%') limit " +
                                           IINFilas.Value.ToString()
                                           );
            foreach (lproved a in lista_proveedores)
            {
                DTGLista.Rows.Add();

                if (a.caprestpro)
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

                DTGLista[0, DTGLista.Rows.Count - 1].Value = a.paprcodpro;
                DTGLista[1, DTGLista.Rows.Count - 1].Value = a.caprestpro;
                DTGLista[2, DTGLista.Rows.Count - 1].Value = a.caprnitpro;
                DTGLista[3, DTGLista.Rows.Count - 1].Value = a.capsapepat + " " +
                                                             a.capsapemat + " " +
                                                             a.capsnomper;
                DTGLista[4, DTGLista.Rows.Count - 1].Value = a.capsnumcel;

            }
        }
        #endregion

        private void FRMProveedor_Lista_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            ActualizarGrid();
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

        private void BTNFiltrar_Click(object sender, EventArgs e)
        {
            ActualizarGrid();
        }

        private void DTGLista_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == 1)
            {
                aproved proveedor = new aproved();

                proveedor.paprcodpro = DTGLista[0, e.RowIndex].Value?.ToString();

                if (proveedor.ObtenerDatos())
                {
                    proveedor.caprestpro = !proveedor.caprestpro;

                    if (!proveedor.Modificar())
                    {
                        MessageBox.Show("No se pudo modificar el estado del proveedor.",
                                        "Error",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Warning);
                    }
                }
            }

            ActualizarGrid();
        }

        private void modificarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (DTGLista.SelectedRows.Count > 0)
            {
                FRMProveedor_Registrar F1 = new FRMProveedor_Registrar();
                F1.modificar = true;
                F1.codPveMod = DTGLista[0, DTGLista.SelectedRows[0].Index].Value.ToString();
                F1.ShowDialog();
                if (F1.actualizar)
                {
                    ActualizarGrid();
                }
            }
        }

        private void inhabilitarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (DTGLista.SelectedRows.Count > 0)
            {
                aproveedor.paprcodpro = DTGLista[0, DTGLista.SelectedRows[0].Index].Value.ToString();
                if (aproveedor.ObtenerDatos())
                {
                    aproveedor.caprestpro = false;
                    if (aproveedor.Modificar())
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
                aproveedor.paprcodpro = DTGLista[0, DTGLista.SelectedRows[0].Index].Value.ToString();
                if (aproveedor.ObtenerDatos())
                {

                    if (aproveedor.caprestpro)
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
                aproveedor.paprcodpro = DTGLista[0, DTGLista.SelectedRows[0].Index].Value.ToString();
                if (aproveedor.ObtenerDatos())
                {
                    aproveedor.caprestpro = true;
                    if (aproveedor.Modificar())
                    {
                        MessageBox.Show("Proveedor Habilitado correctamente");
                        ActualizarGrid();
                    }
                }
            }
        }
    }
}
