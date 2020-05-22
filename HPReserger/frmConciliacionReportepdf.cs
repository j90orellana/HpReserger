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
    public partial class frmConciliacionReportepdf : FormGradient
    {
        public frmConciliacionReportepdf()
        {
            InitializeComponent();
        }
        HPResergerCapaLogica.HPResergerCL CapaLogica = new HPResergerCapaLogica.HPResergerCL();
        HPResergerCapaDatos.HPResergerCD datos = new HPResergerCapaDatos.HPResergerCD();
        rptConciliacionesReporte reporte;
        public string empresa, banco, nrocuenta;
        public DateTime fechaini, fechafin;
        private void crvReporte_ReportRefresh(object source, CrystalDecisions.Windows.Forms.ViewerEventArgs e)
        {
            e.Handled = true;
            frmConciliacionReportepdf_Load(source, e);
        }
        private void frmConciliacionReportepdf_Load(object sender, EventArgs e)
        {
            reporte = new rptConciliacionesReporte();
            reporte.SetParameterValue("@empresa", empresa);
            reporte.SetParameterValue("@banco", banco);
            reporte.SetParameterValue("@NroCuenta", nrocuenta);
            reporte.SetParameterValue("@FechaIni", fechaini);
            reporte.SetParameterValue("@FechaFin", fechafin);
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
            crvReporte.ReportSource = reporte;
        }
    }
}
