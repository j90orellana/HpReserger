namespace HPReserger
{
    partial class frmConfigurarAsientosBoletas
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConfigurarAsientosBoletas));
            this.label5 = new System.Windows.Forms.Label();
            this.dtgconten = new HpResergerUserControls.Dtgconten();
            this.txtcuenta = new HpResergerUserControls.TextBoxPer();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtdescripcion = new HpResergerUserControls.TextBoxPer();
            this.btnmodificar = new System.Windows.Forms.Button();
            this.chkFecha = new HpResergerUserControls.checkboxOre();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtglosa = new HpResergerUserControls.TextBoxPer();
            this.label6 = new System.Windows.Forms.Label();
            this.cbodebe = new HpResergerUserControls.ComboBoxPer(this.components);
            this.btnAceptar = new HpResergerUserControls.ButtonPer();
            this.BtnCerrar = new HpResergerUserControls.ButtonPer();
            this.lblmsg = new System.Windows.Forms.Label();
            this.xpkid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xcuenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xDescripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xDebeHaber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xIncluirFechas = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.xGlosa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnbuscar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgconten)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(142, 13);
            this.label5.TabIndex = 34;
            this.label5.Text = "Datos de la Configuración";
            // 
            // dtgconten
            // 
            this.dtgconten.AllowUserToAddRows = false;
            this.dtgconten.AllowUserToDeleteRows = false;
            this.dtgconten.AllowUserToResizeColumns = false;
            this.dtgconten.AllowUserToResizeRows = false;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(230)))), ((int)(((byte)(241)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(191)))), ((int)(((byte)(231)))));
            this.dtgconten.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.dtgconten.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgconten.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgconten.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(218)))), ((int)(((byte)(231)))));
            this.dtgconten.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgconten.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.dtgconten.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(129)))), ((int)(((byte)(189)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.DeepSkyBlue;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgconten.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dtgconten.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgconten.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.xpkid,
            this.xcuenta,
            this.xDescripcion,
            this.xDebeHaber,
            this.xIncluirFechas,
            this.xGlosa});
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(207)))), ((int)(((byte)(241)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgconten.DefaultCellStyle = dataGridViewCellStyle9;
            this.dtgconten.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dtgconten.EnableHeadersVisualStyles = false;
            this.dtgconten.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(179)))), ((int)(((byte)(215)))));
            this.dtgconten.Location = new System.Drawing.Point(12, 117);
            this.dtgconten.Name = "dtgconten";
            this.dtgconten.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dtgconten.RowHeadersVisible = false;
            this.dtgconten.RowTemplate.Height = 18;
            this.dtgconten.Size = new System.Drawing.Size(630, 248);
            this.dtgconten.TabIndex = 35;
            this.dtgconten.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgconten_RowEnter);
            // 
            // txtcuenta
            // 
            this.txtcuenta.BackColor = System.Drawing.Color.White;
            this.txtcuenta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtcuenta.ColorFondoMouseEncima = System.Drawing.Color.Empty;
            this.txtcuenta.ColorFondoMousePresionado = System.Drawing.Color.Empty;
            this.txtcuenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcuenta.ForeColor = System.Drawing.Color.Black;
            this.txtcuenta.Format = null;
            this.txtcuenta.Location = new System.Drawing.Point(82, 25);
            this.txtcuenta.MaxLength = 15;
            this.txtcuenta.Name = "txtcuenta";
            this.txtcuenta.NextControlOnEnter = null;
            this.txtcuenta.Size = new System.Drawing.Size(75, 21);
            this.txtcuenta.TabIndex = 36;
            this.txtcuenta.Text = "CUENTA";
            this.txtcuenta.TextoDefecto = "CUENTA";
            this.txtcuenta.TextoDefectoColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(129)))), ((int)(((byte)(189)))));
            this.txtcuenta.TiposDatos = HpResergerUserControls.TextBoxPer.ListaTipos.SoloNumeros;
            this.txtcuenta.TextChanged += new System.EventHandler(this.txtcuenta_TextChanged);
            this.txtcuenta.DoubleClick += new System.EventHandler(this.txtcuenta_DoubleClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(35, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 37;
            this.label2.Text = "Cuenta:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 37;
            this.label1.Text = "Descripción:";
            // 
            // txtdescripcion
            // 
            this.txtdescripcion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtdescripcion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(218)))), ((int)(((byte)(231)))));
            this.txtdescripcion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtdescripcion.ColorFondoMouseEncima = System.Drawing.Color.Empty;
            this.txtdescripcion.ColorFondoMousePresionado = System.Drawing.Color.Empty;
            this.txtdescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdescripcion.ForeColor = System.Drawing.Color.Black;
            this.txtdescripcion.Format = null;
            this.txtdescripcion.Location = new System.Drawing.Point(82, 50);
            this.txtdescripcion.MaxLength = 500;
            this.txtdescripcion.Name = "txtdescripcion";
            this.txtdescripcion.NextControlOnEnter = null;
            this.txtdescripcion.ReadOnly = true;
            this.txtdescripcion.Size = new System.Drawing.Size(471, 21);
            this.txtdescripcion.TabIndex = 36;
            this.txtdescripcion.Text = "Descripcion de la Cuenta";
            this.txtdescripcion.TextoDefecto = "Descripcion de la Cuenta";
            this.txtdescripcion.TextoDefectoColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(129)))), ((int)(((byte)(189)))));
            this.txtdescripcion.TiposDatos = HpResergerUserControls.TextBoxPer.ListaTipos.MayusculaCadaPalabra;
            // 
            // btnmodificar
            // 
            this.btnmodificar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnmodificar.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmodificar.Image = ((System.Drawing.Image)(resources.GetObject("btnmodificar.Image")));
            this.btnmodificar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnmodificar.Location = new System.Drawing.Point(559, 24);
            this.btnmodificar.Name = "btnmodificar";
            this.btnmodificar.Size = new System.Drawing.Size(83, 23);
            this.btnmodificar.TabIndex = 38;
            this.btnmodificar.Text = "Modificar";
            this.btnmodificar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnmodificar.UseVisualStyleBackColor = true;
            this.btnmodificar.Click += new System.EventHandler(this.btnmodificar_Click);
            // 
            // chkFecha
            // 
            this.chkFecha.AutoSize = true;
            this.chkFecha.BackColor = System.Drawing.Color.Transparent;
            this.chkFecha.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkFecha.ColorChecked = System.Drawing.Color.Empty;
            this.chkFecha.ColorUnChecked = System.Drawing.Color.Empty;
            this.chkFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.chkFecha.Location = new System.Drawing.Point(354, 26);
            this.chkFecha.Name = "chkFecha";
            this.chkFecha.Size = new System.Drawing.Size(161, 19);
            this.chkFecha.TabIndex = 39;
            this.chkFecha.Text = "Incluir Fecha en la Glosa";
            this.chkFecha.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(182, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 13);
            this.label3.TabIndex = 37;
            this.label3.Text = "Debe o Haber (D/H)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(43, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 37;
            this.label4.Text = "Glosa:";
            // 
            // txtglosa
            // 
            this.txtglosa.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtglosa.BackColor = System.Drawing.Color.White;
            this.txtglosa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtglosa.ColorFondoMouseEncima = System.Drawing.Color.Empty;
            this.txtglosa.ColorFondoMousePresionado = System.Drawing.Color.Empty;
            this.txtglosa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtglosa.ForeColor = System.Drawing.Color.Black;
            this.txtglosa.Format = null;
            this.txtglosa.Location = new System.Drawing.Point(82, 74);
            this.txtglosa.MaxLength = 500;
            this.txtglosa.Name = "txtglosa";
            this.txtglosa.NextControlOnEnter = null;
            this.txtglosa.Size = new System.Drawing.Size(471, 21);
            this.txtglosa.TabIndex = 36;
            this.txtglosa.Text = "Ingrese Glosa";
            this.txtglosa.TextoDefecto = "Ingrese Glosa";
            this.txtglosa.TextoDefectoColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(129)))), ((int)(((byte)(189)))));
            this.txtglosa.TiposDatos = HpResergerUserControls.TextBoxPer.ListaTipos.MayusculaCadaPalabra;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 101);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(185, 13);
            this.label6.TabIndex = 40;
            this.label6.Text = "Listado de las Opciones a Mostrar:";
            // 
            // cbodebe
            // 
            this.cbodebe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(218)))), ((int)(((byte)(231)))));
            this.cbodebe.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbodebe.FormattingEnabled = true;
            this.cbodebe.IndexText = null;
            this.cbodebe.Items.AddRange(new object[] {
            "D",
            "H"});
            this.cbodebe.Location = new System.Drawing.Point(289, 25);
            this.cbodebe.Name = "cbodebe";
            this.cbodebe.ReadOnly = false;
            this.cbodebe.Size = new System.Drawing.Size(65, 21);
            this.cbodebe.TabIndex = 41;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAceptar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(129)))), ((int)(((byte)(189)))));
            this.btnAceptar.FlatAppearance.BorderColor = System.Drawing.Color.Olive;
            this.btnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAceptar.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptar.ForeColor = System.Drawing.Color.White;
            this.btnAceptar.Location = new System.Drawing.Point(471, 371);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(83, 24);
            this.btnAceptar.TabIndex = 42;
            this.btnAceptar.Text = "&Aceptar";
            this.btnAceptar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAceptar.UseVisualStyleBackColor = false;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
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
            this.BtnCerrar.Location = new System.Drawing.Point(559, 371);
            this.BtnCerrar.Name = "BtnCerrar";
            this.BtnCerrar.Size = new System.Drawing.Size(83, 24);
            this.BtnCerrar.TabIndex = 43;
            this.BtnCerrar.Text = "&Cancelar";
            this.BtnCerrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnCerrar.UseVisualStyleBackColor = false;
            this.BtnCerrar.Click += new System.EventHandler(this.BtnCerrar_Click);
            // 
            // lblmsg
            // 
            this.lblmsg.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblmsg.AutoSize = true;
            this.lblmsg.BackColor = System.Drawing.Color.Transparent;
            this.lblmsg.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.lblmsg.Location = new System.Drawing.Point(8, 377);
            this.lblmsg.Name = "lblmsg";
            this.lblmsg.Size = new System.Drawing.Size(113, 13);
            this.lblmsg.TabIndex = 44;
            this.lblmsg.Text = "Total de Registros : 0";
            // 
            // xpkid
            // 
            this.xpkid.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.xpkid.DataPropertyName = "pkid";
            this.xpkid.HeaderText = "ID";
            this.xpkid.MinimumWidth = 25;
            this.xpkid.Name = "xpkid";
            this.xpkid.Width = 25;
            // 
            // xcuenta
            // 
            this.xcuenta.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.xcuenta.DataPropertyName = "cuenta";
            this.xcuenta.HeaderText = "Cuenta";
            this.xcuenta.MinimumWidth = 50;
            this.xcuenta.Name = "xcuenta";
            this.xcuenta.Width = 50;
            // 
            // xDescripcion
            // 
            this.xDescripcion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.xDescripcion.DataPropertyName = "descripcion";
            this.xDescripcion.HeaderText = "Descripcion";
            this.xDescripcion.MinimumWidth = 100;
            this.xDescripcion.Name = "xDescripcion";
            // 
            // xDebeHaber
            // 
            this.xDebeHaber.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.xDebeHaber.DataPropertyName = "debehaber";
            this.xDebeHaber.HeaderText = "D/H";
            this.xDebeHaber.MinimumWidth = 30;
            this.xDebeHaber.Name = "xDebeHaber";
            this.xDebeHaber.Width = 30;
            // 
            // xIncluirFechas
            // 
            this.xIncluirFechas.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.xIncluirFechas.DataPropertyName = "incluirfechaglosa";
            this.xIncluirFechas.FalseValue = "0";
            this.xIncluirFechas.HeaderText = "Incluir Fecha en Glosa";
            this.xIncluirFechas.MinimumWidth = 100;
            this.xIncluirFechas.Name = "xIncluirFechas";
            this.xIncluirFechas.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.xIncluirFechas.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.xIncluirFechas.TrueValue = "1";
            // 
            // xGlosa
            // 
            this.xGlosa.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.xGlosa.DataPropertyName = "glosa";
            this.xGlosa.HeaderText = "Glosa";
            this.xGlosa.Name = "xGlosa";
            // 
            // btnbuscar
            // 
            this.btnbuscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnbuscar.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnbuscar.Image = ((System.Drawing.Image)(resources.GetObject("btnbuscar.Image")));
            this.btnbuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnbuscar.Location = new System.Drawing.Point(159, 24);
            this.btnbuscar.Name = "btnbuscar";
            this.btnbuscar.Size = new System.Drawing.Size(23, 23);
            this.btnbuscar.TabIndex = 45;
            this.btnbuscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnbuscar.UseVisualStyleBackColor = true;
            this.btnbuscar.Click += new System.EventHandler(this.btnbuscar_Click);
            // 
            // frmConfigurarAsientosBoletas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(654, 400);
            this.Controls.Add(this.btnbuscar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.BtnCerrar);
            this.Controls.Add(this.lblmsg);
            this.Controls.Add(this.cbodebe);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.chkFecha);
            this.Controls.Add(this.btnmodificar);
            this.Controls.Add(this.txtglosa);
            this.Controls.Add(this.txtdescripcion);
            this.Controls.Add(this.txtcuenta);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtgconten);
            this.Controls.Add(this.label5);
            this.MinimumSize = new System.Drawing.Size(670, 439);
            this.Name = "frmConfigurarAsientosBoletas";
            this.Nombre = "Configuración de Asiento de Boletas";
            this.Text = "Configuración de Asiento de Boletas";
            this.Load += new System.EventHandler(this.frmConfigurarAsientosBoletas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgconten)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private HpResergerUserControls.Dtgconten dtgconten;
        private HpResergerUserControls.TextBoxPer txtcuenta;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private HpResergerUserControls.TextBoxPer txtdescripcion;
        private System.Windows.Forms.Button btnmodificar;
        private HpResergerUserControls.checkboxOre chkFecha;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private HpResergerUserControls.TextBoxPer txtglosa;
        private System.Windows.Forms.Label label6;
        private HpResergerUserControls.ComboBoxPer cbodebe;
        private HpResergerUserControls.ButtonPer btnAceptar;
        private HpResergerUserControls.ButtonPer BtnCerrar;
        private System.Windows.Forms.Label lblmsg;
        private System.Windows.Forms.DataGridViewTextBoxColumn xpkid;
        private System.Windows.Forms.DataGridViewTextBoxColumn xcuenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn xDescripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn xDebeHaber;
        private System.Windows.Forms.DataGridViewCheckBoxColumn xIncluirFechas;
        private System.Windows.Forms.DataGridViewTextBoxColumn xGlosa;
        private System.Windows.Forms.Button btnbuscar;
    }
}