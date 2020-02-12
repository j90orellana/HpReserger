namespace HPReserger.ModuloReportes
{
    partial class frmFlujodeGastosDoc
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
            this.label4 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.chklist = new System.Windows.Forms.CheckedListBox();
            this.cboperiodohasta = new HpResergerUserControls.ComboMesAño();
            this.cboperiodode = new HpResergerUserControls.ComboMesAño();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnGenerar = new HpResergerUserControls.ButtonPer();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.rbPagos = new System.Windows.Forms.RadioButton();
            this.rbRegistro = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(136, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(24, 13);
            this.label4.TabIndex = 406;
            this.label4.Text = "De:";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.BackColor = System.Drawing.Color.Transparent;
            this.label20.ForeColor = System.Drawing.Color.Black;
            this.label20.Location = new System.Drawing.Point(121, 165);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(39, 13);
            this.label20.TabIndex = 407;
            this.label20.Text = "Hasta:";
            // 
            // chklist
            // 
            this.chklist.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.chklist.ColumnWidth = 200;
            this.chklist.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chklist.Location = new System.Drawing.Point(12, 27);
            this.chklist.Name = "chklist";
            this.chklist.Size = new System.Drawing.Size(472, 66);
            this.chklist.TabIndex = 404;
            this.chklist.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.chklist_ItemCheck);
            // 
            // cboperiodohasta
            // 
            this.cboperiodohasta.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.cboperiodohasta.BackColor = System.Drawing.Color.Transparent;
            this.cboperiodohasta.FechaConDiaActual = new System.DateTime(2020, 2, 11, 0, 0, 0, 0);
            this.cboperiodohasta.FechaFinMes = new System.DateTime(2020, 2, 29, 0, 0, 0, 0);
            this.cboperiodohasta.FechaInicioMes = new System.DateTime(2020, 2, 1, 0, 0, 0, 0);
            this.cboperiodohasta.Location = new System.Drawing.Point(158, 160);
            this.cboperiodohasta.Name = "cboperiodohasta";
            this.cboperiodohasta.Size = new System.Drawing.Size(218, 22);
            this.cboperiodohasta.TabIndex = 402;
            this.cboperiodohasta.VerAño = true;
            this.cboperiodohasta.VerMes = true;
            this.cboperiodohasta.CambioFechas += new System.EventHandler(this.cboperiodohasta_CambioFechas_1);
            // 
            // cboperiodode
            // 
            this.cboperiodode.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.cboperiodode.BackColor = System.Drawing.Color.Transparent;
            this.cboperiodode.FechaConDiaActual = new System.DateTime(2020, 2, 11, 0, 0, 0, 0);
            this.cboperiodode.FechaFinMes = new System.DateTime(2020, 2, 29, 0, 0, 0, 0);
            this.cboperiodode.FechaInicioMes = new System.DateTime(2020, 2, 1, 0, 0, 0, 0);
            this.cboperiodode.Location = new System.Drawing.Point(158, 135);
            this.cboperiodode.Name = "cboperiodode";
            this.cboperiodode.Size = new System.Drawing.Size(218, 22);
            this.cboperiodode.TabIndex = 401;
            this.cboperiodode.VerAño = true;
            this.cboperiodode.VerMes = true;
            this.cboperiodode.CambioFechas += new System.EventHandler(this.cboperiodode_CambioFechas_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(221, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 403;
            this.label3.Text = "EMPRESA";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(221, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 406;
            this.label1.Text = "PERIODO";
            // 
            // btnGenerar
            // 
            this.btnGenerar.BackColor = System.Drawing.Color.SeaGreen;
            this.btnGenerar.FlatAppearance.BorderColor = System.Drawing.Color.Olive;
            this.btnGenerar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerar.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerar.ForeColor = System.Drawing.Color.White;
            this.btnGenerar.Location = new System.Drawing.Point(207, 196);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(83, 23);
            this.btnGenerar.TabIndex = 408;
            this.btnGenerar.Text = "Generar";
            this.btnGenerar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGenerar.UseVisualStyleBackColor = false;
            this.btnGenerar.Click += new System.EventHandler(this.btnTxt_Click);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // rbPagos
            // 
            this.rbPagos.AutoSize = true;
            this.rbPagos.BackColor = System.Drawing.Color.Transparent;
            this.rbPagos.Checked = true;
            this.rbPagos.Location = new System.Drawing.Point(106, 99);
            this.rbPagos.Name = "rbPagos";
            this.rbPagos.Size = new System.Drawing.Size(133, 17);
            this.rbPagos.TabIndex = 409;
            this.rbPagos.TabStop = true;
            this.rbPagos.Text = "Flujo de Caja - Pagos";
            this.rbPagos.UseVisualStyleBackColor = false;
            this.rbPagos.CheckedChanged += new System.EventHandler(this.rbPagos_CheckedChanged);
            // 
            // rbRegistro
            // 
            this.rbRegistro.AutoSize = true;
            this.rbRegistro.BackColor = System.Drawing.Color.Transparent;
            this.rbRegistro.Location = new System.Drawing.Point(245, 99);
            this.rbRegistro.Name = "rbRegistro";
            this.rbRegistro.Size = new System.Drawing.Size(145, 17);
            this.rbRegistro.TabIndex = 409;
            this.rbRegistro.Text = "Flujo de Caja - Registro";
            this.rbRegistro.UseVisualStyleBackColor = false;
            this.rbRegistro.CheckedChanged += new System.EventHandler(this.rbRegistro_CheckedChanged);
            // 
            // frmFlujodeGastosDoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 228);
            this.Controls.Add(this.rbRegistro);
            this.Controls.Add(this.rbPagos);
            this.Controls.Add(this.btnGenerar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.chklist);
            this.Controls.Add(this.cboperiodohasta);
            this.Controls.Add(this.cboperiodode);
            this.Controls.Add(this.label3);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmFlujodeGastosDoc";
            this.Nombre = "Flujo de Caja";
            this.Text = "Flujo de Caja";
            this.Load += new System.EventHandler(this.frmFlujodeGastosDoc_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.CheckedListBox chklist;
        private HpResergerUserControls.ComboMesAño cboperiodohasta;
        private HpResergerUserControls.ComboMesAño cboperiodode;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private HpResergerUserControls.ButtonPer btnGenerar;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.RadioButton rbPagos;
        private System.Windows.Forms.RadioButton rbRegistro;
    }
}