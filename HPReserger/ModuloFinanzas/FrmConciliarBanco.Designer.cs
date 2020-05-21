namespace HPReserger.ModuloFinanzas
{
    partial class FrmConciliarBanco
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle22 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle23 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle27 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle28 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle24 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle25 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle26 = new System.Windows.Forms.DataGridViewCellStyle();
            this.cboempresa = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cboCuentasBancarias = new System.Windows.Forms.ComboBox();
            this.comboMesAño1 = new HpResergerUserControls.ComboMesAño();
            this.label3 = new System.Windows.Forms.Label();
            this.btnPaso1 = new HpResergerUserControls.ButtonPer();
            this.BtnCerrar = new HpResergerUserControls.ButtonPer();
            this.btnTxt = new HpResergerUserControls.ButtonPer();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtRutaExcel = new HpResergerUserControls.TextBoxPer();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnCargar = new HpResergerUserControls.ButtonPer();
            this.btnPaso2 = new HpResergerUserControls.ButtonPer();
            this.dtgContenExcel = new HpResergerUserControls.Dtgconten();
            this.xok = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.xGrupo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xFecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xMonto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xNroOperacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xGlosa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xGlosa2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblREgistros = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.dtgContenSistema = new HpResergerUserControls.Dtgconten();
            this.yok = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ygrupo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ycuo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yFecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ymonto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yoperacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yglosa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yglosa2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yidasiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblexcel = new System.Windows.Forms.Label();
            this.lblSistema = new System.Windows.Forms.Label();
            this.lblTotales = new System.Windows.Forms.Label();
            this.lblFunciones = new System.Windows.Forms.Label();
            this.btnFechaMonto = new System.Windows.Forms.LinkLabel();
            this.btnOperacionMonto = new System.Windows.Forms.LinkLabel();
            this.btnOperacion = new System.Windows.Forms.LinkLabel();
            this.lblmanual = new System.Windows.Forms.Label();
            this.btnAgrupar = new System.Windows.Forms.LinkLabel();
            this.btnDesAgrupar = new System.Windows.Forms.LinkLabel();
            this.chkOperacion = new HpResergerUserControls.checkboxOre();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dtgContenExcel)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgContenSistema)).BeginInit();
            this.SuspendLayout();
            // 
            // cboempresa
            // 
            this.cboempresa.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboempresa.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboempresa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(218)))), ((int)(((byte)(231)))));
            this.cboempresa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboempresa.FormattingEnabled = true;
            this.cboempresa.Location = new System.Drawing.Point(64, 23);
            this.cboempresa.Name = "cboempresa";
            this.cboempresa.Size = new System.Drawing.Size(394, 21);
            this.cboempresa.TabIndex = 44;
            this.cboempresa.SelectedIndexChanged += new System.EventHandler(this.cboempresa_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 43;
            this.label1.Text = "Empresa:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 43;
            this.label2.Text = "Cuenta:";
            // 
            // cboCuentasBancarias
            // 
            this.cboCuentasBancarias.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboCuentasBancarias.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboCuentasBancarias.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(218)))), ((int)(((byte)(231)))));
            this.cboCuentasBancarias.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCuentasBancarias.FormattingEnabled = true;
            this.cboCuentasBancarias.Location = new System.Drawing.Point(64, 47);
            this.cboCuentasBancarias.Name = "cboCuentasBancarias";
            this.cboCuentasBancarias.Size = new System.Drawing.Size(500, 21);
            this.cboCuentasBancarias.TabIndex = 44;
            this.cboCuentasBancarias.SelectedIndexChanged += new System.EventHandler(this.cboCuentasBancarias_SelectedIndexChanged);
            this.cboCuentasBancarias.Click += new System.EventHandler(this.cboCuentasBancarias_Click);
            // 
            // comboMesAño1
            // 
            this.comboMesAño1.BackColor = System.Drawing.Color.Transparent;
            this.comboMesAño1.FechaConDiaActual = new System.DateTime(2020, 5, 20, 0, 0, 0, 0);
            this.comboMesAño1.FechaFinMes = new System.DateTime(2020, 5, 31, 0, 0, 0, 0);
            this.comboMesAño1.FechaInicioMes = new System.DateTime(2020, 5, 1, 0, 0, 0, 0);
            this.comboMesAño1.Location = new System.Drawing.Point(614, 44);
            this.comboMesAño1.Name = "comboMesAño1";
            this.comboMesAño1.Size = new System.Drawing.Size(197, 26);
            this.comboMesAño1.TabIndex = 45;
            this.comboMesAño1.VerAño = true;
            this.comboMesAño1.VerMes = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(564, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 43;
            this.label3.Text = "Periodo:";
            // 
            // btnPaso1
            // 
            this.btnPaso1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(129)))), ((int)(((byte)(189)))));
            this.btnPaso1.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnPaso1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPaso1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPaso1.ForeColor = System.Drawing.Color.White;
            this.btnPaso1.Location = new System.Drawing.Point(817, 46);
            this.btnPaso1.Name = "btnPaso1";
            this.btnPaso1.Size = new System.Drawing.Size(75, 23);
            this.btnPaso1.TabIndex = 46;
            this.btnPaso1.Text = "Avanzar";
            this.btnPaso1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPaso1.UseVisualStyleBackColor = false;
            this.btnPaso1.Click += new System.EventHandler(this.buttonPer1_Click);
            // 
            // BtnCerrar
            // 
            this.BtnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnCerrar.BackColor = System.Drawing.Color.Crimson;
            this.BtnCerrar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnCerrar.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.BtnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCerrar.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCerrar.ForeColor = System.Drawing.Color.White;
            this.BtnCerrar.Location = new System.Drawing.Point(809, 546);
            this.BtnCerrar.Name = "BtnCerrar";
            this.BtnCerrar.Size = new System.Drawing.Size(83, 23);
            this.BtnCerrar.TabIndex = 183;
            this.BtnCerrar.Text = "Cancelar";
            this.BtnCerrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnCerrar.UseVisualStyleBackColor = false;
            this.BtnCerrar.Click += new System.EventHandler(this.BtnCerrar_Click);
            // 
            // btnTxt
            // 
            this.btnTxt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTxt.BackColor = System.Drawing.Color.SeaGreen;
            this.btnTxt.FlatAppearance.BorderColor = System.Drawing.Color.Olive;
            this.btnTxt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTxt.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTxt.ForeColor = System.Drawing.Color.White;
            this.btnTxt.Location = new System.Drawing.Point(723, 546);
            this.btnTxt.Name = "btnTxt";
            this.btnTxt.Size = new System.Drawing.Size(83, 23);
            this.btnTxt.TabIndex = 184;
            this.btnTxt.Text = "Procesar";
            this.btnTxt.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTxt.UseVisualStyleBackColor = false;
            this.btnTxt.Visible = false;
            this.btnTxt.Click += new System.EventHandler(this.btnTxt_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(10, 8);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(277, 13);
            this.label4.TabIndex = 185;
            this.label4.Text = "1.- Seleccione Cuenta Bancaria y Periodo a Conciliar:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(10, 71);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(265, 13);
            this.label5.TabIndex = 185;
            this.label5.Text = "2.- Seleccione Excel de Movimientos de la Cuenta:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(28, 92);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 43;
            this.label6.Text = "Excel:";
            // 
            // txtRutaExcel
            // 
            this.txtRutaExcel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(218)))), ((int)(((byte)(231)))));
            this.txtRutaExcel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRutaExcel.ColorFondoMouseEncima = System.Drawing.Color.Empty;
            this.txtRutaExcel.ColorFondoMousePresionado = System.Drawing.Color.Empty;
            this.txtRutaExcel.Enabled = false;
            this.txtRutaExcel.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRutaExcel.ForeColor = System.Drawing.Color.Black;
            this.txtRutaExcel.Format = null;
            this.txtRutaExcel.Location = new System.Drawing.Point(64, 87);
            this.txtRutaExcel.MaxLength = 100;
            this.txtRutaExcel.Name = "txtRutaExcel";
            this.txtRutaExcel.NextControlOnEnter = null;
            this.txtRutaExcel.ReadOnly = true;
            this.txtRutaExcel.Size = new System.Drawing.Size(668, 22);
            this.txtRutaExcel.TabIndex = 186;
            this.txtRutaExcel.TextoDefecto = "";
            this.txtRutaExcel.TextoDefectoColor = System.Drawing.Color.White;
            this.txtRutaExcel.TiposDatos = HpResergerUserControls.TextBoxPer.ListaTipos.Todo;
            this.txtRutaExcel.DoubleClick += new System.EventHandler(this.textBoxPer1_DoubleClick);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "Archivos Excel|*.xls*";
            // 
            // btnCargar
            // 
            this.btnCargar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(129)))), ((int)(((byte)(189)))));
            this.btnCargar.Enabled = false;
            this.btnCargar.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnCargar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCargar.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCargar.ForeColor = System.Drawing.Color.White;
            this.btnCargar.Location = new System.Drawing.Point(738, 87);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(75, 23);
            this.btnCargar.TabIndex = 187;
            this.btnCargar.Text = "Buscar";
            this.btnCargar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCargar.UseVisualStyleBackColor = false;
            this.btnCargar.Click += new System.EventHandler(this.buttonPer1_Click_1);
            // 
            // btnPaso2
            // 
            this.btnPaso2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(129)))), ((int)(((byte)(189)))));
            this.btnPaso2.Enabled = false;
            this.btnPaso2.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnPaso2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPaso2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPaso2.ForeColor = System.Drawing.Color.White;
            this.btnPaso2.Location = new System.Drawing.Point(817, 87);
            this.btnPaso2.Name = "btnPaso2";
            this.btnPaso2.Size = new System.Drawing.Size(75, 23);
            this.btnPaso2.TabIndex = 46;
            this.btnPaso2.Text = "Avanzar";
            this.btnPaso2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPaso2.UseVisualStyleBackColor = false;
            this.btnPaso2.Click += new System.EventHandler(this.btnPaso2_Click);
            // 
            // dtgContenExcel
            // 
            this.dtgContenExcel.AllowUserToAddRows = false;
            this.dtgContenExcel.AllowUserToOrderColumns = true;
            this.dtgContenExcel.AllowUserToResizeColumns = false;
            this.dtgContenExcel.AllowUserToResizeRows = false;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(230)))), ((int)(((byte)(241)))));
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Tahoma", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(191)))), ((int)(((byte)(231)))));
            this.dtgContenExcel.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle15;
            this.dtgContenExcel.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgContenExcel.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(218)))), ((int)(((byte)(231)))));
            this.dtgContenExcel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgContenExcel.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.dtgContenExcel.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(129)))), ((int)(((byte)(189)))));
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Tahoma", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle16.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.Color.DeepSkyBlue;
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgContenExcel.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle16;
            this.dtgContenExcel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgContenExcel.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.xok,
            this.xGrupo,
            this.xFecha,
            this.xMonto,
            this.xNroOperacion,
            this.xGlosa,
            this.xGlosa2});
            dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle20.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle20.Font = new System.Drawing.Font("Tahoma", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle20.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle20.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(207)))), ((int)(((byte)(241)))));
            dataGridViewCellStyle20.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle20.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgContenExcel.DefaultCellStyle = dataGridViewCellStyle20;
            this.dtgContenExcel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgContenExcel.Enabled = false;
            this.dtgContenExcel.EnableHeadersVisualStyles = false;
            this.dtgContenExcel.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(179)))), ((int)(((byte)(215)))));
            this.dtgContenExcel.Location = new System.Drawing.Point(3, 18);
            this.dtgContenExcel.Name = "dtgContenExcel";
            this.dtgContenExcel.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle21.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle21.Font = new System.Drawing.Font("Tahoma", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle21.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle21.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle21.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle21.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgContenExcel.RowHeadersDefaultCellStyle = dataGridViewCellStyle21;
            this.dtgContenExcel.RowHeadersVisible = false;
            this.dtgContenExcel.RowTemplate.Height = 18;
            this.dtgContenExcel.Size = new System.Drawing.Size(433, 385);
            this.dtgContenExcel.TabIndex = 188;
            this.dtgContenExcel.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgContenExcel_CellClick);
            this.dtgContenExcel.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgContenExcel_CellContentDoubleClick);
            this.dtgContenExcel.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dtgContenExcel_CellFormatting);
            this.dtgContenExcel.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgContenExcel_CellValueChanged);
            this.dtgContenExcel.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgContenExcel_RowEnter);
            // 
            // xok
            // 
            this.xok.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.xok.DataPropertyName = "ok";
            this.xok.FalseValue = "0";
            this.xok.HeaderText = "Ok";
            this.xok.MinimumWidth = 25;
            this.xok.Name = "xok";
            this.xok.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.xok.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.xok.TrueValue = "1";
            this.xok.Width = 25;
            // 
            // xGrupo
            // 
            this.xGrupo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.xGrupo.DataPropertyName = "index";
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.xGrupo.DefaultCellStyle = dataGridViewCellStyle17;
            this.xGrupo.HeaderText = "Grupo";
            this.xGrupo.MinimumWidth = 40;
            this.xGrupo.Name = "xGrupo";
            this.xGrupo.ReadOnly = true;
            this.xGrupo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.xGrupo.Width = 40;
            // 
            // xFecha
            // 
            this.xFecha.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.xFecha.DataPropertyName = "Fecha";
            dataGridViewCellStyle18.Format = "d";
            this.xFecha.DefaultCellStyle = dataGridViewCellStyle18;
            this.xFecha.HeaderText = "Fecha";
            this.xFecha.MinimumWidth = 50;
            this.xFecha.Name = "xFecha";
            this.xFecha.ReadOnly = true;
            this.xFecha.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.xFecha.Width = 50;
            // 
            // xMonto
            // 
            this.xMonto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.xMonto.DataPropertyName = "Monto";
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle19.Format = "n2";
            this.xMonto.DefaultCellStyle = dataGridViewCellStyle19;
            this.xMonto.HeaderText = "Monto";
            this.xMonto.MinimumWidth = 50;
            this.xMonto.Name = "xMonto";
            this.xMonto.ReadOnly = true;
            this.xMonto.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.xMonto.Width = 50;
            // 
            // xNroOperacion
            // 
            this.xNroOperacion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.xNroOperacion.DataPropertyName = "Operacion";
            this.xNroOperacion.HeaderText = "Operacion";
            this.xNroOperacion.MinimumWidth = 60;
            this.xNroOperacion.Name = "xNroOperacion";
            this.xNroOperacion.ReadOnly = true;
            this.xNroOperacion.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.xNroOperacion.Width = 60;
            // 
            // xGlosa
            // 
            this.xGlosa.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.xGlosa.DataPropertyName = "Glosa";
            this.xGlosa.HeaderText = "Glosa";
            this.xGlosa.MinimumWidth = 80;
            this.xGlosa.Name = "xGlosa";
            this.xGlosa.ReadOnly = true;
            this.xGlosa.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // xGlosa2
            // 
            this.xGlosa2.DataPropertyName = "glosa2";
            this.xGlosa2.HeaderText = "Glosa";
            this.xGlosa2.Name = "xGlosa2";
            this.xGlosa2.ReadOnly = true;
            this.xGlosa2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // lblREgistros
            // 
            this.lblREgistros.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblREgistros.AutoSize = true;
            this.lblREgistros.BackColor = System.Drawing.Color.Transparent;
            this.lblREgistros.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblREgistros.Location = new System.Drawing.Point(13, 551);
            this.lblREgistros.Name = "lblREgistros";
            this.lblREgistros.Size = new System.Drawing.Size(94, 13);
            this.lblREgistros.TabIndex = 189;
            this.lblREgistros.Text = "Total Registros: 0";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.dtgContenSistema, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.dtgContenExcel, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblexcel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblSistema, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(13, 121);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 15F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(879, 406);
            this.tableLayoutPanel1.TabIndex = 190;
            // 
            // dtgContenSistema
            // 
            this.dtgContenSistema.AllowUserToAddRows = false;
            this.dtgContenSistema.AllowUserToOrderColumns = true;
            this.dtgContenSistema.AllowUserToResizeColumns = false;
            this.dtgContenSistema.AllowUserToResizeRows = false;
            dataGridViewCellStyle22.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(230)))), ((int)(((byte)(241)))));
            dataGridViewCellStyle22.Font = new System.Drawing.Font("Tahoma", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle22.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(191)))), ((int)(((byte)(231)))));
            this.dtgContenSistema.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle22;
            this.dtgContenSistema.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgContenSistema.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(218)))), ((int)(((byte)(231)))));
            this.dtgContenSistema.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgContenSistema.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.dtgContenSistema.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle23.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle23.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(129)))), ((int)(((byte)(189)))));
            dataGridViewCellStyle23.Font = new System.Drawing.Font("Tahoma", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle23.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle23.SelectionBackColor = System.Drawing.Color.DeepSkyBlue;
            dataGridViewCellStyle23.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle23.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgContenSistema.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle23;
            this.dtgContenSistema.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgContenSistema.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.yok,
            this.ygrupo,
            this.ycuo,
            this.yFecha,
            this.ymonto,
            this.yoperacion,
            this.yglosa,
            this.yglosa2,
            this.yidasiento});
            dataGridViewCellStyle27.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle27.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle27.Font = new System.Drawing.Font("Tahoma", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle27.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle27.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(207)))), ((int)(((byte)(241)))));
            dataGridViewCellStyle27.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle27.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgContenSistema.DefaultCellStyle = dataGridViewCellStyle27;
            this.dtgContenSistema.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgContenSistema.Enabled = false;
            this.dtgContenSistema.EnableHeadersVisualStyles = false;
            this.dtgContenSistema.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(179)))), ((int)(((byte)(215)))));
            this.dtgContenSistema.Location = new System.Drawing.Point(442, 18);
            this.dtgContenSistema.Name = "dtgContenSistema";
            this.dtgContenSistema.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle28.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle28.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle28.Font = new System.Drawing.Font("Tahoma", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle28.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle28.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle28.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle28.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgContenSistema.RowHeadersDefaultCellStyle = dataGridViewCellStyle28;
            this.dtgContenSistema.RowHeadersVisible = false;
            this.dtgContenSistema.RowTemplate.Height = 18;
            this.dtgContenSistema.Size = new System.Drawing.Size(434, 385);
            this.dtgContenSistema.TabIndex = 189;
            this.dtgContenSistema.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgContenSistema_CellClick);
            this.dtgContenSistema.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgContenSistema_CellContentDoubleClick);
            this.dtgContenSistema.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dtgContenSistema_CellFormatting);
            this.dtgContenSistema.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgContenSistema_CellValueChanged);
            this.dtgContenSistema.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgContenSistema_RowEnter);
            // 
            // yok
            // 
            this.yok.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.yok.DataPropertyName = "ok";
            this.yok.FalseValue = "0";
            this.yok.HeaderText = "Ok";
            this.yok.MinimumWidth = 25;
            this.yok.Name = "yok";
            this.yok.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.yok.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.yok.TrueValue = "1";
            this.yok.Width = 25;
            // 
            // ygrupo
            // 
            this.ygrupo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.ygrupo.DataPropertyName = "index";
            dataGridViewCellStyle24.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.ygrupo.DefaultCellStyle = dataGridViewCellStyle24;
            this.ygrupo.HeaderText = "Grupo";
            this.ygrupo.MinimumWidth = 40;
            this.ygrupo.Name = "ygrupo";
            this.ygrupo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.ygrupo.Width = 40;
            // 
            // ycuo
            // 
            this.ycuo.DataPropertyName = "cuo";
            this.ycuo.HeaderText = "Cuo";
            this.ycuo.Name = "ycuo";
            this.ycuo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.ycuo.Visible = false;
            // 
            // yFecha
            // 
            this.yFecha.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.yFecha.DataPropertyName = "Fecha";
            dataGridViewCellStyle25.Format = "d";
            this.yFecha.DefaultCellStyle = dataGridViewCellStyle25;
            this.yFecha.HeaderText = "Fecha";
            this.yFecha.MinimumWidth = 50;
            this.yFecha.Name = "yFecha";
            this.yFecha.ReadOnly = true;
            this.yFecha.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.yFecha.Width = 50;
            // 
            // ymonto
            // 
            this.ymonto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.ymonto.DataPropertyName = "Monto";
            dataGridViewCellStyle26.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle26.Format = "n2";
            this.ymonto.DefaultCellStyle = dataGridViewCellStyle26;
            this.ymonto.HeaderText = "Monto";
            this.ymonto.MinimumWidth = 50;
            this.ymonto.Name = "ymonto";
            this.ymonto.ReadOnly = true;
            this.ymonto.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.ymonto.Width = 50;
            // 
            // yoperacion
            // 
            this.yoperacion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.yoperacion.DataPropertyName = "Operacion";
            this.yoperacion.HeaderText = "Operacion";
            this.yoperacion.MinimumWidth = 60;
            this.yoperacion.Name = "yoperacion";
            this.yoperacion.ReadOnly = true;
            this.yoperacion.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.yoperacion.Width = 60;
            // 
            // yglosa
            // 
            this.yglosa.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.yglosa.DataPropertyName = "Glosa";
            this.yglosa.HeaderText = "Glosa";
            this.yglosa.MinimumWidth = 80;
            this.yglosa.Name = "yglosa";
            this.yglosa.ReadOnly = true;
            this.yglosa.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // yglosa2
            // 
            this.yglosa2.DataPropertyName = "glosa2";
            this.yglosa2.HeaderText = "Glosa";
            this.yglosa2.Name = "yglosa2";
            this.yglosa2.ReadOnly = true;
            this.yglosa2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // yidasiento
            // 
            this.yidasiento.DataPropertyName = "idasiento";
            this.yidasiento.HeaderText = "idAsiento";
            this.yidasiento.Name = "yidasiento";
            this.yidasiento.Visible = false;
            // 
            // lblexcel
            // 
            this.lblexcel.AutoSize = true;
            this.lblexcel.BackColor = System.Drawing.Color.Transparent;
            this.lblexcel.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblexcel.Location = new System.Drawing.Point(3, 0);
            this.lblexcel.Name = "lblexcel";
            this.lblexcel.Size = new System.Drawing.Size(266, 13);
            this.lblexcel.TabIndex = 43;
            this.lblexcel.Text = "Datos de Movimiento Bancario del Excel Cargado.";
            // 
            // lblSistema
            // 
            this.lblSistema.AutoSize = true;
            this.lblSistema.BackColor = System.Drawing.Color.Transparent;
            this.lblSistema.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblSistema.Location = new System.Drawing.Point(442, 0);
            this.lblSistema.Name = "lblSistema";
            this.lblSistema.Size = new System.Drawing.Size(242, 13);
            this.lblSistema.TabIndex = 43;
            this.lblSistema.Text = "Datos de Movimiento Bancario en el Sistema.";
            // 
            // lblTotales
            // 
            this.lblTotales.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotales.BackColor = System.Drawing.Color.Transparent;
            this.lblTotales.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotales.Location = new System.Drawing.Point(624, 530);
            this.lblTotales.Name = "lblTotales";
            this.lblTotales.Size = new System.Drawing.Size(271, 13);
            this.lblTotales.TabIndex = 189;
            this.lblTotales.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblFunciones
            // 
            this.lblFunciones.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblFunciones.AutoSize = true;
            this.lblFunciones.BackColor = System.Drawing.Color.Transparent;
            this.lblFunciones.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFunciones.Location = new System.Drawing.Point(13, 530);
            this.lblFunciones.Name = "lblFunciones";
            this.lblFunciones.Size = new System.Drawing.Size(72, 13);
            this.lblFunciones.TabIndex = 189;
            this.lblFunciones.Text = "Agrupar Por:";
            this.lblFunciones.Visible = false;
            // 
            // btnFechaMonto
            // 
            this.btnFechaMonto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnFechaMonto.AutoSize = true;
            this.btnFechaMonto.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.btnFechaMonto.Location = new System.Drawing.Point(85, 530);
            this.btnFechaMonto.Name = "btnFechaMonto";
            this.btnFechaMonto.Size = new System.Drawing.Size(83, 13);
            this.btnFechaMonto.TabIndex = 191;
            this.btnFechaMonto.TabStop = true;
            this.btnFechaMonto.Text = "Fecha y Monto";
            this.toolTip1.SetToolTip(this.btnFechaMonto, "Agrupa los Movimientos por Fecha y Monto");
            this.btnFechaMonto.Visible = false;
            this.btnFechaMonto.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.btnFechaMonto_LinkClicked);
            // 
            // btnOperacionMonto
            // 
            this.btnOperacionMonto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnOperacionMonto.AutoSize = true;
            this.btnOperacionMonto.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.btnOperacionMonto.Location = new System.Drawing.Point(168, 530);
            this.btnOperacionMonto.Name = "btnOperacionMonto";
            this.btnOperacionMonto.Size = new System.Drawing.Size(107, 13);
            this.btnOperacionMonto.TabIndex = 191;
            this.btnOperacionMonto.TabStop = true;
            this.btnOperacionMonto.Text = "Operación y Monto";
            this.toolTip1.SetToolTip(this.btnOperacionMonto, "Agrupa los Movimientos por Operación y Monto");
            this.btnOperacionMonto.Visible = false;
            this.btnOperacionMonto.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.btnOperacionMonto_LinkClicked);
            // 
            // btnOperacion
            // 
            this.btnOperacion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnOperacion.AutoSize = true;
            this.btnOperacion.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.btnOperacion.Location = new System.Drawing.Point(275, 530);
            this.btnOperacion.Name = "btnOperacion";
            this.btnOperacion.Size = new System.Drawing.Size(61, 13);
            this.btnOperacion.TabIndex = 191;
            this.btnOperacion.TabStop = true;
            this.btnOperacion.Text = "Operación";
            this.toolTip1.SetToolTip(this.btnOperacion, "Agrupa los Movimientos por Nùmero de Operación");
            this.btnOperacion.Visible = false;
            // 
            // lblmanual
            // 
            this.lblmanual.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblmanual.AutoSize = true;
            this.lblmanual.BackColor = System.Drawing.Color.Transparent;
            this.lblmanual.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmanual.Location = new System.Drawing.Point(452, 530);
            this.lblmanual.Name = "lblmanual";
            this.lblmanual.Size = new System.Drawing.Size(49, 13);
            this.lblmanual.TabIndex = 192;
            this.lblmanual.Text = "Manual:";
            // 
            // btnAgrupar
            // 
            this.btnAgrupar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnAgrupar.AutoSize = true;
            this.btnAgrupar.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.btnAgrupar.Location = new System.Drawing.Point(501, 530);
            this.btnAgrupar.Name = "btnAgrupar";
            this.btnAgrupar.Size = new System.Drawing.Size(49, 13);
            this.btnAgrupar.TabIndex = 191;
            this.btnAgrupar.TabStop = true;
            this.btnAgrupar.Text = "Agrupar";
            this.toolTip1.SetToolTip(this.btnAgrupar, "Agrupa los Movimientos Seleccionadas");
            this.btnAgrupar.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.btnAgrupar_LinkClicked);
            // 
            // btnDesAgrupar
            // 
            this.btnDesAgrupar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnDesAgrupar.AutoSize = true;
            this.btnDesAgrupar.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.btnDesAgrupar.Location = new System.Drawing.Point(550, 530);
            this.btnDesAgrupar.Name = "btnDesAgrupar";
            this.btnDesAgrupar.Size = new System.Drawing.Size(68, 13);
            this.btnDesAgrupar.TabIndex = 191;
            this.btnDesAgrupar.TabStop = true;
            this.btnDesAgrupar.Text = "DesAgrupar";
            this.toolTip1.SetToolTip(this.btnDesAgrupar, "DesAgrupa los Momivientos Seleccionados");
            this.btnDesAgrupar.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.btnDesAgrupar_LinkClicked);
            // 
            // chkOperacion
            // 
            this.chkOperacion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.chkOperacion.AutoSize = true;
            this.chkOperacion.BackColor = System.Drawing.Color.Transparent;
            this.chkOperacion.Checked = true;
            this.chkOperacion.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkOperacion.ColorChecked = System.Drawing.Color.Empty;
            this.chkOperacion.ColorUnChecked = System.Drawing.Color.Empty;
            this.chkOperacion.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.chkOperacion.Location = new System.Drawing.Point(600, 552);
            this.chkOperacion.Name = "chkOperacion";
            this.chkOperacion.Size = new System.Drawing.Size(123, 17);
            this.chkOperacion.TabIndex = 193;
            this.chkOperacion.Text = "Actualizar NroOpe.";
            this.toolTip1.SetToolTip(this.chkOperacion, "Actualiza el Nùmero de Operación en el Sistema con los Datos del Excel");
            this.chkOperacion.UseVisualStyleBackColor = false;
            // 
            // FrmConciliarBanco
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(902, 575);
            this.Controls.Add(this.chkOperacion);
            this.Controls.Add(this.lblmanual);
            this.Controls.Add(this.btnOperacion);
            this.Controls.Add(this.btnOperacionMonto);
            this.Controls.Add(this.btnDesAgrupar);
            this.Controls.Add(this.btnAgrupar);
            this.Controls.Add(this.btnFechaMonto);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.lblTotales);
            this.Controls.Add(this.lblFunciones);
            this.Controls.Add(this.lblREgistros);
            this.Controls.Add(this.btnCargar);
            this.Controls.Add(this.txtRutaExcel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.BtnCerrar);
            this.Controls.Add(this.btnTxt);
            this.Controls.Add(this.btnPaso2);
            this.Controls.Add(this.btnPaso1);
            this.Controls.Add(this.comboMesAño1);
            this.Controls.Add(this.cboCuentasBancarias);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cboempresa);
            this.Controls.Add(this.label1);
            this.MinimumSize = new System.Drawing.Size(918, 614);
            this.Name = "FrmConciliarBanco";
            this.Nombre = "Conciliación Bancaria";
            this.Text = "Conciliación Bancaria";
            this.Load += new System.EventHandler(this.FrmConciliarBanco_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgContenExcel)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgContenSistema)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboempresa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboCuentasBancarias;
        private HpResergerUserControls.ComboMesAño comboMesAño1;
        private System.Windows.Forms.Label label3;
        private HpResergerUserControls.ButtonPer btnPaso1;
        private HpResergerUserControls.ButtonPer BtnCerrar;
        private HpResergerUserControls.ButtonPer btnTxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private HpResergerUserControls.TextBoxPer txtRutaExcel;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private HpResergerUserControls.ButtonPer btnCargar;
        private HpResergerUserControls.ButtonPer btnPaso2;
        private HpResergerUserControls.Dtgconten dtgContenExcel;
        private System.Windows.Forms.Label lblREgistros;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblexcel;
        private System.Windows.Forms.Label lblSistema;
        private HpResergerUserControls.Dtgconten dtgContenSistema;
        private System.Windows.Forms.Label lblTotales;
        private System.Windows.Forms.Label lblFunciones;
        private System.Windows.Forms.LinkLabel btnFechaMonto;
        private System.Windows.Forms.LinkLabel btnOperacionMonto;
        private System.Windows.Forms.LinkLabel btnOperacion;
        private System.Windows.Forms.Label lblmanual;
        private System.Windows.Forms.LinkLabel btnAgrupar;
        private System.Windows.Forms.LinkLabel btnDesAgrupar;
        private HpResergerUserControls.checkboxOre chkOperacion;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn xok;
        private System.Windows.Forms.DataGridViewTextBoxColumn xGrupo;
        private System.Windows.Forms.DataGridViewTextBoxColumn xFecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn xMonto;
        private System.Windows.Forms.DataGridViewTextBoxColumn xNroOperacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn xGlosa;
        private System.Windows.Forms.DataGridViewTextBoxColumn xGlosa2;
        private System.Windows.Forms.DataGridViewCheckBoxColumn yok;
        private System.Windows.Forms.DataGridViewTextBoxColumn ygrupo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ycuo;
        private System.Windows.Forms.DataGridViewTextBoxColumn yFecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn ymonto;
        private System.Windows.Forms.DataGridViewTextBoxColumn yoperacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn yglosa;
        private System.Windows.Forms.DataGridViewTextBoxColumn yglosa2;
        private System.Windows.Forms.DataGridViewTextBoxColumn yidasiento;
    }
}