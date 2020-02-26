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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmreportepresupuestoetapas));
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
            this.dtgconten = new HpResergerUserControls.Dtgconten();
            this.label2 = new System.Windows.Forms.Label();
            this.txtcc = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtcentro = new System.Windows.Forms.TextBox();
            this.txtetapa = new System.Windows.Forms.TextBox();
            this.lbl1 = new System.Windows.Forms.Label();
            this.dtgvalores = new HpResergerUserControls.Dtgconten();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dtgoperaciones = new HpResergerUserControls.Dtgconten();
            this.label7 = new System.Windows.Forms.Label();
            this.dtgdiferencia = new HpResergerUserControls.Dtgconten();
            this.dtgvalores1 = new HpResergerUserControls.Dtgconten();
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
            this.dtpfin.Size = new System.Drawing.Size(104, 22);
            this.dtpfin.TabIndex = 35;
            // 
            // dtpinicio
            // 
            this.dtpinicio.Enabled = false;
            this.dtpinicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpinicio.Location = new System.Drawing.Point(467, 12);
            this.dtpinicio.Name = "dtpinicio";
            this.dtpinicio.Size = new System.Drawing.Size(104, 22);
            this.dtpinicio.TabIndex = 34;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(395, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 33;
            this.label4.Text = "Fin Etapa:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(395, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 32;
            this.label3.Text = "Inicio Etapa:";
            // 
            // btnexportar
            // 
            this.btnexportar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnexportar.Image = ((System.Drawing.Image)(resources.GetObject("btnexportar.Image")));
            this.btnexportar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnexportar.Location = new System.Drawing.Point(1107, 61);
            this.btnexportar.Name = "btnexportar";
            this.btnexportar.Size = new System.Drawing.Size(74, 26);
            this.btnexportar.TabIndex = 31;
            this.btnexportar.Text = "Excel";
            this.btnexportar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
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
            this.dtgconten.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgconten.CausesValidation = false;           
            this.dtgconten.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;          
            this.dtgconten.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dtgconten.Location = new System.Drawing.Point(91, 92);
            this.dtgconten.MultiSelect = false;
            this.dtgconten.Name = "dtgconten";
            this.dtgconten.ReadOnly = true;
            this.dtgconten.RowHeadersVisible = false;
            this.dtgconten.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dtgconten.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgconten.Size = new System.Drawing.Size(1090, 47);
            this.dtgconten.TabIndex = 30;
            this.dtgconten.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(14, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 29;
            this.label2.Text = "Centro Costo:";
            // 
            // txtcc
            // 
            this.txtcc.Enabled = false;
            this.txtcc.Location = new System.Drawing.Point(91, 64);
            this.txtcc.Name = "txtcc";
            this.txtcc.Size = new System.Drawing.Size(301, 22);
            this.txtcc.TabIndex = 28;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(14, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 27;
            this.label1.Text = "Centro Costo:";
            // 
            // txtcentro
            // 
            this.txtcentro.Enabled = false;
            this.txtcentro.Location = new System.Drawing.Point(91, 38);
            this.txtcentro.Name = "txtcentro";
            this.txtcentro.Size = new System.Drawing.Size(301, 22);
            this.txtcentro.TabIndex = 26;
            // 
            // txtetapa
            // 
            this.txtetapa.Enabled = false;
            this.txtetapa.Location = new System.Drawing.Point(91, 12);
            this.txtetapa.Name = "txtetapa";
            this.txtetapa.Size = new System.Drawing.Size(301, 22);
            this.txtetapa.TabIndex = 25;
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.BackColor = System.Drawing.Color.Transparent;
            this.lbl1.Location = new System.Drawing.Point(47, 16);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(39, 13);
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
            this.dtgvalores.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dtgvalores.CausesValidation = false;          
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
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(12, 116);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 13);
            this.label5.TabIndex = 37;
            this.label5.Text = "Presupuesto:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(11, 147);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 13);
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
            //this.dtgoperaciones.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dtgoperaciones.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgoperaciones.CausesValidation = false;          
            this.dtgoperaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgoperaciones.ColumnHeadersVisible = false;           
            this.dtgoperaciones.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dtgoperaciones.Location = new System.Drawing.Point(91, 136);
            this.dtgoperaciones.MultiSelect = false;
            this.dtgoperaciones.Name = "dtgoperaciones";
            this.dtgoperaciones.ReadOnly = true;
            this.dtgoperaciones.RowHeadersVisible = false;
            this.dtgoperaciones.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dtgoperaciones.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgoperaciones.Size = new System.Drawing.Size(1090, 37);
            this.dtgoperaciones.TabIndex = 38;
            this.dtgoperaciones.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Location = new System.Drawing.Point(14, 172);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 13);
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
            this.dtgdiferencia.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgdiferencia.CausesValidation = false;           
            this.dtgdiferencia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgdiferencia.ColumnHeadersVisible = false;          
            this.dtgdiferencia.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dtgdiferencia.Location = new System.Drawing.Point(91, 160);
            this.dtgdiferencia.MultiSelect = false;
            this.dtgdiferencia.Name = "dtgdiferencia";
            this.dtgdiferencia.ReadOnly = true;
            this.dtgdiferencia.RowHeadersVisible = false;
            this.dtgdiferencia.ScrollBars = System.Windows.Forms.ScrollBars.None;
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
            this.dtgvalores1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dtgvalores1.CausesValidation = false;          
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
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1193, 198);
            this.Controls.Add(this.dtgvalores1);
            this.Controls.Add(this.dtgdiferencia);
            this.Controls.Add(this.dtgoperaciones);
            this.Controls.Add(this.dtgvalores);
            this.Controls.Add(this.dtpfin);
            this.Controls.Add(this.dtpinicio);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnexportar);
            this.Controls.Add(this.dtgconten);
            this.Controls.Add(this.txtcc);
            this.Controls.Add(this.txtcentro);
            this.Controls.Add(this.txtetapa);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl1);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinimumSize = new System.Drawing.Size(1209, 237);
            this.Name = "frmreportepresupuestoetapas";
            this.Nombre = "Reporte Presupuesto Etapas";
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
        private HpResergerUserControls.Dtgconten dtgconten;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox txtcc;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox txtcentro;
        public System.Windows.Forms.TextBox txtetapa;
        public System.Windows.Forms.Label lbl1;
        private HpResergerUserControls.Dtgconten dtgvalores;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private HpResergerUserControls.Dtgconten dtgoperaciones;
        private System.Windows.Forms.Label label7;
        private HpResergerUserControls.Dtgconten dtgdiferencia;
        private HpResergerUserControls.Dtgconten dtgvalores1;
    }
}