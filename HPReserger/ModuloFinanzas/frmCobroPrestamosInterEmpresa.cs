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

namespace HPReserger.ModuloFinanzas
{
    public partial class frmCobroPrestamosInterEmpresa : FormGradient
    {
        public frmCobroPrestamosInterEmpresa()
        {
            InitializeComponent();
        }
        HPResergerCapaLogica.HPResergerCL CapaLogica = new HPResergerCapaLogica.HPResergerCL();
        public void msg(string cadena) { HPResergerFunciones.frmInformativo.MostrarDialogError(cadena); }
        public void msgOK(string cadena) { HPResergerFunciones.frmInformativo.MostrarDialog(cadena); }

        public void CargarEmpresaOri() { CapaLogica.TablaEmpresa(cboOriEmpresa); }
        public void CargarEmpresaDes() { CapaLogica.TablaEmpresa(cboDesEmpresa); }
        public void CargarMoneda() { CapaLogica.TablaMoneda(cbomoneda); }

        private void frmCobroPrestamosInterEmpresa_Load(object sender, EventArgs e)
        {
            dtpFechaContable.Value = dtpFechaPago.Value = DateTime.Now;
            ///Cargar Textos por Defecto, 
            txtGlosa.CargarTextoporDefecto(); txtnrooperacion.CargarTextoporDefecto();
            CargarMoneda();
            ///CargarBancos
            cboDesBanco_Click(sender, e);
            cboBanco_Click(sender, e);
            ///Carga de Empresas
            CargarEmpresaOri();
            CargarEmpresaDes();
            ///Luego de haber cargado todos los datos de la grilla
            Cargado = true;
            CargarDatos();
        }
        private void cboEmpresa_Click(object sender, EventArgs e)
        {
            DataTable Tablita = CapaLogica.getCargoTipoContratacion("Id_Empresa", "Empresa", "TBL_Empresa");
            if (cboOriEmpresa.Items.Count != Tablita.Rows.Count)
            {
                string cadena = cboOriEmpresa.Text;
                cboOriEmpresa.DataSource = Tablita;
                cboOriEmpresa.Text = cadena;
            }
        }
        public void CargarProyecto()
        {
            if (cboOriEmpresa.SelectedValue != null)
            {
                cboOriProyecto.DisplayMember = "proyecto";
                cboOriProyecto.ValueMember = "id_proyecto";
                cboOriProyecto.DataSource = CapaLogica.ListarProyectosEmpresa(cboOriEmpresa.SelectedValue.ToString());
            }
        }
        int IdEmpresaOri;
        string NameEmpresaOri = "";
        private void cboEmpresa_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (IdEmpresaOri != (int)cboOriEmpresa.SelectedValue)
            {
                IdEmpresaOri = (int)cboOriEmpresa.SelectedValue;
                CargarProyecto();
                EmpresaFind = 0;
                MonedaFind = 0;
                CargarDatos();
            }
            //    ListaFacturas.Clear();
            //ContarRegistros();
            //BusquedaDatos();
            if (cboOriBanco.SelectedValue != null)
            {
                CargarCuentasBancosOri();
                NameEmpresaOri = cboOriEmpresa.Text;
            }
        }
        public void CargarCuentasBancos()
        {
            string cadena = cboOriCuentaBanco.Text;
            if (cboOriEmpresa.SelectedValue != null && cboOriBanco.SelectedValue != null)
            {
                cboOriCuentaBanco.ValueMember = "Id_Cuenta_Contable";
                cboOriCuentaBanco.DisplayMember = "banco";
                cboOriCuentaBanco.DataSource = CapaLogica.ListarBancosTiposdePagoxEmpresa(cboOriBanco.SelectedValue.ToString(), (int)cboOriEmpresa.SelectedValue, 0);
                cboOriCuentaBanco.Text = cadena;
            }
        }
        public void CargarCuentasBancosDestino()
        {
            string cadena = cboDesCuentaBanco.Text;
            if (cboDesEmpresa.SelectedValue != null && cboDesBanco.SelectedValue != null)
            {
                cboDesCuentaBanco.ValueMember = "Id_Cuenta_Contable";
                cboDesCuentaBanco.DisplayMember = "banco";
                cboDesCuentaBanco.DataSource = CapaLogica.ListarBancosTiposdePagoxEmpresa(cboDesBanco.SelectedValue.ToString(), (int)cboDesEmpresa.SelectedValue, 0);
                cboDesCuentaBanco.Text = cadena;
            }
        }
        int EmpresaFind = 0;
        int MonedaFind = 0;
        public Boolean Cargado = false;
        private void CargarDatos()
        {
            if (Cargado)
            {
                DataTable TablePrueba = CapaLogica.ListarCobrarInterEmpresas(IdEmpresaOri, EmpresaFind, MonedaFind, DateTime.Now, DateTime.Now, "", "");
                dtgconten.DataSource = TablePrueba;
                lblmsg.Text = $"Total de Registros : {dtgconten.RowCount}";
            }
        }
        TextBox txt;
        private void dtgconten_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            int x = dtgconten.CurrentCell.RowIndex, y = dtgconten.CurrentCell.ColumnIndex;
            txt = e.Control as TextBox;
            txt.KeyDown -= Txt_KeyDown;
            txt.KeyPress -= Txt_KeyPress;
            if (y == dtgconten.Columns[xPagar.Name].Index)
            {
                //si edito el pago
                txt.KeyDown += Txt_KeyDown;
                txt.KeyPress += Txt_KeyPress;
            }
            //if (y == dtgconten.Columns[xpagar.Name].Index)
            //{
            //    if (ContenedorIdNotas.Contains((int)dtgconten[xIdComprobante.Name, x].Value))
            //    {
            //        dtgconten[y, x].ReadOnly = true;
            //        dtgconten.CancelEdit();
            //    }
            //    else
            //        dtgconten[y, x].ReadOnly = false;
            //}
        }
        private void Txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            HPResergerFunciones.Utilitarios.SoloNumerosDecimalesX(e, txt.Text);
        }
        private void Txt_KeyDown(object sender, KeyEventArgs e)
        {
            HPResergerFunciones.Utilitarios.ValidarDinero(e, txt);
        }

        private void dtgconten_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            int x = e.RowIndex;
            int y = e.ColumnIndex;
            if (x >= 0)
            {
                DataGridViewRow item = dtgconten.Rows[x];
                int valor = (int)item.Cells[xpkid.Name].Value;
                decimal monto = 0;
                decimal.TryParse(item.Cells[xPagar.Name].Value.ToString(), out monto);
                item.Cells[xPagar.Name].Value = monto;
                ////si es valor es mayor o menor a cero
                if (dtgconten.Columns[xPagar.Name].Index == y)
                    if ((decimal)item.Cells[xPagar.Name].Value <= 0 || (decimal)item.Cells[xPagar.Name].Value > (decimal)item.Cells[xSaldo.Name].Value)
                        item.Cells[xPagar.Name].Value = (decimal)item.Cells[xSaldo.Name].Value;
                ////////
                if (y == dtgconten.Columns[xok.Name].Index || y == dtgconten.Columns[xPagar.Name].Index)
                {
                    CalcularTotal();
                }
            }
        }
        public void CalcularTotal()
        {
            decimal Sumatoria = 0;
            foreach (DataGridViewRow item in dtgconten.Rows)
            {
                if ((int)item.Cells[xok.Name].Value == 1)
                {
                    Sumatoria += (decimal)item.Cells[xPagar.Name].Value;
                }
            }
            txtTotal.Text = Sumatoria.ToString("n2");
        }
        private void cboBanco_Click(object sender, EventArgs e)
        {
            string cadenar = cboOriBanco.Text;
            cboOriBanco.ValueMember = "codigo";
            cboOriBanco.DisplayMember = "descripcion";
            cboOriBanco.DataSource = CapaLogica.getCargoTipoContratacion("Sufijo", "Entidad_Financiera", "TBL_Entidad_Financiera");
            cboOriBanco.Text = cadenar;
        }
        private void cboDesBanco_Click(object sender, EventArgs e)
        {
            string cadenar = cboDesBanco.Text;
            cboDesBanco.ValueMember = "codigo";
            cboDesBanco.DisplayMember = "descripcion";
            cboDesBanco.DataSource = CapaLogica.getCargoTipoContratacion("Sufijo", "Entidad_Financiera", "TBL_Entidad_Financiera");
            cboDesBanco.Text = cadenar;
        }
        private void cboBanco_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboOriBanco.SelectedIndex >= 0)
            {
                cboOriCuentaBanco.Text = "";
                CargarCuentasBancosOri();// (cboOriEmpresa, cboOriBanco, cboOriCuentaBanco);
            }
        }
        private void cboDesBanco_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboDesBanco.SelectedIndex >= 0)
            {
                cboOriCuentaBanco.Text = "";
                CargarCuentasBancosDes();
            }
        }
        frmTipodeCambio frmtipo;
        private string NameEmpresaDes = "";
        public int IdEmpresaDes { get; private set; }

        public void SacarTipoCambio()
        {
            DateTime FechaValidaBuscar = dtpFechaPago.Value;
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
        private void dtpFechaPago_ValueChanged(object sender, EventArgs e)
        {
            SacarTipoCambio();
        }
        private void btncancelar_Click(object sender, EventArgs e)
        {
            if (EmpresaFind != 0)
            {
                EmpresaFind = 0;
                MonedaFind = 0;
                CargarDatos();
            }
            else
                this.Close();
        }
        private void cboproyecto_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboOriProyecto.SelectedValue != null)
            {
                cboOriEtapa.ValueMember = "id_etapa";
                cboOriEtapa.DisplayMember = "descripcion";
                cboOriEtapa.DataSource = CapaLogica.ListarEtapasProyecto(cboOriProyecto.SelectedValue.ToString());
            }
        }
        private void cboDesEmpresa_Click(object sender, EventArgs e)
        {
            DataTable Tablita = CapaLogica.getCargoTipoContratacion("Id_Empresa", "Empresa", "TBL_Empresa");
            if (cboDesEmpresa.Items.Count != Tablita.Rows.Count)
            {
                string cadena = cboDesEmpresa.Text;
                cboDesEmpresa.DataSource = Tablita;
                cboDesEmpresa.Text = cadena;
            }
        }

        private void cboDesEmpresa_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboDesEmpresa.Items.Count > 0)
            {
                if (cboDesEmpresa.SelectedValue != null)
                {
                    IdEmpresaDes = (int)cboDesEmpresa.SelectedValue;
                    cboDesProyecto.DisplayMember = "proyecto";
                    cboDesProyecto.ValueMember = "id_proyecto";
                    cboDesProyecto.DataSource = CapaLogica.ListarProyectosEmpresa(cboDesEmpresa.SelectedValue.ToString());
                    //busqueda de Asientos
                    if (Cargado)
                    {
                        EmpresaFind = IdEmpresaDes = (int)cboDesEmpresa.SelectedValue;
                        MonedaFind = (int)cbomoneda.SelectedValue;
                        CargarDatos();
                    }
                }
                if (cboDesBanco.SelectedValue != null)
                {
                    CargarCuentasBancosDes();
                    NameEmpresaDes = cboDesEmpresa.Text;
                }
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

        private void dtgconten_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dtgconten.Columns[xok.Name].Index == e.ColumnIndex)
            {
                dtgconten.EndEdit();
                dtgconten.RefreshEdit();
            }
        }

        private void dtgconten_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            int x = e.RowIndex, y = e.ColumnIndex;
            if (x >= 0)
            {
                //EmpresaFind = (int)dtgconten[xfkEmpresaDes.Name, x].Value;
                //cboDesEmpresa.SelectedValue = EmpresaFind;
                //CargarDatos();
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            EmpresaFind = 0;
            MonedaFind = 0;
            CargarDatos();
        }
        private void dtgconten_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int x = e.RowIndex, y = e.ColumnIndex;
            if (x >= 0)
            {
                if (EmpresaFind == 0)
                {
                    ///Para No hacer la cargada de datos
                    if (y == dtgconten.Columns[xok.Name].Index)
                    {
                        Cargado = false;
                        MonedaFind = (int)dtgconten[xidmoneda.Name, x].Value;
                        cbomoneda.SelectedValue = MonedaFind;
                        EmpresaFind = (int)dtgconten[xfkEmpresaDes.Name, x].Value;
                        cboDesEmpresa.SelectedValue = EmpresaFind;
                        //para hacer la carga de datos con los datos nuevos
                        Cargado = true;
                        CargarDatos();
                    }
                }
                if (y == dtgconten.Columns[xAbono.Name].Index)
                {
                    if (dtgconten[y, x].Value.ToString() != "" && cboOriEmpresa.SelectedValue != null)
                    {
                        int _empresa, _fkid;
                        _empresa = (int)cboOriEmpresa.SelectedValue;
                        _fkid = (int)dtgconten[xpkid.Name, x].Value;
                        ModuloFinanzas.frmListadoPrestamosInterEmpresa frmlistadoPrestamos = new frmListadoPrestamosInterEmpresa(_empresa, _fkid);
                        frmlistadoPrestamos.Glosa = dtgconten[xGlosa.Name, x].Value.ToString();
                        frmlistadoPrestamos.EmpresaOrigen = cboOriEmpresa.Text;
                        frmlistadoPrestamos.EmpresaDestino = dtgconten[xEmpresaDes.Name, x].Value.ToString();
                        //--+--
                        frmlistadoPrestamos.MdiParent = this.MdiParent;
                        frmlistadoPrestamos.Show();
                    }
                }

            }
        }
        private void cbomoneda_SelectedIndexChanged(object sender, EventArgs e)
        {
            CargarCuentasBancosOri(); CargarCuentasBancosDes();
            if (Cargado)
            {
                MonedaFind = (int)cbomoneda.SelectedValue;
                CargarDatos();
            }
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
        public DialogResult msgp(string cadena) { return HPResergerFunciones.frmPregunta.MostrarDialogYesCancel(cadena); }
        private void btnaceptar_Click(object sender, EventArgs e)
        {
            CalcularTotal();
            //Proceso de Validacion de DAtos
            ///Validamos que solo Este Seleccionado un Prestamos
            //int C = 0;
            //foreach (DataGridViewRow item in dtgconten.Rows)
            //    if ((int)item.Cells[xok.Name].Value == 1)
            //        C++;
            //if (C > 1) { msg("Seleccione solo un Prestamo"); return; }
            ///Declaraciones
            decimal ValorTC = 0, MontoAbonado = 0;
            string Glosa = "";
            DateTime FechaContable = dtpFechaContable.Value;
            DateTime FechaAbono = dtpFechaPago.Value;
            int IdMoneda = (int)cbomoneda.SelectedValue;
            int IdUsuario = frmLogin.CodigoUsuario;
            Boolean Prueba = true;
            string mensaje = "El Periodo esta Cerrado en:";
            ///Conversiones
            decimal.TryParse(txtTipoCambio.Text, out ValorTC);
            decimal.TryParse(txtTotal.Text, out MontoAbonado);
            Glosa = txtGlosa.TextValido();
            ///VALIDACIONES
            ///Validacion de PEriodo Contable Cerrado
            if (cboOriEmpresa.SelectedValue == null) { cboOriEmpresa.Focus(); msg("Seleccione Empresa Destino"); return; }
            if (cboDesEmpresa.SelectedValue == null) { cboDesEmpresa.Focus(); msg("Seleccione Empresa Origen"); return; }
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
            if (MontoAbonado == 0) { msg("El Monto Abonado debe ser Mayor A Cero"); return; }
            //Validacion de Valores Cero de suma del Total
            Boolean Prueba1 = false;
            foreach (DataGridViewRow item in dtgconten.Rows)
            {
                if ((int)item.Cells[xok.Name].Value == 1)
                {
                    if ((decimal)item.Cells[xPagar.Name].Value == 0)
                    {
                        HPResergerFunciones.Utilitarios.ColorCeldaError(item.Cells[xPagar.Name]);
                        Prueba1 = true;
                    }
                    else HPResergerFunciones.Utilitarios.ColorCeldaDefecto(item.Cells[xPagar.Name]);
                }
            }
            if (Prueba1) { msg("El Monto Abonado no puede ser Cero, Revise Celdas"); return; }
            //Validaciones de Combos Agrupados
            if (cboOriProyecto.SelectedValue == null) { cboOriProyecto.Focus(); msg("Seleccione Proyecto Destino"); return; }
            if (cboDesProyecto.SelectedValue == null) { cboDesProyecto.Focus(); msg("Seleccione Proyecto Origen"); return; }
            if (cboDesEtapa.SelectedValue == null) { cboDesEtapa.Focus(); msg("Seleccione Etapa Destino"); return; }
            if (cboDesEtapa.SelectedValue == null) { cboDesEtapa.Focus(); msg("Seleccione Etapa Origen"); return; }
            if (cboOriBanco.SelectedValue == null) { cboOriBanco.Focus(); msg("Seleccione Banco Destino"); return; }
            if (cboDesBanco.SelectedValue == null) { cboDesBanco.Focus(); msg("Seleccione Banco Origen"); return; }
            if (cboOriCuentaBanco.SelectedValue == null) { cboOriCuentaBanco.Focus(); msg("Seleccione Cuenta Banco Destino"); return; }
            if (cboDesCuentaBanco.SelectedValue == null) { cboDesCuentaBanco.Focus(); msg("Seleccione Cuenta Banco Origen"); return; }
            //if (cboDesCuentaContable.SelectedValue == null) { cboDesCuentaContable.Focus(); msg("Seleccione Cuenta Contable Destino"); return; }
            //if (cboOriCuentaContable.SelectedValue == null) { cboOriCuentaContable.Focus(); msg("Ingrese Cuenta Contable del Origen"); return; }
            ///Validaciones de Combos Separados
            if (cbomoneda.SelectedValue == null) { cbomoneda.Focus(); msg("Seleccione Moneda"); return; }
            if (cbotipo.Text == "") { cbotipo.Focus(); msg("Seleccione Tipo de Abono"); return; }
            //Programacion de la Logica          
            int IdAsientoOri = CapaLogica.SiguienteAsiento(IdEmpresaOri, FechaContable);
            int IdAsientoDes = CapaLogica.SiguienteAsiento(IdEmpresaDes, FechaContable);
            string CuoOri = HPResergerFunciones.Utilitarios.Cuo(IdAsientoOri, FechaContable);
            string CuoDes = HPResergerFunciones.Utilitarios.Cuo(IdAsientoDes, FechaContable);
            int IdProyectoOri = (int)(cboOriProyecto.SelectedValue);
            int IdProyectoDes = (int)(cboDesProyecto.SelectedValue);
            int IdEtapaOri = (int)(cboOriEtapa.SelectedValue);
            int IdEtapaDes = (int)(cboDesEtapa.SelectedValue);
            if (msgp("Seguro Desea Proceder con el Abono") == DialogResult.Yes)
            {
                //Proceso de Abono
                ///Asiento Empresa Origen y Destino
                ///Cabeceras
                #region Cabeceras
                ///Empresa Origen
                CapaLogica.InsertarAsientoFacturaCabecera(1, 1, IdAsientoOri, FechaContable, cboOriCuentaBanco.SelectedValue.ToString(), MontoAbonado, 0, ValorTC, IdProyectoOri, IdEtapaOri, CuoOri
                    , IdMoneda, Glosa, FechaAbono, -22);
                ///Empresa Destino
                CapaLogica.InsertarAsientoFacturaCabecera(1, 1, IdAsientoDes, FechaContable, cboDesCuentaBanco.SelectedValue.ToString(), 0, MontoAbonado, ValorTC, IdProyectoDes, IdEtapaDes, CuoDes
                    , IdMoneda, Glosa, FechaAbono, -22);
                ///Recorremos la grillas para la cabecera
                //Agregamos el detalle del banco, porque va agrupado sin documento
                string NroKuentaOri = HPResergerFunciones.Utilitarios.ExtraerCuenta(cboOriCuentaBanco.Text);
                string NroKuentaDes = HPResergerFunciones.Utilitarios.ExtraerCuenta(cboDesCuentaBanco.Text);
                string NroOpPago = txtnrooperacion.TextValido();
                //Sacamos el Ruc de la Empresa Origen y DEstino
                string RucOrigen = ((DataRowView)cboOriEmpresa.SelectedItem)["ruc"].ToString();
                string RucDestrino = ((DataRowView)cboDesEmpresa.SelectedItem)["ruc"].ToString();
                ///Detalle en la Empresa Origen - BANCOS                
                CapaLogica.InsertarAsientoFacturaDetalle(10, 1, IdAsientoOri, FechaContable, cboOriCuentaBanco.SelectedValue.ToString(), IdProyectoOri, 5, RucDestrino
                   , cboDesEmpresa.Text, 1, "0", "PRESTAMO", 0, FechaAbono, FechaContable, FechaContable, IdMoneda == 1 ? MontoAbonado : MontoAbonado * ValorTC,
                   IdMoneda == 2 ? MontoAbonado : MontoAbonado / ValorTC, ValorTC, IdMoneda, NroKuentaOri, NroOpPago, Glosa, FechaContable, IdUsuario, " ");
                ///Detalle en la Empresa Destino - BANCOS
                CapaLogica.InsertarAsientoFacturaDetalle(10, 1, IdAsientoDes, FechaContable, cboDesCuentaBanco.SelectedValue.ToString(), IdProyectoDes, 5, RucOrigen
                   , cboOriEmpresa.Text, 1, "0", "PRESTAMO", 0, FechaAbono, FechaContable, FechaContable, IdMoneda == 1 ? MontoAbonado : MontoAbonado * ValorTC,
                   IdMoneda == 2 ? MontoAbonado : MontoAbonado / ValorTC, ValorTC, IdMoneda, NroKuentaDes, NroOpPago, Glosa, FechaContable, IdUsuario, " ");
                int contador = 0;
                foreach (DataGridViewRow item in dtgconten.Rows)
                {
                    if ((int)item.Cells[xok.Name].Value == 1)
                    {
                        string CuentaOrigen = item.Cells[xCtaContableOri.Name].Value.ToString();
                        string CuentaDestino = item.Cells[xCtaContableDes.Name].Value.ToString();
                        decimal MontoAbono = (decimal)item.Cells[xPagar.Name].Value;
                        ///Empresa Origen - Entrada de Dinero
                        CapaLogica.InsertarAsientoFacturaCabecera(1, 2 + contador, IdAsientoOri, FechaContable, CuentaOrigen, 0, MontoAbono, ValorTC, IdProyectoOri, IdEtapaOri, CuoOri, IdMoneda, Glosa
                            , FechaAbono, -22);
                        ///Empresa Destino - Salida de Dinero
                        CapaLogica.InsertarAsientoFacturaCabecera(1, 2 + contador, IdAsientoDes, FechaContable, CuentaDestino, MontoAbono, 0, ValorTC, IdProyectoDes, IdEtapaDes, CuoDes, IdMoneda, Glosa
                            , FechaAbono, -22);
                        contador++;
                    }
                }
                //Fin de las Cabeceras
                #endregion Cabeceras
                ///Detalle de los Asientos
                #region DetalleAsientos
                //string NroKuentaOri = HPResergerFunciones.Utilitarios.ExtraerCuenta(cboOriCuentaBanco.Text);
                //string NroKuentaDes = HPResergerFunciones.Utilitarios.ExtraerCuenta(cboDesCuentaBanco.Text);
                //string NroOpPago = txtnrooperacion.TextValido();
                // Siguiente idpk
                //int SiguientePkId = (int)CapaLogica.SiguienteIdPrestamoInterEmpresa(IdEmpresaOri).Rows[0]["SiguientePkid"];
                string NumComprobante = "";// "Pr." + SiguientePkId + "-" + FechaPrestamo.ToShortDateString();
                int idTipoDocProveedor = 0;
                int TipoPago = int.Parse(cbotipo.Text.Substring(0, 3));
                contador = 0;
                foreach (DataGridViewRow item in dtgconten.Rows)
                {
                    if ((int)item.Cells[xok.Name].Value == 1)
                    {
                        decimal TcReg = (decimal)item.Cells[xtc.Name].Value;
                        string CuentaOrigen = item.Cells[xCtaContableOri.Name].Value.ToString();
                        string CuentaDestino = item.Cells[xCtaContableDes.Name].Value.ToString();
                        string CuoOrigenValue = item.Cells[xcuoori.Name].Value.ToString();
                        decimal MontoAbono = (decimal)item.Cells[xPagar.Name].Value;
                        DateTime FechaPrestamo = (DateTime)item.Cells[xFechaPrestado.Name].Value;
                        int pkid = (int)item.Cells[xpkid.Name].Value;
                        //
                        NumComprobante = "PRESTAMO"; idTipoDocProveedor = 6;
                        //
                        if (int.Parse(CuoOrigenValue.Substring(5)) != 0)
                        {
                            NumComprobante = "Pr." + pkid + "-" + ((DateTime)item.Cells[xFechaPrestado.Name].Value).ToShortDateString();
                            idTipoDocProveedor = 5;
                        }
                        /////Detalle en la Empresa Origen - BANCOS
                        //CapaLogica.InsertarAsientoFacturaDetalle(10, 1, IdAsientoOri, FechaContable, cboOriCuentaBanco.SelectedValue.ToString(), IdProyectoOri, idTipoDocProveedor, RucDestrino
                        //   , cboDesEmpresa.Text, 1, "0", NumComprobante, 0, FechaAbono, FechaContable, FechaContable, IdMoneda == 1 ? MontoAbonado : MontoAbonado * ValorTC,
                        //   IdMoneda == 2 ? MontoAbonado : MontoAbonado / ValorTC, ValorTC, IdMoneda, NroKuentaOri, NroOpPago, Glosa, FechaContable, IdUsuario, " ");
                        /////Detalle en la Empresa Destino - BANCOS
                        //CapaLogica.InsertarAsientoFacturaDetalle(10, 1, IdAsientoDes, FechaContable, cboDesCuentaBanco.SelectedValue.ToString(), IdProyectoDes, idTipoDocProveedor, RucOrigen
                        //   , cboOriEmpresa.Text, 1, "0", NumComprobante, 0, FechaAbono, FechaContable, FechaContable, IdMoneda == 1 ? MontoAbonado : MontoAbonado * ValorTC,
                        //   IdMoneda == 2 ? MontoAbonado : MontoAbonado / ValorTC, ValorTC, IdMoneda, NroKuentaDes, NroOpPago, Glosa, FechaContable, IdUsuario, " ");
                        ///Detalle en la Empresa Origen - Entrada de Dinero - CUENTAS
                        CapaLogica.InsertarAsientoFacturaDetalle(10, 2 + contador, IdAsientoOri, FechaContable, CuentaOrigen, IdProyectoOri, idTipoDocProveedor, RucDestrino
                           , cboDesEmpresa.Text, 1, "0", NumComprobante, 0, FechaPrestamo, FechaContable, FechaContable, IdMoneda == 1 ? MontoAbono : MontoAbono * TcReg, IdMoneda == 2 ? MontoAbono : MontoAbono / TcReg, TcReg,
                           IdMoneda, " ", "", Glosa, FechaContable, IdUsuario, item.Cells[xcuoori.Name].Value.ToString());
                        ///Detalle en la Empresa Destino - Salida de Dinero - CUENTAS
                        CapaLogica.InsertarAsientoFacturaDetalle(10, 2 + contador, IdAsientoDes, FechaContable, CuentaDestino, IdProyectoDes, idTipoDocProveedor, RucOrigen
                           , cboOriEmpresa.Text, 1, "0", NumComprobante, 0, FechaPrestamo, FechaContable, FechaContable, IdMoneda == 1 ? MontoAbono : MontoAbono * TcReg, IdMoneda == 2 ? MontoAbono : MontoAbono / TcReg, TcReg,
                           IdMoneda, " ", "", Glosa, FechaContable, IdUsuario, item.Cells[xcuodes.Name].Value.ToString());
                        contador++;
                        ///Inserto el Registro del Abono InterEmpresa
                        CapaLogica.PrestamosInterEmpresaDetalle(1, pkid, IdEmpresaOri, IdProyectoOri, IdEtapaOri, (int)((DataTable)cboOriCuentaBanco.DataSource).Rows[cboOriCuentaBanco.SelectedIndex]["idtipocta"]
                            , (int)((DataTable)cboOriCuentaBanco.DataSource).Rows[cboOriCuentaBanco.SelectedIndex]["idtipocta"],// cboOriCuentaContable.SelectedValue.ToString(),
                            IdEmpresaDes, IdProyectoDes, IdEtapaDes, (int)((DataTable)cboDesCuentaBanco.DataSource).Rows[cboDesCuentaBanco.SelectedIndex]["idtipocta"],
                            (int)((DataTable)cboDesCuentaBanco.DataSource).Rows[cboDesCuentaBanco.SelectedIndex]["idtipocta"], CuoOri, CuoDes, //cboDesCuentaContable.SelectedValue.ToString(),
                             FechaContable, FechaAbono, IdMoneda, MontoAbono, ValorTC, TipoPago, txtnrooperacion.TextValido(), DateTime.Now, IdUsuario, 1, Glosa);
                    }
                }
                ///Fin detalle de los asientos
                #endregion DetalleAsientos
                ///Proceso de Cuadre de Asientos
                CapaLogica.CuadrarAsiento(CuoOri, IdProyectoOri, FechaContable, 2);
                CapaLogica.CuadrarAsiento(CuoDes, IdProyectoDes, FechaContable, 2);
                ///Inserto el Registro del Prestamo InterEmpresa
                //Carga de Datos Actualizados
                msgOK($"Se Grabó Exitosamente\nEn la Empresa Destino cuo: {CuoOri}\nEn la Empresa Origen  cuo: {CuoDes}");
                //EmpresaFind = 0; MonedaFind = 0;
                CargarDatos();
            }
            else
            {
                msg("Cancelado por el Usuario");
            }
        }

        private void btnAbonados_Click(object sender, EventArgs e)
        {
            ModuloFinanzas.frmPrestamosInterEmpresaListadoAbonados frmlistadoAbonadosPRestamos = new frmPrestamosInterEmpresaListadoAbonados();
            frmlistadoAbonadosPRestamos.MdiParent = this.MdiParent;
            frmlistadoAbonadosPRestamos.Show();
        }

        private void btnCancelados_Click(object sender, EventArgs e)
        {
            ModuloFinanzas.frmListadoPrestamosCancelados frmListadodePrestamosCancelados = new frmListadoPrestamosCancelados();
            frmListadodePrestamosCancelados.MdiParent = this.MdiParent;
            frmListadodePrestamosCancelados.Show();
        }
    }
}
