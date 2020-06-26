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

namespace HPReserger.ModuloContable
{
    public partial class frmAddFormato82 : FormGradient
    {
        private int Estado = 0;
        public frmAddFormato82()
        {
            InitializeComponent();
        }
        HPResergerCapaLogica.HPResergerCL CapaLogica = new HPResergerCapaLogica.HPResergerCL();
        public int Empresa;
        public int idComprobante;
        public string Ruc;
        public string SerieFac;
        public string NumFac;
        public DateTime Periodo;
        public int AnioDua;
        public string RazonSocial;
        //
        public string NameDocumento;
        private bool Encontrado;
        private bool Cargado;

        private void frmAddFormato82_Load(object sender, EventArgs e)
        {
            //dtgconten11al21.Focus();
            //dtgconten1al10.Focus();
            //dtgconten22al36.Focus();
            txtNumDocumento.Text = SerieFac + "-" + NumFac;
            txtruc.Text = Ruc;
            txtNameDocumento.Text = NameDocumento;
            txtRazonSocial.Text = RazonSocial;
            ModoEdicion(false);
            PintarColumnas();
            Cargado = true;
            CargarDatos();
            //CapaLogica.FormatodeCompras8_1_Masivo();
        }
        private void PintarColumnas()
        {
            Color Amarillo = Configuraciones.AmarilloUI;
            Color Azul = Configuraciones.AzulUI;
            Color Verde = Configuraciones.VerdeUI;
            Color Blanco = Configuraciones.BlancoUI;
            //Amarillas            
            xPeriodo.HeaderCell.Style.BackColor = Amarillo;
            xTipoComprobantePago.HeaderCell.Style.BackColor = Amarillo;
            xSerieComprobantePago.HeaderCell.Style.BackColor = Amarillo;
            xAñoDua.HeaderCell.Style.BackColor = Amarillo;
            xNumeroComprobantePago.HeaderCell.Style.BackColor = Amarillo;
            xDocumentoBeneficiario.HeaderCell.Style.BackColor = Amarillo;
            xRazonSocialBeneficiario.HeaderCell.Style.BackColor = Amarillo;
            xPeriodo.HeaderCell.Style.ForeColor = Color.Black;
            xTipoComprobantePago.HeaderCell.Style.ForeColor = Color.Black;
            xSerieComprobantePago.HeaderCell.Style.ForeColor = Color.Black;
            xAñoDua.HeaderCell.Style.ForeColor = Color.Black;
            xNumeroComprobantePago.HeaderCell.Style.ForeColor = Color.Black;
            xDocumentoBeneficiario.HeaderCell.Style.ForeColor = Color.Black;
            xRazonSocialBeneficiario.HeaderCell.Style.ForeColor = Color.Black;
            //Azules
            xFechaEmision.HeaderCell.Style.BackColor = Azul;
            xTipoComprobante.HeaderCell.Style.BackColor = Azul;
            xSerieComprobante.HeaderCell.Style.BackColor = Azul;
            xNumeroComprobante.HeaderCell.Style.BackColor = Azul;
            xValorAdquisiciones.HeaderCell.Style.BackColor = Azul;
            xCodigoMoneda.HeaderCell.Style.BackColor = Azul;
            xTipoCambio.HeaderCell.Style.BackColor = Azul;
            xRazonSocialSujeto.HeaderCell.Style.BackColor = Azul;
            xDocumentoSujeto.HeaderCell.Style.BackColor = Azul;
            //Verde
            xImporteTotal.HeaderCell.Style.BackColor = Verde;
            xDomicilioSujeto.HeaderCell.Style.BackColor = Verde;
            //Blancos
            xNumeroCorrelativo.HeaderCell.Style.BackColor = Blanco;
            xSecuencia.HeaderCell.Style.BackColor = Blanco;
            xOtrosComprobantes.HeaderCell.Style.BackColor = Blanco;
            xMontoRetencion.HeaderCell.Style.BackColor = Blanco;
            xPaisSujeto.HeaderCell.Style.BackColor = Blanco;
            xPaisBeneficiario.HeaderCell.Style.BackColor = Blanco;
            xVinculo.HeaderCell.Style.BackColor = Blanco;
            xRentaBruta.HeaderCell.Style.BackColor = Blanco;
            xDeducciones.HeaderCell.Style.BackColor = Blanco;
            xRentaNeta.HeaderCell.Style.BackColor = Blanco;
            xTasaRetencion.HeaderCell.Style.BackColor = Blanco;
            xImpuestoRetenido.HeaderCell.Style.BackColor = Blanco;
            xConvenios.HeaderCell.Style.BackColor = Blanco;
            xExoneracion.HeaderCell.Style.BackColor = Blanco;
            xTipoRenta.HeaderCell.Style.BackColor = Blanco;
            xModalidad.HeaderCell.Style.BackColor = Blanco;
            xAplicación.HeaderCell.Style.BackColor = Blanco;
            xEstado.HeaderCell.Style.BackColor = Blanco;
            //
            xNumeroCorrelativo.HeaderCell.Style.ForeColor = Color.Black;
            xSecuencia.HeaderCell.Style.ForeColor = Color.Black;
            xOtrosComprobantes.HeaderCell.Style.ForeColor = Color.Black;
            xMontoRetencion.HeaderCell.Style.ForeColor = Color.Black;
            xPaisSujeto.HeaderCell.Style.ForeColor = Color.Black;
            xPaisBeneficiario.HeaderCell.Style.ForeColor = Color.Black;
            xVinculo.HeaderCell.Style.ForeColor = Color.Black;
            xRentaBruta.HeaderCell.Style.ForeColor = Color.Black;
            xDeducciones.HeaderCell.Style.ForeColor = Color.Black;
            xRentaNeta.HeaderCell.Style.ForeColor = Color.Black;
            xTasaRetencion.HeaderCell.Style.ForeColor = Color.Black;
            xImpuestoRetenido.HeaderCell.Style.ForeColor = Color.Black;
            xConvenios.HeaderCell.Style.ForeColor = Color.Black;
            xExoneracion.HeaderCell.Style.ForeColor = Color.Black;
            xTipoRenta.HeaderCell.Style.ForeColor = Color.Black;
            xModalidad.HeaderCell.Style.ForeColor = Color.Black;
            xAplicación.HeaderCell.Style.ForeColor = Color.Black;
            xEstado.HeaderCell.Style.ForeColor = Color.Black;
        }
        private void CargarTextosxDefecto()
        {

        }
        public void ModoEdicion(Boolean v)
        {
            //botones
            btnmodificar.Enabled = !v;
            btnAceptar.Enabled = v;
            //textbox
            dtgconten11al21.Enabled = v;
            dtgconten1al10.Enabled = v;
            dtgconten22al36.Enabled = v;
        }
        private void btnmodificar_Click(object sender, EventArgs e)
        {
            ModoEdicion(true);
            Estado = 2;
        }
        private void btncancelar_Click(object sender, EventArgs e)
        {
            if (Estado != 0)
            {
                Estado = 0;
                ModoEdicion(false);
                CargarDatos();
            }
            else this.Close();
        }

