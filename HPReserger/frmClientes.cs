﻿using HpResergerUserControls;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
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
            LimpiarBusquedas();
        }
        HPResergerCapaLogica.HPResergerCL CapaLogica = new HPResergerCapaLogica.HPResergerCL();
        public void msg(string cadena) { HPResergerFunciones.frmInformativo.MostrarDialogError(cadena); }
        public void msgOK(string cadena) { HPResergerFunciones.frmInformativo.MostrarDialog(cadena); }

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
            get { return txtbusNroDoc.Text; }
            set { txtbusNroDoc.Text = value; }
        }
        public string TipoDocBuscar
        {
            get { return txtbusTipoDoc.Text; }
            set { txtbusTipoDoc.Text = value; }
        }
        public void ModoMuestra()
        {
            Activar(dtgconten, btnnuevo, btnmodificar, btneliminar);
            Desactivar(txtdireccion, txtemail, txtnombre, txtnroid, txtocupacion, txttelcelular, txttelfijo, txtapemat, txtapetpat, cbocivil, cbodepartamento, cbodistrito, cbopersona, cboprovincia, cbosexo, cbotipoid);
            Activar(txtbusEstadocCivil, txtbusNombre, txtbusNroDoc, txtbusTipoDoc, btncleanfind);
        }
        public void ModoEdicion()
        {
            //proceso de edicion------
            Activar(txtdireccion, txtemail, txtnombre, txtnroid, txtocupacion, txttelcelular, txttelfijo, txtapemat, txtapetpat, cbocivil, cbodepartamento, cbodistrito, cbopersona, cboprovincia, cbosexo, cbotipoid);
            Desactivar(dtgconten, btnnuevo, btnmodificar, btneliminar);
            Desactivar(txtbusEstadocCivil, txtbusNombre, txtbusNroDoc, txtbusTipoDoc, btncleanfind);
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
            if (cbodepartamento.Items.Count > 0 && cbodepartamento.SelectedValue != null)
            {
                cboprovincia.ValueMember = "codprov";
                cboprovincia.DisplayMember = "provincia";
                cboprovincia.DataSource = CapaLogica.ListarProvincias((int)cbodepartamento.SelectedValue, "");
            }
        }
        private void cboprovincia_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboprovincia.Items.Count > 0 && cboprovincia.SelectedValue != null)
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
                string cadena = cbosexo.Text;
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
                try
                {
                    string cadena2 = cbodistrito.Text;
                    cbodistrito.ValueMember = "coddis";
                    cbodistrito.DisplayMember = "distrito";
                    cbodistrito.DataSource = CapaLogica.ListarDistrito((int)cbodepartamento.SelectedValue, (int)cboprovincia.SelectedValue, "");
                    cbodistrito.Text = cadena2;
                }
                catch (Exception) { }
            }
        }
        public void BuscarTexto()
        {
            txtBuscar_BuscarTextChanged(new object { }, new EventArgs());
        }
        private void txtBuscar_BuscarTextChanged(object sender, EventArgs e)
        {
            if (estado == 0)
            {
                dtgconten.DataSource = CapaLogica.ClientesBusqueda(txtbusTipoDoc.TextValido(), txtbusNroDoc.TextValido(), txtbusNombre.TextValido(), txtbusEstadocCivil.TextValido());
                if (dtgconten.RowCount == 0) LimpiarControles(cbodepartamento, cboprovincia, cbodistrito, cbocivil, txtcodigo, txtdireccion, txtemail, txtnombre, txtnroid, txtocupacion, txttelcelular, txttelfijo, txtapemat, txtapetpat, cbopersona, cbosexo, cbotipoid);
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
                else if (((Control)x).AccessibilityObject.Role == AccessibleRole.ComboBox)
                {
                    ((ComboBoxPer)x).ReadOnly = false;
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
                else if (((Control)x).AccessibilityObject.Role == AccessibleRole.ComboBox)
                {
                    ((ComboBoxPer)x).ReadOnly = true;
                    //((TextBox)x).BackColor = Color.White;
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
            cbosexo.SelectedIndex = 1;
            cbocivil.SelectedIndex = 3;
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
            /////RUC Y DNI TAMAÑO EXACTO
            if (cbotipoid.Text.ToUpper().Contains("DNI") || cbotipoid.Text.ToUpper().Contains("RUC"))
            {
                if (txtnroid.TextLength != LengthTipoId)
                {
                    txtnroid.Focus();
                    msg($"El tamaño del Nro Documento debe ser: {LengthTipoId}");
                    return;
                }
            }
            else if (txtnroid.TextLength > LengthTipoId)
            {
                txtnroid.Focus();
                msg($"El Máximo tamaño del Nro Documento debe ser: {LengthTipoId}");
                return;
            }
            string ResultaCorreo = "";
            if (txtemail.EstaLLeno())
                if (HPResergerFunciones.Utilitarios.ValidarCorreo(txtemail.TextValido()) == "") ResultaCorreo = "Correo Invalido!\n";
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
                CapaLogica.Clientes(1, Codigo, (int)cbotipoid.SelectedValue, txtnroid.Text, txtapetpat.TextValido().Trim(), txtapemat.TextValido().Trim(), txtnombre.TextValido().Trim(), (int)cbopersona.SelectedValue, sexo, civil, txtdireccion.TextValido(), (int)cbodistrito.SelectedValue, (int)cboprovincia.SelectedValue, (int)cbodepartamento.SelectedValue, txttelfijo.TextValido(), txttelcelular.TextValido(), txtemail.TextValido(), txtocupacion.TextValido(), frmLogin.CodigoUsuario, DateTime.Now);
                msgOK($"{ResultaCorreo}Cliente Agregado Exitosamente");
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
                DataRow Filita = CapaLogica.Clientes(2, Codigo, (int)cbotipoid.SelectedValue, txtnroid.Text, txtapetpat.TextValido().Trim(), txtapemat.TextValido().Trim(), txtnombre.TextValido().Trim(), (int)cbopersona.SelectedValue, sexo, civil, txtdireccion.TextValido(), (int)cbodistrito.SelectedValue, (int)cboprovincia.SelectedValue, (int)cbodepartamento.SelectedValue, txttelfijo.TextValido(), txttelcelular.TextValido(), txtemail.TextValido(), txtocupacion.TextValido(), frmLogin.CodigoUsuario, DateTime.Now).Rows[0];
                if ((int)Filita["Resultado"] == 0)
                    msgOK($"{ResultaCorreo}Cliente Actualizado Exitosamente");
                else
                {
                    msg("No se pudo Modificar, Cliente ya tiene Movimientos");
                    return;
                }
            }
            estado = 0;
            if (Buscando) DialogResult = DialogResult.OK;
            else
            {
                CargarDatos();
                ModoMuestra();
            }

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
        public DialogResult msgp(string cadena) { return HPResergerFunciones.frmPregunta.MostrarDialogYesCancel(cadena); }
        private void btneliminar_Click(object sender, EventArgs e)
        {
            if (msgp("Desea Eliminar Cliente") == DialogResult.Yes)
            {
                DataRow Filita = CapaLogica.EliminarCliente((int)cbotipoid.SelectedValue, txtnroid.Text);
                if ((int)Filita["Resultado"] == 0)
                    msg("Eliminado Exitosamente");
                else
                    msg("No se pudo Eliminar, Cliente ya tiene Movimientos");
            }
        }
        public void LimpiarBusquedas()
        {
            txtbusEstadocCivil.CargarTextoporDefecto();
            txtbusNombre.CargarTextoporDefecto();
            txtbusNroDoc.CargarTextoporDefecto();
            txtbusTipoDoc.CargarTextoporDefecto();
        }
        private void btncleanfind_Click(object sender, EventArgs e)
        {
            LimpiarBusquedas();
        }
        public async Task<string> GetHTTPss(string ruc)
        {
            string url = Configuraciones.ApiRuc + ruc;// + año + "-" + mes.ToString("00");
            System.Net.ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
            WebRequest oRequest = WebRequest.Create(url);
            oRequest.Headers.Clear();
            oRequest.Headers.Add(HttpRequestHeader.Authorization, "Bearer $apis-token-1887.qDw9MbrxloHL-d0c8MlKO44xEQ3S-STB");
            WebResponse oResponse = oRequest.GetResponse();
            StreamReader sr = new StreamReader(oResponse.GetResponseStream());
            return await sr.ReadToEndAsync();
        }
        public async void BuscarProveedorAPi(string ruc)
        {
            try
            {
                string respuesta = await GetHTTPss(ruc);
                respuesta = "[\n " + respuesta + " \n]";
                List<Proveedor> LstData = JsonConvert.DeserializeObject<List<Proveedor>>(respuesta);
                //SAcamos la Data             
                if (LstData.Count > 0)
                {
                     txtnombre.Text = LstData[0].nombre;
                    //cbodocumento.SelectedValue = LstData[0].tipoDocumento - 1;
                    txtdireccion.Text = LstData[0].direccion + " - " + LstData[0].distrito + " - " + LstData[0].departamento;
                    if (txtdireccion.Text == "- -  - ") txtdireccion.Text = "-";
                    cbopersona.SelectedIndex = 0;
                    //if (LstData[0].condicion == "HABIDO") cbocondicion.SelectedIndex = 0; else cbocondicion.SelectedIndex = 1;
                    //if (LstData[0].estado == "ACTIVO") cboestado.SelectedValue = 1;
                    //if (LstData[0].estado == "SUSPENSION TEMPORAL") cboestado.SelectedValue = 2;
                    //if (LstData[0].estado == "BAJA DEFINITIVA") cboestado.SelectedValue = 3;
                    //if (LstData[0].estado == "BAJA DE OFICIO") cboestado.SelectedValue = 3;
                }
            }
            catch (Exception e) { }
        }
        private void txtnroid_TextChanged(object sender, EventArgs e)
        {
            if (estado == 1)
                if (txtnroid.Text.Length == 8)
                {
                    //ANULADO POR FALTA DE DATA DE LA API RENIEC
                    BuscarReniecAPiToken(txtnroid.Text);
                }
            if (estado == 1)//cuando vamos a ingresar uno nuevo
                if (txtnroid.Text.Length == 11)
                {
                    //BuscarProveedorAPiToken(txtnumeroidentidad.Text);
                    BuscarProveedorAPi(txtnroid.Text);
                }
        }
        public class Proveedor
        {
            public string nombre { get; set; }
            public int tipoDocumento { get; set; }
            public string numeroDocumento { get; set; }
            public string estado { get; set; }
            public string condicion { get; set; }
            public string direccion { get; set; }
            public string ubigeo { get; set; }
            public string viaTipo { get; set; }
            public string viaNombre { get; set; }
            public string zonaCodigo { get; set; }
            public string zonaTipo { get; set; }
            public string numero { get; set; }
            public string interior { get; set; }
            public string lote { get; set; }
            public string dpto { get; set; }
            public string manzana { get; set; }
            public string kilometro { get; set; }
            public string distrito { get; set; }
            public string provincia { get; set; }
            public string departamento { get; set; }
        }
        public async Task<string> GetHTTPs(string dni)
        {
            string url = Configuraciones.ApiReniec + dni;// + Configuraciones.Token;// + año + "-" + mes.ToString("00");
            System.Net.ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
            WebRequest oRequest = WebRequest.Create(url);
            WebResponse oResponse = oRequest.GetResponse();
            StreamReader sr = new StreamReader(oResponse.GetResponseStream());
            return await sr.ReadToEndAsync();
        }
        private async void BuscarReniecAPiToken(string dni)
        {
            try
            {
                string respuesta = await GetHTTPs(dni);
                respuesta = "[\n " + respuesta + " \n]";
                List<DNI> LstData = JsonConvert.DeserializeObject<List<DNI>>(respuesta);
                //SAcamos la Data             
                if (LstData.Count > 0)
                {
                    DNI data = LstData[0];
                    txtapetpat.Text = data.apellidoPaterno;
                    txtapemat.Text = data.apellidoMaterno;
                    txtnombre.Text = data.nombres;
                    cbopersona.SelectedIndex = 1;
                    cbotipoid.SelectedValue = 1;

                }
            }
            catch (Exception) { }
        }
        public class DNI
        {
            public string dni { get; set; }
            public string nombres { get; set; }
            public string apellidoPaterno { get; set; }
            public string apellidoMaterno { get; set; }
            public string codVerifica { get; set; }
        }


    }
}
