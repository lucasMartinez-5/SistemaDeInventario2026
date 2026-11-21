namespace SistemaDeInventario2026
{
    partial class FRMCategoria_Lista
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
            this.CMSMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.modificarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inhabilitarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.habilitarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PPrincipal = new System.Windows.Forms.Panel();
            this.PCategoria_Acciones = new System.Windows.Forms.Panel();
            this.BTNLimpiar = new System.Windows.Forms.Button();
            this.BTNBuscar = new System.Windows.Forms.Button();
            this.DTGLista = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LBLGestionCategorias = new DevComponents.DotNetBar.LabelX();
            this.BTNFiltrar = new DevComponents.DotNetBar.ButtonX();
            this.TXTFiltrar = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.IINFilas = new DevComponents.Editors.IntegerInput();
            this.CMSMenu.SuspendLayout();
            this.PPrincipal.SuspendLayout();
            this.PCategoria_Acciones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DTGLista)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IINFilas)).BeginInit();
            this.SuspendLayout();
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
            // PPrincipal
            // 
            this.PPrincipal.BackColor = System.Drawing.Color.White;
            this.PPrincipal.Controls.Add(this.PCategoria_Acciones);
            this.PPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PPrincipal.Location = new System.Drawing.Point(0, 0);
            this.PPrincipal.Name = "PPrincipal";
            this.PPrincipal.Size = new System.Drawing.Size(826, 554);
            this.PPrincipal.TabIndex = 48;
            // 
            // PCategoria_Acciones
            // 
            this.PCategoria_Acciones.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PCategoria_Acciones.Controls.Add(this.BTNLimpiar);
            this.PCategoria_Acciones.Controls.Add(this.BTNBuscar);
            this.PCategoria_Acciones.Controls.Add(this.DTGLista);
            this.PCategoria_Acciones.Controls.Add(this.LBLGestionCategorias);
            this.PCategoria_Acciones.Controls.Add(this.BTNFiltrar);
            this.PCategoria_Acciones.Controls.Add(this.TXTFiltrar);
            this.PCategoria_Acciones.Controls.Add(this.IINFilas);
            this.PCategoria_Acciones.Location = new System.Drawing.Point(0, 0);
            this.PCategoria_Acciones.Name = "PCategoria_Acciones";
            this.PCategoria_Acciones.Size = new System.Drawing.Size(826, 554);
            this.PCategoria_Acciones.TabIndex = 0;
            // 
            // BTNLimpiar
            // 
            this.BTNLimpiar.BackColor = System.Drawing.Color.White;
            this.BTNLimpiar.FlatAppearance.BorderSize = 0;
            this.BTNLimpiar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.BTNLimpiar.ForeColor = System.Drawing.Color.Black;
            this.BTNLimpiar.Location = new System.Drawing.Point(586, 106);
            this.BTNLimpiar.Name = "BTNLimpiar";
            this.BTNLimpiar.Size = new System.Drawing.Size(142, 29);
            this.BTNLimpiar.TabIndex = 128;
            this.BTNLimpiar.Text = "Salir";
            this.BTNLimpiar.UseVisualStyleBackColor = false;
            this.BTNLimpiar.Click += new System.EventHandler(this.BTNLimpiar_Click);
            // 
            // BTNBuscar
            // 
            this.BTNBuscar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.BTNBuscar.BackColor = System.Drawing.Color.Black;
            this.BTNBuscar.FlatAppearance.BorderSize = 0;
            this.BTNBuscar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.BTNBuscar.ForeColor = System.Drawing.Color.White;
            this.BTNBuscar.Location = new System.Drawing.Point(431, 106);
            this.BTNBuscar.Name = "BTNBuscar";
            this.BTNBuscar.Size = new System.Drawing.Size(152, 29);
            this.BTNBuscar.TabIndex = 127;
            this.BTNBuscar.Text = "Agregar";
            this.BTNBuscar.UseVisualStyleBackColor = false;
            this.BTNBuscar.Click += new System.EventHandler(this.BTNRegistrar_Click);
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
            this.Column3});
            this.DTGLista.ContextMenuStrip = this.CMSMenu;
            this.DTGLista.Cursor = System.Windows.Forms.Cursors.Default;
            this.DTGLista.GridColor = System.Drawing.Color.White;
            this.DTGLista.Location = new System.Drawing.Point(180, 152);
            this.DTGLista.Margin = new System.Windows.Forms.Padding(4);
            this.DTGLista.MultiSelect = false;
            this.DTGLista.Name = "DTGLista";
            this.DTGLista.ReadOnly = true;
            this.DTGLista.RowHeadersVisible = false;
            this.DTGLista.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DTGLista.Size = new System.Drawing.Size(447, 341);
            this.DTGLista.TabIndex = 52;
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
            this.Column2.Width = 85;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Nombre";
            this.Column3.MinimumWidth = 20;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 360;
            // 
            // LBLGestionCategorias
            // 
            this.LBLGestionCategorias.AutoSize = true;
            // 
            // 
            // 
            this.LBLGestionCategorias.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.LBLGestionCategorias.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLGestionCategorias.FontBold = true;
            this.LBLGestionCategorias.Location = new System.Drawing.Point(203, 41);
            this.LBLGestionCategorias.Name = "LBLGestionCategorias";
            this.LBLGestionCategorias.Size = new System.Drawing.Size(415, 50);
            this.LBLGestionCategorias.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2000;
            this.LBLGestionCategorias.TabIndex = 51;
            this.LBLGestionCategorias.Text = "Gestión de Categorías";
            this.LBLGestionCategorias.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // BTNFiltrar
            // 
            this.BTNFiltrar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.BTNFiltrar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.BTNFiltrar.Image = global::SistemaDeInventario2026.Properties.Resources.ic_buscar;
            this.BTNFiltrar.ImageFixedSize = new System.Drawing.Size(20, 20);
            this.BTNFiltrar.Location = new System.Drawing.Point(392, 106);
            this.BTNFiltrar.Name = "BTNFiltrar";
            this.BTNFiltrar.Size = new System.Drawing.Size(27, 26);
            this.BTNFiltrar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.BTNFiltrar.TabIndex = 50;
            this.BTNFiltrar.Click += new System.EventHandler(this.BTNFiltrar_Click);
            // 
            // TXTFiltrar
            // 
            this.TXTFiltrar.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.TXTFiltrar.Border.Class = "TextBoxBorder";
            this.TXTFiltrar.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.TXTFiltrar.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TXTFiltrar.DisabledBackColor = System.Drawing.Color.White;
            this.TXTFiltrar.ForeColor = System.Drawing.Color.Black;
            this.TXTFiltrar.Location = new System.Drawing.Point(190, 106);
            this.TXTFiltrar.Name = "TXTFiltrar";
            this.TXTFiltrar.PreventEnterBeep = true;
            this.TXTFiltrar.Size = new System.Drawing.Size(196, 23);
            this.TXTFiltrar.TabIndex = 49;
            this.TXTFiltrar.WatermarkText = "Datos a buscar...";
            this.TXTFiltrar.Click += new System.EventHandler(this.BTNFiltrar_Enter);
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
            this.IINFilas.Location = new System.Drawing.Point(103, 106);
            this.IINFilas.MaxValue = 1000;
            this.IINFilas.MinValue = 0;
            this.IINFilas.Name = "IINFilas";
            this.IINFilas.ShowUpDown = true;
            this.IINFilas.Size = new System.Drawing.Size(80, 23);
            this.IINFilas.TabIndex = 48;
            this.IINFilas.Value = 50;
            // 
            // FRMCategoria_Lista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(826, 554);
            this.Controls.Add(this.PPrincipal);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FRMCategoria_Lista";
            this.Text = "FRMCategoria_Lista";
            this.Load += new System.EventHandler(this.FRMCategoria_Lista_Load);
            this.CMSMenu.ResumeLayout(false);
            this.PPrincipal.ResumeLayout(false);
            this.PCategoria_Acciones.ResumeLayout(false);
            this.PCategoria_Acciones.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DTGLista)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IINFilas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip CMSMenu;
        private System.Windows.Forms.ToolStripMenuItem modificarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inhabilitarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem habilitarToolStripMenuItem;
        private System.Windows.Forms.Panel PPrincipal;
        private System.Windows.Forms.Panel PCategoria_Acciones;
        private DevComponents.DotNetBar.ButtonX BTNFiltrar;
        private DevComponents.DotNetBar.Controls.TextBoxX TXTFiltrar;
        private DevComponents.Editors.IntegerInput IINFilas;
        private DevComponents.DotNetBar.LabelX LBLGestionCategorias;
        private System.Windows.Forms.DataGridView DTGLista;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.Button BTNLimpiar;
        private System.Windows.Forms.Button BTNBuscar;
    }
}