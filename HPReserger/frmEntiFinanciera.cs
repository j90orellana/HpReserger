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
    public partial class frmEntiFinanciera : Form
    {
        public frmEntiFinanciera()
        {
            InitializeComponent();
        }
        public int estado { get; set; }
        HPResergerCapaLogica.HPResergerCL cEntiFinanciera = new HPResergerCapaLogica.HPResergerCL();
        private void frmEntiFinanciera_Load(object sender, EventArgs e)
        {
            estado = 0;
            dtgconten.DataSource = cEntiFinanciera.getCargoTipoContratacion("ID_Entidad", "Entidad_Financiera", "TBL_Entidad_Financiera");
            dtgconten.Focus();
        }

        private void btnnuevo_Click(object sender, EventArgs e)
        {
            tipmsg.Show("Ingrese Nueva Entidad Financiera", txtgerencia, 700);
            txtcodigo.Text = txtgerencia.Text = "";
            estado = 1;
            Desactivar();
        }

        private void btnmodificar_Click(object sender, EventArgs e)
        {
            tipmsg.Show("Ingrese Entidad Financiera", txtgerencia, 700);
            Desactivar();
            estado = 2;
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            estado = 3;
            btnaceptar_Click(sender, e);
        }

        private void dtgconten_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtcodigo.Text = dtgconten[0, e.RowIndex].Value.ToString();
                txtgerencia.Text = dtgconten[1, e.RowIndex].Value.ToString();
            }
            catch { }
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
                frmEntiFinanciera_Load(sender, e);
            }
        }
        public void Desactivar()
        {
            btnnuevo.Enabled = btneliminar.Enabled = btnmodificar.Enabled = dtgconten.Enabled = false;
        }
        public void Activar()
        {
            btnnuevo.Enabled = btneliminar.Enabled = btnmodificar.Enabled = dtgconten.Enabled = true;
        }
        public Boolean ValidarDes(string valor)
        {
            Boolean Aux = true;
            for (int i = 0; i < dtgconten.RowCount; i++)
            {
                if (dtgconten[1, i].Value.ToString() == valor)
                {
                    Aux = false;
                    MessageBox.Show("Este valor: " + txtgerencia.Text + " ya Existe", "Hp Reserger", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return Aux;
                }
            }
            return Aux;
        }

        private void btnaceptar_Click(object sender, EventArgs e)
        {
            //Estado 1=Nuevo. Estado 2=modificar. Estado 3=eliminar. Estado 0=SinAcciones
            if (estado == 1 && ValidarDes(txtgerencia.Text))
            {
                cEntiFinanciera.AgregarEntiFinanciera(txtgerencia.Text.ToString());
            }
            else
            {
                if (estado == 2 && ValidarDes(txtgerencia.Text))
                {
                    cEntiFinanciera.ActualizarEntiFinanciera(Convert.ToInt32(txtcodigo.Text), txtgerencia.Text.ToString());
                }
                else
                {
                    if (estado == 3)
                    {
                        if (MessageBox.Show("Seguró Desea Eliminar: " + txtgerencia.Text, "Hp Reserger", MessageBoxButtons.YesNo, MessageBoxIcon.Question).ToString() == "Yes")
                        {
                            cEntiFinanciera.EliminarEntiFinanciera(Convert.ToInt32(txtcodigo.Text));
                        }
                    }
                }
            }
            estado = 0;
            frmEntiFinanciera_Load(sender, e);
            Activar();
        }
    }
}
