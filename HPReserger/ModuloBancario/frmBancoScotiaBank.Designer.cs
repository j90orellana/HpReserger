namespace HPReserger.ModuloBancario
{
    partial class frmBancoScotiaBank
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBancoScotiaBank));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.ptb = new System.Windows.Forms.PictureBox();
            this.dtgconten = new HpResergerUserControls.Dtgconten();
            this.btnaceptar = new System.Windows.Forms.Button();
            this.btncancelar = new System.Windows.Forms.Button();
            this.txtcuentapago = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SaveFile = new System.Windows.Forms.SaveFileDialog();
            this.xRuc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xRazonSocial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xNroFactura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xFechaFactura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xMontoPagar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xFormaPago = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.xCodigoOficina = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xCodigoCuenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xSimplePay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xcci = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xFactoring = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xFechaVencimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xTransExterior = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ptb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgconten)).BeginInit();
            this.SuspendLayout();
            // 
            // ptb
            // 
            this.ptb.BackColor = System.Drawing.Color.White;
            this.ptb.Image = ((System.Drawing.Image)(resources.GetObject("ptb.Image")));
            this.ptb.Location = new System.Drawing.Point(12, 12);
            this.ptb.Name = "ptb";
            this.ptb.Size = new System.Drawing.Size(383, 73);
            this.ptb.TabIndex = 64;
            this.ptb.TabStop = false;
            // 
            // dtgconten
            // 
            this.dtgconten.AllowUserToAddRows = false;
            this.dtgconten.AllowUserToResizeColumns = false;
            this.dtgconten.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(184)))), ((int)(((byte)(187)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(149)))), ((int)(((byte)(153)))));
            this.dtgconten.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgconten.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgconten.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgconten.BackgroundColor = System.Drawing.Color.White;
            this.dtgconten.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgconten.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.dtgconten.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(17)))), ((int)(((byte)(26)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgconten.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dtgconten.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgconten.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.xRuc,
            this.xRazonSocial,
            this.xNroFactura,
            this.xFechaFactura,
            this.xMontoPagar,
            this.xFormaPago,
            this.xCodigoOficina,
            this.xCodigoCuenta,
            this.xSimplePay,
            this.xEmail,
            this.xcci,
            this.xFactoring,
            this.xFechaVencimiento,
            this.xTransExterior});
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(207)))), ((int)(((byte)(241)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgconten.DefaultCellStyle = dataGridViewCellStyle9;
            this.dtgconten.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dtgconten.EnableHeadersVisualStyles = false;
            this.dtgconten.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))));
            this.dtgconten.Location = new System.Drawing.Point(12, 91);
            this.dtgconten.Name = "dtgconten";
            this.dtgconten.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dtgconten.RowHeadersVisible = false;
            this.dtgconten.RowTemplate.Height = 18;
            this.dtgconten.Size = new System.Drawing.Size(1160, 335);
            this.dtgconten.TabIndex = 65;
            this.dtgconten.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgconten_CellValueChanged);
            this.dtgconten.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dtgconten_DataError);
            this.dtgconten.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgconten_RowEnter);
            // 
            // btnaceptar
            // 
            this.btnaceptar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnaceptar.BackColor = System.Drawing.Color.White;
            this.btnaceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnaceptar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(17)))), ((int)(((byte)(26)))));
            this.btnaceptar.Location = new System.Drawing.Point(1016, 432);
            this.btnaceptar.Name = "btnaceptar";
            this.btnaceptar.Size = new System.Drawing.Size(75, 23);
            this.btnaceptar.TabIndex = 84;
            this.btnaceptar.Text = "Generar";
            this.btnaceptar.UseVisualStyleBackColor = false;
            this.btnaceptar.Click += new System.EventHandler(this.btnaceptar_Click);
            // 
            // btncancelar
            // 
            this.btncancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btncancelar.BackColor = System.Drawing.Color.Red;
            this.btncancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btncancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncancelar.ForeColor = System.Drawing.Color.White;
            this.btncancelar.Location = new System.Drawing.Point(1097, 432);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(75, 23);
            this.btncancelar.TabIndex = 85;
            this.btncancelar.Text = "Cancelar";
            this.btncancelar.UseVisualStyleBackColor = false;
            this.btncancelar.Click += new System.EventHandler(this.btncancelar_Click);
            // 
            // txtcuentapago
            // 
            this.txtcuentapago.BackColor = System.Drawing.Color.White;
            this.txtcuentapago.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtcuentapago.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcuentapago.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(17)))), ((int)(((byte)(26)))));
            this.txtcuentapago.Location = new System.Drawing.Point(498, 63);
            this.txtcuentapago.MaxLength = 18;
            this.txtcuentapago.Name = "txtcuentapago";
            this.txtcuentapago.ReadOnly = true;
            this.txtcuentapago.Size = new System.Drawing.Size(176, 22);
            this.txtcuentapago.TabIndex = 86;
            this.txtcuentapago.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(17)))), ((int)(((byte)(26)))));
            this.label1.Location = new System.Drawing.Point(401, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 13);
            this.label1.TabIndex = 87;
            this.label1.Text = "Cuenta de Cargo:";
            // 
            // SaveFile
            // 
            this.SaveFile.Filter = "Archivos de Texto|*.txt";
            // 
            // xRuc
            // 
            this.xRuc.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.xRuc.DataPropertyName = "RUC";
            this.xRuc.HeaderText = "Ruc";
            this.xRuc.MaxInputLength = 11;
            this.xRuc.MinimumWidth = 70;
            this.xRuc.Name = "xRuc";
            this.xRuc.ReadOnly = true;
            this.xRuc.Width = 70;
            // 
            // xRazonSocial
            // 
            this.xRazonSocial.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.xRazonSocial.DataPropertyName = "RazonSocial";
            this.xRazonSocial.HeaderText = "Razon Social";
            this.xRazonSocial.MaxInputLength = 60;
            this.xRazonSocial.MinimumWidth = 100;
            this.xRazonSocial.Name = "xRazonSocial";
            this.xRazonSocial.ReadOnly = true;
            // 
            // xNroFactura
            // 
            this.xNroFactura.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.xNroFactura.DataPropertyName = "nrofactura";
            this.xNroFactura.HeaderText = "Nro Factura";
            this.xNroFactura.MaxInputLength = 14;
            this.xNroFactura.MinimumWidth = 70;
            this.xNroFactura.Name = "xNroFactura";
            this.xNroFactura.ReadOnly = true;
            this.xNroFactura.Width = 70;
            // 
            // xFechaFactura
            // 
            this.xFechaFactura.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.xFechaFactura.DataPropertyName = "fechafactura";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.Format = "yyyyMMdd";
            this.xFechaFactura.DefaultCellStyle = dataGridViewCellStyle3;
            this.xFechaFactura.HeaderText = "Fecha Factura";
            this.xFechaFactura.MaxInputLength = 10;
            this.xFechaFactura.MinimumWidth = 70;
            this.xFechaFactura.Name = "xFechaFactura";
            this.xFechaFactura.ReadOnly = true;
            this.xFechaFactura.Width = 70;
            // 
            // xMontoPagar
            // 
            this.xMontoPagar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.xMontoPagar.DataPropertyName = "montopagar";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle4.Format = "n2";
            this.xMontoPagar.DefaultCellStyle = dataGridViewCellStyle4;
            this.xMontoPagar.HeaderText = "Monto Pagar";
            this.xMontoPagar.MaxInputLength = 100;
            this.xMontoPagar.MinimumWidth = 70;
            this.xMontoPagar.Name = "xMontoPagar";
            this.xMontoPagar.ReadOnly = true;
            this.xMontoPagar.Width = 70;
            // 
            // xFormaPago
            // 
            this.xFormaPago.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.xFormaPago.DataPropertyName = "formapago";
            this.xFormaPago.HeaderText = "Forma Pago";
            this.xFormaPago.MinimumWidth = 65;
            this.xFormaPago.Name = "xFormaPago";
            this.xFormaPago.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.xFormaPago.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.xFormaPago.ToolTipText = resources.GetString("xFormaPago.ToolTipText");
            this.xFormaPago.Width = 65;
            // 
            // xCodigoOficina
            // 
            this.xCodigoOficina.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.xCodigoOficina.DataPropertyName = "codigooficina";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.xCodigoOficina.DefaultCellStyle = dataGridViewCellStyle5;
            this.xCodigoOficina.HeaderText = "Codigo Oficina";
            this.xCodigoOficina.MaxInputLength = 3;
            this.xCodigoOficina.MinimumWidth = 65;
            this.xCodigoOficina.Name = "xCodigoOficina";
            this.xCodigoOficina.ToolTipText = resources.GetString("xCodigoOficina.ToolTipText");
            this.xCodigoOficina.Width = 65;
            // 
            // xCodigoCuenta
            // 
            this.xCodigoCuenta.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.xCodigoCuenta.DataPropertyName = "codigocuenta";
            this.xCodigoCuenta.HeaderText = "Codigo Cuenta";
            this.xCodigoCuenta.MaxInputLength = 7;
            this.xCodigoCuenta.MinimumWidth = 65;
            this.xCodigoCuenta.Name = "xCodigoCuenta";
            this.xCodigoCuenta.ToolTipText = resources.GetString("xCodigoCuenta.ToolTipText");
            this.xCodigoCuenta.Width = 65;
            // 
            // xSimplePay
            // 
            this.xSimplePay.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.xSimplePay.DataPropertyName = "simplepay";
            this.xSimplePay.HeaderText = "Single Pay\n( * )";
            this.xSimplePay.MaxInputLength = 1;
            this.xSimplePay.MinimumWidth = 70;
            this.xSimplePay.Name = "xSimplePay";
            this.xSimplePay.Width = 70;
            // 
            // xEmail
            // 
            this.xEmail.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.xEmail.DataPropertyName = "email";
            this.xEmail.HeaderText = "Email";
            this.xEmail.MaxInputLength = 30;
            this.xEmail.MinimumWidth = 80;
            this.xEmail.Name = "xEmail";
            this.xEmail.Width = 80;
            // 
            // xcci
            // 
            this.xcci.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.xcci.DataPropertyName = "cci";
            this.xcci.HeaderText = "CCI";
            this.xcci.MaxInputLength = 20;
            this.xcci.Name = "xcci";
            this.xcci.ReadOnly = true;
            this.xcci.Width = 48;
            // 
            // xFactoring
            // 
            this.xFactoring.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.xFactoring.DataPropertyName = "factoring";
            dataGridViewCellStyle6.Format = "\"F\"";
            this.xFactoring.DefaultCellStyle = dataGridViewCellStyle6;
            this.xFactoring.HeaderText = "(F) Factoring";
            this.xFactoring.MaxInputLength = 1;
            this.xFactoring.MinimumWidth = 70;
            this.xFactoring.Name = "xFactoring";
            this.xFactoring.Width = 70;
            // 
            // xFechaVencimiento
            // 
            this.xFechaVencimiento.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.xFechaVencimiento.DataPropertyName = "fechavencimiento";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle7.Format = "yyyyMMdd";
            this.xFechaVencimiento.DefaultCellStyle = dataGridViewCellStyle7;
            this.xFechaVencimiento.HeaderText = "Fecha Vencimiento (Factoring)";
            this.xFechaVencimiento.MaxInputLength = 10;
            this.xFechaVencimiento.MinimumWidth = 80;
            this.xFechaVencimiento.Name = "xFechaVencimiento";
            this.xFechaVencimiento.Width = 80;
            // 
            // xTransExterior
            // 
            this.xTransExterior.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.xTransExterior.DataPropertyName = "trans";
            dataGridViewCellStyle8.Format = "\"*\"";
            this.xTransExterior.DefaultCellStyle = dataGridViewCellStyle8;
            this.xTransExterior.HeaderText = "Trans. al Exterior(*)";
            this.xTransExterior.MaxInputLength = 1;
            this.xTransExterior.MinimumWidth = 80;
            this.xTransExterior.Name = "xTransExterior";
            this.xTransExterior.Width = 80;
            // 
            // frmBancoScotiaBank
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1184, 461);
            this.Colores = new System.Drawing.Color[0];
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtcuentapago);
            this.Controls.Add(this.btnaceptar);
            this.Controls.Add(this.btncancelar);
            this.Controls.Add(this.dtgconten);
            this.Controls.Add(this.ptb);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinimumSize = new System.Drawing.Size(1200, 500);
            this.Name = "frmBancoScotiaBank";
            this.Nombre = "TeleBanking Pago Proveedores ScotiaBank";
            this.Text = "TeleBanking Pago Proveedores ScotiaBank";
            this.Load += new System.EventHandler(this.frmBancoScotiaBank_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ptb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgconten)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox ptb;
        private HpResergerUserControls.Dtgconten dtgconten;
        private System.Windows.Forms.Button btnaceptar;
        private System.Windows.Forms.Button btncancelar;
        public System.Windows.Forms.TextBox txtcuentapago;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.SaveFileDialog SaveFile;
        private System.Windows.Forms.DataGridViewTextBoxColumn xRuc;
        private System.Windows.Forms.DataGridViewTextBoxColumn xRazonSocial;
        private System.Windows.Forms.DataGridViewTextBoxColumn xNroFactura;
        private System.Windows.Forms.DataGridViewTextBoxColumn xFechaFactura;
        private System.Windows.Forms.DataGridViewTextBoxColumn xMontoPagar;
        private System.Windows.Forms.DataGridViewComboBoxColumn xFormaPago;
        private System.Windows.Forms.DataGridViewTextBoxColumn xCodigoOficina;
        private System.Windows.Forms.DataGridViewTextBoxColumn xCodigoCuenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn xSimplePay;
        private System.Windows.Forms.DataGridViewTextBoxColumn xEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn xcci;
        private System.Windows.Forms.DataGridViewTextBoxColumn xFactoring;
        private System.Windows.Forms.DataGridViewTextBoxColumn xFechaVencimiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn xTransExterior;
    }
}