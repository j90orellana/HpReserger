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
    public partial class frmSectorEmpresarial : FormGradient
    {
        HPResergerCapaLogica.HPResergerCL clSectorEmpresarial = new HPResergerCapaLogica.HPResergerCL();
        public void msg(string cadena) { HPResergerFunciones.frmInformativo.MostrarDialogError(cadena); }
        public void msgOK(string cadena) { HPResergerFunciones.frmInformativo.MostrarDialog(cadena); }
        public frmSectorEmpresarial()
        {
            InitializeComponent();
        }
        HPResergerCapaLogica.HPResergerCL CCargos = new HPResergerCapaLogica.HPResergerCL();
        public int estado = 0;
        public Boolean Consulta = false;
        string tabla = "TBL_Sector_Empresarial";
        string campo = "Desc_Sector_Empresarial";
        string id = "Codigo_Sector_Empresarial";
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
        private void frmSectorEmpresarial_Load(object sender, EventArgs e)
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
                if (Consulta) btnaceptar.Enabled = true;
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
                    msg("Ingresé Nombre del Sector Empresarial");
                    txtgerencia.Focus();
                    return;
                }
                foreach (DataGridViewRow valor in dtgconten.Rows)
                {
                    if (txtgerencia.Text.ToString() == valor.Cells["descripcion"].Value.ToString())
                    {
                        msg("El Sector Empresarial ya Existe");
                        txtgerencia.Focus();
                        return;
                    }
                }
                //Insertando;
                CCargos.InsertarActualizarSector_Empresarial(0, 1, txtgerencia.Text, frmLogin.CodigoUsuario);
                msgOK("Insertado Con Exito");
                iniciar(false);
            }
            if (estado == 2)
            {
                //Modificar
                if (string.IsNullOrWhiteSpace(txtgerencia.Text))
                {
                    msg("Ingresé Nombre del Sector Empresarial");
                    txtgerencia.Focus();
                    return;
                }
                int fila = 0;
                foreach (DataGridViewRow valor in dtgconten.Rows)
                {
                    if (txtgerencia.Text.ToString() == valor.Cells["descripcion"].Value.ToString() && fila != dtgconten.CurrentCell.RowIndex)
                    {
                        msg("El Sector Empresarial ya Existe");
                        txtgerencia.Focus();
                        return;
                    }
                    fila++;
                }
                //modificando
                CCargos.InsertarActualizarSector_Empresarial(int.Parse(txtcodigo.Text), 2, txtgerencia.Text, frmLogin.CodigoUsuario);
                msgOK("Actualizado Con Exito");
                iniciar(false);
            }
            if (estado == 0)
            {

            }
            if (Consulta && estado != 1)
            {
                if (txtcodigo.TextLength > 0)
                {
                    estado = int.Parse(txtcodigo.Text);
                    DialogResult = DialogResult.OK;
                    this.Close();
                    return;
                }
            }
            if (Consulta) btnaceptar.Enabled = true;
            estado = 0; CargarDatos();
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
