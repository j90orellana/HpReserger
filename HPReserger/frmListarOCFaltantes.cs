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
    public partial class frmListarOCFaltantes : Form
    {
        public frmListarOCFaltantes()
        {
            InitializeComponent();
        }
        int opcion = 0;
        int articulo = 2;
        int servicio = 6;
        int fecha = 0;
        HPResergerCapaLogica.HPResergerCL cllistarfaltantes = new HPResergerCapaLogica.HPResergerCL();
        private void frmListarOCFaltantes_Load(object sender, EventArgs e)
        {
            dtgconten.DataSource = cllistarfaltantes.ListarOCFaltantes("", DTINICIO.Value, DTFIN.Value, articulo, servicio, 0, 0);
            DTFIN.Value = DateTime.Now;
        }

        private void btnrefres_Click(object sender, EventArgs e)
        {
        }

        private void btnaceptar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dtgconten_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.C && e.Control)
            {
                Clipboard.SetText(dtgconten.CurrentCell.Value.ToString());
                lblmsg.Text = "Copiado";
            }
        }

        private void dtgconten_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void dtgconten_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        public void mensajito(string cadena)
        {
            MessageBox.Show(cadena);
        }

        private void dtgconten_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            dtgconten.CurrentCell = dtgconten[e.ColumnIndex, e.RowIndex];
            if (e.Button == MouseButtons.Right)
            {
                // mnopciones.Show(frmListarOCFaltantes.ActiveForm.);
            }
        }

        private void mnclick_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(dtgconten.CurrentCell.Value.ToString());
            lblmsg.Text = "Copiado";
        }

        private void dtgconten_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Clipboard.SetText(dtgconten[e.ColumnIndex, e.RowIndex].Value.ToString());
            lblmsg.Text = "Copiado";
        }

        private void gb3_Enter(object sender, EventArgs e)
        {

        }

        private void txtbuscar_TextChanged(object sender, EventArgs e)
        {try { 
            dtgconten.DataSource = cllistarfaltantes.ListarOCFaltantes(txtbuscar.Text, DTINICIO.Value, DTFIN.Value, articulo, servicio, opcion, fecha);
            }
            catch { }
        }

        private void radioButton11_CheckedChanged(object sender, EventArgs e)
        {
            opcion = 0;
            txtbuscar_TextChanged(sender, e);
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

            opcion = 1;
            txtbuscar_TextChanged(sender, e);
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            opcion = 2;
            txtbuscar_TextChanged(sender, e);
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            opcion = 3;
            txtbuscar_TextChanged(sender, e);
        }
        private void radioButton8_CheckedChanged(object sender, EventArgs e)
        {
            opcion = 4;
            txtbuscar_TextChanged(sender, e);
        }

        private void radioButton12_CheckedChanged(object sender, EventArgs e)
        {
            opcion = 5;
            txtbuscar_TextChanged(sender, e);
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            opcion = 5;
            txtbuscar_TextChanged(sender, e);
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            opcion = 6;
            txtbuscar_TextChanged(sender, e);
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            opcion = 7;
            txtbuscar_TextChanged(sender, e);
        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {
            opcion = 8;
            txtbuscar_TextChanged(sender, e);
        }

        private void radioButton8_CheckedChanged_1(object sender, EventArgs e)
        {
            opcion = 10;
            txtbuscar_TextChanged(sender, e);
        }

        private void radioButton9_CheckedChanged(object sender, EventArgs e)
        {
            opcion = 9;
            txtbuscar_TextChanged(sender, e);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                articulo = 2;
            }
            else { articulo = 1; }
            txtbuscar_TextChanged(sender, e);
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                servicio = 6;
            }
            else { servicio = 3; }
            txtbuscar_TextChanged(sender, e);
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked)
            {
                fecha = 1;
            }
            else { fecha = 0; }
            txtbuscar_TextChanged(sender, e);
        }

        private void gb2_Enter(object sender, EventArgs e)
        {

        }

        private void DTINICIO_ValueChanged(object sender, EventArgs e)
        {
            txtbuscar_TextChanged(sender, e);
        }

        private void DTFIN_ValueChanged(object sender, EventArgs e)
        {
            txtbuscar_TextChanged(sender, e);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtbuscar.Text = "";
        }
    }
}
