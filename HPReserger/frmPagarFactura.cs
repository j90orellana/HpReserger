﻿using HpResergerUserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HPReserger
{
    public partial class frmPagarFactura : FormGradient
    {
        public frmPagarFactura()
        {
            CartelDeEspera("Cargando...");
            Application.DoEvents();
            InitializeComponent();
        }
        public void CartelDeEspera(string Texto)
        {
            frmproce = new frmProcesando(Texto);
            frmproce.Show();
        }
        public void CartelDeEspera()
        {
            frmproce = new frmProcesando("Cargando...");
            frmproce.Show();
        }
        HPResergerCapaLogica.HPResergerCL CapaLogica = new HPResergerCapaLogica.HPResergerCL();
        private string _NameEmpresa;
        public string NameEmpresa
        {
            get { return _NameEmpresa; }
            set
            {
                if (value != NameEmpresa)
                    Comprobantes.Clear();
                _NameEmpresa = value;
            }
        }
        DataTable TablaPagados;
        DataTable TablaPorPagar;
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
            //DataRow razonsocial = CapaLogica.RUCProveedor(txtruc.Text);
            //if (razonsocial != null)
            //{
            //    //txtRazonSocial.Text = razonsocial["razon_social"].ToString();
            //    //txtdireccion.Text = razonsocial["direccion_oficina"].ToString();
            //    //txtTelefono.Text = razonsocial["telefono_oficina"].ToString();
            //    //cargarguias(txtguia);//txtguia_TextChanged(sender, e);
            //    Dtguias.DataSource = CapaLogica.ListarFacturasPorPagarxEmpresa(0, "", 0, DateTime.Now, DateTime.Now, 0, DateTime.Now, DateTime.Now, 0, (int)cboempresa.SelectedValue);
            //}
            //else
            //{
            //    txtRazonSocial.Text = txtdireccion.Text = txtTelefono.Text = "";
            //    // chlbx.Items.Clear();
            //    //Dtguias.Refresh();
            //    // DtgConten.Refresh();
            //}
        }
        public void ActualizarTablas()
        {
            TablaPorPagar = CapaLogica.ListarFacturasPorPagarxEmpresa(0, txtbuscar.Text, 0, dtinicio.Value, dtfin.Value, 0, dtpini.Value, dtpfin.Value, 0, (int)cboempresa.SelectedValue);
            //TablaPagados = CapaLogica.ListarFacturasPagadosxEmpresa(0, txtbuscar.Text, 0, dtinicio.Value, dtfin.Value, 0, dtpini.Value, dtpfin.Value, 0, (int)cboempresa.SelectedValue);
            if (rdbporPagar.Checked)
                Dtguias.DataSource = TablaPorPagar;
            else if (rdbPagados.Checked)
                Dtguias.DataSource = TablaPagados;
            ContarRegistros();
            frmproce.Close();
            //Filtros
            txtbuscar_TextChanged(new object(), new EventArgs());
        }
        private void frmPagarFactura_Load(object sender, EventArgs e)
        {
            cboempresa_Click_1(sender, e);
            DataRow Filita = CapaLogica.VerUltimoIdentificador("TBL_Factura", "Nro_DocPago");
            if (Filita != null)
                txtnropago.Text = (decimal.Parse(Filita["ultimo"].ToString()) + 1).ToString();
            else txtnropago.Text = "1";
            cbotipo.SelectedIndex = 0;
            dtpFechaContable.Value = dtpFechaPago.Value = DateTime.Now;
            txtglosa.CargarTextoporDefecto();
            ActualizarTablas();
            ContarRegistros();
            frmproce.Close();
            txtCuentaExceso.Text = "";
            txtCuentaExceso.CargarTextoporDefecto();
            //List<Persona> personas = new List<Persona>();
            //Persona person1 = new Persona(1, "jefferson", 27);
            //personas.Add(person1);
            //Persona person3 = new Persona(2, "cristina", 28);
            //personas.Add(person3);
            //Persona person2 = new Persona(1, "jefferson", 27);

            //string cadena = "";
            //foreach (Persona per in personas)
            //{
            //    cadena += $"codigo= {per.codigo} nombre={per.nombre} Edad={per.edad}\n";
            //}
            //MessageBox.Show($"{cadena} Prueba de contain={personas.Contains(person2)} Prueba de exists= {personas.Exists(cust => cust.codigo == 1 && cust.edad == 27 && cust.nombre == "jefferson")}");
            //Persona p = personas.Find(cust => cust.codigo == 1 && cust.edad == 27 && cust.nombre == "jefferson");
            //if (p != null)
            //    MessageBox.Show($"{p.codigo} {p.nombre} {p.edad}");
            //msg("Prueba de Any= " + personas.Any(cust => cust.edad >= 27));
            //Horas Horita = new Horas() { minutos = 10, segundos = 59 };
            //List<Horas> horas = new List<Horas>();
            //horas.Add(new Horas() { minutos = 19, segundos = 20 });
            //personas.RemoveAll(delegate (Persona pers) { return pers.codigo == 10; });
            //personas.RemoveAll(cust => cust.codigo == 10);
            //personas = (from Persona in personas where Persona.codigo != 10 select Persona).ToList<Persona>();

            //personas.RemoveAll(delegate (Persona persis) { return persis.codigo == 10; });
            //personas.RemoveAll(x => x.codigo == 10);
            //personas = (from x in personas where x.codigo != 10 select x).ToList<Persona>();

            //personas.RemoveAll(delegate (Persona peropero) { return peropero.codigo == 10; });

            //Point[] points = { new Point(100, 200),
            //             new Point(150, 250), new Point(250, 375),
            //             new Point(275, 395), new Point(295, 450) };

            //// Define the Predicate<T> delegate.
            //Predicate<Persona> predicate = BuscarPErsona;

            //// Find the first Point structure for which X times Y  
            //// is greater than 100000. 
            //Persona first = Array.Find(personas.ToArray(), predicate);

            //// Display the first structure found.
            //Console.WriteLine("Found: X = {0}, Y = {1}", first.codigo, first.nombre);

            //decimal persin = personas.Max(x => x.edad);
            ////List<Persona> PEr = (personas.FindAll(x => x.edad == persin));
            //List<Persona> PEr = (personas.FindAll(predicate));
            //string xcadena = "";
            //foreach (Persona px in PEr)
            //{
            //    xcadena += px.codigo + " " + px.nombre + px.edad + "\t";
            //}
            //msg("maxima edad" + persin + " " + xcadena);
        }
        private static Boolean BuscarPErsona(Persona obj)
        {
            return obj.edad > 10;
        }
        private static bool FindPoints(Point obj)
        {
            return obj.X * obj.Y > 100000;
        }
        public class Persona
        {
            public int codigo;
            public string nombre;
            public decimal edad;
            public Persona(int cod, string nom, decimal eda)
            {
                codigo = cod;
                nombre = nom;
                edad = eda;
            }
        }
        public class Horas
        {
            public int minutos;
            public int segundos;
        }
        string CodigoPago;
        private void cbotipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            CodigoPago = cbotipo.Text.Substring(0, 3);
            string[] ValoresBancoCheques = { "003", "007" };///003 Banco  /// 007 cheque
            if (ValoresBancoCheques.Contains(CodigoPago))
            {
                cbobanco.Visible = lblguia1.Visible = lblguia.Visible = cbocuentabanco.Visible = true;
                lblguia.Text = "Banco";
                cbobanco.ValueMember = "codigo";
                cbobanco.DisplayMember = "descripcion";
                cbobanco.DataSource = CapaLogica.getCargoTipoContratacion("Sufijo", "Entidad_Financiera", "TBL_Entidad_Financiera");
            }
            else
            {
                cbobanco.Visible = lblguia1.Visible = lblguia.Visible = cbocuentabanco.Visible = false;
            }
            if (CodigoPago == "007") { txtnrocheque.Visible = true; lblcheque.Visible = true; } else { txtnrocheque.Visible = false; lblcheque.Visible = false; }
        }
        private void cbobanco_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbobanco.SelectedIndex >= 0)
            {
                cbocuentabanco.Text = "";
                CargarCuentasBancos();
            }
        }
        private void cboempresa_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbobanco.SelectedValue != null)
            {
                CargarCuentasBancos();
                NameEmpresa = cboempresa.Text;
                CartelDeEspera("Cargando...");
                Application.DoEvents();
                ActualizarTablas();
                //btnaceptar.Enabled = true;                
                NameEmpresa = cboempresa.Text;
                if (cboempresa.Items.Count > 0)
                {
                    if (cboempresa.SelectedValue != null)
                    {
                        cboproyecto.DataSource = CapaLogica.ListarProyectosEmpresa(cboempresa.SelectedValue.ToString());
                        cboproyecto.DisplayMember = "proyecto";
                        cboproyecto.ValueMember = "id_proyecto";
                    }
                }
            }
        }
        public void CargarCuentasBancos()
        {
            if (cboempresa.SelectedValue != null && cbobanco.SelectedValue != null)
            {
                cbocuentabanco.ValueMember = "Id_Cuenta_Contable";
                cbocuentabanco.DisplayMember = "banco";
                cbocuentabanco.DataSource = CapaLogica.ListarBancosTiposdePagoxEmpresa(cbobanco.SelectedValue.ToString(), (int)cboempresa.SelectedValue, 0);
            }
        }
        private void cbobanco_Click(object sender, EventArgs e)
        {
            string cadenar = cbobanco.Text;
            cbobanco.ValueMember = "codigo";
            cbobanco.DisplayMember = "descripcion";
            cbobanco.DataSource = CapaLogica.getCargoTipoContratacion("Sufijo", "Entidad_Financiera", "TBL_Entidad_Financiera");
            cbobanco.Text = cadenar;
        }
        private void txtruc_KeyUp(object sender, KeyEventArgs e)
        {

        }
        private void txtruc_KeyPress(object sender, KeyPressEventArgs e)
        {
            HPResergerFunciones.Utilitarios.SoloNumerosEnteros(e);
        }
        private void txtruc_KeyDown(object sender, KeyEventArgs e)
        {
            //HPResergerFunciones.Utilitarios.Validardocumentos(e, txtruc, 11);
        }
        public void msg(string cadena)
        {
            HPResergerFunciones.Utilitarios.msg(cadena);
        }
        public DialogResult msgp(string cadena)
        {
            return HPResergerFunciones.Utilitarios.msgYesNo(cadena);
        }
        public DialogResult msgOkCancel(string cadena)
        {
            return HPResergerFunciones.Utilitarios.msgOkCancel(cadena);
        }
        DialogResult PAsoBanco = DialogResult.Cancel;
        public class NotaCreditoDebito
        {
            public Decimal Monto;
            public Decimal MontoNotas;
            public string Proveedor;
            public string RazonSocial;
            public Boolean Tomado;
            public int Moneda;
            public NotaCreditoDebito(string _proveedor, Decimal _monto, decimal _montonotas, string _razonsocial, int _moneda)
            {
                MontoNotas = _montonotas;
                Monto = _monto;
                Proveedor = _proveedor;
                RazonSocial = _razonsocial;
                Tomado = false;
                Moneda = _moneda;
            }
        }
        private void btnaceptar_Click(object sender, EventArgs e)
        {
            string TotalAux = txttotal.Text;
            chkprove.Checked = chkfecha.Checked = chkrecepcion.Checked = false;
            CalcularTotal();
            if (TotalAux != txttotal.Text) return;
            if (cbobanco.Items.Count == 0)
            {
                msg("No hay Bancos");
                cbobanco.Focus();
                return;
            }
            if (cboproyecto.SelectedValue == null)
            {
                msg("Seleccione Proyecto"); cboproyecto.Focus();
                return;
            }
            if (txttotal.Text != "0.00")
                if (cbocuentabanco.Items.Count == 0)
                {
                    msg("El Banco Seleccionado No tiene Cuenta");
                    cbobanco.Focus();
                    //if (MSG("Desea Continuar el Proceso de pago") != DialogResult.OK)
                    //{
                    return;
                    //}
                }
            //Valido Cuenta en Exceso
            if (!txtCuentaExceso.ReadOnly)
                if (!txtDescripcionCuentaExceso.EstaLLeno())
                {
                    msg("Ingrese La Cuenta Contable para El Exceso");
                    txtCuentaExceso.Focus(); return;
                }
            ////LISTADO DE NOTAS
            List<NotaCreditoDebito> ListadoNotas = new List<NotaCreditoDebito>();
            foreach (DataGridViewRow item in Dtguias.Rows)
            {
                string Tipos = item.Cells[tipodoc.Name].Value.ToString().Substring(0, 2);
                string Proveedor = item.Cells[proveedor.Name].Value.ToString();
                string RazonSocial = item.Cells[razon.Name].Value.ToString();
                decimal Monto = (decimal)item.Cells[Pagox.Name].Value;
                int Moneda = (int)item.Cells[xidmoneda.Name].Value;
                if (item.Cells[OK.Name].Value.ToString().ToUpper() == "TRUE")
                {
                    NotaCreditoDebito Notita = ListadoNotas.Find(cust => cust.Proveedor == Proveedor);
                    if (Notita == null)
                    {
                        if (Tipos == "ND")
                            ListadoNotas.Add(new NotaCreditoDebito(Proveedor, 0, Monto, RazonSocial, Moneda));
                        else if (Tipos == "NC")
                            ListadoNotas.Add(new NotaCreditoDebito(Proveedor, 0, -1 * Monto, RazonSocial, Moneda));
                        else
                            ListadoNotas.Add(new NotaCreditoDebito(Proveedor, Monto, 0, RazonSocial, Moneda));
                    }
                    else
                    {
                        if (Tipos == "ND") { Notita.MontoNotas += Monto; }
                        else if (Tipos == "NC") { Notita.MontoNotas -= Monto; }
                        else { Notita.Monto += Monto; }
                    }
                }
            }
            if (ListadoNotas.Count == 0)
                if (txttotal.Text.Length > 0)
                {
                    if (decimal.Parse(txttotal.Text) == 0)
                    {
                        msg("El total a pagar no puede ser Cero");
                        Dtguias.Focus();
                        return;
                    }
                }
                else
                {
                    msg("El Monto esta Vacío, Seleccioné una Fila de la grilla");
                    Dtguias.Focus();
                    return;
                }
            Boolean ErrorNotas = false, ErrorTotales = false;
            string Resultado = "Seleccione una Factura o Recibo para:";
            string Resultado2 = "El Monto abonarse debe ser mayor a Cero para:";
            foreach (NotaCreditoDebito item in ListadoNotas)
            {
                if (item.Monto == 0)
                {
                    ErrorNotas = true;
                    Resultado += $"\n{item.RazonSocial}";
                }
                if (item.Monto + item.MontoNotas < 0)
                {
                    ErrorNotas = true;
                    Resultado += $"\n{item.RazonSocial}";
                }
            }
            if (ErrorNotas) { msg(Resultado); return; }
            if (ErrorTotales) { msg(Resultado2); return; }

            //  return;
            if (CodigoPago == "007")
            {
                if (!txtnrocheque.EstaLLeno())
                {
                    msg("Ingrese Nro de Cheque"); txtnrocheque.Focus(); return;
                }
                DataTable Tdatos = CapaLogica.ValidarChequeExiste(cbobanco.SelectedValue.ToString(), HPResergerFunciones.Utilitarios.ExtraerCuenta(cbocuentabanco.Text), txtnrocheque.Text);
                if (Tdatos.Rows.Count > 0) { msg("Número de Cheque Ya Existe"); return; }
            }
            Boolean GenerarTxt = false;
            DialogResult ResultadoDialogo = CodigoPago == "007" ? DialogResult.No : HPResergerFunciones.Utilitarios.msgYesNoCancel("Desea Generar TXT del pago?");
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
                    if (msgOkCancel("El Banco Seleccionado no tiene para exportar a TXT, Desea Continuar?") == DialogResult.OK)
                    {
                        GenerarTxt = false;
                    }
                    else
                        return;
                }
            }
            if (ResultadoDialogo == DialogResult.No)
            {
                PAsoBanco = DialogResult.OK;
                GenerarTxt = false;
                //msg("selecciones no en generar txt");
            }
            if (ResultadoDialogo == DialogResult.Cancel)
                return;
            List<FACTURAS> ListaComprobantes = new List<FACTURAS>();
            foreach (FACTURAS i in Comprobantes)
            {
                ListaComprobantes.Add(new FACTURAS(i.numero, i.proveedor, i.tipo, i.subtotal, i.igv, i.total, i.detraccion, i.Saldo, i.aPagar, i.fechacancelado, i.centrocosto, i.FechaEmision, i.FechaRecepcion,
                    i.Moneda, i.CuentaContable, i.TipoCambio, i.IdComprobante));
            }
            ///REMOVEMOS LAS NOTAS
            for (int i = 0; i < Comprobantes.Count; i++)
            {
                FACTURAS valores = Comprobantes[i];
                string valor = valores.tipo.Substring(0, 2);
                if (valor == "NC" || valor == "ND")
                {
                    Comprobantes.Remove(valores);
                    i--;
                }
            }

            /// bajamos el monto a las facturas
            foreach (NotaCreditoDebito item in ListadoNotas)
            {
                decimal valor = item.MontoNotas;
                decimal dif = 0;
                foreach (FACTURAS items in Comprobantes)
                {
                    dif = valor + items.aPagar;
                    if (item.Proveedor == items.proveedor)
                    {
                        if (dif == 0)
                        {
                            Comprobantes.Remove(items);
                            break;
                        }
                        items.aPagar = dif;
                        valor = dif;
                        if (dif >= 0)
                            break;
                    }
                }
            }
            ////FIN DE REMOVER NOTAS
            if (GenerarTxt)
            {
                Dtguias.EndEdit();
                Proveedores.Clear();

                foreach (FACTURAS cadena in Comprobantes)
                {
                    Proveedores.Add(cadena.proveedor);
                }

                //ventanas de seleccion para generar txt
                frmCargaDatosProveedor frmcargardatosproveedor = new frmCargaDatosProveedor();
                frmcargardatosproveedor.Proveedores = Proveedores.Distinct().ToList<string>();
                frmcargardatosproveedor.banco = cbobanco.SelectedValue.ToString();
                frmcargardatosproveedor.txtbanco.Text = cbobanco.Text;
                frmcargardatosproveedor.cuenta = cbocuentabanco.Text;
                if (frmcargardatosproveedor.ShowDialog() == DialogResult.Cancel || frmcargardatosproveedor.Resultado == DialogResult.Cancel)
                    return;
                //msg("vamos a pagar la factura");
                PasoFactura = false;
                if (cbobanco.SelectedValue.ToString().ToUpper().Trim() == "CREDITO")
                {
                    //Abrimos eL formulario del banco de credito
                    //msg("FORMULARIO DEL BCP");
                    frmBancoBcp bancobcp = new frmBancoBcp();
                    bancobcp.TablaProveedorBanco = frmcargardatosproveedor.TablaProvedoresBancos;
                    //bancointerbank.TablaComprobantes = ((DataTable)Dtguias.DataSource).Clone();
                    //msg("Cuenta Filas " + bancointerbank.TablaComprobantes.Rows.Count);
                    bancobcp.txtcuentapago.Text = frmcargardatosproveedor.txtcuenta.Text;
                    bancobcp.Icon = Icon;
                    bancobcp.Comprobantes = Comprobantes;
                    bancobcp.ShowDialog();
                    PAsoBanco = bancobcp.DialogResult;
                }
                if (cbobanco.SelectedValue.ToString().ToUpper().Trim() == "INTERBANK")
                {
                    //abrimos el formulario del banco interbank
                    // msg("FORMULARIO DEL IBK");
                    frmBancoInterbank bancointerbank = new frmBancoInterbank();
                    bancointerbank.TablaProveedorBanco = frmcargardatosproveedor.TablaProvedoresBancos;
                    //bancointerbank.TablaComprobantes = ((DataTable)Dtguias.DataSource).Clone();
                    //msg("Cuenta Filas " + bancointerbank.TablaComprobantes.Rows.Count);
                    bancointerbank.txtcuenta.Text = frmcargardatosproveedor.txtcuenta.Text;
                    bancointerbank.Comprobantes = Comprobantes;
                    bancointerbank.Icon = Icon;
                    bancointerbank.ShowDialog();
                    PAsoBanco = bancointerbank.DialogResult;
                }
                if (cbobanco.SelectedValue.ToString().ToUpper().Trim() == "BIF")
                {
                    //abrimso el formulario del banco interarmericano de finanzas
                    //  msg("FORMULARIO DEL BIF");
                    frmBancoInterAmericano bancointeramericano = new frmBancoInterAmericano();
                    bancointeramericano.TablaProveedorBanco = frmcargardatosproveedor.TablaProvedoresBancos;
                    //bancointerbank.TablaComprobantes = ((DataTable)Dtguias.DataSource).Clone();
                    //msg("Cuenta Filas " + bancointerbank.TablaComprobantes.Rows.Count);
                    bancointeramericano.txtcuenta.Text = frmcargardatosproveedor.txtcuenta.Text;
                    bancointeramericano.Comprobantes = Comprobantes;
                    bancointeramericano.Icon = Icon;
                    bancointeramericano.ShowDialog();
                    PAsoBanco = bancointeramericano.DialogResult;
                }
            }
            //proceso para pagar facturas!!!
            //Movimiento de las cuentas 
            ///////////////////////
            ///Dinamica Contable///
            /////////////////////// 
            string nroKuenta = "";
            if (txttotal.Text != "0.00")
                nroKuenta = HPResergerFunciones.Utilitarios.ExtraerCuenta(cbocuentabanco.Text);
            ////return;
            DateTime FechaPago = dtpFechaPago.Value;
            DateTime FechaContable = dtpFechaContable.Value;
            if (PAsoBanco == DialogResult.OK)
            {
                int numasiento = 0;
                string facturar = "";
                if (numasiento == 0)
                {
                    DataTable asientito = CapaLogica.UltimoAsiento((int)cboempresa.SelectedValue, FechaContable);
                    DataRow asiento = asientito.Rows[0];
                    if (asiento == null) { numasiento = 1; }
                    else
                        numasiento = (int)asiento["codigo"];
                    numasiento--;
                }
                string cuoPago = HPResergerFunciones.Utilitarios.Cuo(numasiento + 1, FechaContable); int fkEmpresa = (int)cboempresa.SelectedValue;
                int ContadorFilaDiferencial = ListaComprobantes.Count + 2;
                foreach (FACTURAS fac in ListaComprobantes)
                {
                    DataTable TBanco = new DataTable();
                    TBanco = CapaLogica.EntidadFinanciera();
                    DataRow[] filita = TBanco.Select($"sufijo='{cbobanco.SelectedValue.ToString()}'");
                    int banko = int.Parse((filita[0])["codigo"].ToString());
                    //Recorremos los comprobantes seleccionados RH / FT
                    //Public FACTURAS(string Numero, string Proveedor, string Tipo, decimal Subtotal, decimal Igv, decimal Total, decimal Detraccion, DateTime FechaCancelado)
                    if (fac.tipo.Substring(0, 2) == "RH")
                    {
                        //actualizo que el recibo este pagado
                        if (fac.Saldo == fac.aPagar) CapaLogica.insertarPagarfactura(fac.numero, fac.proveedor, int.Parse(cbotipo.Text.Substring(0, 3)), CodigoPago == "007" ? txtnrocheque.Text : "", fac.aPagar > fac.Saldo ? fac.Saldo : fac.aPagar
                            , fac.subtotal, fac.igv, fac.total, frmLogin.CodigoUsuario, 0, banko, nroKuenta, FechaPago, fac.IdComprobante, fkEmpresa, cuoPago);
                        else CapaLogica.insertarPagarfactura(fac.numero, fac.proveedor, int.Parse(cbotipo.Text.Substring(0, 3)), CodigoPago == "007" ? txtnrocheque.Text : "", fac.aPagar > fac.Saldo ? fac.Saldo : fac.aPagar
                            , fac.subtotal, fac.igv, fac.total, frmLogin.CodigoUsuario, 1, banko, nroKuenta, FechaPago, fac.IdComprobante, fkEmpresa, cuoPago);
                        //cuenta de recibo por honorarios 4241101
                        CapaLogica.guardarfactura(1, numasiento + 1, fac.numero, fac.CuentaContable != "" ? fac.CuentaContable : fac.Moneda == 1 ? "4241101" : "4241201", fac.aPagar > fac.Saldo ? fac.Saldo : fac.aPagar
                            , 0, 1, FechaPago, fac.fechacancelado, fac.FechaRecepcion, frmLogin.CodigoUsuario, fac.centrocosto, fac.tipo.Substring(0, 2), fac.proveedor, fac.Moneda, nroKuenta, ""
                            , fac.TipoCambio, decimal.Parse(txttipocambio.Text), FechaPago, Configuraciones.Redondear((fac.aPagar > fac.Saldo ? fac.Saldo : fac.aPagar) * decimal.Parse(txttipocambio.Text))
                            - Configuraciones.Redondear((fac.aPagar > fac.Saldo ? fac.Saldo : fac.aPagar) * fac.TipoCambio), ContadorFilaDiferencial, decimal.Parse(txttotaldiferencial.Text), fac.IdComprobante, FechaContable
                            , txtglosa.TextValido());
                        facturar = fac.numero;
                        proveer = fac.proveedor;
                        idmoneda = fac.Moneda;
                    }
                    else if ((fac.tipo.Substring(0, 2) == "NC" || fac.tipo.Substring(0, 2) == "ND"))// && fac.tipo.Substring(fac.tipo.Length - 1, 1) != "e")
                    {
                        //Actualizo el estado a pagado!
                        if (fac.Saldo >= fac.aPagar)
                            if (fac.tipo.Substring(fac.tipo.Length - 1, 1) != "e")
                                CapaLogica.ActualizarNotaCreditoDebito(fac.proveedor, fac.numero, 1, (int)cboempresa.SelectedValue);
                    }
                    else
                    {
                        //if (fac.detraccion > 0)
                        //{
                        //actualizo que la factura esta pagada
                        //if (fac.Saldo == fac.aPagar) cPagarfactura.insertarPagarfactura(fac.numero, fac.proveedor, int.Parse(cbotipo.Text.Substring(0, 3)), txtnropago.Text, fac.aPagar, fac.subtotal, fac.igv, fac.total, frmLogin.CodigoUsuario, 0, banko, nroKuenta, hoy);
                        //else cPagarfactura.insertarPagarfactura(fac.numero, fac.proveedor, int.Parse(cbotipo.Text.Substring(0, 3)), txtnropago.Text, fac.aPagar, fac.subtotal, fac.igv, fac.total, frmLogin.CodigoUsuario, 1, banko, nroKuenta, hoy);
                        /////facturas por pagar 4212101
                        //cPagarfactura.guardarfactura(1, numasiento + 1, fac.numero, "4011110", 0, fac.detraccion, 3, fac.FechaEmision, fac.fechacancelado, fac.FechaRecepcion, frmLogin.CodigoUsuario, fac.centrocosto, fac.tipo, fac.proveedor, fac.Moneda, nroKuenta);
                        //cPagarfactura.guardarfactura(1, numasiento + 1, fac.numero, "4212101", fac.aPagar, 0, 2, fac.FechaEmision, fac.fechacancelado, fac.FechaRecepcion, frmLogin.CodigoUsuario, fac.centrocosto, fac.tipo, fac.proveedor, fac.Moneda, nroKuenta);
                        //facturar = fac.numero; proveer = fac.proveedor;
                        //idmoneda = fac.Moneda;
                        //}
                        //else
                        //{
                        //actualizo que la factura esta pagada
                        if (fac.Saldo >= fac.aPagar)
                            CapaLogica.insertarPagarfactura(fac.numero, fac.proveedor, int.Parse(cbotipo.Text.Substring(0, 3)), CodigoPago == "007" ? txtnrocheque.Text : "", fac.aPagar > fac.Saldo ? fac.Saldo : fac.aPagar
                                , fac.subtotal, fac.igv, fac.total, frmLogin.CodigoUsuario, 0, banko, nroKuenta, FechaPago, fac.IdComprobante, fkEmpresa, cuoPago);
                        else
                            CapaLogica.insertarPagarfactura(fac.numero, fac.proveedor, int.Parse(cbotipo.Text.Substring(0, 3)), CodigoPago == "007" ? txtnrocheque.Text : "", fac.aPagar > fac.Saldo ? fac.Saldo : fac.aPagar
                                , fac.subtotal, fac.igv, fac.total, frmLogin.CodigoUsuario, 1, banko, nroKuenta, FechaPago, fac.IdComprobante, fkEmpresa, cuoPago);
                        ///facturas por pagar 4212101
                        CapaLogica.guardarfactura(1, numasiento + 1, fac.numero, fac.CuentaContable != "" ? fac.CuentaContable : fac.Moneda == 1 ? "4212101" : "4212201", fac.aPagar > fac.Saldo ? fac.Saldo : fac.aPagar
                            , 0, 2, FechaPago, fac.fechacancelado, fac.FechaRecepcion, frmLogin.CodigoUsuario, fac.centrocosto, fac.tipo, fac.proveedor, fac.Moneda, nroKuenta, "", fac.TipoCambio
                            , decimal.Parse(txttipocambio.Text), FechaPago, Configuraciones.Redondear((fac.aPagar > fac.Saldo ? fac.Saldo : fac.aPagar) * decimal.Parse(txttipocambio.Text))
                            - Configuraciones.Redondear((fac.aPagar > fac.Saldo ? fac.Saldo : fac.aPagar) * fac.TipoCambio), ContadorFilaDiferencial, decimal.Parse(txttotaldiferencial.Text), fac.IdComprobante
                            , FechaContable, txtglosa.TextValido());
                        facturar = fac.numero;
                        proveer = fac.proveedor;
                        idmoneda = fac.Moneda;
                        //}
                    }
                }
                string BanCuenta;
                if (cbocuentabanco.SelectedValue == null)
                    BanCuenta = "";
                else
                    BanCuenta = cbocuentabanco.SelectedValue.ToString();
                ////Notas
                int con = 0;
                foreach (DataGridViewRow item in Dtguias.Rows)
                {
                    if (item.Cells[OK.Name].Value.ToString().ToUpper() == "TRUE")
                    {
                        string tipos = item.Cells[tipodoc.Name].Value.ToString();
                        decimal aPagar = (decimal)item.Cells[Pagox.Name].Value;
                        decimal saldo = (decimal)item.Cells[Saldox.Name].Value;
                        DateTime f = new DateTime(); f = DateTime.Now;
                        if (tipos.Substring(0, 2) == "ND" || tipos.Substring(0, 2) == "NC")// && tipos.Substring(tipos.Length - 1, 1) != "e")
                        {
                            ++con;
                            CapaLogica.guardarfactura(0, numasiento + 1, item.Cells[nrofactura.Name].Value.ToString(), "", tipos == "ND" ? aPagar : 0, tipos == "ND" ? 0 : aPagar, 10, FechaPago, f, f, frmLogin.CodigoUsuario, 0
                                , tipos, item.Cells[proveedor.Name].Value.ToString(), (int)item.Cells[xidmoneda.Name].Value, item.Cells[xCuentaContable.Name].Value.ToString(), "", (decimal)item.Cells[xtc.Name].Value
                                , decimal.Parse(txttipocambio.Text), FechaPago, (Configuraciones.Redondear((aPagar > saldo ? saldo : aPagar) * decimal.Parse(txttipocambio.Text))
                                - Configuraciones.Redondear((aPagar > saldo ? saldo : aPagar) * (decimal)item.Cells[xtc.Name].Value)) * ((int)item.Cells[xidcomprobante.Name].Value == 8 ? -1 : 1)
                                , ContadorFilaDiferencial, decimal.Parse(txttotaldiferencial.Text), (int)item.Cells[xidcomprobante.Name].Value, FechaContable, txtglosa.TextValido());
                        }
                    }
                }
                ///BANCO  /// Revisar el detalle de los bancos!
                string CuentaContable = txtCuentaExceso.Text;
                decimal tc = decimal.Parse(txttipocambio.Text);
                decimal Abonado = decimal.Parse(txttotalAbonado.Text);
                int proyecto = (int)cboproyecto.SelectedValue;
                string Cuo = HPResergerFunciones.Utilitarios.Cuo(numasiento + 1, FechaContable);
                string glosa = txtglosa.TextValido();
                int idUsuario = frmLogin.CodigoUsuario;
                if (decimal.Parse(txttotal.Text) > 0)
                {
                    //CapaLogica.guardarfactura(0, numasiento + 1, facturar, BanCuenta, 0, Abonado, 5, FechaPago, DateTime.Now, DateTime.Now, frmLogin.CodigoUsuario, 1, "", proveer
                    //    , idmoneda, nroKuenta, CodigoPago == "007" ? txtnrocheque.Text : "", decimal.Parse(txttipocambio.Text), decimal.Parse(txttipocambio.Text), FechaPago, decimal.Parse(txttipocambio.Text)
                    //    , ContadorFilaDiferencial, decimal.Parse(txttotaldiferencial.Text), 0, FechaContable, txtglosa.TextValido());
                    ///Cabecera
                    CapaLogica.InsertarAsientoFacturaCabecera(1, ContadorFilaDiferencial, numasiento + 1, FechaContable, BanCuenta, 0, Abonado, tc, proyecto, 0, Cuo, idmoneda
                        , glosa, FechaPago, -3);
                    foreach (DataGridViewRow item in Dtguias.Rows)
                    {
                        //Detalle del asiento
                        if (item.Cells[OK.Name].Value.ToString().ToUpper() == "TRUE")
                        {
                            decimal aPagar = (decimal)item.Cells[Pagox.Name].Value;
                            decimal saldo = (decimal)item.Cells[Saldox.Name].Value;
                            string moneda = item.Cells[monedax.Name].Value.ToString();
                            int idMoneda = (moneda == "SOL" ? 1 : moneda == "USD" ? 2 : 0);
                            string ruc = item.Cells[proveedor.Name].Value.ToString();
                            string RazonSocial = item.Cells[razon.Name].Value.ToString();
                            int idComprobante = (int)item.Cells[xidcomprobante.Name].Value;
                            string[] valor = item.Cells[nrofactura.Name].Value.ToString().Split('-');
                            //Calculo del Exceso
                            decimal ExcesoMN = (idMoneda == 1 ? aPagar : (aPagar) * tc);
                            decimal ExcesoME = (idMoneda == 2 ? aPagar : (aPagar) / tc);
                            //
                            CapaLogica.InsertarAsientoFacturaDetalle(10, ContadorFilaDiferencial, numasiento + 1, FechaContable, BanCuenta, proyecto, 5, ruc, RazonSocial, idComprobante, valor[0], valor[1], 0,
                            FechaPago, FechaContable, FechaContable, ExcesoMN, ExcesoME, tc, idmoneda, nroKuenta, "", glosa, FechaPago, idUsuario, "");
                        }
                    }
                }
                //ABONO EN EXCESO //    
                foreach (DataGridViewRow item in Dtguias.Rows)
                {
                    ///validamos que el monto sea mayor
                    if (item.Cells[OK.Name].Value.ToString().ToUpper() == "TRUE")
                    {
                        decimal aPagar = (decimal)item.Cells[Pagox.Name].Value;
                        decimal saldo = (decimal)item.Cells[Saldox.Name].Value;
                        string moneda = item.Cells[monedax.Name].Value.ToString();
                        int idMoneda = (moneda == "SOL" ? 1 : moneda == "USD" ? 2 : 0);
                        string ruc = item.Cells[proveedor.Name].Value.ToString();
                        string RazonSocial = item.Cells[razon.Name].Value.ToString();
                        int idComprobante = (int)item.Cells[xidcomprobante.Name].Value;
                        string[] valor = item.Cells[nrofactura.Name].Value.ToString().Split('-');
                        //Calculo del Exceso
                        decimal ExcesoMN = (idMoneda == 1 ? aPagar - saldo : (aPagar - saldo) * tc);
                        decimal ExcesoME = (idMoneda == 2 ? aPagar - saldo : (aPagar - saldo) / tc);
                        if (aPagar > saldo)
                        {
                            //Procedemos a guardar el Exceso!
                            //Cabecera Facturas
                            CapaLogica.InsertarAsientoFacturaCabecera(1, ++ContadorFilaDiferencial, numasiento + 1, FechaContable, CuentaContable, idMoneda == 1 ? ExcesoMN : ExcesoME, 0, tc, proyecto, 0, Cuo, idMoneda
                                , glosa, FechaPago, -3);
                            //Detalle del asiento
                            CapaLogica.InsertarAsientoFacturaDetalle(10, ContadorFilaDiferencial, numasiento + 1, FechaContable, CuentaContable, proyecto, 5, ruc, RazonSocial, idComprobante, valor[0], valor[1], 0,
                                FechaPago, FechaContable, FechaContable, ExcesoMN, ExcesoME, tc, idmoneda, "", "", glosa, FechaPago, idUsuario, "");
                        }
                    }
                }
                msg($"Documento Pagado \nGenerado su Asiento {Cuo}");
                //btnActualizar_Click(sender, e);
                //Cuadrar Asiento
                CapaLogica.CuadrarAsiento(Cuo, (int)cboproyecto.SelectedValue, FechaContable, 2);
                //Fin Cuadrar Asiento
                txttotaldetrac.Text = txttotal.Text = "0.00";
                Comprobantes.Clear();
                txtnrocheque.CargarTextoporDefecto();
                btnRefrescar_Click(sender, e);
            }
        }
        public Boolean PasoFactura = false;
        List<string> Proveedores = new List<string>();
        /*
        SaveFile.FileName = cbobanco.Text + " " + DateTime.Now.ToLongDateString();
        if (SaveFile.FileName != string.Empty && SaveFile.ShowDialog() == DialogResult.OK)
        {
            string path = SaveFile.FileName;
            st = File.CreateText(path);
            string cadenita = "";
            for (int i = 0; i < Dtguias.RowCount; i++)
            {
                DataGridViewCheckBoxCell ch1 = new DataGridViewCheckBoxCell();
                ch1 = (DataGridViewCheckBoxCell)Dtguias["ok", i];
                if (ch1.Value == null)
                    ch1.Value = false;
                if (Dtguias["ok", i].Value == null)
                    Dtguias["ok", i].Value = false;
                if (Dtguias["ok", i].Value.ToString() == "True")
                {
                    for (int j = 0; j < Dtguias.ColumnCount - 1; j++)
                    {
                        if (!columnas.Contains(j))
                            cadenita = cadenita + Dtguias[j, i].Value.ToString() + "|";
                    }
                    cadenita = cadenita + Dtguias[Dtguias.ColumnCount - 1, i].Value.ToString() + (char)(13);
                }
            }
            st.Write(cadenita);
            st.Close();

            int numasiento; string facturar = "";
            DataTable asientito = cPagarfactura.UltimoAsiento();
            DataRow asiento = asientito.Rows[0];
            numasiento = (int)asiento["codigo"];
            foreach (DataGridViewRow lista in Dtguias.Rows)
            {
                DataGridViewCheckBoxCell ch1 = new DataGridViewCheckBoxCell();
                ch1 = (DataGridViewCheckBoxCell)lista.Cells["ok"];
                if (ch1.Value == null)
                    ch1.Value = false;
                if (lista.Cells["OK"].Value == null)
                    lista.Cells["OK"].Value = false;
                switch (lista.Cells["OK"].Value.ToString())
                {
                    case "True":
                        if (lista.Cells["tipodoc"].Value.ToString().Substring(0, 2) == "RH")
                        {
                            //actualizo que el recibo este pagado
                            cPagarfactura.insertarPagarfactura(lista.Cells["nrofactura"].Value.ToString(), int.Parse(cbotipo.Text.Substring(0, 3)), txtnropago.Text);
                            //cuenta de recibo por honorarios 4241101
                            cPagarfactura.guardarfactura(1, numasiento + 1, lista.Cells["nrofactura"].Value.ToString(), "4241101", (decimal)lista.Cells["subtotal"].Value, 0);
                            facturar = lista.Cells["nrofactura"].Value.ToString();
                        }
                        else
                        {
                            if ((decimal)lista.Cells["detraccion"].Value > 0)
                            {
                                //actualizo que la factura esta pagada
                                cPagarfactura.insertarPagarfactura(lista.Cells["nrofactura"].Value.ToString(), int.Parse(cbotipo.Text.Substring(0, 3)), txtnropago.Text);
                                ///facturas por pagar 4212101
                                cPagarfactura.guardarfactura(1, numasiento + 1, lista.Cells["nrofactura"].Value.ToString(), "4011110", (decimal)lista.Cells["detraccion"].Value, 0);
                                cPagarfactura.guardarfactura(1, numasiento + 1, lista.Cells["nrofactura"].Value.ToString(), "4212101", (decimal)lista.Cells["total"].Value - (decimal)lista.Cells["detraccion"].Value, 0);
                                facturar = lista.Cells["nrofactura"].Value.ToString();
                            }
                            else
                            {
                                //actualizo que la factura esta pagada
                                cPagarfactura.insertarPagarfactura(lista.Cells["nrofactura"].Value.ToString(), int.Parse(cbotipo.Text.Substring(0, 3)), txtnropago.Text);
                                ///facturas por pagar 4212101
                                cPagarfactura.guardarfactura(1, numasiento + 1, lista.Cells["nrofactura"].Value.ToString(), "4212101", (decimal)lista.Cells["total"].Value, 0);
                                facturar = lista.Cells["nrofactura"].Value.ToString();
                            }
                        }
                        break;
                    case "False":
                        break;
                }
            }
            cPagarfactura.guardarfactura(0, numasiento + 1, facturar, cbocuentabanco.SelectedValue.ToString(), 0, decimal.Parse(txttotal.Text));
            msg("Documento Pagado y se ha Generado su Asiento");
            txtruc_TextChanged(sender, e);
            txttotaldetrac.Text = txttotal.Text = "0.00";

        }
        else
        {
            msg("Cancelado Por el Usuario");
        }*/
        decimal sumatoria;
        decimal detrac;
        public class FACTURAS
        {
            public string numero { get; set; }
            public string proveedor { get; set; }
            public string tipo { get; set; }
            public decimal subtotal { get; set; }
            public decimal igv { get; set; }
            public decimal total { get; set; }
            public decimal Saldo { get; set; }
            public decimal aPagar { get; set; }
            public decimal detraccion { get; set; }
            public DateTime? fechacancelado { get; set; }
            public int centrocosto { get; set; }
            public DateTime FechaEmision { get; set; }
            public DateTime FechaRecepcion { get; set; }
            public int Moneda { get; set; }
            public string CuentaContable { get; set; }
            public decimal TipoCambio { get; set; }
            public int IdComprobante { get; set; }
            public FACTURAS(string Numero, string Proveedor, string Tipo, decimal Subtotal, decimal Igv, decimal Total, decimal Detraccion, decimal saldo, decimal APagar, DateTime? FechaCancelado, int CentroCosto, DateTime fechaemision, DateTime fecharecepcion, int moneda, string _CuentaContable, decimal _tipocambio, int _idcomprobante)
            {
                numero = Numero;
                proveedor = Proveedor;
                tipo = Tipo;
                subtotal = Subtotal;
                igv = Igv;
                total = Total;
                detraccion = Detraccion;
                Saldo = saldo;
                aPagar = APagar;
                fechacancelado = FechaCancelado;
                centrocosto = CentroCosto;
                FechaEmision = fechaemision;
                FechaRecepcion = fecharecepcion;
                Moneda = moneda;
                CuentaContable = _CuentaContable;
                TipoCambio = _tipocambio;
                IdComprobante = _idcomprobante;
            }
        }
        List<FACTURAS> Comprobantes = new List<FACTURAS>();
        private void Dtguias_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Dtguias.EndEdit();
            try
            {
                if (e.RowIndex >= 0 && e.ColumnIndex == 0)
                {
                    if (Dtguias["ok", e.RowIndex].Value.ToString() == "True")
                    {
                        //msg("Contains= " + Comprobantes.Contains(new FACTURAS(Dtguias["nrofactura", e.RowIndex].Value.ToString().TrimStart().TrimEnd(), Dtguias["proveedor", e.RowIndex].Value.ToString().TrimStart().TrimEnd())));
                        Boolean Busqueda = false;
                        foreach (FACTURAS xfac in Comprobantes)
                        {
                            if (xfac.numero == Dtguias["nrofactura", e.RowIndex].Value.ToString().TrimStart().TrimEnd() && xfac.proveedor == Dtguias["proveedor", e.RowIndex].Value.ToString().TrimStart().TrimEnd() && xfac.centrocosto == (int)Dtguias[centrocostox.Name, e.RowIndex].Value && xfac.tipo == Dtguias[tipodoc.Name, e.RowIndex].Value.ToString())
                                Busqueda = true;
                        }
                        if (!Busqueda)
                            Comprobantes.Add(new FACTURAS(Dtguias["nrofactura", e.RowIndex].Value.ToString().TrimStart().TrimEnd(), Dtguias["proveedor", e.RowIndex].Value.ToString().TrimStart().TrimEnd(), Dtguias["tipodoc", e.RowIndex].Value.ToString().TrimStart().TrimEnd(), (decimal)Dtguias["subtotal", e.RowIndex].Value, (decimal)Dtguias["igv", e.RowIndex].Value, (decimal)Dtguias["total", e.RowIndex].Value, (decimal)Dtguias["detraccion", e.RowIndex].Value, (decimal)Dtguias[Saldox.Name, e.RowIndex].Value, (decimal)Dtguias[Pagox.Name, e.RowIndex].Value, (DateTime)Dtguias["fechacancelado", e.RowIndex].Value, (int)(Dtguias[centrocostox.Name, e.RowIndex].Value.ToString() == "" ? 0 : Dtguias[centrocostox.Name, e.RowIndex].Value), (DateTime)Dtguias[FechaEmision.Name, e.RowIndex].Value, (DateTime)Dtguias[fechaRecepcion.Name, e.RowIndex].Value, (int)Dtguias[xidmoneda.Name, e.RowIndex].Value, Dtguias[xCuentaContable.Name, e.RowIndex].Value.ToString()
                                , decimal.Parse(Dtguias[xtc.Name, e.RowIndex].Value.ToString()), (int)Dtguias[xidcomprobante.Name, e.RowIndex].Value));
                    }
                    else
                    {
                        Boolean Busqueda = false; int X = 0, Y = 0;
                        foreach (FACTURAS xfac in Comprobantes)
                        {
                            if (xfac.numero == Dtguias["nrofactura", e.RowIndex].Value.ToString().TrimStart().TrimEnd() && xfac.proveedor == Dtguias["proveedor", e.RowIndex].Value.ToString().TrimStart().TrimEnd() && xfac.tipo == Dtguias[tipodoc.Name, e.RowIndex].Value.ToString())
                            {
                                Busqueda = true; Y = X; break;
                            }
                            X++;
                        }
                        //FACTURAS cola = new FACTURAS(Dtguias["nrofactura", e.RowIndex].Value.ToString().TrimStart().TrimEnd(), Dtguias["proveedor", e.RowIndex].Value.ToString().TrimStart().TrimEnd());
                        //msg("" + Comprobantes.Exists(cust=>cust.numero==cola.numero&&cust.proveedor==cola.proveedor) + " Y=" + Y + " Contador=" + Comprobantes.Count);
                        if (Busqueda)
                            Comprobantes.RemoveAt(Y);
                    }
                    CalcularTotal();
                }
                //else
            }
            catch (Exception ex) { msg(ex.Message); }
            if (e.RowIndex >= 0)
            {
                if (e.ColumnIndex == Dtguias.Columns[btnVer.Name].Index)
                {
                    if (Dtguias[btnVer.Name, e.RowIndex].Value.ToString() == "Abonos")
                    {
                        if (frmdetallepago == null)
                        {
                            frmdetallepago = new frmDetallePagoFactura(1, Dtguias[nrofactura.Name, e.RowIndex].Value.ToString(), 0, Dtguias[proveedor.Name, e.RowIndex].Value.ToString());
                            frmdetallepago.FormClosed += Frmdetallepago_FormClosed;
                            frmdetallepago.MdiParent = MdiParent;
                            frmdetallepago.Show();
                        }
                        else frmdetallepago.Activate();
                    }
                }
                FacturasSeleccionas();
            }
        }

        private void Frmdetallepago_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmdetallepago = null;
        }
        frmDetallePagoFactura frmdetallepago;
        int NumRegistros;
        public void CalcularTotal()
        {
            sumatoria = 0;
            detrac = 0; NumRegistros = 0;
            decimal SumaTotalPagada = 0;
            Boolean señal = false;
            if (Dtguias.RowCount > 0)
            {
                // btnaceptar.Enabled = true;                
                foreach (DataGridViewRow lista in Dtguias.Rows)
                {
                    DataGridViewCheckBoxCell ch1 = new DataGridViewCheckBoxCell();
                    ch1 = (DataGridViewCheckBoxCell)lista.Cells["ok"];
                    if (ch1.Value == null)
                        ch1.Value = false;
                    if (lista.Cells["OK"].Value == null)
                        lista.Cells["OK"].Value = false;
                    switch (lista.Cells["OK"].Value.ToString())
                    {
                        case "True":
                            NumRegistros++;
                            decimal Valor = (decimal)lista.Cells[Pagox.Name].Value;
                            if ((decimal)lista.Cells[Pagox.Name].Value > (decimal)lista.Cells[Saldox.Name].Value)
                            {
                                Valor = (decimal)lista.Cells[Saldox.Name].Value;
                            }
                            //Procesando
                            if (lista.Cells["tipodoc"].Value.ToString().Substring(0, 2) == "RH")
                            {
                                sumatoria += Valor;
                                SumaTotalPagada += (decimal)lista.Cells[Pagox.Name].Value;
                            }
                            else if (lista.Cells["tipodoc"].Value.ToString().Substring(0, 2) == "NC")
                            {
                                sumatoria -= Valor;
                                SumaTotalPagada -= (decimal)lista.Cells[Pagox.Name].Value; señal = true;
                            }
                            else if (lista.Cells["tipodoc"].Value.ToString().Substring(0, 2) == "ND")
                            {
                                sumatoria += Valor;
                                SumaTotalPagada += (decimal)lista.Cells[Pagox.Name].Value; señal = true;
                            }
                            else
                            {
                                sumatoria += Valor;
                                SumaTotalPagada += (decimal)lista.Cells[Pagox.Name].Value; señal = true;
                                detrac += (decimal)lista.Cells["detraccion"].Value;
                            }
                            break;
                        case "False":
                            break;
                    }
                }
                txttotaldetrac.Text = detrac.ToString("n2");
                txttotalAbonado.Text = SumaTotalPagada.ToString("n2");
                txttotal.Text = sumatoria.ToString("n2");
                CalcularDiferencial();
            }
            if (!señal)
            {
                if (sumatoria == 0)
                    btnaceptar.Enabled = false;
                else
                    btnaceptar.Enabled = true;
            }
            else if (sumatoria >= 0)
            {
                btnaceptar.Enabled = true;
            }
            else btnaceptar.Enabled = false;
            lblmensaje.Text = $"Número de Registros: { NumRegistros}/{Dtguias.RowCount} ";
        }
        public void CalcularDiferencial()
        {
            decimal Diferencial = 0;
            foreach (DataGridViewRow item in Dtguias.Rows)
            {
                if (item.Cells[OK.Name].Value != null)
                    if (Boolean.Parse(item.Cells[OK.Name].Value.ToString()) == true)
                    {
                        if (item.Cells[monedax.Name].Value.ToString() == "USD")
                        {
                            if ((int)item.Cells[xidcomprobante.Name].Value == 8)
                                Diferencial -= Configuraciones.Redondear((decimal)item.Cells[Pagox.Name].Value * decimal.Parse(txttipocambio.TextValido())) - Configuraciones.Redondear((decimal)item.Cells[Pagox.Name].Value * (decimal)item.Cells[xtc.Name].Value);
                            else
                                Diferencial += Configuraciones.Redondear((decimal)item.Cells[Pagox.Name].Value * decimal.Parse(txttipocambio.TextValido())) - Configuraciones.Redondear((decimal)item.Cells[Pagox.Name].Value * (decimal)item.Cells[xtc.Name].Value);
                        }
                    }
            }
            txttotaldiferencial.Text = Diferencial.ToString("n2");
        }
        private void Dtguias_RowErrorTextChanged(object sender, DataGridViewRowEventArgs e)
        {
        }
        private void Dtguias_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (Dtguias.RowCount < 0)
            {
                cbotipo.Enabled = cbobanco.Enabled = cbocuentabanco.Enabled = btnaceptar.Enabled = false;
                //   cbotipo.SelectedIndex = 0;// txtnropago.Enabled = false;

            }
            else
            {
                cbotipo.Enabled = true; cbobanco.Enabled = true; cbocuentabanco.Enabled = true;
                // cbotipo.SelectedIndex = 0;// txtnropago.Enabled = true;
            }
            if (e.RowIndex >= 0)
            {
                //if (rdbporPagar.Checked)
                //    if (e.ColumnIndex == Dtguias.Columns[Pagox.Name].Index)
                //    {
                //        if (Dtguias[tipodoc.Name, e.RowIndex].Value.ToString().ToUpper().Substring(0, 2) == "NC" || Dtguias[tipodoc.Name, e.RowIndex].Value.ToString().ToUpper().Substring(0, 2) == "ND")
                //            Dtguias[e.ColumnIndex, e.RowIndex].ReadOnly = true;
                //        else
                //            Dtguias[e.ColumnIndex, e.RowIndex].ReadOnly = false;
                //    }
            }
        }
        private void btncancelar_Click(object sender, EventArgs e)
        {
            if (msgOkCancel("¿Desea Salir?") == DialogResult.OK)
            {
                this.Close();
            }
        }
        int[] columnas = { 0 };
        private void btnActualizar_Click(object sender, EventArgs e)
        {
            txtbuscar_TextChanged(sender, e);
        }
        int prove = 0;
        private void chkprove_CheckedChanged(object sender, EventArgs e)
        {
            txtbuscar.ReadOnly = true;
            if (chkprove.Checked)
            {
                prove = 1;
                txtbuscar.ReadOnly = false;
            }
            else
                prove = 0;
            txtbuscar_TextChanged(sender, e);
        }
        int fecha = 0;
        private void chkfecha_CheckedChanged(object sender, EventArgs e)
        {
            dtinicio.Enabled = dtfin.Enabled = false;
            fecha = 0;
            if (chkfecha.Checked)
            {
                fecha = 1;
                dtinicio.Enabled = dtfin.Enabled = true;
            }
            txtbuscar_TextChanged(sender, e);
        }
        DateTime auxtmp;
        private void txtbuscar_TextChanged(object sender, EventArgs e)
        {
            if (dtfin.Value < dtinicio.Value)
            {
                auxtmp = dtfin.Value;
                dtfin.Value = dtinicio.Value;
                dtinicio.Value = auxtmp;
            }
            if (dtpfin.Value < dtpini.Value)
            {
                auxtmp = dtpfin.Value;
                dtpfin.Value = dtpini.Value;
                dtpini.Value = auxtmp;
            }
            if (cboempresa.SelectedValue != null)
            {
                if (rdbporPagar.Checked)
                {
                    SacarDatosFiltrados();
                    //Dtguias.DataSource = CapaLogica.ListarFacturasPorPagarxEmpresa(prove, txtbuscar.Text, fecha, dtinicio.Value, dtfin.Value, recepcion, dtpini.Value, dtpfin.Value, 0, (int)cboempresa.SelectedValue);
                    //cbotipo.SelectedIndex = 0;
                    txttotaldetrac.Text = txttotal.Text = "0.00";
                    btnaceptar.Enabled = false;
                    FacturasSeleccionas();
                    CalcularTotal();
                }
                else SacarDatosFiltrados();
                //Dtguias.DataSource = CapaLogica.ListarFacturasPagadosxEmpresa(prove, txtbuscar.Text, fecha, dtinicio.Value, dtfin.Value, recepcion, dtpini.Value, dtpfin.Value, 0, (int)cboempresa.SelectedValue);
            }
            ContarRegistros();
        }
        public void SacarDatosFiltrados()
        {
            string filter = "";
            if (prove == 1)
            {
                filter = $"(proveedor like '%{txtbuscar.TextValido() }%' or razon like '%{txtbuscar.TextValido()}%')";
            }
            if (fecha == 1)
            {
                filter += $" {(prove == 1 ? "and" : "")} fechacancelado >= '{Configuraciones.ToFechaSql(dtinicio.Value)}' and fechacancelado <= '{Configuraciones.ToFechaSql(dtfin.Value)}'";
            }
            if (recepcion == 1)
            {
                filter += $" {(prove == 1 || fecha == 1 ? "and" : "")} fecharecepcion >= '{Configuraciones.ToFechaSql(dtpini.Value)}' and fecharecepcion <= '{Configuraciones.ToFechaSql(dtpfin.Value)}'";
            }
            DataTable TableFiltrada;
            if (rdbporPagar.Checked)
            {
                DataView dv = TablaPorPagar.DefaultView;
                dv.RowFilter = filter;
                //Datos Filtrados
                TableFiltrada = dv.ToTable();
                Dtguias.DataSource = TableFiltrada;
            }
            else if (rdbPagados.Checked)
            {
                DataView dv = TablaPagados.DefaultView;
                dv.RowFilter = filter;
                //Datos Filtrados
                TableFiltrada = dv.ToTable();
                Dtguias.DataSource = TableFiltrada;
            }
        }
        public void ContarRegistros()
        {
            lblmensaje.Text = $"Número de Registros: { NumRegistros}/{Dtguias.RowCount} ";
        }
        public void FacturasSeleccionas()
        {
            int conta = Dtguias.RowCount;
            foreach (FACTURAS fac in Comprobantes)
            {
                for (int i = 0; i < conta; i++)
                {
                    if (Dtguias["nrofactura", i].Value.ToString().TrimStart().TrimEnd() == fac.numero && Dtguias["proveedor", i].Value.ToString().TrimStart().TrimEnd() == fac.proveedor && fac.centrocosto == (Dtguias[centrocostox.Name, i].Value.ToString() == "" ? 0 : (int)Dtguias[centrocostox.Name, i].Value) && fac.tipo == Dtguias[tipodoc.Name, i].Value.ToString())
                    {
                        Dtguias["ok", i].Value = true;
                        Dtguias[Pagox.Name, i].Value = fac.aPagar;
                    }
                }
            }
        }
        private void dtinicio_ValueChanged(object sender, EventArgs e)
        {
            txtbuscar_TextChanged(sender, e);
        }
        private void dtfin_ValueChanged(object sender, EventArgs e)
        {
            txtbuscar_TextChanged(sender, e);
        }
        int recepcion = 0;
        private void chkrecepcion_CheckedChanged(object sender, EventArgs e)
        {
            dtpini.Enabled = dtpfin.Enabled = false;
            if (chkrecepcion.Checked)
            {
                recepcion = 1;
                dtpini.Enabled = dtpfin.Enabled = true;
            }
            else recepcion = 0;
            txtbuscar_TextChanged(sender, e);
        }

        private void dtpini_ValueChanged(object sender, EventArgs e)
        {
            txtbuscar_TextChanged(sender, e);
        }
        private void dtpfin_ValueChanged(object sender, EventArgs e)
        {
            txtbuscar_TextChanged(sender, e);
        }
        private void Dtguias_Sorted(object sender, EventArgs e)
        {
            Dtguias.EndEdit();
            FacturasSeleccionas();
        }
        private void btnExportarTxt_Click(object sender, EventArgs e)
        {

        }
        private void Dtguias_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Dtguias.EndEdit();
            if (Dtguias.RowCount > 0)
            {
                if (Dtguias.Columns["ok"].Index == e.ColumnIndex)
                {
                    Boolean estado = false;
                    if (Dtguias["ok", 0].Value == null)
                        estado = false;
                    else
                        estado = Boolean.Parse(Dtguias["ok", 0].Value.ToString());
                    int y = 0;
                    foreach (DataGridViewRow xx in Dtguias.Rows)
                    {
                        xx.Cells["ok"].Value = !estado;
                        Dtguias_CellContentClick(sender, new DataGridViewCellEventArgs(0, y));
                        y++;
                    }
                }
            }
        }
        private void btnseleccion_Click(object sender, EventArgs e)
        {
            Dtguias.EndEdit();
            if (Dtguias.RowCount > 0)
            {
                Boolean estado = false;
                if (Dtguias["ok", 0].Value == null)
                    estado = false;
                else
                    estado = Boolean.Parse(Dtguias["ok", 0].Value.ToString());
                int y = 0;
                foreach (DataGridViewRow xx in Dtguias.Rows)
                {
                    xx.Cells["ok"].Value = !estado;
                    Dtguias_CellContentClick(sender, new DataGridViewCellEventArgs(0, y));
                    y++;
                }
                if (!estado)
                    btnseleccion.Text = "Deseleccionar  Todos";
                else
                    btnseleccion.Text = "Seleccionar Todos";
            }
        }
        public DialogResult MSG(string cadena)
        {
            return MessageBox.Show(cadena, CompanyName, MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
        }
        private void btnReversar_Click(object sender, EventArgs e)
        {
            if (Comprobantes.Count > 0)
            {
                if (MSG("Seguro Desea Reversar") == DialogResult.OK)
                {
                    foreach (FACTURAS xx in Comprobantes)
                    {
                        CapaLogica.ReversaDeFacturas(xx.numero, xx.proveedor);
                    }
                }
            }
            else
            {
                msg("No hay Facturas Seleccionadas ");
                btnseleccion.Focus();
                return;
            }
            txtbuscar_TextChanged(sender, e);
        }

        private void Dtguias_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int x = e.RowIndex, y = e.ColumnIndex;
            if (x >= 0)
            {
                //doble click en proveedores
                if (y != Dtguias.Columns[OK.Name].Index && y != Dtguias.Columns[btnVer.Name].Index)
                {
                    Clipboard.SetText(Dtguias[y, x].Value.ToString());

                    toolTip1.Show("Copiado", this.MdiParent, MousePosition.X + 20, MousePosition.Y, 500);
                    //toolTip1.Show("Copiado", this.MdiParent,MousePosition);                   
                }
            }
        }
        TextBox txt;
        private string proveer;
        private int idmoneda;
        private void Dtguias_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            int x = Dtguias.CurrentCell.RowIndex, y = Dtguias.CurrentCell.ColumnIndex;
            txt = e.Control as TextBox;
            txt.KeyDown -= Txt_KeyDown;
            txt.KeyPress -= Txt_KeyPress;
            if (y == Dtguias.Columns[Pagox.Name].Index)
            {
                //si edito el pago
                txt.KeyDown += Txt_KeyDown;
                txt.KeyPress += Txt_KeyPress;
            }

            if (y == Dtguias.Columns[Pagox.Name].Index)
            {
                if (Dtguias[tipodoc.Name, x].Value.ToString().ToUpper() == "NCM" || Dtguias[tipodoc.Name, x].Value.ToString().ToUpper() == "NDM")
                {
                    Dtguias[y, x].ReadOnly = true;
                    Dtguias.CancelEdit();
                }
                else
                    Dtguias[y, x].ReadOnly = false;
            }
        }
        private void Txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            HPResergerFunciones.Utilitarios.SoloNumerosDecimalesX(e, txt.Text);
        }
        private void Txt_KeyDown(object sender, KeyEventArgs e)
        {
            HPResergerFunciones.Utilitarios.ValidarDinero(e, txt);
        }
        private void Dtguias_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            //int x =e.RowIndex, y = e.ColumnIndex;
            //if (y == Dtguias.Columns[Pagox.Name].Index)
            //{
            //    if ((decimal)Dtguias[Pagox.Name, x].Value > (decimal)Dtguias[Saldox.Name, x].Value)
            //    {
            //        Dtguias.CancelEdit();
            //        Dtguias[Pagox.Name, x].Value = Dtguias[Saldox.Name, x].Value;                             
            //    }
            //}
        }

        private void Dtguias_CellValidated(object sender, DataGridViewCellEventArgs e)
        {
            int x = e.RowIndex, y = e.ColumnIndex;
            if (rdbporPagar.Checked)
                if (y == Dtguias.Columns[Pagox.Name].Index)
                {
                    if (Dtguias[Pagox.Name, x].Value.ToString() == "" || (decimal)Dtguias[Pagox.Name, x].Value == 0)
                    {
                        Dtguias[Pagox.Name, x].Value = Dtguias[Saldox.Name, x].Value;

                    }
                    else
                    {
                        if (Dtguias[tipodoc.Name, e.RowIndex].Value.ToString().ToUpper().Substring(0, 2) == "NC" || Dtguias[tipodoc.Name, e.RowIndex].Value.ToString().ToUpper().Substring(0, 2) == "ND")
                            if (decimal.Parse(Dtguias[Pagox.Name, x].Value.ToString()) > decimal.Parse(Dtguias[Saldox.Name, x].Value.ToString()))
                            {
                                Dtguias[Pagox.Name, x].Value = Dtguias[Saldox.Name, x].Value;
                            }
                    }
                }
            CalcularTotal();
        }
        private void Dtguias_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            int x = e.RowIndex, y = e.ColumnIndex;
            if (x >= 0)
                if (y == Dtguias.Columns[Pagox.Name].Index)
                {
                    FACTURAS factu = Comprobantes.Find(cust => cust.numero == Dtguias[nrofactura.Name, x].Value.ToString() && cust.proveedor == Dtguias[proveedor.Name, x].Value.ToString() && cust.centrocosto == (int)Dtguias[centrocostox.Name, x].Value && cust.tipo == Dtguias[tipodoc.Name, x].Value.ToString());
                    if (factu != null)
                    {
                        factu.aPagar = Convert.ToDecimal(Dtguias[y, x].Value.ToString());
                        Dtguias.EndEdit();
                        Dtguias.RefreshEdit();
                    }
                }
        }
        private void cboempresa_Click_1(object sender, EventArgs e)
        {
            string cadena = cboempresa.Text;
            DataTable Table = CapaLogica.TablaEmpresa();
            if (Table.Rows.Count != cboempresa.Items.Count)
            {
                CapaLogica.TablaEmpresa(cboempresa);
                cboempresa.Text = cadena;
            }
        }
        private void cboempresa_SelectedValueChanged(object sender, EventArgs e)
        {

        }

        private void lblmensaje_Click(object sender, EventArgs e)
        {

        }

        private void txttotal_TextChanged(object sender, EventArgs e)
        {
            decimal ValorPagar = 0, ValorPagado = 0;
            decimal.TryParse(txttotal.Text, out ValorPagar);
            decimal.TryParse(txttotalAbonado.Text, out ValorPagado);
            //
            txtCuentaExceso.ReadOnly = true;
            if (ValorPagado > ValorPagar)
            {
                txtCuentaExceso.ReadOnly = false;
            }
        }
        frmProcesando frmproce;
        private void btnpdf_Click(object sender, EventArgs e)
        {
            if (Dtguias.RowCount > 0)
            {
                Dtguias.SuspendLayout();
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
            if (Dtguias.RowCount > 0)
            {
                string _NombreHoja = ""; string _Cabecera = ""; int[] _Columnas; string _NColumna = "";
                if (rdbPagados.Checked)
                {
                    _NombreHoja = "Documentos Pagados"; _Cabecera = "Comprobantes Pagados"; _Columnas = new int[] { 3, 4, 5, 6, 8, 9, 10, 11, 12, 14, 15, 16, 17 }; _NColumna = "m";
                }
                else
                {
                    _NombreHoja = "Documentos Impago"; _Cabecera = "Comprobantes Impago"; _Columnas = new int[] { 3, 4, 5, 6, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17 }; _NColumna = "n";
                }
                List<HPResergerFunciones.Utilitarios.RangoCelda> Celdas = new List<HPResergerFunciones.Utilitarios.RangoCelda>();
                //HPResergerFunciones.Utilitarios.RangoCelda Celda1 = new HPResergerFunciones.Utilitarios.RangoCelda("a1", "b1", "Cronograma de Pagos", 14);
                Color Back = Color.FromArgb(78, 129, 189);
                Color Fore = Color.FromArgb(255, 255, 255);
                Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda("a1", $"{_NColumna}1", _Cabecera.ToUpper(), 16, true, true, Back, Fore));
                Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda("a2", $"{_NColumna}2", NameEmpresa, 12, false, true, Back, Fore));
                //
                HPResergerFunciones.Utilitarios.EstiloCelda CeldaDefault = new HPResergerFunciones.Utilitarios.EstiloCelda(Dtguias.AlternatingRowsDefaultCellStyle.BackColor, Dtguias.AlternatingRowsDefaultCellStyle.Font, Dtguias.AlternatingRowsDefaultCellStyle.ForeColor);
                HPResergerFunciones.Utilitarios.EstiloCelda CeldaCabecera = new HPResergerFunciones.Utilitarios.EstiloCelda(Dtguias.ColumnHeadersDefaultCellStyle.BackColor, Dtguias.ColumnHeadersDefaultCellStyle.Font, Dtguias.ColumnHeadersDefaultCellStyle.ForeColor);
                int PosInicialGrilla = 3;
                //Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda("a2", "b2", "Nombre Vendedor:", 11));
                //HPResergerFunciones.Utilitarios.ExportarAExcelOrdenandoColumnas(Dtguias, "", _NombreHoja, Celdas, 2, _Columnas, new int[] { }, new int[] { });

                DataTable TableResuk = new DataTable();
                TableResuk = ((DataTable)Dtguias.DataSource).Copy();
                if (rdbPagados.Checked)
                {
                    TableResuk.Columns[FechaCancelado.Name].ColumnName = "Fecha Pagado";
                    TableResuk.Columns["pago"].ColumnName = "Pagado";
                }
                else
                {
                    TableResuk.Columns[FechaCancelado.Name].ColumnName = "Fecha Cancelado";
                    TableResuk.Columns["Pago"].ColumnName = "Pago";
                }
                HPResergerFunciones.Utilitarios.ExportarAExcelOrdenandoColumnas(TableResuk, CeldaCabecera, CeldaDefault, "", _NombreHoja, Celdas, PosInicialGrilla, _Columnas, new int[] { }, new int[] { }, "");

                //HPResergerFunciones.Utilitarios.ExportarAExcelOrdenandoColumnas(dtgconten, "", "Cronograma de Pagos", Celdas, 2, new int[] { 1, 2, 3, 4, 5, 6 }, new int[] { }, new int[] { });
            }
            else msg("No hay Registros en la Grilla");
        }
        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            Cursor = Cursors.Default;
            frmproce.Close();
            Dtguias.ResumeLayout();
        }
        public void ListarPagados(Boolean a)
        {
            if (a)
            {
                Dtguias.Columns[FechaCancelado.Name].HeaderText = "Fecha Pagado";
                Dtguias.Columns[Pagox.Name].HeaderText = "Pagado";
                Dtguias.Columns[OK.Name].Visible = false;
                Dtguias.Columns[btnVer.Name].Visible = false;
                Dtguias.Columns[Saldox.Name].Visible = false;
                Dtguias.Columns[xtc.Name].Visible = false;
                Dtguias.Columns[Pagox.Name].ReadOnly = true;
                btnseleccion.Visible = false;
                btnaceptar.Enabled = false;
                txtbuscar_TextChanged(new object { }, new EventArgs());
            }
            else
            {
                Dtguias.Columns[FechaCancelado.Name].HeaderText = "Fecha Cancelado";
                Dtguias.Columns[Pagox.Name].HeaderText = "Pago";
                Dtguias.Columns[btnVer.Name].Visible = true;
                Dtguias.Columns[Saldox.Name].Visible = true;
                Dtguias.Columns[xtc.Name].Visible = true;
                Dtguias.Columns[OK.Name].Visible = true;
                btnseleccion.Visible = true;
                Dtguias.Columns[Pagox.Name].ReadOnly = false;
                txtbuscar_TextChanged(new object { }, new EventArgs());
            }
        }
        private void rdbporPagar_CheckedChanged(object sender, EventArgs e)
        {
            if (this.ActiveControl == rdbPagados) ListarPagados(true);
            else ListarPagados(false);
        }
        private void dtpFechaPago_ValueChanged(object sender, EventArgs e)
        {
            SacarTipoCambio();
        }
        frmTipodeCambio frmtipo;
        public void SacarTipoCambio()
        {
            DateTime FechaValidaBuscar = dtpFechaPago.Value;
            txttipocambio.Text = CapaLogica.TipoCambioDia("Venta", FechaValidaBuscar).ToString("n3");
            if (txttipocambio.Text == "0.000")
            {
                if (frmtipo == null)
                {
                    frmtipo = new frmTipodeCambio();
                    frmtipo.Show();
                    frmtipo.comboMesAño1.ActualizarMesAÑo(FechaValidaBuscar.Month.ToString(), FechaValidaBuscar.Year.ToString());
                    frmtipo.Buscar_Click(new object(), new EventArgs());
                    frmtipo.BusquedaExterna = false;
                    frmtipo.Hide();
                    if (frmtipo.BusquedaExterna)
                    {
                        frmtipo.Close();
                        frmtipo = null;
                        SacarTipoCambio();
                    }
                }
            }
        }

        private void txttipocambio_TextChanged(object sender, EventArgs e)
        {
            CalcularDiferencial();
        }
        private void btnRefrescar_Click(object sender, EventArgs e)
        {
            CartelDeEspera();
            Application.DoEvents();
            Cursor = Cursors.WaitCursor;
            ActualizarTablas();
            Cursor = Cursors.Default;
            frmproce.Close();
            btnRefrescar.Enabled = true;
            FacturasSeleccionas();
        }
        frmListarFacturasPagadas FormListarFacturasPagadas;
        private void btnVerPagados_Click(object sender, EventArgs e)
        {
            if (FormListarFacturasPagadas == null)
            {
                FormListarFacturasPagadas = new frmListarFacturasPagadas();
                FormListarFacturasPagadas.MdiParent = this.MdiParent;
                FormListarFacturasPagadas.FormClosed += FormListarFacturasPagadas_FormClosed;
                FormListarFacturasPagadas.Show();
            }
            else FormListarFacturasPagadas.Activate();
        }

        private void FormListarFacturasPagadas_FormClosed(object sender, FormClosedEventArgs e)
        {
            FormListarFacturasPagadas = null;
        }

        private void txtCuentaExceso_TextChanged(object sender, EventArgs e)
        {
            DataTable Table = CapaLogica.BuscarCuentas(txtCuentaExceso.Text, 1);
            if (Table.Rows.Count > 0)
            {
                txtDescripcionCuentaExceso.Text = (Table.Rows[0][0].ToString());
            }
            else
            {
                txtDescripcionCuentaExceso.CargarTextoporDefecto();
            }
        }

        private void txtCuentaExceso_DoubleClick(object sender, EventArgs e)
        {
            BuscarCuentas();
        }
        public void BuscarCuentas()
        {
            frmlistarcuentas cuentitas = new frmlistarcuentas();
            cuentitas.Txtbusca.Text = txtCuentaExceso.Text;
            cuentitas.radioButton1.Checked = true;
            cuentitas.ShowDialog();
            if (cuentitas.aceptar)
            {
                txtCuentaExceso.Text = cuentitas.codigo;
            }
        }
        private void btnbuscarCuentas_Click(object sender, EventArgs e)
        {
            BuscarCuentas();
        }

        private void txtCuentaExceso_ReadOnlyChanged(object sender, EventArgs e)
        {
            btnbuscarCuentas.Enabled = !txtCuentaExceso.ReadOnly;
        }

        private void cboproyecto_Click(object sender, EventArgs e)
        {
            DataTable table = CapaLogica.ListarProyectosEmpresa(cboempresa.SelectedValue.ToString());
            if (table.Rows.Count != cboproyecto.Items.Count)
            {
                cboproyecto.DataSource = table;
                cboproyecto.DisplayMember = "proyecto";
                cboproyecto.ValueMember = "id_proyecto";
            }
        }
    }
}
