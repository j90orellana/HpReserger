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
    public partial class frmSeparacionVta : FormGradient
    {
        public frmSeparacionVta()
        {
            InitializeComponent();
        }
        HPResergerCapaLogica.HPResergerCL CapaLogica = new HPResergerCapaLogica.HPResergerCL();
        private void frmSeparacionVta_Load(object sender, EventArgs e)
        {
            lbldias.Text = lbldato.Text = "";
            CargarMoneda();
            ModoEdicion(false);
            estado = 0;
            txtnumcot.CargarTextoporDefecto();
        }
        public int Codid { get; set; }
        private void txtcodvendedor_TextChanged(object sender, EventArgs e)
        {
            lbldato.Text = "";
            LimpiarControles(txtimporte, txtdocpago,txtobservacion);
            dtgconten.DataSource = CapaLogica.SeparacionVenta(0).Clone();
            if (txtnumcot.EstaLLeno())
            {
                //datos de la cotizacion, cliente y tipoid
                DataTable Tdatos = CapaLogica.SeparacionVenta(10, int.Parse(txtnumcot.Text));
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
                    txtNombreVendedor.Text =Configuraciones.MayusculaCadaPalabra( filita["vendedor"].ToString());
                    txtobservacion.Text = filita["Observaciones"].ToString();
                    txtme.Text = Configuraciones.ReturnDecimal(filita["ImporteTotalME"].ToString());
                    txtmn.Text = Configuraciones.ReturnDecimal(filita["ImporteTotalMN"].ToString());
                    txtValorInicial.Text = Configuraciones.ReturnDecimal(filita["ValorInicial"].ToString());
                    txttipocambioref.Text = Configuraciones.ReturnDecimal(filita["TC_Referencial"].ToString());
                    txtvalorinicialsoles.Text = ((decimal)filita["ValorInicial"] * (decimal)filita["TC_Referencial"]).ToString("n2");
                    ////abonos
                    txtabonome.Text = Configuraciones.ReturnDecimal(filita["AbonoimportemE"].ToString());
                    txtabonomn.Text = Configuraciones.ReturnDecimal(filita["AbonoimportemN"].ToString());
                    string cadena = (int)filita["dias"] <= 1 ? filita["dias"].ToString() + " Dia" : filita["dias"].ToString() + " Días";
                    lbldias.Text = cadena;
                    //CARGA DE SALDOS
                    txtsaldome.Text = (decimal.Parse(txtValorInicial.Text) - decimal.Parse(txtabonome.Text)).ToString("n2");
                    txtsaldomn.Text = (decimal.Parse(txtvalorinicialsoles.Text) - decimal.Parse(txtabonomn.Text)).ToString("n2");
                    //txtubicacion.Text = $"{Configuraciones.MayusculaCadaPalabra(filita["Ddepartamento"].ToString())} - {Configuraciones.MayusculaCadaPalabra(filita["dprovincia"].ToString())} - {Configuraciones.MayusculaCadaPalabra(filita["ddistrito"].ToString())} ";
                    btnprocesar.Enabled = true;
                    ///datos de la grilla de pagos
                    CargarDatos();
                    //cuando cargar los datos --btnprocesar
                    // ModoEdicion(true);
                    if (dtgconten.RowCount > 0) btnmodificar.Enabled = true;
                    btnaceptar.Enabled = false;
                    btnnuevo.Enabled = true;
                    //DATOS PARA SALDOS ABONADOS
                    if (decimal.Parse(txtsaldomn.Text) <= 0)
                    {
                        btnnuevo.Enabled = false;
                        lbldato.Text = "Ir al Proceso de Venta";
                    }
                }
                else
                {
                    LimpiarControles(txtdireccion, txtemail, txtnombre, txtocupacion, txttelcelular, txttelfijo, txttipoid, txtnroid, txtNombreVendedor, txtcodvendedor, txttipocambioref, txtValorInicial, txtme, txtmn, txtvalorinicialsoles, txtimporte, txtdocpago, txtabonome, txtabonomn, txttipocambio, txtsaldome, txtsaldomn);
                    btnprocesar.Enabled = false; FotoDocpago = null;
                    lkldocpago.Enabled = false; dtpfecha.Value = DateTime.Now;
                    lbldias.Text = "";
                    btnnuevo.Enabled = btnmodificar.Enabled = false;
                }
            }
            else
            {
                LimpiarControles(txtdireccion, txtemail, txtnombre, txtocupacion, txttelcelular, txttelfijo, txttipoid, txtnroid, txtNombreVendedor, txtcodvendedor, txttipocambioref, txtValorInicial, txtme, txtmn, txtvalorinicialsoles, txtimporte, txtdocpago, txtabonome, txtabonomn, txttipocambio, txtsaldome, txtsaldomn);
                lkldocpago.Enabled = false; FotoDocpago = null;
                btnnuevo.Enabled = btnmodificar.Enabled = false;
                btnprocesar.Enabled = false; dtpfecha.Value = DateTime.Now;
                lbldias.Text = "";
            }
        }
        public void CargarDatos()
        {
            dtgconten.DataSource = CapaLogica.SeparacionVenta(int.Parse(txtnumcot.Text == "" ? "0" : txtnumcot.Text));
            lblmsg.Text = $"Total de Registros: {dtgconten.RowCount}";
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
        private void btnproductos_Click(object sender, EventArgs e)
        {
            ModoEdicion(true);
            if (dtgconten.RowCount > 0) btnmodificar.Enabled = true;
            btnaceptar.Enabled = false;
        }
        public void CargarMoneda()
        {
            DataTable TMoneda = CapaLogica.InsertarActualizarMoneda();
            cbomoneda.DisplayMember = "descripcion";
            cbomoneda.ValueMember = "codigo";
            cbomoneda.DataSource = TMoneda;
        }
        public void ModoEdicion(Boolean a)
        {
            btnaceptar.Enabled = a;
            txtnumcot.ReadOnly = a;
            btnprocesar.Enabled = !a;
            btnbuscoti.Enabled = !a;
            btnnuevo.Enabled = a;
        }
        private void btncancelar_Click(object sender, EventArgs e)
        {
            if (estado == 0)
            {
                this.Close();
            }
            else
            {
                ModoEdicion(false);
                panelllenado.Enabled = false;
                LimpiarControles(txtimporte, txtdocpago, txttipocambio);
                FotoDocpago = null;
                btnmodificar.Enabled = false; dtpfecha.Value = DateTime.Now;
                dtgconten.Enabled = true;
            }
            estado = 0;
            CargarDatos();
        }
        private void btnaddproducto_Click(object sender, EventArgs e)
        {
            frmlistarSeparacionVta frmlissep = new frmlistarSeparacionVta();
            frmlissep.NumCot = int.Parse(txtnumcot.Text);
            frmlissep.ShowDialog();
            if (frmlissep.NumCot != 0) { txtnumcot.Text = frmlissep.NumCot.ToString(); }
        }
        private void btnnuevo_Click(object sender, EventArgs e)
        {
            ModoEdicion(true);
            panelllenado.Enabled = true;
            btnnuevo.Enabled = btnmodificar.Enabled = false;
            LimpiarControles(txtimporte, txtdocpago, txttipocambio);
            FotoDocpago = null;
            estado = 1; dtpfecha.Value = DateTime.Now;
            btnaceptar.Enabled = true;
            dtgconten.Enabled = false;
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
                //txtdocpago.Text = dialogoAbrirArchivoContrato.FileName.ToString();
                //if (txtdocpago.TextValido() != string.Empty)
                //if (txtdocpago.EstaLLeno())      
                txtdocpago.Text = dialogoAbrirArchivoContrato.FileName.ToString();
                _memoryStream.Position = 0;
                _memoryStream.SetLength(0);
                _memoryStream.Capacity = 0;
                lkldocpago.Enabled = true;
                FotoDocpago = File.ReadAllBytes(dialogoAbrirArchivoContrato.FileName);
            }
        }
        public void msg(string cadena)
        {
            HPResergerFunciones.Utilitarios.msg(cadena);
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
                    VerPdf.nombreformulario = " Documento de Pago -" + txtnombre.Text;
                    VerPdf.Show();
                    File.Delete(Ruta);
                }
                catch (Exception ex) { msg(ex.Message); }
            }
        }
        private void txtdocpago_TextChanged(object sender, EventArgs e)
        {
            if (txtdocpago.EstaLLeno()) { lkldocpago.Enabled = true; } else { lkldocpago.Enabled = false; }
        }
        private void cbomoneda_Click(object sender, EventArgs e)
        {
            string value = cbomoneda.Text;
            CargarMoneda();
            cbomoneda.Text = value;
        }

        private void btnmodificar_Click(object sender, EventArgs e)
        {
            ModoEdicion(true);
            estado = 2;
            btnaceptar.Enabled = true;
            btnnuevo.Enabled = btnmodificar.Enabled = false;
            dtgconten.Enabled = false;
        }
        private void dtgconten_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            int x = e.RowIndex, y = e.ColumnIndex;
            if (x >= 0)
            {
                DataGridViewRow item = dtgconten.Rows[x];
                Codid = (int)item.Cells[IdSepVta.Name].Value;
                txttipocambio.Text = item.Cells[tipocambio.Name].Value.ToString();
                cbomoneda.SelectedValue = item.Cells[idmoneda.Name].Value;
                if ((int)cbomoneda.SelectedValue == 1) { txtimporte.Text = ((decimal)item.Cells[Importemn.Name].Value).ToString("n2"); }
                if ((int)cbomoneda.SelectedValue == 2) { txtimporte.Text = ((decimal)item.Cells[importeme.Name].Value).ToString("n2"); }
                dtpfecha.Value = (DateTime)item.Cells[FechaPago.Name].Value;
                ///parte del pdf
                if (item.Cells[Imgpago.Name].Value != null && item.Cells[Imgpago.Name].Value.ToString().Length > 0)
                {
                    byte[] Fotito = new byte[0];
                    FotoDocpago = Fotito = (byte[])item.Cells[Imgpago.Name].Value;
                    //MemoryStream ms = new MemoryStream(Fotito);
                    //ContratoPdf = ms;
                    //pbFotoContrato.Image = Bitmap.FromStream(ms);
                    txtdocpago.Text = item.Cells[Nombrepago.Name].Value.ToString();
                    lkldocpago.Enabled = true;
                }
                else
                {
                    txtdocpago.Text = ""; FotoDocpago = null;
                    lkldocpago.Enabled = false;
                }
            }
        }
        private void btnaceptar_Click(object sender, EventArgs e)
        {
            if (estado == 1)
            {
                if (!txtimporte.EstaLLeno())
                {
                    txtimporte.Focus();
                    msg("Ingrese El Importe a Abonar");
                    return;
                }
                if (cbomoneda.SelectedIndex < 0)
                {
                    cbomoneda.Focus();
                    msg("Seleccion el tipo de moneda");
                    return;
                }
                if (FotoDocpago == null || !txtdocpago.EstaLLeno())
                {
                    btnimagendoc.Focus();
                    msg("Seleccione Imagen del Documento de Pago");
                    return;
                }
                //if (dtpfecha.Value.Date < DateTime.Now.Date)
                //{
                //    dtpfecha.Focus();
                //    msg("Ingrese una Fecha Valida");
                //    return;
                //}
                /// SOLES   
                decimal Valor = decimal.Parse(txtimporte.Text);
                decimal TC = decimal.Parse(txttipocambio.Text);
                if ((int)cbomoneda.SelectedValue == 1)
                {
                    //if (decimal.Parse(txtsaldomn.Text) < Valor)
                    //{
                    //    txtimporte.Focus();
                    //    msg($"El Monto a Abonar NO puede superar el Saldo de: {txtsaldomn.Text}");
                    //    return;
                    //}
                }
                else
                //DOLARES
                if ((int)cbomoneda.SelectedValue == 2)
                {
                    //if (decimal.Parse(txtsaldome.Text) < Valor)
                    //{
                    //    txtimporte.Focus();
                    //    msg($"El Monto a Abonar NO puede superar el Saldo de: {txtsaldome.Text}");
                    //    return;
                    //}
                }
                else { msg("No hay más tipos de moneda"); return; }
                ///calculo de los montos
                Decimal montome = 0, montomn = 0;
                ///soles
                if ((int)cbomoneda.SelectedValue == 1)
                {
                    montomn = Valor;
                    montome = Valor / TC;

                }//dolares
                else if ((int)cbomoneda.SelectedValue == 2)
                {
                    montome = Valor;
                    montomn = Valor * TC;
                }
                else { return; }
                /////proceso de guardado
                CapaLogica.SeparacionVenta(1, int.Parse(txtnumcot.Text), montomn, montome, TC, (int)cbomoneda.SelectedValue, FotoDocpago, txtdocpago.Text, dtpfecha.Value, frmLogin.CodigoUsuario);
                msg("Abono Guardado");
                ///refrescando
                btncancelar_Click(sender, new EventArgs());
                txtcodvendedor_TextChanged(sender, new EventArgs());
            }
        }
        private void dtgconten_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int x = e.RowIndex, y = e.ColumnIndex;
            if (x >= 0)
            {
                if (y == dtgconten.Columns[btneliminar.Name].Index && estado == 0)
                {
                    if (HPResergerFunciones.Utilitarios.msgp("Seguro Desea Eliminar Registro de Abono") == DialogResult.Yes)
                    {
                        CapaLogica.SeparacionVentaDarBajaAbono((int)dtgconten[IdSepVta.Name, x].Value);
                        txtcodvendedor_TextChanged(sender, new EventArgs());
                    }
                }
            }
        }
    }
}
