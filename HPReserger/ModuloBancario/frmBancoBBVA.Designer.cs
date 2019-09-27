namespace HPReserger.ModuloBancario
{
    partial class frmBancoBBVA
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBancoBBVA));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            this.ptb = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnaceptar = new System.Windows.Forms.Button();
            this.btncancelar = new System.Windows.Forms.Button();
            this.dtgconten = new HpResergerUserControls.Dtgconten();
            this.xDoi = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.xDoiNumero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xTipoAbono = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.xCuentaAbonar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xNombreBeneficiario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xImporteAbonar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xTipoRecibo = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.xNroDocumento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xAbono = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.xReferencia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xIndicadorAviso = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.xMedioAviso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xPersonaContacto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ptb)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgconten)).BeginInit();
            this.SuspendLayout();
            // 
            // ptb
            // 
            this.ptb.BackColor = System.Drawing.Color.White;
            this.ptb.Image = ((System.Drawing.Image)(resources.GetObject("ptb.Image")));
            this.ptb.Location = new System.Drawing.Point(12, -12);
            this.ptb.Name = "ptb";
            this.ptb.Size = new System.Drawing.Size(457, 80);
            this.ptb.TabIndex = 65;
            this.ptb.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(33)))), ((int)(((byte)(70)))));
            this.panel1.Controls.Add(this.ptb);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1184, 71);
            this.panel1.TabIndex = 66;
            // 
            // btnaceptar
            // 
            this.btnaceptar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnaceptar.BackColor = System.Drawing.Color.White;
            this.btnaceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnaceptar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(100)))), ((int)(((byte)(165)))));
            this.btnaceptar.Location = new System.Drawing.Point(1016, 427);
            this.btnaceptar.Name = "btnaceptar";
            this.btnaceptar.Size = new System.Drawing.Size(75, 23);
            this.btnaceptar.TabIndex = 87;
            this.btnaceptar.Text = "Generar";
            this.btnaceptar.UseVisualStyleBackColor = false;
            // 
            // btncancelar
            // 
            this.btncancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btncancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(33)))), ((int)(((byte)(70)))));
            this.btncancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btncancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncancelar.ForeColor = System.Drawing.Color.White;
            this.btncancelar.Location = new System.Drawing.Point(1097, 427);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(75, 23);
            this.btncancelar.TabIndex = 88;
            this.btncancelar.Text = "Cancelar";
            this.btncancelar.UseVisualStyleBackColor = false;
            // 
            // dtgconten
            // 
            this.dtgconten.AllowUserToAddRows = false;
            this.dtgconten.AllowUserToResizeColumns = false;
            this.dtgconten.AllowUserToResizeRows = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(192)))), ((int)(((byte)(213)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(213)))), ((int)(((byte)(227)))));
            this.dtgconten.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dtgconten.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgconten.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgconten.BackgroundColor = System.Drawing.Color.White;
            this.dtgconten.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgconten.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.dtgconten.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(50)))), ((int)(((byte)(99)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(100)))), ((int)(((byte)(165)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgconten.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dtgconten.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgconten.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.xDoi,
            this.xDoiNumero,
            this.xTipoAbono,
            this.xCuentaAbonar,
            this.xNombreBeneficiario,
            this.xImporteAbonar,
            this.xTipoRecibo,
            this.xNroDocumento,
            this.xAbono,
            this.xReferencia,
            this.xIndicadorAviso,
            this.xMedioAviso,
            this.xPersonaContacto});
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(207)))), ((int)(((byte)(241)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgconten.DefaultCellStyle = dataGridViewCellStyle8;
            this.dtgconten.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dtgconten.EnableHeadersVisualStyles = false;
            this.dtgconten.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(100)))), ((int)(((byte)(165)))));
            this.dtgconten.Location = new System.Drawing.Point(12, 79);
            this.dtgconten.Name = "dtgconten";
            this.dtgconten.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dtgconten.RowHeadersVisible = false;
            this.dtgconten.RowTemplate.Height = 18;
            this.dtgconten.Size = new System.Drawing.Size(1160, 342);
            this.dtgconten.TabIndex = 86;
            // 
            // xDoi
            // 
            this.xDoi.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.xDoi.HeaderText = "DOI Tipo";
            this.xDoi.MinimumWidth = 54;
            this.xDoi.Name = "xDoi";
            this.xDoi.Width = 54;
            // 
            // xDoiNumero
            // 
            this.xDoiNumero.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.xDoiNumero.HeaderText = "Doi Numero";
            this.xDoiNumero.MaxInputLength = 11;
            this.xDoiNumero.MinimumWidth = 70;
            this.xDoiNumero.Name = "xDoiNumero";
            this.xDoiNumero.Width = 70;
            // 
            // xTipoAbono
            // 
            this.xTipoAbono.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.xTipoAbono.HeaderText = "TipoAbono";
            this.xTipoAbono.MinimumWidth = 60;
            this.xTipoAbono.Name = "xTipoAbono";
            this.xTipoAbono.Width = 60;
            // 
            // xCuentaAbonar
            // 
            this.xCuentaAbonar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.xCuentaAbonar.HeaderText = "Nro Cuentas Abonar";
            this.xCuentaAbonar.MaxInputLength = 19;
            this.xCuentaAbonar.MinimumWidth = 80;
            this.xCuentaAbonar.Name = "xCuentaAbonar";
            this.xCuentaAbonar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.xCuentaAbonar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.xCuentaAbonar.Width = 80;
            // 
            // xNombreBeneficiario
            // 
            this.xNombreBeneficiario.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.xNombreBeneficiario.HeaderText = "Nombre Beneficiario";
            this.xNombreBeneficiario.MaxInputLength = 39;
            this.xNombreBeneficiario.MinimumWidth = 100;
            this.xNombreBeneficiario.Name = "xNombreBeneficiario";
            // 
            // xImporteAbonar
            // 
            this.xImporteAbonar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle7.Format = "n2";
            this.xImporteAbonar.DefaultCellStyle = dataGridViewCellStyle7;
            this.xImporteAbonar.HeaderText = "Importe Abonar";
            this.xImporteAbonar.MaxInputLength = 14;
            this.xImporteAbonar.MinimumWidth = 70;
            this.xImporteAbonar.Name = "xImporteAbonar";
            this.xImporteAbonar.Width = 70;
            // 
            // xTipoRecibo
            // 
            this.xTipoRecibo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.xTipoRecibo.HeaderText = "Tipo Recibo";
            this.xTipoRecibo.MinimumWidth = 70;
            this.xTipoRecibo.Name = "xTipoRecibo";
            this.xTipoRecibo.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.xTipoRecibo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.xTipoRecibo.Width = 70;
            // 
            // xNroDocumento
            // 
            this.xNroDocumento.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.xNroDocumento.HeaderText = "Nro Documento";
            this.xNroDocumento.MaxInputLength = 11;
            this.xNroDocumento.MinimumWidth = 80;
            this.xNroDocumento.Name = "xNroDocumento";
            this.xNroDocumento.Width = 80;
            // 
            // xAbono
            // 
            this.xAbono.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.xAbono.HeaderText = "Abono Agrupado";
            this.xAbono.MinimumWidth = 70;
            this.xAbono.Name = "xAbono";
            this.xAbono.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.xAbono.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.xAbono.Width = 70;
            // 
            // xReferencia
            // 
            this.xReferencia.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.xReferencia.HeaderText = "Referencia";
            this.xReferencia.MaxInputLength = 42;
            this.xReferencia.MinimumWidth = 75;
            this.xReferencia.Name = "xReferencia";
            this.xReferencia.Width = 75;
            // 
            // xIndicadorAviso
            // 
            this.xIndicadorAviso.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.xIndicadorAviso.HeaderText = "Indicador Aviso";
            this.xIndicadorAviso.MinimumWidth = 75;
            this.xIndicadorAviso.Name = "xIndicadorAviso";
            this.xIndicadorAviso.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.xIndicadorAviso.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.xIndicadorAviso.Width = 75;
            // 
            // xMedioAviso
            // 
            this.xMedioAviso.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.xMedioAviso.HeaderText = "Medio Aviso";
            this.xMedioAviso.MaxInputLength = 49;
            this.xMedioAviso.MinimumWidth = 75;
            this.xMedioAviso.Name = "xMedioAviso";
            this.xMedioAviso.Width = 75;
            // 
            // xPersonaContacto
            // 
            this.xPersonaContacto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.xPersonaContacto.HeaderText = "Persona Contacto";
            this.xPersonaContacto.MaxInputLength = 29;
            this.xPersonaContacto.MinimumWidth = 70;
            this.xPersonaContacto.Name = "xPersonaContacto";
            this.xPersonaContacto.Width = 70;
            // 
            // frmBancoBBVA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1184, 461);
            this.Colores = new System.Drawing.Color[0];
            this.Controls.Add(this.btnaceptar);
            this.Controls.Add(this.btncancelar);
            this.Controls.Add(this.dtgconten);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinimumSize = new System.Drawing.Size(1200, 500);
            this.Name = "frmBancoBBVA";
            this.Nombre = "TeleBanking Pago Proveedores BBVA";
            this.Text = "TeleBanking Pago Proveedores BBVA";
            this.Load += new System.EventHandler(this.frmBancoBBVA_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ptb)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgconten)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox ptb;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnaceptar;
        private System.Windows.Forms.Button btncancelar;
        private HpResergerUserControls.Dtgconten dtgconten;
        private System.Windows.Forms.DataGridViewComboBoxColumn xDoi;
        private System.Windows.Forms.DataGridViewTextBoxColumn xDoiNumero;
        private System.Windows.Forms.DataGridViewComboBoxColumn xTipoAbono;
        private System.Windows.Forms.DataGridViewTextBoxColumn xCuentaAbonar;
        private System.Windows.Forms.DataGridViewTextBoxColumn xNombreBeneficiario;
        private System.Windows.Forms.DataGridViewTextBoxColumn xImporteAbonar;
        private System.Windows.Forms.DataGridViewComboBoxColumn xTipoRecibo;
        private System.Windows.Forms.DataGridViewTextBoxColumn xNroDocumento;
        private System.Windows.Forms.DataGridViewComboBoxColumn xAbono;
        private System.Windows.Forms.DataGridViewTextBoxColumn xReferencia;
        private System.Windows.Forms.DataGridViewComboBoxColumn xIndicadorAviso;
        private System.Windows.Forms.DataGridViewTextBoxColumn xMedioAviso;
        private System.Windows.Forms.DataGridViewTextBoxColumn xPersonaContacto;
    }
}