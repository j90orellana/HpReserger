namespace HPReserger
{
    partial class frmPagarFactura
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
            this.Dtguias = new System.Windows.Forms.DataGridView();
            this.OK = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.tipodoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nrofactura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.proveedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.razon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subtotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Igv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.detraccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaEmision = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaRecepcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaCancelado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbobanco = new System.Windows.Forms.ComboBox();
            this.btnmaspro = new System.Windows.Forms.Button();
            this.cbotipo = new System.Windows.Forms.ComboBox();
            this.btnaceptar = new System.Windows.Forms.Button();
            this.btncancelar = new System.Windows.Forms.Button();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.txtRazonSocial = new System.Windows.Forms.TextBox();
            this.txtruc = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.lblguia = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtdireccion = new System.Windows.Forms.TextBox();
            this.cbocuentabanco = new System.Windows.Forms.ComboBox();
            this.lblguia1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtnropago = new System.Windows.Forms.TextBox();
            this.txttotal = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SaveFile = new System.Windows.Forms.SaveFileDialog();
            this.label4 = new System.Windows.Forms.Label();
            this.txttotaldetrac = new System.Windows.Forms.TextBox();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.dtpfin = new System.Windows.Forms.DateTimePicker();
            this.dtpini = new System.Windows.Forms.DateTimePicker();
            this.chkrecepcion = new System.Windows.Forms.CheckBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dtfin = new System.Windows.Forms.DateTimePicker();
            this.dtinicio = new System.Windows.Forms.DateTimePicker();
            this.txtbuscar = new System.Windows.Forms.TextBox();
            this.chkfecha = new System.Windows.Forms.CheckBox();
            this.chkprove = new System.Windows.Forms.CheckBox();
            this.lblmensaje = new System.Windows.Forms.Label();
            this.btnseleccion = new System.Windows.Forms.Button();
            this.btnReversar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Dtguias)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Dtguias
            // 
            this.Dtguias.AllowUserToAddRows = false;
            this.Dtguias.AllowUserToDeleteRows = false;
            this.Dtguias.AllowUserToResizeColumns = false;
            this.Dtguias.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Dtguias.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.Dtguias.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Dtguias.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Dtguias.BackgroundColor = System.Drawing.SystemColors.Control;
            this.Dtguias.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Franklin Gothic Book", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Dtguias.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.Dtguias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dtguias.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.OK,
            this.tipodoc,
            this.nrofactura,
            this.proveedor,
            this.razon,
            this.subtotal,
            this.Igv,
            this.Total,
            this.detraccion,
            this.FechaEmision,
            this.fechaRecepcion,
            this.FechaCancelado});
            this.Dtguias.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnF2;
            this.Dtguias.Location = new System.Drawing.Point(12, 150);
            this.Dtguias.MultiSelect = false;
            this.Dtguias.Name = "Dtguias";
            this.Dtguias.RowHeadersVisible = false;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Franklin Gothic Book", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dtguias.RowsDefaultCellStyle = dataGridViewCellStyle10;
            this.Dtguias.RowTemplate.Height = 18;
            this.Dtguias.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Dtguias.Size = new System.Drawing.Size(1059, 319);
            this.Dtguias.TabIndex = 40;
            this.Dtguias.TabStop = false;
            this.Dtguias.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dtguias_CellContentClick);
            this.Dtguias.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dtguias_CellDoubleClick);
            this.Dtguias.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dtguias_RowEnter);
            this.Dtguias.RowErrorTextChanged += new System.Windows.Forms.DataGridViewRowEventHandler(this.Dtguias_RowErrorTextChanged);
            this.Dtguias.Sorted += new System.EventHandler(this.Dtguias_Sorted);
            // 
            // OK
            // 
            this.OK.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.OK.DataPropertyName = "OK";
            this.OK.FalseValue = "False";
            this.OK.FillWeight = 126.9036F;
            this.OK.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.OK.HeaderText = "OK";
            this.OK.Name = "OK";
            this.OK.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.OK.TrueValue = "True";
            this.OK.Width = 50;
            // 
            // tipodoc
            // 
            this.tipodoc.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.tipodoc.DataPropertyName = "tipo";
            this.tipodoc.HeaderText = "T";
            this.tipodoc.Name = "tipodoc";
            this.tipodoc.ReadOnly = true;
            this.tipodoc.Width = 25;
            // 
            // nrofactura
            // 
            this.nrofactura.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.nrofactura.DataPropertyName = "nrofactura";
            this.nrofactura.HeaderText = "Comprobante";
            this.nrofactura.Name = "nrofactura";
            this.nrofactura.ReadOnly = true;
            this.nrofactura.Width = 96;
            // 
            // proveedor
            // 
            this.proveedor.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.proveedor.DataPropertyName = "proveedor";
            this.proveedor.HeaderText = "Proveedor";
            this.proveedor.Name = "proveedor";
            this.proveedor.ReadOnly = true;
            this.proveedor.Width = 81;
            // 
            // razon
            // 
            this.razon.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.razon.DataPropertyName = "razon";
            this.razon.HeaderText = "Razón Social";
            this.razon.Name = "razon";
            this.razon.ReadOnly = true;
            // 
            // subtotal
            // 
            this.subtotal.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.subtotal.DataPropertyName = "subtotal";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.Format = "n2";
            this.subtotal.DefaultCellStyle = dataGridViewCellStyle3;
            this.subtotal.HeaderText = "Subtotal";
            this.subtotal.Name = "subtotal";
            this.subtotal.ReadOnly = true;
            this.subtotal.Width = 71;
            // 
            // Igv
            // 
            this.Igv.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Igv.DataPropertyName = "Igv";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle4.Format = "n2";
            this.Igv.DefaultCellStyle = dataGridViewCellStyle4;
            this.Igv.HeaderText = "Igv/Rta";
            this.Igv.Name = "Igv";
            this.Igv.ReadOnly = true;
            this.Igv.Width = 66;
            // 
            // Total
            // 
            this.Total.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Total.DataPropertyName = "Total";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle5.Format = "n2";
            this.Total.DefaultCellStyle = dataGridViewCellStyle5;
            this.Total.HeaderText = "Total";
            this.Total.Name = "Total";
            this.Total.ReadOnly = true;
            this.Total.Width = 55;
            // 
            // detraccion
            // 
            this.detraccion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.detraccion.DataPropertyName = "detrac";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle6.Format = "n2";
            this.detraccion.DefaultCellStyle = dataGridViewCellStyle6;
            this.detraccion.HeaderText = "Detracción";
            this.detraccion.Name = "detraccion";
            this.detraccion.ReadOnly = true;
            this.detraccion.Width = 83;
            // 
            // FechaEmision
            // 
            this.FechaEmision.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.FechaEmision.DataPropertyName = "FechaEmision";
            dataGridViewCellStyle7.Format = "g";
            this.FechaEmision.DefaultCellStyle = dataGridViewCellStyle7;
            this.FechaEmision.HeaderText = "Fecha Emisión";
            this.FechaEmision.Name = "FechaEmision";
            this.FechaEmision.ReadOnly = true;
            this.FechaEmision.Width = 94;
            // 
            // fechaRecepcion
            // 
            this.fechaRecepcion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.fechaRecepcion.DataPropertyName = "fechaRecepcion";
            dataGridViewCellStyle8.Format = "g";
            dataGridViewCellStyle8.NullValue = null;
            this.fechaRecepcion.DefaultCellStyle = dataGridViewCellStyle8;
            this.fechaRecepcion.HeaderText = "Fecha Recepción";
            this.fechaRecepcion.Name = "fechaRecepcion";
            this.fechaRecepcion.ReadOnly = true;
            this.fechaRecepcion.Width = 105;
            // 
            // FechaCancelado
            // 
            this.FechaCancelado.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.FechaCancelado.DataPropertyName = "FechaCancelado";
            dataGridViewCellStyle9.Format = "g";
            this.FechaCancelado.DefaultCellStyle = dataGridViewCellStyle9;
            this.FechaCancelado.HeaderText = "Fecha Cancelado";
            this.FechaCancelado.Name = "FechaCancelado";
            this.FechaCancelado.ReadOnly = true;
            this.FechaCancelado.Width = 105;
            // 
            // cbobanco
            // 
            this.cbobanco.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbobanco.FormattingEnabled = true;
            this.cbobanco.Location = new System.Drawing.Point(73, 44);
            this.cbobanco.Name = "cbobanco";
            this.cbobanco.Size = new System.Drawing.Size(270, 21);
            this.cbobanco.TabIndex = 38;
            this.cbobanco.SelectedIndexChanged += new System.EventHandler(this.cbobanco_SelectedIndexChanged);
            // 
            // btnmaspro
            // 
            this.btnmaspro.Location = new System.Drawing.Point(1128, 57);
            this.btnmaspro.Name = "btnmaspro";
            this.btnmaspro.Size = new System.Drawing.Size(24, 20);
            this.btnmaspro.TabIndex = 37;
            this.btnmaspro.Text = "- -";
            this.btnmaspro.UseVisualStyleBackColor = true;
            this.btnmaspro.Visible = false;
            // 
            // cbotipo
            // 
            this.cbotipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbotipo.FormattingEnabled = true;
            this.cbotipo.Items.AddRange(new object[] {
            "003 TRANSFERENCIA DE FONDOS",
            "007 CHEQUES CON LA CLÁUSULA DE \"NO NEGOCIABLE\", \"INTRANSFERIBLES\", \"NO A LA ORDEN" +
                "\" U OTRA EQUIVALENTE, A QUE SE REFIERE EL INCISO G) DEL ARTICULO 5° DE LA LEY",
            "009 EFECTIVO, EN LOS DEMÁS CASOS"});
            this.cbotipo.Location = new System.Drawing.Point(287, 18);
            this.cbotipo.Name = "cbotipo";
            this.cbotipo.Size = new System.Drawing.Size(430, 21);
            this.cbotipo.TabIndex = 36;
            this.cbotipo.SelectedIndexChanged += new System.EventHandler(this.cbotipo_SelectedIndexChanged);
            // 
            // btnaceptar
            // 
            this.btnaceptar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnaceptar.Location = new System.Drawing.Point(915, 526);
            this.btnaceptar.Name = "btnaceptar";
            this.btnaceptar.Size = new System.Drawing.Size(75, 23);
            this.btnaceptar.TabIndex = 33;
            this.btnaceptar.Text = "Pagar";
            this.btnaceptar.UseVisualStyleBackColor = true;
            this.btnaceptar.Click += new System.EventHandler(this.btnaceptar_Click);
            // 
            // btncancelar
            // 
            this.btncancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btncancelar.Location = new System.Drawing.Point(996, 526);
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
            this.txtTelefono.Location = new System.Drawing.Point(1048, 96);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(295, 20);
            this.txtTelefono.TabIndex = 23;
            this.txtTelefono.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtTelefono.Visible = false;
            // 
            // txtRazonSocial
            // 
            this.txtRazonSocial.BackColor = System.Drawing.SystemColors.Control;
            this.txtRazonSocial.Enabled = false;
            this.txtRazonSocial.Location = new System.Drawing.Point(1048, 44);
            this.txtRazonSocial.Name = "txtRazonSocial";
            this.txtRazonSocial.Size = new System.Drawing.Size(295, 20);
            this.txtRazonSocial.TabIndex = 25;
            this.txtRazonSocial.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtRazonSocial.Visible = false;
            // 
            // txtruc
            // 
            this.txtruc.Location = new System.Drawing.Point(1048, 18);
            this.txtruc.MaxLength = 11;
            this.txtruc.Name = "txtruc";
            this.txtruc.Size = new System.Drawing.Size(122, 20);
            this.txtruc.TabIndex = 24;
            this.txtruc.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtruc.Visible = false;
            this.txtruc.TextChanged += new System.EventHandler(this.txtruc_TextChanged);
            this.txtruc.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtruc_KeyDown);
            this.txtruc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtruc_KeyPress);
            this.txtruc.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtruc_KeyUp);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(246, 22);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(35, 13);
            this.label16.TabIndex = 27;
            this.label16.Text = "Pago:";
            // 
            // lblguia
            // 
            this.lblguia.AutoSize = true;
            this.lblguia.Location = new System.Drawing.Point(12, 48);
            this.lblguia.Name = "lblguia";
            this.lblguia.Size = new System.Drawing.Size(41, 13);
            this.lblguia.TabIndex = 28;
            this.lblguia.Text = "Banco:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(954, 99);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 13);
            this.label7.TabIndex = 30;
            this.label7.Text = "Telefono Oficina:";
            this.label7.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(954, 73);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 13);
            this.label6.TabIndex = 31;
            this.label6.Text = "Dirección Oficina:";
            this.label6.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(954, 47);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 13);
            this.label5.TabIndex = 32;
            this.label5.Text = "Razon Social:";
            this.label5.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(954, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 29;
            this.label1.Text = "Ruc Proveedor:";
            this.label1.Visible = false;
            // 
            // txtdireccion
            // 
            this.txtdireccion.BackColor = System.Drawing.SystemColors.Control;
            this.txtdireccion.Enabled = false;
            this.txtdireccion.Location = new System.Drawing.Point(1048, 70);
            this.txtdireccion.Name = "txtdireccion";
            this.txtdireccion.Size = new System.Drawing.Size(418, 20);
            this.txtdireccion.TabIndex = 26;
            this.txtdireccion.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtdireccion.Visible = false;
            // 
            // cbocuentabanco
            // 
            this.cbocuentabanco.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbocuentabanco.FormattingEnabled = true;
            this.cbocuentabanco.Location = new System.Drawing.Point(425, 44);
            this.cbocuentabanco.Name = "cbocuentabanco";
            this.cbocuentabanco.Size = new System.Drawing.Size(292, 21);
            this.cbocuentabanco.TabIndex = 42;
            // 
            // lblguia1
            // 
            this.lblguia1.AutoSize = true;
            this.lblguia1.Location = new System.Drawing.Point(344, 48);
            this.lblguia1.Name = "lblguia1";
            this.lblguia1.Size = new System.Drawing.Size(78, 13);
            this.lblguia1.TabIndex = 41;
            this.lblguia1.Text = "Cuenta Banco:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 43;
            this.label2.Text = "Nro Pago:";
            // 
            // txtnropago
            // 
            this.txtnropago.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtnropago.Enabled = false;
            this.txtnropago.Location = new System.Drawing.Point(73, 18);
            this.txtnropago.Name = "txtnropago";
            this.txtnropago.Size = new System.Drawing.Size(155, 20);
            this.txtnropago.TabIndex = 44;
            // 
            // txttotal
            // 
            this.txttotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txttotal.Enabled = false;
            this.txttotal.Location = new System.Drawing.Point(972, 501);
            this.txttotal.Name = "txttotal";
            this.txttotal.Size = new System.Drawing.Size(99, 20);
            this.txttotal.TabIndex = 45;
            this.txttotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(892, 504);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 41;
            this.label3.Text = "Total a Pagar:";
            // 
            // SaveFile
            // 
            this.SaveFile.Filter = "Archivos de Texto|*.txt";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(880, 478);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 13);
            this.label4.TabIndex = 46;
            this.label4.Text = "Total Detracción";
            // 
            // txttotaldetrac
            // 
            this.txttotaldetrac.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txttotaldetrac.Enabled = false;
            this.txttotaldetrac.Location = new System.Drawing.Point(971, 475);
            this.txttotaldetrac.Name = "txttotaldetrac";
            this.txttotaldetrac.Size = new System.Drawing.Size(100, 20);
            this.txttotaldetrac.TabIndex = 47;
            this.txttotaldetrac.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(723, 43);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(75, 23);
            this.btnActualizar.TabIndex = 48;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.dtpfin);
            this.groupBox1.Controls.Add(this.dtpini);
            this.groupBox1.Controls.Add(this.chkrecepcion);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.dtfin);
            this.groupBox1.Controls.Add(this.dtinicio);
            this.groupBox1.Controls.Add(this.txtbuscar);
            this.groupBox1.Controls.Add(this.chkfecha);
            this.groupBox1.Controls.Add(this.chkprove);
            this.groupBox1.Location = new System.Drawing.Point(15, 74);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1056, 48);
            this.groupBox1.TabIndex = 49;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Busqueda";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(875, 21);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(38, 13);
            this.label10.TabIndex = 56;
            this.label10.Text = "Hasta:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(760, 21);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(24, 13);
            this.label11.TabIndex = 55;
            this.label11.Text = "De:";
            // 
            // dtpfin
            // 
            this.dtpfin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpfin.Location = new System.Drawing.Point(919, 17);
            this.dtpfin.Name = "dtpfin";
            this.dtpfin.Size = new System.Drawing.Size(79, 20);
            this.dtpfin.TabIndex = 54;
            this.dtpfin.ValueChanged += new System.EventHandler(this.dtpfin_ValueChanged);
            // 
            // dtpini
            // 
            this.dtpini.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpini.Location = new System.Drawing.Point(790, 17);
            this.dtpini.Name = "dtpini";
            this.dtpini.Size = new System.Drawing.Size(79, 20);
            this.dtpini.TabIndex = 53;
            this.dtpini.ValueChanged += new System.EventHandler(this.dtpini_ValueChanged);
            // 
            // chkrecepcion
            // 
            this.chkrecepcion.AutoSize = true;
            this.chkrecepcion.Location = new System.Drawing.Point(649, 19);
            this.chkrecepcion.Name = "chkrecepcion";
            this.chkrecepcion.Size = new System.Drawing.Size(114, 17);
            this.chkrecepcion.TabIndex = 52;
            this.chkrecepcion.Text = "Fecha Recepción:";
            this.chkrecepcion.UseVisualStyleBackColor = true;
            this.chkrecepcion.CheckedChanged += new System.EventHandler(this.chkrecepcion_CheckedChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(520, 21);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(38, 13);
            this.label9.TabIndex = 51;
            this.label9.Text = "Hasta:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(405, 21);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(24, 13);
            this.label8.TabIndex = 50;
            this.label8.Text = "De:";
            // 
            // dtfin
            // 
            this.dtfin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtfin.Location = new System.Drawing.Point(564, 17);
            this.dtfin.Name = "dtfin";
            this.dtfin.Size = new System.Drawing.Size(79, 20);
            this.dtfin.TabIndex = 4;
            this.dtfin.ValueChanged += new System.EventHandler(this.dtfin_ValueChanged);
            // 
            // dtinicio
            // 
            this.dtinicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtinicio.Location = new System.Drawing.Point(435, 17);
            this.dtinicio.Name = "dtinicio";
            this.dtinicio.Size = new System.Drawing.Size(79, 20);
            this.dtinicio.TabIndex = 3;
            this.dtinicio.ValueChanged += new System.EventHandler(this.dtinicio_ValueChanged);
            // 
            // txtbuscar
            // 
            this.txtbuscar.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtbuscar.Location = new System.Drawing.Point(97, 17);
            this.txtbuscar.Name = "txtbuscar";
            this.txtbuscar.Size = new System.Drawing.Size(190, 20);
            this.txtbuscar.TabIndex = 2;
            this.txtbuscar.TextChanged += new System.EventHandler(this.txtbuscar_TextChanged);
            // 
            // chkfecha
            // 
            this.chkfecha.AutoSize = true;
            this.chkfecha.Location = new System.Drawing.Point(294, 19);
            this.chkfecha.Name = "chkfecha";
            this.chkfecha.Size = new System.Drawing.Size(113, 17);
            this.chkfecha.TabIndex = 1;
            this.chkfecha.Text = "Fecha Cancelado:";
            this.chkfecha.UseVisualStyleBackColor = true;
            this.chkfecha.CheckedChanged += new System.EventHandler(this.chkfecha_CheckedChanged);
            // 
            // chkprove
            // 
            this.chkprove.AutoSize = true;
            this.chkprove.Location = new System.Drawing.Point(16, 19);
            this.chkprove.Name = "chkprove";
            this.chkprove.Size = new System.Drawing.Size(78, 17);
            this.chkprove.TabIndex = 0;
            this.chkprove.Text = "Proveedor:";
            this.chkprove.UseVisualStyleBackColor = true;
            this.chkprove.CheckedChanged += new System.EventHandler(this.chkprove_CheckedChanged);
            // 
            // lblmensaje
            // 
            this.lblmensaje.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblmensaje.AutoSize = true;
            this.lblmensaje.Location = new System.Drawing.Point(9, 480);
            this.lblmensaje.Name = "lblmensaje";
            this.lblmensaje.Size = new System.Drawing.Size(109, 13);
            this.lblmensaje.TabIndex = 50;
            this.lblmensaje.Text = "Número de Registros:";
            // 
            // btnseleccion
            // 
            this.btnseleccion.Location = new System.Drawing.Point(12, 125);
            this.btnseleccion.Name = "btnseleccion";
            this.btnseleccion.Size = new System.Drawing.Size(122, 23);
            this.btnseleccion.TabIndex = 51;
            this.btnseleccion.Text = "Seleccionar Todos";
            this.btnseleccion.UseVisualStyleBackColor = true;
            this.btnseleccion.Click += new System.EventHandler(this.btnseleccion_Click);
            // 
            // btnReversar
            // 
            this.btnReversar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnReversar.Location = new System.Drawing.Point(509, 475);
            this.btnReversar.Name = "btnReversar";
            this.btnReversar.Size = new System.Drawing.Size(75, 23);
            this.btnReversar.TabIndex = 52;
            this.btnReversar.Text = "Reversar";
            this.btnReversar.UseVisualStyleBackColor = true;
            this.btnReversar.Click += new System.EventHandler(this.btnReversar_Click);
            // 
            // frmPagarFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1085, 561);
            this.Controls.Add(this.btnReversar);
            this.Controls.Add(this.btnseleccion);
            this.Controls.Add(this.lblmensaje);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.txttotaldetrac);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txttotal);
            this.Controls.Add(this.txtnropago);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbocuentabanco);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblguia1);
            this.Controls.Add(this.Dtguias);
            this.Controls.Add(this.cbobanco);
            this.Controls.Add(this.btnmaspro);
            this.Controls.Add(this.cbotipo);
            this.Controls.Add(this.btnaceptar);
            this.Controls.Add(this.btncancelar);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.txtRazonSocial);
            this.Controls.Add(this.txtruc);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.lblguia);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtdireccion);
            this.MinimumSize = new System.Drawing.Size(1101, 600);
            this.Name = "frmPagarFactura";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pagar Comprobantes";
            this.Load += new System.EventHandler(this.frmPagarFactura_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Dtguias)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView Dtguias;
        private System.Windows.Forms.ComboBox cbobanco;
        private System.Windows.Forms.Button btnmaspro;
        private System.Windows.Forms.ComboBox cbotipo;
        private System.Windows.Forms.Button btnaceptar;
        private System.Windows.Forms.Button btncancelar;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.TextBox txtRazonSocial;
        private System.Windows.Forms.TextBox txtruc;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label lblguia;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtdireccion;
        private System.Windows.Forms.ComboBox cbocuentabanco;
        private System.Windows.Forms.Label lblguia1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtnropago;
        private System.Windows.Forms.TextBox txttotal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.SaveFileDialog SaveFile;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txttotaldetrac;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dtfin;
        private System.Windows.Forms.DateTimePicker dtinicio;
        private System.Windows.Forms.TextBox txtbuscar;
        private System.Windows.Forms.CheckBox chkfecha;
        private System.Windows.Forms.CheckBox chkprove;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DateTimePicker dtpfin;
        private System.Windows.Forms.DateTimePicker dtpini;
        private System.Windows.Forms.CheckBox chkrecepcion;
        private System.Windows.Forms.Label lblmensaje;
        private System.Windows.Forms.Button btnseleccion;
        private System.Windows.Forms.Button btnReversar;
        private System.Windows.Forms.DataGridViewCheckBoxColumn OK;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipodoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn nrofactura;
        private System.Windows.Forms.DataGridViewTextBoxColumn proveedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn razon;
        private System.Windows.Forms.DataGridViewTextBoxColumn subtotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn Igv;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private System.Windows.Forms.DataGridViewTextBoxColumn detraccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaEmision;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaRecepcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaCancelado;
    }
}