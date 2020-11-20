namespace HPReserger.ModuloReportes
{
    partial class frmBalanceComprobacion
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBalanceComprobacion));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            this.comboMesAño = new HpResergerUserControls.ComboMesAño();
            this.cboEmpresas = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtgconten = new HpResergerUserControls.Dtgconten();
            this.lblmsg = new System.Windows.Forms.Label();
            this.BtnCerrar = new HpResergerUserControls.ButtonPer();
            this.btnProcesar = new HpResergerUserControls.ButtonPer();
            this.rb2digitos = new System.Windows.Forms.RadioButton();
            this.rb7digitos = new System.Windows.Forms.RadioButton();
            this.btnExportarExcel = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.chkCarpeta = new System.Windows.Forms.CheckBox();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.xCuenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xDescripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xSaldoInicialDebe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xSaldoInicialHaber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xSumaDebe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xSumaHaber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xSaldoDeudor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xSaldoAcreedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xInventarioActivo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xInventarioPasivo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xNaturalezaPerdida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xNaturalezaGanancia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xFuncionPerdida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xfuncionGanancia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtgconten)).BeginInit();
            this.SuspendLayout();
            // 
            // comboMesAño
            // 
            this.comboMesAño.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.comboMesAño.AutoSize = true;
            this.comboMesAño.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.comboMesAño.BackColor = System.Drawing.Color.Transparent;
            this.comboMesAño.FechaConDiaActual = new System.DateTime(2020, 11, 30, 0, 0, 0, 0);
            this.comboMesAño.FechaFinMes = new System.DateTime(2020, 11, 30, 0, 0, 0, 0);
            this.comboMesAño.FechaInicioMes = new System.DateTime(2020, 11, 1, 0, 0, 0, 0);
            this.comboMesAño.Location = new System.Drawing.Point(444, 47);
            this.comboMesAño.Name = "comboMesAño";
            this.comboMesAño.Size = new System.Drawing.Size(206, 27);
            this.comboMesAño.TabIndex = 1;
            this.comboMesAño.VerAño = true;
            this.comboMesAño.VerMes = true;
            // 
            // cboEmpresas
            // 
            this.cboEmpresas.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cboEmpresas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEmpresas.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboEmpresas.FormattingEnabled = true;
            this.cboEmpresas.Location = new System.Drawing.Point(398, 12);
            this.cboEmpresas.Name = "cboEmpresas";
            this.cboEmpresas.Size = new System.Drawing.Size(299, 21);
            this.cboEmpresas.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(364, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(364, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "BALANCE DE COMPROBACIÓN POR MAYOR CONSOLIDADO(MENSUAL)";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(464, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(173, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "(EXPRESADO EN NUEVOS SOLES)";
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
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DeepSkyBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgconten.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dtgconten.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgconten.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.xCuenta,
            this.xDescripcion,
            this.xSaldoInicialDebe,
            this.xSaldoInicialHaber,
            this.xSumaDebe,
            this.xSumaHaber,
            this.xSaldoDeudor,
            this.xSaldoAcreedor,
            this.xInventarioActivo,
            this.xInventarioPasivo,
            this.xNaturalezaPerdida,
            this.xNaturalezaGanancia,
            this.xFuncionPerdida,
            this.xfuncionGanancia});
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(207)))), ((int)(((byte)(241)))));
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgconten.DefaultCellStyle = dataGridViewCellStyle15;
            this.dtgconten.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dtgconten.EnableHeadersVisualStyles = false;
            this.dtgconten.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(179)))), ((int)(((byte)(215)))));
            this.dtgconten.Location = new System.Drawing.Point(12, 113);
            this.dtgconten.Name = "dtgconten";
            this.dtgconten.ReadOnly = true;
            this.dtgconten.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dtgconten.RowHeadersVisible = false;
            this.dtgconten.RowTemplate.Height = 18;
            this.dtgconten.Size = new System.Drawing.Size(1071, 438);
            this.dtgconten.TabIndex = 5;
            // 
            // lblmsg
            // 
            this.lblmsg.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblmsg.AutoSize = true;
            this.lblmsg.BackColor = System.Drawing.Color.Transparent;
            this.lblmsg.Location = new System.Drawing.Point(9, 562);
            this.lblmsg.Name = "lblmsg";
            this.lblmsg.Size = new System.Drawing.Size(91, 13);
            this.lblmsg.TabIndex = 10;
            this.lblmsg.Text = "Total Registos: 0";
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
            this.BtnCerrar.Location = new System.Drawing.Point(1000, 557);
            this.BtnCerrar.Name = "BtnCerrar";
            this.BtnCerrar.Size = new System.Drawing.Size(83, 24);
            this.BtnCerrar.TabIndex = 7;
            this.BtnCerrar.Text = "&Cancelar";
            this.BtnCerrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnCerrar.UseVisualStyleBackColor = false;
            this.BtnCerrar.Click += new System.EventHandler(this.BtnCerrar_Click);
            // 
            // btnProcesar
            // 
            this.btnProcesar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnProcesar.BackColor = System.Drawing.Color.SeaGreen;
            this.btnProcesar.FlatAppearance.BorderColor = System.Drawing.Color.Olive;
            this.btnProcesar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProcesar.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProcesar.ForeColor = System.Drawing.Color.White;
            this.btnProcesar.Location = new System.Drawing.Point(1000, 86);
            this.btnProcesar.Name = "btnProcesar";
            this.btnProcesar.Size = new System.Drawing.Size(83, 24);
            this.btnProcesar.TabIndex = 4;
            this.btnProcesar.Text = "&Procesar";
            this.btnProcesar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnProcesar.UseVisualStyleBackColor = false;
            this.btnProcesar.Click += new System.EventHandler(this.btnTxt_Click);
            // 
            // rb2digitos
            // 
            this.rb2digitos.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.rb2digitos.AutoSize = true;
            this.rb2digitos.BackColor = System.Drawing.Color.Transparent;
            this.rb2digitos.Checked = true;
            this.rb2digitos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(129)))), ((int)(((byte)(189)))));
            this.rb2digitos.Location = new System.Drawing.Point(476, 90);
            this.rb2digitos.Name = "rb2digitos";
            this.rb2digitos.Size = new System.Drawing.Size(68, 17);
            this.rb2digitos.TabIndex = 2;
            this.rb2digitos.TabStop = true;
            this.rb2digitos.Text = "2Dígitos";
            this.rb2digitos.UseVisualStyleBackColor = false;
            // 
            // rb7digitos
            // 
            this.rb7digitos.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.rb7digitos.AutoSize = true;
            this.rb7digitos.BackColor = System.Drawing.Color.Transparent;
            this.rb7digitos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(129)))), ((int)(((byte)(189)))));
            this.rb7digitos.Location = new System.Drawing.Point(550, 90);
            this.rb7digitos.Name = "rb7digitos";
            this.rb7digitos.Size = new System.Drawing.Size(68, 17);
            this.rb7digitos.TabIndex = 3;
            this.rb7digitos.Text = "7Dígitos";
            this.rb7digitos.UseVisualStyleBackColor = false;
            // 
            // btnExportarExcel
            // 
            this.btnExportarExcel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnExportarExcel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExportarExcel.Image = ((System.Drawing.Image)(resources.GetObject("btnExportarExcel.Image")));
            this.btnExportarExcel.Location = new System.Drawing.Point(506, 557);
            this.btnExportarExcel.Name = "btnExportarExcel";
            this.btnExportarExcel.Size = new System.Drawing.Size(82, 23);
            this.btnExportarExcel.TabIndex = 6;
            this.btnExportarExcel.Text = "&Excel";
            this.btnExportarExcel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnExportarExcel.UseVisualStyleBackColor = true;
            this.btnExportarExcel.Click += new System.EventHandler(this.btnExportarExcel_Click);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // chkCarpeta
            // 
            this.chkCarpeta.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.chkCarpeta.AutoSize = true;
            this.chkCarpeta.BackColor = System.Drawing.Color.Transparent;
            this.chkCarpeta.Location = new System.Drawing.Point(593, 560);
            this.chkCarpeta.Name = "chkCarpeta";
            this.chkCarpeta.Size = new System.Drawing.Size(103, 17);
            this.chkCarpeta.TabIndex = 395;
            this.chkCarpeta.Text = "Excel a Carpeta";
            this.chkCarpeta.UseVisualStyleBackColor = false;
            // 
            // xCuenta
            // 
            this.xCuenta.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.xCuenta.DataPropertyName = "Cuenta";
            this.xCuenta.HeaderText = "Cuenta";
            this.xCuenta.MinimumWidth = 50;
            this.xCuenta.Name = "xCuenta";
            this.xCuenta.ReadOnly = true;
            this.xCuenta.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.xCuenta.Width = 50;
            // 
            // xDescripcion
            // 
            this.xDescripcion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.xDescripcion.DataPropertyName = "descripcion";
            this.xDescripcion.HeaderText = "Descripción";
            this.xDescripcion.MinimumWidth = 100;
            this.xDescripcion.Name = "xDescripcion";
            this.xDescripcion.ReadOnly = true;
            this.xDescripcion.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // xSaldoInicialDebe
            // 
            this.xSaldoInicialDebe.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.xSaldoInicialDebe.DataPropertyName = "SaldoInicialDebe";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.Format = "n2";
            this.xSaldoInicialDebe.DefaultCellStyle = dataGridViewCellStyle3;
            this.xSaldoInicialDebe.HeaderText = "Saldo Inicial Debe";
            this.xSaldoInicialDebe.MinimumWidth = 55;
            this.xSaldoInicialDebe.Name = "xSaldoInicialDebe";
            this.xSaldoInicialDebe.ReadOnly = true;
            this.xSaldoInicialDebe.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.xSaldoInicialDebe.Width = 55;
            // 
            // xSaldoInicialHaber
            // 
            this.xSaldoInicialHaber.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.xSaldoInicialHaber.DataPropertyName = "SaldoInicialHaber";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle4.Format = "n2";
            this.xSaldoInicialHaber.DefaultCellStyle = dataGridViewCellStyle4;
            this.xSaldoInicialHaber.HeaderText = "Saldo Inicial Haber";
            this.xSaldoInicialHaber.MinimumWidth = 55;
            this.xSaldoInicialHaber.Name = "xSaldoInicialHaber";
            this.xSaldoInicialHaber.ReadOnly = true;
            this.xSaldoInicialHaber.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.xSaldoInicialHaber.Width = 55;
            // 
            // xSumaDebe
            // 
            this.xSumaDebe.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.xSumaDebe.DataPropertyName = "sumadebe";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle5.Format = "n2";
            this.xSumaDebe.DefaultCellStyle = dataGridViewCellStyle5;
            this.xSumaDebe.HeaderText = "Suma Debe";
            this.xSumaDebe.MinimumWidth = 70;
            this.xSumaDebe.Name = "xSumaDebe";
            this.xSumaDebe.ReadOnly = true;
            this.xSumaDebe.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.xSumaDebe.Width = 70;
            // 
            // xSumaHaber
            // 
            this.xSumaHaber.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.xSumaHaber.DataPropertyName = "sumahaber";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle6.Format = "n2";
            this.xSumaHaber.DefaultCellStyle = dataGridViewCellStyle6;
            this.xSumaHaber.HeaderText = "Suma Haber";
            this.xSumaHaber.MinimumWidth = 70;
            this.xSumaHaber.Name = "xSumaHaber";
            this.xSumaHaber.ReadOnly = true;
            this.xSumaHaber.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.xSumaHaber.Width = 70;
            // 
            // xSaldoDeudor
            // 
            this.xSaldoDeudor.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.xSaldoDeudor.DataPropertyName = "saldodeudor";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle7.Format = "n2";
            this.xSaldoDeudor.DefaultCellStyle = dataGridViewCellStyle7;
            this.xSaldoDeudor.HeaderText = "Saldo Deudor";
            this.xSaldoDeudor.MinimumWidth = 70;
            this.xSaldoDeudor.Name = "xSaldoDeudor";
            this.xSaldoDeudor.ReadOnly = true;
            this.xSaldoDeudor.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.xSaldoDeudor.Width = 70;
            // 
            // xSaldoAcreedor
            // 
            this.xSaldoAcreedor.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.xSaldoAcreedor.DataPropertyName = "saldoacreedor";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle8.Format = "n2";
            this.xSaldoAcreedor.DefaultCellStyle = dataGridViewCellStyle8;
            this.xSaldoAcreedor.HeaderText = "Saldo Acreedor";
            this.xSaldoAcreedor.MinimumWidth = 70;
            this.xSaldoAcreedor.Name = "xSaldoAcreedor";
            this.xSaldoAcreedor.ReadOnly = true;
            this.xSaldoAcreedor.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.xSaldoAcreedor.Width = 70;
            // 
            // xInventarioActivo
            // 
            this.xInventarioActivo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.xInventarioActivo.DataPropertyName = "inventarioactivo";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle9.Format = "n2";
            this.xInventarioActivo.DefaultCellStyle = dataGridViewCellStyle9;
            this.xInventarioActivo.HeaderText = "Inventario Activo";
            this.xInventarioActivo.MinimumWidth = 70;
            this.xInventarioActivo.Name = "xInventarioActivo";
            this.xInventarioActivo.ReadOnly = true;
            this.xInventarioActivo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.xInventarioActivo.Width = 70;
            // 
            // xInventarioPasivo
            // 
            this.xInventarioPasivo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.xInventarioPasivo.DataPropertyName = "inventariopasivo";
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle10.Format = "n2";
            this.xInventarioPasivo.DefaultCellStyle = dataGridViewCellStyle10;
            this.xInventarioPasivo.HeaderText = "Inventario Pasivo";
            this.xInventarioPasivo.MinimumWidth = 70;
            this.xInventarioPasivo.Name = "xInventarioPasivo";
            this.xInventarioPasivo.ReadOnly = true;
            this.xInventarioPasivo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.xInventarioPasivo.Width = 70;
            // 
            // xNaturalezaPerdida
            // 
            this.xNaturalezaPerdida.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.xNaturalezaPerdida.DataPropertyName = "PorNaturalezaPérdida";
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle11.Format = "n2";
            this.xNaturalezaPerdida.DefaultCellStyle = dataGridViewCellStyle11;
            this.xNaturalezaPerdida.HeaderText = "Naturaleza Pérdida";
            this.xNaturalezaPerdida.MinimumWidth = 75;
            this.xNaturalezaPerdida.Name = "xNaturalezaPerdida";
            this.xNaturalezaPerdida.ReadOnly = true;
            this.xNaturalezaPerdida.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.xNaturalezaPerdida.Width = 75;
            // 
            // xNaturalezaGanancia
            // 
            this.xNaturalezaGanancia.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.xNaturalezaGanancia.DataPropertyName = "PorNaturalezaGanancia";
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle12.Format = "n2";
            this.xNaturalezaGanancia.DefaultCellStyle = dataGridViewCellStyle12;
            this.xNaturalezaGanancia.HeaderText = "Naturaleza Ganancia";
            this.xNaturalezaGanancia.MinimumWidth = 75;
            this.xNaturalezaGanancia.Name = "xNaturalezaGanancia";
            this.xNaturalezaGanancia.ReadOnly = true;
            this.xNaturalezaGanancia.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.xNaturalezaGanancia.Width = 75;
            // 
            // xFuncionPerdida
            // 
            this.xFuncionPerdida.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.xFuncionPerdida.DataPropertyName = "PorFunciónPérdida";
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle13.Format = "n2";
            this.xFuncionPerdida.DefaultCellStyle = dataGridViewCellStyle13;
            this.xFuncionPerdida.HeaderText = "Función Pérdida";
            this.xFuncionPerdida.MinimumWidth = 70;
            this.xFuncionPerdida.Name = "xFuncionPerdida";
            this.xFuncionPerdida.ReadOnly = true;
            this.xFuncionPerdida.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.xFuncionPerdida.Width = 70;
            // 
            // xfuncionGanancia
            // 
            this.xfuncionGanancia.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.xfuncionGanancia.DataPropertyName = "PorFunciónGanancia";
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle14.Format = "n2";
            this.xfuncionGanancia.DefaultCellStyle = dataGridViewCellStyle14;
            this.xfuncionGanancia.HeaderText = "Función Ganancia";
            this.xfuncionGanancia.MinimumWidth = 70;
            this.xfuncionGanancia.Name = "xfuncionGanancia";
            this.xfuncionGanancia.ReadOnly = true;
            this.xfuncionGanancia.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.xfuncionGanancia.Width = 70;
            // 
            // frmBalanceComprobacion
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1095, 587);
            this.Controls.Add(this.chkCarpeta);
            this.Controls.Add(this.btnExportarExcel);
            this.Controls.Add(this.rb7digitos);
            this.Controls.Add(this.rb2digitos);
            this.Controls.Add(this.BtnCerrar);
            this.Controls.Add(this.btnProcesar);
            this.Controls.Add(this.dtgconten);
            this.Controls.Add(this.lblmsg);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboMesAño);
            this.Controls.Add(this.cboEmpresas);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinimumSize = new System.Drawing.Size(1111, 626);
            this.Name = "frmBalanceComprobacion";
            this.Nombre = "Balance de Comprobación";
            this.Text = "Balance de Comprobación";
            this.Load += new System.EventHandler(this.frmBalanceComprobacion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgconten)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private HpResergerUserControls.ComboMesAño comboMesAño;
        private System.Windows.Forms.ComboBox cboEmpresas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private HpResergerUserControls.Dtgconten dtgconten;
        private System.Windows.Forms.Label lblmsg;
        private HpResergerUserControls.ButtonPer BtnCerrar;
        private HpResergerUserControls.ButtonPer btnProcesar;
        private System.Windows.Forms.RadioButton rb2digitos;
        private System.Windows.Forms.RadioButton rb7digitos;
        private System.Windows.Forms.Button btnExportarExcel;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.CheckBox chkCarpeta;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.DataGridViewTextBoxColumn xCuenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn xDescripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn xSaldoInicialDebe;
        private System.Windows.Forms.DataGridViewTextBoxColumn xSaldoInicialHaber;
        private System.Windows.Forms.DataGridViewTextBoxColumn xSumaDebe;
        private System.Windows.Forms.DataGridViewTextBoxColumn xSumaHaber;
        private System.Windows.Forms.DataGridViewTextBoxColumn xSaldoDeudor;
        private System.Windows.Forms.DataGridViewTextBoxColumn xSaldoAcreedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn xInventarioActivo;
        private System.Windows.Forms.DataGridViewTextBoxColumn xInventarioPasivo;
        private System.Windows.Forms.DataGridViewTextBoxColumn xNaturalezaPerdida;
        private System.Windows.Forms.DataGridViewTextBoxColumn xNaturalezaGanancia;
        private System.Windows.Forms.DataGridViewTextBoxColumn xFuncionPerdida;
        private System.Windows.Forms.DataGridViewTextBoxColumn xfuncionGanancia;
    }
}