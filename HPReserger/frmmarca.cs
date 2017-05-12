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
    public partial class frmmarca : Form
    {
        public frmmarca()
        {
            InitializeComponent();
        }
        public int estado { get; set; }
        public int codmarca { get; set; }
        HPResergerCapaLogica.HPResergerCL Cmarca = new HPResergerCapaLogica.HPResergerCL();
        private void btnnuevo_Click(object sender, EventArgs e)
        {
            tipmsg.Show("Ingrese Marca", txtmarca, 1000);
            txtcodigo.Text = txtmarca.Text = "";
            estado = 1;
            Desactivar();
        }

        private void btnmodificar_Click(object sender, EventArgs e)
        {
            tipmsg.Show("Ingrese Marca", txtmarca, 700);
            Desactivar();
            estado = 2;
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            estado = 3;
            btnaceptar_Click(sender, e);
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
                CargarMarcas();
                Activar();
            }
        }

        private void btnaceptar_Click(object sender, EventArgs e)
        {
            //Estado 1=Nuevo. Estado 2=modificar. Estado 3=eliminar. Estado 0=SinAcciones
            if (estado == 1 && ValidarDes(txtmarca.Text))
            {
                codmarca = dtgconten.RowCount + 1;
                Cmarca.InsertarMarca(txtmarca.Text);
                MessageBox.Show("Marca Ingresada con Id: " + codmarca, "HpReserger", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (estado == 2 && ValidarDes(txtmarca.Text))
                {
                    Cmarca.ActualizarMarca(Convert.ToInt32(txtcodigo.Text), txtmarca.Text);
                    MessageBox.Show("Marca Actualizada con Id: " + txtcodigo.Text, "HpReserger", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    if (estado == 3)
                    {
                        if (MessageBox.Show("Seguró Desea Eliminar " + txtmarca.Text, "Hp Reserger", MessageBoxButtons.YesNo, MessageBoxIcon.Question).ToString() == "Yes")
                        {
                            Cmarca.EliminarMarca(Convert.ToInt32(txtcodigo.Text));
                            MessageBox.Show("Marca Eliminada con Id: " + txtcodigo.Text, "HpReserger", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
            estado = 0;
            CargarMarcas();
            Activar();
        }

        private void dtgconten_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtcodigo.Text = dtgconten[0, e.RowIndex].Value.ToString();
                txtmarca.Text = dtgconten[1, e.RowIndex].Value.ToString();
            }
            catch { }
        }
        public Boolean ValidarDes(string valor)
        {
            Boolean Aux = true;

            if (!string.IsNullOrWhiteSpace(valor))
            {
                for (int i = 0; i < dtgconten.RowCount; i++)
                {
                    if (dtgconten[1, i].Value.ToString() == valor)
                    {
                        Aux = false;
                        MessageBox.Show("Este valor:" + txtmarca.Text + " ya Existe", "Hp Reserger", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        return Aux;
                    }
                }
            }
            else
            {
                MessageBox.Show("Debe Ingresar Datos", "Hp Reserger", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                Aux = false;
            }
            return Aux;
        }
        public void Activar()
        {
            btnnuevo.Enabled = btneliminar.Enabled = btnmodificar.Enabled = dtgconten.Enabled = true;
        }
        public void Desactivar()
        {
            btnnuevo.Enabled = btneliminar.Enabled = btnmodificar.Enabled = dtgconten.Enabled = false;
        }

        public void CargarMarcas()
        {
            estado = 0;
            dtgconten.DataSource = Cmarca.getCargoTipoContratacion("Id_Marca", "Marca", "TBL_Marca");
        }
        private void frmmarca_Load(object sender, EventArgs e)
        {
            CargarMarcas();
            dtgconten.Focus();
        }
    }
}
