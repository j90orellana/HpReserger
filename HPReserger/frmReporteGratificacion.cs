﻿using CrystalDecisions.Shared;
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
    public partial class frmReporteGratificacion : Form
    {
        public frmReporteGratificacion()
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
        private void frmReporteGratificacion_Load(object sender, EventArgs e)
        {
            rptPagoGratificacion reporte = new rptPagoGratificacion();
            reporte.Refresh();
            reporte.SetParameterValue(0, empresa);
            reporte.SetParameterValue(1, tipo);
            reporte.SetParameterValue(2, numero);
            reporte.SetParameterValue(3, fecha);
            reporte.SetParameterValue(4, fechainicial);
            reporte.SetParameterValue(5, Fechafin);
            reporte.SetDatabaseLogon(datos.USERID, datos.USERPASS);

            ConnectionInfo iConnectionInfo = new ConnectionInfo();
            // ' *****************************************************************************************************************
            // ' configuro el acceso a la base de datos
            //   ' *****************************************************************************************************************
            //iConnectionInfo.DatabaseName = datos.BASEDEDATOS;
            iConnectionInfo.DatabaseName = HPResergerCapaDatos.HPResergerCD.BASEDEDATOS;
            iConnectionInfo.UserID = datos.USERID;
            iConnectionInfo.Password = datos.USERPASS;
            iConnectionInfo.ServerName = datos.DATASOURCE;

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

            crvReporte.ReportSource = reporte;
            crvReporte.AllowedExportFormats = (int)(CrystalDecisions.Shared.ExportFormatType.PortableDocFormat | CrystalDecisions.Shared.ExportFormatType.EditableRTF | CrystalDecisions.Shared.ExportFormatType.WordForWindows | CrystalDecisions.Shared.ExportFormatType.Excel);
        }
        public void msg(string cadena)
        {
            MessageBox.Show(cadena, CompanyName ,MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void crvReporte_ReportRefresh(object source, CrystalDecisions.Windows.Forms.ViewerEventArgs e)
        {
            e.Handled = true;
            frmReporteGratificacion_Load(crvReporte, e);
        }
    }
}
