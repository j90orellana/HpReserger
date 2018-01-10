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
            this.cboaplica = new System.Windows.Forms.ComboBox();
            this.numdesc = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.cbodescuento = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btncancelar = new System.Windows.Forms.Button();
            this.btnaceptar = new System.Windows.Forms.Button();
            this.cboplan = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.pnlconten.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numdesc)).BeginInit();
            this.SuspendLayout();
            // 
            // cboEPS
            // 
            this.cboEPS.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEPS.FormattingEnabled = true;
            this.cboEPS.Items.AddRange(new object[] {
            "SI",
            "NO"});
            this.cboEPS.Location = new System.Drawing.Point(51, 8);
            this.cboEPS.Name = "cboEPS";
            this.cboEPS.Size = new System.Drawing.Size(60, 21);
            this.cboEPS.TabIndex = 0;
            this.cboEPS.SelectedIndexChanged += new System.EventHandler(this.cboEPS_SelectedIndexChanged);
            // 
            // txtCUPSS
            // 
            this.txtCUPSS.Location = new System.Drawing.Point(96, 142);
            this.txtCUPSS.MaxLength = 12;
            this.txtCUPSS.Name = "txtCUPSS";
            this.txtCUPSS.Size = new System.Drawing.Size(241, 20);
            this.txtCUPSS.TabIndex = 6;
            this.txtCUPSS.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCUPSS_KeyDown);
            this.txtCUPSS.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCUPSS_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "EPS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "SCTR";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "AFP";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "AFP Empresa";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(161, 96);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "ONP";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(4, 149);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Número CUSPP";
            // 
            // cboEPSAdicional
            // 
            this.cboEPSAdicional.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEPSAdicional.FormattingEnabled = true;
            this.cboEPSAdicional.Items.AddRange(new object[] {
            "SI",
            "NO"});
            this.cboEPSAdicional.Location = new System.Drawing.Point(250, 8);
            this.cboEPSAdicional.Name = "cboEPSAdicional";
            this.cboEPSAdicional.Size = new System.Drawing.Size(87, 21);
            this.cboEPSAdicional.TabIndex = 14;
            this.cboEPSAdicional.SelectedIndexChanged += new System.EventHandler(this.cboEPSAdicional_SelectedIndexChanged);
            // 
            // cboAFPEmpresa
            // 
            this.cboAFPEmpresa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboAFPEmpresa.FormattingEnabled = true;
            this.cboAFPEmpresa.Items.AddRange(new object[] {
            "SI",
            "NO"});
            this.cboAFPEmpresa.Location = new System.Drawing.Point(96, 115);
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
            this.cboONP.Location = new System.Drawing.Point(197, 88);
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
            this.cboAFP.Location = new System.Drawing.Point(51, 88);
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
            this.cboSCTR.Location = new System.Drawing.Point(51, 61);
            this.cboSCTR.Name = "cboSCTR";
            this.cboSCTR.Size = new System.Drawing.Size(60, 21);
            this.cboSCTR.TabIndex = 18;
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRegistrar.Location = new System.Drawing.Point(368, 20);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(75, 23);
            this.btnRegistrar.TabIndex = 19;
            this.btnRegistrar.Text = "Agregar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnModificar.Location = new System.Drawing.Point(368, 49);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(75, 23);
            this.btnModificar.TabIndex = 20;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // pnlconten
            // 
            this.pnlconten.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlconten.Controls.Add(this.cboplan);
            this.pnlconten.Controls.Add(this.label10);
            this.pnlconten.Controls.Add(this.cboaplica);
            this.pnlconten.Controls.Add(this.numdesc);
            this.pnlconten.Controls.Add(this.label9);
            this.pnlconten.Controls.Add(this.cbodescuento);
            this.pnlconten.Controls.Add(this.label8);
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
            this.pnlconten.Controls.Add(this.cboEPSAdicional);
            this.pnlconten.Controls.Add(this.label6);
            this.pnlconten.Controls.Add(this.label7);
            this.pnlconten.Location = new System.Drawing.Point(12, 12);
            this.pnlconten.Name = "pnlconten";
            this.pnlconten.Size = new System.Drawing.Size(350, 202);
            this.pnlconten.TabIndex = 21;
            // 
            // cboaplica
            // 
            this.cboaplica.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboaplica.FormattingEnabled = true;
            this.cboaplica.Items.AddRange(new object[] {
            "No Aplica",
            "Aplica"});
            this.cboaplica.Location = new System.Drawing.Point(51, 35);
            this.cboaplica.Name = "cboaplica";
            this.cboaplica.Size = new System.Drawing.Size(71, 21);
            this.cboaplica.TabIndex = 23;
            this.cboaplica.SelectedIndexChanged += new System.EventHandler(this.cboaplica_SelectedIndexChanged);
            // 
            // numdesc
            // 
            this.numdesc.DecimalPlaces = 2;
            this.numdesc.Location = new System.Drawing.Point(250, 35);
            this.numdesc.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numdesc.Name = "numdesc";
            this.numdesc.Size = new System.Drawing.Size(87, 20);
            this.numdesc.TabIndex = 22;
            this.numdesc.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numdesc.ValueChanged += new System.EventHandler(this.numdesc_ValueChanged);
            this.numdesc.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.numdesc_HelpRequested);
            this.numdesc.Layout += new System.Windows.Forms.LayoutEventHandler(this.numdesc_Layout);
            this.numdesc.Leave += new System.EventHandler(this.numdesc_Leave);
            this.numdesc.Validating += new System.ComponentModel.CancelEventHandler(this.numdesc_Validating);
            this.numdesc.Validated += new System.EventHandler(this.numdesc_Validated);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(210, 37);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(34, 13);
            this.label9.TabIndex = 21;
            this.label9.Text = "Valor:";
            // 
            // cbodescuento
            // 
            this.cbodescuento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbodescuento.FormattingEnabled = true;
            this.cbodescuento.Items.AddRange(new object[] {
            "SI",
            "NO"});
            this.cbodescuento.Location = new System.Drawing.Point(128, 35);
            this.cbodescuento.Name = "cbodescuento";
            this.cbodescuento.Size = new System.Drawing.Size(76, 21);
            this.cbodescuento.TabIndex = 20;
            this.cbodescuento.SelectedIndexChanged += new System.EventHandler(this.cbodescuento_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(4, 42);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(39, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "DESC:";
            // 
            // btncancelar
            // 
            this.btncancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btncancelar.Location = new System.Drawing.Point(368, 191);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(75, 23);
            this.btncancelar.TabIndex = 23;
            this.btncancelar.Text = "Cancelar";
            this.btncancelar.UseVisualStyleBackColor = true;
            this.btncancelar.Click += new System.EventHandler(this.btncancelar_Click);
            // 
            // btnaceptar
            // 
            this.btnaceptar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnaceptar.Location = new System.Drawing.Point(368, 163);
            this.btnaceptar.Name = "btnaceptar";
            this.btnaceptar.Size = new System.Drawing.Size(75, 23);
            this.btnaceptar.TabIndex = 22;
            this.btnaceptar.Text = "Aceptar";
            this.btnaceptar.UseVisualStyleBackColor = true;
            this.btnaceptar.Click += new System.EventHandler(this.btnaceptar_Click);
            // 
            // cboplan
            // 
            this.cboplan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboplan.FormattingEnabled = true;
            this.cboplan.Items.AddRange(new object[] {
            "SI",
            "NO"});
            this.cboplan.Location = new System.Drawing.Point(145, 8);
            this.cboplan.Name = "cboplan";
            this.cboplan.Size = new System.Drawing.Size(99, 21);
            this.cboplan.TabIndex = 24;
            this.cboplan.SelectedIndexChanged += new System.EventHandler(this.cboplan_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(119, 11);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(28, 13);
            this.label10.TabIndex = 25;
            this.label10.Text = "Plan";
            // 
            // frmEmpleadoPensionSeguro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(457, 226);
            this.Controls.Add(this.btncancelar);
            this.Controls.Add(this.btnaceptar);
            this.Controls.Add(this.pnlconten);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnRegistrar);
            this.MaximumSize = new System.Drawing.Size(473, 265);
            this.MinimumSize = new System.Drawing.Size(473, 265);
            this.Name = "frmEmpleadoPensionSeguro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "  Pensión y Seguro";
            this.Load += new System.EventHandler(this.frmEmpleadoPensionSeguro_Load);
            this.pnlconten.ResumeLayout(false);
            this.pnlconten.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numdesc)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cboEPS;
        private System.Windows.Forms.TextBox txtCUPSS;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
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
        private System.Windows.Forms.ComboBox cbodescuento;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown numdesc;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cboaplica;
        private System.Windows.Forms.ComboBox cboplan;
        private System.Windows.Forms.Label label10;
    }
}