namespace HPReserger
{
    partial class frmCargosVentas
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCargosVentas));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dtgconten = new HpResergerUserControls.Dtgconten();
            this.idcargox = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cargox = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Usuariox = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fechax = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnmodificar = new System.Windows.Forms.Button();
            this.dtgbusca = new HpResergerUserControls.Dtgconten();
            this.idcargoy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cargosy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ususarioy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtBuscar = new HpResergerUserControls.txtBuscar();
            this.btncancelar = new System.Windows.Forms.Button();
            this.btnaceptar = new System.Windows.Forms.Button();
            this.btnaddgroup = new System.Windows.Forms.Button();
            this.btnaddselected = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgconten)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgbusca)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgconten
            // 
            this.dtgconten.AllowUserToAddRows = false;
            this.dtgconten.AllowUserToDeleteRows = false;
            this.dtgconten.AllowUserToOrderColumns = true;
            this.dtgconten.AllowUserToResizeColumns = false;
            this.dtgconten.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(230)))), ((int)(((byte)(241)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(191)))), ((int)(((byte)(231)))));
            this.dtgconten.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgconten.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgconten.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgconten.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(218)))), ((int)(((byte)(231)))));
            this.dtgconten.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dtgconten.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.dtgconten.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(129)))), ((int)(((byte)(189)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DeepSkyBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgconten.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dtgconten.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dtgconten.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idcargox,
            this.cargox,
            this.Usuariox,
            this.Fechax});
            this.dtgconten.Cursor = System.Windows.Forms.Cursors.Default;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(207)))), ((int)(((byte)(241)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgconten.DefaultCellStyle = dataGridViewCellStyle3;
            this.dtgconten.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dtgconten.EnableHeadersVisualStyles = false;
            this.dtgconten.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(179)))), ((int)(((byte)(215)))));
            this.dtgconten.Location = new System.Drawing.Point(12, 317);
            this.dtgconten.Name = "dtgconten";
            this.dtgconten.ReadOnly = true;
            this.dtgconten.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dtgconten.RowHeadersVisible = false;
            this.dtgconten.RowTemplate.Height = 16;
            this.dtgconten.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dtgconten.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgconten.Size = new System.Drawing.Size(675, 265);
            this.dtgconten.TabIndex = 68;
            this.dtgconten.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dtgconten_KeyDown);
            // 
            // idcargox
            // 
            this.idcargox.DataPropertyName = "Cargo";
            this.idcargox.HeaderText = "Cargo";
            this.idcargox.Name = "idcargox";
            this.idcargox.ReadOnly = true;
            this.idcargox.Visible = false;
            // 
            // cargox
            // 
            this.cargox.DataPropertyName = "cargos";
            this.cargox.HeaderText = "Cargo";
            this.cargox.Name = "cargox";
            this.cargox.ReadOnly = true;
            // 
            // Usuariox
            // 
            this.Usuariox.DataPropertyName = "Usuario";
            this.Usuariox.HeaderText = "Usuario";
            this.Usuariox.Name = "Usuariox";
            this.Usuariox.ReadOnly = true;
            this.Usuariox.Visible = false;
            // 
            // Fechax
            // 
            this.Fechax.DataPropertyName = "Fecha";
            this.Fechax.HeaderText = "Fecha";
            this.Fechax.Name = "Fechax";
            this.Fechax.ReadOnly = true;
            this.Fechax.Visible = false;
            // 
            // btnmodificar
            // 
            this.btnmodificar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnmodificar.Image = ((System.Drawing.Image)(resources.GetObject("btnmodificar.Image")));
            this.btnmodificar.Location = new System.Drawing.Point(555, 12);
            this.btnmodificar.Name = "btnmodificar";
            this.btnmodificar.Size = new System.Drawing.Size(132, 25);
            this.btnmodificar.TabIndex = 80;
            this.btnmodificar.Text = "Modificar";
            this.btnmodificar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnmodificar.UseVisualStyleBackColor = true;
            this.btnmodificar.Click += new System.EventHandler(this.btnmodificar_Click);
            // 
            // dtgbusca
            // 
            this.dtgbusca.AllowUserToAddRows = false;
            this.dtgbusca.AllowUserToDeleteRows = false;
            this.dtgbusca.AllowUserToOrderColumns = true;
            this.dtgbusca.AllowUserToResizeColumns = false;
            this.dtgbusca.AllowUserToResizeRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(230)))), ((int)(((byte)(241)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(191)))), ((int)(((byte)(231)))));
            this.dtgbusca.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dtgbusca.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgbusca.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgbusca.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(218)))), ((int)(((byte)(231)))));
            this.dtgbusca.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dtgbusca.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.dtgbusca.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(129)))), ((int)(((byte)(189)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.DeepSkyBlue;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgbusca.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dtgbusca.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dtgbusca.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idcargoy,
            this.cargosy,
            this.ususarioy,
            this.fechay});
            this.dtgbusca.Cursor = System.Windows.Forms.Cursors.Default;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(207)))), ((int)(((byte)(241)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgbusca.DefaultCellStyle = dataGridViewCellStyle6;
            this.dtgbusca.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnF2;
            this.dtgbusca.EnableHeadersVisualStyles = false;
            this.dtgbusca.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(179)))), ((int)(((byte)(215)))));
            this.dtgbusca.Location = new System.Drawing.Point(12, 41);
            this.dtgbusca.MultiSelect = false;
            this.dtgbusca.Name = "dtgbusca";
            this.dtgbusca.ReadOnly = true;
            this.dtgbusca.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dtgbusca.RowHeadersVisible = false;
            this.dtgbusca.RowTemplate.Height = 16;
            this.dtgbusca.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dtgbusca.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgbusca.Size = new System.Drawing.Size(675, 243);
            this.dtgbusca.TabIndex = 81;
            // 
            // idcargoy
            // 
            this.idcargoy.DataPropertyName = "id_cargo";
            this.idcargoy.HeaderText = "idcargo";
            this.idcargoy.Name = "idcargoy";
            this.idcargoy.ReadOnly = true;
            this.idcargoy.Visible = false;
            // 
            // cargosy
            // 
            this.cargosy.DataPropertyName = "Cargo";
            this.cargosy.HeaderText = "Cargos";
            this.cargosy.Name = "cargosy";
            this.cargosy.ReadOnly = true;
            // 
            // ususarioy
            // 
            this.ususarioy.DataPropertyName = "Usuario";
            this.ususarioy.HeaderText = "Usuario";
            this.ususarioy.Name = "ususarioy";
            this.ususarioy.ReadOnly = true;
            this.ususarioy.Visible = false;
            // 
            // fechay
            // 
            this.fechay.DataPropertyName = "Fecha";
            this.fechay.HeaderText = "Fecha";
            this.fechay.Name = "fechay";
            this.fechay.ReadOnly = true;
            this.fechay.Visible = false;
            // 
            // txtBuscar
            // 
            this.txtBuscar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.txtBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(218)))), ((int)(((byte)(231)))));
            this.txtBuscar.FondoBoton = ((System.Drawing.Image)(resources.GetObject("txtBuscar.FondoBoton")));
            this.txtBuscar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscar.ImgBotonCerrar = null;
            this.txtBuscar.Location = new System.Drawing.Point(12, 12);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(537, 25);
            this.txtBuscar.TabIndex = 82;
            this.txtBuscar.BuscarClick += new System.EventHandler(this.txtBuscar_BuscarTextChanged);
            this.txtBuscar.BuscarTextChanged += new System.EventHandler(this.txtBuscar_BuscarTextChanged);
            // 
            // btncancelar
            // 
            this.btncancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btncancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btncancelar.Image = ((System.Drawing.Image)(resources.GetObject("btncancelar.Image")));
            this.btncancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btncancelar.Location = new System.Drawing.Point(555, 589);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(132, 25);
            this.btncancelar.TabIndex = 83;
            this.btncancelar.Text = "Cancelar";
            this.btncancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btncancelar.UseVisualStyleBackColor = true;
            this.btncancelar.Click += new System.EventHandler(this.btncancelar_Click);
            // 
            // btnaceptar
            // 
            this.btnaceptar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnaceptar.Enabled = false;
            this.btnaceptar.Image = ((System.Drawing.Image)(resources.GetObject("btnaceptar.Image")));
            this.btnaceptar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnaceptar.Location = new System.Drawing.Point(417, 589);
            this.btnaceptar.Name = "btnaceptar";
            this.btnaceptar.Size = new System.Drawing.Size(132, 25);
            this.btnaceptar.TabIndex = 84;
            this.btnaceptar.Text = "Aceptar";
            this.btnaceptar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnaceptar.UseVisualStyleBackColor = true;
            this.btnaceptar.Click += new System.EventHandler(this.btnaceptar_Click);
            // 
            // btnaddgroup
            // 
            this.btnaddgroup.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnaddgroup.Enabled = false;
            this.btnaddgroup.Image = ((System.Drawing.Image)(resources.GetObject("btnaddgroup.Image")));
            this.btnaddgroup.Location = new System.Drawing.Point(555, 288);
            this.btnaddgroup.Name = "btnaddgroup";
            this.btnaddgroup.Size = new System.Drawing.Size(132, 25);
            this.btnaddgroup.TabIndex = 154;
            this.btnaddgroup.Text = "Agregar Todo";
            this.btnaddgroup.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnaddgroup.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnaddgroup.UseVisualStyleBackColor = true;
            this.btnaddgroup.Click += new System.EventHandler(this.btnaddgroup_Click);
            // 
            // btnaddselected
            // 
            this.btnaddselected.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnaddselected.Enabled = false;
            this.btnaddselected.Image = ((System.Drawing.Image)(resources.GetObject("btnaddselected.Image")));
            this.btnaddselected.Location = new System.Drawing.Point(417, 288);
            this.btnaddselected.Name = "btnaddselected";
            this.btnaddselected.Size = new System.Drawing.Size(132, 25);
            this.btnaddselected.TabIndex = 153;
            this.btnaddselected.Text = "Agregar Selección";
            this.btnaddselected.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnaddselected.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnaddselected.UseVisualStyleBackColor = true;
            this.btnaddselected.Click += new System.EventHandler(this.btnaddselected_Click);
            // 
            // frmCargosVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(699, 621);
            this.Controls.Add(this.btnaddgroup);
            this.Controls.Add(this.btnaddselected);
            this.Controls.Add(this.btncancelar);
            this.Controls.Add(this.btnaceptar);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.dtgbusca);
            this.Controls.Add(this.btnmodificar);
            this.Controls.Add(this.dtgconten);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinimumSize = new System.Drawing.Size(715, 660);
            this.Name = "frmCargosVentas";
            this.Nombre = "Cargos de Venta";
            this.Text = "Cargos de Venta";
            this.Load += new System.EventHandler(this.frmCargosVentas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgconten)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgbusca)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private HpResergerUserControls.Dtgconten dtgconten;
        private System.Windows.Forms.Button btnmodificar;
        private HpResergerUserControls.Dtgconten dtgbusca;
        private HpResergerUserControls.txtBuscar txtBuscar;
        private System.Windows.Forms.Button btncancelar;
        private System.Windows.Forms.Button btnaceptar;
        private System.Windows.Forms.Button btnaddgroup;
        private System.Windows.Forms.Button btnaddselected;
        private System.Windows.Forms.DataGridViewTextBoxColumn idcargox;
        private System.Windows.Forms.DataGridViewTextBoxColumn cargox;
        private System.Windows.Forms.DataGridViewTextBoxColumn Usuariox;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fechax;
        private System.Windows.Forms.DataGridViewTextBoxColumn idcargoy;
        private System.Windows.Forms.DataGridViewTextBoxColumn cargosy;
        private System.Windows.Forms.DataGridViewTextBoxColumn ususarioy;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechay;
    }
}