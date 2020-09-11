namespace HPReserger
{
    partial class frmGenerarGratificacion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGenerarGratificacion));
            this.comboMesAño1 = new HpResergerUserControls.ComboMesAño();
            this.rbPersona = new System.Windows.Forms.RadioButton();
            this.rbEmpresa = new System.Windows.Forms.RadioButton();
            this.txtnumero = new System.Windows.Forms.TextBox();
            this.cbotipoid = new System.Windows.Forms.ComboBox();
            this.cboempresa = new System.Windows.Forms.ComboBox();
            this.txtGlosa1 = new HpResergerUserControls.TextBoxPer();
            this.cboetapa = new System.Windows.Forms.ComboBox();
            this.cboproyecto = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.BtnCerrar = new HpResergerUserControls.ButtonPer();
            this.buttonPer1 = new HpResergerUserControls.ButtonPer();
            this.btnlimpiar = new System.Windows.Forms.Button();
            this.chkGAsientos = new HpResergerUserControls.checkboxOre();
            this.label5 = new System.Windows.Forms.Label();
            this.cboCuentaBancaria = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comboMesAño1
            // 
            this.comboMesAño1.AutoSize = true;
            this.comboMesAño1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.comboMesAño1.BackColor = System.Drawing.Color.Transparent;
            this.comboMesAño1.FechaConDiaActual = new System.DateTime(2020, 9, 30, 0, 0, 0, 0);
            this.comboMesAño1.FechaFinMes = new System.DateTime(2020, 9, 30, 0, 0, 0, 0);
            this.comboMesAño1.FechaInicioMes = new System.DateTime(2020, 9, 1, 0, 0, 0, 0);
            this.comboMesAño1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboMesAño1.Location = new System.Drawing.Point(142, 127);
            this.comboMesAño1.Name = "comboMesAño1";
            this.comboMesAño1.Size = new System.Drawing.Size(213, 27);
            this.comboMesAño1.TabIndex = 13;
            this.comboMesAño1.VerAño = true;
            this.comboMesAño1.VerMes = true;
            this.comboMesAño1.CambioFechas += new System.EventHandler(this.comboMesAño1_CambioFechas);
            // 
            // rbPersona
            // 
            this.rbPersona.AutoSize = true;
            this.rbPersona.BackColor = System.Drawing.Color.Transparent;
            this.rbPersona.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbPersona.Location = new System.Drawing.Point(17, 62);
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
            this.rbEmpresa.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbEmpresa.Location = new System.Drawing.Point(17, 37);
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
            this.txtnumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnumero.Location = new System.Drawing.Point(108, 87);
            this.txtnumero.Name = "txtnumero";
            this.txtnumero.Size = new System.Drawing.Size(348, 21);
            this.txtnumero.TabIndex = 7;
            // 
            // cbotipoid
            // 
            this.cbotipoid.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbotipoid.Enabled = false;
            this.cbotipoid.FormattingEnabled = true;
            this.cbotipoid.Location = new System.Drawing.Point(108, 61);
            this.cbotipoid.Name = "cbotipoid";
            this.cbotipoid.Size = new System.Drawing.Size(379, 21);
            this.cbotipoid.TabIndex = 4;
            this.cbotipoid.SelectedIndexChanged += new System.EventHandler(this.cbotipoid_SelectedIndexChanged);
            // 
            // cboempresa
            // 
            this.cboempresa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboempresa.FormattingEnabled = true;
            this.cboempresa.Location = new System.Drawing.Point(108, 35);
            this.cboempresa.Name = "cboempresa";
            this.cboempresa.Size = new System.Drawing.Size(379, 21);
            this.cboempresa.TabIndex = 1;
            this.cboempresa.SelectedIndexChanged += new System.EventHandler(this.cboempresa_SelectedIndexChanged);
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
            this.txtGlosa1.Location = new System.Drawing.Point(9, 182);
            this.txtGlosa1.MaxLength = 100;
            this.txtGlosa1.Name = "txtGlosa1";
            this.txtGlosa1.NextControlOnEnter = null;
            this.txtGlosa1.Size = new System.Drawing.Size(478, 21);
            this.txtGlosa1.TabIndex = 52;
            this.txtGlosa1.Text = "INGRESE GLOSA DEL ASIENTO DE LA GRATIFICACION";
            this.txtGlosa1.TextoDefecto = "INGRESE GLOSA DEL ASIENTO DE LA GRATIFICACION";
            this.txtGlosa1.TextoDefectoColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(129)))), ((int)(((byte)(189)))));
            this.txtGlosa1.TiposDatos = HpResergerUserControls.TextBoxPer.ListaTipos.MayusculaCadaPalabra;
            this.txtGlosa1.Visible = false;
            // 
            // cboetapa
            // 
            this.cboetapa.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboetapa.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboetapa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(218)))), ((int)(((byte)(231)))));
            this.cboetapa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboetapa.FormattingEnabled = true;
            this.cboetapa.Location = new System.Drawing.Point(279, 156);
            this.cboetapa.Name = "cboetapa";
            this.cboetapa.Size = new System.Drawing.Size(208, 21);
            this.cboetapa.TabIndex = 51;
            this.cboetapa.Visible = false;
            // 
            // cboproyecto
            // 
            this.cboproyecto.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboproyecto.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboproyecto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(218)))), ((int)(((byte)(231)))));
            this.cboproyecto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboproyecto.FormattingEnabled = true;
            this.cboproyecto.Location = new System.Drawing.Point(9, 156);
            this.cboproyecto.Name = "cboproyecto";
            this.cboproyecto.Size = new System.Drawing.Size(266, 21);
            this.cboproyecto.TabIndex = 50;
            this.cboproyecto.Visible = false;
            this.cboproyecto.SelectedIndexChanged += new System.EventHandler(this.cboproyecto_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(11, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(205, 13);
            this.label3.TabIndex = 49;
            this.label3.Text = "Seleccione la Fecha de la Gratificación:";
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
            this.BtnCerrar.Location = new System.Drawing.Point(251, 232);
            this.BtnCerrar.Name = "BtnCerrar";
            this.BtnCerrar.Size = new System.Drawing.Size(83, 24);
            this.BtnCerrar.TabIndex = 48;
            this.BtnCerrar.Text = "&Cancelar";
            this.BtnCerrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnCerrar.UseVisualStyleBackColor = false;
            this.BtnCerrar.Click += new System.EventHandler(this.BtnCerrar_Click);
            // 
            // buttonPer1
            // 
            this.buttonPer1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonPer1.BackColor = System.Drawing.Color.SeaGreen;
            this.buttonPer1.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.buttonPer1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPer1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPer1.ForeColor = System.Drawing.Color.White;
            this.buttonPer1.Location = new System.Drawing.Point(163, 232);
            this.buttonPer1.Name = "buttonPer1";
            this.buttonPer1.Size = new System.Drawing.Size(83, 24);
            this.buttonPer1.TabIndex = 47;
            this.buttonPer1.Text = "&Generar";
            this.buttonPer1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonPer1.UseVisualStyleBackColor = false;
            this.buttonPer1.Click += new System.EventHandler(this.btngenerar_Click);
            // 
            // btnlimpiar
            // 
            this.btnlimpiar.BackColor = System.Drawing.SystemColors.Control;
            this.btnlimpiar.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlimpiar.ForeColor = System.Drawing.Color.Black;
            this.btnlimpiar.Image = ((System.Drawing.Image)(resources.GetObject("btnlimpiar.Image")));
            this.btnlimpiar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnlimpiar.Location = new System.Drawing.Point(462, 86);
            this.btnlimpiar.Name = "btnlimpiar";
            this.btnlimpiar.Size = new System.Drawing.Size(25, 23);
            this.btnlimpiar.TabIndex = 46;
            this.btnlimpiar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnlimpiar.UseVisualStyleBackColor = true;
            this.btnlimpiar.Click += new System.EventHandler(this.btnlimpiar_Click_1);
            // 
            // chkGAsientos
            // 
            this.chkGAsientos.AutoSize = true;
            this.chkGAsientos.BackColor = System.Drawing.Color.Transparent;
            this.chkGAsientos.ColorChecked = System.Drawing.Color.Empty;
            this.chkGAsientos.ColorUnChecked = System.Drawing.Color.Empty;
            this.chkGAsientos.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkGAsientos.Location = new System.Drawing.Point(318, 7);
            this.chkGAsientos.Name = "chkGAsientos";
            this.chkGAsientos.Size = new System.Drawing.Size(169, 17);
            this.chkGAsientos.TabIndex = 45;
            this.chkGAsientos.Text = "Generar Asientos Contables";
            this.chkGAsientos.UseVisualStyleBackColor = false;
            this.chkGAsientos.CheckedChanged += new System.EventHandler(this.chkGAsientos_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(220, 13);
            this.label5.TabIndex = 44;
            this.label5.Text = "Seleccione como Generar la Gratificación:";
            // 
            // cboCuentaBancaria
            // 
            this.cboCuentaBancaria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCuentaBancaria.FormattingEnabled = true;
            this.cboCuentaBancaria.Location = new System.Drawing.Point(108, 207);
            this.cboCuentaBancaria.Name = "cboCuentaBancaria";
            this.cboCuentaBancaria.Size = new System.Drawing.Size(377, 21);
            this.cboCuentaBancaria.TabIndex = 53;
            this.cboCuentaBancaria.Click += new System.EventHandler(this.cboCuentaBancaria_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 211);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 54;
            this.label1.Text = "Cuenta Bancaria:";
            // 
            // frmGenerarGratificacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(497, 261);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboCuentaBancaria);
            this.Controls.Add(this.txtGlosa1);
            this.Controls.Add(this.cboetapa);
            this.Controls.Add(this.cboproyecto);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.BtnCerrar);
            this.Controls.Add(this.buttonPer1);
            this.Controls.Add(this.btnlimpiar);
            this.Controls.Add(this.chkGAsientos);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboMesAño1);
            this.Controls.Add(this.rbPersona);
            this.Controls.Add(this.rbEmpresa);
            this.Controls.Add(this.cboempresa);
            this.Controls.Add(this.cbotipoid);
            this.Controls.Add(this.txtnumero);
            this.Name = "frmGenerarGratificacion";
            this.Nombre = "Generar Gratificación";
            this.Text = "Generar Gratificación";
            this.Load += new System.EventHandler(this.frmGenerarGratificacion_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private HpResergerUserControls.ComboMesAño comboMesAño1;
        private System.Windows.Forms.RadioButton rbPersona;
        private System.Windows.Forms.RadioButton rbEmpresa;
        private System.Windows.Forms.TextBox txtnumero;
        private System.Windows.Forms.ComboBox cbotipoid;
        private System.Windows.Forms.ComboBox cboempresa;
        private HpResergerUserControls.TextBoxPer txtGlosa1;
        private System.Windows.Forms.ComboBox cboetapa;
        private System.Windows.Forms.ComboBox cboproyecto;
        private System.Windows.Forms.Label label3;
        private HpResergerUserControls.ButtonPer BtnCerrar;
        private HpResergerUserControls.ButtonPer buttonPer1;
        private System.Windows.Forms.Button btnlimpiar;
        private HpResergerUserControls.checkboxOre chkGAsientos;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cboCuentaBancaria;
        private System.Windows.Forms.Label label1;
    }
}