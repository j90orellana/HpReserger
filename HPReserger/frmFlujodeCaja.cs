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
    public partial class frmFlujodeCaja : FormGradient
    {
        public frmFlujodeCaja()
        {
            InitializeComponent();
        }
        HPResergerCapaLogica.HPResergerCL CapaLogica = new HPResergerCapaLogica.HPResergerCL();
        HPResergerCapaDatos.HPResergerCD datos = new HPResergerCapaDatos.HPResergerCD();
        private void frmFlujodeCaja_Load(object sender, EventArgs e)
        {
            CargarEmpresa();
            crvReporte.AllowedExportFormats = (int)(CrystalDecisions.Shared.ExportFormatType.PortableDocFormat | CrystalDecisions.Shared.ExportFormatType.EditableRTF | CrystalDecisions.Shared.ExportFormatType.WordForWindows | CrystalDecisions.Shared.ExportFormatType.Excel);
        }
        public void CargarEmpresa()
        {
            string empresa = cboempresa.Text;
            cboempresa.DisplayMember = "descripcion";
            cboempresa.ValueMember = "codigo";
            cboempresa.DataSource = CapaLogica.getCargoTipoContratacion("Id_Empresa", "Empresa", "TBL_Empresa");
            cboempresa.Text = empresa;
        }
        private void cboempresa_Click(object sender, EventArgs e)
        {
            CargarEmpresa();
        }
        DateTime fechaini, fechafin;

        private void btnexcel_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if (saveFileDialog1.FileName.Length > 0)
                {
                    try
                    {
                        reporte.ExportToDisk(ExportFormatType.Excel, saveFileDialog1.FileName);
                    }
                    catch (IOException) { msg("Error: El Archivo esta Abierto o en Uso"); }                    
                }
            }
            msg($"Exportado Con Exito en {saveFileDialog1.FileName}");
        }
        public void msg(string cadena)
        {
            MessageBox.Show(cadena, "HpReserger", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        rptFlujodeCaja reporte;
        private void btngenerar_Click(object sender, EventArgs e)
        {
            reporte = new rptFlujodeCaja();
            crvReporte.Refresh();
            if (comboMesAño1.GetFechaPRimerDia() > comboMesAño2.GetFechaPRimerDia())
            {
                fechafin = comboMesAño1.UltimoDiaDelMes();
                fechaini = comboMesAño2.GetFechaPRimerDia();
            }
            else
            {
                fechafin = comboMesAño2.UltimoDiaDelMes();
                fechaini = comboMesAño1.GetFechaPRimerDia();
            }
            /* 
            @fechamin as datetime='20130101',
            @fechamax as datetime='20181231',
            @empresa as int=1002,
            @lenMes as int =100            */
            reporte.SetParameterValue("@fechamin", fechaini);
            reporte.SetParameterValue("@fechamax", fechafin);
            reporte.SetParameterValue("@NombreEmpresa", cboempresa.Text);
            reporte.SetParameterValue("@empresa", (int)cboempresa.SelectedValue);
            reporte.SetParameterValue("@lenmes", 100);
            reporte.SetDatabaseLogon(datos.USERID, datos.USERPASS);

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

            myTables = reporte.Database.Tables;

            foreach (CrystalDecisions.CrystalReports.Engine.Table mytable in myTables)
            {
                TableLogOnInfo myTableLogonInfo = mytable.LogOnInfo;
                myTableLogonInfo.ConnectionInfo = iConnectionInfo;
                mytable.ApplyLogOnInfo(myTableLogonInfo);
            }
            crvReporte.ReportSource = reporte;
            btnexcel.Enabled = true;
        }
    }
}
