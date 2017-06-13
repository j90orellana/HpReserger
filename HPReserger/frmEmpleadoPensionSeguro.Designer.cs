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
            this.pnlconten = new System.Windows.Forms.Panel();
            this.btncancelar = new System.Windows.Forms.Button();
            this.btnaceptar = new System.Windows.Forms.Button();
            this.pnlconten.SuspendLayout();
            this.SuspendLayout();
            // 
            // cboEPS
            // 
            this.cboEPS.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEPS.FormattingEnabled = true;
            this.cboEPS.Items.AddRange(new object[] {
            "SI",
            "NO"});
            this.cboEPS.Location = new System.Drawing.Point(51, 7);
            this.cboEPS.Name = "cboEPS";
            this.cboEPS.Size = new System.Drawing.Size(60, 21);
            this.cboEPS.TabIndex = 0;
            this.cboEPS.SelectedIndexChanged += new System.EventHandler(this.cboEPS_SelectedIndexChanged);
            // 
            // txtCUPSS
            // 
            this.txtCUPSS.Location = new System.Drawing.Point(96, 115);
            this.txtCUPSS.MaxLength = 20;
            this.txtCUPSS.Name = "txtCUPSS";
            this.txtCUPSS.Size = new System.Drawing.Size(241, 20);
            this.txtCUPSS.TabIndex = 6;
            this.txtCUPSS.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCUPSS_KeyDown);
            this.txtCUPSS.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCUPSS_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "EPS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "SCTR";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "AFP";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "AFP Empresa";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(117, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "EPS Adicional";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(117, 64);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "ONP";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(4, 118);
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
            this.cboEPSAdicional.Location = new System.Drawing.Point(197, 10);
            this.cboEPSAdicional.Name = "cboEPSAdicional";
            this.cboEPSAdicional.Size = new System.Drawing.Size(140, 21);
            this.cboEPSAdicional.TabIndex = 14;
            // 
            // cboAFPEmpresa
            // 
            this.cboAFPEmpresa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboAFPEmpresa.FormattingEnabled = true;
            this.cboAFPEmpresa.Items.AddRange(new object[] {
            "SI",
            "NO"});
            this.cboAFPEmpresa.Location = new System.Drawing.Point(96, 88);
            this.cboAFPEmpresa.Name = "cboAFPEmpresa";
            this.cboAFPEmpresa.Size = new System.Drawing.Size(241, 21);
            this.cboAFPEmpresa.TabIndex = 15;
            // 
            // cboONP
            // 
            this.cboONP.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboONP.FormattingEnabled = true;
            this.cboONP.Items.AddRange(new object[] {
            "SI"});
            this.cboONP.Location = new System.Drawing.Point(197, 61);
            this.cboONP.Name = "cboONP";
            this.cboONP.Size = new System.Drawing.Size(140, 21);
            this.cboONP.TabIndex = 16;
            this.cboONP.SelectedIndexChanged += new System.EventHandler(this.cboONP_SelectedIndexChanged);
            // 
            // cboAFP
            // 
            this.cboAFP.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboAFP.FormattingEnabled = true;
            this.cboAFP.Items.AddRange(new object[] {
            "SI",
            "NO"});
            this.cboAFP.Location = new System.Drawing.Point(51, 61);
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
            this.cboSCTR.Location = new System.Drawing.Point(51, 34);
            this.cboSCTR.Name = "cboSCTR";
            this.cboSCTR.Size = new System.Drawing.Size(60, 21);
            this.cboSCTR.TabIndex = 18;
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(367, 20);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(75, 23);
            this.btnRegistrar.TabIndex = 19;
            this.btnRegistrar.Text = "Agregar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(367, 49);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(75, 23);
            this.btnModificar.TabIndex = 20;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // pnlconten
            // 
            this.pnlconten.Controls.Add(this.label1);
            this.pnlconten.Controls.Add(this.cboEPS);
            this.pnlconten.Controls.Add(this.txtCUPSS);
            this.pnlconten.Controls.Add(this.cboSCTR);
            this.pnlconten.Controls.Add(this.label2);
            this.pnlconten.Controls.Add(this.cboAFP);
            this.pnlconten.Controls.Add(this.label3);
            this.pnlconten.Controls.Add(this.cboONP);
            this.pnlconten.Controls.Add(this.label4);
            this.pnlconten.Controls.Add(this.cboAFPEmpresa);
            this.pnlconten.Controls.Add(this.label5);
            this.pnlconten.Controls.Add(this.cboEPSAdicional);
            this.pnlconten.Controls.Add(this.label6);
            this.pnlconten.Controls.Add(this.label7);
            this.pnlconten.Location = new System.Drawing.Point(12, 12);
            this.pnlconten.Name = "pnlconten";
            this.pnlconten.Size = new System.Drawing.Size(349, 152);
            this.pnlconten.TabIndex = 21;
            // 
            // btncancelar
            // 
            this.btncancelar.Location = new System.Drawing.Point(367, 173);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(75, 23);
            this.btncancelar.TabIndex = 23;
            this.btncancelar.Text = "Cancelar";
            this.btncancelar.UseVisualStyleBackColor = true;
            this.btncancelar.Click += new System.EventHandler(this.btncancelar_Click);
            // 
            // btnaceptar
            // 
            this.btnaceptar.Location = new System.Drawing.Point(286, 173);
            this.btnaceptar.Name = "btnaceptar";
            this.btnaceptar.Size = new System.Drawing.Size(75, 23);
            this.btnaceptar.TabIndex = 22;
            this.btnaceptar.Text = "Aceptar";
            this.btnaceptar.UseVisualStyleBackColor = true;
            this.btnaceptar.Click += new System.EventHandler(this.btnaceptar_Click);
            // 
            // frmEmpleadoPensionSeguro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(456, 204);
            this.Controls.Add(this.btncancelar);
            this.Controls.Add(this.btnaceptar);
            this.Controls.Add(this.pnlconten);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnRegistrar);
            this.MaximizeBox = false;
            this.Name = "frmEmpleadoPensionSeguro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "  Pensión y Seguro";
            this.Load += new System.EventHandler(this.frmEmpleadoPensionSeguro_Load);
            this.pnlconten.ResumeLayout(false);
            this.pnlconten.PerformLayout();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.Panel pnlconten;
        private System.Windows.Forms.Button btncancelar;
        private System.Windows.Forms.Button btnaceptar;
    }
}