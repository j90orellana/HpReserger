namespace HPReserger.ModuloFinanzas
{
    partial class frmPrestamosInterEmpresaListadoAbonados
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle25 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle26 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle32 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle27 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle28 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle29 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle30 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle31 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrestamosInterEmpresaListadoAbonados));
            this.dtgconten = new HpResergerUserControls.Dtgconten();
            this.xEmpresaOrigen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xbancoOrigen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xctaOrigenBanco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xCuoOrigen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xEmpresaDestino = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xBancoDestino = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xCtaBancoDestino = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xCuoDestino = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xMoneda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xMonto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xNroOperacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xFechaAbono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xGlosa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btncancelar = new System.Windows.Forms.Button();
            this.lblmsg = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnexcel = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.dtgconten)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgconten
            // 
            this.dtgconten.AllowUserToAddRows = false;
            this.dtgconten.AllowUserToOrderColumns = true;
            this.dtgconten.AllowUserToResizeColumns = false;
            this.dtgconten.AllowUserToResizeRows = false;
            dataGridViewCellStyle25.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(230)))), ((int)(((byte)(241)))));
            dataGridViewCellStyle25.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(191)))), ((int)(((byte)(231)))));
            this.dtgconten.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle25;
            this.dtgconten.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgconten.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgconten.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(218)))), ((int)(((byte)(231)))));
            this.dtgconten.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgconten.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.dtgconten.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle26.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle26.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(129)))), ((int)(((byte)(189)))));
            dataGridViewCellStyle26.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle26.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle26.SelectionBackColor = System.Drawing.Color.DeepSkyBlue;
            dataGridViewCellStyle26.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle26.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgconten.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle26;
            this.dtgconten.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgconten.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.xEmpresaOrigen,
            this.xbancoOrigen,
            this.xctaOrigenBanco,
            this.xCuoOrigen,
            this.xEmpresaDestino,
            this.xBancoDestino,
            this.xCtaBancoDestino,
            this.xCuoDestino,
            this.xMoneda,
            this.xMonto,
            this.xNroOperacion,
            this.xFechaAbono,
            this.xGlosa});
            dataGridViewCellStyle32.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle32.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle32.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle32.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle32.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(207)))), ((int)(((byte)(241)))));
            dataGridViewCellStyle32.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle32.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgconten.DefaultCellStyle = dataGridViewCellStyle32;
            this.dtgconten.EnableHeadersVisualStyles = false;
            this.dtgconten.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(179)))), ((int)(((byte)(215)))));
            this.dtgconten.Location = new System.Drawing.Point(12, 38);
            this.dtgconten.Name = "dtgconten";
            this.dtgconten.ReadOnly = true;
            this.dtgconten.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dtgconten.RowHeadersVisible = false;
            this.dtgconten.RowTemplate.Height = 18;
            this.dtgconten.Size = new System.Drawing.Size(960, 287);
            this.dtgconten.TabIndex = 397;
            this.dtgconten.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgconten_CellContentClick);
            // 
            // xEmpresaOrigen
            // 
            this.xEmpresaOrigen.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.xEmpresaOrigen.DataPropertyName = "empresaorigen";
            this.xEmpresaOrigen.HeaderText = "EmpresaOrigen";
            this.xEmpresaOrigen.Name = "xEmpresaOrigen";
            this.xEmpresaOrigen.ReadOnly = true;
            this.xEmpresaOrigen.Width = 110;
            // 
            // xbancoOrigen
            // 
            this.xbancoOrigen.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.xbancoOrigen.DataPropertyName = "BancoOrigen";
            this.xbancoOrigen.HeaderText = "BancoOrigen";
            this.xbancoOrigen.MinimumWidth = 100;
            this.xbancoOrigen.Name = "xbancoOrigen";
            this.xbancoOrigen.ReadOnly = true;
            // 
            // xctaOrigenBanco
            // 
            this.xctaOrigenBanco.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.xctaOrigenBanco.DataPropertyName = "CtaBancoOrigen";
            dataGridViewCellStyle27.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.xctaOrigenBanco.DefaultCellStyle = dataGridViewCellStyle27;
            this.xctaOrigenBanco.FillWeight = 563.1068F;
            this.xctaOrigenBanco.HeaderText = "CtaBancoOrigen";
            this.xctaOrigenBanco.MinimumWidth = 90;
            this.xctaOrigenBanco.Name = "xctaOrigenBanco";
            this.xctaOrigenBanco.ReadOnly = true;
            this.xctaOrigenBanco.Width = 116;
            // 
            // xCuoOrigen
            // 
            this.xCuoOrigen.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.xCuoOrigen.DataPropertyName = "CuoOrigen";
            this.xCuoOrigen.FillWeight = 48.54369F;
            this.xCuoOrigen.HeaderText = "CuoOrigen";
            this.xCuoOrigen.MinimumWidth = 70;
            this.xCuoOrigen.Name = "xCuoOrigen";
            this.xCuoOrigen.ReadOnly = true;
            this.xCuoOrigen.Width = 70;
            // 
            // xEmpresaDestino
            // 
            this.xEmpresaDestino.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.xEmpresaDestino.DataPropertyName = "empresadestino";
            this.xEmpresaDestino.HeaderText = "EmpresaDestino";
            this.xEmpresaDestino.Name = "xEmpresaDestino";
            this.xEmpresaDestino.ReadOnly = true;
            this.xEmpresaDestino.Width = 114;
            // 
            // xBancoDestino
            // 
            this.xBancoDestino.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.xBancoDestino.DataPropertyName = "BancoDestino";
            this.xBancoDestino.FillWeight = 48.54369F;
            this.xBancoDestino.HeaderText = "BancoDestino";
            this.xBancoDestino.MinimumWidth = 100;
            this.xBancoDestino.Name = "xBancoDestino";
            this.xBancoDestino.ReadOnly = true;
            this.xBancoDestino.Width = 103;
            // 
            // xCtaBancoDestino
            // 
            this.xCtaBancoDestino.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.xCtaBancoDestino.DataPropertyName = "CtaBancoDestino";
            this.xCtaBancoDestino.FillWeight = 48.54369F;
            this.xCtaBancoDestino.HeaderText = "CtaBancoDestino";
            this.xCtaBancoDestino.Name = "xCtaBancoDestino";
            this.xCtaBancoDestino.ReadOnly = true;
            this.xCtaBancoDestino.Width = 120;
            // 
            // xCuoDestino
            // 
            this.xCuoDestino.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.xCuoDestino.DataPropertyName = "CuoDestino";
            dataGridViewCellStyle28.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.xCuoDestino.DefaultCellStyle = dataGridViewCellStyle28;
            this.xCuoDestino.FillWeight = 48.54369F;
            this.xCuoDestino.HeaderText = "CuoDestino";
            this.xCuoDestino.MinimumWidth = 70;
            this.xCuoDestino.Name = "xCuoDestino";
            this.xCuoDestino.ReadOnly = true;
            this.xCuoDestino.Width = 70;
            // 
            // xMoneda
            // 
            this.xMoneda.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.xMoneda.DataPropertyName = "Moneda";
            dataGridViewCellStyle29.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.xMoneda.DefaultCellStyle = dataGridViewCellStyle29;
            this.xMoneda.FillWeight = 48.54369F;
            this.xMoneda.HeaderText = "Moneda";
            this.xMoneda.MinimumWidth = 70;
            this.xMoneda.Name = "xMoneda";
            this.xMoneda.ReadOnly = true;
            this.xMoneda.Width = 70;
            // 
            // xMonto
            // 
            this.xMonto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.xMonto.DataPropertyName = "Monto";
            dataGridViewCellStyle30.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle30.Format = "n2";
            this.xMonto.DefaultCellStyle = dataGridViewCellStyle30;
            this.xMonto.FillWeight = 48.54369F;
            this.xMonto.HeaderText = "Monto";
            this.xMonto.MinimumWidth = 60;
            this.xMonto.Name = "xMonto";
            this.xMonto.ReadOnly = true;
            this.xMonto.Width = 60;
            // 
            // xNroOperacion
            // 
            this.xNroOperacion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.xNroOperacion.DataPropertyName = "NroOperacion";
            this.xNroOperacion.FillWeight = 48.54369F;
            this.xNroOperacion.HeaderText = "NroOp.";
            this.xNroOperacion.Name = "xNroOperacion";
            this.xNroOperacion.ReadOnly = true;
            this.xNroOperacion.Width = 69;
            // 
            // xFechaAbono
            // 
            this.xFechaAbono.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.xFechaAbono.DataPropertyName = "FechaAbono";
            dataGridViewCellStyle31.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle31.Format = "d";
            this.xFechaAbono.DefaultCellStyle = dataGridViewCellStyle31;
            this.xFechaAbono.FillWeight = 48.54369F;
            this.xFechaAbono.HeaderText = "Fecha Abono";
            this.xFechaAbono.MinimumWidth = 75;
            this.xFechaAbono.Name = "xFechaAbono";
            this.xFechaAbono.ReadOnly = true;
            this.xFechaAbono.Width = 75;
            // 
            // xGlosa
            // 
            this.xGlosa.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.xGlosa.DataPropertyName = "glosa";
            this.xGlosa.FillWeight = 48.54369F;
            this.xGlosa.HeaderText = "Glosa";
            this.xGlosa.MinimumWidth = 100;
            this.xGlosa.Name = "xGlosa";
            this.xGlosa.ReadOnly = true;
            // 
            // btncancelar
            // 
            this.btncancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btncancelar.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncancelar.Image = ((System.Drawing.Image)(resources.GetObject("btncancelar.Image")));
            this.btncancelar.Location = new System.Drawing.Point(887, 331);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(85, 23);
            this.btncancelar.TabIndex = 398;
            this.btncancelar.Text = "Cancelar";
            this.btncancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btncancelar.UseVisualStyleBackColor = true;
            // 
            // lblmsg
            // 
            this.lblmsg.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblmsg.AutoSize = true;
            this.lblmsg.BackColor = System.Drawing.Color.Transparent;
            this.lblmsg.Location = new System.Drawing.Point(12, 336);
            this.lblmsg.Name = "lblmsg";
            this.lblmsg.Size = new System.Drawing.Size(113, 13);
            this.lblmsg.TabIndex = 399;
            this.lblmsg.Text = "Total de Registros : 0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 13);
            this.label3.TabIndex = 400;
            this.label3.Text = "Listado de Abonos:";
            // 
            // btnActualizar
            // 
            this.btnActualizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnActualizar.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizar.Image = ((System.Drawing.Image)(resources.GetObject("btnActualizar.Image")));
            this.btnActualizar.Location = new System.Drawing.Point(880, 12);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(92, 23);
            this.btnActualizar.TabIndex = 406;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnexcel
            // 
            this.btnexcel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnexcel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnexcel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnexcel.Image = ((System.Drawing.Image)(resources.GetObject("btnexcel.Image")));
            this.btnexcel.Location = new System.Drawing.Point(451, 331);
            this.btnexcel.Name = "btnexcel";
            this.btnexcel.Size = new System.Drawing.Size(82, 23);
            this.btnexcel.TabIndex = 407;
            this.btnexcel.Text = "Excel";
            this.btnexcel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnexcel.UseVisualStyleBackColor = true;
            this.btnexcel.Click += new System.EventHandler(this.btnexcel_Click);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // frmPrestamosInterEmpresaListadoAbonados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 361);
            this.Controls.Add(this.btnexcel);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblmsg);
            this.Controls.Add(this.btncancelar);
            this.Controls.Add(this.dtgconten);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinimumSize = new System.Drawing.Size(1000, 400);
            this.Name = "frmPrestamosInterEmpresaListadoAbonados";
            this.Nombre = "Listado de Abonos de PrestamosInterEmpresa";
            this.Text = "Listado de Abonos de PrestamosInterEmpresa";
            this.Load += new System.EventHandler(this.frmPrestamosInterEmpresaListadoAbonados_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgconten)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private HpResergerUserControls.Dtgconten dtgconten;
        private System.Windows.Forms.DataGridViewTextBoxColumn xEmpresaOrigen;
        private System.Windows.Forms.DataGridViewTextBoxColumn xbancoOrigen;
        private System.Windows.Forms.DataGridViewTextBoxColumn xctaOrigenBanco;
        private System.Windows.Forms.DataGridViewTextBoxColumn xCuoOrigen;
        private System.Windows.Forms.DataGridViewTextBoxColumn xEmpresaDestino;
        private System.Windows.Forms.DataGridViewTextBoxColumn xBancoDestino;
        private System.Windows.Forms.DataGridViewTextBoxColumn xCtaBancoDestino;
        private System.Windows.Forms.DataGridViewTextBoxColumn xCuoDestino;
        private System.Windows.Forms.DataGridViewTextBoxColumn xMoneda;
        private System.Windows.Forms.DataGridViewTextBoxColumn xMonto;
        private System.Windows.Forms.DataGridViewTextBoxColumn xNroOperacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn xFechaAbono;
        private System.Windows.Forms.DataGridViewTextBoxColumn xGlosa;
        private System.Windows.Forms.Button btncancelar;
        private System.Windows.Forms.Label lblmsg;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnexcel;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}