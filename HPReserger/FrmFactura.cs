using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Imaging;

namespace HPReserger
{
    public partial class FrmFactura : Form
    {
        public FrmFactura()
        {
            InitializeComponent();
        }
        HPResergerCapaLogica.HPResergerCL cfactura = new HPResergerCapaLogica.HPResergerCL();
        private void FrmFactura_Load(object sender, EventArgs e)
        {
           // txtruc.Text = "0701046971";
            radioButton1.Checked = true;
            Dtguias.DataSource = cfactura.ListarFics(10, "", 0, 0);
            cbotipo.DisplayMember = "Desc_Tipo_compra";
            cbotipo.ValueMember = "Codigo_Tipo_Compra";
            cbotipo.DataSource = cfactura.ListarTipoPedido();
            imgfactura = null;
            dtfechaemision.Value = Dtfechaentregado.Value = DateTime.Now;
        }
        Decimal monto = 0.2m;
        public string nrofactura;
        public string proveedor;
        public int fic;
        public int tipo;
        public int gravaigv;
        public DateTime fechaemision;
        public int moneda;
        public byte[] imgfactura;
        MemoryStream _memoryStream = new MemoryStream();

        private void btnCargarFoto_Click(object sender, EventArgs e)
        {
            Openfd.ShowDialog();
            if (!string.IsNullOrWhiteSpace(Openfd.FileName))
            {
                txtfoto.Text = Openfd.FileName;
                _memoryStream.Position = 0;
                _memoryStream.SetLength(0);
                _memoryStream.Capacity = 0;
                pbfactura.Image = Image.FromFile(Openfd.FileName);
                pbfactura.Image.Save(_memoryStream, ImageFormat.Jpeg);
                imgfactura = File.ReadAllBytes(Openfd.FileName);
            }
            else
            {
                imgfactura = null;
                txtfoto.Text = "";
                pbfactura.Image = null;
            }

        }
        public void MostrarFoto(PictureBox fotito)
        {
            if (fotito.Image != null)
            {
                FrmFoto foto = new FrmFoto();
                foto.fotito = fotito.Image;
                foto.ShowDialog();
            }
        }
        private void txtruc_TextChanged(object sender, EventArgs e)
        {
            DataRow razonsocial = cfactura.RUCProveedor(txtruc.Text);
            if (razonsocial != null)
            {
                txtRazonSocial.Text = razonsocial["razon_social"].ToString();
                txtdireccion.Text = razonsocial["direccion_oficina"].ToString();
                txtTelefono.Text = razonsocial["telefono_oficina"].ToString();
                cargarguias(txtguia);//txtguia_TextChanged(sender, e);
            }
            else
            {
                txtRazonSocial.Text = txtdireccion.Text = txtTelefono.Text = "";
                chlbx.Items.Clear();
                txtguia.DataSource = null;
                Dtguias.DataSource = cfactura.ListarFics(10, "", 0, 0);
                DtgConten.DataSource = null;
                //Dtguias.Refresh();
                // DtgConten.Refresh();
            }
        }

        private void txtsubtotal_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtigv_TextChanged(object sender, EventArgs e)
        {
            txtsubtotal_TextChanged(sender, e);
        }

        private void txtsubtotal_KeyDown(object sender, KeyEventArgs e)
        {
            HPResergerFunciones.Utilitarios.ValidarDinero(e, txtsubtotal);
        }
        private void txtigv_KeyDown(object sender, KeyEventArgs e)
        {
            HPResergerFunciones.Utilitarios.ValidarDinero(e, txtigv);
        }
        private void txtsubtotal_KeyPress(object sender, KeyPressEventArgs e)
        {
            HPResergerFunciones.Utilitarios.SoloNumerosDecimales(e, txtsubtotal.Text);
        }
        private void txtigv_KeyPress(object sender, KeyPressEventArgs e)
        {

            HPResergerFunciones.Utilitarios.SoloNumerosDecimales(e, txtigv.Text);
        }
        private void txtruc_KeyDown(object sender, KeyEventArgs e)
        {
            HPResergerFunciones.Utilitarios.Validardocumentos(e, txtruc, 18);
        }

        private void txtguia_KeyPress(object sender, KeyPressEventArgs e)
        {
            HPResergerFunciones.Utilitarios.SoloNumerosEnteros(e);
        }

