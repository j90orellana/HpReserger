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
    public partial class frmprofesion : FormGradient, IProfesion
    {
        public frmprofesion()
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
        }
        public void CargarDatos()
        {
            dtgconten.DataSource = CCargos.getCargoTipoContratacion("Id_Profesion", "Profesion", "TBL_Profesion");
            dtgconten.Focus();
        }
        private void frmprofesion_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }
        private void btnnuevo_Click(object sender, EventArgs e)
        {
            estado = 1;
            iniciar(true);
            txtgerencia.Text = "";
            DataRow codigo = CCargos.VerUltimoIdentificador("TBL_Profesion", "Id_Profesion");
            txtcodigo.Text = (int.Parse(codigo["ultimo"].ToString()) + 1).ToString();
            txtgerencia.Focus();
        }

        private void btnmodificar_Click(object sender, EventArgs e)
        {
            estado = 2; btnmodificar.Enabled = false;
            iniciar(true); txtgerencia.Focus();
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
            IProfesion iForm = this.MdiParent as IProfesion;
            if (iForm != null)
                iForm.CargarProfesion();
        }

        private void btnaceptar_Click(object sender, EventArgs e)
        {
            if (estado == 1)
            {
                //nuevo
                if (string.IsNullOrWhiteSpace(txtgerencia.Text))
                {
                    msg("Ingresé Nombre de la Profesión");
                    txtgerencia.Focus();
                    return;
                }
                foreach (DataGridViewRow valor in dtgconten.Rows)
                {
                    if (txtgerencia.Text.ToString() == valor.Cells["descripcion"].Value.ToString())
                    {
                        msg("la Profesión ya Existe");
                        txtgerencia.Focus();
                        return;
                    }
                }
                //Insertando;
                CCargos.InsertarActualizarProfesion(0, 1, txtgerencia.Text, frmLogin.CodigoUsuario);
                msgOK("Insertado Con Exito");
                btncancelar_Click(sender, e);
            }
            if (estado == 2)
            {
                //Modificar
                if (string.IsNullOrWhiteSpace(txtgerencia.Text))
                {
                    msg("Ingresé Nombre de la Profesión");
                    txtgerencia.Focus();
                    return;
                }
                int fila = 0;
                foreach (DataGridViewRow valor in dtgconten.Rows)
                {
                    if (txtgerencia.Text.ToString() == valor.Cells["descripcion"].Value.ToString() && fila != dtgconten.CurrentCell.RowIndex)
                    {
                        msg("la Profesión ya Existe");
                        txtgerencia.Focus();
                        return;
                    }
                    fila++;
                }
                //modificando
                CCargos.InsertarActualizarProfesion(int.Parse(txtcodigo.Text), 2, txtgerencia.Text, frmLogin.CodigoUsuario);
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
                txtcodigo.Text = (string)dtgconten[0, e.RowIndex].Value.ToString();
                txtgerencia.Text = (string)dtgconten[1, e.RowIndex].Value.ToString(); btneliminar.Enabled = true;
            }
            else
            {
                btnmodificar.Enabled = false;
                btneliminar.Enabled = false;
            }
        }
        public void CargarProfesion()
        {
            CargarDatos();
        }

        public void CargarGrado()
        {
            throw new NotImplementedException();
        }
    }
}
