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

namespace HPReserger.ModuloActivoFijo
{
    public partial class frmActivoFijo : FormGradient
    {
        public frmActivoFijo()
        {
            InitializeComponent();
        }
        HPResergerCapaLogica.HPResergerCL CapaLogica = new HPResergerCapaLogica.HPResergerCL();
        private int _proyecto;
        private int _idempresa;

        public void msgError(string cadena) { HPResergerFunciones.frmInformativo.MostrarDialogError(cadena); }
        public void msgOK(string cadena) { HPResergerFunciones.frmInformativo.MostrarDialog(cadena); }
        public void CargarEmpresa()
        {
            CapaLogica.TablaEmpresas(cboempresa);
        }

        private void frmActivoFijo_Load(object sender, EventArgs e)
        {
            cargarValoresDefecto();
            CargarEmpresa();
            CargarDatos();
            CArgarCuentas();
            CargarCuentaActivo();
        }

        private void CargarCuentaActivo()
        {
            tDAtos = CArgarCuentas();
            cboCuentaCrearActivo.DisplayMember = "Cuenta_Contable";
            cboCuentaCrearActivo.ValueMember = "Id_Cuenta_Contable";
            cboCuentaCrearActivo.DataSource = CArgarCuentas();
            //
            cboCuentaActivo.DisplayMember = "Cuenta_Contable";
            cboCuentaActivo.ValueMember = "Id_Cuenta_Contable";
            cboCuentaActivo.DataSource = CArgarCuentas();
        }

        DataTable TCuentas;
        private DataTable CArgarCuentas()
        {
            return CapaLogica.ActivoFijo_CuentasContable(1);
        }
        private void cargarValoresDefecto()
        {
            dtpFechaActivacion.Value = dtpFechaContable.Value = DateTime.Now;
            Configuraciones.CargarTextoPorDefecto(txtGlosa, txtPorcentajeContable, txtPorcentajeTributario, txtValorActivo, txtValorResidual, txtVidaUtil);
        }
        DataTable tDAtos;
        private void CargarDatos()
        {
            tDAtos = CapaLogica.ActivoFijoCrear(_idempresa, chkFacturaTodas.Checked ? 0 : -1);
            if (tDAtos.Rows.Count > 0)
            {
                Dtgconten.DataSource = tDAtos;
            }
            else
            {
                if (Dtgconten.DataSource != null)
                {
                    Dtgconten.DataSource = ((DataTable)Dtgconten.DataSource).Clone();
                }
            }
        }

        private void cboproyecto_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboproyecto.SelectedIndex >= 0)
            {
                DataRowView itemsito = (DataRowView)cboproyecto.Items[cboproyecto.SelectedIndex];
                cboetapa.DataSource = CapaLogica.ListarEtapasProyecto((itemsito["id_proyecto"].ToString()));
                cboetapa.ValueMember = "id_etapa";
                cboetapa.DisplayMember = "descripcion";
                _proyecto = (int)itemsito["id_proyecto"];
            }
            else msgError("No Hay Proyectos");
        }

        private void cboempresa_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboempresa.Items.Count > 0)
            {
                if (cboempresa.SelectedValue != null)
                {
                    cboproyecto.DataSource = CapaLogica.ListarProyectosEmpresa(cboempresa.SelectedValue.ToString());
                    cboproyecto.DisplayMember = "proyecto";
                    cboproyecto.ValueMember = "id_proyecto";
                    //busqueda de Asientos
                    _idempresa = (int)cboempresa.SelectedValue;
                    CargarDatos();
                    SumarTotalActivo();
                }
            }
            else msgError("No hay Empresas");
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void Dtgconten_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Dtgconten.EndEdit();
                SumarTotalActivo();
            }
        }
        decimal SumaSoles;
        int ConFacturas;
        private void SumarTotalActivo()
        {
            SumaSoles = 0;
            ConFacturas = 0;
            //
            foreach (DataGridViewRow item in Dtgconten.Rows)
            {
                if ((int)item.Cells[xOK.Name].Value == 1)
                {
                    SumaSoles += (decimal)item.Cells[xSoles.Name].Value;
                    ConFacturas++;
                    if (!txtGlosa.EstaLLeno()) txtGlosa.Text = item.Cells[xGlosa.Name].Value.ToString();
                    if (ConFacturas == 1)
                        cboCuentaActivo.Text = item.Cells[xccuenta.Name].Value.ToString();
                }
            }
            txtValorActivo.Text = SumaSoles.ToString("n2");
            if (SumaSoles == 0)
            {
                txtGlosa.CargarTextoporDefecto();
            }
            if (ConFacturas > 1)
            {
                cboCuentaCrearActivo.Visible = lblCrearActivo.Visible = true;
            }
            else
                cboCuentaCrearActivo.Visible = lblCrearActivo.Visible = false;

        }
        private void Dtgconten_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // msgError("cellclick");
        }

        private void Dtgconten_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Dtgconten.EndEdit();
        }

        private void chkFacturaTodas_CheckedChanged(object sender, EventArgs e)
        {
            CargarDatos();
            SumarTotalActivo();
        }

        private void txtVidaUtil_TextChanged(object sender, EventArgs e)
        {
            decimal val = txtVidaUtil.DecimalValido();
            if (val > 0)
            {
                val = 100 / val;
                txtPorcentajeContable.Text = val.ToString();
                txtPorcentajeTributario.Text = val.ToString();
            }
        }
        private void txtCuentaContable_TextChanged(object sender, EventArgs e)
        {
            DataTable tabla = CapaLogica.BuscarCuentas(txtCuentaContable.Text, 1);
            if (tabla.Rows.Count != 0)
                txtDescripcionCuenta.Text = tabla.Rows[0]["Cuenta_Contable"].ToString();
            else txtDescripcionCuenta.CargarTextoporDefecto();

        }

        private void cboCuentaCrearActivo_Click(object sender, EventArgs e)
        {
            if (cboCuentaCrearActivo.Items.Count != CArgarCuentas().Rows.Count)
            {
                string cuenta = cboCuentaCrearActivo.Text;
                string cuenta1 = cboCuentaActivo.Text;
                cboCuentaCrearActivo.DataSource = CArgarCuentas();
                cboCuentaActivo.DataSource = CArgarCuentas();
                cboCuentaCrearActivo.Text = cuenta;
                cboCuentaActivo.Text = cuenta1;
            }
        }

        private void cboCuentaActivo_Click(object sender, EventArgs e)
        {
            if (cboCuentaActivo.Items.Count != CArgarCuentas().Rows.Count)
            {
                string cuenta = cboCuentaCrearActivo.Text;
                string cuenta1 = cboCuentaActivo.Text;
                tDAtos = CArgarCuentas();
                cboCuentaCrearActivo.DataSource = CArgarCuentas();
                cboCuentaActivo.DataSource = CArgarCuentas();
                cboCuentaCrearActivo.Text = cuenta;
                cboCuentaActivo.Text = cuenta1;
            }
        }

        private void txtCuentaContable_DoubleClick(object sender, EventArgs e)
        {
            frmlistarcuentas frmBuscarCuenta = new frmlistarcuentas();
            frmBuscarCuenta.Txtbusca.Text = txtCuentaContable.TextValidoNumeros();
            frmBuscarCuenta.ShowDialog();
            if (frmBuscarCuenta.aceptar)
                txtCuentaContable.Text = frmBuscarCuenta.codigo;

        }
    }
}
