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
    public partial class FrmCambioContra : FormGradient
    {
        public FrmCambioContra()
        {
            InitializeComponent();
        }
        HPResergerCapaLogica.HPResergerCL Ccambiocontra = new HPResergerCapaLogica.HPResergerCL();
        public int idusuario;
        public string password;
        public void msg(string cadena) { HPResergerFunciones.frmInformativo.MostrarDialogError(cadena); }
        public void msgOK(string cadena) { HPResergerFunciones.frmInformativo.MostrarDialog(cadena); }

        private void FrmCambioContra_Load(object sender, EventArgs e)
        {
        }
        private void txtactual_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            this.Close();

        }
        public Boolean valido = true;
        private void btnaceptar_Click(object sender, EventArgs e)
        {
            valido = true;
            if (txtnueva.Text != txtnueva2.Text)
            {
                valido = false;
                msg("No son Iguales Las Nuevas Contraseñas"); limpiar();
            }
            if (txtnueva.Text.Length < 4)
            {
                valido = false;
                msg("Contraseña Muy Corta, 4 Caracteres Minimo"); limpiar();
            }

            if (valido)
            {
                int respuesta = 0;
                Ccambiocontra.CambioContraseña(out respuesta, password, txtactual.Text, txtnueva.Text);
                if (respuesta == 2)
                {
                    msgOK("La Nueva Clave ha sido Actualizada.");
                    this.Close();
                }
                else
                {
                    msg("La Contraseña Ingresada, No es la Correcta");
                    limpiar();
                }
            }
        }
        public void limpiar()
        {
            txtactual.Text = txtnueva.Text = txtnueva2.Text = "";
            txtactual.Focus();
        }

        private void txtactual_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtnueva.Focus();
            }
        }

        private void txtnueva_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtnueva2.Focus();
            }
        }

        private void txtnueva2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnaceptar.Focus();
            }
        }

        private void txtnueva2_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtnueva_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
