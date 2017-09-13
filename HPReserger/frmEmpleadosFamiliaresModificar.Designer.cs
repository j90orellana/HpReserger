namespace HPReserger
{
    partial class frmEmpleadosFamiliaresModificar
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
            this.btnModificar = new System.Windows.Forms.Button();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.txtOcupacion = new System.Windows.Forms.TextBox();
            this.txtApellidoPaterno = new System.Windows.Forms.TextBox();
            this.txtNombres = new System.Windows.Forms.TextBox();
            this.txtApellidoMaterno = new System.Windows.Forms.TextBox();
            this.txtNumeroDocumento = new System.Windows.Forms.TextBox();
            this.cboVinculoFamiliar = new System.Windows.Forms.ComboBox();
            this.cboTipoDocumentoIdentidad = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pbconviviente = new System.Windows.Forms.PictureBox();
            this.lklconviviente = new System.Windows.Forms.LinkLabel();
            this.btnconviviente = new System.Windows.Forms.Button();
            this.txtconviviente = new System.Windows.Forms.TextBox();
            this.lblconviviente = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbconviviente)).BeginInit();
            this.SuspendLayout();
            // 
            // btnModificar
            // 
            this.btnModificar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnModificar.Location = new System.Drawing.Point(432, 17);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(75, 23);
            this.btnModificar.TabIndex = 34;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // dtpFecha
            // 
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha.Location = new System.Drawing.Point(195, 99);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(231, 20);
            this.dtpFecha.TabIndex = 33;
            // 
            // txtOcupacion
            // 
            this.txtOcupacion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtOcupacion.Location = new System.Drawing.Point(195, 203);
            this.txtOcupacion.MaxLength = 30;
            this.txtOcupacion.Name = "txtOcupacion";
            this.txtOcupacion.Size = new System.Drawing.Size(311, 20);
            this.txtOcupacion.TabIndex = 32;
            // 
            // txtApellidoPaterno
            // 
            this.txtApellidoPaterno.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtApellidoPaterno.Location = new System.Drawing.Point(195, 125);
            this.txtApellidoPaterno.MaxLength = 30;
            this.txtApellidoPaterno.Name = "txtApellidoPaterno";
            this.txtApellidoPaterno.Size = new System.Drawing.Size(309, 20);
            this.txtApellidoPaterno.TabIndex = 31;
            // 
            // txtNombres
            // 
            this.txtNombres.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNombres.Location = new System.Drawing.Point(195, 177);
            this.txtNombres.MaxLength = 30;
            this.txtNombres.Name = "txtNombres";
            this.txtNombres.Size = new System.Drawing.Size(309, 20);
            this.txtNombres.TabIndex = 30;
            // 
            // txtApellidoMaterno
            // 
            this.txtApellidoMaterno.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtApellidoMaterno.Location = new System.Drawing.Point(195, 151);
            this.txtApellidoMaterno.MaxLength = 30;
            this.txtApellidoMaterno.Name = "txtApellidoMaterno";
            this.txtApellidoMaterno.Size = new System.Drawing.Size(309, 20);
            this.txtApellidoMaterno.TabIndex = 29;
            this.txtApellidoMaterno.TextChanged += new System.EventHandler(this.txtApellidoMaterno_TextChanged);
            // 
            // txtNumeroDocumento
            // 
            this.txtNumeroDocumento.Location = new System.Drawing.Point(195, 46);
            this.txtNumeroDocumento.MaxLength = 10;
            this.txtNumeroDocumento.Name = "txtNumeroDocumento";
            this.txtNumeroDocumento.Size = new System.Drawing.Size(231, 20);
            this.txtNumeroDocumento.TabIndex = 28;
            this.txtNumeroDocumento.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtNumeroDocumento.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtNumeroDocumento_KeyDown);
            this.txtNumeroDocumento.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumeroDocumento_KeyPress);
            // 
            // cboVinculoFamiliar
            // 
            this.cboVinculoFamiliar.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboVinculoFamiliar.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboVinculoFamiliar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboVinculoFamiliar.FormattingEnabled = true;
            this.cboVinculoFamiliar.Location = new System.Drawing.Point(195, 72);
            this.cboVinculoFamiliar.Name = "cboVinculoFamiliar";
            this.cboVinculoFamiliar.Size = new System.Drawing.Size(231, 21);
            this.cboVinculoFamiliar.TabIndex = 27;
            // 
            // cboTipoDocumentoIdentidad
            // 
            this.cboTipoDocumentoIdentidad.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboTipoDocumentoIdentidad.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboTipoDocumentoIdentidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTipoDocumentoIdentidad.FormattingEnabled = true;
            this.cboTipoDocumentoIdentidad.Location = new System.Drawing.Point(195, 19);
            this.cboTipoDocumentoIdentidad.Name = "cboTipoDocumentoIdentidad";
            this.cboTipoDocumentoIdentidad.Size = new System.Drawing.Size(231, 21);
            this.cboTipoDocumentoIdentidad.TabIndex = 26;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label8.Location = new System.Drawing.Point(10, 105);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(108, 13);
            this.label8.TabIndex = 25;
            this.label8.Text = "Fecha de Nacimiento";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label7.Location = new System.Drawing.Point(10, 206);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 13);
            this.label7.TabIndex = 24;
            this.label7.Text = "Ocupación";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label6.Location = new System.Drawing.Point(10, 180);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 23;
            this.label6.Text = "Nombres";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label5.Location = new System.Drawing.Point(10, 128);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 13);
            this.label5.TabIndex = 22;
            this.label5.Text = "Apellido Paterno";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label4.Location = new System.Drawing.Point(10, 154);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 13);
            this.label4.TabIndex = 21;
            this.label4.Text = "Apellido Materno";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label3.Location = new System.Drawing.Point(10, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "Vínculo familiar";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(10, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(179, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "Número de Documento de Identidad";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(10, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Tipo de Documento de Identidad";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pbconviviente);
            this.groupBox1.Controls.Add(this.lklconviviente);
            this.groupBox1.Controls.Add(this.btnconviviente);
            this.groupBox1.Controls.Add(this.txtconviviente);
            this.groupBox1.Controls.Add(this.lblconviviente);
            this.groupBox1.Controls.Add(this.cboVinculoFamiliar);
            this.groupBox1.Controls.Add(this.dtpFecha);
            this.groupBox1.Controls.Add(this.btnModificar);
            this.groupBox1.Controls.Add(this.txtOcupacion);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtApellidoPaterno);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtNombres);
            this.groupBox1.Controls.Add(this.txtApellidoMaterno);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cboTipoDocumentoIdentidad);
            this.groupBox1.Controls.Add(this.txtNumeroDocumento);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(10, 7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(522, 267);
            this.groupBox1.TabIndex = 35;
            this.groupBox1.TabStop = false;
            // 
            // pbconviviente
            // 
            this.pbconviviente.Location = new System.Drawing.Point(432, 46);
            this.pbconviviente.Name = "pbconviviente";
            this.pbconviviente.Size = new System.Drawing.Size(72, 72);
            this.pbconviviente.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbconviviente.TabIndex = 73;
            this.pbconviviente.TabStop = false;
            this.pbconviviente.Click += new System.EventHandler(this.pbconviviente_Click);
            // 
            // lklconviviente
            // 
            this.lklconviviente.AutoSize = true;
            this.lklconviviente.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lklconviviente.Location = new System.Drawing.Point(446, 232);
            this.lklconviviente.Name = "lklconviviente";
            this.lklconviviente.Size = new System.Drawing.Size(61, 13);
            this.lklconviviente.TabIndex = 72;
            this.lklconviviente.TabStop = true;
            this.lklconviviente.Text = "Ver Imagen";
            this.lklconviviente.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lklconviviente_LinkClicked);
            // 
            // btnconviviente
            // 
            this.btnconviviente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnconviviente.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnconviviente.Location = new System.Drawing.Point(415, 228);
            this.btnconviviente.Name = "btnconviviente";
            this.btnconviviente.Size = new System.Drawing.Size(25, 20);
            this.btnconviviente.TabIndex = 71;
            this.btnconviviente.Text = "...";
            this.btnconviviente.UseVisualStyleBackColor = true;
            this.btnconviviente.Click += new System.EventHandler(this.btnconviviente_Click);
            // 
            // txtconviviente
            // 
            this.txtconviviente.Location = new System.Drawing.Point(195, 229);
            this.txtconviviente.Name = "txtconviviente";
            this.txtconviviente.ReadOnly = true;
            this.txtconviviente.Size = new System.Drawing.Size(213, 20);
            this.txtconviviente.TabIndex = 70;
            // 
            // lblconviviente
            // 
            this.lblconviviente.AutoSize = true;
            this.lblconviviente.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblconviviente.Location = new System.Drawing.Point(10, 232);
            this.lblconviviente.Name = "lblconviviente";
            this.lblconviviente.Size = new System.Drawing.Size(45, 13);
            this.lblconviviente.TabIndex = 69;
            this.lblconviviente.Text = "Imagen:";
            // 
            // frmEmpleadosFamiliaresModificar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(550, 282);
            this.Controls.Add(this.groupBox1);
            this.MaximumSize = new System.Drawing.Size(566, 321);
            this.MinimumSize = new System.Drawing.Size(566, 321);
            this.Name = "frmEmpleadosFamiliaresModificar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "  Familiares Empleado Modificar";
            this.Load += new System.EventHandler(this.frmEmpleadosFamiliaresModificar_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbconviviente)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.TextBox txtOcupacion;
        private System.Windows.Forms.TextBox txtApellidoPaterno;
        private System.Windows.Forms.TextBox txtNombres;
        private System.Windows.Forms.TextBox txtApellidoMaterno;
        private System.Windows.Forms.TextBox txtNumeroDocumento;
        private System.Windows.Forms.ComboBox cboVinculoFamiliar;
        private System.Windows.Forms.ComboBox cboTipoDocumentoIdentidad;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnconviviente;
        private System.Windows.Forms.Label lblconviviente;
        public System.Windows.Forms.PictureBox pbconviviente;
        public System.Windows.Forms.TextBox txtconviviente;
        public System.Windows.Forms.LinkLabel lklconviviente;
    }
}