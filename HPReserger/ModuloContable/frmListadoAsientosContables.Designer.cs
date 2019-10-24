namespace HPReserger.ModuloContable
{
    partial class frmListadoAsientosContables
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmListadoAsientosContables));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtbuscuenta = new HpResergerUserControls.TextBoxPer();
            this.btncleanfind = new System.Windows.Forms.Button();
            this.dtpfechaini = new System.Windows.Forms.DateTimePicker();
            this.lbl2 = new System.Windows.Forms.Label();
            this.lbl1 = new System.Windows.Forms.Label();
            this.dtpfechafin = new System.Windows.Forms.DateTimePicker();
            this.txtbusSuboperacion = new HpResergerUserControls.TextBoxPer();
            this.txtbusGlosa = new HpResergerUserControls.TextBoxPer();
            this.txtbuscuo = new HpResergerUserControls.TextBoxPer();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.dtgconten = new HpResergerUserControls.Dtgconten();
            this.btncancelar = new System.Windows.Forms.Button();
            this.lblmsg = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.separadorOre1 = new HpResergerUserControls.SeparadorOre();
            this.cboempresa = new System.Windows.Forms.ComboBox();
            this.btnpdf = new System.Windows.Forms.Button();
            this.rbActivo = new System.Windows.Forms.RadioButton();
            this.rbReversado = new System.Windows.Forms.RadioButton();
            this.rbTodos = new System.Windows.Forms.RadioButton();
            this.idx = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Codidasiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xperiodo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fechax = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechavalorx = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubOperacionx = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Iddinamica = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estadox = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.empresax = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.proyectox = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.etapax = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameestado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha_Asientox = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xglosa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xmoneda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xtc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtgconten)).BeginInit();
            this.SuspendLayout();
            // 
            // txtbuscuenta
            // 
            this.txtbuscuenta.BackColor = System.Drawing.Color.White;
            this.txtbuscuenta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtbuscuenta.ColorFondoMouseEncima = System.Drawing.Color.Empty;
            this.txtbuscuenta.ColorFondoMousePresionado = System.Drawing.Color.Empty;
            this.txtbuscuenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbuscuenta.ForeColor = System.Drawing.Color.Black;
            this.txtbuscuenta.Format = null;
            this.txtbuscuenta.Location = new System.Drawing.Point(15, 47);
            this.txtbuscuenta.MaxLength = 100;
            this.txtbuscuenta.Name = "txtbuscuenta";
            this.txtbuscuenta.NextControlOnEnter = null;
            this.txtbuscuenta.Size = new System.Drawing.Size(142, 21);
            this.txtbuscuenta.TabIndex = 423;
            this.txtbuscuenta.Text = "Buscar Cuenta";
            this.txtbuscuenta.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtbuscuenta.TextoDefecto = "Buscar Cuenta";
            this.txtbuscuenta.TextoDefectoColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(129)))), ((int)(((byte)(189)))));
            this.txtbuscuenta.TiposDatos = HpResergerUserControls.TextBoxPer.ListaTipos.MayusculaCadaPalabra;
            // 
            // btncleanfind
            // 
            this.btncleanfind.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btncleanfind.Image = ((System.Drawing.Image)(resources.GetObject("btncleanfind.Image")));
            this.btncleanfind.Location = new System.Drawing.Point(705, 46);
            this.btncleanfind.Name = "btncleanfind";
            this.btncleanfind.Size = new System.Drawing.Size(25, 23);
            this.btncleanfind.TabIndex = 429;
            this.btncleanfind.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btncleanfind.UseVisualStyleBackColor = true;
            this.btncleanfind.Click += new System.EventHandler(this.btncleanfind_Click);
            // 
            // dtpfechaini
            // 
            this.dtpfechaini.CalendarForeColor = System.Drawing.Color.Fuchsia;
            this.dtpfechaini.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.dtpfechaini.CalendarTitleBackColor = System.Drawing.Color.Blue;
            this.dtpfechaini.CalendarTitleForeColor = System.Drawing.Color.Red;
            this.dtpfechaini.CalendarTrailingForeColor = System.Drawing.Color.Lime;
            this.dtpfechaini.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpfechaini.Location = new System.Drawing.Point(240, 46);
            this.dtpfechaini.Name = "dtpfechaini";
            this.dtpfechaini.Size = new System.Drawing.Size(93, 22);
            this.dtpfechaini.TabIndex = 427;
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.BackColor = System.Drawing.Color.Transparent;
            this.lbl2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lbl2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(129)))), ((int)(((byte)(189)))));
            this.lbl2.Location = new System.Drawing.Point(333, 50);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(79, 15);
            this.lbl2.TabIndex = 420;
            this.lbl2.Text = "Fecha Hasta:";
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.BackColor = System.Drawing.Color.Transparent;
            this.lbl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lbl1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(129)))), ((int)(((byte)(189)))));
            this.lbl1.Location = new System.Drawing.Point(157, 50);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(83, 15);
            this.lbl1.TabIndex = 421;
            this.lbl1.Text = "Fecha Desde:";
            // 
            // dtpfechafin
            // 
            this.dtpfechafin.CalendarForeColor = System.Drawing.Color.Fuchsia;
            this.dtpfechafin.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.dtpfechafin.CalendarTitleBackColor = System.Drawing.Color.Blue;
            this.dtpfechafin.CalendarTitleForeColor = System.Drawing.Color.Red;
            this.dtpfechafin.CalendarTrailingForeColor = System.Drawing.Color.Lime;
            this.dtpfechafin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpfechafin.Location = new System.Drawing.Point(412, 46);
            this.dtpfechafin.Name = "dtpfechafin";
            this.dtpfechafin.Size = new System.Drawing.Size(93, 22);
            this.dtpfechafin.TabIndex = 428;
            // 
            // txtbusSuboperacion
            // 
            this.txtbusSuboperacion.BackColor = System.Drawing.Color.White;
            this.txtbusSuboperacion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtbusSuboperacion.ColorFondoMouseEncima = System.Drawing.Color.Empty;
            this.txtbusSuboperacion.ColorFondoMousePresionado = System.Drawing.Color.Empty;
            this.txtbusSuboperacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbusSuboperacion.ForeColor = System.Drawing.Color.Black;
            this.txtbusSuboperacion.Format = null;
            this.txtbusSuboperacion.Location = new System.Drawing.Point(652, 22);
            this.txtbusSuboperacion.MaxLength = 100;
            this.txtbusSuboperacion.Name = "txtbusSuboperacion";
            this.txtbusSuboperacion.NextControlOnEnter = null;
            this.txtbusSuboperacion.Size = new System.Drawing.Size(170, 21);
            this.txtbusSuboperacion.TabIndex = 424;
            this.txtbusSuboperacion.Text = "Buscar Suboperación";
            this.txtbusSuboperacion.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtbusSuboperacion.TextoDefecto = "Buscar Suboperación";
            this.txtbusSuboperacion.TextoDefectoColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(129)))), ((int)(((byte)(189)))));
            this.txtbusSuboperacion.TiposDatos = HpResergerUserControls.TextBoxPer.ListaTipos.MayusculaCadaPalabra;
            // 
            // txtbusGlosa
            // 
            this.txtbusGlosa.BackColor = System.Drawing.Color.White;
            this.txtbusGlosa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtbusGlosa.ColorFondoMouseEncima = System.Drawing.Color.Empty;
            this.txtbusGlosa.ColorFondoMousePresionado = System.Drawing.Color.Empty;
            this.txtbusGlosa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbusGlosa.ForeColor = System.Drawing.Color.Black;
            this.txtbusGlosa.Format = null;
            this.txtbusGlosa.Location = new System.Drawing.Point(434, 22);
            this.txtbusGlosa.MaxLength = 100;
            this.txtbusGlosa.Name = "txtbusGlosa";
            this.txtbusGlosa.NextControlOnEnter = null;
            this.txtbusGlosa.Size = new System.Drawing.Size(212, 21);
            this.txtbusGlosa.TabIndex = 425;
            this.txtbusGlosa.Text = "Buscar Glosa";
            this.txtbusGlosa.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtbusGlosa.TextoDefecto = "Buscar Glosa";
            this.txtbusGlosa.TextoDefectoColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(129)))), ((int)(((byte)(189)))));
            this.txtbusGlosa.TiposDatos = HpResergerUserControls.TextBoxPer.ListaTipos.MayusculaCadaPalabra;
            // 
            // txtbuscuo
            // 
            this.txtbuscuo.BackColor = System.Drawing.Color.White;
            this.txtbuscuo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtbuscuo.ColorFondoMouseEncima = System.Drawing.Color.Empty;
            this.txtbuscuo.ColorFondoMousePresionado = System.Drawing.Color.Empty;
            this.txtbuscuo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbuscuo.ForeColor = System.Drawing.Color.Black;
            this.txtbuscuo.Format = null;
            this.txtbuscuo.Location = new System.Drawing.Point(275, 22);
            this.txtbuscuo.MaxLength = 100;
            this.txtbuscuo.Name = "txtbuscuo";
            this.txtbuscuo.NextControlOnEnter = null;
            this.txtbuscuo.Size = new System.Drawing.Size(155, 21);
            this.txtbuscuo.TabIndex = 426;
            this.txtbuscuo.Text = "Buscar Cuo";
            this.txtbuscuo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtbuscuo.TextoDefecto = "Buscar Cuo";
            this.txtbuscuo.TextoDefectoColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(129)))), ((int)(((byte)(189)))));
            this.txtbuscuo.TiposDatos = HpResergerUserControls.TextBoxPer.ListaTipos.MayusculaCadaPalabra;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscar.Image")));
            this.btnBuscar.Location = new System.Drawing.Point(730, 46);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(92, 23);
            this.btnBuscar.TabIndex = 422;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // dtgconten
            // 
            this.dtgconten.AllowUserToAddRows = false;
            this.dtgconten.AllowUserToDeleteRows = false;
            this.dtgconten.AllowUserToResizeColumns = false;
            this.dtgconten.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(230)))), ((int)(((byte)(241)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(191)))), ((int)(((byte)(231)))));
            this.dtgconten.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgconten.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgconten.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgconten.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(218)))), ((int)(((byte)(231)))));
            this.dtgconten.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dtgconten.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dtgconten.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(129)))), ((int)(((byte)(189)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DeepSkyBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgconten.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dtgconten.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dtgconten.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idx,
            this.Codidasiento,
            this.xperiodo,
            this.Fechax,
            this.fechavalorx,
            this.SubOperacionx,
            this.Iddinamica,
            this.Estadox,
            this.empresax,
            this.proyectox,
            this.etapax,
            this.nameestado,
            this.Fecha_Asientox,
            this.xglosa,
            this.xmoneda,
            this.xtc});
            this.dtgconten.Cursor = System.Windows.Forms.Cursors.Default;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(207)))), ((int)(((byte)(241)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgconten.DefaultCellStyle = dataGridViewCellStyle5;
            this.dtgconten.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dtgconten.EnableHeadersVisualStyles = false;
            this.dtgconten.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(179)))), ((int)(((byte)(215)))));
            this.dtgconten.Location = new System.Drawing.Point(12, 92);
            this.dtgconten.MultiSelect = false;
            this.dtgconten.Name = "dtgconten";
            this.dtgconten.ReadOnly = true;
            this.dtgconten.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dtgconten.RowHeadersVisible = false;
            this.dtgconten.RowTemplate.Height = 16;
            this.dtgconten.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgconten.Size = new System.Drawing.Size(810, 338);
            this.dtgconten.TabIndex = 419;
            // 
            // btncancelar
            // 
            this.btncancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btncancelar.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncancelar.Image = ((System.Drawing.Image)(resources.GetObject("btncancelar.Image")));
            this.btncancelar.Location = new System.Drawing.Point(730, 433);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(92, 23);
            this.btncancelar.TabIndex = 430;
            this.btncancelar.Text = "Cancelar";
            this.btncancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btncancelar.UseVisualStyleBackColor = true;
            this.btncancelar.Click += new System.EventHandler(this.btncancelar_Click);
            // 
            // lblmsg
            // 
            this.lblmsg.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblmsg.AutoSize = true;
            this.lblmsg.BackColor = System.Drawing.Color.Transparent;
            this.lblmsg.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmsg.Location = new System.Drawing.Point(12, 438);
            this.lblmsg.Name = "lblmsg";
            this.lblmsg.Size = new System.Drawing.Size(88, 13);
            this.lblmsg.TabIndex = 431;
            this.lblmsg.Text = "Total Registros: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 13);
            this.label1.TabIndex = 431;
            this.label1.Text = "Listado de Asientos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 13);
            this.label2.TabIndex = 431;
            this.label2.Text = "Opciones de Filtrado:";
            // 
            // separadorOre1
            // 
            this.separadorOre1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.separadorOre1.BackColor = System.Drawing.Color.Transparent;
            this.separadorOre1.Location = new System.Drawing.Point(0, 70);
            this.separadorOre1.MaximumSize = new System.Drawing.Size(2000, 2);
            this.separadorOre1.MinimumSize = new System.Drawing.Size(0, 2);
            this.separadorOre1.Name = "separadorOre1";
            this.separadorOre1.Size = new System.Drawing.Size(850, 2);
            this.separadorOre1.TabIndex = 432;
            // 
            // cboempresa
            // 
            this.cboempresa.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboempresa.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboempresa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(218)))), ((int)(((byte)(231)))));
            this.cboempresa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboempresa.DropDownWidth = 250;
            this.cboempresa.FormattingEnabled = true;
            this.cboempresa.Location = new System.Drawing.Point(15, 22);
            this.cboempresa.Name = "cboempresa";
            this.cboempresa.Size = new System.Drawing.Size(254, 21);
            this.cboempresa.TabIndex = 433;
            this.cboempresa.Click += new System.EventHandler(this.cboempresa_Click);
            // 
            // btnpdf
            // 
            this.btnpdf.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnpdf.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(129)))), ((int)(((byte)(189)))));
            this.btnpdf.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnpdf.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnpdf.ForeColor = System.Drawing.Color.White;
            this.btnpdf.Image = ((System.Drawing.Image)(resources.GetObject("btnpdf.Image")));
            this.btnpdf.Location = new System.Drawing.Point(371, 432);
            this.btnpdf.Name = "btnpdf";
            this.btnpdf.Size = new System.Drawing.Size(92, 25);
            this.btnpdf.TabIndex = 430;
            this.btnpdf.Text = "Crear Pdf";
            this.btnpdf.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnpdf.UseVisualStyleBackColor = false;
            this.btnpdf.Click += new System.EventHandler(this.btnpdf_Click);
            // 
            // rbActivo
            // 
            this.rbActivo.AutoSize = true;
            this.rbActivo.BackColor = System.Drawing.Color.Transparent;
            this.rbActivo.Checked = true;
            this.rbActivo.Location = new System.Drawing.Point(516, 49);
            this.rbActivo.Name = "rbActivo";
            this.rbActivo.Size = new System.Drawing.Size(56, 17);
            this.rbActivo.TabIndex = 434;
            this.rbActivo.TabStop = true;
            this.rbActivo.Text = "Activo";
            this.rbActivo.UseVisualStyleBackColor = false;
            // 
            // rbReversado
            // 
            this.rbReversado.AutoSize = true;
            this.rbReversado.BackColor = System.Drawing.Color.Transparent;
            this.rbReversado.Location = new System.Drawing.Point(572, 49);
            this.rbReversado.Name = "rbReversado";
            this.rbReversado.Size = new System.Drawing.Size(78, 17);
            this.rbReversado.TabIndex = 434;
            this.rbReversado.Text = "Reversado";
            this.rbReversado.UseVisualStyleBackColor = false;
            // 
            // rbTodos
            // 
            this.rbTodos.AutoSize = true;
            this.rbTodos.BackColor = System.Drawing.Color.Transparent;
            this.rbTodos.Location = new System.Drawing.Point(650, 49);
            this.rbTodos.Name = "rbTodos";
            this.rbTodos.Size = new System.Drawing.Size(55, 17);
            this.rbTodos.TabIndex = 434;
            this.rbTodos.Text = "Todos";
            this.rbTodos.UseVisualStyleBackColor = false;
            // 
            // idx
            // 
            this.idx.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCellsExceptHeader;
            this.idx.DataPropertyName = "id";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.idx.DefaultCellStyle = dataGridViewCellStyle3;
            this.idx.HeaderText = "Num";
            this.idx.MinimumWidth = 40;
            this.idx.Name = "idx";
            this.idx.ReadOnly = true;
            this.idx.Width = 40;
            // 
            // Codidasiento
            // 
            this.Codidasiento.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Codidasiento.DataPropertyName = "cuo";
            this.Codidasiento.HeaderText = "Cuo";
            this.Codidasiento.Name = "Codidasiento";
            this.Codidasiento.ReadOnly = true;
            this.Codidasiento.Width = 51;
            // 
            // xperiodo
            // 
            this.xperiodo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.xperiodo.DataPropertyName = "periodo";
            this.xperiodo.HeaderText = "Periodo";
            this.xperiodo.Name = "xperiodo";
            this.xperiodo.ReadOnly = true;
            this.xperiodo.Visible = false;
            this.xperiodo.Width = 70;
            // 
            // Fechax
            // 
            this.Fechax.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Fechax.DataPropertyName = "fecha";
            this.Fechax.HeaderText = "Fecha";
            this.Fechax.Name = "Fechax";
            this.Fechax.ReadOnly = true;
            this.Fechax.Width = 60;
            // 
            // fechavalorx
            // 
            this.fechavalorx.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.fechavalorx.DataPropertyName = "fechavalor";
            dataGridViewCellStyle4.Format = "dd/MM/yyyy";
            dataGridViewCellStyle4.NullValue = null;
            this.fechavalorx.DefaultCellStyle = dataGridViewCellStyle4;
            this.fechavalorx.FillWeight = 70F;
            this.fechavalorx.HeaderText = "Fec.Valor";
            this.fechavalorx.MinimumWidth = 70;
            this.fechavalorx.Name = "fechavalorx";
            this.fechavalorx.ReadOnly = true;
            this.fechavalorx.Width = 76;
            // 
            // SubOperacionx
            // 
            this.SubOperacionx.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.SubOperacionx.DataPropertyName = "sub-operacion";
            this.SubOperacionx.HeaderText = "SubOperación";
            this.SubOperacionx.MinimumWidth = 100;
            this.SubOperacionx.Name = "SubOperacionx";
            this.SubOperacionx.ReadOnly = true;
            this.SubOperacionx.Width = 104;
            // 
            // Iddinamica
            // 
            this.Iddinamica.DataPropertyName = "iddinamica";
            this.Iddinamica.HeaderText = "IDdinamica";
            this.Iddinamica.Name = "Iddinamica";
            this.Iddinamica.ReadOnly = true;
            this.Iddinamica.Visible = false;
            // 
            // Estadox
            // 
            this.Estadox.DataPropertyName = "estado";
            this.Estadox.HeaderText = "Estado";
            this.Estadox.Name = "Estadox";
            this.Estadox.ReadOnly = true;
            this.Estadox.Visible = false;
            // 
            // empresax
            // 
            this.empresax.DataPropertyName = "empresa";
            this.empresax.HeaderText = "empresa";
            this.empresax.Name = "empresax";
            this.empresax.ReadOnly = true;
            this.empresax.Visible = false;
            // 
            // proyectox
            // 
            this.proyectox.DataPropertyName = "proyecto";
            this.proyectox.HeaderText = "proyecto";
            this.proyectox.Name = "proyectox";
            this.proyectox.ReadOnly = true;
            this.proyectox.Visible = false;
            // 
            // etapax
            // 
            this.etapax.DataPropertyName = "etapa";
            this.etapax.HeaderText = "etapa";
            this.etapax.Name = "etapax";
            this.etapax.ReadOnly = true;
            this.etapax.Visible = false;
            // 
            // nameestado
            // 
            this.nameestado.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.nameestado.DataPropertyName = "estados";
            this.nameestado.HeaderText = "Estado";
            this.nameestado.MinimumWidth = 50;
            this.nameestado.Name = "nameestado";
            this.nameestado.ReadOnly = true;
            this.nameestado.Width = 65;
            // 
            // Fecha_Asientox
            // 
            this.Fecha_Asientox.DataPropertyName = "Fecha_Asiento";
            this.Fecha_Asientox.HeaderText = "Fecha_Asiento";
            this.Fecha_Asientox.Name = "Fecha_Asientox";
            this.Fecha_Asientox.ReadOnly = true;
            this.Fecha_Asientox.Visible = false;
            // 
            // xglosa
            // 
            this.xglosa.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.xglosa.DataPropertyName = "glosa";
            this.xglosa.HeaderText = "Glosa";
            this.xglosa.MinimumWidth = 100;
            this.xglosa.Name = "xglosa";
            this.xglosa.ReadOnly = true;
            // 
            // xmoneda
            // 
            this.xmoneda.DataPropertyName = "moneda";
            this.xmoneda.HeaderText = "moneda";
            this.xmoneda.Name = "xmoneda";
            this.xmoneda.ReadOnly = true;
            this.xmoneda.Visible = false;
            // 
            // xtc
            // 
            this.xtc.DataPropertyName = "tc";
            this.xtc.HeaderText = "tc";
            this.xtc.Name = "xtc";
            this.xtc.ReadOnly = true;
            this.xtc.Visible = false;
            // 
            // frmListadoAsientosContables
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 461);
            this.Controls.Add(this.rbReversado);
            this.Controls.Add(this.rbTodos);
            this.Controls.Add(this.rbActivo);
            this.Controls.Add(this.cboempresa);
            this.Controls.Add(this.separadorOre1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblmsg);
            this.Controls.Add(this.btnpdf);
            this.Controls.Add(this.btncancelar);
            this.Controls.Add(this.txtbuscuenta);
            this.Controls.Add(this.btncleanfind);
            this.Controls.Add(this.dtpfechaini);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.dtpfechafin);
            this.Controls.Add(this.txtbusSuboperacion);
            this.Controls.Add(this.txtbusGlosa);
            this.Controls.Add(this.txtbuscuo);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.dtgconten);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.MinimumSize = new System.Drawing.Size(850, 500);
            this.Name = "frmListadoAsientosContables";
            this.Nombre = "Listado de Asientos Contables";
            this.Text = "Listado de Asientos Contables";
            this.Load += new System.EventHandler(this.frmListadoAsientosContables_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgconten)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private HpResergerUserControls.TextBoxPer txtbuscuenta;
        private System.Windows.Forms.Button btncleanfind;
        private System.Windows.Forms.DateTimePicker dtpfechaini;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.DateTimePicker dtpfechafin;
        private HpResergerUserControls.TextBoxPer txtbusSuboperacion;
        private HpResergerUserControls.TextBoxPer txtbusGlosa;
        private HpResergerUserControls.TextBoxPer txtbuscuo;
        private System.Windows.Forms.Button btnBuscar;
        private HpResergerUserControls.Dtgconten dtgconten;
        private System.Windows.Forms.Button btncancelar;
        private System.Windows.Forms.Label lblmsg;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private HpResergerUserControls.SeparadorOre separadorOre1;
        private System.Windows.Forms.ComboBox cboempresa;
        private System.Windows.Forms.Button btnpdf;
        private System.Windows.Forms.RadioButton rbActivo;
        private System.Windows.Forms.RadioButton rbReversado;
        private System.Windows.Forms.RadioButton rbTodos;
        private System.Windows.Forms.DataGridViewTextBoxColumn idx;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codidasiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn xperiodo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fechax;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechavalorx;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubOperacionx;
        private System.Windows.Forms.DataGridViewTextBoxColumn Iddinamica;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estadox;
        private System.Windows.Forms.DataGridViewTextBoxColumn empresax;
        private System.Windows.Forms.DataGridViewTextBoxColumn proyectox;
        private System.Windows.Forms.DataGridViewTextBoxColumn etapax;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameestado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha_Asientox;
        private System.Windows.Forms.DataGridViewTextBoxColumn xglosa;
        private System.Windows.Forms.DataGridViewTextBoxColumn xmoneda;
        private System.Windows.Forms.DataGridViewTextBoxColumn xtc;
    }
}