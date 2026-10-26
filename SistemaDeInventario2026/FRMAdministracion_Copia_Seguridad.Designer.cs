namespace SistemaDeInventario2026
{
    partial class FRMAdministracion_Copia_Seguridad
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRMAdministracion_Copia_Seguridad));
            this.PPrincipal = new System.Windows.Forms.Panel();
            this.PMenu_Copia_Seguridad = new System.Windows.Forms.Panel();
            this.CMSMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.modificarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inhabilitarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.habilitarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PCBFotografia = new System.Windows.Forms.PictureBox();
            this.BTNSalir = new DevComponents.DotNetBar.ButtonX();
            this.BTNLimpiar = new DevComponents.DotNetBar.ButtonX();
            this.BTNGrabar = new DevComponents.DotNetBar.ButtonX();
            this.TXTDireccion = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.TXTNombres = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.SWBSexo = new DevComponents.DotNetBar.Controls.SwitchButton();
            this.SWBEstado = new DevComponents.DotNetBar.Controls.SwitchButton();
            this.BTNAbrirFoto = new DevComponents.DotNetBar.ButtonX();
            this.TXTApellidoPaterno = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.DTINacimiento = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.PCBCamara = new System.Windows.Forms.PictureBox();
            this.TXTCelular = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.TXTApellidoMaterno = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.BTNCapturarFoto = new DevComponents.DotNetBar.ButtonX();
            this.TXTCI = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.BTNLimpiarFoto = new DevComponents.DotNetBar.ButtonX();
            this.TXTCorreoElectronico = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.PPrincipal.SuspendLayout();
            this.PMenu_Copia_Seguridad.SuspendLayout();
            this.CMSMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PCBFotografia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DTINacimiento)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PCBCamara)).BeginInit();
            this.SuspendLayout();
            // 
            // PPrincipal
            // 
            this.PPrincipal.BackColor = System.Drawing.Color.White;
            this.PPrincipal.Controls.Add(this.PMenu_Copia_Seguridad);
            this.PPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PPrincipal.Location = new System.Drawing.Point(0, 0);
            this.PPrincipal.Name = "PPrincipal";
            this.PPrincipal.Size = new System.Drawing.Size(970, 519);
            this.PPrincipal.TabIndex = 0;
            // 
            // PMenu_Copia_Seguridad
            // 
            this.PMenu_Copia_Seguridad.Controls.Add(this.PCBFotografia);
            this.PMenu_Copia_Seguridad.Controls.Add(this.BTNSalir);
            this.PMenu_Copia_Seguridad.Controls.Add(this.BTNLimpiar);
            this.PMenu_Copia_Seguridad.Controls.Add(this.BTNGrabar);
            this.PMenu_Copia_Seguridad.Controls.Add(this.TXTDireccion);
            this.PMenu_Copia_Seguridad.Controls.Add(this.TXTNombres);
            this.PMenu_Copia_Seguridad.Controls.Add(this.SWBSexo);
            this.PMenu_Copia_Seguridad.Controls.Add(this.SWBEstado);
            this.PMenu_Copia_Seguridad.Controls.Add(this.BTNAbrirFoto);
            this.PMenu_Copia_Seguridad.Controls.Add(this.TXTApellidoPaterno);
            this.PMenu_Copia_Seguridad.Controls.Add(this.DTINacimiento);
            this.PMenu_Copia_Seguridad.Controls.Add(this.PCBCamara);
            this.PMenu_Copia_Seguridad.Controls.Add(this.TXTCelular);
            this.PMenu_Copia_Seguridad.Controls.Add(this.TXTApellidoMaterno);
            this.PMenu_Copia_Seguridad.Controls.Add(this.BTNCapturarFoto);
            this.PMenu_Copia_Seguridad.Controls.Add(this.TXTCI);
            this.PMenu_Copia_Seguridad.Controls.Add(this.BTNLimpiarFoto);
            this.PMenu_Copia_Seguridad.Controls.Add(this.TXTCorreoElectronico);
            this.PMenu_Copia_Seguridad.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PMenu_Copia_Seguridad.Location = new System.Drawing.Point(0, 0);
            this.PMenu_Copia_Seguridad.Name = "PMenu_Copia_Seguridad";
            this.PMenu_Copia_Seguridad.Size = new System.Drawing.Size(970, 519);
            this.PMenu_Copia_Seguridad.TabIndex = 0;
            // 
            // CMSMenu
            // 
            this.CMSMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.modificarToolStripMenuItem,
            this.inhabilitarToolStripMenuItem,
            this.habilitarToolStripMenuItem});
            this.CMSMenu.Name = "CMSMenu";
            this.CMSMenu.Size = new System.Drawing.Size(128, 70);
            this.CMSMenu.Opening += new System.ComponentModel.CancelEventHandler(this.CMSMenu_Opening);
            // 
            // modificarToolStripMenuItem
            // 
            this.modificarToolStripMenuItem.Name = "modificarToolStripMenuItem";
            this.modificarToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.modificarToolStripMenuItem.Text = "&Modificar";
            this.modificarToolStripMenuItem.Click += new System.EventHandler(this.modificarToolStripMenuItem_Click);
            // 
            // inhabilitarToolStripMenuItem
            // 
            this.inhabilitarToolStripMenuItem.Name = "inhabilitarToolStripMenuItem";
            this.inhabilitarToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.inhabilitarToolStripMenuItem.Text = "&Inhabilitar";
            this.inhabilitarToolStripMenuItem.Click += new System.EventHandler(this.inhabilitarToolStripMenuItem_Click);
            // 
            // habilitarToolStripMenuItem
            // 
            this.habilitarToolStripMenuItem.Name = "habilitarToolStripMenuItem";
            this.habilitarToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.habilitarToolStripMenuItem.Text = "&Habilitar";
            this.habilitarToolStripMenuItem.Click += new System.EventHandler(this.habilitarToolStripMenuItem_Click);
            // 
            // PCBFotografia
            // 
            this.PCBFotografia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PCBFotografia.Image = ((System.Drawing.Image)(resources.GetObject("PCBFotografia.Image")));
            this.PCBFotografia.Location = new System.Drawing.Point(749, 63);
            this.PCBFotografia.Name = "PCBFotografia";
            this.PCBFotografia.Size = new System.Drawing.Size(170, 132);
            this.PCBFotografia.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PCBFotografia.TabIndex = 32;
            this.PCBFotografia.TabStop = false;
            // 
            // BTNSalir
            // 
            this.BTNSalir.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.BTNSalir.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.BTNSalir.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BTNSalir.Image = global::SistemaDeInventario2026.Properties.Resources.ic_salir;
            this.BTNSalir.ImageFixedSize = new System.Drawing.Size(40, 40);
            this.BTNSalir.Location = new System.Drawing.Point(615, 353);
            this.BTNSalir.Name = "BTNSalir";
            this.BTNSalir.Size = new System.Drawing.Size(121, 51);
            this.BTNSalir.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.BTNSalir.TabIndex = 31;
            this.BTNSalir.Text = "&Salir";
            // 
            // BTNLimpiar
            // 
            this.BTNLimpiar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.BTNLimpiar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.BTNLimpiar.Image = global::SistemaDeInventario2026.Properties.Resources.ic_limpiar;
            this.BTNLimpiar.ImageFixedSize = new System.Drawing.Size(40, 40);
            this.BTNLimpiar.Location = new System.Drawing.Point(488, 353);
            this.BTNLimpiar.Name = "BTNLimpiar";
            this.BTNLimpiar.Size = new System.Drawing.Size(121, 51);
            this.BTNLimpiar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.BTNLimpiar.TabIndex = 30;
            this.BTNLimpiar.Text = "&Limpiar";
            // 
            // BTNGrabar
            // 
            this.BTNGrabar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.BTNGrabar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.BTNGrabar.Image = global::SistemaDeInventario2026.Properties.Resources.ic_guardar;
            this.BTNGrabar.ImageFixedSize = new System.Drawing.Size(40, 40);
            this.BTNGrabar.Location = new System.Drawing.Point(361, 353);
            this.BTNGrabar.Name = "BTNGrabar";
            this.BTNGrabar.Size = new System.Drawing.Size(121, 51);
            this.BTNGrabar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.BTNGrabar.TabIndex = 29;
            this.BTNGrabar.Text = "&Grabar";
            // 
            // TXTDireccion
            // 
            this.TXTDireccion.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.TXTDireccion.Border.Class = "TextBoxBorder";
            this.TXTDireccion.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.TXTDireccion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TXTDireccion.DisabledBackColor = System.Drawing.Color.White;
            this.TXTDireccion.ForeColor = System.Drawing.Color.Black;
            this.TXTDireccion.Location = new System.Drawing.Point(90, 239);
            this.TXTDireccion.Multiline = true;
            this.TXTDireccion.Name = "TXTDireccion";
            this.TXTDireccion.PreventEnterBeep = true;
            this.TXTDireccion.Size = new System.Drawing.Size(304, 73);
            this.TXTDireccion.TabIndex = 26;
            this.TXTDireccion.WatermarkText = "Dirección";
            // 
            // TXTNombres
            // 
            this.TXTNombres.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.TXTNombres.Border.Class = "TextBoxBorder";
            this.TXTNombres.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.TXTNombres.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TXTNombres.DisabledBackColor = System.Drawing.Color.White;
            this.TXTNombres.ForeColor = System.Drawing.Color.Black;
            this.TXTNombres.Location = new System.Drawing.Point(90, 175);
            this.TXTNombres.Name = "TXTNombres";
            this.TXTNombres.PreventEnterBeep = true;
            this.TXTNombres.Size = new System.Drawing.Size(304, 23);
            this.TXTNombres.TabIndex = 23;
            this.TXTNombres.WatermarkText = "Nombres";
            // 
            // SWBSexo
            // 
            // 
            // 
            // 
            this.SWBSexo.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.SWBSexo.Location = new System.Drawing.Point(245, 63);
            this.SWBSexo.Name = "SWBSexo";
            this.SWBSexo.OffBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.SWBSexo.OffText = "Femenino";
            this.SWBSexo.OffTextColor = System.Drawing.Color.White;
            this.SWBSexo.OnBackColor = System.Drawing.Color.DodgerBlue;
            this.SWBSexo.OnText = "Masculino";
            this.SWBSexo.OnTextColor = System.Drawing.Color.White;
            this.SWBSexo.Size = new System.Drawing.Size(149, 26);
            this.SWBSexo.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.SWBSexo.TabIndex = 28;
            this.SWBSexo.Value = true;
            this.SWBSexo.ValueObject = "Y";
            // 
            // SWBEstado
            // 
            // 
            // 
            // 
            this.SWBEstado.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.SWBEstado.Location = new System.Drawing.Point(90, 63);
            this.SWBEstado.Name = "SWBEstado";
            this.SWBEstado.OffBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.SWBEstado.OffText = "Inhabilitado";
            this.SWBEstado.OffTextColor = System.Drawing.Color.White;
            this.SWBEstado.OnBackColor = System.Drawing.Color.LimeGreen;
            this.SWBEstado.OnText = "Habilitado";
            this.SWBEstado.OnTextColor = System.Drawing.Color.White;
            this.SWBEstado.Size = new System.Drawing.Size(149, 26);
            this.SWBEstado.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.SWBEstado.TabIndex = 27;
            this.SWBEstado.Value = true;
            this.SWBEstado.ValueObject = "Y";
            // 
            // BTNAbrirFoto
            // 
            this.BTNAbrirFoto.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.BTNAbrirFoto.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.BTNAbrirFoto.Image = global::SistemaDeInventario2026.Properties.Resources.ic_camara_abrir;
            this.BTNAbrirFoto.ImageFixedSize = new System.Drawing.Size(40, 40);
            this.BTNAbrirFoto.Location = new System.Drawing.Point(794, 201);
            this.BTNAbrirFoto.Name = "BTNAbrirFoto";
            this.BTNAbrirFoto.Size = new System.Drawing.Size(102, 51);
            this.BTNAbrirFoto.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.BTNAbrirFoto.TabIndex = 20;
            this.BTNAbrirFoto.Text = "&Abrir";
            // 
            // TXTApellidoPaterno
            // 
            this.TXTApellidoPaterno.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.TXTApellidoPaterno.Border.Class = "TextBoxBorder";
            this.TXTApellidoPaterno.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.TXTApellidoPaterno.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TXTApellidoPaterno.DisabledBackColor = System.Drawing.Color.White;
            this.TXTApellidoPaterno.ForeColor = System.Drawing.Color.Black;
            this.TXTApellidoPaterno.Location = new System.Drawing.Point(90, 143);
            this.TXTApellidoPaterno.Name = "TXTApellidoPaterno";
            this.TXTApellidoPaterno.PreventEnterBeep = true;
            this.TXTApellidoPaterno.Size = new System.Drawing.Size(149, 23);
            this.TXTApellidoPaterno.TabIndex = 21;
            this.TXTApellidoPaterno.WatermarkText = "Apellido Paterno";
            // 
            // DTINacimiento
            // 
            // 
            // 
            // 
            this.DTINacimiento.BackgroundStyle.Class = "DateTimeInputBackground";
            this.DTINacimiento.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.DTINacimiento.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown;
            this.DTINacimiento.ButtonDropDown.Visible = true;
            this.DTINacimiento.IsPopupCalendarOpen = false;
            this.DTINacimiento.Location = new System.Drawing.Point(245, 111);
            // 
            // 
            // 
            // 
            // 
            // 
            this.DTINacimiento.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.DTINacimiento.MonthCalendar.CalendarDimensions = new System.Drawing.Size(1, 1);
            this.DTINacimiento.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.DTINacimiento.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.DTINacimiento.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.DTINacimiento.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.DTINacimiento.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.DTINacimiento.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.DTINacimiento.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.DTINacimiento.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.DTINacimiento.MonthCalendar.DisplayMonth = new System.DateTime(2026, 5, 1, 0, 0, 0, 0);
            this.DTINacimiento.MonthCalendar.FirstDayOfWeek = System.DayOfWeek.Monday;
            // 
            // 
            // 
            this.DTINacimiento.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.DTINacimiento.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.DTINacimiento.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.DTINacimiento.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.DTINacimiento.MonthCalendar.TodayButtonVisible = true;
            this.DTINacimiento.Name = "DTINacimiento";
            this.DTINacimiento.Size = new System.Drawing.Size(149, 23);
            this.DTINacimiento.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.DTINacimiento.TabIndex = 18;
            this.DTINacimiento.WatermarkText = "Nacimiento";
            // 
            // PCBCamara
            // 
            this.PCBCamara.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PCBCamara.Image = ((System.Drawing.Image)(resources.GetObject("PCBCamara.Image")));
            this.PCBCamara.Location = new System.Drawing.Point(573, 63);
            this.PCBCamara.Name = "PCBCamara";
            this.PCBCamara.Size = new System.Drawing.Size(170, 132);
            this.PCBCamara.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PCBCamara.TabIndex = 17;
            this.PCBCamara.TabStop = false;
            // 
            // TXTCelular
            // 
            this.TXTCelular.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.TXTCelular.Border.Class = "TextBoxBorder";
            this.TXTCelular.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.TXTCelular.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TXTCelular.DisabledBackColor = System.Drawing.Color.White;
            this.TXTCelular.ForeColor = System.Drawing.Color.Black;
            this.TXTCelular.Location = new System.Drawing.Point(91, 207);
            this.TXTCelular.Name = "TXTCelular";
            this.TXTCelular.PreventEnterBeep = true;
            this.TXTCelular.Size = new System.Drawing.Size(82, 23);
            this.TXTCelular.TabIndex = 24;
            this.TXTCelular.WatermarkText = "Celular";
            // 
            // TXTApellidoMaterno
            // 
            this.TXTApellidoMaterno.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.TXTApellidoMaterno.Border.Class = "TextBoxBorder";
            this.TXTApellidoMaterno.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.TXTApellidoMaterno.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TXTApellidoMaterno.DisabledBackColor = System.Drawing.Color.White;
            this.TXTApellidoMaterno.ForeColor = System.Drawing.Color.Black;
            this.TXTApellidoMaterno.Location = new System.Drawing.Point(245, 143);
            this.TXTApellidoMaterno.Name = "TXTApellidoMaterno";
            this.TXTApellidoMaterno.PreventEnterBeep = true;
            this.TXTApellidoMaterno.Size = new System.Drawing.Size(149, 23);
            this.TXTApellidoMaterno.TabIndex = 22;
            this.TXTApellidoMaterno.WatermarkText = "Apellido Materno";
            // 
            // BTNCapturarFoto
            // 
            this.BTNCapturarFoto.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.BTNCapturarFoto.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.BTNCapturarFoto.Image = global::SistemaDeInventario2026.Properties.Resources.ic_camara_tomar;
            this.BTNCapturarFoto.ImageFixedSize = new System.Drawing.Size(40, 40);
            this.BTNCapturarFoto.Location = new System.Drawing.Point(550, 201);
            this.BTNCapturarFoto.Name = "BTNCapturarFoto";
            this.BTNCapturarFoto.Size = new System.Drawing.Size(119, 51);
            this.BTNCapturarFoto.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.BTNCapturarFoto.TabIndex = 16;
            this.BTNCapturarFoto.Text = "&Capturar";
            // 
            // TXTCI
            // 
            this.TXTCI.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.TXTCI.Border.Class = "TextBoxBorder";
            this.TXTCI.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.TXTCI.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TXTCI.DisabledBackColor = System.Drawing.Color.White;
            this.TXTCI.ForeColor = System.Drawing.Color.Black;
            this.TXTCI.Location = new System.Drawing.Point(90, 111);
            this.TXTCI.Name = "TXTCI";
            this.TXTCI.PreventEnterBeep = true;
            this.TXTCI.Size = new System.Drawing.Size(149, 23);
            this.TXTCI.TabIndex = 15;
            this.TXTCI.WatermarkText = "CI";
            // 
            // BTNLimpiarFoto
            // 
            this.BTNLimpiarFoto.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.BTNLimpiarFoto.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.BTNLimpiarFoto.Image = global::SistemaDeInventario2026.Properties.Resources.ic_camara_Limpiar;
            this.BTNLimpiarFoto.ImageFixedSize = new System.Drawing.Size(40, 40);
            this.BTNLimpiarFoto.Location = new System.Drawing.Point(675, 201);
            this.BTNLimpiarFoto.Name = "BTNLimpiarFoto";
            this.BTNLimpiarFoto.Size = new System.Drawing.Size(113, 51);
            this.BTNLimpiarFoto.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.BTNLimpiarFoto.TabIndex = 19;
            this.BTNLimpiarFoto.Text = "L&impiar";
            // 
            // TXTCorreoElectronico
            // 
            this.TXTCorreoElectronico.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.TXTCorreoElectronico.Border.Class = "TextBoxBorder";
            this.TXTCorreoElectronico.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.TXTCorreoElectronico.DisabledBackColor = System.Drawing.Color.White;
            this.TXTCorreoElectronico.ForeColor = System.Drawing.Color.Black;
            this.TXTCorreoElectronico.Location = new System.Drawing.Point(179, 207);
            this.TXTCorreoElectronico.Name = "TXTCorreoElectronico";
            this.TXTCorreoElectronico.PreventEnterBeep = true;
            this.TXTCorreoElectronico.Size = new System.Drawing.Size(215, 23);
            this.TXTCorreoElectronico.TabIndex = 25;
            this.TXTCorreoElectronico.WatermarkText = "Correo Electrónico";
            // 
            // FRMAdministracion_Copia_Seguridad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(970, 519);
            this.Controls.Add(this.PPrincipal);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FRMAdministracion_Copia_Seguridad";
            this.Text = "FRMAdministracion_Copia_Seguridad";
            this.Load += new System.EventHandler(this.FRMAdministracion_Copia_Seguridad_Load);
            this.PPrincipal.ResumeLayout(false);
            this.PMenu_Copia_Seguridad.ResumeLayout(false);
            this.CMSMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PCBFotografia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DTINacimiento)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PCBCamara)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PPrincipal;
        private System.Windows.Forms.ContextMenuStrip CMSMenu;
        private System.Windows.Forms.ToolStripMenuItem modificarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inhabilitarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem habilitarToolStripMenuItem;
        private System.Windows.Forms.Panel PMenu_Copia_Seguridad;
        private System.Windows.Forms.PictureBox PCBFotografia;
        private DevComponents.DotNetBar.ButtonX BTNSalir;
        private DevComponents.DotNetBar.ButtonX BTNLimpiar;
        private DevComponents.DotNetBar.ButtonX BTNGrabar;
        private DevComponents.DotNetBar.Controls.TextBoxX TXTDireccion;
        private DevComponents.DotNetBar.Controls.TextBoxX TXTNombres;
        private DevComponents.DotNetBar.Controls.SwitchButton SWBSexo;
        private DevComponents.DotNetBar.Controls.SwitchButton SWBEstado;
        private DevComponents.DotNetBar.ButtonX BTNAbrirFoto;
        private DevComponents.DotNetBar.Controls.TextBoxX TXTApellidoPaterno;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput DTINacimiento;
        private System.Windows.Forms.PictureBox PCBCamara;
        private DevComponents.DotNetBar.Controls.TextBoxX TXTCelular;
        private DevComponents.DotNetBar.Controls.TextBoxX TXTApellidoMaterno;
        private DevComponents.DotNetBar.ButtonX BTNCapturarFoto;
        private DevComponents.DotNetBar.Controls.TextBoxX TXTCI;
        private DevComponents.DotNetBar.ButtonX BTNLimpiarFoto;
        private DevComponents.DotNetBar.Controls.TextBoxX TXTCorreoElectronico;
    }
}