namespace HPReserger.ModuloContable
{
    partial class frmAsientosRelacionados
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dtgconten = new HpResergerUserControls.Dtgconten();
            this.xEmpresa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xnamecomprobante = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xnrofactura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xproveedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xfechapago = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xcuo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xglosa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xpkProyecto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label18 = new System.Windows.Forms.Label();
            this.BtnCerrar = new HpResergerUserControls.ButtonPer();
            this.btnTxt = new HpResergerUserControls.ButtonPer();
            this.lblmensaje = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgconten)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgconten
            // 
            this.dtgconten.AllowUserToAddRows = false;
            this.dtgconten.AllowUserToResizeColumns = false;
            this.dtgconten.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(230)))), ((int)(((byte)(241)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(191)))), ((int)(((byte)(231)))));
            this.dtgconten.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgconten.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgconten.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgconten.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(218)))), ((int)(((byte)(231)))));
            this.dtgconten.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgconten.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.dtgconten.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(129)))), ((int)(((byte)(189)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DeepSkyBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgconten.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dtgconten.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dtgconten.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.xEmpresa,
            this.xnamecomprobante,
            this.xnrofactura,
            this.xproveedor,
            this.xfechapago,
            this.xcuo,
            this.xglosa,
            this.xpkProyecto});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(207)))), ((int)(((byte)(241)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgconten.DefaultCellStyle = dataGridViewCellStyle4;
            this.dtgconten.EnableHeadersVisualStyles = false;
            this.dtgconten.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(179)))), ((int)(((byte)(215)))));
            this.dtgconten.Location = new System.Drawing.Point(12, 36);
            this.dtgconten.Name = "dtgconten";
            this.dtgconten.ReadOnly = true;
            this.dtgconten.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dtgconten.RowHeadersVisible = false;
            this.dtgconten.RowTemplate.Height = 18;
            this.dtgconten.Size = new System.Drawing.Size(860, 234);
            this.dtgconten.TabIndex = 0;
            // 
            // xEmpresa
            // 
            this.xEmpresa.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.xEmpresa.DataPropertyName = "empresa";
            this.xEmpresa.HeaderText = "Empresa";
            this.xEmpresa.MinimumWidth = 200;
            this.xEmpresa.Name = "xEmpresa";
            this.xEmpresa.ReadOnly = true;
            this.xEmpresa.Width = 200;
            // 
            // xnamecomprobante
            // 
            this.xnamecomprobante.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.xnamecomprobante.DataPropertyName = "namecomprobante";
            this.xnamecomprobante.HeaderText = "Tipo";
            this.xnamecomprobante.Name = "xnamecomprobante";
            this.xnamecomprobante.ReadOnly = true;
            this.xnamecomprobante.Width = 51;
            // 
            // xnrofactura
            // 
            this.xnrofactura.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.xnrofactura.DataPropertyName = "nrofactura";
            this.xnrofactura.HeaderText = "NroFactura";
            this.xnrofactura.Name = "xnrofactura";
            this.xnrofactura.ReadOnly = true;
            this.xnrofactura.Width = 85;
            // 
            // xproveedor
            // 
            this.xproveedor.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.xproveedor.DataPropertyName = "proveedor";
            this.xproveedor.HeaderText = "Proveedor";
            this.xproveedor.Name = "xproveedor";
            this.xproveedor.ReadOnly = true;
            this.xproveedor.Width = 81;
            // 
            // xfechapago
            // 
            this.xfechapago.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.xfechapago.DataPropertyName = "fechapago";
            dataGridViewCellStyle3.Format = "dd/MM/yyyy";
            this.xfechapago.DefaultCellStyle = dataGridViewCellStyle3;
            this.xfechapago.HeaderText = "FechaPago";
            this.xfechapago.Name = "xfechapago";
            this.xfechapago.ReadOnly = true;
            this.xfechapago.Width = 84;
            // 
            // xcuo
            // 
            this.xcuo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.xcuo.DataPropertyName = "cuo";
            this.xcuo.HeaderText = "Cuo";
            this.xcuo.Name = "xcuo";
            this.xcuo.ReadOnly = true;
            this.xcuo.Width = 50;
            // 
            // xglosa
            // 
            this.xglosa.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.xglosa.DataPropertyName = "glosa";
            this.xglosa.HeaderText = "Glosa";
            this.xglosa.Name = "xglosa";
            this.xglosa.ReadOnly = true;
            // 
            // xpkProyecto
            // 
            this.xpkProyecto.DataPropertyName = "pkProyecto";
            this.xpkProyecto.HeaderText = "pkProyecto";
            this.xpkProyecto.Name = "xpkProyecto";
            this.xpkProyecto.ReadOnly = true;
            this.xpkProyecto.Visible = false;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.BackColor = System.Drawing.Color.Transparent;
            this.label18.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(12, 20);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(287, 13);
            this.label18.TabIndex = 180;
            this.label18.Text = "Listado de Asientos Relacionados a pagos de Facturas";
            // 
            // BtnCerrar
            // 
            this.BtnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnCerrar.BackColor = System.Drawing.Color.Crimson;
            this.BtnCerrar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnCerrar.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.BtnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCerrar.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCerrar.ForeColor = System.Drawing.Color.White;
            this.BtnCerrar.Location = new System.Drawing.Point(789, 276);
            this.BtnCerrar.Name = "BtnCerrar";
            this.BtnCerrar.Size = new System.Drawing.Size(83, 23);
            this.BtnCerrar.TabIndex = 181;
            this.BtnCerrar.Text = "Cancelar";
            this.BtnCerrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnCerrar.UseVisualStyleBackColor = false;
            this.BtnCerrar.Click += new System.EventHandler(this.BtnCerrar_Click);
            // 
            // btnTxt
            // 
            this.btnTxt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTxt.BackColor = System.Drawing.Color.SeaGreen;
            this.btnTxt.FlatAppearance.BorderColor = System.Drawing.Color.Olive;
            this.btnTxt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTxt.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTxt.ForeColor = System.Drawing.Color.White;
            this.btnTxt.Location = new System.Drawing.Point(701, 276);
            this.btnTxt.Name = "btnTxt";
            this.btnTxt.Size = new System.Drawing.Size(83, 23);
            this.btnTxt.TabIndex = 182;
            this.btnTxt.Text = "Procesar";
            this.btnTxt.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTxt.UseVisualStyleBackColor = false;
            this.btnTxt.Visible = false;
            // 
            // lblmensaje
            // 
            this.lblmensaje.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblmensaje.AutoSize = true;
            this.lblmensaje.BackColor = System.Drawing.Color.Transparent;
            this.lblmensaje.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmensaje.Location = new System.Drawing.Point(9, 281);
            this.lblmensaje.Name = "lblmensaje";
            this.lblmensaje.Size = new System.Drawing.Size(85, 13);
            this.lblmensaje.TabIndex = 180;
            this.lblmensaje.Text = "Total Registros:";
            this.lblmensaje.Click += new System.EventHandler(this.label1_Click);
            // 
            // frmAsientosRelacionados
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(884, 311);
            this.Controls.Add(this.BtnCerrar);
            this.Controls.Add(this.btnTxt);
            this.Controls.Add(this.lblmensaje);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.dtgconten);
            this.MinimumSize = new System.Drawing.Size(900, 350);
            this.Name = "frmAsientosRelacionados";
            this.Nombre = "Asientos Relacionados";
            this.Text = "Asientos Relacionados";
            this.Load += new System.EventHandler(this.frmAsientosRelacionados_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgconten)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private HpResergerUserControls.Dtgconten dtgconten;
        private System.Windows.Forms.DataGridViewTextBoxColumn xEmpresa;
        private System.Windows.Forms.DataGridViewTextBoxColumn xnamecomprobante;
        private System.Windows.Forms.DataGridViewTextBoxColumn xnrofactura;
        private System.Windows.Forms.DataGridViewTextBoxColumn xproveedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn xfechapago;
        private System.Windows.Forms.DataGridViewTextBoxColumn xcuo;
        private System.Windows.Forms.DataGridViewTextBoxColumn xglosa;
        private System.Windows.Forms.DataGridViewTextBoxColumn xpkProyecto;
        private System.Windows.Forms.Label label18;
        private HpResergerUserControls.ButtonPer BtnCerrar;
        private HpResergerUserControls.ButtonPer btnTxt;
        private System.Windows.Forms.Label lblmensaje;
    }
}