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
        public void msg(string cadena) { HPResergerFunciones.frmInformativo.MostrarDialogError(cadena); }
        public void msgOK(string cadena) { HPResergerFunciones.frmInformativo.MostrarDialog(cadena); }

        private void frmSeparacionVta_Load(object sender, EventArgs e)
        {
            lbldias.Text = lbldato.Text = "";
            ModoEdicion(false);
            estado = 0;
            txtnumcot.CargarTextoporDefecto();
        }
        public int Codid { get; set; }
        public int _idmoneda { get; set; }
        private void txtcodvendedor_TextChanged(object sender, EventArgs e)
        {
            LimpiarControles(txtdireccion, txtemail, txtnombre, txtocupacion, txttelcelular, txttelfijo, txttipoid, txtnroid, txtNombreVendedor, txtcodvendedor, txttipocambioref, txtValorInicial, txttotal, txtimporte, txtdocpago, txtabonado, txttipocambio, txtsaldo, txtmoneda);
            lbldato.Text = "";
            btncontrato.Visible = btnminuta.Visible = false;
            LimpiarControles(txtimporte, txtdocpago, txtobservacion);
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
                    txtNombreVendedor.Text = Configuraciones.MayusculaCadaPalabra(filita["vendedor"].ToString());
                    txtobservacion.Text = filita["Observaciones"].ToString();
                    txtmoneda.Text = filita["namecorto"].ToString();
                    _idmoneda = (int)filita["idmoneda"];
                    txttotal.Text = Configuraciones.ReturnDecimal(filita["ImporteTotal"].ToString());
                    txtValorInicial.Text = Configuraciones.ReturnDecimal(filita["ValorInicial"].ToString());
                    txttipocambioref.Text = Configuraciones.ReturnDecimal(filita["TC_Referencial"].ToString());
                    ////abonos
                    txtabonado.Text = Configuraciones.ReturnDecimal(filita["Abonado"].ToString());
                    string cadena = (int)filita["dias"] <= 1 ? (int)filita["dias"] < 0 ? "0" : filita["dias"].ToString() + " Dia" : filita["dias"].ToString() + " Días";
                    lbldias.Text = cadena;
                    //CARGA DE SALDOS
                    txtsaldo.Text = (decimal.Parse(txtValorInicial.Text) - decimal.Parse(txtabonado.Text)).ToString("n2");
                    //txtubicacion.Text = $"{Configuraciones.MayusculaCadaPalabra(filita["Ddepartamento"].ToString())} - {Configuraciones.MayusculaCadaPalabra(filita["dprovincia"].ToString())} - {Configuraciones.MayusculaCadaPalabra(filita["ddistrito"].ToString())} ";
                    btnprocesar.Enabled = true;
                    ///datos de la grilla de pagos
                    CargarDatos();
                    //cuando cargar los datos --btnprocesar
                    // ModoEdicion(true);                 
                    btnaceptar.Enabled = false;
                    btnnuevo.Enabled = true;
                    //DATOS PARA SALDOS ABONADOS
                    if (decimal.Parse(txtsaldo.Text) <= 0)
                    {
                        btnnuevo.Enabled = false;
                        lbldato.Text = "Ir al Cronograma de Pago";
                        btncontrato.Visible = true;
                        btnminuta.Visible = true;
                    }
                }
                else
                {
                    LimpiarControles(txtdireccion, txtemail, txtnombre, txtocupacion, txttelcelular, txttelfijo, txttipoid, txtnroid, txtNombreVendedor, txtcodvendedor, txttipocambioref, txtValorInicial, txttotal, txtimporte, txtdocpago, txtabonado, txttipocambio, txtsaldo);
                    btnprocesar.Enabled = false; FotoDocpago = null;
                    lkldocpago.Enabled = false; dtpfecha.Value = DateTime.Now;
                    lbldias.Text = "";
                    btnnuevo.Enabled = btnmodificar.Enabled = false;
                }
            }
            else
            {
                LimpiarControles(txtdireccion, txtemail, txtnombre, txtocupacion, txttelcelular, txttelfijo, txttipoid, txtnroid, txtNombreVendedor, txtcodvendedor, txttipocambioref, txtValorInicial, txttotal, txtimporte, txtdocpago, txtabonado, txttipocambio, txtsaldo);
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
            if (dtgconten.RowCount > 0) btnmodificar.Enabled = true; else btnmodificar.Enabled = false;
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
                btnnuevo.Enabled = true;
            }
            estado = 0;
            CargarDatos();
        }
        private void btnaddproducto_Click(object sender, EventArgs e)
        {
            frmlistarSeparacionVta frmlissep = new frmlistarSeparacionVta();
            frmlissep.NumCot = int.Parse(txtnumcot.Text);
            frmlissep.Estado = 1;
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
        private void btnmodificar_Click(object sender, EventArgs e)
        {
            if (Configuraciones.Decimal(txtsaldo.Text) > 0)
            {
                ModoEdicion(true);
                estado = 2;
                btnaceptar.Enabled = true;
                btnnuevo.Enabled = btnmodificar.Enabled = false;
                dtgconten.Enabled = false;
                panelllenado.Enabled = true;
            }
            else msg("No se Puede modificar, Ya se cumplió la inicial");
        }
        private void dtgconten_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            int x = e.RowIndex, y = e.ColumnIndex;
            if (x >= 0)
            {
                DataGridViewRow item = dtgconten.Rows[x];
                Codid = (int)item.Cells[IdSepVta.Name].Value;
                txttipocambio.Text = item.Cells[tipocambio.Name].Value.ToString();
                txtimporte.Text = ((decimal)item.Cells[Importe.Name].Value).ToString("n2");
                dtpfecha.Value = (DateTime)item.Cells[FechaPago.Name].Value;
                txtmoneda.Text = item.Cells[Moneda.Name].Value.ToString();
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
            int NumCot = int.Parse(txtnumcot.Text);
            if (estado == 1)
            {
                if (Configuraciones.Decimal(txtabonado.Text) == 0)
                {
                    //PROCESO DE VERIFICACION DE STOCK!
                    DataTable Datos = CapaLogica.VerificarStockProductosDeCotizacion(NumCot);
                    string cadena = "No hay Stock de los Productos:";
                    int con = 1;
                    Boolean Probar = false;
                    foreach (DataRow item in Datos.Rows)
                    {
                        if ((decimal)item["cantidad"] < 0)
                        {
                            cadena += $"{con++}: {item["Producto"].ToString()}";
                            Probar = true;
                        }
                    }
                    if (Probar)
                    {
                        msg(cadena);
                        return;
                    }
                }
                if (!txtimporte.EstaLLeno())
                {
                    txtimporte.Focus();
                    msg("Ingrese El Importe a Abonar");
                    return;
                }
                decimal TC = decimal.Parse(txttipocambio.Text);
                decimal Valor = decimal.Parse(txtimporte.Text);
                if (Valor <= 0)
                {
                    txtimporte.Focus();
                    msg("Ingrese un monto Valido mayor a Cero");
                    return;
                }
                if (FotoDocpago == null || !txtdocpago.EstaLLeno())
                {
                    btnimagendoc.Focus();
                    msg("Seleccione Imagen del Documento de Pago");
                    return;
                }
                /////proceso de guardado
                CapaLogica.SeparacionVenta(1, NumCot, decimal.Parse(txtimporte.Text), TC, _idmoneda, FotoDocpago, txtdocpago.Text, dtpfecha.Value, frmLogin.CodigoUsuario);
                msgOK("Abono Guardado");
                ///refrescando
                btncancelar_Click(sender, new EventArgs());
                txtcodvendedor_TextChanged(sender, new EventArgs());
            }
            //PROCESO DE ACTUALIZACION
            if (estado == 2)
            {
                if (!txtimporte.EstaLLeno())
                {
                    txtimporte.Focus();
                    msg("Ingrese El Importe a Abonar");
                    return;
                }
                decimal TC = decimal.Parse(txttipocambio.Text);
                decimal Valor = decimal.Parse(txtimporte.Text);
                if (Valor <= 0)
                {
                    txtimporte.Focus();
                    msg("Ingrese un monto Valido mayor a Cero");
                    return;
                }
                if (FotoDocpago == null || !txtdocpago.EstaLLeno())
                {
                    btnimagendoc.Focus();
                    msg("Seleccione Imagen del Documento de Pago");
                    return;
                }
                ////cambiamos a anulado al registro
                CapaLogica.SeparacionVentaDarBajaAbono((int)dtgconten[IdSepVta.Name, dtgconten.CurrentCell.RowIndex].Value);
                //inserto el nuevo registro
                CapaLogica.SeparacionVenta(1, NumCot, decimal.Parse(txtimporte.Text), TC, _idmoneda, FotoDocpago, txtdocpago.Text, dtpfecha.Value, frmLogin.CodigoUsuario);
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
                    if (HPResergerFunciones.Utilitarios.msgYesNo("Seguro Desea Eliminar Registro de Abono") == DialogResult.Yes)
                    {
                        //cambiamos a estado anulado en el nombre de la imagen
                        CapaLogica.SeparacionVentaDarBajaAbono((int)dtgconten[IdSepVta.Name, x].Value);
                        txtcodvendedor_TextChanged(sender, new EventArgs());
                    }
                }
            }
        }
        private void btncontrato_Click(object sender, EventArgs e)
        {
            msg("Proceso del Contrato de Venta");
        }
        private void btnminuta_Click(object sender, EventArgs e)
        {
            msg("Proceso de la Minuta");
        }
    }
}
