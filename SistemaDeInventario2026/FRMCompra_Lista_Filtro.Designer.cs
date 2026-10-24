namespace SistemaDeInventario2026
{
    partial class FRMCompra_Lista_Filtro
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
            this.PMenu_Compra_Lista_Filtro = new System.Windows.Forms.Panel();
            this.PCompra_Lista = new System.Windows.Forms.Panel();
            this.BTNSalir = new System.Windows.Forms.Button();
            this.BTNFiltrar = new DevComponents.DotNetBar.ButtonX();
            this.IINFilas = new DevComponents.Editors.IntegerInput();
            this.TXTFiltrar = new System.Windows.Forms.TextBox();
            this.LBLDetalles_Compra_Filtro = new DevComponents.DotNetBar.LabelX();
            this.DTGLista = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.PPrincipal.SuspendLayout();
            this.PMenu_Compra_Lista_Filtro.SuspendLayout();
            this.PCompra_Lista.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IINFilas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DTGLista)).BeginInit();
            this.SuspendLayout();
            // 
            // PPrincipal
            // 
            this.PPrincipal.BackColor = System.Drawing.Color.White;
            this.PPrincipal.Controls.Add(this.PMenu_Compra_Lista_Filtro);
            this.PPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PPrincipal.Location = new System.Drawing.Point(0, 0);
            this.PPrincipal.Name = "PPrincipal";
            this.PPrincipal.Size = new System.Drawing.Size(970, 519);
            this.PPrincipal.TabIndex = 0;
            // 
            // PMenu_Compra_Lista_Filtro
            // 
            this.PMenu_Compra_Lista_Filtro.Controls.Add(this.PCompra_Lista);
            this.PMenu_Compra_Lista_Filtro.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PMenu_Compra_Lista_Filtro.Location = new System.Drawing.Point(0, 0);
            this.PMenu_Compra_Lista_Filtro.Name = "PMenu_Compra_Lista_Filtro";
            this.PMenu_Compra_Lista_Filtro.Size = new System.Drawing.Size(970, 519);
            this.PMenu_Compra_Lista_Filtro.TabIndex = 0;
            // 
            // PCompra_Lista
            // 
            this.PCompra_Lista.Controls.Add(this.BTNSalir);
            this.PCompra_Lista.Controls.Add(this.BTNFiltrar);
            this.PCompra_Lista.Controls.Add(this.IINFilas);
            this.PCompra_Lista.Controls.Add(this.TXTFiltrar);
            this.PCompra_Lista.Controls.Add(this.LBLDetalles_Compra_Filtro);
            this.PCompra_Lista.Controls.Add(this.DTGLista);
            this.PCompra_Lista.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PCompra_Lista.Location = new System.Drawing.Point(0, 0);
            this.PCompra_Lista.Name = "PCompra_Lista";
            this.PCompra_Lista.Size = new System.Drawing.Size(970, 519);
            this.PCompra_Lista.TabIndex = 16;
            // 
            // BTNSalir
            // 
            this.BTNSalir.BackColor = System.Drawing.Color.White;
            this.BTNSalir.FlatAppearance.BorderSize = 0;
            this.BTNSalir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.BTNSalir.ForeColor = System.Drawing.Color.Black;
            this.BTNSalir.Location = new System.Drawing.Point(591, 88);
            this.BTNSalir.Name = "BTNSalir";
            this.BTNSalir.Size = new System.Drawing.Size(158, 23);
            this.BTNSalir.TabIndex = 44;
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
            this.BTNFiltrar.Location = new System.Drawing.Point(561, 88);
            this.BTNFiltrar.Name = "BTNFiltrar";
            this.BTNFiltrar.Size = new System.Drawing.Size(24, 23);
            this.BTNFiltrar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.BTNFiltrar.TabIndex = 15;
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
            this.IINFilas.Location = new System.Drawing.Point(187, 88);
            this.IINFilas.MaxValue = 1000;
            this.IINFilas.MinValue = 0;
            this.IINFilas.Name = "IINFilas";
            this.IINFilas.ShowUpDown = true;
            this.IINFilas.Size = new System.Drawing.Size(50, 23);
            this.IINFilas.TabIndex = 14;
            this.IINFilas.Value = 50;
            // 
            // TXTFiltrar
            // 
            this.TXTFiltrar.Location = new System.Drawing.Point(243, 88);
            this.TXTFiltrar.Name = "TXTFiltrar";
            this.TXTFiltrar.Size = new System.Drawing.Size(312, 23);
            this.TXTFiltrar.TabIndex = 13;
            // 
            // LBLDetalles_Compra_Filtro
            // 
            this.LBLDetalles_Compra_Filtro.AutoSize = true;
            // 
            // 
            // 
            this.LBLDetalles_Compra_Filtro.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.LBLDetalles_Compra_Filtro.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLDetalles_Compra_Filtro.FontBold = true;
            this.LBLDetalles_Compra_Filtro.Location = new System.Drawing.Point(264, 32);
            this.LBLDetalles_Compra_Filtro.Name = "LBLDetalles_Compra_Filtro";
            this.LBLDetalles_Compra_Filtro.Size = new System.Drawing.Size(390, 50);
            this.LBLDetalles_Compra_Filtro.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2000;
            this.LBLDetalles_Compra_Filtro.TabIndex = 12;
            this.LBLDetalles_Compra_Filtro.Text = "Historial de Compras";
            this.LBLDetalles_Compra_Filtro.TextAlignment = System.Drawing.StringAlignment.Center;
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
            this.Column3,
            this.Column4,
            this.Column2,
            this.Column7});
            this.DTGLista.Cursor = System.Windows.Forms.Cursors.Default;
            this.DTGLista.GridColor = System.Drawing.SystemColors.Control;
            this.DTGLista.Location = new System.Drawing.Point(40, 142);
            this.DTGLista.Margin = new System.Windows.Forms.Padding(4);
            this.DTGLista.MultiSelect = false;
            this.DTGLista.Name = "DTGLista";
            this.DTGLista.ReadOnly = true;
            this.DTGLista.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DTGLista.Size = new System.Drawing.Size(887, 341);
            this.DTGLista.TabIndex = 11;
            this.DTGLista.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DTGLista_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Código";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Visible = false;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "N° Factura";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 201;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Proveedor";
            this.Column4.MinimumWidth = 20;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 365;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Total";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 145;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Acciones";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.Text = "Ver";
            this.Column7.UseColumnTextForButtonValue = true;
            this.Column7.Width = 135;
            // 
            // FRMCompra_Lista_Filtro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(970, 519);
            this.Controls.Add(this.PPrincipal);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FRMCompra_Lista_Filtro";
            this.Text = "FRMCompra_Lista_Filtro";
            this.Load += new System.EventHandler(this.FRMCompra_Lista_Filtro_Load);
            this.PPrincipal.ResumeLayout(false);
            this.PMenu_Compra_Lista_Filtro.ResumeLayout(false);
            this.PCompra_Lista.ResumeLayout(false);
            this.PCompra_Lista.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IINFilas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DTGLista)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PPrincipal;
        private System.Windows.Forms.Panel PMenu_Compra_Lista_Filtro;
        private System.Windows.Forms.Panel PCompra_Lista;
        private System.Windows.Forms.Button BTNSalir;
        private DevComponents.DotNetBar.ButtonX BTNFiltrar;
        private DevComponents.Editors.IntegerInput IINFilas;
        private System.Windows.Forms.TextBox TXTFiltrar;
        private DevComponents.DotNetBar.LabelX LBLDetalles_Compra_Filtro;
        private System.Windows.Forms.DataGridView DTGLista;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewButtonColumn Column7;
    }
}