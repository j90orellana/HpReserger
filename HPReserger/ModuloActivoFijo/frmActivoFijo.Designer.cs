namespace HPReserger.ModuloActivoFijo
{
    partial class frmActivoFijo
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmActivoFijo));
            this.cboempresa = new System.Windows.Forms.ComboBox();
            this.label18 = new System.Windows.Forms.Label();
            this.cboetapa = new System.Windows.Forms.ComboBox();
            this.cboproyecto = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.dtpFechaContable = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaActivacion = new System.Windows.Forms.DateTimePicker();
            this.label19 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtGlosa = new HpResergerUserControls.TextBoxPer();
            this.label13 = new System.Windows.Forms.Label();
            this.txtValorActivo = new HpResergerUserControls.TextBoxPer();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtValorResidual = new HpResergerUserControls.TextBoxPer();
            this.txtVidaUtil = new HpResergerUserControls.TextBoxPer();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPorcentajeTributario = new HpResergerUserControls.TextBoxPer();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPorcentajeContable = new HpResergerUserControls.TextBoxPer();
            this.label8 = new System.Windows.Forms.Label();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.Dtgconten = new HpResergerUserControls.Dtgconten();
            this.xOK = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.xpkid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xNroFactura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xProveedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xGlosa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xcuo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xcuentacontable = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xccuenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xSoles = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xdolares = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label9 = new System.Windows.Forms.Label();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.chkFacturaTodas = new System.Windows.Forms.CheckBox();
            this.cboCuentaCrearActivo = new System.Windows.Forms.ComboBox();
            this.lblCrearActivo = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.cboCuentaActivo = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtDescripcionCuenta = new HpResergerUserControls.TextBoxPer();
            this.txtCuentaContable = new HpResergerUserControls.TextBoxPer();
            this.separadorOre1 = new HpResergerUserControls.SeparadorOre();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.Dtgconten)).BeginInit();
            this.SuspendLayout();
            // 
            // cboempresa
            // 
            this.cboempresa.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboempresa.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboempresa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(218)))), ((int)(((byte)(231)))));
            this.cboempresa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboempresa.DropDownWidth = 250;
            this.cboempresa.FormattingEnabled = true;
            this.cboempresa.Location = new System.Drawing.Point(65, 12);
            this.cboempresa.Name = "cboempresa";
            this.cboempresa.Size = new System.Drawing.Size(226, 21);
            this.cboempresa.TabIndex = 0;
            this.cboempresa.SelectedIndexChanged += new System.EventHandler(this.cboempresa_SelectedIndexChanged);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.BackColor = System.Drawing.Color.Transparent;
            this.label18.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(10, 16);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(53, 13);
            this.label18.TabIndex = 224;
            this.label18.Text = "Empresa:";
            // 
            // cboetapa
            // 
            this.cboetapa.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboetapa.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboetapa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(218)))), ((int)(((byte)(231)))));
            this.cboetapa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboetapa.FormattingEnabled = true;
            this.cboetapa.Location = new System.Drawing.Point(573, 12);
            this.cboetapa.Name = "cboetapa";
            this.cboetapa.Size = new System.Drawing.Size(165, 21);
            this.cboetapa.TabIndex = 2;
            // 
            // cboproyecto
            // 
            this.cboproyecto.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboproyecto.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboproyecto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(218)))), ((int)(((byte)(231)))));
            this.cboproyecto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboproyecto.FormattingEnabled = true;
            this.cboproyecto.Location = new System.Drawing.Point(349, 12);
            this.cboproyecto.Name = "cboproyecto";
            this.cboproyecto.Size = new System.Drawing.Size(181, 21);
            this.cboproyecto.TabIndex = 1;
            this.cboproyecto.SelectedIndexChanged += new System.EventHandler(this.cboproyecto_SelectedIndexChanged);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.Transparent;
            this.label16.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(293, 16);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(54, 13);
            this.label16.TabIndex = 227;
            this.label16.Text = "Proyecto:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(532, 16);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(39, 13);
            this.label15.TabIndex = 228;
            this.label15.Text = "Etapa:";
            // 
            // dtpFechaContable
            // 
            this.dtpFechaContable.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaContable.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFechaContable.Location = new System.Drawing.Point(109, 63);
            this.dtpFechaContable.MaxDate = new System.DateTime(3000, 12, 31, 0, 0, 0, 0);
            this.dtpFechaContable.MinDate = new System.DateTime(1950, 1, 1, 0, 0, 0, 0);
            this.dtpFechaContable.Name = "dtpFechaContable";
            this.dtpFechaContable.Size = new System.Drawing.Size(97, 22);
            this.dtpFechaContable.TabIndex = 4;
            this.dtpFechaContable.Value = new System.DateTime(2021, 1, 1, 0, 0, 0, 0);
            // 
            // dtpFechaActivacion
            // 
            this.dtpFechaActivacion.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaActivacion.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFechaActivacion.Location = new System.Drawing.Point(109, 39);
            this.dtpFechaActivacion.MaxDate = new System.DateTime(3000, 12, 31, 0, 0, 0, 0);
            this.dtpFechaActivacion.MinDate = new System.DateTime(1950, 1, 1, 0, 0, 0, 0);
            this.dtpFechaActivacion.Name = "dtpFechaActivacion";
            this.dtpFechaActivacion.Size = new System.Drawing.Size(97, 22);
            this.dtpFechaActivacion.TabIndex = 3;
            this.dtpFechaActivacion.Value = new System.DateTime(2021, 1, 1, 0, 0, 0, 0);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.BackColor = System.Drawing.Color.Transparent;
            this.label19.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(20, 68);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(90, 13);
            this.label19.TabIndex = 231;
            this.label19.Text = "Fecha Contable:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 13);
            this.label2.TabIndex = 232;
            this.label2.Text = "Fecha Activación:";
            // 
            // txtGlosa
            // 
            this.txtGlosa.BackColor = System.Drawing.Color.White;
            this.txtGlosa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtGlosa.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtGlosa.ColorFondoMouseEncima = System.Drawing.Color.Empty;
            this.txtGlosa.ColorFondoMousePresionado = System.Drawing.Color.Empty;
            this.txtGlosa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGlosa.ForeColor = System.Drawing.Color.Black;
            this.txtGlosa.Format = null;
            this.txtGlosa.Location = new System.Drawing.Point(52, 89);
            this.txtGlosa.MaxLength = 300;
            this.txtGlosa.Name = "txtGlosa";
            this.txtGlosa.NextControlOnEnter = null;
            this.txtGlosa.Size = new System.Drawing.Size(686, 21);
            this.txtGlosa.TabIndex = 5;
            this.txtGlosa.Text = "INGRESE LA GLOSA DEL ACTIVO";
            this.txtGlosa.TextoDefecto = "INGRESE LA GLOSA DEL ACTIVO";
            this.txtGlosa.TextoDefectoColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(129)))), ((int)(((byte)(189)))));
            this.txtGlosa.TiposDatos = HpResergerUserControls.TextBoxPer.ListaTipos.MayusculaCadaPalabra;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(15, 93);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(39, 13);
            this.label13.TabIndex = 237;
            this.label13.Text = "Glosa:";
            // 
            // txtValorActivo
            // 
            this.txtValorActivo.BackColor = System.Drawing.Color.White;
            this.txtValorActivo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtValorActivo.ColorFondoMouseEncima = System.Drawing.Color.Empty;
            this.txtValorActivo.ColorFondoMousePresionado = System.Drawing.Color.Empty;
            this.txtValorActivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValorActivo.ForeColor = System.Drawing.Color.Black;
            this.txtValorActivo.Format = "n2";
            this.txtValorActivo.Location = new System.Drawing.Point(611, 64);
            this.txtValorActivo.MaxLength = 11;
            this.txtValorActivo.Name = "txtValorActivo";
            this.txtValorActivo.NextControlOnEnter = null;
            this.txtValorActivo.Size = new System.Drawing.Size(127, 21);
            this.txtValorActivo.TabIndex = 10;
            this.txtValorActivo.Text = "0.00";
            this.txtValorActivo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtValorActivo.TextoDefecto = "0.00";
            this.txtValorActivo.TextoDefectoColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(129)))), ((int)(((byte)(189)))));
            this.txtValorActivo.TiposDatos = HpResergerUserControls.TextBoxPer.ListaTipos.SoloDinero;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(541, 68);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 13);
            this.label7.TabIndex = 239;
            this.label7.Text = "Valor Activo:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(528, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 239;
            this.label1.Text = "Valor Residual:";
            // 
            // txtValorResidual
            // 
            this.txtValorResidual.BackColor = System.Drawing.Color.White;
            this.txtValorResidual.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtValorResidual.ColorFondoMouseEncima = System.Drawing.Color.Empty;
            this.txtValorResidual.ColorFondoMousePresionado = System.Drawing.Color.Empty;
            this.txtValorResidual.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValorResidual.ForeColor = System.Drawing.Color.Black;
            this.txtValorResidual.Format = "n2";
            this.txtValorResidual.Location = new System.Drawing.Point(611, 40);
            this.txtValorResidual.MaxLength = 11;
            this.txtValorResidual.Name = "txtValorResidual";
            this.txtValorResidual.NextControlOnEnter = null;
            this.txtValorResidual.Size = new System.Drawing.Size(127, 21);
            this.txtValorResidual.TabIndex = 9;
            this.txtValorResidual.Text = "0.00";
            this.txtValorResidual.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtValorResidual.TextoDefecto = "0.00";
            this.txtValorResidual.TextoDefectoColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(129)))), ((int)(((byte)(189)))));
            this.txtValorResidual.TiposDatos = HpResergerUserControls.TextBoxPer.ListaTipos.SoloDinero;
            // 
            // txtVidaUtil
            // 
            this.txtVidaUtil.BackColor = System.Drawing.Color.White;
            this.txtVidaUtil.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtVidaUtil.ColorFondoMouseEncima = System.Drawing.Color.Empty;
            this.txtVidaUtil.ColorFondoMousePresionado = System.Drawing.Color.Empty;
            this.txtVidaUtil.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVidaUtil.ForeColor = System.Drawing.Color.Black;
            this.txtVidaUtil.Format = "n2";
            this.txtVidaUtil.Location = new System.Drawing.Point(269, 40);
            this.txtVidaUtil.MaxLength = 11;
            this.txtVidaUtil.Name = "txtVidaUtil";
            this.txtVidaUtil.NextControlOnEnter = null;
            this.txtVidaUtil.Size = new System.Drawing.Size(57, 21);
            this.txtVidaUtil.TabIndex = 6;
            this.txtVidaUtil.Text = "0.00";
            this.txtVidaUtil.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtVidaUtil.TextoDefecto = "0.00";
            this.txtVidaUtil.TextoDefectoColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(129)))), ((int)(((byte)(189)))));
            this.txtVidaUtil.TiposDatos = HpResergerUserControls.TextBoxPer.ListaTipos.SoloDinero;
            this.txtVidaUtil.TextChanged += new System.EventHandler(this.txtVidaUtil_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(215, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 241;
            this.label3.Text = "Vida Util:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(332, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 13);
            this.label4.TabIndex = 241;
            this.label4.Text = "Porcentaje Tributario:";
            // 
            // txtPorcentajeTributario
            // 
            this.txtPorcentajeTributario.BackColor = System.Drawing.Color.White;
            this.txtPorcentajeTributario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPorcentajeTributario.ColorFondoMouseEncima = System.Drawing.Color.Empty;
            this.txtPorcentajeTributario.ColorFondoMousePresionado = System.Drawing.Color.Empty;
            this.txtPorcentajeTributario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPorcentajeTributario.ForeColor = System.Drawing.Color.Black;
            this.txtPorcentajeTributario.Format = "n2";
            this.txtPorcentajeTributario.Location = new System.Drawing.Point(449, 40);
            this.txtPorcentajeTributario.MaxLength = 11;
            this.txtPorcentajeTributario.Name = "txtPorcentajeTributario";
            this.txtPorcentajeTributario.NextControlOnEnter = null;
            this.txtPorcentajeTributario.Size = new System.Drawing.Size(50, 21);
            this.txtPorcentajeTributario.TabIndex = 7;
            this.txtPorcentajeTributario.Text = "0.00";
            this.txtPorcentajeTributario.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtPorcentajeTributario.TextoDefecto = "0.00";
            this.txtPorcentajeTributario.TextoDefectoColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(129)))), ((int)(((byte)(189)))));
            this.txtPorcentajeTributario.TiposDatos = HpResergerUserControls.TextBoxPer.ListaTipos.SoloDinero;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(499, 44);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(16, 13);
            this.label5.TabIndex = 242;
            this.label5.Text = "%";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(499, 68);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(16, 13);
            this.label6.TabIndex = 245;
            this.label6.Text = "%";
            // 
            // txtPorcentajeContable
            // 
            this.txtPorcentajeContable.BackColor = System.Drawing.Color.White;
            this.txtPorcentajeContable.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPorcentajeContable.ColorFondoMouseEncima = System.Drawing.Color.Empty;
            this.txtPorcentajeContable.ColorFondoMousePresionado = System.Drawing.Color.Empty;
            this.txtPorcentajeContable.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPorcentajeContable.ForeColor = System.Drawing.Color.Black;
            this.txtPorcentajeContable.Format = "n2";
            this.txtPorcentajeContable.Location = new System.Drawing.Point(449, 64);
            this.txtPorcentajeContable.MaxLength = 11;
            this.txtPorcentajeContable.Name = "txtPorcentajeContable";
            this.txtPorcentajeContable.NextControlOnEnter = null;
            this.txtPorcentajeContable.Size = new System.Drawing.Size(50, 21);
            this.txtPorcentajeContable.TabIndex = 8;
            this.txtPorcentajeContable.Text = "0.00";
            this.txtPorcentajeContable.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtPorcentajeContable.TextoDefecto = "0.00";
            this.txtPorcentajeContable.TextoDefectoColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(129)))), ((int)(((byte)(189)))));
            this.txtPorcentajeContable.TiposDatos = HpResergerUserControls.TextBoxPer.ListaTipos.SoloDinero;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(335, 68);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(114, 13);
            this.label8.TabIndex = 244;
            this.label8.Text = "Porcentaje Contable:";
            // 
            // btnAceptar
            // 
            this.btnAceptar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAceptar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(129)))), ((int)(((byte)(189)))));
            this.btnAceptar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnAceptar.Enabled = false;
            this.btnAceptar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(179)))), ((int)(((byte)(215)))));
            this.btnAceptar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(129)))), ((int)(((byte)(189)))));
            this.btnAceptar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(86)))), ((int)(((byte)(126)))));
            this.btnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAceptar.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptar.ForeColor = System.Drawing.Color.White;
            this.btnAceptar.Location = new System.Drawing.Point(780, 331);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(92, 23);
            this.btnAceptar.TabIndex = 13;
            this.btnAceptar.Text = "&Activar";
            this.btnAceptar.UseVisualStyleBackColor = false;
            // 
            // Dtgconten
            // 
            this.Dtgconten.AllowUserToAddRows = false;
            this.Dtgconten.AllowUserToDeleteRows = false;
            this.Dtgconten.AllowUserToResizeColumns = false;
            this.Dtgconten.AllowUserToResizeRows = false;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(230)))), ((int)(((byte)(241)))));
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(191)))), ((int)(((byte)(231)))));
            this.Dtgconten.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle8;
            this.Dtgconten.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Dtgconten.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Dtgconten.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.Dtgconten.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(218)))), ((int)(((byte)(231)))));
            this.Dtgconten.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Dtgconten.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.Dtgconten.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(129)))), ((int)(((byte)(189)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.DeepSkyBlue;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Dtgconten.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.Dtgconten.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.Dtgconten.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.xOK,
            this.xpkid,
            this.xNroFactura,
            this.xProveedor,
            this.xGlosa,
            this.xcuo,
            this.xcuentacontable,
            this.xccuenta,
            this.xSoles,
            this.xdolares});
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            dataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(207)))), ((int)(((byte)(241)))));
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Dtgconten.DefaultCellStyle = dataGridViewCellStyle13;
            this.Dtgconten.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.Dtgconten.EnableHeadersVisualStyles = false;
            this.Dtgconten.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(179)))), ((int)(((byte)(215)))));
            this.Dtgconten.Location = new System.Drawing.Point(10, 135);
            this.Dtgconten.Name = "Dtgconten";
            this.Dtgconten.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Dtgconten.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.Dtgconten.RowHeadersVisible = false;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Dtgconten.RowsDefaultCellStyle = dataGridViewCellStyle14;
            this.Dtgconten.RowTemplate.Height = 18;
            this.Dtgconten.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Dtgconten.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Dtgconten.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.Dtgconten.ShowRowErrors = false;
            this.Dtgconten.Size = new System.Drawing.Size(862, 144);
            this.Dtgconten.TabIndex = 11;
            this.Dtgconten.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dtgconten_CellContentClick);
            this.Dtgconten.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dtgconten_CellValueChanged);
            // 
            // xOK
            // 
            this.xOK.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.xOK.DataPropertyName = "ok";
            this.xOK.FalseValue = "0";
            this.xOK.HeaderText = "OK";
            this.xOK.MinimumWidth = 25;
            this.xOK.Name = "xOK";
            this.xOK.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.xOK.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.xOK.TrueValue = "1";
            this.xOK.Width = 25;
            // 
            // xpkid
            // 
            this.xpkid.DataPropertyName = "pkid";
            this.xpkid.HeaderText = "pkid";
            this.xpkid.Name = "xpkid";
            this.xpkid.Visible = false;
            // 
            // xNroFactura
            // 
            this.xNroFactura.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.xNroFactura.DataPropertyName = "nrocomprobante";
            this.xNroFactura.HeaderText = "Factura";
            this.xNroFactura.MinimumWidth = 60;
            this.xNroFactura.Name = "xNroFactura";
            this.xNroFactura.ReadOnly = true;
            this.xNroFactura.Width = 60;
            // 
            // xProveedor
            // 
            this.xProveedor.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.xProveedor.DataPropertyName = "proveedor";
            this.xProveedor.HeaderText = "RUC";
            this.xProveedor.MinimumWidth = 60;
            this.xProveedor.Name = "xProveedor";
            this.xProveedor.ReadOnly = true;
            this.xProveedor.Width = 60;
            // 
            // xGlosa
            // 
            this.xGlosa.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.xGlosa.DataPropertyName = "glosa";
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.xGlosa.DefaultCellStyle = dataGridViewCellStyle10;
            this.xGlosa.HeaderText = "Glosa";
            this.xGlosa.MinimumWidth = 100;
            this.xGlosa.Name = "xGlosa";
            this.xGlosa.ReadOnly = true;
            // 
            // xcuo
            // 
            this.xcuo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.xcuo.DataPropertyName = "cuo";
            this.xcuo.HeaderText = "CUO";
            this.xcuo.MinimumWidth = 45;
            this.xcuo.Name = "xcuo";
            this.xcuo.ReadOnly = true;
            this.xcuo.Width = 45;
            // 
            // xcuentacontable
            // 
            this.xcuentacontable.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.xcuentacontable.DataPropertyName = "cuentacontable";
            this.xcuentacontable.HeaderText = "CuentaContable";
            this.xcuentacontable.MinimumWidth = 50;
            this.xcuentacontable.Name = "xcuentacontable";
            this.xcuentacontable.ReadOnly = true;
            this.xcuentacontable.Visible = false;
            // 
            // xccuenta
            // 
            this.xccuenta.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.xccuenta.DataPropertyName = "ccuenta";
            this.xccuenta.HeaderText = "Descripcion Cuenta";
            this.xccuenta.MinimumWidth = 100;
            this.xccuenta.Name = "xccuenta";
            this.xccuenta.ReadOnly = true;
            // 
            // xSoles
            // 
            this.xSoles.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.xSoles.DataPropertyName = "importemn";
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle11.Format = "n2";
            this.xSoles.DefaultCellStyle = dataGridViewCellStyle11;
            this.xSoles.HeaderText = "Soles";
            this.xSoles.MinimumWidth = 60;
            this.xSoles.Name = "xSoles";
            this.xSoles.ReadOnly = true;
            this.xSoles.Width = 60;
            // 
            // xdolares
            // 
            this.xdolares.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.xdolares.DataPropertyName = "importeme";
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle12.Format = "n2";
            this.xdolares.DefaultCellStyle = dataGridViewCellStyle12;
            this.xdolares.HeaderText = "Dolares";
            this.xdolares.MinimumWidth = 60;
            this.xdolares.Name = "xdolares";
            this.xdolares.ReadOnly = true;
            this.xdolares.Width = 60;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(7, 119);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(198, 13);
            this.label9.TabIndex = 248;
            this.label9.Text = "Seleccione Factura Origen del Activo:";
            // 
            // btnActualizar
            // 
            this.btnActualizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnActualizar.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizar.Image = ((System.Drawing.Image)(resources.GetObject("btnActualizar.Image")));
            this.btnActualizar.Location = new System.Drawing.Point(780, 109);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(92, 23);
            this.btnActualizar.TabIndex = 12;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // chkFacturaTodas
            // 
            this.chkFacturaTodas.AutoSize = true;
            this.chkFacturaTodas.BackColor = System.Drawing.Color.Transparent;
            this.chkFacturaTodas.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.chkFacturaTodas.Location = new System.Drawing.Point(211, 117);
            this.chkFacturaTodas.Name = "chkFacturaTodas";
            this.chkFacturaTodas.Size = new System.Drawing.Size(99, 17);
            this.chkFacturaTodas.TabIndex = 326;
            this.chkFacturaTodas.Text = "Mostrar Todas";
            this.chkFacturaTodas.UseVisualStyleBackColor = false;
            this.chkFacturaTodas.CheckedChanged += new System.EventHandler(this.chkFacturaTodas_CheckedChanged);
            // 
            // cboCuentaCrearActivo
            // 
            this.cboCuentaCrearActivo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboCuentaCrearActivo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboCuentaCrearActivo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(218)))), ((int)(((byte)(231)))));
            this.cboCuentaCrearActivo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCuentaCrearActivo.DropDownWidth = 250;
            this.cboCuentaCrearActivo.FormattingEnabled = true;
            this.cboCuentaCrearActivo.Location = new System.Drawing.Point(121, 284);
            this.cboCuentaCrearActivo.Name = "cboCuentaCrearActivo";
            this.cboCuentaCrearActivo.Size = new System.Drawing.Size(617, 21);
            this.cboCuentaCrearActivo.TabIndex = 327;
            this.toolTip1.SetToolTip(this.cboCuentaCrearActivo, "Cuenta Contable para Crear el Asiento desde varias Facturas");
            this.cboCuentaCrearActivo.Click += new System.EventHandler(this.cboCuentaCrearActivo_Click);
            // 
            // lblCrearActivo
            // 
            this.lblCrearActivo.AutoSize = true;
            this.lblCrearActivo.BackColor = System.Drawing.Color.Transparent;
            this.lblCrearActivo.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCrearActivo.Location = new System.Drawing.Point(10, 288);
            this.lblCrearActivo.Name = "lblCrearActivo";
            this.lblCrearActivo.Size = new System.Drawing.Size(111, 13);
            this.lblCrearActivo.TabIndex = 328;
            this.lblCrearActivo.Text = "Cuenta Crear Activo:";
            this.toolTip1.SetToolTip(this.lblCrearActivo, "Cuenta Contable para Crear el Asiento desde varias Facturas");
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(22, 336);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(99, 13);
            this.label11.TabIndex = 328;
            this.label11.Text = "Cuenta del Gasto:";
            this.toolTip1.SetToolTip(this.label11, "Cuenta de Gasto para Cuadrar la Depreciacion");
            // 
            // cboCuentaActivo
            // 
            this.cboCuentaActivo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboCuentaActivo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboCuentaActivo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(218)))), ((int)(((byte)(231)))));
            this.cboCuentaActivo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCuentaActivo.DropDownWidth = 250;
            this.cboCuentaActivo.FormattingEnabled = true;
            this.cboCuentaActivo.Location = new System.Drawing.Point(121, 308);
            this.cboCuentaActivo.Name = "cboCuentaActivo";
            this.cboCuentaActivo.Size = new System.Drawing.Size(617, 21);
            this.cboCuentaActivo.TabIndex = 327;
            this.toolTip1.SetToolTip(this.cboCuentaActivo, "Cuenta para Guarda la Depreciacion del Activo");
            this.cboCuentaActivo.Click += new System.EventHandler(this.cboCuentaActivo_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(24, 312);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(97, 13);
            this.label12.TabIndex = 328;
            this.label12.Text = "Cuenta de Activo:";
            this.toolTip1.SetToolTip(this.label12, "Cuenta para Guarda la Depreciacion del Activo");
            // 
            // txtDescripcionCuenta
            // 
            this.txtDescripcionCuenta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(218)))), ((int)(((byte)(231)))));
            this.txtDescripcionCuenta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDescripcionCuenta.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDescripcionCuenta.ColorFondoMouseEncima = System.Drawing.Color.Empty;
            this.txtDescripcionCuenta.ColorFondoMousePresionado = System.Drawing.Color.Empty;
            this.txtDescripcionCuenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescripcionCuenta.ForeColor = System.Drawing.Color.Black;
            this.txtDescripcionCuenta.Format = null;
            this.txtDescripcionCuenta.Location = new System.Drawing.Point(211, 332);
            this.txtDescripcionCuenta.MaxLength = 300;
            this.txtDescripcionCuenta.Name = "txtDescripcionCuenta";
            this.txtDescripcionCuenta.NextControlOnEnter = null;
            this.txtDescripcionCuenta.ReadOnly = true;
            this.txtDescripcionCuenta.Size = new System.Drawing.Size(527, 21);
            this.txtDescripcionCuenta.TabIndex = 329;
            this.txtDescripcionCuenta.Text = "CUENTA CONTABLE DEL GASTO";
            this.txtDescripcionCuenta.TextoDefecto = "CUENTA CONTABLE DEL GASTO";
            this.txtDescripcionCuenta.TextoDefectoColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(129)))), ((int)(((byte)(189)))));
            this.txtDescripcionCuenta.TiposDatos = HpResergerUserControls.TextBoxPer.ListaTipos.MayusculaCadaPalabra;
            // 
            // txtCuentaContable
            // 
            this.txtCuentaContable.BackColor = System.Drawing.Color.White;
            this.txtCuentaContable.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCuentaContable.ColorFondoMouseEncima = System.Drawing.Color.Empty;
            this.txtCuentaContable.ColorFondoMousePresionado = System.Drawing.Color.Empty;
            this.txtCuentaContable.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCuentaContable.ForeColor = System.Drawing.Color.Black;
            this.txtCuentaContable.Format = "";
            this.txtCuentaContable.Location = new System.Drawing.Point(121, 332);
            this.txtCuentaContable.MaxLength = 11;
            this.txtCuentaContable.Name = "txtCuentaContable";
            this.txtCuentaContable.NextControlOnEnter = null;
            this.txtCuentaContable.Size = new System.Drawing.Size(84, 21);
            this.txtCuentaContable.TabIndex = 330;
            this.txtCuentaContable.Text = "000000";
            this.txtCuentaContable.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtCuentaContable.TextoDefecto = "000000";
            this.txtCuentaContable.TextoDefectoColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(129)))), ((int)(((byte)(189)))));
            this.txtCuentaContable.TiposDatos = HpResergerUserControls.TextBoxPer.ListaTipos.SoloNumeros;
            this.toolTip1.SetToolTip(this.txtCuentaContable, "DobleClick para Buscar.");
            this.txtCuentaContable.TextChanged += new System.EventHandler(this.txtCuentaContable_TextChanged);
            this.txtCuentaContable.DoubleClick += new System.EventHandler(this.txtCuentaContable_DoubleClick);
            // 
            // separadorOre1
            // 
            this.separadorOre1.BackColor = System.Drawing.Color.Transparent;
            this.separadorOre1.Location = new System.Drawing.Point(0, 360);
            this.separadorOre1.MaximumSize = new System.Drawing.Size(2000, 2);
            this.separadorOre1.MinimumSize = new System.Drawing.Size(0, 2);
            this.separadorOre1.Name = "separadorOre1";
            this.separadorOre1.Size = new System.Drawing.Size(900, 2);
            this.separadorOre1.TabIndex = 331;
            // 
            // frmActivoFijo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.separadorOre1);
            this.Controls.Add(this.txtCuentaContable);
            this.Controls.Add(this.txtDescripcionCuenta);
            this.Controls.Add(this.cboCuentaActivo);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.cboCuentaCrearActivo);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.lblCrearActivo);
            this.Controls.Add(this.chkFacturaTodas);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.Dtgconten);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtPorcentajeContable);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtPorcentajeTributario);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtVidaUtil);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtValorResidual);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtValorActivo);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtGlosa);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.dtpFechaContable);
            this.Controls.Add(this.dtpFechaActivacion);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cboetapa);
            this.Controls.Add(this.cboproyecto);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.cboempresa);
            this.Controls.Add(this.label18);
            this.Name = "frmActivoFijo";
            this.Nombre = "Creación Activo Fijo";
            this.Text = "Creación Activo Fijo";
            this.Load += new System.EventHandler(this.frmActivoFijo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Dtgconten)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboempresa;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.ComboBox cboetapa;
        private System.Windows.Forms.ComboBox cboproyecto;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.DateTimePicker dtpFechaContable;
        private System.Windows.Forms.DateTimePicker dtpFechaActivacion;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label2;
        private HpResergerUserControls.TextBoxPer txtGlosa;
        private System.Windows.Forms.Label label13;
        private HpResergerUserControls.TextBoxPer txtValorActivo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private HpResergerUserControls.TextBoxPer txtValorResidual;
        private HpResergerUserControls.TextBoxPer txtVidaUtil;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private HpResergerUserControls.TextBoxPer txtPorcentajeTributario;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private HpResergerUserControls.TextBoxPer txtPorcentajeContable;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnAceptar;
        private HpResergerUserControls.Dtgconten Dtgconten;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.CheckBox chkFacturaTodas;
        private System.Windows.Forms.DataGridViewCheckBoxColumn xOK;
        private System.Windows.Forms.DataGridViewTextBoxColumn xpkid;
        private System.Windows.Forms.DataGridViewTextBoxColumn xNroFactura;
        private System.Windows.Forms.DataGridViewTextBoxColumn xProveedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn xGlosa;
        private System.Windows.Forms.DataGridViewTextBoxColumn xcuo;
        private System.Windows.Forms.DataGridViewTextBoxColumn xcuentacontable;
        private System.Windows.Forms.DataGridViewTextBoxColumn xccuenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn xSoles;
        private System.Windows.Forms.DataGridViewTextBoxColumn xdolares;
        private System.Windows.Forms.ComboBox cboCuentaCrearActivo;
        private System.Windows.Forms.Label lblCrearActivo;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cboCuentaActivo;
        private System.Windows.Forms.Label label12;
        private HpResergerUserControls.TextBoxPer txtDescripcionCuenta;
        private HpResergerUserControls.TextBoxPer txtCuentaContable;
        private HpResergerUserControls.SeparadorOre separadorOre1;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}