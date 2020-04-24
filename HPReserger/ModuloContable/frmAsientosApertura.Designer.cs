namespace HPReserger
{
    partial class frmAsientosApertura
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAsientosApertura));
            this.label1 = new System.Windows.Forms.Label();
            this.dtgconten = new HpResergerUserControls.Dtgconten();
            this.xCuentaDebe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xSolesDebe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xSolesHaber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xDolaresDebe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xDolaresHaber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnPreliminar = new System.Windows.Forms.Button();
            this.btncancelar = new System.Windows.Forms.Button();
            this.cboempresa = new System.Windows.Forms.ComboBox();
            this.btnAplicar = new System.Windows.Forms.Button();
            this.btnExcel = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.lblmsg = new System.Windows.Forms.Label();
            this.cboproyectoCierre = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.comboMesAño = new HpResergerUserControls.ComboMesAño();
            this.lbl1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cboProyectoApertura = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtgconten)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Empresa:";
            // 
            // dtgconten
            // 
            this.dtgconten.AllowUserToAddRows = false;
            this.dtgconten.AllowUserToOrderColumns = true;
            this.dtgconten.AllowUserToResizeColumns = false;
            this.dtgconten.AllowUserToResizeRows = false;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(230)))), ((int)(((byte)(241)))));
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(191)))), ((int)(((byte)(231)))));
            this.dtgconten.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle15;
            this.dtgconten.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgconten.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgconten.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(218)))), ((int)(((byte)(231)))));
            this.dtgconten.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgconten.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.dtgconten.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(129)))), ((int)(((byte)(189)))));
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle16.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.Color.DeepSkyBlue;
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgconten.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle16;
            this.dtgconten.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgconten.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.xCuentaDebe,
            this.xSolesDebe,
            this.xSolesHaber,
            this.xDolaresDebe,
            this.xDolaresHaber});
            dataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle21.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle21.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle21.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle21.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(207)))), ((int)(((byte)(241)))));
            dataGridViewCellStyle21.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle21.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgconten.DefaultCellStyle = dataGridViewCellStyle21;
            this.dtgconten.EnableHeadersVisualStyles = false;
            this.dtgconten.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(179)))), ((int)(((byte)(215)))));
            this.dtgconten.Location = new System.Drawing.Point(15, 101);
            this.dtgconten.Name = "dtgconten";
            this.dtgconten.ReadOnly = true;
            this.dtgconten.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dtgconten.RowHeadersVisible = false;
            this.dtgconten.RowTemplate.Height = 18;
            this.dtgconten.Size = new System.Drawing.Size(895, 374);
            this.dtgconten.TabIndex = 4;
            this.dtgconten.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgconten1_CellContentClick);
            // 
            // xCuentaDebe
            // 
            this.xCuentaDebe.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.xCuentaDebe.DataPropertyName = "CuentaContable";
            this.xCuentaDebe.HeaderText = "Cuenta";
            this.xCuentaDebe.MinimumWidth = 200;
            this.xCuentaDebe.Name = "xCuentaDebe";
            this.xCuentaDebe.ReadOnly = true;
            // 
            // xSolesDebe
            // 
            this.xSolesDebe.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.xSolesDebe.DataPropertyName = "SolesDebe";
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle17.Format = "n2";
            this.xSolesDebe.DefaultCellStyle = dataGridViewCellStyle17;
            this.xSolesDebe.HeaderText = "Soles Debe";
            this.xSolesDebe.MinimumWidth = 60;
            this.xSolesDebe.Name = "xSolesDebe";
            this.xSolesDebe.ReadOnly = true;
            this.xSolesDebe.Width = 60;
            // 
            // xSolesHaber
            // 
            this.xSolesHaber.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.xSolesHaber.DataPropertyName = "SolesHaber";
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle18.Format = "n2";
            this.xSolesHaber.DefaultCellStyle = dataGridViewCellStyle18;
            this.xSolesHaber.HeaderText = "Soles Haber";
            this.xSolesHaber.MinimumWidth = 60;
            this.xSolesHaber.Name = "xSolesHaber";
            this.xSolesHaber.ReadOnly = true;
            this.xSolesHaber.Width = 60;
            // 
            // xDolaresDebe
            // 
            this.xDolaresDebe.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.xDolaresDebe.DataPropertyName = "DolaresDebe";
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle19.Format = "n2";
            this.xDolaresDebe.DefaultCellStyle = dataGridViewCellStyle19;
            this.xDolaresDebe.HeaderText = "Dolares Debe";
            this.xDolaresDebe.MinimumWidth = 60;
            this.xDolaresDebe.Name = "xDolaresDebe";
            this.xDolaresDebe.ReadOnly = true;
            this.xDolaresDebe.Width = 60;
            // 
            // xDolaresHaber
            // 
            this.xDolaresHaber.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.xDolaresHaber.DataPropertyName = "DolaresHaber";
            dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle20.Format = "n2";
            this.xDolaresHaber.DefaultCellStyle = dataGridViewCellStyle20;
            this.xDolaresHaber.HeaderText = "Dolares Haber";
            this.xDolaresHaber.MinimumWidth = 60;
            this.xDolaresHaber.Name = "xDolaresHaber";
            this.xDolaresHaber.ReadOnly = true;
            this.xDolaresHaber.Width = 60;
            // 
            // btnPreliminar
            // 
            this.btnPreliminar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPreliminar.Enabled = false;
            this.btnPreliminar.Image = ((System.Drawing.Image)(resources.GetObject("btnPreliminar.Image")));
            this.btnPreliminar.Location = new System.Drawing.Point(826, 76);
            this.btnPreliminar.Name = "btnPreliminar";
            this.btnPreliminar.Size = new System.Drawing.Size(84, 23);
            this.btnPreliminar.TabIndex = 41;
            this.btnPreliminar.Text = "Preliminar";
            this.btnPreliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPreliminar.UseVisualStyleBackColor = true;
            this.btnPreliminar.EnabledChanged += new System.EventHandler(this.btnPreliminar_EnabledChanged);
            this.btnPreliminar.Click += new System.EventHandler(this.btnaceptar_Click);
            // 
            // btncancelar
            // 
            this.btncancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btncancelar.Image = ((System.Drawing.Image)(resources.GetObject("btncancelar.Image")));
            this.btncancelar.Location = new System.Drawing.Point(835, 481);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(75, 23);
            this.btncancelar.TabIndex = 40;
            this.btncancelar.Text = "Cancelar";
            this.btncancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btncancelar.UseVisualStyleBackColor = true;
            this.btncancelar.Click += new System.EventHandler(this.btncancelar_Click);
            // 
            // cboempresa
            // 
            this.cboempresa.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboempresa.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboempresa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(218)))), ((int)(((byte)(231)))));
            this.cboempresa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboempresa.FormattingEnabled = true;
            this.cboempresa.Location = new System.Drawing.Point(65, 17);
            this.cboempresa.Name = "cboempresa";
            this.cboempresa.Size = new System.Drawing.Size(394, 21);
            this.cboempresa.TabIndex = 42;
            this.cboempresa.SelectedIndexChanged += new System.EventHandler(this.cboempresa_SelectedIndexChanged);
            // 
            // btnAplicar
            // 
            this.btnAplicar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAplicar.Image = ((System.Drawing.Image)(resources.GetObject("btnAplicar.Image")));
            this.btnAplicar.Location = new System.Drawing.Point(719, 481);
            this.btnAplicar.Name = "btnAplicar";
            this.btnAplicar.Size = new System.Drawing.Size(110, 23);
            this.btnAplicar.TabIndex = 43;
            this.btnAplicar.Text = "Aplicar Asiento";
            this.btnAplicar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAplicar.UseVisualStyleBackColor = true;
            this.btnAplicar.Click += new System.EventHandler(this.btncerrar_Click);
            // 
            // btnExcel
            // 
            this.btnExcel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnExcel.Image = ((System.Drawing.Image)(resources.GetObject("btnExcel.Image")));
            this.btnExcel.Location = new System.Drawing.Point(424, 481);
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.Size = new System.Drawing.Size(75, 23);
            this.btnExcel.TabIndex = 43;
            this.btnExcel.Text = "Excel";
            this.btnExcel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnExcel.UseVisualStyleBackColor = true;
            this.btnExcel.Click += new System.EventHandler(this.btnExcel_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(15, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(232, 13);
            this.label3.TabIndex = 45;
            this.label3.Text = "Resultado del Calculo de Asientos de Cierre";
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // lblmsg
            // 
            this.lblmsg.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblmsg.AutoSize = true;
            this.lblmsg.BackColor = System.Drawing.Color.Transparent;
            this.lblmsg.Location = new System.Drawing.Point(15, 486);
            this.lblmsg.Name = "lblmsg";
            this.lblmsg.Size = new System.Drawing.Size(110, 13);
            this.lblmsg.TabIndex = 72;
            this.lblmsg.Text = "Total de Registros: 0";
            // 
            // cboproyectoCierre
            // 
            this.cboproyectoCierre.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboproyectoCierre.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboproyectoCierre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(218)))), ((int)(((byte)(231)))));
            this.cboproyectoCierre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboproyectoCierre.FormattingEnabled = true;
            this.cboproyectoCierre.Location = new System.Drawing.Point(564, 17);
            this.cboproyectoCierre.Name = "cboproyectoCierre";
            this.cboproyectoCierre.Size = new System.Drawing.Size(253, 21);
            this.cboproyectoCierre.TabIndex = 73;
            this.cboproyectoCierre.SelectedIndexChanged += new System.EventHandler(this.cboproyecto_SelectedIndexChanged);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.Transparent;
            this.label16.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(465, 21);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(87, 13);
            this.label16.TabIndex = 74;
            this.label16.Text = "Proyecto Cierre:";
            // 
            // comboMesAño
            // 
            this.comboMesAño.BackColor = System.Drawing.Color.Transparent;
            this.comboMesAño.FechaConDiaActual = new System.DateTime(2020, 4, 23, 0, 0, 0, 0);
            this.comboMesAño.FechaFinMes = new System.DateTime(2020, 4, 30, 0, 0, 0, 0);
            this.comboMesAño.FechaInicioMes = new System.DateTime(2020, 4, 1, 0, 0, 0, 0);
            this.comboMesAño.Location = new System.Drawing.Point(19, 38);
            this.comboMesAño.Name = "comboMesAño";
            this.comboMesAño.Size = new System.Drawing.Size(100, 26);
            this.comboMesAño.TabIndex = 75;
            this.comboMesAño.VerAño = true;
            this.comboMesAño.VerMes = false;
            this.comboMesAño.CambioFechas += new System.EventHandler(this.comboMesAño_CambioFechas);
            // 
            // lbl1
            // 
            this.lbl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl1.BackColor = System.Drawing.Color.Transparent;
            this.lbl1.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1.ForeColor = System.Drawing.Color.Crimson;
            this.lbl1.Location = new System.Drawing.Point(16, 67);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(802, 19);
            this.lbl1.TabIndex = 76;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(465, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 13);
            this.label2.TabIndex = 74;
            this.label2.Text = "Proyecto Apertura:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // cboProyectoApertura
            // 
            this.cboProyectoApertura.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboProyectoApertura.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboProyectoApertura.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(218)))), ((int)(((byte)(231)))));
            this.cboProyectoApertura.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboProyectoApertura.FormattingEnabled = true;
            this.cboProyectoApertura.Location = new System.Drawing.Point(564, 41);
            this.cboProyectoApertura.Name = "cboProyectoApertura";
            this.cboProyectoApertura.Size = new System.Drawing.Size(253, 21);
            this.cboProyectoApertura.TabIndex = 73;
            this.cboProyectoApertura.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // frmAsientosApertura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(922, 513);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.cboProyectoApertura);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cboproyectoCierre);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.lblmsg);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnExcel);
            this.Controls.Add(this.btnAplicar);
            this.Controls.Add(this.cboempresa);
            this.Controls.Add(this.btnPreliminar);
            this.Controls.Add(this.btncancelar);
            this.Controls.Add(this.dtgconten);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboMesAño);
            this.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinimumSize = new System.Drawing.Size(938, 552);
            this.Name = "frmAsientosApertura";
            this.Nombre = "Proceso de Asientos de Cierre y Apertura";
            this.Text = "Proceso de Asientos de Cierre y Apertura";
            this.Load += new System.EventHandler(this.frmcierremensual_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgconten)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private HpResergerUserControls.Dtgconten dtgconten;
        private System.Windows.Forms.Button btnPreliminar;
        private System.Windows.Forms.Button btncancelar;
        private System.Windows.Forms.ComboBox cboempresa;
        private System.Windows.Forms.Button btnAplicar;
        private System.Windows.Forms.Button btnExcel;
        private System.Windows.Forms.Label label3;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label lblmsg;
        private System.Windows.Forms.ComboBox cboproyectoCierre;
        private System.Windows.Forms.Label label16;
        private HpResergerUserControls.ComboMesAño comboMesAño;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.DataGridViewTextBoxColumn xCuentaDebe;
        private System.Windows.Forms.DataGridViewTextBoxColumn xSolesDebe;
        private System.Windows.Forms.DataGridViewTextBoxColumn xSolesHaber;
        private System.Windows.Forms.DataGridViewTextBoxColumn xDolaresDebe;
        private System.Windows.Forms.DataGridViewTextBoxColumn xDolaresHaber;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboProyectoApertura;
    }
}