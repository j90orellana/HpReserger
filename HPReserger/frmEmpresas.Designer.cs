namespace HPReserger
{
    partial class frmEmpresas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEmpresas));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.cbotipo = new System.Windows.Forms.ComboBox();
            this.btnborrar = new System.Windows.Forms.Button();
            this.txtbuscar = new System.Windows.Forms.TextBox();
            this.btnexportarExcel = new System.Windows.Forms.Button();
            this.dtgconten = new System.Windows.Forms.DataGridView();
            this.ruc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.empresa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.direccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipodni = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nroid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.representante = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sector = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dep = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idempresa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idsector = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coddep = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codpro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coddis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ciaseguro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eps = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btneliminar = new System.Windows.Forms.Button();
            this.btnmodificar = new System.Windows.Forms.Button();
            this.btncancelar = new System.Windows.Forms.Button();
            this.btnaceptar = new System.Windows.Forms.Button();
            this.btnnuevo = new System.Windows.Forms.Button();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtruc = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtdireccion = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtnroid = new System.Windows.Forms.TextBox();
            this.cbosector = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.cbodep = new System.Windows.Forms.ComboBox();
            this.cbopro = new System.Windows.Forms.ComboBox();
            this.cbodis = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.cboseguro = new System.Windows.Forms.ComboBox();
            this.cbonombre = new System.Windows.Forms.ComboBox();
            this.btnsector = new System.Windows.Forms.Button();
            this.btnciaseguro = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgconten)).BeginInit();
            this.SuspendLayout();
            // 
            // cbotipo
            // 
            this.cbotipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbotipo.Enabled = false;
            this.cbotipo.FormattingEnabled = true;
            this.cbotipo.Location = new System.Drawing.Point(293, 11);
            this.cbotipo.Name = "cbotipo";
            this.cbotipo.Size = new System.Drawing.Size(146, 21);
            this.cbotipo.TabIndex = 135;
            this.cbotipo.SelectedIndexChanged += new System.EventHandler(this.cbotipo_SelectedIndexChanged);
            // 
            // btnborrar
            // 
            this.btnborrar.Image = ((System.Drawing.Image)(resources.GetObject("btnborrar.Image")));
            this.btnborrar.Location = new System.Drawing.Point(400, 123);
            this.btnborrar.Name = "btnborrar";
            this.btnborrar.Size = new System.Drawing.Size(82, 23);
            this.btnborrar.TabIndex = 134;
            this.btnborrar.Text = "Limpiar";
            this.btnborrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnborrar.UseVisualStyleBackColor = true;
            this.btnborrar.Click += new System.EventHandler(this.btnborrar_Click);
            // 
            // txtbuscar
            // 
            this.txtbuscar.Location = new System.Drawing.Point(113, 124);
            this.txtbuscar.Name = "txtbuscar";
            this.txtbuscar.Size = new System.Drawing.Size(278, 20);
            this.txtbuscar.TabIndex = 133;
            this.txtbuscar.TextChanged += new System.EventHandler(this.txtbuscar_TextChanged);
            // 
            // btnexportarExcel
            // 
            this.btnexportarExcel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnexportarExcel.Enabled = false;
            this.btnexportarExcel.Image = ((System.Drawing.Image)(resources.GetObject("btnexportarExcel.Image")));
            this.btnexportarExcel.Location = new System.Drawing.Point(989, 123);
            this.btnexportarExcel.Name = "btnexportarExcel";
            this.btnexportarExcel.Size = new System.Drawing.Size(82, 23);
            this.btnexportarExcel.TabIndex = 132;
            this.btnexportarExcel.Text = "A Excel";
            this.btnexportarExcel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnexportarExcel.UseVisualStyleBackColor = true;
            this.btnexportarExcel.Click += new System.EventHandler(this.btnexportarExcel_Click);
            // 
            // dtgconten
            // 
            this.dtgconten.AllowUserToAddRows = false;
            this.dtgconten.AllowUserToDeleteRows = false;
            this.dtgconten.AllowUserToResizeColumns = false;
            this.dtgconten.AllowUserToResizeRows = false;
            this.dtgconten.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgconten.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgconten.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dtgconten.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dtgconten.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dtgconten.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgconten.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgconten.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ruc,
            this.empresa,
            this.direccion,
            this.tipodni,
            this.nroid,
            this.representante,
            this.sector,
            this.dep,
            this.pro,
            this.dis,
            this.cia,
            this.idempresa,
            this.idsector,
            this.coddep,
            this.codpro,
            this.coddis,
            this.tipoid,
            this.ciaseguro,
            this.usuario,
            this.fecha,
            this.eps});
            this.dtgconten.Cursor = System.Windows.Forms.Cursors.Default;
            this.dtgconten.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnF2;
            this.dtgconten.Location = new System.Drawing.Point(15, 151);
            this.dtgconten.MultiSelect = false;
            this.dtgconten.Name = "dtgconten";
            this.dtgconten.ReadOnly = true;
            this.dtgconten.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dtgconten.RowHeadersVisible = false;
            this.dtgconten.RowTemplate.Height = 16;
            this.dtgconten.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dtgconten.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgconten.Size = new System.Drawing.Size(1056, 202);
            this.dtgconten.TabIndex = 124;
            this.dtgconten.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgconten_CellContentClick);
            this.dtgconten.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgconten_RowEnter);
            // 
            // ruc
            // 
            this.ruc.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ruc.DataPropertyName = "ruc";
            this.ruc.HeaderText = "Ruc";
            this.ruc.Name = "ruc";
            this.ruc.ReadOnly = true;
            this.ruc.Width = 52;
            // 
            // empresa
            // 
            this.empresa.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.empresa.DataPropertyName = "empresa";
            this.empresa.HeaderText = "Empresa";
            this.empresa.Name = "empresa";
            this.empresa.ReadOnly = true;
            this.empresa.Width = 73;
            // 
            // direccion
            // 
            this.direccion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.direccion.DataPropertyName = "direccion";
            this.direccion.HeaderText = "Dirección";
            this.direccion.MinimumWidth = 100;
            this.direccion.Name = "direccion";
            this.direccion.ReadOnly = true;
            // 
            // tipodni
            // 
            this.tipodni.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.tipodni.DataPropertyName = "tipoid";
            this.tipodni.HeaderText = "Tipo";
            this.tipodni.Name = "tipodni";
            this.tipodni.ReadOnly = true;
            this.tipodni.Width = 53;
            // 
            // nroid
            // 
            this.nroid.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.nroid.DataPropertyName = "nroid_representado";
            this.nroid.HeaderText = "Nro Doc";
            this.nroid.Name = "nroid";
            this.nroid.ReadOnly = true;
            this.nroid.Width = 72;
            // 
            // representante
            // 
            this.representante.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.representante.DataPropertyName = "empleado";
            this.representante.HeaderText = "Representante";
            this.representante.MinimumWidth = 100;
            this.representante.Name = "representante";
            this.representante.ReadOnly = true;
            // 
            // sector
            // 
            this.sector.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.sector.DataPropertyName = "desc_sector_empresarial";
            this.sector.HeaderText = "Sector Empresarial";
            this.sector.Name = "sector";
            this.sector.ReadOnly = true;
            this.sector.Width = 120;
            // 
            // dep
            // 
            this.dep.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dep.DataPropertyName = "departamento";
            this.dep.HeaderText = "Departamento";
            this.dep.Name = "dep";
            this.dep.ReadOnly = true;
            this.dep.Width = 99;
            // 
            // pro
            // 
            this.pro.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.pro.DataPropertyName = "provincia";
            this.pro.HeaderText = "Provincia";
            this.pro.Name = "pro";
            this.pro.ReadOnly = true;
            this.pro.Width = 76;
            // 
            // dis
            // 
            this.dis.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dis.DataPropertyName = "distrito";
            this.dis.HeaderText = "Distrito";
            this.dis.Name = "dis";
            this.dis.ReadOnly = true;
            this.dis.Width = 64;
            // 
            // cia
            // 
            this.cia.DataPropertyName = "cia";
            this.cia.HeaderText = "cia";
            this.cia.Name = "cia";
            this.cia.ReadOnly = true;
            this.cia.Visible = false;
            // 
            // idempresa
            // 
            this.idempresa.DataPropertyName = "id_empresa";
            this.idempresa.HeaderText = "idempresa";
            this.idempresa.Name = "idempresa";
            this.idempresa.ReadOnly = true;
            this.idempresa.Visible = false;
            // 
            // idsector
            // 
            this.idsector.DataPropertyName = "Sector_empresarial";
            this.idsector.HeaderText = "SectorSector";
            this.idsector.Name = "idsector";
            this.idsector.ReadOnly = true;
            this.idsector.Visible = false;
            // 
            // coddep
            // 
            this.coddep.DataPropertyName = "cod_dep";
            this.coddep.HeaderText = "coddep";
            this.coddep.Name = "coddep";
            this.coddep.ReadOnly = true;
            this.coddep.Visible = false;
            // 
            // codpro
            // 
            this.codpro.DataPropertyName = "cod_prov";
            this.codpro.HeaderText = "codpro";
            this.codpro.Name = "codpro";
            this.codpro.ReadOnly = true;
            this.codpro.Visible = false;
            // 
            // coddis
            // 
            this.coddis.DataPropertyName = "cod_dist";
            this.coddis.HeaderText = "coddis";
            this.coddis.Name = "coddis";
            this.coddis.ReadOnly = true;
            this.coddis.Visible = false;
            // 
            // tipoid
            // 
            this.tipoid.DataPropertyName = "tipoid_representado";
            this.tipoid.HeaderText = "tipoid";
            this.tipoid.Name = "tipoid";
            this.tipoid.ReadOnly = true;
            this.tipoid.Visible = false;
            // 
            // ciaseguro
            // 
            this.ciaseguro.DataPropertyName = "cia_seguro";
            this.ciaseguro.HeaderText = "ciaseguro";
            this.ciaseguro.Name = "ciaseguro";
            this.ciaseguro.ReadOnly = true;
            this.ciaseguro.Visible = false;
            // 
            // usuario
            // 
            this.usuario.DataPropertyName = "usuario";
            this.usuario.HeaderText = "usuario";
            this.usuario.Name = "usuario";
            this.usuario.ReadOnly = true;
            this.usuario.Visible = false;
            // 
            // fecha
            // 
            this.fecha.DataPropertyName = "fecha";
            this.fecha.HeaderText = "fecha";
            this.fecha.Name = "fecha";
            this.fecha.ReadOnly = true;
            this.fecha.Visible = false;
            // 
            // eps
            // 
            this.eps.DataPropertyName = "eps";
            this.eps.HeaderText = "Seguro";
            this.eps.Name = "eps";
            this.eps.ReadOnly = true;
            this.eps.Visible = false;
            // 
            // btneliminar
            // 
            this.btneliminar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btneliminar.Enabled = false;
            this.btneliminar.Image = ((System.Drawing.Image)(resources.GetObject("btneliminar.Image")));
            this.btneliminar.Location = new System.Drawing.Point(989, 62);
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Size = new System.Drawing.Size(82, 23);
            this.btneliminar.TabIndex = 129;
            this.btneliminar.Text = "Eliminar";
            this.btneliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btneliminar.UseVisualStyleBackColor = true;
            // 
            // btnmodificar
            // 
            this.btnmodificar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnmodificar.Enabled = false;
            this.btnmodificar.Image = ((System.Drawing.Image)(resources.GetObject("btnmodificar.Image")));
            this.btnmodificar.Location = new System.Drawing.Point(989, 36);
            this.btnmodificar.Name = "btnmodificar";
            this.btnmodificar.Size = new System.Drawing.Size(82, 23);
            this.btnmodificar.TabIndex = 130;
            this.btnmodificar.Text = "Modificar";
            this.btnmodificar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnmodificar.UseVisualStyleBackColor = true;
            this.btnmodificar.Click += new System.EventHandler(this.btnmodificar_Click);
            // 
            // btncancelar
            // 
            this.btncancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btncancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btncancelar.Image = ((System.Drawing.Image)(resources.GetObject("btncancelar.Image")));
            this.btncancelar.Location = new System.Drawing.Point(989, 359);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(82, 29);
            this.btncancelar.TabIndex = 125;
            this.btncancelar.Text = "Cancelar";
            this.btncancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btncancelar.UseVisualStyleBackColor = true;
            this.btncancelar.Click += new System.EventHandler(this.btncancelar_Click);
            // 
            // btnaceptar
            // 
            this.btnaceptar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnaceptar.Enabled = false;
            this.btnaceptar.Image = ((System.Drawing.Image)(resources.GetObject("btnaceptar.Image")));
            this.btnaceptar.Location = new System.Drawing.Point(901, 359);
            this.btnaceptar.Name = "btnaceptar";
            this.btnaceptar.Size = new System.Drawing.Size(82, 29);
            this.btnaceptar.TabIndex = 126;
            this.btnaceptar.Text = "Aceptar";
            this.btnaceptar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnaceptar.UseVisualStyleBackColor = true;
            this.btnaceptar.Click += new System.EventHandler(this.btnaceptar_Click);
            // 
            // btnnuevo
            // 
            this.btnnuevo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnnuevo.Image = ((System.Drawing.Image)(resources.GetObject("btnnuevo.Image")));
            this.btnnuevo.Location = new System.Drawing.Point(989, 10);
            this.btnnuevo.Name = "btnnuevo";
            this.btnnuevo.Size = new System.Drawing.Size(82, 23);
            this.btnnuevo.TabIndex = 127;
            this.btnnuevo.Text = "Nuevo";
            this.btnnuevo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnnuevo.UseVisualStyleBackColor = true;
            this.btnnuevo.Click += new System.EventHandler(this.btnnuevo_Click);
            // 
            // txtnombre
            // 
            this.txtnombre.Enabled = false;
            this.txtnombre.Location = new System.Drawing.Point(65, 37);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(326, 20);
            this.txtnombre.TabIndex = 131;
            this.txtnombre.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtnombre_KeyDown);
            this.txtnombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtnombre_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(167, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 13);
            this.label3.TabIndex = 120;
            this.label3.Text = "Tipo Id Representante:";
            // 
            // txtruc
            // 
            this.txtruc.Enabled = false;
            this.txtruc.Location = new System.Drawing.Point(66, 11);
            this.txtruc.MaxLength = 11;
            this.txtruc.Name = "txtruc";
            this.txtruc.Size = new System.Drawing.Size(95, 20);
            this.txtruc.TabIndex = 128;
            this.txtruc.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtruc_KeyDown);
            this.txtruc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtnroid_KeyPress_1);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 121;
            this.label4.Text = "Buscar:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 122;
            this.label2.Text = "Nombre:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 123;
            this.label1.Text = "Ruc:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(407, 41);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 138;
            this.label6.Text = "Dirección:";
            // 
            // txtdireccion
            // 
            this.txtdireccion.Enabled = false;
            this.txtdireccion.Location = new System.Drawing.Point(468, 37);
            this.txtdireccion.Name = "txtdireccion";
            this.txtdireccion.Size = new System.Drawing.Size(510, 20);
            this.txtdireccion.TabIndex = 139;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(442, 15);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 13);
            this.label7.TabIndex = 140;
            this.label7.Text = "Id Representante";
            // 
            // txtnroid
            // 
            this.txtnroid.Enabled = false;
            this.txtnroid.Location = new System.Drawing.Point(537, 11);
            this.txtnroid.Name = "txtnroid";
            this.txtnroid.Size = new System.Drawing.Size(121, 20);
            this.txtnroid.TabIndex = 141;
            this.txtnroid.TextChanged += new System.EventHandler(this.txtnroid_TextChanged);
            this.txtnroid.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtnroid_KeyDown);
            this.txtnroid.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtnroid_KeyPress_1);
            // 
            // cbosector
            // 
            this.cbosector.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbosector.Enabled = false;
            this.cbosector.FormattingEnabled = true;
            this.cbosector.Location = new System.Drawing.Point(113, 90);
            this.cbosector.Name = "cbosector";
            this.cbosector.Size = new System.Drawing.Size(317, 21);
            this.cbosector.TabIndex = 142;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 94);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 13);
            this.label5.TabIndex = 143;
            this.label5.Text = "Sector Empresarial";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 67);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 13);
            this.label8.TabIndex = 144;
            this.label8.Text = "Departamento";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(408, 67);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(54, 13);
            this.label9.TabIndex = 145;
            this.label9.Text = "Provincia:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(669, 67);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(42, 13);
            this.label10.TabIndex = 146;
            this.label10.Text = "Distrito:";
            // 
            // cbodep
            // 
            this.cbodep.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbodep.Enabled = false;
            this.cbodep.FormattingEnabled = true;
            this.cbodep.Location = new System.Drawing.Point(113, 63);
            this.cbodep.Name = "cbodep";
            this.cbodep.Size = new System.Drawing.Size(278, 21);
            this.cbodep.TabIndex = 147;
            this.cbodep.SelectedIndexChanged += new System.EventHandler(this.cbodep_SelectedIndexChanged);
            // 
            // cbopro
            // 
            this.cbopro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbopro.Enabled = false;
            this.cbopro.FormattingEnabled = true;
            this.cbopro.Location = new System.Drawing.Point(468, 63);
            this.cbopro.Name = "cbopro";
            this.cbopro.Size = new System.Drawing.Size(176, 21);
            this.cbopro.TabIndex = 148;
            this.cbopro.SelectedIndexChanged += new System.EventHandler(this.cbopro_SelectedIndexChanged);
            // 
            // cbodis
            // 
            this.cbodis.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbodis.Enabled = false;
            this.cbodis.FormattingEnabled = true;
            this.cbodis.Location = new System.Drawing.Point(717, 63);
            this.cbodis.Name = "cbodis";
            this.cbodis.Size = new System.Drawing.Size(199, 21);
            this.cbodis.TabIndex = 149;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(466, 94);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(65, 13);
            this.label11.TabIndex = 150;
            this.label11.Text = "Cia. Seguro:";
            // 
            // cboseguro
            // 
            this.cboseguro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboseguro.Enabled = false;
            this.cboseguro.FormattingEnabled = true;
            this.cboseguro.Location = new System.Drawing.Point(537, 90);
            this.cboseguro.Name = "cboseguro";
            this.cboseguro.Size = new System.Drawing.Size(146, 21);
            this.cboseguro.TabIndex = 151;
            // 
            // cbonombre
            // 
            this.cbonombre.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbonombre.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbonombre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbonombre.Enabled = false;
            this.cbonombre.FormattingEnabled = true;
            this.cbonombre.Location = new System.Drawing.Point(664, 11);
            this.cbonombre.Name = "cbonombre";
            this.cbonombre.Size = new System.Drawing.Size(314, 21);
            this.cbonombre.TabIndex = 152;
            this.cbonombre.SelectedIndexChanged += new System.EventHandler(this.cbonombre_SelectedIndexChanged);
            // 
            // btnsector
            // 
            this.btnsector.Enabled = false;
            this.btnsector.Image = ((System.Drawing.Image)(resources.GetObject("btnsector.Image")));
            this.btnsector.Location = new System.Drawing.Point(436, 89);
            this.btnsector.Name = "btnsector";
            this.btnsector.Size = new System.Drawing.Size(24, 23);
            this.btnsector.TabIndex = 153;
            this.btnsector.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnsector.UseVisualStyleBackColor = true;
            this.btnsector.Click += new System.EventHandler(this.btnsector_Click);
            // 
            // btnciaseguro
            // 
            this.btnciaseguro.Enabled = false;
            this.btnciaseguro.Image = ((System.Drawing.Image)(resources.GetObject("btnciaseguro.Image")));
            this.btnciaseguro.Location = new System.Drawing.Point(689, 89);
            this.btnciaseguro.Name = "btnciaseguro";
            this.btnciaseguro.Size = new System.Drawing.Size(24, 23);
            this.btnciaseguro.TabIndex = 154;
            this.btnciaseguro.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnciaseguro.UseVisualStyleBackColor = true;
            this.btnciaseguro.Click += new System.EventHandler(this.btnciaseguro_Click);
            // 
            // frmEmpresas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1083, 394);
            this.Controls.Add(this.btnciaseguro);
            this.Controls.Add(this.btnsector);
            this.Controls.Add(this.cbonombre);
            this.Controls.Add(this.cboseguro);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.cbodis);
            this.Controls.Add(this.cbopro);
            this.Controls.Add(this.cbodep);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbosector);
            this.Controls.Add(this.txtnroid);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtdireccion);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cbotipo);
            this.Controls.Add(this.btnborrar);
            this.Controls.Add(this.txtbuscar);
            this.Controls.Add(this.btnexportarExcel);
            this.Controls.Add(this.dtgconten);
            this.Controls.Add(this.btneliminar);
            this.Controls.Add(this.btnmodificar);
            this.Controls.Add(this.btncancelar);
            this.Controls.Add(this.btnaceptar);
            this.Controls.Add(this.btnnuevo);
            this.Controls.Add(this.txtnombre);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtruc);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MinimumSize = new System.Drawing.Size(1099, 433);
            this.Name = "frmEmpresas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Empresas";
            this.Load += new System.EventHandler(this.frmEmpresas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgconten)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cbotipo;
        private System.Windows.Forms.Button btnborrar;
        private System.Windows.Forms.TextBox txtbuscar;
        private System.Windows.Forms.Button btnexportarExcel;
        private System.Windows.Forms.DataGridView dtgconten;
        private System.Windows.Forms.Button btneliminar;
        private System.Windows.Forms.Button btnmodificar;
        private System.Windows.Forms.Button btncancelar;
        private System.Windows.Forms.Button btnaceptar;
        private System.Windows.Forms.Button btnnuevo;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtruc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtdireccion;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtnroid;
        private System.Windows.Forms.ComboBox cbosector;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cbodep;
        private System.Windows.Forms.ComboBox cbopro;
        private System.Windows.Forms.ComboBox cbodis;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cboseguro;
        private System.Windows.Forms.ComboBox cbonombre;
        private System.Windows.Forms.Button btnsector;
        private System.Windows.Forms.Button btnciaseguro;
        private System.Windows.Forms.DataGridViewTextBoxColumn ruc;
        private System.Windows.Forms.DataGridViewTextBoxColumn empresa;
        private System.Windows.Forms.DataGridViewTextBoxColumn direccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipodni;
        private System.Windows.Forms.DataGridViewTextBoxColumn nroid;
        private System.Windows.Forms.DataGridViewTextBoxColumn representante;
        private System.Windows.Forms.DataGridViewTextBoxColumn sector;
        private System.Windows.Forms.DataGridViewTextBoxColumn dep;
        private System.Windows.Forms.DataGridViewTextBoxColumn pro;
        private System.Windows.Forms.DataGridViewTextBoxColumn dis;
        private System.Windows.Forms.DataGridViewTextBoxColumn cia;
        private System.Windows.Forms.DataGridViewTextBoxColumn idempresa;
        private System.Windows.Forms.DataGridViewTextBoxColumn idsector;
        private System.Windows.Forms.DataGridViewTextBoxColumn coddep;
        private System.Windows.Forms.DataGridViewTextBoxColumn codpro;
        private System.Windows.Forms.DataGridViewTextBoxColumn coddis;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoid;
        private System.Windows.Forms.DataGridViewTextBoxColumn ciaseguro;
        private System.Windows.Forms.DataGridViewTextBoxColumn usuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn eps;
    }
}