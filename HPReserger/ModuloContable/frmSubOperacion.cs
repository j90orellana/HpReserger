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
    public partial class frmSubOperacion : FormGradient
    {
        public frmSubOperacion()
        {
            InitializeComponent();
        }
        HPResergerCapaLogica.HPResergerCL CCargos = new HPResergerCapaLogica.HPResergerCL();
        int estado = 0;
        public void msg(string cadena) { HPResergerFunciones.frmInformativo.MostrarDialogError(cadena); }
        public void msgOK(string cadena) { HPResergerFunciones.frmInformativo.MostrarDialog(cadena); }

        public void iniciar(Boolean a)
        {
            btnnuevo.Enabled = !a;
            btnmodificar.Enabled = !a;
            btnaceptar.Enabled = a;
            dtgconten.Enabled = !a;
            btneliminar.Enabled = !a;
            // txtruc.Enabled = a;
            btnborrar.Enabled = !a;
            txtbuscar.Enabled = !a;
            cboestado.Enabled = a;
            txtnombre.Enabled = a;
            cbooperacion.Enabled = a;
        }
        public void CargarCombos(ComboBox combito)
        {
            DataTable tablita = new DataTable();
            tablita.Columns.Add("CODIGO");
            tablita.Columns.Add("VALOR");
            tablita.Rows.Add(new object[] { "1", "Activo" });
            tablita.Rows.Add(new object[] { "0", "Inactivo" });
            combito.DataSource = tablita;
            combito.DisplayMember = "VALOR";
            combito.ValueMember = "CODIGO";
        }
        public void CargadOperaciones(ComboBox combito)
        {
            combito.DisplayMember = "descripcion";
            combito.ValueMember = "codigo";
            combito.DataSource = CCargos.getCargoTipoContratacion("Id_Operacion", "Operacion", "TBL_Operacion");
        }
        public void CargarDatos()
        {
            dtgconten.DataSource = CCargos.InsertarActualizarListarSubOperacion("0", 0, "0", "0", "0", 0, 0);
            dtgconten.Focus();
        }
        private void frmSubOperacion_Load(object sender, EventArgs e)
        {
            CargarDatos();
            CargarCombos(cboestado);
            CargadOperaciones(cbooperacion);
        }

        private void dtgconten_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (dtgconten.RowCount > 0)
            {
                btnmodificar.Enabled = true;
                txtruc.Text = dtgconten["codigo", e.RowIndex].Value.ToString();
                txtnombre.Text = dtgconten["campo1", e.RowIndex].Value.ToString();
                cboestado.Text = dtgconten["campo3", e.RowIndex].Value.ToString();
                cbooperacion.Text = dtgconten["operacion", e.RowIndex].Value.ToString();
                btneliminar.Enabled = true;
                btnexportarExcel.Enabled = true;
            }
            else
            {
                btnexportarExcel.Enabled = false;
                btnmodificar.Enabled = false;
                btneliminar.Enabled = false;
            }
        }

        private void btnnuevo_Click(object sender, EventArgs e)
        {
            estado = 1;
            iniciar(true);
            txtnombre.Text = txtruc.Text = "";
            //DataRow codigo = CCargos.VerUltimoIdentificador(tabla, id);
            //txtaporte.Text = (int.Parse(codigo["ultimo"].ToString()) + 1).ToString();
            txtnombre.Focus();
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

        private void btnmodificar_Click(object sender, EventArgs e)
        {
            estado = 2; btnmodificar.Enabled = false;
            iniciar(true); txtnombre.Focus();
        }

        private void btnexportarExcel_Click(object sender, EventArgs e)
        {
            if (dtgconten.RowCount > 0)
            {
                List<HPResergerFunciones.Utilitarios.NombreCelda> Celditas = new List<HPResergerFunciones.Utilitarios.NombreCelda>();
                HPResergerFunciones.Utilitarios.NombreCelda Celdita = new HPResergerFunciones.Utilitarios.NombreCelda();
                Celdita.fila = 1; Celdita.columna = 1; Celdita.Nombre = "Listado de Sub-Operaciones";
                Celditas.Add(Celdita);
                HPResergerFunciones.Utilitarios.ExportarAExcel(dtgconten, "", "Sub-Operaciones", Celditas, 1, new int[] { 1, 3, 5 }, new int[] { 1 }, new int[] { });
                msgOK("Exportado con Exito");
            }
            else
                msg("No hay Filas para Exportar");
        }
        private void btnborrar_Click(object sender, EventArgs e)
        {
            txtbuscar.Text = "";
        }
        private void txtbuscar_TextChanged(object sender, EventArgs e)
        {
            dtgconten.DataSource = CCargos.InsertarActualizarListarSubOperacion("0", 10, txtbuscar.Text, "0", "0", 0, 0);
        }
        private void btnaceptar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtruc.Text))
            {
                //Msg("Ingresé Codigo");
                //txtruc.Focus();
                //return;
            }
            if (string.IsNullOrWhiteSpace(cboestado.Text))
            {
                msg("Seleccione Estado");
                cboestado.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(txtnombre.Text))
            {
                msg("Ingresé Nombre Sub-Operación");
                txtnombre.Focus();
                return;
            }
            /* decimal aportex = decimal.Parse(txtaporte.Text) / 100;
             decimal segurox = decimal.Parse(txtseguro.Text) / 100;
             decimal comisionx = decimal.Parse(txtcomision.Text) / 100;*/
            if (estado == 1)
            {
                //nuevo
                /* if (string.IsNullOrWhiteSpace(txtgerencia.Text))
                 {
                     Msg("Ingresé Nombre del Afp");
                     txtgerencia.Focus();
                     return;
                 }*/
                foreach (DataGridViewRow valor in dtgconten.Rows)
                {
                    if (txtruc.Text.ToString() == valor.Cells["campo1"].Value.ToString())
                    {
                        msg("La Sub-Operación ya Existe");
                        txtruc.Focus();
                        return;
                    }
                }
                //Insertando;
                CCargos.InsertarActualizarListarSubOperacion(txtruc.Text, 1, txtnombre.Text, cboestado.SelectedValue.ToString(), cbooperacion.SelectedValue.ToString(), frmLogin.CodigoUsuario, 2);
                msgOK("Insertado Con Exito");
                btncancelar_Click(sender, e);
            }
            if (estado == 2)
            {
                //Modificar
                /*  if (string.IsNullOrWhiteSpace(txtgerencia.Text))
                  {
                      Msg("Ingresé Nombre del Afp");
                      txtgerencia.Focus();
                      return;
                  }*/
                int fila = 0;
                foreach (DataGridViewRow valor in dtgconten.Rows)
                {
                    if (txtruc.Text.ToString() == valor.Cells["campo1"].Value.ToString() && fila != dtgconten.CurrentCell.RowIndex)
                    {
                        msg("La Sub-Operación ya Existe");
                        txtruc.Focus();
                        return;
                    }
                    fila++;
                }
                //modificando
                CCargos.InsertarActualizarListarSubOperacion((dtgconten["campo4", dtgconten.CurrentCell.RowIndex].Value.ToString()), 2, txtnombre.Text, cboestado.SelectedValue.ToString(), cbooperacion.SelectedValue.ToString(), frmLogin.CodigoUsuario, int.Parse(dtgconten["codigo", dtgconten.CurrentCell.RowIndex].Value.ToString()));
                msgOK("Actualizado Con Exito");
                btncancelar_Click(sender, e);
            }
            if (estado == 0)
            {

            }
        }
        private void cbooperacion_Enter(object sender, EventArgs e)
        {
            string cadena = cbooperacion.Text;
            CargadOperaciones(cbooperacion);
            cbooperacion.Text = cadena;
        }

        private void cbooperacion_Click(object sender, EventArgs e)
        {
            string text = cbooperacion.Text;
            CargadOperaciones(cbooperacion);
            cbooperacion.Text = text;
        }
    }
}
