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
    public partial class frmTipoId : Form
    {
        public frmTipoId()
        {
            InitializeComponent();
        }
        public int estado { get; set; }
        HPResergerCapaLogica.HPResergerCL cTipoId = new HPResergerCapaLogica.HPResergerCL();
        private void frmTipoId_Load(object sender, EventArgs e)
        {
            estado = 0;
            dtgconten.DataSource = cTipoId.TiposID(0, 0, "", 0);
            dtgconten.Focus();
            Activar();
        }

        private void btnnuevo_Click(object sender, EventArgs e)
        {

            tipmsg.Show("Ingrese Tipo de Id", txtgerencia, 1000);
            txtcodigo.Text = txtgerencia.Text = "";
            estado = 1;
            Desactivar();
        }

        private void btnmodificar_Click(object sender, EventArgs e)
        {
            tipmsg.Show("Ingrese Tipo de Id", txtgerencia, 700);
            Desactivar();
            estado = 2;
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            estado = 3;
            btnaceptar_Click(sender, e);
        }
        public void Desactivar()
        {
            btnnuevo.Enabled = btneliminar.Enabled = btnmodificar.Enabled = dtgconten.Enabled = false;
            numup.ReadOnly = txtgerencia.ReadOnly = false;
        }
        public void Activar()
        {
            btnnuevo.Enabled = btneliminar.Enabled = btnmodificar.Enabled = dtgconten.Enabled = true;
            numup.ReadOnly = txtgerencia.ReadOnly = true;
        }
        public Boolean ValidarDes(string valor)
        {
            Boolean Aux = true;
            for (int i = 0; i < dtgconten.RowCount; i++)
            {
                if (dtgconten[1, i].Value.ToString() == valor && i != dtgconten.CurrentCell.RowIndex)
                {
                    Aux = false;
                    MessageBox.Show("Este valor:" + txtgerencia.Text + " ya Existe", CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return Aux;
                }
            }
            return Aux;
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            if (estado == 0)
            {
                this.Close();
            }
            else
            {
                estado = 0;
                Activar();
                frmTipoId_Load(sender, e);
            }
        }
        private void dtgconten_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtcodigo.Text = dtgconten[0, e.RowIndex].Value.ToString();
                txtgerencia.Text = dtgconten[1, e.RowIndex].Value.ToString();
                numup.Value = (int)dtgconten[Tamañox.Name, e.RowIndex].Value;
            }
            catch { }
        }
        private void btnaceptar_Click(object sender, EventArgs e)
        {
            //Estado 1=Nuevo. Estado 2=modificar. Estado 3=eliminar. Estado 0=SinAcciones
            if (estado == 1 && ValidarDes(txtgerencia.Text))
            {
                cTipoId.TiposID(1, 0, txtgerencia.Text, Convert.ToInt32(numup.Value));
                msg("Ingresado Con Exito");
            }
            else
            {
                if (estado == 2 && ValidarDes(txtgerencia.Text))
                {
                    cTipoId.TiposID(2, Convert.ToInt32(txtcodigo.Text), txtgerencia.Text, Convert.ToInt32(numup.Value));
                    msg("Actualizado Con Exito");
                }
                else
                {
                    if (estado == 3)
                    {
                        if (MessageBox.Show("Seguró Desea Eliminar " + txtgerencia.Text, CompanyName, MessageBoxButtons.YesNo, MessageBoxIcon.Question).ToString() == "Yes")
                        {
                            cTipoId.EliminarTipoId(Convert.ToInt32(txtcodigo.Text));
                            msg("Eliminado Con Exito");
                        }
                    }
                }
            }
            estado = 0;
            frmTipoId_Load(sender, e);
            Activar();
        }
        public void msg(string cadena)
        {
            MessageBox.Show(cadena, CompanyName ,MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
