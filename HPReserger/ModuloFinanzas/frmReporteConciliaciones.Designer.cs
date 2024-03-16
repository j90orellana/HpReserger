namespace HPReserger.ModuloFinanzas
{
    partial class frmReporteConciliaciones
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReporteConciliaciones));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.BtnCerrar = new HpResergerUserControls.ButtonPer();
            this.lblRegistros = new System.Windows.Forms.Label();
            this.cbofechaini = new HpResergerUserControls.ComboMesAño();
            this.cbofechafin = new HpResergerUserControls.ComboMesAño();
            this.txtbusEmpresa = new HpResergerUserControls.TextBoxPer();
            this.btnlimpiar = new System.Windows.Forms.Button();
            this.txtbusbanco = new HpResergerUserControls.TextBoxPer();
            this.txtbusnrocuenta = new HpResergerUserControls.TextBoxPer();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.dtgconten = new HpResergerUserControls.Dtgconten();
            this.xEmpresa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xBanco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xNameCorto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xNroCta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xEstadoCuenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xFechaCierre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblexcel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnexportarpdf = new System.Windows.Forms.Button();
            this.btnExcel = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.chkFecha = new System.Windows.Forms.CheckBox();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgconten)).BeginInit();
            this.SuspendLayout();
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
            this.BtnCerrar.Location = new System.Drawing.Point(807, 545);
            this.BtnCerrar.Name = "BtnCerrar";
            this.BtnCerrar.Size = new System.Drawing.Size(83, 24);
            this.BtnCerrar.TabIndex = 7;
            this.BtnCerrar.Text = "Cancelar";
            this.BtnCerrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnCerrar.UseVisualStyleBackColor = false;
            this.BtnCerrar.Click += new System.EventHandler(this.BtnCerrar_Click);
            // 
            // lblRegistros
            // 
            this.lblRegistros.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblRegistros.AutoSize = true;
            this.lblRegistros.BackColor = System.Drawing.Color.Transparent;
            this.lblRegistros.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegistros.Location = new System.Drawing.Point(12, 550);
            this.lblRegistros.Name = "lblRegistros";
            this.lblRegistros.Size = new System.Drawing.Size(95, 13);
            this.lblRegistros.TabIndex = 191;
            this.lblRegistros.Text = "Total Registros: 0";
            // 
            // cbofechaini
            // 
            this.cbofechaini.BackColor = System.Drawing.Color.Transparent;
            this.cbofechaini.Enabled = false;
            this.cbofechaini.FechaConDiaActual = new System.DateTime(2020, 8, 19, 0, 0, 0, 0);
            this.cbofechaini.FechaFinMes = new System.DateTime(2020, 8, 31, 0, 0, 0, 0);
            this.cbofechaini.FechaInicioMes = new System.DateTime(2020, 8, 1, 0, 0, 0, 0);
            this.cbofechaini.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbofechaini.Location = new System.Drawing.Point(390, 53);
            this.cbofechaini.Name = "cbofechaini";
            this.cbofechaini.Size = new System.Drawing.Size(197, 23);
            this.cbofechaini.TabIndex = 3;
            this.cbofechaini.VerAño = true;
            this.cbofechaini.VerMes = true;
            this.cbofechaini.CambioFechas += new System.EventHandler(this.cbofechaini_CambioFechas);
            // 
            // cbofechafin
            // 
            this.cbofechafin.BackColor = System.Drawing.Color.Transparent;
            this.cbofechafin.Enabled = false;
            this.cbofechafin.FechaConDiaActual = new System.DateTime(2020, 8, 19, 0, 0, 0, 0);
            this.cbofechafin.FechaFinMes = new System.DateTime(2020, 8, 31, 0, 0, 0, 0);
            this.cbofechafin.FechaInicioMes = new System.DateTime(2020, 8, 1, 0, 0, 0, 0);
            this.cbofechafin.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbofechafin.Location = new System.Drawing.Point(604, 53);
            this.cbofechafin.Name = "cbofechafin";
            this.cbofechafin.Size = new System.Drawing.Size(197, 23);
            this.cbofechafin.TabIndex = 4;
            this.cbofechafin.VerAño = true;
            this.cbofechafin.VerMes = true;
            this.cbofechafin.CambioFechas += new System.EventHandler(this.cbofechaini_CambioFechas);
            // 
            // txtbusEmpresa
            // 
            this.txtbusEmpresa.BackColor = System.Drawing.Color.White;
            this.txtbusEmpresa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtbusEmpresa.ColorFondoMouseEncima = System.Drawing.Color.Empty;
            this.txtbusEmpresa.ColorFondoMousePresionado = System.Drawing.Color.Empty;
            this.txtbusEmpresa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbusEmpresa.ForeColor = System.Drawing.Color.Black;
            this.txtbusEmpresa.Format = null;
            this.txtbusEmpresa.Location = new System.Drawing.Point(12, 27);
            this.txtbusEmpresa.MaxLength = 30;
            this.txtbusEmpresa.Name = "txtbusEmpresa";
            this.txtbusEmpresa.NextControlOnEnter = null;
            this.txtbusEmpresa.Size = new System.Drawing.Size(348, 21);
            this.txtbusEmpresa.TabIndex = 0;
            this.txtbusEmpresa.Text = "Buscar Empresa";
            this.txtbusEmpresa.TextoDefecto = "Buscar Empresa";
            this.txtbusEmpresa.TextoDefectoColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(129)))), ((int)(((byte)(189)))));
            this.txtbusEmpresa.TiposDatos = HpResergerUserControls.TextBoxPer.ListaTipos.MayusculaCadaPalabra;
            this.txtbusEmpresa.TextChanged += new System.EventHandler(this.txtbusempresa_TextChanged);
            // 
            // btnlimpiar
            // 
            this.btnlimpiar.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlimpiar.Image = ((System.Drawing.Image)(resources.GetObject("btnlimpiar.Image")));
            this.btnlimpiar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnlimpiar.Location = new System.Drawing.Point(807, 52);
            this.btnlimpiar.Name = "btnlimpiar";
            this.btnlimpiar.Size = new System.Drawing.Size(82, 24);
            this.btnlimpiar.TabIndex = 9;
            this.btnlimpiar.Text = "Limpiar";
            this.btnlimpiar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnlimpiar.UseVisualStyleBackColor = true;
            this.btnlimpiar.Click += new System.EventHandler(this.btnlimpiar_Click);
            // 
            // txtbusbanco
            // 
            this.txtbusbanco.BackColor = System.Drawing.Color.White;
            this.txtbusbanco.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtbusbanco.ColorFondoMouseEncima = System.Drawing.Color.Empty;
            this.txtbusbanco.ColorFondoMousePresionado = System.Drawing.Color.Empty;
            this.txtbusbanco.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbusbanco.ForeColor = System.Drawing.Color.Black;
            this.txtbusbanco.Format = null;
            this.txtbusbanco.Location = new System.Drawing.Point(364, 27);
            this.txtbusbanco.MaxLength = 30;
            this.txtbusbanco.Name = "txtbusbanco";
            this.txtbusbanco.NextControlOnEnter = null;
            this.txtbusbanco.Size = new System.Drawing.Size(351, 21);
            this.txtbusbanco.TabIndex = 1;
            this.txtbusbanco.Text = "Buscar Banco";
            this.txtbusbanco.TextoDefecto = "Buscar Banco";
            this.txtbusbanco.TextoDefectoColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(129)))), ((int)(((byte)(189)))));
            this.txtbusbanco.TiposDatos = HpResergerUserControls.TextBoxPer.ListaTipos.MayusculaCadaPalabra;
            this.txtbusbanco.TextChanged += new System.EventHandler(this.txtbusempresa_TextChanged);
            // 
            // txtbusnrocuenta
            // 
            this.txtbusnrocuenta.BackColor = System.Drawing.Color.White;
            this.txtbusnrocuenta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtbusnrocuenta.ColorFondoMouseEncima = System.Drawing.Color.Empty;
            this.txtbusnrocuenta.ColorFondoMousePresionado = System.Drawing.Color.Empty;
            this.txtbusnrocuenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbusnrocuenta.ForeColor = System.Drawing.Color.Black;
            this.txtbusnrocuenta.Format = null;
            this.txtbusnrocuenta.Location = new System.Drawing.Point(12, 54);
            this.txtbusnrocuenta.MaxLength = 30;
            this.txtbusnrocuenta.Name = "txtbusnrocuenta";
            this.txtbusnrocuenta.NextControlOnEnter = null;
            this.txtbusnrocuenta.Size = new System.Drawing.Size(297, 21);
            this.txtbusnrocuenta.TabIndex = 2;
            this.txtbusnrocuenta.Text = "Buscar Nro Cuenta";
            this.txtbusnrocuenta.TextoDefecto = "Buscar Nro Cuenta";
            this.txtbusnrocuenta.TextoDefectoColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(129)))), ((int)(((byte)(189)))));
            this.txtbusnrocuenta.TiposDatos = HpResergerUserControls.TextBoxPer.ListaTipos.MayusculaCadaPalabra;
            this.txtbusnrocuenta.TextChanged += new System.EventHandler(this.txtbusempresa_TextChanged);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.dtgconten, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblexcel, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 82);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 15F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(878, 457);
            this.tableLayoutPanel1.TabIndex = 195;
            // 
            // dtgconten
            // 
            this.dtgconten.AllowUserToAddRows = false;
            this.dtgconten.AllowUserToOrderColumns = true;
            this.dtgconten.AllowUserToResizeColumns = false;
            this.dtgconten.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(230)))), ((int)(((byte)(241)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(191)))), ((int)(((byte)(231)))));
            this.dtgconten.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgconten.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgconten.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(218)))), ((int)(((byte)(231)))));
            this.dtgconten.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgconten.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.dtgconten.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(129)))), ((int)(((byte)(189)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DeepSkyBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgconten.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dtgconten.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgconten.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.xEmpresa,
            this.xBanco,
            this.xNameCorto,
            this.xNroCta,
            this.xEstadoCuenta,
            this.xFechaCierre,
            this.xUsuario});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(207)))), ((int)(((byte)(241)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgconten.DefaultCellStyle = dataGridViewCellStyle6;
            this.dtgconten.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgconten.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dtgconten.EnableHeadersVisualStyles = false;
            this.dtgconten.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(179)))), ((int)(((byte)(215)))));
            this.dtgconten.Location = new System.Drawing.Point(3, 18);
            this.dtgconten.Name = "dtgconten";
            this.dtgconten.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgconten.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dtgconten.RowHeadersVisible = false;
            this.dtgconten.RowTemplate.Height = 18;
            this.dtgconten.Size = new System.Drawing.Size(872, 436);
            this.dtgconten.TabIndex = 0;
            // 
            // xEmpresa
            // 
            this.xEmpresa.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.xEmpresa.DataPropertyName = "empresa";
            this.xEmpresa.HeaderText = "Empresa";
            this.xEmpresa.MinimumWidth = 150;
            this.xEmpresa.Name = "xEmpresa";
            this.xEmpresa.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // xBanco
            // 
            this.xBanco.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.xBanco.DataPropertyName = "banco";
            this.xBanco.HeaderText = "Banco";
            this.xBanco.MinimumWidth = 100;
            this.xBanco.Name = "xBanco";
            this.xBanco.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // xNameCorto
            // 
            this.xNameCorto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.xNameCorto.DataPropertyName = "namecorto";
            this.xNameCorto.HeaderText = "Moneda";
            this.xNameCorto.MinimumWidth = 80;
            this.xNameCorto.Name = "xNameCorto";
            this.xNameCorto.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.xNameCorto.Width = 80;
            // 
            // xNroCta
            // 
            this.xNroCta.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.xNroCta.DataPropertyName = "Nro_cta";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.xNroCta.DefaultCellStyle = dataGridViewCellStyle3;
            this.xNroCta.HeaderText = "Nro Cuenta";
            this.xNroCta.MinimumWidth = 100;
            this.xNroCta.Name = "xNroCta";
            this.xNroCta.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // xEstadoCuenta
            // 
            this.xEstadoCuenta.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.xEstadoCuenta.DataPropertyName = "estadocuenta";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle4.Format = "n2";
            this.xEstadoCuenta.DefaultCellStyle = dataGridViewCellStyle4;
            this.xEstadoCuenta.HeaderText = "Estado Cuenta";
            this.xEstadoCuenta.MinimumWidth = 105;
            this.xEstadoCuenta.Name = "xEstadoCuenta";
            this.xEstadoCuenta.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.xEstadoCuenta.Width = 105;
            // 
            // xFechaCierre
            // 
            this.xFechaCierre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.xFechaCierre.DataPropertyName = "fechacierre";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle5.Format = "MMMM/yyyy";
            this.xFechaCierre.DefaultCellStyle = dataGridViewCellStyle5;
            this.xFechaCierre.HeaderText = "Fecha Cierre";
            this.xFechaCierre.MinimumWidth = 100;
            this.xFechaCierre.Name = "xFechaCierre";
            this.xFechaCierre.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // xUsuario
            // 
            this.xUsuario.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.xUsuario.DataPropertyName = "usuario";
            this.xUsuario.HeaderText = "Usuario";
            this.xUsuario.MinimumWidth = 50;
            this.xUsuario.Name = "xUsuario";
            this.xUsuario.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.xUsuario.Width = 50;
            // 
            // lblexcel
            // 
            this.lblexcel.AutoSize = true;
            this.lblexcel.BackColor = System.Drawing.Color.Transparent;
            this.lblexcel.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblexcel.Location = new System.Drawing.Point(3, 0);
            this.lblexcel.Name = "lblexcel";
            this.lblexcel.Size = new System.Drawing.Size(193, 13);
            this.lblexcel.TabIndex = 43;
            this.lblexcel.Text = "Listado de Conciliaciones Bancarias.";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(366, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 13);
            this.label1.TabIndex = 43;
            this.label1.Text = "De:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(587, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 13);
            this.label2.TabIndex = 43;
            this.label2.Text = "A:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(9, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 13);
            this.label3.TabIndex = 43;
            this.label3.Text = "Opciones de Filtrado:";
            // 
            // btnexportarpdf
            // 
            this.btnexportarpdf.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnexportarpdf.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnexportarpdf.Image = ((System.Drawing.Image)(resources.GetObject("btnexportarpdf.Image")));
            this.btnexportarpdf.Location = new System.Drawing.Point(453, 545);
            this.btnexportarpdf.Name = "btnexportarpdf";
            this.btnexportarpdf.Size = new System.Drawing.Size(83, 24);
            this.btnexportarpdf.TabIndex = 6;
            this.btnexportarpdf.Text = "PDF";
            this.btnexportarpdf.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnexportarpdf.UseVisualStyleBackColor = true;
            this.btnexportarpdf.Click += new System.EventHandler(this.btnexportarpdf_Click);
            // 
            // btnExcel
            // 
            this.btnExcel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnExcel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcel.Image = ((System.Drawing.Image)(resources.GetObject("btnExcel.Image")));
            this.btnExcel.Location = new System.Drawing.Point(367, 545);
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.Size = new System.Drawing.Size(83, 24);
            this.btnExcel.TabIndex = 5;
            this.btnExcel.Text = "EXCEL";
            this.btnExcel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnExcel.UseVisualStyleBackColor = true;
            this.btnExcel.Click += new System.EventHandler(this.btnExcel_Click);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // btnActualizar
            // 
            this.btnActualizar.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizar.Image = ((System.Drawing.Image)(resources.GetObject("btnActualizar.Image")));
            this.btnActualizar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnActualizar.Location = new System.Drawing.Point(807, 25);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(82, 24);
            this.btnActualizar.TabIndex = 8;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // chkFecha
            // 
            this.chkFecha.AutoSize = true;
            this.chkFecha.BackColor = System.Drawing.Color.Transparent;
            this.chkFecha.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.chkFecha.Location = new System.Drawing.Point(315, 57);
            this.chkFecha.Name = "chkFecha";
            this.chkFecha.Size = new System.Drawing.Size(56, 17);
            this.chkFecha.TabIndex = 196;
            this.chkFecha.Text = "Fecha";
            this.chkFecha.UseVisualStyleBackColor = false;
            this.chkFecha.CheckedChanged += new System.EventHandler(this.chkFecha_CheckedChanged);
            // 
            // frmReporteConciliaciones
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(902, 575);
            this.Controls.Add(this.btnExcel);
            this.Controls.Add(this.btnexportarpdf);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.btnlimpiar);
            this.Controls.Add(this.txtbusnrocuenta);
            this.Controls.Add(this.txtbusbanco);
            this.Controls.Add(this.txtbusEmpresa);
            this.Controls.Add(this.cbofechafin);
            this.Controls.Add(this.cbofechaini);
            this.Controls.Add(this.lblRegistros);
            this.Controls.Add(this.BtnCerrar);
            this.Controls.Add(this.chkFecha);
            this.MinimumSize = new System.Drawing.Size(918, 614);
            this.Name = "frmReporteConciliaciones";
            this.Nombre = "Listado de Conciliaciones";
            this.Text = "Listado de Conciliaciones";
            this.Load += new System.EventHandler(this.frmReporteConciliaciones_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgconten)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private HpResergerUserControls.ButtonPer BtnCerrar;
        private System.Windows.Forms.Label lblRegistros;
        private HpResergerUserControls.ComboMesAño cbofechaini;
        private HpResergerUserControls.ComboMesAño cbofechafin;
        private HpResergerUserControls.TextBoxPer txtbusEmpresa;
        private System.Windows.Forms.Button btnlimpiar;
        private HpResergerUserControls.TextBoxPer txtbusbanco;
        private HpResergerUserControls.TextBoxPer txtbusnrocuenta;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private HpResergerUserControls.Dtgconten dtgconten;
        private System.Windows.Forms.Label lblexcel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn xEmpresa;
        private System.Windows.Forms.DataGridViewTextBoxColumn xBanco;
        private System.Windows.Forms.DataGridViewTextBoxColumn xNameCorto;
        private System.Windows.Forms.DataGridViewTextBoxColumn xNroCta;
        private System.Windows.Forms.DataGridViewTextBoxColumn xEstadoCuenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn xFechaCierre;
        private System.Windows.Forms.DataGridViewTextBoxColumn xUsuario;
        private System.Windows.Forms.Button btnexportarpdf;
        private System.Windows.Forms.Button btnExcel;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.CheckBox chkFecha;
    }
}