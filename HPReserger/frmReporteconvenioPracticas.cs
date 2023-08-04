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
    public partial class frmReporteconvenioPracticas : FormGradient
    {
        public frmReporteconvenioPracticas()
        {
            InitializeComponent();
        }
        public int contrato, tipo;
        public string numero;
        HPResergerCapaDatos.HPResergerCD datos = new HPResergerCapaDatos.HPResergerCD();

        private void crvreportepracticas_ReportRefresh(object source, CrystalDecisions.Windows.Forms.ViewerEventArgs e)
        {
            frmReporteconvenioPracticas_Load(crvreportepracticas, e);
            e.Handled = true;
        }
        private void frmReporteconvenioPracticas_Load(object sender, EventArgs e)
        {
            rptConvenioPracticasPreprofesional reporte = new rptConvenioPracticasPreprofesional();
            reporte.SetParameterValue(0, contrato);
            reporte.SetParameterValue(1, tipo);
            reporte.SetParameterValue(2, numero);
            reporte.SetDatabaseLogon(HPResergerCapaDatos.HPResergerCD.USERID, HPResergerCapaDatos.HPResergerCD.USERPASS);

            ConnectionInfo iConnectionInfo = new ConnectionInfo();
            // ' *****************************************************************************************************************
            // ' configuro el acceso a la base de datos
            //   ' *****************************************************************************************************************
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
                //Dim myTableLogonInfo As TableLogOnInfo = myTable.LogOnInfo
                myTableLogonInfo.ConnectionInfo = iConnectionInfo;
                //  myTableLogonInfo.ConnectionInfo = myConnectionInfo
                mytable.ApplyLogOnInfo(myTableLogonInfo);
                //myTable.ApplyLogOnInfo(myTableLogonInfo)
            }
            crvreportepracticas.AllowedExportFormats = (int)(CrystalDecisions.Shared.ExportFormatType.PortableDocFormat | CrystalDecisions.Shared.ExportFormatType.EditableRTF | CrystalDecisions.Shared.ExportFormatType.WordForWindows | CrystalDecisions.Shared.ExportFormatType.Excel);

            crvreportepracticas.ReportSource = reporte;
        }
    }
}
