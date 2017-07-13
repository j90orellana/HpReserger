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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gridOC = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtProveedor = new System.Windows.Forms.TextBox();
            this.txtImporte = new System.Windows.Forms.TextBox();
            this.txtFechaEntrega = new System.Windows.Forms.TextBox();
            this.gridDetalle = new System.Windows.Forms.DataGridView();
            this.CODIGOARTICULO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ITEM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGOMARCA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MARCA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGOMODELO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MODELO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CANTIDAD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label5 = new System.Windows.Forms.Label();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.btnAnular = new System.Windows.Forms.Button();
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
            ((System.ComponentModel.ISupportInitialize)(this.gridOC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridDetalle)).BeginInit();
            this.SuspendLayout();
            // 
            // gridOC
            // 
            this.gridOC.AllowUserToAddRows = false;
            this.gridOC.AllowUserToOrderColumns = true;
            this.gridOC.AllowUserToResizeRows = false;
            this.gridOC.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridOC.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.gridOC.BackgroundColor = System.Drawing.SystemColors.Control;
            this.gridOC.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridOC.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gridOC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
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
            this.gridOC.GridColor = System.Drawing.Color.White;
            this.gridOC.Location = new System.Drawing.Point(12, 25);
            this.gridOC.Name = "gridOC";
            this.gridOC.ReadOnly = true;
            this.gridOC.RowHeadersVisible = false;
            this.gridOC.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridOC.Size = new System.Drawing.Size(858, 261);
            this.gridOC.TabIndex = 29;
            this.gridOC.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridOC_RowEnter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 13);
            this.label1.TabIndex = 30;
            this.label1.Text = "Orden de Compra y Servicio:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 300);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 31;
            this.label2.Text = "Proveedor";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(549, 300);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 32;
            this.label3.Text = "Importe";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(684, 300);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 13);
            this.label4.TabIndex = 33;
            this.label4.Text = "Fecha de Entrega";
            // 
            // txtProveedor
            // 
            this.txtProveedor.Location = new System.Drawing.Point(74, 300);
            this.txtProveedor.Name = "txtProveedor";
            this.txtProveedor.ReadOnly = true;
            this.txtProveedor.Size = new System.Drawing.Size(459, 20);
            this.txtProveedor.TabIndex = 34;
            // 
            // txtImporte
            // 
            this.txtImporte.Location = new System.Drawing.Point(597, 300);
            this.txtImporte.Name = "txtImporte";
            this.txtImporte.ReadOnly = true;
            this.txtImporte.Size = new System.Drawing.Size(78, 20);
            this.txtImporte.TabIndex = 35;
            this.txtImporte.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtFechaEntrega
            // 
            this.txtFechaEntrega.Location = new System.Drawing.Point(782, 300);
            this.txtFechaEntrega.Name = "txtFechaEntrega";
            this.txtFechaEntrega.ReadOnly = true;
            this.txtFechaEntrega.Size = new System.Drawing.Size(88, 20);
            this.txtFechaEntrega.TabIndex = 36;
            this.txtFechaEntrega.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // gridDetalle
            // 
            this.gridDetalle.AllowUserToAddRows = false;
            this.gridDetalle.AllowUserToOrderColumns = true;
            this.gridDetalle.AllowUserToResizeRows = false;
            this.gridDetalle.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridDetalle.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.gridDetalle.BackgroundColor = System.Drawing.SystemColors.Control;
            this.gridDetalle.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridDetalle.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.gridDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridDetalle.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CODIGOARTICULO,
            this.ITEM,
            this.CODIGOMARCA,
            this.MARCA,
            this.CODIGOMODELO,
            this.MODELO,
            this.CANTIDAD});
            this.gridDetalle.GridColor = System.Drawing.Color.White;
            this.gridDetalle.Location = new System.Drawing.Point(12, 353);
            this.gridDetalle.Name = "gridDetalle";
            this.gridDetalle.ReadOnly = true;
            this.gridDetalle.RowHeadersVisible = false;
            this.gridDetalle.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridDetalle.Size = new System.Drawing.Size(764, 261);
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
            this.ITEM.DataPropertyName = "ITEM";
            this.ITEM.HeaderText = "ITEM";
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
            this.MARCA.DataPropertyName = "MARCA";
            this.MARCA.HeaderText = "MARCA";
            this.MARCA.Name = "MARCA";
            this.MARCA.ReadOnly = true;
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
            this.MODELO.DataPropertyName = "MODELO";
            this.MODELO.HeaderText = "MODELO";
            this.MODELO.Name = "MODELO";
            this.MODELO.ReadOnly = true;
            // 
            // CANTIDAD
            // 
            this.CANTIDAD.DataPropertyName = "CANTIDAD";
            this.CANTIDAD.HeaderText = "CANTIDAD";
            this.CANTIDAD.Name = "CANTIDAD";
            this.CANTIDAD.ReadOnly = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 337);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 38;
            this.label5.Text = "Detalle:";
            // 
            // btnEnviar
            // 
            this.btnEnviar.Location = new System.Drawing.Point(795, 379);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(75, 23);
            this.btnEnviar.TabIndex = 39;
            this.btnEnviar.Text = "Enviar";
            this.btnEnviar.UseVisualStyleBackColor = true;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // btnAnular
            // 
            this.btnAnular.Location = new System.Drawing.Point(794, 448);
            this.btnAnular.Name = "btnAnular";
            this.btnAnular.Size = new System.Drawing.Size(75, 23);
            this.btnAnular.TabIndex = 40;
            this.btnAnular.Text = "Anular";
            this.btnAnular.UseVisualStyleBackColor = true;
            this.btnAnular.Click += new System.EventHandler(this.btnAnular_Click);
            // 
            // ORDENCOMPRA
            // 
            this.ORDENCOMPRA.DataPropertyName = "ORDENCOMPRA";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.ORDENCOMPRA.DefaultCellStyle = dataGridViewCellStyle2;
            this.ORDENCOMPRA.HeaderText = "Nº OC";
            this.ORDENCOMPRA.Name = "ORDENCOMPRA";
            this.ORDENCOMPRA.ReadOnly = true;
            // 
            // COTIZACION
            // 
            this.COTIZACION.DataPropertyName = "COTIZACION";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.COTIZACION.DefaultCellStyle = dataGridViewCellStyle3;
            this.COTIZACION.HeaderText = "Nº COT";
            this.COTIZACION.Name = "COTIZACION";
            this.COTIZACION.ReadOnly = true;
            // 
            // ORDENPEDIDO
            // 
            this.ORDENPEDIDO.DataPropertyName = "ORDENPEDIDO";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ORDENPEDIDO.DefaultCellStyle = dataGridViewCellStyle4;
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
            this.GERENCIA.DataPropertyName = "GERENCIA";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.GERENCIA.DefaultCellStyle = dataGridViewCellStyle6;
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
            // frmOrdenCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(895, 623);
            this.Controls.Add(this.btnAnular);
            this.Controls.Add(this.btnEnviar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.gridDetalle);
            this.Controls.Add(this.txtFechaEntrega);
            this.Controls.Add(this.txtImporte);
            this.Controls.Add(this.txtProveedor);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gridOC);
            this.MaximizeBox = false;
            this.Name = "frmOrdenCompra";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "  Orden de Compra y Servicio";
            this.Load += new System.EventHandler(this.frmOrdenCompra_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridOC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridDetalle)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gridOC;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtProveedor;
        private System.Windows.Forms.TextBox txtImporte;
        private System.Windows.Forms.TextBox txtFechaEntrega;
        private System.Windows.Forms.DataGridView gridDetalle;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGOARTICULO;
        private System.Windows.Forms.DataGridViewTextBoxColumn ITEM;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGOMARCA;
        private System.Windows.Forms.DataGridViewTextBoxColumn MARCA;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGOMODELO;
        private System.Windows.Forms.DataGridViewTextBoxColumn MODELO;
        private System.Windows.Forms.DataGridViewTextBoxColumn CANTIDAD;
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
    }
}