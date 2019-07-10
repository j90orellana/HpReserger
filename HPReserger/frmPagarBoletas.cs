using HpResergerUserControls;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
namespace HPReserger
{
    public partial class frmPagarBoletas : FormGradient
    {
        public frmPagarBoletas()
        {
            InitializeComponent();

        }
        HPResergerCapaLogica.HPResergerCL Capalogica = new HPResergerCapaLogica.HPResergerCL();

        private void frmPagarBoletas_Load(object sender, EventArgs e)
        {
            txtruc_TextChanged(sender, e);
            //ESTO DAÑADA LA PRESENTACION DE LA FECHA MODIFICA DE 21/07/2017 A 07/21/2017 POR EL CAMBIO DE CULTURA
            //Application.CurrentCulture = System.Globalization.CultureInfo.CreateSpecificCulture("EN-US");
            // txtruc.Text = "0701046971";
            //    radioButton1.Checked = true;
            txtbuscar_TextChanged(sender, e);

            DataRow Filita = Capalogica.VerUltimoIdentificador("TBL_Factura", "Nro_DocPago");
            if (Filita != null)
                txtnropago.Text = (decimal.Parse(Filita["ultimo"].ToString()) + 1).ToString();
            else txtnropago.Text = "1";
            CargarTiposID("TBL_Tipo_ID");
            cargarempresas();
            cbotipo.SelectedIndex = 0;
        }
        public void cargarempresas()
        {
            cboempresa.ValueMember = "codigo";
            cboempresa.DisplayMember = "descripcion";
            cboempresa.DataSource = Capalogica.getCargoTipoContratacion("Id_empresa", "empresa", "tbl_empresa");
        }
        private void txtruc_TextChanged(object sender, EventArgs e)
        {
            //if (txtruc.Text.Length > 9)
            //{
            //    cbotipo.Enabled = true; cbobanco.Enabled = true; cbocuentabanco.Enabled = true;
            //    cbotipo.SelectedIndex = 0; txtnropago.Enabled = true;
            //}
            //else
            //{
            //    cbotipo.Enabled = false; cbobanco.Enabled = false; cbocuentabanco.Enabled = false; txtnropago.Enabled = false; txtnropago.Text = "";
            //}
            //DataRow razonsocial = cPagarfactura.RUCProveedor(txtruc.Text);
            //if (razonsocial != null)
            //{
            //    txtRazonSocial.Text = razonsocial["razon_social"].ToString();
            //    txtdireccion.Text = razonsocial["direccion_oficina"].ToString();
            //    txtTelefono.Text = razonsocial["telefono_oficina"].ToString();
            //    //cargarguias(txtguia);//txtguia_TextChanged(sender, e);
            //    Dtguias.DataSource = cPagarfactura.ListarFacturasPorPagar(0, "", 0, DateTime.Now, DateTime.Now, 0, DateTime.Now, DateTime.Now);
            //}
            //else
            //{
            //    txtRazonSocial.Text = txtdireccion.Text = txtTelefono.Text = "";
            //    // chlbx.Items.Clear();
            //    //Dtguias.Refresh();
            //    // DtgConten.Refresh();
            //}
        }
        DataTable BoletasPorPagar = new DataTable();
        private void btngenerar_Click(object sender, EventArgs e)
        {
            DateTime inicio, fin;
            if (comboMesAño1.GetFechaPRimerDia() > comboMesAño2.GetFechaPRimerDia())
            {
                inicio = comboMesAño2.GetFechaPRimerDia();
                fin = comboMesAño1.GetFechaPRimerDia();
            }
            else
            {
                inicio = comboMesAño1.GetFechaPRimerDia();
                fin = comboMesAño2.GetFechaPRimerDia();
            }
            BoletasPorPagar = Capalogica.BuscarBoletasPOrPAgar(EMPRESA, TIPO, txtnumero.Text, FECHA, inicio, fin);
            dtgconten.DataSource = BoletasPorPagar;
            lblmensaje.Text = $"Número de Registros= {dtgconten.RowCount} Seleccionados= {Comprobantes.Count}";
            PintardeCOloresSinCuenta();
        }
        public void PintardeCOloresSinCuenta()
        {
            foreach (DataGridViewRow fila in dtgconten.Rows)
            {
                if (fila.Cells[CuentaBanco.Name].Value.ToString() == "NO")
                {
                    fila.DefaultCellStyle.ForeColor = Color.Red;
                    fila.DefaultCellStyle.SelectionForeColor = Color.Red;
                }
            }
        }
        private void txtbuscar_TextChanged(object sender, EventArgs e)
        {
            //if (dtfin.Value < dtinicio.Value)
            //{
            //    auxtmp = dtfin.Value;
            //    dtfin.Value = dtinicio.Value;
            //    dtinicio.Value = auxtmp;
            //}
            //if (dtpfin.Value < dtpini.Value)
            //{
            //    auxtmp = dtpfin.Value;
            //    dtpfin.Value = dtpini.Value;
            //    dtpini.Value = auxtmp;
            //}
            //Dtguias.DataSource = cPagarfactura.ListarFacturasPorPagar(prove, txtbuscar.Text, fecha, dtinicio.Value, dtfin.Value, recepcion, dtpini.Value, dtpfin.Value);
            //cbotipo.SelectedIndex = 0;
            //txttotaldetrac.Text = txttotal.Text = "0.00";
            //btnaceptar.Enabled = false;
            //FacturasSeleccionas();
            //CalcularTotal();
        }
        private void cbotipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbotipo.SelectedIndex == 0 || cbotipo.SelectedIndex == 1)
            {
                cbobanco.Visible = lblguia1.Visible = lblguia.Visible = cbocuentabanco.Visible = true;
                lblguia.Text = "Banco";
                cbobanco.ValueMember = "codigo";
                cbobanco.DisplayMember = "descripcion";
                cbobanco.DataSource = Capalogica.getCargoTipoContratacion("Sufijo", "Entidad_Financiera", "TBL_Entidad_Financiera");
            }
            else
            {
                cbobanco.Visible = lblguia1.Visible = lblguia.Visible = cbocuentabanco.Visible = false;
            }
        }
        private void cbobanco_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbobanco.SelectedIndex >= 0)
            {
                cbocuentabanco.Text = "";
                CargarCuentasBancos();
            }
        }
        public void CargarCuentasBancos()
        {
            if (cbobanco.SelectedValue != null && cbobanco.SelectedValue != null)
            {
                cbocuentabanco.ValueMember = "Id_Cuenta_Contable";
                cbocuentabanco.DisplayMember = "banco";
                cbocuentabanco.DataSource = Capalogica.ListarBancosTiposdePagoxEmpresa(cbobanco.SelectedValue.ToString(), (int)cboempresa.SelectedValue, 0);
            }
        }
        private void btnActualizar_Click(object sender, EventArgs e)
        {
            txtbuscar_TextChanged(sender, e);
        }
        int EMPRESA = 0;
        private void cboempresa_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboempresa.Items.Count > 0)
            {
                EMPRESA = (int)cboempresa.SelectedValue;
                CargarCuentasBancos();
            }
        }
        int TIPO = 0;
        private void cbotipoid_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
                TIPO = (int)cbotipoid.SelectedValue;
            else { TIPO = 0; }
        }
        private void chkempresa_CheckedChanged(object sender, EventArgs e)
        {
            if (!chkempresa.Checked)
            {
                cboempresa.Enabled = false;
                btnrecempresa.Enabled = false;
                EMPRESA = 0;
            }
            else
            {
                cboempresa.Enabled = true;
                btnrecempresa.Enabled = true;
                EMPRESA = (int)cboempresa.SelectedValue;
            }
        }
        int FECHA = 0;
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                comboMesAño1.Enabled = comboMesAño2.Enabled = true;
                FECHA = 1;
            }
            else
            {
                comboMesAño1.Enabled = comboMesAño2.Enabled = false;
                FECHA = 0;
            }
        }
        DataTable TablaTipoID;
        public void CargarTiposID(string tabla)
        {
            TablaTipoID = new DataTable();
            TablaTipoID = Capalogica.CualquierTabla(tabla, "Desc_Tipo_ID", "RUC");
            cbotipoid.DisplayMember = "Desc_Tipo_ID";
            cbotipoid.ValueMember = "Codigo_Tipo_ID";
            cbotipoid.DataSource = TablaTipoID;
        }
        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                TIPO = (int)cbotipoid.SelectedValue;
                cbotipoid.Enabled = txtnumero.Enabled = true;
            }
            else
            {
                cbotipoid.Enabled = txtnumero.Enabled = false;
                TIPO = 0;
            }
        }
        private void btnseleccion_Click(object sender, EventArgs e)
        {
            dtgconten.EndEdit();
            if (dtgconten.RowCount > 0)
            {
                Boolean estado = false;
                if (dtgconten["ok", 0].Value == null)
                    estado = false;
                else
                    estado = Boolean.Parse(dtgconten["ok", 0].Value.ToString());
                int y = 0;
                foreach (DataGridViewRow xx in dtgconten.Rows)
                {
                    xx.Cells["ok"].Value = !estado;
                    dtgconten_CellContentClick(sender, new DataGridViewCellEventArgs(0, y));
                    y++;
                }
                if (!estado)
                    btnseleccion.Text = "Deseleccionar  Todos";
                else
                    btnseleccion.Text = "Seleccionar Todos";
            }
        }
        public class FACTURAS
        {
            public string mes { get; set; }
            public int año { get; set; }
            public string tipo { get; set; }
            public string nro { get; set; }
            public decimal neto { get; set; }
            public DateTime fecha { get; set; }
            public FACTURAS(string _mes, int _año, string _tipo, string _nro, decimal _neto, DateTime _fecha)
            {
                mes = _mes;
                año = _año;
                tipo = _tipo;
                nro = _nro;
                neto = _neto;
                fecha = _fecha;
            }
        }
        List<FACTURAS> Comprobantes = new List<FACTURAS>();
        private void dtgconten_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dtgconten.EndEdit();
            int x = e.RowIndex;
            try
            {
                if (e.RowIndex >= 0 && e.ColumnIndex == 0)
                {
                    if (dtgconten["ok", e.RowIndex].Value.ToString() == "True")
                    {
                        //msg("Contains= " + Comprobantes.Contains(new FACTURAS(Dtguias["nrofactura", e.RowIndex].Value.ToString().TrimStart().TrimEnd(), Dtguias["proveedor", e.RowIndex].Value.ToString().TrimStart().TrimEnd())));
                        Boolean Busqueda = false;
                        foreach (FACTURAS xfac in Comprobantes)
                        {
                            if (xfac.mes == dtgconten[mes.Name, x].Value.ToString().TrimStart().TrimEnd() && xfac.año == (int)dtgconten[año.Name, x].Value
                                && xfac.tipo == dtgconten[tipoid.Name, x].Value.ToString().TrimStart().TrimEnd() && xfac.nro == dtgconten[doc.Name, x].Value.ToString().TrimStart().TrimEnd())
                                Busqueda = true;
                        }
                        if (!Busqueda)
                            Comprobantes.Add(new FACTURAS(dtgconten[mes.Name, x].Value.ToString().TrimStart().TrimEnd(), (int)dtgconten[año.Name, x].Value,
                                dtgconten[tipoid.Name, x].Value.ToString().TrimStart().TrimEnd(), dtgconten[doc.Name, x].Value.ToString().TrimStart().TrimEnd(), (decimal)dtgconten[TotalNeto.Name, x].Value, (DateTime)dtgconten[iniciomes.Name, x].Value));
                    }
                    else
                    {
                        Boolean Busqueda = false; int X = 0, Y = 0;
                        foreach (FACTURAS xfac in Comprobantes)
                        {
                            if (xfac.mes == dtgconten[mes.Name, x].Value.ToString().TrimStart().TrimEnd() && xfac.año == (int)dtgconten[año.Name, x].Value
                                 && xfac.tipo == dtgconten[tipoid.Name, x].Value.ToString().TrimStart().TrimEnd() && xfac.nro == dtgconten[doc.Name, x].Value.ToString().TrimStart().TrimEnd())
                            {
                                Busqueda = true; Y = X;
                            }
                            X++;
                        }
                        //FACTURAS cola = new FACTURAS(Dtguias["nrofactura", e.RowIndex].Value.ToString().TrimStart().TrimEnd(), Dtguias["proveedor", e.RowIndex].Value.ToString().TrimStart().TrimEnd());
                        //msg("" + Comprobantes.Exists(cust=>cust.numero==cola.numero&&cust.proveedor==cola.proveedor) + " Y=" + Y + " Contador=" + Comprobantes.Count);
                        if (Busqueda)
                            Comprobantes.RemoveAt(Y);
                    }
                }
                //else
            }
            catch { }
            CalcularTotal();
        }
        private void CalcularTotal()
        {
            decimal Total = 0;
            foreach (FACTURAS fac in Comprobantes)
            {
                Total += fac.neto;
            }
            txttotal.Text = Total.ToString("n2");
            lblmensaje.Text = $"Número de Registros= {dtgconten.RowCount} Seleccionados= {Comprobantes.Count}";
            if (Comprobantes.Count > 0) btnaceptar.Enabled = true; else btnaceptar.Enabled = false;
        }
        List<string> Proveedores = new List<string>();
        public Boolean PasoFactura = false;
        DialogResult PAsoBancos = DialogResult.Cancel;
        DataTable TablaConsulta = new DataTable();
        private void btnaceptar_Click(object sender, EventArgs e)
        {
            if (Comprobantes.Count > 0)
            {
                ///selecione minimo una boleta
                if (cbobanco.Items.Count == 0)
                {
                    msg("No hay Bancos");
                    cbobanco.Focus();
                    return;
                }
                if (cbocuentabanco.Items.Count == 0)
                {
                    msg("El Banco Seleccionado No tiene Cuenta");
                    cbobanco.Focus();
                    return;
                }
                if (txttotal.Text.Length > 0)
                {
                    if (decimal.Parse(txttotal.Text) == 0)
                    {
                        msg("El total a pagar no puede ser Cero");
                        dtgconten.Focus();
                        return;
                    }
                }
                //proceso de calculos
                Boolean GenerarTxt = false;
                DialogResult ResultadoDialogo = HPResergerFunciones.Utilitarios.msgYesNoCancel("Desea Generar TXT del pago?");
                if (ResultadoDialogo == DialogResult.Yes)
                {
                    GenerarTxt = false;
                    ///Verificar si el esta el Generador de txt de ese banco 
                    string bancox = cbobanco.SelectedValue.ToString().Trim();
                    if (bancox == "CREDITO" || bancox == "INTERBANK" || bancox == "BIF")
                    {
                        //bancos que generan el txt bcp ibk bif
                        GenerarTxt = true;
                    }
                    else
                    {
                        if (HPResergerFunciones.Utilitarios.msgOkCancel("El Banco Seleccionado no tiene para exportar a TXT, Desea Continuar?") == DialogResult.OK)
                        {
                            GenerarTxt = false;
                        }
                        else
                            return;
                    }
                }
                if (ResultadoDialogo == DialogResult.No)
                {
                    GenerarTxt = false;
                    //msg("selecciones no en generar txt");
                }
                if (ResultadoDialogo == DialogResult.Cancel)
                    return;
                if (GenerarTxt)
                {
                    dtgconten.EndEdit();
                    Proveedores.Clear();
                    foreach (FACTURAS cadena in Comprobantes)
                        Proveedores.Add(cadena.tipo + cadena.nro);
                    //ventanas de seleccion para generar txt
                    // frmCargaDatosProveedor frmcargardatosproveedor = new frmCargaDatosProveedor();
                    //frmcargardatosproveedor.Proveedores = Proveedores.Distinct().ToList<string>();
                    //frmcargardatosproveedor.banco = cbobanco.SelectedValue.ToString();
                    //frmcargardatosproveedor.txtbanco.Text = cbobanco.Text;
                    //frmcargardatosproveedor.cuenta = cbocuentabanco.Text;
                    //frmcargardatosproveedor.Boletas = true;
                    //if (frmcargardatosproveedor.ShowDialog() == DialogResult.Cancel || frmcargardatosproveedor.Resultado == DialogResult.Cancel)
                    //    return;
                    //msg("vamos a pagar la factura");
                    string cuentax = HPResergerFunciones.Utilitarios.ExtraerCuenta(cbocuentabanco.Text);
                    DataTable TablaCuentas = new DataTable();
                    string consulta = string.Join(",", Proveedores);
                    TablaCuentas = Capalogica.BuscarCuentasBancoPagarBoletas(cbobanco.SelectedValue.ToString(), consulta);
                    PasoFactura = false;
                    if (cbobanco.SelectedValue.ToString().ToUpper().Trim() == "CREDITO")
                    {
                        //Abrimos eL formulario del banco de credito
                        //msg("FORMULARIO DEL BCP");
                        frmBancoBcp bancobcp = new frmBancoBcp();
                        bancobcp.TablaProveedorBanco = TablaCuentas;// frmcargardatosproveedor.TablaProvedoresBancos;
                        //bancointerbank.TablaComprobantes = ((DataTable)Dtguias.DataSource).Clone();
                        //msg("Cuenta Filas " + bancointerbank.TablaComprobantes.Rows.Count);
                        bancobcp.txtcuentapago.Text = cuentax;
                        bancobcp.Icon = Icon;
                        bancobcp.PAgoFactura = true;
                        bancobcp.ComprobanteS = Comprobantes;
                        bancobcp.ShowDialog();
                        PAsoBancos = bancobcp.DialogResult;
                        TablaConsulta = bancobcp.TablaConsulta;
                    }
                    if (cbobanco.SelectedValue.ToString().ToUpper().Trim() == "INTERBANK")
                    {
                        //abrimos el formulario del banco interbank
                        // msg("FORMULARIO DEL IBK");
                        frmBancoInterbank bancointerbank = new frmBancoInterbank();
                        bancointerbank.TablaProveedorBanco = TablaCuentas;// frmcargardatosproveedor.TablaProvedoresBancos;
                        //bancointerbank.TablaComprobantes = ((DataTable)Dtguias.DataSource).Clone();
                        //msg("Cuenta Filas " + bancointerbank.TablaComprobantes.Rows.Count);
                        bancointerbank.txtcuenta.Text = cuentax;
                        bancointerbank.ComprobanteS = Comprobantes;
                        bancointerbank.PAgoFactura = true;
                        bancointerbank.Icon = Icon;
                        bancointerbank.ShowDialog();
                        PAsoBancos = bancointerbank.DialogResult;
                        TablaConsulta = bancointerbank.TablaConsulta;
                    }
                    if (cbobanco.SelectedValue.ToString().ToUpper().Trim() == "BIF")
                    {
                        //abrimso el formulario del banco interarmericano de finanzas
                        //  msg("FORMULARIO DEL BIF");
                        frmBancoInterAmericano bancointeramericano = new frmBancoInterAmericano();
                        bancointeramericano.TablaProveedorBanco = TablaCuentas;// frmcargardatosproveedor.TablaProvedoresBancos;
                        //bancointerbank.TablaComprobantes = ((DataTable)Dtguias.DataSource).Clone();
                        //msg("Cuenta Filas " + bancointerbank.TablaComprobantes.Rows.Count);
                        bancointeramericano.txtcuenta.Text = cuentax;
                        bancointeramericano.ComprobanteS = Comprobantes;
                        bancointeramericano.PAgoFactura = true;
                        bancointeramericano.Icon = Icon;
                        bancointeramericano.ShowDialog();
                        TablaConsulta = bancointeramericano.TablaConsulta;
                        PAsoBancos = bancointeramericano.DialogResult;
                    }
                }
                if (GenerarTxt && PAsoBancos == DialogResult.OK)
                {
                    //Si se Generó el TXT Saco la tabla de los formularios
                    if (TablaConsulta.Rows.Count > 0)
                    {
                        foreach (DataRow filita in TablaConsulta.Rows)
                        {
                            Capalogica.ActualizarBoletas(int.Parse(filita["tipodoc"].ToString()), (string)filita["nrodoc"], (DateTime)filita["fecha"], 2);
                        }
                        msg("Boletas Pagadas!");
                    }
                }
                if (ResultadoDialogo == DialogResult.No)
                {
                    //si seleccion no Generar el txt y seguir
                    if (Comprobantes.Count > 0)
                    {
                        foreach (FACTURAS filita in Comprobantes)
                        {
                            Capalogica.ActualizarBoletas(int.Parse(filita.tipo), filita.nro, filita.fecha, 2);
                        }
                        msg("Boletas Pagadas!");
                    }
                }
                Comprobantes.Clear();
                btngenerar_Click(sender, e);
            }
            else
            {
                msg("Seleccioné mínimo una Boleta");
            }
        }
        public void msg(string cadena)
        {
            HPResergerFunciones.Utilitarios.msg(cadena);
        }
        public DialogResult msgM(string cadena)
        {
            return HPResergerFunciones.Utilitarios.msgOkCancel(cadena);
        }
        private void btncancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void dtgconten_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            lblmensaje.Text = $"Número de Registros= {dtgconten.RowCount} Seleccionados= {Comprobantes.Count}";
        }
        private void dtgconten_Sorted(object sender, EventArgs e)
        {
            PintardeCOloresSinCuenta();
        }
        private void cboempresa_Click(object sender, EventArgs e)
        {
            string cadena = cboempresa.Text;
            Capalogica.TablaEmpresas(cboempresa);
            cboempresa.Text = cadena;
        }
        private void cbobanco_Click(object sender, EventArgs e)
        {
            string cadena = cbobanco.Text;
            cbobanco.ValueMember = "codigo";
            cbobanco.DisplayMember = "descripcion";
            cbobanco.DataSource = Capalogica.getCargoTipoContratacion("Sufijo", "Entidad_Financiera", "TBL_Entidad_Financiera");
            cbobanco.Text = cadena;
        }
    }
}