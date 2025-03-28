namespace SISGEM.ModuloXtraReports.Contable
{
    partial class XtraReportEstadoResultadoIntegral
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

        #region Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            DevExpress.DataAccess.ObjectBinding.Parameter parameter1 = new DevExpress.DataAccess.ObjectBinding.Parameter();
            DevExpress.DataAccess.ObjectBinding.Parameter parameter2 = new DevExpress.DataAccess.ObjectBinding.Parameter();
            DevExpress.DataAccess.ObjectBinding.Parameter parameter3 = new DevExpress.DataAccess.ObjectBinding.Parameter();
            DevExpress.XtraReports.UI.CrossTab.CrossTabColumnDefinition crossTabColumnDefinition1 = new DevExpress.XtraReports.UI.CrossTab.CrossTabColumnDefinition(171.8302F);
            DevExpress.XtraReports.UI.CrossTab.CrossTabColumnDefinition crossTabColumnDefinition2 = new DevExpress.XtraReports.UI.CrossTab.CrossTabColumnDefinition(48.14442F);
            DevExpress.XtraReports.UI.CrossTab.CrossTabColumnDefinition crossTabColumnDefinition3 = new DevExpress.XtraReports.UI.CrossTab.CrossTabColumnDefinition(31.68907F);
            DevExpress.XtraReports.UI.CrossTab.CrossTabColumnField crossTabColumnField1 = new DevExpress.XtraReports.UI.CrossTab.CrossTabColumnField();
            DevExpress.XtraReports.UI.CrossTab.CrossTabDataField crossTabDataField1 = new DevExpress.XtraReports.UI.CrossTab.CrossTabDataField();
            DevExpress.XtraReports.UI.CrossTab.CrossTabRowField crossTabRowField1 = new DevExpress.XtraReports.UI.CrossTab.CrossTabRowField();
            this.objectDataSource1 = new DevExpress.DataAccess.ObjectBinding.ObjectDataSource(this.components);
            this.ReportHeader = new DevExpress.XtraReports.UI.ReportHeaderBand();
            this.label1 = new DevExpress.XtraReports.UI.XRLabel();
            this.Detail = new DevExpress.XtraReports.UI.DetailBand();
            this.TopMargin = new DevExpress.XtraReports.UI.TopMarginBand();
            this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
            this.TitleStyle = new DevExpress.XtraReports.UI.XRControlStyle();
            this.PageHeader = new DevExpress.XtraReports.UI.PageHeaderBand();
            this.xrLabel1 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrCrossTab1 = new DevExpress.XtraReports.UI.XRCrossTab();
            this.crossTabHeaderCell1 = new DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell();
            this.crossTabDataCell1 = new DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell();
            this.crossTabHeaderCell2 = new DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell();
            this.crossTabHeaderCell3 = new DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell();
            this.crossTabHeaderCell4 = new DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell();
            this.crossTabTotalCell1 = new DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell();
            this.crossTabHeaderCell5 = new DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell();
            this.crossTabTotalCell2 = new DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell();
            this.crossTabTotalCell3 = new DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell();
            this.crossTabGeneralStyle1 = new DevExpress.XtraReports.UI.XRControlStyle();
            this.crossTabHeaderStyle1 = new DevExpress.XtraReports.UI.XRControlStyle();
            this.crossTabDataStyle1 = new DevExpress.XtraReports.UI.XRControlStyle();
            this.crossTabTotalStyle1 = new DevExpress.XtraReports.UI.XRControlStyle();
            ((System.ComponentModel.ISupportInitialize)(this.objectDataSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrCrossTab1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // objectDataSource1
            // 
            this.objectDataSource1.DataMember = "GenerarEstadoResultadoIntegral";
            this.objectDataSource1.DataSource = typeof(HpResergerNube.Contabilidad);
            this.objectDataSource1.Name = "objectDataSource1";
            parameter1.Name = "empresa";
            parameter1.Type = typeof(DevExpress.DataAccess.Expression);
            parameter1.Value = new DevExpress.DataAccess.Expression("?xnombreempresa", typeof(string));
            parameter2.Name = "año1";
            parameter2.Type = typeof(DevExpress.DataAccess.Expression);
            parameter2.Value = new DevExpress.DataAccess.Expression("?xyear1", typeof(int));
            parameter3.Name = "año2";
            parameter3.Type = typeof(DevExpress.DataAccess.Expression);
            parameter3.Value = new DevExpress.DataAccess.Expression("?xyear2", typeof(int));
            this.objectDataSource1.Parameters.AddRange(new DevExpress.DataAccess.ObjectBinding.Parameter[] {
            parameter1,
            parameter2,
            parameter3});
            // 
            // ReportHeader
            // 
            this.ReportHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.ReportHeader.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.label1});
            this.ReportHeader.HeightF = 42.01302F;
            this.ReportHeader.Name = "ReportHeader";
            this.ReportHeader.StylePriority.UseBackColor = false;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Empty;
            this.label1.Font = new System.Drawing.Font("Tahoma", 18F);
            this.label1.LocationFloat = new DevExpress.Utils.PointFloat(6F, 6F);
            this.label1.Name = "label1";
            this.label1.SizeF = new System.Drawing.SizeF(291.6831F, 30.01302F);
            this.label1.StyleName = "TitleStyle";
            this.label1.StylePriority.UseBackColor = false;
            this.label1.StylePriority.UseFont = false;
            this.label1.Text = "Estado Resultado Integral";
            // 
            // Detail
            // 
            this.Detail.BackColor = System.Drawing.Color.Lime;
            this.Detail.HeightF = 23F;
            this.Detail.Name = "Detail";
            this.Detail.StylePriority.UseBackColor = false;
            this.Detail.Visible = false;
            // 
            // TopMargin
            // 
            this.TopMargin.HeightF = 50.52084F;
            this.TopMargin.Name = "TopMargin";
            // 
            // BottomMargin
            // 
            this.BottomMargin.HeightF = 37.86097F;
            this.BottomMargin.Name = "BottomMargin";
            // 
            // TitleStyle
            // 
            this.TitleStyle.Font = new System.Drawing.Font("Arial", 18F);
            this.TitleStyle.Name = "TitleStyle";
            this.TitleStyle.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            // 
            // PageHeader
            // 
            this.PageHeader.BackColor = System.Drawing.Color.Empty;
            this.PageHeader.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel1,
            this.xrCrossTab1});
            this.PageHeader.HeightF = 103.3854F;
            this.PageHeader.Name = "PageHeader";
            this.PageHeader.StylePriority.UseBackColor = false;
            // 
            // xrLabel1
            // 
            this.xrLabel1.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[EMPRESA]")});
            this.xrLabel1.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.xrLabel1.LocationFloat = new DevExpress.Utils.PointFloat(10.00002F, 10.00002F);
            this.xrLabel1.Multiline = true;
            this.xrLabel1.Name = "xrLabel1";
            this.xrLabel1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel1.SizeF = new System.Drawing.SizeF(503.7152F, 23F);
            this.xrLabel1.StylePriority.UseFont = false;
            this.xrLabel1.Text = "xrLabel1";
            // 
            // xrCrossTab1
            // 
            this.xrCrossTab1.Cells.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.crossTabHeaderCell1,
            this.crossTabDataCell1,
            this.crossTabHeaderCell2,
            this.crossTabHeaderCell3,
            this.crossTabHeaderCell4,
            this.crossTabTotalCell1,
            this.crossTabHeaderCell5,
            this.crossTabTotalCell2,
            this.crossTabTotalCell3});
            crossTabColumnDefinition1.AutoWidthMode = DevExpress.XtraReports.UI.AutoSizeMode.ShrinkAndGrow;
            crossTabColumnDefinition2.AutoWidthMode = DevExpress.XtraReports.UI.AutoSizeMode.ShrinkAndGrow;
            crossTabColumnDefinition3.AutoWidthMode = DevExpress.XtraReports.UI.AutoSizeMode.GrowOnly;
            this.xrCrossTab1.ColumnDefinitions.AddRange(new DevExpress.XtraReports.UI.CrossTab.CrossTabColumnDefinition[] {
            crossTabColumnDefinition1,
            crossTabColumnDefinition2,
            crossTabColumnDefinition3});
            crossTabColumnField1.FieldName = "FECCHA";
            crossTabColumnField1.GroupInterval = DevExpress.XtraReports.UI.CrossTab.GroupInterval.DateYear;
            this.xrCrossTab1.ColumnFields.AddRange(new DevExpress.XtraReports.UI.CrossTab.CrossTabColumnField[] {
            crossTabColumnField1});
            this.xrCrossTab1.DataAreaStyleName = "crossTabDataStyle1";
            crossTabDataField1.FieldName = "CONTABLE";
            this.xrCrossTab1.DataFields.AddRange(new DevExpress.XtraReports.UI.CrossTab.CrossTabDataField[] {
            crossTabDataField1});
            this.xrCrossTab1.DataSource = this.objectDataSource1;
            this.xrCrossTab1.GeneralStyleName = "crossTabGeneralStyle1";
            this.xrCrossTab1.HeaderAreaStyleName = "crossTabHeaderStyle1";
            this.xrCrossTab1.LocationFloat = new DevExpress.Utils.PointFloat(10.00002F, 38.64585F);
            this.xrCrossTab1.Name = "xrCrossTab1";
            this.xrCrossTab1.RowDefinitions.AddRange(new DevExpress.XtraReports.UI.CrossTab.CrossTabRowDefinition[] {
            new DevExpress.XtraReports.UI.CrossTab.CrossTabRowDefinition(19.47338F),
            new DevExpress.XtraReports.UI.CrossTab.CrossTabRowDefinition(19.47338F),
            new DevExpress.XtraReports.UI.CrossTab.CrossTabRowDefinition(19.47338F)});
            crossTabRowField1.FieldName = "PAREADO";
            crossTabRowField1.SortOrder = DevExpress.XtraReports.UI.XRColumnSortOrder.None;
            this.xrCrossTab1.RowFields.AddRange(new DevExpress.XtraReports.UI.CrossTab.CrossTabRowField[] {
            crossTabRowField1});
            this.xrCrossTab1.SizeF = new System.Drawing.SizeF(251.6637F, 58.42015F);
            this.xrCrossTab1.TotalAreaStyleName = "crossTabTotalStyle1";
            // 
            // crossTabHeaderCell1
            // 
            this.crossTabHeaderCell1.BackColor = System.Drawing.Color.White;
            this.crossTabHeaderCell1.ColumnIndex = 0;
            this.crossTabHeaderCell1.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.crossTabHeaderCell1.Name = "crossTabHeaderCell1";
            this.crossTabHeaderCell1.RowIndex = 0;
            // 
            // crossTabDataCell1
            // 
            this.crossTabDataCell1.ColumnIndex = 1;
            this.crossTabDataCell1.Font = new System.Drawing.Font("Tahoma", 8F);
            this.crossTabDataCell1.Name = "crossTabDataCell1";
            this.crossTabDataCell1.RowIndex = 1;
            this.crossTabDataCell1.TextFormatString = "{0:#,##0.00;(#,##0.00);-}";
            // 
            // crossTabHeaderCell2
            // 
            this.crossTabHeaderCell2.BackColor = System.Drawing.Color.White;
            this.crossTabHeaderCell2.ColumnIndex = 1;
            this.crossTabHeaderCell2.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.crossTabHeaderCell2.Name = "crossTabHeaderCell2";
            this.crossTabHeaderCell2.RowIndex = 0;
            this.crossTabHeaderCell2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            // 
            // crossTabHeaderCell3
            // 
            this.crossTabHeaderCell3.BackColor = System.Drawing.Color.White;
            this.crossTabHeaderCell3.ColumnIndex = 0;
            this.crossTabHeaderCell3.Font = new System.Drawing.Font("Tahoma", 8F);
            this.crossTabHeaderCell3.Name = "crossTabHeaderCell3";
            this.crossTabHeaderCell3.RowIndex = 1;
            // 
            // crossTabHeaderCell4
            // 
            this.crossTabHeaderCell4.BackColor = System.Drawing.Color.White;
            this.crossTabHeaderCell4.ColumnIndex = 2;
            this.crossTabHeaderCell4.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.crossTabHeaderCell4.Name = "crossTabHeaderCell4";
            this.crossTabHeaderCell4.RowIndex = 0;
            this.crossTabHeaderCell4.Text = "TOTAL";
            this.crossTabHeaderCell4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            // 
            // crossTabTotalCell1
            // 
            this.crossTabTotalCell1.ColumnIndex = 2;
            this.crossTabTotalCell1.Font = new System.Drawing.Font("Tahoma", 8F);
            this.crossTabTotalCell1.Name = "crossTabTotalCell1";
            this.crossTabTotalCell1.RowIndex = 1;
            this.crossTabTotalCell1.TextFormatString = "{0:#,##0.00;(#,##0.00);-}";
            // 
            // crossTabHeaderCell5
            // 
            this.crossTabHeaderCell5.BackColor = System.Drawing.Color.White;
            this.crossTabHeaderCell5.ColumnIndex = 0;
            this.crossTabHeaderCell5.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.crossTabHeaderCell5.Name = "crossTabHeaderCell5";
            this.crossTabHeaderCell5.RowIndex = 2;
            this.crossTabHeaderCell5.Text = "RESULTADOS DEL EJERCICIO";
            // 
            // crossTabTotalCell2
            // 
            this.crossTabTotalCell2.ColumnIndex = 1;
            this.crossTabTotalCell2.Font = new System.Drawing.Font("Tahoma", 8F);
            this.crossTabTotalCell2.Name = "crossTabTotalCell2";
            this.crossTabTotalCell2.RowIndex = 2;
            this.crossTabTotalCell2.TextFormatString = "{0:#,##0.00;(#,##0.00);-}";
            // 
            // crossTabTotalCell3
            // 
            this.crossTabTotalCell3.ColumnIndex = 2;
            this.crossTabTotalCell3.Font = new System.Drawing.Font("Tahoma", 8F);
            this.crossTabTotalCell3.Name = "crossTabTotalCell3";
            this.crossTabTotalCell3.RowIndex = 2;
            this.crossTabTotalCell3.TextFormatString = "{0:#,##0.00;(#,##0.00);-}";
            // 
            // crossTabGeneralStyle1
            // 
            this.crossTabGeneralStyle1.BackColor = System.Drawing.Color.White;
            this.crossTabGeneralStyle1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.crossTabGeneralStyle1.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.crossTabGeneralStyle1.Font = new System.Drawing.Font("Arial", 9.75F);
            this.crossTabGeneralStyle1.ForeColor = System.Drawing.Color.Black;
            this.crossTabGeneralStyle1.Name = "crossTabGeneralStyle1";
            this.crossTabGeneralStyle1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            // 
            // crossTabHeaderStyle1
            // 
            this.crossTabHeaderStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.crossTabHeaderStyle1.Name = "crossTabHeaderStyle1";
            this.crossTabHeaderStyle1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // crossTabDataStyle1
            // 
            this.crossTabDataStyle1.Name = "crossTabDataStyle1";
            this.crossTabDataStyle1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            // 
            // crossTabTotalStyle1
            // 
            this.crossTabTotalStyle1.Name = "crossTabTotalStyle1";
            this.crossTabTotalStyle1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            // 
            // XtraReportEstadoResultadoIntegral
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.ReportHeader,
            this.Detail,
            this.TopMargin,
            this.BottomMargin,
            this.PageHeader});
            this.ComponentStorage.AddRange(new System.ComponentModel.IComponent[] {
            this.objectDataSource1});
            this.Font = new System.Drawing.Font("Tahoma", 10F);
            this.HorizontalContentSplitting = DevExpress.XtraPrinting.HorizontalContentSplitting.Smart;
            this.Margins = new System.Drawing.Printing.Margins(100, 100, 51, 38);
            this.StyleSheet.AddRange(new DevExpress.XtraReports.UI.XRControlStyle[] {
            this.TitleStyle,
            this.crossTabGeneralStyle1,
            this.crossTabHeaderStyle1,
            this.crossTabDataStyle1,
            this.crossTabTotalStyle1});
            this.Version = "19.2";
            this.VerticalContentSplitting = DevExpress.XtraPrinting.VerticalContentSplitting.Smart;
            ((System.ComponentModel.ISupportInitialize)(this.objectDataSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrCrossTab1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }

        #endregion

        private DevExpress.DataAccess.ObjectBinding.ObjectDataSource objectDataSource1;
        private DevExpress.XtraReports.UI.ReportHeaderBand ReportHeader;
        private DevExpress.XtraReports.UI.XRLabel label1;
        private DevExpress.XtraReports.UI.DetailBand Detail;
        private DevExpress.XtraReports.UI.TopMarginBand TopMargin;
        private DevExpress.XtraReports.UI.BottomMarginBand BottomMargin;
        private DevExpress.XtraReports.UI.XRControlStyle TitleStyle;
        private DevExpress.XtraReports.UI.PageHeaderBand PageHeader;
        private DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell crossTabHeaderCell1;
        private DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell crossTabDataCell1;
        private DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell crossTabHeaderCell2;
        private DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell crossTabHeaderCell3;
        private DevExpress.XtraReports.UI.XRControlStyle crossTabGeneralStyle1;
        private DevExpress.XtraReports.UI.XRControlStyle crossTabHeaderStyle1;
        private DevExpress.XtraReports.UI.XRControlStyle crossTabDataStyle1;
        private DevExpress.XtraReports.UI.XRControlStyle crossTabTotalStyle1;
        private DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell crossTabHeaderCell4;
        private DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell crossTabTotalCell1;
        private DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell crossTabHeaderCell5;
        private DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell crossTabTotalCell2;
        private DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell crossTabTotalCell3;
        public DevExpress.XtraReports.UI.XRCrossTab xrCrossTab1;
        private DevExpress.XtraReports.UI.XRLabel xrLabel1;
    }
}
