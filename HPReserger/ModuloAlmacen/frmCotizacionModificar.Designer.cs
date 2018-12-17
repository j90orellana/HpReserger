using HpResergerUserControls;

namespace HPReserger
{
    partial class frmCotizacionModificar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCotizacionModificar));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtProveedor = new System.Windows.Forms.TextBox();
            this.cbomoneda = new System.Windows.Forms.ComboBox();
            this.txtRUC = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtAdjunto = new System.Windows.Forms.TextBox();
            this.btnBuscarPDF = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.txtImporte = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtPedido = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCotizacion = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pbFoto = new System.Windows.Forms.PictureBox();
            this.btncancelar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dtgpedidoX = new HpResergerUserControls.Dtgconten();
            this.tipox = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nrocotx = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ArticuloX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DetalleX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioUnitx = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Totalx = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtgpedidoY = new HpResergerUserControls.Dtgconten();
            this.tipoy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nrocoty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cody = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.articuloy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.marcay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modeloy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Canty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.preciounity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totaly = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btndescargar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbFoto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgpedidoX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgpedidoY)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAceptar
            // 
            this.btnAceptar.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptar.Image = ((System.Drawing.Image)(resources.GetObject("btnAceptar.Image")));
            this.btnAceptar.Location = new System.Drawing.Point(533, 373);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(85, 23);
            this.btnAceptar.TabIndex = 22;
            this.btnAceptar.Text = "Guardar";
            this.btnAceptar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtProveedor);
            this.groupBox1.Controls.Add(this.cbomoneda);
            this.groupBox1.Controls.Add(this.txtRUC);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtAdjunto);
            this.groupBox1.Controls.Add(this.btnBuscarPDF);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.dtpFecha);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txtImporte);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Location = new System.Drawing.Point(9, 33);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(695, 82);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(158, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 113;
            this.label2.Text = "Moneda:";
            // 
            // txtProveedor
            // 
            this.txtProveedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(218)))), ((int)(((byte)(231)))));
            this.txtProveedor.Location = new System.Drawing.Point(261, 12);
            this.txtProveedor.Name = "txtProveedor";
            this.txtProveedor.ReadOnly = true;
            this.txtProveedor.Size = new System.Drawing.Size(428, 20);
            this.txtProveedor.TabIndex = 28;
            this.txtProveedor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cbomoneda
            // 
            this.cbomoneda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(218)))), ((int)(((byte)(231)))));
            this.cbomoneda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbomoneda.FormattingEnabled = true;
            this.cbomoneda.Location = new System.Drawing.Point(213, 58);
            this.cbomoneda.Name = "cbomoneda";
            this.cbomoneda.Size = new System.Drawing.Size(139, 21);
            this.cbomoneda.TabIndex = 112;
            this.cbomoneda.Click += new System.EventHandler(this.cbomoneda_Click);
            // 
            // txtRUC
            // 
            this.txtRUC.Enabled = false;
            this.txtRUC.Location = new System.Drawing.Point(74, 12);
            this.txtRUC.MaxLength = 11;
            this.txtRUC.Name = "txtRUC";
            this.txtRUC.Size = new System.Drawing.Size(119, 20);
            this.txtRUC.TabIndex = 27;
            this.txtRUC.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtRUC.TextChanged += new System.EventHandler(this.txtRUC_TextChanged);
            this.txtRUC.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRUC_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(10, 16);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 13);
            this.label8.TabIndex = 26;
            this.label8.Text = "R.U.C.";
            // 
            // txtAdjunto
            // 
            this.txtAdjunto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(218)))), ((int)(((byte)(231)))));
            this.txtAdjunto.Location = new System.Drawing.Point(112, 35);
            this.txtAdjunto.Name = "txtAdjunto";
            this.txtAdjunto.ReadOnly = true;
            this.txtAdjunto.Size = new System.Drawing.Size(546, 20);
            this.txtAdjunto.TabIndex = 23;
            // 
            // btnBuscarPDF
            // 
            this.btnBuscarPDF.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBuscarPDF.BackgroundImage")));
            this.btnBuscarPDF.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBuscarPDF.FlatAppearance.BorderSize = 0;
            this.btnBuscarPDF.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarPDF.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarPDF.Location = new System.Drawing.Point(664, 35);
            this.btnBuscarPDF.Name = "btnBuscarPDF";
            this.btnBuscarPDF.Size = new System.Drawing.Size(20, 20);
            this.btnBuscarPDF.TabIndex = 24;
            this.btnBuscarPDF.UseVisualStyleBackColor = true;
            this.btnBuscarPDF.Click += new System.EventHandler(this.btnBuscarPDF_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(10, 39);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 13);
            this.label7.TabIndex = 22;
            this.label7.Text = "Adjuntar Archivo:";
            // 
            // dtpFecha
            // 
            this.dtpFecha.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(218)))), ((int)(((byte)(231)))));
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha.Location = new System.Drawing.Point(587, 58);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(102, 20);
            this.dtpFecha.TabIndex = 21;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(489, 62);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(99, 13);
            this.label9.TabIndex = 20;
            this.label9.Text = "Fecha de Entrega:";
            // 
            // txtImporte
            // 
            this.txtImporte.Enabled = false;
            this.txtImporte.Location = new System.Drawing.Point(406, 58);
            this.txtImporte.Name = "txtImporte";
            this.txtImporte.Size = new System.Drawing.Size(77, 20);
            this.txtImporte.TabIndex = 19;
            this.txtImporte.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtImporte.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtImporte_KeyPress);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(358, 62);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(50, 13);
            this.label10.TabIndex = 18;
            this.label10.Text = "Importe:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(199, 16);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(62, 13);
            this.label11.TabIndex = 16;
            this.label11.Text = "Proveedor:";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.txtPedido);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txtCotizacion);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(9, -5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(695, 37);
            this.groupBox2.TabIndex = 27;
            this.groupBox2.TabStop = false;
            // 
            // txtPedido
            // 
            this.txtPedido.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(218)))), ((int)(((byte)(231)))));
            this.txtPedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPedido.Location = new System.Drawing.Point(262, 16);
            this.txtPedido.Name = "txtPedido";
            this.txtPedido.ReadOnly = true;
            this.txtPedido.Size = new System.Drawing.Size(100, 20);
            this.txtPedido.TabIndex = 33;
            this.txtPedido.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(199, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 13);
            this.label6.TabIndex = 26;
            this.label6.Text = "Nº Pedido:";
            // 
            // txtCotizacion
            // 
            this.txtCotizacion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(218)))), ((int)(((byte)(231)))));
            this.txtCotizacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCotizacion.Location = new System.Drawing.Point(86, 16);
            this.txtCotizacion.Name = "txtCotizacion";
            this.txtCotizacion.ReadOnly = true;
            this.txtCotizacion.Size = new System.Drawing.Size(100, 20);
            this.txtCotizacion.TabIndex = 32;
            this.txtCotizacion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(10, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 13);
            this.label4.TabIndex = 21;
            this.label4.Text = "Nº Cotización:";
            // 
            // pbFoto
            // 
            this.pbFoto.BackColor = System.Drawing.Color.Transparent;
            this.pbFoto.Location = new System.Drawing.Point(713, 12);
            this.pbFoto.Name = "pbFoto";
            this.pbFoto.Size = new System.Drawing.Size(430, 384);
            this.pbFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbFoto.TabIndex = 28;
            this.pbFoto.TabStop = false;
            this.pbFoto.DoubleClick += new System.EventHandler(this.pbFoto_DoubleClick);
            this.pbFoto.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pbFoto_MouseMove);
            // 
            // btncancelar
            // 
            this.btncancelar.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncancelar.Image = ((System.Drawing.Image)(resources.GetObject("btncancelar.Image")));
            this.btncancelar.Location = new System.Drawing.Point(622, 373);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(85, 23);
            this.btncancelar.TabIndex = 29;
            this.btncancelar.Text = "Cancelar";
            this.btncancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btncancelar.UseVisualStyleBackColor = true;
            this.btncancelar.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 117);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 13);
            this.label1.TabIndex = 31;
            this.label1.Text = "Detalle de la Cotizacion:";
            // 
            // dtgpedidoX
            // 
            this.dtgpedidoX.AllowUserToAddRows = false;
            this.dtgpedidoX.AllowUserToDeleteRows = false;
            this.dtgpedidoX.AllowUserToResizeColumns = false;
            this.dtgpedidoX.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(230)))), ((int)(((byte)(241)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(191)))), ((int)(((byte)(231)))));
            this.dtgpedidoX.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgpedidoX.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgpedidoX.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgpedidoX.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(218)))), ((int)(((byte)(231)))));
            this.dtgpedidoX.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dtgpedidoX.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.dtgpedidoX.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(129)))), ((int)(((byte)(189)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DeepSkyBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgpedidoX.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dtgpedidoX.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dtgpedidoX.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tipox,
            this.nrocotx,
            this.codX,
            this.ArticuloX,
            this.DetalleX,
            this.PrecioUnitx,
            this.Totalx});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(207)))), ((int)(((byte)(241)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgpedidoX.DefaultCellStyle = dataGridViewCellStyle4;
            this.dtgpedidoX.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dtgpedidoX.EnableHeadersVisualStyles = false;
            this.dtgpedidoX.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(179)))), ((int)(((byte)(215)))));
            this.dtgpedidoX.Location = new System.Drawing.Point(9, 133);
            this.dtgpedidoX.Name = "dtgpedidoX";
            this.dtgpedidoX.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dtgpedidoX.RowHeadersVisible = false;
            this.dtgpedidoX.Size = new System.Drawing.Size(695, 234);
            this.dtgpedidoX.TabIndex = 30;
            this.dtgpedidoX.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgpedidoY_CellEndEdit_1);
            this.dtgpedidoX.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dtgpedidoX_DataError);
            this.dtgpedidoX.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dtgpedidoX_EditingControlShowing);
            this.dtgpedidoX.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dtgpedidoY_KeyPress);
            // 
            // tipox
            // 
            this.tipox.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.tipox.DataPropertyName = "tipo";
            this.tipox.HeaderText = "Tipo";
            this.tipox.Name = "tipox";
            this.tipox.ReadOnly = true;
            this.tipox.Width = 55;
            // 
            // nrocotx
            // 
            this.nrocotx.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.nrocotx.DataPropertyName = "nºcot";
            this.nrocotx.HeaderText = "NºCot";
            this.nrocotx.Name = "nrocotx";
            this.nrocotx.ReadOnly = true;
            this.nrocotx.Visible = false;
            // 
            // codX
            // 
            this.codX.DataPropertyName = "cod";
            this.codX.HeaderText = "Cod";
            this.codX.Name = "codX";
            this.codX.ReadOnly = true;
            this.codX.Visible = false;
            // 
            // ArticuloX
            // 
            this.ArticuloX.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ArticuloX.DataPropertyName = "articulo";
            this.ArticuloX.HeaderText = "Articulo";
            this.ArticuloX.Name = "ArticuloX";
            this.ArticuloX.ReadOnly = true;
            this.ArticuloX.Width = 73;
            // 
            // DetalleX
            // 
            this.DetalleX.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DetalleX.DataPropertyName = "detalle";
            this.DetalleX.HeaderText = "Detalle";
            this.DetalleX.Name = "DetalleX";
            this.DetalleX.ReadOnly = true;
            // 
            // PrecioUnitx
            // 
            this.PrecioUnitx.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.PrecioUnitx.DataPropertyName = "preciounit";
            dataGridViewCellStyle3.Format = "n2";
            dataGridViewCellStyle3.NullValue = "0.00";
            this.PrecioUnitx.DefaultCellStyle = dataGridViewCellStyle3;
            this.PrecioUnitx.HeaderText = "Precio Unit";
            this.PrecioUnitx.Name = "PrecioUnitx";
            this.PrecioUnitx.Width = 89;
            // 
            // Totalx
            // 
            this.Totalx.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Totalx.DataPropertyName = "total";
            this.Totalx.HeaderText = "Total";
            this.Totalx.Name = "Totalx";
            this.Totalx.ReadOnly = true;
            this.Totalx.Width = 57;
            // 
            // dtgpedidoY
            // 
            this.dtgpedidoY.AllowUserToAddRows = false;
            this.dtgpedidoY.AllowUserToDeleteRows = false;
            this.dtgpedidoY.AllowUserToResizeColumns = false;
            this.dtgpedidoY.AllowUserToResizeRows = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(230)))), ((int)(((byte)(241)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(191)))), ((int)(((byte)(231)))));
            this.dtgpedidoY.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dtgpedidoY.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgpedidoY.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgpedidoY.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(218)))), ((int)(((byte)(231)))));
            this.dtgpedidoY.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dtgpedidoY.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.dtgpedidoY.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(129)))), ((int)(((byte)(189)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.DeepSkyBlue;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgpedidoY.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dtgpedidoY.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgpedidoY.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tipoy,
            this.nrocoty,
            this.cody,
            this.articuloy,
            this.marcay,
            this.modeloy,
            this.Canty,
            this.preciounity,
            this.totaly});
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(207)))), ((int)(((byte)(241)))));
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgpedidoY.DefaultCellStyle = dataGridViewCellStyle10;
            this.dtgpedidoY.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dtgpedidoY.EnableHeadersVisualStyles = false;
            this.dtgpedidoY.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(179)))), ((int)(((byte)(215)))));
            this.dtgpedidoY.Location = new System.Drawing.Point(9, 140);
            this.dtgpedidoY.Name = "dtgpedidoY";
            this.dtgpedidoY.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dtgpedidoY.RowHeadersVisible = false;
            this.dtgpedidoY.RowTemplate.Height = 16;
            this.dtgpedidoY.Size = new System.Drawing.Size(695, 201);
            this.dtgpedidoY.TabIndex = 32;
            this.dtgpedidoY.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgpedidoY_CellContentClick);
            this.dtgpedidoY.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgpedidoY_CellEndEdit_1);
            this.dtgpedidoY.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dtgpedidoY_DataError);
            this.dtgpedidoY.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dtgpedidoY_EditingControlShowing);
            this.dtgpedidoY.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dtgpedidoY_KeyPress);
            // 
            // tipoy
            // 
            this.tipoy.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.tipoy.DataPropertyName = "tipo";
            this.tipoy.HeaderText = "Tipo";
            this.tipoy.Name = "tipoy";
            this.tipoy.ReadOnly = true;
            this.tipoy.Width = 55;
            // 
            // nrocoty
            // 
            this.nrocoty.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.nrocoty.DataPropertyName = "nºcot";
            this.nrocoty.HeaderText = "NºCot";
            this.nrocoty.Name = "nrocoty";
            this.nrocoty.ReadOnly = true;
            this.nrocoty.Visible = false;
            // 
            // cody
            // 
            this.cody.DataPropertyName = "cod";
            this.cody.HeaderText = "Cod";
            this.cody.Name = "cody";
            this.cody.ReadOnly = true;
            this.cody.Visible = false;
            // 
            // articuloy
            // 
            this.articuloy.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.articuloy.DataPropertyName = "articulo";
            this.articuloy.HeaderText = "Articulo";
            this.articuloy.Name = "articuloy";
            this.articuloy.ReadOnly = true;
            // 
            // marcay
            // 
            this.marcay.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.marcay.DataPropertyName = "marca";
            this.marcay.HeaderText = "Marca";
            this.marcay.Name = "marcay";
            this.marcay.ReadOnly = true;
            this.marcay.Width = 64;
            // 
            // modeloy
            // 
            this.modeloy.DataPropertyName = "modelo";
            this.modeloy.HeaderText = "Modelo";
            this.modeloy.Name = "modeloy";
            this.modeloy.ReadOnly = true;
            // 
            // Canty
            // 
            this.Canty.DataPropertyName = "cant";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.Canty.DefaultCellStyle = dataGridViewCellStyle7;
            this.Canty.HeaderText = "Cant";
            this.Canty.Name = "Canty";
            this.Canty.ReadOnly = true;
            // 
            // preciounity
            // 
            this.preciounity.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.preciounity.DataPropertyName = "preciounit";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle8.Format = "n2";
            this.preciounity.DefaultCellStyle = dataGridViewCellStyle8;
            this.preciounity.HeaderText = "Precio Unit";
            this.preciounity.Name = "preciounity";
            this.preciounity.Width = 89;
            // 
            // totaly
            // 
            this.totaly.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.totaly.DataPropertyName = "total";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.totaly.DefaultCellStyle = dataGridViewCellStyle9;
            this.totaly.HeaderText = "Total";
            this.totaly.Name = "totaly";
            this.totaly.ReadOnly = true;
            this.totaly.Width = 57;
            // 
            // btndescargar
            // 
            this.btndescargar.AutoEllipsis = true;
            this.btndescargar.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndescargar.ImageKey = "(ninguno)";
            this.btndescargar.Location = new System.Drawing.Point(908, 362);
            this.btndescargar.Name = "btndescargar";
            this.btndescargar.Size = new System.Drawing.Size(76, 23);
            this.btndescargar.TabIndex = 111;
            this.btndescargar.Text = "Descargar";
            this.btndescargar.UseVisualStyleBackColor = false;
            this.btndescargar.Visible = false;
            this.btndescargar.Click += new System.EventHandler(this.btndescargar_Click);
            this.btndescargar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btndescargar_MouseMove);
            // 
            // frmCotizacionModificar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1155, 402);
            this.Controls.Add(this.btndescargar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btncancelar);
            this.Controls.Add(this.pbFoto);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.dtgpedidoX);
            this.Controls.Add(this.dtgpedidoY);
            this.MaximumSize = new System.Drawing.Size(1171, 441);
            this.MinimumSize = new System.Drawing.Size(1171, 441);
            this.Name = "frmCotizacionModificar";
            this.Nombre = "  Modificar Cotización";
            this.Text = "  Modificar Cotización";
            this.Load += new System.EventHandler(this.frmCotizacionModificar_Load);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.frmCotizacionModificar_MouseMove);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbFoto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgpedidoX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgpedidoY)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtProveedor;
        private System.Windows.Forms.TextBox txtRUC;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnBuscarPDF;
        private System.Windows.Forms.TextBox txtAdjunto;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtImporte;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPedido;
        private System.Windows.Forms.TextBox txtCotizacion;
        private System.Windows.Forms.PictureBox pbFoto;
        private System.Windows.Forms.Button btncancelar;
        private System.Windows.Forms.Label label1;
        private Dtgconten dtgpedidoX;
        private Dtgconten dtgpedidoY;
        private System.Windows.Forms.Button btndescargar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbomoneda;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoy;
        private System.Windows.Forms.DataGridViewTextBoxColumn nrocoty;
        private System.Windows.Forms.DataGridViewTextBoxColumn cody;
        private System.Windows.Forms.DataGridViewTextBoxColumn articuloy;
        private System.Windows.Forms.DataGridViewTextBoxColumn marcay;
        private System.Windows.Forms.DataGridViewTextBoxColumn modeloy;
        private System.Windows.Forms.DataGridViewTextBoxColumn Canty;
        private System.Windows.Forms.DataGridViewTextBoxColumn preciounity;
        private System.Windows.Forms.DataGridViewTextBoxColumn totaly;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipox;
        private System.Windows.Forms.DataGridViewTextBoxColumn nrocotx;
        private System.Windows.Forms.DataGridViewTextBoxColumn codX;
        private System.Windows.Forms.DataGridViewTextBoxColumn ArticuloX;
        private System.Windows.Forms.DataGridViewTextBoxColumn DetalleX;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioUnitx;
        private System.Windows.Forms.DataGridViewTextBoxColumn Totalx;
    }
}