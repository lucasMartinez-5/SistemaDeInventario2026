namespace SistemaDeInventario2026
{
    partial class UCLProductoCard
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCLProductoCard));
            this.LBLStock = new System.Windows.Forms.Label();
            this.LBLPrecio = new System.Windows.Forms.Label();
            this.LBLTallaColor = new System.Windows.Forms.Label();
            this.LBLNombre = new System.Windows.Forms.Label();
            this.BTNVerUCLProducto = new System.Windows.Forms.Button();
            this.BTNModificarUCLProducto = new System.Windows.Forms.Button();
            this.PCBImagen = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PCBImagen)).BeginInit();
            this.SuspendLayout();
            // 
            // LBLStock
            // 
            this.LBLStock.AutoSize = true;
            this.LBLStock.Location = new System.Drawing.Point(3, 235);
            this.LBLStock.Name = "LBLStock";
            this.LBLStock.Size = new System.Drawing.Size(35, 13);
            this.LBLStock.TabIndex = 82;
            this.LBLStock.Text = "label5";
            // 
            // LBLPrecio
            // 
            this.LBLPrecio.AutoSize = true;
            this.LBLPrecio.Location = new System.Drawing.Point(3, 220);
            this.LBLPrecio.Name = "LBLPrecio";
            this.LBLPrecio.Size = new System.Drawing.Size(35, 13);
            this.LBLPrecio.TabIndex = 81;
            this.LBLPrecio.Text = "label3";
            // 
            // LBLTallaColor
            // 
            this.LBLTallaColor.AutoSize = true;
            this.LBLTallaColor.Location = new System.Drawing.Point(3, 204);
            this.LBLTallaColor.Name = "LBLTallaColor";
            this.LBLTallaColor.Size = new System.Drawing.Size(35, 13);
            this.LBLTallaColor.TabIndex = 80;
            this.LBLTallaColor.Text = "label2";
            // 
            // LBLNombre
            // 
            this.LBLNombre.AutoSize = true;
            this.LBLNombre.Location = new System.Drawing.Point(3, 188);
            this.LBLNombre.Name = "LBLNombre";
            this.LBLNombre.Size = new System.Drawing.Size(35, 13);
            this.LBLNombre.TabIndex = 79;
            this.LBLNombre.Text = "label1";
            // 
            // BTNVerUCLProducto
            // 
            this.BTNVerUCLProducto.Image = global::SistemaDeInventario2026.Properties.Resources.ic_ojo_30;
            this.BTNVerUCLProducto.Location = new System.Drawing.Point(142, 5);
            this.BTNVerUCLProducto.Name = "BTNVerUCLProducto";
            this.BTNVerUCLProducto.Size = new System.Drawing.Size(30, 30);
            this.BTNVerUCLProducto.TabIndex = 85;
            this.BTNVerUCLProducto.UseVisualStyleBackColor = true;
            // 
            // BTNModificarUCLProducto
            // 
            this.BTNModificarUCLProducto.Image = global::SistemaDeInventario2026.Properties.Resources.lapiz_sin_fondo_30;
            this.BTNModificarUCLProducto.Location = new System.Drawing.Point(6, 6);
            this.BTNModificarUCLProducto.Name = "BTNModificarUCLProducto";
            this.BTNModificarUCLProducto.Size = new System.Drawing.Size(30, 30);
            this.BTNModificarUCLProducto.TabIndex = 84;
            this.BTNModificarUCLProducto.UseVisualStyleBackColor = true;
            this.BTNModificarUCLProducto.Click += new System.EventHandler(this.BTNModificarUCLProducto_Click);
            // 
            // PCBImagen
            // 
            this.PCBImagen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PCBImagen.Image = ((System.Drawing.Image)(resources.GetObject("PCBImagen.Image")));
            this.PCBImagen.Location = new System.Drawing.Point(4, 4);
            this.PCBImagen.Name = "PCBImagen";
            this.PCBImagen.Size = new System.Drawing.Size(170, 170);
            this.PCBImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PCBImagen.TabIndex = 78;
            this.PCBImagen.TabStop = false;
            // 
            // UCLProductoCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.BTNVerUCLProducto);
            this.Controls.Add(this.BTNModificarUCLProducto);
            this.Controls.Add(this.LBLStock);
            this.Controls.Add(this.LBLPrecio);
            this.Controls.Add(this.LBLTallaColor);
            this.Controls.Add(this.LBLNombre);
            this.Controls.Add(this.PCBImagen);
            this.MaximumSize = new System.Drawing.Size(178, 287);
            this.MinimumSize = new System.Drawing.Size(178, 287);
            this.Name = "UCLProductoCard";
            this.Size = new System.Drawing.Size(178, 287);
            this.Load += new System.EventHandler(this.UCLProductoCard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PCBImagen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LBLStock;
        private System.Windows.Forms.Label LBLPrecio;
        private System.Windows.Forms.Label LBLTallaColor;
        private System.Windows.Forms.Label LBLNombre;
        private System.Windows.Forms.PictureBox PCBImagen;
        private System.Windows.Forms.Button BTNModificarUCLProducto;
        private System.Windows.Forms.Button BTNVerUCLProducto;
    }
}
