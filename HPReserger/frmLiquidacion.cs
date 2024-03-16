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
using SISGEM;

namespace HPReserger
{
    public partial class frmLiquidacion : FormGradient
    {
        public int TipoDocumento { get; set; }
        public string NumeroDocumento { get; set; }
        public DateTime _FechaInicio;
        public decimal _Monto;
        public string _MotivoCese;
        HPResergerCapaDatos.HPResergerCD datos = new HPResergerCapaDatos.HPResergerCD();
        public frmLiquidacion()
        {
            InitializeComponent();
        }

        private void frmLiquidacion_Load(object sender, EventArgs e)
        {
            rptLiquidacion Reporte = new rptLiquidacion();
            Reporte.Refresh();            
            Reporte.SetParameterValue("@fecha", _FechaInicio);
            Reporte.SetParameterValue("@motivo", _MotivoCese);
            Reporte.SetParameterValue("@monto", _Monto);
            Reporte.SetParameterValue("@tipo", TipoDocumento);
            Reporte.SetParameterValue("@numero", NumeroDocumento);
            Reporte.SetParameterValue("@usuario", frmLogin.CodigoUsuario);
            // Reporte.SetDatabaseLogon(datos.USERID, datos.USERPASS,datos.DATASOURCE,datos.BASEDEDATOS);
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
            cvrLiquidacion.ReportSource = Reporte;
            cvrLiquidacion.AllowedExportFormats = (int)(CrystalDecisions.Shared.ExportFormatType.PortableDocFormat | CrystalDecisions.Shared.ExportFormatType.EditableRTF | CrystalDecisions.Shared.ExportFormatType.WordForWindows | CrystalDecisions.Shared.ExportFormatType.Excel);
        }
        private void cvrLiquidacion_ReportRefresh(object source, CrystalDecisions.Windows.Forms.ViewerEventArgs e)
        {
            e.Handled = true;
            frmLiquidacion_Load(cvrLiquidacion, e);
        }
    }
}
