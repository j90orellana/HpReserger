namespace HPReserger
{
    partial class frmComprobantePago
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmComprobantePago));
            this.dtgconten = new HpResergerUserControls.Dtgconten();
            this.id_comprobantex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codiosunatx = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombrex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usuariox = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechax = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtcodigo = new HpResergerUserControls.TextBoxPer();
            this.txtdescripcion = new HpResergerUserControls.TextBoxPer();
            this.btnaceptar = new System.Windows.Forms.Button();
            this.btncancelar = new System.Windows.Forms.Button();
            this.btnmodificar = new System.Windows.Forms.Button();
            this.btnnuevo = new System.Windows.Forms.Button();
            this.btnactualizar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtcodigosunat = new HpResergerUserControls.TextBoxPer();
            this.txtBuscar = new HpResergerUserControls.txtBuscar();
            ((System.ComponentModel.ISupportInitialize)(this.dtgconten)).BeginInit();
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
            this.dtgconten.BorderStyle = System.Windows.Forms.BorderStyle.None;
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
            this.id_comprobantex,
            this.codiosunatx,
            this.nombrex,
            this.usuariox,
            this.fechax});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(207)))), ((int)(((byte)(241)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgconten.DefaultCellStyle = dataGridViewCellStyle3;
            this.dtgconten.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dtgconten.EnableHeadersVisualStyles = false;
            this.dtgconten.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(179)))), ((int)(((byte)(215)))));
            this.dtgconten.Location = new System.Drawing.Point(11, 91);
            this.dtgconten.Name = "dtgconten";
            this.dtgconten.ReadOnly = true;
            this.dtgconten.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dtgconten.RowHeadersVisible = false;
            this.dtgconten.RowTemplate.Height = 18;
            this.dtgconten.Size = new System.Drawing.Size(544, 346);
            this.dtgconten.TabIndex = 0;
            this.dtgconten.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgconten_CellContentDoubleClick);
            this.dtgconten.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgconten_RowEnter);
            this.dtgconten.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dtgconten_RowsAdded);
            this.dtgconten.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.dtgconten_RowsRemoved);
            // 
            // id_comprobantex
            // 
            this.id_comprobantex.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.id_comprobantex.DataPropertyName = "id_comprobante";
            this.id_comprobantex.HeaderText = "CÓDIGO";
            this.id_comprobantex.MinimumWidth = 65;
            this.id_comprobantex.Name = "id_comprobantex";
            this.id_comprobantex.ReadOnly = true;
            this.id_comprobantex.Visible = false;
            // 
            // codiosunatx
            // 
            this.codiosunatx.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.codiosunatx.DataPropertyName = "COD_SUNAT";
            this.codiosunatx.HeaderText = "CÓDIGO SUNAT";
            this.codiosunatx.MinimumWidth = 100;
            this.codiosunatx.Name = "codiosunatx";
            this.codiosunatx.ReadOnly = true;
            // 
            // nombrex
            // 
            this.nombrex.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nombrex.DataPropertyName = "nombre";
            this.nombrex.HeaderText = "DESCRIPCIÓN";
            this.nombrex.MinimumWidth = 100;
            this.nombrex.Name = "nombrex";
            this.nombrex.ReadOnly = true;
            // 
            // usuariox
            // 
            this.usuariox.DataPropertyName = "usuario";
            this.usuariox.HeaderText = "Usuario";
            this.usuariox.Name = "usuariox";
            this.usuariox.ReadOnly = true;
            this.usuariox.Visible = false;
            // 
            // fechax
            // 
            this.fechax.DataPropertyName = "fecha";
            this.fechax.HeaderText = "Fecha";
            this.fechax.Name = "fechax";
            this.fechax.ReadOnly = true;
            this.fechax.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(11, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Descripción:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(33, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Código:";
            // 
            // txtcodigo
            // 
            this.txtcodigo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(218)))), ((int)(((byte)(231)))));
            this.txtcodigo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtcodigo.ColorFondoMouseEncima = System.Drawing.Color.Empty;
            this.txtcodigo.ColorFondoMousePresionado = System.Drawing.Color.Empty;
            this.txtcodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.txtcodigo.ForeColor = System.Drawing.Color.Black;
            this.txtcodigo.Location = new System.Drawing.Point(87, 12);
            this.txtcodigo.MaxLength = 100;
            this.txtcodigo.Name = "txtcodigo";
            this.txtcodigo.NextControlOnEnter = null;
            this.txtcodigo.ReadOnly = true;
            this.txtcodigo.Size = new System.Drawing.Size(74, 20);
            this.txtcodigo.TabIndex = 2;
            this.txtcodigo.Text = "0";
            this.txtcodigo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtcodigo.TextoDefecto = "0";
            this.txtcodigo.TextoDefectoColor = System.Drawing.Color.White;
            this.txtcodigo.TiposDatos = HpResergerUserControls.TextBoxPer.ListaTipos.Todo;
            // 
            // txtdescripcion
            // 
            this.txtdescripcion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtdescripcion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(218)))), ((int)(((byte)(231)))));
            this.txtdescripcion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtdescripcion.ColorFondoMouseEncima = System.Drawing.Color.Empty;
            this.txtdescripcion.ColorFondoMousePresionado = System.Drawing.Color.Empty;
            this.txtdescripcion.Enabled = false;
            this.txtdescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.txtdescripcion.ForeColor = System.Drawing.Color.Black;
            this.txtdescripcion.Location = new System.Drawing.Point(87, 37);
            this.txtdescripcion.MaxLength = 100;
            this.txtdescripcion.Name = "txtdescripcion";
            this.txtdescripcion.NextControlOnEnter = this.btnaceptar;
            this.txtdescripcion.Size = new System.Drawing.Size(468, 20);
            this.txtdescripcion.TabIndex = 3;
            this.txtdescripcion.Text = "Ingrese Descripción";
            this.txtdescripcion.TextoDefecto = "Ingrese Descripción";
            this.txtdescripcion.TextoDefectoColor = System.Drawing.Color.White;
            this.txtdescripcion.TiposDatos = HpResergerUserControls.TextBoxPer.ListaTipos.Todo;
            // 
            // btnaceptar
            // 
            this.btnaceptar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnaceptar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(218)))), ((int)(((byte)(231)))));
            this.btnaceptar.Enabled = false;
            this.btnaceptar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(129)))), ((int)(((byte)(189)))));
            this.btnaceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnaceptar.Image = ((System.Drawing.Image)(resources.GetObject("btnaceptar.Image")));
            this.btnaceptar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnaceptar.Location = new System.Drawing.Point(561, 388);
            this.btnaceptar.Name = "btnaceptar";
            this.btnaceptar.Size = new System.Drawing.Size(82, 24);
            this.btnaceptar.TabIndex = 71;
            this.btnaceptar.Text = "Aceptar";
            this.btnaceptar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnaceptar.UseVisualStyleBackColor = false;
            this.btnaceptar.Click += new System.EventHandler(this.btnaceptar_Click);
            // 
            // btncancelar
            // 
            this.btncancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btncancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btncancelar.Image = ((System.Drawing.Image)(resources.GetObject("btncancelar.Image")));
            this.btncancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btncancelar.Location = new System.Drawing.Point(561, 413);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(82, 24);
            this.btncancelar.TabIndex = 70;
            this.btncancelar.Text = "Cancelar";
            this.btncancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btncancelar.UseVisualStyleBackColor = true;
            this.btncancelar.Click += new System.EventHandler(this.btncancelar_Click);
            // 
            // btnmodificar
            // 
            this.btnmodificar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnmodificar.BackColor = System.Drawing.SystemColors.Control;
            this.btnmodificar.Enabled = false;
            this.btnmodificar.ForeColor = System.Drawing.Color.Black;
            this.btnmodificar.Image = ((System.Drawing.Image)(resources.GetObject("btnmodificar.Image")));
            this.btnmodificar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnmodificar.Location = new System.Drawing.Point(561, 35);
            this.btnmodificar.Name = "btnmodificar";
            this.btnmodificar.Size = new System.Drawing.Size(82, 24);
            this.btnmodificar.TabIndex = 69;
            this.btnmodificar.Text = "Modificar";
            this.btnmodificar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnmodificar.UseVisualStyleBackColor = true;
            this.btnmodificar.Click += new System.EventHandler(this.btnmodificar_Click);
            // 
            // btnnuevo
            // 
            this.btnnuevo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnnuevo.BackColor = System.Drawing.SystemColors.Control;
            this.btnnuevo.ForeColor = System.Drawing.Color.Black;
            this.btnnuevo.Image = ((System.Drawing.Image)(resources.GetObject("btnnuevo.Image")));
            this.btnnuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnnuevo.Location = new System.Drawing.Point(561, 10);
            this.btnnuevo.Name = "btnnuevo";
            this.btnnuevo.Size = new System.Drawing.Size(82, 24);
            this.btnnuevo.TabIndex = 68;
            this.btnnuevo.Text = "Nuevo";
            this.btnnuevo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnnuevo.UseVisualStyleBackColor = true;
            this.btnnuevo.Click += new System.EventHandler(this.btnnuevo_Click);
            // 
            // btnactualizar
            // 
            this.btnactualizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnactualizar.BackColor = System.Drawing.SystemColors.Control;
            this.btnactualizar.ForeColor = System.Drawing.Color.Black;
            this.btnactualizar.Image = ((System.Drawing.Image)(resources.GetObject("btnactualizar.Image")));
            this.btnactualizar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnactualizar.Location = new System.Drawing.Point(561, 61);
            this.btnactualizar.Name = "btnactualizar";
            this.btnactualizar.Size = new System.Drawing.Size(82, 24);
            this.btnactualizar.TabIndex = 72;
            this.btnactualizar.Text = "Actualizar";
            this.btnactualizar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnactualizar.UseVisualStyleBackColor = true;
            this.btnactualizar.Click += new System.EventHandler(this.btnactualizar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(167, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 13);
            this.label3.TabIndex = 73;
            this.label3.Text = "Código Sunat:";
            // 
            // txtcodigosunat
            // 
            this.txtcodigosunat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(218)))), ((int)(((byte)(231)))));
            this.txtcodigosunat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtcodigosunat.ColorFondoMouseEncima = System.Drawing.Color.Empty;
            this.txtcodigosunat.ColorFondoMousePresionado = System.Drawing.Color.Empty;
            this.txtcodigosunat.Enabled = false;
            this.txtcodigosunat.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.txtcodigosunat.ForeColor = System.Drawing.Color.Black;
            this.txtcodigosunat.Location = new System.Drawing.Point(254, 12);
            this.txtcodigosunat.MaxLength = 100;
            this.txtcodigosunat.Name = "txtcodigosunat";
            this.txtcodigosunat.NextControlOnEnter = null;
            this.txtcodigosunat.ReadOnly = true;
            this.txtcodigosunat.Size = new System.Drawing.Size(128, 20);
            this.txtcodigosunat.TabIndex = 74;
            this.txtcodigosunat.Text = "0";
            this.txtcodigosunat.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtcodigosunat.TextoDefecto = "0";
            this.txtcodigosunat.TextoDefectoColor = System.Drawing.Color.White;
            this.txtcodigosunat.TiposDatos = HpResergerUserControls.TextBoxPer.ListaTipos.SoloNumeros;
            // 
            // txtBuscar
            // 
            this.txtBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBuscar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.txtBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(218)))), ((int)(((byte)(231)))));
            this.txtBuscar.FondoBoton = ((System.Drawing.Image)(resources.GetObject("txtBuscar.FondoBoton")));
            this.txtBuscar.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscar.ForeColor = System.Drawing.Color.Black;
            this.txtBuscar.ImgBotonCerrar = null;
            this.txtBuscar.Location = new System.Drawing.Point(14, 63);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(541, 22);
            this.txtBuscar.TabIndex = 75;
            this.txtBuscar.BuscarClick += new System.EventHandler(this.txtBuscar_BuscarClick);
            this.txtBuscar.ClickLimpiarboton += new System.EventHandler(this.txtBuscar_ClickLimpiarboton);
            this.txtBuscar.BuscarTextChanged += new System.EventHandler(this.txtBuscar_BuscarClick);
            // 
            // frmComprobantePago
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(651, 449);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.txtcodigosunat);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnactualizar);
            this.Controls.Add(this.btncancelar);
            this.Controls.Add(this.btnaceptar);
            this.Controls.Add(this.btnmodificar);
            this.Controls.Add(this.btnnuevo);
            this.Controls.Add(this.txtdescripcion);
            this.Controls.Add(this.txtcodigo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtgconten);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinimumSize = new System.Drawing.Size(667, 488);
            this.Name = "frmComprobantePago";
            this.Nombre = "Comprobantes de Pago";
            this.Text = "Comprobantes de Pago";
            this.Load += new System.EventHandler(this.frmComprobantePago_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgconten)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private HpResergerUserControls.Dtgconten dtgconten;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private HpResergerUserControls.TextBoxPer txtcodigo;
        private HpResergerUserControls.TextBoxPer txtdescripcion;
        public System.Windows.Forms.Button btncancelar;
        public System.Windows.Forms.Button btnaceptar;
        private System.Windows.Forms.Button btnmodificar;
        private System.Windows.Forms.Button btnnuevo;
        private System.Windows.Forms.Button btnactualizar;
        private System.Windows.Forms.Label label3;
        private HpResergerUserControls.TextBoxPer txtcodigosunat;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_comprobantex;
        private System.Windows.Forms.DataGridViewTextBoxColumn codiosunatx;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombrex;
        private System.Windows.Forms.DataGridViewTextBoxColumn usuariox;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechax;
        public HpResergerUserControls.txtBuscar txtBuscar;
    }
}