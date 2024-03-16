using HpResergerUserControls;

namespace HPReserger
{
    partial class frmAprobarCotizacion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAprobarCotizacion));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnAprobar = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.gridCotizacion = new HpResergerUserControls.Dtgconten();
            this.OP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.USUARIO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGOAREA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AREA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGOGERENCIA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GERENCIA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TIPO_PEDIDO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGOCC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CENTROCOSTO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGOPP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PARTIDAPRESUPUESTO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gridCotizacionesAsociadas = new HpResergerUserControls.Dtgconten();
            this.COTIZACION = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PEDIDO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGOPROVEEDOR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PROVEEDOR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MONEDAX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IMPORTE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FECHAENTREGA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ADJUNTO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idmonedax = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btndetalle = new System.Windows.Forms.Button();
            this.pbFoto = new System.Windows.Forms.PictureBox();
            this.btndescargar = new System.Windows.Forms.Button();
            this.btnactualizar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridCotizacion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridCotizacionesAsociadas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFoto)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAprobar
            // 
            this.btnAprobar.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAprobar.Image = ((System.Drawing.Image)(resources.GetObject("btnAprobar.Image")));
            this.btnAprobar.Location = new System.Drawing.Point(327, 540);
            this.btnAprobar.Name = "btnAprobar";
            this.btnAprobar.Size = new System.Drawing.Size(75, 23);
            this.btnAprobar.TabIndex = 35;
            this.btnAprobar.Text = "Aprobar";
            this.btnAprobar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAprobar.UseVisualStyleBackColor = true;
            this.btnAprobar.Click += new System.EventHandler(this.btnAprobar_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(9, 307);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(187, 13);
            this.label7.TabIndex = 33;
            this.label7.Text = "Cotizaciónes por Orden de Pedido:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 13);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(109, 13);
            this.label6.TabIndex = 31;
            this.label6.Text = "Ordenes de Pedido:";
            // 
            // gridCotizacion
            // 
            this.gridCotizacion.AllowUserToAddRows = false;
            this.gridCotizacion.AllowUserToResizeColumns = false;
            this.gridCotizacion.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(230)))), ((int)(((byte)(241)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(191)))), ((int)(((byte)(231)))));
            this.gridCotizacion.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.gridCotizacion.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridCotizacion.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridCotizacion.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(218)))), ((int)(((byte)(231)))));
            this.gridCotizacion.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.gridCotizacion.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SunkenVertical;
            this.gridCotizacion.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(129)))), ((int)(((byte)(189)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DeepSkyBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridCotizacion.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.gridCotizacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.gridCotizacion.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.OP,
            this.c,
            this.USUARIO,
            this.CODIGOAREA,
            this.AREA,
            this.CODIGOGERENCIA,
            this.GERENCIA,
            this.TIPO_PEDIDO,
            this.CODIGOCC,
            this.CENTROCOSTO,
            this.CODIGOPP,
            this.PARTIDAPRESUPUESTO});
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(207)))), ((int)(((byte)(241)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridCotizacion.DefaultCellStyle = dataGridViewCellStyle8;
            this.gridCotizacion.EnableHeadersVisualStyles = false;
            this.gridCotizacion.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(179)))), ((int)(((byte)(215)))));
            this.gridCotizacion.Location = new System.Drawing.Point(9, 29);
            this.gridCotizacion.Name = "gridCotizacion";
            this.gridCotizacion.ReadOnly = true;
            this.gridCotizacion.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.gridCotizacion.RowHeadersVisible = false;
            this.gridCotizacion.RowTemplate.Height = 16;
            this.gridCotizacion.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridCotizacion.Size = new System.Drawing.Size(630, 275);
            this.gridCotizacion.TabIndex = 28;
            this.gridCotizacion.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridCotizacion_RowEnter);
            // 
            // OP
            // 
            this.OP.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.OP.DataPropertyName = "OP";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.OP.DefaultCellStyle = dataGridViewCellStyle3;
            this.OP.HeaderText = "Nº OP";
            this.OP.Name = "OP";
            this.OP.ReadOnly = true;
            this.OP.Width = 64;
            // 
            // c
            // 
            this.c.DataPropertyName = "CODIGOUSUARIO";
            this.c.HeaderText = "c";
            this.c.Name = "c";
            this.c.ReadOnly = true;
            this.c.Visible = false;
            // 
            // USUARIO
            // 
            this.USUARIO.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.USUARIO.DataPropertyName = "USUARIO";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.USUARIO.DefaultCellStyle = dataGridViewCellStyle4;
            this.USUARIO.HeaderText = "USUARIO";
            this.USUARIO.Name = "USUARIO";
            this.USUARIO.ReadOnly = true;
            this.USUARIO.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.USUARIO.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // CODIGOAREA
            // 
            this.CODIGOAREA.DataPropertyName = "CODIGOAREA";
            this.CODIGOAREA.HeaderText = "CODIGOAREA";
            this.CODIGOAREA.Name = "CODIGOAREA";
            this.CODIGOAREA.ReadOnly = true;
            this.CODIGOAREA.Visible = false;
            // 
            // AREA
            // 
            this.AREA.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.AREA.DataPropertyName = "AREA";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AREA.DefaultCellStyle = dataGridViewCellStyle5;
            this.AREA.HeaderText = "AREA";
            this.AREA.Name = "AREA";
            this.AREA.ReadOnly = true;
            this.AREA.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.AREA.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // CODIGOGERENCIA
            // 
            this.CODIGOGERENCIA.DataPropertyName = "CODIGOGERENCIA";
            this.CODIGOGERENCIA.HeaderText = "CODIGOGERENCIA";
            this.CODIGOGERENCIA.Name = "CODIGOGERENCIA";
            this.CODIGOGERENCIA.ReadOnly = true;
            this.CODIGOGERENCIA.Visible = false;
            // 
            // GERENCIA
            // 
            this.GERENCIA.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.GERENCIA.DataPropertyName = "GERENCIA";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.GERENCIA.DefaultCellStyle = dataGridViewCellStyle6;
            this.GERENCIA.HeaderText = "GERENCIA";
            this.GERENCIA.Name = "GERENCIA";
            this.GERENCIA.ReadOnly = true;
            this.GERENCIA.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.GERENCIA.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // TIPO_PEDIDO
            // 
            this.TIPO_PEDIDO.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.TIPO_PEDIDO.DataPropertyName = "TIPO_PEDIDO";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TIPO_PEDIDO.DefaultCellStyle = dataGridViewCellStyle7;
            this.TIPO_PEDIDO.HeaderText = "TIPO PEDIDO";
            this.TIPO_PEDIDO.Name = "TIPO_PEDIDO";
            this.TIPO_PEDIDO.ReadOnly = true;
            this.TIPO_PEDIDO.Width = 101;
            // 
            // CODIGOCC
            // 
            this.CODIGOCC.DataPropertyName = "CODIGOCC";
            this.CODIGOCC.HeaderText = "CODIGOCC";
            this.CODIGOCC.Name = "CODIGOCC";
            this.CODIGOCC.ReadOnly = true;
            this.CODIGOCC.Visible = false;
            // 
            // CENTROCOSTO
            // 
            this.CENTROCOSTO.DataPropertyName = "CENTROCOSTO";
            this.CENTROCOSTO.HeaderText = "CENTROCOSTO";
            this.CENTROCOSTO.Name = "CENTROCOSTO";
            this.CENTROCOSTO.ReadOnly = true;
            this.CENTROCOSTO.Visible = false;
            // 
            // CODIGOPP
            // 
            this.CODIGOPP.DataPropertyName = "CODIGOPP";
            this.CODIGOPP.HeaderText = "CODIGOPP";
            this.CODIGOPP.Name = "CODIGOPP";
            this.CODIGOPP.ReadOnly = true;
            this.CODIGOPP.Visible = false;
            // 
            // PARTIDAPRESUPUESTO
            // 
            this.PARTIDAPRESUPUESTO.DataPropertyName = "PARTIDAPRESUPUESTO";
            this.PARTIDAPRESUPUESTO.HeaderText = "PARTIDAPRESUPUESTO";
            this.PARTIDAPRESUPUESTO.Name = "PARTIDAPRESUPUESTO";
            this.PARTIDAPRESUPUESTO.ReadOnly = true;
            this.PARTIDAPRESUPUESTO.Visible = false;
            // 
            // gridCotizacionesAsociadas
            // 
            this.gridCotizacionesAsociadas.AllowUserToAddRows = false;
            this.gridCotizacionesAsociadas.AllowUserToResizeColumns = false;
            this.gridCotizacionesAsociadas.AllowUserToResizeRows = false;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(230)))), ((int)(((byte)(241)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(191)))), ((int)(((byte)(231)))));
            this.gridCotizacionesAsociadas.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle9;
            this.gridCotizacionesAsociadas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridCotizacionesAsociadas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridCotizacionesAsociadas.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(218)))), ((int)(((byte)(231)))));
            this.gridCotizacionesAsociadas.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.gridCotizacionesAsociadas.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SunkenVertical;
            this.gridCotizacionesAsociadas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(129)))), ((int)(((byte)(189)))));
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.DeepSkyBlue;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridCotizacionesAsociadas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.gridCotizacionesAsociadas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.gridCotizacionesAsociadas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.COTIZACION,
            this.PEDIDO,
            this.CODIGOPROVEEDOR,
            this.PROVEEDOR,
            this.MONEDAX,
            this.IMPORTE,
            this.FECHAENTREGA,
            this.ADJUNTO,
            this.idmonedax});
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(207)))), ((int)(((byte)(241)))));
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridCotizacionesAsociadas.DefaultCellStyle = dataGridViewCellStyle15;
            this.gridCotizacionesAsociadas.EnableHeadersVisualStyles = false;
            this.gridCotizacionesAsociadas.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(179)))), ((int)(((byte)(215)))));
            this.gridCotizacionesAsociadas.Location = new System.Drawing.Point(9, 323);
            this.gridCotizacionesAsociadas.Name = "gridCotizacionesAsociadas";
            this.gridCotizacionesAsociadas.ReadOnly = true;
            this.gridCotizacionesAsociadas.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.gridCotizacionesAsociadas.RowHeadersVisible = false;
            this.gridCotizacionesAsociadas.RowTemplate.Height = 16;
            this.gridCotizacionesAsociadas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridCotizacionesAsociadas.Size = new System.Drawing.Size(630, 211);
            this.gridCotizacionesAsociadas.TabIndex = 37;
            this.gridCotizacionesAsociadas.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridCotizacionesAsociadas_CellDoubleClick);
            this.gridCotizacionesAsociadas.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridCotizacionesAsociadas_RowEnter);
            // 
            // COTIZACION
            // 
            this.COTIZACION.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.COTIZACION.DataPropertyName = "COTIZACION";
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.COTIZACION.DefaultCellStyle = dataGridViewCellStyle11;
            this.COTIZACION.HeaderText = "Nº COT";
            this.COTIZACION.MinimumWidth = 60;
            this.COTIZACION.Name = "COTIZACION";
            this.COTIZACION.ReadOnly = true;
            this.COTIZACION.Width = 60;
            // 
            // PEDIDO
            // 
            this.PEDIDO.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.PEDIDO.DataPropertyName = "PEDIDO";
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.PEDIDO.DefaultCellStyle = dataGridViewCellStyle12;
            this.PEDIDO.HeaderText = "Nº OP";
            this.PEDIDO.MinimumWidth = 40;
            this.PEDIDO.Name = "PEDIDO";
            this.PEDIDO.ReadOnly = true;
            this.PEDIDO.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.PEDIDO.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.PEDIDO.Width = 45;
            // 
            // CODIGOPROVEEDOR
            // 
            this.CODIGOPROVEEDOR.DataPropertyName = "CODIGOPROVEEDOR";
            this.CODIGOPROVEEDOR.HeaderText = "CODIGOPROVEEDOR";
            this.CODIGOPROVEEDOR.Name = "CODIGOPROVEEDOR";
            this.CODIGOPROVEEDOR.ReadOnly = true;
            this.CODIGOPROVEEDOR.Visible = false;
            // 
            // PROVEEDOR
            // 
            this.PROVEEDOR.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.PROVEEDOR.DataPropertyName = "PROVEEDOR";
            this.PROVEEDOR.HeaderText = "PROVEEDOR";
            this.PROVEEDOR.MinimumWidth = 100;
            this.PROVEEDOR.Name = "PROVEEDOR";
            this.PROVEEDOR.ReadOnly = true;
            // 
            // MONEDAX
            // 
            this.MONEDAX.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.MONEDAX.DataPropertyName = "moneda";
            this.MONEDAX.HeaderText = "MONEDA";
            this.MONEDAX.MinimumWidth = 60;
            this.MONEDAX.Name = "MONEDAX";
            this.MONEDAX.ReadOnly = true;
            this.MONEDAX.Width = 82;
            // 
            // IMPORTE
            // 
            this.IMPORTE.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.IMPORTE.DataPropertyName = "IMPORTE";
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.IMPORTE.DefaultCellStyle = dataGridViewCellStyle13;
            this.IMPORTE.HeaderText = "IMPORTE";
            this.IMPORTE.MinimumWidth = 50;
            this.IMPORTE.Name = "IMPORTE";
            this.IMPORTE.ReadOnly = true;
            this.IMPORTE.Width = 80;
            // 
            // FECHAENTREGA
            // 
            this.FECHAENTREGA.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.FECHAENTREGA.DataPropertyName = "FECHAENTREGA";
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.FECHAENTREGA.DefaultCellStyle = dataGridViewCellStyle14;
            this.FECHAENTREGA.HeaderText = "FECHA ENTREGA";
            this.FECHAENTREGA.MinimumWidth = 50;
            this.FECHAENTREGA.Name = "FECHAENTREGA";
            this.FECHAENTREGA.ReadOnly = true;
            this.FECHAENTREGA.Width = 122;
            // 
            // ADJUNTO
            // 
            this.ADJUNTO.DataPropertyName = "ADJUNTO";
            this.ADJUNTO.HeaderText = "ADJUNTO";
            this.ADJUNTO.Name = "ADJUNTO";
            this.ADJUNTO.ReadOnly = true;
            this.ADJUNTO.Visible = false;
            // 
            // idmonedax
            // 
            this.idmonedax.DataPropertyName = "IDMONEDA";
            this.idmonedax.HeaderText = "idmoneda";
            this.idmonedax.Name = "idmonedax";
            this.idmonedax.ReadOnly = true;
            this.idmonedax.Visible = false;
            // 
            // btndetalle
            // 
            this.btndetalle.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndetalle.Image = ((System.Drawing.Image)(resources.GetObject("btndetalle.Image")));
            this.btndetalle.Location = new System.Drawing.Point(246, 540);
            this.btndetalle.Name = "btndetalle";
            this.btndetalle.Size = new System.Drawing.Size(75, 23);
            this.btndetalle.TabIndex = 39;
            this.btndetalle.Text = "Detalle";
            this.btndetalle.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btndetalle.UseVisualStyleBackColor = true;
            this.btndetalle.Click += new System.EventHandler(this.btndetalle_Click);
            // 
            // pbFoto
            // 
            this.pbFoto.BackColor = System.Drawing.Color.Transparent;
            this.pbFoto.Location = new System.Drawing.Point(645, 10);
            this.pbFoto.Name = "pbFoto";
            this.pbFoto.Size = new System.Drawing.Size(519, 547);
            this.pbFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbFoto.TabIndex = 38;
            this.pbFoto.TabStop = false;
            this.pbFoto.DoubleClick += new System.EventHandler(this.pbFoto_DoubleClick);
            this.pbFoto.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pbFoto_MouseMove);
            // 
            // btndescargar
            // 
            this.btndescargar.AutoEllipsis = true;
            this.btndescargar.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndescargar.ImageKey = "(ninguno)";
            this.btndescargar.Location = new System.Drawing.Point(894, 526);
            this.btndescargar.Name = "btndescargar";
            this.btndescargar.Size = new System.Drawing.Size(76, 23);
            this.btndescargar.TabIndex = 111;
            this.btndescargar.Text = "Descargar";
            this.btndescargar.UseVisualStyleBackColor = false;
            this.btndescargar.Visible = false;
            this.btndescargar.Click += new System.EventHandler(this.btndescargar_Click);
            this.btndescargar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btndescargar_MouseMove);
            // 
            // btnactualizar
            // 
            this.btnactualizar.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnactualizar.Image = ((System.Drawing.Image)(resources.GetObject("btnactualizar.Image")));
            this.btnactualizar.Location = new System.Drawing.Point(545, 4);
            this.btnactualizar.Name = "btnactualizar";
            this.btnactualizar.Size = new System.Drawing.Size(94, 23);
            this.btnactualizar.TabIndex = 112;
            this.btnactualizar.Text = "Actualizar";
            this.btnactualizar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnactualizar.UseVisualStyleBackColor = true;
            this.btnactualizar.Click += new System.EventHandler(this.btnactualizar_Click);
            // 
            // frmAprobarCotizacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1176, 567);
            this.Controls.Add(this.btnactualizar);
            this.Controls.Add(this.btndescargar);
            this.Controls.Add(this.btndetalle);
            this.Controls.Add(this.pbFoto);
            this.Controls.Add(this.gridCotizacionesAsociadas);
            this.Controls.Add(this.btnAprobar);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.gridCotizacion);
            this.MaximumSize = new System.Drawing.Size(1192, 606);
            this.MinimumSize = new System.Drawing.Size(1192, 606);
            this.Name = "frmAprobarCotizacion";
            this.Nombre = "  Aprobar Cotizaciones";
            this.Text = "  Aprobar Cotizaciones";
            this.Load += new System.EventHandler(this.frmAprobarCotizacion_Load);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.frmAprobarCotizacion_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.gridCotizacion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridCotizacionesAsociadas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnAprobar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private Dtgconten gridCotizacion;
        private Dtgconten gridCotizacionesAsociadas;
        private System.Windows.Forms.PictureBox pbFoto;
        private System.Windows.Forms.DataGridViewTextBoxColumn OP;
        private System.Windows.Forms.DataGridViewTextBoxColumn c;
        private System.Windows.Forms.DataGridViewTextBoxColumn USUARIO;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGOAREA;
        private System.Windows.Forms.DataGridViewTextBoxColumn AREA;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGOGERENCIA;
        private System.Windows.Forms.DataGridViewTextBoxColumn GERENCIA;
        private System.Windows.Forms.DataGridViewTextBoxColumn TIPO_PEDIDO;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGOCC;
        private System.Windows.Forms.DataGridViewTextBoxColumn CENTROCOSTO;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGOPP;
        private System.Windows.Forms.DataGridViewTextBoxColumn PARTIDAPRESUPUESTO;
        private System.Windows.Forms.Button btndetalle;
        private System.Windows.Forms.Button btndescargar;
        private System.Windows.Forms.Button btnactualizar;
        private System.Windows.Forms.DataGridViewTextBoxColumn COTIZACION;
        private System.Windows.Forms.DataGridViewTextBoxColumn PEDIDO;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGOPROVEEDOR;
        private System.Windows.Forms.DataGridViewTextBoxColumn PROVEEDOR;
        private System.Windows.Forms.DataGridViewTextBoxColumn MONEDAX;
        private System.Windows.Forms.DataGridViewTextBoxColumn IMPORTE;
        private System.Windows.Forms.DataGridViewTextBoxColumn FECHAENTREGA;
        private System.Windows.Forms.DataGridViewTextBoxColumn ADJUNTO;
        private System.Windows.Forms.DataGridViewTextBoxColumn idmonedax;
    }
}