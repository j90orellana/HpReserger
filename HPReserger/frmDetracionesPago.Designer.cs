﻿namespace HPReserger
{
    partial class frmDetracionesPago
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDetracionesPago));
            this.dtgconten = new HpResergerUserControls.Dtgconten();
            this.opcionx = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.nrofacturax = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Proveedorx = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.razonx = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.monedax = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.monedasx = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Detraccionx = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.porpagarx = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaemisionx = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaRecepcionx = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaCanceladox = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nrodetraccionesx = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnaceptar = new System.Windows.Forms.Button();
            this.btncancelar = new System.Windows.Forms.Button();
            this.txttotal = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblmensaje = new System.Windows.Forms.Label();
            this.btnseleccion = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.txtnropago = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbocuentabanco = new System.Windows.Forms.ComboBox();
            this.lblguia1 = new System.Windows.Forms.Label();
            this.cbobanco = new System.Windows.Forms.ComboBox();
            this.cbotipo = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.lblguia = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgconten)).BeginInit();
            this.SuspendLayout();
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
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DeepSkyBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgconten.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dtgconten.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgconten.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.opcionx,
            this.nrofacturax,
            this.Proveedorx,
            this.razonx,
            this.monedax,
            this.monedasx,
            this.Detraccionx,
            this.porpagarx,
            this.fechaemisionx,
            this.FechaRecepcionx,
            this.FechaCanceladox,
            this.nrodetraccionesx});
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(207)))), ((int)(((byte)(241)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgconten.DefaultCellStyle = dataGridViewCellStyle9;
            this.dtgconten.EnableHeadersVisualStyles = false;
            this.dtgconten.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(179)))), ((int)(((byte)(215)))));
            this.dtgconten.Location = new System.Drawing.Point(12, 107);
            this.dtgconten.Name = "dtgconten";
            this.dtgconten.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dtgconten.RowHeadersVisible = false;
            this.dtgconten.RowTemplate.Height = 18;
            this.dtgconten.Size = new System.Drawing.Size(823, 379);
            this.dtgconten.TabIndex = 0;
            this.dtgconten.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgconten_CellContentClick);
            this.dtgconten.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dtgconten_CellFormatting);
            this.dtgconten.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgconten_CellValueChanged);
            this.dtgconten.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dtgconten_EditingControlShowing);
            // 
            // opcionx
            // 
            this.opcionx.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.opcionx.DataPropertyName = "opcion";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.opcionx.DefaultCellStyle = dataGridViewCellStyle3;
            this.opcionx.HeaderText = "Ok";
            this.opcionx.MinimumWidth = 30;
            this.opcionx.Name = "opcionx";
            this.opcionx.Width = 30;
            // 
            // nrofacturax
            // 
            this.nrofacturax.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.nrofacturax.DataPropertyName = "nrofactura";
            this.nrofacturax.HeaderText = "NroFac";
            this.nrofacturax.MinimumWidth = 80;
            this.nrofacturax.Name = "nrofacturax";
            this.nrofacturax.ReadOnly = true;
            this.nrofacturax.Width = 80;
            // 
            // Proveedorx
            // 
            this.Proveedorx.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Proveedorx.DataPropertyName = "proveedor";
            this.Proveedorx.HeaderText = "Proveedor";
            this.Proveedorx.MinimumWidth = 80;
            this.Proveedorx.Name = "Proveedorx";
            this.Proveedorx.ReadOnly = true;
            this.Proveedorx.Width = 85;
            // 
            // razonx
            // 
            this.razonx.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.razonx.DataPropertyName = "razon";
            this.razonx.HeaderText = "Razon Social";
            this.razonx.MinimumWidth = 100;
            this.razonx.Name = "razonx";
            this.razonx.ReadOnly = true;
            // 
            // monedax
            // 
            this.monedax.DataPropertyName = "moneda";
            this.monedax.HeaderText = "idmoneda";
            this.monedax.Name = "monedax";
            this.monedax.ReadOnly = true;
            this.monedax.Visible = false;
            // 
            // monedasx
            // 
            this.monedasx.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.monedasx.DataPropertyName = "namecorto";
            this.monedasx.HeaderText = "Mon.";
            this.monedasx.MinimumWidth = 50;
            this.monedasx.Name = "monedasx";
            this.monedasx.ReadOnly = true;
            this.monedasx.Width = 50;
            // 
            // Detraccionx
            // 
            this.Detraccionx.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.Detraccionx.DataPropertyName = "detraccion";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle4.Format = "n2";
            this.Detraccionx.DefaultCellStyle = dataGridViewCellStyle4;
            this.Detraccionx.HeaderText = "Detracción";
            this.Detraccionx.MinimumWidth = 80;
            this.Detraccionx.Name = "Detraccionx";
            this.Detraccionx.ReadOnly = true;
            this.Detraccionx.Width = 80;
            // 
            // porpagarx
            // 
            this.porpagarx.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.porpagarx.DataPropertyName = "porpagar";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle5.Format = "n2";
            this.porpagarx.DefaultCellStyle = dataGridViewCellStyle5;
            this.porpagarx.HeaderText = "Por Pagar";
            this.porpagarx.MinimumWidth = 80;
            this.porpagarx.Name = "porpagarx";
            this.porpagarx.Width = 80;
            // 
            // fechaemisionx
            // 
            this.fechaemisionx.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.fechaemisionx.DataPropertyName = "fechaemision";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle6.Format = "d";
            this.fechaemisionx.DefaultCellStyle = dataGridViewCellStyle6;
            this.fechaemisionx.HeaderText = "Fecha Emisión";
            this.fechaemisionx.MinimumWidth = 90;
            this.fechaemisionx.Name = "fechaemisionx";
            this.fechaemisionx.ReadOnly = true;
            this.fechaemisionx.Width = 90;
            // 
            // FechaRecepcionx
            // 
            this.FechaRecepcionx.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.FechaRecepcionx.DataPropertyName = "fecharecepcion";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle7.Format = "d";
            this.FechaRecepcionx.DefaultCellStyle = dataGridViewCellStyle7;
            this.FechaRecepcionx.HeaderText = "Fecha Recepción";
            this.FechaRecepcionx.MinimumWidth = 90;
            this.FechaRecepcionx.Name = "FechaRecepcionx";
            this.FechaRecepcionx.ReadOnly = true;
            this.FechaRecepcionx.Width = 90;
            // 
            // FechaCanceladox
            // 
            this.FechaCanceladox.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.FechaCanceladox.DataPropertyName = "fechacancelado";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle8.Format = "d";
            this.FechaCanceladox.DefaultCellStyle = dataGridViewCellStyle8;
            this.FechaCanceladox.HeaderText = "Fecha Cancelado";
            this.FechaCanceladox.MinimumWidth = 90;
            this.FechaCanceladox.Name = "FechaCanceladox";
            this.FechaCanceladox.ReadOnly = true;
            this.FechaCanceladox.Width = 90;
            // 
            // nrodetraccionesx
            // 
            this.nrodetraccionesx.DataPropertyName = "nro_cta_detracciones";
            this.nrodetraccionesx.HeaderText = "NroDetracciones";
            this.nrodetraccionesx.Name = "nrodetraccionesx";
            this.nrodetraccionesx.Visible = false;
            // 
            // btnaceptar
            // 
            this.btnaceptar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnaceptar.Enabled = false;
            this.btnaceptar.Image = ((System.Drawing.Image)(resources.GetObject("btnaceptar.Image")));
            this.btnaceptar.Location = new System.Drawing.Point(679, 512);
            this.btnaceptar.Name = "btnaceptar";
            this.btnaceptar.Size = new System.Drawing.Size(75, 23);
            this.btnaceptar.TabIndex = 62;
            this.btnaceptar.Text = "Pagar";
            this.btnaceptar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnaceptar.UseVisualStyleBackColor = true;
            this.btnaceptar.Click += new System.EventHandler(this.btnaceptar_Click);
            // 
            // btncancelar
            // 
            this.btncancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btncancelar.Image = ((System.Drawing.Image)(resources.GetObject("btncancelar.Image")));
            this.btncancelar.Location = new System.Drawing.Point(760, 512);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(75, 23);
            this.btncancelar.TabIndex = 63;
            this.btncancelar.Text = "Cancelar";
            this.btncancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btncancelar.UseVisualStyleBackColor = true;
            this.btncancelar.Click += new System.EventHandler(this.btncancelar_Click);
            // 
            // txttotal
            // 
            this.txttotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txttotal.Enabled = false;
            this.txttotal.Location = new System.Drawing.Point(736, 489);
            this.txttotal.Name = "txttotal";
            this.txttotal.Size = new System.Drawing.Size(99, 20);
            this.txttotal.TabIndex = 65;
            this.txttotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(656, 493);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 64;
            this.label3.Text = "Total a Pagar:";
            // 
            // lblmensaje
            // 
            this.lblmensaje.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblmensaje.AutoSize = true;
            this.lblmensaje.BackColor = System.Drawing.Color.Transparent;
            this.lblmensaje.Location = new System.Drawing.Point(9, 493);
            this.lblmensaje.Name = "lblmensaje";
            this.lblmensaje.Size = new System.Drawing.Size(118, 13);
            this.lblmensaje.TabIndex = 66;
            this.lblmensaje.Text = "Número de Registros=0";
            // 
            // btnseleccion
            // 
            this.btnseleccion.Image = ((System.Drawing.Image)(resources.GetObject("btnseleccion.Image")));
            this.btnseleccion.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnseleccion.Location = new System.Drawing.Point(12, 81);
            this.btnseleccion.Name = "btnseleccion";
            this.btnseleccion.Size = new System.Drawing.Size(148, 23);
            this.btnseleccion.TabIndex = 2;
            this.btnseleccion.Text = "Seleccionar Todo";
            this.btnseleccion.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnseleccion.UseVisualStyleBackColor = true;
            this.btnseleccion.Click += new System.EventHandler(this.btnseleccion_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.Image = ((System.Drawing.Image)(resources.GetObject("btnActualizar.Image")));
            this.btnActualizar.Location = new System.Drawing.Point(166, 81);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(86, 23);
            this.btnActualizar.TabIndex = 67;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(80)))), ((int)(((byte)(77)))));
            this.label1.Location = new System.Drawing.Point(320, 493);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(207, 13);
            this.label1.TabIndex = 68;
            this.label1.Text = "Letras Rojas-NO Tiene Cuenta Detracción";
            // 
            // button1
            // 
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(723, 39);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 23);
            this.button1.TabIndex = 77;
            this.button1.Text = "Actualizar";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // txtnropago
            // 
            this.txtnropago.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtnropago.Enabled = false;
            this.txtnropago.Location = new System.Drawing.Point(73, 14);
            this.txtnropago.Name = "txtnropago";
            this.txtnropago.Size = new System.Drawing.Size(155, 20);
            this.txtnropago.TabIndex = 76;
            this.txtnropago.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(12, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 75;
            this.label2.Text = "Nro Pago:";
            // 
            // cbocuentabanco
            // 
            this.cbocuentabanco.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(218)))), ((int)(((byte)(231)))));
            this.cbocuentabanco.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbocuentabanco.FormattingEnabled = true;
            this.cbocuentabanco.Location = new System.Drawing.Point(425, 40);
            this.cbocuentabanco.Name = "cbocuentabanco";
            this.cbocuentabanco.Size = new System.Drawing.Size(292, 21);
            this.cbocuentabanco.TabIndex = 74;
            // 
            // lblguia1
            // 
            this.lblguia1.AutoSize = true;
            this.lblguia1.BackColor = System.Drawing.Color.Transparent;
            this.lblguia1.Location = new System.Drawing.Point(347, 44);
            this.lblguia1.Name = "lblguia1";
            this.lblguia1.Size = new System.Drawing.Size(78, 13);
            this.lblguia1.TabIndex = 73;
            this.lblguia1.Text = "Cuenta Banco:";
            // 
            // cbobanco
            // 
            this.cbobanco.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(218)))), ((int)(((byte)(231)))));
            this.cbobanco.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbobanco.FormattingEnabled = true;
            this.cbobanco.Location = new System.Drawing.Point(73, 40);
            this.cbobanco.Name = "cbobanco";
            this.cbobanco.Size = new System.Drawing.Size(270, 21);
            this.cbobanco.TabIndex = 72;
            this.cbobanco.SelectedIndexChanged += new System.EventHandler(this.cbobanco_SelectedIndexChanged);
            // 
            // cbotipo
            // 
            this.cbotipo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(218)))), ((int)(((byte)(231)))));
            this.cbotipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbotipo.FormattingEnabled = true;
            this.cbotipo.Items.AddRange(new object[] {
            "003 TRANSFERENCIA DE FONDOS",
            "007 CHEQUES CON LA CLÁUSULA DE \"NO NEGOCIABLE\", \"INTRANSFERIBLES\", \"NO A LA ORDEN" +
                "\" U OTRA EQUIVALENTE, A QUE SE REFIERE EL INCISO G) DEL ARTICULO 5° DE LA LEY",
            "009 EFECTIVO, EN LOS DEMÁS CASOS"});
            this.cbotipo.Location = new System.Drawing.Point(287, 14);
            this.cbotipo.Name = "cbotipo";
            this.cbotipo.Size = new System.Drawing.Size(430, 21);
            this.cbotipo.TabIndex = 71;
            this.cbotipo.SelectedIndexChanged += new System.EventHandler(this.cbotipo_SelectedIndexChanged);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.Transparent;
            this.label16.Location = new System.Drawing.Point(246, 18);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(35, 13);
            this.label16.TabIndex = 69;
            this.label16.Text = "Pago:";
            // 
            // lblguia
            // 
            this.lblguia.AutoSize = true;
            this.lblguia.BackColor = System.Drawing.Color.Transparent;
            this.lblguia.Location = new System.Drawing.Point(12, 44);
            this.lblguia.Name = "lblguia";
            this.lblguia.Size = new System.Drawing.Size(41, 13);
            this.lblguia.TabIndex = 70;
            this.lblguia.Text = "Banco:";
            // 
            // frmDetracionesPago
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(847, 543);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtnropago);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbocuentabanco);
            this.Controls.Add(this.lblguia1);
            this.Controls.Add(this.cbobanco);
            this.Controls.Add(this.cbotipo);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.lblguia);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.lblmensaje);
            this.Controls.Add(this.txttotal);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnaceptar);
            this.Controls.Add(this.btncancelar);
            this.Controls.Add(this.btnseleccion);
            this.Controls.Add(this.dtgconten);
            this.MinimumSize = new System.Drawing.Size(863, 582);
            this.Name = "frmDetracionesPago";
            this.Nombre = " Pago Detracciones";
            this.Text = " Pago Detracciones";
            this.Load += new System.EventHandler(this.frmDetracionesPago_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgconten)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private HpResergerUserControls.Dtgconten dtgconten;
        private System.Windows.Forms.Button btnaceptar;
        private System.Windows.Forms.Button btncancelar;
        private System.Windows.Forms.TextBox txttotal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblmensaje;
        private System.Windows.Forms.Button btnseleccion;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.DataGridViewCheckBoxColumn opcionx;
        private System.Windows.Forms.DataGridViewTextBoxColumn nrofacturax;
        private System.Windows.Forms.DataGridViewTextBoxColumn Proveedorx;
        private System.Windows.Forms.DataGridViewTextBoxColumn razonx;
        private System.Windows.Forms.DataGridViewTextBoxColumn monedax;
        private System.Windows.Forms.DataGridViewTextBoxColumn monedasx;
        private System.Windows.Forms.DataGridViewTextBoxColumn Detraccionx;
        private System.Windows.Forms.DataGridViewTextBoxColumn porpagarx;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaemisionx;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaRecepcionx;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaCanceladox;
        private System.Windows.Forms.DataGridViewTextBoxColumn nrodetraccionesx;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtnropago;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbocuentabanco;
        private System.Windows.Forms.Label lblguia1;
        private System.Windows.Forms.ComboBox cbobanco;
        private System.Windows.Forms.ComboBox cbotipo;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label lblguia;
    }
}