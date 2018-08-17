using HpResergerUserControls;

namespace HPReserger
{
    partial class frmVerDetallePresuspuestoOperaciones
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVerDetallePresuspuestoOperaciones));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnexportarExcel = new System.Windows.Forms.Button();
            this.dtgcontenx = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.proyecto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cuentas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.debe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Haber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fechas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btncancelar = new System.Windows.Forms.Button();
            this.dtgconten = new Dtgconten();
            this.nrofactura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.proveedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OrdenCompra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Subtotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.impuesto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechafac = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtgcontenx)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgconten)).BeginInit();
            this.SuspendLayout();
            // 
            // btnexportarExcel
            // 
            this.btnexportarExcel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnexportarExcel.Image = ((System.Drawing.Image)(resources.GetObject("btnexportarExcel.Image")));
            this.btnexportarExcel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnexportarExcel.Location = new System.Drawing.Point(538, 11);
            this.btnexportarExcel.Name = "btnexportarExcel";
            this.btnexportarExcel.Size = new System.Drawing.Size(82, 24);
            this.btnexportarExcel.TabIndex = 102;
            this.btnexportarExcel.Text = "A Excel";
            this.btnexportarExcel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnexportarExcel.UseVisualStyleBackColor = true;
            this.btnexportarExcel.Click += new System.EventHandler(this.btnexportarExcel_Click);
            // 
            // dtgcontenx
            // 
            this.dtgcontenx.AllowUserToAddRows = false;
            this.dtgcontenx.AllowUserToDeleteRows = false;
            this.dtgcontenx.AllowUserToResizeColumns = false;
            this.dtgcontenx.AllowUserToResizeRows = false;
            this.dtgcontenx.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgcontenx.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgcontenx.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dtgcontenx.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dtgcontenx.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dtgcontenx.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgcontenx.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgcontenx.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgcontenx.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.proyecto,
            this.cuentas,
            this.debe,
            this.Haber,
            this.Fechas});
            this.dtgcontenx.Cursor = System.Windows.Forms.Cursors.Default;
            this.dtgcontenx.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnF2;
            this.dtgcontenx.Location = new System.Drawing.Point(-4, 322);
            this.dtgcontenx.MultiSelect = false;
            this.dtgcontenx.Name = "dtgcontenx";
            this.dtgcontenx.ReadOnly = true;
            this.dtgcontenx.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dtgcontenx.RowHeadersVisible = false;
            this.dtgcontenx.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dtgcontenx.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgcontenx.Size = new System.Drawing.Size(608, 246);
            this.dtgcontenx.TabIndex = 99;
            this.dtgcontenx.Visible = false;
            this.dtgcontenx.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgconten_RowEnter);
            // 
            // id
            // 
            this.id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "Asiento";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Width = 67;
            // 
            // proyecto
            // 
            this.proyecto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.proyecto.DataPropertyName = "proyecto";
            this.proyecto.HeaderText = "Proyecto";
            this.proyecto.Name = "proyecto";
            this.proyecto.ReadOnly = true;
            // 
            // cuentas
            // 
            this.cuentas.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.cuentas.DataPropertyName = "cuenta";
            this.cuentas.HeaderText = "Cuenta";
            this.cuentas.Name = "cuentas";
            this.cuentas.ReadOnly = true;
            this.cuentas.Width = 66;
            // 
            // debe
            // 
            this.debe.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.debe.DataPropertyName = "debe";
            this.debe.HeaderText = "Debe";
            this.debe.Name = "debe";
            this.debe.ReadOnly = true;
            this.debe.Width = 58;
            // 
            // Haber
            // 
            this.Haber.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Haber.DataPropertyName = "haber";
            this.Haber.HeaderText = "Haber";
            this.Haber.Name = "Haber";
            this.Haber.ReadOnly = true;
            this.Haber.Width = 61;
            // 
            // Fechas
            // 
            this.Fechas.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Fechas.DataPropertyName = "fecha";
            this.Fechas.HeaderText = "Fecha";
            this.Fechas.Name = "Fechas";
            this.Fechas.ReadOnly = true;
            this.Fechas.Width = 62;
            // 
            // btncancelar
            // 
            this.btncancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btncancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btncancelar.Image = ((System.Drawing.Image)(resources.GetObject("btncancelar.Image")));
            this.btncancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btncancelar.Location = new System.Drawing.Point(538, 290);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(82, 24);
            this.btncancelar.TabIndex = 100;
            this.btncancelar.Text = "Cancelar";
            this.btncancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btncancelar.UseVisualStyleBackColor = true;
            // 
            // dtgconten
            // 
            this.dtgconten.AllowUserToAddRows = false;
            this.dtgconten.AllowUserToDeleteRows = false;
            this.dtgconten.AllowUserToResizeColumns = false;
            this.dtgconten.AllowUserToResizeRows = false;
            this.dtgconten.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            //this.dtgconten.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            //this.dtgconten.BackgroundColor = System.Drawing.SystemColors.Control;
            //this.dtgconten.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            //this.dtgconten.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            //this.dtgconten.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            //this.dtgconten.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dtgconten.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgconten.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nrofactura,
            this.proveedor,
            this.OrdenCompra,
            this.Subtotal,
            this.impuesto,
            this.Total,
            this.fechafac});
            this.dtgconten.Cursor = System.Windows.Forms.Cursors.Default;
            this.dtgconten.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnF2;
            this.dtgconten.Location = new System.Drawing.Point(12, 38);
            this.dtgconten.MultiSelect = false;
            this.dtgconten.Name = "dtgconten";
            this.dtgconten.ReadOnly = true;
            //this.dtgconten.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dtgconten.RowHeadersVisible = false;
            this.dtgconten.RowTemplate.Height = 16;
            this.dtgconten.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dtgconten.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgconten.Size = new System.Drawing.Size(608, 246);
            this.dtgconten.TabIndex = 103;
            // 
            // nrofactura
            // 
            this.nrofactura.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.nrofactura.DataPropertyName = "nrofactura";
            this.nrofactura.HeaderText = "NroFactura";
            this.nrofactura.Name = "nrofactura";
            this.nrofactura.ReadOnly = true;
            this.nrofactura.Width = 85;
            // 
            // proveedor
            // 
            this.proveedor.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.proveedor.DataPropertyName = "proveedor";
            this.proveedor.HeaderText = "Proveedor";
            this.proveedor.Name = "proveedor";
            this.proveedor.ReadOnly = true;
            // 
            // OrdenCompra
            // 
            this.OrdenCompra.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.OrdenCompra.DataPropertyName = "ordencompra";
            this.OrdenCompra.HeaderText = "Orden Compra";
            this.OrdenCompra.Name = "OrdenCompra";
            this.OrdenCompra.ReadOnly = true;
            // 
            // Subtotal
            // 
            this.Subtotal.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Subtotal.DataPropertyName = "subtotal";
            this.Subtotal.HeaderText = "Subtotal";
            this.Subtotal.Name = "Subtotal";
            this.Subtotal.ReadOnly = true;
            this.Subtotal.Width = 71;
            // 
            // impuesto
            // 
            this.impuesto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.impuesto.DataPropertyName = "imp";
            this.impuesto.HeaderText = "Imp";
            this.impuesto.Name = "impuesto";
            this.impuesto.ReadOnly = true;
            this.impuesto.Width = 49;
            // 
            // Total
            // 
            this.Total.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Total.DataPropertyName = "total";
            this.Total.HeaderText = "Total";
            this.Total.Name = "Total";
            this.Total.ReadOnly = true;
            this.Total.Width = 56;
            // 
            // fechafac
            // 
            this.fechafac.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.fechafac.DataPropertyName = "fecha";
            this.fechafac.HeaderText = "FechaFac";
            this.fechafac.Name = "fechafac";
            this.fechafac.ReadOnly = true;
            this.fechafac.Width = 80;
            // 
            // frmVerDetallePresuspuestoOperaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 331);
            this.Controls.Add(this.dtgconten);
            this.Controls.Add(this.btnexportarExcel);
            this.Controls.Add(this.dtgcontenx);
            this.Controls.Add(this.btncancelar);
            this.MaximumSize = new System.Drawing.Size(650, 370);
            this.MinimumSize = new System.Drawing.Size(650, 370);
            this.Name = "frmVerDetallePresuspuestoOperaciones";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Detalle de Movimiento Asientos";
            this.Load += new System.EventHandler(this.frmVerDetallePresuspuestoOperaciones_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgcontenx)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgconten)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnexportarExcel;
        private System.Windows.Forms.DataGridView dtgcontenx;
        private System.Windows.Forms.Button btncancelar;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn proyecto;
        private System.Windows.Forms.DataGridViewTextBoxColumn cuentas;
        private System.Windows.Forms.DataGridViewTextBoxColumn debe;
        private System.Windows.Forms.DataGridViewTextBoxColumn Haber;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fechas;
        private Dtgconten dtgconten;
        private System.Windows.Forms.DataGridViewTextBoxColumn nrofactura;
        private System.Windows.Forms.DataGridViewTextBoxColumn proveedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrdenCompra;
        private System.Windows.Forms.DataGridViewTextBoxColumn Subtotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn impuesto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechafac;
    }
}