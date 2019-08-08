namespace HPReserger
{
    partial class frmDetallePagoFactura
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDetallePagoFactura));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dtgconten1 = new HpResergerUserControls.Dtgconten();
            this.btncancelar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtproveedor = new System.Windows.Forms.TextBox();
            this.nrofacturadetx = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nrofacturax = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NroOPBanco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.proveedorx = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.razonsocialx = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subtotalx = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.igvx = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalx = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Entidad_Financiera = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CtaBanco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaPago = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xcuo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usuariox = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Banco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xfkempresa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xidcomprobante = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtgconten1)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgconten1
            // 
            this.dtgconten1.AllowUserToAddRows = false;
            this.dtgconten1.AllowUserToOrderColumns = true;
            this.dtgconten1.AllowUserToResizeColumns = false;
            this.dtgconten1.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(230)))), ((int)(((byte)(241)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(191)))), ((int)(((byte)(231)))));
            this.dtgconten1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgconten1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgconten1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgconten1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(218)))), ((int)(((byte)(231)))));
            this.dtgconten1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgconten1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.dtgconten1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(129)))), ((int)(((byte)(189)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DeepSkyBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgconten1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dtgconten1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dtgconten1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nrofacturadetx,
            this.nrofacturax,
            this.NroOPBanco,
            this.proveedorx,
            this.razonsocialx,
            this.subtotalx,
            this.igvx,
            this.totalx,
            this.Entidad_Financiera,
            this.CtaBanco,
            this.FechaPago,
            this.xcuo,
            this.usuariox,
            this.fecha,
            this.Banco,
            this.xfkempresa,
            this.xidcomprobante});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(207)))), ((int)(((byte)(241)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgconten1.DefaultCellStyle = dataGridViewCellStyle6;
            this.dtgconten1.EnableHeadersVisualStyles = false;
            this.dtgconten1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(179)))), ((int)(((byte)(215)))));
            this.dtgconten1.Location = new System.Drawing.Point(12, 39);
            this.dtgconten1.Name = "dtgconten1";
            this.dtgconten1.ReadOnly = true;
            this.dtgconten1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dtgconten1.RowHeadersVisible = false;
            this.dtgconten1.RowTemplate.Height = 18;
            this.dtgconten1.Size = new System.Drawing.Size(913, 245);
            this.dtgconten1.TabIndex = 0;
            // 
            // btncancelar
            // 
            this.btncancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btncancelar.Image = ((System.Drawing.Image)(resources.GetObject("btncancelar.Image")));
            this.btncancelar.Location = new System.Drawing.Point(850, 290);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(75, 23);
            this.btncancelar.TabIndex = 35;
            this.btncancelar.Text = "Cancelar";
            this.btncancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btncancelar.UseVisualStyleBackColor = true;
            this.btncancelar.Click += new System.EventHandler(this.btncancelar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(12, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 37;
            this.label2.Text = "Proveedor:";
            // 
            // txtproveedor
            // 
            this.txtproveedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(218)))), ((int)(((byte)(231)))));
            this.txtproveedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtproveedor.Location = new System.Drawing.Point(77, 13);
            this.txtproveedor.Name = "txtproveedor";
            this.txtproveedor.ReadOnly = true;
            this.txtproveedor.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtproveedor.Size = new System.Drawing.Size(213, 21);
            this.txtproveedor.TabIndex = 39;
            // 
            // nrofacturadetx
            // 
            this.nrofacturadetx.DataPropertyName = "nrofacturadet";
            this.nrofacturadetx.HeaderText = "nrofacturadet";
            this.nrofacturadetx.Name = "nrofacturadetx";
            this.nrofacturadetx.ReadOnly = true;
            this.nrofacturadetx.Visible = false;
            // 
            // nrofacturax
            // 
            this.nrofacturax.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.nrofacturax.DataPropertyName = "nrofactura";
            this.nrofacturax.HeaderText = "Nro Factura";
            this.nrofacturax.MinimumWidth = 100;
            this.nrofacturax.Name = "nrofacturax";
            this.nrofacturax.ReadOnly = true;
            // 
            // NroOPBanco
            // 
            this.NroOPBanco.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.NroOPBanco.DataPropertyName = "NroOPBanco";
            this.NroOPBanco.HeaderText = "NroOPBanco";
            this.NroOPBanco.MinimumWidth = 70;
            this.NroOPBanco.Name = "NroOPBanco";
            this.NroOPBanco.ReadOnly = true;
            this.NroOPBanco.Width = 97;
            // 
            // proveedorx
            // 
            this.proveedorx.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.proveedorx.DataPropertyName = "proveedor";
            this.proveedorx.HeaderText = "Proveedor";
            this.proveedorx.MinimumWidth = 60;
            this.proveedorx.Name = "proveedorx";
            this.proveedorx.ReadOnly = true;
            this.proveedorx.Width = 83;
            // 
            // razonsocialx
            // 
            this.razonsocialx.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.razonsocialx.DataPropertyName = "razon_social";
            this.razonsocialx.HeaderText = "Razon Social";
            this.razonsocialx.MinimumWidth = 100;
            this.razonsocialx.Name = "razonsocialx";
            this.razonsocialx.ReadOnly = true;
            // 
            // subtotalx
            // 
            this.subtotalx.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.subtotalx.DataPropertyName = "subtotal";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.Format = "n2";
            this.subtotalx.DefaultCellStyle = dataGridViewCellStyle3;
            this.subtotalx.HeaderText = "Subtotal";
            this.subtotalx.MinimumWidth = 60;
            this.subtotalx.Name = "subtotalx";
            this.subtotalx.ReadOnly = true;
            this.subtotalx.Width = 75;
            // 
            // igvx
            // 
            this.igvx.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.igvx.DataPropertyName = "igv";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle4.Format = "n2";
            this.igvx.DefaultCellStyle = dataGridViewCellStyle4;
            this.igvx.HeaderText = "Igv";
            this.igvx.MinimumWidth = 60;
            this.igvx.Name = "igvx";
            this.igvx.ReadOnly = true;
            this.igvx.Width = 60;
            // 
            // totalx
            // 
            this.totalx.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.totalx.DataPropertyName = "total";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle5.Format = "n2";
            this.totalx.DefaultCellStyle = dataGridViewCellStyle5;
            this.totalx.HeaderText = "Total";
            this.totalx.MinimumWidth = 60;
            this.totalx.Name = "totalx";
            this.totalx.ReadOnly = true;
            this.totalx.Width = 60;
            // 
            // Entidad_Financiera
            // 
            this.Entidad_Financiera.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Entidad_Financiera.DataPropertyName = "Entidad_Financiera";
            this.Entidad_Financiera.HeaderText = "Banco";
            this.Entidad_Financiera.MinimumWidth = 70;
            this.Entidad_Financiera.Name = "Entidad_Financiera";
            this.Entidad_Financiera.ReadOnly = true;
            this.Entidad_Financiera.Width = 70;
            // 
            // CtaBanco
            // 
            this.CtaBanco.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.CtaBanco.DataPropertyName = "CtaBanco";
            this.CtaBanco.HeaderText = "CtaBanco";
            this.CtaBanco.MinimumWidth = 60;
            this.CtaBanco.Name = "CtaBanco";
            this.CtaBanco.ReadOnly = true;
            this.CtaBanco.Width = 80;
            // 
            // FechaPago
            // 
            this.FechaPago.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.FechaPago.DataPropertyName = "FechaPago";
            this.FechaPago.HeaderText = "FechaPago";
            this.FechaPago.MinimumWidth = 60;
            this.FechaPago.Name = "FechaPago";
            this.FechaPago.ReadOnly = true;
            this.FechaPago.Width = 87;
            // 
            // xcuo
            // 
            this.xcuo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.xcuo.DataPropertyName = "cuo";
            this.xcuo.HeaderText = "Cuo";
            this.xcuo.MinimumWidth = 60;
            this.xcuo.Name = "xcuo";
            this.xcuo.ReadOnly = true;
            this.xcuo.Width = 60;
            // 
            // usuariox
            // 
            this.usuariox.DataPropertyName = "usuario";
            this.usuariox.HeaderText = "usuario";
            this.usuariox.Name = "usuariox";
            this.usuariox.ReadOnly = true;
            this.usuariox.Visible = false;
            // 
            // fecha
            // 
            this.fecha.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.fecha.DataPropertyName = "fechamodifica";
            this.fecha.HeaderText = "Fecha";
            this.fecha.MinimumWidth = 80;
            this.fecha.Name = "fecha";
            this.fecha.ReadOnly = true;
            this.fecha.Visible = false;
            this.fecha.Width = 80;
            // 
            // Banco
            // 
            this.Banco.DataPropertyName = "Banco";
            this.Banco.HeaderText = "Banco";
            this.Banco.Name = "Banco";
            this.Banco.ReadOnly = true;
            this.Banco.Visible = false;
            // 
            // xfkempresa
            // 
            this.xfkempresa.DataPropertyName = "fkempresa";
            this.xfkempresa.HeaderText = "Fkempresa";
            this.xfkempresa.Name = "xfkempresa";
            this.xfkempresa.ReadOnly = true;
            this.xfkempresa.Visible = false;
            // 
            // xidcomprobante
            // 
            this.xidcomprobante.DataPropertyName = "id_comprobante";
            this.xidcomprobante.HeaderText = "idcomprobante";
            this.xidcomprobante.Name = "xidcomprobante";
            this.xidcomprobante.ReadOnly = true;
            this.xidcomprobante.Visible = false;
            // 
            // frmDetallePagoFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(937, 319);
            this.Controls.Add(this.txtproveedor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btncancelar);
            this.Controls.Add(this.dtgconten1);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinimumSize = new System.Drawing.Size(953, 358);
            this.Name = "frmDetallePagoFactura";
            this.Nombre = "Detalle de Abono de Facturas";
            this.Text = "Detalle de Abono de Facturas";
            this.Load += new System.EventHandler(this.frmDetallePagoFactura_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgconten1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private HpResergerUserControls.Dtgconten dtgconten1;
        private System.Windows.Forms.Button btncancelar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtproveedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn nrofacturadetx;
        private System.Windows.Forms.DataGridViewTextBoxColumn nrofacturax;
        private System.Windows.Forms.DataGridViewTextBoxColumn NroOPBanco;
        private System.Windows.Forms.DataGridViewTextBoxColumn proveedorx;
        private System.Windows.Forms.DataGridViewTextBoxColumn razonsocialx;
        private System.Windows.Forms.DataGridViewTextBoxColumn subtotalx;
        private System.Windows.Forms.DataGridViewTextBoxColumn igvx;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalx;
        private System.Windows.Forms.DataGridViewTextBoxColumn Entidad_Financiera;
        private System.Windows.Forms.DataGridViewTextBoxColumn CtaBanco;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaPago;
        private System.Windows.Forms.DataGridViewTextBoxColumn xcuo;
        private System.Windows.Forms.DataGridViewTextBoxColumn usuariox;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn Banco;
        private System.Windows.Forms.DataGridViewTextBoxColumn xfkempresa;
        private System.Windows.Forms.DataGridViewTextBoxColumn xidcomprobante;
    }
}