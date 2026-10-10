namespace SistemaDeInventario2026
{
    partial class FRMCompra_Resumen
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
            this.PCompra_Resumen = new System.Windows.Forms.Panel();
            this.PFechaInversion = new System.Windows.Forms.Panel();
            this.LBLRangoFechas = new DevComponents.DotNetBar.LabelX();
            this.BTNElegirFecha = new System.Windows.Forms.Button();
            this.BTNVerDetalles = new System.Windows.Forms.Button();
            this.LBLMontoInversionFecha = new DevComponents.DotNetBar.LabelX();
            this.PInversionTotal = new System.Windows.Forms.Panel();
            this.LBLMontoInverstionTotal = new DevComponents.DotNetBar.LabelX();
            this.LBLInversionTotal = new DevComponents.DotNetBar.LabelX();
            this.label1 = new System.Windows.Forms.Label();
            this.LBLTitulo = new DevComponents.DotNetBar.LabelX();
            this.PPrincipal.SuspendLayout();
            this.PCompra_Resumen.SuspendLayout();
            this.PFechaInversion.SuspendLayout();
            this.PInversionTotal.SuspendLayout();
            this.SuspendLayout();
            // 
            // PPrincipal
            // 
            this.PPrincipal.BackColor = System.Drawing.Color.White;
            this.PPrincipal.Controls.Add(this.PCompra_Resumen);
            this.PPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PPrincipal.Location = new System.Drawing.Point(0, 0);
            this.PPrincipal.Name = "PPrincipal";
            this.PPrincipal.Size = new System.Drawing.Size(970, 519);
            this.PPrincipal.TabIndex = 0;
            // 
            // PCompra_Resumen
            // 
            this.PCompra_Resumen.Controls.Add(this.PFechaInversion);
            this.PCompra_Resumen.Controls.Add(this.PInversionTotal);
            this.PCompra_Resumen.Controls.Add(this.label1);
            this.PCompra_Resumen.Controls.Add(this.LBLTitulo);
            this.PCompra_Resumen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PCompra_Resumen.Location = new System.Drawing.Point(0, 0);
            this.PCompra_Resumen.Name = "PCompra_Resumen";
            this.PCompra_Resumen.Size = new System.Drawing.Size(970, 519);
            this.PCompra_Resumen.TabIndex = 0;
            // 
            // PFechaInversion
            // 
            this.PFechaInversion.Controls.Add(this.LBLRangoFechas);
            this.PFechaInversion.Controls.Add(this.BTNElegirFecha);
            this.PFechaInversion.Controls.Add(this.BTNVerDetalles);
            this.PFechaInversion.Controls.Add(this.LBLMontoInversionFecha);
            this.PFechaInversion.Location = new System.Drawing.Point(430, 196);
            this.PFechaInversion.Name = "PFechaInversion";
            this.PFechaInversion.Size = new System.Drawing.Size(366, 174);
            this.PFechaInversion.TabIndex = 85;
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
            // LBLMontoInversionFecha
            // 
            this.LBLMontoInversionFecha.AutoSize = true;
            // 
            // 
            // 
            this.LBLMontoInversionFecha.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.LBLMontoInversionFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLMontoInversionFecha.FontBold = true;
            this.LBLMontoInversionFecha.Location = new System.Drawing.Point(14, 70);
            this.LBLMontoInversionFecha.Margin = new System.Windows.Forms.Padding(4);
            this.LBLMontoInversionFecha.Name = "LBLMontoInversionFecha";
            this.LBLMontoInversionFecha.Size = new System.Drawing.Size(118, 50);
            this.LBLMontoInversionFecha.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2000;
            this.LBLMontoInversionFecha.TabIndex = 85;
            this.LBLMontoInversionFecha.Text = "$0000";
            this.LBLMontoInversionFecha.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // PInversionTotal
            // 
            this.PInversionTotal.Controls.Add(this.LBLMontoInverstionTotal);
            this.PInversionTotal.Controls.Add(this.LBLInversionTotal);
            this.PInversionTotal.Location = new System.Drawing.Point(104, 196);
            this.PInversionTotal.Name = "PInversionTotal";
            this.PInversionTotal.Size = new System.Drawing.Size(299, 174);
            this.PInversionTotal.TabIndex = 84;
            // 
            // LBLMontoInverstionTotal
            // 
            this.LBLMontoInverstionTotal.AutoSize = true;
            // 
            // 
            // 
            this.LBLMontoInverstionTotal.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.LBLMontoInverstionTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLMontoInverstionTotal.FontBold = true;
            this.LBLMontoInverstionTotal.Location = new System.Drawing.Point(14, 70);
            this.LBLMontoInverstionTotal.Margin = new System.Windows.Forms.Padding(4);
            this.LBLMontoInverstionTotal.Name = "LBLMontoInverstionTotal";
            this.LBLMontoInverstionTotal.Size = new System.Drawing.Size(118, 50);
            this.LBLMontoInverstionTotal.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2000;
            this.LBLMontoInverstionTotal.TabIndex = 85;
            this.LBLMontoInverstionTotal.Text = "$0000";
            this.LBLMontoInverstionTotal.TextAlignment = System.Drawing.StringAlignment.Center;
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
            this.LBLInversionTotal.Size = new System.Drawing.Size(139, 27);
            this.LBLInversionTotal.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2000;
            this.LBLInversionTotal.TabIndex = 84;
            this.LBLInversionTotal.Text = "Inversión Total";
            this.LBLInversionTotal.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(360, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(252, 20);
            this.label1.TabIndex = 82;
            this.label1.Text = "Consulta tus inversiones por fecha";
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
            this.LBLTitulo.Location = new System.Drawing.Point(269, 34);
            this.LBLTitulo.Margin = new System.Windows.Forms.Padding(4);
            this.LBLTitulo.Name = "LBLTitulo";
            this.LBLTitulo.Size = new System.Drawing.Size(460, 50);
            this.LBLTitulo.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2000;
            this.LBLTitulo.TabIndex = 81;
            this.LBLTitulo.Text = "Resumen de Inversiones";
            this.LBLTitulo.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // FRMCompra_Resumen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(970, 519);
            this.Controls.Add(this.PPrincipal);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FRMCompra_Resumen";
            this.Text = "FRMCompra_Resumen";
            this.Load += new System.EventHandler(this.FRMCompra_Resumen_Load);
            this.PPrincipal.ResumeLayout(false);
            this.PCompra_Resumen.ResumeLayout(false);
            this.PCompra_Resumen.PerformLayout();
            this.PFechaInversion.ResumeLayout(false);
            this.PFechaInversion.PerformLayout();
            this.PInversionTotal.ResumeLayout(false);
            this.PInversionTotal.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PPrincipal;
        private System.Windows.Forms.Panel PCompra_Resumen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel PInversionTotal;
        private DevComponents.DotNetBar.LabelX LBLMontoInverstionTotal;
        private DevComponents.DotNetBar.LabelX LBLInversionTotal;
        private DevComponents.DotNetBar.LabelX LBLTitulo;
        private System.Windows.Forms.Panel PFechaInversion;
        private DevComponents.DotNetBar.LabelX LBLMontoInversionFecha;
        private System.Windows.Forms.Button BTNVerDetalles;
        private System.Windows.Forms.Button BTNElegirFecha;
        private DevComponents.DotNetBar.LabelX LBLRangoFechas;
    }
}