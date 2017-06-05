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
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
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
            this.COT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NOP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGOPROVEEDOR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PROVEEDOR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IMPORTE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FECHAENTREGA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ADJUNTO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridCotizacion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridCotizacionesAsociadas)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbFoto)).BeginInit();
            this.SuspendLayout();
            // 
            // gridCotizacion
            // 
            this.gridCotizacion.AllowUserToAddRows = false;
            this.gridCotizacion.AllowUserToDeleteRows = false;
            this.gridCotizacion.AllowUserToResizeRows = false;
            this.gridCotizacion.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.gridCotizacion.GridColor = System.Drawing.Color.White;
            this.gridCotizacion.Location = new System.Drawing.Point(15, 39);
            this.gridCotizacion.Name = "gridCotizacion";
            this.gridCotizacion.ReadOnly = true;
            this.gridCotizacion.RowHeadersVisible = false;
            this.gridCotizacion.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridCotizacion.Size = new System.Drawing.Size(616, 278);
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
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(384, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Areas";
            // 
            // cboArea
            // 
            this.cboArea.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboArea.FormattingEnabled = true;
            this.cboArea.Location = new System.Drawing.Point(429, 12);
            this.cboArea.Name = "cboArea";
            this.cboArea.Size = new System.Drawing.Size(199, 21);
            this.cboArea.TabIndex = 4;
            this.cboArea.SelectedIndexChanged += new System.EventHandler(this.cboArea_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Orden de Pedido:";
            // 
            // gridCotizacionesAsociadas
            // 
            this.gridCotizacionesAsociadas.AllowUserToAddRows = false;
            this.gridCotizacionesAsociadas.AllowUserToDeleteRows = false;
            this.gridCotizacionesAsociadas.AllowUserToResizeRows = false;
            this.gridCotizacionesAsociadas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.gridCotizacionesAsociadas.GridColor = System.Drawing.Color.White;
            this.gridCotizacionesAsociadas.Location = new System.Drawing.Point(12, 472);
            this.gridCotizacionesAsociadas.Name = "gridCotizacionesAsociadas";
            this.gridCotizacionesAsociadas.ReadOnly = true;
            this.gridCotizacionesAsociadas.RowHeadersVisible = false;
            this.gridCotizacionesAsociadas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridCotizacionesAsociadas.Size = new System.Drawing.Size(619, 136);
            this.gridCotizacionesAsociadas.TabIndex = 17;
            this.gridCotizacionesAsociadas.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridCotizacionesAsociadas_RowEnter);
            this.gridCotizacionesAsociadas.DoubleClick += new System.EventHandler(this.gridCotizacionesAsociadas_DoubleClick);
            this.gridCotizacionesAsociadas.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gridCotizacionesAsociadas_KeyDown);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 456);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(160, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "Cotización por Orden de Pedido:";
            // 
            // groupBox1
            // 
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
            this.groupBox1.Location = new System.Drawing.Point(12, 323);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(616, 120);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            // 
            // txtProveedor
            // 
            this.txtProveedor.Location = new System.Drawing.Point(68, 50);
            this.txtProveedor.Name = "txtProveedor";
            this.txtProveedor.ReadOnly = true;
            this.txtProveedor.Size = new System.Drawing.Size(343, 20);
            this.txtProveedor.TabIndex = 28;
            this.txtProveedor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtRUC
            // 
            this.txtRUC.Location = new System.Drawing.Point(55, 16);
            this.txtRUC.Name = "txtRUC";
            this.txtRUC.Size = new System.Drawing.Size(154, 20);
            this.txtRUC.TabIndex = 27;
            this.txtRUC.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtRUC.TextChanged += new System.EventHandler(this.txtRUC_TextChanged);
            this.txtRUC.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtRUC_KeyDown);
            this.txtRUC.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRUC_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(10, 16);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(39, 13);
            this.label8.TabIndex = 26;
            this.label8.Text = "R.U.C.";
            // 
            // btnAsociar
            // 
            this.btnAsociar.Location = new System.Drawing.Point(522, 84);
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
            this.btnBuscarPDF.Location = new System.Drawing.Point(480, 84);
            this.btnBuscarPDF.Name = "btnBuscarPDF";
            this.btnBuscarPDF.Size = new System.Drawing.Size(25, 23);
            this.btnBuscarPDF.TabIndex = 24;
            this.btnBuscarPDF.Text = "...";
            this.btnBuscarPDF.UseVisualStyleBackColor = true;
            this.btnBuscarPDF.Click += new System.EventHandler(this.btnBuscarPDF_Click);
            // 
            // txtAdjunto
            // 
            this.txtAdjunto.Location = new System.Drawing.Point(96, 84);
            this.txtAdjunto.Name = "txtAdjunto";
            this.txtAdjunto.ReadOnly = true;
            this.txtAdjunto.Size = new System.Drawing.Size(374, 20);
            this.txtAdjunto.TabIndex = 23;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 84);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 13);
            this.label5.TabIndex = 22;
            this.label5.Text = "Adjuntar archivo";
            // 
            // dtpFecha
            // 
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha.Location = new System.Drawing.Point(495, 50);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(102, 20);
            this.dtpFecha.TabIndex = 21;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(428, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "F. Entrega";
            // 
            // txtImporte
            // 
            this.txtImporte.Location = new System.Drawing.Point(489, 16);
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
            this.label3.Location = new System.Drawing.Point(428, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Importe";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Proveedor";
            // 
            // pbFoto
            // 
            this.pbFoto.Location = new System.Drawing.Point(651, 12);
            this.pbFoto.Name = "pbFoto";
            this.pbFoto.Size = new System.Drawing.Size(507, 596);
            this.pbFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbFoto.TabIndex = 20;
            this.pbFoto.TabStop = false;
            // 
            // COT
            // 
            this.COT.DataPropertyName = "COTIZACION";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.COT.DefaultCellStyle = dataGridViewCellStyle8;
            this.COT.Frozen = true;
            this.COT.HeaderText = "Nº COT";
            this.COT.Name = "COT";
            this.COT.ReadOnly = true;
            this.COT.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.COT.Width = 56;
            // 
            // NOP
            // 
            this.NOP.DataPropertyName = "PEDIDO";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NOP.DefaultCellStyle = dataGridViewCellStyle9;
            this.NOP.Frozen = true;
            this.NOP.HeaderText = "Nº OP";
            this.NOP.Name = "NOP";
            this.NOP.ReadOnly = true;
            this.NOP.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.NOP.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.NOP.Width = 48;
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
            this.PROVEEDOR.DataPropertyName = "PROVEEDOR";
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PROVEEDOR.DefaultCellStyle = dataGridViewCellStyle10;
            this.PROVEEDOR.Frozen = true;
            this.PROVEEDOR.HeaderText = "PROVEEDOR";
            this.PROVEEDOR.Name = "PROVEEDOR";
            this.PROVEEDOR.ReadOnly = true;
            this.PROVEEDOR.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.PROVEEDOR.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.PROVEEDOR.Width = 90;
            // 
            // IMPORTE
            // 
            this.IMPORTE.DataPropertyName = "IMPORTE";
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle11.Format = "N2";
            dataGridViewCellStyle11.NullValue = null;
            this.IMPORTE.DefaultCellStyle = dataGridViewCellStyle11;
            this.IMPORTE.Frozen = true;
            this.IMPORTE.HeaderText = "IMPORTE";
            this.IMPORTE.Name = "IMPORTE";
            this.IMPORTE.ReadOnly = true;
            this.IMPORTE.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.IMPORTE.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.IMPORTE.Width = 69;
            // 
            // FECHAENTREGA
            // 
            this.FECHAENTREGA.DataPropertyName = "FECHAENTREGA";
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.Format = "d";
            dataGridViewCellStyle12.NullValue = null;
            this.FECHAENTREGA.DefaultCellStyle = dataGridViewCellStyle12;
            this.FECHAENTREGA.Frozen = true;
            this.FECHAENTREGA.HeaderText = "FECHA ENTREGA";
            this.FECHAENTREGA.Name = "FECHAENTREGA";
            this.FECHAENTREGA.ReadOnly = true;
            this.FECHAENTREGA.Width = 123;
            // 
            // ADJUNTO
            // 
            this.ADJUNTO.DataPropertyName = "ADJUNTO";
            this.ADJUNTO.Frozen = true;
            this.ADJUNTO.HeaderText = "ADJUNTO";
            this.ADJUNTO.Name = "ADJUNTO";
            this.ADJUNTO.ReadOnly = true;
            this.ADJUNTO.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ADJUNTO.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ADJUNTO.Width = 71;
            // 
            // frmCotizacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1170, 618);
            this.Controls.Add(this.pbFoto);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboArea);
            this.Controls.Add(this.gridCotizacion);
            this.Controls.Add(this.gridCotizacionesAsociadas);
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
        private System.Windows.Forms.DataGridViewTextBoxColumn COT;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOP;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGOPROVEEDOR;
        private System.Windows.Forms.DataGridViewTextBoxColumn PROVEEDOR;
        private System.Windows.Forms.DataGridViewTextBoxColumn IMPORTE;
        private System.Windows.Forms.DataGridViewTextBoxColumn FECHAENTREGA;
        private System.Windows.Forms.DataGridViewTextBoxColumn ADJUNTO;
    }
}