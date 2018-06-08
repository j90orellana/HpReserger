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
    public partial class frmmodelo : Form
    {
        public frmmodelo()
        {
            InitializeComponent();
        }
        public int estado { get; set; }
        public int codmarca { get; set; }
        HPResergerCapaLogica.HPResergerCL CModelo = new HPResergerCapaLogica.HPResergerCL();
        private void btnnuevo_Click(object sender, EventArgs e)
        {
            tipmsg.Show("Ingrese Modelo", txtmodelo, 1000);
            txtcodigo.Text = txtmodelo.Text = "";
            estado = 1;
            Desactivar();
        }

        private void btnmodificar_Click(object sender, EventArgs e)
        {
            tipmsg.Show("Ingrese Modelo", txtmodelo, 700);
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
                CargarModelo();
                Activar();
            }
        }

        private void btnaceptar_Click(object sender, EventArgs e)
        {
            //Estado 1=Nuevo. Estado 2=modificar. Estado 3=eliminar. Estado 0=SinAcciones
            if (estado == 1 && ValidarDes(txtmodelo.Text))
            {
                codmarca = dtgconten.RowCount + 1;
                CModelo.InsertarModelo(txtmodelo.Text);
                MessageBox.Show("Modelo Ingresada con Id: " + codmarca, CompanyName ,MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (estado == 2 && ValidarDes(txtmodelo.Text))
                {
                    CModelo.ActualizarModelo(Convert.ToInt32(txtcodigo.Text), txtmodelo.Text);
                    MessageBox.Show("Modelo Actualizada con Id: " + txtcodigo.Text, CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    if (estado == 3)
                    {
                        if (MessageBox.Show("Seguró Desea Eliminar " + txtmodelo.Text, CompanyName, MessageBoxButtons.YesNo, MessageBoxIcon.Question).ToString() == "Yes")
                        {
                            CModelo.EliminarModelo(Convert.ToInt32(txtcodigo.Text));
                            MessageBox.Show("Modelo Eliminada con Id: " + txtcodigo.Text, CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
            estado = 0;
            CargarModelo();
            Activar();
        }

        private void dtgconten_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtcodigo.Text = dtgconten[0, e.RowIndex].Value.ToString();
                txtmodelo.Text = dtgconten[1, e.RowIndex].Value.ToString();
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
                        MessageBox.Show("Este valor:" + txtmodelo.Text + " ya Existe", CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        return Aux;
                    }
                }
            }
            else
            {
                MessageBox.Show("Debe Ingresar Datos", CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Stop);
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

        public void CargarModelo()
        {
            estado = 0;
            dtgconten.DataSource = CModelo.getCargoTipoContratacion("Id_Modelo", "Modelo", "TBL_Modelo");
        }
        private void frmmarca_Load(object sender, EventArgs e)
        {
            CargarModelo();
            dtgconten.Focus();
        }

        private void frmmodelo_Load(object sender, EventArgs e)
        {
            CargarModelo();
            dtgconten.Focus();
            
        }        
        private void btnmarcamas_Click(object sender, EventArgs e)
        {
            frmmarca marca = new frmmarca();
            marca.Visible = true;
        }
    }
}
