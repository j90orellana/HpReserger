namespace HPReserger.ModuloRRHH
{
    partial class frmReporteComisiones
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dtgconten = new HpResergerUserControls.Dtgconten();
            this.btnPaso1 = new HpResergerUserControls.ButtonPer();
            this.label4 = new System.Windows.Forms.Label();
            this.cbode = new HpResergerUserControls.ComboMesAño();
            this.label1 = new System.Windows.Forms.Label();
            this.cbohasta = new HpResergerUserControls.ComboMesAño();
            this.lbltotalRegistros = new System.Windows.Forms.Label();
            this.BtnCerrar = new HpResergerUserControls.ButtonPer();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.btnexcel = new HpResergerUserControls.ButtonPer();
            this.xok = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xpkid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xtipoid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xnumdoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xpkEmpresa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xEmpresaOrigen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xfkempresa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xEmpresaFin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xperiodo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xSueldo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xComision = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xBono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xRefacturar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtgconten)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgconten
            // 
            this.dtgconten.AllowUserToAddRows = false;
            this.dtgconten.AllowUserToOrderColumns = true;
            this.dtgconten.AllowUserToResizeColumns = false;
            this.dtgconten.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtgconten.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgconten.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgconten.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgconten.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtgconten.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(218)))), ((int)(((byte)(231)))));
            this.dtgconten.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgconten.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.dtgconten.CheckColumna = "xok";
            this.dtgconten.CheckValor = 1;
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
            this.xok,
            this.xpkid,
            this.xtipoid,
            this.xnumdoc,
            this.xNombre,
            this.xpkEmpresa,
            this.xEmpresaOrigen,
            this.xfkempresa,
            this.xEmpresaFin,
            this.xperiodo,
            this.xSueldo,
            this.xComision,
            this.xBono,
            this.xRefacturar});
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(207)))), ((int)(((byte)(241)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgconten.DefaultCellStyle = dataGridViewCellStyle8;
            this.dtgconten.EnableHeadersVisualStyles = false;
            this.dtgconten.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(179)))), ((int)(((byte)(215)))));
            this.dtgconten.Location = new System.Drawing.Point(12, 65);
            this.dtgconten.Name = "dtgconten";
            this.dtgconten.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dtgconten.RowHeadersVisible = false;
            this.dtgconten.RowTemplate.Height = 18;
            this.dtgconten.Size = new System.Drawing.Size(980, 458);
            this.dtgconten.TabIndex = 360;
            // 
            // btnPaso1
            // 
            this.btnPaso1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(129)))), ((int)(((byte)(189)))));
            this.btnPaso1.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnPaso1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPaso1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPaso1.ForeColor = System.Drawing.Color.White;
            this.btnPaso1.Location = new System.Drawing.Point(412, 22);
            this.btnPaso1.Margin = new System.Windows.Forms.Padding(0);
            this.btnPaso1.Name = "btnPaso1";
            this.btnPaso1.Size = new System.Drawing.Size(75, 22);
            this.btnPaso1.TabIndex = 359;
            this.btnPaso1.Tag = "1";
            this.btnPaso1.Text = "Buscar";
            this.btnPaso1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnPaso1.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnPaso1.UseVisualStyleBackColor = false;
            this.btnPaso1.Click += new System.EventHandler(this.btnPaso1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(11, 8);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(179, 13);
            this.label4.TabIndex = 358;
            this.label4.Text = "1.- Seleccione Rango de Periodos";
            // 
            // cbode
            // 
            this.cbode.BackColor = System.Drawing.Color.Transparent;
            this.cbode.FechaConDiaActual = new System.DateTime(2021, 7, 31, 0, 0, 0, 0);
            this.cbode.FechaFinMes = new System.DateTime(2021, 7, 31, 0, 0, 0, 0);
            this.cbode.FechaInicioMes = new System.DateTime(2021, 7, 1, 0, 0, 0, 0);
            this.cbode.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbode.Location = new System.Drawing.Point(11, 20);
            this.cbode.Name = "cbode";
            this.cbode.Size = new System.Drawing.Size(197, 26);
            this.cbode.TabIndex = 357;
            this.cbode.VerAño = true;
            this.cbode.VerMes = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(261, 13);
            this.label1.TabIndex = 358;
            this.label1.Text = "2.- Listado de Comisiones y Bonos de Empleados";
            // 
            // cbohasta
            // 
            this.cbohasta.BackColor = System.Drawing.Color.Transparent;
            this.cbohasta.FechaConDiaActual = new System.DateTime(2021, 7, 31, 0, 0, 0, 0);
            this.cbohasta.FechaFinMes = new System.DateTime(2021, 7, 31, 0, 0, 0, 0);
            this.cbohasta.FechaInicioMes = new System.DateTime(2021, 7, 1, 0, 0, 0, 0);
            this.cbohasta.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbohasta.Location = new System.Drawing.Point(212, 20);
            this.cbohasta.Name = "cbohasta";
            this.cbohasta.Size = new System.Drawing.Size(197, 26);
            this.cbohasta.TabIndex = 357;
            this.cbohasta.VerAño = true;
            this.cbohasta.VerMes = true;
            // 
            // lbltotalRegistros
            // 
            this.lbltotalRegistros.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbltotalRegistros.AutoSize = true;
            this.lbltotalRegistros.BackColor = System.Drawing.Color.Transparent;
            this.lbltotalRegistros.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltotalRegistros.Location = new System.Drawing.Point(12, 539);
            this.lbltotalRegistros.Name = "lbltotalRegistros";
            this.lbltotalRegistros.Size = new System.Drawing.Size(86, 13);
            this.lbltotalRegistros.TabIndex = 364;
            this.lbltotalRegistros.Text = "Total Registros:";
            // 
            // BtnCerrar
            // 
            this.BtnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnCerrar.BackColor = System.Drawing.Color.Crimson;
            this.BtnCerrar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnCerrar.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.BtnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCerrar.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCerrar.ForeColor = System.Drawing.Color.White;
            this.BtnCerrar.Location = new System.Drawing.Point(909, 529);
            this.BtnCerrar.Name = "BtnCerrar";
            this.BtnCerrar.Size = new System.Drawing.Size(83, 23);
            this.BtnCerrar.TabIndex = 365;
            this.BtnCerrar.Text = "Cancelar";
            this.BtnCerrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnCerrar.UseVisualStyleBackColor = false;
            this.BtnCerrar.Click += new System.EventHandler(this.BtnCerrar_Click);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // btnexcel
            // 
            this.btnexcel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnexcel.BackColor = System.Drawing.Color.SeaGreen;
            this.btnexcel.FlatAppearance.BorderColor = System.Drawing.Color.Olive;
            this.btnexcel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnexcel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnexcel.ForeColor = System.Drawing.Color.White;
            this.btnexcel.Location = new System.Drawing.Point(461, 529);
            this.btnexcel.Name = "btnexcel";
            this.btnexcel.Size = new System.Drawing.Size(83, 23);
            this.btnexcel.TabIndex = 376;
            this.btnexcel.Text = "Excel";
            this.btnexcel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnexcel.UseVisualStyleBackColor = false;
            this.btnexcel.Click += new System.EventHandler(this.btnexcel_Click);
            // 
            // xok
            // 
            this.xok.DataPropertyName = "ok";
            this.xok.HeaderText = "OK";
            this.xok.Name = "xok";
            this.xok.Visible = false;
            // 
            // xpkid
            // 
            this.xpkid.DataPropertyName = "pkid";
            this.xpkid.HeaderText = "pkid";
            this.xpkid.Name = "xpkid";
            this.xpkid.Visible = false;
            // 
            // xtipoid
            // 
            this.xtipoid.DataPropertyName = "tipoid";
            this.xtipoid.HeaderText = "TipoID";
            this.xtipoid.Name = "xtipoid";
            this.xtipoid.Visible = false;
            // 
            // xnumdoc
            // 
            this.xnumdoc.DataPropertyName = "numdoc";
            this.xnumdoc.HeaderText = "Dcmnto";
            this.xnumdoc.Name = "xnumdoc";
            this.xnumdoc.Visible = false;
            // 
            // xNombre
            // 
            this.xNombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.xNombre.DataPropertyName = "nombre";
            this.xNombre.HeaderText = "Nombres";
            this.xNombre.MinimumWidth = 180;
            this.xNombre.Name = "xNombre";
            this.xNombre.ReadOnly = true;
            this.xNombre.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // xpkEmpresa
            // 
            this.xpkEmpresa.DataPropertyName = "pkempresa";
            this.xpkEmpresa.HeaderText = "pkEmpresa";
            this.xpkEmpresa.Name = "xpkEmpresa";
            this.xpkEmpresa.Visible = false;
            // 
            // xEmpresaOrigen
            // 
            this.xEmpresaOrigen.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.xEmpresaOrigen.DataPropertyName = "empresaPlanilla";
            this.xEmpresaOrigen.HeaderText = "Empresa Planilla";
            this.xEmpresaOrigen.MinimumWidth = 200;
            this.xEmpresaOrigen.Name = "xEmpresaOrigen";
            this.xEmpresaOrigen.ReadOnly = true;
            this.xEmpresaOrigen.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.xEmpresaOrigen.Width = 200;
            // 
            // xfkempresa
            // 
            this.xfkempresa.DataPropertyName = "fkempresa";
            this.xfkempresa.HeaderText = "fkempresa";
            this.xfkempresa.Name = "xfkempresa";
            this.xfkempresa.Visible = false;
            // 
            // xEmpresaFin
            // 
            this.xEmpresaFin.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.xEmpresaFin.DataPropertyName = "empresabonos";
            this.xEmpresaFin.HeaderText = "Empresa Comisiones";
            this.xEmpresaFin.MinimumWidth = 200;
            this.xEmpresaFin.Name = "xEmpresaFin";
            this.xEmpresaFin.ReadOnly = true;
            this.xEmpresaFin.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.xEmpresaFin.Width = 200;
            // 
            // xperiodo
            // 
            this.xperiodo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.xperiodo.DataPropertyName = "periodo";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.Format = "MM/yyyy";
            this.xperiodo.DefaultCellStyle = dataGridViewCellStyle3;
            this.xperiodo.HeaderText = "Periodo";
            this.xperiodo.MinimumWidth = 55;
            this.xperiodo.Name = "xperiodo";
            this.xperiodo.ReadOnly = true;
            this.xperiodo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.xperiodo.Width = 55;
            // 
            // xSueldo
            // 
            this.xSueldo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.xSueldo.DataPropertyName = "sueldo";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle4.Format = "n2";
            this.xSueldo.DefaultCellStyle = dataGridViewCellStyle4;
            this.xSueldo.HeaderText = "Sueldo";
            this.xSueldo.MinimumWidth = 55;
            this.xSueldo.Name = "xSueldo";
            this.xSueldo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.xSueldo.Width = 55;
            // 
            // xComision
            // 
            this.xComision.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.xComision.DataPropertyName = "comision";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle5.Format = "n2";
            this.xComision.DefaultCellStyle = dataGridViewCellStyle5;
            this.xComision.HeaderText = "Comisión";
            this.xComision.MinimumWidth = 60;
            this.xComision.Name = "xComision";
            this.xComision.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.xComision.Width = 60;
            // 
            // xBono
            // 
            this.xBono.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.xBono.DataPropertyName = "bono";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle6.Format = "n2";
            this.xBono.DefaultCellStyle = dataGridViewCellStyle6;
            this.xBono.HeaderText = "Bono";
            this.xBono.MinimumWidth = 55;
            this.xBono.Name = "xBono";
            this.xBono.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.xBono.Width = 55;
            // 
            // xRefacturar
            // 
            this.xRefacturar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.xRefacturar.DataPropertyName = "Refacturar";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle7.Format = "n2";
            this.xRefacturar.DefaultCellStyle = dataGridViewCellStyle7;
            this.xRefacturar.HeaderText = "Re-Fact";
            this.xRefacturar.MinimumWidth = 55;
            this.xRefacturar.Name = "xRefacturar";
            this.xRefacturar.Width = 55;
            // 
            // frmReporteComisiones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1004, 561);
            this.Controls.Add(this.btnexcel);
            this.Controls.Add(this.BtnCerrar);
            this.Controls.Add(this.lbltotalRegistros);
            this.Controls.Add(this.dtgconten);
            this.Controls.Add(this.btnPaso1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbohasta);
            this.Controls.Add(this.cbode);
            this.MinimumSize = new System.Drawing.Size(1020, 600);
            this.Name = "frmReporteComisiones";
            this.Nombre = "Reporte de Comisiones y Bonos";
            this.Text = "Reporte de Comisiones y Bonos";
            this.Load += new System.EventHandler(this.frmReporteComisiones_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgconten)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private HpResergerUserControls.Dtgconten dtgconten;
        private HpResergerUserControls.ButtonPer btnPaso1;
        private System.Windows.Forms.Label label4;
        private HpResergerUserControls.ComboMesAño cbode;
        private System.Windows.Forms.Label label1;
        private HpResergerUserControls.ComboMesAño cbohasta;
        private System.Windows.Forms.Label lbltotalRegistros;
        private HpResergerUserControls.ButtonPer BtnCerrar;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private HpResergerUserControls.ButtonPer btnexcel;
        private System.Windows.Forms.DataGridViewTextBoxColumn xok;
        private System.Windows.Forms.DataGridViewTextBoxColumn xpkid;
        private System.Windows.Forms.DataGridViewTextBoxColumn xtipoid;
        private System.Windows.Forms.DataGridViewTextBoxColumn xnumdoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn xNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn xpkEmpresa;
        private System.Windows.Forms.DataGridViewTextBoxColumn xEmpresaOrigen;
        private System.Windows.Forms.DataGridViewTextBoxColumn xfkempresa;
        private System.Windows.Forms.DataGridViewTextBoxColumn xEmpresaFin;
        private System.Windows.Forms.DataGridViewTextBoxColumn xperiodo;
        private System.Windows.Forms.DataGridViewTextBoxColumn xSueldo;
        private System.Windows.Forms.DataGridViewTextBoxColumn xComision;
        private System.Windows.Forms.DataGridViewTextBoxColumn xBono;
        private System.Windows.Forms.DataGridViewTextBoxColumn xRefacturar;
    }
}