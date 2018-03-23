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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.GridUser = new System.Windows.Forms.DataGridView();
            this.btnnuevoTemporal = new System.Windows.Forms.Button();
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
            ((System.ComponentModel.ISupportInitialize)(this.dtgconten)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridUser)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombres:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Apellido Paterno:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Apellido Materno:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(136, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Tipo Documento Identidad:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(419, 40);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Perfil Usuario:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(439, 65);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Login:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(419, 90);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Password:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(432, 115);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Estado:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(419, 15);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(132, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "Nro Documento Identidad:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(19, 115);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(80, 13);
            this.label10.TabIndex = 0;
            this.label10.Text = "Gerencia/Area:";
            // 
            // btnaceptar
            // 
            this.btnaceptar.Location = new System.Drawing.Point(622, 138);
            this.btnaceptar.Name = "btnaceptar";
            this.btnaceptar.Size = new System.Drawing.Size(94, 23);
            this.btnaceptar.TabIndex = 1;
            this.btnaceptar.Text = "Aceptar";
            this.btnaceptar.UseVisualStyleBackColor = true;
            this.btnaceptar.Click += new System.EventHandler(this.btnaceptar_Click);
            // 
            // btncancelar
            // 
            this.btncancelar.Location = new System.Drawing.Point(721, 138);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(94, 23);
            this.btncancelar.TabIndex = 1;
            this.btncancelar.Text = "Cancelar";
            this.btncancelar.UseVisualStyleBackColor = true;
            this.btncancelar.Click += new System.EventHandler(this.btncancelar_Click);
            // 
            // btnnuevo
            // 
            this.btnnuevo.Location = new System.Drawing.Point(721, 10);
            this.btnnuevo.Name = "btnnuevo";
            this.btnnuevo.Size = new System.Drawing.Size(94, 23);
            this.btnnuevo.TabIndex = 1;
            this.btnnuevo.Text = "Nuevo";
            this.btnnuevo.UseVisualStyleBackColor = true;
            this.btnnuevo.Click += new System.EventHandler(this.btnnuevo_Click);
            // 
            // btnmodificar
            // 
            this.btnmodificar.Location = new System.Drawing.Point(721, 35);
            this.btnmodificar.Name = "btnmodificar";
            this.btnmodificar.Size = new System.Drawing.Size(94, 23);
            this.btnmodificar.TabIndex = 1;
            this.btnmodificar.Text = "Modificar";
            this.btnmodificar.UseVisualStyleBackColor = true;
            this.btnmodificar.Click += new System.EventHandler(this.btnmodificar_Click);
            // 
            // btneliminar
            // 
            this.btneliminar.Location = new System.Drawing.Point(721, 60);
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Size = new System.Drawing.Size(94, 23);
            this.btneliminar.TabIndex = 1;
            this.btneliminar.Text = "Eliminar";
            this.btneliminar.UseVisualStyleBackColor = true;
            this.btneliminar.Click += new System.EventHandler(this.btneliminar_Click);
            // 
            // txtnombre
            // 
            this.txtnombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtnombre.Location = new System.Drawing.Point(105, 36);
            this.txtnombre.MaxLength = 100;
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(305, 20);
            this.txtnombre.TabIndex = 2;
            // 
            // txtapepat
            // 
            this.txtapepat.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtapepat.Location = new System.Drawing.Point(105, 61);
            this.txtapepat.MaxLength = 100;
            this.txtapepat.Name = "txtapepat";
            this.txtapepat.Size = new System.Drawing.Size(305, 20);
            this.txtapepat.TabIndex = 2;
            // 
            // txtapetmat
            // 
            this.txtapetmat.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtapetmat.Location = new System.Drawing.Point(105, 86);
            this.txtapetmat.MaxLength = 100;
            this.txtapetmat.Name = "txtapetmat";
            this.txtapetmat.Size = new System.Drawing.Size(305, 20);
            this.txtapetmat.TabIndex = 2;
            // 
            // cbotipoid
            // 
            this.cbotipoid.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbotipoid.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbotipoid.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbotipoid.FormattingEnabled = true;
            this.cbotipoid.Location = new System.Drawing.Point(154, 11);
            this.cbotipoid.Name = "cbotipoid";
            this.cbotipoid.Size = new System.Drawing.Size(256, 21);
            this.cbotipoid.TabIndex = 3;
            this.cbotipoid.SelectedIndexChanged += new System.EventHandler(this.cbotipoid_SelectedIndexChanged);
            this.cbotipoid.TextChanged += new System.EventHandler(this.cbotipoid_TextChanged);
            // 
            // cboperfil
            // 
            this.cboperfil.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboperfil.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboperfil.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboperfil.FormattingEnabled = true;
            this.cboperfil.Location = new System.Drawing.Point(497, 36);
            this.cboperfil.Name = "cboperfil";
            this.cboperfil.Size = new System.Drawing.Size(219, 21);
            this.cboperfil.TabIndex = 3;
            // 
            // txtlogin
            // 
            this.txtlogin.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtlogin.Location = new System.Drawing.Point(481, 61);
            this.txtlogin.MaxLength = 10;
            this.txtlogin.Name = "txtlogin";
            this.txtlogin.Size = new System.Drawing.Size(235, 20);
            this.txtlogin.TabIndex = 5;
            this.txtlogin.TextChanged += new System.EventHandler(this.txtlogin_TextChanged);
            this.txtlogin.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtlogin_KeyDown);
            // 
            // txtcontra
            // 
            this.txtcontra.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtcontra.Location = new System.Drawing.Point(481, 86);
            this.txtcontra.MaxLength = 10;
            this.txtcontra.Name = "txtcontra";
            this.txtcontra.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtcontra.Size = new System.Drawing.Size(214, 20);
            this.txtcontra.TabIndex = 6;
            this.txtcontra.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtcontra.UseSystemPasswordChar = true;
            this.txtcontra.TextChanged += new System.EventHandler(this.txtcontra_TextChanged);
            this.txtcontra.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtcontra_KeyDown);
            // 
            // cboestado
            // 
            this.cboestado.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboestado.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboestado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboestado.FormattingEnabled = true;
            this.cboestado.Location = new System.Drawing.Point(481, 111);
            this.cboestado.Name = "cboestado";
            this.cboestado.Size = new System.Drawing.Size(235, 21);
            this.cboestado.TabIndex = 3;
            // 
            // txtid
            // 
            this.txtid.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtid.Location = new System.Drawing.Point(558, 11);
            this.txtid.MaxLength = 10;
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(158, 20);
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
            this.cboarea.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboarea.FormattingEnabled = true;
            this.cboarea.Location = new System.Drawing.Point(105, 111);
            this.cboarea.Name = "cboarea";
            this.cboarea.Size = new System.Drawing.Size(305, 21);
            this.cboarea.TabIndex = 3;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.Location = new System.Drawing.Point(701, 89);
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
            this.dtgconten.Location = new System.Drawing.Point(25, 657);
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
            this.dtgconten.Size = new System.Drawing.Size(798, 139);
            this.dtgconten.TabIndex = 133;
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
            this.GridUser.AllowUserToResizeColumns = false;
            this.GridUser.AllowUserToResizeRows = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.WhiteSmoke;
            this.GridUser.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.GridUser.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.GridUser.BackgroundColor = System.Drawing.SystemColors.Control;
            this.GridUser.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.GridUser.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.GridUser.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Franklin Gothic Book", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GridUser.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
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
            this.passx});
            this.GridUser.Cursor = System.Windows.Forms.Cursors.Default;
            this.GridUser.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.GridUser.Location = new System.Drawing.Point(3, 167);
            this.GridUser.MultiSelect = false;
            this.GridUser.Name = "GridUser";
            this.GridUser.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.GridUser.RowHeadersVisible = false;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Franklin Gothic Book", 8.25F);
            this.GridUser.RowsDefaultCellStyle = dataGridViewCellStyle7;
            this.GridUser.RowTemplate.Height = 18;
            this.GridUser.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GridUser.Size = new System.Drawing.Size(824, 444);
            this.GridUser.TabIndex = 136;
            this.GridUser.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridUser_RowEnter);
            // 
            // btnnuevoTemporal
            // 
            this.btnnuevoTemporal.Location = new System.Drawing.Point(721, 97);
            this.btnnuevoTemporal.Name = "btnnuevoTemporal";
            this.btnnuevoTemporal.Size = new System.Drawing.Size(94, 23);
            this.btnnuevoTemporal.TabIndex = 137;
            this.btnnuevoTemporal.Text = "Nuevo Temporal";
            this.btnnuevoTemporal.UseVisualStyleBackColor = true;
            this.btnnuevoTemporal.Click += new System.EventHandler(this.button1_Click);
            // 
            // Codigox
            // 
            this.Codigox.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Codigox.DataPropertyName = "cod";
            this.Codigox.HeaderText = "cod";
            this.Codigox.Name = "Codigox";
            this.Codigox.Visible = false;
            this.Codigox.Width = 49;
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
            this.tipox.Width = 52;
            // 
            // docx
            // 
            this.docx.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.docx.DataPropertyName = "doc";
            this.docx.HeaderText = "NroDoc";
            this.docx.Name = "docx";
            this.docx.Width = 67;
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
            this.Apellidopatx.HeaderText = "ApellidoPat.";
            this.Apellidopatx.Name = "Apellidopatx";
            this.Apellidopatx.Width = 89;
            // 
            // apellidomatx
            // 
            this.apellidomatx.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.apellidomatx.DataPropertyName = "materno";
            this.apellidomatx.HeaderText = "ApellidoMat.";
            this.apellidomatx.Name = "apellidomatx";
            this.apellidomatx.Width = 92;
            // 
            // gerenciax
            // 
            this.gerenciax.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.gerenciax.DataPropertyName = "gerencia";
            this.gerenciax.HeaderText = "Gerencia";
            this.gerenciax.Name = "gerenciax";
            this.gerenciax.Width = 75;
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
            this.loginx.HeaderText = "LoginUser";
            this.loginx.Name = "loginx";
            this.loginx.Width = 79;
            // 
            // estadox
            // 
            this.estadox.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.estadox.DataPropertyName = "estado";
            this.estadox.HeaderText = "Estado";
            this.estadox.Name = "estadox";
            this.estadox.Width = 64;
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
            // FrmUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(827, 482);
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
            this.Controls.Add(this.btnmodificar);
            this.Controls.Add(this.btnnuevo);
            this.Controls.Add(this.btncancelar);
            this.Controls.Add(this.btnaceptar);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
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
            this.MaximumSize = new System.Drawing.Size(843, 650);
            this.MinimumSize = new System.Drawing.Size(843, 521);
            this.Name = "FrmUsuarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Usuario";
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
        private System.Windows.Forms.DataGridView GridUser;
        private System.Windows.Forms.Button btnnuevoTemporal;
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
    }
}