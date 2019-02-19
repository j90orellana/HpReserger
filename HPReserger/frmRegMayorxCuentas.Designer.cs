namespace HPReserger
{
    partial class frmRegMayorxCuentas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRegMayorxCuentas));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.button1 = new System.Windows.Forms.Button();
            this.btnexcel = new System.Windows.Forms.Button();
            this.btncancelar = new System.Windows.Forms.Button();
            this.lblmensaje = new System.Windows.Forms.Label();
            this.btngenerar = new System.Windows.Forms.Button();
            this.comboMesAño1 = new HpResergerUserControls.ComboMesAño();
            this.separadorOre1 = new HpResergerUserControls.SeparadorOre();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtgconten = new HpResergerUserControls.Dtgconten();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.txtcuenta = new HpResergerUserControls.TextBoxPer();
            ((System.ComponentModel.ISupportInitialize)(this.dtgconten)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(549, 530);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(82, 23);
            this.button1.TabIndex = 386;
            this.button1.Text = "Pdf";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            // 
            // btnexcel
            // 
            this.btnexcel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnexcel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnexcel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnexcel.Image = ((System.Drawing.Image)(resources.GetObject("btnexcel.Image")));
            this.btnexcel.Location = new System.Drawing.Point(637, 530);
            this.btnexcel.Name = "btnexcel";
            this.btnexcel.Size = new System.Drawing.Size(82, 23);
            this.btnexcel.TabIndex = 385;
            this.btnexcel.Text = "Excel";
            this.btnexcel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnexcel.UseVisualStyleBackColor = true;
            this.btnexcel.Click += new System.EventHandler(this.btnexcel_Click);
            // 
            // btncancelar
            // 
            this.btncancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btncancelar.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncancelar.Image = ((System.Drawing.Image)(resources.GetObject("btncancelar.Image")));
            this.btncancelar.Location = new System.Drawing.Point(1129, 530);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(85, 23);
            this.btncancelar.TabIndex = 384;
            this.btncancelar.Text = "Cancelar";
            this.btncancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btncancelar.UseVisualStyleBackColor = true;
            this.btncancelar.Click += new System.EventHandler(this.btncancelar_Click);
            // 
            // lblmensaje
            // 
            this.lblmensaje.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblmensaje.AutoSize = true;
            this.lblmensaje.BackColor = System.Drawing.Color.Transparent;
            this.lblmensaje.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmensaje.Location = new System.Drawing.Point(14, 535);
            this.lblmensaje.Name = "lblmensaje";
            this.lblmensaje.Size = new System.Drawing.Size(110, 13);
            this.lblmensaje.TabIndex = 383;
            this.lblmensaje.Text = "Total de Registros: 0";
            // 
            // btngenerar
            // 
            this.btngenerar.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btngenerar.Image = ((System.Drawing.Image)(resources.GetObject("btngenerar.Image")));
            this.btngenerar.Location = new System.Drawing.Point(295, 54);
            this.btngenerar.Name = "btngenerar";
            this.btngenerar.Size = new System.Drawing.Size(85, 23);
            this.btngenerar.TabIndex = 382;
            this.btngenerar.Text = "Generar";
            this.btngenerar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btngenerar.UseVisualStyleBackColor = true;
            this.btngenerar.Click += new System.EventHandler(this.btngenerar_Click);
            // 
            // comboMesAño1
            // 
            this.comboMesAño1.AutoSize = true;
            this.comboMesAño1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.comboMesAño1.BackColor = System.Drawing.Color.Transparent;
            this.comboMesAño1.FechaConDiaActual = new System.DateTime(2019, 2, 16, 0, 0, 0, 0);
            this.comboMesAño1.FechaFinMes = new System.DateTime(2019, 2, 28, 0, 0, 0, 0);
            this.comboMesAño1.FechaInicioMes = new System.DateTime(2019, 2, 1, 0, 0, 0, 0);
            this.comboMesAño1.Location = new System.Drawing.Point(71, 32);
            this.comboMesAño1.Name = "comboMesAño1";
            this.comboMesAño1.Size = new System.Drawing.Size(218, 24);
            this.comboMesAño1.TabIndex = 379;
            // 
            // separadorOre1
            // 
            this.separadorOre1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.separadorOre1.Location = new System.Drawing.Point(1, 79);
            this.separadorOre1.MaximumSize = new System.Drawing.Size(2000, 2);
            this.separadorOre1.MinimumSize = new System.Drawing.Size(0, 2);
            this.separadorOre1.Name = "separadorOre1";
            this.separadorOre1.Size = new System.Drawing.Size(1284, 2);
            this.separadorOre1.TabIndex = 378;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(13, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 13);
            this.label4.TabIndex = 374;
            this.label4.Text = "INGRESE CUENTA:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(13, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 376;
            this.label2.Text = "PERIODO:\r\n";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 19);
            this.label1.TabIndex = 377;
            this.label1.Text = "MAYOR DE CUENTAS";
            // 
            // dtgconten
            // 
            this.dtgconten.AllowUserToAddRows = false;
            this.dtgconten.AllowUserToDeleteRows = false;
            this.dtgconten.AllowUserToResizeColumns = false;
            this.dtgconten.AllowUserToResizeRows = false;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(230)))), ((int)(((byte)(241)))));
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
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(207)))), ((int)(((byte)(241)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgconten.DefaultCellStyle = dataGridViewCellStyle9;
            this.dtgconten.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dtgconten.EnableHeadersVisualStyles = false;
            this.dtgconten.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(179)))), ((int)(((byte)(215)))));
            this.dtgconten.Location = new System.Drawing.Point(16, 79);
            this.dtgconten.Name = "dtgconten";
            this.dtgconten.ReadOnly = true;
            this.dtgconten.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dtgconten.RowHeadersVisible = false;
            this.dtgconten.RowTemplate.Height = 18;
            this.dtgconten.Size = new System.Drawing.Size(1198, 445);
            this.dtgconten.TabIndex = 373;
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // txtcuenta
            // 
            this.txtcuenta.BackColor = System.Drawing.Color.White;
            this.txtcuenta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtcuenta.ColorFondoMouseEncima = System.Drawing.Color.Empty;
            this.txtcuenta.ColorFondoMousePresionado = System.Drawing.Color.Empty;
            this.txtcuenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcuenta.ForeColor = System.Drawing.Color.Black;
            this.txtcuenta.Format = null;
            this.txtcuenta.Location = new System.Drawing.Point(124, 55);
            this.txtcuenta.MaxLength = 100;
            this.txtcuenta.Name = "txtcuenta";
            this.txtcuenta.NextControlOnEnter = null;
            this.txtcuenta.Size = new System.Drawing.Size(165, 21);
            this.txtcuenta.TabIndex = 387;
            this.txtcuenta.Text = "00";
            this.txtcuenta.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtcuenta.TextoDefecto = "00";
            this.txtcuenta.TextoDefectoColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(129)))), ((int)(((byte)(189)))));
            this.txtcuenta.TiposDatos = HpResergerUserControls.TextBoxPer.ListaTipos.MayusculaCadaPalabra;
            // 
            // frmRegMayorxCuentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1225, 561);
            this.Controls.Add(this.txtcuenta);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnexcel);
            this.Controls.Add(this.btncancelar);
            this.Controls.Add(this.lblmensaje);
            this.Controls.Add(this.btngenerar);
            this.Controls.Add(this.comboMesAño1);
            this.Controls.Add(this.separadorOre1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtgconten);
            this.MinimumSize = new System.Drawing.Size(1241, 600);
            this.Name = "frmRegMayorxCuentas";
            this.Nombre = "Mayor por Cuentas";
            this.Text = "Mayor por Cuentas";
            this.Load += new System.EventHandler(this.frmRegMayorxCuentas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgconten)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnexcel;
        private System.Windows.Forms.Button btncancelar;
        private System.Windows.Forms.Label lblmensaje;
        private System.Windows.Forms.Button btngenerar;
        private HpResergerUserControls.ComboMesAño comboMesAño1;
        private HpResergerUserControls.SeparadorOre separadorOre1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private HpResergerUserControls.Dtgconten dtgconten;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private HpResergerUserControls.TextBoxPer txtcuenta;
    }
}