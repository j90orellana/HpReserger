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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.cboListar = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Grid = new System.Windows.Forms.DataGridView();
            this.CODIGOTIPO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TIPO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NDI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.APELLIDOPATERNO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.APELLIDOMATERNO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NOMBRES = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.groupBox1.Controls.Add(this.cboListar);
            this.groupBox1.Controls.Add(this.txtBuscar);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(564, 52);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // Grid
            // 
            this.Grid.AllowUserToAddRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Grid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.Grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CODIGOTIPO,
            this.TIPO,
            this.NDI,
            this.APELLIDOPATERNO,
            this.APELLIDOMATERNO,
            this.NOMBRES});
            this.Grid.Location = new System.Drawing.Point(12, 70);
            this.Grid.Name = "Grid";
            this.Grid.ReadOnly = true;
            this.Grid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.Grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Grid.Size = new System.Drawing.Size(694, 237);
            this.Grid.TabIndex = 36;
            this.Grid.DoubleClick += new System.EventHandler(this.Grid_DoubleClick);
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
            this.TIPO.DataPropertyName = "TIPO";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TIPO.DefaultCellStyle = dataGridViewCellStyle3;
            this.TIPO.HeaderText = "Tipo ID";
            this.TIPO.Name = "TIPO";
            this.TIPO.ReadOnly = true;
            this.TIPO.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // NDI
            // 
            this.NDI.DataPropertyName = "NID";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.NDI.DefaultCellStyle = dataGridViewCellStyle4;
            this.NDI.HeaderText = "Nº ID";
            this.NDI.Name = "NDI";
            this.NDI.ReadOnly = true;
            this.NDI.Width = 70;
            // 
            // APELLIDOPATERNO
            // 
            this.APELLIDOPATERNO.DataPropertyName = "APELLIDOPATERNO";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.APELLIDOPATERNO.DefaultCellStyle = dataGridViewCellStyle5;
            this.APELLIDOPATERNO.HeaderText = "Apellido Paterno";
            this.APELLIDOPATERNO.Name = "APELLIDOPATERNO";
            this.APELLIDOPATERNO.ReadOnly = true;
            this.APELLIDOPATERNO.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.APELLIDOPATERNO.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.APELLIDOPATERNO.Width = 150;
            // 
            // APELLIDOMATERNO
            // 
            this.APELLIDOMATERNO.DataPropertyName = "APELLIDOMATERNO";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.APELLIDOMATERNO.DefaultCellStyle = dataGridViewCellStyle6;
            this.APELLIDOMATERNO.HeaderText = "Apellido Materno";
            this.APELLIDOMATERNO.Name = "APELLIDOMATERNO";
            this.APELLIDOMATERNO.ReadOnly = true;
            this.APELLIDOMATERNO.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.APELLIDOMATERNO.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.APELLIDOMATERNO.Width = 150;
            // 
            // NOMBRES
            // 
            this.NOMBRES.DataPropertyName = "NOMBRES";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.NOMBRES.DefaultCellStyle = dataGridViewCellStyle7;
            this.NOMBRES.HeaderText = "Nombres";
            this.NOMBRES.Name = "NOMBRES";
            this.NOMBRES.ReadOnly = true;
            this.NOMBRES.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.NOMBRES.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.NOMBRES.Width = 150;
            // 
            // frmListarEmpleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(718, 319);
            this.Controls.Add(this.Grid);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGOTIPO;
        private System.Windows.Forms.DataGridViewTextBoxColumn TIPO;
        private System.Windows.Forms.DataGridViewTextBoxColumn NDI;
        private System.Windows.Forms.DataGridViewTextBoxColumn APELLIDOPATERNO;
        private System.Windows.Forms.DataGridViewTextBoxColumn APELLIDOMATERNO;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOMBRES;
    }
}