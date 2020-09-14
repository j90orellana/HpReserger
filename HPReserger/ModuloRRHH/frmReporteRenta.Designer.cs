namespace HPReserger.ModuloRRHH
{
    partial class frmReporteRenta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReporteRenta));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.label5 = new System.Windows.Forms.Label();
            this.cbofechahasta = new HpResergerUserControls.ComboMesAño();
            this.cbofechade = new HpResergerUserControls.ComboMesAño();
            this.label2 = new System.Windows.Forms.Label();
            this.btnlimpiar = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtbusEmpresa = new HpResergerUserControls.TextBoxPer();
            this.txtbusEmpleado = new HpResergerUserControls.TextBoxPer();
            this.lblRegistros = new System.Windows.Forms.Label();
            this.buttonPer1 = new HpResergerUserControls.ButtonPer();
            this.dtgconten = new HpResergerUserControls.Dtgconten();
            this.xpkempresa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xEmpresa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xFechaIngreso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xtipoid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xtipodoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NroDoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xNombres = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xRenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnExcel = new System.Windows.Forms.Button();
            this.btnTXT = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.cboCuentaBancaria = new System.Windows.Forms.ComboBox();
            this.SaveFile = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dtgconten)).BeginInit();
            this.SuspendLayout();
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(10, 55);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(24, 13);
            this.label5.TabIndex = 242;
            this.label5.Text = "De:";
            // 
            // cbofechahasta
            // 
            this.cbofechahasta.BackColor = System.Drawing.Color.Transparent;
            this.cbofechahasta.FechaConDiaActual = new System.DateTime(2020, 9, 30, 0, 0, 0, 0);
            this.cbofechahasta.FechaFinMes = new System.DateTime(2020, 9, 30, 0, 0, 0, 0);
            this.cbofechahasta.FechaInicioMes = new System.DateTime(2020, 9, 1, 0, 0, 0, 0);
            this.cbofechahasta.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbofechahasta.Location = new System.Drawing.Point(303, 48);
            this.cbofechahasta.Name = "cbofechahasta";
            this.cbofechahasta.Size = new System.Drawing.Size(230, 26);
            this.cbofechahasta.TabIndex = 233;
            this.cbofechahasta.VerAño = true;
            this.cbofechahasta.VerMes = true;
            this.cbofechahasta.CambioFechas += new System.EventHandler(this.cbofechade_CambioFechas);
            // 
            // cbofechade
            // 
            this.cbofechade.BackColor = System.Drawing.Color.Transparent;
            this.cbofechade.FechaConDiaActual = new System.DateTime(2020, 9, 30, 0, 0, 0, 0);
            this.cbofechade.FechaFinMes = new System.DateTime(2020, 9, 30, 0, 0, 0, 0);
            this.cbofechade.FechaInicioMes = new System.DateTime(2020, 9, 1, 0, 0, 0, 0);
            this.cbofechade.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbofechade.Location = new System.Drawing.Point(34, 48);
            this.cbofechade.Name = "cbofechade";
            this.cbofechade.Size = new System.Drawing.Size(230, 26);
            this.cbofechade.TabIndex = 232;
            this.cbofechade.VerAño = true;
            this.cbofechade.VerMes = true;
            this.cbofechade.CambioFechas += new System.EventHandler(this.cbofechade_CambioFechas);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(264, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 243;
            this.label2.Text = "Hasta:";
            // 
            // btnlimpiar
            // 
            this.btnlimpiar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnlimpiar.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlimpiar.Image = ((System.Drawing.Image)(resources.GetObject("btnlimpiar.Image")));
            this.btnlimpiar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnlimpiar.Location = new System.Drawing.Point(891, 24);
            this.btnlimpiar.Name = "btnlimpiar";
            this.btnlimpiar.Size = new System.Drawing.Size(82, 24);
            this.btnlimpiar.TabIndex = 236;
            this.btnlimpiar.Text = "Limpiar";
            this.btnlimpiar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnlimpiar.UseVisualStyleBackColor = true;
            this.btnlimpiar.Click += new System.EventHandler(this.btnlimpiar_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnActualizar.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizar.Image = ((System.Drawing.Image)(resources.GetObject("btnActualizar.Image")));
            this.btnActualizar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnActualizar.Location = new System.Drawing.Point(891, 49);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(82, 24);
            this.btnActualizar.TabIndex = 237;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(10, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 13);
            this.label4.TabIndex = 241;
            this.label4.Text = "Opciones de Filtrado:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 13);
            this.label1.TabIndex = 240;
            this.label1.Text = "Resumen de Empleados";
            // 
            // txtbusEmpresa
            // 
            this.txtbusEmpresa.BackColor = System.Drawing.Color.White;
            this.txtbusEmpresa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtbusEmpresa.ColorFondoMouseEncima = System.Drawing.Color.Empty;
            this.txtbusEmpresa.ColorFondoMousePresionado = System.Drawing.Color.Empty;
            this.txtbusEmpresa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbusEmpresa.ForeColor = System.Drawing.Color.Black;
            this.txtbusEmpresa.Format = null;
            this.txtbusEmpresa.Location = new System.Drawing.Point(378, 26);
            this.txtbusEmpresa.MaxLength = 600;
            this.txtbusEmpresa.Name = "txtbusEmpresa";
            this.txtbusEmpresa.NextControlOnEnter = null;
            this.txtbusEmpresa.Size = new System.Drawing.Size(376, 21);
            this.txtbusEmpresa.TabIndex = 231;
            this.txtbusEmpresa.Text = "Buscar Por Empresa O RUC";
            this.txtbusEmpresa.TextoDefecto = "Buscar Por Empresa O RUC";
            this.txtbusEmpresa.TextoDefectoColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(129)))), ((int)(((byte)(189)))));
            this.txtbusEmpresa.TiposDatos = HpResergerUserControls.TextBoxPer.ListaTipos.MayusculaCadaPalabra;
            this.txtbusEmpresa.TextChanged += new System.EventHandler(this.txtbusEmpleado_TextChanged);
            // 
            // txtbusEmpleado
            // 
            this.txtbusEmpleado.BackColor = System.Drawing.Color.White;
            this.txtbusEmpleado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtbusEmpleado.ColorFondoMouseEncima = System.Drawing.Color.Empty;
            this.txtbusEmpleado.ColorFondoMousePresionado = System.Drawing.Color.Empty;
            this.txtbusEmpleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbusEmpleado.ForeColor = System.Drawing.Color.Black;
            this.txtbusEmpleado.Format = null;
            this.txtbusEmpleado.Location = new System.Drawing.Point(10, 26);
            this.txtbusEmpleado.MaxLength = 600;
            this.txtbusEmpleado.Name = "txtbusEmpleado";
            this.txtbusEmpleado.NextControlOnEnter = null;
            this.txtbusEmpleado.Size = new System.Drawing.Size(361, 21);
            this.txtbusEmpleado.TabIndex = 230;
            this.txtbusEmpleado.Text = "Documento O Nombre Empleado";
            this.txtbusEmpleado.TextoDefecto = "Documento O Nombre Empleado";
            this.txtbusEmpleado.TextoDefectoColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(129)))), ((int)(((byte)(189)))));
            this.txtbusEmpleado.TiposDatos = HpResergerUserControls.TextBoxPer.ListaTipos.MayusculaCadaPalabra;
            this.txtbusEmpleado.TextChanged += new System.EventHandler(this.txtbusEmpleado_TextChanged);
            // 
            // lblRegistros
            // 
            this.lblRegistros.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblRegistros.AutoSize = true;
            this.lblRegistros.BackColor = System.Drawing.Color.Transparent;
            this.lblRegistros.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegistros.Location = new System.Drawing.Point(10, 492);
            this.lblRegistros.Name = "lblRegistros";
            this.lblRegistros.Size = new System.Drawing.Size(95, 13);
            this.lblRegistros.TabIndex = 239;
            this.lblRegistros.Text = "Total Registros: 0";
            // 
            // buttonPer1
            // 
            this.buttonPer1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonPer1.BackColor = System.Drawing.Color.Crimson;
            this.buttonPer1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonPer1.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.buttonPer1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPer1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPer1.ForeColor = System.Drawing.Color.White;
            this.buttonPer1.Location = new System.Drawing.Point(887, 492);
            this.buttonPer1.Name = "buttonPer1";
            this.buttonPer1.Size = new System.Drawing.Size(83, 24);
            this.buttonPer1.TabIndex = 238;
            this.buttonPer1.Text = "Cancelar";
            this.buttonPer1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonPer1.UseVisualStyleBackColor = false;
            this.buttonPer1.Click += new System.EventHandler(this.buttonPer1_Click);
            // 
            // dtgconten
            // 
            this.dtgconten.AllowUserToAddRows = false;
            this.dtgconten.AllowUserToDeleteRows = false;
            this.dtgconten.AllowUserToOrderColumns = true;
            this.dtgconten.AllowUserToResizeColumns = false;
            this.dtgconten.AllowUserToResizeRows = false;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(230)))), ((int)(((byte)(241)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Tahoma", 8F);
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
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.DeepSkyBlue;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgconten.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dtgconten.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgconten.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.xpkempresa,
            this.xEmpresa,
            this.xFechaIngreso,
            this.xtipoid,
            this.xtipodoc,
            this.NroDoc,
            this.xNombres,
            this.xRenta});
            this.dtgconten.Cursor = System.Windows.Forms.Cursors.Default;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(207)))), ((int)(((byte)(241)))));
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgconten.DefaultCellStyle = dataGridViewCellStyle10;
            this.dtgconten.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dtgconten.EnableHeadersVisualStyles = false;
            this.dtgconten.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(179)))), ((int)(((byte)(215)))));
            this.dtgconten.Location = new System.Drawing.Point(10, 116);
            this.dtgconten.MultiSelect = false;
            this.dtgconten.Name = "dtgconten";
            this.dtgconten.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dtgconten.RowHeadersVisible = false;
            this.dtgconten.RowTemplate.Height = 16;
            this.dtgconten.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgconten.Size = new System.Drawing.Size(960, 370);
            this.dtgconten.TabIndex = 234;
            this.dtgconten.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgconten_CellValueChanged);
            // 
            // xpkempresa
            // 
            this.xpkempresa.DataPropertyName = "pkempresa";
            this.xpkempresa.HeaderText = "IdEmpresa";
            this.xpkempresa.Name = "xpkempresa";
            this.xpkempresa.Visible = false;
            // 
            // xEmpresa
            // 
            this.xEmpresa.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.xEmpresa.DataPropertyName = "empresa";
            this.xEmpresa.HeaderText = "Empresa";
            this.xEmpresa.MinimumWidth = 200;
            this.xEmpresa.Name = "xEmpresa";
            this.xEmpresa.Width = 200;
            // 
            // xFechaIngreso
            // 
            this.xFechaIngreso.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.xFechaIngreso.DataPropertyName = "Fecha";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle8.Format = "d";
            this.xFechaIngreso.DefaultCellStyle = dataGridViewCellStyle8;
            this.xFechaIngreso.FillWeight = 19.68504F;
            this.xFechaIngreso.HeaderText = "Fecha";
            this.xFechaIngreso.MinimumWidth = 50;
            this.xFechaIngreso.Name = "xFechaIngreso";
            this.xFechaIngreso.Width = 50;
            // 
            // xtipoid
            // 
            this.xtipoid.DataPropertyName = "tipoid";
            this.xtipoid.HeaderText = "TipoId";
            this.xtipoid.Name = "xtipoid";
            this.xtipoid.Visible = false;
            // 
            // xtipodoc
            // 
            this.xtipodoc.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.xtipodoc.DataPropertyName = "tipodoc";
            this.xtipodoc.HeaderText = "TipoDoc";
            this.xtipodoc.MinimumWidth = 60;
            this.xtipodoc.Name = "xtipodoc";
            this.xtipodoc.Width = 60;
            // 
            // NroDoc
            // 
            this.NroDoc.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.NroDoc.DataPropertyName = "numdoc";
            this.NroDoc.HeaderText = "NumDoc";
            this.NroDoc.MinimumWidth = 60;
            this.NroDoc.Name = "NroDoc";
            this.NroDoc.Width = 60;
            // 
            // xNombres
            // 
            this.xNombres.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.xNombres.DataPropertyName = "NombreEmpleado";
            this.xNombres.FillWeight = 421.2599F;
            this.xNombres.HeaderText = "Nombre Empleado";
            this.xNombres.MinimumWidth = 150;
            this.xNombres.Name = "xNombres";
            // 
            // xRenta
            // 
            this.xRenta.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.xRenta.DataPropertyName = "renta";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle9.Format = "n2";
            this.xRenta.DefaultCellStyle = dataGridViewCellStyle9;
            this.xRenta.HeaderText = "Renta";
            this.xRenta.MinimumWidth = 40;
            this.xRenta.Name = "xRenta";
            this.xRenta.Width = 40;
            // 
            // btnExcel
            // 
            this.btnExcel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnExcel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcel.Image = ((System.Drawing.Image)(resources.GetObject("btnExcel.Image")));
            this.btnExcel.Location = new System.Drawing.Point(406, 492);
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.Size = new System.Drawing.Size(83, 24);
            this.btnExcel.TabIndex = 235;
            this.btnExcel.Text = "EXCEL";
            this.btnExcel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnExcel.UseVisualStyleBackColor = true;
            this.btnExcel.Click += new System.EventHandler(this.btnExcel_Click);
            // 
            // btnTXT
            // 
            this.btnTXT.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnTXT.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTXT.Image = ((System.Drawing.Image)(resources.GetObject("btnTXT.Image")));
            this.btnTXT.Location = new System.Drawing.Point(495, 492);
            this.btnTXT.Name = "btnTXT";
            this.btnTXT.Size = new System.Drawing.Size(83, 24);
            this.btnTXT.TabIndex = 244;
            this.btnTXT.Text = "TXT";
            this.btnTXT.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTXT.UseVisualStyleBackColor = true;
            this.btnTXT.Click += new System.EventHandler(this.btnTXT_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(7, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 13);
            this.label3.TabIndex = 249;
            this.label3.Text = "Cuenta Bancaria:";
            // 
            // cboCuentaBancaria
            // 
            this.cboCuentaBancaria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCuentaBancaria.FormattingEnabled = true;
            this.cboCuentaBancaria.Location = new System.Drawing.Point(100, 76);
            this.cboCuentaBancaria.Name = "cboCuentaBancaria";
            this.cboCuentaBancaria.Size = new System.Drawing.Size(479, 21);
            this.cboCuentaBancaria.TabIndex = 248;
            // 
            // SaveFile
            // 
            this.SaveFile.Filter = "Archivos de Texto|*.txt";
            // 
            // frmReporteRenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 525);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cboCuentaBancaria);
            this.Controls.Add(this.btnTXT);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbofechahasta);
            this.Controls.Add(this.cbofechade);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnlimpiar);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtbusEmpresa);
            this.Controls.Add(this.txtbusEmpleado);
            this.Controls.Add(this.lblRegistros);
            this.Controls.Add(this.buttonPer1);
            this.Controls.Add(this.dtgconten);
            this.Controls.Add(this.btnExcel);
            this.MinimumSize = new System.Drawing.Size(1000, 564);
            this.Name = "frmReporteRenta";
            this.Nombre = "Reporte Renta";
            this.Text = "Reporte Renta";
            this.Load += new System.EventHandler(this.frmReporteAFP_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgconten)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label5;
        private HpResergerUserControls.ComboMesAño cbofechahasta;
        private HpResergerUserControls.ComboMesAño cbofechade;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnlimpiar;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private HpResergerUserControls.TextBoxPer txtbusEmpresa;
        private HpResergerUserControls.TextBoxPer txtbusEmpleado;
        private System.Windows.Forms.Label lblRegistros;
        private HpResergerUserControls.ButtonPer buttonPer1;
        private HpResergerUserControls.Dtgconten dtgconten;
        private System.Windows.Forms.Button btnExcel;
        private System.Windows.Forms.Button btnTXT;
        private System.Windows.Forms.DataGridViewTextBoxColumn xpkempresa;
        private System.Windows.Forms.DataGridViewTextBoxColumn xEmpresa;
        private System.Windows.Forms.DataGridViewTextBoxColumn xFechaIngreso;
        private System.Windows.Forms.DataGridViewTextBoxColumn xtipoid;
        private System.Windows.Forms.DataGridViewTextBoxColumn xtipodoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn NroDoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn xNombres;
        private System.Windows.Forms.DataGridViewTextBoxColumn xRenta;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboCuentaBancaria;
        private System.Windows.Forms.SaveFileDialog SaveFile;
    }
}