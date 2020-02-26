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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPresupuestodetalle));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.cboproyecto = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btneditar = new System.Windows.Forms.Button();
            this.btncancelar = new System.Windows.Forms.Button();
            this.dtgconten = new HpResergerUserControls.Dtgconten();
            this.btnmas = new System.Windows.Forms.DataGridViewButtonColumn();
            this.CodCentroC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iddep = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.conta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripción = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cta_Contable = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.etapa_Des = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.importe_proy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Importe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xtotalflujo = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.txtflujos = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgconten)).BeginInit();
            this.SuspendLayout();
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
            this.cboproyecto.Location = new System.Drawing.Point(71, 17);
            this.cboproyecto.Name = "cboproyecto";
            this.cboproyecto.Size = new System.Drawing.Size(308, 21);
            this.cboproyecto.TabIndex = 1;
            this.cboproyecto.SelectedIndexChanged += new System.EventHandler(this.cboproyecto_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(15, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Proyecto:";
            // 
            // btneditar
            // 
            this.btneditar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btneditar.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btneditar.Image = ((System.Drawing.Image)(resources.GetObject("btneditar.Image")));
            this.btneditar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btneditar.Location = new System.Drawing.Point(650, 40);
            this.btneditar.Name = "btneditar";
            this.btneditar.Size = new System.Drawing.Size(100, 24);
            this.btneditar.TabIndex = 14;
            this.btneditar.Text = "Modificar";
            this.btneditar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btneditar.UseVisualStyleBackColor = true;
            this.btneditar.Click += new System.EventHandler(this.btneditar_Click);
            // 
            // btncancelar
            // 
            this.btncancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btncancelar.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncancelar.Image = ((System.Drawing.Image)(resources.GetObject("btncancelar.Image")));
            this.btncancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btncancelar.Location = new System.Drawing.Point(650, 655);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(100, 24);
            this.btncancelar.TabIndex = 15;
            this.btncancelar.Text = "Cancelar";
            this.btncancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btncancelar.UseVisualStyleBackColor = true;
            this.btncancelar.Click += new System.EventHandler(this.btncancelar_Click);
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
            this.btnmas,
            this.CodCentroC,
            this.iddep,
            this.conta,
            this.Descripción,
            this.Cta_Contable,
            this.etapa_Des,
            this.importe_proy,
            this.Importe,
            this.xtotalflujo,
            this.fk_id_proyecto,
            this.id_etapas});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(207)))), ((int)(((byte)(241)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgconten.DefaultCellStyle = dataGridViewCellStyle6;
            this.dtgconten.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dtgconten.EnableHeadersVisualStyles = false;
            this.dtgconten.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(179)))), ((int)(((byte)(215)))));
            this.dtgconten.Location = new System.Drawing.Point(15, 71);
            this.dtgconten.MultiSelect = false;
            this.dtgconten.Name = "dtgconten";
            this.dtgconten.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dtgconten.RowHeadersVisible = false;
            this.dtgconten.RowTemplate.Height = 16;
            this.dtgconten.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgconten.Size = new System.Drawing.Size(735, 578);
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
            this.btnmas.MinimumWidth = 20;
            this.btnmas.Name = "btnmas";
            this.btnmas.Text = "+";
            this.btnmas.UseColumnTextForButtonValue = true;
            this.btnmas.Width = 20;
            // 
            // CodCentroC
            // 
            this.CodCentroC.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.CodCentroC.DataPropertyName = "Cod_ccosto";
            this.CodCentroC.HeaderText = "CentroCosto";
            this.CodCentroC.Name = "CodCentroC";
            this.CodCentroC.ReadOnly = true;
            this.CodCentroC.Width = 96;
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
            dataGridViewCellStyle3.Format = "n2";
            this.importe_proy.DefaultCellStyle = dataGridViewCellStyle3;
            this.importe_proy.HeaderText = "Importe_proy";
            this.importe_proy.Name = "importe_proy";
            this.importe_proy.ReadOnly = true;
            this.importe_proy.Visible = false;
            // 
            // Importe
            // 
            this.Importe.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Importe.DataPropertyName = "Importe_CeCo";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle4.Format = "n2";
            this.Importe.DefaultCellStyle = dataGridViewCellStyle4;
            this.Importe.HeaderText = "Importe";
            this.Importe.Name = "Importe";
            this.Importe.ReadOnly = true;
            this.Importe.Width = 71;
            // 
            // xtotalflujo
            // 
            this.xtotalflujo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.xtotalflujo.DataPropertyName = "totalflujo";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle5.Format = "n2";
            this.xtotalflujo.DefaultCellStyle = dataGridViewCellStyle5;
            this.xtotalflujo.HeaderText = "Flujo";
            this.xtotalflujo.Name = "xtotalflujo";
            this.xtotalflujo.ReadOnly = true;
            this.xtotalflujo.Width = 57;
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
            this.btnaceptar.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnaceptar.Image = ((System.Drawing.Image)(resources.GetObject("btnaceptar.Image")));
            this.btnaceptar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnaceptar.Location = new System.Drawing.Point(546, 655);
            this.btnaceptar.Name = "btnaceptar";
            this.btnaceptar.Size = new System.Drawing.Size(100, 24);
            this.btnaceptar.TabIndex = 17;
            this.btnaceptar.Text = "Aceptar";
            this.btnaceptar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnaceptar.UseVisualStyleBackColor = true;
            this.btnaceptar.Click += new System.EventHandler(this.btnaceptar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(15, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Estructura Centro de Costo:";
            // 
            // txtimporte
            // 
            this.txtimporte.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtimporte.Location = new System.Drawing.Point(650, 16);
            this.txtimporte.Name = "txtimporte";
            this.txtimporte.Size = new System.Drawing.Size(100, 22);
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
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(599, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "Importe:";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(324, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 21;
            this.label4.Text = "Total:";
            // 
            // txttotal
            // 
            this.txttotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txttotal.Enabled = false;
            this.txttotal.Location = new System.Drawing.Point(356, 41);
            this.txttotal.Name = "txttotal";
            this.txttotal.Size = new System.Drawing.Size(100, 22);
            this.txttotal.TabIndex = 22;
            this.txttotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblmsg
            // 
            this.lblmsg.AutoSize = true;
            this.lblmsg.BackColor = System.Drawing.Color.Transparent;
            this.lblmsg.Location = new System.Drawing.Point(15, 652);
            this.lblmsg.Name = "lblmsg";
            this.lblmsg.Size = new System.Drawing.Size(0, 13);
            this.lblmsg.TabIndex = 23;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(385, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 13);
            this.label5.TabIndex = 24;
            this.label5.Text = "Presupuesto Maximo";
            // 
            // txtmontomax
            // 
            this.txtmontomax.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtmontomax.Location = new System.Drawing.Point(497, 16);
            this.txtmontomax.Name = "txtmontomax";
            this.txtmontomax.Size = new System.Drawing.Size(100, 22);
            this.txtmontomax.TabIndex = 25;
            this.txtmontomax.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtflujos
            // 
            this.txtflujos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtflujos.Enabled = false;
            this.txtflujos.Location = new System.Drawing.Point(497, 41);
            this.txtflujos.Name = "txtflujos";
            this.txtflujos.Size = new System.Drawing.Size(100, 22);
            this.txtflujos.TabIndex = 20;
            this.txtflujos.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtflujos.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtimporte_KeyDown);
            this.txtflujos.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtimporte_KeyPress);
            this.txtflujos.Validated += new System.EventHandler(this.txtimporte_Validated);
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(456, 46);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 13);
            this.label6.TabIndex = 26;
            this.label6.Text = "Flujos:";
            // 
            // frmPresupuestodetalle
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(760, 684);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboproyecto);
            this.Controls.Add(this.txtmontomax);
            this.Controls.Add(this.dtgconten);
            this.Controls.Add(this.lblmsg);
            this.Controls.Add(this.txttotal);
            this.Controls.Add(this.txtflujos);
            this.Controls.Add(this.txtimporte);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnaceptar);
            this.Controls.Add(this.btncancelar);
            this.Controls.Add(this.btneditar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinimumSize = new System.Drawing.Size(776, 723);
            this.Name = "frmPresupuestodetalle";
            this.Nombre = "Detalle del Presupuesto";
            this.Text = "Detalle del Presupuesto";
            this.Load += new System.EventHandler(this.frmPresupuestodetalle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgconten)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cboproyecto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btneditar;
        private System.Windows.Forms.Button btncancelar;
        private HpResergerUserControls.Dtgconten dtgconten;
        private System.Windows.Forms.Button btnaceptar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtimporte;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txttotal;
        private System.Windows.Forms.Label lblmsg;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtmontomax;
        private System.Windows.Forms.TextBox txtflujos;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridViewButtonColumn btnmas;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodCentroC;
        private System.Windows.Forms.DataGridViewTextBoxColumn iddep;
        private System.Windows.Forms.DataGridViewTextBoxColumn conta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripción;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cta_Contable;
        private System.Windows.Forms.DataGridViewTextBoxColumn etapa_Des;
        private System.Windows.Forms.DataGridViewTextBoxColumn importe_proy;
        private System.Windows.Forms.DataGridViewTextBoxColumn Importe;
        private System.Windows.Forms.DataGridViewTextBoxColumn xtotalflujo;
        private System.Windows.Forms.DataGridViewTextBoxColumn fk_id_proyecto;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_etapas;
    }
}