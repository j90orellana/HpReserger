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
    public partial class frmgerencia : Form
    {
        public frmgerencia()
        {
            InitializeComponent();
        }
        public int estado { get; set; }
        HPResergerCapaLogica.HPResergerCL cgerencia = new HPResergerCapaLogica.HPResergerCL();
        private void frmgerencia_Load(object sender, EventArgs e)
        {
            estado = 0;
            dtgconten.DataSource = cgerencia.getCargoTipoContratacion("Id_Gerencia", "Gerencia", "TBL_Gerencia");            
            dtgconten.Focus();
            
        }
        public void Activar()
        {
            btnnuevo.Enabled = btneliminar.Enabled = btnmodificar.Enabled = dtgconten.Enabled = true;
        }
        public void Desactivar()
        {
            btnnuevo.Enabled = btneliminar.Enabled = btnmodificar.Enabled = dtgconten.Enabled = false;
        }
        public Boolean ValidarDes(string valor)
        {
            Boolean Aux = true;
            for (int i = 0; i < dtgconten.RowCount; i++)
            {
                if (dtgconten[1, i].Value.ToString() == valor)
                {
                    Aux = false;
                    MessageBox.Show("Este valor:" + txtgerencia.Text + " ya Existe", "Hp Reserger", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return Aux;
                }
            }
            return Aux;
        }
        private void btnnuevo_Click(object sender, EventArgs e)
        {
            
            tipmsg.Show("Ingrese Gerencia",txtgerencia,1000);
            txtcodigo.Text = txtgerencia.Text = "";
            estado = 1;
            Desactivar();
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
                frmgerencia_Load(sender, e);
            }
        }

        private void btnmodificar_Click(object sender, EventArgs e)
        {
            tipmsg.Show("Ingrese Gerencia",txtgerencia,700);
            Desactivar();
            estado = 2;
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            estado = 3;
            btnaceptar_Click(sender, e);
        }
        private void btnaceptar_Click(object sender, EventArgs e)
        {
            //Estado 1=Nuevo. Estado 2=modificar. Estado 3=eliminar. Estado 0=SinAcciones
            if (estado == 1 && ValidarDes(txtgerencia.Text))
            {
                cgerencia.AgregarGerencia(txtgerencia.Text.ToString());
            }
            else
            {
                if (estado == 2 && ValidarDes(txtgerencia.Text))
                {
                    cgerencia.ActualizarGerencia(Convert.ToInt32(txtcodigo.Text), txtgerencia.Text.ToString());
                }
                else
                {
                    if (estado == 3)
                    {
                        if (MessageBox.Show("Seguró Desea Eliminar " + txtgerencia.Text, "Hp Reserger", MessageBoxButtons.YesNo, MessageBoxIcon.Question).ToString() == "Yes")
                        {
                            cgerencia.EliminarGerencia(Convert.ToInt32(txtcodigo.Text));
                        }
                    }
                }
            }
            estado = 0;
            frmgerencia_Load(sender, e);
            Activar();
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
    }
}
