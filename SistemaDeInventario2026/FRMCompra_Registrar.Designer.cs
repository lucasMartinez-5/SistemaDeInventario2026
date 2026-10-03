namespace SistemaDeInventario2026
{
    partial class FRMCompra_Registrar
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
            this.BTNBusquedaGeneral = new DevComponents.DotNetBar.ButtonX();
            this.TXTFiltrarGeneral = new System.Windows.Forms.TextBox();
            this.BTNConfiguracion = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.BTNAdministracionUsuarios = new System.Windows.Forms.Button();
            this.BTNPuntoDeVenta = new System.Windows.Forms.Button();
            this.BTNBusquedaAvanzada = new System.Windows.Forms.Button();
            this.BTNInventario = new System.Windows.Forms.Button();
            this.BTNDirectorio = new System.Windows.Forms.Button();
            this.PPrincipal = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.TXTCompraProductoEncontrado = new System.Windows.Forms.TextBox();
            this.BTNBuscarProveedorCompra = new System.Windows.Forms.Button();
            this.TXTCompraProveedor = new System.Windows.Forms.TextBox();
            this.BTNSalir = new System.Windows.Forms.Button();
            this.LBLTotal = new DevComponents.DotNetBar.LabelX();
            this.LTVCarrito = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.BTNBuscarProductoCompra = new System.Windows.Forms.Button();
            this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            this.NUDPrecio = new System.Windows.Forms.NumericUpDown();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.NUDCantidad = new System.Windows.Forms.NumericUpDown();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.BTNAgregarProductoAlCarrito = new System.Windows.Forms.Button();
            this.LBLProveedor = new MaterialSkin.Controls.MaterialLabel();
            this.TXTCompraProveedorCelular = new System.Windows.Forms.TextBox();
            this.TXTCompraFactura = new System.Windows.Forms.TextBox();
            this.BTNVaciarCarrito = new System.Windows.Forms.Button();
            this.BTNRegistrarCompra = new System.Windows.Forms.Button();
            this.LBL = new MaterialSkin.Controls.MaterialLabel();
            this.LBLTitulo = new DevComponents.DotNetBar.LabelX();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.panel2.SuspendLayout();
            this.PPrincipal.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUDPrecio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDCantidad)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.BTNBusquedaGeneral);
            this.panel1.Controls.Add(this.TXTFiltrarGeneral);
            this.panel1.Controls.Add(this.BTNConfiguracion);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.pictureBox4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1342, 45);
            this.panel1.TabIndex = 8;
            // 
            // BTNBusquedaGeneral
            // 
            this.BTNBusquedaGeneral.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.BTNBusquedaGeneral.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.BTNBusquedaGeneral.Image = global::SistemaDeInventario2026.Properties.Resources.ic_buscar;
            this.BTNBusquedaGeneral.ImageFixedSize = new System.Drawing.Size(15, 15);
            this.BTNBusquedaGeneral.Location = new System.Drawing.Point(1032, 10);
            this.BTNBusquedaGeneral.Name = "BTNBusquedaGeneral";
            this.BTNBusquedaGeneral.Size = new System.Drawing.Size(23, 23);
            this.BTNBusquedaGeneral.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.BTNBusquedaGeneral.TabIndex = 46;
            // 
            // TXTFiltrarGeneral
            // 
            this.TXTFiltrarGeneral.Location = new System.Drawing.Point(864, 10);
            this.TXTFiltrarGeneral.Name = "TXTFiltrarGeneral";
            this.TXTFiltrarGeneral.Size = new System.Drawing.Size(191, 23);
            this.TXTFiltrarGeneral.TabIndex = 45;
            // 
            // BTNConfiguracion
            // 
            this.BTNConfiguracion.FlatAppearance.BorderSize = 0;
            this.BTNConfiguracion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTNConfiguracion.Location = new System.Drawing.Point(750, 7);
            this.BTNConfiguracion.Name = "BTNConfiguracion";
            this.BTNConfiguracion.Size = new System.Drawing.Size(108, 29);
            this.BTNConfiguracion.TabIndex = 44;
            this.BTNConfiguracion.Text = "Configuración";
            this.BTNConfiguracion.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Cursor = System.Windows.Forms.Cursors.Default;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label4.Location = new System.Drawing.Point(59, 8);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(237, 25);
            this.label4.TabIndex = 33;
            this.label4.Text = "Directorio de Proveedores";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::SistemaDeInventario2026.Properties.Resources.ic_circle_usuario;
            this.pictureBox4.Location = new System.Drawing.Point(5, 2);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(48, 41);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 32;
            this.pictureBox4.TabStop = false;
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
            this.panel2.Size = new System.Drawing.Size(270, 566);
            this.panel2.TabIndex = 13;
            // 
            // BTNAdministracionUsuarios
            // 
            this.BTNAdministracionUsuarios.BackColor = System.Drawing.Color.Transparent;
            this.BTNAdministracionUsuarios.FlatAppearance.BorderSize = 0;
            this.BTNAdministracionUsuarios.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveBorder;
            this.BTNAdministracionUsuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTNAdministracionUsuarios.Image = global::SistemaDeInventario2026.Properties.Resources.ic_candado40;
            this.BTNAdministracionUsuarios.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTNAdministracionUsuarios.Location = new System.Drawing.Point(10, 237);
            this.BTNAdministracionUsuarios.Margin = new System.Windows.Forms.Padding(4);
            this.BTNAdministracionUsuarios.Name = "BTNAdministracionUsuarios";
            this.BTNAdministracionUsuarios.Size = new System.Drawing.Size(250, 50);
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
            this.BTNPuntoDeVenta.Image = global::SistemaDeInventario2026.Properties.Resources.ic_venta40;
            this.BTNPuntoDeVenta.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTNPuntoDeVenta.Location = new System.Drawing.Point(10, 183);
            this.BTNPuntoDeVenta.Margin = new System.Windows.Forms.Padding(4);
            this.BTNPuntoDeVenta.Name = "BTNPuntoDeVenta";
            this.BTNPuntoDeVenta.Size = new System.Drawing.Size(250, 50);
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
            this.BTNBusquedaAvanzada.Image = global::SistemaDeInventario2026.Properties.Resources.ic_buscar40;
            this.BTNBusquedaAvanzada.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTNBusquedaAvanzada.Location = new System.Drawing.Point(10, 129);
            this.BTNBusquedaAvanzada.Margin = new System.Windows.Forms.Padding(4);
            this.BTNBusquedaAvanzada.Name = "BTNBusquedaAvanzada";
            this.BTNBusquedaAvanzada.Size = new System.Drawing.Size(250, 50);
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
            this.BTNInventario.Image = global::SistemaDeInventario2026.Properties.Resources.icons8_producto_100__1___1_;
            this.BTNInventario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTNInventario.Location = new System.Drawing.Point(10, 75);
            this.BTNInventario.Margin = new System.Windows.Forms.Padding(4);
            this.BTNInventario.Name = "BTNInventario";
            this.BTNInventario.Size = new System.Drawing.Size(250, 50);
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
            this.BTNDirectorio.Image = global::SistemaDeInventario2026.Properties.Resources.ic_proveedor40;
            this.BTNDirectorio.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTNDirectorio.Location = new System.Drawing.Point(10, 21);
            this.BTNDirectorio.Margin = new System.Windows.Forms.Padding(4);
            this.BTNDirectorio.Name = "BTNDirectorio";
            this.BTNDirectorio.Size = new System.Drawing.Size(250, 50);
            this.BTNDirectorio.TabIndex = 0;
            this.BTNDirectorio.Text = "Gestíon de Inversión y Proveedores";
            this.BTNDirectorio.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTNDirectorio.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BTNDirectorio.UseVisualStyleBackColor = false;
            // 
            // PPrincipal
            // 
            this.PPrincipal.BackColor = System.Drawing.Color.White;
            this.PPrincipal.Controls.Add(this.panel3);
            this.PPrincipal.Controls.Add(this.panel2);
            this.PPrincipal.Cursor = System.Windows.Forms.Cursors.Default;
            this.PPrincipal.Location = new System.Drawing.Point(0, 44);
            this.PPrincipal.Name = "PPrincipal";
            this.PPrincipal.Size = new System.Drawing.Size(1342, 566);
            this.PPrincipal.TabIndex = 7;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.TXTCompraProductoEncontrado);
            this.panel3.Controls.Add(this.BTNBuscarProveedorCompra);
            this.panel3.Controls.Add(this.TXTCompraProveedor);
            this.panel3.Controls.Add(this.BTNSalir);
            this.panel3.Controls.Add(this.LBLTotal);
            this.panel3.Controls.Add(this.LTVCarrito);
            this.panel3.Controls.Add(this.BTNBuscarProductoCompra);
            this.panel3.Controls.Add(this.materialLabel6);
            this.panel3.Controls.Add(this.NUDPrecio);
            this.panel3.Controls.Add(this.materialLabel5);
            this.panel3.Controls.Add(this.NUDCantidad);
            this.panel3.Controls.Add(this.materialLabel4);
            this.panel3.Controls.Add(this.BTNAgregarProductoAlCarrito);
            this.panel3.Controls.Add(this.LBLProveedor);
            this.panel3.Controls.Add(this.TXTCompraProveedorCelular);
            this.panel3.Controls.Add(this.TXTCompraFactura);
            this.panel3.Controls.Add(this.BTNVaciarCarrito);
            this.panel3.Controls.Add(this.BTNRegistrarCompra);
            this.panel3.Controls.Add(this.LBL);
            this.panel3.Controls.Add(this.LBLTitulo);
            this.panel3.Controls.Add(this.materialLabel3);
            this.panel3.Location = new System.Drawing.Point(277, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1062, 560);
            this.panel3.TabIndex = 39;
            // 
            // TXTCompraProductoEncontrado
            // 
            this.TXTCompraProductoEncontrado.Location = new System.Drawing.Point(11, 256);
            this.TXTCompraProductoEncontrado.Name = "TXTCompraProductoEncontrado";
            this.TXTCompraProductoEncontrado.Size = new System.Drawing.Size(191, 23);
            this.TXTCompraProductoEncontrado.TabIndex = 96;
            // 
            // BTNBuscarProveedorCompra
            // 
            this.BTNBuscarProveedorCompra.BackColor = System.Drawing.Color.White;
            this.BTNBuscarProveedorCompra.FlatAppearance.BorderSize = 0;
            this.BTNBuscarProveedorCompra.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.BTNBuscarProveedorCompra.ForeColor = System.Drawing.Color.Black;
            this.BTNBuscarProveedorCompra.Location = new System.Drawing.Point(223, 126);
            this.BTNBuscarProveedorCompra.Name = "BTNBuscarProveedorCompra";
            this.BTNBuscarProveedorCompra.Size = new System.Drawing.Size(191, 28);
            this.BTNBuscarProveedorCompra.TabIndex = 95;
            this.BTNBuscarProveedorCompra.Text = "BuscarProveedor";
            this.BTNBuscarProveedorCompra.UseVisualStyleBackColor = false;
            this.BTNBuscarProveedorCompra.Click += new System.EventHandler(this.BTNBuscarProveedorCompra_Click);
            // 
            // TXTCompraProveedor
            // 
            this.TXTCompraProveedor.Location = new System.Drawing.Point(11, 126);
            this.TXTCompraProveedor.Name = "TXTCompraProveedor";
            this.TXTCompraProveedor.Size = new System.Drawing.Size(191, 23);
            this.TXTCompraProveedor.TabIndex = 94;
            // 
            // BTNSalir
            // 
            this.BTNSalir.BackColor = System.Drawing.Color.White;
            this.BTNSalir.FlatAppearance.BorderSize = 0;
            this.BTNSalir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.BTNSalir.ForeColor = System.Drawing.Color.Black;
            this.BTNSalir.Location = new System.Drawing.Point(44, 365);
            this.BTNSalir.Name = "BTNSalir";
            this.BTNSalir.Size = new System.Drawing.Size(158, 38);
            this.BTNSalir.TabIndex = 93;
            this.BTNSalir.Text = "Salir";
            this.BTNSalir.UseVisualStyleBackColor = false;
            this.BTNSalir.Click += new System.EventHandler(this.BTNSalir_Click);
            // 
            // LBLTotal
            // 
            this.LBLTotal.AutoSize = true;
            // 
            // 
            // 
            this.LBLTotal.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.LBLTotal.Cursor = System.Windows.Forms.Cursors.Default;
            this.LBLTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLTotal.FontBold = true;
            this.LBLTotal.Location = new System.Drawing.Point(491, 302);
            this.LBLTotal.Name = "LBLTotal";
            this.LBLTotal.Size = new System.Drawing.Size(134, 35);
            this.LBLTotal.TabIndex = 92;
            this.LBLTotal.Text = "Total: 0.00";
            this.LBLTotal.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // LTVCarrito
            // 
            this.LTVCarrito.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LTVCarrito.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.LTVCarrito.FullRowSelect = true;
            this.LTVCarrito.GridLines = true;
            this.LTVCarrito.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.LTVCarrito.HideSelection = false;
            this.LTVCarrito.Location = new System.Drawing.Point(441, 126);
            this.LTVCarrito.Name = "LTVCarrito";
            this.LTVCarrito.Size = new System.Drawing.Size(612, 167);
            this.LTVCarrito.TabIndex = 90;
            this.LTVCarrito.UseCompatibleStateImageBehavior = false;
            this.LTVCarrito.View = System.Windows.Forms.View.Details;
            this.LTVCarrito.MouseClick += new System.Windows.Forms.MouseEventHandler(this.LTVCarrito_MouseClick);
            this.LTVCarrito.MouseLeave += new System.EventHandler(this.LTVCarrito_MouseLeave);
            this.LTVCarrito.MouseMove += new System.Windows.Forms.MouseEventHandler(this.LTVCarrito_MouseMove);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Producto";
            this.columnHeader1.Width = 217;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Cantidad";
            this.columnHeader2.Width = 74;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Precio";
            this.columnHeader3.Width = 82;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Sub Total";
            this.columnHeader4.Width = 87;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = " X";
            this.columnHeader5.Width = 40;
            // 
            // BTNBuscarProductoCompra
            // 
            this.BTNBuscarProductoCompra.BackColor = System.Drawing.Color.White;
            this.BTNBuscarProductoCompra.FlatAppearance.BorderSize = 0;
            this.BTNBuscarProductoCompra.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.BTNBuscarProductoCompra.ForeColor = System.Drawing.Color.Black;
            this.BTNBuscarProductoCompra.Location = new System.Drawing.Point(223, 256);
            this.BTNBuscarProductoCompra.Name = "BTNBuscarProductoCompra";
            this.BTNBuscarProductoCompra.Size = new System.Drawing.Size(191, 28);
            this.BTNBuscarProductoCompra.TabIndex = 89;
            this.BTNBuscarProductoCompra.Text = "Buscar Producto";
            this.BTNBuscarProductoCompra.UseVisualStyleBackColor = false;
            this.BTNBuscarProductoCompra.Click += new System.EventHandler(this.BTNBuscarProductoCompra_Click);
            // 
            // materialLabel6
            // 
            this.materialLabel6.AutoSize = true;
            this.materialLabel6.Cursor = System.Windows.Forms.Cursors.Default;
            this.materialLabel6.Depth = 0;
            this.materialLabel6.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel6.Location = new System.Drawing.Point(220, 292);
            this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel6.Name = "materialLabel6";
            this.materialLabel6.Size = new System.Drawing.Size(105, 19);
            this.materialLabel6.TabIndex = 88;
            this.materialLabel6.Text = "Precio Compra";
            // 
            // NUDPrecio
            // 
            this.NUDPrecio.DecimalPlaces = 2;
            this.NUDPrecio.Location = new System.Drawing.Point(223, 314);
            this.NUDPrecio.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.NUDPrecio.Name = "NUDPrecio";
            this.NUDPrecio.Size = new System.Drawing.Size(191, 23);
            this.NUDPrecio.TabIndex = 87;
            this.NUDPrecio.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Cursor = System.Windows.Forms.Cursors.Default;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel5.Location = new System.Drawing.Point(8, 292);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(65, 19);
            this.materialLabel5.TabIndex = 86;
            this.materialLabel5.Text = "Cantidad";
            // 
            // NUDCantidad
            // 
            this.NUDCantidad.DecimalPlaces = 2;
            this.NUDCantidad.Location = new System.Drawing.Point(11, 314);
            this.NUDCantidad.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.NUDCantidad.Name = "NUDCantidad";
            this.NUDCantidad.Size = new System.Drawing.Size(191, 23);
            this.NUDCantidad.TabIndex = 85;
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel4.Location = new System.Drawing.Point(8, 234);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(65, 19);
            this.materialLabel4.TabIndex = 83;
            this.materialLabel4.Text = "Producto";
            // 
            // BTNAgregarProductoAlCarrito
            // 
            this.BTNAgregarProductoAlCarrito.BackColor = System.Drawing.Color.Black;
            this.BTNAgregarProductoAlCarrito.FlatAppearance.BorderSize = 0;
            this.BTNAgregarProductoAlCarrito.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.BTNAgregarProductoAlCarrito.ForeColor = System.Drawing.Color.White;
            this.BTNAgregarProductoAlCarrito.Location = new System.Drawing.Point(223, 365);
            this.BTNAgregarProductoAlCarrito.Name = "BTNAgregarProductoAlCarrito";
            this.BTNAgregarProductoAlCarrito.Size = new System.Drawing.Size(153, 38);
            this.BTNAgregarProductoAlCarrito.TabIndex = 52;
            this.BTNAgregarProductoAlCarrito.Text = "Agregar al Carrito";
            this.BTNAgregarProductoAlCarrito.UseVisualStyleBackColor = false;
            this.BTNAgregarProductoAlCarrito.Click += new System.EventHandler(this.BTNAgregarProductoAlCarrito_Click);
            // 
            // LBLProveedor
            // 
            this.LBLProveedor.AutoSize = true;
            this.LBLProveedor.Depth = 0;
            this.LBLProveedor.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.LBLProveedor.Location = new System.Drawing.Point(8, 104);
            this.LBLProveedor.MouseState = MaterialSkin.MouseState.HOVER;
            this.LBLProveedor.Name = "LBLProveedor";
            this.LBLProveedor.Size = new System.Drawing.Size(72, 19);
            this.LBLProveedor.TabIndex = 49;
            this.LBLProveedor.Text = "Proveedor";
            // 
            // TXTCompraProveedorCelular
            // 
            this.TXTCompraProveedorCelular.Location = new System.Drawing.Point(223, 183);
            this.TXTCompraProveedorCelular.Name = "TXTCompraProveedorCelular";
            this.TXTCompraProveedorCelular.Size = new System.Drawing.Size(191, 23);
            this.TXTCompraProveedorCelular.TabIndex = 46;
            // 
            // TXTCompraFactura
            // 
            this.TXTCompraFactura.Location = new System.Drawing.Point(11, 183);
            this.TXTCompraFactura.Name = "TXTCompraFactura";
            this.TXTCompraFactura.Size = new System.Drawing.Size(191, 23);
            this.TXTCompraFactura.TabIndex = 45;
            this.TXTCompraFactura.Enter += new System.EventHandler(this.TXTCompraFactura_Enter);
            this.TXTCompraFactura.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TXTCompraFactura_KeyPress);
            // 
            // BTNVaciarCarrito
            // 
            this.BTNVaciarCarrito.BackColor = System.Drawing.Color.White;
            this.BTNVaciarCarrito.FlatAppearance.BorderSize = 0;
            this.BTNVaciarCarrito.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.BTNVaciarCarrito.ForeColor = System.Drawing.Color.Black;
            this.BTNVaciarCarrito.Location = new System.Drawing.Point(491, 365);
            this.BTNVaciarCarrito.Name = "BTNVaciarCarrito";
            this.BTNVaciarCarrito.Size = new System.Drawing.Size(158, 38);
            this.BTNVaciarCarrito.TabIndex = 44;
            this.BTNVaciarCarrito.Text = "Vaciar Carrito";
            this.BTNVaciarCarrito.UseVisualStyleBackColor = false;
            this.BTNVaciarCarrito.Click += new System.EventHandler(this.BTNVaciarCarrito_Click);
            // 
            // BTNRegistrarCompra
            // 
            this.BTNRegistrarCompra.BackColor = System.Drawing.Color.Black;
            this.BTNRegistrarCompra.FlatAppearance.BorderSize = 0;
            this.BTNRegistrarCompra.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.BTNRegistrarCompra.ForeColor = System.Drawing.Color.White;
            this.BTNRegistrarCompra.Location = new System.Drawing.Point(696, 365);
            this.BTNRegistrarCompra.Name = "BTNRegistrarCompra";
            this.BTNRegistrarCompra.Size = new System.Drawing.Size(153, 38);
            this.BTNRegistrarCompra.TabIndex = 42;
            this.BTNRegistrarCompra.Text = "Registrar Compra";
            this.BTNRegistrarCompra.UseVisualStyleBackColor = false;
            this.BTNRegistrarCompra.Click += new System.EventHandler(this.BTNRegistrarCompra_Click);
            // 
            // LBL
            // 
            this.LBL.AutoSize = true;
            this.LBL.Depth = 0;
            this.LBL.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.LBL.Location = new System.Drawing.Point(8, 161);
            this.LBL.MouseState = MaterialSkin.MouseState.HOVER;
            this.LBL.Name = "LBL";
            this.LBL.Size = new System.Drawing.Size(97, 19);
            this.LBL.TabIndex = 41;
            this.LBL.Text = "N° de Factura";
            // 
            // LBLTitulo
            // 
            this.LBLTitulo.AutoSize = true;
            // 
            // 
            // 
            this.LBLTitulo.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.LBLTitulo.Cursor = System.Windows.Forms.Cursors.Default;
            this.LBLTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLTitulo.FontBold = true;
            this.LBLTitulo.Location = new System.Drawing.Point(308, 30);
            this.LBLTitulo.Name = "LBLTitulo";
            this.LBLTitulo.Size = new System.Drawing.Size(330, 50);
            this.LBLTitulo.TabIndex = 40;
            this.LBLTitulo.Text = "Registrar Compra";
            this.LBLTitulo.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Cursor = System.Windows.Forms.Cursors.Default;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel3.Location = new System.Drawing.Point(220, 161);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(50, 19);
            this.materialLabel3.TabIndex = 39;
            this.materialLabel3.Text = "Celular";
            // 
            // FRMCompra_Registrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1342, 609);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.PPrincipal);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FRMCompra_Registrar";
            this.Text = "FRMCompra_Registrar";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FRMCompra_Registrar_FormClosing);
            this.Load += new System.EventHandler(this.FRMCompra_Registrar_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.panel2.ResumeLayout(false);
            this.PPrincipal.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUDPrecio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDCantidad)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private DevComponents.DotNetBar.ButtonX BTNBusquedaGeneral;
        private System.Windows.Forms.TextBox TXTFiltrarGeneral;
        private System.Windows.Forms.Button BTNConfiguracion;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.Button BTNAdministracionUsuarios;
        public System.Windows.Forms.Button BTNPuntoDeVenta;
        public System.Windows.Forms.Button BTNBusquedaAvanzada;
        public System.Windows.Forms.Button BTNInventario;
        public System.Windows.Forms.Button BTNDirectorio;
        private System.Windows.Forms.Panel PPrincipal;
        private System.Windows.Forms.Panel panel3;
        private MaterialSkin.Controls.MaterialLabel LBLProveedor;
        private System.Windows.Forms.TextBox TXTCompraProveedorCelular;
        private System.Windows.Forms.TextBox TXTCompraFactura;
        private System.Windows.Forms.Button BTNVaciarCarrito;
        private System.Windows.Forms.Button BTNRegistrarCompra;
        private MaterialSkin.Controls.MaterialLabel LBL;
        private DevComponents.DotNetBar.LabelX LBLTitulo;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private System.Windows.Forms.Button BTNAgregarProductoAlCarrito;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private System.Windows.Forms.NumericUpDown NUDPrecio;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private System.Windows.Forms.NumericUpDown NUDCantidad;
        private System.Windows.Forms.Button BTNBuscarProductoCompra;
        private System.Windows.Forms.ListView LTVCarrito;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private DevComponents.DotNetBar.LabelX LBLTotal;
        private System.Windows.Forms.Button BTNSalir;
        private System.Windows.Forms.TextBox TXTCompraProductoEncontrado;
        private System.Windows.Forms.Button BTNBuscarProveedorCompra;
        private System.Windows.Forms.TextBox TXTCompraProveedor;
    }
}