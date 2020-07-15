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
            this.chkGAsientos = new HpResergerUserControls.checkboxOre();
            this.rbTodasEmpresa = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboMesAño2 = new HpResergerUserControls.ComboMesAño();
            this.comboMesAño1 = new HpResergerUserControls.ComboMesAño();
            this.rbPersona = new System.Windows.Forms.RadioButton();
            this.rbEmpresa = new System.Windows.Forms.RadioButton();
            this.txtnumero = new System.Windows.Forms.TextBox();
            this.cbotipoid = new System.Windows.Forms.ComboBox();
            this.cboempresa = new System.Windows.Forms.ComboBox();
            this.btngenerar = new HpResergerUserControls.ButtonPer();
            this.label5 = new System.Windows.Forms.Label();
            this.btnlimpiar = new System.Windows.Forms.Button();
            this.BtnCerrar = new HpResergerUserControls.ButtonPer();
            this.label3 = new System.Windows.Forms.Label();
            this.cboetapa = new System.Windows.Forms.ComboBox();
            this.cboproyecto = new System.Windows.Forms.ComboBox();
            this.txtGlosa1 = new HpResergerUserControls.TextBoxPer();
            this.txtglosa2 = new HpResergerUserControls.TextBoxPer();
            this.SuspendLayout();
            // 
            // chkGAsientos
            // 
            this.chkGAsientos.AutoSize = true;
            this.chkGAsientos.BackColor = System.Drawing.Color.Transparent;
            this.chkGAsientos.ColorChecked = System.Drawing.Color.Empty;
            this.chkGAsientos.ColorUnChecked = System.Drawing.Color.Empty;
            this.chkGAsientos.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.chkGAsientos.Location = new System.Drawing.Point(324, 32);
            this.chkGAsientos.Name = "chkGAsientos";
            this.chkGAsientos.Size = new System.Drawing.Size(169, 17);
            this.chkGAsientos.TabIndex = 0;
            this.chkGAsientos.Text = "Generar Asientos Contables";
            this.chkGAsientos.UseVisualStyleBackColor = false;
            this.chkGAsientos.CheckedChanged += new System.EventHandler(this.chkGAsientos_CheckedChanged);
            // 
            // rbTodasEmpresa
            // 
            this.rbTodasEmpresa.AutoSize = true;
            this.rbTodasEmpresa.BackColor = System.Drawing.Color.Transparent;
            this.rbTodasEmpresa.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.rbTodasEmpresa.Location = new System.Drawing.Point(12, 32);
            this.rbTodasEmpresa.Name = "rbTodasEmpresa";
            this.rbTodasEmpresa.Size = new System.Drawing.Size(124, 17);
            this.rbTodasEmpresa.TabIndex = 16;
            this.rbTodasEmpresa.Text = "Todas Las Empresas";
            this.rbTodasEmpresa.UseVisualStyleBackColor = false;
            this.rbTodasEmpresa.CheckedChanged += new System.EventHandler(this.rbTodasEmpresa_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.label2.Location = new System.Drawing.Point(124, 183);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Hasta:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.label1.Location = new System.Drawing.Point(139, 157);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "De:";
            // 
            // comboMesAño2
            // 
            this.comboMesAño2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.comboMesAño2.BackColor = System.Drawing.Color.Transparent;
            this.comboMesAño2.FechaConDiaActual = new System.DateTime(2020, 7, 15, 0, 0, 0, 0);
            this.comboMesAño2.FechaFinMes = new System.DateTime(2020, 7, 31, 0, 0, 0, 0);
            this.comboMesAño2.FechaInicioMes = new System.DateTime(2020, 7, 1, 0, 0, 0, 0);
            this.comboMesAño2.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.comboMesAño2.Location = new System.Drawing.Point(163, 173);
            this.comboMesAño2.Name = "comboMesAño2";
            this.comboMesAño2.Size = new System.Drawing.Size(209, 26);
            this.comboMesAño2.TabIndex = 9;
            this.comboMesAño2.VerAño = true;
            this.comboMesAño2.VerMes = true;
            // 
            // comboMesAño1
            // 
            this.comboMesAño1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.comboMesAño1.BackColor = System.Drawing.Color.Transparent;
            this.comboMesAño1.FechaConDiaActual = new System.DateTime(2020, 7, 15, 0, 0, 0, 0);
            this.comboMesAño1.FechaFinMes = new System.DateTime(2020, 7, 31, 0, 0, 0, 0);
            this.comboMesAño1.FechaInicioMes = new System.DateTime(2020, 7, 1, 0, 0, 0, 0);
            this.comboMesAño1.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.comboMesAño1.Location = new System.Drawing.Point(163, 150);
            this.comboMesAño1.Name = "comboMesAño1";
            this.comboMesAño1.Size = new System.Drawing.Size(209, 26);
            this.comboMesAño1.TabIndex = 5;
            this.comboMesAño1.VerAño = true;
            this.comboMesAño1.VerMes = true;
            // 
            // rbPersona
            // 
            this.rbPersona.AutoSize = true;
            this.rbPersona.BackColor = System.Drawing.Color.Transparent;
            this.rbPersona.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.rbPersona.Location = new System.Drawing.Point(12, 82);
            this.rbPersona.Name = "rbPersona";
            this.rbPersona.Size = new System.Drawing.Size(86, 17);
            this.rbPersona.TabIndex = 9;
            this.rbPersona.Text = "Por Persona";
            this.rbPersona.UseVisualStyleBackColor = false;
            this.rbPersona.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // rbEmpresa
            // 
            this.rbEmpresa.AutoSize = true;
            this.rbEmpresa.BackColor = System.Drawing.Color.Transparent;
            this.rbEmpresa.Checked = true;
            this.rbEmpresa.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.rbEmpresa.Location = new System.Drawing.Point(12, 56);
            this.rbEmpresa.Name = "rbEmpresa";
            this.rbEmpresa.Size = new System.Drawing.Size(88, 17);
            this.rbEmpresa.TabIndex = 9;
            this.rbEmpresa.TabStop = true;
            this.rbEmpresa.Text = "Por Empresa";
            this.rbEmpresa.UseVisualStyleBackColor = false;
            this.rbEmpresa.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // txtnumero
            // 
            this.txtnumero.Enabled = false;
            this.txtnumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.txtnumero.Location = new System.Drawing.Point(105, 105);
            this.txtnumero.Name = "txtnumero";
            this.txtnumero.Size = new System.Drawing.Size(357, 21);
            this.txtnumero.TabIndex = 3;
            // 
            // cbotipoid
            // 
            this.cbotipoid.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbotipoid.Enabled = false;
            this.cbotipoid.FormattingEnabled = true;
            this.cbotipoid.Location = new System.Drawing.Point(105, 80);
            this.cbotipoid.Name = "cbotipoid";
            this.cbotipoid.Size = new System.Drawing.Size(388, 21);
            this.cbotipoid.TabIndex = 2;
            this.cbotipoid.Click += new System.EventHandler(this.cbotipoid_Click);
            // 
            // cboempresa
            // 
            this.cboempresa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboempresa.FormattingEnabled = true;
            this.cboempresa.Location = new System.Drawing.Point(105, 54);
            this.cboempresa.Name = "cboempresa";
            this.cboempresa.Size = new System.Drawing.Size(388, 21);
            this.cboempresa.TabIndex = 1;
            this.cboempresa.SelectedIndexChanged += new System.EventHandler(this.cboempresa_SelectedIndexChanged);
            this.cboempresa.Click += new System.EventHandler(this.cboempresa_Click);
            // 
            // btngenerar
            // 
            this.btngenerar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btngenerar.BackColor = System.Drawing.Color.SeaGreen;
            this.btngenerar.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.btngenerar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btngenerar.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btngenerar.ForeColor = System.Drawing.Color.White;
            this.btngenerar.Location = new System.Drawing.Point(165, 252);
            this.btngenerar.Name = "btngenerar";
            this.btngenerar.Size = new System.Drawing.Size(83, 24);
            this.btngenerar.TabIndex = 11;
            this.btngenerar.Text = "&Generar";
            this.btngenerar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btngenerar.UseVisualStyleBackColor = false;
            this.btngenerar.Click += new System.EventHandler(this.btngenerar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(198, 13);
            this.label5.TabIndex = 34;
            this.label5.Text = "Seleccione como Generar las Boletas:";
            // 
            // btnlimpiar
            // 
            this.btnlimpiar.BackColor = System.Drawing.SystemColors.Control;
            this.btnlimpiar.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlimpiar.ForeColor = System.Drawing.Color.Black;
            this.btnlimpiar.Image = ((System.Drawing.Image)(resources.GetObject("btnlimpiar.Image")));
            this.btnlimpiar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnlimpiar.Location = new System.Drawing.Point(468, 104);
            this.btnlimpiar.Name = "btnlimpiar";
            this.btnlimpiar.Size = new System.Drawing.Size(25, 23);
            this.btnlimpiar.TabIndex = 4;
            this.btnlimpiar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnlimpiar.UseVisualStyleBackColor = true;
            this.btnlimpiar.Click += new System.EventHandler(this.btnlimpiar_Click);
            // 
            // BtnCerrar
            // 
            this.BtnCerrar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.BtnCerrar.BackColor = System.Drawing.Color.Crimson;
            this.BtnCerrar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnCerrar.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.BtnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCerrar.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCerrar.ForeColor = System.Drawing.Color.White;
            this.BtnCerrar.Location = new System.Drawing.Point(253, 252);
            this.BtnCerrar.Name = "BtnCerrar";
            this.BtnCerrar.Size = new System.Drawing.Size(83, 24);
            this.BtnCerrar.TabIndex = 12;
            this.BtnCerrar.Text = "&Cancelar";
            this.BtnCerrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnCerrar.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(183, 13);
            this.label3.TabIndex = 34;
            this.label3.Text = "Seleccione la Fecha de las Boletas:";
            // 
            // cboetapa
            // 
            this.cboetapa.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboetapa.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboetapa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(218)))), ((int)(((byte)(231)))));
            this.cboetapa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboetapa.FormattingEnabled = true;
            this.cboetapa.Location = new System.Drawing.Point(285, 176);
            this.cboetapa.Name = "cboetapa";
            this.cboetapa.Size = new System.Drawing.Size(208, 21);
            this.cboetapa.TabIndex = 8;
            this.cboetapa.Visible = false;
            // 
            // cboproyecto
            // 
            this.cboproyecto.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboproyecto.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboproyecto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(218)))), ((int)(((byte)(231)))));
            this.cboproyecto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboproyecto.FormattingEnabled = true;
            this.cboproyecto.Location = new System.Drawing.Point(15, 176);
            this.cboproyecto.Name = "cboproyecto";
            this.cboproyecto.Size = new System.Drawing.Size(266, 21);
            this.cboproyecto.TabIndex = 7;
            this.cboproyecto.Visible = false;
            this.cboproyecto.SelectedIndexChanged += new System.EventHandler(this.cboproyecto_SelectedIndexChanged);
            // 
            // txtGlosa1
            // 
            this.txtGlosa1.BackColor = System.Drawing.Color.White;
            this.txtGlosa1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtGlosa1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtGlosa1.ColorFondoMouseEncima = System.Drawing.Color.Empty;
            this.txtGlosa1.ColorFondoMousePresionado = System.Drawing.Color.Empty;
            this.txtGlosa1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGlosa1.ForeColor = System.Drawing.Color.Black;
            this.txtGlosa1.Format = null;
            this.txtGlosa1.Location = new System.Drawing.Point(15, 202);
            this.txtGlosa1.MaxLength = 100;
            this.txtGlosa1.Name = "txtGlosa1";
            this.txtGlosa1.NextControlOnEnter = null;
            this.txtGlosa1.Size = new System.Drawing.Size(478, 21);
            this.txtGlosa1.TabIndex = 10;
            this.txtGlosa1.Text = "INGRESE GLOSA DEL ASIENTO DE LA BOLETA";
            this.txtGlosa1.TextoDefecto = "INGRESE GLOSA DEL ASIENTO DE LA BOLETA";
            this.txtGlosa1.TextoDefectoColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(129)))), ((int)(((byte)(189)))));
            this.txtGlosa1.TiposDatos = HpResergerUserControls.TextBoxPer.ListaTipos.MayusculaCadaPalabra;
            this.txtGlosa1.Visible = false;
            // 
            // txtglosa2
            // 
            this.txtglosa2.BackColor = System.Drawing.Color.White;
            this.txtglosa2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtglosa2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtglosa2.ColorFondoMouseEncima = System.Drawing.Color.Empty;
            this.txtglosa2.ColorFondoMousePresionado = System.Drawing.Color.Empty;
            this.txtglosa2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtglosa2.ForeColor = System.Drawing.Color.Black;
            this.txtglosa2.Format = null;
            this.txtglosa2.Location = new System.Drawing.Point(15, 225);
            this.txtglosa2.MaxLength = 100;
            this.txtglosa2.Name = "txtglosa2";
            this.txtglosa2.NextControlOnEnter = null;
            this.txtglosa2.Size = new System.Drawing.Size(478, 21);
            this.txtglosa2.TabIndex = 10;
            this.txtglosa2.Text = "INGRESE GLOSA DEL ASIENTO DE LA PROVISIÓN";
            this.txtglosa2.TextoDefecto = "INGRESE GLOSA DEL ASIENTO DE LA PROVISIÓN";
            this.txtglosa2.TextoDefectoColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(129)))), ((int)(((byte)(189)))));
            this.txtglosa2.TiposDatos = HpResergerUserControls.TextBoxPer.ListaTipos.MayusculaCadaPalabra;
            this.txtglosa2.Visible = false;
            // 
            // frmGenerarBoletas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(501, 283);
            this.Controls.Add(this.BtnCerrar);
            this.Controls.Add(this.btngenerar);
            this.Controls.Add(this.txtglosa2);
            this.Controls.Add(this.txtGlosa1);
            this.Controls.Add(this.cboetapa);
            this.Controls.Add(this.cboproyecto);
            this.Controls.Add(this.btnlimpiar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.chkGAsientos);
            this.Controls.Add(this.rbTodasEmpresa);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cboempresa);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbotipoid);
            this.Controls.Add(this.txtnumero);
            this.Controls.Add(this.comboMesAño1);
            this.Controls.Add(this.rbPersona);
            this.Controls.Add(this.rbEmpresa);
            this.Controls.Add(this.comboMesAño2);
            this.Name = "frmGenerarBoletas";
            this.Nombre = "Generar Boletas";
            this.Text = "Generar Boletas";
            this.Load += new System.EventHandler(this.frmGenerarBoletas_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cboempresa;
        private System.Windows.Forms.TextBox txtnumero;
        private System.Windows.Forms.ComboBox cbotipoid;
        private System.Windows.Forms.RadioButton rbPersona;
        private System.Windows.Forms.RadioButton rbEmpresa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private HpResergerUserControls.ComboMesAño comboMesAño2;
        private HpResergerUserControls.ComboMesAño comboMesAño1;
        private System.Windows.Forms.RadioButton rbTodasEmpresa;
        private HpResergerUserControls.checkboxOre chkGAsientos;
        private HpResergerUserControls.ButtonPer btngenerar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnlimpiar;
        private HpResergerUserControls.ButtonPer BtnCerrar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboetapa;
        private System.Windows.Forms.ComboBox cboproyecto;
        private HpResergerUserControls.TextBoxPer txtGlosa1;
        private HpResergerUserControls.TextBoxPer txtglosa2;
    }
}