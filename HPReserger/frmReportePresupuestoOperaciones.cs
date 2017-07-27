using Microsoft.Office.Interop.Excel;
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
    public partial class frmReportePresupuestoOperaciones : Form
    {
        public frmReportePresupuestoOperaciones()
        {
            InitializeComponent();
        }
        HPResergerCapaLogica.HPResergerCL CLPresuOpera = new HPResergerCapaLogica.HPResergerCL();
        public int cabecera; public int empresa;
        public void MSG(string cadena)
        {
            MessageBox.Show(cadena, "HpReserger", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void frmReportePresupuestoOperaciones_Load(object sender, EventArgs e)
        {
            cboempresa.ValueMember = "codigo";
            cboempresa.DisplayMember = "descripcion";
            cboempresa.DataSource = CLPresuOpera.getCargoTipoContratacion("Id_Empresa", "Empresa", "TBL_Empresa");
            if (cboempresa.Items.Count < 1)
                MSG("No hay Empresas");
        }

        private void cboproyecto_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboproyecto.Items.Count > 0)
                btnGenerar.Enabled = true;
            else btnGenerar.Enabled = false;
        }

        private void cboempresa_SelectedIndexChanged(object sender, EventArgs e)
        {
            CLPresuOpera.ListarPresupuestosCabecera();
            if (cboempresa.SelectedIndex > -1)
            {
                cboproyecto.ValueMember = "id_proyecto";
                cboproyecto.DisplayMember = "proyecto";
                cboproyecto.DataSource = CLPresuOpera.ListarProyectosEmpresa(cboempresa.SelectedValue.ToString());
                if (cboproyecto.Items.Count < 1)
                    MSG("No hay Proyectos");
            }
        }
        public void contando(DataGridView grilla)
        {
            lblmsg.Text = "Total de Registros " + grilla.RowCount;
        }
        decimal IMPORTES, OPERACION, DIFERENCIAS;
        public void Sumatoria()
        {
            IMPORTES = OPERACION = DIFERENCIAS = 0;
            if (dtgconten.RowCount > 0)
            {
                for (int i = 0; i < dtgconten.RowCount; i++)
                {
                    IMPORTES += decimal.Parse(dtgconten["importe", i].Value.ToString());
                    OPERACION += decimal.Parse(dtgconten["Operaciones", i].Value.ToString());
                    DIFERENCIAS += decimal.Parse(dtgconten["diferencia", i].Value.ToString());
                }
            }
            txtimporte.Text = IMPORTES.ToString("n2");
            txtoperaciones.Text = OPERACION.ToString("n2");
            txtdiferencia.Text = DIFERENCIAS.ToString("n2");

            if (IMPORTES > OPERACION)
            {
                txtimporte.ForeColor = Color.Blue;
                txtoperaciones.ForeColor = Color.Blue;
                txtdiferencia.ForeColor = Color.Blue;
            }
            else if (IMPORTES < OPERACION)
            {
                txtimporte.ForeColor = Color.Red;
                txtoperaciones.ForeColor = Color.Blue;
                txtdiferencia.ForeColor = Color.Blue;
            }
            else
            {
                txtimporte.ForeColor = Color.Black;
                txtoperaciones.ForeColor = Color.Black;
                txtdiferencia.ForeColor = Color.Black;
            }

        }
        public void REvisarGrillas()
        {
            if (dtgconten.RowCount > 0)
            {
                for (int i = 0; i < dtgconten.RowCount; i++)
                {
                    //contador++;
                    if (decimal.Parse(dtgconten["importe", i].Value.ToString()) > decimal.Parse(dtgconten["Operaciones", i].Value.ToString()))
                    {
                        dtgconten["diferencia", i].Value = decimal.Parse(dtgconten["importe", i].Value.ToString()) - decimal.Parse(dtgconten["Operaciones", i].Value.ToString());
                        //  dtgconten["importe", i].Style.ForeColor = Color.Blue;
                        //  dtgconten["operaciones", i].Style.ForeColor = Color.Red;
                        // dtgconten["diferencia", i].Style.ForeColor = Color.Red;
                    }
                    else if (decimal.Parse(dtgconten["importe", i].Value.ToString()) < decimal.Parse(dtgconten["Operaciones", i].Value.ToString()))
                    {
                        dtgconten["diferencia", i].Value = decimal.Parse(dtgconten["importe", i].Value.ToString()) - decimal.Parse(dtgconten["Operaciones", i].Value.ToString());
                        //  dtgconten["importe", i].Style.ForeColor = Color.Red;
                        // dtgconten["operaciones", i].Style.ForeColor = Color.Blue;
                        // dtgconten["diferencia", i].Style.ForeColor = Color.Red;
                    }
                    else
                    {
                        dtgconten["diferencia", i].Value = "0.00";
                        //  dtgconten["importe", i].Style.ForeColor = Color.Black;
                        //  dtgconten["operaciones", i].Style.ForeColor = Color.Black;
                        // dtgconten["diferencia", i].Style.ForeColor = Color.Black;
                    }
                }
            }
            // MSG("contado " + contador);
        }
        private void ExportarDataGridViewExcel(DataGridView grd)
        {
            //   SaveFileDialog fichero = new SaveFileDialog();
            // //  fichero.Filter = "Excel (*.xls)|*.xls";
            //   if (fichero.ShowDialog() == DialogResult.OK)
            //   {
            int nume, numer;
            Microsoft.Office.Interop.Excel.Application aplicacion;
            Microsoft.Office.Interop.Excel.Workbook libros_trabajo;
            Microsoft.Office.Interop.Excel.Worksheet hoja_trabajo;
            aplicacion = new Microsoft.Office.Interop.Excel.Application();
            aplicacion.Visible = true;
            libros_trabajo = aplicacion.Workbooks.Add();
            hoja_trabajo = (Microsoft.Office.Interop.Excel.Worksheet)libros_trabajo.Worksheets.get_Item(1);
            hoja_trabajo.Name = "Presupuesto Operaciones";
            //Recorremos el DataGridView rellenando la hoja de trabajo
            for (int i = 0; i < grd.Rows.Count - 1; i++)
            {
                nume = 0;
                for (int j = 0; j < grd.Columns.Count; j++)
                {
                    if (j != 0 && j != 4 && j != 6 && j != 10)
                    {
                        hoja_trabajo.Cells[i + 2, nume + 1] = grd.Rows[i].Cells[j].Value.ToString();
                        nume++;
                    }
                }
            }
            numer = 0;
            for (int contador = 0; contador < grd.ColumnCount; contador++)
            {

                if (contador != 0 && contador != 4 && contador != 6 && contador != 10)
                {
                    hoja_trabajo.Cells[1, numer + 1] = grd.Columns[contador].HeaderText.ToString();
                    hoja_trabajo.Columns[numer + 1].AutoFit();
                    numer++;
                }
            }
            hoja_trabajo.Rows[1].Font.Bold = true;
            //libros_trabajo.SaveAs(fichero.FileName, Microsoft.Office.Interop.Excel.XlFileFormat.xlWorkbookNormal);
            //libros_trabajo.Close(true);
            //aplicacion.Quit();
            //  }
        }
        private void btnexportarexcel_Click(object sender, EventArgs e)
        {
            //ExportarExcel(dtgconten, "");
            if (dtgconten.RowCount > 0)
            {
                ExportarDataGridViewExcel(dtgconten);
                MSG("Exportado con Exito");
            }
            else
            {
                MSG("Debe Primero Generar un reporte");
                btnGenerar.Focus();
            }
        }
        public void ExportarExcel(DataGridView grilla, string path)
        {
            Microsoft.Office.Interop.Excel.Application xlApp = new Microsoft.Office.Interop.Excel.Application();
            if (xlApp == null)
            {
                //Console.WriteLine("EXCEL could not be started. Check that your office installation and project references are correct.");
                return;
            }
            xlApp.Visible = true;
            Workbook wb = xlApp.Workbooks.Add(XlWBATemplate.xlWBATWorksheet);
            Worksheet ws = (Worksheet)wb.Worksheets[1];
            if (ws == null)
            {
                MSG("Hoja de Trabajo no se pudo Crear. Verifique si tiene instalado Office Excel.");
                return;
            }
            // Select the Excel cells, in the range c1 to c7 in the worksheet. 
            Range arangito;
            int nume, numer;
            nume = 0;
            for (int contador = 0; contador < grilla.ColumnCount; contador++)
            {

                if (contador != 0 && contador != 4 && contador != 6)
                {
                    arangito = ws.get_Range(((char)(65 + nume) + "" + (1)).ToString());
                    arangito.Value2 = grilla.Columns[contador].HeaderText.ToString();
                    //arangito.AutoFit();
                    nume++;
                }
            }
            for (int i = 0; i < grilla.RowCount; i++)
            {
                numer = 0;
                for (int j = 0; j < grilla.ColumnCount - 1; j++)
                {
                    if (j != 0 && j != 4 && j != 6)
                    {
                        arangito = ws.get_Range(((char)(65 + numer) + "" + (i + 2)).ToString());//, (char)(65 + j) +""+ (i + 1));
                        if (arangito == null)
                        {
                            // MSG("Could not get a range. Check to be sure you have the correct versions of the office DLLs.");
                            return;
                        }
                        arangito.Value2 = grilla[j, i].Value.ToString();
                        numer++;
                    }
                }
                arangito = ws.get_Range((char)(65 + numer) + "" + (i + 2));//, (char)(65 + grilla.ColumnCount - 1) +""+ (i + 1));
                arangito.Value2 = grilla[grilla.ColumnCount - 1, i].Value.ToString();
            }
            try
            {
                xlApp.SaveWorkspace(path);
            }
            catch { }
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dtgconten_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int x = e.ColumnIndex, y = e.RowIndex;
            if (e.RowIndex >= 0)
            {
                frmreportepresupuestoetapas etapitas = new frmreportepresupuestoetapas();
                etapitas.etapa = (int)dtgconten["Id_etapas", y].Value;
                etapitas.txtetapa.Text = dtgconten["descripcionetapa", y].Value.ToString();
                etapitas.txtcc.Text = dtgconten["codcentroc", y].Value.ToString();
                etapitas.txtcentro.Text = dtgconten["Descripción", y].Value.ToString();
                etapitas.ShowDialog();
            }
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            dtgconten.DataSource = CLPresuOpera.ListarPresupuestoCentrodeCostoReporte(int.Parse(cboproyecto.SelectedValue.ToString()));
            contando(dtgconten);
            Sumatoria();
            //  REvisarGrillas();
        }

        private void dtgconten_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (dtgconten.RowCount > 0)
                btnexportarexcel.Enabled = true;
            else
                btnexportarexcel.Enabled = false;
        }
    }
}
