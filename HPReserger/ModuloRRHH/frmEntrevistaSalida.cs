using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using SISGEM;

namespace HPReserger
{
    public partial class frmEntrevistaSalida : Form
    {
        public int TipoDocumento { get; set; }
        public string NumeroDocumento { get; set; }

        public frmEntrevistaSalida()
        {
            InitializeComponent();
        }
        HPResergerCapaDatos.HPResergerCD datos = new HPResergerCapaDatos.HPResergerCD();
        private void frmEntrevistaSalida_Load(object sender, EventArgs e)
        {
            rptEntrevistaSalida Reporte = new rptEntrevistaSalida();
            Reporte.Refresh();
            Reporte.SetParameterValue("@Tipo_ID_Emp", TipoDocumento);
            Reporte.SetParameterValue("@Nro_ID_Emp", NumeroDocumento);
            //  Reporte.SetDatabaseLogon(datos.USERID, datos.USERPASS, datos.DATASOURCE, datos.BASEDEDATOS);
            Reporte.SetDatabaseLogon("jorellana", "456");

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

            myTables = Reporte.Database.Tables;

            foreach (CrystalDecisions.CrystalReports.Engine.Table mytable in myTables)
            {
                TableLogOnInfo myTableLogonInfo = mytable.LogOnInfo;
                myTableLogonInfo.ConnectionInfo = iConnectionInfo;
                mytable.ApplyLogOnInfo(myTableLogonInfo);
            }
            crvEntrevistaSalida.ReportSource = Reporte;
            crvEntrevistaSalida.AllowedExportFormats = (int)(CrystalDecisions.Shared.ExportFormatType.PortableDocFormat | CrystalDecisions.Shared.ExportFormatType.EditableRTF | CrystalDecisions.Shared.ExportFormatType.WordForWindows | CrystalDecisions.Shared.ExportFormatType.Excel);
        }

        private void crvEntrevistaSalida_ReportRefresh(object source, CrystalDecisions.Windows.Forms.ViewerEventArgs e)
        {
            e.Handled = true;
            frmEntrevistaSalida_Load(crvEntrevistaSalida, e);
        }
    }
}
