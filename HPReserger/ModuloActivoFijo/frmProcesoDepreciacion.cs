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
    public partial class frmProcesoDepreciacion : FormGradient
    {
        public frmProcesoDepreciacion()
        {
            InitializeComponent();
        }
        HPResergerCapaLogica.HPResergerCL CapaLogica = new HPResergerCapaLogica.HPResergerCL();
        private int _proyecto;
        private int _idempresa;
        private int Estado;
        private int _etapa;
        public void msgError(string cadena) { HPResergerFunciones.frmInformativo.MostrarDialogError(cadena); }
        public void msgOK(string cadena) { HPResergerFunciones.frmInformativo.MostrarDialog(cadena); }
        public void CargarEmpresa()
        {
            CapaLogica.TablaEmpresas(cboempresa);
        }
        private void frmProcesoDepreciacion_Load(object sender, EventArgs e)
        {
            CargarEmpresa();
            //CargarDatos();
            //CArgarCuentas();
            //CargarCuentaActivo();
            //
            //Estado = 0; ModoEdicion(false);
            //CargarActivos();
            cargarValoresDefecto();
        }
        private void cargarValoresDefecto()
        {
            Configuraciones.CargarTextoPorDefecto(txtGlosa);
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
                    //CargarDatos();
                    //SumarTotalActivo();
                    //CargarActivos();
                }
            }
            else msgError("No hay Empresas");
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

        private void btnAvanzar_Click(object sender, EventArgs e)
        {
            Estado = 1;
            ModoEdicion(true);
            CargarDatos();
            //if (!txtGlosa.EstaLLeno())
            txtGlosa.Text = $"DEPREC.{cboMesAnio.FechaFinMes.ToString("MMMyy")}/";
        }

        private void CargarDatos()
        {
            Dtgconten.DataSource = CapaLogica.ActivoFijosParaDepreciar(_idempresa, cboMesAnio.FechaFinMes);
            ContarRegistros();
        }
        public int ConReg { get; private set; }
        private void ContarRegistros()
        {
            lblRegistros.Text = $"Total Registros: {Dtgconten.RowCount}, Seleccionadas: {ConReg}";
        }
        private void btncancelar_Click(object sender, EventArgs e)
        {
            if (Estado == 0) this.Close();
            else
            {
                Estado = 0;
                ModoEdicion(false);
                if (Dtgconten.DataSource != null) Dtgconten.DataSource = ((DataTable)Dtgconten.DataSource).Clone();
                else Dtgconten.DataSource = null;
                ConReg = 0;
                ContarRegistros();
            }
        }

        private void ModoEdicion(bool v)
        {
            cboempresa.Enabled = cboMesAnio.Enabled = !v;
            btnAvanzar.Enabled = !v;
            btnProcesar.Visible = v;
            foreach (DataGridViewColumn item in Dtgconten.Columns)
                item.ReadOnly = true;
            if (v)
            {
                Dtgconten.Columns[xok.Name].ReadOnly = false;
            }
        }

        private void Dtgconten_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0) //la columna con check OK
                Dtgconten.EndEdit();
        }

        private void Dtgconten_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0) // la columna del OK
            {
                ConReg = 0;
                foreach (DataGridViewRow item in Dtgconten.Rows)
                {
                    if ((int)item.Cells[xok.Name].Value == 1)
                    {
                        if (ConReg == 0)
                            txtGlosa.Text = $"DEPREC.{cboMesAnio.FechaFinMes.ToString("MMMyy")}/{item.Cells[xcc.Name].Value.ToString()}";
                        ConReg++;
                    }
                }
                ContarRegistros();
            }
        }
        public DialogResult msgp(string cadena) { return HPResergerFunciones.frmPregunta.MostrarDialogYesCancel(cadena); }

        private void btnProcesar_Click(object sender, EventArgs e)
        {
            if (msgp("Seguro Desea Grabar la Depreciación") == DialogResult.Yes)
            {
                if (Estado == 1) //Generar Asiento contable y Registro en la tabla de depreciacion
                {
                    //PROCESO DE VALIDACIONES
                    if (cboempresa.SelectedValue == null) { cboempresa.Focus(); msgError("Seleccione una Empresa"); return; }
                    if (cboproyecto.SelectedValue == null) { cboproyecto.Focus(); msgError("Seleccione un Proyecto"); return; }
                    if (cboetapa.SelectedValue == null) { cboetapa.Focus(); msgError("Seleccione una Etapa"); return; }
                    //              
                    if (!txtGlosa.EstaLLeno()) { txtGlosa.Focus(); msgError("Escriba una Glosa"); return; }
                    if (ConReg == 0) { msgError("Debe Seleccionar Activos Fijos para Depreciar"); return; }
                    //CARGAR VARIABLES
                    _idempresa = (int)cboempresa.SelectedValue;
                    _proyecto = (int)cboproyecto.SelectedValue;
                    _etapa = (int)cboetapa.SelectedValue;
                    DateTime FechaContable = cboMesAnio.FechaFinMes;
                    string Glosa = txtGlosa.TextValido();
                    int _estado = 1;

                    //GRABAMOS EL DETALLE DE LA DEPRECIACION
                    foreach (DataGridViewRow item in Dtgconten.Rows)
                    {
                        if ((int)item.Cells[xok.Name].Value == 1) //Los Activos Seleccionados
                        {
                            CapaLogica.ActivoFijo_Depreciacion(1, 0, (int)item.Cells[xpkid.Name].Value, _idempresa, FechaContable, (int)item.Cells[xMes.Name].Value,
                                (decimal)item.Cells[xVTributario.Name].Value, (decimal)item.Cells[xVContable.Name].Value, "", Glosa, _estado);
                        }
                    }
                    msgOK("Depreciación Grabada con Exito");
                    Estado = 0;
                    ModoEdicion(false);
                    CargarDatos();
                    cargarValoresDefecto();
                    ConReg = 0;
                    ContarRegistros();
                }
            }
        }
    }
}
