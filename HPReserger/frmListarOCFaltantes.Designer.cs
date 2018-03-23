namespace HPReserger
{
    partial class frmListarOCFaltantes
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
            this.dtgconten = new System.Windows.Forms.DataGridView();
            this.OC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.COT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PED = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TIPO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MONTO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ENTREGA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GERENCIA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AREA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EMPRESA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RUC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NOMBRESEMPLEADO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.APELLIDOS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnaceptar = new System.Windows.Forms.Button();
            this.btnrefres = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tip = new System.Windows.Forms.ToolTip(this.components);
            this.btncorreo = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblmsg = new System.Windows.Forms.ToolStripStatusLabel();
            this.mnopciones = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mnclick = new System.Windows.Forms.ToolStripMenuItem();
            this.label2 = new System.Windows.Forms.Label();
            this.txtbuscar = new System.Windows.Forms.TextBox();
            this.gb1 = new System.Windows.Forms.GroupBox();
            this.radioButton9 = new System.Windows.Forms.RadioButton();
            this.radioButton10 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton8 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton11 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton7 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.radioButton6 = new System.Windows.Forms.RadioButton();
            this.gb2 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.DTFIN = new System.Windows.Forms.DateTimePicker();
            this.DTINICIO = new System.Windows.Forms.DateTimePicker();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtgconten)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.mnopciones.SuspendLayout();
            this.gb1.SuspendLayout();
            this.gb2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtgconten
            // 
            this.dtgconten.AllowUserToAddRows = false;
            this.dtgconten.AllowUserToDeleteRows = false;
            this.dtgconten.AllowUserToResizeColumns = false;
            this.dtgconten.AllowUserToResizeRows = false;
            this.dtgconten.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgconten.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dtgconten.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dtgconten.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgconten.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.OC,
            this.COT,
            this.PED,
            this.TIPO,
            this.MONTO,
            this.ENTREGA,
            this.GERENCIA,
            this.AREA,
            this.EMPRESA,
            this.RUC,
            this.NOMBRESEMPLEADO,
            this.APELLIDOS});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgconten.DefaultCellStyle = dataGridViewCellStyle1;
            this.dtgconten.Location = new System.Drawing.Point(10, 138);
            this.dtgconten.MultiSelect = false;
            this.dtgconten.Name = "dtgconten";
            this.dtgconten.RowHeadersVisible = false;
            this.dtgconten.RowTemplate.Height = 16;
            this.dtgconten.Size = new System.Drawing.Size(1206, 329);
            this.dtgconten.TabIndex = 0;
            this.dtgconten.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgconten_CellClick);
            this.dtgconten.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgconten_CellDoubleClick);
            this.dtgconten.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dtgconten_CellMouseClick);
            this.dtgconten.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dtgconten_KeyDown);
            this.dtgconten.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dtgconten_MouseDown);
            // 
            // OC
            // 
            this.OC.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.OC.DataPropertyName = "OC";
            this.OC.HeaderText = "OC";
            this.OC.Name = "OC";
            this.OC.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.OC.ToolTipText = "Orden de Compra";
            this.OC.Width = 47;
            // 
            // COT
            // 
            this.COT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.COT.DataPropertyName = "COT";
            this.COT.HeaderText = "COT";
            this.COT.Name = "COT";
            this.COT.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.COT.ToolTipText = "Cotizacion";
            this.COT.Width = 54;
            // 
            // PED
            // 
            this.PED.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.PED.DataPropertyName = "PED";
            this.PED.HeaderText = "PED";
            this.PED.Name = "PED";
            this.PED.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.PED.ToolTipText = "Orden de Pedido";
            this.PED.Width = 54;
            // 
            // TIPO
            // 
            this.TIPO.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.TIPO.DataPropertyName = "TIPO";
            this.TIPO.HeaderText = "TIPO";
            this.TIPO.Name = "TIPO";
            this.TIPO.ToolTipText = "Articulo/Servicio";
            this.TIPO.Width = 57;
            // 
            // MONTO
            // 
            this.MONTO.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.MONTO.DataPropertyName = "MONTO";
            this.MONTO.FillWeight = 85.10638F;
            this.MONTO.HeaderText = "MONTO";
            this.MONTO.Name = "MONTO";
            this.MONTO.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.MONTO.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.MONTO.ToolTipText = "Importe";
            this.MONTO.Width = 53;
            // 
            // ENTREGA
            // 
            this.ENTREGA.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.ENTREGA.DataPropertyName = "ENTREGA";
            this.ENTREGA.FillWeight = 204.2553F;
            this.ENTREGA.HeaderText = "ENTREGA";
            this.ENTREGA.Name = "ENTREGA";
            this.ENTREGA.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ENTREGA.ToolTipText = "Fecha Entrega";
            this.ENTREGA.Width = 84;
            // 
            // GERENCIA
            // 
            this.GERENCIA.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.GERENCIA.DataPropertyName = "GERENCIA";
            this.GERENCIA.FillWeight = 85.10638F;
            this.GERENCIA.HeaderText = "GERENCIA";
            this.GERENCIA.Name = "GERENCIA";
            this.GERENCIA.Width = 87;
            // 
            // AREA
            // 
            this.AREA.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.AREA.DataPropertyName = "AREA";
            this.AREA.FillWeight = 85.10638F;
            this.AREA.HeaderText = "AREA";
            this.AREA.Name = "AREA";
            this.AREA.Width = 61;
            // 
            // EMPRESA
            // 
            this.EMPRESA.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.EMPRESA.DataPropertyName = "EMPRESA";
            this.EMPRESA.FillWeight = 85.10638F;
            this.EMPRESA.HeaderText = "EMPRESA";
            this.EMPRESA.Name = "EMPRESA";
            this.EMPRESA.Width = 84;
            // 
            // RUC
            // 
            this.RUC.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.RUC.DataPropertyName = "RUC";
            this.RUC.FillWeight = 85.10638F;
            this.RUC.HeaderText = "RUC";
            this.RUC.Name = "RUC";
            this.RUC.Width = 55;
            // 
            // NOMBRESEMPLEADO
            // 
            this.NOMBRESEMPLEADO.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NOMBRESEMPLEADO.DataPropertyName = "NOMBRESEMPLEADO";
            this.NOMBRESEMPLEADO.FillWeight = 85.10638F;
            this.NOMBRESEMPLEADO.HeaderText = "NOMBRESEMPLEADO";
            this.NOMBRESEMPLEADO.Name = "NOMBRESEMPLEADO";
            // 
            // APELLIDOS
            // 
            this.APELLIDOS.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.APELLIDOS.DataPropertyName = "APELLIDOS";
            this.APELLIDOS.FillWeight = 85.10638F;
            this.APELLIDOS.HeaderText = "APELLIDOS";
            this.APELLIDOS.Name = "APELLIDOS";
            this.APELLIDOS.Width = 91;
            // 
            // btnaceptar
            // 
            this.btnaceptar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnaceptar.Location = new System.Drawing.Point(1141, 473);
            this.btnaceptar.Name = "btnaceptar";
            this.btnaceptar.Size = new System.Drawing.Size(75, 23);
            this.btnaceptar.TabIndex = 1;
            this.btnaceptar.Text = "Aceptar";
            this.tip.SetToolTip(this.btnaceptar, "Cerrar la Ventana");
            this.btnaceptar.UseVisualStyleBackColor = true;
            this.btnaceptar.Click += new System.EventHandler(this.btnaceptar_Click);
            // 
            // btnrefres
            // 
            this.btnrefres.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnrefres.Location = new System.Drawing.Point(1060, 473);
            this.btnrefres.Name = "btnrefres";
            this.btnrefres.Size = new System.Drawing.Size(75, 23);
            this.btnrefres.TabIndex = 1;
            this.btnrefres.Text = "Actualizar";
            this.tip.SetToolTip(this.btnrefres, "Recarga la Grilla");
            this.btnrefres.UseVisualStyleBackColor = true;
            this.btnrefres.Click += new System.EventHandler(this.btnrefres_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "ORDENES DE COMPRA POR RECIBIR";
            // 
            // tip
            // 
            this.tip.IsBalloon = true;
            // 
            // btncorreo
            // 
            this.btncorreo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btncorreo.Location = new System.Drawing.Point(577, 473);
            this.btncorreo.Name = "btncorreo";
            this.btncorreo.Size = new System.Drawing.Size(75, 23);
            this.btncorreo.TabIndex = 8;
            this.btncorreo.Text = "Correo";
            this.tip.SetToolTip(this.btncorreo, "Envia un Correo al Proveedor");
            this.btncorreo.UseVisualStyleBackColor = true;
            this.btncorreo.Click += new System.EventHandler(this.btncorreo_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblmsg});
            this.statusStrip1.Location = new System.Drawing.Point(0, 503);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1228, 22);
            this.statusStrip1.TabIndex = 3;
            // 
            // lblmsg
            // 
            this.lblmsg.Name = "lblmsg";
            this.lblmsg.Size = new System.Drawing.Size(0, 17);
            // 
            // mnopciones
            // 
            this.mnopciones.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnclick});
            this.mnopciones.Name = "mnopciones";
            this.mnopciones.Size = new System.Drawing.Size(110, 26);
            // 
            // mnclick
            // 
            this.mnclick.Name = "mnclick";
            this.mnclick.Size = new System.Drawing.Size(109, 22);
            this.mnclick.Text = "Copiar";
            this.mnclick.Click += new System.EventHandler(this.mnclick_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "BUSCAR";
            // 
            // txtbuscar
            // 
            this.txtbuscar.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtbuscar.Location = new System.Drawing.Point(63, 10);
            this.txtbuscar.Name = "txtbuscar";
            this.txtbuscar.Size = new System.Drawing.Size(268, 20);
            this.txtbuscar.TabIndex = 5;
            this.txtbuscar.TextChanged += new System.EventHandler(this.txtbuscar_TextChanged);
            // 
            // gb1
            // 
            this.gb1.Controls.Add(this.radioButton9);
            this.gb1.Controls.Add(this.radioButton10);
            this.gb1.Controls.Add(this.radioButton3);
            this.gb1.Controls.Add(this.radioButton8);
            this.gb1.Controls.Add(this.radioButton2);
            this.gb1.Controls.Add(this.radioButton11);
            this.gb1.Controls.Add(this.radioButton1);
            this.gb1.Controls.Add(this.radioButton7);
            this.gb1.Controls.Add(this.radioButton4);
            this.gb1.Controls.Add(this.radioButton5);
            this.gb1.Controls.Add(this.radioButton6);
            this.gb1.Location = new System.Drawing.Point(15, 37);
            this.gb1.Name = "gb1";
            this.gb1.Size = new System.Drawing.Size(928, 43);
            this.gb1.TabIndex = 6;
            this.gb1.TabStop = false;
            this.gb1.Text = "Buscar Por:";
            // 
            // radioButton9
            // 
            this.radioButton9.AutoSize = true;
            this.radioButton9.Location = new System.Drawing.Point(736, 18);
            this.radioButton9.Name = "radioButton9";
            this.radioButton9.Size = new System.Drawing.Size(67, 17);
            this.radioButton9.TabIndex = 0;
            this.radioButton9.Text = "Apellidos";
            this.radioButton9.UseVisualStyleBackColor = true;
            this.radioButton9.CheckedChanged += new System.EventHandler(this.radioButton9_CheckedChanged);
            // 
            // radioButton10
            // 
            this.radioButton10.AutoSize = true;
            this.radioButton10.Location = new System.Drawing.Point(305, 18);
            this.radioButton10.Name = "radioButton10";
            this.radioButton10.Size = new System.Drawing.Size(55, 17);
            this.radioButton10.TabIndex = 0;
            this.radioButton10.Text = "Monto";
            this.radioButton10.UseVisualStyleBackColor = true;
            this.radioButton10.CheckedChanged += new System.EventHandler(this.radioButton8_CheckedChanged);
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(241, 18);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(58, 17);
            this.radioButton3.TabIndex = 0;
            this.radioButton3.Text = "Pedido";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // radioButton8
            // 
            this.radioButton8.AutoSize = true;
            this.radioButton8.Location = new System.Drawing.Point(616, 18);
            this.radioButton8.Name = "radioButton8";
            this.radioButton8.Size = new System.Drawing.Size(114, 17);
            this.radioButton8.TabIndex = 0;
            this.radioButton8.Text = "NombresEmpleado";
            this.radioButton8.UseVisualStyleBackColor = true;
            this.radioButton8.CheckedChanged += new System.EventHandler(this.radioButton8_CheckedChanged_1);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(161, 18);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(74, 17);
            this.radioButton2.TabIndex = 0;
            this.radioButton2.Text = "Cotizacion";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton11
            // 
            this.radioButton11.AutoSize = true;
            this.radioButton11.Checked = true;
            this.radioButton11.Location = new System.Drawing.Point(9, 18);
            this.radioButton11.Name = "radioButton11";
            this.radioButton11.Size = new System.Drawing.Size(50, 17);
            this.radioButton11.TabIndex = 0;
            this.radioButton11.TabStop = true;
            this.radioButton11.Text = "Todo";
            this.radioButton11.UseVisualStyleBackColor = true;
            this.radioButton11.CheckedChanged += new System.EventHandler(this.radioButton11_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(65, 18);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(90, 17);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.Text = "OrdenCompra";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton7
            // 
            this.radioButton7.AutoSize = true;
            this.radioButton7.Location = new System.Drawing.Point(565, 18);
            this.radioButton7.Name = "radioButton7";
            this.radioButton7.Size = new System.Drawing.Size(45, 17);
            this.radioButton7.TabIndex = 0;
            this.radioButton7.Text = "Ruc";
            this.radioButton7.UseVisualStyleBackColor = true;
            this.radioButton7.CheckedChanged += new System.EventHandler(this.radioButton7_CheckedChanged);
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(366, 18);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(68, 17);
            this.radioButton4.TabIndex = 0;
            this.radioButton4.Text = "Gerencia";
            this.radioButton4.UseVisualStyleBackColor = true;
            this.radioButton4.CheckedChanged += new System.EventHandler(this.radioButton4_CheckedChanged);
            // 
            // radioButton5
            // 
            this.radioButton5.AutoSize = true;
            this.radioButton5.Location = new System.Drawing.Point(440, 18);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(47, 17);
            this.radioButton5.TabIndex = 0;
            this.radioButton5.Text = "Area";
            this.radioButton5.UseVisualStyleBackColor = true;
            this.radioButton5.CheckedChanged += new System.EventHandler(this.radioButton5_CheckedChanged);
            // 
            // radioButton6
            // 
            this.radioButton6.AutoSize = true;
            this.radioButton6.Location = new System.Drawing.Point(493, 18);
            this.radioButton6.Name = "radioButton6";
            this.radioButton6.Size = new System.Drawing.Size(66, 17);
            this.radioButton6.TabIndex = 0;
            this.radioButton6.Text = "Empresa";
            this.radioButton6.UseVisualStyleBackColor = true;
            this.radioButton6.CheckedChanged += new System.EventHandler(this.radioButton6_CheckedChanged);
            // 
            // gb2
            // 
            this.gb2.Controls.Add(this.button1);
            this.gb2.Controls.Add(this.label4);
            this.gb2.Controls.Add(this.label3);
            this.gb2.Controls.Add(this.DTFIN);
            this.gb2.Controls.Add(this.DTINICIO);
            this.gb2.Controls.Add(this.checkBox3);
            this.gb2.Controls.Add(this.checkBox2);
            this.gb2.Controls.Add(this.checkBox1);
            this.gb2.Controls.Add(this.txtbuscar);
            this.gb2.Controls.Add(this.label2);
            this.gb2.Location = new System.Drawing.Point(15, 87);
            this.gb2.Name = "gb2";
            this.gb2.Size = new System.Drawing.Size(928, 45);
            this.gb2.TabIndex = 7;
            this.gb2.TabStop = false;
            this.gb2.Enter += new System.EventHandler(this.gb2_Enter);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(337, 10);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(22, 20);
            this.button1.TabIndex = 8;
            this.button1.Text = "-";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(752, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "HASTA:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(634, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "DE:";
            // 
            // DTFIN
            // 
            this.DTFIN.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DTFIN.Location = new System.Drawing.Point(804, 10);
            this.DTFIN.Name = "DTFIN";
            this.DTFIN.Size = new System.Drawing.Size(81, 20);
            this.DTFIN.TabIndex = 6;
            this.DTFIN.ValueChanged += new System.EventHandler(this.DTFIN_ValueChanged);
            // 
            // DTINICIO
            // 
            this.DTINICIO.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DTINICIO.Location = new System.Drawing.Point(665, 10);
            this.DTINICIO.Name = "DTINICIO";
            this.DTINICIO.Size = new System.Drawing.Size(81, 20);
            this.DTINICIO.TabIndex = 6;
            this.DTINICIO.ValueChanged += new System.EventHandler(this.DTINICIO_ValueChanged);
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(567, 12);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(61, 17);
            this.checkBox3.TabIndex = 5;
            this.checkBox3.Text = "FECHA";
            this.checkBox3.UseVisualStyleBackColor = true;
            this.checkBox3.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Checked = true;
            this.checkBox2.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox2.Location = new System.Drawing.Point(452, 12);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(76, 17);
            this.checkBox2.TabIndex = 5;
            this.checkBox2.Text = "SERVICIO";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.Location = new System.Drawing.Point(366, 12);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(80, 17);
            this.checkBox1.TabIndex = 5;
            this.checkBox1.Text = "ARTICULO";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // frmListarOCFaltantes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1228, 525);
            this.Controls.Add(this.btncorreo);
            this.Controls.Add(this.gb2);
            this.Controls.Add(this.gb1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnrefres);
            this.Controls.Add(this.btnaceptar);
            this.Controls.Add(this.dtgconten);
            this.Name = "frmListarOCFaltantes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Orden de Compra - Atención Incompleta.";
            this.Load += new System.EventHandler(this.frmListarOCFaltantes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgconten)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.mnopciones.ResumeLayout(false);
            this.gb1.ResumeLayout(false);
            this.gb1.PerformLayout();
            this.gb2.ResumeLayout(false);
            this.gb2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgconten;
        private System.Windows.Forms.Button btnaceptar;
        private System.Windows.Forms.Button btnrefres;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolTip tip;
        private System.Windows.Forms.DataGridViewTextBoxColumn OC;
        private System.Windows.Forms.DataGridViewTextBoxColumn COT;
        private System.Windows.Forms.DataGridViewTextBoxColumn PED;
        private System.Windows.Forms.DataGridViewTextBoxColumn TIPO;
        private System.Windows.Forms.DataGridViewTextBoxColumn MONTO;
        private System.Windows.Forms.DataGridViewTextBoxColumn ENTREGA;
        private System.Windows.Forms.DataGridViewTextBoxColumn GERENCIA;
        private System.Windows.Forms.DataGridViewTextBoxColumn AREA;
        private System.Windows.Forms.DataGridViewTextBoxColumn EMPRESA;
        private System.Windows.Forms.DataGridViewTextBoxColumn RUC;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOMBRESEMPLEADO;
        private System.Windows.Forms.DataGridViewTextBoxColumn APELLIDOS;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblmsg;
        private System.Windows.Forms.ContextMenuStrip mnopciones;
        private System.Windows.Forms.ToolStripMenuItem mnclick;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtbuscar;
        private System.Windows.Forms.GroupBox gb1;
        private System.Windows.Forms.RadioButton radioButton8;
        private System.Windows.Forms.RadioButton radioButton7;
        private System.Windows.Forms.RadioButton radioButton6;
        private System.Windows.Forms.RadioButton radioButton5;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton9;
        private System.Windows.Forms.RadioButton radioButton10;
        private System.Windows.Forms.GroupBox gb2;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.RadioButton radioButton11;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker DTFIN;
        private System.Windows.Forms.DateTimePicker DTINICIO;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btncorreo;
    }
}