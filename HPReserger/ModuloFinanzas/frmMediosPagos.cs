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

namespace HPReserger.ModuloFinanzas
{
    public partial class frmMediosPagos : FormGradient
    {
        public frmMediosPagos()
        {
            InitializeComponent();
        }
        HPResergerCapaLogica.HPResergerCL CapaLogica = new HPResergerCapaLogica.HPResergerCL();
        private int Estado;
        private void frmMediosPagos_Load(object sender, EventArgs e)
        {
            txtmediopago.CargarTextoporDefecto();
            CargarDatos();
            ModoEdicion(false);
            Estado = 0;
            //
            LimpiarBusquedas();
        }
        public void LimpiarBusquedas()
        {
            txtbusCodsunat.CargarTextoporDefecto(); txtbusid.CargarTextoporDefecto(); txtbusmedio.CargarTextoporDefecto();
        }
        public void ModoEdicion(Boolean a)
        {
            //Desactivamos con false
            txtbusmedio.ReadOnly = txtbusid.ReadOnly = txtbusCodsunat.ReadOnly = btnAceptar.Enabled = a;
            //Activamos con True
            btnactualizar.Enabled = btnlimpiar.Enabled = txtcodsunat.ReadOnly = txtmediopago.ReadOnly = btnnuevo.Enabled = btnmodificar.Enabled = dtgconten.Enabled = !a;
        }
        public void CargarDatos()
        {
            dtgconten.DataSource = CapaLogica.MedioPagos();
            lblmsg.Text = $"Total de Registros: {dtgconten.RowCount}";
        }
        public void BusquedaDatos()
        {
            if (Configuraciones.ValidarSQLInyect(txtbusCodsunat, txtbusid, txtbusmedio)) { msg("Codigo Malicioso Detectado"); return; }
            int busid, buscodsunat;
            int.TryParse(txtbusid.TextValido(), out busid);
            int.TryParse(txtbusCodsunat.TextValido(), out buscodsunat);
            dtgconten.DataSource = CapaLogica.MedioPagos(10, busid, txtbusmedio.TextValido(), buscodsunat);
            lblmsg.Text = $"Total de Registros: {dtgconten.RowCount}";
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
                txtmediopago.Text = dtgconten[xMedioPago.Name, x].Value.ToString().Trim();
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

        private void btnactualizar_Click(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void txtbusid_TextChanged(object sender, EventArgs e)
        {
            BusquedaDatos();
        }
        private void txtbusCodsunat_TextChanged(object sender, EventArgs e)
        {
            BusquedaDatos();
        }
        private void txtbusmedio_TextChanged(object sender, EventArgs e)
        {
            BusquedaDatos();
        }

        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            LimpiarBusquedas();
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
            if (Configuraciones.ValidarSQLInyect(txtcodsunat, txtmediopago)) { msg("Codigo Malicioso Detectado"); return; }
            //Validaciones
            if (!txtmediopago.EstaLLeno()) { msg("Ingrese Medio de Pago"); txtmediopago.Focus(); return; }
            if (!txtcodsunat.EstaLLeno()) { msg("Ingrese Código Sunat"); txtcodsunat.Focus(); return; }
            //declaracion variables
            string MedioPago = txtmediopago.TextValido().Trim();
            int Codsunat = 0;
            int pkid = 0;
            int.TryParse(txtcodsunat.Text, out Codsunat);
            int.TryParse(txtid.Text, out pkid);
            //insertar valor
            if (Estado == 1)
            {
                CapaLogica.MedioPagos(1, 0, MedioPago, Codsunat);
                msgOk("Se Agregó Registro");
            }
            //actualizamos el valor
            else if (Estado == 2)
            {
                CapaLogica.MedioPagos(2, pkid, MedioPago, Codsunat);
                msgOk("Se Actualizo Registro");
            }
            ModoEdicion(false);
            Estado = 0;
            CargarDatos();
        }
    }
}
