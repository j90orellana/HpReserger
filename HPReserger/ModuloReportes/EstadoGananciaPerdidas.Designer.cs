namespace HPReserger
{
    partial class EstadoGananciaPerdidas
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EstadoGananciaPerdidas));
            this.label1 = new System.Windows.Forms.Label();
            this.lblfechasReporte = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtgconten = new System.Windows.Forms.DataGridView();
            this.indexx = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Camposx = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Totalesx = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.empresax = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btncancelar = new System.Windows.Forms.Button();
            this.btnexportarexcel = new System.Windows.Forms.Button();
            this.btnexportarpdf = new System.Windows.Forms.Button();
            this.lblconteo = new System.Windows.Forms.Label();
            this.btnGenerar = new System.Windows.Forms.Button();
            this.cboempresas = new System.Windows.Forms.ComboBox();
            this.ColorDialog = new System.Windows.Forms.ColorDialog();
            this.btnColorFondo = new System.Windows.Forms.Button();
            this.btnColorLetra = new System.Windows.Forms.Button();
            this.comboMesAño = new HpResergerUserControls.ComboMesAño();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.dtgconten)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(136, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(242, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "ESTADO DE RESULTADO INTEGRAL";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblfechasReporte
            // 
            this.lblfechasReporte.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblfechasReporte.AutoSize = true;
            this.lblfechasReporte.BackColor = System.Drawing.Color.Transparent;
            this.lblfechasReporte.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfechasReporte.Location = new System.Drawing.Point(145, 67);
            this.lblfechasReporte.Name = "lblfechasReporte";
            this.lblfechasReporte.Size = new System.Drawing.Size(32, 13);
            this.lblfechasReporte.TabIndex = 1;
            this.lblfechasReporte.Text = "Al 31";
            this.lblfechasReporte.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblfechasReporte.TextChanged += new System.EventHandler(this.label2_TextChanged);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(201, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "(Expresado en Soles)";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dtgconten
            // 
            this.dtgconten.AllowUserToAddRows = false;
            this.dtgconten.AllowUserToDeleteRows = false;
            this.dtgconten.AllowUserToResizeColumns = false;
            this.dtgconten.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.dtgconten.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgconten.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgconten.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgconten.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dtgconten.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dtgconten.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dtgconten.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(239)))), ((int)(((byte)(206)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(65)))), ((int)(((byte)(104)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.dtgconten.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dtgconten.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dtgconten.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.indexx,
            this.Camposx,
            this.Totalesx,
            this.empresax});
            this.dtgconten.Cursor = System.Windows.Forms.Cursors.Default;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgconten.DefaultCellStyle = dataGridViewCellStyle4;
            this.dtgconten.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dtgconten.EnableHeadersVisualStyles = false;
            this.dtgconten.GridColor = System.Drawing.Color.DimGray;
            this.dtgconten.Location = new System.Drawing.Point(12, 100);
            this.dtgconten.Name = "dtgconten";
            this.dtgconten.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dtgconten.RowHeadersVisible = false;
            this.dtgconten.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToFirstHeader;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtgconten.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dtgconten.RowTemplate.Height = 18;
            this.dtgconten.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dtgconten.Size = new System.Drawing.Size(490, 554);
            this.dtgconten.TabIndex = 61;
            this.dtgconten.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgconten_RowEnter);
            // 
            // indexx
            // 
            this.indexx.DataPropertyName = "i";
            this.indexx.HeaderText = "index";
            this.indexx.Name = "indexx";
            this.indexx.Visible = false;
            // 
            // Camposx
            // 
            this.Camposx.DataPropertyName = "campo";
            this.Camposx.HeaderText = "";
            this.Camposx.Name = "Camposx";
            this.Camposx.ReadOnly = true;
            this.Camposx.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Totalesx
            // 
            this.Totalesx.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Totalesx.DataPropertyName = "total";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.Format = "n2";
            this.Totalesx.DefaultCellStyle = dataGridViewCellStyle3;
            this.Totalesx.FillWeight = 200F;
            this.Totalesx.HeaderText = "TOTALES";
            this.Totalesx.MinimumWidth = 200;
            this.Totalesx.Name = "Totalesx";
            this.Totalesx.ReadOnly = true;
            this.Totalesx.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Totalesx.Width = 200;
            // 
            // empresax
            // 
            this.empresax.DataPropertyName = "Empresa";
            this.empresax.HeaderText = "Empresa";
            this.empresax.Name = "empresax";
            this.empresax.Visible = false;
            // 
            // btncancelar
            // 
            this.btncancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btncancelar.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncancelar.Image = ((System.Drawing.Image)(resources.GetObject("btncancelar.Image")));
            this.btncancelar.Location = new System.Drawing.Point(423, 660);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(79, 23);
            this.btncancelar.TabIndex = 64;
            this.btncancelar.Text = "Cancelar";
            this.btncancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btncancelar.UseVisualStyleBackColor = true;
            this.btncancelar.Click += new System.EventHandler(this.btncancelar_Click);
            // 
            // btnexportarexcel
            // 
            this.btnexportarexcel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnexportarexcel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnexportarexcel.Image = ((System.Drawing.Image)(resources.GetObject("btnexportarexcel.Image")));
            this.btnexportarexcel.Location = new System.Drawing.Point(199, 660);
            this.btnexportarexcel.Name = "btnexportarexcel";
            this.btnexportarexcel.Size = new System.Drawing.Size(79, 23);
            this.btnexportarexcel.TabIndex = 65;
            this.btnexportarexcel.Text = "Excel";
            this.btnexportarexcel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnexportarexcel.UseVisualStyleBackColor = true;
            this.btnexportarexcel.Click += new System.EventHandler(this.btnexportarexcel_Click);
            // 
            // btnexportarpdf
            // 
            this.btnexportarpdf.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnexportarpdf.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnexportarpdf.Image = ((System.Drawing.Image)(resources.GetObject("btnexportarpdf.Image")));
            this.btnexportarpdf.Location = new System.Drawing.Point(282, 660);
            this.btnexportarpdf.Name = "btnexportarpdf";
            this.btnexportarpdf.Size = new System.Drawing.Size(79, 23);
            this.btnexportarpdf.TabIndex = 67;
            this.btnexportarpdf.Text = "Pdf";
            this.btnexportarpdf.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnexportarpdf.UseVisualStyleBackColor = true;
            this.btnexportarpdf.Visible = false;
            this.btnexportarpdf.Click += new System.EventHandler(this.btnexportarpdf_Click);
            // 
            // lblconteo
            // 
            this.lblconteo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblconteo.AutoSize = true;
            this.lblconteo.BackColor = System.Drawing.Color.Transparent;
            this.lblconteo.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblconteo.Location = new System.Drawing.Point(16, 665);
            this.lblconteo.Name = "lblconteo";
            this.lblconteo.Size = new System.Drawing.Size(130, 13);
            this.lblconteo.TabIndex = 68;
            this.lblconteo.Text = "Número de Registros:  0";
            // 
            // btnGenerar
            // 
            this.btnGenerar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGenerar.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerar.Image = ((System.Drawing.Image)(resources.GetObject("btnGenerar.Image")));
            this.btnGenerar.Location = new System.Drawing.Point(423, 71);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(79, 23);
            this.btnGenerar.TabIndex = 69;
            this.btnGenerar.Text = "Generar";
            this.btnGenerar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGenerar.UseVisualStyleBackColor = true;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // cboempresas
            // 
            this.cboempresas.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cboempresas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboempresas.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboempresas.FormattingEnabled = true;
            this.cboempresas.Location = new System.Drawing.Point(108, 12);
            this.cboempresas.Name = "cboempresas";
            this.cboempresas.Size = new System.Drawing.Size(299, 28);
            this.cboempresas.TabIndex = 70;
            this.cboempresas.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.cboempresas_DrawItem);
            // 
            // btnColorFondo
            // 
            this.btnColorFondo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnColorFondo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnColorFondo.BackgroundImage")));
            this.btnColorFondo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnColorFondo.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnColorFondo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnColorFondo.Location = new System.Drawing.Point(363, 660);
            this.btnColorFondo.Name = "btnColorFondo";
            this.btnColorFondo.Size = new System.Drawing.Size(24, 23);
            this.btnColorFondo.TabIndex = 89;
            this.btnColorFondo.UseVisualStyleBackColor = true;
            this.btnColorFondo.Click += new System.EventHandler(this.txtfondo_TextChanged);
            // 
            // btnColorLetra
            // 
            this.btnColorLetra.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnColorLetra.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnColorLetra.BackgroundImage")));
            this.btnColorLetra.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnColorLetra.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnColorLetra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnColorLetra.Location = new System.Drawing.Point(393, 660);
            this.btnColorLetra.Name = "btnColorLetra";
            this.btnColorLetra.Size = new System.Drawing.Size(24, 23);
            this.btnColorLetra.TabIndex = 88;
            this.btnColorLetra.UseVisualStyleBackColor = true;
            this.btnColorLetra.Click += new System.EventHandler(this.txtcolorLetra_Click);
            // 
            // comboMesAño
            // 
            this.comboMesAño.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.comboMesAño.AutoSize = true;
            this.comboMesAño.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.comboMesAño.BackColor = System.Drawing.Color.Transparent;
            this.comboMesAño.FechaConDiaActual = new System.DateTime(2019, 9, 12, 0, 0, 0, 0);
            this.comboMesAño.FechaFinMes = new System.DateTime(2019, 9, 30, 0, 0, 0, 0);
            this.comboMesAño.FechaInicioMes = new System.DateTime(2019, 9, 1, 0, 0, 0, 0);
            this.comboMesAño.Location = new System.Drawing.Point(173, 63);
            this.comboMesAño.Name = "comboMesAño";
            this.comboMesAño.Size = new System.Drawing.Size(197, 24);
            this.comboMesAño.TabIndex = 90;
            this.comboMesAño.VerAño = true;
            this.comboMesAño.VerMes = true;
            this.comboMesAño.CambioFechas += new System.EventHandler(this.comboMesAño_CambioFechas);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // EstadoGananciaPerdidas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 695);
            this.Controls.Add(this.comboMesAño);
            this.Controls.Add(this.btnColorFondo);
            this.Controls.Add(this.btnColorLetra);
            this.Controls.Add(this.cboempresas);
            this.Controls.Add(this.btnGenerar);
            this.Controls.Add(this.lblconteo);
            this.Controls.Add(this.btnexportarpdf);
            this.Controls.Add(this.btnexportarexcel);
            this.Controls.Add(this.btncancelar);
            this.Controls.Add(this.dtgconten);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblfechasReporte);
            this.Controls.Add(this.label1);
            this.MinimumSize = new System.Drawing.Size(530, 598);
            this.Name = "EstadoGananciaPerdidas";
            this.Nombre = "Estado De Resultado Integral";
            this.Text = "Estado De Resultado Integral";
            this.Load += new System.EventHandler(this.EstadoGananciaPerdidas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgconten)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblfechasReporte;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dtgconten;
        private System.Windows.Forms.Button btncancelar;
        private System.Windows.Forms.Button btnexportarexcel;
        private System.Windows.Forms.Button btnexportarpdf;
        private System.Windows.Forms.Label lblconteo;
        private System.Windows.Forms.Button btnGenerar;
        private System.Windows.Forms.ComboBox cboempresas;
        private System.Windows.Forms.ColorDialog ColorDialog;
        private System.Windows.Forms.Button btnColorFondo;
        private System.Windows.Forms.Button btnColorLetra;
        private System.Windows.Forms.DataGridViewTextBoxColumn indexx;
        private System.Windows.Forms.DataGridViewTextBoxColumn Camposx;
        private System.Windows.Forms.DataGridViewTextBoxColumn Totalesx;
        private System.Windows.Forms.DataGridViewTextBoxColumn empresax;
        private HpResergerUserControls.ComboMesAño comboMesAño;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}