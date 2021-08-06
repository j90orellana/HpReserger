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
        private int codigo;
        private string CuoAsiento;

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
            Configuraciones.CargarTextoPorDefecto(txtGlosa, txtfiltro);
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
        DataView dv;
        private void CargarDatos()
        {
            dv = CapaLogica.ActivoFijosParaDepreciar(_idempresa, cboMesAnio.FechaFinMes).AsDataView();
            Dtgconten.DataSource = dv;
            ContarRegistros();
            //Quitamos que se pueda dar check a un registro Depreciado
            foreach (DataGridViewRow item in Dtgconten.Rows)
            {
                if (item.Cells[xCompensado.Name].Value.ToString() != "FALTA")
                {
                    item.Cells[xok.Name].ReadOnly = true;
                }
            }
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
                if (Dtgconten.DataSource != null) Dtgconten.DataSource = dv.ToTable().Clone();
                else Dtgconten.DataSource = null;
                ConReg = 0;
                ContarRegistros();
                cargarValoresDefecto();
            }
        }

        private void ModoEdicion(bool v)
        {
            cboempresa.Enabled = cboMesAnio.Enabled = !v;
            btnAvanzar.Enabled = !v;
            btnProcesar.Visible = v;
            txtfiltro.Enabled = v;
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
                        {

                            if (item.Cells[xcc.Name].Value.ToString().Contains("/"))
                            {
                                string prueba = item.Cells[xcc.Name].Value.ToString();
                                txtGlosa.Text = $"{prueba.Substring(0, prueba.IndexOf('.'))}.{cboMesAnio.FechaFinMes.ToString("MMMyy")}/{prueba.Substring(prueba.IndexOf('/') + 1)}";
                            }
                            else
                                txtGlosa.Text = $"DEPREC.{cboMesAnio.FechaFinMes.ToString("MMMyy")}/{item.Cells[xcc.Name].Value.ToString()}";
                        }
                        ConReg++;
                    }
                }
                ContarRegistros();
            }
        }
        public DialogResult msgp(string cadena) { return HPResergerFunciones.frmPregunta.MostrarDialogYesCancel(cadena); }

        private void btnProcesar_Click(object sender, EventArgs e)
        {
            txtfiltro.CargarTextoporDefecto();
            if (msgp("Seguro Desea Grabar la Depreciación") == DialogResult.Yes)
            {
                if (Estado == 1) //Generar Asiento contable y Registro en la tabla de depreciacion
                {
                    //CARGAR VARIABLES
                    _idempresa = (int)cboempresa.SelectedValue;
                    _proyecto = (int)cboproyecto.SelectedValue;
                    _etapa = (int)cboetapa.SelectedValue;
                    int _dinamica = -26;
                    DateTime FechaContable = cboMesAnio.FechaFinMes;
                    string Glosa = txtGlosa.TextValido();
                    int _estado = 1;
                    decimal tc = CapaLogica.TipoCambioDia("Venta", FechaContable);
                    //PROCESO DE VALIDACIONES
                    if (cboempresa.SelectedValue == null) { cboempresa.Focus(); msgError("Seleccione una Empresa"); return; }
                    if (cboproyecto.SelectedValue == null) { cboproyecto.Focus(); msgError("Seleccione un Proyecto"); return; }
                    if (cboetapa.SelectedValue == null) { cboetapa.Focus(); msgError("Seleccione una Etapa"); return; }
                    //              
                    if (!txtGlosa.EstaLLeno()) { txtGlosa.Focus(); msgError("Escriba una Glosa"); return; }
                    if (ConReg == 0) { msgError("Debe Seleccionar Activos Fijos para Depreciar"); return; }
                    if (tc == 0) { msgError("No hay TIPO DE CAMBIO para el fin de mes del Mes Contable"); return; }
                    //VALIDACION DE CUENTAS CONTABLES Y PERIODOS
                    if (!CapaLogica.ValidarCrearPeriodo(_idempresa, FechaContable))
                    {
                        if (HPResergerFunciones.frmPregunta.MostrarDialogYesCancel("No se Puede Registrar este Asiento\nEl Periodo no puede Crearse", $"¿Desea Crear el Periodo de {FechaContable.ToString("MMMM")}-{FechaContable.Year}?") != DialogResult.Yes)
                            return;
                    }
                    else if (!CapaLogica.VerificarPeriodoAbierto(_idempresa, FechaContable))
                    {
                        msgError("El Periodo Esta Cerrado, Cambie Fecha Contable");  return;
                    }
                    //DataTable TPrueba2 = CapaLogica.VerPeriodoAbierto(_idempresa, FechaContable);
                    //if (TPrueba2.Rows.Count == 0) { msgError("El Periodo está Cerrado, Debe Abrirlo"); return; }
                    //
                    if (Estado == 1)//Nuevo                
                        CapaLogica.UltimoAsiento(_idempresa, FechaContable, out codigo, out CuoAsiento);
                    //validamos que las cuentas contables NO esten desactivadas
                    List<string> ListaAuxiliar = new List<string>();
                    if (ConReg > 1)
                        foreach (DataGridViewRow item in Dtgconten.Rows)
                            if ((int)item.Cells[xok.Name].Value == 1)
                            {
                                ListaAuxiliar.Add(item.Cells[xCGasto.Name].Value.ToString());
                                ListaAuxiliar.Add(item.Cells[xCDepreciacion.Name].Value.ToString());
                            }
                    if (CapaLogica.CuentaContableValidarActivas(string.Join(",", ListaAuxiliar.ToArray()), "Cuentas Contables Desactivadas")) return;
                    //GRABAMOS LOS ASIENTOS CONTABLES
                    int i = 0;
                    foreach (DataGridViewRow item in Dtgconten.Rows)
                    {
                        if ((int)item.Cells[xok.Name].Value == 1)
                        {
                            i++;
                            string SerFac = "VR";
                            string NumFac = FechaContable.ToString("yyyy-MM");
                            int idcomprobante = Configuraciones.DefIdComprobante;
                            string ruc = "0";
                            string razon = "";
                            decimal soles = (decimal)item.Cells[xVContable.Name].Value;
                            decimal dolares = soles / tc;
                            int idUsuario = frmLogin.CodigoUsuario;
                            //CABECERA ASIENTO DEL GASTO AL DEBE
                            CapaLogica.InsertarAsiento(i, codigo, FechaContable, item.Cells[xCGasto.Name].Value.ToString(), soles, 0, _dinamica, 1, FechaContable, _proyecto, _etapa,
                                Glosa, 1, tc);
                            //DETALLE ASIENTO DEL GASTO AL DEBE
                            CapaLogica.DetalleAsientos(1, i, codigo, item.Cells[xCGasto.Name].Value.ToString(), 5, ruc, razon, idcomprobante, SerFac, NumFac, 0, Glosa, FechaContable, FechaContable,
                                soles, dolares, tc, idUsuario, _proyecto, FechaContable, 1, FechaContable, 0, "", "", 0);
                            i++;
                            //CABECERA ASIENTO DEL GASTO AL HABER
                            CapaLogica.InsertarAsiento(i, codigo, FechaContable, item.Cells[xCDepreciacion.Name].Value.ToString(), 0, soles, _dinamica, 1, FechaContable, _proyecto, _etapa,
                                Glosa, 1, tc);
                            //DETALLE ASIENTO DEL GASTO AL HABER
                            CapaLogica.DetalleAsientos(1, i, codigo, item.Cells[xCDepreciacion.Name].Value.ToString(), 5, ruc, razon, idcomprobante, SerFac, NumFac, 0, Glosa, FechaContable,
                                FechaContable, soles, dolares, tc, idUsuario, _proyecto, FechaContable, 1, FechaContable, 0, "", "", 0);
                        }
                    }
                    CapaLogica.CuadrarAsiento(CuoAsiento, _proyecto, FechaContable, 1);
                    //GRABAMOS EL DETALLE DE LA DEPRECIACION
                    foreach (DataGridViewRow item in Dtgconten.Rows)
                    {
                        if ((int)item.Cells[xok.Name].Value == 1) //Los Activos Seleccionados
                        {
                            CapaLogica.ActivoFijo_Depreciacion(1, 0, (int)item.Cells[xpkid.Name].Value, _idempresa, FechaContable, (int)item.Cells[xMes.Name].Value,
                                (decimal)item.Cells[xVTributario.Name].Value, (decimal)item.Cells[xVContable.Name].Value, CuoAsiento, Glosa, _estado);
                        }
                    }
                    msgOK($"Depreciación Grabada con Exito\nCon Cuo: {CuoAsiento}");
                    Estado = 0;
                    ModoEdicion(false);
                    ConReg = 0;
                    if (Dtgconten.DataSource != null) Dtgconten.DataSource = dv.ToTable().Clone();
                    else Dtgconten.DataSource = null;
                    cargarValoresDefecto();
                    ContarRegistros();
                }
            }
        }

        private void Dtgconten_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
                if (Estado == 1)
                    if (Dtgconten[xCompensado.Name, e.RowIndex].Value.ToString() != "FALTA")
                    {
                        msgError("No Se Puede Seleccionar, El Activo Ya Fue Depreciado Este Mes");
                    }
        }

        private void txtfiltro_TextChanged(object sender, EventArgs e)
        {
            if (txtfiltro.EstaLLeno())
            {
                dv.RowFilter = $"glosa like '%{txtfiltro.TextValido()}%' or ccdepre like '%{txtfiltro.TextValido()}%' or ccgasto like '%{txtfiltro.TextValido()}%' or ccactivo like '%{txtfiltro.TextValido()}%'";
            }
            else
            {
                dv.RowFilter = "";
                dv.Sort = $" {xok.DataPropertyName} desc";
            }
        }
    }
}
