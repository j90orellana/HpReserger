namespace HPReserger
{
    partial class frmGenerarBoletas
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnlimpiar = new System.Windows.Forms.Button();
            this.txtnumero = new System.Windows.Forms.TextBox();
            this.btnrectipo = new System.Windows.Forms.Button();
            this.cbotipoid = new System.Windows.Forms.ComboBox();
            this.btnrecempresa = new System.Windows.Forms.Button();
            this.cboempresa = new System.Windows.Forms.ComboBox();
            this.btngenerar = new System.Windows.Forms.Button();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Controls.Add(this.btnlimpiar);
            this.groupBox1.Controls.Add(this.txtnumero);
            this.groupBox1.Controls.Add(this.btnrectipo);
            this.groupBox1.Controls.Add(this.cbotipoid);
            this.groupBox1.Controls.Add(this.btnrecempresa);
            this.groupBox1.Controls.Add(this.cboempresa);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(306, 151);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Parametros";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btnlimpiar
            // 
            this.btnlimpiar.BackgroundImage = global::HPReserger.Properties.Resources.sshot_2017_06_23__15_15_56_;
            this.btnlimpiar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnlimpiar.Enabled = false;
            this.btnlimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnlimpiar.Location = new System.Drawing.Point(243, 119);
            this.btnlimpiar.Name = "btnlimpiar";
            this.btnlimpiar.Size = new System.Drawing.Size(27, 21);
            this.btnlimpiar.TabIndex = 8;
            this.btnlimpiar.UseVisualStyleBackColor = true;
            this.btnlimpiar.Click += new System.EventHandler(this.btnlimpiar_Click);
            // 
            // txtnumero
            // 
            this.txtnumero.Enabled = false;
            this.txtnumero.Location = new System.Drawing.Point(84, 119);
            this.txtnumero.Name = "txtnumero";
            this.txtnumero.Size = new System.Drawing.Size(153, 20);
            this.txtnumero.TabIndex = 7;
            // 
            // btnrectipo
            // 
            this.btnrectipo.BackgroundImage = global::HPReserger.Properties.Resources.sshot_2017_06_13__17_59_46_;
            this.btnrectipo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnrectipo.Enabled = false;
            this.btnrectipo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnrectipo.Location = new System.Drawing.Point(243, 92);
            this.btnrectipo.Name = "btnrectipo";
            this.btnrectipo.Size = new System.Drawing.Size(27, 21);
            this.btnrectipo.TabIndex = 5;
            this.btnrectipo.UseVisualStyleBackColor = true;
            this.btnrectipo.Click += new System.EventHandler(this.btnrectipo_Click);
            // 
            // cbotipoid
            // 
            this.cbotipoid.Enabled = false;
            this.cbotipoid.FormattingEnabled = true;
            this.cbotipoid.Location = new System.Drawing.Point(84, 92);
            this.cbotipoid.Name = "cbotipoid";
            this.cbotipoid.Size = new System.Drawing.Size(153, 21);
            this.cbotipoid.TabIndex = 4;
            // 
            // btnrecempresa
            // 
            this.btnrecempresa.BackgroundImage = global::HPReserger.Properties.Resources.sshot_2017_06_13__17_59_46_;
            this.btnrecempresa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnrecempresa.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnrecempresa.Location = new System.Drawing.Point(243, 42);
            this.btnrecempresa.Name = "btnrecempresa";
            this.btnrecempresa.Size = new System.Drawing.Size(27, 21);
            this.btnrecempresa.TabIndex = 2;
            this.btnrecempresa.UseVisualStyleBackColor = true;
            this.btnrecempresa.Click += new System.EventHandler(this.btnrecempresa_Click);
            // 
            // cboempresa
            // 
            this.cboempresa.FormattingEnabled = true;
            this.cboempresa.Location = new System.Drawing.Point(84, 42);
            this.cboempresa.Name = "cboempresa";
            this.cboempresa.Size = new System.Drawing.Size(153, 21);
            this.cboempresa.TabIndex = 1;
            // 
            // btngenerar
            // 
            this.btngenerar.Location = new System.Drawing.Point(124, 169);
            this.btngenerar.Name = "btngenerar";
            this.btngenerar.Size = new System.Drawing.Size(103, 29);
            this.btngenerar.TabIndex = 1;
            this.btngenerar.Text = "Generar";
            this.btngenerar.UseVisualStyleBackColor = true;
            this.btngenerar.Click += new System.EventHandler(this.btngenerar_Click);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(6, 19);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(85, 17);
            this.radioButton1.TabIndex = 9;
            this.radioButton1.Text = "Por Empresa";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(6, 69);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(83, 17);
            this.radioButton2.TabIndex = 9;
            this.radioButton2.Text = "Por Persona";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // frmGenerarBoletas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(354, 205);
            this.Controls.Add(this.btngenerar);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmGenerarBoletas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Generar Boletas";
            this.Load += new System.EventHandler(this.frmGenerarBoletas_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnrecempresa;
        private System.Windows.Forms.ComboBox cboempresa;
        private System.Windows.Forms.Button btngenerar;
        private System.Windows.Forms.Button btnlimpiar;
        private System.Windows.Forms.TextBox txtnumero;
        private System.Windows.Forms.Button btnrectipo;
        private System.Windows.Forms.ComboBox cbotipoid;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
    }
}