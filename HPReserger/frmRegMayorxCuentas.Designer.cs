namespace HPReserger
{
    partial class frmRegMayorxCuentas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRegMayorxCuentas));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            this.button1 = new System.Windows.Forms.Button();
            this.btnexcel = new System.Windows.Forms.Button();
            this.btncancelar = new System.Windows.Forms.Button();
            this.lblmensaje = new System.Windows.Forms.Label();
            this.btngenerar = new System.Windows.Forms.Button();
            this.separadorOre1 = new HpResergerUserControls.SeparadorOre();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtgconten = new HpResergerUserControls.Dtgconten();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.txtbuscuenta = new HpResergerUserControls.TextBoxPer();
            this.chklist = new System.Windows.Forms.CheckedListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpfechaini = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpfechafin = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.txtbusGlosa = new HpResergerUserControls.TextBoxPer();
            this.label7 = new System.Windows.Forms.Label();
            this.txtbusnrodoc = new HpResergerUserControls.TextBoxPer();
            this.label8 = new System.Windows.Forms.Label();
            this.txtbusruc = new HpResergerUserControls.TextBoxPer();
            this.label9 = new System.Windows.Forms.Label();
            this.txtbusrazon = new HpResergerUserControls.TextBoxPer();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btnbusCuenta = new System.Windows.Forms.Button();
            this.xPeriodo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xRUC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xCod_Asiento_Contable = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xEmpresa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xFechaContable = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xFechaEmision = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xId_Comprobante = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xTipoComprobante = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xCod_Comprobante = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xNum_Comprobante = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xNum_Doc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xRazon_Social = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xGlosa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xCuenta_Contable = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xDESCRIPCION = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xCuentaBanco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xMoneda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xPEN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xUSD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xMes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xTipoCambio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xUsers = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtgconten)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(549, 530);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(82, 23);
            this.button1.TabIndex = 386;
            this.button1.Text = "Pdf";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            // 
            // btnexcel
            // 
            this.btnexcel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnexcel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnexcel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnexcel.Image = ((System.Drawing.Image)(resources.GetObject("btnexcel.Image")));
            this.btnexcel.Location = new System.Drawing.Point(637, 530);
            this.btnexcel.Name = "btnexcel";
            this.btnexcel.Size = new System.Drawing.Size(82, 23);
            this.btnexcel.TabIndex = 385;
            this.btnexcel.Text = "Excel";
            this.btnexcel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnexcel.UseVisualStyleBackColor = true;
            this.btnexcel.Click += new System.EventHandler(this.btnexcel_Click);
            // 
            // btncancelar
            // 
            this.btncancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btncancelar.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncancelar.Image = ((System.Drawing.Image)(resources.GetObject("btncancelar.Image")));
            this.btncancelar.Location = new System.Drawing.Point(1129, 530);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(85, 23);
            this.btncancelar.TabIndex = 384;
            this.btncancelar.Text = "Cancelar";
            this.btncancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btncancelar.UseVisualStyleBackColor = true;
            this.btncancelar.Click += new System.EventHandler(this.btncancelar_Click);
            // 
            // lblmensaje
            // 
            this.lblmensaje.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblmensaje.AutoSize = true;
            this.lblmensaje.BackColor = System.Drawing.Color.Transparent;
            this.lblmensaje.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmensaje.Location = new System.Drawing.Point(14, 535);
            this.lblmensaje.Name = "lblmensaje";
            this.lblmensaje.Size = new System.Drawing.Size(110, 13);
            this.lblmensaje.TabIndex = 383;
            this.lblmensaje.Text = "Total de Registros: 0";
            // 
            // btngenerar
            // 
            this.btngenerar.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btngenerar.Image = ((System.Drawing.Image)(resources.GetObject("btngenerar.Image")));
            this.btngenerar.Location = new System.Drawing.Point(1040, 100);
            this.btngenerar.Name = "btngenerar";
            this.btngenerar.Size = new System.Drawing.Size(85, 23);
            this.btngenerar.TabIndex = 382;
            this.btngenerar.Text = "Generar";
            this.btngenerar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btngenerar.UseVisualStyleBackColor = true;
            this.btngenerar.Click += new System.EventHandler(this.btngenerar_Click);
            // 
            // separadorOre1
            // 
            this.separadorOre1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.separadorOre1.Location = new System.Drawing.Point(1, 123);
            this.separadorOre1.MaximumSize = new System.Drawing.Size(2000, 2);
            this.separadorOre1.MinimumSize = new System.Drawing.Size(0, 2);
            this.separadorOre1.Name = "separadorOre1";
            this.separadorOre1.Size = new System.Drawing.Size(1284, 2);
            this.separadorOre1.TabIndex = 378;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(28, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 374;
            this.label4.Text = "Cuentas:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(13, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 376;
            this.label2.Text = "Periodo De:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 19);
            this.label1.TabIndex = 377;
            this.label1.Text = "MAYOR POR CUENTAS";
            // 
            // dtgconten
            // 
            this.dtgconten.AllowUserToAddRows = false;
            this.dtgconten.AllowUserToDeleteRows = false;
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
            this.xPeriodo,
            this.xRUC,
            this.xCod_Asiento_Contable,
            this.xEmpresa,
            this.xFechaContable,
            this.xFechaEmision,
            this.xId_Comprobante,
            this.xTipoComprobante,
            this.xCod_Comprobante,
            this.xNum_Comprobante,
            this.xNum_Doc,
            this.xRazon_Social,
            this.xGlosa,
            this.xCuenta_Contable,
            this.xDESCRIPCION,
            this.xCuentaBanco,
            this.xMoneda,
            this.xPEN,
            this.xUSD,
            this.xMes,
            this.xTipoCambio,
            this.xUsers});
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(207)))), ((int)(((byte)(241)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgconten.DefaultCellStyle = dataGridViewCellStyle8;
            this.dtgconten.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dtgconten.EnableHeadersVisualStyles = false;
            this.dtgconten.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(179)))), ((int)(((byte)(215)))));
            this.dtgconten.Location = new System.Drawing.Point(16, 128);
            this.dtgconten.Name = "dtgconten";
            this.dtgconten.ReadOnly = true;
            this.dtgconten.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dtgconten.RowHeadersVisible = false;
            this.dtgconten.RowTemplate.Height = 18;
            this.dtgconten.Size = new System.Drawing.Size(1198, 396);
            this.dtgconten.TabIndex = 373;
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // txtbuscuenta
            // 
            this.txtbuscuenta.BackColor = System.Drawing.Color.White;
            this.txtbuscuenta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtbuscuenta.ColorFondoMouseEncima = System.Drawing.Color.Empty;
            this.txtbuscuenta.ColorFondoMousePresionado = System.Drawing.Color.Empty;
            this.txtbuscuenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbuscuenta.ForeColor = System.Drawing.Color.Black;
            this.txtbuscuenta.Format = null;
            this.txtbuscuenta.Location = new System.Drawing.Point(83, 56);
            this.txtbuscuenta.MaxLength = 100;
            this.txtbuscuenta.Name = "txtbuscuenta";
            this.txtbuscuenta.NextControlOnEnter = null;
            this.txtbuscuenta.Size = new System.Drawing.Size(215, 21);
            this.txtbuscuenta.TabIndex = 387;
            this.txtbuscuenta.Text = "000";
            this.txtbuscuenta.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtbuscuenta.TextoDefecto = "000";
            this.txtbuscuenta.TextoDefectoColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(129)))), ((int)(((byte)(189)))));
            this.txtbuscuenta.TiposDatos = HpResergerUserControls.TextBoxPer.ListaTipos.MayusculaCadaPalabra;
            this.toolTip1.SetToolTip(this.txtbuscuenta, "(-) Rango de Cuentas\r\n(;) Cuentas Específicas");
            // 
            // chklist
            // 
            this.chklist.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.chklist.ColumnWidth = 200;
            this.chklist.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chklist.Location = new System.Drawing.Point(378, 33);
            this.chklist.Name = "chklist";
            this.chklist.Size = new System.Drawing.Size(405, 82);
            this.chklist.TabIndex = 388;
            this.chklist.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.chklist_ItemCheck);
            this.chklist.Enter += new System.EventHandler(this.chklist_Enter);
            this.chklist.Leave += new System.EventHandler(this.chklist_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(325, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 376;
            this.label3.Text = "Empresa:";
            // 
            // dtpfechaini
            // 
            this.dtpfechaini.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpfechaini.Location = new System.Drawing.Point(83, 33);
            this.dtpfechaini.Name = "dtpfechaini";
            this.dtpfechaini.Size = new System.Drawing.Size(93, 22);
            this.dtpfechaini.TabIndex = 389;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(182, 38);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(17, 13);
            this.label5.TabIndex = 376;
            this.label5.Text = "A:";
            // 
            // dtpfechafin
            // 
            this.dtpfechafin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpfechafin.Location = new System.Drawing.Point(205, 33);
            this.dtpfechafin.Name = "dtpfechafin";
            this.dtpfechafin.Size = new System.Drawing.Size(93, 22);
            this.dtpfechafin.TabIndex = 389;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(41, 82);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 13);
            this.label6.TabIndex = 374;
            this.label6.Text = "Glosa:";
            // 
            // txtbusGlosa
            // 
            this.txtbusGlosa.BackColor = System.Drawing.Color.White;
            this.txtbusGlosa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtbusGlosa.ColorFondoMouseEncima = System.Drawing.Color.Empty;
            this.txtbusGlosa.ColorFondoMousePresionado = System.Drawing.Color.Empty;
            this.txtbusGlosa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbusGlosa.ForeColor = System.Drawing.Color.Black;
            this.txtbusGlosa.Format = null;
            this.txtbusGlosa.Location = new System.Drawing.Point(83, 78);
            this.txtbusGlosa.MaxLength = 100;
            this.txtbusGlosa.Name = "txtbusGlosa";
            this.txtbusGlosa.NextControlOnEnter = null;
            this.txtbusGlosa.Size = new System.Drawing.Size(215, 21);
            this.txtbusGlosa.TabIndex = 387;
            this.txtbusGlosa.Text = "Buscar Glosa";
            this.txtbusGlosa.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtbusGlosa.TextoDefecto = "Buscar Glosa";
            this.txtbusGlosa.TextoDefectoColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(129)))), ((int)(((byte)(189)))));
            this.txtbusGlosa.TiposDatos = HpResergerUserControls.TextBoxPer.ListaTipos.MayusculaCadaPalabra;
            this.toolTip1.SetToolTip(this.txtbusGlosa, "(;) Glosas Separadas");
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Location = new System.Drawing.Point(15, 104);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 13);
            this.label7.TabIndex = 374;
            this.label7.Text = "Nro Dcmto:";
            // 
            // txtbusnrodoc
            // 
            this.txtbusnrodoc.BackColor = System.Drawing.Color.White;
            this.txtbusnrodoc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtbusnrodoc.ColorFondoMouseEncima = System.Drawing.Color.Empty;
            this.txtbusnrodoc.ColorFondoMousePresionado = System.Drawing.Color.Empty;
            this.txtbusnrodoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbusnrodoc.ForeColor = System.Drawing.Color.Black;
            this.txtbusnrodoc.Format = null;
            this.txtbusnrodoc.Location = new System.Drawing.Point(83, 100);
            this.txtbusnrodoc.MaxLength = 100;
            this.txtbusnrodoc.Name = "txtbusnrodoc";
            this.txtbusnrodoc.NextControlOnEnter = null;
            this.txtbusnrodoc.Size = new System.Drawing.Size(215, 21);
            this.txtbusnrodoc.TabIndex = 387;
            this.txtbusnrodoc.Text = "Buscar Número Documento";
            this.txtbusnrodoc.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtbusnrodoc.TextoDefecto = "Buscar Número Documento";
            this.txtbusnrodoc.TextoDefectoColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(129)))), ((int)(((byte)(189)))));
            this.txtbusnrodoc.TiposDatos = HpResergerUserControls.TextBoxPer.ListaTipos.MayusculaCadaPalabra;
            this.toolTip1.SetToolTip(this.txtbusnrodoc, "(;) Documentos Separados");
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Location = new System.Drawing.Point(835, 60);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 13);
            this.label8.TabIndex = 374;
            this.label8.Text = "Ruc:";
            // 
            // txtbusruc
            // 
            this.txtbusruc.BackColor = System.Drawing.Color.White;
            this.txtbusruc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtbusruc.ColorFondoMouseEncima = System.Drawing.Color.Empty;
            this.txtbusruc.ColorFondoMousePresionado = System.Drawing.Color.Empty;
            this.txtbusruc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbusruc.ForeColor = System.Drawing.Color.Black;
            this.txtbusruc.Format = null;
            this.txtbusruc.Location = new System.Drawing.Point(864, 56);
            this.txtbusruc.MaxLength = 100;
            this.txtbusruc.Name = "txtbusruc";
            this.txtbusruc.NextControlOnEnter = null;
            this.txtbusruc.Size = new System.Drawing.Size(260, 21);
            this.txtbusruc.TabIndex = 387;
            this.txtbusruc.Text = "Buscar RUC";
            this.txtbusruc.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtbusruc.TextoDefecto = "Buscar RUC";
            this.txtbusruc.TextoDefectoColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(129)))), ((int)(((byte)(189)))));
            this.txtbusruc.TiposDatos = HpResergerUserControls.TextBoxPer.ListaTipos.MayusculaCadaPalabra;
            this.toolTip1.SetToolTip(this.txtbusruc, "(;) Ruc Separados");
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Location = new System.Drawing.Point(789, 82);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(75, 13);
            this.label9.TabIndex = 374;
            this.label9.Text = "Razon Social:";
            // 
            // txtbusrazon
            // 
            this.txtbusrazon.BackColor = System.Drawing.Color.White;
            this.txtbusrazon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtbusrazon.ColorFondoMouseEncima = System.Drawing.Color.Empty;
            this.txtbusrazon.ColorFondoMousePresionado = System.Drawing.Color.Empty;
            this.txtbusrazon.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbusrazon.ForeColor = System.Drawing.Color.Black;
            this.txtbusrazon.Format = null;
            this.txtbusrazon.Location = new System.Drawing.Point(864, 78);
            this.txtbusrazon.MaxLength = 100;
            this.txtbusrazon.Name = "txtbusrazon";
            this.txtbusrazon.NextControlOnEnter = null;
            this.txtbusrazon.Size = new System.Drawing.Size(260, 21);
            this.txtbusrazon.TabIndex = 387;
            this.txtbusrazon.Text = "Buscar Razon Social";
            this.txtbusrazon.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtbusrazon.TextoDefecto = "Buscar Razon Social";
            this.txtbusrazon.TextoDefectoColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(129)))), ((int)(((byte)(189)))));
            this.txtbusrazon.TiposDatos = HpResergerUserControls.TextBoxPer.ListaTipos.MayusculaCadaPalabra;
            this.toolTip1.SetToolTip(this.txtbusrazon, "(;) Razon o Nombres Separados");
            // 
            // btnbusCuenta
            // 
            this.btnbusCuenta.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnbusCuenta.BackgroundImage")));
            this.btnbusCuenta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnbusCuenta.Location = new System.Drawing.Point(298, 56);
            this.btnbusCuenta.Name = "btnbusCuenta";
            this.btnbusCuenta.Size = new System.Drawing.Size(21, 21);
            this.btnbusCuenta.TabIndex = 390;
            this.btnbusCuenta.UseVisualStyleBackColor = true;
            this.btnbusCuenta.Click += new System.EventHandler(this.btnbusCuenta_Click);
            // 
            // xPeriodo
            // 
            this.xPeriodo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.xPeriodo.DataPropertyName = "Periodo";
            this.xPeriodo.HeaderText = "Periodo";
            this.xPeriodo.Name = "xPeriodo";
            this.xPeriodo.ReadOnly = true;
            this.xPeriodo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.xPeriodo.Width = 71;
            // 
            // xRUC
            // 
            this.xRUC.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.xRUC.DataPropertyName = "RUC";
            this.xRUC.HeaderText = "RUC";
            this.xRUC.Name = "xRUC";
            this.xRUC.ReadOnly = true;
            this.xRUC.Width = 53;
            // 
            // xCod_Asiento_Contable
            // 
            this.xCod_Asiento_Contable.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.xCod_Asiento_Contable.DataPropertyName = "Cod_Asiento_Contable";
            this.xCod_Asiento_Contable.HeaderText = "CUO";
            this.xCod_Asiento_Contable.Name = "xCod_Asiento_Contable";
            this.xCod_Asiento_Contable.ReadOnly = true;
            this.xCod_Asiento_Contable.Width = 55;
            // 
            // xEmpresa
            // 
            this.xEmpresa.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.xEmpresa.DataPropertyName = "Empresa";
            this.xEmpresa.HeaderText = "Empresa";
            this.xEmpresa.MinimumWidth = 120;
            this.xEmpresa.Name = "xEmpresa";
            this.xEmpresa.ReadOnly = true;
            this.xEmpresa.Width = 120;
            // 
            // xFechaContable
            // 
            this.xFechaContable.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.xFechaContable.DataPropertyName = "FechaContable";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.Format = "d";
            this.xFechaContable.DefaultCellStyle = dataGridViewCellStyle3;
            this.xFechaContable.HeaderText = "Fec. Ctable";
            this.xFechaContable.Name = "xFechaContable";
            this.xFechaContable.ReadOnly = true;
            this.xFechaContable.Width = 87;
            // 
            // xFechaEmision
            // 
            this.xFechaEmision.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.xFechaEmision.DataPropertyName = "FechaEmision";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle4.Format = "d";
            this.xFechaEmision.DefaultCellStyle = dataGridViewCellStyle4;
            this.xFechaEmision.HeaderText = "F. Emision";
            this.xFechaEmision.Name = "xFechaEmision";
            this.xFechaEmision.ReadOnly = true;
            this.xFechaEmision.Width = 83;
            // 
            // xId_Comprobante
            // 
            this.xId_Comprobante.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.xId_Comprobante.DataPropertyName = "Id_Comprobante";
            this.xId_Comprobante.HeaderText = "Cod.Sunat";
            this.xId_Comprobante.Name = "xId_Comprobante";
            this.xId_Comprobante.ReadOnly = true;
            this.xId_Comprobante.Width = 85;
            // 
            // xTipoComprobante
            // 
            this.xTipoComprobante.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.xTipoComprobante.DataPropertyName = "TipoComprobante";
            this.xTipoComprobante.HeaderText = "T.Cmprobante";
            this.xTipoComprobante.MinimumWidth = 150;
            this.xTipoComprobante.Name = "xTipoComprobante";
            this.xTipoComprobante.ReadOnly = true;
            this.xTipoComprobante.Width = 150;
            // 
            // xCod_Comprobante
            // 
            this.xCod_Comprobante.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.xCod_Comprobante.DataPropertyName = "Cod_Comprobante";
            this.xCod_Comprobante.HeaderText = "SerieDoc.";
            this.xCod_Comprobante.Name = "xCod_Comprobante";
            this.xCod_Comprobante.ReadOnly = true;
            this.xCod_Comprobante.Width = 79;
            // 
            // xNum_Comprobante
            // 
            this.xNum_Comprobante.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.xNum_Comprobante.DataPropertyName = "Num_Comprobante";
            this.xNum_Comprobante.HeaderText = "Num.Doc.";
            this.xNum_Comprobante.Name = "xNum_Comprobante";
            this.xNum_Comprobante.ReadOnly = true;
            this.xNum_Comprobante.Width = 81;
            // 
            // xNum_Doc
            // 
            this.xNum_Doc.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.xNum_Doc.DataPropertyName = "Num_Doc";
            this.xNum_Doc.HeaderText = "Ruc-NroId";
            this.xNum_Doc.Name = "xNum_Doc";
            this.xNum_Doc.ReadOnly = true;
            this.xNum_Doc.Width = 83;
            // 
            // xRazon_Social
            // 
            this.xRazon_Social.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.xRazon_Social.DataPropertyName = "Razon_Social";
            this.xRazon_Social.HeaderText = "Nombres-Razon";
            this.xRazon_Social.MinimumWidth = 180;
            this.xRazon_Social.Name = "xRazon_Social";
            this.xRazon_Social.ReadOnly = true;
            // 
            // xGlosa
            // 
            this.xGlosa.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.xGlosa.DataPropertyName = "Glosa";
            this.xGlosa.HeaderText = "Glosa";
            this.xGlosa.MinimumWidth = 100;
            this.xGlosa.Name = "xGlosa";
            this.xGlosa.ReadOnly = true;
            // 
            // xCuenta_Contable
            // 
            this.xCuenta_Contable.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.xCuenta_Contable.DataPropertyName = "Cuenta_Contable";
            this.xCuenta_Contable.HeaderText = "Cuenta";
            this.xCuenta_Contable.Name = "xCuenta_Contable";
            this.xCuenta_Contable.ReadOnly = true;
            this.xCuenta_Contable.Width = 68;
            // 
            // xDESCRIPCION
            // 
            this.xDESCRIPCION.DataPropertyName = "DESCRIPCION";
            this.xDESCRIPCION.HeaderText = "Descripción";
            this.xDESCRIPCION.MinimumWidth = 180;
            this.xDESCRIPCION.Name = "xDESCRIPCION";
            this.xDESCRIPCION.ReadOnly = true;
            // 
            // xCuentaBanco
            // 
            this.xCuentaBanco.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.xCuentaBanco.DataPropertyName = "CuentaBanco";
            this.xCuentaBanco.HeaderText = "CuentaBanco";
            this.xCuentaBanco.Name = "xCuentaBanco";
            this.xCuentaBanco.ReadOnly = true;
            // 
            // xMoneda
            // 
            this.xMoneda.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.xMoneda.DataPropertyName = "Moneda";
            this.xMoneda.HeaderText = "Moneda";
            this.xMoneda.Name = "xMoneda";
            this.xMoneda.ReadOnly = true;
            this.xMoneda.Width = 74;
            // 
            // xPEN
            // 
            this.xPEN.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.xPEN.DataPropertyName = "PEN";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle5.Format = "n2";
            this.xPEN.DefaultCellStyle = dataGridViewCellStyle5;
            this.xPEN.HeaderText = "PEN";
            this.xPEN.Name = "xPEN";
            this.xPEN.ReadOnly = true;
            this.xPEN.Width = 51;
            // 
            // xUSD
            // 
            this.xUSD.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.xUSD.DataPropertyName = "USD";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle6.Format = "n2";
            this.xUSD.DefaultCellStyle = dataGridViewCellStyle6;
            this.xUSD.HeaderText = "USD";
            this.xUSD.Name = "xUSD";
            this.xUSD.ReadOnly = true;
            this.xUSD.Width = 53;
            // 
            // xMes
            // 
            this.xMes.DataPropertyName = "Mes";
            this.xMes.HeaderText = "Mes";
            this.xMes.Name = "xMes";
            this.xMes.ReadOnly = true;
            this.xMes.Visible = false;
            // 
            // xTipoCambio
            // 
            this.xTipoCambio.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.xTipoCambio.DataPropertyName = "TipoCambio";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle7.Format = "n3";
            this.xTipoCambio.DefaultCellStyle = dataGridViewCellStyle7;
            this.xTipoCambio.HeaderText = "T.C.";
            this.xTipoCambio.Name = "xTipoCambio";
            this.xTipoCambio.ReadOnly = true;
            this.xTipoCambio.Width = 49;
            // 
            // xUsers
            // 
            this.xUsers.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.xUsers.DataPropertyName = "Users";
            this.xUsers.HeaderText = "Usuario";
            this.xUsers.Name = "xUsers";
            this.xUsers.ReadOnly = true;
            this.xUsers.Width = 71;
            // 
            // frmRegMayorxCuentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1225, 561);
            this.Controls.Add(this.btnbusCuenta);
            this.Controls.Add(this.dtpfechafin);
            this.Controls.Add(this.dtpfechaini);
            this.Controls.Add(this.chklist);
            this.Controls.Add(this.txtbusnrodoc);
            this.Controls.Add(this.txtbusGlosa);
            this.Controls.Add(this.txtbusrazon);
            this.Controls.Add(this.txtbusruc);
            this.Controls.Add(this.txtbuscuenta);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnexcel);
            this.Controls.Add(this.btncancelar);
            this.Controls.Add(this.lblmensaje);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btngenerar);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.separadorOre1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtgconten);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinimumSize = new System.Drawing.Size(1241, 600);
            this.Name = "frmRegMayorxCuentas";
            this.Nombre = "Mayor por Cuentas";
            this.Text = "Mayor por Cuentas";
            this.Load += new System.EventHandler(this.frmRegMayorxCuentas_Load);
            this.Click += new System.EventHandler(this.frmRegMayorxCuentas_Click);
            ((System.ComponentModel.ISupportInitialize)(this.dtgconten)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnexcel;
        private System.Windows.Forms.Button btncancelar;
        private System.Windows.Forms.Label lblmensaje;
        private System.Windows.Forms.Button btngenerar;
        private HpResergerUserControls.SeparadorOre separadorOre1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private HpResergerUserControls.Dtgconten dtgconten;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private HpResergerUserControls.TextBoxPer txtbuscuenta;
        private System.Windows.Forms.CheckedListBox chklist;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpfechaini;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtpfechafin;
        private System.Windows.Forms.Label label6;
        private HpResergerUserControls.TextBoxPer txtbusGlosa;
        private System.Windows.Forms.Label label7;
        private HpResergerUserControls.TextBoxPer txtbusnrodoc;
        private System.Windows.Forms.Label label8;
        private HpResergerUserControls.TextBoxPer txtbusruc;
        private System.Windows.Forms.Label label9;
        private HpResergerUserControls.TextBoxPer txtbusrazon;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button btnbusCuenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn xPeriodo;
        private System.Windows.Forms.DataGridViewTextBoxColumn xRUC;
        private System.Windows.Forms.DataGridViewTextBoxColumn xCod_Asiento_Contable;
        private System.Windows.Forms.DataGridViewTextBoxColumn xEmpresa;
        private System.Windows.Forms.DataGridViewTextBoxColumn xFechaContable;
        private System.Windows.Forms.DataGridViewTextBoxColumn xFechaEmision;
        private System.Windows.Forms.DataGridViewTextBoxColumn xId_Comprobante;
        private System.Windows.Forms.DataGridViewTextBoxColumn xTipoComprobante;
        private System.Windows.Forms.DataGridViewTextBoxColumn xCod_Comprobante;
        private System.Windows.Forms.DataGridViewTextBoxColumn xNum_Comprobante;
        private System.Windows.Forms.DataGridViewTextBoxColumn xNum_Doc;
        private System.Windows.Forms.DataGridViewTextBoxColumn xRazon_Social;
        private System.Windows.Forms.DataGridViewTextBoxColumn xGlosa;
        private System.Windows.Forms.DataGridViewTextBoxColumn xCuenta_Contable;
        private System.Windows.Forms.DataGridViewTextBoxColumn xDESCRIPCION;
        private System.Windows.Forms.DataGridViewTextBoxColumn xCuentaBanco;
        private System.Windows.Forms.DataGridViewTextBoxColumn xMoneda;
        private System.Windows.Forms.DataGridViewTextBoxColumn xPEN;
        private System.Windows.Forms.DataGridViewTextBoxColumn xUSD;
        private System.Windows.Forms.DataGridViewTextBoxColumn xMes;
        private System.Windows.Forms.DataGridViewTextBoxColumn xTipoCambio;
        private System.Windows.Forms.DataGridViewTextBoxColumn xUsers;
    }
}