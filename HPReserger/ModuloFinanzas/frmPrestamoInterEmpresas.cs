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
    public partial class frmPrestamoInterEmpresas : FormGradient
    {
        public frmPrestamoInterEmpresas()
        {
            InitializeComponent();
        }
        HPResergerCapaLogica.HPResergerCL CapaLogica = new HPResergerCapaLogica.HPResergerCL();
        public void msg(string cadena) { HPResergerFunciones.frmInformativo.MostrarDialogError(cadena); }
        public void msgOK(string cadena) { HPResergerFunciones.frmInformativo.MostrarDialog(cadena); }

        public void CargarEmpresaOri() { CapaLogica.TablaEmpresa(cboOriEmpresa); }
        public void CargarEmpresaDes() { CapaLogica.TablaEmpresa(cboDesEmpresa); }
        public void CargarCuentaOrigen()
        {
            DataTable Tablita = CapaLogica.BuscarcuentasInterEmpresas(FkMoneda);
            cboOriCuentaContable.DisplayMember = "descripcion";
            cboOriCuentaContable.ValueMember = "codigo";
            cboOriCuentaContable.DataSource = Tablita;
            //por defecto la 17
        }
        public void CargarCuentaDestino()
        {
            DataTable Tablita = CapaLogica.BuscarcuentasInterEmpresas(FkMoneda);
            cboDesCuentaContable.DisplayMember = "descripcion";
            cboDesCuentaContable.ValueMember = "codigo";
            cboDesCuentaContable.DataSource = Tablita;
            //por defecto la 47
        }
        public void CargarMoneda() { CapaLogica.TablaMoneda(cbomoneda); }
        private void frmPrestamoInterEmpresas_Load(object sender, EventArgs e)
        {
            //Carga Datos Principales
            txtGlosa.CargarTextoporDefecto(); txtMontoPrestamo.CargarTextoporDefecto(); txtTipoCambio.CargarTextoporDefecto();
            //txtOriCuentaContable.Text = txtDesCuentaContable.Text = "101";
            //txtOriCuentaContable.CargarTextoporDefecto(); txtDesCuentaContable.CargarTextoporDefecto();
            //
            txtbusMoneda.CargarTextoporDefecto(); txtbusempresaorigen.CargarTextoporDefecto(); txtbusempresadestino.CargarTextoporDefecto();
            dtpFechaContable.Value = dtpFechaPrestamo.Value = DateTime.Now;
            CargarMoneda();
            //Empresas
            CargarEmpresaOri();
            CargarEmpresaDes();
            //Cuentas Contables 
            CargarCuentaDestino();
            CargarCuentaOrigen();
            //Bancos
            cboOriBanco_Click(sender, e);
            cboDesBanco_Click(sender, e);
            //Periodo Anual para la Busqueda
            dtpfechabus1.Value = new DateTime(DateTime.Now.Year, 1, 1);
            dtpfechabus2.Value = new DateTime(DateTime.Now.Year, 12, 31);
            ModoEdicion(false);
            CargaDatos();
        }
        public void ModoEdicion(Boolean a)
        {
            //Combos
            cboOriBanco.Enabled = cboOriCuentaBanco.Enabled = cboOriCuentaContable.Enabled = cboOriEmpresa.Enabled = cboOriProyecto.Enabled = cboOriEtapa.Enabled =
            cboDesBanco.Enabled = cboDesCuentaBanco.Enabled = cboDesCuentaContable.Enabled = cboDesEmpresa.Enabled = cboDesEtapa.Enabled = cboDesProyecto.Enabled = cbomoneda.Enabled = a;
            //textbox
            txtMontoPrestamo.Enabled = txtTipoCambio.Enabled = txtGlosa.Enabled = dtpFechaPrestamo.Enabled = dtpFechaContable.Enabled = a;
            //Textbox Busquedas
            chkAnulado.Enabled = chkCancelado.Enabled = chkbusEstados.Enabled = txtbusempresadestino.Enabled = txtbusempresaorigen.Enabled = txtbusMoneda.Enabled = dtpfechabus1.Enabled = dtpfechabus2.Enabled = !a;
            //datagrid
            dtgconten.Enabled = !a;
            //Botones
            btnCambiar.Enabled = btnActualizar.Enabled = btncleanfind.Enabled = !a;
            //Filtros Activada
            Busqueda = !a;
        }
        public void CargaDatos()
        {
            if (Busqueda && Estado == 0)
            {
                DateTime fechaaux = dtpfechabus1.Value;
                DateTime fecha1 = dtpfechabus1.Value;
                DateTime fecha2 = dtpfechabus2.Value;
                if (fecha1 > fecha2)
                {
                    fecha1 = fecha2;
                    fecha2 = fechaaux;
                }
                dtgconten.DataSource = CapaLogica.PrestamosInterEmpresa(0, txtbusempresaorigen.TextValido(), txtbusempresadestino.TextValido(), txtbusMoneda.TextValido(), fecha1, fecha2, chkbusEstados.Checked ? 1 : -1, chkCancelado.Checked ? 3 : -1, chkAnulado.Checked ? 0 : -1);
                lblmensaje.Text = $"Total de Registros {dtgconten.RowCount}";
                //Sacamos Los Totales;
                Totales();
            }
        }
        public void Totales()
        {
            decimal SumatoriaMN = 0, SumatoriaME = 0;
            foreach (DataGridViewRow item in dtgconten.Rows)
            {
                if ((int)item.Cells[xEstado.Name].Value == 1 || (int)item.Cells[xEstado.Name].Value == 2)
                    if (item.Cells[xmon.Name].Value.ToString() == "SOL")
                        SumatoriaMN += (decimal)item.Cells[ximporte.Name].Value;
                    else
                        SumatoriaME += (decimal)item.Cells[ximporte.Name].Value;
            }
            txtMN.Text = SumatoriaMN.ToString("n2");
            txtME.Text = SumatoriaME.ToString("n2");
        }
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
                btnaceptar.Enabled = false;
                btnNuevo.Enabled = true;
                if (dtgconten.CurrentRow != null)
                    VerificarParaModificar(dtgconten.CurrentRow.Index);
            }
        }
        private DialogResult msgYesNo(string v)
        {
            return HPResergerFunciones.Utilitarios.msgYesNo(v);
        }
        private void txtTipoCambio_Leave(object sender, EventArgs e)
        {
            decimal valor = 0;
            if (decimal.TryParse(txtTipoCambio.Text, out valor))
                if (valor == 0) { txtTipoCambio.Text = txtTipoCambio.TextoDefecto; }
        }
        frmTipodeCambio frmtipo;
        private int IdEmpresaOri;
        private int IdEmpresaDes;
        public void SacarTipoCambio()
        {
            DateTime FechaValidaBuscar = dtpFechaPrestamo.Value;
            txtTipoCambio.Text = CapaLogica.TipoCambioDia("Venta", FechaValidaBuscar).ToString("n3");
            if (decimal.Parse(txtTipoCambio.Text) == 0)
            {
                if (frmtipo == null)
                {
                    frmtipo = new frmTipodeCambio();
                    frmtipo.ActualizoTipoCambio += Frmtipo_ActualizoTipoCambio;
                    frmtipo.Show();
                    frmtipo.Hide();
                    frmtipo.comboMesAño1.ActualizarMesAÑo(FechaValidaBuscar.Month.ToString(), FechaValidaBuscar.Year.ToString());
                    frmtipo.Buscar_Click(new object(), new EventArgs());
                }
            }
        }
        private void Frmtipo_ActualizoTipoCambio(object sender, EventArgs e)
        {
            frmtipo.Close();
            frmtipo = null;
            SacarTipoCambio();
        }
        private void dtpFechaPrestamo_ValueChanged(object sender, EventArgs e)
        {
            SacarTipoCambio();
        }
        public void CargarCuentasBancosOri()
        {
            if (cboOriEmpresa.SelectedValue != null && cboOriBanco.SelectedValue != null)
            {
                cboOriCuentaBanco.ValueMember = "Id_Cuenta_Contable";
                cboOriCuentaBanco.DisplayMember = "banco";
                cboOriCuentaBanco.DataSource = CapaLogica.ListarBancosTiposdePagoxEmpresa(cboOriBanco.SelectedValue.ToString(), (int)cboOriEmpresa.SelectedValue, (int)cbomoneda.SelectedValue);
            }
        }
        public void CargarCuentasBancosDes()
        {
            if (cboDesEmpresa.SelectedValue != null && cboDesBanco.SelectedValue != null)
            {
                cboDesCuentaBanco.ValueMember = "Id_Cuenta_Contable";
                cboDesCuentaBanco.DisplayMember = "banco";
                cboDesCuentaBanco.DataSource = CapaLogica.ListarBancosTiposdePagoxEmpresa(cboDesBanco.SelectedValue.ToString(), (int)cboDesEmpresa.SelectedValue, (int)cbomoneda.SelectedValue);
            }
        }
        private void cbomoneda_SelectedIndexChanged(object sender, EventArgs e)
        {
            FkMoneda = (int)cbomoneda.SelectedValue;
            CargarCuentasBancosOri(); CargarCuentasBancosDes();
            CargarCuentaOrigen(); CargarCuentaDestino();
        }
        private void cboOriEmpresa_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboOriEmpresa.Items.Count > 0)
            {
                if (cboOriEmpresa.SelectedValue != null)
                {
                    cboOriProyecto.DisplayMember = "proyecto";
                    cboOriProyecto.ValueMember = "id_proyecto";
                    cboOriProyecto.DataSource = CapaLogica.ListarProyectosEmpresa(cboOriEmpresa.SelectedValue.ToString());
                    ///
                    IdEmpresaOri = (int)cboOriEmpresa.SelectedValue;
                    cboOriBanco_SelectedIndexChanged(sender, e);
                }
            }
        }
        private void cboOriProyecto_Click(object sender, EventArgs e)
        {
            if (cboOriEmpresa.SelectedValue != null)
            {
                string cadena = cboOriProyecto.Text;
                DataTable TableAux = CapaLogica.ListarProyectosEmpresa(cboOriEmpresa.SelectedValue.ToString());
                if (TableAux.Rows.Count != cboOriProyecto.Items.Count) { }
                cboOriProyecto.DisplayMember = "proyecto";
                cboOriProyecto.ValueMember = "id_proyecto";
                cboDesProyecto.DataSource = TableAux;
                cboOriProyecto.Text = cadena;
            }
        }
        private void cboOriBanco_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboOriBanco.SelectedIndex >= 0)
            {
                cboOriCuentaBanco.Text = "";
                CargarCuentasBancos(cboOriEmpresa, cboOriBanco, cboOriCuentaBanco);
                //if (cboOriBanco.SelectedValue != null && cboDesBanco.SelectedValue != null)
                //    if (cboOriBanco.SelectedValue.ToString() != cboDesBanco.SelectedValue.ToString())
                //        cboDesCuentaBanco.DisplayMember = "bancocci";
                //    else
                //        cboDesCuentaBanco.DisplayMember = "banco";
            }
        }
        public void CargarCuentasBancos(ComboBox cboempresa, ComboBox cbobanco, ComboBox cbocuenta)
        {
            if (cboempresa.SelectedValue != null && cbobanco.SelectedValue != null)
            {
                cbocuenta.ValueMember = "Id_Cuenta_Contable";
                cbocuenta.DisplayMember = "banco";
                cbocuenta.DataSource = CapaLogica.ListarBancosTiposdePagoxEmpresa(cbobanco.SelectedValue.ToString(), (int)cboempresa.SelectedValue, (int)cbomoneda.SelectedValue);
            }
        }
        private void cboOriBanco_Click(object sender, EventArgs e)
        {
            string cadenar = cboOriBanco.Text;
            DataTable TableBancos = CapaLogica.TablaBanco();
            if (TableBancos.Rows.Count != cboOriBanco.Items.Count)
            {
                cboOriBanco.ValueMember = "sufijo";
                cboOriBanco.DisplayMember = "descripcion";
                cboOriBanco.DataSource = TableBancos;
                cboOriBanco.Text = cadenar;
            }
        }
        private void cboDesBanco_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboDesBanco.SelectedIndex >= 0)
            {
                cboDesCuentaBanco.Text = "";
                CargarCuentasBancos(cboDesEmpresa, cboDesBanco, cboDesCuentaBanco);
                //if (cboOriBanco.SelectedValue != null && cboDesBanco.SelectedValue != null)
                //    if (cboOriBanco.SelectedValue.ToString() != cboDesBanco.SelectedValue.ToString())
                //        cboDesCuentaBanco.DisplayMember = "bancocci";
                //    else
                //        cboDesCuentaBanco.DisplayMember = "banco";
            }
        }
        private void cboDesBanco_Click(object sender, EventArgs e)
        {
            string cadenar = cboDesBanco.Text;
            DataTable TableBancos = CapaLogica.TablaBanco();
            if (TableBancos.Rows.Count != cboDesBanco.Items.Count)
            {
                cboDesBanco.ValueMember = "sufijo";
                cboDesBanco.DisplayMember = "descripcion";
                cboDesBanco.DataSource = TableBancos;
                cboDesBanco.Text = cadenar;
            }
        }
        private void cboDesEmpresa_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboDesEmpresa.Items.Count > 0)
            {
                if (cboDesEmpresa.SelectedValue != null)
                {
                    cboDesProyecto.DisplayMember = "proyecto";
                    cboDesProyecto.ValueMember = "id_proyecto";
                    cboDesProyecto.DataSource = CapaLogica.ListarProyectosEmpresa(cboDesEmpresa.SelectedValue.ToString());
                    //busqueda de Asientos
                    IdEmpresaDes = (int)cboDesEmpresa.SelectedValue;
                    cboDesBanco_SelectedIndexChanged(sender, e);
                }
            }
        }
        private void cboDesProyecto_Click(object sender, EventArgs e)
        {
            if (cboDesEmpresa.SelectedValue != null)
            {
                string cadena = cboDesProyecto.Text;
                DataTable TableAux = CapaLogica.ListarProyectosEmpresa(cboDesEmpresa.SelectedValue.ToString());
                if (TableAux.Rows.Count != cboDesProyecto.Items.Count) { }
                cboDesProyecto.DisplayMember = "proyecto";
                cboDesProyecto.ValueMember = "id_proyecto";
                cboDesProyecto.DataSource = TableAux;
                cboDesProyecto.Text = cadena;
            }
        }
        private void cboOriProyecto_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboOriProyecto.SelectedValue != null)
            {
                cboOriEtapa.ValueMember = "id_etapa";
                cboOriEtapa.DisplayMember = "descripcion";
                cboOriEtapa.DataSource = CapaLogica.ListarEtapasProyecto(cboOriProyecto.SelectedValue.ToString());
            }
        }
        private void cboDesProyecto_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboDesProyecto.SelectedValue != null)
            {
                cboDesEtapa.ValueMember = "id_etapa";
                cboDesEtapa.DisplayMember = "descripcion";
                cboDesEtapa.DataSource = CapaLogica.ListarEtapasProyecto(cboDesProyecto.SelectedValue.ToString());
            }
        }
        private void btnaceptar_Click(object sender, EventArgs e)
        {
            ///Declaraciones
            decimal ValorTC = 0, MontoPrestado = 0;
            string Glosa = "";
            DateTime FechaContable = dtpFechaContable.Value;
            DateTime FechaPrestamo = dtpFechaPrestamo.Value;
            int IdMoneda = (int)cbomoneda.SelectedValue;
            int IdUsuario = frmLogin.CodigoUsuario;
            Boolean Prueba = true;
            string mensaje = "El Periodo esta Cerrado en:";
            ///Conversiones
            decimal.TryParse(txtTipoCambio.Text, out ValorTC);
            decimal.TryParse(txtMontoPrestamo.Text, out MontoPrestado);
            Glosa = txtGlosa.TextValido();
            ///VALIDACIONES
            ///Validacion de PEriodo Contable Cerrado
            if (cboOriEmpresa.SelectedValue == null) { cboOriEmpresa.Focus(); msg("Seleccione Empresa Origen"); return; }
            if (cboDesEmpresa.SelectedValue == null) { cboDesEmpresa.Focus(); msg("Seleccione Empresa Destino"); return; }
            ///validaciones de Logica
            if ((int)cboOriEmpresa.SelectedValue == (int)cboDesEmpresa.SelectedValue) { cboDesEmpresa.Focus(); msg("Seleccione Diferentes Empresas"); return; }
            if (!CapaLogica.VerificarPeriodoAbierto((int)cboOriEmpresa.SelectedValue, FechaContable))
            {
                mensaje += $"\n{cboOriEmpresa.Text}";
                dtpFechaContable.Focus(); Prueba = false;
            }
            if (!CapaLogica.VerificarPeriodoAbierto((int)cboDesEmpresa.SelectedValue, FechaContable))
            {
                mensaje += $"\n{cboDesEmpresa.Text}";
                dtpFechaContable.Focus(); Prueba = false;
            }
            mensaje += "\nCambie Fecha Contable";
            if (!Prueba) { msg(mensaje); return; }
            ///Validaciones de Importes decimales
            if (ValorTC == 0) { txtTipoCambio.Focus(); msg("Revise El tipo de Cambio"); return; }
            if (MontoPrestado == 0) { txtMontoPrestamo.Focus(); msg("El Monto Prestado debe ser Mayor A Cero"); return; }
            //Validaciones de Combos Agrupados
            if (cboOriProyecto.SelectedValue == null) { cboOriProyecto.Focus(); msg("Seleccione Proyecto Origen"); return; }
            if (cboDesProyecto.SelectedValue == null) { cboDesProyecto.Focus(); msg("Seleccione Proyecto Destino"); return; }
            if (cboDesEtapa.SelectedValue == null) { cboDesEtapa.Focus(); msg("Seleccione Etapa Origen"); return; }
            if (cboDesEtapa.SelectedValue == null) { cboDesEtapa.Focus(); msg("Seleccione Etapa Destino"); return; }
            if (cboOriBanco.SelectedValue == null) { cboOriBanco.Focus(); msg("Seleccione Banco Origen"); return; }
            if (cboDesBanco.SelectedValue == null) { cboDesBanco.Focus(); msg("Seleccione Banco Destino"); return; }
            if (cboOriCuentaBanco.SelectedValue == null) { cboOriCuentaBanco.Focus(); msg("Seleccione Cuenta Banco Origen"); return; }
            if (cboDesCuentaBanco.SelectedValue == null) { cboDesCuentaBanco.Focus(); msg("Seleccione Cuenta Banco Destino"); return; }
            if (cboDesCuentaContable.SelectedValue == null) { cboDesCuentaContable.Focus(); msg("Seleccione Cuenta Contable Destino"); return; }
            if (cboOriCuentaContable.SelectedValue == null) { cboOriCuentaContable.Focus(); msg("Ingrese Cuenta Contable del Origen"); return; }
            ///Validaciones de Combos Separados
            if (cbomoneda.SelectedValue == null) { cbomoneda.Focus(); msg("Seleccione Moneda"); return; }
            //Programacion de la Logica          
            int IdAsientoOri = CapaLogica.SiguienteAsiento(IdEmpresaOri, FechaContable);
            int IdAsientoDes = CapaLogica.SiguienteAsiento(IdEmpresaDes, FechaContable);
            string CuoOri = HPResergerFunciones.Utilitarios.Cuo(IdAsientoOri, FechaContable);
            string CuoDes = HPResergerFunciones.Utilitarios.Cuo(IdAsientoDes, FechaContable);
            int IdProyectoOri = (int)(cboOriProyecto.SelectedValue);
            int IdProyectoDes = (int)(cboDesProyecto.SelectedValue);
            int IdEtapaOri = (int)(cboOriEtapa.SelectedValue);
            int IdEtapaDes = (int)(cboDesEtapa.SelectedValue);
            //Modificar Cartel Consulta
            string CartelPregunta = Estado == 1 ? "Seguro Desea Proceder con el Préstamo" : "Seguro Desea Proceder con la Modificación";
            //Procedemos
            if (msgYesNo(CartelPregunta) == DialogResult.Yes)
            {
                //Sí es Modificación Debemos Eliminar Asiento y su Detalle 
                if (Estado == 2)
                {
                    //Eliminacion Asiento y su Detalle
                    //ELiminacion Detalles
                    CapaLogica.DetalleAsientosEliminarTodo(_IdAsientoOrigen, (int)cboOriProyecto.SelectedValue, FechaContable);
                    CapaLogica.DetalleAsientosEliminarTodo(_IdAsientoDestino, (int)cboDesProyecto.SelectedValue, FechaContable);
                    //Eliminacion Cabecera 
                    CapaLogica.AsientoContableEliminar(_IdAsientoOrigen, (int)cboOriProyecto.SelectedValue, FechaContable);
                    CapaLogica.AsientoContableEliminar(_IdAsientoDestino, (int)cboDesProyecto.SelectedValue, FechaContable);
                    //Cambiamos los Datos de Cuo e idAsiento
                    IdAsientoOri = _IdAsientoOrigen;
                    IdAsientoDes = _IdAsientoDestino;
                    CuoOri = _CuoOrigen;
                    CuoDes = _CuoDestino;
                }
                ///Asiento Empresa Origen y Destino
                ///Asientos Cabeceras
                ///Empresa Origen
                CapaLogica.InsertarAsientoFacturaCabecera(1, 1, IdAsientoOri, FechaContable, cboOriCuentaContable.SelectedValue.ToString(), MontoPrestado, 0, ValorTC, IdProyectoOri, IdEtapaOri, CuoOri, IdMoneda, Glosa
                    , FechaPrestamo, -21);
                CapaLogica.InsertarAsientoFacturaCabecera(1, 2, IdAsientoOri, FechaContable, cboOriCuentaBanco.SelectedValue.ToString(), 0, MontoPrestado, ValorTC, IdProyectoOri, IdEtapaOri, CuoOri
                    , IdMoneda, Glosa, FechaPrestamo, -21);
                ///Empresa Destino
                CapaLogica.InsertarAsientoFacturaCabecera(1, 1, IdAsientoDes, FechaContable, cboDesCuentaBanco.SelectedValue.ToString(), MontoPrestado, 0, ValorTC, IdProyectoDes, IdEtapaDes, CuoDes
                    , IdMoneda, Glosa, FechaPrestamo, -21);
                CapaLogica.InsertarAsientoFacturaCabecera(1, 2, IdAsientoDes, FechaContable, cboDesCuentaContable.SelectedValue.ToString(), 0, MontoPrestado, ValorTC, IdProyectoDes, IdEtapaDes, CuoDes, IdMoneda, Glosa
                    , FechaPrestamo, -21);
                ///Fin de las Cabeceras
                ///Detalle de los Asientos
                string NroKuentaOri = HPResergerFunciones.Utilitarios.ExtraerCuenta(cboOriCuentaBanco.Text).Trim();
                string NroKuentaDes = HPResergerFunciones.Utilitarios.ExtraerCuenta(cboDesCuentaBanco.Text).Trim();
                // Siguiente idpk
                int SiguientePkId = (int)CapaLogica.SiguienteIdPrestamoInterEmpresa(IdEmpresaOri).Rows[0]["SiguientePkid"];
                string NumComprobante = "";
                if (Estado == 1)
                    NumComprobante = "Pr." + SiguientePkId + "-" + FechaPrestamo.ToShortDateString();
                if (Estado == 2)
                    NumComprobante = "Pr." + _FkId + "-" + FechaPrestamo.ToShortDateString();
                //Sacamos el Ruc de la Empresa Origen y DEstino
                string RucOrigen = ((DataRowView)cboOriEmpresa.SelectedItem)["ruc"].ToString();
                string RucDestrino = ((DataRowView)cboDesEmpresa.SelectedItem)["ruc"].ToString();
                ///Detalle en la Empresa Origen
                CapaLogica.InsertarAsientoFacturaDetalle(10, 1, IdAsientoOri, FechaContable, cboOriCuentaContable.SelectedValue.ToString(), IdProyectoOri, 5, RucDestrino
                   , cboDesEmpresa.Text, 1, "0", NumComprobante, 0, FechaPrestamo, FechaContable, FechaContable, IdMoneda == 1 ? MontoPrestado : MontoPrestado * ValorTC, IdMoneda == 2 ? MontoPrestado : MontoPrestado / ValorTC, ValorTC,
                   IdMoneda, " ", NumComprobante, Glosa, FechaContable, IdUsuario, " ");
                CapaLogica.InsertarAsientoFacturaDetalle(10, 2, IdAsientoOri, FechaContable, cboOriCuentaBanco.SelectedValue.ToString(), IdProyectoOri, 5, RucDestrino
                   , cboDesEmpresa.Text, 1, "0", NumComprobante, 0, FechaPrestamo, FechaContable, FechaContable, IdMoneda == 1 ? MontoPrestado : MontoPrestado * ValorTC, IdMoneda == 2 ? MontoPrestado : MontoPrestado / ValorTC, ValorTC,
                   IdMoneda, NroKuentaOri, NumComprobante, Glosa, FechaContable, IdUsuario, " ");
                ///Detalle en la Empresa Destino
                CapaLogica.InsertarAsientoFacturaDetalle(10, 1, IdAsientoDes, FechaContable, cboDesCuentaBanco.SelectedValue.ToString(), IdProyectoDes, 5, RucOrigen
                   , cboOriEmpresa.Text, 1, "0", NumComprobante, 0, FechaPrestamo, FechaContable, FechaContable, IdMoneda == 1 ? MontoPrestado : MontoPrestado * ValorTC, IdMoneda == 2 ? MontoPrestado : MontoPrestado / ValorTC, ValorTC,
                   IdMoneda, NroKuentaDes, NumComprobante, Glosa, FechaContable, IdUsuario, " ");
                CapaLogica.InsertarAsientoFacturaDetalle(10, 2, IdAsientoDes, FechaContable, cboDesCuentaContable.SelectedValue.ToString(), IdProyectoDes, 5, RucOrigen
                   , cboOriEmpresa.Text, 1, "0", NumComprobante, 0, FechaPrestamo, FechaContable, FechaContable, IdMoneda == 1 ? MontoPrestado : MontoPrestado * ValorTC, IdMoneda == 2 ? MontoPrestado : MontoPrestado / ValorTC, ValorTC,
                   IdMoneda, " ", NumComprobante, Glosa, FechaContable, IdUsuario, " ");
                ///Fin detalle de los asientos
                ///Proceso de Cuadre de Asientos
                CapaLogica.CuadrarAsiento(CuoOri, IdProyectoOri, FechaContable, 2);
                CapaLogica.CuadrarAsiento(CuoDes, IdProyectoDes, FechaContable, 2);
                ///Inserto el Registro del Prestamo InterEmpresa
                ///En Banco Enviamos el ID de la Cta para en el asientoo Buscar el Banco
                if (Estado == 1)
                    CapaLogica.PrestamosInterEmpresa(1, IdEmpresaOri, IdProyectoOri, IdEtapaOri, (int)((DataTable)cboOriCuentaBanco.DataSource).Rows[cboOriCuentaBanco.SelectedIndex]["idtipocta"]
                        , (int)((DataTable)cboOriCuentaBanco.DataSource).Rows[cboOriCuentaBanco.SelectedIndex]["idtipocta"], CuoOri, cboOriCuentaContable.SelectedValue.ToString(), IdEmpresaDes, IdProyectoDes
                        , IdEtapaDes, (int)((DataTable)cboDesCuentaBanco.DataSource).Rows[cboDesCuentaBanco.SelectedIndex]["idtipocta"], (int)((DataTable)cboDesCuentaBanco.DataSource).Rows[cboDesCuentaBanco.SelectedIndex]["idtipocta"]
                        , CuoDes, cboDesCuentaContable.SelectedValue.ToString(), IdMoneda, MontoPrestado, FechaContable, FechaPrestamo, ValorTC, Glosa, 1);
                else if (Estado == 2)
                {
                    CapaLogica.PrestamosInterEmpresa(2, IdEmpresaOri, IdProyectoOri, IdEtapaOri, (int)((DataTable)cboOriCuentaBanco.DataSource).Rows[cboOriCuentaBanco.SelectedIndex]["idtipocta"]
                                        , (int)((DataTable)cboOriCuentaBanco.DataSource).Rows[cboOriCuentaBanco.SelectedIndex]["idtipocta"], _CuoOrigen, cboOriCuentaContable.SelectedValue.ToString(),
                                        IdEmpresaDes, IdProyectoDes, IdEtapaDes, (int)((DataTable)cboDesCuentaBanco.DataSource).Rows[cboDesCuentaBanco.SelectedIndex]["idtipocta"],
                                        (int)((DataTable)cboDesCuentaBanco.DataSource).Rows[cboDesCuentaBanco.SelectedIndex]["idtipocta"]
                                        , _CuoDestino, cboDesCuentaContable.SelectedValue.ToString(), IdMoneda, MontoPrestado, FechaContable, FechaPrestamo, ValorTC, Glosa, _FkId);
                }
                ///Proceso Finalizado;
                msgOK($"Se Grabó Exitosamente\nEn la Empresa Origen  cuo: {CuoOri}\nEn la Empresa Destino cuo: {CuoDes}");
                ///****************///
                ModoEdicion(false);
                btnaceptar.Enabled = false;
                btnNuevo.Enabled = true;
                Estado = 0;
                CargaDatos();
            }
            else { msg("Cancelado por el Usuario"); }
        }
        private void txtOriCuentaContable_TextChanged(object sender, EventArgs e)
        {

        }
        private void txtDesCuentaContable_TextChanged(object sender, EventArgs e)
        {

        }
        private void btnOriBuscarCuenta_Click(object sender, EventArgs e)
        {
            BuscarCuentas(1);
        }
        private void btnDesBuscarCuenta_Click(object sender, EventArgs e)
        {
            BuscarCuentas(2);
        }
        public void BuscarCuentas(int i)
        {
            //frmlistarcuentas cuentitas = new frmlistarcuentas();
            //cuentitas.Txtbusca.Text = i == 1 ? txtOriCuentaContable.Text : txtDesCuentaContable.Text;
            //cuentitas.radioButton1.Checked = true;
            //cuentitas.ShowDialog();
            //if (cuentitas.aceptar)
            //{
            //    if (i == 1) txtOriCuentaContable.Text = cuentitas.codigo;
            //    else txtDesCuentaContable.Text = cuentitas.codigo;
            //}
        }

        private void dtgconten_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow item = dtgconten.Rows[e.RowIndex];
                cboOriEmpresa.SelectedValue = (int)item.Cells[xfkEmpresaOri.Name].Value;
                cboDesEmpresa.SelectedValue = (int)item.Cells[xfkEmpresaDes.Name].Value;
                //
                cboOriProyecto.SelectedValue = (int)item.Cells[xfkidProyectoOri.Name].Value;
                cboDesProyecto.SelectedValue = (int)item.Cells[xfkidProyectoDes.Name].Value;
                //
                cboOriEtapa.SelectedValue = (int)item.Cells[xfkidEtapaOri.Name].Value;
                cboDesEtapa.SelectedValue = (int)item.Cells[xfkidEtapaDes.Name].Value;
                //
                cbomoneda.SelectedValue = (int)item.Cells[xidMoneda.Name].Value;
                txtGlosa.Text = item.Cells[xglosa.Name].Value.ToString();
                txtMontoPrestamo.Text = ((decimal)item.Cells[ximporte.Name].Value).ToString("n2");
                //
                dtpFechaContable.Value = (DateTime)item.Cells[xFechaContable.Name].Value;
                dtpFechaPrestamo.Value = (DateTime)item.Cells[xfechaprestamo.Name].Value;
                cboOriCuentaContable.SelectedValue = item.Cells[xCtaContableOri.Name].Value.ToString();
                cboDesCuentaContable.SelectedValue = item.Cells[xCtaContableDes.Name].Value.ToString();
                txtTipoCambio.Text = ((decimal)item.Cells[xtc.Name].Value).ToString("n3");
                //
                cboOriBanco.SelectedValue = item.Cells[xsufijoori.Name].Value.ToString();
                cboDesBanco.SelectedValue = item.Cells[xsufijodes.Name].Value.ToString();
                //
                cboOriCuentaBanco.ValueMember = "Idtipocta";
                cboDesCuentaBanco.ValueMember = "idtipocta";
                cboOriCuentaBanco.SelectedValue = (int)item.Cells[xidCtaOri.Name].Value;
                cboDesCuentaBanco.SelectedValue = (int)item.Cells[xidCtaDes.Name].Value;
                cboOriCuentaBanco.ValueMember = "Id_Cuenta_Contable";
                cboDesCuentaBanco.ValueMember = "Id_Cuenta_Contable";
                //Valido para Mostrar el Boton Modificar
                VerificarParaModificar(e.RowIndex);
            }
        }
        public void VerificarParaModificar(int x)
        {
            //if (dtgconten.CurrentCell != null)
            if ((int)dtgconten[xEstado.Name, x].Value == 1 && Estado == 0)
            {
                btnModificar.Enabled = true;
            }
            else btnModificar.Enabled = false;
        }
        private void btnActualizar_Click(object sender, EventArgs e)
        {
            CargaDatos();
        }

        private void txtbusempresaorigen_TextChanged(object sender, EventArgs e)
        {
            CargaDatos();
        }

        private void txtbusempresadestino_TextChanged(object sender, EventArgs e)
        {
            CargaDatos();
        }

        private void txtbusMoneda_TextChanged(object sender, EventArgs e)
        {
            CargaDatos();
        }

        private void dtpfechabus1_ValueChanged(object sender, EventArgs e)
        {
            CargaDatos();
        }

        private void dtpfechabus2_ValueChanged(object sender, EventArgs e)
        {
            CargaDatos();
        }

        private void btncleanfind_Click(object sender, EventArgs e)
        {
            txtbusempresadestino.CargarTextoporDefecto();
            txtbusempresaorigen.CargarTextoporDefecto();
            txtbusMoneda.CargarTextoporDefecto();
            dtpfechabus1.Value = new DateTime(DateTime.Now.Year, 1, 1);
            dtpfechabus2.Value = new DateTime(DateTime.Now.Year, 12, 31);
            chkAnulado.Checked = false; chkCancelado.Checked = false;
        }

        private void btnCambiar_Move(object sender, EventArgs e)
        {
            //btnCambiar.Location = new Point(182, 258);
            //btnCambiar.Height = 22;
            //btnCambiar.Width = 22;
        }

        private void btnCambiar_MouseLeave(object sender, EventArgs e)
        {
            //btnCambiar.Location = new Point(185, 262);
            //btnCambiar.Height = 20;
            //btnCambiar.Width = 20;
        }

        private void btnCambiar_Click(object sender, EventArgs e)
        {
            string cadena = txtbusempresadestino.TextValido();
            txtbusempresadestino.Text = txtbusempresaorigen.TextValido() == "" ? txtbusempresadestino.TextoPorDefecto : txtbusempresaorigen.TextValido();
            txtbusempresaorigen.Text = cadena == "" ? txtbusempresaorigen.TextoPorDefecto : cadena;
        }

        private void cboOriCuentaContable_Click(object sender, EventArgs e)
        {
            DataTable Table = CapaLogica.BuscarcuentasInterEmpresas(FkMoneda);
            if (cboOriCuentaContable.Items.Count != Table.Rows.Count)
            {
                string cadena = (cboOriCuentaContable.SelectedValue ?? "").ToString();
                cboOriCuentaContable.DataSource = Table;
                cboOriCuentaContable.SelectedValue = cadena;
            }
        }

        private void cboDesCuentaContable_Click(object sender, EventArgs e)
        {
            DataTable Table = CapaLogica.BuscarcuentasInterEmpresas(FkMoneda);
            if (cboDesCuentaContable.Items.Count != Table.Rows.Count)
            {
                string cadena = (cboDesCuentaContable.SelectedValue ?? "").ToString();
                cboDesCuentaContable.DataSource = Table;
                cboDesCuentaContable.SelectedValue = cadena;
            }
        }
        frmProcesando frmproce;
        private void btnExportarPLan2Col_Click(object sender, EventArgs e)
        {
            if (dtgconten.Rows.Count > 0)
            {
                Cursor = Cursors.WaitCursor;
                frmproce = new HPReserger.frmProcesando();
                frmproce.Show();
                if (!backgroundWorker1.IsBusy)
                {
                    backgroundWorker1.RunWorkerAsync();
                }
            }
            else
            {
                msg("No hay Datos que Exportar");
            }
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            if (dtgconten.RowCount > 0)
            {
                string _NombreHoja = ""; string _Cabecera = ""; int[] _Columnas; string _NColumna = "";
                _NombreHoja = "Prestamos InterEmpresa"; _Cabecera = "Listado de Prestamos InterEmpresa";
                _Columnas = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19 }; _NColumna = "m";
                //
                List<HPResergerFunciones.Utilitarios.RangoCelda> Celdas = new List<HPResergerFunciones.Utilitarios.RangoCelda>();
                Color Back = Color.FromArgb(78, 129, 189);
                Color Fore = Color.FromArgb(255, 255, 255);
                Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda("d1", "d1", _Cabecera.ToUpper(), 16, true, false, Back, Fore));
                //
                HPResergerFunciones.Utilitarios.EstiloCelda CeldaDefault = new HPResergerFunciones.Utilitarios.EstiloCelda(dtgconten.AlternatingRowsDefaultCellStyle.BackColor, dtgconten.AlternatingRowsDefaultCellStyle.Font, dtgconten.AlternatingRowsDefaultCellStyle.ForeColor);
                HPResergerFunciones.Utilitarios.EstiloCelda CeldaCabecera = new HPResergerFunciones.Utilitarios.EstiloCelda(dtgconten.ColumnHeadersDefaultCellStyle.BackColor, dtgconten.ColumnHeadersDefaultCellStyle.Font, dtgconten.ColumnHeadersDefaultCellStyle.ForeColor);
                int PosInicialGrilla = 2;
                DataTable TablaExportar = new DataTable();
                TablaExportar = ((DataTable)dtgconten.DataSource).Copy();
                ///Remuevo Columnas inservibles
                TablaExportar.Columns.RemoveAt(30);
                TablaExportar.Columns.RemoveAt(23);
                TablaExportar.Columns.RemoveAt(19);
                TablaExportar.Columns.RemoveAt(18);
                TablaExportar.Columns.RemoveAt(16);
                TablaExportar.Columns.RemoveAt(15);
                TablaExportar.Columns.RemoveAt(14);
                TablaExportar.Columns.RemoveAt(12);
                TablaExportar.Columns.RemoveAt(8);
                TablaExportar.Columns.RemoveAt(7);
                TablaExportar.Columns.RemoveAt(5);
                TablaExportar.Columns.RemoveAt(4);
                TablaExportar.Columns.RemoveAt(3);
                TablaExportar.Columns.RemoveAt(1);
                //TablaExportar.Columns.RemoveAt(0);
                ///
                ///
                HPResergerFunciones.Utilitarios.ExportarAExcelOrdenandoColumnas(TablaExportar, CeldaCabecera, CeldaDefault, _NombreHoja, _NombreHoja, Celdas, PosInicialGrilla, _Columnas, new int[] { }, new int[] { 1, 2, 3, 5, 6, 7, 8, 10, 11, 12, 13, 14, 15, 16, 18 }, "");
            }
            else msg("No hay datos que Exportar");
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            Cursor = Cursors.Default;
            frmproce.Close();
            dtgconten.ResumeLayout();
        }
        int Estado = 0;
        private bool Busqueda;

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Estado = 1;
            btnNuevo.Enabled = false;
            btnModificar.Enabled = false;
            ModoEdicion(true);
            btnaceptar.Enabled = true;
        }

        private void chkbusEstados_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chkbusEstados_CheckStateChanged(object sender, EventArgs e)
        {
            CargaDatos();
        }

        private void chkbusEstados_CheckedChanged_1(object sender, EventArgs e)
        {

        }
        string _CuoOrigen;
        string _CuoDestino;
        int _IdAsientoOrigen;
        int _IdAsientoDestino;
        int _FkId;

        public int FkMoneda { get; private set; }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Estado = 2;
            btnNuevo.Enabled = false;
            btnModificar.Enabled = false;
            ModoEdicion(true);
            ///Desactivo Opciones que no tienes que ir!
            cboOriEmpresa.Enabled = cboOriProyecto.Enabled = cboOriEtapa.Enabled = cboDesEmpresa.Enabled = cboDesProyecto.Enabled = cboDesEtapa.Enabled = false;
            cbomoneda.Enabled = txtMontoPrestamo.Enabled = dtpFechaContable.Enabled = false;
            btnaceptar.Enabled = true;
            //Datos del Cuo Moficable
            int x = dtgconten.CurrentRow.Index;
            _CuoOrigen = dtgconten[xCuoOri.Name, x].Value.ToString();
            _CuoDestino = dtgconten[xCuoDes.Name, x].Value.ToString();
            _IdAsientoOrigen = int.Parse(_CuoOrigen.Substring(5));
            _IdAsientoDestino = int.Parse(_CuoDestino.Substring(5));
            _FkId = (int)dtgconten[xpkid.Name, x].Value;
        }
        private void fontDialog1_Apply(object sender, EventArgs e)
        {
        }
    }
}
