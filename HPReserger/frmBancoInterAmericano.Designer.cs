namespace HPReserger
{
    partial class frmBancoInterAmericano
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBancoInterAmericano));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Dtguias = new System.Windows.Forms.DataGridView();
            this.btnaceptar = new System.Windows.Forms.Button();
            this.btncancelar = new System.Windows.Forms.Button();
            this.txtrecibo = new System.Windows.Forms.TextBox();
            this.txttotalpagos = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtcuenta = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ptb = new System.Windows.Forms.PictureBox();
            this.txtnotacredito = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtfacturas = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtordenpago = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtnotadebito = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.SaveFile = new System.Windows.Forms.SaveFileDialog();
            this.TIPODOC = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.NRODOCUMENTO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NOMBRECLIENTE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TIPOOP = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.NRODOC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MONEDA = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.NETO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FECVENDOC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGOPROPIO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TIPOABONO = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.BANCO = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.MONEDACUENTA = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.NUMEROCTA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumNotaDebito = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FECHAADELANTO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FORMADEPAGOPROVEEDOR = new System.Windows.Forms.DataGridViewComboBoxColumn();
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
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(149)))), ((int)(((byte)(217)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Dtguias.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.Dtguias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dtguias.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TIPODOC,
            this.NRODOCUMENTO,
            this.NOMBRECLIENTE,
            this.TIPOOP,
            this.NRODOC,
            this.MONEDA,
            this.NETO,
            this.FECVENDOC,
            this.CODIGOPROPIO,
            this.TIPOABONO,
            this.BANCO,
            this.MONEDACUENTA,
            this.NUMEROCTA,
            this.NumNotaDebito,
            this.FECHAADELANTO,
            this.FORMADEPAGOPROVEEDOR});
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Dtguias.DefaultCellStyle = dataGridViewCellStyle10;
            this.Dtguias.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.Dtguias.EnableHeadersVisualStyles = false;
            this.Dtguias.Location = new System.Drawing.Point(12, 127);
            this.Dtguias.MultiSelect = false;
            this.Dtguias.Name = "Dtguias";
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Dtguias.RowHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.Dtguias.RowHeadersVisible = false;
            this.Dtguias.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.Dtguias.Size = new System.Drawing.Size(1510, 436);
            this.Dtguias.TabIndex = 52;
            this.Dtguias.TabStop = false;
            this.Dtguias.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dtguias_CellClick);
            this.Dtguias.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.Dtguias_DataError);
            this.Dtguias.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dtguias_RowEnter);
            // 
            // btnaceptar
            // 
            this.btnaceptar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnaceptar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(149)))), ((int)(((byte)(217)))));
            this.btnaceptar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnaceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnaceptar.ForeColor = System.Drawing.Color.White;
            this.btnaceptar.Location = new System.Drawing.Point(1366, 569);
            this.btnaceptar.Name = "btnaceptar";
            this.btnaceptar.Size = new System.Drawing.Size(75, 23);
            this.btnaceptar.TabIndex = 55;
            this.btnaceptar.Text = "Generar";
            this.btnaceptar.UseVisualStyleBackColor = false;
            this.btnaceptar.Click += new System.EventHandler(this.btnaceptar_Click);
            // 
            // btncancelar
            // 
            this.btncancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btncancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(149)))), ((int)(((byte)(217)))));
            this.btncancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btncancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncancelar.ForeColor = System.Drawing.Color.White;
            this.btncancelar.Location = new System.Drawing.Point(1447, 569);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(75, 23);
            this.btncancelar.TabIndex = 56;
            this.btncancelar.Text = "Cancelar";
            this.btncancelar.UseVisualStyleBackColor = false;
            this.btncancelar.Click += new System.EventHandler(this.btncancelar_Click);
            // 
            // txtrecibo
            // 
            this.txtrecibo.BackColor = System.Drawing.Color.White;
            this.txtrecibo.Location = new System.Drawing.Point(708, 88);
            this.txtrecibo.Name = "txtrecibo";
            this.txtrecibo.ReadOnly = true;
            this.txtrecibo.Size = new System.Drawing.Size(100, 20);
            this.txtrecibo.TabIndex = 66;
            this.txtrecibo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txttotalpagos
            // 
            this.txttotalpagos.BackColor = System.Drawing.Color.White;
            this.txttotalpagos.Location = new System.Drawing.Point(904, 88);
            this.txttotalpagos.Name = "txttotalpagos";
            this.txttotalpagos.ReadOnly = true;
            this.txttotalpagos.Size = new System.Drawing.Size(100, 20);
            this.txttotalpagos.TabIndex = 65;
            this.txttotalpagos.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(820, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 64;
            this.label2.Text = "Total S/.";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(627, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 35);
            this.label1.TabIndex = 63;
            this.label1.Text = "Total Recibo por Honorarios:";
            // 
            // txtcuenta
            // 
            this.txtcuenta.BackColor = System.Drawing.Color.White;
            this.txtcuenta.Location = new System.Drawing.Point(152, 101);
            this.txtcuenta.Name = "txtcuenta";
            this.txtcuenta.ReadOnly = true;
            this.txtcuenta.Size = new System.Drawing.Size(227, 20);
            this.txtcuenta.TabIndex = 61;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 13);
            this.label3.TabIndex = 60;
            this.label3.Text = "Cuenta Seleccionada:";
            // 
            // ptb
            // 
            this.ptb.Image = ((System.Drawing.Image)(resources.GetObject("ptb.Image")));
            this.ptb.Location = new System.Drawing.Point(12, 12);
            this.ptb.Name = "ptb";
            this.ptb.Size = new System.Drawing.Size(596, 83);
            this.ptb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptb.TabIndex = 62;
            this.ptb.TabStop = false;
            // 
            // txtnotacredito
            // 
            this.txtnotacredito.BackColor = System.Drawing.Color.White;
            this.txtnotacredito.Location = new System.Drawing.Point(708, 62);
            this.txtnotacredito.Name = "txtnotacredito";
            this.txtnotacredito.ReadOnly = true;
            this.txtnotacredito.Size = new System.Drawing.Size(100, 20);
            this.txtnotacredito.TabIndex = 68;
            this.txtnotacredito.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(627, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 26);
            this.label4.TabIndex = 67;
            this.label4.Text = "Total Nota Crédito:";
            // 
            // txtfacturas
            // 
            this.txtfacturas.BackColor = System.Drawing.Color.White;
            this.txtfacturas.Location = new System.Drawing.Point(708, 36);
            this.txtfacturas.Name = "txtfacturas";
            this.txtfacturas.ReadOnly = true;
            this.txtfacturas.Size = new System.Drawing.Size(100, 20);
            this.txtfacturas.TabIndex = 70;
            this.txtfacturas.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(624, 39);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 13);
            this.label5.TabIndex = 69;
            this.label5.Text = "Total Facturas:";
            // 
            // txtordenpago
            // 
            this.txtordenpago.BackColor = System.Drawing.Color.White;
            this.txtordenpago.Location = new System.Drawing.Point(904, 36);
            this.txtordenpago.Name = "txtordenpago";
            this.txtordenpago.ReadOnly = true;
            this.txtordenpago.Size = new System.Drawing.Size(100, 20);
            this.txtordenpago.TabIndex = 72;
            this.txtordenpago.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(823, 34);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 26);
            this.label6.TabIndex = 71;
            this.label6.Text = "Total Orden de Pago:";
            // 
            // txtnotadebito
            // 
            this.txtnotadebito.BackColor = System.Drawing.Color.White;
            this.txtnotadebito.Location = new System.Drawing.Point(904, 62);
            this.txtnotadebito.Name = "txtnotadebito";
            this.txtnotadebito.ReadOnly = true;
            this.txtnotadebito.Size = new System.Drawing.Size(100, 20);
            this.txtnotadebito.TabIndex = 74;
            this.txtnotadebito.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(823, 60);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 26);
            this.label7.TabIndex = 73;
            this.label7.Text = "Total Nota Débito:";
            // 
            // SaveFile
            // 
            this.SaveFile.Filter = "Archivos de Texto|*.txt";
            // 
            // TIPODOC
            // 
            this.TIPODOC.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.TIPODOC.DataPropertyName = "tipodoc";
            this.TIPODOC.HeaderText = "TIPO DOC.";
            this.TIPODOC.MinimumWidth = 80;
            this.TIPODOC.Name = "TIPODOC";
            this.TIPODOC.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.TIPODOC.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.TIPODOC.Width = 80;
            // 
            // NRODOCUMENTO
            // 
            this.NRODOCUMENTO.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.NRODOCUMENTO.DataPropertyName = "nrodoc";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.NRODOCUMENTO.DefaultCellStyle = dataGridViewCellStyle3;
            this.NRODOCUMENTO.HeaderText = "NRO. DOCUMENTO";
            this.NRODOCUMENTO.MaxInputLength = 15;
            this.NRODOCUMENTO.MinimumWidth = 80;
            this.NRODOCUMENTO.Name = "NRODOCUMENTO";
            this.NRODOCUMENTO.Width = 80;
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
            // TIPOOP
            // 
            this.TIPOOP.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.TIPOOP.DataPropertyName = "tipoop";
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.TIPOOP.DefaultCellStyle = dataGridViewCellStyle4;
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
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.NRODOC.DefaultCellStyle = dataGridViewCellStyle5;
            this.NRODOC.HeaderText = "NRO. DOC. PAGO- FACTURA";
            this.NRODOC.MaxInputLength = 14;
            this.NRODOC.MinimumWidth = 85;
            this.NRODOC.Name = "NRODOC";
            this.NRODOC.Width = 85;
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
            // NETO
            // 
            this.NETO.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.NETO.DataPropertyName = "neto";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle6.Format = "00.00";
            dataGridViewCellStyle6.NullValue = null;
            this.NETO.DefaultCellStyle = dataGridViewCellStyle6;
            this.NETO.HeaderText = "NETO";
            this.NETO.MaxInputLength = 10;
            this.NETO.Name = "NETO";
            this.NETO.Width = 60;
            // 
            // FECVENDOC
            // 
            this.FECVENDOC.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.FECVENDOC.DataPropertyName = "fechaven";
            dataGridViewCellStyle7.Format = "d";
            dataGridViewCellStyle7.NullValue = null;
            this.FECVENDOC.DefaultCellStyle = dataGridViewCellStyle7;
            this.FECVENDOC.HeaderText = "FEC. VENC. DOC. (DDMMAAAA)";
            this.FECVENDOC.MaxInputLength = 10;
            this.FECVENDOC.MinimumWidth = 80;
            this.FECVENDOC.Name = "FECVENDOC";
            this.FECVENDOC.Width = 80;
            // 
            // CODIGOPROPIO
            // 
            this.CODIGOPROPIO.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.CODIGOPROPIO.DataPropertyName = "codigo";
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.White;
            this.CODIGOPROPIO.DefaultCellStyle = dataGridViewCellStyle8;
            this.CODIGOPROPIO.HeaderText = "CÓDIGO PROPIO BENEFICIARIO";
            this.CODIGOPROPIO.MaxInputLength = 15;
            this.CODIGOPROPIO.MinimumWidth = 100;
            this.CODIGOPROPIO.Name = "CODIGOPROPIO";
            // 
            // TIPOABONO
            // 
            this.TIPOABONO.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.TIPOABONO.DataPropertyName = "tipoabono";
            this.TIPOABONO.HeaderText = "TIPO DE ABONO";
            this.TIPOABONO.MinimumWidth = 158;
            this.TIPOABONO.Name = "TIPOABONO";
            this.TIPOABONO.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.TIPOABONO.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.TIPOABONO.Width = 158;
            // 
            // BANCO
            // 
            this.BANCO.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.BANCO.DataPropertyName = "banco";
            this.BANCO.HeaderText = "BANCO";
            this.BANCO.MinimumWidth = 136;
            this.BANCO.Name = "BANCO";
            this.BANCO.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.BANCO.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.BANCO.Width = 158;
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
            // NUMEROCTA
            // 
            this.NUMEROCTA.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.NUMEROCTA.DataPropertyName = "nrocuenta";
            this.NUMEROCTA.HeaderText = "NÚMERO CTA.";
            this.NUMEROCTA.MaxInputLength = 20;
            this.NUMEROCTA.Name = "NUMEROCTA";
            this.NUMEROCTA.Width = 96;
            // 
            // NumNotaDebito
            // 
            this.NumNotaDebito.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.NumNotaDebito.DataPropertyName = "credito";
            this.NumNotaDebito.HeaderText = "Núm. Doc. de Aplicación para la nota de Crédito";
            this.NumNotaDebito.MaxInputLength = 14;
            this.NumNotaDebito.MinimumWidth = 110;
            this.NumNotaDebito.Name = "NumNotaDebito";
            this.NumNotaDebito.Width = 110;
            // 
            // FECHAADELANTO
            // 
            this.FECHAADELANTO.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.FECHAADELANTO.DataPropertyName = "FECHAADE";
            dataGridViewCellStyle9.Format = "d";
            dataGridViewCellStyle9.NullValue = null;
            this.FECHAADELANTO.DefaultCellStyle = dataGridViewCellStyle9;
            this.FECHAADELANTO.HeaderText = "FECHA DE ADELANTO (DDMMAAAA)";
            this.FECHAADELANTO.MaxInputLength = 10;
            this.FECHAADELANTO.MinimumWidth = 80;
            this.FECHAADELANTO.Name = "FECHAADELANTO";
            this.FECHAADELANTO.Width = 80;
            // 
            // FORMADEPAGOPROVEEDOR
            // 
            this.FORMADEPAGOPROVEEDOR.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.FORMADEPAGOPROVEEDOR.DataPropertyName = "tipopago";
            this.FORMADEPAGOPROVEEDOR.HeaderText = "FORMA DE PAGO AL PROVEEDOR";
            this.FORMADEPAGOPROVEEDOR.MinimumWidth = 115;
            this.FORMADEPAGOPROVEEDOR.Name = "FORMADEPAGOPROVEEDOR";
            this.FORMADEPAGOPROVEEDOR.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.FORMADEPAGOPROVEEDOR.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.FORMADEPAGOPROVEEDOR.Width = 115;
            // 
            // frmBancoInterAmericano
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1534, 604);
            this.Controls.Add(this.txtnotadebito);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtordenpago);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtfacturas);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtnotacredito);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtrecibo);
            this.Controls.Add(this.txttotalpagos);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtcuenta);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ptb);
            this.Controls.Add(this.btnaceptar);
            this.Controls.Add(this.btncancelar);
            this.Controls.Add(this.Dtguias);
            this.Name = "frmBancoInterAmericano";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Banco Interamericano de Finanzas";
            this.Load += new System.EventHandler(this.frmBancoInterAmericano_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Dtguias)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView Dtguias;
        private System.Windows.Forms.Button btnaceptar;
        private System.Windows.Forms.Button btncancelar;
        private System.Windows.Forms.TextBox txtrecibo;
        private System.Windows.Forms.TextBox txttotalpagos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox txtcuenta;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox ptb;
        private System.Windows.Forms.TextBox txtnotacredito;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtfacturas;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtordenpago;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtnotadebito;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.SaveFileDialog SaveFile;
        private System.Windows.Forms.DataGridViewComboBoxColumn TIPODOC;
        private System.Windows.Forms.DataGridViewTextBoxColumn NRODOCUMENTO;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOMBRECLIENTE;
        private System.Windows.Forms.DataGridViewComboBoxColumn TIPOOP;
        private System.Windows.Forms.DataGridViewTextBoxColumn NRODOC;
        private System.Windows.Forms.DataGridViewComboBoxColumn MONEDA;
        private System.Windows.Forms.DataGridViewTextBoxColumn NETO;
        private System.Windows.Forms.DataGridViewTextBoxColumn FECVENDOC;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGOPROPIO;
        private System.Windows.Forms.DataGridViewComboBoxColumn TIPOABONO;
        private System.Windows.Forms.DataGridViewComboBoxColumn BANCO;
        private System.Windows.Forms.DataGridViewComboBoxColumn MONEDACUENTA;
        private System.Windows.Forms.DataGridViewTextBoxColumn NUMEROCTA;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumNotaDebito;
        private System.Windows.Forms.DataGridViewTextBoxColumn FECHAADELANTO;
        private System.Windows.Forms.DataGridViewComboBoxColumn FORMADEPAGOPROVEEDOR;
    }
}