using HpResergerUserControls;

namespace HPReserger
{
    partial class frmFaltas
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFaltas));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtNumeroDocumento = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtApellidoPaterno = new System.Windows.Forms.TextBox();
            this.txtApellidoMaterno = new System.Windows.Forms.TextBox();
            this.lblmensajito = new System.Windows.Forms.TextBox();
            this.txtNombres = new System.Windows.Forms.TextBox();
            this.cboTipoDocumento = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpInicio = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.dtpFin = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtDias = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtObservaciones = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pbFaltas = new System.Windows.Forms.PictureBox();
            this.chkfaltas = new System.Windows.Forms.CheckBox();
            this.Grid = new HpResergerUserControls.Dtgconten();
            this.Registro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGOTIPO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TIPOID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NDI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FECHAINICIO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FECHAFIN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DIASFALTAS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OBSERVACIONES = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnRegistrarFalta = new System.Windows.Forms.Button();
            this.btnAdjuntarSustento = new System.Windows.Forms.Button();
            this.txtRuta = new System.Windows.Forms.TextBox();
            this.pbFoto = new System.Windows.Forms.PictureBox();
            this.btndescargar = new System.Windows.Forms.Button();
            this.cachedrptConvenioPracticasPreprofesional1 = new HPReserger.CachedrptConvenioPracticasPreprofesional();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbFaltas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Grid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFoto)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.txtNumeroDocumento);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtApellidoPaterno);
            this.groupBox2.Controls.Add(this.txtApellidoMaterno);
            this.groupBox2.Controls.Add(this.lblmensajito);
            this.groupBox2.Controls.Add(this.txtNombres);
            this.groupBox2.Controls.Add(this.cboTipoDocumento);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(16, 7);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(373, 175);
            this.groupBox2.TabIndex = 71;
            this.groupBox2.TabStop = false;
            // 
            // txtNumeroDocumento
            // 
            this.txtNumeroDocumento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumeroDocumento.Location = new System.Drawing.Point(195, 45);
            this.txtNumeroDocumento.MaxLength = 10;
            this.txtNumeroDocumento.Name = "txtNumeroDocumento";
            this.txtNumeroDocumento.Size = new System.Drawing.Size(161, 21);
            this.txtNumeroDocumento.TabIndex = 0;
            this.txtNumeroDocumento.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtNumeroDocumento.TextChanged += new System.EventHandler(this.txtNumeroDocumento_TextChanged);
            this.txtNumeroDocumento.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtNumeroDocumento_KeyDown);
            this.txtNumeroDocumento.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumeroDocumento_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(1, 49);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(196, 13);
            this.label5.TabIndex = 77;
            this.label5.Text = "Número de Documento de Identidad";
            // 
            // txtApellidoPaterno
            // 
            this.txtApellidoPaterno.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtApellidoPaterno.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApellidoPaterno.Location = new System.Drawing.Point(195, 70);
            this.txtApellidoPaterno.MaxLength = 30;
            this.txtApellidoPaterno.Name = "txtApellidoPaterno";
            this.txtApellidoPaterno.ReadOnly = true;
            this.txtApellidoPaterno.Size = new System.Drawing.Size(161, 21);
            this.txtApellidoPaterno.TabIndex = 76;
            // 
            // txtApellidoMaterno
            // 
            this.txtApellidoMaterno.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtApellidoMaterno.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApellidoMaterno.Location = new System.Drawing.Point(195, 95);
            this.txtApellidoMaterno.MaxLength = 30;
            this.txtApellidoMaterno.Name = "txtApellidoMaterno";
            this.txtApellidoMaterno.ReadOnly = true;
            this.txtApellidoMaterno.Size = new System.Drawing.Size(161, 21);
            this.txtApellidoMaterno.TabIndex = 75;
            // 
            // lblmensajito
            // 
            this.lblmensajito.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.lblmensajito.Enabled = false;
            this.lblmensajito.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmensajito.Location = new System.Drawing.Point(13, 148);
            this.lblmensajito.MaxLength = 30;
            this.lblmensajito.Name = "lblmensajito";
            this.lblmensajito.ReadOnly = true;
            this.lblmensajito.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblmensajito.ShortcutsEnabled = false;
            this.lblmensajito.Size = new System.Drawing.Size(343, 21);
            this.lblmensajito.TabIndex = 74;
            // 
            // txtNombres
            // 
            this.txtNombres.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNombres.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombres.Location = new System.Drawing.Point(195, 120);
            this.txtNombres.MaxLength = 30;
            this.txtNombres.Name = "txtNombres";
            this.txtNombres.ReadOnly = true;
            this.txtNombres.ShortcutsEnabled = false;
            this.txtNombres.Size = new System.Drawing.Size(161, 21);
            this.txtNombres.TabIndex = 74;
            // 
            // cboTipoDocumento
            // 
            this.cboTipoDocumento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(218)))), ((int)(((byte)(231)))));
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
            this.label4.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(144, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 72;
            this.label4.Text = "Nombres";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(100, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 13);
            this.label3.TabIndex = 71;
            this.label3.Text = "Apellido Materno";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(104, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 13);
            this.label2.TabIndex = 70;
            this.label2.Text = "Apellido Paterno";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 13);
            this.label1.TabIndex = 69;
            this.label1.Text = "Tipo de Documento de Identidad";
            // 
            // dtpInicio
            // 
            this.dtpInicio.CalendarTitleBackColor = System.Drawing.Color.Yellow;
            this.dtpInicio.CalendarTrailingForeColor = System.Drawing.Color.Red;
            this.dtpInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpInicio.Location = new System.Drawing.Point(94, 10);
            this.dtpInicio.Name = "dtpInicio";
            this.dtpInicio.Size = new System.Drawing.Size(90, 21);
            this.dtpInicio.TabIndex = 1;
            this.dtpInicio.ValueChanged += new System.EventHandler(this.dtpInicio_ValueChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(24, 14);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(68, 13);
            this.label9.TabIndex = 96;
            this.label9.Text = "Fecha Inicio";
            // 
            // dtpFin
            // 
            this.dtpFin.CalendarTrailingForeColor = System.Drawing.Color.White;
            this.dtpFin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFin.Location = new System.Drawing.Point(266, 10);
            this.dtpFin.Name = "dtpFin";
            this.dtpFin.Size = new System.Drawing.Size(90, 21);
            this.dtpFin.TabIndex = 2;
            this.dtpFin.ValueChanged += new System.EventHandler(this.dtpFin_ValueChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(206, 14);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(56, 13);
            this.label10.TabIndex = 98;
            this.label10.Text = "Fecha Fin";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(18, 40);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(74, 13);
            this.label11.TabIndex = 99;
            this.label11.Text = "Días faltados";
            // 
            // txtDias
            // 
            this.txtDias.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDias.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDias.Location = new System.Drawing.Point(94, 36);
            this.txtDias.MaxLength = 30;
            this.txtDias.Name = "txtDias";
            this.txtDias.ReadOnly = true;
            this.txtDias.Size = new System.Drawing.Size(25, 21);
            this.txtDias.TabIndex = 100;
            this.txtDias.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(10, 64);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(82, 13);
            this.label12.TabIndex = 102;
            this.label12.Text = "Observaciones";
            // 
            // txtObservaciones
            // 
            this.txtObservaciones.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtObservaciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtObservaciones.Location = new System.Drawing.Point(94, 61);
            this.txtObservaciones.MaxLength = 0;
            this.txtObservaciones.Multiline = true;
            this.txtObservaciones.Name = "txtObservaciones";
            this.txtObservaciones.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.txtObservaciones.Size = new System.Drawing.Size(262, 169);
            this.txtObservaciones.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.pbFaltas);
            this.groupBox1.Controls.Add(this.chkfaltas);
            this.groupBox1.Controls.Add(this.txtObservaciones);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.txtDias);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.dtpFin);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.dtpInicio);
            this.groupBox1.Location = new System.Drawing.Point(16, 188);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(373, 236);
            this.groupBox1.TabIndex = 74;
            this.groupBox1.TabStop = false;
            // 
            // pbFaltas
            // 
            this.pbFaltas.BackColor = System.Drawing.Color.Transparent;
            this.pbFaltas.Image = global::HPReserger.Properties.Resources.NoRegistrarFaltas;
            this.pbFaltas.Location = new System.Drawing.Point(0, 0);
            this.pbFaltas.Name = "pbFaltas";
            this.pbFaltas.Size = new System.Drawing.Size(373, 236);
            this.pbFaltas.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbFaltas.TabIndex = 104;
            this.pbFaltas.TabStop = false;
            this.pbFaltas.Visible = false;
            // 
            // chkfaltas
            // 
            this.chkfaltas.AutoSize = true;
            this.chkfaltas.BackColor = System.Drawing.Color.Transparent;
            this.chkfaltas.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkfaltas.Location = new System.Drawing.Point(195, 38);
            this.chkfaltas.Name = "chkfaltas";
            this.chkfaltas.Size = new System.Drawing.Size(119, 17);
            this.chkfaltas.TabIndex = 3;
            this.chkfaltas.Text = "Aplicar Descuento";
            this.chkfaltas.UseVisualStyleBackColor = false;
            this.chkfaltas.CheckedChanged += new System.EventHandler(this.chkfaltas_CheckedChanged);
            // 
            // Grid
            // 
            this.Grid.AllowUserToAddRows = false;
            this.Grid.AllowUserToDeleteRows = false;
            this.Grid.AllowUserToOrderColumns = true;
            this.Grid.AllowUserToResizeColumns = false;
            this.Grid.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(230)))), ((int)(((byte)(241)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(191)))), ((int)(((byte)(231)))));
            this.Grid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.Grid.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.Grid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Grid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(218)))), ((int)(((byte)(231)))));
            this.Grid.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Grid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.Grid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(129)))), ((int)(((byte)(189)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DeepSkyBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Grid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.Grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Registro,
            this.CODIGOTIPO,
            this.TIPOID,
            this.NDI,
            this.FECHAINICIO,
            this.FECHAFIN,
            this.DIASFALTAS,
            this.OBSERVACIONES});
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(207)))), ((int)(((byte)(241)))));
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Grid.DefaultCellStyle = dataGridViewCellStyle10;
            this.Grid.EnableHeadersVisualStyles = false;
            this.Grid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(179)))), ((int)(((byte)(215)))));
            this.Grid.Location = new System.Drawing.Point(401, 12);
            this.Grid.Name = "Grid";
            this.Grid.ReadOnly = true;
            this.Grid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.Grid.RowHeadersVisible = false;
            this.Grid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.Grid.RowTemplate.Height = 16;
            this.Grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Grid.Size = new System.Drawing.Size(746, 412);
            this.Grid.TabIndex = 75;
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
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.CODIGOTIPO.DefaultCellStyle = dataGridViewCellStyle3;
            this.CODIGOTIPO.HeaderText = "CODIGOTIPO";
            this.CODIGOTIPO.Name = "CODIGOTIPO";
            this.CODIGOTIPO.ReadOnly = true;
            this.CODIGOTIPO.Visible = false;
            // 
            // TIPOID
            // 
            this.TIPOID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.TIPOID.DataPropertyName = "TIPOID";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TIPOID.DefaultCellStyle = dataGridViewCellStyle4;
            this.TIPOID.FillWeight = 89.54314F;
            this.TIPOID.HeaderText = "TIPO ID";
            this.TIPOID.MinimumWidth = 50;
            this.TIPOID.Name = "TIPOID";
            this.TIPOID.ReadOnly = true;
            this.TIPOID.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.TIPOID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.TIPOID.Width = 52;
            // 
            // NDI
            // 
            this.NDI.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.NDI.DataPropertyName = "NID";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.NDI.DefaultCellStyle = dataGridViewCellStyle5;
            this.NDI.FillWeight = 89.54314F;
            this.NDI.HeaderText = "Nº ID";
            this.NDI.MinimumWidth = 80;
            this.NDI.Name = "NDI";
            this.NDI.ReadOnly = true;
            this.NDI.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.NDI.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.NDI.Width = 80;
            // 
            // FECHAINICIO
            // 
            this.FECHAINICIO.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.FECHAINICIO.DataPropertyName = "FECHAINICIO";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.FECHAINICIO.DefaultCellStyle = dataGridViewCellStyle6;
            this.FECHAINICIO.FillWeight = 89.54314F;
            this.FECHAINICIO.HeaderText = "FECHA INI";
            this.FECHAINICIO.MinimumWidth = 65;
            this.FECHAINICIO.Name = "FECHAINICIO";
            this.FECHAINICIO.ReadOnly = true;
            this.FECHAINICIO.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.FECHAINICIO.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.FECHAINICIO.Width = 67;
            // 
            // FECHAFIN
            // 
            this.FECHAFIN.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.FECHAFIN.DataPropertyName = "FECHAFIN";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black;
            this.FECHAFIN.DefaultCellStyle = dataGridViewCellStyle7;
            this.FECHAFIN.FillWeight = 89.54314F;
            this.FECHAFIN.HeaderText = "FECHA FIN";
            this.FECHAFIN.MinimumWidth = 65;
            this.FECHAFIN.Name = "FECHAFIN";
            this.FECHAFIN.ReadOnly = true;
            this.FECHAFIN.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.FECHAFIN.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.FECHAFIN.Width = 70;
            // 
            // DIASFALTAS
            // 
            this.DIASFALTAS.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.DIASFALTAS.DataPropertyName = "DIASFALTAS";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.DIASFALTAS.DefaultCellStyle = dataGridViewCellStyle8;
            this.DIASFALTAS.FillWeight = 152.2843F;
            this.DIASFALTAS.HeaderText = "DIAS FALT.";
            this.DIASFALTAS.MinimumWidth = 70;
            this.DIASFALTAS.Name = "DIASFALTAS";
            this.DIASFALTAS.ReadOnly = true;
            this.DIASFALTAS.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.DIASFALTAS.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.DIASFALTAS.Width = 70;
            // 
            // OBSERVACIONES
            // 
            this.OBSERVACIONES.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.OBSERVACIONES.DataPropertyName = "OBSERVACIONES";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.OBSERVACIONES.DefaultCellStyle = dataGridViewCellStyle9;
            this.OBSERVACIONES.FillWeight = 89.54314F;
            this.OBSERVACIONES.HeaderText = "OBSERVACIONES";
            this.OBSERVACIONES.MinimumWidth = 50;
            this.OBSERVACIONES.Name = "OBSERVACIONES";
            this.OBSERVACIONES.ReadOnly = true;
            this.OBSERVACIONES.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.OBSERVACIONES.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // btnRegistrarFalta
            // 
            this.btnRegistrarFalta.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnRegistrarFalta.Image = ((System.Drawing.Image)(resources.GetObject("btnRegistrarFalta.Image")));
            this.btnRegistrarFalta.Location = new System.Drawing.Point(401, 433);
            this.btnRegistrarFalta.Name = "btnRegistrarFalta";
            this.btnRegistrarFalta.Size = new System.Drawing.Size(119, 24);
            this.btnRegistrarFalta.TabIndex = 5;
            this.btnRegistrarFalta.Text = "Registrar Falta";
            this.btnRegistrarFalta.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRegistrarFalta.UseVisualStyleBackColor = true;
            this.btnRegistrarFalta.Click += new System.EventHandler(this.btnRegistrarFalta_Click);
            // 
            // btnAdjuntarSustento
            // 
            this.btnAdjuntarSustento.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAdjuntarSustento.Image = ((System.Drawing.Image)(resources.GetObject("btnAdjuntarSustento.Image")));
            this.btnAdjuntarSustento.Location = new System.Drawing.Point(1159, 433);
            this.btnAdjuntarSustento.Name = "btnAdjuntarSustento";
            this.btnAdjuntarSustento.Size = new System.Drawing.Size(119, 24);
            this.btnAdjuntarSustento.TabIndex = 6;
            this.btnAdjuntarSustento.Text = "Adjuntar Sustento";
            this.btnAdjuntarSustento.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAdjuntarSustento.UseVisualStyleBackColor = true;
            this.btnAdjuntarSustento.Click += new System.EventHandler(this.btnAdjuntarSustento_Click);
            // 
            // txtRuta
            // 
            this.txtRuta.Location = new System.Drawing.Point(1417, 436);
            this.txtRuta.MaxLength = 14;
            this.txtRuta.Name = "txtRuta";
            this.txtRuta.Size = new System.Drawing.Size(118, 20);
            this.txtRuta.TabIndex = 79;
            this.txtRuta.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtRuta.Visible = false;
            // 
            // pbFoto
            // 
            this.pbFoto.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbFoto.BackColor = System.Drawing.Color.Transparent;
            this.pbFoto.Location = new System.Drawing.Point(1159, 12);
            this.pbFoto.Name = "pbFoto";
            this.pbFoto.Size = new System.Drawing.Size(376, 412);
            this.pbFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbFoto.TabIndex = 103;
            this.pbFoto.TabStop = false;
            this.pbFoto.Click += new System.EventHandler(this.pbFoto_Click);
            this.pbFoto.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pbFoto_MouseMove);
            // 
            // btndescargar
            // 
            this.btndescargar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btndescargar.AutoEllipsis = true;
            this.btndescargar.ImageKey = "(ninguno)";
            this.btndescargar.Location = new System.Drawing.Point(1320, 395);
            this.btndescargar.Name = "btndescargar";
            this.btndescargar.Size = new System.Drawing.Size(76, 23);
            this.btndescargar.TabIndex = 111;
            this.btndescargar.Text = "Descargar";
            this.btndescargar.UseVisualStyleBackColor = false;
            this.btndescargar.Visible = false;
            this.btndescargar.Click += new System.EventHandler(this.btndescargar_Click);
            this.btndescargar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btndescargar_MouseMove);
            // 
            // frmFaltas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1541, 468);
            this.Controls.Add(this.btndescargar);
            this.Controls.Add(this.txtRuta);
            this.Controls.Add(this.btnAdjuntarSustento);
            this.Controls.Add(this.pbFoto);
            this.Controls.Add(this.btnRegistrarFalta);
            this.Controls.Add(this.Grid);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.MinimumSize = new System.Drawing.Size(1557, 507);
            this.Name = "frmFaltas";
            this.Nombre = "Registro de Faltas";
            this.Text = "Registro de Faltas";
            this.Load += new System.EventHandler(this.frmFaltas_Load);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.frmFaltas_MouseMove);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbFaltas)).EndInit();
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
        private System.Windows.Forms.DateTimePicker dtpInicio;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dtpFin;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtDias;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtObservaciones;
        private System.Windows.Forms.GroupBox groupBox1;
        private Dtgconten Grid;
        private System.Windows.Forms.Button btnRegistrarFalta;
        private System.Windows.Forms.PictureBox pbFoto;
        private System.Windows.Forms.Button btnAdjuntarSustento;
        private System.Windows.Forms.TextBox txtRuta;
        private System.Windows.Forms.TextBox lblmensajito;
        private System.Windows.Forms.CheckBox chkfaltas;
        private System.Windows.Forms.PictureBox pbFaltas;
        private System.Windows.Forms.Button btndescargar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Registro;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGOTIPO;
        private System.Windows.Forms.DataGridViewTextBoxColumn TIPOID;
        private System.Windows.Forms.DataGridViewTextBoxColumn NDI;
        private System.Windows.Forms.DataGridViewTextBoxColumn FECHAINICIO;
        private System.Windows.Forms.DataGridViewTextBoxColumn FECHAFIN;
        private System.Windows.Forms.DataGridViewTextBoxColumn DIASFALTAS;
        private System.Windows.Forms.DataGridViewTextBoxColumn OBSERVACIONES;
        private CachedrptConvenioPracticasPreprofesional cachedrptConvenioPracticasPreprofesional1;
    }
}