﻿using System;
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
    public partial class frmArticuloServicio : Form
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
                Activar(); Txtbusca.Enabled = true;
            }
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
            cbotipo.Focus(); Txtbusca.Enabled = false;
        }
        public void Activar()
        {
            btnlimpiar.Enabled = Txtbusca.Enabled = btnnuevo.Enabled = btneliminar.Enabled = btnmodificar.Enabled = dtgconten.Enabled = cbotipo.Enabled = true;
        }
        public void Desactivar()
        {
            btnlimpiar.Enabled = Txtbusca.Enabled = btnnuevo.Enabled = btneliminar.Enabled = btnmodificar.Enabled = dtgconten.Enabled = false;
        }
        private void btnmodificar_Click(object sender, EventArgs e)
        {
            tipmsg.Show("Ingrese Descripción", txtdescripcion, 700);
            Desactivar(); cbotipo.Enabled = false; modmarca = Convert.ToInt32(cbomarca.SelectedValue.ToString());
            estado = 2;
            txtdescripcion.Focus();
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
                cbomodelo.DataSource = null;
                cbomodelo.DisplayMember = null;
                cbomodelo.ValueMember = null;
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
                cbomarca.DataSource = null;
                cbomarca.Items.Clear();
                cbomarca.Items.Add("SIN MARCA");
                cbomarca.SelectedText = "SIN MARCA";
                cbomarca.SelectedValue = 1;
                cbomodelo.DataSource = null;
                cbomodelo.Items.Clear();
                cbomodelo.Items.Add("SIN MODELO");
                cbomodelo.SelectedText = "SIN MODELO";
                cbomodelo.SelectedValue = 1;
            }
            else { CargarMarcas(); }
        }

        private void btnmarcamas_Click(object sender, EventArgs e)
        {
            frmmarca marcae = new frmmarca();
            marcae.Visible = true;
        }
        private void dtgconten_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int y = e.RowIndex;
                txtcodigo.Text = dtgconten[0, y].Value.ToString();
                cbotipo.Text = dtgconten[5, y].Value.ToString();
                cbomarca.SelectedValue = Convert.ToInt32(dtgconten[2, y].Value.ToString());
                //cbomarca.Text = dtgconten[3, y].Value.ToString();
                txtdescripcion.Text = dtgconten[1, y].Value.ToString();
                txtobservacion.Text = dtgconten[6, y].Value.ToString();
            }
            catch { }
        }

        private void btnmodelomas_Click(object sender, EventArgs e)
        {
            frmmarcamodelo modelo = new frmmarcamodelo();
            modelo.Visible = true;
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

        private void btnaceptar_Click(object sender, EventArgs e)
        {
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
                    CArticulo.InsertarArticulo(concepto, 0, tipo, txtobservacion.Text);
                }
                CArticulo.InsertarArticuloMarca(marcas, GenerarCodigo());
                MessageBox.Show("Insertado Exitosamente " + concepto + ";" + marcas, "HpReserger", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (estado == 2 && VerificarDatos(concepto, marcas))
                {
                    CArticulo.ActualizarArticuloMarca(Convert.ToInt32(txtcodigo.Text), txtdescripcion.Text, 0, tipo, txtobservacion.Text, marcas, modmarca);
                    MessageBox.Show("Modificado Exitosamente ", "HpReserger", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    if (estado == 3)
                    {
                        if (MessageBox.Show("Seguró Desea Eliminar; " + txtdescripcion.Text + " Marca: " + cbomarca.Text, "Hp Reserger", MessageBoxButtons.YesNo, MessageBoxIcon.Question).ToString() == "Yes") ;
                        {
                            CArticulo.EliminarARticuloMarca(marcas, Convert.ToInt32(txtcodigo.Text.ToString()));
                            estado = 0;
                            MessageBox.Show("Eliminado Exitosamente ", "HpReserger", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        }
                    }
                }
            }
            estado = 0;
            //cbotipo_TextChanged(sender, e);
            dtgconten.DataSource = listarArticulos("");
            CargarCodigo();
            Activar(); Txtbusca.Enabled = false;
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
                    MessageBox.Show("Ya Existe esa Relación Id:" + cbomarca.Text + "=" + marca + " : " + descripcion, "Hp Reserger", MessageBoxButtons.OK);
                    aux = false;
                }
            }
            else
            {
                aux = false;
                MessageBox.Show("Campo Descripción Vacio", "HpReserger", MessageBoxButtons.OK, MessageBoxIcon.Stop);
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

        private void cbomarca_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}