namespace HPReserger
{
    partial class FrmGenerarRemuneracionRenta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGenerarRemuneracionRenta));
            this.btngenerar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboMesAño1 = new HpResergerUserControls.ComboMesAño();
            this.label1 = new System.Windows.Forms.Label();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.btnlimpiar = new System.Windows.Forms.Button();
            this.txtnumero = new System.Windows.Forms.TextBox();
            this.btnrectipo = new System.Windows.Forms.Button();
            this.cbotipoid = new System.Windows.Forms.ComboBox();
            this.btnrecempresa = new System.Windows.Forms.Button();
            this.cboempresa = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btngenerar
            // 
            this.btngenerar.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btngenerar.Image = ((System.Drawing.Image)(resources.GetObject("btngenerar.Image")));
            this.btngenerar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btngenerar.Location = new System.Drawing.Point(176, 136);
            this.btngenerar.Name = "btngenerar";
            this.btngenerar.Size = new System.Drawing.Size(103, 25);
            this.btngenerar.TabIndex = 3;
            this.btngenerar.Text = "Generar";
            this.btngenerar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btngenerar.UseVisualStyleBackColor = true;
            this.btngenerar.Click += new System.EventHandler(this.btngenerar_Click_1);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.btngenerar);
            this.groupBox1.Controls.Add(this.comboMesAño1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Controls.Add(this.btnlimpiar);
            this.groupBox1.Controls.Add(this.txtnumero);
            this.groupBox1.Controls.Add(this.btnrectipo);
            this.groupBox1.Controls.Add(this.cbotipoid);
            this.groupBox1.Controls.Add(this.btnrecempresa);
            this.groupBox1.Controls.Add(this.cboempresa);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(454, 178);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Parametros";
            // 
            // comboMesAño1
            // 
            this.comboMesAño1.AutoSize = true;
            this.comboMesAño1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.comboMesAño1.FechaConDiaActual = new System.DateTime(2018, 12, 5, 0, 0, 0, 0);
            this.comboMesAño1.FechaFinMes = new System.DateTime(2018, 12, 31, 0, 0, 0, 0);
            this.comboMesAño1.FechaInicioMes = new System.DateTime(2018, 12, 1, 0, 0, 0, 0);
            this.comboMesAño1.Location = new System.Drawing.Point(148, 21);
            this.comboMesAño1.Name = "comboMesAño1";
            this.comboMesAño1.Size = new System.Drawing.Size(207, 24);
            this.comboMesAño1.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(99, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Periodo";
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(8, 84);
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
            this.radioButton1.Location = new System.Drawing.Point(6, 57);
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
            this.btnlimpiar.Location = new System.Drawing.Point(399, 109);
            this.btnlimpiar.Name = "btnlimpiar";
            this.btnlimpiar.Size = new System.Drawing.Size(27, 21);
            this.btnlimpiar.TabIndex = 8;
            this.btnlimpiar.UseVisualStyleBackColor = true;
            this.btnlimpiar.Click += new System.EventHandler(this.btnlimpiar_Click);
            // 
            // txtnumero
            // 
            this.txtnumero.Enabled = false;
            this.txtnumero.Location = new System.Drawing.Point(97, 110);
            this.txtnumero.Name = "txtnumero";
            this.txtnumero.Size = new System.Drawing.Size(296, 22);
            this.txtnumero.TabIndex = 7;
            // 
            // btnrectipo
            // 
            this.btnrectipo.BackgroundImage = global::HPReserger.Properties.Resources.sshot_2017_06_13__17_59_46_;
            this.btnrectipo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnrectipo.Enabled = false;
            this.btnrectipo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnrectipo.Location = new System.Drawing.Point(399, 82);
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
            this.cbotipoid.Location = new System.Drawing.Point(97, 83);
            this.cbotipoid.Name = "cbotipoid";
            this.cbotipoid.Size = new System.Drawing.Size(296, 21);
            this.cbotipoid.TabIndex = 4;
            // 
            // btnrecempresa
            // 
            this.btnrecempresa.BackgroundImage = global::HPReserger.Properties.Resources.sshot_2017_06_13__17_59_46_;
            this.btnrecempresa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnrecempresa.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnrecempresa.Location = new System.Drawing.Point(399, 55);
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
            this.cboempresa.Location = new System.Drawing.Point(97, 56);
            this.cboempresa.Name = "cboempresa";
            this.cboempresa.Size = new System.Drawing.Size(296, 21);
            this.cboempresa.TabIndex = 1;
            // 
            // FrmGenerarRemuneracionRenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(454, 178);
            this.Controls.Add(this.groupBox1);
            this.MaximumSize = new System.Drawing.Size(470, 217);
            this.MinimumSize = new System.Drawing.Size(470, 217);
            this.Name = "FrmGenerarRemuneracionRenta";
            this.Nombre = "Generar Certificado de Remuneracion y Renta de Quinta Categoria";
            this.Text = "Generar Certificado de Remuneracion y Renta de Quinta Categoria";
            this.Load += new System.EventHandler(this.FrmGenerarRemuneracionRenta_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btngenerar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Button btnlimpiar;
        private System.Windows.Forms.TextBox txtnumero;
        private System.Windows.Forms.Button btnrectipo;
        private System.Windows.Forms.ComboBox cbotipoid;
        private System.Windows.Forms.Button btnrecempresa;
        private System.Windows.Forms.ComboBox cboempresa;
        private System.Windows.Forms.Label label1;
        private HpResergerUserControls.ComboMesAño comboMesAño1;
    }
}