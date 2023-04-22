namespace CapaPresentacion
{
    partial class frmPrincipal
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

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.btnUsuario = new Bunifu.Framework.UI.BunifuTileButton();
            this.btnMovimientos = new Bunifu.Framework.UI.BunifuTileButton();
            this.btnProductos = new Bunifu.Framework.UI.BunifuTileButton();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnReportes = new Bunifu.Framework.UI.BunifuTileButton();
            this.btnCerrarSesion = new Bunifu.UI.WinForms.BunifuImageButton();
            this.lblSalir = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnUsuario
            // 
            this.btnUsuario.BackColor = System.Drawing.Color.DimGray;
            this.btnUsuario.color = System.Drawing.Color.DimGray;
            this.btnUsuario.colorActive = System.Drawing.Color.Gray;
            this.btnUsuario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUsuario.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.btnUsuario.ForeColor = System.Drawing.Color.White;
            this.btnUsuario.Image = ((System.Drawing.Image)(resources.GetObject("btnUsuario.Image")));
            this.btnUsuario.ImagePosition = 20;
            this.btnUsuario.ImageZoom = 50;
            this.btnUsuario.LabelPosition = 41;
            this.btnUsuario.LabelText = "USUARIO";
            this.btnUsuario.Location = new System.Drawing.Point(109, 96);
            this.btnUsuario.Margin = new System.Windows.Forms.Padding(6);
            this.btnUsuario.Name = "btnUsuario";
            this.btnUsuario.Size = new System.Drawing.Size(204, 184);
            this.btnUsuario.TabIndex = 0;
            this.btnUsuario.Click += new System.EventHandler(this.btnUsuario_Click);
            // 
            // btnMovimientos
            // 
            this.btnMovimientos.BackColor = System.Drawing.Color.DimGray;
            this.btnMovimientos.color = System.Drawing.Color.DimGray;
            this.btnMovimientos.colorActive = System.Drawing.Color.Gray;
            this.btnMovimientos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMovimientos.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.btnMovimientos.ForeColor = System.Drawing.Color.White;
            this.btnMovimientos.Image = ((System.Drawing.Image)(resources.GetObject("btnMovimientos.Image")));
            this.btnMovimientos.ImagePosition = 20;
            this.btnMovimientos.ImageZoom = 50;
            this.btnMovimientos.LabelPosition = 41;
            this.btnMovimientos.LabelText = "MOVIMIENTOS";
            this.btnMovimientos.Location = new System.Drawing.Point(126, 352);
            this.btnMovimientos.Margin = new System.Windows.Forms.Padding(6);
            this.btnMovimientos.Name = "btnMovimientos";
            this.btnMovimientos.Size = new System.Drawing.Size(204, 184);
            this.btnMovimientos.TabIndex = 0;
            this.btnMovimientos.Click += new System.EventHandler(this.btnMovimientos_Click);
            // 
            // btnProductos
            // 
            this.btnProductos.BackColor = System.Drawing.Color.DimGray;
            this.btnProductos.color = System.Drawing.Color.DimGray;
            this.btnProductos.colorActive = System.Drawing.Color.Gray;
            this.btnProductos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProductos.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.btnProductos.ForeColor = System.Drawing.Color.White;
            this.btnProductos.Image = ((System.Drawing.Image)(resources.GetObject("btnProductos.Image")));
            this.btnProductos.ImagePosition = 20;
            this.btnProductos.ImageZoom = 50;
            this.btnProductos.LabelPosition = 41;
            this.btnProductos.LabelText = "PRODUCTOS";
            this.btnProductos.Location = new System.Drawing.Point(576, 96);
            this.btnProductos.Margin = new System.Windows.Forms.Padding(6);
            this.btnProductos.Name = "btnProductos";
            this.btnProductos.Size = new System.Drawing.Size(204, 184);
            this.btnProductos.TabIndex = 0;
            this.btnProductos.Click += new System.EventHandler(this.btnProductos_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Arial Rounded MT Bold", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(12, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(838, 70);
            this.lblTitulo.TabIndex = 2;
            this.lblTitulo.Text = "Sistemas Control Inventario";
            // 
            // btnReportes
            // 
            this.btnReportes.BackColor = System.Drawing.Color.DimGray;
            this.btnReportes.color = System.Drawing.Color.DimGray;
            this.btnReportes.colorActive = System.Drawing.Color.Gray;
            this.btnReportes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReportes.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.btnReportes.ForeColor = System.Drawing.Color.White;
            this.btnReportes.Image = ((System.Drawing.Image)(resources.GetObject("btnReportes.Image")));
            this.btnReportes.ImagePosition = 20;
            this.btnReportes.ImageZoom = 50;
            this.btnReportes.LabelPosition = 41;
            this.btnReportes.LabelText = "REPORTES";
            this.btnReportes.Location = new System.Drawing.Point(587, 352);
            this.btnReportes.Margin = new System.Windows.Forms.Padding(6);
            this.btnReportes.Name = "btnReportes";
            this.btnReportes.Size = new System.Drawing.Size(204, 184);
            this.btnReportes.TabIndex = 0;
            this.btnReportes.Click += new System.EventHandler(this.btnReportes_Click);
            // 
            // btnCerrarSesion
            // 
            this.btnCerrarSesion.ActiveImage = null;
            this.btnCerrarSesion.AllowAnimations = true;
            this.btnCerrarSesion.AllowBuffering = false;
            this.btnCerrarSesion.AllowToggling = false;
            this.btnCerrarSesion.AllowZooming = true;
            this.btnCerrarSesion.AllowZoomingOnFocus = false;
            this.btnCerrarSesion.BackColor = System.Drawing.Color.Transparent;
            this.btnCerrarSesion.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnCerrarSesion.ErrorImage = ((System.Drawing.Image)(resources.GetObject("btnCerrarSesion.ErrorImage")));
            this.btnCerrarSesion.FadeWhenInactive = false;
            this.btnCerrarSesion.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.btnCerrarSesion.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrarSesion.Image")));
            this.btnCerrarSesion.ImageActive = null;
            this.btnCerrarSesion.ImageLocation = null;
            this.btnCerrarSesion.ImageMargin = 40;
            this.btnCerrarSesion.ImageSize = new System.Drawing.Size(50, 50);
            this.btnCerrarSesion.ImageZoomSize = new System.Drawing.Size(90, 90);
            this.btnCerrarSesion.InitialImage = ((System.Drawing.Image)(resources.GetObject("btnCerrarSesion.InitialImage")));
            this.btnCerrarSesion.Location = new System.Drawing.Point(935, 434);
            this.btnCerrarSesion.Name = "btnCerrarSesion";
            this.btnCerrarSesion.Rotation = 0;
            this.btnCerrarSesion.ShowActiveImage = true;
            this.btnCerrarSesion.ShowCursorChanges = true;
            this.btnCerrarSesion.ShowImageBorders = true;
            this.btnCerrarSesion.ShowSizeMarkers = false;
            this.btnCerrarSesion.Size = new System.Drawing.Size(90, 90);
            this.btnCerrarSesion.TabIndex = 3;
            this.btnCerrarSesion.ToolTipText = "";
            this.btnCerrarSesion.WaitOnLoad = false;
            this.btnCerrarSesion.Zoom = 40;
            this.btnCerrarSesion.ZoomSpeed = 10;
            this.btnCerrarSesion.Click += new System.EventHandler(this.btnCerrarSesion_Click);
            // 
            // lblSalir
            // 
            this.lblSalir.AutoSize = true;
            this.lblSalir.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalir.ForeColor = System.Drawing.Color.White;
            this.lblSalir.Location = new System.Drawing.Point(931, 527);
            this.lblSalir.Name = "lblSalir";
            this.lblSalir.Size = new System.Drawing.Size(96, 20);
            this.lblSalir.TabIndex = 2;
            this.lblSalir.Text = "Cerrar Sesión";
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(1057, 564);
            this.Controls.Add(this.btnCerrarSesion);
            this.Controls.Add(this.lblSalir);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.btnProductos);
            this.Controls.Add(this.btnReportes);
            this.Controls.Add(this.btnMovimientos);
            this.Controls.Add(this.btnUsuario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuTileButton btnUsuario;
        private Bunifu.Framework.UI.BunifuTileButton btnMovimientos;
        private Bunifu.Framework.UI.BunifuTileButton btnProductos;
        private System.Windows.Forms.Label lblTitulo;
        private Bunifu.Framework.UI.BunifuTileButton btnReportes;
        private Bunifu.UI.WinForms.BunifuImageButton btnCerrarSesion;
        private System.Windows.Forms.Label lblSalir;
    }
}

