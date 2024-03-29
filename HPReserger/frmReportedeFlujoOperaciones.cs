﻿using HpResergerUserControls;
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
    public partial class frmReportedeFlujoOperaciones : FormGradient
    {
        public frmReportedeFlujoOperaciones()
        {
            InitializeComponent();
        }
        HPResergerCapaLogica.HPResergerCL CapaLogica = new HPResergerCapaLogica.HPResergerCL();
        public void msg(string cadena) { HPResergerFunciones.frmInformativo.MostrarDialogError(cadena); }
        public void msgOK(string cadena) { HPResergerFunciones.frmInformativo.MostrarDialog(cadena); }
        private void frmReportedeFlujoOperaciones_Load(object sender, EventArgs e)
        {
            CargarEmpresas();          
        }

        private void CargarEmpresas()
        {
            cboempresa.ValueMember = "codigo";
            cboempresa.DisplayMember = "descripcion";
            cboempresa.DataSource = CapaLogica.getCargoTipoContratacion("Id_Empresa", "Empresa", "TBL_Empresa");
            if (cboempresa.Items.Count < 1)
                msg("No hay Empresas");
        }

        private void cboempresa_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboempresa.SelectedIndex > -1)
            {
                cbopresupuestos.DisplayMember = "PartidaPpto";
                cbopresupuestos.ValueMember = "Id_PPresupuesto";
                cbopresupuestos.DataSource = CapaLogica.ListarPptoEmpresas((int)cboempresa.SelectedValue);
                if (cbopresupuestos.Items.Count < 1)
                    msg("No Hay Proyectos");
            }
        }

        private void cbopresupuestos_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboproyecto.ValueMember = "id_proyecto";
            cboproyecto.DisplayMember = "proyecto";
            cboproyecto.DataSource = CapaLogica.ListarProyectosEmpresa(cboempresa.SelectedValue.ToString(), (int)cbopresupuestos.SelectedValue);
            if (cboproyecto.Items.Count < 1)
                msg("No hay Proyectos Presupuestados");
        }
        public void contando(DataGridView grilla)
        {
            lblmsg.Text = "Total de Registros " + grilla.RowCount;
        }
        decimal IMPORTES, OPERACION, DIFERENCIAS;

        private void btncancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void msgError(string cadena) { HPResergerFunciones.frmInformativo.MostrarDialogError(cadena); }
        string EmpresaValor = "";
        string NameProyecto = "";
        private void btnexportarexcel_Click(object sender, EventArgs e)
        {
            if (dtgconten.RowCount > 0)
            {
                int a = 0;
                foreach (DataGridViewRow xx in dtgconten.Rows)
                {
                    if ((decimal)xx.Cells[Importe.Name].Value != 0 || (decimal)xx.Cells[importe_proy.Name].Value != 0 || (decimal)xx.Cells[Operaciones.Name].Value != 0)
                        if ((int)xx.Cells[conta.Name].Value == 0)
                            dtgconten_CellContentClick(sender, new DataGridViewCellEventArgs(2, a));
                    a++;
                }
                TDatos = ((DataTable)dtgconten.DataSource).Copy();
                
                if (TDatos.Rows.Count == 0)
                {
                    msgError("No hay Registros para Mostrar");
                    Cursor = Cursors.Default;
                }
                else
                {
                    Cursor = Cursors.WaitCursor;
                    backgroundWorker1.WorkerSupportsCancellation = true;
                    if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
                    {
                        Cursor = Cursors.Default;
                        frmproce = new HPReserger.frmProcesando();
                        frmproce.Show();
                        EmpresaValor = cboempresa.Text;
                        NameProyecto = cboproyecto.Text;
                        if (!backgroundWorker1.IsBusy)
                        {
                            backgroundWorker1.RunWorkerAsync();
                        }
                    }
                    else
                    {
                        Cursor = Cursors.Default;
                        return;
                    }
                }
            }
            else
            {
                msg("Debe Primero Generar un reporte");
                btnGenerar.Focus();
            }
        }
        private void ExportarDataGridViewExcel(DataGridView grd)
        {
            List<HPResergerFunciones.Utilitarios.NombreCelda> Celditas = new List<HPResergerFunciones.Utilitarios.NombreCelda>();
            HPResergerFunciones.Utilitarios.NombreCelda Celdita = new HPResergerFunciones.Utilitarios.NombreCelda();
            Celdita.fila = 1; Celdita.columna = 1; Celdita.Nombre = "Reporte de Operaciones";
            Celditas.Add(Celdita);
            // HPResergerFunciones.Utilitarios.ExportarAExcel(dtgconten, "", "Empresas", Celditas, 1, new int[] {  }, new int[] { 1 }, new int[] { });
            HPResergerFunciones.Utilitarios.ExportarAExcelOrdenandoColumnas(grd, "", "Flujo de Pagos", Celditas, 1, new int[] { 2, 3, 4, 10, 5, 6, 8, 9 }, new int[] { 1 }, new int[] { });
        }

        private void dtgconten_CellContentClick(object sender, DataGridViewCellEventArgs e)
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
                    System.Data.DataTable tablita = CapaLogica.ListarDetalleDelReporteDeCentrodeCostoFLujos((int)dtgconten["id_etapas", e.RowIndex].Value, dtgconten["codcentroc", e.RowIndex].Value.ToString(), dtgconten["Cta_Contable", e.RowIndex].Value.ToString(), (int)cbopresupuestos.SelectedValue);
                    dataGridView1.DataSource = tablita;
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
                    etapitas.Icon = Icon;
                    etapitas.Tipo = 2;//flujos
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
                    Frmpresu.cuenta =  (dtgconten[Cta_Contable.Name, y].Value.ToString());
                    Frmpresu.etapa = int.Parse(dtgconten["id_etapas", y].Value.ToString());
                    Frmpresu.fecha = tiempo;
                    Frmpresu.Icon = Icon;
                    Frmpresu.Tipo = 2;//flujos
                    Frmpresu.ShowDialog();
                }
            }
        }
        frmProcesando frmproce;
        DataTable TDatos = new DataTable();
        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            if (TDatos.Rows.Count > 0)
            {                
                string Carpeta = folderBrowserDialog1.SelectedPath;
                //               
                //string Ruc = CapaLogica.BuscarRucEmpresa(EmpresaValor)[0].ToString();
                string valor = Carpeta + @"\";
                //if (chkCarpetas.Checked)
                //{
                valor = Carpeta + @"\" + EmpresaValor + @"\";
                if (!Directory.Exists(Carpeta + @"\" + EmpresaValor))
                    Directory.CreateDirectory(Carpeta + @"\" + Configuraciones.ValidarRutaValida(EmpresaValor));
                //}
                string NameFile = "";
                NameFile = valor + $"Reporte Flujo Caja  {EmpresaValor} - {NameProyecto}.xlsx";
                //ELiminamos el Excel Antiguo                
                File.Delete(NameFile);
                File.Exists(NameFile);
                //DEFINICIONES
                int i = 0; //posicion de la hoja no  es index
                int Hoja = 0;
                Color BackAlterno = Color.FromArgb(220, 230, 241);
                Color ForeAlterno = Color.Black;
                Color BackColumna = Color.FromArgb(78, 129, 189);
                Color ForeColumna = Color.White;
                //
                HPResergerFunciones.Utilitarios.EstiloCelda CeldaDefault = new HPResergerFunciones.Utilitarios.EstiloCelda(BackAlterno, Configuraciones.FuenteReportesTahoma8, ForeAlterno);
                HPResergerFunciones.Utilitarios.EstiloCelda CeldaCabecera = new HPResergerFunciones.Utilitarios.EstiloCelda(BackColumna, Configuraciones.FuenteReportesTahoma8, ForeColumna);
                //PRIMERA HOJA RESUMEN
                Hoja++;
                String _NombreHoja = $"Resumen";
                List<HPResergerFunciones.Utilitarios.RangoCelda> Celdas = new List<HPResergerFunciones.Utilitarios.RangoCelda>();
               Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda($"A{1 + i}", $"F{1+ i}", $"{EmpresaValor}", 12, true, true, HPResergerFunciones.Utilitarios.Alineado.centro, Color.White, Color.Black, Configuraciones.FuenteReportesTahoma10, true));
                Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda($"A{2 + i}", $"F{2 + i}", $"{NameProyecto}", 9, true, true, HPResergerFunciones.Utilitarios.Alineado.centro, Color.White, Color.Black, Configuraciones.FuenteReportesTahoma10, true));
                Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda($"A{3 + i}", $"F{3 + i}", $"Reporte de Presupuesto Etapas", 9, true, true, HPResergerFunciones.Utilitarios.Alineado.centro, Color.White, Color.Black, Configuraciones.FuenteReportesTahoma10, true));

                TDatos.Columns.RemoveAt(10);
                TDatos.Columns.RemoveAt(6);
                TDatos.Columns.RemoveAt(4);
                TDatos.Columns.RemoveAt(3);
                TDatos.Columns.RemoveAt(0);
                TDatos.Columns[5].SetOrdinal(2);
                
                HPResergerFunciones.Utilitarios.ExportarAExcelOrdenandoColumnasCreado(TDatos, CeldaCabecera, CeldaDefault, NameFile, _NombreHoja, Hoja, Celdas, 5, new int[] { }, new int[] { },
                  new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }, "", true);
              
                msgOK($"Archivo Grabados en \n{folderBrowserDialog1.SelectedPath}");
                if (backgroundWorker1.IsBusy) backgroundWorker1.CancelAsync();
            }
            else msgError("No hay Registros en la Grilla");
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            Cursor = Cursors.Default;
            frmproce.Close();
        }

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
        private void btnGenerar_Click(object sender, EventArgs e)
        {
            if (cboproyecto.SelectedValue != null)
            {
                //MSG(int.Parse(cboproyecto.SelectedValue.ToString()) + " " + (int)cbopresupuestos.SelectedValue + "");
                dtgconten.DataSource = CapaLogica.ListarFLujosCentrodeCostoReporte(int.Parse(cboproyecto.SelectedValue.ToString()), (int)cbopresupuestos.SelectedValue);
                System.Data.DataTable tablita = (System.Data.DataTable)dtgconten.DataSource;
                dtgconten.DataSource = tablita;
                dataGridView1.DataSource = tablita;
                dtgconten.AutoGenerateColumns = false;
                contando(dtgconten);
                Sumatoria();
                if (dtgconten.RowCount <= 0)
                    msg("No hay Etapas en el Proyecto");
            }
        }
    }
}
