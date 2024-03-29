﻿using System;
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
    public partial class frmReporteAdendaNecesidad : FormGradient
    {
        public frmReporteAdendaNecesidad()
        {
            InitializeComponent();
        }
        public string tipo, numero, contrato;
        HPResergerCapaDatos.HPResergerCD datos = new HPResergerCapaDatos.HPResergerCD();
        private void frmReporteAdendaNecesidad_Load(object sender, EventArgs e)
        {
            rptAdendaNecesidad reporte = new rptAdendaNecesidad();
            crvadendaNecesidad.Refresh();
            reporte.SetParameterValue(0, contrato);
            reporte.SetParameterValue(1, tipo);
            reporte.SetParameterValue(2, numero);
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
            crvadendaNecesidad.ReportSource = reporte;
            crvadendaNecesidad.AllowedExportFormats = (int)(CrystalDecisions.Shared.ExportFormatType.PortableDocFormat | CrystalDecisions.Shared.ExportFormatType.EditableRTF | CrystalDecisions.Shared.ExportFormatType.WordForWindows | CrystalDecisions.Shared.ExportFormatType.Excel);
        }
    }
}
