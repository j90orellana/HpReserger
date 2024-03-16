using HpResergerUserControls;

namespace HPReserger
{
    partial class frmAfpsComisiones
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAfpsComisiones));
            this.dtgconten = new HpResergerUserControls.Dtgconten();
            this.xid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xPeriodo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xAfp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xAporte = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xSeguro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xComision = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xRMA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xusuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xFecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btneliminar = new System.Windows.Forms.Button();
            this.btnmodificar = new System.Windows.Forms.Button();
            this.btnexportarExcel = new System.Windows.Forms.Button();
            this.btnaceptar = new HpResergerUserControls.ButtonPer();
            this.btncancelar = new HpResergerUserControls.ButtonPer();
            this.lbltotalRegistros = new System.Windows.Forms.Label();
            this.duplicadorBase1 = new HpResergerUserControls.DuplicadorBase();
            this.cboperiodo = new HpResergerUserControls.ComboMesAño();
            this.label1 = new System.Windows.Forms.Label();
            this.btnPaso1 = new HpResergerUserControls.ButtonPer();
            ((System.ComponentModel.ISupportInitialize)(this.dtgconten)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgconten
            // 
            this.dtgconten.AllowUserToAddRows = false;
            this.dtgconten.AllowUserToDeleteRows = false;
            this.dtgconten.AllowUserToResizeColumns = false;
            this.dtgconten.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtgconten.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgconten.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgconten.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgconten.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(218)))), ((int)(((byte)(231)))));
            this.dtgconten.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgconten.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.dtgconten.CheckColumna = null;
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
            this.xid,
            this.xPeriodo,
            this.xAfp,
            this.xAporte,
            this.xSeguro,
            this.xComision,
            this.xRMA,
            this.xusuario,
            this.xFecha});
            this.dtgconten.Cursor = System.Windows.Forms.Cursors.Default;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(207)))), ((int)(((byte)(241)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgconten.DefaultCellStyle = dataGridViewCellStyle8;
            this.dtgconten.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dtgconten.EnableHeadersVisualStyles = false;
            this.dtgconten.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(179)))), ((int)(((byte)(215)))));
            this.dtgconten.Location = new System.Drawing.Point(12, 51);
            this.dtgconten.MultiSelect = false;
            this.dtgconten.Name = "dtgconten";
            this.dtgconten.ReadOnly = true;
            this.dtgconten.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dtgconten.RowHeadersVisible = false;
            this.dtgconten.RowTemplate.Height = 16;
            this.dtgconten.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dtgconten.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dtgconten.Size = new System.Drawing.Size(611, 315);
            this.dtgconten.TabIndex = 56;
            this.dtgconten.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgconten_CellValueChanged);
            this.dtgconten.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dtgconten_EditingControlShowing);
            this.dtgconten.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgconten_RowEnter);
            // 
            // xid
            // 
            this.xid.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.xid.DataPropertyName = "id_Afp";
            this.xid.HeaderText = "Id";
            this.xid.Name = "xid";
            this.xid.ReadOnly = true;
            this.xid.Visible = false;
            // 
            // xPeriodo
            // 
            this.xPeriodo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.xPeriodo.DataPropertyName = "periodo";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.Format = "MM-yyyy";
            this.xPeriodo.DefaultCellStyle = dataGridViewCellStyle3;
            this.xPeriodo.HeaderText = "MES DEVENGUE";
            this.xPeriodo.MinimumWidth = 70;
            this.xPeriodo.Name = "xPeriodo";
            this.xPeriodo.ReadOnly = true;
            this.xPeriodo.Width = 70;
            // 
            // xAfp
            // 
            this.xAfp.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.xAfp.DataPropertyName = "afp";
            this.xAfp.HeaderText = "AFP";
            this.xAfp.Name = "xAfp";
            this.xAfp.ReadOnly = true;
            // 
            // xAporte
            // 
            this.xAporte.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.xAporte.DataPropertyName = "aporte";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle4.Format = "0.00%";
            this.xAporte.DefaultCellStyle = dataGridViewCellStyle4;
            this.xAporte.HeaderText = "APORTE OBLIGATORIO AL FONDO DE PENSIONES";
            this.xAporte.MinimumWidth = 80;
            this.xAporte.Name = "xAporte";
            this.xAporte.ReadOnly = true;
            this.xAporte.Width = 80;
            // 
            // xSeguro
            // 
            this.xSeguro.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.xSeguro.DataPropertyName = "seguro";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle5.Format = "0.00%";
            this.xSeguro.DefaultCellStyle = dataGridViewCellStyle5;
            this.xSeguro.HeaderText = "PRIMA DE\r\nSEGUROS";
            this.xSeguro.MinimumWidth = 70;
            this.xSeguro.Name = "xSeguro";
            this.xSeguro.ReadOnly = true;
            this.xSeguro.Width = 70;
            // 
            // xComision
            // 
            this.xComision.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.xComision.DataPropertyName = "comision";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle6.Format = "0.00%";
            this.xComision.DefaultCellStyle = dataGridViewCellStyle6;
            this.xComision.HeaderText = "COMISIÓN\r\nSOBRE FLUJO";
            this.xComision.MinimumWidth = 70;
            this.xComision.Name = "xComision";
            this.xComision.ReadOnly = true;
            this.xComision.Width = 70;
            // 
            // xRMA
            // 
            this.xRMA.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.xRMA.DataPropertyName = "rma";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle7.Format = "n2";
            this.xRMA.DefaultCellStyle = dataGridViewCellStyle7;
            this.xRMA.HeaderText = "REMUNERACIÓN MÁXIMA ASEGURABLE";
            this.xRMA.MinimumWidth = 120;
            this.xRMA.Name = "xRMA";
            this.xRMA.ReadOnly = true;
            this.xRMA.Width = 120;
            // 
            // xusuario
            // 
            this.xusuario.DataPropertyName = "usuario";
            this.xusuario.HeaderText = "Usuario";
            this.xusuario.Name = "xusuario";
            this.xusuario.ReadOnly = true;
            this.xusuario.Visible = false;
            // 
            // xFecha
            // 
            this.xFecha.DataPropertyName = "fecha";
            this.xFecha.HeaderText = "Fecha";
            this.xFecha.Name = "xFecha";
            this.xFecha.ReadOnly = true;
            this.xFecha.Visible = false;
            // 
            // btneliminar
            // 
            this.btneliminar.Enabled = false;
            this.btneliminar.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btneliminar.Image = ((System.Drawing.Image)(resources.GetObject("btneliminar.Image")));
            this.btneliminar.Location = new System.Drawing.Point(391, 51);
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Size = new System.Drawing.Size(82, 23);
            this.btneliminar.TabIndex = 61;
            this.btneliminar.Text = "Eliminar";
            this.btneliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btneliminar.UseVisualStyleBackColor = true;
            // 
            // btnmodificar
            // 
            this.btnmodificar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnmodificar.Enabled = false;
            this.btnmodificar.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmodificar.Image = ((System.Drawing.Image)(resources.GetObject("btnmodificar.Image")));
            this.btnmodificar.Location = new System.Drawing.Point(537, 10);
            this.btnmodificar.Name = "btnmodificar";
            this.btnmodificar.Size = new System.Drawing.Size(82, 23);
            this.btnmodificar.TabIndex = 62;
            this.btnmodificar.Text = "Modificar";
            this.btnmodificar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnmodificar.UseVisualStyleBackColor = true;
            this.btnmodificar.Click += new System.EventHandler(this.btnmodificar_Click);
            // 
            // btnexportarExcel
            // 
            this.btnexportarExcel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnexportarExcel.Enabled = false;
            this.btnexportarExcel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnexportarExcel.Image = ((System.Drawing.Image)(resources.GetObject("btnexportarExcel.Image")));
            this.btnexportarExcel.Location = new System.Drawing.Point(276, 372);
            this.btnexportarExcel.Name = "btnexportarExcel";
            this.btnexportarExcel.Size = new System.Drawing.Size(82, 23);
            this.btnexportarExcel.TabIndex = 68;
            this.btnexportarExcel.Text = "A Excel";
            this.btnexportarExcel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnexportarExcel.UseVisualStyleBackColor = true;
            this.btnexportarExcel.Visible = false;
            this.btnexportarExcel.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnaceptar
            // 
            this.btnaceptar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnaceptar.BackColor = System.Drawing.Color.SeaGreen;
            this.btnaceptar.FlatAppearance.BorderColor = System.Drawing.Color.Olive;
            this.btnaceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnaceptar.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnaceptar.ForeColor = System.Drawing.Color.White;
            this.btnaceptar.Location = new System.Drawing.Point(451, 372);
            this.btnaceptar.Name = "btnaceptar";
            this.btnaceptar.Size = new System.Drawing.Size(83, 23);
            this.btnaceptar.TabIndex = 359;
            this.btnaceptar.Text = "Procesar";
            this.btnaceptar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnaceptar.UseVisualStyleBackColor = false;
            this.btnaceptar.Click += new System.EventHandler(this.btnaceptar_Click);
            // 
            // btncancelar
            // 
            this.btncancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btncancelar.BackColor = System.Drawing.Color.Crimson;
            this.btncancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btncancelar.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btncancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncancelar.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncancelar.ForeColor = System.Drawing.Color.White;
            this.btncancelar.Location = new System.Drawing.Point(540, 372);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(83, 23);
            this.btncancelar.TabIndex = 358;
            this.btncancelar.Text = "Cancelar";
            this.btncancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btncancelar.UseVisualStyleBackColor = false;
            this.btncancelar.Click += new System.EventHandler(this.btncancelar_Click);
            // 
            // lbltotalRegistros
            // 
            this.lbltotalRegistros.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbltotalRegistros.AutoSize = true;
            this.lbltotalRegistros.BackColor = System.Drawing.Color.Transparent;
            this.lbltotalRegistros.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltotalRegistros.Location = new System.Drawing.Point(12, 382);
            this.lbltotalRegistros.Name = "lbltotalRegistros";
            this.lbltotalRegistros.Size = new System.Drawing.Size(86, 13);
            this.lbltotalRegistros.TabIndex = 363;
            this.lbltotalRegistros.Text = "Total Registros:";
            // 
            // duplicadorBase1
            // 
            this.duplicadorBase1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.duplicadorBase1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(129)))), ((int)(((byte)(189)))));
            this.duplicadorBase1.dataTable = this.dtgconten;
            this.duplicadorBase1.img = ((System.Drawing.Image)(resources.GetObject("duplicadorBase1.img")));
            this.duplicadorBase1.Location = new System.Drawing.Point(589, 53);
            this.duplicadorBase1.Name = "duplicadorBase1";
            this.duplicadorBase1.Size = new System.Drawing.Size(15, 15);
            this.duplicadorBase1.TabIndex = 364;
            // 
            // cboperiodo
            // 
            this.cboperiodo.Enabled = false;
            this.cboperiodo.FechaConDiaActual = new System.DateTime(2021, 8, 31, 0, 0, 0, 0);
            this.cboperiodo.FechaFinMes = new System.DateTime(2021, 8, 31, 0, 0, 0, 0);
            this.cboperiodo.FechaInicioMes = new System.DateTime(2021, 8, 1, 0, 0, 0, 0);
            this.cboperiodo.Location = new System.Drawing.Point(12, 12);
            this.cboperiodo.Name = "cboperiodo";
            this.cboperiodo.Size = new System.Drawing.Size(219, 21);
            this.cboperiodo.TabIndex = 366;
            this.cboperiodo.VerAño = true;
            this.cboperiodo.VerMes = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 13);
            this.label1.TabIndex = 363;
            this.label1.Text = "Listado de Comisiones:";
            // 
            // btnPaso1
            // 
            this.btnPaso1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(129)))), ((int)(((byte)(189)))));
            this.btnPaso1.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnPaso1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPaso1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPaso1.ForeColor = System.Drawing.Color.White;
            this.btnPaso1.Location = new System.Drawing.Point(232, 11);
            this.btnPaso1.Margin = new System.Windows.Forms.Padding(0);
            this.btnPaso1.Name = "btnPaso1";
            this.btnPaso1.Size = new System.Drawing.Size(75, 22);
            this.btnPaso1.TabIndex = 367;
            this.btnPaso1.Tag = "1";
            this.btnPaso1.Text = "Avanzar";
            this.btnPaso1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnPaso1.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnPaso1.UseVisualStyleBackColor = false;
            this.btnPaso1.Click += new System.EventHandler(this.btnPaso1_Click);
            // 
            // frmAfpsComisiones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 401);
            this.Controls.Add(this.btnPaso1);
            this.Controls.Add(this.cboperiodo);
            this.Controls.Add(this.duplicadorBase1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbltotalRegistros);
            this.Controls.Add(this.btnexportarExcel);
            this.Controls.Add(this.dtgconten);
            this.Controls.Add(this.btneliminar);
            this.Controls.Add(this.btnmodificar);
            this.Controls.Add(this.btncancelar);
            this.Controls.Add(this.btnaceptar);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinimumSize = new System.Drawing.Size(650, 440);
            this.Name = "frmAfpsComisiones";
            this.Nombre = "AFP";
            this.Text = "AFP";
            this.Load += new System.EventHandler(this.frmAfps_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgconten)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Dtgconten dtgconten;
        private System.Windows.Forms.Button btneliminar;
        private System.Windows.Forms.Button btnmodificar;
        private System.Windows.Forms.Button btnexportarExcel;
        private ButtonPer btnaceptar;
        private ButtonPer btncancelar;
        private System.Windows.Forms.Label lbltotalRegistros;
        private DuplicadorBase duplicadorBase1;
        private ComboMesAño cboperiodo;
        private System.Windows.Forms.Label label1;
        private ButtonPer btnPaso1;
        private System.Windows.Forms.DataGridViewTextBoxColumn xid;
        private System.Windows.Forms.DataGridViewTextBoxColumn xPeriodo;
        private System.Windows.Forms.DataGridViewTextBoxColumn xAfp;
        private System.Windows.Forms.DataGridViewTextBoxColumn xAporte;
        private System.Windows.Forms.DataGridViewTextBoxColumn xSeguro;
        private System.Windows.Forms.DataGridViewTextBoxColumn xComision;
        private System.Windows.Forms.DataGridViewTextBoxColumn xRMA;
        private System.Windows.Forms.DataGridViewTextBoxColumn xusuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn xFecha;
    }
}