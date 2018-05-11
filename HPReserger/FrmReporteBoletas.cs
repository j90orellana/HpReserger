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
    public partial class FrmReporteBoletas : Form
    {
        public FrmReporteBoletas()
        {
            InitializeComponent();
        }
        HPResergerCapaLogica.HPResergerCL CapaLogica = new HPResergerCapaLogica.HPResergerCL();
        public void cargarempresas()
        {
            cboempresa.ValueMember = "codigo";
            cboempresa.DisplayMember = "descripcion";
            cboempresa.DataSource = CapaLogica.getCargoTipoContratacion("Id_empresa", "empresa", "tbl_empresa");
        }
        private void btnrecempresa_Click(object sender, EventArgs e)
        {
            cargarempresas();
        }
        DataTable TablaTipoID;
        public void CargarTiposID(string tabla)
        {
            TablaTipoID = new DataTable();
            TablaTipoID = CapaLogica.CualquierTabla(tabla, "Desc_Tipo_ID", "RUC");
            cbotipoid.DisplayMember = "Desc_Tipo_ID";
            cbotipoid.ValueMember = "Codigo_Tipo_ID";
            cbotipoid.DataSource = TablaTipoID;
        }
        public void ModificarTamañoTipo(TextBox txt, int index)
        {
            if (index >= 0 && TablaTipoID != null)
            {
                DataRow Filita = TablaTipoID.Rows[index];
                txt.MaxLength = (int)Filita["Length"];
            }
        }
        private void FrmReporteBoletas_Load(object sender, EventArgs e)
        {
            cargarempresas();
            CargarTiposID("TBL_Tipo_ID");
        }
        int EMPRESA = 0;
        private void chkempresa_CheckedChanged(object sender, EventArgs e)
        {
            if (!chkempresa.Checked)
            {
                cboempresa.Enabled = false;
                btnrecempresa.Enabled = false;
                EMPRESA = 0;
            }
            else
            {
                cboempresa.Enabled = true;
                btnrecempresa.Enabled = true;
                EMPRESA = (int)cboempresa.SelectedValue;
            }
        }

        private void cboempresa_SelectedIndexChanged(object sender, EventArgs e)
        {
            EMPRESA = (int)cboempresa.SelectedValue;
        }
        int FECHA = 0;
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                comboMesAño1.Enabled = comboMesAño2.Enabled = true;
                FECHA = 1;
            }
            else
            {
                comboMesAño1.Enabled = comboMesAño2.Enabled = false;
                FECHA = 0;
            }
        }
        int TIPO = 0;
        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                TIPO = (int)cbotipoid.SelectedValue;
                cbotipoid.Enabled = txtnumero.Enabled = true;
            }
            else
            {
                cbotipoid.Enabled = txtnumero.Enabled = false;
                TIPO = 0;
            }
        }

        private void btngenerar_Click(object sender, EventArgs e)
        {
            DateTime inicio, fin;
            if (comboMesAño1.GetFechaPRimerDia() > comboMesAño2.GetFechaPRimerDia())
            {
                inicio = comboMesAño2.GetFechaPRimerDia();
                fin = comboMesAño1.GetFechaPRimerDia();
            }
            else
            {
                inicio = comboMesAño1.GetFechaPRimerDia();
                fin = comboMesAño2.GetFechaPRimerDia();
            }
            dtgconten.DataSource = CapaLogica.ReporteBoletas(EMPRESA, TIPO, txtnumero.Text, FECHA, inicio, fin);
        }

        private void cbotipoid_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
                TIPO = (int)cbotipoid.SelectedValue;
            else { TIPO = 0; }
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        frmProcesando frmproce;
        private void btnexportar_Click(object sender, EventArgs e)
        {
            if (dtgconten.RowCount > 0)
            {
                frmproce = new frmProcesando();
                Cursor = Cursors.WaitCursor;
                frmproce.Show();
                if (!backgroundWorker1.IsBusy)
                {
                    backgroundWorker1.RunWorkerAsync();
                }
            }
            else
                msg("No hay Filas para Exportar");
        }
        public void msg(string cadena)
        {
            MessageBox.Show(cadena, "HpReserger", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            List<HPResergerFunciones.Utilitarios.NombreCelda> Celditas = new List<HPResergerFunciones.Utilitarios.NombreCelda>();
            HPResergerFunciones.Utilitarios.NombreCelda Celdita = new HPResergerFunciones.Utilitarios.NombreCelda();
            Celdita.fila = 1; Celdita.columna = 1; Celdita.Nombre = "Reporte de Boletas de Pagos";
            Celditas.Add(Celdita);
            //HPResergerFunciones.Utilitarios.ExportarAExcel(dtgconten, "", "Reporte de Boletas", Celditas, 1, new int[] { }, new int[] { 1 }, new int[] { 1 });
            HPResergerFunciones.Utilitarios.ExportarAExcelOrdenandoColumnas(dtgconten, "", "Reporte de Boletas", Celditas, 1, new int[] { 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 1, 2, 3, 4, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31, 32, 33, 34, 35, 36, 37, 38, 39, 40, 41, 42, 43, 44, 45, 46, 47, 48, 49, 50, 51, 52, 53, 54, 55, 56 }, new int[] { 1 }, new int[] { 1 }, dtgconten.RowCount);
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            Cursor = Cursors.Default;
            frmproce.Close();
            msg("Exportado con Exito");
        }
    }
}
