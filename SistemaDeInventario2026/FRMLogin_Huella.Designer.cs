namespace SistemaDeInventario2026
{
    partial class FRMLogin_Huella
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
            this.PSesion_Huella = new System.Windows.Forms.Panel();
            this.PVCHuella = new DPFP.Gui.Verification.VerificationControl();
            this.LBLMensaje = new System.Windows.Forms.PictureBox();
            this.LBLGestionProveedor = new DevComponents.DotNetBar.LabelX();
            this.PPrincipal.SuspendLayout();
            this.PSesion_Huella.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LBLMensaje)).BeginInit();
            this.SuspendLayout();
            // 
            // PPrincipal
            // 
            this.PPrincipal.BackColor = System.Drawing.Color.White;
            this.PPrincipal.Controls.Add(this.PSesion_Huella);
            this.PPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PPrincipal.Location = new System.Drawing.Point(0, 0);
            this.PPrincipal.Name = "PPrincipal";
            this.PPrincipal.Size = new System.Drawing.Size(970, 519);
            this.PPrincipal.TabIndex = 0;
            // 
            // PSesion_Huella
            // 
            this.PSesion_Huella.Controls.Add(this.PVCHuella);
            this.PSesion_Huella.Controls.Add(this.LBLMensaje);
            this.PSesion_Huella.Controls.Add(this.LBLGestionProveedor);
            this.PSesion_Huella.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PSesion_Huella.Location = new System.Drawing.Point(0, 0);
            this.PSesion_Huella.Name = "PSesion_Huella";
            this.PSesion_Huella.Size = new System.Drawing.Size(970, 519);
            this.PSesion_Huella.TabIndex = 0;
            // 
            // PVCHuella
            // 
            this.PVCHuella.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.PVCHuella.Location = new System.Drawing.Point(652, 199);
            this.PVCHuella.Margin = new System.Windows.Forms.Padding(5);
            this.PVCHuella.Name = "PVCHuella";
            this.PVCHuella.ReaderSerialNumber = "00000000-0000-0000-0000-000000000000";
            this.PVCHuella.Size = new System.Drawing.Size(48, 47);
            this.PVCHuella.TabIndex = 41;
            this.PVCHuella.OnComplete += new DPFP.Gui.Verification.VerificationControl._OnComplete(this.PVCHuella_OnComplete);
            // 
            // LBLMensaje
            // 
            this.LBLMensaje.Location = new System.Drawing.Point(776, 175);
            this.LBLMensaje.Margin = new System.Windows.Forms.Padding(4);
            this.LBLMensaje.Name = "LBLMensaje";
            this.LBLMensaje.Size = new System.Drawing.Size(100, 100);
            this.LBLMensaje.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.LBLMensaje.TabIndex = 40;
            this.LBLMensaje.TabStop = false;
            // 
            // LBLGestionProveedor
            // 
            this.LBLGestionProveedor.AutoSize = true;
            // 
            // 
            // 
            this.LBLGestionProveedor.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.LBLGestionProveedor.Cursor = System.Windows.Forms.Cursors.Default;
            this.LBLGestionProveedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLGestionProveedor.FontBold = true;
            this.LBLGestionProveedor.ForeColor = System.Drawing.SystemColors.ControlText;
            this.LBLGestionProveedor.Location = new System.Drawing.Point(43, 199);
            this.LBLGestionProveedor.Name = "LBLGestionProveedor";
            this.LBLGestionProveedor.Size = new System.Drawing.Size(502, 35);
            this.LBLGestionProveedor.TabIndex = 39;
            this.LBLGestionProveedor.Text = "Coloque su huella en el lector biométrico";
            this.LBLGestionProveedor.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // FRMLogin_Huella
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(970, 519);
            this.Controls.Add(this.PPrincipal);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FRMLogin_Huella";
            this.Text = "FRMLogin_Huella";
            this.PPrincipal.ResumeLayout(false);
            this.PSesion_Huella.ResumeLayout(false);
            this.PSesion_Huella.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LBLMensaje)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PPrincipal;
        private System.Windows.Forms.Panel PSesion_Huella;
        private DevComponents.DotNetBar.LabelX LBLGestionProveedor;
        private System.Windows.Forms.PictureBox LBLMensaje;
        private DPFP.Gui.Verification.VerificationControl PVCHuella;
    }
}