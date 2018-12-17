using HpResergerUserControls;

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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.label5 = new System.Windows.Forms.Label();
            this.btneliminar = new System.Windows.Forms.Button();
            this.btnmodificar = new System.Windows.Forms.Button();
            this.btnnuevo = new System.Windows.Forms.Button();
            this.btncancelar = new System.Windows.Forms.Button();
            this.btnaceptar = new System.Windows.Forms.Button();
            this.lblmsg = new System.Windows.Forms.Label();
            this.tipmsg = new System.Windows.Forms.ToolTip(this.components);
            this.Dtgconten = new HpResergerUserControls.Dtgconten();
            this.cuenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.debehaber = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.btnmas = new System.Windows.Forms.Button();
            this.dtgayuda = new HpResergerUserControls.Dtgconten();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.dtgbusca = new HpResergerUserControls.Dtgconten();
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
            this.solicitax = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblmsg2 = new System.Windows.Forms.Label();
            this.dtgayuda2 = new HpResergerUserControls.Dtgconten();
            this.cbosolicitar = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.Txtbusca = new HpResergerUserControls.txtBuscar();
            this.separadorOre1 = new HpResergerUserControls.SeparadorOre();
            this.separadorOre2 = new HpResergerUserControls.SeparadorOre();
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
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(43, 16);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(52, 13);
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
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(182, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
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
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(309, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 13);
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
            this.txtcodigo.Size = new System.Drawing.Size(176, 20);
            this.txtcodigo.TabIndex = 106;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(34, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 108;
            this.label3.Text = "Operación:";
            // 
            // cbooperacion
            // 
            this.cbooperacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbooperacion.Location = new System.Drawing.Point(99, 36);
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
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 13);
            this.label4.TabIndex = 110;
            this.label4.Text = "Sub Operación:";
            // 
            // cbosuboperacion
            // 
            this.cbosuboperacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbosuboperacion.FormattingEnabled = true;
            this.cbosuboperacion.Location = new System.Drawing.Point(99, 61);
            this.cbosuboperacion.Name = "cbosuboperacion";
            this.cbosuboperacion.Size = new System.Drawing.Size(297, 21);
            this.cbosuboperacion.TabIndex = 109;
            this.cbosuboperacion.SelectedIndexChanged += new System.EventHandler(this.cbosuboperacion_SelectedIndexChanged);
            this.cbosuboperacion.Click += new System.EventHandler(this.cbosuboperacion_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 98);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 13);
            this.label5.TabIndex = 112;
            this.label5.Text = "Dinámica Contable:";
            // 
            // btneliminar
            // 
            this.btneliminar.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btneliminar.Image = ((System.Drawing.Image)(resources.GetObject("btneliminar.Image")));
            this.btneliminar.Location = new System.Drawing.Point(584, 60);
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
            this.btnmodificar.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmodificar.Image = ((System.Drawing.Image)(resources.GetObject("btnmodificar.Image")));
            this.btnmodificar.Location = new System.Drawing.Point(584, 35);
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
            this.btnnuevo.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnnuevo.Image = ((System.Drawing.Image)(resources.GetObject("btnnuevo.Image")));
            this.btnnuevo.Location = new System.Drawing.Point(584, 11);
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
            this.btncancelar.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.btnaceptar.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnaceptar.Image = ((System.Drawing.Image)(resources.GetObject("btnaceptar.Image")));
            this.btnaceptar.Location = new System.Drawing.Point(496, 670);
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
            this.lblmsg.BackColor = System.Drawing.Color.Transparent;
            this.lblmsg.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmsg.Location = new System.Drawing.Point(12, 324);
            this.lblmsg.Name = "lblmsg";
            this.lblmsg.Size = new System.Drawing.Size(101, 13);
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
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(230)))), ((int)(((byte)(241)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(191)))), ((int)(((byte)(231)))));
            this.Dtgconten.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.Dtgconten.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Dtgconten.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Dtgconten.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(218)))), ((int)(((byte)(231)))));
            this.Dtgconten.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Dtgconten.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.Dtgconten.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(129)))), ((int)(((byte)(189)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DeepSkyBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Dtgconten.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.Dtgconten.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.Dtgconten.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cuenta,
            this.descripcion,
            this.debehaber});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(207)))), ((int)(((byte)(241)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Dtgconten.DefaultCellStyle = dataGridViewCellStyle3;
            this.Dtgconten.EnableHeadersVisualStyles = false;
            this.Dtgconten.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(179)))), ((int)(((byte)(215)))));
            this.Dtgconten.Location = new System.Drawing.Point(13, 115);
            this.Dtgconten.MultiSelect = false;
            this.Dtgconten.Name = "Dtgconten";
            this.Dtgconten.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Dtgconten.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.Dtgconten.RowHeadersVisible = false;
            this.Dtgconten.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.Dtgconten.RowTemplate.Height = 16;
            this.Dtgconten.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Dtgconten.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Dtgconten.ShowRowErrors = false;
            this.Dtgconten.Size = new System.Drawing.Size(652, 206);
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
            this.cuenta.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.cuenta.HeaderText = "Cuenta Contable";
            this.cuenta.MinimumWidth = 100;
            this.cuenta.Name = "cuenta";
            this.cuenta.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.cuenta.Width = 119;
            // 
            // descripcion
            // 
            this.descripcion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.descripcion.HeaderText = "Descripción Contable";
            this.descripcion.Name = "descripcion";
            this.descripcion.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // debehaber
            // 
            this.debehaber.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.debehaber.HeaderText = "Debe/Haber";
            this.debehaber.MinimumWidth = 80;
            this.debehaber.Name = "debehaber";
            this.debehaber.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.debehaber.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.debehaber.Width = 94;
            // 
            // btnmas
            // 
            this.btnmas.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmas.Image = ((System.Drawing.Image)(resources.GetObject("btnmas.Image")));
            this.btnmas.Location = new System.Drawing.Point(583, 91);
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
            this.dtgayuda.AllowUserToOrderColumns = true;
            this.dtgayuda.AllowUserToResizeColumns = false;
            this.dtgayuda.AllowUserToResizeRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(230)))), ((int)(((byte)(241)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(191)))), ((int)(((byte)(231)))));
            this.dtgayuda.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dtgayuda.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgayuda.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgayuda.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(218)))), ((int)(((byte)(231)))));
            this.dtgayuda.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgayuda.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dtgayuda.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(129)))), ((int)(((byte)(189)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.DeepSkyBlue;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgayuda.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dtgayuda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(207)))), ((int)(((byte)(241)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgayuda.DefaultCellStyle = dataGridViewCellStyle6;
            this.dtgayuda.EnableHeadersVisualStyles = false;
            this.dtgayuda.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(179)))), ((int)(((byte)(215)))));
            this.dtgayuda.Location = new System.Drawing.Point(695, 12);
            this.dtgayuda.Name = "dtgayuda";
            this.dtgayuda.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dtgayuda.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dtgayuda.RowHeadersVisible = false;
            this.dtgayuda.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dtgayuda.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgayuda.Size = new System.Drawing.Size(456, 196);
            this.dtgayuda.TabIndex = 132;
            this.dtgayuda.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.radioButton4);
            this.groupBox1.Controls.Add(this.radioButton5);
            this.groupBox1.Controls.Add(this.radioButton3);
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 369);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(653, 28);
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
            this.radioButton4.Size = new System.Drawing.Size(88, 20);
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
            this.radioButton5.Size = new System.Drawing.Size(70, 20);
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
            this.radioButton3.Size = new System.Drawing.Size(110, 20);
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
            this.radioButton2.Size = new System.Drawing.Size(78, 20);
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
            this.radioButton1.Size = new System.Drawing.Size(70, 20);
            this.radioButton1.TabIndex = 130;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Código";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // dtgbusca
            // 
            this.dtgbusca.AllowUserToAddRows = false;
            this.dtgbusca.AllowUserToDeleteRows = false;
            this.dtgbusca.AllowUserToResizeColumns = false;
            this.dtgbusca.AllowUserToResizeRows = false;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(230)))), ((int)(((byte)(241)))));
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(191)))), ((int)(((byte)(231)))));
            this.dtgbusca.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.dtgbusca.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgbusca.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dtgbusca.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(218)))), ((int)(((byte)(231)))));
            this.dtgbusca.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dtgbusca.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dtgbusca.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(129)))), ((int)(((byte)(189)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.DeepSkyBlue;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgbusca.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dtgbusca.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
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
            this.estadox,
            this.solicitax});
            this.dtgbusca.Cursor = System.Windows.Forms.Cursors.Default;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(207)))), ((int)(((byte)(241)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgbusca.DefaultCellStyle = dataGridViewCellStyle9;
            this.dtgbusca.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dtgbusca.EnableHeadersVisualStyles = false;
            this.dtgbusca.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(179)))), ((int)(((byte)(215)))));
            this.dtgbusca.Location = new System.Drawing.Point(12, 399);
            this.dtgbusca.MultiSelect = false;
            this.dtgbusca.Name = "dtgbusca";
            this.dtgbusca.ReadOnly = true;
            this.dtgbusca.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dtgbusca.RowHeadersVisible = false;
            this.dtgbusca.RowTemplate.Height = 16;
            this.dtgbusca.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgbusca.Size = new System.Drawing.Size(653, 265);
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
            this.operacionx.Width = 85;
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
            this.suboperacionx.Width = 105;
            // 
            // ccx
            // 
            this.ccx.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.ccx.DataPropertyName = "cc";
            this.ccx.HeaderText = "Cuenta";
            this.ccx.Name = "ccx";
            this.ccx.ReadOnly = true;
            this.ccx.Width = 68;
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
            // solicitax
            // 
            this.solicitax.DataPropertyName = "solicita";
            this.solicitax.HeaderText = "Solicita";
            this.solicitax.Name = "solicitax";
            this.solicitax.ReadOnly = true;
            this.solicitax.Visible = false;
            this.solicitax.Width = 67;
            // 
            // lblmsg2
            // 
            this.lblmsg2.AutoSize = true;
            this.lblmsg2.BackColor = System.Drawing.Color.Transparent;
            this.lblmsg2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmsg2.Location = new System.Drawing.Point(15, 675);
            this.lblmsg2.Name = "lblmsg2";
            this.lblmsg2.Size = new System.Drawing.Size(101, 13);
            this.lblmsg2.TabIndex = 130;
            this.lblmsg2.Text = "Total de Registros:";
            this.lblmsg2.Click += new System.EventHandler(this.lblmsg2_Click);
            // 
            // dtgayuda2
            // 
            this.dtgayuda2.AllowUserToAddRows = false;
            this.dtgayuda2.AllowUserToDeleteRows = false;
            this.dtgayuda2.AllowUserToOrderColumns = true;
            this.dtgayuda2.AllowUserToResizeColumns = false;
            this.dtgayuda2.AllowUserToResizeRows = false;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(230)))), ((int)(((byte)(241)))));
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(191)))), ((int)(((byte)(231)))));
            this.dtgayuda2.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle10;
            this.dtgayuda2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgayuda2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgayuda2.BackgroundColor = System.Drawing.SystemColors.HighlightText;
            this.dtgayuda2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgayuda2.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dtgayuda2.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(129)))), ((int)(((byte)(189)))));
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.DeepSkyBlue;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgayuda2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.dtgayuda2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(207)))), ((int)(((byte)(241)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgayuda2.DefaultCellStyle = dataGridViewCellStyle12;
            this.dtgayuda2.EnableHeadersVisualStyles = false;
            this.dtgayuda2.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(179)))), ((int)(((byte)(215)))));
            this.dtgayuda2.Location = new System.Drawing.Point(695, 368);
            this.dtgayuda2.Name = "dtgayuda2";
            this.dtgayuda2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dtgayuda2.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dtgayuda2.RowHeadersVisible = false;
            this.dtgayuda2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dtgayuda2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgayuda2.Size = new System.Drawing.Size(679, 196);
            this.dtgayuda2.TabIndex = 139;
            this.dtgayuda2.Visible = false;
            this.dtgayuda2.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgayuda2_RowEnter);
            // 
            // cbosolicitar
            // 
            this.cbosolicitar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbosolicitar.FormattingEnabled = true;
            this.cbosolicitar.Location = new System.Drawing.Point(494, 36);
            this.cbosolicitar.Name = "cbosolicitar";
            this.cbosolicitar.Size = new System.Drawing.Size(84, 21);
            this.cbosolicitar.TabIndex = 141;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(402, 40);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(92, 13);
            this.label9.TabIndex = 140;
            this.label9.Text = "Solicitar Detalle?";
            // 
            // Txtbusca
            // 
            this.Txtbusca.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Txtbusca.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(218)))), ((int)(((byte)(231)))));
            this.Txtbusca.FondoBoton = ((System.Drawing.Image)(resources.GetObject("Txtbusca.FondoBoton")));
            this.Txtbusca.ImgBotonCerrar = null;
            this.Txtbusca.Location = new System.Drawing.Point(12, 349);
            this.Txtbusca.Name = "Txtbusca";
            this.Txtbusca.Size = new System.Drawing.Size(653, 22);
            this.Txtbusca.TabIndex = 142;
            this.Txtbusca.BuscarClick += new System.EventHandler(this.Txtbusca_TextChanged);
            this.Txtbusca.ClickLimpiarboton += new System.EventHandler(this.btnlimpiar_Click);
            this.Txtbusca.BuscarTextChanged += new System.EventHandler(this.Txtbusca_TextChanged);
            // 
            // separadorOre1
            // 
            this.separadorOre1.Location = new System.Drawing.Point(0, 85);
            this.separadorOre1.MaximumSize = new System.Drawing.Size(2000, 2);
            this.separadorOre1.MinimumSize = new System.Drawing.Size(0, 2);
            this.separadorOre1.Name = "separadorOre1";
            this.separadorOre1.Size = new System.Drawing.Size(692, 2);
            this.separadorOre1.TabIndex = 143;
            // 
            // separadorOre2
            // 
            this.separadorOre2.Location = new System.Drawing.Point(0, 340);
            this.separadorOre2.MaximumSize = new System.Drawing.Size(2000, 2);
            this.separadorOre2.MinimumSize = new System.Drawing.Size(0, 2);
            this.separadorOre2.Name = "separadorOre2";
            this.separadorOre2.Size = new System.Drawing.Size(692, 2);
            this.separadorOre2.TabIndex = 143;
            // 
            // frmdinamicaContable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(673, 698);
            this.Controls.Add(this.separadorOre2);
            this.Controls.Add(this.separadorOre1);
            this.Controls.Add(this.cbosolicitar);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.dtgayuda2);
            this.Controls.Add(this.groupBox1);
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
            this.Controls.Add(this.dtgbusca);
            this.Controls.Add(this.Txtbusca);
            this.MaximumSize = new System.Drawing.Size(689, 737);
            this.MinimumSize = new System.Drawing.Size(689, 737);
            this.Name = "frmdinamicaContable";
            this.Nombre = "Dinámica Cuenta Contable";
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
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btneliminar;
        private System.Windows.Forms.Button btnmodificar;
        private System.Windows.Forms.Button btnnuevo;
        private System.Windows.Forms.Button btncancelar;
        private System.Windows.Forms.Button btnaceptar;
        private System.Windows.Forms.Label lblmsg;
        private System.Windows.Forms.ToolTip tipmsg;
        private Dtgconten Dtgconten;
        private System.Windows.Forms.Button btnmas;
        private Dtgconten dtgayuda;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton5;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private Dtgconten dtgbusca;
        private System.Windows.Forms.Label lblmsg2;
        private Dtgconten dtgayuda2;
        public System.Windows.Forms.TextBox txtcodigo;
        private System.Windows.Forms.ComboBox cbosolicitar;
        private System.Windows.Forms.Label label9;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn solicitax;
        public txtBuscar Txtbusca;
        private SeparadorOre separadorOre1;
        private SeparadorOre separadorOre2;
        private System.Windows.Forms.DataGridViewTextBoxColumn cuenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcion;
        private System.Windows.Forms.DataGridViewComboBoxColumn debehaber;
    }
}