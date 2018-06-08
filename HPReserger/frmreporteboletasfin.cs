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

namespace HPReserger
{
    public partial class frmreporteboletasfin : Form
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
            //DataBoletas DataBoleta = new DataBoletas();
            //DataBoleta.

            rptboletas reporte = new rptboletas();
            reporte.Refresh();
            reporte.SetParameterValue(0, empresa);
            reporte.SetParameterValue(1, tipo);
            reporte.SetParameterValue(2, numero);
            reporte.SetParameterValue(3, fecha);
            reporte.SetParameterValue(4, fechainicial);
            reporte.SetParameterValue(5, Fechafin);

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

            //crvboletas.ReportSource = reporte;
            // Private Sub SetDBLogonForReport(ByVal myConnectionInfo As ConnectionInfo, ByVal myReportDocument As ReportDocument)            

            //reporte.SetParameterValue(6, frmLogin.CodigoUsuario);
            //reporte.SetDatabaseLogon(datos.USERID, datos.USERPASS);//, "hplaptop", "HPReserger");
            //reporte.SetDatabaseLogon(datos.USERID, datos.USERPASS,datos.DATASOURCE, "sige");
            //CrystalDecisions.Shared.PdfFormatOptions options = new CrystalDecisions.Shared.PdfFormatOptions();
            //options.CreateBookmarksFromGroupTree = true;
            crvboletas.ReportSource = reporte;
            foreach (Control x in crvboletas.Controls)
            {
                if (x.GetType().Name.ToUpper() == "REPORTGROUPTREE")
                {
                    ReportGroupTree xx = x as ReportGroupTree;
                    //xx.BackColor = Color.Red;
                    // xx.ForeColor = Color.Blue;
                    //xx.BorderStyle = BorderStyle.Fixed3D;
                    //xx.Font = new Font("Franklin Gothic Book", 12,FontStyle.Bold);
                    //  xx.Paint += new PaintEventHandler(CrearPintura);

                }
            }
            crvboletas.AllowedExportFormats = (int)(CrystalDecisions.Shared.ExportFormatType.PortableDocFormat | CrystalDecisions.Shared.ExportFormatType.EditableRTF | CrystalDecisions.Shared.ExportFormatType.WordForWindows | CrystalDecisions.Shared.ExportFormatType.Excel);
            //string cadena = "";
            //foreach (Control ctl in crvboletas.Controls)
            //{
            //    if (ctl is ToolStrip)
            //    {
            //        ToolStrip ts = (ToolStrip)ctl;
            //        cadena = "";
            //        foreach (ToolStripItem clt in ts.Items)
            //        {
            //            if (clt.ToolTipText.ToUpper() == "EXPORTAR INFORME")
            //                cadena += clt.ToolTipText;
            //            ToolStripButton tsb = new ToolStripButton();
            //            tsb.Size = clt.Size;
            //            tsb.Padding = clt.Padding;
            //            tsb.Margin = clt.Margin;
            //            tsb.TextImageRelation = clt.TextImageRelation;
            //            tsb.Text = clt.Text;
            //            tsb.ToolTipText = clt.ToolTipText;
            //            tsb.ImageScaling = clt.ImageScaling;
            //            tsb.ImageAlign = clt.ImageAlign;
            //            tsb.ImageIndex = clt.ImageIndex;
            //            tsb.Click += new EventHandler(CLicktime);
            //            ts.Items.Insert(3, tsb);
            //            break;
            //        }
            //    }
            //}
            //msg(cadena);            
        }

        private void CrearPintura(object sender, PaintEventArgs e)
        {
            msg(this.Name);
            ((ReportGroupTree)(sender)).BackColor = Color.Green;
            ((ReportGroupTree)(sender)).ForeColor = Color.Blue;
        }
        public void msg(string cadena)
        {
            MessageBox.Show(cadena, CompanyName ,MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void crvboletas_ReportRefresh(object source, CrystalDecisions.Windows.Forms.ViewerEventArgs e)
        {
            e.Handled = true;
            frmreporteboletasfin_Load(crvboletas, e);
        }

    }
}
