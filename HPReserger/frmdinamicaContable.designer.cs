namespace HPReserger
{
    partial class frmdinamicaContable
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label13 = new System.Windows.Forms.Label();
            this.cboyear = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cboestado = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtcodigo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbooperacion = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbosuboperacion = new System.Windows.Forms.ComboBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btneliminar = new System.Windows.Forms.Button();
            this.btnmodificar = new System.Windows.Forms.Button();
            this.btnnuevo = new System.Windows.Forms.Button();
            this.btncancelar = new System.Windows.Forms.Button();
            this.btnaceptar = new System.Windows.Forms.Button();
            this.lblmsg = new System.Windows.Forms.Label();
            this.tipmsg = new System.Windows.Forms.ToolTip(this.components);
            this.Dtgconten = new System.Windows.Forms.DataGridView();
            this.cuenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.debehaber = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.btnmas = new System.Windows.Forms.Button();
            this.dtgayuda = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.btnlimpiar = new System.Windows.Forms.Button();
            this.label22 = new System.Windows.Forms.Label();
            this.Txtbusca = new System.Windows.Forms.TextBox();
            this.dtgbusca = new System.Windows.Forms.DataGridView();
            this.lblmsg2 = new System.Windows.Forms.Label();
            this.dtgayuda2 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.Dtgconten)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgayuda)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgbusca)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgayuda2)).BeginInit();
            this.SuspendLayout();
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(12, 15);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(50, 13);
            this.label13.TabIndex = 102;
            this.label13.Text = "Ejercicio:";
            this.label13.Click += new System.EventHandler(this.label13_Click);
            // 
            // cboyear
            // 
            this.cboyear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboyear.FormattingEnabled = true;
            this.cboyear.ItemHeight = 13;
            this.cboyear.Location = new System.Drawing.Point(76, 12);
            this.cboyear.MaxDropDownItems = 1;
            this.cboyear.MaxLength = 4;
            this.cboyear.Name = "cboyear";
            this.cboyear.Size = new System.Drawing.Size(76, 21);
            this.cboyear.TabIndex = 101;
            this.cboyear.SelectedIndexChanged += new System.EventHandler(this.cboyear_SelectedIndexChanged);
            this.cboyear.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cboanalitica_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(163, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 104;
            this.label1.Text = "Estado:";
            // 
            // cboestado
            // 
            this.cboestado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboestado.FormattingEnabled = true;
            this.cboestado.Location = new System.Drawing.Point(227, 12);
            this.cboestado.Name = "cboestado";
            this.cboestado.Size = new System.Drawing.Size(76, 21);
            this.cboestado.TabIndex = 103;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(309, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 105;
            this.label2.Text = "Código Dinámica";
            // 
            // txtcodigo
            // 
            this.txtcodigo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtcodigo.Enabled = false;
            this.txtcodigo.Location = new System.Drawing.Point(402, 12);
            this.txtcodigo.MaxLength = 15;
            this.txtcodigo.Name = "txtcodigo";
            this.txtcodigo.Size = new System.Drawing.Size(172, 20);
            this.txtcodigo.TabIndex = 106;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 108;
            this.label3.Text = "Operación:";
            // 
            // cbooperacion
            // 
            this.cbooperacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbooperacion.Location = new System.Drawing.Point(77, 39);
            this.cbooperacion.Name = "cbooperacion";
            this.cbooperacion.Size = new System.Drawing.Size(319, 21);
            this.cbooperacion.TabIndex = 107;
            this.cbooperacion.SelectedIndexChanged += new System.EventHandler(this.cbooperacion_SelectedIndexChanged);
            this.cbooperacion.TextChanged += new System.EventHandler(this.cbooperacion_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 13);
            this.label4.TabIndex = 110;
            this.label4.Text = "Sub Operación:";
            // 
            // cbosuboperacion
            // 
            this.cbosuboperacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbosuboperacion.FormattingEnabled = true;
            this.cbosuboperacion.Location = new System.Drawing.Point(99, 66);
            this.cbosuboperacion.Name = "cbosuboperacion";
            this.cbosuboperacion.Size = new System.Drawing.Size(297, 21);
            this.cbosuboperacion.TabIndex = 109;
            this.cbosuboperacion.SelectedIndexChanged += new System.EventHandler(this.cbosuboperacion_SelectedIndexChanged);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(-18, 85);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(817, 13);
            this.label19.TabIndex = 111;
            this.label19.Text = "_________________________________________________________________________________" +
    "______________________________________________________";
            this.label19.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label19.Click += new System.EventHandler(this.label19_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 113);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 13);
            this.label5.TabIndex = 112;
            this.label5.Text = "Dinámica Contable:";
            // 
            // btneliminar
            // 
            this.btneliminar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btneliminar.Location = new System.Drawing.Point(580, 61);
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Size = new System.Drawing.Size(82, 21);
            this.btneliminar.TabIndex = 115;
            this.btneliminar.Text = "Eliminar";
            this.btneliminar.UseVisualStyleBackColor = true;
            this.btneliminar.Click += new System.EventHandler(this.btneliminar_Click);
            // 
            // btnmodificar
            // 
            this.btnmodificar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnmodificar.Location = new System.Drawing.Point(580, 35);
            this.btnmodificar.Name = "btnmodificar";
            this.btnmodificar.Size = new System.Drawing.Size(82, 21);
            this.btnmodificar.TabIndex = 114;
            this.btnmodificar.Text = "Modificar";
            this.btnmodificar.UseVisualStyleBackColor = true;
            this.btnmodificar.Click += new System.EventHandler(this.btnmodificar_Click);
            // 
            // btnnuevo
            // 
            this.btnnuevo.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnnuevo.Location = new System.Drawing.Point(580, 12);
            this.btnnuevo.Name = "btnnuevo";
            this.btnnuevo.Size = new System.Drawing.Size(82, 20);
            this.btnnuevo.TabIndex = 113;
            this.btnnuevo.Text = "Nuevo";
            this.btnnuevo.UseVisualStyleBackColor = true;
            this.btnnuevo.Click += new System.EventHandler(this.btnnuevo_Click);
            // 
            // btncancelar
            // 
            this.btncancelar.Location = new System.Drawing.Point(583, 670);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(82, 29);
            this.btncancelar.TabIndex = 117;
            this.btncancelar.Text = "Cancelar";
            this.btncancelar.UseVisualStyleBackColor = true;
            this.btncancelar.Click += new System.EventHandler(this.btncancelar_Click);
            // 
            // btnaceptar
            // 
            this.btnaceptar.Location = new System.Drawing.Point(485, 670);
            this.btnaceptar.Name = "btnaceptar";
            this.btnaceptar.Size = new System.Drawing.Size(82, 29);
            this.btnaceptar.TabIndex = 116;
            this.btnaceptar.Text = "Aceptar";
            this.btnaceptar.UseVisualStyleBackColor = true;
            this.btnaceptar.Click += new System.EventHandler(this.btnaceptar_Click);
            // 
            // lblmsg
            // 
            this.lblmsg.AutoSize = true;
            this.lblmsg.Location = new System.Drawing.Point(12, 324);
            this.lblmsg.Name = "lblmsg";
            this.lblmsg.Size = new System.Drawing.Size(96, 13);
            this.lblmsg.TabIndex = 130;
            this.lblmsg.Text = "Total de Registros:";
            // 
            // tipmsg
            // 
            this.tipmsg.IsBalloon = true;
            // 
            // Dtgconten
            // 
            this.Dtgconten.AllowUserToAddRows = false;
            this.Dtgconten.AllowUserToResizeColumns = false;
            this.Dtgconten.BackgroundColor = System.Drawing.SystemColors.HighlightText;
            this.Dtgconten.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.Dtgconten.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.Dtgconten.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cuenta,
            this.descripcion,
            this.debehaber});
            this.Dtgconten.Location = new System.Drawing.Point(13, 130);
            this.Dtgconten.MultiSelect = false;
            this.Dtgconten.Name = "Dtgconten";
            this.Dtgconten.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Dtgconten.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Dtgconten.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Dtgconten.ShowRowErrors = false;
            this.Dtgconten.Size = new System.Drawing.Size(648, 191);
            this.Dtgconten.TabIndex = 131;
            this.Dtgconten.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.Dtgconten_CellBeginEdit);
            this.Dtgconten.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dtgconten_CellContentClick);
            this.Dtgconten.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dtgconten_CellDoubleClick);
            this.Dtgconten.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dtgconten_CellEndEdit);
            this.Dtgconten.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dtgconten_CellValueChanged);
            this.Dtgconten.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dtgconten_RowEnter);
            this.Dtgconten.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Dtgconten_KeyDown);
            this.Dtgconten.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Dtgconten_KeyPress);
            this.Dtgconten.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Dtgconten_KeyUp);
            // 
            // cuenta
            // 
            this.cuenta.Frozen = true;
            this.cuenta.HeaderText = "CUENTA CONTABLE";
            this.cuenta.Name = "cuenta";
            this.cuenta.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.cuenta.Width = 150;
            // 
            // descripcion
            // 
            this.descripcion.HeaderText = "DESCRIPCION CUENTA CONTABLE";
            this.descripcion.Name = "descripcion";
            this.descripcion.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.descripcion.Width = 350;
            // 
            // debehaber
            // 
            this.debehaber.HeaderText = "DEBE/HABER";
            this.debehaber.Name = "debehaber";
            this.debehaber.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.debehaber.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // btnmas
            // 
            this.btnmas.Location = new System.Drawing.Point(579, 103);
            this.btnmas.Name = "btnmas";
            this.btnmas.Size = new System.Drawing.Size(82, 21);
            this.btnmas.TabIndex = 115;
            this.btnmas.Text = "+ Cuentas";
            this.btnmas.UseVisualStyleBackColor = true;
            this.btnmas.Click += new System.EventHandler(this.button1_Click);
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
            this.dtgayuda.Location = new System.Drawing.Point(695, 12);
            this.dtgayuda.Name = "dtgayuda";
            this.dtgayuda.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dtgayuda.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dtgayuda.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgayuda.Size = new System.Drawing.Size(456, 196);
            this.dtgayuda.TabIndex = 132;
            this.dtgayuda.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(-71, 331);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(817, 13);
            this.label6.TabIndex = 133;
            this.label6.Text = "_________________________________________________________________________________" +
    "______________________________________________________";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton4);
            this.groupBox1.Controls.Add(this.radioButton5);
            this.groupBox1.Controls.Add(this.radioButton3);
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Location = new System.Drawing.Point(16, 378);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(649, 28);
            this.groupBox1.TabIndex = 138;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.radioButton4.Location = new System.Drawing.Point(169, 10);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(80, 18);
            this.radioButton4.TabIndex = 130;
            this.radioButton4.Text = "Operación";
            this.radioButton4.UseVisualStyleBackColor = true;
            this.radioButton4.CheckedChanged += new System.EventHandler(this.radioButton4_CheckedChanged);
            // 
            // radioButton5
            // 
            this.radioButton5.AutoSize = true;
            this.radioButton5.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.radioButton5.Location = new System.Drawing.Point(373, 8);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(65, 18);
            this.radioButton5.TabIndex = 130;
            this.radioButton5.Text = "Cuenta";
            this.radioButton5.UseVisualStyleBackColor = true;
            this.radioButton5.CheckedChanged += new System.EventHandler(this.radioButton5_CheckedChanged);
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.radioButton3.Location = new System.Drawing.Point(268, 10);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(99, 18);
            this.radioButton3.TabIndex = 130;
            this.radioButton3.Text = "SubOperación";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.radioButton2.Location = new System.Drawing.Point(88, 10);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(71, 18);
            this.radioButton2.TabIndex = 130;
            this.radioButton2.Text = "Ejercicio";
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
            this.btnlimpiar.Location = new System.Drawing.Point(90, 354);
            this.btnlimpiar.Name = "btnlimpiar";
            this.btnlimpiar.Size = new System.Drawing.Size(20, 21);
            this.btnlimpiar.TabIndex = 137;
            this.btnlimpiar.Text = "";
            this.btnlimpiar.UseVisualStyleBackColor = true;
            this.btnlimpiar.Click += new System.EventHandler(this.btnlimpiar_Click);
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(15, 362);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(51, 13);
            this.label22.TabIndex = 136;
            this.label22.Text = "BUSCAR";
            this.label22.Click += new System.EventHandler(this.label22_Click);
            // 
            // Txtbusca
            // 
            this.Txtbusca.BackColor = System.Drawing.SystemColors.Info;
            this.Txtbusca.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.Txtbusca.Cursor = System.Windows.Forms.Cursors.Help;
            this.Txtbusca.Location = new System.Drawing.Point(116, 354);
            this.Txtbusca.Name = "Txtbusca";
            this.Txtbusca.Size = new System.Drawing.Size(529, 20);
            this.Txtbusca.TabIndex = 135;
            this.Txtbusca.TextChanged += new System.EventHandler(this.Txtbusca_TextChanged);
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
            this.dtgbusca.Location = new System.Drawing.Point(18, 410);
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
            this.dtgbusca.TabIndex = 134;
            this.dtgbusca.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgbusca_CellContentClick);
            this.dtgbusca.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgbusca_RowEnter);
            // 
            // lblmsg2
            // 
            this.lblmsg2.AutoSize = true;
            this.lblmsg2.Location = new System.Drawing.Point(15, 678);
            this.lblmsg2.Name = "lblmsg2";
            this.lblmsg2.Size = new System.Drawing.Size(96, 13);
            this.lblmsg2.TabIndex = 130;
            this.lblmsg2.Text = "Total de Registros:";
            this.lblmsg2.Click += new System.EventHandler(this.lblmsg2_Click);
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
            this.dtgayuda2.Location = new System.Drawing.Point(695, 368);
            this.dtgayuda2.Name = "dtgayuda2";
            this.dtgayuda2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dtgayuda2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dtgayuda2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgayuda2.Size = new System.Drawing.Size(679, 196);
            this.dtgayuda2.TabIndex = 139;
            this.dtgayuda2.Visible = false;
            this.dtgayuda2.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgayuda2_RowEnter);
            // 
            // frmdinamicaContable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(684, 711);
            this.Controls.Add(this.dtgayuda2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnlimpiar);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.Txtbusca);
            this.Controls.Add(this.dtgayuda);
            this.Controls.Add(this.Dtgconten);
            this.Controls.Add(this.lblmsg2);
            this.Controls.Add(this.lblmsg);
            this.Controls.Add(this.btncancelar);
            this.Controls.Add(this.btnaceptar);
            this.Controls.Add(this.btnmas);
            this.Controls.Add(this.btneliminar);
            this.Controls.Add(this.btnmodificar);
            this.Controls.Add(this.btnnuevo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbosuboperacion);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbooperacion);
            this.Controls.Add(this.txtcodigo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboestado);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.cboyear);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dtgbusca);
            this.MaximumSize = new System.Drawing.Size(700, 750);
            this.MinimumSize = new System.Drawing.Size(700, 750);
            this.Name = "frmdinamicaContable";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dinámica Cuenta Contable";
            this.Load += new System.EventHandler(this.frmdinamicaContable_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Dtgconten)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgayuda)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgbusca)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgayuda2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox cboyear;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboestado;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbooperacion;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbosuboperacion;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btneliminar;
        private System.Windows.Forms.Button btnmodificar;
        private System.Windows.Forms.Button btnnuevo;
        private System.Windows.Forms.Button btncancelar;
        private System.Windows.Forms.Button btnaceptar;
        private System.Windows.Forms.Label lblmsg;
        private System.Windows.Forms.ToolTip tipmsg;
        private System.Windows.Forms.DataGridView Dtgconten;
        private System.Windows.Forms.Button btnmas;
        private System.Windows.Forms.DataGridView dtgayuda;
        private System.Windows.Forms.DataGridViewTextBoxColumn cuenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcion;
        private System.Windows.Forms.DataGridViewComboBoxColumn debehaber;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton5;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Button btnlimpiar;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.DataGridView dtgbusca;
        private System.Windows.Forms.Label lblmsg2;
        private System.Windows.Forms.DataGridView dtgayuda2;
        public System.Windows.Forms.TextBox txtcodigo;
        public System.Windows.Forms.TextBox Txtbusca;
    }
}