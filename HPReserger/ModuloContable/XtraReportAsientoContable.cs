using System;
using DevExpress.XtraReports.UI;

namespace SISGEM.ModuloContable
{
    public class XtraReportAsientoContable : XtraReport

    {
        private DetailBand detailBand1;
        private TopMarginBand topMarginBand1;
        private DevExpress.DataAccess.Sql.SqlDataSource sqlDataSource1;
        private System.ComponentModel.IContainer components;
        private DevExpress.XtraReports.Parameters.Parameter empresa;
        private DevExpress.XtraReports.Parameters.Parameter fechaini;
        private DevExpress.XtraReports.Parameters.Parameter fechafin;
        private DevExpress.XtraReports.Parameters.Parameter cuo;
        private DevExpress.XtraReports.Parameters.Parameter cuenta;
        private DevExpress.XtraReports.Parameters.Parameter glosa;
        private DevExpress.XtraReports.Parameters.Parameter suboperacion;
        private DevExpress.XtraReports.Parameters.Parameter estado;
        private XRLabel xrLabel1;
        private XRLabel xrLabel2;
        private PageHeaderBand PageHeader;
        private XRLabel xrLabel11;
        private XRLabel xrLabel12;
        private XRLabel xrLabel14;
        private XRLabel xrLabel3;
        private XRLabel xrLabel4;
        private XRLabel xrLabel5;
        private XRLabel xrLabel6;
        private XRLabel xrLabel7;
        private XRLabel xrLabel8;
        private XRLabel xrLabel9;
        private PageFooterBand PageFooter;
        private XRLabel xrLabel10;
        private XRLabel xrLabel13;
        private GroupHeaderBand GroupHeader1;
        private GroupHeaderBand GroupHeader2;
        private GroupFooterBand GroupFooter1;
        private GroupFooterBand GroupFooter2;
        private XRLabel xrLabel17;
        private XRLabel xrLabel16;
        private XRLabel xrLabel15;
        private XRLabel xrLabel18;
        private XRLabel xrLabel19;
        private XRLabel xrLabel21;
        private XRLabel xrLabel20;
        private XRLabel xrLabel29;
        private XRLabel xrLabel28;
        private XRLabel xrLabel27;
        private XRLabel xrLabel30;
        private XRLabel xrLabel31;
        private XRLabel xrLabel25;
        private XRLabel xrLabel24;
        private XRLabel xrLabel23;
        private XRLabel xrLabel22;
        private XRLabel xrLabel26;
        private XRLabel xrLabel32;
        private XRLabel xrLabel33;
        private XRLabel xrLabel34;
        private CalculatedField calculatedField1;
        private BottomMarginBand bottomMarginBand1;

