namespace SISGEM.Flujo_de_Caja
{
    partial class frmCuadraturaMF
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
            DevExpress.XtraPivotGrid.PivotGridGroup pivotGridGroup1 = new DevExpress.XtraPivotGrid.PivotGridGroup();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCuadraturaMF));
            this.xFECHAOPERACION = new DevExpress.XtraPivotGrid.PivotGridField();
            this.xEMPRESA = new DevExpress.XtraPivotGrid.PivotGridField();
            this.xCTABANCARIA = new DevExpress.XtraPivotGrid.PivotGridField();
            this.xMONEDA = new DevExpress.XtraPivotGrid.PivotGridField();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.pivotGridControl1 = new DevExpress.XtraPivotGrid.PivotGridControl();
            this.xIDEMPRESA = new DevExpress.XtraPivotGrid.PivotGridField();
            this.xIDCTABANCO = new DevExpress.XtraPivotGrid.PivotGridField();
            this.xSALDOINICIAL = new DevExpress.XtraPivotGrid.PivotGridField();
            this.repositoryItemTextEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.xSALDOFINAL = new DevExpress.XtraPivotGrid.PivotGridField();
            this.xMOVIMIENTO = new DevExpress.XtraPivotGrid.PivotGridField();
            this.xMONTO = new DevExpress.XtraPivotGrid.PivotGridField();
            this.xDIFERENCIA = new DevExpress.XtraPivotGrid.PivotGridField();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.btnCargar = new DevExpress.XtraBars.BarButtonItem();
            this.btnMovimiento = new DevExpress.XtraBars.BarButtonItem();
            this.btnExcel = new DevExpress.XtraBars.BarButtonItem();
            this.btnCerrar = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pivotGridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // xFECHAOPERACION
            // 
            this.xFECHAOPERACION.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
            this.xFECHAOPERACION.AreaIndex = 0;
            this.xFECHAOPERACION.Caption = "FECHA";
            this.xFECHAOPERACION.FieldName = "FECHAOPERACION";
            this.xFECHAOPERACION.GroupInterval = DevExpress.XtraPivotGrid.PivotGroupInterval.DateMonthYear;
            this.xFECHAOPERACION.Name = "xFECHAOPERACION";
            this.xFECHAOPERACION.UnboundFieldName = "pivotGridFieldAnio";
            this.xFECHAOPERACION.ValueFormat.FormatString = "d";
            this.xFECHAOPERACION.ValueFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            // 
            // xEMPRESA
            // 
            this.xEMPRESA.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.xEMPRESA.AreaIndex = 0;
            this.xEMPRESA.Caption = "EMPRESA";
            this.xEMPRESA.FieldName = "EMPRESA";
            this.xEMPRESA.MinWidth = 100;
            this.xEMPRESA.Name = "xEMPRESA";
            this.xEMPRESA.Options.HideEmptyVariationItems = true;
            // 
            // xCTABANCARIA
            // 
            this.xCTABANCARIA.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.xCTABANCARIA.AreaIndex = 1;
            this.xCTABANCARIA.Caption = "CTABANCARIA";
            this.xCTABANCARIA.FieldName = "CTABANCARIA";
            this.xCTABANCARIA.Name = "xCTABANCARIA";
            this.xCTABANCARIA.Options.HideEmptyVariationItems = true;
            this.xCTABANCARIA.Width = 120;
            // 
            // xMONEDA
            // 
            this.xMONEDA.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.xMONEDA.AreaIndex = 2;
            this.xMONEDA.Caption = "MONEDA";
            this.xMONEDA.FieldName = "MONEDA";
            this.xMONEDA.MinWidth = 90;
            this.xMONEDA.Name = "xMONEDA";
            this.xMONEDA.Options.HideEmptyVariationItems = true;
            this.xMONEDA.Width = 120;
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.pivotGridControl1);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 20);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(919, 481);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // pivotGridControl1
            // 
            this.pivotGridControl1.AppearancePrint.FieldHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.pivotGridControl1.AppearancePrint.FieldHeader.Options.UseFont = true;
            this.pivotGridControl1.Fields.AddRange(new DevExpress.XtraPivotGrid.PivotGridField[] {
            this.xIDEMPRESA,
            this.xIDCTABANCO,
            this.xEMPRESA,
            this.xCTABANCARIA,
            this.xMONEDA,
            this.xFECHAOPERACION,
            this.xSALDOINICIAL,
            this.xSALDOFINAL,
            this.xMOVIMIENTO,
            this.xMONTO,
            this.xDIFERENCIA});
            pivotGridGroup1.Fields.Add(this.xFECHAOPERACION);
            this.pivotGridControl1.Groups.AddRange(new DevExpress.XtraPivotGrid.PivotGridGroup[] {
            pivotGridGroup1});
            this.pivotGridControl1.Location = new System.Drawing.Point(6, 6);
            this.pivotGridControl1.Name = "pivotGridControl1";
            this.pivotGridControl1.OptionsCustomization.AllowHideFields = DevExpress.XtraPivotGrid.AllowHideFieldsType.Never;
            this.pivotGridControl1.OptionsCustomization.CustomizationFormSearchBoxVisible = true;
            this.pivotGridControl1.OptionsPrint.MergeColumnFieldValues = false;
            this.pivotGridControl1.OptionsPrint.MergeRowFieldValues = false;
            this.pivotGridControl1.OptionsPrint.PrintColumnHeaders = DevExpress.Utils.DefaultBoolean.False;
            this.pivotGridControl1.OptionsPrint.PrintDataHeaders = DevExpress.Utils.DefaultBoolean.False;
            this.pivotGridControl1.OptionsPrint.PrintFilterHeaders = DevExpress.Utils.DefaultBoolean.False;
            this.pivotGridControl1.OptionsPrint.PrintHorzLines = DevExpress.Utils.DefaultBoolean.True;
            this.pivotGridControl1.OptionsPrint.PrintRowHeaders = DevExpress.Utils.DefaultBoolean.True;
            this.pivotGridControl1.OptionsPrint.PrintUnusedFilterFields = false;
            this.pivotGridControl1.OptionsPrint.PrintVertLines = DevExpress.Utils.DefaultBoolean.False;
            this.pivotGridControl1.OptionsPrint.UsePrintAppearance = true;
            this.pivotGridControl1.OptionsView.ShowColumnGrandTotalHeader = false;
            this.pivotGridControl1.OptionsView.ShowColumnGrandTotals = false;
            this.pivotGridControl1.OptionsView.ShowColumnTotals = false;
            this.pivotGridControl1.OptionsView.ShowDataHeaders = false;
            this.pivotGridControl1.OptionsView.ShowRowGrandTotalHeader = false;
            this.pivotGridControl1.OptionsView.ShowRowGrandTotals = false;
            this.pivotGridControl1.OptionsView.ShowRowTotals = false;
            this.pivotGridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemTextEdit1});
            this.pivotGridControl1.Size = new System.Drawing.Size(907, 469);
            this.pivotGridControl1.TabIndex = 5;
            this.pivotGridControl1.CustomUnboundFieldData += new DevExpress.XtraPivotGrid.CustomFieldDataEventHandler(this.pivotGridControl1_CustomUnboundFieldData);
            this.pivotGridControl1.FieldValueDisplayText += new DevExpress.XtraPivotGrid.PivotFieldDisplayTextEventHandler(this.pivotGridControl1_FieldValueDisplayText);
            this.pivotGridControl1.CustomCellValue += new System.EventHandler<DevExpress.XtraPivotGrid.PivotCellValueEventArgs>(this.pivotGridControl1_CustomCellValue);
            this.pivotGridControl1.EditValueChanged += new DevExpress.XtraPivotGrid.EditValueChangedEventHandler(this.pivotGridControl1_EditValueChanged);
            // 
            // xIDEMPRESA
            // 
            this.xIDEMPRESA.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.xIDEMPRESA.AreaIndex = 3;
            this.xIDEMPRESA.Caption = "IDEMPRESA";
            this.xIDEMPRESA.FieldName = "IDEMPRESA";
            this.xIDEMPRESA.Name = "xIDEMPRESA";
            this.xIDEMPRESA.Visible = false;
            // 
            // xIDCTABANCO
            // 
            this.xIDCTABANCO.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.xIDCTABANCO.AreaIndex = 3;
            this.xIDCTABANCO.Caption = "IDCTABANCO";
            this.xIDCTABANCO.FieldName = "IDCTABANCO";
            this.xIDCTABANCO.Name = "xIDCTABANCO";
            this.xIDCTABANCO.Visible = false;
            // 
            // xSALDOINICIAL
            // 
            this.xSALDOINICIAL.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            this.xSALDOINICIAL.AreaIndex = 0;
            this.xSALDOINICIAL.Caption = "SALDOINICIAL";
            this.xSALDOINICIAL.CellFormat.FormatString = "n2";
            this.xSALDOINICIAL.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.xSALDOINICIAL.EmptyCellText = "0.000";
            this.xSALDOINICIAL.EmptyValueText = "0.00";
            this.xSALDOINICIAL.FieldEdit = this.repositoryItemTextEdit1;
            this.xSALDOINICIAL.FieldName = "SALDOINICIAL";
            this.xSALDOINICIAL.Name = "xSALDOINICIAL";
            this.xSALDOINICIAL.Options.HideEmptyVariationItems = true;
            this.xSALDOINICIAL.ValueFormat.FormatString = "f2";
            this.xSALDOINICIAL.ValueFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            // 
            // repositoryItemTextEdit1
            // 
            this.repositoryItemTextEdit1.AutoHeight = false;
            this.repositoryItemTextEdit1.DisplayFormat.FormatString = "n2";
            this.repositoryItemTextEdit1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.repositoryItemTextEdit1.EditFormat.FormatString = "f2";
            this.repositoryItemTextEdit1.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.repositoryItemTextEdit1.Mask.EditMask = "f2";
            this.repositoryItemTextEdit1.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.repositoryItemTextEdit1.Name = "repositoryItemTextEdit1";
            // 
            // xSALDOFINAL
            // 
            this.xSALDOFINAL.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            this.xSALDOFINAL.AreaIndex = 1;
            this.xSALDOFINAL.Caption = "SALDOFINAL";
            this.xSALDOFINAL.CellFormat.FormatString = "n2";
            this.xSALDOFINAL.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.xSALDOFINAL.FieldName = "SALDOFINAL";
            this.xSALDOFINAL.Name = "xSALDOFINAL";
            this.xSALDOFINAL.Options.HideEmptyVariationItems = true;
            this.xSALDOFINAL.ValueFormat.FormatString = "f2";
            this.xSALDOFINAL.ValueFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            // 
            // xMOVIMIENTO
            // 
            this.xMOVIMIENTO.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            this.xMOVIMIENTO.AreaIndex = 2;
            this.xMOVIMIENTO.Caption = "MOVIMIENTO";
            this.xMOVIMIENTO.CellFormat.FormatString = "n2";
            this.xMOVIMIENTO.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.xMOVIMIENTO.FieldName = "MOVIMIENTO";
            this.xMOVIMIENTO.Name = "xMOVIMIENTO";
            this.xMOVIMIENTO.Options.HideEmptyVariationItems = true;
            this.xMOVIMIENTO.ValueFormat.FormatString = "n2";
            this.xMOVIMIENTO.ValueFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            // 
            // xMONTO
            // 
            this.xMONTO.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            this.xMONTO.AreaIndex = 3;
            this.xMONTO.Caption = "MONTO";
            this.xMONTO.CellFormat.FormatString = "n2";
            this.xMONTO.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.xMONTO.FieldName = "MONTO";
            this.xMONTO.Name = "xMONTO";
            this.xMONTO.Options.HideEmptyVariationItems = true;
            this.xMONTO.ValueFormat.FormatString = "f2";
            this.xMONTO.ValueFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            // 
            // xDIFERENCIA
            // 
            this.xDIFERENCIA.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            this.xDIFERENCIA.AreaIndex = 4;
            this.xDIFERENCIA.Caption = "DIFERENCIA";
            this.xDIFERENCIA.CellFormat.FormatString = "n2";
            this.xDIFERENCIA.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.xDIFERENCIA.FieldName = "DIFERENCIA";
            this.xDIFERENCIA.Name = "xDIFERENCIA";
            this.xDIFERENCIA.Options.HideEmptyVariationItems = true;
            this.xDIFERENCIA.ValueFormat.FormatString = "f2";
            this.xDIFERENCIA.ValueFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(919, 481);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.pivotGridControl1;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(909, 471);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
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
            this.btnCargar,
            this.btnMovimiento,
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
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnCargar, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnMovimiento, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnExcel, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnCerrar, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar1.OptionsBar.AllowQuickCustomization = false;
            this.bar1.OptionsBar.DrawBorder = false;
            this.bar1.OptionsBar.MultiLine = true;
            this.bar1.OptionsBar.UseWholeRow = true;
            this.bar1.Text = "Menú principal";
            // 
            // btnCargar
            // 
            this.btnCargar.Caption = "Cargar";
            this.btnCargar.Id = 5;
            this.btnCargar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnCargar.ImageOptions.Image")));
            this.btnCargar.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnCargar.ImageOptions.LargeImage")));
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnCargar_ItemClick);
            // 
            // btnMovimiento
            // 
            this.btnMovimiento.Caption = "Movimientos Sueltos";
            this.btnMovimiento.Id = 6;
            this.btnMovimiento.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnMovimiento.ImageOptions.Image")));
            this.btnMovimiento.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnMovimiento.ImageOptions.LargeImage")));
            this.btnMovimiento.Name = "btnMovimiento";
            this.btnMovimiento.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bntMovimiento_ItemClick);
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
            this.barDockControlTop.Size = new System.Drawing.Size(919, 20);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 501);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(919, 0);
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
            this.barDockControlRight.Location = new System.Drawing.Point(919, 20);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 481);
            // 
            // frmCuadraturaMF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(919, 501);
            this.Controls.Add(this.layoutControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.IconOptions.Icon = ((System.Drawing.Icon)(resources.GetObject("frmCuadraturaMF.IconOptions.Icon")));
            this.Name = "frmCuadraturaMF";
            this.Text = "Cuadratura MF";
            this.Load += new System.EventHandler(this.frmCuadraturaMF_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pivotGridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarButtonItem btnCargar;
        private DevExpress.XtraBars.BarButtonItem btnMovimiento;
        private DevExpress.XtraBars.BarButtonItem btnExcel;
        private DevExpress.XtraBars.BarButtonItem btnCerrar;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraPivotGrid.PivotGridControl pivotGridControl1;
        private DevExpress.XtraPivotGrid.PivotGridField xEMPRESA;
        private DevExpress.XtraPivotGrid.PivotGridField xCTABANCARIA;
        private DevExpress.XtraPivotGrid.PivotGridField xFECHAOPERACION;
        private DevExpress.XtraPivotGrid.PivotGridField xMONTO;
        private DevExpress.XtraPivotGrid.PivotGridField xSALDOINICIAL;
        private DevExpress.XtraPivotGrid.PivotGridField xMONEDA;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraPivotGrid.PivotGridField xIDEMPRESA;
        private DevExpress.XtraPivotGrid.PivotGridField xIDCTABANCO;
        private DevExpress.XtraPivotGrid.PivotGridField xSALDOFINAL;
        private DevExpress.XtraPivotGrid.PivotGridField xMOVIMIENTO;
        private DevExpress.XtraPivotGrid.PivotGridField xDIFERENCIA;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit1;
    }
}