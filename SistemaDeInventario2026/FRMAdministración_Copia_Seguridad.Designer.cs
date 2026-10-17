namespace SistemaDeInventario2026
{
    partial class FRMAdministración_Copia_Seguridad
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
            this.PCopia_Seguridad = new System.Windows.Forms.Panel();
            this.BTNSalir = new System.Windows.Forms.Button();
            this.BTNCopiaSeguridad = new System.Windows.Forms.Button();
            this.LBLDirectorioProveedor = new DevComponents.DotNetBar.LabelX();
            this.PPrincipal.SuspendLayout();
            this.PCopia_Seguridad.SuspendLayout();
            this.SuspendLayout();
            // 
            // PPrincipal
            // 
            this.PPrincipal.BackColor = System.Drawing.Color.White;
            this.PPrincipal.Controls.Add(this.PCopia_Seguridad);
            this.PPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PPrincipal.Location = new System.Drawing.Point(0, 0);
            this.PPrincipal.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.PPrincipal.Name = "PPrincipal";
            this.PPrincipal.Size = new System.Drawing.Size(970, 519);
            this.PPrincipal.TabIndex = 0;
            // 
            // PCopia_Seguridad
            // 
            this.PCopia_Seguridad.Controls.Add(this.LBLDirectorioProveedor);
            this.PCopia_Seguridad.Controls.Add(this.BTNSalir);
            this.PCopia_Seguridad.Controls.Add(this.BTNCopiaSeguridad);
            this.PCopia_Seguridad.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PCopia_Seguridad.Location = new System.Drawing.Point(0, 0);
            this.PCopia_Seguridad.Name = "PCopia_Seguridad";
            this.PCopia_Seguridad.Size = new System.Drawing.Size(970, 519);
            this.PCopia_Seguridad.TabIndex = 0;
            // 
            // BTNSalir
            // 
            this.BTNSalir.BackColor = System.Drawing.Color.White;
            this.BTNSalir.FlatAppearance.BorderSize = 0;
            this.BTNSalir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.BTNSalir.ForeColor = System.Drawing.Color.Black;
            this.BTNSalir.Location = new System.Drawing.Point(207, 286);
            this.BTNSalir.Name = "BTNSalir";
            this.BTNSalir.Size = new System.Drawing.Size(252, 38);
            this.BTNSalir.TabIndex = 45;
            this.BTNSalir.Text = "Estado de la Copia de Seguridad";
            this.BTNSalir.UseVisualStyleBackColor = false;
            // 
            // BTNCopiaSeguridad
            // 
            this.BTNCopiaSeguridad.BackColor = System.Drawing.Color.Black;
            this.BTNCopiaSeguridad.FlatAppearance.BorderSize = 0;
            this.BTNCopiaSeguridad.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.BTNCopiaSeguridad.ForeColor = System.Drawing.Color.White;
            this.BTNCopiaSeguridad.Location = new System.Drawing.Point(493, 286);
            this.BTNCopiaSeguridad.Name = "BTNCopiaSeguridad";
            this.BTNCopiaSeguridad.Size = new System.Drawing.Size(252, 38);
            this.BTNCopiaSeguridad.TabIndex = 44;
            this.BTNCopiaSeguridad.Text = "Iniciar Copia de Seguridad";
            this.BTNCopiaSeguridad.UseVisualStyleBackColor = false;
            // 
            // LBLDirectorioProveedor
            // 
            this.LBLDirectorioProveedor.AutoSize = true;
            // 
            // 
            // 
            this.LBLDirectorioProveedor.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.LBLDirectorioProveedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLDirectorioProveedor.FontBold = true;
            this.LBLDirectorioProveedor.Location = new System.Drawing.Point(280, 124);
            this.LBLDirectorioProveedor.Name = "LBLDirectorioProveedor";
            this.LBLDirectorioProveedor.Size = new System.Drawing.Size(389, 50);
            this.LBLDirectorioProveedor.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2000;
            this.LBLDirectorioProveedor.TabIndex = 46;
            this.LBLDirectorioProveedor.Text = "Copias de Seguridad";
            this.LBLDirectorioProveedor.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // FRMAdministración_Copia_Seguridad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(970, 519);
            this.Controls.Add(this.PPrincipal);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FRMAdministración_Copia_Seguridad";
            this.Text = "v";
            this.PPrincipal.ResumeLayout(false);
            this.PCopia_Seguridad.ResumeLayout(false);
            this.PCopia_Seguridad.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PPrincipal;
        private System.Windows.Forms.Panel PCopia_Seguridad;
        private System.Windows.Forms.Button BTNSalir;
        private System.Windows.Forms.Button BTNCopiaSeguridad;
        private DevComponents.DotNetBar.LabelX LBLDirectorioProveedor;
    }
}