using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrystalDecisions.Shared;

namespace HPReserger
{
    public partial class frmReporteNecesidadMercado : Form
    {
        public frmReporteNecesidadMercado()
        {
            InitializeComponent();
        }
        HPResergerCapaDatos.HPResergerCD datos = new HPResergerCapaDatos.HPResergerCD();
        public string numero, tipo;
        public int contrato;

        private void crvnecesidadmercado_ReportRefresh(object source, CrystalDecisions.Windows.Forms.ViewerEventArgs e)
        {
            frmReporteNecesidadMercado_Load(crvnecesidadmercado, e);
            e.Handled = true;
        }
        private void frmReporteNecesidadMercado_Load(object sender, EventArgs e)
        {
            crvnecesidadmercado.AllowedExportFormats = (int)(ViewerExportFormats.PdfFormat | ViewerExportFormats.RtfFormat | ViewerExportFormats.EditableRtfFormat);
            rptNecesidadMercado reporte = new rptNecesidadMercado();
            reporte.Refresh();
            reporte.SetParameterValue(0, contrato);
            reporte.SetParameterValue(1, tipo);
            reporte.SetParameterValue(2, numero);
            reporte.SetDatabaseLogon(HPResergerCapaDatos.HPResergerCD.USERID, HPResergerCapaDatos.HPResergerCD.USERPASS);

            crvnecesidadmercado.Zoom(125);
            //crvnecesidadmercado.ReportSource = reporte;
            
            ConnectionInfo iConnectionInfo = new ConnectionInfo();
            // ' *****************************************************************************************************************
            // ' configuro el acceso a la base de datos
            //   ' *****************************************************************************************************************
            //iConnectionInfo.DatabaseName = datos.BASEDEDATOS;
            iConnectionInfo.DatabaseName = HPResergerCapaDatos.HPResergerCD.BASEDEDATOS;
            iConnectionInfo.UserID = HPResergerCapaDatos.HPResergerCD.USERID;
            iConnectionInfo.Password = HPResergerCapaDatos.HPResergerCD.USERPASS;
            iConnectionInfo.ServerName = HPResergerCapaDatos.HPResergerCD.DATASOURCE;

            iConnectionInfo.Type = ConnectionInfoType.SQL;
            CrystalDecisions.CrystalReports.Engine.Tables myTables;

            myTables = reporte.Database.Tables;
            
            foreach (CrystalDecisions.CrystalReports.Engine.Table mytable in myTables)
            {
                TableLogOnInfo myTableLogonInfo = mytable.LogOnInfo;
                myTableLogonInfo.ConnectionInfo = iConnectionInfo;
                mytable.ApplyLogOnInfo(myTableLogonInfo);
            }
            crvnecesidadmercado.ReportSource = reporte;
            crvnecesidadmercado.AllowedExportFormats = (int)(ExportFormatType.PortableDocFormat | ExportFormatType.Excel | ExportFormatType.ExcelWorkbook);

        }
    }
}
