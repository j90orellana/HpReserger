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
    public partial class frmReporteGeneral : Form
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
        public void msg(string cadena)
        {
            MessageBox.Show(cadena, "HpReserger", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

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
        private void btnexportarexcel_Click(object sender, EventArgs e)
        {
            if (dtgconten.RowCount > 0)
            {
                Cursor = Cursors.WaitCursor;
                frmProcesando frmproce = new HPReserger.frmProcesando();
                frmproce.Show();
                string _NombreHoja = "BALANCE GENERAL";
                List<HPResergerFunciones.Utilitarios.RangoCelda> ListaCeldas = new List<HPResergerFunciones.Utilitarios.RangoCelda>();
                HPResergerFunciones.Utilitarios.RangoCelda Celda1 = new HPResergerFunciones.Utilitarios.RangoCelda("a1", "d1", cboempresas.Text, 14);
                ListaCeldas.Add(Celda1);
                HPResergerFunciones.Utilitarios.RangoCelda Celda2 = new HPResergerFunciones.Utilitarios.RangoCelda("a2", "d2", "ESTADO DE SITUACIÓN FINANCIERA", 12);
                ListaCeldas.Add(Celda2);
                HPResergerFunciones.Utilitarios.RangoCelda Celda3 = new HPResergerFunciones.Utilitarios.RangoCelda("a3", "d3", $"Al {comboMesAño.UltimoDiaDelMes().ToString("dd")} de {comboMesAño.GetFecha().ToString("MMMM")} del {comboMesAño.GetFecha().Year}");
                ListaCeldas.Add(Celda3);
                HPResergerFunciones.Utilitarios.RangoCelda Celda4 = new HPResergerFunciones.Utilitarios.RangoCelda("a4", "d4", $"(Expresado en Soles)");
                ListaCeldas.Add(Celda4);
                HPResergerFunciones.Utilitarios.ExportarAExcelOrdenandoColumnas(dtgconten, "", _NombreHoja, ListaCeldas, 5, new int[] { 2, 3, 6, 7 }, new int[] { 1, 2, 15, 16, 22, 23, 29, 30 }, new int[] { });
                Cursor = Cursors.Default;
                frmproce.Close();
            }
            else msg("No hay datos para Exportar");
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
                if (item.Cells[indexx.Name].Value.ToString().Substring(1) == "9" || item.Cells[indez.Name].Value.ToString().Substring(1) == "9")
                {
                    foreach (DataGridViewCell Celda in item.Cells)
                    {
                        Celda.Style.BackColor = Color.FromArgb(198, 239, 206);//255, 255, 153
                        Celda.Style.ForeColor = Color.FromArgb(0, 97, 0);//.Blue;
                        Celda.Style.Font = new Font(dtgconten.Font, FontStyle.Bold);
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
        private void btnGenerar_Click(object sender, EventArgs e)
        {
            if (comboMesAño.GetFecha().Year >= DateTime.Now.Year && comboMesAño.GetFecha().Month >= DateTime.Now.Month)
            {
                msg("Mes no está Cerrado");
                Reportes.Clear();
                return;
            }

            if (cboempresas.Items.Count > 0)
            {
                Reportes.Clear();
                Reportes.Rows.Add(new object[] { 19, "ACTIVO CORRIENTE" });
                //ACTIVO CORRIENTE
                Consulta = CapaLogica.BalanceGenerarlActivoCorriente(comboMesAño.UltimoDiaDelMes(), (int)cboempresas.SelectedValue);
                decimal Total = 0;
                decimal Sumatoria = 0;
                decimal TotalPasivo = 0;
                foreach (DataRow item in Consulta.Rows)
                {
                    Reportes.ImportRow(item);
                    Sumatoria += (decimal)item["Total"];
                }
                Total += Sumatoria;
                Reportes.Rows.Add(new object[] { 29, "TOTAL ACTIVO CORRIENTE", Sumatoria });
                Reportes.Rows.Add(new object[] { 39, "ACTIVO NO CORRIENTE" });
                //ACTIVO NO CORRIENTE
                Consulta = CapaLogica.BalanceGenerarlActivonoCorriente(comboMesAño.UltimoDiaDelMes(), (int)cboempresas.SelectedValue);
                Sumatoria = 0;
                foreach (DataRow item in Consulta.Rows)
                {
                    Reportes.ImportRow(item);
                    Sumatoria += (decimal)item["Total"];
                }
                Total += Sumatoria;
                Reportes.Rows.Add(new object[] { 49, "TOTAL ACTIVO NO CORRIENTE", Sumatoria });
                AgregarColumnas(Reportes, 7);
                Reportes.Rows.Add(new object[] { 59, "TOTAL ACTIVO ", Total });

                //Columna2
                Reporte2.Clear();
                Reporte2.Rows.Add(new object[] { 49, "PASIVO CORRIENTE" });
                TotalPasivo = 0;
                decimal TotalPatrimonio = 0;
                Consulta = CapaLogica.BalanceGeneralActivoPasivoCorriente(comboMesAño.UltimoDiaDelMes(), (int)cboempresas.SelectedValue);
                foreach (DataRow item in Consulta.Rows)
                {
                    Reporte2.ImportRow(item);
                    TotalPasivo += (decimal)item["Total"];
                }
                TotalPatrimonio += TotalPasivo;
                AgregarColumnas(Reporte2, 5);
                Reporte2.Rows.Add(new object[] { 49, "TOTAL PASIVO CORRIENTE", TotalPasivo });
                Reporte2.Rows.Add(new object[] { 49, "PASIVO NO CORRIENTE" });
                TotalPasivo = 0;
                Consulta = CapaLogica.BalanceGeneralActivoPasivonoCorriente(comboMesAño.UltimoDiaDelMes(), (int)cboempresas.SelectedValue);
                foreach (DataRow item in Consulta.Rows)
                {
                    Reporte2.ImportRow(item);
                    TotalPasivo += (decimal)item["Total"];
                }
                TotalPatrimonio += TotalPasivo;
                AgregarColumnas(Reporte2, 1);
                Reporte2.Rows.Add(new object[] { 49, "TOTAL PASIVO NO CORRIENTE", TotalPasivo });
                Reporte2.Rows.Add(new object[] { 49, "PATRIMONIO" });
                TotalPasivo = 0;
                Consulta = CapaLogica.BalanceGeneralPatrimonio(comboMesAño.UltimoDiaDelMes(), (int)cboempresas.SelectedValue);
                foreach (DataRow item in Consulta.Rows)
                {
                    Reporte2.ImportRow(item);
                    TotalPasivo += (decimal)item["Total"];
                }
                TotalPatrimonio += TotalPasivo;
                Reporte2.Rows.Add(new object[] { 49, "TOTAL PATRIMONIO", TotalPasivo });
                Reporte2.Rows.Add(new object[] { 49, "TOTAL PASIVO Y PATRIMONIO", TotalPatrimonio });

                int i = 0;
                foreach (DataRow item in Reportes.Rows)
                {
                    item["ix"] = Reporte2.Rows[i].ItemArray[0];
                    item["campox"] = Reporte2.Rows[i].ItemArray[1];
                    item["totalx"] = Reporte2.Rows[i].ItemArray[2];
                    item["empresax"] = Reporte2.Rows[i].ItemArray[3];
                    i++;
                }

                //Reportes.Merge(Reporte2);
                dtgconten.DataSource = Reportes;
                ContarRegistros();
                PintarNegroTotales(dtgconten);

                if ((decimal)dtgconten[Totalesx.Name, dtgconten.RowCount - 1].Value != (decimal)dtgconten[totalesz.Name, dtgconten.RowCount - 1].Value)
                {
                    msg("Hay Diferencia\nEntre Total de Activo y Total de Patrimonio mas Pasivo");
                }
            }
            else { msg("no Hay Empresas"); }
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

        private void comboMesAño_CambioFechas(object sender, EventArgs e)
        {
            lblfechasReporte.Text = $"Al {comboMesAño.FechaFinMes.ToString("dd")}";
        }
    }
}
