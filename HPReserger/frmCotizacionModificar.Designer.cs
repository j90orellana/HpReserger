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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtProveedor = new System.Windows.Forms.TextBox();
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
            this.dtgpedidoX = new System.Windows.Forms.DataGridView();
            this.tipox = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nrocotx = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ArticuloX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DetalleX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioUnitx = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Totalx = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtgpedidoY = new System.Windows.Forms.DataGridView();
            this.tipoy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nrocoty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cody = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.articuloy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.marcay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modeloy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Canty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.preciounity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totaly = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbFoto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgpedidoX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgpedidoY)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(551, 363);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 22;
            this.btnAceptar.Text = "Guardar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtProveedor);
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
            this.groupBox1.Location = new System.Drawing.Point(12, 68);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(695, 104);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            // 
            // txtProveedor
            // 
            this.txtProveedor.Location = new System.Drawing.Point(261, 19);
            this.txtProveedor.Name = "txtProveedor";
            this.txtProveedor.ReadOnly = true;
            this.txtProveedor.Size = new System.Drawing.Size(428, 20);
            this.txtProveedor.TabIndex = 28;
            this.txtProveedor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtRUC
            // 
            this.txtRUC.Enabled = false;
            this.txtRUC.Location = new System.Drawing.Point(74, 19);
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
            this.label8.Location = new System.Drawing.Point(10, 22);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(39, 13);
            this.label8.TabIndex = 26;
            this.label8.Text = "R.U.C.";
            // 
            // txtAdjunto
            // 
            this.txtAdjunto.Location = new System.Drawing.Point(100, 45);
            this.txtAdjunto.Name = "txtAdjunto";
            this.txtAdjunto.ReadOnly = true;
            this.txtAdjunto.Size = new System.Drawing.Size(558, 20);
            this.txtAdjunto.TabIndex = 23;
            // 
            // btnBuscarPDF
            // 
            this.btnBuscarPDF.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarPDF.Location = new System.Drawing.Point(664, 45);
            this.btnBuscarPDF.Name = "btnBuscarPDF";
            this.btnBuscarPDF.Size = new System.Drawing.Size(25, 23);
            this.btnBuscarPDF.TabIndex = 24;
            this.btnBuscarPDF.Text = "...";
            this.btnBuscarPDF.UseVisualStyleBackColor = true;
            this.btnBuscarPDF.Click += new System.EventHandler(this.btnBuscarPDF_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(10, 47);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 13);
            this.label7.TabIndex = 22;
            this.label7.Text = "Adjuntar archivo";
            // 
            // dtpFecha
            // 
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha.Location = new System.Drawing.Point(587, 73);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(102, 20);
            this.dtpFecha.TabIndex = 21;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(489, 76);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(92, 13);
            this.label9.TabIndex = 20;
            this.label9.Text = "Fecha de Entrega";
            // 
            // txtImporte
            // 
            this.txtImporte.Enabled = false;
            this.txtImporte.Location = new System.Drawing.Point(406, 73);
            this.txtImporte.Name = "txtImporte";
            this.txtImporte.Size = new System.Drawing.Size(77, 20);
            this.txtImporte.TabIndex = 19;
            this.txtImporte.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtImporte.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtImporte_KeyPress);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(358, 76);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(42, 13);
            this.label10.TabIndex = 18;
            this.label10.Text = "Importe";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(199, 22);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(56, 13);
            this.label11.TabIndex = 16;
            this.label11.Text = "Proveedor";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtPedido);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txtCotizacion);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(12, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(201, 68);
            this.groupBox2.TabIndex = 27;
            this.groupBox2.TabStop = false;
            // 
            // txtPedido
            // 
            this.txtPedido.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtPedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPedido.Location = new System.Drawing.Point(91, 42);
            this.txtPedido.Name = "txtPedido";
            this.txtPedido.ReadOnly = true;
            this.txtPedido.Size = new System.Drawing.Size(100, 20);
            this.txtPedido.TabIndex = 33;
            this.txtPedido.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(10, 45);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 26;
            this.label6.Text = "Nº Pedido";
            // 
            // txtCotizacion
            // 
            this.txtCotizacion.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtCotizacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCotizacion.Location = new System.Drawing.Point(91, 16);
            this.txtCotizacion.Name = "txtCotizacion";
            this.txtCotizacion.ReadOnly = true;
            this.txtCotizacion.Size = new System.Drawing.Size(100, 20);
            this.txtCotizacion.TabIndex = 32;
            this.txtCotizacion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(10, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 13);
            this.label4.TabIndex = 21;
            this.label4.Text = "Nº Cotización";
            // 
            // pbFoto
            // 
            this.pbFoto.Location = new System.Drawing.Point(713, 12);
            this.pbFoto.Name = "pbFoto";
            this.pbFoto.Size = new System.Drawing.Size(430, 374);
            this.pbFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbFoto.TabIndex = 28;
            this.pbFoto.TabStop = false;
            // 
            // btncancelar
            // 
            this.btncancelar.Location = new System.Drawing.Point(632, 363);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(75, 23);
            this.btncancelar.TabIndex = 29;
            this.btncancelar.Text = "Cancelar";
            this.btncancelar.UseVisualStyleBackColor = true;
            this.btncancelar.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 175);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 13);
            this.label1.TabIndex = 31;
            this.label1.Text = "Detalle de la Cotizacion:";
            // 
            // dtgpedidoX
            // 
            this.dtgpedidoX.AllowUserToAddRows = false;
            this.dtgpedidoX.AllowUserToDeleteRows = false;
            this.dtgpedidoX.AllowUserToResizeColumns = false;
            this.dtgpedidoX.AllowUserToResizeRows = false;
            this.dtgpedidoX.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dtgpedidoX.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dtgpedidoX.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dtgpedidoX.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgpedidoX.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgpedidoX.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgpedidoX.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tipox,
            this.nrocotx,
            this.codX,
            this.ArticuloX,
            this.DetalleX,
            this.PrecioUnitx,
            this.Totalx});
            this.dtgpedidoX.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dtgpedidoX.GridColor = System.Drawing.SystemColors.Control;
            this.dtgpedidoX.Location = new System.Drawing.Point(12, 188);
            this.dtgpedidoX.Name = "dtgpedidoX";
            this.dtgpedidoX.RowHeadersVisible = false;
            this.dtgpedidoX.Size = new System.Drawing.Size(695, 169);
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
            this.tipox.Width = 53;
            // 
            // nrocotx
            // 
            this.nrocotx.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.nrocotx.DataPropertyName = "nºcot";
            this.nrocotx.HeaderText = "NºCot";
            this.nrocotx.Name = "nrocotx";
            this.nrocotx.ReadOnly = true;
            this.nrocotx.Width = 60;
            // 
            // codX
            // 
            this.codX.DataPropertyName = "cod";
            this.codX.HeaderText = "Cod";
            this.codX.Name = "codX";
            this.codX.ReadOnly = true;
            this.codX.Visible = false;
            this.codX.Width = 51;
            // 
            // ArticuloX
            // 
            this.ArticuloX.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ArticuloX.DataPropertyName = "articulo";
            this.ArticuloX.HeaderText = "Articulo";
            this.ArticuloX.Name = "ArticuloX";
            this.ArticuloX.ReadOnly = true;
            this.ArticuloX.Width = 67;
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
            dataGridViewCellStyle2.Format = "n2";
            dataGridViewCellStyle2.NullValue = "0.00";
            this.PrecioUnitx.DefaultCellStyle = dataGridViewCellStyle2;
            this.PrecioUnitx.HeaderText = "Precio Unit";
            this.PrecioUnitx.Name = "PrecioUnitx";
            this.PrecioUnitx.Width = 84;
            // 
            // Totalx
            // 
            this.Totalx.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Totalx.DataPropertyName = "total";
            this.Totalx.HeaderText = "Total";
            this.Totalx.Name = "Totalx";
            this.Totalx.ReadOnly = true;
            this.Totalx.Width = 56;
            // 
            // dtgpedidoY
            // 
            this.dtgpedidoY.AllowUserToAddRows = false;
            this.dtgpedidoY.AllowUserToDeleteRows = false;
            this.dtgpedidoY.AllowUserToResizeColumns = false;
            this.dtgpedidoY.AllowUserToResizeRows = false;
            this.dtgpedidoY.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dtgpedidoY.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dtgpedidoY.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dtgpedidoY.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgpedidoY.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
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
            this.dtgpedidoY.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dtgpedidoY.GridColor = System.Drawing.SystemColors.Control;
            this.dtgpedidoY.Location = new System.Drawing.Point(12, 188);
            this.dtgpedidoY.Name = "dtgpedidoY";
            this.dtgpedidoY.RowHeadersVisible = false;
            this.dtgpedidoY.Size = new System.Drawing.Size(695, 169);
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
            this.tipoy.Width = 53;
            // 
            // nrocoty
            // 
            this.nrocoty.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.nrocoty.DataPropertyName = "nºcot";
            this.nrocoty.HeaderText = "NºCot";
            this.nrocoty.Name = "nrocoty";
            this.nrocoty.ReadOnly = true;
            this.nrocoty.Width = 60;
            // 
            // cody
            // 
            this.cody.DataPropertyName = "cod";
            this.cody.HeaderText = "Cod";
            this.cody.Name = "cody";
            this.cody.ReadOnly = true;
            this.cody.Width = 51;
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
            this.marcay.Width = 62;
            // 
            // modeloy
            // 
            this.modeloy.DataPropertyName = "modelo";
            this.modeloy.HeaderText = "Modelo";
            this.modeloy.Name = "modeloy";
            this.modeloy.ReadOnly = true;
            this.modeloy.Width = 67;
            // 
            // Canty
            // 
            this.Canty.DataPropertyName = "cant";
            this.Canty.HeaderText = "Cant";
            this.Canty.Name = "Canty";
            this.Canty.ReadOnly = true;
            this.Canty.Width = 54;
            // 
            // preciounity
            // 
            this.preciounity.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.preciounity.DataPropertyName = "preciounit";
            dataGridViewCellStyle4.Format = "n2";
            dataGridViewCellStyle4.NullValue = "0.00";
            this.preciounity.DefaultCellStyle = dataGridViewCellStyle4;
            this.preciounity.HeaderText = "Precio Unit";
            this.preciounity.Name = "preciounity";
            this.preciounity.Width = 84;
            // 
            // totaly
            // 
            this.totaly.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.totaly.DataPropertyName = "total";
            this.totaly.HeaderText = "Total";
            this.totaly.Name = "totaly";
            this.totaly.ReadOnly = true;
            this.totaly.Width = 56;
            // 
            // frmCotizacionModificar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1155, 402);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btncancelar);
            this.Controls.Add(this.pbFoto);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.dtgpedidoY);
            this.Controls.Add(this.dtgpedidoX);
            this.MaximizeBox = false;
            this.Name = "frmCotizacionModificar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "  Modificar Cotización";
            this.Load += new System.EventHandler(this.frmCotizacionModificar_Load);
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
        private System.Windows.Forms.DataGridView dtgpedidoX;
        private System.Windows.Forms.DataGridView dtgpedidoY;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipox;
        private System.Windows.Forms.DataGridViewTextBoxColumn nrocotx;
        private System.Windows.Forms.DataGridViewTextBoxColumn codX;
        private System.Windows.Forms.DataGridViewTextBoxColumn ArticuloX;
        private System.Windows.Forms.DataGridViewTextBoxColumn DetalleX;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioUnitx;
        private System.Windows.Forms.DataGridViewTextBoxColumn Totalx;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoy;
        private System.Windows.Forms.DataGridViewTextBoxColumn nrocoty;
        private System.Windows.Forms.DataGridViewTextBoxColumn cody;
        private System.Windows.Forms.DataGridViewTextBoxColumn articuloy;
        private System.Windows.Forms.DataGridViewTextBoxColumn marcay;
        private System.Windows.Forms.DataGridViewTextBoxColumn modeloy;
        private System.Windows.Forms.DataGridViewTextBoxColumn Canty;
        private System.Windows.Forms.DataGridViewTextBoxColumn preciounity;
        private System.Windows.Forms.DataGridViewTextBoxColumn totaly;
    }
}