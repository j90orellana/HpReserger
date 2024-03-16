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
    public partial class frmAbonoClientes : FormGradient
    {
        public frmAbonoClientes()
        {
            InitializeComponent();
        }
        HPResergerCapaLogica.HPResergerCL CapaLogica = new HPResergerCapaLogica.HPResergerCL();
        public void msg(string cadena) { HPResergerFunciones.frmInformativo.MostrarDialogError(cadena); }
        public void msgOK(string cadena) { HPResergerFunciones.frmInformativo.MostrarDialog(cadena); }
        private void frmAbonoClientes_Load(object sender, EventArgs e)
        {
            lbldato.Text = "";
            DataTable TDatos = CapaLogica.CronogramaVtaDetalle(0);
            dtgconten.DataSource = TDatos;
            lblmsg.Text = $"Total de Registros : 0";
            txtnumcot.CargarTextoporDefecto();
            dtpabono.Value = DateTime.Now;
            txtnumcot_TextChanged(sender, e);
        }
        public void ModoEdicion(Boolean a)
        {
            panelllenado.Enabled = a;
            //txtvalnrocuotas.ReadOnly = !a;
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
        Boolean Encontrado = false;
        private void txtnumcot_TextChanged(object sender, EventArgs e)
        {
            Encontrado = false; lbldato.Text = "";
            LimpiarControles(txtdireccion, txtemail, txtnombre, txtobservacion, txtocupacion, txttelcelular, txttelfijo, txttipoid, txtnroid, txtNombreVendedor, txtcodvendedor, txtimporte, txtdocpago, txttipocambio, txtvaltotal, txtvalnrocuotas, txtvalnrocuotas);
            ModoEdicion(false);
            lkldocpago.Enabled = false;
            txtimporte.ReadOnly = true; dtpabono.Enabled = false; btnimagendoc.Enabled = false;
            VaciarDataGrid(); btnaceptar.Enabled = false;
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
                    txtvaltotal.Text = Configuraciones.ReturnDecimal(filita["Saldo"].ToString());
                    txtmoneda.Text = filita["moneda"].ToString();
                    txttotalpagado.Text = filita["TotalPagado"].ToString();
                    _idCabecera = (int)filita["idcabecera"];
                    _moneda = (int)filita["idmoneda"];
                    btnaceptar.Enabled = true;
                    ////Sacamos los Datos de resumen
                    DataRow Tdatitos = (CapaLogica.CronogramaVtaDetalleResumen(int.Parse(txtnumcot.Text))).Rows[0];
                    if ((decimal)Tdatitos["PorPagar"] > 0)
                        txtporpagar.Text = ((decimal)Tdatitos["PorPagar"]).ToString("n2");
                    else txtporpagar.Text = "0.00";
                    txtvalnrocuotas.Text = ((decimal)Tdatitos["NroCuotas"]).ToString("0");
                    ModoEdicion(true);
                    CargarDatos();
                    if (int.Parse(txtvalnrocuotas.Text) > 0) lbldato.Text = "Tienes Abonos Pendientes";
                    else lbldato.Text = "No Tienes Abonos Pendientes";
                    if (decimal.Parse(txtvaltotal.Text) > decimal.Parse(txttotalpagado.Text))
                    {
                        btnnuevo.Enabled = true;
                        btnaceptar.Enabled = true;
                    }
                    else
                    {
                        btnaceptar.Enabled = false;
                        btnnuevo.Enabled = false;
                    }
                }
            }
        }
        public void CargarDatos()
        {
            dtgconten.DataSource = CapaLogica.CronogramaVtaDetalleCotizacion(int.Parse(txtnumcot.Text));
            lblmsg.Text = $"Total de Registros : {dtgconten.RowCount}";
        }
        public void VaciarDataGrid()
        {
            ((DataTable)(dtgconten.DataSource)).Clear();
            lblmsg.Text = $"Total de Registros : 0";
        }
        private void btnlimpiarabono_Click(object sender, EventArgs e)
        {
            FotoDocpago = null;
            txtimporte.CargarTextoporDefecto();
            txtdocpago.CargarTextoporDefecto();
            lkldocpago.Enabled = false;
            dtpabono.Value = DateTime.Now;
        }
        MemoryStream _memoryStream = new MemoryStream();
        byte[] FotoDocpago;
        private int _idCabecera;
        private int _moneda;
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
        public int estado = 0;
        private void btncancelar_Click(object sender, EventArgs e)
        {
            if (estado == 0)
            {
                this.Close();

            }
            estado = 0;
            btnnuevo.Enabled = true;
            txtimporte.ReadOnly = true; dtpabono.Enabled = false; btnimagendoc.Enabled = false;
            btnaceptar.Enabled = false;
        }
        public DialogResult msgP(string cadena)
        {
            return HPResergerFunciones.frmPregunta.MostrarDialogYesCancel(cadena);
        }
        private void btnaceptar_Click(object sender, EventArgs e)
        {
            if (estado == 1)
            {
                if (decimal.Parse(txtvaltotal.Text) - decimal.Parse(txttotalpagado.Text) == 0)
                {
                    msg("No Se Puede Abonar mas");
                    return;
                }
                if (decimal.Parse(txtimporte.Text) <= 0)
                {
                    txtimporte.Focus();
                    msg("Ingrese un Monto Mayor a Cero");
                    return;
                }
                if (FotoDocpago == null)
                {
                    btnimagendoc.Focus();
                    msg("Seleccione Documento de Pago");
                    return;
                }
                if (msgP("Seguro desea Grabar Abono") == DialogResult.Yes)
                {
                    CapaLogica.CronogramaVtaDetalle(1, _idCabecera, int.Parse(txtnumcot.Text), int.Parse(txtvalnrocuotas.Text), dtpabono.Value, -1 * decimal.Parse(txtimporte.Text), _moneda, dtpabono.Value, FotoDocpago, txtdocpago.Text, dtpabono.Value, frmLogin.CodigoUsuario);
                    msgOK("Abono Guardado");
                    btnlimpiarabono_Click(sender, e);
                    txtnumcot_TextChanged(sender, e);
                    estado = 0;
                    btnaceptar.Enabled = false;
                    btnnuevo.Enabled = true;
                }
            }
        }

        private void btnbuscoti_Click(object sender, EventArgs e)
        {
            frmlistarSeparacionVta frmlissep = new frmlistarSeparacionVta();
            frmlissep.NumCot = int.Parse(txtnumcot.Text);
            frmlissep.Nombre = "Lista de Cotizaciones Para Realizar los Abonos";
            frmlissep.Estado = 200;////Estado 2 para no mostrar los dias a caducar
            frmlissep.ShowDialog();
            if (frmlissep.NumCot != 0) { txtnumcot.Text = frmlissep.NumCot.ToString(); }
        }
        private void dtgconten_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == dtgconten.Columns[importe.Name].Index)
            {
                var item = dtgconten[importe.Name, e.RowIndex];
                if ((decimal)item.Value <= 0)
                    dtgconten.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.FromArgb(192, 80, 77);
                else
                    dtgconten.Rows[e.RowIndex].DefaultCellStyle.ForeColor = item.InheritedStyle.ForeColor;
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
        private void dtgconten_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            int x = e.RowIndex, y = e.ColumnIndex;
            if (x >= 0)
            {
                DataRow Filita = (CapaLogica.CronogramaVtaDetalleResumenPago((int)dtgconten[idregistro.Name, x].Value)).Rows[0];
                if (Filita["img_pago"].ToString() != "")
                {
                    FotoDocpago = (byte[])Filita["img_pago"];
                    txtdocpago.Text = Filita["nombre_pago"].ToString();
                    lkldocpago.Enabled = true;
                }
                else
                {
                    txtdocpago.Text = ""; FotoDocpago = null;
                    lkldocpago.Enabled = false;
                }
                dtpabono.Value = (DateTime)Filita["Vencimiento_Cuota"];
                if ((decimal)Filita["valor_cuota"] < 0)
                {
                    txtimporte.Text = (-1 * (decimal)Filita["valor_cuota"]).ToString("n2");
                }
                txtimporte.Text = "0.00";

            }
        }
        private void btnnuevo_Click(object sender, EventArgs e)
        {
            txtimporte.ReadOnly = false; dtpabono.Enabled = true; btnimagendoc.Enabled = true;
            btnnuevo.Enabled = false;
            estado = 1;
            btnlimpiarabono_Click(sender, e);
            btnaceptar.Enabled = true;

        }
    }
}

