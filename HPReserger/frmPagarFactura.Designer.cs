using HpResergerUserControls;

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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPagarFactura));
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
            this.cbobanco = new System.Windows.Forms.ComboBox();
            this.btnmaspro = new System.Windows.Forms.Button();
            this.cbotipo = new System.Windows.Forms.ComboBox();
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
            this.btnReversar = new System.Windows.Forms.Button();
            this.btnseleccion = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnaceptar = new System.Windows.Forms.Button();
            this.btncancelar = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.Dtguias = new HpResergerUserControls.Dtgconten();
            this.OK = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.tipodoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.cboempresa = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.lblmensaje = new System.Windows.Forms.Label();
            this.txtnrocheque = new HpResergerUserControls.TextBoxPer();
            this.btnpdf = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.rdbporPagar = new System.Windows.Forms.RadioButton();
            this.rdbPagados = new System.Windows.Forms.RadioButton();
            this.dtpFechaPago = new System.Windows.Forms.DateTimePicker();
            this.label19 = new System.Windows.Forms.Label();
            this.txttipocambio = new HpResergerUserControls.TextBoxPer();
            this.lblcheque = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.txttotaldiferencial = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dtguias)).BeginInit();
            this.SuspendLayout();
            // 
            // cbobanco
            // 
            this.cbobanco.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(218)))), ((int)(((byte)(231)))));
            this.cbobanco.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbobanco.FormattingEnabled = true;
            this.cbobanco.Location = new System.Drawing.Point(73, 36);
            this.cbobanco.Name = "cbobanco";
            this.cbobanco.Size = new System.Drawing.Size(270, 21);
            this.cbobanco.TabIndex = 38;
            this.cbobanco.SelectedIndexChanged += new System.EventHandler(this.cbobanco_SelectedIndexChanged);
            this.cbobanco.Click += new System.EventHandler(this.cbobanco_Click);
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
            this.cbotipo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(218)))), ((int)(((byte)(231)))));
            this.cbotipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbotipo.FormattingEnabled = true;
            this.cbotipo.Items.AddRange(new object[] {
            "003 TRANSFERENCIA DE FONDOS",
            "007 CHEQUES CON LA CLÁUSULA DE \"NO NEGOCIABLE\", \"INTRANSFERIBLES\", \"NO A LA ORDEN" +
                "\" U OTRA EQUIVALENTE, A QUE SE REFIERE EL INCISO G) DEL ARTICULO 5° DE LA LEY",
            "009 EFECTIVO, EN LOS DEMÁS CASOS"});
            this.cbotipo.Location = new System.Drawing.Point(243, 13);
            this.cbotipo.Name = "cbotipo";
            this.cbotipo.Size = new System.Drawing.Size(474, 21);
            this.cbotipo.TabIndex = 36;
            this.cbotipo.SelectedIndexChanged += new System.EventHandler(this.cbotipo_SelectedIndexChanged);
            // 
            // txtTelefono
            // 
            this.txtTelefono.BackColor = System.Drawing.SystemColors.Control;
            this.txtTelefono.Enabled = false;
            this.txtTelefono.Location = new System.Drawing.Point(1048, 96);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(295, 22);
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
            this.txtRazonSocial.Size = new System.Drawing.Size(295, 22);
            this.txtRazonSocial.TabIndex = 25;
            this.txtRazonSocial.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtRazonSocial.Visible = false;
            // 
            // txtruc
            // 
            this.txtruc.Location = new System.Drawing.Point(1048, 18);
            this.txtruc.MaxLength = 11;
            this.txtruc.Name = "txtruc";
            this.txtruc.Size = new System.Drawing.Size(122, 22);
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
            this.label16.BackColor = System.Drawing.Color.Transparent;
            this.label16.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(207, 17);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(36, 13);
            this.label16.TabIndex = 27;
            this.label16.Text = "Pago:";
            // 
            // lblguia
            // 
            this.lblguia.AutoSize = true;
            this.lblguia.BackColor = System.Drawing.Color.Transparent;
            this.lblguia.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblguia.Location = new System.Drawing.Point(28, 40);
            this.lblguia.Name = "lblguia";
            this.lblguia.Size = new System.Drawing.Size(42, 13);
            this.lblguia.TabIndex = 28;
            this.lblguia.Text = "Banco:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(954, 99);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 13);
            this.label7.TabIndex = 30;
            this.label7.Text = "Telefono Oficina:";
            this.label7.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(954, 73);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 13);
            this.label6.TabIndex = 31;
            this.label6.Text = "Dirección Oficina:";
            this.label6.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(954, 47);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 13);
            this.label5.TabIndex = 32;
            this.label5.Text = "Razon Social:";
            this.label5.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(954, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
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
            this.txtdireccion.Size = new System.Drawing.Size(418, 22);
            this.txtdireccion.TabIndex = 26;
            this.txtdireccion.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtdireccion.Visible = false;
            // 
            // cbocuentabanco
            // 
            this.cbocuentabanco.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(218)))), ((int)(((byte)(231)))));
            this.cbocuentabanco.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbocuentabanco.FormattingEnabled = true;
            this.cbocuentabanco.Location = new System.Drawing.Point(425, 36);
            this.cbocuentabanco.Name = "cbocuentabanco";
            this.cbocuentabanco.Size = new System.Drawing.Size(292, 21);
            this.cbocuentabanco.TabIndex = 42;
            // 
            // lblguia1
            // 
            this.lblguia1.AutoSize = true;
            this.lblguia1.BackColor = System.Drawing.Color.Transparent;
            this.lblguia1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblguia1.Location = new System.Drawing.Point(344, 40);
            this.lblguia1.Name = "lblguia1";
            this.lblguia1.Size = new System.Drawing.Size(82, 13);
            this.lblguia1.TabIndex = 41;
            this.lblguia1.Text = "Cuenta Banco:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 43;
            this.label2.Text = "Nro Pago:";
            // 
            // txtnropago
            // 
            this.txtnropago.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtnropago.Enabled = false;
            this.txtnropago.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnropago.Location = new System.Drawing.Point(73, 13);
            this.txtnropago.Name = "txtnropago";
            this.txtnropago.Size = new System.Drawing.Size(126, 21);
            this.txtnropago.TabIndex = 44;
            this.txtnropago.Text = "0";
            this.txtnropago.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txttotal
            // 
            this.txttotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txttotal.Enabled = false;
            this.txttotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttotal.Location = new System.Drawing.Point(809, 474);
            this.txttotal.Name = "txttotal";
            this.txttotal.Size = new System.Drawing.Size(99, 21);
            this.txttotal.TabIndex = 45;
            this.txttotal.Text = "0.00";
            this.txttotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txttotal.TextChanged += new System.EventHandler(this.txttotal_TextChanged);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(809, 460);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
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
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(703, 460);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 13);
            this.label4.TabIndex = 46;
            this.label4.Text = "Total Detracción:";
            // 
            // txttotaldetrac
            // 
            this.txttotaldetrac.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txttotaldetrac.Enabled = false;
            this.txttotaldetrac.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttotaldetrac.Location = new System.Drawing.Point(703, 474);
            this.txttotaldetrac.Name = "txttotaldetrac";
            this.txttotaldetrac.Size = new System.Drawing.Size(100, 21);
            this.txttotaldetrac.TabIndex = 47;
            this.txttotaldetrac.Text = "0.00";
            this.txttotaldetrac.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
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
            this.groupBox1.Location = new System.Drawing.Point(12, 84);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1056, 38);
            this.groupBox1.TabIndex = 49;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Busqueda";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(875, 17);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(39, 13);
            this.label10.TabIndex = 56;
            this.label10.Text = "Hasta:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(760, 17);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(24, 13);
            this.label11.TabIndex = 55;
            this.label11.Text = "De:";
            // 
            // dtpfin
            // 
            this.dtpfin.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(218)))), ((int)(((byte)(231)))));
            this.dtpfin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpfin.Location = new System.Drawing.Point(919, 13);
            this.dtpfin.Name = "dtpfin";
            this.dtpfin.Size = new System.Drawing.Size(79, 22);
            this.dtpfin.TabIndex = 54;
            this.dtpfin.ValueChanged += new System.EventHandler(this.dtpfin_ValueChanged);
            // 
            // dtpini
            // 
            this.dtpini.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(218)))), ((int)(((byte)(231)))));
            this.dtpini.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpini.Location = new System.Drawing.Point(790, 13);
            this.dtpini.Name = "dtpini";
            this.dtpini.Size = new System.Drawing.Size(79, 22);
            this.dtpini.TabIndex = 53;
            this.dtpini.ValueChanged += new System.EventHandler(this.dtpini_ValueChanged);
            // 
            // chkrecepcion
            // 
            this.chkrecepcion.AutoSize = true;
            this.chkrecepcion.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkrecepcion.Location = new System.Drawing.Point(649, 15);
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
            this.label9.Location = new System.Drawing.Point(520, 17);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(39, 13);
            this.label9.TabIndex = 51;
            this.label9.Text = "Hasta:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(405, 17);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(24, 13);
            this.label8.TabIndex = 50;
            this.label8.Text = "De:";
            // 
            // dtfin
            // 
            this.dtfin.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(218)))), ((int)(((byte)(231)))));
            this.dtfin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtfin.Location = new System.Drawing.Point(564, 13);
            this.dtfin.Name = "dtfin";
            this.dtfin.Size = new System.Drawing.Size(79, 22);
            this.dtfin.TabIndex = 4;
            this.dtfin.ValueChanged += new System.EventHandler(this.dtfin_ValueChanged);
            // 
            // dtinicio
            // 
            this.dtinicio.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(218)))), ((int)(((byte)(231)))));
            this.dtinicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtinicio.Location = new System.Drawing.Point(435, 13);
            this.dtinicio.Name = "dtinicio";
            this.dtinicio.Size = new System.Drawing.Size(79, 22);
            this.dtinicio.TabIndex = 3;
            this.dtinicio.ValueChanged += new System.EventHandler(this.dtinicio_ValueChanged);
            // 
            // txtbuscar
            // 
            this.txtbuscar.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtbuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbuscar.Location = new System.Drawing.Point(97, 13);
            this.txtbuscar.Name = "txtbuscar";
            this.txtbuscar.Size = new System.Drawing.Size(190, 21);
            this.txtbuscar.TabIndex = 2;
            this.txtbuscar.TextChanged += new System.EventHandler(this.txtbuscar_TextChanged);
            // 
            // chkfecha
            // 
            this.chkfecha.AutoSize = true;
            this.chkfecha.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkfecha.Location = new System.Drawing.Point(294, 15);
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
            // btnReversar
            // 
            this.btnReversar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnReversar.Enabled = false;
            this.btnReversar.Image = ((System.Drawing.Image)(resources.GetObject("btnReversar.Image")));
            this.btnReversar.Location = new System.Drawing.Point(861, 17);
            this.btnReversar.Name = "btnReversar";
            this.btnReversar.Size = new System.Drawing.Size(75, 23);
            this.btnReversar.TabIndex = 52;
            this.btnReversar.Text = "Reversar";
            this.btnReversar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnReversar.UseVisualStyleBackColor = true;
            this.btnReversar.Visible = false;
            this.btnReversar.Click += new System.EventHandler(this.btnReversar_Click);
            // 
            // btnseleccion
            // 
            this.btnseleccion.Image = ((System.Drawing.Image)(resources.GetObject("btnseleccion.Image")));
            this.btnseleccion.Location = new System.Drawing.Point(12, 123);
            this.btnseleccion.Name = "btnseleccion";
            this.btnseleccion.Size = new System.Drawing.Size(151, 23);
            this.btnseleccion.TabIndex = 51;
            this.btnseleccion.Text = "Seleccionar Todos";
            this.btnseleccion.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnseleccion.UseVisualStyleBackColor = true;
            this.btnseleccion.Click += new System.EventHandler(this.btnseleccion_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.Image = ((System.Drawing.Image)(resources.GetObject("btnActualizar.Image")));
            this.btnActualizar.Location = new System.Drawing.Point(723, 35);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(86, 23);
            this.btnActualizar.TabIndex = 48;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnaceptar
            // 
            this.btnaceptar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnaceptar.Image = ((System.Drawing.Image)(resources.GetObject("btnaceptar.Image")));
            this.btnaceptar.Location = new System.Drawing.Point(917, 469);
            this.btnaceptar.Name = "btnaceptar";
            this.btnaceptar.Size = new System.Drawing.Size(75, 23);
            this.btnaceptar.TabIndex = 33;
            this.btnaceptar.Text = "Pagar";
            this.btnaceptar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnaceptar.UseVisualStyleBackColor = true;
            this.btnaceptar.Click += new System.EventHandler(this.btnaceptar_Click);
            // 
            // btncancelar
            // 
            this.btncancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btncancelar.Image = ((System.Drawing.Image)(resources.GetObject("btncancelar.Image")));
            this.btncancelar.Location = new System.Drawing.Point(998, 469);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(75, 23);
            this.btncancelar.TabIndex = 34;
            this.btncancelar.Text = "Cancelar";
            this.btncancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btncancelar.UseVisualStyleBackColor = true;
            this.btncancelar.Click += new System.EventHandler(this.btncancelar_Click);
            // 
            // toolTip1
            // 
            this.toolTip1.AutoPopDelay = 5000;
            this.toolTip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(215)))), ((int)(((byte)(155)))));
            this.toolTip1.ForeColor = System.Drawing.Color.White;
            this.toolTip1.InitialDelay = 5000;
            this.toolTip1.ReshowDelay = 100;
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
            this.Dtguias.Location = new System.Drawing.Point(12, 149);
            this.Dtguias.MultiSelect = false;
            this.Dtguias.Name = "Dtguias";
            this.Dtguias.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.Dtguias.RowHeadersVisible = false;
            this.Dtguias.RowTemplate.Height = 20;
            this.Dtguias.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Dtguias.Size = new System.Drawing.Size(1059, 310);
            this.Dtguias.TabIndex = 40;
            this.Dtguias.TabStop = false;
            this.Dtguias.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dtguias_CellContentClick);
            this.Dtguias.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dtguias_CellContentDoubleClick);
            this.Dtguias.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dtguias_CellDoubleClick);
            this.Dtguias.CellValidated += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dtguias_CellValidated);
            this.Dtguias.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.Dtguias_CellValidating);
            this.Dtguias.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dtguias_CellValueChanged);
            this.Dtguias.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.Dtguias_EditingControlShowing);
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
            this.OK.MinimumWidth = 30;
            this.OK.Name = "OK";
            this.OK.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.OK.TrueValue = "True";
            this.OK.Width = 30;
            // 
            // tipodoc
            // 
            this.tipodoc.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.tipodoc.DataPropertyName = "tipo";
            this.tipodoc.HeaderText = "T";
            this.tipodoc.Name = "tipodoc";
            this.tipodoc.ReadOnly = true;
            this.tipodoc.Width = 36;
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
            this.xtc.Width = 50;
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
            // cboempresa
            // 
            this.cboempresa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(218)))), ((int)(((byte)(231)))));
            this.cboempresa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboempresa.FormattingEnabled = true;
            this.cboempresa.Location = new System.Drawing.Point(73, 60);
            this.cboempresa.Name = "cboempresa";
            this.cboempresa.Size = new System.Drawing.Size(270, 21);
            this.cboempresa.TabIndex = 79;
            this.cboempresa.SelectedIndexChanged += new System.EventHandler(this.cboempresa_SelectedIndexChanged);
            this.cboempresa.Click += new System.EventHandler(this.cboempresa_Click_1);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(17, 64);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(53, 13);
            this.label12.TabIndex = 28;
            this.label12.Text = "Empresa:";
            // 
            // lblmensaje
            // 
            this.lblmensaje.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblmensaje.AutoSize = true;
            this.lblmensaje.BackColor = System.Drawing.Color.Transparent;
            this.lblmensaje.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmensaje.Location = new System.Drawing.Point(12, 474);
            this.lblmensaje.Name = "lblmensaje";
            this.lblmensaje.Size = new System.Drawing.Size(129, 13);
            this.lblmensaje.TabIndex = 81;
            this.lblmensaje.Text = "Número de Registros=0";
            // 
            // txtnrocheque
            // 
            this.txtnrocheque.BackColor = System.Drawing.Color.White;
            this.txtnrocheque.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtnrocheque.ColorFondoMouseEncima = System.Drawing.Color.Empty;
            this.txtnrocheque.ColorFondoMousePresionado = System.Drawing.Color.Empty;
            this.txtnrocheque.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnrocheque.ForeColor = System.Drawing.Color.Black;
            this.txtnrocheque.Format = null;
            this.txtnrocheque.Location = new System.Drawing.Point(723, 60);
            this.txtnrocheque.MaxLength = 20;
            this.txtnrocheque.Name = "txtnrocheque";
            this.txtnrocheque.NextControlOnEnter = null;
            this.txtnrocheque.Size = new System.Drawing.Size(158, 21);
            this.txtnrocheque.TabIndex = 82;
            this.txtnrocheque.Text = "Ingrese Nro Cheque";
            this.txtnrocheque.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtnrocheque.TextoDefecto = "Ingrese Nro Cheque";
            this.txtnrocheque.TextoDefectoColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(129)))), ((int)(((byte)(189)))));
            this.txtnrocheque.TiposDatos = HpResergerUserControls.TextBoxPer.ListaTipos.Todo;
            // 
            // btnpdf
            // 
            this.btnpdf.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnpdf.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnpdf.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnpdf.Image = ((System.Drawing.Image)(resources.GetObject("btnpdf.Image")));
            this.btnpdf.Location = new System.Drawing.Point(449, 468);
            this.btnpdf.Name = "btnpdf";
            this.btnpdf.Size = new System.Drawing.Size(82, 25);
            this.btnpdf.TabIndex = 236;
            this.btnpdf.Text = "Excel";
            this.btnpdf.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnpdf.UseVisualStyleBackColor = true;
            this.btnpdf.Click += new System.EventHandler(this.btnpdf_Click);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // rdbporPagar
            // 
            this.rdbporPagar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.rdbporPagar.AutoSize = true;
            this.rdbporPagar.BackColor = System.Drawing.Color.Transparent;
            this.rdbporPagar.Checked = true;
            this.rdbporPagar.Location = new System.Drawing.Point(468, 126);
            this.rdbporPagar.Name = "rdbporPagar";
            this.rdbporPagar.Size = new System.Drawing.Size(74, 17);
            this.rdbporPagar.TabIndex = 237;
            this.rdbporPagar.TabStop = true;
            this.rdbporPagar.Text = "Por Pagar";
            this.rdbporPagar.UseVisualStyleBackColor = false;
            this.rdbporPagar.CheckedChanged += new System.EventHandler(this.rdbporPagar_CheckedChanged);
            // 
            // rdbPagados
            // 
            this.rdbPagados.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.rdbPagados.AutoSize = true;
            this.rdbPagados.BackColor = System.Drawing.Color.Transparent;
            this.rdbPagados.Location = new System.Drawing.Point(548, 126);
            this.rdbPagados.Name = "rdbPagados";
            this.rdbPagados.Size = new System.Drawing.Size(69, 17);
            this.rdbPagados.TabIndex = 237;
            this.rdbPagados.Text = "Pagados";
            this.rdbPagados.UseVisualStyleBackColor = false;
            this.rdbPagados.CheckedChanged += new System.EventHandler(this.rdbporPagar_CheckedChanged);
            // 
            // dtpFechaPago
            // 
            this.dtpFechaPago.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaPago.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFechaPago.Location = new System.Drawing.Point(425, 59);
            this.dtpFechaPago.MaxDate = new System.DateTime(3000, 12, 31, 0, 0, 0, 0);
            this.dtpFechaPago.MinDate = new System.DateTime(1950, 1, 1, 0, 0, 0, 0);
            this.dtpFechaPago.Name = "dtpFechaPago";
            this.dtpFechaPago.Size = new System.Drawing.Size(97, 22);
            this.dtpFechaPago.TabIndex = 322;
            this.dtpFechaPago.Value = new System.DateTime(2017, 4, 27, 9, 44, 35, 0);
            this.dtpFechaPago.ValueChanged += new System.EventHandler(this.dtpFechaPago_ValueChanged);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.BackColor = System.Drawing.Color.Transparent;
            this.label19.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(355, 64);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(69, 13);
            this.label19.TabIndex = 323;
            this.label19.Text = "Fecha Pago:";
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
            this.txttipocambio.Location = new System.Drawing.Point(583, 60);
            this.txttipocambio.MaxLength = 10;
            this.txttipocambio.Name = "txttipocambio";
            this.txttipocambio.NextControlOnEnter = null;
            this.txttipocambio.Size = new System.Drawing.Size(64, 21);
            this.txttipocambio.TabIndex = 324;
            this.txttipocambio.Text = "3.300";
            this.txttipocambio.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txttipocambio.TextoDefecto = "3.300";
            this.txttipocambio.TextoDefectoColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(129)))), ((int)(((byte)(189)))));
            this.txttipocambio.TiposDatos = HpResergerUserControls.TextBoxPer.ListaTipos.SoloDinero;
            this.txttipocambio.TextChanged += new System.EventHandler(this.txttipocambio_TextChanged);
            // 
            // lblcheque
            // 
            this.lblcheque.AutoSize = true;
            this.lblcheque.BackColor = System.Drawing.Color.Transparent;
            this.lblcheque.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcheque.Location = new System.Drawing.Point(649, 64);
            this.lblcheque.Name = "lblcheque";
            this.lblcheque.Size = new System.Drawing.Size(75, 13);
            this.lblcheque.TabIndex = 325;
            this.lblcheque.Text = "Nro. Cheque:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(528, 64);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(57, 13);
            this.label14.TabIndex = 325;
            this.label14.Text = "T.C.Venta:";
            // 
            // txttotaldiferencial
            // 
            this.txttotaldiferencial.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txttotaldiferencial.Enabled = false;
            this.txttotaldiferencial.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttotaldiferencial.Location = new System.Drawing.Point(599, 474);
            this.txttotaldiferencial.Name = "txttotaldiferencial";
            this.txttotaldiferencial.Size = new System.Drawing.Size(100, 21);
            this.txttotaldiferencial.TabIndex = 326;
            this.txttotaldiferencial.Text = "0.00";
            this.txttotaldiferencial.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label13
            // 
            this.label13.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(599, 460);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(94, 13);
            this.label13.TabIndex = 327;
            this.label13.Text = "Total Dif. Cambio";
            // 
            // frmPagarFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1085, 499);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txttotaldiferencial);
            this.Controls.Add(this.txttipocambio);
            this.Controls.Add(this.dtpFechaPago);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.rdbPagados);
            this.Controls.Add(this.rdbporPagar);
            this.Controls.Add(this.btnpdf);
            this.Controls.Add(this.txtnrocheque);
            this.Controls.Add(this.lblmensaje);
            this.Controls.Add(this.cboempresa);
            this.Controls.Add(this.btnReversar);
            this.Controls.Add(this.btnseleccion);
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
            this.Controls.Add(this.label12);
            this.Controls.Add(this.lblguia);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtdireccion);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.lblcheque);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinimumSize = new System.Drawing.Size(1101, 538);
            this.Name = "frmPagarFactura";
            this.Nombre = "Pagar Comprobantes";
            this.Text = "Pagar Comprobantes";
            this.Load += new System.EventHandler(this.frmPagarFactura_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dtguias)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Dtgconten  Dtguias;
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
        private System.Windows.Forms.Button btnseleccion;
        private System.Windows.Forms.Button btnReversar;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ComboBox cboempresa;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lblmensaje;
        private TextBoxPer txtnrocheque;
        private System.Windows.Forms.Button btnpdf;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.RadioButton rdbporPagar;
        private System.Windows.Forms.RadioButton rdbPagados;
        private System.Windows.Forms.DateTimePicker dtpFechaPago;
        private System.Windows.Forms.Label label19;
        private TextBoxPer txttipocambio;
        private System.Windows.Forms.Label lblcheque;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txttotaldiferencial;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DataGridViewCheckBoxColumn OK;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipodoc;
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