namespace HPReserger
{
    partial class frmReporteAnalitico2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReporteAnalitico2));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.chksubtotales = new HpResergerUserControls.checkboxOre();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.btnbusCuenta = new System.Windows.Forms.Button();
            this.dtpfechafin = new System.Windows.Forms.DateTimePicker();
            this.chklist = new System.Windows.Forms.CheckedListBox();
            this.txtbusnrodoc = new HpResergerUserControls.TextBoxPer();
            this.txtbusGlosa = new HpResergerUserControls.TextBoxPer();
            this.txtbusrazon = new HpResergerUserControls.TextBoxPer();
            this.txtbusruc = new HpResergerUserControls.TextBoxPer();
            this.txtbuscuenta = new HpResergerUserControls.TextBoxPer();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.dtpfechaini = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnexcel = new System.Windows.Forms.Button();
            this.btncancelar = new System.Windows.Forms.Button();
            this.lblmensaje = new System.Windows.Forms.Label();
            this.btngenerar = new System.Windows.Forms.Button();
            this.separadorOre1 = new HpResergerUserControls.SeparadorOre();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtgconten = new HpResergerUserControls.Dtgconten();
            this.xRUC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xEmpresa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xCuenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xDESCRIPCION = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xcuo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xFCtble = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xidsunat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xTCmprobante = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xnumdoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xtipoiddoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xproveedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xRazonSocial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xGlosa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xMoneda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xtotalmn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xtotalme = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xtc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chkAgruparCuentas = new HpResergerUserControls.checkboxOre();
            ((System.ComponentModel.ISupportInitialize)(this.dtgconten)).BeginInit();
            this.SuspendLayout();
            // 
            // chksubtotales
            // 
            this.chksubtotales.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.chksubtotales.AutoSize = true;
            this.chksubtotales.BackColor = System.Drawing.Color.Transparent;
            this.chksubtotales.ColorChecked = System.Drawing.Color.Empty;
            this.chksubtotales.ColorUnChecked = System.Drawing.Color.Empty;
            this.chksubtotales.Location = new System.Drawing.Point(703, 526);
            this.chksubtotales.Name = "chksubtotales";
            this.chksubtotales.Size = new System.Drawing.Size(123, 17);
            this.chksubtotales.TabIndex = 417;
            this.chksubtotales.Text = "Agrupar Proveedor";
            this.chksubtotales.UseVisualStyleBackColor = false;
            this.chksubtotales.CheckedChanged += new System.EventHandler(this.chksubtotales_CheckedChanged);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // btnbusCuenta
            // 
            this.btnbusCuenta.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnbusCuenta.BackgroundImage")));
            this.btnbusCuenta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnbusCuenta.Location = new System.Drawing.Point(299, 56);
            this.btnbusCuenta.Name = "btnbusCuenta";
            this.btnbusCuenta.Size = new System.Drawing.Size(21, 21);
            this.btnbusCuenta.TabIndex = 416;
            this.btnbusCuenta.UseVisualStyleBackColor = true;
            this.btnbusCuenta.Click += new System.EventHandler(this.btnbusCuenta_Click);
            // 
            // dtpfechafin
            // 
            this.dtpfechafin.CalendarForeColor = System.Drawing.Color.Fuchsia;
            this.dtpfechafin.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.dtpfechafin.CalendarTitleBackColor = System.Drawing.Color.Blue;
            this.dtpfechafin.CalendarTitleForeColor = System.Drawing.Color.Red;
            this.dtpfechafin.CalendarTrailingForeColor = System.Drawing.Color.Lime;
            this.dtpfechafin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpfechafin.Location = new System.Drawing.Point(206, 33);
            this.dtpfechafin.Name = "dtpfechafin";
            this.dtpfechafin.Size = new System.Drawing.Size(93, 22);
            this.dtpfechafin.TabIndex = 1;
            // 
            // chklist
            // 
            this.chklist.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.chklist.ColumnWidth = 200;
            this.chklist.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chklist.Location = new System.Drawing.Point(379, 33);
            this.chklist.Name = "chklist";
            this.chklist.Size = new System.Drawing.Size(405, 82);
            this.chklist.TabIndex = 5;
            this.chklist.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.chklist_ItemCheck);
            // 
            // txtbusnrodoc
            // 
            this.txtbusnrodoc.BackColor = System.Drawing.Color.White;
            this.txtbusnrodoc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtbusnrodoc.ColorFondoMouseEncima = System.Drawing.Color.Empty;
            this.txtbusnrodoc.ColorFondoMousePresionado = System.Drawing.Color.Empty;
            this.txtbusnrodoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbusnrodoc.ForeColor = System.Drawing.Color.Black;
            this.txtbusnrodoc.Format = null;
            this.txtbusnrodoc.Location = new System.Drawing.Point(84, 100);
            this.txtbusnrodoc.MaxLength = 100;
            this.txtbusnrodoc.Name = "txtbusnrodoc";
            this.txtbusnrodoc.NextControlOnEnter = null;
            this.txtbusnrodoc.Size = new System.Drawing.Size(215, 21);
            this.txtbusnrodoc.TabIndex = 4;
            this.txtbusnrodoc.Text = "Buscar Número Documento";
            this.txtbusnrodoc.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtbusnrodoc.TextoDefecto = "Buscar Número Documento";
            this.txtbusnrodoc.TextoDefectoColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(129)))), ((int)(((byte)(189)))));
            this.txtbusnrodoc.TiposDatos = HpResergerUserControls.TextBoxPer.ListaTipos.MayusculaCadaPalabra;
            this.toolTip1.SetToolTip(this.txtbusnrodoc, "(;) Documentos Separados");
            // 
            // txtbusGlosa
            // 
            this.txtbusGlosa.BackColor = System.Drawing.Color.White;
            this.txtbusGlosa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtbusGlosa.ColorFondoMouseEncima = System.Drawing.Color.Empty;
            this.txtbusGlosa.ColorFondoMousePresionado = System.Drawing.Color.Empty;
            this.txtbusGlosa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbusGlosa.ForeColor = System.Drawing.Color.Black;
            this.txtbusGlosa.Format = null;
            this.txtbusGlosa.Location = new System.Drawing.Point(84, 78);
            this.txtbusGlosa.MaxLength = 100;
            this.txtbusGlosa.Name = "txtbusGlosa";
            this.txtbusGlosa.NextControlOnEnter = null;
            this.txtbusGlosa.Size = new System.Drawing.Size(215, 21);
            this.txtbusGlosa.TabIndex = 3;
            this.txtbusGlosa.Text = "Buscar Glosa";
            this.txtbusGlosa.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtbusGlosa.TextoDefecto = "Buscar Glosa";
            this.txtbusGlosa.TextoDefectoColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(129)))), ((int)(((byte)(189)))));
            this.txtbusGlosa.TiposDatos = HpResergerUserControls.TextBoxPer.ListaTipos.MayusculaCadaPalabra;
            this.toolTip1.SetToolTip(this.txtbusGlosa, "(;) Glosas Separadas");
            // 
            // txtbusrazon
            // 
            this.txtbusrazon.BackColor = System.Drawing.Color.White;
            this.txtbusrazon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtbusrazon.ColorFondoMouseEncima = System.Drawing.Color.Empty;
            this.txtbusrazon.ColorFondoMousePresionado = System.Drawing.Color.Empty;
            this.txtbusrazon.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbusrazon.ForeColor = System.Drawing.Color.Black;
            this.txtbusrazon.Format = null;
            this.txtbusrazon.Location = new System.Drawing.Point(865, 78);
            this.txtbusrazon.MaxLength = 100;
            this.txtbusrazon.Name = "txtbusrazon";
            this.txtbusrazon.NextControlOnEnter = null;
            this.txtbusrazon.Size = new System.Drawing.Size(260, 21);
            this.txtbusrazon.TabIndex = 7;
            this.txtbusrazon.Text = "Buscar Razon Social";
            this.txtbusrazon.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtbusrazon.TextoDefecto = "Buscar Razon Social";
            this.txtbusrazon.TextoDefectoColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(129)))), ((int)(((byte)(189)))));
            this.txtbusrazon.TiposDatos = HpResergerUserControls.TextBoxPer.ListaTipos.MayusculaCadaPalabra;
            this.toolTip1.SetToolTip(this.txtbusrazon, "(;) Razon o Nombres Separados");
            // 
            // txtbusruc
            // 
            this.txtbusruc.BackColor = System.Drawing.Color.White;
            this.txtbusruc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtbusruc.ColorFondoMouseEncima = System.Drawing.Color.Empty;
            this.txtbusruc.ColorFondoMousePresionado = System.Drawing.Color.Empty;
            this.txtbusruc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbusruc.ForeColor = System.Drawing.Color.Black;
            this.txtbusruc.Format = null;
            this.txtbusruc.Location = new System.Drawing.Point(865, 56);
            this.txtbusruc.MaxLength = 100;
            this.txtbusruc.Name = "txtbusruc";
            this.txtbusruc.NextControlOnEnter = null;
            this.txtbusruc.Size = new System.Drawing.Size(260, 21);
            this.txtbusruc.TabIndex = 6;
            this.txtbusruc.Text = "Buscar RUC";
            this.txtbusruc.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtbusruc.TextoDefecto = "Buscar RUC";
            this.txtbusruc.TextoDefectoColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(129)))), ((int)(((byte)(189)))));
            this.txtbusruc.TiposDatos = HpResergerUserControls.TextBoxPer.ListaTipos.MayusculaCadaPalabra;
            this.toolTip1.SetToolTip(this.txtbusruc, "(;) Ruc Separados");
            // 
            // txtbuscuenta
            // 
            this.txtbuscuenta.BackColor = System.Drawing.Color.White;
            this.txtbuscuenta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtbuscuenta.ColorFondoMouseEncima = System.Drawing.Color.Empty;
            this.txtbuscuenta.ColorFondoMousePresionado = System.Drawing.Color.Empty;
            this.txtbuscuenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbuscuenta.ForeColor = System.Drawing.Color.Black;
            this.txtbuscuenta.Format = null;
            this.txtbuscuenta.Location = new System.Drawing.Point(84, 56);
            this.txtbuscuenta.MaxLength = 100;
            this.txtbuscuenta.Name = "txtbuscuenta";
            this.txtbuscuenta.NextControlOnEnter = null;
            this.txtbuscuenta.Size = new System.Drawing.Size(215, 21);
            this.txtbuscuenta.TabIndex = 2;
            this.txtbuscuenta.Text = "12;13;14;16;17;18;37;42;43;44;45;46\r\n";
            this.txtbuscuenta.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtbuscuenta.TextoDefecto = "";
            this.txtbuscuenta.TextoDefectoColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(129)))), ((int)(((byte)(189)))));
            this.txtbuscuenta.TiposDatos = HpResergerUserControls.TextBoxPer.ListaTipos.MayusculaCadaPalabra;
            this.toolTip1.SetToolTip(this.txtbuscuenta, "(-) Rango de Cuentas\r\n(;) Cuentas Específicas");
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Location = new System.Drawing.Point(16, 104);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 13);
            this.label7.TabIndex = 397;
            this.label7.Text = "Nro Dcmto:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Location = new System.Drawing.Point(790, 82);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(75, 13);
            this.label9.TabIndex = 396;
            this.label9.Text = "Razon Social:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Location = new System.Drawing.Point(836, 60);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 13);
            this.label8.TabIndex = 395;
            this.label8.Text = "Ruc:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(326, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 400;
            this.label3.Text = "Empresa:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(183, 38);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(17, 13);
            this.label5.TabIndex = 399;
            this.label5.Text = "A:";
            // 
            // dtpfechaini
            // 
            this.dtpfechaini.CalendarForeColor = System.Drawing.Color.Fuchsia;
            this.dtpfechaini.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.dtpfechaini.CalendarTitleBackColor = System.Drawing.Color.Blue;
            this.dtpfechaini.CalendarTitleForeColor = System.Drawing.Color.Red;
            this.dtpfechaini.CalendarTrailingForeColor = System.Drawing.Color.Lime;
            this.dtpfechaini.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpfechaini.Location = new System.Drawing.Point(84, 33);
            this.dtpfechaini.Name = "dtpfechaini";
            this.dtpfechaini.Size = new System.Drawing.Size(93, 22);
            this.dtpfechaini.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(42, 82);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 13);
            this.label6.TabIndex = 394;
            this.label6.Text = "Glosa:";
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(281, 530);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(82, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "Pdf";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            // 
            // btnexcel
            // 
            this.btnexcel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnexcel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnexcel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnexcel.Image = ((System.Drawing.Image)(resources.GetObject("btnexcel.Image")));
            this.btnexcel.Location = new System.Drawing.Point(615, 530);
            this.btnexcel.Name = "btnexcel";
            this.btnexcel.Size = new System.Drawing.Size(82, 23);
            this.btnexcel.TabIndex = 12;
            this.btnexcel.Text = "Excel";
            this.btnexcel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnexcel.UseVisualStyleBackColor = true;
            this.btnexcel.Click += new System.EventHandler(this.btnexcel_Click);
            // 
            // btncancelar
            // 
            this.btncancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btncancelar.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncancelar.Image = ((System.Drawing.Image)(resources.GetObject("btncancelar.Image")));
            this.btncancelar.Location = new System.Drawing.Point(1130, 530);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(85, 23);
            this.btncancelar.TabIndex = 9;
            this.btncancelar.Text = "Cancelar";
            this.btncancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btncancelar.UseVisualStyleBackColor = true;
            this.btncancelar.Click += new System.EventHandler(this.btncancelar_Click);
            // 
            // lblmensaje
            // 
            this.lblmensaje.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblmensaje.AutoSize = true;
            this.lblmensaje.BackColor = System.Drawing.Color.Transparent;
            this.lblmensaje.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmensaje.Location = new System.Drawing.Point(15, 535);
            this.lblmensaje.Name = "lblmensaje";
            this.lblmensaje.Size = new System.Drawing.Size(110, 13);
            this.lblmensaje.TabIndex = 404;
            this.lblmensaje.Text = "Total de Registros: 0";
            // 
            // btngenerar
            // 
            this.btngenerar.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btngenerar.Image = ((System.Drawing.Image)(resources.GetObject("btngenerar.Image")));
            this.btngenerar.Location = new System.Drawing.Point(1041, 100);
            this.btngenerar.Name = "btngenerar";
            this.btngenerar.Size = new System.Drawing.Size(85, 23);
            this.btngenerar.TabIndex = 8;
            this.btngenerar.Text = "Generar";
            this.btngenerar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btngenerar.UseVisualStyleBackColor = true;
            this.btngenerar.Click += new System.EventHandler(this.btngenerar_Click);
            // 
            // separadorOre1
            // 
            this.separadorOre1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.separadorOre1.BackColor = System.Drawing.Color.Transparent;
            this.separadorOre1.Location = new System.Drawing.Point(2, 123);
            this.separadorOre1.MaximumSize = new System.Drawing.Size(2000, 2);
            this.separadorOre1.MinimumSize = new System.Drawing.Size(0, 2);
            this.separadorOre1.Name = "separadorOre1";
            this.separadorOre1.Size = new System.Drawing.Size(1364, 2);
            this.separadorOre1.TabIndex = 402;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(29, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 393;
            this.label4.Text = "Cuentas:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(14, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 398;
            this.label2.Text = "Periodo De:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 19);
            this.label1.TabIndex = 401;
            this.label1.Text = "Reporte Analítico 2";
            // 
            // dtgconten
            // 
            this.dtgconten.AllowUserToAddRows = false;
            this.dtgconten.AllowUserToDeleteRows = false;
            this.dtgconten.AllowUserToResizeColumns = false;
            this.dtgconten.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(230)))), ((int)(((byte)(241)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(191)))), ((int)(((byte)(231)))));
            this.dtgconten.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgconten.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgconten.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgconten.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(218)))), ((int)(((byte)(231)))));
            this.dtgconten.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgconten.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.dtgconten.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(129)))), ((int)(((byte)(189)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DeepSkyBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgconten.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dtgconten.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dtgconten.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.xRUC,
            this.xEmpresa,
            this.xCuenta,
            this.xDESCRIPCION,
            this.xcuo,
            this.xFCtble,
            this.xidsunat,
            this.xTCmprobante,
            this.xnumdoc,
            this.xtipoiddoc,
            this.xproveedor,
            this.xRazonSocial,
            this.xGlosa,
            this.xMoneda,
            this.xtotalmn,
            this.xtotalme,
            this.xtc});
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(207)))), ((int)(((byte)(241)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgconten.DefaultCellStyle = dataGridViewCellStyle7;
            this.dtgconten.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dtgconten.EnableHeadersVisualStyles = false;
            this.dtgconten.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(179)))), ((int)(((byte)(215)))));
            this.dtgconten.Location = new System.Drawing.Point(14, 128);
            this.dtgconten.Name = "dtgconten";
            this.dtgconten.ReadOnly = true;
            this.dtgconten.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dtgconten.RowHeadersVisible = false;
            this.dtgconten.RowTemplate.Height = 18;
            this.dtgconten.Size = new System.Drawing.Size(1201, 396);
            this.dtgconten.TabIndex = 10;
            // 
            // xRUC
            // 
            this.xRUC.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.xRUC.DataPropertyName = "RUC";
            this.xRUC.HeaderText = "RUC";
            this.xRUC.Name = "xRUC";
            this.xRUC.ReadOnly = true;
            this.xRUC.Width = 53;
            // 
            // xEmpresa
            // 
            this.xEmpresa.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.xEmpresa.DataPropertyName = "Empresa";
            this.xEmpresa.HeaderText = "Empresa";
            this.xEmpresa.MinimumWidth = 120;
            this.xEmpresa.Name = "xEmpresa";
            this.xEmpresa.ReadOnly = true;
            this.xEmpresa.Width = 120;
            // 
            // xCuenta
            // 
            this.xCuenta.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.xCuenta.DataPropertyName = "Cuenta";
            this.xCuenta.HeaderText = "Cuenta";
            this.xCuenta.Name = "xCuenta";
            this.xCuenta.ReadOnly = true;
            this.xCuenta.Width = 68;
            // 
            // xDESCRIPCION
            // 
            this.xDESCRIPCION.DataPropertyName = "DESCRIPCION";
            this.xDESCRIPCION.HeaderText = "Descripción";
            this.xDESCRIPCION.MinimumWidth = 180;
            this.xDESCRIPCION.Name = "xDESCRIPCION";
            this.xDESCRIPCION.ReadOnly = true;
            // 
            // xcuo
            // 
            this.xcuo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.xcuo.DataPropertyName = "cuo";
            this.xcuo.HeaderText = "CUO";
            this.xcuo.Name = "xcuo";
            this.xcuo.ReadOnly = true;
            this.xcuo.Width = 55;
            // 
            // xFCtble
            // 
            this.xFCtble.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.xFCtble.DataPropertyName = "FCtble";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.Format = "d";
            this.xFCtble.DefaultCellStyle = dataGridViewCellStyle3;
            this.xFCtble.HeaderText = "F.Ctble";
            this.xFCtble.Name = "xFCtble";
            this.xFCtble.ReadOnly = true;
            this.xFCtble.Width = 67;
            // 
            // xidsunat
            // 
            this.xidsunat.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.xidsunat.DataPropertyName = "idsunat";
            this.xidsunat.HeaderText = "IdSunat";
            this.xidsunat.MinimumWidth = 65;
            this.xidsunat.Name = "xidsunat";
            this.xidsunat.ReadOnly = true;
            this.xidsunat.Width = 65;
            // 
            // xTCmprobante
            // 
            this.xTCmprobante.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.xTCmprobante.DataPropertyName = "TCmprobante";
            this.xTCmprobante.HeaderText = "T.Cmprobante";
            this.xTCmprobante.MinimumWidth = 120;
            this.xTCmprobante.Name = "xTCmprobante";
            this.xTCmprobante.ReadOnly = true;
            this.xTCmprobante.Width = 120;
            // 
            // xnumdoc
            // 
            this.xnumdoc.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.xnumdoc.DataPropertyName = "numdoc";
            this.xnumdoc.HeaderText = "Num.Doc.";
            this.xnumdoc.Name = "xnumdoc";
            this.xnumdoc.ReadOnly = true;
            this.xnumdoc.Width = 81;
            // 
            // xtipoiddoc
            // 
            this.xtipoiddoc.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.xtipoiddoc.DataPropertyName = "tipoiddoc";
            this.xtipoiddoc.HeaderText = "TipoIdDoc";
            this.xtipoiddoc.MinimumWidth = 70;
            this.xtipoiddoc.Name = "xtipoiddoc";
            this.xtipoiddoc.ReadOnly = true;
            this.xtipoiddoc.Width = 70;
            // 
            // xproveedor
            // 
            this.xproveedor.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.xproveedor.DataPropertyName = "proveedor";
            this.xproveedor.HeaderText = "Ruc-NroId";
            this.xproveedor.Name = "xproveedor";
            this.xproveedor.ReadOnly = true;
            this.xproveedor.Width = 83;
            // 
            // xRazonSocial
            // 
            this.xRazonSocial.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.xRazonSocial.DataPropertyName = "RazonSocial";
            this.xRazonSocial.HeaderText = "Nombres-Razon";
            this.xRazonSocial.MinimumWidth = 180;
            this.xRazonSocial.Name = "xRazonSocial";
            this.xRazonSocial.ReadOnly = true;
            // 
            // xGlosa
            // 
            this.xGlosa.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.xGlosa.DataPropertyName = "Glosa";
            this.xGlosa.HeaderText = "Glosa";
            this.xGlosa.MinimumWidth = 100;
            this.xGlosa.Name = "xGlosa";
            this.xGlosa.ReadOnly = true;
            // 
            // xMoneda
            // 
            this.xMoneda.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.xMoneda.DataPropertyName = "Moneda";
            this.xMoneda.HeaderText = "Moneda";
            this.xMoneda.Name = "xMoneda";
            this.xMoneda.ReadOnly = true;
            this.xMoneda.Width = 74;
            // 
            // xtotalmn
            // 
            this.xtotalmn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.xtotalmn.DataPropertyName = "totalmn";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle4.Format = "n2";
            this.xtotalmn.DefaultCellStyle = dataGridViewCellStyle4;
            this.xtotalmn.HeaderText = "PEN";
            this.xtotalmn.Name = "xtotalmn";
            this.xtotalmn.ReadOnly = true;
            this.xtotalmn.Width = 51;
            // 
            // xtotalme
            // 
            this.xtotalme.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.xtotalme.DataPropertyName = "totalme";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle5.Format = "n2";
            this.xtotalme.DefaultCellStyle = dataGridViewCellStyle5;
            this.xtotalme.HeaderText = "USD";
            this.xtotalme.Name = "xtotalme";
            this.xtotalme.ReadOnly = true;
            this.xtotalme.Width = 53;
            // 
            // xtc
            // 
            this.xtc.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.xtc.DataPropertyName = "tc";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle6.Format = "n3";
            this.xtc.DefaultCellStyle = dataGridViewCellStyle6;
            this.xtc.HeaderText = "T.C.";
            this.xtc.Name = "xtc";
            this.xtc.ReadOnly = true;
            this.xtc.Width = 49;
            // 
            // chkAgruparCuentas
            // 
            this.chkAgruparCuentas.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.chkAgruparCuentas.AutoSize = true;
            this.chkAgruparCuentas.BackColor = System.Drawing.Color.Transparent;
            this.chkAgruparCuentas.ColorChecked = System.Drawing.Color.Empty;
            this.chkAgruparCuentas.ColorUnChecked = System.Drawing.Color.Empty;
            this.chkAgruparCuentas.Location = new System.Drawing.Point(703, 543);
            this.chkAgruparCuentas.Name = "chkAgruparCuentas";
            this.chkAgruparCuentas.Size = new System.Drawing.Size(113, 17);
            this.chkAgruparCuentas.TabIndex = 417;
            this.chkAgruparCuentas.Text = "Agrupar Cuentas";
            this.chkAgruparCuentas.UseVisualStyleBackColor = false;
            this.chkAgruparCuentas.CheckedChanged += new System.EventHandler(this.chkAgruparCuentas_CheckedChanged);
            // 
            // frmReporteAnalitico2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1225, 561);
            this.Controls.Add(this.chkAgruparCuentas);
            this.Controls.Add(this.chksubtotales);
            this.Controls.Add(this.btnbusCuenta);
            this.Controls.Add(this.dtpfechafin);
            this.Controls.Add(this.chklist);
            this.Controls.Add(this.txtbusnrodoc);
            this.Controls.Add(this.txtbusGlosa);
            this.Controls.Add(this.txtbusrazon);
            this.Controls.Add(this.txtbusruc);
            this.Controls.Add(this.txtbuscuenta);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dtpfechaini);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnexcel);
            this.Controls.Add(this.btncancelar);
            this.Controls.Add(this.lblmensaje);
            this.Controls.Add(this.btngenerar);
            this.Controls.Add(this.separadorOre1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtgconten);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.MinimumSize = new System.Drawing.Size(1241, 600);
            this.Name = "frmReporteAnalitico2";
            this.Nombre = "Reporte Analítico 2";
            this.Text = "Reporte Analítico 2";
            this.Load += new System.EventHandler(this.frmReporteAnalitico_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgconten)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private HpResergerUserControls.checkboxOre chksubtotales;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button btnbusCuenta;
        private System.Windows.Forms.DateTimePicker dtpfechafin;
        private System.Windows.Forms.CheckedListBox chklist;
        private HpResergerUserControls.TextBoxPer txtbusnrodoc;
        private System.Windows.Forms.ToolTip toolTip1;
        private HpResergerUserControls.TextBoxPer txtbusGlosa;
        private HpResergerUserControls.TextBoxPer txtbusrazon;
        private HpResergerUserControls.TextBoxPer txtbusruc;
        private HpResergerUserControls.TextBoxPer txtbuscuenta;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtpfechaini;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnexcel;
        private System.Windows.Forms.Button btncancelar;
        private System.Windows.Forms.Label lblmensaje;
        private System.Windows.Forms.Button btngenerar;
        private HpResergerUserControls.SeparadorOre separadorOre1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private HpResergerUserControls.Dtgconten dtgconten;
        private HpResergerUserControls.checkboxOre chkAgruparCuentas;
        private System.Windows.Forms.DataGridViewTextBoxColumn xRUC;
        private System.Windows.Forms.DataGridViewTextBoxColumn xEmpresa;
        private System.Windows.Forms.DataGridViewTextBoxColumn xCuenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn xDESCRIPCION;
        private System.Windows.Forms.DataGridViewTextBoxColumn xcuo;
        private System.Windows.Forms.DataGridViewTextBoxColumn xFCtble;
        private System.Windows.Forms.DataGridViewTextBoxColumn xidsunat;
        private System.Windows.Forms.DataGridViewTextBoxColumn xTCmprobante;
        private System.Windows.Forms.DataGridViewTextBoxColumn xnumdoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn xtipoiddoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn xproveedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn xRazonSocial;
        private System.Windows.Forms.DataGridViewTextBoxColumn xGlosa;
        private System.Windows.Forms.DataGridViewTextBoxColumn xMoneda;
        private System.Windows.Forms.DataGridViewTextBoxColumn xtotalmn;
        private System.Windows.Forms.DataGridViewTextBoxColumn xtotalme;
        private System.Windows.Forms.DataGridViewTextBoxColumn xtc;
    }
}