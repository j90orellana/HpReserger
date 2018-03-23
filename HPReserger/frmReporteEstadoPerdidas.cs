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
    public partial class frmReporteEstadoPerdidas : Form
    {
        public frmReporteEstadoPerdidas()
        {
            InitializeComponent();
        }
        HPResergerCapaDatos.HPResergerCD datos = new HPResergerCapaDatos.HPResergerCD();
        public int empresa;
        public DateTime año;
        public string NombreEmpresa;
        private void frmReporteEstadoPerdidas_Load(object sender, EventArgs e)
        {
            rtpGanaciasPerdidas Reporte = new rtpGanaciasPerdidas();
            Reporte.SetDatabaseLogon(datos.USERID, datos.USERPASS);
            Reporte.SetParameterValue(0, año);
            Reporte.SetParameterValue(1, empresa); 
            Reporte.SetParameterValue(2, NombreEmpresa); 

             ConnectionInfo iConnectionInfo = new ConnectionInfo();
            // ' ***************************************'
            // ' configuro el acceso a la base de datos '
            // ' ***************************************'
            //iConnectionInfo.DatabaseName = datos.BASEDEDATOS;
            iConnectionInfo.DatabaseName = HPResergerCapaDatos.HPResergerCD.BASEDEDATOS;
            iConnectionInfo.UserID = datos.USERID;
            iConnectionInfo.Password = datos.USERPASS;
            iConnectionInfo.ServerName = datos.DATASOURCE;

            iConnectionInfo.Type = ConnectionInfoType.SQL;
            CrystalDecisions.CrystalReports.Engine.Tables myTables;

            myTables = Reporte.Database.Tables;
            foreach (CrystalDecisions.CrystalReports.Engine.Table mytable in myTables)
            {
                TableLogOnInfo myTableLogonInfo = mytable.LogOnInfo;
                //Dim myTableLogonInfo As TableLogOnInfo = myTable.LogOnInfo
                myTableLogonInfo.ConnectionInfo = iConnectionInfo;
                //  myTableLogonInfo.ConnectionInfo = myConnectionInfo
                mytable.ApplyLogOnInfo(myTableLogonInfo);
                //myTable.ApplyLogOnInfo(myTableLogonInfo)
            }      
                  
            crvreporte.AllowedExportFormats = (int)(ExportFormatType.PortableDocFormat | ExportFormatType.Excel | ExportFormatType.ExcelWorkbook);
            crvreporte.ReportSource = Reporte;
        }

        private void crvreporte_ReportRefresh(object source, CrystalDecisions.Windows.Forms.ViewerEventArgs e)
        {
            e.Handled = true;
            frmReporteEstadoPerdidas_Load(crvreporte, e);
        }
    }
}
