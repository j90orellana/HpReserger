namespace HPReserger.ModuloCompensaciones
{
    partial class frmReembolsoGastosDetalleFact
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Dtgconten = new HpResergerUserControls.Dtgconten();
            this.BtnCerrar = new HpResergerUserControls.ButtonPer();
            this.lbltotalregistros = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.xIdComprobante = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xProveedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xrazon_social = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xNroComprobante = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xFechaEmision = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xTCReg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xMontoME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xGlosa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.Dtgconten)).BeginInit();
            this.SuspendLayout();
            // 
            // Dtgconten
            // 
            this.Dtgconten.AllowUserToAddRows = false;
            this.Dtgconten.AllowUserToDeleteRows = false;
            this.Dtgconten.AllowUserToResizeColumns = false;
            this.Dtgconten.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(230)))), ((int)(((byte)(241)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(191)))), ((int)(((byte)(231)))));
            this.Dtgconten.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.Dtgconten.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Dtgconten.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Dtgconten.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(218)))), ((int)(((byte)(231)))));
            this.Dtgconten.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Dtgconten.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.Dtgconten.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(129)))), ((int)(((byte)(189)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DeepSkyBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Dtgconten.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.Dtgconten.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dtgconten.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.xIdComprobante,
            this.xProveedor,
            this.xrazon_social,
            this.xNroComprobante,
            this.xFechaEmision,
            this.xTCReg,
            this.xTotal,
            this.xMontoME,
            this.xGlosa});
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(207)))), ((int)(((byte)(241)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Dtgconten.DefaultCellStyle = dataGridViewCellStyle7;
            this.Dtgconten.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.Dtgconten.EnableHeadersVisualStyles = false;
            this.Dtgconten.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(179)))), ((int)(((byte)(215)))));
            this.Dtgconten.Location = new System.Drawing.Point(12, 25);
            this.Dtgconten.Name = "Dtgconten";
            this.Dtgconten.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Dtgconten.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.Dtgconten.RowHeadersVisible = false;
            this.Dtgconten.RowTemplate.Height = 18;
            this.Dtgconten.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.Dtgconten.ShowRowErrors = false;
            this.Dtgconten.Size = new System.Drawing.Size(795, 237);
            this.Dtgconten.TabIndex = 17;
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
            this.BtnCerrar.Location = new System.Drawing.Point(724, 268);
            this.BtnCerrar.Name = "BtnCerrar";
            this.BtnCerrar.Size = new System.Drawing.Size(83, 23);
            this.BtnCerrar.TabIndex = 18;
            this.BtnCerrar.Text = "Cancelar";
            this.BtnCerrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnCerrar.UseVisualStyleBackColor = false;
            this.BtnCerrar.Click += new System.EventHandler(this.BtnCerrar_Click);
            // 
            // lbltotalregistros
            // 
            this.lbltotalregistros.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbltotalregistros.AutoEllipsis = true;
            this.lbltotalregistros.AutoSize = true;
            this.lbltotalregistros.BackColor = System.Drawing.Color.Transparent;
            this.lbltotalregistros.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltotalregistros.Location = new System.Drawing.Point(12, 273);
            this.lbltotalregistros.Name = "lbltotalregistros";
            this.lbltotalregistros.Size = new System.Drawing.Size(104, 13);
            this.lbltotalregistros.TabIndex = 26;
            this.lbltotalregistros.Text = "Total de Registros: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(269, 13);
            this.label2.TabIndex = 35;
            this.label2.Text = "Detalle de las Facturas Relacionadas al Reembolso:";
            // 
            // xIdComprobante
            // 
            this.xIdComprobante.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.xIdComprobante.DataPropertyName = "NameComprobante";
            this.xIdComprobante.HeaderText = "TD";
            this.xIdComprobante.MinimumWidth = 40;
            this.xIdComprobante.Name = "xIdComprobante";
            this.xIdComprobante.ReadOnly = true;
            this.xIdComprobante.Width = 40;
            // 
            // xProveedor
            // 
            this.xProveedor.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.xProveedor.DataPropertyName = "Proveedor";
            this.xProveedor.HeaderText = "Proveedor";
            this.xProveedor.Name = "xProveedor";
            this.xProveedor.ReadOnly = true;
            this.xProveedor.Width = 83;
            // 
            // xrazon_social
            // 
            this.xrazon_social.DataPropertyName = "razon";
            this.xrazon_social.HeaderText = "Razon Social";
            this.xrazon_social.MinimumWidth = 100;
            this.xrazon_social.Name = "xrazon_social";
            this.xrazon_social.ReadOnly = true;
            // 
            // xNroComprobante
            // 
            this.xNroComprobante.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.xNroComprobante.DataPropertyName = "NroComprobante";
            this.xNroComprobante.HeaderText = "Nro. Doc.";
            this.xNroComprobante.Name = "xNroComprobante";
            this.xNroComprobante.ReadOnly = true;
            this.xNroComprobante.Width = 79;
            // 
            // xFechaEmision
            // 
            this.xFechaEmision.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.xFechaEmision.DataPropertyName = "FechaEmision";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.Format = "dd/MM/yyyy";
            this.xFechaEmision.DefaultCellStyle = dataGridViewCellStyle3;
            this.xFechaEmision.HeaderText = "Fec.Emis.";
            this.xFechaEmision.MinimumWidth = 65;
            this.xFechaEmision.Name = "xFechaEmision";
            this.xFechaEmision.ReadOnly = true;
            this.xFechaEmision.Width = 65;
            // 
            // xTCReg
            // 
            this.xTCReg.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.xTCReg.DataPropertyName = "TCReg";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle4.Format = "n3";
            this.xTCReg.DefaultCellStyle = dataGridViewCellStyle4;
            this.xTCReg.HeaderText = "TC Reg";
            this.xTCReg.MinimumWidth = 40;
            this.xTCReg.Name = "xTCReg";
            this.xTCReg.ReadOnly = true;
            this.xTCReg.Width = 40;
            // 
            // xTotal
            // 
            this.xTotal.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.xTotal.DataPropertyName = "MontoMN";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle5.Format = "n2";
            this.xTotal.DefaultCellStyle = dataGridViewCellStyle5;
            this.xTotal.HeaderText = "Monto MN";
            this.xTotal.MinimumWidth = 70;
            this.xTotal.Name = "xTotal";
            this.xTotal.ReadOnly = true;
            this.xTotal.Width = 70;
            // 
            // xMontoME
            // 
            this.xMontoME.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.xMontoME.DataPropertyName = "MontoME";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle6.Format = "n2";
            this.xMontoME.DefaultCellStyle = dataGridViewCellStyle6;
            this.xMontoME.HeaderText = "Monto ME";
            this.xMontoME.MinimumWidth = 70;
            this.xMontoME.Name = "xMontoME";
            this.xMontoME.ReadOnly = true;
            this.xMontoME.Width = 70;
            // 
            // xGlosa
            // 
            this.xGlosa.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.xGlosa.DataPropertyName = "Glosa";
            this.xGlosa.HeaderText = "Glosa";
            this.xGlosa.MinimumWidth = 100;
            this.xGlosa.Name = "xGlosa";
            this.xGlosa.ReadOnly = true;
            // 
            // frmReembolsoGastosDetalleFact
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(819, 298);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbltotalregistros);
            this.Controls.Add(this.BtnCerrar);
            this.Controls.Add(this.Dtgconten);
            this.Name = "frmReembolsoGastosDetalleFact";
            this.Nombre = "Detalle de las Facturas Relacionadas al Reembolso";
            this.Text = "Detalle de las Facturas Relacionadas al Reembolso";
            this.Load += new System.EventHandler(this.frmReembolsoGastosDetalleFact_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Dtgconten)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private HpResergerUserControls.Dtgconten Dtgconten;
        private HpResergerUserControls.ButtonPer BtnCerrar;
        private System.Windows.Forms.Label lbltotalregistros;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn xIdComprobante;
        private System.Windows.Forms.DataGridViewTextBoxColumn xProveedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn xrazon_social;
        private System.Windows.Forms.DataGridViewTextBoxColumn xNroComprobante;
        private System.Windows.Forms.DataGridViewTextBoxColumn xFechaEmision;
        private System.Windows.Forms.DataGridViewTextBoxColumn xTCReg;
        private System.Windows.Forms.DataGridViewTextBoxColumn xTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn xMontoME;
        private System.Windows.Forms.DataGridViewTextBoxColumn xGlosa;
    }
}