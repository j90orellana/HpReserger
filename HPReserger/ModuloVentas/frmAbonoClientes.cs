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
                    txtporpagar.Text = Configuraciones.ReturnDecimal(Tdatitos["PorPagar"].ToString());
                    txtvalnrocuotas.Text = ((decimal)Tdatitos["NroCuotas"]).ToString("0");
                    ModoEdicion(true);
                    CargarDatos();
                    if (int.Parse(txtvalnrocuotas.Text) > 0) lbldato.Text = "Tienes Abonos Pendientes";
                    else lbldato.Text = "No Tienes Abonos Pendientes";
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
        private void btncancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void msg(string cadena)
        {
            HPResergerFunciones.Utilitarios.msg(cadena);
        }
        public DialogResult msgP(string cadena)
        {
            return HPResergerFunciones.Utilitarios.msgp(cadena);
        }
        private void btnaceptar_Click(object sender, EventArgs e)
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
                msg("Abono Guardado");
                btnlimpiarabono_Click(sender, e);
                txtnumcot_TextChanged(sender, e);
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
    }
}

