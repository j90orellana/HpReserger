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
    public partial class Frmreporteop : Form
    {
        public Frmreporteop()
        {
            InitializeComponent();
        }
        HPResergerCapaLogica.HPResergerCL Creporteop = new HPResergerCapaLogica.HPResergerCL();
        private void button1_Click(object sender, EventArgs e)
        {
            txtbusca.Text = "";
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        int opcion = 0;
        int articulo = 0;
        int servicio = 0;
        int fecha = 0;
        int anulado = 0;
        int registrado = 0;
        int cotizado = 0;
        int cotizadocompleto = 0;
        int cotizadooc = 0;
        private void Frmreporteop_Load(object sender, EventArgs e)
        {
            articulo = 3; servicio = 1;
            dtinicio.Value = dtfin.Value = fechainicio = fechafin = DateTime.Now;
            txtbusca_TextChanged(sender, e);
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
                opcion = 1;
            txtbusca_TextChanged(sender, e);
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
                opcion = 2;
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
        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox4.Checked) anulado = 1;
            else anulado = 0;
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

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox7.Checked) cotizadocompleto = 1;
            else cotizadocompleto = 0;
            txtbusca_TextChanged(sender, e);
        }

        private void checkBox8_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox8.Checked) cotizadooc = 1;
            else cotizadooc = 0;
            txtbusca_TextChanged(sender, e);
        }
        DateTime fechainicio, fechafin;
        private void txtbusca_TextChanged(object sender, EventArgs e)
        {
            if (fechainicio > fechafin)
            {
                dtgconten.DataSource = Creporteop.ReportedeOp(opcion, articulo, servicio, fecha, fechafin, fechainicio, anulado, registrado, cotizado, cotizadocompleto, cotizadooc, txtbusca.Text);
            }
            else
            {
                dtgconten.DataSource = Creporteop.ReportedeOp(opcion, articulo, servicio, fecha, fechainicio, fechafin, anulado, registrado, cotizado, cotizadocompleto, cotizadooc, txtbusca.Text);
            }
            ContarRegistros(dtgconten);
        }
        public void ContarRegistros(DataGridView tablita)
        {
            lblmsg.Text = "Total Registros: " + tablita.RowCount;
        }
        private void dtinicio_ValueChanged(object sender, EventArgs e)
        {
            fechainicio = dtinicio.Value;
            txtbusca_TextChanged(sender, e);
        }
        int op = 0;
        private void dtgconten_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (dtgconten["TIPO", e.RowIndex].Value.ToString() == "ARTICULO") op = 1;
            else op = 0;
            dtgconten1.DataSource = Creporteop.reportepedidodetalle(op, Convert.ToInt32(dtgconten["NUMEROpedido", e.RowIndex].Value.ToString()));
        }

        private void dtfin_ValueChanged(object sender, EventArgs e)
        {
            fechafin = dtfin.Value;
            txtbusca_TextChanged(sender, e);
        }
    }
}
