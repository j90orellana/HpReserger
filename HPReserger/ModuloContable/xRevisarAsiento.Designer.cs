namespace SISGEM.ModuloContable
{
    partial class xRevisarAsiento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(xRevisarAsiento));
            this.bar5 = new DevExpress.XtraBars.Bar();
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.btnCerrar = new DevExpress.XtraBars.BarButtonItem();
            this.chkComparar = new DevExpress.XtraBars.BarCheckItem();
            this.chkAgruparCuentas = new DevExpress.XtraBars.BarCheckItem();
            this.chkFiltrarDatos = new DevExpress.XtraBars.BarCheckItem();
            this.lbldatos = new DevExpress.XtraBars.BarStaticItem();
            this.bar6 = new DevExpress.XtraBars.Bar();
            this.bar7 = new DevExpress.XtraBars.Bar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.xPos = new DevExpress.XtraGrid.Columns.GridColumn();
            this.xCuenta = new DevExpress.XtraGrid.Columns.GridColumn();
            this.xDebe = new DevExpress.XtraGrid.Columns.GridColumn();
            this.xHaber = new DevExpress.XtraGrid.Columns.GridColumn();
            this.xImporteMN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.xImporteME = new DevExpress.XtraGrid.Columns.GridColumn();
            this.xDiferencia = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.btnexportarexcel = new DevExpress.XtraBars.BarButtonItem();
            this.btnExportarPDF = new DevExpress.XtraBars.BarButtonItem();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            this.SuspendLayout();
            // 
            // bar5
            // 
            this.bar5.BarName = "MainMenu";
            this.bar5.DockCol = 0;
            this.bar5.DockRow = 0;
            this.bar5.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar5.OptionsBar.MultiLine = true;
            this.bar5.OptionsBar.UseWholeRow = true;
            this.bar5.Text = "MainMenu";
            // 
            // bar1
            // 
            this.bar1.BarName = "MainMenu";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 0;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.OptionsBar.MultiLine = true;
            this.bar1.OptionsBar.UseWholeRow = true;
            this.bar1.Text = "MainMenu";
            // 
            // barManager1
            // 
            this.barManager1.AllowCustomization = false;
            this.barManager1.AllowQuickCustomization = false;
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar2,
            this.bar6,
            this.bar7});
            this.barManager1.Categories.AddRange(new DevExpress.XtraBars.BarManagerCategory[] {
            new DevExpress.XtraBars.BarManagerCategory("Exportar", new System.Guid("7e5d28e8-a562-4007-a96f-fc1ffa64e53d"))});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btnCerrar,
            this.lbldatos,
            this.chkComparar,
            this.chkAgruparCuentas,
            this.chkFiltrarDatos,
            this.btnexportarexcel,
            this.btnExportarPDF});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 9;
            this.barManager1.StatusBar = this.bar7;
            // 
            // bar2
            // 
            this.bar2.BarName = "MainMenu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.HideWhenMerging = DevExpress.Utils.DefaultBoolean.False;
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnCerrar, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.chkComparar, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.chkAgruparCuentas, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.chkFiltrarDatos, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnexportarexcel, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnExportarPDF, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(this.lbldatos, true)});
            this.bar2.OptionsBar.AllowQuickCustomization = false;
            this.bar2.OptionsBar.DisableCustomization = true;
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "MainMenu";
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
            // chkComparar
            // 
            this.chkComparar.Caption = "Solo Diferencias";
            this.chkComparar.Id = 4;
            this.chkComparar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("chkComparar.ImageOptions.Image")));
            this.chkComparar.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("chkComparar.ImageOptions.LargeImage")));
            this.chkComparar.Name = "chkComparar";
            this.chkComparar.CheckedChanged += new DevExpress.XtraBars.ItemClickEventHandler(this.btnComparar_CheckedChanged);
            // 
            // chkAgruparCuentas
            // 
            this.chkAgruparCuentas.Caption = "Agrupar Cuentas";
            this.chkAgruparCuentas.Id = 5;
            this.chkAgruparCuentas.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("chkAgruparCuentas.ImageOptions.Image")));
            this.chkAgruparCuentas.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("chkAgruparCuentas.ImageOptions.LargeImage")));
            this.chkAgruparCuentas.Name = "chkAgruparCuentas";
            this.chkAgruparCuentas.CheckedChanged += new DevExpress.XtraBars.ItemClickEventHandler(this.chkAgruparCuentas_CheckedChanged);
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
            // 
            // bar6
            // 
            this.bar6.BarName = "Tools";
            this.bar6.DockCol = 0;
            this.bar6.DockRow = 1;
            this.bar6.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar6.Text = "Tools";
            this.bar6.Visible = false;
            // 
            // bar7
            // 
            this.bar7.BarName = "StatusBar";
            this.bar7.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.bar7.DockCol = 0;
            this.bar7.DockRow = 0;
            this.bar7.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.bar7.OptionsBar.AllowQuickCustomization = false;
            this.bar7.OptionsBar.DrawDragBorder = false;
            this.bar7.OptionsBar.UseWholeRow = true;
            this.bar7.Text = "StatusBar";
            this.bar7.Visible = false;
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(752, 42);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 480);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(752, 20);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 42);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 438);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(752, 42);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 438);
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.gridControl1);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 42);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(752, 438);
            this.layoutControl1.TabIndex = 4;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // gridControl1
            // 
            this.gridControl1.EmbeddedNavigator.Buttons.AutoRepeatDelay = 5;
            this.gridControl1.Location = new System.Drawing.Point(6, 6);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(740, 426);
            this.gridControl1.TabIndex = 5;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.xPos,
            this.xCuenta,
            this.xDebe,
            this.xHaber,
            this.xImporteMN,
            this.xImporteME,
            this.xDiferencia});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsFind.AlwaysVisible = true;
            this.gridView1.OptionsView.ShowFooter = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // xPos
            // 
            this.xPos.Caption = "Pos";
            this.xPos.FieldName = "Pos";
            this.xPos.Name = "xPos";
            // 
            // xCuenta
            // 
            this.xCuenta.Caption = "Cuenta";
            this.xCuenta.FieldName = "Cuenta";
            this.xCuenta.MaxWidth = 100;
            this.xCuenta.MinWidth = 80;
            this.xCuenta.Name = "xCuenta";
            this.xCuenta.OptionsColumn.AllowEdit = false;
            this.xCuenta.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "Cuenta", "{0}", 0)});
            this.xCuenta.Visible = true;
            this.xCuenta.VisibleIndex = 0;
            this.xCuenta.Width = 80;
            // 
            // xDebe
            // 
            this.xDebe.Caption = "Debe";
            this.xDebe.FieldName = "Debe";
            this.xDebe.MinWidth = 100;
            this.xDebe.Name = "xDebe";
            this.xDebe.OptionsColumn.AllowEdit = false;
            this.xDebe.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Debe", "{0:#.##}")});
            this.xDebe.Visible = true;
            this.xDebe.VisibleIndex = 1;
            this.xDebe.Width = 100;
            // 
            // xHaber
            // 
            this.xHaber.Caption = "Haber";
            this.xHaber.FieldName = "Haber";
            this.xHaber.MinWidth = 100;
            this.xHaber.Name = "xHaber";
            this.xHaber.OptionsColumn.AllowEdit = false;
            this.xHaber.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Haber", "{0:#.##}")});
            this.xHaber.Visible = true;
            this.xHaber.VisibleIndex = 2;
            this.xHaber.Width = 100;
            // 
            // xImporteMN
            // 
            this.xImporteMN.Caption = "ImporteMN";
            this.xImporteMN.FieldName = "ImporteMN";
            this.xImporteMN.MinWidth = 100;
            this.xImporteMN.Name = "xImporteMN";
            this.xImporteMN.OptionsColumn.AllowEdit = false;
            this.xImporteMN.Visible = true;
            this.xImporteMN.VisibleIndex = 3;
            this.xImporteMN.Width = 100;
            // 
            // xImporteME
            // 
            this.xImporteME.Caption = "ImporteME";
            this.xImporteME.FieldName = "ImporteME";
            this.xImporteME.MinWidth = 100;
            this.xImporteME.Name = "xImporteME";
            this.xImporteME.OptionsColumn.AllowEdit = false;
            this.xImporteME.Visible = true;
            this.xImporteME.VisibleIndex = 4;
            this.xImporteME.Width = 100;
            // 
            // xDiferencia
            // 
            this.xDiferencia.Caption = "Diferencia";
            this.xDiferencia.FieldName = "Diferencia";
            this.xDiferencia.MinWidth = 100;
            this.xDiferencia.Name = "xDiferencia";
            this.xDiferencia.OptionsColumn.AllowEdit = false;
            this.xDiferencia.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Diferencia", "{0:#.##}")});
            this.xDiferencia.Visible = true;
            this.xDiferencia.VisibleIndex = 5;
            this.xDiferencia.Width = 100;
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(752, 438);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.gridControl1;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(742, 428);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
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
            // btnExportarPDF
            // 
            this.btnExportarPDF.Caption = "Exportar PDF";
            this.btnExportarPDF.CategoryGuid = new System.Guid("7e5d28e8-a562-4007-a96f-fc1ffa64e53d");
            this.btnExportarPDF.Id = 8;
            this.btnExportarPDF.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnExportarPDF.ImageOptions.Image")));
            this.btnExportarPDF.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnExportarPDF.ImageOptions.LargeImage")));
            this.btnExportarPDF.Name = "btnExportarPDF";
            this.btnExportarPDF.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnExportarPDF_ItemClick);
            // 
            // xRevisarAsiento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(752, 500);
            this.Controls.Add(this.layoutControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.IconOptions.Icon = ((System.Drawing.Icon)(resources.GetObject("xRevisarAsiento.IconOptions.Icon")));
            this.Name = "xRevisarAsiento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Revisando Asientos";
            this.Load += new System.EventHandler(this.xRevisarAsiento_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Bar bar5;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarButtonItem btnCerrar;
        private DevExpress.XtraBars.BarStaticItem lbldatos;
        private DevExpress.XtraBars.Bar bar6;
        private DevExpress.XtraBars.Bar bar7;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn xCuenta;
        private DevExpress.XtraGrid.Columns.GridColumn xDebe;
        private DevExpress.XtraGrid.Columns.GridColumn xHaber;
        private DevExpress.XtraGrid.Columns.GridColumn xImporteMN;
        private DevExpress.XtraGrid.Columns.GridColumn xImporteME;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraGrid.Columns.GridColumn xPos;
        private DevExpress.XtraGrid.Columns.GridColumn xDiferencia;
        private DevExpress.XtraBars.BarCheckItem chkComparar;
        private DevExpress.XtraBars.BarCheckItem chkAgruparCuentas;
        private DevExpress.XtraBars.BarCheckItem chkFiltrarDatos;
        private DevExpress.XtraBars.BarButtonItem btnexportarexcel;
        private DevExpress.XtraBars.BarButtonItem btnExportarPDF;
    }
}