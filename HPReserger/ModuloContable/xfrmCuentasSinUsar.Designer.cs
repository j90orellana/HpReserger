namespace SISGEM.ModuloContable
{
    partial class xfrmCuentasSinUsar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(xfrmCuentasSinUsar));
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
            this.dataLayoutControl1 = new DevExpress.XtraDataLayout.DataLayoutControl();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.XCuenta_Contable = new DevExpress.XtraGrid.Columns.GridColumn();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.xfecha = new DevExpress.XtraGrid.Columns.GridColumn();
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.btnConsultar = new DevExpress.XtraBars.BarButtonItem();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).BeginInit();
            this.dataLayoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            this.SuspendLayout();
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
            this.btnExportarPDF,
            this.btnConsultar});
            this.barManager1.MaxItemId = 10;
            // 
            // bar1
            // 
            this.bar1.BarName = "Personalizada 1";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 0;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnConsultar, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
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
            this.barDockControl1.Size = new System.Drawing.Size(643, 24);
            // 
            // barDockControl2
            // 
            this.barDockControl2.CausesValidation = false;
            this.barDockControl2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControl2.Location = new System.Drawing.Point(0, 494);
            this.barDockControl2.Manager = this.barManager1;
            this.barDockControl2.Size = new System.Drawing.Size(643, 0);
            // 
            // barDockControl3
            // 
            this.barDockControl3.CausesValidation = false;
            this.barDockControl3.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControl3.Location = new System.Drawing.Point(0, 24);
            this.barDockControl3.Manager = this.barManager1;
            this.barDockControl3.Size = new System.Drawing.Size(0, 470);
            // 
            // barDockControl4
            // 
            this.barDockControl4.CausesValidation = false;
            this.barDockControl4.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControl4.Location = new System.Drawing.Point(643, 24);
            this.barDockControl4.Manager = this.barManager1;
            this.barDockControl4.Size = new System.Drawing.Size(0, 470);
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
            // dataLayoutControl1
            // 
            this.dataLayoutControl1.Controls.Add(this.gridControl1);
            this.dataLayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataLayoutControl1.Location = new System.Drawing.Point(0, 24);
            this.dataLayoutControl1.Name = "dataLayoutControl1";
            this.dataLayoutControl1.Root = this.Root;
            this.dataLayoutControl1.Size = new System.Drawing.Size(643, 470);
            this.dataLayoutControl1.TabIndex = 4;
            this.dataLayoutControl1.Text = "dataLayoutControl1";
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(643, 470);
            this.Root.TextVisible = false;
            // 
            // gridControl1
            // 
            this.gridControl1.EmbeddedNavigator.Buttons.AutoRepeatDelay = 5;
            this.gridControl1.Location = new System.Drawing.Point(6, 6);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(631, 458);
            this.gridControl1.TabIndex = 8;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.XCuenta_Contable,
            this.xfecha});
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
            // 
            // XCuenta_Contable
            // 
            this.XCuenta_Contable.Caption = "CuentaContable";
            this.XCuenta_Contable.FieldName = "cuentaContable";
            this.XCuenta_Contable.MinWidth = 80;
            this.XCuenta_Contable.Name = "XCuenta_Contable";
            this.XCuenta_Contable.OptionsColumn.ReadOnly = true;
            this.XCuenta_Contable.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "Cuenta", "{0}", 0)});
            this.XCuenta_Contable.Visible = true;
            this.XCuenta_Contable.VisibleIndex = 0;
            this.XCuenta_Contable.Width = 80;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.gridControl1;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(633, 460);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // xfecha
            // 
            this.xfecha.Caption = "Fecha";
            this.xfecha.FieldName = "fecha";
            this.xfecha.MaxWidth = 80;
            this.xfecha.MinWidth = 80;
            this.xfecha.Name = "xfecha";
            this.xfecha.OptionsColumn.ReadOnly = true;
            this.xfecha.Visible = true;
            this.xfecha.VisibleIndex = 1;
            this.xfecha.Width = 80;
            // 
            // bar2
            // 
            this.bar2.BarName = "Personalizada 3";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 1;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.Text = "Personalizada 3";
            // 
            // btnConsultar
            // 
            this.btnConsultar.Caption = "Consultar";
            this.btnConsultar.Id = 9;
            this.btnConsultar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnConsultar.ImageOptions.Image")));
            this.btnConsultar.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnConsultar.ImageOptions.LargeImage")));
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnConsultar_ItemClick);
            // 
            // xfrmCuentasSinUsar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(643, 494);
            this.Controls.Add(this.dataLayoutControl1);
            this.Controls.Add(this.barDockControl3);
            this.Controls.Add(this.barDockControl4);
            this.Controls.Add(this.barDockControl2);
            this.Controls.Add(this.barDockControl1);
            this.IconOptions.Icon = ((System.Drawing.Icon)(resources.GetObject("xfrmCuentasSinUsar.IconOptions.Icon")));
            this.Name = "xfrmCuentasSinUsar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Revisar Cuentas que no se usan en los EEFF y EERR";
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).EndInit();
            this.dataLayoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarButtonItem btnCerrar;
        private DevExpress.XtraBars.BarButtonItem btnexportarexcel;
        private DevExpress.XtraBars.BarDockControl barDockControl1;
        private DevExpress.XtraBars.BarDockControl barDockControl2;
        private DevExpress.XtraBars.BarDockControl barDockControl3;
        private DevExpress.XtraBars.BarDockControl barDockControl4;
        private DevExpress.XtraBars.BarStaticItem lbldatos;
        private DevExpress.XtraBars.BarCheckItem chkComparar;
        private DevExpress.XtraBars.BarCheckItem chkAgruparCuentas;
        private DevExpress.XtraBars.BarCheckItem chkFiltrarDatos;
        private DevExpress.XtraBars.BarButtonItem btnExportarPDF;
        private DevExpress.XtraDataLayout.DataLayoutControl dataLayoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraBars.BarButtonItem btnConsultar;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn XCuenta_Contable;
        private DevExpress.XtraGrid.Columns.GridColumn xfecha;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
    }
}