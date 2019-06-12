namespace HPReserger.ModuloCompensaciones
{
    partial class frmFondoFijo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFondoFijo));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            this.cboproyecto = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.separadorOre1 = new HpResergerUserControls.SeparadorOre();
            this.cboempresa = new System.Windows.Forms.ComboBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtglosa = new HpResergerUserControls.TextBoxPer();
            this.label8 = new System.Windows.Forms.Label();
            this.cbocuentabanco = new System.Windows.Forms.ComboBox();
            this.lblguia1 = new System.Windows.Forms.Label();
            this.cbobanco = new System.Windows.Forms.ComboBox();
            this.lblguia = new System.Windows.Forms.Label();
            this.cbomoneda = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txttipocambio = new HpResergerUserControls.TextBoxPer();
            this.dtpFechaContable = new System.Windows.Forms.DateTimePicker();
            this.label15 = new System.Windows.Forms.Label();
            this.dtpFechaCompensa = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.cbocuentaxpagar = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cboempleado = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btncancelar = new System.Windows.Forms.Button();
            this.lbltotalregistros = new System.Windows.Forms.Label();
            this.txtImporteTotal = new HpResergerUserControls.TextBoxPer();
            this.label14 = new System.Windows.Forms.Label();
            this.btnbusEmpleado = new HpResergerUserControls.ButtonPer();
            this.dtgconten = new HpResergerUserControls.Dtgconten();
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
            this.btnaceptar = new System.Windows.Forms.Button();
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
            this.cboproyecto.Location = new System.Drawing.Point(480, 8);
            this.cboproyecto.Name = "cboproyecto";
            this.cboproyecto.Size = new System.Drawing.Size(253, 21);
            this.cboproyecto.TabIndex = 387;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.Transparent;
            this.label16.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(426, 12);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(54, 13);
            this.label16.TabIndex = 388;
            this.label16.Text = "Proyecto:";
            // 
            // separadorOre1
            // 
            this.separadorOre1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.separadorOre1.BackColor = System.Drawing.Color.Transparent;
            this.separadorOre1.Location = new System.Drawing.Point(-7, 30);
            this.separadorOre1.MaximumSize = new System.Drawing.Size(2000, 2);
            this.separadorOre1.MinimumSize = new System.Drawing.Size(0, 2);
            this.separadorOre1.Name = "separadorOre1";
            this.separadorOre1.Size = new System.Drawing.Size(1129, 2);
            this.separadorOre1.TabIndex = 386;
            // 
            // cboempresa
            // 
            this.cboempresa.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboempresa.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboempresa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(218)))), ((int)(((byte)(231)))));
            this.cboempresa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboempresa.DropDownWidth = 250;
            this.cboempresa.FormattingEnabled = true;
            this.cboempresa.Location = new System.Drawing.Point(81, 8);
            this.cboempresa.Name = "cboempresa";
            this.cboempresa.Size = new System.Drawing.Size(344, 21);
            this.cboempresa.TabIndex = 384;
            this.cboempresa.SelectedIndexChanged += new System.EventHandler(this.cboempresa_SelectedIndexChanged);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.BackColor = System.Drawing.Color.Transparent;
            this.label18.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(27, 12);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(53, 13);
            this.label18.TabIndex = 385;
            this.label18.Text = "Empresa:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(10, 38);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(228, 13);
            this.label7.TabIndex = 389;
            this.label7.Text = "Opciones para la Creación de el Fondo Fijo";
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
            this.txtglosa.Location = new System.Drawing.Point(479, 53);
            this.txtglosa.MaxLength = 300;
            this.txtglosa.Name = "txtglosa";
            this.txtglosa.NextControlOnEnter = null;
            this.txtglosa.Size = new System.Drawing.Size(443, 21);
            this.txtglosa.TabIndex = 405;
            this.txtglosa.Text = "INGRESE GLOSA DE LA CREACIÓN";
            this.txtglosa.TextoDefecto = "INGRESE GLOSA DE LA CREACIÓN";
            this.txtglosa.TextoDefectoColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(129)))), ((int)(((byte)(189)))));
            this.txtglosa.TiposDatos = HpResergerUserControls.TextBoxPer.ListaTipos.MayusculaCadaPalabra;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(438, 57);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(39, 13);
            this.label8.TabIndex = 406;
            this.label8.Text = "Glosa:";
            // 
            // cbocuentabanco
            // 
            this.cbocuentabanco.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(218)))), ((int)(((byte)(231)))));
            this.cbocuentabanco.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbocuentabanco.FormattingEnabled = true;
            this.cbocuentabanco.Location = new System.Drawing.Point(479, 123);
            this.cbocuentabanco.Name = "cbocuentabanco";
            this.cbocuentabanco.Size = new System.Drawing.Size(443, 21);
            this.cbocuentabanco.TabIndex = 404;
            // 
            // lblguia1
            // 
            this.lblguia1.AutoSize = true;
            this.lblguia1.BackColor = System.Drawing.Color.Transparent;
            this.lblguia1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblguia1.Location = new System.Drawing.Point(347, 127);
            this.lblguia1.Name = "lblguia1";
            this.lblguia1.Size = new System.Drawing.Size(135, 13);
            this.lblguia1.TabIndex = 403;
            this.lblguia1.Text = "Cuenta Salida de Dinero:";
            // 
            // cbobanco
            // 
            this.cbobanco.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(218)))), ((int)(((byte)(231)))));
            this.cbobanco.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbobanco.FormattingEnabled = true;
            this.cbobanco.Location = new System.Drawing.Point(80, 123);
            this.cbobanco.Name = "cbobanco";
            this.cbobanco.Size = new System.Drawing.Size(265, 21);
            this.cbobanco.TabIndex = 402;
            this.cbobanco.SelectedIndexChanged += new System.EventHandler(this.cbobanco_SelectedIndexChanged);
            this.cbobanco.Click += new System.EventHandler(this.cbobanco_Click);
            // 
            // lblguia
            // 
            this.lblguia.AutoSize = true;
            this.lblguia.BackColor = System.Drawing.Color.Transparent;
            this.lblguia.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblguia.Location = new System.Drawing.Point(39, 127);
            this.lblguia.Name = "lblguia";
            this.lblguia.Size = new System.Drawing.Size(42, 13);
            this.lblguia.TabIndex = 401;
            this.lblguia.Text = "Banco:";
            // 
            // cbomoneda
            // 
            this.cbomoneda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(218)))), ((int)(((byte)(231)))));
            this.cbomoneda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbomoneda.FormattingEnabled = true;
            this.cbomoneda.Location = new System.Drawing.Point(80, 76);
            this.cbomoneda.Name = "cbomoneda";
            this.cbomoneda.Size = new System.Drawing.Size(170, 21);
            this.cbomoneda.TabIndex = 399;
            this.cbomoneda.SelectedIndexChanged += new System.EventHandler(this.cbomoneda_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(28, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 400;
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
            this.txttipocambio.Location = new System.Drawing.Point(863, 76);
            this.txttipocambio.MaxLength = 10;
            this.txttipocambio.Name = "txttipocambio";
            this.txttipocambio.NextControlOnEnter = null;
            this.txttipocambio.Size = new System.Drawing.Size(59, 21);
            this.txttipocambio.TabIndex = 397;
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
            this.dtpFechaContable.Location = new System.Drawing.Point(523, 75);
            this.dtpFechaContable.MaxDate = new System.DateTime(3000, 12, 31, 0, 0, 0, 0);
            this.dtpFechaContable.MinDate = new System.DateTime(1950, 1, 1, 0, 0, 0, 0);
            this.dtpFechaContable.Name = "dtpFechaContable";
            this.dtpFechaContable.Size = new System.Drawing.Size(93, 22);
            this.dtpFechaContable.TabIndex = 393;
            this.dtpFechaContable.Value = new System.DateTime(2017, 4, 27, 9, 44, 35, 0);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(433, 80);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(90, 13);
            this.label15.TabIndex = 395;
            this.label15.Text = "Fecha Contable:";
            // 
            // dtpFechaCompensa
            // 
            this.dtpFechaCompensa.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaCompensa.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFechaCompensa.Location = new System.Drawing.Point(741, 75);
            this.dtpFechaCompensa.MaxDate = new System.DateTime(3000, 12, 31, 0, 0, 0, 0);
            this.dtpFechaCompensa.MinDate = new System.DateTime(1950, 1, 1, 0, 0, 0, 0);
            this.dtpFechaCompensa.Name = "dtpFechaCompensa";
            this.dtpFechaCompensa.Size = new System.Drawing.Size(93, 22);
            this.dtpFechaCompensa.TabIndex = 394;
            this.dtpFechaCompensa.Value = new System.DateTime(2017, 4, 27, 9, 44, 35, 0);
            this.dtpFechaCompensa.ValueChanged += new System.EventHandler(this.dtpFechaCompensa_ValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(835, 80);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(28, 13);
            this.label6.TabIndex = 398;
            this.label6.Text = "T.C.:";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.BackColor = System.Drawing.Color.Transparent;
            this.label19.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(616, 80);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(125, 13);
            this.label19.TabIndex = 396;
            this.label19.Text = "Fecha Creación Fondo:";
            // 
            // cbocuentaxpagar
            // 
            this.cbocuentaxpagar.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbocuentaxpagar.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbocuentaxpagar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(218)))), ((int)(((byte)(231)))));
            this.cbocuentaxpagar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbocuentaxpagar.DropDownWidth = 250;
            this.cbocuentaxpagar.FormattingEnabled = true;
            this.cbocuentaxpagar.Location = new System.Drawing.Point(80, 100);
            this.cbocuentaxpagar.Name = "cbocuentaxpagar";
            this.cbocuentaxpagar.Size = new System.Drawing.Size(555, 21);
            this.cbocuentaxpagar.TabIndex = 390;
            // 
            // label3
            // 
            this.label3.AutoEllipsis = true;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(17, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 392;
            this.label3.Text = "Cta Fondo:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 391;
            this.label1.Text = "Empleado:";
            // 
            // cboempleado
            // 
            this.cboempleado.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboempleado.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboempleado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(218)))), ((int)(((byte)(231)))));
            this.cboempleado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboempleado.DropDownWidth = 250;
            this.cboempleado.FormattingEnabled = true;
            this.cboempleado.Location = new System.Drawing.Point(80, 53);
            this.cboempleado.Name = "cboempleado";
            this.cboempleado.Size = new System.Drawing.Size(320, 21);
            this.cboempleado.TabIndex = 407;
            this.cboempleado.Click += new System.EventHandler(this.cboempleado_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(10, 149);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 13);
            this.label2.TabIndex = 408;
            this.label2.Text = "Listado de Fondo Fijos:";
            // 
            // btncancelar
            // 
            this.btncancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btncancelar.Image = ((System.Drawing.Image)(resources.GetObject("btncancelar.Image")));
            this.btncancelar.Location = new System.Drawing.Point(847, 463);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(75, 23);
            this.btncancelar.TabIndex = 410;
            this.btncancelar.Text = "Cancelar";
            this.btncancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btncancelar.UseVisualStyleBackColor = true;
            // 
            // lbltotalregistros
            // 
            this.lbltotalregistros.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbltotalregistros.AutoEllipsis = true;
            this.lbltotalregistros.AutoSize = true;
            this.lbltotalregistros.BackColor = System.Drawing.Color.Transparent;
            this.lbltotalregistros.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltotalregistros.Location = new System.Drawing.Point(12, 468);
            this.lbltotalregistros.Name = "lbltotalregistros";
            this.lbltotalregistros.Size = new System.Drawing.Size(104, 13);
            this.lbltotalregistros.TabIndex = 409;
            this.lbltotalregistros.Text = "Total de Registros: ";
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
            this.txtImporteTotal.Location = new System.Drawing.Point(334, 76);
            this.txtImporteTotal.MaxLength = 10;
            this.txtImporteTotal.Name = "txtImporteTotal";
            this.txtImporteTotal.NextControlOnEnter = null;
            this.txtImporteTotal.Size = new System.Drawing.Size(90, 21);
            this.txtImporteTotal.TabIndex = 411;
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
            this.label14.Location = new System.Drawing.Point(252, 80);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(82, 13);
            this.label14.TabIndex = 412;
            this.label14.Text = "Monto Fondo:";
            // 
            // btnbusEmpleado
            // 
            this.btnbusEmpleado.BackColor = System.Drawing.SystemColors.Control;
            this.btnbusEmpleado.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnbusEmpleado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnbusEmpleado.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnbusEmpleado.ForeColor = System.Drawing.Color.White;
            this.btnbusEmpleado.Image = ((System.Drawing.Image)(resources.GetObject("btnbusEmpleado.Image")));
            this.btnbusEmpleado.Location = new System.Drawing.Point(404, 53);
            this.btnbusEmpleado.Name = "btnbusEmpleado";
            this.btnbusEmpleado.Size = new System.Drawing.Size(21, 21);
            this.btnbusEmpleado.TabIndex = 413;
            this.btnbusEmpleado.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnbusEmpleado.UseVisualStyleBackColor = false;
            this.btnbusEmpleado.Click += new System.EventHandler(this.btnbusEmpleado_Click);
            // 
            // dtgconten
            // 
            this.dtgconten.AllowUserToAddRows = false;
            this.dtgconten.AllowUserToResizeColumns = false;
            this.dtgconten.AllowUserToResizeRows = false;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(230)))), ((int)(((byte)(241)))));
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(191)))), ((int)(((byte)(231)))));
            this.dtgconten.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle13;
            this.dtgconten.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgconten.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgconten.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(218)))), ((int)(((byte)(231)))));
            this.dtgconten.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgconten.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.dtgconten.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(129)))), ((int)(((byte)(189)))));
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.DeepSkyBlue;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgconten.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle14;
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
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle18.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle18.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(207)))), ((int)(((byte)(241)))));
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgconten.DefaultCellStyle = dataGridViewCellStyle18;
            this.dtgconten.EnableHeadersVisualStyles = false;
            this.dtgconten.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(179)))), ((int)(((byte)(215)))));
            this.dtgconten.Location = new System.Drawing.Point(11, 163);
            this.dtgconten.Name = "dtgconten";
            this.dtgconten.ReadOnly = true;
            this.dtgconten.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dtgconten.RowHeadersVisible = false;
            this.dtgconten.RowTemplate.Height = 18;
            this.dtgconten.Size = new System.Drawing.Size(912, 296);
            this.dtgconten.TabIndex = 414;
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
            this.xNameTipo.Width = 53;
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
            this.xtipodesc.Width = 73;
            // 
            // xNumDoc
            // 
            this.xNumDoc.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.xNumDoc.DataPropertyName = "NumDoc";
            this.xNumDoc.HeaderText = "NumDoc";
            this.xNumDoc.Name = "xNumDoc";
            this.xNumDoc.ReadOnly = true;
            this.xNumDoc.Width = 75;
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
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle15.Format = "n2";
            this.xMontoMN.DefaultCellStyle = dataGridViewCellStyle15;
            this.xMontoMN.HeaderText = "MontoMN";
            this.xMontoMN.Name = "xMontoMN";
            this.xMontoMN.ReadOnly = true;
            this.xMontoMN.Width = 84;
            // 
            // xMontoME
            // 
            this.xMontoME.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.xMontoME.DataPropertyName = "MontoME";
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle16.Format = "n2";
            this.xMontoME.DefaultCellStyle = dataGridViewCellStyle16;
            this.xMontoME.HeaderText = "MontoME";
            this.xMontoME.Name = "xMontoME";
            this.xMontoME.ReadOnly = true;
            this.xMontoME.Width = 82;
            // 
            // xCuo
            // 
            this.xCuo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.xCuo.DataPropertyName = "Cuo";
            this.xCuo.HeaderText = "Cuo";
            this.xCuo.Name = "xCuo";
            this.xCuo.ReadOnly = true;
            this.xCuo.Width = 52;
            // 
            // xNumPago
            // 
            this.xNumPago.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.xNumPago.DataPropertyName = "NumPago";
            this.xNumPago.HeaderText = "NumPago";
            this.xNumPago.Name = "xNumPago";
            this.xNumPago.ReadOnly = true;
            this.xNumPago.Visible = false;
            this.xNumPago.Width = 81;
            // 
            // xFechaCompensa
            // 
            this.xFechaCompensa.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.xFechaCompensa.DataPropertyName = "FechaCompensa";
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle17.Format = "dd/MM/yyyy HH:mm";
            dataGridViewCellStyle17.NullValue = null;
            this.xFechaCompensa.DefaultCellStyle = dataGridViewCellStyle17;
            this.xFechaCompensa.HeaderText = "F.Fondo.";
            this.xFechaCompensa.Name = "xFechaCompensa";
            this.xFechaCompensa.ReadOnly = true;
            this.xFechaCompensa.Width = 77;
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
            // btnaceptar
            // 
            this.btnaceptar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnaceptar.Image = ((System.Drawing.Image)(resources.GetObject("btnaceptar.Image")));
            this.btnaceptar.Location = new System.Drawing.Point(770, 463);
            this.btnaceptar.Name = "btnaceptar";
            this.btnaceptar.Size = new System.Drawing.Size(75, 23);
            this.btnaceptar.TabIndex = 415;
            this.btnaceptar.Text = "Pagar";
            this.btnaceptar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnaceptar.UseVisualStyleBackColor = true;
            this.btnaceptar.Click += new System.EventHandler(this.btnaceptar_Click);
            // 
            // frmFondoFijo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 493);
            this.Controls.Add(this.cbobanco);
            this.Controls.Add(this.btnaceptar);
            this.Controls.Add(this.dtgconten);
            this.Controls.Add(this.btnbusEmpleado);
            this.Controls.Add(this.txtImporteTotal);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.btncancelar);
            this.Controls.Add(this.lbltotalregistros);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cboempleado);
            this.Controls.Add(this.txtglosa);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cbocuentabanco);
            this.Controls.Add(this.lblguia1);
            this.Controls.Add(this.lblguia);
            this.Controls.Add(this.cbomoneda);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txttipocambio);
            this.Controls.Add(this.dtpFechaContable);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.dtpFechaCompensa);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.cbocuentaxpagar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cboproyecto);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.separadorOre1);
            this.Controls.Add(this.cboempresa);
            this.Controls.Add(this.label18);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinimumSize = new System.Drawing.Size(950, 532);
            this.Name = "frmFondoFijo";
            this.Nombre = "Fondo Fijo [Crear]";
            this.Text = "Fondo Fijo [Crear]";
            this.Load += new System.EventHandler(this.frmFondoFijo_Load);
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
        private System.Windows.Forms.ComboBox cbocuentabanco;
        private System.Windows.Forms.Label lblguia1;
        private System.Windows.Forms.ComboBox cbobanco;
        private System.Windows.Forms.Label lblguia;
        private System.Windows.Forms.ComboBox cbomoneda;
        private System.Windows.Forms.Label label4;
        private HpResergerUserControls.TextBoxPer txttipocambio;
        private System.Windows.Forms.DateTimePicker dtpFechaContable;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.DateTimePicker dtpFechaCompensa;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.ComboBox cbocuentaxpagar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboempleado;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btncancelar;
        private System.Windows.Forms.Label lbltotalregistros;
        private HpResergerUserControls.TextBoxPer txtImporteTotal;
        private System.Windows.Forms.Label label14;
        private HpResergerUserControls.ButtonPer btnbusEmpleado;
        private HpResergerUserControls.Dtgconten dtgconten;
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
        private System.Windows.Forms.Button btnaceptar;
    }
}