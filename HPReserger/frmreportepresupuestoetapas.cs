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
    public partial class frmreportepresupuestoetapas : Form
    {
        public frmreportepresupuestoetapas()
        {
            InitializeComponent();
        }
        HPResergerCapaLogica.HPResergerCL CLpresupuestoetapa = new HPResergerCapaLogica.HPResergerCL();
        public void msg(string cadena) { HPResergerFunciones.frmInformativo.MostrarDialogError(cadena); }
        public void msgOK(string cadena) { HPResergerFunciones.frmInformativo.MostrarDialog(cadena); }
        public int etapa;
        public string cc;
        public Boolean ok;
        public decimal valor;
        public int cabecera;
        public int Tipo;

        private void frmreportepresupuestoetapas_Load(object sender, EventArgs e)
        {
            ok = false;
            //Application.CurrentCulture = new System.Globalization.CultureInfo("EN-US");
            dtgconten.DataSource = CLpresupuestoetapa.MesEtapaProyecto(etapa);
            dtgoperaciones.DataSource = CLpresupuestoetapa.MesEtapaProyecto(etapa);
            dtgdiferencia.DataSource = CLpresupuestoetapa.MesEtapaProyecto(etapa);
            dtgconten.Columns[0].Visible = false;
            dtgoperaciones.Columns[0].Visible = false;
            dtgdiferencia.Columns[0].Visible = false;
            DataTable EtapasDatos = CLpresupuestoetapa.ListarEtapasdelProyecto(10, 0, etapa, "", 0, DateTime.Now, DateTime.Now, 0, "", 0);
            DataRow filadatos = EtapasDatos.Rows[0];
            dtpinicio.Value = (DateTime)filadatos["fecha_inicio"];
            dtpfin.Value = (DateTime)filadatos["fecha_fin"];

            for (int i = 1; i < dtgconten.ColumnCount; i++)
            {
                dtgconten[i, 0].Value = "0.00";
                dtgoperaciones[i, 0].Value = "0.00";
                dtgdiferencia[i, 0].Value = "0.00";
            }
            cc = txtcc.Text;
            dtgvalores.DataSource = CLpresupuestoetapa.MesEtapaCentroCosto(0, etapa, 0, cc, 0, 0, cabecera, 0);
            if (dtgvalores.RowCount > 0)
            {
                for (int i = 0; i < dtgvalores.RowCount; i++)
                {
                    if (Tipo == 1)
                        dtgconten[i + 1, 0].Value = dtgvalores["Importe_MesEtapa", i].Value;
                    else
                        dtgconten[i + 1, 0].Value = dtgvalores["Importe_Flujo", i].Value;
                }
            }
            if (Tipo == 1)
                dtgvalores1.DataSource = CLpresupuestoetapa.ListarReporteCuentaCosto(etapa, cc);
            else
                dtgvalores1.DataSource = CLpresupuestoetapa.ListarReporteCuentaCostoFlujo(etapa, cc);
            if (dtgvalores1.RowCount > 0)
            {
                for (int i = 0; i < dtgvalores1.RowCount; i++)
                {
                    dtgoperaciones[i + 1, 0].Value = dtgvalores1["operaciones", i].Value;
                }
            }
            if (dtgvalores.RowCount > 0)
            {
                for (int i = 0; i < dtgvalores.RowCount; i++)
                {
                    if (Tipo == 1)
                        dtgdiferencia[i + 1, 0].Value = (decimal)dtgvalores["Importe_MesEtapa", i].Value - (decimal)dtgvalores1["operaciones", i].Value;
                    else dtgdiferencia[i + 1, 0].Value = (decimal)dtgvalores["Importe_Flujo", i].Value - (decimal)dtgvalores1["operaciones", i].Value;
                }
            }

            /* dtgvalores.DataSource = CLpresupuestoetapa.MesEtapaCentroCosto(0, etapa, 0, cc, 0, 0);
             if (dtgvalores.RowCount > 0)
             {
                 for (int i = 0; i < dtgvalores.RowCount; i++)
                 {
                     dtgconten[i + 1, 0].Value = dtgvalores["Importe_MesEtapa", i].Value;
                 }
             }*/
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            if (dtgconten.RowCount > 0)
            {
                ExportarDataGridViewExcel();
                msg("Exportado con Exito");
            }
            else
            {

            }
        }
        private void ExportarDataGridViewExcel()
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
            hoja_trabajo.Cells[1, 1] = txtetapa.Text; hoja_trabajo.Cells[1, 3] = txtcc.Text; hoja_trabajo.Cells[1, 2] = txtcentro.Text;
            hoja_trabajo.Cells[2, 1] = "Periodo";
            hoja_trabajo.Cells[3, 1] = "Presupuesto";
            hoja_trabajo.Cells[4, 1] = "Operaciones";
            hoja_trabajo.Cells[5, 1] = "Diferencia";
            for (int i = 0; i < dtgconten.Rows.Count; i++)
            {
                nume = 1;
                for (int j = 0; j < dtgconten.Columns.Count; j++)
                {
                    if (j != 0)
                    {
                        hoja_trabajo.Cells[i + 3, nume + 1] = dtgconten.Rows[i].Cells[j].Value.ToString();
                        hoja_trabajo.Cells[i + 4, nume + 1] = dtgoperaciones.Rows[i].Cells[j].Value.ToString();
                        hoja_trabajo.Cells[i + 5, nume + 1] = dtgdiferencia.Rows[i].Cells[j].Value.ToString();
                        nume++;
                    }
                }
            }
            numer = 1;
            for (int contador = 0; contador < dtgconten.ColumnCount; contador++)
            {
                if (contador != 0)
                {
                    hoja_trabajo.Cells[2, numer + 1] = dtgconten.Columns[contador].HeaderText.ToString();
                    hoja_trabajo.Columns[numer].AutoFit();
                    numer++;
                }
            }
            hoja_trabajo.Rows[1].Font.Bold = true;
            hoja_trabajo.Rows[2].Font.Bold = true;
            hoja_trabajo.Columns[1].Font.Bold = true;
            //libros_trabajo.SaveAs(fichero.FileName, Microsoft.Office.Interop.Excel.XlFileFormat.xlWorkbookNormal);
            //libros_trabajo.Close(true);
            //aplicacion.Quit();
            //  }
        }
    }
}
