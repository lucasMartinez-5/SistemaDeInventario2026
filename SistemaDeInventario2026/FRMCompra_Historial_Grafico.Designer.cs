namespace SistemaDeInventario2026
{
    partial class FRMCompra_Historial_Grafico
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.PPrincipal = new System.Windows.Forms.Panel();
            this.PCompra_HistorialGrafico = new System.Windows.Forms.Panel();
            this.NUDAnio = new System.Windows.Forms.NumericUpDown();
            this.BTNConsultar = new System.Windows.Forms.Button();
            this.BTNSalir = new System.Windows.Forms.Button();
            this.LBLSubTitulo = new DevComponents.DotNetBar.LabelX();
            this.LBLTitulo = new DevComponents.DotNetBar.LabelX();
            this.CHTCompra_HistorialGrafico = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.PPrincipal.SuspendLayout();
            this.PCompra_HistorialGrafico.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUDAnio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CHTCompra_HistorialGrafico)).BeginInit();
            this.SuspendLayout();
            // 
            // PPrincipal
            // 
            this.PPrincipal.BackColor = System.Drawing.Color.White;
            this.PPrincipal.Controls.Add(this.PCompra_HistorialGrafico);
            this.PPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PPrincipal.Location = new System.Drawing.Point(0, 0);
            this.PPrincipal.Margin = new System.Windows.Forms.Padding(4);
            this.PPrincipal.Name = "PPrincipal";
            this.PPrincipal.Size = new System.Drawing.Size(1067, 552);
            this.PPrincipal.TabIndex = 0;
            // 
            // PCompra_HistorialGrafico
            // 
            this.PCompra_HistorialGrafico.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PCompra_HistorialGrafico.Controls.Add(this.NUDAnio);
            this.PCompra_HistorialGrafico.Controls.Add(this.BTNConsultar);
            this.PCompra_HistorialGrafico.Controls.Add(this.BTNSalir);
            this.PCompra_HistorialGrafico.Controls.Add(this.LBLSubTitulo);
            this.PCompra_HistorialGrafico.Controls.Add(this.LBLTitulo);
            this.PCompra_HistorialGrafico.Controls.Add(this.CHTCompra_HistorialGrafico);
            this.PCompra_HistorialGrafico.Location = new System.Drawing.Point(0, 0);
            this.PCompra_HistorialGrafico.Margin = new System.Windows.Forms.Padding(4);
            this.PCompra_HistorialGrafico.Name = "PCompra_HistorialGrafico";
            this.PCompra_HistorialGrafico.Size = new System.Drawing.Size(1067, 552);
            this.PCompra_HistorialGrafico.TabIndex = 0;
            // 
            // NUDAnio
            // 
            this.NUDAnio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NUDAnio.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NUDAnio.Location = new System.Drawing.Point(593, 153);
            this.NUDAnio.Margin = new System.Windows.Forms.Padding(4);
            this.NUDAnio.Maximum = new decimal(new int[] {
            2100,
            0,
            0,
            0});
            this.NUDAnio.Minimum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.NUDAnio.Name = "NUDAnio";
            this.NUDAnio.Size = new System.Drawing.Size(160, 30);
            this.NUDAnio.TabIndex = 84;
            this.NUDAnio.Value = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.NUDAnio.ValueChanged += new System.EventHandler(this.NUDAnio_ValueChanged);
            // 
            // BTNConsultar
            // 
            this.BTNConsultar.BackColor = System.Drawing.Color.Black;
            this.BTNConsultar.FlatAppearance.BorderSize = 0;
            this.BTNConsultar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.BTNConsultar.ForeColor = System.Drawing.Color.White;
            this.BTNConsultar.Location = new System.Drawing.Point(761, 153);
            this.BTNConsultar.Margin = new System.Windows.Forms.Padding(4);
            this.BTNConsultar.Name = "BTNConsultar";
            this.BTNConsultar.Size = new System.Drawing.Size(140, 32);
            this.BTNConsultar.TabIndex = 83;
            this.BTNConsultar.Text = "Consultar";
            this.BTNConsultar.UseVisualStyleBackColor = false;
            this.BTNConsultar.Click += new System.EventHandler(this.BTNConsultar_Click);
            // 
            // BTNSalir
            // 
            this.BTNSalir.BackColor = System.Drawing.Color.White;
            this.BTNSalir.FlatAppearance.BorderSize = 0;
            this.BTNSalir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.BTNSalir.ForeColor = System.Drawing.Color.Black;
            this.BTNSalir.Location = new System.Drawing.Point(402, 153);
            this.BTNSalir.Margin = new System.Windows.Forms.Padding(4);
            this.BTNSalir.Name = "BTNSalir";
            this.BTNSalir.Size = new System.Drawing.Size(98, 32);
            this.BTNSalir.TabIndex = 82;
            this.BTNSalir.Text = "Salir";
            this.BTNSalir.UseVisualStyleBackColor = false;
            this.BTNSalir.Click += new System.EventHandler(this.BTNSalir_Click);
            // 
            // LBLSubTitulo
            // 
            this.LBLSubTitulo.AutoSize = true;
            // 
            // 
            // 
            this.LBLSubTitulo.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.LBLSubTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLSubTitulo.FontBold = true;
            this.LBLSubTitulo.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.LBLSubTitulo.Location = new System.Drawing.Point(71, 153);
            this.LBLSubTitulo.Margin = new System.Windows.Forms.Padding(4);
            this.LBLSubTitulo.Name = "LBLSubTitulo";
            this.LBLSubTitulo.Size = new System.Drawing.Size(141, 27);
            this.LBLSubTitulo.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2000;
            this.LBLSubTitulo.TabIndex = 81;
            this.LBLSubTitulo.Text = "Cantidad (Bs.):";
            this.LBLSubTitulo.TextAlignment = System.Drawing.StringAlignment.Center;
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
            this.LBLTitulo.Location = new System.Drawing.Point(219, 33);
            this.LBLTitulo.Margin = new System.Windows.Forms.Padding(4);
            this.LBLTitulo.Name = "LBLTitulo";
            this.LBLTitulo.Size = new System.Drawing.Size(553, 50);
            this.LBLTitulo.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2000;
            this.LBLTitulo.TabIndex = 80;
            this.LBLTitulo.Text = "Historial Anual de Inversiones";
            this.LBLTitulo.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // CHTCompra_HistorialGrafico
            // 
            this.CHTCompra_HistorialGrafico.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CHTCompra_HistorialGrafico.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.TopBottom;
            this.CHTCompra_HistorialGrafico.BorderlineColor = System.Drawing.Color.Gainsboro;
            this.CHTCompra_HistorialGrafico.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            this.CHTCompra_HistorialGrafico.BorderlineWidth = 0;
            chartArea1.AxisX.Interval = 1D;
            chartArea1.AxisX.IsMarginVisible = false;
            chartArea1.AxisX.LabelStyle.ForeColor = System.Drawing.Color.Gray;
            chartArea1.AxisX.LabelStyle.Interval = 1D;
            chartArea1.AxisX.LineColor = System.Drawing.Color.Gainsboro;
            chartArea1.AxisX.MajorGrid.Enabled = false;
            chartArea1.AxisX.MajorTickMark.Enabled = false;
            chartArea1.AxisX.Title = "Meses";
            chartArea1.AxisX.TitleAlignment = System.Drawing.StringAlignment.Far;
            chartArea1.AxisX.TitleForeColor = System.Drawing.Color.Gray;
            chartArea1.AxisY.LabelStyle.ForeColor = System.Drawing.Color.Gray;
            chartArea1.AxisY.LabelStyle.Format = "N0";
            chartArea1.AxisY.MajorGrid.LineColor = System.Drawing.Color.Gainsboro;
            chartArea1.AxisY.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot;
            chartArea1.AxisY.MajorTickMark.Enabled = false;
            chartArea1.Name = "ChartArea1";
            this.CHTCompra_HistorialGrafico.ChartAreas.Add(chartArea1);
            this.CHTCompra_HistorialGrafico.Location = new System.Drawing.Point(71, 193);
            this.CHTCompra_HistorialGrafico.Margin = new System.Windows.Forms.Padding(4);
            this.CHTCompra_HistorialGrafico.Name = "CHTCompra_HistorialGrafico";
            this.CHTCompra_HistorialGrafico.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Grayscale;
            this.CHTCompra_HistorialGrafico.PaletteCustomColors = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64))))),
        System.Drawing.Color.Gray,
        System.Drawing.Color.Silver,
        System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224))))),
        System.Drawing.Color.White};
            series1.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.TopBottom;
            series1.BackSecondaryColor = System.Drawing.Color.White;
            series1.BorderColor = System.Drawing.Color.Transparent;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.SplineArea;
            series1.Color = System.Drawing.Color.DarkGray;
            series1.IsVisibleInLegend = false;
            series1.Name = "Area";
            series2.BorderWidth = 3;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series2.Color = System.Drawing.Color.Black;
            series2.IsVisibleInLegend = false;
            series2.Name = "Linea";
            this.CHTCompra_HistorialGrafico.Series.Add(series1);
            this.CHTCompra_HistorialGrafico.Series.Add(series2);
            this.CHTCompra_HistorialGrafico.Size = new System.Drawing.Size(867, 344);
            this.CHTCompra_HistorialGrafico.TabIndex = 0;
            this.CHTCompra_HistorialGrafico.Text = "Historial Anual";
            this.CHTCompra_HistorialGrafico.Click += new System.EventHandler(this.CHTCompra_HistorialGrafico_Click);
            // 
            // FRMCompra_Historial_Grafico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 552);
            this.Controls.Add(this.PPrincipal);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FRMCompra_Historial_Grafico";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FRMCompra_Historial_Grafico";
            this.Load += new System.EventHandler(this.FRMCompra_Historial_Grafico_Load);
            this.PPrincipal.ResumeLayout(false);
            this.PCompra_HistorialGrafico.ResumeLayout(false);
            this.PCompra_HistorialGrafico.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUDAnio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CHTCompra_HistorialGrafico)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PPrincipal;
        private System.Windows.Forms.Panel PCompra_HistorialGrafico;
        private System.Windows.Forms.DataVisualization.Charting.Chart CHTCompra_HistorialGrafico;
        private DevComponents.DotNetBar.LabelX LBLTitulo;
        private DevComponents.DotNetBar.LabelX LBLSubTitulo;
        private System.Windows.Forms.Button BTNSalir;
        private System.Windows.Forms.Button BTNConsultar;
        private System.Windows.Forms.NumericUpDown NUDAnio;
    }
}