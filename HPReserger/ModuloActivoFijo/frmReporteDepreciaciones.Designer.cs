namespace HPReserger.ModuloActivoFijo
{
    partial class frmReporteDepreciaciones
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReporteDepreciaciones));
            this.btnProcesar = new HpResergerUserControls.ButtonPer();
            this.btncancelar = new System.Windows.Forms.Button();
            this.cbodesde = new HpResergerUserControls.ComboMesAño();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.SuspendLayout();
            // 
            // btnProcesar
            // 
            this.btnProcesar.BackColor = System.Drawing.Color.SeaGreen;
            this.btnProcesar.FlatAppearance.BorderColor = System.Drawing.Color.Olive;
            this.btnProcesar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProcesar.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProcesar.ForeColor = System.Drawing.Color.White;
            this.btnProcesar.Location = new System.Drawing.Point(77, 57);
            this.btnProcesar.Name = "btnProcesar";
            this.btnProcesar.Size = new System.Drawing.Size(83, 23);
            this.btnProcesar.TabIndex = 348;
            this.btnProcesar.Text = "Excel";
            this.btnProcesar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnProcesar.UseVisualStyleBackColor = false;
            this.btnProcesar.Click += new System.EventHandler(this.btnProcesar_Click);
            // 
            // btncancelar
            // 
            this.btncancelar.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncancelar.Image = ((System.Drawing.Image)(resources.GetObject("btncancelar.Image")));
            this.btncancelar.Location = new System.Drawing.Point(164, 57);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(92, 23);
            this.btncancelar.TabIndex = 347;
            this.btncancelar.Text = "Cancelar";
            this.btncancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btncancelar.UseVisualStyleBackColor = true;
            this.btncancelar.Click += new System.EventHandler(this.btncancelar_Click);
            // 
            // cbodesde
            // 
            this.cbodesde.BackColor = System.Drawing.Color.Transparent;
            this.cbodesde.FechaConDiaActual = new System.DateTime(2021, 5, 31, 0, 0, 0, 0);
            this.cbodesde.FechaFinMes = new System.DateTime(2021, 5, 31, 0, 0, 0, 0);
            this.cbodesde.FechaInicioMes = new System.DateTime(2021, 5, 1, 0, 0, 0, 0);
            this.cbodesde.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.cbodesde.Location = new System.Drawing.Point(51, 25);
            this.cbodesde.Name = "cbodesde";
            this.cbodesde.Size = new System.Drawing.Size(261, 26);
            this.cbodesde.TabIndex = 346;
            this.cbodesde.VerAño = true;
            this.cbodesde.VerMes = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 345;
            this.label1.Text = "Hasta:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(183, 13);
            this.label4.TabIndex = 344;
            this.label4.Text = "1.- Seleccione el Rango de Fechas:";
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // frmReporteDepreciaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(333, 115);
            this.Controls.Add(this.btnProcesar);
            this.Controls.Add(this.btncancelar);
            this.Controls.Add(this.cbodesde);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Name = "frmReporteDepreciaciones";
            this.Nombre = "Reporte Depreciaciones";
            this.Text = "Reporte Depreciaciones";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private HpResergerUserControls.ButtonPer btnProcesar;
        private System.Windows.Forms.Button btncancelar;
        private HpResergerUserControls.ComboMesAño cbodesde;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
    }
}