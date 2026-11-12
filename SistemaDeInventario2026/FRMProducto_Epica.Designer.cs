namespace SistemaDeInventario2026
{
    partial class FRMProducto_Epica
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
            this.PMenu_Producto = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.PCBAlertasStock = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.PCBLista_Producto = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.PCBAgregar_Producto = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.LBLGestionInventario = new DevComponents.DotNetBar.LabelX();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.PPrincipal.SuspendLayout();
            this.PMenu_Producto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PCBAlertasStock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PCBLista_Producto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PCBAgregar_Producto)).BeginInit();
            this.SuspendLayout();
            // 
            // PPrincipal
            // 
            this.PPrincipal.BackColor = System.Drawing.Color.White;
            this.PPrincipal.Controls.Add(this.PMenu_Producto);
            this.PPrincipal.Cursor = System.Windows.Forms.Cursors.Default;
            this.PPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PPrincipal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PPrincipal.Location = new System.Drawing.Point(0, 0);
            this.PPrincipal.Name = "PPrincipal";
            this.PPrincipal.Size = new System.Drawing.Size(970, 519);
            this.PPrincipal.TabIndex = 6;
            // 
            // PMenu_Producto
            // 
            this.PMenu_Producto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PMenu_Producto.Controls.Add(this.label6);
            this.PMenu_Producto.Controls.Add(this.label4);
            this.PMenu_Producto.Controls.Add(this.PCBAlertasStock);
            this.PMenu_Producto.Controls.Add(this.label5);
            this.PMenu_Producto.Controls.Add(this.label3);
            this.PMenu_Producto.Controls.Add(this.PCBLista_Producto);
            this.PMenu_Producto.Controls.Add(this.label2);
            this.PMenu_Producto.Controls.Add(this.PCBAgregar_Producto);
            this.PMenu_Producto.Controls.Add(this.label1);
            this.PMenu_Producto.Controls.Add(this.LBLGestionInventario);
            this.PMenu_Producto.Controls.Add(this.materialLabel3);
            this.PMenu_Producto.Location = new System.Drawing.Point(0, 0);
            this.PMenu_Producto.Name = "PMenu_Producto";
            this.PMenu_Producto.Size = new System.Drawing.Size(970, 519);
            this.PMenu_Producto.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(594, 327);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(228, 17);
            this.label6.TabIndex = 59;
            this.label6.Text = "Configurar alertas de Stock Mínimo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(594, 218);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(174, 17);
            this.label4.TabIndex = 58;
            this.label4.Text = "Ver productos con imagen";
            // 
            // PCBAlertasStock
            // 
            this.PCBAlertasStock.Image = global::SistemaDeInventario2026.Properties.Resources.campana_alerta_fondo_gris_PhotoShop;
            this.PCBAlertasStock.Location = new System.Drawing.Point(534, 298);
            this.PCBAlertasStock.Name = "PCBAlertasStock";
            this.PCBAlertasStock.Size = new System.Drawing.Size(52, 52);
            this.PCBAlertasStock.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PCBAlertasStock.TabIndex = 57;
            this.PCBAlertasStock.TabStop = false;
            this.PCBAlertasStock.Click += new System.EventHandler(this.PCBAlertasStock_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(594, 112);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(247, 17);
            this.label5.TabIndex = 54;
            this.label5.Text = "Registrar entradas por talla/color, etc.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Cursor = System.Windows.Forms.Cursors.Default;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label3.Location = new System.Drawing.Point(592, 302);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 25);
            this.label3.TabIndex = 51;
            this.label3.Text = "Alertas Críticas";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // PCBLista_Producto
            // 
            this.PCBLista_Producto.Image = global::SistemaDeInventario2026.Properties.Resources.catalogo_visual_100;
            this.PCBLista_Producto.Location = new System.Drawing.Point(534, 190);
            this.PCBLista_Producto.Name = "PCBLista_Producto";
            this.PCBLista_Producto.Size = new System.Drawing.Size(52, 52);
            this.PCBLista_Producto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PCBLista_Producto.TabIndex = 50;
            this.PCBLista_Producto.TabStop = false;
            this.PCBLista_Producto.Click += new System.EventHandler(this.PCBLista_Producto_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Cursor = System.Windows.Forms.Cursors.Default;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label2.Location = new System.Drawing.Point(592, 193);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 25);
            this.label2.TabIndex = 49;
            this.label2.Text = "Catálogo Visual";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // PCBAgregar_Producto
            // 
            this.PCBAgregar_Producto.Image = global::SistemaDeInventario2026.Properties.Resources.agregar_fondo_gris_PhotoShop_2;
            this.PCBAgregar_Producto.Location = new System.Drawing.Point(536, 88);
            this.PCBAgregar_Producto.Name = "PCBAgregar_Producto";
            this.PCBAgregar_Producto.Size = new System.Drawing.Size(52, 52);
            this.PCBAgregar_Producto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PCBAgregar_Producto.TabIndex = 48;
            this.PCBAgregar_Producto.TabStop = false;
            this.PCBAgregar_Producto.Click += new System.EventHandler(this.PCBAgregar_Producto_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Default;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Location = new System.Drawing.Point(592, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 25);
            this.label1.TabIndex = 47;
            this.label1.Text = "Agregar Productos";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // LBLGestionInventario
            // 
            this.LBLGestionInventario.AutoSize = true;
            // 
            // 
            // 
            this.LBLGestionInventario.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.LBLGestionInventario.Cursor = System.Windows.Forms.Cursors.Default;
            this.LBLGestionInventario.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLGestionInventario.FontBold = true;
            this.LBLGestionInventario.ForeColor = System.Drawing.SystemColors.ControlText;
            this.LBLGestionInventario.Location = new System.Drawing.Point(50, 190);
            this.LBLGestionInventario.Name = "LBLGestionInventario";
            this.LBLGestionInventario.Size = new System.Drawing.Size(397, 50);
            this.LBLGestionInventario.TabIndex = 43;
            this.LBLGestionInventario.Text = "Gestión de Inventario";
            this.LBLGestionInventario.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Cursor = System.Windows.Forms.Cursors.Default;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel3.Location = new System.Drawing.Point(57, 243);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(285, 19);
            this.materialLabel3.TabIndex = 42;
            this.materialLabel3.Text = "Acciones para la gestión de proveedores";
            // 
            // FRMProducto_Epica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(970, 519);
            this.Controls.Add(this.PPrincipal);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FRMProducto_Epica";
            this.Text = "FRMProducto_Epica";
            this.Load += new System.EventHandler(this.FRMProducto_Epica_Load);
            this.PPrincipal.ResumeLayout(false);
            this.PMenu_Producto.ResumeLayout(false);
            this.PMenu_Producto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PCBAlertasStock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PCBLista_Producto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PCBAgregar_Producto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel PPrincipal;
        private System.Windows.Forms.Panel PMenu_Producto;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox PCBLista_Producto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox PCBAgregar_Producto;
        private System.Windows.Forms.Label label1;
        private DevComponents.DotNetBar.LabelX LBLGestionInventario;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private System.Windows.Forms.PictureBox PCBAlertasStock;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
    }
}