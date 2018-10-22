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
            CargarMoneda();
            //ModoEdicion(false);
            estado = 0;
            txtnumcot.CargarTextoporDefecto();
            dtpabono.Value = DateTime.Now;
            dtpfecha.Value = DateTime.Now.AddMonths(1);
            txtnumcot_TextChanged(sender, e);
        }
        public void CargarMoneda()
        {
            DataTable TMoneda = CapaLogica.InsertarActualizarMoneda();
            cbomoneda.DisplayMember = "descripcion";
            cbomoneda.ValueMember = "codigo";
            cbomoneda.DataSource = TMoneda;
        }
        private void btnbuscoti_Click(object sender, EventArgs e)
        {
            frmlistarSeparacionVta frmlissep = new frmlistarSeparacionVta();
            frmlissep.NumCot = int.Parse(txtnumcot.Text);
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
        private void txtnumcot_TextChanged(object sender, EventArgs e)
        {
            LimpiarControles(txtdireccion, txtemail, txtnombre, txtobservacion, txtocupacion, txttelcelular, txttelfijo, txttipoid, txtnroid, txtNombreVendedor, txtcodvendedor, txtimporte, txtdocpago, txttipocambio, txtvalinicial, txtvalorcuota, txtabonado, txtvaltotal, txtvalnrocuotas, txtsaldo, txtvalorcuota, txtvalnrocuotas);
            LimpiarControles(txtdiferencia, txtcuotapagar);
            ModoEdicion(false);
            lkldocpago.Enabled = false;
            dtgconten.Rows.Clear();
            //FotoDocpago = null;           
            dtpabono.Value = DateTime.Now;
            dtpfecha.Value = DateTime.Now.AddMonths(1);
            ///dtgconten.DataSource = CapaLogica.SeparacionVenta(0).Clone();
            if (txtnumcot.EstaLLeno())
            {
                //datos de la cotizacion, cliente y tipoid
                DataTable Tdatos = CapaLogica.SeparacionVenta(50, int.Parse(txtnumcot.Text));
                if (Tdatos.Rows.Count != 0)
                {
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
                    txtabonado.Text = Configuraciones.ReturnDecimal(filita["AbonoimportemE"].ToString());
                    txtvaltotal.Text = Configuraciones.ReturnDecimal(filita["ImporteTotalME"].ToString());
                    txtsaldo.Text = ((decimal)filita["ImporteTotalME"] - (decimal)filita["AbonoimportemE"]).ToString("n2");
                    ModoEdicion(true);
                }
            }
        }
        public void CargarDatos()
        {
            dtgconten.Rows.Clear();
            if (int.Parse(txtvalnrocuotas.Text) > 0)
            {
                dtgconten.Rows.Add(int.Parse(txtvalnrocuotas.Text));
                foreach (DataGridViewRow item in dtgconten.Rows)
                {
                    item.Cells[idregistro.Name].Value = item.Index + 1;
                    item.Cells[NroCotizacion.Name].Value = int.Parse(txtnumcot.Text).ToString("0000");
                    item.Cells[NroCuota.Name].Value = item.Index + 1;
                    item.Cells[VencimientoPago.Name].Value = dtpfecha.Value.AddMonths(item.Index);
                    if (item.Index == 0)
                    {
                        if (!txtvalorcuota.ReadOnly)
                        {
                            //nro cuotas
                            item.Cells[ValorCuota.Name].Value = Decimal(txtvalorcuota.Text);
                            item.Cells[ImporteME.Name].Value = Decimal(txtvalorcuota.Text);
                        }
                        else
                        {
                            //monto
                            item.Cells[ImporteME.Name].Value = Decimal(txtvalorcuota.Text) + Decimal(txtdiferencia.Text);
                            item.Cells[ValorCuota.Name].Value = Decimal(txtvalorcuota.Text) + Decimal(txtdiferencia.Text);
                        }

                    }
                    else if (item.Index == int.Parse(txtvalnrocuotas.Text) - 1)
                    {
                        if (!txtvalorcuota.ReadOnly)
                        {
                            if (Decimal(txtdiferencia.Text) >= 0)
                            {
                                item.Cells[ImporteME.Name].Value = Decimal(txtdiferencia.Text);
                                item.Cells[ValorCuota.Name].Value = Decimal(txtdiferencia.Text);
                            }
                            else
                            {
                                item.Cells[ImporteME.Name].Value = Decimal(txtvalorcuota.Text) + Decimal(txtdiferencia.Text);
                                item.Cells[ValorCuota.Name].Value = Decimal(txtvalorcuota.Text) + Decimal(txtdiferencia.Text);
                            }
                        }
                        else
                        {
                            item.Cells[ValorCuota.Name].Value = Decimal(txtvalorcuota.Text);
                            item.Cells[ImporteME.Name].Value = Decimal(txtvalorcuota.Text);
                        }
                    }
                    else
                    {
                        item.Cells[ValorCuota.Name].Value = Decimal(txtvalorcuota.Text);
                        item.Cells[ImporteME.Name].Value = Decimal(txtvalorcuota.Text);
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
        int estado = 0;
        private void cbomoneda_Click(object sender, EventArgs e)
        {
            string value = cbomoneda.Text;
            CargarMoneda();
            cbomoneda.Text = value;
        }
        public static decimal Decimal(string cadena)
        {
            if (cadena == "" || cadena == ".") cadena = "0";
            return decimal.Parse(cadena);
        }
        private void txtsaldo_TextChanged(object sender, EventArgs e)
        {
            decimal deuda = 0;
            //SOLES
            if ((int)cbomoneda.SelectedValue == 1)
            {
                deuda = Decimal(txtsaldo.Text) - Decimal(txtimporte.Text) / Decimal(txttipocambio.TextValido());
            }
            //dolares
            if ((int)cbomoneda.SelectedValue == 2)
            {
                deuda = Decimal(txtsaldo.Text) - Decimal(txtimporte.Text);
            }
            if (deuda < 0)
            {
                msg("No se Puede Abonar mas de la Deuda");
                txtimporte.Focus();
            }
            txtdeudatotal.Text = deuda.ToString("n2");
        }
        private void btnprocesar_Click(object sender, EventArgs e)
        {
            decimal valcal = 0;
            btnprocesar.Enabled = true;
            //txtvalorcuota.ReadOnly = txtvalnrocuotas.ReadOnly = false;
            if (Decimal(txtdeudatotal.Text) > 0)
            {
                if (!txtvalorcuota.ReadOnly && txtvalorcuota.EstaLLeno())
                {
                    valcal = Decimal(txtdeudatotal.Text) / Decimal(txtvalorcuota.Text);
                    txtvalnrocuotas.Text = valcal.ToString("n0");
                    txtcuotapagar.Text = (Decimal(txtvalnrocuotas.Text) * Decimal(txtvalorcuota.Text)).ToString("n2");
                    if (txtdeudatotal.Text != txtcuotapagar.Text)
                    {
                        txtdiferencia.Text = (Decimal(txtdeudatotal.Text) - Decimal(txtcuotapagar.Text)).ToString("n2");
                        if (Decimal(txtdiferencia.Text) > 0)
                        {
                            txtvalnrocuotas.Text = (int.Parse(txtvalnrocuotas.Text) + 1).ToString("n0");
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
            }
            //else
            //    msg("Ingrese el Valor de La cuota o Nro de Cuotas");            
        }
        public void msg(string cadena)
        {
            HPResergerFunciones.Utilitarios.msg(cadena);
        }
        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            txtvalnrocuotas.CargarTextoporDefecto();
            txtvalorcuota.CargarTextoporDefecto();
            txtdiferencia.Text = txtcuotapagar.Text = "0.00";
            btnprocesar_Click(sender, e);
        }

        private void txtvalorcuota_Click(object sender, EventArgs e)
        {
            if (Decimal(txtdeudatotal.Text) > 0)
            {
                txtvalnrocuotas.ReadOnly = true;
                txtvalorcuota.ReadOnly = false;
            }
        }
        private void txtvalnrocuotas_Click(object sender, EventArgs e)
        {
            if (Decimal(txtdeudatotal.Text) > 0)
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
        private void btnpdf_Click(object sender, EventArgs e)
        {
            if (dtgconten.RowCount > 0)
                msg("Programando");
        }
    }
}
