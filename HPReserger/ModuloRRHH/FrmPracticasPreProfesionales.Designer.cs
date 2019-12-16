namespace HPReserger
{
    partial class FrmPracticasPreProfesionales
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPracticasPreProfesionales));
            this.txtrazonsocialuni = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtrucuni = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtdireccionuni = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtrepre = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtsituacionprac = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtespecialidadprac = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtocupacionmateriaprac = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtdiasprac = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtnrodocrepre = new System.Windows.Forms.TextBox();
            this.gp1 = new System.Windows.Forms.GroupBox();
            this.lsbrazon = new System.Windows.Forms.ListBox();
            this.lsbruc = new System.Windows.Forms.ListBox();
            this.cbotipoid = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txthorarioprac = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.msgtIP = new System.Windows.Forms.ToolTip(this.components);
            this.btncancelar = new System.Windows.Forms.Button();
            this.btnaceptar = new System.Windows.Forms.Button();
            this.gp1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtrazonsocialuni
            // 
            this.txtrazonsocialuni.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtrazonsocialuni.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtrazonsocialuni.Location = new System.Drawing.Point(92, 45);
            this.txtrazonsocialuni.Name = "txtrazonsocialuni";
            this.txtrazonsocialuni.Size = new System.Drawing.Size(306, 21);
            this.txtrazonsocialuni.TabIndex = 1;
            this.msgtIP.SetToolTip(this.txtrazonsocialuni, "UNI");
            this.txtrazonsocialuni.Click += new System.EventHandler(this.txtrazonsocialuni_Click);
            this.txtrazonsocialuni.TextChanged += new System.EventHandler(this.txtrazonsocialuni_TextChanged);
            this.txtrazonsocialuni.Enter += new System.EventHandler(this.txtrazonsocialuni_Enter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Razón Social:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "RUC:";
            // 
            // txtrucuni
            // 
            this.txtrucuni.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtrucuni.Location = new System.Drawing.Point(92, 19);
            this.txtrucuni.MaxLength = 10;
            this.txtrucuni.Name = "txtrucuni";
            this.txtrucuni.Size = new System.Drawing.Size(140, 21);
            this.txtrucuni.TabIndex = 0;
            this.msgtIP.SetToolTip(this.txtrucuni, "0701046971");
            this.txtrucuni.Click += new System.EventHandler(this.txtrucuni_Click);
            this.txtrucuni.TextChanged += new System.EventHandler(this.txtrucuni_TextChanged);
            this.txtrucuni.Enter += new System.EventHandler(this.txtrucuni_Enter);
            this.txtrucuni.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtrucuni_KeyDown);
            this.txtrucuni.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtrucuni_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Dirección:";
            // 
            // txtdireccionuni
            // 
            this.txtdireccionuni.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdireccionuni.Location = new System.Drawing.Point(92, 70);
            this.txtdireccionuni.Name = "txtdireccionuni";
            this.txtdireccionuni.Size = new System.Drawing.Size(306, 21);
            this.txtdireccionuni.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Representante:";
            // 
            // txtrepre
            // 
            this.txtrepre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtrepre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtrepre.Location = new System.Drawing.Point(92, 122);
            this.txtrepre.Name = "txtrepre";
            this.txtrepre.Size = new System.Drawing.Size(306, 21);
            this.txtrepre.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 101);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(123, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Tipo Id Representante:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(136, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Situación del Practicante:";
            // 
            // txtsituacionprac
            // 
            this.txtsituacionprac.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsituacionprac.Location = new System.Drawing.Point(143, 19);
            this.txtsituacionprac.Name = "txtsituacionprac";
            this.txtsituacionprac.Size = new System.Drawing.Size(337, 21);
            this.txtsituacionprac.TabIndex = 6;
            this.msgtIP.SetToolTip(this.txtsituacionprac, "Estudiante del 9° ciclo de la carrera de Diseño Grafico");
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 49);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Especialidad:";
            // 
            // txtespecialidadprac
            // 
            this.txtespecialidadprac.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtespecialidadprac.Location = new System.Drawing.Point(143, 45);
            this.txtespecialidadprac.Name = "txtespecialidadprac";
            this.txtespecialidadprac.Size = new System.Drawing.Size(337, 21);
            this.txtespecialidadprac.TabIndex = 7;
            this.msgtIP.SetToolTip(this.txtespecialidadprac, "Diseño corporativo, Publicidad, Papelería");
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 74);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(193, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Ocupación Materia de Capacitación:";
            // 
            // txtocupacionmateriaprac
            // 
            this.txtocupacionmateriaprac.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtocupacionmateriaprac.Location = new System.Drawing.Point(192, 70);
            this.txtocupacionmateriaprac.Name = "txtocupacionmateriaprac";
            this.txtocupacionmateriaprac.Size = new System.Drawing.Size(288, 21);
            this.txtocupacionmateriaprac.TabIndex = 8;
            this.txtocupacionmateriaprac.Tag = "";
            this.msgtIP.SetToolTip(this.txtocupacionmateriaprac, "Practicante Pre-profesional en el área de Diseño");
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 100);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(112, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "Dias de las Practicas:";
            // 
            // txtdiasprac
            // 
            this.txtdiasprac.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdiasprac.Location = new System.Drawing.Point(143, 96);
            this.txtdiasprac.Name = "txtdiasprac";
            this.txtdiasprac.Size = new System.Drawing.Size(337, 21);
            this.txtdiasprac.TabIndex = 9;
            this.msgtIP.SetToolTip(this.txtdiasprac, "De lunes a viernes");
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(234, 101);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(86, 13);
            this.label10.TabIndex = 19;
            this.label10.Text = "Nº Documento:";
            // 
            // txtnrodocrepre
            // 
            this.txtnrodocrepre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnrodocrepre.Location = new System.Drawing.Point(320, 97);
            this.txtnrodocrepre.MaxLength = 10;
            this.txtnrodocrepre.Name = "txtnrodocrepre";
            this.txtnrodocrepre.Size = new System.Drawing.Size(78, 21);
            this.txtnrodocrepre.TabIndex = 4;
            this.txtnrodocrepre.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtnrodocrepre_KeyDown);
            this.txtnrodocrepre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtnrodocrepre_KeyPress);
            // 
            // gp1
            // 
            this.gp1.BackColor = System.Drawing.Color.Transparent;
            this.gp1.Controls.Add(this.lsbrazon);
            this.gp1.Controls.Add(this.lsbruc);
            this.gp1.Controls.Add(this.cbotipoid);
            this.gp1.Controls.Add(this.txtrucuni);
            this.gp1.Controls.Add(this.txtrazonsocialuni);
            this.gp1.Controls.Add(this.txtnrodocrepre);
            this.gp1.Controls.Add(this.txtdireccionuni);
            this.gp1.Controls.Add(this.txtrepre);
            this.gp1.Controls.Add(this.label2);
            this.gp1.Controls.Add(this.label5);
            this.gp1.Controls.Add(this.label10);
            this.gp1.Controls.Add(this.label1);
            this.gp1.Controls.Add(this.label3);
            this.gp1.Controls.Add(this.label4);
            this.gp1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gp1.Location = new System.Drawing.Point(12, 12);
            this.gp1.Name = "gp1";
            this.gp1.Size = new System.Drawing.Size(404, 151);
            this.gp1.TabIndex = 20;
            this.gp1.TabStop = false;
            this.gp1.Text = "Centro de Formación Profesional:";
            this.gp1.MouseHover += new System.EventHandler(this.gp1_MouseHover);
            // 
            // lsbrazon
            // 
            this.lsbrazon.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lsbrazon.FormattingEnabled = true;
            this.lsbrazon.ItemHeight = 15;
            this.lsbrazon.Location = new System.Drawing.Point(92, 61);
            this.lsbrazon.Name = "lsbrazon";
            this.lsbrazon.Size = new System.Drawing.Size(306, 4);
            this.lsbrazon.TabIndex = 21;
            this.lsbrazon.Visible = false;
            this.lsbrazon.Click += new System.EventHandler(this.lsbrazon_Click);
            this.lsbrazon.MouseLeave += new System.EventHandler(this.lsbrazon_MouseLeave);
            // 
            // lsbruc
            // 
            this.lsbruc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lsbruc.FormattingEnabled = true;
            this.lsbruc.ItemHeight = 15;
            this.lsbruc.Location = new System.Drawing.Point(92, 38);
            this.lsbruc.Name = "lsbruc";
            this.lsbruc.Size = new System.Drawing.Size(140, 4);
            this.lsbruc.TabIndex = 20;
            this.lsbruc.Visible = false;
            this.lsbruc.Click += new System.EventHandler(this.lsbruc_Click);
            this.lsbruc.MouseLeave += new System.EventHandler(this.lsbruc_MouseLeave);
            // 
            // cbotipoid
            // 
            this.cbotipoid.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbotipoid.FormattingEnabled = true;
            this.cbotipoid.Location = new System.Drawing.Point(128, 97);
            this.cbotipoid.Name = "cbotipoid";
            this.cbotipoid.Size = new System.Drawing.Size(100, 23);
            this.cbotipoid.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.txthorarioprac);
            this.groupBox1.Controls.Add(this.txtsituacionprac);
            this.groupBox1.Controls.Add(this.txtespecialidadprac);
            this.groupBox1.Controls.Add(this.txtdiasprac);
            this.groupBox1.Controls.Add(this.txtocupacionmateriaprac);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(422, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(505, 151);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "El Practicante:";
            // 
            // txthorarioprac
            // 
            this.txthorarioprac.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txthorarioprac.Location = new System.Drawing.Point(143, 122);
            this.txthorarioprac.Name = "txthorarioprac";
            this.txthorarioprac.Size = new System.Drawing.Size(337, 21);
            this.txthorarioprac.TabIndex = 10;
            this.msgtIP.SetToolTip(this.txthorarioprac, "De lunes a viernes de 9:00 am a 16:00 pm, con una hora de refrigerio, desde las 1" +
        "3:00 pm hasta las 14:00 pm");
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 126);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(129, 13);
            this.label11.TabIndex = 19;
            this.label11.Text = "Horario de las Practicas:";
            // 
            // msgtIP
            // 
            this.msgtIP.AutoPopDelay = 10000;
            this.msgtIP.InitialDelay = 500;
            this.msgtIP.IsBalloon = true;
            this.msgtIP.ReshowDelay = 100;
            this.msgtIP.ShowAlways = true;
            // 
            // btncancelar
            // 
            this.btncancelar.Image = ((System.Drawing.Image)(resources.GetObject("btncancelar.Image")));
            this.btncancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btncancelar.Location = new System.Drawing.Point(852, 169);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(75, 24);
            this.btncancelar.TabIndex = 12;
            this.btncancelar.Text = "Cancelar";
            this.btncancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btncancelar.UseVisualStyleBackColor = true;
            this.btncancelar.Click += new System.EventHandler(this.btncancelar_Click);
            // 
            // btnaceptar
            // 
            this.btnaceptar.Image = ((System.Drawing.Image)(resources.GetObject("btnaceptar.Image")));
            this.btnaceptar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnaceptar.Location = new System.Drawing.Point(770, 169);
            this.btnaceptar.Name = "btnaceptar";
            this.btnaceptar.Size = new System.Drawing.Size(75, 24);
            this.btnaceptar.TabIndex = 11;
            this.btnaceptar.Text = "Aceptar";
            this.btnaceptar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnaceptar.UseVisualStyleBackColor = true;
            this.btnaceptar.Click += new System.EventHandler(this.btnaceptar_Click);
            // 
            // FrmPracticasPreProfesionales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(943, 204);
            this.Controls.Add(this.btncancelar);
            this.Controls.Add(this.btnaceptar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gp1);
            this.MaximumSize = new System.Drawing.Size(959, 243);
            this.MinimumSize = new System.Drawing.Size(959, 243);
            this.Name = "FrmPracticasPreProfesionales";
            this.Nombre = "Practicas Pre Profesionales";
            this.Text = "Practicas Pre Profesionales";
            this.Load += new System.EventHandler(this.FrmPracticasPreProfesionales_Load);
            this.gp1.ResumeLayout(false);
            this.gp1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtrazonsocialuni;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtrucuni;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtdireccionuni;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtrepre;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtsituacionprac;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtespecialidadprac;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtocupacionmateriaprac;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtdiasprac;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtnrodocrepre;
        private System.Windows.Forms.GroupBox gp1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ToolTip msgtIP;
        private System.Windows.Forms.Button btncancelar;
        private System.Windows.Forms.Button btnaceptar;
        private System.Windows.Forms.ComboBox cbotipoid;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txthorarioprac;
        private System.Windows.Forms.ListBox lsbruc;
        private System.Windows.Forms.ListBox lsbrazon;
    }
}