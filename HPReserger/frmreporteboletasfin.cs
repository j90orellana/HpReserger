using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrystalDecisions.Windows.Forms;
using CrystalDecisions.Shared;
using HpResergerUserControls;
using CrystalDecisions.CrystalReports.Engine;

namespace HPReserger
{
    public partial class frmreporteboletasfin : FormGradient
    {
        public frmreporteboletasfin()
        {
            InitializeComponent();
        }
        public int empresa;
        public int tipo;
        public string numero = "";
        public int fecha = 0;
        public DateTime fechainicial;
        public DateTime Fechafin;
        HPResergerCapaDatos.HPResergerCD datos = new HPResergerCapaDatos.HPResergerCD();
        private void frmreporteboletasfin_Load(object sender, EventArgs e)
        {
            rptboletas reporte = new rptboletas();
            //reporte.Refresh();
            reporte.SetParameterValue(0, empresa);
            reporte.SetParameterValue(1, tipo);
            reporte.SetParameterValue(2, numero);
            reporte.SetParameterValue(3, fecha);
            reporte.SetParameterValue(4, fechainicial);
            reporte.SetParameterValue(5, Fechafin);

            CambiarConectorBaseDatos(reporte);
            //ConnectionInfo iConnectionInfo = new ConnectionInfo();
            //// ' ***************************************'
            //// ' configuro el acceso a la base de datos '
            //// ' ***************************************'
            ////iConnectionInfo.DatabaseName = datos.BASEDEDATOS;
            //iConnectionInfo.DatabaseName = HPResergerCapaDatos.HPResergerCD.BASEDEDATOS;
            //iConnectionInfo.UserID = datos.USERID;
            //iConnectionInfo.Password = datos.USERPASS;
            //iConnectionInfo.ServerName = datos.DATASOURCE;
            //
            //iConnectionInfo.Type = ConnectionInfoType.CRQE;
            //CrystalDecisions.CrystalReports.Engine.Tables myTables;
            ////
            //myTables = reporte.Database.Tables;


            //TableLogOnInfo logonInfo = new TableLogOnInfo();
            //foreach (Table table in reporte.Database.Tables)
            //{
            //    logonInfo = table.LogOnInfo;
            //    logonInfo.ConnectionInfo.ServerName = datos.DATASOURCE;
            //    logonInfo.ConnectionInfo.DatabaseName = HPResergerCapaDatos.HPResergerCD.BASEDEDATOS; ;
            //    logonInfo.ConnectionInfo.UserID = datos.USERID;
            //    logonInfo.ConnectionInfo.Password = datos.USERPASS;
            //    table.ApplyLogOnInfo(logonInfo);
            //}
            //foreach (CrystalDecisions.CrystalReports.Engine.Table mytable in myTables)
            //{
            //    TableLogOnInfo myTableLogonInfo = mytable.LogOnInfo;
            //    //Dim myTableLogonInfo As TableLogOnInfo = myTable.LogOnInfo
            //    myTableLogonInfo.ConnectionInfo = iConnectionInfo;
            //    //  myTableLogonInfo.ConnectionInfo = myConnectionInfo
            //    mytable.ApplyLogOnInfo(myTableLogonInfo);
            //    //myTable.ApplyLogOnInfo(myTableLogonInfo)
            //}
            crvboletas.AllowedExportFormats = (int)(ExportFormatType.PortableDocFormat | ExportFormatType.Excel | ExportFormatType.ExcelWorkbook);
            //crvReporte.Zoom(1);
            crvboletas.ReportSource = reporte;
            //crvboletas.ToolPanelWidth = 115;
            crvboletas.Zoom(1);
        }

        private void CambiarConectorBaseDatos(rptboletas reporte)
        {
            TableLogOnInfo logOnInfo;
            foreach (CrystalDecisions.CrystalReports.Engine.Table t in reporte.Database.Tables)
            {
                t.TestConnectivity();
                logOnInfo = t.LogOnInfo;
                logOnInfo.ReportName = reporte.Name;
                logOnInfo.ConnectionInfo.ServerName = datos.DATASOURCE;
                logOnInfo.ConnectionInfo.DatabaseName = HPResergerCapaDatos.HPResergerCD.BASEDEDATOS;
                logOnInfo.ConnectionInfo.UserID = datos.USERID;
                logOnInfo.ConnectionInfo.Password = datos.USERPASS;
                logOnInfo.ConnectionInfo.Type = ConnectionInfoType.SQL;
                logOnInfo.TableName = t.Name;
                t.ApplyLogOnInfo(logOnInfo);

            }
        }
        private void CrearPintura(object sender, PaintEventArgs e)
        {
            msg(this.Name);
            ((ReportGroupTree)(sender)).BackColor = Color.Green;
            ((ReportGroupTree)(sender)).ForeColor = Color.Blue;
        }
        public void msg(string cadena)
        {
            //Message Box.Show(cadena, CompanyName ,MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void crvboletas_ReportRefresh(object source, CrystalDecisions.Windows.Forms.ViewerEventArgs e)
        {
            e.Handled = true;
            frmreporteboletasfin_Load(crvboletas, e);
        }

    }
}
