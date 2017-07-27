namespace HPReserger
{
    partial class frmCotizacion
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gridCotizacion = new System.Windows.Forms.DataGridView();
            this.OP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.USUARIO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AREA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GERENCIA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TIPO_PEDIDO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.cboArea = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.gridCotizacionesAsociadas = new System.Windows.Forms.DataGridView();
            this.COT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NOP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGOPROVEEDOR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PROVEEDOR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IMPORTE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FECHAENTREGA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ADJUNTO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lsbproveedor = new System.Windows.Forms.ListBox();
            this.txtProveedor = new System.Windows.Forms.TextBox();
            this.txtRUC = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnAsociar = new System.Windows.Forms.Button();
            this.btnBuscarPDF = new System.Windows.Forms.Button();
            this.txtAdjunto = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.txtImporte = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pbFoto = new System.Windows.Forms.PictureBox();
            this.dtgpedido = new System.Windows.Forms.DataGridView();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gridCotizacion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridCotizacionesAsociadas)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbFoto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgpedido)).BeginInit();
            this.SuspendLayout();
            // 
            // gridCotizacion
            // 
            this.gridCotizacion.AllowUserToAddRows = false;
            this.gridCotizacion.AllowUserToDeleteRows = false;
            this.gridCotizacion.AllowUserToResizeRows = false;
            this.gridCotizacion.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridCotizacion.BackgroundColor = System.Drawing.SystemColors.Control;
            this.gridCotizacion.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.gridCotizacion.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridCotizacion.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gridCotizacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridCotizacion.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.OP,
            this.c,
            this.USUARIO,
            this.AREA,
            this.GERENCIA,
            this.TIPO_PEDIDO});
            this.gridCotizacion.GridColor = System.Drawing.SystemColors.Control;
            this.gridCotizacion.Location = new System.Drawing.Point(9, 31);
            this.gridCotizacion.MultiSelect = false;
            this.gridCotizacion.Name = "gridCotizacion";
            this.gridCotizacion.ReadOnly = true;
            this.gridCotizacion.RowHeadersVisible = false;
            this.gridCotizacion.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridCotizacion.Size = new System.Drawing.Size(616, 230);
            this.gridCotizacion.TabIndex = 2;
            this.gridCotizacion.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridCotizacion_RowEnter);
            this.gridCotizacion.DoubleClick += new System.EventHandler(this.gridCotizacion_DoubleClick);
            // 
            // OP
            // 
            this.OP.DataPropertyName = "OP";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.OP.DefaultCellStyle = dataGridViewCellStyle2;
            this.OP.HeaderText = "Nº OP";
            this.OP.Name = "OP";
            this.OP.ReadOnly = true;
            // 
            // c
            // 
            this.c.DataPropertyName = "CODIGOUSUARIO";
            this.c.HeaderText = "c";
            this.c.Name = "c";
            this.c.ReadOnly = true;
            this.c.Visible = false;
            // 
            // USUARIO
            // 
            this.USUARIO.DataPropertyName = "USUARIO";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.USUARIO.DefaultCellStyle = dataGridViewCellStyle3;
            this.USUARIO.HeaderText = "USUARIO";
            this.USUARIO.Name = "USUARIO";
            this.USUARIO.ReadOnly = true;
            this.USUARIO.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.USUARIO.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // AREA
            // 
            this.AREA.DataPropertyName = "AREA";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AREA.DefaultCellStyle = dataGridViewCellStyle4;
            this.AREA.HeaderText = "AREA";
            this.AREA.Name = "AREA";
            this.AREA.ReadOnly = true;
            this.AREA.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.AREA.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // GERENCIA
            // 
            this.GERENCIA.DataPropertyName = "GERENCIA";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.GERENCIA.DefaultCellStyle = dataGridViewCellStyle5;
            this.GERENCIA.HeaderText = "GERENCIA";
            this.GERENCIA.Name = "GERENCIA";
            this.GERENCIA.ReadOnly = true;
            this.GERENCIA.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.GERENCIA.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // TIPO_PEDIDO
            // 
            this.TIPO_PEDIDO.DataPropertyName = "TIPO_PEDIDO";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TIPO_PEDIDO.DefaultCellStyle = dataGridViewCellStyle6;
            this.TIPO_PEDIDO.HeaderText = "TIPO PEDIDO";
            this.TIPO_PEDIDO.Name = "TIPO_PEDIDO";
            this.TIPO_PEDIDO.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(381, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Areas";
            // 
            // cboArea
            // 
            this.cboArea.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboArea.FormattingEnabled = true;
            this.cboArea.Location = new System.Drawing.Point(426, 4);
            this.cboArea.Name = "cboArea";
            this.cboArea.Size = new System.Drawing.Size(199, 21);
            this.cboArea.TabIndex = 4;
            this.cboArea.SelectedIndexChanged += new System.EventHandler(this.cboArea_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(6, 12);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Orden de Pedido:";
            // 
            // gridCotizacionesAsociadas
            // 
            this.gridCotizacionesAsociadas.AllowUserToAddRows = false;
            this.gridCotizacionesAsociadas.AllowUserToDeleteRows = false;
            this.gridCotizacionesAsociadas.AllowUserToResizeColumns = false;
            this.gridCotizacionesAsociadas.AllowUserToResizeRows = false;
            this.gridCotizacionesAsociadas.BackgroundColor = System.Drawing.SystemColors.Control;
            this.gridCotizacionesAsociadas.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.gridCotizacionesAsociadas.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridCotizacionesAsociadas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.gridCotizacionesAsociadas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridCotizacionesAsociadas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.COT,
            this.NOP,
            this.CODIGOPROVEEDOR,
            this.PROVEEDOR,
            this.IMPORTE,
            this.FECHAENTREGA,
            this.ADJUNTO});
            this.gridCotizacionesAsociadas.GridColor = System.Drawing.SystemColors.Control;
            this.gridCotizacionesAsociadas.Location = new System.Drawing.Point(9, 280);
            this.gridCotizacionesAsociadas.MultiSelect = false;
            this.gridCotizacionesAsociadas.Name = "gridCotizacionesAsociadas";
            this.gridCotizacionesAsociadas.ReadOnly = true;
            this.gridCotizacionesAsociadas.RowHeadersVisible = false;
            this.gridCotizacionesAsociadas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridCotizacionesAsociadas.Size = new System.Drawing.Size(619, 125);
            this.gridCotizacionesAsociadas.TabIndex = 17;
            this.gridCotizacionesAsociadas.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridCotizacionesAsociadas_RowEnter);
            this.gridCotizacionesAsociadas.DoubleClick += new System.EventHandler(this.gridCotizacionesAsociadas_DoubleClick);
            this.gridCotizacionesAsociadas.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gridCotizacionesAsociadas_KeyDown);
            // 
            // COT
            // 
            this.COT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.COT.DataPropertyName = "COTIZACION";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.COT.DefaultCellStyle = dataGridViewCellStyle8;
            this.COT.HeaderText = "Nº COT";
            this.COT.Name = "COT";
            this.COT.ReadOnly = true;
            this.COT.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // NOP
            // 
            this.NOP.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NOP.DataPropertyName = "PEDIDO";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NOP.DefaultCellStyle = dataGridViewCellStyle9;
            this.NOP.HeaderText = "Nº OP";
            this.NOP.Name = "NOP";
            this.NOP.ReadOnly = true;
            this.NOP.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.NOP.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // CODIGOPROVEEDOR
            // 
            this.CODIGOPROVEEDOR.DataPropertyName = "CODIGOPROVEEDOR";
            this.CODIGOPROVEEDOR.HeaderText = "CODIGOPROVEEDOR";
            this.CODIGOPROVEEDOR.Name = "CODIGOPROVEEDOR";
            this.CODIGOPROVEEDOR.ReadOnly = true;
            this.CODIGOPROVEEDOR.Visible = false;
            this.CODIGOPROVEEDOR.Width = 157;
            // 
            // PROVEEDOR
            // 
            this.PROVEEDOR.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.PROVEEDOR.DataPropertyName = "PROVEEDOR";
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PROVEEDOR.DefaultCellStyle = dataGridViewCellStyle10;
            this.PROVEEDOR.HeaderText = "PROVEEDOR";
            this.PROVEEDOR.Name = "PROVEEDOR";
            this.PROVEEDOR.ReadOnly = true;
            this.PROVEEDOR.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.PROVEEDOR.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // IMPORTE
            // 
            this.IMPORTE.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.IMPORTE.DataPropertyName = "IMPORTE";
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle11.Format = "N2";
            dataGridViewCellStyle11.NullValue = null;
            this.IMPORTE.DefaultCellStyle = dataGridViewCellStyle11;
            this.IMPORTE.HeaderText = "IMPORTE";
            this.IMPORTE.Name = "IMPORTE";
            this.IMPORTE.ReadOnly = true;
            this.IMPORTE.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.IMPORTE.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // FECHAENTREGA
            // 
            this.FECHAENTREGA.DataPropertyName = "FECHAENTREGA";
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.Format = "d";
            dataGridViewCellStyle12.NullValue = null;
            this.FECHAENTREGA.DefaultCellStyle = dataGridViewCellStyle12;
            this.FECHAENTREGA.HeaderText = "FECHA ENTREGA";
            this.FECHAENTREGA.Name = "FECHAENTREGA";
            this.FECHAENTREGA.ReadOnly = true;
            this.FECHAENTREGA.Width = 123;
            // 
            // ADJUNTO
            // 
            this.ADJUNTO.DataPropertyName = "ADJUNTO";
            this.ADJUNTO.HeaderText = "ADJUNTO";
            this.ADJUNTO.Name = "ADJUNTO";
            this.ADJUNTO.ReadOnly = true;
            this.ADJUNTO.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ADJUNTO.Visible = false;
            this.ADJUNTO.Width = 71;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 264);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(160, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "Cotización por Orden de Pedido:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lsbproveedor);
            this.groupBox1.Controls.Add(this.txtProveedor);
            this.groupBox1.Controls.Add(this.txtRUC);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.btnAsociar);
            this.groupBox1.Controls.Add(this.btnBuscarPDF);
            this.groupBox1.Controls.Add(this.txtAdjunto);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.dtpFecha);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtImporte);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(9, 411);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(616, 93);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            // 
            // lsbproveedor
            // 
            this.lsbproveedor.FormattingEnabled = true;
            this.lsbproveedor.Location = new System.Drawing.Point(68, 30);
            this.lsbproveedor.Name = "lsbproveedor";
            this.lsbproveedor.Size = new System.Drawing.Size(154, 69);
            this.lsbproveedor.TabIndex = 21;
            this.lsbproveedor.Visible = false;
            this.lsbproveedor.Click += new System.EventHandler(this.lsbproveedor_Click);
            this.lsbproveedor.MouseLeave += new System.EventHandler(this.lsbproveedor_MouseLeave);
            // 
            // txtProveedor
            // 
            this.txtProveedor.Location = new System.Drawing.Point(68, 39);
            this.txtProveedor.Name = "txtProveedor";
            this.txtProveedor.ReadOnly = true;
            this.txtProveedor.Size = new System.Drawing.Size(343, 20);
            this.txtProveedor.TabIndex = 28;
            this.txtProveedor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtRUC
            // 
            this.txtRUC.Location = new System.Drawing.Point(68, 13);
            this.txtRUC.MaxLength = 11;
            this.txtRUC.Multiline = true;
            this.txtRUC.Name = "txtRUC";
            this.txtRUC.Size = new System.Drawing.Size(154, 20);
            this.txtRUC.TabIndex = 27;
            this.txtRUC.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtRUC.Click += new System.EventHandler(this.txtRUC_Click);
            this.txtRUC.TextChanged += new System.EventHandler(this.txtRUC_TextChanged);
            this.txtRUC.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtRUC_KeyDown);
            this.txtRUC.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRUC_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 16);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(39, 13);
            this.label8.TabIndex = 26;
            this.label8.Text = "R.U.C.";
            // 
            // btnAsociar
            // 
            this.btnAsociar.Location = new System.Drawing.Point(535, 65);
            this.btnAsociar.Name = "btnAsociar";
            this.btnAsociar.Size = new System.Drawing.Size(75, 23);
            this.btnAsociar.TabIndex = 25;
            this.btnAsociar.Text = "Asociar";
            this.btnAsociar.UseVisualStyleBackColor = true;
            this.btnAsociar.Click += new System.EventHandler(this.btnAsociar_Click);
            // 
            // btnBuscarPDF
            // 
            this.btnBuscarPDF.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarPDF.Location = new System.Drawing.Point(502, 65);
            this.btnBuscarPDF.Name = "btnBuscarPDF";
            this.btnBuscarPDF.Size = new System.Drawing.Size(25, 23);
            this.btnBuscarPDF.TabIndex = 24;
            this.btnBuscarPDF.Text = "...";
            this.btnBuscarPDF.UseVisualStyleBackColor = true;
            this.btnBuscarPDF.Click += new System.EventHandler(this.btnBuscarPDF_Click);
            // 
            // txtAdjunto
            // 
            this.txtAdjunto.Location = new System.Drawing.Point(96, 65);
            this.txtAdjunto.Name = "txtAdjunto";
            this.txtAdjunto.ReadOnly = true;
            this.txtAdjunto.Size = new System.Drawing.Size(400, 20);
            this.txtAdjunto.TabIndex = 23;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 68);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 13);
            this.label5.TabIndex = 22;
            this.label5.Text = "Adjuntar archivo";
            // 
            // dtpFecha
            // 
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha.Location = new System.Drawing.Point(502, 39);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(108, 20);
            this.dtpFecha.TabIndex = 21;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(442, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "F. Entrega";
            // 
            // txtImporte
            // 
            this.txtImporte.Enabled = false;
            this.txtImporte.Location = new System.Drawing.Point(502, 13);
            this.txtImporte.Name = "txtImporte";
            this.txtImporte.Size = new System.Drawing.Size(108, 20);
            this.txtImporte.TabIndex = 19;
            this.txtImporte.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtImporte.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtImporte_KeyDown);
            this.txtImporte.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtImporte_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(442, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Importe";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Proveedor";
            // 
            // pbFoto
            // 
            this.pbFoto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.pbFoto.Location = new System.Drawing.Point(637, 5);
            this.pbFoto.Name = "pbFoto";
            this.pbFoto.Size = new System.Drawing.Size(539, 666);
            this.pbFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbFoto.TabIndex = 20;
            this.pbFoto.TabStop = false;
            // 
            // dtgpedido
            // 
            this.dtgpedido.AllowUserToAddRows = false;
            this.dtgpedido.AllowUserToDeleteRows = false;
            this.dtgpedido.AllowUserToResizeColumns = false;
            this.dtgpedido.AllowUserToResizeRows = false;
            this.dtgpedido.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dtgpedido.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dtgpedido.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dtgpedido.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgpedido.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle13;
            this.dtgpedido.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgpedido.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dtgpedido.GridColor = System.Drawing.SystemColors.Control;
            this.dtgpedido.Location = new System.Drawing.Point(9, 520);
            this.dtgpedido.Name = "dtgpedido";
            this.dtgpedido.RowHeadersVisible = false;
            this.dtgpedido.Size = new System.Drawing.Size(619, 150);
            this.dtgpedido.TabIndex = 21;
            this.dtgpedido.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgpedido_CellClick);
            this.dtgpedido.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgpedido_CellEndEdit);
            this.dtgpedido.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dtgpedido_EditingControlShowing);
            this.dtgpedido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dtgpedido_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 507);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(121, 13);
            this.label9.TabIndex = 22;
            this.label9.Text = "Detalle de la Cotizacion:";
            // 
            // frmCotizacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1195, 679);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.dtgpedido);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboArea);
            this.Controls.Add(this.gridCotizacion);
            this.Controls.Add(this.gridCotizacionesAsociadas);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.pbFoto);
            this.MaximizeBox = false;
            this.Name = "frmCotizacion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " Cotización";
            this.Load += new System.EventHandler(this.frmCotizacion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridCotizacion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridCotizacionesAsociadas)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbFoto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgpedido)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gridCotizacion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboArea;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView gridCotizacionesAsociadas;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnAsociar;
        private System.Windows.Forms.Button btnBuscarPDF;
        private System.Windows.Forms.TextBox txtAdjunto;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtImporte;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtRUC;
        private System.Windows.Forms.TextBox txtProveedor;
        private System.Windows.Forms.PictureBox pbFoto;
        private System.Windows.Forms.DataGridViewTextBoxColumn OP;
        private System.Windows.Forms.DataGridViewTextBoxColumn c;
        private System.Windows.Forms.DataGridViewTextBoxColumn USUARIO;
        private System.Windows.Forms.DataGridViewTextBoxColumn AREA;
        private System.Windows.Forms.DataGridViewTextBoxColumn GERENCIA;
        private System.Windows.Forms.DataGridViewTextBoxColumn TIPO_PEDIDO;
        private System.Windows.Forms.ListBox lsbproveedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn COT;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOP;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGOPROVEEDOR;
        private System.Windows.Forms.DataGridViewTextBoxColumn PROVEEDOR;
        private System.Windows.Forms.DataGridViewTextBoxColumn IMPORTE;
        private System.Windows.Forms.DataGridViewTextBoxColumn FECHAENTREGA;
        private System.Windows.Forms.DataGridViewTextBoxColumn ADJUNTO;
        private System.Windows.Forms.DataGridView dtgpedido;
        private System.Windows.Forms.Label label9;
    }
}