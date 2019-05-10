namespace HPReserger
{
    partial class frmTipodeCambio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTipodeCambio));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Btncancelar = new System.Windows.Forms.Button();
            this.Buscar = new System.Windows.Forms.Button();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.label1 = new System.Windows.Forms.Label();
            this.pbup = new System.Windows.Forms.PictureBox();
            this.pbdown = new System.Windows.Forms.PictureBox();
            this.pbigual = new System.Windows.Forms.PictureBox();
            this.btnExcel = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.btnaddtipo = new System.Windows.Forms.Button();
            this.comboMesAño1 = new HpResergerUserControls.ComboMesAño();
            this.dtgconten = new HpResergerUserControls.Dtgconten();
            this.Dia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Año = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Compra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cp = new System.Windows.Forms.DataGridViewImageColumn();
            this.Venta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vv = new System.Windows.Forms.DataGridViewImageColumn();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.Timer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pbup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbdown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbigual)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgconten)).BeginInit();
            this.SuspendLayout();
            // 
            // Btncancelar
            // 
            this.Btncancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Btncancelar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Btncancelar.Image = ((System.Drawing.Image)(resources.GetObject("Btncancelar.Image")));
            this.Btncancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Btncancelar.Location = new System.Drawing.Point(395, 10);
            this.Btncancelar.Name = "Btncancelar";
            this.Btncancelar.Size = new System.Drawing.Size(75, 24);
            this.Btncancelar.TabIndex = 62;
            this.Btncancelar.Text = "Cancelar";
            this.Btncancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Btncancelar.UseVisualStyleBackColor = true;
            this.Btncancelar.Click += new System.EventHandler(this.Btncancelar_Click);
            // 
            // Buscar
            // 
            this.Buscar.Image = ((System.Drawing.Image)(resources.GetObject("Buscar.Image")));
            this.Buscar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Buscar.Location = new System.Drawing.Point(210, 10);
            this.Buscar.Name = "Buscar";
            this.Buscar.Size = new System.Drawing.Size(75, 24);
            this.Buscar.TabIndex = 64;
            this.Buscar.Text = "Buscar";
            this.Buscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Buscar.UseVisualStyleBackColor = true;
            this.Buscar.Click += new System.EventHandler(this.Buscar_Click);
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(3, 56);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(331, 123);
            this.webBrowser1.TabIndex = 60;
            this.webBrowser1.Visible = false;
            this.webBrowser1.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.webBrowser1_DocumentCompleted);
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 451);
            this.label1.MinimumSize = new System.Drawing.Size(482, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(482, 87);
            this.label1.TabIndex = 65;
            this.label1.Text = resources.GetString("label1.Text");
            // 
            // pbup
            // 
            this.pbup.Image = ((System.Drawing.Image)(resources.GetObject("pbup.Image")));
            this.pbup.Location = new System.Drawing.Point(350, 502);
            this.pbup.Name = "pbup";
            this.pbup.Size = new System.Drawing.Size(28, 24);
            this.pbup.TabIndex = 66;
            this.pbup.TabStop = false;
            this.pbup.Visible = false;
            // 
            // pbdown
            // 
            this.pbdown.Image = ((System.Drawing.Image)(resources.GetObject("pbdown.Image")));
            this.pbdown.Location = new System.Drawing.Point(384, 502);
            this.pbdown.Name = "pbdown";
            this.pbdown.Size = new System.Drawing.Size(28, 24);
            this.pbdown.TabIndex = 67;
            this.pbdown.TabStop = false;
            this.pbdown.Visible = false;
            // 
            // pbigual
            // 
            this.pbigual.Image = ((System.Drawing.Image)(resources.GetObject("pbigual.Image")));
            this.pbigual.Location = new System.Drawing.Point(418, 502);
            this.pbigual.Name = "pbigual";
            this.pbigual.Size = new System.Drawing.Size(28, 24);
            this.pbigual.TabIndex = 68;
            this.pbigual.TabStop = false;
            this.pbigual.Visible = false;
            // 
            // btnExcel
            // 
            this.btnExcel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExcel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnExcel.Image = ((System.Drawing.Image)(resources.GetObject("btnExcel.Image")));
            this.btnExcel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExcel.Location = new System.Drawing.Point(317, 10);
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.Size = new System.Drawing.Size(75, 24);
            this.btnExcel.TabIndex = 69;
            this.btnExcel.Text = "Excel";
            this.btnExcel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnExcel.UseVisualStyleBackColor = true;
            this.btnExcel.Click += new System.EventHandler(this.btnExcel_Click);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // btnaddtipo
            // 
            this.btnaddtipo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnaddtipo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnaddtipo.Image = ((System.Drawing.Image)(resources.GetObject("btnaddtipo.Image")));
            this.btnaddtipo.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnaddtipo.Location = new System.Drawing.Point(290, 10);
            this.btnaddtipo.Name = "btnaddtipo";
            this.btnaddtipo.Size = new System.Drawing.Size(24, 24);
            this.btnaddtipo.TabIndex = 70;
            this.btnaddtipo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toolTip1.SetToolTip(this.btnaddtipo, "Tipo de Cambio Manual");
            this.btnaddtipo.UseVisualStyleBackColor = true;
            this.btnaddtipo.Click += new System.EventHandler(this.btnaddtipo_Click);
            // 
            // comboMesAño1
            // 
            this.comboMesAño1.AutoSize = true;
            this.comboMesAño1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.comboMesAño1.BackColor = System.Drawing.Color.Transparent;
            this.comboMesAño1.FechaConDiaActual = new System.DateTime(2019, 5, 10, 0, 0, 0, 0);
            this.comboMesAño1.FechaFinMes = new System.DateTime(2019, 5, 31, 0, 0, 0, 0);
            this.comboMesAño1.FechaInicioMes = new System.DateTime(2019, 5, 1, 0, 0, 0, 0);
            this.comboMesAño1.Location = new System.Drawing.Point(12, 11);
            this.comboMesAño1.Name = "comboMesAño1";
            this.comboMesAño1.Size = new System.Drawing.Size(197, 24);
            this.comboMesAño1.TabIndex = 63;
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
            this.dtgconten.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgconten.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.dtgconten.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
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
            this.Dia,
            this.Mes,
            this.Año,
            this.Compra,
            this.cp,
            this.Venta,
            this.vv});
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgconten.DefaultCellStyle = dataGridViewCellStyle8;
            this.dtgconten.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dtgconten.EnableHeadersVisualStyles = false;
            this.dtgconten.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(179)))), ((int)(((byte)(215)))));
            this.dtgconten.Location = new System.Drawing.Point(12, 41);
            this.dtgconten.MultiSelect = false;
            this.dtgconten.Name = "dtgconten";
            this.dtgconten.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dtgconten.RowHeadersVisible = false;
            this.dtgconten.RowTemplate.Height = 18;
            this.dtgconten.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dtgconten.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dtgconten.Size = new System.Drawing.Size(458, 407);
            this.dtgconten.TabIndex = 61;
            this.dtgconten.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dtgconten_MouseDown);
            // 
            // Dia
            // 
            this.Dia.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Dia.DataPropertyName = "dia";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Dia.DefaultCellStyle = dataGridViewCellStyle3;
            this.Dia.HeaderText = "                 Día                         ";
            this.Dia.Name = "Dia";
            this.Dia.ReadOnly = true;
            // 
            // Mes
            // 
            this.Mes.DataPropertyName = "mes";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Mes.DefaultCellStyle = dataGridViewCellStyle4;
            this.Mes.HeaderText = "Mes";
            this.Mes.Name = "Mes";
            this.Mes.ReadOnly = true;
            this.Mes.Visible = false;
            // 
            // Año
            // 
            this.Año.DataPropertyName = "año";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Año.DefaultCellStyle = dataGridViewCellStyle5;
            this.Año.HeaderText = "Año";
            this.Año.Name = "Año";
            this.Año.ReadOnly = true;
            this.Año.Visible = false;
            // 
            // Compra
            // 
            this.Compra.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Compra.DataPropertyName = "compra";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle6.Format = "#0.000";
            this.Compra.DefaultCellStyle = dataGridViewCellStyle6;
            this.Compra.HeaderText = "                Compra                      ";
            this.Compra.Name = "Compra";
            this.Compra.ReadOnly = true;
            // 
            // cp
            // 
            this.cp.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.cp.DataPropertyName = "compraimg";
            this.cp.HeaderText = "-";
            this.cp.Name = "cp";
            this.cp.Width = 16;
            // 
            // Venta
            // 
            this.Venta.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Venta.DataPropertyName = "venta";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle7.Format = "#0.000";
            this.Venta.DefaultCellStyle = dataGridViewCellStyle7;
            this.Venta.HeaderText = "                    Venta                     ";
            this.Venta.Name = "Venta";
            this.Venta.ReadOnly = true;
            // 
            // vv
            // 
            this.vv.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.vv.DataPropertyName = "ventaimg";
            this.vv.HeaderText = "-";
            this.vv.Name = "vv";
            this.vv.Width = 16;
            // 
            // Timer
            // 
            this.Timer.Enabled = true;
            this.Timer.Interval = 1800000;
            this.Timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // frmTipodeCambio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 538);
            this.Controls.Add(this.btnaddtipo);
            this.Controls.Add(this.pbigual);
            this.Controls.Add(this.pbdown);
            this.Controls.Add(this.pbup);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Buscar);
            this.Controls.Add(this.comboMesAño1);
            this.Controls.Add(this.Btncancelar);
            this.Controls.Add(this.dtgconten);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.btnExcel);
            this.MinimumSize = new System.Drawing.Size(498, 577);
            this.Name = "frmTipodeCambio";
            this.Nombre = "Tipo de Cambio [SUNAT]";
            this.Text = "Tipo de Cambio [SUNAT]";
            this.Load += new System.EventHandler(this.TipodeCambio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbdown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbigual)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgconten)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.WebBrowser webBrowser1;
        private HpResergerUserControls.Dtgconten dtgconten;
        private System.Windows.Forms.Button Btncancelar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pbup;
        private System.Windows.Forms.PictureBox pbdown;
        private System.Windows.Forms.PictureBox pbigual;
        private System.Windows.Forms.Button btnExcel;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dia;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mes;
        private System.Windows.Forms.DataGridViewTextBoxColumn Año;
        private System.Windows.Forms.DataGridViewTextBoxColumn Compra;
        private System.Windows.Forms.DataGridViewImageColumn cp;
        private System.Windows.Forms.DataGridViewTextBoxColumn Venta;
        private System.Windows.Forms.DataGridViewImageColumn vv;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button btnaddtipo;
        private System.Windows.Forms.ToolTip toolTip1;
        public HpResergerUserControls.ComboMesAño comboMesAño1;
        private System.Windows.Forms.Button Buscar;
        private System.Windows.Forms.Timer Timer;
    }
}