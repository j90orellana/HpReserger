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
    public partial class frmccosto : Form
    {
        public frmccosto()
        {
            InitializeComponent();
        }
        public Boolean Consulta = false;
        public int ConsulCodi = 0;
        public int estado { get; set; }
        public string cadeaux = ""; public string siono = "";
        HPResergerCapaLogica.HPResergerCL Ccostos = new HPResergerCapaLogica.HPResergerCL();
        private void frmccosto_Load(object sender, EventArgs e)
        {
            cbocuentas.DataSource = Ccostos.ListarCuentasArticulos();
            cbocuentas.DisplayMember = "codigo";
            cbocuentas.ValueMember = "codigo";
            estado = 0;
            Cargarsiyno(cbotiene);
            radioButton2.Checked = true; dtgconten.DataSource = Ccostos.ListarCentrosdeCosto(0, 0, null);
            dtgconten.Focus();
        }
        public void Cargarsiyno(ComboBox combito)
        {
            DataTable tablita = new DataTable();
            tablita.Columns.Add("CODIGO");
            tablita.Columns.Add("VALOR");
            tablita.Rows.Add(new object[] { "1", "SI" });
            tablita.Rows.Add(new object[] { "2", "NO" });
            combito.DataSource = tablita;
            combito.DisplayMember = "VALOR";
            combito.ValueMember = "CODIGO";
            combito.SelectedIndex = 0;
        }
        public void Activar()
        {
            btnnuevo.Enabled = btneliminar.Enabled = btnmodificar.Enabled = dtgconten.Enabled = true;
        }
        public void Desactivar()
        {
            btnnuevo.Enabled = btneliminar.Enabled = btnmodificar.Enabled = dtgconten.Enabled = false;
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            if (estado == 0)
            {
                this.Visible = false;
            }
            else
            {
                pnl1.Enabled = false;
                estado = 0; gp1.Enabled = true;
                Activar();
                frmccosto_Load(sender, e);
            }
        }

        private void btnnuevo_Click(object sender, EventArgs e)
        {
            pnl1.Enabled = true;
            tipmsg.Show("Ingrese Centro de Costo", txtcosto, 1000);
            txtcodigo.Text = txtcosto.Text = "";
            estado = 1;
            Desactivar(); gp1.Enabled = false;
            txtcodigo.Focus();
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            estado = 3;
            btnaceptar_Click(sender, e);
        }

        private void btnmodificar_Click(object sender, EventArgs e)
        {
            pnl1.Enabled = true;
            tipmsg.Show("Ingrese Centro de Costo", txtcosto, 700);
            Desactivar();
            estado = 2; gp1.Enabled = false; txtcodigo.Focus();
        }

        private void btnaceptar_Click(object sender, EventArgs e)
        {
            if (Consulta)
            {
                if (dtgconten.RowCount > 0)
                {
                    int x = dtgconten.CurrentCell.RowIndex;
                    ConsulCodi = (int)dtgconten[idcodigo.Name, x].Value;
                }
                DialogResult = DialogResult.OK;
                this.Close();
            }

            cadeaux = cbocuentas.Text; siono = cbotiene.Text;
            //Estado 1=Nuevo. Estado 2=modificar. Estado 3=eliminar. Estado 0=SinAcciones
            if (!string.IsNullOrWhiteSpace(txtcosto.Text))
            {
                if (estado == 1 && ValidarDes(txtcosto.Text) && ValidarCodigo(txtcodigo.Text))
                {
                    Ccostos.InsertarCentroCostros(txtcodigo.Text, txtcosto.Text, cbotiene.SelectedValue.ToString(), cbocuentas.SelectedValue.ToString());
                    MessageBox.Show("Centro de Costo, Ingresado", "Hp Reserger", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    if (estado == 2 && ValidarDes(txtcosto.Text) && ValidarCodigo(txtcodigo.Text))
                    {
                        Ccostos.ActualizarCentroCostos(txtcosto.Text.ToString(), txtcodigo.Text, int.Parse(dtgconten["idcodigo", dtgconten.CurrentCell.RowIndex].Value.ToString()), cbotiene.SelectedValue.ToString(), cbocuentas.SelectedValue.ToString());
                        MessageBox.Show("Centro de Costo, Actualizado", "Hp Reserger", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        if (estado == 3)
                        {
                            if (MessageBox.Show("Seguró Desea Eliminar " + txtcosto.Text, "Hp Reserger", MessageBoxButtons.YesNo, MessageBoxIcon.Question).ToString() == "Yes")
                            {
                                //Ccostos.EliminarGerencia(Convert.ToInt32(txtcodigo.Text));
                            }
                        }
                    }
                }
                estado = 0;
                frmccosto_Load(sender, e);
                Activar(); gp1.Enabled = true;
                pnl1.Enabled = false;
            }
            else { MessageBox.Show("Debe Rellenar el campo Descripción", "Hp Reserger", MessageBoxButtons.OK, MessageBoxIcon.Information); }
        }
        public Boolean ValidarDes(string valor)
        {
            Boolean Aux = true;
            for (int i = 0; i < dtgconten.RowCount; i++)
            {
                if (dtgconten["descripcion", i].Value.ToString() == valor && dtgconten.CurrentCell.RowIndex != i)
                {
                    Aux = false;
                    MessageBox.Show("Este valor:" + txtcosto.Text + " ya Existe", "Hp Reserger", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return Aux;
                }
            }
            return Aux;
        }
        public Boolean ValidarCodigo(string valor)
        {
            Boolean Aux = true;
            for (int i = 0; i < dtgconten.RowCount; i++)
            {
                if (dtgconten["codigos", i].Value.ToString() == valor && dtgconten.CurrentCell.RowIndex != i)
                {
                    Aux = false;
                    MessageBox.Show("Este Código:" + txtcosto.Text + " ya Existe", "Hp Reserger", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return Aux;
                }
            }
            return Aux;
        }
        private void dtgconten_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (dtgconten.RowCount > 0)
            {
                txtcodigo.Text = dtgconten["codigos", e.RowIndex].Value.ToString();
                txtcosto.Text = dtgconten["Descripcion", e.RowIndex].Value.ToString();
                if (dtgconten["idcuenta", e.RowIndex].Value.ToString() == "")
                    cbocuentas.SelectedIndex = -1;
                else
                    cbocuentas.Text = dtgconten["idcuenta", e.RowIndex].Value.ToString();
                cbotiene.SelectedValue = dtgconten["tienecuenta", e.RowIndex].Value.ToString();
            }

        }

        private void txtcosto_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtcodigo_TextChanged(object sender, EventArgs e)
        {

        }

        private void dtgconten_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Limpiar_Click(object sender, EventArgs e)
        {
            txtbuscar.Text = "";
        }

        private void txtbuscar_TextChanged(object sender, EventArgs e)
        {

        }
        int CODIGO = 0, CENTRO = 0;
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void txtbuscar_TextChanged_1(object sender, EventArgs e)
        {
            dtgconten.DataSource = Ccostos.ListarCentrosdeCosto(CODIGO, CENTRO, txtbuscar.Text);
        }

        private void Limpiar_Click_1(object sender, EventArgs e)
        {
            txtbuscar.Text = "";
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
                CODIGO = 1;
            else CODIGO = 0;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
                CENTRO = 1;
            else CENTRO = 0;
        }

        private void txtcodigo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtcosto.Focus();
            }
        }

        private void txtcosto_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnaceptar.Focus();
            }
        }

        private void cbocuentas_TextChanged(object sender, EventArgs e)
        {
        }

        private void dtgconten_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (Consulta)
            {
                int x = e.RowIndex;
                ConsulCodi = (int)dtgconten[idcodigo.Name, x].Value;
                this.Close();
            }
        }

        private void chkcodigo_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
