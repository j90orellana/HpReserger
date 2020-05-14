using HpResergerUserControls;

namespace HPReserger
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmcuentacontable));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
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
            this.btneliminar = new System.Windows.Forms.Button();
            this.btnmodificar = new System.Windows.Forms.Button();
            this.btnnuevo = new System.Windows.Forms.Button();
            this.lblmsg = new System.Windows.Forms.Label();
            this.tipmsg = new System.Windows.Forms.ToolTip(this.components);
            this.btncargarcuentas = new System.Windows.Forms.Button();
            this.btncancelar = new System.Windows.Forms.Button();
            this.btnaceptar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.dtgconten = new HpResergerUserControls.Dtgconten();
            this.OpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.label9 = new System.Windows.Forms.Label();
            this.cbosolicitar = new System.Windows.Forms.ComboBox();
            this.Txtbusca = new HpResergerUserControls.txtBuscar();
            this.chkcabecera = new System.Windows.Forms.CheckBox();
            this.txtnombrecuenta = new HpResergerUserControls.TextBoxPer();
            this.txtcodcuenta = new HpResergerUserControls.TextBoxPer();
            this.txtcuentan1 = new HpResergerUserControls.TextBoxPer();
            this.txtcuentacierre = new HpResergerUserControls.TextBoxPer();
            this.cboestado = new System.Windows.Forms.ComboBox();
            this.label19 = new System.Windows.Forms.Label();
            this.btnExportarPlan = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.btnExportarPLan2Col = new System.Windows.Forms.Button();
            this.chkInterEmpresa = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgconten)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 13);
            this.label2.TabIndex = 94;
            this.label2.Text = "Cuenta Contable N1:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(419, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 96;
            this.label1.Text = "Código Cuenta:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(44, 178);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 13);
            this.label3.TabIndex = 98;
            this.label3.Text = "Cuenta Cierre:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // cbotipo
            // 
            this.cbotipo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbotipo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbotipo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(218)))), ((int)(((byte)(231)))));
            this.cbotipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbotipo.FormattingEnabled = true;
            this.cbotipo.Location = new System.Drawing.Point(124, 58);
            this.cbotipo.Name = "cbotipo";
            this.cbotipo.Size = new System.Drawing.Size(273, 21);
            this.cbotipo.TabIndex = 13;
            this.cbotipo.TextChanged += new System.EventHandler(this.cbotipo_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(52, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 13);
            this.label4.TabIndex = 94;
            this.label4.Text = "Tipo Cuenta:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(402, 62);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 13);
            this.label5.TabIndex = 100;
            this.label5.Text = "Naturaleza Cuenta:";
            // 
            // cbonaturaleza
            // 
            this.cbonaturaleza.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbonaturaleza.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbonaturaleza.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(218)))), ((int)(((byte)(231)))));
            this.cbonaturaleza.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbonaturaleza.FormattingEnabled = true;
            this.cbonaturaleza.Location = new System.Drawing.Point(507, 58);
            this.cbonaturaleza.Name = "cbonaturaleza";
            this.cbonaturaleza.Size = new System.Drawing.Size(229, 21);
            this.cbonaturaleza.TabIndex = 14;
            // 
            // cbogenerica
            // 
            this.cbogenerica.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbogenerica.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbogenerica.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(218)))), ((int)(((byte)(231)))));
            this.cbogenerica.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbogenerica.FormattingEnabled = true;
            this.cbogenerica.Location = new System.Drawing.Point(124, 81);
            this.cbogenerica.Name = "cbogenerica";
            this.cbogenerica.Size = new System.Drawing.Size(273, 21);
            this.cbogenerica.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(29, 85);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 13);
            this.label6.TabIndex = 94;
            this.label6.Text = "Cuenta Genérica:";
            // 
            // cbogrupo
            // 
            this.cbogrupo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbogrupo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbogrupo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(218)))), ((int)(((byte)(231)))));
            this.cbogrupo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbogrupo.FormattingEnabled = true;
            this.cbogrupo.Location = new System.Drawing.Point(507, 81);
            this.cbogrupo.Name = "cbogrupo";
            this.cbogrupo.Size = new System.Drawing.Size(229, 21);
            this.cbogrupo.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(464, 85);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 13);
            this.label7.TabIndex = 100;
            this.label7.Text = "Grupo:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(223, 108);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 13);
            this.label8.TabIndex = 100;
            this.label8.Text = "¿Refleja?";
            // 
            // cborefleja
            // 
            this.cborefleja.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(218)))), ((int)(((byte)(231)))));
            this.cborefleja.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cborefleja.FormattingEnabled = true;
            this.cborefleja.Location = new System.Drawing.Point(275, 104);
            this.cborefleja.Name = "cborefleja";
            this.cborefleja.Size = new System.Drawing.Size(122, 21);
            this.cborefleja.TabIndex = 18;
            this.cborefleja.SelectedIndexChanged += new System.EventHandler(this.cborefleja_SelectedIndexChanged);
            // 
            // cboreflejacc
            // 
            this.cboreflejacc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(218)))), ((int)(((byte)(231)))));
            this.cboreflejacc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboreflejacc.FormattingEnabled = true;
            this.cboreflejacc.Location = new System.Drawing.Point(124, 104);
            this.cboreflejacc.Name = "cboreflejacc";
            this.cboreflejacc.Size = new System.Drawing.Size(99, 21);
            this.cboreflejacc.TabIndex = 17;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(12, 108);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(112, 13);
            this.label10.TabIndex = 100;
            this.label10.Text = "Refleja Depende CC:";
            // 
            // cboreflejadebe
            // 
            this.cboreflejadebe.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboreflejadebe.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboreflejadebe.FormattingEnabled = true;
            this.cboreflejadebe.Location = new System.Drawing.Point(124, 128);
            this.cboreflejadebe.Name = "cboreflejadebe";
            this.cboreflejadebe.Size = new System.Drawing.Size(612, 21);
            this.cboreflejadebe.TabIndex = 21;
            this.cboreflejadebe.Click += new System.EventHandler(this.cboreflejadebe_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(53, 132);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(71, 13);
            this.label11.TabIndex = 94;
            this.label11.Text = "Releja Debe:";
            // 
            // cboreflejahaber
            // 
            this.cboreflejahaber.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboreflejahaber.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboreflejahaber.FormattingEnabled = true;
            this.cboreflejahaber.Location = new System.Drawing.Point(124, 151);
            this.cboreflejahaber.Name = "cboreflejahaber";
            this.cboreflejahaber.Size = new System.Drawing.Size(612, 21);
            this.cboreflejahaber.TabIndex = 22;
            this.cboreflejahaber.Click += new System.EventHandler(this.cboreflejahaber_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(49, 154);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(75, 13);
            this.label12.TabIndex = 94;
            this.label12.Text = "Releja Haber:";
            // 
            // cboanalitica
            // 
            this.cboanalitica.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(218)))), ((int)(((byte)(231)))));
            this.cboanalitica.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboanalitica.FormattingEnabled = true;
            this.cboanalitica.Location = new System.Drawing.Point(124, 197);
            this.cboanalitica.Name = "cboanalitica";
            this.cboanalitica.Size = new System.Drawing.Size(76, 21);
            this.cboanalitica.TabIndex = 24;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(63, 201);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(61, 13);
            this.label13.TabIndex = 100;
            this.label13.Text = "¿Analitica?";
            // 
            // cboajustemensual
            // 
            this.cboajustemensual.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(218)))), ((int)(((byte)(231)))));
            this.cboajustemensual.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboajustemensual.FormattingEnabled = true;
            this.cboajustemensual.Location = new System.Drawing.Point(386, 197);
            this.cboajustemensual.Name = "cboajustemensual";
            this.cboajustemensual.Size = new System.Drawing.Size(161, 21);
            this.cboajustemensual.TabIndex = 25;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(200, 201);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(186, 13);
            this.label14.TabIndex = 100;
            this.label14.Text = "Ajuste Diferencia Cambio Mensual:";
            // 
            // cbocierre
            // 
            this.cbocierre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(218)))), ((int)(((byte)(231)))));
            this.cbocierre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbocierre.FormattingEnabled = true;
            this.cbocierre.Location = new System.Drawing.Point(598, 197);
            this.cbocierre.Name = "cbocierre";
            this.cbocierre.Size = new System.Drawing.Size(138, 21);
            this.cbocierre.TabIndex = 26;
            this.cbocierre.SelectedIndexChanged += new System.EventHandler(this.cbocierre_SelectedIndexChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(558, 201);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(40, 13);
            this.label15.TabIndex = 100;
            this.label15.Text = "Cierre:";
            this.label15.Click += new System.EventHandler(this.label15_Click);
            // 
            // cboajustetraslacion
            // 
            this.cboajustetraslacion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(218)))), ((int)(((byte)(231)))));
            this.cboajustetraslacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboajustetraslacion.FormattingEnabled = true;
            this.cboajustetraslacion.Location = new System.Drawing.Point(125, 220);
            this.cboajustetraslacion.Name = "cboajustetraslacion";
            this.cboajustetraslacion.Size = new System.Drawing.Size(122, 21);
            this.cboajustetraslacion.TabIndex = 27;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.Color.Transparent;
            this.label17.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(8, 224);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(116, 13);
            this.label17.TabIndex = 100;
            this.label17.Text = "Ajuste por Traslación:";
            // 
            // cbocuentabc
            // 
            this.cbocuentabc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(218)))), ((int)(((byte)(231)))));
            this.cbocuentabc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbocuentabc.FormattingEnabled = true;
            this.cbocuentabc.Location = new System.Drawing.Point(369, 220);
            this.cbocuentabc.Name = "cbocuentabc";
            this.cbocuentabc.Size = new System.Drawing.Size(77, 21);
            this.cbocuentabc.TabIndex = 28;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.Transparent;
            this.label16.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(247, 224);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(122, 13);
            this.label16.TabIndex = 100;
            this.label16.Text = "Cuenta Declarante BC:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.BackColor = System.Drawing.Color.Transparent;
            this.label18.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(12, 39);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(160, 13);
            this.label18.TabIndex = 98;
            this.label18.Text = "Cuenta Contable Descripción:";
            // 
            // btneliminar
            // 
            this.btneliminar.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btneliminar.Image = ((System.Drawing.Image)(resources.GetObject("btneliminar.Image")));
            this.btneliminar.Location = new System.Drawing.Point(740, 57);
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Size = new System.Drawing.Size(82, 23);
            this.btneliminar.TabIndex = 3;
            this.btneliminar.Text = "Eliminar";
            this.btneliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btneliminar.UseVisualStyleBackColor = true;
            this.btneliminar.Click += new System.EventHandler(this.btneliminar_Click);
            // 
            // btnmodificar
            // 
            this.btnmodificar.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmodificar.Image = ((System.Drawing.Image)(resources.GetObject("btnmodificar.Image")));
            this.btnmodificar.Location = new System.Drawing.Point(740, 34);
            this.btnmodificar.Name = "btnmodificar";
            this.btnmodificar.Size = new System.Drawing.Size(82, 23);
            this.btnmodificar.TabIndex = 2;
            this.btnmodificar.Text = "Modificar";
            this.btnmodificar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnmodificar.UseVisualStyleBackColor = true;
            this.btnmodificar.Click += new System.EventHandler(this.btnmodificar_Click);
            // 
            // btnnuevo
            // 
            this.btnnuevo.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnnuevo.Image = ((System.Drawing.Image)(resources.GetObject("btnnuevo.Image")));
            this.btnnuevo.Location = new System.Drawing.Point(740, 11);
            this.btnnuevo.Name = "btnnuevo";
            this.btnnuevo.Size = new System.Drawing.Size(82, 23);
            this.btnnuevo.TabIndex = 1;
            this.btnnuevo.Text = "Nuevo";
            this.btnnuevo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnnuevo.UseVisualStyleBackColor = true;
            this.btnnuevo.Click += new System.EventHandler(this.btnnuevo_Click);
            // 
            // lblmsg
            // 
            this.lblmsg.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblmsg.AutoSize = true;
            this.lblmsg.BackColor = System.Drawing.Color.Transparent;
            this.lblmsg.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmsg.Location = new System.Drawing.Point(14, 551);
            this.lblmsg.Name = "lblmsg";
            this.lblmsg.Size = new System.Drawing.Size(101, 13);
            this.lblmsg.TabIndex = 129;
            this.lblmsg.Text = "Total de Registros:";
            // 
            // tipmsg
            // 
            this.tipmsg.IsBalloon = true;
            // 
            // btncargarcuentas
            // 
            this.btncargarcuentas.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btncargarcuentas.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncargarcuentas.Image = ((System.Drawing.Image)(resources.GetObject("btncargarcuentas.Image")));
            this.btncargarcuentas.Location = new System.Drawing.Point(740, 126);
            this.btncargarcuentas.Name = "btncargarcuentas";
            this.btncargarcuentas.Size = new System.Drawing.Size(82, 23);
            this.btncargarcuentas.TabIndex = 137;
            this.btncargarcuentas.Text = "Cuentas";
            this.btncargarcuentas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.tipmsg.SetToolTip(this.btncargarcuentas, "Cargar Cuentas por Excel");
            this.btncargarcuentas.UseVisualStyleBackColor = true;
            this.btncargarcuentas.Visible = false;
            this.btncargarcuentas.Click += new System.EventHandler(this.btncargarcuentas_Click);
            // 
            // btncancelar
            // 
            this.btncancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btncancelar.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncancelar.Image = ((System.Drawing.Image)(resources.GetObject("btncancelar.Image")));
            this.btncancelar.Location = new System.Drawing.Point(740, 545);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(82, 24);
            this.btncancelar.TabIndex = 51;
            this.btncancelar.Text = "Cancelar";
            this.btncancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btncancelar.UseVisualStyleBackColor = true;
            this.btncancelar.Click += new System.EventHandler(this.btncancelar_Click);
            // 
            // btnaceptar
            // 
            this.btnaceptar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnaceptar.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnaceptar.Image = ((System.Drawing.Image)(resources.GetObject("btnaceptar.Image")));
            this.btnaceptar.Location = new System.Drawing.Point(654, 545);
            this.btnaceptar.Name = "btnaceptar";
            this.btnaceptar.Size = new System.Drawing.Size(82, 24);
            this.btnaceptar.TabIndex = 50;
            this.btnaceptar.Text = "Aceptar";
            this.btnaceptar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnaceptar.UseVisualStyleBackColor = true;
            this.btnaceptar.Click += new System.EventHandler(this.btnaceptar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.radioButton4);
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Location = new System.Drawing.Point(15, 269);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(807, 28);
            this.groupBox1.TabIndex = 133;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.BackColor = System.Drawing.Color.Transparent;
            this.radioButton4.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.radioButton4.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton4.Location = new System.Drawing.Point(119, 10);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(85, 18);
            this.radioButton4.TabIndex = 41;
            this.radioButton4.Text = "Cuenta N1";
            this.radioButton4.UseVisualStyleBackColor = false;
            this.radioButton4.CheckedChanged += new System.EventHandler(this.radioButton4_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.BackColor = System.Drawing.Color.Transparent;
            this.radioButton2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.radioButton2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton2.Location = new System.Drawing.Point(211, 10);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(118, 18);
            this.radioButton2.TabIndex = 42;
            this.radioButton2.Text = "Cuenta Contable";
            this.radioButton2.UseVisualStyleBackColor = false;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.BackColor = System.Drawing.Color.Transparent;
            this.radioButton1.Checked = true;
            this.radioButton1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.radioButton1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton1.Location = new System.Drawing.Point(18, 10);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(109, 18);
            this.radioButton1.TabIndex = 40;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Código Cuenta";
            this.radioButton1.UseVisualStyleBackColor = false;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // dtgconten
            // 
            this.dtgconten.AllowUserToAddRows = false;
            this.dtgconten.AllowUserToDeleteRows = false;
            this.dtgconten.AllowUserToOrderColumns = true;
            this.dtgconten.AllowUserToResizeColumns = false;
            this.dtgconten.AllowUserToResizeRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(230)))), ((int)(((byte)(241)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(191)))), ((int)(((byte)(231)))));
            this.dtgconten.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dtgconten.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgconten.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dtgconten.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dtgconten.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(218)))), ((int)(((byte)(231)))));
            this.dtgconten.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgconten.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.dtgconten.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(129)))), ((int)(((byte)(189)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.DeepSkyBlue;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgconten.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dtgconten.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dtgconten.Cursor = System.Windows.Forms.Cursors.Default;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(207)))), ((int)(((byte)(241)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgconten.DefaultCellStyle = dataGridViewCellStyle6;
            this.dtgconten.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dtgconten.EnableHeadersVisualStyles = false;
            this.dtgconten.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(179)))), ((int)(((byte)(215)))));
            this.dtgconten.Location = new System.Drawing.Point(17, 299);
            this.dtgconten.MultiSelect = false;
            this.dtgconten.Name = "dtgconten";
            this.dtgconten.ReadOnly = true;
            this.dtgconten.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dtgconten.RowHeadersVisible = false;
            this.dtgconten.RowTemplate.Height = 16;
            this.dtgconten.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgconten.Size = new System.Drawing.Size(805, 240);
            this.dtgconten.TabIndex = 132;
            this.dtgconten.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgconten_CellContentDoubleClick);
            this.dtgconten.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgconten_RowEnter);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(412, 108);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(95, 13);
            this.label9.TabIndex = 138;
            this.label9.Text = "Solicitar Detalle?:";
            // 
            // cbosolicitar
            // 
            this.cbosolicitar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(218)))), ((int)(((byte)(231)))));
            this.cbosolicitar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbosolicitar.FormattingEnabled = true;
            this.cbosolicitar.Location = new System.Drawing.Point(507, 104);
            this.cbosolicitar.Name = "cbosolicitar";
            this.cbosolicitar.Size = new System.Drawing.Size(150, 21);
            this.cbosolicitar.TabIndex = 19;
            // 
            // Txtbusca
            // 
            this.Txtbusca.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Txtbusca.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(218)))), ((int)(((byte)(231)))));
            this.Txtbusca.FondoBoton = ((System.Drawing.Image)(resources.GetObject("Txtbusca.FondoBoton")));
            this.Txtbusca.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txtbusca.ForeColor = System.Drawing.Color.Black;
            this.Txtbusca.ImgBotonCerrar = null;
            this.Txtbusca.Location = new System.Drawing.Point(17, 245);
            this.Txtbusca.Name = "Txtbusca";
            this.Txtbusca.Size = new System.Drawing.Size(805, 22);
            this.Txtbusca.TabIndex = 43;
            this.Txtbusca.BuscarClick += new System.EventHandler(this.Txtbusca_TextChanged);
            this.Txtbusca.BuscarTextChanged += new System.EventHandler(this.Txtbusca_TextChanged);
            this.Txtbusca.Load += new System.EventHandler(this.Txtbusca_Load);
            // 
            // chkcabecera
            // 
            this.chkcabecera.AutoSize = true;
            this.chkcabecera.BackColor = System.Drawing.Color.Transparent;
            this.chkcabecera.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkcabecera.ForeColor = System.Drawing.SystemColors.ControlText;
            this.chkcabecera.Location = new System.Drawing.Point(663, 106);
            this.chkcabecera.Name = "chkcabecera";
            this.chkcabecera.Size = new System.Drawing.Size(73, 17);
            this.chkcabecera.TabIndex = 20;
            this.chkcabecera.Text = "Cabecera";
            this.chkcabecera.UseVisualStyleBackColor = true;
            // 
            // txtnombrecuenta
            // 
            this.txtnombrecuenta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(218)))), ((int)(((byte)(231)))));
            this.txtnombrecuenta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtnombrecuenta.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtnombrecuenta.ColorFondoMouseEncima = System.Drawing.Color.Empty;
            this.txtnombrecuenta.ColorFondoMousePresionado = System.Drawing.Color.Empty;
            this.txtnombrecuenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnombrecuenta.ForeColor = System.Drawing.Color.Black;
            this.txtnombrecuenta.Format = null;
            this.txtnombrecuenta.Location = new System.Drawing.Point(172, 35);
            this.txtnombrecuenta.MaxLength = 250;
            this.txtnombrecuenta.Name = "txtnombrecuenta";
            this.txtnombrecuenta.NextControlOnEnter = this.cbotipo;
            this.txtnombrecuenta.ReadOnly = true;
            this.txtnombrecuenta.Size = new System.Drawing.Size(564, 21);
            this.txtnombrecuenta.TabIndex = 12;
            this.txtnombrecuenta.Text = "DESCRIPCIÓN DE LA CUENTA CONTABLE";
            this.txtnombrecuenta.TextoDefecto = "DESCRIPCIÓN DE LA CUENTA CONTABLE";
            this.txtnombrecuenta.TextoDefectoColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(129)))), ((int)(((byte)(189)))));
            this.txtnombrecuenta.TiposDatos = HpResergerUserControls.TextBoxPer.ListaTipos.MayusculaCadaPalabra;
            // 
            // txtcodcuenta
            // 
            this.txtcodcuenta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(218)))), ((int)(((byte)(231)))));
            this.txtcodcuenta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtcodcuenta.ColorFondoMouseEncima = System.Drawing.Color.Empty;
            this.txtcodcuenta.ColorFondoMousePresionado = System.Drawing.Color.Empty;
            this.txtcodcuenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcodcuenta.ForeColor = System.Drawing.Color.Black;
            this.txtcodcuenta.Format = null;
            this.txtcodcuenta.Location = new System.Drawing.Point(507, 12);
            this.txtcodcuenta.MaxLength = 12;
            this.txtcodcuenta.Name = "txtcodcuenta";
            this.txtcodcuenta.NextControlOnEnter = this.txtnombrecuenta;
            this.txtcodcuenta.ReadOnly = true;
            this.txtcodcuenta.Size = new System.Drawing.Size(229, 21);
            this.txtcodcuenta.TabIndex = 11;
            this.txtcodcuenta.Text = "00000000";
            this.txtcodcuenta.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtcodcuenta.TextoDefecto = "00000000";
            this.txtcodcuenta.TextoDefectoColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(129)))), ((int)(((byte)(189)))));
            this.txtcodcuenta.TiposDatos = HpResergerUserControls.TextBoxPer.ListaTipos.SoloNumeros;
            // 
            // txtcuentan1
            // 
            this.txtcuentan1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(218)))), ((int)(((byte)(231)))));
            this.txtcuentan1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtcuentan1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtcuentan1.ColorFondoMouseEncima = System.Drawing.Color.Empty;
            this.txtcuentan1.ColorFondoMousePresionado = System.Drawing.Color.Empty;
            this.txtcuentan1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcuentan1.ForeColor = System.Drawing.Color.Black;
            this.txtcuentan1.Format = null;
            this.txtcuentan1.Location = new System.Drawing.Point(126, 12);
            this.txtcuentan1.MaxLength = 250;
            this.txtcuentan1.Name = "txtcuentan1";
            this.txtcuentan1.NextControlOnEnter = this.txtcodcuenta;
            this.txtcuentan1.ReadOnly = true;
            this.txtcuentan1.Size = new System.Drawing.Size(294, 21);
            this.txtcuentan1.TabIndex = 10;
            this.txtcuentan1.Text = "CUENTA CONTABLE N1";
            this.txtcuentan1.TextoDefecto = "CUENTA CONTABLE N1";
            this.txtcuentan1.TextoDefectoColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(129)))), ((int)(((byte)(189)))));
            this.txtcuentan1.TiposDatos = HpResergerUserControls.TextBoxPer.ListaTipos.MayusculaCadaPalabra;
            // 
            // txtcuentacierre
            // 
            this.txtcuentacierre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(218)))), ((int)(((byte)(231)))));
            this.txtcuentacierre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtcuentacierre.ColorFondoMouseEncima = System.Drawing.Color.Empty;
            this.txtcuentacierre.ColorFondoMousePresionado = System.Drawing.Color.Empty;
            this.txtcuentacierre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcuentacierre.ForeColor = System.Drawing.Color.Black;
            this.txtcuentacierre.Format = null;
            this.txtcuentacierre.Location = new System.Drawing.Point(124, 174);
            this.txtcuentacierre.MaxLength = 250;
            this.txtcuentacierre.Name = "txtcuentacierre";
            this.txtcuentacierre.NextControlOnEnter = this.cbotipo;
            this.txtcuentacierre.ReadOnly = true;
            this.txtcuentacierre.Size = new System.Drawing.Size(612, 21);
            this.txtcuentacierre.TabIndex = 23;
            this.txtcuentacierre.TextoDefecto = "";
            this.txtcuentacierre.TextoDefectoColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(129)))), ((int)(((byte)(189)))));
            this.txtcuentacierre.TiposDatos = HpResergerUserControls.TextBoxPer.ListaTipos.MayusculaCadaPalabra;
            this.txtcuentacierre.TextChanged += new System.EventHandler(this.txtcuentacierre_TextChanged);
            // 
            // cboestado
            // 
            this.cboestado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(218)))), ((int)(((byte)(231)))));
            this.cboestado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboestado.FormattingEnabled = true;
            this.cboestado.Location = new System.Drawing.Point(598, 220);
            this.cboestado.Name = "cboestado";
            this.cboestado.Size = new System.Drawing.Size(138, 21);
            this.cboestado.TabIndex = 29;
            this.cboestado.SelectedIndexChanged += new System.EventHandler(this.cbocierre_SelectedIndexChanged);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.BackColor = System.Drawing.Color.Transparent;
            this.label19.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(553, 224);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(45, 13);
            this.label19.TabIndex = 100;
            this.label19.Text = "Estado:";
            this.label19.Click += new System.EventHandler(this.label15_Click);
            // 
            // btnExportarPlan
            // 
            this.btnExportarPlan.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnExportarPlan.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExportarPlan.Image = ((System.Drawing.Image)(resources.GetObject("btnExportarPlan.Image")));
            this.btnExportarPlan.Location = new System.Drawing.Point(334, 546);
            this.btnExportarPlan.Name = "btnExportarPlan";
            this.btnExportarPlan.Size = new System.Drawing.Size(82, 23);
            this.btnExportarPlan.TabIndex = 3;
            this.btnExportarPlan.Text = "Plan 1";
            this.btnExportarPlan.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnExportarPlan.UseVisualStyleBackColor = true;
            this.btnExportarPlan.Click += new System.EventHandler(this.btnExportarPlan_Click);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // btnExportarPLan2Col
            // 
            this.btnExportarPLan2Col.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnExportarPLan2Col.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExportarPLan2Col.Image = ((System.Drawing.Image)(resources.GetObject("btnExportarPLan2Col.Image")));
            this.btnExportarPLan2Col.Location = new System.Drawing.Point(418, 546);
            this.btnExportarPLan2Col.Name = "btnExportarPLan2Col";
            this.btnExportarPLan2Col.Size = new System.Drawing.Size(82, 23);
            this.btnExportarPLan2Col.TabIndex = 3;
            this.btnExportarPLan2Col.Text = "Plan 2";
            this.btnExportarPLan2Col.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnExportarPLan2Col.UseVisualStyleBackColor = true;
            this.btnExportarPLan2Col.Click += new System.EventHandler(this.btnExportarPLan2Col_Click);
            // 
            // chkInterEmpresa
            // 
            this.chkInterEmpresa.AutoSize = true;
            this.chkInterEmpresa.BackColor = System.Drawing.Color.Transparent;
            this.chkInterEmpresa.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkInterEmpresa.ForeColor = System.Drawing.SystemColors.ControlText;
            this.chkInterEmpresa.Location = new System.Drawing.Point(460, 222);
            this.chkInterEmpresa.Name = "chkInterEmpresa";
            this.chkInterEmpresa.Size = new System.Drawing.Size(93, 17);
            this.chkInterEmpresa.TabIndex = 20;
            this.chkInterEmpresa.Text = "InterEmpresa";
            this.chkInterEmpresa.UseVisualStyleBackColor = true;
            // 
            // frmcuentacontable
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 576);
            this.Controls.Add(this.txtcuentacierre);
            this.Controls.Add(this.txtcuentan1);
            this.Controls.Add(this.txtcodcuenta);
            this.Controls.Add(this.txtnombrecuenta);
            this.Controls.Add(this.chkInterEmpresa);
            this.Controls.Add(this.chkcabecera);
            this.Controls.Add(this.Txtbusca);
            this.Controls.Add(this.cbosolicitar);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btncargarcuentas);
            this.Controls.Add(this.dtgconten);
            this.Controls.Add(this.lblmsg);
            this.Controls.Add(this.btncancelar);
            this.Controls.Add(this.btnaceptar);
            this.Controls.Add(this.btnExportarPLan2Col);
            this.Controls.Add(this.btnExportarPlan);
            this.Controls.Add(this.btneliminar);
            this.Controls.Add(this.btnmodificar);
            this.Controls.Add(this.btnnuevo);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cboreflejacc);
            this.Controls.Add(this.cboajustetraslacion);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cboajustemensual);
            this.Controls.Add(this.cbocuentabc);
            this.Controls.Add(this.cboanalitica);
            this.Controls.Add(this.cboestado);
            this.Controls.Add(this.cbocierre);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cborefleja);
            this.Controls.Add(this.cbogrupo);
            this.Controls.Add(this.cbonaturaleza);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbogenerica);
            this.Controls.Add(this.cbotipo);
            this.Controls.Add(this.cboreflejahaber);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cboreflejadebe);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinimumSize = new System.Drawing.Size(850, 615);
            this.Name = "frmcuentacontable";
            this.Nombre = " Cuenta Contable";
            this.Text = " Cuenta Contable";
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
        private System.Windows.Forms.Button btneliminar;
        private System.Windows.Forms.Button btnmodificar;
        private System.Windows.Forms.Label lblmsg;
        private System.Windows.Forms.ToolTip tipmsg;
        private System.Windows.Forms.Button btncancelar;
        private System.Windows.Forms.Button btnaceptar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private Dtgconten dtgconten;
        private System.Windows.Forms.Button btnnuevo;
        private System.Windows.Forms.Button btncargarcuentas;
        private System.Windows.Forms.OpenFileDialog OpenFileDialog;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cbosolicitar;
        public txtBuscar Txtbusca;
        private System.Windows.Forms.CheckBox chkcabecera;
        private TextBoxPer txtnombrecuenta;
        public TextBoxPer txtcodcuenta;
        public TextBoxPer txtcuentan1;
        private TextBoxPer txtcuentacierre;
        private System.Windows.Forms.ComboBox cboestado;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Button btnExportarPlan;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button btnExportarPLan2Col;
        private System.Windows.Forms.CheckBox chkInterEmpresa;
    }
}