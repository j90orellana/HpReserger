namespace HPReserger.ModuloFinanzas
{
    partial class frmPrestamosInterEmpresaListadoAbonados
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle24 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle22 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle23 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrestamosInterEmpresaListadoAbonados));
            this.dtgconten = new HpResergerUserControls.Dtgconten();
            this.xEmpresaOrigen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xbancoOrigen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xctaOrigenBanco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xCuoOrigen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xEmpresaDestino = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xBancoDestino = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xCtaBancoDestino = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xCuoDestino = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xMoneda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xMonto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xNroOperacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xFechaAbono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xGlosa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btncancelar = new System.Windows.Forms.Button();
            this.lblmsg = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnexcel = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.btncleanfind = new System.Windows.Forms.Button();
            this.txtbusMoneda = new HpResergerUserControls.TextBoxPer();
            this.txtbusempresadestino = new HpResergerUserControls.TextBoxPer();
            this.txtbusempresaorigen = new HpResergerUserControls.TextBoxPer();
            this.btnCambiar = new System.Windows.Forms.Button();
            this.dtpfechabus2 = new System.Windows.Forms.DateTimePicker();
            this.dtpfechabus1 = new System.Windows.Forms.DateTimePicker();
            this.label23 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgconten)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgconten
            // 
            this.dtgconten.AllowUserToAddRows = false;
            this.dtgconten.AllowUserToOrderColumns = true;
            this.dtgconten.AllowUserToResizeColumns = false;
            this.dtgconten.AllowUserToResizeRows = false;
            dataGridViewCellStyle17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(230)))), ((int)(((byte)(241)))));
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(191)))), ((int)(((byte)(231)))));
            this.dtgconten.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle17;
            this.dtgconten.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgconten.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgconten.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(218)))), ((int)(((byte)(231)))));
            this.dtgconten.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgconten.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.dtgconten.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle18.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(129)))), ((int)(((byte)(189)))));
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle18.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.Color.DeepSkyBlue;
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgconten.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle18;
            this.dtgconten.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgconten.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.xEmpresaOrigen,
            this.xbancoOrigen,
            this.xctaOrigenBanco,
            this.xCuoOrigen,
            this.xEmpresaDestino,
            this.xBancoDestino,
            this.xCtaBancoDestino,
            this.xCuoDestino,
            this.xMoneda,
            this.xMonto,
            this.xNroOperacion,
            this.xFechaAbono,
            this.xGlosa});
            dataGridViewCellStyle24.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle24.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle24.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle24.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle24.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(207)))), ((int)(((byte)(241)))));
            dataGridViewCellStyle24.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle24.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgconten.DefaultCellStyle = dataGridViewCellStyle24;
            this.dtgconten.EnableHeadersVisualStyles = false;
            this.dtgconten.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(179)))), ((int)(((byte)(215)))));
            this.dtgconten.Location = new System.Drawing.Point(12, 52);
            this.dtgconten.Name = "dtgconten";
            this.dtgconten.ReadOnly = true;
            this.dtgconten.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dtgconten.RowHeadersVisible = false;
            this.dtgconten.RowTemplate.Height = 18;
            this.dtgconten.Size = new System.Drawing.Size(960, 273);
            this.dtgconten.TabIndex = 397;
            this.dtgconten.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgconten_CellContentClick);
            // 
            // xEmpresaOrigen
            // 
            this.xEmpresaOrigen.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.xEmpresaOrigen.DataPropertyName = "empresaorigen";
            this.xEmpresaOrigen.HeaderText = "EmpresaOrigen";
            this.xEmpresaOrigen.Name = "xEmpresaOrigen";
            this.xEmpresaOrigen.ReadOnly = true;
            this.xEmpresaOrigen.Width = 110;
            // 
            // xbancoOrigen
            // 
            this.xbancoOrigen.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.xbancoOrigen.DataPropertyName = "BancoOrigen";
            this.xbancoOrigen.HeaderText = "BancoOrigen";
            this.xbancoOrigen.MinimumWidth = 100;
            this.xbancoOrigen.Name = "xbancoOrigen";
            this.xbancoOrigen.ReadOnly = true;
            // 
            // xctaOrigenBanco
            // 
            this.xctaOrigenBanco.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.xctaOrigenBanco.DataPropertyName = "CtaBancoOrigen";
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.xctaOrigenBanco.DefaultCellStyle = dataGridViewCellStyle19;
            this.xctaOrigenBanco.FillWeight = 563.1068F;
            this.xctaOrigenBanco.HeaderText = "CtaBancoOrigen";
            this.xctaOrigenBanco.MinimumWidth = 90;
            this.xctaOrigenBanco.Name = "xctaOrigenBanco";
            this.xctaOrigenBanco.ReadOnly = true;
            this.xctaOrigenBanco.Width = 116;
            // 
            // xCuoOrigen
            // 
            this.xCuoOrigen.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.xCuoOrigen.DataPropertyName = "CuoOrigen";
            this.xCuoOrigen.FillWeight = 48.54369F;
            this.xCuoOrigen.HeaderText = "CuoOrigen";
            this.xCuoOrigen.MinimumWidth = 70;
            this.xCuoOrigen.Name = "xCuoOrigen";
            this.xCuoOrigen.ReadOnly = true;
            this.xCuoOrigen.Width = 70;
            // 
            // xEmpresaDestino
            // 
            this.xEmpresaDestino.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.xEmpresaDestino.DataPropertyName = "empresadestino";
            this.xEmpresaDestino.HeaderText = "EmpresaDestino";
            this.xEmpresaDestino.Name = "xEmpresaDestino";
            this.xEmpresaDestino.ReadOnly = true;
            this.xEmpresaDestino.Width = 114;
            // 
            // xBancoDestino
            // 
            this.xBancoDestino.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.xBancoDestino.DataPropertyName = "BancoDestino";
            this.xBancoDestino.FillWeight = 48.54369F;
            this.xBancoDestino.HeaderText = "BancoDestino";
            this.xBancoDestino.MinimumWidth = 100;
            this.xBancoDestino.Name = "xBancoDestino";
            this.xBancoDestino.ReadOnly = true;
            this.xBancoDestino.Width = 103;
            // 
            // xCtaBancoDestino
            // 
            this.xCtaBancoDestino.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.xCtaBancoDestino.DataPropertyName = "CtaBancoDestino";
            this.xCtaBancoDestino.FillWeight = 48.54369F;
            this.xCtaBancoDestino.HeaderText = "CtaBancoDestino";
            this.xCtaBancoDestino.Name = "xCtaBancoDestino";
            this.xCtaBancoDestino.ReadOnly = true;
            this.xCtaBancoDestino.Width = 120;
            // 
            // xCuoDestino
            // 
            this.xCuoDestino.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.xCuoDestino.DataPropertyName = "CuoDestino";
            dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.xCuoDestino.DefaultCellStyle = dataGridViewCellStyle20;
            this.xCuoDestino.FillWeight = 48.54369F;
            this.xCuoDestino.HeaderText = "CuoDestino";
            this.xCuoDestino.MinimumWidth = 70;
            this.xCuoDestino.Name = "xCuoDestino";
            this.xCuoDestino.ReadOnly = true;
            this.xCuoDestino.Width = 70;
            // 
            // xMoneda
            // 
            this.xMoneda.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.xMoneda.DataPropertyName = "Moneda";
            dataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.xMoneda.DefaultCellStyle = dataGridViewCellStyle21;
            this.xMoneda.FillWeight = 48.54369F;
            this.xMoneda.HeaderText = "Moneda";
            this.xMoneda.MinimumWidth = 70;
            this.xMoneda.Name = "xMoneda";
            this.xMoneda.ReadOnly = true;
            this.xMoneda.Width = 70;
            // 
            // xMonto
            // 
            this.xMonto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.xMonto.DataPropertyName = "Monto";
            dataGridViewCellStyle22.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle22.Format = "n2";
            this.xMonto.DefaultCellStyle = dataGridViewCellStyle22;
            this.xMonto.FillWeight = 48.54369F;
            this.xMonto.HeaderText = "Monto";
            this.xMonto.MinimumWidth = 60;
            this.xMonto.Name = "xMonto";
            this.xMonto.ReadOnly = true;
            this.xMonto.Width = 60;
            // 
            // xNroOperacion
            // 
            this.xNroOperacion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.xNroOperacion.DataPropertyName = "NroOperacion";
            this.xNroOperacion.FillWeight = 48.54369F;
            this.xNroOperacion.HeaderText = "NroOp.";
            this.xNroOperacion.Name = "xNroOperacion";
            this.xNroOperacion.ReadOnly = true;
            this.xNroOperacion.Width = 69;
            // 
            // xFechaAbono
            // 
            this.xFechaAbono.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.xFechaAbono.DataPropertyName = "FechaAbono";
            dataGridViewCellStyle23.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle23.Format = "dd/MM/yyyy";
            this.xFechaAbono.DefaultCellStyle = dataGridViewCellStyle23;
            this.xFechaAbono.FillWeight = 48.54369F;
            this.xFechaAbono.HeaderText = "Fecha Abono";
            this.xFechaAbono.MinimumWidth = 75;
            this.xFechaAbono.Name = "xFechaAbono";
            this.xFechaAbono.ReadOnly = true;
            this.xFechaAbono.Width = 75;
            // 
            // xGlosa
            // 
            this.xGlosa.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.xGlosa.DataPropertyName = "glosa";
            this.xGlosa.FillWeight = 48.54369F;
            this.xGlosa.HeaderText = "Glosa";
            this.xGlosa.MinimumWidth = 100;
            this.xGlosa.Name = "xGlosa";
            this.xGlosa.ReadOnly = true;
            // 
            // btncancelar
            // 
            this.btncancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btncancelar.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncancelar.Image = ((System.Drawing.Image)(resources.GetObject("btncancelar.Image")));
            this.btncancelar.Location = new System.Drawing.Point(887, 331);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(85, 23);
            this.btncancelar.TabIndex = 398;
            this.btncancelar.Text = "Cancelar";
            this.btncancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btncancelar.UseVisualStyleBackColor = true;
            this.btncancelar.Click += new System.EventHandler(this.btncancelar_Click);
            // 
            // lblmsg
            // 
            this.lblmsg.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblmsg.AutoSize = true;
            this.lblmsg.BackColor = System.Drawing.Color.Transparent;
            this.lblmsg.Location = new System.Drawing.Point(12, 336);
            this.lblmsg.Name = "lblmsg";
            this.lblmsg.Size = new System.Drawing.Size(113, 13);
            this.lblmsg.TabIndex = 399;
            this.lblmsg.Text = "Total de Registros : 0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 13);
            this.label3.TabIndex = 400;
            this.label3.Text = "Listado de Abonos:";
            // 
            // btnActualizar
            // 
            this.btnActualizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnActualizar.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizar.Image = ((System.Drawing.Image)(resources.GetObject("btnActualizar.Image")));
            this.btnActualizar.Location = new System.Drawing.Point(880, 27);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(92, 23);
            this.btnActualizar.TabIndex = 406;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnexcel
            // 
            this.btnexcel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnexcel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnexcel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnexcel.Image = ((System.Drawing.Image)(resources.GetObject("btnexcel.Image")));
            this.btnexcel.Location = new System.Drawing.Point(451, 331);
            this.btnexcel.Name = "btnexcel";
            this.btnexcel.Size = new System.Drawing.Size(82, 23);
            this.btnexcel.TabIndex = 407;
            this.btnexcel.Text = "Excel";
            this.btnexcel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnexcel.UseVisualStyleBackColor = true;
            this.btnexcel.Click += new System.EventHandler(this.btnexcel_Click);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // btncleanfind
            // 
            this.btncleanfind.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btncleanfind.Image = ((System.Drawing.Image)(resources.GetObject("btncleanfind.Image")));
            this.btncleanfind.Location = new System.Drawing.Point(794, 28);
            this.btncleanfind.Name = "btncleanfind";
            this.btncleanfind.Size = new System.Drawing.Size(25, 23);
            this.btncleanfind.TabIndex = 412;
            this.btncleanfind.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btncleanfind.UseVisualStyleBackColor = true;
            this.btncleanfind.Click += new System.EventHandler(this.btncleanfind_Click);
            // 
            // txtbusMoneda
            // 
            this.txtbusMoneda.BackColor = System.Drawing.Color.White;
            this.txtbusMoneda.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtbusMoneda.ColorFondoMouseEncima = System.Drawing.Color.Empty;
            this.txtbusMoneda.ColorFondoMousePresionado = System.Drawing.Color.Empty;
            this.txtbusMoneda.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbusMoneda.ForeColor = System.Drawing.Color.Black;
            this.txtbusMoneda.Format = null;
            this.txtbusMoneda.Location = new System.Drawing.Point(384, 29);
            this.txtbusMoneda.MaxLength = 300;
            this.txtbusMoneda.Name = "txtbusMoneda";
            this.txtbusMoneda.NextControlOnEnter = null;
            this.txtbusMoneda.Size = new System.Drawing.Size(113, 21);
            this.txtbusMoneda.TabIndex = 411;
            this.txtbusMoneda.Text = "Buscar Moneda";
            this.txtbusMoneda.TextoDefecto = "Buscar Moneda";
            this.txtbusMoneda.TextoDefectoColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(129)))), ((int)(((byte)(189)))));
            this.txtbusMoneda.TiposDatos = HpResergerUserControls.TextBoxPer.ListaTipos.MayusculaCadaPalabra;
            this.txtbusMoneda.TextChanged += new System.EventHandler(this.txtbusMoneda_TextChanged);
            // 
            // txtbusempresadestino
            // 
            this.txtbusempresadestino.BackColor = System.Drawing.Color.White;
            this.txtbusempresadestino.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtbusempresadestino.ColorFondoMouseEncima = System.Drawing.Color.Empty;
            this.txtbusempresadestino.ColorFondoMousePresionado = System.Drawing.Color.Empty;
            this.txtbusempresadestino.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbusempresadestino.ForeColor = System.Drawing.Color.Black;
            this.txtbusempresadestino.Format = null;
            this.txtbusempresadestino.Location = new System.Drawing.Point(205, 29);
            this.txtbusempresadestino.MaxLength = 300;
            this.txtbusempresadestino.Name = "txtbusempresadestino";
            this.txtbusempresadestino.NextControlOnEnter = null;
            this.txtbusempresadestino.Size = new System.Drawing.Size(177, 21);
            this.txtbusempresadestino.TabIndex = 409;
            this.txtbusempresadestino.Text = "Buscar Empresa Destino";
            this.txtbusempresadestino.TextoDefecto = "Buscar Empresa Destino";
            this.txtbusempresadestino.TextoDefectoColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(129)))), ((int)(((byte)(189)))));
            this.txtbusempresadestino.TiposDatos = HpResergerUserControls.TextBoxPer.ListaTipos.MayusculaCadaPalabra;
            this.txtbusempresadestino.TextChanged += new System.EventHandler(this.txtbusempresadestino_TextChanged);
            // 
            // txtbusempresaorigen
            // 
            this.txtbusempresaorigen.BackColor = System.Drawing.Color.White;
            this.txtbusempresaorigen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtbusempresaorigen.ColorFondoMouseEncima = System.Drawing.Color.Empty;
            this.txtbusempresaorigen.ColorFondoMousePresionado = System.Drawing.Color.Empty;
            this.txtbusempresaorigen.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbusempresaorigen.ForeColor = System.Drawing.Color.Black;
            this.txtbusempresaorigen.Format = null;
            this.txtbusempresaorigen.Location = new System.Drawing.Point(12, 29);
            this.txtbusempresaorigen.MaxLength = 300;
            this.txtbusempresaorigen.Name = "txtbusempresaorigen";
            this.txtbusempresaorigen.NextControlOnEnter = null;
            this.txtbusempresaorigen.Size = new System.Drawing.Size(177, 21);
            this.txtbusempresaorigen.TabIndex = 408;
            this.txtbusempresaorigen.Text = "Buscar Empresa Origen";
            this.txtbusempresaorigen.TextoDefecto = "Buscar Empresa Origen";
            this.txtbusempresaorigen.TextoDefectoColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(129)))), ((int)(((byte)(189)))));
            this.txtbusempresaorigen.TiposDatos = HpResergerUserControls.TextBoxPer.ListaTipos.MayusculaCadaPalabra;
            this.txtbusempresaorigen.TextChanged += new System.EventHandler(this.txtbusempresaorigen_TextChanged);
            // 
            // btnCambiar
            // 
            this.btnCambiar.BackColor = System.Drawing.Color.Transparent;
            this.btnCambiar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCambiar.FlatAppearance.BorderSize = 0;
            this.btnCambiar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnCambiar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnCambiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCambiar.Image = ((System.Drawing.Image)(resources.GetObject("btnCambiar.Image")));
            this.btnCambiar.Location = new System.Drawing.Point(186, 29);
            this.btnCambiar.Name = "btnCambiar";
            this.btnCambiar.Size = new System.Drawing.Size(20, 20);
            this.btnCambiar.TabIndex = 410;
            this.btnCambiar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCambiar.UseVisualStyleBackColor = false;
            this.btnCambiar.Click += new System.EventHandler(this.btnCambiar_Click);
            // 
            // dtpfechabus2
            // 
            this.dtpfechabus2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpfechabus2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpfechabus2.Location = new System.Drawing.Point(697, 28);
            this.dtpfechabus2.MaxDate = new System.DateTime(3000, 12, 31, 0, 0, 0, 0);
            this.dtpfechabus2.MinDate = new System.DateTime(1950, 1, 1, 0, 0, 0, 0);
            this.dtpfechabus2.Name = "dtpfechabus2";
            this.dtpfechabus2.Size = new System.Drawing.Size(93, 22);
            this.dtpfechabus2.TabIndex = 414;
            this.dtpfechabus2.Value = new System.DateTime(2017, 4, 27, 9, 44, 35, 0);
            this.dtpfechabus2.ValueChanged += new System.EventHandler(this.dtpfechabus2_ValueChanged);
            // 
            // dtpfechabus1
            // 
            this.dtpfechabus1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpfechabus1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpfechabus1.Location = new System.Drawing.Point(601, 28);
            this.dtpfechabus1.MaxDate = new System.DateTime(3000, 12, 31, 0, 0, 0, 0);
            this.dtpfechabus1.MinDate = new System.DateTime(1950, 1, 1, 0, 0, 0, 0);
            this.dtpfechabus1.Name = "dtpfechabus1";
            this.dtpfechabus1.Size = new System.Drawing.Size(93, 22);
            this.dtpfechabus1.TabIndex = 413;
            this.dtpfechabus1.Value = new System.DateTime(2017, 4, 27, 9, 44, 35, 0);
            this.dtpfechabus1.ValueChanged += new System.EventHandler(this.dtpfechabus1_ValueChanged);
            // 
            // label23
            // 
            this.label23.AutoEllipsis = true;
            this.label23.AutoSize = true;
            this.label23.BackColor = System.Drawing.Color.Transparent;
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label23.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(129)))), ((int)(((byte)(189)))));
            this.label23.Location = new System.Drawing.Point(501, 32);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(100, 15);
            this.label23.TabIndex = 415;
            this.label23.Text = "Fecha Prestamo:";
            // 
            // frmPrestamosInterEmpresaListadoAbonados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 361);
            this.Controls.Add(this.dtpfechabus2);
            this.Controls.Add(this.dtpfechabus1);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.btncleanfind);
            this.Controls.Add(this.txtbusMoneda);
            this.Controls.Add(this.txtbusempresadestino);
            this.Controls.Add(this.txtbusempresaorigen);
            this.Controls.Add(this.btnCambiar);
            this.Controls.Add(this.btnexcel);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblmsg);
            this.Controls.Add(this.btncancelar);
            this.Controls.Add(this.dtgconten);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinimumSize = new System.Drawing.Size(1000, 400);
            this.Name = "frmPrestamosInterEmpresaListadoAbonados";
            this.Nombre = "Listado de Abonos de Prestamos InterEmpresa";
            this.Text = "Listado de Abonos de Prestamos InterEmpresa";
            this.Load += new System.EventHandler(this.frmPrestamosInterEmpresaListadoAbonados_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgconten)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private HpResergerUserControls.Dtgconten dtgconten;
        private System.Windows.Forms.DataGridViewTextBoxColumn xEmpresaOrigen;
        private System.Windows.Forms.DataGridViewTextBoxColumn xbancoOrigen;
        private System.Windows.Forms.DataGridViewTextBoxColumn xctaOrigenBanco;
        private System.Windows.Forms.DataGridViewTextBoxColumn xCuoOrigen;
        private System.Windows.Forms.DataGridViewTextBoxColumn xEmpresaDestino;
        private System.Windows.Forms.DataGridViewTextBoxColumn xBancoDestino;
        private System.Windows.Forms.DataGridViewTextBoxColumn xCtaBancoDestino;
        private System.Windows.Forms.DataGridViewTextBoxColumn xCuoDestino;
        private System.Windows.Forms.DataGridViewTextBoxColumn xMoneda;
        private System.Windows.Forms.DataGridViewTextBoxColumn xMonto;
        private System.Windows.Forms.DataGridViewTextBoxColumn xNroOperacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn xFechaAbono;
        private System.Windows.Forms.DataGridViewTextBoxColumn xGlosa;
        private System.Windows.Forms.Button btncancelar;
        private System.Windows.Forms.Label lblmsg;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnexcel;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button btncleanfind;
        private HpResergerUserControls.TextBoxPer txtbusMoneda;
        private HpResergerUserControls.TextBoxPer txtbusempresadestino;
        private HpResergerUserControls.TextBoxPer txtbusempresaorigen;
        private System.Windows.Forms.Button btnCambiar;
        private System.Windows.Forms.DateTimePicker dtpfechabus2;
        private System.Windows.Forms.DateTimePicker dtpfechabus1;
        private System.Windows.Forms.Label label23;
    }
}