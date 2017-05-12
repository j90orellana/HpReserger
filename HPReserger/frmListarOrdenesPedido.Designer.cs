namespace HPReserger
{
    partial class frmListarOrdenesPedido
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gridListar = new System.Windows.Forms.DataGridView();
            this.Tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Numero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtServicios = new System.Windows.Forms.TextBox();
            this.txtArticulos = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.rbtFechas = new System.Windows.Forms.RadioButton();
            this.dtpHasta = new System.Windows.Forms.DateTimePicker();
            this.dtpDesde = new System.Windows.Forms.DateTimePicker();
            this.rbtServicios = new System.Windows.Forms.RadioButton();
            this.rbtArticulo = new System.Windows.Forms.RadioButton();
            this.btnMostrar = new System.Windows.Forms.Button();
            this.gridDetalle = new System.Windows.Forms.DataGridView();
            this.CODIGOARTICULO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Item = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGOMARCA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Marca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGOMODELO = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Modelo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAnular = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridListar)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridDetalle)).BeginInit();
            this.SuspendLayout();
            // 
            // gridListar
            // 
            this.gridListar.AllowUserToAddRows = false;
            this.gridListar.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridListar.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gridListar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridListar.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Tipo,
            this.Numero,
            this.Fecha,
            this.Estado});
            this.gridListar.Location = new System.Drawing.Point(12, 70);
            this.gridListar.Name = "gridListar";
            this.gridListar.ReadOnly = true;
            this.gridListar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridListar.Size = new System.Drawing.Size(430, 270);
            this.gridListar.TabIndex = 1;
            this.gridListar.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridListar_RowEnter);
            // 
            // Tipo
            // 
            this.Tipo.DataPropertyName = "TIPO";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Tipo.DefaultCellStyle = dataGridViewCellStyle2;
            this.Tipo.HeaderText = "TIPO";
            this.Tipo.Name = "Tipo";
            this.Tipo.ReadOnly = true;
            this.Tipo.Width = 40;
            // 
            // Numero
            // 
            this.Numero.DataPropertyName = "NUMERO";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Numero.DefaultCellStyle = dataGridViewCellStyle3;
            this.Numero.HeaderText = "NRO_OrdenPedido";
            this.Numero.Name = "Numero";
            this.Numero.ReadOnly = true;
            this.Numero.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Numero.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Numero.Width = 120;
            // 
            // Fecha
            // 
            this.Fecha.DataPropertyName = "FECHA";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Fecha.DefaultCellStyle = dataGridViewCellStyle4;
            this.Fecha.HeaderText = "FECHA";
            this.Fecha.Name = "Fecha";
            this.Fecha.ReadOnly = true;
            this.Fecha.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Fecha.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Fecha.Width = 90;
            // 
            // Estado
            // 
            this.Estado.DataPropertyName = "ESTADO";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Estado.DefaultCellStyle = dataGridViewCellStyle5;
            this.Estado.HeaderText = "ESTADO";
            this.Estado.Name = "Estado";
            this.Estado.ReadOnly = true;
            this.Estado.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Estado.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Estado.Width = 110;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtServicios);
            this.groupBox1.Controls.Add(this.txtArticulos);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.rbtFechas);
            this.groupBox1.Controls.Add(this.dtpHasta);
            this.groupBox1.Controls.Add(this.dtpDesde);
            this.groupBox1.Controls.Add(this.rbtServicios);
            this.groupBox1.Controls.Add(this.rbtArticulo);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(938, 52);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // txtServicios
            // 
            this.txtServicios.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtServicios.Enabled = false;
            this.txtServicios.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtServicios.Location = new System.Drawing.Point(354, 19);
            this.txtServicios.Name = "txtServicios";
            this.txtServicios.Size = new System.Drawing.Size(165, 20);
            this.txtServicios.TabIndex = 13;
            this.txtServicios.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtServicios_KeyPress);
            // 
            // txtArticulos
            // 
            this.txtArticulos.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtArticulos.Enabled = false;
            this.txtArticulos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtArticulos.Location = new System.Drawing.Point(96, 19);
            this.txtArticulos.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.txtArticulos.Name = "txtArticulos";
            this.txtArticulos.Size = new System.Drawing.Size(165, 20);
            this.txtArticulos.TabIndex = 12;
            this.txtArticulos.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtArticulos_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(768, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Hasta";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(600, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Desde";
            // 
            // rbtFechas
            // 
            this.rbtFechas.AutoSize = true;
            this.rbtFechas.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtFechas.Location = new System.Drawing.Point(534, 20);
            this.rbtFechas.Name = "rbtFechas";
            this.rbtFechas.Size = new System.Drawing.Size(60, 17);
            this.rbtFechas.TabIndex = 9;
            this.rbtFechas.Text = "Fechas";
            this.rbtFechas.UseVisualStyleBackColor = true;
            this.rbtFechas.Click += new System.EventHandler(this.rbtFechas_Click);
            // 
            // dtpHasta
            // 
            this.dtpHasta.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpHasta.Enabled = false;
            this.dtpHasta.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpHasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpHasta.Location = new System.Drawing.Point(809, 19);
            this.dtpHasta.Name = "dtpHasta";
            this.dtpHasta.Size = new System.Drawing.Size(108, 20);
            this.dtpHasta.TabIndex = 8;
            this.dtpHasta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dtpHasta_KeyPress);
            // 
            // dtpDesde
            // 
            this.dtpDesde.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDesde.Enabled = false;
            this.dtpDesde.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDesde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDesde.Location = new System.Drawing.Point(644, 19);
            this.dtpDesde.Name = "dtpDesde";
            this.dtpDesde.Size = new System.Drawing.Size(108, 20);
            this.dtpDesde.TabIndex = 7;
            this.dtpDesde.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dtpDesde_KeyPress);
            // 
            // rbtServicios
            // 
            this.rbtServicios.AutoSize = true;
            this.rbtServicios.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtServicios.Location = new System.Drawing.Point(280, 19);
            this.rbtServicios.Name = "rbtServicios";
            this.rbtServicios.Size = new System.Drawing.Size(68, 17);
            this.rbtServicios.TabIndex = 2;
            this.rbtServicios.Text = "Servicios";
            this.rbtServicios.UseVisualStyleBackColor = true;
            this.rbtServicios.Click += new System.EventHandler(this.rbtServicios_Click);
            // 
            // rbtArticulo
            // 
            this.rbtArticulo.AutoSize = true;
            this.rbtArticulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtArticulo.Location = new System.Drawing.Point(23, 19);
            this.rbtArticulo.Name = "rbtArticulo";
            this.rbtArticulo.Size = new System.Drawing.Size(67, 17);
            this.rbtArticulo.TabIndex = 0;
            this.rbtArticulo.Text = "Artículos";
            this.rbtArticulo.UseVisualStyleBackColor = true;
            this.rbtArticulo.Click += new System.EventHandler(this.rbtArticulo_Click);
            // 
            // btnMostrar
            // 
            this.btnMostrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMostrar.Location = new System.Drawing.Point(970, 41);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(66, 23);
            this.btnMostrar.TabIndex = 14;
            this.btnMostrar.Text = "Mostrar";
            this.btnMostrar.UseVisualStyleBackColor = true;
            this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);
            // 
            // gridDetalle
            // 
            this.gridDetalle.AllowUserToAddRows = false;
            this.gridDetalle.AllowUserToDeleteRows = false;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridDetalle.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.gridDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridDetalle.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CODIGOARTICULO,
            this.Item,
            this.CODIGOMARCA,
            this.Marca,
            this.CODIGOMODELO,
            this.Modelo,
            this.Cantidad});
            this.gridDetalle.Location = new System.Drawing.Point(459, 70);
            this.gridDetalle.Name = "gridDetalle";
            this.gridDetalle.ReadOnly = true;
            this.gridDetalle.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.gridDetalle.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridDetalle.Size = new System.Drawing.Size(752, 270);
            this.gridDetalle.TabIndex = 15;
            this.gridDetalle.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridDetalle_RowEnter);
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
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Item.DefaultCellStyle = dataGridViewCellStyle7;
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
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Marca.DefaultCellStyle = dataGridViewCellStyle8;
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
            this.CODIGOMODELO.Visible = false;
            // 
            // Modelo
            // 
            this.Modelo.DataPropertyName = "MODELO";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.Modelo.DefaultCellStyle = dataGridViewCellStyle9;
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
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle10.Format = "N0";
            dataGridViewCellStyle10.NullValue = null;
            this.Cantidad.DefaultCellStyle = dataGridViewCellStyle10;
            this.Cantidad.HeaderText = "CANTIDAD";
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.ReadOnly = true;
            // 
            // btnAnular
            // 
            this.btnAnular.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnular.Location = new System.Drawing.Point(1136, 41);
            this.btnAnular.Name = "btnAnular";
            this.btnAnular.Size = new System.Drawing.Size(75, 23);
            this.btnAnular.TabIndex = 16;
            this.btnAnular.Text = "Anular";
            this.btnAnular.UseVisualStyleBackColor = true;
            this.btnAnular.Click += new System.EventHandler(this.btnAnular_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.Location = new System.Drawing.Point(1136, 12);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(75, 23);
            this.btnModificar.TabIndex = 17;
            this.btnModificar.Text = "Editar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // frmListarOrdenesPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1221, 351);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnAnular);
            this.Controls.Add(this.gridDetalle);
            this.Controls.Add(this.btnMostrar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gridListar);
            this.MaximizeBox = false;
            this.Name = "frmListarOrdenesPedido";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " Listar Ordenes de Pedido";
            ((System.ComponentModel.ISupportInitialize)(this.gridListar)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridDetalle)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView gridListar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbtArticulo;
        private System.Windows.Forms.RadioButton rbtServicios;
        private System.Windows.Forms.DateTimePicker dtpDesde;
        private System.Windows.Forms.DateTimePicker dtpHasta;
        private System.Windows.Forms.RadioButton rbtFechas;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtServicios;
        private System.Windows.Forms.TextBox txtArticulos;
        private System.Windows.Forms.Button btnMostrar;
        private System.Windows.Forms.DataGridView gridDetalle;
        private System.Windows.Forms.Button btnAnular;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGOARTICULO;
        private System.Windows.Forms.DataGridViewTextBoxColumn Item;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGOMARCA;
        private System.Windows.Forms.DataGridViewTextBoxColumn Marca;
        private System.Windows.Forms.DataGridViewButtonColumn CODIGOMODELO;
        private System.Windows.Forms.DataGridViewTextBoxColumn Modelo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Numero;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
    }
}