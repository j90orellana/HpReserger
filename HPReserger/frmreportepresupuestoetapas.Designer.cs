namespace HPReserger
{
    partial class frmreportepresupuestoetapas
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
            this.dtpfin = new System.Windows.Forms.DateTimePicker();
            this.dtpinicio = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnexportar = new System.Windows.Forms.Button();
            this.dtgconten = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.txtcc = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtcentro = new System.Windows.Forms.TextBox();
            this.txtetapa = new System.Windows.Forms.TextBox();
            this.lbl1 = new System.Windows.Forms.Label();
            this.dtgvalores = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dtgoperaciones = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.dtgdiferencia = new System.Windows.Forms.DataGridView();
            this.dtgvalores1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dtgconten)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvalores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgoperaciones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgdiferencia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvalores1)).BeginInit();
            this.SuspendLayout();
            // 
            // dtpfin
            // 
            this.dtpfin.Enabled = false;
            this.dtpfin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpfin.Location = new System.Drawing.Point(467, 38);
            this.dtpfin.Name = "dtpfin";
            this.dtpfin.Size = new System.Drawing.Size(104, 20);
            this.dtpfin.TabIndex = 35;
            // 
            // dtpinicio
            // 
            this.dtpinicio.Enabled = false;
            this.dtpinicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpinicio.Location = new System.Drawing.Point(467, 12);
            this.dtpinicio.Name = "dtpinicio";
            this.dtpinicio.Size = new System.Drawing.Size(104, 20);
            this.dtpinicio.TabIndex = 34;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(395, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 33;
            this.label4.Text = "Fin Etapa:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(395, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 32;
            this.label3.Text = "Inicio Etapa:";
            // 
            // btnexportar
            // 
            this.btnexportar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnexportar.Location = new System.Drawing.Point(1107, 60);
            this.btnexportar.Name = "btnexportar";
            this.btnexportar.Size = new System.Drawing.Size(74, 26);
            this.btnexportar.TabIndex = 31;
            this.btnexportar.Text = "Excel";
            this.btnexportar.UseVisualStyleBackColor = true;
            this.btnexportar.Click += new System.EventHandler(this.btnguardar_Click);
            // 
            // dtgconten
            // 
            this.dtgconten.AllowUserToAddRows = false;
            this.dtgconten.AllowUserToDeleteRows = false;
            this.dtgconten.AllowUserToResizeColumns = false;
            this.dtgconten.AllowUserToResizeRows = false;
            this.dtgconten.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgconten.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgconten.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dtgconten.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgconten.CausesValidation = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgconten.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgconten.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgconten.DefaultCellStyle = dataGridViewCellStyle2;
            this.dtgconten.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dtgconten.Location = new System.Drawing.Point(91, 92);
            this.dtgconten.MultiSelect = false;
            this.dtgconten.Name = "dtgconten";
            this.dtgconten.ReadOnly = true;
            this.dtgconten.RowHeadersVisible = false;
            this.dtgconten.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgconten.Size = new System.Drawing.Size(1090, 47);
            this.dtgconten.TabIndex = 30;
            this.dtgconten.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 29;
            this.label2.Text = "Centro Costo:";
            // 
            // txtcc
            // 
            this.txtcc.Enabled = false;
            this.txtcc.Location = new System.Drawing.Point(91, 64);
            this.txtcc.Name = "txtcc";
            this.txtcc.Size = new System.Drawing.Size(282, 20);
            this.txtcc.TabIndex = 28;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 27;
            this.label1.Text = "Centro Costo:";
            // 
            // txtcentro
            // 
            this.txtcentro.Enabled = false;
            this.txtcentro.Location = new System.Drawing.Point(91, 38);
            this.txtcentro.Name = "txtcentro";
            this.txtcentro.Size = new System.Drawing.Size(282, 20);
            this.txtcentro.TabIndex = 26;
            // 
            // txtetapa
            // 
            this.txtetapa.Enabled = false;
            this.txtetapa.Location = new System.Drawing.Point(91, 12);
            this.txtetapa.Name = "txtetapa";
            this.txtetapa.Size = new System.Drawing.Size(282, 20);
            this.txtetapa.TabIndex = 25;
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(14, 15);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(38, 13);
            this.lbl1.TabIndex = 24;
            this.lbl1.Text = "Etapa:";
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
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvalores.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dtgvalores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvalores.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dtgvalores.Location = new System.Drawing.Point(591, 12);
            this.dtgvalores.MultiSelect = false;
            this.dtgvalores.Name = "dtgvalores";
            this.dtgvalores.RowHeadersVisible = false;
            this.dtgvalores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dtgvalores.Size = new System.Drawing.Size(510, 74);
            this.dtgvalores.TabIndex = 36;
            this.dtgvalores.TabStop = false;
            this.dtgvalores.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 116);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 13);
            this.label5.TabIndex = 37;
            this.label5.Text = "Presupuesto:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 147);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 13);
            this.label6.TabIndex = 39;
            this.label6.Text = "Operaciones:";
            // 
            // dtgoperaciones
            // 
            this.dtgoperaciones.AllowUserToAddRows = false;
            this.dtgoperaciones.AllowUserToDeleteRows = false;
            this.dtgoperaciones.AllowUserToResizeColumns = false;
            this.dtgoperaciones.AllowUserToResizeRows = false;
            this.dtgoperaciones.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgoperaciones.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgoperaciones.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dtgoperaciones.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgoperaciones.CausesValidation = false;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgoperaciones.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dtgoperaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgoperaciones.ColumnHeadersVisible = false;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgoperaciones.DefaultCellStyle = dataGridViewCellStyle5;
            this.dtgoperaciones.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dtgoperaciones.Location = new System.Drawing.Point(91, 136);
            this.dtgoperaciones.MultiSelect = false;
            this.dtgoperaciones.Name = "dtgoperaciones";
            this.dtgoperaciones.ReadOnly = true;
            this.dtgoperaciones.RowHeadersVisible = false;
            this.dtgoperaciones.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgoperaciones.Size = new System.Drawing.Size(1090, 37);
            this.dtgoperaciones.TabIndex = 38;
            this.dtgoperaciones.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(14, 172);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 13);
            this.label7.TabIndex = 41;
            this.label7.Text = "Diferencia:";
            // 
            // dtgdiferencia
            // 
            this.dtgdiferencia.AllowUserToAddRows = false;
            this.dtgdiferencia.AllowUserToDeleteRows = false;
            this.dtgdiferencia.AllowUserToResizeColumns = false;
            this.dtgdiferencia.AllowUserToResizeRows = false;
            this.dtgdiferencia.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgdiferencia.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgdiferencia.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dtgdiferencia.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgdiferencia.CausesValidation = false;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgdiferencia.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dtgdiferencia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgdiferencia.ColumnHeadersVisible = false;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgdiferencia.DefaultCellStyle = dataGridViewCellStyle7;
            this.dtgdiferencia.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dtgdiferencia.Location = new System.Drawing.Point(91, 160);
            this.dtgdiferencia.MultiSelect = false;
            this.dtgdiferencia.Name = "dtgdiferencia";
            this.dtgdiferencia.ReadOnly = true;
            this.dtgdiferencia.RowHeadersVisible = false;
            this.dtgdiferencia.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgdiferencia.Size = new System.Drawing.Size(1090, 25);
            this.dtgdiferencia.TabIndex = 40;
            this.dtgdiferencia.TabStop = false;
            // 
            // dtgvalores1
            // 
            this.dtgvalores1.AllowUserToAddRows = false;
            this.dtgvalores1.AllowUserToDeleteRows = false;
            this.dtgvalores1.AllowUserToResizeColumns = false;
            this.dtgvalores1.AllowUserToResizeRows = false;
            this.dtgvalores1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgvalores1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dtgvalores1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dtgvalores1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dtgvalores1.CausesValidation = false;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvalores1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dtgvalores1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvalores1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dtgvalores1.Location = new System.Drawing.Point(591, 6);
            this.dtgvalores1.MultiSelect = false;
            this.dtgvalores1.Name = "dtgvalores1";
            this.dtgvalores1.RowHeadersVisible = false;
            this.dtgvalores1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dtgvalores1.Size = new System.Drawing.Size(510, 74);
            this.dtgvalores1.TabIndex = 42;
            this.dtgvalores1.TabStop = false;
            this.dtgvalores1.Visible = false;
            // 
            // frmreportepresupuestoetapas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1193, 198);
            this.Controls.Add(this.dtgvalores1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dtgdiferencia);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dtgoperaciones);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dtgvalores);
            this.Controls.Add(this.dtpfin);
            this.Controls.Add(this.dtpinicio);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnexportar);
            this.Controls.Add(this.dtgconten);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtcc);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtcentro);
            this.Controls.Add(this.txtetapa);
            this.Controls.Add(this.lbl1);
            this.Name = "frmreportepresupuestoetapas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reporte Presupuesto Etapas";
            this.Load += new System.EventHandler(this.frmreportepresupuestoetapas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgconten)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvalores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgoperaciones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgdiferencia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvalores1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpfin;
        private System.Windows.Forms.DateTimePicker dtpinicio;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnexportar;
        private System.Windows.Forms.DataGridView dtgconten;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox txtcc;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox txtcentro;
        public System.Windows.Forms.TextBox txtetapa;
        public System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.DataGridView dtgvalores;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dtgoperaciones;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dtgdiferencia;
        private System.Windows.Forms.DataGridView dtgvalores1;
    }
}