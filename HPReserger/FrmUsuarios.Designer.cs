using HpResergerUserControls;

namespace HPReserger
{
    partial class FrmUsuarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmUsuarios));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btnaceptar = new System.Windows.Forms.Button();
            this.btncancelar = new System.Windows.Forms.Button();
            this.btnnuevo = new System.Windows.Forms.Button();
            this.btnmodificar = new System.Windows.Forms.Button();
            this.btneliminar = new System.Windows.Forms.Button();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.txtapepat = new System.Windows.Forms.TextBox();
            this.txtapetmat = new System.Windows.Forms.TextBox();
            this.cbotipoid = new System.Windows.Forms.ComboBox();
            this.cboperfil = new System.Windows.Forms.ComboBox();
            this.txtlogin = new System.Windows.Forms.TextBox();
            this.txtcontra = new System.Windows.Forms.TextBox();
            this.cboestado = new System.Windows.Forms.ComboBox();
            this.txtid = new System.Windows.Forms.TextBox();
            this.cboarea = new System.Windows.Forms.ComboBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.dtgconten = new System.Windows.Forms.DataGridView();
            this.lblmensaje = new System.Windows.Forms.Label();
            this.GridUser = new HpResergerUserControls.Dtgconten();
            this.Codigox = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipox = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.docx = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombresx = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellidopatx = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellidomatx = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gerenciax = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.perfilx = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loginx = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estadox = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codperfilx = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codestadox = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passx = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xconectado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnnuevoTemporal = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.separadorOre1 = new HpResergerUserControls.SeparadorOre();
            this.txtbusnombre = new HpResergerUserControls.TextBoxPer();
            this.txtbusnro = new HpResergerUserControls.TextBoxPer();
            this.txtbustipodoc = new HpResergerUserControls.TextBoxPer();
            this.txtbusareagerencia = new HpResergerUserControls.TextBoxPer();
            this.txtbuslogin = new HpResergerUserControls.TextBoxPer();
            this.btnlimpiar = new System.Windows.Forms.Button();
            this.lblmsg = new System.Windows.Forms.Label();
            this.btndesconectar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgconten)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridUser)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.label1.Location = new System.Drawing.Point(54, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombres:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.label2.Location = new System.Drawing.Point(14, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Apellido Paterno:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.label3.Location = new System.Drawing.Point(12, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Apellido Materno:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.label4.Location = new System.Drawing.Point(12, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(148, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Tipo Documento Identidad:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(465, 37);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Perfil Usuario:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(501, 60);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Login:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(481, 82);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Password:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(494, 104);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Estado:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(465, 14);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(145, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "Nro Documento Identidad:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.label10.Location = new System.Drawing.Point(28, 104);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(82, 13);
            this.label10.TabIndex = 0;
            this.label10.Text = "Gerencia/Area:";
            // 
            // btnaceptar
            // 
            this.btnaceptar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnaceptar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(129)))), ((int)(((byte)(189)))));
            this.btnaceptar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(179)))), ((int)(((byte)(215)))));
            this.btnaceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnaceptar.ForeColor = System.Drawing.Color.White;
            this.btnaceptar.Image = ((System.Drawing.Image)(resources.GetObject("btnaceptar.Image")));
            this.btnaceptar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnaceptar.Location = new System.Drawing.Point(713, 431);
            this.btnaceptar.Name = "btnaceptar";
            this.btnaceptar.Size = new System.Drawing.Size(94, 24);
            this.btnaceptar.TabIndex = 1;
            this.btnaceptar.Text = "Aceptar";
            this.btnaceptar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnaceptar.UseVisualStyleBackColor = false;
            this.btnaceptar.Click += new System.EventHandler(this.btnaceptar_Click);
            // 
            // btncancelar
            // 
            this.btncancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btncancelar.Image = ((System.Drawing.Image)(resources.GetObject("btncancelar.Image")));
            this.btncancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btncancelar.Location = new System.Drawing.Point(810, 431);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(94, 24);
            this.btncancelar.TabIndex = 1;
            this.btncancelar.Text = "Cancelar";
            this.btncancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btncancelar.UseVisualStyleBackColor = true;
            this.btncancelar.Click += new System.EventHandler(this.btncancelar_Click);
            // 
            // btnnuevo
            // 
            this.btnnuevo.Image = ((System.Drawing.Image)(resources.GetObject("btnnuevo.Image")));
            this.btnnuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnnuevo.Location = new System.Drawing.Point(810, 9);
            this.btnnuevo.Name = "btnnuevo";
            this.btnnuevo.Size = new System.Drawing.Size(94, 23);
            this.btnnuevo.TabIndex = 1;
            this.btnnuevo.Text = "Nuevo";
            this.btnnuevo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnnuevo.UseVisualStyleBackColor = true;
            this.btnnuevo.Click += new System.EventHandler(this.btnnuevo_Click);
            // 
            // btnmodificar
            // 
            this.btnmodificar.Image = ((System.Drawing.Image)(resources.GetObject("btnmodificar.Image")));
            this.btnmodificar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnmodificar.Location = new System.Drawing.Point(810, 32);
            this.btnmodificar.Name = "btnmodificar";
            this.btnmodificar.Size = new System.Drawing.Size(94, 23);
            this.btnmodificar.TabIndex = 1;
            this.btnmodificar.Text = "Modificar";
            this.btnmodificar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnmodificar.UseVisualStyleBackColor = true;
            this.btnmodificar.EnabledChanged += new System.EventHandler(this.btnmodificar_EnabledChanged);
            this.btnmodificar.Click += new System.EventHandler(this.btnmodificar_Click);
            // 
            // btneliminar
            // 
            this.btneliminar.Image = ((System.Drawing.Image)(resources.GetObject("btneliminar.Image")));
            this.btneliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btneliminar.Location = new System.Drawing.Point(810, 55);
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Size = new System.Drawing.Size(94, 23);
            this.btneliminar.TabIndex = 1;
            this.btneliminar.Text = "Eliminar";
            this.btneliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btneliminar.UseVisualStyleBackColor = true;
            this.btneliminar.Click += new System.EventHandler(this.btneliminar_Click);
            // 
            // txtnombre
            // 
            this.txtnombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtnombre.Location = new System.Drawing.Point(112, 33);
            this.txtnombre.MaxLength = 100;
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(349, 20);
            this.txtnombre.TabIndex = 2;
            // 
            // txtapepat
            // 
            this.txtapepat.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtapepat.Location = new System.Drawing.Point(112, 56);
            this.txtapepat.MaxLength = 100;
            this.txtapepat.Name = "txtapepat";
            this.txtapepat.Size = new System.Drawing.Size(349, 20);
            this.txtapepat.TabIndex = 2;
            // 
            // txtapetmat
            // 
            this.txtapetmat.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtapetmat.Location = new System.Drawing.Point(112, 78);
            this.txtapetmat.MaxLength = 100;
            this.txtapetmat.Name = "txtapetmat";
            this.txtapetmat.Size = new System.Drawing.Size(349, 20);
            this.txtapetmat.TabIndex = 2;
            // 
            // cbotipoid
            // 
            this.cbotipoid.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbotipoid.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbotipoid.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(218)))), ((int)(((byte)(231)))));
            this.cbotipoid.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbotipoid.FormattingEnabled = true;
            this.cbotipoid.Location = new System.Drawing.Point(166, 10);
            this.cbotipoid.Name = "cbotipoid";
            this.cbotipoid.Size = new System.Drawing.Size(295, 21);
            this.cbotipoid.TabIndex = 3;
            this.cbotipoid.SelectedIndexChanged += new System.EventHandler(this.cbotipoid_SelectedIndexChanged);
            this.cbotipoid.TextChanged += new System.EventHandler(this.cbotipoid_TextChanged);
            this.cbotipoid.Click += new System.EventHandler(this.cbotipoid_Click);
            // 
            // cboperfil
            // 
            this.cboperfil.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboperfil.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboperfil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(218)))), ((int)(((byte)(231)))));
            this.cboperfil.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboperfil.FormattingEnabled = true;
            this.cboperfil.Location = new System.Drawing.Point(545, 33);
            this.cboperfil.Name = "cboperfil";
            this.cboperfil.Size = new System.Drawing.Size(261, 21);
            this.cboperfil.TabIndex = 3;
            // 
            // txtlogin
            // 
            this.txtlogin.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtlogin.Location = new System.Drawing.Point(545, 56);
            this.txtlogin.MaxLength = 10;
            this.txtlogin.Name = "txtlogin";
            this.txtlogin.Size = new System.Drawing.Size(261, 20);
            this.txtlogin.TabIndex = 5;
            this.txtlogin.TextChanged += new System.EventHandler(this.txtlogin_TextChanged);
            this.txtlogin.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtlogin_KeyDown);
            // 
            // txtcontra
            // 
            this.txtcontra.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtcontra.Location = new System.Drawing.Point(545, 78);
            this.txtcontra.MaxLength = 10;
            this.txtcontra.Name = "txtcontra";
            this.txtcontra.Size = new System.Drawing.Size(238, 20);
            this.txtcontra.TabIndex = 6;
            this.txtcontra.UseSystemPasswordChar = true;
            this.txtcontra.TextChanged += new System.EventHandler(this.txtcontra_TextChanged);
            this.txtcontra.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtcontra_KeyDown);
            // 
            // cboestado
            // 
            this.cboestado.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboestado.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboestado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(218)))), ((int)(((byte)(231)))));
            this.cboestado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboestado.FormattingEnabled = true;
            this.cboestado.Location = new System.Drawing.Point(545, 100);
            this.cboestado.Name = "cboestado";
            this.cboestado.Size = new System.Drawing.Size(261, 21);
            this.cboestado.TabIndex = 3;
            // 
            // txtid
            // 
            this.txtid.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtid.Enabled = false;
            this.txtid.Location = new System.Drawing.Point(613, 10);
            this.txtid.MaxLength = 10;
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(193, 20);
            this.txtid.TabIndex = 1;
            this.txtid.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtid.Click += new System.EventHandler(this.txtid_Click);
            this.txtid.TextChanged += new System.EventHandler(this.txtid_TextChanged);
            this.txtid.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtid_KeyDown);
            this.txtid.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtid_KeyPress);
            // 
            // cboarea
            // 
            this.cboarea.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboarea.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboarea.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(218)))), ((int)(((byte)(231)))));
            this.cboarea.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboarea.FormattingEnabled = true;
            this.cboarea.Location = new System.Drawing.Point(112, 100);
            this.cboarea.Name = "cboarea";
            this.cboarea.Size = new System.Drawing.Size(349, 21);
            this.cboarea.TabIndex = 3;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.Location = new System.Drawing.Point(791, 81);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(15, 14);
            this.checkBox1.TabIndex = 4;
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // dtgconten
            // 
            this.dtgconten.AllowUserToAddRows = false;
            this.dtgconten.AllowUserToDeleteRows = false;
            this.dtgconten.AllowUserToResizeColumns = false;
            this.dtgconten.AllowUserToResizeRows = false;
            this.dtgconten.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtgconten.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dtgconten.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dtgconten.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dtgconten.Cursor = System.Windows.Forms.Cursors.Default;
            this.dtgconten.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dtgconten.Location = new System.Drawing.Point(70, 646);
            this.dtgconten.MultiSelect = false;
            this.dtgconten.Name = "dtgconten";
            this.dtgconten.ReadOnly = true;
            this.dtgconten.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dtgconten.RowHeadersVisible = false;
            this.dtgconten.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgconten.Size = new System.Drawing.Size(798, 139);
            this.dtgconten.TabIndex = 133;
            this.dtgconten.Visible = false;
            this.dtgconten.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgconten_RowEnter);
            // 
            // lblmensaje
            // 
            this.lblmensaje.AutoSize = true;
            this.lblmensaje.Location = new System.Drawing.Point(12, 159);
            this.lblmensaje.Name = "lblmensaje";
            this.lblmensaje.Size = new System.Drawing.Size(0, 13);
            this.lblmensaje.TabIndex = 135;
            // 
            // GridUser
            // 
            this.GridUser.AllowUserToAddRows = false;
            this.GridUser.AllowUserToDeleteRows = false;
            this.GridUser.AllowUserToOrderColumns = true;
            this.GridUser.AllowUserToResizeColumns = false;
            this.GridUser.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(230)))), ((int)(((byte)(241)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(191)))), ((int)(((byte)(231)))));
            this.GridUser.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.GridUser.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GridUser.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.GridUser.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(218)))), ((int)(((byte)(231)))));
            this.GridUser.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.GridUser.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.GridUser.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(129)))), ((int)(((byte)(189)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DeepSkyBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GridUser.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.GridUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.GridUser.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigox,
            this.IDX,
            this.tipox,
            this.docx,
            this.nombresx,
            this.Apellidopatx,
            this.apellidomatx,
            this.gerenciax,
            this.perfilx,
            this.loginx,
            this.estadox,
            this.codperfilx,
            this.codestadox,
            this.passx,
            this.xconectado});
            this.GridUser.Cursor = System.Windows.Forms.Cursors.Default;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(207)))), ((int)(((byte)(241)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.GridUser.DefaultCellStyle = dataGridViewCellStyle3;
            this.GridUser.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.GridUser.EnableHeadersVisualStyles = false;
            this.GridUser.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(179)))), ((int)(((byte)(215)))));
            this.GridUser.Location = new System.Drawing.Point(12, 170);
            this.GridUser.MultiSelect = false;
            this.GridUser.Name = "GridUser";
            this.GridUser.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.GridUser.RowHeadersVisible = false;
            this.GridUser.RowTemplate.Height = 18;
            this.GridUser.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GridUser.Size = new System.Drawing.Size(892, 255);
            this.GridUser.TabIndex = 136;
            this.GridUser.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridUser_RowEnter);
            // 
            // Codigox
            // 
            this.Codigox.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Codigox.DataPropertyName = "cod";
            this.Codigox.HeaderText = "cod";
            this.Codigox.Name = "Codigox";
            this.Codigox.Visible = false;
            // 
            // IDX
            // 
            this.IDX.DataPropertyName = "id";
            this.IDX.HeaderText = "id";
            this.IDX.Name = "IDX";
            this.IDX.Visible = false;
            // 
            // tipox
            // 
            this.tipox.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.tipox.DataPropertyName = "tipo";
            this.tipox.HeaderText = "Tipo";
            this.tipox.Name = "tipox";
            this.tipox.Width = 54;
            // 
            // docx
            // 
            this.docx.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.docx.DataPropertyName = "doc";
            this.docx.HeaderText = "NroDoc";
            this.docx.Name = "docx";
            this.docx.Width = 71;
            // 
            // nombresx
            // 
            this.nombresx.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nombresx.DataPropertyName = "nombres";
            this.nombresx.HeaderText = "Nombres";
            this.nombresx.MinimumWidth = 60;
            this.nombresx.Name = "nombresx";
            // 
            // Apellidopatx
            // 
            this.Apellidopatx.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Apellidopatx.DataPropertyName = "paterno";
            this.Apellidopatx.HeaderText = "Apellido P.";
            this.Apellidopatx.Name = "Apellidopatx";
            this.Apellidopatx.Width = 87;
            // 
            // apellidomatx
            // 
            this.apellidomatx.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.apellidomatx.DataPropertyName = "materno";
            this.apellidomatx.HeaderText = "Apellido M.";
            this.apellidomatx.Name = "apellidomatx";
            this.apellidomatx.Width = 91;
            // 
            // gerenciax
            // 
            this.gerenciax.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.gerenciax.DataPropertyName = "gerencia";
            this.gerenciax.HeaderText = "Gerencia";
            this.gerenciax.MinimumWidth = 150;
            this.gerenciax.Name = "gerenciax";
            this.gerenciax.Width = 150;
            // 
            // perfilx
            // 
            this.perfilx.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.perfilx.DataPropertyName = "perfil";
            this.perfilx.HeaderText = "Perfil";
            this.perfilx.Name = "perfilx";
            this.perfilx.Width = 57;
            // 
            // loginx
            // 
            this.loginx.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.loginx.DataPropertyName = "loginuser";
            this.loginx.HeaderText = "Login";
            this.loginx.Name = "loginx";
            this.loginx.Width = 60;
            // 
            // estadox
            // 
            this.estadox.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.estadox.DataPropertyName = "estado";
            this.estadox.HeaderText = "Estado";
            this.estadox.Name = "estadox";
            this.estadox.Width = 65;
            // 
            // codperfilx
            // 
            this.codperfilx.DataPropertyName = "codperfil";
            this.codperfilx.HeaderText = "codperfil";
            this.codperfilx.Name = "codperfilx";
            this.codperfilx.Visible = false;
            // 
            // codestadox
            // 
            this.codestadox.DataPropertyName = "codestado";
            this.codestadox.HeaderText = "codestado";
            this.codestadox.Name = "codestadox";
            this.codestadox.Visible = false;
            // 
            // passx
            // 
            this.passx.DataPropertyName = "pass";
            this.passx.HeaderText = "Pasxx";
            this.passx.Name = "passx";
            this.passx.Visible = false;
            // 
            // xconectado
            // 
            this.xconectado.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.xconectado.DataPropertyName = "conectado";
            this.xconectado.HeaderText = "Conectado";
            this.xconectado.MinimumWidth = 70;
            this.xconectado.Name = "xconectado";
            this.xconectado.Width = 70;
            // 
            // btnnuevoTemporal
            // 
            this.btnnuevoTemporal.Location = new System.Drawing.Point(810, 99);
            this.btnnuevoTemporal.Name = "btnnuevoTemporal";
            this.btnnuevoTemporal.Size = new System.Drawing.Size(94, 23);
            this.btnnuevoTemporal.TabIndex = 137;
            this.btnnuevoTemporal.Text = "Nuevo Temporal";
            this.btnnuevoTemporal.UseVisualStyleBackColor = true;
            this.btnnuevoTemporal.Click += new System.EventHandler(this.button1_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.label11.Location = new System.Drawing.Point(14, 155);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(112, 13);
            this.label11.TabIndex = 0;
            this.label11.Text = "Listado de Usuarios:";
            // 
            // separadorOre1
            // 
            this.separadorOre1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.separadorOre1.Location = new System.Drawing.Point(0, 126);
            this.separadorOre1.MaximumSize = new System.Drawing.Size(2000, 2);
            this.separadorOre1.MinimumSize = new System.Drawing.Size(0, 2);
            this.separadorOre1.Name = "separadorOre1";
            this.separadorOre1.Size = new System.Drawing.Size(924, 2);
            this.separadorOre1.TabIndex = 138;
            // 
            // txtbusnombre
            // 
            this.txtbusnombre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(218)))), ((int)(((byte)(231)))));
            this.txtbusnombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtbusnombre.ColorFondoMouseEncima = System.Drawing.Color.Empty;
            this.txtbusnombre.ColorFondoMousePresionado = System.Drawing.Color.Empty;
            this.txtbusnombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbusnombre.ForeColor = System.Drawing.Color.Black;
            this.txtbusnombre.Format = null;
            this.txtbusnombre.Location = new System.Drawing.Point(260, 132);
            this.txtbusnombre.MaxLength = 30;
            this.txtbusnombre.Name = "txtbusnombre";
            this.txtbusnombre.NextControlOnEnter = null;
            this.txtbusnombre.ReadOnly = true;
            this.txtbusnombre.Size = new System.Drawing.Size(218, 21);
            this.txtbusnombre.TabIndex = 139;
            this.txtbusnombre.Text = "Buscar Por Nombre Apellidos";
            this.txtbusnombre.TextoDefecto = "Buscar Por Nombre Apellidos";
            this.txtbusnombre.TextoDefectoColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(129)))), ((int)(((byte)(189)))));
            this.txtbusnombre.TiposDatos = HpResergerUserControls.TextBoxPer.ListaTipos.MayusculaCadaPalabra;
            this.txtbusnombre.TextChanged += new System.EventHandler(this.txtbuslogin_TextChanged);
            // 
            // txtbusnro
            // 
            this.txtbusnro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(218)))), ((int)(((byte)(231)))));
            this.txtbusnro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtbusnro.ColorFondoMouseEncima = System.Drawing.Color.Empty;
            this.txtbusnro.ColorFondoMousePresionado = System.Drawing.Color.Empty;
            this.txtbusnro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbusnro.ForeColor = System.Drawing.Color.Black;
            this.txtbusnro.Format = null;
            this.txtbusnro.Location = new System.Drawing.Point(12, 132);
            this.txtbusnro.MaxLength = 30;
            this.txtbusnro.Name = "txtbusnro";
            this.txtbusnro.NextControlOnEnter = null;
            this.txtbusnro.ReadOnly = true;
            this.txtbusnro.Size = new System.Drawing.Size(121, 21);
            this.txtbusnro.TabIndex = 140;
            this.txtbusnro.Text = "Buscar Nro Doc";
            this.txtbusnro.TextoDefecto = "Buscar Nro Doc";
            this.txtbusnro.TextoDefectoColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(129)))), ((int)(((byte)(189)))));
            this.txtbusnro.TiposDatos = HpResergerUserControls.TextBoxPer.ListaTipos.SoloNumeros;
            this.txtbusnro.TextChanged += new System.EventHandler(this.txtbuslogin_TextChanged);
            // 
            // txtbustipodoc
            // 
            this.txtbustipodoc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(218)))), ((int)(((byte)(231)))));
            this.txtbustipodoc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtbustipodoc.ColorFondoMouseEncima = System.Drawing.Color.Empty;
            this.txtbustipodoc.ColorFondoMousePresionado = System.Drawing.Color.Empty;
            this.txtbustipodoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbustipodoc.ForeColor = System.Drawing.Color.Black;
            this.txtbustipodoc.Format = null;
            this.txtbustipodoc.Location = new System.Drawing.Point(136, 132);
            this.txtbustipodoc.MaxLength = 30;
            this.txtbustipodoc.Name = "txtbustipodoc";
            this.txtbustipodoc.NextControlOnEnter = null;
            this.txtbustipodoc.ReadOnly = true;
            this.txtbustipodoc.Size = new System.Drawing.Size(121, 21);
            this.txtbustipodoc.TabIndex = 140;
            this.txtbustipodoc.Text = "Buscar Tipo Dcmto";
            this.txtbustipodoc.TextoDefecto = "Buscar Tipo Dcmto";
            this.txtbustipodoc.TextoDefectoColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(129)))), ((int)(((byte)(189)))));
            this.txtbustipodoc.TiposDatos = HpResergerUserControls.TextBoxPer.ListaTipos.MayusculaCadaPalabra;
            this.txtbustipodoc.TextChanged += new System.EventHandler(this.txtbuslogin_TextChanged);
            // 
            // txtbusareagerencia
            // 
            this.txtbusareagerencia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(218)))), ((int)(((byte)(231)))));
            this.txtbusareagerencia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtbusareagerencia.ColorFondoMouseEncima = System.Drawing.Color.Empty;
            this.txtbusareagerencia.ColorFondoMousePresionado = System.Drawing.Color.Empty;
            this.txtbusareagerencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbusareagerencia.ForeColor = System.Drawing.Color.Black;
            this.txtbusareagerencia.Format = null;
            this.txtbusareagerencia.Location = new System.Drawing.Point(482, 132);
            this.txtbusareagerencia.MaxLength = 30;
            this.txtbusareagerencia.Name = "txtbusareagerencia";
            this.txtbusareagerencia.NextControlOnEnter = null;
            this.txtbusareagerencia.ReadOnly = true;
            this.txtbusareagerencia.Size = new System.Drawing.Size(164, 21);
            this.txtbusareagerencia.TabIndex = 141;
            this.txtbusareagerencia.Text = "Buscar Area/Gerencia";
            this.txtbusareagerencia.TextoDefecto = "Buscar Area/Gerencia";
            this.txtbusareagerencia.TextoDefectoColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(129)))), ((int)(((byte)(189)))));
            this.txtbusareagerencia.TiposDatos = HpResergerUserControls.TextBoxPer.ListaTipos.MayusculaCadaPalabra;
            this.txtbusareagerencia.TextChanged += new System.EventHandler(this.txtbuslogin_TextChanged);
            // 
            // txtbuslogin
            // 
            this.txtbuslogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(218)))), ((int)(((byte)(231)))));
            this.txtbuslogin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtbuslogin.ColorFondoMouseEncima = System.Drawing.Color.Empty;
            this.txtbuslogin.ColorFondoMousePresionado = System.Drawing.Color.Empty;
            this.txtbuslogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbuslogin.ForeColor = System.Drawing.Color.Black;
            this.txtbuslogin.Format = null;
            this.txtbuslogin.Location = new System.Drawing.Point(650, 132);
            this.txtbuslogin.MaxLength = 30;
            this.txtbuslogin.Name = "txtbuslogin";
            this.txtbuslogin.NextControlOnEnter = null;
            this.txtbuslogin.ReadOnly = true;
            this.txtbuslogin.Size = new System.Drawing.Size(156, 21);
            this.txtbuslogin.TabIndex = 141;
            this.txtbuslogin.Text = "Buscar Login";
            this.txtbuslogin.TextoDefecto = "Buscar Login";
            this.txtbuslogin.TextoDefectoColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(129)))), ((int)(((byte)(189)))));
            this.txtbuslogin.TiposDatos = HpResergerUserControls.TextBoxPer.ListaTipos.MayusculaCadaPalabra;
            this.txtbuslogin.TextChanged += new System.EventHandler(this.txtbuslogin_TextChanged);
            // 
            // btnlimpiar
            // 
            this.btnlimpiar.Image = ((System.Drawing.Image)(resources.GetObject("btnlimpiar.Image")));
            this.btnlimpiar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnlimpiar.Location = new System.Drawing.Point(810, 130);
            this.btnlimpiar.Name = "btnlimpiar";
            this.btnlimpiar.Size = new System.Drawing.Size(94, 24);
            this.btnlimpiar.TabIndex = 142;
            this.btnlimpiar.Text = "Limpiar";
            this.btnlimpiar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnlimpiar.UseVisualStyleBackColor = true;
            this.btnlimpiar.Click += new System.EventHandler(this.btnlimpiar_Click);
            // 
            // lblmsg
            // 
            this.lblmsg.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblmsg.BackColor = System.Drawing.Color.Transparent;
            this.lblmsg.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmsg.Location = new System.Drawing.Point(9, 435);
            this.lblmsg.Name = "lblmsg";
            this.lblmsg.Size = new System.Drawing.Size(133, 16);
            this.lblmsg.TabIndex = 268;
            this.lblmsg.Text = "Total de Registros : 0";
            // 
            // btndesconectar
            // 
            this.btndesconectar.Image = ((System.Drawing.Image)(resources.GetObject("btndesconectar.Image")));
            this.btndesconectar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btndesconectar.Location = new System.Drawing.Point(810, 77);
            this.btndesconectar.Name = "btndesconectar";
            this.btndesconectar.Size = new System.Drawing.Size(94, 23);
            this.btndesconectar.TabIndex = 1;
            this.btndesconectar.Text = "Desconectar";
            this.btndesconectar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btndesconectar.UseVisualStyleBackColor = true;
            this.btndesconectar.Click += new System.EventHandler(this.btndesconectar_Click);
            // 
            // FrmUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(916, 461);
            this.Controls.Add(this.lblmsg);
            this.Controls.Add(this.btnlimpiar);
            this.Controls.Add(this.txtbuslogin);
            this.Controls.Add(this.txtbusareagerencia);
            this.Controls.Add(this.txtbustipodoc);
            this.Controls.Add(this.txtbusnro);
            this.Controls.Add(this.txtbusnombre);
            this.Controls.Add(this.separadorOre1);
            this.Controls.Add(this.btnnuevoTemporal);
            this.Controls.Add(this.lblmensaje);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.cboarea);
            this.Controls.Add(this.cboperfil);
            this.Controls.Add(this.cboestado);
            this.Controls.Add(this.cbotipoid);
            this.Controls.Add(this.txtapetmat);
            this.Controls.Add(this.txtapepat);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.txtcontra);
            this.Controls.Add(this.txtlogin);
            this.Controls.Add(this.txtnombre);
            this.Controls.Add(this.btneliminar);
            this.Controls.Add(this.btndesconectar);
            this.Controls.Add(this.btnmodificar);
            this.Controls.Add(this.btnnuevo);
            this.Controls.Add(this.btncancelar);
            this.Controls.Add(this.btnaceptar);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtgconten);
            this.Controls.Add(this.GridUser);
            this.Controls.Add(this.label9);
            this.MinimumSize = new System.Drawing.Size(932, 500);
            this.Name = "FrmUsuarios";
            this.Nombre = "Usuarios";
            this.Text = "Usuarios";
            this.Load += new System.EventHandler(this.FrmUsuarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgconten)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridUser)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnaceptar;
        private System.Windows.Forms.Button btncancelar;
        private System.Windows.Forms.Button btnnuevo;
        private System.Windows.Forms.Button btnmodificar;
        private System.Windows.Forms.Button btneliminar;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.TextBox txtapepat;
        private System.Windows.Forms.TextBox txtapetmat;
        private System.Windows.Forms.ComboBox cbotipoid;
        private System.Windows.Forms.ComboBox cboperfil;
        private System.Windows.Forms.TextBox txtlogin;
        private System.Windows.Forms.TextBox txtcontra;
        private System.Windows.Forms.ComboBox cboestado;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.ComboBox cboarea;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.DataGridView dtgconten;
        private System.Windows.Forms.Label lblmensaje;
        private Dtgconten GridUser;
        private System.Windows.Forms.Button btnnuevoTemporal;
        private System.Windows.Forms.Label label11;
        private SeparadorOre separadorOre1;
        private TextBoxPer txtbusnombre;
        private TextBoxPer txtbusnro;
        private TextBoxPer txtbustipodoc;
        private TextBoxPer txtbusareagerencia;
        private TextBoxPer txtbuslogin;
        private System.Windows.Forms.Button btnlimpiar;
        private System.Windows.Forms.Label lblmsg;
        private System.Windows.Forms.Button btndesconectar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigox;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDX;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipox;
        private System.Windows.Forms.DataGridViewTextBoxColumn docx;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombresx;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellidopatx;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellidomatx;
        private System.Windows.Forms.DataGridViewTextBoxColumn gerenciax;
        private System.Windows.Forms.DataGridViewTextBoxColumn perfilx;
        private System.Windows.Forms.DataGridViewTextBoxColumn loginx;
        private System.Windows.Forms.DataGridViewTextBoxColumn estadox;
        private System.Windows.Forms.DataGridViewTextBoxColumn codperfilx;
        private System.Windows.Forms.DataGridViewTextBoxColumn codestadox;
        private System.Windows.Forms.DataGridViewTextBoxColumn passx;
        private System.Windows.Forms.DataGridViewTextBoxColumn xconectado;
    }
}