namespace HPReserger
{
    partial class frmEmpleadoRequerimiento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEmpleadoRequerimiento));
            this.cboCelular = new System.Windows.Forms.ComboBox();
            this.cboMaquina = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtObservacionesOtros = new System.Windows.Forms.TextBox();
            this.txtObservacionesCorreo = new System.Windows.Forms.TextBox();
            this.txtObservacionesMaquina = new System.Windows.Forms.TextBox();
            this.txtObservacionesCelular = new System.Windows.Forms.TextBox();
            this.cboOtros = new System.Windows.Forms.ComboBox();
            this.cboCorreo = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btncancelar = new System.Windows.Forms.Button();
            this.btnaceptar = new System.Windows.Forms.Button();
            this.pnlconten = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.btnimagen = new System.Windows.Forms.Button();
            this.txtimagen = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnBuscarImagenOtros = new System.Windows.Forms.Button();
            this.btnexportar = new System.Windows.Forms.Button();
            this.savefile = new System.Windows.Forms.SaveFileDialog();
            this.lklimagen = new System.Windows.Forms.LinkLabel();
            this.pbimagen = new System.Windows.Forms.PictureBox();
            this.pnlconten.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbimagen)).BeginInit();
            this.SuspendLayout();
            // 
            // cboCelular
            // 
            this.cboCelular.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(218)))), ((int)(((byte)(231)))));
            this.cboCelular.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCelular.FormattingEnabled = true;
            this.cboCelular.Items.AddRange(new object[] {
            "SI",
            "NO"});
            this.cboCelular.Location = new System.Drawing.Point(57, 17);
            this.cboCelular.Name = "cboCelular";
            this.cboCelular.Size = new System.Drawing.Size(66, 21);
            this.cboCelular.TabIndex = 0;
            this.cboCelular.SelectedIndexChanged += new System.EventHandler(this.cboCelular_SelectedIndexChanged);
            // 
            // cboMaquina
            // 
            this.cboMaquina.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(218)))), ((int)(((byte)(231)))));
            this.cboMaquina.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMaquina.FormattingEnabled = true;
            this.cboMaquina.Items.AddRange(new object[] {
            "SI",
            "NO"});
            this.cboMaquina.Location = new System.Drawing.Point(57, 55);
            this.cboMaquina.Name = "cboMaquina";
            this.cboMaquina.Size = new System.Drawing.Size(66, 21);
            this.cboMaquina.TabIndex = 1;
            this.cboMaquina.SelectedIndexChanged += new System.EventHandler(this.cboMaquina_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Celular";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Máquina";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Correo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Otros";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(129, 21);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "Observaciones";
            // 
            // txtObservacionesOtros
            // 
            this.txtObservacionesOtros.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtObservacionesOtros.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtObservacionesOtros.Location = new System.Drawing.Point(213, 125);
            this.txtObservacionesOtros.MaxLength = 70;
            this.txtObservacionesOtros.Multiline = true;
            this.txtObservacionesOtros.Name = "txtObservacionesOtros";
            this.txtObservacionesOtros.Size = new System.Drawing.Size(256, 32);
            this.txtObservacionesOtros.TabIndex = 12;
            // 
            // txtObservacionesCorreo
            // 
            this.txtObservacionesCorreo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtObservacionesCorreo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtObservacionesCorreo.Location = new System.Drawing.Point(213, 87);
            this.txtObservacionesCorreo.MaxLength = 70;
            this.txtObservacionesCorreo.Multiline = true;
            this.txtObservacionesCorreo.Name = "txtObservacionesCorreo";
            this.txtObservacionesCorreo.Size = new System.Drawing.Size(256, 32);
            this.txtObservacionesCorreo.TabIndex = 13;
            // 
            // txtObservacionesMaquina
            // 
            this.txtObservacionesMaquina.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtObservacionesMaquina.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtObservacionesMaquina.Location = new System.Drawing.Point(213, 49);
            this.txtObservacionesMaquina.MaxLength = 70;
            this.txtObservacionesMaquina.Multiline = true;
            this.txtObservacionesMaquina.Name = "txtObservacionesMaquina";
            this.txtObservacionesMaquina.Size = new System.Drawing.Size(256, 32);
            this.txtObservacionesMaquina.TabIndex = 14;
            // 
            // txtObservacionesCelular
            // 
            this.txtObservacionesCelular.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtObservacionesCelular.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtObservacionesCelular.Location = new System.Drawing.Point(213, 11);
            this.txtObservacionesCelular.MaxLength = 70;
            this.txtObservacionesCelular.Multiline = true;
            this.txtObservacionesCelular.Name = "txtObservacionesCelular";
            this.txtObservacionesCelular.Size = new System.Drawing.Size(256, 32);
            this.txtObservacionesCelular.TabIndex = 15;
            // 
            // cboOtros
            // 
            this.cboOtros.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(218)))), ((int)(((byte)(231)))));
            this.cboOtros.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboOtros.FormattingEnabled = true;
            this.cboOtros.Items.AddRange(new object[] {
            "SI",
            "NO"});
            this.cboOtros.Location = new System.Drawing.Point(57, 131);
            this.cboOtros.Name = "cboOtros";
            this.cboOtros.Size = new System.Drawing.Size(66, 21);
            this.cboOtros.TabIndex = 17;
            this.cboOtros.SelectedIndexChanged += new System.EventHandler(this.cboOtros_SelectedIndexChanged);
            // 
            // cboCorreo
            // 
            this.cboCorreo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(218)))), ((int)(((byte)(231)))));
            this.cboCorreo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCorreo.FormattingEnabled = true;
            this.cboCorreo.Items.AddRange(new object[] {
            "SI",
            "NO"});
            this.cboCorreo.Location = new System.Drawing.Point(57, 93);
            this.cboCorreo.Name = "cboCorreo";
            this.cboCorreo.Size = new System.Drawing.Size(66, 21);
            this.cboCorreo.TabIndex = 16;
            this.cboCorreo.SelectedIndexChanged += new System.EventHandler(this.cboCorreo_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(129, 135);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "Observaciones";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(129, 97);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "Observaciones";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(129, 59);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 13);
            this.label7.TabIndex = 20;
            this.label7.Text = "Observaciones";
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrar.Image = ((System.Drawing.Image)(resources.GetObject("btnRegistrar.Image")));
            this.btnRegistrar.Location = new System.Drawing.Point(491, 21);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(82, 23);
            this.btnRegistrar.TabIndex = 21;
            this.btnRegistrar.Text = "Agregar";
            this.btnRegistrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.Image = ((System.Drawing.Image)(resources.GetObject("btnModificar.Image")));
            this.btnModificar.Location = new System.Drawing.Point(491, 50);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(82, 23);
            this.btnModificar.TabIndex = 22;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btncancelar
            // 
            this.btncancelar.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncancelar.Image = ((System.Drawing.Image)(resources.GetObject("btncancelar.Image")));
            this.btncancelar.Location = new System.Drawing.Point(493, 208);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(82, 23);
            this.btncancelar.TabIndex = 24;
            this.btncancelar.Text = "Cancelar";
            this.btncancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btncancelar.UseVisualStyleBackColor = true;
            this.btncancelar.Click += new System.EventHandler(this.btncancelar_Click);
            // 
            // btnaceptar
            // 
            this.btnaceptar.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnaceptar.Image = ((System.Drawing.Image)(resources.GetObject("btnaceptar.Image")));
            this.btnaceptar.Location = new System.Drawing.Point(408, 208);
            this.btnaceptar.Name = "btnaceptar";
            this.btnaceptar.Size = new System.Drawing.Size(82, 23);
            this.btnaceptar.TabIndex = 23;
            this.btnaceptar.Text = "Aceptar";
            this.btnaceptar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnaceptar.UseVisualStyleBackColor = true;
            this.btnaceptar.Click += new System.EventHandler(this.btnaceptar_Click);
            // 
            // pnlconten
            // 
            this.pnlconten.BackColor = System.Drawing.Color.Transparent;
            this.pnlconten.Controls.Add(this.btnimagen);
            this.pnlconten.Controls.Add(this.txtimagen);
            this.pnlconten.Controls.Add(this.label9);
            this.pnlconten.Controls.Add(this.btnBuscarImagenOtros);
            this.pnlconten.Controls.Add(this.label1);
            this.pnlconten.Controls.Add(this.cboCelular);
            this.pnlconten.Controls.Add(this.cboMaquina);
            this.pnlconten.Controls.Add(this.label2);
            this.pnlconten.Controls.Add(this.label3);
            this.pnlconten.Controls.Add(this.label7);
            this.pnlconten.Controls.Add(this.label4);
            this.pnlconten.Controls.Add(this.label6);
            this.pnlconten.Controls.Add(this.label8);
            this.pnlconten.Controls.Add(this.label5);
            this.pnlconten.Controls.Add(this.txtObservacionesOtros);
            this.pnlconten.Controls.Add(this.cboOtros);
            this.pnlconten.Controls.Add(this.txtObservacionesCorreo);
            this.pnlconten.Controls.Add(this.cboCorreo);
            this.pnlconten.Controls.Add(this.txtObservacionesMaquina);
            this.pnlconten.Controls.Add(this.txtObservacionesCelular);
            this.pnlconten.Controls.Add(this.label10);
            this.pnlconten.Location = new System.Drawing.Point(12, 12);
            this.pnlconten.Name = "pnlconten";
            this.pnlconten.Size = new System.Drawing.Size(475, 190);
            this.pnlconten.TabIndex = 25;
            this.pnlconten.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlconten_Paint);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(3, 169);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(148, 13);
            this.label10.TabIndex = 94;
            this.label10.Text = "Imagen de Requerimientos:";
            // 
            // btnimagen
            // 
            this.btnimagen.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnimagen.BackgroundImage")));
            this.btnimagen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnimagen.FlatAppearance.BorderSize = 0;
            this.btnimagen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnimagen.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnimagen.Location = new System.Drawing.Point(449, 165);
            this.btnimagen.Name = "btnimagen";
            this.btnimagen.Size = new System.Drawing.Size(20, 20);
            this.btnimagen.TabIndex = 92;
            this.btnimagen.UseVisualStyleBackColor = true;
            this.btnimagen.Click += new System.EventHandler(this.btnimagen_Click);
            // 
            // txtimagen
            // 
            this.txtimagen.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtimagen.Location = new System.Drawing.Point(150, 165);
            this.txtimagen.Name = "txtimagen";
            this.txtimagen.ReadOnly = true;
            this.txtimagen.Size = new System.Drawing.Size(293, 21);
            this.txtimagen.TabIndex = 92;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(-83, 166);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(36, 13);
            this.label9.TabIndex = 91;
            this.label9.Text = "Otros*";
            // 
            // btnBuscarImagenOtros
            // 
            this.btnBuscarImagenOtros.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarImagenOtros.Location = new System.Drawing.Point(-94, -106);
            this.btnBuscarImagenOtros.Name = "btnBuscarImagenOtros";
            this.btnBuscarImagenOtros.Size = new System.Drawing.Size(25, 23);
            this.btnBuscarImagenOtros.TabIndex = 93;
            this.btnBuscarImagenOtros.Text = "...";
            this.btnBuscarImagenOtros.UseVisualStyleBackColor = true;
            // 
            // btnexportar
            // 
            this.btnexportar.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnexportar.Image = ((System.Drawing.Image)(resources.GetObject("btnexportar.Image")));
            this.btnexportar.Location = new System.Drawing.Point(491, 137);
            this.btnexportar.Name = "btnexportar";
            this.btnexportar.Size = new System.Drawing.Size(82, 23);
            this.btnexportar.TabIndex = 26;
            this.btnexportar.Text = "Exp. Pdf";
            this.btnexportar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnexportar.UseVisualStyleBackColor = true;
            this.btnexportar.Click += new System.EventHandler(this.btnexportar_Click);
            // 
            // savefile
            // 
            this.savefile.DefaultExt = "pdf";
            this.savefile.Filter = "|*.pdf";
            // 
            // lklimagen
            // 
            this.lklimagen.AutoSize = true;
            this.lklimagen.Location = new System.Drawing.Point(493, 181);
            this.lklimagen.Name = "lklimagen";
            this.lklimagen.Size = new System.Drawing.Size(61, 13);
            this.lklimagen.TabIndex = 93;
            this.lklimagen.TabStop = true;
            this.lklimagen.Text = "Ver Imagen";
            this.lklimagen.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lklimagen_LinkClicked);
            // 
            // pbimagen
            // 
            this.pbimagen.Location = new System.Drawing.Point(493, 84);
            this.pbimagen.Name = "pbimagen";
            this.pbimagen.Size = new System.Drawing.Size(72, 47);
            this.pbimagen.TabIndex = 94;
            this.pbimagen.TabStop = false;
            this.pbimagen.Visible = false;
            // 
            // frmEmpleadoRequerimiento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(577, 236);
            this.Controls.Add(this.pbimagen);
            this.Controls.Add(this.lklimagen);
            this.Controls.Add(this.btnexportar);
            this.Controls.Add(this.btncancelar);
            this.Controls.Add(this.btnaceptar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.pnlconten);
            this.MaximumSize = new System.Drawing.Size(593, 275);
            this.MinimumSize = new System.Drawing.Size(593, 275);
            this.Name = "frmEmpleadoRequerimiento";
            this.Nombre = "  Empleado Requerimiento";
            this.Text = "  Empleado Requerimiento";
            this.Load += new System.EventHandler(this.frmEmpleadoRequerimiento_Load);
            this.pnlconten.ResumeLayout(false);
            this.pnlconten.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbimagen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboCelular;
        private System.Windows.Forms.ComboBox cboMaquina;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtObservacionesOtros;
        private System.Windows.Forms.TextBox txtObservacionesCorreo;
        private System.Windows.Forms.TextBox txtObservacionesMaquina;
        private System.Windows.Forms.TextBox txtObservacionesCelular;
        private System.Windows.Forms.ComboBox cboOtros;
        private System.Windows.Forms.ComboBox cboCorreo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btncancelar;
        private System.Windows.Forms.Button btnaceptar;
        private System.Windows.Forms.Panel pnlconten;
        private System.Windows.Forms.Button btnexportar;
        private System.Windows.Forms.SaveFileDialog savefile;
        private System.Windows.Forms.TextBox txtimagen;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnBuscarImagenOtros;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnimagen;
        private System.Windows.Forms.LinkLabel lklimagen;
        private System.Windows.Forms.PictureBox pbimagen;
    }
}