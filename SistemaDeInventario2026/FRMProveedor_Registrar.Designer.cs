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
            this.panel1 = new System.Windows.Forms.Panel();
            this.MTLProveedor = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.materialLabel1);
            this.panel1.Controls.Add(this.MTLProveedor);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(3, 64);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1063, 487);
            this.panel1.TabIndex = 0;
            this.panel1.UseWaitCursor = true;
            // 
            // MTLProveedor
            // 
            this.MTLProveedor.AutoSize = true;
            this.MTLProveedor.Depth = 0;
            this.MTLProveedor.Font = new System.Drawing.Font("Raleway ExtraBold", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Pixel);
            this.MTLProveedor.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
            this.MTLProveedor.ForeColor = System.Drawing.SystemColors.ControlText;
            this.MTLProveedor.Location = new System.Drawing.Point(107, 172);
            this.MTLProveedor.MouseState = MaterialSkin.MouseState.HOVER;
            this.MTLProveedor.Name = "MTLProveedor";
            this.MTLProveedor.Size = new System.Drawing.Size(202, 29);
            this.MTLProveedor.TabIndex = 0;
            this.MTLProveedor.Text = "Agregar Proveedor";
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.FontType = MaterialSkin.MaterialSkinManager.fontType.Body2;
            this.materialLabel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.materialLabel1.Location = new System.Drawing.Point(109, 201);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(257, 17);
            this.materialLabel1.TabIndex = 1;
            this.materialLabel1.Text = "Introduzca los datos del nuevo proveedor";
            // 
            // FRMProveedor_Registrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FRMProveedor_Registrar";
            this.Text = "FRMProveedor_Registrar";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private MaterialSkin.Controls.MaterialLabel MTLProveedor;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
    }
}