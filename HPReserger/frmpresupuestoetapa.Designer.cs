namespace HPReserger
{
    partial class frmpresupuestoetapa
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
            this.lbl1 = new System.Windows.Forms.Label();
            this.txtetapa = new System.Windows.Forms.TextBox();
            this.txtcentro = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtcc = new System.Windows.Forms.TextBox();
            this.dtgconten = new System.Windows.Forms.DataGridView();
            this.btnguardar = new System.Windows.Forms.Button();
            this.dtgvalores = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpinicio = new System.Windows.Forms.DateTimePicker();
            this.dtpfin = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dtgconten1 = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtpagos = new System.Windows.Forms.TextBox();
            this.txtflujo = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtdiferencia = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtgconten)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvalores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgconten1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(18, 15);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(38, 13);
            this.lbl1.TabIndex = 0;
            this.lbl1.Text = "Etapa:";
            // 
            // txtetapa
            // 
            this.txtetapa.Enabled = false;
            this.txtetapa.Location = new System.Drawing.Point(95, 12);
            this.txtetapa.Name = "txtetapa";
            this.txtetapa.Size = new System.Drawing.Size(282, 20);
            this.txtetapa.TabIndex = 1;
            // 
            // txtcentro
            // 
            this.txtcentro.Enabled = false;
            this.txtcentro.Location = new System.Drawing.Point(95, 38);
            this.txtcentro.Name = "txtcentro";
            this.txtcentro.Size = new System.Drawing.Size(282, 20);
            this.txtcentro.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Centro Costo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Centro Costo:";
            // 
            // txtcc
            // 
            this.txtcc.Enabled = false;
            this.txtcc.Location = new System.Drawing.Point(95, 64);
            this.txtcc.Name = "txtcc";
            this.txtcc.Size = new System.Drawing.Size(282, 20);
            this.txtcc.TabIndex = 4;
            // 
            // dtgconten
            // 
            this.dtgconten.AllowUserToAddRows = false;
            this.dtgconten.AllowUserToDeleteRows = false;
            this.dtgconten.AllowUserToResizeColumns = false;
            this.dtgconten.AllowUserToResizeRows = false;
            this.dtgconten.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgconten.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dtgconten.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dtgconten.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dtgconten.CausesValidation = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgconten.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgconten.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgconten.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dtgconten.Location = new System.Drawing.Point(12, 107);
            this.dtgconten.MultiSelect = false;
            this.dtgconten.Name = "dtgconten";
            this.dtgconten.RowHeadersVisible = false;
            this.dtgconten.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dtgconten.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dtgconten.Size = new System.Drawing.Size(801, 52);
            this.dtgconten.TabIndex = 17;
            this.dtgconten.TabStop = false;
            this.dtgconten.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgconten_CellClick);
            this.dtgconten.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgconten_CellEndEdit);
            this.dtgconten.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dtgconten_DataError);
            this.dtgconten.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dtgconten_EditingControlShowing);
            this.dtgconten.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dtgconten_KeyPress);
            // 
            // btnguardar
            // 
            this.btnguardar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnguardar.Location = new System.Drawing.Point(739, 75);
            this.btnguardar.Name = "btnguardar";
            this.btnguardar.Size = new System.Drawing.Size(74, 26);
            this.btnguardar.TabIndex = 18;
            this.btnguardar.Text = "Guardar";
            this.btnguardar.UseVisualStyleBackColor = true;
            this.btnguardar.Click += new System.EventHandler(this.btnguardar_Click);
            // 
            // dtgvalores
            // 
            this.dtgvalores.AllowUserToAddRows = false;
            this.dtgvalores.AllowUserToDeleteRows = false;
            this.dtgvalores.AllowUserToResizeColumns = false;
            this.dtgvalores.AllowUserToResizeRows = false;
            this.dtgvalores.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgvalores.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dtgvalores.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dtgvalores.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dtgvalores.CausesValidation = false;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvalores.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dtgvalores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvalores.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dtgvalores.Location = new System.Drawing.Point(12, 315);
            this.dtgvalores.MultiSelect = false;
            this.dtgvalores.Name = "dtgvalores";
            this.dtgvalores.RowHeadersVisible = false;
            this.dtgvalores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dtgvalores.Size = new System.Drawing.Size(363, 109);
            this.dtgvalores.TabIndex = 19;
            this.dtgvalores.TabStop = false;
            this.dtgvalores.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(399, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "Inicio Etapa:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(399, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 21;
            this.label4.Text = "Fin Etapa:";
            // 
            // dtpinicio
            // 
            this.dtpinicio.Enabled = false;
            this.dtpinicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpinicio.Location = new System.Drawing.Point(471, 12);
            this.dtpinicio.Name = "dtpinicio";
            this.dtpinicio.Size = new System.Drawing.Size(86, 20);
            this.dtpinicio.TabIndex = 22;
            // 
            // dtpfin
            // 
            this.dtpfin.Enabled = false;
            this.dtpfin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpfin.Location = new System.Drawing.Point(471, 38);
            this.dtpfin.Name = "dtpfin";
            this.dtpfin.Size = new System.Drawing.Size(86, 20);
            this.dtpfin.TabIndex = 23;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 91);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 24;
            this.label5.Text = "Gastos:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 162);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 25;
            this.label6.Text = "Flujos:";
            // 
            // dtgconten1
            // 
            this.dtgconten1.AllowUserToAddRows = false;
            this.dtgconten1.AllowUserToDeleteRows = false;
            this.dtgconten1.AllowUserToResizeColumns = false;
            this.dtgconten1.AllowUserToResizeRows = false;
            this.dtgconten1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgconten1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dtgconten1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dtgconten1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dtgconten1.CausesValidation = false;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgconten1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dtgconten1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgconten1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dtgconten1.Location = new System.Drawing.Point(11, 176);
            this.dtgconten1.MultiSelect = false;
            this.dtgconten1.Name = "dtgconten1";
            this.dtgconten1.RowHeadersVisible = false;
            this.dtgconten1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dtgconten1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dtgconten1.Size = new System.Drawing.Size(801, 52);
            this.dtgconten1.TabIndex = 26;
            this.dtgconten1.TabStop = false;
            this.dtgconten1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgconten1_CellClick);
            this.dtgconten1.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgconten1_CellEndEdit);
            this.dtgconten1.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dtgconten1_EditingControlShowing);
            this.dtgconten1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dtgconten1_KeyPress);
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(566, 15);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 13);
            this.label7.TabIndex = 27;
            this.label7.Text = "Total Gastos:";
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(570, 41);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 13);
            this.label8.TabIndex = 28;
            this.label8.Text = "Total Flujo:";
            // 
            // txtpagos
            // 
            this.txtpagos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtpagos.Location = new System.Drawing.Point(635, 12);
            this.txtpagos.Name = "txtpagos";
            this.txtpagos.ReadOnly = true;
            this.txtpagos.Size = new System.Drawing.Size(89, 20);
            this.txtpagos.TabIndex = 29;
            this.txtpagos.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtflujo
            // 
            this.txtflujo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtflujo.Location = new System.Drawing.Point(635, 38);
            this.txtflujo.Name = "txtflujo";
            this.txtflujo.ReadOnly = true;
            this.txtflujo.Size = new System.Drawing.Size(89, 20);
            this.txtflujo.TabIndex = 30;
            this.txtflujo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(570, 67);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(58, 13);
            this.label9.TabIndex = 28;
            this.label9.Text = "Diferencia:";
            // 
            // txtdiferencia
            // 
            this.txtdiferencia.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtdiferencia.Location = new System.Drawing.Point(635, 64);
            this.txtdiferencia.Name = "txtdiferencia";
            this.txtdiferencia.ReadOnly = true;
            this.txtdiferencia.Size = new System.Drawing.Size(89, 20);
            this.txtdiferencia.TabIndex = 30;
            this.txtdiferencia.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // frmpresupuestoetapa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(823, 236);
            this.Controls.Add(this.txtdiferencia);
            this.Controls.Add(this.txtflujo);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtpagos);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dtgconten1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dtpfin);
            this.Controls.Add(this.dtpinicio);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtgvalores);
            this.Controls.Add(this.btnguardar);
            this.Controls.Add(this.dtgconten);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtcc);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtcentro);
            this.Controls.Add(this.txtetapa);
            this.Controls.Add(this.lbl1);
            this.MinimumSize = new System.Drawing.Size(839, 275);
            this.Name = "frmpresupuestoetapa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Presupuesto Etapa";
            this.Load += new System.EventHandler(this.frmpresupuestoetapa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgconten)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvalores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgconten1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label lbl1;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dtgconten;
        public System.Windows.Forms.TextBox txtetapa;
        public System.Windows.Forms.TextBox txtcentro;
        public System.Windows.Forms.TextBox txtcc;
        private System.Windows.Forms.Button btnguardar;
        private System.Windows.Forms.DataGridView dtgvalores;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpinicio;
        private System.Windows.Forms.DateTimePicker dtpfin;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dtgconten1;
        public System.Windows.Forms.Label label7;
        public System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtpagos;
        private System.Windows.Forms.TextBox txtflujo;
        public System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtdiferencia;
    }
}