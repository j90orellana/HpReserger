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
                msg($"Exportado Con Exito en {saveFileDialog1.FileName}");
            }
        }
        public void msg(string cadena)
        {
            MessageBox.Show(cadena, CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        rptFlujodeCajaNormal reporte;
        private void crvReporte_ReportRefresh(object source, CrystalDecisions.Windows.Forms.ViewerEventArgs e)
        {
            e.Handled = true;
            btngenerar_Click(source, e);
        }

        private void btnpdf_Click(object sender, EventArgs e)
        {
            frmReportedeFlujosCaja frmcajita = new frmReportedeFlujosCaja();
            frmcajita.NombreEmpresa = cboempresa.Text;
            frmcajita.empresa = (int)cboempresa.SelectedValue;
            if (comboMesAño1.GetFechaPRimerDia() > comboMesAño2.GetFechaPRimerDia())
            {
                frmcajita.fechafin = comboMesAño1.UltimoDiaDelMes();
                frmcajita.fechaini = comboMesAño2.GetFechaPRimerDia();
            }
            else
            {
                frmcajita.fechafin = comboMesAño2.UltimoDiaDelMes();
                frmcajita.fechaini = comboMesAño1.GetFechaPRimerDia();
            }
            frmcajita.WindowState = FormWindowState.Maximized;
            frmcajita.Show();
        }

        private void btnaceptar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btngenerar_Click(object sender, EventArgs e)
        {
            reporte = new rptFlujodeCajaNormal();
            //crvReporte.Refresh();
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
            btnpdf.Enabled = true;


            //carga de datetable
            DataTable Tablita = new DataTable();
            Tablita = CapaLogica.FLujodeCaja(fechaini, fechafin, cboempresa.Text, (int)cboempresa.SelectedValue, 100);

            DataTable Tabla = new DataTable();
            Tabla.Columns.Add("Fecha");
            Tabla.Columns.Add("cuenta");
            Tabla.Columns.Add("ruc");
            Tabla.Columns.Add("numruc");
            Tabla.Columns.Add("razonsocial");
            Tabla.Columns.Add("nombreDoc");
            Tabla.Columns.Add("numdoc");
            Tabla.Columns.Add("FechaAsiento");
            Tabla.Columns.Add("glosas");

            Tabla.Columns.Add("movimientos", typeof(decimal));

            foreach (DataRow item in Tablita.Rows)
            {
                DataRow filita = Tabla.NewRow();
                filita["fecha"] = $"{ item["mesletras"].ToString() } - { item["año"].ToString() }";
                string ruc;
                if (item["Desc_Tipo_ID"].ToString() == "") ruc = "";
                else
                    ruc = $"{item["Desc_Tipo_ID"].ToString()}" ?? "";
                string numruc;
                if (item["Num_Doc"].ToString() == "") numruc = "";
                else numruc = $"{item["Num_Doc"].ToString()}" ?? "";
                string glosas;
                if (item["glosa"].ToString() == "") glosas = "";
                else glosas = $"{item["glosa"].ToString()}" ?? "";
                filita["cuenta"] = $"{item["Cuenta_Contable"].ToString()}";
                filita["ruc"] = $"{ruc}";
                filita["numruc"] = numruc;
                filita["razonsocial"] = item["razon_social"].ToString();
                filita["nombredoc"] = item["nombredoc"].ToString();
                string resul = "";
                resul = $"{ item["Cod_Comprobante"].ToString()}-{item["Num_Comprobante"].ToString()}";
                if (resul == "-")
                    resul = "";
                else
                    resul = $"{ item["Cod_Comprobante"].ToString()}-{item["Num_Comprobante"].ToString()}";
                if (item["Cod_Comprobante"].ToString() == "")
                    resul = $"{item["Num_Comprobante"].ToString()}";
                filita["numdoc"] = resul;
                filita["glosas"] = glosas;
                filita["FechaAsiento"] = DateTime.Parse(item["fechaasiento"].ToString()).ToShortDateString();

                decimal total = 0;
                if (item["Cuenta_Contable"].ToString().Substring(0, 2) == "10")
                    total = decimal.Parse(item["deber"].ToString()) - decimal.Parse(item["haber"].ToString());
                else total = decimal.Parse(item["haber"].ToString()) - decimal.Parse(item["deber"].ToString());
                filita["Movimientos"] = total;
                Tabla.Rows.Add(filita);
            }
            decimal sumatoria = 0;
            if (Tabla.Rows.Count > 0)
            {
                foreach (DataRow item in Tabla.Rows)
                {
                    sumatoria += decimal.Parse(item["movimientos"].ToString());
                }
                DataRow filita = Tabla.NewRow();
                filita["razonsocial"] = "SALDO FINAL";
                filita["movimientos"] = sumatoria;
                Tabla.Rows.Add(filita);
                dtgconten1.DataSource = Tabla;
                dtgconten1.Rows[dtgconten1.Rows.Count - 1].DefaultCellStyle.BackColor = Color.FromArgb(149, 179, 215);
                dtgconten1.Rows[dtgconten1.Rows.Count - 1].DefaultCellStyle.ForeColor = Color.White;
                dtgconten1.Rows[dtgconten1.Rows.Count - 1].DefaultCellStyle.Font = new Font("Segoe UI", 9F, FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            }
            else msg("No Hay Datos que Mostrar");
        }
    }
}
