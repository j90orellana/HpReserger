namespace HPReserger
{
    partial class frmListarAsientosAbiertos
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmListarAsientosAbiertos));
            this.dtgconten = new HpResergerUserControls.Dtgconten();
            this.btnAbrirx = new System.Windows.Forms.DataGridViewButtonColumn();
            this.idAsientoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idAsientoContableDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaAsientoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaAsientoValorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.empresaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cuentaContableDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.saldoDebeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.saldoHaberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idDinamicaContableDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idproyectoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fkidEtapaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nroDocumentoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estadoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idEmpresaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uspListarAsientosAbiertosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.siGeDataSet1 = new HPReserger.SiGeDataSet1();
            this.label1 = new System.Windows.Forms.Label();
            this.btncancelar = new System.Windows.Forms.Button();
            this.btnactualizar = new System.Windows.Forms.Button();
            this.usp_ListarAsientosAbiertosTableAdapter = new HPReserger.SiGeDataSet1TableAdapters.usp_ListarAsientosAbiertosTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.dtgconten)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uspListarAsientosAbiertosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.siGeDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgconten
            // 
            this.dtgconten.AllowUserToAddRows = false;
            this.dtgconten.AllowUserToOrderColumns = true;
            this.dtgconten.AllowUserToResizeColumns = false;
            this.dtgconten.AllowUserToResizeRows = false;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(230)))), ((int)(((byte)(241)))));
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(191)))), ((int)(((byte)(231)))));
            this.dtgconten.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.dtgconten.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgconten.AutoGenerateColumns = false;
            this.dtgconten.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgconten.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(218)))), ((int)(((byte)(231)))));
            this.dtgconten.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgconten.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.dtgconten.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(129)))), ((int)(((byte)(189)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.DeepSkyBlue;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgconten.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dtgconten.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dtgconten.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.btnAbrirx,
            this.idAsientoDataGridViewTextBoxColumn,
            this.idAsientoContableDataGridViewTextBoxColumn,
            this.fechaAsientoDataGridViewTextBoxColumn,
            this.fechaAsientoValorDataGridViewTextBoxColumn,
            this.empresaDataGridViewTextBoxColumn,
            this.cuentaContableDataGridViewTextBoxColumn,
            this.saldoDebeDataGridViewTextBoxColumn,
            this.saldoHaberDataGridViewTextBoxColumn,
            this.idDinamicaContableDataGridViewTextBoxColumn,
            this.idproyectoDataGridViewTextBoxColumn,
            this.fkidEtapaDataGridViewTextBoxColumn,
            this.nroDocumentoDataGridViewTextBoxColumn,
            this.estadoDataGridViewTextBoxColumn,
            this.idEmpresaDataGridViewTextBoxColumn});
            this.dtgconten.DataSource = this.uspListarAsientosAbiertosBindingSource;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(207)))), ((int)(((byte)(241)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgconten.DefaultCellStyle = dataGridViewCellStyle12;
            this.dtgconten.EnableHeadersVisualStyles = false;
            this.dtgconten.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(179)))), ((int)(((byte)(215)))));
            this.dtgconten.Location = new System.Drawing.Point(12, 30);
            this.dtgconten.Name = "dtgconten";
            this.dtgconten.ReadOnly = true;
            this.dtgconten.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dtgconten.RowHeadersVisible = false;
            this.dtgconten.RowTemplate.Height = 18;
            this.dtgconten.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dtgconten.Size = new System.Drawing.Size(699, 432);
            this.dtgconten.TabIndex = 0;
            this.dtgconten.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgconten_CellContentClick);
            this.dtgconten.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgconten_CellContentDoubleClick);
            // 
            // btnAbrirx
            // 
            this.btnAbrirx.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.btnAbrirx.HeaderText = "";
            this.btnAbrirx.MinimumWidth = 50;
            this.btnAbrirx.Name = "btnAbrirx";
            this.btnAbrirx.ReadOnly = true;
            this.btnAbrirx.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.btnAbrirx.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.btnAbrirx.Text = "Abrir";
            this.btnAbrirx.UseColumnTextForButtonValue = true;
            this.btnAbrirx.Width = 50;
            // 
            // idAsientoDataGridViewTextBoxColumn
            // 
            this.idAsientoDataGridViewTextBoxColumn.DataPropertyName = "id_Asiento";
            this.idAsientoDataGridViewTextBoxColumn.HeaderText = "id_Asiento";
            this.idAsientoDataGridViewTextBoxColumn.Name = "idAsientoDataGridViewTextBoxColumn";
            this.idAsientoDataGridViewTextBoxColumn.ReadOnly = true;
            this.idAsientoDataGridViewTextBoxColumn.Visible = false;
            // 
            // idAsientoContableDataGridViewTextBoxColumn
            // 
            this.idAsientoContableDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.idAsientoContableDataGridViewTextBoxColumn.DataPropertyName = "Id_Asiento_Contable";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.idAsientoContableDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle9;
            this.idAsientoContableDataGridViewTextBoxColumn.HeaderText = "CUO";
            this.idAsientoContableDataGridViewTextBoxColumn.Name = "idAsientoContableDataGridViewTextBoxColumn";
            this.idAsientoContableDataGridViewTextBoxColumn.ReadOnly = true;
            this.idAsientoContableDataGridViewTextBoxColumn.Width = 56;
            // 
            // fechaAsientoDataGridViewTextBoxColumn
            // 
            this.fechaAsientoDataGridViewTextBoxColumn.DataPropertyName = "Fecha_Asiento";
            this.fechaAsientoDataGridViewTextBoxColumn.HeaderText = "Fecha_Asiento";
            this.fechaAsientoDataGridViewTextBoxColumn.Name = "fechaAsientoDataGridViewTextBoxColumn";
            this.fechaAsientoDataGridViewTextBoxColumn.ReadOnly = true;
            this.fechaAsientoDataGridViewTextBoxColumn.Visible = false;
            // 
            // fechaAsientoValorDataGridViewTextBoxColumn
            // 
            this.fechaAsientoValorDataGridViewTextBoxColumn.DataPropertyName = "Fecha_Asiento_Valor";
            this.fechaAsientoValorDataGridViewTextBoxColumn.HeaderText = "Fecha_Asiento_Valor";
            this.fechaAsientoValorDataGridViewTextBoxColumn.Name = "fechaAsientoValorDataGridViewTextBoxColumn";
            this.fechaAsientoValorDataGridViewTextBoxColumn.ReadOnly = true;
            this.fechaAsientoValorDataGridViewTextBoxColumn.Visible = false;
            // 
            // empresaDataGridViewTextBoxColumn
            // 
            this.empresaDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.empresaDataGridViewTextBoxColumn.DataPropertyName = "Empresa";
            this.empresaDataGridViewTextBoxColumn.HeaderText = "Empresa";
            this.empresaDataGridViewTextBoxColumn.Name = "empresaDataGridViewTextBoxColumn";
            this.empresaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cuentaContableDataGridViewTextBoxColumn
            // 
            this.cuentaContableDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.cuentaContableDataGridViewTextBoxColumn.DataPropertyName = "Cuenta_Contable";
            this.cuentaContableDataGridViewTextBoxColumn.HeaderText = "Cuenta Contable";
            this.cuentaContableDataGridViewTextBoxColumn.Name = "cuentaContableDataGridViewTextBoxColumn";
            this.cuentaContableDataGridViewTextBoxColumn.ReadOnly = true;
            this.cuentaContableDataGridViewTextBoxColumn.Width = 120;
            // 
            // saldoDebeDataGridViewTextBoxColumn
            // 
            this.saldoDebeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.saldoDebeDataGridViewTextBoxColumn.DataPropertyName = "Saldo_Debe";
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle10.Format = "n2";
            this.saldoDebeDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle10;
            this.saldoDebeDataGridViewTextBoxColumn.HeaderText = "Saldo Debe";
            this.saldoDebeDataGridViewTextBoxColumn.Name = "saldoDebeDataGridViewTextBoxColumn";
            this.saldoDebeDataGridViewTextBoxColumn.ReadOnly = true;
            this.saldoDebeDataGridViewTextBoxColumn.Width = 90;
            // 
            // saldoHaberDataGridViewTextBoxColumn
            // 
            this.saldoHaberDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.saldoHaberDataGridViewTextBoxColumn.DataPropertyName = "Saldo_Haber";
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle11.Format = "n2";
            this.saldoHaberDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle11;
            this.saldoHaberDataGridViewTextBoxColumn.HeaderText = "Saldo Haber";
            this.saldoHaberDataGridViewTextBoxColumn.Name = "saldoHaberDataGridViewTextBoxColumn";
            this.saldoHaberDataGridViewTextBoxColumn.ReadOnly = true;
            this.saldoHaberDataGridViewTextBoxColumn.Width = 95;
            // 
            // idDinamicaContableDataGridViewTextBoxColumn
            // 
            this.idDinamicaContableDataGridViewTextBoxColumn.DataPropertyName = "Id_Dinamica_Contable";
            this.idDinamicaContableDataGridViewTextBoxColumn.HeaderText = "Id_Dinamica_Contable";
            this.idDinamicaContableDataGridViewTextBoxColumn.Name = "idDinamicaContableDataGridViewTextBoxColumn";
            this.idDinamicaContableDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDinamicaContableDataGridViewTextBoxColumn.Visible = false;
            // 
            // idproyectoDataGridViewTextBoxColumn
            // 
            this.idproyectoDataGridViewTextBoxColumn.DataPropertyName = "id_proyecto";
            this.idproyectoDataGridViewTextBoxColumn.HeaderText = "id_proyecto";
            this.idproyectoDataGridViewTextBoxColumn.Name = "idproyectoDataGridViewTextBoxColumn";
            this.idproyectoDataGridViewTextBoxColumn.ReadOnly = true;
            this.idproyectoDataGridViewTextBoxColumn.Visible = false;
            // 
            // fkidEtapaDataGridViewTextBoxColumn
            // 
            this.fkidEtapaDataGridViewTextBoxColumn.DataPropertyName = "fk_id_Etapa";
            this.fkidEtapaDataGridViewTextBoxColumn.HeaderText = "fk_id_Etapa";
            this.fkidEtapaDataGridViewTextBoxColumn.Name = "fkidEtapaDataGridViewTextBoxColumn";
            this.fkidEtapaDataGridViewTextBoxColumn.ReadOnly = true;
            this.fkidEtapaDataGridViewTextBoxColumn.Visible = false;
            // 
            // nroDocumentoDataGridViewTextBoxColumn
            // 
            this.nroDocumentoDataGridViewTextBoxColumn.DataPropertyName = "Nro_Documento";
            this.nroDocumentoDataGridViewTextBoxColumn.HeaderText = "Nro_Documento";
            this.nroDocumentoDataGridViewTextBoxColumn.Name = "nroDocumentoDataGridViewTextBoxColumn";
            this.nroDocumentoDataGridViewTextBoxColumn.ReadOnly = true;
            this.nroDocumentoDataGridViewTextBoxColumn.Visible = false;
            // 
            // estadoDataGridViewTextBoxColumn
            // 
            this.estadoDataGridViewTextBoxColumn.DataPropertyName = "Estado";
            this.estadoDataGridViewTextBoxColumn.HeaderText = "Estado";
            this.estadoDataGridViewTextBoxColumn.Name = "estadoDataGridViewTextBoxColumn";
            this.estadoDataGridViewTextBoxColumn.ReadOnly = true;
            this.estadoDataGridViewTextBoxColumn.Visible = false;
            // 
            // idEmpresaDataGridViewTextBoxColumn
            // 
            this.idEmpresaDataGridViewTextBoxColumn.DataPropertyName = "Id_Empresa";
            this.idEmpresaDataGridViewTextBoxColumn.HeaderText = "Id_Empresa";
            this.idEmpresaDataGridViewTextBoxColumn.Name = "idEmpresaDataGridViewTextBoxColumn";
            this.idEmpresaDataGridViewTextBoxColumn.ReadOnly = true;
            this.idEmpresaDataGridViewTextBoxColumn.Visible = false;
            // 
            // uspListarAsientosAbiertosBindingSource
            // 
            this.uspListarAsientosAbiertosBindingSource.DataMember = "usp_ListarAsientosAbiertos";
            this.uspListarAsientosAbiertosBindingSource.DataSource = this.siGeDataSet1;
            // 
            // siGeDataSet1
            // 
            this.siGeDataSet1.DataSetName = "SiGeDataSet1";
            this.siGeDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "LISTADO DE ASIENTOS ABIERTOS\r\n";
            // 
            // btncancelar
            // 
            this.btncancelar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btncancelar.Image = ((System.Drawing.Image)(resources.GetObject("btncancelar.Image")));
            this.btncancelar.Location = new System.Drawing.Point(324, 468);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(75, 23);
            this.btncancelar.TabIndex = 39;
            this.btncancelar.Text = "Cancelar";
            this.btncancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btncancelar.UseVisualStyleBackColor = true;
            this.btncancelar.Click += new System.EventHandler(this.btncancelar_Click);
            // 
            // btnactualizar
            // 
            this.btnactualizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnactualizar.Image = ((System.Drawing.Image)(resources.GetObject("btnactualizar.Image")));
            this.btnactualizar.Location = new System.Drawing.Point(632, 4);
            this.btnactualizar.Name = "btnactualizar";
            this.btnactualizar.Size = new System.Drawing.Size(79, 23);
            this.btnactualizar.TabIndex = 40;
            this.btnactualizar.Text = "Actualizar";
            this.btnactualizar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnactualizar.UseVisualStyleBackColor = true;
            this.btnactualizar.Click += new System.EventHandler(this.btnactualizar_Click);
            // 
            // usp_ListarAsientosAbiertosTableAdapter
            // 
            this.usp_ListarAsientosAbiertosTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(551, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 45;
            this.button1.Text = "Excel";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // frmListarAsientosAbiertos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(723, 497);
            this.Colores = new System.Drawing.Color[0];
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnactualizar);
            this.Controls.Add(this.btncancelar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtgconten);
            this.Name = "frmListarAsientosAbiertos";
            this.Nombre = "Listado de Asientos Abiertos";
            this.Text = "Listado de Asientos Abiertos";
            this.Load += new System.EventHandler(this.frmListarAsientosAbiertos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgconten)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uspListarAsientosAbiertosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.siGeDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private HpResergerUserControls.Dtgconten dtgconten;
        private System.Windows.Forms.BindingSource uspListarAsientosAbiertosBindingSource;
        private SiGeDataSet1 siGeDataSet1;
        private System.Windows.Forms.Label label1;
        private SiGeDataSet1TableAdapters.usp_ListarAsientosAbiertosTableAdapter usp_ListarAsientosAbiertosTableAdapter;
        private System.Windows.Forms.Button btncancelar;
        private System.Windows.Forms.Button btnactualizar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewButtonColumn btnAbrirx;
        private System.Windows.Forms.DataGridViewTextBoxColumn idAsientoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idAsientoContableDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaAsientoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaAsientoValorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn empresaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cuentaContableDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn saldoDebeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn saldoHaberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDinamicaContableDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idproyectoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fkidEtapaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nroDocumentoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn estadoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idEmpresaDataGridViewTextBoxColumn;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}