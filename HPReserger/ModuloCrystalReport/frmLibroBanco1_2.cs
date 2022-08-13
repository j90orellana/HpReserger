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

namespace HPReserger.ModuloCrystalReport
{
    public partial class frmLibroBanco1_2 : FormGradient
    {
        public frmLibroBanco1_2()
        {
            InitializeComponent();
        }
        HPResergerCapaLogica.HPResergerCL CapaLogica = new HPResergerCapaLogica.HPResergerCL();
        HPResergerCapaDatos.HPResergerCD datos = new HPResergerCapaDatos.HPResergerCD();
        rptLibroBanco_2 reporte;
        public DateTime FechaIni, FechaFin;
        public string ListadoEmpresas;
        private void frmLibroBanco1_2_Load(object sender, EventArgs e)
        {
            reporte = new rptLibroBanco_2();
            reporte.SetParameterValue("@FechaInicial", FechaIni);
            reporte.SetParameterValue("@FechaFinal", FechaFin);
            reporte.SetParameterValue("@Empresa", ListadoEmpresas);

            reporte.SetDatabaseLogon(datos.USERID, datos.USERPASS);
            ConnectionInfo iConnectionInfo = new ConnectionInfo();
            // ' ***************************************************************
            // ' configuro el acceso a la base de datos
            // ' ***************************************************************
            //iConnectionInfo.DatabaseName = datos.BASEDEDATOS;
            iConnectionInfo.DatabaseName = HPResergerCapaDatos.HPResergerCD.BASEDEDATOS;
            iConnectionInfo.UserID = datos.USERID;
            iConnectionInfo.Password = datos.USERPASS;
            iConnectionInfo.ServerName = datos.DATASOURCE;

            iConnectionInfo.Type = ConnectionInfoType.SQL;
            CrystalDecisions.CrystalReports.Engine.Tables myTables;

            myTables = reporte.Database.Tables;

            foreach (CrystalDecisions.CrystalReports.Engine.Table mytable in myTables)
            {
                TableLogOnInfo myTableLogonInfo = mytable.LogOnInfo;
                myTableLogonInfo.ConnectionInfo = iConnectionInfo;
                mytable.ApplyLogOnInfo(myTableLogonInfo);
            }
            //reporte.FileName = $"Conciliacion Bancaria {empresa} del " + fechaini.ToString("MMMM/yyyy") + " al " + fechafin.ToString("MMMM/yyyy");
            crvReporte.AllowedExportFormats = (int)(ExportFormatType.PortableDocFormat | ExportFormatType.Excel | ExportFormatType.ExcelWorkbook | ExportFormatType.Text);
            crvReporte.ReportSource = reporte;
            //   reporte.FileName = $"{FechaIni.ToString("MMM/yyyy")}-{FechaFin.ToString("MMM/yyyy")} LIBRO DIARIO 5.1";

            crvReporte.Zoom(1);
        }

        private void crvReporte_ReportRefresh(object source, CrystalDecisions.Windows.Forms.ViewerEventArgs e)
        {
            e.Handled = true;
            frmLibroBanco1_2_Load(source, e);
        }
    }
}
