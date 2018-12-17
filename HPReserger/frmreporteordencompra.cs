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
    public partial class frmreporteordencompra : FormGradient
    {

        HPResergerCapaLogica.HPResergerCL CReportORden = new HPResergerCapaLogica.HPResergerCL();
        int opcion = 0;
        int articulo = 0;
        int servicio = 0;
        int fecha = 0;
        int anulado = 0;
        int registrado = 0;
        int cotizado = 0;
        int cotizadocompleto = 0;
        int cotizadooc = 0;
        DateTime fechafin, fechainicio;
        public frmreporteordencompra()
        {
            InitializeComponent();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox7.Checked) cotizadocompleto = 1;
            else cotizadocompleto = 0;
            txtbusca_TextChanged(sender, e);
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox4.Checked) anulado = 1;
            else anulado = 0;
            txtbusca_TextChanged(sender, e);
        }

        private void frmreporteordencompra_Load(object sender, EventArgs e)
        {
            articulo = 3; servicio = 1; importe = 0;

            dtinicio.Value = dtfin.Value = fechainicio = fechafin = DateTime.Now;
            txtbusca_TextChanged(sender, e);
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void dtgconten_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton6.Checked)
                opcion = 6;
            txtbusca_TextChanged(sender, e);
        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton7.Checked)
                opcion = 7;
            txtbusca_TextChanged(sender, e);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtdesde_KeyPress(object sender, KeyPressEventArgs e)
        {
            HPResergerFunciones.Utilitarios.SoloNumerosDecimales(e, txtdesde.Text);
        }

        private void txtdesde_KeyDown(object sender, KeyEventArgs e)
        {
            HPResergerFunciones.Utilitarios.ValidarDinero(e, txtdesde);
        }

        private void txthasta_KeyPress(object sender, KeyPressEventArgs e)
        {
            HPResergerFunciones.Utilitarios.SoloNumerosDecimales(e, txthasta.Text);
        }

        private void txthasta_KeyDown(object sender, KeyEventArgs e)
        {
            HPResergerFunciones.Utilitarios.ValidarDinero(e, txthasta);
        }
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
                opcion = 1;
            txtbusca_TextChanged(sender, e);
        }
        decimal aux;
        private void txtbusca_TextChanged(object sender, EventArgs e)
        {
            if (minimo > maximo)
            {
                aux = minimo;
                minimo = maximo;
                maximo = aux;
            }
            if (maximo < minimo)
            {
                aux = maximo;
                maximo = minimo;
                minimo = aux;
            }
            if (fechainicio > fechafin)
            {
                dtgconten.DataSource = CReportORden.ReportedeOC(opcion, articulo, servicio, fecha, fechafin, fechainicio, anulado, registrado, entregadoimcompleto, cotizado, cotizadocompleto, cotizadooc, txtbusca.Text, importe, minimo, maximo);
            }
            else
            {
                dtgconten.DataSource = CReportORden.ReportedeOC(opcion, articulo, servicio, fecha, fechainicio, fechafin, anulado, registrado, cotizado, entregadoimcompleto, cotizadocompleto, cotizadooc, txtbusca.Text, importe, minimo, maximo);
            }
            //////SUMATORIA
            if (dtgconten.RowCount > 0)
            {
                decimal sumatoria = 0.00M;
                for (int i = 0; i < dtgconten.RowCount; i++)
                {
                    sumatoria += decimal.Parse(dtgconten["MONTOCOT.", i].Value.ToString());
                }
                txtsumatoria.Text = sumatoria.ToString();
            }
            else
            {
                txtsumatoria.Text = "0.00";
                dtgconten1.DataSource = null;
            }
            ContarRegistros(dtgconten);
        }

        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            txtbusca.Text = "";
        }

        private void dtinicio_ValueChanged(object sender, EventArgs e)
        {
            fechainicio = dtinicio.Value;
            txtbusca_TextChanged(sender, e);
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
                opcion = 2;
            txtbusca_TextChanged(sender, e);
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked)
                opcion = 3;
            txtbusca_TextChanged(sender, e);
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton4.Checked)
                opcion = 4;
            txtbusca_TextChanged(sender, e);
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton5.Checked)
                opcion = 5;
            txtbusca_TextChanged(sender, e);
        }

        private void radioButton8_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton8.Checked)
                opcion = 8;
            txtbusca_TextChanged(sender, e);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
                articulo = 6;
            else articulo = 3;
            txtbusca_TextChanged(sender, e);
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked) servicio = 2;
            else servicio = 1;
            txtbusca_TextChanged(sender, e);
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked) fecha = 1;
            else fecha = 0;
            txtbusca_TextChanged(sender, e);
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox5.Checked) registrado = 1;
            else registrado = 0;
            txtbusca_TextChanged(sender, e);
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox6.Checked) cotizado = 1;
            else cotizado = 0;
            txtbusca_TextChanged(sender, e);
        }

        private void checkBox8_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox8.Checked) cotizadooc = 1;
            else cotizadooc = 0;
            txtbusca_TextChanged(sender, e);
        }
        int importe = 0;
        decimal minimo = 0.00m;
        decimal maximo = 1000.00m;

        private void txtdesde_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtdesde.Text))
                minimo = decimal.Parse(txtdesde.Text);
            else minimo = 0.00m;
            txtbusca_TextChanged(sender, e);
        }

        private void txthasta_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txthasta.Text))
                maximo = decimal.Parse(txthasta.Text);
            else maximo = 0.00m;
            txtdesde_TextChanged(sender, e);
        }

        private void radioButton9_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton9.Checked)
                opcion = 9;
            txtbusca_TextChanged(sender, e);
        }
        int entregadoimcompleto = 0;
        private void checkBox10_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox10.Checked) entregadoimcompleto = 1;
            else entregadoimcompleto = 0;
            txtbusca_TextChanged(sender, e);
        }
        int op;
        private void dtgconten_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (dtgconten["TIPO", e.RowIndex].Value.ToString() == "ARTICULO") op = 1;
            else op = 0;
            if (dtgconten.RowCount > 0)
                dtgconten1.DataSource = CReportORden.reportepedidodetalle(op, Convert.ToInt32(dtgconten["nroPED.", e.RowIndex].Value.ToString()));
            else
                dtgconten1.DataSource = null;
        }

        private void checkBox9_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox9.Checked) importe = 1;
            else importe = 0;
            txtbusca_TextChanged(sender, e);
        }

        private void dtgconten_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {

        }
        public void ContarRegistros(DataGridView tablita)
        {
            lblmsg.Text = "Total Registros: " + tablita.RowCount;
        }

        private void radioButton10_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton10.Checked)
                opcion = 0;
            txtbusca_TextChanged(sender, e);
        }

        private void btnexcel_Click(object sender, EventArgs e)
        {
            if (dtgconten.RowCount > 0)
            {
                ExportarDataGridViewExcel();
                msg("Exportado con Exito");
            }
            else
                msg("No hay Filas para Exportar");
        }
        public void msg(string cadena)
        {
            MessageBox.Show(cadena, CompanyName ,MessageBoxButtons.OK, MessageBoxIcon.Question);

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
            hoja_trabajo.Name = "Ordenes de Compra";
            //Recorremos el DataGridView rellenando la hoja de trabajo
            hoja_trabajo.Cells[1, 1] = "Ordenes de Compra";
            for (int i = 0; i < dtgconten.Rows.Count; i++)
            {
                nume = 0;
                for (int j = 0; j < dtgconten.Columns.Count; j++)
                {

                    hoja_trabajo.Cells[i + 3, nume + 1] = dtgconten.Rows[i].Cells[j].Value.ToString();
                    nume++;

                }
            }
            numer = 0;
            for (int contador = 0; contador < dtgconten.ColumnCount; contador++)
            {

                hoja_trabajo.Cells[2, numer + 1] = dtgconten.Columns[contador].HeaderText.ToString();
                hoja_trabajo.Columns[numer + 1].AutoFit();
                numer++;

            }
            hoja_trabajo.Rows[1].Font.Bold = true;
            hoja_trabajo.Rows[2].Font.Bold = true;
            hoja_trabajo.Columns[1].Font.Bold = true;
            //libros_trabajo.SaveAs(fichero.FileName, Microsoft.Office.Interop.Excel.XlFileFormat.xlWorkbookNormal);
            //libros_trabajo.Close(true);
            //aplicacion.Quit();
            //  }
        }
        private void dtfin_ValueChanged(object sender, EventArgs e)
        {
            fechafin = dtfin.Value;
            txtbusca_TextChanged(sender, e);
        }
    }
}
