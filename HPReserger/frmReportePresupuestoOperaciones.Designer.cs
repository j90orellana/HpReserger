namespace HPReserger
{
    partial class frmReportePresupuestoOperaciones
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReportePresupuestoOperaciones));
            this.label1 = new System.Windows.Forms.Label();
            this.cboempresa = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cboproyecto = new System.Windows.Forms.ComboBox();
            this.dtgconten = new HpResergerUserControls.Dtgconten();
            this.iddep = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.conta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripción = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cta_Contable = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.importe_proy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CodCentroC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcionetapa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.importe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Operaciones = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Diferencia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_etapas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnexportarexcel = new System.Windows.Forms.Button();
            this.lblmsg = new System.Windows.Forms.Label();
            this.txtdiferencia = new System.Windows.Forms.TextBox();
            this.txtoperaciones = new System.Windows.Forms.TextBox();
            this.txtimporte = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btncancelar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.cbopresupuestos = new System.Windows.Forms.ComboBox();
            this.btnGenerar = new HpResergerUserControls.ButtonPer();
            ((System.ComponentModel.ISupportInitialize)(this.dtgconten)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Empresa:";
            // 
            // cboempresa
            // 
            this.cboempresa.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboempresa.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboempresa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboempresa.FormattingEnabled = true;
            this.cboempresa.Location = new System.Drawing.Point(68, 16);
            this.cboempresa.Name = "cboempresa";
            this.cboempresa.Size = new System.Drawing.Size(257, 21);
            this.cboempresa.TabIndex = 1;
            this.cboempresa.SelectedIndexChanged += new System.EventHandler(this.cboempresa_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(12, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Proyecto:";
            // 
            // cboproyecto
            // 
            this.cboproyecto.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboproyecto.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboproyecto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboproyecto.FormattingEnabled = true;
            this.cboproyecto.Location = new System.Drawing.Point(69, 42);
            this.cboproyecto.Name = "cboproyecto";
            this.cboproyecto.Size = new System.Drawing.Size(257, 21);
            this.cboproyecto.TabIndex = 1;
            this.cboproyecto.SelectedIndexChanged += new System.EventHandler(this.cboproyecto_SelectedIndexChanged);
            // 
            // dtgconten
            // 
            this.dtgconten.AllowUserToAddRows = false;
            this.dtgconten.AllowUserToDeleteRows = false;
            this.dtgconten.AllowUserToResizeColumns = false;
            this.dtgconten.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(230)))), ((int)(((byte)(241)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(191)))), ((int)(((byte)(231)))));
            this.dtgconten.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgconten.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgconten.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgconten.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(218)))), ((int)(((byte)(231)))));
            this.dtgconten.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
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
            this.dtgconten.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dtgconten.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iddep,
            this.conta,
            this.Descripción,
            this.Cta_Contable,
            this.importe_proy,
            this.CodCentroC,
            this.descripcionetapa,
            this.importe,
            this.Operaciones,
            this.Diferencia,
            this.id_etapas});
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(207)))), ((int)(((byte)(241)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgconten.DefaultCellStyle = dataGridViewCellStyle7;
            this.dtgconten.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dtgconten.EnableHeadersVisualStyles = false;
            this.dtgconten.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(179)))), ((int)(((byte)(215)))));
            this.dtgconten.Location = new System.Drawing.Point(12, 67);
            this.dtgconten.MultiSelect = false;
            this.dtgconten.Name = "dtgconten";
            this.dtgconten.ReadOnly = true;
            this.dtgconten.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dtgconten.RowHeadersVisible = false;
            this.dtgconten.RowTemplate.Height = 16;
            this.dtgconten.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgconten.Size = new System.Drawing.Size(926, 489);
            this.dtgconten.TabIndex = 17;
            this.dtgconten.TabStop = false;
            this.dtgconten.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgconten_CellClick);
            this.dtgconten.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgconten_CellDoubleClick);
            this.dtgconten.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgconten_RowEnter);
            // 
            // iddep
            // 
            this.iddep.DataPropertyName = "iddep";
            this.iddep.HeaderText = "idedep";
            this.iddep.Name = "iddep";
            this.iddep.ReadOnly = true;
            this.iddep.Visible = false;
            // 
            // conta
            // 
            this.conta.DataPropertyName = "contador";
            this.conta.HeaderText = "conta";
            this.conta.Name = "conta";
            this.conta.ReadOnly = true;
            this.conta.Visible = false;
            // 
            // Descripción
            // 
            this.Descripción.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Descripción.DataPropertyName = "centrocosto";
            this.Descripción.HeaderText = "Descripción";
            this.Descripción.Name = "Descripción";
            this.Descripción.ReadOnly = true;
            this.Descripción.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Cta_Contable
            // 
            this.Cta_Contable.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Cta_Contable.DataPropertyName = "id_ctactble";
            this.Cta_Contable.HeaderText = "CuentaContable";
            this.Cta_Contable.Name = "Cta_Contable";
            this.Cta_Contable.ReadOnly = true;
            this.Cta_Contable.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Cta_Contable.Width = 96;
            // 
            // importe_proy
            // 
            this.importe_proy.DataPropertyName = "importe_proy";
            dataGridViewCellStyle3.Format = "n2";
            this.importe_proy.DefaultCellStyle = dataGridViewCellStyle3;
            this.importe_proy.HeaderText = "Importe_proy";
            this.importe_proy.Name = "importe_proy";
            this.importe_proy.ReadOnly = true;
            this.importe_proy.Visible = false;
            // 
            // CodCentroC
            // 
            this.CodCentroC.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.CodCentroC.DataPropertyName = "Cod_ccosto";
            this.CodCentroC.HeaderText = "CentroCosto";
            this.CodCentroC.Name = "CodCentroC";
            this.CodCentroC.ReadOnly = true;
            this.CodCentroC.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.CodCentroC.Width = 77;
            // 
            // descripcionetapa
            // 
            this.descripcionetapa.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.descripcionetapa.DataPropertyName = "descripcion";
            this.descripcionetapa.HeaderText = "Etapas";
            this.descripcionetapa.Name = "descripcionetapa";
            this.descripcionetapa.ReadOnly = true;
            this.descripcionetapa.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.descripcionetapa.Width = 46;
            // 
            // importe
            // 
            this.importe.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.importe.DataPropertyName = "importe_Ceco";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle4.Format = "n2";
            this.importe.DefaultCellStyle = dataGridViewCellStyle4;
            this.importe.HeaderText = "Importe";
            this.importe.Name = "importe";
            this.importe.ReadOnly = true;
            this.importe.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.importe.Width = 52;
            // 
            // Operaciones
            // 
            this.Operaciones.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Operaciones.DataPropertyName = "operaciones";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle5.Format = "n2";
            this.Operaciones.DefaultCellStyle = dataGridViewCellStyle5;
            this.Operaciones.HeaderText = "Operaciones";
            this.Operaciones.Name = "Operaciones";
            this.Operaciones.ReadOnly = true;
            this.Operaciones.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Operaciones.Width = 77;
            // 
            // Diferencia
            // 
            this.Diferencia.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Diferencia.DataPropertyName = "diferencia";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle6.Format = "n2";
            this.Diferencia.DefaultCellStyle = dataGridViewCellStyle6;
            this.Diferencia.HeaderText = "Diferencia";
            this.Diferencia.Name = "Diferencia";
            this.Diferencia.ReadOnly = true;
            this.Diferencia.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Diferencia.Width = 64;
            // 
            // id_etapas
            // 
            this.id_etapas.DataPropertyName = "Id_etapa";
            this.id_etapas.HeaderText = "id_etapas";
            this.id_etapas.Name = "id_etapas";
            this.id_etapas.ReadOnly = true;
            this.id_etapas.Visible = false;
            // 
            // btnexportarexcel
            // 
            this.btnexportarexcel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnexportarexcel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnexportarexcel.Image = ((System.Drawing.Image)(resources.GetObject("btnexportarexcel.Image")));
            this.btnexportarexcel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnexportarexcel.Location = new System.Drawing.Point(864, 14);
            this.btnexportarexcel.Name = "btnexportarexcel";
            this.btnexportarexcel.Size = new System.Drawing.Size(75, 24);
            this.btnexportarexcel.TabIndex = 19;
            this.btnexportarexcel.Text = "Excel";
            this.btnexportarexcel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnexportarexcel.UseVisualStyleBackColor = true;
            this.btnexportarexcel.Click += new System.EventHandler(this.btnexportarexcel_Click);
            // 
            // lblmsg
            // 
            this.lblmsg.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblmsg.AutoSize = true;
            this.lblmsg.BackColor = System.Drawing.Color.Transparent;
            this.lblmsg.Location = new System.Drawing.Point(12, 568);
            this.lblmsg.Name = "lblmsg";
            this.lblmsg.Size = new System.Drawing.Size(58, 13);
            this.lblmsg.TabIndex = 24;
            this.lblmsg.Text = "Registros:";
            // 
            // txtdiferencia
            // 
            this.txtdiferencia.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtdiferencia.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtdiferencia.Location = new System.Drawing.Point(854, 41);
            this.txtdiferencia.Name = "txtdiferencia";
            this.txtdiferencia.ReadOnly = true;
            this.txtdiferencia.Size = new System.Drawing.Size(84, 22);
            this.txtdiferencia.TabIndex = 25;
            this.txtdiferencia.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtoperaciones
            // 
            this.txtoperaciones.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtoperaciones.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtoperaciones.Location = new System.Drawing.Point(764, 41);
            this.txtoperaciones.Name = "txtoperaciones";
            this.txtoperaciones.ReadOnly = true;
            this.txtoperaciones.Size = new System.Drawing.Size(84, 22);
            this.txtoperaciones.TabIndex = 26;
            this.txtoperaciones.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtimporte
            // 
            this.txtimporte.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtimporte.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtimporte.Location = new System.Drawing.Point(674, 41);
            this.txtimporte.Name = "txtimporte";
            this.txtimporte.ReadOnly = true;
            this.txtimporte.Size = new System.Drawing.Size(84, 22);
            this.txtimporte.TabIndex = 27;
            this.txtimporte.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(623, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 28;
            this.label3.Text = "Totales:";
            // 
            // btncancelar
            // 
            this.btncancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btncancelar.Image = ((System.Drawing.Image)(resources.GetObject("btncancelar.Image")));
            this.btncancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btncancelar.Location = new System.Drawing.Point(863, 562);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(75, 24);
            this.btncancelar.TabIndex = 29;
            this.btncancelar.Text = "Cancelar";
            this.btncancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btncancelar.UseVisualStyleBackColor = true;
            this.btncancelar.Click += new System.EventHandler(this.btncancelar_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.Location = new System.Drawing.Point(744, 14);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(114, 24);
            this.button1.TabIndex = 30;
            this.button1.Text = "Análisis por Periodo";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(331, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 13);
            this.label4.TabIndex = 31;
            this.label4.Text = "Presupuestos:";
            // 
            // cbopresupuestos
            // 
            this.cbopresupuestos.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbopresupuestos.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbopresupuestos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbopresupuestos.FormattingEnabled = true;
            this.cbopresupuestos.Location = new System.Drawing.Point(411, 16);
            this.cbopresupuestos.Name = "cbopresupuestos";
            this.cbopresupuestos.Size = new System.Drawing.Size(242, 21);
            this.cbopresupuestos.TabIndex = 32;
            this.cbopresupuestos.SelectedIndexChanged += new System.EventHandler(this.cbopresupuestos_SelectedIndexChanged);
            // 
            // btnGenerar
            // 
            this.btnGenerar.BackColor = System.Drawing.Color.SeaGreen;
            this.btnGenerar.FlatAppearance.BorderColor = System.Drawing.Color.Olive;
            this.btnGenerar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerar.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerar.ForeColor = System.Drawing.Color.White;
            this.btnGenerar.Location = new System.Drawing.Point(334, 40);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(83, 24);
            this.btnGenerar.TabIndex = 407;
            this.btnGenerar.Text = "&Procesar";
            this.btnGenerar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGenerar.UseVisualStyleBackColor = false;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // frmReportePresupuestoOperaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(950, 592);
            this.Controls.Add(this.btnGenerar);
            this.Controls.Add(this.cbopresupuestos);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btncancelar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtimporte);
            this.Controls.Add(this.txtoperaciones);
            this.Controls.Add(this.txtdiferencia);
            this.Controls.Add(this.lblmsg);
            this.Controls.Add(this.btnexportarexcel);
            this.Controls.Add(this.cboproyecto);
            this.Controls.Add(this.cboempresa);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtgconten);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinimumSize = new System.Drawing.Size(966, 631);
            this.Name = "frmReportePresupuestoOperaciones";
            this.Nombre = "Detalle de Movimientos";
            this.Text = "Detalle de Movimientos";
            this.Load += new System.EventHandler(this.frmReportePresupuestoOperaciones_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgconten)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboempresa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboproyecto;
        private HpResergerUserControls.Dtgconten dtgconten;
        private System.Windows.Forms.Button btnexportarexcel;
        private System.Windows.Forms.Label lblmsg;
        private System.Windows.Forms.TextBox txtdiferencia;
        private System.Windows.Forms.TextBox txtoperaciones;
        private System.Windows.Forms.TextBox txtimporte;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btncancelar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbopresupuestos;
        private System.Windows.Forms.DataGridViewTextBoxColumn iddep;
        private System.Windows.Forms.DataGridViewTextBoxColumn conta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripción;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cta_Contable;
        private System.Windows.Forms.DataGridViewTextBoxColumn importe_proy;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodCentroC;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcionetapa;
        private System.Windows.Forms.DataGridViewTextBoxColumn importe;
        private System.Windows.Forms.DataGridViewTextBoxColumn Operaciones;
        private System.Windows.Forms.DataGridViewTextBoxColumn Diferencia;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_etapas;
        private HpResergerUserControls.ButtonPer btnGenerar;
    }
}