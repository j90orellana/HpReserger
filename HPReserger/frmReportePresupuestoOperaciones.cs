using HpResergerUserControls;
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
    public partial class frmReportePresupuestoOperaciones : FormGradient
    {
        public frmReportePresupuestoOperaciones()
        {
            InitializeComponent();
        }
        HPResergerCapaLogica.HPResergerCL CLPresuOpera = new HPResergerCapaLogica.HPResergerCL();
        public void msg(string cadena) { HPResergerFunciones.frmInformativo.MostrarDialogError(cadena); }
        public void msgOK(string cadena) { HPResergerFunciones.frmInformativo.MostrarDialog(cadena); }
        public int cabecera; public int empresa;
        private void frmReportePresupuestoOperaciones_Load(object sender, EventArgs e)
        {
            cboempresa.ValueMember = "codigo";
            cboempresa.DisplayMember = "descripcion";
            cboempresa.DataSource = CLPresuOpera.getCargoTipoContratacion("Id_Empresa", "Empresa", "TBL_Empresa");
            if (cboempresa.Items.Count < 1)
                msg("No hay Empresas");
        }

        private void cboproyecto_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboproyecto.Items.Count > 0)
                btnGenerar.Enabled = true;
            else btnGenerar.Enabled = false;
        }

        private void cboempresa_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboempresa.SelectedIndex > -1)
            {
                cbopresupuestos.DisplayMember = "PartidaPpto";
                cbopresupuestos.ValueMember = "Id_PPresupuesto";
                cbopresupuestos.DataSource = CLPresuOpera.ListarPptoEmpresas((int)cboempresa.SelectedValue);
                if (cbopresupuestos.Items.Count < 1)
                    msg("No Hay Proyectos");
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
                        hoja_trabajo.Cells[i + 2, nume + 1] = grd.Rows[i].Cells[j].Value;
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

                    if (dtgconten.Rows[0].Cells[contador].Value.GetType() == typeof(decimal))
                        hoja_trabajo.Columns[numer + 1].NumberFormat = "0.00";
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
                int a = 0;
                foreach (DataGridViewRow xx in dtgconten.Rows)
                {
                    if ((decimal)xx.Cells[importe.Name].Value != 0 || (decimal)xx.Cells[importe_proy.Name].Value != 0 || (decimal)xx.Cells[Diferencia.Name].Value != 0)
                        dtgconten_CellClick(sender, new DataGridViewCellEventArgs(2, a));
                    a++;
                }
                ExportarDataGridViewExcel(dtgconten);
                msgOK("Exportado con Exito");
            }
            else
            {
                msg("Debe Primero Generar un reporte");
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
                msg("Hoja de Trabajo no se pudo Crear. Verifique si tiene instalado Office Excel.");
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
                if (!string.IsNullOrWhiteSpace(dtgconten["Descripción", y].Value.ToString()))
                {
                    frmreportepresupuestoetapas etapitas = new frmreportepresupuestoetapas();
                    etapitas.etapa = (int)dtgconten["Id_etapas", y].Value;
                    etapitas.txtetapa.Text = dtgconten["descripcionetapa", y].Value.ToString();
                    etapitas.txtcc.Text = dtgconten["codcentroc", y].Value.ToString();
                    etapitas.txtcentro.Text = dtgconten["Descripción", y].Value.ToString();
                    etapitas.cabecera = (int)cbopresupuestos.SelectedValue;
                    etapitas.Tipo = 1;//Operaciones
                    etapitas.Icon = Icon;
                    etapitas.ShowDialog();
                }
                else
                {
                    //  System.Globalization.CultureInfo C = new System.Globalization.CultureInfo("es-ES");
                    // System.Windows.Forms.Application.CurrentCulture = C;
                    int[] fila = SacarValores((dtgconten["descripcionetapa", y].Value.ToString()));
                    DateTime tiempo = DateTime.Parse("01/" + fila[0] + "/" + fila[1]);
                    // MSG(tiempo.ToString());
                    frmVerDetallePresuspuestoOperaciones Frmpresu = new frmVerDetallePresuspuestoOperaciones();
                    Frmpresu.cuenta = (dtgconten[Cta_Contable.Name, y].Value.ToString());
                    Frmpresu.etapa = int.Parse(dtgconten["id_etapas", y].Value.ToString());
                    Frmpresu.Tipo = 1;//flujos
                    Frmpresu.fecha = tiempo;
                    Frmpresu.Icon = Icon;
                    Frmpresu.ShowDialog();
                }
            }
        }
        public class MesAño
        {
            public string mes { get; set; }
            public int numero { get; set; }
        }
        List<MesAño> liston = new List<MesAño>();
        public int[] SacarValores(string cadena) //jul - 2017
        {
            liston.Add(new MesAño() { mes = "Ene", numero = 1 });
            liston.Add(new MesAño() { mes = "Feb", numero = 2 });
            liston.Add(new MesAño() { mes = "Mar", numero = 3 });
            liston.Add(new MesAño() { mes = "Abr", numero = 4 });
            liston.Add(new MesAño() { mes = "May", numero = 5 });
            liston.Add(new MesAño() { mes = "Jun", numero = 6 });
            liston.Add(new MesAño() { mes = "Jul", numero = 7 });
            liston.Add(new MesAño() { mes = "Ago", numero = 8 });
            liston.Add(new MesAño() { mes = "Sep", numero = 9 });
            liston.Add(new MesAño() { mes = "Oct", numero = 10 });
            liston.Add(new MesAño() { mes = "Nov", numero = 11 });
            liston.Add(new MesAño() { mes = "Dic", numero = 12 });
            ///
            string cadenita = cadena.Substring(0, 3);
            int año = int.Parse(cadena.Substring(6, 4));
            MesAño numerito = liston.Find(val => val.mes == cadenita);
            int[] numeron = new int[2];
            numeron[0] = numerito.numero;
            numeron[1] = año;
            liston.Clear();
            return numeron;

        }
        private void dtgconten_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && !string.IsNullOrWhiteSpace(dtgconten["CodCentroC", e.RowIndex].Value.ToString()))
            {
                int Ocultar = 0;
                if (dtgconten["conta", e.RowIndex].Value.ToString() == "99")
                {
                    dtgconten["conta", e.RowIndex].Value = "0";
                    Ocultar = 1;
                }
                else
                {
                    Ocultar = 0;
                    dtgconten["conta", e.RowIndex].Value = "99";
                }
                if (!string.IsNullOrWhiteSpace(dtgconten["iddep", e.RowIndex].Value.ToString()))
                {
                    System.Data.DataTable tablon = (System.Data.DataTable)dtgconten.DataSource;
                    List<DataRow> datos = new List<DataRow>();
                    foreach (DataRow datito in tablon.Rows)
                    {
                        datos.Add(datito);
                    }
                    System.Data.DataTable tablita = CLPresuOpera.ListarDetalleDelReporteDeCentrodeCosto((int)dtgconten["id_etapas", e.RowIndex].Value, dtgconten["codcentroc", e.RowIndex].Value.ToString(), dtgconten["Cta_Contable", e.RowIndex].Value.ToString(), (int)cbopresupuestos.SelectedValue);
                    int i = 1;
                    //dtgconten.DataSource = null;
                    foreach (DataRow dato in tablita.Rows)
                    {
                        if (Ocultar == 0)
                            datos.Insert(e.RowIndex + i, dato);
                        i++;
                    }
                    if (Ocultar == 1)
                        datos.RemoveRange(e.RowIndex + 1, tablita.Rows.Count);
                    tablon = datos.CopyToDataTable();
                    dtgconten.DataSource = tablon;
                    /////////////////////////////////////////////////////////////////////////////*
                    /*    int esto=10;        
                        List<numeros> numero = new List<numeros>();
                        numeros valor = new numeros();
                        valor.numero = 10;
                        valor.nombre = "Jefferson Orellana";
                        valor.valor = 10.01m;
                        numero.Add(valor);
                        List<numeros> aloja = numero.FindAll(holi => holi.numero > esto);
                        IEnumerable<numeros> lista = from valores in numero where valores.valor > esto select valor;
                      */
                    /////////////////////////////////////////////////////////////////////////////
                    // List<int> Scores = new List<int>() { 97, 92, 81, 60 };
                    //   IEnumerable<int> lista = from score in Scores where score > 80 select score;
                }
                dtgconten.CurrentCell = dtgconten[e.ColumnIndex, e.RowIndex];
                // Message Box.Show("hola");
            }
        }
        public class numeros
        {
            public int numero { get; set; }
            public string nombre { get; set; }
            public decimal valor { get; set; }
        }

        private void cbopresupuestos_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboproyecto.ValueMember = "id_proyecto";
            cboproyecto.DisplayMember = "proyecto";
            cboproyecto.DataSource = CLPresuOpera.ListarProyectosEmpresa(cboempresa.SelectedValue.ToString(), (int)cbopresupuestos.SelectedValue);
            if (cboproyecto.Items.Count < 1)
                msg("No hay Proyectos Presupuestados");
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            if (cboproyecto.SelectedIndex >= 0 && cbopresupuestos.SelectedIndex >= 0)
            {
                dtgconten.DataSource = CLPresuOpera.ListarPresupuestoCentrodeCostoReporte(int.Parse(cboproyecto.SelectedValue.ToString()), (int)cbopresupuestos.SelectedValue);
                System.Data.DataTable tablita = (System.Data.DataTable)dtgconten.DataSource;
                dtgconten.DataSource = tablita;
                // System.Data.DataTable dttAgrupamientos = CLPresuOpera.ListarPresupuestoCentrodeCostoReporte(int.Parse(cboproyecto.SelectedValue.ToString()));
                // BindingSource bAsociacion = new BindingSource();
                // bAsociacion.DataSource = dttAgrupamientos;
                dtgconten.AutoGenerateColumns = false;
                // dtgconten.DataSource = bAsociacion;
                // System.Data.DataTable tablita = CLPresuOpera.ListarPresupuestoCentrodeCostoReporte(int.Parse(cboproyecto.SelectedValue.ToString()));
                // dtgconten.DataSource = null;
                contando(dtgconten);
                Sumatoria();
                //  REvisarGrillas();
                if (dtgconten.RowCount <= 0)
                    msg("No hay Etapas en el Proyecto");
            }//MSG("Seleccione Proyecto y Presupuesto");
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
