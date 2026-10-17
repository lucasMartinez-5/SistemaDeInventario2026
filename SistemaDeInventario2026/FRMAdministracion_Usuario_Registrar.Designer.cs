namespace SistemaDeInventario2026
{
    partial class FRMAdministracion_Usuario_Registrar
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
            this.PAgregar_Usuario = new System.Windows.Forms.Panel();
            this.TXTRol = new System.Windows.Forms.TextBox();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.DPECHuellas = new DPFP.Gui.Enrollment.EnrollmentControl();
            this.BTNBuscarUsuario = new DevComponents.DotNetBar.ButtonX();
            this.SWBEstado = new DevComponents.DotNetBar.Controls.SwitchButton();
            this.TXTNombreCompleto = new System.Windows.Forms.TextBox();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.TXTLoginUsuario = new System.Windows.Forms.TextBox();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.TXTCI = new System.Windows.Forms.TextBox();
            this.BTNLimpiar = new System.Windows.Forms.Button();
            this.BTNSalir = new System.Windows.Forms.Button();
            this.BTNGrabar = new System.Windows.Forms.Button();
            this.LBLCI = new MaterialSkin.Controls.MaterialLabel();
            this.LBLRegistrarProveedor = new DevComponents.DotNetBar.LabelX();
            this.PPrincipal.SuspendLayout();
            this.PAgregar_Usuario.SuspendLayout();
            this.SuspendLayout();
            // 
            // PPrincipal
            // 
            this.PPrincipal.BackColor = System.Drawing.Color.White;
            this.PPrincipal.Controls.Add(this.PAgregar_Usuario);
            this.PPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PPrincipal.Location = new System.Drawing.Point(0, 0);
            this.PPrincipal.Name = "PPrincipal";
            this.PPrincipal.Size = new System.Drawing.Size(970, 519);
            this.PPrincipal.TabIndex = 0;
            // 
            // PAgregar_Usuario
            // 
            this.PAgregar_Usuario.Controls.Add(this.TXTRol);
            this.PAgregar_Usuario.Controls.Add(this.materialLabel4);
            this.PAgregar_Usuario.Controls.Add(this.DPECHuellas);
            this.PAgregar_Usuario.Controls.Add(this.BTNBuscarUsuario);
            this.PAgregar_Usuario.Controls.Add(this.SWBEstado);
            this.PAgregar_Usuario.Controls.Add(this.TXTNombreCompleto);
            this.PAgregar_Usuario.Controls.Add(this.materialLabel2);
            this.PAgregar_Usuario.Controls.Add(this.TXTLoginUsuario);
            this.PAgregar_Usuario.Controls.Add(this.materialLabel1);
            this.PAgregar_Usuario.Controls.Add(this.TXTCI);
            this.PAgregar_Usuario.Controls.Add(this.BTNLimpiar);
            this.PAgregar_Usuario.Controls.Add(this.BTNSalir);
            this.PAgregar_Usuario.Controls.Add(this.BTNGrabar);
            this.PAgregar_Usuario.Controls.Add(this.LBLCI);
            this.PAgregar_Usuario.Controls.Add(this.LBLRegistrarProveedor);
            this.PAgregar_Usuario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PAgregar_Usuario.Location = new System.Drawing.Point(0, 0);
            this.PAgregar_Usuario.Name = "PAgregar_Usuario";
            this.PAgregar_Usuario.Size = new System.Drawing.Size(970, 519);
            this.PAgregar_Usuario.TabIndex = 0;
            // 
            // TXTRol
            // 
            this.TXTRol.Location = new System.Drawing.Point(23, 235);
            this.TXTRol.Name = "TXTRol";
            this.TXTRol.Size = new System.Drawing.Size(414, 23);
            this.TXTRol.TabIndex = 69;
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel4.Location = new System.Drawing.Point(20, 213);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(24, 19);
            this.materialLabel4.TabIndex = 68;
            this.materialLabel4.Text = "Rol";
            // 
            // DPECHuellas
            // 
            this.DPECHuellas.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.DPECHuellas.EnrolledFingerMask = 0;
            this.DPECHuellas.Location = new System.Drawing.Point(448, 152);
            this.DPECHuellas.Margin = new System.Windows.Forms.Padding(5);
            this.DPECHuellas.MaxEnrollFingerCount = 10;
            this.DPECHuellas.Name = "DPECHuellas";
            this.DPECHuellas.ReaderSerialNumber = "00000000-0000-0000-0000-000000000000";
            this.DPECHuellas.Size = new System.Drawing.Size(492, 314);
            this.DPECHuellas.TabIndex = 67;
            this.DPECHuellas.OnDelete += new DPFP.Gui.Enrollment.EnrollmentControl._OnDelete(this.DPECHuellas_OnDelete);
            this.DPECHuellas.OnEnroll += new DPFP.Gui.Enrollment.EnrollmentControl._OnEnroll(this.DPECHuellas_OnEnroll);
            // 
            // BTNBuscarUsuario
            // 
            this.BTNBuscarUsuario.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.BTNBuscarUsuario.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.BTNBuscarUsuario.Image = global::SistemaDeInventario2026.Properties.Resources.ic_buscar;
            this.BTNBuscarUsuario.ImageFixedSize = new System.Drawing.Size(15, 15);
            this.BTNBuscarUsuario.Location = new System.Drawing.Point(207, 175);
            this.BTNBuscarUsuario.Name = "BTNBuscarUsuario";
            this.BTNBuscarUsuario.Size = new System.Drawing.Size(23, 23);
            this.BTNBuscarUsuario.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.BTNBuscarUsuario.TabIndex = 66;
            this.BTNBuscarUsuario.Click += new System.EventHandler(this.BTNBuscarUsuario_Click);
            // 
            // SWBEstado
            // 
            // 
            // 
            // 
            this.SWBEstado.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.SWBEstado.Location = new System.Drawing.Point(246, 175);
            this.SWBEstado.Name = "SWBEstado";
            this.SWBEstado.Size = new System.Drawing.Size(191, 23);
            this.SWBEstado.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.SWBEstado.TabIndex = 65;
            // 
            // TXTNombreCompleto
            // 
            this.TXTNombreCompleto.Location = new System.Drawing.Point(23, 292);
            this.TXTNombreCompleto.Name = "TXTNombreCompleto";
            this.TXTNombreCompleto.Size = new System.Drawing.Size(414, 23);
            this.TXTNombreCompleto.TabIndex = 64;
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.Location = new System.Drawing.Point(20, 270);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(129, 19);
            this.materialLabel2.TabIndex = 63;
            this.materialLabel2.Text = "Nombre Completo";
            // 
            // TXTLoginUsuario
            // 
            this.TXTLoginUsuario.Location = new System.Drawing.Point(23, 359);
            this.TXTLoginUsuario.Name = "TXTLoginUsuario";
            this.TXTLoginUsuario.Size = new System.Drawing.Size(414, 23);
            this.TXTLoginUsuario.TabIndex = 62;
            this.TXTLoginUsuario.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TXTLoginUsuario_KeyDown);
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(20, 337);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(120, 19);
            this.materialLabel1.TabIndex = 61;
            this.materialLabel1.Text = "Login de Usuario";
            // 
            // TXTCI
            // 
            this.TXTCI.Location = new System.Drawing.Point(23, 178);
            this.TXTCI.Name = "TXTCI";
            this.TXTCI.Size = new System.Drawing.Size(178, 23);
            this.TXTCI.TabIndex = 59;
            // 
            // BTNLimpiar
            // 
            this.BTNLimpiar.BackColor = System.Drawing.Color.White;
            this.BTNLimpiar.FlatAppearance.BorderSize = 0;
            this.BTNLimpiar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.BTNLimpiar.ForeColor = System.Drawing.Color.Black;
            this.BTNLimpiar.Location = new System.Drawing.Point(311, 399);
            this.BTNLimpiar.Name = "BTNLimpiar";
            this.BTNLimpiar.Size = new System.Drawing.Size(126, 38);
            this.BTNLimpiar.TabIndex = 58;
            this.BTNLimpiar.Text = "Limpiar";
            this.BTNLimpiar.UseVisualStyleBackColor = false;
            // 
            // BTNSalir
            // 
            this.BTNSalir.BackColor = System.Drawing.Color.White;
            this.BTNSalir.FlatAppearance.BorderSize = 0;
            this.BTNSalir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.BTNSalir.ForeColor = System.Drawing.Color.Black;
            this.BTNSalir.Location = new System.Drawing.Point(23, 399);
            this.BTNSalir.Name = "BTNSalir";
            this.BTNSalir.Size = new System.Drawing.Size(131, 38);
            this.BTNSalir.TabIndex = 57;
            this.BTNSalir.Text = "Salir";
            this.BTNSalir.UseVisualStyleBackColor = false;
            this.BTNSalir.Click += new System.EventHandler(this.BTNSalir_Click);
            // 
            // BTNGrabar
            // 
            this.BTNGrabar.BackColor = System.Drawing.Color.Black;
            this.BTNGrabar.FlatAppearance.BorderSize = 0;
            this.BTNGrabar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.BTNGrabar.ForeColor = System.Drawing.Color.White;
            this.BTNGrabar.Location = new System.Drawing.Point(160, 399);
            this.BTNGrabar.Name = "BTNGrabar";
            this.BTNGrabar.Size = new System.Drawing.Size(145, 38);
            this.BTNGrabar.TabIndex = 56;
            this.BTNGrabar.Text = "Grabar";
            this.BTNGrabar.UseVisualStyleBackColor = false;
            this.BTNGrabar.Click += new System.EventHandler(this.BTNGrabar_Click);
            // 
            // LBLCI
            // 
            this.LBLCI.AutoSize = true;
            this.LBLCI.Depth = 0;
            this.LBLCI.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.LBLCI.Location = new System.Drawing.Point(20, 156);
            this.LBLCI.MouseState = MaterialSkin.MouseState.HOVER;
            this.LBLCI.Name = "LBLCI";
            this.LBLCI.Size = new System.Drawing.Size(15, 19);
            this.LBLCI.TabIndex = 55;
            this.LBLCI.Text = "CI";
            // 
            // LBLRegistrarProveedor
            // 
            this.LBLRegistrarProveedor.AutoSize = true;
            // 
            // 
            // 
            this.LBLRegistrarProveedor.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.LBLRegistrarProveedor.Cursor = System.Windows.Forms.Cursors.Default;
            this.LBLRegistrarProveedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLRegistrarProveedor.FontBold = true;
            this.LBLRegistrarProveedor.Location = new System.Drawing.Point(322, 27);
            this.LBLRegistrarProveedor.Name = "LBLRegistrarProveedor";
            this.LBLRegistrarProveedor.Size = new System.Drawing.Size(305, 50);
            this.LBLRegistrarProveedor.TabIndex = 54;
            this.LBLRegistrarProveedor.Text = "Agregar Usuario";
            this.LBLRegistrarProveedor.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // FRMAdministracion_Usuario_Registrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(970, 519);
            this.Controls.Add(this.PPrincipal);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FRMAdministracion_Usuario_Registrar";
            this.Text = "FRMAdministracion_Usuario_Registrar";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FRMAdministracion_Usuario_Registrar_FormClosing);
            this.Load += new System.EventHandler(this.FRMAdministracion_Usuario_Registrar_Load);
            this.PPrincipal.ResumeLayout(false);
            this.PAgregar_Usuario.ResumeLayout(false);
            this.PAgregar_Usuario.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PPrincipal;
        private System.Windows.Forms.Panel PAgregar_Usuario;
        private DevComponents.DotNetBar.ButtonX BTNBuscarUsuario;
        private DevComponents.DotNetBar.Controls.SwitchButton SWBEstado;
        private System.Windows.Forms.TextBox TXTNombreCompleto;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private System.Windows.Forms.TextBox TXTLoginUsuario;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private System.Windows.Forms.TextBox TXTCI;
        private System.Windows.Forms.Button BTNLimpiar;
        private System.Windows.Forms.Button BTNSalir;
        private System.Windows.Forms.Button BTNGrabar;
        private MaterialSkin.Controls.MaterialLabel LBLCI;
        private DevComponents.DotNetBar.LabelX LBLRegistrarProveedor;
        private DPFP.Gui.Enrollment.EnrollmentControl DPECHuellas;
        private System.Windows.Forms.TextBox TXTRol;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
    }
}