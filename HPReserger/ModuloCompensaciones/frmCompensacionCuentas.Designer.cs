namespace HPReserger.ModuloCompensaciones
{
    partial class frmCompensacionCuentas
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            this.cboempresa = new System.Windows.Forms.ComboBox();
            this.label18 = new System.Windows.Forms.Label();
            this.txtglosa = new HpResergerUserControls.TextBoxPer();
            this.label4 = new System.Windows.Forms.Label();
            this.btnPaso1 = new HpResergerUserControls.ButtonPer();
            this.label1 = new System.Windows.Forms.Label();
            this.dtgconten = new HpResergerUserControls.Dtgconten();
            this.xEmpresa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xBanco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xNameCorto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xNroCta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xEstadoCuenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xFechaCierre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnTxt = new HpResergerUserControls.ButtonPer();
            this.BtnCerrar = new HpResergerUserControls.ButtonPer();
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
            this.cboempresa.Location = new System.Drawing.Point(67, 26);
            this.cboempresa.Name = "cboempresa";
            this.cboempresa.Size = new System.Drawing.Size(344, 21);
            this.cboempresa.TabIndex = 20;
            this.cboempresa.SelectedIndexChanged += new System.EventHandler(this.cboempresa_SelectedIndexChanged);
            this.cboempresa.Click += new System.EventHandler(this.cboempresa_Click);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.BackColor = System.Drawing.Color.Transparent;
            this.label18.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(14, 30);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(53, 13);
            this.label18.TabIndex = 21;
            this.label18.Text = "Empresa:";
            // 
            // txtglosa
            // 
            this.txtglosa.BackColor = System.Drawing.Color.White;
            this.txtglosa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtglosa.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtglosa.ColorFondoMouseEncima = System.Drawing.Color.Empty;
            this.txtglosa.ColorFondoMousePresionado = System.Drawing.Color.Empty;
            this.txtglosa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtglosa.ForeColor = System.Drawing.Color.Black;
            this.txtglosa.Format = null;
            this.txtglosa.Location = new System.Drawing.Point(14, 51);
            this.txtglosa.MaxLength = 300;
            this.txtglosa.Name = "txtglosa";
            this.txtglosa.NextControlOnEnter = null;
            this.txtglosa.Size = new System.Drawing.Size(643, 21);
            this.txtglosa.TabIndex = 351;
            this.txtglosa.Text = "INGRESE CUOS SEPARADOS POR UNA COMA MINIMO 2 CUOS";
            this.txtglosa.TextoDefecto = "INGRESE CUOS SEPARADOS POR UNA COMA MINIMO 2 CUOS";
            this.txtglosa.TextoDefectoColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(129)))), ((int)(((byte)(189)))));
            this.txtglosa.TiposDatos = HpResergerUserControls.TextBoxPer.ListaTipos.MayusculaCadaPalabra;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(14, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(268, 13);
            this.label4.TabIndex = 352;
            this.label4.Text = "1.- Seleccione la Empresa e Ingrese Minimo 2 Cuos";
            // 
            // btnPaso1
            // 
            this.btnPaso1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(129)))), ((int)(((byte)(189)))));
            this.btnPaso1.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnPaso1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPaso1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPaso1.ForeColor = System.Drawing.Color.White;
            this.btnPaso1.Location = new System.Drawing.Point(663, 50);
            this.btnPaso1.Name = "btnPaso1";
            this.btnPaso1.Size = new System.Drawing.Size(75, 23);
            this.btnPaso1.TabIndex = 353;
            this.btnPaso1.Tag = "1";
            this.btnPaso1.Text = "Avanzar";
            this.btnPaso1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPaso1.UseVisualStyleBackColor = false;
            this.btnPaso1.Click += new System.EventHandler(this.btnPaso1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(397, 13);
            this.label1.TabIndex = 354;
            this.label1.Text = "2.- Selecciones las Cuentas a Compensar e Ingrese los Datos para el Asiento";
            // 
            // dtgconten
            // 
            this.dtgconten.AllowUserToAddRows = false;
            this.dtgconten.AllowUserToOrderColumns = true;
            this.dtgconten.AllowUserToResizeColumns = false;
            this.dtgconten.AllowUserToResizeRows = false;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(230)))), ((int)(((byte)(241)))));
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(191)))), ((int)(((byte)(231)))));
            this.dtgconten.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle15;
            this.dtgconten.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgconten.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(218)))), ((int)(((byte)(231)))));
            this.dtgconten.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgconten.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.dtgconten.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(129)))), ((int)(((byte)(189)))));
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle16.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.Color.DeepSkyBlue;
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgconten.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle16;
            this.dtgconten.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgconten.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.xEmpresa,
            this.xBanco,
            this.xNameCorto,
            this.xNroCta,
            this.xEstadoCuenta,
            this.xFechaCierre,
            this.xUsuario});
            dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle20.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle20.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle20.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle20.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(207)))), ((int)(((byte)(241)))));
            dataGridViewCellStyle20.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle20.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgconten.DefaultCellStyle = dataGridViewCellStyle20;
            this.dtgconten.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dtgconten.EnableHeadersVisualStyles = false;
            this.dtgconten.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(179)))), ((int)(((byte)(215)))));
            this.dtgconten.Location = new System.Drawing.Point(14, 91);
            this.dtgconten.Name = "dtgconten";
            this.dtgconten.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle21.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle21.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle21.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle21.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle21.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle21.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgconten.RowHeadersDefaultCellStyle = dataGridViewCellStyle21;
            this.dtgconten.RowHeadersVisible = false;
            this.dtgconten.RowTemplate.Height = 18;
            this.dtgconten.Size = new System.Drawing.Size(724, 346);
            this.dtgconten.TabIndex = 355;
            // 
            // xEmpresa
            // 
            this.xEmpresa.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.xEmpresa.DataPropertyName = "empresa";
            this.xEmpresa.HeaderText = "Empresa";
            this.xEmpresa.MinimumWidth = 150;
            this.xEmpresa.Name = "xEmpresa";
            this.xEmpresa.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // xBanco
            // 
            this.xBanco.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.xBanco.DataPropertyName = "banco";
            this.xBanco.HeaderText = "Banco";
            this.xBanco.MinimumWidth = 100;
            this.xBanco.Name = "xBanco";
            this.xBanco.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // xNameCorto
            // 
            this.xNameCorto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.xNameCorto.DataPropertyName = "namecorto";
            this.xNameCorto.HeaderText = "Moneda";
            this.xNameCorto.MinimumWidth = 80;
            this.xNameCorto.Name = "xNameCorto";
            this.xNameCorto.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.xNameCorto.Width = 80;
            // 
            // xNroCta
            // 
            this.xNroCta.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.xNroCta.DataPropertyName = "Nro_cta";
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.xNroCta.DefaultCellStyle = dataGridViewCellStyle17;
            this.xNroCta.HeaderText = "Nro Cuenta";
            this.xNroCta.MinimumWidth = 100;
            this.xNroCta.Name = "xNroCta";
            this.xNroCta.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // xEstadoCuenta
            // 
            this.xEstadoCuenta.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.xEstadoCuenta.DataPropertyName = "estadocuenta";
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle18.Format = "n2";
            this.xEstadoCuenta.DefaultCellStyle = dataGridViewCellStyle18;
            this.xEstadoCuenta.HeaderText = "Estado Cuenta";
            this.xEstadoCuenta.MinimumWidth = 105;
            this.xEstadoCuenta.Name = "xEstadoCuenta";
            this.xEstadoCuenta.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.xEstadoCuenta.Width = 105;
            // 
            // xFechaCierre
            // 
            this.xFechaCierre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.xFechaCierre.DataPropertyName = "fechacierre";
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle19.Format = "MMMM/yyyy";
            this.xFechaCierre.DefaultCellStyle = dataGridViewCellStyle19;
            this.xFechaCierre.HeaderText = "Fecha Cierre";
            this.xFechaCierre.MinimumWidth = 100;
            this.xFechaCierre.Name = "xFechaCierre";
            this.xFechaCierre.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // xUsuario
            // 
            this.xUsuario.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.xUsuario.DataPropertyName = "usuario";
            this.xUsuario.HeaderText = "Usuario";
            this.xUsuario.MinimumWidth = 50;
            this.xUsuario.Name = "xUsuario";
            this.xUsuario.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.xUsuario.Width = 50;
            // 
            // btnTxt
            // 
            this.btnTxt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTxt.BackColor = System.Drawing.Color.SeaGreen;
            this.btnTxt.FlatAppearance.BorderColor = System.Drawing.Color.Olive;
            this.btnTxt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTxt.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTxt.ForeColor = System.Drawing.Color.White;
            this.btnTxt.Location = new System.Drawing.Point(569, 556);
            this.btnTxt.Name = "btnTxt";
            this.btnTxt.Size = new System.Drawing.Size(83, 23);
            this.btnTxt.TabIndex = 357;
            this.btnTxt.Text = "Procesar";
            this.btnTxt.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTxt.UseVisualStyleBackColor = false;
            this.btnTxt.Visible = false;
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
            this.BtnCerrar.Location = new System.Drawing.Point(655, 556);
            this.BtnCerrar.Name = "BtnCerrar";
            this.BtnCerrar.Size = new System.Drawing.Size(83, 23);
            this.BtnCerrar.TabIndex = 356;
            this.BtnCerrar.Text = "Cancelar";
            this.BtnCerrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnCerrar.UseVisualStyleBackColor = false;
            this.BtnCerrar.Click += new System.EventHandler(this.BtnCerrar_Click);
            // 
            // frmCompensacionCuentas
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(750, 587);
            this.Controls.Add(this.btnTxt);
            this.Controls.Add(this.BtnCerrar);
            this.Controls.Add(this.dtgconten);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnPaso1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtglosa);
            this.Controls.Add(this.cboempresa);
            this.Controls.Add(this.label18);
            this.Name = "frmCompensacionCuentas";
            this.Nombre = "Compensación de Cuentas";
            this.Text = "Compensación de Cuentas";
            this.Load += new System.EventHandler(this.frmCompensacionCuentas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgconten)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboempresa;
        private System.Windows.Forms.Label label18;
        private HpResergerUserControls.TextBoxPer txtglosa;
        private System.Windows.Forms.Label label4;
        private HpResergerUserControls.ButtonPer btnPaso1;
        private System.Windows.Forms.Label label1;
        private HpResergerUserControls.Dtgconten dtgconten;
        private System.Windows.Forms.DataGridViewTextBoxColumn xEmpresa;
        private System.Windows.Forms.DataGridViewTextBoxColumn xBanco;
        private System.Windows.Forms.DataGridViewTextBoxColumn xNameCorto;
        private System.Windows.Forms.DataGridViewTextBoxColumn xNroCta;
        private System.Windows.Forms.DataGridViewTextBoxColumn xEstadoCuenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn xFechaCierre;
        private System.Windows.Forms.DataGridViewTextBoxColumn xUsuario;
        private HpResergerUserControls.ButtonPer btnTxt;
        private HpResergerUserControls.ButtonPer BtnCerrar;
    }
}