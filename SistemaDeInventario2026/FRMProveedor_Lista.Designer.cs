namespace SistemaDeInventario2026
{
    partial class FRMProveedor_Lista
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
            this.styleManager1 = new DevComponents.DotNetBar.StyleManager(this.components);
            this.styleManager2 = new DevComponents.DotNetBar.StyleManager(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.LBLDirectorio = new DevComponents.DotNetBar.LabelX();
            this.TXTFiltrar = new System.Windows.Forms.TextBox();
            this.IINFilas = new DevComponents.Editors.IntegerInput();
            this.BTNFiltrar = new DevComponents.DotNetBar.ButtonX();
            this.CMSMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.modificarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inhabilitarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.habilitarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BTNAdministracionUsuarios = new System.Windows.Forms.Button();
            this.BTNPuntoDeVenta = new System.Windows.Forms.Button();
            this.BTNBusquedaAvanzada = new System.Windows.Forms.Button();
            this.BTNInventario = new System.Windows.Forms.Button();
            this.BTNDirectorio = new System.Windows.Forms.Button();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DTGLista)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IINFilas)).BeginInit();
            this.CMSMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // DTGLista
            // 
            this.DTGLista.AllowUserToAddRows = false;
            this.DTGLista.AllowUserToDeleteRows = false;
            this.DTGLista.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DTGLista.BorderStyle = System.Windows.Forms.BorderStyle.None;
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
            this.DTGLista.Location = new System.Drawing.Point(271, 100);
            this.DTGLista.Margin = new System.Windows.Forms.Padding(4);
            this.DTGLista.MultiSelect = false;
            this.DTGLista.Name = "DTGLista";
            this.DTGLista.ReadOnly = true;
            this.DTGLista.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DTGLista.Size = new System.Drawing.Size(791, 497);
            this.DTGLista.TabIndex = 0;
            this.DTGLista.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DTGLista_CellContentClick);
            this.DTGLista.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DTGLista_CellDoubleClick);
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
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(270, 597);
            this.panel1.TabIndex = 2;
            // 
            // LBLDirectorio
            // 
            this.LBLDirectorio.AutoSize = true;
            // 
            // 
            // 
            this.LBLDirectorio.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.LBLDirectorio.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLDirectorio.FontBold = true;
            this.LBLDirectorio.Location = new System.Drawing.Point(423, 10);
            this.LBLDirectorio.Name = "LBLDirectorio";
            this.LBLDirectorio.Size = new System.Drawing.Size(485, 50);
            this.LBLDirectorio.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2000;
            this.LBLDirectorio.TabIndex = 3;
            this.LBLDirectorio.Text = "Directorio de Proveedores";
            this.LBLDirectorio.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // TXTFiltrar
            // 
            this.TXTFiltrar.Location = new System.Drawing.Point(599, 66);
            this.TXTFiltrar.Name = "TXTFiltrar";
            this.TXTFiltrar.Size = new System.Drawing.Size(342, 23);
            this.TXTFiltrar.TabIndex = 8;
            this.TXTFiltrar.UseWaitCursor = true;
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
            this.IINFilas.Location = new System.Drawing.Point(491, 66);
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
            this.BTNFiltrar.ImageFixedSize = new System.Drawing.Size(20, 20);
            this.BTNFiltrar.Location = new System.Drawing.Point(947, 66);
            this.BTNFiltrar.Name = "BTNFiltrar";
            this.BTNFiltrar.Size = new System.Drawing.Size(27, 26);
            this.BTNFiltrar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.BTNFiltrar.TabIndex = 10;
            this.BTNFiltrar.Click += new System.EventHandler(this.BTNFiltrar_Click);
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
            // BTNAdministracionUsuarios
            // 
            this.BTNAdministracionUsuarios.BackColor = System.Drawing.Color.Transparent;
            this.BTNAdministracionUsuarios.FlatAppearance.BorderSize = 0;
            this.BTNAdministracionUsuarios.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveBorder;
            this.BTNAdministracionUsuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTNAdministracionUsuarios.Image = global::SistemaDeInventario2026.Properties.Resources.ic_candado;
            this.BTNAdministracionUsuarios.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTNAdministracionUsuarios.Location = new System.Drawing.Point(5, 237);
            this.BTNAdministracionUsuarios.Margin = new System.Windows.Forms.Padding(4);
            this.BTNAdministracionUsuarios.Name = "BTNAdministracionUsuarios";
            this.BTNAdministracionUsuarios.Size = new System.Drawing.Size(260, 50);
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
            this.BTNPuntoDeVenta.Image = global::SistemaDeInventario2026.Properties.Resources.ic_venta;
            this.BTNPuntoDeVenta.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTNPuntoDeVenta.Location = new System.Drawing.Point(3, 183);
            this.BTNPuntoDeVenta.Margin = new System.Windows.Forms.Padding(4);
            this.BTNPuntoDeVenta.Name = "BTNPuntoDeVenta";
            this.BTNPuntoDeVenta.Size = new System.Drawing.Size(260, 50);
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
            this.BTNBusquedaAvanzada.Image = global::SistemaDeInventario2026.Properties.Resources.ic_buscar;
            this.BTNBusquedaAvanzada.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTNBusquedaAvanzada.Location = new System.Drawing.Point(3, 129);
            this.BTNBusquedaAvanzada.Margin = new System.Windows.Forms.Padding(4);
            this.BTNBusquedaAvanzada.Name = "BTNBusquedaAvanzada";
            this.BTNBusquedaAvanzada.Size = new System.Drawing.Size(260, 50);
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
            this.BTNInventario.Image = global::SistemaDeInventario2026.Properties.Resources.ic_producto;
            this.BTNInventario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTNInventario.Location = new System.Drawing.Point(3, 75);
            this.BTNInventario.Margin = new System.Windows.Forms.Padding(4);
            this.BTNInventario.Name = "BTNInventario";
            this.BTNInventario.Size = new System.Drawing.Size(260, 50);
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
            this.BTNDirectorio.Image = global::SistemaDeInventario2026.Properties.Resources.ic_proveedor;
            this.BTNDirectorio.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTNDirectorio.Location = new System.Drawing.Point(3, 21);
            this.BTNDirectorio.Margin = new System.Windows.Forms.Padding(4);
            this.BTNDirectorio.Name = "BTNDirectorio";
            this.BTNDirectorio.Size = new System.Drawing.Size(260, 50);
            this.BTNDirectorio.TabIndex = 0;
            this.BTNDirectorio.Text = "Gestíon de Inversión y Proveedores";
            this.BTNDirectorio.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTNDirectorio.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BTNDirectorio.UseVisualStyleBackColor = false;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Código";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Estado";
            this.Column2.Name = "Column2";
            this.Column2.Width = 60;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "NIT";
            this.Column3.Name = "Column3";
            this.Column3.Width = 130;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Razón Social";
            this.Column4.MinimumWidth = 20;
            this.Column4.Name = "Column4";
            this.Column4.Width = 200;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Celular";
            this.Column5.Name = "Column5";
            this.Column5.Width = 130;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Dirección";
            this.Column6.Name = "Column6";
            this.Column6.Visible = false;
            this.Column6.Width = 150;
            // 
            // FRMProveedor_Lista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1065, 597);
            this.Controls.Add(this.BTNFiltrar);
            this.Controls.Add(this.IINFilas);
            this.Controls.Add(this.TXTFiltrar);
            this.Controls.Add(this.LBLDirectorio);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.DTGLista);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FRMProveedor_Lista";
            this.Padding = new System.Windows.Forms.Padding(4, 79, 4, 4);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FRMProveedor_Lista";
            this.Load += new System.EventHandler(this.FRMProveedor_Lista_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DTGLista)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.IINFilas)).EndInit();
            this.CMSMenu.ResumeLayout(false);
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
        private DevComponents.DotNetBar.LabelX LBLDirectorio;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
    }
}