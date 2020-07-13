namespace HPReserger
{
    partial class frmTipoFaltas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTipoFaltas));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.separadorOre1 = new HpResergerUserControls.SeparadorOre();
            this.btnlimpiar = new System.Windows.Forms.Button();
            this.txtbusObservacion = new HpResergerUserControls.TextBoxPer();
            this.txtbusTipoFalta = new HpResergerUserControls.TextBoxPer();
            this.btnactualizar = new System.Windows.Forms.Button();
            this.txtdiamin = new HpResergerUserControls.TextBoxPer();
            this.txtTipoFalta = new HpResergerUserControls.TextBoxPer();
            this.btnAceptar = new HpResergerUserControls.ButtonPer();
            this.btnmodificar = new System.Windows.Forms.Button();
            this.btnnuevo = new System.Windows.Forms.Button();
            this.BtnCerrar = new HpResergerUserControls.ButtonPer();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblmsg = new System.Windows.Forms.Label();
            this.dtgconten = new HpResergerUserControls.Dtgconten();
            this.xpkid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xdiasminimos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xdiasmaximos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xFecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xdescuento = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.xobservacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label6 = new System.Windows.Forms.Label();
            this.txtobservacion = new HpResergerUserControls.TextBoxPer();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.chkDescuento = new HpResergerUserControls.checkboxOre();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtdiamax = new HpResergerUserControls.TextBoxPer();
            ((System.ComponentModel.ISupportInitialize)(this.dtgconten)).BeginInit();
            this.SuspendLayout();
            // 
            // separadorOre1
            // 
            this.separadorOre1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.separadorOre1.BackColor = System.Drawing.Color.Transparent;
            this.separadorOre1.Location = new System.Drawing.Point(-3, 98);
            this.separadorOre1.MaximumSize = new System.Drawing.Size(2000, 2);
            this.separadorOre1.MinimumSize = new System.Drawing.Size(0, 2);
            this.separadorOre1.Name = "separadorOre1";
            this.separadorOre1.Size = new System.Drawing.Size(663, 2);
            this.separadorOre1.TabIndex = 35;
            // 
            // btnlimpiar
            // 
            this.btnlimpiar.BackColor = System.Drawing.SystemColors.Control;
            this.btnlimpiar.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlimpiar.ForeColor = System.Drawing.Color.Black;
            this.btnlimpiar.Image = ((System.Drawing.Image)(resources.GetObject("btnlimpiar.Image")));
            this.btnlimpiar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnlimpiar.Location = new System.Drawing.Point(559, 102);
            this.btnlimpiar.Name = "btnlimpiar";
            this.btnlimpiar.Size = new System.Drawing.Size(83, 23);
            this.btnlimpiar.TabIndex = 10;
            this.btnlimpiar.Text = "&Limpiar";
            this.btnlimpiar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnlimpiar.UseVisualStyleBackColor = true;
            this.btnlimpiar.Click += new System.EventHandler(this.btnlimpiar_Click);
            // 
            // txtbusObservacion
            // 
            this.txtbusObservacion.BackColor = System.Drawing.Color.White;
            this.txtbusObservacion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtbusObservacion.ColorFondoMouseEncima = System.Drawing.Color.Empty;
            this.txtbusObservacion.ColorFondoMousePresionado = System.Drawing.Color.Empty;
            this.txtbusObservacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbusObservacion.ForeColor = System.Drawing.Color.Black;
            this.txtbusObservacion.Format = null;
            this.txtbusObservacion.Location = new System.Drawing.Point(198, 103);
            this.txtbusObservacion.MaxLength = 40;
            this.txtbusObservacion.Name = "txtbusObservacion";
            this.txtbusObservacion.NextControlOnEnter = null;
            this.txtbusObservacion.Size = new System.Drawing.Size(358, 21);
            this.txtbusObservacion.TabIndex = 9;
            this.txtbusObservacion.Text = "Buscar Observación";
            this.txtbusObservacion.TextoDefecto = "Buscar Observación";
            this.txtbusObservacion.TextoDefectoColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(129)))), ((int)(((byte)(189)))));
            this.txtbusObservacion.TiposDatos = HpResergerUserControls.TextBoxPer.ListaTipos.MayusculaCadaPalabra;
            this.txtbusObservacion.TextChanged += new System.EventHandler(this.txtbusObservacion_TextChanged);
            // 
            // txtbusTipoFalta
            // 
            this.txtbusTipoFalta.BackColor = System.Drawing.Color.White;
            this.txtbusTipoFalta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtbusTipoFalta.ColorFondoMouseEncima = System.Drawing.Color.Empty;
            this.txtbusTipoFalta.ColorFondoMousePresionado = System.Drawing.Color.Empty;
            this.txtbusTipoFalta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbusTipoFalta.ForeColor = System.Drawing.Color.Black;
            this.txtbusTipoFalta.Format = null;
            this.txtbusTipoFalta.Location = new System.Drawing.Point(12, 103);
            this.txtbusTipoFalta.MaxLength = 40;
            this.txtbusTipoFalta.Name = "txtbusTipoFalta";
            this.txtbusTipoFalta.NextControlOnEnter = null;
            this.txtbusTipoFalta.Size = new System.Drawing.Size(180, 21);
            this.txtbusTipoFalta.TabIndex = 8;
            this.txtbusTipoFalta.Text = "Buscar Tipo Falta";
            this.txtbusTipoFalta.TextoDefecto = "Buscar Tipo Falta";
            this.txtbusTipoFalta.TextoDefectoColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(129)))), ((int)(((byte)(189)))));
            this.txtbusTipoFalta.TiposDatos = HpResergerUserControls.TextBoxPer.ListaTipos.MayusculaCadaPalabra;
            this.txtbusTipoFalta.TextChanged += new System.EventHandler(this.txtbusTipoFalta_TextChanged);
            // 
            // btnactualizar
            // 
            this.btnactualizar.BackColor = System.Drawing.SystemColors.Control;
            this.btnactualizar.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnactualizar.ForeColor = System.Drawing.Color.Black;
            this.btnactualizar.Image = ((System.Drawing.Image)(resources.GetObject("btnactualizar.Image")));
            this.btnactualizar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnactualizar.Location = new System.Drawing.Point(559, 125);
            this.btnactualizar.Name = "btnactualizar";
            this.btnactualizar.Size = new System.Drawing.Size(83, 23);
            this.btnactualizar.TabIndex = 11;
            this.btnactualizar.Text = "Ac&tualizar";
            this.btnactualizar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnactualizar.UseVisualStyleBackColor = true;
            this.btnactualizar.Click += new System.EventHandler(this.btnactualizar_Click);
            // 
            // txtdiamin
            // 
            this.txtdiamin.BackColor = System.Drawing.Color.White;
            this.txtdiamin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtdiamin.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtdiamin.ColorFondoMouseEncima = System.Drawing.Color.Empty;
            this.txtdiamin.ColorFondoMousePresionado = System.Drawing.Color.Empty;
            this.txtdiamin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdiamin.ForeColor = System.Drawing.Color.Black;
            this.txtdiamin.Format = "0";
            this.txtdiamin.Location = new System.Drawing.Point(255, 74);
            this.txtdiamin.MaxLength = 100;
            this.txtdiamin.Name = "txtdiamin";
            this.txtdiamin.NextControlOnEnter = null;
            this.txtdiamin.Size = new System.Drawing.Size(60, 21);
            this.txtdiamin.TabIndex = 5;
            this.txtdiamin.Text = "0";
            this.txtdiamin.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtdiamin.TextoDefecto = "0";
            this.txtdiamin.TextoDefectoColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(129)))), ((int)(((byte)(189)))));
            this.txtdiamin.TiposDatos = HpResergerUserControls.TextBoxPer.ListaTipos.SoloNumeros;
            // 
            // txtTipoFalta
            // 
            this.txtTipoFalta.BackColor = System.Drawing.Color.White;
            this.txtTipoFalta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTipoFalta.ColorFondoMouseEncima = System.Drawing.Color.Empty;
            this.txtTipoFalta.ColorFondoMousePresionado = System.Drawing.Color.Empty;
            this.txtTipoFalta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTipoFalta.ForeColor = System.Drawing.Color.Black;
            this.txtTipoFalta.Format = null;
            this.txtTipoFalta.Location = new System.Drawing.Point(80, 25);
            this.txtTipoFalta.MaxLength = 100;
            this.txtTipoFalta.Name = "txtTipoFalta";
            this.txtTipoFalta.NextControlOnEnter = null;
            this.txtTipoFalta.Size = new System.Drawing.Size(476, 21);
            this.txtTipoFalta.TabIndex = 2;
            this.txtTipoFalta.Text = "INGRESE TIPO DE FALTA";
            this.txtTipoFalta.TextoDefecto = "INGRESE TIPO DE FALTA";
            this.txtTipoFalta.TextoDefectoColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(129)))), ((int)(((byte)(189)))));
            this.txtTipoFalta.TiposDatos = HpResergerUserControls.TextBoxPer.ListaTipos.MayusculaCadaPalabra;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAceptar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(129)))), ((int)(((byte)(189)))));
            this.btnAceptar.FlatAppearance.BorderColor = System.Drawing.Color.Olive;
            this.btnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAceptar.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptar.ForeColor = System.Drawing.Color.White;
            this.btnAceptar.Location = new System.Drawing.Point(471, 369);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(83, 24);
            this.btnAceptar.TabIndex = 13;
            this.btnAceptar.Text = "&Aceptar";
            this.btnAceptar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAceptar.UseVisualStyleBackColor = false;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnmodificar
            // 
            this.btnmodificar.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmodificar.Image = ((System.Drawing.Image)(resources.GetObject("btnmodificar.Image")));
            this.btnmodificar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnmodificar.Location = new System.Drawing.Point(559, 48);
            this.btnmodificar.Name = "btnmodificar";
            this.btnmodificar.Size = new System.Drawing.Size(83, 23);
            this.btnmodificar.TabIndex = 1;
            this.btnmodificar.Text = "Modificar";
            this.btnmodificar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnmodificar.UseVisualStyleBackColor = true;
            this.btnmodificar.Click += new System.EventHandler(this.btnmodificar_Click);
            // 
            // btnnuevo
            // 
            this.btnnuevo.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnnuevo.Image = ((System.Drawing.Image)(resources.GetObject("btnnuevo.Image")));
            this.btnnuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnnuevo.Location = new System.Drawing.Point(559, 24);
            this.btnnuevo.Name = "btnnuevo";
            this.btnnuevo.Size = new System.Drawing.Size(83, 23);
            this.btnnuevo.TabIndex = 0;
            this.btnnuevo.Text = "Nuevo";
            this.btnnuevo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnnuevo.UseVisualStyleBackColor = true;
            this.btnnuevo.Click += new System.EventHandler(this.btnnuevo_Click);
            // 
            // BtnCerrar
            // 
            this.BtnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnCerrar.BackColor = System.Drawing.Color.Crimson;
            this.BtnCerrar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnCerrar.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.BtnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCerrar.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCerrar.ForeColor = System.Drawing.Color.White;
            this.BtnCerrar.Location = new System.Drawing.Point(559, 369);
            this.BtnCerrar.Name = "BtnCerrar";
            this.BtnCerrar.Size = new System.Drawing.Size(83, 24);
            this.BtnCerrar.TabIndex = 14;
            this.BtnCerrar.Text = "&Cancelar";
            this.BtnCerrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnCerrar.UseVisualStyleBackColor = false;
            this.BtnCerrar.Click += new System.EventHandler(this.BtnCerrar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 34;
            this.label2.Text = "Tipo Falta:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(8, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 13);
            this.label5.TabIndex = 33;
            this.label5.Text = "TIPOS DE FALTAS";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 135);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "Listado de Tipos de Faltas:";
            // 
            // lblmsg
            // 
            this.lblmsg.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblmsg.AutoSize = true;
            this.lblmsg.BackColor = System.Drawing.Color.Transparent;
            this.lblmsg.Location = new System.Drawing.Point(8, 375);
            this.lblmsg.Name = "lblmsg";
            this.lblmsg.Size = new System.Drawing.Size(113, 13);
            this.lblmsg.TabIndex = 38;
            this.lblmsg.Text = "Total de Registros : 0";
            // 
            // dtgconten
            // 
            this.dtgconten.AllowUserToAddRows = false;
            this.dtgconten.AllowUserToDeleteRows = false;
            this.dtgconten.AllowUserToResizeColumns = false;
            this.dtgconten.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(230)))), ((int)(((byte)(241)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DeepSkyBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgconten.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dtgconten.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dtgconten.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.xpkid,
            this.xNombre,
            this.xdiasminimos,
            this.xdiasmaximos,
            this.xFecha,
            this.xdescuento,
            this.xobservacion});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(207)))), ((int)(((byte)(241)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgconten.DefaultCellStyle = dataGridViewCellStyle4;
            this.dtgconten.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dtgconten.EnableHeadersVisualStyles = false;
            this.dtgconten.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(179)))), ((int)(((byte)(215)))));
            this.dtgconten.Location = new System.Drawing.Point(8, 149);
            this.dtgconten.Name = "dtgconten";
            this.dtgconten.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dtgconten.RowHeadersVisible = false;
            this.dtgconten.RowTemplate.Height = 18;
            this.dtgconten.Size = new System.Drawing.Size(634, 214);
            this.dtgconten.TabIndex = 12;
            this.dtgconten.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgconten_RowEnter);
            // 
            // xpkid
            // 
            this.xpkid.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.xpkid.DataPropertyName = "pkid";
            this.xpkid.HeaderText = "Id";
            this.xpkid.MinimumWidth = 40;
            this.xpkid.Name = "xpkid";
            this.xpkid.Width = 40;
            // 
            // xNombre
            // 
            this.xNombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.xNombre.DataPropertyName = "Nombre";
            this.xNombre.HeaderText = "Nombre";
            this.xNombre.MinimumWidth = 100;
            this.xNombre.Name = "xNombre";
            // 
            // xdiasminimos
            // 
            this.xdiasminimos.DataPropertyName = "diasminimos";
            this.xdiasminimos.HeaderText = "DiasMinimos";
            this.xdiasminimos.Name = "xdiasminimos";
            this.xdiasminimos.Visible = false;
            // 
            // xdiasmaximos
            // 
            this.xdiasmaximos.DataPropertyName = "diasmaximos";
            this.xdiasmaximos.HeaderText = "DiasMaximos";
            this.xdiasmaximos.Name = "xdiasmaximos";
            this.xdiasmaximos.Visible = false;
            // 
            // xFecha
            // 
            this.xFecha.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.xFecha.DataPropertyName = "Fecha";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.Format = "dd/MM/yyyy";
            this.xFecha.DefaultCellStyle = dataGridViewCellStyle3;
            this.xFecha.HeaderText = "Fecha";
            this.xFecha.MinimumWidth = 60;
            this.xFecha.Name = "xFecha";
            this.xFecha.Width = 60;
            // 
            // xdescuento
            // 
            this.xdescuento.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.xdescuento.DataPropertyName = "descuento";
            this.xdescuento.FalseValue = "0";
            this.xdescuento.HeaderText = "Descuento";
            this.xdescuento.MinimumWidth = 70;
            this.xdescuento.Name = "xdescuento";
            this.xdescuento.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.xdescuento.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.xdescuento.TrueValue = "1";
            this.xdescuento.Width = 70;
            // 
            // xobservacion
            // 
            this.xobservacion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.xobservacion.DataPropertyName = "observacion";
            this.xobservacion.HeaderText = "Observación";
            this.xobservacion.MinimumWidth = 150;
            this.xobservacion.Name = "xobservacion";
            this.xobservacion.Width = 150;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(8, 53);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 13);
            this.label6.TabIndex = 34;
            this.label6.Text = "Observación:";
            // 
            // txtobservacion
            // 
            this.txtobservacion.BackColor = System.Drawing.Color.White;
            this.txtobservacion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtobservacion.ColorFondoMouseEncima = System.Drawing.Color.Empty;
            this.txtobservacion.ColorFondoMousePresionado = System.Drawing.Color.Empty;
            this.txtobservacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtobservacion.ForeColor = System.Drawing.Color.Black;
            this.txtobservacion.Format = null;
            this.txtobservacion.Location = new System.Drawing.Point(80, 49);
            this.txtobservacion.MaxLength = 600;
            this.txtobservacion.Name = "txtobservacion";
            this.txtobservacion.NextControlOnEnter = null;
            this.txtobservacion.Size = new System.Drawing.Size(476, 21);
            this.txtobservacion.TabIndex = 3;
            this.txtobservacion.Text = "INGRESE OBSERVACIÓN";
            this.txtobservacion.TextoDefecto = "INGRESE OBSERVACIÓN";
            this.txtobservacion.TextoDefectoColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(129)))), ((int)(((byte)(189)))));
            this.txtobservacion.TiposDatos = HpResergerUserControls.TextBoxPer.ListaTipos.MayusculaCadaPalabra;
            // 
            // dtpFecha
            // 
            this.dtpFecha.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.dtpFecha.CustomFormat = "dd/MM/yyyy";
            this.dtpFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha.Location = new System.Drawing.Point(80, 74);
            this.dtpFecha.MaxDate = new System.DateTime(2100, 12, 31, 0, 0, 0, 0);
            this.dtpFecha.MinDate = new System.DateTime(1990, 1, 1, 0, 0, 0, 0);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(101, 21);
            this.dtpFecha.TabIndex = 4;
            this.dtpFecha.Value = new System.DateTime(2020, 7, 2, 0, 0, 0, 0);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(42, 78);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 13);
            this.label7.TabIndex = 34;
            this.label7.Text = "Fecha:";
            // 
            // chkDescuento
            // 
            this.chkDescuento.AutoSize = true;
            this.chkDescuento.BackColor = System.Drawing.Color.Transparent;
            this.chkDescuento.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkDescuento.ColorChecked = System.Drawing.Color.Empty;
            this.chkDescuento.ColorUnChecked = System.Drawing.Color.Empty;
            this.chkDescuento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.chkDescuento.Location = new System.Drawing.Point(447, 75);
            this.chkDescuento.Name = "chkDescuento";
            this.chkDescuento.Size = new System.Drawing.Size(85, 19);
            this.chkDescuento.TabIndex = 7;
            this.chkDescuento.Text = "Descuento";
            this.chkDescuento.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(181, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 34;
            this.label3.Text = "Días Minimo:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(315, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 13);
            this.label4.TabIndex = 34;
            this.label4.Text = "Días Maximo";
            // 
            // txtdiamax
            // 
            this.txtdiamax.BackColor = System.Drawing.Color.White;
            this.txtdiamax.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtdiamax.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtdiamax.ColorFondoMouseEncima = System.Drawing.Color.Empty;
            this.txtdiamax.ColorFondoMousePresionado = System.Drawing.Color.Empty;
            this.txtdiamax.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdiamax.ForeColor = System.Drawing.Color.Black;
            this.txtdiamax.Format = "0";
            this.txtdiamax.Location = new System.Drawing.Point(387, 74);
            this.txtdiamax.MaxLength = 100;
            this.txtdiamax.Name = "txtdiamax";
            this.txtdiamax.NextControlOnEnter = null;
            this.txtdiamax.Size = new System.Drawing.Size(60, 21);
            this.txtdiamax.TabIndex = 6;
            this.txtdiamax.Text = "1";
            this.txtdiamax.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtdiamax.TextoDefecto = "1";
            this.txtdiamax.TextoDefectoColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(129)))), ((int)(((byte)(189)))));
            this.txtdiamax.TiposDatos = HpResergerUserControls.TextBoxPer.ListaTipos.SoloNumeros;
            // 
            // frmTipoFaltas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(654, 400);
            this.Controls.Add(this.chkDescuento);
            this.Controls.Add(this.dtpFecha);
            this.Controls.Add(this.separadorOre1);
            this.Controls.Add(this.btnlimpiar);
            this.Controls.Add(this.txtbusObservacion);
            this.Controls.Add(this.txtbusTipoFalta);
            this.Controls.Add(this.btnactualizar);
            this.Controls.Add(this.txtdiamax);
            this.Controls.Add(this.txtdiamin);
            this.Controls.Add(this.txtobservacion);
            this.Controls.Add(this.txtTipoFalta);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.btnmodificar);
            this.Controls.Add(this.btnnuevo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.BtnCerrar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblmsg);
            this.Controls.Add(this.dtgconten);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.MinimumSize = new System.Drawing.Size(670, 439);
            this.Name = "frmTipoFaltas";
            this.Nombre = "Tipos de Faltas";
            this.Text = "Tipos de Faltas";
            this.Load += new System.EventHandler(this.frmTipoFaltas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgconten)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private HpResergerUserControls.SeparadorOre separadorOre1;
        private System.Windows.Forms.Button btnlimpiar;
        public HpResergerUserControls.TextBoxPer txtbusObservacion;
        public HpResergerUserControls.TextBoxPer txtbusTipoFalta;
        private System.Windows.Forms.Button btnactualizar;
        private HpResergerUserControls.TextBoxPer txtdiamin;
        private HpResergerUserControls.TextBoxPer txtTipoFalta;
        private HpResergerUserControls.ButtonPer btnAceptar;
        private System.Windows.Forms.Button btnmodificar;
        private System.Windows.Forms.Button btnnuevo;
        private HpResergerUserControls.ButtonPer BtnCerrar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblmsg;
        private HpResergerUserControls.Dtgconten dtgconten;
        private System.Windows.Forms.Label label6;
        private HpResergerUserControls.TextBoxPer txtobservacion;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.Label label7;
        private HpResergerUserControls.checkboxOre chkDescuento;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private HpResergerUserControls.TextBoxPer txtdiamax;
        private System.Windows.Forms.DataGridViewTextBoxColumn xpkid;
        private System.Windows.Forms.DataGridViewTextBoxColumn xNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn xdiasminimos;
        private System.Windows.Forms.DataGridViewTextBoxColumn xdiasmaximos;
        private System.Windows.Forms.DataGridViewTextBoxColumn xFecha;
        private System.Windows.Forms.DataGridViewCheckBoxColumn xdescuento;
        private System.Windows.Forms.DataGridViewTextBoxColumn xobservacion;
    }
}