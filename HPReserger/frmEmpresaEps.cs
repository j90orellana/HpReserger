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
    public partial class frmEmpresaEps : Form
    {
        public frmEmpresaEps()
        {
            InitializeComponent();
        }
        HPResergerCapaLogica.HPResergerCL CCargos = new HPResergerCapaLogica.HPResergerCL();
        public int estado = 0;
        public Boolean Consulta = false;
        public void iniciar(Boolean a)
        {
            btnnuevo.Enabled = !a;
            btnmodificar.Enabled = !a;
            btnaceptar.Enabled = a;
            dtgconten.Enabled = !a;
            // btneliminar.Enabled = !a;
            txtgerencia.Enabled = a;
            // NumAporte.Enabled = a;
            // Numadicional1.Enabled = a;
            // Numadicional2.Enabled = a;
            // Numadicional3.Enabled = a;
            checkActivo.Enabled = a;
        }
        private void Msg(string cadena)
        {
            MessageBox.Show(cadena, "HpReseger", MessageBoxButtons.OK, MessageBoxIcon.Question);
        }
        public void CargarDatos()
        {
            dtgconten.DataSource = CCargos.InsertarActualizarEmpresaEps(0, 0, txtgerencia.Text, frmLogin.CodigoUsuario, 0, 0, 0, 0, true);
            dtgconten.Focus();
        }
        private void btnnuevo_Click(object sender, EventArgs e)
        {
            estado = 1;
            iniciar(true);
            txtgerencia.Text = "";
            DataRow codigo = CCargos.VerUltimoIdentificador("TBL_Empresa_Eps", "ID_Eps");
            txtcodigo.Text = (int.Parse(codigo["ultimo"].ToString()) + 1).ToString();
            btnplanes.Enabled = false;
            txtgerencia.Focus();
        }

        private void btnmodificar_Click(object sender, EventArgs e)
        {
            estado = 2; btnmodificar.Enabled = false;
            iniciar(true); txtgerencia.Focus(); btnplanes.Enabled = false;
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
                if (Consulta) btnaceptar.Enabled = true;
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
                    Msg("Ingresé Nombre de la Empresa");
                    txtgerencia.Focus();
                    return;
                }
                foreach (DataGridViewRow valor in dtgconten.Rows)
                {
                    if (txtgerencia.Text.ToString().ToUpper() == valor.Cells["empresaeps"].Value.ToString().ToUpper())
                    {
                        Msg("La Empresa ya Existe");
                        txtgerencia.Focus();
                        return;
                    }
                }
                //Insertando;
                CCargos.InsertarActualizarEmpresaEps(0, 1, txtgerencia.Text, frmLogin.CodigoUsuario, 0, 0, 0, 0, checkActivo.Checked);
                Msg("Insertado Con Exito");
                iniciar(false); 
            }
            if (estado == 2)
            {
                //Modificar
                if (string.IsNullOrWhiteSpace(txtgerencia.Text))
                {
                    Msg("Ingresé Nombre de la Empresa");
                    txtgerencia.Focus();
                    return;
                }
                int fila = 0;
                foreach (DataGridViewRow valor in dtgconten.Rows)
                {
                    if (txtgerencia.Text.ToString().ToUpper() == valor.Cells["empresaeps"].Value.ToString().ToUpper() && fila != dtgconten.CurrentCell.RowIndex)
                    {
                        Msg("La Empresa ya Existe");
                        txtgerencia.Focus();
                        return;
                    }
                    fila++;
                }
                //modificando
                CCargos.InsertarActualizarEmpresaEps(int.Parse(txtcodigo.Text), 2, txtgerencia.Text, frmLogin.CodigoUsuario, 0, 0, 0, 0, checkActivo.Checked);
                Msg("Actualizado Con Exito");
                IEpsAdicional IFOrmAdicional = MdiParent as IEpsAdicional;
                if (IFOrmAdicional != null)
                    IFOrmAdicional.CargarPLanes();

                iniciar(false);
            }
            if (estado == 0)
            {

            }
            if (Consulta && estado != 1)
            {
                if (txtcodigo.TextLength > 0)
                {
                    estado = int.Parse(txtcodigo.Text);
                    DialogResult = DialogResult.OK;
                    this.Close();
                    return;
                }
            }
            estado = 0; CargarDatos();
        }

        private void dtgconten_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (dtgconten.RowCount > 0)
            {
                btnmodificar.Enabled = true;
                btnplanes.Enabled = true;
                txtcodigo.Text = (string)dtgconten[0, e.RowIndex].Value.ToString();
                txtgerencia.Text = (string)dtgconten[1, e.RowIndex].Value.ToString();
                /*btneliminar.Enabled = true;
                NumAporte.Value = (decimal)dtgconten["aportebeneficiario", e.RowIndex].Value;
                Numadicional1.Value = (decimal)dtgconten["adicional1", e.RowIndex].Value;
                Numadicional2.Value = (decimal)dtgconten["adicional2", e.RowIndex].Value;
                Numadicional3.Value = (decimal)dtgconten["adicional3", e.RowIndex].Value;*/
                if ((int)dtgconten["activo", e.RowIndex].Value == 0) { checkActivo.Checked = false; } else { checkActivo.Checked = true; }
            }
            else
            {
                btnmodificar.Enabled = false;
                btnplanes.Enabled = false;
            }
        }

        private void frmEmpresaEps_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void txtgerencia_TextChanged(object sender, EventArgs e)
        {

        }

        private void btneliminar_Click(object sender, EventArgs e)
        {

        }

        private void btnplanes_Click(object sender, EventArgs e)
        {
            int fila = dtgconten.CurrentCell.RowIndex;
            if (fila >= 0)
            {
                frmPLanesEPS planes = new HPReserger.frmPLanesEPS();
                planes.Icon = this.Icon;
                planes.Text = "Planes EPS - " + dtgconten[empresaeps.Name, fila].Value.ToString();
                planes.CodigoEmpresa = (int)dtgconten[ideps.Name, fila].Value;
                planes.Owner = MdiParent;
                planes.ShowDialog();
            }
        }
    }
}
