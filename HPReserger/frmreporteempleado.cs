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
using Microsoft.Office.Interop.Excel;
using System.Reflection;

namespace HPReserger
{
    public partial class frmreporteempleado : Form
    {
        public frmreporteempleado()
        {
            InitializeComponent();
        }
        HPResergerCapaLogica.HPResergerCL Creporempleado = new HPResergerCapaLogica.HPResergerCL();
        DateTime fechainicio, fechafin;
        private void frmreporteempleado_Load(object sender, EventArgs e)
        {
            dtinicio.Value = dtfin.Value = fechainicio = fechafin = DateTime.Now;
            opcion = 2; opciones = 1;
            Cargarentidad(cbobanco);
            cbobanco.SelectedItem = 0;
            txtbusca_TextChanged(sender, e);

        }
        int banco = 0;
        private void Cargarentidad(ComboBox combito)
        {
            combito.DataSource = Creporempleado.ListarBancosCts();
            combito.DisplayMember = "descripcion";
            combito.ValueMember = "codigo";
        }

        private void cbotipo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        public void MSG(string cadena)
        {
            MessageBox.Show(cadena, "HpReserger", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        int sueldo = 0;
        decimal minimo = 0.00m;
        decimal maximo = 1000.00m;
        private void txthasta_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txthasta.Text))
                maximo = decimal.Parse(txthasta.Text);
            else maximo = 0.00m;
            txtdesde_TextChanged(sender, e);
        }
        private void txtdesde_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtdesde.Text))
                minimo = decimal.Parse(txtdesde.Text);
            else minimo = 0.00m;
            txtbusca_TextChanged(sender, e);
        }
        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            txtbusca.Text = "";
        }
        decimal aux;
        int dni, carnet, pasa, cedula, ruc = 0;
        private void checkBox9_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox9.Checked)
                dni = 1;
            else dni = 0;
            txtbusca_TextChanged(sender, e);
        }
        int practicas, planillaempleado, planillaobrero, recibohono = 0;
        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox4.Checked)
                recibohono = 1;
            else recibohono = 0;
            txtbusca_TextChanged(sender, e);
        }
        private void checkBox11_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox11.Checked)
                sueldo = 1;
            else sueldo = 0;
            txtbusca_TextChanged(sender, e);
        }
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
                opcion = 2;
            else opcion = 0;
            txtbusca_TextChanged(sender, e);
        }
        int opcion = 0;
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
                opcion = 1;
            else opcion = 0;
            txtbusca_TextChanged(sender, e);
        }
        int opciones = 0;
        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton4.Checked)
                opciones = 1;
            else opciones = 0;
            txtbusca_TextChanged(sender, e);
        }
        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked)
            {
                checkBox1.Enabled = checkBox4.Enabled = false;
                opciones = 2;
            }
            else
            {
                opciones = 0;
                checkBox1.Enabled = checkBox4.Enabled = true;
            }
            txtbusca_TextChanged(sender, e);
        }
        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton5.Checked)
                opciones = 3;
            else opciones = 0;
            txtbusca_TextChanged(sender, e);
        }

        private void dtinicio_ValueChanged(object sender, EventArgs e)
        {
            fechainicio = dtinicio.Value;
            txtbusca_TextChanged(sender, e);
            txtbusca_TextChanged(sender, e);
        }

        private void dtfin_ValueChanged(object sender, EventArgs e)
        {
            fechafin = dtfin.Value;
            txtbusca_TextChanged(sender, e);
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked)
                planillaobrero = 1;
            else planillaobrero = 0;
            txtbusca_TextChanged(sender, e);
        }
        int fecha = 0;
        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox5.Checked)
                fecha = 1;
            else fecha = 0;
            txtbusca_TextChanged(sender, e);
        }
        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton6.Checked)
                opcion = 3;
            else opcion = 0;
            txtbusca_TextChanged(sender, e);
        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton7.Checked)
                opcion = 4;
            else opcion = 0;
            txtbusca_TextChanged(sender, e);
        }

        private void dtgconten_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void groupBox5_Enter(object sender, EventArgs e)
        {

        }

        private void radioButton8_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton8.Checked)
            {
                opciones = 4; checkBox1.Enabled = checkBox4.Enabled = false; btnexportarplano.Visible = true; gpbanco.Visible = true;
            }
            else
            {
                opciones = 0; checkBox1.Enabled = checkBox4.Enabled = true; btnexportarplano.Visible = false; gpbanco.Visible = false;
            }
            txtbusca_TextChanged(sender, e);
        }
        StreamWriter st, stx;
        private void btnexportarplano_Click(object sender, EventArgs e)
        {
            if (dtgconten.RowCount > 0)
            {
                SaveFileCts.FileName = "Cts " + DateTime.Now.ToLongDateString();

                if (SaveFileCts.FileName != string.Empty && SaveFileCts.ShowDialog() == DialogResult.OK)
                {
                    string path = SaveFileCts.FileName;
                    ///if (File.Exists(path)) st = File.AppendText(path);
                    //else
                    //string patchxls;
                    // patchxls = path.Substring(0, path.Length - 3) + "xls";
                    //MSG(path + (char)13+ patchxls);
                    st = File.CreateText(path);
                    // stx = File.CreateText(patchxls);
                    string cadenita = "";
                    //     string cadenaxls = "";
                    for (int i = 0; i < dtgconten.RowCount; i++)
                    {
                        for (int j = 0; j < dtgconten.ColumnCount - 1; j++)
                        {
                            cadenita = cadenita + dtgconten[j, i].Value.ToString() + "|";
                            //          cadenaxls += dtgconten[j, i].Value.ToString() + (char)9;
                        }
                        cadenita = cadenita + dtgconten[dtgconten.ColumnCount - 1, i].Value.ToString() + (char)(13);
                        //     cadenaxls += dtgconten[dtgconten.ColumnCount - 1, i].Value.ToString() + (char)(13);
                    }
                    st.Write(cadenita);
                    st.Close();
                    //  stx.Write(cadenaxls);
                    //   stx.Close();
                    //ExportarExcel(dtgconten, patchxls);

                    MSG("Guardando");
                }
                else
                {
                    //  MSG("Ingrese nombre del archivo");
                }
            }
            else
            {
                MSG("Reporte esta vacio");
            }
        }

        private void btnexportaexcel_Click(object sender, EventArgs e)
        {
            ExportarExcel(dtgconten, "");
        }

        private void checkBox12_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox12.Checked)
                banco = 1;
            else banco = 0;
            txtbusca_TextChanged(sender, e);
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
            for (int contador = 0; contador < grilla.ColumnCount; contador++)
            {
                arangito = ws.get_Range(((char)(65 + contador) + "" + (1)).ToString());
                arangito.Value2 = grilla.Columns[contador].HeaderText.ToString();
            }
            for (int i = 0; i < grilla.RowCount; i++)
            {
                for (int j = 0; j < grilla.ColumnCount - 1; j++)
                {
                    arangito = ws.get_Range(((char)(65 + j) + "" + (i + 2)).ToString());//, (char)(65 + j) +""+ (i + 1));

                    if (arangito == null)
                    {
                        // MSG("Could not get a range. Check to be sure you have the correct versions of the office DLLs.");
                        return;
                    }
                    arangito.Value2 = grilla[j, i].Value.ToString();
                }
                arangito = ws.get_Range((char)(65 + grilla.ColumnCount - 1) + "" + (i + 2));//, (char)(65 + grilla.ColumnCount - 1) +""+ (i + 1));
                arangito.Value2 = grilla[grilla.ColumnCount - 1, i].Value.ToString();
            }
            try
            {
                xlApp.SaveWorkspace(path);
            }
            catch { }
        }

        private void cbobanco_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtbusca_TextChanged(sender, e);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Cargarentidad(cbobanco);
        }
       
        private void dtgconten_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Clipboard.SetText(dtgconten[e.ColumnIndex, e.RowIndex].Value.ToString());
            MSG("Celda Copiada");
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
                planillaempleado = 1;
            else planillaempleado = 0;
            txtbusca_TextChanged(sender, e);
        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
                practicas = 1;
            else practicas = 0;
            txtbusca_TextChanged(sender, e);
        }
        private void checkBox10_CheckedChanged(object sender, EventArgs e)
        {

            if (checkBox10.Checked)
                ruc = 1;
            else ruc = 0;
            txtbusca_TextChanged(sender, e);
        }
        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox6.Checked)
                cedula = 1;
            else cedula = 0;
            txtbusca_TextChanged(sender, e);
        }
        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox7.Checked)
                pasa = 1;
            else pasa = 0;
            txtbusca_TextChanged(sender, e);
        }
        private void checkBox8_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox8.Checked)
                carnet = 1;
            else carnet = 0;
            txtbusca_TextChanged(sender, e);
        }
        int codbanco = 0;
        private void txtbusca_TextChanged(object sender, EventArgs e)
        {
            if (cbobanco.SelectedValue == null)
                codbanco = 0;
            if (checkBox12.Checked)
            {
                codbanco = Int32.Parse(cbobanco.SelectedValue.ToString());
            }
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
                dtgconten.DataSource = Creporempleado.Reporteempleados(opcion, opciones, txtbusca.Text, dni, carnet, pasa, cedula, ruc, practicas, planillaempleado, planillaobrero, recibohono, sueldo, minimo, maximo, fecha, fechafin, fechainicio, banco, codbanco.ToString());
            }
            else
            {
                dtgconten.DataSource = Creporempleado.Reporteempleados(opcion, opciones, txtbusca.Text, dni, carnet, pasa, cedula, ruc, practicas, planillaempleado, planillaobrero, recibohono, sueldo, minimo, maximo, fecha, fechainicio, fechafin, banco, codbanco.ToString());
            }
            //////SUMATORIA
            if (dtgconten.RowCount > 0)
            {
                decimal sumatoria = 0.00M;
                for (int i = 0; i < dtgconten.RowCount; i++)
                {
                    sumatoria += decimal.Parse(dtgconten["Sueldo", i].Value.ToString());
                }
                txtsumatoria.Text = sumatoria.ToString();
            }
            else
                txtsumatoria.Text = "0.00";
            ContarRegistros(dtgconten);
        }
        public void ContarRegistros(DataGridView tablita)
        {
            lblmsg.Text = "Total Registros: " + tablita.RowCount;
        }
    }
}
