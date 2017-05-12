namespace HPReserger
{
    partial class frmFamiliares
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFamiliares));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cboTipoDocumentoIdentidad = new System.Windows.Forms.ComboBox();
            this.cboVinculoFamiliar = new System.Windows.Forms.ComboBox();
            this.txtNumeroDocumento = new System.Windows.Forms.TextBox();
            this.txtApellidoMaterno = new System.Windows.Forms.TextBox();
            this.txtNombres = new System.Windows.Forms.TextBox();
            this.txtApellidoPaterno = new System.Windows.Forms.TextBox();
            this.txtOcupacion = new System.Windows.Forms.TextBox();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.Grid = new System.Windows.Forms.DataGridView();
            this.CODIGOTIPOID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TIPOID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NROID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGOVINCULOFAMILIAR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VINCULOFAMILIAR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.APEPAT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.APEMAT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NOMBRES = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FECHANACIMIENTO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OCUPACION = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnRegistrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Grid)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.Name = "label7";
            // 
            // label8
            // 
            resources.ApplyResources(this.label8, "label8");
            this.label8.Name = "label8";
            // 
            // cboTipoDocumentoIdentidad
            // 
            this.cboTipoDocumentoIdentidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTipoDocumentoIdentidad.FormattingEnabled = true;
            resources.ApplyResources(this.cboTipoDocumentoIdentidad, "cboTipoDocumentoIdentidad");
            this.cboTipoDocumentoIdentidad.Name = "cboTipoDocumentoIdentidad";
            // 
            // cboVinculoFamiliar
            // 
            this.cboVinculoFamiliar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboVinculoFamiliar.FormattingEnabled = true;
            resources.ApplyResources(this.cboVinculoFamiliar, "cboVinculoFamiliar");
            this.cboVinculoFamiliar.Name = "cboVinculoFamiliar";
            // 
            // txtNumeroDocumento
            // 
            resources.ApplyResources(this.txtNumeroDocumento, "txtNumeroDocumento");
            this.txtNumeroDocumento.Name = "txtNumeroDocumento";
            this.txtNumeroDocumento.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtNumeroDocumento_KeyDown);
            this.txtNumeroDocumento.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumeroDocumento_KeyPress);
            // 
            // txtApellidoMaterno
            // 
            this.txtApellidoMaterno.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            resources.ApplyResources(this.txtApellidoMaterno, "txtApellidoMaterno");
            this.txtApellidoMaterno.Name = "txtApellidoMaterno";
            // 
            // txtNombres
            // 
            this.txtNombres.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            resources.ApplyResources(this.txtNombres, "txtNombres");
            this.txtNombres.Name = "txtNombres";
            // 
            // txtApellidoPaterno
            // 
            this.txtApellidoPaterno.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            resources.ApplyResources(this.txtApellidoPaterno, "txtApellidoPaterno");
            this.txtApellidoPaterno.Name = "txtApellidoPaterno";
            // 
            // txtOcupacion
            // 
            this.txtOcupacion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            resources.ApplyResources(this.txtOcupacion, "txtOcupacion");
            this.txtOcupacion.Name = "txtOcupacion";
            // 
            // dtpFecha
            // 
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            resources.ApplyResources(this.dtpFecha, "dtpFecha");
            this.dtpFecha.Name = "dtpFecha";
            // 
            // Grid
            // 
            this.Grid.AllowUserToAddRows = false;
            this.Grid.AllowUserToOrderColumns = true;
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
            this.CODIGOTIPOID,
            this.TIPOID,
            this.NROID,
            this.CODIGOVINCULOFAMILIAR,
            this.VINCULOFAMILIAR,
            this.APEPAT,
            this.APEMAT,
            this.NOMBRES,
            this.FECHANACIMIENTO,
            this.OCUPACION});
            this.Grid.GridColor = System.Drawing.Color.White;
            resources.ApplyResources(this.Grid, "Grid");
            this.Grid.Name = "Grid";
            this.Grid.ReadOnly = true;
            this.Grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Grid.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.Grid_RowEnter);
            this.Grid.DoubleClick += new System.EventHandler(this.Grid_DoubleClick);
            // 
            // CODIGOTIPOID
            // 
            this.CODIGOTIPOID.DataPropertyName = "CODIGOTIPOID";
            resources.ApplyResources(this.CODIGOTIPOID, "CODIGOTIPOID");
            this.CODIGOTIPOID.Name = "CODIGOTIPOID";
            this.CODIGOTIPOID.ReadOnly = true;
            // 
            // TIPOID
            // 
            this.TIPOID.DataPropertyName = "TIPODOCUMENTO";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.TIPOID.DefaultCellStyle = dataGridViewCellStyle2;
            resources.ApplyResources(this.TIPOID, "TIPOID");
            this.TIPOID.Name = "TIPOID";
            this.TIPOID.ReadOnly = true;
            // 
            // NROID
            // 
            this.NROID.DataPropertyName = "NUMERODOCUMENTO";
            resources.ApplyResources(this.NROID, "NROID");
            this.NROID.Name = "NROID";
            this.NROID.ReadOnly = true;
            // 
            // CODIGOVINCULOFAMILIAR
            // 
            this.CODIGOVINCULOFAMILIAR.DataPropertyName = "CODIGOVINCULOFAMILIAR";
            resources.ApplyResources(this.CODIGOVINCULOFAMILIAR, "CODIGOVINCULOFAMILIAR");
            this.CODIGOVINCULOFAMILIAR.Name = "CODIGOVINCULOFAMILIAR";
            this.CODIGOVINCULOFAMILIAR.ReadOnly = true;
            // 
            // VINCULOFAMILIAR
            // 
            this.VINCULOFAMILIAR.DataPropertyName = "VINCULOFAMILIAR";
            resources.ApplyResources(this.VINCULOFAMILIAR, "VINCULOFAMILIAR");
            this.VINCULOFAMILIAR.Name = "VINCULOFAMILIAR";
            this.VINCULOFAMILIAR.ReadOnly = true;
            // 
            // APEPAT
            // 
            this.APEPAT.DataPropertyName = "APELLIDOPATERNO";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.APEPAT.DefaultCellStyle = dataGridViewCellStyle3;
            resources.ApplyResources(this.APEPAT, "APEPAT");
            this.APEPAT.Name = "APEPAT";
            this.APEPAT.ReadOnly = true;
            this.APEPAT.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.APEPAT.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // APEMAT
            // 
            this.APEMAT.DataPropertyName = "APELLIDOMATERNO";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.APEMAT.DefaultCellStyle = dataGridViewCellStyle4;
            resources.ApplyResources(this.APEMAT, "APEMAT");
            this.APEMAT.Name = "APEMAT";
            this.APEMAT.ReadOnly = true;
            this.APEMAT.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.APEMAT.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // NOMBRES
            // 
            this.NOMBRES.DataPropertyName = "NOMBRES";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.NOMBRES.DefaultCellStyle = dataGridViewCellStyle5;
            resources.ApplyResources(this.NOMBRES, "NOMBRES");
            this.NOMBRES.Name = "NOMBRES";
            this.NOMBRES.ReadOnly = true;
            this.NOMBRES.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.NOMBRES.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // FECHANACIMIENTO
            // 
            this.FECHANACIMIENTO.DataPropertyName = "FECHA";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FECHANACIMIENTO.DefaultCellStyle = dataGridViewCellStyle6;
            resources.ApplyResources(this.FECHANACIMIENTO, "FECHANACIMIENTO");
            this.FECHANACIMIENTO.Name = "FECHANACIMIENTO";
            this.FECHANACIMIENTO.ReadOnly = true;
            // 
            // OCUPACION
            // 
            this.OCUPACION.DataPropertyName = "OCUPACION";
            resources.ApplyResources(this.OCUPACION, "OCUPACION");
            this.OCUPACION.Name = "OCUPACION";
            this.OCUPACION.ReadOnly = true;
            // 
            // btnRegistrar
            // 
            resources.ApplyResources(this.btnRegistrar, "btnRegistrar");
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // frmFamiliares
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.Grid);
            this.Controls.Add(this.dtpFecha);
            this.Controls.Add(this.txtOcupacion);
            this.Controls.Add(this.txtApellidoPaterno);
            this.Controls.Add(this.txtNombres);
            this.Controls.Add(this.txtApellidoMaterno);
            this.Controls.Add(this.txtNumeroDocumento);
            this.Controls.Add(this.cboVinculoFamiliar);
            this.Controls.Add(this.cboTipoDocumentoIdentidad);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "frmFamiliares";
            this.Load += new System.EventHandler(this.frmFamiliares_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Grid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cboTipoDocumentoIdentidad;
        private System.Windows.Forms.ComboBox cboVinculoFamiliar;
        private System.Windows.Forms.TextBox txtNumeroDocumento;
        private System.Windows.Forms.TextBox txtApellidoMaterno;
        private System.Windows.Forms.TextBox txtNombres;
        private System.Windows.Forms.TextBox txtApellidoPaterno;
        private System.Windows.Forms.TextBox txtOcupacion;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.DataGridView Grid;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGOTIPOID;
        private System.Windows.Forms.DataGridViewTextBoxColumn TIPOID;
        private System.Windows.Forms.DataGridViewTextBoxColumn NROID;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGOVINCULOFAMILIAR;
        private System.Windows.Forms.DataGridViewTextBoxColumn VINCULOFAMILIAR;
        private System.Windows.Forms.DataGridViewTextBoxColumn APEPAT;
        private System.Windows.Forms.DataGridViewTextBoxColumn APEMAT;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOMBRES;
        private System.Windows.Forms.DataGridViewTextBoxColumn FECHANACIMIENTO;
        private System.Windows.Forms.DataGridViewTextBoxColumn OCUPACION;
    }
}