namespace SistemaDeInventario2026
{
    partial class FRMProducto_Alerta_Stock
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
            this.PAlertasConfig_Producto = new System.Windows.Forms.Panel();
            this.BTNCancelar = new System.Windows.Forms.Button();
            this.NUDCantidadMinima = new System.Windows.Forms.NumericUpDown();
            this.LBLAlertas2 = new DevComponents.DotNetBar.LabelX();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.BTNSalir = new System.Windows.Forms.Button();
            this.BTNGuardar = new System.Windows.Forms.Button();
            this.LBLCantidadMinima = new MaterialSkin.Controls.MaterialLabel();
            this.LBLAlertas = new DevComponents.DotNetBar.LabelX();
            this.PPrincipal.SuspendLayout();
            this.PAlertasConfig_Producto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUDCantidadMinima)).BeginInit();
            this.SuspendLayout();
            // 
            // PPrincipal
            // 
            this.PPrincipal.BackColor = System.Drawing.Color.White;
            this.PPrincipal.Controls.Add(this.PAlertasConfig_Producto);
            this.PPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PPrincipal.Location = new System.Drawing.Point(0, 0);
            this.PPrincipal.Name = "PPrincipal";
            this.PPrincipal.Size = new System.Drawing.Size(970, 519);
            this.PPrincipal.TabIndex = 0;
            // 
            // PAlertasConfig_Producto
            // 
            this.PAlertasConfig_Producto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PAlertasConfig_Producto.Controls.Add(this.BTNCancelar);
            this.PAlertasConfig_Producto.Controls.Add(this.NUDCantidadMinima);
            this.PAlertasConfig_Producto.Controls.Add(this.LBLAlertas2);
            this.PAlertasConfig_Producto.Controls.Add(this.materialLabel3);
            this.PAlertasConfig_Producto.Controls.Add(this.BTNSalir);
            this.PAlertasConfig_Producto.Controls.Add(this.BTNGuardar);
            this.PAlertasConfig_Producto.Controls.Add(this.LBLCantidadMinima);
            this.PAlertasConfig_Producto.Controls.Add(this.LBLAlertas);
            this.PAlertasConfig_Producto.Location = new System.Drawing.Point(0, 0);
            this.PAlertasConfig_Producto.Name = "PAlertasConfig_Producto";
            this.PAlertasConfig_Producto.Size = new System.Drawing.Size(970, 519);
            this.PAlertasConfig_Producto.TabIndex = 0;
            // 
            // BTNCancelar
            // 
            this.BTNCancelar.BackColor = System.Drawing.Color.White;
            this.BTNCancelar.FlatAppearance.BorderSize = 0;
            this.BTNCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.BTNCancelar.ForeColor = System.Drawing.Color.Black;
            this.BTNCancelar.Location = new System.Drawing.Point(510, 268);
            this.BTNCancelar.Name = "BTNCancelar";
            this.BTNCancelar.Size = new System.Drawing.Size(106, 38);
            this.BTNCancelar.TabIndex = 102;
            this.BTNCancelar.Text = "Cancelar";
            this.BTNCancelar.UseVisualStyleBackColor = false;
            this.BTNCancelar.Click += new System.EventHandler(this.BTNCancelar_Click);
            // 
            // NUDCantidadMinima
            // 
            this.NUDCantidadMinima.Location = new System.Drawing.Point(510, 218);
            this.NUDCantidadMinima.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.NUDCantidadMinima.Name = "NUDCantidadMinima";
            this.NUDCantidadMinima.Size = new System.Drawing.Size(180, 23);
            this.NUDCantidadMinima.TabIndex = 101;
            // 
            // LBLAlertas2
            // 
            this.LBLAlertas2.AutoSize = true;
            // 
            // 
            // 
            this.LBLAlertas2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.LBLAlertas2.Cursor = System.Windows.Forms.Cursors.Default;
            this.LBLAlertas2.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLAlertas2.FontBold = true;
            this.LBLAlertas2.Location = new System.Drawing.Point(92, 228);
            this.LBLAlertas2.Name = "LBLAlertas2";
            this.LBLAlertas2.Size = new System.Drawing.Size(133, 50);
            this.LBLAlertas2.TabIndex = 52;
            this.LBLAlertas2.Text = "Alertas";
            this.LBLAlertas2.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Cursor = System.Windows.Forms.Cursors.Default;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel3.Location = new System.Drawing.Point(89, 287);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(285, 19);
            this.materialLabel3.TabIndex = 51;
            this.materialLabel3.Text = "Acciones para la gestión de proveedores";
            // 
            // BTNSalir
            // 
            this.BTNSalir.BackColor = System.Drawing.Color.White;
            this.BTNSalir.FlatAppearance.BorderSize = 0;
            this.BTNSalir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.BTNSalir.ForeColor = System.Drawing.Color.Black;
            this.BTNSalir.Location = new System.Drawing.Point(734, 268);
            this.BTNSalir.Name = "BTNSalir";
            this.BTNSalir.Size = new System.Drawing.Size(106, 38);
            this.BTNSalir.TabIndex = 49;
            this.BTNSalir.Text = "Salir";
            this.BTNSalir.UseVisualStyleBackColor = false;
            this.BTNSalir.Click += new System.EventHandler(this.BTNSalir_Click);
            // 
            // BTNGuardar
            // 
            this.BTNGuardar.BackColor = System.Drawing.Color.Black;
            this.BTNGuardar.FlatAppearance.BorderSize = 0;
            this.BTNGuardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.BTNGuardar.ForeColor = System.Drawing.Color.White;
            this.BTNGuardar.Location = new System.Drawing.Point(622, 268);
            this.BTNGuardar.Name = "BTNGuardar";
            this.BTNGuardar.Size = new System.Drawing.Size(106, 38);
            this.BTNGuardar.TabIndex = 48;
            this.BTNGuardar.Text = "Guardar";
            this.BTNGuardar.UseVisualStyleBackColor = false;
            this.BTNGuardar.Click += new System.EventHandler(this.BTNGuardar_Click);
            // 
            // LBLCantidadMinima
            // 
            this.LBLCantidadMinima.AutoSize = true;
            this.LBLCantidadMinima.Depth = 0;
            this.LBLCantidadMinima.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.LBLCantidadMinima.Location = new System.Drawing.Point(507, 196);
            this.LBLCantidadMinima.MouseState = MaterialSkin.MouseState.HOVER;
            this.LBLCantidadMinima.Name = "LBLCantidadMinima";
            this.LBLCantidadMinima.Size = new System.Drawing.Size(183, 19);
            this.LBLCantidadMinima.TabIndex = 47;
            this.LBLCantidadMinima.Text = "Nivel de Cantidad Mínima";
            // 
            // LBLAlertas
            // 
            this.LBLAlertas.AutoSize = true;
            // 
            // 
            // 
            this.LBLAlertas.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.LBLAlertas.Cursor = System.Windows.Forms.Cursors.Default;
            this.LBLAlertas.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLAlertas.FontBold = true;
            this.LBLAlertas.Location = new System.Drawing.Point(92, 178);
            this.LBLAlertas.Name = "LBLAlertas";
            this.LBLAlertas.Size = new System.Drawing.Size(317, 50);
            this.LBLAlertas.TabIndex = 46;
            this.LBLAlertas.Text = "Configuración de";
            this.LBLAlertas.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // FRMProducto_Alerta_Stock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(970, 519);
            this.Controls.Add(this.PPrincipal);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FRMProducto_Alerta_Stock";
            this.Text = "FRMProducto_Alerta_Stock";
            this.Load += new System.EventHandler(this.FRMProducto_Alerta_Stock_Load);
            this.PPrincipal.ResumeLayout(false);
            this.PAlertasConfig_Producto.ResumeLayout(false);
            this.PAlertasConfig_Producto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUDCantidadMinima)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PPrincipal;
        private System.Windows.Forms.Panel PAlertasConfig_Producto;
        private System.Windows.Forms.Button BTNSalir;
        private System.Windows.Forms.Button BTNGuardar;
        private MaterialSkin.Controls.MaterialLabel LBLCantidadMinima;
        private DevComponents.DotNetBar.LabelX LBLAlertas;
        private DevComponents.DotNetBar.LabelX LBLAlertas2;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private System.Windows.Forms.NumericUpDown NUDCantidadMinima;
        private System.Windows.Forms.Button BTNCancelar;
    }
}