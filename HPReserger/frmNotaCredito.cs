using HpResergerUserControls;
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
    public partial class frmNotaCredito : FormGradient
    {
        public frmNotaCredito()
        {
            InitializeComponent();
            tipo = 1;
        }
        public frmNotaCredito(int _tipo)
        {
            InitializeComponent();
            tipo = _tipo;
        }
        //por pagar - todos=0,porpagar=1 pagados=2
        string PorPagar = "0";
        public int tipo { get; set; }
        HPResergerCapaLogica.HPResergerCL CapaLogica = new HPResergerCapaLogica.HPResergerCL();
        public void msg(string cadena) { HPResergerFunciones.frmInformativo.MostrarDialogError(cadena); }
        public void msgOK(string cadena) { HPResergerFunciones.frmInformativo.MostrarDialog(cadena); }
        private void frmNotaCredito_Load(object sender, EventArgs e)
        {
            CargarNotas();
            cbotiponota.SelectedValue = tipo;
        }
        DataTable Notas;
        public void CargarNotas()
        {
            Notas = new DataTable();
            Notas.Columns.Add("codigo", typeof(int));
            Notas.Columns.Add("valor");
            Notas.Rows.Add(1, "Nota Crédito");
            Notas.Rows.Add(2, "Nota Débito");
            cbotiponota.DisplayMember = "valor";
            cbotiponota.ValueMember = "codigo";
            cbotiponota.DataSource = Notas;
        }
        public void CalculoTotales()
        {
            txttotal.Text = (Convert.ToDecimal(txtsubtotal.Text) + Convert.ToDecimal(txtigv.Text)).ToString("n2");
        }
        private void txtcodfactura_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '-' || e.KeyChar == '-')
            {
                e.Handled = true;
                txtnronota.Focus();
            }
        }
        private void txtcodfactura_Leave(object sender, EventArgs e)
        {
            HPResergerFunciones.Utilitarios.AjustarTexto(txtcodnota, 4);
        }
        private void txtnrofactura_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Back)
                if (txtnronota.Text.Length == 0)
                    txtcodnota.Focus();
        }
        private void txtnrofactura_Leave(object sender, EventArgs e)
        {
            HPResergerFunciones.Utilitarios.AjustarTexto(txtnronota, 15);
            //buscar si la factura ya existe en el sistema
            if (!string.IsNullOrWhiteSpace(txtnronota.Text))
            {
                //DataRow factura = cfactura.BuscarFacturas(txtruc.Text, $"{txtcodnota.Text}-{txtnronota.Text}");
                //if (factura != null)
                //{
                //    MSG("Nro Factura ya Existe");
                //}
            }
        }
        private void btncancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        frmproveedor frmprovee;
        private void btnmaspro_Click(object sender, EventArgs e)
        {
            frmprovee = new frmproveedor();
            frmprovee.Txtbusca.Text = txtruc.Text;
            frmprovee.llamada = 1;
            frmprovee.Icon = Icon;
            frmprovee.MdiParent = ParentForm;
            frmprovee.FormClosed += Frmprovee_FormClosed;
            frmprovee.Show();
        }
        private void Frmprovee_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (frmprovee.llamada == 1)
            {
                txtruc.Text = frmprovee.rucito;
            }
        }
        DataTable Datos;
        private void txtruc_TextChanged(object sender, EventArgs e)
        {
            DataRow filita = CapaLogica.RUCProveedor(txtruc.Text);
            if (filita != null)
            {
                //si encuentro un proveedor
                txtRazonSocial.Text = filita["razon_social"].ToString();
                //Cargar Las Facturas por pagar de ese proveedor
                Datos = CapaLogica.ListarFacturasProveedor(txtruc.Text, PorPagar, tipo);

                if (Datos.Rows.Count > 0)
                {
                    cbofacturas.ValueMember = "descripcion";
                    cbofacturas.DisplayMember = "codigo";
                    cbofacturas.DataSource = Datos;
                    panelOre1.Enabled = true;
                    txtglosa.Text = txtglosa.TextoDefecto;
                }
                else
                {
                    cbofacturas.DataSource = null;
                    cbofacturas.Items.Clear(); txtmoneda.Text = "";
                    txtsubtotal.Text = txtigv.Text = txttotal.Text = txtsubtotalm.Text = txtigvm.Text = txttotalm.Text = "0.00";
                    txtglosa.Text = txtglosa.TextoDefecto;
                    panelOre1.Enabled = false;
                    btnaceptar.Enabled = false;
                }
            }
            else
            {// si no encuentro un provedor
                txtRazonSocial.Text = "";
                txtmoneda.Text = "";
                txtglosa.Text = txtglosa.TextoDefecto;
                Datos = new DataTable();
                cbofacturas.DataSource = null;
                cbofacturas.Items.Clear();
                txtsubtotal.Text = txtigv.Text = txttotal.Text = txtsubtotalm.Text = txtigvm.Text = txttotalm.Text = "0.00";
                panelOre1.Enabled = false;
                btnaceptar.Enabled = false;
                LimpiarTotales();
            }
        }
        public void LimpiarTotales()
        {
            txtsubtotal.Text = txtsubtotalm.Text = txtigv.Text = txtigvm.Text = txttotal.Text = txttotalm.Text = "0.00";
            txtglosa.Text = txtglosa.TextoDefecto;
        }
        public void ValidarNumeronotaCredito(string codigo, string numero)
        {
            //varias notas de credito
        }
        DataTable DatosFactura;
        private void cbofacturas_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbofacturas.SelectedIndex > 0)
            {
                txtmoneda.Text = cbofacturas.SelectedValue == null ? "" : cbofacturas.SelectedValue.ToString();
                if (((DataTable)cbofacturas.DataSource).Rows[cbofacturas.SelectedIndex]["T"].ToString() == "A")
                    btndetalle.Enabled = true;
                else btndetalle.Enabled = false;
                ///Buscar Datos de la Factura
                DatosFactura = CapaLogica.ListarFacturaProveedorNota(cbofacturas.Text, txtruc.Text, PorPagar);
                if (DatosFactura.Rows.Count > 0)
                {
                    txtsubtotalm.Text = txtsubtotal.Text = (DatosFactura.Rows[0])["subtotal"].ToString();
                    txtigvm.Text = txtigv.Text = (DatosFactura.Rows[0])["igv"].ToString();
                    txttotalm.Text = txttotal.Text = (DatosFactura.Rows[0])["total"].ToString();
                    DatosDetalle = CapaLogica.ListarFacturasNotas(cbofacturas.Text, txtruc.Text, "");
                    btnaceptar.Enabled = true;
                }
                else
                {
                    txtsubtotal.Text = txtigv.Text = txttotal.Text = txtsubtotalm.Text = txtigvm.Text = txttotalm.Text = "0.00";
                    btnaceptar.Enabled = false;
                    DatosDetalle = new DataTable();
                }
            }
            else
            {
                txtmoneda.Text = ""; btndetalle.Enabled = false; txtsubtotal.Text = txtigv.Text = txttotal.Text = txtsubtotalm.Text = txtigvm.Text = txttotalm.Text = "0.00";
                btnaceptar.Enabled = false;
                DatosDetalle = new DataTable();
            }
        }
        frmNotaCreditoDetalle frmnotacreditodet;
        DataTable DatosDetalle;
        private void btnagregar_Click(object sender, EventArgs e)
        {
            if (txtcodnota.Text == "") { msg($"Ingrese Código de {this.Text}"); txtcodnota.Focus(); return; }
            if (txtnronota.Text == "") { msg($"Ingrese Número de {this.Text}"); txtnronota.Focus(); return; }
            if (frmnotacreditodet == null)
            {
                frmnotacreditodet = new frmNotaCreditoDetalle();
                frmnotacreditodet.FormClosed += Frmnotacreditodet_FormClosed;
                frmnotacreditodet.Text = $"Detalle {cbotiponota.Text}  [{txtcodnota.Text}-{txtnronota.Text}]";
                frmnotacreditodet.DatosDetalle = DatosDetalle;
                //frmnotacreditodet.Parent = ParentForm;
                frmnotacreditodet.Show();
            }
            else
            {
                msg("La Ventana Ya está Abierta");
            }
        }
        private void Frmnotacreditodet_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmnotacreditodet = null;
            txttotalm.Text = DatosDetalle.Rows[DatosDetalle.Rows.Count - 1]["total"].ToString();
            txttotalm_Leave(sender, new EventArgs());
        }
        decimal porcentaje = 0, sub;
        private void txtsubtotalm_Leave(object sender, EventArgs e)
        {
            txtsubtotalm.Text = Convert.ToDecimal(txtsubtotalm.Text == "" ? "0" : txtsubtotalm.Text).ToString("n2");
            //modifica el subtotal
            porcentaje = Convert.ToDecimal(txtsubtotalm.Text) / Convert.ToDecimal(txtsubtotal.Text);
            txtigvm.Text = (Convert.ToDecimal(txtigv.Text) * porcentaje).ToString("n2");
            txttotalm.Text = (Convert.ToDecimal(txttotal.Text) * porcentaje).ToString("n2");
            AjustarModificacion();

        }
        private void txtigvm_Leave(object sender, EventArgs e)
        {
            txtigvm.Text = Convert.ToDecimal(txtigvm.Text == "" ? "0" : txtigvm.Text).ToString("n2");
            //modifica el igv
            porcentaje = Convert.ToDecimal(txtigvm.Text) / (Convert.ToDecimal(txtigv.Text) == 0 ? 1 : Convert.ToDecimal(txtigv.Text));
            txtsubtotalm.Text = (Convert.ToDecimal(txtsubtotal.Text) * porcentaje).ToString("n2");
            txttotalm.Text = (Convert.ToDecimal(txttotal.Text) * porcentaje).ToString("n2");
            AjustarModificacion();
        }
        private void txttotalm_Leave(object sender, EventArgs e)
        {
            txttotalm.Text = Convert.ToDecimal(txttotalm.Text == "" ? "0" : txttotalm.Text).ToString("n2");
            //modifica el total
            porcentaje = Convert.ToDecimal(txttotalm.Text) / Convert.ToDecimal(txttotal.Text);
            txtigvm.Text = (Convert.ToDecimal(txtigv.Text) * porcentaje).ToString("n2");
            txtsubtotalm.Text = (Convert.ToDecimal(txtsubtotal.Text) * porcentaje).ToString("n2");
            AjustarModificacion();
        }
        public void AjustarModificacion()
        {
            int con = 1;
            foreach (DataRow item in DatosDetalle.Rows)
                if (item["eliminar"].ToString() == "1" && item["descripcion"].ToString() != "Totales") con++;
            /////
            foreach (DataRow item in DatosDetalle.Rows)
            {
                if (item["descripcion"].ToString() != "Totales")
                {
                    if (item["eliminar"].ToString() == "0")
                    {
                        item["modificado"] = Convert.ToDecimal(item["subtotal"].ToString()) * con * porcentaje;
                        if ((int)item["codcompra"] == 2)
                            item["total"] = (int)item["cantidad"] * (decimal)item["modificado"] / 100;
                        else
                            item["total"] = (int)item["cantidad"] * (decimal)item["modificado"];
                    }
                }
            }
        }
        private void cbotiponota_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((int)cbotiponota.SelectedValue == 1)//nota crédito
            {
                lblnota.Text = "Nro N.Crédito:";
                this.Text = "Nota Crédito";
            }
            if ((int)cbotiponota.SelectedValue == 2)//nota débito
            {
                lblnota.Text = "Nro N.Débito:";
                this.Text = "Nota Débito";
            }
        }
        private void btnaceptar_Click(object sender, EventArgs e)
        {
            if (txtcodnota.Text == "") { msg($"Ingrese Código {this.Text}"); txtcodnota.Focus(); return; }
            if (txtnronota.Text == "") { msg($"Ingrese Número {this.Text}"); txtnronota.Focus(); return; }
            if (cbofacturas.Items.Count <= 0) { msg("No Hay Facturas"); return; }
            if (txtsubtotal.Text == "0.00") { msg("El Subtotal de La Factura está en Cero"); return; }
            if (txttotal.Text == "0.00") { msg("El Total de La Factura está en Cero"); return; }
            if (txtsubtotalm.Text == "0.00") { msg("El Subtotal Modificado de La Factura está en Cero"); txtsubtotalm.Focus(); return; }
            if (txttotalm.Text == "0.00") { msg("El Total Modificado de La Factura está en Cero"); txttotalm.Focus(); return; }
            if (txttotalm.Text == txttotal.Text) { msg("El Total Modificado Es Igual al Registrado"); txttotalm.Focus(); return; }
            //Verifico si no Existe la nota de credito
            if (CapaLogica.ListarNotaCredito(txtcodnota.Text + "-" + txtnronota, txtruc.Text, tipo).Rows.Count != 0) { msg($"La {this.Text} ya existe "); return; }
            //Guardando  INSERTAR opcion=1
            //CABECERA
            CapaLogica.NotaCredito(1, txtcodnota.Text, txtnronota.Text, cbofacturas.Text, tipo, txtruc.Text, Convert.ToDecimal(txtsubtotalm.Text), Convert.ToDecimal(txtigvm.Text), Convert.ToDecimal(txttotalm.Text), txtglosa.EstaLLeno() ? txtglosa.Text : "", frmLogin.CodigoUsuario);
            //DETALLE
            CapaLogica.NotaCreditoDetalleEliminar(txtcodnota.Text, txtnronota.Text, txtruc.Text, tipo);
            foreach (DataRow item in DatosDetalle.Rows)
            {
                //insertar opcion=1
                if (item["descripcion"].ToString() != "Totales")
                    CapaLogica.NotaCreditoDetalle(1, txtcodnota.Text, txtnronota.Text, txtruc.Text, tipo, (int)item["codcompra"], (int)item["cantidad"], (int)item["Id_Articulo"], (int)item["Id_Marca"], (int)item["Id_Modelo"], (decimal)item["Subtotal"], (decimal)item["modificado"], (decimal)item["Total"], (int)item["eliminar"], frmLogin.CodigoUsuario);
            }
            txtruc_TextChanged(sender, e);
            cbofacturas.SelectedIndex = -1;
            msgOK($"Insertado con Exito, La {this.Text}: {txtcodnota.Text}-{txtnronota.Text}");
            txtcodnota.Text = txtnronota.Text = "";


        }
    }
}
