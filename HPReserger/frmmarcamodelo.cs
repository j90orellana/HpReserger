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
    public partial class frmmarcamodelo : Form
    {
        public frmmarcamodelo()
        {
            InitializeComponent();
        }
        public HPResergerCapaLogica.HPResergerCL CArticulo = new HPResergerCapaLogica.HPResergerCL();
        public int estado { get; set; }
        public int modmarca { get; set; }
        public int modmodelo { get; set; }
        public int marca { get; set; }
        public int modelo { get; set; }
        private void btnmarcamas_Click(object sender, EventArgs e)
        {
            frmmarca marca = new frmmarca();
            marca.Show();
        }
        public void CargarMarcas()
        {
            try
            {
                cbomarca.DataSource = CArticulo.getCargoTipoContratacion2("Id_Marca", "Marca", "TBL_Marca");
                cbomarca.DisplayMember = "DESCRIPCION";
                cbomarca.ValueMember = "CODIGO";
                cbomarca.Sorted = true;
            }
            catch { }
        }

        public void CargarModelos()
        {
            try
            {
                cbomodelo.DataSource = CArticulo.getCargoTipoContratacion2("Id_Modelo", "Modelo", "TBL_Modelo");
                cbomodelo.DisplayMember = "DESCRIPCION";
                cbomodelo.ValueMember = "CODIGO";
                cbomodelo.Sorted = true;
            }
            catch { }
        }
        public DataTable CargarModeloMarca(string busca)
        {
            return CArticulo.ListarModeloMarcas(busca);

        }
        public void msg(DataGridView conteo)
        {
            lblmsg.Text = "Total Registros: " + conteo.RowCount;
        }
        private void frmmarcacodigo_Load(object sender, EventArgs e)
        {

            CargarMarcas();
            CargarModelos();
            dtgconten.DataSource = CArticulo.ListarModeloMarcas("");
            msg(dtgconten);

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
            }
        }
        public void Activar()
        {
            btnnuevo.Enabled = btneliminar.Enabled = btnmodificar.Enabled = dtgconten.Enabled = true;
            cbomarca.Enabled = cbomodelo.Enabled = true;
            Txtbusca.Enabled = true;
        }
        public void Desactivar()
        {
            btnnuevo.Enabled = btneliminar.Enabled = btnmodificar.Enabled = dtgconten.Enabled = false;
            cbomarca.Enabled = cbomodelo.Enabled = true;
            Txtbusca.Enabled = false;
        }

        private void btnmodificar_Click(object sender, EventArgs e)
        {
            Desactivar();
            estado = 2;
        }

        public Boolean VerificarDatos(int marca, int modelo)
        {
            Boolean aux = true;
            if (CArticulo.VerificarMarcaModelo(marca, modelo).Rows.Count > 0)
            {
                MessageBox.Show("Ya Existe esa Relación Id:" + cbomarca.Text + "=" + marca + " : " + cbomodelo.Text + "=" + modelo, CompanyName, MessageBoxButtons.OK);
                aux = false;
            }
            return aux;
        }
        private void btnnuevo_Click(object sender, EventArgs e)
        {
            estado = 1; Desactivar();

        }

        private void cbomarca_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbomarca_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = char.ToUpper(e.KeyChar);
        }

        private void cbomodelo_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = char.ToUpper(e.KeyChar);
        }

        private void btnmodelomas_Click(object sender, EventArgs e)
        {
            frmmodelo modelo = new frmmodelo();
            modelo.Visible = true;
        }

        private void dtgconten_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            int y = e.RowIndex;
            cbomarca.Text = dtgconten[1, y].Value.ToString();
            cbomodelo.Text = dtgconten[3, y].Value.ToString();

            modmarca = Convert.ToInt32(dtgconten[0, y].Value.ToString());
            modmodelo = Convert.ToInt32(dtgconten[2, y].Value.ToString());
        }

        private void Txtbusca_TextChanged(object sender, EventArgs e)
        {
            dtgconten.DataSource = CargarModeloMarca(Txtbusca.Text);
            msg(dtgconten);
        }

        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            Txtbusca.Text = "";
        }

        private void btnaceptar_Click(object sender, EventArgs e)
        {
            //Estado 1=Nuevo. Estado 2=modificar. Estado 3=eliminar. Estado 0=SinAcciones

            marca = Convert.ToInt32(cbomarca.SelectedValue.ToString());
            modelo = Convert.ToInt32(cbomodelo.SelectedValue.ToString());

            if (estado == 1 && VerificarDatos(marca, modelo))
            {
                CArticulo.InsertarMarcaModelo(marca, modelo);
                MessageBox.Show("Relación Insertada Exitosamente "+marca+";"+modelo, CompanyName ,MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (estado == 2 && VerificarDatos(marca, modelo))
                {
                    CArticulo.ActualizarMarcaModelo(marca, modelo, modmarca, modmodelo);estado = 0;
                    MessageBox.Show("Relación Modificada Exitosamente ", CompanyName ,MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    if (estado == 3)
                    {
                        if (MessageBox.Show("Seguró Desea Eliminar; Marca: " + cbomarca.Text + " Modelo: " + cbomodelo.Text, CompanyName, MessageBoxButtons.YesNo, MessageBoxIcon.Question).ToString() == "Yes")
                        {
                            CArticulo.EliminarMarcaModelo(marca, modelo);estado = 0;
                            MessageBox.Show("Relación Modificada Exitosamente ", CompanyName ,MessageBoxButtons.OK, MessageBoxIcon.Information);

                        }
                    }
                }
            }estado = 0;
            CargarMarcas();
            CargarModelos();
            dtgconten.DataSource = CargarModeloMarca("");
            Activar();
        }

        private void frmmarcamodelo_Activated(object sender, EventArgs e)
        {
            if (estado != 2)
            {
                CargarMarcas();
                CargarModelos();
            }

        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            estado = 3;
            btnaceptar_Click(sender, e);
        }
    }
}
