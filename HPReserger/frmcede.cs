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
    public partial class frmcede : FormGradient
    {
        public frmcede()
        {
            InitializeComponent();
        }
        HPResergerCapaLogica.HPResergerCL CCargos = new HPResergerCapaLogica.HPResergerCL();
        int estado = 0;
        string tabla = "TBL_Sede";
        string campo = "Sede";
        string id = "Id_Sede";
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
            dtgconten.DataSource = CCargos.getCargoTipoContratacion(id, campo, tabla);
            dtgconten.Focus();
        }
        private void frmcede_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void btnnuevo_Click(object sender, EventArgs e)
        {
            estado = 1;
            iniciar(true);
            txtgerencia.Text = "";
            DataRow codigo = CCargos.VerUltimoIdentificador(tabla, id);
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
        }

        private void btnaceptar_Click(object sender, EventArgs e)
        {
            if (estado == 1)
            {
                //nuevo
                if (string.IsNullOrWhiteSpace(txtgerencia.Text))
                {
                    HPResergerFunciones.frmInformativo.MostrarDialogError("Ingresé Nombre de la Sede");
                    txtgerencia.Focus();
                    return;
                }
                foreach (DataGridViewRow valor in dtgconten.Rows)
                {
                    if (txtgerencia.Text.ToString() == valor.Cells["descripcion"].Value.ToString())
                    {
                        HPResergerFunciones.frmInformativo.MostrarDialogError("La Sede ya Existe");
                        txtgerencia.Focus();
                        return;
                    }
                }
                //Insertando;
                CCargos.InsertarActualizarSede(0, 1, txtgerencia.Text, frmLogin.CodigoUsuario);
                HPResergerFunciones.frmInformativo.MostrarDialog("Insertado Con Exito");
                btncancelar_Click(sender, e);
            }
            if (estado == 2)
            {
                //Modificar
                if (string.IsNullOrWhiteSpace(txtgerencia.Text))
                {
                    HPResergerFunciones.frmInformativo.MostrarDialogError("Ingresé Nombre de la Sede");
                    txtgerencia.Focus();
                    return;
                }
                int fila = 0;
                foreach (DataGridViewRow valor in dtgconten.Rows)
                {
                    if (txtgerencia.Text.ToString() == valor.Cells["descripcion"].Value.ToString() && fila != dtgconten.CurrentCell.RowIndex)
                    {
                        HPResergerFunciones.frmInformativo.MostrarDialogError("La Sede ya Existe");
                        txtgerencia.Focus();
                        return;
                    }
                    fila++;
                }
                //modificando
                CCargos.InsertarActualizarSede(int.Parse(txtcodigo.Text), 2, txtgerencia.Text, frmLogin.CodigoUsuario);
                HPResergerFunciones.frmInformativo.MostrarDialog("Actualizado Con Exito");
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
    }
}
