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
using HpResergerUserControls;

namespace HPReserger
{
    public partial class frmBoletaVacaciones : FormGradient
    {
        public int TipoDocumento { get; set; }
        public string NumeroDocumento { get; set; }
        public int Registro { get; set; }
        public int tipo { get; set; }
        public frmBoletaVacaciones()
        {
            InitializeComponent();
        }
        HPResergerCapaDatos.HPResergerCD datos = new HPResergerCapaDatos.HPResergerCD();
        private void frmBoletaVacaciones_Load(object sender, EventArgs e)
        {
            rptVacaciones Reporte = new rptVacaciones();
            Reporte.Refresh();
            Reporte.SetParameterValue("@Tipo_ID_Emp", TipoDocumento);
            Reporte.SetParameterValue("@Nro_ID_Emp", NumeroDocumento);
            Reporte.SetParameterValue("@Registro", Registro);
            Reporte.SetParameterValue("@tipo", tipo);
            // Reporte.SetDatabaseLogon(datos.USERID, datos.USERPASS, datos.DATASOURCE, datos.BASEDEDATOS);
            Reporte.SetDatabaseLogon(datos.USERID, datos.USERPASS);

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

            myTables = Reporte.Database.Tables;

            foreach (CrystalDecisions.CrystalReports.Engine.Table mytable in myTables)
            {
                TableLogOnInfo myTableLogonInfo = mytable.LogOnInfo;
                myTableLogonInfo.ConnectionInfo = iConnectionInfo;
                mytable.ApplyLogOnInfo(myTableLogonInfo);
            }
            crvBoletaVacaciones.ReportSource = Reporte;
            crvBoletaVacaciones.AllowedExportFormats = (int)(CrystalDecisions.Shared.ExportFormatType.PortableDocFormat | CrystalDecisions.Shared.ExportFormatType.EditableRTF | CrystalDecisions.Shared.ExportFormatType.WordForWindows | CrystalDecisions.Shared.ExportFormatType.Excel);
        }
        private void crvBoletaVacaciones_ReportRefresh(object source, CrystalDecisions.Windows.Forms.ViewerEventArgs e)
        {
            e.Handled = true;
            frmBoletaVacaciones_Load(crvBoletaVacaciones, e);
        }
    }
}