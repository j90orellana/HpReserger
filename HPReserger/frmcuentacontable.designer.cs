﻿namespace HPReserger
{
    partial class frmcuentacontable
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label2 = new System.Windows.Forms.Label();
            this.txtcodcuenta = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtcuentacierre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbotipo = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbonaturaleza = new System.Windows.Forms.ComboBox();
            this.cbogenerica = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbogrupo = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cborefleja = new System.Windows.Forms.ComboBox();
            this.cboreflejacc = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cboreflejadebe = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.cboreflejahaber = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.cboanalitica = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.cboajustemensual = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.cbocierre = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.cboajustetraslacion = new System.Windows.Forms.ComboBox();
            this.label17 = new System.Windows.Forms.Label();
            this.cbocuentabc = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.txtnombrecuenta = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.btneliminar = new System.Windows.Forms.Button();
            this.btnmodificar = new System.Windows.Forms.Button();
            this.btnnuevo = new System.Windows.Forms.Button();
            this.lblmsg = new System.Windows.Forms.Label();
            this.tipmsg = new System.Windows.Forms.ToolTip(this.components);
            this.btncancelar = new System.Windows.Forms.Button();
            this.btnaceptar = new System.Windows.Forms.Button();
            this.txtcuentan1 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.dtgconten = new System.Windows.Forms.DataGridView();
            this.btnlimpiar = new System.Windows.Forms.Button();
            this.label22 = new System.Windows.Forms.Label();
            this.Txtbusca = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgconten)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 13);
            this.label2.TabIndex = 94;
            this.label2.Text = "Cuenta Contable N1:";
            // 
            // txtcodcuenta
            // 
            this.txtcodcuenta.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtcodcuenta.Location = new System.Drawing.Point(458, 12);
            this.txtcodcuenta.MaxLength = 15;
            this.txtcodcuenta.Name = "txtcodcuenta";
            this.txtcodcuenta.Size = new System.Drawing.Size(172, 20);
            this.txtcodcuenta.TabIndex = 2;
            this.txtcodcuenta.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtcodcuenta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtcodcuenta_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(372, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 96;
            this.label1.Text = "Código Cuenta:";
            // 
            // txtcuentacierre
            // 
            this.txtcuentacierre.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtcuentacierre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtcuentacierre.Location = new System.Drawing.Point(106, 199);
            this.txtcuentacierre.Name = "txtcuentacierre";
            this.txtcuentacierre.Size = new System.Drawing.Size(511, 20);
            this.txtcuentacierre.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 202);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 98;
            this.label3.Text = "Cuenta Cierre:";
            // 
            // cbotipo
            // 
            this.cbotipo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbotipo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbotipo.FormattingEnabled = true;
            this.cbotipo.Location = new System.Drawing.Point(106, 64);
            this.cbotipo.Name = "cbotipo";
            this.cbotipo.Size = new System.Drawing.Size(291, 21);
            this.cbotipo.TabIndex = 4;
            this.cbotipo.TextChanged += new System.EventHandler(this.cbotipo_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 13);
            this.label4.TabIndex = 94;
            this.label4.Text = "Tipo Cuenta:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(403, 67);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 13);
            this.label5.TabIndex = 100;
            this.label5.Text = "Naturaleza Cuenta:";
            // 
            // cbonaturaleza
            // 
            this.cbonaturaleza.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbonaturaleza.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbonaturaleza.FormattingEnabled = true;
            this.cbonaturaleza.Location = new System.Drawing.Point(507, 64);
            this.cbonaturaleza.Name = "cbonaturaleza";
            this.cbonaturaleza.Size = new System.Drawing.Size(123, 21);
            this.cbonaturaleza.TabIndex = 5;
            // 
            // cbogenerica
            // 
            this.cbogenerica.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbogenerica.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbogenerica.FormattingEnabled = true;
            this.cbogenerica.Location = new System.Drawing.Point(105, 91);
            this.cbogenerica.Name = "cbogenerica";
            this.cbogenerica.Size = new System.Drawing.Size(305, 21);
            this.cbogenerica.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 94);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 13);
            this.label6.TabIndex = 94;
            this.label6.Text = "Cuenta Genérica";
            // 
            // cbogrupo
            // 
            this.cbogrupo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbogrupo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbogrupo.FormattingEnabled = true;
            this.cbogrupo.Location = new System.Drawing.Point(458, 91);
            this.cbogrupo.Name = "cbogrupo";
            this.cbogrupo.Size = new System.Drawing.Size(172, 21);
            this.cbogrupo.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(416, 94);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 13);
            this.label7.TabIndex = 100;
            this.label7.Text = "Grupo";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(205, 121);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 13);
            this.label8.TabIndex = 100;
            this.label8.Text = "¿Refleja?";
            // 
            // cborefleja
            // 
            this.cborefleja.FormattingEnabled = true;
            this.cborefleja.Location = new System.Drawing.Point(263, 118);
            this.cborefleja.Name = "cborefleja";
            this.cborefleja.Size = new System.Drawing.Size(38, 21);
            this.cborefleja.TabIndex = 99;
            // 
            // cboreflejacc
            // 
            this.cboreflejacc.FormattingEnabled = true;
            this.cboreflejacc.Location = new System.Drawing.Point(123, 118);
            this.cboreflejacc.Name = "cboreflejacc";
            this.cboreflejacc.Size = new System.Drawing.Size(76, 21);
            this.cboreflejacc.TabIndex = 8;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(12, 121);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(104, 13);
            this.label10.TabIndex = 100;
            this.label10.Text = "Refleja Depende CC";
            // 
            // cboreflejadebe
            // 
            this.cboreflejadebe.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboreflejadebe.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboreflejadebe.FormattingEnabled = true;
            this.cboreflejadebe.Location = new System.Drawing.Point(106, 145);
            this.cboreflejadebe.Name = "cboreflejadebe";
            this.cboreflejadebe.Size = new System.Drawing.Size(511, 21);
            this.cboreflejadebe.TabIndex = 9;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(12, 148);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(69, 13);
            this.label11.TabIndex = 94;
            this.label11.Text = "Releja Debe:";
            // 
            // cboreflejahaber
            // 
            this.cboreflejahaber.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboreflejahaber.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboreflejahaber.FormattingEnabled = true;
            this.cboreflejahaber.Location = new System.Drawing.Point(106, 172);
            this.cboreflejahaber.Name = "cboreflejahaber";
            this.cboreflejahaber.Size = new System.Drawing.Size(511, 21);
            this.cboreflejahaber.TabIndex = 10;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(12, 175);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(72, 13);
            this.label12.TabIndex = 94;
            this.label12.Text = "Releja Haber:";
            // 
            // cboanalitica
            // 
            this.cboanalitica.FormattingEnabled = true;
            this.cboanalitica.Location = new System.Drawing.Point(78, 225);
            this.cboanalitica.Name = "cboanalitica";
            this.cboanalitica.Size = new System.Drawing.Size(76, 21);
            this.cboanalitica.TabIndex = 12;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(14, 228);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(59, 13);
            this.label13.TabIndex = 100;
            this.label13.Text = "¿Analitica?";
            // 
            // cboajustemensual
            // 
            this.cboajustemensual.FormattingEnabled = true;
            this.cboajustemensual.Location = new System.Drawing.Point(334, 225);
            this.cboajustemensual.Name = "cboajustemensual";
            this.cboajustemensual.Size = new System.Drawing.Size(185, 21);
            this.cboajustemensual.TabIndex = 13;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(160, 228);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(168, 13);
            this.label14.TabIndex = 100;
            this.label14.Text = "Ajuste Diferencia Cambio Mensual";
            // 
            // cbocierre
            // 
            this.cbocierre.FormattingEnabled = true;
            this.cbocierre.Location = new System.Drawing.Point(610, 225);
            this.cbocierre.Name = "cbocierre";
            this.cbocierre.Size = new System.Drawing.Size(122, 21);
            this.cbocierre.TabIndex = 14;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(567, 228);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(37, 13);
            this.label15.TabIndex = 100;
            this.label15.Text = "Cierre:";
            // 
            // cboajustetraslacion
            // 
            this.cboajustetraslacion.FormattingEnabled = true;
            this.cboajustetraslacion.Location = new System.Drawing.Point(125, 252);
            this.cboajustetraslacion.Name = "cboajustetraslacion";
            this.cboajustetraslacion.Size = new System.Drawing.Size(208, 21);
            this.cboajustetraslacion.TabIndex = 15;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(12, 255);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(106, 13);
            this.label17.TabIndex = 100;
            this.label17.Text = "Ajuste por Traslación";
            // 
            // cbocuentabc
            // 
            this.cbocuentabc.FormattingEnabled = true;
            this.cbocuentabc.Location = new System.Drawing.Point(458, 252);
            this.cbocuentabc.Name = "cbocuentabc";
            this.cbocuentabc.Size = new System.Drawing.Size(61, 21);
            this.cbocuentabc.TabIndex = 16;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(339, 255);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(113, 13);
            this.label16.TabIndex = 100;
            this.label16.Text = "Cuenta Declarante BC";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(12, 41);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(148, 13);
            this.label18.TabIndex = 98;
            this.label18.Text = "Cuenta Contable Descripción:";
            // 
            // txtnombrecuenta
            // 
            this.txtnombrecuenta.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtnombrecuenta.Location = new System.Drawing.Point(163, 38);
            this.txtnombrecuenta.Name = "txtnombrecuenta";
            this.txtnombrecuenta.Size = new System.Drawing.Size(467, 20);
            this.txtnombrecuenta.TabIndex = 3;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(-56, 268);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(817, 13);
            this.label19.TabIndex = 110;
            this.label19.Text = "_________________________________________________________________________________" +
    "______________________________________________________";
            this.label19.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btneliminar
            // 
            this.btneliminar.Location = new System.Drawing.Point(650, 61);
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Size = new System.Drawing.Size(82, 21);
            this.btneliminar.TabIndex = 21;
            this.btneliminar.Text = "Eliminar";
            this.btneliminar.UseVisualStyleBackColor = true;
            // 
            // btnmodificar
            // 
            this.btnmodificar.Location = new System.Drawing.Point(650, 35);
            this.btnmodificar.Name = "btnmodificar";
            this.btnmodificar.Size = new System.Drawing.Size(82, 21);
            this.btnmodificar.TabIndex = 20;
            this.btnmodificar.Text = "Modificar";
            this.btnmodificar.UseVisualStyleBackColor = true;
            this.btnmodificar.Click += new System.EventHandler(this.btnmodificar_Click);
            // 
            // btnnuevo
            // 
            this.btnnuevo.Location = new System.Drawing.Point(650, 12);
            this.btnnuevo.Name = "btnnuevo";
            this.btnnuevo.Size = new System.Drawing.Size(82, 20);
            this.btnnuevo.TabIndex = 19;
            this.btnnuevo.Text = "Nuevo";
            this.btnnuevo.UseVisualStyleBackColor = true;
            this.btnnuevo.Click += new System.EventHandler(this.btnnuevo_Click);
            // 
            // lblmsg
            // 
            this.lblmsg.AutoSize = true;
            this.lblmsg.Location = new System.Drawing.Point(14, 620);
            this.lblmsg.Name = "lblmsg";
            this.lblmsg.Size = new System.Drawing.Size(96, 13);
            this.lblmsg.TabIndex = 129;
            this.lblmsg.Text = "Total de Registros:";
            // 
            // tipmsg
            // 
            this.tipmsg.IsBalloon = true;
            // 
            // btncancelar
            // 
            this.btncancelar.Location = new System.Drawing.Point(650, 603);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(82, 29);
            this.btncancelar.TabIndex = 23;
            this.btncancelar.Text = "Cancelar";
            this.btncancelar.UseVisualStyleBackColor = true;
            this.btncancelar.Click += new System.EventHandler(this.btncancelar_Click);
            // 
            // btnaceptar
            // 
            this.btnaceptar.Location = new System.Drawing.Point(552, 603);
            this.btnaceptar.Name = "btnaceptar";
            this.btnaceptar.Size = new System.Drawing.Size(82, 29);
            this.btnaceptar.TabIndex = 22;
            this.btnaceptar.Text = "Aceptar";
            this.btnaceptar.UseVisualStyleBackColor = true;
            this.btnaceptar.Click += new System.EventHandler(this.btnaceptar_Click);
            // 
            // txtcuentan1
            // 
            this.txtcuentan1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtcuentan1.Location = new System.Drawing.Point(119, 12);
            this.txtcuentan1.Name = "txtcuentan1";
            this.txtcuentan1.Size = new System.Drawing.Size(223, 20);
            this.txtcuentan1.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton4);
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Location = new System.Drawing.Point(15, 311);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(712, 28);
            this.groupBox1.TabIndex = 133;
            this.groupBox1.TabStop = false;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.radioButton4.Location = new System.Drawing.Point(110, 10);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(82, 18);
            this.radioButton4.TabIndex = 130;
            this.radioButton4.Text = "Cuenta N1";
            this.radioButton4.UseVisualStyleBackColor = true;
            this.radioButton4.CheckedChanged += new System.EventHandler(this.radioButton4_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.radioButton2.Location = new System.Drawing.Point(198, 10);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(110, 18);
            this.radioButton2.TabIndex = 130;
            this.radioButton2.Text = "Cuenta Contable";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.radioButton1.Location = new System.Drawing.Point(18, 10);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(101, 18);
            this.radioButton1.TabIndex = 130;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Código Cuenta";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // dtgconten
            // 
            this.dtgconten.AllowUserToAddRows = false;
            this.dtgconten.AllowUserToDeleteRows = false;
            this.dtgconten.AllowUserToResizeColumns = false;
            this.dtgconten.AllowUserToResizeRows = false;
            this.dtgconten.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dtgconten.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dtgconten.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dtgconten.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dtgconten.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgconten.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgconten.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgconten.Cursor = System.Windows.Forms.Cursors.Default;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgconten.DefaultCellStyle = dataGridViewCellStyle2;
            this.dtgconten.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dtgconten.Location = new System.Drawing.Point(17, 343);
            this.dtgconten.MultiSelect = false;
            this.dtgconten.Name = "dtgconten";
            this.dtgconten.ReadOnly = true;
            this.dtgconten.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgconten.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dtgconten.RowHeadersVisible = false;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtgconten.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dtgconten.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgconten.Size = new System.Drawing.Size(715, 254);
            this.dtgconten.TabIndex = 132;
            this.dtgconten.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgconten_RowEnter);
            // 
            // btnlimpiar
            // 
            this.btnlimpiar.Cursor = System.Windows.Forms.Cursors.Cross;
            this.btnlimpiar.Font = new System.Drawing.Font("Webdings", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(3)));
            this.btnlimpiar.Location = new System.Drawing.Point(93, 284);
            this.btnlimpiar.Name = "btnlimpiar";
            this.btnlimpiar.Size = new System.Drawing.Size(20, 21);
            this.btnlimpiar.TabIndex = 136;
            this.btnlimpiar.Text = "";
            this.btnlimpiar.UseVisualStyleBackColor = true;
            this.btnlimpiar.Click += new System.EventHandler(this.btnlimpiar_Click);
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(18, 292);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(51, 13);
            this.label22.TabIndex = 135;
            this.label22.Text = "BUSCAR";
            // 
            // Txtbusca
            // 
            this.Txtbusca.BackColor = System.Drawing.SystemColors.Info;
            this.Txtbusca.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.Txtbusca.Cursor = System.Windows.Forms.Cursors.Help;
            this.Txtbusca.Location = new System.Drawing.Point(119, 284);
            this.Txtbusca.Name = "Txtbusca";
            this.Txtbusca.Size = new System.Drawing.Size(529, 20);
            this.Txtbusca.TabIndex = 134;
            this.Txtbusca.TextChanged += new System.EventHandler(this.Txtbusca_TextChanged);
            // 
            // frmcuentacontable
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(747, 647);
            this.Controls.Add(this.btnlimpiar);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.Txtbusca);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dtgconten);
            this.Controls.Add(this.txtcuentan1);
            this.Controls.Add(this.lblmsg);
            this.Controls.Add(this.btncancelar);
            this.Controls.Add(this.btnaceptar);
            this.Controls.Add(this.btneliminar);
            this.Controls.Add(this.btnmodificar);
            this.Controls.Add(this.btnnuevo);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cboreflejacc);
            this.Controls.Add(this.cboajustetraslacion);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cboajustemensual);
            this.Controls.Add(this.cbocuentabc);
            this.Controls.Add(this.cboanalitica);
            this.Controls.Add(this.cbocierre);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cborefleja);
            this.Controls.Add(this.cbogrupo);
            this.Controls.Add(this.cbonaturaleza);
            this.Controls.Add(this.txtnombrecuenta);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.txtcuentacierre);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtcodcuenta);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbogenerica);
            this.Controls.Add(this.cbotipo);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.cboreflejahaber);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cboreflejadebe);
            this.Controls.Add(this.label19);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MinimizeBox = false;
            this.Name = "frmcuentacontable";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CUENTA CONTABLE";
            this.Load += new System.EventHandler(this.frmcuentacontable_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgconten)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtcuentacierre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbotipo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbonaturaleza;
        private System.Windows.Forms.ComboBox cbogenerica;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbogrupo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cborefleja;
        private System.Windows.Forms.ComboBox cboreflejacc;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cboreflejadebe;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cboreflejahaber;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cboanalitica;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox cboajustemensual;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox cbocierre;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox cboajustetraslacion;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.ComboBox cbocuentabc;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txtnombrecuenta;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Button btneliminar;
        private System.Windows.Forms.Button btnmodificar;
        private System.Windows.Forms.Label lblmsg;
        private System.Windows.Forms.ToolTip tipmsg;
        private System.Windows.Forms.Button btncancelar;
        private System.Windows.Forms.Button btnaceptar;
        private System.Windows.Forms.TextBox txtcuentan1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.DataGridView dtgconten;
        private System.Windows.Forms.Button btnlimpiar;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox Txtbusca;
        private System.Windows.Forms.Button btnnuevo;
        public System.Windows.Forms.TextBox txtcodcuenta;
    }
}