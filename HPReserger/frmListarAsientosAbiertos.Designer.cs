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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmListarAsientosAbiertos));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dtgconten = new HpResergerUserControls.Dtgconten();
            this.uspListarAsientosAbiertosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.siGeDataSet1 = new HPReserger.SiGeDataSet1();
            this.label1 = new System.Windows.Forms.Label();
            this.btncancelar = new System.Windows.Forms.Button();
            this.btnactualizar = new System.Windows.Forms.Button();
            this.usp_ListarAsientosAbiertosTableAdapter = new HPReserger.SiGeDataSet1TableAdapters.usp_ListarAsientosAbiertosTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.btnAbrirx = new System.Windows.Forms.DataGridViewButtonColumn();
            this.idAsientoContableDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fechax = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.empresaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idEmpresaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(230)))), ((int)(((byte)(241)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(191)))), ((int)(((byte)(231)))));
            this.dtgconten.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgconten.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgconten.AutoGenerateColumns = false;
            this.dtgconten.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgconten.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(218)))), ((int)(((byte)(231)))));
            this.dtgconten.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgconten.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
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
            this.btnAbrirx,
            this.idAsientoContableDataGridViewTextBoxColumn,
            this.Fechax,
            this.empresaDataGridViewTextBoxColumn,
            this.idEmpresaDataGridViewTextBoxColumn});
            this.dtgconten.DataSource = this.uspListarAsientosAbiertosBindingSource;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(207)))), ((int)(((byte)(241)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgconten.DefaultCellStyle = dataGridViewCellStyle4;
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
            // idAsientoContableDataGridViewTextBoxColumn
            // 
            this.idAsientoContableDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.idAsientoContableDataGridViewTextBoxColumn.DataPropertyName = "Id_Asiento_Contable";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.idAsientoContableDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.idAsientoContableDataGridViewTextBoxColumn.HeaderText = "Nro Asiento";
            this.idAsientoContableDataGridViewTextBoxColumn.Name = "idAsientoContableDataGridViewTextBoxColumn";
            this.idAsientoContableDataGridViewTextBoxColumn.ReadOnly = true;
            this.idAsientoContableDataGridViewTextBoxColumn.Width = 94;
            // 
            // Fechax
            // 
            this.Fechax.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Fechax.DataPropertyName = "Fechon";
            this.Fechax.HeaderText = "Fecha";
            this.Fechax.Name = "Fechax";
            this.Fechax.ReadOnly = true;
            this.Fechax.Width = 62;
            // 
            // empresaDataGridViewTextBoxColumn
            // 
            this.empresaDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.empresaDataGridViewTextBoxColumn.DataPropertyName = "Empresa";
            this.empresaDataGridViewTextBoxColumn.HeaderText = "Empresa";
            this.empresaDataGridViewTextBoxColumn.Name = "empresaDataGridViewTextBoxColumn";
            this.empresaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idEmpresaDataGridViewTextBoxColumn
            // 
            this.idEmpresaDataGridViewTextBoxColumn.DataPropertyName = "Id_Empresa";
            this.idEmpresaDataGridViewTextBoxColumn.HeaderText = "Id_Empresa";
            this.idEmpresaDataGridViewTextBoxColumn.Name = "idEmpresaDataGridViewTextBoxColumn";
            this.idEmpresaDataGridViewTextBoxColumn.ReadOnly = true;
            this.idEmpresaDataGridViewTextBoxColumn.Visible = false;
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
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.DataGridViewTextBoxColumn saldoHaberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn btnAbrirx;
        private System.Windows.Forms.DataGridViewTextBoxColumn idAsientoContableDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fechax;
        private System.Windows.Forms.DataGridViewTextBoxColumn empresaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idEmpresaDataGridViewTextBoxColumn;
    }
}