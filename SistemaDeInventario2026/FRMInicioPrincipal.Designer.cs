namespace SistemaDeInventario2026
{
    partial class FRMInicioPrincipal
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
            this.PMenu_Proveedor = new System.Windows.Forms.Panel();
            this.LBLGestionProveedor = new DevComponents.DotNetBar.LabelX();
            this.PPrincipal.SuspendLayout();
            this.PMenu_Proveedor.SuspendLayout();
            this.SuspendLayout();
            // 
            // PPrincipal
            // 
            this.PPrincipal.BackColor = System.Drawing.Color.White;
            this.PPrincipal.Controls.Add(this.PMenu_Proveedor);
            this.PPrincipal.Cursor = System.Windows.Forms.Cursors.Default;
            this.PPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PPrincipal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PPrincipal.Location = new System.Drawing.Point(0, 0);
            this.PPrincipal.Name = "PPrincipal";
            this.PPrincipal.Size = new System.Drawing.Size(970, 519);
            this.PPrincipal.TabIndex = 16;
            // 
            // PMenu_Proveedor
            // 
            this.PMenu_Proveedor.Controls.Add(this.LBLGestionProveedor);
            this.PMenu_Proveedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PMenu_Proveedor.Location = new System.Drawing.Point(0, 0);
            this.PMenu_Proveedor.Name = "PMenu_Proveedor";
            this.PMenu_Proveedor.Size = new System.Drawing.Size(970, 519);
            this.PMenu_Proveedor.TabIndex = 5;
            // 
            // LBLGestionProveedor
            // 
            this.LBLGestionProveedor.AutoSize = true;
            // 
            // 
            // 
            this.LBLGestionProveedor.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.LBLGestionProveedor.Cursor = System.Windows.Forms.Cursors.Default;
            this.LBLGestionProveedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLGestionProveedor.FontBold = true;
            this.LBLGestionProveedor.ForeColor = System.Drawing.SystemColors.ControlText;
            this.LBLGestionProveedor.Location = new System.Drawing.Point(201, 192);
            this.LBLGestionProveedor.Name = "LBLGestionProveedor";
            this.LBLGestionProveedor.Size = new System.Drawing.Size(547, 65);
            this.LBLGestionProveedor.TabIndex = 38;
            this.LBLGestionProveedor.Text = "Sistema De Inventario";
            this.LBLGestionProveedor.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // FRMInicioPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(970, 519);
            this.Controls.Add(this.PPrincipal);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FRMInicioPrincipal";
            this.Text = "FRMInicioPrincipal";
            this.Load += new System.EventHandler(this.FRMInicioPrincipal_Load);
            this.PPrincipal.ResumeLayout(false);
            this.PMenu_Proveedor.ResumeLayout(false);
            this.PMenu_Proveedor.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel PPrincipal;
        private System.Windows.Forms.Panel PMenu_Proveedor;
        private DevComponents.DotNetBar.LabelX LBLGestionProveedor;
    }
}