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
    public partial class frmArea : Form
    {
        public frmArea()
        {
            InitializeComponent();
        }
        int Codarea { get; set; }
        int Codgerencia { get; set; }
        int CodCCosto { get; set; }
        public int estado { get; set; }
        HPResergerCapaLogica.HPResergerCL CArea = new HPResergerCapaLogica.HPResergerCL();

        private void frmArea_Load(object sender, EventArgs e)
        {
            cboarea.DataSource = CArea.getCargoTipoContratacion("Id_Gerencia", "Gerencia", "TBL_Gerencia");
            cboarea.ValueMember = "CODIGO";
            cboarea.DisplayMember = "DESCRIPCION";
            dtgconten.DataSource = CArea.ListarAreas("");
            cboccosto.DataSource = CArea.getCargoTipoContratacion("Id_CCosto", "CentroCosto", "TBL_Centro_Costo");
            cboccosto.ValueMember = "CODIGO";
            cboccosto.DisplayMember = "DESCRIPCION";
        }
        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            Txtbusca.Text = "";
        }

        private void btndepmas_Click(object sender, EventArgs e)
        {
            frmgerencia gerencia = new frmgerencia();
            gerencia.Visible = true;
        }

        private void dtgconten_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtcodigo.Text = dtgconten[0, e.RowIndex].Value.ToString();
                cboarea.Text = dtgconten[5, e.RowIndex].Value.ToString();
                txtdescripcion.Text = dtgconten[1, e.RowIndex].Value.ToString();
                Codarea = Convert.ToInt32(txtcodigo.Text.ToString());
                cboccosto.Text = dtgconten[3, e.RowIndex].Value.ToString();
                CodCCosto = Convert.ToInt32(dtgconten[2, e.RowIndex].Value.ToString());
                Codgerencia = Convert.ToInt32(dtgconten[4, e.RowIndex].Value.ToString());
            }
            catch { }
        }

        private void cboarea_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Codgerencia = Convert.ToInt32(cboarea.SelectedValue.ToString());
            }
            catch { }
        }
        private void cboccosto_TextChanged(object sender, EventArgs e)
        {
            try
            {
                CodCCosto = Convert.ToInt32(cboccosto.SelectedValue.ToString());
            }
            catch { }
        }
        private void Txtbusca_TextChanged(object sender, EventArgs e)
        {
            estado = 0;
            dtgconten.DataSource = CArea.ListarAreas(Txtbusca.Text);
        }
        public void Desactivar()
        {
            btnnuevo.Enabled = btneliminar.Enabled = btnmodificar.Enabled = dtgconten.Enabled = false;

        }
        public void Desactivarmas()
        {
            cboarea.Enabled = cboccosto.Enabled = false;
        }
        public void Activar()
        {
            btnnuevo.Enabled = btneliminar.Enabled = btnmodificar.Enabled = dtgconten.Enabled = true;
        }
        public void Activarmas()
        {
            cboarea.Enabled = cboccosto.Enabled = true;
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
                Activar(); Activarmas();
                frmArea_Load(sender, e);
            }
        }
        private void btnnuevo_Click(object sender, EventArgs e)
        {
            tipmsg.Show("Ingrese Descripción", txtdescripcion, 700);
            txtcodigo.Text = txtdescripcion.Text = "";
            estado = 1; Desactivar();
            txtdescripcion.Focus();
        }
        private void btnmodificar_Click(object sender, EventArgs e)
        {
            tipmsg.Show("Ingrese Descripción", txtdescripcion, 700);
            Desactivar(); Desactivarmas();
            estado = 2;
            txtdescripcion.Focus();
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            estado = 3;
            btnaceptar_Click(sender, e);
        }
        public Boolean ValidarDes(string valor)
        {
            Boolean Aux = true;
            if (!string.IsNullOrWhiteSpace(txtdescripcion.Text))
            {
                dtgareas.DataSource = CArea.ListarAreas("");
                for (int i = 0; i < dtgareas.RowCount - 1; i++)
                {
                    if (dtgareas[1, i].Value.ToString() == txtdescripcion.Text)
                    {
                        MessageBox.Show("Ya existe: '" + txtdescripcion.Text + "'", "Hp Reserger", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        Txtbusca.Text = txtdescripcion.Text;
                        Aux = false;
                        break;
                    }
                }
            }
            else
            {
                Aux = false;
                MessageBox.Show("Campo de Descripción Vacio", "Hp Reserger", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return Aux;
        }
        private void btnaceptar_Click(object sender, EventArgs e)
        {
            //Estado 1=Nuevo. Estado 2=modificar. Estado 3=eliminar. Estado 0=SinAcciones
            if (estado == 1 && ValidarDes(txtdescripcion.Text) )
            {
                CArea.InsertarArea(txtdescripcion.Text,CodCCosto,Codgerencia);                
                MessageBox.Show("Descripción Insertada Exitosamente "+ txtdescripcion.Text, "Hp Reserger", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                Txtbusca.Text = txtdescripcion.Text;
            }
            else
            {
                if (estado == 2 && ValidarDes(txtdescripcion.Text))
                {
                    CArea.ActualizarArea(txtdescripcion.Text, CodCCosto, Codgerencia,Codarea);
                    MessageBox.Show("Descripción Modificada Exitosamente" , "Hp Reserger", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    Txtbusca.Text = txtdescripcion.Text;
                }
                else
                {
                    if (estado == 3)
                    {
                        if (MessageBox.Show("Seguró Desea Eliminar: " + txtdescripcion.Text, "Hp Reserger", MessageBoxButtons.YesNo, MessageBoxIcon.Question).ToString() == "Yes")
                        {
                            CArea.EliminarArea(CodCCosto,Codgerencia,Codarea);
                            MessageBox.Show("Descripción Eliminada Exitosamente", "Hp Reserger", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            Txtbusca.Text = txtdescripcion.Text;
                        }
                    }
                }
            }
            estado = 0;
            Activar();Activarmas();
            /*Cargarprovincias(coddep, "");
            codpro = Convert.ToInt32(cboprovincia.SelectedValue.ToString());
            codprofinal = cboprovincia.Items.Count;*/
        }
        private void btnccostomas_Click(object sender, EventArgs e)
        {
            frmccosto costo = new frmccosto();
            costo.Visible = true;
        }

        private void frmArea_Activated_1(object sender, EventArgs e)
        {
            //frmArea_Load(sender, e);
        }        
    }
}