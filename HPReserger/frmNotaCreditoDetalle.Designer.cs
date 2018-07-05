namespace HPReserger
{
    partial class frmNotaCreditoDetalle
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNotaCreditoDetalle));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dtgconten = new HpResergerUserControls.Dtgconten();
            this.btnaceptar = new System.Windows.Forms.Button();
            this.btncancelar = new System.Windows.Forms.Button();
            this.eliminarx = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.codcomprax = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipox = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idarticulox = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcionx = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idmarcax = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.marcax = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idmodelox = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modelox = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidadx = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioUnitarioRegistradox = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Preciounitariomodificado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalx = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtgconten)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgconten
            // 
            this.dtgconten.AllowUserToAddRows = false;
            this.dtgconten.AllowUserToOrderColumns = true;
            this.dtgconten.AllowUserToResizeColumns = false;
            this.dtgconten.AllowUserToResizeRows = false;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(230)))), ((int)(((byte)(241)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(191)))), ((int)(((byte)(231)))));
            this.dtgconten.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle9;
            this.dtgconten.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgconten.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgconten.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(218)))), ((int)(((byte)(231)))));
            this.dtgconten.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgconten.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.dtgconten.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(129)))), ((int)(((byte)(189)))));
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.DeepSkyBlue;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgconten.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.dtgconten.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgconten.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.eliminarx,
            this.codcomprax,
            this.tipox,
            this.idarticulox,
            this.descripcionx,
            this.idmarcax,
            this.marcax,
            this.idmodelox,
            this.modelox,
            this.cantidadx,
            this.PrecioUnitarioRegistradox,
            this.Preciounitariomodificado,
            this.totalx});
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle16.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle16.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(207)))), ((int)(((byte)(241)))));
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgconten.DefaultCellStyle = dataGridViewCellStyle16;
            this.dtgconten.EnableHeadersVisualStyles = false;
            this.dtgconten.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(179)))), ((int)(((byte)(215)))));
            this.dtgconten.Location = new System.Drawing.Point(12, 12);
            this.dtgconten.Name = "dtgconten";
            this.dtgconten.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dtgconten.RowHeadersVisible = false;
            this.dtgconten.RowTemplate.Height = 18;
            this.dtgconten.Size = new System.Drawing.Size(942, 493);
            this.dtgconten.TabIndex = 0;
            this.dtgconten.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgconten_CellContentClick);
            this.dtgconten.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgconten_CellEndEdit);
            this.dtgconten.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dtgconten_CellFormatting);
            this.dtgconten.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dtgconten_EditingControlShowing);
            // 
            // btnaceptar
            // 
            this.btnaceptar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnaceptar.Enabled = false;
            this.btnaceptar.Image = ((System.Drawing.Image)(resources.GetObject("btnaceptar.Image")));
            this.btnaceptar.Location = new System.Drawing.Point(317, 511);
            this.btnaceptar.Name = "btnaceptar";
            this.btnaceptar.Size = new System.Drawing.Size(75, 23);
            this.btnaceptar.TabIndex = 38;
            this.btnaceptar.Text = "Guardar";
            this.btnaceptar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnaceptar.UseVisualStyleBackColor = true;
            this.btnaceptar.Visible = false;
            // 
            // btncancelar
            // 
            this.btncancelar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btncancelar.Image = ((System.Drawing.Image)(resources.GetObject("btncancelar.Image")));
            this.btncancelar.Location = new System.Drawing.Point(446, 511);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(75, 23);
            this.btncancelar.TabIndex = 39;
            this.btncancelar.Text = "Aceptar";
            this.btncancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btncancelar.UseVisualStyleBackColor = true;
            this.btncancelar.Click += new System.EventHandler(this.btncancelar_Click);
            // 
            // eliminarx
            // 
            this.eliminarx.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.eliminarx.DataPropertyName = "eliminar";
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.eliminarx.DefaultCellStyle = dataGridViewCellStyle11;
            this.eliminarx.HeaderText = "Eliminar?";
            this.eliminarx.Name = "eliminarx";
            this.eliminarx.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.eliminarx.Width = 60;
            // 
            // codcomprax
            // 
            this.codcomprax.DataPropertyName = "codcompra";
            this.codcomprax.HeaderText = "codcompra";
            this.codcomprax.Name = "codcomprax";
            this.codcomprax.Visible = false;
            // 
            // tipox
            // 
            this.tipox.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.tipox.DataPropertyName = "tipo";
            this.tipox.HeaderText = "Tipo";
            this.tipox.MinimumWidth = 60;
            this.tipox.Name = "tipox";
            this.tipox.ReadOnly = true;
            this.tipox.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.tipox.Width = 60;
            // 
            // idarticulox
            // 
            this.idarticulox.DataPropertyName = "id_articulo";
            this.idarticulox.HeaderText = "idarticulo";
            this.idarticulox.Name = "idarticulox";
            this.idarticulox.Visible = false;
            // 
            // descripcionx
            // 
            this.descripcionx.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.descripcionx.DataPropertyName = "descripcion";
            this.descripcionx.HeaderText = "Descripción";
            this.descripcionx.Name = "descripcionx";
            this.descripcionx.ReadOnly = true;
            this.descripcionx.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // idmarcax
            // 
            this.idmarcax.DataPropertyName = "id_marca";
            this.idmarcax.HeaderText = "idmarca";
            this.idmarcax.Name = "idmarcax";
            this.idmarcax.Visible = false;
            // 
            // marcax
            // 
            this.marcax.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.marcax.DataPropertyName = "marca";
            this.marcax.HeaderText = "Marca";
            this.marcax.MinimumWidth = 60;
            this.marcax.Name = "marcax";
            this.marcax.ReadOnly = true;
            this.marcax.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.marcax.Width = 60;
            // 
            // idmodelox
            // 
            this.idmodelox.DataPropertyName = "id_modelo";
            this.idmodelox.HeaderText = "idmodelo";
            this.idmodelox.Name = "idmodelox";
            this.idmodelox.Visible = false;
            // 
            // modelox
            // 
            this.modelox.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.modelox.DataPropertyName = "modelo";
            this.modelox.HeaderText = "Modelo";
            this.modelox.MinimumWidth = 60;
            this.modelox.Name = "modelox";
            this.modelox.ReadOnly = true;
            this.modelox.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.modelox.Width = 60;
            // 
            // cantidadx
            // 
            this.cantidadx.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.cantidadx.DataPropertyName = "cantidad";
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.cantidadx.DefaultCellStyle = dataGridViewCellStyle12;
            this.cantidadx.HeaderText = "Cantidad";
            this.cantidadx.MinimumWidth = 60;
            this.cantidadx.Name = "cantidadx";
            this.cantidadx.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.cantidadx.Width = 60;
            // 
            // PrecioUnitarioRegistradox
            // 
            this.PrecioUnitarioRegistradox.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.PrecioUnitarioRegistradox.DataPropertyName = "subtotal";
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle13.Format = "n2";
            dataGridViewCellStyle13.NullValue = "0.00";
            this.PrecioUnitarioRegistradox.DefaultCellStyle = dataGridViewCellStyle13;
            this.PrecioUnitarioRegistradox.HeaderText = "PrecioUnitario Registrado";
            this.PrecioUnitarioRegistradox.MinimumWidth = 90;
            this.PrecioUnitarioRegistradox.Name = "PrecioUnitarioRegistradox";
            this.PrecioUnitarioRegistradox.ReadOnly = true;
            this.PrecioUnitarioRegistradox.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.PrecioUnitarioRegistradox.Width = 90;
            // 
            // Preciounitariomodificado
            // 
            this.Preciounitariomodificado.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.Preciounitariomodificado.DataPropertyName = "modificado";
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle14.Format = "n2";
            dataGridViewCellStyle14.NullValue = "0.00";
            this.Preciounitariomodificado.DefaultCellStyle = dataGridViewCellStyle14;
            this.Preciounitariomodificado.HeaderText = "PrecioUnitario Modificado";
            this.Preciounitariomodificado.MinimumWidth = 90;
            this.Preciounitariomodificado.Name = "Preciounitariomodificado";
            this.Preciounitariomodificado.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.Preciounitariomodificado.Width = 90;
            // 
            // totalx
            // 
            this.totalx.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.totalx.DataPropertyName = "total";
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle15.Format = "n2";
            dataGridViewCellStyle15.NullValue = "0.00";
            this.totalx.DefaultCellStyle = dataGridViewCellStyle15;
            this.totalx.HeaderText = "Total";
            this.totalx.MinimumWidth = 60;
            this.totalx.Name = "totalx";
            this.totalx.ReadOnly = true;
            this.totalx.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.totalx.Width = 60;
            // 
            // frmNotaCreditoDetalle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(966, 541);
            this.Colores = new System.Drawing.Color[0];
            this.Controls.Add(this.btnaceptar);
            this.Controls.Add(this.btncancelar);
            this.Controls.Add(this.dtgconten);
            this.MinimumSize = new System.Drawing.Size(982, 580);
            this.Name = "frmNotaCreditoDetalle";
            this.Nombre = "Detalle Nota de Crédito";
            this.Text = "Detalle Nota de Crédito";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmNotaCreditoDetalle_FormClosing);
            this.Load += new System.EventHandler(this.frmNotaCreditoDetalle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgconten)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private HpResergerUserControls.Dtgconten dtgconten;
        private System.Windows.Forms.Button btnaceptar;
        private System.Windows.Forms.Button btncancelar;
        private System.Windows.Forms.DataGridViewCheckBoxColumn eliminarx;
        private System.Windows.Forms.DataGridViewTextBoxColumn codcomprax;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipox;
        private System.Windows.Forms.DataGridViewTextBoxColumn idarticulox;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcionx;
        private System.Windows.Forms.DataGridViewTextBoxColumn idmarcax;
        private System.Windows.Forms.DataGridViewTextBoxColumn marcax;
        private System.Windows.Forms.DataGridViewTextBoxColumn idmodelox;
        private System.Windows.Forms.DataGridViewTextBoxColumn modelox;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidadx;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioUnitarioRegistradox;
        private System.Windows.Forms.DataGridViewTextBoxColumn Preciounitariomodificado;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalx;
    }
}