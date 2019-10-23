using HpResergerUserControls;
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
    public partial class FrmUsuarios : FormGradient
    {
        public FrmUsuarios()
        {
            InitializeComponent();
        }
        HPResergerCapaLogica.HPResergerCL Cusuario = new HPResergerCapaLogica.HPResergerCL();
        public void msg(string cadena) { HPResergerFunciones.frmInformativo.MostrarDialogError(cadena); }
        public void msgOK(string cadena) { HPResergerFunciones.frmInformativo.MostrarDialog(cadena); }
        public void CargarEstado(ComboBox combito)
        {
            DataTable tablita = new DataTable();
            tablita.Columns.Add("CODIGO", typeof(int));
            tablita.Columns.Add("VALOR", typeof(string));
            tablita.Rows.Add(new object[] { 1, "ACTIVO" });
            tablita.Rows.Add(new object[] { 0, "INACTIVO" });
            tablita.Rows.Add(new object[] { 3, "TEMPORAL" });
            combito.DataSource = tablita;
            combito.DisplayMember = "VALOR";
            combito.ValueMember = "CODIGO";
            combito.SelectedIndex = 0;
        }
        public int LengthTipoId
        {
            get { return txtid.MaxLength; }
            set { txtid.MaxLength = value; }
        }
        public void CargarPerfil(ComboBox combito)
        {
            combito.DataSource = Cusuario.getCargoTipoContratacion("Codgo_Perfil_User", "Desc_Perfil_User", "TBL_Perfil_User");
            combito.DisplayMember = "DESCRIPCION";
            combito.ValueMember = "CODIGO";
        }
        public void CargarTipoDocumento(ComboBox combito)
        {
            Cusuario.TablaTipoId(combito);
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
            btnnuevoTemporal.Enabled = txtnombre.Enabled = txtapepat.Enabled = txtapetmat.Enabled = cboarea.Enabled = !si;
        }
        public void limpiar()
        {
            txtapepat.Text = txtapetmat.Text = txtcontra.Text = txtlogin.Text = txtnombre.Text = "";
            cboarea.SelectedIndex = cboestado.SelectedIndex = cboperfil.SelectedIndex = -1;
        }
        public void CargarUsuarios()
        {
            GridUser.DataSource = Cusuario.usuarios("0", 0, 0);
            lblmsg.Text = $"Total de Registros : {GridUser.RowCount}";
        }
        private void FrmUsuarios_Load(object sender, EventArgs e)
        {
            CargarArea(cboarea);
            CargarPerfil(cboperfil);
            CargarEstado(cboestado);
            btnlimpiar_Click(sender, e);
            estado = 0; CargarTipoDocumento(cbotipoid);
            txtid.Focus();
            bloqueado(true);
            btnmodificar.Enabled = btneliminar.Enabled = false;
            cbotipoid.Enabled = true;
            txtlogin.Enabled = txtcontra.Enabled = false; cboperfil.Enabled = cboestado.Enabled = false;
            CargarUsuarios();
            btnnuevoTemporal.Enabled = true;
            ModoEdicion(true);
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
        public void buscar()
        {

        }
        public void Cargar()
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
        private void txtid_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int cadena = Convert.ToInt32(cbotipoid.SelectedValue.ToString());
                if (txtid.Text.Length > 0)
                {
                    if (estado == 0 || estado == 3)
                    {
                        dtgconten.DataSource = Cusuario.usuarios(txtid.Text, cadena, 1);
                        if (dtgconten.RowCount > 0)
                        {
                            checkBox1.Enabled = true; btnnuevo.Enabled = true;
                            btnmodificar.Enabled = btneliminar.Enabled = true;
                            cboperfil.Enabled = cboestado.Enabled = false;
                            txtlogin.Enabled = false; txtcontra.Enabled = false;
                            Cargar();
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
                            //txtid.Enabled = false;
                            // cbotipoid.Enabled = false;
                            Cargar();
                        }
                        else
                        {
                            //bloqueado(true);
                            limpiar(); checkBox1.Enabled = false; btnnuevo.Enabled = false;
                            cboperfil.Enabled = cboestado.Enabled = false;
                            txtlogin.Enabled = false; txtcontra.Enabled = false; txtid.Enabled = true;
                            cbotipoid.Enabled = true;
                        }

                    }
                    if (estado == 2)
                    {
                        dtgconten.DataSource = Cusuario.usuarios(txtid.Text, cadena, 1);

                        if (dtgconten.RowCount > 0)
                        {
                            checkBox1.Enabled = true; btnnuevo.Enabled = true;
                            btnmodificar.Enabled = btneliminar.Enabled = true;
                            estado = 0;
                            Cargar();
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
            btnmodificar.Enabled = btneliminar.Enabled = si; btnlimpiar.Enabled = si;
        }
        public void ModoEdicion(Boolean a)
        {
            txtbusareagerencia.ReadOnly = !a;
            txtbuslogin.ReadOnly = !a;
            txtbusnombre.ReadOnly = !a;
            txtbusnro.ReadOnly = !a;
            txtbustipodoc.ReadOnly = !a;
            dtgconten.ReadOnly = !a;
        }
        public int estado = 0;
        private void btnnuevo_Click(object sender, EventArgs e)
        {
            CargarCombos();
            estado = 1; txtid.Text = "";
            bloqueado(true);
            Activar(false);
            limpiar(); btnnuevo.Enabled = false;
            txtid.Enabled = cbotipoid.Enabled = true;
            txtid.Focus(); GridUser.Enabled = false;
            ModoEdicion(false);
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
            GridUser.Enabled = false;
            btnnuevo.Enabled = false;
            if ((int)cboestado.SelectedValue == 3)
            {
                cboestado.Enabled = false;
                txtid.Enabled = cbotipoid.Enabled = true;
            }
            if (txtnombre.Text.Length == 0)
            {
                cboestado.SelectedIndex = 2;
                cboestado.Enabled = false;
            }
            ModoEdicion(false);
        }
        private void btneliminar_Click(object sender, EventArgs e)
        {
            estado = 3;
            if (MessageBox.Show("Desea dar de Baja a este Usuario", CompanyName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
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
            else if (estado == 1 || estado == 5)
            {
                btnnuevo.Enabled = true; cboperfil.Enabled = false;
                txtlogin.Enabled = false; limpiar();
                txtcontra.Enabled = false; txtid.Enabled = cbotipoid.Enabled = true; txtid.Text = "";
                cboestado.Enabled = false; estado = 0;
                txtid_TextChanged(sender, e); GridUser.Enabled = true;
                btnnuevoTemporal.Enabled = true;
            }
            else if (estado == 2)
            {
                cbotipoid.Enabled = true;
                txtid.Enabled = true;
                checkBox1.Enabled = true;
                cboperfil.Enabled = false;
                txtlogin.Enabled = false;
                txtcontra.Enabled = false;
                cboestado.Enabled = false; btnnuevo.Enabled = true;
                txtid_TextChanged(sender, e); GridUser.Enabled = true; btnnuevoTemporal.Enabled = true;
            }
            else if (estado == 3)
            {
                bloqueado(true); GridUser.Enabled = true;
                btnnuevo.Enabled = true; txtid_TextChanged(sender, e); estado = 0;
                btnnuevo.Enabled = true; btnnuevoTemporal.Enabled = true;
            }
            CargarUsuarios(); ModoEdicion(true); btnlimpiar.Enabled = true;
            estado = 0;
            txtid.Enabled = false;
        }
        public int tipoid;
        public string nroid;
        public string login;
        public string contra;
        public int perfil;
        public int estadito;
        public int Codigo;
        public void CargarValores()
        {
            if (cbotipoid.SelectedValue != null)
                tipoid = (int)cbotipoid.SelectedValue;
            else tipoid = 1;
            nroid = txtid.Text;
            login = txtlogin.Text;
            contra = txtcontra.Text;
            if (cboperfil.SelectedValue != null)
                perfil = (int)cboperfil.SelectedValue;
            else perfil = 0;
            if (cboestado.SelectedValue != null)
                estadito = (int)cboestado.SelectedValue;
            else estadito = 0;
            //Codigo = (int)GridUser[Codigox.Name, GridUser.CurrentCell.RowIndex].Value;
        }
        private void btnaceptar_Click(object sender, EventArgs e)
        {
            //verifico si el usuario es activo
            if (cbotipoid.Text.ToUpper().Contains("DNI") || cbotipoid.Text.ToUpper().Contains("RUC"))
            {
                if (txtid.TextLength != LengthTipoId)
                {
                    txtid.Focus();
                    msg($"El tamaño del Nro Documento debe ser: {LengthTipoId}");
                    return;
                }
            }
            else if (txtid.TextLength > LengthTipoId)
            {
                txtid.Focus();
                msg($"El Máximo tamaño del Nro Documento debe ser: {LengthTipoId}");
                return;
            }
            if (cboestado.SelectedValue == null) { msg("No se ha Seleccionado Empleado"); return; }
            if ((int)cboestado.SelectedValue == 1 || (int)cboestado.SelectedValue == 3)
            {
                DataTable table = Cusuario.UsuarioConectado(frmLogin.CodigoUsuario, txtlogin.Text, 10);
                if (table.Rows.Count > 0)
                {
                    DataRow file = table.Rows[0];
                    int ConUsuarios = (int)file["usuarios"];
                    if (estado == 1 || estado == 5)
                    {
                        ConUsuarios++;
                    }
                    //si sobrepasa el limite de usuarios
                    if (ConUsuarios > frmMenu.Users)
                    {
                        //mensaje de Cancelación
                        frmMensajeLicencia frmmensa = new frmMensajeLicencia();
                        frmmensa.ShowDialog();
                        return;
                    }
                }
            }
            //estado 1=nuevo 2=modificar 3=eliminar
            if (estado == 1 || estado == 5)
            {
                if (string.IsNullOrWhiteSpace(txtlogin.Text) || string.IsNullOrWhiteSpace(txtcontra.Text))
                {
                    msg("El Campo Login y Password, No deben estar Vacios");
                    return;
                }
                else
                {
                    if (txtlogin.Text.Length < 5)
                    {
                        msg("Campo Login 5 Caracteres minimo");
                        return;
                    }
                    else
                    {
                        if (txtcontra.Text.Length < 4)
                        {
                            msg("Contraseña muy pequeña: 4 caracteres minimo");
                            return;
                        }
                        else
                        {
                            CargarValores(); int respuesta = 0;
                            Cusuario.InsertarActualizarUsuario(tipoid, nroid, login, contra, perfil, estadito, estado, frmLogin.CodigoUsuario, out respuesta);
                            if (respuesta == 1)
                            {
                                msg("Ese Login ya Existe");
                                return;
                                //txtcontra.Text = txtlogin.Text = "";txtid_TextChanged(sender, e);
                            }
                            else
                            {
                                msgOK("Usuario Creado Exitosamente"); bloqueado(true);
                                estado = 0; txtid.Enabled = cbotipoid.Enabled = true; estado = 0;
                                txtid_TextChanged(sender, e); GridUser.Enabled = true;
                            }
                        }
                    }

                }
            }
            if (estado == 2)
            {
                if (string.IsNullOrWhiteSpace(txtlogin.Text) || string.IsNullOrWhiteSpace(txtcontra.Text))
                {
                    msg("El Campo Login y Password, No deben estar Vacios"); return;
                }
                else
                {
                    if (txtlogin.Text.Length < 5)
                    {
                        msg("Campo Login 5 Caracteres minimo"); return;
                    }
                    else
                    {
                        if (txtcontra.Text.Length < 4)
                        {
                            msg("Contraseña muy pequeña"); return;
                        }
                        else
                        {
                            CargarValores(); int respuesta = 0;
                            Cusuario.InsertarActualizarUsuario(tipoid, nroid, login, contra, perfil, estadito, 2, frmLogin.CodigoUsuario, out respuesta);
                            if (respuesta == 1)
                            {
                                msg("Ese Login ya Existe"); return;
                                //txtcontra.Text = txtlogin.Text = "";txtid_TextChanged(sender, e);
                            }
                            else
                            {
                                msgOK("Usuario Actualizado Exitosamente"); Activar(false);
                                bloqueado(true); checkBox1.Checked = true; estado = 0; txtid.Enabled = cbotipoid.Enabled = true;
                                txtid_TextChanged(sender, e); GridUser.Enabled = true;

                            }
                        }
                    }

                }
            }
            if (estado == 3)
            {
                CargarValores(); int respuesta = 0;
                Cusuario.InsertarActualizarUsuario(Codigo, nroid, login, contra, perfil, 0, 3, frmLogin.CodigoUsuario, out respuesta);
                msgOK("Usuario Eliminado Exitosamente");
                bloqueado(true); checkBox1.Checked = true; btnnuevo.Enabled = true;
                txtid_TextChanged(sender, e); GridUser.Enabled = true;
            }
            CargarUsuarios(); ModoEdicion(true);
            txtid.Enabled = false; btnlimpiar.Enabled = true;
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
            txtid.MaxLength = (int)((DataTable)cbotipoid.DataSource).Rows[cbotipoid.SelectedIndex]["leng"];
            if (txtid.Text.Length > 5)
                txtid_TextChanged(sender, e);
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
            HPResergerFunciones.Utilitarios.Validardocumentos(e, txtid, 10);
        }

        private void GridUser_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            int x = e.RowIndex;
            if (x >= 0)
            {
                Codigo = (int)GridUser[Codigox.Name, x].Value;
                cbotipoid.SelectedValue = (int)GridUser[IDX.Name, x].Value;
                txtid.Text = GridUser[docx.Name, x].Value.ToString();
                txtlogin.Text = GridUser[loginx.Name, x].Value.ToString();
                txtcontra.Text = GridUser[passx.Name, x].Value.ToString();
                ///// 
                CargarPerfil(cboperfil);
                txtnombre.Text = GridUser[nombresx.Name, x].Value.ToString();
                txtapepat.Text = GridUser[Apellidopatx.Name, x].Value.ToString();
                txtapetmat.Text = GridUser[apellidomatx.Name, x].Value.ToString();
                cboarea.Text = GridUser[gerenciax.Name, x].Value.ToString();
                cboperfil.Text = GridUser[perfilx.Name, x].Value.ToString();
                cboestado.SelectedValue = (int)GridUser[codestadox.Name, x].Value;
                if (GridUser[codestadox.Name, x].Value.ToString() == "3")
                {
                    CargarEstado(cboestado);
                    CargarPerfil(cboperfil);
                    btneliminar.Enabled = true; btnmodificar.Enabled = true;
                    cboperfil.SelectedValue = (int)GridUser[codperfilx.Name, x].Value;
                    cboestado.SelectedValue = (int)GridUser[codestadox.Name, x].Value;
                }
                btnnuevoTemporal.Enabled = true;
                btnmodificar.Enabled = true;
            }
        }
        public void Activar(params object[] control)
        {
            foreach (object x in control)
                ((Control)x).Enabled = true;
        }
        public void Desactivar(params object[] control)
        {
            foreach (object x in control)
                ((Control)x).Enabled = false;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Desactivar(btnnuevo, btnmodificar, btnnuevoTemporal, btneliminar, btnlimpiar, GridUser);
            Activar(cboperfil, txtlogin, txtcontra, checkBox1);
            limpiar();
            txtid.Text = "";
            CargarEstado(cboestado);
            CargarArea(cboarea);
            CargarTipoDocumento(cbotipoid);
            CargarPerfil(cboperfil);
            cboestado.Text = "TEMPORAL";
            estado = 5;
            ModoEdicion(false);
            txtid.Enabled = cbotipoid.Enabled = true;
        }
        private void cbotipoid_Click(object sender, EventArgs e)
        {
            string cadena = cbotipoid.Text;
            CargarTipoDocumento(cbotipoid);
            cbotipoid.Text = cadena;
        }

        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            txtbusareagerencia.CargarTextoporDefecto();
            txtbuslogin.CargarTextoporDefecto();
            txtbusnombre.CargarTextoporDefecto();
            txtbusnro.CargarTextoporDefecto();
            txtbustipodoc.CargarTextoporDefecto();
        }
        private void txtbuslogin_TextChanged(object sender, EventArgs e)
        {
            BuscarUsuarios();
        }
        public void BuscarUsuarios()
        {
            GridUser.DataSource = Cusuario.BusquedaUsuarios(txtbusnro.TextValido() == txtbusnro.TextoDefecto ? "" : txtbusnro.TextValido(), txtbustipodoc.TextValido(), txtbusnombre.TextValido(), txtbusareagerencia.TextValido(), txtbuslogin.TextValido());
            lblmsg.Text = $"Total de Registros : {GridUser.RowCount}";
        }

        private void btnmodificar_EnabledChanged(object sender, EventArgs e)
        {
            btndesconectar.Enabled = btnmodificar.Enabled;
        }
        public DialogResult msgyes(string cadena) { return HPResergerFunciones.Utilitarios.msgYesNo(cadena); }
        int PosicionFila = 0;
        int PosicionColumna = 0;
        private void btndesconectar_Click(object sender, EventArgs e)
        {
            //desconectado al usuario
            string cadeusua = GridUser[loginx.Name, GridUser.CurrentRow.Index].Value.ToString();
            if (msgyes($"Seguro desea Desconectar al Usuario: {cadeusua}") == DialogResult.Yes)
            {
                HPResergerFunciones.Utilitarios.SacarPosicionActualFilaColumna(GridUser, out PosicionFila, out PosicionColumna);
                Cusuario.UsuarioConectado((int)GridUser[Codigox.Name, GridUser.CurrentRow.Index].Value, "", 2);
                msgOK($"Usuario {cadeusua} Desconectado..");
                BuscarUsuarios();
                GridUser.CurrentCell = GridUser[PosicionColumna, PosicionFila];
            }
        }
    }
}
