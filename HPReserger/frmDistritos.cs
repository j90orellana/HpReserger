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
    public partial class frmDistritos : Form
    {
        public frmDistritos()
        {
            InitializeComponent();
        }
        HPResergerCapaLogica.HPResergerCL CDistrito = new HPResergerCapaLogica.HPResergerCL();
        HPResergerCapaLogica.HPResergerCL CDepartamento = new HPResergerCapaLogica.HPResergerCL();
        HPResergerCapaLogica.HPResergerCL cDistritos = new HPResergerCapaLogica.HPResergerCL();
        public int estado { get; set; }
        public string busca { get; set; }
        public int coddep { get; set; }
        public int codpro { get; set; }
        public int coddis { get; set; }
        public int coddisfinal { get; set; }
        private void btnnuevo_Click(object sender, EventArgs e)
        {
            tipmsg.Show("Ingrese Nuevo Distrito", cbodistrito, 700);
            txtcodigo.Text = cbodistrito.Text = "";
            estado = 1; Desactivar();
            cbodistrito.Focus();
        }
        public void Cargarprovincias(int codigo, string busca)
        {
            cboprovincia.DataSource = CDepartamento.ListarProvincias(codigo, busca);
            cboprovincia.DisplayMember = "Provincia";
            cboprovincia.ValueMember = "CodProv";
        }
        public void Cargardepartamentos(string busca)
        {
            cbodepartamento.DataSource = CDepartamento.ListarDepartamentos(busca);
            cbodepartamento.DisplayMember = "Departamento";
            cbodepartamento.ValueMember = "CodDep";
        }
        public void CargarDistritos(int coddep, int codpro, string busca)
        {
            cbodistrito.DataSource = cDistritos.ListarDistrito(coddep, codpro, busca);
            cbodistrito.DisplayMember = "Distrito";
            cbodistrito.ValueMember = "CodDis";
        }
        private void btnmodificar_Click(object sender, EventArgs e)
        {
            tipmsg.Show("Ingrese Distrito", cbodistrito, 700);
            Desactivar();
            estado = 2;
            cbodistrito.Focus();
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            estado = 3;
            btnaceptar_Click(sender, e);
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
            dtgdistritos.DataSource = CDistrito.verificardistrito(coddep, codpro);
            for (int i = 0; i <= dtgdistritos.RowCount - 1; i++)
            {
                if (dtgdistritos[3, i].Value.ToString() == cbodistrito.Text)
                {
                    MessageBox.Show("Ya existe: '" + cbodistrito.Text + " '", "Hp Reserger", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Aux = false;
                    break;
                }
            }
            return Aux;
        }

        private void frmDistritos_Load(object sender, EventArgs e)
        {
            busca = "";
            estado = 0;
            dtgconten.DataSource = CDistrito.ListarDistritos(busca);
            Cargardepartamentos("");
            coddep = Convert.ToInt32(cbodepartamento.SelectedValue.ToString());
            Cargarprovincias(coddep, "");
            codpro = Convert.ToInt32(cboprovincia.SelectedValue.ToString());
            CargarDistritos(coddep, codpro, "");
            coddis = Convert.ToInt32(cbodistrito.SelectedValue.ToString());
            coddisfinal = cbodistrito.Items.Count;
            //dtgconten.Focus();
        }

        private void btnaceptar_Click(object sender, EventArgs e)
        {
            //Estado 1=Nuevo. Estado 2=modificar. Estado 3=eliminar. Estado 0=SinAcciones
            if (estado == 1 && ValidarDes(cbodistrito.Text) && cbodistrito.Text != "")
            {
                for (int i = 0; i < dtgdistritos.RowCount - 1; i++)
                {
                    if ((i + 1) == Convert.ToInt32(dtgdistritos[2, i].Value.ToString()))
                    {
                        coddis = coddisfinal;
                    }
                    else
                    {
                        coddis = i + 1;
                        break;
                    }
                }
                CDistrito.insertardistrito(coddep, codpro, coddis, cbodistrito.Text);
                MessageBox.Show("Distrito Ingresado Exitosamente", "Hp Reserger", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                Txtbusca.Text = cbodistrito.Text;
            }
            else
            {
                if (estado == 2 && ValidarDes(cbodistrito.Text))
                {
                    CDistrito.modificardistrito(coddep, codpro, coddis, cbodistrito.Text);
                    MessageBox.Show("Distrito Modificado Exitosamente", "Hp Reserger", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    Txtbusca.Text = cbodistrito.Text;
                }
                else
                {
                    if (estado == 3)
                    {
                        if (MessageBox.Show("Seguró Desea Eliminar: " + cbodistrito.Text, "Hp Reserger", MessageBoxButtons.YesNo, MessageBoxIcon.Question).ToString() == "Yes")
                        {
                            CDistrito.eliminardistrito(coddep, codpro, coddis);
                            MessageBox.Show("Distrito Eliminado Exitosamente", "Hp Reserger", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            Txtbusca.Text = "";
                        }
                    }
                }
            }
            estado = 0;
            Activar();
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
                frmDistritos_Load(sender, e);
            }
        }

        private void dtgconten_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtcodigo.Text = dtgconten[4, e.RowIndex].Value.ToString();
                cbodepartamento.Text = dtgconten[1, e.RowIndex].Value.ToString();
                cboprovincia.Text = dtgconten[3, e.RowIndex].Value.ToString();
                cbodistrito.Text = dtgconten[5, e.RowIndex].Value.ToString();
            }
            catch { }
        }
        private void txtbusca_TextChanged(object sender, EventArgs e)
        {
            estado = 0;
            dtgconten.DataSource = CDistrito.ListarDistritos(Txtbusca.Text);
        }



        private void cboprovincia_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                coddep = Convert.ToInt32(cbodepartamento.SelectedValue.ToString());
                codpro = Convert.ToInt32(cboprovincia.SelectedValue.ToString());
                CargarDistritos(coddep, codpro, "");
                coddis = Convert.ToInt32(cbodistrito.SelectedValue.ToString());
                txtcodigo.Text = coddis.ToString();
                coddisfinal = cbodistrito.Items.Count;
            }
            catch { }
        }

        private void cbodistrito_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                coddis = Convert.ToInt32(cbodistrito.SelectedValue.ToString());
                txtcodigo.Text = coddis.ToString();
                coddisfinal = cbodistrito.Items.Count;
            }
            catch { }
        }

        private void cbodepartamento_TextChanged(object sender, EventArgs e)
        {
            try
            {
                coddep = Convert.ToInt32(cbodepartamento.SelectedValue.ToString());
                Cargarprovincias(coddep, "");
                coddis = Convert.ToInt32(cbodistrito.SelectedValue.ToString());
                txtcodigo.Text = coddis.ToString();
                coddisfinal = cbodistrito.Items.Count;
            }
            catch { }
        }

        private void cboprovincia_TextChanged(object sender, EventArgs e)
        {
            try
            {
                coddep = Convert.ToInt32(cbodepartamento.SelectedValue.ToString());
                codpro = Convert.ToInt32(cboprovincia.SelectedValue.ToString());
                CargarDistritos(coddep, codpro, "");
                coddis = Convert.ToInt32(cbodistrito.SelectedValue.ToString());
                txtcodigo.Text = coddis.ToString();
                coddisfinal = cbodistrito.Items.Count;
            }
            catch { }
        }

        private void cbodistrito_TextChanged(object sender, EventArgs e)
        {

            try
            {
                coddis = Convert.ToInt32(cbodistrito.SelectedValue.ToString());
                txtcodigo.Text = coddis.ToString();
                coddisfinal = cbodistrito.Items.Count;
            }
            catch { }
        }

        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            Txtbusca.Text = "";
        }

        private void cbodistrito_KeyPress(object sender, KeyPressEventArgs e)
        {
            HPResergerFunciones.Utilitarios.ToUpper(e);
        }

        private void btndepmas_Click(object sender, EventArgs e)
        {
            frmdepartamento frmdepartamento = new frmdepartamento();
            frmdepartamento.ShowDialog();
            presionado = 1;
        }

        private void btnpromas_Click(object sender, EventArgs e)
        {
            frmprovincias Provincias = new frmprovincias();
            Provincias.ShowDialog();
            presionado = 2;
        }

        private void dtgconten_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        public int presionado = 0;
        private void frmDistritos_Activated(object sender, EventArgs e)
        {
            if (presionado == 1)//presiono departamentos
            { Cargardepartamentos(""); }
            if (presionado == 2)//presiono provincia
            {
                Cargarprovincias(coddep, "");
            }
            //frmDistritos_Load(sender,e);

        }

        private void cbodepartamento_KeyPress(object sender, KeyPressEventArgs e)
        {
            HPResergerFunciones.Utilitarios.ToUpper(e);
        }

        private void cboprovincia_KeyPress(object sender, KeyPressEventArgs e)
        {
            HPResergerFunciones.Utilitarios.ToUpper(e);
        }
    }
}
