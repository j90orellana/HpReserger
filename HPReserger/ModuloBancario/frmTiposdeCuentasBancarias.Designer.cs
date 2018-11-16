namespace HPReserger.ModuloBancario
{
    partial class frmTiposdeCuentasBancarias
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTiposdeCuentasBancarias));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnaceptar = new System.Windows.Forms.Button();
            this.btncancelar = new System.Windows.Forms.Button();
            this.btneliminar = new System.Windows.Forms.Button();
            this.btnmodificar = new System.Windows.Forms.Button();
            this.btnnuevo = new System.Windows.Forms.Button();
            this.dtgconten = new HpResergerUserControls.Dtgconten();
            this.xId_Tipo_Cta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xideempresa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xEmpresa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xidbanco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xBanco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xidmoneda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xMoneda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xTipo_Cta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xtipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xNro_Cta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xNro_Cta_Cci = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xFecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblmsg = new System.Windows.Forms.Label();
            this.gppanel = new HpResergerUserControls.PanelOre();
            this.cbomoneda = new HpResergerUserControls.ComboBoxPer(this.components);
            this.cbotipocuenta = new HpResergerUserControls.ComboBoxPer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.cbobanco = new HpResergerUserControls.ComboBoxPer(this.components);
            this.cboempresa = new HpResergerUserControls.ComboBoxPer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.txtnrocci = new HpResergerUserControls.TextBoxPer();
            this.txtnrocuenta = new HpResergerUserControls.TextBoxPer();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgconten)).BeginInit();
            this.gppanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnaceptar
            // 
            this.btnaceptar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnaceptar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(129)))), ((int)(((byte)(189)))));
            this.btnaceptar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnaceptar.Enabled = false;
            this.btnaceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnaceptar.ForeColor = System.Drawing.Color.White;
            this.btnaceptar.Image = ((System.Drawing.Image)(resources.GetObject("btnaceptar.Image")));
            this.btnaceptar.Location = new System.Drawing.Point(759, 493);
            this.btnaceptar.Name = "btnaceptar";
            this.btnaceptar.Size = new System.Drawing.Size(82, 25);
            this.btnaceptar.TabIndex = 229;
            this.btnaceptar.Text = "Aceptar";
            this.btnaceptar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnaceptar.UseVisualStyleBackColor = false;
            this.btnaceptar.Click += new System.EventHandler(this.btnaceptar_Click);
            // 
            // btncancelar
            // 
            this.btncancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btncancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btncancelar.Image = ((System.Drawing.Image)(resources.GetObject("btncancelar.Image")));
            this.btncancelar.Location = new System.Drawing.Point(847, 493);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(82, 25);
            this.btncancelar.TabIndex = 230;
            this.btncancelar.Text = "Cancelar";
            this.btncancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btncancelar.UseVisualStyleBackColor = true;
            this.btncancelar.Click += new System.EventHandler(this.btncancelar_Click);
            // 
            // btneliminar
            // 
            this.btneliminar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btneliminar.Enabled = false;
            this.btneliminar.Image = ((System.Drawing.Image)(resources.GetObject("btneliminar.Image")));
            this.btneliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btneliminar.Location = new System.Drawing.Point(847, 56);
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Size = new System.Drawing.Size(82, 24);
            this.btneliminar.TabIndex = 232;
            this.btneliminar.Text = "Eliminar";
            this.btneliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btneliminar.UseVisualStyleBackColor = true;
            // 
            // btnmodificar
            // 
            this.btnmodificar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnmodificar.Enabled = false;
            this.btnmodificar.Image = ((System.Drawing.Image)(resources.GetObject("btnmodificar.Image")));
            this.btnmodificar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnmodificar.Location = new System.Drawing.Point(847, 31);
            this.btnmodificar.Name = "btnmodificar";
            this.btnmodificar.Size = new System.Drawing.Size(82, 24);
            this.btnmodificar.TabIndex = 233;
            this.btnmodificar.Text = "Modificar";
            this.btnmodificar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnmodificar.UseVisualStyleBackColor = true;
            this.btnmodificar.Click += new System.EventHandler(this.btnmodificar_Click);
            // 
            // btnnuevo
            // 
            this.btnnuevo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnnuevo.Image = ((System.Drawing.Image)(resources.GetObject("btnnuevo.Image")));
            this.btnnuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnnuevo.Location = new System.Drawing.Point(847, 7);
            this.btnnuevo.Name = "btnnuevo";
            this.btnnuevo.Size = new System.Drawing.Size(82, 24);
            this.btnnuevo.TabIndex = 231;
            this.btnnuevo.Text = "Nuevo";
            this.btnnuevo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnnuevo.UseVisualStyleBackColor = true;
            this.btnnuevo.Click += new System.EventHandler(this.btnnuevo_Click);
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
            this.xId_Tipo_Cta,
            this.xideempresa,
            this.xEmpresa,
            this.xidbanco,
            this.xBanco,
            this.xidmoneda,
            this.xMoneda,
            this.xTipo_Cta,
            this.xtipo,
            this.xNro_Cta,
            this.xNro_Cta_Cci,
            this.xUsuario,
            this.xFecha});
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(207)))), ((int)(((byte)(241)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgconten.DefaultCellStyle = dataGridViewCellStyle7;
            this.dtgconten.EnableHeadersVisualStyles = false;
            this.dtgconten.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(179)))), ((int)(((byte)(215)))));
            this.dtgconten.Location = new System.Drawing.Point(12, 86);
            this.dtgconten.Name = "dtgconten";
            this.dtgconten.ReadOnly = true;
            this.dtgconten.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dtgconten.RowHeadersVisible = false;
            this.dtgconten.RowTemplate.Height = 18;
            this.dtgconten.Size = new System.Drawing.Size(917, 401);
            this.dtgconten.TabIndex = 234;
            this.dtgconten.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgconten_RowEnter);
            // 
            // xId_Tipo_Cta
            // 
            this.xId_Tipo_Cta.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.xId_Tipo_Cta.DataPropertyName = "Id_Tipo_Cta";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.Format = "00";
            this.xId_Tipo_Cta.DefaultCellStyle = dataGridViewCellStyle3;
            this.xId_Tipo_Cta.HeaderText = "Id";
            this.xId_Tipo_Cta.MinimumWidth = 45;
            this.xId_Tipo_Cta.Name = "xId_Tipo_Cta";
            this.xId_Tipo_Cta.ReadOnly = true;
            this.xId_Tipo_Cta.Width = 45;
            // 
            // xideempresa
            // 
            this.xideempresa.DataPropertyName = "idempresa";
            this.xideempresa.HeaderText = "idempresa";
            this.xideempresa.Name = "xideempresa";
            this.xideempresa.ReadOnly = true;
            this.xideempresa.Visible = false;
            // 
            // xEmpresa
            // 
            this.xEmpresa.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.xEmpresa.DataPropertyName = "Empresa";
            this.xEmpresa.HeaderText = "Empresa";
            this.xEmpresa.MinimumWidth = 100;
            this.xEmpresa.Name = "xEmpresa";
            this.xEmpresa.ReadOnly = true;
            // 
            // xidbanco
            // 
            this.xidbanco.DataPropertyName = "idbanco";
            this.xidbanco.HeaderText = "idbanco";
            this.xidbanco.Name = "xidbanco";
            this.xidbanco.ReadOnly = true;
            this.xidbanco.Visible = false;
            // 
            // xBanco
            // 
            this.xBanco.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.xBanco.DataPropertyName = "banco";
            this.xBanco.HeaderText = "Banco";
            this.xBanco.MinimumWidth = 80;
            this.xBanco.Name = "xBanco";
            this.xBanco.ReadOnly = true;
            this.xBanco.Width = 80;
            // 
            // xidmoneda
            // 
            this.xidmoneda.DataPropertyName = "idmoneda";
            this.xidmoneda.HeaderText = "idmoneda";
            this.xidmoneda.Name = "xidmoneda";
            this.xidmoneda.ReadOnly = true;
            this.xidmoneda.Visible = false;
            // 
            // xMoneda
            // 
            this.xMoneda.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.xMoneda.DataPropertyName = "moneda";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.xMoneda.DefaultCellStyle = dataGridViewCellStyle4;
            this.xMoneda.HeaderText = "Mon";
            this.xMoneda.MinimumWidth = 2;
            this.xMoneda.Name = "xMoneda";
            this.xMoneda.ReadOnly = true;
            this.xMoneda.Width = 55;
            // 
            // xTipo_Cta
            // 
            this.xTipo_Cta.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.xTipo_Cta.DataPropertyName = "tipo";
            this.xTipo_Cta.HeaderText = "TipoCuenta";
            this.xTipo_Cta.MinimumWidth = 70;
            this.xTipo_Cta.Name = "xTipo_Cta";
            this.xTipo_Cta.ReadOnly = true;
            this.xTipo_Cta.Width = 90;
            // 
            // xtipo
            // 
            this.xtipo.DataPropertyName = "Tipo_Cta";
            this.xtipo.HeaderText = "tipo";
            this.xtipo.Name = "xtipo";
            this.xtipo.ReadOnly = true;
            this.xtipo.Visible = false;
            // 
            // xNro_Cta
            // 
            this.xNro_Cta.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.xNro_Cta.DataPropertyName = "Nro_Cta";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.xNro_Cta.DefaultCellStyle = dataGridViewCellStyle5;
            this.xNro_Cta.HeaderText = "NroCuenta";
            this.xNro_Cta.MinimumWidth = 70;
            this.xNro_Cta.Name = "xNro_Cta";
            this.xNro_Cta.ReadOnly = true;
            this.xNro_Cta.Width = 87;
            // 
            // xNro_Cta_Cci
            // 
            this.xNro_Cta_Cci.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.xNro_Cta_Cci.DataPropertyName = "Nro_Cta_Cci";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.xNro_Cta_Cci.DefaultCellStyle = dataGridViewCellStyle6;
            this.xNro_Cta_Cci.HeaderText = "NroCuentaCCI";
            this.xNro_Cta_Cci.MinimumWidth = 90;
            this.xNro_Cta_Cci.Name = "xNro_Cta_Cci";
            this.xNro_Cta_Cci.ReadOnly = true;
            this.xNro_Cta_Cci.Width = 104;
            // 
            // xUsuario
            // 
            this.xUsuario.DataPropertyName = "Usuario";
            this.xUsuario.HeaderText = "Usuario";
            this.xUsuario.Name = "xUsuario";
            this.xUsuario.ReadOnly = true;
            this.xUsuario.Visible = false;
            // 
            // xFecha
            // 
            this.xFecha.DataPropertyName = "Fecha";
            this.xFecha.HeaderText = "Fecha";
            this.xFecha.Name = "xFecha";
            this.xFecha.ReadOnly = true;
            this.xFecha.Visible = false;
            // 
            // lblmsg
            // 
            this.lblmsg.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblmsg.BackColor = System.Drawing.Color.Transparent;
            this.lblmsg.Location = new System.Drawing.Point(12, 497);
            this.lblmsg.Name = "lblmsg";
            this.lblmsg.Size = new System.Drawing.Size(133, 16);
            this.lblmsg.TabIndex = 267;
            this.lblmsg.Text = "Total de Registros : 0";
            // 
            // gppanel
            // 
            this.gppanel.BackColor = System.Drawing.Color.Transparent;
            this.gppanel.Controls.Add(this.cbomoneda);
            this.gppanel.Controls.Add(this.cbotipocuenta);
            this.gppanel.Controls.Add(this.label2);
            this.gppanel.Controls.Add(this.label3);
            this.gppanel.Controls.Add(this.label26);
            this.gppanel.Controls.Add(this.cbobanco);
            this.gppanel.Controls.Add(this.cboempresa);
            this.gppanel.Controls.Add(this.label1);
            this.gppanel.Controls.Add(this.label19);
            this.gppanel.Location = new System.Drawing.Point(0, 12);
            this.gppanel.Movible = false;
            this.gppanel.Name = "gppanel";
            this.gppanel.Size = new System.Drawing.Size(536, 70);
            this.gppanel.TabIndex = 268;
            // 
            // cbomoneda
            // 
            this.cbomoneda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(218)))), ((int)(((byte)(231)))));
            this.cbomoneda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbomoneda.FormattingEnabled = true;
            this.cbomoneda.Location = new System.Drawing.Point(396, 22);
            this.cbomoneda.Name = "cbomoneda";
            this.cbomoneda.Size = new System.Drawing.Size(133, 21);
            this.cbomoneda.TabIndex = 263;
            this.cbomoneda.Click += new System.EventHandler(this.cbomoneda_Click);
            // 
            // cbotipocuenta
            // 
            this.cbotipocuenta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(218)))), ((int)(((byte)(231)))));
            this.cbotipocuenta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbotipocuenta.FormattingEnabled = true;
            this.cbotipocuenta.Location = new System.Drawing.Point(340, 46);
            this.cbotipocuenta.Name = "cbotipocuenta";
            this.cbotipocuenta.Size = new System.Drawing.Size(189, 21);
            this.cbotipocuenta.TabIndex = 264;
            this.cbotipocuenta.Click += new System.EventHandler(this.cbotipocuenta_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(343, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 265;
            this.label2.Text = "Moneda:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(268, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 266;
            this.label3.Text = "Tipo Cuenta:";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.BackColor = System.Drawing.Color.Transparent;
            this.label26.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.Location = new System.Drawing.Point(12, 5);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(155, 13);
            this.label26.TabIndex = 262;
            this.label26.Text = "Datos de la Cuenta Bancaria:";
            // 
            // cbobanco
            // 
            this.cbobanco.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(218)))), ((int)(((byte)(231)))));
            this.cbobanco.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbobanco.FormattingEnabled = true;
            this.cbobanco.Location = new System.Drawing.Point(78, 46);
            this.cbobanco.Name = "cbobanco";
            this.cbobanco.Size = new System.Drawing.Size(189, 21);
            this.cbobanco.TabIndex = 0;
            this.cbobanco.Click += new System.EventHandler(this.cbobanco_Click);
            // 
            // cboempresa
            // 
            this.cboempresa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(218)))), ((int)(((byte)(231)))));
            this.cboempresa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboempresa.FormattingEnabled = true;
            this.cboempresa.Location = new System.Drawing.Point(78, 22);
            this.cboempresa.Name = "cboempresa";
            this.cboempresa.Size = new System.Drawing.Size(262, 21);
            this.cboempresa.TabIndex = 0;
            this.cboempresa.Click += new System.EventHandler(this.cboempresa_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(37, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 261;
            this.label1.Text = "Banco:";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.BackColor = System.Drawing.Color.Transparent;
            this.label19.Location = new System.Drawing.Point(26, 26);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(53, 13);
            this.label19.TabIndex = 261;
            this.label19.Text = "Empresa:";
            // 
            // txtnrocci
            // 
            this.txtnrocci.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(218)))), ((int)(((byte)(231)))));
            this.txtnrocci.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtnrocci.ColorFondoMouseEncima = System.Drawing.Color.Empty;
            this.txtnrocci.ColorFondoMousePresionado = System.Drawing.Color.Empty;
            this.txtnrocci.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnrocci.ForeColor = System.Drawing.Color.Black;
            this.txtnrocci.Location = new System.Drawing.Point(598, 57);
            this.txtnrocci.MaxLength = 30;
            this.txtnrocci.Name = "txtnrocci";
            this.txtnrocci.NextControlOnEnter = null;
            this.txtnrocci.ReadOnly = true;
            this.txtnrocci.Size = new System.Drawing.Size(243, 21);
            this.txtnrocci.TabIndex = 270;
            this.txtnrocci.Text = "0000000000";
            this.txtnrocci.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtnrocci.TextoDefecto = "0000000000";
            this.txtnrocci.TextoDefectoColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(129)))), ((int)(((byte)(189)))));
            this.txtnrocci.TiposDatos = HpResergerUserControls.TextBoxPer.ListaTipos.MayusculaCadaPalabra;
            // 
            // txtnrocuenta
            // 
            this.txtnrocuenta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(218)))), ((int)(((byte)(231)))));
            this.txtnrocuenta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtnrocuenta.ColorFondoMouseEncima = System.Drawing.Color.Empty;
            this.txtnrocuenta.ColorFondoMousePresionado = System.Drawing.Color.Empty;
            this.txtnrocuenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnrocuenta.ForeColor = System.Drawing.Color.Black;
            this.txtnrocuenta.Location = new System.Drawing.Point(598, 33);
            this.txtnrocuenta.MaxLength = 30;
            this.txtnrocuenta.Name = "txtnrocuenta";
            this.txtnrocuenta.NextControlOnEnter = null;
            this.txtnrocuenta.ReadOnly = true;
            this.txtnrocuenta.Size = new System.Drawing.Size(243, 21);
            this.txtnrocuenta.TabIndex = 269;
            this.txtnrocuenta.Text = "0000000000";
            this.txtnrocuenta.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtnrocuenta.TextoDefecto = "0000000000";
            this.txtnrocuenta.TextoDefectoColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(129)))), ((int)(((byte)(189)))));
            this.txtnrocuenta.TiposDatos = HpResergerUserControls.TextBoxPer.ListaTipos.MayusculaCadaPalabra;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(553, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 267;
            this.label4.Text = "NroCCI:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(533, 37);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 13);
            this.label5.TabIndex = 268;
            this.label5.Text = "NroCuenta:";
            // 
            // frmTiposdeCuentasBancarias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(941, 526);
            this.Controls.Add(this.txtnrocci);
            this.Controls.Add(this.gppanel);
            this.Controls.Add(this.txtnrocuenta);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblmsg);
            this.Controls.Add(this.btneliminar);
            this.Controls.Add(this.btnmodificar);
            this.Controls.Add(this.btnnuevo);
            this.Controls.Add(this.btnaceptar);
            this.Controls.Add(this.btncancelar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dtgconten);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinimumSize = new System.Drawing.Size(957, 565);
            this.Name = "frmTiposdeCuentasBancarias";
            this.Nombre = "Cuentas Bancarias";
            this.Text = "Cuentas Bancarias";
            this.Load += new System.EventHandler(this.frmTiposdeCuentasBancarias_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgconten)).EndInit();
            this.gppanel.ResumeLayout(false);
            this.gppanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnaceptar;
        private System.Windows.Forms.Button btncancelar;
        private System.Windows.Forms.Button btneliminar;
        private System.Windows.Forms.Button btnmodificar;
        private System.Windows.Forms.Button btnnuevo;
        private HpResergerUserControls.Dtgconten dtgconten;
        private System.Windows.Forms.Label lblmsg;
        private HpResergerUserControls.PanelOre gppanel;
        private HpResergerUserControls.ComboBoxPer cboempresa;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private HpResergerUserControls.ComboBoxPer cbomoneda;
        private HpResergerUserControls.ComboBoxPer cbotipocuenta;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private HpResergerUserControls.ComboBoxPer cbobanco;
        private System.Windows.Forms.Label label1;
        private HpResergerUserControls.TextBoxPer txtnrocuenta;
        private HpResergerUserControls.TextBoxPer txtnrocci;
        private System.Windows.Forms.DataGridViewTextBoxColumn xId_Tipo_Cta;
        private System.Windows.Forms.DataGridViewTextBoxColumn xideempresa;
        private System.Windows.Forms.DataGridViewTextBoxColumn xEmpresa;
        private System.Windows.Forms.DataGridViewTextBoxColumn xidbanco;
        private System.Windows.Forms.DataGridViewTextBoxColumn xBanco;
        private System.Windows.Forms.DataGridViewTextBoxColumn xidmoneda;
        private System.Windows.Forms.DataGridViewTextBoxColumn xMoneda;
        private System.Windows.Forms.DataGridViewTextBoxColumn xTipo_Cta;
        private System.Windows.Forms.DataGridViewTextBoxColumn xtipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn xNro_Cta;
        private System.Windows.Forms.DataGridViewTextBoxColumn xNro_Cta_Cci;
        private System.Windows.Forms.DataGridViewTextBoxColumn xUsuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn xFecha;
    }
}