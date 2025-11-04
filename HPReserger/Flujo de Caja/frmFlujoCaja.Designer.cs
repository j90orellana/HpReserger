namespace SISGEM.Flujo_de_Caja
{
    partial class frmFlujoCaja
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFlujoCaja));
            DevExpress.XtraPivotGrid.PivotGridGroup pivotGridGroup2 = new DevExpress.XtraPivotGrid.PivotGridGroup();
            this.xTipo = new DevExpress.XtraPivotGrid.PivotGridField();
            this.pivotGridFieldPartidaPadre = new DevExpress.XtraPivotGrid.PivotGridField();
            this.xPresupuesto = new DevExpress.XtraPivotGrid.PivotGridField();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.chkMovimientos = new DevExpress.XtraEditors.CheckButton();
            this.chkPagos = new DevExpress.XtraEditors.CheckButton();
            this.chkVentas = new DevExpress.XtraEditors.CheckButton();
            this.chkCompras = new DevExpress.XtraEditors.CheckButton();
            this.btnBuscarFacturas = new DevExpress.XtraEditors.SimpleButton();
            this.cboEmpresa = new DevExpress.XtraEditors.LookUpEdit();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.btnBuscar = new DevExpress.XtraBars.BarButtonItem();
            this.btnRefrescar = new DevExpress.XtraBars.BarButtonItem();
            this.btnExcel = new DevExpress.XtraBars.BarButtonItem();
            this.btnCerrar = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.pivotGridControl1 = new DevExpress.XtraPivotGrid.PivotGridControl();
            this.pivotGridFieldAnio = new DevExpress.XtraPivotGrid.PivotGridField();
            this.xPEN = new DevExpress.XtraPivotGrid.PivotGridField();
            this.pivotGridField1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.pivotGridFieldMes = new DevExpress.XtraPivotGrid.PivotGridField();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.emptySpaceItem2 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem3 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem7 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cboEmpresa.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pivotGridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            this.SuspendLayout();
            // 
            // xTipo
            // 
            this.xTipo.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.xTipo.AreaIndex = 0;
            this.xTipo.Caption = "Tipo";
            this.xTipo.FieldName = "Tipo";
            this.xTipo.Name = "xTipo";
            this.xTipo.Options.HideEmptyVariationItems = true;
            // 
            // pivotGridFieldPartidaPadre
            // 
            this.pivotGridFieldPartidaPadre.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.pivotGridFieldPartidaPadre.AreaIndex = 1;
            this.pivotGridFieldPartidaPadre.Caption = "Partida Padre";
            this.pivotGridFieldPartidaPadre.FieldName = "PartidaPadre";
            this.pivotGridFieldPartidaPadre.MinWidth = 90;
            this.pivotGridFieldPartidaPadre.Name = "pivotGridFieldPartidaPadre";
            this.pivotGridFieldPartidaPadre.Options.HideEmptyVariationItems = true;
            this.pivotGridFieldPartidaPadre.Width = 120;
            // 
            // xPresupuesto
            // 
            this.xPresupuesto.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.xPresupuesto.AreaIndex = 2;
            this.xPresupuesto.Caption = "Presupuesto";
            this.xPresupuesto.FieldName = "Presupuesto";
            this.xPresupuesto.Name = "xPresupuesto";
            this.xPresupuesto.Options.HideEmptyVariationItems = true;
            this.xPresupuesto.Width = 120;
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.chkMovimientos);
            this.layoutControl1.Controls.Add(this.chkPagos);
            this.layoutControl1.Controls.Add(this.chkVentas);
            this.layoutControl1.Controls.Add(this.chkCompras);
            this.layoutControl1.Controls.Add(this.btnBuscarFacturas);
            this.layoutControl1.Controls.Add(this.cboEmpresa);
            this.layoutControl1.Controls.Add(this.pivotGridControl1);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 22);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(-922, 260, 650, 640);
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(756, 452);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // chkMovimientos
            // 
            this.chkMovimientos.Checked = true;
            this.chkMovimientos.Location = new System.Drawing.Point(6, 28);
            this.chkMovimientos.Name = "chkMovimientos";
            this.chkMovimientos.Size = new System.Drawing.Size(99, 22);
            this.chkMovimientos.StyleController = this.layoutControl1;
            this.chkMovimientos.TabIndex = 20;
            this.chkMovimientos.Text = "Mov. Bancarios";
            this.chkMovimientos.CheckedChanged += new System.EventHandler(this.chkMovimientos_CheckedChanged);
            // 
            // chkPagos
            // 
            this.chkPagos.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("chkPagos.ImageOptions.Image")));
            this.chkPagos.Location = new System.Drawing.Point(238, 28);
            this.chkPagos.Name = "chkPagos";
            this.chkPagos.Size = new System.Drawing.Size(55, 22);
            this.chkPagos.StyleController = this.layoutControl1;
            this.chkPagos.TabIndex = 19;
            this.chkPagos.Text = "Pagos";
            // 
            // chkVentas
            // 
            this.chkVentas.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("chkVentas.ImageOptions.Image")));
            this.chkVentas.Location = new System.Drawing.Point(177, 28);
            this.chkVentas.Name = "chkVentas";
            this.chkVentas.Size = new System.Drawing.Size(59, 22);
            this.chkVentas.StyleController = this.layoutControl1;
            this.chkVentas.TabIndex = 18;
            this.chkVentas.Text = "Ventas";
            // 
            // chkCompras
            // 
            this.chkCompras.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("chkCompras.ImageOptions.Image")));
            this.chkCompras.Location = new System.Drawing.Point(107, 28);
            this.chkCompras.Name = "chkCompras";
            this.chkCompras.Size = new System.Drawing.Size(68, 22);
            this.chkCompras.StyleController = this.layoutControl1;
            this.chkCompras.TabIndex = 17;
            this.chkCompras.Text = "Compras";
            this.chkCompras.CheckedChanged += new System.EventHandler(this.chkCompras_CheckedChanged);
            // 
            // btnBuscarFacturas
            // 
            this.btnBuscarFacturas.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscarFacturas.ImageOptions.Image")));
            this.btnBuscarFacturas.Location = new System.Drawing.Point(481, 28);
            this.btnBuscarFacturas.Name = "btnBuscarFacturas";
            this.btnBuscarFacturas.Size = new System.Drawing.Size(74, 22);
            this.btnBuscarFacturas.StyleController = this.layoutControl1;
            this.btnBuscarFacturas.TabIndex = 16;
            this.btnBuscarFacturas.Text = "Buscar";
            this.btnBuscarFacturas.Click += new System.EventHandler(this.btnBuscarFacturas_Click);
            // 
            // cboEmpresa
            // 
            this.cboEmpresa.Location = new System.Drawing.Point(90, 6);
            this.cboEmpresa.MenuManager = this.barManager1;
            this.cboEmpresa.Name = "cboEmpresa";
            this.cboEmpresa.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboEmpresa.Properties.NullText = "";
            this.cboEmpresa.Size = new System.Drawing.Size(389, 20);
            this.cboEmpresa.StyleController = this.layoutControl1;
            this.cboEmpresa.TabIndex = 11;
            this.cboEmpresa.EditValueChanged += new System.EventHandler(this.cboEmpresa_EditValueChanged);
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar1});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btnCerrar,
            this.btnBuscar,
            this.btnRefrescar,
            this.btnExcel});
            this.barManager1.MainMenu = this.bar1;
            this.barManager1.MaxItemId = 8;
            // 
            // bar1
            // 
            this.bar1.BarName = "Menú principal";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 0;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.FloatLocation = new System.Drawing.Point(432, 133);
            this.bar1.FloatSize = new System.Drawing.Size(169, 44);
            this.bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnBuscar, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnRefrescar, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnExcel, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnCerrar, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar1.OptionsBar.AllowQuickCustomization = false;
            this.bar1.OptionsBar.DrawBorder = false;
            this.bar1.OptionsBar.MultiLine = true;
            this.bar1.OptionsBar.UseWholeRow = true;
            this.bar1.Text = "Menú principal";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Caption = "Buscar";
            this.btnBuscar.Id = 5;
            this.btnBuscar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscar.ImageOptions.Image")));
            this.btnBuscar.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnBuscar.ImageOptions.LargeImage")));
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnBuscar_ItemClick);
            // 
            // btnRefrescar
            // 
            this.btnRefrescar.Caption = "Refrescar";
            this.btnRefrescar.Id = 6;
            this.btnRefrescar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnRefrescar.ImageOptions.Image")));
            this.btnRefrescar.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnRefrescar.ImageOptions.LargeImage")));
            this.btnRefrescar.Name = "btnRefrescar";
            this.btnRefrescar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnRefrescar_ItemClick);
            // 
            // btnExcel
            // 
            this.btnExcel.Caption = "Excel";
            this.btnExcel.Id = 7;
            this.btnExcel.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnExcel.ImageOptions.Image")));
            this.btnExcel.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnExcel.ImageOptions.LargeImage")));
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnExcel_ItemClick);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Caption = "Cerrar";
            this.btnCerrar.Id = 1;
            this.btnCerrar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrar.ImageOptions.Image")));
            this.btnCerrar.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnCerrar.ImageOptions.LargeImage")));
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnCerrar_ItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(756, 22);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 474);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(756, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 22);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 452);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(756, 22);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 452);
            // 
            // pivotGridControl1
            // 
            this.pivotGridControl1.Fields.AddRange(new DevExpress.XtraPivotGrid.PivotGridField[] {
            this.xTipo,
            this.xPresupuesto,
            this.pivotGridFieldAnio,
            this.xPEN,
            this.pivotGridField1,
            this.pivotGridFieldMes,
            this.pivotGridFieldPartidaPadre});
            pivotGridGroup2.Fields.Add(this.xTipo);
            pivotGridGroup2.Fields.Add(this.pivotGridFieldPartidaPadre);
            pivotGridGroup2.Fields.Add(this.xPresupuesto);
            this.pivotGridControl1.Groups.AddRange(new DevExpress.XtraPivotGrid.PivotGridGroup[] {
            pivotGridGroup2});
            this.pivotGridControl1.Location = new System.Drawing.Point(6, 52);
            this.pivotGridControl1.Name = "pivotGridControl1";
            this.pivotGridControl1.OptionsCustomization.AllowHideFields = DevExpress.XtraPivotGrid.AllowHideFieldsType.Never;
            this.pivotGridControl1.OptionsCustomization.CustomizationFormSearchBoxVisible = true;
            this.pivotGridControl1.OptionsPrint.PrintColumnAreaOnEveryPage = true;
            this.pivotGridControl1.OptionsPrint.PrintColumnHeaders = DevExpress.Utils.DefaultBoolean.True;
            this.pivotGridControl1.OptionsPrint.PrintDataHeaders = DevExpress.Utils.DefaultBoolean.True;
            this.pivotGridControl1.OptionsPrint.PrintFilterHeaders = DevExpress.Utils.DefaultBoolean.True;
            this.pivotGridControl1.OptionsPrint.PrintHorzLines = DevExpress.Utils.DefaultBoolean.True;
            this.pivotGridControl1.OptionsPrint.PrintRowAreaOnEveryPage = true;
            this.pivotGridControl1.OptionsPrint.PrintRowHeaders = DevExpress.Utils.DefaultBoolean.True;
            this.pivotGridControl1.OptionsPrint.PrintUnusedFilterFields = false;
            this.pivotGridControl1.OptionsPrint.PrintVertLines = DevExpress.Utils.DefaultBoolean.True;
            this.pivotGridControl1.OptionsView.ShowTotalsForSingleValues = true;
            this.pivotGridControl1.Size = new System.Drawing.Size(744, 394);
            this.pivotGridControl1.TabIndex = 4;
            this.pivotGridControl1.CustomFieldValueCells += new DevExpress.XtraPivotGrid.PivotCustomFieldValueCellsEventHandler(this.pivotGridControl1_CustomFieldValueCells);
            this.pivotGridControl1.FieldValueDisplayText += new DevExpress.XtraPivotGrid.PivotFieldDisplayTextEventHandler(this.pivotGridControl1_FieldValueDisplayText);
            this.pivotGridControl1.CustomCellDisplayText += new DevExpress.XtraPivotGrid.PivotCellDisplayTextEventHandler(this.pivotGridControl1_CustomCellDisplayText);
            // 
            // pivotGridFieldAnio
            // 
            this.pivotGridFieldAnio.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
            this.pivotGridFieldAnio.AreaIndex = 0;
            this.pivotGridFieldAnio.Caption = "Año";
            this.pivotGridFieldAnio.FieldName = "FechaEmision";
            this.pivotGridFieldAnio.GroupInterval = DevExpress.XtraPivotGrid.PivotGroupInterval.DateYear;
            this.pivotGridFieldAnio.Name = "pivotGridFieldAnio";
            this.pivotGridFieldAnio.UnboundFieldName = "pivotGridFieldAnio";
            this.pivotGridFieldAnio.ValueFormat.FormatString = "yyyy";
            this.pivotGridFieldAnio.ValueFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            // 
            // xPEN
            // 
            this.xPEN.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            this.xPEN.AreaIndex = 0;
            this.xPEN.Caption = "Soles";
            this.xPEN.FieldName = "PEN";
            this.xPEN.Name = "xPEN";
            this.xPEN.Options.HideEmptyVariationItems = true;
            this.xPEN.ValueFormat.FormatString = "0";
            this.xPEN.ValueFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            // 
            // pivotGridField1
            // 
            this.pivotGridField1.AreaIndex = 0;
            this.pivotGridField1.Caption = "Dolares";
            this.pivotGridField1.FieldName = "USD";
            this.pivotGridField1.Name = "pivotGridField1";
            this.pivotGridField1.Options.HideEmptyVariationItems = true;
            this.pivotGridField1.ValueFormat.FormatString = "0";
            this.pivotGridField1.ValueFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            // 
            // pivotGridFieldMes
            // 
            this.pivotGridFieldMes.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
            this.pivotGridFieldMes.AreaIndex = 1;
            this.pivotGridFieldMes.Caption = "Mes";
            this.pivotGridFieldMes.CellFormat.FormatString = "d";
            this.pivotGridFieldMes.CellFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.pivotGridFieldMes.FieldName = "FechaEmision";
            this.pivotGridFieldMes.GroupInterval = DevExpress.XtraPivotGrid.PivotGroupInterval.DateMonthYear;
            this.pivotGridFieldMes.Name = "pivotGridFieldMes";
            this.pivotGridFieldMes.UnboundFieldName = "pivotGridFieldMes";
            this.pivotGridFieldMes.ValueFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.emptySpaceItem1,
            this.emptySpaceItem2,
            this.layoutControlItem3,
            this.layoutControlItem5,
            this.layoutControlItem6,
            this.emptySpaceItem3,
            this.layoutControlItem7,
            this.layoutControlItem4});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(756, 452);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.pivotGridControl1;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 46);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(746, 396);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.cboEmpresa;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem2.MaxSize = new System.Drawing.Size(475, 22);
            this.layoutControlItem2.MinSize = new System.Drawing.Size(475, 22);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(475, 22);
            this.layoutControlItem2.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem2.Text = "Nombre Empresa";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(81, 13);
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(551, 22);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(195, 24);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // emptySpaceItem2
            // 
            this.emptySpaceItem2.AllowHotTrack = false;
            this.emptySpaceItem2.Location = new System.Drawing.Point(475, 0);
            this.emptySpaceItem2.Name = "emptySpaceItem2";
            this.emptySpaceItem2.Size = new System.Drawing.Size(271, 22);
            this.emptySpaceItem2.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.btnBuscarFacturas;
            this.layoutControlItem3.Location = new System.Drawing.Point(475, 22);
            this.layoutControlItem3.MaxSize = new System.Drawing.Size(76, 24);
            this.layoutControlItem3.MinSize = new System.Drawing.Size(76, 24);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(76, 24);
            this.layoutControlItem3.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextVisible = false;
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.chkVentas;
            this.layoutControlItem5.Location = new System.Drawing.Point(171, 22);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(61, 24);
            this.layoutControlItem5.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem5.TextVisible = false;
            this.layoutControlItem5.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.chkPagos;
            this.layoutControlItem6.Location = new System.Drawing.Point(232, 22);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(57, 24);
            this.layoutControlItem6.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem6.TextVisible = false;
            this.layoutControlItem6.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
            // 
            // emptySpaceItem3
            // 
            this.emptySpaceItem3.AllowHotTrack = false;
            this.emptySpaceItem3.Location = new System.Drawing.Point(289, 22);
            this.emptySpaceItem3.Name = "emptySpaceItem3";
            this.emptySpaceItem3.Size = new System.Drawing.Size(186, 24);
            this.emptySpaceItem3.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem7
            // 
            this.layoutControlItem7.Control = this.chkMovimientos;
            this.layoutControlItem7.Location = new System.Drawing.Point(0, 22);
            this.layoutControlItem7.Name = "layoutControlItem7";
            this.layoutControlItem7.Size = new System.Drawing.Size(101, 24);
            this.layoutControlItem7.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem7.TextVisible = false;
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.chkCompras;
            this.layoutControlItem4.Location = new System.Drawing.Point(101, 22);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(70, 24);
            this.layoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem4.TextVisible = false;
            this.layoutControlItem4.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
            // 
            // frmFlujoCaja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(756, 474);
            this.Controls.Add(this.layoutControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.IconOptions.Icon = ((System.Drawing.Icon)(resources.GetObject("frmFlujoCaja.IconOptions.Icon")));
            this.Name = "frmFlujoCaja";
            this.Text = "Flujo de Caja";
            this.Load += new System.EventHandler(this.frmFlujoCaja_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cboEmpresa.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pivotGridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraPivotGrid.PivotGridControl pivotGridControl1;
        private DevExpress.XtraPivotGrid.PivotGridField xTipo;
        private DevExpress.XtraPivotGrid.PivotGridField xPresupuesto;
        private DevExpress.XtraPivotGrid.PivotGridField pivotGridFieldAnio;
        private DevExpress.XtraPivotGrid.PivotGridField xPEN;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarButtonItem btnBuscar;
        private DevExpress.XtraBars.BarButtonItem btnRefrescar;
        private DevExpress.XtraBars.BarButtonItem btnExcel;
        private DevExpress.XtraBars.BarButtonItem btnCerrar;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraEditors.LookUpEdit cboEmpresa;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraEditors.SimpleButton btnBuscarFacturas;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem2;
        private DevExpress.XtraEditors.CheckButton chkPagos;
        private DevExpress.XtraEditors.CheckButton chkVentas;
        private DevExpress.XtraEditors.CheckButton chkCompras;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem3;
        private DevExpress.XtraPivotGrid.PivotGridField pivotGridFieldMes;
        private DevExpress.XtraPivotGrid.PivotGridField pivotGridField1;
        private DevExpress.XtraEditors.CheckButton chkMovimientos;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem7;
        private DevExpress.XtraPivotGrid.PivotGridField pivotGridFieldPartidaPadre;
    }
}