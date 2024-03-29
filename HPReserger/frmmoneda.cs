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
    public partial class frmmoneda : FormGradient
    {
        public frmmoneda()
        {
            InitializeComponent();
        }
        HPResergerCapaLogica.HPResergerCL CCargos = new HPResergerCapaLogica.HPResergerCL();
        public void msg(string cadena) { HPResergerFunciones.frmInformativo.MostrarDialogError(cadena); }
        public void msgOK(string cadena) { HPResergerFunciones.frmInformativo.MostrarDialog(cadena); }
        int estado = 0;
        public void iniciar(Boolean a)
        {
            btnnuevo.Enabled = !a;
            btnmodificar.Enabled = !a;
            btnaceptar.Enabled = a;
            dtgconten.Enabled = !a;
            btneliminar.Enabled = !a;
            txtgerencia.Enabled = a;
            txtname.Enabled = a;
        }
        public void CargarDatos()
        {
            dtgconten.DataSource = CCargos.InsertarActualizarMoneda();
            dtgconten.Focus();
        }
        private void frmmoneda_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }
        private void btnnuevo_Click(object sender, EventArgs e)
        {
            estado = 1;
            iniciar(true);
            txtgerencia.Text = ""; txtname.Text = "";
            DataRow codigo = CCargos.VerUltimoIdentificador("TBL_Moneda", "Id_Moneda");
            txtcodigo.Text = (int.Parse(codigo["ultimo"].ToString()) + 1).ToString();
            txtname.Enabled = true;
            txtgerencia.Focus();
        }

        private void btnmodificar_Click(object sender, EventArgs e)
        {
            estado = 2; btnmodificar.Enabled = false;
            iniciar(true); txtgerencia.Focus();
            txtname.Enabled = true;
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            if (estado == 0)
            {
                this.Close();
            }
            else
            {
                iniciar(false);
                estado = 0;
            }
            CargarDatos();
        }

        private void btnaceptar_Click(object sender, EventArgs e)
        {
            if (estado == 1)
            {
                //nuevo
                if (string.IsNullOrWhiteSpace(txtgerencia.Text))
                {
                    msg("Ingresé Nombre de la Moneda");
                    txtgerencia.Focus();
                    return;
                }
                if (string.IsNullOrWhiteSpace(txtname.Text))
                {
                    msg("Ingresé Moneda");
                    txtname.Focus();
                    return;
                }
                foreach (DataGridViewRow valor in dtgconten.Rows)
                {
                    if (txtgerencia.Text.ToString() == valor.Cells["descripcion"].Value.ToString())
                    {
                        msg("La Moneda ya Existe");
                        txtgerencia.Focus();
                        return;
                    }
                }
                //Insertando;
                CCargos.InsertarActualizarMoneda(0, 1, txtgerencia.Text, frmLogin.CodigoUsuario, txtname.Text);
                msgOK("Insertado Con Exito");
                btncancelar_Click(sender, e);
            }
            if (estado == 2)
            {
                //Modificar
                if (string.IsNullOrWhiteSpace(txtgerencia.Text))
                {
                    msg("Ingresé Nombre de la Moneda");
                    txtgerencia.Focus();
                    return;
                }
                if (string.IsNullOrWhiteSpace(txtname.Text))
                {
                    msg("Ingresé Moneda");
                    txtname.Focus();
                    return;
                }
                int fila = 0;
                foreach (DataGridViewRow valor in dtgconten.Rows)
                {
                    if (txtgerencia.Text.ToString() == valor.Cells["descripcion"].Value.ToString() && fila != dtgconten.CurrentCell.RowIndex)
                    {
                        msg("La Moneda ya Existe");
                        txtgerencia.Focus();
                        return;
                    }
                    fila++;
                }
                //modificando
                CCargos.InsertarActualizarMoneda(int.Parse(txtcodigo.Text), 2, txtgerencia.Text, frmLogin.CodigoUsuario, txtname.Text);
                msgOK("Actualizado Con Exito");
                btncancelar_Click(sender, e);
            }
            if (estado == 0)
            {

            }
        }
        private void dtgconten_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (dtgconten.RowCount > 0)
            {
                btnmodificar.Enabled = true;
                txtcodigo.Text = (string)dtgconten[Codigos.Name, e.RowIndex].Value.ToString();
                txtgerencia.Text = (string)dtgconten[Descripcion.Name, e.RowIndex].Value.ToString(); btneliminar.Enabled = true;
                txtname.Text = dtgconten[namex.Name, e.RowIndex].Value.ToString();
            }
            else
            {
                btnmodificar.Enabled = false;
                btneliminar.Enabled = false;
            }
        }
    }
}
