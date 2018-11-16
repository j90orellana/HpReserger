namespace HPReserger
{
    partial class frmVendedores
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVendedores));
            this.label13 = new System.Windows.Forms.Label();
            this.txtnumven = new HpResergerUserControls.TextBoxPer();
            this.label2 = new System.Windows.Forms.Label();
            this.cboestado = new HpResergerUserControls.ComboBoxPer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.cbotipoid = new HpResergerUserControls.ComboBoxPer(this.components);
            this.txtnroid = new HpResergerUserControls.TextBoxPer();
            this.label3 = new System.Windows.Forms.Label();
            this.txtnombre = new HpResergerUserControls.TextBoxPer();
            this.label4 = new System.Windows.Forms.Label();
            this.txtapellido = new HpResergerUserControls.TextBoxPer();
            this.label5 = new System.Windows.Forms.Label();
            this.txtgerencia = new HpResergerUserControls.TextBoxPer();
            this.label6 = new System.Windows.Forms.Label();
            this.txtarea = new HpResergerUserControls.TextBoxPer();
            this.label7 = new System.Windows.Forms.Label();
            this.txtcargo = new HpResergerUserControls.TextBoxPer();
            this.label8 = new System.Windows.Forms.Label();
            this.separadorOre1 = new HpResergerUserControls.SeparadorOre();
            this.dtgconten = new HpResergerUserControls.Dtgconten();
            this.idvend = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nroid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombres = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellidos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gerencia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cargo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.area = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estadox = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estadoletras = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblmsg = new System.Windows.Forms.Label();
            this.btncancelar = new System.Windows.Forms.Button();
            this.btnaceptar = new System.Windows.Forms.Button();
            this.btnmodificar = new System.Windows.Forms.Button();
            this.btnnuevo = new System.Windows.Forms.Button();
            this.btnbuscar = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgconten)).BeginInit();
            this.SuspendLayout();
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Location = new System.Drawing.Point(589, 16);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(60, 13);
            this.label13.TabIndex = 143;
            this.label13.Text = "Cod.Vend.";
            // 
            // txtnumven
            // 
            this.txtnumven.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(218)))), ((int)(((byte)(231)))));
            this.txtnumven.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtnumven.ColorFondoMouseEncima = System.Drawing.Color.Empty;
            this.txtnumven.ColorFondoMousePresionado = System.Drawing.Color.Empty;
            this.txtnumven.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnumven.ForeColor = System.Drawing.Color.Black;
            this.txtnumven.Location = new System.Drawing.Point(655, 12);
            this.txtnumven.MaxLength = 10;
            this.txtnumven.Name = "txtnumven";
            this.txtnumven.NextControlOnEnter = null;
            this.txtnumven.ReadOnly = true;
            this.txtnumven.Size = new System.Drawing.Size(80, 21);
            this.txtnumven.TabIndex = 142;
            this.txtnumven.Text = "0000";
            this.txtnumven.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtnumven.TextoDefecto = "0000";
            this.txtnumven.TextoDefectoColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(129)))), ((int)(((byte)(189)))));
            this.txtnumven.TiposDatos = HpResergerUserControls.TextBoxPer.ListaTipos.SoloNumeros;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(563, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 145;
            this.label2.Text = "Estado:";
            // 
            // cboestado
            // 
            this.cboestado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(218)))), ((int)(((byte)(231)))));
            this.cboestado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboestado.Enabled = false;
            this.cboestado.FormattingEnabled = true;
            this.cboestado.Location = new System.Drawing.Point(613, 37);
            this.cboestado.Name = "cboestado";
            this.cboestado.Size = new System.Drawing.Size(122, 21);
            this.cboestado.TabIndex = 144;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(26, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 149;
            this.label1.Text = "Tipo Id";
            // 
            // cbotipoid
            // 
            this.cbotipoid.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(218)))), ((int)(((byte)(231)))));
            this.cbotipoid.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbotipoid.Enabled = false;
            this.cbotipoid.FormattingEnabled = true;
            this.cbotipoid.Location = new System.Drawing.Point(71, 37);
            this.cbotipoid.Name = "cbotipoid";
            this.cbotipoid.Size = new System.Drawing.Size(223, 21);
            this.cbotipoid.TabIndex = 148;
            this.cbotipoid.SelectedIndexChanged += new System.EventHandler(this.cbotipoid_SelectedIndexChanged);
            this.cbotipoid.Click += new System.EventHandler(this.cbotipoid_Click);
            // 
            // txtnroid
            // 
            this.txtnroid.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(218)))), ((int)(((byte)(231)))));
            this.txtnroid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtnroid.ColorFondoMouseEncima = System.Drawing.Color.Empty;
            this.txtnroid.ColorFondoMousePresionado = System.Drawing.Color.Empty;
            this.txtnroid.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnroid.ForeColor = System.Drawing.Color.Black;
            this.txtnroid.Location = new System.Drawing.Point(380, 37);
            this.txtnroid.MaxLength = 10;
            this.txtnroid.Name = "txtnroid";
            this.txtnroid.NextControlOnEnter = null;
            this.txtnroid.ReadOnly = true;
            this.txtnroid.Size = new System.Drawing.Size(151, 21);
            this.txtnroid.TabIndex = 146;
            this.txtnroid.Text = "00000000";
            this.txtnroid.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtnroid.TextoDefecto = "00000000";
            this.txtnroid.TextoDefectoColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(129)))), ((int)(((byte)(189)))));
            this.txtnroid.TiposDatos = HpResergerUserControls.TextBoxPer.ListaTipos.SoloNumeros;
            this.txtnroid.TextChanged += new System.EventHandler(this.txtnroid_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(336, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 147;
            this.label3.Text = "Nro Id";
            // 
            // txtnombre
            // 
            this.txtnombre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(218)))), ((int)(((byte)(231)))));
            this.txtnombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtnombre.ColorFondoMouseEncima = System.Drawing.Color.Empty;
            this.txtnombre.ColorFondoMousePresionado = System.Drawing.Color.Empty;
            this.txtnombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnombre.ForeColor = System.Drawing.Color.Black;
            this.txtnombre.Location = new System.Drawing.Point(71, 61);
            this.txtnombre.MaxLength = 100;
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.NextControlOnEnter = null;
            this.txtnombre.ReadOnly = true;
            this.txtnombre.Size = new System.Drawing.Size(223, 21);
            this.txtnombre.TabIndex = 150;
            this.txtnombre.Text = "Nombre Vendedor";
            this.txtnombre.TextoDefecto = "Nombre Vendedor";
            this.txtnombre.TextoDefectoColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(129)))), ((int)(((byte)(189)))));
            this.txtnombre.TiposDatos = HpResergerUserControls.TextBoxPer.ListaTipos.MayusculaCadaPalabra;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(17, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 151;
            this.label4.Text = "Nombres";
            // 
            // txtapellido
            // 
            this.txtapellido.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(218)))), ((int)(((byte)(231)))));
            this.txtapellido.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtapellido.ColorFondoMouseEncima = System.Drawing.Color.Empty;
            this.txtapellido.ColorFondoMousePresionado = System.Drawing.Color.Empty;
            this.txtapellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtapellido.ForeColor = System.Drawing.Color.Black;
            this.txtapellido.Location = new System.Drawing.Point(380, 61);
            this.txtapellido.MaxLength = 100;
            this.txtapellido.Name = "txtapellido";
            this.txtapellido.NextControlOnEnter = null;
            this.txtapellido.ReadOnly = true;
            this.txtapellido.Size = new System.Drawing.Size(355, 21);
            this.txtapellido.TabIndex = 152;
            this.txtapellido.Text = "Apellidos Vendedor";
            this.txtapellido.TextoDefecto = "Apellidos Vendedor";
            this.txtapellido.TextoDefectoColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(129)))), ((int)(((byte)(189)))));
            this.txtapellido.TiposDatos = HpResergerUserControls.TextBoxPer.ListaTipos.MayusculaCadaPalabra;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(320, 65);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 153;
            this.label5.Text = "Apellidos";
            // 
            // txtgerencia
            // 
            this.txtgerencia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(218)))), ((int)(((byte)(231)))));
            this.txtgerencia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtgerencia.ColorFondoMouseEncima = System.Drawing.Color.Empty;
            this.txtgerencia.ColorFondoMousePresionado = System.Drawing.Color.Empty;
            this.txtgerencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtgerencia.ForeColor = System.Drawing.Color.Black;
            this.txtgerencia.Location = new System.Drawing.Point(71, 84);
            this.txtgerencia.MaxLength = 100;
            this.txtgerencia.Name = "txtgerencia";
            this.txtgerencia.NextControlOnEnter = null;
            this.txtgerencia.ReadOnly = true;
            this.txtgerencia.Size = new System.Drawing.Size(183, 21);
            this.txtgerencia.TabIndex = 154;
            this.txtgerencia.Text = "Gerencia Vendedor";
            this.txtgerencia.TextoDefecto = "Gerencia Vendedor";
            this.txtgerencia.TextoDefectoColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(129)))), ((int)(((byte)(189)))));
            this.txtgerencia.TiposDatos = HpResergerUserControls.TextBoxPer.ListaTipos.MayusculaCadaPalabra;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(13, 88);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 155;
            this.label6.Text = "Gerencia:";
            // 
            // txtarea
            // 
            this.txtarea.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(218)))), ((int)(((byte)(231)))));
            this.txtarea.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtarea.ColorFondoMouseEncima = System.Drawing.Color.Empty;
            this.txtarea.ColorFondoMousePresionado = System.Drawing.Color.Empty;
            this.txtarea.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtarea.ForeColor = System.Drawing.Color.Black;
            this.txtarea.Location = new System.Drawing.Point(293, 84);
            this.txtarea.MaxLength = 100;
            this.txtarea.Name = "txtarea";
            this.txtarea.NextControlOnEnter = null;
            this.txtarea.ReadOnly = true;
            this.txtarea.Size = new System.Drawing.Size(153, 21);
            this.txtarea.TabIndex = 156;
            this.txtarea.Text = "Area Vendedor";
            this.txtarea.TextoDefecto = "Area Vendedor";
            this.txtarea.TextoDefectoColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(129)))), ((int)(((byte)(189)))));
            this.txtarea.TiposDatos = HpResergerUserControls.TextBoxPer.ListaTipos.MayusculaCadaPalabra;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Location = new System.Drawing.Point(260, 88);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(33, 13);
            this.label7.TabIndex = 157;
            this.label7.Text = "Area:";
            // 
            // txtcargo
            // 
            this.txtcargo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(218)))), ((int)(((byte)(231)))));
            this.txtcargo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtcargo.ColorFondoMouseEncima = System.Drawing.Color.Empty;
            this.txtcargo.ColorFondoMousePresionado = System.Drawing.Color.Empty;
            this.txtcargo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcargo.ForeColor = System.Drawing.Color.Black;
            this.txtcargo.Location = new System.Drawing.Point(493, 84);
            this.txtcargo.MaxLength = 100;
            this.txtcargo.Name = "txtcargo";
            this.txtcargo.NextControlOnEnter = null;
            this.txtcargo.ReadOnly = true;
            this.txtcargo.Size = new System.Drawing.Size(242, 21);
            this.txtcargo.TabIndex = 158;
            this.txtcargo.Text = "Cargo Vendedor";
            this.txtcargo.TextoDefecto = "Cargo Vendedor";
            this.txtcargo.TextoDefectoColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(129)))), ((int)(((byte)(189)))));
            this.txtcargo.TiposDatos = HpResergerUserControls.TextBoxPer.ListaTipos.MayusculaCadaPalabra;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Location = new System.Drawing.Point(451, 88);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 13);
            this.label8.TabIndex = 159;
            this.label8.Text = "Cargo:";
            // 
            // separadorOre1
            // 
            this.separadorOre1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.separadorOre1.Location = new System.Drawing.Point(0, 108);
            this.separadorOre1.MaximumSize = new System.Drawing.Size(2000, 2);
            this.separadorOre1.MinimumSize = new System.Drawing.Size(0, 2);
            this.separadorOre1.Name = "separadorOre1";
            this.separadorOre1.Size = new System.Drawing.Size(864, 2);
            this.separadorOre1.TabIndex = 160;
            // 
            // dtgconten
            // 
            this.dtgconten.AllowUserToAddRows = false;
            this.dtgconten.AllowUserToDeleteRows = false;
            this.dtgconten.AllowUserToResizeColumns = false;
            this.dtgconten.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(230)))), ((int)(((byte)(241)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(191)))), ((int)(((byte)(231)))));
            this.dtgconten.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgconten.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgconten.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgconten.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(218)))), ((int)(((byte)(231)))));
            this.dtgconten.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgconten.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.dtgconten.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(129)))), ((int)(((byte)(189)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DeepSkyBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgconten.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dtgconten.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dtgconten.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idvend,
            this.tipoid,
            this.nroid,
            this.nombres,
            this.apellidos,
            this.gerencia,
            this.cargo,
            this.area,
            this.estadox,
            this.estadoletras});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(207)))), ((int)(((byte)(241)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgconten.DefaultCellStyle = dataGridViewCellStyle4;
            this.dtgconten.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dtgconten.EnableHeadersVisualStyles = false;
            this.dtgconten.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(179)))), ((int)(((byte)(215)))));
            this.dtgconten.Location = new System.Drawing.Point(15, 128);
            this.dtgconten.Name = "dtgconten";
            this.dtgconten.ReadOnly = true;
            this.dtgconten.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dtgconten.RowHeadersVisible = false;
            this.dtgconten.RowTemplate.Height = 18;
            this.dtgconten.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgconten.Size = new System.Drawing.Size(808, 289);
            this.dtgconten.TabIndex = 161;
            this.dtgconten.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgconten_RowEnter);
            // 
            // idvend
            // 
            this.idvend.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.idvend.DataPropertyName = "idvend";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.Format = "0000";
            this.idvend.DefaultCellStyle = dataGridViewCellStyle3;
            this.idvend.HeaderText = "CodVend.";
            this.idvend.Name = "idvend";
            this.idvend.ReadOnly = true;
            this.idvend.Width = 81;
            // 
            // tipoid
            // 
            this.tipoid.DataPropertyName = "tipoid";
            this.tipoid.HeaderText = "tipoid";
            this.tipoid.Name = "tipoid";
            this.tipoid.ReadOnly = true;
            this.tipoid.Visible = false;
            // 
            // nroid
            // 
            this.nroid.DataPropertyName = "nroid";
            this.nroid.HeaderText = "nroid";
            this.nroid.Name = "nroid";
            this.nroid.ReadOnly = true;
            this.nroid.Visible = false;
            // 
            // nombres
            // 
            this.nombres.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nombres.DataPropertyName = "nombres";
            this.nombres.HeaderText = "Nombres";
            this.nombres.MinimumWidth = 150;
            this.nombres.Name = "nombres";
            this.nombres.ReadOnly = true;
            // 
            // apellidos
            // 
            this.apellidos.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.apellidos.DataPropertyName = "apellido";
            this.apellidos.HeaderText = "Apellidos";
            this.apellidos.MinimumWidth = 200;
            this.apellidos.Name = "apellidos";
            this.apellidos.ReadOnly = true;
            this.apellidos.Width = 200;
            // 
            // gerencia
            // 
            this.gerencia.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.gerencia.DataPropertyName = "gerencia";
            this.gerencia.HeaderText = "Gerencia";
            this.gerencia.Name = "gerencia";
            this.gerencia.ReadOnly = true;
            this.gerencia.Width = 76;
            // 
            // cargo
            // 
            this.cargo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.cargo.DataPropertyName = "cargo";
            this.cargo.HeaderText = "Cargo";
            this.cargo.Name = "cargo";
            this.cargo.ReadOnly = true;
            this.cargo.Width = 62;
            // 
            // area
            // 
            this.area.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.area.DataPropertyName = "area";
            this.area.HeaderText = "Área";
            this.area.Name = "area";
            this.area.ReadOnly = true;
            this.area.Width = 54;
            // 
            // estadox
            // 
            this.estadox.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.estadox.DataPropertyName = "estado";
            this.estadox.HeaderText = "Estado";
            this.estadox.Name = "estadox";
            this.estadox.ReadOnly = true;
            this.estadox.Visible = false;
            // 
            // estadoletras
            // 
            this.estadoletras.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.estadoletras.DataPropertyName = "estadoletras";
            this.estadoletras.HeaderText = "Estado";
            this.estadoletras.Name = "estadoletras";
            this.estadoletras.ReadOnly = true;
            this.estadoletras.Width = 66;
            // 
            // lblmsg
            // 
            this.lblmsg.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblmsg.AutoSize = true;
            this.lblmsg.BackColor = System.Drawing.Color.Transparent;
            this.lblmsg.Location = new System.Drawing.Point(9, 428);
            this.lblmsg.Name = "lblmsg";
            this.lblmsg.Size = new System.Drawing.Size(113, 13);
            this.lblmsg.TabIndex = 162;
            this.lblmsg.Text = "Total de Registros : 0";
            // 
            // btncancelar
            // 
            this.btncancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btncancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btncancelar.Image = ((System.Drawing.Image)(resources.GetObject("btncancelar.Image")));
            this.btncancelar.Location = new System.Drawing.Point(741, 423);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(82, 23);
            this.btncancelar.TabIndex = 164;
            this.btncancelar.Text = "Cancelar";
            this.btncancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btncancelar.UseVisualStyleBackColor = true;
            this.btncancelar.Click += new System.EventHandler(this.btncancelar_Click);
            // 
            // btnaceptar
            // 
            this.btnaceptar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnaceptar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnaceptar.Enabled = false;
            this.btnaceptar.Image = ((System.Drawing.Image)(resources.GetObject("btnaceptar.Image")));
            this.btnaceptar.Location = new System.Drawing.Point(650, 423);
            this.btnaceptar.Name = "btnaceptar";
            this.btnaceptar.Size = new System.Drawing.Size(82, 23);
            this.btnaceptar.TabIndex = 163;
            this.btnaceptar.Text = "Aceptar";
            this.btnaceptar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnaceptar.UseVisualStyleBackColor = true;
            this.btnaceptar.Click += new System.EventHandler(this.btnaceptar_Click);
            // 
            // btnmodificar
            // 
            this.btnmodificar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnmodificar.BackColor = System.Drawing.SystemColors.Control;
            this.btnmodificar.Enabled = false;
            this.btnmodificar.ForeColor = System.Drawing.Color.Black;
            this.btnmodificar.Image = ((System.Drawing.Image)(resources.GetObject("btnmodificar.Image")));
            this.btnmodificar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnmodificar.Location = new System.Drawing.Point(741, 82);
            this.btnmodificar.Name = "btnmodificar";
            this.btnmodificar.Size = new System.Drawing.Size(82, 24);
            this.btnmodificar.TabIndex = 166;
            this.btnmodificar.Text = "Modificar";
            this.btnmodificar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnmodificar.UseVisualStyleBackColor = true;
            this.btnmodificar.Click += new System.EventHandler(this.btnmodificar_Click);
            // 
            // btnnuevo
            // 
            this.btnnuevo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnnuevo.BackColor = System.Drawing.SystemColors.Control;
            this.btnnuevo.ForeColor = System.Drawing.Color.Black;
            this.btnnuevo.Image = ((System.Drawing.Image)(resources.GetObject("btnnuevo.Image")));
            this.btnnuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnnuevo.Location = new System.Drawing.Point(741, 59);
            this.btnnuevo.Name = "btnnuevo";
            this.btnnuevo.Size = new System.Drawing.Size(82, 24);
            this.btnnuevo.TabIndex = 165;
            this.btnnuevo.Text = "Nuevo";
            this.btnnuevo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnnuevo.UseVisualStyleBackColor = true;
            this.btnnuevo.Click += new System.EventHandler(this.btnnuevo_Click);
            // 
            // btnbuscar
            // 
            this.btnbuscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnbuscar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnbuscar.BackgroundImage")));
            this.btnbuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnbuscar.Enabled = false;
            this.btnbuscar.Location = new System.Drawing.Point(537, 37);
            this.btnbuscar.Name = "btnbuscar";
            this.btnbuscar.Size = new System.Drawing.Size(21, 21);
            this.btnbuscar.TabIndex = 167;
            this.btnbuscar.UseVisualStyleBackColor = true;
            this.btnbuscar.Click += new System.EventHandler(this.btnbuscar_Click);
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(12, 16);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(123, 13);
            this.label9.TabIndex = 168;
            this.label9.Text = "Datos del Vendedor:";
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(12, 113);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(141, 13);
            this.label10.TabIndex = 168;
            this.label10.Text = "Listado de Vendedores:";
            // 
            // frmVendedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(835, 454);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnbuscar);
            this.Controls.Add(this.btnmodificar);
            this.Controls.Add(this.btnnuevo);
            this.Controls.Add(this.btncancelar);
            this.Controls.Add(this.btnaceptar);
            this.Controls.Add(this.lblmsg);
            this.Controls.Add(this.dtgconten);
            this.Controls.Add(this.separadorOre1);
            this.Controls.Add(this.txtcargo);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtarea);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtgerencia);
            this.Controls.Add(this.txtapellido);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtnombre);
            this.Controls.Add(this.cbotipoid);
            this.Controls.Add(this.txtnroid);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cboestado);
            this.Controls.Add(this.txtnumven);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label13);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinimumSize = new System.Drawing.Size(851, 493);
            this.Name = "frmVendedores";
            this.Nombre = "Vendedores";
            this.Text = "Vendedores";
            this.Load += new System.EventHandler(this.frmVendedores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgconten)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label13;
        private HpResergerUserControls.TextBoxPer txtnumven;
        private System.Windows.Forms.Label label2;
        private HpResergerUserControls.ComboBoxPer cboestado;
        private System.Windows.Forms.Label label1;
        private HpResergerUserControls.ComboBoxPer cbotipoid;
        private HpResergerUserControls.TextBoxPer txtnroid;
        private System.Windows.Forms.Label label3;
        private HpResergerUserControls.TextBoxPer txtnombre;
        private System.Windows.Forms.Label label4;
        private HpResergerUserControls.TextBoxPer txtapellido;
        private System.Windows.Forms.Label label5;
        private HpResergerUserControls.TextBoxPer txtgerencia;
        private System.Windows.Forms.Label label6;
        private HpResergerUserControls.TextBoxPer txtarea;
        private System.Windows.Forms.Label label7;
        private HpResergerUserControls.TextBoxPer txtcargo;
        private System.Windows.Forms.Label label8;
        private HpResergerUserControls.SeparadorOre separadorOre1;
        private HpResergerUserControls.Dtgconten dtgconten;
        private System.Windows.Forms.Label lblmsg;
        private System.Windows.Forms.Button btncancelar;
        private System.Windows.Forms.Button btnaceptar;
        private System.Windows.Forms.Button btnmodificar;
        private System.Windows.Forms.Button btnnuevo;
        private System.Windows.Forms.Button btnbuscar;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridViewTextBoxColumn idvend;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoid;
        private System.Windows.Forms.DataGridViewTextBoxColumn nroid;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombres;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellidos;
        private System.Windows.Forms.DataGridViewTextBoxColumn gerencia;
        private System.Windows.Forms.DataGridViewTextBoxColumn cargo;
        private System.Windows.Forms.DataGridViewTextBoxColumn area;
        private System.Windows.Forms.DataGridViewTextBoxColumn estadox;
        private System.Windows.Forms.DataGridViewTextBoxColumn estadoletras;
    }
}