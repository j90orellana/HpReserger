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
        public string NumFactura;
        public int idComprobante;
        public string Ruc;
        private void frmAddFormato82_Load(object sender, EventArgs e)
        {
            ModoEdicion(false);
            CargarDatos();
        }
        public void ModoEdicion(Boolean v)
        {
            //botones
            btnmodificar.Enabled = !v;
            btnAceptar.Enabled = v;
            //textbox
            txtAplicacion.ReadOnly = !v;
            txtConvenio.ReadOnly = !v;
            txtcuo.ReadOnly = !v;
            txtDeducciones.ReadOnly = !v;
            txtEstado.ReadOnly = !v;
            txtExoneracion.ReadOnly = !v;
            txtImpuestoRetenido.ReadOnly = !v;
            txtModalidadServicio.ReadOnly = !v;
            txtMontoRetencion.ReadOnly = !v;
            txtOtrosConceptos.ReadOnly = !v;
            txtPaisBeneficiario.ReadOnly = !v;
            txtPaisSujeto.ReadOnly = !v;
            txtRentaBruta.ReadOnly = !v;
            txtRentaNeta.ReadOnly = !v;
            txtRetencion.ReadOnly = !v;
            txtsecuencia.ReadOnly = !v;
            txtTipoRenta.ReadOnly = !v;
            txtVinculo.ReadOnly = !v;
        }
        private void btnmodificar_Click(object sender, EventArgs e)
        {
            Estado = 2;
            ModoEdicion(true);
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

        }
    }
}