        private void txtruc_KeyPress(object sender, KeyPressEventArgs e)
        {
            HPResergerFunciones.Utilitarios.SoloNumerosEnteros(e);
        }
        public void cargarguias(ComboBox combito)
        {
            combito.DataSource = cfactura.ListarGuias(txtruc.Text, cbotipo.SelectedIndex, 0, 0);
            Dtguias.DataSource = cfactura.ListarFics(10, txtruc.Text, 0, 0);
            combito.DisplayMember = "VALOR";
            combito.ValueMember = "CODIGO";
            chlbx.Items.Clear();
            foreach (DataRowView items in combito.Items)
            {
                chlbx.Items.Add(items["valor"].ToString());
            }
        }
        public void cargarguiasporguia(ComboBox combito, int guia)
        {
            combito.DataSource = cfactura.ListarGuias(txtruc.Text, cbotipo.SelectedIndex, 1, guia);
            combito.DisplayMember = "VALOR";
            combito.ValueMember = "CODIGO";
            chlbx.Items.Clear();
            foreach (DataRowView items in combito.Items)
            {
                chlbx.Items.Add(items["valor"].ToString());
            }
        }
        private void cbotipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbotipo.SelectedValue.ToString() == "1")
            {
                lblguia.Text = "Guia Remisión:";

                //txtguia.Text = cbotipo.SelectedValue.ToString();
            }
            else
            {

                lblguia.Text = "Valoración:";
                // txtguia.Text = cbotipo.SelectedValue.ToString();
            }
            cargarguias(txtguia);
            //txtguia_TextChanged(sender, e);
        }
        Decimal subtotal = 0.3m;
        Decimal porcentaje = 0.3m;
        Decimal igv = 0.2m;
        Decimal total = 0.2m;
        private void cboigv_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtmonto.Text))
            {
                monto = Convert.ToDecimal(txtmonto.Text);
                porcentaje = numigv.Value;
                if (cboigv.SelectedIndex == 0)//si (incluido) valor index+1= 1
                {
                    numigv.Visible = true;
                    lblporcentaje.Visible = true;
                    txtsubtotal.Enabled = false;
                    txtmonto.Enabled = txtigv.Enabled = true;
                    subtotal = Decimal.Round(monto / ((100 + porcentaje) / 100), 2);
                    total = monto;
                    igv = total - subtotal;
                    txttotal.Text = total.ToString("N2");
                    txtsubtotal.Text = subtotal.ToString("N2");
                    txtigv.Text = igv.ToString("N2");

                    txttotal.Enabled = false;
                }
                if (cboigv.SelectedIndex == 1)//si (no incluido) valor index+1= 2
                {
                    numigv.Visible = true;
                    lblporcentaje.Visible = true;
                    txtsubtotal.Enabled = false;
                    txtmonto.Enabled = txtigv.Enabled = true;
                    igv = Decimal.Round(((monto * (porcentaje)) / 100), 2);
                    total = monto + igv;
                    txttotal.Text = total.ToString("N2");
                    txtigv.Text = igv.ToString("N2");
                    txtsubtotal.Text = monto.ToString("N2");

                    txttotal.Enabled = false;

                }
                if (cboigv.SelectedIndex == 2)//no valor index+1= 3
                {
                    numigv.Visible = false;
                    lblporcentaje.Visible = false;
                    txtsubtotal.Enabled = txtigv.Enabled = txttotal.Enabled = false;
                    total = monto;
                    txttotal.Text = total.ToString("N2");
                    porcentaje = igv = 0.2m;
                    txtsubtotal.Text = txtmonto.Text;
                    txtigv.Text = "0.00";

                    // txttotal.Enabled = true;
                }
            }
        }
        private void numigv_ValueChanged(object sender, EventArgs e)
        {
            cboigv_SelectedIndexChanged(sender, e);
        }

        private void btnmaspro_Click(object sender, EventArgs e)
        {
            frmproveedor provee = new frmproveedor();
            provee.btnnuevo_Click(sender, e);
            provee.ShowDialog();
            if (!string.IsNullOrWhiteSpace(provee.rucito))
            {
                txtruc.Text = provee.rucito;
            }
        }
        private void txtguia_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
        private void txtguia_TextChanged(object sender, EventArgs e)
        {
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (estado == 1)
            {
                btnaceptar.Enabled = false;
                gp1.Enabled = false;
                //gpordenes.Enabled = true;
                btnagregar.Enabled = true;
                txtruc.Enabled = true;// txtguia.Enabled = true;
                Dtguias.Enabled = true;
            }
            if (estado == 0)
            {
                this.Close();
            }
            estado = 0;
        }
        private void btnaceptar_Click(object sender, EventArgs e)
        {
            if (estado == 1 && validar())
            {
                for (int i = 0; i < Dtguias.RowCount; i++)
                {
                    if ((Boolean)Dtguias["OK", i].Value == true)
                        cfactura.InsertarFactura(txtnrofactura.Text, txtruc.Text, Convert.ToInt32(Dtguias["FIC", i].Value), Convert.ToInt32(Dtguias["OC", i].Value), 0,
                        Convert.ToDecimal(txtsubtotal.Text), Convert.ToDecimal(txtigv.Text), Convert.ToDecimal(txttotal.Text),
                        cboigv.SelectedIndex + 1, dtfechaemision.Value, Dtfechaentregado.Value, DtFechaRecepcion.Value, 1, 1, imgfactura, Convert.ToInt32(frmLogin.CodigoUsuario));
                }
                MSG("Factura Ingresada Exitosamente");
                button1_Click(sender, e);
                txtnrofactura.Text = ""; txtmonto.Text = ""; txtsubtotal.Text = txtigv.Text = txttotal.Text = ""; pbfactura.Image = null; imgfactura = null;
                txtruc.Text = ""; busqueda = 0;
                Dtguias.Enabled = true;

            }
        }
        private void pbfactura_DoubleClick(object sender, EventArgs e)
        {
            MostrarFoto(pbfactura);
        }
        public void MSG(string cadena)
        {
            MessageBox.Show(cadena, "Hp Reserger", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        int estado = 0;
        private void btnagregar_Click(object sender, EventArgs e)
        {
            gp1.Enabled = true;
            gpordenes.Enabled = false;
            btnaceptar.Enabled = true;
            estado = 1;
            btnagregar.Enabled = false;
            txtruc.Enabled = false; txtguia.Enabled = false;
            txtsubtotal.Enabled = txtigv.Enabled = false;
            Dtguias.Enabled = false;
        }
        public Boolean validar()
        {
            if (string.IsNullOrWhiteSpace(txtnrofactura.Text))
            {
                MSG("Ingresé Número de la Factura");
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtmonto.Text))
            {
                MSG("Ingresé Importe de la Factura");
                return false;
            }
            if (!string.IsNullOrWhiteSpace(txtnrofactura.Text))
            {
                DataRow factura = cfactura.BuscarFacturas(txtruc.Text, txtnrofactura.Text);
                if (factura != null)
                {
                    MSG("Nro Factura ya Existe");
                    return false;
                }
            }
            if ((dtfechaemision.Value > Dtfechaentregado.Value))
            {
                MSG("La Fecha de EMISION no puede ser menor que la de ENTREGA");
                return false;
            }

            if ((Dtfechaentregado.Value < dtfechaemision.Value))
            {
                MSG("La Fecha de ENTREGA no puede ser menor que la de EMISION");
                return false;
            }
            if (Convert.ToDecimal(txtmonto.Text) < 0)
            {
                MSG("El monto no puede ser menor igual cero");
                return false;
            }
            if (txtguia.Items.Count == chlbx.CheckedIndices.Count)
            {
                if (primermonto != Convert.ToDecimal(txttotal.Text) && unoovarios == 1)
                {
                    MSG("El TOTAL debe ser igual al saldo de la orden de compra");
                    return false;
                }
            }
            if (Convert.ToDecimal(txttotal.Text) > primermonto && unoovarios == 1)
            {
                MSG("El TOTAL No debe ser mayor que el TOTAL de la Orden");
                return false;
            }
            return true;
        }
        private void chlbx_Click(object sender, EventArgs e)
        {
        }
        decimal primermonto = 0;
        string cadenita; int busqueda = 0;
        private void chlbx_SelectedIndexChanged(object sender, EventArgs e)
        {/*
            if (chlbx.CheckedIndices.Count == 0 && unoovarios == 1)//lista las guias del proveedor que no se han registrado 
            {
                cargarguias(txtguia); busqueda = 0;
            }
            if (chlbx.CheckedIndices.Count == 1 && busqueda == 0 && unoovarios == 1)//lista todas las guias de proveedor que no se han registado y pertenecen a una orden de compra
            {
                var lista = chlbx.CheckedIndices;
                int valor;
                foreach (var recorrido in lista)
                {
                    busqueda = 1;
                    txtguia.SelectedIndex = Convert.ToInt32(recorrido);
                    cadenita = txtguia.SelectedValue.ToString();
                    valor = Convert.ToInt32(txtguia.SelectedValue.ToString());
                    cargarguiasporguia(txtguia, valor);
                    break;
                }
            }
            else
            {
                //busqueda = 0;
                var lista = chlbx.CheckedIndices;
                cadenita = "";
                foreach (var recorrido in lista)//saco las guias seleccionadas  de la lista
                {
                    txtguia.SelectedIndex = Convert.ToInt32(recorrido);
                    cadenita += txtguia.SelectedValue.ToString() + ",";

                }
                cadenita += "0";
                if (!string.IsNullOrWhiteSpace(txtguia.Text) && (!string.IsNullOrWhiteSpace(txtruc.Text)) && !string.IsNullOrWhiteSpace(cadenita))
                {
                    //Cargar Guias Seleccionadas
                    Dtguias.DataSource = cfactura.ListarFicsFila(2, txtruc.Text, cadenita, cbotipo.SelectedIndex);
                    if (Dtguias.RowCount > 0)
                    {
                        string BuscaMonto = "", BuscaFic = "";
                        for (int i = 0; i < Dtguias.RowCount; i++)
                        {
                            BuscaMonto += Dtguias["OC", i].Value.ToString() + ",";
                            BuscaFic += Dtguias["FIC", i].Value.ToString() + ",";
                        }
                        BuscaMonto += "0";
                        BuscaFic += "0";
                        DataRow BusMonto = cfactura.BuscarMontoDelasGuias(3, txtruc.Text, cadenita, 0);//monto
                        txtmonto.Text = BusMonto["monto"].ToString();
                        DtgConten.DataSource = cfactura.ListarFicsDetalle(BuscaFic);
                        cboigv.SelectedIndex = 0;
                        primermonto = monto = Convert.ToDecimal(txtmonto.Text);
                        DtgConten.Enabled = true;
                        gp1.Enabled = true;
                        txttotal.Enabled = false;
                        cboigv_SelectedIndexChanged(sender, e);
                        gp1.Enabled = false;
                        btnagregar.Enabled = true;
                    }
                    else
                    {
                        btnagregar.Enabled = false;
                        gp1.Enabled = false;
                        txttotal.Enabled = false;
                        DtgConten.Enabled = false;
                        txtmonto.Text = "";
                        txtsubtotal.Text = txtigv.Text = txttotal.Text = "";
                        DtgConten.DataSource = null;
                        gp1.Enabled = false;
                        txttotal.Enabled = false;
                        DtgConten.Enabled = false;
                        cboigv.SelectedIndex = -1; gp1.Enabled = false;
                    }
                }
                else
                {
                    txtsubtotal.Text = txtigv.Text = txttotal.Text = "";
                    // TXTFIC.Text = TXTOC.Text = TXTTIPO.Text = "";
                    DtgConten.DataSource = null;
                    gp1.Enabled = false;
                    txttotal.Enabled = false; gp1.Enabled = false;
                    DtgConten.Enabled = false;
                }
            }*/
        }
        private void chlbx_MouseLeave(object sender, EventArgs e)
        {
            chlbx.Visible = false;
            txtguia.Visible = true;
        }
        private void txtguia_MouseClick(object sender, MouseEventArgs e)
        {
            chlbx.Visible = true;
            txtguia.Visible = false;
        }
        private void lblporcentaje_Click(object sender, EventArgs e)
        {
        }
        int unoovarios;
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked) unoovarios = 1;
            cargarguias(txtguia); busqueda = 0;
            Dtguias.DataSource = null;
            txtruc_TextChanged(sender, e);
        }
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if ((radioButton2.Checked)) unoovarios = 0;
            Dtguias.DataSource = null;
            txtruc_TextChanged(sender, e);
        }
        private void txtmonto_KeyDown(object sender, KeyEventArgs e)
        {
            HPResergerFunciones.Utilitarios.ValidarDinero(e, txtmonto);
        }
        private void txtmonto_KeyPress(object sender, KeyPressEventArgs e)
        {
            HPResergerFunciones.Utilitarios.SoloNumerosDecimales(e, txtmonto.Text);
        }
        private void txtmonto_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtmonto.Text))
            {
                cboigv_SelectedIndexChanged(sender, e);
            }
            if ((!string.IsNullOrWhiteSpace(txtsubtotal.Text)) && (!string.IsNullOrWhiteSpace(txtigv.Text)))
            {
                txttotal.Text = (Convert.ToDouble(txtsubtotal.Text) + Convert.ToDouble(txtigv.Text)).ToString();
            }
        }
        private void gpordenes_Enter(object sender, EventArgs e)
        {

        }
        private void txtnrofactura_TextChanged(object sender, EventArgs e)
        {

        }
        private void dtfechaemision_ValueChanged(object sender, EventArgs e)
        {
            if ((dtfechaemision.Value > Dtfechaentregado.Value))
            {
                MSG("La Fecha de EMISION no puede ser menor que la de ENTREGA");
            }
        }
        private void Dtfechaentregado_ValueChanged(object sender, EventArgs e)
        {
            if ((Dtfechaentregado.Value < dtfechaemision.Value))
            {
                MSG("La Fecha de ENTREGA no puede ser menor que la de EMISION");
            }
        }
        private void txtmonto_DoubleClick(object sender, EventArgs e)
        {
            txtmonto.Text = primermonto.ToString();
        }
        private void txtnrofactura_Leave(object sender, EventArgs e)
        {
            //buscar si la factura ya existe en el sistema
            if (!string.IsNullOrWhiteSpace(txtnrofactura.Text))
            {
                DataRow factura = cfactura.BuscarFacturas(txtruc.Text, txtnrofactura.Text);
                if (factura != null)
                {
                    MSG("Nro Factura ya Existe");
                }
            }
        }

        private void Dtguias_RowEnter(object sender, DataGridViewCellEventArgs e)
        {

        }
        public int contador = 0;
        public void cargarFics()
        {
            contador = 0;
            if (Dtguias.RowCount > 0)
            {
                string BuscaMonto = "", BuscaFic = "";
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
                            BuscaMonto += lista.Cells["oc"].Value.ToString() + ","; contador++;
                            BuscaFic += lista.Cells["FIC"].Value.ToString() + ",";
                            break;
                        case "False":
                            break;
                    }
                }
                BuscaMonto += "0";
                BuscaFic += "0";
                DataRow BusMonto = cfactura.BuscarMontoDelasGuias(3, txtruc.Text, BuscaFic, 0);//monto
                //MSG(BuscaFic + " " + BuscaMonto+" " + BusMonto["MONTO"].ToString());
                txtmonto.Text = BusMonto["MONTO"].ToString();
                DtgConten.DataSource = cfactura.ListarFicsDetalle(BuscaFic);
                cboigv.SelectedIndex = 0;
                if (!string.IsNullOrWhiteSpace(txtmonto.Text))
                    primermonto = monto = Convert.ToDecimal(txtmonto.Text);
                else
                    primermonto = monto = 0.002m;
                DtgConten.Enabled = true;
                gp1.Enabled = true;
                txttotal.Enabled = false;
                cboigv_SelectedIndexChanged(null, null);
                gp1.Enabled = false;
            }
            else
            {
                gp1.Enabled = false;
                txttotal.Enabled = false;
                DtgConten.Enabled = false;
                txtmonto.Text = "";
                txtsubtotal.Text = txtigv.Text = txttotal.Text = "";
                DtgConten.DataSource = null;
                gp1.Enabled = false;
                txttotal.Enabled = false;
                DtgConten.Enabled = false;
                cboigv.SelectedIndex = -1; gp1.Enabled = false;
            }
            if (contador == 0)
                btnagregar.Enabled = false;
            else
                btnagregar.Enabled = true;
        }
        private void Dtguias_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Dtguias.EndEdit();
            cargarFics();
            /*
                        if (ch1.Value == null)
                            ch1.Value = false;
                        switch (ch1.Value.ToString())
                        {
                            case "True":
                                ch1.Value = false;
                                break;
                            case "False":
                                ch1.Value = true;
                                break;
                        }
                        MessageBox.Show(ch1.Value.ToString());*/
        }

        private void Dtguias_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
        }
    }
}
