using HpResergerUserControls;

namespace HPReserger
{
    partial class frmpresupuesto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmpresupuesto));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.gp1 = new System.Windows.Forms.GroupBox();
            this.txtimporte = new System.Windows.Forms.TextBox();
            this.cbomoneda = new System.Windows.Forms.ComboBox();
            this.cbotipo = new System.Windows.Forms.ComboBox();
            this.cboempresa = new System.Windows.Forms.ComboBox();
            this.txtejercicio = new System.Windows.Forms.TextBox();
            this.txtdescripcion = new System.Windows.Forms.TextBox();
            this.txtnumero = new System.Windows.Forms.TextBox();
            this.btnnuevo = new System.Windows.Forms.Button();
            this.btnmodificar = new System.Windows.Forms.Button();
            this.btndetalle = new System.Windows.Forms.Button();
            this.dtgconten = new HpResergerUserControls.Dtgconten();
            this.idppto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Partidappto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EMPRESA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TIPOS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ejercicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_empresa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.importe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.moneda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipo_ppto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnaceptar = new System.Windows.Forms.Button();
            this.btncancelar = new System.Windows.Forms.Button();
            this.gp1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgconten)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Presupuesto Nº:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Presupuesto Des:.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Presupuesto Ejercicio:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(77, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Empresa:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(411, 92);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Importe:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(429, 43);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Tipo:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(408, 67);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Moneda:";
            // 
            // gp1
            // 
            this.gp1.BackColor = System.Drawing.Color.Transparent;
            this.gp1.Controls.Add(this.txtimporte);
            this.gp1.Controls.Add(this.cbomoneda);
            this.gp1.Controls.Add(this.cbotipo);
            this.gp1.Controls.Add(this.cboempresa);
            this.gp1.Controls.Add(this.txtejercicio);
            this.gp1.Controls.Add(this.label5);
            this.gp1.Controls.Add(this.txtdescripcion);
            this.gp1.Controls.Add(this.label7);
            this.gp1.Controls.Add(this.label6);
            this.gp1.Controls.Add(this.txtnumero);
            this.gp1.Controls.Add(this.label1);
            this.gp1.Controls.Add(this.label2);
            this.gp1.Controls.Add(this.label3);
            this.gp1.Controls.Add(this.label4);
            this.gp1.Enabled = false;
            this.gp1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gp1.Location = new System.Drawing.Point(9, 0);
            this.gp1.Name = "gp1";
            this.gp1.Size = new System.Drawing.Size(611, 115);
            this.gp1.TabIndex = 7;
            this.gp1.TabStop = false;
            // 
            // txtimporte
            // 
            this.txtimporte.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtimporte.Location = new System.Drawing.Point(462, 88);
            this.txtimporte.Name = "txtimporte";
            this.txtimporte.Size = new System.Drawing.Size(143, 21);
            this.txtimporte.TabIndex = 13;
            this.txtimporte.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtimporte.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtimporte_KeyDown);
            this.txtimporte.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtimporte_KeyPress);
            // 
            // cbomoneda
            // 
            this.cbomoneda.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbomoneda.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbomoneda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(218)))), ((int)(((byte)(231)))));
            this.cbomoneda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbomoneda.FormattingEnabled = true;
            this.cbomoneda.Location = new System.Drawing.Point(462, 63);
            this.cbomoneda.Name = "cbomoneda";
            this.cbomoneda.Size = new System.Drawing.Size(143, 21);
            this.cbomoneda.TabIndex = 12;
            // 
            // cbotipo
            // 
            this.cbotipo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbotipo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbotipo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(218)))), ((int)(((byte)(231)))));
            this.cbotipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbotipo.FormattingEnabled = true;
            this.cbotipo.Location = new System.Drawing.Point(462, 39);
            this.cbotipo.Name = "cbotipo";
            this.cbotipo.Size = new System.Drawing.Size(143, 21);
            this.cbotipo.TabIndex = 11;
            // 
            // cboempresa
            // 
            this.cboempresa.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboempresa.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboempresa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(218)))), ((int)(((byte)(231)))));
            this.cboempresa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboempresa.FormattingEnabled = true;
            this.cboempresa.Location = new System.Drawing.Point(130, 88);
            this.cboempresa.Name = "cboempresa";
            this.cboempresa.Size = new System.Drawing.Size(271, 21);
            this.cboempresa.TabIndex = 10;
            // 
            // txtejercicio
            // 
            this.txtejercicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtejercicio.Location = new System.Drawing.Point(130, 63);
            this.txtejercicio.MaxLength = 4;
            this.txtejercicio.Name = "txtejercicio";
            this.txtejercicio.Size = new System.Drawing.Size(74, 21);
            this.txtejercicio.TabIndex = 9;
            this.txtejercicio.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtejercicio.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtejercicio_KeyDown);
            this.txtejercicio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtejercicio_KeyPress);
            // 
            // txtdescripcion
            // 
            this.txtdescripcion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtdescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdescripcion.Location = new System.Drawing.Point(130, 39);
            this.txtdescripcion.Name = "txtdescripcion";
            this.txtdescripcion.Size = new System.Drawing.Size(271, 21);
            this.txtdescripcion.TabIndex = 8;
            // 
            // txtnumero
            // 
            this.txtnumero.Enabled = false;
            this.txtnumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnumero.Location = new System.Drawing.Point(130, 15);
            this.txtnumero.Name = "txtnumero";
            this.txtnumero.Size = new System.Drawing.Size(74, 21);
            this.txtnumero.TabIndex = 7;
            // 
            // btnnuevo
            // 
            this.btnnuevo.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnnuevo.Image = ((System.Drawing.Image)(resources.GetObject("btnnuevo.Image")));
            this.btnnuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnnuevo.Location = new System.Drawing.Point(624, 12);
            this.btnnuevo.Name = "btnnuevo";
            this.btnnuevo.Size = new System.Drawing.Size(80, 24);
            this.btnnuevo.TabIndex = 8;
            this.btnnuevo.Text = "Nuevo";
            this.btnnuevo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnnuevo.UseVisualStyleBackColor = true;
            this.btnnuevo.Click += new System.EventHandler(this.btnnuevo_Click);
            // 
            // btnmodificar
            // 
            this.btnmodificar.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmodificar.Image = ((System.Drawing.Image)(resources.GetObject("btnmodificar.Image")));
            this.btnmodificar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnmodificar.Location = new System.Drawing.Point(624, 39);
            this.btnmodificar.Name = "btnmodificar";
            this.btnmodificar.Size = new System.Drawing.Size(80, 24);
            this.btnmodificar.TabIndex = 9;
            this.btnmodificar.Text = "Modificar";
            this.btnmodificar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnmodificar.UseVisualStyleBackColor = true;
            this.btnmodificar.Click += new System.EventHandler(this.btnmodificar_Click);
            // 
            // btndetalle
            // 
            this.btndetalle.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndetalle.Image = ((System.Drawing.Image)(resources.GetObject("btndetalle.Image")));
            this.btndetalle.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btndetalle.Location = new System.Drawing.Point(624, 67);
            this.btndetalle.Name = "btndetalle";
            this.btndetalle.Size = new System.Drawing.Size(80, 24);
            this.btndetalle.TabIndex = 10;
            this.btndetalle.Text = "Detalle";
            this.btndetalle.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btndetalle.UseVisualStyleBackColor = true;
            this.btndetalle.Click += new System.EventHandler(this.btndetalle_Click);
            // 
            // dtgconten
            // 
            this.dtgconten.AllowUserToAddRows = false;
            this.dtgconten.AllowUserToDeleteRows = false;
            this.dtgconten.AllowUserToOrderColumns = true;
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
            this.dtgconten.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
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
            this.dtgconten.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dtgconten.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idppto,
            this.Partidappto,
            this.EMPRESA,
            this.TIPOS,
            this.Ejercicio,
            this.id_empresa,
            this.importe,
            this.moneda,
            this.usuario,
            this.fecha,
            this.tipo_ppto});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(207)))), ((int)(((byte)(241)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgconten.DefaultCellStyle = dataGridViewCellStyle4;
            this.dtgconten.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dtgconten.EnableHeadersVisualStyles = false;
            this.dtgconten.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(179)))), ((int)(((byte)(215)))));
            this.dtgconten.Location = new System.Drawing.Point(12, 121);
            this.dtgconten.MultiSelect = false;
            this.dtgconten.Name = "dtgconten";
            this.dtgconten.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dtgconten.RowHeadersVisible = false;
            this.dtgconten.RowTemplate.Height = 16;
            this.dtgconten.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgconten.Size = new System.Drawing.Size(692, 368);
            this.dtgconten.TabIndex = 11;
            this.dtgconten.TabStop = false;
            this.dtgconten.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgconten_CellDoubleClick);
            this.dtgconten.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgconten_RowEnter);
            // 
            // idppto
            // 
            this.idppto.DataPropertyName = "id_ppresupuesto";
            this.idppto.HeaderText = "idppto";
            this.idppto.Name = "idppto";
            this.idppto.Visible = false;
            // 
            // Partidappto
            // 
            this.Partidappto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Partidappto.DataPropertyName = "partidappto";
            this.Partidappto.HeaderText = "PartidaPpto";
            this.Partidappto.Name = "Partidappto";
            // 
            // EMPRESA
            // 
            this.EMPRESA.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.EMPRESA.DataPropertyName = "Empresa";
            this.EMPRESA.HeaderText = "Empresa";
            this.EMPRESA.Name = "EMPRESA";
            this.EMPRESA.Width = 76;
            // 
            // TIPOS
            // 
            this.TIPOS.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.TIPOS.DataPropertyName = "TIPOS";
            this.TIPOS.HeaderText = "Tipos";
            this.TIPOS.Name = "TIPOS";
            this.TIPOS.Width = 60;
            // 
            // Ejercicio
            // 
            this.Ejercicio.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Ejercicio.DataPropertyName = "ejecicio";
            this.Ejercicio.HeaderText = "Ejercicio";
            this.Ejercicio.Name = "Ejercicio";
            this.Ejercicio.Width = 75;
            // 
            // id_empresa
            // 
            this.id_empresa.DataPropertyName = "id_empresa";
            this.id_empresa.HeaderText = "id_empresa";
            this.id_empresa.Name = "id_empresa";
            this.id_empresa.Visible = false;
            // 
            // importe
            // 
            this.importe.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.importe.DataPropertyName = "importe";
            this.importe.HeaderText = "Importe";
            this.importe.Name = "importe";
            this.importe.Width = 73;
            // 
            // moneda
            // 
            this.moneda.DataPropertyName = "moneda";
            this.moneda.HeaderText = "moneda";
            this.moneda.Name = "moneda";
            this.moneda.Visible = false;
            // 
            // usuario
            // 
            this.usuario.DataPropertyName = "usuario";
            this.usuario.HeaderText = "usuario";
            this.usuario.Name = "usuario";
            this.usuario.Visible = false;
            // 
            // fecha
            // 
            this.fecha.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.fecha.DataPropertyName = "fecha";
            dataGridViewCellStyle3.Format = "d";
            dataGridViewCellStyle3.NullValue = null;
            this.fecha.DefaultCellStyle = dataGridViewCellStyle3;
            this.fecha.HeaderText = "Fecha";
            this.fecha.Name = "fecha";
            this.fecha.Width = 62;
            // 
            // tipo_ppto
            // 
            this.tipo_ppto.DataPropertyName = "tipo_ppto";
            this.tipo_ppto.HeaderText = "Tipo";
            this.tipo_ppto.Name = "tipo_ppto";
            this.tipo_ppto.Visible = false;
            // 
            // btnaceptar
            // 
            this.btnaceptar.Enabled = false;
            this.btnaceptar.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnaceptar.Image = ((System.Drawing.Image)(resources.GetObject("btnaceptar.Image")));
            this.btnaceptar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnaceptar.Location = new System.Drawing.Point(545, 495);
            this.btnaceptar.Name = "btnaceptar";
            this.btnaceptar.Size = new System.Drawing.Size(80, 24);
            this.btnaceptar.TabIndex = 12;
            this.btnaceptar.Text = "Aceptar";
            this.btnaceptar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnaceptar.UseVisualStyleBackColor = true;
            this.btnaceptar.Click += new System.EventHandler(this.btnaceptar_Click);
            // 
            // btncancelar
            // 
            this.btncancelar.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncancelar.Image = ((System.Drawing.Image)(resources.GetObject("btncancelar.Image")));
            this.btncancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btncancelar.Location = new System.Drawing.Point(626, 495);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(80, 24);
            this.btncancelar.TabIndex = 13;
            this.btncancelar.Text = "Cancelar";
            this.btncancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btncancelar.UseVisualStyleBackColor = true;
            this.btncancelar.Click += new System.EventHandler(this.btncancelar_Click);
            // 
            // frmpresupuesto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(718, 527);
            this.Controls.Add(this.btncancelar);
            this.Controls.Add(this.btnaceptar);
            this.Controls.Add(this.dtgconten);
            this.Controls.Add(this.gp1);
            this.Controls.Add(this.btndetalle);
            this.Controls.Add(this.btnnuevo);
            this.Controls.Add(this.btnmodificar);
            this.MaximumSize = new System.Drawing.Size(734, 566);
            this.MinimumSize = new System.Drawing.Size(734, 566);
            this.Name = "frmpresupuesto";
            this.Nombre = "Presupuestos";
            this.Text = "Presupuestos";
            this.Load += new System.EventHandler(this.frmpresupuesto_Load);
            this.gp1.ResumeLayout(false);
            this.gp1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgconten)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox gp1;
        private Dtgconten dtgconten;
        private System.Windows.Forms.Button btndetalle;
        private System.Windows.Forms.Button btnmodificar;
        private System.Windows.Forms.Button btnnuevo;
        private System.Windows.Forms.TextBox txtimporte;
        private System.Windows.Forms.ComboBox cbomoneda;
        private System.Windows.Forms.ComboBox cbotipo;
        private System.Windows.Forms.ComboBox cboempresa;
        private System.Windows.Forms.TextBox txtejercicio;
        private System.Windows.Forms.TextBox txtdescripcion;
        private System.Windows.Forms.TextBox txtnumero;
        private System.Windows.Forms.Button btnaceptar;
        private System.Windows.Forms.Button btncancelar;
        private System.Windows.Forms.DataGridViewTextBoxColumn idppto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Partidappto;
        private System.Windows.Forms.DataGridViewTextBoxColumn EMPRESA;
        private System.Windows.Forms.DataGridViewTextBoxColumn TIPOS;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ejercicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_empresa;
        private System.Windows.Forms.DataGridViewTextBoxColumn importe;
        private System.Windows.Forms.DataGridViewTextBoxColumn moneda;
        private System.Windows.Forms.DataGridViewTextBoxColumn usuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipo_ppto;
    }
}