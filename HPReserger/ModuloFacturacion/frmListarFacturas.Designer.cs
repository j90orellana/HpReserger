namespace HPReserger.ModuloFacturacion
{
    partial class frmListarFacturas
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lbltotalRegistros = new System.Windows.Forms.Label();
            this.dtpFechaHasta = new System.Windows.Forms.DateTimePicker();
            this.dtpfechade = new System.Windows.Forms.DateTimePicker();
            this.chkFecha = new HpResergerUserControls.checkboxOre();
            this.txtbusglosa = new HpResergerUserControls.TextBoxPer();
            this.txtbusproveedor = new HpResergerUserControls.TextBoxPer();
            this.txtbusNumFac = new HpResergerUserControls.TextBoxPer();
            this.txtbusEmpresa = new HpResergerUserControls.TextBoxPer();
            this.btnProcesar = new HpResergerUserControls.ButtonPer();
            this.BtnCerrar = new HpResergerUserControls.ButtonPer();
            this.dtgconten = new HpResergerUserControls.Dtgconten();
            this.label1 = new System.Windows.Forms.Label();
            this.btnbuscar = new HpResergerUserControls.ButtonPer();
            this.label4 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.xok = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.xpkempresa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xEmpresa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xpkfac = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xidcomprobante = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xnrocomprobante = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xFechaEmision = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xRuc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xRazon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xGlosa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xmoneda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xNMoneda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtTotal = new HpResergerUserControls.TextBoxPer();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgconten)).BeginInit();
            this.SuspendLayout();
            // 
            // lbltotalRegistros
            // 
            this.lbltotalRegistros.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbltotalRegistros.AutoSize = true;
            this.lbltotalRegistros.BackColor = System.Drawing.Color.Transparent;
            this.lbltotalRegistros.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltotalRegistros.Location = new System.Drawing.Point(12, 509);
            this.lbltotalRegistros.Name = "lbltotalRegistros";
            this.lbltotalRegistros.Size = new System.Drawing.Size(86, 13);
            this.lbltotalRegistros.TabIndex = 386;
            this.lbltotalRegistros.Text = "Total Registros:";
            // 
            // dtpFechaHasta
            // 
            this.dtpFechaHasta.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.dtpFechaHasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaHasta.Location = new System.Drawing.Point(559, 73);
            this.dtpFechaHasta.Name = "dtpFechaHasta";
            this.dtpFechaHasta.Size = new System.Drawing.Size(83, 22);
            this.dtpFechaHasta.TabIndex = 5;
            this.dtpFechaHasta.ValueChanged += new System.EventHandler(this.dtpFechaHasta_ValueChanged);
            // 
            // dtpfechade
            // 
            this.dtpfechade.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.dtpfechade.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpfechade.Location = new System.Drawing.Point(459, 73);
            this.dtpfechade.Name = "dtpfechade";
            this.dtpfechade.Size = new System.Drawing.Size(83, 22);
            this.dtpfechade.TabIndex = 4;
            this.dtpfechade.ValueChanged += new System.EventHandler(this.dtpfechade_ValueChanged);
            // 
            // chkFecha
            // 
            this.chkFecha.AutoSize = true;
            this.chkFecha.BackColor = System.Drawing.Color.Transparent;
            this.chkFecha.ColorChecked = System.Drawing.Color.Empty;
            this.chkFecha.ColorUnChecked = System.Drawing.Color.Empty;
            this.chkFecha.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.chkFecha.Location = new System.Drawing.Point(380, 76);
            this.chkFecha.Name = "chkFecha";
            this.chkFecha.Size = new System.Drawing.Size(79, 17);
            this.chkFecha.TabIndex = 383;
            this.chkFecha.Text = "Fecha: De:";
            this.chkFecha.UseVisualStyleBackColor = false;
            this.chkFecha.CheckedChanged += new System.EventHandler(this.chkFecha_CheckedChanged);
            // 
            // txtbusglosa
            // 
            this.txtbusglosa.BackColor = System.Drawing.Color.White;
            this.txtbusglosa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtbusglosa.ColorFondoMouseEncima = System.Drawing.Color.Empty;
            this.txtbusglosa.ColorFondoMousePresionado = System.Drawing.Color.Empty;
            this.txtbusglosa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbusglosa.ForeColor = System.Drawing.Color.Black;
            this.txtbusglosa.Format = null;
            this.txtbusglosa.Location = new System.Drawing.Point(15, 74);
            this.txtbusglosa.MaxLength = 300;
            this.txtbusglosa.Name = "txtbusglosa";
            this.txtbusglosa.NextControlOnEnter = null;
            this.txtbusglosa.Size = new System.Drawing.Size(352, 21);
            this.txtbusglosa.TabIndex = 3;
            this.txtbusglosa.Text = "Busqueda Por Glosa";
            this.txtbusglosa.TextoDefecto = "Busqueda Por Glosa";
            this.txtbusglosa.TextoDefectoColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(129)))), ((int)(((byte)(189)))));
            this.txtbusglosa.TiposDatos = HpResergerUserControls.TextBoxPer.ListaTipos.MayusculaCadaPalabra;
            this.txtbusglosa.OnPresionarEnter += new System.Windows.Forms.KeyPressEventHandler(this.txtbusEmpresa_OnPresionarEnter_1);
            this.txtbusglosa.TextChanged += new System.EventHandler(this.txtbusglosa_TextChanged);
            // 
            // txtbusproveedor
            // 
            this.txtbusproveedor.BackColor = System.Drawing.Color.White;
            this.txtbusproveedor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtbusproveedor.ColorFondoMouseEncima = System.Drawing.Color.Empty;
            this.txtbusproveedor.ColorFondoMousePresionado = System.Drawing.Color.Empty;
            this.txtbusproveedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbusproveedor.ForeColor = System.Drawing.Color.Black;
            this.txtbusproveedor.Format = null;
            this.txtbusproveedor.Location = new System.Drawing.Point(226, 49);
            this.txtbusproveedor.MaxLength = 300;
            this.txtbusproveedor.Name = "txtbusproveedor";
            this.txtbusproveedor.NextControlOnEnter = null;
            this.txtbusproveedor.Size = new System.Drawing.Size(416, 21);
            this.txtbusproveedor.TabIndex = 2;
            this.txtbusproveedor.Text = "Busqueda Por Proveedor";
            this.txtbusproveedor.TextoDefecto = "Busqueda Por Proveedor";
            this.txtbusproveedor.TextoDefectoColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(129)))), ((int)(((byte)(189)))));
            this.txtbusproveedor.TiposDatos = HpResergerUserControls.TextBoxPer.ListaTipos.MayusculaCadaPalabra;
            this.txtbusproveedor.OnPresionarEnter += new System.Windows.Forms.KeyPressEventHandler(this.txtbusEmpresa_OnPresionarEnter_1);
            this.txtbusproveedor.TextChanged += new System.EventHandler(this.txtbusproveedor_TextChanged);
            // 
            // txtbusNumFac
            // 
            this.txtbusNumFac.BackColor = System.Drawing.Color.White;
            this.txtbusNumFac.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtbusNumFac.ColorFondoMouseEncima = System.Drawing.Color.Empty;
            this.txtbusNumFac.ColorFondoMousePresionado = System.Drawing.Color.Empty;
            this.txtbusNumFac.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbusNumFac.ForeColor = System.Drawing.Color.Black;
            this.txtbusNumFac.Format = null;
            this.txtbusNumFac.Location = new System.Drawing.Point(15, 49);
            this.txtbusNumFac.MaxLength = 300;
            this.txtbusNumFac.Name = "txtbusNumFac";
            this.txtbusNumFac.NextControlOnEnter = null;
            this.txtbusNumFac.Size = new System.Drawing.Size(205, 21);
            this.txtbusNumFac.TabIndex = 1;
            this.txtbusNumFac.Text = "Busqueda Por Factura";
            this.txtbusNumFac.TextoDefecto = "Busqueda Por Factura";
            this.txtbusNumFac.TextoDefectoColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(129)))), ((int)(((byte)(189)))));
            this.txtbusNumFac.TiposDatos = HpResergerUserControls.TextBoxPer.ListaTipos.MayusculaCadaPalabra;
            this.txtbusNumFac.OnPresionarEnter += new System.Windows.Forms.KeyPressEventHandler(this.txtbusEmpresa_OnPresionarEnter_1);
            this.txtbusNumFac.TextChanged += new System.EventHandler(this.txtbusNumFac_TextChanged);
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
            this.txtbusEmpresa.Location = new System.Drawing.Point(15, 25);
            this.txtbusEmpresa.MaxLength = 300;
            this.txtbusEmpresa.Name = "txtbusEmpresa";
            this.txtbusEmpresa.NextControlOnEnter = null;
            this.txtbusEmpresa.Size = new System.Drawing.Size(627, 21);
            this.txtbusEmpresa.TabIndex = 0;
            this.txtbusEmpresa.Text = "Busqueda Por Empresa";
            this.txtbusEmpresa.TextoDefecto = "Busqueda Por Empresa";
            this.txtbusEmpresa.TextoDefectoColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(129)))), ((int)(((byte)(189)))));
            this.txtbusEmpresa.TiposDatos = HpResergerUserControls.TextBoxPer.ListaTipos.MayusculaCadaPalabra;
            this.txtbusEmpresa.OnPresionarEnter += new System.Windows.Forms.KeyPressEventHandler(this.txtbusEmpresa_OnPresionarEnter_1);
            this.txtbusEmpresa.TextChanged += new System.EventHandler(this.txtbusEmpresa_TextChanged);
            // 
            // btnProcesar
            // 
            this.btnProcesar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnProcesar.BackColor = System.Drawing.Color.SeaGreen;
            this.btnProcesar.FlatAppearance.BorderColor = System.Drawing.Color.Olive;
            this.btnProcesar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProcesar.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProcesar.ForeColor = System.Drawing.Color.White;
            this.btnProcesar.Location = new System.Drawing.Point(793, 499);
            this.btnProcesar.Name = "btnProcesar";
            this.btnProcesar.Size = new System.Drawing.Size(83, 23);
            this.btnProcesar.TabIndex = 6;
            this.btnProcesar.Text = "OK";
            this.btnProcesar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnProcesar.UseVisualStyleBackColor = false;
            this.btnProcesar.Click += new System.EventHandler(this.btnProcesar_Click);
            // 
            // BtnCerrar
            // 
            this.BtnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnCerrar.BackColor = System.Drawing.Color.Crimson;
            this.BtnCerrar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnCerrar.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.BtnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCerrar.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCerrar.ForeColor = System.Drawing.Color.White;
            this.BtnCerrar.Location = new System.Drawing.Point(879, 499);
            this.BtnCerrar.Name = "BtnCerrar";
            this.BtnCerrar.Size = new System.Drawing.Size(83, 23);
            this.BtnCerrar.TabIndex = 7;
            this.BtnCerrar.Text = "Cancelar";
            this.BtnCerrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnCerrar.UseVisualStyleBackColor = false;
            this.BtnCerrar.Click += new System.EventHandler(this.BtnCerrar_Click);
            // 
            // dtgconten
            // 
            this.dtgconten.AllowUserToAddRows = false;
            this.dtgconten.AllowUserToOrderColumns = true;
            this.dtgconten.AllowUserToResizeColumns = false;
            this.dtgconten.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(230)))), ((int)(((byte)(241)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(191)))), ((int)(((byte)(231)))));
            this.dtgconten.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgconten.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgconten.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgconten.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtgconten.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(218)))), ((int)(((byte)(231)))));
            this.dtgconten.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgconten.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.dtgconten.CheckColumna = "xok";
            this.dtgconten.CheckValor = 1;
            this.dtgconten.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(129)))), ((int)(((byte)(189)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DeepSkyBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgconten.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dtgconten.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgconten.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.xok,
            this.xpkempresa,
            this.xEmpresa,
            this.xpkfac,
            this.xidcomprobante,
            this.xnrocomprobante,
            this.xFechaEmision,
            this.xRuc,
            this.xRazon,
            this.xGlosa,
            this.xmoneda,
            this.xNMoneda,
            this.xTotal});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(207)))), ((int)(((byte)(241)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgconten.DefaultCellStyle = dataGridViewCellStyle5;
            this.dtgconten.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dtgconten.EnableHeadersVisualStyles = false;
            this.dtgconten.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(179)))), ((int)(((byte)(215)))));
            this.dtgconten.Location = new System.Drawing.Point(15, 113);
            this.dtgconten.Name = "dtgconten";
            this.dtgconten.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgconten.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dtgconten.RowHeadersVisible = false;
            this.dtgconten.RowTemplate.Height = 18;
            this.dtgconten.Size = new System.Drawing.Size(947, 380);
            this.dtgconten.TabIndex = 379;
            this.dtgconten.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgconten_CellContentClick);
            this.dtgconten.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgconten_CellContentDoubleClick);
            this.dtgconten.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgconten_CellValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 13);
            this.label1.TabIndex = 378;
            this.label1.Text = "Listado de Facturas de Compras:";
            // 
            // btnbuscar
            // 
            this.btnbuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(129)))), ((int)(((byte)(189)))));
            this.btnbuscar.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnbuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnbuscar.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnbuscar.ForeColor = System.Drawing.Color.White;
            this.btnbuscar.Location = new System.Drawing.Point(650, 73);
            this.btnbuscar.Margin = new System.Windows.Forms.Padding(0);
            this.btnbuscar.Name = "btnbuscar";
            this.btnbuscar.Size = new System.Drawing.Size(75, 22);
            this.btnbuscar.TabIndex = 377;
            this.btnbuscar.Tag = "1";
            this.btnbuscar.Text = "Buscar";
            this.btnbuscar.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnbuscar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnbuscar.UseVisualStyleBackColor = false;
            this.btnbuscar.Click += new System.EventHandler(this.btnbuscar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(208, 13);
            this.label4.TabIndex = 376;
            this.label4.Text = "1.- Ingrese Filtros para Buscar Facturas:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(542, 78);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(17, 13);
            this.label10.TabIndex = 375;
            this.label10.Text = "A:";
            // 
            // xok
            // 
            this.xok.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.xok.DataPropertyName = "ok";
            this.xok.FalseValue = "0";
            this.xok.HeaderText = "Ok";
            this.xok.MinimumWidth = 25;
            this.xok.Name = "xok";
            this.xok.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.xok.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.xok.TrueValue = "1";
            this.xok.Width = 25;
            // 
            // xpkempresa
            // 
            this.xpkempresa.DataPropertyName = "pkempresa";
            this.xpkempresa.HeaderText = "pkempresa";
            this.xpkempresa.Name = "xpkempresa";
            this.xpkempresa.ReadOnly = true;
            this.xpkempresa.Visible = false;
            // 
            // xEmpresa
            // 
            this.xEmpresa.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.xEmpresa.DataPropertyName = "empresa";
            this.xEmpresa.HeaderText = "Empresa";
            this.xEmpresa.MinimumWidth = 100;
            this.xEmpresa.Name = "xEmpresa";
            this.xEmpresa.ReadOnly = true;
            // 
            // xpkfac
            // 
            this.xpkfac.DataPropertyName = "pkfac";
            this.xpkfac.HeaderText = "pkfac";
            this.xpkfac.Name = "xpkfac";
            this.xpkfac.Visible = false;
            // 
            // xidcomprobante
            // 
            this.xidcomprobante.DataPropertyName = "idcomprobante";
            this.xidcomprobante.HeaderText = "idcomprobante";
            this.xidcomprobante.Name = "xidcomprobante";
            this.xidcomprobante.Visible = false;
            // 
            // xnrocomprobante
            // 
            this.xnrocomprobante.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.xnrocomprobante.DataPropertyName = "nrocomprobante";
            this.xnrocomprobante.HeaderText = "NumFac";
            this.xnrocomprobante.MinimumWidth = 60;
            this.xnrocomprobante.Name = "xnrocomprobante";
            this.xnrocomprobante.ReadOnly = true;
            this.xnrocomprobante.Width = 60;
            // 
            // xFechaEmision
            // 
            this.xFechaEmision.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.xFechaEmision.DataPropertyName = "fechaemision";
            dataGridViewCellStyle3.Format = "d";
            this.xFechaEmision.DefaultCellStyle = dataGridViewCellStyle3;
            this.xFechaEmision.HeaderText = "Fec.Emision";
            this.xFechaEmision.MinimumWidth = 65;
            this.xFechaEmision.Name = "xFechaEmision";
            this.xFechaEmision.ReadOnly = true;
            this.xFechaEmision.Width = 65;
            // 
            // xRuc
            // 
            this.xRuc.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.xRuc.DataPropertyName = "proveedor";
            this.xRuc.HeaderText = "RUC";
            this.xRuc.MinimumWidth = 80;
            this.xRuc.Name = "xRuc";
            this.xRuc.ReadOnly = true;
            this.xRuc.Width = 80;
            // 
            // xRazon
            // 
            this.xRazon.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.xRazon.DataPropertyName = "razon";
            this.xRazon.HeaderText = "RazonSocial";
            this.xRazon.Name = "xRazon";
            this.xRazon.ReadOnly = true;
            // 
            // xGlosa
            // 
            this.xGlosa.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.xGlosa.DataPropertyName = "glosa";
            this.xGlosa.HeaderText = "Glosa";
            this.xGlosa.Name = "xGlosa";
            this.xGlosa.ReadOnly = true;
            // 
            // xmoneda
            // 
            this.xmoneda.DataPropertyName = "moneda";
            this.xmoneda.HeaderText = "moneda";
            this.xmoneda.Name = "xmoneda";
            this.xmoneda.Visible = false;
            // 
            // xNMoneda
            // 
            this.xNMoneda.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.xNMoneda.DataPropertyName = "nmoneda";
            this.xNMoneda.HeaderText = "Mon.";
            this.xNMoneda.MinimumWidth = 40;
            this.xNMoneda.Name = "xNMoneda";
            this.xNMoneda.ReadOnly = true;
            this.xNMoneda.Width = 40;
            // 
            // xTotal
            // 
            this.xTotal.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.xTotal.DataPropertyName = "total";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle4.Format = "n2";
            this.xTotal.DefaultCellStyle = dataGridViewCellStyle4;
            this.xTotal.HeaderText = "Total";
            this.xTotal.MinimumWidth = 50;
            this.xTotal.Name = "xTotal";
            this.xTotal.ReadOnly = true;
            this.xTotal.Width = 50;
            // 
            // txtTotal
            // 
            this.txtTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTotal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(218)))), ((int)(((byte)(231)))));
            this.txtTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTotal.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtTotal.ColorFondoMouseEncima = System.Drawing.Color.Empty;
            this.txtTotal.ColorFondoMousePresionado = System.Drawing.Color.Empty;
            this.txtTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.ForeColor = System.Drawing.Color.Black;
            this.txtTotal.Format = null;
            this.txtTotal.Location = new System.Drawing.Point(846, 89);
            this.txtTotal.MaxLength = 300;
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.NextControlOnEnter = null;
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(116, 21);
            this.txtTotal.TabIndex = 387;
            this.txtTotal.Text = "0.00";
            this.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtTotal.TextoDefecto = "0.00";
            this.txtTotal.TextoDefectoColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(129)))), ((int)(((byte)(189)))));
            this.txtTotal.TiposDatos = HpResergerUserControls.TextBoxPer.ListaTipos.MayusculaCadaPalabra;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(811, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 375;
            this.label2.Text = "Total:";
            // 
            // frmListarFacturas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(974, 531);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.lbltotalRegistros);
            this.Controls.Add(this.dtpFechaHasta);
            this.Controls.Add(this.dtpfechade);
            this.Controls.Add(this.chkFecha);
            this.Controls.Add(this.txtbusglosa);
            this.Controls.Add(this.txtbusproveedor);
            this.Controls.Add(this.txtbusNumFac);
            this.Controls.Add(this.txtbusEmpresa);
            this.Controls.Add(this.btnProcesar);
            this.Controls.Add(this.BtnCerrar);
            this.Controls.Add(this.dtgconten);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnbuscar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label10);
            this.MinimumSize = new System.Drawing.Size(990, 570);
            this.Name = "frmListarFacturas";
            this.Nombre = "Listado de Facturas de Compra";
            this.Text = "Listado de Facturas de Compra";
            this.Load += new System.EventHandler(this.frmListarFacturas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgconten)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpFechaHasta;
        private System.Windows.Forms.DateTimePicker dtpfechade;
        private HpResergerUserControls.checkboxOre chkFecha;
        private HpResergerUserControls.TextBoxPer txtbusEmpresa;
        private HpResergerUserControls.ButtonPer btnProcesar;
        private HpResergerUserControls.ButtonPer BtnCerrar;
        private HpResergerUserControls.Dtgconten dtgconten;
        private System.Windows.Forms.Label label1;
        private HpResergerUserControls.ButtonPer btnbuscar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lbltotalRegistros;
        private HpResergerUserControls.TextBoxPer txtbusNumFac;
        private HpResergerUserControls.TextBoxPer txtbusproveedor;
        private HpResergerUserControls.TextBoxPer txtbusglosa;
        private System.Windows.Forms.DataGridViewCheckBoxColumn xok;
        private System.Windows.Forms.DataGridViewTextBoxColumn xpkempresa;
        private System.Windows.Forms.DataGridViewTextBoxColumn xEmpresa;
        private System.Windows.Forms.DataGridViewTextBoxColumn xpkfac;
        private System.Windows.Forms.DataGridViewTextBoxColumn xidcomprobante;
        private System.Windows.Forms.DataGridViewTextBoxColumn xnrocomprobante;
        private System.Windows.Forms.DataGridViewTextBoxColumn xFechaEmision;
        private System.Windows.Forms.DataGridViewTextBoxColumn xRuc;
        private System.Windows.Forms.DataGridViewTextBoxColumn xRazon;
        private System.Windows.Forms.DataGridViewTextBoxColumn xGlosa;
        private System.Windows.Forms.DataGridViewTextBoxColumn xmoneda;
        private System.Windows.Forms.DataGridViewTextBoxColumn xNMoneda;
        private System.Windows.Forms.DataGridViewTextBoxColumn xTotal;
        private HpResergerUserControls.TextBoxPer txtTotal;
        private System.Windows.Forms.Label label2;
    }
}