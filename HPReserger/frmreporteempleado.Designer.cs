using HpResergerUserControls;

namespace HPReserger
{
    partial class frmreporteempleado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmreporteempleado));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblmsg = new System.Windows.Forms.Label();
            this.txtsumatoria = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnexportarplano = new System.Windows.Forms.Button();
            this.SaveFileCts = new System.Windows.Forms.SaveFileDialog();
            this.btnexportaexcel = new System.Windows.Forms.Button();
            this.dtgconten = new HpResergerUserControls.Dtgconten();
            this.label4 = new System.Windows.Forms.Label();
            this.txtbusEmpresa = new HpResergerUserControls.TextBoxPer();
            this.txtbusEmpleado = new HpResergerUserControls.TextBoxPer();
            this.buttonPer1 = new HpResergerUserControls.ButtonPer();
            this.btnlimpiar = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.cboTipodoc = new HpResergerUserControls.ComboBoxPer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.cboTipoContrato = new HpResergerUserControls.ComboBoxPer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtbusCargo = new HpResergerUserControls.TextBoxPer();
            this.txtbusAreaGerencia = new HpResergerUserControls.TextBoxPer();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.dtgconten)).BeginInit();
            this.SuspendLayout();
            // 
            // lblmsg
            // 
            this.lblmsg.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblmsg.AutoSize = true;
            this.lblmsg.BackColor = System.Drawing.Color.Transparent;
            this.lblmsg.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmsg.Location = new System.Drawing.Point(9, 572);
            this.lblmsg.Name = "lblmsg";
            this.lblmsg.Size = new System.Drawing.Size(86, 13);
            this.lblmsg.TabIndex = 11;
            this.lblmsg.Text = "Total Registros:";
            // 
            // txtsumatoria
            // 
            this.txtsumatoria.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtsumatoria.Enabled = false;
            this.txtsumatoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsumatoria.Location = new System.Drawing.Point(1037, 568);
            this.txtsumatoria.Name = "txtsumatoria";
            this.txtsumatoria.Size = new System.Drawing.Size(96, 21);
            this.txtsumatoria.TabIndex = 27;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(972, 572);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 13);
            this.label6.TabIndex = 26;
            this.label6.Text = "Sumatoria:";
            // 
            // btnexportarplano
            // 
            this.btnexportarplano.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnexportarplano.Font = new System.Drawing.Font("Tahoma", 9F);
            this.btnexportarplano.Image = ((System.Drawing.Image)(resources.GetObject("btnexportarplano.Image")));
            this.btnexportarplano.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnexportarplano.Location = new System.Drawing.Point(614, 567);
            this.btnexportarplano.Name = "btnexportarplano";
            this.btnexportarplano.Size = new System.Drawing.Size(105, 23);
            this.btnexportarplano.TabIndex = 28;
            this.btnexportarplano.Text = "Exportar Txt";
            this.btnexportarplano.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnexportarplano.UseVisualStyleBackColor = true;
            this.btnexportarplano.Visible = false;
            this.btnexportarplano.Click += new System.EventHandler(this.btnexportarplano_Click);
            // 
            // SaveFileCts
            // 
            this.SaveFileCts.Filter = "Archivos de Texto|*.txt";
            // 
            // btnexportaexcel
            // 
            this.btnexportaexcel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnexportaexcel.Font = new System.Drawing.Font("Tahoma", 9F);
            this.btnexportaexcel.Image = ((System.Drawing.Image)(resources.GetObject("btnexportaexcel.Image")));
            this.btnexportaexcel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnexportaexcel.Location = new System.Drawing.Point(505, 567);
            this.btnexportaexcel.Name = "btnexportaexcel";
            this.btnexportaexcel.Size = new System.Drawing.Size(115, 23);
            this.btnexportaexcel.TabIndex = 29;
            this.btnexportaexcel.Text = "Exportar Excel";
            this.btnexportaexcel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnexportaexcel.UseVisualStyleBackColor = true;
            this.btnexportaexcel.Click += new System.EventHandler(this.btnexportaexcel_Click);
            // 
            // dtgconten
            // 
            this.dtgconten.AllowUserToAddRows = false;
            this.dtgconten.AllowUserToDeleteRows = false;
            this.dtgconten.AllowUserToOrderColumns = true;
            this.dtgconten.AllowUserToResizeColumns = false;
            this.dtgconten.AllowUserToResizeRows = false;
            dataGridViewCellStyle16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(230)))), ((int)(((byte)(241)))));
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(191)))), ((int)(((byte)(231)))));
            this.dtgconten.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle16;
            this.dtgconten.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgconten.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgconten.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(218)))), ((int)(((byte)(231)))));
            this.dtgconten.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dtgconten.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.dtgconten.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(129)))), ((int)(((byte)(189)))));
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle17.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.Color.DeepSkyBlue;
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgconten.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle17;
            this.dtgconten.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle18.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle18.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(207)))), ((int)(((byte)(241)))));
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgconten.DefaultCellStyle = dataGridViewCellStyle18;
            this.dtgconten.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dtgconten.EnableHeadersVisualStyles = false;
            this.dtgconten.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(179)))), ((int)(((byte)(215)))));
            this.dtgconten.Location = new System.Drawing.Point(12, 115);
            this.dtgconten.MultiSelect = false;
            this.dtgconten.Name = "dtgconten";
            this.dtgconten.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dtgconten.RowHeadersVisible = false;
            this.dtgconten.RowTemplate.Height = 16;
            this.dtgconten.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgconten.Size = new System.Drawing.Size(1210, 445);
            this.dtgconten.TabIndex = 6;
            this.dtgconten.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgconten_CellContentClick);
            this.dtgconten.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgconten_CellDoubleClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 13);
            this.label4.TabIndex = 229;
            this.label4.Text = "Opciones de Filtrado:";
            // 
            // txtbusEmpresa
            // 
            this.txtbusEmpresa.BackColor = System.Drawing.Color.White;
            this.txtbusEmpresa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtbusEmpresa.ColorFondoMouseEncima = System.Drawing.Color.Empty;
            this.txtbusEmpresa.ColorFondoMousePresionado = System.Drawing.Color.Empty;
            this.txtbusEmpresa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbusEmpresa.ForeColor = System.Drawing.Color.Black;
            this.txtbusEmpresa.Format = null;
            this.txtbusEmpresa.Location = new System.Drawing.Point(380, 26);
            this.txtbusEmpresa.MaxLength = 600;
            this.txtbusEmpresa.Name = "txtbusEmpresa";
            this.txtbusEmpresa.NextControlOnEnter = null;
            this.txtbusEmpresa.Size = new System.Drawing.Size(376, 21);
            this.txtbusEmpresa.TabIndex = 228;
            this.txtbusEmpresa.Text = "Buscar Por Empresa O RUC";
            this.txtbusEmpresa.TextoDefecto = "Buscar Por Empresa O RUC";
            this.txtbusEmpresa.TextoDefectoColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(129)))), ((int)(((byte)(189)))));
            this.txtbusEmpresa.TiposDatos = HpResergerUserControls.TextBoxPer.ListaTipos.MayusculaCadaPalabra;
            this.txtbusEmpresa.TextChanged += new System.EventHandler(this.txtbusEmpresa_TextChanged);
            // 
            // txtbusEmpleado
            // 
            this.txtbusEmpleado.BackColor = System.Drawing.Color.White;
            this.txtbusEmpleado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtbusEmpleado.ColorFondoMouseEncima = System.Drawing.Color.Empty;
            this.txtbusEmpleado.ColorFondoMousePresionado = System.Drawing.Color.Empty;
            this.txtbusEmpleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbusEmpleado.ForeColor = System.Drawing.Color.Black;
            this.txtbusEmpleado.Format = null;
            this.txtbusEmpleado.Location = new System.Drawing.Point(12, 26);
            this.txtbusEmpleado.MaxLength = 600;
            this.txtbusEmpleado.Name = "txtbusEmpleado";
            this.txtbusEmpleado.NextControlOnEnter = null;
            this.txtbusEmpleado.Size = new System.Drawing.Size(361, 21);
            this.txtbusEmpleado.TabIndex = 227;
            this.txtbusEmpleado.Text = "Documento O Nombre Empleado";
            this.txtbusEmpleado.TextoDefecto = "Documento O Nombre Empleado";
            this.txtbusEmpleado.TextoDefectoColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(129)))), ((int)(((byte)(189)))));
            this.txtbusEmpleado.TiposDatos = HpResergerUserControls.TextBoxPer.ListaTipos.MayusculaCadaPalabra;
            this.txtbusEmpleado.TextChanged += new System.EventHandler(this.txtbusEmpleado_TextChanged);
            // 
            // buttonPer1
            // 
            this.buttonPer1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonPer1.BackColor = System.Drawing.Color.Crimson;
            this.buttonPer1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonPer1.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.buttonPer1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPer1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPer1.ForeColor = System.Drawing.Color.White;
            this.buttonPer1.Location = new System.Drawing.Point(1139, 566);
            this.buttonPer1.Name = "buttonPer1";
            this.buttonPer1.Size = new System.Drawing.Size(83, 24);
            this.buttonPer1.TabIndex = 230;
            this.buttonPer1.Text = "Cancelar";
            this.buttonPer1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonPer1.UseVisualStyleBackColor = false;
            this.buttonPer1.Click += new System.EventHandler(this.buttonPer1_Click);
            // 
            // btnlimpiar
            // 
            this.btnlimpiar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnlimpiar.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlimpiar.Image = ((System.Drawing.Image)(resources.GetObject("btnlimpiar.Image")));
            this.btnlimpiar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnlimpiar.Location = new System.Drawing.Point(762, 48);
            this.btnlimpiar.Name = "btnlimpiar";
            this.btnlimpiar.Size = new System.Drawing.Size(82, 24);
            this.btnlimpiar.TabIndex = 231;
            this.btnlimpiar.Text = "Limpiar";
            this.btnlimpiar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnlimpiar.UseVisualStyleBackColor = true;
            this.btnlimpiar.Click += new System.EventHandler(this.btnlimpiar_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnActualizar.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizar.Image = ((System.Drawing.Image)(resources.GetObject("btnActualizar.Image")));
            this.btnActualizar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnActualizar.Location = new System.Drawing.Point(762, 73);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(82, 24);
            this.btnActualizar.TabIndex = 232;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // cboTipodoc
            // 
            this.cboTipodoc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(218)))), ((int)(((byte)(231)))));
            this.cboTipodoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTipodoc.FormattingEnabled = true;
            this.cboTipodoc.IndexText = null;
            this.cboTipodoc.Location = new System.Drawing.Point(127, 75);
            this.cboTipodoc.Name = "cboTipodoc";
            this.cboTipodoc.ReadOnly = false;
            this.cboTipodoc.Size = new System.Drawing.Size(246, 21);
            this.cboTipodoc.TabIndex = 233;
            this.cboTipodoc.SelectedIndexChanged += new System.EventHandler(this.cboTipodoc_SelectedIndexChanged);
            this.cboTipodoc.Click += new System.EventHandler(this.cboTipodoc_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 13);
            this.label1.TabIndex = 234;
            this.label1.Text = "Tipo de Documento:";
            // 
            // cboTipoContrato
            // 
            this.cboTipoContrato.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(218)))), ((int)(((byte)(231)))));
            this.cboTipoContrato.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTipoContrato.FormattingEnabled = true;
            this.cboTipoContrato.IndexText = null;
            this.cboTipoContrato.Location = new System.Drawing.Point(484, 75);
            this.cboTipoContrato.Name = "cboTipoContrato";
            this.cboTipoContrato.ReadOnly = false;
            this.cboTipoContrato.Size = new System.Drawing.Size(272, 21);
            this.cboTipoContrato.TabIndex = 233;
            this.cboTipoContrato.SelectedIndexChanged += new System.EventHandler(this.cboTipoContrato_SelectedIndexChanged);
            this.cboTipoContrato.Click += new System.EventHandler(this.cboTipoContrato_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(381, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 13);
            this.label2.TabIndex = 234;
            this.label2.Text = "Tipo Contratación:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(9, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 13);
            this.label3.TabIndex = 229;
            this.label3.Text = "Filtrado de los Empleados:";
            // 
            // txtbusCargo
            // 
            this.txtbusCargo.BackColor = System.Drawing.Color.White;
            this.txtbusCargo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtbusCargo.ColorFondoMouseEncima = System.Drawing.Color.Empty;
            this.txtbusCargo.ColorFondoMousePresionado = System.Drawing.Color.Empty;
            this.txtbusCargo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbusCargo.ForeColor = System.Drawing.Color.Black;
            this.txtbusCargo.Format = null;
            this.txtbusCargo.Location = new System.Drawing.Point(12, 50);
            this.txtbusCargo.MaxLength = 600;
            this.txtbusCargo.Name = "txtbusCargo";
            this.txtbusCargo.NextControlOnEnter = null;
            this.txtbusCargo.Size = new System.Drawing.Size(361, 21);
            this.txtbusCargo.TabIndex = 227;
            this.txtbusCargo.Text = "Buscar Por Cargo";
            this.txtbusCargo.TextoDefecto = "Buscar Por Cargo";
            this.txtbusCargo.TextoDefectoColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(129)))), ((int)(((byte)(189)))));
            this.txtbusCargo.TiposDatos = HpResergerUserControls.TextBoxPer.ListaTipos.MayusculaCadaPalabra;
            this.txtbusCargo.TextChanged += new System.EventHandler(this.txtbusAreaGerencia_TextChanged);
            // 
            // txtbusAreaGerencia
            // 
            this.txtbusAreaGerencia.BackColor = System.Drawing.Color.White;
            this.txtbusAreaGerencia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtbusAreaGerencia.ColorFondoMouseEncima = System.Drawing.Color.Empty;
            this.txtbusAreaGerencia.ColorFondoMousePresionado = System.Drawing.Color.Empty;
            this.txtbusAreaGerencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbusAreaGerencia.ForeColor = System.Drawing.Color.Black;
            this.txtbusAreaGerencia.Format = null;
            this.txtbusAreaGerencia.Location = new System.Drawing.Point(380, 50);
            this.txtbusAreaGerencia.MaxLength = 600;
            this.txtbusAreaGerencia.Name = "txtbusAreaGerencia";
            this.txtbusAreaGerencia.NextControlOnEnter = null;
            this.txtbusAreaGerencia.Size = new System.Drawing.Size(376, 21);
            this.txtbusAreaGerencia.TabIndex = 228;
            this.txtbusAreaGerencia.Text = "Buscar Por Area O Gerencia";
            this.txtbusAreaGerencia.TextoDefecto = "Buscar Por Area O Gerencia";
            this.txtbusAreaGerencia.TextoDefectoColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(129)))), ((int)(((byte)(189)))));
            this.txtbusAreaGerencia.TiposDatos = HpResergerUserControls.TextBoxPer.ListaTipos.MayusculaCadaPalabra;
            this.txtbusAreaGerencia.TextChanged += new System.EventHandler(this.txtbusAreaGerencia_TextChanged);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // frmreporteempleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1237, 596);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboTipoContrato);
            this.Controls.Add(this.cboTipodoc);
            this.Controls.Add(this.btnlimpiar);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.buttonPer1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtbusAreaGerencia);
            this.Controls.Add(this.txtbusCargo);
            this.Controls.Add(this.txtbusEmpresa);
            this.Controls.Add(this.txtbusEmpleado);
            this.Controls.Add(this.btnexportaexcel);
            this.Controls.Add(this.btnexportarplano);
            this.Controls.Add(this.txtsumatoria);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblmsg);
            this.Controls.Add(this.dtgconten);
            this.MinimumSize = new System.Drawing.Size(1253, 635);
            this.Name = "frmreporteempleado";
            this.Nombre = "Reporte de Empleados";
            this.Text = "Reporte de Empleados";
            this.Load += new System.EventHandler(this.frmreporteempleado_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgconten)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Dtgconten dtgconten;
        private System.Windows.Forms.Label lblmsg;
        private System.Windows.Forms.TextBox txtsumatoria;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnexportarplano;
        private System.Windows.Forms.SaveFileDialog SaveFileCts;
        private System.Windows.Forms.Button btnexportaexcel;
        private System.Windows.Forms.Label label4;
        private TextBoxPer txtbusEmpresa;
        private TextBoxPer txtbusEmpleado;
        private ButtonPer buttonPer1;
        private System.Windows.Forms.Button btnlimpiar;
        private System.Windows.Forms.Button btnActualizar;
        private ComboBoxPer cboTipodoc;
        private System.Windows.Forms.Label label1;
        private ComboBoxPer cboTipoContrato;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private TextBoxPer txtbusCargo;
        private TextBoxPer txtbusAreaGerencia;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}