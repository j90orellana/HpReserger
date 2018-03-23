using CrystalDecisions.Shared;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HPReserger
{
    public partial class frmRPTExportarRequerimiento : Form
    {
        public frmRPTExportarRequerimiento()
        {
            InitializeComponent();
        }
        HPResergerCapaDatos.HPResergerCD datos = new HPResergerCapaDatos.HPResergerCD();
        public string numerodocumento;
        public string codigodocumento;
        private void frmRPTExportarRequerimiento_Load(object sender, EventArgs e)
        {
            rptReporteRequerimientos requeri = new rptReporteRequerimientos();
            requeri.Refresh();
            requeri.SetDatabaseLogon(datos.USERID, datos.USERPASS);
            requeri.SetParameterValue(0, numerodocumento);
            requeri.SetParameterValue(1, codigodocumento);
            rptreporterequerimientos.AllowedExportFormats = (int)(ViewerExportFormats.PdfFormat | ViewerExportFormats.RtfFormat | ViewerExportFormats.EditableRtfFormat);
            
            ConnectionInfo iConnectionInfo = new ConnectionInfo();
            // ' *****************************************************************************************************************
            // ' configuro el acceso a la base de datos
            //   ' *****************************************************************************************************************
            //iConnectionInfo.DatabaseName = datos.BASEDEDATOS;
            iConnectionInfo.DatabaseName = HPResergerCapaDatos.HPResergerCD.BASEDEDATOS;
            iConnectionInfo.UserID = datos.USERID;
            iConnectionInfo.Password = datos.USERPASS;
            iConnectionInfo.ServerName = datos.DATASOURCE;

            iConnectionInfo.Type = ConnectionInfoType.SQL;
            CrystalDecisions.CrystalReports.Engine.Tables myTables;

            myTables = requeri.Database.Tables;

            foreach (CrystalDecisions.CrystalReports.Engine.Table mytable in myTables)
            {
                TableLogOnInfo myTableLogonInfo = mytable.LogOnInfo;
                //Dim myTableLogonInfo As TableLogOnInfo = myTable.LogOnInfo
                myTableLogonInfo.ConnectionInfo = iConnectionInfo;
                //  myTableLogonInfo.ConnectionInfo = myConnectionInfo
                mytable.ApplyLogOnInfo(myTableLogonInfo);
                //myTable.ApplyLogOnInfo(myTableLogonInfo)
            }

            rptreporterequerimientos.ReportSource = requeri;
            rptreporterequerimientos.AllowedExportFormats = (int)(ExportFormatType.PortableDocFormat | ExportFormatType.Excel | ExportFormatType.ExcelWorkbook);

            rptreporterequerimientos.Zoom(150);
        }

        private void rptreporterequerimientos_ReportRefresh(object source, CrystalDecisions.Windows.Forms.ViewerEventArgs e)
        {
            frmRPTExportarRequerimiento_Load(rptreporterequerimientos, e);
            e.Handled = true;
        }
    }
}
