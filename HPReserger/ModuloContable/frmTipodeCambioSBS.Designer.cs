﻿namespace HPReserger
{
    partial class frmTipodeCambioSBS
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTipodeCambioSBS));
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
            this.pbup = new System.Windows.Forms.PictureBox();
            this.pbdown = new System.Windows.Forms.PictureBox();
            this.pbigual = new System.Windows.Forms.PictureBox();
            this.btnExcel = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.btnaddtipo = new System.Windows.Forms.Button();
            this.comboMesAño = new HpResergerUserControls.ComboMesAño();
            this.dtgconten = new HpResergerUserControls.Dtgconten();
            this.Dia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Año = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Compra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cp = new System.Windows.Forms.DataGridViewImageColumn();
            this.Venta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vv = new System.Windows.Forms.DataGridViewImageColumn();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.lblmsg = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbdown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbigual)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgconten)).BeginInit();
            this.SuspendLayout();
            // 
            // Btncancelar
            // 
            this.Btncancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Btncancelar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Btncancelar.Image = ((System.Drawing.Image)(resources.GetObject("Btncancelar.Image")));
            this.Btncancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Btncancelar.Location = new System.Drawing.Point(387, 421);
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
            this.Buscar.Location = new System.Drawing.Point(310, 12);
            this.Buscar.Name = "Buscar";
            this.Buscar.Size = new System.Drawing.Size(75, 24);
            this.Buscar.TabIndex = 64;
            this.Buscar.Text = "Buscar";
            this.Buscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Buscar.UseVisualStyleBackColor = true;
            this.Buscar.Click += new System.EventHandler(this.Buscar_Click);
            // 
            // pbup
            // 
            this.pbup.Image = ((System.Drawing.Image)(resources.GetObject("pbup.Image")));
            this.pbup.Location = new System.Drawing.Point(190, 11);
            this.pbup.Name = "pbup";
            this.pbup.Size = new System.Drawing.Size(28, 24);
            this.pbup.TabIndex = 66;
            this.pbup.TabStop = false;
            this.pbup.Visible = false;
            // 
            // pbdown
            // 
            this.pbdown.Image = ((System.Drawing.Image)(resources.GetObject("pbdown.Image")));
            this.pbdown.Location = new System.Drawing.Point(224, 11);
            this.pbdown.Name = "pbdown";
            this.pbdown.Size = new System.Drawing.Size(28, 24);
            this.pbdown.TabIndex = 67;
            this.pbdown.TabStop = false;
            this.pbdown.Visible = false;
            // 
            // pbigual
            // 
            this.pbigual.Image = ((System.Drawing.Image)(resources.GetObject("pbigual.Image")));
            this.pbigual.Location = new System.Drawing.Point(258, 11);
            this.pbigual.Name = "pbigual";
            this.pbigual.Size = new System.Drawing.Size(28, 24);
            this.pbigual.TabIndex = 68;
            this.pbigual.TabStop = false;
            this.pbigual.Visible = false;
            // 
            // btnExcel
            // 
            this.btnExcel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnExcel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnExcel.Image = ((System.Drawing.Image)(resources.GetObject("btnExcel.Image")));
            this.btnExcel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExcel.Location = new System.Drawing.Point(200, 421);
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
            this.btnaddtipo.Location = new System.Drawing.Point(387, 12);
            this.btnaddtipo.Name = "btnaddtipo";
            this.btnaddtipo.Size = new System.Drawing.Size(75, 24);
            this.btnaddtipo.TabIndex = 70;
            this.btnaddtipo.Text = "Agregar";
            this.btnaddtipo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toolTip1.SetToolTip(this.btnaddtipo, "Tipo de Cambio Manual");
            this.btnaddtipo.UseVisualStyleBackColor = true;
            this.btnaddtipo.Click += new System.EventHandler(this.btnaddtipo_Click);
            // 
            // comboMesAño
            // 
            this.comboMesAño.AutoSize = true;
            this.comboMesAño.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.comboMesAño.BackColor = System.Drawing.Color.Transparent;
            this.comboMesAño.FechaConDiaActual = new System.DateTime(2019, 11, 8, 0, 0, 0, 0);
            this.comboMesAño.FechaFinMes = new System.DateTime(2019, 11, 30, 0, 0, 0, 0);
            this.comboMesAño.FechaInicioMes = new System.DateTime(2019, 11, 1, 0, 0, 0, 0);
            this.comboMesAño.Location = new System.Drawing.Point(12, 11);
            this.comboMesAño.Name = "comboMesAño";
            this.comboMesAño.Size = new System.Drawing.Size(82, 27);
            this.comboMesAño.TabIndex = 63;
            this.comboMesAño.VerAño = true;
            this.comboMesAño.VerMes = false;
            // 
            // dtgconten
            // 
            this.dtgconten.AllowUserToAddRows = false;
            this.dtgconten.AllowUserToDeleteRows = false;
            this.dtgconten.AllowUserToResizeColumns = false;
            this.dtgconten.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(230)))), ((int)(((byte)(241)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 8.25F);
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
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(207)))), ((int)(((byte)(241)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.Black;
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
            this.dtgconten.Size = new System.Drawing.Size(450, 374);
            this.dtgconten.TabIndex = 61;
            this.dtgconten.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dtgconten_MouseDown);
            // 
            // Dia
            // 
            this.Dia.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Dia.DataPropertyName = "dia";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Dia.DefaultCellStyle = dataGridViewCellStyle3;
            this.Dia.HeaderText = "Día";
            this.Dia.Name = "Dia";
            this.Dia.ReadOnly = true;
            this.Dia.Width = 48;
            // 
            // Mes
            // 
            this.Mes.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Mes.DataPropertyName = "mes";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle4.Format = "MMMM-yyyy";
            this.Mes.DefaultCellStyle = dataGridViewCellStyle4;
            this.Mes.HeaderText = "Periodo";
            this.Mes.MinimumWidth = 80;
            this.Mes.Name = "Mes";
            this.Mes.ReadOnly = true;
            this.Mes.Width = 80;
            // 
            // Año
            // 
            this.Año.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
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
            dataGridViewCellStyle6.Format = "n4";
            this.Compra.DefaultCellStyle = dataGridViewCellStyle6;
            this.Compra.HeaderText = "Compra";
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
            dataGridViewCellStyle7.Format = "n4";
            this.Venta.DefaultCellStyle = dataGridViewCellStyle7;
            this.Venta.HeaderText = "Venta";
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
            // lblmsg
            // 
            this.lblmsg.AutoSize = true;
            this.lblmsg.BackColor = System.Drawing.Color.Transparent;
            this.lblmsg.Location = new System.Drawing.Point(12, 427);
            this.lblmsg.Name = "lblmsg";
            this.lblmsg.Size = new System.Drawing.Size(110, 13);
            this.lblmsg.TabIndex = 71;
            this.lblmsg.Text = "Total de Registros: 0";
            // 
            // frmTipodeCambioSBS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 451);
            this.Controls.Add(this.lblmsg);
            this.Controls.Add(this.btnaddtipo);
            this.Controls.Add(this.pbigual);
            this.Controls.Add(this.pbdown);
            this.Controls.Add(this.pbup);
            this.Controls.Add(this.Buscar);
            this.Controls.Add(this.comboMesAño);
            this.Controls.Add(this.Btncancelar);
            this.Controls.Add(this.btnExcel);
            this.Controls.Add(this.dtgconten);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.MinimumSize = new System.Drawing.Size(490, 490);
            this.Name = "frmTipodeCambioSBS";
            this.Nombre = "Tipo de Cambio Cierre Mensual";
            this.Text = "Tipo de Cambio Cierre Mensual";
            this.Load += new System.EventHandler(this.TipodeCambio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbdown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbigual)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgconten)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private HpResergerUserControls.Dtgconten dtgconten;
        private System.Windows.Forms.Button Btncancelar;
        private System.Windows.Forms.PictureBox pbup;
        private System.Windows.Forms.PictureBox pbdown;
        private System.Windows.Forms.PictureBox pbigual;
        private System.Windows.Forms.Button btnExcel;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button btnaddtipo;
        private System.Windows.Forms.ToolTip toolTip1;
        public HpResergerUserControls.ComboMesAño comboMesAño;
        private System.Windows.Forms.Button Buscar;
        private System.Windows.Forms.Label lblmsg;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dia;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mes;
        private System.Windows.Forms.DataGridViewTextBoxColumn Año;
        private System.Windows.Forms.DataGridViewTextBoxColumn Compra;
        private System.Windows.Forms.DataGridViewImageColumn cp;
        private System.Windows.Forms.DataGridViewTextBoxColumn Venta;
        private System.Windows.Forms.DataGridViewImageColumn vv;
    }
}