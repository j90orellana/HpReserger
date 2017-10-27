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
    public partial class frmpresupuestoetapa : Form
    {
        public frmpresupuestoetapa()
        {
            InitializeComponent();
        }
        HPResergerCapaLogica.HPResergerCL CLpresupuestoetapa = new HPResergerCapaLogica.HPResergerCL();
        public int etapa;
        public string cc;
        public Boolean ok;
        public decimal valor;
        public decimal valorflujo;
        public int cabecera;
        private void frmpresupuestoetapa_Load(object sender, EventArgs e)
        {
            ok = false;
            //Application.CurrentCulture = new System.Globalization.CultureInfo("EN-US");
            dtgconten.DataSource = CLpresupuestoetapa.MesEtapaProyecto(etapa);
            dtgconten1.DataSource = CLpresupuestoetapa.MesEtapaProyecto(etapa);
            dtgconten.Columns[0].Visible = false;
            dtgconten1.Columns[0].Visible = false;
            DataTable EtapasDatos = CLpresupuestoetapa.ListarEtapasdelProyecto(10, 0, etapa, "", 0, DateTime.Now, DateTime.Now, 0, "", 0);
            DataRow filadatos = EtapasDatos.Rows[0];
            dtpinicio.Value = (DateTime)filadatos["fecha_inicio"];
            dtpfin.Value = (DateTime)filadatos["fecha_fin"];
            for (int i = 1; i < dtgconten.ColumnCount; i++)
            {
                dtgconten[i, 0].Value = "0.00";
                dtgconten1[i, 0].Value = "0.00";
            }
            cc = txtcc.Text;
            dtgvalores.DataSource = CLpresupuestoetapa.MesEtapaCentroCosto(0, etapa, 0, cc, 0, 0, cabecera, 0);
            if (dtgvalores.RowCount > 0)
            {
                for (int i = 0; i < dtgvalores.RowCount; i++)
                {
                    dtgconten[i + 1, 0].Value = dtgvalores["Importe_MesEtapa", i].Value;
                    dtgconten1[i + 1, 0].Value = dtgvalores["Importe_Flujo", i].Value;
                }
            }
            CalcularTotal(dtgconten, txtpagos);
            CalcularTotal(dtgconten1, txtflujo);
        }
        private void dtgconten_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int y = e.RowIndex, x = e.ColumnIndex;
            if (y >= 0)
            {
                if (x == 0)
                {
                    dtgconten[x, 0].ReadOnly = true;
                }
            }
        }
        private void dtgconten_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                dtgconten.EndEdit();
                // btnmas_Click(sender, e);
            }
            else { e.Handled = true; }
        }
        TextBox txt;
        private void dtgconten_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            if (dtgconten.CurrentCell.RowIndex == 0)
            {
                txt = e.Control as TextBox;
                if (txt != null)
                {
                    txt.KeyPress -= new KeyPressEventHandler(dataGridview_KeyPressCajita);
                    txt.KeyPress += new KeyPressEventHandler(dataGridview_KeyPressCajita);
                }
            }
        }
        private void dataGridview_KeyPressCajita(object sender, KeyPressEventArgs e)
        {
            HPResergerFunciones.Utilitarios.SoloNumerosDecimales(e, txt.Text);
        }
        private void dtgconten_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
        }
        decimal numero = 0.00m;
        public void msg(string cadena)
        {
            MessageBox.Show(cadena, "HpReserger", MessageBoxButtons.OK, MessageBoxIcon.Question);
        }
        private void dtgconten_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            int x = e.ColumnIndex, y = e.RowIndex;
            if (y >= 0 && x > 0)
            {
                if (!string.IsNullOrWhiteSpace(dtgconten[x, y].Value.ToString()))
                {
                    numero = decimal.Parse(dtgconten[x, y].Value.ToString());
                    numero = decimal.Parse(numero.ToString("n2"));
                    dtgconten[x, y].Value = numero;
                }
                else
                    dtgconten[x, y].Value = "0.00";
            }
            CalcularTotal(dtgconten, txtpagos);
        }
        public void CalcularTotal(DataGridView dtg, TextBox txtbox)
        {
            decimal totalito = 0;
            for (int i = 1; i < dtg.ColumnCount; i++)
            {
                totalito += (decimal)dtg[i, 0].Value;
            }
            txtbox.Text = totalito.ToString("n2");
            CalcularDiferencia();
        }
        public void CalcularDiferencia()
        {
            if (!string.IsNullOrWhiteSpace(txtpagos.Text) && !string.IsNullOrWhiteSpace(txtflujo.Text))
                txtdiferencia.Text = (decimal.Parse(txtpagos.Text) - decimal.Parse(txtflujo.Text)).ToString("n2");
        }
        private void btnguardar_Click(object sender, EventArgs e)
        {
            dtgconten.EndEdit(); dtgconten1.EndEdit();
            dtgconten.CurrentCell = dtgconten[1, 0];
            CLpresupuestoetapa.MesEtapaCentroCosto(10, etapa, 0, cc, 0, 0, cabecera, 0);
            valor = 0; valorflujo = 0;
            for (int i = 1; i < dtgconten.ColumnCount; i++)
            {
                CLpresupuestoetapa.MesEtapaCentroCosto(1, etapa, i, cc, (decimal)dtgconten[i, 0].Value, (decimal)dtgconten1[i, 0].Value, cabecera, frmLogin.CodigoUsuario);
                valor += (decimal)dtgconten[i, 0].Value;
                valorflujo += (decimal)dtgconten1[i, 0].Value;
            }
            msg("Guardado Con exito");
            ok = true;
            this.Close();
        }

        private void dtgconten1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                dtgconten1.EndEdit();
                // btnmas_Click(sender, e);
            }
            else { e.Handled = true; }
        }

        private void dtgconten1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int y = e.RowIndex, x = e.ColumnIndex;
            if (y >= 0)
            {
                if (x == 0)
                {
                    dtgconten1[x, 0].ReadOnly = true;
                }
            }
        }

        private void dtgconten1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            int x = e.ColumnIndex, y = e.RowIndex;
            if (y >= 0 && x > 0)
            {
                if (!string.IsNullOrWhiteSpace(dtgconten1[x, y].Value.ToString()))
                {
                    numero = decimal.Parse(dtgconten1[x, y].Value.ToString());
                    numero = decimal.Parse(numero.ToString("n2"));
                    dtgconten1[x, y].Value = numero;
                }
                else
                    dtgconten1[x, y].Value = "0.00";
            }
            CalcularTotal(dtgconten1, txtflujo);
        }

        private void dtgconten1_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            if (dtgconten1.CurrentCell.RowIndex == 0)
            {
                txt = e.Control as TextBox;
                if (txt != null)
                {
                    txt.KeyPress -= new KeyPressEventHandler(dataGridview_KeyPressCajita);
                    txt.KeyPress += new KeyPressEventHandler(dataGridview_KeyPressCajita);
                }
            }
        }
    }
}
