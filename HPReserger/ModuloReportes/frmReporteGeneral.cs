using HpResergerUserControls;
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
    public partial class frmReporteGeneral : FormGradient
    {
        public frmReporteGeneral()
        {
            InitializeComponent();
        }
        HPResergerCapaLogica.HPResergerCL CapaLogica = new HPResergerCapaLogica.HPResergerCL();
        public void ContarRegistros()
        {
            lblconteo.Text = $"Número de Registros: {dtgconten.RowCount}";
        }
        private void frmReporteGeneral_Load(object sender, EventArgs e)
        {
            cboempresas.DataSource = CapaLogica.getCargoTipoContratacion2("Id_Empresa", "Empresa", "TBL_Empresa");
            cboempresas.DisplayMember = "descripcion";
            cboempresas.ValueMember = "codigo";
            //cargarAños();

            Reportes.Columns.Add("i", typeof(int));
            Reportes.Columns.Add("campo", typeof(string));
            Reportes.Columns.Add("total", typeof(decimal));
            Reportes.Columns.Add("empresa", typeof(int));
            Reportes.Columns.Add("ix", typeof(int));
            Reportes.Columns.Add("campox", typeof(string));
            Reportes.Columns.Add("totalx", typeof(decimal));
            Reportes.Columns.Add("empresax", typeof(int));

            Reporte2.Columns.Add("i", typeof(int));
            Reporte2.Columns.Add("campo", typeof(string));
            Reporte2.Columns.Add("total", typeof(decimal));
            Reporte2.Columns.Add("empresa", typeof(int));

            comboMesAño.Fecha(DateTime.Now.AddMonths(-1));

            lblfechasReporte.Text = $"Al {comboMesAño.FechaFinMes.ToString("dd")}";
            // comboaño.Text = (DateTime.Now.Year - 1).ToString();
        }
        //DataTable años;
        //public void cargarAños()
        //{
        //    años = new DataTable();
        //    años.Columns.Add("codigo");
        //    años.Columns.Add("valor", typeof(int));
        //    int año = DateTime.Now.Year;
        //    DataRow datito = CapaLogica.getMinMaxContrato();
        //    int x;
        //    if (datito["minimo"].ToString() != "")
        //        x = DateTime.Now.Year + 1 - DateTime.Parse(datito["minimo"].ToString()).Year;
        //    else
        //        x = DateTime.Now.Year - DateTime.Now.Year + 1;

        //    for (int i = 0; i < x; i++)
        //    {
        //        años.Rows.Add(año - i, año - i);
        //    }
        //    comboaño.ValueMember = "valor";
        //    comboaño.DisplayMember = "codigo";
        //    comboaño.DataSource = años;
        //}
        public void msg(string cadena) { HPResergerFunciones.frmInformativo.MostrarDialogError(cadena); }
        public void msgOK(string cadena) { HPResergerFunciones.frmInformativo.MostrarDialog(cadena); }
        public DialogResult msgp(string cadena) { return HPResergerFunciones.frmPregunta.MostrarDialogYesCancel(cadena); }

        private void dtgconten_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            ContarRegistros();
            ColorFondo = btnColorFondo.BackColor = dtgconten[e.ColumnIndex, e.RowIndex].Style.BackColor;
            ColorLetra = btnColorLetra.BackColor = dtgconten[e.ColumnIndex, e.RowIndex].Style.ForeColor;
        }
        private void cboempresas_DrawItem(object sender, DrawItemEventArgs e)
        {
            try
            {
                if (e.Index >= 0)
                {
                    StringFormat st = new StringFormat();
                    st.Alignment = StringAlignment.Center;
                    cboempresas.SelectedIndex = e.Index;
                    e.Graphics.DrawString(cboempresas.Text, e.Font, Brushes.Black, e.Bounds, st);
                }
            }
            catch
            {
                throw;
            }
        }
        private void comboaño_DrawItem(object sender, DrawItemEventArgs e)
        {
            try
            {
                if (e.Index >= 0)
                {
                    StringFormat st = new StringFormat();
                    st.Alignment = StringAlignment.Center;
                    //  comboaño.SelectedIndex = e.Index;
                    //e.Graphics.DrawString(comboaño.Text, e.Font, Brushes.Black, e.Bounds, st);
                }
            }
            catch
            {
                throw;
            }
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
        frmProcesando frmproce;
        string EMPRESA = "";
        DateTime ultimodia, getfecha;
        private void btnexportarexcel_Click(object sender, EventArgs e)
        {
            if (dtgconten.RowCount > 0)
            {
                Cursor = Cursors.WaitCursor;
                frmproce = new HPReserger.frmProcesando();
                frmproce.Show();

                EMPRESA = cboempresas.Text;
                ultimodia = comboMesAño.UltimoDiaDelMes();
                getfecha = comboMesAño.GetFecha();
                if (!backgroundWorker1.IsBusy)
                {
                    backgroundWorker1.RunWorkerAsync();
                }
            }
            else msg("No hay datos para Exportar");
        }
        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            string _NombreHoja = "ESTADO_SITUACÍON_FINANCIERA";
            List<HPResergerFunciones.Utilitarios.RangoCelda> ListaCeldas = new List<HPResergerFunciones.Utilitarios.RangoCelda>();
            HPResergerFunciones.Utilitarios.RangoCelda Celda1 = new HPResergerFunciones.Utilitarios.RangoCelda("a1", "d1", EMPRESA, 14);
            ListaCeldas.Add(Celda1);
            HPResergerFunciones.Utilitarios.RangoCelda Celda2 = new HPResergerFunciones.Utilitarios.RangoCelda("a2", "d2", "ESTADO DE SITUACIÓN FINANCIERA", 12);
            ListaCeldas.Add(Celda2);
            HPResergerFunciones.Utilitarios.RangoCelda Celda3 = new HPResergerFunciones.Utilitarios.RangoCelda("a3", "d3", $"Al {ultimodia.ToString("dd")} de {getfecha.ToString("MMMM")} del {getfecha.Year}");
            ListaCeldas.Add(Celda3);
            HPResergerFunciones.Utilitarios.RangoCelda Celda4 = new HPResergerFunciones.Utilitarios.RangoCelda("a4", "d4", $"(Expresado en Soles)");
            ListaCeldas.Add(Celda4);
            HPResergerFunciones.Utilitarios.ExportarAExcelOrdenandoColumnas(dtgconten, "", _NombreHoja, ListaCeldas, 5, new int[] { 2, 3, 6, 7 }, new int[] { 1 }, new int[] { });
        }
        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            Cursor = Cursors.Default;
            frmproce.Close();
        }
        private void btnexportarpdf_Click(object sender, EventArgs e)
        {
            if (dtgconten.RowCount > 0)
            {
                frmReporteBalanceGeneral frmrepor = new frmReporteBalanceGeneral();
                frmrepor.año = comboMesAño.UltimoDiaDelMes();
                frmrepor.empresa = (int)cboempresas.SelectedValue;
                frmrepor.NombreEmpresa = cboempresas.Text;
                frmrepor.Icon = Icon;
                frmrepor.Show();
            }
            else msg("No hay datos para Exportar");
        }
        public Color ColorFondo;
        public Color ColorLetra;
        public void PintarNegroTotales(DataGridView grid)
        {
            foreach (DataGridViewRow item in grid.Rows)
            {
                if (item.Cells[indexx.Name].Value.ToString() != "" || item.Cells[indez.Name].Value.ToString() != "")
                {
                    if ((item.Cells[indexx.Name].Value.ToString().Length <= 4) && item.Cells[indexx.Name].Value.ToString() != "")
                    {
                        if (item.Cells[indexx.Name].Value.ToString().Substring(item.Cells[indexx.Name].Value.ToString().Length - 2, 2) == "99" || item.Cells[indexx.Name].Value.ToString().Substring(item.Cells[indexx.Name].Value.ToString().Length - 2, 2) == "00")
                        {
                            foreach (DataGridViewCell Celda in item.Cells)
                            {
                                if (Celda.OwningColumn.Name == Camposx.Name || Celda.OwningColumn.Name == Totalesx.Name)
                                {
                                    if (Celda.OwningColumn.Name == Camposx.Name && Celda.Value.ToString().Length < 41)
                                        Celda.Value = Celda.Value.ToString().ToUpper();

                                    Celda.Style.BackColor = Color.FromArgb(198, 239, 206);//255, 255, 153
                                    Celda.Style.ForeColor = Color.FromArgb(0, 97, 0);//.Blue;
                                    Celda.Style.Font = new Font(dtgconten.Font, FontStyle.Bold);
                                }
                            }
                        }
                        else
                        {
                            foreach (DataGridViewCell Celda in item.Cells)
                            {
                                if (Celda.OwningColumn.Name == Camposx.Name || Celda.OwningColumn.Name == Totalesx.Name)
                                {
                                    Celda.Style.BackColor = Color.FromArgb(255, 255, 255);
                                    Celda.Style.ForeColor = Color.Black;
                                }
                            }
                        }
                    }
                    else
                    {
                        foreach (DataGridViewCell Celda in item.Cells)
                        {
                            Celda.Style.BackColor = Color.FromArgb(255, 255, 255);
                            Celda.Style.ForeColor = Color.Black;
                        }
                    }
                    if ((item.Cells[indez.Name].Value.ToString().Length <= 4) && item.Cells[indez.Name].Value.ToString().Length > 0)
                    {
                        if (item.Cells[indez.Name].Value.ToString().Substring(item.Cells[indez.Name].Value.ToString().Length - 2, 2) == "99" || item.Cells[indez.Name].Value.ToString().Substring(item.Cells[indez.Name].Value.ToString().Length - 2, 2) == "00")
                        {
                            foreach (DataGridViewCell Celda in item.Cells)
                            {
                                if (Celda.OwningColumn.Name == campoz.Name || Celda.OwningColumn.Name == totalesz.Name)
                                {
                                    if (Celda.OwningColumn.Name == campoz.Name && Celda.Value.ToString().Length < 41)
                                        Celda.Value = Celda.Value.ToString().ToUpper();

                                    Celda.Style.BackColor = Color.FromArgb(198, 239, 206);//255, 255, 153
                                    Celda.Style.ForeColor = Color.FromArgb(0, 97, 0);//.Blue;
                                    Celda.Style.Font = new Font(dtgconten.Font, FontStyle.Bold);
                                }
                            }
                        }
                        else
                        {
                            foreach (DataGridViewCell Celda in item.Cells)
                            {
                                if (Celda.OwningColumn.Name == campoz.Name || Celda.OwningColumn.Name == totalesz.Name)
                                {
                                    Celda.Style.BackColor = Color.FromArgb(255, 255, 255);
                                    Celda.Style.ForeColor = Color.Black;
                                }
                            }
                        }
                    }
                    else
                    {
                        foreach (DataGridViewCell Celda in item.Cells)
                        {
                            Celda.Style.BackColor = Color.FromArgb(255, 255, 255);
                            Celda.Style.ForeColor = Color.Black;
                        }
                    }
                }
                else
                {
                    foreach (DataGridViewCell Celda in item.Cells)
                    {
                        Celda.Style.BackColor = Color.FromArgb(255, 255, 255);
                        Celda.Style.ForeColor = Color.Black;
                    }
                }
            }
        }
        DataTable Reportes = new DataTable();
        DataTable Reporte2 = new DataTable();
        DataTable Consulta = new DataTable();
        public DataTable SacarResultadoEjercicio(DateTime año, int empresa)
        {
            return CapaLogica.SacarResultadoEjercicio(año, empresa);
        }
        DataTable Prueba = new DataTable();
        private void btnGenerar_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            DataTable Datitos = CapaLogica.Periodos(5, (int)cboempresas.SelectedValue, comboMesAño.GetFecha());
            if (Datitos.Rows.Count == 0)
            {
                Reportes.Clear();
                HPResergerFunciones.Utilitarios.msg("Periodo no está Creado");
                return;
            }
            DataRow filita = Datitos.Rows[0];
            if ((int)filita["estado"] == 3)
            {
                HPResergerFunciones.Utilitarios.msg("Periodo Cerrado");
            }
            //if (comboMesAño.GetFecha().Year >= DateTime.Now.Year && comboMesAño.GetFecha().Month >= DateTime.Now.Month)
            //{
            //    msg("Mes no está Cerrado");
            //    Reportes.Clear();
            //    return;
            //}
            if (cboempresas.Items.Count > 0)
            {
                try
                {
                    Cursor = Cursors.WaitCursor;

                    Consulta = CapaLogica.BalanceGeneral(comboMesAño.UltimoDiaDelMes(), (int)cboempresas.SelectedValue);
                    Prueba = SacarResultadoEjercicio(comboMesAño.UltimoDiaDelMes(), (int)cboempresas.SelectedValue);
                    Reportes.Clear();
                    Reporte2.Clear();
                    int act = 0, pas = 0;
                    if (Consulta != null)
                        foreach (DataRow item in Consulta.Rows)
                        {

                            if (item["i"].ToString().Substring(0, 1) == "1")
                            {
                                Reportes.ImportRow(item);
                                act++;
                            }
                            else
                            {
                                Reporte2.ImportRow(item);
                                pas++;
                            }
                        }
                    //msg($"Activo {act}, Pasivo {pas}");
                    if (act > pas)
                    {
                        int dif = act - pas;
                        for (int iv = 0; iv < dif; iv++)
                        {
                            Reportes.Rows.InsertAt(Reportes.NewRow(), Reportes.Rows.Count - 1);
                        }
                    }
                    else
                    {
                        int dif = pas - act;
                        for (int iv = 0; iv < dif; iv++)
                        {
                            Reportes.Rows.InsertAt(Reportes.NewRow(), Reportes.Rows.Count - 2);
                        }
                    }
                    int i = 0;
                    foreach (DataRow item in Reportes.Rows)
                    {
                        item["ix"] = Reporte2.Rows[i].ItemArray[0];
                        item["campox"] = Reporte2.Rows[i].ItemArray[1];
                        item["totalx"] = Reporte2.Rows[i].ItemArray[2];
                        item["empresax"] = Reporte2.Rows[i].ItemArray[3];
                        i++;
                    }
                    //Resultado Periodo
                    foreach (DataRow item in Reportes.Rows)
                    {
                        if (item["campox"].ToString() == "Resultados del Período" || item["ix"].ToString() == "3108")
                        {
                            item["totalx"] = Convert.ToDecimal((Prueba.Rows[0])["total"].ToString());
                        }
                    }
                    ///sacar totales
                    decimal ActivoTotal = 0;
                    decimal PasivoTotal = 0;
                    decimal PatrimonioTotal = 0;

                    foreach (DataRow item in Reportes.Rows)
                    {
                        int ValorMaximo = 0, ValorMinimo = 0;
                        string cadena = "";
                        decimal Sumar;
                        cadena = item["i"].ToString();
                        if (cadena != "")
                        {
                            if (item["i"].ToString().Substring(0, 1) == "1" && cadena.Substring(cadena.Length - 2, 2) != "00" && cadena.Substring(cadena.Length - 2, 2) != "99")
                                ActivoTotal += decimal.Parse(item["total"].ToString());
                            //cadena = item["ix"].ToString();
                            //if (item["ix"].ToString().Substring(0, 1) == "2" && cadena.Substring(cadena.Length - 2, 2) != "00" && cadena.Substring(cadena.Length - 2, 2) != "99")
                            //    PasivoTotal += decimal.Parse(item["totalx"].ToString());
                            //if (item["ix"].ToString().Substring(0, 1) == "3" && cadena.Substring(cadena.Length - 2, 2) != "00" && cadena.Substring(cadena.Length - 2, 2) != "99")
                            //    PatrimonioTotal += decimal.Parse(item["totalx"].ToString());

                            if (item["i"].ToString().Substring(item["i"].ToString().Length - 2, 2) == "99")
                            {

                                cadena = item["i"].ToString();
                                ValorMinimo = int.Parse(cadena.Substring(0, cadena.Length - 2) + "00");
                                ValorMaximo = int.Parse(cadena.Substring(0, cadena.Length - 2) + "99");
                                Sumar = 0;
                                foreach (DataRow items in Reportes.Rows)
                                {
                                    if (items["i"].ToString() != "")
                                    {
                                        int valore = int.Parse(items["i"].ToString());
                                        if (valore > ValorMinimo && valore < ValorMaximo)
                                        {
                                            Sumar += decimal.Parse(items["total"].ToString());
                                        }
                                    }
                                }
                                item["total"] = Sumar;
                            }
                        }
                        cadena = item["ix"].ToString();
                        if (cadena != "")
                        {
                            cadena = item["ix"].ToString();
                            if (item["ix"].ToString().Substring(0, 1) == "2" && cadena.Substring(cadena.Length - 2, 2) != "00" && cadena.Substring(cadena.Length - 2, 2) != "99")
                                PasivoTotal += decimal.Parse(item["totalx"].ToString());
                            if (item["ix"].ToString().Substring(0, 1) == "3" && cadena.Substring(cadena.Length - 2, 2) != "00" && cadena.Substring(cadena.Length - 2, 2) != "99")
                                PatrimonioTotal += decimal.Parse(item["totalx"].ToString());
                            if (item["ix"].ToString().Substring(item["ix"].ToString().Length - 2, 2) == "99")
                            {
                                cadena = item["ix"].ToString();
                                ValorMinimo = int.Parse(cadena.Substring(0, cadena.Length - 2) + "00");
                                ValorMaximo = int.Parse(cadena.Substring(0, cadena.Length - 2) + "99");
                                Sumar = 0;
                                foreach (DataRow items in Reportes.Rows)
                                {
                                    if (items["ix"].ToString() != "")
                                    {
                                        int valore = int.Parse(items["ix"].ToString());
                                        if (valore > ValorMinimo && valore < ValorMaximo)
                                        {
                                            Sumar += decimal.Parse(items["totalx"].ToString());
                                        }
                                    }
                                }
                                item["totalx"] = Sumar;
                            }
                        }
                    }
                    //asignacion de valores
                    foreach (DataRow item in Reportes.Rows)
                    {
                        if (item["i"].ToString() == "199")
                            item["total"] = ActivoTotal;
                        if (item["ix"].ToString() == "299")
                            item["totalx"] = PasivoTotal;
                        if (item["ix"].ToString() == "399")
                            item["totalx"] = PatrimonioTotal;
                        if (item["ix"].ToString() == "499")
                            item["totalx"] = PatrimonioTotal + PasivoTotal;
                    }

                    dtgconten.DataSource = Reportes;
                    ContarRegistros();
                    PintarNegroTotales(dtgconten);
                    Cursor = Cursors.Default;
                    //procesando.Close();
                    decimal diff = ActivoTotal - (PatrimonioTotal + PasivoTotal);
                    txtdiferencia.Text = "0.00";
                    if (diff != 0)
                        if (diff > 0)
                        {
                            msg($"El ACTIVO sobrepasa al PASIVO+PATRIMONIO por: {diff.ToString("n2")}");
                            txtdiferencia.Text = diff.ToString("n2");
                        }
                        else
                        {
                            msg($"El PASIVO+PATRIMONIO sobrepasa al ACTIVO por : {(-1 * diff).ToString("n2")}");
                            txtdiferencia.Text = (-1 * diff).ToString("n2");
                        }
                }
                catch (System.Data.SqlClient.SqlException ex)
                {
                    Cursor = Cursors.Default;
                    HPResergerFunciones.frmInformativo.MostrarDialogError("Error", $"Revise la Naturaleza de las Cuentas  \n{ex.Message}");
                }

                //if (cboempresas.Items.Count > 0)
                //{
                //    Reportes.Clear();
                //    Reportes.Rows.Add(new object[] { 19, "ACTIVO CORRIENTE" });
                //    //ACTIVO CORRIENTE
                //   Consulta = CapaLogica.BalanceGenerarlActivoCorriente(comboMesAño.UltimoDiaDelMes(), (int)cboempresas.SelectedValue);
                //    decimal Total = 0;
                //    decimal Sumatoria = 0;
                //    decimal TotalPasivo = 0;
                //    foreach (DataRow item in Consulta.Rows)
                //    {
                //        Reportes.ImportRow(item);
                //        Sumatoria += (decimal)item["Total"];
                //    }
                //    Total += Sumatoria;
                //    Reportes.Rows.Add(new object[] { 29, "TOTAL ACTIVO CORRIENTE", Sumatoria });
                //    Reportes.Rows.Add(new object[] { 39, "ACTIVO NO CORRIENTE" });
                //    //ACTIVO NO CORRIENTE
                //    Consulta = CapaLogica.BalanceGenerarlActivonoCorriente(comboMesAño.UltimoDiaDelMes(), (int)cboempresas.SelectedValue);
                //    Sumatoria = 0;
                //    foreach (DataRow item in Consulta.Rows)
                //    {
                //        Reportes.ImportRow(item);
                //        Sumatoria += (decimal)item["Total"];
                //    }
                //    Total += Sumatoria;
                //    Reportes.Rows.Add(new object[] { 49, "TOTAL ACTIVO NO CORRIENTE", Sumatoria });
                //    AgregarColumnas(Reportes, 7);
                //    Reportes.Rows.Add(new object[] { 59, "TOTAL ACTIVO ", Total });
                //    //Columna2
                //    Reporte2.Clear();
                //    Reporte2.Rows.Add(new object[] { 49, "PASIVO CORRIENTE" });
                //    TotalPasivo = 0;
                //    decimal TotalPatrimonio = 0;
                //    Consulta = CapaLogica.BalanceGeneralActivoPasivoCorriente(comboMesAño.UltimoDiaDelMes(), (int)cboempresas.SelectedValue);
                //    foreach (DataRow item in Consulta.Rows)
                //    {
                //        Reporte2.ImportRow(item);
                //        TotalPasivo += (decimal)item["Total"];
                //    }
                //    TotalPatrimonio += TotalPasivo;
                //    AgregarColumnas(Reporte2, 5);
                //    Reporte2.Rows.Add(new object[] { 49, "TOTAL PASIVO CORRIENTE", TotalPasivo });
                //    Reporte2.Rows.Add(new object[] { 49, "PASIVO NO CORRIENTE" });
                //    TotalPasivo = 0;
                //    Consulta = CapaLogica.BalanceGeneralActivoPasivonoCorriente(comboMesAño.UltimoDiaDelMes(), (int)cboempresas.SelectedValue);
                //    foreach (DataRow item in Consulta.Rows)
                //    {
                //        Reporte2.ImportRow(item);
                //        TotalPasivo += (decimal)item["Total"];
                //    }
                //    TotalPatrimonio += TotalPasivo;
                //    AgregarColumnas(Reporte2, 2);
                //    Reporte2.Rows.Add(new object[] { 49, "TOTAL PASIVO NO CORRIENTE", TotalPasivo });
                //    Reporte2.Rows.Add(new object[] { 49, "PATRIMONIO" });
                //    TotalPasivo = 0;
                //    Consulta = CapaLogica.BalanceGeneralPatrimonio(comboMesAño.UltimoDiaDelMes(), (int)cboempresas.SelectedValue);
                //    foreach (DataRow item in Consulta.Rows)
                //    {
                //        Reporte2.ImportRow(item);
                //        TotalPasivo += (decimal)item["Total"];
                //    }
                //    TotalPatrimonio += TotalPasivo;
                //    Reporte2.Rows.Add(new object[] { 49, "TOTAL PATRIMONIO", TotalPasivo });
                //    Reporte2.Rows.Add(new object[] { 49, "TOTAL PASIVO Y PATRIMONIO", TotalPatrimonio });

                //    int i = 0;
                //    foreach (DataRow item in Reportes.Rows)
                //    {
                //        item["ix"] = Reporte2.Rows[i].ItemArray[0];
                //        item["campox"] = Reporte2.Rows[i].ItemArray[1];
                //        item["totalx"] = Reporte2.Rows[i].ItemArray[2];
                //        item["empresax"] = Reporte2.Rows[i].ItemArray[3];
                //        i++;
                //    }
                //    //Reportes.Merge(Reporte2);
                //    dtgconten.DataSource = Reportes;

                //    ContarRegistros();
                //    PintarNegroTotales(dtgconten);

                //    if ((decimal)dtgconten[Totalesx.Name, dtgconten.RowCount - 1].Value != (decimal)dtgconten[totalesz.Name, dtgconten.RowCount - 1].Value)
                //    {
                //        msg("Hay Diferencia\nEntre Total de Activo y Total de Patrimonio mas Pasivo");
                //    }
                //}
                //else { msg("no Hay Empresas"); }
            }
            else { msg("no Hay Empresas"); }
            Cursor = Cursors.Default;
        }
        public void AgregarColumnas(DataTable tablita, int length)
        {
            for (int i = 0; i < length; i++)
            {
                tablita.Rows.Add(0);
            }
        }
        private void dtgconten_Sorted(object sender, EventArgs e)
        {
            PintarNegroTotales(dtgconten);
        }
        private void txtfondo_Click(object sender, EventArgs e)
        {
            ColorDialog.Color = ColorFondo;
            if (ColorDialog.ShowDialog() == DialogResult.OK)
            {
                ColorFondo = ColorDialog.Color;
                foreach (DataGridViewCell item in dtgconten.SelectedCells)
                {
                    item.Style.BackColor = ColorFondo;
                    // item.Style.ForeColor = ColorLetra;
                }
            }
        }
        private void txtcolorLetra_Click(object sender, EventArgs e)
        {
            ColorDialog.Color = ColorLetra;
            if (ColorDialog.ShowDialog() == DialogResult.OK)
            {
                ColorLetra = ColorDialog.Color;
                foreach (DataGridViewCell item in dtgconten.SelectedCells)
                {
                    item.Style.ForeColor = ColorLetra;
                }
            }
        }
        private static SISGEM.ModuloContable.frmRevisarCuentasEEFF frmRevisa;
        private void btnDetalleCuentas_Click(object sender, EventArgs e)
        {
            // Intentar obtener el id de empresa de manera segura
            if (!int.TryParse(cboempresas.SelectedValue?.ToString(), out int idEmpresa) || idEmpresa == 0)
            {
                MessageBox.Show("Por favor, seleccione una empresa válida antes de continuar.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (frmRevisa != null && !frmRevisa.IsDisposed)
            {
                frmRevisa.Close();
                frmRevisa.Dispose(); // buena práctica
            }

            frmRevisa = new SISGEM.ModuloContable.frmRevisarCuentasEEFF();
            //frmRevisa.cuo = txtcuo.Text.Trim();
            frmRevisa.idEmpresa = idEmpresa;
            frmRevisa.NombreEmpresa = cboempresas.Text;
            frmRevisa.Fecha = comboMesAño.GetFechaPRimerDia();
            frmRevisa.Show();
        }

        SISGEM.ModuloContable.xfrmCuentasSinUsar frmcuentas;
        private void btnCuentasSinUsar_Click(object sender, EventArgs e)
        {
            if (frmcuentas != null && !frmcuentas.IsDisposed)
            {
                frmcuentas.Close();
                frmcuentas.Dispose(); // buena práctica
            }

            frmcuentas = new SISGEM.ModuloContable.xfrmCuentasSinUsar();
            //frmRevisa.cuo = txtcuo.Text.Trim();
            frmcuentas.Show();
        }

        private void comboMesAño_CambioFechas(object sender, EventArgs e)
        {
            lblfechasReporte.Text = $"Al {comboMesAño.FechaFinMes.ToString("dd")}";
        }

    }
}
