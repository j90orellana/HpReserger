using CrystalDecisions.Shared;
using HpResergerUserControls;
using SISGEM.ModuloCrystalReport;
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
    public partial class frmReporteLibro1_1 : FormGradient
    {
        public frmReporteLibro1_1()
        {
            InitializeComponent();
        }
        HPResergerCapaLogica.HPResergerCL CapaLogica = new HPResergerCapaLogica.HPResergerCL();
        HPResergerCapaDatos.HPResergerCD datos = new HPResergerCapaDatos.HPResergerCD();
        rptLibro1Caja_1 reporte;
        rptLibro1Caja_1_Ori reporteori;
        public DateTime FechaIni, FechaFin;
        public string ListadoEmpresas;

        public bool Matricial { get; internal set; }

        private void crvReporte_ReportRefresh(object source, CrystalDecisions.Windows.Forms.ViewerEventArgs e)
        {
            e.Handled = true;
            frmReporteLibro1_1_Load(source, e);
        }
        private void frmReporteLibro1_1_Load(object sender, EventArgs e)
        {
            if (Matricial)
            {
                reporte = new rptLibro1Caja_1();
                reporte.SetParameterValue("@FechaInicial", FechaIni);
                reporte.SetParameterValue("@FechaFinal", FechaFin);
                reporte.SetParameterValue("@Empresa", ListadoEmpresas);

                reporte.SetDatabaseLogon(HPResergerCapaDatos.HPResergerCD.USERID, HPResergerCapaDatos.HPResergerCD.USERPASS);

                ConnectionInfo iConnectionInfo = new ConnectionInfo();
                // ' ***************************************************************
                // ' configuro el acceso a la base de datos
                // ' ***************************************************************
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
                //reporte.FileName = $"Conciliacion Bancaria {empresa} del " + fechaini.ToString("MMMM/yyyy") + " al " + fechafin.ToString("MMMM/yyyy");
                crvReporte.AllowedExportFormats = (int)(ExportFormatType.PortableDocFormat | ExportFormatType.Excel | ExportFormatType.ExcelWorkbook | ExportFormatType.Text);
                crvReporte.ReportSource = reporte;
                //   reporte.FileName = $"{FechaIni.ToString("MMM/yyyy")}-{FechaFin.ToString("MMM/yyyy")} LIBRO DIARIO 5.1";

                crvReporte.Zoom(1);
            }
            else
            {
                reporteori = new rptLibro1Caja_1_Ori();
                reporteori.SetParameterValue("@FechaInicial", FechaIni);
                reporteori.SetParameterValue("@FechaFinal", FechaFin);
                reporteori.SetParameterValue("@Empresa", ListadoEmpresas);

                reporteori.SetDatabaseLogon(HPResergerCapaDatos.HPResergerCD.USERID, HPResergerCapaDatos.HPResergerCD.USERPASS);

                ConnectionInfo iConnectionInfo = new ConnectionInfo();
                // ' ***************************************************************
                // ' configuro el acceso a la base de datos
                // ' ***************************************************************
                //iConnectionInfo.DatabaseName = datos.BASEDEDATOS;
                iConnectionInfo.DatabaseName = HPResergerCapaDatos.HPResergerCD.BASEDEDATOS;
                iConnectionInfo.UserID = HPResergerCapaDatos.HPResergerCD.USERID;
                iConnectionInfo.Password = HPResergerCapaDatos.HPResergerCD.USERPASS;
                iConnectionInfo.ServerName = HPResergerCapaDatos.HPResergerCD.DATASOURCE;

                iConnectionInfo.Type = ConnectionInfoType.SQL;
                CrystalDecisions.CrystalReports.Engine.Tables myTables;

                myTables = reporteori.Database.Tables;

                foreach (CrystalDecisions.CrystalReports.Engine.Table mytable in myTables)
                {
                    TableLogOnInfo myTableLogonInfo = mytable.LogOnInfo;
                    myTableLogonInfo.ConnectionInfo = iConnectionInfo;
                    mytable.ApplyLogOnInfo(myTableLogonInfo);
                }
                //reporteori.FileName = $"Conciliacion Bancaria {empresa} del " + fechaini.ToString("MMMM/yyyy") + " al " + fechafin.ToString("MMMM/yyyy");
                crvReporte.AllowedExportFormats = (int)(ExportFormatType.PortableDocFormat | ExportFormatType.Excel | ExportFormatType.ExcelWorkbook | ExportFormatType.Text);
                crvReporte.ReportSource = reporteori;
                //   reporteori.FileName = $"{FechaIni.ToString("MMM/yyyy")}-{FechaFin.ToString("MMM/yyyy")} LIBRO DIARIO 5.1";

                crvReporte.Zoom(1);
            }
        }

    }
}
