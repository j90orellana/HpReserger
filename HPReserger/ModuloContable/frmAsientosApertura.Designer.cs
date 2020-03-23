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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAsientosApertura));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.dtgconten = new HpResergerUserControls.Dtgconten();
            this.btnPreliminar = new System.Windows.Forms.Button();
            this.btncancelar = new System.Windows.Forms.Button();
            this.cboempresa = new System.Windows.Forms.ComboBox();
            this.btnAplicar = new System.Windows.Forms.Button();
            this.btnExcel = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.lblmsg = new System.Windows.Forms.Label();
            this.cboproyecto = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.comboMesAño = new HpResergerUserControls.ComboMesAño();
            this.lbl1 = new System.Windows.Forms.Label();
            this.xcuentacontable = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xdescripcioncuenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xIdComprobante = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xNameComprobante = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xNumDoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xProveedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xTipoidPro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xNameProveedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xSumaDebe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xSumaHaber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xSaldoDeudor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xSaldoAcreedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xtcvompra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xtcVenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xMon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xMoneda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xfkNaturaleza = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtgconten)).BeginInit();
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
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DeepSkyBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgconten.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dtgconten.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgconten.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.xcuentacontable,
            this.xdescripcioncuenta,
            this.xIdComprobante,
            this.xNameComprobante,
            this.xNumDoc,
            this.xProveedor,
            this.xTipoidPro,
            this.xNameProveedor,
            this.xSumaDebe,
            this.xSumaHaber,
            this.xSaldoDeudor,
            this.xSaldoAcreedor,
            this.xtcvompra,
            this.xtcVenta,
            this.xMon,
            this.xMoneda,
            this.xfkNaturaleza});
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(207)))), ((int)(((byte)(241)))));
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgconten.DefaultCellStyle = dataGridViewCellStyle10;
            this.dtgconten.EnableHeadersVisualStyles = false;
            this.dtgconten.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(179)))), ((int)(((byte)(215)))));
            this.dtgconten.Location = new System.Drawing.Point(15, 81);
            this.dtgconten.Name = "dtgconten";
            this.dtgconten.ReadOnly = true;
            this.dtgconten.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dtgconten.RowHeadersVisible = false;
            this.dtgconten.RowTemplate.Height = 18;
            this.dtgconten.Size = new System.Drawing.Size(857, 394);
            this.dtgconten.TabIndex = 4;
            this.dtgconten.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgconten1_CellContentClick);
            // 
            // btnPreliminar
            // 
            this.btnPreliminar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPreliminar.Enabled = false;
            this.btnPreliminar.Image = ((System.Drawing.Image)(resources.GetObject("btnPreliminar.Image")));
            this.btnPreliminar.Location = new System.Drawing.Point(788, 55);
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
            this.btncancelar.Location = new System.Drawing.Point(797, 481);
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
            this.btnAplicar.Location = new System.Drawing.Point(681, 481);
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
            this.btnExcel.Location = new System.Drawing.Point(405, 481);
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.Size = new System.Drawing.Size(75, 23);
            this.btnExcel.TabIndex = 43;
            this.btnExcel.Text = "Excel";
            this.btnExcel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnExcel.UseVisualStyleBackColor = true;
            this.btnExcel.Click += new System.EventHandler(this.btnExcel_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(15, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(248, 13);
            this.label3.TabIndex = 45;
            this.label3.Text = "Resultado del Calculo de Asientos de Apertura";
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // lblmsg
            // 
            this.lblmsg.AutoSize = true;
            this.lblmsg.BackColor = System.Drawing.Color.Transparent;
            this.lblmsg.Location = new System.Drawing.Point(15, 486);
            this.lblmsg.Name = "lblmsg";
            this.lblmsg.Size = new System.Drawing.Size(110, 13);
            this.lblmsg.TabIndex = 72;
            this.lblmsg.Text = "Total de Registros: 0";
            // 
            // cboproyecto
            // 
            this.cboproyecto.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboproyecto.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboproyecto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(218)))), ((int)(((byte)(231)))));
            this.cboproyecto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboproyecto.FormattingEnabled = true;
            this.cboproyecto.Location = new System.Drawing.Point(519, 18);
            this.cboproyecto.Name = "cboproyecto";
            this.cboproyecto.Size = new System.Drawing.Size(253, 21);
            this.cboproyecto.TabIndex = 73;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.Transparent;
            this.label16.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(465, 22);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(54, 13);
            this.label16.TabIndex = 74;
            this.label16.Text = "Proyecto:";
            // 
            // comboMesAño
            // 
            this.comboMesAño.FechaConDiaActual = new System.DateTime(2020, 3, 23, 0, 0, 0, 0);
            this.comboMesAño.FechaFinMes = new System.DateTime(2020, 3, 31, 0, 0, 0, 0);
            this.comboMesAño.FechaInicioMes = new System.DateTime(2020, 3, 1, 0, 0, 0, 0);
            this.comboMesAño.Location = new System.Drawing.Point(19, 38);
            this.comboMesAño.Name = "comboMesAño";
            this.comboMesAño.Size = new System.Drawing.Size(100, 26);
            this.comboMesAño.TabIndex = 75;
            this.comboMesAño.VerAño = true;
            this.comboMesAño.VerMes = false;
            this.comboMesAño.CambioFechas += new System.EventHandler(this.comboMesAño_CambioFechas);
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.BackColor = System.Drawing.Color.Transparent;
            this.lbl1.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1.ForeColor = System.Drawing.Color.Crimson;
            this.lbl1.Location = new System.Drawing.Point(119, 45);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(0, 13);
            this.lbl1.TabIndex = 76;
            // 
            // xcuentacontable
            // 
            this.xcuentacontable.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.xcuentacontable.DataPropertyName = "cuenta";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.xcuentacontable.DefaultCellStyle = dataGridViewCellStyle3;
            this.xcuentacontable.HeaderText = "Cuenta Contable";
            this.xcuentacontable.MinimumWidth = 75;
            this.xcuentacontable.Name = "xcuentacontable";
            this.xcuentacontable.ReadOnly = true;
            this.xcuentacontable.Width = 75;
            // 
            // xdescripcioncuenta
            // 
            this.xdescripcioncuenta.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.xdescripcioncuenta.DataPropertyName = "descripcion";
            this.xdescripcioncuenta.HeaderText = "Descripción Cuenta";
            this.xdescripcioncuenta.MinimumWidth = 70;
            this.xdescripcioncuenta.Name = "xdescripcioncuenta";
            this.xdescripcioncuenta.ReadOnly = true;
            // 
            // xIdComprobante
            // 
            this.xIdComprobante.DataPropertyName = "IdComprobante";
            this.xIdComprobante.HeaderText = "Compro";
            this.xIdComprobante.MinimumWidth = 50;
            this.xIdComprobante.Name = "xIdComprobante";
            this.xIdComprobante.ReadOnly = true;
            this.xIdComprobante.Visible = false;
            // 
            // xNameComprobante
            // 
            this.xNameComprobante.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.xNameComprobante.DataPropertyName = "NameComprobante";
            this.xNameComprobante.HeaderText = "T.D.";
            this.xNameComprobante.MinimumWidth = 40;
            this.xNameComprobante.Name = "xNameComprobante";
            this.xNameComprobante.ReadOnly = true;
            this.xNameComprobante.ToolTipText = "Tipo Documento";
            this.xNameComprobante.Width = 40;
            // 
            // xNumDoc
            // 
            this.xNumDoc.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.xNumDoc.DataPropertyName = "NumDoc";
            this.xNumDoc.HeaderText = "NumDoc";
            this.xNumDoc.Name = "xNumDoc";
            this.xNumDoc.ReadOnly = true;
            this.xNumDoc.ToolTipText = "Número Comprobante";
            this.xNumDoc.Width = 75;
            // 
            // xProveedor
            // 
            this.xProveedor.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.xProveedor.DataPropertyName = "Proveedor";
            this.xProveedor.HeaderText = "Ruc";
            this.xProveedor.Name = "xProveedor";
            this.xProveedor.ReadOnly = true;
            this.xProveedor.Width = 50;
            // 
            // xTipoidPro
            // 
            this.xTipoidPro.DataPropertyName = "TipoidPro";
            this.xTipoidPro.HeaderText = "TipoidPro";
            this.xTipoidPro.Name = "xTipoidPro";
            this.xTipoidPro.ReadOnly = true;
            this.xTipoidPro.Visible = false;
            // 
            // xNameProveedor
            // 
            this.xNameProveedor.DataPropertyName = "NombreProveedor";
            this.xNameProveedor.HeaderText = "Proveedor";
            this.xNameProveedor.MinimumWidth = 60;
            this.xNameProveedor.Name = "xNameProveedor";
            this.xNameProveedor.ReadOnly = true;
            // 
            // xSumaDebe
            // 
            this.xSumaDebe.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.xSumaDebe.DataPropertyName = "SumaDebe";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle4.Format = "n2";
            this.xSumaDebe.DefaultCellStyle = dataGridViewCellStyle4;
            this.xSumaDebe.HeaderText = "Suma Debe";
            this.xSumaDebe.MinimumWidth = 70;
            this.xSumaDebe.Name = "xSumaDebe";
            this.xSumaDebe.ReadOnly = true;
            this.xSumaDebe.Width = 70;
            // 
            // xSumaHaber
            // 
            this.xSumaHaber.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.xSumaHaber.DataPropertyName = "SumaHaber";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle5.Format = "n2";
            this.xSumaHaber.DefaultCellStyle = dataGridViewCellStyle5;
            this.xSumaHaber.HeaderText = "Suma Haber";
            this.xSumaHaber.MinimumWidth = 70;
            this.xSumaHaber.Name = "xSumaHaber";
            this.xSumaHaber.ReadOnly = true;
            this.xSumaHaber.Width = 70;
            // 
            // xSaldoDeudor
            // 
            this.xSaldoDeudor.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.xSaldoDeudor.DataPropertyName = "SaldoDeudor";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle6.Format = "n2";
            this.xSaldoDeudor.DefaultCellStyle = dataGridViewCellStyle6;
            this.xSaldoDeudor.HeaderText = "Saldo Deudor";
            this.xSaldoDeudor.MinimumWidth = 70;
            this.xSaldoDeudor.Name = "xSaldoDeudor";
            this.xSaldoDeudor.ReadOnly = true;
            this.xSaldoDeudor.Width = 70;
            // 
            // xSaldoAcreedor
            // 
            this.xSaldoAcreedor.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.xSaldoAcreedor.DataPropertyName = "SaldoAcreedor";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle7.Format = "n2";
            this.xSaldoAcreedor.DefaultCellStyle = dataGridViewCellStyle7;
            this.xSaldoAcreedor.HeaderText = "Saldo Acreedor";
            this.xSaldoAcreedor.MinimumWidth = 70;
            this.xSaldoAcreedor.Name = "xSaldoAcreedor";
            this.xSaldoAcreedor.ReadOnly = true;
            this.xSaldoAcreedor.Width = 70;
            // 
            // xtcvompra
            // 
            this.xtcvompra.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.xtcvompra.DataPropertyName = "tccompra";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle8.Format = "n4";
            this.xtcvompra.DefaultCellStyle = dataGridViewCellStyle8;
            this.xtcvompra.HeaderText = "Tc Compra";
            this.xtcvompra.MinimumWidth = 60;
            this.xtcvompra.Name = "xtcvompra";
            this.xtcvompra.ReadOnly = true;
            this.xtcvompra.Width = 60;
            // 
            // xtcVenta
            // 
            this.xtcVenta.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.xtcVenta.DataPropertyName = "tcventa";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle9.Format = "n4";
            this.xtcVenta.DefaultCellStyle = dataGridViewCellStyle9;
            this.xtcVenta.HeaderText = "Tc Venta";
            this.xtcVenta.MinimumWidth = 60;
            this.xtcVenta.Name = "xtcVenta";
            this.xtcVenta.ReadOnly = true;
            this.xtcVenta.Width = 60;
            // 
            // xMon
            // 
            this.xMon.DataPropertyName = "Moneda";
            this.xMon.HeaderText = "Moneda";
            this.xMon.Name = "xMon";
            this.xMon.ReadOnly = true;
            this.xMon.Visible = false;
            // 
            // xMoneda
            // 
            this.xMoneda.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.xMoneda.DataPropertyName = "nmoneda";
            this.xMoneda.HeaderText = "Mon";
            this.xMoneda.MinimumWidth = 35;
            this.xMoneda.Name = "xMoneda";
            this.xMoneda.ReadOnly = true;
            this.xMoneda.Width = 35;
            // 
            // xfkNaturaleza
            // 
            this.xfkNaturaleza.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.xfkNaturaleza.DataPropertyName = "Naturaleza";
            this.xfkNaturaleza.HeaderText = "Natu.";
            this.xfkNaturaleza.MinimumWidth = 50;
            this.xfkNaturaleza.Name = "xfkNaturaleza";
            this.xfkNaturaleza.ReadOnly = true;
            this.xfkNaturaleza.Width = 50;
            // 
            // frmAsientosApertura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 513);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.cboproyecto);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.lblmsg);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnExcel);
            this.Controls.Add(this.btnAplicar);
            this.Controls.Add(this.cboempresa);
            this.Controls.Add(this.btnPreliminar);
            this.Controls.Add(this.btncancelar);
            this.Controls.Add(this.dtgconten);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboMesAño);
            this.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinimumSize = new System.Drawing.Size(900, 552);
            this.Name = "frmAsientosApertura";
            this.Nombre = "Proceso de Asientos de Apertura";
            this.Text = "Proceso de Asientos de Apertura";
            this.Load += new System.EventHandler(this.frmcierremensual_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgconten)).EndInit();
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
        private System.Windows.Forms.Label label3;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label lblmsg;
        private System.Windows.Forms.ComboBox cboproyecto;
        private System.Windows.Forms.Label label16;
        private HpResergerUserControls.ComboMesAño comboMesAño;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.DataGridViewTextBoxColumn xcuentacontable;
        private System.Windows.Forms.DataGridViewTextBoxColumn xdescripcioncuenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn xIdComprobante;
        private System.Windows.Forms.DataGridViewTextBoxColumn xNameComprobante;
        private System.Windows.Forms.DataGridViewTextBoxColumn xNumDoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn xProveedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn xTipoidPro;
        private System.Windows.Forms.DataGridViewTextBoxColumn xNameProveedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn xSumaDebe;
        private System.Windows.Forms.DataGridViewTextBoxColumn xSumaHaber;
        private System.Windows.Forms.DataGridViewTextBoxColumn xSaldoDeudor;
        private System.Windows.Forms.DataGridViewTextBoxColumn xSaldoAcreedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn xtcvompra;
        private System.Windows.Forms.DataGridViewTextBoxColumn xtcVenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn xMon;
        private System.Windows.Forms.DataGridViewTextBoxColumn xMoneda;
        private System.Windows.Forms.DataGridViewTextBoxColumn xfkNaturaleza;
    }
}