        public void CargarDatos()
        {
            if (Cargado)
            {
                DataTable TDatos = CapaLogica.FormatodeCompras8_2(Empresa, Periodo, idComprobante, SerieFac, AnioDua, NumFac, Ruc, RazonSocial);
                if (TDatos.Rows.Count != 0)
                {
                    Encontrado = true;
                    DataTable Tabla1al10 = TDatos.Copy();
                    DataTable Tabla11al21 = TDatos.Copy();
                    DataTable Tabla22al36 = TDatos.Copy();
                    //
                    QuitarColumnas(Tabla1al10, xTipoComprobantePago, xSerieComprobantePago, xAñoDua, xNumeroComprobantePago, xMontoRetencion, xCodigoMoneda, xTipoCambio, xPaisSujeto, xRazonSocialSujeto,
                        xDomicilioSujeto, xDocumentoSujeto, xDocumentoBeneficiario, xRazonSocialBeneficiario, xPaisBeneficiario, xVinculo, xRentaBruta, xDeducciones, xRentaNeta, xTasaRetencion, xImpuestoRetenido,
                        xConvenios, xExoneracion, xTipoRenta, xModalidad, xAplicación, xEstado);
                    QuitarColumnas(Tabla11al21, xpkempresa, xPeriodo, xNumeroCorrelativo, xSecuencia, xFechaEmision, xTipoComprobante, xSerieComprobante, xNumeroComprobante, xValorAdquisiciones,
                        xOtrosComprobantes, xImporteTotal, xDocumentoBeneficiario, xRazonSocialBeneficiario, xPaisBeneficiario, xVinculo, xRentaBruta, xDeducciones, xRentaNeta,
                        xTasaRetencion, xImpuestoRetenido, xConvenios, xExoneracion, xTipoRenta, xModalidad, xAplicación, xEstado);
                    QuitarColumnas(Tabla22al36, xpkempresa, xPeriodo, xNumeroCorrelativo, xSecuencia, xFechaEmision, xTipoComprobante, xSerieComprobante, xNumeroComprobante, xValorAdquisiciones,
                        xOtrosComprobantes, xImporteTotal, xTipoComprobantePago, xSerieComprobantePago, xAñoDua, xNumeroComprobantePago, xMontoRetencion, xCodigoMoneda, xTipoCambio, xPaisSujeto,
                        xRazonSocialSujeto, xDomicilioSujeto, xDocumentoSujeto);
                    //
                    dtgconten1al10.DataSource = Tabla1al10;
                    dtgconten11al21.DataSource = Tabla11al21;
                    dtgconten22al36.DataSource = Tabla22al36;

                }
                else
                {
                    CargarTextosxDefecto();
                    Encontrado = false;
                }
            }
        }

