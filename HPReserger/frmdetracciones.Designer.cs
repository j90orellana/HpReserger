namespace HPReserger
{
    partial class frmdetracciones
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmdetracciones));
            this.dtgconten = new HpResergerUserControls.Dtgconten();
            this.id_detraccionx = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xCod_Detraccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xAnexo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcionx = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.porcentajex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usuariox = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechax = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnaceptar = new HpResergerUserControls.ButtonPer();
            this.btncancelar = new System.Windows.Forms.Button();
            this.txtdescripcion = new HpResergerUserControls.TextBoxPer();
            this.txtporcentaje = new HpResergerUserControls.TextBoxPer();
            this.dtpfecha = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnmodificar = new System.Windows.Forms.Button();
            this.btnnuevo = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnactualizar = new System.Windows.Forms.Button();
            this.btneliminar = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.label4 = new System.Windows.Forms.Label();
            this.txtAnexo = new HpResergerUserControls.TextBoxPer();
            this.label5 = new System.Windows.Forms.Label();
            this.txtsunat = new HpResergerUserControls.TextBoxPer();
            this.separadorOre1 = new HpResergerUserControls.SeparadorOre();
            this.lblmsg2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtbusanexo = new HpResergerUserControls.TextBoxPer();
            this.txtbusdesc = new HpResergerUserControls.TextBoxPer();
            this.txtbusid = new HpResergerUserControls.TextBoxPer();
            this.btnlimpiar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgconten)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgconten
            // 
            this.dtgconten.AllowUserToAddRows = false;
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
            this.id_detraccionx,
            this.xCod_Detraccion,
            this.xAnexo,
            this.descripcionx,
            this.porcentajex,
            this.usuariox,
            this.fechax});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(207)))), ((int)(((byte)(241)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgconten.DefaultCellStyle = dataGridViewCellStyle6;
            this.dtgconten.EnableHeadersVisualStyles = false;
            this.dtgconten.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(179)))), ((int)(((byte)(215)))));
            this.dtgconten.Location = new System.Drawing.Point(12, 92);
            this.dtgconten.Name = "dtgconten";
            this.dtgconten.ReadOnly = true;
            this.dtgconten.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dtgconten.RowHeadersVisible = false;
            this.dtgconten.RowTemplate.Height = 18;
            this.dtgconten.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgconten.Size = new System.Drawing.Size(682, 284);
            this.dtgconten.TabIndex = 0;
            this.dtgconten.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgconten_CellContentDoubleClick);
            this.dtgconten.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgconten_RowEnter);
            this.dtgconten.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dtgconten_RowsAdded);
            this.dtgconten.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.dtgconten_RowsRemoved);
            // 
            // id_detraccionx
            // 
            this.id_detraccionx.DataPropertyName = "id_detraccion";
            this.id_detraccionx.HeaderText = "id_detraccion";
            this.id_detraccionx.Name = "id_detraccionx";
            this.id_detraccionx.ReadOnly = true;
            this.id_detraccionx.Visible = false;
            // 
            // xCod_Detraccion
            // 
            this.xCod_Detraccion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.xCod_Detraccion.DataPropertyName = "Cod_Detraccion";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.xCod_Detraccion.DefaultCellStyle = dataGridViewCellStyle3;
            this.xCod_Detraccion.HeaderText = "Id Sunat";
            this.xCod_Detraccion.Name = "xCod_Detraccion";
            this.xCod_Detraccion.ReadOnly = true;
            this.xCod_Detraccion.Width = 74;
            // 
            // xAnexo
            // 
            this.xAnexo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.xAnexo.DataPropertyName = "Anexo";
            this.xAnexo.HeaderText = "Anexo";
            this.xAnexo.MinimumWidth = 50;
            this.xAnexo.Name = "xAnexo";
            this.xAnexo.ReadOnly = true;
            this.xAnexo.Width = 63;
            // 
            // descripcionx
            // 
            this.descripcionx.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.descripcionx.DataPropertyName = "Desc_Detraccion";
            this.descripcionx.HeaderText = "Descripción";
            this.descripcionx.MinimumWidth = 200;
            this.descripcionx.Name = "descripcionx";
            this.descripcionx.ReadOnly = true;
            // 
            // porcentajex
            // 
            this.porcentajex.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.porcentajex.DataPropertyName = "porcentaje";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle4.Format = "0.##\"%\"";
            dataGridViewCellStyle4.NullValue = null;
            this.porcentajex.DefaultCellStyle = dataGridViewCellStyle4;
            this.porcentajex.HeaderText = "Porcentaje";
            this.porcentajex.MinimumWidth = 70;
            this.porcentajex.Name = "porcentajex";
            this.porcentajex.ReadOnly = true;
            this.porcentajex.Width = 85;
            // 
            // usuariox
            // 
            this.usuariox.DataPropertyName = "usuario";
            this.usuariox.HeaderText = "usuario";
            this.usuariox.Name = "usuariox";
            this.usuariox.ReadOnly = true;
            this.usuariox.Visible = false;
            // 
            // fechax
            // 
            this.fechax.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.fechax.DataPropertyName = "fecha";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle5.Format = "dd/MM/yyyy";
            dataGridViewCellStyle5.NullValue = null;
            this.fechax.DefaultCellStyle = dataGridViewCellStyle5;
            this.fechax.HeaderText = "Fecha";
            this.fechax.MinimumWidth = 80;
            this.fechax.Name = "fechax";
            this.fechax.ReadOnly = true;
            this.fechax.Width = 80;
            // 
            // btnaceptar
            // 
            this.btnaceptar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnaceptar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(129)))), ((int)(((byte)(189)))));
            this.btnaceptar.Enabled = false;
            this.btnaceptar.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnaceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnaceptar.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnaceptar.ForeColor = System.Drawing.Color.White;
            this.btnaceptar.Image = ((System.Drawing.Image)(resources.GetObject("btnaceptar.Image")));
            this.btnaceptar.Location = new System.Drawing.Point(700, 343);
            this.btnaceptar.Name = "btnaceptar";
            this.btnaceptar.Size = new System.Drawing.Size(87, 23);
            this.btnaceptar.TabIndex = 2;
            this.btnaceptar.Text = "&Aceptar";
            this.btnaceptar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnaceptar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnaceptar.UseVisualStyleBackColor = false;
            this.btnaceptar.Click += new System.EventHandler(this.btnaceptar_Click);
            // 
            // btncancelar
            // 
            this.btncancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btncancelar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btncancelar.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncancelar.Image = ((System.Drawing.Image)(resources.GetObject("btncancelar.Image")));
            this.btncancelar.Location = new System.Drawing.Point(700, 369);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(87, 23);
            this.btncancelar.TabIndex = 35;
            this.btncancelar.Text = "&Cancelar";
            this.btncancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btncancelar.UseVisualStyleBackColor = true;
            this.btncancelar.Click += new System.EventHandler(this.btncancelar_Click);
            // 
            // txtdescripcion
            // 
            this.txtdescripcion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(218)))), ((int)(((byte)(231)))));
            this.txtdescripcion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtdescripcion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtdescripcion.ColorFondoMouseEncima = System.Drawing.Color.Empty;
            this.txtdescripcion.ColorFondoMousePresionado = System.Drawing.Color.Empty;
            this.txtdescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdescripcion.ForeColor = System.Drawing.Color.Black;
            this.txtdescripcion.Format = null;
            this.txtdescripcion.Location = new System.Drawing.Point(83, 10);
            this.txtdescripcion.MaxLength = 100;
            this.txtdescripcion.Name = "txtdescripcion";
            this.txtdescripcion.NextControlOnEnter = this.txtporcentaje;
            this.txtdescripcion.ReadOnly = true;
            this.txtdescripcion.Size = new System.Drawing.Size(436, 21);
            this.txtdescripcion.TabIndex = 70;
            this.txtdescripcion.Text = "INGRESE DESCRIPCIÓN";
            this.txtdescripcion.TextoDefecto = "Ingrese Descripción";
            this.txtdescripcion.TextoDefectoColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(129)))), ((int)(((byte)(189)))));
            this.txtdescripcion.TiposDatos = HpResergerUserControls.TextBoxPer.ListaTipos.Todo;
            // 
            // txtporcentaje
            // 
            this.txtporcentaje.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(218)))), ((int)(((byte)(231)))));
            this.txtporcentaje.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtporcentaje.ColorFondoMouseEncima = System.Drawing.Color.Empty;
            this.txtporcentaje.ColorFondoMousePresionado = System.Drawing.Color.Empty;
            this.txtporcentaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtporcentaje.ForeColor = System.Drawing.Color.Black;
            this.txtporcentaje.Format = null;
            this.txtporcentaje.Location = new System.Drawing.Point(588, 10);
            this.txtporcentaje.MaxLength = 100;
            this.txtporcentaje.Name = "txtporcentaje";
            this.txtporcentaje.NextControlOnEnter = this.dtpfecha;
            this.txtporcentaje.ReadOnly = true;
            this.txtporcentaje.Size = new System.Drawing.Size(90, 21);
            this.txtporcentaje.TabIndex = 73;
            this.txtporcentaje.Text = "0.00";
            this.txtporcentaje.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtporcentaje.TextoDefecto = "0.00";
            this.txtporcentaje.TextoDefectoColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(129)))), ((int)(((byte)(189)))));
            this.txtporcentaje.TiposDatos = HpResergerUserControls.TextBoxPer.ListaTipos.SoloDinero;
            // 
            // dtpfecha
            // 
            this.dtpfecha.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(218)))), ((int)(((byte)(231)))));
            this.dtpfecha.Enabled = false;
            this.dtpfecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpfecha.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpfecha.Location = new System.Drawing.Point(588, 36);
            this.dtpfecha.Name = "dtpfecha";
            this.dtpfecha.Size = new System.Drawing.Size(106, 21);
            this.dtpfecha.TabIndex = 75;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(12, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 71;
            this.label1.Text = "Descripción:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(525, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 72;
            this.label2.Text = "Porcentaje:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(549, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 74;
            this.label3.Text = "Fecha:";
            // 
            // btnmodificar
            // 
            this.btnmodificar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnmodificar.BackColor = System.Drawing.SystemColors.Control;
            this.btnmodificar.Enabled = false;
            this.btnmodificar.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmodificar.ForeColor = System.Drawing.Color.Black;
            this.btnmodificar.Image = ((System.Drawing.Image)(resources.GetObject("btnmodificar.Image")));
            this.btnmodificar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnmodificar.Location = new System.Drawing.Point(700, 34);
            this.btnmodificar.Name = "btnmodificar";
            this.btnmodificar.Size = new System.Drawing.Size(87, 24);
            this.btnmodificar.TabIndex = 77;
            this.btnmodificar.Text = "&Modificar";
            this.btnmodificar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnmodificar.UseVisualStyleBackColor = true;
            this.btnmodificar.Click += new System.EventHandler(this.btnmodificar_Click);
            // 
            // btnnuevo
            // 
            this.btnnuevo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnnuevo.BackColor = System.Drawing.SystemColors.Control;
            this.btnnuevo.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnnuevo.ForeColor = System.Drawing.Color.Black;
            this.btnnuevo.Image = ((System.Drawing.Image)(resources.GetObject("btnnuevo.Image")));
            this.btnnuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnnuevo.Location = new System.Drawing.Point(700, 8);
            this.btnnuevo.Name = "btnnuevo";
            this.btnnuevo.Size = new System.Drawing.Size(87, 24);
            this.btnnuevo.TabIndex = 76;
            this.btnnuevo.Text = "&Nuevo";
            this.btnnuevo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnnuevo.UseVisualStyleBackColor = true;
            this.btnnuevo.Click += new System.EventHandler(this.btnnuevo_Click);
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.button1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(700, 189);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 23);
            this.button1.TabIndex = 78;
            this.button1.Text = "&Excel";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnactualizar
            // 
            this.btnactualizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnactualizar.BackColor = System.Drawing.SystemColors.Control;
            this.btnactualizar.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnactualizar.ForeColor = System.Drawing.Color.Black;
            this.btnactualizar.Image = ((System.Drawing.Image)(resources.GetObject("btnactualizar.Image")));
            this.btnactualizar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnactualizar.Location = new System.Drawing.Point(700, 92);
            this.btnactualizar.Name = "btnactualizar";
            this.btnactualizar.Size = new System.Drawing.Size(87, 24);
            this.btnactualizar.TabIndex = 80;
            this.btnactualizar.Text = "Ac&tualizar";
            this.btnactualizar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnactualizar.UseVisualStyleBackColor = true;
            this.btnactualizar.Click += new System.EventHandler(this.btnactualizar_Click);
            // 
            // btneliminar
            // 
            this.btneliminar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btneliminar.BackColor = System.Drawing.SystemColors.Control;
            this.btneliminar.Enabled = false;
            this.btneliminar.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btneliminar.ForeColor = System.Drawing.Color.Black;
            this.btneliminar.Image = ((System.Drawing.Image)(resources.GetObject("btneliminar.Image")));
            this.btneliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btneliminar.Location = new System.Drawing.Point(700, 65);
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Size = new System.Drawing.Size(87, 24);
            this.btneliminar.TabIndex = 79;
            this.btneliminar.Text = "&Eliminar";
            this.btneliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btneliminar.UseVisualStyleBackColor = true;
            this.btneliminar.Click += new System.EventHandler(this.btneliminar_Click);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(40, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 71;
            this.label4.Text = "Anexo:";
            // 
            // txtAnexo
            // 
            this.txtAnexo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(218)))), ((int)(((byte)(231)))));
            this.txtAnexo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAnexo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtAnexo.ColorFondoMouseEncima = System.Drawing.Color.Empty;
            this.txtAnexo.ColorFondoMousePresionado = System.Drawing.Color.Empty;
            this.txtAnexo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAnexo.ForeColor = System.Drawing.Color.Black;
            this.txtAnexo.Format = null;
            this.txtAnexo.Location = new System.Drawing.Point(83, 36);
            this.txtAnexo.MaxLength = 40;
            this.txtAnexo.Name = "txtAnexo";
            this.txtAnexo.NextControlOnEnter = null;
            this.txtAnexo.ReadOnly = true;
            this.txtAnexo.Size = new System.Drawing.Size(289, 21);
            this.txtAnexo.TabIndex = 70;
            this.txtAnexo.Text = "INGRESE ANEXO";
            this.txtAnexo.TextoDefecto = "Ingrese Anexo";
            this.txtAnexo.TextoDefectoColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(129)))), ((int)(((byte)(189)))));
            this.txtAnexo.TiposDatos = HpResergerUserControls.TextBoxPer.ListaTipos.Todo;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(373, 40);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 13);
            this.label5.TabIndex = 72;
            this.label5.Text = "Cod Sunat:";
            // 
            // txtsunat
            // 
            this.txtsunat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(218)))), ((int)(((byte)(231)))));
            this.txtsunat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtsunat.ColorFondoMouseEncima = System.Drawing.Color.Empty;
            this.txtsunat.ColorFondoMousePresionado = System.Drawing.Color.Empty;
            this.txtsunat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsunat.ForeColor = System.Drawing.Color.Black;
            this.txtsunat.Format = null;
            this.txtsunat.Location = new System.Drawing.Point(436, 36);
            this.txtsunat.MaxLength = 4;
            this.txtsunat.Name = "txtsunat";
            this.txtsunat.NextControlOnEnter = null;
            this.txtsunat.ReadOnly = true;
            this.txtsunat.Size = new System.Drawing.Size(83, 21);
            this.txtsunat.TabIndex = 73;
            this.txtsunat.Text = "000";
            this.txtsunat.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtsunat.TextoDefecto = "000";
            this.txtsunat.TextoDefectoColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(129)))), ((int)(((byte)(189)))));
            this.txtsunat.TiposDatos = HpResergerUserControls.TextBoxPer.ListaTipos.SoloNumeros;
            // 
            // separadorOre1
            // 
            this.separadorOre1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.separadorOre1.BackColor = System.Drawing.Color.Transparent;
            this.separadorOre1.Location = new System.Drawing.Point(0, 60);
            this.separadorOre1.MaximumSize = new System.Drawing.Size(2000, 2);
            this.separadorOre1.MinimumSize = new System.Drawing.Size(0, 2);
            this.separadorOre1.Name = "separadorOre1";
            this.separadorOre1.Size = new System.Drawing.Size(805, 2);
            this.separadorOre1.TabIndex = 81;
            // 
            // lblmsg2
            // 
            this.lblmsg2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblmsg2.AutoSize = true;
            this.lblmsg2.BackColor = System.Drawing.Color.Transparent;
            this.lblmsg2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmsg2.Location = new System.Drawing.Point(12, 379);
            this.lblmsg2.Name = "lblmsg2";
            this.lblmsg2.Size = new System.Drawing.Size(113, 13);
            this.lblmsg2.TabIndex = 140;
            this.lblmsg2.Text = "Total de Registros : 0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(678, 14);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(16, 13);
            this.label6.TabIndex = 74;
            this.label6.Text = "%";
            // 
            // txtbusanexo
            // 
            this.txtbusanexo.BackColor = System.Drawing.Color.White;
            this.txtbusanexo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtbusanexo.ColorFondoMouseEncima = System.Drawing.Color.Empty;
            this.txtbusanexo.ColorFondoMousePresionado = System.Drawing.Color.Empty;
            this.txtbusanexo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbusanexo.ForeColor = System.Drawing.Color.Black;
            this.txtbusanexo.Format = null;
            this.txtbusanexo.Location = new System.Drawing.Point(83, 67);
            this.txtbusanexo.MaxLength = 40;
            this.txtbusanexo.Name = "txtbusanexo";
            this.txtbusanexo.NextControlOnEnter = null;
            this.txtbusanexo.Size = new System.Drawing.Size(139, 21);
            this.txtbusanexo.TabIndex = 70;
            this.txtbusanexo.Text = "Buscar Anexo";
            this.txtbusanexo.TextoDefecto = "Buscar Anexo";
            this.txtbusanexo.TextoDefectoColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(129)))), ((int)(((byte)(189)))));
            this.txtbusanexo.TiposDatos = HpResergerUserControls.TextBoxPer.ListaTipos.Todo;
            this.txtbusanexo.TextChanged += new System.EventHandler(this.txtbusdesc_TextChanged);
            // 
            // txtbusdesc
            // 
            this.txtbusdesc.BackColor = System.Drawing.Color.White;
            this.txtbusdesc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtbusdesc.ColorFondoMouseEncima = System.Drawing.Color.Empty;
            this.txtbusdesc.ColorFondoMousePresionado = System.Drawing.Color.Empty;
            this.txtbusdesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbusdesc.ForeColor = System.Drawing.Color.Black;
            this.txtbusdesc.Format = null;
            this.txtbusdesc.Location = new System.Drawing.Point(228, 67);
            this.txtbusdesc.MaxLength = 40;
            this.txtbusdesc.Name = "txtbusdesc";
            this.txtbusdesc.NextControlOnEnter = null;
            this.txtbusdesc.Size = new System.Drawing.Size(373, 21);
            this.txtbusdesc.TabIndex = 70;
            this.txtbusdesc.Text = "Buscar Descripción";
            this.txtbusdesc.TextoDefecto = "Buscar Descripción";
            this.txtbusdesc.TextoDefectoColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(129)))), ((int)(((byte)(189)))));
            this.txtbusdesc.TiposDatos = HpResergerUserControls.TextBoxPer.ListaTipos.Todo;
            this.txtbusdesc.TextChanged += new System.EventHandler(this.txtbusdesc_TextChanged);
            // 
            // txtbusid
            // 
            this.txtbusid.BackColor = System.Drawing.Color.White;
            this.txtbusid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtbusid.ColorFondoMouseEncima = System.Drawing.Color.Empty;
            this.txtbusid.ColorFondoMousePresionado = System.Drawing.Color.Empty;
            this.txtbusid.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbusid.ForeColor = System.Drawing.Color.Black;
            this.txtbusid.Format = null;
            this.txtbusid.Location = new System.Drawing.Point(12, 67);
            this.txtbusid.MaxLength = 40;
            this.txtbusid.Name = "txtbusid";
            this.txtbusid.NextControlOnEnter = null;
            this.txtbusid.Size = new System.Drawing.Size(65, 21);
            this.txtbusid.TabIndex = 70;
            this.txtbusid.Text = "Buscar ID";
            this.txtbusid.TextoDefecto = "Buscar ID";
            this.txtbusid.TextoDefectoColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(129)))), ((int)(((byte)(189)))));
            this.txtbusid.TiposDatos = HpResergerUserControls.TextBoxPer.ListaTipos.Todo;
            this.txtbusid.TextChanged += new System.EventHandler(this.txtbusdesc_TextChanged);
            // 
            // btnlimpiar
            // 
            this.btnlimpiar.BackColor = System.Drawing.SystemColors.Control;
            this.btnlimpiar.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlimpiar.ForeColor = System.Drawing.Color.Black;
            this.btnlimpiar.Image = ((System.Drawing.Image)(resources.GetObject("btnlimpiar.Image")));
            this.btnlimpiar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnlimpiar.Location = new System.Drawing.Point(607, 65);
            this.btnlimpiar.Name = "btnlimpiar";
            this.btnlimpiar.Size = new System.Drawing.Size(87, 24);
            this.btnlimpiar.TabIndex = 79;
            this.btnlimpiar.Text = "&Limpiar";
            this.btnlimpiar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnlimpiar.UseVisualStyleBackColor = true;
            this.btnlimpiar.Click += new System.EventHandler(this.button2_Click);
            // 
            // frmdetracciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(796, 400);
            this.Controls.Add(this.lblmsg2);
            this.Controls.Add(this.separadorOre1);
            this.Controls.Add(this.btnactualizar);
            this.Controls.Add(this.btnlimpiar);
            this.Controls.Add(this.btneliminar);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnmodificar);
            this.Controls.Add(this.btnnuevo);
            this.Controls.Add(this.dtpfecha);
            this.Controls.Add(this.txtsunat);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtporcentaje);
            this.Controls.Add(this.txtbusdesc);
            this.Controls.Add(this.txtbusid);
            this.Controls.Add(this.txtbusanexo);
            this.Controls.Add(this.txtAnexo);
            this.Controls.Add(this.txtdescripcion);
            this.Controls.Add(this.btncancelar);
            this.Controls.Add(this.btnaceptar);
            this.Controls.Add(this.dtgconten);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinimumSize = new System.Drawing.Size(812, 439);
            this.Name = "frmdetracciones";
            this.Nombre = "Configuración de las Detracciones";
            this.Tag = "70114";
            this.Text = "Configuración de las Detracciones";
            this.Load += new System.EventHandler(this.frmdetracciones_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgconten)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private HpResergerUserControls.Dtgconten dtgconten;
        private System.Windows.Forms.Button btncancelar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private HpResergerUserControls.TextBoxPer txtporcentaje;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpfecha;
        private System.Windows.Forms.Button btnmodificar;
        private System.Windows.Forms.Button btnnuevo;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnactualizar;
        private System.Windows.Forms.Button btneliminar;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        public HpResergerUserControls.TextBoxPer txtdescripcion;
        public HpResergerUserControls.ButtonPer btnaceptar;
        private System.Windows.Forms.Label label4;
        public HpResergerUserControls.TextBoxPer txtAnexo;
        private System.Windows.Forms.Label label5;
        private HpResergerUserControls.TextBoxPer txtsunat;
        private HpResergerUserControls.SeparadorOre separadorOre1;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_detraccionx;
        private System.Windows.Forms.DataGridViewTextBoxColumn xCod_Detraccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn xAnexo;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcionx;
        private System.Windows.Forms.DataGridViewTextBoxColumn porcentajex;
        private System.Windows.Forms.DataGridViewTextBoxColumn usuariox;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechax;
        private System.Windows.Forms.Label lblmsg2;
        private System.Windows.Forms.Label label6;
        public HpResergerUserControls.TextBoxPer txtbusanexo;
        public HpResergerUserControls.TextBoxPer txtbusdesc;
        public HpResergerUserControls.TextBoxPer txtbusid;
        private System.Windows.Forms.Button btnlimpiar;
    }
}