﻿namespace HPReserger
{
    partial class frmNroOpBancacia
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNroOpBancacia));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.chkNroop = new HpResergerUserControls.checkboxOre();
            this.btnpdf = new System.Windows.Forms.Button();
            this.btnclear = new System.Windows.Forms.Button();
            this.btnseleccion = new System.Windows.Forms.Button();
            this.lblmsg = new System.Windows.Forms.Label();
            this.btncancelar = new System.Windows.Forms.Button();
            this.btnaceptar = new System.Windows.Forms.Button();
            this.dtgconten = new HpResergerUserControls.Dtgconten();
            this.okx = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.idx = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xnameEmpresa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipox = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xdet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NroFacturax = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Proveedorx = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Razonx = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.monedax = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.importex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaPagox = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Bancox = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CtaBancox = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NroOPBancox = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.botonx = new System.Windows.Forms.DataGridViewButtonColumn();
            this.xfkempresa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xcuo = new System.Windows.Forms.DataGridViewButtonColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtcuo = new HpResergerUserControls.TextBoxPer();
            this.txtnrobanco = new HpResergerUserControls.TextBoxPer();
            this.cboEmpresa = new HpResergerUserControls.ComboBoxPer(this.components);
            this.cbocuenta = new HpResergerUserControls.ComboBoxPer(this.components);
            this.txtrazon = new HpResergerUserControls.TextBoxPer();
            this.txttipodoc = new HpResergerUserControls.TextBoxPer();
            this.label8 = new System.Windows.Forms.Label();
            this.txtruc = new HpResergerUserControls.TextBoxPer();
            this.label10 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbobanco = new HpResergerUserControls.ComboBoxPer(this.components);
            this.dtpfecha2 = new System.Windows.Forms.DateTimePicker();
            this.dtpfecha1 = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtnroid = new HpResergerUserControls.TextBoxPer();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgconten)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // chkNroop
            // 
            this.chkNroop.AutoSize = true;
            this.chkNroop.BackColor = System.Drawing.Color.Transparent;
            this.chkNroop.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkNroop.Checked = true;
            this.chkNroop.CheckState = System.Windows.Forms.CheckState.Indeterminate;
            this.chkNroop.ColorChecked = System.Drawing.Color.Empty;
            this.chkNroop.ColorUnChecked = System.Drawing.Color.Empty;
            this.chkNroop.Location = new System.Drawing.Point(607, 62);
            this.chkNroop.Name = "chkNroop";
            this.chkNroop.Size = new System.Drawing.Size(90, 17);
            this.chkNroop.TabIndex = 236;
            this.chkNroop.Text = "Con Nro OP.";
            this.chkNroop.ThreeState = true;
            this.chkNroop.UseVisualStyleBackColor = true;
            this.chkNroop.CheckStateChanged += new System.EventHandler(this.txtnrobanco_TextChanged);
            // 
            // btnpdf
            // 
            this.btnpdf.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnpdf.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnpdf.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnpdf.Image = ((System.Drawing.Image)(resources.GetObject("btnpdf.Image")));
            this.btnpdf.Location = new System.Drawing.Point(506, 430);
            this.btnpdf.Name = "btnpdf";
            this.btnpdf.Size = new System.Drawing.Size(82, 25);
            this.btnpdf.TabIndex = 235;
            this.btnpdf.Text = "Excel";
            this.btnpdf.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnpdf.UseVisualStyleBackColor = true;
            this.btnpdf.Click += new System.EventHandler(this.btnpdf_Click);
            // 
            // btnclear
            // 
            this.btnclear.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnclear.Image = ((System.Drawing.Image)(resources.GetObject("btnclear.Image")));
            this.btnclear.Location = new System.Drawing.Point(732, 49);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(98, 23);
            this.btnclear.TabIndex = 140;
            this.btnclear.Text = "Borrar Filtros";
            this.btnclear.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnclear.UseVisualStyleBackColor = true;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // btnseleccion
            // 
            this.btnseleccion.Image = ((System.Drawing.Image)(resources.GetObject("btnseleccion.Image")));
            this.btnseleccion.Location = new System.Drawing.Point(17, 144);
            this.btnseleccion.Name = "btnseleccion";
            this.btnseleccion.Size = new System.Drawing.Size(151, 23);
            this.btnseleccion.TabIndex = 139;
            this.btnseleccion.Text = "Seleccionar Todos";
            this.btnseleccion.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnseleccion.UseVisualStyleBackColor = true;
            this.btnseleccion.Click += new System.EventHandler(this.btnseleccion_Click);
            // 
            // lblmsg
            // 
            this.lblmsg.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblmsg.AutoSize = true;
            this.lblmsg.BackColor = System.Drawing.Color.Transparent;
            this.lblmsg.Location = new System.Drawing.Point(17, 436);
            this.lblmsg.Name = "lblmsg";
            this.lblmsg.Size = new System.Drawing.Size(113, 13);
            this.lblmsg.TabIndex = 138;
            this.lblmsg.Text = "Total de Registros : 0";
            // 
            // btncancelar
            // 
            this.btncancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btncancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btncancelar.Image = ((System.Drawing.Image)(resources.GetObject("btncancelar.Image")));
            this.btncancelar.Location = new System.Drawing.Point(1001, 431);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(82, 23);
            this.btncancelar.TabIndex = 137;
            this.btncancelar.Text = "Cancelar";
            this.btncancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btncancelar.UseVisualStyleBackColor = true;
            this.btncancelar.Click += new System.EventHandler(this.btncancelar_Click);
            // 
            // btnaceptar
            // 
            this.btnaceptar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnaceptar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnaceptar.Image = ((System.Drawing.Image)(resources.GetObject("btnaceptar.Image")));
            this.btnaceptar.Location = new System.Drawing.Point(914, 431);
            this.btnaceptar.Name = "btnaceptar";
            this.btnaceptar.Size = new System.Drawing.Size(82, 23);
            this.btnaceptar.TabIndex = 136;
            this.btnaceptar.Text = "Aceptar";
            this.btnaceptar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnaceptar.UseVisualStyleBackColor = true;
            this.btnaceptar.Click += new System.EventHandler(this.btnaceptar_Click);
            // 
            // dtgconten
            // 
            this.dtgconten.AllowUserToAddRows = false;
            this.dtgconten.AllowUserToDeleteRows = false;
            this.dtgconten.AllowUserToOrderColumns = true;
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
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DeepSkyBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgconten.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dtgconten.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgconten.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.okx,
            this.idx,
            this.xnameEmpresa,
            this.tipox,
            this.xdet,
            this.NroFacturax,
            this.Proveedorx,
            this.Razonx,
            this.monedax,
            this.importex,
            this.FechaPagox,
            this.Bancox,
            this.CtaBancox,
            this.NroOPBancox,
            this.botonx,
            this.xfkempresa,
            this.xcuo});
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(207)))), ((int)(((byte)(241)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgconten.DefaultCellStyle = dataGridViewCellStyle7;
            this.dtgconten.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dtgconten.EnableHeadersVisualStyles = false;
            this.dtgconten.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(179)))), ((int)(((byte)(215)))));
            this.dtgconten.Location = new System.Drawing.Point(17, 169);
            this.dtgconten.Name = "dtgconten";
            this.dtgconten.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dtgconten.RowHeadersVisible = false;
            this.dtgconten.RowTemplate.Height = 18;
            this.dtgconten.Size = new System.Drawing.Size(1066, 255);
            this.dtgconten.TabIndex = 112;
            this.dtgconten.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgconten_CellContentClick);
            this.dtgconten.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgconten_CellDoubleClick);
            this.dtgconten.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgconten_CellValueChanged);
            this.dtgconten.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgconten_RowEnter);
            // 
            // okx
            // 
            this.okx.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.okx.DataPropertyName = "ok";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.okx.DefaultCellStyle = dataGridViewCellStyle3;
            this.okx.FalseValue = "0";
            this.okx.HeaderText = "Ok";
            this.okx.Name = "okx";
            this.okx.TrueValue = "1";
            this.okx.Width = 27;
            // 
            // idx
            // 
            this.idx.DataPropertyName = "id";
            this.idx.HeaderText = "id";
            this.idx.Name = "idx";
            this.idx.ReadOnly = true;
            this.idx.Visible = false;
            // 
            // xnameEmpresa
            // 
            this.xnameEmpresa.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.xnameEmpresa.DataPropertyName = "nameempresa";
            this.xnameEmpresa.HeaderText = "Empresa";
            this.xnameEmpresa.MinimumWidth = 100;
            this.xnameEmpresa.Name = "xnameEmpresa";
            this.xnameEmpresa.ReadOnly = true;
            // 
            // tipox
            // 
            this.tipox.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.tipox.DataPropertyName = "tipo";
            this.tipox.HeaderText = "Doc";
            this.tipox.MinimumWidth = 40;
            this.tipox.Name = "tipox";
            this.tipox.ReadOnly = true;
            this.tipox.Width = 40;
            // 
            // xdet
            // 
            this.xdet.DataPropertyName = "det";
            this.xdet.HeaderText = "det";
            this.xdet.Name = "xdet";
            this.xdet.Visible = false;
            // 
            // NroFacturax
            // 
            this.NroFacturax.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.NroFacturax.DataPropertyName = "NroFactura";
            this.NroFacturax.HeaderText = "NroComp.";
            this.NroFacturax.MinimumWidth = 70;
            this.NroFacturax.Name = "NroFacturax";
            this.NroFacturax.ReadOnly = true;
            this.NroFacturax.Width = 70;
            // 
            // Proveedorx
            // 
            this.Proveedorx.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.Proveedorx.DataPropertyName = "Proveedor";
            this.Proveedorx.HeaderText = "NroDoc";
            this.Proveedorx.MinimumWidth = 60;
            this.Proveedorx.Name = "Proveedorx";
            this.Proveedorx.ReadOnly = true;
            this.Proveedorx.Width = 60;
            // 
            // Razonx
            // 
            this.Razonx.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Razonx.DataPropertyName = "razon";
            this.Razonx.HeaderText = "Razon/Cliente";
            this.Razonx.MinimumWidth = 100;
            this.Razonx.Name = "Razonx";
            this.Razonx.ReadOnly = true;
            // 
            // monedax
            // 
            this.monedax.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.monedax.DataPropertyName = "moneda";
            this.monedax.HeaderText = "Mon";
            this.monedax.MinimumWidth = 40;
            this.monedax.Name = "monedax";
            this.monedax.ReadOnly = true;
            this.monedax.Width = 55;
            // 
            // importex
            // 
            this.importex.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.importex.DataPropertyName = "importe";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle4.Format = "n2";
            this.importex.DefaultCellStyle = dataGridViewCellStyle4;
            this.importex.HeaderText = "Importe";
            this.importex.MinimumWidth = 60;
            this.importex.Name = "importex";
            this.importex.ReadOnly = true;
            this.importex.Width = 60;
            // 
            // FechaPagox
            // 
            this.FechaPagox.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.FechaPagox.DataPropertyName = "FechaPago";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle5.Format = "dd/MM/yyyy";
            this.FechaPagox.DefaultCellStyle = dataGridViewCellStyle5;
            this.FechaPagox.HeaderText = "Fecha Pago";
            this.FechaPagox.MinimumWidth = 60;
            this.FechaPagox.Name = "FechaPagox";
            this.FechaPagox.ReadOnly = true;
            this.FechaPagox.Width = 60;
            // 
            // Bancox
            // 
            this.Bancox.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Bancox.DataPropertyName = "Banco";
            this.Bancox.HeaderText = "Banco";
            this.Bancox.MinimumWidth = 70;
            this.Bancox.Name = "Bancox";
            this.Bancox.ReadOnly = true;
            this.Bancox.Width = 70;
            // 
            // CtaBancox
            // 
            this.CtaBancox.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.CtaBancox.DataPropertyName = "CtaBanco";
            this.CtaBancox.HeaderText = "CtaBanco";
            this.CtaBancox.MinimumWidth = 70;
            this.CtaBancox.Name = "CtaBancox";
            this.CtaBancox.ReadOnly = true;
            this.CtaBancox.Width = 80;
            // 
            // NroOPBancox
            // 
            this.NroOPBancox.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.NroOPBancox.DataPropertyName = "NroOPBanco";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.NroOPBancox.DefaultCellStyle = dataGridViewCellStyle6;
            this.NroOPBancox.HeaderText = "NroOPBanco";
            this.NroOPBancox.MinimumWidth = 50;
            this.NroOPBancox.Name = "NroOPBancox";
            this.NroOPBancox.ReadOnly = true;
            this.NroOPBancox.Width = 97;
            // 
            // botonx
            // 
            this.botonx.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.botonx.DataPropertyName = "boton";
            this.botonx.HeaderText = "Modificar";
            this.botonx.Name = "botonx";
            this.botonx.ReadOnly = true;
            this.botonx.Text = "";
            this.botonx.Width = 61;
            // 
            // xfkempresa
            // 
            this.xfkempresa.DataPropertyName = "fkempresa";
            this.xfkempresa.HeaderText = "fkempresa";
            this.xfkempresa.Name = "xfkempresa";
            this.xfkempresa.Visible = false;
            // 
            // xcuo
            // 
            this.xcuo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.xcuo.DataPropertyName = "cuo";
            this.xcuo.HeaderText = "Ver PDF";
            this.xcuo.MinimumWidth = 70;
            this.xcuo.Name = "xcuo";
            this.xcuo.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.xcuo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.xcuo.Width = 70;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.txtcuo);
            this.groupBox1.Controls.Add(this.chkNroop);
            this.groupBox1.Controls.Add(this.txtnrobanco);
            this.groupBox1.Controls.Add(this.cboEmpresa);
            this.groupBox1.Controls.Add(this.cbocuenta);
            this.groupBox1.Controls.Add(this.txtrazon);
            this.groupBox1.Controls.Add(this.txttipodoc);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtruc);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.cbobanco);
            this.groupBox1.Controls.Add(this.dtpfecha2);
            this.groupBox1.Controls.Add(this.dtpfecha1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(17, 35);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(709, 108);
            this.groupBox1.TabIndex = 111;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Buscar Por:";
            // 
            // txtcuo
            // 
            this.txtcuo.BackColor = System.Drawing.Color.White;
            this.txtcuo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtcuo.ColorFondoMouseEncima = System.Drawing.Color.Empty;
            this.txtcuo.ColorFondoMousePresionado = System.Drawing.Color.Empty;
            this.txtcuo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcuo.ForeColor = System.Drawing.Color.Black;
            this.txtcuo.Format = null;
            this.txtcuo.Location = new System.Drawing.Point(210, 37);
            this.txtcuo.MaxLength = 100;
            this.txtcuo.Name = "txtcuo";
            this.txtcuo.NextControlOnEnter = null;
            this.txtcuo.Size = new System.Drawing.Size(80, 21);
            this.txtcuo.TabIndex = 237;
            this.txtcuo.Text = "1900-00000";
            this.txtcuo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtcuo.TextoDefecto = "1900-00000";
            this.txtcuo.TextoDefectoColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(129)))), ((int)(((byte)(189)))));
            this.txtcuo.TiposDatos = HpResergerUserControls.TextBoxPer.ListaTipos.Todo;
            this.txtcuo.TextChanged += new System.EventHandler(this.txtcuo_TextChanged);
            // 
            // txtnrobanco
            // 
            this.txtnrobanco.BackColor = System.Drawing.Color.White;
            this.txtnrobanco.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtnrobanco.ColorFondoMouseEncima = System.Drawing.Color.Empty;
            this.txtnrobanco.ColorFondoMousePresionado = System.Drawing.Color.Empty;
            this.txtnrobanco.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnrobanco.ForeColor = System.Drawing.Color.Black;
            this.txtnrobanco.Format = null;
            this.txtnrobanco.Location = new System.Drawing.Point(394, 60);
            this.txtnrobanco.MaxLength = 100;
            this.txtnrobanco.Name = "txtnrobanco";
            this.txtnrobanco.NextControlOnEnter = null;
            this.txtnrobanco.Size = new System.Drawing.Size(210, 21);
            this.txtnrobanco.TabIndex = 6;
            this.txtnrobanco.Text = "Ingrese Nro Op Bancaria";
            this.txtnrobanco.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtnrobanco.TextoDefecto = "Ingrese Nro Op Bancaria";
            this.txtnrobanco.TextoDefectoColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(129)))), ((int)(((byte)(189)))));
            this.txtnrobanco.TiposDatos = HpResergerUserControls.TextBoxPer.ListaTipos.Todo;
            this.txtnrobanco.TextChanged += new System.EventHandler(this.txtnrobanco_TextChanged);
            // 
            // cboEmpresa
            // 
            this.cboEmpresa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(218)))), ((int)(((byte)(231)))));
            this.cboEmpresa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEmpresa.FormattingEnabled = true;
            this.cboEmpresa.IndexText = null;
            this.cboEmpresa.Location = new System.Drawing.Point(394, 14);
            this.cboEmpresa.Name = "cboEmpresa";
            this.cboEmpresa.ReadOnly = false;
            this.cboEmpresa.Size = new System.Drawing.Size(303, 21);
            this.cboEmpresa.TabIndex = 8;
            this.cboEmpresa.SelectedIndexChanged += new System.EventHandler(this.cbocuenta_SelectedIndexChanged);
            this.cboEmpresa.Click += new System.EventHandler(this.cboEmpresa_Click);
            // 
            // cbocuenta
            // 
            this.cbocuenta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(218)))), ((int)(((byte)(231)))));
            this.cbocuenta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbocuenta.FormattingEnabled = true;
            this.cbocuenta.IndexText = null;
            this.cbocuenta.Location = new System.Drawing.Point(394, 83);
            this.cbocuenta.Name = "cbocuenta";
            this.cbocuenta.ReadOnly = false;
            this.cbocuenta.Size = new System.Drawing.Size(303, 21);
            this.cbocuenta.TabIndex = 8;
            this.cbocuenta.SelectedIndexChanged += new System.EventHandler(this.cbocuenta_SelectedIndexChanged);
            // 
            // txtrazon
            // 
            this.txtrazon.BackColor = System.Drawing.Color.White;
            this.txtrazon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtrazon.ColorFondoMouseEncima = System.Drawing.Color.Empty;
            this.txtrazon.ColorFondoMousePresionado = System.Drawing.Color.Empty;
            this.txtrazon.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtrazon.ForeColor = System.Drawing.Color.Black;
            this.txtrazon.Format = null;
            this.txtrazon.Location = new System.Drawing.Point(394, 37);
            this.txtrazon.MaxLength = 100;
            this.txtrazon.Name = "txtrazon";
            this.txtrazon.NextControlOnEnter = null;
            this.txtrazon.Size = new System.Drawing.Size(303, 21);
            this.txtrazon.TabIndex = 3;
            this.txtrazon.Text = "Ingrese Razón Social/Cliente";
            this.txtrazon.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtrazon.TextoDefecto = "Ingrese Razón Social/Cliente";
            this.txtrazon.TextoDefectoColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(129)))), ((int)(((byte)(189)))));
            this.txtrazon.TiposDatos = HpResergerUserControls.TextBoxPer.ListaTipos.MayusculaCadaPalabra;
            this.txtrazon.TextChanged += new System.EventHandler(this.txtrazon_TextChanged);
            // 
            // txttipodoc
            // 
            this.txttipodoc.BackColor = System.Drawing.Color.White;
            this.txttipodoc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txttipodoc.ColorFondoMouseEncima = System.Drawing.Color.Empty;
            this.txttipodoc.ColorFondoMousePresionado = System.Drawing.Color.Empty;
            this.txttipodoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttipodoc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(129)))), ((int)(((byte)(189)))));
            this.txttipodoc.Format = null;
            this.txttipodoc.Location = new System.Drawing.Point(86, 14);
            this.txttipodoc.MaxLength = 100;
            this.txttipodoc.Name = "txttipodoc";
            this.txttipodoc.NextControlOnEnter = null;
            this.txttipodoc.Size = new System.Drawing.Size(204, 21);
            this.txttipodoc.TabIndex = 2;
            this.txttipodoc.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txttipodoc.TextoDefecto = "";
            this.txttipodoc.TextoDefectoColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(129)))), ((int)(((byte)(189)))));
            this.txttipodoc.TiposDatos = HpResergerUserControls.TextBoxPer.ListaTipos.Todo;
            this.txttipodoc.TextChanged += new System.EventHandler(this.txtruc_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Location = new System.Drawing.Point(34, 18);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 13);
            this.label8.TabIndex = 117;
            this.label8.Text = "Tipo Doc";
            // 
            // txtruc
            // 
            this.txtruc.BackColor = System.Drawing.Color.White;
            this.txtruc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtruc.ColorFondoMouseEncima = System.Drawing.Color.Empty;
            this.txtruc.ColorFondoMousePresionado = System.Drawing.Color.Empty;
            this.txtruc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtruc.ForeColor = System.Drawing.Color.Black;
            this.txtruc.Format = null;
            this.txtruc.Location = new System.Drawing.Point(86, 37);
            this.txtruc.MaxLength = 100;
            this.txtruc.Name = "txtruc";
            this.txtruc.NextControlOnEnter = null;
            this.txtruc.Size = new System.Drawing.Size(93, 21);
            this.txtruc.TabIndex = 2;
            this.txtruc.Text = "000000";
            this.txtruc.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtruc.TextoDefecto = "000000";
            this.txtruc.TextoDefectoColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(129)))), ((int)(((byte)(189)))));
            this.txtruc.TiposDatos = HpResergerUserControls.TextBoxPer.ListaTipos.Todo;
            this.txtruc.TextChanged += new System.EventHandler(this.txtruc_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Location = new System.Drawing.Point(179, 41);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(31, 13);
            this.label10.TabIndex = 117;
            this.label10.Text = "Cuo:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(19, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 117;
            this.label4.Text = "NroFactura:";
            // 
            // cbobanco
            // 
            this.cbobanco.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(218)))), ((int)(((byte)(231)))));
            this.cbobanco.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbobanco.FormattingEnabled = true;
            this.cbobanco.IndexText = null;
            this.cbobanco.Location = new System.Drawing.Point(86, 83);
            this.cbobanco.Name = "cbobanco";
            this.cbobanco.ReadOnly = false;
            this.cbobanco.Size = new System.Drawing.Size(204, 21);
            this.cbobanco.TabIndex = 7;
            this.cbobanco.SelectedIndexChanged += new System.EventHandler(this.cbobanco_SelectedIndexChanged);
            this.cbobanco.Click += new System.EventHandler(this.cbobanco_Click);
            // 
            // dtpfecha2
            // 
            this.dtpfecha2.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(129)))), ((int)(((byte)(189)))));
            this.dtpfecha2.CalendarTitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(129)))), ((int)(((byte)(189)))));
            this.dtpfecha2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpfecha2.Location = new System.Drawing.Point(192, 59);
            this.dtpfecha2.Name = "dtpfecha2";
            this.dtpfecha2.Size = new System.Drawing.Size(98, 22);
            this.dtpfecha2.TabIndex = 5;
            this.dtpfecha2.ValueChanged += new System.EventHandler(this.dtpfecha2_ValueChanged);
            // 
            // dtpfecha1
            // 
            this.dtpfecha1.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(129)))), ((int)(((byte)(189)))));
            this.dtpfecha1.CalendarTitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(129)))), ((int)(((byte)(189)))));
            this.dtpfecha1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpfecha1.Location = new System.Drawing.Point(86, 59);
            this.dtpfecha1.Name = "dtpfecha1";
            this.dtpfecha1.Size = new System.Drawing.Size(98, 22);
            this.dtpfecha1.TabIndex = 4;
            this.dtpfecha1.ValueChanged += new System.EventHandler(this.dtpfecha1_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(17, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 113;
            this.label2.Text = "Fecha Pago:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(44, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 112;
            this.label1.Text = "Banco:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Location = new System.Drawing.Point(342, 18);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 13);
            this.label9.TabIndex = 120;
            this.label9.Text = "Empresa:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Location = new System.Drawing.Point(297, 64);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 13);
            this.label7.TabIndex = 122;
            this.label7.Text = "Nro Op. Bancaria:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(326, 87);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 13);
            this.label6.TabIndex = 120;
            this.label6.Text = "Nro Cuenta:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(313, 41);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 13);
            this.label5.TabIndex = 118;
            this.label5.Text = "Razon/Cliente:";
            // 
            // txtnroid
            // 
            this.txtnroid.BackColor = System.Drawing.Color.White;
            this.txtnroid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtnroid.ColorFondoMouseEncima = System.Drawing.Color.Empty;
            this.txtnroid.ColorFondoMousePresionado = System.Drawing.Color.Empty;
            this.txtnroid.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnroid.ForeColor = System.Drawing.Color.Black;
            this.txtnroid.Format = null;
            this.txtnroid.Location = new System.Drawing.Point(103, 12);
            this.txtnroid.MaxLength = 20;
            this.txtnroid.Name = "txtnroid";
            this.txtnroid.NextControlOnEnter = null;
            this.txtnroid.Size = new System.Drawing.Size(204, 21);
            this.txtnroid.TabIndex = 1;
            this.txtnroid.Text = "Ingrese Valor";
            this.txtnroid.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtnroid.TextoDefecto = "Ingrese Valor";
            this.txtnroid.TextoDefectoColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(129)))), ((int)(((byte)(189)))));
            this.txtnroid.TiposDatos = HpResergerUserControls.TextBoxPer.ListaTipos.Todo;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(11, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 13);
            this.label3.TabIndex = 110;
            this.label3.Text = "Nro.Op.Bancaria";
            // 
            // frmNroOpBancacia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1095, 461);
            this.Controls.Add(this.lblmsg);
            this.Controls.Add(this.btnpdf);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.btnseleccion);
            this.Controls.Add(this.btncancelar);
            this.Controls.Add(this.btnaceptar);
            this.Controls.Add(this.dtgconten);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtnroid);
            this.Controls.Add(this.label3);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinimumSize = new System.Drawing.Size(1111, 500);
            this.Name = "frmNroOpBancacia";
            this.Nombre = "Número Operación Bancaria";
            this.Text = "Número Operación Bancaria";
            this.Load += new System.EventHandler(this.frmNroOpBancacia_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgconten)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private HpResergerUserControls.TextBoxPer txtnroid;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private HpResergerUserControls.TextBoxPer txtnrobanco;
        private System.Windows.Forms.Label label7;
        private HpResergerUserControls.ComboBoxPer cbocuenta;
        private System.Windows.Forms.Label label6;
        private HpResergerUserControls.TextBoxPer txtrazon;
        private System.Windows.Forms.Label label5;
        private HpResergerUserControls.TextBoxPer txtruc;
        private System.Windows.Forms.Label label4;
        private HpResergerUserControls.ComboBoxPer cbobanco;
        private System.Windows.Forms.DateTimePicker dtpfecha2;
        private System.Windows.Forms.DateTimePicker dtpfecha1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private HpResergerUserControls.Dtgconten dtgconten;
        private System.Windows.Forms.Button btncancelar;
        private System.Windows.Forms.Button btnaceptar;
        private System.Windows.Forms.Label lblmsg;
        private System.Windows.Forms.Button btnseleccion;
        private System.Windows.Forms.Button btnclear;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button btnpdf;
        private HpResergerUserControls.checkboxOre chkNroop;
        private HpResergerUserControls.ComboBoxPer cboEmpresa;
        private HpResergerUserControls.TextBoxPer txttipodoc;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridViewCheckBoxColumn okx;
        private System.Windows.Forms.DataGridViewTextBoxColumn idx;
        private System.Windows.Forms.DataGridViewTextBoxColumn xnameEmpresa;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipox;
        private System.Windows.Forms.DataGridViewTextBoxColumn xdet;
        private System.Windows.Forms.DataGridViewTextBoxColumn NroFacturax;
        private System.Windows.Forms.DataGridViewTextBoxColumn Proveedorx;
        private System.Windows.Forms.DataGridViewTextBoxColumn Razonx;
        private System.Windows.Forms.DataGridViewTextBoxColumn monedax;
        private System.Windows.Forms.DataGridViewTextBoxColumn importex;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaPagox;
        private System.Windows.Forms.DataGridViewTextBoxColumn Bancox;
        private System.Windows.Forms.DataGridViewTextBoxColumn CtaBancox;
        private System.Windows.Forms.DataGridViewTextBoxColumn NroOPBancox;
        private System.Windows.Forms.DataGridViewButtonColumn botonx;
        private System.Windows.Forms.DataGridViewTextBoxColumn xfkempresa;
        private System.Windows.Forms.DataGridViewButtonColumn xcuo;
        private HpResergerUserControls.TextBoxPer txtcuo;
        private System.Windows.Forms.Label label10;
    }
}