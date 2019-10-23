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
    public partial class frmCargosVentas : FormGradient
    {
        public frmCargosVentas()
        {
            InitializeComponent();
        }
        DataTable TCargos;
        HPResergerCapaLogica.HPResergerCL CapaLogica = new HPResergerCapaLogica.HPResergerCL();
        public void msg(string cadena) { HPResergerFunciones.frmInformativo.MostrarDialogError(cadena); }
        public void msgOK(string cadena) { HPResergerFunciones.frmInformativo.MostrarDialog(cadena); }

        private void frmCargosVentas_Load(object sender, EventArgs e)
        {
            dtgbusca.ReadOnly = dtgconten.ReadOnly = true; txtBuscar.Enabled = false; btnaceptar.Enabled = false;
            CargarDatos();
            txtBuscar_BuscarTextChanged(sender, e);
            dtgbusca.ReadOnly = true;
        }
        int estado = 0;
        public void CargarDatos()
        {
            TCargos = CapaLogica.InsertarActualizarCargo(0, 10, "", 0);
            dtgconten.DataSource = TCargos;
        }
        private void txtBuscar_BuscarTextChanged(object sender, EventArgs e)
        {
            dtgbusca.DataSource = CapaLogica.InsertarActualizarCargo(0, 0, txtBuscar.TextoValido(), 0);
        }
        private void btncancelar_Click(object sender, EventArgs e)
        {
            if (estado == 0)
            {
                this.Close();
            }
            if (estado == 2)
            {
                // dtgbusca.ReadOnly =
                dtgconten.ReadOnly = true; txtBuscar.Enabled = false; btnaceptar.Enabled = false;
            }
            btnaddgroup.Enabled = btnaddselected.Enabled = false;
            estado = 0;
            CargarDatos();
        }

        private void btnmodificar_Click(object sender, EventArgs e)
        {
            estado = 2;
            //dtgbusca.ReadOnly =
            dtgconten.ReadOnly = false; txtBuscar.Enabled = true; btnaceptar.Enabled = true;
            btnaddgroup.Enabled = true; btnaddselected.Enabled = true;
        }

        private void btnaddselected_Click(object sender, EventArgs e)
        {
            if (dtgbusca.CurrentCell != null)
            {
                int x = dtgbusca.CurrentCell.RowIndex;
                int value = (int)dtgbusca[idcargoy.Name, x].Value;
                string cadena = dtgbusca[cargosy.Name, x].Value.ToString();
                Agregando(value, cadena);
            }
        }
        public void Agregando(int valor, string cadena)
        {
            string filter = $"cargo ={valor}";
            DataRow[] dfilas = TCargos.Select(filter);
            if (dfilas.Length == 0)
            {
                TCargos.Rows.Add(valor, 0, DateTime.Now, cadena);
            }
        }

        private void btnaddgroup_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow item in dtgbusca.Rows)
            {
                int value = (int)item.Cells[idcargoy.Name].Value;
                string cadena = item.Cells[cargosy.Name].Value.ToString();
                Agregando(value, cadena);
            }
        }

        private void btnaceptar_Click(object sender, EventArgs e)
        {
            if (estado == 2)
            {
                //20 eliminar los registros
                CapaLogica.InsertarActualizarCargo(0, 20, "", 0);
                foreach (DataGridViewRow item in dtgconten.Rows)
                {
                    //21 inserta linea a linea
                    CapaLogica.InsertarActualizarCargo((int)item.Cells[idcargox.Name].Value, 21, "", 0);
                }
                msgOK("Guardado Exitosamente");
            }
            btnaddgroup.Enabled = true; btnaddselected.Enabled = true;
            estado = 0;
            CargarDatos();
        }
        private void dtgconten_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Delete || e.KeyData == Keys.Back)
            {
                if (dtgconten.SelectedRows.Count > 0)
                {
                    if (HPResergerFunciones.Utilitarios.msgYesNo("Desea Eliminar Fila") == DialogResult.Yes)
                    {
                        foreach (DataGridViewRow item in dtgconten.SelectedRows)
                        {
                            dtgconten.Rows.Remove(item);
                        }
                        msgOK("Items Eliminados");
                    }
                    else
                        msg("Cancelado Por el Usuario");
                }
            }
        }
    }
}
