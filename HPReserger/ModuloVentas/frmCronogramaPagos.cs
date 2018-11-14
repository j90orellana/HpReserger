using HpResergerUserControls;
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
    public partial class frmCronogramaPagos : FormGradient
    {
        public frmCronogramaPagos()
        {
            InitializeComponent();
        }
        HPResergerCapaLogica.HPResergerCL CapaLogica = new HPResergerCapaLogica.HPResergerCL();
        private void frmCronogramaPagos_Load(object sender, EventArgs e)
        {
            //ModoEdicion(false);
            DataTable TDatos = CapaLogica.CronogramaVtaDetalle(0);

            dtgconten.DataSource = TDatos;
            Estado = 0;
            txtnumcot.CargarTextoporDefecto();
            dtpabono.Value = DateTime.Now;
            dtpfecha.Value = DateTime.Now.AddMonths(1);
            txtnumcot_TextChanged(sender, e);
        }
        public string Monedita;
        public void CargarMoneda(ComboBox cbo)
        {
            DataTable TMoneda = CapaLogica.InsertarActualizarMoneda();
            cbo.DisplayMember = "descripcion";
            cbo.ValueMember = "codigo";
            cbo.DataSource = TMoneda;
        }
        private void btnbuscoti_Click(object sender, EventArgs e)
        {
            frmlistarSeparacionVta frmlissep = new frmlistarSeparacionVta();
            frmlissep.NumCot = int.Parse(txtnumcot.Text);
            frmlissep.Nombre = "Lista Cotizaciones para el Cronograma de Pagos";
            frmlissep.Estado = 2;////Estado 2 para no mostrar los dias a caducar
            frmlissep.ShowDialog();
            if (frmlissep.NumCot != 0) { txtnumcot.Text = frmlissep.NumCot.ToString(); }
        }
        public void ModoEdicion(Boolean a)
        {
            btnprocesar.Enabled = a;
            panelllenado.Enabled = a;
            txtvalorcuota.ReadOnly = !a;
            txtvalnrocuotas.ReadOnly = !a;
            btnlimpiar.Enabled = a;
        }
        int estado = 0;
        Boolean Encontrado = false;
        public int _moneda { get; set; }

        public int Estado
        {
            get { return estado; }
            set
            {
                if (value == 1)
                {
                    btnaceptar.Enabled = btnprocesar.Enabled = btnlimpiar.Enabled = true;
                }
                else
                {
                    btnprocesar.Enabled = btnaceptar.Enabled = btnlimpiar.Enabled = false;
                }
                estado = value;
            }
        }
        private void txtnumcot_TextChanged(object sender, EventArgs e)
        {
            lbldato.Text = "";
            Estado = 0;
            Encontrado = false;
            LimpiarControles(txtdireccion, txtemail, txtnombre, txtobservacion, txtocupacion, txttelcelular, txttelfijo, txttipoid, txtnroid, txtNombreVendedor, txtcodvendedor, txtimporte, txtdocpago, txttipocambio, txtvalinicial, txtvalorcuota, txtabonado, txtvaltotal, txtvalnrocuotas, txtsaldo, txtvalorcuota, txtvalnrocuotas);
            btnminuta.Visible = btncontrato.Visible = false;
            LimpiarControles(txtdiferencia, txtcuotapagar);
            LimpiarControles(txttipocambioabonado);
            ModoEdicion(false);
            lkldocpago.Enabled = false; txttiporef.ReadOnly = false;
            ((DataTable)(dtgconten.DataSource)).Clear();
            ////FotoDocpago = null;   
            dtpfecha.Enabled = true;
            dtpabono.Value = DateTime.Now;
            dtpfecha.Value = DateTime.Now.AddMonths(1);
            btnminuta.Visible = btncontrato.Visible = false;
            ////dtgconten.DataSource = CapaLogica.SeparacionVenta(0).Clone();
            if (txtnumcot.EstaLLeno())
            {
                ////datos de la cotizacion, cliente y tipoid
                DataTable Tdatos = CapaLogica.SeparacionVenta(50, int.Parse(txtnumcot.Text));
                if (Tdatos.Rows.Count != 0)
                {
                    Encontrado = true;
                    DataRow filita = Tdatos.Rows[0];
                    txttipoid.Text = filita["Desc_Tipo_ID"].ToString();
                    txtnroid.Text = filita["Nro_Id_Cli"].ToString();
                    txtdireccion.Text = filita["Direccion"].ToString();
                    txtemail.Text = filita["E_mail"].ToString();
                    txtnombre.Text = filita["nombres"].ToString();
                    txtocupacion.Text = filita["Ocupacion"].ToString();
                    txttelcelular.Text = filita["Telf_Celular"].ToString();
                    txttelfijo.Text = filita["Telf_Fijo"].ToString();
                    txtcodvendedor.Text = filita["Cod_Vend"].ToString();
                    txtNombreVendedor.Text = Configuraciones.MayusculaCadaPalabra(filita["vendedor"].ToString());
                    txtobservacion.Text = filita["Observaciones"].ToString();
                    txtvalinicial.Text = Configuraciones.ReturnDecimal(filita["ValorInicial"].ToString());
                    txtabonado.Text = Configuraciones.ReturnDecimal(filita["abonado"].ToString());
                    txtvaltotal.Text = Configuraciones.ReturnDecimal(filita["importetotal"].ToString());
                    txtdeudatotal.Text = txtsaldo.Text = Configuraciones.ReturnDecimal(filita["saldo"].ToString());
                    txtmonedaabono.Text = txtmoneda.Text = filita["moneda"].ToString();
                    _moneda = (int)filita["idmoneda"];
                    txttipocambioabonado.Text = Configuraciones.ReturnDecimal(filita["TC_Referencial"].ToString());
                    ModoEdicion(true);
                    if (Decimal(txtabonado.Text) >= Decimal(txtvalinicial.Text)) { btnminuta.Visible = btncontrato.Visible = true; }
                    Estado = (int)filita["TieneCronograma"];
                    ////Cargamos el Cronograma de Pago
                    if (estado == 0)
                    {
                        lbldato.Text = "Ya tiene un Cronograma de Pago";
                        DataTable TDatos = CapaLogica.CronogramaVtaDetalle(int.Parse(txtnumcot.Text));
                        dtgconten.DataSource = TDatos;
                        txtvalnrocuotas.Text = (dtgconten.RowCount).ToString();
                        txtvalorcuota.Text = ((decimal)(TDatos.Rows[dtgconten.RowCount - 1])["valor"]).ToString("n2");
                        decimal total = 0;
                        foreach (DataRow item in TDatos.Rows)
                            total += (decimal)item["valor"];
                        txtcuotapagar.Text = total.ToString("n2");
                        dtpfecha.Value = (DateTime)TDatos.Rows[0]["vence"];
                        dtpfecha.Enabled = false;
                        txttiporef.ReadOnly = true;
                        txtvalnrocuotas.ReadOnly = txtvalorcuota.ReadOnly = true;
                    }
                }
            }
        }
        public void CargarDatos()
        {
            ((DataTable)(dtgconten.DataSource)).Clear();
            if (decimal.Parse(txtvalnrocuotas.Text) > 0 && txtvalnrocuotas.TextLength <= 4)
            {
                dtgconten.Rows.Add(int.Parse(txtvalnrocuotas.Text));
                foreach (DataGridViewRow item in dtgconten.Rows)
                {
                    item.Cells[idregistro.Name].Value = item.Index + 1;
                    item.Cells[NroCotizacion.Name].Value = int.Parse(txtnumcot.Text).ToString("0000");
                    item.Cells[NroCuota.Name].Value = item.Index + 1;
                    item.Cells[VencimientoPago.Name].Value = dtpfecha.Value.AddMonths(item.Index);
                    if (item.Index == 0)
                    { /////nro cuotas   
                        if (!txtvalorcuota.ReadOnly)
                            item.Cells[importe.Name].Value = Decimal(txtvalorcuota.Text);
                        else
                            //monto
                            item.Cells[importe.Name].Value = Decimal(txtvalorcuota.Text) + Decimal(txtdiferencia.Text);
                    }
                    else if (item.Index == int.Parse(txtvalnrocuotas.Text) - 1)
                    {
                        if (!txtvalorcuota.ReadOnly)
                            if (Decimal(txtdiferencia.Text) > 0)
                                item.Cells[importe.Name].Value = Decimal(txtdiferencia.Text);
                            else
                                item.Cells[importe.Name].Value = Decimal(txtvalorcuota.Text) + Decimal(txtdiferencia.Text);
                        else
                            item.Cells[importe.Name].Value = Decimal(txtvalorcuota.Text);
                    }
                    else
                    {
                        item.Cells[importe.Name].Value = Decimal(txtvalorcuota.Text);
                    }
                }
                lblmsg.Text = $"Total de Registros: {dtgconten.RowCount}";
            }
        }
        private void LimpiarControles(params object[] control)
        {
            foreach (object item in control)
            {
                if (((Control)item).AccessibilityObject.Role == AccessibleRole.ComboBox)
                    ((ComboBoxPer)item).SelectedIndex = -1;
                else
                {
                    ((TextBoxPer)item).CargarTextoporDefecto();
                }
            }
        }
        public static decimal Decimal(string cadena)
        {
            try
            {
                if (cadena == "" || cadena == "." || cadena == ",") cadena = "0";
                return decimal.Parse(cadena);
            }
            catch (Exception) { return 0; }
        }
        private void txtsaldo_TextChanged(object sender, EventArgs e)
        {
            decimal deuda = 0;
            deuda = Decimal(txtsaldo.Text) - Decimal(txtimporte.Text);
            if (deuda < 0)
            {
                msg("No se Puede Abonar más de la Deuda");
                txtimporte.Text = txtsaldo.Text;
                txtimporte.Focus();
                deuda = 0;
            }
            txtdeudatotal.Text = deuda.ToString("n2");
        }
        private void btnprocesar_Click(object sender, EventArgs e)
        {
            decimal valcal = 0;
            //btnminuta.Visible = btncontrato.Visible = false;
            btnprocesar.Enabled = true;
            if (Decimal(txtdeudatotal.Text) > 0)
            {
                if (!txtvalorcuota.ReadOnly && txtvalorcuota.EstaLLeno())
                {
                    valcal = Decimal(txtdeudatotal.Text) / Decimal(txtvalorcuota.Text);
                    txtvalnrocuotas.Text = valcal.ToString("n0");
                    txtcuotapagar.Text = (Decimal(txtvalnrocuotas.Text) * Decimal(txtvalorcuota.Text)).ToString("n2");
                    if (Decimal(txtdeudatotal.Text) != Decimal(txtcuotapagar.Text))
                    {
                        txtdiferencia.Text = (Decimal(txtdeudatotal.Text) - Decimal(txtcuotapagar.Text)).ToString("n2");
                        if (Decimal(txtdiferencia.Text) > 0)
                        {
                            txtvalnrocuotas.Text = (decimal.Parse(txtvalnrocuotas.Text) + 1).ToString("n0");
                        }
                    }
                }
                else if (!txtvalnrocuotas.ReadOnly && txtvalnrocuotas.EstaLLeno())
                {
                    valcal = Decimal(txtdeudatotal.Text) / Decimal(txtvalnrocuotas.Text);
                    txtvalorcuota.Text = valcal.ToString("n2");
                    txtcuotapagar.Text = (Decimal(txtvalorcuota.Text) * Decimal(txtvalnrocuotas.Text)).ToString("n2");
                    if (txtdeudatotal.Text != txtcuotapagar.Text)
                    {
                        txtdiferencia.Text = (Decimal(txtdeudatotal.Text) - Decimal(txtcuotapagar.Text)).ToString("n2");
                    }
                }
                CargarDatos();
            }
            else
            {
                btnprocesar.Enabled = false;
                txtvalorcuota.ReadOnly = txtvalnrocuotas.ReadOnly = true;
                //if (Encontrado)
                //    btnminuta.Visible = btncontrato.Visible = true;
            }
            if (Decimal(txtvalnrocuotas.Text) > 999) msg("No Puede Haber más de 1000 Cuotas");
        }
        public void msg(string cadena)
        {
            HPResergerFunciones.Utilitarios.msg(cadena);
        }
        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            ((DataTable)(dtgconten.DataSource)).Clear();
            txtvalnrocuotas.CargarTextoporDefecto();
            txtvalorcuota.CargarTextoporDefecto();
            txtdiferencia.Text = txtcuotapagar.Text = "0.00";
            btnprocesar_Click(sender, e);
        }
        private void txtvalorcuota_Click(object sender, EventArgs e)
        {
            if (Decimal(txtdeudatotal.Text) > 0 && estado == 1)
            {
                txtvalnrocuotas.ReadOnly = true;
                txtvalorcuota.ReadOnly = false;
            }
        }
        private void txtvalnrocuotas_Click(object sender, EventArgs e)
        {
            if (Decimal(txtdeudatotal.Text) > 0 && estado == 1)
            {
                txtvalnrocuotas.ReadOnly = false;
                txtvalorcuota.ReadOnly = true;
            }
        }
        MemoryStream _memoryStream = new MemoryStream();
        byte[] FotoDocpago;
        private void btnimagendoc_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialogoAbrirArchivoContrato = new OpenFileDialog();
            dialogoAbrirArchivoContrato.Filter = "Pdf Files|*.pdf";
            dialogoAbrirArchivoContrato.DefaultExt = ".pdf";
            if (dialogoAbrirArchivoContrato.ShowDialog(this) == DialogResult.OK)
            {
                txtdocpago.Text = dialogoAbrirArchivoContrato.FileName.ToString();
                _memoryStream.Position = 0;
                _memoryStream.SetLength(0);
                _memoryStream.Capacity = 0;
                lkldocpago.Enabled = true;
                FotoDocpago = File.ReadAllBytes(dialogoAbrirArchivoContrato.FileName);
            }
        }
        private void lkldocpago_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (FotoDocpago != null)
            {
                int K = FotoDocpago.Length;
                frmVerPdf VerPdf = new frmVerPdf();
                string Ruta = Application.CommonAppDataPath + @"\temp.pdf";
                try
                {
                    FileStream RutaArchivo = new FileStream(Ruta, FileMode.Create, FileAccess.ReadWrite);
                    RutaArchivo.Write(FotoDocpago, 0, K);
                    RutaArchivo.Close();
                    VerPdf.MdiParent = MdiParent;
                    VerPdf.Icon = Icon;
                    VerPdf.ruta = Ruta;
                    VerPdf.nombreformulario = " Documento de Pago Extra -" + txtnombre.Text;
                    VerPdf.Show();
                    File.Delete(Ruta);
                }
                catch (Exception ex) { msg(ex.Message); }
            }
        }
        private void btncancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        frmProcesando frmproce;
        private void btnpdf_Click(object sender, EventArgs e)
        {
            if (dtgconten.RowCount > 0)
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
        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            Cursor = Cursors.Default;
            frmproce.Close();
        }
        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            if (dtgconten.RowCount > 0)
            {
                string _NombreHoja = "Cronograma de Pagos";
                List<HPResergerFunciones.Utilitarios.RangoCelda> Celdas = new List<HPResergerFunciones.Utilitarios.RangoCelda>();
                //HPResergerFunciones.Utilitarios.RangoCelda Celda1 = new HPResergerFunciones.Utilitarios.RangoCelda("a1", "b1", "Cronograma de Pagos", 14);
                Color Back = Color.FromArgb(78, 129, 189);
                Color Fore = Color.FromArgb(255, 255, 255);
                Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda("a1", "d1", "CRONOGRAMA DE PAGOS", 16, true, true, Back, Fore));
                //Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda("a2", "b2", "Nombre Vendedor:", 11));
                //Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda("c2", "e2", txtNombreVendedor.Text, 11));
                Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda("a2", "d2", "Datos del Cliente", 11, true, Back, Fore));
                //Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda("a3", "a3", txttipoid.Text, 11));
                //Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda("b3", "b3", "'" + txtnroid.Text, 11));
                //Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda("c3", "c3", "e-mail:", 11));
                //Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda("d3", "e3", txtemail.Text, 11));
                Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda("c3", "c3", "Nro Cotización:", 11));
                Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda("d3", "d3", "'" + txtnumcot.Text, 11));
                Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda("a3", "b3", txtnombre.Text, 11));
                //Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda("a6", "a6", "Tel.Celular:", 11));
                //Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda("b6", "b6", "'" + txttelcelular.Text, 11));
                //Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda("d6", "d6", "Tel.Fijo:", 11));
                //Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda("e6", "e6", "'" + txttelfijo.Text, 11));    
                Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda("a4", "d4", "Resumen Cotización", 11, true, Back, Fore));
                Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda("a5", "a5", "Total:", 11));
                Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda("b5", "b5", "'" + txtvaltotal.Text, 11));
                Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda("c5", "c5", "Val.Inicial:", 11));
                Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda("d5", "d5", "'" + txtvalinicial.Text, 11));
                //////////
                Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda("a6", "a6", "Abonado:", 11));
                Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda("b6", "b6", "'" + txtabonado.Text, 11));
                Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda("c6", "c6", "Saldo:", 11));
                Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda("d6", "d6", "'" + txtsaldo.Text, 11));
                Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda("a7", "d7", "Abono Extra", 11, true, Back, Fore));
                //////////
                Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda("a8", "a8", "Mon.Abonado:", 11));
                Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda("b8", "b8", "'" + txtimporte.Text, 11));
                Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda("c8", "c8", "'" + txtmonedaabono.Text, 11));
                //Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda("d8", "d8", "T.C.:" + txttipocambio.Text + " *", 11));
                Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda("a9", "d9", "Detalle de Pagos", 11, true, Back, Fore));
                //////////
                Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda("a10", "a10", "DeudaTotal:", 11));
                Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda("b10", "b10", "'" + txtdeudatotal.Text, 11));
                Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda("c10", "c10", "FechaAbono:", 11));
                Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda("d10", "d10", dtpfecha.Value.ToShortDateString(), 11));
                //////////
                Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda("a11", "a11", "ValorCuotas:", 11));
                Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda("b11", "b11", "'" + txtvalorcuota.Text, 11));
                Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda("c11", "c11", "NroCuotas:", 11));
                Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda("d11", "d11", "'" + txtvalnrocuotas.Text, 11));
                ///////////
                //Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda("a12", "d12", "*Nota: El Importe en ME es referencia la tipo de cambio", 9, false, null, Color.Red));
                ///
                HPResergerFunciones.Utilitarios.ExportarAExcelOrdenandoColumnas(dtgconten, "", _NombreHoja, Celdas, 11, new int[] { 2, 4, 0, 5 }, new int[] { }, new int[] { });
                //HPResergerFunciones.Utilitarios.ExportarAExcelOrdenandoColumnas(dtgconten, "", "Cronograma de Pagos", Celdas, 2, new int[] { 1, 2, 3, 4, 5, 6 }, new int[] { }, new int[] { });
            }
            else msg("No hay Registros en la Grilla");
        }
        private void btncontrato_Click(object sender, EventArgs e)
        {
            msg("Proceso del Contrato de Venta");
        }
        private void btnminuta_Click(object sender, EventArgs e)
        {
            msg("Proceso de la Minuta");
        }
        private void btnlimpiarabono_Click(object sender, EventArgs e)
        {
            FotoDocpago = null;
            txtimporte.CargarTextoporDefecto();
            txtdocpago.CargarTextoporDefecto();
            lkldocpago.Enabled = false;
        }
        private void btnaceptar_Click(object sender, EventArgs e)
        {
            if (Estado == 1)
            {
                if (Decimal(txtimporte.Text) < 0)
                {
                    txtimporte.Focus();
                    msg("No Se puede Ingresar Valores Menores a Cero");
                    return;
                }
                if (txtimporte.EstaLLeno())
                {
                    if (!txtdocpago.EstaLLeno() || FotoDocpago == null)
                    {
                        btnimagendoc.Focus();
                        msg("Ingrese El Documento de pago");
                        return;
                    }
                }
                if (txtdocpago.EstaLLeno() || FotoDocpago != null)
                {
                    if (!txtimporte.EstaLLeno())
                    {
                        txtimporte.Focus();
                        msg("Ingrese el Monto del Importe");
                        return;
                    }
                }
                if (Decimal(txtdeudatotal.Text) != 0)
                {
                    if (Decimal(txtvalnrocuotas.Text) > 999)
                    {
                        txtvalnrocuotas.Focus();
                        msg("No Puede Haber más de 1000 Cuotas");
                        return;
                    }
                    if (!txtvalorcuota.EstaLLeno())
                    {
                        txtvalorcuota.Focus();
                        msg("Ingrese Valor de la Cuota");
                        return;
                    }
                    if (!txtvalnrocuotas.EstaLLeno())
                    {
                        txtvalnrocuotas.Focus();
                        msg("Ingrese El Número de Cuotas");
                        return;
                    }
                }
                if (HPResergerFunciones.Utilitarios.msgp("Seguro Desea Grabar el Cronograma de Pagos") == DialogResult.Yes)
                {
                    string cadena = "";
                    var NumCot = int.Parse(txtnumcot.Text);
                    if (Decimal(txtimporte.Text) > 0)
                    {
                        //proceso de guardar el abono extra
                        CapaLogica.SeparacionVenta(11, NumCot, decimal.Parse(txtimporte.Text), Decimal(txttipocambio.Text), _moneda, FotoDocpago, txtdocpago.Text, dtpabono.Value, frmLogin.CodigoUsuario);
                        cadena = "Abono Extra Guardado";
                    }//proceso de Grabar el Cronograma de pagos cabecera
                    CapaLogica.CronogramaVtaCabecera(1, NumCot, Decimal(txtdeudatotal.Text), _moneda, Decimal(txttiporef.Text), int.Parse(txtvalnrocuotas.Text), frmLogin.CodigoUsuario);
                    ////Cambio El estado de la Cotizacion a Vendido

                    DataRow fila = CapaLogica.CronogramaVtaCabecera(NumCot).Rows[0];
                    int idCronograma = (int)fila["Id_Cron_Cab"];
                    //proceso de Grabar el Cronograma de pagos detalle
                    foreach (DataGridViewRow item in dtgconten.Rows)
                        CapaLogica.CronogramaVtaDetalle(1, idCronograma, NumCot, (int)item.Cells[NroCuota.Name].Value, (DateTime)item.Cells[VencimientoPago.Name].Value, (decimal)item.Cells[importe.Name].Value, _moneda, null, FotoDocpago, txtdocpago.Text, DateTime.Now, frmLogin.CodigoUsuario);
                    msg(cadena + "\nCronograma de Pagos Guardado");
                    ////Actualizo el numcot
                    txtnumcot_TextChanged(sender, e);
                }
            }
            else msg("No hay que Guardar");
        }
    }
}
