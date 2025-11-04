namespace SISGEM.ModuloContable
{
    partial class frmSaldoCuentasContables
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSaldoCuentasContables));
            this.dataLayoutControl1 = new DevExpress.XtraDataLayout.DataLayoutControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.xEmpresa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.xIdCuentaContable = new DevExpress.XtraGrid.Columns.GridColumn();
            this.xCuentaContable = new DevExpress.XtraGrid.Columns.GridColumn();
            this.xCUO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.xTipo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.xNumero = new DevExpress.XtraGrid.Columns.GridColumn();
            this.xRazon_Social = new DevExpress.XtraGrid.Columns.GridColumn();
            this.xIdComprobante = new DevExpress.XtraGrid.Columns.GridColumn();
            this.xCod_Comprobante = new DevExpress.XtraGrid.Columns.GridColumn();
            this.xNum_Comprobante = new DevExpress.XtraGrid.Columns.GridColumn();
            this.xImporte_MN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.xImporte_ME = new DevExpress.XtraGrid.Columns.GridColumn();
            this.xFechaEmision = new DevExpress.XtraGrid.Columns.GridColumn();
            this.xId_Aux = new DevExpress.XtraGrid.Columns.GridColumn();
            this.xId_Asiento_Contable = new DevExpress.XtraGrid.Columns.GridColumn();
            this.xidProyecto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.xFechaAsiento = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemCheckedComboBoxEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckedComboBoxEdit();
            this.repositoryItemButtonEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.dtpfecha = new DevExpress.XtraEditors.DateEdit();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar4 = new DevExpress.XtraBars.Bar();
            this.btnBuscar = new DevExpress.XtraBars.BarButtonItem();
            this.btnRefrescar = new DevExpress.XtraBars.BarButtonItem();
            this.btnExcel = new DevExpress.XtraBars.BarButtonItem();
            this.btnAgrupar = new DevExpress.XtraBars.BarButtonItem();
            this.btnDesAgrupar = new DevExpress.XtraBars.BarButtonItem();
            this.btnConsolidar = new DevExpress.XtraBars.BarButtonItem();
            this.btnCerrar = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.btnGenerar = new DevExpress.XtraEditors.SimpleButton();
            this.cboEmpresa = new DevExpress.XtraEditors.LookUpEdit();
            this.cbocuentas = new DevExpress.XtraEditors.LookUpEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem2 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.bar3 = new DevExpress.XtraBars.Bar();
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).BeginInit();
            this.dataLayoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckedComboBoxEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpfecha.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpfecha.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboEmpresa.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbocuentas.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            this.SuspendLayout();
            // 
            // dataLayoutControl1
            // 
            this.dataLayoutControl1.Controls.Add(this.gridControl1);
            this.dataLayoutControl1.Controls.Add(this.dtpfecha);
            this.dataLayoutControl1.Controls.Add(this.btnGenerar);
            this.dataLayoutControl1.Controls.Add(this.cboEmpresa);
            this.dataLayoutControl1.Controls.Add(this.cbocuentas);
            this.dataLayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataLayoutControl1.Location = new System.Drawing.Point(0, 20);
            this.dataLayoutControl1.Name = "dataLayoutControl1";
            this.dataLayoutControl1.Root = this.layoutControlGroup1;
            this.dataLayoutControl1.Size = new System.Drawing.Size(1103, 486);
            this.dataLayoutControl1.TabIndex = 1;
            this.dataLayoutControl1.Text = "dataLayoutControl1";
            // 
            // gridControl1
            // 
            this.gridControl1.Location = new System.Drawing.Point(6, 52);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemCheckedComboBoxEdit1,
            this.repositoryItemButtonEdit1});
            this.gridControl1.Size = new System.Drawing.Size(1091, 428);
            this.gridControl1.TabIndex = 19;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.xEmpresa,
            this.xIdCuentaContable,
            this.xCuentaContable,
            this.xCUO,
            this.xTipo,
            this.xNumero,
            this.xRazon_Social,
            this.xIdComprobante,
            this.xCod_Comprobante,
            this.xNum_Comprobante,
            this.xImporte_MN,
            this.xImporte_ME,
            this.xFechaEmision,
            this.xId_Aux,
            this.xId_Asiento_Contable,
            this.xidProyecto,
            this.xFechaAsiento});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.GroupCount = 1;
            this.gridView1.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Importe_MN", this.xImporte_MN, "{0:n2}", new decimal(new int[] {
                            0,
                            0,
                            0,
                            0})),
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Importe_ME", this.xImporte_ME, "{0:n2}", new decimal(new int[] {
                            0,
                            0,
                            0,
                            0})),
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Count, "Numero", this.xNumero, "R. {0}", new decimal(new int[] {
                            0,
                            0,
                            0,
                            0})),
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Max, "IdCuentaContable", this.xCuentaContable, "TOTAL CUENTA :{0}", "")});
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.AutoExpandAllGroups = true;
            this.gridView1.OptionsFind.AlwaysVisible = true;
            this.gridView1.OptionsFind.FindNullPrompt = "Ingrese Texto a Buscar";
            this.gridView1.OptionsSelection.MultiSelect = true;
            this.gridView1.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
            this.gridView1.OptionsSelection.ShowCheckBoxSelectorInColumnHeader = DevExpress.Utils.DefaultBoolean.False;
            this.gridView1.OptionsSelection.ShowCheckBoxSelectorInGroupRow = DevExpress.Utils.DefaultBoolean.True;
            this.gridView1.OptionsView.ShowFooter = true;
            this.gridView1.OptionsView.ShowGroupedColumns = true;
            this.gridView1.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.xCuentaContable, DevExpress.Data.ColumnSortOrder.Ascending)});
            // 
            // xEmpresa
            // 
            this.xEmpresa.Caption = "Empresa";
            this.xEmpresa.FieldName = "Empresa";
            this.xEmpresa.MinWidth = 10;
            this.xEmpresa.Name = "xEmpresa";
            this.xEmpresa.OptionsColumn.AllowEdit = false;
            this.xEmpresa.Visible = true;
            this.xEmpresa.VisibleIndex = 1;
            this.xEmpresa.Width = 112;
            // 
            // xIdCuentaContable
            // 
            this.xIdCuentaContable.Caption = "CuentaContable";
            this.xIdCuentaContable.FieldName = "IdCuentaContable";
            this.xIdCuentaContable.MaxWidth = 85;
            this.xIdCuentaContable.Name = "xIdCuentaContable";
            this.xIdCuentaContable.OptionsColumn.ReadOnly = true;
            this.xIdCuentaContable.Visible = true;
            this.xIdCuentaContable.VisibleIndex = 2;
            this.xIdCuentaContable.Width = 85;
            // 
            // xCuentaContable
            // 
            this.xCuentaContable.Caption = "Descripción Cuenta Contable";
            this.xCuentaContable.FieldName = "CuentaContable";
            this.xCuentaContable.GroupInterval = DevExpress.XtraGrid.ColumnGroupInterval.DisplayText;
            this.xCuentaContable.MinWidth = 85;
            this.xCuentaContable.Name = "xCuentaContable";
            this.xCuentaContable.OptionsColumn.ReadOnly = true;
            this.xCuentaContable.Visible = true;
            this.xCuentaContable.VisibleIndex = 3;
            this.xCuentaContable.Width = 112;
            // 
            // xCUO
            // 
            this.xCUO.Caption = "CUO";
            this.xCUO.FieldName = "CUO";
            this.xCUO.MaxWidth = 80;
            this.xCUO.MinWidth = 60;
            this.xCUO.Name = "xCUO";
            this.xCUO.OptionsColumn.ReadOnly = true;
            this.xCUO.Visible = true;
            this.xCUO.VisibleIndex = 4;
            // 
            // xTipo
            // 
            this.xTipo.Caption = "Tipo";
            this.xTipo.FieldName = "Tipo";
            this.xTipo.MaxWidth = 40;
            this.xTipo.Name = "xTipo";
            this.xTipo.OptionsColumn.ReadOnly = true;
            this.xTipo.Visible = true;
            this.xTipo.VisibleIndex = 5;
            this.xTipo.Width = 40;
            // 
            // xNumero
            // 
            this.xNumero.Caption = "Numero";
            this.xNumero.FieldName = "Numero";
            this.xNumero.MinWidth = 80;
            this.xNumero.Name = "xNumero";
            this.xNumero.OptionsColumn.ReadOnly = true;
            this.xNumero.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "Numero", "{0}")});
            this.xNumero.Visible = true;
            this.xNumero.VisibleIndex = 6;
            this.xNumero.Width = 112;
            // 
            // xRazon_Social
            // 
            this.xRazon_Social.Caption = "Razon Social";
            this.xRazon_Social.FieldName = "Razon_Social";
            this.xRazon_Social.Name = "xRazon_Social";
            this.xRazon_Social.OptionsColumn.ReadOnly = true;
            this.xRazon_Social.Visible = true;
            this.xRazon_Social.VisibleIndex = 7;
            this.xRazon_Social.Width = 112;
            // 
            // xIdComprobante
            // 
            this.xIdComprobante.Caption = "TP";
            this.xIdComprobante.FieldName = "IdComprobante";
            this.xIdComprobante.MaxWidth = 35;
            this.xIdComprobante.Name = "xIdComprobante";
            this.xIdComprobante.OptionsColumn.ReadOnly = true;
            this.xIdComprobante.Visible = true;
            this.xIdComprobante.VisibleIndex = 8;
            this.xIdComprobante.Width = 35;
            // 
            // xCod_Comprobante
            // 
            this.xCod_Comprobante.Caption = "Serie";
            this.xCod_Comprobante.FieldName = "Cod_Comprobante";
            this.xCod_Comprobante.MaxWidth = 50;
            this.xCod_Comprobante.Name = "xCod_Comprobante";
            this.xCod_Comprobante.OptionsColumn.ReadOnly = true;
            this.xCod_Comprobante.Visible = true;
            this.xCod_Comprobante.VisibleIndex = 9;
            this.xCod_Comprobante.Width = 50;
            // 
            // xNum_Comprobante
            // 
            this.xNum_Comprobante.Caption = "Num Doc";
            this.xNum_Comprobante.FieldName = "Num_Comprobante";
            this.xNum_Comprobante.MinWidth = 50;
            this.xNum_Comprobante.Name = "xNum_Comprobante";
            this.xNum_Comprobante.OptionsColumn.ReadOnly = true;
            this.xNum_Comprobante.Visible = true;
            this.xNum_Comprobante.VisibleIndex = 10;
            this.xNum_Comprobante.Width = 140;
            // 
            // xImporte_MN
            // 
            this.xImporte_MN.Caption = "Monto MN";
            this.xImporte_MN.DisplayFormat.FormatString = "#,##0.00;(#,##0.00)";
            this.xImporte_MN.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.xImporte_MN.FieldName = "Importe_MN";
            this.xImporte_MN.MaxWidth = 100;
            this.xImporte_MN.MinWidth = 70;
            this.xImporte_MN.Name = "xImporte_MN";
            this.xImporte_MN.OptionsColumn.ReadOnly = true;
            this.xImporte_MN.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Importe_MN", "{0:n2}", new decimal(new int[] {
                            0,
                            0,
                            0,
                            0}))});
            this.xImporte_MN.Visible = true;
            this.xImporte_MN.VisibleIndex = 11;
            this.xImporte_MN.Width = 99;
            // 
            // xImporte_ME
            // 
            this.xImporte_ME.Caption = "Monto ME";
            this.xImporte_ME.DisplayFormat.FormatString = "#,##0.00;(#,##0.00)";
            this.xImporte_ME.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.xImporte_ME.FieldName = "Importe_ME";
            this.xImporte_ME.MaxWidth = 100;
            this.xImporte_ME.MinWidth = 70;
            this.xImporte_ME.Name = "xImporte_ME";
            this.xImporte_ME.OptionsColumn.ReadOnly = true;
            this.xImporte_ME.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Importe_ME", "{0:n2}", new decimal(new int[] {
                            0,
                            0,
                            0,
                            0}))});
            this.xImporte_ME.Visible = true;
            this.xImporte_ME.VisibleIndex = 12;
            this.xImporte_ME.Width = 100;
            // 
            // xFechaEmision
            // 
            this.xFechaEmision.Caption = "Fecha Emision";
            this.xFechaEmision.DisplayFormat.FormatString = "d";
            this.xFechaEmision.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.xFechaEmision.FieldName = "FechaEmision";
            this.xFechaEmision.MaxWidth = 72;
            this.xFechaEmision.Name = "xFechaEmision";
            this.xFechaEmision.OptionsColumn.ReadOnly = true;
            this.xFechaEmision.Visible = true;
            this.xFechaEmision.VisibleIndex = 13;
            this.xFechaEmision.Width = 72;
            // 
            // xId_Aux
            // 
            this.xId_Aux.Caption = "Id_Aux";
            this.xId_Aux.FieldName = "Id_Aux";
            this.xId_Aux.Name = "xId_Aux";
            // 
            // xId_Asiento_Contable
            // 
            this.xId_Asiento_Contable.Caption = "Id_Asiento_Contable";
            this.xId_Asiento_Contable.FieldName = "Id_Asiento_Contable";
            this.xId_Asiento_Contable.Name = "xId_Asiento_Contable";
            // 
            // xidProyecto
            // 
            this.xidProyecto.Caption = "idProyecto";
            this.xidProyecto.FieldName = "idProyecto";
            this.xidProyecto.Name = "xidProyecto";
            // 
            // xFechaAsiento
            // 
            this.xFechaAsiento.Caption = "FechaAsiento";
            this.xFechaAsiento.FieldName = "FechaAsiento";
            this.xFechaAsiento.Name = "xFechaAsiento";
            // 
            // repositoryItemCheckedComboBoxEdit1
            // 
            this.repositoryItemCheckedComboBoxEdit1.AutoHeight = false;
            this.repositoryItemCheckedComboBoxEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Search)});
            this.repositoryItemCheckedComboBoxEdit1.Name = "repositoryItemCheckedComboBoxEdit1";
            // 
            // repositoryItemButtonEdit1
            // 
            this.repositoryItemButtonEdit1.AutoHeight = false;
            this.repositoryItemButtonEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Clear)});
            this.repositoryItemButtonEdit1.Name = "repositoryItemButtonEdit1";
            this.repositoryItemButtonEdit1.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            // 
            // dtpfecha
            // 
            this.dtpfecha.EditValue = null;
            this.dtpfecha.Location = new System.Drawing.Point(316, 28);
            this.dtpfecha.MenuManager = this.barManager1;
            this.dtpfecha.Name = "dtpfecha";
            this.dtpfecha.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtpfecha.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtpfecha.Size = new System.Drawing.Size(163, 20);
            this.dtpfecha.StyleController = this.dataLayoutControl1;
            this.dtpfecha.TabIndex = 18;
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
            this.btnConsolidar});
            this.barManager1.MainMenu = this.bar4;
            this.barManager1.MaxItemId = 11;
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
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnRefrescar, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnExcel, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnAgrupar, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnDesAgrupar, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnConsolidar, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnCerrar, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar4.OptionsBar.AllowQuickCustomization = false;
            this.bar4.OptionsBar.DrawBorder = false;
            this.bar4.OptionsBar.MultiLine = true;
            this.bar4.OptionsBar.UseWholeRow = true;
            this.bar4.Text = "Menú principal";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Caption = "Generar";
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
            this.btnRefrescar.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
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
            // btnConsolidar
            // 
            this.btnConsolidar.Caption = "Consolidar Selección";
            this.btnConsolidar.Id = 10;
            this.btnConsolidar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnConsolidar.ImageOptions.Image")));
            this.btnConsolidar.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnConsolidar.ImageOptions.LargeImage")));
            this.btnConsolidar.Name = "btnConsolidar";
            this.btnConsolidar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnConsolidar_ItemClick);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Caption = "Cerrar";
            this.btnCerrar.Id = 1;
            this.btnCerrar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrar.ImageOptions.Image")));
            this.btnCerrar.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnCerrar.ImageOptions.LargeImage")));
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnCerrar_ItemClick_1);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(1103, 20);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 506);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1103, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 20);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 486);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1103, 20);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 486);
            // 
            // btnGenerar
            // 
            this.btnGenerar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnGenerar.ImageOptions.Image")));
            this.btnGenerar.Location = new System.Drawing.Point(481, 28);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(70, 22);
            this.btnGenerar.StyleController = this.dataLayoutControl1;
            this.btnGenerar.TabIndex = 17;
            this.btnGenerar.Text = "Generar";
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // cboEmpresa
            // 
            this.cboEmpresa.Location = new System.Drawing.Point(90, 6);
            this.cboEmpresa.Name = "cboEmpresa";
            this.cboEmpresa.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboEmpresa.Properties.NullText = "";
            this.cboEmpresa.Size = new System.Drawing.Size(389, 20);
            this.cboEmpresa.StyleController = this.dataLayoutControl1;
            this.cboEmpresa.TabIndex = 11;
            this.cboEmpresa.EditValueChanged += new System.EventHandler(this.cboEmpresa_EditValueChanged);
            // 
            // cbocuentas
            // 
            this.cbocuentas.Location = new System.Drawing.Point(90, 28);
            this.cbocuentas.Name = "cbocuentas";
            this.cbocuentas.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbocuentas.Properties.NullText = "";
            this.cbocuentas.Size = new System.Drawing.Size(140, 20);
            this.cbocuentas.StyleController = this.dataLayoutControl1;
            this.cbocuentas.TabIndex = 11;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem2,
            this.emptySpaceItem1,
            this.layoutControlItem1,
            this.emptySpaceItem2,
            this.layoutControlItem3,
            this.layoutControlItem4,
            this.layoutControlItem5});
            this.layoutControlGroup1.Name = "Root";
            this.layoutControlGroup1.Size = new System.Drawing.Size(1103, 486);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.cboEmpresa;
            this.layoutControlItem2.ControlAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.layoutControlItem2.CustomizationFormText = "Nombre Empresa";
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
            this.emptySpaceItem1.Location = new System.Drawing.Point(475, 0);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(618, 22);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.BestFitWeight = 50;
            this.layoutControlItem1.Control = this.cbocuentas;
            this.layoutControlItem1.ControlAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.layoutControlItem1.CustomizationFormText = "Nombre Empresa";
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 22);
            this.layoutControlItem1.MaxSize = new System.Drawing.Size(226, 22);
            this.layoutControlItem1.MinSize = new System.Drawing.Size(226, 22);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(226, 24);
            this.layoutControlItem1.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem1.Text = "Saldo de Cuenta";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(81, 13);
            // 
            // emptySpaceItem2
            // 
            this.emptySpaceItem2.AllowHotTrack = false;
            this.emptySpaceItem2.Location = new System.Drawing.Point(547, 22);
            this.emptySpaceItem2.Name = "emptySpaceItem2";
            this.emptySpaceItem2.Size = new System.Drawing.Size(546, 24);
            this.emptySpaceItem2.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.btnGenerar;
            this.layoutControlItem3.Location = new System.Drawing.Point(475, 22);
            this.layoutControlItem3.MaxSize = new System.Drawing.Size(72, 24);
            this.layoutControlItem3.MinSize = new System.Drawing.Size(72, 24);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(72, 24);
            this.layoutControlItem3.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextVisible = false;
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.dtpfecha;
            this.layoutControlItem4.Location = new System.Drawing.Point(226, 22);
            this.layoutControlItem4.MaxSize = new System.Drawing.Size(249, 24);
            this.layoutControlItem4.MinSize = new System.Drawing.Size(249, 24);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(249, 24);
            this.layoutControlItem4.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem4.Text = "Fecha Hasta";
            this.layoutControlItem4.TextSize = new System.Drawing.Size(81, 13);
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.gridControl1;
            this.layoutControlItem5.Location = new System.Drawing.Point(0, 46);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(1093, 430);
            this.layoutControlItem5.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem5.TextVisible = false;
            // 
            // bar1
            // 
            this.bar1.BarName = "Menú principal";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 0;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.FloatLocation = new System.Drawing.Point(432, 133);
            this.bar1.FloatSize = new System.Drawing.Size(169, 44);
            this.bar1.OptionsBar.AllowQuickCustomization = false;
            this.bar1.OptionsBar.DrawBorder = false;
            this.bar1.OptionsBar.MultiLine = true;
            this.bar1.OptionsBar.UseWholeRow = true;
            this.bar1.Text = "Menú principal";
            // 
            // bar2
            // 
            this.bar2.BarName = "Menú principal";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.FloatLocation = new System.Drawing.Point(432, 133);
            this.bar2.FloatSize = new System.Drawing.Size(169, 44);
            this.bar2.OptionsBar.AllowQuickCustomization = false;
            this.bar2.OptionsBar.DrawBorder = false;
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Menú principal";
            // 
            // bar3
            // 
            this.bar3.BarName = "Menú principal";
            this.bar3.DockCol = 0;
            this.bar3.DockRow = 0;
            this.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar3.FloatLocation = new System.Drawing.Point(432, 133);
            this.bar3.FloatSize = new System.Drawing.Size(169, 44);
            this.bar3.OptionsBar.AllowQuickCustomization = false;
            this.bar3.OptionsBar.DrawBorder = false;
            this.bar3.OptionsBar.MultiLine = true;
            this.bar3.OptionsBar.UseWholeRow = true;
            this.bar3.Text = "Menú principal";
            // 
            // frmSaldoCuentasContables
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1103, 506);
            this.Controls.Add(this.dataLayoutControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.IconOptions.Icon = ((System.Drawing.Icon)(resources.GetObject("frmSaldoCuentasContables.IconOptions.Icon")));
            this.Name = "frmSaldoCuentasContables";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Detalle de Saldo de las Cuentas";
            this.Load += new System.EventHandler(this.frmSaldoCuentasContables_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).EndInit();
            this.dataLayoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckedComboBoxEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpfecha.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpfecha.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboEmpresa.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbocuentas.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraDataLayout.DataLayoutControl dataLayoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraEditors.LookUpEdit cboEmpresa;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem2;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar4;
        private DevExpress.XtraBars.BarButtonItem btnBuscar;
        private DevExpress.XtraBars.BarButtonItem btnRefrescar;
        private DevExpress.XtraBars.BarButtonItem btnExcel;
        private DevExpress.XtraBars.BarButtonItem btnCerrar;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraEditors.LookUpEdit cbocuentas;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraEditors.SimpleButton btnGenerar;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraEditors.DateEdit dtpfecha;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckedComboBoxEdit repositoryItemCheckedComboBoxEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryItemButtonEdit1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraGrid.Columns.GridColumn xEmpresa;
        private DevExpress.XtraGrid.Columns.GridColumn xIdCuentaContable;
        private DevExpress.XtraGrid.Columns.GridColumn xCuentaContable;
        private DevExpress.XtraGrid.Columns.GridColumn xTipo;
        private DevExpress.XtraGrid.Columns.GridColumn xNumero;
        private DevExpress.XtraGrid.Columns.GridColumn xRazon_Social;
        private DevExpress.XtraGrid.Columns.GridColumn xIdComprobante;
        private DevExpress.XtraGrid.Columns.GridColumn xCod_Comprobante;
        private DevExpress.XtraGrid.Columns.GridColumn xNum_Comprobante;
        private DevExpress.XtraGrid.Columns.GridColumn xImporte_MN;
        private DevExpress.XtraGrid.Columns.GridColumn xImporte_ME;
        private DevExpress.XtraGrid.Columns.GridColumn xFechaEmision;
        private DevExpress.XtraBars.BarButtonItem btnAgrupar;
        private DevExpress.XtraBars.BarButtonItem btnDesAgrupar;
        private DevExpress.XtraGrid.Columns.GridColumn xCUO;
        private DevExpress.XtraBars.BarButtonItem btnConsolidar;
        private DevExpress.XtraGrid.Columns.GridColumn xId_Aux;
        private DevExpress.XtraGrid.Columns.GridColumn xId_Asiento_Contable;
        private DevExpress.XtraGrid.Columns.GridColumn xidProyecto;
        private DevExpress.XtraGrid.Columns.GridColumn xFechaAsiento;
    }
}