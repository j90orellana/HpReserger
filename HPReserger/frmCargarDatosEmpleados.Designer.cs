namespace HPReserger
{
    partial class frmCargarDatosEmpleados
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCargarDatosEmpleados));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.frmimagen1 = new HpResergerUserControls.frmimagen();
            this.txtBuscar1 = new HpResergerUserControls.txtBuscar();
            this.dtgconten1 = new HpResergerUserControls.Dtgconten();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ORELLANA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtgconten2 = new HpResergerUserControls.Dtgconten();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.textBoxPer1 = new HpResergerUserControls.TextBoxPer();
            this.buttonPer2 = new HpResergerUserControls.ButtonPer();
            ((System.ComponentModel.ISupportInitialize)(this.dtgconten1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgconten2)).BeginInit();
            this.SuspendLayout();
            // 
            // frmimagen1
            // 
            this.frmimagen1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.frmimagen1.Imagen = ((System.Drawing.Image)(resources.GetObject("frmimagen1.Imagen")));
            this.frmimagen1.Location = new System.Drawing.Point(666, 390);
            this.frmimagen1.Name = "frmimagen1";
            this.frmimagen1.Nombre = null;
            this.frmimagen1.Padre = this;
            this.frmimagen1.Size = new System.Drawing.Size(216, 193);
            this.frmimagen1.TabIndex = 2;
            // 
            // txtBuscar1
            // 
            this.txtBuscar1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.txtBuscar1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(129)))), ((int)(((byte)(189)))));
            this.txtBuscar1.FondoBoton = ((System.Drawing.Image)(resources.GetObject("txtBuscar1.FondoBoton")));
            this.txtBuscar1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscar1.Location = new System.Drawing.Point(12, 5);
            this.txtBuscar1.Name = "txtBuscar1";
            this.txtBuscar1.Size = new System.Drawing.Size(278, 23);
            this.txtBuscar1.TabIndex = 3;
            // 
            // dtgconten1
            // 
            this.dtgconten1.AllowUserToOrderColumns = true;
            this.dtgconten1.AllowUserToResizeColumns = false;
            this.dtgconten1.AllowUserToResizeRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(230)))), ((int)(((byte)(241)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(191)))), ((int)(((byte)(231)))));
            this.dtgconten1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dtgconten1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgconten1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgconten1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(218)))), ((int)(((byte)(231)))));
            this.dtgconten1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgconten1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.dtgconten1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(129)))), ((int)(((byte)(189)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.DeepSkyBlue;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgconten1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dtgconten1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dtgconten1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.ORELLANA});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(207)))), ((int)(((byte)(241)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgconten1.DefaultCellStyle = dataGridViewCellStyle6;
            this.dtgconten1.EnableHeadersVisualStyles = false;
            this.dtgconten1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(179)))), ((int)(((byte)(215)))));
            this.dtgconten1.Location = new System.Drawing.Point(12, 34);
            this.dtgconten1.Name = "dtgconten1";
            this.dtgconten1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dtgconten1.RowHeadersVisible = false;
            this.dtgconten1.RowTemplate.Height = 18;
            this.dtgconten1.Size = new System.Drawing.Size(870, 350);
            this.dtgconten1.TabIndex = 4;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "NOMBRE";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "APELLIDO";
            this.Column2.Name = "Column2";
            // 
            // ORELLANA
            // 
            this.ORELLANA.HeaderText = "DIRECCIÓN";
            this.ORELLANA.Name = "ORELLANA";
            // 
            // dtgconten2
            // 
            this.dtgconten2.AllowUserToOrderColumns = true;
            this.dtgconten2.AllowUserToResizeColumns = false;
            this.dtgconten2.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(230)))), ((int)(((byte)(241)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(191)))), ((int)(((byte)(231)))));
            this.dtgconten2.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgconten2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgconten2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgconten2.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(218)))), ((int)(((byte)(231)))));
            this.dtgconten2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgconten2.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.dtgconten2.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(129)))), ((int)(((byte)(189)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DeepSkyBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgconten2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dtgconten2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dtgconten2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column3,
            this.Column4});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(207)))), ((int)(((byte)(241)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgconten2.DefaultCellStyle = dataGridViewCellStyle3;
            this.dtgconten2.EnableHeadersVisualStyles = false;
            this.dtgconten2.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(179)))), ((int)(((byte)(215)))));
            this.dtgconten2.Location = new System.Drawing.Point(12, 390);
            this.dtgconten2.Name = "dtgconten2";
            this.dtgconten2.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dtgconten2.RowHeadersVisible = false;
            this.dtgconten2.RowTemplate.Height = 18;
            this.dtgconten2.Size = new System.Drawing.Size(648, 193);
            this.dtgconten2.TabIndex = 5;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "NOMBRES";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "APELLIDOS";
            this.Column4.Name = "Column4";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(129)))), ((int)(((byte)(189)))));
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(296, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Cruzetas";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Paint += new System.Windows.Forms.PaintEventHandler(this.button1_Paint);
            // 
            // textBoxPer1
            // 
            this.textBoxPer1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxPer1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(129)))), ((int)(((byte)(189)))));
            this.textBoxPer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxPer1.ColorFondoMouseEncima = System.Drawing.Color.Empty;
            this.textBoxPer1.ColorFondoMousePresionado = System.Drawing.Color.Empty;
            this.textBoxPer1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPer1.ForeColor = System.Drawing.Color.LightGray;
            this.textBoxPer1.Location = new System.Drawing.Point(580, 4);
            this.textBoxPer1.MaxLength = 100;
            this.textBoxPer1.Name = "textBoxPer1";
            this.textBoxPer1.NextControlOnEnter = null;
            this.textBoxPer1.Size = new System.Drawing.Size(302, 23);
            this.textBoxPer1.TabIndex = 8;
            this.textBoxPer1.Text = "Ingrese Cadena";
            this.textBoxPer1.TextoDefecto = "Ingrese Cadena";
            this.textBoxPer1.TextoDefectoColor = System.Drawing.Color.Gainsboro;
            this.textBoxPer1.TiposDatos = HpResergerUserControls.TextBoxPer.ListaTipos.SoloLetras;
            // 
            // buttonPer2
            // 
            this.buttonPer2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(129)))), ((int)(((byte)(189)))));
            this.buttonPer2.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.buttonPer2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPer2.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPer2.ForeColor = System.Drawing.Color.White;
            this.buttonPer2.Image = ((System.Drawing.Image)(resources.GetObject("buttonPer2.Image")));
            this.buttonPer2.Location = new System.Drawing.Point(377, 4);
            this.buttonPer2.Margin = new System.Windows.Forms.Padding(0);
            this.buttonPer2.Name = "buttonPer2";
            this.buttonPer2.Size = new System.Drawing.Size(197, 23);
            this.buttonPer2.TabIndex = 10;
            this.buttonPer2.Text = "Listado";
            this.buttonPer2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonPer2.UseVisualStyleBackColor = false;
            // 
            // frmCargarDatosEmpleados
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(894, 595);
            this.Colores = new System.Drawing.Color[0];
            this.Controls.Add(this.buttonPer2);
            this.Controls.Add(this.textBoxPer1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dtgconten2);
            this.Controls.Add(this.dtgconten1);
            this.Controls.Add(this.txtBuscar1);
            this.Controls.Add(this.frmimagen1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmCargarDatosEmpleados";
            this.Nombre = "Seleccione Los Bancos de Los Empleados";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "Seleccione Los Bancos de Los Empleados";
            this.Load += new System.EventHandler(this.frmCargarDatosEmpleados_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgconten1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgconten2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private HpResergerUserControls.frmimagen frmimagen1;
        private HpResergerUserControls.txtBuscar txtBuscar1;
        private HpResergerUserControls.Dtgconten dtgconten1;
        private HpResergerUserControls.Dtgconten dtgconten2;
        private System.Windows.Forms.Button button1;
        private HpResergerUserControls.TextBoxPer textBoxPer1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ORELLANA;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private HpResergerUserControls.ButtonPer buttonPer2;
    }
}