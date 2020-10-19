namespace HPReserger.ModuloFinanzas
{
    partial class frmReporteConciliacionesFinanzas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReporteConciliacionesFinanzas));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle22 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle23 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle24 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle25 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle26 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle27 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle28 = new System.Windows.Forms.DataGridViewCellStyle();
            this.chkFecha = new System.Windows.Forms.CheckBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.btnExcel = new System.Windows.Forms.Button();
            this.btnexportarpdf = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblexcel = new System.Windows.Forms.Label();
            this.xUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xFechaCierre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xEstadoCuenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.xNroCta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xBanco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xEmpresa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtgconten = new HpResergerUserControls.Dtgconten();
            this.xNameCorto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnlimpiar = new System.Windows.Forms.Button();
            this.txtbusnrocuenta = new HpResergerUserControls.TextBoxPer();
            this.txtbusbanco = new HpResergerUserControls.TextBoxPer();
            this.cbofechafin = new HpResergerUserControls.ComboMesAño();
            this.cbofechaini = new HpResergerUserControls.ComboMesAño();
            this.lblRegistros = new System.Windows.Forms.Label();
            this.BtnCerrar = new HpResergerUserControls.ButtonPer();
            this.cboempresa = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtgconten)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // chkFecha
            // 
            this.chkFecha.AutoSize = true;
            this.chkFecha.BackColor = System.Drawing.Color.Transparent;
            this.chkFecha.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.chkFecha.Location = new System.Drawing.Point(317, 54);
            this.chkFecha.Name = "chkFecha";
            this.chkFecha.Size = new System.Drawing.Size(56, 17);
            this.chkFecha.TabIndex = 212;
            this.chkFecha.Text = "Fecha";
            this.chkFecha.UseVisualStyleBackColor = false;
            this.chkFecha.CheckedChanged += new System.EventHandler(this.chkFecha_CheckedChanged);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // btnExcel
            // 
            this.btnExcel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnExcel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcel.Image = ((System.Drawing.Image)(resources.GetObject("btnExcel.Image")));
            this.btnExcel.Location = new System.Drawing.Point(410, 542);
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.Size = new System.Drawing.Size(83, 24);
            this.btnExcel.TabIndex = 202;
            this.btnExcel.Text = "EXCEL";
            this.btnExcel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnExcel.UseVisualStyleBackColor = true;
            this.btnExcel.Click += new System.EventHandler(this.btnExcel_Click);
            // 
            // btnexportarpdf
            // 
            this.btnexportarpdf.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnexportarpdf.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnexportarpdf.Image = ((System.Drawing.Image)(resources.GetObject("btnexportarpdf.Image")));
            this.btnexportarpdf.Location = new System.Drawing.Point(606, 547);
            this.btnexportarpdf.Name = "btnexportarpdf";
            this.btnexportarpdf.Size = new System.Drawing.Size(83, 24);
            this.btnexportarpdf.TabIndex = 203;
            this.btnexportarpdf.Text = "PDF";
            this.btnexportarpdf.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnexportarpdf.UseVisualStyleBackColor = true;
            this.btnexportarpdf.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(11, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 13);
            this.label3.TabIndex = 209;
            this.label3.Text = "Opciones de Filtrado:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(589, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 13);
            this.label2.TabIndex = 208;
            this.label2.Text = "A:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(368, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 13);
            this.label1.TabIndex = 207;
            this.label1.Text = "De:";
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
            // xFechaCierre
            // 
            this.xFechaCierre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.xFechaCierre.DataPropertyName = "fechacierre";
            dataGridViewCellStyle22.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle22.Format = "MMMM/yyyy";
            this.xFechaCierre.DefaultCellStyle = dataGridViewCellStyle22;
            this.xFechaCierre.HeaderText = "Fecha Cierre";
            this.xFechaCierre.MinimumWidth = 100;
            this.xFechaCierre.Name = "xFechaCierre";
            this.xFechaCierre.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // xEstadoCuenta
            // 
            this.xEstadoCuenta.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.xEstadoCuenta.DataPropertyName = "estadocuenta";
            dataGridViewCellStyle23.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle23.Format = "n2";
            this.xEstadoCuenta.DefaultCellStyle = dataGridViewCellStyle23;
            this.xEstadoCuenta.HeaderText = "Estado Cuenta";
            this.xEstadoCuenta.MinimumWidth = 105;
            this.xEstadoCuenta.Name = "xEstadoCuenta";
            this.xEstadoCuenta.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.xEstadoCuenta.Width = 105;
            // 
            // btnActualizar
            // 
            this.btnActualizar.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizar.Image = ((System.Drawing.Image)(resources.GetObject("btnActualizar.Image")));
            this.btnActualizar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnActualizar.Location = new System.Drawing.Point(809, 22);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(82, 24);
            this.btnActualizar.TabIndex = 205;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // xNroCta
            // 
            this.xNroCta.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.xNroCta.DataPropertyName = "Nro_cta";
            dataGridViewCellStyle24.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.xNroCta.DefaultCellStyle = dataGridViewCellStyle24;
            this.xNroCta.HeaderText = "Nro Cuenta";
            this.xNroCta.MinimumWidth = 100;
            this.xNroCta.Name = "xNroCta";
            this.xNroCta.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
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
            // xEmpresa
            // 
            this.xEmpresa.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.xEmpresa.DataPropertyName = "empresa";
            this.xEmpresa.HeaderText = "Empresa";
            this.xEmpresa.MinimumWidth = 150;
            this.xEmpresa.Name = "xEmpresa";
            this.xEmpresa.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // dtgconten
            // 
            this.dtgconten.AllowUserToAddRows = false;
            this.dtgconten.AllowUserToOrderColumns = true;
            this.dtgconten.AllowUserToResizeColumns = false;
            this.dtgconten.AllowUserToResizeRows = false;
            dataGridViewCellStyle25.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(230)))), ((int)(((byte)(241)))));
            dataGridViewCellStyle25.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle25.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(191)))), ((int)(((byte)(231)))));
            this.dtgconten.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle25;
            this.dtgconten.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgconten.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(218)))), ((int)(((byte)(231)))));
            this.dtgconten.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgconten.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.dtgconten.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle26.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle26.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(129)))), ((int)(((byte)(189)))));
            dataGridViewCellStyle26.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle26.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle26.SelectionBackColor = System.Drawing.Color.DeepSkyBlue;
            dataGridViewCellStyle26.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle26.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgconten.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle26;
            this.dtgconten.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgconten.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.xEmpresa,
            this.xBanco,
            this.xNameCorto,
            this.xNroCta,
            this.xEstadoCuenta,
            this.xFechaCierre,
            this.xUsuario});
            dataGridViewCellStyle27.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle27.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle27.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle27.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle27.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(207)))), ((int)(((byte)(241)))));
            dataGridViewCellStyle27.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle27.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgconten.DefaultCellStyle = dataGridViewCellStyle27;
            this.dtgconten.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgconten.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dtgconten.EnableHeadersVisualStyles = false;
            this.dtgconten.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(179)))), ((int)(((byte)(215)))));
            this.dtgconten.Location = new System.Drawing.Point(3, 18);
            this.dtgconten.Name = "dtgconten";
            this.dtgconten.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle28.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle28.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle28.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle28.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle28.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle28.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle28.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgconten.RowHeadersDefaultCellStyle = dataGridViewCellStyle28;
            this.dtgconten.RowHeadersVisible = false;
            this.dtgconten.RowTemplate.Height = 18;
            this.dtgconten.Size = new System.Drawing.Size(872, 436);
            this.dtgconten.TabIndex = 0;
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
            this.tableLayoutPanel1.Location = new System.Drawing.Point(14, 79);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 15F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(878, 457);
            this.tableLayoutPanel1.TabIndex = 211;
            // 
            // btnlimpiar
            // 
            this.btnlimpiar.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlimpiar.Image = ((System.Drawing.Image)(resources.GetObject("btnlimpiar.Image")));
            this.btnlimpiar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnlimpiar.Location = new System.Drawing.Point(809, 49);
            this.btnlimpiar.Name = "btnlimpiar";
            this.btnlimpiar.Size = new System.Drawing.Size(82, 24);
            this.btnlimpiar.TabIndex = 206;
            this.btnlimpiar.Text = "Limpiar";
            this.btnlimpiar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnlimpiar.UseVisualStyleBackColor = true;
            this.btnlimpiar.Click += new System.EventHandler(this.btnlimpiar_Click);
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
            this.txtbusnrocuenta.Location = new System.Drawing.Point(14, 51);
            this.txtbusnrocuenta.MaxLength = 30;
            this.txtbusnrocuenta.Name = "txtbusnrocuenta";
            this.txtbusnrocuenta.NextControlOnEnter = null;
            this.txtbusnrocuenta.Size = new System.Drawing.Size(297, 21);
            this.txtbusnrocuenta.TabIndex = 199;
            this.txtbusnrocuenta.Text = "Buscar Nro Cuenta";
            this.txtbusnrocuenta.TextoDefecto = "Buscar Nro Cuenta";
            this.txtbusnrocuenta.TextoDefectoColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(129)))), ((int)(((byte)(189)))));
            this.txtbusnrocuenta.TiposDatos = HpResergerUserControls.TextBoxPer.ListaTipos.MayusculaCadaPalabra;
            this.txtbusnrocuenta.TextChanged += new System.EventHandler(this.txtbusempresa_TextChanged);
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
            this.txtbusbanco.Location = new System.Drawing.Point(366, 24);
            this.txtbusbanco.MaxLength = 30;
            this.txtbusbanco.Name = "txtbusbanco";
            this.txtbusbanco.NextControlOnEnter = null;
            this.txtbusbanco.Size = new System.Drawing.Size(351, 21);
            this.txtbusbanco.TabIndex = 198;
            this.txtbusbanco.Text = "Buscar Banco";
            this.txtbusbanco.TextoDefecto = "Buscar Banco";
            this.txtbusbanco.TextoDefectoColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(129)))), ((int)(((byte)(189)))));
            this.txtbusbanco.TiposDatos = HpResergerUserControls.TextBoxPer.ListaTipos.MayusculaCadaPalabra;
            this.txtbusbanco.TextChanged += new System.EventHandler(this.txtbusempresa_TextChanged);
            // 
            // cbofechafin
            // 
            this.cbofechafin.BackColor = System.Drawing.Color.Transparent;
            this.cbofechafin.Enabled = false;
            this.cbofechafin.FechaConDiaActual = new System.DateTime(2020, 10, 31, 0, 0, 0, 0);
            this.cbofechafin.FechaFinMes = new System.DateTime(2020, 10, 31, 0, 0, 0, 0);
            this.cbofechafin.FechaInicioMes = new System.DateTime(2020, 10, 1, 0, 0, 0, 0);
            this.cbofechafin.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbofechafin.Location = new System.Drawing.Point(606, 50);
            this.cbofechafin.Name = "cbofechafin";
            this.cbofechafin.Size = new System.Drawing.Size(197, 23);
            this.cbofechafin.TabIndex = 201;
            this.cbofechafin.VerAño = true;
            this.cbofechafin.VerMes = true;
            this.cbofechafin.CambioFechas += new System.EventHandler(this.cbofechaini_CambioFechas);
            // 
            // cbofechaini
            // 
            this.cbofechaini.BackColor = System.Drawing.Color.Transparent;
            this.cbofechaini.Enabled = false;
            this.cbofechaini.FechaConDiaActual = new System.DateTime(2020, 10, 31, 0, 0, 0, 0);
            this.cbofechaini.FechaFinMes = new System.DateTime(2020, 10, 31, 0, 0, 0, 0);
            this.cbofechaini.FechaInicioMes = new System.DateTime(2020, 10, 1, 0, 0, 0, 0);
            this.cbofechaini.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbofechaini.Location = new System.Drawing.Point(392, 50);
            this.cbofechaini.Name = "cbofechaini";
            this.cbofechaini.Size = new System.Drawing.Size(197, 23);
            this.cbofechaini.TabIndex = 200;
            this.cbofechaini.VerAño = true;
            this.cbofechaini.VerMes = true;
            this.cbofechaini.CambioFechas += new System.EventHandler(this.cbofechaini_CambioFechas);
            // 
            // lblRegistros
            // 
            this.lblRegistros.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblRegistros.AutoSize = true;
            this.lblRegistros.BackColor = System.Drawing.Color.Transparent;
            this.lblRegistros.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegistros.Location = new System.Drawing.Point(14, 547);
            this.lblRegistros.Name = "lblRegistros";
            this.lblRegistros.Size = new System.Drawing.Size(95, 13);
            this.lblRegistros.TabIndex = 210;
            this.lblRegistros.Text = "Total Registros: 0";
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
            this.BtnCerrar.Location = new System.Drawing.Point(809, 542);
            this.BtnCerrar.Name = "BtnCerrar";
            this.BtnCerrar.Size = new System.Drawing.Size(83, 24);
            this.BtnCerrar.TabIndex = 204;
            this.BtnCerrar.Text = "Cancelar";
            this.BtnCerrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnCerrar.UseVisualStyleBackColor = false;
            this.BtnCerrar.Click += new System.EventHandler(this.BtnCerrar_Click);
            // 
            // cboempresa
            // 
            this.cboempresa.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboempresa.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboempresa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(218)))), ((int)(((byte)(231)))));
            this.cboempresa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboempresa.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.cboempresa.FormattingEnabled = true;
            this.cboempresa.Location = new System.Drawing.Point(14, 24);
            this.cboempresa.Name = "cboempresa";
            this.cboempresa.Size = new System.Drawing.Size(346, 21);
            this.cboempresa.TabIndex = 213;
            this.cboempresa.SelectedIndexChanged += new System.EventHandler(this.cboempresa_SelectedIndexChanged);
            this.cboempresa.Click += new System.EventHandler(this.cboempresa_Click);
            // 
            // frmReporteConciliacionesFinanzas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(902, 575);
            this.Controls.Add(this.cboempresa);
            this.Controls.Add(this.chkFecha);
            this.Controls.Add(this.btnExcel);
            this.Controls.Add(this.btnexportarpdf);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.btnlimpiar);
            this.Controls.Add(this.txtbusnrocuenta);
            this.Controls.Add(this.txtbusbanco);
            this.Controls.Add(this.cbofechafin);
            this.Controls.Add(this.cbofechaini);
            this.Controls.Add(this.lblRegistros);
            this.Controls.Add(this.BtnCerrar);
            this.Name = "frmReporteConciliacionesFinanzas";
            this.Nombre = "Reporte Conciliacion - Finanzas";
            this.Text = "Reporte Conciliacion - Finanzas";
            this.Load += new System.EventHandler(this.frmReporteConciliacionesFinanzas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgconten)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chkFecha;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button btnExcel;
        private System.Windows.Forms.Button btnexportarpdf;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblexcel;
        private System.Windows.Forms.DataGridViewTextBoxColumn xUsuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn xFechaCierre;
        private System.Windows.Forms.DataGridViewTextBoxColumn xEstadoCuenta;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.DataGridViewTextBoxColumn xNroCta;
        private System.Windows.Forms.DataGridViewTextBoxColumn xBanco;
        private System.Windows.Forms.DataGridViewTextBoxColumn xEmpresa;
        private HpResergerUserControls.Dtgconten dtgconten;
        private System.Windows.Forms.DataGridViewTextBoxColumn xNameCorto;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnlimpiar;
        private HpResergerUserControls.TextBoxPer txtbusnrocuenta;
        private HpResergerUserControls.TextBoxPer txtbusbanco;
        private HpResergerUserControls.ComboMesAño cbofechafin;
        private HpResergerUserControls.ComboMesAño cbofechaini;
        private System.Windows.Forms.Label lblRegistros;
        private HpResergerUserControls.ButtonPer BtnCerrar;
        private System.Windows.Forms.ComboBox cboempresa;
    }
}