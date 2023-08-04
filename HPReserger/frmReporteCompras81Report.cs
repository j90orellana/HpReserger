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
    public partial class frmReporteCompras81Report : FormGradient
    {
        public frmReporteCompras81Report(int _fkempresa,string _ruc, string _nombreempresa,DateTime _FechaPeriodo)
        {
            InitializeComponent();
            fkempresa = _fkempresa;
            Ruc = _ruc;
            NombreEmpresa = _nombreempresa;
            FechaPeriodo = _FechaPeriodo;
        }
        HPResergerCapaLogica.HPResergerCL CapaLogica = new HPResergerCapaLogica.HPResergerCL();
        private void frmReporteCompras81Report_Load(object sender, EventArgs e)
        {       
            GenerarReporte();         
        }
        private void crpreporte_ReportRefresh(object source, CrystalDecisions.Windows.Forms.ViewerEventArgs e)
        { e.Handled = true; GenerarReporte(); }
        DateTime FechaPeriodo; string NombreEmpresa = "";
        string Ruc = "";
        int fkempresa = 0;
        HPResergerCapaDatos.HPResergerCD datos = new HPResergerCapaDatos.HPResergerCD();
        public void GenerarReporte()
        {
            rptFormato81Compras Reporte = new rptFormato81Compras();
            Reporte.SetDatabaseLogon(HPResergerCapaDatos.HPResergerCD.USERID, HPResergerCapaDatos.HPResergerCD.USERPASS);

            Reporte.SetParameterValue("@Empresa", fkempresa);
            Reporte.SetParameterValue("@periodoAño", FechaPeriodo.Year);
            Reporte.SetParameterValue("@PeriodoMes", FechaPeriodo.Month);
            Reporte.SetParameterValue("@RucEmpresa", Ruc);
            Reporte.SetParameterValue("@NombreEmpresa", NombreEmpresa);
            ConnectionInfo iConnectionInfo = new ConnectionInfo();
            // ' ***************************************'
            // ' configuro el acceso a la base de datos '
            // ' ***************************************'
            //iConnectionInfo.DatabaseName = datos.BASEDEDATOS;
            iConnectionInfo.DatabaseName = HPResergerCapaDatos.HPResergerCD.BASEDEDATOS;
            iConnectionInfo.UserID = HPResergerCapaDatos.HPResergerCD.USERID;
            iConnectionInfo.Password = HPResergerCapaDatos.HPResergerCD.USERPASS;
            iConnectionInfo.ServerName = HPResergerCapaDatos.HPResergerCD.DATASOURCE;
            iConnectionInfo.Type = ConnectionInfoType.OLAP;
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

            crvreporte.BackColor = Color.Transparent;
            crvreporte.Zoom(150);
        }
    }
}
