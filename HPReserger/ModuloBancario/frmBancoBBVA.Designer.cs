namespace HPReserger.ModuloBancario
{
    partial class frmBancoBBVA
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBancoBBVA));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.ptb = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.cboMoneda = new HpResergerUserControls.ComboBoxPer(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.cboPertenencia = new HpResergerUserControls.ComboBoxPer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtRefencia = new System.Windows.Forms.TextBox();
            this.txtcuentapago = new System.Windows.Forms.TextBox();
            this.btnaceptar = new System.Windows.Forms.Button();
            this.btncancelar = new System.Windows.Forms.Button();
            this.dtgconten = new HpResergerUserControls.Dtgconten();
            this.xDoi = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.xDoiNumero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xTipoAbono = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.xCuentaAbonar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xNombreBeneficiario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xImporteAbonar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xTipoRecibo = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.xNroDocumento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xAbono = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.xReferencia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xIndicadorAviso = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.xMedioAviso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xPersonaContacto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SaveFile = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.ptb)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgconten)).BeginInit();
            this.SuspendLayout();
            // 
            // ptb
            // 
            this.ptb.BackColor = System.Drawing.Color.White;
            this.ptb.Image = ((System.Drawing.Image)(resources.GetObject("ptb.Image")));
            this.ptb.Location = new System.Drawing.Point(0, -12);
            this.ptb.Name = "ptb";
            this.ptb.Size = new System.Drawing.Size(454, 85);
            this.ptb.TabIndex = 65;
            this.ptb.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(50)))), ((int)(((byte)(99)))));
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtTotal);
            this.panel1.Controls.Add(this.cboMoneda);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.cboPertenencia);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtRefencia);
            this.panel1.Controls.Add(this.txtcuentapago);
            this.panel1.Controls.Add(this.ptb);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1184, 71);
            this.panel1.TabIndex = 66;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(1063, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 13);
            this.label5.TabIndex = 92;
            this.label5.Text = "TOTAL PLANILLA";
            // 
            // txtTotal
            // 
            this.txtTotal.BackColor = System.Drawing.Color.White;
            this.txtTotal.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtTotal.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(33)))), ((int)(((byte)(70)))));
            this.txtTotal.Location = new System.Drawing.Point(1043, 44);
            this.txtTotal.MaxLength = 18;
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(129, 22);
            this.txtTotal.TabIndex = 91;
            this.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cboMoneda
            // 
            this.cboMoneda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(33)))), ((int)(((byte)(70)))));
            this.cboMoneda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.cboMoneda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboMoneda.ForeColor = System.Drawing.Color.White;
            this.cboMoneda.FormattingEnabled = true;
            this.cboMoneda.IndexText = null;
            this.cboMoneda.Items.AddRange(new object[] {
            "SI",
            "NO"});
            this.cboMoneda.Location = new System.Drawing.Point(827, 21);
            this.cboMoneda.Name = "cboMoneda";
            this.cboMoneda.ReadOnly = true;
            this.cboMoneda.Size = new System.Drawing.Size(210, 21);
            this.cboMoneda.TabIndex = 90;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(778, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 89;
            this.label4.Text = "Moneda:";
            // 
            // cboPertenencia
            // 
            this.cboPertenencia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(33)))), ((int)(((byte)(70)))));
            this.cboPertenencia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPertenencia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboPertenencia.ForeColor = System.Drawing.Color.White;
            this.cboPertenencia.FormattingEnabled = true;
            this.cboPertenencia.IndexText = null;
            this.cboPertenencia.Items.AddRange(new object[] {
            "SI",
            "NO"});
            this.cboPertenencia.Location = new System.Drawing.Point(570, 45);
            this.cboPertenencia.Name = "cboPertenencia";
            this.cboPertenencia.ReadOnly = false;
            this.cboPertenencia.Size = new System.Drawing.Size(176, 21);
            this.cboPertenencia.TabIndex = 90;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(471, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 27);
            this.label2.TabIndex = 89;
            this.label2.Text = "Validación de Pertenencia:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(746, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 13);
            this.label3.TabIndex = 89;
            this.label3.Text = "Glosa del Pago:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(471, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 89;
            this.label1.Text = "Cuenta de Cargo:";
            // 
            // txtRefencia
            // 
            this.txtRefencia.BackColor = System.Drawing.Color.White;
            this.txtRefencia.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtRefencia.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRefencia.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(33)))), ((int)(((byte)(70)))));
            this.txtRefencia.Location = new System.Drawing.Point(827, 44);
            this.txtRefencia.MaxLength = 24;
            this.txtRefencia.Name = "txtRefencia";
            this.txtRefencia.Size = new System.Drawing.Size(210, 22);
            this.txtRefencia.TabIndex = 88;
            this.txtRefencia.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtcuentapago
            // 
            this.txtcuentapago.BackColor = System.Drawing.Color.White;
            this.txtcuentapago.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtcuentapago.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcuentapago.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(33)))), ((int)(((byte)(70)))));
            this.txtcuentapago.Location = new System.Drawing.Point(568, 20);
            this.txtcuentapago.MaxLength = 18;
            this.txtcuentapago.Name = "txtcuentapago";
            this.txtcuentapago.ReadOnly = true;
            this.txtcuentapago.Size = new System.Drawing.Size(176, 22);
            this.txtcuentapago.TabIndex = 88;
            this.txtcuentapago.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnaceptar
            // 
            this.btnaceptar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnaceptar.BackColor = System.Drawing.Color.White;
            this.btnaceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnaceptar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(100)))), ((int)(((byte)(165)))));
            this.btnaceptar.Location = new System.Drawing.Point(1016, 427);
            this.btnaceptar.Name = "btnaceptar";
            this.btnaceptar.Size = new System.Drawing.Size(75, 23);
            this.btnaceptar.TabIndex = 87;
            this.btnaceptar.Text = "Generar";
            this.btnaceptar.UseVisualStyleBackColor = false;
            this.btnaceptar.Click += new System.EventHandler(this.btnaceptar_Click);
            // 
            // btncancelar
            // 
            this.btncancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btncancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(33)))), ((int)(((byte)(70)))));
            this.btncancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btncancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncancelar.ForeColor = System.Drawing.Color.White;
            this.btncancelar.Location = new System.Drawing.Point(1097, 427);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(75, 23);
            this.btncancelar.TabIndex = 88;
            this.btncancelar.Text = "Cancelar";
            this.btncancelar.UseVisualStyleBackColor = false;
            this.btncancelar.Click += new System.EventHandler(this.btncancelar_Click);
            // 
            // dtgconten
            // 
            this.dtgconten.AllowUserToAddRows = false;
            this.dtgconten.AllowUserToResizeColumns = false;
            this.dtgconten.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(192)))), ((int)(((byte)(213)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(213)))), ((int)(((byte)(227)))));
            this.dtgconten.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgconten.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgconten.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgconten.BackgroundColor = System.Drawing.Color.White;
            this.dtgconten.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgconten.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.dtgconten.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(50)))), ((int)(((byte)(99)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(100)))), ((int)(((byte)(165)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgconten.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dtgconten.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgconten.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.xDoi,
            this.xDoiNumero,
            this.xTipoAbono,
            this.xCuentaAbonar,
            this.xNombreBeneficiario,
            this.xImporteAbonar,
            this.xTipoRecibo,
            this.xNroDocumento,
            this.xAbono,
            this.xReferencia,
            this.xIndicadorAviso,
            this.xMedioAviso,
            this.xPersonaContacto});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(207)))), ((int)(((byte)(241)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgconten.DefaultCellStyle = dataGridViewCellStyle4;
            this.dtgconten.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dtgconten.EnableHeadersVisualStyles = false;
            this.dtgconten.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(100)))), ((int)(((byte)(165)))));
            this.dtgconten.Location = new System.Drawing.Point(12, 79);
            this.dtgconten.Name = "dtgconten";
            this.dtgconten.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dtgconten.RowHeadersVisible = false;
            this.dtgconten.RowTemplate.Height = 18;
            this.dtgconten.Size = new System.Drawing.Size(1160, 342);
            this.dtgconten.TabIndex = 86;
            this.dtgconten.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dtgconten_DataError);
            this.dtgconten.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgconten_RowEnter);
            // 
            // xDoi
            // 
            this.xDoi.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.xDoi.DataPropertyName = "doitipo";
            this.xDoi.HeaderText = "DOI Tipo";
            this.xDoi.MinimumWidth = 54;
            this.xDoi.Name = "xDoi";
            this.xDoi.ReadOnly = true;
            this.xDoi.Width = 54;
            // 
            // xDoiNumero
            // 
            this.xDoiNumero.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.xDoiNumero.DataPropertyName = "doinumero";
            this.xDoiNumero.HeaderText = "Doi Numero";
            this.xDoiNumero.MaxInputLength = 11;
            this.xDoiNumero.MinimumWidth = 70;
            this.xDoiNumero.Name = "xDoiNumero";
            this.xDoiNumero.ReadOnly = true;
            this.xDoiNumero.Width = 70;
            // 
            // xTipoAbono
            // 
            this.xTipoAbono.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.xTipoAbono.DataPropertyName = "TipoAbono";
            this.xTipoAbono.HeaderText = "TipoAbono";
            this.xTipoAbono.MinimumWidth = 60;
            this.xTipoAbono.Name = "xTipoAbono";
            this.xTipoAbono.ReadOnly = true;
            this.xTipoAbono.Width = 60;
            // 
            // xCuentaAbonar
            // 
            this.xCuentaAbonar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.xCuentaAbonar.DataPropertyName = "NroCuentaAbonar";
            this.xCuentaAbonar.HeaderText = "Nro Cuentas Abonar";
            this.xCuentaAbonar.MaxInputLength = 20;
            this.xCuentaAbonar.MinimumWidth = 80;
            this.xCuentaAbonar.Name = "xCuentaAbonar";
            this.xCuentaAbonar.ReadOnly = true;
            this.xCuentaAbonar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.xCuentaAbonar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.xCuentaAbonar.Width = 80;
            // 
            // xNombreBeneficiario
            // 
            this.xNombreBeneficiario.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.xNombreBeneficiario.DataPropertyName = "Beneficiario";
            this.xNombreBeneficiario.HeaderText = "Nombre Beneficiario";
            this.xNombreBeneficiario.MaxInputLength = 39;
            this.xNombreBeneficiario.MinimumWidth = 100;
            this.xNombreBeneficiario.Name = "xNombreBeneficiario";
            this.xNombreBeneficiario.ReadOnly = true;
            // 
            // xImporteAbonar
            // 
            this.xImporteAbonar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.xImporteAbonar.DataPropertyName = "ImporteAbonar";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.Format = "n2";
            this.xImporteAbonar.DefaultCellStyle = dataGridViewCellStyle3;
            this.xImporteAbonar.HeaderText = "Importe Abonar";
            this.xImporteAbonar.MaxInputLength = 14;
            this.xImporteAbonar.MinimumWidth = 70;
            this.xImporteAbonar.Name = "xImporteAbonar";
            this.xImporteAbonar.ReadOnly = true;
            this.xImporteAbonar.Width = 70;
            // 
            // xTipoRecibo
            // 
            this.xTipoRecibo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.xTipoRecibo.DataPropertyName = "TipoRecibo";
            this.xTipoRecibo.HeaderText = "Tipo Recibo";
            this.xTipoRecibo.MinimumWidth = 70;
            this.xTipoRecibo.Name = "xTipoRecibo";
            this.xTipoRecibo.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.xTipoRecibo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.xTipoRecibo.Width = 70;
            // 
            // xNroDocumento
            // 
            this.xNroDocumento.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.xNroDocumento.DataPropertyName = "NroDocumento";
            this.xNroDocumento.HeaderText = "Nro Documento";
            this.xNroDocumento.MaxInputLength = 11;
            this.xNroDocumento.MinimumWidth = 80;
            this.xNroDocumento.Name = "xNroDocumento";
            this.xNroDocumento.ReadOnly = true;
            this.xNroDocumento.Width = 80;
            // 
            // xAbono
            // 
            this.xAbono.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.xAbono.DataPropertyName = "AbonoAgrupado";
            this.xAbono.HeaderText = "Abono Agrupado";
            this.xAbono.MinimumWidth = 70;
            this.xAbono.Name = "xAbono";
            this.xAbono.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.xAbono.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.xAbono.Width = 70;
            // 
            // xReferencia
            // 
            this.xReferencia.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.xReferencia.DataPropertyName = "Referencia";
            this.xReferencia.HeaderText = "Referencia";
            this.xReferencia.MaxInputLength = 40;
            this.xReferencia.MinimumWidth = 75;
            this.xReferencia.Name = "xReferencia";
            this.xReferencia.Width = 75;
            // 
            // xIndicadorAviso
            // 
            this.xIndicadorAviso.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.xIndicadorAviso.DataPropertyName = "IndicadorAviso";
            this.xIndicadorAviso.HeaderText = "Indicador Aviso";
            this.xIndicadorAviso.MinimumWidth = 75;
            this.xIndicadorAviso.Name = "xIndicadorAviso";
            this.xIndicadorAviso.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.xIndicadorAviso.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.xIndicadorAviso.Width = 75;
            // 
            // xMedioAviso
            // 
            this.xMedioAviso.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.xMedioAviso.DataPropertyName = "MedioAviso";
            this.xMedioAviso.HeaderText = "Medio Aviso";
            this.xMedioAviso.MaxInputLength = 49;
            this.xMedioAviso.MinimumWidth = 75;
            this.xMedioAviso.Name = "xMedioAviso";
            this.xMedioAviso.Width = 75;
            // 
            // xPersonaContacto
            // 
            this.xPersonaContacto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.xPersonaContacto.DataPropertyName = "PersonaContacto";
            this.xPersonaContacto.HeaderText = "Persona Contacto";
            this.xPersonaContacto.MaxInputLength = 29;
            this.xPersonaContacto.MinimumWidth = 70;
            this.xPersonaContacto.Name = "xPersonaContacto";
            this.xPersonaContacto.Width = 70;
            // 
            // SaveFile
            // 
            this.SaveFile.Filter = "Archivos de Texto|*.txt";
            // 
            // frmBancoBBVA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1184, 461);
            this.Colores = new System.Drawing.Color[0];
            this.Controls.Add(this.btnaceptar);
            this.Controls.Add(this.btncancelar);
            this.Controls.Add(this.dtgconten);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinimumSize = new System.Drawing.Size(1200, 500);
            this.Name = "frmBancoBBVA";
            this.Nombre = "TeleBanking Pago Proveedores BBVA";
            this.Text = "TeleBanking Pago Proveedores BBVA";
            this.Load += new System.EventHandler(this.frmBancoBBVA_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ptb)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgconten)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox ptb;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnaceptar;
        private System.Windows.Forms.Button btncancelar;
        private HpResergerUserControls.Dtgconten dtgconten;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox txtcuentapago;
        private HpResergerUserControls.ComboBoxPer cboPertenencia;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox txtRefencia;
        private HpResergerUserControls.ComboBoxPer cboMoneda;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.DataGridViewComboBoxColumn xDoi;
        private System.Windows.Forms.DataGridViewTextBoxColumn xDoiNumero;
        private System.Windows.Forms.DataGridViewComboBoxColumn xTipoAbono;
        private System.Windows.Forms.DataGridViewTextBoxColumn xCuentaAbonar;
        private System.Windows.Forms.DataGridViewTextBoxColumn xNombreBeneficiario;
        private System.Windows.Forms.DataGridViewTextBoxColumn xImporteAbonar;
        private System.Windows.Forms.DataGridViewComboBoxColumn xTipoRecibo;
        private System.Windows.Forms.DataGridViewTextBoxColumn xNroDocumento;
        private System.Windows.Forms.DataGridViewComboBoxColumn xAbono;
        private System.Windows.Forms.DataGridViewTextBoxColumn xReferencia;
        private System.Windows.Forms.DataGridViewComboBoxColumn xIndicadorAviso;
        private System.Windows.Forms.DataGridViewTextBoxColumn xMedioAviso;
        private System.Windows.Forms.DataGridViewTextBoxColumn xPersonaContacto;
        private System.Windows.Forms.SaveFileDialog SaveFile;
    }
}