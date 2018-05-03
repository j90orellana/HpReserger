namespace HPReserger
{
    partial class frmReporteGeneral
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReporteGeneral));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.cboempresas = new System.Windows.Forms.ComboBox();
            this.btnGenerar = new System.Windows.Forms.Button();
            this.lblconteo = new System.Windows.Forms.Label();
            this.btnexportarpdf = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnexportarexcel = new System.Windows.Forms.Button();
            this.btncancelar = new System.Windows.Forms.Button();
            this.dtgconten = new System.Windows.Forms.DataGridView();
            this.indexx = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Camposx = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Totalesx = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.empresax = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.indez = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.campoz = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalesz = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.empresaz = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.lblfechasReporte = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ColorDialog = new System.Windows.Forms.ColorDialog();
            this.btnColorLetra = new System.Windows.Forms.Button();
            this.btnColorFondo = new System.Windows.Forms.Button();
            this.comboMesAño = new HpResergerUserControls.ComboMesAño();
            this.label4 = new System.Windows.Forms.Label();
            this.txtdiferencia = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtgconten)).BeginInit();
            this.SuspendLayout();
            // 
            // cboempresas
            // 
            this.cboempresas.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cboempresas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboempresas.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboempresas.FormattingEnabled = true;
            this.cboempresas.Location = new System.Drawing.Point(260, 12);
            this.cboempresas.Name = "cboempresas";
            this.cboempresas.Size = new System.Drawing.Size(299, 28);
            this.cboempresas.TabIndex = 82;
            this.cboempresas.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.cboempresas_DrawItem);
            // 
            // btnGenerar
            // 
            this.btnGenerar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGenerar.Image = ((System.Drawing.Image)(resources.GetObject("btnGenerar.Image")));
            this.btnGenerar.Location = new System.Drawing.Point(732, 71);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(75, 23);
            this.btnGenerar.TabIndex = 81;
            this.btnGenerar.Text = "Generar";
            this.btnGenerar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGenerar.UseVisualStyleBackColor = true;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // lblconteo
            // 
            this.lblconteo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblconteo.AutoSize = true;
            this.lblconteo.Location = new System.Drawing.Point(14, 744);
            this.lblconteo.Name = "lblconteo";
            this.lblconteo.Size = new System.Drawing.Size(121, 13);
            this.lblconteo.TabIndex = 80;
            this.lblconteo.Text = "Número de Registros:  0";
            // 
            // btnexportarpdf
            // 
            this.btnexportarpdf.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnexportarpdf.Image = ((System.Drawing.Image)(resources.GetObject("btnexportarpdf.Image")));
            this.btnexportarpdf.Location = new System.Drawing.Point(282, 739);
            this.btnexportarpdf.Name = "btnexportarpdf";
            this.btnexportarpdf.Size = new System.Drawing.Size(75, 23);
            this.btnexportarpdf.TabIndex = 79;
            this.btnexportarpdf.Text = "Pdf";
            this.btnexportarpdf.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnexportarpdf.UseVisualStyleBackColor = true;
            this.btnexportarpdf.Click += new System.EventHandler(this.btnexportarpdf_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(146, 744);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 78;
            this.label2.Text = "Exportar:";
            // 
            // btnexportarexcel
            // 
            this.btnexportarexcel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnexportarexcel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnexportarexcel.Image = ((System.Drawing.Image)(resources.GetObject("btnexportarexcel.Image")));
            this.btnexportarexcel.Location = new System.Drawing.Point(201, 739);
            this.btnexportarexcel.Name = "btnexportarexcel";
            this.btnexportarexcel.Size = new System.Drawing.Size(75, 23);
            this.btnexportarexcel.TabIndex = 77;
            this.btnexportarexcel.Text = "Excel";
            this.btnexportarexcel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnexportarexcel.UseVisualStyleBackColor = true;
            this.btnexportarexcel.Click += new System.EventHandler(this.btnexportarexcel_Click);
            // 
            // btncancelar
            // 
            this.btncancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btncancelar.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btncancelar.Image = ((System.Drawing.Image)(resources.GetObject("btncancelar.Image")));
            this.btncancelar.Location = new System.Drawing.Point(732, 739);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(75, 23);
            this.btncancelar.TabIndex = 76;
            this.btncancelar.Text = "Cancelar";
            this.btncancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btncancelar.UseVisualStyleBackColor = true;
            this.btncancelar.Click += new System.EventHandler(this.btncancelar_Click);
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
            this.empresax,
            this.indez,
            this.campoz,
            this.totalesz,
            this.empresaz});
            this.dtgconten.Cursor = System.Windows.Forms.Cursors.Default;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgconten.DefaultCellStyle = dataGridViewCellStyle5;
            this.dtgconten.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dtgconten.EnableHeadersVisualStyles = false;
            this.dtgconten.Location = new System.Drawing.Point(11, 100);
            this.dtgconten.Name = "dtgconten";
            this.dtgconten.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dtgconten.RowHeadersVisible = false;
            this.dtgconten.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtgconten.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dtgconten.RowTemplate.Height = 18;
            this.dtgconten.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dtgconten.Size = new System.Drawing.Size(796, 633);
            this.dtgconten.TabIndex = 75;
            this.dtgconten.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgconten_RowEnter);
            this.dtgconten.Sorted += new System.EventHandler(this.dtgconten_Sorted);
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
            this.Totalesx.HeaderText = "TOTALES";
            this.Totalesx.MinimumWidth = 100;
            this.Totalesx.Name = "Totalesx";
            this.Totalesx.ReadOnly = true;
            this.Totalesx.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // empresax
            // 
            this.empresax.DataPropertyName = "Empresa";
            this.empresax.HeaderText = "Empresa";
            this.empresax.Name = "empresax";
            this.empresax.Visible = false;
            // 
            // indez
            // 
            this.indez.DataPropertyName = "ix";
            this.indez.HeaderText = "indez";
            this.indez.Name = "indez";
            this.indez.Visible = false;
            // 
            // campoz
            // 
            this.campoz.DataPropertyName = "campox";
            this.campoz.HeaderText = "";
            this.campoz.Name = "campoz";
            this.campoz.ReadOnly = true;
            this.campoz.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // totalesz
            // 
            this.totalesz.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.totalesz.DataPropertyName = "totalx";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle4.Format = "n2";
            this.totalesz.DefaultCellStyle = dataGridViewCellStyle4;
            this.totalesz.HeaderText = "TOTALES";
            this.totalesz.MinimumWidth = 100;
            this.totalesz.Name = "totalesz";
            this.totalesz.ReadOnly = true;
            this.totalesz.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // empresaz
            // 
            this.empresaz.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.empresaz.DataPropertyName = "empresax";
            this.empresaz.HeaderText = "Empresa";
            this.empresaz.Name = "empresaz";
            this.empresaz.Visible = false;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(353, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 13);
            this.label3.TabIndex = 74;
            this.label3.Text = "(Expresado en Soles)";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblfechasReporte
            // 
            this.lblfechasReporte.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblfechasReporte.AutoSize = true;
            this.lblfechasReporte.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfechasReporte.Location = new System.Drawing.Point(296, 67);
            this.lblfechasReporte.Name = "lblfechasReporte";
            this.lblfechasReporte.Size = new System.Drawing.Size(32, 13);
            this.lblfechasReporte.TabIndex = 73;
            this.lblfechasReporte.Text = "Al 31";
            this.lblfechasReporte.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(283, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(253, 20);
            this.label1.TabIndex = 72;
            this.label1.Text = "ESTADO DE SITUACIÓN FINANCIERA";
            // 
            // btnColorLetra
            // 
            this.btnColorLetra.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnColorLetra.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnColorLetra.BackgroundImage")));
            this.btnColorLetra.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnColorLetra.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnColorLetra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnColorLetra.Location = new System.Drawing.Point(393, 739);
            this.btnColorLetra.Name = "btnColorLetra";
            this.btnColorLetra.Size = new System.Drawing.Size(24, 23);
            this.btnColorLetra.TabIndex = 86;
            this.btnColorLetra.UseVisualStyleBackColor = true;
            this.btnColorLetra.Click += new System.EventHandler(this.txtcolorLetra_Click);
            // 
            // btnColorFondo
            // 
            this.btnColorFondo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnColorFondo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnColorFondo.BackgroundImage")));
            this.btnColorFondo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnColorFondo.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnColorFondo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnColorFondo.Location = new System.Drawing.Point(363, 739);
            this.btnColorFondo.Name = "btnColorFondo";
            this.btnColorFondo.Size = new System.Drawing.Size(24, 23);
            this.btnColorFondo.TabIndex = 87;
            this.btnColorFondo.UseVisualStyleBackColor = true;
            this.btnColorFondo.Click += new System.EventHandler(this.txtfondo_Click);
            // 
            // comboMesAño
            // 
            this.comboMesAño.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.comboMesAño.AutoSize = true;
            this.comboMesAño.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.comboMesAño.FechaConDiaActual = new System.DateTime(2018, 4, 27, 0, 0, 0, 0);
            this.comboMesAño.FechaFinMes = new System.DateTime(2018, 4, 30, 0, 0, 0, 0);
            this.comboMesAño.FechaInicioMes = new System.DateTime(2018, 4, 1, 0, 0, 0, 0);
            this.comboMesAño.Location = new System.Drawing.Point(325, 63);
            this.comboMesAño.Name = "comboMesAño";
            this.comboMesAño.Size = new System.Drawing.Size(197, 24);
            this.comboMesAño.TabIndex = 88;
            this.comboMesAño.CambioFechas += new System.EventHandler(this.comboMesAño_CambioFechas);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(556, 744);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 89;
            this.label4.Text = "Diferencia";
            // 
            // txtdiferencia
            // 
            this.txtdiferencia.Location = new System.Drawing.Point(611, 740);
            this.txtdiferencia.Name = "txtdiferencia";
            this.txtdiferencia.ReadOnly = true;
            this.txtdiferencia.Size = new System.Drawing.Size(115, 20);
            this.txtdiferencia.TabIndex = 90;
            this.txtdiferencia.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // frmReporteGeneral
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(819, 774);
            this.Controls.Add(this.txtdiferencia);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboMesAño);
            this.Controls.Add(this.btnColorFondo);
            this.Controls.Add(this.btnColorLetra);
            this.Controls.Add(this.cboempresas);
            this.Controls.Add(this.btnGenerar);
            this.Controls.Add(this.lblconteo);
            this.Controls.Add(this.btnexportarpdf);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnexportarexcel);
            this.Controls.Add(this.btncancelar);
            this.Controls.Add(this.dtgconten);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblfechasReporte);
            this.Controls.Add(this.label1);
            this.MinimumSize = new System.Drawing.Size(835, 813);
            this.Name = "frmReporteGeneral";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reporte Estado de Situación Financiera";
            this.Load += new System.EventHandler(this.frmReporteGeneral_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgconten)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cboempresas;
        private System.Windows.Forms.Button btnGenerar;
        private System.Windows.Forms.Label lblconteo;
        private System.Windows.Forms.Button btnexportarpdf;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnexportarexcel;
        private System.Windows.Forms.Button btncancelar;
        private System.Windows.Forms.DataGridView dtgconten;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblfechasReporte;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ColorDialog ColorDialog;
        private System.Windows.Forms.Button btnColorLetra;
        private System.Windows.Forms.Button btnColorFondo;
        private HpResergerUserControls.ComboMesAño comboMesAño;
        private System.Windows.Forms.DataGridViewTextBoxColumn indexx;
        private System.Windows.Forms.DataGridViewTextBoxColumn Camposx;
        private System.Windows.Forms.DataGridViewTextBoxColumn Totalesx;
        private System.Windows.Forms.DataGridViewTextBoxColumn empresax;
        private System.Windows.Forms.DataGridViewTextBoxColumn indez;
        private System.Windows.Forms.DataGridViewTextBoxColumn campoz;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalesz;
        private System.Windows.Forms.DataGridViewTextBoxColumn empresaz;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtdiferencia;
    }
}