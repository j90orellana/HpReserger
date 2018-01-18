using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HPReserger
{
    public partial class frmREciboPorHonorario : Form
    {
        public frmREciboPorHonorario()
        {
            InitializeComponent();
        }
        HPResergerCapaLogica.HPResergerCL cfactura = new HPResergerCapaLogica.HPResergerCL();
        private void txtruc_TextChanged(object sender, EventArgs e)
        {
            DataRow razonsocial = cfactura.RUCProveedor(txtruc.Text);
            if (razonsocial != null)
            {
                txtRazonSocial.Text = razonsocial["razon_social"].ToString();
                txtdireccion.Text = razonsocial["direccion_oficina"].ToString();
                txtTelefono.Text = razonsocial["telefono_oficina"].ToString();
                cargarguias();
            }
            else
            {
                txtRazonSocial.Text = txtdireccion.Text = txtTelefono.Text = "";
                Dtguias.DataSource = cfactura.ListarFics(10, "", 0, 0);
                DtgConten.DataSource = cfactura.ListarFicsDetalle("0,0");
                //DtgConten.DataSource=cfactura.
                //Dtguias.Refresh();
                // DtgConten.Refresh();
            }
        }

        private void btnmaspro_Click(object sender, EventArgs e)
        {
            frmproveedor provee = new frmproveedor();
            provee.txtnumeroidentidad.Text = txtruc.Text;
            provee.Txtbusca.Text = txtruc.Text;
            provee.radioButton2.Checked = true;
            provee.Txtbusca_TextChanged(sender, e);
            provee.llamada = 10;
            provee.ShowDialog();
            if (provee.llamada != 100)
                txtruc.Text = provee.rucito;
        }
        public void cargarguias()
        {
            // combito.DataSource = cfactura.ListarGuias(txtruc.Text, cbotipo.SelectedIndex, 0, 0);
            Dtguias.DataSource = cfactura.ListarFics(10, txtruc.Text, 0, 1);
            //  combito.DisplayMember = "VALOR";
            //  combito.ValueMember = "CODIGO";
            DtgConten.Refresh();
        }

        private void Dtguias_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Dtguias.EndEdit();
            cargarFics();
            cboigv_SelectedIndexChanged(sender, e);
        }

        public int contador = 0;
        public decimal primermonto = 0, monto = 0;
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

        private void pbfactura_DoubleClick(object sender, EventArgs e)
        {
            MostrarFoto(pbfactura);
        }
        public void MostrarFoto(PictureBox fotito)
        {
            if (fotito.Image != null)
            {
                FrmFoto foto = new FrmFoto($"Imagen de Recibo por Honorarios");
                foto.fotito = fotito.Image;
                foto.Owner = this.MdiParent;
                foto.ShowDialog();
            }
        }
        public void BuscarRenta()
        {
            Busqueda:
            DataRow BuscarIgv = cfactura.BuscarParametros("4ta", DateTime.Now);
            if (BuscarIgv != null)
            {
                numigv.Value = (decimal.Parse(BuscarIgv["valor"].ToString()) * 100);
            }
            else
            {
                MSG("No ha Ingresado el Valor Del Imp. Renta 4ta Categoría, Ingréselo en El Siguiente Formulario");
                frmParametros param = new frmParametros();
                param.ShowDialog();
                goto Busqueda;
            }
        }
        private void frmREciboPorHonorario_Load(object sender, EventArgs e)
        {
            //Application.CurrentCulture = System.Globalization.CultureInfo.CreateSpecificCulture("EN-US");
            // txtruc.Text = "0701046971";
            // radioButton1.Checked = true;
            Dtguias.DataSource = cfactura.ListarFics(10, "", 0, 0);
            imgfactura = null;
            dtfechaemision.Value = Dtfechaentregado.Value = DateTime.Now;
            cbotipo.SelectedIndex = 0;
            BuscarRenta();
        }
        int estado = 0;
        private void btnagregar_Click(object sender, EventArgs e)
        {
            cbotipo.Enabled = false;
            gp1.Enabled = true;
            btnaceptar.Enabled = true;
            estado = 1;
            btnagregar.Enabled = false;
            txtruc.Enabled = false;
            txtsubtotal.Enabled = txtigv.Enabled = false;
            Dtguias.Enabled = false;
        }

        private void DtgConten_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(DtgConten[e.ColumnIndex, e.RowIndex].Value.ToString()))
                DtgConten[e.ColumnIndex, e.RowIndex].Value = "0.00";
            Calculando();
        }
        public void Calculando()
        {
            if (DtgConten.RowCount > 0)
            {
                decimal X = 0, sumatoria = 0, igvigv = 0, subtotales = 0;
                if (cboigv.SelectedIndex == 0)
                {
                    for (int i = 0; i < DtgConten.RowCount; i++)
                    {
                        X = (decimal.Parse(DtgConten["cantidad", i].Value.ToString().Substring(0, DtgConten["cantidad", i].Value.ToString().Length - 1)) / 100) * decimal.Parse(DtgConten["PRECIOUNIT", i].Value.ToString());
                        DtgConten["SUBTOTALE", i].Value = decimal.Round(X, 2);
                        igvigv = 0;
                        DtgConten["valueigv", i].Value = decimal.Round(igvigv, 2);
                        X += igvigv;
                        sumatoria += (X);
                        DtgConten["totalfac", i].Value = decimal.Round(X, 2);
                    }

                }
                if (cboigv.SelectedIndex == 1)
                {
                    for (int i = 0; i < DtgConten.RowCount; i++)
                    {
                        X = (decimal.Parse(DtgConten["cantidad", i].Value.ToString().Substring(0, (DtgConten["cantidad", i].Value.ToString().Length - 1))) / 100) * decimal.Parse(DtgConten["PRECIOUNIT", i].Value.ToString());
                        DtgConten["totalfac", i].Value = decimal.Round(X, 2);
                        subtotales = X / (1 + (numigv.Value / 100));
                        igvigv = X - subtotales;
                        //subtotales = X - igvigv;
                        DtgConten["valueigv", i].Value = decimal.Round(igvigv, 2);
                        sumatoria += (X);
                        DtgConten["subtotale", i].Value = decimal.Round(subtotales, 2);
                    }
                }
                txtmonto.Text = sumatoria.ToString("n2");
            }
        }
        TextBox txt;
        private void DtgConten_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            txt = e.Control as TextBox;
            if (txt != null)
            {
                txt.KeyPress -= new KeyPressEventHandler(dataGridview_KeyPressCajita);
                txt.KeyPress += new KeyPressEventHandler(dataGridview_KeyPressCajita);
            }
        }
        private void dataGridview_KeyPressCajita(object sender, KeyPressEventArgs e)
        {
            HPResergerFunciones.Utilitarios.SoloNumerosDecimales(e, txt.Text);
        }

        private void DtgConten_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                DtgConten.EndEdit();
            }
            else { e.Handled = true; }
        }

        private void DtgConten_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            DtgConten[e.ColumnIndex, e.RowIndex].Value = "0.00";
        }
        decimal porcentaje, subtotal, total, igv;
        public void MSG(string cadena)
        {
            MessageBox.Show(cadena, "Hp Reserger", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public Boolean validar()
        {
            if (string.IsNullOrWhiteSpace(txtnrofactura.Text))
            {
                MSG("Ingresé Número del Recibo");
                txtnrofactura.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtmonto.Text))
            {
                MSG("Ingresé Importe del Recibo");
                return false;
            }
            if (!string.IsNullOrWhiteSpace(txtnrofactura.Text))
            {
                DataRow factura = cfactura.BuscarFacturas(txtruc.Text, txtnrofactura.Text);
                if (factura != null)
                {
                    MSG("Nro de Recibo ya Existe");
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

            /*  if (Convert.ToDecimal(txttotal.Text) > primermonto && unoovarios == 1)
              {
                  MSG("El TOTAL No debe ser mayor que el TOTAL de la Orden"+txttotal.Text+":"+primermonto.ToString());
                  return false;
              }*/
            for (int i = 0; i < DtgConten.RowCount; i++)
            {
                if (decimal.Parse(DtgConten["preciounit", i].Value.ToString()) <= 0)
                {
                    MSG("Ingresé Precio Unitario de la fila " + (i + 1));
                    DtgConten.CurrentCell = DtgConten["preciounit", i];
                    return false;
                }
            }

            return true;
        }
        private void btnaceptar_Click(object sender, EventArgs e)
        {
            if (estado == 1 && validar())
            {
                int next;
                DataRow siguiente = cfactura.Siguiente("TBL_Asiento_Contable", "Id_Asiento_Contable");
                next = int.Parse(siguiente["valor"].ToString());
                for (int i = 0; i < DtgConten.RowCount; i++)
                {
                    decimal valorigv = 0, valorsubtotal = 0, valortotal = 0;
                    valorsubtotal = (Convert.ToDecimal(DtgConten["subtotale", i].Value));
                    valorigv = (Convert.ToDecimal(DtgConten["valueigv", i].Value));
                    valortotal = (Convert.ToDecimal(DtgConten["TOTALFAC", i].Value));
                    //grabando
                    cfactura.InsertarFactura(txtnrofactura.Text, txtruc.Text, Convert.ToInt32(DtgConten["numFIC", i].Value), Convert.ToInt32(DtgConten["numOC", i].Value), 1,
                      valorsubtotal, valorigv, valortotal,
                         cboigv.SelectedIndex + 1, dtfechaemision.Value, Dtfechaentregado.Value, DtFechaRecepcion.Value, 1, 1, imgfactura, Convert.ToInt32(frmLogin.CodigoUsuario), 0, 0);
                    ///////////////////////
                    ///Dinamica Contable///
                    ///////////////////////                    
                    cfactura.InsertarAsientoRecibo(next, 1, Convert.ToInt32(DtgConten["numOC", i].Value.ToString()), valorsubtotal, 0, 0, DtgConten["cc", i].Value.ToString(), txtnrofactura.Text);
                    cfactura.InsertarAsientoRecibo(next, 2, Convert.ToInt32(DtgConten["numOC", i].Value.ToString()), valorsubtotal, valorigv, valortotal, DtgConten["cc", i].Value.ToString(), txtnrofactura.Text);
                    ///////////////////////
                    ///Dinamica Contable///
                    ///////////////////////  
                }
                MSG("Recibo por Honorario Ingresado Exitosamente");
                btncancelar_Click(sender, e);
                txtnrofactura.Text = ""; txtmonto.Text = ""; txtsubtotal.Text = txtigv.Text = txttotal.Text = ""; pbfactura.Image = null; imgfactura = null;
                txtruc.Text = "";
                Dtguias.Enabled = true;
            }
        }

        private void Dtguias_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btndescargar_MouseMove(object sender, MouseEventArgs e)
        {
            if (pbfactura.Image != null)
                btndescargar.Visible = true;
        }

        private void pbfactura_MouseMove(object sender, MouseEventArgs e)
        {
            if (pbfactura.Image != null)
                btndescargar.Visible = true;
        }

        private void gp1_Move(object sender, EventArgs e)
        {
            btndescargar.Visible = false;
        }

        private void btndescargar_Click(object sender, EventArgs e)
        {
            HPResergerFunciones.Utilitarios.DescargarImagen(pbfactura);
        }

        private void btncancelar_Click(object sender, EventArgs e)
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

        private void txtmonto_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtmonto.Text))
                txttotal.Text = txtsubtotal.Text = txtigv.Text = "0.00";
            if (!string.IsNullOrWhiteSpace(txtmonto.Text))
            {
                cboigv_SelectedIndexChanged(sender, e);
            }
            if ((!string.IsNullOrWhiteSpace(txtsubtotal.Text)) && (!string.IsNullOrWhiteSpace(txtigv.Text)))
            {
                txttotal.Text = (Convert.ToDouble(txtsubtotal.Text) + Convert.ToDouble(txtigv.Text)).ToString();
            }
        }

        private void cboigv_SelectedIndexChanged(object sender, EventArgs e)
        {
            Calculando();
            if (!string.IsNullOrEmpty(txtmonto.Text))
            {
                monto = Convert.ToDecimal(txtmonto.Text);
                porcentaje = numigv.Value;
                if (cboigv.SelectedIndex == 1)//si (incluido) valor index+1= 1
                {
                    numigv.Visible = true;
                    lblporcentaje.Visible = true;
                    txtsubtotal.Enabled = false;
                    ///txtmonto.Enabled = txtigv.Enabled = true;
                    igv = Decimal.Round((monto * porcentaje / 100), 2);
                    total = monto;
                    subtotal = total - igv;
                    txttotal.Text = total.ToString("N2");
                    txtsubtotal.Text = subtotal.ToString("N2");
                    txtigv.Text = igv.ToString("N2");

                    txttotal.Enabled = false;
                }

                if (cboigv.SelectedIndex == 0)//no valor index+1= 3
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
                            BuscaFic += lista.Cells["FIC1"].Value.ToString() + ",";
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
                DtgConten.DataSource = cfactura.ListarFicsDetalleservicio(BuscaFic);
                cboigv.SelectedIndex = 0;
                if (!string.IsNullOrWhiteSpace(txtmonto.Text))
                    primermonto = monto = Convert.ToDecimal(txtmonto.Text);
                else
                    primermonto = monto = 0.002m;
                DtgConten.Enabled = true;
                gp1.Enabled = true;
                txttotal.Enabled = false;
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
            {
                btnagregar.Enabled = false;
                btnmaspro.Enabled = true;
                cbotipo.Enabled = true;
            }
            else
            {
                btnagregar.Enabled = true;
                btnmaspro.Enabled = false;
                cbotipo.Enabled = false;

            }
        }
    }
}
