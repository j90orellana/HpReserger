namespace HPReserger
{
    partial class frmEmpleadoPensionSeguro
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
            this.cboEPS = new System.Windows.Forms.ComboBox();
            this.txtCUPSS = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cboEPSAdicional = new System.Windows.Forms.ComboBox();
            this.cboAFPEmpresa = new System.Windows.Forms.ComboBox();
            this.cboONP = new System.Windows.Forms.ComboBox();
            this.cboAFP = new System.Windows.Forms.ComboBox();
            this.cboSCTR = new System.Windows.Forms.ComboBox();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cboEPS
            // 
            this.cboEPS.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEPS.FormattingEnabled = true;
            this.cboEPS.Items.AddRange(new object[] {
            "SI",
            "NO"});
            this.cboEPS.Location = new System.Drawing.Point(105, 12);
            this.cboEPS.Name = "cboEPS";
            this.cboEPS.Size = new System.Drawing.Size(60, 21);
            this.cboEPS.TabIndex = 0;
            this.cboEPS.SelectedIndexChanged += new System.EventHandler(this.cboEPS_SelectedIndexChanged);
            // 
            // txtCUPSS
            // 
            this.txtCUPSS.Location = new System.Drawing.Point(105, 159);
            this.txtCUPSS.MaxLength = 20;
            this.txtCUPSS.Name = "txtCUPSS";
            this.txtCUPSS.Size = new System.Drawing.Size(163, 20);
            this.txtCUPSS.TabIndex = 6;
            this.txtCUPSS.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCUPSS_KeyDown);
            this.txtCUPSS.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCUPSS_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "EPS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "SCTR";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "AFP";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "AFP Empresa";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(236, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "EPS Adicional";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(236, 82);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "ONP";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 159);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Número CUPSS";
            // 
            // cboEPSAdicional
            // 
            this.cboEPSAdicional.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEPSAdicional.FormattingEnabled = true;
            this.cboEPSAdicional.Items.AddRange(new object[] {
            "SI",
            "NO"});
            this.cboEPSAdicional.Location = new System.Drawing.Point(316, 12);
            this.cboEPSAdicional.Name = "cboEPSAdicional";
            this.cboEPSAdicional.Size = new System.Drawing.Size(101, 21);
            this.cboEPSAdicional.TabIndex = 14;
            // 
            // cboAFPEmpresa
            // 
            this.cboAFPEmpresa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboAFPEmpresa.FormattingEnabled = true;
            this.cboAFPEmpresa.Items.AddRange(new object[] {
            "SI",
            "NO"});
            this.cboAFPEmpresa.Location = new System.Drawing.Point(105, 120);
            this.cboAFPEmpresa.Name = "cboAFPEmpresa";
            this.cboAFPEmpresa.Size = new System.Drawing.Size(163, 21);
            this.cboAFPEmpresa.TabIndex = 15;
            // 
            // cboONP
            // 
            this.cboONP.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboONP.FormattingEnabled = true;
            this.cboONP.Items.AddRange(new object[] {
            "SI"});
            this.cboONP.Location = new System.Drawing.Point(316, 82);
            this.cboONP.Name = "cboONP";
            this.cboONP.Size = new System.Drawing.Size(67, 21);
            this.cboONP.TabIndex = 16;
            // 
            // cboAFP
            // 
            this.cboAFP.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboAFP.FormattingEnabled = true;
            this.cboAFP.Items.AddRange(new object[] {
            "SI",
            "NO"});
            this.cboAFP.Location = new System.Drawing.Point(105, 82);
            this.cboAFP.Name = "cboAFP";
            this.cboAFP.Size = new System.Drawing.Size(60, 21);
            this.cboAFP.TabIndex = 17;
            this.cboAFP.SelectedIndexChanged += new System.EventHandler(this.cboAFP_SelectedIndexChanged);
            // 
            // cboSCTR
            // 
            this.cboSCTR.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSCTR.FormattingEnabled = true;
            this.cboSCTR.Items.AddRange(new object[] {
            "SI",
            "NO"});
            this.cboSCTR.Location = new System.Drawing.Point(105, 46);
            this.cboSCTR.Name = "cboSCTR";
            this.cboSCTR.Size = new System.Drawing.Size(60, 21);
            this.cboSCTR.TabIndex = 18;
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(120, 201);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(75, 23);
            this.btnRegistrar.TabIndex = 19;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(220, 201);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(75, 23);
            this.btnModificar.TabIndex = 20;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // frmEmpleadoPensionSeguro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(424, 236);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.cboSCTR);
            this.Controls.Add(this.cboAFP);
            this.Controls.Add(this.cboONP);
            this.Controls.Add(this.cboAFPEmpresa);
            this.Controls.Add(this.cboEPSAdicional);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCUPSS);
            this.Controls.Add(this.cboEPS);
            this.MaximizeBox = false;
            this.Name = "frmEmpleadoPensionSeguro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "  Pensión y Seguro";
            this.Load += new System.EventHandler(this.frmEmpleadoPensionSeguro_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboEPS;
        private System.Windows.Forms.TextBox txtCUPSS;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cboEPSAdicional;
        private System.Windows.Forms.ComboBox cboAFPEmpresa;
        private System.Windows.Forms.ComboBox cboONP;
        private System.Windows.Forms.ComboBox cboAFP;
        private System.Windows.Forms.ComboBox cboSCTR;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Button btnModificar;
    }
}