namespace HPReserger
{
    partial class frmCargasRegVentas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCargasRegVentas));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.txtruta = new HpResergerUserControls.TextBoxPer();
            this.btncargaexcel = new System.Windows.Forms.Button();
            this.btnbuscar = new System.Windows.Forms.Button();
            this.dtgconten = new HpResergerUserControls.Dtgconten();
            this.btnprocesar = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.cbohojas = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.eliminarFilasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarColumnasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dtgconten)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(10, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ruta:";
            // 
            // txtruta
            // 
            this.txtruta.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtruta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(218)))), ((int)(((byte)(231)))));
            this.txtruta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtruta.ColorFondoMouseEncima = System.Drawing.Color.Empty;
            this.txtruta.ColorFondoMousePresionado = System.Drawing.Color.Empty;
            this.txtruta.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txtruta.ForeColor = System.Drawing.Color.Black;
            this.txtruta.Location = new System.Drawing.Point(47, 11);
            this.txtruta.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtruta.MaxLength = 100;
            this.txtruta.Name = "txtruta";
            this.txtruta.NextControlOnEnter = this.btncargaexcel;
            this.txtruta.Size = new System.Drawing.Size(847, 25);
            this.txtruta.TabIndex = 1;
            this.txtruta.TextoDefecto = "";
            this.txtruta.TextoDefectoColor = System.Drawing.Color.Black;
            this.txtruta.TiposDatos = HpResergerUserControls.TextBoxPer.ListaTipos.Todo;
            this.txtruta.TextChanged += new System.EventHandler(this.txtruta_TextChanged);
            this.txtruta.Leave += new System.EventHandler(this.txtruta_Leave);
            // 
            // btncargaexcel
            // 
            this.btncargaexcel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btncargaexcel.Image = ((System.Drawing.Image)(resources.GetObject("btncargaexcel.Image")));
            this.btncargaexcel.Location = new System.Drawing.Point(900, 41);
            this.btncargaexcel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btncargaexcel.Name = "btncargaexcel";
            this.btncargaexcel.Size = new System.Drawing.Size(92, 23);
            this.btncargaexcel.TabIndex = 150;
            this.btncargaexcel.Text = "Cargar";
            this.btncargaexcel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btncargaexcel.UseVisualStyleBackColor = true;
            this.btncargaexcel.Click += new System.EventHandler(this.btncargaexcel_Click);
            // 
            // btnbuscar
            // 
            this.btnbuscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnbuscar.BackColor = System.Drawing.SystemColors.Control;
            this.btnbuscar.ForeColor = System.Drawing.Color.Black;
            this.btnbuscar.Image = ((System.Drawing.Image)(resources.GetObject("btnbuscar.Image")));
            this.btnbuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnbuscar.Location = new System.Drawing.Point(900, 12);
            this.btnbuscar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnbuscar.Name = "btnbuscar";
            this.btnbuscar.Size = new System.Drawing.Size(92, 23);
            this.btnbuscar.TabIndex = 16;
            this.btnbuscar.Text = "Buscar";
            this.btnbuscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnbuscar.UseVisualStyleBackColor = true;
            this.btnbuscar.Click += new System.EventHandler(this.btnbuscar_Click);
            // 
            // dtgconten
            // 
            this.dtgconten.AllowUserToAddRows = false;
            this.dtgconten.AllowUserToOrderColumns = true;
            this.dtgconten.AllowUserToResizeColumns = false;
            this.dtgconten.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(230)))), ((int)(((byte)(241)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(191)))), ((int)(((byte)(231)))));
            this.dtgconten.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgconten.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgconten.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dtgconten.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(218)))), ((int)(((byte)(231)))));
            this.dtgconten.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgconten.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.dtgconten.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(129)))), ((int)(((byte)(189)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DeepSkyBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgconten.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dtgconten.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(207)))), ((int)(((byte)(241)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgconten.DefaultCellStyle = dataGridViewCellStyle3;
            this.dtgconten.EnableHeadersVisualStyles = false;
            this.dtgconten.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(179)))), ((int)(((byte)(215)))));
            this.dtgconten.Location = new System.Drawing.Point(13, 69);
            this.dtgconten.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtgconten.Name = "dtgconten";
            this.dtgconten.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dtgconten.RowHeadersVisible = false;
            this.dtgconten.RowTemplate.Height = 18;
            this.dtgconten.Size = new System.Drawing.Size(979, 416);
            this.dtgconten.TabIndex = 17;
            this.dtgconten.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dtgconten_CellMouseClick);
            this.dtgconten.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dtgconten_KeyDown);
            this.dtgconten.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dtgconten_MouseClick);
            // 
            // btnprocesar
            // 
            this.btnprocesar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnprocesar.BackColor = System.Drawing.SystemColors.Control;
            this.btnprocesar.ForeColor = System.Drawing.Color.Black;
            this.btnprocesar.Image = ((System.Drawing.Image)(resources.GetObject("btnprocesar.Image")));
            this.btnprocesar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnprocesar.Location = new System.Drawing.Point(442, 490);
            this.btnprocesar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnprocesar.Name = "btnprocesar";
            this.btnprocesar.Size = new System.Drawing.Size(118, 23);
            this.btnprocesar.TabIndex = 18;
            this.btnprocesar.Text = "Procesar Carga";
            this.btnprocesar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnprocesar.UseVisualStyleBackColor = true;
            this.btnprocesar.Click += new System.EventHandler(this.btnprocesar_Click);
            // 
            // cbohojas
            // 
            this.cbohojas.BackColor = System.Drawing.Color.White;
            this.cbohojas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbohojas.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbohojas.ForeColor = System.Drawing.Color.Black;
            this.cbohojas.FormattingEnabled = true;
            this.cbohojas.Location = new System.Drawing.Point(110, 40);
            this.cbohojas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbohojas.Name = "cbohojas";
            this.cbohojas.Size = new System.Drawing.Size(323, 25);
            this.cbohojas.TabIndex = 149;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(10, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 13);
            this.label2.TabIndex = 148;
            this.label2.Text = "Nombre de la Hoja";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.eliminarFilasToolStripMenuItem,
            this.eliminarColumnasToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(175, 48);
            // 
            // eliminarFilasToolStripMenuItem
            // 
            this.eliminarFilasToolStripMenuItem.Name = "eliminarFilasToolStripMenuItem";
            this.eliminarFilasToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.eliminarFilasToolStripMenuItem.Text = "Eliminar Filas";
            this.eliminarFilasToolStripMenuItem.Click += new System.EventHandler(this.eliminarFilasToolStripMenuItem_Click);
            // 
            // eliminarColumnasToolStripMenuItem
            // 
            this.eliminarColumnasToolStripMenuItem.Name = "eliminarColumnasToolStripMenuItem";
            this.eliminarColumnasToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.eliminarColumnasToolStripMenuItem.Text = "Eliminar Columnas";
            this.eliminarColumnasToolStripMenuItem.Click += new System.EventHandler(this.eliminarColumnasToolStripMenuItem_Click);
            // 
            // frmCargasRegVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1002, 514);
            this.Controls.Add(this.btncargaexcel);
            this.Controls.Add(this.cbohojas);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnprocesar);
            this.Controls.Add(this.dtgconten);
            this.Controls.Add(this.btnbuscar);
            this.Controls.Add(this.txtruta);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinimumSize = new System.Drawing.Size(896, 433);
            this.Name = "frmCargasRegVentas";
            this.Nombre = "Carga de Registros de Ventas";
            this.Text = "Carga de Registros de Ventas";
            this.Load += new System.EventHandler(this.frmCargasRegVentas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgconten)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private HpResergerUserControls.TextBoxPer txtruta;
        private System.Windows.Forms.Button btnbuscar;
        private HpResergerUserControls.Dtgconten dtgconten;
        private System.Windows.Forms.Button btnprocesar;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ComboBox cbohojas;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btncargaexcel;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem eliminarFilasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarColumnasToolStripMenuItem;
    }
}