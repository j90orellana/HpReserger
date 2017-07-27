namespace HPReserger
{
    partial class frmAsientoContable
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkfecha = new System.Windows.Forms.CheckBox();
            this.fechafin = new System.Windows.Forms.DateTimePicker();
            this.fechaini = new System.Windows.Forms.DateTimePicker();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.btnlimpiar = new System.Windows.Forms.Button();
            this.label22 = new System.Windows.Forms.Label();
            this.Txtbusca = new System.Windows.Forms.TextBox();
            this.lblmsg2 = new System.Windows.Forms.Label();
            this.btncancelar = new System.Windows.Forms.Button();
            this.btnaceptar = new System.Windows.Forms.Button();
            this.btneliminar = new System.Windows.Forms.Button();
            this.btnmodificar = new System.Windows.Forms.Button();
            this.btnnuevo = new System.Windows.Forms.Button();
            this.txtcodigo = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.dtgbusca = new System.Windows.Forms.DataGridView();
            this.label19 = new System.Windows.Forms.Label();
            this.fecha = new System.Windows.Forms.DateTimePicker();
            this.Dtgconten = new System.Windows.Forms.DataGridView();
            this.cuenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.debe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.haber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnmas = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Dinamica = new System.Windows.Forms.Label();
            this.txtdinamica = new System.Windows.Forms.TextBox();
            this.dtgayuda = new System.Windows.Forms.DataGridView();
            this.btndina = new System.Windows.Forms.Button();
            this.dtgayuda2 = new System.Windows.Forms.DataGridView();
            this.txttotalhaber = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txttotaldebe = new System.Windows.Forms.TextBox();
            this.txtdiferencia = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lblmsg = new System.Windows.Forms.Label();
            this.dtgayuda3 = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.cboestado = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgbusca)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dtgconten)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgayuda)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgayuda2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgayuda3)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkfecha);
            this.groupBox1.Controls.Add(this.fechafin);
            this.groupBox1.Controls.Add(this.fechaini);
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Location = new System.Drawing.Point(26, 415);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(649, 28);
            this.groupBox1.TabIndex = 152;
            this.groupBox1.TabStop = false;
            // 
            // chkfecha
            // 
            this.chkfecha.AutoSize = true;
            this.chkfecha.Location = new System.Drawing.Point(159, 10);
            this.chkfecha.Name = "chkfecha";
            this.chkfecha.Size = new System.Drawing.Size(56, 17);
            this.chkfecha.TabIndex = 169;
            this.chkfecha.Text = "Fecha";
            this.chkfecha.UseVisualStyleBackColor = true;
            this.chkfecha.CheckedChanged += new System.EventHandler(this.chkfecha_CheckedChanged);
            // 
            // fechafin
            // 
            this.fechafin.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.fechafin.Location = new System.Drawing.Point(370, 8);
            this.fechafin.MaxDate = new System.DateTime(3000, 12, 31, 0, 0, 0, 0);
            this.fechafin.MinDate = new System.DateTime(1950, 1, 1, 0, 0, 0, 0);
            this.fechafin.Name = "fechafin";
            this.fechafin.Size = new System.Drawing.Size(105, 20);
            this.fechafin.TabIndex = 168;
            this.fechafin.Value = new System.DateTime(2017, 4, 27, 9, 44, 35, 0);
            this.fechafin.ValueChanged += new System.EventHandler(this.fechafin_ValueChanged);
            // 
            // fechaini
            // 
            this.fechaini.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.fechaini.Location = new System.Drawing.Point(250, 8);
            this.fechaini.MaxDate = new System.DateTime(3000, 12, 31, 0, 0, 0, 0);
            this.fechaini.MinDate = new System.DateTime(1950, 1, 1, 0, 0, 0, 0);
            this.fechaini.Name = "fechaini";
            this.fechaini.Size = new System.Drawing.Size(105, 20);
            this.fechaini.TabIndex = 167;
            this.fechaini.Value = new System.DateTime(2017, 4, 27, 9, 44, 35, 0);
            this.fechaini.ValueChanged += new System.EventHandler(this.fechaini_ValueChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.radioButton2.Location = new System.Drawing.Point(88, 10);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(65, 18);
            this.radioButton2.TabIndex = 130;
            this.radioButton2.Text = "Cuenta";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.radioButton1.Location = new System.Drawing.Point(18, 10);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(64, 18);
            this.radioButton1.TabIndex = 130;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Código";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // btnlimpiar
            // 
            this.btnlimpiar.Cursor = System.Windows.Forms.Cursors.Cross;
            this.btnlimpiar.Font = new System.Drawing.Font("Webdings", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(3)));
            this.btnlimpiar.Location = new System.Drawing.Point(100, 391);
            this.btnlimpiar.Name = "btnlimpiar";
            this.btnlimpiar.Size = new System.Drawing.Size(20, 21);
            this.btnlimpiar.TabIndex = 151;
            this.btnlimpiar.Text = "";
            this.btnlimpiar.UseVisualStyleBackColor = true;
            this.btnlimpiar.Click += new System.EventHandler(this.btnlimpiar_Click);
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(25, 399);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(51, 13);
            this.label22.TabIndex = 150;
            this.label22.Text = "BUSCAR";
            // 
            // Txtbusca
            // 
            this.Txtbusca.BackColor = System.Drawing.SystemColors.Info;
            this.Txtbusca.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.Txtbusca.Cursor = System.Windows.Forms.Cursors.Help;
            this.Txtbusca.Location = new System.Drawing.Point(126, 391);
            this.Txtbusca.Name = "Txtbusca";
            this.Txtbusca.Size = new System.Drawing.Size(529, 20);
            this.Txtbusca.TabIndex = 149;
            this.Txtbusca.TextChanged += new System.EventHandler(this.Txtbusca_TextChanged);
            // 
            // lblmsg2
            // 
            this.lblmsg2.AutoSize = true;
            this.lblmsg2.Location = new System.Drawing.Point(25, 715);
            this.lblmsg2.Name = "lblmsg2";
            this.lblmsg2.Size = new System.Drawing.Size(96, 13);
            this.lblmsg2.TabIndex = 147;
            this.lblmsg2.Text = "Total de Registros:";
            // 
            // btncancelar
            // 
            this.btncancelar.Location = new System.Drawing.Point(593, 707);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(82, 29);
            this.btncancelar.TabIndex = 146;
            this.btncancelar.Text = "Cancelar";
            this.btncancelar.UseVisualStyleBackColor = true;
            this.btncancelar.Click += new System.EventHandler(this.btncancelar_Click);
            // 
            // btnaceptar
            // 
            this.btnaceptar.Location = new System.Drawing.Point(495, 707);
            this.btnaceptar.Name = "btnaceptar";
            this.btnaceptar.Size = new System.Drawing.Size(82, 29);
            this.btnaceptar.TabIndex = 145;
            this.btnaceptar.Text = "Aceptar";
            this.btnaceptar.UseVisualStyleBackColor = true;
            this.btnaceptar.Click += new System.EventHandler(this.btnaceptar_Click);
            // 
            // btneliminar
            // 
            this.btneliminar.Enabled = false;
            this.btneliminar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btneliminar.Location = new System.Drawing.Point(583, 61);
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Size = new System.Drawing.Size(82, 21);
            this.btneliminar.TabIndex = 144;
            this.btneliminar.Text = "Eliminar";
            this.btneliminar.UseVisualStyleBackColor = true;
            this.btneliminar.Click += new System.EventHandler(this.btneliminar_Click);
            // 
            // btnmodificar
            // 
            this.btnmodificar.Enabled = false;
            this.btnmodificar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnmodificar.Location = new System.Drawing.Point(583, 35);
            this.btnmodificar.Name = "btnmodificar";
            this.btnmodificar.Size = new System.Drawing.Size(82, 21);
            this.btnmodificar.TabIndex = 143;
            this.btnmodificar.Text = "Modificar";
            this.btnmodificar.UseVisualStyleBackColor = true;
            this.btnmodificar.Click += new System.EventHandler(this.btnmodificar_Click);
            // 
            // btnnuevo
            // 
            this.btnnuevo.Enabled = false;
            this.btnnuevo.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnnuevo.Location = new System.Drawing.Point(583, 12);
            this.btnnuevo.Name = "btnnuevo";
            this.btnnuevo.Size = new System.Drawing.Size(82, 20);
            this.btnnuevo.TabIndex = 142;
            this.btnnuevo.Text = "Nuevo";
            this.btnnuevo.UseVisualStyleBackColor = true;
            this.btnnuevo.Click += new System.EventHandler(this.btnnuevo_Click);
            // 
            // txtcodigo
            // 
            this.txtcodigo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtcodigo.Enabled = false;
            this.txtcodigo.Location = new System.Drawing.Point(405, 12);
            this.txtcodigo.MaxLength = 15;
            this.txtcodigo.Name = "txtcodigo";
            this.txtcodigo.Size = new System.Drawing.Size(172, 20);
            this.txtcodigo.TabIndex = 141;
            this.txtcodigo.TextChanged += new System.EventHandler(this.txtcodigo_TextChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(348, 16);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(43, 13);
            this.label13.TabIndex = 140;
            this.label13.Text = "Código:";
            // 
            // dtgbusca
            // 
            this.dtgbusca.AllowUserToAddRows = false;
            this.dtgbusca.AllowUserToDeleteRows = false;
            this.dtgbusca.AllowUserToResizeColumns = false;
            this.dtgbusca.AllowUserToResizeRows = false;
            this.dtgbusca.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dtgbusca.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dtgbusca.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dtgbusca.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dtgbusca.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgbusca.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgbusca.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgbusca.Cursor = System.Windows.Forms.Cursors.Default;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgbusca.DefaultCellStyle = dataGridViewCellStyle2;
            this.dtgbusca.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dtgbusca.Location = new System.Drawing.Point(28, 447);
            this.dtgbusca.MultiSelect = false;
            this.dtgbusca.Name = "dtgbusca";
            this.dtgbusca.ReadOnly = true;
            this.dtgbusca.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgbusca.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dtgbusca.RowHeadersVisible = false;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtgbusca.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dtgbusca.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgbusca.Size = new System.Drawing.Size(647, 254);
            this.dtgbusca.TabIndex = 148;
            this.dtgbusca.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgbusca_CellContentClick);
            this.dtgbusca.CellValidated += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgbusca_CellValidated);
            this.dtgbusca.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgbusca_CellValueChanged);
            this.dtgbusca.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgbusca_RowEnter);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(-19, 371);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(817, 13);
            this.label19.TabIndex = 153;
            this.label19.Text = "_________________________________________________________________________________" +
    "______________________________________________________";
            this.label19.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // fecha
            // 
            this.fecha.Enabled = false;
            this.fecha.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.fecha.Location = new System.Drawing.Point(212, 62);
            this.fecha.MaxDate = new System.DateTime(3000, 12, 31, 0, 0, 0, 0);
            this.fecha.MinDate = new System.DateTime(1950, 1, 1, 0, 0, 0, 0);
            this.fecha.Name = "fecha";
            this.fecha.Size = new System.Drawing.Size(105, 20);
            this.fecha.TabIndex = 154;
            this.fecha.Value = new System.DateTime(2017, 4, 27, 9, 44, 35, 0);
            // 
            // Dtgconten
            // 
            this.Dtgconten.AllowUserToAddRows = false;
            this.Dtgconten.AllowUserToDeleteRows = false;
            this.Dtgconten.AllowUserToResizeColumns = false;
            this.Dtgconten.AllowUserToResizeRows = false;
            this.Dtgconten.BackgroundColor = System.Drawing.SystemColors.HighlightText;
            this.Dtgconten.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.Dtgconten.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.Dtgconten.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cuenta,
            this.descripcion,
            this.debe,
            this.haber});
            this.Dtgconten.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.Dtgconten.Enabled = false;
            this.Dtgconten.Location = new System.Drawing.Point(18, 120);
            this.Dtgconten.MultiSelect = false;
            this.Dtgconten.Name = "Dtgconten";
            this.Dtgconten.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Dtgconten.RowHeadersVisible = false;
            this.Dtgconten.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Dtgconten.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.Dtgconten.ShowRowErrors = false;
            this.Dtgconten.Size = new System.Drawing.Size(648, 191);
            this.Dtgconten.TabIndex = 155;
            this.Dtgconten.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dtgconten_CellDoubleClick);
            this.Dtgconten.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dtgconten_CellEndEdit);
            this.Dtgconten.CellValidated += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dtgconten_CellValidated);
            this.Dtgconten.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dtgconten_CellValueChanged);
            this.Dtgconten.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.Dtgconten_EditingControlShowing);
            this.Dtgconten.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.Dtgconten_RowsAdded);
            this.Dtgconten.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Dtgconten_KeyDown);
            this.Dtgconten.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Dtgconten_KeyPress);
            // 
            // cuenta
            // 
            this.cuenta.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.cuenta.Frozen = true;
            this.cuenta.HeaderText = "CUENTA";
            this.cuenta.MaxInputLength = 30;
            this.cuenta.Name = "cuenta";
            this.cuenta.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.cuenta.Width = 76;
            // 
            // descripcion
            // 
            this.descripcion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.descripcion.HeaderText = "DESCRIPCION CUENTA CONTABLE";
            this.descripcion.MaxInputLength = 400;
            this.descripcion.Name = "descripcion";
            this.descripcion.ReadOnly = true;
            this.descripcion.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // debe
            // 
            this.debe.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle5.Format = "N2";
            dataGridViewCellStyle5.NullValue = "0.00";
            this.debe.DefaultCellStyle = dataGridViewCellStyle5;
            this.debe.HeaderText = "DEBE";
            this.debe.MaxInputLength = 30;
            this.debe.Name = "debe";
            this.debe.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.debe.Width = 61;
            // 
            // haber
            // 
            this.haber.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle6.Format = "N2";
            dataGridViewCellStyle6.NullValue = "0.00";
            this.haber.DefaultCellStyle = dataGridViewCellStyle6;
            this.haber.HeaderText = "HABER";
            this.haber.MaxInputLength = 30;
            this.haber.Name = "haber";
            this.haber.Width = 69;
            // 
            // btnmas
            // 
            this.btnmas.Enabled = false;
            this.btnmas.Location = new System.Drawing.Point(583, 93);
            this.btnmas.Name = "btnmas";
            this.btnmas.Size = new System.Drawing.Size(82, 21);
            this.btnmas.TabIndex = 156;
            this.btnmas.Text = "+ Cuentas";
            this.btnmas.UseVisualStyleBackColor = true;
            this.btnmas.Click += new System.EventHandler(this.btnmas_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(-41, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(817, 13);
            this.label1.TabIndex = 157;
            this.label1.Text = "_________________________________________________________________________________" +
    "______________________________________________________";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(167, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 140;
            this.label2.Text = "Fecha:";
            // 
            // Dinamica
            // 
            this.Dinamica.AutoSize = true;
            this.Dinamica.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dinamica.Location = new System.Drawing.Point(348, 65);
            this.Dinamica.Name = "Dinamica";
            this.Dinamica.Size = new System.Drawing.Size(51, 13);
            this.Dinamica.TabIndex = 140;
            this.Dinamica.Text = "Dinámica";
            // 
            // txtdinamica
            // 
            this.txtdinamica.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtdinamica.Enabled = false;
            this.txtdinamica.Location = new System.Drawing.Point(439, 61);
            this.txtdinamica.MaxLength = 15;
            this.txtdinamica.Name = "txtdinamica";
            this.txtdinamica.Size = new System.Drawing.Size(140, 20);
            this.txtdinamica.TabIndex = 141;
            this.txtdinamica.Click += new System.EventHandler(this.txtdinamica_Click);
            this.txtdinamica.TextChanged += new System.EventHandler(this.txtcodigo_TextChanged);
            this.txtdinamica.DoubleClick += new System.EventHandler(this.txtdinamica_DoubleClick);
            this.txtdinamica.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtdinamica_KeyDown);
            this.txtdinamica.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtdinamica_KeyPress);
            this.txtdinamica.Leave += new System.EventHandler(this.txtdinamica_Leave);
            // 
            // dtgayuda
            // 
            this.dtgayuda.AllowUserToAddRows = false;
            this.dtgayuda.AllowUserToDeleteRows = false;
            this.dtgayuda.AllowUserToResizeColumns = false;
            this.dtgayuda.BackgroundColor = System.Drawing.SystemColors.HighlightText;
            this.dtgayuda.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dtgayuda.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dtgayuda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dtgayuda.Location = new System.Drawing.Point(712, 16);
            this.dtgayuda.Name = "dtgayuda";
            this.dtgayuda.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dtgayuda.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dtgayuda.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgayuda.Size = new System.Drawing.Size(456, 191);
            this.dtgayuda.TabIndex = 158;
            this.dtgayuda.Visible = false;
            this.dtgayuda.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgayuda_CellEnter);
            this.dtgayuda.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgayuda_CellValueChanged);
            this.dtgayuda.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dtgayuda_RowsAdded);
            // 
            // btndina
            // 
            this.btndina.Enabled = false;
            this.btndina.Location = new System.Drawing.Point(405, 61);
            this.btndina.Name = "btndina";
            this.btndina.Size = new System.Drawing.Size(28, 22);
            this.btndina.TabIndex = 1;
            this.btndina.Text = "+";
            this.btndina.UseVisualStyleBackColor = true;
            this.btndina.Click += new System.EventHandler(this.btndina_Click);
            // 
            // dtgayuda2
            // 
            this.dtgayuda2.AllowUserToAddRows = false;
            this.dtgayuda2.AllowUserToDeleteRows = false;
            this.dtgayuda2.AllowUserToResizeColumns = false;
            this.dtgayuda2.BackgroundColor = System.Drawing.SystemColors.HighlightText;
            this.dtgayuda2.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dtgayuda2.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dtgayuda2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dtgayuda2.Location = new System.Drawing.Point(712, 220);
            this.dtgayuda2.Name = "dtgayuda2";
            this.dtgayuda2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dtgayuda2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dtgayuda2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgayuda2.Size = new System.Drawing.Size(456, 191);
            this.dtgayuda2.TabIndex = 159;
            this.dtgayuda2.Visible = false;
            // 
            // txttotalhaber
            // 
            this.txttotalhaber.BackColor = System.Drawing.SystemColors.Window;
            this.txttotalhaber.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttotalhaber.Location = new System.Drawing.Point(563, 330);
            this.txttotalhaber.MaxLength = 20;
            this.txttotalhaber.Name = "txttotalhaber";
            this.txttotalhaber.Size = new System.Drawing.Size(102, 20);
            this.txttotalhaber.TabIndex = 160;
            this.txttotalhaber.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(580, 314);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 161;
            this.label3.Text = "Total Haber";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(469, 314);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 163;
            this.label4.Text = "Total Debe";
            // 
            // txttotaldebe
            // 
            this.txttotaldebe.BackColor = System.Drawing.SystemColors.Window;
            this.txttotaldebe.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttotaldebe.Location = new System.Drawing.Point(455, 330);
            this.txttotaldebe.MaxLength = 20;
            this.txttotaldebe.Name = "txttotaldebe";
            this.txttotaldebe.Size = new System.Drawing.Size(102, 20);
            this.txttotaldebe.TabIndex = 162;
            this.txttotaldebe.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtdiferencia
            // 
            this.txtdiferencia.BackColor = System.Drawing.SystemColors.Window;
            this.txtdiferencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdiferencia.Location = new System.Drawing.Point(563, 356);
            this.txtdiferencia.MaxLength = 20;
            this.txtdiferencia.Name = "txtdiferencia";
            this.txtdiferencia.Size = new System.Drawing.Size(102, 20);
            this.txtdiferencia.TabIndex = 164;
            this.txtdiferencia.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(494, 359);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 165;
            this.label5.Text = "Diferencia";
            // 
            // lblmsg
            // 
            this.lblmsg.AutoSize = true;
            this.lblmsg.Location = new System.Drawing.Point(15, 337);
            this.lblmsg.Name = "lblmsg";
            this.lblmsg.Size = new System.Drawing.Size(96, 13);
            this.lblmsg.TabIndex = 166;
            this.lblmsg.Text = "Total de Registros:";
            // 
            // dtgayuda3
            // 
            this.dtgayuda3.AllowUserToAddRows = false;
            this.dtgayuda3.AllowUserToDeleteRows = false;
            this.dtgayuda3.AllowUserToResizeColumns = false;
            this.dtgayuda3.BackgroundColor = System.Drawing.SystemColors.HighlightText;
            this.dtgayuda3.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dtgayuda3.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dtgayuda3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dtgayuda3.Location = new System.Drawing.Point(712, 425);
            this.dtgayuda3.Name = "dtgayuda3";
            this.dtgayuda3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dtgayuda3.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dtgayuda3.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgayuda3.Size = new System.Drawing.Size(456, 191);
            this.dtgayuda3.TabIndex = 167;
            this.dtgayuda3.Visible = false;
            this.dtgayuda3.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgayuda3_RowEnter);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(167, 38);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 169;
            this.label6.Text = "Estado:";
            // 
            // cboestado
            // 
            this.cboestado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboestado.Enabled = false;
            this.cboestado.FormattingEnabled = true;
            this.cboestado.Location = new System.Drawing.Point(212, 35);
            this.cboestado.Name = "cboestado";
            this.cboestado.Size = new System.Drawing.Size(105, 21);
            this.cboestado.TabIndex = 168;
            this.cboestado.SelectedIndexChanged += new System.EventHandler(this.cboestado_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(15, 97);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(117, 13);
            this.label7.TabIndex = 170;
            this.label7.Text = "ASIENTO CONTABLE:";
            // 
            // frmAsientoContable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(687, 767);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cboestado);
            this.Controls.Add(this.dtgayuda3);
            this.Controls.Add(this.lblmsg);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtdiferencia);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txttotaldebe);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txttotalhaber);
            this.Controls.Add(this.dtgayuda2);
            this.Controls.Add(this.btndina);
            this.Controls.Add(this.dtgayuda);
            this.Controls.Add(this.btnmas);
            this.Controls.Add(this.Dtgconten);
            this.Controls.Add(this.fecha);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnlimpiar);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.Txtbusca);
            this.Controls.Add(this.lblmsg2);
            this.Controls.Add(this.btncancelar);
            this.Controls.Add(this.btnaceptar);
            this.Controls.Add(this.btneliminar);
            this.Controls.Add(this.btnmodificar);
            this.Controls.Add(this.btnnuevo);
            this.Controls.Add(this.txtdinamica);
            this.Controls.Add(this.txtcodigo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Dinamica);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.dtgbusca);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAsientoContable";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Asiento Contable";
            this.Load += new System.EventHandler(this.frmAsientoContable_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgbusca)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dtgconten)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgayuda)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgayuda2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgayuda3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Button btnlimpiar;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox Txtbusca;
        private System.Windows.Forms.Label lblmsg2;
        private System.Windows.Forms.Button btncancelar;
        private System.Windows.Forms.Button btnaceptar;
        private System.Windows.Forms.Button btneliminar;
        private System.Windows.Forms.Button btnmodificar;
        private System.Windows.Forms.Button btnnuevo;
        private System.Windows.Forms.TextBox txtcodigo;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DataGridView dtgbusca;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.DateTimePicker fecha;
        private System.Windows.Forms.DataGridView Dtgconten;
        private System.Windows.Forms.Button btnmas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Dinamica;
        private System.Windows.Forms.TextBox txtdinamica;
        private System.Windows.Forms.DataGridView dtgayuda;
        private System.Windows.Forms.Button btndina;
        private System.Windows.Forms.DataGridView dtgayuda2;
        private System.Windows.Forms.TextBox txttotalhaber;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txttotaldebe;
        private System.Windows.Forms.TextBox txtdiferencia;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblmsg;
        private System.Windows.Forms.DateTimePicker fechafin;
        private System.Windows.Forms.DateTimePicker fechaini;
        private System.Windows.Forms.DataGridView dtgayuda3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cboestado;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox chkfecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn cuenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn debe;
        private System.Windows.Forms.DataGridViewTextBoxColumn haber;
    }
}