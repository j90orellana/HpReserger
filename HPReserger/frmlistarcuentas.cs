﻿using System;
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
    public partial class frmlistarcuentas : Form
    {
        public frmlistarcuentas()
        {
            InitializeComponent();
        }
        public int tipobusca { get; set; }
        public Boolean aceptar { get; set; }
        public string codigo { get; set; }
        HPResergerCapaLogica.HPResergerCL CcuentaContable = new HPResergerCapaLogica.HPResergerCL();
        private void frmlistarcuentas_Load(object sender, EventArgs e)
        {

            aceptar = false;
            if (radioButton1.Checked) {
                tipobusca = 1;
            ListarCuentasContables(Txtbusca.Text, tipobusca);
            }
            if (radioButton2.Checked)
            {
                tipobusca = 2;
                ListarCuentasContables(Txtbusca.Text, tipobusca);
            }
            if (radioButton4.Checked)
            {
                tipobusca = 3;
                ListarCuentasContables(Txtbusca.Text, tipobusca);
            }
            msg(dtgconten);
        }
        public void msg(DataGridView conteo)
        {
            lblmsg.Text = "Total Registros: " + conteo.RowCount;
        }
        public void Txtbusca_TextChanged(object sender, EventArgs e)
        {
            dtgconten.DataSource = CcuentaContable.ListarCuentasContables(Txtbusca.Text, tipobusca);
            msg(dtgconten);
        }

        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            Txtbusca.Text = "";
        }
        public void ListarCuentasContables(string busca, int opcion)
        {
            dtgconten.DataSource = CcuentaContable.ListarCuentasContables(busca, opcion);
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            aceptar = false;
            this.Close();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            tipobusca = 1;
            Txtbusca_TextChanged(sender, e);
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            tipobusca = 2;
            Txtbusca_TextChanged(sender, e);
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            tipobusca = 3;
            Txtbusca_TextChanged(sender, e);
        }

        private void btnaceptar_Click(object sender, EventArgs e)
        {
            codigo = dtgconten[0, dtgconten.CurrentRow.Index].Value.ToString();
            aceptar = true;
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmcuentacontable cuentas = new frmcuentacontable();
            cuentas.Show();
        }

        private void dtgconten_DoubleClick(object sender, EventArgs e)
        {try { 
            codigo = dtgconten[0, dtgconten.CurrentCell.RowIndex].Value.ToString();
            aceptar = true;
            this.Close();
            }
            catch { }
        }
    }
}