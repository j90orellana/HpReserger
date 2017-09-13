namespace HPReserger
{
    partial class frmPresupuestodetalle
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
            this.gp1 = new System.Windows.Forms.GroupBox();
            this.cboproyecto = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btneditar = new System.Windows.Forms.Button();
            this.btncancelar = new System.Windows.Forms.Button();
            this.dtgconten = new System.Windows.Forms.DataGridView();
            this.btnmas = new System.Windows.Forms.DataGridViewButtonColumn();
            this.CodCentroC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iddep = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.conta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripción = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cta_Contable = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.etapa_Des = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.importe_proy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Importe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fk_id_proyecto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_etapas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnaceptar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtimporte = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txttotal = new System.Windows.Forms.TextBox();
            this.lblmsg = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtmontomax = new System.Windows.Forms.TextBox();
            this.gp1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgconten)).BeginInit();
            this.SuspendLayout();
            // 
            // gp1
            // 
            this.gp1.Controls.Add(this.cboproyecto);
            this.gp1.Controls.Add(this.label1);
            this.gp1.Location = new System.Drawing.Point(12, 12);
            this.gp1.Name = "gp1";
            this.gp1.Size = new System.Drawing.Size(384, 53);
            this.gp1.TabIndex = 0;
            this.gp1.TabStop = false;
            // 
            // cboproyecto
            // 
            this.cboproyecto.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboproyecto.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboproyecto.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboproyecto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboproyecto.FormattingEnabled = true;
            this.cboproyecto.Location = new System.Drawing.Point(64, 19);
            this.cboproyecto.Name = "cboproyecto";
            this.cboproyecto.Size = new System.Drawing.Size(298, 21);
            this.cboproyecto.TabIndex = 1;
            this.cboproyecto.SelectedIndexChanged += new System.EventHandler(this.cboproyecto_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Proyecto:";
            // 
            // btneditar
            // 
            this.btneditar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btneditar.Location = new System.Drawing.Point(672, 27);
            this.btneditar.Name = "btneditar";
            this.btneditar.Size = new System.Drawing.Size(75, 23);
            this.btneditar.TabIndex = 14;
            this.btneditar.Text = "Modificar";
            this.btneditar.UseVisualStyleBackColor = true;
            this.btneditar.Click += new System.EventHandler(this.btneditar_Click);
            // 
            // btncancelar
            // 
            this.btncancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btncancelar.Location = new System.Drawing.Point(672, 646);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(75, 23);
            this.btncancelar.TabIndex = 15;
            this.btncancelar.Text = "Cancelar";
            this.btncancelar.UseVisualStyleBackColor = true;
            this.btncancelar.Click += new System.EventHandler(this.btncancelar_Click);
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
            this.dtgconten.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgconten.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.btnmas,
            this.CodCentroC,
            this.iddep,
            this.conta,
            this.Descripción,
            this.Cta_Contable,
            this.etapa_Des,
            this.importe_proy,
            this.Importe,
            this.fk_id_proyecto,
            this.id_etapas});
            this.dtgconten.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dtgconten.Enabled = false;
            this.dtgconten.Location = new System.Drawing.Point(12, 84);
            this.dtgconten.MultiSelect = false;
            this.dtgconten.Name = "dtgconten";
            this.dtgconten.RowHeadersVisible = false;
            this.dtgconten.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgconten.Size = new System.Drawing.Size(735, 556);
            this.dtgconten.TabIndex = 16;
            this.dtgconten.TabStop = false;
            this.dtgconten.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgconten_CellClick);
            this.dtgconten.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgconten_CellDoubleClick);
            this.dtgconten.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgconten_CellEndEdit);
            this.dtgconten.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.Dtgconten_EditingControlShowing);
            this.dtgconten.DoubleClick += new System.EventHandler(this.dtgconten_DoubleClick);
            // 
            // btnmas
            // 
            this.btnmas.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.btnmas.HeaderText = "";
            this.btnmas.Name = "btnmas";
            this.btnmas.Text = "+";
            this.btnmas.UseColumnTextForButtonValue = true;
            this.btnmas.Width = 5;
            // 
            // CodCentroC
            // 
            this.CodCentroC.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.CodCentroC.DataPropertyName = "Cod_ccosto";
            this.CodCentroC.HeaderText = "CentroCosto";
            this.CodCentroC.Name = "CodCentroC";
            this.CodCentroC.ReadOnly = true;
            this.CodCentroC.Width = 90;
            // 
            // iddep
            // 
            this.iddep.DataPropertyName = "iddep";
            this.iddep.HeaderText = "idedep";
            this.iddep.Name = "iddep";
            this.iddep.Visible = false;
            // 
            // conta
            // 
            this.conta.DataPropertyName = "contador";
            this.conta.HeaderText = "conta";
            this.conta.Name = "conta";
            this.conta.Visible = false;
            // 
            // Descripción
            // 
            this.Descripción.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Descripción.DataPropertyName = "centrocosto";
            this.Descripción.HeaderText = "Descripción";
            this.Descripción.Name = "Descripción";
            this.Descripción.ReadOnly = true;
            // 
            // Cta_Contable
            // 
            this.Cta_Contable.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Cta_Contable.DataPropertyName = "id_ctactble";
            this.Cta_Contable.HeaderText = "Cta_Contable";
            this.Cta_Contable.Name = "Cta_Contable";
            this.Cta_Contable.ReadOnly = true;
            this.Cta_Contable.Width = 96;
            // 
            // etapa_Des
            // 
            this.etapa_Des.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.etapa_Des.DataPropertyName = "descripcion";
            this.etapa_Des.HeaderText = "Etapas";
            this.etapa_Des.Name = "etapa_Des";
            this.etapa_Des.ReadOnly = true;
            this.etapa_Des.Width = 65;
            // 
            // importe_proy
            // 
            this.importe_proy.DataPropertyName = "Importe_Proy";
            dataGridViewCellStyle2.Format = "n2";
            this.importe_proy.DefaultCellStyle = dataGridViewCellStyle2;
            this.importe_proy.HeaderText = "Importe_proy";
            this.importe_proy.Name = "importe_proy";
            this.importe_proy.ReadOnly = true;
            this.importe_proy.Visible = false;
            // 
            // Importe
            // 
            this.Importe.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Importe.DataPropertyName = "Importe_CeCo";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.Format = "n2";
            this.Importe.DefaultCellStyle = dataGridViewCellStyle3;
            this.Importe.HeaderText = "Importe";
            this.Importe.Name = "Importe";
            this.Importe.ReadOnly = true;
            this.Importe.Width = 67;
            // 
            // fk_id_proyecto
            // 
            this.fk_id_proyecto.DataPropertyName = "fk_id_proyecto";
            this.fk_id_proyecto.HeaderText = "fk_id_proyecto";
            this.fk_id_proyecto.Name = "fk_id_proyecto";
            this.fk_id_proyecto.Visible = false;
            // 
            // id_etapas
            // 
            this.id_etapas.DataPropertyName = "id_etapa";
            this.id_etapas.HeaderText = "id_etapas";
            this.id_etapas.Name = "id_etapas";
            this.id_etapas.Visible = false;
            // 
            // btnaceptar
            // 
            this.btnaceptar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnaceptar.Enabled = false;
            this.btnaceptar.Location = new System.Drawing.Point(591, 646);
            this.btnaceptar.Name = "btnaceptar";
            this.btnaceptar.Size = new System.Drawing.Size(75, 23);
            this.btnaceptar.TabIndex = 17;
            this.btnaceptar.Text = "Aceptar";
            this.btnaceptar.UseVisualStyleBackColor = true;
            this.btnaceptar.Click += new System.EventHandler(this.btnaceptar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Estructura Centro de Costo:";
            // 
            // txtimporte
            // 
            this.txtimporte.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtimporte.Location = new System.Drawing.Point(512, 56);
            this.txtimporte.Name = "txtimporte";
            this.txtimporte.Size = new System.Drawing.Size(100, 20);
            this.txtimporte.TabIndex = 20;
            this.txtimporte.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtimporte.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtimporte_KeyDown);
            this.txtimporte.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtimporte_KeyPress);
            this.txtimporte.Validated += new System.EventHandler(this.txtimporte_Validated);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(461, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "Importe:";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(618, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 21;
            this.label4.Text = "Total:";
            // 
            // txttotal
            // 
            this.txttotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txttotal.Enabled = false;
            this.txttotal.Location = new System.Drawing.Point(658, 56);
            this.txttotal.Name = "txttotal";
            this.txttotal.Size = new System.Drawing.Size(89, 20);
            this.txttotal.TabIndex = 22;
            this.txttotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblmsg
            // 
            this.lblmsg.AutoSize = true;
            this.lblmsg.Location = new System.Drawing.Point(12, 666);
            this.lblmsg.Name = "lblmsg";
            this.lblmsg.Size = new System.Drawing.Size(0, 13);
            this.lblmsg.TabIndex = 23;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(401, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 13);
            this.label5.TabIndex = 24;
            this.label5.Text = "Presupuesto Maximo";
            // 
            // txtmontomax
            // 
            this.txtmontomax.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtmontomax.Location = new System.Drawing.Point(512, 30);
            this.txtmontomax.Name = "txtmontomax";
            this.txtmontomax.Size = new System.Drawing.Size(100, 20);
            this.txtmontomax.TabIndex = 25;
            this.txtmontomax.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // frmPresupuestodetalle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(760, 684);
            this.Controls.Add(this.txtmontomax);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dtgconten);
            this.Controls.Add(this.lblmsg);
            this.Controls.Add(this.txttotal);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtimporte);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnaceptar);
            this.Controls.Add(this.btncancelar);
            this.Controls.Add(this.gp1);
            this.Controls.Add(this.btneditar);
            this.MinimumSize = new System.Drawing.Size(776, 723);
            this.Name = "frmPresupuestodetalle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Detalle del Presupuesto";
            this.Load += new System.EventHandler(this.frmPresupuestodetalle_Load);
            this.gp1.ResumeLayout(false);
            this.gp1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgconten)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gp1;
        private System.Windows.Forms.ComboBox cboproyecto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btneditar;
        private System.Windows.Forms.Button btncancelar;
        private System.Windows.Forms.DataGridView dtgconten;
        private System.Windows.Forms.Button btnaceptar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtimporte;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txttotal;
        private System.Windows.Forms.Label lblmsg;
        private System.Windows.Forms.DataGridViewButtonColumn btnmas;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodCentroC;
        private System.Windows.Forms.DataGridViewTextBoxColumn iddep;
        private System.Windows.Forms.DataGridViewTextBoxColumn conta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripción;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cta_Contable;
        private System.Windows.Forms.DataGridViewTextBoxColumn etapa_Des;
        private System.Windows.Forms.DataGridViewTextBoxColumn importe_proy;
        private System.Windows.Forms.DataGridViewTextBoxColumn Importe;
        private System.Windows.Forms.DataGridViewTextBoxColumn fk_id_proyecto;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_etapas;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtmontomax;
    }
}