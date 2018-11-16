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

namespace HPReserger.ModuloBancario
{
    public partial class frmCuentasBancarias : FormGradient
    {
        public frmCuentasBancarias()
        {
            InitializeComponent();
        }
        HPResergerCapaLogica.HPResergerCL CapaLogica = new HPResergerCapaLogica.HPResergerCL();
        private void frmCuentasBancarias_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }
        int estado = 0;
        public int Estado
        {
            get { return estado; }
            set { estado = value; }
        }
        public void CargarDatos()
        {
            dtgconten.DataSource = CapaLogica.TipoCuentaBancaria();
            lblmsg.Text = $"Total de Registros : {dtgconten.RowCount}";
            if (dtgconten.RowCount > 0) btnmodificar.Enabled = true; else btnmodificar.Enabled = false;
        }

        public void ModoEdicion(Boolean a)
        {
            txtdescripcion.ReadOnly = !a;
            btnnuevo.Enabled = !a;
            btnmodificar.Enabled = !a;
            dtgconten.Enabled = !a;
            btnaceptar.Enabled = a;
        }
        private void btnnuevo_Click(object sender, EventArgs e)
        {
            estado = 1;
            ModoEdicion(true);
        }
        private void btnmodificar_Click(object sender, EventArgs e)
        {
            estado = 2;
            ModoEdicion(true);
        }
        private void btncancelar_Click(object sender, EventArgs e)
        {
            if (estado == 0) this.Close();
            else
            {
                estado = 0;
                ModoEdicion(false);
                CargarDatos();
            }
        }
        public void msg(string cadena)
        { HPResergerFunciones.Utilitarios.msg(cadena); }
        private void btnaceptar_Click(object sender, EventArgs e)
        {
            if (!txtdescripcion.EstaLLeno()) { txtdescripcion.Focus(); msg("Ingrese la Descripción"); return; }
            ////inserto
            if (estado == 1)
            {
                ///valido si existe
                DataTable Tdatos = CapaLogica.TipoCuentaBancaria(5, 0, txtdescripcion.TextValido(), frmLogin.CodigoUsuario);
                if (Tdatos.Rows.Count > 0) { msg("Descripción YA Existe"); return; }
                CapaLogica.TipoCuentaBancaria(1, 0, txtdescripcion.TextValido(), frmLogin.CodigoUsuario);
                msg("Tipo de Cuenta Agregada");
            }
            ////actualizo
            if (estado == 2)
            {
                ////verifico si ya existe
                DataTable Tdatos = CapaLogica.TipoCuentaBancaria(6, (int)dtgconten[xId_Tipo_Cta.Name, dtgconten.CurrentRow.Index].Value, txtdescripcion.TextValido(), frmLogin.CodigoUsuario);
                if (Tdatos.Rows.Count > 0) { msg("Descripción YA Existe"); return; }
                CapaLogica.TipoCuentaBancaria(2, (int)dtgconten[xId_Tipo_Cta.Name, dtgconten.CurrentRow.Index].Value, txtdescripcion.TextValido(), frmLogin.CodigoUsuario);
                msg("Tipo de Cuenta Actualizado");
            }
            estado = 0;
            ModoEdicion(false);
            CargarDatos();

        }

        private void dtgconten_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            int x = e.RowIndex, y = e.ColumnIndex;
            if (x >= 0)
            {
                txtdescripcion.Text = dtgconten[xDescripcion.Name, x].Value.ToString();
            }
        }
    }
}
