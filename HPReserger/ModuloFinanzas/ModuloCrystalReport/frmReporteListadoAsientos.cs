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
    public partial class frmReporteListadoAsientos : FormGradient
    {
        public frmReporteListadoAsientos()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
        }
        public FormWindowState StateInicialForm;
        public frmReporteListadoAsientos(int _empresa, DateTime _Fechaini, DateTime _Fechafin, string _cuo, string _cuenta, string _glosa, string _suboperacion, int _Estado)
        {
            InitializeComponent();
            empresa = _empresa;
            Fechaini = _Fechaini;
            Fechafin = _Fechafin;
            Cuo = _cuo;
            Cuenta = _cuenta;
            Glosa = _glosa;
            SubOperacion = _suboperacion;
            Estado = _Estado;
            this.WindowState = FormWindowState.Maximized;
        }
        HPResergerCapaDatos.HPResergerCD datos = new HPResergerCapaDatos.HPResergerCD();
        public int empresa = 1;
        public DateTime Fechaini;
        public DateTime Fechafin;
        public string Cuo = "";
        public string Cuenta = "";
        public string Glosa = "";
        public string SubOperacion = "";
        public int Estado = 1;
        private void frmReporteListadoAsientos_Load(object sender, EventArgs e)
        {
            ModuloFinanzas.ModuloCrystalReport.rptListadodeAsientos Reporte = new ModuloFinanzas.ModuloCrystalReport.rptListadodeAsientos();
            Reporte.SetDatabaseLogon(datos.USERID, datos.USERPASS);
            Reporte.SetParameterValue(0, empresa);
            Reporte.SetParameterValue(1, Fechaini);
            Reporte.SetParameterValue(2, Fechafin);
            Reporte.SetParameterValue(3, Cuo);
            Reporte.SetParameterValue(4, Cuenta);
            Reporte.SetParameterValue(5, Glosa);
            Reporte.SetParameterValue(6, SubOperacion);
            Reporte.SetParameterValue(7, Estado);
            //
            ConnectionInfo iConnectionInfo = new ConnectionInfo();
            // ' ***************************************'
            // ' configuro el acceso a la base de datos '
            // ' ***************************************'
            //iConnectionInfo.DatabaseName = datos.BASEDEDATOS;
            iConnectionInfo.DatabaseName = HPResergerCapaDatos.HPResergerCD.BASEDEDATOS;
            iConnectionInfo.UserID = datos.USERID;
            iConnectionInfo.Password = datos.USERPASS;
            iConnectionInfo.ServerName = datos.DATASOURCE;
            //
            iConnectionInfo.Type = ConnectionInfoType.SQL;
            CrystalDecisions.CrystalReports.Engine.Tables myTables;
            //
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
            crvReporte.AllowedExportFormats = (int)(ExportFormatType.PortableDocFormat | ExportFormatType.Excel | ExportFormatType.ExcelWorkbook);
            //crvReporte.Zoom(1);
            crvReporte.ReportSource = Reporte;
            crvReporte.ToolPanelWidth = 115;
            crvReporte.Zoom(1);
        }
        private void crystalReportViewer2_ReportRefresh(object source, CrystalDecisions.Windows.Forms.ViewerEventArgs e)
        {
            e.Handled = true;
            frmReporteListadoAsientos_Load(crvReporte, e);
        }
        private void frmReporteListadoAsientos_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.WindowState = StateInicialForm;
        }
    }
}
