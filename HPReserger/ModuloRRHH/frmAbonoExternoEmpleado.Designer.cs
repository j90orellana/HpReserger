using HpResergerUserControls;

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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAbonoExternoEmpleado));
            this.dtgconten = new HpResergerUserControls.Dtgconten();
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
            this.cboempresa = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btngrabar = new System.Windows.Forms.Button();
            this.btncancelar = new System.Windows.Forms.Button();
            this.btncargar = new System.Windows.Forms.Button();
            this.btnrecempresa = new System.Windows.Forms.Button();
            this.comboMesAño1 = new HpResergerUserControls.ComboMesAño();
            ((System.ComponentModel.ISupportInitialize)(this.dtgconten)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgconten
            // 
            this.dtgconten.AllowUserToAddRows = false;
            this.dtgconten.AllowUserToDeleteRows = false;
            this.dtgconten.AllowUserToResizeColumns = false;
            this.dtgconten.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(230)))), ((int)(((byte)(241)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(191)))), ((int)(((byte)(231)))));
            this.dtgconten.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgconten.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgconten.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgconten.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(218)))), ((int)(((byte)(231)))));
            this.dtgconten.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dtgconten.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dtgconten.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(129)))), ((int)(((byte)(189)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DeepSkyBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgconten.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dtgconten.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
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
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(207)))), ((int)(((byte)(241)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgconten.DefaultCellStyle = dataGridViewCellStyle5;
            this.dtgconten.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dtgconten.EnableHeadersVisualStyles = false;
            this.dtgconten.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(179)))), ((int)(((byte)(215)))));
            this.dtgconten.Location = new System.Drawing.Point(12, 69);
            this.dtgconten.MultiSelect = false;
            this.dtgconten.Name = "dtgconten";
            this.dtgconten.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dtgconten.RowHeadersVisible = false;
            this.dtgconten.RowTemplate.Height = 16;
            this.dtgconten.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dtgconten.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgconten.Size = new System.Drawing.Size(447, 234);
            this.dtgconten.TabIndex = 57;
            this.dtgconten.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dtgconten_EditingControlShowing);
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
            this.tipodoc.Width = 78;
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
            this.documento.Width = 117;
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
            dataGridViewCellStyle3.Format = "MMMMyyyy";
            this.fecha.DefaultCellStyle = dataGridViewCellStyle3;
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
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle4.Format = "n2";
            dataGridViewCellStyle4.NullValue = "0.00";
            this.importeabono.DefaultCellStyle = dataGridViewCellStyle4;
            this.importeabono.HeaderText = "Importe Abono";
            this.importeabono.MinimumWidth = 90;
            this.importeabono.Name = "importeabono";
            this.importeabono.Width = 112;
            // 
            // cboempresa
            // 
            this.cboempresa.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cboempresa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(218)))), ((int)(((byte)(231)))));
            this.cboempresa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboempresa.FormattingEnabled = true;
            this.cboempresa.Location = new System.Drawing.Point(128, 12);
            this.cboempresa.Name = "cboempresa";
            this.cboempresa.Size = new System.Drawing.Size(241, 21);
            this.cboempresa.TabIndex = 58;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(70, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 61;
            this.label1.Text = "Empresa:";
            // 
            // btngrabar
            // 
            this.btngrabar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btngrabar.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btngrabar.Image = ((System.Drawing.Image)(resources.GetObject("btngrabar.Image")));
            this.btngrabar.Location = new System.Drawing.Point(297, 309);
            this.btngrabar.Name = "btngrabar";
            this.btngrabar.Size = new System.Drawing.Size(78, 23);
            this.btngrabar.TabIndex = 62;
            this.btngrabar.Text = "&Grabar";
            this.btngrabar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btngrabar.UseVisualStyleBackColor = true;
            this.btngrabar.Click += new System.EventHandler(this.btngrabar_Click);
            // 
            // btncancelar
            // 
            this.btncancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btncancelar.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncancelar.Image = ((System.Drawing.Image)(resources.GetObject("btncancelar.Image")));
            this.btncancelar.Location = new System.Drawing.Point(381, 309);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(78, 23);
            this.btncancelar.TabIndex = 63;
            this.btncancelar.Text = "&Cancelar";
            this.btncancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btncancelar.UseVisualStyleBackColor = true;
            this.btncancelar.Click += new System.EventHandler(this.btncancelar_Click);
            // 
            // btncargar
            // 
            this.btncargar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btncargar.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncargar.Image = ((System.Drawing.Image)(resources.GetObject("btncargar.Image")));
            this.btncargar.Location = new System.Drawing.Point(303, 39);
            this.btncargar.Name = "btncargar";
            this.btncargar.Size = new System.Drawing.Size(78, 23);
            this.btncargar.TabIndex = 64;
            this.btncargar.Text = "&Cargar";
            this.btncargar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btncargar.UseVisualStyleBackColor = true;
            this.btncargar.Click += new System.EventHandler(this.btncargar_Click);
            // 
            // btnrecempresa
            // 
            this.btnrecempresa.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnrecempresa.BackgroundImage = global::HPReserger.Properties.Resources.sshot_2017_06_13__17_59_46_;
            this.btnrecempresa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnrecempresa.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnrecempresa.Location = new System.Drawing.Point(374, 12);
            this.btnrecempresa.Name = "btnrecempresa";
            this.btnrecempresa.Size = new System.Drawing.Size(27, 21);
            this.btnrecempresa.TabIndex = 59;
            this.btnrecempresa.UseVisualStyleBackColor = true;
            this.btnrecempresa.Click += new System.EventHandler(this.btnrecempresa_Click);
            // 
            // comboMesAño1
            // 
            this.comboMesAño1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.comboMesAño1.AutoSize = true;
            this.comboMesAño1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.comboMesAño1.BackColor = System.Drawing.Color.Transparent;
            this.comboMesAño1.FechaConDiaActual = new System.DateTime(2018, 12, 3, 0, 0, 0, 0);
            this.comboMesAño1.FechaFinMes = new System.DateTime(2018, 12, 31, 0, 0, 0, 0);
            this.comboMesAño1.FechaInicioMes = new System.DateTime(2018, 12, 1, 0, 0, 0, 0);
            this.comboMesAño1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboMesAño1.Location = new System.Drawing.Point(89, 38);
            this.comboMesAño1.Name = "comboMesAño1";
            this.comboMesAño1.Size = new System.Drawing.Size(201, 24);
            this.comboMesAño1.TabIndex = 60;
            this.comboMesAño1.Click += new System.EventHandler(this.comboMesAño1_Click);
            this.comboMesAño1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.comboMesAño1_MouseClick);
            // 
            // frmAbonoExternoEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(471, 339);
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
            this.Nombre = "Planilla Externa De Empleado";
            this.Text = "Planilla Externa De Empleado";
            this.Load += new System.EventHandler(this.frmAbonoExternoEmpleado_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgconten)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Dtgconten dtgconten;
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