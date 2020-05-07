namespace HPReserger
{
    partial class frmAsientosApertura
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle23 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle22 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAsientosApertura));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle24 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle25 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle32 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle26 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle27 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle28 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle29 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle30 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle31 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.dtgconten = new HpResergerUserControls.Dtgconten();
            this.xCuentaDebe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xSolesDebe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xSolesHaber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xDolaresDebe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xDolaresHaber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnPreliminar = new System.Windows.Forms.Button();
            this.btncancelar = new System.Windows.Forms.Button();
            this.cboempresa = new System.Windows.Forms.ComboBox();
            this.btnAplicar = new System.Windows.Forms.Button();
            this.btnExcel = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.lblmsg = new System.Windows.Forms.Label();
            this.cboproyectoCierre = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.comboMesAño = new HpResergerUserControls.ComboMesAño();
            this.lbl1 = new System.Windows.Forms.Label();
            this.rbCierre = new System.Windows.Forms.RadioButton();
            this.rbApertura = new System.Windows.Forms.RadioButton();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dtgcontenBalance = new HpResergerUserControls.Dtgconten();
            this.xcuo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xFechaContable = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xFechaRegistro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xFechaEmision = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xId_Comprobante = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xtipoComprobante = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xCod_Comprobante = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xNum_Comprobante = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xNum_Doc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xRazon_Social = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xGlosa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xCuenta_Contable = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xdescripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xCuentaBanco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xmoneda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xpen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xusd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xtipocambio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtgconten)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgcontenBalance)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Empresa:";
            // 
            // dtgconten
            // 
            this.dtgconten.AllowUserToAddRows = false;
            this.dtgconten.AllowUserToOrderColumns = true;
            this.dtgconten.AllowUserToResizeColumns = false;
            this.dtgconten.AllowUserToResizeRows = false;
            dataGridViewCellStyle17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(230)))), ((int)(((byte)(241)))));
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(191)))), ((int)(((byte)(231)))));
            this.dtgconten.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle17;
            this.dtgconten.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgconten.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(218)))), ((int)(((byte)(231)))));
            this.dtgconten.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgconten.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.dtgconten.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle18.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(129)))), ((int)(((byte)(189)))));
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle18.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.Color.DeepSkyBlue;
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgconten.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle18;
            this.dtgconten.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgconten.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.xCuentaDebe,
            this.xSolesDebe,
            this.xSolesHaber,
            this.xDolaresDebe,
            this.xDolaresHaber});
            dataGridViewCellStyle23.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle23.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle23.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle23.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle23.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(207)))), ((int)(((byte)(241)))));
            dataGridViewCellStyle23.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle23.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgconten.DefaultCellStyle = dataGridViewCellStyle23;
            this.dtgconten.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgconten.EnableHeadersVisualStyles = false;
            this.dtgconten.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(179)))), ((int)(((byte)(215)))));
            this.dtgconten.Location = new System.Drawing.Point(3, 3);
            this.dtgconten.Name = "dtgconten";
            this.dtgconten.ReadOnly = true;
            this.dtgconten.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dtgconten.RowHeadersVisible = false;
            this.dtgconten.RowTemplate.Height = 18;
            this.dtgconten.Size = new System.Drawing.Size(1016, 357);
            this.dtgconten.TabIndex = 4;
            this.dtgconten.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgconten1_CellContentClick);
            // 
            // xCuentaDebe
            // 
            this.xCuentaDebe.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.xCuentaDebe.DataPropertyName = "CuentaContable";
            this.xCuentaDebe.HeaderText = "Cuenta";
            this.xCuentaDebe.MinimumWidth = 200;
            this.xCuentaDebe.Name = "xCuentaDebe";
            this.xCuentaDebe.ReadOnly = true;
            // 
            // xSolesDebe
            // 
            this.xSolesDebe.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.xSolesDebe.DataPropertyName = "SolesDebe";
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle19.Format = "n2";
            this.xSolesDebe.DefaultCellStyle = dataGridViewCellStyle19;
            this.xSolesDebe.HeaderText = "Soles Debe";
            this.xSolesDebe.MinimumWidth = 60;
            this.xSolesDebe.Name = "xSolesDebe";
            this.xSolesDebe.ReadOnly = true;
            this.xSolesDebe.Width = 60;
            // 
            // xSolesHaber
            // 
            this.xSolesHaber.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.xSolesHaber.DataPropertyName = "SolesHaber";
            dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle20.Format = "n2";
            this.xSolesHaber.DefaultCellStyle = dataGridViewCellStyle20;
            this.xSolesHaber.HeaderText = "Soles Haber";
            this.xSolesHaber.MinimumWidth = 60;
            this.xSolesHaber.Name = "xSolesHaber";
            this.xSolesHaber.ReadOnly = true;
            this.xSolesHaber.Width = 60;
            // 
            // xDolaresDebe
            // 
            this.xDolaresDebe.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.xDolaresDebe.DataPropertyName = "DolaresDebe";
            dataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle21.Format = "n2";
            this.xDolaresDebe.DefaultCellStyle = dataGridViewCellStyle21;
            this.xDolaresDebe.HeaderText = "Dolares Debe";
            this.xDolaresDebe.MinimumWidth = 60;
            this.xDolaresDebe.Name = "xDolaresDebe";
            this.xDolaresDebe.ReadOnly = true;
            this.xDolaresDebe.Width = 60;
            // 
            // xDolaresHaber
            // 
            this.xDolaresHaber.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.xDolaresHaber.DataPropertyName = "DolaresHaber";
            dataGridViewCellStyle22.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle22.Format = "n2";
            this.xDolaresHaber.DefaultCellStyle = dataGridViewCellStyle22;
            this.xDolaresHaber.HeaderText = "Dolares Haber";
            this.xDolaresHaber.MinimumWidth = 60;
            this.xDolaresHaber.Name = "xDolaresHaber";
            this.xDolaresHaber.ReadOnly = true;
            this.xDolaresHaber.Width = 60;
            // 
            // btnPreliminar
            // 
            this.btnPreliminar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPreliminar.Enabled = false;
            this.btnPreliminar.Image = ((System.Drawing.Image)(resources.GetObject("btnPreliminar.Image")));
            this.btnPreliminar.Location = new System.Drawing.Point(961, 81);
            this.btnPreliminar.Name = "btnPreliminar";
            this.btnPreliminar.Size = new System.Drawing.Size(84, 23);
            this.btnPreliminar.TabIndex = 41;
            this.btnPreliminar.Text = "Preliminar";
            this.btnPreliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPreliminar.UseVisualStyleBackColor = true;
            this.btnPreliminar.EnabledChanged += new System.EventHandler(this.btnPreliminar_EnabledChanged);
            this.btnPreliminar.Click += new System.EventHandler(this.btnaceptar_Click);
            // 
            // btncancelar
            // 
            this.btncancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btncancelar.Image = ((System.Drawing.Image)(resources.GetObject("btncancelar.Image")));
            this.btncancelar.Location = new System.Drawing.Point(970, 481);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(75, 23);
            this.btncancelar.TabIndex = 40;
            this.btncancelar.Text = "Cancelar";
            this.btncancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btncancelar.UseVisualStyleBackColor = true;
            this.btncancelar.Click += new System.EventHandler(this.btncancelar_Click);
            // 
            // cboempresa
            // 
            this.cboempresa.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboempresa.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboempresa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(218)))), ((int)(((byte)(231)))));
            this.cboempresa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboempresa.FormattingEnabled = true;
            this.cboempresa.Location = new System.Drawing.Point(65, 17);
            this.cboempresa.Name = "cboempresa";
            this.cboempresa.Size = new System.Drawing.Size(394, 21);
            this.cboempresa.TabIndex = 42;
            this.cboempresa.SelectedIndexChanged += new System.EventHandler(this.cboempresa_SelectedIndexChanged);
            // 
            // btnAplicar
            // 
            this.btnAplicar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAplicar.Image = ((System.Drawing.Image)(resources.GetObject("btnAplicar.Image")));
            this.btnAplicar.Location = new System.Drawing.Point(854, 481);
            this.btnAplicar.Name = "btnAplicar";
            this.btnAplicar.Size = new System.Drawing.Size(110, 23);
            this.btnAplicar.TabIndex = 43;
            this.btnAplicar.Text = "Aplicar Asiento";
            this.btnAplicar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAplicar.UseVisualStyleBackColor = true;
            this.btnAplicar.Click += new System.EventHandler(this.btncerrar_Click);
            // 
            // btnExcel
            // 
            this.btnExcel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnExcel.Image = ((System.Drawing.Image)(resources.GetObject("btnExcel.Image")));
            this.btnExcel.Location = new System.Drawing.Point(491, 481);
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.Size = new System.Drawing.Size(75, 23);
            this.btnExcel.TabIndex = 43;
            this.btnExcel.Text = "Excel";
            this.btnExcel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnExcel.UseVisualStyleBackColor = true;
            this.btnExcel.Click += new System.EventHandler(this.btnExcel_Click);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // lblmsg
            // 
            this.lblmsg.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblmsg.AutoSize = true;
            this.lblmsg.BackColor = System.Drawing.Color.Transparent;
            this.lblmsg.Location = new System.Drawing.Point(15, 486);
            this.lblmsg.Name = "lblmsg";
            this.lblmsg.Size = new System.Drawing.Size(110, 13);
            this.lblmsg.TabIndex = 72;
            this.lblmsg.Text = "Total de Registros: 0";
            // 
            // cboproyectoCierre
            // 
            this.cboproyectoCierre.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboproyectoCierre.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboproyectoCierre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(218)))), ((int)(((byte)(231)))));
            this.cboproyectoCierre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboproyectoCierre.FormattingEnabled = true;
            this.cboproyectoCierre.Location = new System.Drawing.Point(520, 17);
            this.cboproyectoCierre.Name = "cboproyectoCierre";
            this.cboproyectoCierre.Size = new System.Drawing.Size(297, 21);
            this.cboproyectoCierre.TabIndex = 73;
            this.cboproyectoCierre.SelectedIndexChanged += new System.EventHandler(this.cboproyecto_SelectedIndexChanged);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.Transparent;
            this.label16.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(465, 21);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(54, 13);
            this.label16.TabIndex = 74;
            this.label16.Text = "Proyecto:";
            // 
            // comboMesAño
            // 
            this.comboMesAño.BackColor = System.Drawing.Color.Transparent;
            this.comboMesAño.FechaConDiaActual = new System.DateTime(2020, 5, 5, 0, 0, 0, 0);
            this.comboMesAño.FechaFinMes = new System.DateTime(2020, 5, 31, 0, 0, 0, 0);
            this.comboMesAño.FechaInicioMes = new System.DateTime(2020, 5, 1, 0, 0, 0, 0);
            this.comboMesAño.Location = new System.Drawing.Point(277, 39);
            this.comboMesAño.Name = "comboMesAño";
            this.comboMesAño.Size = new System.Drawing.Size(90, 26);
            this.comboMesAño.TabIndex = 75;
            this.comboMesAño.VerAño = true;
            this.comboMesAño.VerMes = false;
            this.comboMesAño.CambioFechas += new System.EventHandler(this.comboMesAño_CambioFechas);
            // 
            // lbl1
            // 
            this.lbl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl1.BackColor = System.Drawing.Color.Transparent;
            this.lbl1.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1.ForeColor = System.Drawing.Color.Crimson;
            this.lbl1.Location = new System.Drawing.Point(16, 67);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(937, 19);
            this.lbl1.TabIndex = 76;
            // 
            // rbCierre
            // 
            this.rbCierre.Appearance = System.Windows.Forms.Appearance.Button;
            this.rbCierre.BackColor = System.Drawing.Color.Transparent;
            this.rbCierre.Checked = true;
            this.rbCierre.Location = new System.Drawing.Point(65, 41);
            this.rbCierre.Name = "rbCierre";
            this.rbCierre.Size = new System.Drawing.Size(106, 23);
            this.rbCierre.TabIndex = 77;
            this.rbCierre.TabStop = true;
            this.rbCierre.Text = "Asiento Cierre";
            this.rbCierre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rbCierre.UseVisualStyleBackColor = false;
            // 
            // rbApertura
            // 
            this.rbApertura.Appearance = System.Windows.Forms.Appearance.Button;
            this.rbApertura.BackColor = System.Drawing.Color.Transparent;
            this.rbApertura.Location = new System.Drawing.Point(171, 41);
            this.rbApertura.Name = "rbApertura";
            this.rbApertura.Size = new System.Drawing.Size(106, 23);
            this.rbApertura.TabIndex = 77;
            this.rbApertura.Text = "Asiento Apertura";
            this.rbApertura.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rbApertura.UseVisualStyleBackColor = false;
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(15, 86);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1030, 389);
            this.tabControl1.TabIndex = 78;
            this.tabControl1.Selected += new System.Windows.Forms.TabControlEventHandler(this.tabControl1_Selected);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dtgconten);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1022, 363);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Dinámica del Resultado-Cierre";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dtgcontenBalance);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1022, 363);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "Dinámica del Balance-Cierre";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dtgcontenBalance
            // 
            this.dtgcontenBalance.AllowUserToAddRows = false;
            this.dtgcontenBalance.AllowUserToDeleteRows = false;
            this.dtgcontenBalance.AllowUserToResizeColumns = false;
            this.dtgcontenBalance.AllowUserToResizeRows = false;
            dataGridViewCellStyle24.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(230)))), ((int)(((byte)(241)))));
            dataGridViewCellStyle24.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle24.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(191)))), ((int)(((byte)(231)))));
            this.dtgcontenBalance.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle24;
            this.dtgcontenBalance.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgcontenBalance.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(218)))), ((int)(((byte)(231)))));
            this.dtgcontenBalance.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgcontenBalance.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.dtgcontenBalance.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle25.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle25.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(129)))), ((int)(((byte)(189)))));
            dataGridViewCellStyle25.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle25.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle25.SelectionBackColor = System.Drawing.Color.DeepSkyBlue;
            dataGridViewCellStyle25.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle25.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgcontenBalance.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle25;
            this.dtgcontenBalance.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgcontenBalance.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.xcuo,
            this.xFechaContable,
            this.xFechaRegistro,
            this.xFechaEmision,
            this.xId_Comprobante,
            this.xtipoComprobante,
            this.xCod_Comprobante,
            this.xNum_Comprobante,
            this.xNum_Doc,
            this.xRazon_Social,
            this.xGlosa,
            this.xCuenta_Contable,
            this.xdescripcion,
            this.xCuentaBanco,
            this.xmoneda,
            this.xpen,
            this.xusd,
            this.xtipocambio});
            dataGridViewCellStyle32.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle32.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle32.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle32.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle32.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(207)))), ((int)(((byte)(241)))));
            dataGridViewCellStyle32.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle32.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgcontenBalance.DefaultCellStyle = dataGridViewCellStyle32;
            this.dtgcontenBalance.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgcontenBalance.EnableHeadersVisualStyles = false;
            this.dtgcontenBalance.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(179)))), ((int)(((byte)(215)))));
            this.dtgcontenBalance.Location = new System.Drawing.Point(3, 3);
            this.dtgcontenBalance.Name = "dtgcontenBalance";
            this.dtgcontenBalance.ReadOnly = true;
            this.dtgcontenBalance.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dtgcontenBalance.RowHeadersVisible = false;
            this.dtgcontenBalance.RowTemplate.Height = 18;
            this.dtgcontenBalance.Size = new System.Drawing.Size(1016, 357);
            this.dtgcontenBalance.TabIndex = 5;
            // 
            // xcuo
            // 
            this.xcuo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.xcuo.DataPropertyName = "Cod_Asiento_Contable";
            this.xcuo.HeaderText = "CUO";
            this.xcuo.MinimumWidth = 40;
            this.xcuo.Name = "xcuo";
            this.xcuo.ReadOnly = true;
            this.xcuo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.xcuo.Width = 40;
            // 
            // xFechaContable
            // 
            this.xFechaContable.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.xFechaContable.DataPropertyName = "FechaContable";
            dataGridViewCellStyle26.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle26.Format = "d";
            this.xFechaContable.DefaultCellStyle = dataGridViewCellStyle26;
            this.xFechaContable.HeaderText = "Fecha Contable";
            this.xFechaContable.MinimumWidth = 60;
            this.xFechaContable.Name = "xFechaContable";
            this.xFechaContable.ReadOnly = true;
            this.xFechaContable.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.xFechaContable.Width = 60;
            // 
            // xFechaRegistro
            // 
            this.xFechaRegistro.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.xFechaRegistro.DataPropertyName = "FechaRegistro";
            dataGridViewCellStyle27.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle27.Format = "d";
            this.xFechaRegistro.DefaultCellStyle = dataGridViewCellStyle27;
            this.xFechaRegistro.HeaderText = "Fecha Registro";
            this.xFechaRegistro.MinimumWidth = 60;
            this.xFechaRegistro.Name = "xFechaRegistro";
            this.xFechaRegistro.ReadOnly = true;
            this.xFechaRegistro.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.xFechaRegistro.Width = 60;
            // 
            // xFechaEmision
            // 
            this.xFechaEmision.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCellsExceptHeader;
            this.xFechaEmision.DataPropertyName = "FechaEmision";
            dataGridViewCellStyle28.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle28.Format = "d";
            this.xFechaEmision.DefaultCellStyle = dataGridViewCellStyle28;
            this.xFechaEmision.HeaderText = "Fecha Emision";
            this.xFechaEmision.MinimumWidth = 60;
            this.xFechaEmision.Name = "xFechaEmision";
            this.xFechaEmision.ReadOnly = true;
            this.xFechaEmision.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.xFechaEmision.Width = 60;
            // 
            // xId_Comprobante
            // 
            this.xId_Comprobante.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.xId_Comprobante.DataPropertyName = "Id_Comprobante";
            this.xId_Comprobante.HeaderText = "id Sunat";
            this.xId_Comprobante.MinimumWidth = 50;
            this.xId_Comprobante.Name = "xId_Comprobante";
            this.xId_Comprobante.ReadOnly = true;
            this.xId_Comprobante.Visible = false;
            this.xId_Comprobante.Width = 50;
            // 
            // xtipoComprobante
            // 
            this.xtipoComprobante.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.xtipoComprobante.DataPropertyName = "tipoComprobante";
            this.xtipoComprobante.HeaderText = "Tipo Comp.";
            this.xtipoComprobante.MinimumWidth = 100;
            this.xtipoComprobante.Name = "xtipoComprobante";
            this.xtipoComprobante.ReadOnly = true;
            this.xtipoComprobante.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // xCod_Comprobante
            // 
            this.xCod_Comprobante.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.xCod_Comprobante.DataPropertyName = "Cod_Comprobante";
            this.xCod_Comprobante.HeaderText = "Serie Comp.";
            this.xCod_Comprobante.MinimumWidth = 60;
            this.xCod_Comprobante.Name = "xCod_Comprobante";
            this.xCod_Comprobante.ReadOnly = true;
            this.xCod_Comprobante.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.xCod_Comprobante.Width = 60;
            // 
            // xNum_Comprobante
            // 
            this.xNum_Comprobante.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.xNum_Comprobante.DataPropertyName = "Num_Comprobante";
            this.xNum_Comprobante.HeaderText = "Num Comp.";
            this.xNum_Comprobante.MinimumWidth = 60;
            this.xNum_Comprobante.Name = "xNum_Comprobante";
            this.xNum_Comprobante.ReadOnly = true;
            this.xNum_Comprobante.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.xNum_Comprobante.Width = 60;
            // 
            // xNum_Doc
            // 
            this.xNum_Doc.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.xNum_Doc.DataPropertyName = "Num_Doc";
            this.xNum_Doc.HeaderText = "Ruc";
            this.xNum_Doc.MinimumWidth = 65;
            this.xNum_Doc.Name = "xNum_Doc";
            this.xNum_Doc.ReadOnly = true;
            this.xNum_Doc.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.xNum_Doc.Width = 65;
            // 
            // xRazon_Social
            // 
            this.xRazon_Social.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.xRazon_Social.DataPropertyName = "Razon_Social";
            this.xRazon_Social.HeaderText = "Razon Social";
            this.xRazon_Social.MinimumWidth = 100;
            this.xRazon_Social.Name = "xRazon_Social";
            this.xRazon_Social.ReadOnly = true;
            this.xRazon_Social.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // xGlosa
            // 
            this.xGlosa.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.xGlosa.DataPropertyName = "Glosa";
            this.xGlosa.HeaderText = "Glosa";
            this.xGlosa.MinimumWidth = 100;
            this.xGlosa.Name = "xGlosa";
            this.xGlosa.ReadOnly = true;
            this.xGlosa.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // xCuenta_Contable
            // 
            this.xCuenta_Contable.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.xCuenta_Contable.DataPropertyName = "Cuenta_Contable";
            this.xCuenta_Contable.HeaderText = "Cuenta Contable";
            this.xCuenta_Contable.MinimumWidth = 60;
            this.xCuenta_Contable.Name = "xCuenta_Contable";
            this.xCuenta_Contable.ReadOnly = true;
            this.xCuenta_Contable.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.xCuenta_Contable.Width = 60;
            // 
            // xdescripcion
            // 
            this.xdescripcion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.xdescripcion.DataPropertyName = "descripcion";
            this.xdescripcion.HeaderText = "Desc. Cuenta";
            this.xdescripcion.MinimumWidth = 100;
            this.xdescripcion.Name = "xdescripcion";
            this.xdescripcion.ReadOnly = true;
            this.xdescripcion.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // xCuentaBanco
            // 
            this.xCuentaBanco.DataPropertyName = "CuentaBanco";
            this.xCuentaBanco.HeaderText = "CuentaBanco";
            this.xCuentaBanco.Name = "xCuentaBanco";
            this.xCuentaBanco.ReadOnly = true;
            this.xCuentaBanco.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.xCuentaBanco.Visible = false;
            // 
            // xmoneda
            // 
            this.xmoneda.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.xmoneda.DataPropertyName = "moneda";
            this.xmoneda.HeaderText = "Mon";
            this.xmoneda.MinimumWidth = 30;
            this.xmoneda.Name = "xmoneda";
            this.xmoneda.ReadOnly = true;
            this.xmoneda.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.xmoneda.Width = 30;
            // 
            // xpen
            // 
            this.xpen.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.xpen.DataPropertyName = "pen";
            dataGridViewCellStyle29.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle29.Format = "n2";
            this.xpen.DefaultCellStyle = dataGridViewCellStyle29;
            this.xpen.HeaderText = "PEN";
            this.xpen.MinimumWidth = 40;
            this.xpen.Name = "xpen";
            this.xpen.ReadOnly = true;
            this.xpen.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.xpen.Width = 40;
            // 
            // xusd
            // 
            this.xusd.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.xusd.DataPropertyName = "usd";
            dataGridViewCellStyle30.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle30.Format = "n2";
            this.xusd.DefaultCellStyle = dataGridViewCellStyle30;
            this.xusd.HeaderText = "USD";
            this.xusd.MinimumWidth = 40;
            this.xusd.Name = "xusd";
            this.xusd.ReadOnly = true;
            this.xusd.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.xusd.Width = 40;
            // 
            // xtipocambio
            // 
            this.xtipocambio.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.xtipocambio.DataPropertyName = "tipocambio";
            dataGridViewCellStyle31.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle31.Format = "n4";
            this.xtipocambio.DefaultCellStyle = dataGridViewCellStyle31;
            this.xtipocambio.HeaderText = "TC";
            this.xtipocambio.MinimumWidth = 30;
            this.xtipocambio.Name = "xtipocambio";
            this.xtipocambio.ReadOnly = true;
            this.xtipocambio.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.xtipocambio.Width = 30;
            // 
            // frmAsientosApertura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1057, 513);
            this.Controls.Add(this.btnPreliminar);
            this.Controls.Add(this.rbApertura);
            this.Controls.Add(this.rbCierre);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.cboproyectoCierre);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.lblmsg);
            this.Controls.Add(this.btnExcel);
            this.Controls.Add(this.btnAplicar);
            this.Controls.Add(this.cboempresa);
            this.Controls.Add(this.btncancelar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboMesAño);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinimumSize = new System.Drawing.Size(938, 552);
            this.Name = "frmAsientosApertura";
            this.Nombre = "Proceso de Asientos de Cierre y Apertura";
            this.Text = "Proceso de Asientos de Cierre y Apertura";
            this.Load += new System.EventHandler(this.frmcierremensual_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgconten)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgcontenBalance)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private HpResergerUserControls.Dtgconten dtgconten;
        private System.Windows.Forms.Button btnPreliminar;
        private System.Windows.Forms.Button btncancelar;
        private System.Windows.Forms.ComboBox cboempresa;
        private System.Windows.Forms.Button btnAplicar;
        private System.Windows.Forms.Button btnExcel;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label lblmsg;
        private System.Windows.Forms.ComboBox cboproyectoCierre;
        private System.Windows.Forms.Label label16;
        private HpResergerUserControls.ComboMesAño comboMesAño;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.DataGridViewTextBoxColumn xCuentaDebe;
        private System.Windows.Forms.DataGridViewTextBoxColumn xSolesDebe;
        private System.Windows.Forms.DataGridViewTextBoxColumn xSolesHaber;
        private System.Windows.Forms.DataGridViewTextBoxColumn xDolaresDebe;
        private System.Windows.Forms.DataGridViewTextBoxColumn xDolaresHaber;
        private System.Windows.Forms.RadioButton rbCierre;
        private System.Windows.Forms.RadioButton rbApertura;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage1;
        private HpResergerUserControls.Dtgconten dtgcontenBalance;
        private System.Windows.Forms.DataGridViewTextBoxColumn xcuo;
        private System.Windows.Forms.DataGridViewTextBoxColumn xFechaContable;
        private System.Windows.Forms.DataGridViewTextBoxColumn xFechaRegistro;
        private System.Windows.Forms.DataGridViewTextBoxColumn xFechaEmision;
        private System.Windows.Forms.DataGridViewTextBoxColumn xId_Comprobante;
        private System.Windows.Forms.DataGridViewTextBoxColumn xtipoComprobante;
        private System.Windows.Forms.DataGridViewTextBoxColumn xCod_Comprobante;
        private System.Windows.Forms.DataGridViewTextBoxColumn xNum_Comprobante;
        private System.Windows.Forms.DataGridViewTextBoxColumn xNum_Doc;
        private System.Windows.Forms.DataGridViewTextBoxColumn xRazon_Social;
        private System.Windows.Forms.DataGridViewTextBoxColumn xGlosa;
        private System.Windows.Forms.DataGridViewTextBoxColumn xCuenta_Contable;
        private System.Windows.Forms.DataGridViewTextBoxColumn xdescripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn xCuentaBanco;
        private System.Windows.Forms.DataGridViewTextBoxColumn xmoneda;
        private System.Windows.Forms.DataGridViewTextBoxColumn xpen;
        private System.Windows.Forms.DataGridViewTextBoxColumn xusd;
        private System.Windows.Forms.DataGridViewTextBoxColumn xtipocambio;
    }
}