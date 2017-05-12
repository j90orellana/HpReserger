namespace HPReserger
{
    partial class frmOrdenPedidoCotizacion
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtGerencia = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtArea = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtFecha = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPedido = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.gridCotizacionPedido = new System.Windows.Forms.DataGridView();
            this.CODIGOARTICULO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Item = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGOMARCA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Marca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGOMODELO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Modelo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridCotizacionPedido)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtGerencia);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtArea);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtUsuario);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtFecha);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtPedido);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(777, 87);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            // 
            // txtGerencia
            // 
            this.txtGerencia.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtGerencia.Location = new System.Drawing.Point(471, 51);
            this.txtGerencia.Name = "txtGerencia";
            this.txtGerencia.ReadOnly = true;
            this.txtGerencia.Size = new System.Drawing.Size(294, 20);
            this.txtGerencia.TabIndex = 19;
            this.txtGerencia.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(407, 51);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "Gerencia";
            // 
            // txtArea
            // 
            this.txtArea.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtArea.Location = new System.Drawing.Point(46, 51);
            this.txtArea.Name = "txtArea";
            this.txtArea.ReadOnly = true;
            this.txtArea.Size = new System.Drawing.Size(336, 20);
            this.txtArea.TabIndex = 17;
            this.txtArea.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(7, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Area";
            // 
            // txtUsuario
            // 
            this.txtUsuario.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtUsuario.Location = new System.Drawing.Point(451, 16);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.ReadOnly = true;
            this.txtUsuario.Size = new System.Drawing.Size(314, 20);
            this.txtUsuario.TabIndex = 15;
            this.txtUsuario.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(395, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Usuario";
            // 
            // txtFecha
            // 
            this.txtFecha.Location = new System.Drawing.Point(233, 16);
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.ReadOnly = true;
            this.txtFecha.Size = new System.Drawing.Size(108, 20);
            this.txtFecha.TabIndex = 13;
            this.txtFecha.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(175, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Fecha";
            // 
            // txtPedido
            // 
            this.txtPedido.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtPedido.Location = new System.Drawing.Point(46, 16);
            this.txtPedido.Name = "txtPedido";
            this.txtPedido.ReadOnly = true;
            this.txtPedido.Size = new System.Drawing.Size(80, 20);
            this.txtPedido.TabIndex = 11;
            this.txtPedido.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Nº";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.gridCotizacionPedido);
            this.groupBox2.Location = new System.Drawing.Point(12, 105);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(777, 258);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            // 
            // gridCotizacionPedido
            // 
            this.gridCotizacionPedido.AllowUserToAddRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridCotizacionPedido.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gridCotizacionPedido.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridCotizacionPedido.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CODIGOARTICULO,
            this.Item,
            this.CODIGOMARCA,
            this.Marca,
            this.CODIGOMODELO,
            this.Modelo,
            this.Cantidad});
            this.gridCotizacionPedido.Location = new System.Drawing.Point(10, 19);
            this.gridCotizacionPedido.Name = "gridCotizacionPedido";
            this.gridCotizacionPedido.ReadOnly = true;
            this.gridCotizacionPedido.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.gridCotizacionPedido.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridCotizacionPedido.Size = new System.Drawing.Size(755, 227);
            this.gridCotizacionPedido.TabIndex = 17;
            // 
            // CODIGOARTICULO
            // 
            this.CODIGOARTICULO.DataPropertyName = "CODIGOARTICULO";
            this.CODIGOARTICULO.HeaderText = "CODIGOARTICULO";
            this.CODIGOARTICULO.Name = "CODIGOARTICULO";
            this.CODIGOARTICULO.ReadOnly = true;
            this.CODIGOARTICULO.Visible = false;
            // 
            // Item
            // 
            this.Item.DataPropertyName = "ITEM";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Item.DefaultCellStyle = dataGridViewCellStyle2;
            this.Item.HeaderText = "ITEM";
            this.Item.Name = "Item";
            this.Item.ReadOnly = true;
            this.Item.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Item.Width = 180;
            // 
            // CODIGOMARCA
            // 
            this.CODIGOMARCA.DataPropertyName = "CODIGOMARCA";
            this.CODIGOMARCA.HeaderText = "CODIGOMARCA";
            this.CODIGOMARCA.Name = "CODIGOMARCA";
            this.CODIGOMARCA.ReadOnly = true;
            this.CODIGOMARCA.Visible = false;
            // 
            // Marca
            // 
            this.Marca.DataPropertyName = "MARCA";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Marca.DefaultCellStyle = dataGridViewCellStyle3;
            this.Marca.HeaderText = "MARCA";
            this.Marca.Name = "Marca";
            this.Marca.ReadOnly = true;
            this.Marca.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Marca.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Marca.Width = 180;
            // 
            // CODIGOMODELO
            // 
            this.CODIGOMODELO.DataPropertyName = "CODIGOMODELO";
            this.CODIGOMODELO.HeaderText = "CODIGOMODELO";
            this.CODIGOMODELO.Name = "CODIGOMODELO";
            this.CODIGOMODELO.ReadOnly = true;
            this.CODIGOMODELO.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.CODIGOMODELO.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.CODIGOMODELO.Visible = false;
            // 
            // Modelo
            // 
            this.Modelo.DataPropertyName = "MODELO";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.Modelo.DefaultCellStyle = dataGridViewCellStyle4;
            this.Modelo.HeaderText = "MODELO";
            this.Modelo.Name = "Modelo";
            this.Modelo.ReadOnly = true;
            this.Modelo.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Modelo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Modelo.Width = 180;
            // 
            // Cantidad
            // 
            this.Cantidad.DataPropertyName = "CANTIDAD";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle5.Format = "N0";
            dataGridViewCellStyle5.NullValue = null;
            this.Cantidad.DefaultCellStyle = dataGridViewCellStyle5;
            this.Cantidad.HeaderText = "CANTIDAD";
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.ReadOnly = true;
            // 
            // frmOrdenPedidoCotizacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(795, 371);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmOrdenPedidoCotizacion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "  Orden de Pedido";
            this.Load += new System.EventHandler(this.frmOrdenPedidoCotizacion_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridCotizacionPedido)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtGerencia;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtFecha;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPedido;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtArea;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView gridCotizacionPedido;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGOARTICULO;
        private System.Windows.Forms.DataGridViewTextBoxColumn Item;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGOMARCA;
        private System.Windows.Forms.DataGridViewTextBoxColumn Marca;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGOMODELO;
        private System.Windows.Forms.DataGridViewTextBoxColumn Modelo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
    }
}