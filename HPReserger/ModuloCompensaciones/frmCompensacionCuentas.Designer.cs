namespace HPReserger.ModuloCompensaciones
{
    partial class frmCompensacionCuentas
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.cboempresa = new System.Windows.Forms.ComboBox();
            this.label18 = new System.Windows.Forms.Label();
            this.txtcuos = new HpResergerUserControls.TextBoxPer();
            this.label4 = new System.Windows.Forms.Label();
            this.btnPaso1 = new HpResergerUserControls.ButtonPer();
            this.label1 = new System.Windows.Forms.Label();
            this.dtgconten = new HpResergerUserControls.Dtgconten();
            this.btnProcesar = new HpResergerUserControls.ButtonPer();
            this.BtnCerrar = new HpResergerUserControls.ButtonPer();
            this.xok = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.xCUO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xCuenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.XDescripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xTC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xDebeSoles = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xDebeDolares = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xHaberSoles = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xHaberDOlares = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xNumDoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xidComprobante = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xCodComprobante = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xNumComprobante = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xRazonSocial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xCC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xFechaEmision = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xFechaVence = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xFechaREcepcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xGlosa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.txtGlosa = new HpResergerUserControls.TextBoxPer();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCuenta = new HpResergerUserControls.TextBoxPer();
            this.txtdescripcion = new HpResergerUserControls.TextBoxPer();
            this.lbltotalRegistros = new System.Windows.Forms.Label();
            this.txtSoles = new HpResergerUserControls.TextBoxPer();
            this.txtDolares = new HpResergerUserControls.TextBoxPer();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dtpFechaEmision = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.dtpFechaContable = new System.Windows.Forms.DateTimePicker();
            this.label19 = new System.Windows.Forms.Label();
            this.cbomoneda = new HpResergerUserControls.ComboBoxPer(this.components);
            this.cboproyecto = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgconten)).BeginInit();
            this.SuspendLayout();
            // 
            // cboempresa
            // 
            this.cboempresa.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboempresa.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboempresa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(218)))), ((int)(((byte)(231)))));
            this.cboempresa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboempresa.DropDownWidth = 250;
            this.cboempresa.FormattingEnabled = true;
            this.cboempresa.Location = new System.Drawing.Point(67, 26);
            this.cboempresa.Name = "cboempresa";
            this.cboempresa.Size = new System.Drawing.Size(344, 21);
            this.cboempresa.TabIndex = 20;
            this.cboempresa.SelectedIndexChanged += new System.EventHandler(this.cboempresa_SelectedIndexChanged);
            this.cboempresa.Click += new System.EventHandler(this.cboempresa_Click);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.BackColor = System.Drawing.Color.Transparent;
            this.label18.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(14, 30);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(53, 13);
            this.label18.TabIndex = 21;
            this.label18.Text = "Empresa:";
            // 
            // txtcuos
            // 
            this.txtcuos.BackColor = System.Drawing.Color.White;
            this.txtcuos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtcuos.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtcuos.ColorFondoMouseEncima = System.Drawing.Color.Empty;
            this.txtcuos.ColorFondoMousePresionado = System.Drawing.Color.Empty;
            this.txtcuos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcuos.ForeColor = System.Drawing.Color.Black;
            this.txtcuos.Format = null;
            this.txtcuos.Location = new System.Drawing.Point(14, 51);
            this.txtcuos.MaxLength = 300;
            this.txtcuos.Name = "txtcuos";
            this.txtcuos.NextControlOnEnter = null;
            this.txtcuos.Size = new System.Drawing.Size(643, 21);
            this.txtcuos.TabIndex = 351;
            this.txtcuos.Text = "INGRESE CUOS SEPARADOS POR UNA COMA MINIMO 2 CUOS";
            this.txtcuos.TextoDefecto = "INGRESE CUOS SEPARADOS POR UNA COMA MINIMO 2 CUOS";
            this.txtcuos.TextoDefectoColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(129)))), ((int)(((byte)(189)))));
            this.txtcuos.TiposDatos = HpResergerUserControls.TextBoxPer.ListaTipos.MayusculaCadaPalabra;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(14, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(268, 13);
            this.label4.TabIndex = 352;
            this.label4.Text = "1.- Seleccione la Empresa e Ingrese Minimo 2 Cuos";
            // 
            // btnPaso1
            // 
            this.btnPaso1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(129)))), ((int)(((byte)(189)))));
            this.btnPaso1.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnPaso1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPaso1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPaso1.ForeColor = System.Drawing.Color.White;
            this.btnPaso1.Location = new System.Drawing.Point(663, 50);
            this.btnPaso1.Name = "btnPaso1";
            this.btnPaso1.Size = new System.Drawing.Size(75, 23);
            this.btnPaso1.TabIndex = 353;
            this.btnPaso1.Tag = "1";
            this.btnPaso1.Text = "Avanzar";
            this.btnPaso1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPaso1.UseVisualStyleBackColor = false;
            this.btnPaso1.Click += new System.EventHandler(this.btnPaso1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(392, 13);
            this.label1.TabIndex = 354;
            this.label1.Text = "2.- Seleccione las Cuentas a Compensar e Ingrese los Datos para el Asiento";
            // 
            // dtgconten
            // 
            this.dtgconten.AllowUserToAddRows = false;
            this.dtgconten.AllowUserToOrderColumns = true;
            this.dtgconten.AllowUserToResizeColumns = false;
            this.dtgconten.AllowUserToResizeRows = false;
            this.dtgconten.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgconten.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgconten.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(218)))), ((int)(((byte)(231)))));
            this.dtgconten.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgconten.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.dtgconten.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(129)))), ((int)(((byte)(189)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DeepSkyBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgconten.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgconten.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgconten.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.xok,
            this.xCUO,
            this.xCuenta,
            this.XDescripcion,
            this.xTC,
            this.xDebeSoles,
            this.xDebeDolares,
            this.xHaberSoles,
            this.xHaberDOlares,
            this.xNumDoc,
            this.xidComprobante,
            this.xCodComprobante,
            this.xNumComprobante,
            this.xRazonSocial,
            this.xCC,
            this.xFechaEmision,
            this.xFechaVence,
            this.xFechaREcepcion,
            this.xGlosa});
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(207)))), ((int)(((byte)(241)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgconten.DefaultCellStyle = dataGridViewCellStyle7;
            this.dtgconten.EnableHeadersVisualStyles = false;
            this.dtgconten.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(179)))), ((int)(((byte)(215)))));
            this.dtgconten.Location = new System.Drawing.Point(14, 91);
            this.dtgconten.Name = "dtgconten";
            this.dtgconten.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgconten.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dtgconten.RowHeadersVisible = false;
            this.dtgconten.RowTemplate.Height = 18;
            this.dtgconten.Size = new System.Drawing.Size(858, 320);
            this.dtgconten.TabIndex = 355;
            this.dtgconten.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgconten_CellClick);
            this.dtgconten.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgconten_CellValueChanged);
            // 
            // btnProcesar
            // 
            this.btnProcesar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnProcesar.BackColor = System.Drawing.Color.SeaGreen;
            this.btnProcesar.FlatAppearance.BorderColor = System.Drawing.Color.Olive;
            this.btnProcesar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProcesar.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProcesar.ForeColor = System.Drawing.Color.White;
            this.btnProcesar.Location = new System.Drawing.Point(703, 530);
            this.btnProcesar.Name = "btnProcesar";
            this.btnProcesar.Size = new System.Drawing.Size(83, 23);
            this.btnProcesar.TabIndex = 357;
            this.btnProcesar.Text = "Procesar";
            this.btnProcesar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnProcesar.UseVisualStyleBackColor = false;
            this.btnProcesar.Visible = false;
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
            this.BtnCerrar.Location = new System.Drawing.Point(789, 530);
            this.BtnCerrar.Name = "BtnCerrar";
            this.BtnCerrar.Size = new System.Drawing.Size(83, 23);
            this.BtnCerrar.TabIndex = 356;
            this.BtnCerrar.Text = "Cancelar";
            this.BtnCerrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnCerrar.UseVisualStyleBackColor = false;
            this.BtnCerrar.Click += new System.EventHandler(this.BtnCerrar_Click);
            // 
            // xok
            // 
            this.xok.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.xok.DataPropertyName = "ok";
            this.xok.FalseValue = "0";
            this.xok.HeaderText = "Ok";
            this.xok.MinimumWidth = 25;
            this.xok.Name = "xok";
            this.xok.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.xok.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.xok.TrueValue = "1";
            this.xok.Width = 25;
            // 
            // xCUO
            // 
            this.xCUO.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.xCUO.DataPropertyName = "cuo";
            this.xCUO.HeaderText = "CUO";
            this.xCUO.MinimumWidth = 40;
            this.xCUO.Name = "xCUO";
            this.xCUO.ReadOnly = true;
            this.xCUO.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.xCUO.Width = 40;
            // 
            // xCuenta
            // 
            this.xCuenta.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.xCuenta.DataPropertyName = "cuenta";
            this.xCuenta.HeaderText = "Cuenta";
            this.xCuenta.MinimumWidth = 50;
            this.xCuenta.Name = "xCuenta";
            this.xCuenta.ReadOnly = true;
            this.xCuenta.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.xCuenta.Width = 50;
            // 
            // XDescripcion
            // 
            this.XDescripcion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.XDescripcion.DataPropertyName = "descripcion";
            this.XDescripcion.HeaderText = "Cuenta Contable";
            this.XDescripcion.MinimumWidth = 100;
            this.XDescripcion.Name = "XDescripcion";
            this.XDescripcion.ReadOnly = true;
            this.XDescripcion.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // xTC
            // 
            this.xTC.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.xTC.DataPropertyName = "tc";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.Format = "n4";
            this.xTC.DefaultCellStyle = dataGridViewCellStyle2;
            this.xTC.HeaderText = "TC";
            this.xTC.MinimumWidth = 30;
            this.xTC.Name = "xTC";
            this.xTC.ReadOnly = true;
            this.xTC.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.xTC.Width = 30;
            // 
            // xDebeSoles
            // 
            this.xDebeSoles.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.xDebeSoles.DataPropertyName = "debesoles";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.Format = "n2";
            this.xDebeSoles.DefaultCellStyle = dataGridViewCellStyle3;
            this.xDebeSoles.HeaderText = "Debe Soles";
            this.xDebeSoles.MinimumWidth = 60;
            this.xDebeSoles.Name = "xDebeSoles";
            this.xDebeSoles.ReadOnly = true;
            this.xDebeSoles.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.xDebeSoles.Width = 60;
            // 
            // xDebeDolares
            // 
            this.xDebeDolares.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.xDebeDolares.DataPropertyName = "debedolares";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle4.Format = "n2";
            this.xDebeDolares.DefaultCellStyle = dataGridViewCellStyle4;
            this.xDebeDolares.HeaderText = "Debe Dolares";
            this.xDebeDolares.MinimumWidth = 60;
            this.xDebeDolares.Name = "xDebeDolares";
            this.xDebeDolares.ReadOnly = true;
            this.xDebeDolares.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.xDebeDolares.Width = 60;
            // 
            // xHaberSoles
            // 
            this.xHaberSoles.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.xHaberSoles.DataPropertyName = "habersoles";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle5.Format = "n2";
            this.xHaberSoles.DefaultCellStyle = dataGridViewCellStyle5;
            this.xHaberSoles.HeaderText = "Haber Soles";
            this.xHaberSoles.MinimumWidth = 60;
            this.xHaberSoles.Name = "xHaberSoles";
            this.xHaberSoles.ReadOnly = true;
            this.xHaberSoles.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.xHaberSoles.Width = 60;
            // 
            // xHaberDOlares
            // 
            this.xHaberDOlares.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.xHaberDOlares.DataPropertyName = "haberdolares";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle6.Format = "n2";
            this.xHaberDOlares.DefaultCellStyle = dataGridViewCellStyle6;
            this.xHaberDOlares.HeaderText = "Haber Dolares";
            this.xHaberDOlares.MinimumWidth = 60;
            this.xHaberDOlares.Name = "xHaberDOlares";
            this.xHaberDOlares.ReadOnly = true;
            this.xHaberDOlares.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.xHaberDOlares.Width = 60;
            // 
            // xNumDoc
            // 
            this.xNumDoc.DataPropertyName = "numdoc";
            this.xNumDoc.HeaderText = "NumDoc";
            this.xNumDoc.Name = "xNumDoc";
            this.xNumDoc.Visible = false;
            // 
            // xidComprobante
            // 
            this.xidComprobante.DataPropertyName = "idcomprobante";
            this.xidComprobante.HeaderText = "IdComprobante";
            this.xidComprobante.Name = "xidComprobante";
            this.xidComprobante.Visible = false;
            // 
            // xCodComprobante
            // 
            this.xCodComprobante.DataPropertyName = "codcomprobante";
            this.xCodComprobante.HeaderText = "CodComprobante";
            this.xCodComprobante.Name = "xCodComprobante";
            this.xCodComprobante.Visible = false;
            // 
            // xNumComprobante
            // 
            this.xNumComprobante.DataPropertyName = "numcomprobante";
            this.xNumComprobante.HeaderText = "NumComprobante";
            this.xNumComprobante.Name = "xNumComprobante";
            this.xNumComprobante.Visible = false;
            // 
            // xRazonSocial
            // 
            this.xRazonSocial.DataPropertyName = "razonsocial";
            this.xRazonSocial.HeaderText = "RazonSocial";
            this.xRazonSocial.Name = "xRazonSocial";
            this.xRazonSocial.Visible = false;
            // 
            // xCC
            // 
            this.xCC.DataPropertyName = "cc";
            this.xCC.HeaderText = "CC";
            this.xCC.Name = "xCC";
            this.xCC.Visible = false;
            // 
            // xFechaEmision
            // 
            this.xFechaEmision.DataPropertyName = "fechaemision";
            this.xFechaEmision.HeaderText = "FechaEmision";
            this.xFechaEmision.Name = "xFechaEmision";
            this.xFechaEmision.Visible = false;
            // 
            // xFechaVence
            // 
            this.xFechaVence.DataPropertyName = "fechavence";
            this.xFechaVence.HeaderText = "FechaVence";
            this.xFechaVence.Name = "xFechaVence";
            this.xFechaVence.Visible = false;
            // 
            // xFechaREcepcion
            // 
            this.xFechaREcepcion.DataPropertyName = "fechaRecepcion";
            this.xFechaREcepcion.HeaderText = "FechaRecepcion";
            this.xFechaREcepcion.Name = "xFechaREcepcion";
            this.xFechaREcepcion.Visible = false;
            // 
            // xGlosa
            // 
            this.xGlosa.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.xGlosa.DataPropertyName = "glosa";
            this.xGlosa.HeaderText = "Glosa";
            this.xGlosa.MinimumWidth = 150;
            this.xGlosa.Name = "xGlosa";
            this.xGlosa.ReadOnly = true;
            this.xGlosa.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.xGlosa.Width = 150;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 414);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(286, 13);
            this.label2.TabIndex = 358;
            this.label2.Text = "3.-Ingrese los Datos para El Asiento de Compensación";
            // 
            // txtGlosa
            // 
            this.txtGlosa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtGlosa.BackColor = System.Drawing.Color.White;
            this.txtGlosa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtGlosa.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtGlosa.ColorFondoMouseEncima = System.Drawing.Color.Empty;
            this.txtGlosa.ColorFondoMousePresionado = System.Drawing.Color.Empty;
            this.txtGlosa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGlosa.ForeColor = System.Drawing.Color.Black;
            this.txtGlosa.Format = null;
            this.txtGlosa.Location = new System.Drawing.Point(14, 480);
            this.txtGlosa.MaxLength = 300;
            this.txtGlosa.Name = "txtGlosa";
            this.txtGlosa.NextControlOnEnter = null;
            this.txtGlosa.Size = new System.Drawing.Size(643, 21);
            this.txtGlosa.TabIndex = 359;
            this.txtGlosa.Text = "INGRESE LA GLOSA DEL ASIENTO";
            this.txtGlosa.TextoDefecto = "INGRESE LA GLOSA DEL ASIENTO";
            this.txtGlosa.TextoDefectoColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(129)))), ((int)(((byte)(189)))));
            this.txtGlosa.TiposDatos = HpResergerUserControls.TextBoxPer.ListaTipos.MayusculaCadaPalabra;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(14, 461);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 13);
            this.label3.TabIndex = 360;
            this.label3.Text = "Cuenta Enviar Dif:";
            // 
            // txtCuenta
            // 
            this.txtCuenta.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtCuenta.BackColor = System.Drawing.Color.White;
            this.txtCuenta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCuenta.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCuenta.ColorFondoMouseEncima = System.Drawing.Color.Empty;
            this.txtCuenta.ColorFondoMousePresionado = System.Drawing.Color.Empty;
            this.txtCuenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCuenta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(129)))), ((int)(((byte)(189)))));
            this.txtCuenta.Format = null;
            this.txtCuenta.Location = new System.Drawing.Point(118, 457);
            this.txtCuenta.MaxLength = 300;
            this.txtCuenta.Name = "txtCuenta";
            this.txtCuenta.NextControlOnEnter = null;
            this.txtCuenta.Size = new System.Drawing.Size(76, 21);
            this.txtCuenta.TabIndex = 361;
            this.txtCuenta.Text = "9999999";
            this.txtCuenta.TextoDefecto = "9999999";
            this.txtCuenta.TextoDefectoColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(129)))), ((int)(((byte)(189)))));
            this.txtCuenta.TiposDatos = HpResergerUserControls.TextBoxPer.ListaTipos.MayusculaCadaPalabra;
            this.txtCuenta.TextChanged += new System.EventHandler(this.txtCuenta_TextChanged);
            this.txtCuenta.DoubleClick += new System.EventHandler(this.txtCuenta_DoubleClick);
            // 
            // txtdescripcion
            // 
            this.txtdescripcion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtdescripcion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(218)))), ((int)(((byte)(231)))));
            this.txtdescripcion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtdescripcion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtdescripcion.ColorFondoMouseEncima = System.Drawing.Color.Empty;
            this.txtdescripcion.ColorFondoMousePresionado = System.Drawing.Color.Empty;
            this.txtdescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdescripcion.ForeColor = System.Drawing.Color.Black;
            this.txtdescripcion.Format = null;
            this.txtdescripcion.Location = new System.Drawing.Point(199, 457);
            this.txtdescripcion.MaxLength = 300;
            this.txtdescripcion.Name = "txtdescripcion";
            this.txtdescripcion.NextControlOnEnter = null;
            this.txtdescripcion.ReadOnly = true;
            this.txtdescripcion.Size = new System.Drawing.Size(458, 21);
            this.txtdescripcion.TabIndex = 361;
            this.txtdescripcion.Text = "DESCRIPCION DE LA CUENTA CONTABLE";
            this.txtdescripcion.TextoDefecto = "DESCRIPCION DE LA CUENTA CONTABLE";
            this.txtdescripcion.TextoDefectoColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(129)))), ((int)(((byte)(189)))));
            this.txtdescripcion.TiposDatos = HpResergerUserControls.TextBoxPer.ListaTipos.MayusculaCadaPalabra;
            // 
            // lbltotalRegistros
            // 
            this.lbltotalRegistros.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbltotalRegistros.AutoSize = true;
            this.lbltotalRegistros.BackColor = System.Drawing.Color.Transparent;
            this.lbltotalRegistros.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltotalRegistros.Location = new System.Drawing.Point(14, 399);
            this.lbltotalRegistros.Name = "lbltotalRegistros";
            this.lbltotalRegistros.Size = new System.Drawing.Size(86, 13);
            this.lbltotalRegistros.TabIndex = 362;
            this.lbltotalRegistros.Text = "Total Registros:";
            // 
            // txtSoles
            // 
            this.txtSoles.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtSoles.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(218)))), ((int)(((byte)(231)))));
            this.txtSoles.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSoles.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtSoles.ColorFondoMouseEncima = System.Drawing.Color.Empty;
            this.txtSoles.ColorFondoMousePresionado = System.Drawing.Color.Empty;
            this.txtSoles.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoles.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(129)))), ((int)(((byte)(189)))));
            this.txtSoles.Format = null;
            this.txtSoles.Location = new System.Drawing.Point(662, 480);
            this.txtSoles.MaxLength = 300;
            this.txtSoles.Name = "txtSoles";
            this.txtSoles.NextControlOnEnter = null;
            this.txtSoles.ReadOnly = true;
            this.txtSoles.Size = new System.Drawing.Size(104, 21);
            this.txtSoles.TabIndex = 363;
            this.txtSoles.Text = "0.00";
            this.txtSoles.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtSoles.TextoDefecto = "0.00";
            this.txtSoles.TextoDefectoColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(129)))), ((int)(((byte)(189)))));
            this.txtSoles.TiposDatos = HpResergerUserControls.TextBoxPer.ListaTipos.MayusculaCadaPalabra;
            // 
            // txtDolares
            // 
            this.txtDolares.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtDolares.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(218)))), ((int)(((byte)(231)))));
            this.txtDolares.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDolares.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDolares.ColorFondoMouseEncima = System.Drawing.Color.Empty;
            this.txtDolares.ColorFondoMousePresionado = System.Drawing.Color.Empty;
            this.txtDolares.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDolares.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(129)))), ((int)(((byte)(189)))));
            this.txtDolares.Format = null;
            this.txtDolares.Location = new System.Drawing.Point(768, 480);
            this.txtDolares.MaxLength = 300;
            this.txtDolares.Name = "txtDolares";
            this.txtDolares.NextControlOnEnter = null;
            this.txtDolares.ReadOnly = true;
            this.txtDolares.Size = new System.Drawing.Size(104, 21);
            this.txtDolares.TabIndex = 364;
            this.txtDolares.Text = "0.00";
            this.txtDolares.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtDolares.TextoDefecto = "0.00";
            this.txtDolares.TextoDefectoColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(129)))), ((int)(((byte)(189)))));
            this.txtDolares.TiposDatos = HpResergerUserControls.TextBoxPer.ListaTipos.MayusculaCadaPalabra;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(695, 461);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 362;
            this.label5.Text = "SOLES";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(793, 461);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 362;
            this.label6.Text = "DOLARES";
            // 
            // dtpFechaEmision
            // 
            this.dtpFechaEmision.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.dtpFechaEmision.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaEmision.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFechaEmision.Location = new System.Drawing.Point(118, 432);
            this.dtpFechaEmision.MaxDate = new System.DateTime(3000, 12, 31, 0, 0, 0, 0);
            this.dtpFechaEmision.MinDate = new System.DateTime(1950, 1, 1, 0, 0, 0, 0);
            this.dtpFechaEmision.Name = "dtpFechaEmision";
            this.dtpFechaEmision.Size = new System.Drawing.Size(76, 22);
            this.dtpFechaEmision.TabIndex = 367;
            this.dtpFechaEmision.Value = new System.DateTime(2017, 4, 27, 9, 44, 35, 0);
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(14, 437);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 13);
            this.label7.TabIndex = 368;
            this.label7.Text = "Fecha Emisión:";
            // 
            // dtpFechaContable
            // 
            this.dtpFechaContable.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.dtpFechaContable.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaContable.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFechaContable.Location = new System.Drawing.Point(289, 431);
            this.dtpFechaContable.MaxDate = new System.DateTime(3000, 12, 31, 0, 0, 0, 0);
            this.dtpFechaContable.MinDate = new System.DateTime(1950, 1, 1, 0, 0, 0, 0);
            this.dtpFechaContable.Name = "dtpFechaContable";
            this.dtpFechaContable.Size = new System.Drawing.Size(76, 22);
            this.dtpFechaContable.TabIndex = 365;
            this.dtpFechaContable.Value = new System.DateTime(2017, 4, 27, 9, 44, 35, 0);
            // 
            // label19
            // 
            this.label19.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label19.AutoSize = true;
            this.label19.BackColor = System.Drawing.Color.Transparent;
            this.label19.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(199, 436);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(90, 13);
            this.label19.TabIndex = 366;
            this.label19.Text = "Fecha Contable:";
            // 
            // cbomoneda
            // 
            this.cbomoneda.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cbomoneda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(218)))), ((int)(((byte)(231)))));
            this.cbomoneda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbomoneda.FormattingEnabled = true;
            this.cbomoneda.IndexText = null;
            this.cbomoneda.Location = new System.Drawing.Point(763, 433);
            this.cbomoneda.Name = "cbomoneda";
            this.cbomoneda.ReadOnly = false;
            this.cbomoneda.Size = new System.Drawing.Size(109, 21);
            this.cbomoneda.TabIndex = 370;
            // 
            // cboproyecto
            // 
            this.cboproyecto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cboproyecto.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboproyecto.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboproyecto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(218)))), ((int)(((byte)(231)))));
            this.cboproyecto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboproyecto.FormattingEnabled = true;
            this.cboproyecto.Location = new System.Drawing.Point(419, 432);
            this.cboproyecto.Name = "cboproyecto";
            this.cboproyecto.Size = new System.Drawing.Size(288, 21);
            this.cboproyecto.TabIndex = 369;
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(365, 436);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(54, 13);
            this.label9.TabIndex = 371;
            this.label9.Text = "Proyecto:";
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(713, 437);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 13);
            this.label8.TabIndex = 372;
            this.label8.Text = "Moneda";
            // 
            // frmCompensacionCuentas
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.cbomoneda);
            this.Controls.Add(this.cboproyecto);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dtpFechaEmision);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dtpFechaContable);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.txtDolares);
            this.Controls.Add(this.txtSoles);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lbltotalRegistros);
            this.Controls.Add(this.txtdescripcion);
            this.Controls.Add(this.txtCuenta);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtGlosa);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnProcesar);
            this.Controls.Add(this.BtnCerrar);
            this.Controls.Add(this.dtgconten);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnPaso1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtcuos);
            this.Controls.Add(this.cboempresa);
            this.Controls.Add(this.label18);
            this.MinimumSize = new System.Drawing.Size(900, 600);
            this.Name = "frmCompensacionCuentas";
            this.Nombre = "Compensación de Cuentas";
            this.Text = "Compensación de Cuentas";
            this.Load += new System.EventHandler(this.frmCompensacionCuentas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgconten)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboempresa;
        private System.Windows.Forms.Label label18;
        private HpResergerUserControls.TextBoxPer txtcuos;
        private System.Windows.Forms.Label label4;
        private HpResergerUserControls.ButtonPer btnPaso1;
        private System.Windows.Forms.Label label1;
        private HpResergerUserControls.Dtgconten dtgconten;
        private HpResergerUserControls.ButtonPer btnProcesar;
        private HpResergerUserControls.ButtonPer BtnCerrar;
        private System.Windows.Forms.DataGridViewCheckBoxColumn xok;
        private System.Windows.Forms.DataGridViewTextBoxColumn xCUO;
        private System.Windows.Forms.DataGridViewTextBoxColumn xCuenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn XDescripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn xTC;
        private System.Windows.Forms.DataGridViewTextBoxColumn xDebeSoles;
        private System.Windows.Forms.DataGridViewTextBoxColumn xDebeDolares;
        private System.Windows.Forms.DataGridViewTextBoxColumn xHaberSoles;
        private System.Windows.Forms.DataGridViewTextBoxColumn xHaberDOlares;
        private System.Windows.Forms.DataGridViewTextBoxColumn xNumDoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn xidComprobante;
        private System.Windows.Forms.DataGridViewTextBoxColumn xCodComprobante;
        private System.Windows.Forms.DataGridViewTextBoxColumn xNumComprobante;
        private System.Windows.Forms.DataGridViewTextBoxColumn xRazonSocial;
        private System.Windows.Forms.DataGridViewTextBoxColumn xCC;
        private System.Windows.Forms.DataGridViewTextBoxColumn xFechaEmision;
        private System.Windows.Forms.DataGridViewTextBoxColumn xFechaVence;
        private System.Windows.Forms.DataGridViewTextBoxColumn xFechaREcepcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn xGlosa;
        private System.Windows.Forms.Label label2;
        private HpResergerUserControls.TextBoxPer txtGlosa;
        private System.Windows.Forms.Label label3;
        private HpResergerUserControls.TextBoxPer txtCuenta;
        private HpResergerUserControls.TextBoxPer txtdescripcion;
        private System.Windows.Forms.Label lbltotalRegistros;
        private HpResergerUserControls.TextBoxPer txtSoles;
        private HpResergerUserControls.TextBoxPer txtDolares;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtpFechaEmision;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dtpFechaContable;
        private System.Windows.Forms.Label label19;
        private HpResergerUserControls.ComboBoxPer cbomoneda;
        private System.Windows.Forms.ComboBox cboproyecto;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
    }
}