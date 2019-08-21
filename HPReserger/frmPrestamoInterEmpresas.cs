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
        public void CargarEmpresaOri() { CapaLogica.TablaEmpresa(cboOriEmpresa); }
        public void CargarEmpresaDes() { CapaLogica.TablaEmpresa(cboDesEmpresa); }
        public void CargarMoneda() { CapaLogica.TablaMoneda(cbomoneda); }
        private void frmPrestamoInterEmpresas_Load(object sender, EventArgs e)
        {
            //Carga Datos Principales
            txtGlosa.CargarTextoporDefecto(); txtMontoPrestamo.CargarTextoporDefecto(); txtTipoCambio.CargarTextoporDefecto();
            txtOriCuentaContable.Text = txtDesCuentaContable.Text = "101";
            txtOriCuentaContable.CargarTextoporDefecto(); txtDesCuentaContable.CargarTextoporDefecto();
            //
            txtbusMoneda.CargarTextoporDefecto(); txtbusempresaorigen.CargarTextoporDefecto(); txtbusempresadestino.CargarTextoporDefecto();
            dtpFechaContable.Value = dtpFechaPrestamo.Value = DateTime.Now;
            CargarMoneda();
            //Empresas
            CargarEmpresaOri();
            CargarEmpresaDes();
            //Bancos
            cboOriBanco_Click(sender, e);
            cboDesBanco_Click(sender, e);
            //Periodo Anual para la Busqueda
            dtpfechabus1.Value = new DateTime(DateTime.Now.Year, 1, 1);
            dtpfechabus2.Value = new DateTime(DateTime.Now.Year, 12, 31);
        }
        public void CargaDatos()
        {
            DateTime fechaaux = dtpfechabus1.Value;
            DateTime fecha1 = dtpfechabus1.Value;
            DateTime fecha2 = dtpfechabus2.Value;
            if (fecha1 > fecha2)
            {
                fecha1 = fecha2;
                fecha2 = fechaaux;
            }
            dtgconten.DataSource = CapaLogica.PrestamosInterEmpresa(0, txtbusempresaorigen.TextValido(), txtbusempresadestino.TextValido(), txtbusMoneda.TextValido(), fecha1, fecha2);
            lblmensaje.Text = $"Total de Registros {dtgconten.RowCount}";
        }
        private void btncancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void msg(string v)
        {
            HPResergerFunciones.Utilitarios.msg(v);
        }
        private DialogResult msgYesNo(string v)
        {
            return HPResergerFunciones.Utilitarios.msgYesNo(v);
        }
        private void txtTipoCambio_Leave(object sender, EventArgs e)
        {
            decimal valor = 0;
            if (decimal.TryParse(txtTipoCambio.Text, out valor) || valor == 0) { txtTipoCambio.Text = txtTipoCambio.TextoDefecto; }
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
            CargarCuentasBancosOri(); CargarCuentasBancosDes();
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
            if (!txtOriNombreCuenta.EstaLLeno()) { txtOriCuentaContable.Focus(); msg("Ingrese Cuenta Contable del Origen"); return; }
            if (!txtDesNombreCuenta.EstaLLeno()) { txtDesCuentaContable.Focus(); msg("Ingrese Cuenta Contable del Destino"); return; }
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
            if (msgYesNo("Seguro Desea Proceder con el Préstamo") == DialogResult.Yes)
            {
                ///Asiento Empresa Origen y Destino
                ///Asientos Cabeceras
                ///Empresa Origen
                CapaLogica.InsertarAsientoFacturaCabecera(1, 1, IdAsientoOri, FechaContable, txtOriCuentaContable.Text, MontoPrestado, 0, ValorTC, IdProyectoOri, IdEtapaOri, CuoOri, IdMoneda, Glosa
                    , FechaPrestamo, -21);
                CapaLogica.InsertarAsientoFacturaCabecera(1, 2, IdAsientoOri, FechaContable, cboOriCuentaBanco.SelectedValue.ToString(), 0, MontoPrestado, ValorTC, IdProyectoOri, IdEtapaOri, CuoOri
                    , IdMoneda, Glosa, FechaPrestamo, -21);
                ///Empresa Destino
                CapaLogica.InsertarAsientoFacturaCabecera(1, 1, IdAsientoDes, FechaContable, cboDesCuentaBanco.SelectedValue.ToString(), MontoPrestado, 0, ValorTC, IdProyectoDes, IdEtapaDes, CuoDes
                    , IdMoneda, Glosa, FechaPrestamo, -21);
                CapaLogica.InsertarAsientoFacturaCabecera(1, 2, IdAsientoDes, FechaContable, txtDesCuentaContable.Text, 0, MontoPrestado, ValorTC, IdProyectoDes, IdEtapaDes, CuoDes, IdMoneda, Glosa
                    , FechaPrestamo, -21);
                ///Fin de las Cabeceras
                ///Detalle de los Asientos
                string NroKuentaOri = HPResergerFunciones.Utilitarios.ExtraerCuenta(cboOriCuentaBanco.Text);
                string NroKuentaDes = HPResergerFunciones.Utilitarios.ExtraerCuenta(cboDesCuentaBanco.Text);
                ///Detalle en la Empresa Origen
                CapaLogica.InsertarAsientoFacturaDetalle(10, 1, IdAsientoOri, FechaContable, txtOriCuentaContable.Text, IdProyectoOri, 0, "0"
                   , "", 0, "0", "0", 0, FechaPrestamo, FechaContable, FechaContable, IdMoneda == 1 ? MontoPrestado : MontoPrestado * ValorTC, IdMoneda == 2 ? MontoPrestado : MontoPrestado / ValorTC, ValorTC,
                   IdMoneda, " ", "", Glosa, FechaContable, IdUsuario, " ");
                CapaLogica.InsertarAsientoFacturaDetalle(10, 2, IdAsientoOri, FechaContable, cboOriCuentaBanco.SelectedValue.ToString(), IdProyectoOri, 0, "0"
                   , "", 0, "0", "0", 0, FechaPrestamo, FechaContable, FechaContable, IdMoneda == 1 ? MontoPrestado : MontoPrestado * ValorTC, IdMoneda == 2 ? MontoPrestado : MontoPrestado / ValorTC, ValorTC,
                   IdMoneda, NroKuentaOri, "", Glosa, FechaContable, IdUsuario, " ");
                ///Detalle en la Empresa Destino
                CapaLogica.InsertarAsientoFacturaDetalle(10, 1, IdAsientoDes, FechaContable, cboDesCuentaBanco.SelectedValue.ToString(), IdProyectoDes, 0, "0"
                   , "", 0, "0", "0", 0, FechaPrestamo, FechaContable, FechaContable, IdMoneda == 1 ? MontoPrestado : MontoPrestado * ValorTC, IdMoneda == 2 ? MontoPrestado : MontoPrestado / ValorTC, ValorTC,
                   IdMoneda, NroKuentaDes, "", Glosa, FechaContable, IdUsuario, " ");
                CapaLogica.InsertarAsientoFacturaDetalle(10, 2, IdAsientoDes, FechaContable, txtDesCuentaContable.Text, IdProyectoDes, 0, "0"
                   , "", 0, "0", "0", 0, FechaPrestamo, FechaContable, FechaContable, IdMoneda == 1 ? MontoPrestado : MontoPrestado * ValorTC, IdMoneda == 2 ? MontoPrestado : MontoPrestado / ValorTC, ValorTC,
                   IdMoneda, " ", "", Glosa, FechaContable, IdUsuario, " ");
                ///Fin detalle de los asientos
                ///Proceso de Cuadre de Asientos
                CapaLogica.CuadrarAsiento(CuoOri, IdProyectoOri, FechaContable, 2);
                CapaLogica.CuadrarAsiento(CuoDes, IdProyectoDes, FechaContable, 2);
                ///Inserto el Registro del Prestamo InterEmpresa
                ///En Banco Enviamos el ID de la Cta para en el asientoo Buscar el Banco
                CapaLogica.PrestamosInterEmpresa(1, IdEmpresaOri, IdProyectoOri, IdEtapaOri, (int)((DataTable)cboOriCuentaBanco.DataSource).Rows[cboOriCuentaBanco.SelectedIndex]["idtipocta"]
                    , (int)((DataTable)cboOriCuentaBanco.DataSource).Rows[cboOriCuentaBanco.SelectedIndex]["idtipocta"], CuoOri, txtOriCuentaContable.Text, IdEmpresaDes, IdProyectoDes
                    , IdEtapaDes, (int)((DataTable)cboDesCuentaBanco.DataSource).Rows[cboDesCuentaBanco.SelectedIndex]["idtipocta"], (int)((DataTable)cboDesCuentaBanco.DataSource).Rows[cboDesCuentaBanco.SelectedIndex]["idtipocta"]
                    , CuoDes, txtDesCuentaContable.Text, IdMoneda, MontoPrestado, FechaContable, FechaPrestamo, ValorTC, Glosa, 1);
                ///Proceso Finalizado;
                msg($"Se Grabó Exitosamente\nEn la Empresa Origen cuo: {CuoOri}\nEn la Empresa Destino cuo: {CuoDes}");
                CargaDatos();
            }
            else { msg("Cancelado por el Usuario"); }
        }
        private void txtOriCuentaContable_TextChanged(object sender, EventArgs e)
        {
            DataTable Table = CapaLogica.BuscarCuentas(txtOriCuentaContable.Text, 1);
            if (Table.Rows.Count > 0)
                txtOriNombreCuenta.Text = Configuraciones.MayusculaCadaPalabra((Table.Rows[0][0].ToString()));
            else
                txtOriNombreCuenta.CargarTextoporDefecto();
        }
        private void txtDesCuentaContable_TextChanged(object sender, EventArgs e)
        {
            DataTable Table = CapaLogica.BuscarCuentas(txtDesCuentaContable.Text, 1);
            if (Table.Rows.Count > 0)
                txtDesNombreCuenta.Text = Configuraciones.MayusculaCadaPalabra((Table.Rows[0][0].ToString()));
            else
                txtDesNombreCuenta.CargarTextoporDefecto();
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
            frmlistarcuentas cuentitas = new frmlistarcuentas();
            cuentitas.Txtbusca.Text = i == 1 ? txtOriCuentaContable.Text : txtDesCuentaContable.Text;
            cuentitas.radioButton1.Checked = true;
            cuentitas.ShowDialog();
            if (cuentitas.aceptar)
            {
                if (i == 1) txtOriCuentaContable.Text = cuentitas.codigo;
                else txtDesCuentaContable.Text = cuentitas.codigo;
            }
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
                txtOriCuentaContable.Text = item.Cells[xCtaContableOri.Name].Value.ToString();
                txtDesCuentaContable.Text = item.Cells[xCtaContableDes.Name].Value.ToString();
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
                //
            }
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
        }
    }
}
