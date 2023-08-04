using CrystalDecisions.Shared;
using HpResergerUserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HPReserger
{
    public partial class frmReportedeFlujosCaja : FormGradient
    {
        public frmReportedeFlujosCaja()
        {
            InitializeComponent();
        }
        HPResergerCapaLogica.HPResergerCL CapaLogica = new HPResergerCapaLogica.HPResergerCL();
        HPResergerCapaDatos.HPResergerCD datos = new HPResergerCapaDatos.HPResergerCD();
        rptFlujodeCajaNormal reporte;
        public string NombreEmpresa;
        public int empresa;
        public DateTime fechaini, fechafin;
        private void crvReporte_ReportRefresh(object source, CrystalDecisions.Windows.Forms.ViewerEventArgs e)
        {
            e.Handled = true;
            frmReportedeFlujosCaja_Load(source, e);
        }

        private void frmReportedeFlujosCaja_Load(object sender, EventArgs e)
        {
            reporte = new rptFlujodeCajaNormal();
            //crvReporte.Refresh();           
            /* 
            @fechamin as datetime='20130101',
            @fechamax as datetime='20181231',
            @empresa as int=1002,
            @lenMes as int =100            */
            reporte.SetParameterValue("@fechamin", fechaini);
            reporte.SetParameterValue("@fechamax", fechafin);
            reporte.SetParameterValue("@NombreEmpresa", NombreEmpresa);
            reporte.SetParameterValue("@empresa", empresa);
            reporte.SetParameterValue("@lenmes", 100);
            reporte.SetDatabaseLogon(HPResergerCapaDatos.HPResergerCD.USERID, HPResergerCapaDatos.HPResergerCD.USERPASS);


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
