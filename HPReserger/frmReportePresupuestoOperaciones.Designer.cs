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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.cboempresa = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cboproyecto = new System.Windows.Forms.ComboBox();
            this.dtgconten = new System.Windows.Forms.DataGridView();
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
            this.btnGenerar = new System.Windows.Forms.Button();
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
            ((System.ComponentModel.ISupportInitialize)(this.dtgconten)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Empresa:";
            // 
            // cboempresa
            // 
            this.cboempresa.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboempresa.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboempresa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboempresa.FormattingEnabled = true;
            this.cboempresa.Location = new System.Drawing.Point(68, 20);
            this.cboempresa.Name = "cboempresa";
            this.cboempresa.Size = new System.Drawing.Size(257, 21);
            this.cboempresa.TabIndex = 1;
            this.cboempresa.SelectedIndexChanged += new System.EventHandler(this.cboempresa_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Proyecto:";
            // 
            // cboproyecto
            // 
            this.cboproyecto.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboproyecto.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboproyecto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboproyecto.FormattingEnabled = true;
            this.cboproyecto.Location = new System.Drawing.Point(69, 48);
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
            this.dtgconten.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgconten.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgconten.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dtgconten.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgconten.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
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
            this.dtgconten.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dtgconten.Location = new System.Drawing.Point(12, 74);
            this.dtgconten.MultiSelect = false;
            this.dtgconten.Name = "dtgconten";
            this.dtgconten.ReadOnly = true;
            this.dtgconten.RowHeadersVisible = false;
            this.dtgconten.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgconten.Size = new System.Drawing.Size(926, 480);
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
            this.Cta_Contable.Width = 89;
            // 
            // importe_proy
            // 
            this.importe_proy.DataPropertyName = "importe_proy";
            dataGridViewCellStyle2.Format = "n2";
            this.importe_proy.DefaultCellStyle = dataGridViewCellStyle2;
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
            this.CodCentroC.Width = 71;
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
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.Format = "n2";
            this.importe.DefaultCellStyle = dataGridViewCellStyle3;
            this.importe.HeaderText = "Importe";
            this.importe.Name = "importe";
            this.importe.ReadOnly = true;
            this.importe.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.importe.Width = 48;
            // 
            // Operaciones
            // 
            this.Operaciones.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Operaciones.DataPropertyName = "operaciones";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle4.Format = "n2";
            this.Operaciones.DefaultCellStyle = dataGridViewCellStyle4;
            this.Operaciones.HeaderText = "Operaciones";
            this.Operaciones.Name = "Operaciones";
            this.Operaciones.ReadOnly = true;
            this.Operaciones.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Operaciones.Width = 73;
            // 
            // Diferencia
            // 
            this.Diferencia.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Diferencia.DataPropertyName = "diferencia";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle5.Format = "n2";
            this.Diferencia.DefaultCellStyle = dataGridViewCellStyle5;
            this.Diferencia.HeaderText = "Diferencia";
            this.Diferencia.Name = "Diferencia";
            this.Diferencia.ReadOnly = true;
            this.Diferencia.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Diferencia.Width = 61;
            // 
            // id_etapas
            // 
            this.id_etapas.DataPropertyName = "Id_etapa";
            this.id_etapas.HeaderText = "id_etapas";
            this.id_etapas.Name = "id_etapas";
            this.id_etapas.ReadOnly = true;
            this.id_etapas.Visible = false;
            // 
            // btnGenerar
            // 
            this.btnGenerar.Location = new System.Drawing.Point(439, 48);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(75, 20);
            this.btnGenerar.TabIndex = 18;
            this.btnGenerar.Text = "Generar";
            this.btnGenerar.UseVisualStyleBackColor = true;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // btnexportarexcel
            // 
            this.btnexportarexcel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnexportarexcel.Location = new System.Drawing.Point(864, 20);
            this.btnexportarexcel.Name = "btnexportarexcel";
            this.btnexportarexcel.Size = new System.Drawing.Size(75, 21);
            this.btnexportarexcel.TabIndex = 19;
            this.btnexportarexcel.Text = "Excel";
            this.btnexportarexcel.UseVisualStyleBackColor = true;
            this.btnexportarexcel.Click += new System.EventHandler(this.btnexportarexcel_Click);
            // 
            // lblmsg
            // 
            this.lblmsg.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblmsg.AutoSize = true;
            this.lblmsg.Location = new System.Drawing.Point(9, 564);
            this.lblmsg.Name = "lblmsg";
            this.lblmsg.Size = new System.Drawing.Size(54, 13);
            this.lblmsg.TabIndex = 24;
            this.lblmsg.Text = "Registros:";
            // 
            // txtdiferencia
            // 
            this.txtdiferencia.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtdiferencia.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtdiferencia.Location = new System.Drawing.Point(854, 49);
            this.txtdiferencia.Name = "txtdiferencia";
            this.txtdiferencia.ReadOnly = true;
            this.txtdiferencia.Size = new System.Drawing.Size(84, 20);
            this.txtdiferencia.TabIndex = 25;
            this.txtdiferencia.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtoperaciones
            // 
            this.txtoperaciones.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtoperaciones.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtoperaciones.Location = new System.Drawing.Point(764, 49);
            this.txtoperaciones.Name = "txtoperaciones";
            this.txtoperaciones.ReadOnly = true;
            this.txtoperaciones.Size = new System.Drawing.Size(84, 20);
            this.txtoperaciones.TabIndex = 26;
            this.txtoperaciones.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtimporte
            // 
            this.txtimporte.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtimporte.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtimporte.Location = new System.Drawing.Point(674, 49);
            this.txtimporte.Name = "txtimporte";
            this.txtimporte.ReadOnly = true;
            this.txtimporte.Size = new System.Drawing.Size(84, 20);
            this.txtimporte.TabIndex = 27;
            this.txtimporte.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(623, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 28;
            this.label3.Text = "Totales:";
            // 
            // btncancelar
            // 
            this.btncancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btncancelar.Location = new System.Drawing.Point(863, 559);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(75, 23);
            this.btncancelar.TabIndex = 29;
            this.btncancelar.Text = "Cancelar";
            this.btncancelar.UseVisualStyleBackColor = true;
            this.btncancelar.Click += new System.EventHandler(this.btncancelar_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(744, 20);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(114, 21);
            this.button1.TabIndex = 30;
            this.button1.Text = "Análisis por Periodo";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(331, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 13);
            this.label4.TabIndex = 31;
            this.label4.Text = "Presupuestos:";
            // 
            // cbopresupuestos
            // 
            this.cbopresupuestos.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbopresupuestos.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbopresupuestos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbopresupuestos.FormattingEnabled = true;
            this.cbopresupuestos.Location = new System.Drawing.Point(411, 20);
            this.cbopresupuestos.Name = "cbopresupuestos";
            this.cbopresupuestos.Size = new System.Drawing.Size(242, 21);
            this.cbopresupuestos.TabIndex = 32;
            this.cbopresupuestos.SelectedIndexChanged += new System.EventHandler(this.cbopresupuestos_SelectedIndexChanged);
            // 
            // frmReportePresupuestoOperaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(950, 592);
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
            this.Controls.Add(this.btnGenerar);
            this.Controls.Add(this.cboproyecto);
            this.Controls.Add(this.cboempresa);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtgconten);
            this.MinimumSize = new System.Drawing.Size(966, 631);
            this.Name = "frmReportePresupuestoOperaciones";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reporte Presupuesto-Operaciones";
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
        private System.Windows.Forms.DataGridView dtgconten;
        private System.Windows.Forms.Button btnGenerar;
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
    }
}