namespace HPReserger
{
    partial class frmReportedeFacturas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReportedeFacturas));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle32 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle22 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle23 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle24 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle25 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle26 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle27 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle28 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle29 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle30 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle31 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dtpfechafin = new System.Windows.Forms.DateTimePicker();
            this.dtpfechaini = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.chkfecha = new System.Windows.Forms.CheckBox();
            this.btnexcel = new System.Windows.Forms.Button();
            this.btncancelar = new System.Windows.Forms.Button();
            this.lblmensaje = new System.Windows.Forms.Label();
            this.btngenerar = new System.Windows.Forms.Button();
            this.dtgconten = new HpResergerUserControls.Dtgconten();
            this.xCodSunatComprobante = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xTipoComprobante = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xRUC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xRazonSocial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xEmpresa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xProyecto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xEtapa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xCompensacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xMoneda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xNroComprobante = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xTC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xIgv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xFechaEmision = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xFechaRecepcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xFechaVencimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xFechaContable = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xCod_Detraccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xDesc_Detraccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xPorcentajeDetrac = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xDetraccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xImportePagar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xGlosa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.dtgconten)).BeginInit();
            this.SuspendLayout();
            // 
            // dtpfechafin
            // 
            this.dtpfechafin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpfechafin.Location = new System.Drawing.Point(247, 12);
            this.dtpfechafin.Name = "dtpfechafin";
            this.dtpfechafin.Size = new System.Drawing.Size(93, 22);
            this.dtpfechafin.TabIndex = 3;
            // 
            // dtpfechaini
            // 
            this.dtpfechaini.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpfechaini.Location = new System.Drawing.Point(137, 12);
            this.dtpfechaini.Name = "dtpfechaini";
            this.dtpfechaini.Size = new System.Drawing.Size(93, 22);
            this.dtpfechaini.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(230, 17);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(17, 13);
            this.label5.TabIndex = 390;
            this.label5.Text = "A:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(70, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 391;
            this.label2.Text = "Periodo De:";
            // 
            // chkfecha
            // 
            this.chkfecha.AutoSize = true;
            this.chkfecha.BackColor = System.Drawing.Color.Transparent;
            this.chkfecha.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkfecha.Location = new System.Drawing.Point(12, 15);
            this.chkfecha.Name = "chkfecha";
            this.chkfecha.Size = new System.Drawing.Size(56, 17);
            this.chkfecha.TabIndex = 1;
            this.chkfecha.Text = "Fecha";
            this.chkfecha.UseVisualStyleBackColor = false;
            // 
            // btnexcel
            // 
            this.btnexcel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnexcel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnexcel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnexcel.Image = ((System.Drawing.Image)(resources.GetObject("btnexcel.Image")));
            this.btnexcel.Location = new System.Drawing.Point(635, 531);
            this.btnexcel.Name = "btnexcel";
            this.btnexcel.Size = new System.Drawing.Size(82, 23);
            this.btnexcel.TabIndex = 5;
            this.btnexcel.Text = "Excel";
            this.btnexcel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnexcel.UseVisualStyleBackColor = true;
            this.btnexcel.Click += new System.EventHandler(this.btnexcel_Click);
            // 
            // btncancelar
            // 
            this.btncancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btncancelar.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncancelar.Image = ((System.Drawing.Image)(resources.GetObject("btncancelar.Image")));
            this.btncancelar.Location = new System.Drawing.Point(1127, 531);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(85, 23);
            this.btncancelar.TabIndex = 6;
            this.btncancelar.Text = "Cancelar";
            this.btncancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btncancelar.UseVisualStyleBackColor = true;
            this.btncancelar.Click += new System.EventHandler(this.btncancelar_Click);
            // 
            // lblmensaje
            // 
            this.lblmensaje.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblmensaje.AutoSize = true;
            this.lblmensaje.BackColor = System.Drawing.Color.Transparent;
            this.lblmensaje.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmensaje.Location = new System.Drawing.Point(12, 536);
            this.lblmensaje.Name = "lblmensaje";
            this.lblmensaje.Size = new System.Drawing.Size(110, 13);
            this.lblmensaje.TabIndex = 397;
            this.lblmensaje.Text = "Total de Registros: 0";
            // 
            // btngenerar
            // 
            this.btngenerar.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btngenerar.Image = ((System.Drawing.Image)(resources.GetObject("btngenerar.Image")));
            this.btngenerar.Location = new System.Drawing.Point(346, 11);
            this.btngenerar.Name = "btngenerar";
            this.btngenerar.Size = new System.Drawing.Size(85, 23);
            this.btngenerar.TabIndex = 4;
            this.btngenerar.Text = "Generar";
            this.btngenerar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btngenerar.UseVisualStyleBackColor = true;
            this.btngenerar.Click += new System.EventHandler(this.btngenerar_Click);
            // 
            // dtgconten
            // 
            this.dtgconten.AllowUserToAddRows = false;
            this.dtgconten.AllowUserToDeleteRows = false;
            this.dtgconten.AllowUserToResizeColumns = false;
            this.dtgconten.AllowUserToResizeRows = false;
            dataGridViewCellStyle17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(230)))), ((int)(((byte)(241)))));
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(191)))), ((int)(((byte)(231)))));
            this.dtgconten.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle17;
            this.dtgconten.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgconten.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgconten.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(218)))), ((int)(((byte)(231)))));
            this.dtgconten.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgconten.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.dtgconten.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle18.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(129)))), ((int)(((byte)(189)))));
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            dataGridViewCellStyle18.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.Color.DeepSkyBlue;
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgconten.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle18;
            this.dtgconten.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgconten.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.xCodSunatComprobante,
            this.xTipoComprobante,
            this.xRUC,
            this.xRazonSocial,
            this.xEmpresa,
            this.xProyecto,
            this.xEtapa,
            this.xCompensacion,
            this.xMoneda,
            this.xNroComprobante,
            this.xTC,
            this.xTotal,
            this.xIgv,
            this.xFechaEmision,
            this.xFechaRecepcion,
            this.xFechaVencimiento,
            this.xFechaContable,
            this.xCod_Detraccion,
            this.xDesc_Detraccion,
            this.xPorcentajeDetrac,
            this.xDetraccion,
            this.xImportePagar,
            this.xGlosa});
            dataGridViewCellStyle32.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle32.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle32.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            dataGridViewCellStyle32.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle32.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(207)))), ((int)(((byte)(241)))));
            dataGridViewCellStyle32.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle32.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgconten.DefaultCellStyle = dataGridViewCellStyle32;
            this.dtgconten.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dtgconten.EnableHeadersVisualStyles = false;
            this.dtgconten.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(179)))), ((int)(((byte)(215)))));
            this.dtgconten.Location = new System.Drawing.Point(12, 56);
            this.dtgconten.Name = "dtgconten";
            this.dtgconten.ReadOnly = true;
            this.dtgconten.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dtgconten.RowHeadersVisible = false;
            this.dtgconten.RowTemplate.Height = 18;
            this.dtgconten.Size = new System.Drawing.Size(1200, 469);
            this.dtgconten.TabIndex = 395;
            // 
            // xCodSunatComprobante
            // 
            this.xCodSunatComprobante.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.xCodSunatComprobante.DataPropertyName = "CodSunatComprobante";
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.xCodSunatComprobante.DefaultCellStyle = dataGridViewCellStyle19;
            this.xCodSunatComprobante.HeaderText = "CodSunat";
            this.xCodSunatComprobante.Name = "xCodSunatComprobante";
            this.xCodSunatComprobante.ReadOnly = true;
            this.xCodSunatComprobante.Width = 82;
            // 
            // xTipoComprobante
            // 
            this.xTipoComprobante.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.xTipoComprobante.DataPropertyName = "TipoComprobante";
            this.xTipoComprobante.HeaderText = "Tipo";
            this.xTipoComprobante.MinimumWidth = 100;
            this.xTipoComprobante.Name = "xTipoComprobante";
            this.xTipoComprobante.ReadOnly = true;
            // 
            // xRUC
            // 
            this.xRUC.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.xRUC.DataPropertyName = "RUC";
            dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.xRUC.DefaultCellStyle = dataGridViewCellStyle20;
            this.xRUC.HeaderText = "RUC";
            this.xRUC.Name = "xRUC";
            this.xRUC.ReadOnly = true;
            this.xRUC.Width = 53;
            // 
            // xRazonSocial
            // 
            this.xRazonSocial.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.xRazonSocial.DataPropertyName = "RazonSocial";
            this.xRazonSocial.HeaderText = "RazonSocial/Nombre";
            this.xRazonSocial.MinimumWidth = 200;
            this.xRazonSocial.Name = "xRazonSocial";
            this.xRazonSocial.ReadOnly = true;
            this.xRazonSocial.Width = 200;
            // 
            // xEmpresa
            // 
            this.xEmpresa.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.xEmpresa.DataPropertyName = "Empresa";
            this.xEmpresa.HeaderText = "Empresa";
            this.xEmpresa.MinimumWidth = 100;
            this.xEmpresa.Name = "xEmpresa";
            this.xEmpresa.ReadOnly = true;
            // 
            // xProyecto
            // 
            this.xProyecto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.xProyecto.DataPropertyName = "Proyecto";
            this.xProyecto.HeaderText = "Proyecto";
            this.xProyecto.MinimumWidth = 100;
            this.xProyecto.Name = "xProyecto";
            this.xProyecto.ReadOnly = true;
            // 
            // xEtapa
            // 
            this.xEtapa.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.xEtapa.DataPropertyName = "Etapa";
            this.xEtapa.HeaderText = "Etapa";
            this.xEtapa.Name = "xEtapa";
            this.xEtapa.ReadOnly = true;
            this.xEtapa.Visible = false;
            // 
            // xCompensacion
            // 
            this.xCompensacion.DataPropertyName = "Compensacion";
            this.xCompensacion.HeaderText = "Compensacion";
            this.xCompensacion.Name = "xCompensacion";
            this.xCompensacion.ReadOnly = true;
            this.xCompensacion.Visible = false;
            // 
            // xMoneda
            // 
            this.xMoneda.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.xMoneda.DataPropertyName = "Moneda";
            this.xMoneda.HeaderText = "Moneda";
            this.xMoneda.Name = "xMoneda";
            this.xMoneda.ReadOnly = true;
            this.xMoneda.Width = 74;
            // 
            // xNroComprobante
            // 
            this.xNroComprobante.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.xNroComprobante.DataPropertyName = "NroComprobante";
            dataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.xNroComprobante.DefaultCellStyle = dataGridViewCellStyle21;
            this.xNroComprobante.HeaderText = "Nro.Compbte";
            this.xNroComprobante.Name = "xNroComprobante";
            this.xNroComprobante.ReadOnly = true;
            // 
            // xTC
            // 
            this.xTC.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.xTC.DataPropertyName = "TC";
            dataGridViewCellStyle22.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle22.Format = "n3";
            this.xTC.DefaultCellStyle = dataGridViewCellStyle22;
            this.xTC.HeaderText = "TC";
            this.xTC.Name = "xTC";
            this.xTC.ReadOnly = true;
            this.xTC.Width = 42;
            // 
            // xTotal
            // 
            this.xTotal.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.xTotal.DataPropertyName = "Total";
            dataGridViewCellStyle23.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle23.Format = "n2";
            this.xTotal.DefaultCellStyle = dataGridViewCellStyle23;
            this.xTotal.HeaderText = "Total";
            this.xTotal.Name = "xTotal";
            this.xTotal.ReadOnly = true;
            this.xTotal.Width = 55;
            // 
            // xIgv
            // 
            this.xIgv.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.xIgv.DataPropertyName = "Igv";
            dataGridViewCellStyle24.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle24.Format = "n2";
            this.xIgv.DefaultCellStyle = dataGridViewCellStyle24;
            this.xIgv.HeaderText = "Igv";
            this.xIgv.Name = "xIgv";
            this.xIgv.ReadOnly = true;
            this.xIgv.Width = 46;
            // 
            // xFechaEmision
            // 
            this.xFechaEmision.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.xFechaEmision.DataPropertyName = "FechaEmision";
            dataGridViewCellStyle25.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle25.Format = "dd/MM/yyyy";
            this.xFechaEmision.DefaultCellStyle = dataGridViewCellStyle25;
            this.xFechaEmision.HeaderText = "FechaEmision";
            this.xFechaEmision.Name = "xFechaEmision";
            this.xFechaEmision.ReadOnly = true;
            this.xFechaEmision.Width = 101;
            // 
            // xFechaRecepcion
            // 
            this.xFechaRecepcion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.xFechaRecepcion.DataPropertyName = "FechaRecepcion";
            dataGridViewCellStyle26.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle26.Format = "dd/MM/yyyy";
            this.xFechaRecepcion.DefaultCellStyle = dataGridViewCellStyle26;
            this.xFechaRecepcion.HeaderText = "FechaRecepcion";
            this.xFechaRecepcion.Name = "xFechaRecepcion";
            this.xFechaRecepcion.ReadOnly = true;
            this.xFechaRecepcion.Width = 114;
            // 
            // xFechaVencimiento
            // 
            this.xFechaVencimiento.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.xFechaVencimiento.DataPropertyName = "FechaVencimiento";
            dataGridViewCellStyle27.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle27.Format = "dd/MM/yyyy";
            this.xFechaVencimiento.DefaultCellStyle = dataGridViewCellStyle27;
            this.xFechaVencimiento.HeaderText = "FechaVencimiento";
            this.xFechaVencimiento.Name = "xFechaVencimiento";
            this.xFechaVencimiento.ReadOnly = true;
            this.xFechaVencimiento.Width = 124;
            // 
            // xFechaContable
            // 
            this.xFechaContable.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.xFechaContable.DataPropertyName = "FechaContable";
            dataGridViewCellStyle28.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle28.Format = "dd/MM/yyyy";
            this.xFechaContable.DefaultCellStyle = dataGridViewCellStyle28;
            this.xFechaContable.HeaderText = "FechaContable";
            this.xFechaContable.Name = "xFechaContable";
            this.xFechaContable.ReadOnly = true;
            this.xFechaContable.Width = 108;
            // 
            // xCod_Detraccion
            // 
            this.xCod_Detraccion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.xCod_Detraccion.DataPropertyName = "Cod_Detraccion";
            this.xCod_Detraccion.HeaderText = "Código Detracción";
            this.xCod_Detraccion.Name = "xCod_Detraccion";
            this.xCod_Detraccion.ReadOnly = true;
            this.xCod_Detraccion.Visible = false;
            // 
            // xDesc_Detraccion
            // 
            this.xDesc_Detraccion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.xDesc_Detraccion.DataPropertyName = "Desc_Detraccion";
            this.xDesc_Detraccion.HeaderText = "Descripción Detracción";
            this.xDesc_Detraccion.Name = "xDesc_Detraccion";
            this.xDesc_Detraccion.ReadOnly = true;
            this.xDesc_Detraccion.Width = 136;
            // 
            // xPorcentajeDetrac
            // 
            this.xPorcentajeDetrac.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.xPorcentajeDetrac.DataPropertyName = "PorcentajeDetrac";
            dataGridViewCellStyle29.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle29.Format = "n2";
            this.xPorcentajeDetrac.DefaultCellStyle = dataGridViewCellStyle29;
            this.xPorcentajeDetrac.HeaderText = "Porcentaje Detracción";
            this.xPorcentajeDetrac.MinimumWidth = 80;
            this.xPorcentajeDetrac.Name = "xPorcentajeDetrac";
            this.xPorcentajeDetrac.ReadOnly = true;
            this.xPorcentajeDetrac.Width = 80;
            // 
            // xDetraccion
            // 
            this.xDetraccion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.xDetraccion.DataPropertyName = "Detraccion";
            dataGridViewCellStyle30.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle30.Format = "n2";
            this.xDetraccion.DefaultCellStyle = dataGridViewCellStyle30;
            this.xDetraccion.HeaderText = "Detraccion";
            this.xDetraccion.Name = "xDetraccion";
            this.xDetraccion.ReadOnly = true;
            this.xDetraccion.Width = 86;
            // 
            // xImportePagar
            // 
            this.xImportePagar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.xImportePagar.DataPropertyName = "ImportePagar";
            dataGridViewCellStyle31.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle31.Format = "n2";
            this.xImportePagar.DefaultCellStyle = dataGridViewCellStyle31;
            this.xImportePagar.HeaderText = "Importe Pagar";
            this.xImportePagar.Name = "xImportePagar";
            this.xImportePagar.ReadOnly = true;
            this.xImportePagar.Width = 95;
            // 
            // xGlosa
            // 
            this.xGlosa.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.xGlosa.DataPropertyName = "Glosa";
            this.xGlosa.HeaderText = "Glosa";
            this.xGlosa.MinimumWidth = 150;
            this.xGlosa.Name = "xGlosa";
            this.xGlosa.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(12, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(276, 13);
            this.label1.TabIndex = 400;
            this.label1.Text = "Listado de Comprobantes de Compras Incompletos.";
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // frmReportedeFacturas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1225, 561);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnexcel);
            this.Controls.Add(this.btncancelar);
            this.Controls.Add(this.lblmensaje);
            this.Controls.Add(this.btngenerar);
            this.Controls.Add(this.dtgconten);
            this.Controls.Add(this.chkfecha);
            this.Controls.Add(this.dtpfechafin);
            this.Controls.Add(this.dtpfechaini);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.MinimumSize = new System.Drawing.Size(1241, 600);
            this.Name = "frmReportedeFacturas";
            this.Nombre = "Comprobantes de Compras Incompletos";
            this.Text = "Comprobantes de Compras Incompletos";
            this.Load += new System.EventHandler(this.frmReportedeFacturas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgconten)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpfechafin;
        private System.Windows.Forms.DateTimePicker dtpfechaini;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox chkfecha;
        private System.Windows.Forms.Button btnexcel;
        private System.Windows.Forms.Button btncancelar;
        private System.Windows.Forms.Label lblmensaje;
        private System.Windows.Forms.Button btngenerar;
        private HpResergerUserControls.Dtgconten dtgconten;
        private System.Windows.Forms.Label label1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.DataGridViewTextBoxColumn xCodSunatComprobante;
        private System.Windows.Forms.DataGridViewTextBoxColumn xTipoComprobante;
        private System.Windows.Forms.DataGridViewTextBoxColumn xRUC;
        private System.Windows.Forms.DataGridViewTextBoxColumn xRazonSocial;
        private System.Windows.Forms.DataGridViewTextBoxColumn xEmpresa;
        private System.Windows.Forms.DataGridViewTextBoxColumn xProyecto;
        private System.Windows.Forms.DataGridViewTextBoxColumn xEtapa;
        private System.Windows.Forms.DataGridViewTextBoxColumn xCompensacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn xMoneda;
        private System.Windows.Forms.DataGridViewTextBoxColumn xNroComprobante;
        private System.Windows.Forms.DataGridViewTextBoxColumn xTC;
        private System.Windows.Forms.DataGridViewTextBoxColumn xTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn xIgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn xFechaEmision;
        private System.Windows.Forms.DataGridViewTextBoxColumn xFechaRecepcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn xFechaVencimiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn xFechaContable;
        private System.Windows.Forms.DataGridViewTextBoxColumn xCod_Detraccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn xDesc_Detraccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn xPorcentajeDetrac;
        private System.Windows.Forms.DataGridViewTextBoxColumn xDetraccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn xImportePagar;
        private System.Windows.Forms.DataGridViewTextBoxColumn xGlosa;
    }
}