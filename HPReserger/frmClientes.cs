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
    public partial class frmClientes : FormGradient
    {
        public frmClientes()
        {
            InitializeComponent();
        }
        HPResergerCapaLogica.HPResergerCL CapaLogica = new HPResergerCapaLogica.HPResergerCL();
        private void frmClientes_Load(object sender, EventArgs e)
        {
            CargarCombos();
            ModoMuestra();
            CargarDatos();
            ///CargadeBusqueda
            if (Buscando)
            {
                btnaceptar.Enabled = true;
                AcceptButton = btnaceptar;
                BuscarTexto();
            }
        }
        public Boolean Buscando = false;
        public int codigoid
        {
            get { return (int)cbotipoid.SelectedValue; }
            set { cbotipoid.SelectedValue = value; }
        }
        public string codigodoc
        {
            get { return txtnroid.Text; }
            set { txtnroid.Text = value; }
        }
        public string CodigoDocBuscar
        {
            get { return txtBuscar.Text; }
            set
            {
                txtBuscar.Text = value;
                // txtBuscar_BuscarTextChanged(new object { }, new EventArgs());               
            }
        }
        public void ModoMuestra()
        {
            Activar(gp1, dtgconten, txtBuscar, btnnuevo, btnmodificar, btneliminar);
            Desactivar(txtdireccion, txtemail, txtnombre, txtnroid, txtocupacion, txttelcelular, txttelfijo, txtapemat, txtapetpat, cbocivil, cbodepartamento, cbodistrito, cbopersona, cboprovincia, cbosexo, cbotipoid);
        }
        public void ModoEdicion()
        {
            //proceso de edicion------
            Activar(txtdireccion, txtemail, txtnombre, txtnroid, txtocupacion, txttelcelular, txttelfijo, txtapemat, txtapetpat, cbocivil, cbodepartamento, cbodistrito, cbopersona, cboprovincia, cbosexo, cbotipoid);
            Desactivar(gp1, dtgconten, txtBuscar, btnnuevo, btnmodificar, btneliminar);
        }
        public int Opciones = 10;
        DataTable TTipoId;
        DataTable TSexo;
        DataTable TEstCivil;
        DataTable TDepartamento;
        DataTable TProvincia;
        DataTable TDistrito;
        DataTable Tpersona;
        public void CargarCombos()
        {
            CargarCombito();
            CargarTipoid();
            CargarSexo();
            CargarEstadoCivil();
            CargarDepartamento();
            CargarProvincia(1);
            CargarDistrito(1, 1);
        }
        public void CargarCombito()
        {
            cbodepartamento.ValueMember = "coddep";
            cbodepartamento.DisplayMember = "departamento";
            cbodepartamento.DataSource = CapaLogica.ListarDepartamentos("");

            cbotipoid.ValueMember = "codigo";
            cbotipoid.DisplayMember = "valor";
            cbotipoid.DataSource = CapaLogica.TiposID(0, 0, "", 0);

            cbosexo.ValueMember = "codigo";
            cbosexo.DisplayMember = "descripcion";
            cbosexo.DataSource = CapaLogica.getCargoTipoContratacion("Id_Sexo", "Sexo", "TBL_Sexo");

            cbocivil.ValueMember = "codigo";
            cbocivil.DisplayMember = "descripcion";
            cbocivil.DataSource = CapaLogica.getCargoTipoContratacion("Id_EstCivil", "EstadoCivil", "TBL_EstadoCivil");

            Tpersona = new DataTable();
            Tpersona.Columns.Add("codigo", typeof(int));
            Tpersona.Columns.Add("descripcion");
            Tpersona.Rows.Add(1, "1. JURÍDICA");
            Tpersona.Rows.Add(2, "2. NATURAL");
            cbopersona.DisplayMember = "descripcion";
            cbopersona.ValueMember = "codigo";
            cbopersona.DataSource = Tpersona;
        }
        public void CargarTipoid()
        {
            TTipoId = new DataTable();
            //codigo-valor-leng
            TTipoId = CapaLogica.TiposID(0, 0, "", 0);
        }
        public void CargarSexo()
        {
            TSexo = new DataTable();
            TSexo = CapaLogica.getCargoTipoContratacion("Id_Sexo", "Sexo", "TBL_Sexo");
        }
        public void CargarDepartamento()
        {
            TDepartamento = new DataTable();
            TDepartamento = CapaLogica.ListarDepartamentos("");
        }
        public void CargarProvincia(int iddep)
        {
            TProvincia = new DataTable();
            TProvincia = CapaLogica.ListarProvincia(iddep);
        }
        public void CargarDistrito(int iddep, int idpro)
        {
            TDistrito = new DataTable();
            TDistrito = CapaLogica.ListarDistrito(iddep, idpro);
        }
        public void CargarEstadoCivil()
        {
            TEstCivil = new DataTable();
            TEstCivil = CapaLogica.getCargoTipoContratacion("Id_EstCivil", "EstadoCivil", "TBL_EstadoCivil");
        }
        public void CargarDatos()
        {
            dtgconten.DataSource = CapaLogica.Clientes(0, "");
            if (dtgconten.RowCount > 0)
            {
                btnmodificar.Enabled = true;
                btneliminar.Enabled = true;
            }
            else
            {
                btnmodificar.Enabled = false;
                btneliminar.Enabled = false;
            }
            lblmsg.Text = $"Total de Registros : {dtgconten.RowCount}";
        }
        //DataGridViewComboBoxColumn Combo;
        private void dtgconten_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            int x = e.RowIndex, y = e.ColumnIndex;
            if (dtgconten.RowCount > 0)
            {
                ////tipodoc
                //Combo = dtgconten.Columns[Tipo_Id_Clix.Name] as DataGridViewComboBoxColumn;
                ////Combo.DataSource = tipoDoc;
                //Combo.ValueMember = "codigo";
                //Combo.DisplayMember = "valor";
                //Combo.DataSource = TTipoId;
                ////sexo
                //Combo = dtgconten.Columns[Sexox.Name] as DataGridViewComboBoxColumn;
                //Combo.ValueMember = "codigo";
                //Combo.DisplayMember = "descripcion";
                //Combo.DataSource = TSexo;
                ////estadocivil
                //Combo = dtgconten.Columns[Estado_Civilx.Name] as DataGridViewComboBoxColumn;
                //Combo.ValueMember = "codigo";
                //Combo.DisplayMember = "descripcion";
                //Combo.DataSource = TEstCivil;
                ////deparmtamento
                //Combo = dtgconten.Columns[Departamentox.Name] as DataGridViewComboBoxColumn;
                //Combo.ValueMember = "coddep";
                //Combo.DisplayMember = "departamento";
                //Combo.DataSource = TDepartamento;
                ////provincia
                //Combo = dtgconten.Columns[Provinciax.Name] as DataGridViewComboBoxColumn;
                //Combo.ValueMember = "codigoprovincia";
                //Combo.DisplayMember = "Provincia";
                //Combo.DataSource = TProvincia;
                ////distrito
                //Combo = dtgconten.Columns[Distritox.Name] as DataGridViewComboBoxColumn;
                //Combo.ValueMember = "codigodistrito";
                //Combo.DisplayMember = "distrito";
                //Combo.DataSource = TDistrito;
                ///carga de datos
                ///carga de datos
                DataGridViewRow Fila = dtgconten.Rows[x];
                txtcodigo.Text = Fila.Cells[Cod_Clix.Name].Value.ToString();
                Codigo = (int)Fila.Cells[Cod_Clix.Name].Value;
                cbotipoid.SelectedValue = Fila.Cells[Tipo_Id_Clix.Name].Value;
                txtnroid.Text = Fila.Cells[Nro_Id_Clix.Name].Value.ToString();
                txtnombre.Text = Fila.Cells[Nombres_Clix.Name].Value.ToString();
                txtapetpat.Text = Fila.Cells[Apepat_RazSoc_Clix.Name].Value.ToString();
                txtapemat.Text = Fila.Cells[Apemat_Clix.Name].Value.ToString();
                cbopersona.SelectedValue = Fila.Cells[Tipo_Personax.Name].Value;
                cbosexo.SelectedValue = Fila.Cells[Sexox.Name].Value;
                cbocivil.SelectedValue = Fila.Cells[Estado_Civilx.Name].Value.ToString();
                txtdireccion.Text = Fila.Cells[Direccionx.Name].Value.ToString();
                txttelfijo.Text = Fila.Cells[Telf_Fijox.Name].Value.ToString();
                txttelcelular.Text = Fila.Cells[Telf_Celularx.Name].Value.ToString();
                cbodepartamento.SelectedValue = Fila.Cells[Departamentox.Name].Value.ToString();
                cboprovincia.SelectedValue = Fila.Cells[Provinciax.Name].Value.ToString();
                cbodistrito.SelectedValue = Fila.Cells[Distritox.Name].Value.ToString();
                txtemail.Text = Fila.Cells[E_mailx.Name].Value.ToString();
                txtocupacion.Text = Fila.Cells[Ocupacionx.Name].Value.ToString();
            }
        }
        DataGridViewComboBoxCell dataCol;
        private void dtgconten_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            int x = e.RowIndex, y = e.ColumnIndex;
            if (dtgconten.RowCount > 0)
            {
                if (y == dtgconten.Columns[Departamentox.Name].Index)
                {
                    dataCol = dtgconten.Rows[x].Cells[Provinciax.Name] as DataGridViewComboBoxCell;
                    dataCol.ValueMember = "codigoprovincia";
                    dataCol.DisplayMember = "Provincia";
                    dataCol.DataSource = CapaLogica.ListarProvincia((int)dtgconten[y, x].Value);

                    dataCol = dtgconten.Rows[x].Cells[Distritox.Name] as DataGridViewComboBoxCell;
                    dataCol.ValueMember = "codigodistrito";
                    dataCol.DisplayMember = "distrito";
                    dataCol.DataSource = CapaLogica.ListarDistrito((int)dtgconten[Departamentox.Name, x].Value, (int)dtgconten[Provinciax.Name, x].Value);
                }
                if (y == dtgconten.Columns[Provinciax.Name].Index)
                {
                    dataCol = dtgconten.Rows[x].Cells[Distritox.Name] as DataGridViewComboBoxCell;
                    dataCol.ValueMember = "codigodistrito";
                    dataCol.DisplayMember = "distrito";
                    dataCol.DataSource = CapaLogica.ListarDistrito((int)dtgconten[Departamentox.Name, x].Value, (int)dtgconten[Provinciax.Name, x].Value);
                }
            }
        }
        private void dtgconten_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.Cancel = false;
        }
        int estado = 0;
        private void btncancelar_Click(object sender, EventArgs e)
        {
            if (estado == 0)
            {
                this.Close();
            }
            else CargarDatos();
            ModoMuestra();
            estado = 0;
        }
        private void cbodepartamento_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbodepartamento.Items.Count > 0)
            {
                cboprovincia.ValueMember = "codprov";
                cboprovincia.DisplayMember = "provincia";
                cboprovincia.DataSource = CapaLogica.ListarProvincias((int)cbodepartamento.SelectedValue, "");
            }
        }
        private void cboprovincia_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboprovincia.Items.Count > 0)
            {
                cbodistrito.ValueMember = "coddis";
                cbodistrito.DisplayMember = "distrito";
                cbodistrito.DataSource = CapaLogica.ListarDistrito((int)cbodepartamento.SelectedValue, (int)cboprovincia.SelectedValue, "");
            }
        }
        private void cbodistrito_SelectedIndexChanged(object sender, EventArgs e)
        { }
        private void cbotipoid_Click(object sender, EventArgs e)
        {
            if (cbotipoid.Items.Count > 0)
            {
                string cadena = cbotipoid.Text;
                cbotipoid.ValueMember = "codigo";
                cbotipoid.DisplayMember = "valor";
                cbotipoid.DataSource = CapaLogica.TiposID(0, 0, "", 0);
                cbotipoid.Text = cadena;
            }
        }
        private void cbosexo_Click(object sender, EventArgs e)
        {
            if (cbosexo.Items.Count > 0)
            {
                string cadena = cbotipoid.Text;
                cbosexo.ValueMember = "codigo";
                cbosexo.DisplayMember = "descripcion";
                cbosexo.DataSource = CapaLogica.getCargoTipoContratacion("Id_Sexo", "Sexo", "TBL_Sexo");
                cbosexo.Text = cadena;
            }
        }
        private void cbocivil_Click(object sender, EventArgs e)
        {
            if (cbocivil.Items.Count > 0)
            {
                string cadena = cbocivil.Text;
                cbocivil.ValueMember = "codigo";
                cbocivil.DisplayMember = "descripcion";
                cbocivil.DataSource = CapaLogica.getCargoTipoContratacion("Id_EstCivil", "EstadoCivil", "TBL_EstadoCivil");
                cbocivil.Text = cadena;
            }
        }
        private void cbodepartamento_Click(object sender, EventArgs e)
        {
            if (cbodepartamento.Items.Count > 0)
            {
                string cadena1 = cboprovincia.Text;
                string cadena2 = cbodistrito.Text;
                string cadena = cbodepartamento.Text;
                cbodepartamento.ValueMember = "coddep";
                cbodepartamento.DisplayMember = "departamento";
                cbodepartamento.DataSource = CapaLogica.ListarDepartamentos("");
                cbodepartamento.Text = cadena;
                cboprovincia.Text = cadena1;
                cbodistrito.Text = cadena2;
            }
        }
        private void cboprovincia_Click(object sender, EventArgs e)
        {
            if (cboprovincia.Items.Count > 0)
            {
                string cadena1 = cboprovincia.Text;
                string cadena2 = cbodistrito.Text;
                cboprovincia.ValueMember = "codprov";
                cboprovincia.DisplayMember = "provincia";
                cboprovincia.DataSource = CapaLogica.ListarProvincias((int)cbodepartamento.SelectedValue, "");
                cboprovincia.Text = cadena1;
                cbodistrito.Text = cadena2;
            }
        }
        private void cbodistrito_Click(object sender, EventArgs e)
        {
            if (cbodistrito.Items.Count > 0)
            {
                string cadena2 = cbodistrito.Text;
                cbodistrito.ValueMember = "coddis";
                cbodistrito.DisplayMember = "distrito";
                cbodistrito.DataSource = CapaLogica.ListarDistrito((int)cbodepartamento.SelectedValue, (int)cboprovincia.SelectedValue, "");
                cbodistrito.Text = cadena2;
            }
        }
        public void BuscarTexto()
        {
            txtBuscar_BuscarTextChanged(new object { }, new EventArgs());
        }
        private void txtBuscar_BuscarTextChanged(object sender, EventArgs e)
        {
            if (txtBuscar.EstaLLeno())
            {
                dtgconten.DataSource = CapaLogica.Clientes(Opciones, txtBuscar.Text);
                if (dtgconten.RowCount == 0) LimpiarControles(cbocivil, txtcodigo, txtdireccion, txtemail, txtnombre, txtnroid, txtocupacion, txttelcelular, txttelfijo, txtapemat, txtapetpat, cbopersona, cbosexo, cbotipoid);
            }
            else CargarDatos();
            lblmsg.Text = $"Total de Registros : {dtgconten.RowCount}";
        }
        private void rdid_CheckedChanged(object sender, EventArgs e)
        {
            if (((RadioButton)sender).Checked)
            {
                Opciones = 10;
                txtBuscar_BuscarTextChanged(sender, e);
            }
        }
        private void rdnrodoc_CheckedChanged(object sender, EventArgs e)
        {
            if (((RadioButton)sender).Checked)
            {
                Opciones = 20;
                txtBuscar_BuscarTextChanged(sender, e);
            }
        }
        private void rdnombre_CheckedChanged(object sender, EventArgs e)
        {
            if (((RadioButton)sender).Checked)
            {
                Opciones = 30;
                txtBuscar_BuscarTextChanged(sender, e);
            }
        }
        private void rdEstadoCivil_CheckedChanged(object sender, EventArgs e)
        {
            if (((RadioButton)sender).Checked)
            {
                Opciones = 40;
                txtBuscar_BuscarTextChanged(sender, e);
            }
        }
        public void Activar(params object[] control)
        {
            foreach (object x in control)
            {
                if (((Control)x).AccessibilityObject.Role == AccessibleRole.Text)
                {
                    ((TextBox)x).ReadOnly = false;
                    //((TextBox)x).BackColor = Color.White;
                }
                else
                    ((Control)x).Enabled = true;
            }
        }
        public void Desactivar(params object[] control)
        {
            foreach (object x in control)
            {
                if (((Control)x).AccessibilityObject.Role == AccessibleRole.Text)
                {
                    ((TextBox)x).ReadOnly = true;
                    // ((TextBox)x).BackColor = Color.FromArgb(204, 218, 231);
                }
                else
                    ((Control)x).Enabled = false;
            }
        }
        public int Codigo { get; set; }
        private void btnnuevo_Click(object sender, EventArgs e)
        {
            estado = 1;
            ModoEdicion();
            LimpiarControles(cbocivil, txtcodigo, txtdireccion, txtemail, txtnombre, txtnroid, txtocupacion, txttelcelular, txttelfijo, txtapemat, txtapetpat, cbopersona, cbosexo, cbotipoid);
            cbodepartamento.Text = "LIMA";
            DataRow filita = (CapaLogica.ClienteSiguienteCodigo()).Rows[0];
            txtcodigo.Text = filita["total"].ToString(); ;
            Codigo = (int)filita["total"];
        }
        private void LimpiarControles(params object[] control)
        {
            foreach (object item in control)
            {
                if (((Control)item).AccessibilityObject.Role == AccessibleRole.ComboBox)
                    ((ComboBoxPer)item).SelectedIndex = -1;
                else
                {
                    ((TextBoxPer)item).Clear();
                    ((TextBoxPer)item).CargarTextoporDefecto();
                }
            }
        }
        private void LimpiarControlesEdicion(params object[] control)
        {
            foreach (object item in control)
            {
                if (!((TextBoxPer)item).EstaLLeno())
                {
                    //((TextBoxPer)item).Clear();
                    ((TextBoxPer)item).CargarTextoporDefecto();
                }
            }
        }
        private void btnmodificar_Click(object sender, EventArgs e)
        {
            ModoEdicion();
            estado = 2;
            //cbotipoid.Enabled = false; txtnroid.ReadOnly = true;
            LimpiarControlesEdicion(txtdireccion, txtemail, txtnombre, txtnroid, txtocupacion, txttelcelular, txttelfijo, txtapemat, txtapetpat);
        }
        private void btnaceptar_Click(object sender, EventArgs e)
        {
            if (!txtnroid.EstaLLeno())
            {
                msg("Ingrese Nro Documento");
                txtnroid.Focus();
                return;
            }
            if (cbotipoid.SelectedIndex < 0)
            {
                msg("Seleccione Tipo Documento");
                cbotipoid.Focus();
                return;
            }
            if (cbopersona.SelectedIndex < 0)
            {
                msg("Seleccione Tipo de Persona");
                cbopersona.Focus();
                return;
            }
            if (cbotipoid.Text.ToUpper() != "RUC")
            {
                if (cbosexo.SelectedIndex < 0)
                {
                    msg("Seleccione Sexo");
                    cbosexo.Focus();
                    return;
                }
                if (cbocivil.SelectedIndex < 0)
                {
                    msg("Seleccione Estado Civil");
                    cbocivil.Focus();
                    return;
                }
            }
            if (!txtnombre.EstaLLeno())
            {
                msg("Ingrese el Nombre");
                txtnombre.Focus();
                return;
            }
            if (cbodepartamento.SelectedIndex < 0)
            {
                msg("Seleccione Departamento");
                cbodepartamento.Focus();
                return;
            }
            if (txtnroid.TextLength != LengthTipoId)
            {
                txtnroid.Focus();
                msg($"El tamaño del Nro Documento debe ser: {LengthTipoId}");
                return;
            }
            int sexo = 0, civil = 0;
            ///insertar;
            if (cbotipoid.Text.ToUpper() != "RUC")
            {
                sexo = (int)cbosexo.SelectedValue;
                civil = (int)cbocivil.SelectedValue;
            }
            if (estado == 1)
            {
                DataRow filita = (CapaLogica.ClienteBuscarExiste((int)cbotipoid.SelectedValue, txtnroid.Text)).Rows[0];
                if ((int)filita["total"] != 0)
                {
                    msg("El Cliente Ya Existe");
                    return;
                }
                CapaLogica.Clientes(1, Codigo, (int)cbotipoid.SelectedValue, txtnroid.Text, txtapetpat.TextValido(), txtapemat.TextValido(), txtnombre.TextValido(), (int)cbopersona.SelectedValue, sexo, civil, txtdireccion.TextValido(), (int)cbodistrito.SelectedValue, (int)cboprovincia.SelectedValue, (int)cbodepartamento.SelectedValue, txttelfijo.TextValido(), txttelcelular.TextValido(), txtemail.TextValido(), txtocupacion.TextValido(), frmLogin.CodigoUsuario, DateTime.Now);
                msg("Cliente Agregado Exitosamente");
            }
            //actualizar
            if (estado == 2)
            {
                DataRow filita = (CapaLogica.ClienteBuscarExiste(Codigo, (int)cbotipoid.SelectedValue, txtnroid.Text)).Rows[0];
                if ((int)filita["total"] != 0)
                {
                    msg("El Cliente Ya Existe");
                    return;
                }
                CapaLogica.Clientes(2, Codigo, (int)cbotipoid.SelectedValue, txtnroid.Text, txtapetpat.TextValido(), txtapemat.TextValido(), txtnombre.TextValido(), (int)cbopersona.SelectedValue, sexo, civil, txtdireccion.TextValido(), (int)cbodistrito.SelectedValue, (int)cboprovincia.SelectedValue, (int)cbodepartamento.SelectedValue, txttelfijo.TextValido(), txttelcelular.TextValido(), txtemail.TextValido(), txtocupacion.TextValido(), frmLogin.CodigoUsuario, DateTime.Now);
                msg("Cliente Actualizado Exitosamente");
            }
            estado = 0;
            if (Buscando) DialogResult = DialogResult.OK;
            else
            {
                CargarDatos();
                ModoMuestra();
            }

        }
        public void msg(string cadena)
        {
            HPResergerFunciones.Utilitarios.msg(cadena);
        }
        DataRow TiposId;
        public int LengthTipoId
        {
            get { return txtnroid.MaxLength; }
            set { txtnroid.MaxLength = value; }
        }
        private void cbotipoid_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbotipoid.SelectedIndex >= 0)
            {
                TiposId = (CapaLogica.TiposID((int)cbotipoid.SelectedValue)).Rows[0]; ////Length
                LengthTipoId = (int)TiposId["Length"];
                if (cbotipoid.Text.ToUpper() == "RUC")
                    label5.Visible = label6.Visible = txtapemat.Visible = txtapetpat.Visible = label9.Visible = label8.Visible = cbosexo.Visible = cbocivil.Visible = false;
                else
                    label5.Visible = label6.Visible = txtapemat.Visible = txtapetpat.Visible = label9.Visible = label8.Visible = cbosexo.Visible = cbocivil.Visible = true;
            }
        }
        private void txtcodigo_TextChanged(object sender, EventArgs e)
        {
        }
        private void dtgconten_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int x = e.RowIndex, y = e.ColumnIndex;
            if (x >= 0)
            {
                btnaceptar_Click(sender, new EventArgs());
            }
        }
        public DialogResult msgyesno(string cadena) { return HPResergerFunciones.Utilitarios.msgYesNo(cadena); }
        private void btneliminar_Click(object sender, EventArgs e)
        {
            if (msgyesno("Desea Eliminar Cliente") == DialogResult.Yes)
            {
                DataRow Filita = CapaLogica.EliminarCliente((int)cbotipoid.SelectedValue, txtnroid.Text);
                if ((int)Filita["Resultado"] == 0)
                    msg("Eliminado Exitosamente");
                else
                    msg("No se pudo Eliminar, Cliente ya tiene Movimientos");
            }
        }
    }
}
