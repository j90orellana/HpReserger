namespace HPReserger
{
    partial class frmListarEmpleados
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmListarEmpleados));
            this.label1 = new System.Windows.Forms.Label();
            this.cboListar = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Grid = new System.Windows.Forms.DataGridView();
            this.cboTipoDocumento = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDocumento = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.checkemp = new System.Windows.Forms.CheckBox();
            this.checkpos = new System.Windows.Forms.CheckBox();
            this.CODIGOTIPO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TIPO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NDI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.T = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.APELLIDOPATERNO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.APELLIDOMATERNO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NOMBRES = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.areax = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gerenciax = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Grid)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Listar por:";
            // 
            // cboListar
            // 
            this.cboListar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboListar.FormattingEnabled = true;
            this.cboListar.Items.AddRange(new object[] {
            "AP. PATERNO",
            "AP. MATERNO",
            "NOMBRES"});
            this.cboListar.Location = new System.Drawing.Point(65, 16);
            this.cboListar.Name = "cboListar";
            this.cboListar.Size = new System.Drawing.Size(121, 21);
            this.cboListar.TabIndex = 1;
            this.cboListar.SelectedIndexChanged += new System.EventHandler(this.cboListar_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(205, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "label2";
            // 
            // txtBuscar
            // 
            this.txtBuscar.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtBuscar.Location = new System.Drawing.Point(290, 16);
            this.txtBuscar.MaxLength = 30;
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(256, 20);
            this.txtBuscar.TabIndex = 3;
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkpos);
            this.groupBox1.Controls.Add(this.checkemp);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtDocumento);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cboTipoDocumento);
            this.groupBox1.Controls.Add(this.cboListar);
            this.groupBox1.Controls.Add(this.txtBuscar);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(861, 75);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // Grid
            // 
            this.Grid.AllowUserToAddRows = false;
            this.Grid.AllowUserToDeleteRows = false;
            this.Grid.AllowUserToResizeColumns = false;
            this.Grid.AllowUserToResizeRows = false;
            this.Grid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Grid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Grid.BackgroundColor = System.Drawing.SystemColors.Control;
            this.Grid.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Franklin Gothic Book", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Grid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.Grid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CODIGOTIPO,
            this.TIPO,
            this.NDI,
            this.T,
            this.APELLIDOPATERNO,
            this.APELLIDOMATERNO,
            this.NOMBRES,
            this.areax,
            this.gerenciax});
            this.Grid.Location = new System.Drawing.Point(12, 84);
            this.Grid.Name = "Grid";
            this.Grid.ReadOnly = true;
            this.Grid.RowHeadersVisible = false;
            this.Grid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Franklin Gothic Book", 8.25F);
            this.Grid.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.Grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Grid.Size = new System.Drawing.Size(861, 377);
            this.Grid.TabIndex = 36;
            this.Grid.DoubleClick += new System.EventHandler(this.Grid_DoubleClick);
            // 
            // cboTipoDocumento
            // 
            this.cboTipoDocumento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTipoDocumento.FormattingEnabled = true;
            this.cboTipoDocumento.Location = new System.Drawing.Point(65, 43);
            this.cboTipoDocumento.Name = "cboTipoDocumento";
            this.cboTipoDocumento.Size = new System.Drawing.Size(203, 21);
            this.cboTipoDocumento.TabIndex = 4;
            this.cboTipoDocumento.SelectedIndexChanged += new System.EventHandler(this.cboTipoDocumento_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "TipoDoc:";
            // 
            // txtDocumento
            // 
            this.txtDocumento.Location = new System.Drawing.Point(340, 44);
            this.txtDocumento.MaxLength = 10;
            this.txtDocumento.Name = "txtDocumento";
            this.txtDocumento.Size = new System.Drawing.Size(206, 20);
            this.txtDocumento.TabIndex = 6;
            this.txtDocumento.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtDocumento.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(287, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "NroDoc:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // checkemp
            // 
            this.checkemp.AutoSize = true;
            this.checkemp.Location = new System.Drawing.Point(563, 47);
            this.checkemp.Name = "checkemp";
            this.checkemp.Size = new System.Drawing.Size(73, 17);
            this.checkemp.TabIndex = 8;
            this.checkemp.Text = "Empleado";
            this.checkemp.UseVisualStyleBackColor = true;
            this.checkemp.CheckedChanged += new System.EventHandler(this.checkemp_CheckedChanged);
            // 
            // checkpos
            // 
            this.checkpos.AutoSize = true;
            this.checkpos.Location = new System.Drawing.Point(642, 47);
            this.checkpos.Name = "checkpos";
            this.checkpos.Size = new System.Drawing.Size(76, 17);
            this.checkpos.TabIndex = 9;
            this.checkpos.Text = "Postulante";
            this.checkpos.UseVisualStyleBackColor = true;
            this.checkpos.CheckedChanged += new System.EventHandler(this.checkemp_CheckedChanged);
            // 
            // CODIGOTIPO
            // 
            this.CODIGOTIPO.DataPropertyName = "CODIGOTIPO";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.CODIGOTIPO.DefaultCellStyle = dataGridViewCellStyle2;
            this.CODIGOTIPO.HeaderText = "CODIGOTIPO";
            this.CODIGOTIPO.Name = "CODIGOTIPO";
            this.CODIGOTIPO.ReadOnly = true;
            this.CODIGOTIPO.Visible = false;
            // 
            // TIPO
            // 
            this.TIPO.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.TIPO.DataPropertyName = "TIPO";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TIPO.DefaultCellStyle = dataGridViewCellStyle3;
            this.TIPO.HeaderText = "Tipo ID";
            this.TIPO.Name = "TIPO";
            this.TIPO.ReadOnly = true;
            this.TIPO.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.TIPO.Width = 65;
            // 
            // NDI
            // 
            this.NDI.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.NDI.DataPropertyName = "NID";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.NDI.DefaultCellStyle = dataGridViewCellStyle4;
            this.NDI.HeaderText = "Nº ID";
            this.NDI.Name = "NDI";
            this.NDI.ReadOnly = true;
            this.NDI.Width = 56;
            // 
            // T
            // 
            this.T.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.T.DataPropertyName = "T";
            this.T.HeaderText = "Tipo";
            this.T.MinimumWidth = 40;
            this.T.Name = "T";
            this.T.ReadOnly = true;
            this.T.Width = 40;
            // 
            // APELLIDOPATERNO
            // 
            this.APELLIDOPATERNO.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.APELLIDOPATERNO.DataPropertyName = "APELLIDOPATERNO";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.APELLIDOPATERNO.DefaultCellStyle = dataGridViewCellStyle5;
            this.APELLIDOPATERNO.HeaderText = "Apellido Paterno";
            this.APELLIDOPATERNO.Name = "APELLIDOPATERNO";
            this.APELLIDOPATERNO.ReadOnly = true;
            this.APELLIDOPATERNO.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.APELLIDOPATERNO.Width = 111;
            // 
            // APELLIDOMATERNO
            // 
            this.APELLIDOMATERNO.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.APELLIDOMATERNO.DataPropertyName = "APELLIDOMATERNO";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.APELLIDOMATERNO.DefaultCellStyle = dataGridViewCellStyle6;
            this.APELLIDOMATERNO.HeaderText = "Apellido Materno";
            this.APELLIDOMATERNO.Name = "APELLIDOMATERNO";
            this.APELLIDOMATERNO.ReadOnly = true;
            this.APELLIDOMATERNO.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.APELLIDOMATERNO.Width = 114;
            // 
            // NOMBRES
            // 
            this.NOMBRES.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NOMBRES.DataPropertyName = "NOMBRES";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.NOMBRES.DefaultCellStyle = dataGridViewCellStyle7;
            this.NOMBRES.HeaderText = "Nombres";
            this.NOMBRES.Name = "NOMBRES";
            this.NOMBRES.ReadOnly = true;
            this.NOMBRES.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // areax
            // 
            this.areax.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.areax.DataPropertyName = "area";
            this.areax.HeaderText = "Área";
            this.areax.Name = "areax";
            this.areax.ReadOnly = true;
            this.areax.Width = 54;
            // 
            // gerenciax
            // 
            this.gerenciax.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.gerenciax.DataPropertyName = "gerencia";
            this.gerenciax.HeaderText = "Gerencia";
            this.gerenciax.Name = "gerenciax";
            this.gerenciax.ReadOnly = true;
            this.gerenciax.Width = 75;
            // 
            // frmListarEmpleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(885, 473);
            this.Controls.Add(this.Grid);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmListarEmpleados";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "  Listar Empleados";
            this.Load += new System.EventHandler(this.frmListarEmpleados_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Grid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboListar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView Grid;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboTipoDocumento;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDocumento;
        private System.Windows.Forms.CheckBox checkpos;
        private System.Windows.Forms.CheckBox checkemp;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGOTIPO;
        private System.Windows.Forms.DataGridViewTextBoxColumn TIPO;
        private System.Windows.Forms.DataGridViewTextBoxColumn NDI;
        private System.Windows.Forms.DataGridViewTextBoxColumn T;
        private System.Windows.Forms.DataGridViewTextBoxColumn APELLIDOPATERNO;
        private System.Windows.Forms.DataGridViewTextBoxColumn APELLIDOMATERNO;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOMBRES;
        private System.Windows.Forms.DataGridViewTextBoxColumn areax;
        private System.Windows.Forms.DataGridViewTextBoxColumn gerenciax;
    }
}