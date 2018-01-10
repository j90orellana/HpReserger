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
    public partial class frmPLanesEPS : Form
    {
        public frmPLanesEPS()
        {
            InitializeComponent();
        }
        HPResergerCapaLogica.HPResergerCL CapaLogica = new HPResergerCapaLogica.HPResergerCL();
        public int CodigoEmpresa;
        int estado;
        private void frmPLanesEPS_Load(object sender, EventArgs e)
        {
            estado = 0;
            CargarDatos();
        }
        public void CargarDatos()
        {
            dtgconten.DataSource = CapaLogica.InsertarActualizarEmpresaEpsPLanes(CodigoEmpresa, 0, 0, txtplan.Text, frmLogin.CodigoUsuario, 0, 0, 0, 0);
            dtgconten.Focus();
        }
        private void dtgconten_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (dtgconten.RowCount > 0)
            {
                btnmodificar.Enabled = true;
                txtplan.Text = (string)dtgconten[nombreplan.Name, e.RowIndex].Value.ToString();
                NumAporte.Value = (decimal)dtgconten[Titular.Name, e.RowIndex].Value;
                Numadicional1.Value = (decimal)dtgconten[Beneficiario1.Name, e.RowIndex].Value;
                Numadicional2.Value = (decimal)dtgconten[Beneficiario2.Name, e.RowIndex].Value;
                Numadicional3.Value = (decimal)dtgconten[Beneficiario3.Name, e.RowIndex].Value;
            }
            else
            {
                btnmodificar.Enabled = false;
            }
        }
        public void iniciar(Boolean a)
        {
            btnnuevo.Enabled = !a;
            btnmodificar.Enabled = !a;
            btnaceptar.Enabled = a;
            dtgconten.Enabled = !a;
            txtplan.Enabled = a;
            NumAporte.Enabled = a;
            Numadicional1.Enabled = a;
            Numadicional2.Enabled = a;
            Numadicional3.Enabled = a;

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
        private void Msg(string cadena)
        {
            MessageBox.Show(cadena, "HpReseger", MessageBoxButtons.OK, MessageBoxIcon.Question);
        }
        private void btnaceptar_Click(object sender, EventArgs e)
        {
            if (estado == 1)
            {
                //nuevo
                if (string.IsNullOrWhiteSpace(txtplan.Text))
                {
                    Msg("Ingresé Nombre del Plan");
                    txtplan.Focus();
                    return;
                }
                foreach (DataGridViewRow valor in dtgconten.Rows)
                {
                    if (txtplan.Text.ToString().ToUpper() == valor.Cells[nombreplan.Name].Value.ToString().ToUpper())
                    {
                        Msg("El Plan ya Existe");
                        txtplan.Focus();
                        return;
                    }
                }
                //Insertando;
                CapaLogica.InsertarActualizarEmpresaEpsPLanes(CodigoEmpresa, 0, 1, txtplan.Text, frmLogin.CodigoUsuario, NumAporte.Value, Numadicional1.Value, Numadicional2.Value, Numadicional3.Value);
                Msg("Insertado Con Exito");
                btncancelar_Click(sender, e);
            }
            if (estado == 2)
            {
                //Modificar
                if (string.IsNullOrWhiteSpace(txtplan.Text))
                {
                    Msg("Ingresé Nombre del Plan");
                    txtplan.Focus();
                    return;
                }
                int fila = 0;
                foreach (DataGridViewRow valor in dtgconten.Rows)
                {
                    if (txtplan.Text.ToString().ToUpper() == valor.Cells[nombreplan.Name].Value.ToString().ToUpper() && fila != dtgconten.CurrentCell.RowIndex)
                    {
                        Msg("El Plan ya Existe");
                        txtplan.Focus();
                        return;
                    }
                    fila++;
                }
                //modificando
                int filax = dtgconten.CurrentCell.RowIndex;
                CapaLogica.InsertarActualizarEmpresaEpsPLanes(CodigoEmpresa, (int)dtgconten[id_eps_planes.Name, filax].Value, 2, txtplan.Text, frmLogin.CodigoUsuario, NumAporte.Value, Numadicional1.Value, Numadicional2.Value, Numadicional3.Value);
                Msg("Actualizado Con Exito");
                btncancelar_Click(sender, e);
            }
            if (estado == 0)
            {

            }
        }
        private void btnnuevo_Click(object sender, EventArgs e)
        {
            estado = 1;
            iniciar(true);
            txtplan.Text = "";
            txtplan.Focus(); btnmodificar.Enabled = false;
        }
        private void btnmodificar_Click(object sender, EventArgs e)
        {
            estado = 2; btnmodificar.Enabled = false;
            iniciar(true); txtplan.Focus();
        }
    }
}
