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
        public void msg(string cadena) { HPResergerFunciones.frmInformativo.MostrarDialogError(cadena); }
        public void msgOK(string cadena) { HPResergerFunciones.frmInformativo.MostrarDialog(cadena); }
        public string Cuentas;
        private void FrmListarCuentasParaConfigurar_Load(object sender, EventArgs e)
        {
            SAcarCuentas();
            Grid.DataSource = CapaLogica.ListarCuentasContables(Txtbusca.EstaLLeno() ? Txtbusca.Text : "", tipobusca);
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
            // Asegurar que las columnas no se repitan
            if (!tablita.Columns.Contains("codigo"))
                tablita.Columns.Add("codigo");
            if (!tablita.Columns.Contains("valor"))
                tablita.Columns.Add("valor");

            // Separar las cuentas
            CadenaCuentas = Cuentas.Split(',');

            // Obtener el listado de cuentas contables
            DataTable Tcuentas = CapaLogica.ListarCuentasContables("", 10);
            // Se espera que Tcuentas tenga las columnas:
            // 0: CodCuenta
            // 1: Descripción N1
            // 2: CUENTA CONTABLE (formato completo)

            // Convertir Tcuentas en lista de DataRow para LINQ
            var listaCuentas = Tcuentas.AsEnumerable();

            foreach (string item in CadenaCuentas)
            {
                string cuenta = item.Trim();
                if (cuenta.Length > 1)
                {
                    var resultado = listaCuentas
                        .FirstOrDefault(r => r.Field<string>(0) == cuenta);

                    DataRow nuevaFila = tablita.NewRow();
                    nuevaFila["codigo"] = cuenta;
                    nuevaFila["valor"] = resultado != null ? resultado.Field<string>(2) : "";

                    tablita.Rows.Add(nuevaFila);
                }
            }

            // Guardar lista de cuentas en variable
            ListaCuentas = CadenaCuentas.ToList();

            // Asignar la tabla al control
            dtgConten.DataSource = tablita;
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
            Grid.DataSource = CapaLogica.ListarCuentasContables(Txtbusca.EstaLLeno() ? Txtbusca.Text : "", tipobusca);
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
                if ((int)item.Cells[xestadocta.Name].Value == 1 && (int)item.Cells[xctadetalle.Name].Value == 1)
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
                AgregarSeleccion();
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
            // HashSet es más eficiente para búsquedas que List
            var cuentasExistentes = new HashSet<string>(ListaCuentas);

            var nuevasCuentas = Grid.Rows
                .Cast<DataGridViewRow>()
                .Where(row =>
                    row.Cells[xestadocta.Name].Value is int estado && estado == 1 &&
                    row.Cells[xctadetalle.Name].Value is int detalle && detalle == 1)
                .Select(row => row.Cells[codcuenta.Name].Value?.ToString()?.Trim())
                .Where(cuenta => !string.IsNullOrEmpty(cuenta) && !cuentasExistentes.Contains(cuenta))
                .Distinct()
                .ToList();

            dtgConten.SuspendLayout();

            foreach (string cuenta in nuevasCuentas)
            {
                ListaCuentas.Add(cuenta);
                tablita.Rows.Add(cuenta);
            }

            dtgConten.ResumeLayout();

            msj("Agregado Todo el Grupo");
        }
        public DialogResult msgp(string cadena) { return HPResergerFunciones.frmPregunta.MostrarDialogYesCancel(cadena); }
        private void dtgConten_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Delete || e.KeyData == Keys.Back)
            {
                if (dtgConten.SelectedRows.Count > 0)
                {
                    if (msgp("Desea Eliminar Fila") == DialogResult.Yes)
                    {
                        foreach (DataGridViewRow item in dtgConten.SelectedRows)
                        {
                            ListaCuentas.Remove(item.Cells[0].Value.ToString());
                            dtgConten.Rows.Remove(item);
                        }
                        msj("Items Eliminados");
                    }
                    else
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
            List<string> Lista = new List<string>();
            foreach (DataGridViewRow item in dtgConten.Rows)
            {
                Lista.Add(item.Cells[Cuentax.Name].Value.ToString().Trim());
            }
            Cuentas = string.Join(",", (ListaCuentas.ToArray()));
            Cuentas = string.Join(",", (Lista.ToArray()));
            //msg(Cuentas);
            DialogResult = DialogResult.OK;
            this.Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string cadena = "999999";
            if (!ListaCuentas.Exists(cust => cust == cadena))
            {
                ListaCuentas.Add(cadena.Trim());
                tablita.Rows.Add(cadena.Trim());
                msj("Agregado");
            }
            else msj("No Se puede Agregar, Ya Existe");
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            ListaCuentas.Clear();
            tablita.Clear();
        }

        private void btnDuplicados_Click(object sender, EventArgs e)
        {           
            
            if (tablita != null && tablita.Rows.Count > 0)
            {
                try
                {
                    // Filtrar registros con valor no vacío y luego agrupar por código
                    var registrosFiltrados = tablita.AsEnumerable()
                        .Where(row => !string.IsNullOrEmpty(row.Field<string>("valor")))
                        .GroupBy(row => row.Field<string>("codigo"))
                        .Select(group => group.First());

                    // Verificar si hay registros antes de crear la tabla
                    if (registrosFiltrados.Any())
                    {
                        DataTable tablaUnica = registrosFiltrados.CopyToDataTable();
                        tablita = tablaUnica;
                        dtgConten.DataSource = tablita;
                    }
                    else
                    {
                        tablita.Clear();
                        dtgConten.DataSource = null;
                    }
                }
                catch (Exception ex)
                {
                }
            }
            else
            {
            }
        }
    }
}
