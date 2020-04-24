namespace HPReserger.ModuloContable
{
    partial class frmRevesarAsientos
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
            this.PanelOtraReversa = new System.Windows.Forms.Panel();
            this.txtGlosa = new HpResergerUserControls.TextBoxPer();
            this.label18 = new System.Windows.Forms.Label();
            this.dtpFechaContableReversa = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaEmisionReversa = new System.Windows.Forms.DateTimePicker();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.rbReversarPeriodo = new System.Windows.Forms.RadioButton();
            this.rbReversar = new System.Windows.Forms.RadioButton();
            this.separadorOre3 = new HpResergerUserControls.SeparadorOre();
            this.label31 = new System.Windows.Forms.Label();
            this.btnTxt = new HpResergerUserControls.ButtonPer();
            this.BtnCerrar = new HpResergerUserControls.ButtonPer();
            this.btnAsientosRelacionados = new HpResergerUserControls.ButtonPer();
            this.PanelOtraReversa.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelOtraReversa
            // 
            this.PanelOtraReversa.BackColor = System.Drawing.Color.Transparent;
            this.PanelOtraReversa.Controls.Add(this.txtGlosa);
            this.PanelOtraReversa.Controls.Add(this.label18);
            this.PanelOtraReversa.Controls.Add(this.dtpFechaContableReversa);
            this.PanelOtraReversa.Controls.Add(this.dtpFechaEmisionReversa);
            this.PanelOtraReversa.Controls.Add(this.label15);
            this.PanelOtraReversa.Controls.Add(this.label16);
            this.PanelOtraReversa.Enabled = false;
            this.PanelOtraReversa.Location = new System.Drawing.Point(13, 58);
            this.PanelOtraReversa.Name = "PanelOtraReversa";
            this.PanelOtraReversa.Size = new System.Drawing.Size(418, 115);
            this.PanelOtraReversa.TabIndex = 9;
            // 
            // txtGlosa
            // 
            this.txtGlosa.BackColor = System.Drawing.Color.White;
            this.txtGlosa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtGlosa.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtGlosa.ColorFondoMouseEncima = System.Drawing.Color.Empty;
            this.txtGlosa.ColorFondoMousePresionado = System.Drawing.Color.Empty;
            this.txtGlosa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGlosa.ForeColor = System.Drawing.Color.Black;
            this.txtGlosa.Format = null;
            this.txtGlosa.Location = new System.Drawing.Point(8, 85);
            this.txtGlosa.MaxLength = 100;
            this.txtGlosa.Name = "txtGlosa";
            this.txtGlosa.NextControlOnEnter = null;
            this.txtGlosa.Size = new System.Drawing.Size(400, 21);
            this.txtGlosa.TabIndex = 178;
            this.txtGlosa.Text = "INGRESE GLOSA DEL ASIENTO";
            this.txtGlosa.TextoDefecto = "INGRESE GLOSA DEL ASIENTO";
            this.txtGlosa.TextoDefectoColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(129)))), ((int)(((byte)(189)))));
            this.txtGlosa.TiposDatos = HpResergerUserControls.TextBoxPer.ListaTipos.MayusculaCadaPalabra;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.BackColor = System.Drawing.Color.Transparent;
            this.label18.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(8, 69);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(100, 13);
            this.label18.TabIndex = 179;
            this.label18.Text = "Glosa del Asiento:";
            // 
            // dtpFechaContableReversa
            // 
            this.dtpFechaContableReversa.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaContableReversa.Location = new System.Drawing.Point(179, 40);
            this.dtpFechaContableReversa.MaxDate = new System.DateTime(3000, 12, 31, 0, 0, 0, 0);
            this.dtpFechaContableReversa.MinDate = new System.DateTime(1950, 1, 1, 0, 0, 0, 0);
            this.dtpFechaContableReversa.Name = "dtpFechaContableReversa";
            this.dtpFechaContableReversa.Size = new System.Drawing.Size(229, 22);
            this.dtpFechaContableReversa.TabIndex = 142;
            this.dtpFechaContableReversa.Value = new System.DateTime(2017, 4, 27, 9, 44, 35, 0);
            // 
            // dtpFechaEmisionReversa
            // 
            this.dtpFechaEmisionReversa.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaEmisionReversa.Location = new System.Drawing.Point(179, 12);
            this.dtpFechaEmisionReversa.MaxDate = new System.DateTime(3000, 12, 31, 0, 0, 0, 0);
            this.dtpFechaEmisionReversa.MinDate = new System.DateTime(1950, 1, 1, 0, 0, 0, 0);
            this.dtpFechaEmisionReversa.Name = "dtpFechaEmisionReversa";
            this.dtpFechaEmisionReversa.Size = new System.Drawing.Size(229, 22);
            this.dtpFechaEmisionReversa.TabIndex = 141;
            this.dtpFechaEmisionReversa.Value = new System.DateTime(2017, 4, 27, 9, 44, 35, 0);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(89, 45);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(90, 13);
            this.label15.TabIndex = 143;
            this.label15.Text = "Fecha Contable:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.Transparent;
            this.label16.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(99, 17);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(80, 13);
            this.label16.TabIndex = 144;
            this.label16.Text = "FechaEmisión:";
            // 
            // rbReversarPeriodo
            // 
            this.rbReversarPeriodo.AutoSize = true;
            this.rbReversarPeriodo.BackColor = System.Drawing.Color.Transparent;
            this.rbReversarPeriodo.Location = new System.Drawing.Point(13, 37);
            this.rbReversarPeriodo.Name = "rbReversarPeriodo";
            this.rbReversarPeriodo.Size = new System.Drawing.Size(154, 17);
            this.rbReversarPeriodo.TabIndex = 8;
            this.rbReversarPeriodo.Text = "Reversar en Otro Periodo";
            this.rbReversarPeriodo.UseVisualStyleBackColor = false;
            this.rbReversarPeriodo.CheckedChanged += new System.EventHandler(this.rbReversarPeriodo_CheckedChanged);
            // 
            // rbReversar
            // 
            this.rbReversar.AutoSize = true;
            this.rbReversar.BackColor = System.Drawing.Color.Transparent;
            this.rbReversar.Checked = true;
            this.rbReversar.Location = new System.Drawing.Point(13, 177);
            this.rbReversar.Name = "rbReversar";
            this.rbReversar.Size = new System.Drawing.Size(94, 17);
            this.rbReversar.TabIndex = 8;
            this.rbReversar.TabStop = true;
            this.rbReversar.Text = "Solo Reversar";
            this.rbReversar.UseVisualStyleBackColor = false;
            // 
            // separadorOre3
            // 
            this.separadorOre3.BackColor = System.Drawing.Color.Transparent;
            this.separadorOre3.Location = new System.Drawing.Point(95, 2);
            this.separadorOre3.MaximumSize = new System.Drawing.Size(2000, 2);
            this.separadorOre3.MinimumSize = new System.Drawing.Size(0, 2);
            this.separadorOre3.Name = "separadorOre3";
            this.separadorOre3.Size = new System.Drawing.Size(253, 2);
            this.separadorOre3.TabIndex = 2;
            this.separadorOre3.Visible = false;
            // 
            // label31
            // 
            this.label31.BackColor = System.Drawing.Color.Transparent;
            this.label31.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label31.Location = new System.Drawing.Point(98, 9);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(246, 17);
            this.label31.TabIndex = 1;
            this.label31.Text = "REVERSA DE ASIENTOS";
            this.label31.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnTxt
            // 
            this.btnTxt.BackColor = System.Drawing.Color.SeaGreen;
            this.btnTxt.FlatAppearance.BorderColor = System.Drawing.Color.Olive;
            this.btnTxt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTxt.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTxt.ForeColor = System.Drawing.Color.White;
            this.btnTxt.Location = new System.Drawing.Point(259, 195);
            this.btnTxt.Name = "btnTxt";
            this.btnTxt.Size = new System.Drawing.Size(83, 23);
            this.btnTxt.TabIndex = 0;
            this.btnTxt.Text = "Procesar";
            this.btnTxt.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTxt.UseVisualStyleBackColor = false;
            this.btnTxt.Click += new System.EventHandler(this.btnTxt_Click);
            // 
            // BtnCerrar
            // 
            this.BtnCerrar.BackColor = System.Drawing.Color.Crimson;
            this.BtnCerrar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnCerrar.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.BtnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCerrar.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCerrar.ForeColor = System.Drawing.Color.White;
            this.BtnCerrar.Location = new System.Drawing.Point(347, 195);
            this.BtnCerrar.Name = "BtnCerrar";
            this.BtnCerrar.Size = new System.Drawing.Size(83, 23);
            this.BtnCerrar.TabIndex = 0;
            this.BtnCerrar.Text = "Cancelar";
            this.BtnCerrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnCerrar.UseVisualStyleBackColor = false;
            this.BtnCerrar.Click += new System.EventHandler(this.BtnCerrar_Click);
            // 
            // btnAsientosRelacionados
            // 
            this.btnAsientosRelacionados.BackColor = System.Drawing.Color.SeaGreen;
            this.btnAsientosRelacionados.FlatAppearance.BorderColor = System.Drawing.Color.Olive;
            this.btnAsientosRelacionados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAsientosRelacionados.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAsientosRelacionados.ForeColor = System.Drawing.Color.White;
            this.btnAsientosRelacionados.Location = new System.Drawing.Point(242, 34);
            this.btnAsientosRelacionados.Name = "btnAsientosRelacionados";
            this.btnAsientosRelacionados.Size = new System.Drawing.Size(100, 23);
            this.btnAsientosRelacionados.TabIndex = 0;
            this.btnAsientosRelacionados.Text = "Asientos Asoc.";
            this.btnAsientosRelacionados.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAsientosRelacionados.UseVisualStyleBackColor = false;
            this.btnAsientosRelacionados.Click += new System.EventHandler(this.btnAsientosRelacionados_Click);
            // 
            // frmRevesarAsientos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 229);
            this.Controls.Add(this.PanelOtraReversa);
            this.Controls.Add(this.rbReversarPeriodo);
            this.Controls.Add(this.BtnCerrar);
            this.Controls.Add(this.rbReversar);
            this.Controls.Add(this.btnAsientosRelacionados);
            this.Controls.Add(this.btnTxt);
            this.Controls.Add(this.label31);
            this.Controls.Add(this.separadorOre3);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximumSize = new System.Drawing.Size(458, 268);
            this.MinimumSize = new System.Drawing.Size(458, 268);
            this.Name = "frmRevesarAsientos";
            this.Nombre = "Reversar Asientos";
            this.Text = "Reversar Asientos";
            this.Load += new System.EventHandler(this.frmRevesarAsientos_Load);
            this.PanelOtraReversa.ResumeLayout(false);
            this.PanelOtraReversa.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel PanelOtraReversa;
        private HpResergerUserControls.TextBoxPer txtGlosa;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.DateTimePicker dtpFechaContableReversa;
        private System.Windows.Forms.DateTimePicker dtpFechaEmisionReversa;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.RadioButton rbReversar;
        private HpResergerUserControls.SeparadorOre separadorOre3;
        private System.Windows.Forms.Label label31;
        private HpResergerUserControls.ButtonPer btnTxt;
        private HpResergerUserControls.ButtonPer BtnCerrar;
        private HpResergerUserControls.ButtonPer btnAsientosRelacionados;
        public System.Windows.Forms.RadioButton rbReversarPeriodo;
    }
}