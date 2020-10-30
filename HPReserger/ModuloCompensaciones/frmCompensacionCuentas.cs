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

namespace HPReserger.ModuloCompensaciones
{
    public partial class frmCompensacionCuentas : FormGradient
    {
        HPResergerCapaLogica.HPResergerCL CapaLogica = new HPResergerCapaLogica.HPResergerCL();
        private int pkEmpresa;
        private int _Estado = 0;
        public int Estado
        {
            get { return _Estado; }
            set
            {
                _Estado = value;
                //Control del Formulario
                Boolean a = true;
                btnPaso1.Enabled = !a;
                if (value == 0)
                {
                    cboempresa.Enabled = a;
                    txtcuos.Enabled = a;
                    dtgconten.Enabled = !a;
                    btnPaso1.Enabled = a;
                    if (dtgconten.DataSource != null)
                    {
                        dtgconten.DataSource = ((DataTable)dtgconten.DataSource).Clone();
                    }
                    else dtgconten.DataSource = null;
                    lbltotalRegistros.Text = $"Total de Registros:{dtgconten.RowCount}";
                    contador = 0;
                    MostrarParteFinal();
                }
                else if (value == 1)
                {
                    cboempresa.Enabled = !a;
                    txtcuos.Enabled = !a;
                    dtgconten.Enabled = a;
                }
            }
        }
        public void msgError(string cadena) { HPResergerFunciones.frmInformativo.MostrarDialogError(cadena); }
        public void msgOK(string cadena) { HPResergerFunciones.frmInformativo.MostrarDialog(cadena); }
        public DialogResult msgp(string cadena) { return HPResergerFunciones.frmPregunta.MostrarDialogYesCancel(cadena); }
        public frmCompensacionCuentas()
        {
            InitializeComponent();
        }
        private void frmCompensacionCuentas_Load(object sender, EventArgs e)
        {
            dtpFechaContable.Value = dtpFechaEmision.Value = DateTime.Now;
            CargarTextxDefecto();
            Estado = 0;
            CargarEmpresa();
            CargarMonedas();
        }
        public void CargarMonedas()
        {
            CapaLogica.TablaMonedas(cbomoneda);
        }
        private void CargarTextxDefecto()
        {
            txtcuos.CargarTextoporDefecto();
            txtCuenta.CargarTextoporDefecto();
            txtGlosa.CargarTextoporDefecto();
        }
        public void CargarEmpresa()
        {
            cboempresa.ValueMember = "codigo";
            cboempresa.DisplayMember = "descripcion";
            cboempresa.DataSource = CapaLogica.getCargoTipoContratacion("Id_empresa", "empresa", "tbl_empresa");
        }

        private void cboempresa_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (pkEmpresa != (int)(cboempresa.SelectedValue))
            {
                pkEmpresa = (int)cboempresa.SelectedValue;
                cboproyecto.DataSource = CapaLogica.ListarProyectosEmpresa(cboempresa.SelectedValue.ToString());
                cboproyecto.DisplayMember = "proyecto";
                cboproyecto.ValueMember = "id_proyecto";
            }
        }
        private void cboempresa_Click(object sender, EventArgs e)
        {
            string cadena = cboempresa.Text;
            DataTable Table = CapaLogica.Empresa();
            if (cboempresa.Items.Count != Table.Rows.Count)
                cboempresa.DataSource = Table;
            cboempresa.Text = cadena;
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            if (Estado == 0)
            {
                this.Close();
            }
            else Estado--;
        }
        DataTable Tdatos = new DataTable();
        private int contador;