        public XtraReportAsientoContable()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            DevExpress.XtraReports.UI.XRSummary xrSummary1 = new DevExpress.XtraReports.UI.XRSummary();
            DevExpress.DataAccess.ConnectionParameters.MsSqlConnectionParameters msSqlConnectionParameters1 = new DevExpress.DataAccess.ConnectionParameters.MsSqlConnectionParameters();
            DevExpress.DataAccess.Sql.StoredProcQuery storedProcQuery1 = new DevExpress.DataAccess.Sql.StoredProcQuery();
            DevExpress.DataAccess.Sql.QueryParameter queryParameter1 = new DevExpress.DataAccess.Sql.QueryParameter();
            DevExpress.DataAccess.Sql.QueryParameter queryParameter2 = new DevExpress.DataAccess.Sql.QueryParameter();
            DevExpress.DataAccess.Sql.QueryParameter queryParameter3 = new DevExpress.DataAccess.Sql.QueryParameter();
            DevExpress.DataAccess.Sql.QueryParameter queryParameter4 = new DevExpress.DataAccess.Sql.QueryParameter();
            DevExpress.DataAccess.Sql.QueryParameter queryParameter5 = new DevExpress.DataAccess.Sql.QueryParameter();
            DevExpress.DataAccess.Sql.QueryParameter queryParameter6 = new DevExpress.DataAccess.Sql.QueryParameter();
            DevExpress.DataAccess.Sql.QueryParameter queryParameter7 = new DevExpress.DataAccess.Sql.QueryParameter();
            DevExpress.DataAccess.Sql.QueryParameter queryParameter8 = new DevExpress.DataAccess.Sql.QueryParameter();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(XtraReportAsientoContable));
            DevExpress.XtraReports.UI.XRSummary xrSummary2 = new DevExpress.XtraReports.UI.XRSummary();
            DevExpress.XtraReports.UI.XRSummary xrSummary3 = new DevExpress.XtraReports.UI.XRSummary();
            this.detailBand1 = new DevExpress.XtraReports.UI.DetailBand();
            this.xrLabel29 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel28 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel27 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel19 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel17 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel16 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel15 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel11 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel12 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel14 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel30 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel31 = new DevExpress.XtraReports.UI.XRLabel();
            this.topMarginBand1 = new DevExpress.XtraReports.UI.TopMarginBand();
            this.bottomMarginBand1 = new DevExpress.XtraReports.UI.BottomMarginBand();
            this.sqlDataSource1 = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.empresa = new DevExpress.XtraReports.Parameters.Parameter();
            this.fechaini = new DevExpress.XtraReports.Parameters.Parameter();
            this.fechafin = new DevExpress.XtraReports.Parameters.Parameter();
            this.cuo = new DevExpress.XtraReports.Parameters.Parameter();
            this.cuenta = new DevExpress.XtraReports.Parameters.Parameter();
            this.glosa = new DevExpress.XtraReports.Parameters.Parameter();
            this.suboperacion = new DevExpress.XtraReports.Parameters.Parameter();
            this.estado = new DevExpress.XtraReports.Parameters.Parameter();
            this.xrLabel1 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel2 = new DevExpress.XtraReports.UI.XRLabel();
            this.PageHeader = new DevExpress.XtraReports.UI.PageHeaderBand();
            this.xrLabel3 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel4 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel5 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel6 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel7 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel8 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel9 = new DevExpress.XtraReports.UI.XRLabel();
            this.PageFooter = new DevExpress.XtraReports.UI.PageFooterBand();
            this.xrLabel10 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel13 = new DevExpress.XtraReports.UI.XRLabel();
            this.GroupHeader1 = new DevExpress.XtraReports.UI.GroupHeaderBand();
            this.GroupHeader2 = new DevExpress.XtraReports.UI.GroupHeaderBand();
            this.xrLabel25 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel24 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel23 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel22 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel21 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel20 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel18 = new DevExpress.XtraReports.UI.XRLabel();
            this.GroupFooter1 = new DevExpress.XtraReports.UI.GroupFooterBand();
            this.xrLabel33 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel26 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel32 = new DevExpress.XtraReports.UI.XRLabel();
            this.GroupFooter2 = new DevExpress.XtraReports.UI.GroupFooterBand();
            this.xrLabel34 = new DevExpress.XtraReports.UI.XRLabel();
            this.calculatedField1 = new DevExpress.XtraReports.UI.CalculatedField();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // detailBand1
            // 
            this.detailBand1.BackColor = System.Drawing.Color.Transparent;
            this.detailBand1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel29,
            this.xrLabel28,
            this.xrLabel27,
            this.xrLabel19,
            this.xrLabel17,
            this.xrLabel16,
            this.xrLabel15,
            this.xrLabel11,
            this.xrLabel12,
            this.xrLabel14,
            this.xrLabel30,
            this.xrLabel31});
            this.detailBand1.Dpi = 254F;
            this.detailBand1.HeightF = 35F;
            this.detailBand1.KeepTogether = true;
            this.detailBand1.Name = "detailBand1";
            this.detailBand1.StylePriority.UseBackColor = false;
            // 
            // xrLabel29
            // 
            this.xrLabel29.BackColor = System.Drawing.Color.Transparent;
            this.xrLabel29.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "usp_ListarAsientosFiltradosAvanzadopdf.glosaDetalle")});
            this.xrLabel29.Dpi = 254F;
            this.xrLabel29.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel29.LocationFloat = new DevExpress.Utils.PointFloat(2236.337F, 0F);
            this.xrLabel29.Name = "xrLabel29";
            this.xrLabel29.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254F);
            this.xrLabel29.SizeF = new System.Drawing.SizeF(328.3799F, 35F);
            this.xrLabel29.StylePriority.UseBackColor = false;
            this.xrLabel29.StylePriority.UseFont = false;
            this.xrLabel29.WordWrap = false;
            // 
            // xrLabel28
            // 
            this.xrLabel28.BackColor = System.Drawing.Color.Transparent;
            this.xrLabel28.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "usp_ListarAsientosFiltradosAvanzadopdf.haber", "{0:n2}")});
            this.xrLabel28.Dpi = 254F;
            this.xrLabel28.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel28.LocationFloat = new DevExpress.Utils.PointFloat(2048.441F, 0F);
            this.xrLabel28.Name = "xrLabel28";
            this.xrLabel28.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254F);
            this.xrLabel28.SizeF = new System.Drawing.SizeF(187.896F, 35F);
            this.xrLabel28.StylePriority.UseBackColor = false;
            this.xrLabel28.StylePriority.UseFont = false;
            this.xrLabel28.StylePriority.UseTextAlignment = false;
            this.xrLabel28.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            this.xrLabel28.WordWrap = false;
            // 
            // xrLabel27
            // 
            this.xrLabel27.BackColor = System.Drawing.Color.Transparent;
            this.xrLabel27.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "usp_ListarAsientosFiltradosAvanzadopdf.debe")});
            this.xrLabel27.Dpi = 254F;
            this.xrLabel27.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel27.LocationFloat = new DevExpress.Utils.PointFloat(1860.545F, 0F);
            this.xrLabel27.Name = "xrLabel27";
            this.xrLabel27.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254F);
            this.xrLabel27.SizeF = new System.Drawing.SizeF(187.896F, 35F);
            this.xrLabel27.StylePriority.UseBackColor = false;
            this.xrLabel27.StylePriority.UseFont = false;
            this.xrLabel27.StylePriority.UseTextAlignment = false;
            xrSummary1.FormatString = "{0:n2}";
            this.xrLabel27.Summary = xrSummary1;
            this.xrLabel27.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            this.xrLabel27.WordWrap = false;
            // 
            // xrLabel19
            // 
            this.xrLabel19.BackColor = System.Drawing.Color.Transparent;
            this.xrLabel19.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "usp_ListarAsientosFiltradosAvanzadopdf.Fecha_Emision", "{0:dd/MM/yyyy}")});
            this.xrLabel19.Dpi = 254F;
            this.xrLabel19.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel19.LocationFloat = new DevExpress.Utils.PointFloat(1688.083F, 0F);
            this.xrLabel19.Name = "xrLabel19";
            this.xrLabel19.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254F);
            this.xrLabel19.SizeF = new System.Drawing.SizeF(172.4622F, 35F);
            this.xrLabel19.StylePriority.UseBackColor = false;
            this.xrLabel19.StylePriority.UseFont = false;
            this.xrLabel19.WordWrap = false;
            // 
            // xrLabel17
            // 
            this.xrLabel17.BackColor = System.Drawing.Color.Transparent;
            this.xrLabel17.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "usp_ListarAsientosFiltradosAvanzadopdf.Cod_Comprobante")});
            this.xrLabel17.Dpi = 254F;
            this.xrLabel17.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel17.LocationFloat = new DevExpress.Utils.PointFloat(1416.229F, 0F);
            this.xrLabel17.Name = "xrLabel17";
            this.xrLabel17.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254F);
            this.xrLabel17.SizeF = new System.Drawing.SizeF(83.95715F, 35F);
            this.xrLabel17.StylePriority.UseBackColor = false;
            this.xrLabel17.StylePriority.UseFont = false;
            this.xrLabel17.StylePriority.UseTextAlignment = false;
            this.xrLabel17.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            this.xrLabel17.WordWrap = false;
            // 
            // xrLabel16
            // 
            this.xrLabel16.BackColor = System.Drawing.Color.Transparent;
            this.xrLabel16.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "usp_ListarAsientosFiltradosAvanzadopdf.Num_Comprobante")});
            this.xrLabel16.Dpi = 254F;
            this.xrLabel16.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel16.LocationFloat = new DevExpress.Utils.PointFloat(1500.187F, 0F);
            this.xrLabel16.Name = "xrLabel16";
            this.xrLabel16.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254F);
            this.xrLabel16.SizeF = new System.Drawing.SizeF(187.8961F, 35F);
            this.xrLabel16.StylePriority.UseBackColor = false;
            this.xrLabel16.StylePriority.UseFont = false;
            this.xrLabel16.WordWrap = false;
            // 
            // xrLabel15
            // 
            this.xrLabel15.BackColor = System.Drawing.Color.Transparent;
            this.xrLabel15.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "usp_ListarAsientosFiltradosAvanzadopdf.Razon_Social")});
            this.xrLabel15.Dpi = 254F;
            this.xrLabel15.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel15.LocationFloat = new DevExpress.Utils.PointFloat(927.313F, 0F);
            this.xrLabel15.Name = "xrLabel15";
            this.xrLabel15.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254F);
            this.xrLabel15.SizeF = new System.Drawing.SizeF(488.9165F, 35F);
            this.xrLabel15.StylePriority.UseBackColor = false;
            this.xrLabel15.StylePriority.UseFont = false;
            this.xrLabel15.WordWrap = false;
            // 
            // xrLabel11
            // 
            this.xrLabel11.BackColor = System.Drawing.Color.Transparent;
            this.xrLabel11.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "usp_ListarAsientosFiltradosAvanzadopdf.CuentaDescripcion")});
            this.xrLabel11.Dpi = 254F;
            this.xrLabel11.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel11.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.xrLabel11.Name = "xrLabel11";
            this.xrLabel11.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254F);
            this.xrLabel11.SizeF = new System.Drawing.SizeF(689.4166F, 35F);
            this.xrLabel11.StylePriority.UseBackColor = false;
            this.xrLabel11.StylePriority.UseFont = false;
            this.xrLabel11.Text = "xrLabel11";
            this.xrLabel11.WordWrap = false;
            // 
            // xrLabel12
            // 
            this.xrLabel12.BackColor = System.Drawing.Color.Transparent;
            this.xrLabel12.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "usp_ListarAsientosFiltradosAvanzadopdf.Num_Doc")});
            this.xrLabel12.Dpi = 254F;
            this.xrLabel12.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel12.LocationFloat = new DevExpress.Utils.PointFloat(739.4169F, 0F);
            this.xrLabel12.Name = "xrLabel12";
            this.xrLabel12.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254F);
            this.xrLabel12.SizeF = new System.Drawing.SizeF(187.8961F, 35F);
            this.xrLabel12.StylePriority.UseBackColor = false;
            this.xrLabel12.StylePriority.UseFont = false;
            this.xrLabel12.WordWrap = false;
            // 
            // xrLabel14
            // 
            this.xrLabel14.BackColor = System.Drawing.Color.Transparent;
            this.xrLabel14.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "usp_ListarAsientosFiltradosAvanzadopdf.Id_Comprobante", "{0:00}")});
            this.xrLabel14.Dpi = 254F;
            this.xrLabel14.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel14.LocationFloat = new DevExpress.Utils.PointFloat(689.4169F, 0F);
            this.xrLabel14.Name = "xrLabel14";
            this.xrLabel14.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254F);
            this.xrLabel14.SizeF = new System.Drawing.SizeF(50F, 35F);
            this.xrLabel14.StylePriority.UseBackColor = false;
            this.xrLabel14.StylePriority.UseFont = false;
            this.xrLabel14.WordWrap = false;
            // 
            // xrLabel30
            // 
            this.xrLabel30.BackColor = System.Drawing.Color.Transparent;
            this.xrLabel30.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "usp_ListarAsientosFiltradosAvanzadopdf.NameCorto")});
            this.xrLabel30.Dpi = 254F;
            this.xrLabel30.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel30.LocationFloat = new DevExpress.Utils.PointFloat(2564.717F, 0F);
            this.xrLabel30.Name = "xrLabel30";
            this.xrLabel30.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254F);
            this.xrLabel30.SizeF = new System.Drawing.SizeF(78.11719F, 35F);
            this.xrLabel30.StylePriority.UseBackColor = false;
            this.xrLabel30.StylePriority.UseFont = false;
            this.xrLabel30.WordWrap = false;
            // 
            // xrLabel31
            // 
            this.xrLabel31.BackColor = System.Drawing.Color.Transparent;
            this.xrLabel31.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "usp_ListarAsientosFiltradosAvanzadopdf.TcDetalle", "{0:n3}")});
            this.xrLabel31.Dpi = 254F;
            this.xrLabel31.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel31.LocationFloat = new DevExpress.Utils.PointFloat(2642.834F, 0F);
            this.xrLabel31.Name = "xrLabel31";
            this.xrLabel31.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254F);
            this.xrLabel31.SizeF = new System.Drawing.SizeF(100.1658F, 35F);
            this.xrLabel31.StylePriority.UseBackColor = false;
            this.xrLabel31.StylePriority.UseFont = false;
            this.xrLabel31.StylePriority.UseTextAlignment = false;
            this.xrLabel31.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            this.xrLabel31.WordWrap = false;
            // 
            // topMarginBand1
            // 
            this.topMarginBand1.BackColor = System.Drawing.Color.Transparent;
            this.topMarginBand1.Dpi = 254F;
            this.topMarginBand1.HeightF = 146F;
            this.topMarginBand1.Name = "topMarginBand1";
            this.topMarginBand1.StylePriority.UseBackColor = false;
            // 
            // bottomMarginBand1
            // 
            this.bottomMarginBand1.Dpi = 254F;
            this.bottomMarginBand1.HeightF = 0F;
            this.bottomMarginBand1.Name = "bottomMarginBand1";
            // 
            // sqlDataSource1
            // 
            this.sqlDataSource1.ConnectionName = "192.168.10.200_LIBRE_Connection";
            msSqlConnectionParameters1.AuthorizationType = DevExpress.DataAccess.ConnectionParameters.MsSqlAuthorizationType.SqlServer;
            msSqlConnectionParameters1.DatabaseName = "LIBRE";
            msSqlConnectionParameters1.ServerName = "192.168.10.200";
            this.sqlDataSource1.ConnectionParameters = msSqlConnectionParameters1;
            this.sqlDataSource1.Name = "sqlDataSource1";
            storedProcQuery1.Name = "usp_ListarAsientosFiltradosAvanzadopdf";
            queryParameter1.Name = "@empresa";
            queryParameter1.Type = typeof(DevExpress.DataAccess.Expression);
            queryParameter1.Value = new DevExpress.DataAccess.Expression("[Parameters.empresa]", typeof(int));
            queryParameter2.Name = "@fechaini";
            queryParameter2.Type = typeof(DevExpress.DataAccess.Expression);
            queryParameter2.Value = new DevExpress.DataAccess.Expression("[Parameters.fechaini]", typeof(System.DateTime));
            queryParameter3.Name = "@fechafin";
            queryParameter3.Type = typeof(DevExpress.DataAccess.Expression);
            queryParameter3.Value = new DevExpress.DataAccess.Expression("[Parameters.fechafin]", typeof(System.DateTime));
            queryParameter4.Name = "@cuo";
            queryParameter4.Type = typeof(DevExpress.DataAccess.Expression);
            queryParameter4.Value = new DevExpress.DataAccess.Expression("[Parameters.cuo]", typeof(string));
            queryParameter5.Name = "@cuenta";
            queryParameter5.Type = typeof(DevExpress.DataAccess.Expression);
            queryParameter5.Value = new DevExpress.DataAccess.Expression("[Parameters.cuenta]", typeof(string));
            queryParameter6.Name = "@glosa";
            queryParameter6.Type = typeof(DevExpress.DataAccess.Expression);
            queryParameter6.Value = new DevExpress.DataAccess.Expression("[Parameters.glosa]", typeof(string));
            queryParameter7.Name = "@SubOperacion";
            queryParameter7.Type = typeof(DevExpress.DataAccess.Expression);
            queryParameter7.Value = new DevExpress.DataAccess.Expression("[Parameters.suboperacion]", typeof(string));
            queryParameter8.Name = "@Estado";
            queryParameter8.Type = typeof(DevExpress.DataAccess.Expression);
            queryParameter8.Value = new DevExpress.DataAccess.Expression("[Parameters.estado]", typeof(int));
            storedProcQuery1.Parameters.Add(queryParameter1);
            storedProcQuery1.Parameters.Add(queryParameter2);
            storedProcQuery1.Parameters.Add(queryParameter3);
            storedProcQuery1.Parameters.Add(queryParameter4);
            storedProcQuery1.Parameters.Add(queryParameter5);
            storedProcQuery1.Parameters.Add(queryParameter6);
            storedProcQuery1.Parameters.Add(queryParameter7);
            storedProcQuery1.Parameters.Add(queryParameter8);
            storedProcQuery1.StoredProcName = "usp_ListarAsientosFiltradosAvanzadopdf";
            this.sqlDataSource1.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            storedProcQuery1});
            this.sqlDataSource1.ResultSchemaSerializable = resources.GetString("sqlDataSource1.ResultSchemaSerializable");
            // 
            // empresa
            // 
            this.empresa.Name = "empresa";
            this.empresa.Type = typeof(int);
            this.empresa.ValueInfo = "2";
            // 
            // fechaini
            // 
            this.fechaini.Name = "fechaini";
            this.fechaini.Type = typeof(System.DateTime);
            this.fechaini.ValueInfo = "2025-01-01";
            // 
            // fechafin
            // 
            this.fechafin.Name = "fechafin";
            this.fechafin.Type = typeof(System.DateTime);
            this.fechafin.ValueInfo = "2025-03-04";
            // 
            // cuo
            // 
            this.cuo.Name = "cuo";
            // 
            // cuenta
            // 
            this.cuenta.Name = "cuenta";
            this.cuenta.ValueInfo = " ";
            // 
            // glosa
            // 
            this.glosa.Name = "glosa";
            this.glosa.ValueInfo = " ";
            // 
            // suboperacion
            // 
            this.suboperacion.Name = "suboperacion";
            this.suboperacion.ValueInfo = " ";
            // 
            // estado
            // 
            this.estado.Name = "estado";
            this.estado.Type = typeof(int);
            this.estado.ValueInfo = "1";
            // 
            // xrLabel1
            // 
            this.xrLabel1.BackColor = System.Drawing.Color.Transparent;
            this.xrLabel1.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "usp_ListarAsientosFiltradosAvanzadopdf.NameEmpresa")});
            this.xrLabel1.Dpi = 254F;
            this.xrLabel1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.xrLabel1.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.xrLabel1.Name = "xrLabel1";
            this.xrLabel1.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254F);
            this.xrLabel1.SizeF = new System.Drawing.SizeF(700F, 45.72F);
            this.xrLabel1.StylePriority.UseBackColor = false;
            this.xrLabel1.StylePriority.UseFont = false;
            this.xrLabel1.Text = "xrLabel1";
            // 
            // xrLabel2
            // 
            this.xrLabel2.BackColor = System.Drawing.Color.Transparent;
            this.xrLabel2.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "usp_ListarAsientosFiltradosAvanzadopdf.RUC", "R.U.C. {0}")});
            this.xrLabel2.Dpi = 254F;
            this.xrLabel2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.xrLabel2.LocationFloat = new DevExpress.Utils.PointFloat(0F, 60.69914F);
            this.xrLabel2.Name = "xrLabel2";
            this.xrLabel2.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254F);
            this.xrLabel2.SizeF = new System.Drawing.SizeF(700F, 45.72F);
            this.xrLabel2.StylePriority.UseBackColor = false;
            this.xrLabel2.StylePriority.UseFont = false;
            this.xrLabel2.Text = "xrLabel2";
            // 
            // PageHeader
            // 
            this.PageHeader.BackColor = System.Drawing.Color.Transparent;
            this.PageHeader.Dpi = 254F;
            this.PageHeader.HeightF = 0F;
            this.PageHeader.Name = "PageHeader";
            this.PageHeader.StylePriority.UseBackColor = false;
            // 
            // xrLabel3
            // 
            this.xrLabel3.BackColor = System.Drawing.Color.Transparent;
            this.xrLabel3.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "usp_ListarAsientosFiltradosAvanzadopdf.cuo")});
            this.xrLabel3.Dpi = 254F;
            this.xrLabel3.LocationFloat = new DevExpress.Utils.PointFloat(276.6666F, 128.2083F);
            this.xrLabel3.Name = "xrLabel3";
            this.xrLabel3.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254F);
            this.xrLabel3.SizeF = new System.Drawing.SizeF(423.3332F, 45.72F);
            this.xrLabel3.StylePriority.UseBackColor = false;
            this.xrLabel3.Text = "xrLabel3";
            // 
            // xrLabel4
            // 
            this.xrLabel4.BackColor = System.Drawing.Color.Transparent;
            this.xrLabel4.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "usp_ListarAsientosFiltradosAvanzadopdf.periodo")});
            this.xrLabel4.Dpi = 254F;
            this.xrLabel4.LocationFloat = new DevExpress.Utils.PointFloat(276.6666F, 177.0099F);
            this.xrLabel4.Name = "xrLabel4";
            this.xrLabel4.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254F);
            this.xrLabel4.SizeF = new System.Drawing.SizeF(423.3332F, 45.72F);
            this.xrLabel4.StylePriority.UseBackColor = false;
            this.xrLabel4.Text = "xrLabel4";
            // 
            // xrLabel5
            // 
            this.xrLabel5.BackColor = System.Drawing.Color.Transparent;
            this.xrLabel5.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "usp_ListarAsientosFiltradosAvanzadopdf.Fecha_Asiento", "{0:dd/MM/yyyy}")});
            this.xrLabel5.Dpi = 254F;
            this.xrLabel5.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.xrLabel5.LocationFloat = new DevExpress.Utils.PointFloat(1127.687F, 177.0099F);
            this.xrLabel5.Name = "xrLabel5";
            this.xrLabel5.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254F);
            this.xrLabel5.SizeF = new System.Drawing.SizeF(403.6666F, 45.72F);
            this.xrLabel5.StylePriority.UseBackColor = false;
            this.xrLabel5.StylePriority.UseFont = false;
            this.xrLabel5.Text = "xrLabel5";
            // 
            // xrLabel6
            // 
            this.xrLabel6.BackColor = System.Drawing.Color.Transparent;
            this.xrLabel6.Dpi = 254F;
            this.xrLabel6.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.xrLabel6.LocationFloat = new DevExpress.Utils.PointFloat(1227.667F, 60.69914F);
            this.xrLabel6.Name = "xrLabel6";
            this.xrLabel6.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254F);
            this.xrLabel6.SizeF = new System.Drawing.SizeF(485.6877F, 45.72F);
            this.xrLabel6.StylePriority.UseBackColor = false;
            this.xrLabel6.StylePriority.UseFont = false;
            this.xrLabel6.Text = "VOUCHER GENERAL";
            // 
            // xrLabel7
            // 
            this.xrLabel7.BackColor = System.Drawing.Color.Transparent;
            this.xrLabel7.Dpi = 254F;
            this.xrLabel7.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.xrLabel7.LocationFloat = new DevExpress.Utils.PointFloat(0F, 128.2083F);
            this.xrLabel7.Name = "xrLabel7";
            this.xrLabel7.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254F);
            this.xrLabel7.SizeF = new System.Drawing.SizeF(276.6667F, 45.72F);
            this.xrLabel7.StylePriority.UseBackColor = false;
            this.xrLabel7.StylePriority.UseFont = false;
            this.xrLabel7.StylePriority.UseTextAlignment = false;
            this.xrLabel7.Text = "CORRELATIVO:";
            this.xrLabel7.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            // 
            // xrLabel8
            // 
            this.xrLabel8.BackColor = System.Drawing.Color.Transparent;
            this.xrLabel8.Dpi = 254F;
            this.xrLabel8.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.xrLabel8.LocationFloat = new DevExpress.Utils.PointFloat(0F, 177.0099F);
            this.xrLabel8.Name = "xrLabel8";
            this.xrLabel8.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254F);
            this.xrLabel8.SizeF = new System.Drawing.SizeF(276.6667F, 45.72F);
            this.xrLabel8.StylePriority.UseBackColor = false;
            this.xrLabel8.StylePriority.UseFont = false;
            this.xrLabel8.StylePriority.UseTextAlignment = false;
            this.xrLabel8.Text = "PERIODO:";
            this.xrLabel8.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            // 
            // xrLabel9
            // 
            this.xrLabel9.BackColor = System.Drawing.Color.Transparent;
            this.xrLabel9.Dpi = 254F;
            this.xrLabel9.LocationFloat = new DevExpress.Utils.PointFloat(888.0624F, 177.0099F);
            this.xrLabel9.Name = "xrLabel9";
            this.xrLabel9.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254F);
            this.xrLabel9.SizeF = new System.Drawing.SizeF(239.625F, 45.72F);
            this.xrLabel9.StylePriority.UseBackColor = false;
            this.xrLabel9.StylePriority.UseTextAlignment = false;
            this.xrLabel9.Text = "FECHA MOV.";
            this.xrLabel9.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            // 
            // PageFooter
            // 
            this.PageFooter.Dpi = 254F;
            this.PageFooter.HeightF = 123.9133F;
            this.PageFooter.Name = "PageFooter";
            // 
            // xrLabel10
            // 
            this.xrLabel10.BackColor = System.Drawing.Color.Transparent;
            this.xrLabel10.Dpi = 254F;
            this.xrLabel10.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.xrLabel10.LocationFloat = new DevExpress.Utils.PointFloat(0F, 276.1758F);
            this.xrLabel10.Name = "xrLabel10";
            this.xrLabel10.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254F);
            this.xrLabel10.SizeF = new System.Drawing.SizeF(689.4167F, 45.72F);
            this.xrLabel10.StylePriority.UseBackColor = false;
            this.xrLabel10.StylePriority.UseFont = false;
            this.xrLabel10.Text = "CUENTA - DESCRIPCION";
            // 
            // xrLabel13
            // 
            this.xrLabel13.BackColor = System.Drawing.Color.Transparent;
            this.xrLabel13.Dpi = 254F;
            this.xrLabel13.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.xrLabel13.LocationFloat = new DevExpress.Utils.PointFloat(689.4169F, 276.1758F);
            this.xrLabel13.Name = "xrLabel13";
            this.xrLabel13.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254F);
            this.xrLabel13.SizeF = new System.Drawing.SizeF(726.8126F, 45.72F);
            this.xrLabel13.StylePriority.UseBackColor = false;
            this.xrLabel13.StylePriority.UseFont = false;
            this.xrLabel13.StylePriority.UseTextAlignment = false;
            this.xrLabel13.Text = "ANEXO";
            this.xrLabel13.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // GroupHeader1
            // 
            this.GroupHeader1.Dpi = 254F;
            this.GroupHeader1.GroupFields.AddRange(new DevExpress.XtraReports.UI.GroupField[] {
            new DevExpress.XtraReports.UI.GroupField("NameEmpresa", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)});
            this.GroupHeader1.GroupUnion = DevExpress.XtraReports.UI.GroupUnion.WithFirstDetail;
            this.GroupHeader1.HeightF = 0F;
            this.GroupHeader1.KeepTogether = true;
            this.GroupHeader1.Level = 1;
            this.GroupHeader1.Name = "GroupHeader1";
            // 
            // GroupHeader2
            // 
            this.GroupHeader2.BackColor = System.Drawing.Color.Transparent;
            this.GroupHeader2.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel34,
            this.xrLabel25,
            this.xrLabel24,
            this.xrLabel23,
            this.xrLabel22,
            this.xrLabel21,
            this.xrLabel20,
            this.xrLabel18,
            this.xrLabel2,
            this.xrLabel3,
            this.xrLabel4,
            this.xrLabel5,
            this.xrLabel6,
            this.xrLabel7,
            this.xrLabel8,
            this.xrLabel9,
            this.xrLabel10,
            this.xrLabel13,
            this.xrLabel1});
            this.GroupHeader2.Dpi = 254F;
            this.GroupHeader2.GroupFields.AddRange(new DevExpress.XtraReports.UI.GroupField[] {
            new DevExpress.XtraReports.UI.GroupField("cuo", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)});
            this.GroupHeader2.GroupUnion = DevExpress.XtraReports.UI.GroupUnion.WithFirstDetail;
            this.GroupHeader2.HeightF = 328.375F;
            this.GroupHeader2.KeepTogether = true;
            this.GroupHeader2.Name = "GroupHeader2";
            this.GroupHeader2.StylePriority.UseBackColor = false;
            // 
            // xrLabel25
            // 
            this.xrLabel25.BackColor = System.Drawing.Color.Transparent;
            this.xrLabel25.Dpi = 254F;
            this.xrLabel25.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.xrLabel25.LocationFloat = new DevExpress.Utils.PointFloat(2642.834F, 276.1758F);
            this.xrLabel25.Name = "xrLabel25";
            this.xrLabel25.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254F);
            this.xrLabel25.SizeF = new System.Drawing.SizeF(100.1658F, 45.72F);
            this.xrLabel25.StylePriority.UseBackColor = false;
            this.xrLabel25.StylePriority.UseFont = false;
            this.xrLabel25.StylePriority.UseTextAlignment = false;
            this.xrLabel25.Text = "T.C.";
            this.xrLabel25.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            // 
            // xrLabel24
            // 
            this.xrLabel24.BackColor = System.Drawing.Color.Transparent;
            this.xrLabel24.Dpi = 254F;
            this.xrLabel24.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.xrLabel24.LocationFloat = new DevExpress.Utils.PointFloat(2564.717F, 276.1757F);
            this.xrLabel24.Name = "xrLabel24";
            this.xrLabel24.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254F);
            this.xrLabel24.SizeF = new System.Drawing.SizeF(78.11719F, 45.72F);
            this.xrLabel24.StylePriority.UseBackColor = false;
            this.xrLabel24.StylePriority.UseFont = false;
            this.xrLabel24.StylePriority.UseTextAlignment = false;
            this.xrLabel24.Text = "M.O.";
            this.xrLabel24.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // xrLabel23
            // 
            this.xrLabel23.BackColor = System.Drawing.Color.Transparent;
            this.xrLabel23.Dpi = 254F;
            this.xrLabel23.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.xrLabel23.LocationFloat = new DevExpress.Utils.PointFloat(2236.337F, 276.1758F);
            this.xrLabel23.Name = "xrLabel23";
            this.xrLabel23.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254F);
            this.xrLabel23.SizeF = new System.Drawing.SizeF(328.3801F, 45.72F);
            this.xrLabel23.StylePriority.UseBackColor = false;
            this.xrLabel23.StylePriority.UseFont = false;
            this.xrLabel23.StylePriority.UseTextAlignment = false;
            this.xrLabel23.Text = "GLOSA";
            this.xrLabel23.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // xrLabel22
            // 
            this.xrLabel22.BackColor = System.Drawing.Color.Transparent;
            this.xrLabel22.Dpi = 254F;
            this.xrLabel22.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.xrLabel22.LocationFloat = new DevExpress.Utils.PointFloat(2048.441F, 276.1757F);
            this.xrLabel22.Name = "xrLabel22";
            this.xrLabel22.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254F);
            this.xrLabel22.SizeF = new System.Drawing.SizeF(187.896F, 45.72F);
            this.xrLabel22.StylePriority.UseBackColor = false;
            this.xrLabel22.StylePriority.UseFont = false;
            this.xrLabel22.StylePriority.UseTextAlignment = false;
            this.xrLabel22.Text = "HABER";
            this.xrLabel22.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            // 
            // xrLabel21
            // 
            this.xrLabel21.BackColor = System.Drawing.Color.Transparent;
            this.xrLabel21.Dpi = 254F;
            this.xrLabel21.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.xrLabel21.LocationFloat = new DevExpress.Utils.PointFloat(1860.545F, 276.1757F);
            this.xrLabel21.Name = "xrLabel21";
            this.xrLabel21.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254F);
            this.xrLabel21.SizeF = new System.Drawing.SizeF(187.896F, 45.72F);
            this.xrLabel21.StylePriority.UseBackColor = false;
            this.xrLabel21.StylePriority.UseFont = false;
            this.xrLabel21.StylePriority.UseTextAlignment = false;
            this.xrLabel21.Text = "DEBE";
            this.xrLabel21.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            // 
            // xrLabel20
            // 
            this.xrLabel20.BackColor = System.Drawing.Color.Transparent;
            this.xrLabel20.Dpi = 254F;
            this.xrLabel20.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.xrLabel20.LocationFloat = new DevExpress.Utils.PointFloat(1688.083F, 276.1758F);
            this.xrLabel20.Name = "xrLabel20";
            this.xrLabel20.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254F);
            this.xrLabel20.SizeF = new System.Drawing.SizeF(172.4622F, 45.72F);
            this.xrLabel20.StylePriority.UseBackColor = false;
            this.xrLabel20.StylePriority.UseFont = false;
            this.xrLabel20.StylePriority.UseTextAlignment = false;
            this.xrLabel20.Text = "F.EMISIÓN";
            this.xrLabel20.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // xrLabel18
            // 
            this.xrLabel18.BackColor = System.Drawing.Color.Transparent;
            this.xrLabel18.Dpi = 254F;
            this.xrLabel18.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.xrLabel18.LocationFloat = new DevExpress.Utils.PointFloat(1416.229F, 276.1758F);
            this.xrLabel18.Name = "xrLabel18";
            this.xrLabel18.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254F);
            this.xrLabel18.SizeF = new System.Drawing.SizeF(271.8535F, 45.72F);
            this.xrLabel18.StylePriority.UseBackColor = false;
            this.xrLabel18.StylePriority.UseFont = false;
            this.xrLabel18.StylePriority.UseTextAlignment = false;
            this.xrLabel18.Text = "DOCUMENTO";
            this.xrLabel18.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // GroupFooter1
            // 
            this.GroupFooter1.BackColor = System.Drawing.Color.Transparent;
            this.GroupFooter1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel33,
            this.xrLabel26,
            this.xrLabel32});
            this.GroupFooter1.Dpi = 254F;
            this.GroupFooter1.HeightF = 273.4027F;
            this.GroupFooter1.KeepTogether = true;
            this.GroupFooter1.Name = "GroupFooter1";
            this.GroupFooter1.StylePriority.UseBackColor = false;
            // 
            // xrLabel33
            // 
            this.xrLabel33.BackColor = System.Drawing.Color.Transparent;
            this.xrLabel33.Dpi = 254F;
            this.xrLabel33.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.xrLabel33.LocationFloat = new DevExpress.Utils.PointFloat(1374.857F, 0F);
            this.xrLabel33.Name = "xrLabel33";
            this.xrLabel33.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254F);
            this.xrLabel33.SizeF = new System.Drawing.SizeF(485.6877F, 35F);
            this.xrLabel33.StylePriority.UseBackColor = false;
            this.xrLabel33.StylePriority.UseFont = false;
            this.xrLabel33.Text = "TOTAL VOUCHER:";
            // 
            // xrLabel26
            // 
            this.xrLabel26.BackColor = System.Drawing.Color.Transparent;
            this.xrLabel26.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "usp_ListarAsientosFiltradosAvanzadopdf.haber")});
            this.xrLabel26.Dpi = 254F;
            this.xrLabel26.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel26.LocationFloat = new DevExpress.Utils.PointFloat(2048.441F, 0F);
            this.xrLabel26.Name = "xrLabel26";
            this.xrLabel26.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254F);
            this.xrLabel26.SizeF = new System.Drawing.SizeF(187.896F, 35F);
            this.xrLabel26.StylePriority.UseBackColor = false;
            this.xrLabel26.StylePriority.UseFont = false;
            this.xrLabel26.StylePriority.UseTextAlignment = false;
            xrSummary2.FormatString = "{0:n2}";
            xrSummary2.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
            this.xrLabel26.Summary = xrSummary2;
            this.xrLabel26.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            this.xrLabel26.WordWrap = false;
            // 
            // xrLabel32
            // 
            this.xrLabel32.BackColor = System.Drawing.Color.Transparent;
            this.xrLabel32.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "usp_ListarAsientosFiltradosAvanzadopdf.debe")});
            this.xrLabel32.Dpi = 254F;
            this.xrLabel32.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel32.LocationFloat = new DevExpress.Utils.PointFloat(1860.545F, 0F);
            this.xrLabel32.Name = "xrLabel32";
            this.xrLabel32.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254F);
            this.xrLabel32.SizeF = new System.Drawing.SizeF(187.896F, 35F);
            this.xrLabel32.StylePriority.UseBackColor = false;
            this.xrLabel32.StylePriority.UseFont = false;
            this.xrLabel32.StylePriority.UseTextAlignment = false;
            xrSummary3.FormatString = "{0:n2}";
            xrSummary3.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
            this.xrLabel32.Summary = xrSummary3;
            this.xrLabel32.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            this.xrLabel32.WordWrap = false;
            // 
            // GroupFooter2
            // 
            this.GroupFooter2.Dpi = 254F;
            this.GroupFooter2.HeightF = 0F;
            this.GroupFooter2.KeepTogether = true;
            this.GroupFooter2.Level = 1;
            this.GroupFooter2.Name = "GroupFooter2";
            // 
            // xrLabel34
            // 
            this.xrLabel34.BackColor = System.Drawing.Color.Transparent;
            this.xrLabel34.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "calculatedField1")});
            this.xrLabel34.Dpi = 254F;
            this.xrLabel34.Font = new System.Drawing.Font("Tahoma", 7F);
            this.xrLabel34.LocationFloat = new DevExpress.Utils.PointFloat(1960.979F, 50.1875F);
            this.xrLabel34.Name = "xrLabel34";
            this.xrLabel34.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254F);
            this.xrLabel34.SizeF = new System.Drawing.SizeF(782.0214F, 45.72F);
            this.xrLabel34.StylePriority.UseBackColor = false;
            this.xrLabel34.StylePriority.UseFont = false;
            this.xrLabel34.StylePriority.UseTextAlignment = false;
            this.xrLabel34.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            // 
            // calculatedField1
            // 
            this.calculatedField1.DisplayName = "hoy";
            this.calculatedField1.Expression = "Now()";
            this.calculatedField1.FieldType = DevExpress.XtraReports.UI.FieldType.DateTime;
            this.calculatedField1.Name = "calculatedField1";
            // 
            // XtraReportAsientoContable
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.detailBand1,
            this.topMarginBand1,
            this.bottomMarginBand1,
            this.PageHeader,
            this.PageFooter,
            this.GroupHeader1,
            this.GroupHeader2,
            this.GroupFooter1,
            this.GroupFooter2});
            this.CalculatedFields.AddRange(new DevExpress.XtraReports.UI.CalculatedField[] {
            this.calculatedField1});
            this.ComponentStorage.AddRange(new System.ComponentModel.IComponent[] {
            this.sqlDataSource1});
            this.DataMember = "usp_ListarAsientosFiltradosAvanzadopdf";
            this.DataSource = this.sqlDataSource1;
            this.Dpi = 254F;
            this.ExportOptions.Pdf.DocumentOptions.Application = "AutoGest";
            this.ExportOptions.Pdf.DocumentOptions.Title = "Reporte Asiento Contable";
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.Landscape = true;
            this.Margins = new System.Drawing.Printing.Margins(130, 97, 146, 0);
            this.PageHeight = 2100;
            this.PageWidth = 2970;
            this.PaperKind = System.Drawing.Printing.PaperKind.A4;
            this.Parameters.AddRange(new DevExpress.XtraReports.Parameters.Parameter[] {
            this.empresa,
            this.fechaini,
            this.fechafin,
            this.cuo,
            this.cuenta,
            this.glosa,
            this.suboperacion,
            this.estado});
            this.ReportUnit = DevExpress.XtraReports.UI.ReportUnit.TenthsOfAMillimeter;
            this.Version = "15.1";
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }
    }
}
