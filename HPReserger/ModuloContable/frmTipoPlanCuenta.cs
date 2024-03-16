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
    public partial class frmTipoPlanCuenta : FormGradient
    {
        public frmTipoPlanCuenta()
        {
            InitializeComponent();
        }
        HPResergerCapaLogica.HPResergerCL CapaLogica = new HPResergerCapaLogica.HPResergerCL();
        private int Estado;
        private void frmTipoPlanCuenta_Load(object sender, EventArgs e)
        {
            txtplancuenta.CargarTextoporDefecto();
            CargarDatos();
            ModoEdicion(false);
            Estado = 0;
        }
        public void CargarDatos()
        {
            dtgconten.DataSource = CapaLogica.TipoPlanCuentas();
            lblmsg.Text = $"Total de Registros: {dtgconten.RowCount}";
        }
        public void ModoEdicion(Boolean a)
        {
            //Desactivamos con false
            btnAceptar.Enabled = a;
            //Activamos con True
            btnactualizar.Enabled = txtcodsunat.ReadOnly = txtplancuenta.ReadOnly = btnnuevo.Enabled = btnmodificar.Enabled = dtgconten.Enabled = !a;
        }

        private void btnactualizar_Click(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            if (Estado == 0)
            {
                this.Close();
            }
            else
            {
                Estado = 0;
                ModoEdicion(false);
                CargarDatos();
            }
        }

        private void dtgconten_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int x = e.RowIndex;
                txtcodsunat.Text = ((int)dtgconten[xCodsunat.Name, x].Value).ToString("000");
                txtid.Text = dtgconten[xpkid.Name, x].Value.ToString();
                txtplancuenta.Text = dtgconten[xPlanCuenta.Name, x].Value.ToString().Trim();
            }
        }

        private void btnnuevo_Click(object sender, EventArgs e)
        {
            Estado = 1;
            ModoEdicion(true);
        }

        private void btnmodificar_Click(object sender, EventArgs e)
        {
            Estado = 2;
            ModoEdicion(true);
        }
        public void msgOk(string cadena)
        {
            HPResergerFunciones.Utilitarios.msg(cadena);
        }
        public void msg(string cadena)
        {
            HPResergerFunciones.Utilitarios.msgCancel(cadena);
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (Configuraciones.ValidarSQLInyect(txtcodsunat, txtplancuenta)) { msg("Codigo Malicioso Detectado"); return; }
            //Validaciones
            if (!txtplancuenta.EstaLLeno()) { msg("Ingrese Medio de Pago"); txtplancuenta.Focus(); return; }
            if (!txtcodsunat.EstaLLeno()) { msg("Ingrese Código Sunat"); txtcodsunat.Focus(); return; }
            //declaracion variables
            string MedioPago = txtplancuenta.TextValido().Trim();
            int Codsunat = 0;
            int pkid = 0;
            int.TryParse(txtcodsunat.Text, out Codsunat);
            int.TryParse(txtid.Text, out pkid);
            //insertar valor
            if (Estado == 1)
            {
                CapaLogica.TipoPlanCuentas(1, 0, MedioPago, Codsunat);
                msgOk("Se Agregó Registro");
            }
            //actualizamos el valor
            else if (Estado == 2)
            {
                CapaLogica.TipoPlanCuentas(2, pkid, MedioPago, Codsunat);
                msgOk("Se Actualizo Registro");
            }
            ModoEdicion(false);
            Estado = 0;
            CargarDatos();
        }
    }
}
