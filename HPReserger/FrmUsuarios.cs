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
    public partial class FrmUsuarios : Form
    {
        public FrmUsuarios()
        {
            InitializeComponent();
        }
        HPResergerCapaLogica.HPResergerCL Cusuario = new HPResergerCapaLogica.HPResergerCL();
        public void CargarEstado(ComboBox combito)
        {
            DataTable tablita = new DataTable();
            tablita.Columns.Add("CODIGO");
            tablita.Columns.Add("VALOR");
            tablita.Rows.Add(new object[] { "1", "ACTIVO" });
            tablita.Rows.Add(new object[] { "0", "INACTIVO" });
            combito.DataSource = tablita;
            combito.DisplayMember = "VALOR";
            combito.ValueMember = "CODIGO";
            combito.SelectedIndex = 0;
        }
        public void CargarPerfil(ComboBox combito)
        {
            combito.DataSource = Cusuario.getCargoTipoContratacion("Codgo_Perfil_User", "Desc_Perfil_User", "TBL_Perfil_User");
            combito.DisplayMember = "DESCRIPCION";
            combito.ValueMember = "CODIGO";

        }
        public void CargarTipoDocumento(ComboBox combito)
        {
            combito.DataSource = Cusuario.getCargoTipoContratacion("Codigo_Tipo_ID", "Desc_Tipo_ID", "TBL_Tipo_ID");
            combito.DisplayMember = "DESCRIPCION";
            combito.ValueMember = "CODIGO";
            combito.SelectedIndex = 0;

        }
        public void CargarArea(ComboBox combito)
        {
            combito.DataSource = Cusuario.ListarAreaGerencia();
            combito.DisplayMember = "AREA";
            combito.ValueMember = "CODIGO";

        }
        private void label2_Click(object sender, EventArgs e)
        {

        }
        public void bloqueado(Boolean si)
        {
            txtnombre.Enabled = txtapepat.Enabled = txtapetmat.Enabled = cboarea.Enabled = !si;

        }
        public void limpiar()
        {
            txtapepat.Text = txtapetmat.Text = txtcontra.Text = txtlogin.Text = txtnombre.Text = "";
            cboarea.DataSource = cboestado.DataSource = cboperfil.DataSource = null;
        }
        private void FrmUsuarios_Load(object sender, EventArgs e)
        {
            estado = 0; CargarTipoDocumento(cbotipoid);
            txtid.Focus();
            bloqueado(true);
            btnmodificar.Enabled = btneliminar.Enabled = false;
            cbotipoid.Enabled = true;
            txtlogin.Enabled = txtcontra.Enabled = false; cboperfil.Enabled = cboestado.Enabled = false;

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                txtcontra.UseSystemPasswordChar = true;
            }
            else
            {
                txtcontra.UseSystemPasswordChar = false;
            }
        }

        private void txtcontra_TextChanged(object sender, EventArgs e)
        {

        }
        public void Mensajes(string cadena)
        {
            MessageBox.Show(cadena, "HpReserger", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void buscar()
        {

        }
        private void txtid_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int cadena = Convert.ToInt32(cbotipoid.SelectedValue.ToString());
                if (txtid.Text.Length > 0)
                {
                    if (estado == 0)
                    {
                        dtgconten.DataSource = Cusuario.usuarios(txtid.Text, cadena, 1);
                        if (dtgconten.RowCount > 0)
                        {
                            checkBox1.Enabled = true; btnnuevo.Enabled = true;
                            btnmodificar.Enabled = btneliminar.Enabled = true;
                            cboperfil.Enabled = cboestado.Enabled = false;
                            txtlogin.Enabled = false; txtcontra.Enabled = false;

                        }
                        else
                        {
                            bloqueado(true);
                            limpiar();
                            btnmodificar.Enabled = btneliminar.Enabled = false;
                            txtlogin.Enabled = false; txtcontra.Enabled = false;
                            //
                            checkBox1.Enabled = false; cboperfil.Enabled = cboestado.Enabled = false;
                            txtlogin.Enabled = false; txtcontra.Enabled = false;

                        }
                    }//solo si nuevo
                    if (estado == 1)
                    {
                        dtgconten.DataSource = Cusuario.usuarios(txtid.Text, cadena, 2);
                        if (dtgconten.RowCount > 0)
                        {
                            checkBox1.Enabled = true; cboperfil.Enabled = cboestado.Enabled = true;
                            txtlogin.Enabled = true; txtcontra.Enabled = true;
                            txtnombre.Enabled = txtapepat.Enabled = txtapetmat.Enabled = cboarea.Enabled = false;
                            btnnuevo.Enabled = false;
                            txtid.Enabled = false;
                            cbotipoid.Enabled = false;
                        }
                        else
                        {
                            //bloqueado(true);
                            limpiar(); checkBox1.Enabled = false;btnnuevo.Enabled = false;
                            cboperfil.Enabled = cboestado.Enabled = false;
                            txtlogin.Enabled = false; txtcontra.Enabled = false; txtid.Enabled = true;
                            cbotipoid.Enabled = true;
                        }

                    }
                    if (estado == 3)
                    {
                        dtgconten.DataSource = Cusuario.usuarios(txtid.Text, cadena, 1);

                        if (dtgconten.RowCount > 0)
                        {
                            checkBox1.Enabled = true; btnnuevo.Enabled = true;
                            btnmodificar.Enabled = btneliminar.Enabled = true;
                            estado = 0;
                        }
                        else
                        {
                            bloqueado(true);
                            limpiar();
                            btnmodificar.Enabled = btneliminar.Enabled = false;
                            txtlogin.Enabled = true; txtcontra.Enabled = false;
                            checkBox1.Enabled = false; estado = 0;

                        }
                    }
                }
            }
            catch { }

        }
        public void CargarCombos()
        {
            CargarEstado(cboestado);
            CargarPerfil(cboperfil);
            CargarArea(cboarea);
        }
        private void dtgconten_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                CargarCombos();
                ////////////////
                cbotipoid.SelectedValue = dtgconten[0, 0].Value;
                txtnombre.Text = dtgconten[2, 0].Value.ToString();
                txtapepat.Text = dtgconten[3, 0].Value.ToString();
                txtapetmat.Text = dtgconten[4, 0].Value.ToString();
                cboarea.SelectedValue = dtgconten[5, 0].Value;
                cboperfil.SelectedValue = dtgconten[7, 0].Value;
                txtlogin.Text = dtgconten[9, 0].Value.ToString();
                txtcontra.Text = dtgconten[10, 0].Value.ToString();
                cboestado.SelectedValue = dtgconten[11, 0].Value;
            }
            catch { }

        }
        public void Activar(Boolean si)
        {
             btnmodificar.Enabled = btneliminar.Enabled = si;
        }
        public int estado = 0;
        private void btnnuevo_Click(object sender, EventArgs e)
        {
            CargarCombos();
            estado = 1; txtid.Text = "";
            bloqueado(true);
            Activar(false);
            limpiar();btnnuevo.Enabled = false;
            txtid.Enabled = cbotipoid.Enabled = true;
            txtid.Focus();
        }
        private void btnmodificar_Click(object sender, EventArgs e)
        {
            estado = 2;
            bloqueado(true);
            Activar(false);
            cbotipoid.Enabled = false;
            txtid.Enabled = false;
            checkBox1.Enabled = true;
            cboperfil.Enabled = true;
            txtlogin.Enabled = true;
            txtcontra.Enabled = true;
            cboestado.Enabled = true;

        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            estado = 3;
            if (MessageBox.Show("Desea dar de Baja a este Usuario", "HpReserger", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                btnaceptar_Click(sender, e);
            }
            Activar(false); estado = 0;
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            if (estado == 0)
            {
                this.Close();
            }
            if (estado == 1)
            {
                btnnuevo.Enabled = true; cboperfil.Enabled = false;
                txtlogin.Enabled = false;limpiar();
                txtcontra.Enabled = false; txtid.Enabled = cbotipoid.Enabled = true; txtid.Text = "";
                cboestado.Enabled = false; estado = 0;
                txtid_TextChanged(sender, e);
            }
            if (estado == 2)
            {
                cbotipoid.Enabled = true;
                txtid.Enabled = true;
                checkBox1.Enabled = true;
                cboperfil.Enabled = false;
                txtlogin.Enabled = false;
                txtcontra.Enabled = false;
                cboestado.Enabled = false;
                txtid_TextChanged(sender, e);
            }
            if (estado == 3)
            {
                bloqueado(true);
                btnnuevo.Enabled = true; txtid_TextChanged(sender, e); estado = 0;
                btnnuevo.Enabled = true;
            }

            estado = 0;
        }
        public int tipoid;
        public string nroid;
        public string login;
        public string contra;
        public int perfil;
        public int estadito;
        public void CargarValores()
        {
            tipoid = Convert.ToInt32(cbotipoid.SelectedValue.ToString());
            nroid = txtid.Text;
            login = txtlogin.Text;
            contra = txtcontra.Text;
            perfil = Convert.ToInt32(cboperfil.SelectedValue.ToString());
            estadito = Convert.ToInt32(cboestado.SelectedValue.ToString());
        }
        private void btnaceptar_Click(object sender, EventArgs e)
        {
            //estado 1=nuevo 2=modificar 3=eliminar
            if (estado == 1)
            {
                if (string.IsNullOrWhiteSpace(txtlogin.Text) || string.IsNullOrWhiteSpace(txtcontra.Text))
                {
                    Mensajes("El Campo Login y Password, No deben estar Vacios");
                }
                else
                {
                    if (txtlogin.Text.Length < 5)
                    {
                        Mensajes("Campo Login 5 Caracteres minimo");
                    }
                    else
                    {
                        if (txtcontra.Text.Length < 4)
                        {
                            Mensajes("Contraseña muy pequeña: 4 caracteres minimo");
                        }
                        else
                        {
                            CargarValores(); int respuesta = 0;
                            Cusuario.InsertarActualizarUsuario(tipoid, nroid, login, contra, perfil, estadito, 1, out respuesta);
                            if (respuesta == 1)
                            {
                                Mensajes("Ese Login ya Existe");
                                //txtcontra.Text = txtlogin.Text = "";txtid_TextChanged(sender, e);
                            }
                            else
                            {
                                Mensajes("Usuario Creado Exitosamente");bloqueado(true);
                                estado = 0;txtid.Enabled = cbotipoid.Enabled = true;estado = 0;
                                txtid_TextChanged(sender, e);
                            }
                        }
                    }

                }
            }
            if (estado == 2)
            {
                if (string.IsNullOrWhiteSpace(txtlogin.Text) || string.IsNullOrWhiteSpace(txtcontra.Text))
                {
                    Mensajes("El Campo Login y Password, No deben estar Vacios");
                }
                else
                {
                    if (txtlogin.Text.Length < 5)
                    {
                        Mensajes("Campo Login 5 Caracteres minimo");
                    }
                    else
                    {
                        if (txtcontra.Text.Length < 4)
                        {
                            Mensajes("Contraseña muy pequeña");
                        }
                        else
                        {
                            CargarValores(); int respuesta = 0;
                            Cusuario.InsertarActualizarUsuario(tipoid, nroid, login, contra, perfil, estadito, 2, out respuesta);
                            if (respuesta == 1)
                            {
                                Mensajes("Ese Login ya Existe");
                                //txtcontra.Text = txtlogin.Text = "";txtid_TextChanged(sender, e);
                            }
                            else
                            {
                                Mensajes("Usuario Actualizado Exitosamente"); Activar(false);
                                bloqueado(true); checkBox1.Checked = true; estado = 0; txtid.Enabled = cbotipoid.Enabled = true;
                                txtid_TextChanged(sender, e);

                            }
                        }
                    }

                }
            }
            if (estado == 3)
            {
                CargarValores(); int respuesta = 0;
                Cusuario.InsertarActualizarUsuario(tipoid, nroid, login, contra, perfil, 0, 3, out respuesta);
                Mensajes("Usuario Eliminado Exitosamente");
                bloqueado(true); checkBox1.Checked = true; btnnuevo.Enabled = true;
                txtid_TextChanged(sender, e);
            }
        }
        public void msg(string cadena)
        {
            lblmensaje.Text = cadena;
        }

        private void txtid_Click(object sender, EventArgs e)
        {
            //txtid.SelectAll();
        }

        private void cbotipoid_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbotipoid_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (txtid.Text.Length > 5)
            {
                txtid_TextChanged(sender, e);
            }
        }

        private void txtlogin_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtlogin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtcontra.Focus();
            }
            if (e.KeyCode == Keys.Down)
            {
                txtcontra.Focus();
            }
        }

        private void txtcontra_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnaceptar.Focus();
            }
            if (e.KeyCode == Keys.Down)
            {
                btnaceptar.Focus();
            }
            if (e.KeyCode == Keys.Up)
            {
                txtlogin.Focus();
            }
        }

        private void txtid_KeyPress(object sender, KeyPressEventArgs e)
        {
            HPResergerFunciones.Utilitarios.SoloNumerosEnteros(e);
        }

        private void txtid_KeyDown(object sender, KeyEventArgs e)
        {
            HPResergerFunciones.Utilitarios.Validardocumentos(e, txtid, 15);
        }
    }
}
