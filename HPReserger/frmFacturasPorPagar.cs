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
    public partial class frmFacturasPorPagar : Form
    {
        public frmFacturasPorPagar()
        {
            InitializeComponent();
        }
        HPResergerCapaLogica.HPResergerCL CLFacturas = new HPResergerCapaLogica.HPResergerCL();
        private void btncancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        int factura = 0, proveedor = 0;
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
                factura = 1;
            else
                factura = 0;
            txtbuscar_TextChanged(sender, e);
        }
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
                proveedor = 1;
            else
                proveedor = 0;
            txtbuscar_TextChanged(sender, e);
        }
        int check = 0;
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
                check = 1;
            else
                check = 0;
            txtbuscar_TextChanged(sender, e);
        }

        private void txtbuscar_TextChanged(object sender, EventArgs e)
        {

            dtgconten.DataSource = CLFacturas.ListarFacturasSinPagar(txtbuscar.Text, factura, proveedor, check, cbodocumento.SelectedIndex.ToString());
        }

        private void cbodocumento_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtbuscar_TextChanged(sender, e);
        }

        private void btnexportarexcel_Click(object sender, EventArgs e)
        {
            if (dtgconten.RowCount > 0)
            {
                ExportarDataGridViewExcel();
                MSG("Exportado con Exito");
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
            hoja_trabajo.Name = "Facturas sin pagar";
            //Recorremos el DataGridView rellenando la hoja de trabajo
            //  hoja_trabajo.Cells[1, 1] = txtetapa.Text; hoja_trabajo.Cells[1, 3] = txtcc.Text; hoja_trabajo.Cells[1, 2] = txtcentro.Text;
            hoja_trabajo.Cells[1, 1] = "FACTURAS SIN PAGAR";
            //   hoja_trabajo.Cells[3, 1] = "Presupuesto";
            //  hoja_trabajo.Cells[4, 1] = "Operaciones";
            //   hoja_trabajo.Cells[5, 1] = "Diferencia";

            //FILAS
            for (int i = 0; i < dtgconten.Rows.Count; i++)
            {
                nume = 0;
                for (int j = 0; j < dtgconten.Columns.Count; j++)
                {

                    hoja_trabajo.Cells[i + 3, nume + 1] = dtgconten.Rows[i].Cells[j].Value.ToString();
                    //  hoja_trabajo.Cells[i + 4, nume + 1] = dtgoperaciones.Rows[i].Cells[j].Value.ToString();
                    // hoja_trabajo.Cells[i + 5, nume + 1] = dtgdiferencia.Rows[i].Cells[j].Value.ToString();
                   
                    nume++;

                }
            }
            numer = 0;
            //COLUMNAS
            for (int contador = 0; contador < dtgconten.ColumnCount; contador++)
            {

                hoja_trabajo.Cells[2, numer + 1] = dtgconten.Columns[contador].HeaderText.ToString();
                hoja_trabajo.Columns[numer + 1].AutoFit();
                numer++;

            }
            hoja_trabajo.Rows[1].Font.Bold = true;
            hoja_trabajo.Rows[2].Font.Bold = true;
            //libros_trabajo.SaveAs(fichero.FileName, Microsoft.Office.Interop.Excel.XlFileFormat.xlWorkbookNormal);
            //libros_trabajo.Close(true);
            //aplicacion.Quit();
            //  }
        }
        public void MSG(string cadena)
        {
            MessageBox.Show(cadena, "HpReserger", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void frmFacturasPorPagar_Load(object sender, EventArgs e)
        {
            cbodocumento.SelectedIndex = 0;
            factura = 1;
            dtgconten.DataSource = CLFacturas.ListarFacturasSinPagar(txtbuscar.Text, factura, proveedor, check, cbodocumento.SelectedIndex.ToString());
        }
    }
}
