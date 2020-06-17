namespace HPReserger.ModuloRRHH
{
    partial class frmBonosEmpleados
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBonosEmpleados));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dtgconten = new HpResergerUserControls.Dtgconten();
            this.lblexcel = new System.Windows.Forms.Label();
            this.BtnCerrar = new HpResergerUserControls.ButtonPer();
            this.lblRegistros = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cboFecha = new HpResergerUserControls.ComboMesAño();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtImporte = new HpResergerUserControls.TextBoxPer();
            this.cboempleado = new HpResergerUserControls.ComboBoxPer(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.txtImagen = new HpResergerUserControls.TextBoxPer();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.lblVerImagen = new System.Windows.Forms.LinkLabel();
            this.lblBuscarEmpleado = new System.Windows.Forms.LinkLabel();
            this.pboFoto = new System.Windows.Forms.PictureBox();
            this.btnCargarImagen = new System.Windows.Forms.Button();
            this.btnAceptar = new HpResergerUserControls.ButtonPer();
            this.btnExcel = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtbusEmpleado = new HpResergerUserControls.TextBoxPer();
            this.label7 = new System.Windows.Forms.Label();
            this.txtbusImporteDE = new HpResergerUserControls.TextBoxPer();
            this.label8 = new System.Windows.Forms.Label();
            this.txtbusImporteA = new HpResergerUserControls.TextBoxPer();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnlimpiar = new System.Windows.Forms.Button();
            this.cbofechafin = new HpResergerUserControls.ComboMesAño();
            this.cbofechaini = new HpResergerUserControls.ComboMesAño();
            this.separadorOre1 = new HpResergerUserControls.SeparadorOre();
            this.separadorOre2 = new HpResergerUserControls.SeparadorOre();
            this.xpkid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xtipodoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xnrodoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xempleado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xperiodo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ximpornte = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ximagen = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtgconten)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboFoto)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgconten
            // 
            this.dtgconten.AllowUserToAddRows = false;
            this.dtgconten.AllowUserToOrderColumns = true;
            this.dtgconten.AllowUserToResizeColumns = false;
            this.dtgconten.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(230)))), ((int)(((byte)(241)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(191)))), ((int)(((byte)(231)))));
            this.dtgconten.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgconten.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgconten.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
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
            this.dtgconten.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dtgconten.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.xpkid,
            this.xtipodoc,
            this.xnrodoc,
            this.xempleado,
            this.xperiodo,
            this.ximpornte,
            this.ximagen});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(207)))), ((int)(((byte)(241)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgconten.DefaultCellStyle = dataGridViewCellStyle5;
            this.dtgconten.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dtgconten.EnableHeadersVisualStyles = false;
            this.dtgconten.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(179)))), ((int)(((byte)(215)))));
            this.dtgconten.Location = new System.Drawing.Point(12, 183);
            this.dtgconten.Name = "dtgconten";
            this.dtgconten.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dtgconten.RowHeadersVisible = false;
            this.dtgconten.RowTemplate.Height = 18;
            this.dtgconten.Size = new System.Drawing.Size(750, 342);
            this.dtgconten.TabIndex = 17;
            this.dtgconten.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgconten_RowEnter);
            // 
            // lblexcel
            // 
            this.lblexcel.AutoSize = true;
            this.lblexcel.BackColor = System.Drawing.Color.Transparent;
            this.lblexcel.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblexcel.Location = new System.Drawing.Point(12, 170);
            this.lblexcel.Name = "lblexcel";
            this.lblexcel.Size = new System.Drawing.Size(221, 13);
            this.lblexcel.TabIndex = 189;
            this.lblexcel.Text = "Listado de Comisiones de los Empleados:";
            // 
            // BtnCerrar
            // 
            this.BtnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnCerrar.BackColor = System.Drawing.Color.Crimson;
            this.BtnCerrar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnCerrar.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.BtnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCerrar.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCerrar.ForeColor = System.Drawing.Color.White;
            this.BtnCerrar.Location = new System.Drawing.Point(679, 531);
            this.BtnCerrar.Name = "BtnCerrar";
            this.BtnCerrar.Size = new System.Drawing.Size(83, 24);
            this.BtnCerrar.TabIndex = 20;
            this.BtnCerrar.Text = "Cancelar";
            this.BtnCerrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnCerrar.UseVisualStyleBackColor = false;
            this.BtnCerrar.Click += new System.EventHandler(this.BtnCerrar_Click);
            // 
            // lblRegistros
            // 
            this.lblRegistros.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblRegistros.AutoSize = true;
            this.lblRegistros.BackColor = System.Drawing.Color.Transparent;
            this.lblRegistros.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegistros.Location = new System.Drawing.Point(12, 537);
            this.lblRegistros.Name = "lblRegistros";
            this.lblRegistros.Size = new System.Drawing.Size(94, 13);
            this.lblRegistros.TabIndex = 192;
            this.lblRegistros.Text = "Total Registros: 0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 13);
            this.label1.TabIndex = 193;
            this.label1.Text = "Datos de la Comisión:";
            // 
            // cboFecha
            // 
            this.cboFecha.BackColor = System.Drawing.Color.Transparent;
            this.cboFecha.FechaConDiaActual = new System.DateTime(2020, 6, 17, 0, 0, 0, 0);
            this.cboFecha.FechaFinMes = new System.DateTime(2020, 6, 30, 0, 0, 0, 0);
            this.cboFecha.FechaInicioMes = new System.DateTime(2020, 6, 1, 0, 0, 0, 0);
            this.cboFecha.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboFecha.Location = new System.Drawing.Point(76, 50);
            this.cboFecha.Name = "cboFecha";
            this.cboFecha.Size = new System.Drawing.Size(197, 23);
            this.cboFecha.TabIndex = 5;
            this.cboFecha.VerAño = true;
            this.cboFecha.VerMes = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label2.Location = new System.Drawing.Point(12, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 15);
            this.label2.TabIndex = 193;
            this.label2.Text = "Empleado:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label3.Location = new System.Drawing.Point(12, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 15);
            this.label3.TabIndex = 193;
            this.label3.Text = "Periodo:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label4.Location = new System.Drawing.Point(320, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 15);
            this.label4.TabIndex = 193;
            this.label4.Text = "Importe:";
            // 
            // txtImporte
            // 
            this.txtImporte.BackColor = System.Drawing.Color.White;
            this.txtImporte.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtImporte.ColorFondoMouseEncima = System.Drawing.Color.Empty;
            this.txtImporte.ColorFondoMousePresionado = System.Drawing.Color.Empty;
            this.txtImporte.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.txtImporte.ForeColor = System.Drawing.Color.Black;
            this.txtImporte.Format = "n2";
            this.txtImporte.Location = new System.Drawing.Point(384, 51);
            this.txtImporte.MaxLength = 100;
            this.txtImporte.Name = "txtImporte";
            this.txtImporte.NextControlOnEnter = null;
            this.txtImporte.Size = new System.Drawing.Size(197, 21);
            this.txtImporte.TabIndex = 6;
            this.txtImporte.Text = "0.00";
            this.txtImporte.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtImporte.TextoDefecto = "0.00";
            this.txtImporte.TextoDefectoColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(129)))), ((int)(((byte)(189)))));
            this.txtImporte.TiposDatos = HpResergerUserControls.TextBoxPer.ListaTipos.SoloDinero;
            // 
            // cboempleado
            // 
            this.cboempleado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(218)))), ((int)(((byte)(231)))));
            this.cboempleado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboempleado.FormattingEnabled = true;
            this.cboempleado.IndexText = null;
            this.cboempleado.Location = new System.Drawing.Point(76, 27);
            this.cboempleado.Name = "cboempleado";
            this.cboempleado.ReadOnly = false;
            this.cboempleado.Size = new System.Drawing.Size(553, 21);
            this.cboempleado.TabIndex = 3;
            this.cboempleado.Click += new System.EventHandler(this.cboempleado_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label5.Location = new System.Drawing.Point(12, 79);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 15);
            this.label5.TabIndex = 193;
            this.label5.Text = "Sustento:";
            // 
            // txtImagen
            // 
            this.txtImagen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(218)))), ((int)(((byte)(231)))));
            this.txtImagen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtImagen.ColorFondoMouseEncima = System.Drawing.Color.Empty;
            this.txtImagen.ColorFondoMousePresionado = System.Drawing.Color.Empty;
            this.txtImagen.Enabled = false;
            this.txtImagen.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtImagen.ForeColor = System.Drawing.Color.Black;
            this.txtImagen.Format = null;
            this.txtImagen.Location = new System.Drawing.Point(76, 75);
            this.txtImagen.MaxLength = 100;
            this.txtImagen.Name = "txtImagen";
            this.txtImagen.NextControlOnEnter = null;
            this.txtImagen.ReadOnly = true;
            this.txtImagen.Size = new System.Drawing.Size(505, 23);
            this.txtImagen.TabIndex = 7;
            this.txtImagen.TextoDefecto = "";
            this.txtImagen.TextoDefectoColor = System.Drawing.Color.Black;
            this.txtImagen.TiposDatos = HpResergerUserControls.TextBoxPer.ListaTipos.Todo;
            // 
            // btnNuevo
            // 
            this.btnNuevo.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevo.Image = ((System.Drawing.Image)(resources.GetObject("btnNuevo.Image")));
            this.btnNuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNuevo.Location = new System.Drawing.Point(679, 25);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(83, 24);
            this.btnNuevo.TabIndex = 0;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Enabled = false;
            this.btnModificar.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.Image = ((System.Drawing.Image)(resources.GetObject("btnModificar.Image")));
            this.btnModificar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnModificar.Location = new System.Drawing.Point(679, 49);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(83, 24);
            this.btnModificar.TabIndex = 1;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnModificar.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Enabled = false;
            this.btnEliminar.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminar.Image")));
            this.btnEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEliminar.Location = new System.Drawing.Point(679, 74);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(83, 24);
            this.btnEliminar.TabIndex = 2;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // lblVerImagen
            // 
            this.lblVerImagen.AutoSize = true;
            this.lblVerImagen.BackColor = System.Drawing.Color.Transparent;
            this.lblVerImagen.Enabled = false;
            this.lblVerImagen.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblVerImagen.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(129)))), ((int)(((byte)(189)))));
            this.lblVerImagen.Location = new System.Drawing.Point(604, 79);
            this.lblVerImagen.Name = "lblVerImagen";
            this.lblVerImagen.Size = new System.Drawing.Size(70, 15);
            this.lblVerImagen.TabIndex = 9;
            this.lblVerImagen.TabStop = true;
            this.lblVerImagen.Text = "Ver Imagen";
            this.lblVerImagen.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblVerImagen_LinkClicked);
            // 
            // lblBuscarEmpleado
            // 
            this.lblBuscarEmpleado.AutoSize = true;
            this.lblBuscarEmpleado.BackColor = System.Drawing.Color.Transparent;
            this.lblBuscarEmpleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblBuscarEmpleado.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(129)))), ((int)(((byte)(189)))));
            this.lblBuscarEmpleado.Location = new System.Drawing.Point(629, 30);
            this.lblBuscarEmpleado.Name = "lblBuscarEmpleado";
            this.lblBuscarEmpleado.Size = new System.Drawing.Size(45, 15);
            this.lblBuscarEmpleado.TabIndex = 4;
            this.lblBuscarEmpleado.TabStop = true;
            this.lblBuscarEmpleado.Text = "Buscar";
            this.lblBuscarEmpleado.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblBuscarEmpleado_LinkClicked);
            // 
            // pboFoto
            // 
            this.pboFoto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pboFoto.Location = new System.Drawing.Point(573, -1);
            this.pboFoto.Name = "pboFoto";
            this.pboFoto.Size = new System.Drawing.Size(25, 25);
            this.pboFoto.TabIndex = 200;
            this.pboFoto.TabStop = false;
            this.pboFoto.Visible = false;
            // 
            // btnCargarImagen
            // 
            this.btnCargarImagen.BackColor = System.Drawing.Color.Transparent;
            this.btnCargarImagen.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCargarImagen.BackgroundImage")));
            this.btnCargarImagen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCargarImagen.FlatAppearance.BorderSize = 0;
            this.btnCargarImagen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCargarImagen.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCargarImagen.Location = new System.Drawing.Point(584, 76);
            this.btnCargarImagen.Margin = new System.Windows.Forms.Padding(0, 1, 0, 1);
            this.btnCargarImagen.Name = "btnCargarImagen";
            this.btnCargarImagen.Size = new System.Drawing.Size(20, 20);
            this.btnCargarImagen.TabIndex = 8;
            this.btnCargarImagen.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCargarImagen.UseVisualStyleBackColor = false;
            this.btnCargarImagen.Click += new System.EventHandler(this.btnfirma_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAceptar.BackColor = System.Drawing.Color.SeaGreen;
            this.btnAceptar.Enabled = false;
            this.btnAceptar.FlatAppearance.BorderColor = System.Drawing.Color.Olive;
            this.btnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAceptar.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptar.ForeColor = System.Drawing.Color.White;
            this.btnAceptar.Location = new System.Drawing.Point(591, 531);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(83, 23);
            this.btnAceptar.TabIndex = 19;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAceptar.UseVisualStyleBackColor = false;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnExcel
            // 
            this.btnExcel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnExcel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcel.Image = ((System.Drawing.Image)(resources.GetObject("btnExcel.Image")));
            this.btnExcel.Location = new System.Drawing.Point(346, 530);
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.Size = new System.Drawing.Size(83, 24);
            this.btnExcel.TabIndex = 18;
            this.btnExcel.Text = "EXCEL";
            this.btnExcel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnExcel.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 105);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(129, 13);
            this.label6.TabIndex = 189;
            this.label6.Text = "Opciones de Busqueda:";
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
            this.txtbusEmpleado.Location = new System.Drawing.Point(15, 119);
            this.txtbusEmpleado.MaxLength = 600;
            this.txtbusEmpleado.Name = "txtbusEmpleado";
            this.txtbusEmpleado.NextControlOnEnter = null;
            this.txtbusEmpleado.Size = new System.Drawing.Size(662, 21);
            this.txtbusEmpleado.TabIndex = 10;
            this.txtbusEmpleado.Text = "Buscar Empleado";
            this.txtbusEmpleado.TextoDefecto = "Buscar Empleado";
            this.txtbusEmpleado.TextoDefectoColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(129)))), ((int)(((byte)(189)))));
            this.txtbusEmpleado.TiposDatos = HpResergerUserControls.TextBoxPer.ListaTipos.MayusculaCadaPalabra;
            this.txtbusEmpleado.TextChanged += new System.EventHandler(this.txtbusEmpleado_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(129)))), ((int)(((byte)(189)))));
            this.label7.Location = new System.Drawing.Point(445, 146);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 15);
            this.label7.TabIndex = 193;
            this.label7.Text = "Importe De:";
            // 
            // txtbusImporteDE
            // 
            this.txtbusImporteDE.BackColor = System.Drawing.Color.White;
            this.txtbusImporteDE.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtbusImporteDE.ColorFondoMouseEncima = System.Drawing.Color.Empty;
            this.txtbusImporteDE.ColorFondoMousePresionado = System.Drawing.Color.Empty;
            this.txtbusImporteDE.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.txtbusImporteDE.ForeColor = System.Drawing.Color.Black;
            this.txtbusImporteDE.Format = "n2";
            this.txtbusImporteDE.Location = new System.Drawing.Point(516, 143);
            this.txtbusImporteDE.MaxLength = 100;
            this.txtbusImporteDE.Name = "txtbusImporteDE";
            this.txtbusImporteDE.NextControlOnEnter = null;
            this.txtbusImporteDE.Size = new System.Drawing.Size(72, 21);
            this.txtbusImporteDE.TabIndex = 13;
            this.txtbusImporteDE.Text = "0.00";
            this.txtbusImporteDE.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtbusImporteDE.TextoDefecto = "0.00";
            this.txtbusImporteDE.TextoDefectoColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(129)))), ((int)(((byte)(189)))));
            this.txtbusImporteDE.TiposDatos = HpResergerUserControls.TextBoxPer.ListaTipos.SoloDinero;
            this.txtbusImporteDE.TextChanged += new System.EventHandler(this.txtbusImporteDE_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(129)))), ((int)(((byte)(189)))));
            this.label8.Location = new System.Drawing.Point(588, 146);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(17, 15);
            this.label8.TabIndex = 193;
            this.label8.Text = "A:";
            // 
            // txtbusImporteA
            // 
            this.txtbusImporteA.BackColor = System.Drawing.Color.White;
            this.txtbusImporteA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtbusImporteA.ColorFondoMouseEncima = System.Drawing.Color.Empty;
            this.txtbusImporteA.ColorFondoMousePresionado = System.Drawing.Color.Empty;
            this.txtbusImporteA.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.txtbusImporteA.ForeColor = System.Drawing.Color.Black;
            this.txtbusImporteA.Format = "n2";
            this.txtbusImporteA.Location = new System.Drawing.Point(605, 143);
            this.txtbusImporteA.MaxLength = 100;
            this.txtbusImporteA.Name = "txtbusImporteA";
            this.txtbusImporteA.NextControlOnEnter = null;
            this.txtbusImporteA.Size = new System.Drawing.Size(72, 21);
            this.txtbusImporteA.TabIndex = 14;
            this.txtbusImporteA.Text = "0.00";
            this.txtbusImporteA.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtbusImporteA.TextoDefecto = "0.00";
            this.txtbusImporteA.TextoDefectoColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(129)))), ((int)(((byte)(189)))));
            this.txtbusImporteA.TiposDatos = HpResergerUserControls.TextBoxPer.ListaTipos.SoloDinero;
            this.txtbusImporteA.TextChanged += new System.EventHandler(this.txtbusImporteA_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label9.Location = new System.Drawing.Point(233, 146);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(17, 15);
            this.label9.TabIndex = 205;
            this.label9.Text = "A:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(129)))), ((int)(((byte)(189)))));
            this.label10.Location = new System.Drawing.Point(12, 146);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(26, 15);
            this.label10.TabIndex = 206;
            this.label10.Text = "De:";
            // 
            // btnActualizar
            // 
            this.btnActualizar.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizar.Image = ((System.Drawing.Image)(resources.GetObject("btnActualizar.Image")));
            this.btnActualizar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnActualizar.Location = new System.Drawing.Point(679, 117);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(82, 24);
            this.btnActualizar.TabIndex = 15;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnlimpiar
            // 
            this.btnlimpiar.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlimpiar.Image = ((System.Drawing.Image)(resources.GetObject("btnlimpiar.Image")));
            this.btnlimpiar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnlimpiar.Location = new System.Drawing.Point(679, 141);
            this.btnlimpiar.Name = "btnlimpiar";
            this.btnlimpiar.Size = new System.Drawing.Size(82, 24);
            this.btnlimpiar.TabIndex = 16;
            this.btnlimpiar.Text = "Limpiar";
            this.btnlimpiar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnlimpiar.UseVisualStyleBackColor = true;
            this.btnlimpiar.Click += new System.EventHandler(this.btnlimpiar_Click);
            // 
            // cbofechafin
            // 
            this.cbofechafin.BackColor = System.Drawing.Color.Transparent;
            this.cbofechafin.FechaConDiaActual = new System.DateTime(2020, 6, 17, 0, 0, 0, 0);
            this.cbofechafin.FechaFinMes = new System.DateTime(2020, 6, 30, 0, 0, 0, 0);
            this.cbofechafin.FechaInicioMes = new System.DateTime(2020, 6, 1, 0, 0, 0, 0);
            this.cbofechafin.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbofechafin.Location = new System.Drawing.Point(250, 142);
            this.cbofechafin.Name = "cbofechafin";
            this.cbofechafin.Size = new System.Drawing.Size(197, 23);
            this.cbofechafin.TabIndex = 12;
            this.cbofechafin.VerAño = true;
            this.cbofechafin.VerMes = true;
            this.cbofechafin.CambioFechas += new System.EventHandler(this.cbofechafin_CambioFechas);
            // 
            // cbofechaini
            // 
            this.cbofechaini.BackColor = System.Drawing.Color.Transparent;
            this.cbofechaini.FechaConDiaActual = new System.DateTime(2020, 6, 17, 0, 0, 0, 0);
            this.cbofechaini.FechaFinMes = new System.DateTime(2020, 6, 30, 0, 0, 0, 0);
            this.cbofechaini.FechaInicioMes = new System.DateTime(2020, 6, 1, 0, 0, 0, 0);
            this.cbofechaini.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbofechaini.Location = new System.Drawing.Point(36, 142);
            this.cbofechaini.Name = "cbofechaini";
            this.cbofechaini.Size = new System.Drawing.Size(197, 23);
            this.cbofechaini.TabIndex = 11;
            this.cbofechaini.VerAño = true;
            this.cbofechaini.VerMes = true;
            this.cbofechaini.CambioFechas += new System.EventHandler(this.cbofechaini_CambioFechas);
            // 
            // separadorOre1
            // 
            this.separadorOre1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(129)))), ((int)(((byte)(189)))));
            this.separadorOre1.ForeColor = System.Drawing.Color.Black;
            this.separadorOre1.Location = new System.Drawing.Point(12, 100);
            this.separadorOre1.MaximumSize = new System.Drawing.Size(2000, 2);
            this.separadorOre1.MinimumSize = new System.Drawing.Size(0, 2);
            this.separadorOre1.Name = "separadorOre1";
            this.separadorOre1.Size = new System.Drawing.Size(749, 2);
            this.separadorOre1.TabIndex = 207;
            // 
            // separadorOre2
            // 
            this.separadorOre2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(129)))), ((int)(((byte)(189)))));
            this.separadorOre2.ForeColor = System.Drawing.Color.Black;
            this.separadorOre2.Location = new System.Drawing.Point(13, 167);
            this.separadorOre2.MaximumSize = new System.Drawing.Size(2000, 2);
            this.separadorOre2.MinimumSize = new System.Drawing.Size(0, 2);
            this.separadorOre2.Name = "separadorOre2";
            this.separadorOre2.Size = new System.Drawing.Size(749, 2);
            this.separadorOre2.TabIndex = 208;
            // 
            // xpkid
            // 
            this.xpkid.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.xpkid.DataPropertyName = "pkid";
            this.xpkid.HeaderText = "Id";
            this.xpkid.MinimumWidth = 30;
            this.xpkid.Name = "xpkid";
            this.xpkid.Width = 30;
            // 
            // xtipodoc
            // 
            this.xtipodoc.DataPropertyName = "tipodoc";
            this.xtipodoc.HeaderText = "tipodoc";
            this.xtipodoc.Name = "xtipodoc";
            this.xtipodoc.Visible = false;
            // 
            // xnrodoc
            // 
            this.xnrodoc.DataPropertyName = "nrodoc";
            this.xnrodoc.HeaderText = "nrodoc";
            this.xnrodoc.Name = "xnrodoc";
            this.xnrodoc.Visible = false;
            // 
            // xempleado
            // 
            this.xempleado.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.xempleado.DataPropertyName = "empleado";
            this.xempleado.HeaderText = "Empleado";
            this.xempleado.MinimumWidth = 150;
            this.xempleado.Name = "xempleado";
            // 
            // xperiodo
            // 
            this.xperiodo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.xperiodo.DataPropertyName = "periodo";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.Format = "MMMM/yyyy";
            this.xperiodo.DefaultCellStyle = dataGridViewCellStyle3;
            this.xperiodo.HeaderText = "Periodo";
            this.xperiodo.MinimumWidth = 80;
            this.xperiodo.Name = "xperiodo";
            this.xperiodo.Width = 80;
            // 
            // ximpornte
            // 
            this.ximpornte.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.ximpornte.DataPropertyName = "importe";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle4.Format = "n2";
            this.ximpornte.DefaultCellStyle = dataGridViewCellStyle4;
            this.ximpornte.HeaderText = "Importe";
            this.ximpornte.MinimumWidth = 70;
            this.ximpornte.Name = "ximpornte";
            this.ximpornte.Width = 70;
            // 
            // ximagen
            // 
            this.ximagen.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.ximagen.DataPropertyName = "imgsustento";
            this.ximagen.HeaderText = "Sustento";
            this.ximagen.MinimumWidth = 250;
            this.ximagen.Name = "ximagen";
            this.ximagen.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ximagen.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.ximagen.Width = 250;
            // 
            // frmBonosEmpleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(774, 561);
            this.Controls.Add(this.separadorOre2);
            this.Controls.Add(this.separadorOre1);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.txtbusEmpleado);
            this.Controls.Add(this.btnExcel);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.btnCargarImagen);
            this.Controls.Add(this.pboFoto);
            this.Controls.Add(this.lblBuscarEmpleado);
            this.Controls.Add(this.lblVerImagen);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.cboempleado);
            this.Controls.Add(this.txtImagen);
            this.Controls.Add(this.txtbusImporteA);
            this.Controls.Add(this.txtbusImporteDE);
            this.Controls.Add(this.txtImporte);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cboFecha);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblRegistros);
            this.Controls.Add(this.BtnCerrar);
            this.Controls.Add(this.dtgconten);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblexcel);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btnlimpiar);
            this.Controls.Add(this.cbofechafin);
            this.Controls.Add(this.cbofechaini);
            this.Controls.Add(this.label7);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinimumSize = new System.Drawing.Size(790, 600);
            this.Name = "frmBonosEmpleados";
            this.Nombre = "Comisiones de Empleados";
            this.Text = "Comisiones de Empleados";
            this.Load += new System.EventHandler(this.frmBonosEmpleados_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgconten)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboFoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private HpResergerUserControls.Dtgconten dtgconten;
        private System.Windows.Forms.Label lblexcel;
        private HpResergerUserControls.ButtonPer BtnCerrar;
        private System.Windows.Forms.Label lblRegistros;
        private System.Windows.Forms.Label label1;
        private HpResergerUserControls.ComboMesAño cboFecha;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private HpResergerUserControls.TextBoxPer txtImporte;
        private HpResergerUserControls.ComboBoxPer cboempleado;
        private System.Windows.Forms.Label label5;
        private HpResergerUserControls.TextBoxPer txtImagen;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.LinkLabel lblVerImagen;
        private System.Windows.Forms.LinkLabel lblBuscarEmpleado;
        private System.Windows.Forms.PictureBox pboFoto;
        private System.Windows.Forms.Button btnCargarImagen;
        private HpResergerUserControls.ButtonPer btnAceptar;
        private System.Windows.Forms.Button btnExcel;
        private System.Windows.Forms.Label label6;
        private HpResergerUserControls.TextBoxPer txtbusEmpleado;
        private System.Windows.Forms.Label label7;
        private HpResergerUserControls.TextBoxPer txtbusImporteDE;
        private System.Windows.Forms.Label label8;
        private HpResergerUserControls.TextBoxPer txtbusImporteA;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnlimpiar;
        private HpResergerUserControls.ComboMesAño cbofechafin;
        private HpResergerUserControls.ComboMesAño cbofechaini;
        private HpResergerUserControls.SeparadorOre separadorOre1;
        private HpResergerUserControls.SeparadorOre separadorOre2;
        private System.Windows.Forms.DataGridViewTextBoxColumn xpkid;
        private System.Windows.Forms.DataGridViewTextBoxColumn xtipodoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn xnrodoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn xempleado;
        private System.Windows.Forms.DataGridViewTextBoxColumn xperiodo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ximpornte;
        private System.Windows.Forms.DataGridViewImageColumn ximagen;
    }
}