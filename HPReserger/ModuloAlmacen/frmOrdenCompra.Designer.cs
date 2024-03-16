using HpResergerUserControls;

namespace HPReserger
{
    partial class frmOrdenCompra
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmOrdenCompra));
            this.gridOC = new HpResergerUserControls.Dtgconten();
            this.ORDENCOMPRA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.COTIZACION = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ORDENPEDIDO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGOCC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CENTROCOSTO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGOPP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PARTIDAPRESUPUESTO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGOUSUARIO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.USUARIO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGOAREA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AREA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGOGERENCIA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GERENCIA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TIPO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtProveedor = new System.Windows.Forms.TextBox();
            this.txtImporte = new System.Windows.Forms.TextBox();
            this.txtFechaEntrega = new System.Windows.Forms.TextBox();
            this.gridDetalle = new HpResergerUserControls.Dtgconten();
            this.CODIGOARTICULO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ITEM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGOMARCA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MARCA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGOMODELO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MODELO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CANTIDAD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.btnAnular = new System.Windows.Forms.Button();
            this.btnactualizar = new System.Windows.Forms.Button();
            this.txtmoneda = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.pbCotizacion = new System.Windows.Forms.PictureBox();
            this.btndescargar = new System.Windows.Forms.Button();
            this.btnaprobar = new System.Windows.Forms.Button();
            this.label29 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gridOC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridDetalle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCotizacion)).BeginInit();
            this.SuspendLayout();
            // 
            // gridOC
            // 
            this.gridOC.AllowUserToAddRows = false;
            this.gridOC.AllowUserToResizeColumns = false;
            this.gridOC.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(230)))), ((int)(((byte)(241)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(191)))), ((int)(((byte)(231)))));
            this.gridOC.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.gridOC.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridOC.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridOC.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.gridOC.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(218)))), ((int)(((byte)(231)))));
            this.gridOC.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.gridOC.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.gridOC.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(129)))), ((int)(((byte)(189)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DeepSkyBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridOC.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.gridOC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.gridOC.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ORDENCOMPRA,
            this.COTIZACION,
            this.ORDENPEDIDO,
            this.CODIGOCC,
            this.CENTROCOSTO,
            this.CODIGOPP,
            this.PARTIDAPRESUPUESTO,
            this.CODIGOUSUARIO,
            this.USUARIO,
            this.CODIGOAREA,
            this.AREA,
            this.CODIGOGERENCIA,
            this.GERENCIA,
            this.TIPO});
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(207)))), ((int)(((byte)(241)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridOC.DefaultCellStyle = dataGridViewCellStyle8;
            this.gridOC.EnableHeadersVisualStyles = false;
            this.gridOC.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(179)))), ((int)(((byte)(215)))));
            this.gridOC.Location = new System.Drawing.Point(11, 29);
            this.gridOC.Name = "gridOC";
            this.gridOC.ReadOnly = true;
            this.gridOC.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.gridOC.RowHeadersVisible = false;
            this.gridOC.RowTemplate.Height = 18;
            this.gridOC.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridOC.Size = new System.Drawing.Size(862, 263);
            this.gridOC.TabIndex = 29;
            this.gridOC.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridOC_RowEnter);
            // 
            // ORDENCOMPRA
            // 
            this.ORDENCOMPRA.DataPropertyName = "ORDENCOMPRA";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.ORDENCOMPRA.DefaultCellStyle = dataGridViewCellStyle3;
            this.ORDENCOMPRA.HeaderText = "Nº OC";
            this.ORDENCOMPRA.Name = "ORDENCOMPRA";
            this.ORDENCOMPRA.ReadOnly = true;
            // 
            // COTIZACION
            // 
            this.COTIZACION.DataPropertyName = "COTIZACION";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.COTIZACION.DefaultCellStyle = dataGridViewCellStyle4;
            this.COTIZACION.HeaderText = "Nº COT";
            this.COTIZACION.Name = "COTIZACION";
            this.COTIZACION.ReadOnly = true;
            // 
            // ORDENPEDIDO
            // 
            this.ORDENPEDIDO.DataPropertyName = "ORDENPEDIDO";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ORDENPEDIDO.DefaultCellStyle = dataGridViewCellStyle5;
            this.ORDENPEDIDO.HeaderText = "Nº OP";
            this.ORDENPEDIDO.Name = "ORDENPEDIDO";
            this.ORDENPEDIDO.ReadOnly = true;
            this.ORDENPEDIDO.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ORDENPEDIDO.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
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
            this.CENTROCOSTO.HeaderText = "CENTRO DE COSTO";
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
            this.PARTIDAPRESUPUESTO.HeaderText = "P. PTO";
            this.PARTIDAPRESUPUESTO.Name = "PARTIDAPRESUPUESTO";
            this.PARTIDAPRESUPUESTO.ReadOnly = true;
            // 
            // CODIGOUSUARIO
            // 
            this.CODIGOUSUARIO.DataPropertyName = "CODIGOUSUARIO";
            this.CODIGOUSUARIO.HeaderText = "CODIGOUSUARIO";
            this.CODIGOUSUARIO.Name = "CODIGOUSUARIO";
            this.CODIGOUSUARIO.ReadOnly = true;
            this.CODIGOUSUARIO.Visible = false;
            // 
            // USUARIO
            // 
            this.USUARIO.DataPropertyName = "USUARIO";
            this.USUARIO.HeaderText = "USUARIO";
            this.USUARIO.Name = "USUARIO";
            this.USUARIO.ReadOnly = true;
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
            this.AREA.DataPropertyName = "AREA";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AREA.DefaultCellStyle = dataGridViewCellStyle6;
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
            this.GERENCIA.DataPropertyName = "GERENCIA";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.GERENCIA.DefaultCellStyle = dataGridViewCellStyle7;
            this.GERENCIA.HeaderText = "GERENCIA";
            this.GERENCIA.Name = "GERENCIA";
            this.GERENCIA.ReadOnly = true;
            this.GERENCIA.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.GERENCIA.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // TIPO
            // 
            this.TIPO.DataPropertyName = "TIPO";
            this.TIPO.HeaderText = "TIPO";
            this.TIPO.Name = "TIPO";
            this.TIPO.ReadOnly = true;
            this.TIPO.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(11, 299);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 31;
            this.label2.Text = "Proveedor:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(464, 299);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 32;
            this.label3.Text = "Importe:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(700, 299);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 13);
            this.label4.TabIndex = 33;
            this.label4.Text = "Fecha de Entrega:";
            // 
            // txtProveedor
            // 
            this.txtProveedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProveedor.Location = new System.Drawing.Point(75, 295);
            this.txtProveedor.Name = "txtProveedor";
            this.txtProveedor.ReadOnly = true;
            this.txtProveedor.Size = new System.Drawing.Size(385, 21);
            this.txtProveedor.TabIndex = 34;
            // 
            // txtImporte
            // 
            this.txtImporte.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtImporte.Location = new System.Drawing.Point(619, 295);
            this.txtImporte.Name = "txtImporte";
            this.txtImporte.ReadOnly = true;
            this.txtImporte.Size = new System.Drawing.Size(78, 21);
            this.txtImporte.TabIndex = 35;
            this.txtImporte.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtFechaEntrega
            // 
            this.txtFechaEntrega.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFechaEntrega.Location = new System.Drawing.Point(798, 295);
            this.txtFechaEntrega.Name = "txtFechaEntrega";
            this.txtFechaEntrega.ReadOnly = true;
            this.txtFechaEntrega.Size = new System.Drawing.Size(75, 21);
            this.txtFechaEntrega.TabIndex = 36;
            this.txtFechaEntrega.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // gridDetalle
            // 
            this.gridDetalle.AllowUserToAddRows = false;
            this.gridDetalle.AllowUserToResizeColumns = false;
            this.gridDetalle.AllowUserToResizeRows = false;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(230)))), ((int)(((byte)(241)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(191)))), ((int)(((byte)(231)))));
            this.gridDetalle.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle9;
            this.gridDetalle.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridDetalle.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridDetalle.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.gridDetalle.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(218)))), ((int)(((byte)(231)))));
            this.gridDetalle.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.gridDetalle.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.gridDetalle.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(129)))), ((int)(((byte)(189)))));
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.DeepSkyBlue;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridDetalle.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.gridDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.gridDetalle.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CODIGOARTICULO,
            this.ITEM,
            this.CODIGOMARCA,
            this.MARCA,
            this.CODIGOMODELO,
            this.MODELO,
            this.CANTIDAD});
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(207)))), ((int)(((byte)(241)))));
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridDetalle.DefaultCellStyle = dataGridViewCellStyle11;
            this.gridDetalle.EnableHeadersVisualStyles = false;
            this.gridDetalle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(179)))), ((int)(((byte)(215)))));
            this.gridDetalle.Location = new System.Drawing.Point(11, 334);
            this.gridDetalle.Name = "gridDetalle";
            this.gridDetalle.ReadOnly = true;
            this.gridDetalle.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.gridDetalle.RowHeadersVisible = false;
            this.gridDetalle.RowTemplate.Height = 16;
            this.gridDetalle.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridDetalle.Size = new System.Drawing.Size(686, 276);
            this.gridDetalle.TabIndex = 37;
            // 
            // CODIGOARTICULO
            // 
            this.CODIGOARTICULO.DataPropertyName = "CODIGOARTICULO";
            this.CODIGOARTICULO.HeaderText = "CODIGOARTICULO";
            this.CODIGOARTICULO.Name = "CODIGOARTICULO";
            this.CODIGOARTICULO.ReadOnly = true;
            this.CODIGOARTICULO.Visible = false;
            // 
            // ITEM
            // 
            this.ITEM.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ITEM.DataPropertyName = "ITEM";
            this.ITEM.HeaderText = "ITEM";
            this.ITEM.MinimumWidth = 100;
            this.ITEM.Name = "ITEM";
            this.ITEM.ReadOnly = true;
            // 
            // CODIGOMARCA
            // 
            this.CODIGOMARCA.DataPropertyName = "CODIGOMARCA";
            this.CODIGOMARCA.HeaderText = "CODIGOMARCA";
            this.CODIGOMARCA.Name = "CODIGOMARCA";
            this.CODIGOMARCA.ReadOnly = true;
            this.CODIGOMARCA.Visible = false;
            // 
            // MARCA
            // 
            this.MARCA.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.MARCA.DataPropertyName = "MARCA";
            this.MARCA.HeaderText = "MARCA";
            this.MARCA.Name = "MARCA";
            this.MARCA.ReadOnly = true;
            this.MARCA.Width = 69;
            // 
            // CODIGOMODELO
            // 
            this.CODIGOMODELO.DataPropertyName = "CODIGOMODELO";
            this.CODIGOMODELO.HeaderText = "CODIGOMODELO";
            this.CODIGOMODELO.Name = "CODIGOMODELO";
            this.CODIGOMODELO.ReadOnly = true;
            this.CODIGOMODELO.Visible = false;
            // 
            // MODELO
            // 
            this.MODELO.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.MODELO.DataPropertyName = "MODELO";
            this.MODELO.HeaderText = "MODELO";
            this.MODELO.Name = "MODELO";
            this.MODELO.ReadOnly = true;
            this.MODELO.Width = 78;
            // 
            // CANTIDAD
            // 
            this.CANTIDAD.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.CANTIDAD.DataPropertyName = "CANTIDAD";
            this.CANTIDAD.HeaderText = "CANTIDAD";
            this.CANTIDAD.Name = "CANTIDAD";
            this.CANTIDAD.ReadOnly = true;
            this.CANTIDAD.Width = 84;
            // 
            // btnEnviar
            // 
            this.btnEnviar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEnviar.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnviar.Image = ((System.Drawing.Image)(resources.GetObject("btnEnviar.Image")));
            this.btnEnviar.Location = new System.Drawing.Point(703, 561);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(170, 24);
            this.btnEnviar.TabIndex = 39;
            this.btnEnviar.Text = "Enviar y Aprobar";
            this.btnEnviar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEnviar.UseVisualStyleBackColor = true;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // btnAnular
            // 
            this.btnAnular.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAnular.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnular.Image = ((System.Drawing.Image)(resources.GetObject("btnAnular.Image")));
            this.btnAnular.Location = new System.Drawing.Point(792, 586);
            this.btnAnular.Name = "btnAnular";
            this.btnAnular.Size = new System.Drawing.Size(81, 24);
            this.btnAnular.TabIndex = 40;
            this.btnAnular.Text = "Anular";
            this.btnAnular.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAnular.UseVisualStyleBackColor = true;
            this.btnAnular.Click += new System.EventHandler(this.btnAnular_Click);
            // 
            // btnactualizar
            // 
            this.btnactualizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnactualizar.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnactualizar.Image = ((System.Drawing.Image)(resources.GetObject("btnactualizar.Image")));
            this.btnactualizar.Location = new System.Drawing.Point(779, 4);
            this.btnactualizar.Name = "btnactualizar";
            this.btnactualizar.Size = new System.Drawing.Size(94, 23);
            this.btnactualizar.TabIndex = 41;
            this.btnactualizar.Text = "Actualizar";
            this.btnactualizar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnactualizar.UseVisualStyleBackColor = true;
            this.btnactualizar.Click += new System.EventHandler(this.btnactualizar_Click);
            // 
            // txtmoneda
            // 
            this.txtmoneda.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmoneda.Location = new System.Drawing.Point(514, 295);
            this.txtmoneda.Name = "txtmoneda";
            this.txtmoneda.ReadOnly = true;
            this.txtmoneda.Size = new System.Drawing.Size(99, 21);
            this.txtmoneda.TabIndex = 42;
            this.txtmoneda.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // pbCotizacion
            // 
            this.pbCotizacion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbCotizacion.BackColor = System.Drawing.Color.Transparent;
            this.pbCotizacion.Location = new System.Drawing.Point(703, 334);
            this.pbCotizacion.Name = "pbCotizacion";
            this.pbCotizacion.Size = new System.Drawing.Size(170, 221);
            this.pbCotizacion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbCotizacion.TabIndex = 43;
            this.pbCotizacion.TabStop = false;
            this.pbCotizacion.Click += new System.EventHandler(this.pbCotizacion_Click);
            this.pbCotizacion.DoubleClick += new System.EventHandler(this.pbCotizacion_DoubleClick);
            this.pbCotizacion.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pbCotizacion_MouseMove);
            // 
            // btndescargar
            // 
            this.btndescargar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btndescargar.AutoEllipsis = true;
            this.btndescargar.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndescargar.ImageKey = "(ninguno)";
            this.btndescargar.Location = new System.Drawing.Point(755, 522);
            this.btndescargar.Name = "btndescargar";
            this.btndescargar.Size = new System.Drawing.Size(76, 23);
            this.btndescargar.TabIndex = 112;
            this.btndescargar.Text = "Descargar";
            this.btndescargar.UseCompatibleTextRendering = true;
            this.btndescargar.UseVisualStyleBackColor = true;
            this.btndescargar.Visible = false;
            this.btndescargar.Click += new System.EventHandler(this.btndescargar_Click);
            this.btndescargar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btndescargar_MouseMove);
            // 
            // btnaprobar
            // 
            this.btnaprobar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnaprobar.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnaprobar.Image = ((System.Drawing.Image)(resources.GetObject("btnaprobar.Image")));
            this.btnaprobar.Location = new System.Drawing.Point(703, 586);
            this.btnaprobar.Name = "btnaprobar";
            this.btnaprobar.Size = new System.Drawing.Size(87, 24);
            this.btnaprobar.TabIndex = 113;
            this.btnaprobar.Text = "Aprobar";
            this.btnaprobar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnaprobar.UseVisualStyleBackColor = true;
            this.btnaprobar.Click += new System.EventHandler(this.btnaprobar_Click);
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.BackColor = System.Drawing.Color.Transparent;
            this.label29.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label29.Location = new System.Drawing.Point(11, 318);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(109, 13);
            this.label29.TabIndex = 197;
            this.label29.Text = "Detalle de la Orden:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(11, 14);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(154, 13);
            this.label5.TabIndex = 197;
            this.label5.Text = "Orden de Compra y Servicio:";
            // 
            // frmOrdenCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(885, 623);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label29);
            this.Controls.Add(this.btnaprobar);
            this.Controls.Add(this.btndescargar);
            this.Controls.Add(this.pbCotizacion);
            this.Controls.Add(this.txtmoneda);
            this.Controls.Add(this.btnactualizar);
            this.Controls.Add(this.btnAnular);
            this.Controls.Add(this.btnEnviar);
            this.Controls.Add(this.gridDetalle);
            this.Controls.Add(this.txtFechaEntrega);
            this.Controls.Add(this.txtImporte);
            this.Controls.Add(this.txtProveedor);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.gridOC);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinimumSize = new System.Drawing.Size(901, 662);
            this.Name = "frmOrdenCompra";
            this.Nombre = "Orden de Compra y Servicio";
            this.Text = "Orden de Compra y Servicio";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmOrdenCompra_FormClosing);
            this.Load += new System.EventHandler(this.frmOrdenCompra_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridOC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridDetalle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCotizacion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Dtgconten gridOC;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtProveedor;
        private System.Windows.Forms.TextBox txtImporte;
        private System.Windows.Forms.TextBox txtFechaEntrega;
        private Dtgconten gridDetalle;
        private System.Windows.Forms.Button btnEnviar;
        private System.Windows.Forms.Button btnAnular;
        private System.Windows.Forms.DataGridViewTextBoxColumn ORDENCOMPRA;
        private System.Windows.Forms.DataGridViewTextBoxColumn COTIZACION;
        private System.Windows.Forms.DataGridViewTextBoxColumn ORDENPEDIDO;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGOCC;
        private System.Windows.Forms.DataGridViewTextBoxColumn CENTROCOSTO;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGOPP;
        private System.Windows.Forms.DataGridViewTextBoxColumn PARTIDAPRESUPUESTO;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGOUSUARIO;
        private System.Windows.Forms.DataGridViewTextBoxColumn USUARIO;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGOAREA;
        private System.Windows.Forms.DataGridViewTextBoxColumn AREA;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGOGERENCIA;
        private System.Windows.Forms.DataGridViewTextBoxColumn GERENCIA;
        private System.Windows.Forms.DataGridViewTextBoxColumn TIPO;
        private System.Windows.Forms.Button btnactualizar;
        private System.Windows.Forms.TextBox txtmoneda;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.PictureBox pbCotizacion;
        private System.Windows.Forms.Button btndescargar;
        private System.Windows.Forms.Button btnaprobar;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGOARTICULO;
        private System.Windows.Forms.DataGridViewTextBoxColumn ITEM;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGOMARCA;
        private System.Windows.Forms.DataGridViewTextBoxColumn MARCA;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGOMODELO;
        private System.Windows.Forms.DataGridViewTextBoxColumn MODELO;
        private System.Windows.Forms.DataGridViewTextBoxColumn CANTIDAD;
    }
}