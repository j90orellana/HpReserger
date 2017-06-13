namespace HPReserger
{
    partial class FrmFactura
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
            this.txtnrofactura = new System.Windows.Forms.TextBox();
            this.txtruc = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblguia = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btncancelar = new System.Windows.Forms.Button();
            this.btnaceptar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtfoto = new System.Windows.Forms.TextBox();
            this.btnCargarFoto = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtRazonSocial = new System.Windows.Forms.TextBox();
            this.txtdireccion = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dtfechaemision = new System.Windows.Forms.DateTimePicker();
            this.gp1 = new System.Windows.Forms.GroupBox();
            this.txtmonto = new System.Windows.Forms.TextBox();
            this.pbfactura = new System.Windows.Forms.PictureBox();
            this.DtgConten = new System.Windows.Forms.DataGridView();
            this.numigv = new System.Windows.Forms.NumericUpDown();
            this.cboigv = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.Dtfechaentregado = new System.Windows.Forms.DateTimePicker();
            this.lblporcentaje = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txttotal = new System.Windows.Forms.TextBox();
            this.txtigv = new System.Windows.Forms.TextBox();
            this.txtsubtotal = new System.Windows.Forms.TextBox();
            this.Openfd = new System.Windows.Forms.OpenFileDialog();
            this.label16 = new System.Windows.Forms.Label();
            this.cbotipo = new System.Windows.Forms.ComboBox();
            this.btnmaspro = new System.Windows.Forms.Button();
            this.txtguia = new System.Windows.Forms.ComboBox();
            this.btnagregar = new System.Windows.Forms.Button();
            this.chlbx = new System.Windows.Forms.CheckedListBox();
            this.Dtguias = new System.Windows.Forms.DataGridView();
            this.FIC1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GUIA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FECHAENTREGA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OK = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.gpordenes = new System.Windows.Forms.GroupBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.tooltip = new System.Windows.Forms.ToolTip(this.components);
            this.label9 = new System.Windows.Forms.Label();
            this.DtFechaRecepcion = new System.Windows.Forms.DateTimePicker();
            this.gp1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbfactura)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DtgConten)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numigv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dtguias)).BeginInit();
            this.gpordenes.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtnrofactura
            // 
            this.txtnrofactura.Location = new System.Drawing.Point(72, 14);
            this.txtnrofactura.Name = "txtnrofactura";
            this.txtnrofactura.Size = new System.Drawing.Size(128, 20);
            this.txtnrofactura.TabIndex = 6;
            this.txtnrofactura.TextChanged += new System.EventHandler(this.txtnrofactura_TextChanged);
            this.txtnrofactura.Leave += new System.EventHandler(this.txtnrofactura_Leave);
            // 
            // txtruc
            // 
            this.txtruc.Location = new System.Drawing.Point(106, 12);
            this.txtruc.Name = "txtruc";
            this.txtruc.Size = new System.Drawing.Size(100, 20);
            this.txtruc.TabIndex = 0;
            this.txtruc.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtruc.TextChanged += new System.EventHandler(this.txtruc_TextChanged);
            this.txtruc.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtruc_KeyDown);
            this.txtruc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtruc_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nro Factura:";
            // 
            // lblguia
            // 
            this.lblguia.AutoSize = true;
            this.lblguia.Location = new System.Drawing.Point(340, 15);
            this.lblguia.Name = "lblguia";
            this.lblguia.Size = new System.Drawing.Size(78, 13);
            this.lblguia.TabIndex = 4;
            this.lblguia.Text = "Guia Remision:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Ruc Proveedor:";
            // 
            // btncancelar
            // 
            this.btncancelar.Location = new System.Drawing.Point(733, 614);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(75, 23);
            this.btncancelar.TabIndex = 10;
            this.btncancelar.Text = "Cancelar";
            this.btncancelar.UseVisualStyleBackColor = true;
            this.btncancelar.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnaceptar
            // 
            this.btnaceptar.Enabled = false;
            this.btnaceptar.Location = new System.Drawing.Point(652, 614);
            this.btnaceptar.Name = "btnaceptar";
            this.btnaceptar.Size = new System.Drawing.Size(75, 23);
            this.btnaceptar.TabIndex = 10;
            this.btnaceptar.Text = "Aceptar";
            this.btnaceptar.UseVisualStyleBackColor = true;
            this.btnaceptar.Click += new System.EventHandler(this.btnaceptar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Imagen:";
            // 
            // txtfoto
            // 
            this.txtfoto.Location = new System.Drawing.Point(72, 40);
            this.txtfoto.Name = "txtfoto";
            this.txtfoto.Size = new System.Drawing.Size(285, 20);
            this.txtfoto.TabIndex = 6;
            this.txtfoto.Tag = "";
            // 
            // btnCargarFoto
            // 
            this.btnCargarFoto.Location = new System.Drawing.Point(363, 39);
            this.btnCargarFoto.Name = "btnCargarFoto";
            this.btnCargarFoto.Size = new System.Drawing.Size(24, 20);
            this.btnCargarFoto.TabIndex = 11;
            this.btnCargarFoto.Text = "- -";
            this.btnCargarFoto.UseVisualStyleBackColor = true;
            this.btnCargarFoto.Click += new System.EventHandler(this.btnCargarFoto_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 41);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Razon Social:";
            // 
            // txtRazonSocial
            // 
            this.txtRazonSocial.BackColor = System.Drawing.SystemColors.Control;
            this.txtRazonSocial.Enabled = false;
            this.txtRazonSocial.Location = new System.Drawing.Point(106, 38);
            this.txtRazonSocial.Name = "txtRazonSocial";
            this.txtRazonSocial.Size = new System.Drawing.Size(295, 20);
            this.txtRazonSocial.TabIndex = 0;
            this.txtRazonSocial.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtdireccion
            // 
            this.txtdireccion.BackColor = System.Drawing.SystemColors.Control;
            this.txtdireccion.Enabled = false;
            this.txtdireccion.Location = new System.Drawing.Point(106, 64);
            this.txtdireccion.Name = "txtdireccion";
            this.txtdireccion.Size = new System.Drawing.Size(418, 20);
            this.txtdireccion.TabIndex = 0;
            this.txtdireccion.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 67);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Dirección Oficina:";
            // 
            // txtTelefono
            // 
            this.txtTelefono.BackColor = System.Drawing.SystemColors.Control;
            this.txtTelefono.Enabled = false;
            this.txtTelefono.Location = new System.Drawing.Point(106, 90);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(295, 20);
            this.txtTelefono.TabIndex = 0;
            this.txtTelefono.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 93);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "Telefono Oficina:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(206, 16);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 13);
            this.label8.TabIndex = 3;
            this.label8.Text = "Fecha Emision:";
            // 
            // dtfechaemision
            // 
            this.dtfechaemision.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtfechaemision.Location = new System.Drawing.Point(287, 14);
            this.dtfechaemision.Name = "dtfechaemision";
            this.dtfechaemision.Size = new System.Drawing.Size(100, 20);
            this.dtfechaemision.TabIndex = 12;
            this.dtfechaemision.ValueChanged += new System.EventHandler(this.dtfechaemision_ValueChanged);
            // 
            // gp1
            // 
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
            this.gp1.Location = new System.Drawing.Point(15, 306);
            this.gp1.Name = "gp1";
            this.gp1.Size = new System.Drawing.Size(712, 302);
            this.gp1.TabIndex = 13;
            this.gp1.TabStop = false;
            // 
            // txtmonto
            // 
            this.txtmonto.Location = new System.Drawing.Point(260, 67);
            this.txtmonto.Name = "txtmonto";
            this.txtmonto.Size = new System.Drawing.Size(78, 20);
            this.txtmonto.TabIndex = 18;
            this.txtmonto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtmonto.TextChanged += new System.EventHandler(this.txtmonto_TextChanged);
            this.txtmonto.DoubleClick += new System.EventHandler(this.txtmonto_DoubleClick);
            this.txtmonto.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtmonto_KeyDown);
            this.txtmonto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtmonto_KeyPress);
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
            // 
            // DtgConten
            // 
            this.DtgConten.AllowUserToAddRows = false;
            this.DtgConten.AllowUserToDeleteRows = false;
            this.DtgConten.AllowUserToOrderColumns = true;
            this.DtgConten.AllowUserToResizeColumns = false;
            this.DtgConten.AllowUserToResizeRows = false;
            this.DtgConten.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DtgConten.BackgroundColor = System.Drawing.SystemColors.Control;
            this.DtgConten.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DtgConten.Enabled = false;
            this.DtgConten.Location = new System.Drawing.Point(6, 93);
            this.DtgConten.Name = "DtgConten";
            this.DtgConten.RowHeadersVisible = false;
            this.DtgConten.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DtgConten.Size = new System.Drawing.Size(699, 196);
            this.DtgConten.TabIndex = 16;
            this.DtgConten.TabStop = false;
            // 
            // numigv
            // 
            this.numigv.Enabled = false;
            this.numigv.Location = new System.Drawing.Point(201, 67);
            this.numigv.Name = "numigv";
            this.numigv.Size = new System.Drawing.Size(38, 20);
            this.numigv.TabIndex = 15;
            this.numigv.Value = new decimal(new int[] {
            18,
            0,
            0,
            0});
            this.numigv.ValueChanged += new System.EventHandler(this.numigv_ValueChanged);
            // 
            // cboigv
            // 
            this.cboigv.FormattingEnabled = true;
            this.cboigv.Items.AddRange(new object[] {
            "SI (IGV Incluido)",
            "SI (IGV No Incluido)",
            "NO"});
            this.cboigv.Location = new System.Drawing.Point(72, 66);
            this.cboigv.Name = "cboigv";
            this.cboigv.Size = new System.Drawing.Size(123, 21);
            this.cboigv.TabIndex = 14;
            this.cboigv.SelectedIndexChanged += new System.EventHandler(this.cboigv_SelectedIndexChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(591, 69);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(34, 13);
            this.label15.TabIndex = 3;
            this.label15.Text = "Total:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(484, 69);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(28, 13);
            this.label14.TabIndex = 3;
            this.label14.Text = "IGV:";
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
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(393, 17);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(94, 13);
            this.label17.TabIndex = 3;
            this.label17.Text = "Fecha Cancelado:";
            // 
            // Dtfechaentregado
            // 
            this.Dtfechaentregado.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.Dtfechaentregado.Location = new System.Drawing.Point(487, 14);
            this.Dtfechaentregado.Name = "Dtfechaentregado";
            this.Dtfechaentregado.Size = new System.Drawing.Size(100, 20);
            this.Dtfechaentregado.TabIndex = 12;
            this.Dtfechaentregado.ValueChanged += new System.EventHandler(this.Dtfechaentregado_ValueChanged);
            // 
            // lblporcentaje
            // 
            this.lblporcentaje.AutoSize = true;
            this.lblporcentaje.Location = new System.Drawing.Point(239, 69);
            this.lblporcentaje.Name = "lblporcentaje";
            this.lblporcentaje.Size = new System.Drawing.Size(15, 13);
            this.lblporcentaje.TabIndex = 3;
            this.lblporcentaje.Text = "%";
            this.lblporcentaje.Click += new System.EventHandler(this.lblporcentaje_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Grava IGV:";
            // 
            // txttotal
            // 
            this.txttotal.Location = new System.Drawing.Point(627, 66);
            this.txttotal.Name = "txttotal";
            this.txttotal.Size = new System.Drawing.Size(78, 20);
            this.txttotal.TabIndex = 6;
            this.txttotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtigv
            // 
            this.txtigv.Enabled = false;
            this.txtigv.Location = new System.Drawing.Point(517, 66);
            this.txtigv.Name = "txtigv";
            this.txtigv.Size = new System.Drawing.Size(70, 20);
            this.txtigv.TabIndex = 6;
            this.txtigv.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtigv.TextChanged += new System.EventHandler(this.txtigv_TextChanged);
            this.txtigv.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtigv_KeyDown);
            this.txtigv.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtigv_KeyPress);
            // 
            // txtsubtotal
            // 
            this.txtsubtotal.Location = new System.Drawing.Point(403, 66);
            this.txtsubtotal.Name = "txtsubtotal";
            this.txtsubtotal.Size = new System.Drawing.Size(75, 20);
            this.txtsubtotal.TabIndex = 6;
            this.txtsubtotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtsubtotal.TextChanged += new System.EventHandler(this.txtsubtotal_TextChanged);
            this.txtsubtotal.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtsubtotal_KeyDown);
            this.txtsubtotal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtsubtotal_KeyPress);
            // 
            // Openfd
            // 
            this.Openfd.Filter = "Archivos de Imagen|*.jpg|Todos los Archivos|*.*";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(212, 15);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(28, 13);
            this.label16.TabIndex = 4;
            this.label16.Text = "Tipo";
            // 
            // cbotipo
            // 
            this.cbotipo.Enabled = false;
            this.cbotipo.FormattingEnabled = true;
            this.cbotipo.Location = new System.Drawing.Point(246, 11);
            this.cbotipo.Name = "cbotipo";
            this.cbotipo.Size = new System.Drawing.Size(88, 21);
            this.cbotipo.TabIndex = 14;
            this.cbotipo.SelectedIndexChanged += new System.EventHandler(this.cbotipo_SelectedIndexChanged);
            // 
            // btnmaspro
            // 
            this.btnmaspro.Location = new System.Drawing.Point(407, 38);
            this.btnmaspro.Name = "btnmaspro";
            this.btnmaspro.Size = new System.Drawing.Size(24, 20);
            this.btnmaspro.TabIndex = 15;
            this.btnmaspro.Text = "- -";
            this.btnmaspro.UseVisualStyleBackColor = true;
            this.btnmaspro.Click += new System.EventHandler(this.btnmaspro_Click);
            // 
            // txtguia
            // 
            this.txtguia.Enabled = false;
            this.txtguia.FormattingEnabled = true;
            this.txtguia.Location = new System.Drawing.Point(424, 12);
            this.txtguia.Name = "txtguia";
            this.txtguia.Size = new System.Drawing.Size(100, 21);
            this.txtguia.TabIndex = 16;
            this.txtguia.SelectedIndexChanged += new System.EventHandler(this.txtguia_SelectedIndexChanged);
            this.txtguia.TextChanged += new System.EventHandler(this.txtguia_TextChanged);
            this.txtguia.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtguia_MouseClick);
            // 
            // btnagregar
            // 
            this.btnagregar.Enabled = false;
            this.btnagregar.Location = new System.Drawing.Point(733, 317);
            this.btnagregar.Name = "btnagregar";
            this.btnagregar.Size = new System.Drawing.Size(75, 23);
            this.btnagregar.TabIndex = 17;
            this.btnagregar.Text = "Ingresar";
            this.btnagregar.UseVisualStyleBackColor = true;
            this.btnagregar.Click += new System.EventHandler(this.btnagregar_Click);
            // 
            // chlbx
            // 
            this.chlbx.CheckOnClick = true;
            this.chlbx.FormattingEnabled = true;
            this.chlbx.Location = new System.Drawing.Point(929, 11);
            this.chlbx.Name = "chlbx";
            this.chlbx.Size = new System.Drawing.Size(100, 109);
            this.chlbx.TabIndex = 20;
            this.chlbx.ThreeDCheckBoxes = true;
            this.chlbx.Visible = false;
            this.chlbx.Click += new System.EventHandler(this.chlbx_Click);
            this.chlbx.SelectedIndexChanged += new System.EventHandler(this.chlbx_SelectedIndexChanged);
            this.chlbx.MouseLeave += new System.EventHandler(this.chlbx_MouseLeave);
            // 
            // Dtguias
            // 
            this.Dtguias.AllowUserToAddRows = false;
            this.Dtguias.AllowUserToDeleteRows = false;
            this.Dtguias.AllowUserToResizeColumns = false;
            this.Dtguias.AllowUserToResizeRows = false;
            this.Dtguias.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Dtguias.BackgroundColor = System.Drawing.SystemColors.Control;
            this.Dtguias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dtguias.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FIC1,
            this.OC,
            this.GUIA,
            this.FECHAENTREGA,
            this.OK});
            this.Dtguias.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnF2;
            this.Dtguias.Location = new System.Drawing.Point(21, 116);
            this.Dtguias.MultiSelect = false;
            this.Dtguias.Name = "Dtguias";
            this.Dtguias.RowHeadersVisible = false;
            this.Dtguias.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Dtguias.Size = new System.Drawing.Size(699, 184);
            this.Dtguias.TabIndex = 21;
            this.Dtguias.TabStop = false;
            this.Dtguias.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dtguias_CellContentClick);
            this.Dtguias.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dtguias_CellEndEdit);
            this.Dtguias.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dtguias_RowEnter);
            // 
            // FIC1
            // 
            this.FIC1.DataPropertyName = "FIC";
            this.FIC1.FillWeight = 93.27411F;
            this.FIC1.HeaderText = "FIC";
            this.FIC1.Name = "FIC1";
            // 
            // OC
            // 
            this.OC.DataPropertyName = "OC";
            this.OC.FillWeight = 93.27411F;
            this.OC.HeaderText = "OC";
            this.OC.Name = "OC";
            // 
            // GUIA
            // 
            this.GUIA.DataPropertyName = "GUIA";
            this.GUIA.FillWeight = 93.27411F;
            this.GUIA.HeaderText = "GUIA";
            this.GUIA.Name = "GUIA";
            // 
            // FECHAENTREGA
            // 
            this.FECHAENTREGA.DataPropertyName = "FECHAENTREGA";
            this.FECHAENTREGA.FillWeight = 93.27411F;
            this.FECHAENTREGA.HeaderText = "FECHAENTREGA";
            this.FECHAENTREGA.Name = "FECHAENTREGA";
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
            // gpordenes
            // 
            this.gpordenes.Controls.Add(this.radioButton2);
            this.gpordenes.Controls.Add(this.radioButton1);
            this.gpordenes.Enabled = false;
            this.gpordenes.Location = new System.Drawing.Point(532, 15);
            this.gpordenes.Name = "gpordenes";
            this.gpordenes.Size = new System.Drawing.Size(182, 76);
            this.gpordenes.TabIndex = 22;
            this.gpordenes.TabStop = false;
            this.gpordenes.Text = "Ordenes de Compra";
            this.gpordenes.Enter += new System.EventHandler(this.gpordenes_Enter);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(7, 43);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(97, 17);
            this.radioButton2.TabIndex = 0;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Varias Ordenes";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(7, 20);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(77, 17);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Una Orden";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // tooltip
            // 
            this.tooltip.IsBalloon = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(393, 43);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(95, 13);
            this.label9.TabIndex = 3;
            this.label9.Text = "Fecha Recepción:";
            // 
            // DtFechaRecepcion
            // 
            this.DtFechaRecepcion.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtFechaRecepcion.Location = new System.Drawing.Point(487, 40);
            this.DtFechaRecepcion.Name = "DtFechaRecepcion";
            this.DtFechaRecepcion.Size = new System.Drawing.Size(100, 20);
            this.DtFechaRecepcion.TabIndex = 19;
            // 
            // FrmFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(819, 644);
            this.Controls.Add(this.gpordenes);
            this.Controls.Add(this.chlbx);
            this.Controls.Add(this.Dtguias);
            this.Controls.Add(this.txtguia);
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
            this.Controls.Add(this.lblguia);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtdireccion);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FrmFactura";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro de Factura";
            this.Load += new System.EventHandler(this.FrmFactura_Load);
            this.gp1.ResumeLayout(false);
            this.gp1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbfactura)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DtgConten)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numigv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dtguias)).EndInit();
            this.gpordenes.ResumeLayout(false);
            this.gpordenes.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtnrofactura;
        private System.Windows.Forms.TextBox txtruc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblguia;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btncancelar;
        private System.Windows.Forms.Button btnaceptar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtfoto;
        private System.Windows.Forms.Button btnCargarFoto;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtRazonSocial;
        private System.Windows.Forms.TextBox txtdireccion;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dtfechaemision;
        private System.Windows.Forms.GroupBox gp1;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txttotal;
        private System.Windows.Forms.TextBox txtigv;
        private System.Windows.Forms.TextBox txtsubtotal;
        private System.Windows.Forms.OpenFileDialog Openfd;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ComboBox cbotipo;
        private System.Windows.Forms.NumericUpDown numigv;
        private System.Windows.Forms.ComboBox cboigv;
        private System.Windows.Forms.Label lblporcentaje;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnmaspro;
        private System.Windows.Forms.ComboBox txtguia;
        private System.Windows.Forms.Button btnagregar;
        private System.Windows.Forms.DataGridView DtgConten;
        private System.Windows.Forms.PictureBox pbfactura;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.CheckedListBox chlbx;
        private System.Windows.Forms.DataGridView Dtguias;
        private System.Windows.Forms.TextBox txtmonto;
        private System.Windows.Forms.DateTimePicker Dtfechaentregado;
        private System.Windows.Forms.GroupBox gpordenes;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.ToolTip tooltip;
        private System.Windows.Forms.DataGridViewTextBoxColumn FIC1;
        private System.Windows.Forms.DataGridViewTextBoxColumn OC;
        private System.Windows.Forms.DataGridViewTextBoxColumn GUIA;
        private System.Windows.Forms.DataGridViewTextBoxColumn FECHAENTREGA;
        private System.Windows.Forms.DataGridViewCheckBoxColumn OK;
        private System.Windows.Forms.DateTimePicker DtFechaRecepcion;
        private System.Windows.Forms.Label label9;
    }
}