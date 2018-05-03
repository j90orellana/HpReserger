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
    public partial class FrmListarCuentasParaConfigurar : FormGradient
    {
        public FrmListarCuentasParaConfigurar()
        {
            InitializeComponent();
        }
        public Boolean aceptar { get; set; }
        HPResergerCapaLogica.HPResergerCL CapaLogica = new HPResergerCapaLogica.HPResergerCL();
        public string Cuentas;
        private void FrmListarCuentasParaConfigurar_Load(object sender, EventArgs e)
        {
            SAcarCuentas();
            Grid.DataSource = CapaLogica.ListarCuentasContables(Txtbusca.Text, tipobusca);
            msg(Grid);
            tipobusca = 10;
            aceptar = false;
            if (radioButton1.Checked)
            {
                tipobusca = 10;
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
            msg(Grid);
        }
        public void ListarCuentasContables(string busca, int opcion)
        {
            Grid.DataSource = CapaLogica.ListarCuentasContables(busca, opcion);
        }
        int tipobusca = 0;
        public void msg(DataGridView conteo)
        {
            lblmsg.Text = "Total Registros: " + conteo.RowCount;
        }
        DataTable tableaux = new DataTable();
        DataTable tablita = new DataTable();
        string[] CadenaCuentas;
        List<string> ListaCuentas = new List<string>();
        public void SAcarCuentas()
        {
            tablita.Columns.Add("codigo");
            tablita.Columns.Add("valor");
            CadenaCuentas = Cuentas.Split(',');
            foreach (string item in CadenaCuentas)
            {
                if (item.Length > 1)
                {
                    DataRow filita = tablita.NewRow();
                    filita[0] = item.Trim();
                    tableaux = CapaLogica.BuscarCuentas(item.Trim(), 1);
                    if (tableaux.Rows.Count > 0)
                    {
                        DataRow filas = tableaux.Rows[0];
                        filita[1] = filas[0];
                    }
                    tablita.Rows.Add(filita);
                }
            }
            ListaCuentas = CadenaCuentas.ToList();
            dtgConten.DataSource = tablita;
        }
        public void msg(string cadena)
        {
            MessageBox.Show(cadena, "HpReserger", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void dtgConten_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            int x = e.ColumnIndex, y = e.RowIndex;
            if (y >= 0)
            {
                dtgConten[Cuentax.Name, y].Value.ToString();
                tableaux = CapaLogica.BuscarCuentas(dtgConten[Cuentax.Name, y].Value.ToString().Trim(), 1);
                if (tableaux.Rows.Count > 0)
                {
                    DataRow filas = tableaux.Rows[0];
                    dtgConten[Descripcionx.Name, y].Value = filas[0];
                }
            }
        }
        private void Txtbusca_TextChanged(object sender, EventArgs e)
        {
            Grid.DataSource = CapaLogica.ListarCuentasContables(Txtbusca.Text, tipobusca);
            msg(Grid);
        }
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            tipobusca = 10;
            Txtbusca_TextChanged(sender, e);
        }
        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            tipobusca = 3;
            Txtbusca_TextChanged(sender, e);
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            tipobusca = 2;
            Txtbusca_TextChanged(sender, e);
        }
        public void AgregarSeleccion()
        {
            foreach (DataGridViewRow item in Grid.SelectedRows)
            {
                string cadena = item.Cells[codcuenta.Name].Value.ToString();
                if (cadena.Substring(cadena.Length - 1, 1) != "0")
                {
                    if (!ListaCuentas.Exists(cust => cust == cadena))
                    {
                        ListaCuentas.Add(cadena.Trim());
                        tablita.Rows.Add(cadena.Trim());
                        msj("Agregado");
                    }
                    else msj("No Se puede Agregar, YA Existe");
                }
                else msj("No Se puede Agregar, Es Titulo");
            }

        }
        public void msj(string cadena)
        {
            lblmensaje2.Text = $"Total de Registros :{dtgConten.RowCount} " + cadena;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            AgregarSeleccion();
        }

        private void Grid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                AgregarSeleccion();
            }
        }

        private void dtgConten_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            int y = e.RowIndex;
            if (y >= 0)
            {
                dtgConten[Cuentax.Name, y].Value.ToString();
                tableaux = CapaLogica.BuscarCuentas(dtgConten[Cuentax.Name, y].Value.ToString().Trim(), 1);
                if (tableaux.Rows.Count > 0)
                {
                    DataRow filas = tableaux.Rows[0];
                    dtgConten[Descripcionx.Name, y].Value = filas[0];
                }
            }
            msj("");
        }

        private void btnaddgroup_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow item in Grid.Rows)
            {
                string CadeAux = item.Cells[codcuenta.Name].Value.ToString();
                if (CadeAux.Substring(CadeAux.Length - 1, 1) != "0")
                {
                    if (!ListaCuentas.Exists(cust => cust == CadeAux))
                    {
                        ListaCuentas.Add(CadeAux.Trim());
                        tablita.Rows.Add(CadeAux.Trim());
                    }
                }
            }
            msj("Agregado Todo el Grupo");
        }
        public DialogResult MSG(string cadena)
        {
            return MessageBox.Show(cadena, "HpReserger", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
        }
        private void dtgConten_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Delete || e.KeyData == Keys.Back)
            {
                if (dtgConten.SelectedRows.Count > 0)
                {
                    if (MSG("Desea Eliminar Fila") == DialogResult.Yes)
                    {
                        foreach (DataGridViewRow item in dtgConten.SelectedRows)
                        {
                            ListaCuentas.Remove(item.Cells[0].Value.ToString());
                            dtgConten.Rows.Remove(item);
                        }
                        msj("Items Eliminados");
                    }
                    msj("Cancelado Por el Usuario");
                }
            }
        }
        private void btncancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnaceptar_Click(object sender, EventArgs e)
        {
            Cuentas = string.Join(",", (ListaCuentas.ToArray()));
            //msg(Cuentas);
            DialogResult = DialogResult.OK;
            this.Close();
        }

        private void Txtbusca_Click(object sender, EventArgs e)
        {
            Txtbusca.SelectAll();
        }
    }
}
