namespace HPReserger
{
    partial class frmlistarSeparacionVta
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmlistarSeparacionVta));
            this.dtgconten = new HpResergerUserControls.Dtgconten();
            this.numcot = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cod_Vend = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dias = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vendedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Desc_Tipo_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nro_Id_Cli = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombres = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Direccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.E_mail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ocupacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telf_Celular = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telf_Fijo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ImporteTotalMN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ImporteTotalME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ValorInicial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TC_Referencial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaVencimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnaceptar = new System.Windows.Forms.Button();
            this.btncancelar = new System.Windows.Forms.Button();
            this.lblmsg = new System.Windows.Forms.Label();
            this.txtBuscar = new HpResergerUserControls.txtBuscar();
            this.label13 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtnumcot = new HpResergerUserControls.TextBoxPer();
            ((System.ComponentModel.ISupportInitialize)(this.dtgconten)).BeginInit();
            this.SuspendLayout();
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
            this.numcot,
            this.Cod_Vend,
            this.dias,
            this.vendedor,
            this.Desc_Tipo_ID,
            this.Nro_Id_Cli,
            this.nombres,
            this.Direccion,
            this.E_mail,
            this.Ocupacion,
            this.Telf_Celular,
            this.Telf_Fijo,
            this.ImporteTotalMN,
            this.ImporteTotalME,
            this.ValorInicial,
            this.TC_Referencial,
            this.FechaVencimiento});
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(207)))), ((int)(((byte)(241)))));
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgconten.DefaultCellStyle = dataGridViewCellStyle10;
            this.dtgconten.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dtgconten.EnableHeadersVisualStyles = false;
            this.dtgconten.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(179)))), ((int)(((byte)(215)))));
            this.dtgconten.Location = new System.Drawing.Point(12, 40);
            this.dtgconten.Name = "dtgconten";
            this.dtgconten.ReadOnly = true;
            this.dtgconten.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dtgconten.RowHeadersVisible = false;
            this.dtgconten.RowTemplate.Height = 18;
            this.dtgconten.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgconten.Size = new System.Drawing.Size(960, 453);
            this.dtgconten.TabIndex = 188;
            this.dtgconten.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgconten_CellDoubleClick);
            this.dtgconten.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgconten_RowEnter);
            // 
            // numcot
            // 
            this.numcot.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.numcot.DataPropertyName = "numcot";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.Format = "00000";
            this.numcot.DefaultCellStyle = dataGridViewCellStyle3;
            this.numcot.HeaderText = "NumCot";
            this.numcot.Name = "numcot";
            this.numcot.ReadOnly = true;
            this.numcot.Width = 73;
            // 
            // Cod_Vend
            // 
            this.Cod_Vend.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Cod_Vend.DataPropertyName = "Cod_Vend";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle4.Format = "000";
            this.Cod_Vend.DefaultCellStyle = dataGridViewCellStyle4;
            this.Cod_Vend.HeaderText = "Cod.Vend.";
            this.Cod_Vend.Name = "Cod_Vend";
            this.Cod_Vend.ReadOnly = true;
            this.Cod_Vend.Visible = false;
            // 
            // dias
            // 
            this.dias.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dias.DataPropertyName = "dias";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.dias.DefaultCellStyle = dataGridViewCellStyle5;
            this.dias.HeaderText = "DiasFin";
            this.dias.Name = "dias";
            this.dias.ReadOnly = true;
            this.dias.Width = 69;
            // 
            // vendedor
            // 
            this.vendedor.DataPropertyName = "vendedor";
            this.vendedor.HeaderText = "vendedor";
            this.vendedor.Name = "vendedor";
            this.vendedor.ReadOnly = true;
            this.vendedor.Visible = false;
            // 
            // Desc_Tipo_ID
            // 
            this.Desc_Tipo_ID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Desc_Tipo_ID.DataPropertyName = "Desc_Tipo_ID";
            this.Desc_Tipo_ID.HeaderText = "TipoDoc.";
            this.Desc_Tipo_ID.Name = "Desc_Tipo_ID";
            this.Desc_Tipo_ID.ReadOnly = true;
            this.Desc_Tipo_ID.Width = 76;
            // 
            // Nro_Id_Cli
            // 
            this.Nro_Id_Cli.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Nro_Id_Cli.DataPropertyName = "Nro_Id_Cli";
            this.Nro_Id_Cli.HeaderText = "Nro.Doc.";
            this.Nro_Id_Cli.Name = "Nro_Id_Cli";
            this.Nro_Id_Cli.ReadOnly = true;
            this.Nro_Id_Cli.Width = 76;
            // 
            // nombres
            // 
            this.nombres.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nombres.DataPropertyName = "nombres";
            this.nombres.HeaderText = "Nombre Cliente";
            this.nombres.MinimumWidth = 100;
            this.nombres.Name = "nombres";
            this.nombres.ReadOnly = true;
            // 
            // Direccion
            // 
            this.Direccion.DataPropertyName = "Direccion";
            this.Direccion.HeaderText = "Direccion";
            this.Direccion.Name = "Direccion";
            this.Direccion.ReadOnly = true;
            this.Direccion.Visible = false;
            // 
            // E_mail
            // 
            this.E_mail.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.E_mail.DataPropertyName = "E_mail";
            this.E_mail.HeaderText = "E-mail";
            this.E_mail.Name = "E_mail";
            this.E_mail.ReadOnly = true;
            this.E_mail.Width = 62;
            // 
            // Ocupacion
            // 
            this.Ocupacion.DataPropertyName = "Ocupacion";
            this.Ocupacion.HeaderText = "Ocupacion";
            this.Ocupacion.Name = "Ocupacion";
            this.Ocupacion.ReadOnly = true;
            this.Ocupacion.Visible = false;
            // 
            // Telf_Celular
            // 
            this.Telf_Celular.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Telf_Celular.DataPropertyName = "Telf_Celular";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.Telf_Celular.DefaultCellStyle = dataGridViewCellStyle6;
            this.Telf_Celular.HeaderText = "Tel.Celular";
            this.Telf_Celular.Name = "Telf_Celular";
            this.Telf_Celular.ReadOnly = true;
            this.Telf_Celular.Width = 83;
            // 
            // Telf_Fijo
            // 
            this.Telf_Fijo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Telf_Fijo.DataPropertyName = "Telf_Fijo";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.Telf_Fijo.DefaultCellStyle = dataGridViewCellStyle7;
            this.Telf_Fijo.HeaderText = "Tel.Fijo";
            this.Telf_Fijo.Name = "Telf_Fijo";
            this.Telf_Fijo.ReadOnly = true;
            this.Telf_Fijo.Width = 66;
            // 
            // ImporteTotalMN
            // 
            this.ImporteTotalMN.DataPropertyName = "ImporteTotal";
            this.ImporteTotalMN.HeaderText = "ImporteTotalMN";
            this.ImporteTotalMN.Name = "ImporteTotalMN";
            this.ImporteTotalMN.ReadOnly = true;
            this.ImporteTotalMN.Visible = false;
            // 
            // ImporteTotalME
            // 
            this.ImporteTotalME.DataPropertyName = "Observaciones";
            this.ImporteTotalME.HeaderText = "ImporteTotalME";
            this.ImporteTotalME.Name = "ImporteTotalME";
            this.ImporteTotalME.ReadOnly = true;
            this.ImporteTotalME.Visible = false;
            // 
            // ValorInicial
            // 
            this.ValorInicial.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.ValorInicial.DataPropertyName = "ValorInicial";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle8.Format = "n2";
            this.ValorInicial.DefaultCellStyle = dataGridViewCellStyle8;
            this.ValorInicial.HeaderText = "ValorInicial";
            this.ValorInicial.Name = "ValorInicial";
            this.ValorInicial.ReadOnly = true;
            this.ValorInicial.Width = 87;
            // 
            // TC_Referencial
            // 
            this.TC_Referencial.DataPropertyName = "TC_Referencial";
            this.TC_Referencial.HeaderText = "TC_Referencial";
            this.TC_Referencial.Name = "TC_Referencial";
            this.TC_Referencial.ReadOnly = true;
            this.TC_Referencial.Visible = false;
            // 
            // FechaVencimiento
            // 
            this.FechaVencimiento.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.FechaVencimiento.DataPropertyName = "FechaVencimiento";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle9.Format = "dd/MM/yyyy";
            this.FechaVencimiento.DefaultCellStyle = dataGridViewCellStyle9;
            this.FechaVencimiento.HeaderText = "Fech.Venc.";
            this.FechaVencimiento.Name = "FechaVencimiento";
            this.FechaVencimiento.ReadOnly = true;
            this.FechaVencimiento.Width = 85;
            // 
            // btnaceptar
            // 
            this.btnaceptar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnaceptar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(129)))), ((int)(((byte)(189)))));
            this.btnaceptar.DialogResult = System.Windows.Forms.DialogResult.Yes;
            this.btnaceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnaceptar.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnaceptar.ForeColor = System.Drawing.Color.White;
            this.btnaceptar.Image = ((System.Drawing.Image)(resources.GetObject("btnaceptar.Image")));
            this.btnaceptar.Location = new System.Drawing.Point(802, 499);
            this.btnaceptar.Name = "btnaceptar";
            this.btnaceptar.Size = new System.Drawing.Size(82, 25);
            this.btnaceptar.TabIndex = 189;
            this.btnaceptar.Text = "Aceptar";
            this.btnaceptar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnaceptar.UseVisualStyleBackColor = false;
            this.btnaceptar.Click += new System.EventHandler(this.btnaceptar_Click);
            // 
            // btncancelar
            // 
            this.btncancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btncancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btncancelar.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncancelar.Image = ((System.Drawing.Image)(resources.GetObject("btncancelar.Image")));
            this.btncancelar.Location = new System.Drawing.Point(890, 499);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(82, 25);
            this.btncancelar.TabIndex = 190;
            this.btncancelar.Text = "Cancelar";
            this.btncancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btncancelar.UseVisualStyleBackColor = true;
            this.btncancelar.Click += new System.EventHandler(this.btncancelar_Click);
            // 
            // lblmsg
            // 
            this.lblmsg.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblmsg.BackColor = System.Drawing.Color.Transparent;
            this.lblmsg.Location = new System.Drawing.Point(12, 503);
            this.lblmsg.Name = "lblmsg";
            this.lblmsg.Size = new System.Drawing.Size(133, 16);
            this.lblmsg.TabIndex = 194;
            this.lblmsg.Text = "Total de Registros : 0";
            // 
            // txtBuscar
            // 
            this.txtBuscar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.txtBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(218)))), ((int)(((byte)(231)))));
            this.txtBuscar.FondoBoton = ((System.Drawing.Image)(resources.GetObject("txtBuscar.FondoBoton")));
            this.txtBuscar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscar.ImgBotonCerrar = null;
            this.txtBuscar.Location = new System.Drawing.Point(103, 12);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(184, 22);
            this.txtBuscar.TabIndex = 195;
            this.txtBuscar.BuscarClick += new System.EventHandler(this.txtBuscar_BuscarTextChanged);
            this.txtBuscar.BuscarTextChanged += new System.EventHandler(this.txtBuscar_BuscarTextChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Location = new System.Drawing.Point(12, 17);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(86, 13);
            this.label13.TabIndex = 196;
            this.label13.Text = "Nombre/E-mail:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(305, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 196;
            this.label1.Text = "Nro.Documento:";
            // 
            // txtnumcot
            // 
            this.txtnumcot.BackColor = System.Drawing.Color.White;
            this.txtnumcot.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtnumcot.ColorFondoMouseEncima = System.Drawing.Color.Empty;
            this.txtnumcot.ColorFondoMousePresionado = System.Drawing.Color.Empty;
            this.txtnumcot.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnumcot.ForeColor = System.Drawing.Color.Black;
            this.txtnumcot.Location = new System.Drawing.Point(396, 13);
            this.txtnumcot.MaxLength = 10;
            this.txtnumcot.Name = "txtnumcot";
            this.txtnumcot.NextControlOnEnter = null;
            this.txtnumcot.Size = new System.Drawing.Size(184, 21);
            this.txtnumcot.TabIndex = 197;
            this.txtnumcot.Text = "000";
            this.txtnumcot.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtnumcot.TextoDefecto = "000";
            this.txtnumcot.TextoDefectoColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(129)))), ((int)(((byte)(189)))));
            this.txtnumcot.TiposDatos = HpResergerUserControls.TextBoxPer.ListaTipos.SoloNumeros;
            this.txtnumcot.TextChanged += new System.EventHandler(this.txtBuscar_BuscarTextChanged);
            // 
            // frmlistarSeparacionVta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 531);
            this.Controls.Add(this.txtnumcot);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.lblmsg);
            this.Controls.Add(this.btnaceptar);
            this.Controls.Add(this.btncancelar);
            this.Controls.Add(this.dtgconten);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinimumSize = new System.Drawing.Size(1000, 570);
            this.Name = "frmlistarSeparacionVta";
            this.Nombre = "Lista Cotizaciones por Abonar";
            this.Text = "Lista Cotizaciones por Abonar";
            this.Load += new System.EventHandler(this.frmlistarSeparacionVta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgconten)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private HpResergerUserControls.Dtgconten dtgconten;
        private System.Windows.Forms.Button btnaceptar;
        private System.Windows.Forms.Button btncancelar;
        private System.Windows.Forms.Label lblmsg;
        private HpResergerUserControls.txtBuscar txtBuscar;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label1;
        private HpResergerUserControls.TextBoxPer txtnumcot;
        private System.Windows.Forms.DataGridViewTextBoxColumn numcot;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cod_Vend;
        private System.Windows.Forms.DataGridViewTextBoxColumn dias;
        private System.Windows.Forms.DataGridViewTextBoxColumn vendedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Desc_Tipo_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nro_Id_Cli;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombres;
        private System.Windows.Forms.DataGridViewTextBoxColumn Direccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn E_mail;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ocupacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telf_Celular;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telf_Fijo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ImporteTotalMN;
        private System.Windows.Forms.DataGridViewTextBoxColumn ImporteTotalME;
        private System.Windows.Forms.DataGridViewTextBoxColumn ValorInicial;
        private System.Windows.Forms.DataGridViewTextBoxColumn TC_Referencial;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaVencimiento;
    }
}