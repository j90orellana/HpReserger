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
    public partial class frmEmpleadoCTS : FormGradient
    {
        HPResergerCapaLogica.HPResergerCL clCTS = new HPResergerCapaLogica.HPResergerCL();

        public int CodigoDocumento { get; set; }


        public string NumeroDocumento { get; set; }

        public frmEmpleadoCTS()
        {
            InitializeComponent();
        }

        private void frmEmpleadoCTS_Load(object sender, EventArgs e)
        {
            CargaCombos(cboBanco, "Id_Entidad", "Entidad_Financiera", "TBL_Entidad_Financiera");
            CargaCombos(cboMoneda, "Id_Moneda", "Moneda", "TBL_Moneda");

            DataRow ExisteCTS = clCTS.CargarCualquierImagenPostulanteEmpleado("*", "TBL_Empleado_CTS", "Tipo_ID_Emp", CodigoDocumento, "Nro_ID_Emp", NumeroDocumento);
            if (ExisteCTS != null)
            {
                cboBanco.SelectedValue = Convert.ToInt32(ExisteCTS["BANCO"].ToString());
                cboMoneda.SelectedValue = Convert.ToInt32(ExisteCTS["MONEDA"].ToString());
                txtCuenta.Text = ExisteCTS["Nro_Cta"].ToString();
                txtCuentaCCI.Text = ExisteCTS["Nro_Cci"].ToString();
                btnModificar.Enabled = true;
                btnRegistrar.Enabled = false;
            }
            else
            {
                btnModificar.Enabled = false;
                btnRegistrar.Enabled = true;
            }
            btnaceptar.Enabled = false;
            pnlconten.Enabled = false;
        }

        private void CargaCombos(ComboBox cbo, string codigo, string descripcion, string tabla)
        {
            cbo.ValueMember = "codigo";
            cbo.DisplayMember = "descripcion";
            cbo.DataSource = clCTS.getCargoTipoContratacion(codigo, descripcion, tabla);
        }

        private void txtCuenta_KeyPress(object sender, KeyPressEventArgs e)
        {
            HPResergerFunciones.Utilitarios.SoloNumerosEnteros(e);
        }

        private void txtCuentaCCI_KeyPress(object sender, KeyPressEventArgs e)
        {
            HPResergerFunciones.Utilitarios.SoloNumerosEnteros(e);
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            estado = 1;
            btnModificar.Enabled = false;
            btnRegistrar.Enabled = false;
            btnaceptar.Enabled = true;
            pnlconten.Enabled = true;
        }

        private Boolean GrabarEditar(int Opcion)
        {
            if (txtCuenta.Text.Length == 0)
            {
                HPResergerFunciones.frmInformativo.MostrarDialogError("Ingrese Nº de Cuenta");
                txtCuenta.Focus();
                return false;
            }
            if (txtCuentaCCI.Text.Length < 20 && txtCuentaCCI.Text != "0")
            {
                HPResergerFunciones.frmInformativo.MostrarDialogError("Número de Cuenta CCI Mayor a 20 digitos");
                txtCuentaCCI.Focus();
                return false;
            }
            return true;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            estado = 2;
            btnModificar.Enabled = false;
            btnRegistrar.Enabled = false;
            btnaceptar.Enabled = true;
            pnlconten.Enabled = true;
        }

        private void txtCuenta_KeyDown(object sender, KeyEventArgs e)
        {
            HPResergerFunciones.Utilitarios.Validardocumentos(e, txtCuenta, 20);
        }

        private void txtCuentaCCI_KeyDown(object sender, KeyEventArgs e)
        {
            HPResergerFunciones.Utilitarios.Validardocumentos(e, txtCuentaCCI, 20);
        }
        int estado = 0;
        private void btncancelar_Click(object sender, EventArgs e)
        {
            if (estado != 0)
            {

                btnaceptar.Enabled = false;
                pnlconten.Enabled = false;
                if (estado == 1)
                {
                    btnRegistrar.Enabled = true;
                    btnModificar.Enabled = false;
                }
                if (estado == 2)
                {
                    btnRegistrar.Enabled = false;
                    btnModificar.Enabled = true;
                }
            }
            if (estado == 0)
            {
                this.Close();
            }
            estado = 0;
        }
        private void btnaceptar_Click(object sender, EventArgs e)
        {
            if (estado == 1)
            {
                if (GrabarEditar(1))
                {
                    HPResergerFunciones.frmInformativo.MostrarDialog("CTS registrado con éxito");
                    estado = 0;
                    btnaceptar.Enabled = false;
                    pnlconten.Enabled = false; btnModificar.Enabled = true;
                    clCTS.EmpleadoCTS(CodigoDocumento, NumeroDocumento, Convert.ToInt32(cboBanco.SelectedValue.ToString()), Convert.ToInt32(cboMoneda.SelectedValue.ToString()), txtCuenta.Text, txtCuentaCCI.Text, frmLogin.CodigoUsuario, 1);
                }
            }
            if (estado == 2)
            {
                if (GrabarEditar(0))
                {
                    HPResergerFunciones.frmInformativo.MostrarDialog("CTS Modificada con éxito");
                    clCTS.EmpleadoCTS(CodigoDocumento, NumeroDocumento, Convert.ToInt32(cboBanco.SelectedValue.ToString()), Convert.ToInt32(cboMoneda.SelectedValue.ToString()), txtCuenta.Text, txtCuentaCCI.Text, frmLogin.CodigoUsuario, 2);
                    estado = 0;
                    btnaceptar.Enabled = false;
                    pnlconten.Enabled = false; btnModificar.Enabled = true;
                }
            }
        }
    }
}
