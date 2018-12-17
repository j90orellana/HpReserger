using CrystalDecisions.Shared;
using HpResergerUserControls;
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
    public partial class fmReporteRemuneracionRenta : FormGradient
    {
        public fmReporteRemuneracionRenta()
        {
            InitializeComponent();
        }
        public int empresa;
        public int tipo;
        public string numero = "";
        public int fecha;
        public int año;
        public DateTime fechainicial;
        HPResergerCapaDatos.HPResergerCD CapaLogica = new HPResergerCapaDatos.HPResergerCD();
        private void fmReporteRemuneracionRenta_Load(object sender, EventArgs e)
        {
            RptGenerarRenta reporte = new RptGenerarRenta();
            reporte.Refresh();
            reporte.SetParameterValue(0, empresa);
            reporte.SetParameterValue(1, tipo);
            reporte.SetParameterValue(2, numero);
            reporte.SetParameterValue(3, año);
            reporte.SetParameterValue(4, fechainicial);
            ///  reporte.SetParameterValue(3, fecha);
            ///   reporte.SetParameterValue(4, fechainicial);
            reporte.SetDatabaseLogon(CapaLogica.USERID, CapaLogica.USERPASS);

            ConnectionInfo iConnectionInfo = new ConnectionInfo();
            // ' *****************************************************************************************************************
            // ' configuro el acceso a la base de datos
            //   ' *****************************************************************************************************************
            //iConnectionInfo.DatabaseName = CapaLogica.BASEDEDATOS;
            iConnectionInfo.DatabaseName = HPResergerCapaDatos.HPResergerCD.BASEDEDATOS;
            iConnectionInfo.UserID = CapaLogica.USERID;
            iConnectionInfo.Password = CapaLogica.USERPASS;
            iConnectionInfo.ServerName = CapaLogica.DATASOURCE;

            iConnectionInfo.Type = ConnectionInfoType.SQL;
            CrystalDecisions.CrystalReports.Engine.Tables myTables;

            myTables = reporte.Database.Tables;

            foreach (CrystalDecisions.CrystalReports.Engine.Table mytable in myTables)
            {
                TableLogOnInfo myTableLogonInfo = mytable.LogOnInfo;
                //Dim myTableLogonInfo As TableLogOnInfo = myTable.LogOnInfo
                myTableLogonInfo.ConnectionInfo = iConnectionInfo;
                //  myTableLogonInfo.ConnectionInfo = myConnectionInfo
                mytable.ApplyLogOnInfo(myTableLogonInfo);
                //myTable.ApplyLogOnInfo(myTableLogonInfo)
            }

            crvboletas.ReportSource = reporte;
            crvboletas.AllowedExportFormats = (int)(ExportFormatType.PortableDocFormat | ExportFormatType.Excel | ExportFormatType.ExcelWorkbook);
        }
    }
}
