namespace HPReserger.ModuloCompensaciones
{
    partial class frmAnticipoProveedores
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAnticipoProveedores));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            this.cboproyecto = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.separadorOre1 = new HpResergerUserControls.SeparadorOre();
            this.cboempresa = new System.Windows.Forms.ComboBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtglosa = new HpResergerUserControls.TextBoxPer();
            this.label8 = new System.Windows.Forms.Label();
            this.cboproveedor = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbomoneda = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txttipocambio = new HpResergerUserControls.TextBoxPer();
            this.dtpFechaContable = new System.Windows.Forms.DateTimePicker();
            this.label15 = new System.Windows.Forms.Label();
            this.dtpFechaCompensa = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.btnaceptar = new System.Windows.Forms.Button();
            this.btncancelar = new System.Windows.Forms.Button();
            this.lbltotalregistros = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtgconten = new HpResergerUserControls.Dtgconten();
            this.cbocuentabanco = new System.Windows.Forms.ComboBox();
            this.lblguia1 = new System.Windows.Forms.Label();
            this.cbobanco = new System.Windows.Forms.ComboBox();
            this.lblguia = new System.Windows.Forms.Label();
            this.txtImporteTotal = new HpResergerUserControls.TextBoxPer();
            this.label14 = new System.Windows.Forms.Label();
            this.separadorOre2 = new HpResergerUserControls.SeparadorOre();
            this.cbocuentaxpagar = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn = new HpResergerUserControls.ButtonPer();
            this.xpkid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xFkEmpresa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xNameTipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xTipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xTipoID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xtipodesc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xNumDoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xcliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xMontoMN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xMontoME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xCuo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xNumPago = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xFechaCompensa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xNameEstado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xcuentacontable = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtgconten)).BeginInit();
            this.SuspendLayout();
            // 
            // cboproyecto
            // 
            this.cboproyecto.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboproyecto.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboproyecto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(218)))), ((int)(((byte)(231)))));
            this.cboproyecto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboproyecto.FormattingEnabled = true;
            this.cboproyecto.Location = new System.Drawing.Point(477, 11);
            this.cboproyecto.Name = "cboproyecto";
            this.cboproyecto.Size = new System.Drawing.Size(253, 21);
            this.cboproyecto.TabIndex = 349;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.Transparent;
            this.label16.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(423, 15);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(54, 13);
            this.label16.TabIndex = 350;
            this.label16.Text = "Proyecto:";
            // 
            // separadorOre1
            // 
            this.separadorOre1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.separadorOre1.BackColor = System.Drawing.Color.Transparent;
            this.separadorOre1.Location = new System.Drawing.Point(-7, 33);
            this.separadorOre1.MaximumSize = new System.Drawing.Size(2000, 2);
            this.separadorOre1.MinimumSize = new System.Drawing.Size(0, 2);
            this.separadorOre1.Name = "separadorOre1";
            this.separadorOre1.Size = new System.Drawing.Size(948, 2);
            this.separadorOre1.TabIndex = 348;
            // 
            // cboempresa
            // 
            this.cboempresa.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboempresa.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboempresa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(218)))), ((int)(((byte)(231)))));
            this.cboempresa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboempresa.DropDownWidth = 250;
            this.cboempresa.FormattingEnabled = true;
            this.cboempresa.Location = new System.Drawing.Point(78, 11);
            this.cboempresa.Name = "cboempresa";
            this.cboempresa.Size = new System.Drawing.Size(344, 21);
            this.cboempresa.TabIndex = 346;
            this.cboempresa.SelectedIndexChanged += new System.EventHandler(this.cboempresa_SelectedIndexChanged);
            this.cboempresa.SelectedValueChanged += new System.EventHandler(this.cboempresa_SelectedValueChanged);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.BackColor = System.Drawing.Color.Transparent;
            this.label18.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(26, 14);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(53, 13);
            this.label18.TabIndex = 347;
            this.label18.Text = "Empresa:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(10, 38);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(209, 13);
            this.label7.TabIndex = 351;
            this.label7.Text = "Opciones para el Anticipo al Proveedor";
            // 
            // txtglosa
            // 
            this.txtglosa.BackColor = System.Drawing.Color.White;
            this.txtglosa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtglosa.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtglosa.ColorFondoMouseEncima = System.Drawing.Color.Empty;
            this.txtglosa.ColorFondoMousePresionado = System.Drawing.Color.Empty;
            this.txtglosa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtglosa.ForeColor = System.Drawing.Color.Black;
            this.txtglosa.Format = null;
            this.txtglosa.Location = new System.Drawing.Point(477, 54);
            this.txtglosa.MaxLength = 300;
            this.txtglosa.Name = "txtglosa";
            this.txtglosa.NextControlOnEnter = null;
            this.txtglosa.Size = new System.Drawing.Size(445, 21);
            this.txtglosa.TabIndex = 354;
            this.txtglosa.Text = "INGRESE LA GLOSA DEL ANTICIPO";
            this.txtglosa.TextoDefecto = "INGRESE LA GLOSA DEL ANTICIPO";
            this.txtglosa.TextoDefectoColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(129)))), ((int)(((byte)(189)))));
            this.txtglosa.TiposDatos = HpResergerUserControls.TextBoxPer.ListaTipos.MayusculaCadaPalabra;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(436, 58);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(39, 13);
            this.label8.TabIndex = 355;
            this.label8.Text = "Glosa:";
            // 
            // cboproveedor
            // 
            this.cboproveedor.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboproveedor.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboproveedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(218)))), ((int)(((byte)(231)))));
            this.cboproveedor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboproveedor.DropDownWidth = 250;
            this.cboproveedor.FormattingEnabled = true;
            this.cboproveedor.Location = new System.Drawing.Point(78, 54);
            this.cboproveedor.Name = "cboproveedor";
            this.cboproveedor.Size = new System.Drawing.Size(344, 21);
            this.cboproveedor.TabIndex = 352;
            this.cboproveedor.SelectedIndexChanged += new System.EventHandler(this.cboempleado_SelectedIndexChanged);
            this.cboproveedor.Click += new System.EventHandler(this.cboempleado_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 353;
            this.label1.Text = "Proveedor:";
            // 
            // cbomoneda
            // 
            this.cbomoneda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(218)))), ((int)(((byte)(231)))));
            this.cbomoneda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbomoneda.FormattingEnabled = true;
            this.cbomoneda.Location = new System.Drawing.Point(78, 78);
            this.cbomoneda.Name = "cbomoneda";
            this.cbomoneda.Size = new System.Drawing.Size(163, 21);
            this.cbomoneda.TabIndex = 362;
            this.cbomoneda.SelectedIndexChanged += new System.EventHandler(this.cbomoneda_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(26, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 363;
            this.label4.Text = "Moneda:";
            // 
            // txttipocambio
            // 
            this.txttipocambio.BackColor = System.Drawing.Color.White;
            this.txttipocambio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txttipocambio.ColorFondoMouseEncima = System.Drawing.Color.Empty;
            this.txttipocambio.ColorFondoMousePresionado = System.Drawing.Color.Empty;
            this.txttipocambio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttipocambio.ForeColor = System.Drawing.Color.Black;
            this.txttipocambio.Format = "n3";
            this.txttipocambio.Location = new System.Drawing.Point(477, 78);
            this.txttipocambio.MaxLength = 10;
            this.txttipocambio.Name = "txttipocambio";
            this.txttipocambio.NextControlOnEnter = null;
            this.txttipocambio.Size = new System.Drawing.Size(50, 21);
            this.txttipocambio.TabIndex = 360;
            this.txttipocambio.Text = "3.300";
            this.txttipocambio.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txttipocambio.TextoDefecto = "3.300";
            this.txttipocambio.TextoDefectoColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(129)))), ((int)(((byte)(189)))));
            this.txttipocambio.TiposDatos = HpResergerUserControls.TextBoxPer.ListaTipos.SoloDinero;
            // 
            // dtpFechaContable
            // 
            this.dtpFechaContable.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaContable.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFechaContable.Location = new System.Drawing.Point(829, 77);
            this.dtpFechaContable.MaxDate = new System.DateTime(3000, 12, 31, 0, 0, 0, 0);
            this.dtpFechaContable.MinDate = new System.DateTime(1950, 1, 1, 0, 0, 0, 0);
            this.dtpFechaContable.Name = "dtpFechaContable";
            this.dtpFechaContable.Size = new System.Drawing.Size(93, 22);
            this.dtpFechaContable.TabIndex = 356;
            this.dtpFechaContable.Value = new System.DateTime(2017, 4, 27, 9, 44, 35, 0);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(738, 82);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(90, 13);
            this.label15.TabIndex = 358;
            this.label15.Text = "Fecha Contable:";
            // 
            // dtpFechaCompensa
            // 
            this.dtpFechaCompensa.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaCompensa.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFechaCompensa.Location = new System.Drawing.Point(638, 77);
            this.dtpFechaCompensa.MaxDate = new System.DateTime(3000, 12, 31, 0, 0, 0, 0);
            this.dtpFechaCompensa.MinDate = new System.DateTime(1950, 1, 1, 0, 0, 0, 0);
            this.dtpFechaCompensa.Name = "dtpFechaCompensa";
            this.dtpFechaCompensa.Size = new System.Drawing.Size(93, 22);
            this.dtpFechaCompensa.TabIndex = 357;
            this.dtpFechaCompensa.Value = new System.DateTime(2017, 4, 27, 9, 44, 35, 0);
            this.dtpFechaCompensa.ValueChanged += new System.EventHandler(this.dtpFechaCompensa_ValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(449, 82);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(28, 13);
            this.label6.TabIndex = 361;
            this.label6.Text = "T.C.:";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.BackColor = System.Drawing.Color.Transparent;
            this.label19.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(533, 82);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(105, 13);
            this.label19.TabIndex = 359;
            this.label19.Text = "Fecha del Anticipo:";
            // 
            // btnaceptar
            // 
            this.btnaceptar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnaceptar.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnaceptar.Image = ((System.Drawing.Image)(resources.GetObject("btnaceptar.Image")));
            this.btnaceptar.Location = new System.Drawing.Point(765, 463);
            this.btnaceptar.Name = "btnaceptar";
            this.btnaceptar.Size = new System.Drawing.Size(78, 24);
            this.btnaceptar.TabIndex = 367;
            this.btnaceptar.Text = "Registrar";
            this.btnaceptar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnaceptar.UseVisualStyleBackColor = true;
            this.btnaceptar.Click += new System.EventHandler(this.btnaceptar_Click);
            // 
            // btncancelar
            // 
            this.btncancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btncancelar.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncancelar.Image = ((System.Drawing.Image)(resources.GetObject("btncancelar.Image")));
            this.btncancelar.Location = new System.Drawing.Point(844, 463);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(78, 24);
            this.btncancelar.TabIndex = 368;
            this.btncancelar.Text = "Cancelar";
            this.btncancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btncancelar.UseVisualStyleBackColor = true;
            this.btncancelar.Click += new System.EventHandler(this.btncancelar_Click);
            // 
            // lbltotalregistros
            // 
            this.lbltotalregistros.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbltotalregistros.AutoEllipsis = true;
            this.lbltotalregistros.AutoSize = true;
            this.lbltotalregistros.BackColor = System.Drawing.Color.Transparent;
            this.lbltotalregistros.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltotalregistros.Location = new System.Drawing.Point(10, 469);
            this.lbltotalregistros.Name = "lbltotalregistros";
            this.lbltotalregistros.Size = new System.Drawing.Size(104, 13);
            this.lbltotalregistros.TabIndex = 366;
            this.lbltotalregistros.Text = "Total de Registros: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 13);
            this.label3.TabIndex = 364;
            this.label3.Text = "Anticipos al Proveedor:";
            // 
            // dtgconten
            // 
            this.dtgconten.AllowUserToAddRows = false;
            this.dtgconten.AllowUserToResizeColumns = false;
            this.dtgconten.AllowUserToResizeRows = false;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(230)))), ((int)(((byte)(241)))));
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(191)))), ((int)(((byte)(231)))));
            this.dtgconten.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.dtgconten.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgconten.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgconten.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(218)))), ((int)(((byte)(231)))));
            this.dtgconten.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgconten.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.dtgconten.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(129)))), ((int)(((byte)(189)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.DeepSkyBlue;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgconten.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dtgconten.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dtgconten.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.xpkid,
            this.xFkEmpresa,
            this.xNameTipo,
            this.xTipo,
            this.xTipoID,
            this.xtipodesc,
            this.xNumDoc,
            this.xcliente,
            this.xMontoMN,
            this.xMontoME,
            this.xCuo,
            this.xNumPago,
            this.xFechaCompensa,
            this.xNameEstado,
            this.dataGridViewTextBoxColumn1,
            this.xcuentacontable});
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(207)))), ((int)(((byte)(241)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgconten.DefaultCellStyle = dataGridViewCellStyle12;
            this.dtgconten.EnableHeadersVisualStyles = false;
            this.dtgconten.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(179)))), ((int)(((byte)(215)))));
            this.dtgconten.Location = new System.Drawing.Point(10, 169);
            this.dtgconten.Name = "dtgconten";
            this.dtgconten.ReadOnly = true;
            this.dtgconten.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dtgconten.RowHeadersVisible = false;
            this.dtgconten.RowTemplate.Height = 18;
            this.dtgconten.Size = new System.Drawing.Size(912, 289);
            this.dtgconten.TabIndex = 369;
            // 
            // cbocuentabanco
            // 
            this.cbocuentabanco.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(218)))), ((int)(((byte)(231)))));
            this.cbocuentabanco.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbocuentabanco.FormattingEnabled = true;
            this.cbocuentabanco.Location = new System.Drawing.Point(477, 125);
            this.cbocuentabanco.Name = "cbocuentabanco";
            this.cbocuentabanco.Size = new System.Drawing.Size(445, 21);
            this.cbocuentabanco.TabIndex = 373;
            // 
            // lblguia1
            // 
            this.lblguia1.AutoSize = true;
            this.lblguia1.BackColor = System.Drawing.Color.Transparent;
            this.lblguia1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblguia1.Location = new System.Drawing.Point(348, 129);
            this.lblguia1.Name = "lblguia1";
            this.lblguia1.Size = new System.Drawing.Size(129, 13);
            this.lblguia1.TabIndex = 372;
            this.lblguia1.Text = "Cuenta Salida del Pago:";
            // 
            // cbobanco
            // 
            this.cbobanco.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(218)))), ((int)(((byte)(231)))));
            this.cbobanco.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbobanco.FormattingEnabled = true;
            this.cbobanco.Location = new System.Drawing.Point(78, 125);
            this.cbobanco.Name = "cbobanco";
            this.cbobanco.Size = new System.Drawing.Size(270, 21);
            this.cbobanco.TabIndex = 371;
            this.cbobanco.SelectedIndexChanged += new System.EventHandler(this.cbobanco_SelectedIndexChanged);
            this.cbobanco.Click += new System.EventHandler(this.cbobanco_Click);
            // 
            // lblguia
            // 
            this.lblguia.AutoSize = true;
            this.lblguia.BackColor = System.Drawing.Color.Transparent;
            this.lblguia.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblguia.Location = new System.Drawing.Point(37, 129);
            this.lblguia.Name = "lblguia";
            this.lblguia.Size = new System.Drawing.Size(42, 13);
            this.lblguia.TabIndex = 370;
            this.lblguia.Text = "Banco:";
            // 
            // txtImporteTotal
            // 
            this.txtImporteTotal.BackColor = System.Drawing.Color.White;
            this.txtImporteTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtImporteTotal.ColorFondoMouseEncima = System.Drawing.Color.Empty;
            this.txtImporteTotal.ColorFondoMousePresionado = System.Drawing.Color.Empty;
            this.txtImporteTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtImporteTotal.ForeColor = System.Drawing.Color.Black;
            this.txtImporteTotal.Format = "n2";
            this.txtImporteTotal.Location = new System.Drawing.Point(332, 78);
            this.txtImporteTotal.MaxLength = 10;
            this.txtImporteTotal.Name = "txtImporteTotal";
            this.txtImporteTotal.NextControlOnEnter = null;
            this.txtImporteTotal.Size = new System.Drawing.Size(90, 21);
            this.txtImporteTotal.TabIndex = 374;
            this.txtImporteTotal.Text = "0.00";
            this.txtImporteTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtImporteTotal.TextoDefecto = "0.00";
            this.txtImporteTotal.TextoDefectoColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(129)))), ((int)(((byte)(189)))));
            this.txtImporteTotal.TiposDatos = HpResergerUserControls.TextBoxPer.ListaTipos.SoloDinero;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(241, 82);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(91, 13);
            this.label14.TabIndex = 375;
            this.label14.Text = "Monto Anticipo:";
            // 
            // separadorOre2
            // 
            this.separadorOre2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.separadorOre2.BackColor = System.Drawing.Color.Transparent;
            this.separadorOre2.Location = new System.Drawing.Point(-5, 148);
            this.separadorOre2.MaximumSize = new System.Drawing.Size(2000, 2);
            this.separadorOre2.MinimumSize = new System.Drawing.Size(0, 2);
            this.separadorOre2.Name = "separadorOre2";
            this.separadorOre2.Size = new System.Drawing.Size(948, 2);
            this.separadorOre2.TabIndex = 348;
            // 
            // cbocuentaxpagar
            // 
            this.cbocuentaxpagar.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbocuentaxpagar.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbocuentaxpagar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(218)))), ((int)(((byte)(231)))));
            this.cbocuentaxpagar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbocuentaxpagar.DropDownWidth = 250;
            this.cbocuentaxpagar.FormattingEnabled = true;
            this.cbocuentaxpagar.Location = new System.Drawing.Point(78, 102);
            this.cbocuentaxpagar.Name = "cbocuentaxpagar";
            this.cbocuentaxpagar.Size = new System.Drawing.Size(555, 21);
            this.cbocuentaxpagar.TabIndex = 376;
            this.cbocuentaxpagar.Click += new System.EventHandler(this.cbocuentaxpagar_Click);
            // 
            // label2
            // 
            this.label2.AutoEllipsis = true;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(0, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 377;
            this.label2.Text = "Cuenta Pagar:";
            // 
            // btn
            // 
            this.btn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(129)))), ((int)(((byte)(189)))));
            this.btn.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn.ForeColor = System.Drawing.Color.White;
            this.btn.Location = new System.Drawing.Point(412, 463);
            this.btn.Name = "btn";
            this.btn.Size = new System.Drawing.Size(111, 24);
            this.btn.TabIndex = 378;
            this.btn.Text = "Aplicar Anticipo";
            this.btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn.UseVisualStyleBackColor = false;
            this.btn.Click += new System.EventHandler(this.btn_Click);
            // 
            // xpkid
            // 
            this.xpkid.DataPropertyName = "PkId";
            this.xpkid.HeaderText = "pkid";
            this.xpkid.Name = "xpkid";
            this.xpkid.ReadOnly = true;
            this.xpkid.Visible = false;
            // 
            // xFkEmpresa
            // 
            this.xFkEmpresa.DataPropertyName = "FkEmpresa";
            this.xFkEmpresa.HeaderText = "[FkEmpresa]";
            this.xFkEmpresa.Name = "xFkEmpresa";
            this.xFkEmpresa.ReadOnly = true;
            this.xFkEmpresa.Visible = false;
            // 
            // xNameTipo
            // 
            this.xNameTipo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.xNameTipo.DataPropertyName = "NameTipo";
            this.xNameTipo.HeaderText = "Tipo";
            this.xNameTipo.Name = "xNameTipo";
            this.xNameTipo.ReadOnly = true;
            this.xNameTipo.Width = 55;
            // 
            // xTipo
            // 
            this.xTipo.DataPropertyName = "Tipo";
            this.xTipo.HeaderText = "[Tipo]";
            this.xTipo.Name = "xTipo";
            this.xTipo.ReadOnly = true;
            this.xTipo.Visible = false;
            // 
            // xTipoID
            // 
            this.xTipoID.DataPropertyName = "TipoID";
            this.xTipoID.HeaderText = "[TipoID]";
            this.xTipoID.Name = "xTipoID";
            this.xTipoID.ReadOnly = true;
            this.xTipoID.Visible = false;
            // 
            // xtipodesc
            // 
            this.xtipodesc.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.xtipodesc.DataPropertyName = "tipodesc";
            this.xtipodesc.HeaderText = "TipoDoc";
            this.xtipodesc.Name = "xtipodesc";
            this.xtipodesc.ReadOnly = true;
            this.xtipodesc.Width = 76;
            // 
            // xNumDoc
            // 
            this.xNumDoc.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.xNumDoc.DataPropertyName = "NumDoc";
            this.xNumDoc.HeaderText = "NumDoc";
            this.xNumDoc.Name = "xNumDoc";
            this.xNumDoc.ReadOnly = true;
            this.xNumDoc.Width = 79;
            // 
            // xcliente
            // 
            this.xcliente.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.xcliente.DataPropertyName = "cliente";
            this.xcliente.HeaderText = "Nombres";
            this.xcliente.MinimumWidth = 100;
            this.xcliente.Name = "xcliente";
            this.xcliente.ReadOnly = true;
            // 
            // xMontoMN
            // 
            this.xMontoMN.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.xMontoMN.DataPropertyName = "MontoMN";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle9.Format = "n2";
            this.xMontoMN.DefaultCellStyle = dataGridViewCellStyle9;
            this.xMontoMN.HeaderText = "MontoMN";
            this.xMontoMN.Name = "xMontoMN";
            this.xMontoMN.ReadOnly = true;
            this.xMontoMN.Width = 87;
            // 
            // xMontoME
            // 
            this.xMontoME.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.xMontoME.DataPropertyName = "MontoME";
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle10.Format = "n2";
            this.xMontoME.DefaultCellStyle = dataGridViewCellStyle10;
            this.xMontoME.HeaderText = "MontoME";
            this.xMontoME.Name = "xMontoME";
            this.xMontoME.ReadOnly = true;
            this.xMontoME.Width = 84;
            // 
            // xCuo
            // 
            this.xCuo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.xCuo.DataPropertyName = "Cuo";
            this.xCuo.HeaderText = "Cuo";
            this.xCuo.Name = "xCuo";
            this.xCuo.ReadOnly = true;
            this.xCuo.Width = 53;
            // 
            // xNumPago
            // 
            this.xNumPago.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.xNumPago.DataPropertyName = "NumPago";
            this.xNumPago.HeaderText = "NumPago";
            this.xNumPago.Name = "xNumPago";
            this.xNumPago.ReadOnly = true;
            this.xNumPago.Visible = false;
            this.xNumPago.Width = 85;
            // 
            // xFechaCompensa
            // 
            this.xFechaCompensa.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.xFechaCompensa.DataPropertyName = "FechaCompensa";
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle11.Format = "dd/MM/yyyy HH:mm";
            dataGridViewCellStyle11.NullValue = null;
            this.xFechaCompensa.DefaultCellStyle = dataGridViewCellStyle11;
            this.xFechaCompensa.HeaderText = "F.Cmpsa.";
            this.xFechaCompensa.Name = "xFechaCompensa";
            this.xFechaCompensa.ReadOnly = true;
            this.xFechaCompensa.Width = 80;
            // 
            // xNameEstado
            // 
            this.xNameEstado.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.xNameEstado.DataPropertyName = "NameEstado";
            this.xNameEstado.HeaderText = "Estado";
            this.xNameEstado.Name = "xNameEstado";
            this.xNameEstado.ReadOnly = true;
            this.xNameEstado.Width = 66;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Estado";
            this.dataGridViewTextBoxColumn1.HeaderText = "[Estado]";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // xcuentacontable
            // 
            this.xcuentacontable.DataPropertyName = "cuentacontable";
            this.xcuentacontable.HeaderText = "Cuentacontable";
            this.xcuentacontable.Name = "xcuentacontable";
            this.xcuentacontable.ReadOnly = true;
            this.xcuentacontable.Visible = false;
            // 
            // frmAnticipoProveedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 493);
            this.Controls.Add(this.btn);
            this.Controls.Add(this.cbocuentaxpagar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbomoneda);
            this.Controls.Add(this.txtImporteTotal);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.cbocuentabanco);
            this.Controls.Add(this.lblguia1);
            this.Controls.Add(this.cbobanco);
            this.Controls.Add(this.lblguia);
            this.Controls.Add(this.dtgconten);
            this.Controls.Add(this.btnaceptar);
            this.Controls.Add(this.btncancelar);
            this.Controls.Add(this.lbltotalregistros);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txttipocambio);
            this.Controls.Add(this.dtpFechaContable);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.dtpFechaCompensa);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.txtglosa);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cboproveedor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cboproyecto);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.separadorOre2);
            this.Controls.Add(this.separadorOre1);
            this.Controls.Add(this.cboempresa);
            this.Controls.Add(this.label18);
            this.MinimumSize = new System.Drawing.Size(950, 532);
            this.Name = "frmAnticipoProveedores";
            this.Nombre = "Anticipo a Proveedores [Registro]";
            this.Text = "Anticipo a Proveedores [Registro]";
            this.Load += new System.EventHandler(this.frmAnticipoProveedores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgconten)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboproyecto;
        private System.Windows.Forms.Label label16;
        private HpResergerUserControls.SeparadorOre separadorOre1;
        private System.Windows.Forms.ComboBox cboempresa;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label7;
        private HpResergerUserControls.TextBoxPer txtglosa;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cboproveedor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbomoneda;
        private System.Windows.Forms.Label label4;
        private HpResergerUserControls.TextBoxPer txttipocambio;
        private System.Windows.Forms.DateTimePicker dtpFechaContable;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.DateTimePicker dtpFechaCompensa;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Button btnaceptar;
        private System.Windows.Forms.Button btncancelar;
        private System.Windows.Forms.Label lbltotalregistros;
        private System.Windows.Forms.Label label3;
        private HpResergerUserControls.Dtgconten dtgconten;
        private System.Windows.Forms.ComboBox cbocuentabanco;
        private System.Windows.Forms.Label lblguia1;
        private System.Windows.Forms.ComboBox cbobanco;
        private System.Windows.Forms.Label lblguia;
        private HpResergerUserControls.TextBoxPer txtImporteTotal;
        private System.Windows.Forms.Label label14;
        private HpResergerUserControls.SeparadorOre separadorOre2;
        private System.Windows.Forms.ComboBox cbocuentaxpagar;
        private System.Windows.Forms.Label label2;
        private HpResergerUserControls.ButtonPer btn;
        private System.Windows.Forms.DataGridViewTextBoxColumn xpkid;
        private System.Windows.Forms.DataGridViewTextBoxColumn xFkEmpresa;
        private System.Windows.Forms.DataGridViewTextBoxColumn xNameTipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn xTipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn xTipoID;
        private System.Windows.Forms.DataGridViewTextBoxColumn xtipodesc;
        private System.Windows.Forms.DataGridViewTextBoxColumn xNumDoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn xcliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn xMontoMN;
        private System.Windows.Forms.DataGridViewTextBoxColumn xMontoME;
        private System.Windows.Forms.DataGridViewTextBoxColumn xCuo;
        private System.Windows.Forms.DataGridViewTextBoxColumn xNumPago;
        private System.Windows.Forms.DataGridViewTextBoxColumn xFechaCompensa;
        private System.Windows.Forms.DataGridViewTextBoxColumn xNameEstado;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn xcuentacontable;
    }
}