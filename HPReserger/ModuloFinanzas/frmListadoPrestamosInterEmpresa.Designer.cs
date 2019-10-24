namespace HPReserger.ModuloFinanzas
{
    partial class frmListadoPrestamosInterEmpresa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmListadoPrestamosInterEmpresa));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtTotal = new HpResergerUserControls.TextBoxPer();
            this.label7 = new System.Windows.Forms.Label();
            this.btnaceptar = new System.Windows.Forms.Button();
            this.btncancelar = new System.Windows.Forms.Button();
            this.lblmsg = new System.Windows.Forms.Label();
            this.dtgconten = new HpResergerUserControls.Dtgconten();
            this.xbancoOrigen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xctaOrigenBanco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xCuoOrigen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xBancoDestino = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xCtaBancoDestino = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xCuoDestino = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xMoneda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xMonto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xNroOperacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xFechaAbono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xGlosa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtempresaorigen = new HpResergerUserControls.TextBoxPer();
            this.label21 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtempresadestino = new HpResergerUserControls.TextBoxPer();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtglosa = new HpResergerUserControls.TextBoxPer();
            this.separadorOre2 = new HpResergerUserControls.SeparadorOre();
            ((System.ComponentModel.ISupportInitialize)(this.dtgconten)).BeginInit();
            this.SuspendLayout();
            // 
            // txtTotal
            // 
            this.txtTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTotal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(218)))), ((int)(((byte)(231)))));
            this.txtTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTotal.ColorFondoMouseEncima = System.Drawing.Color.Empty;
            this.txtTotal.ColorFondoMousePresionado = System.Drawing.Color.Empty;
            this.txtTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.ForeColor = System.Drawing.Color.Black;
            this.txtTotal.Format = "n2";
            this.txtTotal.Location = new System.Drawing.Point(708, 334);
            this.txtTotal.MaxLength = 11;
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.NextControlOnEnter = null;
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(92, 21);
            this.txtTotal.TabIndex = 395;
            this.txtTotal.Text = "0.00";
            this.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtTotal.TextoDefecto = "0.00";
            this.txtTotal.TextoDefectoColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(129)))), ((int)(((byte)(189)))));
            this.txtTotal.TiposDatos = HpResergerUserControls.TextBoxPer.ListaTipos.SoloDinero;
            this.txtTotal.Visible = false;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(674, 338);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 13);
            this.label7.TabIndex = 394;
            this.label7.Text = "Total:";
            this.label7.Visible = false;
            // 
            // btnaceptar
            // 
            this.btnaceptar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnaceptar.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnaceptar.Image = ((System.Drawing.Image)(resources.GetObject("btnaceptar.Image")));
            this.btnaceptar.Location = new System.Drawing.Point(801, 333);
            this.btnaceptar.Name = "btnaceptar";
            this.btnaceptar.Size = new System.Drawing.Size(85, 23);
            this.btnaceptar.TabIndex = 392;
            this.btnaceptar.Text = "Abonar";
            this.btnaceptar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnaceptar.UseVisualStyleBackColor = true;
            this.btnaceptar.Visible = false;
            // 
            // btncancelar
            // 
            this.btncancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btncancelar.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncancelar.Image = ((System.Drawing.Image)(resources.GetObject("btncancelar.Image")));
            this.btncancelar.Location = new System.Drawing.Point(887, 333);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(85, 23);
            this.btncancelar.TabIndex = 393;
            this.btncancelar.Text = "Cancelar";
            this.btncancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btncancelar.UseVisualStyleBackColor = true;
            this.btncancelar.Click += new System.EventHandler(this.btncancelar_Click);
            // 
            // lblmsg
            // 
            this.lblmsg.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblmsg.AutoSize = true;
            this.lblmsg.BackColor = System.Drawing.Color.Transparent;
            this.lblmsg.Location = new System.Drawing.Point(14, 338);
            this.lblmsg.Name = "lblmsg";
            this.lblmsg.Size = new System.Drawing.Size(113, 13);
            this.lblmsg.TabIndex = 391;
            this.lblmsg.Text = "Total de Registros : 0";
            // 
            // dtgconten
            // 
            this.dtgconten.AllowUserToAddRows = false;
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
            this.dtgconten.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgconten.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.xbancoOrigen,
            this.xctaOrigenBanco,
            this.xCuoOrigen,
            this.xBancoDestino,
            this.xCtaBancoDestino,
            this.xCuoDestino,
            this.xMoneda,
            this.xMonto,
            this.xNroOperacion,
            this.xFechaAbono,
            this.xGlosa});
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
            this.dtgconten.Location = new System.Drawing.Point(17, 103);
            this.dtgconten.Name = "dtgconten";
            this.dtgconten.ReadOnly = true;
            this.dtgconten.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dtgconten.RowHeadersVisible = false;
            this.dtgconten.RowTemplate.Height = 18;
            this.dtgconten.Size = new System.Drawing.Size(955, 225);
            this.dtgconten.TabIndex = 396;
            // 
            // xbancoOrigen
            // 
            this.xbancoOrigen.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.xbancoOrigen.DataPropertyName = "BancoOrigen";
            this.xbancoOrigen.HeaderText = "BancoOrigen";
            this.xbancoOrigen.MinimumWidth = 100;
            this.xbancoOrigen.Name = "xbancoOrigen";
            this.xbancoOrigen.ReadOnly = true;
            // 
            // xctaOrigenBanco
            // 
            this.xctaOrigenBanco.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.xctaOrigenBanco.DataPropertyName = "CtaBancoOrigen";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.xctaOrigenBanco.DefaultCellStyle = dataGridViewCellStyle3;
            this.xctaOrigenBanco.FillWeight = 563.1068F;
            this.xctaOrigenBanco.HeaderText = "CtaBancoOrigen";
            this.xctaOrigenBanco.MinimumWidth = 90;
            this.xctaOrigenBanco.Name = "xctaOrigenBanco";
            this.xctaOrigenBanco.ReadOnly = true;
            this.xctaOrigenBanco.Width = 116;
            // 
            // xCuoOrigen
            // 
            this.xCuoOrigen.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.xCuoOrigen.DataPropertyName = "CuoOrigen";
            this.xCuoOrigen.FillWeight = 48.54369F;
            this.xCuoOrigen.HeaderText = "CuoOrigen";
            this.xCuoOrigen.MinimumWidth = 70;
            this.xCuoOrigen.Name = "xCuoOrigen";
            this.xCuoOrigen.ReadOnly = true;
            this.xCuoOrigen.Width = 70;
            // 
            // xBancoDestino
            // 
            this.xBancoDestino.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.xBancoDestino.DataPropertyName = "BancoDestino";
            this.xBancoDestino.FillWeight = 48.54369F;
            this.xBancoDestino.HeaderText = "BancoDestino";
            this.xBancoDestino.MinimumWidth = 100;
            this.xBancoDestino.Name = "xBancoDestino";
            this.xBancoDestino.ReadOnly = true;
            this.xBancoDestino.Width = 103;
            // 
            // xCtaBancoDestino
            // 
            this.xCtaBancoDestino.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.xCtaBancoDestino.DataPropertyName = "CtaBancoDestino";
            this.xCtaBancoDestino.FillWeight = 48.54369F;
            this.xCtaBancoDestino.HeaderText = "CtaBancoDestino";
            this.xCtaBancoDestino.Name = "xCtaBancoDestino";
            this.xCtaBancoDestino.ReadOnly = true;
            this.xCtaBancoDestino.Width = 120;
            // 
            // xCuoDestino
            // 
            this.xCuoDestino.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.xCuoDestino.DataPropertyName = "CuoDestino";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.xCuoDestino.DefaultCellStyle = dataGridViewCellStyle4;
            this.xCuoDestino.FillWeight = 48.54369F;
            this.xCuoDestino.HeaderText = "CuoDestino";
            this.xCuoDestino.MinimumWidth = 70;
            this.xCuoDestino.Name = "xCuoDestino";
            this.xCuoDestino.ReadOnly = true;
            this.xCuoDestino.Width = 70;
            // 
            // xMoneda
            // 
            this.xMoneda.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.xMoneda.DataPropertyName = "Moneda";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.xMoneda.DefaultCellStyle = dataGridViewCellStyle5;
            this.xMoneda.FillWeight = 48.54369F;
            this.xMoneda.HeaderText = "Moneda";
            this.xMoneda.MinimumWidth = 70;
            this.xMoneda.Name = "xMoneda";
            this.xMoneda.ReadOnly = true;
            this.xMoneda.Width = 70;
            // 
            // xMonto
            // 
            this.xMonto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.xMonto.DataPropertyName = "Monto";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle6.Format = "n2";
            this.xMonto.DefaultCellStyle = dataGridViewCellStyle6;
            this.xMonto.FillWeight = 48.54369F;
            this.xMonto.HeaderText = "Monto";
            this.xMonto.MinimumWidth = 60;
            this.xMonto.Name = "xMonto";
            this.xMonto.ReadOnly = true;
            this.xMonto.Width = 60;
            // 
            // xNroOperacion
            // 
            this.xNroOperacion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.xNroOperacion.DataPropertyName = "NroOperacion";
            this.xNroOperacion.FillWeight = 48.54369F;
            this.xNroOperacion.HeaderText = "NroOp.";
            this.xNroOperacion.Name = "xNroOperacion";
            this.xNroOperacion.ReadOnly = true;
            this.xNroOperacion.Width = 69;
            // 
            // xFechaAbono
            // 
            this.xFechaAbono.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.xFechaAbono.DataPropertyName = "FechaAbono";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle7.Format = "dd/MM/yyyy";
            this.xFechaAbono.DefaultCellStyle = dataGridViewCellStyle7;
            this.xFechaAbono.FillWeight = 48.54369F;
            this.xFechaAbono.HeaderText = "Fecha Abono";
            this.xFechaAbono.MinimumWidth = 75;
            this.xFechaAbono.Name = "xFechaAbono";
            this.xFechaAbono.ReadOnly = true;
            this.xFechaAbono.Width = 75;
            // 
            // xGlosa
            // 
            this.xGlosa.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.xGlosa.DataPropertyName = "glosa";
            this.xGlosa.FillWeight = 48.54369F;
            this.xGlosa.HeaderText = "Glosa";
            this.xGlosa.MinimumWidth = 100;
            this.xGlosa.Name = "xGlosa";
            this.xGlosa.ReadOnly = true;
            // 
            // txtempresaorigen
            // 
            this.txtempresaorigen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(218)))), ((int)(((byte)(231)))));
            this.txtempresaorigen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtempresaorigen.ColorFondoMouseEncima = System.Drawing.Color.Empty;
            this.txtempresaorigen.ColorFondoMousePresionado = System.Drawing.Color.Empty;
            this.txtempresaorigen.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtempresaorigen.ForeColor = System.Drawing.Color.Black;
            this.txtempresaorigen.Format = null;
            this.txtempresaorigen.Location = new System.Drawing.Point(115, 12);
            this.txtempresaorigen.MaxLength = 20;
            this.txtempresaorigen.Name = "txtempresaorigen";
            this.txtempresaorigen.NextControlOnEnter = null;
            this.txtempresaorigen.ReadOnly = true;
            this.txtempresaorigen.Size = new System.Drawing.Size(373, 21);
            this.txtempresaorigen.TabIndex = 405;
            this.txtempresaorigen.TextoDefecto = "";
            this.txtempresaorigen.TextoDefectoColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(129)))), ((int)(((byte)(189)))));
            this.txtempresaorigen.TiposDatos = HpResergerUserControls.TextBoxPer.ListaTipos.Todo;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.BackColor = System.Drawing.Color.Transparent;
            this.label21.Location = new System.Drawing.Point(24, 16);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(89, 13);
            this.label21.TabIndex = 406;
            this.label21.Text = "EmpresaOrigen:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(20, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 406;
            this.label1.Text = "EmpresaDestino:";
            // 
            // txtempresadestino
            // 
            this.txtempresadestino.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(218)))), ((int)(((byte)(231)))));
            this.txtempresadestino.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtempresadestino.ColorFondoMouseEncima = System.Drawing.Color.Empty;
            this.txtempresadestino.ColorFondoMousePresionado = System.Drawing.Color.Empty;
            this.txtempresadestino.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtempresadestino.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(129)))), ((int)(((byte)(189)))));
            this.txtempresadestino.Format = null;
            this.txtempresadestino.Location = new System.Drawing.Point(115, 36);
            this.txtempresadestino.MaxLength = 20;
            this.txtempresadestino.Name = "txtempresadestino";
            this.txtempresadestino.NextControlOnEnter = null;
            this.txtempresadestino.ReadOnly = true;
            this.txtempresadestino.Size = new System.Drawing.Size(373, 21);
            this.txtempresadestino.TabIndex = 405;
            this.txtempresadestino.TextoDefecto = "";
            this.txtempresadestino.TextoDefectoColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(129)))), ((int)(((byte)(189)))));
            this.txtempresadestino.TiposDatos = HpResergerUserControls.TextBoxPer.ListaTipos.Todo;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(17, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 13);
            this.label2.TabIndex = 406;
            this.label2.Text = "Detalle de los Abono:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(74, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 406;
            this.label3.Text = "Glosa:";
            // 
            // txtglosa
            // 
            this.txtglosa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(218)))), ((int)(((byte)(231)))));
            this.txtglosa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtglosa.ColorFondoMouseEncima = System.Drawing.Color.Empty;
            this.txtglosa.ColorFondoMousePresionado = System.Drawing.Color.Empty;
            this.txtglosa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtglosa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(129)))), ((int)(((byte)(189)))));
            this.txtglosa.Format = null;
            this.txtglosa.Location = new System.Drawing.Point(115, 60);
            this.txtglosa.MaxLength = 20;
            this.txtglosa.Name = "txtglosa";
            this.txtglosa.NextControlOnEnter = null;
            this.txtglosa.ReadOnly = true;
            this.txtglosa.Size = new System.Drawing.Size(649, 21);
            this.txtglosa.TabIndex = 405;
            this.txtglosa.TextoDefecto = "";
            this.txtglosa.TextoDefectoColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(129)))), ((int)(((byte)(189)))));
            this.txtglosa.TiposDatos = HpResergerUserControls.TextBoxPer.ListaTipos.Todo;
            // 
            // separadorOre2
            // 
            this.separadorOre2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.separadorOre2.BackColor = System.Drawing.Color.Transparent;
            this.separadorOre2.Location = new System.Drawing.Point(-3, 82);
            this.separadorOre2.MaximumSize = new System.Drawing.Size(2000, 2);
            this.separadorOre2.MinimumSize = new System.Drawing.Size(0, 2);
            this.separadorOre2.Name = "separadorOre2";
            this.separadorOre2.Size = new System.Drawing.Size(991, 2);
            this.separadorOre2.TabIndex = 407;
            // 
            // frmListadoPrestamosInterEmpresa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 361);
            this.Controls.Add(this.separadorOre2);
            this.Controls.Add(this.txtglosa);
            this.Controls.Add(this.txtempresadestino);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtempresaorigen);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.dtgconten);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnaceptar);
            this.Controls.Add(this.btncancelar);
            this.Controls.Add(this.lblmsg);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinimumSize = new System.Drawing.Size(1000, 400);
            this.Name = "frmListadoPrestamosInterEmpresa";
            this.Nombre = "Listado de Los Abonos de Prestamos InterEmpresa";
            this.Text = "Listado de Los Abonos de Prestamos InterEmpresa";
            this.Load += new System.EventHandler(this.frmListadoPrestamosInterEmpresa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgconten)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private HpResergerUserControls.TextBoxPer txtTotal;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnaceptar;
        private System.Windows.Forms.Button btncancelar;
        private System.Windows.Forms.Label lblmsg;
        private HpResergerUserControls.Dtgconten dtgconten;
        private System.Windows.Forms.DataGridViewTextBoxColumn xbancoOrigen;
        private System.Windows.Forms.DataGridViewTextBoxColumn xctaOrigenBanco;
        private System.Windows.Forms.DataGridViewTextBoxColumn xCuoOrigen;
        private System.Windows.Forms.DataGridViewTextBoxColumn xBancoDestino;
        private System.Windows.Forms.DataGridViewTextBoxColumn xCtaBancoDestino;
        private System.Windows.Forms.DataGridViewTextBoxColumn xCuoDestino;
        private System.Windows.Forms.DataGridViewTextBoxColumn xMoneda;
        private System.Windows.Forms.DataGridViewTextBoxColumn xMonto;
        private System.Windows.Forms.DataGridViewTextBoxColumn xNroOperacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn xFechaAbono;
        private System.Windows.Forms.DataGridViewTextBoxColumn xGlosa;
        private HpResergerUserControls.TextBoxPer txtempresaorigen;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label1;
        private HpResergerUserControls.TextBoxPer txtempresadestino;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private HpResergerUserControls.TextBoxPer txtglosa;
        private HpResergerUserControls.SeparadorOre separadorOre2;
    }
}