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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnAprobar = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.gridCotizacion = new System.Windows.Forms.DataGridView();
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
            this.gridCotizacionesAsociadas = new System.Windows.Forms.DataGridView();
            this.COTIZACION = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PEDIDO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGOPROVEEDOR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PROVEEDOR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IMPORTE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FECHAENTREGA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ADJUNTO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pbFoto = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.gridCotizacion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridCotizacionesAsociadas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFoto)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAprobar
            // 
            this.btnAprobar.Location = new System.Drawing.Point(268, 537);
            this.btnAprobar.Name = "btnAprobar";
            this.btnAprobar.Size = new System.Drawing.Size(75, 23);
            this.btnAprobar.TabIndex = 35;
            this.btnAprobar.Text = "Aprobar";
            this.btnAprobar.UseVisualStyleBackColor = true;
            this.btnAprobar.Click += new System.EventHandler(this.btnAprobar_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 325);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(160, 13);
            this.label7.TabIndex = 33;
            this.label7.Text = "Cotización por Orden de Pedido:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(9, 11);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 13);
            this.label6.TabIndex = 31;
            this.label6.Text = "Orden de Pedido:";
            // 
            // gridCotizacion
            // 
            this.gridCotizacion.AllowUserToAddRows = false;
            this.gridCotizacion.AllowUserToOrderColumns = true;
            this.gridCotizacion.AllowUserToResizeRows = false;
            this.gridCotizacion.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridCotizacion.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gridCotizacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
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
            this.gridCotizacion.GridColor = System.Drawing.Color.White;
            this.gridCotizacion.Location = new System.Drawing.Point(12, 29);
            this.gridCotizacion.Name = "gridCotizacion";
            this.gridCotizacion.ReadOnly = true;
            this.gridCotizacion.RowHeadersVisible = false;
            this.gridCotizacion.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridCotizacion.Size = new System.Drawing.Size(616, 278);
            this.gridCotizacion.TabIndex = 28;
            this.gridCotizacion.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridCotizacion_RowEnter);
            // 
            // OP
            // 
            this.OP.DataPropertyName = "OP";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.OP.DefaultCellStyle = dataGridViewCellStyle2;
            this.OP.HeaderText = "Nº OP";
            this.OP.Name = "OP";
            this.OP.ReadOnly = true;
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
            this.USUARIO.DataPropertyName = "USUARIO";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.USUARIO.DefaultCellStyle = dataGridViewCellStyle3;
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
            this.AREA.DataPropertyName = "AREA";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AREA.DefaultCellStyle = dataGridViewCellStyle4;
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
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.GERENCIA.DefaultCellStyle = dataGridViewCellStyle5;
            this.GERENCIA.HeaderText = "GERENCIA";
            this.GERENCIA.Name = "GERENCIA";
            this.GERENCIA.ReadOnly = true;
            this.GERENCIA.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.GERENCIA.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // TIPO_PEDIDO
            // 
            this.TIPO_PEDIDO.DataPropertyName = "TIPO_PEDIDO";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TIPO_PEDIDO.DefaultCellStyle = dataGridViewCellStyle6;
            this.TIPO_PEDIDO.HeaderText = "TIPO PEDIDO";
            this.TIPO_PEDIDO.Name = "TIPO_PEDIDO";
            this.TIPO_PEDIDO.ReadOnly = true;
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
            this.gridCotizacionesAsociadas.AllowUserToResizeRows = false;
            this.gridCotizacionesAsociadas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridCotizacionesAsociadas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.gridCotizacionesAsociadas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridCotizacionesAsociadas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.COTIZACION,
            this.PEDIDO,
            this.CODIGOPROVEEDOR,
            this.PROVEEDOR,
            this.IMPORTE,
            this.FECHAENTREGA,
            this.ADJUNTO});
            this.gridCotizacionesAsociadas.Location = new System.Drawing.Point(12, 344);
            this.gridCotizacionesAsociadas.Name = "gridCotizacionesAsociadas";
            this.gridCotizacionesAsociadas.ReadOnly = true;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridCotizacionesAsociadas.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.gridCotizacionesAsociadas.RowHeadersVisible = false;
            this.gridCotizacionesAsociadas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridCotizacionesAsociadas.Size = new System.Drawing.Size(616, 176);
            this.gridCotizacionesAsociadas.TabIndex = 37;
            this.gridCotizacionesAsociadas.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridCotizacionesAsociadas_RowEnter);
            // 
            // COTIZACION
            // 
            this.COTIZACION.DataPropertyName = "COTIZACION";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.COTIZACION.DefaultCellStyle = dataGridViewCellStyle8;
            this.COTIZACION.HeaderText = "Nº COT";
            this.COTIZACION.Name = "COTIZACION";
            this.COTIZACION.ReadOnly = true;
            // 
            // PEDIDO
            // 
            this.PEDIDO.DataPropertyName = "PEDIDO";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.PEDIDO.DefaultCellStyle = dataGridViewCellStyle9;
            this.PEDIDO.HeaderText = "Nº OP";
            this.PEDIDO.Name = "PEDIDO";
            this.PEDIDO.ReadOnly = true;
            this.PEDIDO.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.PEDIDO.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
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
            this.PROVEEDOR.DataPropertyName = "PROVEEDOR";
            this.PROVEEDOR.HeaderText = "PROVEEDOR";
            this.PROVEEDOR.Name = "PROVEEDOR";
            this.PROVEEDOR.ReadOnly = true;
            // 
            // IMPORTE
            // 
            this.IMPORTE.DataPropertyName = "IMPORTE";
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.IMPORTE.DefaultCellStyle = dataGridViewCellStyle10;
            this.IMPORTE.HeaderText = "IMPORTE";
            this.IMPORTE.Name = "IMPORTE";
            this.IMPORTE.ReadOnly = true;
            // 
            // FECHAENTREGA
            // 
            this.FECHAENTREGA.DataPropertyName = "FECHAENTREGA";
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.FECHAENTREGA.DefaultCellStyle = dataGridViewCellStyle11;
            this.FECHAENTREGA.HeaderText = "FECHA ENTREGA";
            this.FECHAENTREGA.Name = "FECHAENTREGA";
            this.FECHAENTREGA.ReadOnly = true;
            // 
            // ADJUNTO
            // 
            this.ADJUNTO.DataPropertyName = "ADJUNTO";
            this.ADJUNTO.HeaderText = "ADJUNTO";
            this.ADJUNTO.Name = "ADJUNTO";
            this.ADJUNTO.ReadOnly = true;
            this.ADJUNTO.Visible = false;
            // 
            // pbFoto
            // 
            this.pbFoto.Location = new System.Drawing.Point(645, 10);
            this.pbFoto.Name = "pbFoto";
            this.pbFoto.Size = new System.Drawing.Size(519, 547);
            this.pbFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbFoto.TabIndex = 38;
            this.pbFoto.TabStop = false;
            // 
            // frmAprobarCotizacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1176, 567);
            this.Controls.Add(this.pbFoto);
            this.Controls.Add(this.gridCotizacionesAsociadas);
            this.Controls.Add(this.btnAprobar);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.gridCotizacion);
            this.MaximizeBox = false;
            this.Name = "frmAprobarCotizacion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "  Aprobar Cotizaciones";
            this.Load += new System.EventHandler(this.frmAprobarCotizacion_Load);
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
        private System.Windows.Forms.DataGridView gridCotizacion;
        private System.Windows.Forms.DataGridView gridCotizacionesAsociadas;
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
        private System.Windows.Forms.PictureBox pbFoto;
        private System.Windows.Forms.DataGridViewTextBoxColumn COTIZACION;
        private System.Windows.Forms.DataGridViewTextBoxColumn PEDIDO;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGOPROVEEDOR;
        private System.Windows.Forms.DataGridViewTextBoxColumn PROVEEDOR;
        private System.Windows.Forms.DataGridViewTextBoxColumn IMPORTE;
        private System.Windows.Forms.DataGridViewTextBoxColumn FECHAENTREGA;
        private System.Windows.Forms.DataGridViewTextBoxColumn ADJUNTO;
    }
}