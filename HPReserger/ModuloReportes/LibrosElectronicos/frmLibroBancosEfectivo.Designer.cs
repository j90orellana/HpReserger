namespace HPReserger.ModuloReportes.LibrosElectronicos
{
    partial class frmLibroBancosEfectivo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLibroBancosEfectivo));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.button1 = new System.Windows.Forms.Button();
            this.btnGenerarTXT = new System.Windows.Forms.Button();
            this.btnexcel = new System.Windows.Forms.Button();
            this.lblmensaje = new System.Windows.Forms.Label();
            this.cboempresa = new System.Windows.Forms.ComboBox();
            this.txtruc = new HpResergerUserControls.TextBoxPer();
            this.comboMesAño1 = new HpResergerUserControls.ComboMesAño();
            this.separadorOre1 = new HpResergerUserControls.SeparadorOre();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtgconten = new HpResergerUserControls.Dtgconten();
            this.xperiodo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xcuo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xCorrelativo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xCodigoCuenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xCodigoOperacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xCentroCosto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xMoneda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xTipoComprobante = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xSerieComprobante = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xNumComprobante = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xFechaContable = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xFechaVence = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xFechaEmision = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xGlosa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xDebe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xHaber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xDatoEstructurado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xEstado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtnCerrar = new HpResergerUserControls.ButtonPer();
            this.btnProcesar = new HpResergerUserControls.ButtonPer();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.fondoColorOre1 = new HpResergerUserControls.FondoColorOre(this.components);
            this.SaveFile = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dtgconten)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(413, 530);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(82, 23);
            this.button1.TabIndex = 358;
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
            this.btnGenerarTXT.Location = new System.Drawing.Point(589, 530);
            this.btnGenerarTXT.Name = "btnGenerarTXT";
            this.btnGenerarTXT.Size = new System.Drawing.Size(82, 23);
            this.btnGenerarTXT.TabIndex = 356;
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
            this.btnexcel.Location = new System.Drawing.Point(501, 530);
            this.btnexcel.Name = "btnexcel";
            this.btnexcel.Size = new System.Drawing.Size(82, 23);
            this.btnexcel.TabIndex = 357;
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
            this.lblmensaje.Location = new System.Drawing.Point(13, 535);
            this.lblmensaje.Name = "lblmensaje";
            this.lblmensaje.Size = new System.Drawing.Size(110, 13);
            this.lblmensaje.TabIndex = 354;
            this.lblmensaje.Text = "Total de Registros: 0";
            // 
            // cboempresa
            // 
            this.cboempresa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(218)))), ((int)(((byte)(231)))));
            this.cboempresa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboempresa.FormattingEnabled = true;
            this.cboempresa.Location = new System.Drawing.Point(326, 51);
            this.cboempresa.Name = "cboempresa";
            this.cboempresa.Size = new System.Drawing.Size(425, 21);
            this.cboempresa.TabIndex = 352;
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
            this.txtruc.Location = new System.Drawing.Point(757, 51);
            this.txtruc.MaxLength = 12;
            this.txtruc.Name = "txtruc";
            this.txtruc.NextControlOnEnter = null;
            this.txtruc.ReadOnly = true;
            this.txtruc.Size = new System.Drawing.Size(114, 21);
            this.txtruc.TabIndex = 351;
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
            this.comboMesAño1.Location = new System.Drawing.Point(70, 28);
            this.comboMesAño1.Name = "comboMesAño1";
            this.comboMesAño1.Size = new System.Drawing.Size(218, 27);
            this.comboMesAño1.TabIndex = 350;
            this.comboMesAño1.VerAño = true;
            this.comboMesAño1.VerMes = true;
            // 
            // separadorOre1
            // 
            this.separadorOre1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.separadorOre1.BackColor = System.Drawing.Color.Transparent;
            this.separadorOre1.Location = new System.Drawing.Point(0, 75);
            this.separadorOre1.MaximumSize = new System.Drawing.Size(2000, 2);
            this.separadorOre1.MinimumSize = new System.Drawing.Size(0, 2);
            this.separadorOre1.Name = "separadorOre1";
            this.separadorOre1.Size = new System.Drawing.Size(1092, 2);
            this.separadorOre1.TabIndex = 349;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(12, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(313, 13);
            this.label4.TabIndex = 346;
            this.label4.Text = "APELLIDOS Y NOMBRES, DENOMINACIÓN O RAZÓN SOCIAL:\r\n";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(12, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 347;
            this.label2.Text = "PERIODO:\r\n";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(554, 19);
            this.label1.TabIndex = 348;
            this.label1.Text = "FORMATO 1.1 LIBRO CAJA Y BANCOS - DETALLE DE LOS MOVIMIENTOS DEL EFECTIVO";
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
            this.xperiodo,
            this.xcuo,
            this.xCorrelativo,
            this.xCodigoCuenta,
            this.xCodigoOperacion,
            this.xCentroCosto,
            this.xMoneda,
            this.xTipoComprobante,
            this.xSerieComprobante,
            this.xNumComprobante,
            this.xFechaContable,
            this.xFechaVence,
            this.xFechaEmision,
            this.xGlosa,
            this.xDebe,
            this.xHaber,
            this.xDatoEstructurado,
            this.xEstado});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(207)))), ((int)(((byte)(241)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgconten.DefaultCellStyle = dataGridViewCellStyle5;
            this.dtgconten.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dtgconten.EnableHeadersVisualStyles = false;
            this.dtgconten.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(179)))), ((int)(((byte)(215)))));
            this.dtgconten.Location = new System.Drawing.Point(15, 81);
            this.dtgconten.Name = "dtgconten";
            this.dtgconten.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dtgconten.RowHeadersVisible = false;
            this.dtgconten.RowTemplate.Height = 18;
            this.dtgconten.Size = new System.Drawing.Size(1057, 443);
            this.dtgconten.TabIndex = 345;
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
            // xCodigoCuenta
            // 
            this.xCodigoCuenta.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.xCodigoCuenta.DataPropertyName = "CodigoCuenta";
            this.xCodigoCuenta.HeaderText = "Codigo Cuenta";
            this.xCodigoCuenta.MinimumWidth = 65;
            this.xCodigoCuenta.Name = "xCodigoCuenta";
            this.xCodigoCuenta.Width = 65;
            // 
            // xCodigoOperacion
            // 
            this.xCodigoOperacion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.xCodigoOperacion.DataPropertyName = "CodigoOperacion";
            this.xCodigoOperacion.HeaderText = "Codigo Operacion";
            this.xCodigoOperacion.MinimumWidth = 70;
            this.xCodigoOperacion.Name = "xCodigoOperacion";
            this.xCodigoOperacion.Width = 70;
            // 
            // xCentroCosto
            // 
            this.xCentroCosto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.xCentroCosto.DataPropertyName = "CentroCosto";
            this.xCentroCosto.HeaderText = "Centro Costo";
            this.xCentroCosto.MinimumWidth = 60;
            this.xCentroCosto.Name = "xCentroCosto";
            this.xCentroCosto.Width = 60;
            // 
            // xMoneda
            // 
            this.xMoneda.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.xMoneda.DataPropertyName = "Moneda";
            this.xMoneda.HeaderText = "Mon";
            this.xMoneda.MinimumWidth = 40;
            this.xMoneda.Name = "xMoneda";
            this.xMoneda.Width = 40;
            // 
            // xTipoComprobante
            // 
            this.xTipoComprobante.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.xTipoComprobante.DataPropertyName = "TipoComprobante";
            this.xTipoComprobante.HeaderText = "Tp. Comp.";
            this.xTipoComprobante.MinimumWidth = 50;
            this.xTipoComprobante.Name = "xTipoComprobante";
            this.xTipoComprobante.Width = 50;
            // 
            // xSerieComprobante
            // 
            this.xSerieComprobante.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.xSerieComprobante.DataPropertyName = "SerieComprobante";
            this.xSerieComprobante.HeaderText = "S. Comp.";
            this.xSerieComprobante.MinimumWidth = 50;
            this.xSerieComprobante.Name = "xSerieComprobante";
            this.xSerieComprobante.Width = 50;
            // 
            // xNumComprobante
            // 
            this.xNumComprobante.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.xNumComprobante.DataPropertyName = "NumComprobante";
            this.xNumComprobante.HeaderText = "Num. Comp.";
            this.xNumComprobante.MinimumWidth = 50;
            this.xNumComprobante.Name = "xNumComprobante";
            this.xNumComprobante.Width = 50;
            // 
            // xFechaContable
            // 
            this.xFechaContable.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.xFechaContable.DataPropertyName = "FechaContable";
            this.xFechaContable.HeaderText = "Fecha Contable";
            this.xFechaContable.MinimumWidth = 70;
            this.xFechaContable.Name = "xFechaContable";
            this.xFechaContable.Width = 70;
            // 
            // xFechaVence
            // 
            this.xFechaVence.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.xFechaVence.DataPropertyName = "FechaVence";
            this.xFechaVence.HeaderText = "Fecha Vence";
            this.xFechaVence.MinimumWidth = 60;
            this.xFechaVence.Name = "xFechaVence";
            this.xFechaVence.Width = 60;
            // 
            // xFechaEmision
            // 
            this.xFechaEmision.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.xFechaEmision.DataPropertyName = "FechaEmision";
            this.xFechaEmision.HeaderText = "Fecha Emision";
            this.xFechaEmision.MinimumWidth = 60;
            this.xFechaEmision.Name = "xFechaEmision";
            this.xFechaEmision.Width = 60;
            // 
            // xGlosa
            // 
            this.xGlosa.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.xGlosa.DataPropertyName = "Glosa";
            this.xGlosa.HeaderText = "Glosa";
            this.xGlosa.MinimumWidth = 80;
            this.xGlosa.Name = "xGlosa";
            // 
            // xDebe
            // 
            this.xDebe.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.xDebe.DataPropertyName = "Debe";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.Format = "n2";
            this.xDebe.DefaultCellStyle = dataGridViewCellStyle3;
            this.xDebe.HeaderText = "Debe";
            this.xDebe.MinimumWidth = 50;
            this.xDebe.Name = "xDebe";
            this.xDebe.Width = 50;
            // 
            // xHaber
            // 
            this.xHaber.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.xHaber.DataPropertyName = "Haber";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle4.Format = "N2";
            dataGridViewCellStyle4.NullValue = null;
            this.xHaber.DefaultCellStyle = dataGridViewCellStyle4;
            this.xHaber.HeaderText = "Haber";
            this.xHaber.MinimumWidth = 50;
            this.xHaber.Name = "xHaber";
            this.xHaber.Width = 50;
            // 
            // xDatoEstructurado
            // 
            this.xDatoEstructurado.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.xDatoEstructurado.DataPropertyName = "DatoEstructurado";
            this.xDatoEstructurado.HeaderText = "Dato Estructurado";
            this.xDatoEstructurado.MinimumWidth = 80;
            this.xDatoEstructurado.Name = "xDatoEstructurado";
            this.xDatoEstructurado.Width = 80;
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
            // BtnCerrar
            // 
            this.BtnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnCerrar.BackColor = System.Drawing.Color.Crimson;
            this.BtnCerrar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnCerrar.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.BtnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCerrar.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCerrar.ForeColor = System.Drawing.Color.White;
            this.BtnCerrar.Location = new System.Drawing.Point(989, 529);
            this.BtnCerrar.Name = "BtnCerrar";
            this.BtnCerrar.Size = new System.Drawing.Size(83, 24);
            this.BtnCerrar.TabIndex = 360;
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
            this.btnProcesar.Location = new System.Drawing.Point(989, 49);
            this.btnProcesar.Name = "btnProcesar";
            this.btnProcesar.Size = new System.Drawing.Size(83, 24);
            this.btnProcesar.TabIndex = 359;
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
            // fondoColorOre1
            // 
            this.fondoColorOre1.Angulo = 135;
            this.fondoColorOre1.Colores = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(253)))), ((int)(((byte)(253))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(229)))), ((int)(((byte)(237))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))))};
            this.fondoColorOre1.control = null;
            // 
            // SaveFile
            // 
            this.SaveFile.Filter = "Archivos de Texto|*.txt";
            // 
            // frmLibroBancosEfectivo
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
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtgconten);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinimumSize = new System.Drawing.Size(1100, 600);
            this.Name = "frmLibroBancosEfectivo";
            this.Nombre = "1.1 Libro Caja y Bancos - Detalle De Los Movimientos Del Efectivo";
            this.Text = "1.1 Libro Caja y Bancos - Detalle De Los Movimientos Del Efectivo";
            this.Load += new System.EventHandler(this.LibroBancosEfectivo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgconten)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnGenerarTXT;
        private System.Windows.Forms.Button btnexcel;
        private System.Windows.Forms.Label lblmensaje;
        private System.Windows.Forms.ComboBox cboempresa;
        private HpResergerUserControls.TextBoxPer txtruc;
        private HpResergerUserControls.ComboMesAño comboMesAño1;
        private HpResergerUserControls.SeparadorOre separadorOre1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private HpResergerUserControls.Dtgconten dtgconten;
        private HpResergerUserControls.ButtonPer BtnCerrar;
        private HpResergerUserControls.ButtonPer btnProcesar;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private HpResergerUserControls.FondoColorOre fondoColorOre1;
        private System.Windows.Forms.SaveFileDialog SaveFile;
        private System.Windows.Forms.DataGridViewTextBoxColumn xperiodo;
        private System.Windows.Forms.DataGridViewTextBoxColumn xcuo;
        private System.Windows.Forms.DataGridViewTextBoxColumn xCorrelativo;
        private System.Windows.Forms.DataGridViewTextBoxColumn xCodigoCuenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn xCodigoOperacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn xCentroCosto;
        private System.Windows.Forms.DataGridViewTextBoxColumn xMoneda;
        private System.Windows.Forms.DataGridViewTextBoxColumn xTipoComprobante;
        private System.Windows.Forms.DataGridViewTextBoxColumn xSerieComprobante;
        private System.Windows.Forms.DataGridViewTextBoxColumn xNumComprobante;
        private System.Windows.Forms.DataGridViewTextBoxColumn xFechaContable;
        private System.Windows.Forms.DataGridViewTextBoxColumn xFechaVence;
        private System.Windows.Forms.DataGridViewTextBoxColumn xFechaEmision;
        private System.Windows.Forms.DataGridViewTextBoxColumn xGlosa;
        private System.Windows.Forms.DataGridViewTextBoxColumn xDebe;
        private System.Windows.Forms.DataGridViewTextBoxColumn xHaber;
        private System.Windows.Forms.DataGridViewTextBoxColumn xDatoEstructurado;
        private System.Windows.Forms.DataGridViewTextBoxColumn xEstado;
    }
}