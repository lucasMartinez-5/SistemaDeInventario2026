namespace SistemaDeInventario2026
{
    partial class FRMAdministracion_Extracto_Fecha
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
            this.PAdmin_Venta_Extracto = new System.Windows.Forms.Panel();
            this.PVentaTotal = new System.Windows.Forms.Panel();
            this.LBLCantidadVendidaTotal = new DevComponents.DotNetBar.LabelX();
            this.LBLMontoVentaTotal = new DevComponents.DotNetBar.LabelX();
            this.LBLInversionTotal = new DevComponents.DotNetBar.LabelX();
            this.label1 = new System.Windows.Forms.Label();
            this.PFechaVentas = new System.Windows.Forms.Panel();
            this.BTNVerTodoVentas = new System.Windows.Forms.Button();
            this.LBLRangoFechas = new DevComponents.DotNetBar.LabelX();
            this.BTNElegirFecha = new System.Windows.Forms.Button();
            this.BTNVerDetalles = new System.Windows.Forms.Button();
            this.LBLMontoVentaFecha = new DevComponents.DotNetBar.LabelX();
            this.LBLTitulo = new DevComponents.DotNetBar.LabelX();
            this.PPrincipal.SuspendLayout();
            this.PAdmin_Venta_Extracto.SuspendLayout();
            this.PVentaTotal.SuspendLayout();
            this.PFechaVentas.SuspendLayout();
            this.SuspendLayout();
            // 
            // PPrincipal
            // 
            this.PPrincipal.BackColor = System.Drawing.Color.White;
            this.PPrincipal.Controls.Add(this.PAdmin_Venta_Extracto);
            this.PPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PPrincipal.Location = new System.Drawing.Point(0, 0);
            this.PPrincipal.Name = "PPrincipal";
            this.PPrincipal.Size = new System.Drawing.Size(970, 519);
            this.PPrincipal.TabIndex = 0;
            // 
            // PAdmin_Venta_Extracto
            // 
            this.PAdmin_Venta_Extracto.Controls.Add(this.PVentaTotal);
            this.PAdmin_Venta_Extracto.Controls.Add(this.label1);
            this.PAdmin_Venta_Extracto.Controls.Add(this.PFechaVentas);
            this.PAdmin_Venta_Extracto.Controls.Add(this.LBLTitulo);
            this.PAdmin_Venta_Extracto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PAdmin_Venta_Extracto.Location = new System.Drawing.Point(0, 0);
            this.PAdmin_Venta_Extracto.Name = "PAdmin_Venta_Extracto";
            this.PAdmin_Venta_Extracto.Size = new System.Drawing.Size(970, 519);
            this.PAdmin_Venta_Extracto.TabIndex = 0;
            // 
            // PVentaTotal
            // 
            this.PVentaTotal.Controls.Add(this.LBLCantidadVendidaTotal);
            this.PVentaTotal.Controls.Add(this.LBLMontoVentaTotal);
            this.PVentaTotal.Controls.Add(this.LBLInversionTotal);
            this.PVentaTotal.Location = new System.Drawing.Point(139, 253);
            this.PVentaTotal.Name = "PVentaTotal";
            this.PVentaTotal.Size = new System.Drawing.Size(299, 174);
            this.PVentaTotal.TabIndex = 88;
            // 
            // LBLCantidadVendidaTotal
            // 
            this.LBLCantidadVendidaTotal.AutoSize = true;
            // 
            // 
            // 
            this.LBLCantidadVendidaTotal.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.LBLCantidadVendidaTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLCantidadVendidaTotal.FontBold = true;
            this.LBLCantidadVendidaTotal.Location = new System.Drawing.Point(14, 120);
            this.LBLCantidadVendidaTotal.Margin = new System.Windows.Forms.Padding(4);
            this.LBLCantidadVendidaTotal.Name = "LBLCantidadVendidaTotal";
            this.LBLCantidadVendidaTotal.Size = new System.Drawing.Size(134, 50);
            this.LBLCantidadVendidaTotal.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2000;
            this.LBLCantidadVendidaTotal.TabIndex = 86;
            this.LBLCantidadVendidaTotal.Text = "0 Unid.";
            this.LBLCantidadVendidaTotal.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // LBLMontoVentaTotal
            // 
            this.LBLMontoVentaTotal.AutoSize = true;
            // 
            // 
            // 
            this.LBLMontoVentaTotal.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.LBLMontoVentaTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLMontoVentaTotal.FontBold = true;
            this.LBLMontoVentaTotal.Location = new System.Drawing.Point(14, 70);
            this.LBLMontoVentaTotal.Margin = new System.Windows.Forms.Padding(4);
            this.LBLMontoVentaTotal.Name = "LBLMontoVentaTotal";
            this.LBLMontoVentaTotal.Size = new System.Drawing.Size(118, 50);
            this.LBLMontoVentaTotal.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2000;
            this.LBLMontoVentaTotal.TabIndex = 85;
            this.LBLMontoVentaTotal.Text = "$0000";
            this.LBLMontoVentaTotal.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // LBLInversionTotal
            // 
            this.LBLInversionTotal.AutoSize = true;
            // 
            // 
            // 
            this.LBLInversionTotal.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.LBLInversionTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLInversionTotal.FontBold = true;
            this.LBLInversionTotal.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.LBLInversionTotal.Location = new System.Drawing.Point(14, 35);
            this.LBLInversionTotal.Margin = new System.Windows.Forms.Padding(4);
            this.LBLInversionTotal.Name = "LBLInversionTotal";
            this.LBLInversionTotal.Size = new System.Drawing.Size(109, 27);
            this.LBLInversionTotal.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2000;
            this.LBLInversionTotal.TabIndex = 84;
            this.LBLInversionTotal.Text = "Venta Total";
            this.LBLInversionTotal.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(319, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(305, 20);
            this.label1.TabIndex = 87;
            this.label1.Text = "Consulta las ventas en general / por fecha";
            // 
            // PFechaVentas
            // 
            this.PFechaVentas.Controls.Add(this.BTNVerTodoVentas);
            this.PFechaVentas.Controls.Add(this.LBLRangoFechas);
            this.PFechaVentas.Controls.Add(this.BTNElegirFecha);
            this.PFechaVentas.Controls.Add(this.BTNVerDetalles);
            this.PFechaVentas.Controls.Add(this.LBLMontoVentaFecha);
            this.PFechaVentas.Location = new System.Drawing.Point(465, 253);
            this.PFechaVentas.Name = "PFechaVentas";
            this.PFechaVentas.Size = new System.Drawing.Size(366, 174);
            this.PFechaVentas.TabIndex = 89;
            // 
            // BTNVerTodoVentas
            // 
            this.BTNVerTodoVentas.BackColor = System.Drawing.Color.Black;
            this.BTNVerTodoVentas.FlatAppearance.BorderSize = 0;
            this.BTNVerTodoVentas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.BTNVerTodoVentas.ForeColor = System.Drawing.Color.White;
            this.BTNVerTodoVentas.Location = new System.Drawing.Point(195, 128);
            this.BTNVerTodoVentas.Margin = new System.Windows.Forms.Padding(4);
            this.BTNVerTodoVentas.Name = "BTNVerTodoVentas";
            this.BTNVerTodoVentas.Size = new System.Drawing.Size(167, 32);
            this.BTNVerTodoVentas.TabIndex = 91;
            this.BTNVerTodoVentas.Text = "Ver Todas las ventas";
            this.BTNVerTodoVentas.UseVisualStyleBackColor = false;
            this.BTNVerTodoVentas.Click += new System.EventHandler(this.BTNVerTodoVentas_Click);
            // 
            // LBLRangoFechas
            // 
            this.LBLRangoFechas.AutoSize = true;
            // 
            // 
            // 
            this.LBLRangoFechas.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.LBLRangoFechas.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLRangoFechas.FontBold = true;
            this.LBLRangoFechas.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.LBLRangoFechas.Location = new System.Drawing.Point(14, 35);
            this.LBLRangoFechas.Margin = new System.Windows.Forms.Padding(4);
            this.LBLRangoFechas.Name = "LBLRangoFechas";
            this.LBLRangoFechas.Size = new System.Drawing.Size(124, 27);
            this.LBLRangoFechas.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2000;
            this.LBLRangoFechas.TabIndex = 90;
            this.LBLRangoFechas.Text = "Fecha Actual";
            this.LBLRangoFechas.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // BTNElegirFecha
            // 
            this.BTNElegirFecha.BackColor = System.Drawing.Color.White;
            this.BTNElegirFecha.FlatAppearance.BorderSize = 0;
            this.BTNElegirFecha.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.BTNElegirFecha.ForeColor = System.Drawing.Color.Black;
            this.BTNElegirFecha.Location = new System.Drawing.Point(217, 3);
            this.BTNElegirFecha.Name = "BTNElegirFecha";
            this.BTNElegirFecha.Size = new System.Drawing.Size(145, 32);
            this.BTNElegirFecha.TabIndex = 89;
            this.BTNElegirFecha.Text = "Elegir Fecha";
            this.BTNElegirFecha.UseVisualStyleBackColor = false;
            this.BTNElegirFecha.Click += new System.EventHandler(this.BTNElegirFecha_Click);
            // 
            // BTNVerDetalles
            // 
            this.BTNVerDetalles.BackColor = System.Drawing.Color.Black;
            this.BTNVerDetalles.FlatAppearance.BorderSize = 0;
            this.BTNVerDetalles.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.BTNVerDetalles.ForeColor = System.Drawing.Color.White;
            this.BTNVerDetalles.Location = new System.Drawing.Point(14, 128);
            this.BTNVerDetalles.Margin = new System.Windows.Forms.Padding(4);
            this.BTNVerDetalles.Name = "BTNVerDetalles";
            this.BTNVerDetalles.Size = new System.Drawing.Size(124, 32);
            this.BTNVerDetalles.TabIndex = 88;
            this.BTNVerDetalles.Text = "Ver Detalles";
            this.BTNVerDetalles.UseVisualStyleBackColor = false;
            this.BTNVerDetalles.Click += new System.EventHandler(this.BTNVerDetalles_Click);
            // 
            // LBLMontoVentaFecha
            // 
            this.LBLMontoVentaFecha.AutoSize = true;
            // 
            // 
            // 
            this.LBLMontoVentaFecha.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.LBLMontoVentaFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLMontoVentaFecha.FontBold = true;
            this.LBLMontoVentaFecha.Location = new System.Drawing.Point(14, 70);
            this.LBLMontoVentaFecha.Margin = new System.Windows.Forms.Padding(4);
            this.LBLMontoVentaFecha.Name = "LBLMontoVentaFecha";
            this.LBLMontoVentaFecha.Size = new System.Drawing.Size(118, 50);
            this.LBLMontoVentaFecha.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2000;
            this.LBLMontoVentaFecha.TabIndex = 85;
            this.LBLMontoVentaFecha.Text = "$0000";
            this.LBLMontoVentaFecha.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // LBLTitulo
            // 
            this.LBLTitulo.AutoSize = true;
            // 
            // 
            // 
            this.LBLTitulo.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.LBLTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLTitulo.FontBold = true;
            this.LBLTitulo.Location = new System.Drawing.Point(283, 55);
            this.LBLTitulo.Margin = new System.Windows.Forms.Padding(4);
            this.LBLTitulo.Name = "LBLTitulo";
            this.LBLTitulo.Size = new System.Drawing.Size(376, 50);
            this.LBLTitulo.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2000;
            this.LBLTitulo.TabIndex = 86;
            this.LBLTitulo.Text = "Resumen de Ventas";
            this.LBLTitulo.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // FRMAdministracion_Extracto_Fecha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(970, 519);
            this.Controls.Add(this.PPrincipal);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FRMAdministracion_Extracto_Fecha";
            this.Text = "FRMAdministracion_Extracto_Fecha";
            this.Load += new System.EventHandler(this.FRMAdministracion_Extracto_Fecha_Load);
            this.PPrincipal.ResumeLayout(false);
            this.PAdmin_Venta_Extracto.ResumeLayout(false);
            this.PAdmin_Venta_Extracto.PerformLayout();
            this.PVentaTotal.ResumeLayout(false);
            this.PVentaTotal.PerformLayout();
            this.PFechaVentas.ResumeLayout(false);
            this.PFechaVentas.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PPrincipal;
        private System.Windows.Forms.Panel PAdmin_Venta_Extracto;
        private System.Windows.Forms.Panel PVentaTotal;
        private DevComponents.DotNetBar.LabelX LBLMontoVentaTotal;
        private DevComponents.DotNetBar.LabelX LBLInversionTotal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel PFechaVentas;
        private DevComponents.DotNetBar.LabelX LBLRangoFechas;
        private System.Windows.Forms.Button BTNElegirFecha;
        private System.Windows.Forms.Button BTNVerDetalles;
        private DevComponents.DotNetBar.LabelX LBLMontoVentaFecha;
        private DevComponents.DotNetBar.LabelX LBLTitulo;
        private DevComponents.DotNetBar.LabelX LBLCantidadVendidaTotal;
        private System.Windows.Forms.Button BTNVerTodoVentas;
    }
}