        private void QuitarColumnas(DataTable tabla1al10, params DataGridViewColumn[] ListadoColumnas)
        {
            foreach (var item in ListadoColumnas)
                tabla1al10.Columns.Remove(item.DataPropertyName);
        }
        public void msgError(string cadena) { HPResergerFunciones.frmInformativo.MostrarDialogError(cadena); }
        public void msgOK(string cadena) { HPResergerFunciones.frmInformativo.MostrarDialog(cadena); }
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (!ValidarCuo()) { msgError("Cuo Invalido"); return; }
            //if (!txtcuo.EstaLLeno()) { msgError("Ingrese un Cuo Valido."); return; }
            if (Estado == 1)//Insertamos registros
            {
                //CapaLogica.FormatodeCompras8_2(1, Empresa, idComprobante, NumFactura, 0, Ruc, txtcuo.TextValido(), txtsecuencia.TextValido(), txtOtrosConceptos.DecimalValido(),
                //    txtMontoRetencion.DecimalValido(), txtPaisSujeto.Text, txtPaisBeneficiario.Text, txtVinculo.Text, txtRentaBruta.DecimalValido(), txtDeducciones.DecimalValido(),
                //    txtRentaNeta.DecimalValido(), txtRetencion.DecimalValido(), txtImpuestoRetenido.DecimalValido(), txtConvenio.Text, txtExoneracion.Text, txtTipoRenta.Text,
                //    txtModalidadServicio.Text, txtAplicacion.Text, int.Parse(txtEstado.TextValido()));
                msgOK("Se Agrego con Exito");
            }
            else if (Estado == 2)
            {
                CapaLogica.FormatodeCompras8_2(2, Empresa, Periodo,
                    (string)dtgconten1al10[xNumeroCorrelativo.Name, 0].Value, (string)dtgconten1al10[xSecuencia.Name, 0].Value
                    , (DateTime)dtgconten1al10[xFechaEmision.Name, 0].Value, (int)dtgconten1al10[xTipoComprobante.Name, 0].Value, (string)dtgconten1al10[xSerieComprobante.Name, 0].Value
                    , (string)dtgconten1al10[xNumeroComprobante.Name, 0].Value, (decimal)dtgconten1al10[xValorAdquisiciones.Name, 0].Value
                    , (decimal)dtgconten1al10[xOtrosComprobantes.Name, 0].Value, (decimal)dtgconten1al10[xImporteTotal.Name, 0].Value,
                    idComprobante, SerieFac, AnioDua, NumFac
                    , (decimal)dtgconten11al21[xMontoRetencion.Name, 0].Value, (string)dtgconten11al21[xCodigoMoneda.Name, 0].Value, (decimal)dtgconten11al21[xTipoCambio.Name, 0].Value
                    , (string)dtgconten11al21[xPaisSujeto.Name, 0].Value, (string)dtgconten11al21[xRazonSocialSujeto.Name, 0].Value, (string)dtgconten11al21[xDomicilioSujeto.Name, 0].Value
                    , (string)dtgconten11al21[xDocumentoSujeto.Name, 0].Value,
                    (string)dtgconten22al36[xDocumentoBeneficiario.Name, 0].Value, (string)dtgconten22al36[xRazonSocialBeneficiario.Name, 0].Value
                    , (string)dtgconten22al36[xPaisBeneficiario.Name, 0].Value, (string)dtgconten22al36[xVinculo.Name, 0].Value, (decimal)dtgconten22al36[xRentaBruta.Name, 0].Value
                    , (decimal)dtgconten22al36[xDeducciones.Name, 0].Value, (decimal)dtgconten22al36[xRentaNeta.Name, 0].Value, (decimal)dtgconten22al36[xTasaRetencion.Name, 0].Value
                    , (decimal)dtgconten22al36[xImpuestoRetenido.Name, 0].Value, dtgconten22al36[xConvenios.Name, 0].Value.ToString(),
                    dtgconten22al36[xExoneracion.Name, 0].Value.ToString(), dtgconten22al36[xTipoRenta.Name, 0].Value.ToString(), dtgconten22al36[xModalidad.Name, 0].Value.ToString(),
                    dtgconten22al36[xAplicación.Name, 0].Value.ToString(), (int)dtgconten22al36[xEstado.Name, 0].Value);
                msgOK("Se Guardo con Exito");
            }
            Estado = 0;
            ModoEdicion(false);
            Cargado = true;
            CargarDatos();

        }

