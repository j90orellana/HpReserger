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
    public partial class frmReporteMayor6_1 : FormGradient
    {
        public frmReporteMayor6_1()
        {
            InitializeComponent();
        }
        HPResergerCapaLogica.HPResergerCL CapaLogica = new HPResergerCapaLogica.HPResergerCL();
        HPResergerCapaDatos.HPResergerCD datos = new HPResergerCapaDatos.HPResergerCD();
        rptLibroMayor6_1 reporte;
        rptLibroMayor6_1_Ori Reporteori;
        public DateTime FechaIni, FechaFin;
        public string Cuentas, glosas, nrodoc, ruc, empresa, razonsocial;

        public bool Matricial { get; internal set; }

        private void frmReporteMayor6_1_Load(object sender, EventArgs e)
        {
            if (Matricial)
            {
                reporte = new rptLibroMayor6_1();
                reporte.SetParameterValue("@Fechaini", FechaIni);
                reporte.SetParameterValue("@FechaFin", FechaFin);
                reporte.SetParameterValue("@cuentas", Cuentas);
                reporte.SetParameterValue("@Glosas", glosas);
                reporte.SetParameterValue("@NroDoc", nrodoc);
                reporte.SetParameterValue("@Ruc", ruc);
                reporte.SetParameterValue("@Empresa", empresa);
                reporte.SetParameterValue("@RazonSocial", razonsocial);

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
                crvReporte.AllowedExportFormats = (int)(ExportFormatType.PortableDocFormat | ExportFormatType.Excel | ExportFormatType.ExcelWorkbook);
                crvReporte.ReportSource = reporte;
                //  reporte.FileName = $"{FechaIni.ToString("MMM/yyyy")}-{FechaFin.ToString("MMM/yyyy")} LIBRO MAYOR 6.1";
                crvReporte.Zoom(1);
            }
            else
            {
                if (Matricial)
                {
                    Reporteori = new rptLibroMayor6_1_Ori();
                    Reporteori.SetParameterValue("@Fechaini", FechaIni);
                    Reporteori.SetParameterValue("@FechaFin", FechaFin);
                    Reporteori.SetParameterValue("@cuentas", Cuentas);
                    Reporteori.SetParameterValue("@Glosas", glosas);
                    Reporteori.SetParameterValue("@NroDoc", nrodoc);
                    Reporteori.SetParameterValue("@Ruc", ruc);
                    Reporteori.SetParameterValue("@Empresa", empresa);
                    Reporteori.SetParameterValue("@RazonSocial", razonsocial);

                    Reporteori.SetDatabaseLogon(datos.USERID, datos.USERPASS);
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

                    myTables = Reporteori.Database.Tables;

                    foreach (CrystalDecisions.CrystalReports.Engine.Table mytable in myTables)
                    {
                        TableLogOnInfo myTableLogonInfo = mytable.LogOnInfo;
                        myTableLogonInfo.ConnectionInfo = iConnectionInfo;
                        mytable.ApplyLogOnInfo(myTableLogonInfo);
                    }
                    //Reporteori.FileName = $"Conciliacion Bancaria {empresa} del " + fechaini.ToString("MMMM/yyyy") + " al " + fechafin.ToString("MMMM/yyyy");
                    crvReporte.AllowedExportFormats = (int)(ExportFormatType.PortableDocFormat | ExportFormatType.Excel | ExportFormatType.ExcelWorkbook);
                    crvReporte.ReportSource = Reporteori;
                    //  Reporteori.FileName = $"{FechaIni.ToString("MMM/yyyy")}-{FechaFin.ToString("MMM/yyyy")} LIBRO MAYOR 6.1";
                    crvReporte.Zoom(1);
                }
            }
        }
        private void crvReporte_ReportRefresh(object source, CrystalDecisions.Windows.Forms.ViewerEventArgs e)
        {
            e.Handled = true;
            frmReporteMayor6_1_Load(source, e);
        }
    }
}
