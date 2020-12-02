namespace HPReserger.ModuloReportes
{
    partial class frmReporteSaldosContables
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReporteSaldosContables));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.comboMesAño = new HpResergerUserControls.ComboMesAño();
            this.cboEmpresas = new System.Windows.Forms.ComboBox();
            this.lblfechasReporte = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtgconten = new HpResergerUserControls.Dtgconten();
            this.separadorOre1 = new HpResergerUserControls.SeparadorOre();
            this.lblconteo = new System.Windows.Forms.Label();
            this.btnexportarexcel = new System.Windows.Forms.Button();
            this.btncancelar = new System.Windows.Forms.Button();
            this.btnGenerar = new HpResergerUserControls.ButtonPer();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.chk2col = new HpResergerUserControls.checkboxOre();
            this.xCuentaContable = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xDescripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xMontoSoles = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xMontoDolares = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtgconten)).BeginInit();
            this.SuspendLayout();
            // 
            // comboMesAño
            // 
            this.comboMesAño.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.comboMesAño.AutoSize = true;
            this.comboMesAño.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.comboMesAño.BackColor = System.Drawing.Color.Transparent;
            this.comboMesAño.FechaConDiaActual = new System.DateTime(2020, 12, 31, 0, 0, 0, 0);
            this.comboMesAño.FechaFinMes = new System.DateTime(2020, 12, 31, 0, 0, 0, 0);
            this.comboMesAño.FechaInicioMes = new System.DateTime(2020, 12, 1, 0, 0, 0, 0);
            this.comboMesAño.Location = new System.Drawing.Point(203, 54);
            this.comboMesAño.Name = "comboMesAño";
            this.comboMesAño.Size = new System.Drawing.Size(200, 27);
            this.comboMesAño.TabIndex = 97;
            this.comboMesAño.VerAño = true;
            this.comboMesAño.VerMes = true;
            // 
            // cboEmpresas
            // 
            this.cboEmpresas.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cboEmpresas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEmpresas.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboEmpresas.FormattingEnabled = true;
            this.cboEmpresas.Location = new System.Drawing.Point(154, 8);
            this.cboEmpresas.Name = "cboEmpresas";
            this.cboEmpresas.Size = new System.Drawing.Size(299, 25);
            this.cboEmpresas.TabIndex = 96;
            this.cboEmpresas.Click += new System.EventHandler(this.cboEmpresas_Click);
            // 
            // lblfechasReporte
            // 
            this.lblfechasReporte.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblfechasReporte.AutoSize = true;
            this.lblfechasReporte.BackColor = System.Drawing.Color.Transparent;
            this.lblfechasReporte.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfechasReporte.Location = new System.Drawing.Point(287, 63);
            this.lblfechasReporte.Name = "lblfechasReporte";
            this.lblfechasReporte.Size = new System.Drawing.Size(32, 13);
            this.lblfechasReporte.TabIndex = 92;
            this.lblfechasReporte.Text = "Al 31";
            this.lblfechasReporte.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(214, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 17);
            this.label1.TabIndex = 91;
            this.label1.Text = "Reporte de Saldos Contables";
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
            this.dtgconten.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(129)))), ((int)(((byte)(189)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DeepSkyBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgconten.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dtgconten.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dtgconten.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.xCuentaContable,
            this.xDescripcion,
            this.xMontoSoles,
            this.xMontoDolares});
            this.dtgconten.Cursor = System.Windows.Forms.Cursors.Default;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(207)))), ((int)(((byte)(241)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgconten.DefaultCellStyle = dataGridViewCellStyle5;
            this.dtgconten.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dtgconten.EnableHeadersVisualStyles = false;
            this.dtgconten.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(179)))), ((int)(((byte)(215)))));
            this.dtgconten.Location = new System.Drawing.Point(10, 89);
            this.dtgconten.MultiSelect = false;
            this.dtgconten.Name = "dtgconten";
            this.dtgconten.ReadOnly = true;
            this.dtgconten.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dtgconten.RowHeadersVisible = false;
            this.dtgconten.RowTemplate.Height = 16;
            this.dtgconten.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgconten.Size = new System.Drawing.Size(584, 393);
            this.dtgconten.TabIndex = 420;
            // 
            // separadorOre1
            // 
            this.separadorOre1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.separadorOre1.BackColor = System.Drawing.Color.Transparent;
            this.separadorOre1.Location = new System.Drawing.Point(0, 84);
            this.separadorOre1.MaximumSize = new System.Drawing.Size(2000, 2);
            this.separadorOre1.MinimumSize = new System.Drawing.Size(0, 2);
            this.separadorOre1.Name = "separadorOre1";
            this.separadorOre1.Size = new System.Drawing.Size(622, 2);
            this.separadorOre1.TabIndex = 421;
            // 
            // lblconteo
            // 
            this.lblconteo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblconteo.AutoSize = true;
            this.lblconteo.BackColor = System.Drawing.Color.Transparent;
            this.lblconteo.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblconteo.Location = new System.Drawing.Point(10, 493);
            this.lblconteo.Name = "lblconteo";
            this.lblconteo.Size = new System.Drawing.Size(130, 13);
            this.lblconteo.TabIndex = 424;
            this.lblconteo.Text = "Número de Registros:  0";
            // 
            // btnexportarexcel
            // 
            this.btnexportarexcel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnexportarexcel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnexportarexcel.Image = ((System.Drawing.Image)(resources.GetObject("btnexportarexcel.Image")));
            this.btnexportarexcel.Location = new System.Drawing.Point(264, 488);
            this.btnexportarexcel.Name = "btnexportarexcel";
            this.btnexportarexcel.Size = new System.Drawing.Size(79, 23);
            this.btnexportarexcel.TabIndex = 423;
            this.btnexportarexcel.Text = "Excel";
            this.btnexportarexcel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnexportarexcel.UseVisualStyleBackColor = true;
            this.btnexportarexcel.Click += new System.EventHandler(this.btnexportarexcel_Click);
            // 
            // btncancelar
            // 
            this.btncancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btncancelar.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncancelar.Image = ((System.Drawing.Image)(resources.GetObject("btncancelar.Image")));
            this.btncancelar.Location = new System.Drawing.Point(515, 488);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(79, 23);
            this.btncancelar.TabIndex = 422;
            this.btncancelar.Text = "Cancelar";
            this.btncancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btncancelar.UseVisualStyleBackColor = true;
            this.btncancelar.Click += new System.EventHandler(this.btncancelar_Click);
            // 
            // btnGenerar
            // 
            this.btnGenerar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGenerar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(129)))), ((int)(((byte)(189)))));
            this.btnGenerar.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnGenerar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerar.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerar.ForeColor = System.Drawing.Color.White;
            this.btnGenerar.Image = ((System.Drawing.Image)(resources.GetObject("btnGenerar.Image")));
            this.btnGenerar.Location = new System.Drawing.Point(515, 59);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(79, 24);
            this.btnGenerar.TabIndex = 425;
            this.btnGenerar.Text = "Generar";
            this.btnGenerar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGenerar.UseVisualStyleBackColor = false;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // chk2col
            // 
            this.chk2col.AutoSize = true;
            this.chk2col.BackColor = System.Drawing.Color.Transparent;
            this.chk2col.Checked = true;
            this.chk2col.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chk2col.ColorChecked = System.Drawing.Color.Empty;
            this.chk2col.ColorUnChecked = System.Drawing.Color.Empty;
            this.chk2col.Location = new System.Drawing.Point(423, 491);
            this.chk2col.Name = "chk2col";
            this.chk2col.Size = new System.Drawing.Size(69, 17);
            this.chk2col.TabIndex = 426;
            this.chk2col.Text = "Moneda";
            this.chk2col.UseVisualStyleBackColor = false;
            this.chk2col.Visible = false;
            this.chk2col.CheckedChanged += new System.EventHandler(this.chk2col_CheckedChanged);
            // 
            // xCuentaContable
            // 
            this.xCuentaContable.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.xCuentaContable.DataPropertyName = "cuentacontable";
            this.xCuentaContable.HeaderText = "Cuenta Contable";
            this.xCuentaContable.Name = "xCuentaContable";
            this.xCuentaContable.ReadOnly = true;
            this.xCuentaContable.Width = 117;
            // 
            // xDescripcion
            // 
            this.xDescripcion.DataPropertyName = "cuenta_contable";
            this.xDescripcion.HeaderText = "Descripción";
            this.xDescripcion.Name = "xDescripcion";
            this.xDescripcion.ReadOnly = true;
            // 
            // xMontoSoles
            // 
            this.xMontoSoles.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.xMontoSoles.DataPropertyName = "SaldoSoles";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.Format = "n2";
            this.xMontoSoles.DefaultCellStyle = dataGridViewCellStyle3;
            this.xMontoSoles.HeaderText = "Saldo Soles";
            this.xMontoSoles.MinimumWidth = 100;
            this.xMontoSoles.Name = "xMontoSoles";
            this.xMontoSoles.ReadOnly = true;
            // 
            // xMontoDolares
            // 
            this.xMontoDolares.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.xMontoDolares.DataPropertyName = "SaldoDolares";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle4.Format = "n2";
            this.xMontoDolares.DefaultCellStyle = dataGridViewCellStyle4;
            this.xMontoDolares.HeaderText = "Saldo Dolares";
            this.xMontoDolares.MinimumWidth = 100;
            this.xMontoDolares.Name = "xMontoDolares";
            this.xMontoDolares.ReadOnly = true;
            this.xMontoDolares.Width = 101;
            // 
            // frmReporteSaldosContables
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(606, 517);
            this.Controls.Add(this.chk2col);
            this.Controls.Add(this.btnGenerar);
            this.Controls.Add(this.lblconteo);
            this.Controls.Add(this.btnexportarexcel);
            this.Controls.Add(this.btncancelar);
            this.Controls.Add(this.separadorOre1);
            this.Controls.Add(this.dtgconten);
            this.Controls.Add(this.comboMesAño);
            this.Controls.Add(this.cboEmpresas);
            this.Controls.Add(this.lblfechasReporte);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinimumSize = new System.Drawing.Size(622, 556);
            this.Name = "frmReporteSaldosContables";
            this.Nombre = "Reporte de Saldos Contables";
            this.Text = "Reporte de Saldos Contables";
            this.Load += new System.EventHandler(this.frmReporteSaldosContables_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgconten)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private HpResergerUserControls.ComboMesAño comboMesAño;
        private System.Windows.Forms.ComboBox cboEmpresas;
        private System.Windows.Forms.Label lblfechasReporte;
        private System.Windows.Forms.Label label1;
        private HpResergerUserControls.Dtgconten dtgconten;
        private HpResergerUserControls.SeparadorOre separadorOre1;
        private System.Windows.Forms.Label lblconteo;
        private System.Windows.Forms.Button btnexportarexcel;
        private System.Windows.Forms.Button btncancelar;
        private HpResergerUserControls.ButtonPer btnGenerar;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private HpResergerUserControls.checkboxOre chk2col;
        private System.Windows.Forms.DataGridViewTextBoxColumn xCuentaContable;
        private System.Windows.Forms.DataGridViewTextBoxColumn xDescripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn xMontoSoles;
        private System.Windows.Forms.DataGridViewTextBoxColumn xMontoDolares;
    }
}