        private Boolean ValidarCuo()
        {
            TablaAuxiliar = CapaLogica.ConsultaCuoFormato82(Empresa, dtgconten1al10[xNumeroCorrelativo.Name, 0].Value.ToString());
            if (TablaAuxiliar.Rows.Count > 1)
            {
                msgError($"El CUO Tiene, {TablaAuxiliar.Rows.Count} Filas");
                dtgconten1al10.CurrentCell = dtgconten1al10[xNumeroCorrelativo.Name, 0];
                return false;
            }
            if (TablaAuxiliar.Rows.Count == 0)
            {
                msgError($"No Se Encontro el CUO Ingresado");
                dtgconten1al10.CurrentCell = dtgconten1al10[xNumeroCorrelativo.Name, 0];
                return false;
            }
            return true;
        }
        DataTable TablaAuxiliar;
        private void dtgconten1al10_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (Cargado && Estado == 2)
            {
                if (e.ColumnIndex == dtgconten1al10.Columns[xNumeroCorrelativo.Name].Index)
                {
                    //Buscamos este Cuo
                    if (ValidarCuo())
                    {
                        DataRow Fila = TablaAuxiliar.Rows[0];
                        dtgconten1al10[xFechaEmision.Name, 0].Value = (DateTime)Fila["fechaemision"];
                        dtgconten1al10[xTipoComprobante.Name, 0].Value = (int)Fila["idcomprobante"];
                        dtgconten1al10[xSerieComprobante.Name, 0].Value = (string)Fila["seriefac"];
                        dtgconten1al10[xNumeroComprobante.Name, 0].Value = (string)Fila["numfac"];
                        dtgconten1al10[xValorAdquisiciones.Name, 0].Value = (decimal)Fila["valor"];
                        dtgconten11al21[xCodigoMoneda.Name, 0].Value = (string)Fila["moneda"];
                        dtgconten11al21[xTipoCambio.Name, 0].Value = (decimal)Fila["tc"];
                        dtgconten11al21[xRazonSocialSujeto.Name, 0].Value = (string)Fila["RazonSocial"];
                        dtgconten11al21[xDomicilioSujeto.Name, 0].Value = (string)Fila["Direccion"];
                        dtgconten11al21[xDocumentoSujeto.Name, 0].Value = (string)Fila["ruc"];
                        msgOK("CUO Encontrado");
                    }
                    else
                    {
                        //dtgconten1al10[xFechaEmision.Name, 0].Value = null;
                        dtgconten1al10[xTipoComprobante.Name, 0].Value = 0;
                        dtgconten1al10[xSerieComprobante.Name, 0].Value = null;
                        dtgconten1al10[xNumeroComprobante.Name, 0].Value = null;
                        dtgconten1al10[xValorAdquisiciones.Name, 0].Value = 0;
                        dtgconten11al21[xCodigoMoneda.Name, 0].Value = "USD";
                        dtgconten11al21[xTipoCambio.Name, 0].Value = 0;
                        dtgconten11al21[xRazonSocialSujeto.Name, 0].Value = null;
                        dtgconten11al21[xDomicilioSujeto.Name, 0].Value = null;
                        dtgconten11al21[xDocumentoSujeto.Name, 0].Value = null;
                    }
                }
                //Sim modifica los importes
                if (e.ColumnIndex == dtgconten1al10.Columns[xValorAdquisiciones.Name].Index || e.ColumnIndex == dtgconten1al10.Columns[xOtrosComprobantes.Name].Index)
                {
                    dtgconten1al10[xImporteTotal.Name, 0].Value = (decimal)dtgconten1al10[xValorAdquisiciones.Name, 0].Value + (decimal)dtgconten1al10[xOtrosComprobantes.Name, 0].Value;

                    //xImporteTotal
                }

            }
        }
        TextBox txt;
        private void dtgconten1al10_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            if (txt != null)
                txt.KeyPress -= new KeyPressEventHandler(dataGridview_KeyPressCajitaDecimales);
            if (dtgconten1al10.CurrentCell.ColumnIndex == dtgconten1al10.Columns[xOtrosComprobantes.Name].Index)
            {
                txt = e.Control as TextBox;
                if (txt != null)
                {
                    txt.KeyPress += new KeyPressEventHandler(dataGridview_KeyPressCajitaDecimales);
                    // txt.KeyPress += new KeyPressEventHandler(dataGridview_KeyPressCajita);
                }
            }
        }
        private void dataGridview_KeyPressCajitaDecimales(object sender, KeyPressEventArgs e)
        {
            HPResergerFunciones.Utilitarios.SoloNumerosDecimales(e, txt.Text);
        }
        private void Txt_KeyPressEnteros(object sender, KeyPressEventArgs e)
        {
            HPResergerFunciones.Utilitarios.SoloNumerosEnteros(e);
        }
        private void dtgconten11al21_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            if (txt != null)
            {
                txt.KeyPress -= new KeyPressEventHandler(dataGridview_KeyPressCajitaDecimales);
                txt.KeyPress -= Txt_KeyPressEnteros;
            }
            //
            if (dtgconten11al21.CurrentCell.ColumnIndex == dtgconten11al21.Columns[xMontoRetencion.Name].Index)
            {
                txt = e.Control as TextBox;
                if (txt != null)
                {
                    txt.KeyPress += new KeyPressEventHandler(dataGridview_KeyPressCajitaDecimales);
                    // txt.KeyPress += new KeyPressEventHandler(dataGridview_KeyPressCajita);
                }
            }
            else if (dtgconten11al21.CurrentCell.ColumnIndex == dtgconten11al21.Columns[xPaisSujeto.Name].Index)
            {
                txt = e.Control as TextBox;
                if (txt != null)
                {
                    txt.KeyPress += Txt_KeyPressEnteros;
                    // txt.KeyPress += new KeyPressEventHandler(dataGridview_KeyPressCajita);
                }
            }
        }
        private void dtgconten22al36_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            int[] ListaodEnteros = { 2, 3, 9, 11, 14 };
            int[] ListadoDecimales = { 4, 5, 6, 7, 8 };
            if (txt != null)
            {
                txt.KeyPress -= new KeyPressEventHandler(dataGridview_KeyPressCajitaDecimales);
                txt.KeyPress -= Txt_KeyPressEnteros;
            }
            if (ListadoDecimales.Contains(dtgconten22al36.CurrentCell.ColumnIndex))
            //== (int)(dtgconten22al36.Columns[xRentaBruta.Name].Index | dtgconten22al36.Columns[xDeducciones.Name].Index
            //   | dtgconten22al36.Columns[xRentaNeta.Name].Index | dtgconten22al36.Columns[xTasaRetencion.Name].Index | dtgconten22al36.Columns[xImpuestoRetenido.Name].Index))
            {
                txt = e.Control as TextBox;
                if (txt != null)
                {
                    txt.KeyPress += new KeyPressEventHandler(dataGridview_KeyPressCajitaDecimales);
                    // txt.KeyPress += new KeyPressEventHandler(dataGridview_KeyPressCajita);
                }
            }
            else if (ListaodEnteros.Contains(dtgconten22al36.CurrentCell.ColumnIndex))
            //== (int)(dtgconten22al36.Columns[xPaisBeneficiario.Name].Index | dtgconten22al36.Columns[xVinculo.Name].Index |
            //dtgconten22al36.Columns[xConvenios.Name].Index | dtgconten22al36.Columns[xTipoRenta.Name].Index | dtgconten22al36.Columns[xEstado.Name].Index))
            {
                txt = e.Control as TextBox;
                if (txt != null)
                {
                    txt.KeyPress += Txt_KeyPressEnteros;
                    // txt.KeyPress += new KeyPressEventHandler(dataGridview_KeyPressCajita);
                }
            }
        }
    }
}
