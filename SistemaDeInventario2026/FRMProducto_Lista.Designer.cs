namespace SistemaDeInventario2026
{
    partial class FRMProducto_Lista
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.PNLConetenedorCatalogo = new System.Windows.Forms.Panel();
            this.BTNAnterior = new System.Windows.Forms.Button();
            this.LBLCatalogoVisual = new DevComponents.DotNetBar.LabelX();
            this.BTNSiguiente = new System.Windows.Forms.Button();
            this.FLPCatalogo = new System.Windows.Forms.FlowLayoutPanel();
            this.CMSMenu.SuspendLayout();
            this.panel3.SuspendLayout();
            this.PNLConetenedorCatalogo.SuspendLayout();
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
            // 
            // modificarToolStripMenuItem
            // 
            this.modificarToolStripMenuItem.Name = "modificarToolStripMenuItem";
            this.modificarToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.modificarToolStripMenuItem.Text = "&Modificar";
            // 
            // inhabilitarToolStripMenuItem
            // 
            this.inhabilitarToolStripMenuItem.Name = "inhabilitarToolStripMenuItem";
            this.inhabilitarToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.inhabilitarToolStripMenuItem.Text = "&Inhabilitar";
            // 
            // habilitarToolStripMenuItem
            // 
            this.habilitarToolStripMenuItem.Name = "habilitarToolStripMenuItem";
            this.habilitarToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.habilitarToolStripMenuItem.Text = "&Habilitar";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.PNLConetenedorCatalogo);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1067, 552);
            this.panel3.TabIndex = 80;
            // 
            // PNLConetenedorCatalogo
            // 
            this.PNLConetenedorCatalogo.BackColor = System.Drawing.Color.White;
            this.PNLConetenedorCatalogo.Controls.Add(this.BTNAnterior);
            this.PNLConetenedorCatalogo.Controls.Add(this.LBLCatalogoVisual);
            this.PNLConetenedorCatalogo.Controls.Add(this.BTNSiguiente);
            this.PNLConetenedorCatalogo.Controls.Add(this.FLPCatalogo);
            this.PNLConetenedorCatalogo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PNLConetenedorCatalogo.Location = new System.Drawing.Point(0, 0);
            this.PNLConetenedorCatalogo.Name = "PNLConetenedorCatalogo";
            this.PNLConetenedorCatalogo.Size = new System.Drawing.Size(1067, 552);
            this.PNLConetenedorCatalogo.TabIndex = 79;
            // 
            // BTNAnterior
            // 
            this.BTNAnterior.Location = new System.Drawing.Point(150, 269);
            this.BTNAnterior.Name = "BTNAnterior";
            this.BTNAnterior.Size = new System.Drawing.Size(46, 33);
            this.BTNAnterior.TabIndex = 80;
            this.BTNAnterior.Text = "Izq";
            this.BTNAnterior.UseVisualStyleBackColor = true;
            // 
            // LBLCatalogoVisual
            // 
            this.LBLCatalogoVisual.AutoSize = true;
            // 
            // 
            // 
            this.LBLCatalogoVisual.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.LBLCatalogoVisual.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLCatalogoVisual.FontBold = true;
            this.LBLCatalogoVisual.Location = new System.Drawing.Point(383, 52);
            this.LBLCatalogoVisual.Name = "LBLCatalogoVisual";
            this.LBLCatalogoVisual.Size = new System.Drawing.Size(294, 50);
            this.LBLCatalogoVisual.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2000;
            this.LBLCatalogoVisual.TabIndex = 78;
            this.LBLCatalogoVisual.Text = "Catálogo Visual";
            this.LBLCatalogoVisual.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // BTNSiguiente
            // 
            this.BTNSiguiente.Location = new System.Drawing.Point(890, 269);
            this.BTNSiguiente.Name = "BTNSiguiente";
            this.BTNSiguiente.Size = new System.Drawing.Size(43, 33);
            this.BTNSiguiente.TabIndex = 81;
            this.BTNSiguiente.Text = "Der";
            this.BTNSiguiente.UseVisualStyleBackColor = true;
            // 
            // FLPCatalogo
            // 
            this.FLPCatalogo.AutoScroll = true;
            this.FLPCatalogo.BackColor = System.Drawing.Color.White;
            this.FLPCatalogo.Location = new System.Drawing.Point(202, 106);
            this.FLPCatalogo.Name = "FLPCatalogo";
            this.FLPCatalogo.Size = new System.Drawing.Size(682, 361);
            this.FLPCatalogo.TabIndex = 79;
            this.FLPCatalogo.WrapContents = false;
            // 
            // FRMProducto_Lista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 552);
            this.Controls.Add(this.panel3);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FRMProducto_Lista";
            this.Text = "FRMPorducto_Lista";
            this.Load += new System.EventHandler(this.FRMProducto_Lista_Load);
            this.CMSMenu.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.PNLConetenedorCatalogo.ResumeLayout(false);
            this.PNLConetenedorCatalogo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip CMSMenu;
        private System.Windows.Forms.ToolStripMenuItem modificarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inhabilitarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem habilitarToolStripMenuItem;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel PNLConetenedorCatalogo;
        private System.Windows.Forms.Button BTNAnterior;
        private DevComponents.DotNetBar.LabelX LBLCatalogoVisual;
        private System.Windows.Forms.Button BTNSiguiente;
        private System.Windows.Forms.FlowLayoutPanel FLPCatalogo;
    }
}