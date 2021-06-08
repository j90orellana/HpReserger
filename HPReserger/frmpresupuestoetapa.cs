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
    public partial class frmpresupuestoetapa : FormGradient
    {
        public frmpresupuestoetapa()
        {
            InitializeComponent();
        }
        HPResergerCapaLogica.HPResergerCL CLpresupuestoetapa = new HPResergerCapaLogica.HPResergerCL();
        public void msg(string cadena) { HPResergerFunciones.frmInformativo.MostrarDialogError(cadena); }
        public void msgOK(string cadena) { HPResergerFunciones.frmInformativo.MostrarDialog(cadena); }
        public int etapa;
        public string cc;
        public Boolean ok;
        public decimal valor;
        public decimal valorflujo;
        public int cabecera;
        private void frmpresupuestoetapa_Load(object sender, EventArgs e)
        {
            if (Estado)
            {
                dtgGastos.ReadOnly = true;
                //dtgFlujos.ReadOnly = true;
                btnguardar.Enabled = false;
            }
            else
            {
                dtgGastos.ReadOnly = false;
                // dtgFlujos.ReadOnly = false;
                btnguardar.Enabled = true;
            }
            ok = false;
            //Application.CurrentCulture = new System.Globalization.CultureInfo("EN-US");
            dtgGastos.DataSource = CLpresupuestoetapa.MesEtapaProyecto(etapa);
            dtgFlujos.DataSource = CLpresupuestoetapa.MesEtapaProyecto(etapa);
            dtgDiferencia.DataSource = CLpresupuestoetapa.MesEtapaProyecto(etapa);
            dtgGastos.Columns[0].Visible = false;
            dtgFlujos.Columns[0].Visible = false;
            dtgDiferencia.Columns[0].Visible = false;
            DataTable EtapasDatos = CLpresupuestoetapa.ListarEtapasdelProyecto(10, 0, etapa, "", 0, DateTime.Now, DateTime.Now, 0, "", 0);
            DataRow filadatos = EtapasDatos.Rows[0];
            dtpinicio.Value = (DateTime)filadatos["fecha_inicio"];
            dtpfin.Value = (DateTime)filadatos["fecha_fin"];
            for (int i = 1; i < dtgGastos.ColumnCount; i++)
            {
                dtgGastos[i, 0].Value = "0.00";
                dtgFlujos[i, 0].Value = "0.00";
                dtgDiferencia[i, 0].Value = "0.00";
                dtgGastos.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                dtgFlujos.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                dtgDiferencia.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                if (dtgGastos.ColumnCount - i < 3)
                {
                    dtgGastos.Columns[i].DefaultCellStyle.BackColor = Color.FromArgb(136, 178, 178);
                    dtgFlujos.Columns[i].DefaultCellStyle.BackColor = Color.FromArgb(136, 178, 178);
                    dtgDiferencia.Columns[i].DefaultCellStyle.BackColor = Color.FromArgb(136, 178, 178);
                    dtgGastos.Columns[i].DefaultCellStyle.ForeColor = Color.Red;
                    dtgFlujos.Columns[i].DefaultCellStyle.ForeColor = Color.Red;
                    dtgDiferencia.Columns[i].DefaultCellStyle.ForeColor = Color.Red;
                }
            }
            cc = txtcc.Text;
            dtgvalores.DataSource = CLpresupuestoetapa.MesEtapaCentroCosto(0, etapa, 0, cc, 0, 0, cabecera, 0);
            DataTable RFila = CLpresupuestoetapa.ListarReporteCuentaCostoFlujo(etapa, cc);
            if (RFila.Rows.Count > 0)
            {
                for (int i = 0; i < RFila.Rows.Count; i++)
                {
                    dtgFlujos[i + 1, 0].Value = RFila.Rows[i]["operaciones"];
                }
            }
            if (dtgvalores.RowCount > 0)
            {
                for (int i = 0; i < dtgvalores.RowCount; i++)
                {
                    dtgGastos[i + 1, 0].Value = dtgvalores["Importe_MesEtapa", i].Value;
                }
            }
            CalcularTotal(dtgGastos, txtpagos);
            CalcularTotal(dtgFlujos, txtflujo);
            CalcularDiferenciaGrillas();
        }
        private void dtgconten_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int y = e.RowIndex, x = e.ColumnIndex;
            if (y >= 0)
            {
                if (x == 0)
                {
                    dtgGastos[x, 0].ReadOnly = true;
                }
            }
        }
        private void dtgconten_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                dtgGastos.EndEdit();
                // btnmas_Click(sender, e);
            }
            else { e.Handled = true; }
        }
        TextBox txt;
        private void dtgconten_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            if (dtgGastos.CurrentCell.RowIndex == 0)
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

        public bool Estado { get; internal set; }

        private void dtgconten_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            int x = e.ColumnIndex, y = e.RowIndex;
            if (y >= 0 && x > 0)
            {
                if (!string.IsNullOrWhiteSpace(dtgGastos[x, y].Value.ToString()))
                {
                    numero = decimal.Parse(dtgGastos[x, y].Value.ToString());
                    numero = decimal.Parse(numero.ToString("n2"));
                    dtgGastos[x, y].Value = numero;
                }
                else
                    dtgGastos[x, y].Value = "0.00";
            }
            CalcularTotal(dtgGastos, txtpagos);
            CalcularDiferenciaGrillas();
        }
        private void CalcularDiferenciaGrillas()
        {
            for (int i = 0; i < dtgGastos.ColumnCount; i++)
            {
                if (i > 0)
                    dtgDiferencia[i, 0].Value = (decimal)dtgGastos[i, 0].Value - (decimal)dtgFlujos[i, 0].Value;
            }
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
            dtgGastos.EndEdit(); dtgFlujos.EndEdit();
            dtgGastos.CurrentCell = dtgGastos[1, 0];
            CLpresupuestoetapa.MesEtapaCentroCosto(10, etapa, 0, cc, 0, 0, cabecera, 0);
            valor = 0; valorflujo = 0;
            for (int i = 1; i < dtgGastos.ColumnCount; i++)
            {
                CLpresupuestoetapa.MesEtapaCentroCosto(1, etapa, i, cc, (decimal)dtgGastos[i, 0].Value, (decimal)dtgFlujos[i, 0].Value, cabecera, frmLogin.CodigoUsuario);
                valor += (decimal)dtgGastos[i, 0].Value;
                valorflujo += (decimal)dtgFlujos[i, 0].Value;
            }
            msgOK("Guardado Con exito");
            ok = true;
            this.Close();
        }

        private void dtgconten1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                dtgFlujos.EndEdit();
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
                    dtgFlujos[x, 0].ReadOnly = true;
                }
            }
        }

        private void dtgconten1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            int x = e.ColumnIndex, y = e.RowIndex;
            if (y >= 0 && x > 0)
            {
                if (!string.IsNullOrWhiteSpace(dtgFlujos[x, y].Value.ToString()))
                {
                    numero = decimal.Parse(dtgFlujos[x, y].Value.ToString());
                    numero = decimal.Parse(numero.ToString("n2"));
                    dtgFlujos[x, y].Value = numero;
                }
                else
                    dtgFlujos[x, y].Value = "0.00";
            }
            CalcularTotal(dtgFlujos, txtflujo);
        }

        private void dtgconten1_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            if (dtgFlujos.CurrentCell.RowIndex == 0)
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
