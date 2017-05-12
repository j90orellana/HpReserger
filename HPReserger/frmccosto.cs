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
    public partial class frmccosto : Form
    {
        public frmccosto()
        {
            InitializeComponent();
        }
        public int estado { get; set; }
        HPResergerCapaLogica.HPResergerCL Ccostos = new HPResergerCapaLogica.HPResergerCL();
        private void frmccosto_Load(object sender, EventArgs e)
        {
            estado = 0;
            dtgconten.DataSource = Ccostos.getCargoTipoContratacion("Id_CCosto", "CentroCosto", "TBL_Centro_Costo");
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

        private void btncancelar_Click(object sender, EventArgs e)
        {
            if (estado == 0)
            {
                this.Visible = false;
            }
            else
            {
                estado = 0;
                Activar();
                frmccosto_Load(sender, e);
            }
        }

        private void btnnuevo_Click(object sender, EventArgs e)
        {

            tipmsg.Show("Ingrese Centro de Costo", txtcosto, 1000);
            txtcodigo.Text = txtcosto.Text = "";
            estado = 1;
            Desactivar();
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            estado = 3;
            btnaceptar_Click(sender, e);
        }

        private void btnmodificar_Click(object sender, EventArgs e)
        {
            tipmsg.Show("Ingrese Centro de Costo", txtcosto, 700);
            Desactivar();
            estado = 2;
        }

        private void btnaceptar_Click(object sender, EventArgs e)
        {
            //Estado 1=Nuevo. Estado 2=modificar. Estado 3=eliminar. Estado 0=SinAcciones
            if (!string.IsNullOrWhiteSpace(txtcosto.Text))
            {
                if (estado == 1 && ValidarDes(txtcosto.Text))
                {
                    Ccostos.InsertarCentroCostros(txtcosto.Text);
                    MessageBox.Show("Centro de Costo, Ingresado", "Hp Reserger", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    if (estado == 2 && ValidarDes(txtcosto.Text))
                    {
                       Ccostos.ActualizarCentroCostos( txtcosto.Text.ToString(), Convert.ToInt32(txtcodigo.Text));
                        MessageBox.Show("Centro de Costo, Actualizado", "Hp Reserger", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        if (estado == 3)
                        {
                            if (MessageBox.Show("Seguró Desea Eliminar " + txtcosto.Text, "Hp Reserger", MessageBoxButtons.YesNo, MessageBoxIcon.Question).ToString() == "Yes")
                            {
                                //Ccostos.EliminarGerencia(Convert.ToInt32(txtcodigo.Text));
                            }
                        }
                    }
                }
                estado = 0;
                frmccosto_Load(sender, e);
                Activar();
            }
            else { MessageBox.Show("Debe Rellenar el campo Descripción", "Hp Reserger",MessageBoxButtons.OK,MessageBoxIcon.Information); }
        }
        public Boolean ValidarDes(string valor)
        {
            Boolean Aux = true;
            for (int i = 0; i < dtgconten.RowCount; i++)
            {
                if (dtgconten[1, i].Value.ToString() == valor)
                {
                    Aux = false;
                    MessageBox.Show("Este valor:" + txtcosto.Text + " ya Existe", "Hp Reserger", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return Aux;
                }
            }
            return Aux;
        }
        private void dtgconten_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtcodigo.Text = dtgconten[0, e.RowIndex].Value.ToString();
                txtcosto.Text = dtgconten[1, e.RowIndex].Value.ToString();
            }
            catch { }
        }
    }
}
