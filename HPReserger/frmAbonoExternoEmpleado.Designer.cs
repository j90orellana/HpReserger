namespace HPReserger
{
    partial class frmAbonoExternoEmpleado
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dtgconten = new System.Windows.Forms.DataGridView();
            this.cboempresa = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btngrabar = new System.Windows.Forms.Button();
            this.btncancelar = new System.Windows.Forms.Button();
            this.btncargar = new System.Windows.Forms.Button();
            this.btnrecempresa = new System.Windows.Forms.Button();
            this.comboMesAño1 = new HpResergerUserControls.ComboMesAño();
            this.nroregistro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diaactual = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rucempres = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codempleado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipodoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.documento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Empleado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ruc_Empresa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.importeabono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtgconten)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgconten
            // 
            this.dtgconten.AllowUserToAddRows = false;
            this.dtgconten.AllowUserToDeleteRows = false;
            this.dtgconten.AllowUserToResizeColumns = false;
            this.dtgconten.AllowUserToResizeRows = false;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.WhiteSmoke;
            this.dtgconten.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle9;
            this.dtgconten.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgconten.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgconten.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dtgconten.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dtgconten.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dtgconten.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgconten.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.dtgconten.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nroregistro,
            this.diaactual,
            this.rucempres,
            this.codempleado,
            this.tipodoc,
            this.documento,
            this.Empleado,
            this.fecha,
            this.usuario,
            this.Ruc_Empresa,
            this.importeabono});
            this.dtgconten.Cursor = System.Windows.Forms.Cursors.Default;
            this.dtgconten.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dtgconten.Location = new System.Drawing.Point(12, 90);
            this.dtgconten.MultiSelect = false;
            this.dtgconten.Name = "dtgconten";
            this.dtgconten.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dtgconten.RowHeadersVisible = false;
            this.dtgconten.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dtgconten.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgconten.Size = new System.Drawing.Size(516, 207);
            this.dtgconten.TabIndex = 57;
            this.dtgconten.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dtgconten_EditingControlShowing);
            // 
            // cboempresa
            // 
            this.cboempresa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboempresa.FormattingEnabled = true;
            this.cboempresa.Location = new System.Drawing.Point(127, 23);
            this.cboempresa.Name = "cboempresa";
            this.cboempresa.Size = new System.Drawing.Size(241, 21);
            this.cboempresa.TabIndex = 58;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(70, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 61;
            this.label1.Text = "Empresa:";
            // 
            // btngrabar
            // 
            this.btngrabar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btngrabar.Location = new System.Drawing.Point(366, 304);
            this.btngrabar.Name = "btngrabar";
            this.btngrabar.Size = new System.Drawing.Size(78, 23);
            this.btngrabar.TabIndex = 62;
            this.btngrabar.Text = "&Grabar";
            this.btngrabar.UseVisualStyleBackColor = true;
            this.btngrabar.Click += new System.EventHandler(this.btngrabar_Click);
            // 
            // btncancelar
            // 
            this.btncancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btncancelar.Location = new System.Drawing.Point(450, 303);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(78, 23);
            this.btncancelar.TabIndex = 63;
            this.btncancelar.Text = "&Cancelar";
            this.btncancelar.UseVisualStyleBackColor = true;
            this.btncancelar.Click += new System.EventHandler(this.btncancelar_Click);
            // 
            // btncargar
            // 
            this.btncargar.Location = new System.Drawing.Point(323, 57);
            this.btncargar.Name = "btncargar";
            this.btncargar.Size = new System.Drawing.Size(78, 23);
            this.btncargar.TabIndex = 64;
            this.btncargar.Text = "&Cargar";
            this.btncargar.UseVisualStyleBackColor = true;
            this.btncargar.Click += new System.EventHandler(this.btncargar_Click);
            // 
            // btnrecempresa
            // 
            this.btnrecempresa.BackgroundImage = global::HPReserger.Properties.Resources.sshot_2017_06_13__17_59_46_;
            this.btnrecempresa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnrecempresa.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnrecempresa.Location = new System.Drawing.Point(374, 23);
            this.btnrecempresa.Name = "btnrecempresa";
            this.btnrecempresa.Size = new System.Drawing.Size(27, 21);
            this.btnrecempresa.TabIndex = 59;
            this.btnrecempresa.UseVisualStyleBackColor = true;
            this.btnrecempresa.Click += new System.EventHandler(this.btnrecempresa_Click);
            // 
            // comboMesAño1
            // 
            this.comboMesAño1.Location = new System.Drawing.Point(83, 55);
            this.comboMesAño1.Name = "comboMesAño1";
            this.comboMesAño1.Size = new System.Drawing.Size(205, 29);
            this.comboMesAño1.TabIndex = 60;
            this.comboMesAño1.Click += new System.EventHandler(this.comboMesAño1_Click);
            this.comboMesAño1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.comboMesAño1_MouseClick);
            // 
            // nroregistro
            // 
            this.nroregistro.DataPropertyName = "nro_Regitro";
            this.nroregistro.Frozen = true;
            this.nroregistro.HeaderText = "nroregistro";
            this.nroregistro.Name = "nroregistro";
            this.nroregistro.ReadOnly = true;
            this.nroregistro.Visible = false;
            // 
            // diaactual
            // 
            this.diaactual.DataPropertyName = "diaactual";
            this.diaactual.Frozen = true;
            this.diaactual.HeaderText = "diaactual";
            this.diaactual.Name = "diaactual";
            this.diaactual.ReadOnly = true;
            this.diaactual.Visible = false;
            // 
            // rucempres
            // 
            this.rucempres.DataPropertyName = "Ruc_Empresa";
            this.rucempres.Frozen = true;
            this.rucempres.HeaderText = "rucempresa";
            this.rucempres.Name = "rucempres";
            this.rucempres.ReadOnly = true;
            this.rucempres.Visible = false;
            // 
            // codempleado
            // 
            this.codempleado.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.codempleado.DataPropertyName = "cod_empleado";
            this.codempleado.Frozen = true;
            this.codempleado.HeaderText = "codempleado";
            this.codempleado.Name = "codempleado";
            this.codempleado.ReadOnly = true;
            this.codempleado.Visible = false;
            // 
            // tipodoc
            // 
            this.tipodoc.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.tipodoc.DataPropertyName = "tipodoc";
            this.tipodoc.Frozen = true;
            this.tipodoc.HeaderText = "Tipo DNI";
            this.tipodoc.MinimumWidth = 50;
            this.tipodoc.Name = "tipodoc";
            this.tipodoc.ReadOnly = true;
            this.tipodoc.Width = 75;
            // 
            // documento
            // 
            this.documento.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.documento.DataPropertyName = "documento";
            this.documento.Frozen = true;
            this.documento.HeaderText = "Nro Documento";
            this.documento.MinimumWidth = 70;
            this.documento.Name = "documento";
            this.documento.ReadOnly = true;
            this.documento.Width = 107;
            // 
            // Empleado
            // 
            this.Empleado.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Empleado.DataPropertyName = "empleado";
            this.Empleado.HeaderText = "Empleado";
            this.Empleado.MinimumWidth = 100;
            this.Empleado.Name = "Empleado";
            this.Empleado.ReadOnly = true;
            // 
            // fecha
            // 
            this.fecha.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.fecha.DataPropertyName = "fecha";
            dataGridViewCellStyle11.Format = "MMMMyyyy";
            this.fecha.DefaultCellStyle = dataGridViewCellStyle11;
            this.fecha.HeaderText = "Fecha";
            this.fecha.MinimumWidth = 50;
            this.fecha.Name = "fecha";
            this.fecha.ReadOnly = true;
            this.fecha.Width = 62;
            // 
            // usuario
            // 
            this.usuario.DataPropertyName = "usuario";
            this.usuario.HeaderText = "usuario";
            this.usuario.Name = "usuario";
            this.usuario.ReadOnly = true;
            this.usuario.Visible = false;
            // 
            // Ruc_Empresa
            // 
            this.Ruc_Empresa.DataPropertyName = "RucEmpresa";
            this.Ruc_Empresa.HeaderText = "empresaxx";
            this.Ruc_Empresa.Name = "Ruc_Empresa";
            this.Ruc_Empresa.Visible = false;
            // 
            // importeabono
            // 
            this.importeabono.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.importeabono.DataPropertyName = "importe_abono";
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle12.Format = "n2";
            dataGridViewCellStyle12.NullValue = "0.00";
            this.importeabono.DefaultCellStyle = dataGridViewCellStyle12;
            this.importeabono.HeaderText = "Importe Abono";
            this.importeabono.MinimumWidth = 90;
            this.importeabono.Name = "importeabono";
            this.importeabono.Width = 101;
            // 
            // frmAbonoExternoEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(540, 339);
            this.Controls.Add(this.btncargar);
            this.Controls.Add(this.btncancelar);
            this.Controls.Add(this.btngrabar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboMesAño1);
            this.Controls.Add(this.btnrecempresa);
            this.Controls.Add(this.cboempresa);
            this.Controls.Add(this.dtgconten);
            this.MinimumSize = new System.Drawing.Size(487, 378);
            this.Name = "frmAbonoExternoEmpleado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Abono Externo a Empleados";
            this.Load += new System.EventHandler(this.frmAbonoExternoEmpleado_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgconten)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgconten;
        private HpResergerUserControls.ComboMesAño comboMesAño1;
        private System.Windows.Forms.Button btnrecempresa;
        private System.Windows.Forms.ComboBox cboempresa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btngrabar;
        private System.Windows.Forms.Button btncancelar;
        private System.Windows.Forms.Button btncargar;
        private System.Windows.Forms.DataGridViewTextBoxColumn nroregistro;
        private System.Windows.Forms.DataGridViewTextBoxColumn diaactual;
        private System.Windows.Forms.DataGridViewTextBoxColumn rucempres;
        private System.Windows.Forms.DataGridViewTextBoxColumn codempleado;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipodoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn documento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Empleado;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn usuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ruc_Empresa;
        private System.Windows.Forms.DataGridViewTextBoxColumn importeabono;
    }
}