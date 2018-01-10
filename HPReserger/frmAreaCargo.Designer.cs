namespace HPReserger
{
    partial class frmAreaCargo
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
            this.dtgconten = new System.Windows.Forms.DataGridView();
            this.fk_id_Area = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.area = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fk_id_cargo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cargo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btncancelar = new System.Windows.Forms.Button();
            this.cboarea = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cboCargoPuesto = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnmodificar = new System.Windows.Forms.Button();
            this.btnagregar = new System.Windows.Forms.Button();
            this.cbogerencia = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnr = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgconten)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgconten
            // 
            this.dtgconten.AllowUserToAddRows = false;
            this.dtgconten.AllowUserToDeleteRows = false;
            this.dtgconten.AllowUserToResizeColumns = false;
            this.dtgconten.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.dtgconten.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgconten.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgconten.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgconten.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dtgconten.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dtgconten.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dtgconten.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Franklin Gothic Book", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgconten.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dtgconten.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dtgconten.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.fk_id_Area,
            this.area,
            this.fk_id_cargo,
            this.cargo});
            this.dtgconten.Cursor = System.Windows.Forms.Cursors.Default;
            this.dtgconten.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dtgconten.Location = new System.Drawing.Point(12, 96);
            this.dtgconten.MultiSelect = false;
            this.dtgconten.Name = "dtgconten";
            this.dtgconten.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dtgconten.RowHeadersVisible = false;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Franklin Gothic Book", 8.25F);
            this.dtgconten.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dtgconten.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgconten.Size = new System.Drawing.Size(469, 218);
            this.dtgconten.TabIndex = 59;
            this.dtgconten.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dtgconten_KeyDown);
            // 
            // fk_id_Area
            // 
            this.fk_id_Area.DataPropertyName = "fk_id_Area";
            this.fk_id_Area.HeaderText = "fk_id_Area";
            this.fk_id_Area.Name = "fk_id_Area";
            this.fk_id_Area.Visible = false;
            // 
            // area
            // 
            this.area.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.area.DataPropertyName = "area";
            this.area.HeaderText = "Área";
            this.area.Name = "area";
            // 
            // fk_id_cargo
            // 
            this.fk_id_cargo.DataPropertyName = "fk_idcargo";
            this.fk_id_cargo.HeaderText = "fk_id_cargo";
            this.fk_id_cargo.Name = "fk_id_cargo";
            this.fk_id_cargo.Visible = false;
            // 
            // cargo
            // 
            this.cargo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cargo.DataPropertyName = "cargo";
            this.cargo.HeaderText = "Cargo";
            this.cargo.Name = "cargo";
            // 
            // btncancelar
            // 
            this.btncancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btncancelar.Location = new System.Drawing.Point(378, 320);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(103, 24);
            this.btncancelar.TabIndex = 76;
            this.btncancelar.Text = "&Cancelar";
            this.btncancelar.UseVisualStyleBackColor = true;
            this.btncancelar.Click += new System.EventHandler(this.btncancelar_Click);
            // 
            // cboarea
            // 
            this.cboarea.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboarea.BackColor = System.Drawing.Color.White;
            this.cboarea.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboarea.FormattingEnabled = true;
            this.cboarea.Items.AddRange(new object[] {
            "EXTERNA",
            "INTERNA"});
            this.cboarea.Location = new System.Drawing.Point(70, 39);
            this.cboarea.Name = "cboarea";
            this.cboarea.Size = new System.Drawing.Size(301, 21);
            this.cboarea.TabIndex = 78;
            this.cboarea.SelectedIndexChanged += new System.EventHandler(this.cboarea_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Location = new System.Drawing.Point(32, 42);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(32, 13);
            this.label8.TabIndex = 77;
            this.label8.Text = "Área:";
            // 
            // cboCargoPuesto
            // 
            this.cboCargoPuesto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboCargoPuesto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCargoPuesto.Enabled = false;
            this.cboCargoPuesto.FormattingEnabled = true;
            this.cboCargoPuesto.Location = new System.Drawing.Point(70, 69);
            this.cboCargoPuesto.Name = "cboCargoPuesto";
            this.cboCargoPuesto.Size = new System.Drawing.Size(269, 21);
            this.cboCargoPuesto.TabIndex = 79;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(26, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 80;
            this.label1.Text = "Cargo:";
            // 
            // btnmodificar
            // 
            this.btnmodificar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnmodificar.Location = new System.Drawing.Point(377, 36);
            this.btnmodificar.Name = "btnmodificar";
            this.btnmodificar.Size = new System.Drawing.Size(103, 24);
            this.btnmodificar.TabIndex = 81;
            this.btnmodificar.Text = "&Modificar";
            this.btnmodificar.UseVisualStyleBackColor = true;
            this.btnmodificar.Click += new System.EventHandler(this.btnmodificar_Click);
            // 
            // btnagregar
            // 
            this.btnagregar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnagregar.Location = new System.Drawing.Point(377, 66);
            this.btnagregar.Name = "btnagregar";
            this.btnagregar.Size = new System.Drawing.Size(103, 24);
            this.btnagregar.TabIndex = 82;
            this.btnagregar.Text = "&Agregar";
            this.btnagregar.UseVisualStyleBackColor = true;
            this.btnagregar.Click += new System.EventHandler(this.btnagregar_Click);
            // 
            // cbogerencia
            // 
            this.cbogerencia.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbogerencia.BackColor = System.Drawing.Color.White;
            this.cbogerencia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbogerencia.FormattingEnabled = true;
            this.cbogerencia.Items.AddRange(new object[] {
            "EXTERNA",
            "INTERNA"});
            this.cbogerencia.Location = new System.Drawing.Point(70, 12);
            this.cbogerencia.Name = "cbogerencia";
            this.cbogerencia.Size = new System.Drawing.Size(269, 21);
            this.cbogerencia.TabIndex = 84;
            this.cbogerencia.SelectedIndexChanged += new System.EventHandler(this.cbogerencia_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(11, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 83;
            this.label3.Text = "Gerencia:";
            // 
            // btnr
            // 
            this.btnr.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnr.BackgroundImage = global::HPReserger.Properties.Resources.sshot_2017_06_13__17_59_46_;
            this.btnr.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnr.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnr.Location = new System.Drawing.Point(345, 12);
            this.btnr.Name = "btnr";
            this.btnr.Size = new System.Drawing.Size(26, 21);
            this.btnr.TabIndex = 85;
            this.btnr.Tag = "1";
            this.btnr.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnr.UseVisualStyleBackColor = true;
            this.btnr.Click += new System.EventHandler(this.btnr_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackgroundImage = global::HPReserger.Properties.Resources.sshot_2017_06_13__17_59_46_;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(345, 68);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(26, 21);
            this.button1.TabIndex = 86;
            this.button1.Tag = "2";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnr_Click);
            // 
            // frmAreaCargo
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(493, 349);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnr);
            this.Controls.Add(this.cbogerencia);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnagregar);
            this.Controls.Add(this.btnmodificar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboCargoPuesto);
            this.Controls.Add(this.cboarea);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btncancelar);
            this.Controls.Add(this.dtgconten);
            this.MinimumSize = new System.Drawing.Size(509, 388);
            this.Name = "frmAreaCargo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Area - Cargo";
            this.Load += new System.EventHandler(this.frmAreaCargo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgconten)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgconten;
        private System.Windows.Forms.Button btncancelar;
        private System.Windows.Forms.DataGridViewTextBoxColumn fk_id_Area;
        private System.Windows.Forms.DataGridViewTextBoxColumn area;
        private System.Windows.Forms.DataGridViewTextBoxColumn fk_id_cargo;
        private System.Windows.Forms.DataGridViewTextBoxColumn cargo;
        private System.Windows.Forms.ComboBox cboarea;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cboCargoPuesto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnmodificar;
        private System.Windows.Forms.Button btnagregar;
        private System.Windows.Forms.ComboBox cbogerencia;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnr;
        private System.Windows.Forms.Button button1;
    }
}