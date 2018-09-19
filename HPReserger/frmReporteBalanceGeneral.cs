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
    public partial class frmReporteBalanceGeneral : Form
    {
        public frmReporteBalanceGeneral()
        {
            InitializeComponent();
        }
        public DateTime año = DateTime.Now.AddMonths(-1);
        public int empresa = 2;
        public string NombreEmpresa = "CONSTRUCTORA PRUEBA S.A.C.";
        HPResergerCapaDatos.HPResergerCD datos = new HPResergerCapaDatos.HPResergerCD();
        private void frmReporteBalanceGeneral_Load(object sender, EventArgs e)
        {
            //rptBalanceGeneral Reporte = new rptBalanceGeneral();
            rptBalanceGeneralPro Reporte = new rptBalanceGeneralPro();
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
                myTableLogonInfo.ConnectionInfo = iConnectionInfo;
                mytable.ApplyLogOnInfo(myTableLogonInfo);
                //mytable.TestConnectivity();
            }
            crvreporte.AllowedExportFormats = (int)(ExportFormatType.PortableDocFormat | ExportFormatType.Excel | ExportFormatType.RichText);
            crvreporte.ReportSource = Reporte;
        }
        private void crvreporte_ReportRefresh(object source, CrystalDecisions.Windows.Forms.ViewerEventArgs e)
        {
            e.Handled = true;
            frmReporteBalanceGeneral_Load(crvreporte, e);
        }
    }
}
