namespace HPReserger.ModuloFinanzas
{
    partial class FrmConciliarBanco
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.cboempresa = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cboCuentasBancarias = new System.Windows.Forms.ComboBox();
            this.comboMesAño1 = new HpResergerUserControls.ComboMesAño();
            this.label3 = new System.Windows.Forms.Label();
            this.btnPaso1 = new HpResergerUserControls.ButtonPer();
            this.BtnCerrar = new HpResergerUserControls.ButtonPer();
            this.btnTxt = new HpResergerUserControls.ButtonPer();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtRutaExcel = new HpResergerUserControls.TextBoxPer();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnCargar = new HpResergerUserControls.ButtonPer();
            this.btnPaso2 = new HpResergerUserControls.ButtonPer();
            this.dtgconten = new HpResergerUserControls.Dtgconten();
            this.xCtaBancaria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xSaldo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xNroCuenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtgconten)).BeginInit();
            this.SuspendLayout();
            // 
            // cboempresa
            // 
            this.cboempresa.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboempresa.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboempresa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(218)))), ((int)(((byte)(231)))));
            this.cboempresa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboempresa.FormattingEnabled = true;
            this.cboempresa.Location = new System.Drawing.Point(64, 23);
            this.cboempresa.Name = "cboempresa";
            this.cboempresa.Size = new System.Drawing.Size(394, 21);
            this.cboempresa.TabIndex = 44;
            this.cboempresa.SelectedIndexChanged += new System.EventHandler(this.cboempresa_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 43;
            this.label1.Text = "Empresa:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 43;
            this.label2.Text = "Cuenta:";
            // 
            // cboCuentasBancarias
            // 
            this.cboCuentasBancarias.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboCuentasBancarias.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboCuentasBancarias.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(218)))), ((int)(((byte)(231)))));
            this.cboCuentasBancarias.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCuentasBancarias.FormattingEnabled = true;
            this.cboCuentasBancarias.Location = new System.Drawing.Point(64, 47);
            this.cboCuentasBancarias.Name = "cboCuentasBancarias";
            this.cboCuentasBancarias.Size = new System.Drawing.Size(500, 21);
            this.cboCuentasBancarias.TabIndex = 44;
            this.cboCuentasBancarias.Click += new System.EventHandler(this.cboCuentasBancarias_Click);
            // 
            // comboMesAño1
            // 
            this.comboMesAño1.BackColor = System.Drawing.Color.Transparent;
            this.comboMesAño1.FechaConDiaActual = new System.DateTime(2020, 5, 13, 0, 0, 0, 0);
            this.comboMesAño1.FechaFinMes = new System.DateTime(2020, 5, 31, 0, 0, 0, 0);
            this.comboMesAño1.FechaInicioMes = new System.DateTime(2020, 5, 1, 0, 0, 0, 0);
            this.comboMesAño1.Location = new System.Drawing.Point(614, 44);
            this.comboMesAño1.Name = "comboMesAño1";
            this.comboMesAño1.Size = new System.Drawing.Size(197, 26);
            this.comboMesAño1.TabIndex = 45;
            this.comboMesAño1.VerAño = true;
            this.comboMesAño1.VerMes = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(564, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 43;
            this.label3.Text = "Periodo:";
            // 
            // btnPaso1
            // 
            this.btnPaso1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(129)))), ((int)(((byte)(189)))));
            this.btnPaso1.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnPaso1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPaso1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPaso1.ForeColor = System.Drawing.Color.White;
            this.btnPaso1.Location = new System.Drawing.Point(817, 46);
            this.btnPaso1.Name = "btnPaso1";
            this.btnPaso1.Size = new System.Drawing.Size(75, 23);
            this.btnPaso1.TabIndex = 46;
            this.btnPaso1.Text = "Avanzar";
            this.btnPaso1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPaso1.UseVisualStyleBackColor = false;
            this.btnPaso1.Click += new System.EventHandler(this.buttonPer1_Click);
            // 
            // BtnCerrar
            // 
            this.BtnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnCerrar.BackColor = System.Drawing.Color.Crimson;
            this.BtnCerrar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnCerrar.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.BtnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCerrar.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCerrar.ForeColor = System.Drawing.Color.White;
            this.BtnCerrar.Location = new System.Drawing.Point(809, 557);
            this.BtnCerrar.Name = "BtnCerrar";
            this.BtnCerrar.Size = new System.Drawing.Size(83, 23);
            this.BtnCerrar.TabIndex = 183;
            this.BtnCerrar.Text = "Cancelar";
            this.BtnCerrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnCerrar.UseVisualStyleBackColor = false;
            this.BtnCerrar.Click += new System.EventHandler(this.BtnCerrar_Click);
            // 
            // btnTxt
            // 
            this.btnTxt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTxt.BackColor = System.Drawing.Color.SeaGreen;
            this.btnTxt.FlatAppearance.BorderColor = System.Drawing.Color.Olive;
            this.btnTxt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTxt.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTxt.ForeColor = System.Drawing.Color.White;
            this.btnTxt.Location = new System.Drawing.Point(719, 557);
            this.btnTxt.Name = "btnTxt";
            this.btnTxt.Size = new System.Drawing.Size(83, 23);
            this.btnTxt.TabIndex = 184;
            this.btnTxt.Text = "Procesar";
            this.btnTxt.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTxt.UseVisualStyleBackColor = false;
            this.btnTxt.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(10, 8);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(277, 13);
            this.label4.TabIndex = 185;
            this.label4.Text = "1.- Seleccione Cuenta Bancaria y Periodo a Conciliar:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(10, 71);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(265, 13);
            this.label5.TabIndex = 185;
            this.label5.Text = "2.- Seleccione Excel de Movimientos de la Cuenta:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(28, 92);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 43;
            this.label6.Text = "Excel:";
            // 
            // txtRutaExcel
            // 
            this.txtRutaExcel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(218)))), ((int)(((byte)(231)))));
            this.txtRutaExcel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRutaExcel.ColorFondoMouseEncima = System.Drawing.Color.Empty;
            this.txtRutaExcel.ColorFondoMousePresionado = System.Drawing.Color.Empty;
            this.txtRutaExcel.Enabled = false;
            this.txtRutaExcel.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRutaExcel.ForeColor = System.Drawing.Color.Black;
            this.txtRutaExcel.Format = null;
            this.txtRutaExcel.Location = new System.Drawing.Point(64, 87);
            this.txtRutaExcel.Name = "txtRutaExcel";
            this.txtRutaExcel.NextControlOnEnter = null;
            this.txtRutaExcel.ReadOnly = true;
            this.txtRutaExcel.Size = new System.Drawing.Size(668, 22);
            this.txtRutaExcel.TabIndex = 186;
            this.txtRutaExcel.TextoDefecto = "";
            this.txtRutaExcel.TextoDefectoColor = System.Drawing.Color.White;
            this.txtRutaExcel.TiposDatos = HpResergerUserControls.TextBoxPer.ListaTipos.Todo;
            this.txtRutaExcel.TextChanged += new System.EventHandler(this.textBoxPer1_TextChanged);
            this.txtRutaExcel.DoubleClick += new System.EventHandler(this.textBoxPer1_DoubleClick);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "Archivos Excel|*.xls*";
            // 
            // btnCargar
            // 
            this.btnCargar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(129)))), ((int)(((byte)(189)))));
            this.btnCargar.Enabled = false;
            this.btnCargar.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnCargar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCargar.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCargar.ForeColor = System.Drawing.Color.White;
            this.btnCargar.Location = new System.Drawing.Point(738, 87);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(75, 23);
            this.btnCargar.TabIndex = 187;
            this.btnCargar.Text = "Buscar";
            this.btnCargar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCargar.UseVisualStyleBackColor = false;
            this.btnCargar.Click += new System.EventHandler(this.buttonPer1_Click_1);
            // 
            // btnPaso2
            // 
            this.btnPaso2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(129)))), ((int)(((byte)(189)))));
            this.btnPaso2.Enabled = false;
            this.btnPaso2.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnPaso2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPaso2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPaso2.ForeColor = System.Drawing.Color.White;
            this.btnPaso2.Location = new System.Drawing.Point(817, 87);
            this.btnPaso2.Name = "btnPaso2";
            this.btnPaso2.Size = new System.Drawing.Size(75, 23);
            this.btnPaso2.TabIndex = 46;
            this.btnPaso2.Text = "Avanzar";
            this.btnPaso2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPaso2.UseVisualStyleBackColor = false;
            this.btnPaso2.Click += new System.EventHandler(this.btnPaso2_Click);
            // 
            // dtgconten
            // 
            this.dtgconten.AllowUserToAddRows = false;
            this.dtgconten.AllowUserToOrderColumns = true;
            this.dtgconten.AllowUserToResizeColumns = false;
            this.dtgconten.AllowUserToResizeRows = false;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(230)))), ((int)(((byte)(241)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(191)))), ((int)(((byte)(231)))));
            this.dtgconten.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.dtgconten.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgconten.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgconten.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(218)))), ((int)(((byte)(231)))));
            this.dtgconten.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgconten.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.dtgconten.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(129)))), ((int)(((byte)(189)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.DeepSkyBlue;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgconten.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dtgconten.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgconten.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.xCtaBancaria,
            this.xSaldo,
            this.xNroCuenta});
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(207)))), ((int)(((byte)(241)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgconten.DefaultCellStyle = dataGridViewCellStyle9;
            this.dtgconten.Enabled = false;
            this.dtgconten.EnableHeadersVisualStyles = false;
            this.dtgconten.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(179)))), ((int)(((byte)(215)))));
            this.dtgconten.Location = new System.Drawing.Point(13, 116);
            this.dtgconten.Name = "dtgconten";
            this.dtgconten.ReadOnly = true;
            this.dtgconten.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dtgconten.RowHeadersVisible = false;
            this.dtgconten.RowTemplate.Height = 18;
            this.dtgconten.Size = new System.Drawing.Size(879, 435);
            this.dtgconten.TabIndex = 188;
            // 
            // xCtaBancaria
            // 
            this.xCtaBancaria.DataPropertyName = "CtaBancaria";
            this.xCtaBancaria.HeaderText = "Fecha";
            this.xCtaBancaria.Name = "xCtaBancaria";
            this.xCtaBancaria.ReadOnly = true;
            // 
            // xSaldo
            // 
            this.xSaldo.HeaderText = "Saldo";
            this.xSaldo.Name = "xSaldo";
            this.xSaldo.ReadOnly = true;
            // 
            // xNroCuenta
            // 
            this.xNroCuenta.DataPropertyName = "NroCuenta";
            this.xNroCuenta.HeaderText = "Operacion";
            this.xNroCuenta.MinimumWidth = 80;
            this.xNroCuenta.Name = "xNroCuenta";
            this.xNroCuenta.ReadOnly = true;
            // 
            // FrmConciliarBanco
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(902, 586);
            this.Controls.Add(this.dtgconten);
            this.Controls.Add(this.btnCargar);
            this.Controls.Add(this.txtRutaExcel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.BtnCerrar);
            this.Controls.Add(this.btnTxt);
            this.Controls.Add(this.btnPaso2);
            this.Controls.Add(this.btnPaso1);
            this.Controls.Add(this.comboMesAño1);
            this.Controls.Add(this.cboCuentasBancarias);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cboempresa);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "FrmConciliarBanco";
            this.Nombre = "Conciliación Bancaria";
            this.Text = "Conciliación Bancaria";
            this.Load += new System.EventHandler(this.FrmConciliarBanco_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgconten)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboempresa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboCuentasBancarias;
        private HpResergerUserControls.ComboMesAño comboMesAño1;
        private System.Windows.Forms.Label label3;
        private HpResergerUserControls.ButtonPer btnPaso1;
        private HpResergerUserControls.ButtonPer BtnCerrar;
        private HpResergerUserControls.ButtonPer btnTxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private HpResergerUserControls.TextBoxPer txtRutaExcel;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private HpResergerUserControls.ButtonPer btnCargar;
        private HpResergerUserControls.ButtonPer btnPaso2;
        private HpResergerUserControls.Dtgconten dtgconten;
        private System.Windows.Forms.DataGridViewTextBoxColumn xCtaBancaria;
        private System.Windows.Forms.DataGridViewTextBoxColumn xSaldo;
        private System.Windows.Forms.DataGridViewTextBoxColumn xNroCuenta;
    }
}