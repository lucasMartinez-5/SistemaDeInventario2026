namespace SistemaDeInventario2026
{
    partial class FRMProducto_Registrar
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRMProducto_Registrar));
            this.OFDElegirImagen = new System.Windows.Forms.OpenFileDialog();
            this.BLTAyuda = new DevComponents.DotNetBar.BalloonTip();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BTNBusquedaGeneral = new DevComponents.DotNetBar.ButtonX();
            this.TXTFiltrarGeneral = new System.Windows.Forms.TextBox();
            this.BTNConfiguracion = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.PPrincipal = new System.Windows.Forms.Panel();
            this.CMBMarca = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.CMBProductoNombre = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.CMBTalla = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.CMBColor = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.CMBMaterial = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.CMBCategoria = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.CMBGenero = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.comboItem1 = new DevComponents.Editors.ComboItem();
            this.comboItem2 = new DevComponents.Editors.ComboItem();
            this.comboItem3 = new DevComponents.Editors.ComboItem();
            this.BTNAbrirFoto = new System.Windows.Forms.Button();
            this.BTNLimpiarFoto = new System.Windows.Forms.Button();
            this.BTNCapturarFoto = new System.Windows.Forms.Button();
            this.PCBFotografia = new System.Windows.Forms.PictureBox();
            this.PCBCamara = new System.Windows.Forms.PictureBox();
            this.BTNCodigoDeBarras = new DevComponents.DotNetBar.ButtonX();
            this.TXTProductoDescripcion = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.LBLCodigoDeBarras = new DevComponents.DotNetBar.LabelX();
            this.materialLabel13 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel10 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel11 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel12 = new MaterialSkin.Controls.MaterialLabel();
            this.TXTModelo = new System.Windows.Forms.TextBox();
            this.materialLabel9 = new MaterialSkin.Controls.MaterialLabel();
            this.NUDStockActual = new System.Windows.Forms.NumericUpDown();
            this.NUDPrecioVenta = new System.Windows.Forms.NumericUpDown();
            this.NUDPrecioMinVenta = new System.Windows.Forms.NumericUpDown();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.SWBEstadoStock = new DevComponents.DotNetBar.Controls.SwitchButton();
            this.materialLabel8 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel7 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.FLYTallas = new System.Windows.Forms.FlowLayoutPanel();
            this.RBTTS = new System.Windows.Forms.RadioButton();
            this.RBTTM = new System.Windows.Forms.RadioButton();
            this.RBTTL = new System.Windows.Forms.RadioButton();
            this.RBTTXL = new System.Windows.Forms.RadioButton();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.BTNLimpiar = new System.Windows.Forms.Button();
            this.BTNSalir = new System.Windows.Forms.Button();
            this.BTNGrabar = new System.Windows.Forms.Button();
            this.LBL = new MaterialSkin.Controls.MaterialLabel();
            this.LBLRegistrarProducto = new DevComponents.DotNetBar.LabelX();
            this.panel2 = new System.Windows.Forms.Panel();
            this.BTNAdministracionUsuarios = new System.Windows.Forms.Button();
            this.BTNPuntoDeVenta = new System.Windows.Forms.Button();
            this.BTNBusquedaAvanzada = new System.Windows.Forms.Button();
            this.BTNInventario = new System.Windows.Forms.Button();
            this.BTNDirectorio = new System.Windows.Forms.Button();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.PPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PCBFotografia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PCBCamara)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDStockActual)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDPrecioVenta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDPrecioMinVenta)).BeginInit();
            this.FLYTallas.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // OFDElegirImagen
            // 
            this.OFDElegirImagen.Filter = "Archivos de Imagen|*.jpg;*.jpeg;*.png";
            this.OFDElegirImagen.Title = "Elegir fotografía";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.BTNBusquedaGeneral);
            this.panel1.Controls.Add(this.TXTFiltrarGeneral);
            this.panel1.Controls.Add(this.BTNConfiguracion);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.pictureBox4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1237, 45);
            this.panel1.TabIndex = 8;
            // 
            // BTNBusquedaGeneral
            // 
            this.BTNBusquedaGeneral.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.BTNBusquedaGeneral.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.BTNBusquedaGeneral.Image = global::SistemaDeInventario2026.Properties.Resources.ic_buscar;
            this.BTNBusquedaGeneral.ImageFixedSize = new System.Drawing.Size(15, 15);
            this.BTNBusquedaGeneral.Location = new System.Drawing.Point(1032, 10);
            this.BTNBusquedaGeneral.Name = "BTNBusquedaGeneral";
            this.BTNBusquedaGeneral.Size = new System.Drawing.Size(23, 23);
            this.BTNBusquedaGeneral.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.BTNBusquedaGeneral.TabIndex = 46;
            // 
            // TXTFiltrarGeneral
            // 
            this.TXTFiltrarGeneral.Location = new System.Drawing.Point(864, 10);
            this.TXTFiltrarGeneral.Name = "TXTFiltrarGeneral";
            this.TXTFiltrarGeneral.Size = new System.Drawing.Size(191, 23);
            this.TXTFiltrarGeneral.TabIndex = 45;
            // 
            // BTNConfiguracion
            // 
            this.BTNConfiguracion.FlatAppearance.BorderSize = 0;
            this.BTNConfiguracion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTNConfiguracion.Location = new System.Drawing.Point(750, 7);
            this.BTNConfiguracion.Name = "BTNConfiguracion";
            this.BTNConfiguracion.Size = new System.Drawing.Size(108, 29);
            this.BTNConfiguracion.TabIndex = 44;
            this.BTNConfiguracion.Text = "Configuración";
            this.BTNConfiguracion.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Cursor = System.Windows.Forms.Cursors.Default;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label4.Location = new System.Drawing.Point(59, 8);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(237, 25);
            this.label4.TabIndex = 33;
            this.label4.Text = "Directorio de Proveedores";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::SistemaDeInventario2026.Properties.Resources.ic_circle_usuario;
            this.pictureBox4.Location = new System.Drawing.Point(5, 2);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(48, 41);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 32;
            this.pictureBox4.TabStop = false;
            // 
            // PPrincipal
            // 
            this.PPrincipal.AutoScroll = true;
            this.PPrincipal.BackColor = System.Drawing.Color.White;
            this.PPrincipal.Controls.Add(this.CMBMarca);
            this.PPrincipal.Controls.Add(this.CMBProductoNombre);
            this.PPrincipal.Controls.Add(this.CMBTalla);
            this.PPrincipal.Controls.Add(this.CMBColor);
            this.PPrincipal.Controls.Add(this.CMBMaterial);
            this.PPrincipal.Controls.Add(this.CMBCategoria);
            this.PPrincipal.Controls.Add(this.CMBGenero);
            this.PPrincipal.Controls.Add(this.BTNAbrirFoto);
            this.PPrincipal.Controls.Add(this.BTNLimpiarFoto);
            this.PPrincipal.Controls.Add(this.BTNCapturarFoto);
            this.PPrincipal.Controls.Add(this.PCBFotografia);
            this.PPrincipal.Controls.Add(this.PCBCamara);
            this.PPrincipal.Controls.Add(this.BTNCodigoDeBarras);
            this.PPrincipal.Controls.Add(this.TXTProductoDescripcion);
            this.PPrincipal.Controls.Add(this.LBLCodigoDeBarras);
            this.PPrincipal.Controls.Add(this.materialLabel13);
            this.PPrincipal.Controls.Add(this.materialLabel10);
            this.PPrincipal.Controls.Add(this.materialLabel11);
            this.PPrincipal.Controls.Add(this.materialLabel12);
            this.PPrincipal.Controls.Add(this.TXTModelo);
            this.PPrincipal.Controls.Add(this.materialLabel9);
            this.PPrincipal.Controls.Add(this.NUDStockActual);
            this.PPrincipal.Controls.Add(this.NUDPrecioVenta);
            this.PPrincipal.Controls.Add(this.NUDPrecioMinVenta);
            this.PPrincipal.Controls.Add(this.materialLabel1);
            this.PPrincipal.Controls.Add(this.SWBEstadoStock);
            this.PPrincipal.Controls.Add(this.materialLabel8);
            this.PPrincipal.Controls.Add(this.materialLabel7);
            this.PPrincipal.Controls.Add(this.materialLabel6);
            this.PPrincipal.Controls.Add(this.materialLabel5);
            this.PPrincipal.Controls.Add(this.materialLabel4);
            this.PPrincipal.Controls.Add(this.FLYTallas);
            this.PPrincipal.Controls.Add(this.materialLabel2);
            this.PPrincipal.Controls.Add(this.BTNLimpiar);
            this.PPrincipal.Controls.Add(this.BTNSalir);
            this.PPrincipal.Controls.Add(this.BTNGrabar);
            this.PPrincipal.Controls.Add(this.LBL);
            this.PPrincipal.Controls.Add(this.LBLRegistrarProducto);
            this.PPrincipal.Controls.Add(this.panel2);
            this.PPrincipal.Controls.Add(this.materialLabel3);
            this.PPrincipal.Cursor = System.Windows.Forms.Cursors.Default;
            this.PPrincipal.Location = new System.Drawing.Point(0, 45);
            this.PPrincipal.Name = "PPrincipal";
            this.PPrincipal.Size = new System.Drawing.Size(1237, 509);
            this.PPrincipal.TabIndex = 7;
            // 
            // CMBMarca
            // 
            this.CMBMarca.DisplayMember = "Text";
            this.CMBMarca.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.CMBMarca.ForeColor = System.Drawing.Color.Black;
            this.CMBMarca.FormattingEnabled = true;
            this.CMBMarca.ItemHeight = 17;
            this.CMBMarca.Location = new System.Drawing.Point(970, 47);
            this.CMBMarca.Name = "CMBMarca";
            this.CMBMarca.Size = new System.Drawing.Size(223, 23);
            this.CMBMarca.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.CMBMarca.TabIndex = 82;
            this.CMBMarca.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CMBMarca_KeyDown);
            // 
            // CMBProductoNombre
            // 
            this.CMBProductoNombre.DisplayMember = "Text";
            this.CMBProductoNombre.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.CMBProductoNombre.ForeColor = System.Drawing.Color.Black;
            this.CMBProductoNombre.FormattingEnabled = true;
            this.CMBProductoNombre.ItemHeight = 17;
            this.CMBProductoNombre.Location = new System.Drawing.Point(321, 210);
            this.CMBProductoNombre.Name = "CMBProductoNombre";
            this.CMBProductoNombre.Size = new System.Drawing.Size(336, 23);
            this.CMBProductoNombre.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.CMBProductoNombre.TabIndex = 81;
            this.CMBProductoNombre.SelectedIndexChanged += new System.EventHandler(this.CMBProductoNombre_SelectedIndexChanged);
            this.CMBProductoNombre.Enter += new System.EventHandler(this.CMBProductoNombre_Enter);
            this.CMBProductoNombre.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CMBProductoNombre_KeyDown);
            this.CMBProductoNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CMBProductoNombre_KeyPress);
            // 
            // CMBTalla
            // 
            this.CMBTalla.DisplayMember = "Text";
            this.CMBTalla.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.CMBTalla.ForeColor = System.Drawing.Color.Black;
            this.CMBTalla.FormattingEnabled = true;
            this.CMBTalla.ItemHeight = 17;
            this.CMBTalla.Location = new System.Drawing.Point(698, 156);
            this.CMBTalla.Name = "CMBTalla";
            this.CMBTalla.Size = new System.Drawing.Size(223, 23);
            this.CMBTalla.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.CMBTalla.TabIndex = 80;
            // 
            // CMBColor
            // 
            this.CMBColor.DisplayMember = "Text";
            this.CMBColor.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.CMBColor.ForeColor = System.Drawing.Color.Black;
            this.CMBColor.FormattingEnabled = true;
            this.CMBColor.ItemHeight = 17;
            this.CMBColor.Location = new System.Drawing.Point(698, 209);
            this.CMBColor.Name = "CMBColor";
            this.CMBColor.Size = new System.Drawing.Size(223, 23);
            this.CMBColor.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.CMBColor.TabIndex = 79;
            this.CMBColor.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CMBColor_KeyDown);
            // 
            // CMBMaterial
            // 
            this.CMBMaterial.DisplayMember = "Text";
            this.CMBMaterial.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.CMBMaterial.ForeColor = System.Drawing.Color.Black;
            this.CMBMaterial.FormattingEnabled = true;
            this.CMBMaterial.ItemHeight = 17;
            this.CMBMaterial.Location = new System.Drawing.Point(970, 214);
            this.CMBMaterial.Name = "CMBMaterial";
            this.CMBMaterial.Size = new System.Drawing.Size(223, 23);
            this.CMBMaterial.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.CMBMaterial.TabIndex = 78;
            this.CMBMaterial.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CMBMaterial_KeyDown);
            // 
            // CMBCategoria
            // 
            this.CMBCategoria.DisplayMember = "Text";
            this.CMBCategoria.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.CMBCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CMBCategoria.ForeColor = System.Drawing.Color.Black;
            this.CMBCategoria.FormattingEnabled = true;
            this.CMBCategoria.ItemHeight = 17;
            this.CMBCategoria.Location = new System.Drawing.Point(970, 155);
            this.CMBCategoria.Name = "CMBCategoria";
            this.CMBCategoria.Size = new System.Drawing.Size(223, 23);
            this.CMBCategoria.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.CMBCategoria.TabIndex = 77;
            this.CMBCategoria.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CMBCategoria_KeyDown);
            // 
            // CMBGenero
            // 
            this.CMBGenero.DisplayMember = "Text";
            this.CMBGenero.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.CMBGenero.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CMBGenero.ForeColor = System.Drawing.Color.Black;
            this.CMBGenero.FormattingEnabled = true;
            this.CMBGenero.ItemHeight = 17;
            this.CMBGenero.Items.AddRange(new object[] {
            this.comboItem1,
            this.comboItem2,
            this.comboItem3});
            this.CMBGenero.Location = new System.Drawing.Point(970, 95);
            this.CMBGenero.Name = "CMBGenero";
            this.CMBGenero.Size = new System.Drawing.Size(223, 23);
            this.CMBGenero.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.CMBGenero.TabIndex = 76;
            // 
            // comboItem1
            // 
            this.comboItem1.Text = "Hombre";
            // 
            // comboItem2
            // 
            this.comboItem2.Text = "Mujer";
            // 
            // comboItem3
            // 
            this.comboItem3.Text = "Unisex";
            // 
            // BTNAbrirFoto
            // 
            this.BTNAbrirFoto.BackColor = System.Drawing.Color.Black;
            this.BTNAbrirFoto.FlatAppearance.BorderSize = 0;
            this.BTNAbrirFoto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.BTNAbrirFoto.ForeColor = System.Drawing.Color.White;
            this.BTNAbrirFoto.Location = new System.Drawing.Point(321, 354);
            this.BTNAbrirFoto.Name = "BTNAbrirFoto";
            this.BTNAbrirFoto.Size = new System.Drawing.Size(34, 35);
            this.BTNAbrirFoto.TabIndex = 75;
            this.BTNAbrirFoto.Text = "-";
            this.BTNAbrirFoto.UseVisualStyleBackColor = false;
            this.BTNAbrirFoto.Click += new System.EventHandler(this.BTNAbrirFoto_Click);
            // 
            // BTNLimpiarFoto
            // 
            this.BTNLimpiarFoto.BackColor = System.Drawing.Color.Black;
            this.BTNLimpiarFoto.FlatAppearance.BorderSize = 0;
            this.BTNLimpiarFoto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.BTNLimpiarFoto.ForeColor = System.Drawing.Color.White;
            this.BTNLimpiarFoto.Location = new System.Drawing.Point(321, 302);
            this.BTNLimpiarFoto.Name = "BTNLimpiarFoto";
            this.BTNLimpiarFoto.Size = new System.Drawing.Size(34, 35);
            this.BTNLimpiarFoto.TabIndex = 74;
            this.BTNLimpiarFoto.Text = "..";
            this.BTNLimpiarFoto.UseVisualStyleBackColor = false;
            this.BTNLimpiarFoto.Click += new System.EventHandler(this.BTNLimpiarFoto_Click);
            // 
            // BTNCapturarFoto
            // 
            this.BTNCapturarFoto.BackColor = System.Drawing.Color.Black;
            this.BTNCapturarFoto.FlatAppearance.BorderSize = 0;
            this.BTNCapturarFoto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.BTNCapturarFoto.ForeColor = System.Drawing.Color.White;
            this.BTNCapturarFoto.Location = new System.Drawing.Point(321, 249);
            this.BTNCapturarFoto.Name = "BTNCapturarFoto";
            this.BTNCapturarFoto.Size = new System.Drawing.Size(34, 35);
            this.BTNCapturarFoto.TabIndex = 73;
            this.BTNCapturarFoto.Text = "+";
            this.BTNCapturarFoto.UseVisualStyleBackColor = false;
            this.BTNCapturarFoto.Click += new System.EventHandler(this.BTNCapturarFoto_Click);
            // 
            // PCBFotografia
            // 
            this.PCBFotografia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PCBFotografia.Image = ((System.Drawing.Image)(resources.GetObject("PCBFotografia.Image")));
            this.PCBFotografia.Location = new System.Drawing.Point(517, 249);
            this.PCBFotografia.Name = "PCBFotografia";
            this.PCBFotografia.Size = new System.Drawing.Size(140, 140);
            this.PCBFotografia.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PCBFotografia.TabIndex = 72;
            this.PCBFotografia.TabStop = false;
            // 
            // PCBCamara
            // 
            this.PCBCamara.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PCBCamara.Image = ((System.Drawing.Image)(resources.GetObject("PCBCamara.Image")));
            this.PCBCamara.Location = new System.Drawing.Point(362, 249);
            this.PCBCamara.Name = "PCBCamara";
            this.PCBCamara.Size = new System.Drawing.Size(140, 140);
            this.PCBCamara.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PCBCamara.TabIndex = 71;
            this.PCBCamara.TabStop = false;
            // 
            // BTNCodigoDeBarras
            // 
            this.BTNCodigoDeBarras.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.BTNCodigoDeBarras.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.BTNCodigoDeBarras.Image = global::SistemaDeInventario2026.Properties.Resources.ic_lectorBarras23;
            this.BTNCodigoDeBarras.ImageFixedSize = new System.Drawing.Size(15, 15);
            this.BTNCodigoDeBarras.Location = new System.Drawing.Point(634, 155);
            this.BTNCodigoDeBarras.Name = "BTNCodigoDeBarras";
            this.BTNCodigoDeBarras.Size = new System.Drawing.Size(23, 23);
            this.BTNCodigoDeBarras.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.BTNCodigoDeBarras.TabIndex = 69;
            this.BTNCodigoDeBarras.Click += new System.EventHandler(this.BTNCodigoDeBarras_Click);
            this.BTNCodigoDeBarras.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.BTNCodigoDeBarras_KeyPress);
            // 
            // TXTProductoDescripcion
            // 
            this.TXTProductoDescripcion.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.TXTProductoDescripcion.Border.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.TXTProductoDescripcion.Border.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.TXTProductoDescripcion.Border.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.TXTProductoDescripcion.Border.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.TXTProductoDescripcion.Border.Class = "TextBoxBorder";
            this.TXTProductoDescripcion.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.TXTProductoDescripcion.DisabledBackColor = System.Drawing.Color.White;
            this.TXTProductoDescripcion.ForeColor = System.Drawing.Color.Black;
            this.TXTProductoDescripcion.Location = new System.Drawing.Point(698, 262);
            this.TXTProductoDescripcion.Multiline = true;
            this.TXTProductoDescripcion.Name = "TXTProductoDescripcion";
            this.TXTProductoDescripcion.PreventEnterBeep = true;
            this.TXTProductoDescripcion.Size = new System.Drawing.Size(476, 75);
            this.TXTProductoDescripcion.TabIndex = 68;
            // 
            // LBLCodigoDeBarras
            // 
            this.LBLCodigoDeBarras.BackColor = System.Drawing.Color.LightGreen;
            // 
            // 
            // 
            this.LBLCodigoDeBarras.BackgroundStyle.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.DashDot;
            this.LBLCodigoDeBarras.BackgroundStyle.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.DashDot;
            this.LBLCodigoDeBarras.BackgroundStyle.BorderRight = DevComponents.DotNetBar.eStyleBorderType.DashDot;
            this.LBLCodigoDeBarras.BackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.DashDot;
            this.LBLCodigoDeBarras.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.LBLCodigoDeBarras.Location = new System.Drawing.Point(321, 155);
            this.LBLCodigoDeBarras.Name = "LBLCodigoDeBarras";
            this.LBLCodigoDeBarras.Size = new System.Drawing.Size(298, 23);
            this.LBLCodigoDeBarras.TabIndex = 67;
            this.LBLCodigoDeBarras.Text = "Sin codigo";
            // 
            // materialLabel13
            // 
            this.materialLabel13.AutoSize = true;
            this.materialLabel13.Cursor = System.Windows.Forms.Cursors.Default;
            this.materialLabel13.Depth = 0;
            this.materialLabel13.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel13.Location = new System.Drawing.Point(322, 133);
            this.materialLabel13.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel13.Name = "materialLabel13";
            this.materialLabel13.Size = new System.Drawing.Size(122, 19);
            this.materialLabel13.TabIndex = 66;
            this.materialLabel13.Text = "Código de Barras";
            // 
            // materialLabel10
            // 
            this.materialLabel10.AutoSize = true;
            this.materialLabel10.Depth = 0;
            this.materialLabel10.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel10.Location = new System.Drawing.Point(997, 344);
            this.materialLabel10.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel10.Name = "materialLabel10";
            this.materialLabel10.Size = new System.Drawing.Size(90, 19);
            this.materialLabel10.TabIndex = 65;
            this.materialLabel10.Text = "Precio Venta";
            // 
            // materialLabel11
            // 
            this.materialLabel11.AutoSize = true;
            this.materialLabel11.Depth = 0;
            this.materialLabel11.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel11.Location = new System.Drawing.Point(817, 344);
            this.materialLabel11.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel11.Name = "materialLabel11";
            this.materialLabel11.Size = new System.Drawing.Size(125, 19);
            this.materialLabel11.TabIndex = 64;
            this.materialLabel11.Text = "Precio Min. Venta";
            // 
            // materialLabel12
            // 
            this.materialLabel12.AutoSize = true;
            this.materialLabel12.Depth = 0;
            this.materialLabel12.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel12.Location = new System.Drawing.Point(692, 344);
            this.materialLabel12.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel12.Name = "materialLabel12";
            this.materialLabel12.Size = new System.Drawing.Size(90, 19);
            this.materialLabel12.TabIndex = 63;
            this.materialLabel12.Text = "Stock Actual";
            // 
            // TXTModelo
            // 
            this.TXTModelo.Location = new System.Drawing.Point(698, 95);
            this.TXTModelo.Name = "TXTModelo";
            this.TXTModelo.Size = new System.Drawing.Size(223, 23);
            this.TXTModelo.TabIndex = 61;
            this.TXTModelo.Enter += new System.EventHandler(this.TXTModelo_Enter);
            // 
            // materialLabel9
            // 
            this.materialLabel9.AutoSize = true;
            this.materialLabel9.Depth = 0;
            this.materialLabel9.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel9.Location = new System.Drawing.Point(692, 73);
            this.materialLabel9.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel9.Name = "materialLabel9";
            this.materialLabel9.Size = new System.Drawing.Size(54, 19);
            this.materialLabel9.TabIndex = 60;
            this.materialLabel9.Text = "Modelo";
            // 
            // NUDStockActual
            // 
            this.NUDStockActual.DecimalPlaces = 2;
            this.NUDStockActual.Location = new System.Drawing.Point(695, 366);
            this.NUDStockActual.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.NUDStockActual.Name = "NUDStockActual";
            this.NUDStockActual.Size = new System.Drawing.Size(102, 23);
            this.NUDStockActual.TabIndex = 59;
            // 
            // NUDPrecioVenta
            // 
            this.NUDPrecioVenta.DecimalPlaces = 2;
            this.NUDPrecioVenta.Location = new System.Drawing.Point(1000, 366);
            this.NUDPrecioVenta.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.NUDPrecioVenta.Name = "NUDPrecioVenta";
            this.NUDPrecioVenta.Size = new System.Drawing.Size(174, 23);
            this.NUDPrecioVenta.TabIndex = 58;
            this.NUDPrecioVenta.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // NUDPrecioMinVenta
            // 
            this.NUDPrecioMinVenta.DecimalPlaces = 2;
            this.NUDPrecioMinVenta.Location = new System.Drawing.Point(820, 366);
            this.NUDPrecioMinVenta.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.NUDPrecioMinVenta.Name = "NUDPrecioMinVenta";
            this.NUDPrecioMinVenta.Size = new System.Drawing.Size(174, 23);
            this.NUDPrecioMinVenta.TabIndex = 57;
            this.NUDPrecioMinVenta.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(692, 240);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(84, 19);
            this.materialLabel1.TabIndex = 56;
            this.materialLabel1.Text = "Descripción";
            // 
            // SWBEstadoStock
            // 
            // 
            // 
            // 
            this.SWBEstadoStock.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.SWBEstadoStock.Location = new System.Drawing.Point(695, 42);
            this.SWBEstadoStock.Name = "SWBEstadoStock";
            this.SWBEstadoStock.OffText = "INHABILITADO";
            this.SWBEstadoStock.OnText = "HABILITADO";
            this.SWBEstadoStock.Size = new System.Drawing.Size(226, 24);
            this.SWBEstadoStock.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.SWBEstadoStock.TabIndex = 54;
            this.SWBEstadoStock.ValueChanged += new System.EventHandler(this.SWBEstadoStock_ValueChanged);
            // 
            // materialLabel8
            // 
            this.materialLabel8.AutoSize = true;
            this.materialLabel8.Depth = 0;
            this.materialLabel8.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel8.Location = new System.Drawing.Point(964, 78);
            this.materialLabel8.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel8.Name = "materialLabel8";
            this.materialLabel8.Size = new System.Drawing.Size(51, 19);
            this.materialLabel8.TabIndex = 50;
            this.materialLabel8.Text = "Género";
            // 
            // materialLabel7
            // 
            this.materialLabel7.AutoSize = true;
            this.materialLabel7.Depth = 0;
            this.materialLabel7.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel7.Location = new System.Drawing.Point(964, 192);
            this.materialLabel7.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel7.Name = "materialLabel7";
            this.materialLabel7.Size = new System.Drawing.Size(59, 19);
            this.materialLabel7.TabIndex = 49;
            this.materialLabel7.Text = "Material";
            // 
            // materialLabel6
            // 
            this.materialLabel6.AutoSize = true;
            this.materialLabel6.Depth = 0;
            this.materialLabel6.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel6.Location = new System.Drawing.Point(692, 133);
            this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel6.Name = "materialLabel6";
            this.materialLabel6.Size = new System.Drawing.Size(37, 19);
            this.materialLabel6.TabIndex = 43;
            this.materialLabel6.Text = "Talla";
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel5.Location = new System.Drawing.Point(692, 187);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(38, 19);
            this.materialLabel5.TabIndex = 41;
            this.materialLabel5.Text = "Color";
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel4.Location = new System.Drawing.Point(919, 408);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(37, 19);
            this.materialLabel4.TabIndex = 40;
            this.materialLabel4.Text = "Talla";
            // 
            // FLYTallas
            // 
            this.FLYTallas.AutoScroll = true;
            this.FLYTallas.Controls.Add(this.RBTTS);
            this.FLYTallas.Controls.Add(this.RBTTM);
            this.FLYTallas.Controls.Add(this.RBTTL);
            this.FLYTallas.Controls.Add(this.RBTTXL);
            this.FLYTallas.Location = new System.Drawing.Point(922, 430);
            this.FLYTallas.Name = "FLYTallas";
            this.FLYTallas.Size = new System.Drawing.Size(142, 32);
            this.FLYTallas.TabIndex = 39;
            this.FLYTallas.WrapContents = false;
            // 
            // RBTTS
            // 
            this.RBTTS.Appearance = System.Windows.Forms.Appearance.Button;
            this.RBTTS.Location = new System.Drawing.Point(3, 3);
            this.RBTTS.Name = "RBTTS";
            this.RBTTS.Size = new System.Drawing.Size(25, 26);
            this.RBTTS.TabIndex = 40;
            this.RBTTS.Text = "S";
            this.RBTTS.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.RBTTS.UseVisualStyleBackColor = true;
            // 
            // RBTTM
            // 
            this.RBTTM.Appearance = System.Windows.Forms.Appearance.Button;
            this.RBTTM.Location = new System.Drawing.Point(34, 3);
            this.RBTTM.Name = "RBTTM";
            this.RBTTM.Size = new System.Drawing.Size(25, 26);
            this.RBTTM.TabIndex = 41;
            this.RBTTM.Text = "M";
            this.RBTTM.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.RBTTM.UseVisualStyleBackColor = true;
            // 
            // RBTTL
            // 
            this.RBTTL.Appearance = System.Windows.Forms.Appearance.Button;
            this.RBTTL.Location = new System.Drawing.Point(65, 3);
            this.RBTTL.Name = "RBTTL";
            this.RBTTL.Size = new System.Drawing.Size(25, 26);
            this.RBTTL.TabIndex = 42;
            this.RBTTL.Text = "L";
            this.RBTTL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.RBTTL.UseVisualStyleBackColor = true;
            // 
            // RBTTXL
            // 
            this.RBTTXL.Appearance = System.Windows.Forms.Appearance.Button;
            this.RBTTXL.Location = new System.Drawing.Point(96, 3);
            this.RBTTXL.Name = "RBTTXL";
            this.RBTTXL.Size = new System.Drawing.Size(35, 26);
            this.RBTTXL.TabIndex = 43;
            this.RBTTXL.Text = "XL";
            this.RBTTXL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.RBTTXL.UseVisualStyleBackColor = true;
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.Location = new System.Drawing.Point(964, 25);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(46, 19);
            this.materialLabel2.TabIndex = 35;
            this.materialLabel2.Text = "Marca";
            // 
            // BTNLimpiar
            // 
            this.BTNLimpiar.BackColor = System.Drawing.Color.White;
            this.BTNLimpiar.FlatAppearance.BorderSize = 0;
            this.BTNLimpiar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.BTNLimpiar.ForeColor = System.Drawing.Color.Black;
            this.BTNLimpiar.Location = new System.Drawing.Point(714, 430);
            this.BTNLimpiar.Name = "BTNLimpiar";
            this.BTNLimpiar.Size = new System.Drawing.Size(158, 38);
            this.BTNLimpiar.TabIndex = 30;
            this.BTNLimpiar.Text = "Limpiar";
            this.BTNLimpiar.UseVisualStyleBackColor = false;
            this.BTNLimpiar.Click += new System.EventHandler(this.BTNLimpiar_Click);
            // 
            // BTNSalir
            // 
            this.BTNSalir.BackColor = System.Drawing.Color.White;
            this.BTNSalir.FlatAppearance.BorderSize = 0;
            this.BTNSalir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.BTNSalir.ForeColor = System.Drawing.Color.Black;
            this.BTNSalir.Location = new System.Drawing.Point(391, 430);
            this.BTNSalir.Name = "BTNSalir";
            this.BTNSalir.Size = new System.Drawing.Size(158, 38);
            this.BTNSalir.TabIndex = 29;
            this.BTNSalir.Text = "Salir";
            this.BTNSalir.UseVisualStyleBackColor = false;
            this.BTNSalir.Click += new System.EventHandler(this.BTNSalir_Click);
            // 
            // BTNGrabar
            // 
            this.BTNGrabar.BackColor = System.Drawing.Color.Black;
            this.BTNGrabar.FlatAppearance.BorderSize = 0;
            this.BTNGrabar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.BTNGrabar.ForeColor = System.Drawing.Color.White;
            this.BTNGrabar.Location = new System.Drawing.Point(555, 430);
            this.BTNGrabar.Name = "BTNGrabar";
            this.BTNGrabar.Size = new System.Drawing.Size(153, 38);
            this.BTNGrabar.TabIndex = 28;
            this.BTNGrabar.Text = "Grabar";
            this.BTNGrabar.UseVisualStyleBackColor = false;
            this.BTNGrabar.Click += new System.EventHandler(this.BTNGrabar_Click);
            // 
            // LBL
            // 
            this.LBL.AutoSize = true;
            this.LBL.Depth = 0;
            this.LBL.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.LBL.Location = new System.Drawing.Point(967, 134);
            this.LBL.MouseState = MaterialSkin.MouseState.HOVER;
            this.LBL.Name = "LBL";
            this.LBL.Size = new System.Drawing.Size(69, 19);
            this.LBL.TabIndex = 16;
            this.LBL.Text = "Categoria";
            // 
            // LBLRegistrarProducto
            // 
            this.LBLRegistrarProducto.AutoSize = true;
            // 
            // 
            // 
            this.LBLRegistrarProducto.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.LBLRegistrarProducto.Cursor = System.Windows.Forms.Cursors.Default;
            this.LBLRegistrarProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLRegistrarProducto.FontBold = true;
            this.LBLRegistrarProducto.Location = new System.Drawing.Point(323, 36);
            this.LBLRegistrarProducto.Name = "LBLRegistrarProducto";
            this.LBLRegistrarProducto.Size = new System.Drawing.Size(219, 35);
            this.LBLRegistrarProducto.TabIndex = 14;
            this.LBLRegistrarProducto.Text = "Agregar Producto";
            this.LBLRegistrarProducto.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel2.Controls.Add(this.BTNAdministracionUsuarios);
            this.panel2.Controls.Add(this.BTNPuntoDeVenta);
            this.panel2.Controls.Add(this.BTNBusquedaAvanzada);
            this.panel2.Controls.Add(this.BTNInventario);
            this.panel2.Controls.Add(this.BTNDirectorio);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(270, 509);
            this.panel2.TabIndex = 13;
            // 
            // BTNAdministracionUsuarios
            // 
            this.BTNAdministracionUsuarios.BackColor = System.Drawing.Color.Transparent;
            this.BTNAdministracionUsuarios.FlatAppearance.BorderSize = 0;
            this.BTNAdministracionUsuarios.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveBorder;
            this.BTNAdministracionUsuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTNAdministracionUsuarios.Image = global::SistemaDeInventario2026.Properties.Resources.ic_candado40;
            this.BTNAdministracionUsuarios.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTNAdministracionUsuarios.Location = new System.Drawing.Point(10, 237);
            this.BTNAdministracionUsuarios.Margin = new System.Windows.Forms.Padding(4);
            this.BTNAdministracionUsuarios.Name = "BTNAdministracionUsuarios";
            this.BTNAdministracionUsuarios.Size = new System.Drawing.Size(250, 50);
            this.BTNAdministracionUsuarios.TabIndex = 4;
            this.BTNAdministracionUsuarios.Text = "Administración de Usuarios";
            this.BTNAdministracionUsuarios.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTNAdministracionUsuarios.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BTNAdministracionUsuarios.UseVisualStyleBackColor = false;
            // 
            // BTNPuntoDeVenta
            // 
            this.BTNPuntoDeVenta.BackColor = System.Drawing.Color.Transparent;
            this.BTNPuntoDeVenta.FlatAppearance.BorderSize = 0;
            this.BTNPuntoDeVenta.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveBorder;
            this.BTNPuntoDeVenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTNPuntoDeVenta.Image = global::SistemaDeInventario2026.Properties.Resources.ic_venta40;
            this.BTNPuntoDeVenta.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTNPuntoDeVenta.Location = new System.Drawing.Point(10, 183);
            this.BTNPuntoDeVenta.Margin = new System.Windows.Forms.Padding(4);
            this.BTNPuntoDeVenta.Name = "BTNPuntoDeVenta";
            this.BTNPuntoDeVenta.Size = new System.Drawing.Size(250, 50);
            this.BTNPuntoDeVenta.TabIndex = 3;
            this.BTNPuntoDeVenta.Text = "Punto de Venta";
            this.BTNPuntoDeVenta.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTNPuntoDeVenta.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BTNPuntoDeVenta.UseVisualStyleBackColor = false;
            // 
            // BTNBusquedaAvanzada
            // 
            this.BTNBusquedaAvanzada.BackColor = System.Drawing.Color.Transparent;
            this.BTNBusquedaAvanzada.FlatAppearance.BorderSize = 0;
            this.BTNBusquedaAvanzada.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveBorder;
            this.BTNBusquedaAvanzada.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTNBusquedaAvanzada.Image = global::SistemaDeInventario2026.Properties.Resources.ic_buscar40;
            this.BTNBusquedaAvanzada.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTNBusquedaAvanzada.Location = new System.Drawing.Point(10, 129);
            this.BTNBusquedaAvanzada.Margin = new System.Windows.Forms.Padding(4);
            this.BTNBusquedaAvanzada.Name = "BTNBusquedaAvanzada";
            this.BTNBusquedaAvanzada.Size = new System.Drawing.Size(250, 50);
            this.BTNBusquedaAvanzada.TabIndex = 2;
            this.BTNBusquedaAvanzada.Text = "Búsqueda Avanzada";
            this.BTNBusquedaAvanzada.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTNBusquedaAvanzada.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BTNBusquedaAvanzada.UseVisualStyleBackColor = false;
            // 
            // BTNInventario
            // 
            this.BTNInventario.BackColor = System.Drawing.Color.Transparent;
            this.BTNInventario.FlatAppearance.BorderSize = 0;
            this.BTNInventario.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveBorder;
            this.BTNInventario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTNInventario.Image = global::SistemaDeInventario2026.Properties.Resources.icons8_producto_100__1___1_;
            this.BTNInventario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTNInventario.Location = new System.Drawing.Point(10, 75);
            this.BTNInventario.Margin = new System.Windows.Forms.Padding(4);
            this.BTNInventario.Name = "BTNInventario";
            this.BTNInventario.Size = new System.Drawing.Size(250, 50);
            this.BTNInventario.TabIndex = 1;
            this.BTNInventario.Text = "Inventario";
            this.BTNInventario.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTNInventario.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BTNInventario.UseVisualStyleBackColor = false;
            // 
            // BTNDirectorio
            // 
            this.BTNDirectorio.BackColor = System.Drawing.Color.Transparent;
            this.BTNDirectorio.FlatAppearance.BorderSize = 0;
            this.BTNDirectorio.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveBorder;
            this.BTNDirectorio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTNDirectorio.Image = global::SistemaDeInventario2026.Properties.Resources.ic_proveedor40;
            this.BTNDirectorio.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTNDirectorio.Location = new System.Drawing.Point(10, 21);
            this.BTNDirectorio.Margin = new System.Windows.Forms.Padding(4);
            this.BTNDirectorio.Name = "BTNDirectorio";
            this.BTNDirectorio.Size = new System.Drawing.Size(250, 50);
            this.BTNDirectorio.TabIndex = 0;
            this.BTNDirectorio.Text = "Gestíon de Inversión y Proveedores";
            this.BTNDirectorio.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTNDirectorio.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BTNDirectorio.UseVisualStyleBackColor = false;
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Cursor = System.Windows.Forms.Cursors.Default;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel3.Location = new System.Drawing.Point(322, 187);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(57, 19);
            this.materialLabel3.TabIndex = 3;
            this.materialLabel3.Text = "Nombre";
            // 
            // FRMProducto_Registrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1237, 554);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.PPrincipal);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FRMProducto_Registrar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FRMProducto_Registrar";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FRMProducto_Registrar_FormClosing);
            this.Load += new System.EventHandler(this.FRMProducto_Registrar_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.PPrincipal.ResumeLayout(false);
            this.PPrincipal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PCBFotografia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PCBCamara)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDStockActual)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDPrecioVenta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDPrecioMinVenta)).EndInit();
            this.FLYTallas.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.OpenFileDialog OFDElegirImagen;
        private DevComponents.DotNetBar.BalloonTip BLTAyuda;
        private System.Windows.Forms.Panel panel1;
        private DevComponents.DotNetBar.ButtonX BTNBusquedaGeneral;
        private System.Windows.Forms.TextBox TXTFiltrarGeneral;
        private System.Windows.Forms.Button BTNConfiguracion;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Panel PPrincipal;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private System.Windows.Forms.Button BTNLimpiar;
        private System.Windows.Forms.Button BTNSalir;
        private System.Windows.Forms.Button BTNGrabar;
        private MaterialSkin.Controls.MaterialLabel LBL;
        private DevComponents.DotNetBar.LabelX LBLRegistrarProducto;
        private System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.Button BTNAdministracionUsuarios;
        public System.Windows.Forms.Button BTNPuntoDeVenta;
        public System.Windows.Forms.Button BTNBusquedaAvanzada;
        public System.Windows.Forms.Button BTNInventario;
        public System.Windows.Forms.Button BTNDirectorio;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private System.Windows.Forms.FlowLayoutPanel FLYTallas;
        private System.Windows.Forms.RadioButton RBTTS;
        private System.Windows.Forms.RadioButton RBTTM;
        private System.Windows.Forms.RadioButton RBTTL;
        private System.Windows.Forms.RadioButton RBTTXL;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialLabel materialLabel8;
        private MaterialSkin.Controls.MaterialLabel materialLabel7;
        private DevComponents.DotNetBar.Controls.SwitchButton SWBEstadoStock;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private System.Windows.Forms.NumericUpDown NUDStockActual;
        private System.Windows.Forms.NumericUpDown NUDPrecioVenta;
        private System.Windows.Forms.NumericUpDown NUDPrecioMinVenta;
        private MaterialSkin.Controls.MaterialLabel materialLabel9;
        private System.Windows.Forms.TextBox TXTModelo;
        private MaterialSkin.Controls.MaterialLabel materialLabel10;
        private MaterialSkin.Controls.MaterialLabel materialLabel11;
        private MaterialSkin.Controls.MaterialLabel materialLabel12;
        private MaterialSkin.Controls.MaterialLabel materialLabel13;
        private DevComponents.DotNetBar.LabelX LBLCodigoDeBarras;
        private DevComponents.DotNetBar.Controls.TextBoxX TXTProductoDescripcion;
        private DevComponents.DotNetBar.ButtonX BTNCodigoDeBarras;
        private System.Windows.Forms.Button BTNCapturarFoto;
        private System.Windows.Forms.PictureBox PCBFotografia;
        private System.Windows.Forms.PictureBox PCBCamara;
        private System.Windows.Forms.Button BTNAbrirFoto;
        private System.Windows.Forms.Button BTNLimpiarFoto;
        private DevComponents.DotNetBar.Controls.ComboBoxEx CMBGenero;
        private DevComponents.Editors.ComboItem comboItem1;
        private DevComponents.Editors.ComboItem comboItem2;
        private DevComponents.Editors.ComboItem comboItem3;
        private DevComponents.DotNetBar.Controls.ComboBoxEx CMBCategoria;
        private DevComponents.DotNetBar.Controls.ComboBoxEx CMBTalla;
        private DevComponents.DotNetBar.Controls.ComboBoxEx CMBColor;
        private DevComponents.DotNetBar.Controls.ComboBoxEx CMBMaterial;
        private DevComponents.DotNetBar.Controls.ComboBoxEx CMBProductoNombre;
        private DevComponents.DotNetBar.Controls.ComboBoxEx CMBMarca;
    }
}