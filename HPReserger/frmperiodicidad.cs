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
    public partial class frmperiodicidad : Form
    {
        public frmperiodicidad()
        {
            InitializeComponent();
        }
        HPResergerCapaLogica.HPResergerCL CCargos = new HPResergerCapaLogica.HPResergerCL();
        int estado = 0;
        public void iniciar(Boolean a)
        {
            btnnuevo.Enabled = !a;
            btnmodificar.Enabled = !a;
            btnaceptar.Enabled = a;
            dtgconten.Enabled = !a;
            btneliminar.Enabled = !a;
            txtgerencia.Enabled = a;
        }
        private void Msg(string cadena)
        {
            MessageBox.Show(cadena, "HpReseger", MessageBoxButtons.OK, MessageBoxIcon.Question);
        }
        public void CargarDatos()
        {
            dtgconten.DataSource = CCargos.getCargoTipoContratacion("Id_Periodicidad", "Periodicidad", "TBL_Periodicidad");
            dtgconten.Focus();
        }
        private void frmperiodicidad_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void btnnuevo_Click(object sender, EventArgs e)
        {
            estado = 1;
            iniciar(true);
            txtgerencia.Text = "";
            DataRow codigo = CCargos.VerUltimoIdentificador("TBL_Periodicidad", "Id_Periodicidad");
            txtcodigo.Text = (int.Parse(codigo["ultimo"].ToString()) + 1).ToString();
            txtgerencia.Focus();
        }

        private void btnmodificar_Click(object sender, EventArgs e)
        {
            estado = 2; btnmodificar.Enabled = false;
            iniciar(true); txtgerencia.Focus();
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            if (estado == 0)
            {
                this.Close();
            }
            else
            {
                iniciar(false);
                estado = 0;
            }
            CargarDatos();
        }

        private void btnaceptar_Click(object sender, EventArgs e)
        {
            if (estado == 1)
            {
                //nuevo
                if (string.IsNullOrWhiteSpace(txtgerencia.Text))
                {
                    Msg("Ingresé Periodicidad");
                    txtgerencia.Focus();
                    return;
                }
                foreach (DataGridViewRow valor in dtgconten.Rows)
                {
                    if (txtgerencia.Text.ToString() == valor.Cells["descripcion"].Value.ToString())
                    {
                        Msg("Periocidad ya Existe");
                        txtgerencia.Focus();
                        return;
                    }
                }
                //Insertando;
                CCargos.InsertarActualizarPeriodicidad(0, 1, txtgerencia.Text, frmLogin.CodigoUsuario);
                Msg("Insertado Con Exito");
                btncancelar_Click(sender, e);
            }
            if (estado == 2)
            {
                //Modificar
                if (string.IsNullOrWhiteSpace(txtgerencia.Text))
                {
                    Msg("Ingresé Periocidad");
                    txtgerencia.Focus();
                    return;
                }
                int fila = 0;
                foreach (DataGridViewRow valor in dtgconten.Rows)
                {
                    if (txtgerencia.Text.ToString() == valor.Cells["descripcion"].Value.ToString() && fila != dtgconten.CurrentCell.RowIndex)
                    {
                        Msg("Periocidad ya Existe");
                        txtgerencia.Focus();
                        return;
                    }
                    fila++;
                }
                //modificando
                CCargos.InsertarActualizarPeriodicidad(int.Parse(txtcodigo.Text), 2, txtgerencia.Text, frmLogin.CodigoUsuario);
                Msg("Actualizado Con Exito");
                btncancelar_Click(sender, e);
            }
            if (estado == 0)
            {

            }
        }
        private void dtgconten_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (dtgconten.RowCount > 0)
            {
                btnmodificar.Enabled = true;
                txtcodigo.Text = (string)dtgconten[0, e.RowIndex].Value.ToString();
                txtgerencia.Text = (string)dtgconten[1, e.RowIndex].Value.ToString(); btneliminar.Enabled = true;
            }
            else
            {
                btnmodificar.Enabled = false;
                btneliminar.Enabled = false;
            }
        }
    }
}
