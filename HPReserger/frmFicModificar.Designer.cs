namespace HPReserger
{
    partial class frmFicModificar
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblguia = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtCantOC = new System.Windows.Forms.TextBox();
            this.txtModelo = new System.Windows.Forms.TextBox();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.txtArticulo = new System.Windows.Forms.TextBox();
            this.txtFIC = new System.Windows.Forms.TextBox();
            this.txtCantFIC = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblmodelo = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.txtGuia = new System.Windows.Forms.TextBox();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btncancelar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "FIC";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Fecha";
            // 
            // lblguia
            // 
            this.lblguia.AutoSize = true;
            this.lblguia.Location = new System.Drawing.Point(15, 81);
            this.lblguia.Name = "lblguia";
            this.lblguia.Size = new System.Drawing.Size(77, 13);
            this.lblguia.TabIndex = 2;
            this.lblguia.Text = "Guía Remisión";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtCantOC);
            this.groupBox1.Controls.Add(this.txtModelo);
            this.groupBox1.Controls.Add(this.txtMarca);
            this.groupBox1.Controls.Add(this.txtArticulo);
            this.groupBox1.Controls.Add(this.txtFIC);
            this.groupBox1.Controls.Add(this.txtCantFIC);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.lblmodelo);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.dtpFecha);
            this.groupBox1.Controls.Add(this.txtGuia);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lblguia);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(303, 283);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // txtCantOC
            // 
            this.txtCantOC.Location = new System.Drawing.Point(105, 216);
            this.txtCantOC.Name = "txtCantOC";
            this.txtCantOC.ReadOnly = true;
            this.txtCantOC.Size = new System.Drawing.Size(69, 20);
            this.txtCantOC.TabIndex = 22;
            this.txtCantOC.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtModelo
            // 
            this.txtModelo.Location = new System.Drawing.Point(105, 181);
            this.txtModelo.Name = "txtModelo";
            this.txtModelo.ReadOnly = true;
            this.txtModelo.Size = new System.Drawing.Size(182, 20);
            this.txtModelo.TabIndex = 21;
            // 
            // txtMarca
            // 
            this.txtMarca.Location = new System.Drawing.Point(105, 147);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.ReadOnly = true;
            this.txtMarca.Size = new System.Drawing.Size(182, 20);
            this.txtMarca.TabIndex = 20;
            // 
            // txtArticulo
            // 
            this.txtArticulo.Location = new System.Drawing.Point(105, 115);
            this.txtArticulo.Name = "txtArticulo";
            this.txtArticulo.ReadOnly = true;
            this.txtArticulo.Size = new System.Drawing.Size(182, 20);
            this.txtArticulo.TabIndex = 19;
            // 
            // txtFIC
            // 
            this.txtFIC.Location = new System.Drawing.Point(105, 19);
            this.txtFIC.Name = "txtFIC";
            this.txtFIC.ReadOnly = true;
            this.txtFIC.Size = new System.Drawing.Size(94, 20);
            this.txtFIC.TabIndex = 18;
            this.txtFIC.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtCantFIC
            // 
            this.txtCantFIC.Location = new System.Drawing.Point(105, 249);
            this.txtCantFIC.Name = "txtCantFIC";
            this.txtCantFIC.Size = new System.Drawing.Size(69, 20);
            this.txtCantFIC.TabIndex = 1;
            this.txtCantFIC.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtCantFIC.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCantFIC_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(15, 249);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Cant. FIC";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 216);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Saldo OC";
            // 
            // lblmodelo
            // 
            this.lblmodelo.AutoSize = true;
            this.lblmodelo.Location = new System.Drawing.Point(15, 181);
            this.lblmodelo.Name = "lblmodelo";
            this.lblmodelo.Size = new System.Drawing.Size(42, 13);
            this.lblmodelo.TabIndex = 12;
            this.lblmodelo.Text = "Modelo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 147);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Marca";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Artículo";
            // 
            // dtpFecha
            // 
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha.Location = new System.Drawing.Point(105, 50);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(111, 20);
            this.dtpFecha.TabIndex = 7;
            // 
            // txtGuia
            // 
            this.txtGuia.Location = new System.Drawing.Point(105, 82);
            this.txtGuia.Name = "txtGuia";
            this.txtGuia.Size = new System.Drawing.Size(84, 20);
            this.txtGuia.TabIndex = 5;
            this.txtGuia.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtGuia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtGuia_KeyPress);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(159, 293);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(75, 23);
            this.btnModificar.TabIndex = 5;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btncancelar
            // 
            this.btncancelar.Location = new System.Drawing.Point(240, 293);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(75, 23);
            this.btncancelar.TabIndex = 5;
            this.btncancelar.Text = "Cancelar";
            this.btncancelar.UseVisualStyleBackColor = true;
            this.btncancelar.Click += new System.EventHandler(this.btncancelar_Click);
            // 
            // frmFicModificar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(331, 325);
            this.Controls.Add(this.btncancelar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.groupBox1);
            this.MaximumSize = new System.Drawing.Size(347, 364);
            this.MinimumSize = new System.Drawing.Size(347, 364);
            this.Name = "frmFicModificar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "  Modificar FIC";
            this.Load += new System.EventHandler(this.frmFicModificar_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.TextBox txtCantFIC;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCantOC;
        private System.Windows.Forms.TextBox txtModelo;
        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.TextBox txtArticulo;
        private System.Windows.Forms.TextBox txtFIC;
        public System.Windows.Forms.Label lblguia;
        public System.Windows.Forms.Label lblmodelo;
        private System.Windows.Forms.Button btncancelar;
        public System.Windows.Forms.TextBox txtGuia;
    }
}