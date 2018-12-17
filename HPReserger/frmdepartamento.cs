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
    public partial class frmdepartamento : FormGradient
    {
        public frmdepartamento()
        {
            InitializeComponent();
        }
        public int estado { get; set; }
        HPResergerCapaLogica.HPResergerCL Cdepartamento = new HPResergerCapaLogica.HPResergerCL();
        private void btnnuevo_Click(object sender, EventArgs e)
        {


            tipmsg.Show("Ingrese Departamento", txtdepartamento, 1000);
            txtcodigo.Text = txtdepartamento.Text = "";
            estado = 1;
            Desactivar();
        }

        private void btnmodificar_Click(object sender, EventArgs e)
        {
            tipmsg.Show("Ingrese departamento", txtdepartamento, 700);
            Desactivar();
            estado = 2;
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            estado = 3;
            btnaceptar_Click(sender, e);
        }
        public Boolean ValidarDes(string valor)
        {
            Boolean Aux = true;
            if (valor != " ")
            {
                for (int i = 0; i < dtgconten.RowCount; i++)
                {
                    if (dtgconten[1, i].Value.ToString() == valor)
                    {
                        Aux = false;
                        MessageBox.Show("Este valor:" + txtdepartamento.Text + " ya Existe", CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        return Aux;
                    }
                }
            }
            else { Aux = false; }
            return Aux;
        }
        public void Activar()
        {
            btnnuevo.Enabled = btneliminar.Enabled = btnmodificar.Enabled = dtgconten.Enabled = true;
        }
        public void Desactivar()
        {
            btnnuevo.Enabled = btneliminar.Enabled = btnmodificar.Enabled = dtgconten.Enabled = false;
        }

        private void frmdepartamento_Load(object sender, EventArgs e)
        {
            estado = 0;
            dtgconten.DataSource = Cdepartamento.getCargoTipoContratacion("Cod_Dept", "Departamento", "TBL_Departamento");
            dtgconten.Focus();

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
                frmdepartamento_Load(sender, e);
            }
        }
        public Boolean Acepta = false;
        private void btnaceptar_Click(object sender, EventArgs e)
        {
            if (Acepta)
            { this.Close();DialogResult= DialogResult.OK; }
            else
            {
                //Estado 1=Nuevo. Estado 2=modificar. Estado 3=eliminar. Estado 0=SinAcciones
                if (estado == 1 && ValidarDes(txtdepartamento.Text))
                {
                    Cdepartamento.InsertarDepartamento(txtdepartamento.Text);
                    MessageBox.Show("Departamento: " + txtdepartamento.Text + " Insertado", CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    if (estado == 2 && ValidarDes(txtdepartamento.Text))
                    {
                        Cdepartamento.ActualizarDepartamento(txtdepartamento.Text.ToString(), Convert.ToInt32(txtcodigo.Text));
                        MessageBox.Show("Departamento: " + txtdepartamento.Text + " Actualizado", CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    {
                        if (estado == 3)
                        {
                            if (MessageBox.Show("Seguró Desea Eliminar " + txtdepartamento.Text, CompanyName, MessageBoxButtons.YesNo, MessageBoxIcon.Question).ToString() == "Yes")
                            {
                                Cdepartamento.EliminarDepartamento(Convert.ToInt32(txtcodigo.Text));
                            }
                        }
                    }
                }
                estado = 0;
                frmdepartamento_Load(sender, e);
                Activar();
            }
        }

        private void dtgconten_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtcodigo.Text = dtgconten[0, e.RowIndex].Value.ToString();
                txtdepartamento.Text = dtgconten[1, e.RowIndex].Value.ToString();
            }
            catch { }
        }
    }
}