        private void btnPaso1_Click(object sender, EventArgs e)
        {
            if (cboempresa.SelectedValue == null) { msgError("Seleccione una Empresa"); cboempresa.Focus(); return; }
            if (Configuraciones.ValidarSQLInyect(txtcuos)) { msgError("Codigo Malicioso Detectado"); txtcuos.Focus(); return; }
            if (!txtcuos.EstaLLeno()) { msgError("Ingrese 2 CUOS minimos"); txtcuos.Focus(); return; }
            if ((txtcuos.TextValido().Split(',')).Count() < 2) { msgError("Ingrese 2 CUOS minimos"); txtcuos.Focus(); return; }
            List<string> Listado = new List<string>();
            Tdatos = CapaLogica.CompensacionDeCuentas(pkEmpresa, txtcuos.TextValido());
            foreach (DataRow item in Tdatos.Rows)
            {
                if (!Listado.Contains(item["cuo"].ToString())) Listado.Add(item["cuo"].ToString());
            }
            if (Listado.Count < 2) { msgError("CUOS invalidos, verifique que los CUOS Existan"); return; }
            Estado++;
            dtgconten.DataSource = Tdatos;
            lbltotalRegistros.Text = $"Total de Registros:{dtgconten.RowCount}";
            //Cambio de color de fondo por cuos
            int pos = 0;
            string cuo = "";
            foreach (DataGridViewRow item in dtgconten.Rows)
            {
                if (item.Cells[xCUO.Name].Value.ToString() != cuo)
                {
                    pos = pos == 0 ? 1 : 0;
                }
                cuo = item.Cells[xCUO.Name].Value.ToString();
                if (pos == 0)
                    item.DefaultCellStyle.BackColor = Color.White;
                else
                    item.DefaultCellStyle.BackColor = Color.FromArgb(220, 230, 241);
            }
        }
        decimal SumaSoles = 0, SumaDolares = 0;
        private int idDinamica = -23;
        private void dtgconten_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
                if (e.ColumnIndex == dtgconten.Columns[xok.Name].Index)
                {
                    CalcularTotales();
                }
        }
        private void txtCuenta_DoubleClick(object sender, EventArgs e)
        {
            frmlistarcuentas cuentitas = new frmlistarcuentas();
            cuentitas.Icon = Icon;

            cuentitas.Txtbusca.Text = txtCuenta.Text;
            cuentitas.radioButton1.Checked = true;
            cuentitas.ShowDialog();
            if (cuentitas.aceptar)
                txtCuenta.Text = cuentitas.codigo;
        }
        private void txtCuenta_TextChanged(object sender, EventArgs e)
        {
            if (txtCuenta.EstaLLeno())
            {
                DataTable TAble = CapaLogica.BuscarCuentas(txtCuenta.Text, 1);
                if (TAble.Rows.Count > 0)
                    txtdescripcion.Text = TAble.Rows[0][0].ToString();
                else txtdescripcion.Text = "";
            }
            else txtdescripcion.CargarTextoporDefecto();

        }

        private void dtgconten_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
                if (e.ColumnIndex == dtgconten.Columns[xok.Name].Index)
                {
                    dtgconten.EndEdit(); dtgconten.RefreshEdit();
                    // CalcularTotales();
                }
        }

        private void CalcularTotales()
        {
            SumaSoles = 0; SumaDolares = 0;
            contador = 0;
            if (Estado == 1)
            {
                foreach (DataRow item in Tdatos.Rows)
                {
                    if ((int)item[xok.DataPropertyName] == 1)
                    {
                        contador++;
                        SumaSoles += (decimal)item[xDebeSoles.DataPropertyName] - (decimal)item[xHaberSoles.DataPropertyName];
                        SumaDolares += (decimal)item[xDebeDolares.DataPropertyName] - (decimal)item[xHaberDOlares.DataPropertyName];
                    }

                }
            }
            MostrarParteFinal();
        }

        private void btnProcesar_Click(object sender, EventArgs e)
        {
            if (cboproyecto.SelectedValue == null) { msgError("Seleccione un Proyecto"); cboproyecto.Focus(); return; }
            if (cbomoneda.SelectedValue == null) { msgError("Seleccione una Moneda"); cbomoneda.Focus(); return; }
            if (!txtdescripcion.EstaLLeno()) { msgError("Ingrese una Cuenta Contable para mandar la Diferncia"); txtCuenta.Focus(); return; }
            if (!txtGlosa.EstaLLeno()) { msgError("Ingrese una Glosa"); txtGlosa.Focus(); return; }
            if (cboempresa.SelectedValue == null) { msgError("Seleccione una Empresa"); cboempresa.Focus(); return; }
            if (SumaDolares + SumaSoles == 0) { msgError("No se ha Generado Diferencia"); return; }
            //
            //Validacion de que el periodo NO sea muy disperso, sea un mes continuo a los trabajados        
            DateTime FechaContable = dtpFechaContable.Value;
            if (!CapaLogica.ValidarCrearPeriodo(pkEmpresa, FechaContable))
            {
                if (HPResergerFunciones.frmPregunta.MostrarDialogYesCancel("No se Puede Registrar este Asiento\nEl Periodo no puede Crearse", $"¿Desea Crear el Periodo de {FechaContable.ToString("MMMM")}-{FechaContable.Year}?") != DialogResult.Yes)
                    return;
            }
            if (!CapaLogica.VerificarPeriodoAbierto(pkEmpresa, FechaContable))
            {
                msgError("El Periodo Esta Cerrado, Cambie Fecha Contable"); dtpFechaContable.Focus(); return;
            }
            if (msgp("¿Seguro Desea Grabar la Compensacion?") == DialogResult.Yes)
            {
                //Asientos
                int numasiento = 0;
                if (numasiento == 0)
                {
                    DataTable asientito = CapaLogica.UltimoAsiento((int)cboempresa.SelectedValue, dtpFechaContable.Value);
                    DataRow asiento = asientito.Rows[0];
                    if (asiento == null) { numasiento = 1; }
                    else
                        numasiento = ((int)asiento["codigo"]);
                }
                int PosFila = 0;
                string Cuo = HPResergerFunciones.Utilitarios.Cuo(numasiento, dtpFechaContable.Value);
                int moneda = (int)cbomoneda.SelectedValue;
                int proyecto = (int)cboproyecto.SelectedValue;
                string GlosaCab = txtGlosa.TextValido();
                DateTime FechaEmision = dtpFechaEmision.Value;
                //
                int idUsuario = frmLogin.CodigoUsuario;
                //
                List<string> LCuentas = new List<string>();
                //Add Listado de Cuentas
                foreach (DataRow item in Tdatos.Rows)
                    if ((int)item[xok.DataPropertyName] == 1)
                        if (!LCuentas.Contains(item[xCuenta.DataPropertyName].ToString()))
                            LCuentas.Add(item[xCuenta.DataPropertyName].ToString());
                //Grabamos Cabecera y Detalle de los Datos de la Grilla
                DataView dv = new DataView(Tdatos);
                decimal Soles = 0, Dolares = 0;
                foreach (string Cuenta in LCuentas)
                {
                    Soles = Dolares = 0;
                    dv.RowFilter = $"cuenta = {Cuenta} and ok=1";
                    foreach (DataRow itemx in dv.ToTable().Rows)
                    {
                        Soles += (decimal)itemx[xDebeSoles.DataPropertyName] - (decimal)itemx[xHaberSoles.DataPropertyName];
                        Dolares += (decimal)itemx[xDebeDolares.DataPropertyName] - (decimal)itemx[xHaberDOlares.DataPropertyName];
                    }
                    int FactorSOles = Soles > 0 ? 1 : -1;
                    int FactorDolares = Dolares > 0 ? 1 : -1;
                    //Grabamos la Cabeceras
                    CapaLogica.InsertarAsientoFacturaCabecera(1, ++PosFila, numasiento, FechaContable, Cuenta,
                        (moneda == 1 ? Soles : Dolares) > 0 ? Math.Abs((moneda == 1 ? Soles : Dolares)) : 0,
                        (moneda == 1 ? Soles : Dolares) < 0 ? Math.Abs((moneda == 1 ? Soles : Dolares)) : 0,
                        3.3000m, proyecto, 0, Cuo, moneda, GlosaCab, FechaEmision, idDinamica);
                    //Grabamos el Detalle 
                    foreach (DataRow itemx in dv.ToTable().Rows)
                    {
                        CapaLogica.InsertarDetalleAsiento(11, PosFila, numasiento, FechaContable, Cuenta, proyecto, (int)itemx[xtipodoc.DataPropertyName], itemx[xNumDoc.DataPropertyName].ToString(),
                            itemx[xRazonSocial.DataPropertyName].ToString(), (int)itemx[xidComprobante.DataPropertyName], itemx[xCodComprobante.DataPropertyName].ToString(),
                            itemx[xNumComprobante.DataPropertyName].ToString(), (int)itemx[xCC.DataPropertyName], (DateTime)itemx[xFechaEmision.DataPropertyName],
                            (DateTime)itemx[xFechaVence.DataPropertyName], (DateTime)itemx[xFechaREcepcion.DataPropertyName],
                           FactorSOles * ((decimal)itemx[xDebeSoles.DataPropertyName] - (decimal)itemx[xHaberSoles.DataPropertyName]),
                           FactorDolares * ((decimal)itemx[xDebeDolares.DataPropertyName] - (decimal)itemx[xHaberDOlares.DataPropertyName]),
                            (decimal)itemx[xTC.DataPropertyName], (int)itemx[xfkmoneda.DataPropertyName],
                            (int)itemx[xctabanco.DataPropertyName], "", itemx[xGlosa.DataPropertyName].ToString(), FechaContable, idUsuario, itemx[xCUO.DataPropertyName].ToString(), 0);
                    }
                }
                //Grabamos lo que se envia a la cuenta de diferencia                
                CapaLogica.InsertarAsientoFacturaCabecera(1, ++PosFila, numasiento, FechaContable, txtCuenta.Text,
                    (moneda == 1 ? SumaSoles : SumaDolares) < 0 ? Math.Abs((moneda == 1 ? SumaSoles : SumaDolares)) : 0,
                    (moneda == 1 ? SumaSoles : SumaDolares) > 0 ? Math.Abs((moneda == 1 ? SumaSoles : SumaDolares)) : 0,
                    3.3000m, proyecto, 0, Cuo, moneda, GlosaCab, FechaEmision, idDinamica);
                //Grabamos el Detalle 
                CapaLogica.InsertarDetalleAsiento(11, PosFila, numasiento, FechaContable, txtCuenta.Text, proyecto, 0, "99999999", "", 0, "", "9999", 0, FechaEmision, FechaContable, FechaContable,
                    Math.Abs(SumaSoles), Math.Abs(SumaDolares), 3.3000m, moneda, 0, "", GlosaCab, FechaContable, idUsuario, "", 0);
                //Fin de la Grabacion
                msgOK("Compensación Grabada con Exito");
                Estado = 0;
            }
        }
        private void MostrarParteFinal()
        {
            //Bloquear Controles
            Boolean a = true;
            txtCuenta.Enabled = !a;
            txtdescripcion.Enabled = !a;
            txtGlosa.Enabled = !a;
            btnProcesar.Visible = !a;
            txtSoles.Text = txtDolares.Text = "0.00";
            //
            cboproyecto.Enabled = !a;
            cbomoneda.Enabled = !a;
            dtpFechaContable.Enabled = !a;
            dtpFechaEmision.Enabled = !a;
            if (contador > 1)
            {
                //Desbloquearlos
                txtCuenta.Enabled = a;
                txtdescripcion.Enabled = a;
                txtGlosa.Enabled = a;
                btnProcesar.Visible = a;
                txtSoles.Text = txtDolares.Text = SumaSoles.ToString("n2");
                txtDolares.Text = SumaDolares.ToString("n2");
                cboproyecto.Enabled = dtpFechaContable.Enabled = dtpFechaEmision.Enabled = a;
                if (SumaSoles != 0 && SumaDolares != 0)
                {
                    cbomoneda.Enabled = a;
                }
                if (SumaDolares != 0) cbomoneda.SelectedValue = 2;
                if (SumaSoles != 0) cbomoneda.SelectedValue = 1;
            }
        }
    }
}
