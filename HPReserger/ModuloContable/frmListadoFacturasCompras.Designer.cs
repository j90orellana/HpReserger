namespace SISGEM.ModuloContable
{
    partial class frmListadoFacturasCompras
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmListadoFacturasCompras));
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.btnFiltrar = new DevExpress.XtraEditors.SimpleButton();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.xEmpresa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.xProveedor = new DevExpress.XtraGrid.Columns.GridColumn();
            this.xRazonSocial = new DevExpress.XtraGrid.Columns.GridColumn();
            this.xIdComprobante = new DevExpress.XtraGrid.Columns.GridColumn();
            this.xComprobante = new DevExpress.XtraGrid.Columns.GridColumn();
            this.xNroComprobante = new DevExpress.XtraGrid.Columns.GridColumn();
            this.xFechaEmision = new DevExpress.XtraGrid.Columns.GridColumn();
            this.xTotal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.xGlosa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.xCompensacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.xEstadoCP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.dtpfecha = new DevExpress.XtraEditors.DateEdit();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar4 = new DevExpress.XtraBars.Bar();
            this.btnBuscar = new DevExpress.XtraBars.BarButtonItem();
            this.btnExcel = new DevExpress.XtraBars.BarButtonItem();
            this.btnDesagruparGrupos = new DevExpress.XtraBars.BarButtonItem();
            this.btnAgruparEmpresa = new DevExpress.XtraBars.BarButtonItem();
            this.btnAgruparProveedor = new DevExpress.XtraBars.BarButtonItem();
            this.btnAgruparxMes = new DevExpress.XtraBars.BarButtonItem();
            this.btnAgruparEstado = new DevExpress.XtraBars.BarButtonItem();
            this.btnAgrupar = new DevExpress.XtraBars.BarButtonItem();
            this.btnDesAgrupar = new DevExpress.XtraBars.BarButtonItem();
            this.btnCerrar = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.btnRefrescar = new DevExpress.XtraBars.BarButtonItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpfecha.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpfecha.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.btnFiltrar);
            this.layoutControl1.Controls.Add(this.gridControl1);
            this.layoutControl1.Controls.Add(this.dtpfecha);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 22);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(1206, 481);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnFiltrar.ImageOptions.Image")));
            this.btnFiltrar.Location = new System.Drawing.Point(255, 6);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(96, 22);
            this.btnFiltrar.StyleController = this.layoutControl1;
            this.btnFiltrar.TabIndex = 21;
            this.btnFiltrar.Text = "Listar";
            this.btnFiltrar.Click += new System.EventHandler(this.btnFiltrar_Click);
            // 
            // gridControl1
            // 
            this.gridControl1.Location = new System.Drawing.Point(6, 30);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1194, 445);
            this.gridControl1.TabIndex = 20;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.xEmpresa,
            this.xProveedor,
            this.xRazonSocial,
            this.xIdComprobante,
            this.xComprobante,
            this.xNroComprobante,
            this.xFechaEmision,
            this.xTotal,
            this.xGlosa,
            this.xCompensacion,
            this.xEstadoCP});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.GroupCount = 1;
            this.gridView1.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Total", this.xTotal, "{0:n2}", new decimal(new int[] {
                            0,
                            0,
                            0,
                            0})),
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Count, "Proveedor", this.xProveedor, "R. {0}", new decimal(new int[] {
                            0,
                            0,
                            0,
                            0}))});
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.AutoExpandAllGroups = true;
            this.gridView1.OptionsEditForm.EditFormColumnCount = 2;
            this.gridView1.OptionsFind.AlwaysVisible = true;
            this.gridView1.OptionsFind.FindNullPrompt = "Ingrese Texto a Buscar";
            this.gridView1.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
            this.gridView1.OptionsSelection.ShowCheckBoxSelectorInColumnHeader = DevExpress.Utils.DefaultBoolean.False;
            this.gridView1.OptionsSelection.ShowCheckBoxSelectorInGroupRow = DevExpress.Utils.DefaultBoolean.True;
            this.gridView1.OptionsView.ColumnAutoWidth = false;
            this.gridView1.OptionsView.ShowFooter = true;
            this.gridView1.OptionsView.ShowGroupedColumns = true;
            this.gridView1.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.xEmpresa, DevExpress.Data.ColumnSortOrder.Descending),
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.xFechaEmision, DevExpress.Data.ColumnSortOrder.Descending)});
            // 
            // xEmpresa
            // 
            this.xEmpresa.Caption = "Empresa";
            this.xEmpresa.FieldName = "Empresa";
            this.xEmpresa.GroupInterval = DevExpress.XtraGrid.ColumnGroupInterval.DisplayText;
            this.xEmpresa.MinWidth = 10;
            this.xEmpresa.Name = "xEmpresa";
            this.xEmpresa.OptionsColumn.ReadOnly = true;
            this.xEmpresa.SortMode = DevExpress.XtraGrid.ColumnSortMode.DisplayText;
            this.xEmpresa.Visible = true;
            this.xEmpresa.VisibleIndex = 0;
            this.xEmpresa.Width = 112;
            // 
            // xProveedor
            // 
            this.xProveedor.Caption = "Proveedor";
            this.xProveedor.FieldName = "Proveedor";
            this.xProveedor.MinWidth = 80;
            this.xProveedor.Name = "xProveedor";
            this.xProveedor.OptionsColumn.ReadOnly = true;
            this.xProveedor.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "Numero", "{0}")});
            this.xProveedor.Visible = true;
            this.xProveedor.VisibleIndex = 1;
            this.xProveedor.Width = 112;
            // 
            // xRazonSocial
            // 
            this.xRazonSocial.Caption = "Razon Social";
            this.xRazonSocial.FieldName = "RazonSocial";
            this.xRazonSocial.MaxWidth = 300;
            this.xRazonSocial.MinWidth = 100;
            this.xRazonSocial.Name = "xRazonSocial";
            this.xRazonSocial.OptionsColumn.ReadOnly = true;
            this.xRazonSocial.Visible = true;
            this.xRazonSocial.VisibleIndex = 2;
            this.xRazonSocial.Width = 100;
            // 
            // xIdComprobante
            // 
            this.xIdComprobante.Caption = "IdCP";
            this.xIdComprobante.FieldName = "IdComprobante";
            this.xIdComprobante.MaxWidth = 35;
            this.xIdComprobante.Name = "xIdComprobante";
            this.xIdComprobante.OptionsColumn.ReadOnly = true;
            this.xIdComprobante.Visible = true;
            this.xIdComprobante.VisibleIndex = 3;
            this.xIdComprobante.Width = 35;
            // 
            // xComprobante
            // 
            this.xComprobante.Caption = "Comprobante";
            this.xComprobante.FieldName = "Comprobante";
            this.xComprobante.MaxWidth = 80;
            this.xComprobante.MinWidth = 60;
            this.xComprobante.Name = "xComprobante";
            this.xComprobante.OptionsColumn.ReadOnly = true;
            this.xComprobante.Visible = true;
            this.xComprobante.VisibleIndex = 4;
            // 
            // xNroComprobante
            // 
            this.xNroComprobante.Caption = "NroComprobante";
            this.xNroComprobante.FieldName = "NroComprobante";
            this.xNroComprobante.MinWidth = 50;
            this.xNroComprobante.Name = "xNroComprobante";
            this.xNroComprobante.OptionsColumn.ReadOnly = true;
            this.xNroComprobante.Visible = true;
            this.xNroComprobante.VisibleIndex = 5;
            this.xNroComprobante.Width = 140;
            // 
            // xFechaEmision
            // 
            this.xFechaEmision.Caption = "Fecha Emision";
            this.xFechaEmision.DisplayFormat.FormatString = "d";
            this.xFechaEmision.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.xFechaEmision.FieldName = "FechaEmision";
            this.xFechaEmision.MaxWidth = 90;
            this.xFechaEmision.MinWidth = 90;
            this.xFechaEmision.Name = "xFechaEmision";
            this.xFechaEmision.OptionsColumn.ReadOnly = true;
            this.xFechaEmision.SortMode = DevExpress.XtraGrid.ColumnSortMode.Value;
            this.xFechaEmision.Visible = true;
            this.xFechaEmision.VisibleIndex = 6;
            this.xFechaEmision.Width = 90;
            // 
            // xTotal
            // 
            this.xTotal.Caption = "Total";
            this.xTotal.DisplayFormat.FormatString = "#,##0.00;(#,##0.00)";
            this.xTotal.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.xTotal.FieldName = "Total";
            this.xTotal.MaxWidth = 100;
            this.xTotal.MinWidth = 70;
            this.xTotal.Name = "xTotal";
            this.xTotal.OptionsColumn.ReadOnly = true;
            this.xTotal.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Total", "{0:n2}", new decimal(new int[] {
                            0,
                            0,
                            0,
                            0}))});
            this.xTotal.Visible = true;
            this.xTotal.VisibleIndex = 7;
            this.xTotal.Width = 99;
            // 
            // xGlosa
            // 
            this.xGlosa.Caption = "Glosa";
            this.xGlosa.FieldName = "Glosa";
            this.xGlosa.MaxWidth = 300;
            this.xGlosa.MinWidth = 100;
            this.xGlosa.Name = "xGlosa";
            this.xGlosa.OptionsColumn.ReadOnly = true;
            this.xGlosa.Visible = true;
            this.xGlosa.VisibleIndex = 8;
            this.xGlosa.Width = 100;
            // 
            // xCompensacion
            // 
            this.xCompensacion.Caption = "Compensacion";
            this.xCompensacion.FieldName = "Compensacion";
            this.xCompensacion.MinWidth = 80;
            this.xCompensacion.Name = "xCompensacion";
            this.xCompensacion.OptionsColumn.ReadOnly = true;
            this.xCompensacion.Visible = true;
            this.xCompensacion.VisibleIndex = 9;
            this.xCompensacion.Width = 80;
            // 
            // xEstadoCP
            // 
            this.xEstadoCP.Caption = "EstadoCP";
            this.xEstadoCP.FieldName = "EstadoCP";
            this.xEstadoCP.MinWidth = 60;
            this.xEstadoCP.Name = "xEstadoCP";
            this.xEstadoCP.OptionsColumn.ReadOnly = true;
            this.xEstadoCP.Visible = true;
            this.xEstadoCP.VisibleIndex = 10;
            this.xEstadoCP.Width = 60;
            // 
            // dtpfecha
            // 
            this.dtpfecha.EditValue = null;
            this.dtpfecha.Location = new System.Drawing.Point(69, 6);
            this.dtpfecha.Name = "dtpfecha";
            this.dtpfecha.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtpfecha.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtpfecha.Properties.DisplayFormat.FormatString = "yyyy";
            this.dtpfecha.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dtpfecha.Properties.Mask.EditMask = "yyyy";
            this.dtpfecha.Properties.VistaCalendarInitialViewStyle = DevExpress.XtraEditors.VistaCalendarInitialViewStyle.YearView;
            this.dtpfecha.Size = new System.Drawing.Size(184, 20);
            this.dtpfecha.StyleController = this.layoutControl1;
            this.dtpfecha.TabIndex = 18;
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem4,
            this.layoutControlItem2,
            this.emptySpaceItem1});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(1206, 481);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.gridControl1;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 24);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(1196, 447);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.dtpfecha;
            this.layoutControlItem4.ControlAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.layoutControlItem4.CustomizationFormText = "Fecha Hasta";
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem4.MaxSize = new System.Drawing.Size(249, 24);
            this.layoutControlItem4.MinSize = new System.Drawing.Size(249, 24);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(249, 24);
            this.layoutControlItem4.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem4.Text = "Fecha Hasta";
            this.layoutControlItem4.TextSize = new System.Drawing.Size(60, 13);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.btnFiltrar;
            this.layoutControlItem2.Location = new System.Drawing.Point(249, 0);
            this.layoutControlItem2.MaxSize = new System.Drawing.Size(98, 24);
            this.layoutControlItem2.MinSize = new System.Drawing.Size(98, 24);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(98, 24);
            this.layoutControlItem2.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(347, 0);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(849, 24);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar4});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btnCerrar,
            this.btnBuscar,
            this.btnRefrescar,
            this.btnExcel,
            this.btnAgrupar,
            this.btnDesAgrupar,
            this.btnAgruparProveedor,
            this.btnAgruparxMes,
            this.btnAgruparEmpresa,
            this.btnAgruparEstado,
            this.btnDesagruparGrupos});
            this.barManager1.MainMenu = this.bar4;
            this.barManager1.MaxItemId = 15;
            // 
            // bar4
            // 
            this.bar4.BarName = "Menú principal";
            this.bar4.DockCol = 0;
            this.bar4.DockRow = 0;
            this.bar4.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar4.FloatLocation = new System.Drawing.Point(432, 133);
            this.bar4.FloatSize = new System.Drawing.Size(169, 44);
            this.bar4.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnBuscar, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnExcel, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnDesagruparGrupos, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnAgruparEmpresa, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnAgruparProveedor, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnAgruparxMes, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnAgruparEstado, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnAgrupar, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnDesAgrupar, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnCerrar, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar4.OptionsBar.AllowQuickCustomization = false;
            this.bar4.OptionsBar.DrawBorder = false;
            this.bar4.OptionsBar.MultiLine = true;
            this.bar4.OptionsBar.UseWholeRow = true;
            this.bar4.Text = "Menú principal";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Caption = "Listar";
            this.btnBuscar.Id = 5;
            this.btnBuscar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscar.ImageOptions.Image")));
            this.btnBuscar.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnBuscar.ImageOptions.LargeImage")));
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnBuscar_ItemClick);
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
            // btnDesagruparGrupos
            // 
            this.btnDesagruparGrupos.Caption = "Desagrupar";
            this.btnDesagruparGrupos.Id = 14;
            this.btnDesagruparGrupos.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDesagruparGrupos.ImageOptions.Image")));
            this.btnDesagruparGrupos.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnDesagruparGrupos.ImageOptions.LargeImage")));
            this.btnDesagruparGrupos.Name = "btnDesagruparGrupos";
            this.btnDesagruparGrupos.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDesagruparGrupos_ItemClick);
            // 
            // btnAgruparEmpresa
            // 
            this.btnAgruparEmpresa.Caption = "Agrupar Empresas";
            this.btnAgruparEmpresa.Id = 12;
            this.btnAgruparEmpresa.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnAgruparEmpresa.ImageOptions.Image")));
            this.btnAgruparEmpresa.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnAgruparEmpresa.ImageOptions.LargeImage")));
            this.btnAgruparEmpresa.Name = "btnAgruparEmpresa";
            this.btnAgruparEmpresa.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnAgruparEmpresa_ItemClick);
            // 
            // btnAgruparProveedor
            // 
            this.btnAgruparProveedor.Caption = "Agrupar Proveedor";
            this.btnAgruparProveedor.Id = 10;
            this.btnAgruparProveedor.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnAgruparProveedor.ImageOptions.Image")));
            this.btnAgruparProveedor.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnAgruparProveedor.ImageOptions.LargeImage")));
            this.btnAgruparProveedor.Name = "btnAgruparProveedor";
            this.btnAgruparProveedor.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnAgruparProveedor_ItemClick);
            // 
            // btnAgruparxMes
            // 
            this.btnAgruparxMes.Caption = "Agrupar x Mes";
            this.btnAgruparxMes.Id = 11;
            this.btnAgruparxMes.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnAgruparxMes.ImageOptions.Image")));
            this.btnAgruparxMes.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnAgruparxMes.ImageOptions.LargeImage")));
            this.btnAgruparxMes.Name = "btnAgruparxMes";
            this.btnAgruparxMes.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnAgruparxMes_ItemClick);
            // 
            // btnAgruparEstado
            // 
            this.btnAgruparEstado.Caption = "Agrupar Estado";
            this.btnAgruparEstado.Id = 13;
            this.btnAgruparEstado.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnAgruparEstado.ImageOptions.Image")));
            this.btnAgruparEstado.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnAgruparEstado.ImageOptions.LargeImage")));
            this.btnAgruparEstado.Name = "btnAgruparEstado";
            this.btnAgruparEstado.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnAgruparEstado_ItemClick);
            // 
            // btnAgrupar
            // 
            this.btnAgrupar.Caption = "Expandir Grupo";
            this.btnAgrupar.Id = 8;
            this.btnAgrupar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnAgrupar.ImageOptions.Image")));
            this.btnAgrupar.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnAgrupar.ImageOptions.LargeImage")));
            this.btnAgrupar.Name = "btnAgrupar";
            this.btnAgrupar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnAgrupar_ItemClick);
            // 
            // btnDesAgrupar
            // 
            this.btnDesAgrupar.Caption = "Contraer Grupo";
            this.btnDesAgrupar.Id = 9;
            this.btnDesAgrupar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDesAgrupar.ImageOptions.Image")));
            this.btnDesAgrupar.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnDesAgrupar.ImageOptions.LargeImage")));
            this.btnDesAgrupar.Name = "btnDesAgrupar";
            this.btnDesAgrupar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDesAgrupar_ItemClick);
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
            this.barDockControlTop.Size = new System.Drawing.Size(1206, 22);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 503);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1206, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 22);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 481);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1206, 22);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 481);
            // 
            // btnRefrescar
            // 
            this.btnRefrescar.Caption = "Refrescar";
            this.btnRefrescar.Id = 6;
            this.btnRefrescar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnRefrescar.ImageOptions.Image")));
            this.btnRefrescar.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnRefrescar.ImageOptions.LargeImage")));
            this.btnRefrescar.Name = "btnRefrescar";
            this.btnRefrescar.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            // 
            // frmListadoFacturasCompras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1206, 503);
            this.Controls.Add(this.layoutControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.IconOptions.Icon = ((System.Drawing.Icon)(resources.GetObject("frmListadoFacturasCompras.IconOptions.Icon")));
            this.Name = "frmListadoFacturasCompras";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Listado de Facturas de Compra";
            this.Load += new System.EventHandler(this.frmListadoFacturasCompras_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpfecha.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpfecha.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar4;
        private DevExpress.XtraBars.BarButtonItem btnBuscar;
        private DevExpress.XtraBars.BarButtonItem btnRefrescar;
        private DevExpress.XtraBars.BarButtonItem btnExcel;
        private DevExpress.XtraBars.BarButtonItem btnAgrupar;
        private DevExpress.XtraBars.BarButtonItem btnDesAgrupar;
        private DevExpress.XtraBars.BarButtonItem btnAgruparProveedor;
        private DevExpress.XtraBars.BarButtonItem btnCerrar;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn xEmpresa;
        private DevExpress.XtraGrid.Columns.GridColumn xEstadoCP;
        private DevExpress.XtraGrid.Columns.GridColumn xComprobante;
        private DevExpress.XtraGrid.Columns.GridColumn xGlosa;
        private DevExpress.XtraGrid.Columns.GridColumn xProveedor;
        private DevExpress.XtraGrid.Columns.GridColumn xRazonSocial;
        private DevExpress.XtraGrid.Columns.GridColumn xIdComprobante;
        private DevExpress.XtraGrid.Columns.GridColumn xCompensacion;
        private DevExpress.XtraGrid.Columns.GridColumn xNroComprobante;
        private DevExpress.XtraGrid.Columns.GridColumn xTotal;
        private DevExpress.XtraGrid.Columns.GridColumn xFechaEmision;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraEditors.DateEdit dtpfecha;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraEditors.SimpleButton btnFiltrar;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraBars.BarButtonItem btnAgruparxMes;
        private DevExpress.XtraBars.BarButtonItem btnAgruparEmpresa;
        private DevExpress.XtraBars.BarButtonItem btnAgruparEstado;
        private DevExpress.XtraBars.BarButtonItem btnDesagruparGrupos;
    }
}