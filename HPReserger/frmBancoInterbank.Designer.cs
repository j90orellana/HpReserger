namespace HPReserger
{
    partial class frmBancoInterbank
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Dtguias = new System.Windows.Forms.DataGridView();
            this.CODIGOPROPIO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TIPOOP = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.NRODOC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FECVENDOC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MONEDA = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.IMPORTE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NETO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BANCO = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.TIPOABONO = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.TIPOCUENTA = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.MONEDACUENTA = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.TIENDA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NUMEROCTA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TIPOPERSONA = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.TIPODOC = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.NRODOCUMENTO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NOMBRECLIENTE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtcuenta = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btnaceptar = new System.Windows.Forms.Button();
            this.btncancelar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txttotalpagos = new System.Windows.Forms.TextBox();
            this.txtnropagos = new System.Windows.Forms.TextBox();
            this.SaveFile = new System.Windows.Forms.SaveFileDialog();
            this.ptb = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Dtguias)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb)).BeginInit();
            this.SuspendLayout();
            // 
            // Dtguias
            // 
            this.Dtguias.AllowUserToAddRows = false;
            this.Dtguias.AllowUserToDeleteRows = false;
            this.Dtguias.AllowUserToResizeColumns = false;
            this.Dtguias.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Dtguias.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.Dtguias.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Dtguias.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Dtguias.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.Dtguias.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Dtguias.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.Dtguias.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(164)))), ((int)(((byte)(92)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Dtguias.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.Dtguias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dtguias.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CODIGOPROPIO,
            this.TIPOOP,
            this.NRODOC,
            this.FECVENDOC,
            this.MONEDA,
            this.IMPORTE,
            this.NETO,
            this.BANCO,
            this.TIPOABONO,
            this.TIPOCUENTA,
            this.MONEDACUENTA,
            this.TIENDA,
            this.NUMEROCTA,
            this.TIPOPERSONA,
            this.TIPODOC,
            this.NRODOCUMENTO,
            this.NOMBRECLIENTE});
            this.Dtguias.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.Dtguias.EnableHeadersVisualStyles = false;
            this.Dtguias.Location = new System.Drawing.Point(12, 93);
            this.Dtguias.MultiSelect = false;
            this.Dtguias.Name = "Dtguias";
            this.Dtguias.RowHeadersVisible = false;
            this.Dtguias.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.Dtguias.Size = new System.Drawing.Size(1506, 412);
            this.Dtguias.TabIndex = 41;
            this.Dtguias.TabStop = false;
            this.Dtguias.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dtguias_CellClick);
            this.Dtguias.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.Dtguias_DataError);
            this.Dtguias.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dtguias_RowEnter);
            // 
            // CODIGOPROPIO
            // 
            this.CODIGOPROPIO.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.CODIGOPROPIO.DataPropertyName = "codigo";
            this.CODIGOPROPIO.HeaderText = "CÓDIGO PROPIO BENEFICIARIO";
            this.CODIGOPROPIO.MaxInputLength = 20;
            this.CODIGOPROPIO.MinimumWidth = 100;
            this.CODIGOPROPIO.Name = "CODIGOPROPIO";
            // 
            // TIPOOP
            // 
            this.TIPOOP.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.TIPOOP.DataPropertyName = "tipoop";
            this.TIPOOP.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.TIPOOP.HeaderText = "TIPO DE OP.";
            this.TIPOOP.MinimumWidth = 115;
            this.TIPOOP.Name = "TIPOOP";
            this.TIPOOP.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.TIPOOP.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.TIPOOP.ToolTipText = "Tipo de Operación: C: Nota de Crédito; D: Nota de Débito; F: Factura";
            this.TIPOOP.Width = 115;
            // 
            // NRODOC
            // 
            this.NRODOC.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.NRODOC.DataPropertyName = "nrofac";
            this.NRODOC.HeaderText = "NRO.DOC.PAGO- FACTURA";
            this.NRODOC.MaxInputLength = 20;
            this.NRODOC.MinimumWidth = 100;
            this.NRODOC.Name = "NRODOC";
            // 
            // FECVENDOC
            // 
            this.FECVENDOC.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.FECVENDOC.DataPropertyName = "fechaven";
            dataGridViewCellStyle3.Format = "d";
            dataGridViewCellStyle3.NullValue = null;
            this.FECVENDOC.DefaultCellStyle = dataGridViewCellStyle3;
            this.FECVENDOC.HeaderText = "FEC. VENC. DOC. (DDMMAAAA)";
            this.FECVENDOC.MaxInputLength = 8;
            this.FECVENDOC.MinimumWidth = 80;
            this.FECVENDOC.Name = "FECVENDOC";
            this.FECVENDOC.Width = 80;
            // 
            // MONEDA
            // 
            this.MONEDA.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.MONEDA.DataPropertyName = "monedaabono";
            this.MONEDA.HeaderText = "MONEDA ABONO";
            this.MONEDA.MinimumWidth = 75;
            this.MONEDA.Name = "MONEDA";
            this.MONEDA.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.MONEDA.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.MONEDA.Width = 75;
            // 
            // IMPORTE
            // 
            this.IMPORTE.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.IMPORTE.DataPropertyName = "importe";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle4.Format = "00.00";
            dataGridViewCellStyle4.NullValue = null;
            this.IMPORTE.DefaultCellStyle = dataGridViewCellStyle4;
            this.IMPORTE.HeaderText = "IMPORTE";
            this.IMPORTE.MaxInputLength = 15;
            this.IMPORTE.Name = "IMPORTE";
            this.IMPORTE.Width = 79;
            // 
            // NETO
            // 
            this.NETO.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.NETO.DataPropertyName = "neto";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle5.Format = "00.00";
            this.NETO.DefaultCellStyle = dataGridViewCellStyle5;
            this.NETO.HeaderText = "NETO";
            this.NETO.MaxInputLength = 15;
            this.NETO.Name = "NETO";
            this.NETO.Width = 60;
            // 
            // BANCO
            // 
            this.BANCO.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.BANCO.DataPropertyName = "banco";
            this.BANCO.HeaderText = "BANCO";
            this.BANCO.MinimumWidth = 70;
            this.BANCO.Name = "BANCO";
            this.BANCO.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.BANCO.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.BANCO.Width = 70;
            // 
            // TIPOABONO
            // 
            this.TIPOABONO.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.TIPOABONO.DataPropertyName = "tipoabono";
            this.TIPOABONO.HeaderText = "TIPO DE ABONO";
            this.TIPOABONO.MinimumWidth = 127;
            this.TIPOABONO.Name = "TIPOABONO";
            this.TIPOABONO.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.TIPOABONO.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.TIPOABONO.Width = 127;
            // 
            // TIPOCUENTA
            // 
            this.TIPOCUENTA.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.TIPOCUENTA.DataPropertyName = "tipocuenta";
            this.TIPOCUENTA.HeaderText = "TIPO DE CUENTA";
            this.TIPOCUENTA.MinimumWidth = 129;
            this.TIPOCUENTA.Name = "TIPOCUENTA";
            this.TIPOCUENTA.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.TIPOCUENTA.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.TIPOCUENTA.Width = 129;
            // 
            // MONEDACUENTA
            // 
            this.MONEDACUENTA.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.MONEDACUENTA.DataPropertyName = "monedacuenta";
            this.MONEDACUENTA.HeaderText = "MONEDA CUENTA";
            this.MONEDACUENTA.MinimumWidth = 80;
            this.MONEDACUENTA.Name = "MONEDACUENTA";
            this.MONEDACUENTA.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.MONEDACUENTA.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.MONEDACUENTA.Width = 80;
            // 
            // TIENDA
            // 
            this.TIENDA.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.TIENDA.DataPropertyName = "tienda";
            this.TIENDA.HeaderText = "TIENDA";
            this.TIENDA.MaxInputLength = 3;
            this.TIENDA.Name = "TIENDA";
            this.TIENDA.Width = 60;
            // 
            // NUMEROCTA
            // 
            this.NUMEROCTA.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.NUMEROCTA.DataPropertyName = "nrocuenta";
            this.NUMEROCTA.HeaderText = "NÚMERO CTA.";
            this.NUMEROCTA.MaxInputLength = 20;
            this.NUMEROCTA.Name = "NUMEROCTA";
            this.NUMEROCTA.Width = 96;
            // 
            // TIPOPERSONA
            // 
            this.TIPOPERSONA.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.TIPOPERSONA.DataPropertyName = "tipopersona";
            this.TIPOPERSONA.HeaderText = "TIPO DE PERSONA";
            this.TIPOPERSONA.MinimumWidth = 117;
            this.TIPOPERSONA.Name = "TIPOPERSONA";
            this.TIPOPERSONA.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.TIPOPERSONA.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.TIPOPERSONA.Width = 117;
            // 
            // TIPODOC
            // 
            this.TIPODOC.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.TIPODOC.DataPropertyName = "tipodoc";
            this.TIPODOC.HeaderText = "TIPO DOC.";
            this.TIPODOC.MinimumWidth = 119;
            this.TIPODOC.Name = "TIPODOC";
            this.TIPODOC.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.TIPODOC.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.TIPODOC.Width = 119;
            // 
            // NRODOCUMENTO
            // 
            this.NRODOCUMENTO.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.NRODOCUMENTO.DataPropertyName = "nrodoc";
            this.NRODOCUMENTO.HeaderText = "NRO. DOCUMENTO";
            this.NRODOCUMENTO.MaxInputLength = 15;
            this.NRODOCUMENTO.MinimumWidth = 80;
            this.NRODOCUMENTO.Name = "NRODOCUMENTO";
            this.NRODOCUMENTO.Width = 119;
            // 
            // NOMBRECLIENTE
            // 
            this.NOMBRECLIENTE.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NOMBRECLIENTE.DataPropertyName = "razon";
            this.NOMBRECLIENTE.HeaderText = "NOMBRE CLIENTE O AP. PATERNO ; AP. MATERNO; NOMBRES";
            this.NOMBRECLIENTE.MaxInputLength = 60;
            this.NOMBRECLIENTE.MinimumWidth = 150;
            this.NOMBRECLIENTE.Name = "NOMBRECLIENTE";
            // 
            // txtcuenta
            // 
            this.txtcuenta.BackColor = System.Drawing.Color.White;
            this.txtcuenta.Location = new System.Drawing.Point(161, 67);
            this.txtcuenta.Name = "txtcuenta";
            this.txtcuenta.ReadOnly = true;
            this.txtcuenta.Size = new System.Drawing.Size(227, 20);
            this.txtcuenta.TabIndex = 51;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 13);
            this.label3.TabIndex = 50;
            this.label3.Text = "Cuenta Seleccionada:";
            // 
            // toolTip1
            // 
            this.toolTip1.IsBalloon = true;
            // 
            // btnaceptar
            // 
            this.btnaceptar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnaceptar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(164)))), ((int)(((byte)(92)))));
            this.btnaceptar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnaceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnaceptar.ForeColor = System.Drawing.Color.White;
            this.btnaceptar.Location = new System.Drawing.Point(1362, 511);
            this.btnaceptar.Name = "btnaceptar";
            this.btnaceptar.Size = new System.Drawing.Size(75, 23);
            this.btnaceptar.TabIndex = 53;
            this.btnaceptar.Text = "Generar";
            this.btnaceptar.UseVisualStyleBackColor = false;
            this.btnaceptar.Click += new System.EventHandler(this.btnaceptar_Click);
            // 
            // btncancelar
            // 
            this.btncancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btncancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(164)))), ((int)(((byte)(92)))));
            this.btncancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btncancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncancelar.ForeColor = System.Drawing.Color.White;
            this.btncancelar.Location = new System.Drawing.Point(1443, 511);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(75, 23);
            this.btncancelar.TabIndex = 54;
            this.btncancelar.Text = "Cancelar";
            this.btncancelar.UseVisualStyleBackColor = false;
            this.btncancelar.Click += new System.EventHandler(this.btncancelar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(636, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 56;
            this.label1.Text = "Nro. Pagos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(636, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 57;
            this.label2.Text = "Total S/.";
            // 
            // txttotalpagos
            // 
            this.txttotalpagos.BackColor = System.Drawing.Color.White;
            this.txttotalpagos.Location = new System.Drawing.Point(702, 63);
            this.txttotalpagos.Name = "txttotalpagos";
            this.txttotalpagos.ReadOnly = true;
            this.txttotalpagos.Size = new System.Drawing.Size(100, 20);
            this.txttotalpagos.TabIndex = 58;
            this.txttotalpagos.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtnropagos
            // 
            this.txtnropagos.BackColor = System.Drawing.Color.White;
            this.txtnropagos.Location = new System.Drawing.Point(702, 38);
            this.txtnropagos.Name = "txtnropagos";
            this.txtnropagos.ReadOnly = true;
            this.txtnropagos.Size = new System.Drawing.Size(100, 20);
            this.txtnropagos.TabIndex = 59;
            this.txtnropagos.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // SaveFile
            // 
            this.SaveFile.Filter = "Archivos de Texto|*.txt";
            // 
            // ptb
            // 
            this.ptb.Image = global::HPReserger.Properties.Resources.Interbank1;
            this.ptb.Location = new System.Drawing.Point(12, 11);
            this.ptb.Name = "ptb";
            this.ptb.Size = new System.Drawing.Size(605, 72);
            this.ptb.TabIndex = 55;
            this.ptb.TabStop = false;
            // 
            // frmBancoInterbank
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1530, 546);
            this.Controls.Add(this.txtnropagos);
            this.Controls.Add(this.txttotalpagos);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnaceptar);
            this.Controls.Add(this.btncancelar);
            this.Controls.Add(this.txtcuenta);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Dtguias);
            this.Controls.Add(this.ptb);
            this.Name = "frmBancoInterbank";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Banco Interbank";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmBancoInterbank_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Dtguias)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView Dtguias;
        public System.Windows.Forms.TextBox txtcuenta;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button btnaceptar;
        private System.Windows.Forms.Button btncancelar;
        private System.Windows.Forms.PictureBox ptb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txttotalpagos;
        private System.Windows.Forms.TextBox txtnropagos;
        private System.Windows.Forms.SaveFileDialog SaveFile;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGOPROPIO;
        private System.Windows.Forms.DataGridViewComboBoxColumn TIPOOP;
        private System.Windows.Forms.DataGridViewTextBoxColumn NRODOC;
        private System.Windows.Forms.DataGridViewTextBoxColumn FECVENDOC;
        private System.Windows.Forms.DataGridViewComboBoxColumn MONEDA;
        private System.Windows.Forms.DataGridViewTextBoxColumn IMPORTE;
        private System.Windows.Forms.DataGridViewTextBoxColumn NETO;
        private System.Windows.Forms.DataGridViewComboBoxColumn BANCO;
        private System.Windows.Forms.DataGridViewComboBoxColumn TIPOABONO;
        private System.Windows.Forms.DataGridViewComboBoxColumn TIPOCUENTA;
        private System.Windows.Forms.DataGridViewComboBoxColumn MONEDACUENTA;
        private System.Windows.Forms.DataGridViewTextBoxColumn TIENDA;
        private System.Windows.Forms.DataGridViewTextBoxColumn NUMEROCTA;
        private System.Windows.Forms.DataGridViewComboBoxColumn TIPOPERSONA;
        private System.Windows.Forms.DataGridViewComboBoxColumn TIPODOC;
        private System.Windows.Forms.DataGridViewTextBoxColumn NRODOCUMENTO;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOMBRECLIENTE;
    }
}