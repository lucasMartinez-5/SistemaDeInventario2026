namespace SistemaDeInventario2026
{
    partial class FRMProveedor_Registrar
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
            this.PAgregar_Proveedor = new System.Windows.Forms.Panel();
            this.BTNBuscarProveedor = new DevComponents.DotNetBar.ButtonX();
            this.SWBEstado = new DevComponents.DotNetBar.Controls.SwitchButton();
            this.TXTRazonSocial = new System.Windows.Forms.TextBox();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.TXTDireccion = new System.Windows.Forms.TextBox();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.TXTCelular = new System.Windows.Forms.TextBox();
            this.TXTNIT = new System.Windows.Forms.TextBox();
            this.BTNLimpiar = new System.Windows.Forms.Button();
            this.BTNSalir = new System.Windows.Forms.Button();
            this.BTNGrabar = new System.Windows.Forms.Button();
            this.LBL = new MaterialSkin.Controls.MaterialLabel();
            this.LBLRegistrarProveedor = new DevComponents.DotNetBar.LabelX();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.PPrincipal.SuspendLayout();
            this.PAgregar_Proveedor.SuspendLayout();
            this.SuspendLayout();
            // 
            // PPrincipal
            // 
            this.PPrincipal.BackColor = System.Drawing.Color.White;
            this.PPrincipal.Controls.Add(this.PAgregar_Proveedor);
            this.PPrincipal.Cursor = System.Windows.Forms.Cursors.Default;
            this.PPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PPrincipal.Location = new System.Drawing.Point(0, 0);
            this.PPrincipal.Name = "PPrincipal";
            this.PPrincipal.Size = new System.Drawing.Size(1067, 552);
            this.PPrincipal.TabIndex = 2;
            // 
            // PAgregar_Proveedor
            // 
            this.PAgregar_Proveedor.Controls.Add(this.BTNBuscarProveedor);
            this.PAgregar_Proveedor.Controls.Add(this.SWBEstado);
            this.PAgregar_Proveedor.Controls.Add(this.TXTRazonSocial);
            this.PAgregar_Proveedor.Controls.Add(this.materialLabel2);
            this.PAgregar_Proveedor.Controls.Add(this.TXTDireccion);
            this.PAgregar_Proveedor.Controls.Add(this.materialLabel1);
            this.PAgregar_Proveedor.Controls.Add(this.TXTCelular);
            this.PAgregar_Proveedor.Controls.Add(this.TXTNIT);
            this.PAgregar_Proveedor.Controls.Add(this.BTNLimpiar);
            this.PAgregar_Proveedor.Controls.Add(this.BTNSalir);
            this.PAgregar_Proveedor.Controls.Add(this.BTNGrabar);
            this.PAgregar_Proveedor.Controls.Add(this.LBL);
            this.PAgregar_Proveedor.Controls.Add(this.LBLRegistrarProveedor);
            this.PAgregar_Proveedor.Controls.Add(this.materialLabel3);
            this.PAgregar_Proveedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PAgregar_Proveedor.Location = new System.Drawing.Point(0, 0);
            this.PAgregar_Proveedor.Name = "PAgregar_Proveedor";
            this.PAgregar_Proveedor.Size = new System.Drawing.Size(1067, 552);
            this.PAgregar_Proveedor.TabIndex = 14;
            this.PAgregar_Proveedor.Paint += new System.Windows.Forms.PaintEventHandler(this.PAgregar_Proveedor_Paint);
            // 
            // BTNBuscarProveedor
            // 
            this.BTNBuscarProveedor.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.BTNBuscarProveedor.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.BTNBuscarProveedor.Image = global::SistemaDeInventario2026.Properties.Resources.ic_buscar;
            this.BTNBuscarProveedor.ImageFixedSize = new System.Drawing.Size(15, 15);
            this.BTNBuscarProveedor.Location = new System.Drawing.Point(469, 199);
            this.BTNBuscarProveedor.Name = "BTNBuscarProveedor";
            this.BTNBuscarProveedor.Size = new System.Drawing.Size(23, 23);
            this.BTNBuscarProveedor.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.BTNBuscarProveedor.TabIndex = 52;
            this.BTNBuscarProveedor.Click += new System.EventHandler(this.BTNBuscarProveedor_Click);
            // 
            // SWBEstado
            // 
            // 
            // 
            // 
            this.SWBEstado.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.SWBEstado.Location = new System.Drawing.Point(595, 199);
            this.SWBEstado.Name = "SWBEstado";
            this.SWBEstado.Size = new System.Drawing.Size(191, 23);
            this.SWBEstado.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.SWBEstado.TabIndex = 51;
            // 
            // TXTRazonSocial
            // 
            this.TXTRazonSocial.Location = new System.Drawing.Point(595, 258);
            this.TXTRazonSocial.Name = "TXTRazonSocial";
            this.TXTRazonSocial.Size = new System.Drawing.Size(191, 23);
            this.TXTRazonSocial.TabIndex = 50;
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.Location = new System.Drawing.Point(592, 236);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(94, 19);
            this.materialLabel2.TabIndex = 49;
            this.materialLabel2.Text = "Razon Social";
            // 
            // TXTDireccion
            // 
            this.TXTDireccion.Location = new System.Drawing.Point(272, 321);
            this.TXTDireccion.Name = "TXTDireccion";
            this.TXTDireccion.Size = new System.Drawing.Size(514, 23);
            this.TXTDireccion.TabIndex = 48;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(269, 299);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(67, 19);
            this.materialLabel1.TabIndex = 47;
            this.materialLabel1.Text = "Direccion";
            // 
            // TXTCelular
            // 
            this.TXTCelular.Location = new System.Drawing.Point(272, 199);
            this.TXTCelular.Name = "TXTCelular";
            this.TXTCelular.Size = new System.Drawing.Size(191, 23);
            this.TXTCelular.TabIndex = 46;
            // 
            // TXTNIT
            // 
            this.TXTNIT.Location = new System.Drawing.Point(272, 258);
            this.TXTNIT.Name = "TXTNIT";
            this.TXTNIT.Size = new System.Drawing.Size(191, 23);
            this.TXTNIT.TabIndex = 45;
            // 
            // BTNLimpiar
            // 
            this.BTNLimpiar.BackColor = System.Drawing.Color.White;
            this.BTNLimpiar.FlatAppearance.BorderSize = 0;
            this.BTNLimpiar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.BTNLimpiar.ForeColor = System.Drawing.Color.Black;
            this.BTNLimpiar.Location = new System.Drawing.Point(611, 361);
            this.BTNLimpiar.Name = "BTNLimpiar";
            this.BTNLimpiar.Size = new System.Drawing.Size(158, 38);
            this.BTNLimpiar.TabIndex = 44;
            this.BTNLimpiar.Text = "Limpiar";
            this.BTNLimpiar.UseVisualStyleBackColor = false;
            // 
            // BTNSalir
            // 
            this.BTNSalir.BackColor = System.Drawing.Color.White;
            this.BTNSalir.FlatAppearance.BorderSize = 0;
            this.BTNSalir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.BTNSalir.ForeColor = System.Drawing.Color.Black;
            this.BTNSalir.Location = new System.Drawing.Point(288, 361);
            this.BTNSalir.Name = "BTNSalir";
            this.BTNSalir.Size = new System.Drawing.Size(158, 38);
            this.BTNSalir.TabIndex = 43;
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
            this.BTNGrabar.Location = new System.Drawing.Point(452, 361);
            this.BTNGrabar.Name = "BTNGrabar";
            this.BTNGrabar.Size = new System.Drawing.Size(153, 38);
            this.BTNGrabar.TabIndex = 42;
            this.BTNGrabar.Text = "Grabar";
            this.BTNGrabar.UseVisualStyleBackColor = false;
            this.BTNGrabar.Click += new System.EventHandler(this.BTNGrabar_Click);
            // 
            // LBL
            // 
            this.LBL.AutoSize = true;
            this.LBL.Depth = 0;
            this.LBL.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.LBL.Location = new System.Drawing.Point(269, 236);
            this.LBL.MouseState = MaterialSkin.MouseState.HOVER;
            this.LBL.Name = "LBL";
            this.LBL.Size = new System.Drawing.Size(26, 19);
            this.LBL.TabIndex = 41;
            this.LBL.Text = "NIT";
            // 
            // LBLRegistrarProveedor
            // 
            this.LBLRegistrarProveedor.AutoSize = true;
            // 
            // 
            // 
            this.LBLRegistrarProveedor.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.LBLRegistrarProveedor.Cursor = System.Windows.Forms.Cursors.Default;
            this.LBLRegistrarProveedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLRegistrarProveedor.FontBold = true;
            this.LBLRegistrarProveedor.Location = new System.Drawing.Point(366, 89);
            this.LBLRegistrarProveedor.Name = "LBLRegistrarProveedor";
            this.LBLRegistrarProveedor.Size = new System.Drawing.Size(353, 50);
            this.LBLRegistrarProveedor.TabIndex = 40;
            this.LBLRegistrarProveedor.Text = "Agregar Proveedor";
            this.LBLRegistrarProveedor.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Cursor = System.Windows.Forms.Cursors.Default;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel3.Location = new System.Drawing.Point(269, 177);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(50, 19);
            this.materialLabel3.TabIndex = 39;
            this.materialLabel3.Text = "Celular";
            // 
            // FRMProveedor_Registrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 552);
            this.Controls.Add(this.PPrincipal);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FRMProveedor_Registrar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FRMProveedor_Registrar_FormClosing);
            this.Load += new System.EventHandler(this.FRMProveedor_Registrar_Load);
            this.PPrincipal.ResumeLayout(false);
            this.PAgregar_Proveedor.ResumeLayout(false);
            this.PAgregar_Proveedor.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PPrincipal;
        private System.Windows.Forms.Panel PAgregar_Proveedor;
        private DevComponents.DotNetBar.ButtonX BTNBuscarProveedor;
        private DevComponents.DotNetBar.Controls.SwitchButton SWBEstado;
        private System.Windows.Forms.TextBox TXTRazonSocial;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private System.Windows.Forms.TextBox TXTDireccion;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private System.Windows.Forms.TextBox TXTCelular;
        private System.Windows.Forms.TextBox TXTNIT;
        private System.Windows.Forms.Button BTNLimpiar;
        private System.Windows.Forms.Button BTNSalir;
        private System.Windows.Forms.Button BTNGrabar;
        private MaterialSkin.Controls.MaterialLabel LBL;
        private DevComponents.DotNetBar.LabelX LBLRegistrarProveedor;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
    }
}