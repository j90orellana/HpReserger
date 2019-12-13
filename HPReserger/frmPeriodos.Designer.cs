namespace HPReserger
{
    partial class frmPeriodos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPeriodos));
            this.dtgconten = new HpResergerUserControls.Dtgconten();
            this.añox = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mesletrasx = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.empresax = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estadosx = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estadox = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mesx = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usuariox = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechax = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idempresax = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btncancelar = new System.Windows.Forms.Button();
            this.btnaceptar = new System.Windows.Forms.Button();
            this.txtanio = new HpResergerUserControls.TextBoxPer();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbomes = new System.Windows.Forms.ComboBox();
            this.cboestado = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.btnabriperiodo = new System.Windows.Forms.Button();
            this.btncleanfind = new System.Windows.Forms.Button();
            this.txtbusaño = new HpResergerUserControls.TextBoxPer();
            this.txtbusmes = new HpResergerUserControls.TextBoxPer();
            this.txtbusempresa = new HpResergerUserControls.TextBoxPer();
            this.lblmensaje = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgconten)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgconten
            // 
            this.dtgconten.AllowUserToAddRows = false;
            this.dtgconten.AllowUserToOrderColumns = true;
            this.dtgconten.AllowUserToResizeColumns = false;
            this.dtgconten.AllowUserToResizeRows = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(230)))), ((int)(((byte)(241)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(191)))), ((int)(((byte)(231)))));
            this.dtgconten.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dtgconten.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgconten.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgconten.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(218)))), ((int)(((byte)(231)))));
            this.dtgconten.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgconten.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.dtgconten.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(129)))), ((int)(((byte)(189)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.DeepSkyBlue;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgconten.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dtgconten.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dtgconten.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.añox,
            this.Mesletrasx,
            this.empresax,
            this.Estadosx,
            this.estadox,
            this.mesx,
            this.usuariox,
            this.fechax,
            this.idempresax});
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(207)))), ((int)(((byte)(241)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgconten.DefaultCellStyle = dataGridViewCellStyle8;
            this.dtgconten.EnableHeadersVisualStyles = false;
            this.dtgconten.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(179)))), ((int)(((byte)(215)))));
            this.dtgconten.Location = new System.Drawing.Point(12, 60);
            this.dtgconten.Name = "dtgconten";
            this.dtgconten.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dtgconten.RowHeadersVisible = false;
            this.dtgconten.RowTemplate.Height = 18;
            this.dtgconten.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgconten.Size = new System.Drawing.Size(630, 296);
            this.dtgconten.TabIndex = 9;
            this.dtgconten.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dtgconten_CellFormatting);
            this.dtgconten.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgconten_RowEnter);
            // 
            // añox
            // 
            this.añox.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.añox.DataPropertyName = "AÑO";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.añox.DefaultCellStyle = dataGridViewCellStyle7;
            this.añox.HeaderText = "Año";
            this.añox.MinimumWidth = 80;
            this.añox.Name = "añox";
            this.añox.ReadOnly = true;
            this.añox.Width = 80;
            // 
            // Mesletrasx
            // 
            this.Mesletrasx.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Mesletrasx.DataPropertyName = "mesletras";
            this.Mesletrasx.HeaderText = "Mes";
            this.Mesletrasx.MinimumWidth = 80;
            this.Mesletrasx.Name = "Mesletrasx";
            this.Mesletrasx.ReadOnly = true;
            this.Mesletrasx.Width = 80;
            // 
            // empresax
            // 
            this.empresax.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.empresax.DataPropertyName = "nameempresa";
            this.empresax.HeaderText = "Empresa";
            this.empresax.Name = "empresax";
            this.empresax.ReadOnly = true;
            // 
            // Estadosx
            // 
            this.Estadosx.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Estadosx.DataPropertyName = "estados";
            this.Estadosx.HeaderText = "Estados";
            this.Estadosx.MinimumWidth = 120;
            this.Estadosx.Name = "Estadosx";
            this.Estadosx.ReadOnly = true;
            this.Estadosx.Width = 120;
            // 
            // estadox
            // 
            this.estadox.DataPropertyName = "estado";
            this.estadox.HeaderText = "estado";
            this.estadox.Name = "estadox";
            this.estadox.Visible = false;
            // 
            // mesx
            // 
            this.mesx.DataPropertyName = "mes";
            this.mesx.HeaderText = "mes";
            this.mesx.Name = "mesx";
            this.mesx.Visible = false;
            // 
            // usuariox
            // 
            this.usuariox.DataPropertyName = "usuario";
            this.usuariox.HeaderText = "usuario";
            this.usuariox.Name = "usuariox";
            this.usuariox.Visible = false;
            // 
            // fechax
            // 
            this.fechax.DataPropertyName = "fecha";
            this.fechax.HeaderText = "fecha";
            this.fechax.Name = "fechax";
            this.fechax.Visible = false;
            // 
            // idempresax
            // 
            this.idempresax.DataPropertyName = "empresa";
            this.idempresax.HeaderText = "idempresa";
            this.idempresax.Name = "idempresax";
            this.idempresax.Visible = false;
            // 
            // btncancelar
            // 
            this.btncancelar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btncancelar.Image = ((System.Drawing.Image)(resources.GetObject("btncancelar.Image")));
            this.btncancelar.Location = new System.Drawing.Point(330, 362);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(75, 23);
            this.btncancelar.TabIndex = 11;
            this.btncancelar.Text = "Cancelar";
            this.btncancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btncancelar.UseVisualStyleBackColor = true;
            this.btncancelar.Click += new System.EventHandler(this.btncancelar_Click);
            // 
            // btnaceptar
            // 
            this.btnaceptar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnaceptar.Image = ((System.Drawing.Image)(resources.GetObject("btnaceptar.Image")));
            this.btnaceptar.Location = new System.Drawing.Point(249, 362);
            this.btnaceptar.Name = "btnaceptar";
            this.btnaceptar.Size = new System.Drawing.Size(75, 23);
            this.btnaceptar.TabIndex = 10;
            this.btnaceptar.Text = "Aceptar";
            this.btnaceptar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnaceptar.UseVisualStyleBackColor = true;
            this.btnaceptar.Click += new System.EventHandler(this.btnaceptar_Click);
            // 
            // txtanio
            // 
            this.txtanio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(218)))), ((int)(((byte)(231)))));
            this.txtanio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtanio.ColorFondoMouseEncima = System.Drawing.Color.Empty;
            this.txtanio.ColorFondoMousePresionado = System.Drawing.Color.Empty;
            this.txtanio.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtanio.ForeColor = System.Drawing.Color.Black;
            this.txtanio.Format = null;
            this.txtanio.Location = new System.Drawing.Point(47, 12);
            this.txtanio.MaxLength = 4;
            this.txtanio.Name = "txtanio";
            this.txtanio.NextControlOnEnter = null;
            this.txtanio.ReadOnly = true;
            this.txtanio.Size = new System.Drawing.Size(37, 20);
            this.txtanio.TabIndex = 0;
            this.txtanio.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtanio.TextoDefecto = "";
            this.txtanio.TextoDefectoColor = System.Drawing.Color.Black;
            this.txtanio.TiposDatos = HpResergerUserControls.TextBoxPer.ListaTipos.SoloNumeros;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Año:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(88, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Mes:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(254, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Estado:";
            // 
            // cbomes
            // 
            this.cbomes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(218)))), ((int)(((byte)(231)))));
            this.cbomes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbomes.Enabled = false;
            this.cbomes.FormattingEnabled = true;
            this.cbomes.Location = new System.Drawing.Point(124, 12);
            this.cbomes.Name = "cbomes";
            this.cbomes.Size = new System.Drawing.Size(121, 21);
            this.cbomes.TabIndex = 1;
            // 
            // cboestado
            // 
            this.cboestado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(218)))), ((int)(((byte)(231)))));
            this.cboestado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboestado.Enabled = false;
            this.cboestado.FormattingEnabled = true;
            this.cboestado.Location = new System.Drawing.Point(303, 12);
            this.cboestado.Name = "cboestado";
            this.cboestado.Size = new System.Drawing.Size(121, 21);
            this.cboestado.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(567, 11);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Excel";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // btnabriperiodo
            // 
            this.btnabriperiodo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnabriperiodo.Enabled = false;
            this.btnabriperiodo.Image = ((System.Drawing.Image)(resources.GetObject("btnabriperiodo.Image")));
            this.btnabriperiodo.Location = new System.Drawing.Point(492, 11);
            this.btnabriperiodo.Name = "btnabriperiodo";
            this.btnabriperiodo.Size = new System.Drawing.Size(75, 23);
            this.btnabriperiodo.TabIndex = 3;
            this.btnabriperiodo.Text = "Abrir";
            this.btnabriperiodo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnabriperiodo.UseVisualStyleBackColor = true;
            this.btnabriperiodo.Click += new System.EventHandler(this.btnabriperiodo_Click);
            // 
            // btncleanfind
            // 
            this.btncleanfind.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btncleanfind.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btncleanfind.Image = ((System.Drawing.Image)(resources.GetObject("btncleanfind.Image")));
            this.btncleanfind.Location = new System.Drawing.Point(617, 35);
            this.btncleanfind.Name = "btncleanfind";
            this.btncleanfind.Size = new System.Drawing.Size(25, 23);
            this.btncleanfind.TabIndex = 8;
            this.btncleanfind.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btncleanfind.UseVisualStyleBackColor = true;
            this.btncleanfind.Click += new System.EventHandler(this.btncleanfind_Click);
            // 
            // txtbusaño
            // 
            this.txtbusaño.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtbusaño.BackColor = System.Drawing.Color.White;
            this.txtbusaño.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtbusaño.ColorFondoMouseEncima = System.Drawing.Color.Empty;
            this.txtbusaño.ColorFondoMousePresionado = System.Drawing.Color.Empty;
            this.txtbusaño.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbusaño.ForeColor = System.Drawing.Color.Black;
            this.txtbusaño.Format = null;
            this.txtbusaño.Location = new System.Drawing.Point(12, 36);
            this.txtbusaño.MaxLength = 300;
            this.txtbusaño.Name = "txtbusaño";
            this.txtbusaño.NextControlOnEnter = null;
            this.txtbusaño.Size = new System.Drawing.Size(72, 21);
            this.txtbusaño.TabIndex = 5;
            this.txtbusaño.Text = "Buscar Año";
            this.txtbusaño.TextoDefecto = "Buscar Año";
            this.txtbusaño.TextoDefectoColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(129)))), ((int)(((byte)(189)))));
            this.txtbusaño.TiposDatos = HpResergerUserControls.TextBoxPer.ListaTipos.MayusculaCadaPalabra;
            this.txtbusaño.TextChanged += new System.EventHandler(this.txtbusaño_TextChanged);
            // 
            // txtbusmes
            // 
            this.txtbusmes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtbusmes.BackColor = System.Drawing.Color.White;
            this.txtbusmes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtbusmes.ColorFondoMouseEncima = System.Drawing.Color.Empty;
            this.txtbusmes.ColorFondoMousePresionado = System.Drawing.Color.Empty;
            this.txtbusmes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbusmes.ForeColor = System.Drawing.Color.Black;
            this.txtbusmes.Format = null;
            this.txtbusmes.Location = new System.Drawing.Point(87, 36);
            this.txtbusmes.MaxLength = 300;
            this.txtbusmes.Name = "txtbusmes";
            this.txtbusmes.NextControlOnEnter = null;
            this.txtbusmes.Size = new System.Drawing.Size(155, 21);
            this.txtbusmes.TabIndex = 6;
            this.txtbusmes.Text = "Buscar Mes";
            this.txtbusmes.TextoDefecto = "Buscar Mes";
            this.txtbusmes.TextoDefectoColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(129)))), ((int)(((byte)(189)))));
            this.txtbusmes.TiposDatos = HpResergerUserControls.TextBoxPer.ListaTipos.MayusculaCadaPalabra;
            this.txtbusmes.TextChanged += new System.EventHandler(this.txtbusmes_TextChanged);
            // 
            // txtbusempresa
            // 
            this.txtbusempresa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtbusempresa.BackColor = System.Drawing.Color.White;
            this.txtbusempresa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtbusempresa.ColorFondoMouseEncima = System.Drawing.Color.Empty;
            this.txtbusempresa.ColorFondoMousePresionado = System.Drawing.Color.Empty;
            this.txtbusempresa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbusempresa.ForeColor = System.Drawing.Color.Black;
            this.txtbusempresa.Format = null;
            this.txtbusempresa.Location = new System.Drawing.Point(245, 36);
            this.txtbusempresa.MaxLength = 300;
            this.txtbusempresa.Name = "txtbusempresa";
            this.txtbusempresa.NextControlOnEnter = null;
            this.txtbusempresa.Size = new System.Drawing.Size(370, 21);
            this.txtbusempresa.TabIndex = 7;
            this.txtbusempresa.Text = "Buscar Empresa";
            this.txtbusempresa.TextoDefecto = "Buscar Empresa";
            this.txtbusempresa.TextoDefectoColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(129)))), ((int)(((byte)(189)))));
            this.txtbusempresa.TiposDatos = HpResergerUserControls.TextBoxPer.ListaTipos.MayusculaCadaPalabra;
            this.txtbusempresa.TextChanged += new System.EventHandler(this.txtbusempresa_TextChanged);
            // 
            // lblmensaje
            // 
            this.lblmensaje.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblmensaje.AutoSize = true;
            this.lblmensaje.BackColor = System.Drawing.Color.Transparent;
            this.lblmensaje.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmensaje.Location = new System.Drawing.Point(12, 367);
            this.lblmensaje.Name = "lblmensaje";
            this.lblmensaje.Size = new System.Drawing.Size(110, 13);
            this.lblmensaje.TabIndex = 236;
            this.lblmensaje.Text = "Total de Registros: 0";
            // 
            // frmPeriodos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(654, 391);
            this.Controls.Add(this.lblmensaje);
            this.Controls.Add(this.btncleanfind);
            this.Controls.Add(this.txtbusempresa);
            this.Controls.Add(this.txtbusmes);
            this.Controls.Add(this.txtbusaño);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cboestado);
            this.Controls.Add(this.cbomes);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtanio);
            this.Controls.Add(this.btnabriperiodo);
            this.Controls.Add(this.btnaceptar);
            this.Controls.Add(this.btncancelar);
            this.Controls.Add(this.dtgconten);
            this.MinimumSize = new System.Drawing.Size(670, 430);
            this.Name = "frmPeriodos";
            this.Nombre = "Periodos";
            this.Text = "Periodos";
            this.Load += new System.EventHandler(this.frmPeriodos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgconten)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private HpResergerUserControls.Dtgconten dtgconten;
        private System.Windows.Forms.Button btncancelar;
        private System.Windows.Forms.Button btnaceptar;
        private HpResergerUserControls.TextBoxPer txtanio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbomes;
        private System.Windows.Forms.ComboBox cboestado;
        private System.Windows.Forms.Button button1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.DataGridViewTextBoxColumn añox;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mesletrasx;
        private System.Windows.Forms.DataGridViewTextBoxColumn empresax;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estadosx;
        private System.Windows.Forms.DataGridViewTextBoxColumn estadox;
        private System.Windows.Forms.DataGridViewTextBoxColumn mesx;
        private System.Windows.Forms.DataGridViewTextBoxColumn usuariox;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechax;
        private System.Windows.Forms.DataGridViewTextBoxColumn idempresax;
        private System.Windows.Forms.Button btnabriperiodo;
        private System.Windows.Forms.Button btncleanfind;
        private HpResergerUserControls.TextBoxPer txtbusaño;
        private HpResergerUserControls.TextBoxPer txtbusmes;
        private HpResergerUserControls.TextBoxPer txtbusempresa;
        private System.Windows.Forms.Label lblmensaje;
    }
}