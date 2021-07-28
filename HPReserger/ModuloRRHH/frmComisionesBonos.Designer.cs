namespace HPReserger.ModuloRRHH
{
    partial class frmComisionesBonos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.comboMesAño1 = new HpResergerUserControls.ComboMesAño();
            this.label4 = new System.Windows.Forms.Label();
            this.btnPaso1 = new HpResergerUserControls.ButtonPer();
            this.label1 = new System.Windows.Forms.Label();
            this.dtgconten = new HpResergerUserControls.Dtgconten();
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
            this.btnProcesar = new HpResergerUserControls.ButtonPer();
            this.BtnCerrar = new HpResergerUserControls.ButtonPer();
            this.lbltotalRegistros = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgconten)).BeginInit();
            this.SuspendLayout();
            // 
            // comboMesAño1
            // 
            this.comboMesAño1.BackColor = System.Drawing.Color.Transparent;
            this.comboMesAño1.FechaConDiaActual = new System.DateTime(2021, 7, 31, 0, 0, 0, 0);
            this.comboMesAño1.FechaFinMes = new System.DateTime(2021, 7, 31, 0, 0, 0, 0);
            this.comboMesAño1.FechaInicioMes = new System.DateTime(2021, 7, 1, 0, 0, 0, 0);
            this.comboMesAño1.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboMesAño1.Location = new System.Drawing.Point(12, 21);
            this.comboMesAño1.Name = "comboMesAño1";
            this.comboMesAño1.Size = new System.Drawing.Size(197, 26);
            this.comboMesAño1.TabIndex = 0;
            this.comboMesAño1.VerAño = true;
            this.comboMesAño1.VerMes = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(133, 13);
            this.label4.TabIndex = 353;
            this.label4.Text = "1.- Seleccione el Periodo";
            // 
            // btnPaso1
            // 
            this.btnPaso1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(129)))), ((int)(((byte)(189)))));
            this.btnPaso1.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnPaso1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPaso1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPaso1.ForeColor = System.Drawing.Color.White;
            this.btnPaso1.Location = new System.Drawing.Point(213, 23);
            this.btnPaso1.Margin = new System.Windows.Forms.Padding(0);
            this.btnPaso1.Name = "btnPaso1";
            this.btnPaso1.Size = new System.Drawing.Size(75, 22);
            this.btnPaso1.TabIndex = 354;
            this.btnPaso1.Tag = "1";
            this.btnPaso1.Text = "Avanzar";
            this.btnPaso1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnPaso1.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnPaso1.UseVisualStyleBackColor = false;
            this.btnPaso1.Click += new System.EventHandler(this.btnPaso1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(235, 13);
            this.label1.TabIndex = 353;
            this.label1.Text = "2.- Listo de Empleados, Bonos y Comisiones";
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
            this.xBono});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(207)))), ((int)(((byte)(241)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgconten.DefaultCellStyle = dataGridViewCellStyle6;
            this.dtgconten.EnableHeadersVisualStyles = false;
            this.dtgconten.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(179)))), ((int)(((byte)(215)))));
            this.dtgconten.Location = new System.Drawing.Point(13, 66);
            this.dtgconten.Name = "dtgconten";
            this.dtgconten.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dtgconten.RowHeadersVisible = false;
            this.dtgconten.RowTemplate.Height = 18;
            this.dtgconten.Size = new System.Drawing.Size(858, 484);
            this.dtgconten.TabIndex = 356;
            this.dtgconten.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dtgconten_EditingControlShowing);
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
            this.xtipoid.HeaderText = "tipoid";
            this.xtipoid.Name = "xtipoid";
            this.xtipoid.Visible = false;
            // 
            // xnumdoc
            // 
            this.xnumdoc.DataPropertyName = "numdoc";
            this.xnumdoc.HeaderText = "numdoc";
            this.xnumdoc.Name = "xnumdoc";
            this.xnumdoc.Visible = false;
            // 
            // xNombre
            // 
            this.xNombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.xNombre.DataPropertyName = "nombre";
            this.xNombre.HeaderText = "Nombre";
            this.xNombre.MinimumWidth = 180;
            this.xNombre.Name = "xNombre";
            this.xNombre.ReadOnly = true;
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
            this.xEmpresaOrigen.DataPropertyName = "empresaorigen";
            this.xEmpresaOrigen.HeaderText = "Empresa Planilla";
            this.xEmpresaOrigen.MinimumWidth = 200;
            this.xEmpresaOrigen.Name = "xEmpresaOrigen";
            this.xEmpresaOrigen.ReadOnly = true;
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
            this.xEmpresaFin.DataPropertyName = "empresafin";
            this.xEmpresaFin.HeaderText = "Empresa Comisiones";
            this.xEmpresaFin.MinimumWidth = 200;
            this.xEmpresaFin.Name = "xEmpresaFin";
            this.xEmpresaFin.ReadOnly = true;
            this.xEmpresaFin.Width = 200;
            // 
            // xperiodo
            // 
            this.xperiodo.DataPropertyName = "periodo";
            this.xperiodo.HeaderText = "Periodo";
            this.xperiodo.Name = "xperiodo";
            this.xperiodo.ReadOnly = true;
            this.xperiodo.Visible = false;
            // 
            // xSueldo
            // 
            this.xSueldo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.xSueldo.DataPropertyName = "sueldo";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.Format = "n2";
            this.xSueldo.DefaultCellStyle = dataGridViewCellStyle3;
            this.xSueldo.HeaderText = "Sueldo";
            this.xSueldo.MinimumWidth = 60;
            this.xSueldo.Name = "xSueldo";
            this.xSueldo.Width = 60;
            // 
            // xComision
            // 
            this.xComision.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.xComision.DataPropertyName = "comision";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle4.Format = "n2";
            this.xComision.DefaultCellStyle = dataGridViewCellStyle4;
            this.xComision.HeaderText = "Comisión";
            this.xComision.MinimumWidth = 60;
            this.xComision.Name = "xComision";
            this.xComision.Width = 60;
            // 
            // xBono
            // 
            this.xBono.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.xBono.DataPropertyName = "bono";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle5.Format = "n2";
            this.xBono.DefaultCellStyle = dataGridViewCellStyle5;
            this.xBono.HeaderText = "Bono";
            this.xBono.MinimumWidth = 60;
            this.xBono.Name = "xBono";
            this.xBono.Width = 60;
            // 
            // btnProcesar
            // 
            this.btnProcesar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnProcesar.BackColor = System.Drawing.Color.SeaGreen;
            this.btnProcesar.FlatAppearance.BorderColor = System.Drawing.Color.Olive;
            this.btnProcesar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProcesar.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProcesar.ForeColor = System.Drawing.Color.White;
            this.btnProcesar.Location = new System.Drawing.Point(701, 556);
            this.btnProcesar.Name = "btnProcesar";
            this.btnProcesar.Size = new System.Drawing.Size(83, 23);
            this.btnProcesar.TabIndex = 359;
            this.btnProcesar.Text = "Procesar";
            this.btnProcesar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnProcesar.UseVisualStyleBackColor = false;
            this.btnProcesar.Click += new System.EventHandler(this.btnProcesar_Click);
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
            this.BtnCerrar.Location = new System.Drawing.Point(788, 556);
            this.BtnCerrar.Name = "BtnCerrar";
            this.BtnCerrar.Size = new System.Drawing.Size(83, 23);
            this.BtnCerrar.TabIndex = 358;
            this.BtnCerrar.Text = "Cancelar";
            this.BtnCerrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnCerrar.UseVisualStyleBackColor = false;
            this.BtnCerrar.Click += new System.EventHandler(this.BtnCerrar_Click);
            // 
            // lbltotalRegistros
            // 
            this.lbltotalRegistros.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbltotalRegistros.AutoSize = true;
            this.lbltotalRegistros.BackColor = System.Drawing.Color.Transparent;
            this.lbltotalRegistros.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltotalRegistros.Location = new System.Drawing.Point(9, 566);
            this.lbltotalRegistros.Name = "lbltotalRegistros";
            this.lbltotalRegistros.Size = new System.Drawing.Size(86, 13);
            this.lbltotalRegistros.TabIndex = 363;
            this.lbltotalRegistros.Text = "Total Registros:";
            // 
            // frmComisionesBonos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 587);
            this.Controls.Add(this.lbltotalRegistros);
            this.Controls.Add(this.btnProcesar);
            this.Controls.Add(this.BtnCerrar);
            this.Controls.Add(this.dtgconten);
            this.Controls.Add(this.btnPaso1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboMesAño1);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmComisionesBonos";
            this.Nombre = "Carga de Comisiones y Bonos de Empleados";
            this.Text = "Carga de Comisiones y Bonos de Empleados";
            ((System.ComponentModel.ISupportInitialize)(this.dtgconten)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private HpResergerUserControls.ComboMesAño comboMesAño1;
        private System.Windows.Forms.Label label4;
        private HpResergerUserControls.ButtonPer btnPaso1;
        private System.Windows.Forms.Label label1;
        private HpResergerUserControls.Dtgconten dtgconten;
        private HpResergerUserControls.ButtonPer btnProcesar;
        private HpResergerUserControls.ButtonPer BtnCerrar;
        private System.Windows.Forms.Label lbltotalRegistros;
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
    }
}