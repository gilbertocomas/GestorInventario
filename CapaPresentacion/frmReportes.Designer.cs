namespace CapaPresentacion
{
    partial class frmReportes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReportes));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnCerrar = new Bunifu.UI.WinForms.BunifuImageButton();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnIncremento = new Bunifu.UI.WinForms.BunifuImageButton();
            this.btnDecrementar = new Bunifu.UI.WinForms.BunifuImageButton();
            this.btnGeneral = new Bunifu.UI.WinForms.BunifuImageButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvReportes = new Bunifu.UI.WinForms.BunifuDataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReportes)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCerrar
            // 
            this.btnCerrar.ActiveImage = null;
            this.btnCerrar.AllowAnimations = true;
            this.btnCerrar.AllowBuffering = false;
            this.btnCerrar.AllowToggling = false;
            this.btnCerrar.AllowZooming = true;
            this.btnCerrar.AllowZoomingOnFocus = false;
            this.btnCerrar.BackColor = System.Drawing.Color.Transparent;
            this.btnCerrar.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnCerrar.ErrorImage = ((System.Drawing.Image)(resources.GetObject("btnCerrar.ErrorImage")));
            this.btnCerrar.FadeWhenInactive = false;
            this.btnCerrar.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.btnCerrar.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrar.Image")));
            this.btnCerrar.ImageActive = null;
            this.btnCerrar.ImageLocation = null;
            this.btnCerrar.ImageMargin = 40;
            this.btnCerrar.ImageSize = new System.Drawing.Size(40, 40);
            this.btnCerrar.ImageZoomSize = new System.Drawing.Size(80, 80);
            this.btnCerrar.InitialImage = ((System.Drawing.Image)(resources.GetObject("btnCerrar.InitialImage")));
            this.btnCerrar.Location = new System.Drawing.Point(960, 1);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Rotation = 0;
            this.btnCerrar.ShowActiveImage = true;
            this.btnCerrar.ShowCursorChanges = true;
            this.btnCerrar.ShowImageBorders = true;
            this.btnCerrar.ShowSizeMarkers = false;
            this.btnCerrar.Size = new System.Drawing.Size(80, 80);
            this.btnCerrar.TabIndex = 0;
            this.btnCerrar.ToolTipText = "";
            this.btnCerrar.WaitOnLoad = false;
            this.btnCerrar.Zoom = 40;
            this.btnCerrar.ZoomSpeed = 10;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Arial Rounded MT Bold", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.SystemColors.Control;
            this.lblTitulo.Location = new System.Drawing.Point(-1, 1);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(656, 70);
            this.lblTitulo.TabIndex = 1;
            this.lblTitulo.Text = "Generación Reportes";
            // 
            // btnIncremento
            // 
            this.btnIncremento.ActiveImage = null;
            this.btnIncremento.AllowAnimations = true;
            this.btnIncremento.AllowBuffering = false;
            this.btnIncremento.AllowToggling = false;
            this.btnIncremento.AllowZooming = true;
            this.btnIncremento.AllowZoomingOnFocus = false;
            this.btnIncremento.BackColor = System.Drawing.Color.Transparent;
            this.btnIncremento.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnIncremento.ErrorImage = ((System.Drawing.Image)(resources.GetObject("btnIncremento.ErrorImage")));
            this.btnIncremento.FadeWhenInactive = false;
            this.btnIncremento.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.btnIncremento.Image = ((System.Drawing.Image)(resources.GetObject("btnIncremento.Image")));
            this.btnIncremento.ImageActive = null;
            this.btnIncremento.ImageLocation = null;
            this.btnIncremento.ImageMargin = 40;
            this.btnIncremento.ImageSize = new System.Drawing.Size(60, 60);
            this.btnIncremento.ImageZoomSize = new System.Drawing.Size(100, 100);
            this.btnIncremento.InitialImage = ((System.Drawing.Image)(resources.GetObject("btnIncremento.InitialImage")));
            this.btnIncremento.Location = new System.Drawing.Point(82, 91);
            this.btnIncremento.Name = "btnIncremento";
            this.btnIncremento.Rotation = 0;
            this.btnIncremento.ShowActiveImage = true;
            this.btnIncremento.ShowCursorChanges = true;
            this.btnIncremento.ShowImageBorders = true;
            this.btnIncremento.ShowSizeMarkers = false;
            this.btnIncremento.Size = new System.Drawing.Size(100, 100);
            this.btnIncremento.TabIndex = 2;
            this.btnIncremento.ToolTipText = "REPORTE INCREMENTO";
            this.btnIncremento.WaitOnLoad = false;
            this.btnIncremento.Zoom = 40;
            this.btnIncremento.ZoomSpeed = 10;
            this.btnIncremento.Click += new System.EventHandler(this.btnIncremento_Click);
            // 
            // btnDecrementar
            // 
            this.btnDecrementar.ActiveImage = null;
            this.btnDecrementar.AllowAnimations = true;
            this.btnDecrementar.AllowBuffering = false;
            this.btnDecrementar.AllowToggling = false;
            this.btnDecrementar.AllowZooming = true;
            this.btnDecrementar.AllowZoomingOnFocus = false;
            this.btnDecrementar.BackColor = System.Drawing.Color.Transparent;
            this.btnDecrementar.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnDecrementar.ErrorImage = ((System.Drawing.Image)(resources.GetObject("btnDecrementar.ErrorImage")));
            this.btnDecrementar.FadeWhenInactive = false;
            this.btnDecrementar.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.btnDecrementar.Image = ((System.Drawing.Image)(resources.GetObject("btnDecrementar.Image")));
            this.btnDecrementar.ImageActive = null;
            this.btnDecrementar.ImageLocation = null;
            this.btnDecrementar.ImageMargin = 40;
            this.btnDecrementar.ImageSize = new System.Drawing.Size(60, 60);
            this.btnDecrementar.ImageZoomSize = new System.Drawing.Size(100, 100);
            this.btnDecrementar.InitialImage = ((System.Drawing.Image)(resources.GetObject("btnDecrementar.InitialImage")));
            this.btnDecrementar.Location = new System.Drawing.Point(451, 91);
            this.btnDecrementar.Name = "btnDecrementar";
            this.btnDecrementar.Rotation = 0;
            this.btnDecrementar.ShowActiveImage = true;
            this.btnDecrementar.ShowCursorChanges = true;
            this.btnDecrementar.ShowImageBorders = true;
            this.btnDecrementar.ShowSizeMarkers = false;
            this.btnDecrementar.Size = new System.Drawing.Size(100, 100);
            this.btnDecrementar.TabIndex = 2;
            this.btnDecrementar.ToolTipText = "REPORTE INCREMENTO";
            this.btnDecrementar.WaitOnLoad = false;
            this.btnDecrementar.Zoom = 40;
            this.btnDecrementar.ZoomSpeed = 10;
            this.btnDecrementar.Click += new System.EventHandler(this.bunifuImageButton1_Click);
            // 
            // btnGeneral
            // 
            this.btnGeneral.ActiveImage = null;
            this.btnGeneral.AllowAnimations = true;
            this.btnGeneral.AllowBuffering = false;
            this.btnGeneral.AllowToggling = false;
            this.btnGeneral.AllowZooming = true;
            this.btnGeneral.AllowZoomingOnFocus = false;
            this.btnGeneral.BackColor = System.Drawing.Color.Transparent;
            this.btnGeneral.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnGeneral.ErrorImage = ((System.Drawing.Image)(resources.GetObject("btnGeneral.ErrorImage")));
            this.btnGeneral.FadeWhenInactive = false;
            this.btnGeneral.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.btnGeneral.Image = ((System.Drawing.Image)(resources.GetObject("btnGeneral.Image")));
            this.btnGeneral.ImageActive = null;
            this.btnGeneral.ImageLocation = null;
            this.btnGeneral.ImageMargin = 40;
            this.btnGeneral.ImageSize = new System.Drawing.Size(60, 60);
            this.btnGeneral.ImageZoomSize = new System.Drawing.Size(100, 100);
            this.btnGeneral.InitialImage = ((System.Drawing.Image)(resources.GetObject("btnGeneral.InitialImage")));
            this.btnGeneral.Location = new System.Drawing.Point(806, 91);
            this.btnGeneral.Name = "btnGeneral";
            this.btnGeneral.Rotation = 0;
            this.btnGeneral.ShowActiveImage = true;
            this.btnGeneral.ShowCursorChanges = true;
            this.btnGeneral.ShowImageBorders = true;
            this.btnGeneral.ShowSizeMarkers = false;
            this.btnGeneral.Size = new System.Drawing.Size(100, 100);
            this.btnGeneral.TabIndex = 2;
            this.btnGeneral.ToolTipText = "REPORTE INCREMENTO";
            this.btnGeneral.WaitOnLoad = false;
            this.btnGeneral.Zoom = 40;
            this.btnGeneral.ZoomSpeed = 10;
            this.btnGeneral.Click += new System.EventHandler(this.btnGeneral_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(416, 194);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "DECREMENTO PRODUCTO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(39, 194);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(190, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "INCREMENTO PRODUCTO";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(763, 194);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(214, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "PRODUCTOS MAS VENDIDOS";
            // 
            // dgvReportes
            // 
            this.dgvReportes.AllowCustomTheming = false;
            this.dgvReportes.AllowUserToAddRows = false;
            this.dgvReportes.AllowUserToDeleteRows = false;
            this.dgvReportes.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(48)))), ((int)(((byte)(52)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            this.dgvReportes.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvReportes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvReportes.BackgroundColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dgvReportes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvReportes.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvReportes.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(16)))), ((int)(((byte)(18)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvReportes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvReportes.ColumnHeadersHeight = 40;
            this.dgvReportes.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(48)))), ((int)(((byte)(52)))));
            this.dgvReportes.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.dgvReportes.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.White;
            this.dgvReportes.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(117)))), ((int)(((byte)(119)))));
            this.dgvReportes.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            this.dgvReportes.CurrentTheme.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(16)))), ((int)(((byte)(18)))));
            this.dgvReportes.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(56)))), ((int)(((byte)(62)))));
            this.dgvReportes.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(16)))), ((int)(((byte)(18)))));
            this.dgvReportes.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            this.dgvReportes.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvReportes.CurrentTheme.HeaderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.dgvReportes.CurrentTheme.HeaderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dgvReportes.CurrentTheme.Name = null;
            this.dgvReportes.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.dgvReportes.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.dgvReportes.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.White;
            this.dgvReportes.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(117)))), ((int)(((byte)(119)))));
            this.dgvReportes.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(117)))), ((int)(((byte)(119)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvReportes.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvReportes.EnableHeadersVisualStyles = false;
            this.dgvReportes.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(56)))), ((int)(((byte)(62)))));
            this.dgvReportes.HeaderBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(16)))), ((int)(((byte)(18)))));
            this.dgvReportes.HeaderBgColor = System.Drawing.Color.Empty;
            this.dgvReportes.HeaderForeColor = System.Drawing.Color.White;
            this.dgvReportes.Location = new System.Drawing.Point(1, 232);
            this.dgvReportes.Name = "dgvReportes";
            this.dgvReportes.ReadOnly = true;
            this.dgvReportes.RowHeadersVisible = false;
            this.dgvReportes.RowHeadersWidth = 51;
            this.dgvReportes.RowTemplate.Height = 40;
            this.dgvReportes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvReportes.Size = new System.Drawing.Size(1039, 415);
            this.dgvReportes.TabIndex = 4;
            this.dgvReportes.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Dark;
            // 
            // frmReportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(1039, 647);
            this.Controls.Add(this.dgvReportes);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnGeneral);
            this.Controls.Add(this.btnDecrementar);
            this.Controls.Add(this.btnIncremento);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.btnCerrar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmReportes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmReportes";
            ((System.ComponentModel.ISupportInitialize)(this.dgvReportes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuImageButton btnCerrar;
        private System.Windows.Forms.Label lblTitulo;
        private Bunifu.UI.WinForms.BunifuImageButton btnIncremento;
        private Bunifu.UI.WinForms.BunifuImageButton btnDecrementar;
        private Bunifu.UI.WinForms.BunifuImageButton btnGeneral;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private Bunifu.UI.WinForms.BunifuDataGridView dgvReportes;
    }
}