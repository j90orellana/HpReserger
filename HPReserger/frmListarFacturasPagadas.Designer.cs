namespace HPReserger
{
    partial class frmListarFacturasPagadas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmListarFacturasPagadas));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.btnRefrescar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtbuscar = new HpResergerUserControls.TextBoxPer();
            this.label11 = new System.Windows.Forms.Label();
            this.dtpfin = new System.Windows.Forms.DateTimePicker();
            this.dtpini = new System.Windows.Forms.DateTimePicker();
            this.chkrecepcion = new System.Windows.Forms.CheckBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dtfin = new System.Windows.Forms.DateTimePicker();
            this.dtinicio = new System.Windows.Forms.DateTimePicker();
            this.chkfecha = new System.Windows.Forms.CheckBox();
            this.chkprove = new System.Windows.Forms.CheckBox();
            this.Dtguias = new HpResergerUserControls.Dtgconten();
            this.btncancelar = new System.Windows.Forms.Button();
            this.cboempresa = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblmensaje = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.btnpdf = new System.Windows.Forms.Button();
            this.OK = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.tipodoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xidcomprobante = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nrofactura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.proveedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.razon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.monedax = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xtc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subtotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Igv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.detraccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Saldox = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pagox = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaEmision = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaRecepcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaCancelado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nrofic1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.centrocostox = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnVer = new System.Windows.Forms.DataGridViewButtonColumn();
            this.fkasientox = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xidmoneda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xCuentaContable = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dtguias)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRefrescar
            // 
            this.btnRefrescar.Image = ((System.Drawing.Image)(resources.GetObject("btnRefrescar.Image")));
            this.btnRefrescar.Location = new System.Drawing.Point(966, 12);
            this.btnRefrescar.Name = "btnRefrescar";
            this.btnRefrescar.Size = new System.Drawing.Size(86, 23);
            this.btnRefrescar.TabIndex = 347;
            this.btnRefrescar.Text = "Actualizar";
            this.btnRefrescar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRefrescar.UseVisualStyleBackColor = true;
            this.btnRefrescar.Click += new System.EventHandler(this.btnRefrescar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.txtbuscar);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.btnRefrescar);
            this.groupBox1.Controls.Add(this.dtpfin);
            this.groupBox1.Controls.Add(this.dtpini);
            this.groupBox1.Controls.Add(this.chkrecepcion);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.dtfin);
            this.groupBox1.Controls.Add(this.dtinicio);
            this.groupBox1.Controls.Add(this.chkfecha);
            this.groupBox1.Controls.Add(this.chkprove);
            this.groupBox1.Location = new System.Drawing.Point(12, 34);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1058, 38);
            this.groupBox1.TabIndex = 346;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Busqueda";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(842, 17);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(39, 13);
            this.label10.TabIndex = 56;
            this.label10.Text = "Hasta:";
            // 
            // txtbuscar
            // 
            this.txtbuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(218)))), ((int)(((byte)(231)))));
            this.txtbuscar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtbuscar.ColorFondoMouseEncima = System.Drawing.Color.Empty;
            this.txtbuscar.ColorFondoMousePresionado = System.Drawing.Color.Empty;
            this.txtbuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbuscar.ForeColor = System.Drawing.Color.Black;
            this.txtbuscar.Format = null;
            this.txtbuscar.Location = new System.Drawing.Point(97, 13);
            this.txtbuscar.MaxLength = 300;
            this.txtbuscar.Name = "txtbuscar";
            this.txtbuscar.NextControlOnEnter = null;
            this.txtbuscar.ReadOnly = true;
            this.txtbuscar.Size = new System.Drawing.Size(190, 21);
            this.txtbuscar.TabIndex = 342;
            this.txtbuscar.Text = "Buscar Proveedor";
            this.txtbuscar.TextoDefecto = "Buscar Proveedor";
            this.txtbuscar.TextoDefectoColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(129)))), ((int)(((byte)(189)))));
            this.txtbuscar.TiposDatos = HpResergerUserControls.TextBoxPer.ListaTipos.Todo;
            this.txtbuscar.TextChanged += new System.EventHandler(this.txtbuscar_TextChanged_1);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(739, 17);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(24, 13);
            this.label11.TabIndex = 55;
            this.label11.Text = "De:";
            // 
            // dtpfin
            // 
            this.dtpfin.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(218)))), ((int)(((byte)(231)))));
            this.dtpfin.Enabled = false;
            this.dtpfin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpfin.Location = new System.Drawing.Point(881, 13);
            this.dtpfin.Name = "dtpfin";
            this.dtpfin.Size = new System.Drawing.Size(79, 22);
            this.dtpfin.TabIndex = 54;
            this.dtpfin.ValueChanged += new System.EventHandler(this.dtpfin_ValueChanged);
            // 
            // dtpini
            // 
            this.dtpini.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(218)))), ((int)(((byte)(231)))));
            this.dtpini.Enabled = false;
            this.dtpini.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpini.Location = new System.Drawing.Point(763, 13);
            this.dtpini.Name = "dtpini";
            this.dtpini.Size = new System.Drawing.Size(79, 22);
            this.dtpini.TabIndex = 53;
            this.dtpini.ValueChanged += new System.EventHandler(this.dtpini_ValueChanged);
            // 
            // chkrecepcion
            // 
            this.chkrecepcion.AutoSize = true;
            this.chkrecepcion.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkrecepcion.Location = new System.Drawing.Point(628, 15);
            this.chkrecepcion.Name = "chkrecepcion";
            this.chkrecepcion.Size = new System.Drawing.Size(115, 17);
            this.chkrecepcion.TabIndex = 52;
            this.chkrecepcion.Text = "Fecha Recepción:";
            this.chkrecepcion.UseVisualStyleBackColor = true;
            this.chkrecepcion.CheckedChanged += new System.EventHandler(this.chkrecepcion_CheckedChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(506, 17);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(39, 13);
            this.label9.TabIndex = 51;
            this.label9.Text = "Hasta:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(403, 17);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(24, 13);
            this.label8.TabIndex = 50;
            this.label8.Text = "De:";
            // 
            // dtfin
            // 
            this.dtfin.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(218)))), ((int)(((byte)(231)))));
            this.dtfin.Enabled = false;
            this.dtfin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtfin.Location = new System.Drawing.Point(545, 13);
            this.dtfin.Name = "dtfin";
            this.dtfin.Size = new System.Drawing.Size(79, 22);
            this.dtfin.TabIndex = 4;
            this.dtfin.ValueChanged += new System.EventHandler(this.dtfin_ValueChanged);
            // 
            // dtinicio
            // 
            this.dtinicio.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(218)))), ((int)(((byte)(231)))));
            this.dtinicio.Enabled = false;
            this.dtinicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtinicio.Location = new System.Drawing.Point(427, 13);
            this.dtinicio.Name = "dtinicio";
            this.dtinicio.Size = new System.Drawing.Size(79, 22);
            this.dtinicio.TabIndex = 3;
            this.dtinicio.ValueChanged += new System.EventHandler(this.dtinicio_ValueChanged);
            // 
            // chkfecha
            // 
            this.chkfecha.AutoSize = true;
            this.chkfecha.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkfecha.Location = new System.Drawing.Point(292, 15);
            this.chkfecha.Name = "chkfecha";
            this.chkfecha.Size = new System.Drawing.Size(116, 17);
            this.chkfecha.TabIndex = 1;
            this.chkfecha.Text = "Fecha Cancelado:";
            this.chkfecha.UseVisualStyleBackColor = true;
            this.chkfecha.CheckedChanged += new System.EventHandler(this.chkfecha_CheckedChanged);
            // 
            // chkprove
            // 
            this.chkprove.AutoSize = true;
            this.chkprove.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkprove.Location = new System.Drawing.Point(16, 15);
            this.chkprove.Name = "chkprove";
            this.chkprove.Size = new System.Drawing.Size(81, 17);
            this.chkprove.TabIndex = 0;
            this.chkprove.Text = "Proveedor:";
            this.chkprove.UseVisualStyleBackColor = true;
            this.chkprove.CheckedChanged += new System.EventHandler(this.chkprove_CheckedChanged);
            // 
            // Dtguias
            // 
            this.Dtguias.AllowUserToAddRows = false;
            this.Dtguias.AllowUserToDeleteRows = false;
            this.Dtguias.AllowUserToOrderColumns = true;
            this.Dtguias.AllowUserToResizeColumns = false;
            this.Dtguias.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(230)))), ((int)(((byte)(241)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(191)))), ((int)(((byte)(231)))));
            this.Dtguias.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.Dtguias.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Dtguias.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Dtguias.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(218)))), ((int)(((byte)(231)))));
            this.Dtguias.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Dtguias.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.Dtguias.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(129)))), ((int)(((byte)(189)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DeepSkyBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Dtguias.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.Dtguias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dtguias.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.OK,
            this.tipodoc,
            this.xidcomprobante,
            this.nrofactura,
            this.proveedor,
            this.razon,
            this.monedax,
            this.xtc,
            this.subtotal,
            this.Igv,
            this.Total,
            this.detraccion,
            this.Saldox,
            this.Pagox,
            this.FechaEmision,
            this.fechaRecepcion,
            this.FechaCancelado,
            this.nrofic1,
            this.centrocostox,
            this.btnVer,
            this.fkasientox,
            this.xidmoneda,
            this.xCuentaContable});
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(207)))), ((int)(((byte)(241)))));
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Dtguias.DefaultCellStyle = dataGridViewCellStyle13;
            this.Dtguias.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.Dtguias.EnableHeadersVisualStyles = false;
            this.Dtguias.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(179)))), ((int)(((byte)(215)))));
            this.Dtguias.Location = new System.Drawing.Point(12, 91);
            this.Dtguias.MultiSelect = false;
            this.Dtguias.Name = "Dtguias";
            this.Dtguias.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.Dtguias.RowHeadersVisible = false;
            this.Dtguias.RowTemplate.Height = 20;
            this.Dtguias.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Dtguias.Size = new System.Drawing.Size(1077, 341);
            this.Dtguias.TabIndex = 345;
            this.Dtguias.TabStop = false;
            // 
            // btncancelar
            // 
            this.btncancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btncancelar.Image = ((System.Drawing.Image)(resources.GetObject("btncancelar.Image")));
            this.btncancelar.Location = new System.Drawing.Point(1014, 437);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(75, 23);
            this.btncancelar.TabIndex = 348;
            this.btncancelar.Text = "Cancelar";
            this.btncancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btncancelar.UseVisualStyleBackColor = true;
            // 
            // cboempresa
            // 
            this.cboempresa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(218)))), ((int)(((byte)(231)))));
            this.cboempresa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboempresa.FormattingEnabled = true;
            this.cboempresa.Location = new System.Drawing.Point(71, 12);
            this.cboempresa.Name = "cboempresa";
            this.cboempresa.Size = new System.Drawing.Size(349, 21);
            this.cboempresa.TabIndex = 350;
            this.cboempresa.SelectedIndexChanged += new System.EventHandler(this.cboempresa_SelectedIndexChanged);
            this.cboempresa.Click += new System.EventHandler(this.cboempresa_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(15, 16);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(53, 13);
            this.label12.TabIndex = 349;
            this.label12.Text = "Empresa:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 13);
            this.label1.TabIndex = 349;
            this.label1.Text = "Listado de Facturas Pagadas:";
            // 
            // lblmensaje
            // 
            this.lblmensaje.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblmensaje.AutoSize = true;
            this.lblmensaje.BackColor = System.Drawing.Color.Transparent;
            this.lblmensaje.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmensaje.Location = new System.Drawing.Point(12, 442);
            this.lblmensaje.Name = "lblmensaje";
            this.lblmensaje.Size = new System.Drawing.Size(129, 13);
            this.lblmensaje.TabIndex = 348;
            this.lblmensaje.Text = "Número de Registros=0";
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // btnpdf
            // 
            this.btnpdf.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnpdf.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnpdf.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnpdf.Image = ((System.Drawing.Image)(resources.GetObject("btnpdf.Image")));
            this.btnpdf.Location = new System.Drawing.Point(506, 436);
            this.btnpdf.Name = "btnpdf";
            this.btnpdf.Size = new System.Drawing.Size(82, 25);
            this.btnpdf.TabIndex = 351;
            this.btnpdf.Text = "Excel";
            this.btnpdf.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnpdf.UseVisualStyleBackColor = true;
            this.btnpdf.Click += new System.EventHandler(this.btnpdf_Click);
            // 
            // OK
            // 
            this.OK.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.OK.DataPropertyName = "OK";
            this.OK.FalseValue = "False";
            this.OK.FillWeight = 126.9036F;
            this.OK.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.OK.HeaderText = "OK";
            this.OK.MinimumWidth = 30;
            this.OK.Name = "OK";
            this.OK.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.OK.TrueValue = "True";
            this.OK.Visible = false;
            this.OK.Width = 30;
            // 
            // tipodoc
            // 
            this.tipodoc.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.tipodoc.DataPropertyName = "tipo";
            this.tipodoc.HeaderText = "T";
            this.tipodoc.MinimumWidth = 30;
            this.tipodoc.Name = "tipodoc";
            this.tipodoc.ReadOnly = true;
            this.tipodoc.Width = 36;
            // 
            // xidcomprobante
            // 
            this.xidcomprobante.DataPropertyName = "idcomprobante";
            this.xidcomprobante.HeaderText = "xidcomprobante";
            this.xidcomprobante.Name = "xidcomprobante";
            this.xidcomprobante.Visible = false;
            // 
            // nrofactura
            // 
            this.nrofactura.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.nrofactura.DataPropertyName = "nrofactura";
            this.nrofactura.HeaderText = "Comprobante";
            this.nrofactura.MinimumWidth = 85;
            this.nrofactura.Name = "nrofactura";
            this.nrofactura.ReadOnly = true;
            this.nrofactura.Width = 85;
            // 
            // proveedor
            // 
            this.proveedor.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.proveedor.DataPropertyName = "proveedor";
            this.proveedor.HeaderText = "Proveedor";
            this.proveedor.MinimumWidth = 80;
            this.proveedor.Name = "proveedor";
            this.proveedor.ReadOnly = true;
            this.proveedor.Width = 80;
            // 
            // razon
            // 
            this.razon.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.razon.DataPropertyName = "razon";
            this.razon.HeaderText = "Razón Social";
            this.razon.MinimumWidth = 100;
            this.razon.Name = "razon";
            this.razon.ReadOnly = true;
            // 
            // monedax
            // 
            this.monedax.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.monedax.DataPropertyName = "MON";
            this.monedax.FillWeight = 40F;
            this.monedax.HeaderText = "Mon";
            this.monedax.MinimumWidth = 40;
            this.monedax.Name = "monedax";
            this.monedax.ReadOnly = true;
            this.monedax.Width = 40;
            // 
            // xtc
            // 
            this.xtc.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.xtc.DataPropertyName = "tc";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.Format = "n3";
            this.xtc.DefaultCellStyle = dataGridViewCellStyle3;
            this.xtc.HeaderText = "T.C. Reg.";
            this.xtc.Name = "xtc";
            this.xtc.ReadOnly = true;
            this.xtc.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.xtc.Width = 56;
            // 
            // subtotal
            // 
            this.subtotal.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.subtotal.DataPropertyName = "subtotal";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle4.Format = "n2";
            this.subtotal.DefaultCellStyle = dataGridViewCellStyle4;
            this.subtotal.HeaderText = "Subtotal";
            this.subtotal.MinimumWidth = 70;
            this.subtotal.Name = "subtotal";
            this.subtotal.ReadOnly = true;
            this.subtotal.Width = 70;
            // 
            // Igv
            // 
            this.Igv.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.Igv.DataPropertyName = "Igv";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle5.Format = "n2";
            this.Igv.DefaultCellStyle = dataGridViewCellStyle5;
            this.Igv.HeaderText = "Igv/Rta";
            this.Igv.MinimumWidth = 60;
            this.Igv.Name = "Igv";
            this.Igv.ReadOnly = true;
            this.Igv.Width = 60;
            // 
            // Total
            // 
            this.Total.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.Total.DataPropertyName = "Total";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle6.Format = "n2";
            this.Total.DefaultCellStyle = dataGridViewCellStyle6;
            this.Total.HeaderText = "Total";
            this.Total.MinimumWidth = 56;
            this.Total.Name = "Total";
            this.Total.ReadOnly = true;
            this.Total.Width = 56;
            // 
            // detraccion
            // 
            this.detraccion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.detraccion.DataPropertyName = "detrac";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle7.Format = "n2";
            this.detraccion.DefaultCellStyle = dataGridViewCellStyle7;
            this.detraccion.HeaderText = "Detrac.";
            this.detraccion.MinimumWidth = 70;
            this.detraccion.Name = "detraccion";
            this.detraccion.ReadOnly = true;
            this.detraccion.Width = 70;
            // 
            // Saldox
            // 
            this.Saldox.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Saldox.DataPropertyName = "saldo";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle8.Format = "n2";
            this.Saldox.DefaultCellStyle = dataGridViewCellStyle8;
            this.Saldox.HeaderText = "Saldo";
            this.Saldox.MinimumWidth = 50;
            this.Saldox.Name = "Saldox";
            this.Saldox.ReadOnly = true;
            this.Saldox.Width = 60;
            // 
            // Pagox
            // 
            this.Pagox.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Pagox.DataPropertyName = "pago";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle9.Format = "n2";
            this.Pagox.DefaultCellStyle = dataGridViewCellStyle9;
            this.Pagox.HeaderText = "Pago";
            this.Pagox.MinimumWidth = 50;
            this.Pagox.Name = "Pagox";
            this.Pagox.Width = 57;
            // 
            // FechaEmision
            // 
            this.FechaEmision.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.FechaEmision.DataPropertyName = "FechaEmision";
            dataGridViewCellStyle10.Format = "g";
            this.FechaEmision.DefaultCellStyle = dataGridViewCellStyle10;
            this.FechaEmision.HeaderText = "Fecha Emisión";
            this.FechaEmision.MinimumWidth = 70;
            this.FechaEmision.Name = "FechaEmision";
            this.FechaEmision.ReadOnly = true;
            this.FechaEmision.Width = 70;
            // 
            // fechaRecepcion
            // 
            this.fechaRecepcion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.fechaRecepcion.DataPropertyName = "fechaRecepcion";
            dataGridViewCellStyle11.Format = "g";
            dataGridViewCellStyle11.NullValue = null;
            this.fechaRecepcion.DefaultCellStyle = dataGridViewCellStyle11;
            this.fechaRecepcion.HeaderText = "Fecha Recepción";
            this.fechaRecepcion.MinimumWidth = 80;
            this.fechaRecepcion.Name = "fechaRecepcion";
            this.fechaRecepcion.ReadOnly = true;
            this.fechaRecepcion.Width = 80;
            // 
            // FechaCancelado
            // 
            this.FechaCancelado.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.FechaCancelado.DataPropertyName = "FechaCancelado";
            dataGridViewCellStyle12.Format = "g";
            this.FechaCancelado.DefaultCellStyle = dataGridViewCellStyle12;
            this.FechaCancelado.HeaderText = "Fecha Cancelado";
            this.FechaCancelado.MinimumWidth = 70;
            this.FechaCancelado.Name = "FechaCancelado";
            this.FechaCancelado.ReadOnly = true;
            this.FechaCancelado.Width = 70;
            // 
            // nrofic1
            // 
            this.nrofic1.DataPropertyName = "nrofic";
            this.nrofic1.HeaderText = "nrofic";
            this.nrofic1.Name = "nrofic1";
            this.nrofic1.Visible = false;
            // 
            // centrocostox
            // 
            this.centrocostox.DataPropertyName = "centrocosto";
            this.centrocostox.HeaderText = "CentroCosto";
            this.centrocostox.Name = "centrocostox";
            this.centrocostox.Visible = false;
            // 
            // btnVer
            // 
            this.btnVer.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.btnVer.DataPropertyName = "ver";
            this.btnVer.HeaderText = "Ver";
            this.btnVer.MinimumWidth = 55;
            this.btnVer.Name = "btnVer";
            this.btnVer.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.btnVer.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.btnVer.Text = "";
            this.btnVer.Width = 55;
            // 
            // fkasientox
            // 
            this.fkasientox.DataPropertyName = "fkasiento";
            this.fkasientox.HeaderText = "fkasiento";
            this.fkasientox.Name = "fkasientox";
            this.fkasientox.Visible = false;
            // 
            // xidmoneda
            // 
            this.xidmoneda.DataPropertyName = "idmoneda";
            this.xidmoneda.HeaderText = "IDMONEDA";
            this.xidmoneda.Name = "xidmoneda";
            this.xidmoneda.Visible = false;
            // 
            // xCuentaContable
            // 
            this.xCuentaContable.DataPropertyName = "CuentaContable";
            this.xCuentaContable.HeaderText = "CuentaContable";
            this.xCuentaContable.Name = "xCuentaContable";
            this.xCuentaContable.Visible = false;
            // 
            // frmListarFacturasPagadas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1094, 466);
            this.Controls.Add(this.btnpdf);
            this.Controls.Add(this.lblmensaje);
            this.Controls.Add(this.cboempresa);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.btncancelar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Dtguias);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinimumSize = new System.Drawing.Size(1110, 505);
            this.Name = "frmListarFacturasPagadas";
            this.Nombre = "Listado de Facturas Pagadas";
            this.Text = "Listado de Facturas Pagadas";
            this.Load += new System.EventHandler(this.frmListarFacturasPagadas_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dtguias)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRefrescar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label10;
        private HpResergerUserControls.TextBoxPer txtbuscar;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DateTimePicker dtpfin;
        private System.Windows.Forms.DateTimePicker dtpini;
        private System.Windows.Forms.CheckBox chkrecepcion;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dtfin;
        private System.Windows.Forms.DateTimePicker dtinicio;
        private System.Windows.Forms.CheckBox chkfecha;
        private System.Windows.Forms.CheckBox chkprove;
        private HpResergerUserControls.Dtgconten Dtguias;
        private System.Windows.Forms.Button btncancelar;
        private System.Windows.Forms.ComboBox cboempresa;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblmensaje;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button btnpdf;
        private System.Windows.Forms.DataGridViewCheckBoxColumn OK;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipodoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn xidcomprobante;
        private System.Windows.Forms.DataGridViewTextBoxColumn nrofactura;
        private System.Windows.Forms.DataGridViewTextBoxColumn proveedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn razon;
        private System.Windows.Forms.DataGridViewTextBoxColumn monedax;
        private System.Windows.Forms.DataGridViewTextBoxColumn xtc;
        private System.Windows.Forms.DataGridViewTextBoxColumn subtotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn Igv;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private System.Windows.Forms.DataGridViewTextBoxColumn detraccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Saldox;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pagox;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaEmision;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaRecepcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaCancelado;
        private System.Windows.Forms.DataGridViewTextBoxColumn nrofic1;
        private System.Windows.Forms.DataGridViewTextBoxColumn centrocostox;
        private System.Windows.Forms.DataGridViewButtonColumn btnVer;
        private System.Windows.Forms.DataGridViewTextBoxColumn fkasientox;
        private System.Windows.Forms.DataGridViewTextBoxColumn xidmoneda;
        private System.Windows.Forms.DataGridViewTextBoxColumn xCuentaContable;
    }
}