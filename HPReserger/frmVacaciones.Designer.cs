namespace HPReserger
{
    partial class frmVacaciones
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtNumeroDocumento = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtApellidoPaterno = new System.Windows.Forms.TextBox();
            this.txtApellidoMaterno = new System.Windows.Forms.TextBox();
            this.txtNombres = new System.Windows.Forms.TextBox();
            this.cboTipoDocumento = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtDiasPendientes = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtDiasUtilizados = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtObservaciones = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtDias = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.dtpFin = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.dtpInicio = new System.Windows.Forms.DateTimePicker();
            this.txtFecha = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtVacaciones = new System.Windows.Forms.TextBox();
            this.btnBoletaVacaciones = new System.Windows.Forms.Button();
            this.Grid = new System.Windows.Forms.DataGridView();
            this.Registro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGOTIPO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TIPOID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NDI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DIASTRABAJADOS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FECHAINICIO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FECHAFIN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DIASVACACIONES = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ESTADO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAprobarVacaciones = new System.Windows.Forms.Button();
            this.btnSeleccionarImagen = new System.Windows.Forms.Button();
            this.pbFoto = new System.Windows.Forms.PictureBox();
            this.txtRuta = new System.Windows.Forms.TextBox();
            this.btnCompraVacaciones = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.txttipo = new System.Windows.Forms.TextBox();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Grid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFoto)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.txtNumeroDocumento);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtApellidoPaterno);
            this.groupBox2.Controls.Add(this.txtApellidoMaterno);
            this.groupBox2.Controls.Add(this.txttipo);
            this.groupBox2.Controls.Add(this.txtNombres);
            this.groupBox2.Controls.Add(this.cboTipoDocumento);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(12, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(373, 175);
            this.groupBox2.TabIndex = 70;
            this.groupBox2.TabStop = false;
            // 
            // txtNumeroDocumento
            // 
            this.txtNumeroDocumento.Location = new System.Drawing.Point(195, 46);
            this.txtNumeroDocumento.MaxLength = 14;
            this.txtNumeroDocumento.Name = "txtNumeroDocumento";
            this.txtNumeroDocumento.Size = new System.Drawing.Size(159, 20);
            this.txtNumeroDocumento.TabIndex = 78;
            this.txtNumeroDocumento.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtNumeroDocumento.TextChanged += new System.EventHandler(this.txtNumeroDocumento_TextChanged);
            this.txtNumeroDocumento.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtNumeroDocumento_KeyDown);
            this.txtNumeroDocumento.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumeroDocumento_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 49);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(179, 13);
            this.label5.TabIndex = 77;
            this.label5.Text = "Número de Documento de Identidad";
            // 
            // txtApellidoPaterno
            // 
            this.txtApellidoPaterno.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtApellidoPaterno.Location = new System.Drawing.Point(119, 75);
            this.txtApellidoPaterno.MaxLength = 30;
            this.txtApellidoPaterno.Name = "txtApellidoPaterno";
            this.txtApellidoPaterno.ReadOnly = true;
            this.txtApellidoPaterno.Size = new System.Drawing.Size(237, 20);
            this.txtApellidoPaterno.TabIndex = 76;
            // 
            // txtApellidoMaterno
            // 
            this.txtApellidoMaterno.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtApellidoMaterno.Location = new System.Drawing.Point(119, 101);
            this.txtApellidoMaterno.MaxLength = 30;
            this.txtApellidoMaterno.Name = "txtApellidoMaterno";
            this.txtApellidoMaterno.ReadOnly = true;
            this.txtApellidoMaterno.Size = new System.Drawing.Size(237, 20);
            this.txtApellidoMaterno.TabIndex = 75;
            // 
            // txtNombres
            // 
            this.txtNombres.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNombres.Location = new System.Drawing.Point(119, 127);
            this.txtNombres.MaxLength = 30;
            this.txtNombres.Name = "txtNombres";
            this.txtNombres.ReadOnly = true;
            this.txtNombres.ShortcutsEnabled = false;
            this.txtNombres.Size = new System.Drawing.Size(237, 20);
            this.txtNombres.TabIndex = 74;
            // 
            // cboTipoDocumento
            // 
            this.cboTipoDocumento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTipoDocumento.FormattingEnabled = true;
            this.cboTipoDocumento.Location = new System.Drawing.Point(195, 19);
            this.cboTipoDocumento.Name = "cboTipoDocumento";
            this.cboTipoDocumento.Size = new System.Drawing.Size(161, 21);
            this.cboTipoDocumento.TabIndex = 73;
            this.cboTipoDocumento.SelectedIndexChanged += new System.EventHandler(this.cboTipoDocumento_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 72;
            this.label4.Text = "Nombres";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 13);
            this.label3.TabIndex = 71;
            this.label3.Text = "Apellido Materno";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 70;
            this.label2.Text = "Apellido Paterno";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 13);
            this.label1.TabIndex = 69;
            this.label1.Text = "Tipo de Documento de Identidad";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtDiasPendientes);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.txtDiasUtilizados);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.txtObservaciones);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.txtDias);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.dtpFin);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.dtpInicio);
            this.groupBox1.Controls.Add(this.txtFecha);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtVacaciones);
            this.groupBox1.Location = new System.Drawing.Point(12, 177);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(373, 343);
            this.groupBox1.TabIndex = 71;
            this.groupBox1.TabStop = false;
            // 
            // txtDiasPendientes
            // 
            this.txtDiasPendientes.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDiasPendientes.Location = new System.Drawing.Point(329, 113);
            this.txtDiasPendientes.MaxLength = 30;
            this.txtDiasPendientes.Name = "txtDiasPendientes";
            this.txtDiasPendientes.ReadOnly = true;
            this.txtDiasPendientes.Size = new System.Drawing.Size(25, 20);
            this.txtDiasPendientes.TabIndex = 107;
            this.txtDiasPendientes.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtDiasPendientes.TextChanged += new System.EventHandler(this.txtDiasPendientes_TextChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(236, 113);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(85, 13);
            this.label14.TabIndex = 106;
            this.label14.Text = "Días pendientes";
            // 
            // txtDiasUtilizados
            // 
            this.txtDiasUtilizados.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDiasUtilizados.Location = new System.Drawing.Point(198, 113);
            this.txtDiasUtilizados.MaxLength = 30;
            this.txtDiasUtilizados.Name = "txtDiasUtilizados";
            this.txtDiasUtilizados.ReadOnly = true;
            this.txtDiasUtilizados.Size = new System.Drawing.Size(25, 20);
            this.txtDiasUtilizados.TabIndex = 105;
            this.txtDiasUtilizados.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(116, 113);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(76, 13);
            this.label13.TabIndex = 104;
            this.label13.Text = "Días utilizados";
            // 
            // txtObservaciones
            // 
            this.txtObservaciones.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtObservaciones.Location = new System.Drawing.Point(95, 148);
            this.txtObservaciones.MaxLength = 0;
            this.txtObservaciones.Multiline = true;
            this.txtObservaciones.Name = "txtObservaciones";
            this.txtObservaciones.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.txtObservaciones.Size = new System.Drawing.Size(261, 180);
            this.txtObservaciones.TabIndex = 103;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(10, 148);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(78, 13);
            this.label12.TabIndex = 102;
            this.label12.Text = "Observaciones";
            // 
            // txtDias
            // 
            this.txtDias.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDias.Location = new System.Drawing.Point(77, 113);
            this.txtDias.MaxLength = 30;
            this.txtDias.Name = "txtDias";
            this.txtDias.ReadOnly = true;
            this.txtDias.Size = new System.Drawing.Size(25, 20);
            this.txtDias.TabIndex = 100;
            this.txtDias.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(10, 113);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(60, 13);
            this.label11.TabIndex = 99;
            this.label11.Text = "Días a salir";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(195, 80);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(54, 13);
            this.label10.TabIndex = 98;
            this.label10.Text = "Fecha Fin";
            // 
            // dtpFin
            // 
            this.dtpFin.CalendarTrailingForeColor = System.Drawing.Color.White;
            this.dtpFin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFin.Location = new System.Drawing.Point(255, 80);
            this.dtpFin.Name = "dtpFin";
            this.dtpFin.Size = new System.Drawing.Size(90, 20);
            this.dtpFin.TabIndex = 97;
            this.dtpFin.ValueChanged += new System.EventHandler(this.dtpFin_ValueChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(10, 82);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 13);
            this.label9.TabIndex = 96;
            this.label9.Text = "Fecha Inicio";
            // 
            // dtpInicio
            // 
            this.dtpInicio.CalendarTitleBackColor = System.Drawing.Color.Yellow;
            this.dtpInicio.CalendarTrailingForeColor = System.Drawing.Color.Red;
            this.dtpInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpInicio.Location = new System.Drawing.Point(79, 80);
            this.dtpInicio.Name = "dtpInicio";
            this.dtpInicio.Size = new System.Drawing.Size(90, 20);
            this.dtpInicio.TabIndex = 95;
            this.dtpInicio.ValueChanged += new System.EventHandler(this.dtpInicio_ValueChanged);
            // 
            // txtFecha
            // 
            this.txtFecha.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtFecha.Location = new System.Drawing.Point(195, 19);
            this.txtFecha.MaxLength = 30;
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.ReadOnly = true;
            this.txtFecha.Size = new System.Drawing.Size(69, 20);
            this.txtFecha.TabIndex = 94;
            this.txtFecha.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(10, 19);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(136, 13);
            this.label8.TabIndex = 93;
            this.label8.Text = "Fecha de Inicio de Labores";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(246, 49);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(101, 13);
            this.label7.TabIndex = 92;
            this.label7.Text = "días de vacaciones";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 49);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(174, 13);
            this.label6.TabIndex = 91;
            this.label6.Text = "A la Fecha de Inicio le corresponde";
            // 
            // txtVacaciones
            // 
            this.txtVacaciones.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtVacaciones.Location = new System.Drawing.Point(195, 49);
            this.txtVacaciones.MaxLength = 2;
            this.txtVacaciones.Name = "txtVacaciones";
            this.txtVacaciones.ReadOnly = true;
            this.txtVacaciones.Size = new System.Drawing.Size(40, 20);
            this.txtVacaciones.TabIndex = 90;
            this.txtVacaciones.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnBoletaVacaciones
            // 
            this.btnBoletaVacaciones.Location = new System.Drawing.Point(401, 528);
            this.btnBoletaVacaciones.Name = "btnBoletaVacaciones";
            this.btnBoletaVacaciones.Size = new System.Drawing.Size(172, 23);
            this.btnBoletaVacaciones.TabIndex = 101;
            this.btnBoletaVacaciones.Text = "Generar Boleta de Vacaciones";
            this.btnBoletaVacaciones.UseVisualStyleBackColor = true;
            this.btnBoletaVacaciones.Click += new System.EventHandler(this.btnBoletaVacaciones_Click);
            // 
            // Grid
            // 
            this.Grid.AllowUserToAddRows = false;
            this.Grid.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Grid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.Grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Registro,
            this.CODIGOTIPO,
            this.TIPOID,
            this.NDI,
            this.DIASTRABAJADOS,
            this.FECHAINICIO,
            this.FECHAFIN,
            this.DIASVACACIONES,
            this.ESTADO});
            this.Grid.Location = new System.Drawing.Point(401, 8);
            this.Grid.Name = "Grid";
            this.Grid.ReadOnly = true;
            this.Grid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.Grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Grid.Size = new System.Drawing.Size(662, 512);
            this.Grid.TabIndex = 72;
            this.Grid.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.Grid_RowEnter);
            // 
            // Registro
            // 
            this.Registro.DataPropertyName = "REGISTRO";
            this.Registro.HeaderText = "REGISTRO";
            this.Registro.Name = "Registro";
            this.Registro.ReadOnly = true;
            this.Registro.Visible = false;
            // 
            // CODIGOTIPO
            // 
            this.CODIGOTIPO.DataPropertyName = "CODIGOTIPO";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.CODIGOTIPO.DefaultCellStyle = dataGridViewCellStyle2;
            this.CODIGOTIPO.HeaderText = "CODIGOTIPO";
            this.CODIGOTIPO.Name = "CODIGOTIPO";
            this.CODIGOTIPO.ReadOnly = true;
            this.CODIGOTIPO.Visible = false;
            // 
            // TIPOID
            // 
            this.TIPOID.DataPropertyName = "TIPOID";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TIPOID.DefaultCellStyle = dataGridViewCellStyle3;
            this.TIPOID.HeaderText = "TIPO ID";
            this.TIPOID.Name = "TIPOID";
            this.TIPOID.ReadOnly = true;
            this.TIPOID.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.TIPOID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.TIPOID.Width = 150;
            // 
            // NDI
            // 
            this.NDI.DataPropertyName = "NID";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.NDI.DefaultCellStyle = dataGridViewCellStyle4;
            this.NDI.HeaderText = "Nº ID";
            this.NDI.Name = "NDI";
            this.NDI.ReadOnly = true;
            this.NDI.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.NDI.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.NDI.Width = 80;
            // 
            // DIASTRABAJADOS
            // 
            this.DIASTRABAJADOS.DataPropertyName = "DIASTRABAJADOS";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DIASTRABAJADOS.DefaultCellStyle = dataGridViewCellStyle5;
            this.DIASTRABAJADOS.HeaderText = "DIAS TRAB.";
            this.DIASTRABAJADOS.Name = "DIASTRABAJADOS";
            this.DIASTRABAJADOS.ReadOnly = true;
            this.DIASTRABAJADOS.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.DIASTRABAJADOS.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.DIASTRABAJADOS.Width = 60;
            // 
            // FECHAINICIO
            // 
            this.FECHAINICIO.DataPropertyName = "FECHAINICIO";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.FECHAINICIO.DefaultCellStyle = dataGridViewCellStyle6;
            this.FECHAINICIO.HeaderText = "FECHA INI";
            this.FECHAINICIO.Name = "FECHAINICIO";
            this.FECHAINICIO.ReadOnly = true;
            this.FECHAINICIO.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.FECHAINICIO.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.FECHAINICIO.Width = 80;
            // 
            // FECHAFIN
            // 
            this.FECHAFIN.DataPropertyName = "FECHAFIN";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black;
            this.FECHAFIN.DefaultCellStyle = dataGridViewCellStyle7;
            this.FECHAFIN.HeaderText = "FECHA FIN";
            this.FECHAFIN.Name = "FECHAFIN";
            this.FECHAFIN.ReadOnly = true;
            this.FECHAFIN.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.FECHAFIN.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.FECHAFIN.Width = 80;
            // 
            // DIASVACACIONES
            // 
            this.DIASVACACIONES.DataPropertyName = "DIASVACACIONES";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.DIASVACACIONES.DefaultCellStyle = dataGridViewCellStyle8;
            this.DIASVACACIONES.HeaderText = "DIAS VAC.";
            this.DIASVACACIONES.Name = "DIASVACACIONES";
            this.DIASVACACIONES.ReadOnly = true;
            this.DIASVACACIONES.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.DIASVACACIONES.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.DIASVACACIONES.Width = 60;
            // 
            // ESTADO
            // 
            this.ESTADO.DataPropertyName = "ESTADO";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.ESTADO.DefaultCellStyle = dataGridViewCellStyle9;
            this.ESTADO.HeaderText = "ESTADO";
            this.ESTADO.Name = "ESTADO";
            this.ESTADO.ReadOnly = true;
            this.ESTADO.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ESTADO.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ESTADO.Width = 80;
            // 
            // btnAprobarVacaciones
            // 
            this.btnAprobarVacaciones.Location = new System.Drawing.Point(745, 528);
            this.btnAprobarVacaciones.Name = "btnAprobarVacaciones";
            this.btnAprobarVacaciones.Size = new System.Drawing.Size(172, 23);
            this.btnAprobarVacaciones.TabIndex = 102;
            this.btnAprobarVacaciones.Text = "Aprobar Vacaciones";
            this.btnAprobarVacaciones.UseVisualStyleBackColor = true;
            this.btnAprobarVacaciones.Click += new System.EventHandler(this.btnAprobarVacaciones_Click);
            // 
            // btnSeleccionarImagen
            // 
            this.btnSeleccionarImagen.Location = new System.Drawing.Point(1078, 528);
            this.btnSeleccionarImagen.Name = "btnSeleccionarImagen";
            this.btnSeleccionarImagen.Size = new System.Drawing.Size(267, 23);
            this.btnSeleccionarImagen.TabIndex = 103;
            this.btnSeleccionarImagen.Text = "Seleccionar Imagen de Boleta deVacaciones";
            this.btnSeleccionarImagen.UseVisualStyleBackColor = true;
            this.btnSeleccionarImagen.Click += new System.EventHandler(this.btnSeleccionarImagen_Click);
            // 
            // pbFoto
            // 
            this.pbFoto.Location = new System.Drawing.Point(1078, 8);
            this.pbFoto.Name = "pbFoto";
            this.pbFoto.Size = new System.Drawing.Size(466, 512);
            this.pbFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbFoto.TabIndex = 104;
            this.pbFoto.TabStop = false;
            // 
            // txtRuta
            // 
            this.txtRuta.Location = new System.Drawing.Point(1367, 530);
            this.txtRuta.Name = "txtRuta";
            this.txtRuta.Size = new System.Drawing.Size(177, 20);
            this.txtRuta.TabIndex = 105;
            this.txtRuta.Visible = false;
            // 
            // btnCompraVacaciones
            // 
            this.btnCompraVacaciones.Location = new System.Drawing.Point(12, 527);
            this.btnCompraVacaciones.Name = "btnCompraVacaciones";
            this.btnCompraVacaciones.Size = new System.Drawing.Size(172, 23);
            this.btnCompraVacaciones.TabIndex = 106;
            this.btnCompraVacaciones.Text = "Compra de Vacaciones";
            this.btnCompraVacaciones.UseVisualStyleBackColor = true;
            this.btnCompraVacaciones.Click += new System.EventHandler(this.btnCompraVacaciones_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(10, 152);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(91, 13);
            this.label15.TabIndex = 79;
            this.label15.Text = "Tipo Contratación";
            // 
            // txttipo
            // 
            this.txttipo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txttipo.Location = new System.Drawing.Point(119, 149);
            this.txttipo.MaxLength = 30;
            this.txttipo.Name = "txttipo";
            this.txttipo.ReadOnly = true;
            this.txttipo.ShortcutsEnabled = false;
            this.txttipo.Size = new System.Drawing.Size(237, 20);
            this.txttipo.TabIndex = 74;
            // 
            // frmVacaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1552, 563);
            this.Controls.Add(this.btnCompraVacaciones);
            this.Controls.Add(this.txtRuta);
            this.Controls.Add(this.pbFoto);
            this.Controls.Add(this.btnSeleccionarImagen);
            this.Controls.Add(this.btnAprobarVacaciones);
            this.Controls.Add(this.Grid);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnBoletaVacaciones);
            this.Controls.Add(this.groupBox2);
            this.MaximizeBox = false;
            this.Name = "frmVacaciones";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "  Vacaciones";
            this.Load += new System.EventHandler(this.frmVacaciones_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Grid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtNumeroDocumento;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtApellidoPaterno;
        private System.Windows.Forms.TextBox txtApellidoMaterno;
        private System.Windows.Forms.TextBox txtNombres;
        private System.Windows.Forms.ComboBox cboTipoDocumento;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtDias;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker dtpFin;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dtpInicio;
        private System.Windows.Forms.TextBox txtFecha;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtVacaciones;
        private System.Windows.Forms.Button btnBoletaVacaciones;
        private System.Windows.Forms.DataGridView Grid;
        private System.Windows.Forms.TextBox txtObservaciones;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnAprobarVacaciones;
        private System.Windows.Forms.Button btnSeleccionarImagen;
        private System.Windows.Forms.PictureBox pbFoto;
        private System.Windows.Forms.TextBox txtRuta;
        private System.Windows.Forms.TextBox txtDiasPendientes;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtDiasUtilizados;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DataGridViewTextBoxColumn Registro;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGOTIPO;
        private System.Windows.Forms.DataGridViewTextBoxColumn TIPOID;
        private System.Windows.Forms.DataGridViewTextBoxColumn NDI;
        private System.Windows.Forms.DataGridViewTextBoxColumn DIASTRABAJADOS;
        private System.Windows.Forms.DataGridViewTextBoxColumn FECHAINICIO;
        private System.Windows.Forms.DataGridViewTextBoxColumn FECHAFIN;
        private System.Windows.Forms.DataGridViewTextBoxColumn DIASVACACIONES;
        private System.Windows.Forms.DataGridViewTextBoxColumn ESTADO;
        private System.Windows.Forms.Button btnCompraVacaciones;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txttipo;
    }
}