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
using HpResergerUserControls;
using SISGEM;

namespace HPReserger
{
    public partial class frmReporteEstadoPerdidas : FormGradient
    {
        public frmReporteEstadoPerdidas()
        {
            InitializeComponent();
        }
        HPResergerCapaDatos.HPResergerCD datos = new HPResergerCapaDatos.HPResergerCD();
        public void msg(string cadena) { HPResergerFunciones.frmInformativo.MostrarDialogError(cadena); }
        public void msgOK(string cadena) { HPResergerFunciones.frmInformativo.MostrarDialog(cadena); }
        public int empresa;
        public DateTime año;
        public string NombreEmpresa;
        private void frmReporteEstadoPerdidas_Load(object sender, EventArgs e)
        {
            rtpGanaciasPerdidas Reporte = new rtpGanaciasPerdidas();
            Reporte.SetDatabaseLogon(HPResergerCapaDatos.HPResergerCD.USERID, HPResergerCapaDatos.HPResergerCD.USERPASS);

            Reporte.SetParameterValue(0, año);
            Reporte.SetParameterValue(1, empresa); 
            Reporte.SetParameterValue(2, NombreEmpresa); 

             ConnectionInfo iConnectionInfo = new ConnectionInfo();
            // ' ***************************************'
            // ' configuro el acceso a la base de datos '
            // ' ***************************************'
            //iConnectionInfo.DatabaseName = datos.BASEDEDATOS;
            iConnectionInfo.DatabaseName = HPResergerCapaDatos.HPResergerCD.BASEDEDATOS;
            iConnectionInfo.UserID = HPResergerCapaDatos.HPResergerCD.USERID;
            iConnectionInfo.Password = HPResergerCapaDatos.HPResergerCD.USERPASS;
            iConnectionInfo.ServerName = HPResergerCapaDatos.HPResergerCD.DATASOURCE;

            iConnectionInfo.Type = ConnectionInfoType.SQL;
            CrystalDecisions.CrystalReports.Engine.Tables myTables;

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
                  
            crvreporte.AllowedExportFormats = (int)(ExportFormatType.PortableDocFormat | ExportFormatType.Excel | ExportFormatType.ExcelWorkbook);
            crvreporte.ReportSource = Reporte;
        }

        private void crvreporte_ReportRefresh(object source, CrystalDecisions.Windows.Forms.ViewerEventArgs e)
        {
            e.Handled = true;
            frmReporteEstadoPerdidas_Load(crvreporte, e);
        }
    }
}
