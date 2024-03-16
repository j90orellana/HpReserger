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
    public partial class EstadoGananciaPerdidas : FormGradient
    {
        public EstadoGananciaPerdidas()
        {
            InitializeComponent();
        }
        public void msg(string cadena) { HPResergerFunciones.frmInformativo.MostrarDialogError(cadena); }
        public void msgOK(string cadena) { HPResergerFunciones.frmInformativo.MostrarDialog(cadena); }

        HPResergerCapaLogica.HPResergerCL CapaLogica = new HPResergerCapaLogica.HPResergerCL();
        private void label2_TextChanged(object sender, EventArgs e)
        {
            //CentrarObjeto(lblfechasReporte);
        }
        public void CentrarObjeto(Control control)
        {
            control.Location = new Point((this.Width / 2) - (control.Width / 2), control.Location.Y);
        }
        public Color ColorFondo;
        public Color ColorLetra;
        private void dtgconten_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            ContarRegistros();
            ColorFondo = btnColorFondo.BackColor = dtgconten[e.ColumnIndex, e.RowIndex].Style.BackColor;
            ColorLetra = btnColorLetra.ForeColor = dtgconten[e.ColumnIndex, e.RowIndex].Style.ForeColor;
        }
        public void ContarRegistros()
        {
            lblconteo.Text = $"Número de Registros: {dtgconten.RowCount}";
        }
        public Color FondoSeleccionados = Color.FromArgb(198, 239, 206);
        public Color ForeSeleccionados = Color.FromArgb(0, 97, 0);
        public void PintarNegroTotales(DataGridView grid)
        {
            foreach (DataGridViewRow item in grid.Rows)
            {
                if (item.Cells[indexx.Name].Value.ToString().Substring(2) == "99" || item.Cells[indexx.Name].Value.ToString().Substring(3) == "0")
                {
                    foreach (DataGridViewCell Celda in item.Cells)
                    {
                        Celda.Style.BackColor = FondoSeleccionados; //255, 255, 153
                        Celda.Style.ForeColor = ForeSeleccionados;//.Blue;
                        //Celda.Style.BackColor = Color.FromArgb(255, 255, 153);
                        //Celda.Style.ForeColor = Color.Blue;
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
        DataTable Reportes;
        private void btnGenerar_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            DataTable Datitos = CapaLogica.Periodos(5, (int)cboempresas.SelectedValue, comboMesAño.GetFecha());
            if (Datitos.Rows.Count == 0)
            {
                Reportes.Clear();
                msg("Periodo no está Creado");
                return;
            }
            DataRow filita = Datitos.Rows[0];
            if ((int)filita["estado"] == 3)
            {
                msg("Periodo Cerrado");
            }
            //if (comboMesAño.GetFecha().Year >= DateTime.Now.Year && comboMesAño.GetFecha().Month >= DateTime.Now.Month)
            //{
            //    msg("Mes no está Cerrado");
            //    Reportes.Clear();
            //    return;
            //}

            if (cboempresas.Items.Count > 0)
            {
                Reportes = CapaLogica.EstadodeGanaciasPerdidas(comboMesAño.UltimoDiaDelMes(), (int)cboempresas.SelectedValue);
                dtgconten.DataSource = Reportes;
                ContarRegistros();
                PintarNegroTotales(dtgconten);
            }
            else { msg("no Hay Empresas"); }
            Cursor = Cursors.Default;
        }      
        private void EstadoGananciaPerdidas_Load(object sender, EventArgs e)
        {
            CapaLogica.CambiarBase(frmLogin.Basedatos);
            Reportes = new DataTable();
            cboempresas.DataSource = CapaLogica.getCargoTipoContratacion2("Id_Empresa", "Empresa", "TBL_Empresa");
            cboempresas.DisplayMember = "descripcion";
            cboempresas.ValueMember = "codigo";
            //cargarAños();
            ColorFondo = btnColorFondo.BackColor;
            ColorLetra = btnColorLetra.ForeColor;
            dtgconten.ColumnHeadersDefaultCellStyle.BackColor = FondoSeleccionados;
            dtgconten.ColumnHeadersDefaultCellStyle.ForeColor = ForeSeleccionados;
            comboMesAño.Fecha(DateTime.Now.AddMonths(-1));
        }
        // DataTable años;
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
            catch (StackOverflowException)
            {
                throw;
            }

            //       If e.Index >= 0 Then
            //   Using st As New StringFormat With {.Alignment = StringAlignment.Center}
            //       e.Graphics.DrawString(sender.Items(e.Index).ToString, e.Font, Brushes.Black, e.Bounds, st)
            //   End Using
            //End If
        }

        private void comboaño_DrawItem(object sender, DrawItemEventArgs e)
        {
            try
            {
                if (e.Index >= 0)
                {
                    StringFormat st = new StringFormat();
                    st.Alignment = StringAlignment.Center;
                    // comboaño.SelectedIndex = e.Index;
                    // e.Graphics.DrawString(comboaño.Text, e.Font, Brushes.Black, e.Bounds, st);
                }
            }
            catch (StackOverflowException)
            {
                throw;
            }

        }
        frmProcesando frmproce;
        String Empresa = "";
        DateTime ultimodiadelmes, getfecha;
        private void btnexportarexcel_Click(object sender, EventArgs e)
        {
            if (dtgconten.RowCount > 0)
            {
                Cursor = Cursors.WaitCursor;
                frmproce = new HPReserger.frmProcesando();
                frmproce.Show();
                Empresa = cboempresas.Text;
                ultimodiadelmes = comboMesAño.UltimoDiaDelMes();
                getfecha = comboMesAño.GetFecha();
                if (!backgroundWorker1.IsBusy)
                {
                    backgroundWorker1.RunWorkerAsync();
                }
            }
            else
            {
                msg("No hay Datos que Exportar");
            }
        }
        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            string _NombreHoja = "ESTADO DE RESULTADO INTEGRAL";
            List<HPResergerFunciones.Utilitarios.RangoCelda> ListaCeldas = new List<HPResergerFunciones.Utilitarios.RangoCelda>();
            HPResergerFunciones.Utilitarios.RangoCelda Celda1 = new HPResergerFunciones.Utilitarios.RangoCelda("a1", "b1", Empresa, 14);
            ListaCeldas.Add(Celda1);
            HPResergerFunciones.Utilitarios.RangoCelda Celda2 = new HPResergerFunciones.Utilitarios.RangoCelda("a2", "b2", "ESTADO DE RESULTADO INTEGRAL", 12);
            ListaCeldas.Add(Celda2);
            HPResergerFunciones.Utilitarios.RangoCelda Celda3 = new HPResergerFunciones.Utilitarios.RangoCelda("a3", "b3", $"Al {ultimodiadelmes.ToString("dd")} de {getfecha.ToString("MMMM")} del {getfecha.Year}");
            ListaCeldas.Add(Celda3);
            HPResergerFunciones.Utilitarios.RangoCelda Celda4 = new HPResergerFunciones.Utilitarios.RangoCelda("a4", "b4", $"(Expresado en Soles)");
            ListaCeldas.Add(Celda4);
            HPResergerFunciones.Utilitarios.ExportarAExcelOrdenandoColumnas(dtgconten, "", _NombreHoja, ListaCeldas, 5, new int[] { 2, 3 }, new int[] { }, new int[] { });
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            Cursor = Cursors.Default;
            frmproce.Close();
        }
        private void btncancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnexportarpdf_Click(object sender, EventArgs e)
        {
            if (dtgconten.RowCount > 0)
            {
                frmReporteEstadoPerdidas ReporteEstado = new frmReporteEstadoPerdidas();
                ReporteEstado.Icon = Icon;
                ReporteEstado.año = comboMesAño.UltimoDiaDelMes();
                ReporteEstado.empresa = (int)cboempresas.SelectedValue;
                ReporteEstado.NombreEmpresa = cboempresas.Text;
                ReporteEstado.Show();
            }
        }

        private void txtfondo_TextChanged(object sender, EventArgs e)
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

        private void txtcolorLetra_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboMesAño_CambioFechas(object sender, EventArgs e)
        {
            lblfechasReporte.Text = $"Al {comboMesAño.FechaFinMes.ToString("dd")}";
        }


    }
}
