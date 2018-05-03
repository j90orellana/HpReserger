namespace HPReserger
{
    partial class frmOtrosDescuentos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmOtrosDescuentos));
            this.panelOre3 = new HpResergerUserControls.PanelOre();
            this.dtgconten = new System.Windows.Forms.DataGridView();
            this.desvinculancion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.registro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipo_id_emp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nro_id_emp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Motivo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Importe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dscto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre_dscto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelOre2 = new HpResergerUserControls.PanelOre();
            this.lkldescuento = new System.Windows.Forms.LinkLabel();
            this.txtNumeroDocumento = new System.Windows.Forms.TextBox();
            this.cboTipoDocumento = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnaddfoto = new System.Windows.Forms.Button();
            this.txtdescuento = new HpResergerUserControls.TextBoxPer();
            this.txtimporte = new HpResergerUserControls.NumBox();
            this.txtmotivo = new HpResergerUserControls.TextBoxPer();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panelOre1 = new HpResergerUserControls.PanelOre();
            this.btneliminar = new System.Windows.Forms.Button();
            this.pbdescuento = new System.Windows.Forms.PictureBox();
            this.btnaceptar = new System.Windows.Forms.Button();
            this.btncancelar = new System.Windows.Forms.Button();
            this.btnmodificar = new System.Windows.Forms.Button();
            this.btnnuevo = new System.Windows.Forms.Button();
            this.panelOre3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgconten)).BeginInit();
            this.panelOre2.SuspendLayout();
            this.panelOre1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbdescuento)).BeginInit();
            this.SuspendLayout();
            // 
            // panelOre3
            // 
            this.panelOre3.BackColor = System.Drawing.SystemColors.Control;
            this.panelOre3.Controls.Add(this.dtgconten);
            this.panelOre3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelOre3.Location = new System.Drawing.Point(0, 152);
            this.panelOre3.Movible = false;
            this.panelOre3.Name = "panelOre3";
            this.panelOre3.Size = new System.Drawing.Size(404, 209);
            this.panelOre3.TabIndex = 154;
            // 
            // dtgconten
            // 
            this.dtgconten.AllowUserToAddRows = false;
            this.dtgconten.AllowUserToDeleteRows = false;
            this.dtgconten.AllowUserToResizeColumns = false;
            this.dtgconten.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.dtgconten.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgconten.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgconten.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgconten.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            this.dtgconten.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dtgconten.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dtgconten.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dtgconten.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Franklin Gothic Book", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgconten.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dtgconten.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgconten.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.desvinculancion,
            this.registro,
            this.tipo_id_emp,
            this.nro_id_emp,
            this.Motivo,
            this.Importe,
            this.dscto,
            this.nombre_dscto,
            this.usuario,
            this.fecha});
            this.dtgconten.Cursor = System.Windows.Forms.Cursors.Default;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgconten.DefaultCellStyle = dataGridViewCellStyle3;
            this.dtgconten.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dtgconten.Enabled = false;
            this.dtgconten.Location = new System.Drawing.Point(12, 6);
            this.dtgconten.MultiSelect = false;
            this.dtgconten.Name = "dtgconten";
            this.dtgconten.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgconten.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dtgconten.RowHeadersVisible = false;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Franklin Gothic Book", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtgconten.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dtgconten.RowTemplate.Height = 16;
            this.dtgconten.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgconten.Size = new System.Drawing.Size(386, 191);
            this.dtgconten.TabIndex = 152;
            this.dtgconten.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgconten_RowEnter);
            // 
            // desvinculancion
            // 
            this.desvinculancion.DataPropertyName = "desvinculacion";
            this.desvinculancion.HeaderText = "desvinculacion";
            this.desvinculancion.Name = "desvinculancion";
            this.desvinculancion.Visible = false;
            // 
            // registro
            // 
            this.registro.DataPropertyName = "registro";
            this.registro.HeaderText = "registro";
            this.registro.Name = "registro";
            this.registro.Visible = false;
            // 
            // tipo_id_emp
            // 
            this.tipo_id_emp.DataPropertyName = "tipo_id_emp";
            this.tipo_id_emp.HeaderText = "tipoid";
            this.tipo_id_emp.Name = "tipo_id_emp";
            this.tipo_id_emp.Visible = false;
            // 
            // nro_id_emp
            // 
            this.nro_id_emp.DataPropertyName = "nro_id_emp";
            this.nro_id_emp.HeaderText = "nrodoc";
            this.nro_id_emp.Name = "nro_id_emp";
            this.nro_id_emp.Visible = false;
            // 
            // Motivo
            // 
            this.Motivo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Motivo.DataPropertyName = "Motivo";
            this.Motivo.HeaderText = "Motivo";
            this.Motivo.MinimumWidth = 100;
            this.Motivo.Name = "Motivo";
            // 
            // Importe
            // 
            this.Importe.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Importe.DataPropertyName = "Importe";
            this.Importe.HeaderText = "Importe";
            this.Importe.MinimumWidth = 100;
            this.Importe.Name = "Importe";
            // 
            // dscto
            // 
            this.dscto.DataPropertyName = "dscto";
            this.dscto.HeaderText = "Descuento";
            this.dscto.Name = "dscto";
            this.dscto.Visible = false;
            // 
            // nombre_dscto
            // 
            this.nombre_dscto.DataPropertyName = "nombre_dscto";
            this.nombre_dscto.HeaderText = "nombre_dscto";
            this.nombre_dscto.Name = "nombre_dscto";
            this.nombre_dscto.Visible = false;
            // 
            // usuario
            // 
            this.usuario.DataPropertyName = "usuario";
            this.usuario.HeaderText = "usuario";
            this.usuario.Name = "usuario";
            this.usuario.Visible = false;
            // 
            // fecha
            // 
            this.fecha.DataPropertyName = "fecha";
            this.fecha.HeaderText = "fecha";
            this.fecha.Name = "fecha";
            this.fecha.Visible = false;
            // 
            // panelOre2
            // 
            this.panelOre2.BackColor = System.Drawing.SystemColors.Control;
            this.panelOre2.Controls.Add(this.lkldescuento);
            this.panelOre2.Controls.Add(this.txtNumeroDocumento);
            this.panelOre2.Controls.Add(this.cboTipoDocumento);
            this.panelOre2.Controls.Add(this.label4);
            this.panelOre2.Controls.Add(this.btnaddfoto);
            this.panelOre2.Controls.Add(this.txtdescuento);
            this.panelOre2.Controls.Add(this.txtimporte);
            this.panelOre2.Controls.Add(this.txtmotivo);
            this.panelOre2.Controls.Add(this.label3);
            this.panelOre2.Controls.Add(this.label2);
            this.panelOre2.Controls.Add(this.label1);
            this.panelOre2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelOre2.Location = new System.Drawing.Point(0, 0);
            this.panelOre2.Movible = false;
            this.panelOre2.Name = "panelOre2";
            this.panelOre2.Size = new System.Drawing.Size(404, 152);
            this.panelOre2.TabIndex = 153;
            this.panelOre2.Paint += new System.Windows.Forms.PaintEventHandler(this.panelOre2_Paint);
            // 
            // lkldescuento
            // 
            this.lkldescuento.AutoSize = true;
            this.lkldescuento.Location = new System.Drawing.Point(329, 121);
            this.lkldescuento.Name = "lkldescuento";
            this.lkldescuento.Size = new System.Drawing.Size(61, 13);
            this.lkldescuento.TabIndex = 76;
            this.lkldescuento.TabStop = true;
            this.lkldescuento.Text = "Ver Imagen";
            this.lkldescuento.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lkldescuento_LinkClicked);
            // 
            // txtNumeroDocumento
            // 
            this.txtNumeroDocumento.Enabled = false;
            this.txtNumeroDocumento.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.txtNumeroDocumento.Location = new System.Drawing.Point(215, 38);
            this.txtNumeroDocumento.MaxLength = 10;
            this.txtNumeroDocumento.Name = "txtNumeroDocumento";
            this.txtNumeroDocumento.Size = new System.Drawing.Size(180, 20);
            this.txtNumeroDocumento.TabIndex = 74;
            this.txtNumeroDocumento.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // cboTipoDocumento
            // 
            this.cboTipoDocumento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTipoDocumento.Enabled = false;
            this.cboTipoDocumento.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.cboTipoDocumento.FormattingEnabled = true;
            this.cboTipoDocumento.Location = new System.Drawing.Point(12, 37);
            this.cboTipoDocumento.Name = "cboTipoDocumento";
            this.cboTipoDocumento.Size = new System.Drawing.Size(197, 21);
            this.cboTipoDocumento.TabIndex = 75;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(103, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(198, 19);
            this.label4.TabIndex = 7;
            this.label4.Text = "Ingrese Otros Descuentos";
            // 
            // btnaddfoto
            // 
            this.btnaddfoto.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnaddfoto.BackgroundImage")));
            this.btnaddfoto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnaddfoto.FlatAppearance.BorderSize = 0;
            this.btnaddfoto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnaddfoto.Location = new System.Drawing.Point(296, 117);
            this.btnaddfoto.Name = "btnaddfoto";
            this.btnaddfoto.Size = new System.Drawing.Size(20, 20);
            this.btnaddfoto.TabIndex = 6;
            this.btnaddfoto.UseVisualStyleBackColor = true;
            this.btnaddfoto.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtdescuento
            // 
            this.txtdescuento.BackColor = System.Drawing.Color.White;
            this.txtdescuento.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtdescuento.ColorFondoMouseEncima = System.Drawing.Color.Empty;
            this.txtdescuento.ColorFondoMousePresionado = System.Drawing.Color.Empty;
            this.txtdescuento.Enabled = false;
            this.txtdescuento.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.txtdescuento.ForeColor = System.Drawing.Color.Blue;
            this.txtdescuento.Location = new System.Drawing.Point(85, 117);
            this.txtdescuento.MaxLength = 100;
            this.txtdescuento.Name = "txtdescuento";
            this.txtdescuento.NextControlOnEnter = null;
            this.txtdescuento.Size = new System.Drawing.Size(205, 20);
            this.txtdescuento.TabIndex = 5;
            this.txtdescuento.Text = "Ingrese Imagen Descuento";
            this.txtdescuento.TextoDefecto = "Ingrese Imagen Descuento";
            this.txtdescuento.TextoDefectoColor = System.Drawing.Color.Blue;
            this.txtdescuento.TiposDatos = HpResergerUserControls.TextBoxPer.ListaTipos.SoloLetras;
            // 
            // txtimporte
            // 
            this.txtimporte.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.txtimporte.Location = new System.Drawing.Point(85, 90);
            this.txtimporte.Name = "txtimporte";
            this.txtimporte.NextControlOnEnter = this.btnaddfoto;
            this.txtimporte.Size = new System.Drawing.Size(124, 24);
            this.txtimporte.TabIndex = 4;
            // 
            // txtmotivo
            // 
            this.txtmotivo.BackColor = System.Drawing.Color.White;
            this.txtmotivo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtmotivo.ColorFondoMouseEncima = System.Drawing.Color.Empty;
            this.txtmotivo.ColorFondoMousePresionado = System.Drawing.Color.Empty;
            this.txtmotivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.txtmotivo.ForeColor = System.Drawing.Color.Blue;
            this.txtmotivo.Location = new System.Drawing.Point(85, 64);
            this.txtmotivo.MaxLength = 100;
            this.txtmotivo.Name = "txtmotivo";
            this.txtmotivo.NextControlOnEnter = this.txtimporte;
            this.txtmotivo.Size = new System.Drawing.Size(310, 20);
            this.txtmotivo.TabIndex = 3;
            this.txtmotivo.Text = "Ingrese Motivo";
            this.txtmotivo.TextoDefecto = "Ingrese Motivo";
            this.txtmotivo.TextoDefectoColor = System.Drawing.Color.Blue;
            this.txtmotivo.TiposDatos = HpResergerUserControls.TextBoxPer.ListaTipos.SoloLetras;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Descuento:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Importe:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Motivo:";
            // 
            // panelOre1
            // 
            this.panelOre1.BackColor = System.Drawing.SystemColors.Control;
            this.panelOre1.Controls.Add(this.btneliminar);
            this.panelOre1.Controls.Add(this.pbdescuento);
            this.panelOre1.Controls.Add(this.btnaceptar);
            this.panelOre1.Controls.Add(this.btncancelar);
            this.panelOre1.Controls.Add(this.btnmodificar);
            this.panelOre1.Controls.Add(this.btnnuevo);
            this.panelOre1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelOre1.Location = new System.Drawing.Point(404, 0);
            this.panelOre1.Movible = false;
            this.panelOre1.Name = "panelOre1";
            this.panelOre1.Size = new System.Drawing.Size(90, 361);
            this.panelOre1.TabIndex = 152;
            // 
            // btneliminar
            // 
            this.btneliminar.Image = ((System.Drawing.Image)(resources.GetObject("btneliminar.Image")));
            this.btneliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btneliminar.Location = new System.Drawing.Point(6, 115);
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Size = new System.Drawing.Size(77, 24);
            this.btneliminar.TabIndex = 156;
            this.btneliminar.Text = "Eliminar";
            this.btneliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btneliminar.UseVisualStyleBackColor = true;
            this.btneliminar.Click += new System.EventHandler(this.btneliminar_Click);
            // 
            // pbdescuento
            // 
            this.pbdescuento.Location = new System.Drawing.Point(6, 152);
            this.pbdescuento.Name = "pbdescuento";
            this.pbdescuento.Size = new System.Drawing.Size(77, 139);
            this.pbdescuento.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbdescuento.TabIndex = 77;
            this.pbdescuento.TabStop = false;
            this.pbdescuento.Visible = false;
            // 
            // btnaceptar
            // 
            this.btnaceptar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnaceptar.Image = ((System.Drawing.Image)(resources.GetObject("btnaceptar.Image")));
            this.btnaceptar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnaceptar.Location = new System.Drawing.Point(6, 297);
            this.btnaceptar.Name = "btnaceptar";
            this.btnaceptar.Size = new System.Drawing.Size(77, 24);
            this.btnaceptar.TabIndex = 155;
            this.btnaceptar.Text = "Aceptar";
            this.btnaceptar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnaceptar.UseVisualStyleBackColor = true;
            this.btnaceptar.Click += new System.EventHandler(this.btnaceptar_Click);
            // 
            // btncancelar
            // 
            this.btncancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btncancelar.Image = ((System.Drawing.Image)(resources.GetObject("btncancelar.Image")));
            this.btncancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btncancelar.Location = new System.Drawing.Point(6, 326);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(77, 24);
            this.btncancelar.TabIndex = 154;
            this.btncancelar.Text = "&Cancelar";
            this.btncancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btncancelar.UseVisualStyleBackColor = true;
            this.btncancelar.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnmodificar
            // 
            this.btnmodificar.Image = ((System.Drawing.Image)(resources.GetObject("btnmodificar.Image")));
            this.btnmodificar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnmodificar.Location = new System.Drawing.Point(6, 62);
            this.btnmodificar.Name = "btnmodificar";
            this.btnmodificar.Size = new System.Drawing.Size(77, 24);
            this.btnmodificar.TabIndex = 153;
            this.btnmodificar.Text = "&Modificar";
            this.btnmodificar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnmodificar.UseVisualStyleBackColor = true;
            this.btnmodificar.Click += new System.EventHandler(this.btnmodificar_Click);
            // 
            // btnnuevo
            // 
            this.btnnuevo.Image = ((System.Drawing.Image)(resources.GetObject("btnnuevo.Image")));
            this.btnnuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnnuevo.Location = new System.Drawing.Point(6, 36);
            this.btnnuevo.Name = "btnnuevo";
            this.btnnuevo.Size = new System.Drawing.Size(77, 24);
            this.btnnuevo.TabIndex = 152;
            this.btnnuevo.Text = "&Nuevo";
            this.btnnuevo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnnuevo.UseVisualStyleBackColor = true;
            this.btnnuevo.Click += new System.EventHandler(this.btncancelar_Click);
            // 
            // frmOtrosDescuentos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 361);
            this.Controls.Add(this.panelOre3);
            this.Controls.Add(this.panelOre2);
            this.Controls.Add(this.panelOre1);
            this.MinimumSize = new System.Drawing.Size(510, 400);
            this.Name = "frmOtrosDescuentos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Otros Descuentos";
            this.Load += new System.EventHandler(this.frmOtrosDescuentos_Load);
            this.panelOre3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgconten)).EndInit();
            this.panelOre2.ResumeLayout(false);
            this.panelOre2.PerformLayout();
            this.panelOre1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbdescuento)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private HpResergerUserControls.PanelOre panelOre1;
        private HpResergerUserControls.PanelOre panelOre2;
        private HpResergerUserControls.PanelOre panelOre3;
        private System.Windows.Forms.DataGridView dtgconten;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnaddfoto;
        private HpResergerUserControls.TextBoxPer txtdescuento;
        private HpResergerUserControls.NumBox txtimporte;
        private HpResergerUserControls.TextBoxPer txtmotivo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNumeroDocumento;
        private System.Windows.Forms.ComboBox cboTipoDocumento;
        private System.Windows.Forms.Button btncancelar;
        private System.Windows.Forms.Button btnmodificar;
        private System.Windows.Forms.Button btnnuevo;
        private System.Windows.Forms.Button btnaceptar;
        private System.Windows.Forms.LinkLabel lkldescuento;
        private System.Windows.Forms.PictureBox pbdescuento;
        private System.Windows.Forms.DataGridViewTextBoxColumn desvinculancion;
        private System.Windows.Forms.DataGridViewTextBoxColumn registro;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipo_id_emp;
        private System.Windows.Forms.DataGridViewTextBoxColumn nro_id_emp;
        private System.Windows.Forms.DataGridViewTextBoxColumn Motivo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Importe;
        private System.Windows.Forms.DataGridViewTextBoxColumn dscto;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre_dscto;
        private System.Windows.Forms.DataGridViewTextBoxColumn usuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecha;
        private System.Windows.Forms.Button btneliminar;
    }
}