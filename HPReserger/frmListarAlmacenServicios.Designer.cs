﻿namespace HPReserger
{
    partial class frmListarAlmacenServicios
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle37 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle43 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle38 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle39 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle40 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle41 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle42 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle44 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle45 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle46 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle47 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle48 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtNumeros = new System.Windows.Forms.TextBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cboOC = new System.Windows.Forms.ComboBox();
            this.txtGR = new System.Windows.Forms.TextBox();
            this.txtRUC = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gridDetalle2 = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.gridDetalle1 = new System.Windows.Forms.DataGridView();
            this.ItemDetalle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.G2CODIGOARTICULO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.G2ITEM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.G2CODIGOMARCA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.G2MARCA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.G2CODIGOMODELO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.G2MODELO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CANTOC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CANTING = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FIC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FECHA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NGR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ARTOC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ARTFIC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtsuma = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridDetalle2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridDetalle1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNumeros
            // 
            this.txtNumeros.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNumeros.Location = new System.Drawing.Point(348, 68);
            this.txtNumeros.Name = "txtNumeros";
            this.txtNumeros.Size = new System.Drawing.Size(75, 20);
            this.txtNumeros.TabIndex = 36;
            this.txtNumeros.Visible = false;
            // 
            // btnAceptar
            // 
            this.btnAceptar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnAceptar.Location = new System.Drawing.Point(527, 525);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 35;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cboOC);
            this.groupBox1.Controls.Add(this.txtGR);
            this.groupBox1.Controls.Add(this.txtRUC);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(587, 50);
            this.groupBox1.TabIndex = 34;
            this.groupBox1.TabStop = false;
            // 
            // cboOC
            // 
            this.cboOC.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboOC.FormattingEnabled = true;
            this.cboOC.Location = new System.Drawing.Point(234, 16);
            this.cboOC.Name = "cboOC";
            this.cboOC.Size = new System.Drawing.Size(87, 21);
            this.cboOC.TabIndex = 12;
            this.cboOC.SelectedIndexChanged += new System.EventHandler(this.cboOC_SelectedIndexChanged);
            // 
            // txtGR
            // 
            this.txtGR.Location = new System.Drawing.Point(442, 16);
            this.txtGR.Name = "txtGR";
            this.txtGR.Size = new System.Drawing.Size(52, 20);
            this.txtGR.TabIndex = 11;
            this.txtGR.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtGR.Visible = false;
            // 
            // txtRUC
            // 
            this.txtRUC.Location = new System.Drawing.Point(90, 16);
            this.txtRUC.MaxLength = 11;
            this.txtRUC.Name = "txtRUC";
            this.txtRUC.Size = new System.Drawing.Size(92, 20);
            this.txtRUC.TabIndex = 10;
            this.txtRUC.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtRUC.TextChanged += new System.EventHandler(this.txtRUC_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label3.Location = new System.Drawing.Point(333, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Nº Guía de Remisión";
            this.label3.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(192, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Nº OC";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "RUC Proveedor";
            // 
            // gridDetalle2
            // 
            this.gridDetalle2.AllowUserToAddRows = false;
            this.gridDetalle2.AllowUserToDeleteRows = false;
            this.gridDetalle2.AllowUserToResizeColumns = false;
            this.gridDetalle2.AllowUserToResizeRows = false;
            this.gridDetalle2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle37.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle37.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle37.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle37.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle37.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle37.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle37.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridDetalle2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle37;
            this.gridDetalle2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridDetalle2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ItemDetalle,
            this.G2CODIGOARTICULO,
            this.G2ITEM,
            this.G2CODIGOMARCA,
            this.G2MARCA,
            this.G2CODIGOMODELO,
            this.G2MODELO,
            this.CANTOC,
            this.CANTING});
            this.gridDetalle2.Location = new System.Drawing.Point(12, 337);
            this.gridDetalle2.Name = "gridDetalle2";
            this.gridDetalle2.ReadOnly = true;
            this.gridDetalle2.RowHeadersVisible = false;
            this.gridDetalle2.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.gridDetalle2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridDetalle2.Size = new System.Drawing.Size(587, 182);
            this.gridDetalle2.TabIndex = 33;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label6.Location = new System.Drawing.Point(9, 314);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 13);
            this.label6.TabIndex = 32;
            this.label6.Text = "Servicios de La OC:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label4.Location = new System.Drawing.Point(14, 225);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 13);
            this.label4.TabIndex = 31;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label5.Location = new System.Drawing.Point(9, 107);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 13);
            this.label5.TabIndex = 30;
            this.label5.Text = "Registro de FICs:";
            // 
            // gridDetalle1
            // 
            this.gridDetalle1.AllowUserToAddRows = false;
            this.gridDetalle1.AllowUserToDeleteRows = false;
            this.gridDetalle1.AllowUserToResizeColumns = false;
            this.gridDetalle1.AllowUserToResizeRows = false;
            this.gridDetalle1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle43.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle43.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle43.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle43.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle43.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle43.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle43.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridDetalle1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle43;
            this.gridDetalle1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridDetalle1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FIC,
            this.FECHA,
            this.NGR,
            this.ARTOC,
            this.ARTFIC});
            this.gridDetalle1.Location = new System.Drawing.Point(12, 123);
            this.gridDetalle1.Name = "gridDetalle1";
            this.gridDetalle1.ReadOnly = true;
            this.gridDetalle1.RowHeadersVisible = false;
            this.gridDetalle1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.gridDetalle1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridDetalle1.Size = new System.Drawing.Size(587, 182);
            this.gridDetalle1.TabIndex = 29;
            this.gridDetalle1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridDetalle1_CellContentClick);
            this.gridDetalle1.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridDetalle1_CellValueChanged);
            this.gridDetalle1.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridDetalle1_RowEnter);
            // 
            // ItemDetalle
            // 
            this.ItemDetalle.DataPropertyName = "ItemDetalle";
            this.ItemDetalle.HeaderText = "ItemDetalle";
            this.ItemDetalle.Name = "ItemDetalle";
            this.ItemDetalle.ReadOnly = true;
            this.ItemDetalle.Visible = false;
            // 
            // G2CODIGOARTICULO
            // 
            this.G2CODIGOARTICULO.DataPropertyName = "CODIGOARTICULO";
            this.G2CODIGOARTICULO.HeaderText = "CODIGOARTICULO";
            this.G2CODIGOARTICULO.Name = "G2CODIGOARTICULO";
            this.G2CODIGOARTICULO.ReadOnly = true;
            this.G2CODIGOARTICULO.Visible = false;
            // 
            // G2ITEM
            // 
            this.G2ITEM.DataPropertyName = "ITEM";
            dataGridViewCellStyle38.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle38.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.G2ITEM.DefaultCellStyle = dataGridViewCellStyle38;
            this.G2ITEM.HeaderText = "ITEM";
            this.G2ITEM.Name = "G2ITEM";
            this.G2ITEM.ReadOnly = true;
            this.G2ITEM.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // G2CODIGOMARCA
            // 
            this.G2CODIGOMARCA.DataPropertyName = "CODIGOMARCA";
            this.G2CODIGOMARCA.HeaderText = "CODIGOMARCA";
            this.G2CODIGOMARCA.Name = "G2CODIGOMARCA";
            this.G2CODIGOMARCA.ReadOnly = true;
            this.G2CODIGOMARCA.Visible = false;
            // 
            // G2MARCA
            // 
            this.G2MARCA.DataPropertyName = "MARCA";
            dataGridViewCellStyle39.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle39.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.G2MARCA.DefaultCellStyle = dataGridViewCellStyle39;
            this.G2MARCA.HeaderText = "MARCA";
            this.G2MARCA.Name = "G2MARCA";
            this.G2MARCA.ReadOnly = true;
            this.G2MARCA.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.G2MARCA.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // G2CODIGOMODELO
            // 
            this.G2CODIGOMODELO.DataPropertyName = "CODIGOMODELO";
            this.G2CODIGOMODELO.HeaderText = "CODIGOMODELO";
            this.G2CODIGOMODELO.Name = "G2CODIGOMODELO";
            this.G2CODIGOMODELO.ReadOnly = true;
            this.G2CODIGOMODELO.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.G2CODIGOMODELO.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.G2CODIGOMODELO.Visible = false;
            // 
            // G2MODELO
            // 
            this.G2MODELO.DataPropertyName = "MODELO";
            dataGridViewCellStyle40.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.G2MODELO.DefaultCellStyle = dataGridViewCellStyle40;
            this.G2MODELO.HeaderText = "MODELO";
            this.G2MODELO.Name = "G2MODELO";
            this.G2MODELO.ReadOnly = true;
            this.G2MODELO.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.G2MODELO.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // CANTOC
            // 
            this.CANTOC.DataPropertyName = "CANTIDAD";
            dataGridViewCellStyle41.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle41.Format = "N0";
            dataGridViewCellStyle41.NullValue = null;
            this.CANTOC.DefaultCellStyle = dataGridViewCellStyle41;
            this.CANTOC.HeaderText = "CANT OC";
            this.CANTOC.Name = "CANTOC";
            this.CANTOC.ReadOnly = true;
            this.CANTOC.Visible = false;
            // 
            // CANTING
            // 
            this.CANTING.DataPropertyName = "CANTIDADFIC";
            dataGridViewCellStyle42.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.CANTING.DefaultCellStyle = dataGridViewCellStyle42;
            this.CANTING.HeaderText = "CANT ING";
            this.CANTING.Name = "CANTING";
            this.CANTING.ReadOnly = true;
            // 
            // FIC
            // 
            this.FIC.DataPropertyName = "FIC";
            dataGridViewCellStyle44.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle44.Format = "N0";
            dataGridViewCellStyle44.NullValue = null;
            this.FIC.DefaultCellStyle = dataGridViewCellStyle44;
            this.FIC.HeaderText = " Nº FIC";
            this.FIC.Name = "FIC";
            this.FIC.ReadOnly = true;
            // 
            // FECHA
            // 
            this.FECHA.DataPropertyName = "FECHA";
            dataGridViewCellStyle45.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.FECHA.DefaultCellStyle = dataGridViewCellStyle45;
            this.FECHA.HeaderText = "FECHA";
            this.FECHA.Name = "FECHA";
            this.FECHA.ReadOnly = true;
            // 
            // NGR
            // 
            this.NGR.DataPropertyName = "GUIA";
            dataGridViewCellStyle46.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.NGR.DefaultCellStyle = dataGridViewCellStyle46;
            this.NGR.HeaderText = "VALORIZACION";
            this.NGR.Name = "NGR";
            this.NGR.ReadOnly = true;
            // 
            // ARTOC
            // 
            this.ARTOC.DataPropertyName = "ARTOC";
            dataGridViewCellStyle47.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.ARTOC.DefaultCellStyle = dataGridViewCellStyle47;
            this.ARTOC.HeaderText = "ART OC";
            this.ARTOC.Name = "ARTOC";
            this.ARTOC.ReadOnly = true;
            this.ARTOC.Visible = false;
            // 
            // ARTFIC
            // 
            this.ARTFIC.DataPropertyName = "ARTFIC";
            dataGridViewCellStyle48.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle48.Format = "0\'%\'";
            dataGridViewCellStyle48.NullValue = null;
            this.ARTFIC.DefaultCellStyle = dataGridViewCellStyle48;
            this.ARTFIC.HeaderText = "ART FIC";
            this.ARTFIC.Name = "ARTFIC";
            this.ARTFIC.ReadOnly = true;
            // 
            // txtsuma
            // 
            this.txtsuma.BackColor = System.Drawing.SystemColors.Window;
            this.txtsuma.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtsuma.Location = new System.Drawing.Point(509, 311);
            this.txtsuma.Name = "txtsuma";
            this.txtsuma.Size = new System.Drawing.Size(90, 20);
            this.txtsuma.TabIndex = 36;
            this.txtsuma.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label7.Location = new System.Drawing.Point(442, 314);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 13);
            this.label7.TabIndex = 32;
            this.label7.Text = "Suma Total";
            // 
            // frmListarAlmacenServicios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(608, 551);
            this.Controls.Add(this.txtsuma);
            this.Controls.Add(this.txtNumeros);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gridDetalle2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.gridDetalle1);
            this.Name = "frmListarAlmacenServicios";
            this.Text = "Listar Articulos Almacen";
            this.Load += new System.EventHandler(this.frmListarAlmacenArticulos_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridDetalle2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridDetalle1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNumeros;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cboOC;
        private System.Windows.Forms.TextBox txtGR;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView gridDetalle2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView gridDetalle1;
        public System.Windows.Forms.TextBox txtRUC;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemDetalle;
        private System.Windows.Forms.DataGridViewTextBoxColumn G2CODIGOARTICULO;
        private System.Windows.Forms.DataGridViewTextBoxColumn G2ITEM;
        private System.Windows.Forms.DataGridViewTextBoxColumn G2CODIGOMARCA;
        private System.Windows.Forms.DataGridViewTextBoxColumn G2MARCA;
        private System.Windows.Forms.DataGridViewTextBoxColumn G2CODIGOMODELO;
        private System.Windows.Forms.DataGridViewTextBoxColumn G2MODELO;
        private System.Windows.Forms.DataGridViewTextBoxColumn CANTOC;
        private System.Windows.Forms.DataGridViewTextBoxColumn CANTING;
        private System.Windows.Forms.DataGridViewTextBoxColumn FIC;
        private System.Windows.Forms.DataGridViewTextBoxColumn FECHA;
        private System.Windows.Forms.DataGridViewTextBoxColumn NGR;
        private System.Windows.Forms.DataGridViewTextBoxColumn ARTOC;
        private System.Windows.Forms.DataGridViewTextBoxColumn ARTFIC;
        private System.Windows.Forms.TextBox txtsuma;
        private System.Windows.Forms.Label label7;
    }
}