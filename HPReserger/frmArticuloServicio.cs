﻿using HpResergerUserControls;
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
    public partial class frmArticuloServicio : FormGradient
    {
        public frmArticuloServicio()
        {
            InitializeComponent();
        }
        public HPResergerCapaLogica.HPResergerCL CArticulo = new HPResergerCapaLogica.HPResergerCL();
        public int estado { get; set; }
        public int marcas { get; set; }
        public string concepto { get; set; }
        public int codigo { get; set; }
        public int tipo { get; set; }
        public int ArtExiste { get; set; }
        public int modmarca { get; set; }
        private void frmArticuloServicio_Load(object sender, EventArgs e)
        {
            CargarArticuloServicio();
            CargarMarcas();
            CargarModelos(1);
            cbocuenta.DataSource = CArticulo.ListarCuentasArticulos();
            cbocuenta.DisplayMember = "codigo";
            cbocuenta.ValueMember = "codigo";
            DataTable Tdatos = CArticulo.ListarCentroCostoTieneCuenta();
            DataRow Filon = Tdatos.NewRow();
            Filon[4] = 0;
            Filon[2] = "NINGUN CENTRO";
            Tdatos.Rows.InsertAt(Filon, 0);
            cbocentrocosto.DataSource = Tdatos;
            cbocentrocosto.DisplayMember = "CentroCosto";
            cbocentrocosto.ValueMember = "Id_CtaCtble";
            dtgconten.DataSource = listarArticulos("");
            msg(dtgconten);
            CargarCodigo();
        }
        public void CargarCodigo()
        {
            try
            {
                codigo = Convert.ToInt32(dtgconten[0, dtgconten.RowCount - 1].Value.ToString());
                codigo = codigo + 1;
            }
            catch { }
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
                //  Activar(); Txtbusca.Enabled = true; gp1.Enabled = false;
                Iniciar(false);
            }
        }
        public void Iniciar(Boolean a)
        {
            gp1.Enabled = a;
            dtgconten.Enabled = !a;
            btnnuevo.Enabled = !a;
            btnmodificar.Enabled = !a;
            btneliminar.Enabled = !a;
            btnlimpiar.Enabled = !a;
            Txtbusca.Enabled = !a;
            btnaceptar.Enabled = a;
            btncentro.Enabled = a;
            btnctaact.Enabled = a;
            btnctactble.Enabled = a;

        }
        public DataTable listarArticulos(string busca)
        {
            return CArticulo.ListarArticulos(busca);
        }
        private void btnnuevo_Click(object sender, EventArgs e)
        {
            txtcodigo.Text = codigo.ToString();
            tipmsg.Show("Ingrese Descripción del Artículo", txtdescripcion, 700);
            txtdescripcion.Text = txtobservacion.Text = "";
            estado = 1; Desactivar();
            cbotipo.Focus();
            //Txtbusca.Enabled = false; gp1.Enabled = true;
            Iniciar(true);
        }
        public void Activar()
        {
            //  btnlimpiar.Enabled = Txtbusca.Enabled = btnnuevo.Enabled = btneliminar.Enabled = btnmodificar.Enabled = dtgconten.Enabled = cbotipo.Enabled = true;
            //   gp1.Enabled = false;
        }
        public void Desactivar()
        {
            // btnlimpiar.Enabled = Txtbusca.Enabled = btnnuevo.Enabled = btneliminar.Enabled = btnmodificar.Enabled = dtgconten.Enabled = false;gp1.Enabled = false;
        }
        private void btnmodificar_Click(object sender, EventArgs e)
        {
            tipmsg.Show("Ingrese Descripción", txtdescripcion, 700);
            //Desactivar(); cbotipo.Enabled = false;
            modmarca = Convert.ToInt32(cbomarca.SelectedValue.ToString());
            estado = 2;
            txtdescripcion.Focus(); //gp1.Enabled = true;
            Iniciar(true);
        }
        public void CargarArticuloServicio()
        {
            cbotipo.DataSource = CArticulo.getCargoTipoContratacion("Codigo_Tipo_Compra", "Desc_Tipo_compra", "TBL_Tipo_Compra");
            cbotipo.DisplayMember = "DESCRIPCION";
            cbotipo.ValueMember = "CODIGO";

        }
        public void CargarMarcas()
        {
            try
            {
                cbomarca.DataSource = CArticulo.getCargoTipoContratacion("Id_Marca", "Marca", "TBL_Marca");
                cbomarca.DisplayMember = "DESCRIPCION";
                cbomarca.ValueMember = "CODIGO";
            }
            catch { }
        }
        public void CargarModelos(int codmarca)
        {
            try
            {
                cbomodelo.DataSource = CArticulo.ListarModelos(codmarca);
                cbomodelo.DisplayMember = "DESCRIPCION";
                cbomodelo.ValueMember = "CODIGO";
            }
            catch { }
        }
        private void Txtbusca_TextChanged(object sender, EventArgs e)
        {
            dtgconten.DataSource = listarArticulos(Txtbusca.Text);
            msg(dtgconten);
        }

        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            Txtbusca.Text = "";
        }

        private void cbomarca_TextChanged(object sender, EventArgs e)
        {
            try
            {
                ///cbomodelo.DataSource = null;
                /// cbomodelo.DisplayMember = null;
                /// cbomodelo.ValueMember = null;
                if (cbotipo.SelectedIndex == 1)
                {
                    CargarModelos(1);
                }
                else CargarModelos(Convert.ToInt32(cbomarca.SelectedValue.ToString()));
            }
            catch { }

        }
        private void cbotipo_TextChanged(object sender, EventArgs e)
        {
            if (cbotipo.SelectedValue.ToString() == "2")
            {
                ///  cbomarca.DataSource = null;
                //   cbomarca.Items.Clear();
                //  cbomarca.Items.Add("SIN MARCA");
                //    cbomarca.SelectedText = "SIN MARCA";
                cbomarca.SelectedValue = 1;
                cbomarca.Enabled = false;

                //    cbomodelo.DataSource = null;
                //    cbomodelo.Items.Clear();
                //    cbomodelo.Items.Add("SIN MODELO");
                //    cbomodelo.SelectedText = "SIN MODELO";
                cbomodelo.SelectedValue = 1;
                cbomodelo.Enabled = false;
            }
            else { CargarMarcas(); cbomarca.Enabled = true; cbomodelo.Enabled = true; }
        }

        private void btnmarcamas_Click(object sender, EventArgs e)
        {
            frmmarca marcae = new frmmarca();
            marcae.ShowDialog();
            string filamarca = cbomarca.SelectedText;
            CargarMarcas();
            cbomarca.Text = filamarca;
        }
        private void dtgconten_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (dtgconten.RowCount > 0)
            {
                btnmodificar.Enabled = true;
                btneliminar.Enabled = true;
                int y = e.RowIndex;
                txtcodigo.Text = dtgconten["ida", y].Value.ToString();
                cbotipo.Text = dtgconten["tipo", y].Value.ToString();
                cbomarca.Text = dtgconten["marca", y].Value.ToString();
                //cbomarca.Text = dtgconten[3, y].Value.ToString();
                txtdescripcion.Text = dtgconten["descripcion", y].Value.ToString();
                txtobservacion.Text = dtgconten["obs", y].Value.ToString();
                if (int.Parse(dtgconten["cc", y].Value.ToString()) == 0)
                    chkcentro.Checked = false;
                else
                    chkcentro.Checked = true;
                if (int.Parse(dtgconten["GV", y].Value.ToString()) == 0)
                    chkigv.Checked = false;
                else chkigv.Checked = true;
                cbocuenta.Text = dtgconten["cuenta", y].Value.ToString();
                cbocentrocosto.SelectedValue = dtgconten["cc", y].Value.ToString();
                txtctacble.Text = dtgconten[ctax.Name, y].Value.ToString();
                txtcntctbleact.Text = dtgconten[ctaactivox.Name, y].Value.ToString();
            }
            else
            {
                btnmodificar.Enabled = false;
                btneliminar.Enabled = false;
            }

        }

        private void btnmodelomas_Click(object sender, EventArgs e)
        {
            frmmarcamodelo modelo = new frmmarcamodelo();
            modelo.ShowDialog();
            cbomarca_SelectedIndexChanged(sender, e);
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            estado = 3;
            btnaceptar_Click(sender, e);
        }

        private void cbomarca_KeyPress(object sender, KeyPressEventArgs e)
        {
            HPResergerFunciones.Utilitarios.ToUpper(e);
        }
        int IGV;
        string cuentax;
        private void btnaceptar_Click(object sender, EventArgs e)
        {
            int CENTRO = 0;
            if (chkcentro.Checked)
                CENTRO = 1;
            else CENTRO = 0;
            if (chkigv.Checked)
                IGV = 1;
            else IGV = 0;
            if (chkcentro.Checked)
                cuentax = cbocentrocosto.SelectedValue.ToString();
            else cuentax = "0";

            //Estado 1=Nuevo. Estado 2=modificar. Estado 3=eliminar. Estado 0=SinAcciones
            //tipo 2 = sin marca marcas= sin marca
            //Generar Codigo = ultimo codigo ingresado // ArtEXsite 1=Existe Articulo  0=No existe
            if (cbotipo.SelectedValue.ToString() == "2")
            {
                marcas = 1;
                tipo = 2;
            }
            else
            { marcas = Convert.ToInt32(cbomarca.SelectedValue.ToString()); tipo = 1; }
            concepto = txtdescripcion.Text;

            VerificarArticulo();

            if (estado == 1 && VerificarDatos(concepto, marcas))
            {
                if (ArtExiste == 0)
                {
                    CArticulo.InsertarArticulo(concepto, 0, tipo, txtobservacion.Text, IGV, int.Parse(cuentax), cuentax, cuentax, txtctacble.Text, txtcntctbleact.Text);
                    //CArticulo.InsertarArticulo(concepto, 0, tipo, txtobservacion.Text, IGV, CENTRO, cbocuenta.SelectedText, cbocentrocosto.SelectedValue.ToString());
                }
                CArticulo.InsertarArticuloMarca(marcas, GenerarCodigo());
                HPResergerFunciones.frmInformativo.MostrarDialog("Insertado Exitosamente " + concepto + ";" + marcas);
            }
            else
            {
                if (estado == 2 && VerificarValores(concepto, marcas))
                {
                    //CArticulo.ActualizarArticuloMarca(Convert.ToInt32(txtcodigo.Text), txtdescripcion.Text, 0, tipo, txtobservacion.Text, marcas, modmarca, IGV, CENTRO, cbocuenta.SelectedText, cbocentrocosto.SelectedValue.ToString());
                    CArticulo.ActualizarArticuloMarca(Convert.ToInt32(txtcodigo.Text), txtdescripcion.Text, 0, tipo, txtobservacion.Text, marcas, modmarca, IGV, int.Parse(cuentax), cuentax, cuentax, txtctacble.Text, txtcntctbleact.Text);
                    HPResergerFunciones.frmInformativo.MostrarDialog("Modificado Exitosamente ");
                }
                else
                {
                    if (estado == 3)
                    {
                        if (msgp("Seguró Desea Eliminar; " + txtdescripcion.Text + " Marca: " + cbomarca.Text) == DialogResult.Yes)
                        {
                            CArticulo.EliminarARticuloMarca(marcas, Convert.ToInt32(txtcodigo.Text.ToString()));
                            estado = 0;
                            HPResergerFunciones.frmInformativo.MostrarDialog("Eliminado Exitosamente ");

                        }
                    }
                }
            }
            estado = 0;
            //cbotipo_TextChanged(sender, e);
            dtgconten.DataSource = listarArticulos("");
            CargarCodigo();
            Iniciar(false);
            //Activar(); Txtbusca.Enabled = false;
        }
        public DialogResult msgp(string cadena) { return HPResergerFunciones.frmPregunta.MostrarDialogYesCancel(cadena); }
        public Boolean VerificarValores(string concepto, int marca)
        {
            if (dtgconten.RowCount > 0)
            {
                for (int i = 0; i < dtgconten.RowCount; i++)
                {
                    if (dtgconten["descripcion", i].Value.ToString() == concepto && dtgconten["idm", i].Value.ToString() == marca.ToString() && i != dtgconten.CurrentCell.RowIndex)
                    {
                        HPResergerFunciones.frmInformativo.MostrarDialogError("Ya Existe esa Relación Id:" + cbomarca.Text + "=" + marca + " : " + txtdescripcion.Text);
                        return false;
                    }
                }
            }
            return true;
        }
        public void msg(DataGridView conteo)
        {
            lblmsg.Text = "Total Registros: " + conteo.RowCount;
        }
        private void frmArticuloServicio_Activated(object sender, EventArgs e)
        {
            /* if (estado == 0)
             {
                 CargarArticuloServicio();
                 CargarMarcas();
                 CargarModelos();
                 dtgconten.DataSource = listarArticulos("");
             }*/
        }
        public void VerificarArticulo()
        {
            ArtExiste = 0;
            if (CArticulo.VerificarArticulo(txtdescripcion.Text).Rows.Count > 0)
            {
                ArtExiste = 1;
            }
        }
        public int GenerarCodigo()
        {
            veri.DataSource = CArticulo.VerificarArticulo(txtdescripcion.Text);
            return Convert.ToInt32(veri[0, 0].Value.ToString());

        }
        public Boolean VerificarDatos(string descripcion, int marca)
        {
            Boolean aux = true;
            if (!string.IsNullOrWhiteSpace(descripcion))
            {
                if (CArticulo.VerificarArticuloServicio(descripcion, marca).Rows.Count > 0)
                {
                    HPResergerFunciones.frmInformativo.MostrarDialogError("Ya Existe esa Relación Id:" + cbomarca.Text + "=" + marca + " : " + descripcion);
                    aux = false;
                }
            }
            else
            {
                aux = false;
                HPResergerFunciones.frmInformativo.MostrarDialogError("Campo Descripción Vacio");
            }
            return aux;
        }

        private void cbomodelo_KeyPress(object sender, KeyPressEventArgs e)
        {
            HPResergerFunciones.Utilitarios.ToUpper(e);

        }

        private void dtgconten_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cbotipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            label12.Visible = txtcntctbleact.Visible = btnctaact.Visible = true; btnlimpiarCtactivo.Visible = true;
            if (cbotipo.Text.ToUpper() == "SERVICIO")
            {
                txtcntctbleact.Text = ""; label12.Visible = txtcntctbleact.Visible = btnctaact.Visible = false;
                btnlimpiarCtactivo.Visible = false;
            }
        }
        private void cbomarca_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbomarca.SelectedIndex > 0)
            {
                if (cbotipo.SelectedIndex == 1)
                {
                    CargarModelos(1);
                }
                else CargarModelos(Convert.ToInt32(cbomarca.SelectedValue.ToString()));
            }
        }

        private void chkcentro_CheckedChanged(object sender, EventArgs e)
        {
            if (chkcentro.Checked)
            {
                cbocentrocosto.Enabled = true;
                btncentro.Enabled = true;
            }
            else
            {
                cbocentrocosto.Enabled = false;
                btncentro.Enabled = false;
            }
        }
        private void txtdescripcion_TextChanged(object sender, EventArgs e)
        {

        }
        frmccosto fccentro;
        private void btncentro_Click(object sender, EventArgs e)
        {
            if (fccentro == null)
            {
                fccentro = new frmccosto();
                fccentro.Icon = Icon;
                fccentro.Consulta = true;
                fccentro.MdiParent = MdiParent;
                fccentro.FormClosed += Fccentro_FormClosed;
                fccentro.Show();
            }
            else fccentro.Activate();
        }

        private void Fccentro_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (fccentro.ConsulCodigo != "")
                cbocentrocosto.Text = fccentro.ConsulCodigo;
            fccentro = null;
        }

        private void btnctaact_Click(object sender, EventArgs e)
        {
            frmlistarcuentas cuentitas = new frmlistarcuentas();
            cuentitas.Icon = Icon;
            cuentitas.Txtbusca.Text = txtcntctbleact.Text;
            cuentitas.radioButton1.Checked = true;
            cuentitas.ShowDialog();
            if (cuentitas.aceptar)
            {
                if (cuentitas.codigo.Substring(cuentitas.codigo.Length - 1, 1) == "0")
                {
                    HPResergerFunciones.frmInformativo.MostrarDialogError("No se Puede Seleccionar una cuenta de Cabecera");
                }
                else
                {
                    txtcntctbleact.Text = cuentitas.codigo;
                }
            }
        }
        private void btnctactble_Click(object sender, EventArgs e)
        {
            frmlistarcuentas cuentitas = new frmlistarcuentas();
            cuentitas.Icon = Icon;
            cuentitas.Txtbusca.Text = txtctacble.Text;
            cuentitas.radioButton1.Checked = true;
            cuentitas.ShowDialog();
            if (cuentitas.aceptar)
            {
                //if (cuentitas.codigo.Substring(cuentitas.codigo.Length - 1, 1) == "0")
                //{
                //MSG("No se Puede Seleccionar una cuenta de Cabeceras");
                //}
                //else
                //{
                txtctacble.Text = cuentitas.codigo;
                //}
            }
        }

        private void btnctaact_EnabledChanged(object sender, EventArgs e)
        {
            btnlimpiarCtactivo.Enabled = btnctaact.Enabled;
        }

        private void btnctactble_EnabledChanged(object sender, EventArgs e)
        {
            btnlimpiarcta.Enabled = btnctactble.Enabled;
        }
        private void btnlimpiarCtactivo_Click(object sender, EventArgs e)
        {
            txtcntctbleact.Text = "";
        }

        private void btnlimpiarcta_Click(object sender, EventArgs e)
        {
            txtctacble.Text = "";
        }
    }
}
