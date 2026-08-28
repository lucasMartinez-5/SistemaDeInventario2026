using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;

namespace SistemaDeInventario2026
{
    public partial class FRMProveedor_Registrar : MaterialSkin.Controls.MaterialForm
    {
        public FRMProveedor_Registrar()
        {
            InitializeComponent();

            var skinManager = MaterialSkinManager.Instance;
            skinManager.AddFormToManage(this);
            skinManager.Theme = MaterialSkinManager.Themes.LIGHT;

            //skinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
            skinManager.ColorScheme = new ColorScheme(
                Color.FromArgb(248, 249, 250), 
                Color.FromArgb(240, 240, 240), 
                Color.FromArgb(200, 200, 200), 
                Color.FromArgb(30, 41, 59), 
                TextShade.BLACK);
            this.FormStyle = FormStyles.StatusAndActionBar_None;
        }
    }
}
