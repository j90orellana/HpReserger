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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGenerarBoletas));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbTodasEmpresa = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboMesAño2 = new HpResergerUserControls.ComboMesAño();
            this.comboMesAño1 = new HpResergerUserControls.ComboMesAño();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.btnlimpiar = new System.Windows.Forms.Button();
            this.txtnumero = new System.Windows.Forms.TextBox();
            this.btnrectipo = new System.Windows.Forms.Button();
            this.cbotipoid = new System.Windows.Forms.ComboBox();
            this.btnrecempresa = new System.Windows.Forms.Button();
            this.cboempresa = new System.Windows.Forms.ComboBox();
            this.btngenerar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.rbTodasEmpresa);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.comboMesAño2);
            this.groupBox1.Controls.Add(this.comboMesAño1);
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Controls.Add(this.btnlimpiar);
            this.groupBox1.Controls.Add(this.txtnumero);
            this.groupBox1.Controls.Add(this.btnrectipo);
            this.groupBox1.Controls.Add(this.cbotipoid);
            this.groupBox1.Controls.Add(this.btnrecempresa);
            this.groupBox1.Controls.Add(this.cboempresa);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(390, 180);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Parametros";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // rbTodasEmpresa
            // 
            this.rbTodasEmpresa.AutoSize = true;
            this.rbTodasEmpresa.Location = new System.Drawing.Point(11, 100);
            this.rbTodasEmpresa.Name = "rbTodasEmpresa";
            this.rbTodasEmpresa.Size = new System.Drawing.Size(124, 17);
            this.rbTodasEmpresa.TabIndex = 16;
            this.rbTodasEmpresa.Text = "Todas Las Empresas";
            this.rbTodasEmpresa.UseVisualStyleBackColor = true;
            this.rbTodasEmpresa.CheckedChanged += new System.EventHandler(this.rbTodasEmpresa_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(75, 159);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Hasta:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(83, 129);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "De:";
            // 
            // comboMesAño2
            // 
            this.comboMesAño2.AutoSize = true;
            this.comboMesAño2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.comboMesAño2.FechaConDiaActual = new System.DateTime(2018, 12, 5, 0, 0, 0, 0);
            this.comboMesAño2.FechaFinMes = new System.DateTime(2018, 12, 31, 0, 0, 0, 0);
            this.comboMesAño2.FechaInicioMes = new System.DateTime(2018, 12, 1, 0, 0, 0, 0);
            this.comboMesAño2.Location = new System.Drawing.Point(93, 153);
            this.comboMesAño2.Name = "comboMesAño2";
            this.comboMesAño2.Size = new System.Drawing.Size(204, 24);
            this.comboMesAño2.TabIndex = 14;
            // 
            // comboMesAño1
            // 
            this.comboMesAño1.AutoSize = true;
            this.comboMesAño1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.comboMesAño1.FechaConDiaActual = new System.DateTime(2018, 12, 5, 0, 0, 0, 0);
            this.comboMesAño1.FechaFinMes = new System.DateTime(2018, 12, 31, 0, 0, 0, 0);
            this.comboMesAño1.FechaInicioMes = new System.DateTime(2018, 12, 1, 0, 0, 0, 0);
            this.comboMesAño1.Location = new System.Drawing.Point(93, 123);
            this.comboMesAño1.Name = "comboMesAño1";
            this.comboMesAño1.Size = new System.Drawing.Size(204, 24);
            this.comboMesAño1.TabIndex = 13;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(11, 48);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(86, 17);
            this.radioButton2.TabIndex = 9;
            this.radioButton2.Text = "Por Persona";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(11, 21);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(88, 17);
            this.radioButton1.TabIndex = 9;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Por Empresa";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // btnlimpiar
            // 
            this.btnlimpiar.BackgroundImage = global::HPReserger.Properties.Resources.sshot_2017_06_23__15_15_56_;
            this.btnlimpiar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnlimpiar.Enabled = false;
            this.btnlimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnlimpiar.Location = new System.Drawing.Point(349, 73);
            this.btnlimpiar.Name = "btnlimpiar";
            this.btnlimpiar.Size = new System.Drawing.Size(27, 21);
            this.btnlimpiar.TabIndex = 8;
            this.btnlimpiar.UseVisualStyleBackColor = true;
            this.btnlimpiar.Click += new System.EventHandler(this.btnlimpiar_Click);
            // 
            // txtnumero
            // 
            this.txtnumero.Enabled = false;
            this.txtnumero.Location = new System.Drawing.Point(102, 73);
            this.txtnumero.Name = "txtnumero";
            this.txtnumero.Size = new System.Drawing.Size(241, 22);
            this.txtnumero.TabIndex = 7;
            // 
            // btnrectipo
            // 
            this.btnrectipo.BackgroundImage = global::HPReserger.Properties.Resources.sshot_2017_06_13__17_59_46_;
            this.btnrectipo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnrectipo.Enabled = false;
            this.btnrectipo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnrectipo.Location = new System.Drawing.Point(349, 46);
            this.btnrectipo.Name = "btnrectipo";
            this.btnrectipo.Size = new System.Drawing.Size(27, 21);
            this.btnrectipo.TabIndex = 5;
            this.btnrectipo.UseVisualStyleBackColor = true;
            this.btnrectipo.Click += new System.EventHandler(this.btnrectipo_Click);
            // 
            // cbotipoid
            // 
            this.cbotipoid.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbotipoid.Enabled = false;
            this.cbotipoid.FormattingEnabled = true;
            this.cbotipoid.Location = new System.Drawing.Point(102, 46);
            this.cbotipoid.Name = "cbotipoid";
            this.cbotipoid.Size = new System.Drawing.Size(241, 21);
            this.cbotipoid.TabIndex = 4;
            this.cbotipoid.SelectedIndexChanged += new System.EventHandler(this.cbotipoid_SelectedIndexChanged);
            // 
            // btnrecempresa
            // 
            this.btnrecempresa.BackgroundImage = global::HPReserger.Properties.Resources.sshot_2017_06_13__17_59_46_;
            this.btnrecempresa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnrecempresa.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnrecempresa.Location = new System.Drawing.Point(349, 19);
            this.btnrecempresa.Name = "btnrecempresa";
            this.btnrecempresa.Size = new System.Drawing.Size(27, 21);
            this.btnrecempresa.TabIndex = 2;
            this.btnrecempresa.UseVisualStyleBackColor = true;
            this.btnrecempresa.Click += new System.EventHandler(this.btnrecempresa_Click);
            // 
            // cboempresa
            // 
            this.cboempresa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboempresa.FormattingEnabled = true;
            this.cboempresa.Location = new System.Drawing.Point(102, 19);
            this.cboempresa.Name = "cboempresa";
            this.cboempresa.Size = new System.Drawing.Size(241, 21);
            this.cboempresa.TabIndex = 1;
            // 
            // btngenerar
            // 
            this.btngenerar.Image = ((System.Drawing.Image)(resources.GetObject("btngenerar.Image")));
            this.btngenerar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btngenerar.Location = new System.Drawing.Point(146, 188);
            this.btngenerar.Name = "btngenerar";
            this.btngenerar.Size = new System.Drawing.Size(115, 33);
            this.btngenerar.TabIndex = 1;
            this.btngenerar.Text = "&Generar";
            this.btngenerar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btngenerar.UseVisualStyleBackColor = true;
            this.btngenerar.Click += new System.EventHandler(this.btngenerar_Click);
            // 
            // frmGenerarBoletas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(441, 273);
            this.Controls.Add(this.btngenerar);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmGenerarBoletas";
            this.Nombre = "Generar Boletas";
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
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private HpResergerUserControls.ComboMesAño comboMesAño2;
        private HpResergerUserControls.ComboMesAño comboMesAño1;
        private System.Windows.Forms.RadioButton rbTodasEmpresa;
    }
}