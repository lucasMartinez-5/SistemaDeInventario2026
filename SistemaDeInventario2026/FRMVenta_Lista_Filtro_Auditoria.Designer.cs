namespace SistemaDeInventario2026
{
    partial class FRMVenta_Lista_Filtro_Auditoria
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
            this.PPrincipal = new System.Windows.Forms.Panel();
            this.PVenta_Lista_Fecha = new System.Windows.Forms.Panel();
            this.BTNSalir = new System.Windows.Forms.Button();
            this.BTNFiltrar = new DevComponents.DotNetBar.ButtonX();
            this.IINFilas = new DevComponents.Editors.IntegerInput();
            this.TXTFiltrar = new System.Windows.Forms.TextBox();
            this.LBLDetalles_Venta_Lista = new DevComponents.DotNetBar.LabelX();
            this.DTGLista = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.PPrincipal.SuspendLayout();
            this.PVenta_Lista_Fecha.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IINFilas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DTGLista)).BeginInit();
            this.SuspendLayout();
            // 
            // PPrincipal
            // 
            this.PPrincipal.BackColor = System.Drawing.Color.White;
            this.PPrincipal.Controls.Add(this.PVenta_Lista_Fecha);
            this.PPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PPrincipal.Location = new System.Drawing.Point(0, 0);
            this.PPrincipal.Name = "PPrincipal";
            this.PPrincipal.Size = new System.Drawing.Size(970, 519);
            this.PPrincipal.TabIndex = 0;
            // 
            // PVenta_Lista_Fecha
            // 
            this.PVenta_Lista_Fecha.Controls.Add(this.BTNSalir);
            this.PVenta_Lista_Fecha.Controls.Add(this.BTNFiltrar);
            this.PVenta_Lista_Fecha.Controls.Add(this.IINFilas);
            this.PVenta_Lista_Fecha.Controls.Add(this.TXTFiltrar);
            this.PVenta_Lista_Fecha.Controls.Add(this.LBLDetalles_Venta_Lista);
            this.PVenta_Lista_Fecha.Controls.Add(this.DTGLista);
            this.PVenta_Lista_Fecha.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PVenta_Lista_Fecha.Location = new System.Drawing.Point(0, 0);
            this.PVenta_Lista_Fecha.Name = "PVenta_Lista_Fecha";
            this.PVenta_Lista_Fecha.Size = new System.Drawing.Size(970, 519);
            this.PVenta_Lista_Fecha.TabIndex = 0;
            // 
            // BTNSalir
            // 
            this.BTNSalir.BackColor = System.Drawing.Color.White;
            this.BTNSalir.FlatAppearance.BorderSize = 0;
            this.BTNSalir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.BTNSalir.ForeColor = System.Drawing.Color.Black;
            this.BTNSalir.Location = new System.Drawing.Point(593, 90);
            this.BTNSalir.Name = "BTNSalir";
            this.BTNSalir.Size = new System.Drawing.Size(158, 23);
            this.BTNSalir.TabIndex = 56;
            this.BTNSalir.Text = "Salir";
            this.BTNSalir.UseVisualStyleBackColor = false;
            this.BTNSalir.Click += new System.EventHandler(this.BTNSalir_Click);
            // 
            // BTNFiltrar
            // 
            this.BTNFiltrar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.BTNFiltrar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.BTNFiltrar.Image = global::SistemaDeInventario2026.Properties.Resources.ic_buscar;
            this.BTNFiltrar.ImageFixedSize = new System.Drawing.Size(20, 20);
            this.BTNFiltrar.Location = new System.Drawing.Point(563, 90);
            this.BTNFiltrar.Name = "BTNFiltrar";
            this.BTNFiltrar.Size = new System.Drawing.Size(24, 23);
            this.BTNFiltrar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.BTNFiltrar.TabIndex = 55;
            this.BTNFiltrar.Click += new System.EventHandler(this.BTNFiltrar_Click);
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
            this.IINFilas.Location = new System.Drawing.Point(189, 90);
            this.IINFilas.MaxValue = 1000;
            this.IINFilas.MinValue = 0;
            this.IINFilas.Name = "IINFilas";
            this.IINFilas.ShowUpDown = true;
            this.IINFilas.Size = new System.Drawing.Size(50, 23);
            this.IINFilas.TabIndex = 54;
            this.IINFilas.Value = 50;
            // 
            // TXTFiltrar
            // 
            this.TXTFiltrar.Location = new System.Drawing.Point(245, 90);
            this.TXTFiltrar.Name = "TXTFiltrar";
            this.TXTFiltrar.Size = new System.Drawing.Size(312, 23);
            this.TXTFiltrar.TabIndex = 53;
            // 
            // LBLDetalles_Venta_Lista
            // 
            this.LBLDetalles_Venta_Lista.AutoSize = true;
            // 
            // 
            // 
            this.LBLDetalles_Venta_Lista.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.LBLDetalles_Venta_Lista.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLDetalles_Venta_Lista.FontBold = true;
            this.LBLDetalles_Venta_Lista.Location = new System.Drawing.Point(291, 34);
            this.LBLDetalles_Venta_Lista.Name = "LBLDetalles_Venta_Lista";
            this.LBLDetalles_Venta_Lista.Size = new System.Drawing.Size(352, 50);
            this.LBLDetalles_Venta_Lista.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2000;
            this.LBLDetalles_Venta_Lista.TabIndex = 52;
            this.LBLDetalles_Venta_Lista.Text = "Historial de Ventas";
            this.LBLDetalles_Venta_Lista.TextAlignment = System.Drawing.StringAlignment.Center;
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
            this.DTGLista.Cursor = System.Windows.Forms.Cursors.Default;
            this.DTGLista.GridColor = System.Drawing.SystemColors.Control;
            this.DTGLista.Location = new System.Drawing.Point(13, 144);
            this.DTGLista.Margin = new System.Windows.Forms.Padding(4);
            this.DTGLista.MultiSelect = false;
            this.DTGLista.Name = "DTGLista";
            this.DTGLista.ReadOnly = true;
            this.DTGLista.RowHeadersVisible = false;
            this.DTGLista.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DTGLista.Size = new System.Drawing.Size(944, 341);
            this.DTGLista.TabIndex = 51;
            this.DTGLista.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DTGLista_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Código";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Visible = false;
            this.Column1.Width = 50;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Usuario";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 205;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Cliente";
            this.Column3.MinimumWidth = 20;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 270;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Fecha Creacion";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 240;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Total";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 110;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Acciones";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Text = "Ver";
            this.Column6.UseColumnTextForButtonValue = true;
            this.Column6.Width = 115;
            // 
            // FRMVenta_Lista_Filtro_Auditoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(970, 519);
            this.Controls.Add(this.PPrincipal);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FRMVenta_Lista_Filtro_Auditoria";
            this.Text = "FRMVenta_Lista_Filtro_Auditoria";
            this.Load += new System.EventHandler(this.FRMVenta_Lista_Filtro_Auditoria_Load);
            this.PPrincipal.ResumeLayout(false);
            this.PVenta_Lista_Fecha.ResumeLayout(false);
            this.PVenta_Lista_Fecha.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IINFilas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DTGLista)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PPrincipal;
        private System.Windows.Forms.Panel PVenta_Lista_Fecha;
        private System.Windows.Forms.Button BTNSalir;
        private DevComponents.DotNetBar.ButtonX BTNFiltrar;
        private DevComponents.Editors.IntegerInput IINFilas;
        private System.Windows.Forms.TextBox TXTFiltrar;
        private DevComponents.DotNetBar.LabelX LBLDetalles_Venta_Lista;
        private System.Windows.Forms.DataGridView DTGLista;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewButtonColumn Column6;
    }
}