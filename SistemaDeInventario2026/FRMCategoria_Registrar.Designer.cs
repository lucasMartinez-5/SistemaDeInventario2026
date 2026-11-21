namespace SistemaDeInventario2026
{
    partial class FRMCategoria_Registrar
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
            this.BLTAyuda = new DevComponents.DotNetBar.BalloonTip();
            this.PPrincipal = new System.Windows.Forms.Panel();
            this.PAgregar_Categoria = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.BTNGrabar = new System.Windows.Forms.Button();
            this.LBLRegistrarCategoria = new DevComponents.DotNetBar.LabelX();
            this.materialLabel9 = new MaterialSkin.Controls.MaterialLabel();
            this.TXTCategoriaProductoNombre = new System.Windows.Forms.TextBox();
            this.SWBCategoriaProductoEstadoStock = new DevComponents.DotNetBar.Controls.SwitchButton();
            this.PPrincipal.SuspendLayout();
            this.PAgregar_Categoria.SuspendLayout();
            this.SuspendLayout();
            // 
            // PPrincipal
            // 
            this.PPrincipal.BackColor = System.Drawing.Color.White;
            this.PPrincipal.Controls.Add(this.PAgregar_Categoria);
            this.PPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PPrincipal.Location = new System.Drawing.Point(0, 0);
            this.PPrincipal.Name = "PPrincipal";
            this.PPrincipal.Size = new System.Drawing.Size(657, 419);
            this.PPrincipal.TabIndex = 0;
            // 
            // PAgregar_Categoria
            // 
            this.PAgregar_Categoria.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PAgregar_Categoria.Controls.Add(this.button1);
            this.PAgregar_Categoria.Controls.Add(this.button2);
            this.PAgregar_Categoria.Controls.Add(this.BTNGrabar);
            this.PAgregar_Categoria.Controls.Add(this.LBLRegistrarCategoria);
            this.PAgregar_Categoria.Controls.Add(this.materialLabel9);
            this.PAgregar_Categoria.Controls.Add(this.TXTCategoriaProductoNombre);
            this.PAgregar_Categoria.Controls.Add(this.SWBCategoriaProductoEstadoStock);
            this.PAgregar_Categoria.Location = new System.Drawing.Point(0, 0);
            this.PAgregar_Categoria.Name = "PAgregar_Categoria";
            this.PAgregar_Categoria.Size = new System.Drawing.Size(657, 419);
            this.PAgregar_Categoria.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(409, 285);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(142, 38);
            this.button1.TabIndex = 108;
            this.button1.Text = "Limpiar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.BTNLimpiar_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Location = new System.Drawing.Point(106, 285);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(146, 38);
            this.button2.TabIndex = 107;
            this.button2.Text = "Salir";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.BTNSalir_Click);
            // 
            // BTNGrabar
            // 
            this.BTNGrabar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.BTNGrabar.BackColor = System.Drawing.Color.Black;
            this.BTNGrabar.FlatAppearance.BorderSize = 0;
            this.BTNGrabar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.BTNGrabar.ForeColor = System.Drawing.Color.White;
            this.BTNGrabar.Location = new System.Drawing.Point(254, 285);
            this.BTNGrabar.Name = "BTNGrabar";
            this.BTNGrabar.Size = new System.Drawing.Size(152, 38);
            this.BTNGrabar.TabIndex = 106;
            this.BTNGrabar.Text = "Grabar";
            this.BTNGrabar.UseVisualStyleBackColor = false;
            this.BTNGrabar.Click += new System.EventHandler(this.BTNGrabar_Click);
            // 
            // LBLRegistrarCategoria
            // 
            this.LBLRegistrarCategoria.AutoSize = true;
            // 
            // 
            // 
            this.LBLRegistrarCategoria.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.LBLRegistrarCategoria.Cursor = System.Windows.Forms.Cursors.Default;
            this.LBLRegistrarCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLRegistrarCategoria.FontBold = true;
            this.LBLRegistrarCategoria.ForeColor = System.Drawing.Color.Black;
            this.LBLRegistrarCategoria.Location = new System.Drawing.Point(216, 68);
            this.LBLRegistrarCategoria.Name = "LBLRegistrarCategoria";
            this.LBLRegistrarCategoria.Size = new System.Drawing.Size(229, 35);
            this.LBLRegistrarCategoria.TabIndex = 105;
            this.LBLRegistrarCategoria.Text = "Agregar Categoria";
            this.LBLRegistrarCategoria.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // materialLabel9
            // 
            this.materialLabel9.AutoSize = true;
            this.materialLabel9.Depth = 0;
            this.materialLabel9.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel9.Location = new System.Drawing.Point(153, 189);
            this.materialLabel9.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel9.Name = "materialLabel9";
            this.materialLabel9.Size = new System.Drawing.Size(150, 19);
            this.materialLabel9.TabIndex = 104;
            this.materialLabel9.Text = "Nombre de Categoría";
            // 
            // TXTCategoriaProductoNombre
            // 
            this.TXTCategoriaProductoNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TXTCategoriaProductoNombre.Location = new System.Drawing.Point(153, 211);
            this.TXTCategoriaProductoNombre.Name = "TXTCategoriaProductoNombre";
            this.TXTCategoriaProductoNombre.Size = new System.Drawing.Size(352, 23);
            this.TXTCategoriaProductoNombre.TabIndex = 103;
            // 
            // SWBCategoriaProductoEstadoStock
            // 
            // 
            // 
            // 
            this.SWBCategoriaProductoEstadoStock.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.SWBCategoriaProductoEstadoStock.Location = new System.Drawing.Point(153, 154);
            this.SWBCategoriaProductoEstadoStock.Name = "SWBCategoriaProductoEstadoStock";
            this.SWBCategoriaProductoEstadoStock.OffBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.SWBCategoriaProductoEstadoStock.OffText = "INHABILITADO";
            this.SWBCategoriaProductoEstadoStock.OffTextColor = System.Drawing.Color.White;
            this.SWBCategoriaProductoEstadoStock.OnBackColor = System.Drawing.Color.LimeGreen;
            this.SWBCategoriaProductoEstadoStock.OnText = "HABILITADO";
            this.SWBCategoriaProductoEstadoStock.OnTextColor = System.Drawing.Color.White;
            this.SWBCategoriaProductoEstadoStock.Size = new System.Drawing.Size(351, 23);
            this.SWBCategoriaProductoEstadoStock.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.SWBCategoriaProductoEstadoStock.TabIndex = 22;
            this.SWBCategoriaProductoEstadoStock.Value = true;
            this.SWBCategoriaProductoEstadoStock.ValueObject = "Y";
            // 
            // FRMCategoria_Registrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(657, 419);
            this.Controls.Add(this.PPrincipal);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FRMCategoria_Registrar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FRMCategoria_Registrar";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FRMCategoria_Registrar_FormClosing);
            this.Load += new System.EventHandler(this.FRMCategoria_Registrar_Load);
            this.PPrincipal.ResumeLayout(false);
            this.PAgregar_Categoria.ResumeLayout(false);
            this.PAgregar_Categoria.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private DevComponents.DotNetBar.BalloonTip BLTAyuda;
        private System.Windows.Forms.Panel PPrincipal;
        private System.Windows.Forms.Panel PAgregar_Categoria;
        private DevComponents.DotNetBar.Controls.SwitchButton SWBCategoriaProductoEstadoStock;
        private System.Windows.Forms.TextBox TXTCategoriaProductoNombre;
        private MaterialSkin.Controls.MaterialLabel materialLabel9;
        private DevComponents.DotNetBar.LabelX LBLRegistrarCategoria;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button BTNGrabar;
    }
}