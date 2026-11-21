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
            this.PPrincipal = new System.Windows.Forms.Panel();
            this.PAgregar_Producto = new System.Windows.Forms.Panel();
            this.CMBMaterial = new Krypton.Toolkit.KryptonComboBox();
            this.CMBGenero = new Krypton.Toolkit.KryptonComboBox();
            this.CMBCategoria = new Krypton.Toolkit.KryptonComboBox();
            this.CMBMarca = new Krypton.Toolkit.KryptonComboBox();
            this.CMBColor = new Krypton.Toolkit.KryptonComboBox();
            this.CMBTalla = new Krypton.Toolkit.KryptonComboBox();
            this.CMBProductoNombre = new Krypton.Toolkit.KryptonComboBox();
            this.materialLabel17 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel18 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel15 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel16 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel14 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
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
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.BTNLimpiar = new System.Windows.Forms.Button();
            this.BTNSalir = new System.Windows.Forms.Button();
            this.BTNGrabar = new System.Windows.Forms.Button();
            this.LBL = new MaterialSkin.Controls.MaterialLabel();
            this.LBLRegistrarProducto = new DevComponents.DotNetBar.LabelX();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.comboItem3 = new DevComponents.Editors.ComboItem();
            this.comboItem2 = new DevComponents.Editors.ComboItem();
            this.comboItem1 = new DevComponents.Editors.ComboItem();
            this.PPrincipal.SuspendLayout();
            this.PAgregar_Producto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CMBMaterial)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CMBGenero)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CMBCategoria)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CMBMarca)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CMBColor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CMBTalla)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CMBProductoNombre)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PCBFotografia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PCBCamara)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDStockActual)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDPrecioVenta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDPrecioMinVenta)).BeginInit();
            this.SuspendLayout();
            // 
            // OFDElegirImagen
            // 
            this.OFDElegirImagen.Filter = "Archivos de Imagen|*.jpg;*.jpeg;*.png";
            this.OFDElegirImagen.Title = "Elegir fotografía";
            // 
            // PPrincipal
            // 
            this.PPrincipal.AutoScroll = true;
            this.PPrincipal.BackColor = System.Drawing.Color.White;
            this.PPrincipal.Controls.Add(this.PAgregar_Producto);
            this.PPrincipal.Cursor = System.Windows.Forms.Cursors.Default;
            this.PPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PPrincipal.Location = new System.Drawing.Point(0, 0);
            this.PPrincipal.Name = "PPrincipal";
            this.PPrincipal.Size = new System.Drawing.Size(802, 554);
            this.PPrincipal.TabIndex = 7;
            // 
            // PAgregar_Producto
            // 
            this.PAgregar_Producto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PAgregar_Producto.Controls.Add(this.CMBMaterial);
            this.PAgregar_Producto.Controls.Add(this.CMBGenero);
            this.PAgregar_Producto.Controls.Add(this.CMBCategoria);
            this.PAgregar_Producto.Controls.Add(this.CMBMarca);
            this.PAgregar_Producto.Controls.Add(this.CMBColor);
            this.PAgregar_Producto.Controls.Add(this.CMBTalla);
            this.PAgregar_Producto.Controls.Add(this.CMBProductoNombre);
            this.PAgregar_Producto.Controls.Add(this.materialLabel17);
            this.PAgregar_Producto.Controls.Add(this.materialLabel18);
            this.PAgregar_Producto.Controls.Add(this.materialLabel15);
            this.PAgregar_Producto.Controls.Add(this.materialLabel16);
            this.PAgregar_Producto.Controls.Add(this.materialLabel14);
            this.PAgregar_Producto.Controls.Add(this.materialLabel4);
            this.PAgregar_Producto.Controls.Add(this.BTNAbrirFoto);
            this.PAgregar_Producto.Controls.Add(this.BTNLimpiarFoto);
            this.PAgregar_Producto.Controls.Add(this.BTNCapturarFoto);
            this.PAgregar_Producto.Controls.Add(this.PCBFotografia);
            this.PAgregar_Producto.Controls.Add(this.PCBCamara);
            this.PAgregar_Producto.Controls.Add(this.BTNCodigoDeBarras);
            this.PAgregar_Producto.Controls.Add(this.TXTProductoDescripcion);
            this.PAgregar_Producto.Controls.Add(this.LBLCodigoDeBarras);
            this.PAgregar_Producto.Controls.Add(this.materialLabel13);
            this.PAgregar_Producto.Controls.Add(this.materialLabel10);
            this.PAgregar_Producto.Controls.Add(this.materialLabel11);
            this.PAgregar_Producto.Controls.Add(this.materialLabel12);
            this.PAgregar_Producto.Controls.Add(this.TXTModelo);
            this.PAgregar_Producto.Controls.Add(this.materialLabel9);
            this.PAgregar_Producto.Controls.Add(this.NUDStockActual);
            this.PAgregar_Producto.Controls.Add(this.NUDPrecioVenta);
            this.PAgregar_Producto.Controls.Add(this.NUDPrecioMinVenta);
            this.PAgregar_Producto.Controls.Add(this.materialLabel1);
            this.PAgregar_Producto.Controls.Add(this.SWBEstadoStock);
            this.PAgregar_Producto.Controls.Add(this.materialLabel8);
            this.PAgregar_Producto.Controls.Add(this.materialLabel7);
            this.PAgregar_Producto.Controls.Add(this.materialLabel6);
            this.PAgregar_Producto.Controls.Add(this.materialLabel5);
            this.PAgregar_Producto.Controls.Add(this.materialLabel2);
            this.PAgregar_Producto.Controls.Add(this.BTNLimpiar);
            this.PAgregar_Producto.Controls.Add(this.BTNSalir);
            this.PAgregar_Producto.Controls.Add(this.BTNGrabar);
            this.PAgregar_Producto.Controls.Add(this.LBL);
            this.PAgregar_Producto.Controls.Add(this.LBLRegistrarProducto);
            this.PAgregar_Producto.Controls.Add(this.materialLabel3);
            this.PAgregar_Producto.Location = new System.Drawing.Point(0, 0);
            this.PAgregar_Producto.Name = "PAgregar_Producto";
            this.PAgregar_Producto.Size = new System.Drawing.Size(802, 554);
            this.PAgregar_Producto.TabIndex = 14;
            // 
            // CMBMaterial
            // 
            this.CMBMaterial.Location = new System.Drawing.Point(565, 264);
            this.CMBMaterial.Name = "CMBMaterial";
            this.CMBMaterial.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalOffice2003;
            this.CMBMaterial.Size = new System.Drawing.Size(191, 22);
            this.CMBMaterial.StateCommon.ComboBox.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.CMBMaterial.StateCommon.Item.Back.Color1 = System.Drawing.Color.White;
            this.CMBMaterial.StateCommon.Item.Back.Color2 = System.Drawing.Color.White;
            this.CMBMaterial.StateCommon.Item.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            this.CMBMaterial.StateTracking.Item.Back.Color1 = System.Drawing.Color.DeepSkyBlue;
            this.CMBMaterial.StateTracking.Item.Back.Color2 = System.Drawing.Color.DeepSkyBlue;
            this.CMBMaterial.StateTracking.Item.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            this.CMBMaterial.TabIndex = 151;
            // 
            // CMBGenero
            // 
            this.CMBGenero.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CMBGenero.Items.AddRange(new object[] {
            "Hombre",
            "Mujer",
            "Unisex"});
            this.CMBGenero.Location = new System.Drawing.Point(565, 154);
            this.CMBGenero.Name = "CMBGenero";
            this.CMBGenero.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalOffice2003;
            this.CMBGenero.Size = new System.Drawing.Size(191, 22);
            this.CMBGenero.StateCommon.ComboBox.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.CMBGenero.StateCommon.Item.Back.Color1 = System.Drawing.Color.White;
            this.CMBGenero.StateCommon.Item.Back.Color2 = System.Drawing.Color.White;
            this.CMBGenero.StateCommon.Item.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            this.CMBGenero.StateTracking.Item.Back.Color1 = System.Drawing.Color.DeepSkyBlue;
            this.CMBGenero.StateTracking.Item.Back.Color2 = System.Drawing.Color.DeepSkyBlue;
            this.CMBGenero.StateTracking.Item.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            this.CMBGenero.TabIndex = 150;
            // 
            // CMBCategoria
            // 
            this.CMBCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CMBCategoria.Location = new System.Drawing.Point(565, 209);
            this.CMBCategoria.Name = "CMBCategoria";
            this.CMBCategoria.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalOffice2003;
            this.CMBCategoria.Size = new System.Drawing.Size(191, 22);
            this.CMBCategoria.StateCommon.ComboBox.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.CMBCategoria.StateCommon.Item.Back.Color1 = System.Drawing.Color.White;
            this.CMBCategoria.StateCommon.Item.Back.Color2 = System.Drawing.Color.White;
            this.CMBCategoria.StateCommon.Item.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            this.CMBCategoria.StateTracking.Item.Back.Color1 = System.Drawing.Color.DeepSkyBlue;
            this.CMBCategoria.StateTracking.Item.Back.Color2 = System.Drawing.Color.DeepSkyBlue;
            this.CMBCategoria.StateTracking.Item.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            this.CMBCategoria.TabIndex = 149;
            // 
            // CMBMarca
            // 
            this.CMBMarca.Location = new System.Drawing.Point(565, 96);
            this.CMBMarca.Name = "CMBMarca";
            this.CMBMarca.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalOffice2003;
            this.CMBMarca.Size = new System.Drawing.Size(191, 22);
            this.CMBMarca.StateCommon.ComboBox.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.CMBMarca.StateCommon.Item.Back.Color1 = System.Drawing.Color.White;
            this.CMBMarca.StateCommon.Item.Back.Color2 = System.Drawing.Color.White;
            this.CMBMarca.StateCommon.Item.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            this.CMBMarca.StateTracking.Item.Back.Color1 = System.Drawing.Color.DeepSkyBlue;
            this.CMBMarca.StateTracking.Item.Back.Color2 = System.Drawing.Color.DeepSkyBlue;
            this.CMBMarca.StateTracking.Item.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            this.CMBMarca.TabIndex = 148;
            // 
            // CMBColor
            // 
            this.CMBColor.Location = new System.Drawing.Point(310, 264);
            this.CMBColor.Name = "CMBColor";
            this.CMBColor.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalOffice2003;
            this.CMBColor.Size = new System.Drawing.Size(226, 22);
            this.CMBColor.StateCommon.ComboBox.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.CMBColor.StateCommon.Item.Back.Color1 = System.Drawing.Color.White;
            this.CMBColor.StateCommon.Item.Back.Color2 = System.Drawing.Color.White;
            this.CMBColor.StateCommon.Item.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            this.CMBColor.StateTracking.Item.Back.Color1 = System.Drawing.Color.DeepSkyBlue;
            this.CMBColor.StateTracking.Item.Back.Color2 = System.Drawing.Color.DeepSkyBlue;
            this.CMBColor.StateTracking.Item.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            this.CMBColor.TabIndex = 147;
            // 
            // CMBTalla
            // 
            this.CMBTalla.Location = new System.Drawing.Point(310, 209);
            this.CMBTalla.Name = "CMBTalla";
            this.CMBTalla.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalOffice2003;
            this.CMBTalla.Size = new System.Drawing.Size(226, 22);
            this.CMBTalla.StateCommon.ComboBox.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.CMBTalla.StateCommon.Item.Back.Color1 = System.Drawing.Color.White;
            this.CMBTalla.StateCommon.Item.Back.Color2 = System.Drawing.Color.White;
            this.CMBTalla.StateCommon.Item.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            this.CMBTalla.StateTracking.Item.Back.Color1 = System.Drawing.Color.DeepSkyBlue;
            this.CMBTalla.StateTracking.Item.Back.Color2 = System.Drawing.Color.DeepSkyBlue;
            this.CMBTalla.StateTracking.Item.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            this.CMBTalla.TabIndex = 145;
            // 
            // CMBProductoNombre
            // 
            this.CMBProductoNombre.Location = new System.Drawing.Point(40, 154);
            this.CMBProductoNombre.Name = "CMBProductoNombre";
            this.CMBProductoNombre.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalOffice2003;
            this.CMBProductoNombre.Size = new System.Drawing.Size(239, 22);
            this.CMBProductoNombre.StateCommon.ComboBox.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.CMBProductoNombre.StateCommon.Item.Back.Color1 = System.Drawing.Color.White;
            this.CMBProductoNombre.StateCommon.Item.Back.Color2 = System.Drawing.Color.White;
            this.CMBProductoNombre.StateCommon.Item.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            this.CMBProductoNombre.StateTracking.Item.Back.Color1 = System.Drawing.Color.DeepSkyBlue;
            this.CMBProductoNombre.StateTracking.Item.Back.Color2 = System.Drawing.Color.DeepSkyBlue;
            this.CMBProductoNombre.StateTracking.Item.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            this.CMBProductoNombre.TabIndex = 143;
            this.CMBProductoNombre.Enter += new System.EventHandler(this.CMBProductoNombre_Enter);
            this.CMBProductoNombre.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CMBProductoNombre_KeyDown);
            this.CMBProductoNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CMBProductoNombre_KeyPress);
            // 
            // materialLabel17
            // 
            this.materialLabel17.AutoSize = true;
            this.materialLabel17.Depth = 0;
            this.materialLabel17.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel17.Location = new System.Drawing.Point(184, 393);
            this.materialLabel17.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel17.Name = "materialLabel17";
            this.materialLabel17.Size = new System.Drawing.Size(54, 19);
            this.materialLabel17.TabIndex = 127;
            this.materialLabel17.Text = "Imagen";
            // 
            // materialLabel18
            // 
            this.materialLabel18.AutoSize = true;
            this.materialLabel18.Depth = 0;
            this.materialLabel18.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel18.Location = new System.Drawing.Point(184, 374);
            this.materialLabel18.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel18.Name = "materialLabel18";
            this.materialLabel18.Size = new System.Drawing.Size(40, 19);
            this.materialLabel18.TabIndex = 126;
            this.materialLabel18.Text = "Elegir";
            // 
            // materialLabel15
            // 
            this.materialLabel15.AutoSize = true;
            this.materialLabel15.Depth = 0;
            this.materialLabel15.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel15.Location = new System.Drawing.Point(184, 283);
            this.materialLabel15.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel15.Name = "materialLabel15";
            this.materialLabel15.Size = new System.Drawing.Size(54, 19);
            this.materialLabel15.TabIndex = 125;
            this.materialLabel15.Text = "Imagen";
            // 
            // materialLabel16
            // 
            this.materialLabel16.AutoSize = true;
            this.materialLabel16.Depth = 0;
            this.materialLabel16.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel16.Location = new System.Drawing.Point(184, 264);
            this.materialLabel16.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel16.Name = "materialLabel16";
            this.materialLabel16.Size = new System.Drawing.Size(59, 19);
            this.materialLabel16.TabIndex = 124;
            this.materialLabel16.Text = "Eliminar";
            // 
            // materialLabel14
            // 
            this.materialLabel14.AutoSize = true;
            this.materialLabel14.Depth = 0;
            this.materialLabel14.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel14.Location = new System.Drawing.Point(184, 228);
            this.materialLabel14.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel14.Name = "materialLabel14";
            this.materialLabel14.Size = new System.Drawing.Size(57, 19);
            this.materialLabel14.TabIndex = 123;
            this.materialLabel14.Text = "Cámara";
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel4.Location = new System.Drawing.Point(184, 209);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(34, 19);
            this.materialLabel4.TabIndex = 122;
            this.materialLabel4.Text = "Abrir";
            // 
            // BTNAbrirFoto
            // 
            this.BTNAbrirFoto.BackColor = System.Drawing.Color.White;
            this.BTNAbrirFoto.FlatAppearance.BorderSize = 0;
            this.BTNAbrirFoto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.BTNAbrirFoto.ForeColor = System.Drawing.Color.White;
            this.BTNAbrirFoto.Image = global::SistemaDeInventario2026.Properties.Resources.ic_eliminar_imagen_35;
            this.BTNAbrirFoto.Location = new System.Drawing.Point(256, 264);
            this.BTNAbrirFoto.Name = "BTNAbrirFoto";
            this.BTNAbrirFoto.Size = new System.Drawing.Size(35, 35);
            this.BTNAbrirFoto.TabIndex = 114;
            this.BTNAbrirFoto.Text = "-";
            this.BTNAbrirFoto.UseVisualStyleBackColor = false;
            this.BTNAbrirFoto.Click += new System.EventHandler(this.BTNLimpiarFoto_Click);
            // 
            // BTNLimpiarFoto
            // 
            this.BTNLimpiarFoto.BackColor = System.Drawing.Color.White;
            this.BTNLimpiarFoto.FlatAppearance.BorderSize = 0;
            this.BTNLimpiarFoto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.BTNLimpiarFoto.ForeColor = System.Drawing.Color.White;
            this.BTNLimpiarFoto.Image = global::SistemaDeInventario2026.Properties.Resources.ic_elegir_imagen_35;
            this.BTNLimpiarFoto.Location = new System.Drawing.Point(256, 374);
            this.BTNLimpiarFoto.Name = "BTNLimpiarFoto";
            this.BTNLimpiarFoto.Size = new System.Drawing.Size(35, 35);
            this.BTNLimpiarFoto.TabIndex = 113;
            this.BTNLimpiarFoto.Text = "..";
            this.BTNLimpiarFoto.UseVisualStyleBackColor = false;
            this.BTNLimpiarFoto.Click += new System.EventHandler(this.BTNAbrirFoto_Click);
            // 
            // BTNCapturarFoto
            // 
            this.BTNCapturarFoto.BackColor = System.Drawing.Color.White;
            this.BTNCapturarFoto.FlatAppearance.BorderSize = 0;
            this.BTNCapturarFoto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.BTNCapturarFoto.ForeColor = System.Drawing.Color.White;
            this.BTNCapturarFoto.Image = global::SistemaDeInventario2026.Properties.Resources.ic_abrir_camara_35;
            this.BTNCapturarFoto.Location = new System.Drawing.Point(256, 210);
            this.BTNCapturarFoto.Name = "BTNCapturarFoto";
            this.BTNCapturarFoto.Size = new System.Drawing.Size(35, 35);
            this.BTNCapturarFoto.TabIndex = 112;
            this.BTNCapturarFoto.Text = "+";
            this.BTNCapturarFoto.UseVisualStyleBackColor = false;
            this.BTNCapturarFoto.Click += new System.EventHandler(this.BTNCapturarFoto_Click);
            // 
            // PCBFotografia
            // 
            this.PCBFotografia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PCBFotografia.Image = ((System.Drawing.Image)(resources.GetObject("PCBFotografia.Image")));
            this.PCBFotografia.Location = new System.Drawing.Point(40, 325);
            this.PCBFotografia.Name = "PCBFotografia";
            this.PCBFotografia.Size = new System.Drawing.Size(138, 138);
            this.PCBFotografia.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PCBFotografia.TabIndex = 111;
            this.PCBFotografia.TabStop = false;
            // 
            // PCBCamara
            // 
            this.PCBCamara.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PCBCamara.Image = ((System.Drawing.Image)(resources.GetObject("PCBCamara.Image")));
            this.PCBCamara.Location = new System.Drawing.Point(40, 183);
            this.PCBCamara.Name = "PCBCamara";
            this.PCBCamara.Size = new System.Drawing.Size(138, 138);
            this.PCBCamara.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PCBCamara.TabIndex = 110;
            this.PCBCamara.TabStop = false;
            // 
            // BTNCodigoDeBarras
            // 
            this.BTNCodigoDeBarras.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.BTNCodigoDeBarras.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.BTNCodigoDeBarras.Image = global::SistemaDeInventario2026.Properties.Resources.ic_lectorBarras23;
            this.BTNCodigoDeBarras.ImageFixedSize = new System.Drawing.Size(15, 15);
            this.BTNCodigoDeBarras.Location = new System.Drawing.Point(256, 97);
            this.BTNCodigoDeBarras.Name = "BTNCodigoDeBarras";
            this.BTNCodigoDeBarras.Size = new System.Drawing.Size(23, 23);
            this.BTNCodigoDeBarras.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.BTNCodigoDeBarras.TabIndex = 109;
            this.BTNCodigoDeBarras.Click += new System.EventHandler(this.BTNCodigoDeBarras_Click);
            this.BTNCodigoDeBarras.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.BTNCodigoDeBarras_KeyPress);
            // 
            // TXTProductoDescripcion
            // 
            this.TXTProductoDescripcion.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.TXTProductoDescripcion.Border.BackColor2 = System.Drawing.Color.Black;
            this.TXTProductoDescripcion.Border.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.TXTProductoDescripcion.Border.BorderColor = System.Drawing.Color.Black;
            this.TXTProductoDescripcion.Border.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.TXTProductoDescripcion.Border.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.TXTProductoDescripcion.Border.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.TXTProductoDescripcion.Border.Class = "TextBoxBorder";
            this.TXTProductoDescripcion.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.TXTProductoDescripcion.DisabledBackColor = System.Drawing.Color.White;
            this.TXTProductoDescripcion.ForeColor = System.Drawing.Color.Black;
            this.TXTProductoDescripcion.Location = new System.Drawing.Point(311, 317);
            this.TXTProductoDescripcion.Multiline = true;
            this.TXTProductoDescripcion.Name = "TXTProductoDescripcion";
            this.TXTProductoDescripcion.PreventEnterBeep = true;
            this.TXTProductoDescripcion.Size = new System.Drawing.Size(445, 47);
            this.TXTProductoDescripcion.TabIndex = 108;
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
            this.LBLCodigoDeBarras.Location = new System.Drawing.Point(40, 97);
            this.LBLCodigoDeBarras.Name = "LBLCodigoDeBarras";
            this.LBLCodigoDeBarras.Size = new System.Drawing.Size(210, 23);
            this.LBLCodigoDeBarras.TabIndex = 107;
            this.LBLCodigoDeBarras.Text = "Sin codigo";
            this.LBLCodigoDeBarras.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.BTNCodigoDeBarras_KeyPress);
            // 
            // materialLabel13
            // 
            this.materialLabel13.AutoSize = true;
            this.materialLabel13.Cursor = System.Windows.Forms.Cursors.Default;
            this.materialLabel13.Depth = 0;
            this.materialLabel13.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel13.Location = new System.Drawing.Point(45, 75);
            this.materialLabel13.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel13.Name = "materialLabel13";
            this.materialLabel13.Size = new System.Drawing.Size(122, 19);
            this.materialLabel13.TabIndex = 106;
            this.materialLabel13.Text = "Código de Barras";
            // 
            // materialLabel10
            // 
            this.materialLabel10.AutoSize = true;
            this.materialLabel10.Depth = 0;
            this.materialLabel10.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel10.Location = new System.Drawing.Point(604, 374);
            this.materialLabel10.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel10.Name = "materialLabel10";
            this.materialLabel10.Size = new System.Drawing.Size(90, 19);
            this.materialLabel10.TabIndex = 105;
            this.materialLabel10.Text = "Precio Venta";
            // 
            // materialLabel11
            // 
            this.materialLabel11.AutoSize = true;
            this.materialLabel11.Depth = 0;
            this.materialLabel11.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel11.Location = new System.Drawing.Point(435, 374);
            this.materialLabel11.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel11.Name = "materialLabel11";
            this.materialLabel11.Size = new System.Drawing.Size(125, 19);
            this.materialLabel11.TabIndex = 104;
            this.materialLabel11.Text = "Precio Min. Venta";
            // 
            // materialLabel12
            // 
            this.materialLabel12.AutoSize = true;
            this.materialLabel12.Depth = 0;
            this.materialLabel12.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel12.Location = new System.Drawing.Point(310, 374);
            this.materialLabel12.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel12.Name = "materialLabel12";
            this.materialLabel12.Size = new System.Drawing.Size(90, 19);
            this.materialLabel12.TabIndex = 103;
            this.materialLabel12.Text = "Stock Actual";
            // 
            // TXTModelo
            // 
            this.TXTModelo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TXTModelo.Location = new System.Drawing.Point(311, 154);
            this.TXTModelo.Name = "TXTModelo";
            this.TXTModelo.Size = new System.Drawing.Size(225, 23);
            this.TXTModelo.TabIndex = 102;
            // 
            // materialLabel9
            // 
            this.materialLabel9.AutoSize = true;
            this.materialLabel9.Depth = 0;
            this.materialLabel9.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel9.Location = new System.Drawing.Point(307, 132);
            this.materialLabel9.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel9.Name = "materialLabel9";
            this.materialLabel9.Size = new System.Drawing.Size(54, 19);
            this.materialLabel9.TabIndex = 101;
            this.materialLabel9.Text = "Modelo";
            // 
            // NUDStockActual
            // 
            this.NUDStockActual.Location = new System.Drawing.Point(313, 396);
            this.NUDStockActual.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.NUDStockActual.Name = "NUDStockActual";
            this.NUDStockActual.Size = new System.Drawing.Size(102, 23);
            this.NUDStockActual.TabIndex = 100;
            // 
            // NUDPrecioVenta
            // 
            this.NUDPrecioVenta.DecimalPlaces = 2;
            this.NUDPrecioVenta.Location = new System.Drawing.Point(605, 396);
            this.NUDPrecioVenta.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.NUDPrecioVenta.Name = "NUDPrecioVenta";
            this.NUDPrecioVenta.Size = new System.Drawing.Size(151, 23);
            this.NUDPrecioVenta.TabIndex = 99;
            this.NUDPrecioVenta.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // NUDPrecioMinVenta
            // 
            this.NUDPrecioMinVenta.DecimalPlaces = 2;
            this.NUDPrecioMinVenta.Location = new System.Drawing.Point(438, 396);
            this.NUDPrecioMinVenta.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.NUDPrecioMinVenta.Name = "NUDPrecioMinVenta";
            this.NUDPrecioMinVenta.Size = new System.Drawing.Size(150, 23);
            this.NUDPrecioMinVenta.TabIndex = 98;
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
            this.materialLabel1.Location = new System.Drawing.Point(309, 295);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(84, 19);
            this.materialLabel1.TabIndex = 97;
            this.materialLabel1.Text = "Descripción";
            // 
            // SWBEstadoStock
            // 
            // 
            // 
            // 
            this.SWBEstadoStock.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.SWBEstadoStock.Location = new System.Drawing.Point(312, 96);
            this.SWBEstadoStock.Name = "SWBEstadoStock";
            this.SWBEstadoStock.OffBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.SWBEstadoStock.OffText = "INHABILITADO";
            this.SWBEstadoStock.OffTextColor = System.Drawing.Color.White;
            this.SWBEstadoStock.OnBackColor = System.Drawing.Color.LimeGreen;
            this.SWBEstadoStock.OnText = "HABILITADO";
            this.SWBEstadoStock.OnTextColor = System.Drawing.Color.White;
            this.SWBEstadoStock.Size = new System.Drawing.Size(224, 24);
            this.SWBEstadoStock.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.SWBEstadoStock.TabIndex = 96;
            this.SWBEstadoStock.Value = true;
            this.SWBEstadoStock.ValueObject = "Y";
            this.SWBEstadoStock.ValueChanged += new System.EventHandler(this.SWBEstadoStock_ValueChanged);
            // 
            // materialLabel8
            // 
            this.materialLabel8.AutoSize = true;
            this.materialLabel8.Depth = 0;
            this.materialLabel8.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel8.Location = new System.Drawing.Point(562, 132);
            this.materialLabel8.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel8.Name = "materialLabel8";
            this.materialLabel8.Size = new System.Drawing.Size(51, 19);
            this.materialLabel8.TabIndex = 95;
            this.materialLabel8.Text = "Género";
            // 
            // materialLabel7
            // 
            this.materialLabel7.AutoSize = true;
            this.materialLabel7.Depth = 0;
            this.materialLabel7.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel7.Location = new System.Drawing.Point(562, 242);
            this.materialLabel7.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel7.Name = "materialLabel7";
            this.materialLabel7.Size = new System.Drawing.Size(59, 19);
            this.materialLabel7.TabIndex = 94;
            this.materialLabel7.Text = "Material";
            // 
            // materialLabel6
            // 
            this.materialLabel6.AutoSize = true;
            this.materialLabel6.Depth = 0;
            this.materialLabel6.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel6.Location = new System.Drawing.Point(308, 188);
            this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel6.Name = "materialLabel6";
            this.materialLabel6.Size = new System.Drawing.Size(37, 19);
            this.materialLabel6.TabIndex = 93;
            this.materialLabel6.Text = "Talla";
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel5.Location = new System.Drawing.Point(308, 242);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(38, 19);
            this.materialLabel5.TabIndex = 92;
            this.materialLabel5.Text = "Color";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.Location = new System.Drawing.Point(562, 75);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(46, 19);
            this.materialLabel2.TabIndex = 89;
            this.materialLabel2.Text = "Marca";
            // 
            // BTNLimpiar
            // 
            this.BTNLimpiar.BackColor = System.Drawing.Color.White;
            this.BTNLimpiar.FlatAppearance.BorderSize = 0;
            this.BTNLimpiar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.BTNLimpiar.ForeColor = System.Drawing.Color.Black;
            this.BTNLimpiar.Location = new System.Drawing.Point(614, 425);
            this.BTNLimpiar.Name = "BTNLimpiar";
            this.BTNLimpiar.Size = new System.Drawing.Size(142, 38);
            this.BTNLimpiar.TabIndex = 88;
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
            this.BTNSalir.Location = new System.Drawing.Point(311, 425);
            this.BTNSalir.Name = "BTNSalir";
            this.BTNSalir.Size = new System.Drawing.Size(146, 38);
            this.BTNSalir.TabIndex = 87;
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
            this.BTNGrabar.Location = new System.Drawing.Point(459, 425);
            this.BTNGrabar.Name = "BTNGrabar";
            this.BTNGrabar.Size = new System.Drawing.Size(152, 38);
            this.BTNGrabar.TabIndex = 86;
            this.BTNGrabar.Text = "Grabar";
            this.BTNGrabar.UseVisualStyleBackColor = false;
            this.BTNGrabar.Click += new System.EventHandler(this.BTNGrabar_Click);
            // 
            // LBL
            // 
            this.LBL.AutoSize = true;
            this.LBL.Depth = 0;
            this.LBL.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.LBL.Location = new System.Drawing.Point(562, 187);
            this.LBL.MouseState = MaterialSkin.MouseState.HOVER;
            this.LBL.Name = "LBL";
            this.LBL.Size = new System.Drawing.Size(69, 19);
            this.LBL.TabIndex = 85;
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
            this.LBLRegistrarProducto.Location = new System.Drawing.Point(292, 21);
            this.LBLRegistrarProducto.Name = "LBLRegistrarProducto";
            this.LBLRegistrarProducto.Size = new System.Drawing.Size(219, 35);
            this.LBLRegistrarProducto.TabIndex = 84;
            this.LBLRegistrarProducto.Text = "Agregar Producto";
            this.LBLRegistrarProducto.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Cursor = System.Windows.Forms.Cursors.Default;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel3.Location = new System.Drawing.Point(41, 132);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(57, 19);
            this.materialLabel3.TabIndex = 83;
            this.materialLabel3.Text = "Nombre";
            // 
            // comboItem3
            // 
            this.comboItem3.Text = "Unisex";
            // 
            // comboItem2
            // 
            this.comboItem2.Text = "Mujer";
            // 
            // comboItem1
            // 
            this.comboItem1.Text = "Hombre";
            // 
            // FRMProducto_Registrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 554);
            this.Controls.Add(this.PPrincipal);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FRMProducto_Registrar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FRMProducto_Registrar";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FRMProducto_Registrar_FormClosing);
            this.Load += new System.EventHandler(this.FRMProducto_Registrar_Load);
            this.PPrincipal.ResumeLayout(false);
            this.PAgregar_Producto.ResumeLayout(false);
            this.PAgregar_Producto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CMBMaterial)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CMBGenero)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CMBCategoria)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CMBMarca)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CMBColor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CMBTalla)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CMBProductoNombre)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PCBFotografia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PCBCamara)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDStockActual)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDPrecioVenta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDPrecioMinVenta)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.OpenFileDialog OFDElegirImagen;
        private DevComponents.DotNetBar.BalloonTip BLTAyuda;
        private System.Windows.Forms.Panel PPrincipal;
        private System.Windows.Forms.Panel PAgregar_Producto;
        private System.Windows.Forms.PictureBox PCBFotografia;
        private System.Windows.Forms.PictureBox PCBCamara;
        private DevComponents.DotNetBar.ButtonX BTNCodigoDeBarras;
        private DevComponents.DotNetBar.Controls.TextBoxX TXTProductoDescripcion;
        private DevComponents.DotNetBar.LabelX LBLCodigoDeBarras;
        private MaterialSkin.Controls.MaterialLabel materialLabel13;
        private MaterialSkin.Controls.MaterialLabel materialLabel10;
        private MaterialSkin.Controls.MaterialLabel materialLabel11;
        private MaterialSkin.Controls.MaterialLabel materialLabel12;
        private System.Windows.Forms.TextBox TXTModelo;
        private MaterialSkin.Controls.MaterialLabel materialLabel9;
        private System.Windows.Forms.NumericUpDown NUDStockActual;
        private System.Windows.Forms.NumericUpDown NUDPrecioVenta;
        private System.Windows.Forms.NumericUpDown NUDPrecioMinVenta;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private DevComponents.DotNetBar.Controls.SwitchButton SWBEstadoStock;
        private MaterialSkin.Controls.MaterialLabel materialLabel8;
        private MaterialSkin.Controls.MaterialLabel materialLabel7;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private System.Windows.Forms.Button BTNLimpiar;
        private System.Windows.Forms.Button BTNSalir;
        private System.Windows.Forms.Button BTNGrabar;
        private MaterialSkin.Controls.MaterialLabel LBL;
        private DevComponents.DotNetBar.LabelX LBLRegistrarProducto;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel materialLabel14;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialLabel materialLabel17;
        private MaterialSkin.Controls.MaterialLabel materialLabel18;
        private MaterialSkin.Controls.MaterialLabel materialLabel15;
        private MaterialSkin.Controls.MaterialLabel materialLabel16;
        private System.Windows.Forms.Button BTNAbrirFoto;
        private System.Windows.Forms.Button BTNLimpiarFoto;
        private System.Windows.Forms.Button BTNCapturarFoto;
        private Krypton.Toolkit.KryptonComboBox CMBProductoNombre;
        private Krypton.Toolkit.KryptonComboBox CMBTalla;
        private Krypton.Toolkit.KryptonComboBox CMBColor;
        private Krypton.Toolkit.KryptonComboBox CMBMarca;
        private Krypton.Toolkit.KryptonComboBox CMBCategoria;
        private Krypton.Toolkit.KryptonComboBox CMBGenero;
        private DevComponents.Editors.ComboItem comboItem3;
        private DevComponents.Editors.ComboItem comboItem2;
        private DevComponents.Editors.ComboItem comboItem1;
        private Krypton.Toolkit.KryptonComboBox CMBMaterial;
    }
}