namespace SISGEM.ModuloContable
{
    partial class frmRevisarCuentasEEFF
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
            DevExpress.XtraGrid.GridFormatRule gridFormatRule1 = new DevExpress.XtraGrid.GridFormatRule();
            DevExpress.XtraEditors.FormatConditionRuleExpression formatConditionRuleExpression1 = new DevExpress.XtraEditors.FormatConditionRuleExpression();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRevisarCuentasEEFF));
            this.XCuenta_Contable = new DevExpress.XtraGrid.Columns.GridColumn();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.XPosicion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.xid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.xcampo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.xtotal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.dtpfechaa = new DevExpress.XtraEditors.DateEdit();
            this.btnRevisar = new DevExpress.XtraEditors.SimpleButton();
            this.textEdit1 = new DevExpress.XtraEditors.TextEdit();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem2 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.dtpfecha = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem3 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.btnCerrar = new DevExpress.XtraBars.BarButtonItem();
            this.btnexportarexcel = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControl1 = new DevExpress.XtraBars.BarDockControl();
            this.barDockControl2 = new DevExpress.XtraBars.BarDockControl();
            this.barDockControl3 = new DevExpress.XtraBars.BarDockControl();
            this.barDockControl4 = new DevExpress.XtraBars.BarDockControl();
            this.lbldatos = new DevExpress.XtraBars.BarStaticItem();
            this.chkComparar = new DevExpress.XtraBars.BarCheckItem();
            this.chkAgruparCuentas = new DevExpress.XtraBars.BarCheckItem();
            this.chkFiltrarDatos = new DevExpress.XtraBars.BarCheckItem();
            this.btnExportarPDF = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpfechaa.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpfechaa.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpfecha)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // XCuenta_Contable
            // 
            this.XCuenta_Contable.Caption = "Cuenta";
            this.XCuenta_Contable.FieldName = "Cuenta_Contable";
            this.XCuenta_Contable.MaxWidth = 100;
            this.XCuenta_Contable.MinWidth = 80;
            this.XCuenta_Contable.Name = "XCuenta_Contable";
            this.XCuenta_Contable.OptionsColumn.ReadOnly = true;
            this.XCuenta_Contable.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "Cuenta", "{0}", 0)});
            this.XCuenta_Contable.Visible = true;
            this.XCuenta_Contable.VisibleIndex = 3;
            this.XCuenta_Contable.Width = 80;
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.gridControl1);
            this.layoutControl1.Controls.Add(this.dtpfechaa);
            this.layoutControl1.Controls.Add(this.btnRevisar);
            this.layoutControl1.Controls.Add(this.textEdit1);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 24);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(805, 499);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // gridControl1
            // 
            this.gridControl1.EmbeddedNavigator.Buttons.AutoRepeatDelay = 5;
            this.gridControl1.Location = new System.Drawing.Point(6, 54);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(793, 439);
            this.gridControl1.TabIndex = 7;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.XPosicion,
            this.xid,
            this.xcampo,
            this.XCuenta_Contable,
            this.xtotal});
            gridFormatRule1.ApplyToRow = true;
            gridFormatRule1.Column = this.XCuenta_Contable;
            gridFormatRule1.ColumnApplyTo = this.XCuenta_Contable;
            gridFormatRule1.Name = "Format0";
            formatConditionRuleExpression1.AllowAnimation = DevExpress.Utils.DefaultBoolean.True;
            formatConditionRuleExpression1.PredefinedName = "Red Bold Text";
            gridFormatRule1.Rule = formatConditionRuleExpression1;
            this.gridView1.FormatRules.Add(gridFormatRule1);
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsFind.AlwaysVisible = true;
            this.gridView1.OptionsView.ShowFooter = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.RowCellStyle += new DevExpress.XtraGrid.Views.Grid.RowCellStyleEventHandler(this.gridView1_RowCellStyle);
            // 
            // XPosicion
            // 
            this.XPosicion.Caption = "Posicion";
            this.XPosicion.FieldName = "Posicion";
            this.XPosicion.MaxWidth = 80;
            this.XPosicion.MinWidth = 40;
            this.XPosicion.Name = "XPosicion";
            this.XPosicion.OptionsColumn.ReadOnly = true;
            this.XPosicion.Visible = true;
            this.XPosicion.VisibleIndex = 0;
            this.XPosicion.Width = 40;
            // 
            // xid
            // 
            this.xid.Caption = "id";
            this.xid.FieldName = "id";
            this.xid.MaxWidth = 65;
            this.xid.MinWidth = 40;
            this.xid.Name = "xid";
            this.xid.OptionsColumn.ReadOnly = true;
            this.xid.Visible = true;
            this.xid.VisibleIndex = 1;
            this.xid.Width = 40;
            // 
            // xcampo
            // 
            this.xcampo.Caption = "Campo";
            this.xcampo.FieldName = "campo";
            this.xcampo.MinWidth = 200;
            this.xcampo.Name = "xcampo";
            this.xcampo.OptionsColumn.ReadOnly = true;
            this.xcampo.Visible = true;
            this.xcampo.VisibleIndex = 2;
            this.xcampo.Width = 200;
            // 
            // xtotal
            // 
            this.xtotal.Caption = "Total";
            this.xtotal.DisplayFormat.FormatString = "n2";
            this.xtotal.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.xtotal.FieldName = "total";
            this.xtotal.MaxWidth = 150;
            this.xtotal.MinWidth = 100;
            this.xtotal.Name = "xtotal";
            this.xtotal.OptionsColumn.ReadOnly = true;
            this.xtotal.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Debe", "{0:#.##}")});
            this.xtotal.Visible = true;
            this.xtotal.VisibleIndex = 4;
            this.xtotal.Width = 100;
            // 
            // dtpfechaa
            // 
            this.dtpfechaa.EditValue = new System.DateTime(2025, 6, 25, 10, 56, 18, 868);
            this.dtpfechaa.Location = new System.Drawing.Point(90, 30);
            this.dtpfechaa.Name = "dtpfechaa";
            this.dtpfechaa.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.dtpfechaa.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtpfechaa.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtpfechaa.Properties.CalendarTimeProperties.DisplayFormat.FormatString = "MMMM yyyy";
            this.dtpfechaa.Properties.CalendarTimeProperties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dtpfechaa.Properties.CalendarTimeProperties.ReadOnly = true;
            this.dtpfechaa.Properties.CalendarTimeProperties.ShowDropDown = DevExpress.XtraEditors.Controls.ShowDropDown.Never;
            this.dtpfechaa.Properties.DisplayFormat.FormatString = "MMMM yyyy";
            this.dtpfechaa.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dtpfechaa.Properties.EditFormat.FormatString = "MMMM yyyy";
            this.dtpfechaa.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dtpfechaa.Properties.HideSelection = false;
            this.dtpfechaa.Properties.ReadOnly = true;
            this.dtpfechaa.Properties.ShowDropDown = DevExpress.XtraEditors.Controls.ShowDropDown.Never;
            this.dtpfechaa.Properties.ShowPopupShadow = false;
            this.dtpfechaa.Size = new System.Drawing.Size(95, 20);
            this.dtpfechaa.StyleController = this.layoutControl1;
            this.dtpfechaa.TabIndex = 6;
            // 
            // btnRevisar
            // 
            this.btnRevisar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnRevisar.ImageOptions.Image")));
            this.btnRevisar.Location = new System.Drawing.Point(187, 30);
            this.btnRevisar.Name = "btnRevisar";
            this.btnRevisar.Size = new System.Drawing.Size(62, 22);
            this.btnRevisar.StyleController = this.layoutControl1;
            this.btnRevisar.TabIndex = 5;
            this.btnRevisar.Text = "Revisar";
            this.btnRevisar.Click += new System.EventHandler(this.btnRevisar_Click);
            // 
            // textEdit1
            // 
            this.textEdit1.Location = new System.Drawing.Point(90, 6);
            this.textEdit1.Name = "textEdit1";
            this.textEdit1.Properties.ReadOnly = true;
            this.textEdit1.Size = new System.Drawing.Size(457, 20);
            this.textEdit1.StyleController = this.layoutControl1;
            this.textEdit1.TabIndex = 4;
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.emptySpaceItem2,
            this.dtpfecha,
            this.layoutControlItem2,
            this.emptySpaceItem3,
            this.layoutControlItem3});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(805, 499);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.textEdit1;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.MaxSize = new System.Drawing.Size(543, 24);
            this.layoutControlItem1.MinSize = new System.Drawing.Size(543, 24);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(543, 24);
            this.layoutControlItem1.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem1.Text = "Nombre Empresa";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(81, 13);
            // 
            // emptySpaceItem2
            // 
            this.emptySpaceItem2.AllowHotTrack = false;
            this.emptySpaceItem2.Location = new System.Drawing.Point(543, 0);
            this.emptySpaceItem2.Name = "emptySpaceItem2";
            this.emptySpaceItem2.Size = new System.Drawing.Size(252, 24);
            this.emptySpaceItem2.TextSize = new System.Drawing.Size(0, 0);
            // 
            // dtpfecha
            // 
            this.dtpfecha.Control = this.dtpfechaa;
            this.dtpfecha.Location = new System.Drawing.Point(0, 24);
            this.dtpfecha.MaxSize = new System.Drawing.Size(181, 24);
            this.dtpfecha.MinSize = new System.Drawing.Size(181, 24);
            this.dtpfecha.Name = "dtpfecha";
            this.dtpfecha.Size = new System.Drawing.Size(181, 24);
            this.dtpfecha.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.dtpfecha.Text = "Fecha";
            this.dtpfecha.TextSize = new System.Drawing.Size(81, 13);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.btnRevisar;
            this.layoutControlItem2.Location = new System.Drawing.Point(181, 24);
            this.layoutControlItem2.MaxSize = new System.Drawing.Size(64, 24);
            this.layoutControlItem2.MinSize = new System.Drawing.Size(64, 24);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(64, 24);
            this.layoutControlItem2.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // emptySpaceItem3
            // 
            this.emptySpaceItem3.AllowHotTrack = false;
            this.emptySpaceItem3.Location = new System.Drawing.Point(245, 24);
            this.emptySpaceItem3.Name = "emptySpaceItem3";
            this.emptySpaceItem3.Size = new System.Drawing.Size(550, 24);
            this.emptySpaceItem3.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.gridControl1;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 48);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(795, 441);
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextVisible = false;
            // 
            // barManager1
            // 
            this.barManager1.AllowCustomization = false;
            this.barManager1.AllowMoveBarOnToolbar = false;
            this.barManager1.AllowQuickCustomization = false;
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar1});
            this.barManager1.Categories.AddRange(new DevExpress.XtraBars.BarManagerCategory[] {
            new DevExpress.XtraBars.BarManagerCategory("Exportar", new System.Guid("7e5d28e8-a562-4007-a96f-fc1ffa64e53d"))});
            this.barManager1.DockControls.Add(this.barDockControl1);
            this.barManager1.DockControls.Add(this.barDockControl2);
            this.barManager1.DockControls.Add(this.barDockControl3);
            this.barManager1.DockControls.Add(this.barDockControl4);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btnCerrar,
            this.lbldatos,
            this.chkComparar,
            this.chkAgruparCuentas,
            this.chkFiltrarDatos,
            this.btnexportarexcel,
            this.btnExportarPDF});
            this.barManager1.MaxItemId = 9;
            // 
            // bar1
            // 
            this.bar1.BarName = "Personalizada 1";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 0;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnCerrar, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnexportarexcel, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar1.Text = "Personalizada 1";
            // 
            // btnCerrar
            // 
            this.btnCerrar.Caption = "Cerrar";
            this.btnCerrar.Id = 0;
            this.btnCerrar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrar.ImageOptions.Image")));
            this.btnCerrar.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnCerrar.ImageOptions.LargeImage")));
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnCerrar_ItemClick);
            // 
            // btnexportarexcel
            // 
            this.btnexportarexcel.Caption = "Exportar XLS";
            this.btnexportarexcel.CategoryGuid = new System.Guid("7e5d28e8-a562-4007-a96f-fc1ffa64e53d");
            this.btnexportarexcel.Id = 7;
            this.btnexportarexcel.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnexportarexcel.ImageOptions.Image")));
            this.btnexportarexcel.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnexportarexcel.ImageOptions.LargeImage")));
            this.btnexportarexcel.Name = "btnexportarexcel";
            this.btnexportarexcel.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnexportarexcel_ItemClick);
            // 
            // barDockControl1
            // 
            this.barDockControl1.CausesValidation = false;
            this.barDockControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControl1.Location = new System.Drawing.Point(0, 0);
            this.barDockControl1.Manager = this.barManager1;
            this.barDockControl1.Size = new System.Drawing.Size(805, 24);
            // 
            // barDockControl2
            // 
            this.barDockControl2.CausesValidation = false;
            this.barDockControl2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControl2.Location = new System.Drawing.Point(0, 523);
            this.barDockControl2.Manager = this.barManager1;
            this.barDockControl2.Size = new System.Drawing.Size(805, 0);
            // 
            // barDockControl3
            // 
            this.barDockControl3.CausesValidation = false;
            this.barDockControl3.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControl3.Location = new System.Drawing.Point(0, 24);
            this.barDockControl3.Manager = this.barManager1;
            this.barDockControl3.Size = new System.Drawing.Size(0, 499);
            // 
            // barDockControl4
            // 
            this.barDockControl4.CausesValidation = false;
            this.barDockControl4.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControl4.Location = new System.Drawing.Point(805, 24);
            this.barDockControl4.Manager = this.barManager1;
            this.barDockControl4.Size = new System.Drawing.Size(0, 499);
            // 
            // lbldatos
            // 
            this.lbldatos.Caption = "Datos:";
            this.lbldatos.Id = 3;
            this.lbldatos.ItemAppearance.Disabled.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.lbldatos.ItemAppearance.Disabled.ForeColor = System.Drawing.Color.Red;
            this.lbldatos.ItemAppearance.Disabled.Options.UseFont = true;
            this.lbldatos.ItemAppearance.Disabled.Options.UseForeColor = true;
            this.lbldatos.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.lbldatos.ItemAppearance.Normal.ForeColor = System.Drawing.Color.Red;
            this.lbldatos.ItemAppearance.Normal.Options.UseFont = true;
            this.lbldatos.ItemAppearance.Normal.Options.UseForeColor = true;
            this.lbldatos.Name = "lbldatos";
            this.lbldatos.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            // 
            // chkComparar
            // 
            this.chkComparar.Caption = "Solo Diferencias";
            this.chkComparar.Id = 4;
            this.chkComparar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("chkComparar.ImageOptions.Image")));
            this.chkComparar.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("chkComparar.ImageOptions.LargeImage")));
            this.chkComparar.Name = "chkComparar";
            // 
            // chkAgruparCuentas
            // 
            this.chkAgruparCuentas.Caption = "Agrupar Cuentas";
            this.chkAgruparCuentas.Id = 5;
            this.chkAgruparCuentas.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("chkAgruparCuentas.ImageOptions.Image")));
            this.chkAgruparCuentas.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("chkAgruparCuentas.ImageOptions.LargeImage")));
            this.chkAgruparCuentas.Name = "chkAgruparCuentas";
            // 
            // chkFiltrarDatos
            // 
            this.chkFiltrarDatos.Caption = "Filtrar";
            this.chkFiltrarDatos.Id = 6;
            this.chkFiltrarDatos.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("chkFiltrarDatos.ImageOptions.Image")));
            this.chkFiltrarDatos.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("chkFiltrarDatos.ImageOptions.LargeImage")));
            this.chkFiltrarDatos.Name = "chkFiltrarDatos";
            this.chkFiltrarDatos.CheckedChanged += new DevExpress.XtraBars.ItemClickEventHandler(this.chkFiltrarDatos_CheckedChanged);
            // 
            // btnExportarPDF
            // 
            this.btnExportarPDF.Caption = "Exportar PDF";
            this.btnExportarPDF.CategoryGuid = new System.Guid("7e5d28e8-a562-4007-a96f-fc1ffa64e53d");
            this.btnExportarPDF.Id = 8;
            this.btnExportarPDF.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnExportarPDF.ImageOptions.Image")));
            this.btnExportarPDF.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnExportarPDF.ImageOptions.LargeImage")));
            this.btnExportarPDF.Name = "btnExportarPDF";
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 24);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(805, 0);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 523);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(805, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 24);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 499);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(805, 24);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 499);
            // 
            // frmRevisarCuentasEEFF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(805, 523);
            this.Controls.Add(this.layoutControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Controls.Add(this.barDockControl3);
            this.Controls.Add(this.barDockControl4);
            this.Controls.Add(this.barDockControl2);
            this.Controls.Add(this.barDockControl1);
            this.IconOptions.Icon = ((System.Drawing.Icon)(resources.GetObject("frmRevisarCuentasEEFF.IconOptions.Icon")));
            this.Name = "frmRevisarCuentasEEFF";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Revisar Cuentas de los Estado Financieros";
            this.Load += new System.EventHandler(this.frmRevisarCuentasEEFF_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpfechaa.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpfechaa.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpfecha)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraEditors.SimpleButton btnRevisar;
        private DevExpress.XtraEditors.TextEdit textEdit1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem2;
        private DevExpress.XtraEditors.DateEdit dtpfechaa;
        private DevExpress.XtraLayout.LayoutControlItem dtpfecha;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem3;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn XPosicion;
        private DevExpress.XtraGrid.Columns.GridColumn XCuenta_Contable;
        private DevExpress.XtraGrid.Columns.GridColumn xtotal;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraGrid.Columns.GridColumn xid;
        private DevExpress.XtraGrid.Columns.GridColumn xcampo;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.BarButtonItem btnCerrar;
        private DevExpress.XtraBars.BarCheckItem chkComparar;
        private DevExpress.XtraBars.BarCheckItem chkAgruparCuentas;
        private DevExpress.XtraBars.BarCheckItem chkFiltrarDatos;
        private DevExpress.XtraBars.BarButtonItem btnexportarexcel;
        private DevExpress.XtraBars.BarButtonItem btnExportarPDF;
        private DevExpress.XtraBars.BarStaticItem lbldatos;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarDockControl barDockControl1;
        private DevExpress.XtraBars.BarDockControl barDockControl2;
        private DevExpress.XtraBars.BarDockControl barDockControl3;
        private DevExpress.XtraBars.BarDockControl barDockControl4;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
    }
}