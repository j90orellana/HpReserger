namespace HPReserger.ModuloCompensaciones
{
    partial class frmListarCompensaciones
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmListarCompensaciones));
            this.cboempresa = new System.Windows.Forms.ComboBox();
            this.label18 = new System.Windows.Forms.Label();
            this.dtgconten = new HpResergerUserControls.Dtgconten();
            this.xpkid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xFkEmpresa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xNameTipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xTipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xTipoID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xtipodesc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xNumDoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xcliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xMontoMN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xMontoME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xCuo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xNumPago = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xFechaCompensa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xNameEstado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xEstado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xcuentacontable = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btncancelar = new System.Windows.Forms.Button();
            this.lbltotalregistros = new System.Windows.Forms.Label();
            this.txtbuscarnombre = new HpResergerUserControls.TextBoxPer();
            this.label1 = new System.Windows.Forms.Label();
            this.cbotipoid = new HpResergerUserControls.ComboBoxPer(this.components);
            this.label22 = new System.Windows.Forms.Label();
            this.separadorOre1 = new HpResergerUserControls.SeparadorOre();
            this.label2 = new System.Windows.Forms.Label();
            this.cbocompensa = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtMontoMN = new HpResergerUserControls.TextBoxPer();
            this.label10 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMontoME = new HpResergerUserControls.TextBoxPer();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtRegularMN = new HpResergerUserControls.TextBoxPer();
            this.label7 = new System.Windows.Forms.Label();
            this.txtRegularME = new HpResergerUserControls.TextBoxPer();
            ((System.ComponentModel.ISupportInitialize)(this.dtgconten)).BeginInit();
            this.SuspendLayout();
            // 
            // cboempresa
            // 
            this.cboempresa.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboempresa.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboempresa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(218)))), ((int)(((byte)(231)))));
            this.cboempresa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboempresa.DropDownWidth = 250;
            this.cboempresa.FormattingEnabled = true;
            this.cboempresa.Location = new System.Drawing.Point(70, 12);
            this.cboempresa.Name = "cboempresa";
            this.cboempresa.Size = new System.Drawing.Size(344, 21);
            this.cboempresa.TabIndex = 225;
            this.cboempresa.SelectedIndexChanged += new System.EventHandler(this.cboempresa_SelectedIndexChanged);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.BackColor = System.Drawing.Color.Transparent;
            this.label18.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(14, 15);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(53, 13);
            this.label18.TabIndex = 226;
            this.label18.Text = "Empresa:";
            // 
            // dtgconten
            // 
            this.dtgconten.AllowUserToAddRows = false;
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
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DeepSkyBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgconten.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dtgconten.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgconten.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.xpkid,
            this.xFkEmpresa,
            this.xNameTipo,
            this.xTipo,
            this.xTipoID,
            this.xtipodesc,
            this.xNumDoc,
            this.xcliente,
            this.xMontoMN,
            this.xMontoME,
            this.xCuo,
            this.xNumPago,
            this.xFechaCompensa,
            this.xNameEstado,
            this.xEstado,
            this.xcuentacontable});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(207)))), ((int)(((byte)(241)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgconten.DefaultCellStyle = dataGridViewCellStyle6;
            this.dtgconten.EnableHeadersVisualStyles = false;
            this.dtgconten.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(179)))), ((int)(((byte)(215)))));
            this.dtgconten.Location = new System.Drawing.Point(12, 103);
            this.dtgconten.Name = "dtgconten";
            this.dtgconten.ReadOnly = true;
            this.dtgconten.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dtgconten.RowHeadersVisible = false;
            this.dtgconten.RowTemplate.Height = 18;
            this.dtgconten.Size = new System.Drawing.Size(910, 355);
            this.dtgconten.TabIndex = 227;
            // 
            // xpkid
            // 
            this.xpkid.DataPropertyName = "PkId";
            this.xpkid.HeaderText = "pkid";
            this.xpkid.Name = "xpkid";
            this.xpkid.ReadOnly = true;
            this.xpkid.Visible = false;
            // 
            // xFkEmpresa
            // 
            this.xFkEmpresa.DataPropertyName = "FkEmpresa";
            this.xFkEmpresa.HeaderText = "[FkEmpresa]";
            this.xFkEmpresa.Name = "xFkEmpresa";
            this.xFkEmpresa.ReadOnly = true;
            this.xFkEmpresa.Visible = false;
            // 
            // xNameTipo
            // 
            this.xNameTipo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.xNameTipo.DataPropertyName = "NameTipo";
            this.xNameTipo.HeaderText = "Tipo";
            this.xNameTipo.Name = "xNameTipo";
            this.xNameTipo.ReadOnly = true;
            this.xNameTipo.Width = 55;
            // 
            // xTipo
            // 
            this.xTipo.DataPropertyName = "Tipo";
            this.xTipo.HeaderText = "[Tipo]";
            this.xTipo.Name = "xTipo";
            this.xTipo.ReadOnly = true;
            this.xTipo.Visible = false;
            // 
            // xTipoID
            // 
            this.xTipoID.DataPropertyName = "TipoID";
            this.xTipoID.HeaderText = "[TipoID]";
            this.xTipoID.Name = "xTipoID";
            this.xTipoID.ReadOnly = true;
            this.xTipoID.Visible = false;
            // 
            // xtipodesc
            // 
            this.xtipodesc.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.xtipodesc.DataPropertyName = "tipodesc";
            this.xtipodesc.HeaderText = "TipoDoc";
            this.xtipodesc.Name = "xtipodesc";
            this.xtipodesc.ReadOnly = true;
            this.xtipodesc.Width = 76;
            // 
            // xNumDoc
            // 
            this.xNumDoc.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.xNumDoc.DataPropertyName = "NumDoc";
            this.xNumDoc.HeaderText = "NumDoc";
            this.xNumDoc.Name = "xNumDoc";
            this.xNumDoc.ReadOnly = true;
            this.xNumDoc.Width = 79;
            // 
            // xcliente
            // 
            this.xcliente.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.xcliente.DataPropertyName = "cliente";
            this.xcliente.HeaderText = "Nombres";
            this.xcliente.MinimumWidth = 100;
            this.xcliente.Name = "xcliente";
            this.xcliente.ReadOnly = true;
            // 
            // xMontoMN
            // 
            this.xMontoMN.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.xMontoMN.DataPropertyName = "MontoMN";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.Format = "n2";
            this.xMontoMN.DefaultCellStyle = dataGridViewCellStyle3;
            this.xMontoMN.HeaderText = "MontoMN";
            this.xMontoMN.Name = "xMontoMN";
            this.xMontoMN.ReadOnly = true;
            this.xMontoMN.Width = 87;
            // 
            // xMontoME
            // 
            this.xMontoME.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.xMontoME.DataPropertyName = "MontoME";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle4.Format = "n2";
            this.xMontoME.DefaultCellStyle = dataGridViewCellStyle4;
            this.xMontoME.HeaderText = "MontoME";
            this.xMontoME.Name = "xMontoME";
            this.xMontoME.ReadOnly = true;
            this.xMontoME.Width = 84;
            // 
            // xCuo
            // 
            this.xCuo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.xCuo.DataPropertyName = "Cuo";
            this.xCuo.HeaderText = "Cuo Reg.";
            this.xCuo.Name = "xCuo";
            this.xCuo.ReadOnly = true;
            this.xCuo.Width = 79;
            // 
            // xNumPago
            // 
            this.xNumPago.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.xNumPago.DataPropertyName = "NumPago";
            this.xNumPago.HeaderText = "NumPago";
            this.xNumPago.Name = "xNumPago";
            this.xNumPago.ReadOnly = true;
            this.xNumPago.Visible = false;
            // 
            // xFechaCompensa
            // 
            this.xFechaCompensa.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.xFechaCompensa.DataPropertyName = "FechaCompensa";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.xFechaCompensa.DefaultCellStyle = dataGridViewCellStyle5;
            this.xFechaCompensa.HeaderText = "F.Cmpsa.";
            this.xFechaCompensa.Name = "xFechaCompensa";
            this.xFechaCompensa.ReadOnly = true;
            this.xFechaCompensa.Width = 80;
            // 
            // xNameEstado
            // 
            this.xNameEstado.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.xNameEstado.DataPropertyName = "NameEstado";
            this.xNameEstado.HeaderText = "Estado";
            this.xNameEstado.Name = "xNameEstado";
            this.xNameEstado.ReadOnly = true;
            this.xNameEstado.Width = 66;
            // 
            // xEstado
            // 
            this.xEstado.DataPropertyName = "Estado";
            this.xEstado.HeaderText = "[Estado]";
            this.xEstado.Name = "xEstado";
            this.xEstado.ReadOnly = true;
            this.xEstado.Visible = false;
            // 
            // xcuentacontable
            // 
            this.xcuentacontable.DataPropertyName = "cuentacontable";
            this.xcuentacontable.HeaderText = "Cuentacontable";
            this.xcuentacontable.Name = "xcuentacontable";
            this.xcuentacontable.ReadOnly = true;
            this.xcuentacontable.Visible = false;
            // 
            // btncancelar
            // 
            this.btncancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btncancelar.Image = ((System.Drawing.Image)(resources.GetObject("btncancelar.Image")));
            this.btncancelar.Location = new System.Drawing.Point(847, 464);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(75, 23);
            this.btncancelar.TabIndex = 334;
            this.btncancelar.Text = "Cancelar";
            this.btncancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btncancelar.UseVisualStyleBackColor = true;
            // 
            // lbltotalregistros
            // 
            this.lbltotalregistros.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbltotalregistros.AutoEllipsis = true;
            this.lbltotalregistros.AutoSize = true;
            this.lbltotalregistros.BackColor = System.Drawing.Color.Transparent;
            this.lbltotalregistros.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltotalregistros.Location = new System.Drawing.Point(12, 469);
            this.lbltotalregistros.Name = "lbltotalregistros";
            this.lbltotalregistros.Size = new System.Drawing.Size(104, 13);
            this.lbltotalregistros.TabIndex = 335;
            this.lbltotalregistros.Text = "Total de Registros: ";
            // 
            // txtbuscarnombre
            // 
            this.txtbuscarnombre.BackColor = System.Drawing.Color.White;
            this.txtbuscarnombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtbuscarnombre.ColorFondoMouseEncima = System.Drawing.Color.Empty;
            this.txtbuscarnombre.ColorFondoMousePresionado = System.Drawing.Color.Empty;
            this.txtbuscarnombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbuscarnombre.ForeColor = System.Drawing.Color.Black;
            this.txtbuscarnombre.Format = null;
            this.txtbuscarnombre.Location = new System.Drawing.Point(70, 39);
            this.txtbuscarnombre.MaxLength = 300;
            this.txtbuscarnombre.Name = "txtbuscarnombre";
            this.txtbuscarnombre.NextControlOnEnter = null;
            this.txtbuscarnombre.Size = new System.Drawing.Size(344, 21);
            this.txtbuscarnombre.TabIndex = 343;
            this.txtbuscarnombre.Text = "Buscar Numdoc - Nombres";
            this.txtbuscarnombre.TextoDefecto = "Buscar Numdoc - Nombres";
            this.txtbuscarnombre.TextoDefectoColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(129)))), ((int)(((byte)(189)))));
            this.txtbuscarnombre.TiposDatos = HpResergerUserControls.TextBoxPer.ListaTipos.MayusculaCadaPalabra;
            this.txtbuscarnombre.TextChanged += new System.EventHandler(this.txtbuscarnombre_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 226;
            this.label1.Text = "NumDoc:";
            // 
            // cbotipoid
            // 
            this.cbotipoid.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(218)))), ((int)(((byte)(231)))));
            this.cbotipoid.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbotipoid.FormattingEnabled = true;
            this.cbotipoid.IndexText = null;
            this.cbotipoid.Location = new System.Drawing.Point(70, 63);
            this.cbotipoid.MaxDropDownItems = 10;
            this.cbotipoid.Name = "cbotipoid";
            this.cbotipoid.ReadOnly = false;
            this.cbotipoid.Size = new System.Drawing.Size(344, 21);
            this.cbotipoid.TabIndex = 344;
            this.cbotipoid.SelectedIndexChanged += new System.EventHandler(this.cbotipoid_SelectedIndexChanged);
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.BackColor = System.Drawing.Color.Transparent;
            this.label22.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(12, 67);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(55, 13);
            this.label22.TabIndex = 345;
            this.label22.Text = "Tipo Doc:";
            // 
            // separadorOre1
            // 
            this.separadorOre1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.separadorOre1.BackColor = System.Drawing.Color.Transparent;
            this.separadorOre1.Location = new System.Drawing.Point(-2, 34);
            this.separadorOre1.MaximumSize = new System.Drawing.Size(2000, 2);
            this.separadorOre1.MinimumSize = new System.Drawing.Size(0, 2);
            this.separadorOre1.Name = "separadorOre1";
            this.separadorOre1.Size = new System.Drawing.Size(938, 2);
            this.separadorOre1.TabIndex = 346;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 13);
            this.label2.TabIndex = 345;
            this.label2.Text = "Listado de Compensaciones:";
            // 
            // cbocompensa
            // 
            this.cbocompensa.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbocompensa.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbocompensa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(218)))), ((int)(((byte)(231)))));
            this.cbocompensa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbocompensa.FormattingEnabled = true;
            this.cbocompensa.Location = new System.Drawing.Point(504, 63);
            this.cbocompensa.Name = "cbocompensa";
            this.cbocompensa.Size = new System.Drawing.Size(150, 21);
            this.cbocompensa.TabIndex = 347;
            this.cbocompensa.SelectedIndexChanged += new System.EventHandler(this.cbocompensa_SelectedIndexChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(419, 67);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(86, 13);
            this.label12.TabIndex = 348;
            this.label12.Text = "Compensación:";
            // 
            // txtMontoMN
            // 
            this.txtMontoMN.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMontoMN.BackColor = System.Drawing.Color.White;
            this.txtMontoMN.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMontoMN.ColorFondoMouseEncima = System.Drawing.Color.Empty;
            this.txtMontoMN.ColorFondoMousePresionado = System.Drawing.Color.Empty;
            this.txtMontoMN.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMontoMN.ForeColor = System.Drawing.Color.Black;
            this.txtMontoMN.Format = "n2";
            this.txtMontoMN.Location = new System.Drawing.Point(645, 470);
            this.txtMontoMN.MaxLength = 20;
            this.txtMontoMN.Name = "txtMontoMN";
            this.txtMontoMN.NextControlOnEnter = null;
            this.txtMontoMN.Size = new System.Drawing.Size(85, 21);
            this.txtMontoMN.TabIndex = 395;
            this.txtMontoMN.Text = "0.00";
            this.txtMontoMN.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtMontoMN.TextoDefecto = "0.00";
            this.txtMontoMN.TextoDefectoColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(129)))), ((int)(((byte)(189)))));
            this.txtMontoMN.TiposDatos = HpResergerUserControls.TextBoxPer.ListaTipos.SoloDinero;
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(617, 474);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(28, 13);
            this.label10.TabIndex = 396;
            this.label10.Text = "MN:";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(730, 474);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 396;
            this.label3.Text = "ME:";
            // 
            // txtMontoME
            // 
            this.txtMontoME.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMontoME.BackColor = System.Drawing.Color.White;
            this.txtMontoME.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMontoME.ColorFondoMouseEncima = System.Drawing.Color.Empty;
            this.txtMontoME.ColorFondoMousePresionado = System.Drawing.Color.Empty;
            this.txtMontoME.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMontoME.ForeColor = System.Drawing.Color.Black;
            this.txtMontoME.Format = "n2";
            this.txtMontoME.Location = new System.Drawing.Point(756, 470);
            this.txtMontoME.MaxLength = 20;
            this.txtMontoME.Name = "txtMontoME";
            this.txtMontoME.NextControlOnEnter = null;
            this.txtMontoME.Size = new System.Drawing.Size(85, 21);
            this.txtMontoME.TabIndex = 395;
            this.txtMontoME.Text = "0.00";
            this.txtMontoME.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtMontoME.TextoDefecto = "0.00";
            this.txtMontoME.TextoDefectoColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(129)))), ((int)(((byte)(189)))));
            this.txtMontoME.TiposDatos = HpResergerUserControls.TextBoxPer.ListaTipos.SoloDinero;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoEllipsis = true;
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(673, 458);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 13);
            this.label4.TabIndex = 335;
            this.label4.Text = "Totales Por Regularizar";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoEllipsis = true;
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(457, 458);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 13);
            this.label5.TabIndex = 335;
            this.label5.Text = "Total Regularizados";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(387, 474);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(28, 13);
            this.label6.TabIndex = 396;
            this.label6.Text = "MN:";
            // 
            // txtRegularMN
            // 
            this.txtRegularMN.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtRegularMN.BackColor = System.Drawing.Color.White;
            this.txtRegularMN.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRegularMN.ColorFondoMouseEncima = System.Drawing.Color.Empty;
            this.txtRegularMN.ColorFondoMousePresionado = System.Drawing.Color.Empty;
            this.txtRegularMN.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRegularMN.ForeColor = System.Drawing.Color.Black;
            this.txtRegularMN.Format = "n2";
            this.txtRegularMN.Location = new System.Drawing.Point(415, 470);
            this.txtRegularMN.MaxLength = 20;
            this.txtRegularMN.Name = "txtRegularMN";
            this.txtRegularMN.NextControlOnEnter = null;
            this.txtRegularMN.Size = new System.Drawing.Size(85, 21);
            this.txtRegularMN.TabIndex = 395;
            this.txtRegularMN.Text = "0.00";
            this.txtRegularMN.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtRegularMN.TextoDefecto = "0.00";
            this.txtRegularMN.TextoDefectoColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(129)))), ((int)(((byte)(189)))));
            this.txtRegularMN.TiposDatos = HpResergerUserControls.TextBoxPer.ListaTipos.SoloDinero;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(500, 474);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(26, 13);
            this.label7.TabIndex = 396;
            this.label7.Text = "ME:";
            // 
            // txtRegularME
            // 
            this.txtRegularME.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtRegularME.BackColor = System.Drawing.Color.White;
            this.txtRegularME.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRegularME.ColorFondoMouseEncima = System.Drawing.Color.Empty;
            this.txtRegularME.ColorFondoMousePresionado = System.Drawing.Color.Empty;
            this.txtRegularME.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRegularME.ForeColor = System.Drawing.Color.Black;
            this.txtRegularME.Format = "n2";
            this.txtRegularME.Location = new System.Drawing.Point(526, 470);
            this.txtRegularME.MaxLength = 20;
            this.txtRegularME.Name = "txtRegularME";
            this.txtRegularME.NextControlOnEnter = null;
            this.txtRegularME.Size = new System.Drawing.Size(85, 21);
            this.txtRegularME.TabIndex = 395;
            this.txtRegularME.Text = "0.00";
            this.txtRegularME.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtRegularME.TextoDefecto = "0.00";
            this.txtRegularME.TextoDefectoColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(129)))), ((int)(((byte)(189)))));
            this.txtRegularME.TiposDatos = HpResergerUserControls.TextBoxPer.ListaTipos.SoloDinero;
            // 
            // frmListarCompensaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 493);
            this.Controls.Add(this.txtRegularME);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtMontoME);
            this.Controls.Add(this.txtRegularMN);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtMontoMN);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.cbocompensa);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.separadorOre1);
            this.Controls.Add(this.cbotipoid);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtbuscarnombre);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbltotalregistros);
            this.Controls.Add(this.btncancelar);
            this.Controls.Add(this.dtgconten);
            this.Controls.Add(this.cboempresa);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label18);
            this.MinimumSize = new System.Drawing.Size(950, 532);
            this.Name = "frmListarCompensaciones";
            this.Nombre = "Listado de Compensaciones";
            this.Text = "Listado de Compensaciones";
            this.Load += new System.EventHandler(this.frmListarCompensaciones_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgconten)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboempresa;
        private System.Windows.Forms.Label label18;
        private HpResergerUserControls.Dtgconten dtgconten;
        private System.Windows.Forms.Button btncancelar;
        private System.Windows.Forms.Label lbltotalregistros;
        private HpResergerUserControls.TextBoxPer txtbuscarnombre;
        private System.Windows.Forms.Label label1;
        private HpResergerUserControls.ComboBoxPer cbotipoid;
        private System.Windows.Forms.Label label22;
        private HpResergerUserControls.SeparadorOre separadorOre1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbocompensa;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DataGridViewTextBoxColumn xpkid;
        private System.Windows.Forms.DataGridViewTextBoxColumn xFkEmpresa;
        private System.Windows.Forms.DataGridViewTextBoxColumn xNameTipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn xTipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn xTipoID;
        private System.Windows.Forms.DataGridViewTextBoxColumn xtipodesc;
        private System.Windows.Forms.DataGridViewTextBoxColumn xNumDoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn xcliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn xMontoMN;
        private System.Windows.Forms.DataGridViewTextBoxColumn xMontoME;
        private System.Windows.Forms.DataGridViewTextBoxColumn xCuo;
        private System.Windows.Forms.DataGridViewTextBoxColumn xNumPago;
        private System.Windows.Forms.DataGridViewTextBoxColumn xFechaCompensa;
        private System.Windows.Forms.DataGridViewTextBoxColumn xNameEstado;
        private System.Windows.Forms.DataGridViewTextBoxColumn xEstado;
        private System.Windows.Forms.DataGridViewTextBoxColumn xcuentacontable;
        private HpResergerUserControls.TextBoxPer txtMontoMN;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label3;
        private HpResergerUserControls.TextBoxPer txtMontoME;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private HpResergerUserControls.TextBoxPer txtRegularMN;
        private System.Windows.Forms.Label label7;
        private HpResergerUserControls.TextBoxPer txtRegularME;
    }
}