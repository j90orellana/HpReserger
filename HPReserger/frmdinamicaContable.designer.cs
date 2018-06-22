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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmdinamicaContable));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.codx = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ejerciciox = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.opx = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.operacionx = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.csx = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.suboperacionx = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ccx = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cuentax = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.partex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estadox = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.label13.Location = new System.Drawing.Point(43, 16);
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
            this.cboyear.Location = new System.Drawing.Point(99, 12);
            this.cboyear.MaxDropDownItems = 1;
            this.cboyear.MaxLength = 4;
            this.cboyear.Name = "cboyear";
            this.cboyear.Size = new System.Drawing.Size(73, 21);
            this.cboyear.TabIndex = 101;
            this.cboyear.SelectedIndexChanged += new System.EventHandler(this.cboyear_SelectedIndexChanged);
            this.cboyear.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cboanalitica_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(182, 16);
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
            this.label2.Location = new System.Drawing.Point(309, 16);
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
            this.label3.Location = new System.Drawing.Point(34, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 108;
            this.label3.Text = "Operación:";
            // 
            // cbooperacion
            // 
            this.cbooperacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbooperacion.Location = new System.Drawing.Point(99, 39);
            this.cbooperacion.Name = "cbooperacion";
            this.cbooperacion.Size = new System.Drawing.Size(297, 21);
            this.cbooperacion.TabIndex = 107;
            this.cbooperacion.SelectedIndexChanged += new System.EventHandler(this.cbooperacion_SelectedIndexChanged);
            this.cbooperacion.TextChanged += new System.EventHandler(this.cbooperacion_TextChanged);
            this.cbooperacion.Click += new System.EventHandler(this.cbooperacion_Click);
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
            this.cbosuboperacion.Click += new System.EventHandler(this.cbosuboperacion_Click);
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
            this.btneliminar.Image = ((System.Drawing.Image)(resources.GetObject("btneliminar.Image")));
            this.btneliminar.Location = new System.Drawing.Point(580, 65);
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Size = new System.Drawing.Size(82, 23);
            this.btneliminar.TabIndex = 115;
            this.btneliminar.Text = "Eliminar";
            this.btneliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btneliminar.UseVisualStyleBackColor = true;
            this.btneliminar.Click += new System.EventHandler(this.btneliminar_Click);
            // 
            // btnmodificar
            // 
            this.btnmodificar.Image = ((System.Drawing.Image)(resources.GetObject("btnmodificar.Image")));
            this.btnmodificar.Location = new System.Drawing.Point(580, 38);
            this.btnmodificar.Name = "btnmodificar";
            this.btnmodificar.Size = new System.Drawing.Size(82, 23);
            this.btnmodificar.TabIndex = 114;
            this.btnmodificar.Text = "Modificar";
            this.btnmodificar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnmodificar.UseVisualStyleBackColor = true;
            this.btnmodificar.Click += new System.EventHandler(this.btnmodificar_Click);
            // 
            // btnnuevo
            // 
            this.btnnuevo.Image = ((System.Drawing.Image)(resources.GetObject("btnnuevo.Image")));
            this.btnnuevo.Location = new System.Drawing.Point(580, 11);
            this.btnnuevo.Name = "btnnuevo";
            this.btnnuevo.Size = new System.Drawing.Size(82, 23);
            this.btnnuevo.TabIndex = 113;
            this.btnnuevo.Text = "Nuevo";
            this.btnnuevo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnnuevo.UseVisualStyleBackColor = true;
            this.btnnuevo.Click += new System.EventHandler(this.btnnuevo_Click);
            // 
            // btncancelar
            // 
            this.btncancelar.Image = ((System.Drawing.Image)(resources.GetObject("btncancelar.Image")));
            this.btncancelar.Location = new System.Drawing.Point(583, 670);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(82, 23);
            this.btncancelar.TabIndex = 117;
            this.btncancelar.Text = "Cancelar";
            this.btncancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btncancelar.UseVisualStyleBackColor = true;
            this.btncancelar.Click += new System.EventHandler(this.btncancelar_Click);
            // 
            // btnaceptar
            // 
            this.btnaceptar.Image = ((System.Drawing.Image)(resources.GetObject("btnaceptar.Image")));
            this.btnaceptar.Location = new System.Drawing.Point(485, 670);
            this.btnaceptar.Name = "btnaceptar";
            this.btnaceptar.Size = new System.Drawing.Size(82, 23);
            this.btnaceptar.TabIndex = 116;
            this.btnaceptar.Text = "Aceptar";
            this.btnaceptar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
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
            this.Dtgconten.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Dtgconten.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.Dtgconten.BackgroundColor = System.Drawing.SystemColors.Control;
            this.Dtgconten.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Dtgconten.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.Dtgconten.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Franklin Gothic Book", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Dtgconten.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.Dtgconten.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.Dtgconten.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cuenta,
            this.descripcion,
            this.debehaber});
            this.Dtgconten.GridColor = System.Drawing.SystemColors.Highlight;
            this.Dtgconten.Location = new System.Drawing.Point(13, 130);
            this.Dtgconten.MultiSelect = false;
            this.Dtgconten.Name = "Dtgconten";
            this.Dtgconten.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Dtgconten.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.Dtgconten.RowHeadersVisible = false;
            this.Dtgconten.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Franklin Gothic Book", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dtgconten.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.Dtgconten.RowTemplate.Height = 16;
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
            this.descripcion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.descripcion.HeaderText = "DESCRIPCIÓN CUENTA CONTABLE";
            this.descripcion.Name = "descripcion";
            this.descripcion.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // debehaber
            // 
            this.debehaber.HeaderText = "DEBE/HABER";
            this.debehaber.MinimumWidth = 80;
            this.debehaber.Name = "debehaber";
            this.debehaber.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.debehaber.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // btnmas
            // 
            this.btnmas.Image = ((System.Drawing.Image)(resources.GetObject("btnmas.Image")));
            this.btnmas.Location = new System.Drawing.Point(579, 103);
            this.btnmas.Name = "btnmas";
            this.btnmas.Size = new System.Drawing.Size(82, 23);
            this.btnmas.TabIndex = 115;
            this.btnmas.Text = "Cuentas";
            this.btnmas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
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
            this.btnlimpiar.BackColor = System.Drawing.Color.White;
            this.btnlimpiar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnlimpiar.BackgroundImage")));
            this.btnlimpiar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnlimpiar.Cursor = System.Windows.Forms.Cursors.Cross;
            this.btnlimpiar.FlatAppearance.BorderSize = 0;
            this.btnlimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnlimpiar.Font = new System.Drawing.Font("Webdings", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(3)));
            this.btnlimpiar.Location = new System.Drawing.Point(90, 354);
            this.btnlimpiar.Name = "btnlimpiar";
            this.btnlimpiar.Size = new System.Drawing.Size(20, 21);
            this.btnlimpiar.TabIndex = 137;
            this.btnlimpiar.UseVisualStyleBackColor = false;
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
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.WhiteSmoke;
            this.dtgbusca.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dtgbusca.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dtgbusca.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dtgbusca.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dtgbusca.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dtgbusca.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Franklin Gothic Book", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgbusca.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dtgbusca.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgbusca.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codx,
            this.Ejerciciox,
            this.opx,
            this.operacionx,
            this.csx,
            this.suboperacionx,
            this.ccx,
            this.cuentax,
            this.partex,
            this.estadox});
            this.dtgbusca.Cursor = System.Windows.Forms.Cursors.Default;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgbusca.DefaultCellStyle = dataGridViewCellStyle6;
            this.dtgbusca.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dtgbusca.Location = new System.Drawing.Point(18, 410);
            this.dtgbusca.MultiSelect = false;
            this.dtgbusca.Name = "dtgbusca";
            this.dtgbusca.ReadOnly = true;
            this.dtgbusca.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgbusca.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dtgbusca.RowHeadersVisible = false;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Franklin Gothic Book", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtgbusca.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.dtgbusca.RowTemplate.Height = 16;
            this.dtgbusca.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgbusca.Size = new System.Drawing.Size(647, 254);
            this.dtgbusca.TabIndex = 134;
            this.dtgbusca.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgbusca_CellContentClick);
            this.dtgbusca.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgbusca_RowEnter);
            this.dtgbusca.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dtgbusca_KeyDown);
            // 
            // codx
            // 
            this.codx.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCellsExceptHeader;
            this.codx.DataPropertyName = "cod";
            this.codx.HeaderText = "Cod";
            this.codx.MinimumWidth = 30;
            this.codx.Name = "codx";
            this.codx.ReadOnly = true;
            this.codx.Width = 30;
            // 
            // Ejerciciox
            // 
            this.Ejerciciox.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCellsExceptHeader;
            this.Ejerciciox.DataPropertyName = "ejercicio";
            this.Ejerciciox.HeaderText = "Ejercicio";
            this.Ejerciciox.MinimumWidth = 55;
            this.Ejerciciox.Name = "Ejerciciox";
            this.Ejerciciox.ReadOnly = true;
            this.Ejerciciox.Width = 55;
            // 
            // opx
            // 
            this.opx.DataPropertyName = "op";
            this.opx.HeaderText = "op";
            this.opx.Name = "opx";
            this.opx.ReadOnly = true;
            this.opx.Visible = false;
            this.opx.Width = 44;
            // 
            // operacionx
            // 
            this.operacionx.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.operacionx.DataPropertyName = "operacion";
            this.operacionx.HeaderText = "Operación";
            this.operacionx.Name = "operacionx";
            this.operacionx.ReadOnly = true;
            this.operacionx.Width = 81;
            // 
            // csx
            // 
            this.csx.DataPropertyName = "cs";
            this.csx.HeaderText = "cs";
            this.csx.Name = "csx";
            this.csx.ReadOnly = true;
            this.csx.Visible = false;
            this.csx.Width = 42;
            // 
            // suboperacionx
            // 
            this.suboperacionx.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.suboperacionx.DataPropertyName = "suboperacion";
            this.suboperacionx.HeaderText = "SubOperación";
            this.suboperacionx.Name = "suboperacionx";
            this.suboperacionx.ReadOnly = true;
            this.suboperacionx.Width = 99;
            // 
            // ccx
            // 
            this.ccx.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.ccx.DataPropertyName = "cc";
            this.ccx.HeaderText = "Cuenta";
            this.ccx.Name = "ccx";
            this.ccx.ReadOnly = true;
            this.ccx.Width = 65;
            // 
            // cuentax
            // 
            this.cuentax.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cuentax.DataPropertyName = "cuenta";
            this.cuentax.HeaderText = "Cuenta";
            this.cuentax.MinimumWidth = 80;
            this.cuentax.Name = "cuentax";
            this.cuentax.ReadOnly = true;
            // 
            // partex
            // 
            this.partex.DataPropertyName = "parte";
            this.partex.HeaderText = "Parte";
            this.partex.Name = "partex";
            this.partex.ReadOnly = true;
            this.partex.Visible = false;
            this.partex.Width = 57;
            // 
            // estadox
            // 
            this.estadox.DataPropertyName = "estado";
            this.estadox.HeaderText = "estado";
            this.estadox.Name = "estadox";
            this.estadox.ReadOnly = true;
            this.estadox.Visible = false;
            this.estadox.Width = 64;
            // 
            // lblmsg2
            // 
            this.lblmsg2.AutoSize = true;
            this.lblmsg2.Location = new System.Drawing.Point(15, 675);
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
            this.ClientSize = new System.Drawing.Size(673, 698);
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
            this.MaximumSize = new System.Drawing.Size(689, 737);
            this.MinimumSize = new System.Drawing.Size(689, 737);
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
        private System.Windows.Forms.DataGridViewTextBoxColumn cuenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcion;
        private System.Windows.Forms.DataGridViewComboBoxColumn debehaber;
        private System.Windows.Forms.DataGridViewTextBoxColumn codx;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ejerciciox;
        private System.Windows.Forms.DataGridViewTextBoxColumn opx;
        private System.Windows.Forms.DataGridViewTextBoxColumn operacionx;
        private System.Windows.Forms.DataGridViewTextBoxColumn csx;
        private System.Windows.Forms.DataGridViewTextBoxColumn suboperacionx;
        private System.Windows.Forms.DataGridViewTextBoxColumn ccx;
        private System.Windows.Forms.DataGridViewTextBoxColumn cuentax;
        private System.Windows.Forms.DataGridViewTextBoxColumn partex;
        private System.Windows.Forms.DataGridViewTextBoxColumn estadox;
    }
}