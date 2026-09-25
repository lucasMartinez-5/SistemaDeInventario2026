namespace SistemaDeInventario2026
{
    partial class FRMProveedor_Epica
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
            this.BTNVer = new System.Windows.Forms.Button();
            this.BTNRegistrar = new System.Windows.Forms.Button();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.LBLModificar = new DevComponents.DotNetBar.LabelX();
            this.panel2 = new System.Windows.Forms.Panel();
            this.BTNAdministracionUsuarios = new System.Windows.Forms.Button();
            this.BTNPuntoDeVenta = new System.Windows.Forms.Button();
            this.BTNBusquedaAvanzada = new System.Windows.Forms.Button();
            this.BTNInventario = new System.Windows.Forms.Button();
            this.BTNDirectorio = new System.Windows.Forms.Button();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.BTNModificar = new System.Windows.Forms.Button();
            this.BTNCostoRegistros = new System.Windows.Forms.Button();
            this.BTNResumenInversion = new System.Windows.Forms.Button();
            this.BTNHistorialAnual = new System.Windows.Forms.Button();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.PPrincipal.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // PPrincipal
            // 
            this.PPrincipal.BackColor = System.Drawing.Color.White;
            this.PPrincipal.Controls.Add(this.BTNResumenInversion);
            this.PPrincipal.Controls.Add(this.BTNHistorialAnual);
            this.PPrincipal.Controls.Add(this.materialLabel2);
            this.PPrincipal.Controls.Add(this.BTNCostoRegistros);
            this.PPrincipal.Controls.Add(this.BTNModificar);
            this.PPrincipal.Controls.Add(this.BTNVer);
            this.PPrincipal.Controls.Add(this.BTNRegistrar);
            this.PPrincipal.Controls.Add(this.materialLabel1);
            this.PPrincipal.Controls.Add(this.LBLModificar);
            this.PPrincipal.Controls.Add(this.panel2);
            this.PPrincipal.Controls.Add(this.materialLabel3);
            this.PPrincipal.Cursor = System.Windows.Forms.Cursors.Default;
            this.PPrincipal.Location = new System.Drawing.Point(0, 0);
            this.PPrincipal.Name = "PPrincipal";
            this.PPrincipal.Size = new System.Drawing.Size(1066, 554);
            this.PPrincipal.TabIndex = 1;
            // 
            // BTNVer
            // 
            this.BTNVer.BackColor = System.Drawing.Color.White;
            this.BTNVer.FlatAppearance.BorderSize = 0;
            this.BTNVer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.BTNVer.ForeColor = System.Drawing.Color.Black;
            this.BTNVer.Location = new System.Drawing.Point(398, 151);
            this.BTNVer.Name = "BTNVer";
            this.BTNVer.Size = new System.Drawing.Size(64, 38);
            this.BTNVer.TabIndex = 24;
            this.BTNVer.Text = "Ver";
            this.BTNVer.UseVisualStyleBackColor = false;
            this.BTNVer.Click += new System.EventHandler(this.BTNVer_Click);
            // 
            // BTNRegistrar
            // 
            this.BTNRegistrar.BackColor = System.Drawing.Color.Black;
            this.BTNRegistrar.FlatAppearance.BorderSize = 0;
            this.BTNRegistrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.BTNRegistrar.ForeColor = System.Drawing.Color.White;
            this.BTNRegistrar.Location = new System.Drawing.Point(468, 151);
            this.BTNRegistrar.Name = "BTNRegistrar";
            this.BTNRegistrar.Size = new System.Drawing.Size(128, 38);
            this.BTNRegistrar.TabIndex = 22;
            this.BTNRegistrar.Text = "+Agregar";
            this.BTNRegistrar.UseVisualStyleBackColor = false;
            this.BTNRegistrar.Click += new System.EventHandler(this.BTNRegistrar_Click);
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(325, 237);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(261, 19);
            this.materialLabel1.TabIndex = 16;
            this.materialLabel1.Text = "Acciones para la gestión de compras";
            // 
            // LBLModificar
            // 
            // 
            // 
            // 
            this.LBLModificar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.LBLModificar.Cursor = System.Windows.Forms.Cursors.Default;
            this.LBLModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLModificar.FontBold = true;
            this.LBLModificar.Location = new System.Drawing.Point(507, 30);
            this.LBLModificar.Name = "LBLModificar";
            this.LBLModificar.Size = new System.Drawing.Size(309, 41);
            this.LBLModificar.TabIndex = 14;
            this.LBLModificar.Text = "Gestión de Proveedores";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel2.Controls.Add(this.BTNAdministracionUsuarios);
            this.panel2.Controls.Add(this.BTNPuntoDeVenta);
            this.panel2.Controls.Add(this.BTNBusquedaAvanzada);
            this.panel2.Controls.Add(this.BTNInventario);
            this.panel2.Controls.Add(this.BTNDirectorio);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(270, 554);
            this.panel2.TabIndex = 13;
            // 
            // BTNAdministracionUsuarios
            // 
            this.BTNAdministracionUsuarios.BackColor = System.Drawing.Color.Transparent;
            this.BTNAdministracionUsuarios.FlatAppearance.BorderSize = 0;
            this.BTNAdministracionUsuarios.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveBorder;
            this.BTNAdministracionUsuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTNAdministracionUsuarios.Image = global::SistemaDeInventario2026.Properties.Resources.ic_candado;
            this.BTNAdministracionUsuarios.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTNAdministracionUsuarios.Location = new System.Drawing.Point(5, 237);
            this.BTNAdministracionUsuarios.Margin = new System.Windows.Forms.Padding(4);
            this.BTNAdministracionUsuarios.Name = "BTNAdministracionUsuarios";
            this.BTNAdministracionUsuarios.Size = new System.Drawing.Size(260, 50);
            this.BTNAdministracionUsuarios.TabIndex = 4;
            this.BTNAdministracionUsuarios.Text = "Administración de Usuarios";
            this.BTNAdministracionUsuarios.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTNAdministracionUsuarios.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BTNAdministracionUsuarios.UseVisualStyleBackColor = false;
            // 
            // BTNPuntoDeVenta
            // 
            this.BTNPuntoDeVenta.BackColor = System.Drawing.Color.Transparent;
            this.BTNPuntoDeVenta.FlatAppearance.BorderSize = 0;
            this.BTNPuntoDeVenta.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveBorder;
            this.BTNPuntoDeVenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTNPuntoDeVenta.Image = global::SistemaDeInventario2026.Properties.Resources.ic_venta;
            this.BTNPuntoDeVenta.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTNPuntoDeVenta.Location = new System.Drawing.Point(3, 183);
            this.BTNPuntoDeVenta.Margin = new System.Windows.Forms.Padding(4);
            this.BTNPuntoDeVenta.Name = "BTNPuntoDeVenta";
            this.BTNPuntoDeVenta.Size = new System.Drawing.Size(260, 50);
            this.BTNPuntoDeVenta.TabIndex = 3;
            this.BTNPuntoDeVenta.Text = "Punto de Venta";
            this.BTNPuntoDeVenta.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTNPuntoDeVenta.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BTNPuntoDeVenta.UseVisualStyleBackColor = false;
            // 
            // BTNBusquedaAvanzada
            // 
            this.BTNBusquedaAvanzada.BackColor = System.Drawing.Color.Transparent;
            this.BTNBusquedaAvanzada.FlatAppearance.BorderSize = 0;
            this.BTNBusquedaAvanzada.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveBorder;
            this.BTNBusquedaAvanzada.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTNBusquedaAvanzada.Image = global::SistemaDeInventario2026.Properties.Resources.ic_buscar;
            this.BTNBusquedaAvanzada.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTNBusquedaAvanzada.Location = new System.Drawing.Point(3, 129);
            this.BTNBusquedaAvanzada.Margin = new System.Windows.Forms.Padding(4);
            this.BTNBusquedaAvanzada.Name = "BTNBusquedaAvanzada";
            this.BTNBusquedaAvanzada.Size = new System.Drawing.Size(260, 50);
            this.BTNBusquedaAvanzada.TabIndex = 2;
            this.BTNBusquedaAvanzada.Text = "Búsqueda Avanzada";
            this.BTNBusquedaAvanzada.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTNBusquedaAvanzada.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BTNBusquedaAvanzada.UseVisualStyleBackColor = false;
            // 
            // BTNInventario
            // 
            this.BTNInventario.BackColor = System.Drawing.Color.Transparent;
            this.BTNInventario.FlatAppearance.BorderSize = 0;
            this.BTNInventario.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveBorder;
            this.BTNInventario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTNInventario.Image = global::SistemaDeInventario2026.Properties.Resources.ic_producto;
            this.BTNInventario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTNInventario.Location = new System.Drawing.Point(3, 75);
            this.BTNInventario.Margin = new System.Windows.Forms.Padding(4);
            this.BTNInventario.Name = "BTNInventario";
            this.BTNInventario.Size = new System.Drawing.Size(260, 50);
            this.BTNInventario.TabIndex = 1;
            this.BTNInventario.Text = "Inventario";
            this.BTNInventario.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTNInventario.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BTNInventario.UseVisualStyleBackColor = false;
            // 
            // BTNDirectorio
            // 
            this.BTNDirectorio.BackColor = System.Drawing.Color.Transparent;
            this.BTNDirectorio.FlatAppearance.BorderSize = 0;
            this.BTNDirectorio.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveBorder;
            this.BTNDirectorio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTNDirectorio.Image = global::SistemaDeInventario2026.Properties.Resources.ic_proveedor;
            this.BTNDirectorio.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTNDirectorio.Location = new System.Drawing.Point(3, 21);
            this.BTNDirectorio.Margin = new System.Windows.Forms.Padding(4);
            this.BTNDirectorio.Name = "BTNDirectorio";
            this.BTNDirectorio.Size = new System.Drawing.Size(260, 50);
            this.BTNDirectorio.TabIndex = 0;
            this.BTNDirectorio.Text = "Gestíon de Inversión y Proveedores";
            this.BTNDirectorio.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTNDirectorio.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BTNDirectorio.UseVisualStyleBackColor = false;
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Cursor = System.Windows.Forms.Cursors.Default;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel3.Location = new System.Drawing.Point(325, 129);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(285, 19);
            this.materialLabel3.TabIndex = 3;
            this.materialLabel3.Text = "Acciones para la gestión de proveedores";
            this.materialLabel3.Click += new System.EventHandler(this.materialLabel3_Click);
            // 
            // BTNModificar
            // 
            this.BTNModificar.BackColor = System.Drawing.Color.White;
            this.BTNModificar.FlatAppearance.BorderSize = 0;
            this.BTNModificar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.BTNModificar.ForeColor = System.Drawing.Color.Black;
            this.BTNModificar.Location = new System.Drawing.Point(328, 151);
            this.BTNModificar.Name = "BTNModificar";
            this.BTNModificar.Size = new System.Drawing.Size(64, 38);
            this.BTNModificar.TabIndex = 25;
            this.BTNModificar.Text = "Editar";
            this.BTNModificar.UseVisualStyleBackColor = false;
            this.BTNModificar.Click += new System.EventHandler(this.BTNModificar_Click);
            // 
            // BTNCostoRegistros
            // 
            this.BTNCostoRegistros.BackColor = System.Drawing.Color.Black;
            this.BTNCostoRegistros.FlatAppearance.BorderSize = 0;
            this.BTNCostoRegistros.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.BTNCostoRegistros.ForeColor = System.Drawing.Color.White;
            this.BTNCostoRegistros.Location = new System.Drawing.Point(328, 259);
            this.BTNCostoRegistros.Name = "BTNCostoRegistros";
            this.BTNCostoRegistros.Size = new System.Drawing.Size(213, 38);
            this.BTNCostoRegistros.TabIndex = 26;
            this.BTNCostoRegistros.Text = "Acceder a Registro de Costos";
            this.BTNCostoRegistros.UseVisualStyleBackColor = false;
            // 
            // BTNResumenInversion
            // 
            this.BTNResumenInversion.BackColor = System.Drawing.Color.White;
            this.BTNResumenInversion.FlatAppearance.BorderSize = 0;
            this.BTNResumenInversion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.BTNResumenInversion.ForeColor = System.Drawing.Color.Black;
            this.BTNResumenInversion.Location = new System.Drawing.Point(328, 367);
            this.BTNResumenInversion.Name = "BTNResumenInversion";
            this.BTNResumenInversion.Size = new System.Drawing.Size(158, 38);
            this.BTNResumenInversion.TabIndex = 29;
            this.BTNResumenInversion.Text = "Resumen por Fecha";
            this.BTNResumenInversion.UseVisualStyleBackColor = false;
            // 
            // BTNHistorialAnual
            // 
            this.BTNHistorialAnual.BackColor = System.Drawing.Color.Black;
            this.BTNHistorialAnual.FlatAppearance.BorderSize = 0;
            this.BTNHistorialAnual.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.BTNHistorialAnual.ForeColor = System.Drawing.Color.White;
            this.BTNHistorialAnual.Location = new System.Drawing.Point(492, 367);
            this.BTNHistorialAnual.Name = "BTNHistorialAnual";
            this.BTNHistorialAnual.Size = new System.Drawing.Size(153, 38);
            this.BTNHistorialAnual.TabIndex = 28;
            this.BTNHistorialAnual.Text = "Ver Historial Anual";
            this.BTNHistorialAnual.UseVisualStyleBackColor = false;
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Cursor = System.Windows.Forms.Cursors.Default;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.Location = new System.Drawing.Point(325, 345);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(281, 19);
            this.materialLabel2.TabIndex = 27;
            this.materialLabel2.Text = "Acciones para el análisis de inversiones";
            // 
            // FRMProveedor_Epica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.PPrincipal);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FRMProveedor_Epica";
            this.Text = "FRMProveedor_Epica";
            this.PPrincipal.ResumeLayout(false);
            this.PPrincipal.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PPrincipal;
        private System.Windows.Forms.Button BTNVer;
        private System.Windows.Forms.Button BTNRegistrar;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private DevComponents.DotNetBar.LabelX LBLModificar;
        private System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.Button BTNAdministracionUsuarios;
        public System.Windows.Forms.Button BTNPuntoDeVenta;
        public System.Windows.Forms.Button BTNBusquedaAvanzada;
        public System.Windows.Forms.Button BTNInventario;
        public System.Windows.Forms.Button BTNDirectorio;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private System.Windows.Forms.Button BTNCostoRegistros;
        private System.Windows.Forms.Button BTNModificar;
        private System.Windows.Forms.Button BTNResumenInversion;
        private System.Windows.Forms.Button BTNHistorialAnual;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
    }
}