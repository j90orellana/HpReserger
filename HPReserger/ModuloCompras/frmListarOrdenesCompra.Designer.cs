namespace SISGEM.ModuloCompras
{
    partial class frmListarOrdenesCompra
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmListarOrdenesCompra));
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.btnFiltrar = new DevExpress.XtraEditors.SimpleButton();
            this.dtpfecha = new DevExpress.XtraEditors.DateEdit();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.xid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.xEmpresa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.xProveedor = new DevExpress.XtraGrid.Columns.GridColumn();
            this.xRazonSocial = new DevExpress.XtraGrid.Columns.GridColumn();
            this.xnumOrden = new DevExpress.XtraGrid.Columns.GridColumn();
            this.xFechaEmision = new DevExpress.XtraGrid.Columns.GridColumn();
            this.xfechaEntrega = new DevExpress.XtraGrid.Columns.GridColumn();
            this.xfechaPago = new DevExpress.XtraGrid.Columns.GridColumn();
            this.xMoneda = new DevExpress.XtraGrid.Columns.GridColumn();
            this.xTotal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.xnEstadoOrden = new DevExpress.XtraGrid.Columns.GridColumn();
            this.xNEstado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar4 = new DevExpress.XtraBars.Bar();
            this.btnBuscar = new DevExpress.XtraBars.BarButtonItem();
            this.btnVer = new DevExpress.XtraBars.BarButtonItem();
            this.bntEliminar = new DevExpress.XtraBars.BarButtonItem();
            this.btnExcel = new DevExpress.XtraBars.BarButtonItem();
            this.btnExportarPDF = new DevExpress.XtraBars.BarButtonItem();
            this.btnAgruparEmpresa = new DevExpress.XtraBars.BarButtonItem();
            this.btnAgruparProveedor = new DevExpress.XtraBars.BarButtonItem();
            this.btnAgruparEstado = new DevExpress.XtraBars.BarButtonItem();
            this.btnAgrupar = new DevExpress.XtraBars.BarButtonItem();
            this.btnDesAgrupar = new DevExpress.XtraBars.BarButtonItem();
            this.btnCerrar = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.btnRefrescar = new DevExpress.XtraBars.BarButtonItem();
            this.btnAgruparxMes = new DevExpress.XtraBars.BarButtonItem();
            this.btnDesagruparGrupos = new DevExpress.XtraBars.BarButtonItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtpfecha.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpfecha.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.btnFiltrar);
            this.layoutControl1.Controls.Add(this.dtpfecha);
            this.layoutControl1.Controls.Add(this.gridControl1);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 20);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(-744, 269, 650, 400);
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(1115, 481);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnFiltrar.ImageOptions.Image")));
            this.btnFiltrar.Location = new System.Drawing.Point(176, 6);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(52, 22);
            this.btnFiltrar.StyleController = this.layoutControl1;
            this.btnFiltrar.TabIndex = 23;
            this.btnFiltrar.Text = "Listar";
            this.btnFiltrar.Click += new System.EventHandler(this.btnFiltrar_Click);
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
            this.dtpfecha.Size = new System.Drawing.Size(105, 20);
            this.dtpfecha.StyleController = this.layoutControl1;
            this.dtpfecha.TabIndex = 22;
            // 
            // gridControl1
            // 
            this.gridControl1.Location = new System.Drawing.Point(6, 30);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1103, 445);
            this.gridControl1.TabIndex = 21;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.xid,
            this.xEmpresa,
            this.xProveedor,
            this.xRazonSocial,
            this.xnumOrden,
            this.xFechaEmision,
            this.xfechaEntrega,
            this.xfechaPago,
            this.xMoneda,
            this.xTotal,
            this.xnEstadoOrden,
            this.xNEstado});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.GroupCount = 1;
            this.gridView1.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "total", this.xTotal, "{0:n2}", new decimal(new int[] {
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
            this.gridView1.DoubleClick += new System.EventHandler(this.gridView1_DoubleClick);
            // 
            // xid
            // 
            this.xid.Caption = "id";
            this.xid.FieldName = "id";
            this.xid.Name = "xid";
            // 
            // xEmpresa
            // 
            this.xEmpresa.Caption = "Empresa";
            this.xEmpresa.FieldName = "empresa";
            this.xEmpresa.GroupInterval = DevExpress.XtraGrid.ColumnGroupInterval.DisplayText;
            this.xEmpresa.MinWidth = 10;
            this.xEmpresa.Name = "xEmpresa";
            this.xEmpresa.OptionsColumn.AllowEdit = false;
            this.xEmpresa.OptionsColumn.ReadOnly = true;
            this.xEmpresa.SortMode = DevExpress.XtraGrid.ColumnSortMode.DisplayText;
            this.xEmpresa.Visible = true;
            this.xEmpresa.VisibleIndex = 0;
            this.xEmpresa.Width = 112;
            // 
            // xProveedor
            // 
            this.xProveedor.Caption = "RUC";
            this.xProveedor.FieldName = "ruc";
            this.xProveedor.MaxWidth = 100;
            this.xProveedor.MinWidth = 80;
            this.xProveedor.Name = "xProveedor";
            this.xProveedor.OptionsColumn.ReadOnly = true;
            this.xProveedor.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "Numero", "{0}")});
            this.xProveedor.Visible = true;
            this.xProveedor.VisibleIndex = 1;
            this.xProveedor.Width = 100;
            // 
            // xRazonSocial
            // 
            this.xRazonSocial.Caption = "Razon Social";
            this.xRazonSocial.FieldName = "razonSocial";
            this.xRazonSocial.MinWidth = 120;
            this.xRazonSocial.Name = "xRazonSocial";
            this.xRazonSocial.OptionsColumn.AllowEdit = false;
            this.xRazonSocial.OptionsColumn.ReadOnly = true;
            this.xRazonSocial.Visible = true;
            this.xRazonSocial.VisibleIndex = 2;
            this.xRazonSocial.Width = 200;
            // 
            // xnumOrden
            // 
            this.xnumOrden.Caption = "NumOrden";
            this.xnumOrden.FieldName = "numOrden";
            this.xnumOrden.MaxWidth = 65;
            this.xnumOrden.MinWidth = 65;
            this.xnumOrden.Name = "xnumOrden";
            this.xnumOrden.OptionsColumn.ReadOnly = true;
            this.xnumOrden.Visible = true;
            this.xnumOrden.VisibleIndex = 3;
            this.xnumOrden.Width = 65;
            // 
            // xFechaEmision
            // 
            this.xFechaEmision.Caption = "Fecha Emision";
            this.xFechaEmision.DisplayFormat.FormatString = "d";
            this.xFechaEmision.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.xFechaEmision.FieldName = "fechaEmision";
            this.xFechaEmision.MaxWidth = 90;
            this.xFechaEmision.MinWidth = 90;
            this.xFechaEmision.Name = "xFechaEmision";
            this.xFechaEmision.OptionsColumn.AllowEdit = false;
            this.xFechaEmision.OptionsColumn.ReadOnly = true;
            this.xFechaEmision.SortMode = DevExpress.XtraGrid.ColumnSortMode.Value;
            this.xFechaEmision.Visible = true;
            this.xFechaEmision.VisibleIndex = 4;
            this.xFechaEmision.Width = 90;
            // 
            // xfechaEntrega
            // 
            this.xfechaEntrega.Caption = "Fecha Entrega";
            this.xfechaEntrega.DisplayFormat.FormatString = "d";
            this.xfechaEntrega.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.xfechaEntrega.FieldName = "fechaEntrega";
            this.xfechaEntrega.MaxWidth = 80;
            this.xfechaEntrega.MinWidth = 80;
            this.xfechaEntrega.Name = "xfechaEntrega";
            this.xfechaEntrega.OptionsColumn.AllowEdit = false;
            this.xfechaEntrega.OptionsColumn.ReadOnly = true;
            this.xfechaEntrega.Visible = true;
            this.xfechaEntrega.VisibleIndex = 5;
            this.xfechaEntrega.Width = 80;
            // 
            // xfechaPago
            // 
            this.xfechaPago.Caption = "Fecha Pago";
            this.xfechaPago.DisplayFormat.FormatString = "d";
            this.xfechaPago.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.xfechaPago.FieldName = "fechaPago";
            this.xfechaPago.MaxWidth = 80;
            this.xfechaPago.MinWidth = 80;
            this.xfechaPago.Name = "xfechaPago";
            this.xfechaPago.OptionsColumn.AllowEdit = false;
            this.xfechaPago.Visible = true;
            this.xfechaPago.VisibleIndex = 6;
            this.xfechaPago.Width = 80;
            // 
            // xMoneda
            // 
            this.xMoneda.Caption = "Moneda";
            this.xMoneda.FieldName = "Moneda";
            this.xMoneda.MaxWidth = 70;
            this.xMoneda.MinWidth = 70;
            this.xMoneda.Name = "xMoneda";
            this.xMoneda.OptionsColumn.AllowEdit = false;
            this.xMoneda.OptionsColumn.ReadOnly = true;
            this.xMoneda.Visible = true;
            this.xMoneda.VisibleIndex = 7;
            this.xMoneda.Width = 70;
            // 
            // xTotal
            // 
            this.xTotal.Caption = "Total";
            this.xTotal.DisplayFormat.FormatString = "#,##0.00;(#,##0.00)";
            this.xTotal.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.xTotal.FieldName = "total";
            this.xTotal.MaxWidth = 100;
            this.xTotal.MinWidth = 70;
            this.xTotal.Name = "xTotal";
            this.xTotal.OptionsColumn.AllowEdit = false;
            this.xTotal.OptionsColumn.ReadOnly = true;
            this.xTotal.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Total", "{0:n2}", new decimal(new int[] {
                            0,
                            0,
                            0,
                            0}))});
            this.xTotal.Visible = true;
            this.xTotal.VisibleIndex = 8;
            this.xTotal.Width = 99;
            // 
            // xnEstadoOrden
            // 
            this.xnEstadoOrden.Caption = "Estado Orden";
            this.xnEstadoOrden.FieldName = "nEstadoOrden";
            this.xnEstadoOrden.MaxWidth = 80;
            this.xnEstadoOrden.MinWidth = 80;
            this.xnEstadoOrden.Name = "xnEstadoOrden";
            this.xnEstadoOrden.OptionsColumn.AllowEdit = false;
            this.xnEstadoOrden.OptionsColumn.ReadOnly = true;
            this.xnEstadoOrden.Visible = true;
            this.xnEstadoOrden.VisibleIndex = 9;
            this.xnEstadoOrden.Width = 80;
            // 
            // xNEstado
            // 
            this.xNEstado.Caption = "Estado";
            this.xNEstado.FieldName = "NEstado";
            this.xNEstado.MaxWidth = 80;
            this.xNEstado.MinWidth = 60;
            this.xNEstado.Name = "xNEstado";
            this.xNEstado.OptionsColumn.AllowEdit = false;
            this.xNEstado.OptionsColumn.ReadOnly = true;
            this.xNEstado.Visible = true;
            this.xNEstado.VisibleIndex = 10;
            this.xNEstado.Width = 60;
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.layoutControlItem3,
            this.emptySpaceItem1});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(1115, 481);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.gridControl1;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 24);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(1105, 447);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.dtpfecha;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem2.MaxSize = new System.Drawing.Size(170, 24);
            this.layoutControlItem2.MinSize = new System.Drawing.Size(170, 24);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(170, 24);
            this.layoutControlItem2.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem2.Text = "Fecha Hasta";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(60, 13);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.btnFiltrar;
            this.layoutControlItem3.Location = new System.Drawing.Point(170, 0);
            this.layoutControlItem3.MaxSize = new System.Drawing.Size(54, 24);
            this.layoutControlItem3.MinSize = new System.Drawing.Size(54, 24);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(54, 24);
            this.layoutControlItem3.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextVisible = false;
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(224, 0);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(881, 24);
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
            this.btnDesagruparGrupos,
            this.btnExportarPDF,
            this.bntEliminar,
            this.btnVer});
            this.barManager1.MainMenu = this.bar4;
            this.barManager1.MaxItemId = 18;
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
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnVer, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.bntEliminar, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnExcel, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnExportarPDF, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnAgruparEmpresa, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnAgruparProveedor, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
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
            // btnVer
            // 
            this.btnVer.Caption = "Ver Orden";
            this.btnVer.Id = 17;
            this.btnVer.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnVer.ImageOptions.Image")));
            this.btnVer.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnVer.ImageOptions.LargeImage")));
            this.btnVer.Name = "btnVer";
            this.btnVer.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnVer_ItemClick);
            // 
            // bntEliminar
            // 
            this.bntEliminar.Caption = "Anular";
            this.bntEliminar.Id = 16;
            this.bntEliminar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("bntEliminar.ImageOptions.Image")));
            this.bntEliminar.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("bntEliminar.ImageOptions.LargeImage")));
            this.bntEliminar.Name = "bntEliminar";
            this.bntEliminar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bntEliminar_ItemClick);
            // 
            // btnExcel
            // 
            this.btnExcel.Caption = "Exportar Excel";
            this.btnExcel.Id = 7;
            this.btnExcel.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnExcel.ImageOptions.Image")));
            this.btnExcel.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnExcel.ImageOptions.LargeImage")));
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnExcel_ItemClick);
            // 
            // btnExportarPDF
            // 
            this.btnExportarPDF.Caption = "Exportar PDF";
            this.btnExportarPDF.Id = 15;
            this.btnExportarPDF.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnExportarPDF.ImageOptions.Image")));
            this.btnExportarPDF.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnExportarPDF.ImageOptions.LargeImage")));
            this.btnExportarPDF.Name = "btnExportarPDF";
            this.btnExportarPDF.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnExportarPDF_ItemClick);
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
            this.barDockControlTop.Size = new System.Drawing.Size(1115, 20);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 501);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1115, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 20);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 481);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1115, 20);
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
            // btnAgruparxMes
            // 
            this.btnAgruparxMes.Caption = "Agrupar x Mes";
            this.btnAgruparxMes.Id = 11;
            this.btnAgruparxMes.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnAgruparxMes.ImageOptions.Image")));
            this.btnAgruparxMes.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnAgruparxMes.ImageOptions.LargeImage")));
            this.btnAgruparxMes.Name = "btnAgruparxMes";
            // 
            // btnDesagruparGrupos
            // 
            this.btnDesagruparGrupos.Caption = "Desagrupar";
            this.btnDesagruparGrupos.Id = 14;
            this.btnDesagruparGrupos.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDesagruparGrupos.ImageOptions.Image")));
            this.btnDesagruparGrupos.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnDesagruparGrupos.ImageOptions.LargeImage")));
            this.btnDesagruparGrupos.Name = "btnDesagruparGrupos";
            // 
            // frmListarOrdenesCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1115, 501);
            this.Controls.Add(this.layoutControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.IconOptions.Icon = ((System.Drawing.Icon)(resources.GetObject("frmListarOrdenesCompra.IconOptions.Icon")));
            this.Name = "frmListarOrdenesCompra";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Listar Ordenes de Compra";
            this.Load += new System.EventHandler(this.frmListarOrdenesCompra_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtpfecha.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpfecha.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn xEmpresa;
        private DevExpress.XtraGrid.Columns.GridColumn xProveedor;
        private DevExpress.XtraGrid.Columns.GridColumn xRazonSocial;
        private DevExpress.XtraGrid.Columns.GridColumn xFechaEmision;
        private DevExpress.XtraGrid.Columns.GridColumn xTotal;
        private DevExpress.XtraGrid.Columns.GridColumn xMoneda;
        private DevExpress.XtraGrid.Columns.GridColumn xnEstadoOrden;
        private DevExpress.XtraGrid.Columns.GridColumn xNEstado;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraEditors.DateEdit dtpfecha;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraEditors.SimpleButton btnFiltrar;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar4;
        private DevExpress.XtraBars.BarButtonItem btnBuscar;
        private DevExpress.XtraBars.BarButtonItem btnExcel;
        private DevExpress.XtraBars.BarButtonItem btnDesagruparGrupos;
        private DevExpress.XtraBars.BarButtonItem btnAgruparEmpresa;
        private DevExpress.XtraBars.BarButtonItem btnAgruparProveedor;
        private DevExpress.XtraBars.BarButtonItem btnAgruparxMes;
        private DevExpress.XtraBars.BarButtonItem btnAgruparEstado;
        private DevExpress.XtraBars.BarButtonItem btnAgrupar;
        private DevExpress.XtraBars.BarButtonItem btnDesAgrupar;
        private DevExpress.XtraBars.BarButtonItem btnCerrar;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem btnRefrescar;
        private DevExpress.XtraGrid.Columns.GridColumn xid;
        private DevExpress.XtraGrid.Columns.GridColumn xfechaEntrega;
        private DevExpress.XtraGrid.Columns.GridColumn xfechaPago;
        private DevExpress.XtraBars.BarButtonItem btnExportarPDF;
        private DevExpress.XtraGrid.Columns.GridColumn xnumOrden;
        private DevExpress.XtraBars.BarButtonItem bntEliminar;
        private DevExpress.XtraBars.BarButtonItem btnVer;
    }
}