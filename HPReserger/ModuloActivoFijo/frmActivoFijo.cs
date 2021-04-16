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
            //CargarDatos();
            CArgarCuentas();
            CargarCuentaActivo();
            //
            Estado = 0; ModoEdicion(false);
            //CargarActivos();
        }

        private void CargarActivos()
        {
            dtgActivos.DataSource = CapaLogica.ActivoFijo(_idempresa);
        }

        private void CargarCuentaActivo()
        {
            tDAtos = CArgarCuentas();
            cboCuentaActivo.DisplayMember = "Cuenta_Contable";
            cboCuentaActivo.ValueMember = "Id_Cuenta_Contable";
            cboCuentaActivo.DataSource = CArgarCuentas();
            //
            cboCuentaDepreciacion.DisplayMember = "Cuenta_Contable";
            cboCuentaDepreciacion.ValueMember = "Id_Cuenta_Contable";
            cboCuentaDepreciacion.DataSource = CArgarCuentas();
        }
        private DataTable CArgarCuentas()
        {
            return CapaLogica.ActivoFijo_CuentasContable(1);
        }
        private void cargarValoresDefecto()
        {
            lblNoAgrupar.Text = "Sí hay más de 1 Factura seleccionada, Se necesita agruparlas para crear un Activo Fijo.";
            dtpFechaActivacion.Value = dtpFechaContable.Value = DateTime.Now;
            Configuraciones.CargarTextoPorDefecto(txtGlosa, txtPorcentajeContable, txtPorcentajeTributario, txtValorActivo, txtValorResidual, txtVidaUtil);
            Configuraciones.CargarTextoPorDefecto(txtCuentaContable, txtDescripcionCuenta);
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
                    CargarActivos();
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
        private int _etapa;
        public int Estado { get; private set; }

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
                    //if (ConFacturas == 1)
                    //    cboCuentaActivo.Text = item.Cells[xccuenta.Name].Value.ToString();
                }
            }
            txtValorActivo.Text = SumaSoles.ToString("n2");
            if (SumaSoles == 0)
            {
                txtGlosa.CargarTextoporDefecto();
            }
            if (ConFacturas > 1) { lblNoAgrupar.Visible = false; cboCuentaActivo.Visible = lblCrearActivo.Visible = true; }
            else { cboCuentaActivo.Visible = lblCrearActivo.Visible = false; lblNoAgrupar.Visible = true; }

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
            if (cboCuentaActivo.Items.Count != CArgarCuentas().Rows.Count)
            {
                string cuenta = cboCuentaActivo.Text;
                string cuenta1 = cboCuentaDepreciacion.Text;
                cboCuentaActivo.DataSource = CArgarCuentas();
                cboCuentaDepreciacion.DataSource = CArgarCuentas();
                cboCuentaActivo.Text = cuenta;
                cboCuentaDepreciacion.Text = cuenta1;
            }
        }

        private void cboCuentaActivo_Click(object sender, EventArgs e)
        {
            if (cboCuentaDepreciacion.Items.Count != CArgarCuentas().Rows.Count)
            {
                string cuenta = cboCuentaActivo.Text;
                string cuenta1 = cboCuentaDepreciacion.Text;
                tDAtos = CArgarCuentas();
                cboCuentaActivo.DataSource = CArgarCuentas();
                cboCuentaDepreciacion.DataSource = CArgarCuentas();
                cboCuentaActivo.Text = cuenta;
                cboCuentaDepreciacion.Text = cuenta1;
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

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            //PROCESO DE VALIDACIONES
            if (cboempresa.SelectedValue == null) { cboempresa.Focus(); msgError("Seleccione una Empresa"); return; }
            if (cboproyecto.SelectedValue == null) { cboproyecto.Focus(); msgError("Seleccione un Proyecto"); return; }
            if (cboetapa.SelectedValue == null) { cboetapa.Focus(); msgError("Seleccione una Etapa"); return; }
            //
            if (!txtValorActivo.EstaLLeno()) { txtValorActivo.Focus(); msgError("El Valor del Activo, no puede ser CERO"); return; }
            if (txtValorResidual.DecimalValido() >= txtValorActivo.DecimalValido()) { txtValorResidual.Focus(); msgError("El Valor Residual no debe ser mayor al Valor del Activo"); return; }
            if (ConFacturas <= 0) { msgError("Debe seleccionar la Factura del Activo Fijo"); return; }
            if (dtpFechaContable.Value < dtpFechaActivacion.Value) { msgError("La Fecha Contable, no puede ser menor a la Fecha Activación"); return; }
            if (txtVidaUtil.DecimalValido() <= 0) { txtVidaUtil.Focus(); msgError("Vida util debe ser mayor a CERO"); return; }
            if (!txtGlosa.EstaLLeno()) { txtGlosa.Focus(); msgError("Escriba una Glosa"); return; }
            if (!txtDescripcionCuenta.EstaLLeno()) { txtCuentaContable.Focus(); msgError("Ingrese la Cuenta de Gasto"); return; }
            if (cboCuentaDepreciacion.SelectedValue == null) { cboCuentaDepreciacion.Focus(); msgError("Seleccione cuenta de Depreciación"); return; }
            if (txtPorcentajeContable.DecimalValido() <= 0 || txtPorcentajeContable.DecimalValido() > 100) { txtPorcentajeContable.Focus(); msgError("El Porcentaje Contable debe ser entre 1 y 100%"); return; }
            if (txtPorcentajeTributario.DecimalValido() <= 0 || txtPorcentajeTributario.DecimalValido() > 100) { txtPorcentajeTributario.Focus(); msgError("El Porcentaje Tributario debe ser entre 1 y 100%"); return; }
            //CARGAR VARIABLES
            _idempresa = (int)cboempresa.SelectedValue;
            _proyecto = (int)cboproyecto.SelectedValue;
            _etapa = (int)cboetapa.SelectedValue;
            DateTime FechaActivacion = dtpFechaActivacion.Value;
            DateTime FechaContable = dtpFechaContable.Value;
            string Facturas = "";
            List<string> LisFac = new List<string>();
            foreach (DataGridViewRow item in Dtgconten.Rows)
            {
                if ((int)item.Cells[xOK.Name].Value == 1) LisFac.Add(item.Cells[xpkid.Name].Value.ToString());
            }
            Facturas = string.Join(",", LisFac.ToArray());
            string CUO = "";
            int Estado = 1;
            //GRABAR EL ACTIVO FIJO EN LA BASE
            CapaLogica.ActivoFijo(1, 0, _idempresa, _proyecto, _etapa, FechaActivacion, FechaContable, txtVidaUtil.DecimalValido(), txtPorcentajeTributario.DecimalValido(), txtPorcentajeContable.DecimalValido(),
                txtValorResidual.DecimalValido(), txtValorActivo.DecimalValido(), txtGlosa.Text, Facturas, cboCuentaActivo.SelectedValue.ToString(), txtCuentaContable.Text, cboCuentaDepreciacion.SelectedValue.ToString(),
                CUO, Estado);
            //CAMBIAMOS EL ESTADO DE LAS FACTURAS QUE TIENEN ACTIVO FIJO, CAMBIAMOS A 2 PARA IDENTIFICAR QUE ESA FACTURA ESTA ASOCIADA A UNA ACTIVO FIJO EN DEPRECIACION
            foreach (string item in LisFac)
                CapaLogica.ActivoFijo_CambiarEstadoFactura(int.Parse(item));

            Estado = 0;
            ModoEdicion(false);
            CargarActivos();
            msgOK("Activo Fijo Creado");
        }

        private void btnnuevo_Click(object sender, EventArgs e)
        {
            Estado = 1;
            ModoEdicion(true);
            CargarDatos();
            cargarValoresDefecto();
        }

        private void ModoEdicion(bool v)
        {
            if (v)
            {
                Configuraciones.Activar(cboproyecto, cboetapa, dtpFechaActivacion, dtpFechaContable, txtCuentaContable, txtGlosa, txtPorcentajeContable, txtPorcentajeTributario, txtValorActivo, txtValorResidual, txtVidaUtil,
                cboCuentaActivo, cboCuentaDepreciacion, btnAceptar, chkFacturaTodas);
                Configuraciones.Desactivar(btnmodificar, btnnuevo, dtgActivos, btnActualizar);
                Dtgconten.Columns[0].ReadOnly = false;
            }
            else
            {
                chkFacturaTodas.Checked = true;
                Configuraciones.Desactivar(cboproyecto, cboetapa, dtpFechaActivacion, dtpFechaContable, txtCuentaContable, txtGlosa, txtPorcentajeContable, txtPorcentajeTributario, txtValorActivo, txtValorResidual, txtVidaUtil,
                cboCuentaActivo, cboCuentaDepreciacion, btnAceptar, chkFacturaTodas);
                Configuraciones.Activar(btnmodificar, btnnuevo, dtgActivos, btnActualizar);
                foreach (DataGridViewColumn item in Dtgconten.Columns)
                    item.ReadOnly = !v;
            }
        }

        private void btnmodificar_Click(object sender, EventArgs e)
        {
            Estado = 2;
            ModoEdicion(true);
        }
        public DialogResult msgp(string cadena) { return HPResergerFunciones.frmPregunta.MostrarDialogYesCancel(cadena); }
        private void btncancelar_Click(object sender, EventArgs e)
        {
            if (Estado == 0)
            {

                this.Close();
            }
            else
            {
                Estado = 0;
                ModoEdicion(false);
                CargarDatos();
                CargarActivos();
            }
        }

        private void dtgActivos_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow Fila = dtgActivos.Rows[e.RowIndex];
                dtpFechaActivacion.Value = (DateTime)Fila.Cells[fechaActivacionDataGridViewTextBoxColumn.Name].Value;
                dtpFechaContable.Value = (DateTime)Fila.Cells[fechaContableDataGridViewTextBoxColumn.Name].Value;
                cboproyecto.SelectedValue = (int)Fila.Cells[pkProyectoDataGridViewTextBoxColumn.Name].Value;
                cboetapa.SelectedValue = (int)Fila.Cells[pkEtapaDataGridViewTextBoxColumn.Name].Value;
                txtVidaUtil.Text = Fila.Cells[vidaUtilDataGridViewTextBoxColumn.Name].Value.ToString();
                txtPorcentajeContable.Text = Fila.Cells[porcentajeContableDataGridViewTextBoxColumn.Name].Value.ToString();
                txtPorcentajeTributario.Text = Fila.Cells[porcentajeTributarioDataGridViewTextBoxColumn.Name].Value.ToString();
                txtValorResidual.Text = Fila.Cells[valorResidualDataGridViewTextBoxColumn.Name].Value.ToString();
                txtValorActivo.Text = Fila.Cells[valorActivoDataGridViewTextBoxColumn.Name].Value.ToString();
                txtGlosa.Text = Fila.Cells[glosaDataGridViewTextBoxColumn.Name].Value.ToString();
                txtCuentaContable.Text = Fila.Cells[cuentaGastoDataGridViewTextBoxColumn.Name].Value.ToString();
                cboCuentaActivo.SelectedValue = Fila.Cells[cuentaActivoDataGridViewTextBoxColumn.Name].Value.ToString();
                cboCuentaDepreciacion.SelectedValue = Fila.Cells[cuentaGastoDataGridViewTextBoxColumn.Name].Value.ToString();
                string[] Lfac = Fila.Cells[facturasDataGridViewTextBoxColumn.Name].Value.ToString().Split(',');
                foreach (DataGridViewRow item in Dtgconten.Rows)
                {
                    if (Lfac.Contains(item.Cells[xpkid.Name].Value.ToString()))
                        item.Cells[xOK.Name].Value = 1;

                }


            }
        }
    }
}
