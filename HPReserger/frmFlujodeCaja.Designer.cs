namespace HPReserger
{
    partial class frmFlujodeCaja
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFlujodeCaja));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.cboempresa = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboMesAño1 = new HpResergerUserControls.ComboMesAño();
            this.comboMesAño2 = new HpResergerUserControls.ComboMesAño();
            this.crvReporte = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnpdf = new System.Windows.Forms.Button();
            this.btnexcel = new System.Windows.Forms.Button();
            this.btngenerar = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.dtgconten1 = new HpResergerUserControls.Dtgconten();
            this.fechax = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cuentax = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Detallex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numrucx = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.razonsocialx = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombredocx = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numdoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.glosasx = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaasientox = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Movimientosx = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnaceptar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgconten1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Empresa:";
            // 
            // cboempresa
            // 
            this.cboempresa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboempresa.FormattingEnabled = true;
            this.cboempresa.Location = new System.Drawing.Point(71, 12);
            this.cboempresa.Name = "cboempresa";
            this.cboempresa.Size = new System.Drawing.Size(283, 21);
            this.cboempresa.TabIndex = 1;
            this.cboempresa.Click += new System.EventHandler(this.cboempresa_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(17, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Desde:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(287, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Hasta:";
            // 
            // comboMesAño1
            // 
            this.comboMesAño1.AutoSize = true;
            this.comboMesAño1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.comboMesAño1.BackColor = System.Drawing.Color.Transparent;
            this.comboMesAño1.FechaConDiaActual = new System.DateTime(2018, 12, 5, 0, 0, 0, 0);
            this.comboMesAño1.FechaFinMes = new System.DateTime(2018, 12, 31, 0, 0, 0, 0);
            this.comboMesAño1.FechaInicioMes = new System.DateTime(2018, 12, 1, 0, 0, 0, 0);
            this.comboMesAño1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboMesAño1.Location = new System.Drawing.Point(71, 36);
            this.comboMesAño1.Name = "comboMesAño1";
            this.comboMesAño1.Size = new System.Drawing.Size(210, 24);
            this.comboMesAño1.TabIndex = 4;
            // 
            // comboMesAño2
            // 
            this.comboMesAño2.AutoSize = true;
            this.comboMesAño2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.comboMesAño2.BackColor = System.Drawing.Color.Transparent;
            this.comboMesAño2.FechaConDiaActual = new System.DateTime(2018, 12, 5, 0, 0, 0, 0);
            this.comboMesAño2.FechaFinMes = new System.DateTime(2018, 12, 31, 0, 0, 0, 0);
            this.comboMesAño2.FechaInicioMes = new System.DateTime(2018, 12, 1, 0, 0, 0, 0);
            this.comboMesAño2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboMesAño2.Location = new System.Drawing.Point(331, 36);
            this.comboMesAño2.Name = "comboMesAño2";
            this.comboMesAño2.Size = new System.Drawing.Size(203, 24);
            this.comboMesAño2.TabIndex = 5;
            // 
            // crvReporte
            // 
            this.crvReporte.ActiveViewIndex = -1;
            this.crvReporte.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.crvReporte.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crvReporte.Cursor = System.Windows.Forms.Cursors.Default;
            this.crvReporte.DisplayBackgroundEdge = false;
            this.crvReporte.EnableDrillDown = false;
            this.crvReporte.Location = new System.Drawing.Point(842, 3);
            this.crvReporte.Name = "crvReporte";
            this.crvReporte.ShowCloseButton = false;
            this.crvReporte.ShowLogo = false;
            this.crvReporte.ShowParameterPanelButton = false;
            this.crvReporte.Size = new System.Drawing.Size(90, 57);
            this.crvReporte.TabIndex = 6;
            this.crvReporte.Visible = false;
            this.crvReporte.ReportRefresh += new CrystalDecisions.Windows.Forms.RefreshEventHandler(this.crvReporte_ReportRefresh);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.crvReporte);
            this.panel1.Controls.Add(this.btnpdf);
            this.panel1.Controls.Add(this.btnexcel);
            this.panel1.Controls.Add(this.btngenerar);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.cboempresa);
            this.panel1.Controls.Add(this.comboMesAño2);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.comboMesAño1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(944, 69);
            this.panel1.TabIndex = 7;
            // 
            // btnpdf
            // 
            this.btnpdf.Enabled = false;
            this.btnpdf.Image = ((System.Drawing.Image)(resources.GetObject("btnpdf.Image")));
            this.btnpdf.Location = new System.Drawing.Point(729, 37);
            this.btnpdf.Name = "btnpdf";
            this.btnpdf.Size = new System.Drawing.Size(85, 23);
            this.btnpdf.TabIndex = 8;
            this.btnpdf.Text = "Pdf";
            this.btnpdf.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnpdf.UseVisualStyleBackColor = true;
            this.btnpdf.Click += new System.EventHandler(this.btnpdf_Click);
            // 
            // btnexcel
            // 
            this.btnexcel.Enabled = false;
            this.btnexcel.Image = ((System.Drawing.Image)(resources.GetObject("btnexcel.Image")));
            this.btnexcel.Location = new System.Drawing.Point(639, 37);
            this.btnexcel.Name = "btnexcel";
            this.btnexcel.Size = new System.Drawing.Size(85, 23);
            this.btnexcel.TabIndex = 7;
            this.btnexcel.Text = "Excel";
            this.btnexcel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnexcel.UseVisualStyleBackColor = true;
            this.btnexcel.Click += new System.EventHandler(this.btnexcel_Click);
            // 
            // btngenerar
            // 
            this.btngenerar.Image = ((System.Drawing.Image)(resources.GetObject("btngenerar.Image")));
            this.btngenerar.Location = new System.Drawing.Point(549, 37);
            this.btngenerar.Name = "btngenerar";
            this.btngenerar.Size = new System.Drawing.Size(85, 23);
            this.btngenerar.TabIndex = 6;
            this.btngenerar.Text = "Generar";
            this.btngenerar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btngenerar.UseVisualStyleBackColor = true;
            this.btngenerar.Click += new System.EventHandler(this.btngenerar_Click);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.FileName = "Flujo de Caja.xls";
            this.saveFileDialog1.Filter = "Archivos de Excel|*.xls";
            // 
            // dtgconten1
            // 
            this.dtgconten1.AllowUserToAddRows = false;
            this.dtgconten1.AllowUserToResizeColumns = false;
            this.dtgconten1.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(230)))), ((int)(((byte)(241)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(191)))), ((int)(((byte)(231)))));
            this.dtgconten1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgconten1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgconten1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgconten1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(218)))), ((int)(((byte)(231)))));
            this.dtgconten1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgconten1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.dtgconten1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(129)))), ((int)(((byte)(189)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DeepSkyBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgconten1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dtgconten1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dtgconten1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.fechax,
            this.cuentax,
            this.Detallex,
            this.numrucx,
            this.razonsocialx,
            this.nombredocx,
            this.numdoc,
            this.glosasx,
            this.fechaasientox,
            this.Movimientosx});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(207)))), ((int)(((byte)(241)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgconten1.DefaultCellStyle = dataGridViewCellStyle4;
            this.dtgconten1.EnableHeadersVisualStyles = false;
            this.dtgconten1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(179)))), ((int)(((byte)(215)))));
            this.dtgconten1.Location = new System.Drawing.Point(0, 68);
            this.dtgconten1.Name = "dtgconten1";
            this.dtgconten1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dtgconten1.RowHeadersVisible = false;
            this.dtgconten1.RowTemplate.Height = 18;
            this.dtgconten1.Size = new System.Drawing.Size(944, 497);
            this.dtgconten1.TabIndex = 8;
            // 
            // fechax
            // 
            this.fechax.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.fechax.DataPropertyName = "fecha";
            this.fechax.HeaderText = "Periodo";
            this.fechax.MinimumWidth = 50;
            this.fechax.Name = "fechax";
            this.fechax.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.fechax.Width = 53;
            // 
            // cuentax
            // 
            this.cuentax.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.cuentax.DataPropertyName = "cuenta";
            this.cuentax.HeaderText = "Cuenta";
            this.cuentax.MinimumWidth = 50;
            this.cuentax.Name = "cuentax";
            this.cuentax.Width = 69;
            // 
            // Detallex
            // 
            this.Detallex.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Detallex.DataPropertyName = "ruc";
            this.Detallex.HeaderText = "TipoDoc";
            this.Detallex.MinimumWidth = 50;
            this.Detallex.Name = "Detallex";
            this.Detallex.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Detallex.Width = 57;
            // 
            // numrucx
            // 
            this.numrucx.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.numrucx.DataPropertyName = "numruc";
            this.numrucx.HeaderText = "NumDoc";
            this.numrucx.Name = "numrucx";
            this.numrucx.Width = 79;
            // 
            // razonsocialx
            // 
            this.razonsocialx.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.razonsocialx.DataPropertyName = "razonsocial";
            this.razonsocialx.HeaderText = "Razon Social";
            this.razonsocialx.MinimumWidth = 100;
            this.razonsocialx.Name = "razonsocialx";
            // 
            // nombredocx
            // 
            this.nombredocx.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.nombredocx.DataPropertyName = "nombredoc";
            this.nombredocx.HeaderText = "Tipo Comp.";
            this.nombredocx.MinimumWidth = 80;
            this.nombredocx.Name = "nombredocx";
            this.nombredocx.Width = 80;
            // 
            // numdoc
            // 
            this.numdoc.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.numdoc.DataPropertyName = "numdoc";
            this.numdoc.HeaderText = "Num. Comp.";
            this.numdoc.MinimumWidth = 85;
            this.numdoc.Name = "numdoc";
            this.numdoc.Width = 85;
            // 
            // glosasx
            // 
            this.glosasx.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.glosasx.DataPropertyName = "glosas";
            this.glosasx.HeaderText = "Glosas";
            this.glosasx.MinimumWidth = 50;
            this.glosasx.Name = "glosasx";
            this.glosasx.Visible = false;
            // 
            // fechaasientox
            // 
            this.fechaasientox.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.fechaasientox.DataPropertyName = "fechaasiento";
            this.fechaasientox.HeaderText = "FechaAsiento";
            this.fechaasientox.MinimumWidth = 95;
            this.fechaasientox.Name = "fechaasientox";
            this.fechaasientox.Width = 95;
            // 
            // Movimientosx
            // 
            this.Movimientosx.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.Movimientosx.DataPropertyName = "movimientos";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.Format = "N2";
            dataGridViewCellStyle3.NullValue = "0.00";
            this.Movimientosx.DefaultCellStyle = dataGridViewCellStyle3;
            this.Movimientosx.HeaderText = "Movimientos";
            this.Movimientosx.MinimumWidth = 200;
            this.Movimientosx.Name = "Movimientosx";
            this.Movimientosx.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Movimientosx.Width = 200;
            // 
            // btnaceptar
            // 
            this.btnaceptar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnaceptar.Image = ((System.Drawing.Image)(resources.GetObject("btnaceptar.Image")));
            this.btnaceptar.Location = new System.Drawing.Point(850, 571);
            this.btnaceptar.Name = "btnaceptar";
            this.btnaceptar.Size = new System.Drawing.Size(82, 23);
            this.btnaceptar.TabIndex = 60;
            this.btnaceptar.Text = "Aceptar";
            this.btnaceptar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnaceptar.UseVisualStyleBackColor = true;
            this.btnaceptar.Click += new System.EventHandler(this.btnaceptar_Click);
            // 
            // frmFlujodeCaja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 601);
            this.Controls.Add(this.btnaceptar);
            this.Controls.Add(this.dtgconten1);
            this.Controls.Add(this.panel1);
            this.MinimumSize = new System.Drawing.Size(960, 640);
            this.Name = "frmFlujodeCaja";
            this.Nombre = "Flujo de Caja";
            this.Text = "Flujo de Caja";
            this.Load += new System.EventHandler(this.frmFlujodeCaja_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgconten1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboempresa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private HpResergerUserControls.ComboMesAño comboMesAño1;
        private HpResergerUserControls.ComboMesAño comboMesAño2;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crvReporte;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btngenerar;
        private System.Windows.Forms.Button btnexcel;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button btnpdf;
        private HpResergerUserControls.Dtgconten dtgconten1;
        private System.Windows.Forms.Button btnaceptar;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechax;
        private System.Windows.Forms.DataGridViewTextBoxColumn cuentax;
        private System.Windows.Forms.DataGridViewTextBoxColumn Detallex;
        private System.Windows.Forms.DataGridViewTextBoxColumn numrucx;
        private System.Windows.Forms.DataGridViewTextBoxColumn razonsocialx;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombredocx;
        private System.Windows.Forms.DataGridViewTextBoxColumn numdoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn glosasx;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaasientox;
        private System.Windows.Forms.DataGridViewTextBoxColumn Movimientosx;
    }
}