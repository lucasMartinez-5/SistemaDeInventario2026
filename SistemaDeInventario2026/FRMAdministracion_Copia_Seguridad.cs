using CapaRN;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaDeInventario2026
{
    public partial class FRMAdministracion_Copia_Seguridad : Form
    {
        #region Variables
        private aperson persona = new aperson();
        private List<aperson> lista_personas = new List<aperson>();
        public event Action<string> PersonaElegida;
        #endregion

        #region Constructor
        public FRMAdministracion_Copia_Seguridad()
        {
            InitializeComponent();
        }
        #endregion

        private void FRMAdministracion_Copia_Seguridad_Load(object sender, EventArgs e)
        {

        }

        private void DTGLista_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void BTNFiltrar_Click(object sender, EventArgs e)
        {
            
        }

        private void CMSMenu_Opening(object sender, CancelEventArgs e)
        {
            
        }

        private void TXTFiltrar_Enter(object sender, EventArgs e)
        {
            
        }

        private void modificarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void inhabilitarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void habilitarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }
    }
}
