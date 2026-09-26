namespace SistemaDeInventario2026
{
    partial class FRMDirectorioProveedor
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
            this.DTGLista = new System.Windows.Forms.DataGridView();
            this.CMSMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.modificarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inhabilitarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.habilitarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.styleManager1 = new DevComponents.DotNetBar.StyleManager(this.components);
            this.styleManager2 = new DevComponents.DotNetBar.StyleManager(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.BTNAdministracionUsuarios = new System.Windows.Forms.Button();
            this.BTNPuntoDeVenta = new System.Windows.Forms.Button();
            this.BTNBusquedaAvanzada = new System.Windows.Forms.Button();
            this.BTNInventario = new System.Windows.Forms.Button();
            this.BTNDirectorio = new System.Windows.Forms.Button();
            this.LBLDirectorioProveedor = new DevComponents.DotNetBar.LabelX();
            this.TXTFiltrar = new System.Windows.Forms.TextBox();
            this.IINFilas = new DevComponents.Editors.IntegerInput();
            this.BTNFiltrar = new DevComponents.DotNetBar.ButtonX();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DTGLista)).BeginInit();
            this.CMSMenu.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IINFilas)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // DTGLista
            // 
            this.DTGLista.AllowUserToAddRows = false;
            this.DTGLista.AllowUserToDeleteRows = false;
            this.DTGLista.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DTGLista.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DTGLista.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedVertical;
            this.DTGLista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DTGLista.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.DTGLista.ContextMenuStrip = this.CMSMenu;
            this.DTGLista.Cursor = System.Windows.Forms.Cursors.Default;
            this.DTGLista.GridColor = System.Drawing.SystemColors.Control;
            this.DTGLista.Location = new System.Drawing.Point(268, 203);
            this.DTGLista.Margin = new System.Windows.Forms.Padding(4);
            this.DTGLista.MultiSelect = false;
            this.DTGLista.Name = "DTGLista";
            this.DTGLista.ReadOnly = true;
            this.DTGLista.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DTGLista.Size = new System.Drawing.Size(800, 348);
            this.DTGLista.TabIndex = 0;
            this.DTGLista.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DTGLista_CellContentClick);
            this.DTGLista.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DTGLista_CellDoubleClick);
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
            // styleManager1
            // 
            this.styleManager1.ManagerColorTint = System.Drawing.Color.DodgerBlue;
            this.styleManager1.ManagerStyle = DevComponents.DotNetBar.eStyle.VisualStudio2012Light;
            this.styleManager1.MetroColorParameters = new DevComponents.DotNetBar.Metro.ColorTables.MetroColorGeneratorParameters(System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(242))))), System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204))))));
            // 
            // styleManager2
            // 
            this.styleManager2.ManagerColorTint = System.Drawing.Color.DodgerBlue;
            this.styleManager2.ManagerStyle = DevComponents.DotNetBar.eStyle.VisualStudio2012Light;
            this.styleManager2.MetroColorParameters = new DevComponents.DotNetBar.Metro.ColorTables.MetroColorGeneratorParameters(System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(242))))), System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204))))));
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Controls.Add(this.BTNAdministracionUsuarios);
            this.panel1.Controls.Add(this.BTNPuntoDeVenta);
            this.panel1.Controls.Add(this.BTNBusquedaAvanzada);
            this.panel1.Controls.Add(this.BTNInventario);
            this.panel1.Controls.Add(this.BTNDirectorio);
            this.panel1.Location = new System.Drawing.Point(0, 45);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(270, 507);
            this.panel1.TabIndex = 2;
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
            // LBLDirectorioProveedor
            // 
            this.LBLDirectorioProveedor.AutoSize = true;
            // 
            // 
            // 
            this.LBLDirectorioProveedor.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.LBLDirectorioProveedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLDirectorioProveedor.FontBold = true;
            this.LBLDirectorioProveedor.Location = new System.Drawing.Point(422, 91);
            this.LBLDirectorioProveedor.Name = "LBLDirectorioProveedor";
            this.LBLDirectorioProveedor.Size = new System.Drawing.Size(485, 50);
            this.LBLDirectorioProveedor.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2000;
            this.LBLDirectorioProveedor.TabIndex = 3;
            this.LBLDirectorioProveedor.Text = "Directorio de Proveedores";
            this.LBLDirectorioProveedor.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // TXTFiltrar
            // 
            this.TXTFiltrar.Location = new System.Drawing.Point(530, 147);
            this.TXTFiltrar.Name = "TXTFiltrar";
            this.TXTFiltrar.Size = new System.Drawing.Size(342, 23);
            this.TXTFiltrar.TabIndex = 8;
            // 
            // IINFilas
            // 
            // 
            // 
            // 
            this.IINFilas.BackgroundStyle.Class = "DateTimeInputBackground";
            this.IINFilas.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.IINFilas.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2;
            this.IINFilas.Increment = 10;
            this.IINFilas.Location = new System.Drawing.Point(422, 147);
            this.IINFilas.MaxValue = 1000;
            this.IINFilas.MinValue = 0;
            this.IINFilas.Name = "IINFilas";
            this.IINFilas.ShowUpDown = true;
            this.IINFilas.Size = new System.Drawing.Size(80, 23);
            this.IINFilas.TabIndex = 9;
            this.IINFilas.Value = 50;
            // 
            // BTNFiltrar
            // 
            this.BTNFiltrar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.BTNFiltrar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.BTNFiltrar.Image = global::SistemaDeInventario2026.Properties.Resources.ic_buscar;
            this.BTNFiltrar.ImageFixedSize = new System.Drawing.Size(20, 20);
            this.BTNFiltrar.Location = new System.Drawing.Point(878, 147);
            this.BTNFiltrar.Name = "BTNFiltrar";
            this.BTNFiltrar.Size = new System.Drawing.Size(23, 23);
            this.BTNFiltrar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.BTNFiltrar.TabIndex = 10;
            this.BTNFiltrar.Click += new System.EventHandler(this.BTNFiltrar_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.pictureBox4);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1068, 45);
            this.panel2.TabIndex = 12;
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
            // Column1
            // 
            this.Column1.HeaderText = "Código";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Visible = false;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Estado";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 73;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "NIT";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 201;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Razón Social";
            this.Column4.MinimumWidth = 20;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 305;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Celular";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 180;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Dirección";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Visible = false;
            this.Column6.Width = 150;
            // 
            // FRMDirectorioProveedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1067, 552);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.BTNFiltrar);
            this.Controls.Add(this.IINFilas);
            this.Controls.Add(this.TXTFiltrar);
            this.Controls.Add(this.LBLDirectorioProveedor);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.DTGLista);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FRMDirectorioProveedor";
            this.Padding = new System.Windows.Forms.Padding(4, 79, 4, 4);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FRMProveedor_Lista_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DTGLista)).EndInit();
            this.CMSMenu.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.IINFilas)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DTGLista;
        private DevComponents.DotNetBar.StyleManager styleManager1;
        private DevComponents.DotNetBar.StyleManager styleManager2;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Button BTNDirectorio;
        public System.Windows.Forms.Button BTNInventario;
        private DevComponents.DotNetBar.LabelX LBLDirectorioProveedor;
        public System.Windows.Forms.Button BTNPuntoDeVenta;
        public System.Windows.Forms.Button BTNBusquedaAvanzada;
        public System.Windows.Forms.Button BTNAdministracionUsuarios;
        private System.Windows.Forms.TextBox TXTFiltrar;
        private DevComponents.Editors.IntegerInput IINFilas;
        private DevComponents.DotNetBar.ButtonX BTNFiltrar;
        private System.Windows.Forms.ContextMenuStrip CMSMenu;
        private System.Windows.Forms.ToolStripMenuItem modificarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inhabilitarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem habilitarToolStripMenuItem;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
    }
}