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
    public partial class frmUnidadMedida : FormGradient
    {
        public frmUnidadMedida()
        {
            InitializeComponent();
        }
        HPResergerCapaLogica.HPResergerCL CapaLogica = new HPResergerCapaLogica.HPResergerCL();
        public void msg(string cadena) { HPResergerFunciones.frmInformativo.MostrarDialogError(cadena); }
        public void msgOK(string cadena) { HPResergerFunciones.frmInformativo.MostrarDialog(cadena); }
        private void frmUnidadMedida_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }       
        int estado = 0;
        public void CargarDatos()
        {
            dtgconten.DataSource = CapaLogica.UnidadMedida();
            if (dtgconten.RowCount > 0)
            {
                btneliminar.Enabled = btnmodificar.Enabled = true;
            }
            else
            {
                btnmodificar.Enabled = btneliminar.Enabled = false;
            }
        }
        private void btnnuevo_Click(object sender, EventArgs e)
        {
            estado = 1;
            txtnombre.ReadOnly = btnnuevo.Enabled = dtgconten.Enabled = btneliminar.Enabled = btnmodificar.Enabled = false;
            btnactualizar.Enabled = false;
            btnaceptar.Enabled = true;
            DataRow filita = CapaLogica.UnidadMedida(5, 0, "", 0).Rows[0];
            txtcodigo.Text = filita["total"].ToString();
            TextBox item = txtnombre;
            ((TextBoxPer)item).Clear();
            ((TextBoxPer)item).CargarTextoporDefecto();
            txtnombre.Focus();
        }
        private void btnmodificar_Click(object sender, EventArgs e)
        {
            estado = 2;
            txtnombre.ReadOnly = btnnuevo.Enabled = dtgconten.Enabled = btneliminar.Enabled = btnmodificar.Enabled = false;
            btnactualizar.Enabled = false;
            btnaceptar.Enabled = true;
            txtnombre.Focus();
        }
        private void btneliminar_Click(object sender, EventArgs e)
        {

        }
        private void btncancelar_Click(object sender, EventArgs e)
        {
            if (estado == 0)
            {
                this.Close();
            }
            if (estado == 1 || estado == 2)
            {
                btnnuevo.Enabled = dtgconten.Enabled = btneliminar.Enabled = btnmodificar.Enabled = true;
                btnaceptar.Enabled = false; txtnombre.ReadOnly = true;
                btnactualizar.Enabled = true;
            }
            CargarDatos();
            estado = 0;
        }
        private void dtgconten_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (dtgconten.RowCount > 0)
            {
                DataGridViewRow fila = dtgconten.Rows[e.RowIndex];
                txtnombre.Text = fila.Cells[UnidadMedidax.Name].Value.ToString();
                txtcodigo.Text = fila.Cells[Id_UnidMedidax.Name].Value.ToString();
            }
        }

        private void btnaceptar_Click(object sender, EventArgs e)
        {
            if (!txtnombre.EstaLLeno())
            {
                txtnombre.Focus();
                msg("Ingrese Nombre Valido");
                return;
            }
            if (estado == 1)
            {
                DataRow filita = (CapaLogica.UnidadMedida(6, 0, txtnombre.TextValido(), frmLogin.CodigoUsuario)).Rows[0];
                if (filita["total"].ToString() != "0")
                {
                    msg("La Unidad de Medida Ya Existe");
                    return;
                }
                CapaLogica.UnidadMedida(1, 0, txtnombre.TextValido(), frmLogin.CodigoUsuario);
            msgOK("Agregadó Exitosamente");
            }
            if (estado == 2)
            {
                DataRow filita = (CapaLogica.UnidadMedida(7, int.Parse(txtcodigo.TextValido()), txtnombre.TextValido(), frmLogin.CodigoUsuario)).Rows[0];
                if (filita["total"].ToString() != "0")
                {
                    msg("La Unidad de Medida Ya Existe");
                    return;
                }
                CapaLogica.UnidadMedida(2, int.Parse(txtcodigo.TextValido()), txtnombre.TextValido(), frmLogin.CodigoUsuario);
               msgOK("Actualizadó Exitosamente");
            }
            estado = 0;
            btnnuevo.Enabled = dtgconten.Enabled = btneliminar.Enabled = btnmodificar.Enabled = true;
            btnaceptar.Enabled = false; txtnombre.ReadOnly = true;
            btnactualizar.Enabled = true;
            CargarDatos();
        }
        private void btnactualizar_Click(object sender, EventArgs e)
        {
            CargarDatos();
        }
    }
}
