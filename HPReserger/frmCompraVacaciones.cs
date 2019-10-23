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

namespace HPReserger
{
    public partial class frmCompraVacaciones : FormGradient
    {
        public int TipoDocumento { get; set; }
        public string NumeroDocumento { get; set; }

        public string FechaInicioLabores { get; set; }
        public string FechaUltimoPeriodoDesde { get; set; }
        public string FechaUltimoPeriodoHasta { get; set; }
        public string DiasUtilizados { get; set; }
        public string MaximoDiasComprar { get; set; }

        HPResergerCapaLogica.HPResergerCL clCompraVacaciones = new HPResergerCapaLogica.HPResergerCL();
        DataRow DiasComprar;
        DataRow DiasGenerado;

        public frmCompraVacaciones()
        {
            InitializeComponent();
        }

        private void CalcularSueldo(int TipoDocumento, string NumeroDocumento)
        {
            DataRow drSueldo = clCompraVacaciones.Sueldo(TipoDocumento, NumeroDocumento);
            if (!drSueldo.IsNull("SUELDOMENSUAL"))
            {
                txtSueldoMensual.Text = Convert.ToDouble(drSueldo["SUELDOMENSUAL"].ToString()).ToString("N");
                txtSueldoDiario.Text = Convert.ToDouble(drSueldo["SUELDODIARIO"].ToString()).ToString("N");
                txtMontoPropuesto.Text = Convert.ToDouble(Convert.ToString(Convert.ToDouble(txtDiasComprar.Text) * Convert.ToDouble(txtSueldoDiario.Text))).ToString("N");
                txtMontoPactado.Text = Convert.ToDouble(Convert.ToString(Convert.ToDouble(txtDiasComprar.Text) * Convert.ToDouble(txtSueldoDiario.Text))).ToString("N");
            }
        }

        private void frmCompraVacaciones_Load(object sender, EventArgs e)
        {
            txtFechaInicioLabores.Text = FechaInicioLabores;
            txtUltimoPeriodoDesde.Text = FechaUltimoPeriodoDesde;
            txtUltimoPeriodoHasta.Text = FechaUltimoPeriodoHasta;
            txtDiasUtilizados.Text = DiasUtilizados;
            txtMaximoDias.Text = MaximoDiasComprar;

            dtpPeriodoComprarDesde.Value = DateTime.Now.Date;
            dtpPeriodoComprarHasta.Value = DateTime.Now.Date;

            CalcularSueldo(TipoDocumento, NumeroDocumento);
            cbopago.SelectedIndex = 0;
        }

        private void txtMontoPactado_KeyPress(object sender, KeyPressEventArgs e)
        {
            HPResergerFunciones.Utilitarios.SoloNumerosDecimales(e, txtMontoPactado.Text);
        }

        private void Dias(DateTime Inicio, DateTime Fin, int TipoDocumento, string NumeroDocumento)
        {
            DiasComprar = clCompraVacaciones.DiasVacaciones(Inicio, Fin);
            if (!DiasComprar.IsNull("DIAS"))
            {
                txtDiasComprar.Text = DiasComprar["DIAS"].ToString();
            }

            DiasGenerado = clCompraVacaciones.DiasGenerado(TipoDocumento, NumeroDocumento, dtpPeriodoComprarDesde.Value);
            if (!DiasGenerado.IsNull("DIAS"))
            {
                txtEquivaleDias.Text = ((decimal)DiasGenerado["DIAS"]).ToString("n2");
            }

            CalcularSueldo(TipoDocumento, NumeroDocumento);
        }

        private void dtpPeriodoComprarDesde_ValueChanged(object sender, EventArgs e)
        {
            Dias(dtpPeriodoComprarDesde.Value, dtpPeriodoComprarHasta.Value, TipoDocumento, NumeroDocumento);
        }

        private void dtpPeriodoComprarHasta_ValueChanged(object sender, EventArgs e)
        {
            Dias(dtpPeriodoComprarDesde.Value, dtpPeriodoComprarHasta.Value, TipoDocumento, NumeroDocumento);
        }

        private void btnComprarVacaciones_Click(object sender, EventArgs e)
        {
            if (txtDiasComprar.Text.Length == 0 || Convert.ToInt32(txtDiasComprar.Text) <= 0)
            {
                HPResergerFunciones.frmInformativo.MostrarDialogError("Días Inválido");
                txtDiasComprar.Focus();
                return;
            }
            if (Convert.ToInt32(txtDiasComprar.Text) > 15)
            {
                HPResergerFunciones.frmInformativo.MostrarDialogError("Solo puedes Comprar 15 Días Como Máximo");
                return;
            }
            if (Convert.ToInt32(txtDiasComprar.Text) > Convert.ToInt32(txtMaximoDias.Text))
            {
                HPResergerFunciones.frmInformativo.MostrarDialogError("Solo puedes tomar " + Convert.ToString(txtMaximoDias.Text) + " días de vacaciones como máximo");
                return;
            }
            DateTime FechaMaxima;
            DataRow MaximaFecha = clCompraVacaciones.MaximaFechaATomar(TipoDocumento, NumeroDocumento);
            if (!MaximaFecha.IsNull("FECHA"))
            {
                FechaMaxima = Convert.ToDateTime(MaximaFecha["FECHA"].ToString());

                int Resultado = DateTime.Compare(dtpPeriodoComprarDesde.Value.Date, FechaMaxima.Date);
                if (Resultado <= 0)
                {
                    HPResergerFunciones.frmInformativo.MostrarDialogError("Fecha de Inicio debe ser posterior a la última Fecha Fin aprobada");
                    return;
                }
            }
            if (MessageBox.Show("¿ Seguro de Comprar las Vacaciones ?", CompanyName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                clCompraVacaciones.ComprarVacaciones(TipoDocumento, NumeroDocumento, dtpPeriodoComprarDesde.Value, dtpPeriodoComprarHasta.Value, Convert.ToInt32(txtDiasComprar.Text), Convert.ToDecimal(txtMontoPropuesto.Text), Convert.ToDecimal(txtMontoPactado.Text), frmLogin.CodigoUsuario, cbopago.SelectedIndex + 1, txtobservacion.Text);
                this.DialogResult = System.Windows.Forms.DialogResult.OK;
                this.Close();
            }
        }

        private void txtMontoPactado_Leave(object sender, EventArgs e)
        {
            if (txtMontoPactado.TextLength > 0)
            {
                txtMontoPactado.Text = decimal.Parse(txtMontoPactado.Text).ToString("n2");
            }
        }
    }
}
