﻿using HpResergerUserControls;
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
    public partial class frmEntregaRendirPago : FormGradient
    {
        public frmEntregaRendirPago()
        {
            InitializeComponent();
            dtpFechaContable.Value = dtpFechaCompensa.Value = DateTime.Now;
            CargarTipoPagos();
            CargarMoneda();
            CargarEmpresa();
            txtglosa.CargarTextoporDefecto(); txtnrooperacion.CargarTextoporDefecto();
        }
        public void CargarMoneda() { CapaLogica.TablaMoneda(cbomoneda); }
        public void CargarEmpresa() { CapaLogica.TablaEmpresa(cboempresa); }
        private void frmEntregaRendirPago_Load(object sender, EventArgs e)
        {
        }
        public void CargarTipoPagos()
        {
            cbotipo.DisplayMember = "mediopago";
            cbotipo.ValueMember = "codsunat";
            DTipoPagos = CapaLogica.ListadoMedioPagos();
            cbotipo.DataSource = DTipoPagos;
            if (cbotipo.Items.Count > 0) cbotipo.SelectedValue = 3;
        }
        HPResergerCapaLogica.HPResergerCL CapaLogica = new HPResergerCapaLogica.HPResergerCL();
        int _idempresa;
        private string _NameEmpresa;
        public string NameEmpresa
        {
            get { return _NameEmpresa; }
            set
            {
                if (value != NameEmpresa)
                    if (NameEmpresa != null && NameEmpresa != "")
                        BuscarEmpleadoCompensaciones();
                _NameEmpresa = value;
            }
        }
        public DataTable EmpleadosCompensaciones()
        {
            return CapaLogica.ListarEmpleadosCompensaciones((int)cboempresa.SelectedValue, 3);
        }
        public void BuscarEmpleadoCompensaciones()
        {
            if (cboempresa.SelectedValue != null)
            {
                cboempleado.DataSource = EmpleadosCompensaciones();
                if (cboempleado.Items.Count == 0)
                {
                    if (DtgcontenFacturas.DataSource != null)
                        DtgcontenFacturas.DataSource = ((DataTable)DtgcontenFacturas.DataSource).Clone();
                    if (DtgcontenEntregas.DataSource != null)
                        DtgcontenEntregas.DataSource = ((DataTable)DtgcontenEntregas.DataSource).Clone();
                    ContarRegistros();
                }
            }
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
                    cbobanco_SelectedIndexChanged(sender, e);
                }
            }
            //btnaceptar.Enabled = true;
            cboempleado.DisplayMember = "empleado";
            cboempleado.ValueMember = "UsuarioCompensacion";
            NameEmpresa = cboempresa.Text;
        }
        //int fkEmpresa = 99;
        private void cboempleado_SelectedIndexChanged(object sender, EventArgs e)
        {
            ContaFacturas = ContarEntregas = 0;
            ImporteTotal = 0;
            if (cboempleado.SelectedValue != null)
            {
                //Compensaciones
                string[] valor = cboempleado.SelectedValue.ToString().Split('-');
                DataTable Table = CapaLogica.ListarCompensacionesxPagar((int)cboempresa.SelectedValue, 3, int.Parse(valor[0]), valor[1], 2);
                DataColumn ColumnaOk = new DataColumn("ok", typeof(int));
                ColumnaOk.DefaultValue = 0;
                Table.Columns.Add(ColumnaOk);
                DtgcontenEntregas.DataSource = Table;
                //Facturas               
                DataTable Tablex = FacturasxCompensa();//CapaLogica.ListarFacturasAnticipos(valor[1], (int)cboempresa.SelectedValue);
                DtgcontenFacturas.DataSource = Tablex;
                FacturasDolares = FacturasSoles = 0;
                EntregasDolares = EntregaSoles = 0;
            }
            else
            {
                if (DtgcontenEntregas.DataSource != null)
                {
                    DtgcontenEntregas.DataSource = ((DataTable)DtgcontenEntregas.DataSource).Clone();
                }
                if (DtgcontenFacturas.DataSource != null)
                {
                    DtgcontenFacturas.DataSource = ((DataTable)DtgcontenFacturas.DataSource).Clone();
                }
            }
            CalcularTotales();
        }
        //public DataTable TablaProveedores()
        //{
        //    fkEmpresa = 99;
        //    //combo.DisplayMember = "proveedor";
        //    //combo.ValueMember = "TipoidNumDoc";
        //    if (cboempresa.SelectedValue != null) fkEmpresa = (int)cboempresa.SelectedValue;
        //    return CapaLogica.ListarProveedoresCompensaciones(fkEmpresa);
        //}
        DataTable Table;
        private void cboempleado_Click(object sender, EventArgs e)
        {
            string cadena = cboempleado.Text;
            Table = EmpleadosCompensaciones();
            if (cboempleado.SelectedValue != null)
            {
                DataTable Table1 = FacturasxCompensa();
                DataTable Table2 = EntregasaRendir();
                if (Table1.Rows.Count != DtgcontenFacturas.RowCount)
                {
                    cboempleado_SelectedIndexChanged(sender, e); return;
                }
                if (Table2.Rows.Count != DtgcontenEntregas.RowCount)
                {
                    cboempleado_SelectedIndexChanged(sender, e); return;
                }
            }
            else
            {
                if (DtgcontenEntregas.DataSource != null)
                {
                    DtgcontenEntregas.DataSource = ((DataTable)DtgcontenEntregas.DataSource).Clone();
                }
                if (DtgcontenFacturas.DataSource != null)
                {
                    DtgcontenFacturas.DataSource = ((DataTable)DtgcontenFacturas.DataSource).Clone();
                }
            }
            if (cboempleado.Items.Count != Table.Rows.Count)
            {
                cboempleado.DataSource = EmpleadosCompensaciones();
                cboempleado.Text = cadena;
            }
        }
        private void SacarEntregasRendir()
        {
            if (cboempleado.SelectedValue != null)
            {
                DataTable Table = EntregasaRendir();
                DtgcontenFacturas.DataSource = Table;
                btnaceptar.Enabled = false;
            }
            ContarRegistros();
        }
        private void sacarFacturasxCompensar()
        {
            if (cboempleado.SelectedValue != null)
            {
                DataTable Table = FacturasxCompensa();
                DtgcontenFacturas.DataSource = Table;
                btnaceptar.Enabled = false;
            }
            ContarRegistros();
        }
        public DataTable EntregasaRendir()
        {
            string[] empleado = cboempleado.SelectedValue.ToString().Split('-');
            return CapaLogica.ListarCompensacionesxPagar(_idempresa, 3, int.Parse(empleado[0]), empleado[1], 2);
        }
        public DataTable FacturasxCompensa()
        {
            return CapaLogica.ListarFacturasCompensaciones(cboempleado.SelectedValue.ToString(), (int)cboempresa.SelectedValue, 3, (int)cbomoneda.SelectedValue);
        }
        private void cbomoneda_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbocuentaxpagar.ValueMember = "idcuenta";
            cbocuentaxpagar.DisplayMember = "Cuenta_contable";
            cbocuentaxpagar.DataSource = CargarCuentasxPagar();
            CalcularTotales(); CargarCuentasBancos();
        }
        public DataTable CargarCuentasxPagar()
        {
            string tipomoneda = "MN";
            if (cbomoneda.Items.Count > 0)
            {
                if ((int)cbomoneda.SelectedValue == 1)
                {
                    tipomoneda = "mn";
                }
                else if ((int)cbomoneda.SelectedValue == 2)
                {
                    tipomoneda = "me";
                }
            }
            DataTable TablePagar = CapaLogica.BuscarCuentas($"%46%otras cuentas por pagar%{tipomoneda}", 5, "D");
            return TablePagar;
        }
        public void ContarRegistros()
        {
            CalcularTotales();
            //lbltotalregistros.Text = $"Total de Registros: {DtgcontenFacturas.RowCount}";
        }
        private void cbobanco_Click(object sender, EventArgs e)
        {
            string cadenar = cbobanco.Text;
            DataTable TableBancos = CapaLogica.TablaBanco();
            if (TableBancos.Rows.Count != cbobanco.Items.Count)
            {
                cbobanco.ValueMember = "sufijo";
                cbobanco.DisplayMember = "descripcion";
                cbobanco.DataSource = TableBancos;
                cbobanco.Text = cadenar;
            }
        }
        public void CargarCuentasBancos()
        {
            if (cboempresa.SelectedValue != null && cbobanco.SelectedValue != null)
            {
                cbocuentabanco.ValueMember = "Id_Cuenta_Contable";
                cbocuentabanco.DisplayMember = "banco";
                cbocuentabanco.DataSource = CapaLogica.ListarBancosTiposdePagoxEmpresa(cbobanco.SelectedValue.ToString(), (int)cboempresa.SelectedValue, (int)cbomoneda.SelectedValue);
            }
        }
        private void cbobanco_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbobanco.SelectedIndex >= 0)
            {
                cbocuentabanco.Text = "";
                CargarCuentasBancos();

            }
            if (cbotipo.SelectedValue != null)
            {
                lblcheque.Visible = txtnrooperacion.Visible = cbobanco.Visible = cbocuentabanco.Visible = lblbanco.Visible = lblmsgsalida.Visible = true;
                if ((int)cbotipo.SelectedValue == 0)
                {
                    lblcheque.Visible = txtnrooperacion.Visible = cbobanco.Visible = cbocuentabanco.Visible = lblbanco.Visible = lblmsgsalida.Visible = false;
                }
            }
        }

        private void DtgcontenAnticipos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //si damos click en el checkbutton
            if (e.ColumnIndex == DtgcontenEntregas.Columns[yOk.Name].Index)
            {
                DtgcontenEntregas.EndEdit(); DtgcontenEntregas.RefreshEdit();
            }
        }
        private void DtgcontenAnticipos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int x = e.RowIndex;
            if (x >= 0)
            {
                DtgcontenEntregas[yOk.Name, x].Value = ((int)DtgcontenEntregas[yOk.Name, x].Value) == 1 ? 0 : 1;
            }
            else if (e.ColumnIndex == DtgcontenEntregas.Columns[yOk.Name].Index)
            {
                if (DtgcontenEntregas.RowCount > 0)
                {
                    int valor = (int)DtgcontenEntregas[yOk.Name, 0].Value;
                    foreach (DataGridViewRow item in DtgcontenEntregas.Rows)
                    {
                        item.Cells[yOk.Name].Value = valor == 1 ? 0 : 1;
                    }
                }
            }
            DtgcontenEntregas.EndEdit(); DtgcontenEntregas.RefreshEdit();
        }
        frmTipodeCambio frmtipo;
        public void SacarTipoCambio()
        {
            DateTime FechaValidaBuscar = dtpFechaCompensa.Value;
            txttipocambio.Text = CapaLogica.TipoCambioDia("Venta", FechaValidaBuscar).ToString("n3");
            if (decimal.Parse(txttipocambio.Text) == 0)
            {
                if (frmtipo == null)
                {
                    frmtipo = new frmTipodeCambio();
                    //frmtipo.ActualizoTipoCambio += Frmtipo_ActualizoTipoCambio;
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
        private void dtpFechaCompensa_ValueChanged(object sender, EventArgs e)
        {
            SacarTipoCambio();
        }
        private void DtgcontenFacturas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //si damos click en el checkbutton
            if (e.ColumnIndex == DtgcontenFacturas.Columns[xok.Name].Index && e.RowIndex >= 0)
            {
                SelecionarFacturaDetraccion(e.RowIndex);
                DtgcontenFacturas.EndEdit(); DtgcontenFacturas.RefreshEdit();
            }
        }
        private void DtgcontenFacturas_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int x = e.RowIndex;
            if (x >= 0)
            {
                DtgcontenFacturas[xok.Name, x].Value = ((int)DtgcontenFacturas[xok.Name, x].Value) == 1 ? 0 : 1;
            }
            else if (e.ColumnIndex == DtgcontenFacturas.Columns[xok.Name].Index)
            {
                if (DtgcontenFacturas.RowCount > 0)
                {
                    int valor = (int)DtgcontenFacturas[xok.Name, 0].Value;
                    foreach (DataGridViewRow item in DtgcontenFacturas.Rows)
                    {
                        item.Cells[xok.Name].Value = valor == 1 ? 0 : 1;
                    }
                }
            }
            DtgcontenFacturas.EndEdit(); DtgcontenFacturas.RefreshEdit();
        }
        //ANTICIPOS
        int ContarEntregas, ContaFacturas;
        decimal EntregaSoles, EntregasDolares;
        decimal FacturasSoles, FacturasDolares;
        private DataTable DTipoPagos;

        private void txtImporteTotal_TextChanged(object sender, EventArgs e)
        {
            cbobanco.Enabled = cbocuentabanco.Enabled = cbotipo.Enabled = txtnrooperacion.Enabled = true;
            lblcheque.Visible = txtnrooperacion.Visible = lblcuentasxpagar.Visible = cbocuentaxpagar.Visible = false;
            string cadena = cbotipo.Text;
            var valorCompensa = DTipoPagos.NewRow();
            valorCompensa[0] = 0;
            valorCompensa[1] = "0 - NINGUNO";
            valorCompensa[2] = 0;
            //string valorCompensa = "000 Ninguno.";
            //Quitamos el Valor de Ninguno
            cbotipo.Items.Remove(valorCompensa);
            for (int i = 0; i < DTipoPagos.Rows.Count; i++)
            {
                if (DTipoPagos.Rows[0][0].ToString() == "0")
                {
                    DTipoPagos.Rows.Remove(DTipoPagos.Rows[i]);
                    i--;
                }
            }
            if (ImporteTotal == 0)
            {
                cbobanco.Enabled = cbocuentabanco.Enabled = cbotipo.Enabled = txtnrooperacion.Enabled = false;
                //cbopago.Items.Remove(valorCompensa);
            }
            else if (ImporteTotal > 0)
            {
                lblcheque.Visible = txtnrooperacion.Visible = lblcuentasxpagar.Visible = cbocuentaxpagar.Visible = true;
                lblmsgsalida.Text = "Salida Dinero:";
                DTipoPagos.Rows.InsertAt(valorCompensa, 0);

            }
            else
            {
                lblcheque.Visible = txtnrooperacion.Visible = true;
                lblmsgsalida.Text = "Entrada Dinero:";
                if (ContaFacturas > 0)
                {
                    //cbopago.Items.Remove(valorCompensa);
                    //cbotipo.Items.Insert(0, valorCompensa);
                    DTipoPagos.Rows.InsertAt(valorCompensa, 0);
                }
                //else
                //cbopago.Items.Remove(valorCompensa);
            }
            cbotipo.Text = cadena;
        }

        private void cbopago_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbobanco.Enabled = cbocuentabanco.Enabled = txtnrooperacion.Enabled = true;
            txtPorAbonar.Enabled = true;
            OcultarOpcionesPago(false);
            //Transferencia de Fondos
            if ((int)cbotipo.SelectedValue == 3)
            {
                if (!txtnrooperacion.EstaLLeno())
                {
                    txtnrooperacion.Text = txtnrooperacion.TextoDefecto = "Ingrese Nro Operación".ToUpper();
                    txtnrooperacion.CargarTextoporDefecto();
                }
            }
            //Cheques
            else if ((int)cbotipo.SelectedValue == 7)
            {
                if (!txtnrooperacion.EstaLLeno())
                {
                    txtnrooperacion.Text = txtnrooperacion.TextoDefecto = "Ingrese Nro Cheque".ToUpper();
                    txtnrooperacion.CargarTextoporDefecto();
                }
            }
            else if ((int)cbotipo.SelectedValue == 0)
            {
                cbobanco.Enabled = cbocuentabanco.Enabled = txtnrooperacion.Enabled = false;
                txtPorAbonar.Enabled = false;
                OcultarOpcionesPago(true);
            }
        }

        private void DtgcontenAnticipos_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            ContarEntregas = 0;
            EntregaSoles = 0;
            EntregasDolares = 0;
            foreach (DataGridViewRow item in DtgcontenEntregas.Rows)
            {
                if ((int)item.Cells[yOk.Name].Value == 1)
                {
                    ContarEntregas++;
                    EntregaSoles += (decimal)item.Cells[xMontoMN.Name].Value;
                    EntregasDolares += (decimal)item.Cells[xMontoME.Name].Value;
                }
            }
            CalcularTotales();
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            if (ContarEntregas + ContaFacturas > 0)
            {
                if (msgp("¿Seguro Desea Salir?") == DialogResult.Yes) this.Close();
            }
            else
                this.Close();
        }

        private void txtPorAbonar_TextChanged(object sender, EventArgs e)
        {
            CalcularxAbonar();
        }
        public void CalcularxAbonar()
        {
            decimal ImporteAbonar = 0;
            decimal.TryParse(txtPorAbonar.Text, out ImporteAbonar);
            if (decimal.Parse(txtPorAbonar.Text == "" ? "0" : ImporteAbonar.ToString()) > Math.Abs(ImporteTotal))
            {
                txtPorAbonar.Text = Math.Abs(ImporteTotal).ToString("n2");
            }
        }
        public void SelecionarFacturaDetraccion(int _x)
        {
            DtgcontenFacturas.SuspendLayout();
            int x = _x;
            foreach (DataGridViewRow item in DtgcontenFacturas.Rows)
            {
                if (item.Index != _x)
                    if (item.Cells[xProveedor.Name].Value.ToString() == DtgcontenFacturas[xProveedor.Name, x].Value.ToString() && item.Cells[xNroComprobante.Name].Value.ToString() == DtgcontenFacturas[xNroComprobante.Name, x].Value.ToString())
                    {
                        item.Cells[xok.Name].Value = ((int)DtgcontenFacturas[xok.Name, x].Value) == 1 ? 1 : 0;
                    }
            }
            DtgcontenFacturas.ResumeLayout();
        }
        decimal ImporteTotal
        {
            get { return decimal.Parse(txtImporteTotal.Text); }
            set
            {
                txtImporteTotal.Text = value.ToString("n2");
                txtPorAbonar.Text = Math.Abs(value).ToString("n2");
                if (ImporteTotal < 0)
                    //if (cbotipo.Text == "000 Ninguno.")
                    if ((int)cbotipo.SelectedValue == 0)
                        txtPorAbonar.Enabled = false;
                    else txtPorAbonar.Enabled = true;
                else if (cbotipo.Text == "") cbotipo.SelectedValue = 0;
            }
        }
        public void CalcularTotales()
        {
            ContaFacturas = 0;
            btnaceptar.Enabled = false;
            cboempleado.Enabled = cboproyecto.Enabled = cboempresa.Enabled = btnbusproveedor.Enabled = true;
            txttotalME.Text = txttotaldifME.Text = txttotalMN.Text = txttotaldifMN.Text = "0.00";
            if (cbomoneda.SelectedValue != null)
            {
                int mon = (int)cbomoneda.SelectedValue;
                decimal sumatoriaMN = 0, diferenciaMN = 0;
                decimal sumatoriaME = 0, diferenciaME = 0;
                foreach (DataGridViewRow item in DtgcontenFacturas.Rows)
                {
                    //si esta seleccionado
                    if ((int)item.Cells[xok.Name].Value == 1)
                    {
                        ContaFacturas++;
                        if ((int)item.Cells[xidMoneda.Name].Value == 1)
                        {
                            //Nacional
                            sumatoriaMN += Configuraciones.Redondear((decimal)item.Cells[xTotal.Name].Value);
                            //Extranjero
                            sumatoriaME += Configuraciones.Redondear((decimal)item.Cells[xTotal.Name].Value / (decimal)item.Cells[xTCOri.Name].Value);
                            if ((int)cbomoneda.SelectedValue != 1)
                                diferenciaME += Configuraciones.Redondear((decimal)item.Cells[xTotal.Name].Value / (decimal)item.Cells[xTcReg.Name].Value) -
                                    Configuraciones.Redondear((decimal)item.Cells[xTotal.Name].Value / (decimal)item.Cells[xTCOri.Name].Value);

                        }
                        else if ((int)item.Cells[xidMoneda.Name].Value == 2)
                        {
                            //Nacional
                            sumatoriaMN += Configuraciones.Redondear((decimal)item.Cells[xTotal.Name].Value * (decimal)item.Cells[xTCOri.Name].Value);
                            sumatoriaME += Configuraciones.Redondear((decimal)item.Cells[xTotal.Name].Value);
                            //Extranjero
                            if ((int)cbomoneda.SelectedValue != 2)
                                diferenciaMN += Configuraciones.Redondear((decimal)item.Cells[xTotal.Name].Value * (decimal)item.Cells[xTcReg.Name].Value) -
                                                Configuraciones.Redondear((decimal)item.Cells[xTotal.Name].Value * (decimal)item.Cells[xTCOri.Name].Value);
                            //diferenciaMN += Configuraciones.Redondear((decimal)item.Cells[xTotal.Name].Value / (decimal)item.Cells[xTcReg.Name].Value) -
                            //    Configuraciones.Redondear((decimal)item.Cells[xTotal.Name].Value / (decimal)item.Cells[xTCOri.Name].Value);
                        }
                    }
                }
                txttotalMN.Text = sumatoriaMN.ToString("n2");
                txttotaldifMN.Text = diferenciaMN.ToString("n2");
                txttotalME.Text = sumatoriaME.ToString("n2");
                txttotaldifME.Text = diferenciaME.ToString("n2");
                if ((int)cbomoneda.SelectedValue == 1)
                    txtImporteTotal.Text = (sumatoriaMN + diferenciaMN).ToString("n2");
                else if ((int)cbomoneda.SelectedValue == 2)
                    txtImporteTotal.Text = (sumatoriaME + diferenciaME).ToString("n2");
                if (ContaFacturas > 0 || ContarEntregas > 0)
                {
                    cboempleado.Enabled = cboproyecto.Enabled = cboempresa.Enabled = btnbusproveedor.Enabled = false;
                    btnaceptar.Enabled = true;
                }
                ImporteTotal = 0;
                if (cbomoneda.SelectedValue != null)
                    //soles
                    if ((int)cbomoneda.SelectedValue == 1)
                    {
                        ImporteTotal = FacturasSoles - EntregaSoles;
                    }
                    //dolares
                    else
                    {
                        ImporteTotal = FacturasDolares - EntregasDolares;
                    }
            }
            lbltotalregistros.Text = $"Total Entregas: {ContarEntregas}/{DtgcontenEntregas.RowCount} - Total Facturas: {ContaFacturas}/{DtgcontenFacturas.RowCount}";// - Seleccionado: {ContaAnticipos + ContaFacturas}";
        }
        private void DtgcontenFacturas_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            SelecionarFacturaDetraccion(e.RowIndex);
            ContaFacturas = 0;
            FacturasSoles = 0;
            FacturasDolares = 0;
            foreach (DataGridViewRow item in DtgcontenFacturas.Rows)
            {
                if ((int)item.Cells[xok.Name].Value == 1)
                {
                    ContaFacturas++;
                    if ((int)item.Cells[xidMoneda.Name].Value == 1)
                    {
                        FacturasSoles += (decimal)item.Cells[xTotal.Name].Value;
                        //de soles a dolares Divido
                        FacturasDolares += Configuraciones.Redondear((decimal)item.Cells[xTotal.Name].Value / (decimal)item.Cells[xTcReg.Name].Value);
                    }
                    else
                    {
                        //de soles a dolares Multiplico
                        FacturasSoles += Configuraciones.Redondear((decimal)item.Cells[xTotal.Name].Value * (decimal)item.Cells[xTcReg.Name].Value);
                        FacturasDolares += (decimal)item.Cells[xTotal.Name].Value;
                    }
                }
            }
            //DtgcontenFacturas.EndEdit(); DtgcontenFacturas.RefreshEdit();
            CalcularTotales();
        }

        private void btnbusproveedor_Click(object sender, EventArgs e)
        {
            frmListarEmpleados frmlisempleado = new frmListarEmpleados();
            string[] empleado = "0-0".Split('-');
            if (cboempleado.SelectedValue != null)
            {
                empleado = cboempleado.SelectedValue.ToString().Split('-');
                frmlisempleado.TipoDocumento = int.Parse(empleado[0]);
                frmlisempleado.NumeroDocumento = empleado[1];
            }
            frmlisempleado.Text = "Seleccione Empleado para la Entrega a Rendir";
            if (frmlisempleado.ShowDialog() == DialogResult.OK)
            {
                cboempleado.SelectedValue = frmlisempleado.TipoDocumento + "-" + frmlisempleado.NumeroDocumento;
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
        public void OcultarOpcionesPago(Boolean a)
        {
            label17.Visible = lblbanco.Visible = lblmsgsalida.Visible = cbobanco.Visible = cbocuentabanco.Visible = txtnrooperacion.Visible = !a;
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (ContaFacturas + ContarEntregas <= 0)
            {
                cboempleado_Click(sender, e);
            }
        }
        public DialogResult msgp(string cadena) { return HPResergerFunciones.frmPregunta.MostrarDialogYesCancel(cadena); }
        public void msg(string cadena) { HPResergerFunciones.frmInformativo.MostrarDialogError(cadena); }
        public void msgOK(string cadena) { HPResergerFunciones.frmInformativo.MostrarDialog(cadena); }

        private void btnaceptar_Click(object sender, EventArgs e)
        {
            //Validaciones
            if (cboempresa.SelectedValue == null)
            {
                msg("Seleccione la Empresa");
                cboempresa.Focus(); return;
            }
            if (cboproyecto.SelectedValue == null)
            {
                msg("Seleccione el Proyecto");
                cboproyecto.Focus(); return;
            }
            if (cboempleado.SelectedValue == null)
            {
                msg("Seleccione el Empleado");
                cboempleado.Focus(); return;
            }
            if (cbomoneda.SelectedValue == null)
            {
                msg("Seleccione la Moneda");
                cbomoneda.Focus(); return;
            }
            if (cbotipo.Items.Count == 0) { cbotipo.Focus(); msg("Seleccione Tipo de Pago"); return; }
            int TipoPago = (int)cbotipo.SelectedValue;
            if (ImporteTotal == 0) TipoPago = 0;
            string NroOperacion = txtnrooperacion.TextValido();
            if (decimal.Parse(txtImporteTotal.Text) != 0)
            {
                //if (cbotipo.Text != "000 Ninguno.")
                if (TipoPago != 0)
                {
                    if (cbobanco.SelectedValue == null)
                    {
                        msg("Seleccione el Banco");
                        cbobanco.Focus(); return;
                    }
                    if (cbocuentabanco.SelectedValue == null)
                    {
                        msg("Seleccione la cuenta del Abono");
                        cbocuentabanco.Focus(); return;
                    }
                    if (!txtnrooperacion.EstaLLeno())
                    {
                        msg("Ingrese Valor De Nro Operacion - Cheque");
                        txtnrooperacion.Focus(); return;
                    }
                    if (cbotipo.SelectedValue == null)
                    {
                        msg("Seleccione Tipo de Pago");
                        cbotipo.Focus(); return;
                    }
                }
            }
            if (decimal.Parse(txttipocambio.Text) == 0)
            {
                msg("El monto del Tipo de Cambio no debe ser Cero");
                txttipocambio.Focus(); return;
            }
            if (!txtglosa.EstaLLeno())
            {
                msg("Ingrese Glosa");
                txtglosa.Focus(); return;
            }
            if (ContarEntregas <= 0)
            {
                msg("No se ha Seleccionado Entregas");
                return;
            }
            if (ContaFacturas <= 0)
            {
                if (msgp("No se ha Seleccionado Facturas, Desea Continuar?") != DialogResult.Yes)
                    return;
            }
            //Validacion de que el periodo NO sea muy disperso, sea un mes continuo a los trabajados
            int IdEmpresa = (int)cboempresa.SelectedValue;
            DateTime FechaCoontable = dtpFechaContable.Value;
            if (!CapaLogica.ValidarCrearPeriodo(IdEmpresa, FechaCoontable))
            {
                if (HPResergerFunciones.frmPregunta.MostrarDialogYesCancel("No se Puede Registrar este Asiento\nEl Periodo no puede Crearse", $"¿Desea Crear el Periodo de {FechaCoontable.ToString("MMMM")}-{FechaCoontable.Year}?") != DialogResult.Yes)
                    return;
            }
            else
            if (!CapaLogica.VerificarPeriodoAbierto((int)cboempresa.SelectedValue, dtpFechaContable.Value))
            {
                msg("El Periodo Esta Cerrado, Cambie Fecha Contable"); dtpFechaContable.Focus(); return;
            }
            if (msgp("¿Seguro Desea Aplicar las Entregas a Rendir?") == DialogResult.Yes)
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
                string[] Empleado = cboempleado.SelectedValue.ToString().Split('-');
                int TipoIdProveedor = int.Parse(Empleado[0]);
                string NumDocEmpleado = Empleado[1];
                string NameEmpleado = cboempleado.Text.Substring(cboempleado.Text.IndexOf('-') + 2).ToUpper();
                decimal ImporteTotal = decimal.Parse(txtImporteTotal.Text);
                decimal tc = decimal.Parse(txttipocambio.Text);
                string glosa = txtglosa.TextValido();
                int idUsuario = frmLogin.CodigoUsuario;
                DateTime FechaContable = dtpFechaContable.Value;
                DateTime FechaCompensa = dtpFechaCompensa.Value;
                ///
                string CuentaCtaBanco = (cbocuentabanco.SelectedValue ?? "").ToString();
                ///
                DataRow Fila = CapaLogica.VerUltimoIdentificador("Tbl_EntregasRendir_Det", "pkid");
                int SiguientePkId = 0;
                int.TryParse(Fila["ultimo"].ToString(), out SiguientePkId);
                SiguientePkId++;
                string[] UserCompensa = cboempleado.SelectedValue.ToString().Split('-');
                int IdLogin = frmLogin.CodigoUsuario;
                DateTime FechaPago = dtpFechaCompensa.Value;
                string CtaPerdida = CapaLogica.BuscarCuentas("perdida%cambio", 5).Rows[1]["idcuenta"].ToString();
                string CtaGanacia = CapaLogica.BuscarCuentas("ganancia%cambio", 5).Rows[0]["idcuenta"].ToString();
                //VALIDAMOS QUE NO EXISTAN CUENTAS CONTABLES DESACTIVADAS
                List<string> ListaAuxiliar = new List<string>();
                foreach (DataGridViewRow item in DtgcontenFacturas.Rows)
                    if ((int)item.Cells[xok.Name].Value == 1)
                        ListaAuxiliar.Add(item.Cells[xcuenta.Name].Value.ToString());
                foreach (DataGridViewRow item in DtgcontenEntregas.Rows)
                    if ((int)item.Cells[yOk.Name].Value == 1)
                        ListaAuxiliar.Add(item.Cells[xcuentacontable.Name].Value.ToString());
                ListaAuxiliar.Add(CtaPerdida);
                ListaAuxiliar.Add(CtaGanacia);
                ListaAuxiliar.Add(CuentaCtaBanco);
                ListaAuxiliar.Add(cbocuentaxpagar.SelectedValue.ToString());
                if (CapaLogica.CuentaContableValidarActivas(string.Join(",", ListaAuxiliar.ToArray()), Mensajes.CuentasContablesDesactivadas)) return;
                //FIN DE LA VALDIACION DE LAS CUENTAS CONTABLES DESACTIVADAS
                //Facturas al Debe      -- xok
                foreach (DataGridViewRow item in DtgcontenFacturas.Rows)
                {
                    if ((int)item.Cells[xok.Name].Value == 1)
                    {
                        string[] valor = item.Cells[xNroComprobante.Name].Value.ToString().Split('-');
                        string CuentaContable = item.Cells[xcuenta.Name].Value.ToString();
                        decimal TC = (decimal)item.Cells[xTcReg.Name].Value;
                        string[] NumFac = item.Cells[xNroComprobante.Name].Value.ToString().Split('-');
                        int idfac = (int)item.Cells[xIdComprobante.Name].Value;
                        DateTime fecha = dtpFechaCompensa.Value;
                        //cabeceras
                        decimal MontoSolesOri = ((int)item.Cells[xidMoneda.Name].Value) == 1 ? (decimal)item.Cells[xTotal.Name].Value : Configuraciones.Redondear((decimal)item.Cells[xTotal.Name].Value * (decimal)item.Cells[xTCOri.Name].Value);
                        decimal MontoDolaresOri = ((int)item.Cells[xidMoneda.Name].Value) == 2 ? (decimal)item.Cells[xTotal.Name].Value : Configuraciones.Redondear((decimal)item.Cells[xTotal.Name].Value / (decimal)item.Cells[xTCOri.Name].Value);
                        //Detalle
                        decimal MontoSolesReg = ((int)item.Cells[xidMoneda.Name].Value) == 1 ? (decimal)item.Cells[xTotal.Name].Value : Configuraciones.Redondear((decimal)item.Cells[xTotal.Name].Value * (decimal)item.Cells[xTcReg.Name].Value);
                        decimal MontoDolaresReg = ((int)item.Cells[xidMoneda.Name].Value) == 2 ? (decimal)item.Cells[xTotal.Name].Value : Configuraciones.Redondear((decimal)item.Cells[xTotal.Name].Value / (decimal)item.Cells[xTcReg.Name].Value);
                        //Cabecera Facturas
                        CapaLogica.InsertarAsientoFacturaCabecera(1, ++PosFila, numasiento, FechaContable, CuentaContable,
                            Math.Abs(MontoSolesOri > 0 ? (moneda == 1 ? MontoSolesOri : MontoDolaresOri) : 0), Math.Abs(MontoSolesOri < 0 ? (moneda == 1 ? MontoSolesOri : MontoDolaresOri) : 0),
                            tc, proyecto, 0, Cuo, moneda, glosa, FechaCompensa, -15);
                        //Detalle del asiento
                        CapaLogica.InsertarAsientoFacturaDetalle(10, PosFila, numasiento, FechaContable, CuentaContable, proyecto, 5, item.Cells[xProveedor.Name].Value.ToString(),
                            item.Cells[xrazon_social.Name].Value.ToString(), idfac, valor[0], valor[1], 0, (DateTime)item.Cells[xFechaEmision.Name].Value, fecha, fecha,
                            Math.Abs(moneda == 1 ? MontoSolesOri : MontoSolesReg), Math.Abs(moneda == 2 ? MontoDolaresOri : MontoDolaresReg),
                            //moneda == (int)item.Cells[xidMoneda.Name].Value ? 
                            (decimal)item.Cells[xTCOri.Name].Value,// : (decimal)item.Cells[xTcReg.Name].Value,
                            (int)item.Cells[xidMoneda.Name].Value, "", "", glosa, FechaCompensa, idUsuario, "");
                        //Actualizar su Estado y Fecha de Compensacion
                        if (item.Cells[xnameComprobante.Name].Value.ToString() != "DET")
                            CapaLogica.ActualizaEstadoFacturas((int)item.Cells[xId.Name].Value, (int)item.Cells[xIdComprobante.Name].Value, 3, FechaCompensa, TipoPago, NroOperacion);
                        else
                        {
                            decimal TotalDetracion = (decimal)item.Cells[xTotal.Name].Value;
                            CapaLogica.Detracciones(1, string.Join("-", valor), item.Cells[xProveedor.Name].Value.ToString(), TotalDetracion, MontoSolesOri, decimal.Parse(txttipocambio.Text),
                                TotalDetracion, 0, NroOperacion, "", "", FechaCompensa, IdLogin, (int)item.Cells[xIdComprobante.Name].Value, _idempresa, Cuo, TipoPago);
                        }
                        if (TipoPago == 0 && ImporteTotal > 0)
                        {
                            if (item.Cells[xnameComprobante.Name].Value.ToString() != "DET")
                            {
                                CapaLogica.EntregasRendir_Detalle(1, SiguientePkId, _idempresa, (int)item.Cells[xIdComprobante.Name].Value, 5, item.Cells[xProveedor.Name].Value.ToString(),
                                    item.Cells[xrazon_social.Name].Value.ToString(), string.Join("-", valor), (DateTime)item.Cells[xFechaEmision.Name].Value, string.Join("-", UserCompensa),
                                   moneda, (decimal)item.Cells[xTcReg.Name].Value,
                                   // (int)item.Cells[xidMoneda.Name].Value 
                                   1 == moneda ? Math.Abs(ImporteTotal) : Math.Abs(ImporteTotal) * (decimal)item.Cells[xTcReg.Name].Value,
                                    //(int)item.Cells[xidMoneda.Name].Value 
                                    2 == moneda ? Math.Abs(ImporteTotal) : Math.Abs(ImporteTotal) / (decimal)item.Cells[xTcReg.Name].Value,
                                    Cuo, "", 1, "", "", "", FechaCompensa, cbocuentaxpagar.SelectedValue.ToString(), txtglosa.Text, item.Cells[xGlosa.Name].Value.ToString(), 1, IdLogin);
                            }
                            else
                            {
                                CapaLogica.EntregasRendir_Detalle(1, SiguientePkId, _idempresa, -1, 5, item.Cells[xProveedor.Name].Value.ToString(),
                                    item.Cells[xrazon_social.Name].Value.ToString(), string.Join("-", valor), (DateTime)item.Cells[xFechaEmision.Name].Value, string.Join("-", UserCompensa),
                                   moneda, (decimal)item.Cells[xTcReg.Name].Value,
                                    //(int)item.Cells[xidMoneda.Name].Value 
                                    1 == moneda ? Math.Abs(ImporteTotal) : Math.Abs(ImporteTotal) * (decimal)item.Cells[xTcReg.Name].Value,
                                    //(int)item.Cells[xidMoneda.Name].Value 
                                    2 == moneda ? Math.Abs(ImporteTotal) : Math.Abs(ImporteTotal) / (decimal)item.Cells[xTcReg.Name].Value,
                                    Cuo, "", 1, "", "", "", FechaCompensa, cbocuentaxpagar.SelectedValue.ToString(), txtglosa.Text, item.Cells[xGlosa.Name].Value.ToString(), 1, IdLogin);


                            }
                        }
                    }
                }
                //Diferencial Ganacia Perdida
                if (Math.Abs(decimal.Parse(txttotaldifMN.Text) + decimal.Parse(txttotaldifME.Text)) > 0)
                {
                    //cabecera                  
                    DateTime fecha = FechaCompensa;
                    decimal diferencial = (moneda == 1 ? decimal.Parse(txttotaldifMN.Text) : decimal.Parse(txttotaldifME.Text));
                    decimal Tc = tc;
                    //Cabecera Diferencial
                    CapaLogica.InsertarAsientoFacturaCabecera(1, ++PosFila, numasiento, FechaContable, (decimal.Parse(txttotaldifME.Text) + decimal.Parse(txttotaldifMN.Text)) > 0 ? CtaPerdida : CtaGanacia,
                        Math.Abs((moneda == 1 ? decimal.Parse(txttotaldifMN.Text) > 0 ? decimal.Parse(txttotaldifMN.Text) : 0 : decimal.Parse(txttotaldifME.Text) > 0 ? decimal.Parse(txttotaldifME.Text) : 0)),
                        Math.Abs((moneda == 1 ? decimal.Parse(txttotaldifMN.Text) < 0 ? decimal.Parse(txttotaldifMN.Text) : 0 : decimal.Parse(txttotaldifME.Text) < 0 ? decimal.Parse(txttotaldifME.Text) : 0)),
                        tc, proyecto, 0, Cuo, moneda, glosa, FechaCompensa, -15);
                    //Detalle Diferencial
                    CapaLogica.InsertarAsientoFacturaDetalle(10, PosFila, numasiento, FechaContable, (decimal.Parse(txttotaldifME.Text) + decimal.Parse(txttotaldifMN.Text)) > 0 ? CtaPerdida : CtaGanacia, proyecto,
                        0, "0", "", 0, "0", "0", 0, fecha, fecha, fecha, ((diferencial < 0 ? -1 : 1) * decimal.Parse(txttotaldifMN.Text)),
                    ((diferencial < 0 ? -1 : 1) * decimal.Parse(txttotaldifME.Text)), Tc, moneda, "", "", glosa, FechaCompensa, idUsuario, "");
                }
                //decimal ImporteAbonarAnticipos = decimal.Parse(txtPorAbonar.Text);
                ///Si son pagos Totales
                //Anticipos al Haber     --yOk
                //if (cbotipo.Text != "000 Ninguno.")
                if (TipoPago != 0 || ContaFacturas == 0 || (TipoPago == 0 && ImporteTotal > 0))
                {
                    foreach (DataGridViewRow item in DtgcontenEntregas.Rows)
                    {
                        if ((int)item.Cells[yOk.Name].Value == 1)
                        {
                            if ((int)item.Cells[yOk.Name].Value == 1)
                            {
                                //string[] NumFac = $"0-Ent.N°{(int)item.Cells[xpkid.Name].Value} {((DateTime)item.Cells[xFechaCompensa.Name].Value).ToString("dd/MM/yyyy")}".Split('-');
                                string[] NumFac = $"{(int)item.Cells[xpkid.Name].Value}-ER{((DateTime)item.Cells[xFechaCompensa.Name].Value).ToString(Configuraciones.ddMMyy)}".Split('-');
                                //Asiento de las facturas al debe
                                string CuentaContable = item.Cells[xcuentacontable.Name].Value.ToString();
                                decimal MontoSoles = (decimal)item.Cells[xMontoMN.Name].Value;
                                decimal MontoDolares = (decimal)item.Cells[xMontoME.Name].Value;
                                decimal TC = tc;
                                CapaLogica.InsertarAsientoFacturaCabecera(1, ++PosFila, numasiento, FechaContable, CuentaContable
                                    , 0, moneda == 1 ? MontoSoles : MontoDolares, TC, proyecto, 0, Cuo, moneda, glosa, FechaCompensa, -15);
                                //Detalle del asiento
                                CapaLogica.InsertarAsientoFacturaDetalle(10, PosFila, numasiento, FechaContable, item.Cells[xcuentacontable.Name].Value.ToString(), proyecto, TipoIdProveedor, NumDocEmpleado
                                    , NameEmpleado, 0, NumFac[0], NumFac[1], 0, FechaContable, FechaCompensa, FechaCompensa, MontoSoles, MontoDolares, TC, moneda, "", "", glosa, FechaCompensa, idUsuario, "");
                                ///Actualizo el Estado del Anticipo(Compensacion)
                                CapaLogica.ActualizarCompensaciones((int)cboempresa.SelectedValue, (int)item.Cells[xTipo.Name].Value, (int)item.Cells[xpkid.Name].Value, 1,
                                     TipoPago, decimal.Parse(txtImporteTotal.Text) == 0 ? "" : HPResergerFunciones.Utilitarios.ExtraerCuenta(cbocuentabanco.Text), NroOperacion, Cuo);
                                //REGISTRO DEL ABONO EN LA TABLA ENTREGAS A RENDIR DETALLES
                                //si las Cuentas son seleccionadas
                            }
                        }
                    }
                }
                //Si el Pago es Parcial!!...
                else
                {
                    //proceso de pago parcial de los entregas a rendir.
                    decimal AcumuladoFacturas = (moneda == 1 ? FacturasSoles : FacturasDolares); //+ (cbopago.Text != "000 Ninguno." ? decimal.Parse(txtPorAbonar.Text) : 0);
                    foreach (DataGridViewRow item in DtgcontenEntregas.Rows)
                    {
                        if ((int)item.Cells[yOk.Name].Value == 1)
                        {
                            if ((int)item.Cells[yOk.Name].Value == 1)
                            {
                                //SAco El Acumalado.
                                AcumuladoFacturas = AcumuladoFacturas - (moneda == 1 ? (decimal)item.Cells[xMontoMN.Name].Value : (decimal)item.Cells[xMontoME.Name].Value);
                                //string[] NumFac = $"0-Ent.N°{(int)item.Cells[xpkid.Name].Value} {((DateTime)item.Cells[xFechaCompensa.Name].Value).ToString("dd/MM/yyyy")}".Split('-');
                                string[] NumFac = $"{(int)item.Cells[xpkid.Name].Value}-ER{((DateTime)item.Cells[xFechaCompensa.Name].Value).ToString(Configuraciones.ddMMyy)}".Split('-');
                                //Asiento de las Entregas a Rendir al Haber.
                                string CuentaContable = item.Cells[xcuentacontable.Name].Value.ToString();
                                decimal MontoSoles = (decimal)item.Cells[xMontoMN.Name].Value;
                                decimal MontoDolares = (decimal)item.Cells[xMontoME.Name].Value;
                                decimal TC = decimal.Parse(txttipocambio.Text);
                                ////Parciales
                                decimal ParcialSoles = 0, ParcialDolares = 0;
                                decimal Factor = 0;
                                if (AcumuladoFacturas < 0)
                                {
                                    if (moneda == 1)
                                    {
                                        Factor = (MontoSoles + AcumuladoFacturas) / MontoSoles;
                                        ParcialSoles = Math.Abs(Configuraciones.Redondear(MontoSoles * Factor));
                                        ParcialDolares = Math.Abs(Configuraciones.Redondear(MontoDolares * Factor));
                                    }
                                    else if (moneda == 2)
                                    {
                                        Factor = (MontoDolares + AcumuladoFacturas) / MontoDolares;
                                        ParcialSoles = Math.Abs(Configuraciones.Redondear(MontoSoles * Factor));
                                        ParcialDolares = Math.Abs(Configuraciones.Redondear(MontoDolares * Factor));
                                    }
                                }
                                ///
                                CapaLogica.InsertarAsientoFacturaCabecera(1, ++PosFila, numasiento, FechaContable, CuentaContable
                                    , 0, AcumuladoFacturas < 0 ? moneda == 1 ? ParcialSoles : ParcialDolares : moneda == 1 ? MontoSoles : MontoDolares, TC, proyecto, 0, Cuo, moneda, glosa, dtpFechaCompensa.Value, -15);
                                //Detalle del asiento
                                CapaLogica.InsertarAsientoFacturaDetalle(10, PosFila, numasiento, FechaContable, item.Cells[xcuentacontable.Name].Value.ToString(), proyecto, TipoIdProveedor, NumDocEmpleado
                                    , NameEmpleado, 0, NumFac[0], NumFac[1], 0, FechaContable, FechaCompensa, FechaCompensa, AcumuladoFacturas < 0 ? ParcialSoles : MontoSoles, AcumuladoFacturas < 0 ? ParcialDolares : MontoDolares,
                                    TC, moneda, "", "", glosa, FechaCompensa, frmLogin.CodigoUsuario, "");
                                ///Actualizo el Estado del Anticipo(Compensacion)
                                //CapaLogica.ActualizarCompensaciones((int)cboempresa.SelectedValue, (int)item.Cells[xTipo.Name].Value, (int)item.Cells[xpkid.Name].Value, 1, Cuo);
                                if (AcumuladoFacturas == 0)
                                {
                                    CapaLogica.ActualizarCompensaciones((int)cboempresa.SelectedValue, (int)item.Cells[xTipo.Name].Value, (int)item.Cells[xpkid.Name].Value, 1,
                                         TipoPago, TipoPago == 0 ? "" : HPResergerFunciones.Utilitarios.ExtraerCuenta(cbocuentabanco.Text), txtnrooperacion.TextValido(), Cuo);
                                    break;
                                }
                                else if (AcumuladoFacturas < 0)
                                {
                                    //Parcial
                                    CapaLogica.InsertarCompensacionesDetalle((int)item.Cells[xpkid.Name].Value, (int)cboempresa.SelectedValue, (int)item.Cells[xTipo.Name].Value,
                                        ParcialSoles, ParcialDolares, TipoPago, TipoPago == 0 ? "" : HPResergerFunciones.Utilitarios.ExtraerCuenta(cbocuentabanco.Text), txtnrooperacion.TextValido(),
                                        $"{Configuraciones.MayusculaCadaPalabra(NameEmpleado)} {dtpFechaCompensa.Value.ToString("d")}", FechaCompensa, 1, Cuo);
                                    break;
                                }
                                else if (AcumuladoFacturas > 0)
                                {
                                    CapaLogica.ActualizarCompensaciones((int)cboempresa.SelectedValue, (int)item.Cells[xTipo.Name].Value, (int)item.Cells[xpkid.Name].Value, 1,
                                         TipoPago, TipoPago == 0 ? "" : HPResergerFunciones.Utilitarios.ExtraerCuenta(cbocuentabanco.Text), txtnrooperacion.TextValido(), Cuo);
                                    //Continua..
                                }
                            }
                        }
                    }
                    //Fin de Pago Parcial 
                }
                //Entrada -+- Salida de Dinero(Bancos)
                //if (ImporteTotal != 0 && cbotipo.Text != "000 Ninguno.")
                if (ImporteTotal != 0 && TipoPago != 0)
                {
                    string CuentaContable = ""; string nroKuenta = "";
                    if (cbocuentabanco.SelectedValue == null) CuentaContable = ""; else CuentaContable = cbocuentabanco.SelectedValue.ToString();
                    if (cbocuentabanco.SelectedValue != null)
                        nroKuenta = HPResergerFunciones.Utilitarios.ExtraerCuenta(cbocuentabanco.Text);
                    decimal MontoSoles = Configuraciones.Redondear(moneda == 1 ? ImporteTotal : ImporteTotal * tc);
                    decimal MontoDolares = Configuraciones.Redondear(moneda == 2 ? ImporteTotal : ImporteTotal / tc);
                    decimal TC = tc;
                    string[] NumFac = $"0-ER{FechaCompensa.ToString(Configuraciones.ddMMyy)}".Split('-');
                    int idfac = 0;
                    //Salida o Entrada de Dinero
                    //Salido = positiva = Otras cuentas x Pagar
                    //Entrada= Negativa= Banco en Positivo
                    decimal ImporteAbonar = decimal.Parse(txtPorAbonar.Text);
                    decimal Factor = MontoSoles / MontoDolares;
                    decimal AbonarSoles = Configuraciones.Redondear(moneda == 1 ? ImporteAbonar : ImporteAbonar * Factor);
                    decimal AbonarDolares = Configuraciones.Redondear(moneda == 2 ? ImporteAbonar : ImporteAbonar / Factor);
                    //Salida de Dinero
                    if (ImporteTotal > 0)
                    {
                        string OtrasCuentas = cbocuentaxpagar.SelectedValue.ToString();
                        //Asiento Cabecera
                        CapaLogica.InsertarAsientoFacturaCabecera(1, ++PosFila, numasiento, FechaContable, OtrasCuentas
                               , Math.Abs(ImporteTotal < 0 ? moneda == 1 ? AbonarSoles : AbonarDolares : 0)
                               , Math.Abs(ImporteTotal > 0 ? moneda == 1 ? AbonarSoles : AbonarDolares : 0)
                               , tc, proyecto, 0, Cuo, moneda, glosa, FechaCompensa, -15);
                        //Detalle del asiento
                        CapaLogica.InsertarAsientoFacturaDetalle(10, PosFila, numasiento, FechaContable, OtrasCuentas, proyecto, TipoIdProveedor, NumDocEmpleado
                            , NameEmpleado, idfac, NumFac[0], NumFac[1], 0, FechaContable, FechaCompensa, FechaCompensa, Math.Abs(AbonarSoles), Math.Abs(AbonarDolares), TC, moneda, ""
                            , "", glosa, FechaCompensa, idUsuario, "");
                    }
                    //Entrada de Dinero                   
                    else if (ImporteTotal < 0)
                    {
                        //Asiento Cabecera
                        CapaLogica.InsertarAsientoFacturaCabecera(1, ++PosFila, numasiento, FechaContable, CuentaCtaBanco
                               , Math.Abs(ImporteTotal < 0 ? moneda == 1 ? AbonarSoles : AbonarDolares : 0)
                               , Math.Abs(ImporteTotal > 0 ? moneda == 1 ? AbonarSoles : AbonarDolares : 0)
                               , tc, proyecto, 0, Cuo, moneda, glosa, FechaCompensa, -15);
                        //Detalle del asiento
                        CapaLogica.InsertarAsientoFacturaDetalle(10, PosFila, numasiento, FechaContable, CuentaCtaBanco, proyecto, TipoIdProveedor, NumDocEmpleado
                            , NameEmpleado, idfac, NumFac[0], NumFac[1], 0, FechaContable, FechaCompensa, FechaCompensa, Math.Abs(AbonarSoles), Math.Abs(AbonarDolares), TC, moneda, nroKuenta
                            , NroOperacion, glosa, FechaCompensa, idUsuario, "", TipoPago);
                    }
                }
                //Cuadre Asiento
                CapaLogica.CuadrarAsiento(Cuo, proyecto, FechaContable, 2);
                //Fin Cuadre
                string cadena = "";
                //SIGUIENTE ASIENTO DE LA SALIDA DE DINERO
                if (ImporteTotal > 0 && TipoPago != 0)
                {
                    numasiento = 0;
                    if (numasiento == 0)
                    {
                        DataTable asientito = CapaLogica.UltimoAsiento((int)cboempresa.SelectedValue, FechaContable);
                        DataRow asiento = asientito.Rows[0];
                        if (asiento == null) { numasiento = 1; }
                        else
                            numasiento = ((int)asiento["codigo"]);
                    }
                    PosFila = 0;
                    string CuoNext = HPResergerFunciones.Utilitarios.Cuo(numasiento, FechaContable);
                    ////Segundo Asiento Del Pago.
                    string CuentaContable = ""; string nroKuenta = "";
                    if (cbocuentabanco.SelectedValue == null) CuentaContable = ""; else CuentaContable = cbocuentabanco.SelectedValue.ToString();
                    if (cbocuentabanco.SelectedValue != null)
                        nroKuenta = HPResergerFunciones.Utilitarios.ExtraerCuenta(cbocuentabanco.Text);
                    decimal MontoSoles = Configuraciones.Redondear(moneda == 1 ? ImporteTotal : ImporteTotal * tc);
                    decimal MontoDolares = Configuraciones.Redondear(moneda == 2 ? ImporteTotal : ImporteTotal / tc);
                    decimal TC = tc;
                    string[] NumFac = $"0-ER{FechaCompensa.ToString(Configuraciones.ddMMyy)}".Split('-');
                    int idfac = 0;
                    //Salida o Entrada de Dinero
                    //Salido = positiva = Otras cuentas x Pagar
                    //Entrada= Negativa= Banco en Positivo
                    decimal ImporteAbonar = decimal.Parse(txtPorAbonar.Text);
                    decimal Factor = MontoSoles / MontoDolares;
                    decimal AbonarSoles = Configuraciones.Redondear(moneda == 1 ? ImporteAbonar : ImporteAbonar * Factor);
                    decimal AbonarDolares = Configuraciones.Redondear(moneda == 2 ? ImporteAbonar : ImporteAbonar / Factor);
                    string OtrasCuentas = cbocuentaxpagar.SelectedValue.ToString();
                    //DEBE
                    //Asiento Cabecera 
                    CapaLogica.InsertarAsientoFacturaCabecera(1, ++PosFila, numasiento, FechaContable, OtrasCuentas
                           , Math.Abs(ImporteTotal > 0 ? moneda == 1 ? AbonarSoles : AbonarDolares : 0)
                           , Math.Abs(ImporteTotal < 0 ? moneda == 1 ? AbonarSoles : AbonarDolares : 0)
                           , tc, proyecto, 0, CuoNext, moneda, glosa, FechaCompensa, -15);
                    //Detalle del asiento
                    CapaLogica.InsertarAsientoFacturaDetalle(10, PosFila, numasiento, FechaContable, OtrasCuentas, proyecto, TipoIdProveedor, NumDocEmpleado
                        , NameEmpleado, idfac, NumFac[0], NumFac[1], 0, FechaContable, FechaCompensa, FechaCompensa, Math.Abs(AbonarSoles), Math.Abs(AbonarDolares), TC, moneda, ""
                        , "", glosa, FechaCompensa, idUsuario, Cuo);
                    //HABER
                    //Asiento Cabecera
                    CapaLogica.InsertarAsientoFacturaCabecera(1, ++PosFila, numasiento, FechaContable, CuentaCtaBanco
                           , Math.Abs(ImporteTotal < 0 ? moneda == 1 ? AbonarSoles : AbonarDolares : 0)
                           , Math.Abs(ImporteTotal > 0 ? moneda == 1 ? AbonarSoles : AbonarDolares : 0)
                           , tc, proyecto, 0, CuoNext, moneda, glosa, FechaCompensa, -15);
                    //Detalle del asiento
                    CapaLogica.InsertarAsientoFacturaDetalle(10, PosFila, numasiento, FechaContable, CuentaCtaBanco, proyecto, TipoIdProveedor, NumDocEmpleado
                        , NameEmpleado, idfac, NumFac[0], NumFac[1], 0, FechaContable, FechaCompensa, FechaCompensa, Math.Abs(AbonarSoles), Math.Abs(AbonarDolares), TC, moneda, nroKuenta
                        , NroOperacion, glosa, FechaCompensa, idUsuario, Cuo, TipoPago);
                    //Cuadre Asiento
                    CapaLogica.CuadrarAsiento(CuoNext, proyecto, FechaContable, 2);
                    cadena = $"\nSe Aplico el Pago con Cuo{ CuoNext}";
                    //Fin Cuadre                 
                }
                else if (ImporteTotal > 0 && TipoPago == 0)
                {
                    string CuentaContable = ""; string nroKuenta = "";
                    if (cbocuentabanco.SelectedValue == null) CuentaContable = ""; else CuentaContable = cbocuentabanco.SelectedValue.ToString();
                    if (cbocuentabanco.SelectedValue != null)
                        nroKuenta = HPResergerFunciones.Utilitarios.ExtraerCuenta(cbocuentabanco.Text);
                    decimal MontoSoles = Configuraciones.Redondear(moneda == 1 ? ImporteTotal : ImporteTotal * tc);
                    decimal MontoDolares = Configuraciones.Redondear(moneda == 2 ? ImporteTotal : ImporteTotal / tc);
                    decimal TC = tc;
                    string[] NumFac = $"0-ER{FechaCompensa.ToString(Configuraciones.ddMMyy)}".Split('-');
                    int idfac = 0;
                    //Salida o Entrada de Dinero
                    //Salido = positiva = Otras cuentas x Pagar
                    //Entrada= Negativa= Banco en Positivo
                    decimal ImporteAbonar = decimal.Parse(txtPorAbonar.Text);
                    decimal Factor = MontoSoles / MontoDolares;
                    decimal AbonarSoles = Configuraciones.Redondear(moneda == 1 ? ImporteAbonar : ImporteAbonar * Factor);
                    decimal AbonarDolares = Configuraciones.Redondear(moneda == 2 ? ImporteAbonar : ImporteAbonar / Factor);
                    string OtrasCuentas = cbocuentaxpagar.SelectedValue.ToString();
                    //DEBE
                    //Asiento Cabecera 
                    CapaLogica.InsertarAsientoFacturaCabecera(1, ++PosFila, numasiento, FechaContable, OtrasCuentas
                           , Math.Abs(ImporteTotal < 0 ? moneda == 1 ? AbonarSoles : AbonarDolares : 0)
                           , Math.Abs(ImporteTotal > 0 ? moneda == 1 ? AbonarSoles : AbonarDolares : 0)
                           , tc, proyecto, 0, Cuo, moneda, glosa, FechaCompensa, -15);
                    //Detalle del asiento
                    CapaLogica.InsertarAsientoFacturaDetalle(10, PosFila, numasiento, FechaContable, OtrasCuentas, proyecto, TipoIdProveedor, NumDocEmpleado
                        , NameEmpleado, idfac, NumFac[0], NumFac[1], 0, FechaContable, FechaCompensa, FechaCompensa, Math.Abs(AbonarSoles), Math.Abs(AbonarDolares), TC, moneda, ""
                        , "", glosa, FechaCompensa, idUsuario, Cuo);
                    ////HABER
                    ////Asiento Cabecera
                    //CapaLogica.InsertarAsientoFacturaCabecera(1, ++PosFila, numasiento, FechaContable, CuentaCtaBanco
                    //       , Math.Abs(ImporteTotal < 0 ? moneda == 1 ? AbonarSoles : AbonarDolares : 0)
                    //       , Math.Abs(ImporteTotal > 0 ? moneda == 1 ? AbonarSoles : AbonarDolares : 0)
                    //       , tc, proyecto, 0, Cuo, moneda, glosa, FechaCompensa, -15);
                    ////Detalle del asiento
                    //CapaLogica.InsertarAsientoFacturaDetalle(10, PosFila, numasiento, FechaContable, CuentaCtaBanco, proyecto, TipoIdProveedor, NumDocEmpleado
                    //    , NameEmpleado, idfac, NumFac[0], NumFac[1], 0, FechaContable, FechaCompensa, FechaCompensa, Math.Abs(AbonarSoles), Math.Abs(AbonarDolares), TC, moneda, nroKuenta
                    //    , NroOperacion, glosa, FechaCompensa, idUsuario, Cuo, TipoPago);
                    ////Cuadre Asiento
                    CapaLogica.CuadrarAsiento(Cuo, proyecto, FechaContable, 2);
                    //cadena = $"\nSe Aplico el Pago con Cuo{ CuoNext}";
                    //Fin Cuadre   
                }
                msgOK($"Se Aplicó la Entrega a Rendir con Cuo {Cuo} {(cadena != "" ? cadena : "")}");
                cbotipo.SelectedValue = 3;
                cboempleado_SelectedIndexChanged(sender, e);
            }
        }

    }
}
