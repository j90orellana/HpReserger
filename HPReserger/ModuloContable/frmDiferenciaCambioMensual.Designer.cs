namespace HPReserger
{
    partial class frmDiferenciaCambioMensual
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDiferenciaCambioMensual));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cboperiodo = new System.Windows.Forms.ComboBox();
            this.dtgconten = new HpResergerUserControls.Dtgconten();
            this.xcuentacontable = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xdescripcioncuenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xMontoDolares = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xMontoSoles = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xFinMesSoles = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xDifCambio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xtcvompra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xtcVenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xfkNaturaleza = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnPreliminar = new System.Windows.Forms.Button();
            this.btncancelar = new System.Windows.Forms.Button();
            this.cboempresa = new System.Windows.Forms.ComboBox();
            this.btnAplicar = new System.Windows.Forms.Button();
            this.chkSaldos = new HpResergerUserControls.checkboxOre();
            this.chkDocumentos = new HpResergerUserControls.checkboxOre();
            this.btnExcel = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.lblmsg = new System.Windows.Forms.Label();
            this.cboproyecto = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.lbl1 = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgconten)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Empresa:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Periodo:";
            // 
            // cboperiodo
            // 
            this.cboperiodo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(218)))), ((int)(((byte)(231)))));
            this.cboperiodo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboperiodo.FormattingEnabled = true;
            this.cboperiodo.Location = new System.Drawing.Point(65, 40);
            this.cboperiodo.Name = "cboperiodo";
            this.cboperiodo.Size = new System.Drawing.Size(394, 21);
            this.cboperiodo.TabIndex = 3;
            this.cboperiodo.SelectedIndexChanged += new System.EventHandler(this.cboperiodo_SelectedIndexChanged);
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
            this.xMontoDolares,
            this.xMontoSoles,
            this.xFinMesSoles,
            this.xDifCambio,
            this.xtcvompra,
            this.xtcVenta,
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
            this.dtgconten.Location = new System.Drawing.Point(15, 113);
            this.dtgconten.Name = "dtgconten";
            this.dtgconten.ReadOnly = true;
            this.dtgconten.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dtgconten.RowHeadersVisible = false;
            this.dtgconten.RowTemplate.Height = 18;
            this.dtgconten.Size = new System.Drawing.Size(757, 362);
            this.dtgconten.TabIndex = 4;
            this.dtgconten.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgconten1_CellContentClick);
            // 
            // xcuentacontable
            // 
            this.xcuentacontable.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.xcuentacontable.DataPropertyName = "cuentacontable";
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
            this.xdescripcioncuenta.DataPropertyName = "cuenta_contable";
            this.xdescripcioncuenta.HeaderText = "Descripción Cuenta";
            this.xdescripcioncuenta.Name = "xdescripcioncuenta";
            this.xdescripcioncuenta.ReadOnly = true;
            // 
            // xMontoDolares
            // 
            this.xMontoDolares.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.xMontoDolares.DataPropertyName = "montodolares";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle4.Format = "n2";
            this.xMontoDolares.DefaultCellStyle = dataGridViewCellStyle4;
            this.xMontoDolares.HeaderText = "Monto Dolares";
            this.xMontoDolares.MinimumWidth = 70;
            this.xMontoDolares.Name = "xMontoDolares";
            this.xMontoDolares.ReadOnly = true;
            this.xMontoDolares.Width = 70;
            // 
            // xMontoSoles
            // 
            this.xMontoSoles.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.xMontoSoles.DataPropertyName = "montosoles";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle5.Format = "n2";
            this.xMontoSoles.DefaultCellStyle = dataGridViewCellStyle5;
            this.xMontoSoles.HeaderText = "Monto Soles";
            this.xMontoSoles.MinimumWidth = 70;
            this.xMontoSoles.Name = "xMontoSoles";
            this.xMontoSoles.ReadOnly = true;
            this.xMontoSoles.Width = 70;
            // 
            // xFinMesSoles
            // 
            this.xFinMesSoles.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.xFinMesSoles.DataPropertyName = "FinMesSoles";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle6.Format = "n2";
            this.xFinMesSoles.DefaultCellStyle = dataGridViewCellStyle6;
            this.xFinMesSoles.HeaderText = "FinMes Soles";
            this.xFinMesSoles.MinimumWidth = 70;
            this.xFinMesSoles.Name = "xFinMesSoles";
            this.xFinMesSoles.ReadOnly = true;
            this.xFinMesSoles.Width = 70;
            // 
            // xDifCambio
            // 
            this.xDifCambio.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.xDifCambio.DataPropertyName = "DifCambio";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle7.Format = "n2";
            this.xDifCambio.DefaultCellStyle = dataGridViewCellStyle7;
            this.xDifCambio.HeaderText = "Dif. Cambio";
            this.xDifCambio.MinimumWidth = 70;
            this.xDifCambio.Name = "xDifCambio";
            this.xDifCambio.ReadOnly = true;
            this.xDifCambio.Width = 70;
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
            // xfkNaturaleza
            // 
            this.xfkNaturaleza.DataPropertyName = "naturaleza";
            this.xfkNaturaleza.HeaderText = "Naturaleza";
            this.xfkNaturaleza.Name = "xfkNaturaleza";
            this.xfkNaturaleza.ReadOnly = true;
            this.xfkNaturaleza.Visible = false;
            // 
            // btnPreliminar
            // 
            this.btnPreliminar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPreliminar.Enabled = false;
            this.btnPreliminar.Image = ((System.Drawing.Image)(resources.GetObject("btnPreliminar.Image")));
            this.btnPreliminar.Location = new System.Drawing.Point(688, 87);
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
            this.btncancelar.Location = new System.Drawing.Point(697, 481);
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
            this.btnAplicar.Location = new System.Drawing.Point(581, 481);
            this.btnAplicar.Name = "btnAplicar";
            this.btnAplicar.Size = new System.Drawing.Size(110, 23);
            this.btnAplicar.TabIndex = 43;
            this.btnAplicar.Text = "Aplicar Asiento";
            this.btnAplicar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAplicar.UseVisualStyleBackColor = true;
            this.btnAplicar.Click += new System.EventHandler(this.btncerrar_Click);
            // 
            // chkSaldos
            // 
            this.chkSaldos.AutoSize = true;
            this.chkSaldos.BackColor = System.Drawing.Color.Transparent;
            this.chkSaldos.Checked = true;
            this.chkSaldos.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkSaldos.ColorChecked = System.Drawing.Color.Empty;
            this.chkSaldos.ColorUnChecked = System.Drawing.Color.Empty;
            this.chkSaldos.Enabled = false;
            this.chkSaldos.Location = new System.Drawing.Point(65, 63);
            this.chkSaldos.Name = "chkSaldos";
            this.chkSaldos.Size = new System.Drawing.Size(137, 17);
            this.chkSaldos.TabIndex = 44;
            this.chkSaldos.Text = "1.- por Saldo Cuentas";
            this.chkSaldos.UseVisualStyleBackColor = false;
            // 
            // chkDocumentos
            // 
            this.chkDocumentos.AutoSize = true;
            this.chkDocumentos.BackColor = System.Drawing.Color.Transparent;
            this.chkDocumentos.ColorChecked = System.Drawing.Color.Empty;
            this.chkDocumentos.ColorUnChecked = System.Drawing.Color.Empty;
            this.chkDocumentos.Enabled = false;
            this.chkDocumentos.Location = new System.Drawing.Point(65, 80);
            this.chkDocumentos.Name = "chkDocumentos";
            this.chkDocumentos.Size = new System.Drawing.Size(128, 17);
            this.chkDocumentos.TabIndex = 44;
            this.chkDocumentos.Text = "2.- por Documentos";
            this.chkDocumentos.UseVisualStyleBackColor = false;
            // 
            // btnExcel
            // 
            this.btnExcel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnExcel.Image = ((System.Drawing.Image)(resources.GetObject("btnExcel.Image")));
            this.btnExcel.Location = new System.Drawing.Point(355, 481);
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
            this.label3.Location = new System.Drawing.Point(12, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(297, 13);
            this.label3.TabIndex = 45;
            this.label3.Text = "Resultado del Calculo de Diferencia de Cambio Mensual";
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
            this.lblmsg.Location = new System.Drawing.Point(12, 486);
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
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.BackColor = System.Drawing.Color.Transparent;
            this.lbl1.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1.ForeColor = System.Drawing.Color.Crimson;
            this.lbl1.Location = new System.Drawing.Point(204, 65);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(0, 13);
            this.lbl1.TabIndex = 72;
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.BackColor = System.Drawing.Color.Transparent;
            this.lbl2.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl2.ForeColor = System.Drawing.Color.Crimson;
            this.lbl2.Location = new System.Drawing.Point(204, 82);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(0, 13);
            this.lbl2.TabIndex = 72;
            // 
            // frmDiferenciaCambioMensual
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 513);
            this.Controls.Add(this.cboproyecto);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.lblmsg);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.chkDocumentos);
            this.Controls.Add(this.chkSaldos);
            this.Controls.Add(this.btnExcel);
            this.Controls.Add(this.btnAplicar);
            this.Controls.Add(this.cboempresa);
            this.Controls.Add(this.btnPreliminar);
            this.Controls.Add(this.btncancelar);
            this.Controls.Add(this.dtgconten);
            this.Controls.Add(this.cboperiodo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinimumSize = new System.Drawing.Size(800, 552);
            this.Name = "frmDiferenciaCambioMensual";
            this.Nombre = "Diferencia de Cambio Mensual";
            this.Text = "Diferencia de Cambio Mensual";
            this.Load += new System.EventHandler(this.frmcierremensual_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgconten)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboperiodo;
        private HpResergerUserControls.Dtgconten dtgconten;
        private System.Windows.Forms.Button btnPreliminar;
        private System.Windows.Forms.Button btncancelar;
        private System.Windows.Forms.ComboBox cboempresa;
        private System.Windows.Forms.Button btnAplicar;
        private HpResergerUserControls.checkboxOre chkSaldos;
        private HpResergerUserControls.checkboxOre chkDocumentos;
        private System.Windows.Forms.Button btnExcel;
        private System.Windows.Forms.Label label3;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label lblmsg;
        private System.Windows.Forms.DataGridViewTextBoxColumn xcuentacontable;
        private System.Windows.Forms.DataGridViewTextBoxColumn xdescripcioncuenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn xMontoDolares;
        private System.Windows.Forms.DataGridViewTextBoxColumn xMontoSoles;
        private System.Windows.Forms.DataGridViewTextBoxColumn xFinMesSoles;
        private System.Windows.Forms.DataGridViewTextBoxColumn xDifCambio;
        private System.Windows.Forms.DataGridViewTextBoxColumn xtcvompra;
        private System.Windows.Forms.DataGridViewTextBoxColumn xtcVenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn xfkNaturaleza;
        private System.Windows.Forms.ComboBox cboproyecto;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label lbl2;
    }
}