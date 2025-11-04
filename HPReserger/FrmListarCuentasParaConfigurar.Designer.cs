using HpResergerUserControls;

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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmListarCuentasParaConfigurar));
            this.dtgConten = new HpResergerUserControls.Dtgconten();
            this.Cuentax = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcionx = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Grid = new HpResergerUserControls.Dtgconten();
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
            this.SolicitaDetallex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xctadetalle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xestadocta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xnestado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnaddselected = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.lblmsg = new System.Windows.Forms.Label();
            this.btnaddgroup = new System.Windows.Forms.Button();
            this.lblmensaje2 = new System.Windows.Forms.Label();
            this.btncancelar = new System.Windows.Forms.Button();
            this.btnaceptar = new System.Windows.Forms.Button();
            this.Txtbusca = new HpResergerUserControls.txtBuscar();
            this.button1 = new System.Windows.Forms.Button();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.btnDuplicados = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.dtgConten)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Grid)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtgConten
            // 
            this.dtgConten.AllowUserToAddRows = false;
            this.dtgConten.AllowUserToDeleteRows = false;
            this.dtgConten.AllowUserToOrderColumns = true;
            this.dtgConten.AllowUserToResizeColumns = false;
            this.dtgConten.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(230)))), ((int)(((byte)(241)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(191)))), ((int)(((byte)(231)))));
            this.dtgConten.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgConten.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgConten.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgConten.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(218)))), ((int)(((byte)(231)))));
            this.dtgConten.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dtgConten.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.dtgConten.CheckColumna = null;
            this.dtgConten.CheckValor = 1;
            this.dtgConten.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(129)))), ((int)(((byte)(189)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DeepSkyBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgConten.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dtgConten.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dtgConten.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Cuentax,
            this.Descripcionx});
            this.dtgConten.Cursor = System.Windows.Forms.Cursors.Default;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(207)))), ((int)(((byte)(241)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgConten.DefaultCellStyle = dataGridViewCellStyle3;
            this.dtgConten.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dtgConten.EnableHeadersVisualStyles = false;
            this.dtgConten.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(179)))), ((int)(((byte)(215)))));
            this.dtgConten.Location = new System.Drawing.Point(12, 289);
            this.dtgConten.Name = "dtgConten";
            this.dtgConten.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dtgConten.RowHeadersVisible = false;
            this.dtgConten.RowTemplate.Height = 16;
            this.dtgConten.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgConten.Size = new System.Drawing.Size(738, 342);
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
            this.Grid.AllowUserToOrderColumns = true;
            this.Grid.AllowUserToResizeColumns = false;
            this.Grid.AllowUserToResizeRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(230)))), ((int)(((byte)(241)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(191)))), ((int)(((byte)(231)))));
            this.Grid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.Grid.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Grid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Grid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(218)))), ((int)(((byte)(231)))));
            this.Grid.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Grid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.Grid.CheckColumna = null;
            this.Grid.CheckValor = 1;
            this.Grid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(129)))), ((int)(((byte)(189)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.DeepSkyBlue;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Grid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
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
            this.BC,
            this.SolicitaDetallex,
            this.xctadetalle,
            this.xestadocta,
            this.xnestado});
            this.Grid.Cursor = System.Windows.Forms.Cursors.Default;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(207)))), ((int)(((byte)(241)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Grid.DefaultCellStyle = dataGridViewCellStyle6;
            this.Grid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.Grid.EnableHeadersVisualStyles = false;
            this.Grid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(179)))), ((int)(((byte)(215)))));
            this.Grid.Location = new System.Drawing.Point(12, 57);
            this.Grid.Name = "Grid";
            this.Grid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.Grid.RowHeadersVisible = false;
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
            this.codcuenta.HeaderText = "Cuenta";
            this.codcuenta.MinimumWidth = 70;
            this.codcuenta.Name = "codcuenta";
            this.codcuenta.Width = 70;
            // 
            // CUENTAN1
            // 
            this.CUENTAN1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.CUENTAN1.DataPropertyName = "CUENTA N1";
            this.CUENTAN1.HeaderText = "Cuenta N1";
            this.CUENTAN1.MinimumWidth = 100;
            this.CUENTAN1.Name = "CUENTAN1";
            // 
            // CUENTACONTABLE
            // 
            this.CUENTACONTABLE.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CUENTACONTABLE.DataPropertyName = "CUENTA CONTABLE";
            this.CUENTACONTABLE.HeaderText = "Cuenta Contable";
            this.CUENTACONTABLE.MinimumWidth = 150;
            this.CUENTACONTABLE.Name = "CUENTACONTABLE";
            // 
            // TIPOCUENTA
            // 
            this.TIPOCUENTA.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.TIPOCUENTA.DataPropertyName = "TIPO CUENTA";
            this.TIPOCUENTA.HeaderText = "Tipo Cuenta";
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
            // SolicitaDetallex
            // 
            this.SolicitaDetallex.DataPropertyName = "solicitar";
            this.SolicitaDetallex.HeaderText = "SolicitaDetalle";
            this.SolicitaDetallex.Name = "SolicitaDetallex";
            this.SolicitaDetallex.Visible = false;
            // 
            // xctadetalle
            // 
            this.xctadetalle.DataPropertyName = "ctadetalle";
            this.xctadetalle.HeaderText = "ctadetalle";
            this.xctadetalle.Name = "xctadetalle";
            this.xctadetalle.Visible = false;
            // 
            // xestadocta
            // 
            this.xestadocta.DataPropertyName = "estadocta";
            this.xestadocta.HeaderText = "estadocuenta";
            this.xestadocta.Name = "xestadocta";
            this.xestadocta.Visible = false;
            // 
            // xnestado
            // 
            this.xnestado.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.xnestado.DataPropertyName = "nestado";
            this.xnestado.HeaderText = "Estado";
            this.xnestado.MinimumWidth = 55;
            this.xnestado.Name = "xnestado";
            this.xnestado.Width = 66;
            // 
            // btnaddselected
            // 
            this.btnaddselected.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnaddselected.Image = ((System.Drawing.Image)(resources.GetObject("btnaddselected.Image")));
            this.btnaddselected.Location = new System.Drawing.Point(498, 259);
            this.btnaddselected.Name = "btnaddselected";
            this.btnaddselected.Size = new System.Drawing.Size(123, 26);
            this.btnaddselected.TabIndex = 150;
            this.btnaddselected.Text = "Agregar Selección";
            this.btnaddselected.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnaddselected.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnaddselected.UseVisualStyleBackColor = true;
            this.btnaddselected.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.radioButton4);
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.radioButton4.Location = new System.Drawing.Point(120, 10);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(85, 18);
            this.radioButton4.TabIndex = 130;
            this.radioButton4.Text = "Cuenta N1";
            this.radioButton4.UseVisualStyleBackColor = true;
            this.radioButton4.CheckedChanged += new System.EventHandler(this.radioButton4_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.radioButton2.Location = new System.Drawing.Point(211, 10);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(118, 18);
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
            this.radioButton1.Size = new System.Drawing.Size(109, 18);
            this.radioButton1.TabIndex = 130;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Código Cuenta";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // lblmsg
            // 
            this.lblmsg.AutoSize = true;
            this.lblmsg.BackColor = System.Drawing.Color.Transparent;
            this.lblmsg.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmsg.Location = new System.Drawing.Point(12, 266);
            this.lblmsg.Name = "lblmsg";
            this.lblmsg.Size = new System.Drawing.Size(102, 13);
            this.lblmsg.TabIndex = 151;
            this.lblmsg.Text = "Total de Registros:";
            // 
            // btnaddgroup
            // 
            this.btnaddgroup.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnaddgroup.Image = ((System.Drawing.Image)(resources.GetObject("btnaddgroup.Image")));
            this.btnaddgroup.Location = new System.Drawing.Point(627, 259);
            this.btnaddgroup.Name = "btnaddgroup";
            this.btnaddgroup.Size = new System.Drawing.Size(123, 26);
            this.btnaddgroup.TabIndex = 152;
            this.btnaddgroup.Text = "Agregar Todo";
            this.btnaddgroup.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnaddgroup.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnaddgroup.UseVisualStyleBackColor = true;
            this.btnaddgroup.Click += new System.EventHandler(this.btnaddgroup_Click);
            // 
            // lblmensaje2
            // 
            this.lblmensaje2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblmensaje2.AutoSize = true;
            this.lblmensaje2.BackColor = System.Drawing.Color.Transparent;
            this.lblmensaje2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmensaje2.Location = new System.Drawing.Point(12, 643);
            this.lblmensaje2.Name = "lblmensaje2";
            this.lblmensaje2.Size = new System.Drawing.Size(102, 13);
            this.lblmensaje2.TabIndex = 153;
            this.lblmensaje2.Text = "Total de Registros:";
            // 
            // btncancelar
            // 
            this.btncancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btncancelar.Image = ((System.Drawing.Image)(resources.GetObject("btncancelar.Image")));
            this.btncancelar.Location = new System.Drawing.Point(627, 636);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(123, 26);
            this.btncancelar.TabIndex = 155;
            this.btncancelar.Text = "Cancelar";
            this.btncancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btncancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btncancelar.UseVisualStyleBackColor = true;
            this.btncancelar.Click += new System.EventHandler(this.btncancelar_Click);
            // 
            // btnaceptar
            // 
            this.btnaceptar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnaceptar.Image = ((System.Drawing.Image)(resources.GetObject("btnaceptar.Image")));
            this.btnaceptar.Location = new System.Drawing.Point(498, 636);
            this.btnaceptar.Name = "btnaceptar";
            this.btnaceptar.Size = new System.Drawing.Size(123, 26);
            this.btnaceptar.TabIndex = 154;
            this.btnaceptar.Text = "Aceptar";
            this.btnaceptar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnaceptar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnaceptar.UseVisualStyleBackColor = true;
            this.btnaceptar.Click += new System.EventHandler(this.btnaceptar_Click);
            // 
            // Txtbusca
            // 
            this.Txtbusca.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Txtbusca.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(218)))), ((int)(((byte)(231)))));
            this.Txtbusca.FondoBoton = ((System.Drawing.Image)(resources.GetObject("Txtbusca.FondoBoton")));
            this.Txtbusca.ImgBotonCerrar = null;
            this.Txtbusca.Location = new System.Drawing.Point(12, 10);
            this.Txtbusca.Name = "Txtbusca";
            this.Txtbusca.Size = new System.Drawing.Size(567, 22);
            this.Txtbusca.TabIndex = 156;
            this.Txtbusca.BuscarClick += new System.EventHandler(this.Txtbusca_TextChanged);
            this.Txtbusca.BuscarTextChanged += new System.EventHandler(this.Txtbusca_TextChanged);
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(320, 259);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(123, 26);
            this.button1.TabIndex = 157;
            this.button1.Text = "CuentaPrueba";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // simpleButton1
            // 
            this.simpleButton1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.simpleButton1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.simpleButton1.Location = new System.Drawing.Point(296, 639);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(107, 23);
            this.simpleButton1.TabIndex = 158;
            this.simpleButton1.Text = "Limpiar todo";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // btnDuplicados
            // 
            this.btnDuplicados.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnDuplicados.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDuplicados.ImageOptions.Image")));
            this.btnDuplicados.Location = new System.Drawing.Point(175, 639);
            this.btnDuplicados.Name = "btnDuplicados";
            this.btnDuplicados.Size = new System.Drawing.Size(117, 23);
            this.btnDuplicados.TabIndex = 159;
            this.btnDuplicados.Text = "Quitar Duplicados";
            this.btnDuplicados.Click += new System.EventHandler(this.btnDuplicados_Click);
            // 
            // FrmListarCuentasParaConfigurar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(762, 669);
            this.Controls.Add(this.btnDuplicados);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Txtbusca);
            this.Controls.Add(this.btncancelar);
            this.Controls.Add(this.btnaceptar);
            this.Controls.Add(this.lblmensaje2);
            this.Controls.Add(this.btnaddgroup);
            this.Controls.Add(this.lblmsg);
            this.Controls.Add(this.btnaddselected);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Grid);
            this.Controls.Add(this.dtgConten);
            this.MinimumSize = new System.Drawing.Size(778, 708);
            this.Name = "FrmListarCuentasParaConfigurar";
            this.Nombre = "Configuración de Cuentas";
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
        
        private Dtgconten dtgConten;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cuentax;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcionx;
        private Dtgconten Grid;
        private System.Windows.Forms.Button btnaddselected;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton4;
        public System.Windows.Forms.RadioButton radioButton2;
        public System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Label lblmsg;
        private System.Windows.Forms.Button btnaddgroup;
        private System.Windows.Forms.Label lblmensaje2;
        private System.Windows.Forms.Button btncancelar;
        private System.Windows.Forms.Button btnaceptar;
        private txtBuscar Txtbusca;
        private System.Windows.Forms.Button button1;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn SolicitaDetallex;
        private System.Windows.Forms.DataGridViewTextBoxColumn xctadetalle;
        private System.Windows.Forms.DataGridViewTextBoxColumn xestadocta;
        private System.Windows.Forms.DataGridViewTextBoxColumn xnestado;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.SimpleButton btnDuplicados;
    }
}