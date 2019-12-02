namespace HPReserger.ModuloReportes.LibrosElectronicos
{
    partial class frmLibroBancosCorriente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLibroBancosCorriente));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.fondoColorOre1 = new HpResergerUserControls.FondoColorOre(this.components);
            this.BtnCerrar = new HpResergerUserControls.ButtonPer();
            this.btnProcesar = new HpResergerUserControls.ButtonPer();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.SaveFile = new System.Windows.Forms.SaveFileDialog();
            this.button1 = new System.Windows.Forms.Button();
            this.btnGenerarTXT = new System.Windows.Forms.Button();
            this.btnexcel = new System.Windows.Forms.Button();
            this.lblmensaje = new System.Windows.Forms.Label();
            this.cboempresa = new System.Windows.Forms.ComboBox();
            this.txtruc = new HpResergerUserControls.TextBoxPer();
            this.comboMesAño1 = new HpResergerUserControls.ComboMesAño();
            this.separadorOre1 = new HpResergerUserControls.SeparadorOre();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtgconten = new HpResergerUserControls.Dtgconten();
            this.label4 = new System.Windows.Forms.Label();
            this.xperiodo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xcuo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xCorrelativo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xCodigoEntidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xNroCuenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xFechaOperacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xTipoPago = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xGlosa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xTipoDoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xNumDoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xBeneficiario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xNroOpBanco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xParteDeudora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xParteAcreedora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xEstado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtgconten)).BeginInit();
            this.SuspendLayout();
            // 
            // fondoColorOre1
            // 
            this.fondoColorOre1.Angulo = 135;
            this.fondoColorOre1.Colores = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(253)))), ((int)(((byte)(253))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(229)))), ((int)(((byte)(237))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))))};
            this.fondoColorOre1.control = null;
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
            this.BtnCerrar.Location = new System.Drawing.Point(989, 530);
            this.BtnCerrar.Name = "BtnCerrar";
            this.BtnCerrar.Size = new System.Drawing.Size(83, 24);
            this.BtnCerrar.TabIndex = 374;
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
            this.btnProcesar.Location = new System.Drawing.Point(989, 50);
            this.btnProcesar.Name = "btnProcesar";
            this.btnProcesar.Size = new System.Drawing.Size(83, 24);
            this.btnProcesar.TabIndex = 373;
            this.btnProcesar.Text = "&Procesar";
            this.btnProcesar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnProcesar.UseVisualStyleBackColor = false;
            this.btnProcesar.Click += new System.EventHandler(this.btnProcesar_Click);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // SaveFile
            // 
            this.SaveFile.Filter = "Archivos de Texto|*.txt";
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(413, 531);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(82, 23);
            this.button1.TabIndex = 372;
            this.button1.Text = "Pdf";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            // 
            // btnGenerarTXT
            // 
            this.btnGenerarTXT.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnGenerarTXT.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnGenerarTXT.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerarTXT.Image = ((System.Drawing.Image)(resources.GetObject("btnGenerarTXT.Image")));
            this.btnGenerarTXT.Location = new System.Drawing.Point(589, 531);
            this.btnGenerarTXT.Name = "btnGenerarTXT";
            this.btnGenerarTXT.Size = new System.Drawing.Size(82, 23);
            this.btnGenerarTXT.TabIndex = 370;
            this.btnGenerarTXT.Text = "PLE Txt";
            this.btnGenerarTXT.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGenerarTXT.UseVisualStyleBackColor = true;
            this.btnGenerarTXT.Click += new System.EventHandler(this.btnGenerarTXT_Click);
            // 
            // btnexcel
            // 
            this.btnexcel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnexcel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnexcel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnexcel.Image = ((System.Drawing.Image)(resources.GetObject("btnexcel.Image")));
            this.btnexcel.Location = new System.Drawing.Point(501, 531);
            this.btnexcel.Name = "btnexcel";
            this.btnexcel.Size = new System.Drawing.Size(82, 23);
            this.btnexcel.TabIndex = 371;
            this.btnexcel.Text = "Excel";
            this.btnexcel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnexcel.UseVisualStyleBackColor = true;
            this.btnexcel.Click += new System.EventHandler(this.btnexcel_Click);
            // 
            // lblmensaje
            // 
            this.lblmensaje.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblmensaje.AutoSize = true;
            this.lblmensaje.BackColor = System.Drawing.Color.Transparent;
            this.lblmensaje.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmensaje.Location = new System.Drawing.Point(13, 536);
            this.lblmensaje.Name = "lblmensaje";
            this.lblmensaje.Size = new System.Drawing.Size(110, 13);
            this.lblmensaje.TabIndex = 369;
            this.lblmensaje.Text = "Total de Registros: 0";
            // 
            // cboempresa
            // 
            this.cboempresa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(218)))), ((int)(((byte)(231)))));
            this.cboempresa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboempresa.FormattingEnabled = true;
            this.cboempresa.Location = new System.Drawing.Point(326, 52);
            this.cboempresa.Name = "cboempresa";
            this.cboempresa.Size = new System.Drawing.Size(425, 21);
            this.cboempresa.TabIndex = 368;
            this.cboempresa.SelectedIndexChanged += new System.EventHandler(this.cboempresa_SelectedIndexChanged);
            // 
            // txtruc
            // 
            this.txtruc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(218)))), ((int)(((byte)(231)))));
            this.txtruc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtruc.ColorFondoMouseEncima = System.Drawing.Color.Empty;
            this.txtruc.ColorFondoMousePresionado = System.Drawing.Color.Empty;
            this.txtruc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtruc.ForeColor = System.Drawing.Color.Black;
            this.txtruc.Format = null;
            this.txtruc.Location = new System.Drawing.Point(757, 52);
            this.txtruc.MaxLength = 12;
            this.txtruc.Name = "txtruc";
            this.txtruc.NextControlOnEnter = null;
            this.txtruc.ReadOnly = true;
            this.txtruc.Size = new System.Drawing.Size(114, 21);
            this.txtruc.TabIndex = 367;
            this.txtruc.Text = "00000000000";
            this.txtruc.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtruc.TextoDefecto = "00000000000";
            this.txtruc.TextoDefectoColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(129)))), ((int)(((byte)(189)))));
            this.txtruc.TiposDatos = HpResergerUserControls.TextBoxPer.ListaTipos.SoloNumeros;
            // 
            // comboMesAño1
            // 
            this.comboMesAño1.AutoSize = true;
            this.comboMesAño1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.comboMesAño1.BackColor = System.Drawing.Color.Transparent;
            this.comboMesAño1.FechaConDiaActual = new System.DateTime(2019, 12, 2, 0, 0, 0, 0);
            this.comboMesAño1.FechaFinMes = new System.DateTime(2019, 12, 31, 0, 0, 0, 0);
            this.comboMesAño1.FechaInicioMes = new System.DateTime(2019, 12, 1, 0, 0, 0, 0);
            this.comboMesAño1.Location = new System.Drawing.Point(70, 29);
            this.comboMesAño1.Name = "comboMesAño1";
            this.comboMesAño1.Size = new System.Drawing.Size(218, 27);
            this.comboMesAño1.TabIndex = 366;
            this.comboMesAño1.VerAño = true;
            this.comboMesAño1.VerMes = true;
            // 
            // separadorOre1
            // 
            this.separadorOre1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.separadorOre1.BackColor = System.Drawing.Color.Transparent;
            this.separadorOre1.Location = new System.Drawing.Point(0, 76);
            this.separadorOre1.MaximumSize = new System.Drawing.Size(2000, 2);
            this.separadorOre1.MinimumSize = new System.Drawing.Size(0, 2);
            this.separadorOre1.Name = "separadorOre1";
            this.separadorOre1.Size = new System.Drawing.Size(1092, 2);
            this.separadorOre1.TabIndex = 365;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(12, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 363;
            this.label2.Text = "PERIODO:\r\n";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(564, 19);
            this.label1.TabIndex = 364;
            this.label1.Text = "1.2 LIBRO CAJA Y BANCOS - DETALLE DE LOS MOVIMIENTOS DE LA CUENTA CORRIENTE";
            // 
            // dtgconten
            // 
            this.dtgconten.AllowUserToAddRows = false;
            this.dtgconten.AllowUserToDeleteRows = false;
            this.dtgconten.AllowUserToResizeColumns = false;
            this.dtgconten.AllowUserToResizeRows = false;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(230)))), ((int)(((byte)(241)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(191)))), ((int)(((byte)(231)))));
            this.dtgconten.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dtgconten.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgconten.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgconten.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(218)))), ((int)(((byte)(231)))));
            this.dtgconten.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgconten.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.dtgconten.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(129)))), ((int)(((byte)(189)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.DeepSkyBlue;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgconten.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dtgconten.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgconten.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.xperiodo,
            this.xcuo,
            this.xCorrelativo,
            this.xCodigoEntidad,
            this.xNroCuenta,
            this.xFechaOperacion,
            this.xTipoPago,
            this.xGlosa,
            this.xTipoDoc,
            this.xNumDoc,
            this.xBeneficiario,
            this.xNroOpBanco,
            this.xParteDeudora,
            this.xParteAcreedora,
            this.xEstado});
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(207)))), ((int)(((byte)(241)))));
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgconten.DefaultCellStyle = dataGridViewCellStyle10;
            this.dtgconten.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dtgconten.EnableHeadersVisualStyles = false;
            this.dtgconten.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(179)))), ((int)(((byte)(215)))));
            this.dtgconten.Location = new System.Drawing.Point(15, 82);
            this.dtgconten.Name = "dtgconten";
            this.dtgconten.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dtgconten.RowHeadersVisible = false;
            this.dtgconten.RowTemplate.Height = 18;
            this.dtgconten.Size = new System.Drawing.Size(1057, 443);
            this.dtgconten.TabIndex = 361;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(12, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(313, 13);
            this.label4.TabIndex = 362;
            this.label4.Text = "APELLIDOS Y NOMBRES, DENOMINACIÓN O RAZÓN SOCIAL:\r\n";
            // 
            // xperiodo
            // 
            this.xperiodo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.xperiodo.DataPropertyName = "Periodo";
            this.xperiodo.HeaderText = "Periodo";
            this.xperiodo.MinimumWidth = 50;
            this.xperiodo.Name = "xperiodo";
            this.xperiodo.Width = 50;
            // 
            // xcuo
            // 
            this.xcuo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.xcuo.DataPropertyName = "CUO";
            this.xcuo.HeaderText = "CUO";
            this.xcuo.MinimumWidth = 50;
            this.xcuo.Name = "xcuo";
            this.xcuo.Width = 50;
            // 
            // xCorrelativo
            // 
            this.xCorrelativo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.xCorrelativo.DataPropertyName = "Correlativo";
            this.xCorrelativo.HeaderText = "Correlativo";
            this.xCorrelativo.MinimumWidth = 70;
            this.xCorrelativo.Name = "xCorrelativo";
            this.xCorrelativo.Width = 70;
            // 
            // xCodigoEntidad
            // 
            this.xCodigoEntidad.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.xCodigoEntidad.DataPropertyName = "CodigoEntidad";
            this.xCodigoEntidad.HeaderText = "Codigo Entidad";
            this.xCodigoEntidad.MinimumWidth = 60;
            this.xCodigoEntidad.Name = "xCodigoEntidad";
            this.xCodigoEntidad.Width = 60;
            // 
            // xNroCuenta
            // 
            this.xNroCuenta.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.xNroCuenta.DataPropertyName = "NroCuenta";
            this.xNroCuenta.HeaderText = "Nro Cuenta";
            this.xNroCuenta.MinimumWidth = 70;
            this.xNroCuenta.Name = "xNroCuenta";
            this.xNroCuenta.Width = 70;
            // 
            // xFechaOperacion
            // 
            this.xFechaOperacion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.xFechaOperacion.DataPropertyName = "FechaOperacion";
            this.xFechaOperacion.HeaderText = "Fecha Operacion";
            this.xFechaOperacion.MinimumWidth = 60;
            this.xFechaOperacion.Name = "xFechaOperacion";
            this.xFechaOperacion.Width = 60;
            // 
            // xTipoPago
            // 
            this.xTipoPago.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.xTipoPago.DataPropertyName = "TipoPago";
            this.xTipoPago.HeaderText = "Tipo Pago";
            this.xTipoPago.MinimumWidth = 40;
            this.xTipoPago.Name = "xTipoPago";
            this.xTipoPago.Width = 40;
            // 
            // xGlosa
            // 
            this.xGlosa.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.xGlosa.DataPropertyName = "Glosa";
            this.xGlosa.HeaderText = "Glosa";
            this.xGlosa.MinimumWidth = 80;
            this.xGlosa.Name = "xGlosa";
            // 
            // xTipoDoc
            // 
            this.xTipoDoc.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.xTipoDoc.DataPropertyName = "TipoDoc";
            this.xTipoDoc.HeaderText = "Tipo Doc";
            this.xTipoDoc.MinimumWidth = 50;
            this.xTipoDoc.Name = "xTipoDoc";
            this.xTipoDoc.Width = 50;
            // 
            // xNumDoc
            // 
            this.xNumDoc.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.xNumDoc.DataPropertyName = "NumDoc";
            this.xNumDoc.HeaderText = "Num Doc";
            this.xNumDoc.MinimumWidth = 50;
            this.xNumDoc.Name = "xNumDoc";
            this.xNumDoc.Width = 50;
            // 
            // xBeneficiario
            // 
            this.xBeneficiario.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.xBeneficiario.DataPropertyName = "Beneficiario";
            this.xBeneficiario.HeaderText = "Beneficiario";
            this.xBeneficiario.MinimumWidth = 80;
            this.xBeneficiario.Name = "xBeneficiario";
            // 
            // xNroOpBanco
            // 
            this.xNroOpBanco.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.xNroOpBanco.DataPropertyName = "NroOpBanco";
            this.xNroOpBanco.HeaderText = "NroOp Banco";
            this.xNroOpBanco.MinimumWidth = 60;
            this.xNroOpBanco.Name = "xNroOpBanco";
            this.xNroOpBanco.Width = 60;
            // 
            // xParteDeudora
            // 
            this.xParteDeudora.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.xParteDeudora.DataPropertyName = "ParteDeudora";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle8.Format = "n2";
            this.xParteDeudora.DefaultCellStyle = dataGridViewCellStyle8;
            this.xParteDeudora.HeaderText = "Parte Deudora";
            this.xParteDeudora.MinimumWidth = 70;
            this.xParteDeudora.Name = "xParteDeudora";
            this.xParteDeudora.Width = 70;
            // 
            // xParteAcreedora
            // 
            this.xParteAcreedora.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.xParteAcreedora.DataPropertyName = "ParteAcreedora";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle9.Format = "N2";
            dataGridViewCellStyle9.NullValue = null;
            this.xParteAcreedora.DefaultCellStyle = dataGridViewCellStyle9;
            this.xParteAcreedora.HeaderText = "Parte Acreedora";
            this.xParteAcreedora.MinimumWidth = 70;
            this.xParteAcreedora.Name = "xParteAcreedora";
            this.xParteAcreedora.Width = 70;
            // 
            // xEstado
            // 
            this.xEstado.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.xEstado.DataPropertyName = "Estado";
            this.xEstado.HeaderText = "Estado";
            this.xEstado.MinimumWidth = 50;
            this.xEstado.Name = "xEstado";
            this.xEstado.Width = 50;
            // 
            // frmLibroBancosCorriente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 561);
            this.Controls.Add(this.BtnCerrar);
            this.Controls.Add(this.btnProcesar);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnGenerarTXT);
            this.Controls.Add(this.btnexcel);
            this.Controls.Add(this.lblmensaje);
            this.Controls.Add(this.cboempresa);
            this.Controls.Add(this.txtruc);
            this.Controls.Add(this.comboMesAño1);
            this.Controls.Add(this.separadorOre1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtgconten);
            this.Controls.Add(this.label4);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.MinimumSize = new System.Drawing.Size(1100, 600);
            this.Name = "frmLibroBancosCorriente";
            this.Nombre = "1.2 Libro Caja y Bancos - Detalle De Los Movimientos De la Cuenta Corriente";
            this.Text = "1.2 Libro Caja y Bancos - Detalle De Los Movimientos De la Cuenta Corriente";
            this.Load += new System.EventHandler(this.frmLibroBancosCorriente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgconten)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private HpResergerUserControls.FondoColorOre fondoColorOre1;
        private HpResergerUserControls.ButtonPer BtnCerrar;
        private HpResergerUserControls.ButtonPer btnProcesar;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.SaveFileDialog SaveFile;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnGenerarTXT;
        private System.Windows.Forms.Button btnexcel;
        private System.Windows.Forms.Label lblmensaje;
        private System.Windows.Forms.ComboBox cboempresa;
        private HpResergerUserControls.TextBoxPer txtruc;
        private HpResergerUserControls.ComboMesAño comboMesAño1;
        private HpResergerUserControls.SeparadorOre separadorOre1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private HpResergerUserControls.Dtgconten dtgconten;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn xperiodo;
        private System.Windows.Forms.DataGridViewTextBoxColumn xcuo;
        private System.Windows.Forms.DataGridViewTextBoxColumn xCorrelativo;
        private System.Windows.Forms.DataGridViewTextBoxColumn xCodigoEntidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn xNroCuenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn xFechaOperacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn xTipoPago;
        private System.Windows.Forms.DataGridViewTextBoxColumn xGlosa;
        private System.Windows.Forms.DataGridViewTextBoxColumn xTipoDoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn xNumDoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn xBeneficiario;
        private System.Windows.Forms.DataGridViewTextBoxColumn xNroOpBanco;
        private System.Windows.Forms.DataGridViewTextBoxColumn xParteDeudora;
        private System.Windows.Forms.DataGridViewTextBoxColumn xParteAcreedora;
        private System.Windows.Forms.DataGridViewTextBoxColumn xEstado;
    }
}