namespace HPReserger
{
    partial class frmDatosExterno
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDatosExterno));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtempresa = new System.Windows.Forms.TextBox();
            this.cboCertificados = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.numrenta = new HpResergerUserControls.NumBox();
            this.txtnombreimagen = new System.Windows.Forms.TextBox();
            this.numimporte = new HpResergerUserControls.NumBox();
            this.label8 = new System.Windows.Forms.Label();
            this.comboMesAño1 = new HpResergerUserControls.ComboMesAño();
            this.label7 = new System.Windows.Forms.Label();
            this.pbimagen = new System.Windows.Forms.PictureBox();
            this.lklimagen = new System.Windows.Forms.LinkLabel();
            this.btnimagen = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btncancelar = new System.Windows.Forms.Button();
            this.btnaceptar = new System.Windows.Forms.Button();
            this.txtruc = new HPReserger.TextboxSoloNumeros();
            this.btnnuevo = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbimagen)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(55, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ruc:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(102, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(170, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "Datos de la Empresa";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(30, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Empresa:";
            // 
            // txtempresa
            // 
            this.txtempresa.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtempresa.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtempresa.Location = new System.Drawing.Point(94, 66);
            this.txtempresa.MaxLength = 100;
            this.txtempresa.Name = "txtempresa";
            this.txtempresa.Size = new System.Drawing.Size(273, 21);
            this.txtempresa.TabIndex = 2;
            this.txtempresa.Text = "-INGRESE NOMBRE DE LA EMPRESA-";
            this.txtempresa.Click += new System.EventHandler(this.txtempresa_Click);
            this.txtempresa.Leave += new System.EventHandler(this.txtempresa_Leave);
            // 
            // cboCertificados
            // 
            this.cboCertificados.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCertificados.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboCertificados.FormattingEnabled = true;
            this.cboCertificados.Location = new System.Drawing.Point(94, 89);
            this.cboCertificados.Name = "cboCertificados";
            this.cboCertificados.Size = new System.Drawing.Size(273, 24);
            this.cboCertificados.TabIndex = 3;
            this.cboCertificados.SelectedIndexChanged += new System.EventHandler(this.cboCertificados_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(35, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Trabajo:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.numrenta);
            this.panel1.Controls.Add(this.txtnombreimagen);
            this.panel1.Controls.Add(this.numimporte);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.comboMesAño1);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.pbimagen);
            this.panel1.Controls.Add(this.lklimagen);
            this.panel1.Controls.Add(this.btnimagen);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(8, 115);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(359, 94);
            this.panel1.TabIndex = 7;
            // 
            // numrenta
            // 
            this.numrenta.Location = new System.Drawing.Point(252, 5);
            this.numrenta.Margin = new System.Windows.Forms.Padding(3, 7, 3, 7);
            this.numrenta.Name = "numrenta";
            this.numrenta.NextControlOnEnter = null;
            this.numrenta.Size = new System.Drawing.Size(96, 27);
            this.numrenta.TabIndex = 5;
            // 
            // txtnombreimagen
            // 
            this.txtnombreimagen.Enabled = false;
            this.txtnombreimagen.Location = new System.Drawing.Point(86, 28);
            this.txtnombreimagen.Name = "txtnombreimagen";
            this.txtnombreimagen.Size = new System.Drawing.Size(137, 21);
            this.txtnombreimagen.TabIndex = 6;
            // 
            // numimporte
            // 
            this.numimporte.Location = new System.Drawing.Point(86, 5);
            this.numimporte.Margin = new System.Windows.Forms.Padding(3, 7, 3, 7);
            this.numimporte.Name = "numimporte";
            this.numimporte.NextControlOnEnter = null;
            this.numimporte.Size = new System.Drawing.Size(96, 27);
            this.numimporte.TabIndex = 4;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(190, 10);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 16);
            this.label8.TabIndex = 67;
            this.label8.Text = "Renta 5ta:";
            // 
            // comboMesAño1
            // 
            this.comboMesAño1.AutoSize = true;
            this.comboMesAño1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.comboMesAño1.FechaConDiaActual = new System.DateTime(2018, 3, 15, 0, 0, 0, 0);
            this.comboMesAño1.FechaFinMes = new System.DateTime(2018, 3, 31, 0, 0, 0, 0);
            this.comboMesAño1.FechaInicioMes = new System.DateTime(2018, 3, 1, 0, 0, 0, 0);
            this.comboMesAño1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboMesAño1.Location = new System.Drawing.Point(89, 54);
            this.comboMesAño1.Margin = new System.Windows.Forms.Padding(3, 28, 3, 28);
            this.comboMesAño1.Name = "comboMesAño1";
            this.comboMesAño1.Size = new System.Drawing.Size(229, 28);
            this.comboMesAño1.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(5, 60);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 16);
            this.label7.TabIndex = 65;
            this.label7.Text = "Fecha Cert.:";
            // 
            // pbimagen
            // 
            this.pbimagen.Location = new System.Drawing.Point(328, 61);
            this.pbimagen.Name = "pbimagen";
            this.pbimagen.Size = new System.Drawing.Size(27, 14);
            this.pbimagen.TabIndex = 64;
            this.pbimagen.TabStop = false;
            this.pbimagen.Visible = false;
            // 
            // lklimagen
            // 
            this.lklimagen.AutoSize = true;
            this.lklimagen.Location = new System.Drawing.Point(259, 30);
            this.lklimagen.Name = "lklimagen";
            this.lklimagen.Size = new System.Drawing.Size(70, 16);
            this.lklimagen.TabIndex = 8;
            this.lklimagen.TabStop = true;
            this.lklimagen.Text = "Ver Imagen";
            this.lklimagen.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lklimagen_LinkClicked);
            // 
            // btnimagen
            // 
            this.btnimagen.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnimagen.BackgroundImage")));
            this.btnimagen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnimagen.FlatAppearance.BorderSize = 0;
            this.btnimagen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnimagen.Location = new System.Drawing.Point(229, 28);
            this.btnimagen.Name = "btnimagen";
            this.btnimagen.Size = new System.Drawing.Size(20, 20);
            this.btnimagen.TabIndex = 7;
            this.btnimagen.UseVisualStyleBackColor = true;
            this.btnimagen.Click += new System.EventHandler(this.btnimagen_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(5, 30);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 16);
            this.label6.TabIndex = 60;
            this.label6.Text = "Imagen Cert.:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 16);
            this.label5.TabIndex = 59;
            this.label5.Text = "Renta Bruta:";
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(292, 37);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(75, 23);
            this.btnModificar.TabIndex = 0;
            this.btnModificar.Text = "&Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btncancelar
            // 
            this.btncancelar.Location = new System.Drawing.Point(292, 210);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(75, 23);
            this.btncancelar.TabIndex = 11;
            this.btncancelar.Text = "&Cancelar";
            this.btncancelar.UseVisualStyleBackColor = true;
            this.btncancelar.Click += new System.EventHandler(this.btncancelar_Click);
            // 
            // btnaceptar
            // 
            this.btnaceptar.Location = new System.Drawing.Point(211, 210);
            this.btnaceptar.Name = "btnaceptar";
            this.btnaceptar.Size = new System.Drawing.Size(75, 23);
            this.btnaceptar.TabIndex = 10;
            this.btnaceptar.Text = "&Aceptar";
            this.btnaceptar.UseVisualStyleBackColor = true;
            this.btnaceptar.Click += new System.EventHandler(this.btnaceptar_Click);
            // 
            // txtruc
            // 
            this.txtruc.AutoSize = true;
            this.txtruc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtruc.FuenteDelTxt = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtruc.Location = new System.Drawing.Point(94, 37);
            this.txtruc.MaxLengthTxt = 11;
            this.txtruc.Name = "txtruc";
            this.txtruc.Size = new System.Drawing.Size(134, 23);
            this.txtruc.TabIndex = 1;
            // 
            // btnnuevo
            // 
            this.btnnuevo.Location = new System.Drawing.Point(292, 11);
            this.btnnuevo.Name = "btnnuevo";
            this.btnnuevo.Size = new System.Drawing.Size(75, 23);
            this.btnnuevo.TabIndex = 9;
            this.btnnuevo.Text = "&Nuevo";
            this.btnnuevo.UseVisualStyleBackColor = true;
            this.btnnuevo.Click += new System.EventHandler(this.btnnuevo_Click);
            // 
            // frmDatosExterno
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(375, 238);
            this.Controls.Add(this.btnnuevo);
            this.Controls.Add(this.btncancelar);
            this.Controls.Add(this.btnaceptar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cboCertificados);
            this.Controls.Add(this.txtempresa);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtruc);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximumSize = new System.Drawing.Size(391, 277);
            this.MinimumSize = new System.Drawing.Size(391, 277);
            this.Name = "frmDatosExterno";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Datos Externo";
            this.Load += new System.EventHandler(this.frmDatosExterno_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbimagen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private TextboxSoloNumeros txtruc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtempresa;
        private System.Windows.Forms.ComboBox cboCertificados;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btncancelar;
        private System.Windows.Forms.Button btnaceptar;
        private System.Windows.Forms.LinkLabel lklimagen;
        private System.Windows.Forms.Button btnimagen;
        private System.Windows.Forms.TextBox txtnombreimagen;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private HpResergerUserControls. NumBox numimporte;
        private System.Windows.Forms.PictureBox pbimagen;
        private HpResergerUserControls. ComboMesAño comboMesAño1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnnuevo;
        private HpResergerUserControls.NumBox numrenta;
        private System.Windows.Forms.Label label8;
    }
}