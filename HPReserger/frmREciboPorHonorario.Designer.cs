namespace HPReserger
{
    partial class frmREciboPorHonorario
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Dtguias = new System.Windows.Forms.DataGridView();
            this.OK = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.FIC1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GUIA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FECHAENTREGA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnagregar = new System.Windows.Forms.Button();
            this.btnmaspro = new System.Windows.Forms.Button();
            this.cbotipo = new System.Windows.Forms.ComboBox();
            this.gp1 = new System.Windows.Forms.GroupBox();
            this.btndescargar = new System.Windows.Forms.Button();
            this.DtFechaRecepcion = new System.Windows.Forms.DateTimePicker();
            this.txtmonto = new System.Windows.Forms.TextBox();
            this.pbfactura = new System.Windows.Forms.PictureBox();
            this.DtgConten = new System.Windows.Forms.DataGridView();
            this.numfic = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DESCRIPCION = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MARCA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MODELO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CANTIDAD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PRECIOUNIT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subtotale = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valueigv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TOTALFAC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.siigv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numigv = new System.Windows.Forms.NumericUpDown();
            this.cboigv = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.Dtfechaentregado = new System.Windows.Forms.DateTimePicker();
            this.dtfechaemision = new System.Windows.Forms.DateTimePicker();
            this.lblporcentaje = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnCargarFoto = new System.Windows.Forms.Button();
            this.txttotal = new System.Windows.Forms.TextBox();
            this.txtigv = new System.Windows.Forms.TextBox();
            this.txtsubtotal = new System.Windows.Forms.TextBox();
            this.txtnrofactura = new System.Windows.Forms.TextBox();
            this.txtfoto = new System.Windows.Forms.TextBox();
            this.btnaceptar = new System.Windows.Forms.Button();
            this.btncancelar = new System.Windows.Forms.Button();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.txtRazonSocial = new System.Windows.Forms.TextBox();
            this.txtruc = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtdireccion = new System.Windows.Forms.TextBox();
            this.Openfd = new System.Windows.Forms.OpenFileDialog();
            this.tooltip = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.Dtguias)).BeginInit();
            this.gp1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbfactura)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DtgConten)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numigv)).BeginInit();
            this.SuspendLayout();
            // 
            // Dtguias
            // 
            this.Dtguias.AllowUserToAddRows = false;
            this.Dtguias.AllowUserToDeleteRows = false;
            this.Dtguias.AllowUserToResizeColumns = false;
            this.Dtguias.AllowUserToResizeRows = false;
            this.Dtguias.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Dtguias.BackgroundColor = System.Drawing.SystemColors.Control;
            this.Dtguias.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Dtguias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dtguias.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.OK,
            this.FIC1,
            this.OC,
            this.GUIA,
            this.FECHAENTREGA});
            this.Dtguias.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnF2;
            this.Dtguias.Location = new System.Drawing.Point(16, 115);
            this.Dtguias.MultiSelect = false;
            this.Dtguias.Name = "Dtguias";
            this.Dtguias.RowHeadersVisible = false;
            this.Dtguias.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Dtguias.Size = new System.Drawing.Size(701, 185);
            this.Dtguias.TabIndex = 40;
            this.Dtguias.TabStop = false;
            this.Dtguias.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dtguias_CellContentClick);
            this.Dtguias.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dtguias_CellEndEdit);
            // 
            // OK
            // 
            this.OK.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.OK.DataPropertyName = "OK";
            this.OK.FillWeight = 126.9036F;
            this.OK.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.OK.HeaderText = "OK";
            this.OK.Name = "OK";
            this.OK.Width = 50;
            // 
            // FIC1
            // 
            this.FIC1.DataPropertyName = "FIC";
            this.FIC1.FillWeight = 93.27411F;
            this.FIC1.HeaderText = "FIC";
            this.FIC1.Name = "FIC1";
            this.FIC1.ReadOnly = true;
            // 
            // OC
            // 
            this.OC.DataPropertyName = "OC";
            this.OC.FillWeight = 93.27411F;
            this.OC.HeaderText = "OC";
            this.OC.Name = "OC";
            this.OC.ReadOnly = true;
            // 
            // GUIA
            // 
            this.GUIA.DataPropertyName = "GUIA";
            this.GUIA.FillWeight = 93.27411F;
            this.GUIA.HeaderText = "VALORIZACIÓN";
            this.GUIA.Name = "GUIA";
            this.GUIA.ReadOnly = true;
            // 
            // FECHAENTREGA
            // 
            this.FECHAENTREGA.DataPropertyName = "FECHAENTREGA";
            this.FECHAENTREGA.FillWeight = 93.27411F;
            this.FECHAENTREGA.HeaderText = "FECHAENTREGA";
            this.FECHAENTREGA.Name = "FECHAENTREGA";
            this.FECHAENTREGA.ReadOnly = true;
            // 
            // btnagregar
            // 
            this.btnagregar.Enabled = false;
            this.btnagregar.Location = new System.Drawing.Point(734, 317);
            this.btnagregar.Name = "btnagregar";
            this.btnagregar.Size = new System.Drawing.Size(75, 23);
            this.btnagregar.TabIndex = 39;
            this.btnagregar.Text = "Ingresar";
            this.btnagregar.UseVisualStyleBackColor = true;
            this.btnagregar.Click += new System.EventHandler(this.btnagregar_Click);
            // 
            // btnmaspro
            // 
            this.btnmaspro.Location = new System.Drawing.Point(408, 37);
            this.btnmaspro.Name = "btnmaspro";
            this.btnmaspro.Size = new System.Drawing.Size(24, 20);
            this.btnmaspro.TabIndex = 37;
            this.btnmaspro.Text = "- -";
            this.btnmaspro.UseVisualStyleBackColor = true;
            this.btnmaspro.Click += new System.EventHandler(this.btnmaspro_Click);
            // 
            // cbotipo
            // 
            this.cbotipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbotipo.Enabled = false;
            this.cbotipo.FormattingEnabled = true;
            this.cbotipo.Items.AddRange(new object[] {
            "SERVICIO"});
            this.cbotipo.Location = new System.Drawing.Point(247, 11);
            this.cbotipo.Name = "cbotipo";
            this.cbotipo.Size = new System.Drawing.Size(88, 21);
            this.cbotipo.TabIndex = 36;
            // 
            // gp1
            // 
            this.gp1.Controls.Add(this.btndescargar);
            this.gp1.Controls.Add(this.DtFechaRecepcion);
            this.gp1.Controls.Add(this.txtmonto);
            this.gp1.Controls.Add(this.pbfactura);
            this.gp1.Controls.Add(this.DtgConten);
            this.gp1.Controls.Add(this.numigv);
            this.gp1.Controls.Add(this.cboigv);
            this.gp1.Controls.Add(this.label15);
            this.gp1.Controls.Add(this.label14);
            this.gp1.Controls.Add(this.label13);
            this.gp1.Controls.Add(this.label2);
            this.gp1.Controls.Add(this.label9);
            this.gp1.Controls.Add(this.label17);
            this.gp1.Controls.Add(this.label8);
            this.gp1.Controls.Add(this.Dtfechaentregado);
            this.gp1.Controls.Add(this.dtfechaemision);
            this.gp1.Controls.Add(this.lblporcentaje);
            this.gp1.Controls.Add(this.label3);
            this.gp1.Controls.Add(this.label4);
            this.gp1.Controls.Add(this.btnCargarFoto);
            this.gp1.Controls.Add(this.txttotal);
            this.gp1.Controls.Add(this.txtigv);
            this.gp1.Controls.Add(this.txtsubtotal);
            this.gp1.Controls.Add(this.txtnrofactura);
            this.gp1.Controls.Add(this.txtfoto);
            this.gp1.Enabled = false;
            this.gp1.Location = new System.Drawing.Point(12, 306);
            this.gp1.Name = "gp1";
            this.gp1.Size = new System.Drawing.Size(716, 302);
            this.gp1.TabIndex = 35;
            this.gp1.TabStop = false;
            this.gp1.Move += new System.EventHandler(this.gp1_Move);
            // 
            // btndescargar
            // 
            this.btndescargar.AutoEllipsis = true;
            this.btndescargar.ImageKey = "(ninguno)";
            this.btndescargar.Location = new System.Drawing.Point(612, 29);
            this.btndescargar.Name = "btndescargar";
            this.btndescargar.Size = new System.Drawing.Size(76, 23);
            this.btndescargar.TabIndex = 114;
            this.btndescargar.Text = "Descargar";
            this.btndescargar.UseVisualStyleBackColor = false;
            this.btndescargar.Visible = false;
            this.btndescargar.Click += new System.EventHandler(this.btndescargar_Click);
            this.btndescargar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btndescargar_MouseMove);
            // 
            // DtFechaRecepcion
            // 
            this.DtFechaRecepcion.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtFechaRecepcion.Location = new System.Drawing.Point(487, 40);
            this.DtFechaRecepcion.Name = "DtFechaRecepcion";
            this.DtFechaRecepcion.Size = new System.Drawing.Size(100, 20);
            this.DtFechaRecepcion.TabIndex = 19;
            // 
            // txtmonto
            // 
            this.txtmonto.Enabled = false;
            this.txtmonto.Location = new System.Drawing.Point(260, 66);
            this.txtmonto.Name = "txtmonto";
            this.txtmonto.Size = new System.Drawing.Size(78, 20);
            this.txtmonto.TabIndex = 18;
            this.txtmonto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtmonto.TextChanged += new System.EventHandler(this.txtmonto_TextChanged);
            // 
            // pbfactura
            // 
            this.pbfactura.Location = new System.Drawing.Point(594, 14);
            this.pbfactura.Name = "pbfactura";
            this.pbfactura.Size = new System.Drawing.Size(111, 41);
            this.pbfactura.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbfactura.TabIndex = 17;
            this.pbfactura.TabStop = false;
            this.pbfactura.DoubleClick += new System.EventHandler(this.pbfactura_DoubleClick);
            this.pbfactura.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pbfactura_MouseMove);
            // 
            // DtgConten
            // 
            this.DtgConten.AllowUserToAddRows = false;
            this.DtgConten.AllowUserToDeleteRows = false;
            this.DtgConten.AllowUserToResizeColumns = false;
            this.DtgConten.AllowUserToResizeRows = false;
            this.DtgConten.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DtgConten.BackgroundColor = System.Drawing.SystemColors.Control;
            this.DtgConten.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DtgConten.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.numfic,
            this.DESCRIPCION,
            this.cc,
            this.MARCA,
            this.MODELO,
            this.CANTIDAD,
            this.PRECIOUNIT,
            this.subtotale,
            this.valueigv,
            this.TOTALFAC,
            this.numoc,
            this.siigv});
            this.DtgConten.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.DtgConten.Enabled = false;
            this.DtgConten.Location = new System.Drawing.Point(6, 93);
            this.DtgConten.MultiSelect = false;
            this.DtgConten.Name = "DtgConten";
            this.DtgConten.RowHeadersVisible = false;
            this.DtgConten.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DtgConten.Size = new System.Drawing.Size(699, 196);
            this.DtgConten.TabIndex = 16;
            this.DtgConten.TabStop = false;
            this.DtgConten.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.DtgConten_CellEndEdit);
            this.DtgConten.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.DtgConten_DataError);
            this.DtgConten.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.DtgConten_EditingControlShowing);
            this.DtgConten.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DtgConten_KeyPress);
            // 
            // numfic
            // 
            this.numfic.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.numfic.DataPropertyName = "fic";
            this.numfic.HeaderText = "FIC";
            this.numfic.Name = "numfic";
            this.numfic.ReadOnly = true;
            this.numfic.Width = 48;
            // 
            // DESCRIPCION
            // 
            this.DESCRIPCION.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DESCRIPCION.DataPropertyName = "DESCRIPCION";
            this.DESCRIPCION.HeaderText = "Descripción";
            this.DESCRIPCION.Name = "DESCRIPCION";
            this.DESCRIPCION.ReadOnly = true;
            // 
            // cc
            // 
            this.cc.DataPropertyName = "cc";
            this.cc.HeaderText = "cc";
            this.cc.Name = "cc";
            this.cc.Visible = false;
            // 
            // MARCA
            // 
            this.MARCA.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.MARCA.DataPropertyName = "MARCA";
            this.MARCA.HeaderText = "Detalle";
            this.MARCA.Name = "MARCA";
            this.MARCA.ReadOnly = true;
            this.MARCA.Width = 65;
            // 
            // MODELO
            // 
            this.MODELO.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.MODELO.DataPropertyName = "MODELO";
            this.MODELO.HeaderText = "Modelo";
            this.MODELO.Name = "MODELO";
            this.MODELO.ReadOnly = true;
            this.MODELO.Visible = false;
            // 
            // CANTIDAD
            // 
            this.CANTIDAD.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.CANTIDAD.DataPropertyName = "CANTIDAD";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.CANTIDAD.DefaultCellStyle = dataGridViewCellStyle1;
            this.CANTIDAD.HeaderText = "Cant.";
            this.CANTIDAD.Name = "CANTIDAD";
            this.CANTIDAD.ReadOnly = true;
            this.CANTIDAD.Width = 57;
            // 
            // PRECIOUNIT
            // 
            this.PRECIOUNIT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.PRECIOUNIT.DataPropertyName = "preciounit";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.Format = "N2";
            dataGridViewCellStyle2.NullValue = "0.00";
            this.PRECIOUNIT.DefaultCellStyle = dataGridViewCellStyle2;
            this.PRECIOUNIT.HeaderText = "PrecioUnit.";
            this.PRECIOUNIT.Name = "PRECIOUNIT";
            this.PRECIOUNIT.Width = 84;
            // 
            // subtotale
            // 
            this.subtotale.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.subtotale.DataPropertyName = "subtotal";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.Format = "n2";
            dataGridViewCellStyle3.NullValue = "0.00";
            this.subtotale.DefaultCellStyle = dataGridViewCellStyle3;
            this.subtotale.HeaderText = "Subtotal";
            this.subtotale.Name = "subtotale";
            this.subtotale.ReadOnly = true;
            this.subtotale.Width = 71;
            // 
            // valueigv
            // 
            this.valueigv.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.valueigv.DataPropertyName = "valueigv";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle4.Format = "n2";
            dataGridViewCellStyle4.NullValue = "0.00";
            this.valueigv.DefaultCellStyle = dataGridViewCellStyle4;
            this.valueigv.HeaderText = "ImpRta";
            this.valueigv.Name = "valueigv";
            this.valueigv.ReadOnly = true;
            this.valueigv.Width = 66;
            // 
            // TOTALFAC
            // 
            this.TOTALFAC.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.TOTALFAC.DataPropertyName = "total";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle5.Format = "N2";
            dataGridViewCellStyle5.NullValue = "0.00";
            this.TOTALFAC.DefaultCellStyle = dataGridViewCellStyle5;
            this.TOTALFAC.HeaderText = "Total";
            this.TOTALFAC.Name = "TOTALFAC";
            this.TOTALFAC.ReadOnly = true;
            this.TOTALFAC.Width = 56;
            // 
            // numoc
            // 
            this.numoc.DataPropertyName = "oc";
            this.numoc.HeaderText = "oc";
            this.numoc.Name = "numoc";
            this.numoc.ReadOnly = true;
            this.numoc.Visible = false;
            // 
            // siigv
            // 
            this.siigv.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.siigv.DataPropertyName = "igv";
            this.siigv.HeaderText = "siigv";
            this.siigv.Name = "siigv";
            this.siigv.ReadOnly = true;
            this.siigv.Visible = false;
            // 
            // numigv
            // 
            this.numigv.Enabled = false;
            this.numigv.Location = new System.Drawing.Point(201, 66);
            this.numigv.Name = "numigv";
            this.numigv.Size = new System.Drawing.Size(38, 20);
            this.numigv.TabIndex = 15;
            this.numigv.Value = new decimal(new int[] {
            8,
            0,
            0,
            0});
            // 
            // cboigv
            // 
            this.cboigv.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboigv.FormattingEnabled = true;
            this.cboigv.Items.AddRange(new object[] {
            "Exonerado",
            "No Exonerado"});
            this.cboigv.Location = new System.Drawing.Point(72, 66);
            this.cboigv.Name = "cboigv";
            this.cboigv.Size = new System.Drawing.Size(123, 21);
            this.cboigv.TabIndex = 14;
            this.cboigv.SelectedIndexChanged += new System.EventHandler(this.cboigv_SelectedIndexChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(593, 70);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(34, 13);
            this.label15.TabIndex = 3;
            this.label15.Text = "Total:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(477, 70);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(44, 13);
            this.label14.TabIndex = 3;
            this.label14.Text = "ImpRta:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(344, 70);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(53, 13);
            this.label13.TabIndex = 3;
            this.label13.Text = "SubTotal:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nro Recibo";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(393, 44);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(95, 13);
            this.label9.TabIndex = 3;
            this.label9.Text = "Fecha Recepción:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(393, 18);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(94, 13);
            this.label17.TabIndex = 3;
            this.label17.Text = "Fecha Cancelado:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(206, 18);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 13);
            this.label8.TabIndex = 3;
            this.label8.Text = "Fecha Emision:";
            // 
            // Dtfechaentregado
            // 
            this.Dtfechaentregado.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.Dtfechaentregado.Location = new System.Drawing.Point(487, 14);
            this.Dtfechaentregado.Name = "Dtfechaentregado";
            this.Dtfechaentregado.Size = new System.Drawing.Size(100, 20);
            this.Dtfechaentregado.TabIndex = 12;
            // 
            // dtfechaemision
            // 
            this.dtfechaemision.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtfechaemision.Location = new System.Drawing.Point(287, 14);
            this.dtfechaemision.Name = "dtfechaemision";
            this.dtfechaemision.Size = new System.Drawing.Size(100, 20);
            this.dtfechaemision.TabIndex = 12;
            // 
            // lblporcentaje
            // 
            this.lblporcentaje.AutoSize = true;
            this.lblporcentaje.Location = new System.Drawing.Point(239, 70);
            this.lblporcentaje.Name = "lblporcentaje";
            this.lblporcentaje.Size = new System.Drawing.Size(15, 13);
            this.lblporcentaje.TabIndex = 3;
            this.lblporcentaje.Text = "%";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Grava Renta";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Imagen:";
            // 
            // btnCargarFoto
            // 
            this.btnCargarFoto.Location = new System.Drawing.Point(363, 40);
            this.btnCargarFoto.Name = "btnCargarFoto";
            this.btnCargarFoto.Size = new System.Drawing.Size(24, 20);
            this.btnCargarFoto.TabIndex = 11;
            this.btnCargarFoto.Text = "- -";
            this.btnCargarFoto.UseVisualStyleBackColor = true;
            this.btnCargarFoto.Click += new System.EventHandler(this.btnCargarFoto_Click);
            // 
            // txttotal
            // 
            this.txttotal.Enabled = false;
            this.txttotal.Location = new System.Drawing.Point(627, 66);
            this.txttotal.Name = "txttotal";
            this.txttotal.Size = new System.Drawing.Size(78, 20);
            this.txttotal.TabIndex = 6;
            this.txttotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtigv
            // 
            this.txtigv.Enabled = false;
            this.txtigv.Location = new System.Drawing.Point(523, 66);
            this.txtigv.Name = "txtigv";
            this.txtigv.Size = new System.Drawing.Size(70, 20);
            this.txtigv.TabIndex = 6;
            this.txtigv.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtsubtotal
            // 
            this.txtsubtotal.Enabled = false;
            this.txtsubtotal.Location = new System.Drawing.Point(402, 66);
            this.txtsubtotal.Name = "txtsubtotal";
            this.txtsubtotal.Size = new System.Drawing.Size(75, 20);
            this.txtsubtotal.TabIndex = 6;
            this.txtsubtotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtnrofactura
            // 
            this.txtnrofactura.Location = new System.Drawing.Point(72, 14);
            this.txtnrofactura.Name = "txtnrofactura";
            this.txtnrofactura.Size = new System.Drawing.Size(128, 20);
            this.txtnrofactura.TabIndex = 6;
            // 
            // txtfoto
            // 
            this.txtfoto.Location = new System.Drawing.Point(72, 40);
            this.txtfoto.Name = "txtfoto";
            this.txtfoto.Size = new System.Drawing.Size(285, 20);
            this.txtfoto.TabIndex = 6;
            this.txtfoto.Tag = "";
            // 
            // btnaceptar
            // 
            this.btnaceptar.Enabled = false;
            this.btnaceptar.Location = new System.Drawing.Point(653, 614);
            this.btnaceptar.Name = "btnaceptar";
            this.btnaceptar.Size = new System.Drawing.Size(75, 23);
            this.btnaceptar.TabIndex = 33;
            this.btnaceptar.Text = "Aceptar";
            this.btnaceptar.UseVisualStyleBackColor = true;
            this.btnaceptar.Click += new System.EventHandler(this.btnaceptar_Click);
            // 
            // btncancelar
            // 
            this.btncancelar.Location = new System.Drawing.Point(734, 614);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(75, 23);
            this.btncancelar.TabIndex = 34;
            this.btncancelar.Text = "Cancelar";
            this.btncancelar.UseVisualStyleBackColor = true;
            this.btncancelar.Click += new System.EventHandler(this.btncancelar_Click);
            // 
            // txtTelefono
            // 
            this.txtTelefono.BackColor = System.Drawing.SystemColors.Control;
            this.txtTelefono.Enabled = false;
            this.txtTelefono.Location = new System.Drawing.Point(107, 89);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(295, 20);
            this.txtTelefono.TabIndex = 23;
            this.txtTelefono.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtRazonSocial
            // 
            this.txtRazonSocial.BackColor = System.Drawing.SystemColors.Control;
            this.txtRazonSocial.Enabled = false;
            this.txtRazonSocial.Location = new System.Drawing.Point(107, 37);
            this.txtRazonSocial.Name = "txtRazonSocial";
            this.txtRazonSocial.Size = new System.Drawing.Size(295, 20);
            this.txtRazonSocial.TabIndex = 25;
            this.txtRazonSocial.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtruc
            // 
            this.txtruc.Location = new System.Drawing.Point(107, 11);
            this.txtruc.MaxLength = 11;
            this.txtruc.Name = "txtruc";
            this.txtruc.Size = new System.Drawing.Size(100, 20);
            this.txtruc.TabIndex = 24;
            this.txtruc.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtruc.TextChanged += new System.EventHandler(this.txtruc_TextChanged);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(213, 15);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(28, 13);
            this.label16.TabIndex = 27;
            this.label16.Text = "Tipo";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 93);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 13);
            this.label7.TabIndex = 30;
            this.label7.Text = "Telefono Oficina:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 67);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 13);
            this.label6.TabIndex = 31;
            this.label6.Text = "Dirección Oficina:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 41);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 13);
            this.label5.TabIndex = 32;
            this.label5.Text = "Razon Social:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 29;
            this.label1.Text = "Ruc Proveedor:";
            // 
            // txtdireccion
            // 
            this.txtdireccion.BackColor = System.Drawing.SystemColors.Control;
            this.txtdireccion.Enabled = false;
            this.txtdireccion.Location = new System.Drawing.Point(107, 63);
            this.txtdireccion.Name = "txtdireccion";
            this.txtdireccion.Size = new System.Drawing.Size(418, 20);
            this.txtdireccion.TabIndex = 26;
            this.txtdireccion.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Openfd
            // 
            this.Openfd.Filter = "Archivos de Imagen|*.jpg|Todos los Archivos|*.*";
            // 
            // tooltip
            // 
            this.tooltip.IsBalloon = true;
            // 
            // frmREciboPorHonorario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(819, 651);
            this.Controls.Add(this.Dtguias);
            this.Controls.Add(this.btnagregar);
            this.Controls.Add(this.btnmaspro);
            this.Controls.Add(this.cbotipo);
            this.Controls.Add(this.gp1);
            this.Controls.Add(this.btnaceptar);
            this.Controls.Add(this.btncancelar);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.txtRazonSocial);
            this.Controls.Add(this.txtruc);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtdireccion);
            this.MaximumSize = new System.Drawing.Size(835, 690);
            this.MinimumSize = new System.Drawing.Size(835, 690);
            this.Name = "frmREciboPorHonorario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Recibo Por Honorarios";
            this.Load += new System.EventHandler(this.frmREciboPorHonorario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Dtguias)).EndInit();
            this.gp1.ResumeLayout(false);
            this.gp1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbfactura)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DtgConten)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numigv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView Dtguias;
        private System.Windows.Forms.Button btnagregar;
        private System.Windows.Forms.Button btnmaspro;
        private System.Windows.Forms.ComboBox cbotipo;
        private System.Windows.Forms.GroupBox gp1;
        private System.Windows.Forms.DateTimePicker DtFechaRecepcion;
        private System.Windows.Forms.TextBox txtmonto;
        private System.Windows.Forms.PictureBox pbfactura;
        private System.Windows.Forms.DataGridView DtgConten;
        private System.Windows.Forms.NumericUpDown numigv;
        private System.Windows.Forms.ComboBox cboigv;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker Dtfechaentregado;
        private System.Windows.Forms.DateTimePicker dtfechaemision;
        private System.Windows.Forms.Label lblporcentaje;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnCargarFoto;
        private System.Windows.Forms.TextBox txttotal;
        private System.Windows.Forms.TextBox txtigv;
        private System.Windows.Forms.TextBox txtsubtotal;
        private System.Windows.Forms.TextBox txtnrofactura;
        private System.Windows.Forms.TextBox txtfoto;
        private System.Windows.Forms.Button btnaceptar;
        private System.Windows.Forms.Button btncancelar;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.TextBox txtRazonSocial;
        private System.Windows.Forms.TextBox txtruc;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtdireccion;
        private System.Windows.Forms.OpenFileDialog Openfd;
        private System.Windows.Forms.ToolTip tooltip;
        private System.Windows.Forms.DataGridViewCheckBoxColumn OK;
        private System.Windows.Forms.DataGridViewTextBoxColumn FIC1;
        private System.Windows.Forms.DataGridViewTextBoxColumn OC;
        private System.Windows.Forms.DataGridViewTextBoxColumn GUIA;
        private System.Windows.Forms.DataGridViewTextBoxColumn FECHAENTREGA;
        private System.Windows.Forms.Button btndescargar;
        private System.Windows.Forms.DataGridViewTextBoxColumn numfic;
        private System.Windows.Forms.DataGridViewTextBoxColumn DESCRIPCION;
        private System.Windows.Forms.DataGridViewTextBoxColumn cc;
        private System.Windows.Forms.DataGridViewTextBoxColumn MARCA;
        private System.Windows.Forms.DataGridViewTextBoxColumn MODELO;
        private System.Windows.Forms.DataGridViewTextBoxColumn CANTIDAD;
        private System.Windows.Forms.DataGridViewTextBoxColumn PRECIOUNIT;
        private System.Windows.Forms.DataGridViewTextBoxColumn subtotale;
        private System.Windows.Forms.DataGridViewTextBoxColumn valueigv;
        private System.Windows.Forms.DataGridViewTextBoxColumn TOTALFAC;
        private System.Windows.Forms.DataGridViewTextBoxColumn numoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn siigv;
    }
}