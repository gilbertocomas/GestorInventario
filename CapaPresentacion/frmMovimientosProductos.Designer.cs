namespace CapaPresentacion
{
    partial class frmMovimientosProductos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMovimientosProductos));
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnCerrar = new Bunifu.UI.WinForms.BunifuImageButton();
            this.cbProducto = new System.Windows.Forms.ComboBox();
            this.lblProducto = new System.Windows.Forms.Label();
            this.txtCantidad = new Bunifu.UI.WinForms.BunifuTextBox();
            this.btnSustraer = new Bunifu.Framework.UI.BunifuTileButton();
            this.btnIngresar = new Bunifu.Framework.UI.BunifuTileButton();
            this.bdgvMovimientos = new Bunifu.UI.WinForms.BunifuDataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.bdgvMovimientos)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Arial Rounded MT Bold", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.SystemColors.Control;
            this.lblTitulo.Location = new System.Drawing.Point(0, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(713, 70);
            this.lblTitulo.TabIndex = 1;
            this.lblTitulo.Text = "Movimientos Productos";
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
            this.btnCerrar.Location = new System.Drawing.Point(977, 0);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Rotation = 0;
            this.btnCerrar.ShowActiveImage = true;
            this.btnCerrar.ShowCursorChanges = true;
            this.btnCerrar.ShowImageBorders = true;
            this.btnCerrar.ShowSizeMarkers = false;
            this.btnCerrar.Size = new System.Drawing.Size(80, 80);
            this.btnCerrar.TabIndex = 2;
            this.btnCerrar.ToolTipText = "";
            this.btnCerrar.WaitOnLoad = false;
            this.btnCerrar.Zoom = 40;
            this.btnCerrar.ZoomSpeed = 10;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // cbProducto
            // 
            this.cbProducto.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.cbProducto.DisplayMember = "(ninguno)";
            this.cbProducto.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbProducto.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbProducto.ForeColor = System.Drawing.Color.White;
            this.cbProducto.FormattingEnabled = true;
            this.cbProducto.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cbProducto.Items.AddRange(new object[] {
            "admin",
            "user"});
            this.cbProducto.Location = new System.Drawing.Point(25, 122);
            this.cbProducto.Name = "cbProducto";
            this.cbProducto.Size = new System.Drawing.Size(258, 28);
            this.cbProducto.TabIndex = 13;
            // 
            // lblProducto
            // 
            this.lblProducto.AutoSize = true;
            this.lblProducto.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProducto.ForeColor = System.Drawing.Color.White;
            this.lblProducto.Location = new System.Drawing.Point(21, 99);
            this.lblProducto.Name = "lblProducto";
            this.lblProducto.Size = new System.Drawing.Size(175, 20);
            this.lblProducto.TabIndex = 14;
            this.lblProducto.Text = "SELECCIONE PRODUCTO:";
            // 
            // txtCantidad
            // 
            this.txtCantidad.AcceptsReturn = false;
            this.txtCantidad.AcceptsTab = false;
            this.txtCantidad.AnimationSpeed = 200;
            this.txtCantidad.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtCantidad.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtCantidad.BackColor = System.Drawing.Color.DimGray;
            this.txtCantidad.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtCantidad.BackgroundImage")));
            this.txtCantidad.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.txtCantidad.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txtCantidad.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.txtCantidad.BorderColorIdle = System.Drawing.Color.Gainsboro;
            this.txtCantidad.BorderRadius = 15;
            this.txtCantidad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCantidad.BorderThickness = 1;
            this.txtCantidad.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtCantidad.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCantidad.DefaultFont = new System.Drawing.Font("Segoe UI", 9.25F);
            this.txtCantidad.DefaultText = "";
            this.txtCantidad.FillColor = System.Drawing.Color.DimGray;
            this.txtCantidad.ForeColor = System.Drawing.Color.White;
            this.txtCantidad.HideSelection = true;
            this.txtCantidad.IconLeft = null;
            this.txtCantidad.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCantidad.IconPadding = 10;
            this.txtCantidad.IconRight = null;
            this.txtCantidad.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCantidad.Lines = new string[0];
            this.txtCantidad.Location = new System.Drawing.Point(23, 198);
            this.txtCantidad.MaxLength = 32767;
            this.txtCantidad.MinimumSize = new System.Drawing.Size(2, 2);
            this.txtCantidad.Modified = false;
            this.txtCantidad.Multiline = false;
            this.txtCantidad.Name = "txtCantidad";
            stateProperties1.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties1.FillColor = System.Drawing.Color.Empty;
            stateProperties1.ForeColor = System.Drawing.Color.Empty;
            stateProperties1.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtCantidad.OnActiveState = stateProperties1;
            stateProperties2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties2.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txtCantidad.OnDisabledState = stateProperties2;
            stateProperties3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties3.FillColor = System.Drawing.Color.Empty;
            stateProperties3.ForeColor = System.Drawing.Color.Empty;
            stateProperties3.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtCantidad.OnHoverState = stateProperties3;
            stateProperties4.BorderColor = System.Drawing.Color.Gainsboro;
            stateProperties4.FillColor = System.Drawing.Color.DimGray;
            stateProperties4.ForeColor = System.Drawing.Color.White;
            stateProperties4.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtCantidad.OnIdleState = stateProperties4;
            this.txtCantidad.Padding = new System.Windows.Forms.Padding(3);
            this.txtCantidad.PasswordChar = '\0';
            this.txtCantidad.PlaceholderForeColor = System.Drawing.Color.White;
            this.txtCantidad.PlaceholderText = "CANTIDAD";
            this.txtCantidad.ReadOnly = false;
            this.txtCantidad.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtCantidad.SelectedText = "";
            this.txtCantidad.SelectionLength = 0;
            this.txtCantidad.SelectionStart = 0;
            this.txtCantidad.ShortcutsEnabled = true;
            this.txtCantidad.Size = new System.Drawing.Size(260, 41);
            this.txtCantidad.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.txtCantidad.TabIndex = 15;
            this.txtCantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtCantidad.TextMarginBottom = 0;
            this.txtCantidad.TextMarginLeft = 3;
            this.txtCantidad.TextMarginTop = 1;
            this.txtCantidad.TextPlaceholder = "CANTIDAD";
            this.txtCantidad.UseSystemPasswordChar = false;
            this.txtCantidad.WordWrap = true;
            // 
            // btnSustraer
            // 
            this.btnSustraer.BackColor = System.Drawing.Color.DarkRed;
            this.btnSustraer.color = System.Drawing.Color.DarkRed;
            this.btnSustraer.colorActive = System.Drawing.Color.Red;
            this.btnSustraer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSustraer.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSustraer.ForeColor = System.Drawing.Color.White;
            this.btnSustraer.Image = ((System.Drawing.Image)(resources.GetObject("btnSustraer.Image")));
            this.btnSustraer.ImagePosition = 14;
            this.btnSustraer.ImageZoom = 50;
            this.btnSustraer.LabelPosition = 29;
            this.btnSustraer.LabelText = "SUSTRAER";
            this.btnSustraer.Location = new System.Drawing.Point(630, 112);
            this.btnSustraer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSustraer.Name = "btnSustraer";
            this.btnSustraer.Size = new System.Drawing.Size(135, 115);
            this.btnSustraer.TabIndex = 17;
            this.btnSustraer.Click += new System.EventHandler(this.btnSustraer_Click);
            // 
            // btnIngresar
            // 
            this.btnIngresar.BackColor = System.Drawing.Color.SeaGreen;
            this.btnIngresar.color = System.Drawing.Color.SeaGreen;
            this.btnIngresar.colorActive = System.Drawing.Color.MediumSeaGreen;
            this.btnIngresar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnIngresar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIngresar.ForeColor = System.Drawing.Color.White;
            this.btnIngresar.Image = ((System.Drawing.Image)(resources.GetObject("btnIngresar.Image")));
            this.btnIngresar.ImagePosition = 14;
            this.btnIngresar.ImageZoom = 50;
            this.btnIngresar.LabelPosition = 29;
            this.btnIngresar.LabelText = "INGRESAR";
            this.btnIngresar.Location = new System.Drawing.Point(418, 112);
            this.btnIngresar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(135, 115);
            this.btnIngresar.TabIndex = 16;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // bdgvMovimientos
            // 
            this.bdgvMovimientos.AllowCustomTheming = false;
            this.bdgvMovimientos.AllowUserToAddRows = false;
            this.bdgvMovimientos.AllowUserToDeleteRows = false;
            this.bdgvMovimientos.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(48)))), ((int)(((byte)(52)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            this.bdgvMovimientos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.bdgvMovimientos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.bdgvMovimientos.BackgroundColor = System.Drawing.SystemColors.ControlDarkDark;
            this.bdgvMovimientos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.bdgvMovimientos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.bdgvMovimientos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(16)))), ((int)(((byte)(18)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.bdgvMovimientos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.bdgvMovimientos.ColumnHeadersHeight = 40;
            this.bdgvMovimientos.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(48)))), ((int)(((byte)(52)))));
            this.bdgvMovimientos.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.bdgvMovimientos.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.White;
            this.bdgvMovimientos.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(117)))), ((int)(((byte)(119)))));
            this.bdgvMovimientos.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            this.bdgvMovimientos.CurrentTheme.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(16)))), ((int)(((byte)(18)))));
            this.bdgvMovimientos.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(56)))), ((int)(((byte)(62)))));
            this.bdgvMovimientos.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(16)))), ((int)(((byte)(18)))));
            this.bdgvMovimientos.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            this.bdgvMovimientos.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.bdgvMovimientos.CurrentTheme.HeaderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.bdgvMovimientos.CurrentTheme.HeaderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.bdgvMovimientos.CurrentTheme.Name = null;
            this.bdgvMovimientos.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.bdgvMovimientos.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.bdgvMovimientos.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.White;
            this.bdgvMovimientos.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(117)))), ((int)(((byte)(119)))));
            this.bdgvMovimientos.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(117)))), ((int)(((byte)(119)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.bdgvMovimientos.DefaultCellStyle = dataGridViewCellStyle3;
            this.bdgvMovimientos.EnableHeadersVisualStyles = false;
            this.bdgvMovimientos.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(56)))), ((int)(((byte)(62)))));
            this.bdgvMovimientos.HeaderBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(16)))), ((int)(((byte)(18)))));
            this.bdgvMovimientos.HeaderBgColor = System.Drawing.Color.Empty;
            this.bdgvMovimientos.HeaderForeColor = System.Drawing.Color.White;
            this.bdgvMovimientos.Location = new System.Drawing.Point(1, 265);
            this.bdgvMovimientos.Name = "bdgvMovimientos";
            this.bdgvMovimientos.ReadOnly = true;
            this.bdgvMovimientos.RowHeadersVisible = false;
            this.bdgvMovimientos.RowHeadersWidth = 51;
            this.bdgvMovimientos.RowTemplate.Height = 40;
            this.bdgvMovimientos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.bdgvMovimientos.Size = new System.Drawing.Size(1056, 302);
            this.bdgvMovimientos.TabIndex = 19;
            this.bdgvMovimientos.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Dark;
            // 
            // frmMovimientosProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(1057, 564);
            this.Controls.Add(this.bdgvMovimientos);
            this.Controls.Add(this.btnSustraer);
            this.Controls.Add(this.btnIngresar);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.cbProducto);
            this.Controls.Add(this.lblProducto);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.lblTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMovimientosProductos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmMovimientosProductos";
            this.Load += new System.EventHandler(this.frmMovimientosProductos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bdgvMovimientos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblTitulo;
        private Bunifu.UI.WinForms.BunifuImageButton btnCerrar;
        private System.Windows.Forms.ComboBox cbProducto;
        private System.Windows.Forms.Label lblProducto;
        private Bunifu.UI.WinForms.BunifuTextBox txtCantidad;
        private Bunifu.Framework.UI.BunifuTileButton btnSustraer;
        private Bunifu.Framework.UI.BunifuTileButton btnIngresar;
        private Bunifu.UI.WinForms.BunifuDataGridView bdgvMovimientos;
    }
}