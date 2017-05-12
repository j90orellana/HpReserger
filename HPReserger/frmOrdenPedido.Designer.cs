namespace HPReserger
{
    partial class frmOrdenPedido
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.txtGerencia = new System.Windows.Forms.TextBox();
            this.txtArea = new System.Windows.Forms.TextBox();
            this.txtCentroCosto = new System.Windows.Forms.TextBox();
            this.cboTipoPedido = new System.Windows.Forms.ComboBox();
            this.gridItem = new System.Windows.Forms.DataGridView();
            this.Item = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Marca = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Modelo = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnListar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.txtNumeros = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.gridItem)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Usuario";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(282, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Centro de Costo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(500, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tipo de Pedido";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Área";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(500, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Gerencia";
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(67, 15);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.ReadOnly = true;
            this.txtUsuario.Size = new System.Drawing.Size(185, 20);
            this.txtUsuario.TabIndex = 5;
            // 
            // txtGerencia
            // 
            this.txtGerencia.Location = new System.Drawing.Point(602, 15);
            this.txtGerencia.Name = "txtGerencia";
            this.txtGerencia.ReadOnly = true;
            this.txtGerencia.Size = new System.Drawing.Size(158, 20);
            this.txtGerencia.TabIndex = 7;
            // 
            // txtArea
            // 
            this.txtArea.Location = new System.Drawing.Point(67, 45);
            this.txtArea.Name = "txtArea";
            this.txtArea.ReadOnly = true;
            this.txtArea.Size = new System.Drawing.Size(307, 20);
            this.txtArea.TabIndex = 8;
            // 
            // txtCentroCosto
            // 
            this.txtCentroCosto.Location = new System.Drawing.Point(389, 15);
            this.txtCentroCosto.Name = "txtCentroCosto";
            this.txtCentroCosto.ReadOnly = true;
            this.txtCentroCosto.Size = new System.Drawing.Size(82, 20);
            this.txtCentroCosto.TabIndex = 9;
            // 
            // cboTipoPedido
            // 
            this.cboTipoPedido.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTipoPedido.FormattingEnabled = true;
            this.cboTipoPedido.Location = new System.Drawing.Point(602, 45);
            this.cboTipoPedido.Name = "cboTipoPedido";
            this.cboTipoPedido.Size = new System.Drawing.Size(158, 21);
            this.cboTipoPedido.TabIndex = 10;
            this.cboTipoPedido.SelectedIndexChanged += new System.EventHandler(this.cboTipoPedido_SelectedIndexChanged);
            // 
            // gridItem
            // 
            this.gridItem.AllowUserToAddRows = false;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridItem.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.gridItem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridItem.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Item,
            this.Marca,
            this.Modelo,
            this.Cantidad});
            this.gridItem.Location = new System.Drawing.Point(12, 87);
            this.gridItem.Name = "gridItem";
            this.gridItem.Size = new System.Drawing.Size(755, 270);
            this.gridItem.TabIndex = 0;
            this.gridItem.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridItem_CellValueChanged);
            this.gridItem.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.gridItem_EditingControlShowing);
            this.gridItem.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gridItem_KeyDown);
            // 
            // Item
            // 
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Item.DefaultCellStyle = dataGridViewCellStyle7;
            this.Item.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox;
            this.Item.HeaderText = "Item";
            this.Item.Name = "Item";
            this.Item.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Item.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Item.Width = 180;
            // 
            // Marca
            // 
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Marca.DefaultCellStyle = dataGridViewCellStyle8;
            this.Marca.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox;
            this.Marca.HeaderText = "Marca";
            this.Marca.Name = "Marca";
            this.Marca.Width = 180;
            // 
            // Modelo
            // 
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.Modelo.DefaultCellStyle = dataGridViewCellStyle9;
            this.Modelo.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox;
            this.Modelo.HeaderText = "Modelo";
            this.Modelo.Name = "Modelo";
            this.Modelo.Width = 180;
            // 
            // Cantidad
            // 
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle10.Format = "N0";
            dataGridViewCellStyle10.NullValue = null;
            this.Cantidad.DefaultCellStyle = dataGridViewCellStyle10;
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            // 
            // btnAceptar
            // 
            this.btnAceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptar.Location = new System.Drawing.Point(773, 292);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 12;
            this.btnAceptar.Text = "&Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnListar
            // 
            this.btnListar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListar.Location = new System.Drawing.Point(773, 334);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(75, 23);
            this.btnListar.TabIndex = 14;
            this.btnListar.Text = "&Listar";
            this.btnListar.UseVisualStyleBackColor = true;
            this.btnListar.Click += new System.EventHandler(this.btnListar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Location = new System.Drawing.Point(773, 87);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(29, 23);
            this.btnAgregar.TabIndex = 15;
            this.btnAgregar.Text = "...";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // txtNumeros
            // 
            this.txtNumeros.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNumeros.Location = new System.Drawing.Point(773, 238);
            this.txtNumeros.Name = "txtNumeros";
            this.txtNumeros.Size = new System.Drawing.Size(75, 20);
            this.txtNumeros.TabIndex = 16;
            this.txtNumeros.Visible = false;
            this.txtNumeros.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumeros_KeyPress);
            // 
            // frmOrdenPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(854, 369);
            this.Controls.Add(this.txtNumeros);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.btnListar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.gridItem);
            this.Controls.Add(this.cboTipoPedido);
            this.Controls.Add(this.txtCentroCosto);
            this.Controls.Add(this.txtArea);
            this.Controls.Add(this.txtGerencia);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "frmOrdenPedido";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "  Orden de Pedido";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmOrdenPedido_FormClosing);
            this.Load += new System.EventHandler(this.frmOrdenPedido_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridItem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.TextBox txtGerencia;
        private System.Windows.Forms.TextBox txtArea;
        private System.Windows.Forms.TextBox txtCentroCosto;
        private System.Windows.Forms.ComboBox cboTipoPedido;
        private System.Windows.Forms.DataGridViewComboBoxColumn Item;
        private System.Windows.Forms.DataGridViewComboBoxColumn Marca;
        private System.Windows.Forms.DataGridViewComboBoxColumn Modelo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnListar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.DataGridView gridItem;
        private System.Windows.Forms.TextBox txtNumeros;
    }
}