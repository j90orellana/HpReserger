namespace HPReserger.ModuloReportes
{
    partial class frmReporteCentrodeCosto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReporteCentrodeCosto));
            this.chksubtotales = new HpResergerUserControls.checkboxOre();
            this.btnbusCuenta = new System.Windows.Forms.Button();
            this.dtpfechafin = new System.Windows.Forms.DateTimePicker();
            this.dtpfechaini = new System.Windows.Forms.DateTimePicker();
            this.chklist = new System.Windows.Forms.CheckedListBox();
            this.txtbuscuenta = new HpResergerUserControls.TextBoxPer();
            this.btngenerar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // chksubtotales
            // 
            this.chksubtotales.AutoSize = true;
            this.chksubtotales.BackColor = System.Drawing.Color.Transparent;
            this.chksubtotales.ColorChecked = System.Drawing.Color.Empty;
            this.chksubtotales.ColorUnChecked = System.Drawing.Color.Empty;
            this.chksubtotales.Location = new System.Drawing.Point(213, 97);
            this.chksubtotales.Name = "chksubtotales";
            this.chksubtotales.Size = new System.Drawing.Size(81, 17);
            this.chksubtotales.TabIndex = 402;
            this.chksubtotales.Text = "Subtotales";
            this.chksubtotales.UseVisualStyleBackColor = false;
            // 
            // btnbusCuenta
            // 
            this.btnbusCuenta.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnbusCuenta.BackgroundImage")));
            this.btnbusCuenta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnbusCuenta.Location = new System.Drawing.Point(273, 71);
            this.btnbusCuenta.Name = "btnbusCuenta";
            this.btnbusCuenta.Size = new System.Drawing.Size(21, 21);
            this.btnbusCuenta.TabIndex = 401;
            this.btnbusCuenta.UseVisualStyleBackColor = true;
            this.btnbusCuenta.Click += new System.EventHandler(this.btnbusCuenta_Click);
            // 
            // dtpfechafin
            // 
            this.dtpfechafin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpfechafin.Location = new System.Drawing.Point(201, 46);
            this.dtpfechafin.Name = "dtpfechafin";
            this.dtpfechafin.Size = new System.Drawing.Size(93, 22);
            this.dtpfechafin.TabIndex = 399;
            // 
            // dtpfechaini
            // 
            this.dtpfechaini.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpfechaini.Location = new System.Drawing.Point(79, 46);
            this.dtpfechaini.Name = "dtpfechaini";
            this.dtpfechaini.Size = new System.Drawing.Size(93, 22);
            this.dtpfechaini.TabIndex = 400;
            // 
            // chklist
            // 
            this.chklist.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.chklist.ColumnWidth = 200;
            this.chklist.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chklist.Location = new System.Drawing.Point(359, 32);
            this.chklist.Name = "chklist";
            this.chklist.Size = new System.Drawing.Size(405, 82);
            this.chklist.TabIndex = 398;
            this.chklist.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.chklist_ItemCheck);
            // 
            // txtbuscuenta
            // 
            this.txtbuscuenta.BackColor = System.Drawing.Color.White;
            this.txtbuscuenta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtbuscuenta.ColorFondoMouseEncima = System.Drawing.Color.Empty;
            this.txtbuscuenta.ColorFondoMousePresionado = System.Drawing.Color.Empty;
            this.txtbuscuenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbuscuenta.ForeColor = System.Drawing.Color.Black;
            this.txtbuscuenta.Format = null;
            this.txtbuscuenta.Location = new System.Drawing.Point(79, 71);
            this.txtbuscuenta.MaxLength = 100;
            this.txtbuscuenta.Name = "txtbuscuenta";
            this.txtbuscuenta.NextControlOnEnter = null;
            this.txtbuscuenta.Size = new System.Drawing.Size(188, 21);
            this.txtbuscuenta.TabIndex = 397;
            this.txtbuscuenta.Text = "000";
            this.txtbuscuenta.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtbuscuenta.TextoDefecto = "000";
            this.txtbuscuenta.TextoDefectoColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(129)))), ((int)(((byte)(189)))));
            this.txtbuscuenta.TiposDatos = HpResergerUserControls.TextBoxPer.ListaTipos.MayusculaCadaPalabra;
            // 
            // btngenerar
            // 
            this.btngenerar.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btngenerar.Image = ((System.Drawing.Image)(resources.GetObject("btngenerar.Image")));
            this.btngenerar.Location = new System.Drawing.Point(770, 91);
            this.btngenerar.Name = "btngenerar";
            this.btngenerar.Size = new System.Drawing.Size(85, 23);
            this.btngenerar.TabIndex = 396;
            this.btngenerar.Text = "Generar";
            this.btngenerar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btngenerar.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(24, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 392;
            this.label4.Text = "Cuentas:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(306, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 393;
            this.label3.Text = "Empresa:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(178, 51);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(17, 13);
            this.label5.TabIndex = 394;
            this.label5.Text = "A:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(9, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 395;
            this.label2.Text = "Periodo De:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(196, 19);
            this.label1.TabIndex = 403;
            this.label1.Text = "Reporte de Centro de Costo";
            // 
            // frmReporteCentrodeCosto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 589);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chksubtotales);
            this.Controls.Add(this.btnbusCuenta);
            this.Controls.Add(this.dtpfechafin);
            this.Controls.Add(this.dtpfechaini);
            this.Controls.Add(this.chklist);
            this.Controls.Add(this.txtbuscuenta);
            this.Controls.Add(this.btngenerar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.Name = "frmReporteCentrodeCosto";
            this.Nombre = "Reporte de Centro de Costo";
            this.Text = "Reporte de Centro de Costo";
            this.Load += new System.EventHandler(this.frmReporteCentrodeCosto_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private HpResergerUserControls.checkboxOre chksubtotales;
        private System.Windows.Forms.Button btnbusCuenta;
        private System.Windows.Forms.DateTimePicker dtpfechafin;
        private System.Windows.Forms.DateTimePicker dtpfechaini;
        private System.Windows.Forms.CheckedListBox chklist;
        private HpResergerUserControls.TextBoxPer txtbuscuenta;
        private System.Windows.Forms.Button btngenerar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}