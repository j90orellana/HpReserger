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
            reporte.SetParameterValue(0, empresa);
            reporte.SetParameterValue(1, tipo);
            reporte.SetParameterValue(2, numero);
            reporte.SetParameterValue(3, fecha);
            reporte.SetParameterValue(4, fechainicial);
            reporte.SetParameterValue(5, Fechafin);

            ConnectionInfo iConnectionInfo = new ConnectionInfo();
            // ' ***************************************************************
            // ' configuro el acceso a la base de datos
            // ' ***************************************************************
            //iConnectionInfo.DatabaseName = datos.BASEDEDATOS;
            iConnectionInfo.DatabaseName = HPResergerCapaDatos.HPResergerCD.BASEDEDATOS;
            iConnectionInfo.UserID = datos.USERID;
            iConnectionInfo.Password = datos.USERPASS;
            iConnectionInfo.ServerName = datos.DATASOURCE;

            iConnectionInfo.Type = ConnectionInfoType.CRQE;
            CrystalDecisions.CrystalReports.Engine.Tables myTables;

            myTables = reporte.Database.Tables;

            foreach (CrystalDecisions.CrystalReports.Engine.Table mytable in myTables)
            {
                TableLogOnInfo myTableLogonInfo = mytable.LogOnInfo;
                myTableLogonInfo.ConnectionInfo = iConnectionInfo;
                mytable.ApplyLogOnInfo(myTableLogonInfo);
            }
            //reporte.FileName = $"Conciliacion Bancaria {empresa} del " + fechaini.ToString("MMMM/yyyy") + " al " + fechafin.ToString("MMMM/yyyy");
            crvboletas.AllowedExportFormats = (int)(ExportFormatType.PortableDocFormat | ExportFormatType.Excel | ExportFormatType.ExcelWorkbook);
            crvboletas.ReportSource = reporte;            
            //foreach (Control x in crvboletas.Controls)
            //{
            //    if (x.GetType().Name.ToUpper() == "REPORTGROUPTREE")
            //    {
            //        ReportGroupTree xx = x as ReportGroupTree;
            //        //xx.BackColor = Color.Red;
            //        // xx.ForeColor = Color.Blue;
            //        //xx.BorderStyle = BorderStyle.Fixed3D;
            //        //xx.Font = new Font("Franklin Gothic Book", 12,FontStyle.Bold);
            //        //  xx.Paint += new PaintEventHandler(CrearPintura);
            //    }
            //}                 
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
