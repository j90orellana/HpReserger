using HpResergerUserControls;

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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEmpresas));
            this.cbotipo = new System.Windows.Forms.ComboBox();
            this.dtgconten = new HpResergerUserControls.Dtgconten();
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
            this.xStock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xIngresosMayores = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yppto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btncancelar = new System.Windows.Forms.Button();
            this.btnaceptar = new System.Windows.Forms.Button();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.txtruc = new System.Windows.Forms.TextBox();
            this.txtdireccion = new System.Windows.Forms.TextBox();
            this.txtnroid = new System.Windows.Forms.TextBox();
            this.cbosector = new System.Windows.Forms.ComboBox();
            this.cbodep = new System.Windows.Forms.ComboBox();
            this.cbopro = new System.Windows.Forms.ComboBox();
            this.cbodis = new System.Windows.Forms.ComboBox();
            this.cboseguro = new System.Windows.Forms.ComboBox();
            this.cbonombre = new System.Windows.Forms.ComboBox();
            this.btnsector = new System.Windows.Forms.Button();
            this.btnciaseguro = new System.Windows.Forms.Button();
            this.lbltotalregistros = new System.Windows.Forms.Label();
            this.chkStock = new HpResergerUserControls.checkboxOre();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.xId_Empresa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.xRUC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.xEmpresa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.xSector_Empresarial = new DevExpress.XtraGrid.Columns.GridColumn();
            this.xDireccion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.xCod_Dep = new DevExpress.XtraGrid.Columns.GridColumn();
            this.xCod_Prov = new DevExpress.XtraGrid.Columns.GridColumn();
            this.xCod_Dist = new DevExpress.XtraGrid.Columns.GridColumn();
            this.xTipoID_Representado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.xNroID_Representado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.xCia_Seguro = new DevExpress.XtraGrid.Columns.GridColumn();
            this.xUsuario = new DevExpress.XtraGrid.Columns.GridColumn();
            this.xFecha = new DevExpress.XtraGrid.Columns.GridColumn();
            this.xDesc_Sector_Empresarial = new DevExpress.XtraGrid.Columns.GridColumn();
            this.xDepartamento = new DevExpress.XtraGrid.Columns.GridColumn();
            this.xProvincia = new DevExpress.XtraGrid.Columns.GridColumn();
            this.xDistrito = new DevExpress.XtraGrid.Columns.GridColumn();
            this.xempleado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.xDesc_Tipo_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.xtipoid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.xcia = new DevExpress.XtraGrid.Columns.GridColumn();
            this.xeps = new DevExpress.XtraGrid.Columns.GridColumn();
            this.xstocks = new DevExpress.XtraGrid.Columns.GridColumn();
            this.xppto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.btnnNuevo = new DevExpress.XtraBars.BarButtonItem();
            this.btnnModificar = new DevExpress.XtraBars.BarButtonItem();
            this.btnnEliminar = new DevExpress.XtraBars.BarButtonItem();
            this.btnRepresentantes = new DevExpress.XtraBars.BarButtonItem();
            this.btnnAExcel = new DevExpress.XtraBars.BarButtonItem();
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.chkIngresosMayores = new DevExpress.XtraEditors.CheckEdit();
            this.cboppto = new System.Windows.Forms.ComboBox();
            this.layoutControlItem10 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem7 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem8 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem9 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem11 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem13 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem15 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem3 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem12 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem4 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem14 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem17 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem18 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem16 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem2 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.emptySpaceItem5 = new DevExpress.XtraLayout.EmptySpaceItem();
            ((System.ComponentModel.ISupportInitialize)(this.dtgconten)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkIngresosMayores.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem15)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem14)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem17)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem18)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem16)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem5)).BeginInit();
            this.SuspendLayout();
            // 
            // cbotipo
            // 
            this.cbotipo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(218)))), ((int)(((byte)(231)))));
            this.cbotipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbotipo.Enabled = false;
            this.cbotipo.FormattingEnabled = true;
            this.cbotipo.Location = new System.Drawing.Point(524, 6);
            this.cbotipo.Name = "cbotipo";
            this.cbotipo.Size = new System.Drawing.Size(41, 21);
            this.cbotipo.TabIndex = 135;
            this.cbotipo.SelectedIndexChanged += new System.EventHandler(this.cbotipo_SelectedIndexChanged);
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
            this.dtgconten.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgconten.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.dtgconten.CheckColumna = null;
            this.dtgconten.CheckValor = 1;
            this.dtgconten.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(129)))), ((int)(((byte)(189)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DeepSkyBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgconten.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dtgconten.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
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
            this.eps,
            this.xStock,
            this.xIngresosMayores,
            this.yppto});
            this.dtgconten.Cursor = System.Windows.Forms.Cursors.Default;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(207)))), ((int)(((byte)(241)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgconten.DefaultCellStyle = dataGridViewCellStyle3;
            this.dtgconten.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnF2;
            this.dtgconten.EnableHeadersVisualStyles = false;
            this.dtgconten.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(179)))), ((int)(((byte)(215)))));
            this.dtgconten.Location = new System.Drawing.Point(12, 135);
            this.dtgconten.MultiSelect = false;
            this.dtgconten.Name = "dtgconten";
            this.dtgconten.ReadOnly = true;
            this.dtgconten.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dtgconten.RowHeadersVisible = false;
            this.dtgconten.RowTemplate.Height = 16;
            this.dtgconten.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dtgconten.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgconten.Size = new System.Drawing.Size(1079, 164);
            this.dtgconten.TabIndex = 124;
            this.dtgconten.Visible = false;
            this.dtgconten.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgconten_RowEnter);
            // 
            // ruc
            // 
            this.ruc.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ruc.DataPropertyName = "ruc";
            this.ruc.HeaderText = "Ruc";
            this.ruc.Name = "ruc";
            this.ruc.ReadOnly = true;
            this.ruc.Width = 51;
            // 
            // empresa
            // 
            this.empresa.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.empresa.DataPropertyName = "empresa";
            this.empresa.HeaderText = "Empresa";
            this.empresa.Name = "empresa";
            this.empresa.ReadOnly = true;
            this.empresa.Width = 76;
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
            this.tipodni.Visible = false;
            // 
            // nroid
            // 
            this.nroid.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.nroid.DataPropertyName = "nroid_representado";
            this.nroid.HeaderText = "Nro Doc";
            this.nroid.Name = "nroid";
            this.nroid.ReadOnly = true;
            this.nroid.Visible = false;
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
            this.sector.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.sector.DataPropertyName = "desc_sector_empresarial";
            this.sector.HeaderText = "Sector Empresarial";
            this.sector.MinimumWidth = 200;
            this.sector.Name = "sector";
            this.sector.ReadOnly = true;
            this.sector.Width = 200;
            // 
            // dep
            // 
            this.dep.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dep.DataPropertyName = "departamento";
            this.dep.HeaderText = "Departamento";
            this.dep.Name = "dep";
            this.dep.ReadOnly = true;
            this.dep.Visible = false;
            // 
            // pro
            // 
            this.pro.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.pro.DataPropertyName = "provincia";
            this.pro.HeaderText = "Provincia";
            this.pro.Name = "pro";
            this.pro.ReadOnly = true;
            this.pro.Visible = false;
            // 
            // dis
            // 
            this.dis.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dis.DataPropertyName = "distrito";
            this.dis.HeaderText = "Distrito";
            this.dis.Name = "dis";
            this.dis.ReadOnly = true;
            this.dis.Width = 69;
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
            // xStock
            // 
            this.xStock.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.xStock.DataPropertyName = "stock";
            this.xStock.HeaderText = "Stock";
            this.xStock.MinimumWidth = 40;
            this.xStock.Name = "xStock";
            this.xStock.ReadOnly = true;
            this.xStock.Width = 40;
            // 
            // xIngresosMayores
            // 
            this.xIngresosMayores.DataPropertyName = "IngresosMayores";
            this.xIngresosMayores.HeaderText = "IngresosMayores";
            this.xIngresosMayores.Name = "xIngresosMayores";
            this.xIngresosMayores.ReadOnly = true;
            // 
            // yppto
            // 
            this.yppto.DataPropertyName = "ppto";
            this.yppto.HeaderText = "ppto";
            this.yppto.Name = "yppto";
            this.yppto.ReadOnly = true;
            this.yppto.Visible = false;
            // 
            // btncancelar
            // 
            this.btncancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btncancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btncancelar.Image = ((System.Drawing.Image)(resources.GetObject("btncancelar.Image")));
            this.btncancelar.Location = new System.Drawing.Point(989, 369);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(82, 25);
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
            this.btnaceptar.Location = new System.Drawing.Point(901, 369);
            this.btnaceptar.Name = "btnaceptar";
            this.btnaceptar.Size = new System.Drawing.Size(82, 25);
            this.btnaceptar.TabIndex = 126;
            this.btnaceptar.Text = "Aceptar";
            this.btnaceptar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnaceptar.UseVisualStyleBackColor = true;
            this.btnaceptar.Click += new System.EventHandler(this.btnaceptar_Click);
            // 
            // txtnombre
            // 
            this.txtnombre.Enabled = false;
            this.txtnombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnombre.Location = new System.Drawing.Point(102, 28);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(301, 20);
            this.txtnombre.TabIndex = 131;
            this.txtnombre.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtnombre_KeyDown);
            this.txtnombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtnombre_KeyPress);
            // 
            // txtruc
            // 
            this.txtruc.Enabled = false;
            this.txtruc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtruc.Location = new System.Drawing.Point(102, 6);
            this.txtruc.MaxLength = 11;
            this.txtruc.Name = "txtruc";
            this.txtruc.Size = new System.Drawing.Size(301, 20);
            this.txtruc.TabIndex = 128;
            this.txtruc.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtruc_KeyDown);
            this.txtruc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtnroid_KeyPress_1);
            // 
            // txtdireccion
            // 
            this.txtdireccion.Enabled = false;
            this.txtdireccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdireccion.Location = new System.Drawing.Point(524, 29);
            this.txtdireccion.Name = "txtdireccion";
            this.txtdireccion.Size = new System.Drawing.Size(553, 20);
            this.txtdireccion.TabIndex = 139;
            // 
            // txtnroid
            // 
            this.txtnroid.Enabled = false;
            this.txtnroid.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnroid.Location = new System.Drawing.Point(663, 6);
            this.txtnroid.Name = "txtnroid";
            this.txtnroid.Size = new System.Drawing.Size(53, 20);
            this.txtnroid.TabIndex = 141;
            this.txtnroid.TextChanged += new System.EventHandler(this.txtnroid_TextChanged);
            this.txtnroid.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtnroid_KeyDown);
            this.txtnroid.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtnroid_KeyPress_1);
            // 
            // cbosector
            // 
            this.cbosector.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(218)))), ((int)(((byte)(231)))));
            this.cbosector.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbosector.Enabled = false;
            this.cbosector.FormattingEnabled = true;
            this.cbosector.Location = new System.Drawing.Point(102, 73);
            this.cbosector.Name = "cbosector";
            this.cbosector.Size = new System.Drawing.Size(301, 21);
            this.cbosector.TabIndex = 142;
            // 
            // cbodep
            // 
            this.cbodep.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(218)))), ((int)(((byte)(231)))));
            this.cbodep.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbodep.Enabled = false;
            this.cbodep.FormattingEnabled = true;
            this.cbodep.Location = new System.Drawing.Point(102, 50);
            this.cbodep.Name = "cbodep";
            this.cbodep.Size = new System.Drawing.Size(301, 21);
            this.cbodep.TabIndex = 147;
            this.cbodep.SelectedIndexChanged += new System.EventHandler(this.cbodep_SelectedIndexChanged);
            // 
            // cbopro
            // 
            this.cbopro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(218)))), ((int)(((byte)(231)))));
            this.cbopro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbopro.Enabled = false;
            this.cbopro.FormattingEnabled = true;
            this.cbopro.Location = new System.Drawing.Point(524, 51);
            this.cbopro.Name = "cbopro";
            this.cbopro.Size = new System.Drawing.Size(106, 21);
            this.cbopro.TabIndex = 148;
            this.cbopro.SelectedIndexChanged += new System.EventHandler(this.cbopro_SelectedIndexChanged);
            // 
            // cbodis
            // 
            this.cbodis.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(218)))), ((int)(((byte)(231)))));
            this.cbodis.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbodis.Enabled = false;
            this.cbodis.FormattingEnabled = true;
            this.cbodis.Location = new System.Drawing.Point(751, 51);
            this.cbodis.Name = "cbodis";
            this.cbodis.Size = new System.Drawing.Size(326, 21);
            this.cbodis.TabIndex = 149;
            // 
            // cboseguro
            // 
            this.cboseguro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(218)))), ((int)(((byte)(231)))));
            this.cboseguro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboseguro.Enabled = false;
            this.cboseguro.FormattingEnabled = true;
            this.cboseguro.Location = new System.Drawing.Point(525, 74);
            this.cboseguro.Name = "cboseguro";
            this.cboseguro.Size = new System.Drawing.Size(105, 21);
            this.cboseguro.TabIndex = 151;
            // 
            // cbonombre
            // 
            this.cbonombre.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbonombre.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbonombre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(218)))), ((int)(((byte)(231)))));
            this.cbonombre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbonombre.Enabled = false;
            this.cbonombre.FormattingEnabled = true;
            this.cbonombre.Location = new System.Drawing.Point(814, 6);
            this.cbonombre.Name = "cbonombre";
            this.cbonombre.Size = new System.Drawing.Size(263, 21);
            this.cbonombre.TabIndex = 152;
            this.cbonombre.SelectedIndexChanged += new System.EventHandler(this.cbonombre_SelectedIndexChanged);
            // 
            // btnsector
            // 
            this.btnsector.Enabled = false;
            this.btnsector.Image = ((System.Drawing.Image)(resources.GetObject("btnsector.Image")));
            this.btnsector.Location = new System.Drawing.Point(405, 74);
            this.btnsector.Name = "btnsector";
            this.btnsector.Size = new System.Drawing.Size(22, 23);
            this.btnsector.TabIndex = 153;
            this.btnsector.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnsector.UseVisualStyleBackColor = true;
            this.btnsector.Click += new System.EventHandler(this.btnsector_Click);
            // 
            // btnciaseguro
            // 
            this.btnciaseguro.Enabled = false;
            this.btnciaseguro.Image = ((System.Drawing.Image)(resources.GetObject("btnciaseguro.Image")));
            this.btnciaseguro.Location = new System.Drawing.Point(632, 74);
            this.btnciaseguro.Name = "btnciaseguro";
            this.btnciaseguro.Size = new System.Drawing.Size(22, 23);
            this.btnciaseguro.TabIndex = 154;
            this.btnciaseguro.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnciaseguro.UseVisualStyleBackColor = true;
            this.btnciaseguro.Click += new System.EventHandler(this.btnciaseguro_Click);
            // 
            // lbltotalregistros
            // 
            this.lbltotalregistros.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbltotalregistros.AutoEllipsis = true;
            this.lbltotalregistros.AutoSize = true;
            this.lbltotalregistros.BackColor = System.Drawing.Color.Transparent;
            this.lbltotalregistros.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltotalregistros.Location = new System.Drawing.Point(14, 375);
            this.lbltotalregistros.Name = "lbltotalregistros";
            this.lbltotalregistros.Size = new System.Drawing.Size(105, 13);
            this.lbltotalregistros.TabIndex = 156;
            this.lbltotalregistros.Text = "Total de Registros: ";
            // 
            // chkStock
            // 
            this.chkStock.BackColor = System.Drawing.Color.Transparent;
            this.chkStock.ColorChecked = System.Drawing.Color.Empty;
            this.chkStock.ColorUnChecked = System.Drawing.Color.Empty;
            this.chkStock.Enabled = false;
            this.chkStock.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.chkStock.Location = new System.Drawing.Point(6, 99);
            this.chkStock.Name = "chkStock";
            this.chkStock.Size = new System.Drawing.Size(65, 22);
            this.chkStock.TabIndex = 157;
            this.chkStock.Text = "Stock";
            this.chkStock.UseVisualStyleBackColor = false;
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.gridControl1);
            this.layoutControl1.Controls.Add(this.chkIngresosMayores);
            this.layoutControl1.Controls.Add(this.chkStock);
            this.layoutControl1.Controls.Add(this.btnciaseguro);
            this.layoutControl1.Controls.Add(this.txtruc);
            this.layoutControl1.Controls.Add(this.cboseguro);
            this.layoutControl1.Controls.Add(this.btnsector);
            this.layoutControl1.Controls.Add(this.cbotipo);
            this.layoutControl1.Controls.Add(this.cbonombre);
            this.layoutControl1.Controls.Add(this.txtnroid);
            this.layoutControl1.Controls.Add(this.cbodis);
            this.layoutControl1.Controls.Add(this.cbosector);
            this.layoutControl1.Controls.Add(this.txtnombre);
            this.layoutControl1.Controls.Add(this.cbopro);
            this.layoutControl1.Controls.Add(this.txtdireccion);
            this.layoutControl1.Controls.Add(this.cbodep);
            this.layoutControl1.Controls.Add(this.dtgconten);
            this.layoutControl1.Controls.Add(this.cboppto);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.HiddenItems.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem10});
            this.layoutControl1.Location = new System.Drawing.Point(0, 20);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(1083, 352);
            this.layoutControl1.TabIndex = 158;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // gridControl1
            // 
            this.gridControl1.Location = new System.Drawing.Point(6, 123);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.MenuManager = this.barManager1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1071, 223);
            this.gridControl1.TabIndex = 159;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.xId_Empresa,
            this.xRUC,
            this.xEmpresa,
            this.xSector_Empresarial,
            this.xDireccion,
            this.xCod_Dep,
            this.xCod_Prov,
            this.xCod_Dist,
            this.xTipoID_Representado,
            this.xNroID_Representado,
            this.xCia_Seguro,
            this.xUsuario,
            this.xFecha,
            this.xDesc_Sector_Empresarial,
            this.xDepartamento,
            this.xProvincia,
            this.xDistrito,
            this.xempleado,
            this.xDesc_Tipo_ID,
            this.xtipoid,
            this.xcia,
            this.xeps,
            this.xstocks,
            this.xppto});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsFind.AlwaysVisible = true;
            this.gridView1.OptionsFind.FindNullPrompt = "Ingrese Texto a Buscar.";
            // 
            // xId_Empresa
            // 
            this.xId_Empresa.Caption = "Id_Empresa";
            this.xId_Empresa.FieldName = "Id_Empresa";
            this.xId_Empresa.Name = "xId_Empresa";
            // 
            // xRUC
            // 
            this.xRUC.Caption = "RUC";
            this.xRUC.FieldName = "RUC";
            this.xRUC.Name = "xRUC";
            this.xRUC.OptionsColumn.AllowEdit = false;
            this.xRUC.Visible = true;
            this.xRUC.VisibleIndex = 0;
            // 
            // xEmpresa
            // 
            this.xEmpresa.Caption = "Empresa";
            this.xEmpresa.FieldName = "Empresa";
            this.xEmpresa.Name = "xEmpresa";
            this.xEmpresa.OptionsColumn.AllowEdit = false;
            this.xEmpresa.Visible = true;
            this.xEmpresa.VisibleIndex = 1;
            // 
            // xSector_Empresarial
            // 
            this.xSector_Empresarial.Caption = "Sector_Empresarial";
            this.xSector_Empresarial.FieldName = "Sector_Empresarial";
            this.xSector_Empresarial.Name = "xSector_Empresarial";
            // 
            // xDireccion
            // 
            this.xDireccion.Caption = "Dirección";
            this.xDireccion.FieldName = "Direccion";
            this.xDireccion.Name = "xDireccion";
            this.xDireccion.OptionsColumn.AllowEdit = false;
            this.xDireccion.Visible = true;
            this.xDireccion.VisibleIndex = 2;
            // 
            // xCod_Dep
            // 
            this.xCod_Dep.Caption = "Cod_Dep";
            this.xCod_Dep.FieldName = "Cod_Dep";
            this.xCod_Dep.Name = "xCod_Dep";
            // 
            // xCod_Prov
            // 
            this.xCod_Prov.Caption = "Cod_Prov";
            this.xCod_Prov.FieldName = "Cod_Prov";
            this.xCod_Prov.Name = "xCod_Prov";
            // 
            // xCod_Dist
            // 
            this.xCod_Dist.Caption = "Cod_Dist";
            this.xCod_Dist.FieldName = "Cod_Dist";
            this.xCod_Dist.Name = "xCod_Dist";
            // 
            // xTipoID_Representado
            // 
            this.xTipoID_Representado.Caption = "TipoID_Representado";
            this.xTipoID_Representado.Name = "xTipoID_Representado";
            // 
            // xNroID_Representado
            // 
            this.xNroID_Representado.Caption = "NroID";
            this.xNroID_Representado.FieldName = "NroID_Representado";
            this.xNroID_Representado.Name = "xNroID_Representado";
            this.xNroID_Representado.OptionsColumn.AllowEdit = false;
            this.xNroID_Representado.Visible = true;
            this.xNroID_Representado.VisibleIndex = 3;
            // 
            // xCia_Seguro
            // 
            this.xCia_Seguro.Caption = "Cia_Seguro";
            this.xCia_Seguro.FieldName = "Cia_Seguro";
            this.xCia_Seguro.Name = "xCia_Seguro";
            // 
            // xUsuario
            // 
            this.xUsuario.Caption = "Usuario";
            this.xUsuario.FieldName = "Usuario";
            this.xUsuario.Name = "xUsuario";
            // 
            // xFecha
            // 
            this.xFecha.Caption = "Fecha";
            this.xFecha.FieldName = "Fecha";
            this.xFecha.Name = "xFecha";
            // 
            // xDesc_Sector_Empresarial
            // 
            this.xDesc_Sector_Empresarial.Caption = "Sector";
            this.xDesc_Sector_Empresarial.FieldName = "Desc_Sector_Empresarial";
            this.xDesc_Sector_Empresarial.Name = "xDesc_Sector_Empresarial";
            this.xDesc_Sector_Empresarial.OptionsColumn.AllowEdit = false;
            this.xDesc_Sector_Empresarial.Visible = true;
            this.xDesc_Sector_Empresarial.VisibleIndex = 4;
            // 
            // xDepartamento
            // 
            this.xDepartamento.Caption = "Departamento";
            this.xDepartamento.FieldName = "Departamento";
            this.xDepartamento.Name = "xDepartamento";
            this.xDepartamento.OptionsColumn.AllowEdit = false;
            this.xDepartamento.Visible = true;
            this.xDepartamento.VisibleIndex = 5;
            // 
            // xProvincia
            // 
            this.xProvincia.Caption = "Provincia";
            this.xProvincia.FieldName = "Provincia";
            this.xProvincia.Name = "xProvincia";
            this.xProvincia.OptionsColumn.AllowEdit = false;
            this.xProvincia.Visible = true;
            this.xProvincia.VisibleIndex = 6;
            // 
            // xDistrito
            // 
            this.xDistrito.Caption = "Distrito";
            this.xDistrito.FieldName = "Distrito";
            this.xDistrito.Name = "xDistrito";
            this.xDistrito.OptionsColumn.AllowEdit = false;
            this.xDistrito.Visible = true;
            this.xDistrito.VisibleIndex = 7;
            // 
            // xempleado
            // 
            this.xempleado.Caption = "Representante";
            this.xempleado.FieldName = "empleado";
            this.xempleado.Name = "xempleado";
            this.xempleado.OptionsColumn.AllowEdit = false;
            this.xempleado.Visible = true;
            this.xempleado.VisibleIndex = 8;
            // 
            // xDesc_Tipo_ID
            // 
            this.xDesc_Tipo_ID.Caption = "Desc_Tipo_ID";
            this.xDesc_Tipo_ID.FieldName = "Desc_Tipo_ID";
            this.xDesc_Tipo_ID.Name = "xDesc_Tipo_ID";
            this.xDesc_Tipo_ID.OptionsColumn.AllowEdit = false;
            // 
            // xtipoid
            // 
            this.xtipoid.Caption = "tipoid";
            this.xtipoid.FieldName = "tipoid";
            this.xtipoid.Name = "xtipoid";
            // 
            // xcia
            // 
            this.xcia.Caption = "cia";
            this.xcia.FieldName = "cia";
            this.xcia.Name = "xcia";
            // 
            // xeps
            // 
            this.xeps.Caption = "eps";
            this.xeps.FieldName = "eps";
            this.xeps.Name = "xeps";
            // 
            // xstocks
            // 
            this.xstocks.Caption = "STOCk";
            this.xstocks.FieldName = "STOCk";
            this.xstocks.Name = "xstocks";
            // 
            // xppto
            // 
            this.xppto.Caption = "ppto";
            this.xppto.FieldName = "ppto";
            this.xppto.Name = "xppto";
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar2,
            this.bar1});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btnnNuevo,
            this.btnnModificar,
            this.btnnEliminar,
            this.btnnAExcel,
            this.btnRepresentantes});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 6;
            this.barManager1.StatusBar = this.bar1;
            // 
            // bar2
            // 
            this.bar2.BarName = "Menú principal";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnnNuevo, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnnModificar, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnnEliminar, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnRepresentantes, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnnAExcel, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Menú principal";
            // 
            // btnnNuevo
            // 
            this.btnnNuevo.Caption = "Nuevo";
            this.btnnNuevo.Id = 0;
            this.btnnNuevo.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnnNuevo.ImageOptions.Image")));
            this.btnnNuevo.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnnNuevo.ImageOptions.LargeImage")));
            this.btnnNuevo.Name = "btnnNuevo";
            this.btnnNuevo.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnnNuevo_ItemClick);
            // 
            // btnnModificar
            // 
            this.btnnModificar.Caption = "Modificar";
            this.btnnModificar.Id = 1;
            this.btnnModificar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnnModificar.ImageOptions.Image")));
            this.btnnModificar.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnnModificar.ImageOptions.LargeImage")));
            this.btnnModificar.Name = "btnnModificar";
            this.btnnModificar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnnModificar_ItemClick);
            // 
            // btnnEliminar
            // 
            this.btnnEliminar.Caption = "Eliminar";
            this.btnnEliminar.Id = 2;
            this.btnnEliminar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnnEliminar.ImageOptions.Image")));
            this.btnnEliminar.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnnEliminar.ImageOptions.LargeImage")));
            this.btnnEliminar.Name = "btnnEliminar";
            // 
            // btnRepresentantes
            // 
            this.btnRepresentantes.Caption = "Representantes";
            this.btnRepresentantes.Id = 5;
            this.btnRepresentantes.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnRepresentantes.ImageOptions.Image")));
            this.btnRepresentantes.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnRepresentantes.ImageOptions.LargeImage")));
            this.btnRepresentantes.Name = "btnRepresentantes";
            this.btnRepresentantes.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnRepresentantes_ItemClick);
            // 
            // btnnAExcel
            // 
            this.btnnAExcel.Caption = "A Excel";
            this.btnnAExcel.Id = 4;
            this.btnnAExcel.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnnAExcel.ImageOptions.Image")));
            this.btnnAExcel.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnnAExcel.ImageOptions.LargeImage")));
            this.btnnAExcel.Name = "btnnAExcel";
            this.btnnAExcel.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnexportarExcel_Click);
            // 
            // bar1
            // 
            this.bar1.BarName = "Personalizada 3";
            this.bar1.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 0;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.bar1.OptionsBar.AllowQuickCustomization = false;
            this.bar1.OptionsBar.DrawDragBorder = false;
            this.bar1.OptionsBar.UseWholeRow = true;
            this.bar1.Text = "Personalizada 3";
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(1083, 20);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 372);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1083, 22);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 20);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 352);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1083, 20);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 352);
            // 
            // chkIngresosMayores
            // 
            this.chkIngresosMayores.Enabled = false;
            this.chkIngresosMayores.Location = new System.Drawing.Point(73, 99);
            this.chkIngresosMayores.MenuManager = this.barManager1;
            this.chkIngresosMayores.Name = "chkIngresosMayores";
            this.chkIngresosMayores.Properties.Caption = "Ingresos Mayores 1500 UIT";
            this.chkIngresosMayores.Size = new System.Drawing.Size(330, 18);
            this.chkIngresosMayores.StyleController = this.layoutControl1;
            this.chkIngresosMayores.TabIndex = 158;
            // 
            // cboppto
            // 
            this.cboppto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(218)))), ((int)(((byte)(231)))));
            this.cboppto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboppto.Enabled = false;
            this.cboppto.FormattingEnabled = true;
            this.cboppto.Location = new System.Drawing.Point(524, 99);
            this.cboppto.Name = "cboppto";
            this.cboppto.Size = new System.Drawing.Size(258, 21);
            this.cboppto.TabIndex = 147;
            this.cboppto.SelectionChangeCommitted += new System.EventHandler(this.cboppto_SelectionChangeCommitted);
            this.cboppto.Enter += new System.EventHandler(this.cboppto_Enter);
            // 
            // layoutControlItem10
            // 
            this.layoutControlItem10.Control = this.dtgconten;
            this.layoutControlItem10.Location = new System.Drawing.Point(0, 123);
            this.layoutControlItem10.Name = "layoutControlItem10";
            this.layoutControlItem10.Size = new System.Drawing.Size(1083, 168);
            this.layoutControlItem10.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem10.TextVisible = false;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.emptySpaceItem1,
            this.layoutControlItem3,
            this.layoutControlItem4,
            this.layoutControlItem5,
            this.layoutControlItem7,
            this.layoutControlItem8,
            this.layoutControlItem9,
            this.layoutControlItem11,
            this.layoutControlItem13,
            this.layoutControlItem15,
            this.emptySpaceItem3,
            this.layoutControlItem12,
            this.layoutControlItem6,
            this.emptySpaceItem4,
            this.layoutControlItem14,
            this.layoutControlItem17,
            this.layoutControlItem18,
            this.layoutControlItem16,
            this.emptySpaceItem2,
            this.emptySpaceItem5});
            this.layoutControlGroup1.Name = "Root";
            this.layoutControlGroup1.Size = new System.Drawing.Size(1083, 352);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.txtruc;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(399, 22);
            this.layoutControlItem1.Text = "Ruc:";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(93, 13);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.cbotipo;
            this.layoutControlItem2.Location = new System.Drawing.Point(422, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(139, 23);
            this.layoutControlItem2.Text = "Tipo Id:";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(93, 13);
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(650, 68);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(423, 25);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.txtnroid;
            this.layoutControlItem3.Location = new System.Drawing.Point(561, 0);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(151, 23);
            this.layoutControlItem3.Text = "Id Representante:";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(93, 13);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.cbonombre;
            this.layoutControlItem4.Location = new System.Drawing.Point(712, 0);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(361, 23);
            this.layoutControlItem4.Text = "Nombre:";
            this.layoutControlItem4.TextSize = new System.Drawing.Size(93, 13);
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.txtnombre;
            this.layoutControlItem5.Location = new System.Drawing.Point(0, 22);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(399, 22);
            this.layoutControlItem5.Text = "Nombre:";
            this.layoutControlItem5.TextSize = new System.Drawing.Size(93, 13);
            // 
            // layoutControlItem7
            // 
            this.layoutControlItem7.Control = this.cbodep;
            this.layoutControlItem7.Location = new System.Drawing.Point(0, 44);
            this.layoutControlItem7.Name = "layoutControlItem7";
            this.layoutControlItem7.Size = new System.Drawing.Size(399, 23);
            this.layoutControlItem7.Text = "Departamento:";
            this.layoutControlItem7.TextSize = new System.Drawing.Size(93, 13);
            // 
            // layoutControlItem8
            // 
            this.layoutControlItem8.Control = this.cbopro;
            this.layoutControlItem8.Location = new System.Drawing.Point(422, 45);
            this.layoutControlItem8.Name = "layoutControlItem8";
            this.layoutControlItem8.Size = new System.Drawing.Size(204, 23);
            this.layoutControlItem8.Text = "Provincia:";
            this.layoutControlItem8.TextSize = new System.Drawing.Size(93, 13);
            // 
            // layoutControlItem9
            // 
            this.layoutControlItem9.Control = this.cbodis;
            this.layoutControlItem9.Location = new System.Drawing.Point(649, 45);
            this.layoutControlItem9.Name = "layoutControlItem9";
            this.layoutControlItem9.Size = new System.Drawing.Size(424, 23);
            this.layoutControlItem9.Text = "Distrito:";
            this.layoutControlItem9.TextSize = new System.Drawing.Size(93, 13);
            // 
            // layoutControlItem11
            // 
            this.layoutControlItem11.Control = this.cbosector;
            this.layoutControlItem11.Location = new System.Drawing.Point(0, 67);
            this.layoutControlItem11.MaxSize = new System.Drawing.Size(399, 26);
            this.layoutControlItem11.MinSize = new System.Drawing.Size(399, 26);
            this.layoutControlItem11.Name = "layoutControlItem11";
            this.layoutControlItem11.Size = new System.Drawing.Size(399, 26);
            this.layoutControlItem11.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem11.Text = "Sector Empresarial:";
            this.layoutControlItem11.TextSize = new System.Drawing.Size(93, 13);
            // 
            // layoutControlItem13
            // 
            this.layoutControlItem13.Control = this.cboseguro;
            this.layoutControlItem13.Location = new System.Drawing.Point(423, 68);
            this.layoutControlItem13.Name = "layoutControlItem13";
            this.layoutControlItem13.Size = new System.Drawing.Size(203, 25);
            this.layoutControlItem13.Text = "Cia. Seguro:";
            this.layoutControlItem13.TextSize = new System.Drawing.Size(93, 13);
            // 
            // layoutControlItem15
            // 
            this.layoutControlItem15.Control = this.chkStock;
            this.layoutControlItem15.Location = new System.Drawing.Point(0, 93);
            this.layoutControlItem15.MaxSize = new System.Drawing.Size(67, 24);
            this.layoutControlItem15.MinSize = new System.Drawing.Size(67, 24);
            this.layoutControlItem15.Name = "layoutControlItem15";
            this.layoutControlItem15.Size = new System.Drawing.Size(67, 24);
            this.layoutControlItem15.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem15.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem15.TextVisible = false;
            // 
            // emptySpaceItem3
            // 
            this.emptySpaceItem3.AllowHotTrack = false;
            this.emptySpaceItem3.Location = new System.Drawing.Point(399, 0);
            this.emptySpaceItem3.MaxSize = new System.Drawing.Size(23, 68);
            this.emptySpaceItem3.MinSize = new System.Drawing.Size(23, 68);
            this.emptySpaceItem3.Name = "emptySpaceItem3";
            this.emptySpaceItem3.Size = new System.Drawing.Size(23, 68);
            this.emptySpaceItem3.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.emptySpaceItem3.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem12
            // 
            this.layoutControlItem12.Control = this.btnsector;
            this.layoutControlItem12.Location = new System.Drawing.Point(399, 68);
            this.layoutControlItem12.MaxSize = new System.Drawing.Size(24, 25);
            this.layoutControlItem12.MinSize = new System.Drawing.Size(24, 25);
            this.layoutControlItem12.Name = "layoutControlItem12";
            this.layoutControlItem12.Size = new System.Drawing.Size(24, 25);
            this.layoutControlItem12.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem12.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem12.TextVisible = false;
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.txtdireccion;
            this.layoutControlItem6.Location = new System.Drawing.Point(422, 23);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(651, 22);
            this.layoutControlItem6.Text = "Dirección:";
            this.layoutControlItem6.TextSize = new System.Drawing.Size(93, 13);
            // 
            // emptySpaceItem4
            // 
            this.emptySpaceItem4.AllowHotTrack = false;
            this.emptySpaceItem4.Location = new System.Drawing.Point(626, 45);
            this.emptySpaceItem4.Name = "emptySpaceItem4";
            this.emptySpaceItem4.Size = new System.Drawing.Size(23, 23);
            this.emptySpaceItem4.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem14
            // 
            this.layoutControlItem14.Control = this.btnciaseguro;
            this.layoutControlItem14.Location = new System.Drawing.Point(626, 68);
            this.layoutControlItem14.MaxSize = new System.Drawing.Size(24, 25);
            this.layoutControlItem14.MinSize = new System.Drawing.Size(24, 25);
            this.layoutControlItem14.Name = "layoutControlItem14";
            this.layoutControlItem14.Size = new System.Drawing.Size(24, 25);
            this.layoutControlItem14.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem14.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem14.TextVisible = false;
            // 
            // layoutControlItem17
            // 
            this.layoutControlItem17.Control = this.gridControl1;
            this.layoutControlItem17.Location = new System.Drawing.Point(0, 117);
            this.layoutControlItem17.Name = "layoutControlItem17";
            this.layoutControlItem17.Size = new System.Drawing.Size(1073, 225);
            this.layoutControlItem17.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem17.TextVisible = false;
            // 
            // layoutControlItem18
            // 
            this.layoutControlItem18.Control = this.cboppto;
            this.layoutControlItem18.ControlAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.layoutControlItem18.CustomizationFormText = "Departamento:";
            this.layoutControlItem18.Location = new System.Drawing.Point(422, 93);
            this.layoutControlItem18.MaxSize = new System.Drawing.Size(356, 24);
            this.layoutControlItem18.MinSize = new System.Drawing.Size(356, 24);
            this.layoutControlItem18.Name = "layoutControlItem18";
            this.layoutControlItem18.Size = new System.Drawing.Size(356, 24);
            this.layoutControlItem18.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem18.Text = "Presupuesto";
            this.layoutControlItem18.TextSize = new System.Drawing.Size(93, 13);
            // 
            // layoutControlItem16
            // 
            this.layoutControlItem16.Control = this.chkIngresosMayores;
            this.layoutControlItem16.Location = new System.Drawing.Point(67, 93);
            this.layoutControlItem16.MaxSize = new System.Drawing.Size(332, 24);
            this.layoutControlItem16.MinSize = new System.Drawing.Size(332, 24);
            this.layoutControlItem16.Name = "layoutControlItem16";
            this.layoutControlItem16.Size = new System.Drawing.Size(332, 24);
            this.layoutControlItem16.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem16.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem16.TextVisible = false;
            // 
            // emptySpaceItem2
            // 
            this.emptySpaceItem2.AllowHotTrack = false;
            this.emptySpaceItem2.Location = new System.Drawing.Point(778, 93);
            this.emptySpaceItem2.Name = "emptySpaceItem2";
            this.emptySpaceItem2.Size = new System.Drawing.Size(295, 24);
            this.emptySpaceItem2.TextSize = new System.Drawing.Size(0, 0);
            // 
            // emptySpaceItem5
            // 
            this.emptySpaceItem5.AllowHotTrack = false;
            this.emptySpaceItem5.Location = new System.Drawing.Point(399, 93);
            this.emptySpaceItem5.MaxSize = new System.Drawing.Size(23, 24);
            this.emptySpaceItem5.MinSize = new System.Drawing.Size(23, 24);
            this.emptySpaceItem5.Name = "emptySpaceItem5";
            this.emptySpaceItem5.Size = new System.Drawing.Size(23, 24);
            this.emptySpaceItem5.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.emptySpaceItem5.TextSize = new System.Drawing.Size(0, 0);
            // 
            // frmEmpresas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1083, 394);
            this.Controls.Add(this.layoutControl1);
            this.Controls.Add(this.lbltotalregistros);
            this.Controls.Add(this.btncancelar);
            this.Controls.Add(this.btnaceptar);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.MinimumSize = new System.Drawing.Size(1099, 433);
            this.Name = "frmEmpresas";
            this.Nombre = "Empresas";
            this.Text = "Empresas";
            this.Load += new System.EventHandler(this.frmEmpresas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgconten)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkIngresosMayores.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem15)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem14)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem17)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem18)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem16)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cbotipo;
        private Dtgconten dtgconten;
        private System.Windows.Forms.Button btncancelar;
        private System.Windows.Forms.Button btnaceptar;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.TextBox txtruc;
        private System.Windows.Forms.TextBox txtdireccion;
        private System.Windows.Forms.TextBox txtnroid;
        private System.Windows.Forms.ComboBox cbosector;
        private System.Windows.Forms.ComboBox cbodep;
        private System.Windows.Forms.ComboBox cbopro;
        private System.Windows.Forms.ComboBox cbodis;
        private System.Windows.Forms.ComboBox cboseguro;
        private System.Windows.Forms.ComboBox cbonombre;
        private System.Windows.Forms.Button btnsector;
        private System.Windows.Forms.Button btnciaseguro;
        private System.Windows.Forms.Label lbltotalregistros;
        private checkboxOre chkStock;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem7;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem8;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem9;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem10;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem11;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem12;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem13;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem14;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem15;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraEditors.CheckEdit chkIngresosMayores;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem16;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem3;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem4;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem17;
        private DevExpress.XtraGrid.Columns.GridColumn xId_Empresa;
        private DevExpress.XtraGrid.Columns.GridColumn xRUC;
        private DevExpress.XtraGrid.Columns.GridColumn xEmpresa;
        private DevExpress.XtraGrid.Columns.GridColumn xSector_Empresarial;
        private DevExpress.XtraGrid.Columns.GridColumn xDireccion;
        private DevExpress.XtraGrid.Columns.GridColumn xCod_Dep;
        private DevExpress.XtraGrid.Columns.GridColumn xCod_Prov;
        private DevExpress.XtraGrid.Columns.GridColumn xCod_Dist;
        private DevExpress.XtraGrid.Columns.GridColumn xTipoID_Representado;
        private DevExpress.XtraGrid.Columns.GridColumn xNroID_Representado;
        private DevExpress.XtraGrid.Columns.GridColumn xCia_Seguro;
        private DevExpress.XtraGrid.Columns.GridColumn xUsuario;
        private DevExpress.XtraGrid.Columns.GridColumn xFecha;
        private DevExpress.XtraGrid.Columns.GridColumn xDesc_Sector_Empresarial;
        private DevExpress.XtraGrid.Columns.GridColumn xDepartamento;
        private DevExpress.XtraGrid.Columns.GridColumn xProvincia;
        private DevExpress.XtraGrid.Columns.GridColumn xDistrito;
        private DevExpress.XtraGrid.Columns.GridColumn xempleado;
        private DevExpress.XtraGrid.Columns.GridColumn xDesc_Tipo_ID;
        private DevExpress.XtraGrid.Columns.GridColumn xtipoid;
        private DevExpress.XtraGrid.Columns.GridColumn xcia;
        private DevExpress.XtraGrid.Columns.GridColumn xeps;
        private DevExpress.XtraGrid.Columns.GridColumn xstocks;
        private DevExpress.XtraBars.BarButtonItem btnnNuevo;
        private DevExpress.XtraBars.BarButtonItem btnnModificar;
        private DevExpress.XtraBars.BarButtonItem btnnEliminar;
        private DevExpress.XtraBars.BarButtonItem btnnAExcel;
        private DevExpress.XtraBars.BarButtonItem btnRepresentantes;
        private DevExpress.XtraGrid.Columns.GridColumn xppto;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn xStock;
        private System.Windows.Forms.DataGridViewTextBoxColumn xIngresosMayores;
        private System.Windows.Forms.DataGridViewTextBoxColumn yppto;
        private System.Windows.Forms.ComboBox cboppto;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem18;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem2;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem5;
    }
}