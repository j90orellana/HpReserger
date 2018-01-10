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
    public partial class frmprovincias : Form
    {
        public frmprovincias()
        {
            InitializeComponent();
        }
        HPResergerCapaLogica.HPResergerCL Cprovincia = new HPResergerCapaLogica.HPResergerCL();
        public int estado { get; set; }
        public string busca { get; set; }
        public int coddep { get; set; }
        public int codpro { get; set; }
        public int codprofinal { get; set; }
        private void btnnuevo_Click(object sender, EventArgs e)
        {
            tipmsg.Show("Ingrese Nueva Provincia", cboprovincia, 700);
            txtcodigo.Text = cboprovincia.Text = "";
            estado = 1; Desactivar();
            cboprovincia.Focus();
            Txtbusca.Enabled = false;
            cboprovincia.DropDownStyle = ComboBoxStyle.DropDown;
        }

        private void btnmodificar_Click(object sender, EventArgs e)
        {
            tipmsg.Show("Ingrese Provincia", cboprovincia, 700);
            Desactivar();
            Txtbusca.Enabled = false;
            estado = 2;
            cboprovincia.Focus(); cboprovincia.DropDownStyle = ComboBoxStyle.DropDown;
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
                this.Visible = false;
            }
            else
            {
                estado = 0;
                Activar();
                frmprovincias_Load(sender, e); cboprovincia.DropDownStyle = ComboBoxStyle.DropDownList;
                Txtbusca.Enabled = true;
            }
        }

        private void btnaceptar_Click(object sender, EventArgs e)
        {
            //Estado 1=Nuevo. Estado 2=modificar. Estado 3=eliminar. Estado 0=SinAcciones
            if (estado == 1 && ValidarDes(cboprovincia.Text) && cboprovincia.Text != "")
            {
                for (int i = 0; i < dtgprovincias.RowCount - 1; i++)
                {
                    if ((i + 1) == Convert.ToInt32(dtgprovincias[1, i].Value.ToString()))
                    {
                        codpro = codprofinal + 1;
                    }
                    else
                    {
                        codpro = i + 1;
                        break;
                    }
                }
                Cprovincia.InsertarProvincia(coddep, codpro, cboprovincia.Text);
                MessageBox.Show("Provincia Ingresada Exitosamente con Id:'" + codpro + "'", "Hp Reserger", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                Txtbusca.Text = cboprovincia.Text; cboprovincia.DropDownStyle = ComboBoxStyle.DropDownList; Txtbusca.Enabled = true;
            }
            else
            {
                if (estado == 2 && ValidarDes(cboprovincia.Text))
                {
                    Cprovincia.ActualizarProvincia(coddep, codpro, cboprovincia.Text);
                    MessageBox.Show("Provincia Modificada Exitosamente", "Hp Reserger", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    Txtbusca.Text = cboprovincia.Text; cboprovincia.DropDownStyle = ComboBoxStyle.DropDownList; Txtbusca.Enabled = true;
                }
                else
                {
                    if (estado == 3)
                    {
                        if (MessageBox.Show("Seguró Desea Eliminar: " + cboprovincia.Text, "Hp Reserger", MessageBoxButtons.YesNo, MessageBoxIcon.Question).ToString() == "Yes")
                        {
                            Cprovincia.EliminarProvincia(coddep, codpro);
                            MessageBox.Show("Provincia Eliminada Exitosamente", "Hp Reserger", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            Txtbusca.Text = cboprovincia.Text; cboprovincia.DropDownStyle = ComboBoxStyle.DropDownList; Txtbusca.Enabled = true;
                        }
                    }
                }
            }
            estado = 0;
            Activar();
            Cargarprovincias(coddep, "");
            codpro = Convert.ToInt32(cboprovincia.SelectedValue.ToString());
            codprofinal = cboprovincia.Items.Count;
        }

        private void dtgconten_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtcodigo.Text = dtgconten[2, e.RowIndex].Value.ToString();
                cbodepartamento.Text = dtgconten[1, e.RowIndex].Value.ToString();
                cboprovincia.Text = dtgconten[3, e.RowIndex].Value.ToString();
            }
            catch { }
        }

        private void cbodepartamento_TextChanged(object sender, EventArgs e)
        {
            try
            {
                coddep = Convert.ToInt32(cbodepartamento.SelectedValue.ToString());
                Cargarprovincias(coddep, "");
                codpro = Convert.ToInt32(cboprovincia.SelectedValue.ToString());
                txtcodigo.Text = codpro.ToString();
                codprofinal = cboprovincia.Items.Count;
            }
            catch { }
        }

        private void cboprovincia_TextChanged(object sender, EventArgs e)
        {
            try
            {
                coddep = Convert.ToInt32(cbodepartamento.SelectedValue.ToString());
                codpro = Convert.ToInt32(cboprovincia.SelectedValue.ToString());
                txtcodigo.Text = codpro.ToString();
                codprofinal = cboprovincia.Items.Count;
            }
            catch { }
        }

        private void Txtbusca_TextChanged(object sender, EventArgs e)
        {
            estado = 0;
            dtgconten.DataSource = Cprovincia.ListarProvincias(Txtbusca.Text);
        }

        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            Txtbusca.Text = "";
        }

        private void btndepmas_Click(object sender, EventArgs e)
        {
            frmdepartamento frmdepartamento = new frmdepartamento();
            frmdepartamento.Show();
        }

        private void cboprovincia_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = char.ToUpper(e.KeyChar);
        }
        public Boolean ValidarDes(string valor)
        {
            Boolean Aux = true;
            if ( !string.IsNullOrWhiteSpace(cboprovincia.Text))
            {
                dtgprovincias.DataSource = Cprovincia.VerificarProvincia(coddep);
                for (int i = 0; i < dtgprovincias.RowCount - 1; i++)
                {
                    if (dtgprovincias[2, i].Value.ToString() == cboprovincia.Text)
                    {
                        MessageBox.Show("Ya existe: '" + cboprovincia.Text + " ' en Departamento:'" + cbodepartamento.Text + "'", "Hp Reserger", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        Txtbusca.Text = cboprovincia.Text;
                        Aux = false;
                        break;
                    }
                }
            }
            else
            {
                Aux = false;
                MessageBox.Show("Campo de Provincia Vacio", "Hp Reserger", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return Aux;
        }
        public void Cargardepartamentos(string busca)
        {
            cbodepartamento.DataSource = Cprovincia.ListarDepartamentos(busca);
            cbodepartamento.DisplayMember = "Departamento";
            cbodepartamento.ValueMember = "CodDep";
        }
        public void Cargarprovincias(int codigo, string busca)
        {
            cboprovincia.DataSource = Cprovincia.ListarProvincias(codigo, busca);
            cboprovincia.DisplayMember = "Provincia";
            cboprovincia.ValueMember = "CodProv";
        }
        private void frmprovincias_Load(object sender, EventArgs e)
        {
            busca = "";
            estado = 0;
            dtgconten.DataSource = Cprovincia.ListarProvincias(busca);
            Cargardepartamentos("");
            coddep = Convert.ToInt32(cbodepartamento.SelectedValue.ToString());
            Cargarprovincias(coddep, "");
            codpro = Convert.ToInt32(cboprovincia.SelectedValue.ToString());
            codprofinal = cboprovincia.Items.Count;
        }
        public void Desactivar()
        {
            btnnuevo.Enabled = btneliminar.Enabled = btnmodificar.Enabled = dtgconten.Enabled = false;

        }
        public void Activar()
        {
            btnnuevo.Enabled = btneliminar.Enabled = btnmodificar.Enabled = dtgconten.Enabled = true;

        }

        private void cbodepartamento_KeyUp(object sender, KeyEventArgs e)
        {
            
        }

        private void cbodepartamento_KeyPress(object sender, KeyPressEventArgs e)
        {
            HPResergerFunciones.Utilitarios.ToUpper(e);
        }
    }
}
