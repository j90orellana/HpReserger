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
    public partial class frmPagarFactura : Form
    {
        public frmPagarFactura()
        {
            InitializeComponent();
        }
        HPResergerCapaLogica.HPResergerCL cPagarfactura = new HPResergerCapaLogica.HPResergerCL();

        private void txtruc_TextChanged(object sender, EventArgs e)
        {
            if (txtruc.Text.Length > 9)
            {
                cbotipo.Enabled = true; cbobanco.Enabled = true; cbocuentabanco.Enabled = true;
                cbotipo.SelectedIndex = 0; txtnropago.Enabled = true;
            }
            else
            {
                cbotipo.Enabled = false; cbobanco.Enabled = false; cbocuentabanco.Enabled = false; txtnropago.Enabled = false; txtnropago.Text = "";
            }
            DataRow razonsocial = cPagarfactura.RUCProveedor(txtruc.Text);
            if (razonsocial != null)
            {
                txtRazonSocial.Text = razonsocial["razon_social"].ToString();
                txtdireccion.Text = razonsocial["direccion_oficina"].ToString();
                txtTelefono.Text = razonsocial["telefono_oficina"].ToString();
                //cargarguias(txtguia);//txtguia_TextChanged(sender, e);
                Dtguias.DataSource = cPagarfactura.ListarFacturasPorPagar(txtruc.Text);
            }
            else
            {
                txtRazonSocial.Text = txtdireccion.Text = txtTelefono.Text = "";
                // chlbx.Items.Clear();
                Dtguias.DataSource = cPagarfactura.ListarFacturasPorPagar("");

                //Dtguias.Refresh();
                // DtgConten.Refresh();
            }
        }
        private void frmPagarFactura_Load(object sender, EventArgs e)
        {
            txtruc_TextChanged(sender, e);
            Application.CurrentCulture = System.Globalization.CultureInfo.CreateSpecificCulture("EN-US");
            // txtruc.Text = "0701046971";
            //    radioButton1.Checked = true;
            Dtguias.DataSource = cPagarfactura.ListarFacturasPorPagar(txtruc.Text);
            cbotipo.SelectedIndex = 0;
            txttotal.Text = "0.00";
        }
        private void cbotipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbotipo.SelectedIndex == 0 || cbotipo.SelectedIndex == 1)
            {
                cbobanco.Visible = lblguia1.Visible = lblguia.Visible = cbocuentabanco.Visible = true;
                lblguia.Text = "Banco";
                cbobanco.ValueMember = "codigo";
                cbobanco.DisplayMember = "descripcion";
                cbobanco.DataSource = cPagarfactura.getCargoTipoContratacion("Sufijo", "Entidad_Financiera", "TBL_Entidad_Financiera");
            }
            else
            {
                cbobanco.Visible = lblguia1.Visible = lblguia.Visible = cbocuentabanco.Visible = false;
            }
        }
        private void cbobanco_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbobanco.SelectedIndex >= 0)
            {
                cbocuentabanco.Text = "";
                cbocuentabanco.ValueMember = "Id_Cuenta_Contable";
                cbocuentabanco.DisplayMember = "banco";
                cbocuentabanco.DataSource = cPagarfactura.ListarBancosTiposdePago(cbobanco.SelectedValue.ToString());
            }
        }
        private void txtruc_KeyUp(object sender, KeyEventArgs e)
        {

        }
        private void txtruc_KeyPress(object sender, KeyPressEventArgs e)
        {
            HPResergerFunciones.Utilitarios.SoloNumerosEnteros(e);
        }
        private void txtruc_KeyDown(object sender, KeyEventArgs e)
        {
            HPResergerFunciones.Utilitarios.Validardocumentos(e, txtruc, 11);
        }
        public void msg(string cadena)
        {
            MessageBox.Show(cadena, "HpReserger", MessageBoxButtons.OK, MessageBoxIcon.Question);
        }
        private void btnaceptar_Click(object sender, EventArgs e)
        {
            if (cbotipo.SelectedIndex != 2)
            {
                if (string.IsNullOrWhiteSpace(txtnropago.Text))
                {
                    msg("Ingrese Nro de pago");
                    txtnropago.Focus();
                    return;
                }
            }
            if (cbobanco.Items.Count == 0)
            {
                msg("No hay Bancos");
                cbobanco.Focus();
                return;
            }
            if (cbocuentabanco.Items.Count == 0)
            {
                msg("El Banco Seleccionado No tiene Cuenta");
                cbobanco.Focus();
                return;
            }
            if (txttotal.Text.Length > 0)
            {
                if (decimal.Parse(txttotal.Text) == 0)
                {
                    msg("El total a pagar no puede ser Cero");
                    Dtguias.Focus();
                    return;
                }
            }
            else
            {
                msg("El Monto esta Vacio, Seleccioné una Fila de la grilla");
                Dtguias.Focus();
                return;
            }
            if (MessageBox.Show("Seguro desea Guardar", "HpReserger", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                int numasiento; string facturar = "";
                DataTable asientito = cPagarfactura.UltimoAsiento();
                DataRow asiento = asientito.Rows[0];
                numasiento = (int)asiento["codigo"];
                foreach (DataGridViewRow lista in Dtguias.Rows)
                {
                    DataGridViewCheckBoxCell ch1 = new DataGridViewCheckBoxCell();
                    ch1 = (DataGridViewCheckBoxCell)lista.Cells["ok"];
                    if (ch1.Value == null)
                        ch1.Value = false;
                    if (lista.Cells["OK"].Value == null)
                        lista.Cells["OK"].Value = false;
                    switch (lista.Cells["OK"].Value.ToString())
                    {
                        case "True":
                            if (lista.Cells["tipodoc"].Value.ToString().Substring(0, 2) == "RH")
                            {
                                //actualizo que el recibo este pagado
                                cPagarfactura.insertarPagarfactura(lista.Cells["nrofactura"].Value.ToString(), int.Parse(cbotipo.Text.Substring(0, 3)), txtnropago.Text);
                                //cuenta de recibo por honorarios 4241101
                                cPagarfactura.guardarfactura(1, numasiento + 1, lista.Cells["nrofactura"].Value.ToString(), "4241101", (decimal)lista.Cells["subtotal"].Value, 0);
                                facturar = lista.Cells["nrofactura"].Value.ToString();
                            }
                            else
                            {
                                //actualizo que la factura esta pagada
                                cPagarfactura.insertarPagarfactura(lista.Cells["nrofactura"].Value.ToString(), int.Parse(cbotipo.Text.Substring(0, 3)), txtnropago.Text);
                                ///facturas por pagar 4212101
                                cPagarfactura.guardarfactura(1, numasiento + 1, lista.Cells["nrofactura"].Value.ToString(), "4212101", (decimal)lista.Cells["total"].Value, 0);
                                facturar = lista.Cells["nrofactura"].Value.ToString();
                            }
                            break;
                        case "False":
                            break;
                    }
                }
                cPagarfactura.guardarfactura(0, numasiento + 1, facturar, cbocuentabanco.SelectedValue.ToString(), 0, decimal.Parse(txttotal.Text));
                msg("Documento Pagado y se ha Generado su Asiento");
                txtruc_TextChanged(sender, e);
            }
        }
        decimal sumatoria;
        private void Dtguias_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Dtguias.EndEdit();
            if (Dtguias.RowCount > 0)
            {
                btnaceptar.Enabled = true;
                sumatoria = 0;
                foreach (DataGridViewRow lista in Dtguias.Rows)
                {
                    DataGridViewCheckBoxCell ch1 = new DataGridViewCheckBoxCell();
                    ch1 = (DataGridViewCheckBoxCell)lista.Cells["ok"];
                    if (ch1.Value == null)
                        ch1.Value = false;
                    if (lista.Cells["OK"].Value == null)
                        lista.Cells["OK"].Value = false;
                    switch (lista.Cells["OK"].Value.ToString())
                    {
                        case "True":
                            if (lista.Cells["tipodoc"].Value.ToString().Substring(0, 2) == "RH")
                                sumatoria += (decimal)lista.Cells["subtotal"].Value;
                            else
                                sumatoria += (decimal)lista.Cells["total"].Value;
                            break;
                        case "False":
                            break;
                    }
                }
                txttotal.Text = sumatoria.ToString("n2");
            }
            if (sumatoria == 0)
                btnaceptar.Enabled = false;
            else
                btnaceptar.Enabled = true;
        }

        private void Dtguias_RowErrorTextChanged(object sender, DataGridViewRowEventArgs e)
        {

        }

        private void Dtguias_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (Dtguias.RowCount < 0)
            {
                cbotipo.Enabled = cbobanco.Enabled = cbocuentabanco.Enabled = btnaceptar.Enabled = false;
                cbotipo.SelectedIndex = 0; txtnropago.Enabled = false;

            }
            else
            {
                cbotipo.Enabled = true; cbobanco.Enabled = true; cbocuentabanco.Enabled = true;
                cbotipo.SelectedIndex = 0; txtnropago.Enabled = true;
                btnaceptar.Enabled = true;
            }

        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            if (txtruc.Text.Length > 8)
            {
                if (MessageBox.Show("Desea Salir", "HpReserger", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    this.Close();
                }
            }
            else
                this.Close();
        }
    }
}
