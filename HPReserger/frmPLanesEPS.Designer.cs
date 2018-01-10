namespace HPReserger
{
    partial class frmPLanesEPS
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Numadicional3 = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.Numadicional2 = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.Numadicional1 = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.NumAporte = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.btnmodificar = new System.Windows.Forms.Button();
            this.btncancelar = new System.Windows.Forms.Button();
            this.btnaceptar = new System.Windows.Forms.Button();
            this.btnnuevo = new System.Windows.Forms.Button();
            this.dtgconten = new System.Windows.Forms.DataGridView();
            this.txtplan = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.id_eps_planes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ideps = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreplan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Titular = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Beneficiario1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Beneficiario2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Beneficiario3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.Numadicional3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Numadicional2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Numadicional1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumAporte)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgconten)).BeginInit();
            this.SuspendLayout();
            // 
            // Numadicional3
            // 
            this.Numadicional3.DecimalPlaces = 2;
            this.Numadicional3.Enabled = false;
            this.Numadicional3.Location = new System.Drawing.Point(302, 71);
            this.Numadicional3.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.Numadicional3.Name = "Numadicional3";
            this.Numadicional3.Size = new System.Drawing.Size(116, 20);
            this.Numadicional3.TabIndex = 80;
            this.Numadicional3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(223, 73);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 13);
            this.label8.TabIndex = 79;
            this.label8.Text = "Adicional 3";
            // 
            // Numadicional2
            // 
            this.Numadicional2.DecimalPlaces = 2;
            this.Numadicional2.Enabled = false;
            this.Numadicional2.Location = new System.Drawing.Point(87, 71);
            this.Numadicional2.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.Numadicional2.Name = "Numadicional2";
            this.Numadicional2.Size = new System.Drawing.Size(116, 20);
            this.Numadicional2.TabIndex = 78;
            this.Numadicional2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 73);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 13);
            this.label5.TabIndex = 77;
            this.label5.Text = "Adicional 2";
            // 
            // Numadicional1
            // 
            this.Numadicional1.DecimalPlaces = 2;
            this.Numadicional1.Enabled = false;
            this.Numadicional1.Location = new System.Drawing.Point(302, 45);
            this.Numadicional1.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.Numadicional1.Name = "Numadicional1";
            this.Numadicional1.Size = new System.Drawing.Size(116, 20);
            this.Numadicional1.TabIndex = 76;
            this.Numadicional1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(223, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 75;
            this.label4.Text = "Adicional 1";
            // 
            // NumAporte
            // 
            this.NumAporte.DecimalPlaces = 2;
            this.NumAporte.Enabled = false;
            this.NumAporte.Location = new System.Drawing.Point(87, 45);
            this.NumAporte.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.NumAporte.Name = "NumAporte";
            this.NumAporte.Size = new System.Drawing.Size(116, 20);
            this.NumAporte.TabIndex = 74;
            this.NumAporte.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 73;
            this.label3.Text = "Beneficiario:";
            // 
            // btnmodificar
            // 
            this.btnmodificar.Enabled = false;
            this.btnmodificar.Location = new System.Drawing.Point(424, 44);
            this.btnmodificar.Name = "btnmodificar";
            this.btnmodificar.Size = new System.Drawing.Size(82, 21);
            this.btnmodificar.TabIndex = 84;
            this.btnmodificar.Text = "Modificar";
            this.btnmodificar.UseVisualStyleBackColor = true;
            this.btnmodificar.Click += new System.EventHandler(this.btnmodificar_Click);
            // 
            // btncancelar
            // 
            this.btncancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btncancelar.Location = new System.Drawing.Point(424, 369);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(82, 29);
            this.btncancelar.TabIndex = 81;
            this.btncancelar.Text = "Cancelar";
            this.btncancelar.UseVisualStyleBackColor = true;
            this.btncancelar.Click += new System.EventHandler(this.btncancelar_Click);
            // 
            // btnaceptar
            // 
            this.btnaceptar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnaceptar.Enabled = false;
            this.btnaceptar.Location = new System.Drawing.Point(336, 369);
            this.btnaceptar.Name = "btnaceptar";
            this.btnaceptar.Size = new System.Drawing.Size(82, 29);
            this.btnaceptar.TabIndex = 82;
            this.btnaceptar.Text = "Aceptar";
            this.btnaceptar.UseVisualStyleBackColor = true;
            this.btnaceptar.Click += new System.EventHandler(this.btnaceptar_Click);
            // 
            // btnnuevo
            // 
            this.btnnuevo.Location = new System.Drawing.Point(424, 18);
            this.btnnuevo.Name = "btnnuevo";
            this.btnnuevo.Size = new System.Drawing.Size(82, 20);
            this.btnnuevo.TabIndex = 83;
            this.btnnuevo.Text = "Nuevo";
            this.btnnuevo.UseVisualStyleBackColor = true;
            this.btnnuevo.Click += new System.EventHandler(this.btnnuevo_Click);
            // 
            // dtgconten
            // 
            this.dtgconten.AllowUserToAddRows = false;
            this.dtgconten.AllowUserToDeleteRows = false;
            this.dtgconten.AllowUserToResizeColumns = false;
            this.dtgconten.AllowUserToResizeRows = false;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.WhiteSmoke;
            this.dtgconten.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle13;
            this.dtgconten.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dtgconten.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Franklin Gothic Book", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgconten.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle14;
            this.dtgconten.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_eps_planes,
            this.ideps,
            this.nombreplan,
            this.Titular,
            this.Beneficiario1,
            this.Beneficiario2,
            this.Beneficiario3,
            this.usuario,
            this.fechas});
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Franklin Gothic Book", 8.25F);
            dataGridViewCellStyle15.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgconten.DefaultCellStyle = dataGridViewCellStyle15;
            this.dtgconten.GridColor = System.Drawing.Color.White;
            this.dtgconten.Location = new System.Drawing.Point(12, 97);
            this.dtgconten.Name = "dtgconten";
            this.dtgconten.ReadOnly = true;
            this.dtgconten.RowHeadersVisible = false;
            this.dtgconten.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgconten.Size = new System.Drawing.Size(494, 266);
            this.dtgconten.TabIndex = 85;
            this.dtgconten.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgconten_RowEnter);
            // 
            // txtplan
            // 
            this.txtplan.Enabled = false;
            this.txtplan.Location = new System.Drawing.Point(86, 19);
            this.txtplan.Name = "txtplan";
            this.txtplan.Size = new System.Drawing.Size(332, 20);
            this.txtplan.TabIndex = 87;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 86;
            this.label2.Text = "Descripción";
            // 
            // id_eps_planes
            // 
            this.id_eps_planes.DataPropertyName = "id_eps_planes";
            this.id_eps_planes.HeaderText = "idPlanes";
            this.id_eps_planes.Name = "id_eps_planes";
            this.id_eps_planes.ReadOnly = true;
            this.id_eps_planes.Visible = false;
            // 
            // ideps
            // 
            this.ideps.DataPropertyName = "id_eps";
            this.ideps.HeaderText = "IdEps";
            this.ideps.Name = "ideps";
            this.ideps.ReadOnly = true;
            this.ideps.Visible = false;
            // 
            // nombreplan
            // 
            this.nombreplan.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nombreplan.DataPropertyName = "planes";
            this.nombreplan.FillWeight = 67.8934F;
            this.nombreplan.HeaderText = "Nombre Plan";
            this.nombreplan.Name = "nombreplan";
            this.nombreplan.ReadOnly = true;
            // 
            // Titular
            // 
            this.Titular.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Titular.DataPropertyName = "Titular";
            this.Titular.HeaderText = "Titular";
            this.Titular.Name = "Titular";
            this.Titular.ReadOnly = true;
            this.Titular.Width = 62;
            // 
            // Beneficiario1
            // 
            this.Beneficiario1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Beneficiario1.DataPropertyName = "Adicional1";
            this.Beneficiario1.HeaderText = "Adicional 1";
            this.Beneficiario1.Name = "Beneficiario1";
            this.Beneficiario1.ReadOnly = true;
            this.Beneficiario1.Width = 85;
            // 
            // Beneficiario2
            // 
            this.Beneficiario2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Beneficiario2.DataPropertyName = "Adicional2";
            this.Beneficiario2.HeaderText = "Adicional 2";
            this.Beneficiario2.Name = "Beneficiario2";
            this.Beneficiario2.ReadOnly = true;
            this.Beneficiario2.Width = 85;
            // 
            // Beneficiario3
            // 
            this.Beneficiario3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Beneficiario3.DataPropertyName = "Adicional3";
            this.Beneficiario3.HeaderText = "Adicional 3";
            this.Beneficiario3.Name = "Beneficiario3";
            this.Beneficiario3.ReadOnly = true;
            this.Beneficiario3.Width = 85;
            // 
            // usuario
            // 
            this.usuario.DataPropertyName = "usuario";
            this.usuario.HeaderText = "Usuario";
            this.usuario.Name = "usuario";
            this.usuario.ReadOnly = true;
            this.usuario.Visible = false;
            // 
            // fechas
            // 
            this.fechas.DataPropertyName = "fecha";
            this.fechas.HeaderText = "Fecha";
            this.fechas.Name = "fechas";
            this.fechas.ReadOnly = true;
            this.fechas.Visible = false;
            // 
            // frmPLanesEPS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 405);
            this.Controls.Add(this.txtplan);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtgconten);
            this.Controls.Add(this.btnmodificar);
            this.Controls.Add(this.btncancelar);
            this.Controls.Add(this.btnaceptar);
            this.Controls.Add(this.btnnuevo);
            this.Controls.Add(this.Numadicional3);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.Numadicional2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Numadicional1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.NumAporte);
            this.Controls.Add(this.label3);
            this.MinimumSize = new System.Drawing.Size(530, 444);
            this.Name = "frmPLanesEPS";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Planes EPS";
            this.Load += new System.EventHandler(this.frmPLanesEPS_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Numadicional3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Numadicional2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Numadicional1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumAporte)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgconten)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown Numadicional3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown Numadicional2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown Numadicional1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown NumAporte;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnmodificar;
        private System.Windows.Forms.Button btncancelar;
        private System.Windows.Forms.Button btnaceptar;
        private System.Windows.Forms.Button btnnuevo;
        private System.Windows.Forms.DataGridView dtgconten;
        private System.Windows.Forms.TextBox txtplan;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_eps_planes;
        private System.Windows.Forms.DataGridViewTextBoxColumn ideps;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreplan;
        private System.Windows.Forms.DataGridViewTextBoxColumn Titular;
        private System.Windows.Forms.DataGridViewTextBoxColumn Beneficiario1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Beneficiario2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Beneficiario3;
        private System.Windows.Forms.DataGridViewTextBoxColumn usuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechas;
    }
}