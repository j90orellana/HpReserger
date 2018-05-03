namespace HPReserger
{
    partial class FrmListarCuentasParaConfigurar
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmListarCuentasParaConfigurar));
            this.dtgConten = new System.Windows.Forms.DataGridView();
            this.Cuentax = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcionx = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Grid = new System.Windows.Forms.DataGridView();
            this.codcuenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CUENTAN1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CUENTACONTABLE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TIPOCUENTA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NATURALEZA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CUENTAGENERICA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GRUPOCUENTA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.REFLEJA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.REFLEJADEPENDE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CUENTAREFLEJA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CUENTAREFLEJA2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CUENTACIERRE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CIERRE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ANALITICA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AJUSTEPOR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AJUSTECUENTA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnaddselected = new System.Windows.Forms.Button();
            this.btnlimpiar = new System.Windows.Forms.Button();
            this.label22 = new System.Windows.Forms.Label();
            this.Txtbusca = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.lblmsg = new System.Windows.Forms.Label();
            this.btnaddgroup = new System.Windows.Forms.Button();
            this.lblmensaje2 = new System.Windows.Forms.Label();
            this.btncancelar = new System.Windows.Forms.Button();
            this.btnaceptar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgConten)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Grid)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtgConten
            // 
            this.dtgConten.AllowUserToAddRows = false;
            this.dtgConten.AllowUserToDeleteRows = false;
            this.dtgConten.AllowUserToResizeColumns = false;
            this.dtgConten.AllowUserToResizeRows = false;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.WhiteSmoke;
            this.dtgConten.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle13;
            this.dtgConten.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgConten.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgConten.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dtgConten.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dtgConten.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dtgConten.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Franklin Gothic Book", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgConten.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle14;
            this.dtgConten.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dtgConten.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Cuentax,
            this.Descripcionx});
            this.dtgConten.Cursor = System.Windows.Forms.Cursors.Default;
            this.dtgConten.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dtgConten.Location = new System.Drawing.Point(12, 291);
            this.dtgConten.Name = "dtgConten";
            this.dtgConten.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dtgConten.RowHeadersVisible = false;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Franklin Gothic Book", 8.25F);
            this.dtgConten.RowsDefaultCellStyle = dataGridViewCellStyle15;
            this.dtgConten.RowTemplate.Height = 16;
            this.dtgConten.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgConten.Size = new System.Drawing.Size(738, 340);
            this.dtgConten.TabIndex = 137;
            this.dtgConten.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgConten_CellValueChanged);
            this.dtgConten.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dtgConten_RowsAdded);
            this.dtgConten.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dtgConten_KeyDown);
            // 
            // Cuentax
            // 
            this.Cuentax.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Cuentax.DataPropertyName = "codigo";
            this.Cuentax.HeaderText = "Cuenta";
            this.Cuentax.MinimumWidth = 100;
            this.Cuentax.Name = "Cuentax";
            this.Cuentax.ReadOnly = true;
            // 
            // Descripcionx
            // 
            this.Descripcionx.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Descripcionx.DataPropertyName = "valor";
            this.Descripcionx.HeaderText = "Descripcion";
            this.Descripcionx.Name = "Descripcionx";
            this.Descripcionx.ReadOnly = true;
            // 
            // Grid
            // 
            this.Grid.AllowUserToAddRows = false;
            this.Grid.AllowUserToDeleteRows = false;
            this.Grid.AllowUserToResizeColumns = false;
            this.Grid.AllowUserToResizeRows = false;
            dataGridViewCellStyle16.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Grid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle16;
            this.Grid.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Grid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Grid.BackgroundColor = System.Drawing.SystemColors.Control;
            this.Grid.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Grid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.Grid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle17.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Franklin Gothic Book", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle17.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Grid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle17;
            this.Grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.Grid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codcuenta,
            this.CUENTAN1,
            this.CUENTACONTABLE,
            this.TIPOCUENTA,
            this.NATURALEZA,
            this.CUENTAGENERICA,
            this.GRUPOCUENTA,
            this.REFLEJA,
            this.REFLEJADEPENDE,
            this.CUENTAREFLEJA,
            this.CUENTAREFLEJA2,
            this.CUENTACIERRE,
            this.CIERRE,
            this.ANALITICA,
            this.AJUSTEPOR,
            this.AJUSTECUENTA,
            this.BC});
            this.Grid.Cursor = System.Windows.Forms.Cursors.Default;
            this.Grid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.Grid.Location = new System.Drawing.Point(12, 57);
            this.Grid.Name = "Grid";
            this.Grid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.Grid.RowHeadersVisible = false;
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Franklin Gothic Book", 8.25F);
            this.Grid.RowsDefaultCellStyle = dataGridViewCellStyle18;
            this.Grid.RowTemplate.Height = 16;
            this.Grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Grid.Size = new System.Drawing.Size(738, 197);
            this.Grid.TabIndex = 138;
            this.Grid.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Grid_CellDoubleClick);
            // 
            // codcuenta
            // 
            this.codcuenta.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.codcuenta.DataPropertyName = "CODCUENTA";
            this.codcuenta.HeaderText = "CUENTA";
            this.codcuenta.MinimumWidth = 70;
            this.codcuenta.Name = "codcuenta";
            this.codcuenta.Width = 70;
            // 
            // CUENTAN1
            // 
            this.CUENTAN1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.CUENTAN1.DataPropertyName = "CUENTA N1";
            this.CUENTAN1.HeaderText = "CUENTA N1";
            this.CUENTAN1.MinimumWidth = 100;
            this.CUENTAN1.Name = "CUENTAN1";
            // 
            // CUENTACONTABLE
            // 
            this.CUENTACONTABLE.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CUENTACONTABLE.DataPropertyName = "CUENTA CONTABLE";
            this.CUENTACONTABLE.HeaderText = "CUENTA CONTABLE";
            this.CUENTACONTABLE.MinimumWidth = 150;
            this.CUENTACONTABLE.Name = "CUENTACONTABLE";
            // 
            // TIPOCUENTA
            // 
            this.TIPOCUENTA.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.TIPOCUENTA.DataPropertyName = "TIPO CUENTA";
            this.TIPOCUENTA.HeaderText = "TIPO CUENTA";
            this.TIPOCUENTA.MinimumWidth = 100;
            this.TIPOCUENTA.Name = "TIPOCUENTA";
            // 
            // NATURALEZA
            // 
            this.NATURALEZA.DataPropertyName = "NATURALEZA CUENTA";
            this.NATURALEZA.HeaderText = "NATURALEZA ";
            this.NATURALEZA.Name = "NATURALEZA";
            this.NATURALEZA.Visible = false;
            // 
            // CUENTAGENERICA
            // 
            this.CUENTAGENERICA.DataPropertyName = "CUENTA GENERICA";
            this.CUENTAGENERICA.HeaderText = "CUENTA GENERICA";
            this.CUENTAGENERICA.Name = "CUENTAGENERICA";
            this.CUENTAGENERICA.Visible = false;
            // 
            // GRUPOCUENTA
            // 
            this.GRUPOCUENTA.DataPropertyName = "GRUPO CUENTA";
            this.GRUPOCUENTA.HeaderText = "GRUPOCUENTA";
            this.GRUPOCUENTA.Name = "GRUPOCUENTA";
            this.GRUPOCUENTA.Visible = false;
            // 
            // REFLEJA
            // 
            this.REFLEJA.DataPropertyName = "REFLEJA";
            this.REFLEJA.HeaderText = "REFLEJA";
            this.REFLEJA.Name = "REFLEJA";
            this.REFLEJA.Visible = false;
            // 
            // REFLEJADEPENDE
            // 
            this.REFLEJADEPENDE.DataPropertyName = "REFLEJA DEPENDE";
            this.REFLEJADEPENDE.HeaderText = "REFLEJA DEPENDE";
            this.REFLEJADEPENDE.Name = "REFLEJADEPENDE";
            this.REFLEJADEPENDE.Visible = false;
            // 
            // CUENTAREFLEJA
            // 
            this.CUENTAREFLEJA.DataPropertyName = "CUENTA REFLEJA DEBE";
            this.CUENTAREFLEJA.HeaderText = "CUENTA REFLEJA";
            this.CUENTAREFLEJA.Name = "CUENTAREFLEJA";
            this.CUENTAREFLEJA.Visible = false;
            // 
            // CUENTAREFLEJA2
            // 
            this.CUENTAREFLEJA2.DataPropertyName = "CUENTA REFLEJA HABER";
            this.CUENTAREFLEJA2.HeaderText = "CUENTA REFLEJA 2";
            this.CUENTAREFLEJA2.Name = "CUENTAREFLEJA2";
            this.CUENTAREFLEJA2.Visible = false;
            // 
            // CUENTACIERRE
            // 
            this.CUENTACIERRE.DataPropertyName = "CUENTA CIERRE";
            this.CUENTACIERRE.HeaderText = "CUENTA CIERRE";
            this.CUENTACIERRE.Name = "CUENTACIERRE";
            this.CUENTACIERRE.Visible = false;
            // 
            // CIERRE
            // 
            this.CIERRE.DataPropertyName = "CIERRE";
            this.CIERRE.HeaderText = "CIERRE";
            this.CIERRE.Name = "CIERRE";
            this.CIERRE.Visible = false;
            // 
            // ANALITICA
            // 
            this.ANALITICA.DataPropertyName = "ANALITICA";
            this.ANALITICA.HeaderText = "ANALITICA";
            this.ANALITICA.Name = "ANALITICA";
            this.ANALITICA.Visible = false;
            // 
            // AJUSTEPOR
            // 
            this.AJUSTEPOR.DataPropertyName = "AJUSTE POR TRASLACION";
            this.AJUSTEPOR.HeaderText = "AJUSTE POR";
            this.AJUSTEPOR.Name = "AJUSTEPOR";
            this.AJUSTEPOR.Visible = false;
            // 
            // AJUSTECUENTA
            // 
            this.AJUSTECUENTA.DataPropertyName = "AJUSTE CAMBIO MENSUAL";
            this.AJUSTECUENTA.HeaderText = "AJUSTE CUENTA";
            this.AJUSTECUENTA.Name = "AJUSTECUENTA";
            this.AJUSTECUENTA.Visible = false;
            // 
            // BC
            // 
            this.BC.DataPropertyName = "BC";
            this.BC.HeaderText = "BC";
            this.BC.Name = "BC";
            this.BC.Visible = false;
            // 
            // btnaddselected
            // 
            this.btnaddselected.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnaddselected.Image = ((System.Drawing.Image)(resources.GetObject("btnaddselected.Image")));
            this.btnaddselected.Location = new System.Drawing.Point(498, 257);
            this.btnaddselected.Name = "btnaddselected";
            this.btnaddselected.Size = new System.Drawing.Size(123, 28);
            this.btnaddselected.TabIndex = 150;
            this.btnaddselected.Text = "Agregar Selección";
            this.btnaddselected.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnaddselected.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnaddselected.UseVisualStyleBackColor = true;
            this.btnaddselected.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnlimpiar
            // 
            this.btnlimpiar.BackColor = System.Drawing.Color.White;
            this.btnlimpiar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnlimpiar.BackgroundImage")));
            this.btnlimpiar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnlimpiar.Cursor = System.Windows.Forms.Cursors.Cross;
            this.btnlimpiar.FlatAppearance.BorderSize = 0;
            this.btnlimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnlimpiar.Font = new System.Drawing.Font("Webdings", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(3)));
            this.btnlimpiar.Location = new System.Drawing.Point(91, 12);
            this.btnlimpiar.Name = "btnlimpiar";
            this.btnlimpiar.Size = new System.Drawing.Size(20, 21);
            this.btnlimpiar.TabIndex = 149;
            this.btnlimpiar.UseVisualStyleBackColor = false;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(12, 16);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(51, 13);
            this.label22.TabIndex = 148;
            this.label22.Text = "BUSCAR";
            // 
            // Txtbusca
            // 
            this.Txtbusca.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Txtbusca.BackColor = System.Drawing.Color.White;
            this.Txtbusca.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.Txtbusca.Cursor = System.Windows.Forms.Cursors.Help;
            this.Txtbusca.Location = new System.Drawing.Point(117, 12);
            this.Txtbusca.Name = "Txtbusca";
            this.Txtbusca.Size = new System.Drawing.Size(462, 20);
            this.Txtbusca.TabIndex = 147;
            this.Txtbusca.Click += new System.EventHandler(this.Txtbusca_Click);
            this.Txtbusca.TextChanged += new System.EventHandler(this.Txtbusca_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.radioButton4);
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Location = new System.Drawing.Point(12, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(567, 28);
            this.groupBox1.TabIndex = 146;
            this.groupBox1.TabStop = false;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.radioButton4.Location = new System.Drawing.Point(114, 10);
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
            this.radioButton2.Location = new System.Drawing.Point(202, 10);
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
            // lblmsg
            // 
            this.lblmsg.AutoSize = true;
            this.lblmsg.Location = new System.Drawing.Point(12, 265);
            this.lblmsg.Name = "lblmsg";
            this.lblmsg.Size = new System.Drawing.Size(96, 13);
            this.lblmsg.TabIndex = 151;
            this.lblmsg.Text = "Total de Registros:";
            // 
            // btnaddgroup
            // 
            this.btnaddgroup.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnaddgroup.Image = ((System.Drawing.Image)(resources.GetObject("btnaddgroup.Image")));
            this.btnaddgroup.Location = new System.Drawing.Point(627, 257);
            this.btnaddgroup.Name = "btnaddgroup";
            this.btnaddgroup.Size = new System.Drawing.Size(123, 28);
            this.btnaddgroup.TabIndex = 152;
            this.btnaddgroup.Text = "Agregar Todo";
            this.btnaddgroup.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnaddgroup.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnaddgroup.UseVisualStyleBackColor = true;
            this.btnaddgroup.Click += new System.EventHandler(this.btnaddgroup_Click);
            // 
            // lblmensaje2
            // 
            this.lblmensaje2.AutoSize = true;
            this.lblmensaje2.Location = new System.Drawing.Point(12, 645);
            this.lblmensaje2.Name = "lblmensaje2";
            this.lblmensaje2.Size = new System.Drawing.Size(96, 13);
            this.lblmensaje2.TabIndex = 153;
            this.lblmensaje2.Text = "Total de Registros:";
            // 
            // btncancelar
            // 
            this.btncancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btncancelar.Image = ((System.Drawing.Image)(resources.GetObject("btncancelar.Image")));
            this.btncancelar.Location = new System.Drawing.Point(627, 637);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(123, 28);
            this.btncancelar.TabIndex = 155;
            this.btncancelar.Text = "Cancelar";
            this.btncancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btncancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btncancelar.UseVisualStyleBackColor = true;
            this.btncancelar.Click += new System.EventHandler(this.btncancelar_Click);
            // 
            // btnaceptar
            // 
            this.btnaceptar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnaceptar.Image = ((System.Drawing.Image)(resources.GetObject("btnaceptar.Image")));
            this.btnaceptar.Location = new System.Drawing.Point(498, 637);
            this.btnaceptar.Name = "btnaceptar";
            this.btnaceptar.Size = new System.Drawing.Size(123, 28);
            this.btnaceptar.TabIndex = 154;
            this.btnaceptar.Text = "Aceptar";
            this.btnaceptar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnaceptar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnaceptar.UseVisualStyleBackColor = true;
            this.btnaceptar.Click += new System.EventHandler(this.btnaceptar_Click);
            // 
            // FrmListarCuentasParaConfigurar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(762, 669);
            this.Colores = new System.Drawing.Color[0];
            this.Controls.Add(this.btncancelar);
            this.Controls.Add(this.btnaceptar);
            this.Controls.Add(this.lblmensaje2);
            this.Controls.Add(this.btnaddgroup);
            this.Controls.Add(this.lblmsg);
            this.Controls.Add(this.btnaddselected);
            this.Controls.Add(this.btnlimpiar);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.Txtbusca);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Grid);
            this.Controls.Add(this.dtgConten);
            this.Name = "FrmListarCuentasParaConfigurar";
            this.Text = "Configuración de Cuentas";
            this.Load += new System.EventHandler(this.FrmListarCuentasParaConfigurar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgConten)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Grid)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgConten;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cuentax;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcionx;
        private System.Windows.Forms.DataGridView Grid;
        private System.Windows.Forms.Button btnaddselected;
        private System.Windows.Forms.Button btnlimpiar;
        private System.Windows.Forms.Label label22;
        public System.Windows.Forms.TextBox Txtbusca;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton4;
        public System.Windows.Forms.RadioButton radioButton2;
        public System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Label lblmsg;
        private System.Windows.Forms.Button btnaddgroup;
        private System.Windows.Forms.Label lblmensaje2;
        private System.Windows.Forms.Button btncancelar;
        private System.Windows.Forms.Button btnaceptar;
        private System.Windows.Forms.DataGridViewTextBoxColumn codcuenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn CUENTAN1;
        private System.Windows.Forms.DataGridViewTextBoxColumn CUENTACONTABLE;
        private System.Windows.Forms.DataGridViewTextBoxColumn TIPOCUENTA;
        private System.Windows.Forms.DataGridViewTextBoxColumn NATURALEZA;
        private System.Windows.Forms.DataGridViewTextBoxColumn CUENTAGENERICA;
        private System.Windows.Forms.DataGridViewTextBoxColumn GRUPOCUENTA;
        private System.Windows.Forms.DataGridViewTextBoxColumn REFLEJA;
        private System.Windows.Forms.DataGridViewTextBoxColumn REFLEJADEPENDE;
        private System.Windows.Forms.DataGridViewTextBoxColumn CUENTAREFLEJA;
        private System.Windows.Forms.DataGridViewTextBoxColumn CUENTAREFLEJA2;
        private System.Windows.Forms.DataGridViewTextBoxColumn CUENTACIERRE;
        private System.Windows.Forms.DataGridViewTextBoxColumn CIERRE;
        private System.Windows.Forms.DataGridViewTextBoxColumn ANALITICA;
        private System.Windows.Forms.DataGridViewTextBoxColumn AJUSTEPOR;
        private System.Windows.Forms.DataGridViewTextBoxColumn AJUSTECUENTA;
        private System.Windows.Forms.DataGridViewTextBoxColumn BC;
    }
}