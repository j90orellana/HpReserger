using HpResergerUserControls;
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
    public partial class FrmFacturaManual : FormGradient
    {
        public FrmFacturaManual()
        {
            InitializeComponent();
        }
        public void msgError(string cadena) { HPResergerFunciones.frmInformativo.MostrarDialogError(cadena); }
        public void msgOK(string cadena) { HPResergerFunciones.frmInformativo.MostrarDialog(cadena); }
        HPResergerCapaDatos.HPResergerCD CapaDatos = new HPResergerCapaDatos.HPResergerCD();
        HPResergerCapaLogica.HPResergerCL CapaLogica = new HPResergerCapaLogica.HPResergerCL();
        public int _PlazoPago { get; set; }
        public int _idempresa { get; set; }
        public int Estado { get; set; }
        public object _proyecto { get; set; }
        public int _etapa { get; set; }
        public string coddet { get; set; }
        public int _idFac { get; private set; }
        public decimal TotalIgv { get; private set; }
        public string OldCuo { get; private set; }
        public int OldEmpresa { get; private set; }
        public int OldProyecto { get; private set; }
        public DateTime OldFechaContable { get; private set; }
        public int OldId { get; private set; }
        public string OldNumFac { get; private set; }
        public string OldProveedor { get; private set; }
        public int OldIdComprobante { get; private set; }
        public int OldIdComprobanteSelect { get; private set; }
        public int NotasEstado { get; private set; }
        public decimal igvs { get; private set; }
        public int ActivoFijo { get; private set; }

        private void FrmFacturaManual_Load(object sender, EventArgs e)
        {
            Estado = 0; _idempresa = 0; _proyecto = 0; _etapa = 0; coddet = "";
            CargarCombitoTipoid();
            CargarMoneda(); CargarTipoComprobante(); CargarDetracciones(); CargarEmpresa(); CargarCompensaciones();
            CargarTablasDefecto();
            dtpfechaemision.Value = dtpfecharecep.Value = DateTime.Now;
            cbodetraccion.Text = "NO";
            cbograba.SelectedIndex = 0;
            ModoEdicion(false);
            LimpiarBusquedas();
            CargarDatos();
        }
        public void CargarCompensaciones()
        {
            DataTable ListCompensaciones = new DataTable();
            ListCompensaciones.Columns.Add("codigo", typeof(int));
            ListCompensaciones.Columns.Add("descripcion");
            ListCompensaciones.Rows.Add(0, "Ninguno");
            ListCompensaciones.Rows.Add(1, "Fondo Fijo");
            ListCompensaciones.Rows.Add(2, "Reembolso Gasto");
            ListCompensaciones.Rows.Add(3, "Entregas a Rendir");
            ListCompensaciones.Rows.Add(4, "Anticipo Proveedor");
            cbocompensa.ValueMember = "codigo";
            cbocompensa.DisplayMember = "descripcion";
            cbocompensa.DataSource = ListCompensaciones;
            cbocompensa.SelectedIndex = 0;
        }
        public void CargarCombitoTipoid()
        {
            cbotipoidcompensa.ValueMember = "codigo";
            cbotipoidcompensa.DisplayMember = "valor";
            cbotipoidcompensa.DataSource = CapaLogica.TiposID(0, 0, "", 0);
        }
        DataTable TContenendor;
        public void CargarDatos()
        {
            dtgBusqueda.DataSource = CapaLogica.FacturaManualBusqueda(txtbusproveedor.TextValido(), txtbusnrodoc.TextValido(), txtbuscaempresa.TextValido(), txtBusTipoDoc.TextValido());
            btnmodificar.Enabled = false;
            if (dtgBusqueda.RowCount > 0) btnmodificar.Enabled = true;
            else
            {
                TContenendor = CapaLogica.FacturaManualDetalleBusqueda("", "", 0);
                Dtgconten.DataSource = TContenendor;
                Limpiar();
            }
            DataRow Filon = CapaLogica.FacturaManualBusquedaContadas();
            lblcontador.Text = $"Listado de Facturas Registradas: { dtgBusqueda.RowCount} / {Filon[0]} ";
        }
        DataTable TFacReferencia = new DataTable();
        DataTable TFacRefDetalle = new DataTable();
        public void BusquedaDocReferencia()
        {
            btnaplicar.Enabled = false;
            Encontrado = 0;
            ////Busqueda de Referencias
            if ((_TipoDoc == 2 || _TipoDoc == 3) && (Estado == 2 || Estado == 1))
            {
                string NumDocRef = txtSerieRef.Text + "-" + txtNumRef.Text;
                TFacReferencia = CapaLogica.BuscarFacturasManualesToNcNd(txtruc.Text, NumDocRef);
                if (TFacReferencia.Rows.Count > 0)
                {
                    DataRow Fila = TFacReferencia.Rows[0];
                    cbomoneda.SelectedValue = Fila["moneda"];
                    txttipocambio.Text = ((decimal)Fila["tc"]).ToString("n3");
                    cboempresa.SelectedValue = Fila["empresa"];
                    cboproyecto.SelectedValue = Fila["Proyecto"];
                    cboetapa.SelectedValue = Fila["etapa"];
                    btnaplicar.Enabled = true;
                    Encontrado = 1;
                }
            }
        }
        int Encontrado = 0;
        public void ModoEdicion(Boolean a)
        {
            ////combobox
            cboempresa.Enabled = cboproyecto.Enabled = cboetapa.Enabled = cbodetraccion.Enabled = cbograba.Enabled = cbomoneda.Enabled = cbotipodoc.Enabled = a;
            ///textbox user
            txtrenta.ReadOnly = txtruc.ReadOnly = txttipocambio.ReadOnly = txttotalfac.ReadOnly = txtnrofactura.ReadOnly = txtcodfactura.ReadOnly = txtglosa.ReadOnly = !a;
            ///Botones
            btnCargarFoto.Enabled = btnbusproveedor.Enabled = btnAdd.Enabled = btnlimpiar.Enabled = a;
            ////checkbox DESACTIVADO POR EL MOMENTO
            //cbocompensa.Enabled = false;
            cbocompensa.Enabled = a;// btnbususuacompesa.Enabled = a;
            ///datetimepicker
            dtpFechaContable.Enabled = dtpfechaemision.Enabled = dtpfecharecep.Enabled = dtpfechavence.Enabled = a;
            ///////////////////
            btnActualizar.Enabled = btncleanfind.Enabled = !a;
            txtBusTipoDoc.ReadOnly = txtbusnrodoc.ReadOnly = txtbuscaempresa.ReadOnly = txtbusproveedor.ReadOnly = a;
            dtgBusqueda.Enabled = !a; Dtgconten.ReadOnly = !a;
            btnnuevo.Enabled = !a; btnmodificar.Enabled = !a;
            btnmasdetracion.Enabled = !a;
            //Cargar Masica
            btnCargar.Enabled = !a;
            btnFormato.Enabled = !a;
            ////
            txtNumRef.ReadOnly = txtSerieRef.ReadOnly = a;
            chkActivoFijo.Enabled = a;
            chkfac.Enabled = !a;
            chkQuitarDetraccionaFactura.Enabled = a;

            NumIGV.Enabled = false;
            chkIGV.Enabled = a;
        }
        DataTable TDebeHaber;
        DataTable TGrava;
        public void CargarTablasDefecto()
        {
            ///Tabla Debe Haber
            TDebeHaber = new DataTable();
            TDebeHaber.Columns.Add("codigo");
            TDebeHaber.Columns.Add("Descripcion");
            TDebeHaber.Rows.Add("D", "Debe");
            TDebeHaber.Rows.Add("H", "Haber");
            ///Graba
            TGrava = new DataTable();
            TGrava.Columns.Add("codigo", typeof(int));
            TGrava.Columns.Add("descripcion");
            TGrava.Rows.Add(1, "IGV");
            TGrava.Rows.Add(2, "GNG");
            TGrava.Rows.Add(3, "ONG");
            TGrava.Rows.Add(4, "NGR");
        }
        public void CargarEmpresa()
        {
            CapaLogica.TablaEmpresas(cboempresa);
        }
        public void CargarMoneda()
        {
            CapaLogica.TablaMoneda(cbomoneda);
        }
        public void CargarTipoComprobante()
        {
            CapaLogica.TablaComprobantesConCodigo(cbotipodoc);
        }
        private void txtcodfactura_Leave(object sender, EventArgs e)
        {
            HPResergerFunciones.Utilitarios.AjustarTexto(txtcodfactura, 4);
            txtnrofactura_Leave(sender, e);
        }
        private void txtcodfactura_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '-' || e.KeyChar == '-')
            {
                e.Handled = true;
                txtnrofactura.Focus();
            }
        }
        private void txtnrofactura_Leave(object sender, EventArgs e)
        {
            HPResergerFunciones.Utilitarios.AjustarTexto(txtnrofactura, 15);
            //buscar si la factura ya existe en el sistema
            //if (!string.IsNullOrWhiteSpace(txtnrofactura.Text))
            //{
            //    DataRow factura = CapaLogica.BuscarFacturas(txtruc.Text, $"{txtcodfactura.Text}-{txtnrofactura.Text}");
            //    if (factura != null)
            //    {
            //        Msg("Nro Factura ya Existe");
            //    }
            //}
        }
        public DialogResult MsgAceptCancel(string cadena)
        {
            return HPResergerFunciones.Utilitarios.MsgAcceptCancel(cadena);
        }
        private void txtnrofactura_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Back)
                if (txtnrofactura.Text.Length == 0)
                    txtcodfactura.Focus();
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            dtpfechavence.Value = dtpfecharecep.Value.AddDays(_PlazoPago);
        }

        private void btnbusproveedor_Click(object sender, EventArgs e)
        {
            frmproveedor provee = new frmproveedor();
            provee.txtnumeroidentidad.Text = txtruc.Text;
            provee.Txtbusca.Text = txtruc.TextValido();
            provee.radioButton2.Checked = true;
            provee.Txtbusca_TextChanged(sender, e);
            provee.llamada = 10;
            provee.ShowDialog();
            if (provee.llamada != 100)
                txtruc.Text = provee.rucito;
        }

        private void txtruc_TextChanged(object sender, EventArgs e)
        {
            DataRow DatosEmpresa = CapaLogica.RUCProveedor(txtruc.Text);
            if (DatosEmpresa != null)
            {
                txtrazon.Text = DatosEmpresa["razon_social"].ToString();
                _PlazoPago = int.Parse(DatosEmpresa["plazo"].ToString());
                dtpfechavence.Value = dtpfecharecep.Value.AddDays(_PlazoPago);
            }
            else
            {
                _PlazoPago = 30;
                txtrazon.CargarTextoporDefecto();
                dtpfechavence.Value = dtpfecharecep.Value.AddDays(_PlazoPago);
            }
            if (Estado == 1 || Estado == 2) BusquedaDocReferencia();
        }
        frmTipodeCambio frmtipo;
        public void SacarTipoCambio()
        {
            DateTime FechaValidaBuscar = dtpfechaemision.Value;
            txttipocambio.Text = CapaLogica.TipoCambioDia("Venta", FechaValidaBuscar).ToString("n3");
            if (decimal.Parse(txttipocambio.Text) == 0)
            {
                if (frmtipo == null)
                {
                    frmtipo = new frmTipodeCambio();
                    //frmtipo.ActualizoTipoCambio += Frmtipo_ActualizoTipoCambio;
                    frmtipo.Show();
                    frmtipo.Hide();
                    frmtipo.comboMesAño1.ActualizarMesAÑo(FechaValidaBuscar.Month.ToString(), FechaValidaBuscar.Year.ToString());
                    frmtipo.Buscar_Click(new object(), new EventArgs());
                }
            }
        }
        private void Frmtipo_ActualizoTipoCambio(object sender, EventArgs e)
        {
            frmtipo.Close();
            frmtipo = null;
            SacarTipoCambio();
        }
        private void dtpfechaemision_ValueChanged(object sender, EventArgs e)
        {
            if (_TipoDoc != 2 && _TipoDoc != 3)
                SacarTipoCambio();
            if (Dtgconten.RowCount > 0) btnAceptar.Enabled = false;
            igvs = (decimal)(CapaLogica.ValorIGVactual(dtpfechaemision.Value))["Valor"];
            NumIGV.Value = igvs * 100;
        }
        public byte[] imgfactura;
        MemoryStream _memoryStream = new MemoryStream();
        private void btnCargarFoto_Click(object sender, EventArgs e)
        {
            if (Openfd.ShowDialog() == DialogResult.OK)
                if (!string.IsNullOrWhiteSpace(Openfd.FileName))
                {
                    _memoryStream.Position = 0;
                    _memoryStream.SetLength(0);
                    _memoryStream.Capacity = 0;
                    frmimagen.Imagen = Image.FromFile(Openfd.FileName);
                    frmimagen.Imagen.Save(_memoryStream, ImageFormat.Jpeg);
                    imgfactura = File.ReadAllBytes(Openfd.FileName);
                }
                else
                {
                    imgfactura = null;
                    frmimagen.Imagen = null;
                }
        }
        private void frmimagen_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }

        private void frmimagen_DragDrop(object sender, DragEventArgs e)
        {
            string[] strDragDrop = (string[])e.Data.GetData(DataFormats.FileDrop);
            foreach (string file in strDragDrop)
                try
                {
                    frmimagen.Imagen = Bitmap.FromFile(file);
                    imgfactura = File.ReadAllBytes(file);
                }
                catch (Exception) { }
        }
        public void OcultarDetraccion(Boolean a)
        {
            //lblporcentajedetraccion.Enabled = a;
            numdetraccion.Enabled = a;
            //txtdetraccion.Enabled = a;
        }
        DataTable DatosDetracciones;
        public void CargarDetracciones()
        {
            DatosDetracciones = new DataTable();
            DatosDetracciones = CapaLogica.Detraciones(0);
            DataRow filita = DatosDetracciones.NewRow();
            filita["Desc_Detraccion"] = "NO";
            filita["Porcentaje"] = 0.00;
            DatosDetracciones.Rows.InsertAt(filita, 0);
        }
        private void Cbodetraccion_Click(object sender, EventArgs e)
        {
            string cadena = cbodetraccion.Text;
            CargarDetracciones();
            cbodetraccion.Text = cadena;
        }
        string detrac = "";
        decimal detracion = 0;
        private void cbodetraccion_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbodetraccion.Text != "NO")
            {
                detracion = 0;
                OcultarDetraccion(true);
                txtdescdetraccion.Text = detrac;
                string filtro = $"Desc_Detraccion ='{txtdescdetraccion.Text}'";
                DataRow[] filaS = DatosDetracciones.Select(filtro);
                if (filaS.Count() != 0)
                {
                    txtdescdetraccion.Text = filaS[0]["Desc_Detraccion"].ToString();
                    coddet = filaS[0]["Cod_Detraccion"].ToString();
                    //numdetraccion.Value = cbodetraccion.SelectedValue == null ? 0.0m : (decimal)cbodetraccion.SelectedValue;
                    numdetraccion.Value = Convert.ToDecimal(filaS[0]["Porcentaje"].ToString());
                    if (!string.IsNullOrWhiteSpace(txttotalfac.Text))
                        if ((int)cbomoneda.SelectedValue == 1)
                        {
                            decimal valor = decimal.Parse(txttotalfac.Text.ToString()) * (numdetraccion.Value / 100);
                            if (valor < 1) detracion = 1;
                            else
                                detracion = Math.Round(decimal.Parse(txttotalfac.Text.ToString()) * (numdetraccion.Value / 100), 0);
                        }
                        else
                            detracion = decimal.Parse(txttotalfac.Text.ToString()) * (numdetraccion.Value / 100);
                    numdetraccion.Enabled = false;
                    if (Estado == 1 || Estado == 2 || Estado == 10)
                        btnmasdetracion.Enabled = true;
                    else btnmasdetracion.Enabled = false;
                    txtmontodetraccion.Text = detracion.ToString("n2");
                }
                else
                {
                    filtro = $"cod_detraccion ='{CodDetracciones}'";
                    filaS = DatosDetracciones.Select(filtro);
                    if (filaS.Count() != 0)
                    {
                        txtdescdetraccion.Text = filaS[0]["Desc_Detraccion"].ToString();
                        coddet = filaS[0]["Cod_Detraccion"].ToString();
                        //numdetraccion.Value = cbodetraccion.SelectedValue == null ? 0.0m : (decimal)cbodetraccion.SelectedValue;
                        numdetraccion.Value = Convert.ToDecimal(filaS[0]["Porcentaje"].ToString());
                        if (!string.IsNullOrWhiteSpace(txttotalfac.Text))
                            if ((int)cbomoneda.SelectedValue == 1)
                            {
                                decimal valor = decimal.Parse(txttotalfac.Text.ToString()) * (numdetraccion.Value / 100);
                                if (valor < 1) detracion = 1;
                                else
                                    detracion = Math.Round(decimal.Parse(txttotalfac.Text.ToString()) * (numdetraccion.Value / 100), 0);
                            }
                            else
                                detracion = decimal.Parse(txttotalfac.Text.ToString()) * (numdetraccion.Value / 100);
                    }
                    numdetraccion.Enabled = false;
                    if (Estado == 1 || Estado == 2 || Estado == 10)
                        btnmasdetracion.Enabled = true;
                    else btnmasdetracion.Enabled = false;
                    txtmontodetraccion.Text = detracion.ToString("n2");
                }
            }
            else
            {
                OcultarDetraccion(false);
                btnmasdetracion.Enabled = false;
                numdetraccion.Value = 0;
                txtdescdetraccion.Text = "NO";
                txtmontodetraccion.Text = "0.00";
            }
            if (Dtgconten.RowCount > 0) btnAceptar.Enabled = false;
            txtmontodetraccion.Text = (decimal.Parse(txtmontodetraccion.Text)).ToString(txtmontodetraccion.Format);
        }
        string CodDetracciones = "";
        frmdetracciones frdetracion;
        private void btnmasdetracion_Click(object sender, EventArgs e)
        {
            frdetracion = new frmdetracciones();
            frdetracion.FormClosed += Frdetracion_FormClosed;
            frdetracion.BuscarValor = true; frdetracion.detraccion = txtdescdetraccion.Text;
            frdetracion.btnaceptar.Enabled = true;
            frdetracion.AcceptButton = frdetracion.btnaceptar;
            frdetracion.ShowDialog();
        }
        private void Frdetracion_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (!frdetracion.BuscarValor)
            {
                detrac = txtdescdetraccion.Text = frdetracion.detraccion;
                CargarDetracciones();
                cbodetraccion_SelectedIndexChanged(sender, e);
            }
        }
        private void cboempresa_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboempresa.Items.Count > 0)
            {
                if (cboempresa.SelectedValue != null)
                {
                    cboproyecto.DataSource = CapaLogica.ListarProyectosEmpresa(cboempresa.SelectedValue.ToString());
                    cboproyecto.DisplayMember = "proyecto";
                    cboproyecto.ValueMember = "id_proyecto";
                    //busqueda de Asientos
                    _idempresa = (int)cboempresa.SelectedValue;
                    //if (estado == 0)
                    //{
                    //    txtcodigo.Text = "0";
                    //    txttotaldebe.Text = txttotalhaber.Text = txtdiferencia.Text = "0.00";
                    //    Txtbusca_TextChanged(sender, e);
                    //}
                    //if (estado == 1)
                    //{
                    //    ultimoasiento();
                    //    txtcodigo.Text = (codigo).ToString();
                    //}
                }
            }
            else msgError("No hay Empresas");
        }
        private void cboproyecto_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboproyecto.SelectedIndex >= 0)
            {
                DataRowView itemsito = (DataRowView)cboproyecto.Items[cboproyecto.SelectedIndex];
                cboetapa.DataSource = CapaLogica.ListarEtapasProyecto((itemsito["id_proyecto"].ToString()));
                cboetapa.ValueMember = "id_etapa";
                cboetapa.DisplayMember = "descripcion";
                _proyecto = (int)itemsito["id_proyecto"];
            }
            else msgError("No Hay Proyectos");
        }
        public void CalcularDiferenciaTOtalDetra()
        {
            txtDifDetra.Text = (decimal.Parse(txttotalfac.Text == "" ? "0" : txttotalfac.Text) - decimal.Parse(txtmontodetraccion.Text)).ToString("n2");
        }
        private void txttotalfac_TextChanged(object sender, EventArgs e)
        {
            decimal resul = 0;
            decimal.TryParse(txttotalfac.Text, out resul);
            if (cbodetraccion.Text == "SI")
            {
                if ((int)cbomoneda.SelectedValue == 1)
                {
                    decimal valor = resul * (numdetraccion.Value / 100);
                    if (valor < 1) detracion = 1;
                    else
                        detracion = Math.Round(resul * (numdetraccion.Value / 100), 1);
                    txtmontodetraccion.Text = detracion.ToString("N0");

                }
                else
                {
                    detracion = resul * (numdetraccion.Value / 100);
                    txtmontodetraccion.Text = detracion.ToString("N2");
                }
            }
            else txtDifDetra.Text = txttotalfac.Text;
            if (Dtgconten.RowCount > 0) btnAceptar.Enabled = false;
            CalcularDiferenciaTOtalDetra();
        }
        DataGridViewComboBoxColumn combo;
        private void Dtgconten_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            int x = e.RowIndex, y = e.ColumnIndex;
            if (x >= 0)
            {
                //////DEBE HABER
                //combo = Dtgconten.Columns[xDebeHaber.Name] as DataGridViewComboBoxColumn;
                //combo.DisplayMember = "Descripcion";
                //combo.ValueMember = "codigo";
                //combo.AutoComplete = true;
                //combo.DataSource = TDebeHaber;
                //////GRAVA
                //if (cbograba.Text.ToUpper() == "GRAVA")
                //{
                combo = Dtgconten.Columns[xTipoIgvg.Name] as DataGridViewComboBoxColumn;
                combo.AutoComplete = true;
                combo.DataSource = TGrava;
                combo.DisplayMember = "Descripcion";
                combo.ValueMember = "codigo";
            }
        }
        private void btnaceptar_Click(object sender, EventArgs e)
        {

            if (Dtgconten.AllowUserToAddRows)
            {
                Dtgconten.AllowUserToAddRows = false;
                btnAdd.Text = "Agregar";
            }
            else
            {
                LimpiarVistaPRevia();
                Dtgconten.AllowUserToAddRows = true;
                btnAdd.Text = "Finalizar";

            }
            btnAceptar.Enabled = false;
        }
        private void Dtgconten_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            if (e.ColumnIndex == Dtgconten.Columns[xTipoIgvg.Name].Index)
            {
                Dtgconten[xTipoIgvg.Name, e.RowIndex].Value = 1;
            }
        }
        private void Dtgconten_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int x = e.RowIndex, y = e.ColumnIndex;
            if (x >= 0)
            {
                if (y == Dtgconten.Columns[xCuentaContable.Name].Index)
                {
                    frmlistarcuentas cuentitas = new frmlistarcuentas();
                    cuentitas.Icon = Icon;
                    Dtgconten.EndEdit();
                    if (Dtgconten[xCuentaContable.Name, e.RowIndex].Value != null)
                    {
                        cuentitas.Txtbusca.Text = Dtgconten[xCuentaContable.Name, e.RowIndex].Value.ToString();
                    }
                    else
                    { cuentitas.Txtbusca.Text = ""; }
                    cuentitas.radioButton1.Checked = true;
                    cuentitas.ShowDialog();
                    if (cuentitas.aceptar)
                    {
                        //if (cuentitas.codigo.Substring(cuentitas.codigo.Length - 1, 1) == "0")
                        //{
                        //    Msg("No se Puede Seleccionar una cuenta de Cabeceras");
                        //}
                        //else
                        //{
                        Dtgconten[xCuentaContable.Name, e.RowIndex].Value = cuentitas.codigo;
                        Dtgconten.EndEdit();
                        Dtgconten.RefreshEdit();
                        //}
                    }
                }
                if (Dtgconten.Columns[xCentroCosto.Name].Index == y)
                {
                    frmccosto ccosto = new frmccosto();
                    ccosto.Consulta = true;
                    if (ccosto.ShowDialog() == DialogResult.OK)
                    {
                        Dtgconten[xCentroCosto.Name, x].Value = ccosto.CodigoCentro;
                        Dtgconten.EndEdit();
                        Dtgconten.RefreshEdit();
                    }
                }
            }
        }
        private void Dtgconten_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            int x = e.RowIndex, y = e.ColumnIndex;
            if (x >= 0)
            {
                btnAceptar.Enabled = false;
                if (y == Dtgconten.Columns[xCuentaContable.Name].Index)
                {
                    string consulta = Dtgconten[xCuentaContable.Name, x].Value == null ? "" : Dtgconten[xCuentaContable.Name, x].Value.ToString();
                    DataTable Tcuenta = CapaLogica.BuscarCuentas(consulta, 3);
                    string cadena = "";
                    if (Tcuenta.Rows.Count > 0)
                    {
                        cadena = Tcuenta.Rows[0]["cuenta_contable"].ToString();
                    }
                    Dtgconten[xdescripcion.Name, x].Value = cadena;
                }
                else
                if (y == Dtgconten.Columns[xCentroCosto.Name].Index)
                {
                    string consulta = Dtgconten[xCentroCosto.Name, x].Value == null ? "" : Dtgconten[xCentroCosto.Name, x].Value.ToString();
                    DataTable Tcentron = CapaLogica.ListarCentrosdeCosto(2, 0, consulta);
                    string resul = ""; int result2 = 0;
                    if (Tcentron.Rows.Count > 0)
                    {
                        resul = Tcentron.Rows[0]["centrocosto"].ToString();
                        result2 = (int)Tcentron.Rows[0]["Id_CCosto"];
                    }
                    Dtgconten[xCentroCostoDesc.Name, x].Value = resul;
                    Dtgconten[xidcc.Name, x].Value = result2;
                }
                else
                if (y == Dtgconten.Columns[xImporteME.Name].Index)
                {
                    if (cbomoneda.SelectedValue.ToString() == "2")
                    {
                        if (Dtgconten[xUsuario.Name, x].Value != null)
                            if ((Dtgconten[xUsuario.Name, x].Value.ToString() == "" ? 1 : (int)Dtgconten[xUsuario.Name, x].Value) != 999)
                            {
                                decimal Valor = 0;
                                decimal.TryParse(Dtgconten[xImporteME.Name, x].Value == null ? "0" : Dtgconten[xImporteME.Name, x].Value.ToString(), out Valor);
                                Dtgconten[xImporteMN.Name, x].Value = Redondear(Valor * decimal.Parse(txttipocambio.Text == ".000" ? "1" : txttipocambio.Text == "" ? "1" : txttipocambio.Text));
                            }
                    }
                }
                else if (y == Dtgconten.Columns[xImporteMN.Name].Index)
                {
                    if (cbomoneda.SelectedValue.ToString() == "1")
                    {
                        if (Dtgconten[xUsuario.Name, x].Value != null)
                            if ((Dtgconten[xUsuario.Name, x].Value.ToString() == "" ? 1 : (int)Dtgconten[xUsuario.Name, x].Value) != 999)
                            {
                                decimal Valor = 0;
                                decimal.TryParse(Dtgconten[xImporteMN.Name, x].Value == null ? "0" : Dtgconten[xImporteMN.Name, x].Value.ToString(), out Valor);
                                decimal TC = decimal.Parse(txttipocambio.Text == ".000" ? "1" : txttipocambio.Text == "" ? "1" : txttipocambio.Text);
                                //Para no dividir por Cero
                                TC = TC == 0 ? 1 : TC;
                                Dtgconten[xImporteME.Name, x].Value = Redondear(Valor / TC);
                            }
                    }
                }
                else
                if (y == Dtgconten.Columns[xDebeHaber.Name].Index && Dtgconten[xDebeHaber.Name, x].Value != null)
                {
                    Dtgconten[xDebeHaber.Name, x].Value = Dtgconten[xDebeHaber.Name, x].Value.ToString().ToUpper();
                }
            }
        }
        private void cbomoneda_SelectedIndexChanged(object sender, EventArgs e)
        {
            //xImporteME.ReadOnly = false;
            //xImporteMN.ReadOnly = false;
            //////SOLES
            //if (cbomoneda.SelectedValue.ToString() == "1")
            //{
            //    xImporteME.ReadOnly = true;
            //    foreach (DataGridViewRow item in Dtgconten.Rows)                
            //        Dtgconten_CellValueChanged(sender, new DataGridViewCellEventArgs(xImporteMN.Index, item.Index));                
            //}
            //////dolares
            //if (cbomoneda.SelectedValue.ToString() == "2")
            //{
            //    xImporteMN.ReadOnly = true;
            //    foreach (DataGridViewRow item in Dtgconten.Rows)
            //        Dtgconten_CellValueChanged(sender, new DataGridViewCellEventArgs(xImporteME.Index, item.Index));
            //}
        }
        private void Dtgconten_KeyPress(object sender, KeyPressEventArgs e)
        {
        }
        public DialogResult msgYesCancel(string cadena) { return HPResergerFunciones.frmPregunta.MostrarDialogYesCancel(cadena); }
        public DialogResult msgync(string cadena) { return HPResergerFunciones.frmPregunta.MostrarDialogYesNoCancel(cadena); }
        private void Dtgconten_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Delete || e.KeyData == Keys.Back)
                if (Estado == 1 || Estado == 2)
                    if (msgp("Desea Eliminar Filas") == DialogResult.Yes)
                    {
                        foreach (DataGridViewCell item in Dtgconten.SelectedCells)
                            if (item.RowIndex >= 0)
                            {
                                try
                                {
                                    Dtgconten.Rows.Remove(Dtgconten.Rows[item.RowIndex]);
                                    btnAceptar.Enabled = false;
                                }
                                catch (Exception) { }
                            }
                    }
        }
        private void cbomoneda_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                ////SOLES
                if (cbomoneda.SelectedValue != null)
                {
                    Dtgconten.Columns[xImporteME.Name].ReadOnly = false;
                    Dtgconten.Columns[xImporteMN.Name].ReadOnly = false;
                    if (cbomoneda.SelectedValue.ToString() == "1")
                    {
                        Dtgconten.Columns[xImporteME.Name].ReadOnly = true;
                        foreach (DataGridViewRow item in Dtgconten.Rows)
                            Dtgconten_CellValueChanged(sender, new DataGridViewCellEventArgs(Dtgconten.Columns[xImporteMN.Name].Index, item.Index));
                    }
                    ////dolares
                    if (cbomoneda.SelectedValue.ToString() == "2")
                    {
                        Dtgconten.Columns[xImporteMN.Name].ReadOnly = true;
                        foreach (DataGridViewRow item in Dtgconten.Rows)
                            Dtgconten_CellValueChanged(sender, new DataGridViewCellEventArgs(Dtgconten.Columns[xImporteME.Name].Index, item.Index));
                    }
                }
            }
            catch (InvalidOperationException) { }
        }
        private void txttipocambio_TextChanged(object sender, EventArgs e)
        {
            ////CAMBIO DE MONEDA
            cbomoneda_SelectedValueChanged(sender, e);
        }
        string DatosCompensacion = "";
        int FacturaEstado = 0;
        int[] ListaIdNotas = { 8, 9 };
        private void btnAceptar_Click_1(object sender, EventArgs e)
        {
            if (Estado == 2)
            {
                //Validacion para que un Activo fijo no se quede sin su factura de registro y activacion
                if (ActivoFijo == 2 && !chkActivoFijo.Checked)
                {
                    msgError("No se Puede quitar el CHECK a activo fijo de la factura, ya que está pertenece a una Activo Fijo Activado");
                    return;
                }
            }

            if (Estado == 10)
            {
                CapaLogica.FacturaManualCabecera(_idFac, imgfactura);
                msgOK($"Imagen de la Factura Actualizada Con Éxito");
                btnvistaPrevia.Visible = false;
                Estado = 0;
                btnAceptar.Enabled = btnCargarFoto.Enabled = false;
                Limpiar();
                CargarDatos();
                return;
            }
            if (Estado == 1 || Estado == 2)
            {
                foreach (DataGridViewRow item in Dtgconten.Rows)
                {
                    if (item.Cells[xCuentaContable.Name].Value.ToString().Substring(0, 1) == "3" && !chkActivoFijo.Checked)
                    {
                        msgError("La Factura tiene una cuenta de Activo Fijo");
                        chkActivoFijo.Checked = true;
                        return;
                    }
                }


                if (_TipoDoc == 3 || _TipoDoc == 2)
                {
                    if (chkfac.Checked)
                    {
                        //if (Dtgconten.RowCount > 0)
                        //{
                        //    if (txtSerieRef.Text.Length == 0) { Msg("Ingrese Serie del Documento de Referencia"); txtSerieRef.Focus(); return; }
                        //    if (txtNumRef.Text.Length == 0) { Msg("Ingrese Número del Documento de Referencia"); txtNumRef.Focus(); return; }
                        //}
                    }
                    else
                    {
                        BusquedaDocReferencia(); btnaplicar.Enabled = false; if (Encontrado == 0) { msgError("El Documento de Referencia no se ha Encontrado"); return; }
                    }
                }//BusquedaDocReferencia(); btnaplicar.Enabled = false; if (Encontrado == 0) { Msg("El Documento de Referencia no se ha Encontrado"); return; } }
                 //Validacion de que el periodo NO sea muy disperso, sea un mes continuo a los trabajados
                int IdEmpresa = (int)cboempresa.SelectedValue;
                DateTime FechaCoontable = dtpFechaContable.Value;
                if (!CapaLogica.ValidarCrearPeriodo(IdEmpresa, FechaCoontable))
                {
                    if (HPResergerFunciones.frmPregunta.MostrarDialogYesCancel("No se Puede Registrar este Asiento\nEl Periodo no puede Crearse", $"¿Desea Crear el Periodo de {FechaCoontable.ToString("MMMM")}-{FechaCoontable.Year}?") != DialogResult.Yes)
                        return;
                }
                else if (!CapaLogica.VerificarPeriodoAbierto((int)cboempresa.SelectedValue, dtpFechaContable.Value))
                {
                    msgError("El Periodo Esta Cerrado, Cambie Fecha Contable"); dtpFechaContable.Focus(); return;
                }
                //Validamos el Periodo Abierto
                //DataTable TPrueba2 = CapaLogica.VerPeriodoAbierto((int)cboempresa.SelectedValue, dtpFechaContable.Value);
                //if (TPrueba2.Rows.Count == 0) { msg("El Periodo está Cerrado cambie la Fecha Contable"); dtpFechaContable.Focus(); return; }
                if (cboempresa.Items.Count == 0) { msgError("No hay Empresa"); cboempresa.Focus(); return; }
                if (cboproyecto.Items.Count == 0) { msgError("No hay Proyecto"); cboproyecto.Focus(); return; }
                if (cboetapa.Items.Count == 0) { msgError("No hay Etapa"); cboetapa.Focus(); return; }
                if (cbomoneda.Items.Count == 0) { msgError("No hay Moneda"); cbomoneda.Focus(); return; }
                if (cbotipodoc.Items.Count == 0) { msgError("No hay Tipo"); cbotipodoc.Focus(); return; }
                if (txtcodfactura.Text.Length == 0) { msgError($"Ingrese Codigo de {cbotipodoc.Text}"); txtcodfactura.Focus(); return; }
                if (txtnrofactura.Text.Length == 0) { msgError($"Ingrese Número de {cbotipodoc.Text}"); txtnrofactura.Focus(); return; }
                if (!ProcesoMasivo)
                    if (!txttotalfac.EstaLLeno()) { if (msgp("Desea Graba el Comprobante con Total Cero.") != DialogResult.Yes) { txttotalfac.Focus(); return; } }
                if (decimal.Parse(txttipocambio.TextValido()) == 0) { msgError("El Tipo de Cambio debe ser Mayor a Cero"); txttipocambio.Focus(); return; }
                if (!txtruc.EstaLLeno()) { msgError("Ingrese RUC del Comprobante"); txtruc.Focus(); return; }
                if (_TipoDoc == 0) if (cbodetraccion.Text == "SI") if (!txtdescdetraccion.EstaLLeno()) { msgError("Seleccione la Detracción"); cbodetraccion.Focus(); return; }
                if (!txtrazon.EstaLLeno()) { msgError("No se Encontro Razon Social"); txtruc.Focus(); return; }
                ///valido compensacion
                DatosCompensacion = "";
                if ((new int[] { 1, 2, 3 }).Contains((int)cbocompensa.SelectedValue))
                {
                    if (cbotipoidcompensa.SelectedValue == null || txtnumdocompensa.Text.Length == 0)
                    {
                        msgError("Seleccione Empleado de la Compensación"); btnbususuacompesa.Focus(); return;
                    }
                    DatosCompensacion = cbotipoidcompensa.SelectedValue.ToString() + "-" + txtnumdocompensa.Text;
                }
                //// SI TIENE DETALLE LA FACTURA
                if (Dtgconten.RowCount > 0)
                {


                    FacturaEstado = 1;
                    Boolean errorc = false, ErrorDH = false;
                    foreach (DataGridViewRow item in Dtgconten.Rows)
                    {
                        if ((item.Cells[xDebeHaber.Name].Value.ToString() == "D" || item.Cells[xDebeHaber.Name].Value.ToString() == "H"))
                        {
                            HPResergerFunciones.Utilitarios.ColorCeldaDefecto(item.Cells[xDebeHaber.Name]);
                        }
                        else { HPResergerFunciones.Utilitarios.ColorCeldaError(item.Cells[xDebeHaber.Name]); ErrorDH = true; }
                        if (item.Cells[xdescripcion.Name].Value.ToString() == "")
                        {
                            errorc = true;
                            HPResergerFunciones.Utilitarios.ColorCeldaError(item.Cells[xdescripcion.Name]);
                            HPResergerFunciones.Utilitarios.ColorCeldaError(item.Cells[xCuentaContable.Name]);
                        }
                        else
                        {
                            HPResergerFunciones.Utilitarios.ColorCeldaDefecto(item.Cells[xdescripcion.Name]);
                            HPResergerFunciones.Utilitarios.ColorCeldaDefecto(item.Cells[xCuentaContable.Name]);
                        }
                    }
                    string cadena = "";
                    if (errorc) { cadena += "Hay Errores en las Cuentas\n"; }
                    if (ErrorDH) { cadena += "Hay Errores en del Debe/Haber\n"; }
                    /////VALIDACION
                    if (errorc || ErrorDH) { msgError(cadena); return; }
                }
                else FacturaEstado = 0;
            }
            //////INSERTANDO
            int codigo = 0;
            string cuo = "";
            ////INSERTAR ASIENTO DE CABECERA Y DETALLE 
            ////PARTE DE LOS ASIENTOS DONDE SE VALIDARA LA ELIMINACION, CREACION Y ACTUALIZACION -DETALLE
            ///semantiene la misma empresa
            if (Estado == 2)
            {
                if (OldCuo != null)
                {
                    if (OldEmpresa == (int)cboempresa.SelectedValue)
                    {
                        if (OldFechaContable.Month == dtpFechaContable.Value.Month && OldFechaContable.Year == dtpFechaContable.Value.Year && (OldCuo != null))
                        {
                            cuo = OldCuo;
                            if (OldCuo != "")
                                codigo = int.Parse(OldCuo.Substring(5));
                            else CapaLogica.UltimoAsiento((int)cboempresa.SelectedValue, dtpFechaContable.Value, out codigo, out cuo);
                        }
                        else
                        {
                            CapaLogica.UltimoAsiento((int)cboempresa.SelectedValue, dtpFechaContable.Value, out codigo, out cuo);
                        }
                    }
                    ////cambio de empresa la factura///
                    else
                    {
                        CapaLogica.UltimoAsiento((int)cboempresa.SelectedValue, dtpFechaContable.Value, out codigo, out cuo);
                    }
                    ///eliminanos el registro anterior
                    if (OldCuo != null)
                        CapaLogica.EliminarAsiento(OldCuo, OldEmpresa, OldFechaContable, 0);
                }
                else
                    CapaLogica.UltimoAsiento((int)cboempresa.SelectedValue, dtpFechaContable.Value, out codigo, out cuo);
            }
            else
                CapaLogica.UltimoAsiento((int)cboempresa.SelectedValue, dtpFechaContable.Value, out codigo, out cuo);
            if (_TipoDoc == 1)
            {
                TotalIgv = decimal.Parse(txtrenta.Text);
            }
            ///fin de revision de la modificacion
            /////los estados 
            OpcionBusqueda = 0;
            if (_TipoDoc == 0 || _TipoDoc == 1) OpcionBusqueda = 1;
            if (_TipoDoc == 2 || _TipoDoc == 3) OpcionBusqueda = 2;
            NumFac = txtcodfactura.Text + "-" + txtnrofactura.Text;
            NumFacRef = txtSerieRef.Text + "-" + txtNumRef.Text;
            //VALIDAMOS QUE NO EXISTAN CUENTAS CONTABLES DESACTIVADAS
            List<string> ListaAuxiliar = new List<string>();
            foreach (DataGridViewRow item in Dtgconten.Rows)
                ListaAuxiliar.Add(item.Cells[xCuentaContable.Name].Value.ToString());
            if (CapaLogica.CuentaContableValidarActivas(string.Join(",", ListaAuxiliar.ToArray()), "Cuentas Contables Desactivadas")) return;
            //FIN DE LA VALDIACION DE LAS CUENTAS CONTABLES DESACTIVADAS
            if (Estado == 1)
            {
                /////VALIDO SI EXISTE LA FACTURA  
                DataTable Tprueba = CapaLogica.FacturaManualCabecera(txtruc.Text, txtcodfactura.Text + "-" + txtnrofactura.Text, (int)cbotipodoc.SelectedValue);
                if (Tprueba.Rows.Count > 0) { msgError("No se puede Registrar, Este Documento Ya Existe"); return; }
                /////INSERTANDO LA FACTURA
                CapaLogica.FacturaManualCabecera(OpcionBusqueda == 1 ? 1 : 100, 0, (int)cbotipodoc.SelectedValue, NumFac, NumFacRef, txtruc.Text, (int)cboempresa.SelectedValue, (int)cboproyecto.SelectedValue, (int)cboetapa.SelectedValue, (int)cbocompensa.SelectedValue, (int)cbomoneda.SelectedValue,
                   decimal.Parse(txttipocambio.Text), decimal.Parse(txttotalfac.Text), TotalIgv, cbograba.SelectedIndex, dtpfechaemision.Value, dtpfecharecep.Value, dtpfechavence.Value, dtpFechaContable.Value, compensada ? 3 : FacturaEstado, 0, "", cbodetraccion.Text == "NO" ? "" : coddet, numdetraccion.Value,
                  decimal.Parse(txtmontodetraccion.Text), imgfactura, txtglosa.TextValido(), frmLogin.CodigoUsuario, DatosCompensacion, chkActivoFijo.Checked ? 1 : 0);

                ////INSERTANDO EL DETALLE DE LA FACTURA
                foreach (DataGridViewRow item in Dtgconten.Rows)
                {
                    //int usua; if (item.Cells[xUsuario.Name].Value.ToString() == "999" || item.Cells[xUsuario.Name].Value.ToString() == "998") usua = 999; else usua = frmLogin.CodigoUsuario;
                    CapaLogica.FacturaManualDetalle(1, 0, (int)cbotipodoc.SelectedValue, NumFac, txtruc.Text, item.Cells[xDebeHaber.Name].Value.ToString(),
                        item.Cells[xCuentaContable.Name].Value.ToString(), item.Cells[xCentroCosto.Name].Value.ToString(), item.Cells[xTipoIgvg.Name].Value.ToString() == "" ? 0 : (int)item.Cells[xTipoIgvg.Name].Value,
                     (decimal)item.Cells[xImporteMN.Name].Value, (decimal)item.Cells[xImporteME.Name].Value, item.Cells[xGlosa.Name].Value.ToString(), cuo, item.Cells[xUsuario.Name].Value.ToString() == "" ? frmLogin.CodigoUsuario : (int)item.Cells[xUsuario.Name].Value);
                }


                //Actualizamos los datos adicionales
                DataTable tfACTURA = CapaLogica.FacturaManualCabecera(txtruc.Text, txtcodfactura.Text + "-" + txtnrofactura.Text, (int)cbotipodoc.SelectedValue);
                if (tfACTURA.Rows.Count > 0)
                {
                    _idFac = (int)tfACTURA.Rows[0]["ID"];
                    _Tipo = (int)tfACTURA.Rows[0]["tipo"];
                }
                CapaDatos.FacturaManualDatosAdicionales(0, _idFac, Convert.ToInt32(igvs * 100), _Tipo);
                //fin Actualizamos los datos adicionales

                ////INSERTAR ASIENTO DE CABECERA Y DETALLE
                int i = 1;
                foreach (DataGridViewRow item in Dtgconten.Rows)
                {
                    if (item.Cells[xUsuario.Name].Value.ToString() != "998")
                    {
                        double vdeber = 0, vhaber = 0;
                        if (item.Cells[xDebeHaber.Name].Value.ToString() == "D") vdeber = double.Parse(((int)cbomoneda.SelectedValue) == 1 ? item.Cells[xImporteMN.Name].Value.ToString() : item.Cells[xImporteME.Name].Value.ToString());
                        if (item.Cells[xDebeHaber.Name].Value.ToString() == "H") vhaber = double.Parse(((int)cbomoneda.SelectedValue) == 1 ? item.Cells[xImporteMN.Name].Value.ToString() : item.Cells[xImporteME.Name].Value.ToString());
                        CapaLogica.InsertarAsiento(i, codigo, dtpfechaemision.Value, item.Cells[xCuentaContable.Name].Value.ToString(), vdeber, vhaber, -4, 1, dtpFechaContable.Value, (int)cboproyecto.SelectedValue, (int)cboetapa.SelectedValue, txtglosa.TextValido(), (int)cbomoneda.SelectedValue, decimal.Parse(txttipocambio.Text));
                        ////DETALLE ASIENTO                        
                        CapaLogica.DetalleAsientos(1, i, codigo, item.Cells[xCuentaContable.Name].Value.ToString(), 5, txtruc.Text, txtrazon.Text, (int)cbotipodoc.SelectedValue,/* OpcionBusqueda == 1 ?*/ txtcodfactura.Text/* : txtSerieRef.Text*/, /*OpcionBusqueda == 1 ?*/ txtnrofactura.Text /*: txtNumRef.Text*/,
                         item.Cells[xidcc.Name].Value.ToString() == "" ? 0 : (int)item.Cells[xidcc.Name].Value, item.Cells[xGlosa.Name].Value.ToString(), dtpfechaemision.Value, dtpfechavence.Value, (decimal)item.Cells[xImporteMN.Name].Value, (decimal)item.Cells[xImporteME.Name].Value,
                        decimal.Parse(txttipocambio.Text), frmLogin.CodigoUsuario, (int)cboproyecto.SelectedValue, dtpfecharecep.Value, (int)cbomoneda.SelectedValue, dtpFechaContable.Value, 0, "", "", 0);
                        ////contador para next valor
                        i++;
                    }
                }
                if (!ProcesoMasivo)
                    if (FacturaEstado == 0) msgOK($"Documento Guardado Con Éxito"); else msgOK($"Documento Guardado \nGenerado sus Asiento : {cuo} \nCon Éxito");
                else
                    ResultadoMasivoTXT += $"Documento Guardado:Ruc:{txtruc.Text} Comprobante:{txtcodfactura.Text}-{txtnrofactura.Text}  Generado sus Asiento:{ cuo} \n";
            }
            //////ACTUALIZANDO
            if (Estado == 2)
            {
                /////VALIDO SI YA EXISTE LA FACTURA  
                DataTable Tprueba = CapaLogica.FacturaManualCabecera(txtruc.Text, txtcodfactura.Text + "-" + txtnrofactura.Text, _idFac, (int)cbotipodoc.SelectedValue, OpcionBusqueda);
                if (Tprueba.Rows.Count > 0) { msgError("No se puede Registrar, Este Documento Ya Existe"); return; }
                //////ACTUALIZANDO LA FACTURA  
                Boolean ResultOld = ListaIdNotas.Contains(OldIdComprobanteSelect);
                Boolean ResultNew = ListaIdNotas.Contains((int)cbotipodoc.SelectedValue);
                if (ResultOld != ResultNew)
                {
                    //Elimino la Cabecera Anterior
                    CapaLogica.FacturaManualCabeceraRemover((int)dtgBusqueda[yid.Name, dtgBusqueda.CurrentRow.Index].Value, ResultOld ? 300 : 3);
                    //Inserto un Nuevo Registro
                    CapaLogica.FacturaManualCabecera(OpcionBusqueda == 1 ? 1 : 100, 0, (int)cbotipodoc.SelectedValue, NumFac, NumFacRef, txtruc.Text, (int)cboempresa.SelectedValue, (int)cboproyecto.SelectedValue, (int)cboetapa.SelectedValue, (int)cbocompensa.SelectedValue, (int)cbomoneda.SelectedValue,
                        decimal.Parse(txttipocambio.Text), decimal.Parse(txttotalfac.Text), TotalIgv, cbograba.SelectedIndex, dtpfechaemision.Value, dtpfecharecep.Value, dtpfechavence.Value, dtpFechaContable.Value, OpcionBusqueda == 1 ? compensada ? 3 : FacturaEstado : NotasEstado == 2 ? 2 : compensada ? 3 : FacturaEstado, 0, "", cbodetraccion.Text == "NO" ? "" : coddet, numdetraccion.Value,
                        decimal.Parse(txtmontodetraccion.Text), imgfactura, txtglosa.TextValido(), frmLogin.CodigoUsuario, DatosCompensacion, ActivoFijo == 2 ? 2 : chkActivoFijo.Checked ? 1 : 0);

                }
                else
                    CapaLogica.FacturaManualCabecera(OpcionBusqueda == 1 ? 2 : 200, _idFac, (int)cbotipodoc.SelectedValue, NumFac, NumFacRef, txtruc.Text, (int)cboempresa.SelectedValue, (int)cboproyecto.SelectedValue, (int)cboetapa.SelectedValue, (int)cbocompensa.SelectedValue, (int)cbomoneda.SelectedValue,
                        decimal.Parse(txttipocambio.Text), decimal.Parse(txttotalfac.Text), TotalIgv, cbograba.SelectedIndex, dtpfechaemision.Value, dtpfecharecep.Value, dtpfechavence.Value, dtpFechaContable.Value, OpcionBusqueda == 1 ? compensada ? 3 : FacturaEstado : NotasEstado == 2 ? 2 : compensada ? 3 : FacturaEstado, 0, "", cbodetraccion.Text == "NO" ? "" : coddet, numdetraccion.Value,
                        decimal.Parse(txtmontodetraccion.Text), imgfactura, txtglosa.TextValido(), frmLogin.CodigoUsuario, DatosCompensacion, ActivoFijo == 2 ? 2 : chkActivoFijo.Checked ? 1 : 0);

                ///BORRAMOS LOS DATOS ANTERIOES
                if (OldCuo != null)
                    CapaLogica.FacturaManualDetalleRemover(OldNumFac, OldProveedor, OpcionBusqueda == 1 ? 3 : 300, OldIdComprobanteSelect);
                ////INSERTANDO EL DETALLE DE LA FACTURA

                //Actualizamos los datos adicionales
                DataTable tfACTURA = CapaLogica.FacturaManualCabecera(txtruc.Text, txtcodfactura.Text + "-" + txtnrofactura.Text, (int)cbotipodoc.SelectedValue);
                if (tfACTURA.Rows.Count > 0)
                {
                    _idFac = (int)tfACTURA.Rows[0]["ID"];
                    _Tipo = (int)tfACTURA.Rows[0]["tipo"];
                }
                CapaDatos.FacturaManualDatosAdicionales(0, _idFac, Convert.ToInt32(igvs * 100), _Tipo);
                //fin Actualizamos los datos adicionales

                foreach (DataGridViewRow item in Dtgconten.Rows)
                {
                    //int usua; if (item.Cells[xUsuario.Name].Value.ToString() == "999" || item.Cells[xUsuario.Name].Value.ToString() == "998") usua = 999; else usua = frmLogin.CodigoUsuario;
                    CapaLogica.FacturaManualDetalle(1, 0, (int)cbotipodoc.SelectedValue, NumFac, txtruc.Text, item.Cells[xDebeHaber.Name].Value.ToString(),
                        item.Cells[xCuentaContable.Name].Value.ToString(), item.Cells[xCentroCosto.Name].Value.ToString(), item.Cells[xTipoIgvg.Name].Value.ToString() == "" ? 0 : (int)item.Cells[xTipoIgvg.Name].Value,
                     (decimal)item.Cells[xImporteMN.Name].Value, (decimal)item.Cells[xImporteME.Name].Value, item.Cells[xGlosa.Name].Value.ToString(), cuo, item.Cells[xUsuario.Name].Value.ToString() == "" ? frmLogin.CodigoUsuario : (int)item.Cells[xUsuario.Name].Value);
                }
                int i = 1;
                foreach (DataGridViewRow item in Dtgconten.Rows)
                {
                    if (item.Cells[xUsuario.Name].Value.ToString() != "998")
                    {
                        double vdeber = 0, vhaber = 0;
                        if (item.Cells[xDebeHaber.Name].Value.ToString() == "D") vdeber = double.Parse(((int)cbomoneda.SelectedValue) == 1 ? item.Cells[xImporteMN.Name].Value.ToString() : item.Cells[xImporteME.Name].Value.ToString());
                        if (item.Cells[xDebeHaber.Name].Value.ToString() == "H") vhaber = double.Parse(((int)cbomoneda.SelectedValue) == 1 ? item.Cells[xImporteMN.Name].Value.ToString() : item.Cells[xImporteME.Name].Value.ToString());
                        CapaLogica.InsertarAsiento(i, codigo, dtpfechaemision.Value, item.Cells[xCuentaContable.Name].Value.ToString(), vdeber, vhaber, -4, 1, dtpFechaContable.Value, (int)cboproyecto.SelectedValue, (int)cboetapa.SelectedValue, txtglosa.TextValido(), (int)cbomoneda.SelectedValue, decimal.Parse(txttipocambio.Text));
                        ////DETALLE ASIENTO                        
                        CapaLogica.DetalleAsientos(1, i, codigo, item.Cells[xCuentaContable.Name].Value.ToString(), 5, txtruc.Text, txtrazon.Text, (int)cbotipodoc.SelectedValue,/* OpcionBusqueda == 1 ? */txtcodfactura.Text/* : txtSerieRef.Text*/, /*OpcionBusqueda == 1 ? */txtnrofactura.Text /*: txtNumRef.Text*/,
                        item.Cells[xidcc.Name].Value.ToString() == "" ? 0 : (int)item.Cells[xidcc.Name].Value, item.Cells[xGlosa.Name].Value.ToString(), dtpfechaemision.Value, dtpfechavence.Value, (decimal)item.Cells[xImporteMN.Name].Value, (decimal)item.Cells[xImporteME.Name].Value,
                        decimal.Parse(txttipocambio.Text), frmLogin.CodigoUsuario, (int)cboproyecto.SelectedValue, dtpfecharecep.Value, (int)cbomoneda.SelectedValue, dtpFechaContable.Value, 0, "", "", 0);
                        ////contador para next valor
                        i++;
                    }
                }
                /////FIN DE LA PARTE DE LOS ASIENTOS
                if (FacturaEstado == 0) msgOK($"Documento Actualizado Con Éxito"); else msgOK($"Documento Actualizado \nGenerado sus Asiento : {cuo} \nCon Éxito");
            }
            btnvistaPrevia.Visible = false;
            string nroFac = txtcodfactura.Text + "-" + txtnrofactura.Text;
            int IdComprobante = (int)cbotipodoc.SelectedValue;
            ModoEdicion(false);
            btnAceptar.Enabled = false;
            Limpiar();
            if (!ProcesoMasivo)
                CargarDatos();
            if (Estado == 2 || Estado == 10)
            {
                foreach (DataGridViewRow item in dtgBusqueda.Rows)
                {
                    if (item.Cells[yNroComprobante.Name].Value.ToString() == nroFac && (int)item.Cells[yIdComprobante.Name].Value == IdComprobante)
                    {
                        dtgBusqueda.CurrentCell = dtgBusqueda[_IndicadorColumna, item.Index];
                        break;
                    }
                }
            }
            if (Estado == 1)
            {
                foreach (DataGridViewRow item in dtgBusqueda.Rows)
                {
                    if (item.Cells[yNroComprobante.Name].Value.ToString() == nroFac && (int)item.Cells[yIdComprobante.Name].Value == IdComprobante)
                    {
                        _IndicadorColumna = _IndicadorColumna == 0 ? 3 : _IndicadorColumna;
                        dtgBusqueda.CurrentCell = dtgBusqueda[_IndicadorColumna, item.Index];
                        break;
                    }
                }

            }
            BloquearControlesExtras();
            //txtSerieRef.Text = txtNumRef.Text = "";
            Estado = 0;
            cbotipodoc_SelectedIndexChanged(sender, e);
        }
        int OpcionBusqueda = 0;
        string NumFac = "";
        string NumFacRef = "";
        private void Dtgconten_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {
            lblmensaje.Text = $"Total de Registros: {Dtgconten.RowCount}";
        }
        private void cboetapa_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if (cboetapa.Items.Count > 0)
            //{
            //    if (cboetapa.SelectedValue != null)
            //        _etapa = (int)cboetapa.SelectedValue;
            //}
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            ///soluciuonar el error del dataformating la next row
            Dtgconten.AllowUserToAddRows = false;
            if (Estado != 0)
            {
                ModoEdicion(false);
                btnAceptar.Enabled = false;
                Limpiar();
                CargarDatos();
                if (_IndicadorColumna != 0)
                    if (dtgBusqueda.RowCount > 0)
                    {
                        if (Estado == 2 || Estado == 10 || Estado == 1)
                        {
                            if (dtgBusqueda.RowCount < _IndicadorFila)
                                _IndicadorFila = dtgBusqueda.RowCount - 1;
                            dtgBusqueda.CurrentCell = dtgBusqueda[_IndicadorColumna, _IndicadorFila];
                        }
                    }
                Estado = 0;
                cbotipodoc_SelectedIndexChanged(sender, e);
            }
            else Close();
            BloquearControlesExtras();
            Estado = 0; btnvistaPrevia.Visible = false;

        }
        public void BloquearControlesExtras()
        {
            cbomoneda.Enabled = false;
            cboproyecto.Enabled = false;
            cboetapa.Enabled = false;
            cboempresa.Enabled = false;
            cbocompensa.Enabled = false;
        }
        public void Limpiar()
        {
            imgfactura = null;
            frmimagen.Imagen = null;
            txtcodfactura.Text = "";
            txtnrofactura.Text = "";
            txtmontodetraccion.CargarTextoporDefecto();
            cbodetraccion.Text = "NO";
            txttotalfac.CargarTextoporDefecto();
            txtglosa.CargarTextoporDefecto();
            txtruc.CargarTextoporDefecto();
            txtDifDetra.CargarTextoporDefecto();
            txtrenta.CargarTextoporDefecto();
            txtSerieRef.Text = txtNumRef.Text = "";
            chkActivoFijo.Checked = false;
        }
        private void btnnuevo_Click(object sender, EventArgs e)
        {
            //_IndicadorColumna = dtgBusqueda.CurrentCell == null ? 6 : dtgBusqueda.CurrentCell.ColumnIndex;
            if (dtgBusqueda.CurrentCell != null)
            {
                _IndicadorFila = dtgBusqueda.CurrentCell.RowIndex;
                _IndicadorColumna = dtgBusqueda.CurrentCell.ColumnIndex;
            }
            compensada = false;
            Estado = 1;
            ActivoFijo = 0;
            ModoEdicion(true);
            Limpiar();
            if (Dtgconten.DataSource != null)
            {
                TContenendor = ((DataTable)Dtgconten.DataSource).Clone();
                Dtgconten.DataSource = TContenendor;
            }
            else
            {
                TContenendor = CapaLogica.FacturaManualDetalleBusqueda("", "", 0);
                Dtgconten.DataSource = TContenendor;
            }
            btnAceptar.Enabled = true;
            dtpfechaemision_ValueChanged(sender, e);
            dtpfechavence.Value = DateTime.Now;
            BloquearColumnas();
            cbomoneda_SelectedValueChanged(sender, e);
            cbotipodoc_SelectedIndexChanged(sender, e);
            MostrarFormato82(false);

            chkIGV.Checked = false;
        }
        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            if (msgp("Eliminar Todas Las Filas") == DialogResult.Yes)
                ((DataTable)Dtgconten.DataSource).Clear();
        }
        public void BloquearColumnas()
        {
            foreach (DataGridViewColumn item in Dtgconten.Columns)
            {
                var x = item.Name;
                if (x == xdescripcion.Name || x == xCentroCostoDesc.Name || x == xCodAsientoCtble.Name)
                    item.ReadOnly = true;
            }
            ///disparado
            cbomoneda_SelectedIndexChanged(new object(), new EventArgs());
        }
        public void ModoEdicionFoto(Boolean a)
        {
            dtgBusqueda.Enabled = !a;
            txtbuscaempresa.ReadOnly = txtbusnrodoc.ReadOnly = txtbusproveedor.ReadOnly = a;
            btncleanfind.Enabled = btnnuevo.Enabled = btnmodificar.Enabled = !a;
        }
        int _IndicadorFila, _IndicadorColumna;
        Boolean compensada = false;
        string GlosaAnterior;
        private void btnmodificar_Click(object sender, EventArgs e)
        {
            GlosaAnterior = txtglosa.Text;
            _IndicadorFila = dtgBusqueda.CurrentCell.RowIndex;
            _IndicadorColumna = dtgBusqueda.CurrentCell.ColumnIndex;
            compensada = false;
            if (Dtgconten.RowCount > 0)
            {
                DataTable TPrueba1 = CapaLogica.VerFacturasPagadasCompras(txtruc.Text, txtcodfactura.Text + '-' + txtnrofactura.Text, (int)cbotipodoc.SelectedValue);
                DataTable TPrueba2 = CapaLogica.VerPeriodoAbierto((int)cboempresa.SelectedValue, dtpFechaContable.Value);
                if (TPrueba1.Rows.Count > 0 || dtgBusqueda[ynamestado.Name, dtgBusqueda.CurrentRow.Index].Value.ToString().ToUpper() == "PAGADA")
                {
                    DialogResult Result = msgync("La Factura ya tiene un Pago. \nSolo se puede Actualizar la Imagen.");
                    if (Result == DialogResult.Cancel) { return; }
                    if (Result == DialogResult.Yes)
                    {
                        ///Actualizar solo imagen 
                        Estado = 10;
                        ///bloquear Controles
                        btnCargarFoto.Enabled = btnAceptar.Enabled = true;
                        ModoEdicionFoto(true);
                    }
                    if (Result == DialogResult.No)
                    {
                        msgOK("Se Modificará el Registro de La Factura");
                        ////lo eliminamos 
                        ModoEdicion(true);
                        BloquearColumnas();
                        Estado = 2;
                        NotasEstado = 2;
                        ////fin eliminacion
                    }
                }
                else if (TPrueba2.Rows.Count == 0)
                {
                    btnCargarFoto.Enabled = btnAceptar.Enabled = true;
                    Estado = 10;
                    msgError("La Factura Pertenece a un Periodo Cerrado. \nSolo se puede Actualizar la Imagen.");
                    ModoEdicionFoto(true);
                }
                else if (dtgBusqueda[yEstado.Name, dtgBusqueda.CurrentRow.Index].Value.ToString() == "3")
                {
                    Estado = 2;
                    msgError("Factura ya esta Compensada");
                    //return;
                    //if (cbodetraccion.Text.ToUpper() == "SI") btnmasdetracion.Enabled = true;
                    BloquearColumnas();
                    ModoEdicion(true);
                    compensada = true;
                }
                else
                {
                    Estado = 2;
                    ModoEdicion(true);
                    if (cbodetraccion.Text.ToUpper() == "SI") btnmasdetracion.Enabled = true;
                    BloquearColumnas();
                }
            }

            else
            {
                Estado = 2;
                ModoEdicion(true);
                if (cbodetraccion.Text.ToUpper() == "SI") btnmasdetracion.Enabled = true;
                BloquearColumnas();
            }
            OldIdComprobanteSelect = (int)cbotipodoc.SelectedValue;
            cbomoneda_SelectedValueChanged(sender, e);
            btnAceptar.Enabled = true;
            cbotipodoc_SelectedIndexChanged(sender, e);
            MostrarFormato82(false);

            chkIGV.Checked = !chkIGV.Checked;
            chkIGV.Checked = !chkIGV.Checked;

        }

        private void dtgBusqueda_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            int x = e.RowIndex, y = e.ColumnIndex;
            if (x >= 0)
            {
                DataGridViewRow R = dtgBusqueda.Rows[x];
                _idFac = (int)R.Cells[yid.Name].Value;
                _idComprobante = (int)R.Cells[yIdComprobante.Name].Value;
                /////datos de la empresa            
                cboempresa.SelectedValue = (int)R.Cells[yfkempresa.Name].Value;
                cboproyecto.SelectedValue = (int)R.Cells[yfkproyecto.Name].Value;
                cboetapa.SelectedValue = (int)R.Cells[yfkEtapa.Name].Value;
                ///datos de proveedor
                txtruc.Text = R.Cells[yProveedor.Name].Value.ToString();
                ///datos de la factura
                cbotipodoc.SelectedValue = (int)R.Cells[yIdComprobante.Name].Value;
                string[] CodNrofac = R.Cells[yNroComprobante.Name].Value.ToString().Split('-'); txtcodfactura.Text = CodNrofac[0]; txtnrofactura.Text = CodNrofac[1];
                dtpfechaemision.Value = (DateTime)R.Cells[yFechaEmision.Name].Value;
                dtpfecharecep.Value = (DateTime)R.Cells[yFechaRecepcion.Name].Value;
                dtpFechaContable.Value = (DateTime)R.Cells[yfechacontable.Name].Value;
                dtpfechavence.Value = (DateTime)R.Cells[yFechaVencimiento.Name].Value;
                txtglosa.Text = R.Cells[yGlosa.Name].Value.ToString();
                cbomoneda.SelectedValue = (int)R.Cells[yfkMoneda.Name].Value;
                txttipocambio.Text = ((decimal)R.Cells[yTC.Name].Value).ToString("n3");
                txttotalfac.Text = ((decimal)R.Cells[yTotal.Name].Value).ToString("n2");
                cbocompensa.SelectedValue = ((int)R.Cells[yCompensacion.Name].Value);
                TotalIgv = (decimal)R.Cells[yigv.Name].Value;
                txtrenta.Text = TotalIgv.ToString("n2");
                string[] CodNroFacRef;
                string NumFacRefe = R.Cells[yNroComprobanteRef.Name].Value.ToString();
                //Activo fijo
                if (R.Cells[xActivoFijo.Name].Value != null)
                {
                    ActivoFijo = (int)R.Cells[xActivoFijo.Name].Value;
                    chkActivoFijo.Checked = ((int)R.Cells[xActivoFijo.Name].Value) == 0 ? false : true;
                }
                //
                if (NumFacRefe != "")
                {
                    CodNroFacRef = R.Cells[yNroComprobanteRef.Name].Value.ToString().Split('-'); txtSerieRef.Text = CodNroFacRef[0]; txtNumRef.Text = CodNroFacRef[1];
                }
                /////CARGAR IMAGEN DE LA FACTURA
                DataTable TImagen = CapaLogica.BuscarImagenFacturasCompras(txtruc.Text, txtcodfactura.Text + "-" + txtnrofactura.Text, NumFacRefe == "" ? 1 : 2, 1, (int)cboempresa.SelectedValue, (int)cbotipodoc.SelectedValue);
                imgfactura = null; frmimagen.Imagen = null;
                if (TImagen.Rows.Count > 0)
                {
                    DataRow Fila = TImagen.Rows[0];
                    if (Fila["img"] != null)
                        if (Fila["img"].ToString().Length > 0)
                        {
                            imgfactura = (byte[])Fila["img"];
                            MemoryStream ms = new MemoryStream(imgfactura);
                            frmimagen.Imagen = Image.FromStream(ms);
                        }
                }
                ////detalle detraccion
                numdetraccion.Value = (decimal)R.Cells[yPorcentaje.Name].Value;
                cbograba.SelectedIndex = (int)R.Cells[yGravaIgv.Name].Value;
                if (R.Cells[yCod_Detraccion.Name].Value.ToString() == "")
                {
                    cbodetraccion.Text = "NO";
                    txtdescdetraccion.Text = "";
                }
                else
                {
                    cbodetraccion.Text = "SI";
                    CargarDetracciones();
                    string filtro = $"Cod_Detraccion ='{R.Cells[yCod_Detraccion.Name].Value.ToString()}'";
                    DataRow[] filaS = DatosDetracciones.Select(filtro);
                    if (filaS.Count() != 0)
                    {
                        detrac = txtdescdetraccion.Text = filaS[0]["Desc_Detraccion"].ToString();
                        coddet = filaS[0]["Cod_Detraccion"].ToString();
                        //numdetraccion.Value = cbodetraccion.SelectedValue == null ? 0.0m : (decimal)cbodetraccion.SelectedValue;
                        numdetraccion.Value = Convert.ToDecimal(filaS[0]["Porcentaje"].ToString());
                        if (!string.IsNullOrWhiteSpace(txttotalfac.Text))
                            detracion = decimal.Parse(txttotalfac.Text.ToString()) * (numdetraccion.Value / 100);
                    }
                    numdetraccion.Enabled = false;
                    int formato = (int)cbomoneda.SelectedValue == 1 ? 1 : 2;
                    txtmontodetraccion.Text = detracion.ToString($"n{formato}");
                }
                ///
                if (R.Cells[xusuarioCompensa.Name].Value.ToString() != "")
                {
                    string[] UsuaCompensa = R.Cells[xusuarioCompensa.Name].Value.ToString().Split('-');
                    cbotipoidcompensa.SelectedValue = int.Parse(UsuaCompensa[0]);
                    txtnumdocompensa.Text = UsuaCompensa[1];
                }
                else { cbotipoidcompensa.SelectedIndex = -1; txtnumdocompensa.Text = ""; }
                //
                btnmasdetracion.Enabled = false;
                int format = (int)cbomoneda.SelectedValue == 1 ? 1 : 2;
                txtmontodetraccion.Text = ((decimal)R.Cells[yDetraccion.Name].Value).ToString($"n{format}");
                txtDifDetra.Text = (decimal.Parse(txttotalfac.Text) - decimal.Parse(txtmontodetraccion.Text)).ToString("n2");
                //////CARGA DEL DETALLE DE LA FACTURA MANUAL
                Dtgconten.DataSource = CapaLogica.FacturaManualDetalleBusqueda(R.Cells[yProveedor.Name].Value.ToString(), R.Cells[yNroComprobante.Name].Value.ToString(), (int)cbotipodoc.SelectedValue);
                ////valores para saber si se modifico (cuo asiento fecha empresa)
                if (Dtgconten.RowCount > 0)
                {
                    OldCuo = Dtgconten[xCodAsientoCtble.Name, 0].Value.ToString();
                    OldEmpresa = (int)R.Cells[yfkempresa.Name].Value;
                    OldProyecto = (int)R.Cells[yfkproyecto.Name].Value;
                    OldFechaContable = (DateTime)R.Cells[yfechacontable.Name].Value;
                    OldId = (int)R.Cells[yid.Name].Value;
                    OldNumFac = txtcodfactura.Text + "-" + txtnrofactura.Text;
                    OldProveedor = txtruc.Text;
                    OldIdComprobante = (int)cbotipodoc.SelectedValue;
                }
                else OldCuo = null;
                //Muestra de Boton de Formato 8.2
                MostrarFormato82(false);
                if ((int)cbotipodoc.SelectedValue == 45) MostrarFormato82(true);

                //SACAMOS LOS DATOS ADICIONALES DE LA FACTURA
                //Actualizamos los datos adicionales
                DataTable tfACTURA = CapaLogica.FacturaManualCabecera(txtruc.Text, txtcodfactura.Text + "-" + txtnrofactura.Text, (int)cbotipodoc.SelectedValue);
                if (tfACTURA.Rows.Count > 0)
                {
                    _idFac = (int)tfACTURA.Rows[0]["ID"];
                    _Tipo = (int)tfACTURA.Rows[0]["tipo"];
                }
                DataTable TdataAdicional = CapaDatos.FacturaManualDatosAdicionales(10, _idFac, 0, _Tipo);
                if (TdataAdicional.Rows.Count > 0)
                {
                    if ((Int32)TdataAdicional.Rows[0]["igv"] == Convert.ToInt32(igvs * 100))
                    {
                        chkIGV.Checked = false;
                    }
                    else
                    {
                        chkIGV.Checked = true;
                        NumIGV.Value = (Int32)TdataAdicional.Rows[0]["igv"];
                    }
                }
                else
                    chkIGV.Checked = false;
            }
        }
        public void MostrarFormato82(Boolean v)
        {
            btnFormato82.Enabled = btnFormato82.Visible = v;
        }
        private void textBoxPer1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxPer2_TextChanged(object sender, EventArgs e)
        {
            /////proceso de Busqueda
            txtbusnrodoc.Text = txtbusnrodoc.Text.Replace("\t", "-");
            CargarDatos();
        }
        private void txtbusempresa_TextChanged(object sender, EventArgs e)
        {

        }
        public void LimpiarBusquedas()
        {
            txtBusTipoDoc.CargarTextoporDefecto();
            txtbuscaempresa.CargarTextoporDefecto();
            txtbusnrodoc.CargarTextoporDefecto();
            txtbusproveedor.CargarTextoporDefecto();
        }
        private void btncleanfind_Click(object sender, EventArgs e)
        {
            LimpiarBusquedas();
        }
        private void btnAdd_TextChanged(object sender, EventArgs e)
        {
            if (btnAdd.Text.ToUpper() == "AGREGAR")
            {
                //btnAceptar.Enabled = true;
                btnvistaPrevia.Visible = true;
            }
            else
            {
                //btnAceptar.Enabled = false;
                btnvistaPrevia.Visible = false;
            }
        }
        public void LimpiarVistaPRevia()
        {
            for (int i = 0; i < Dtgconten.RowCount; i++)
                if (Dtgconten[xUsuario.Name, i].Value != null)
                    if (Dtgconten[xUsuario.Name, i].Value.ToString() == "999" || Dtgconten[xUsuario.Name, i].Value.ToString() == "998")
                    {
                        Dtgconten.Rows.RemoveAt(i); i--;
                    }
        }
        private void btnvistaPrevia_Click(object sender, EventArgs e)
        {
            btnAceptar.Enabled = false;
            if (Dtgconten.Rows.Count > 0)
            {

                int conD = 0, conH = 0;
                Boolean error = false;
                Boolean errord = false;
                Boolean ErrorM = false;
                Boolean ErrorDH = false;
                string glosa = "";
                string cuo = "";
                DataTable TDatos = ((DataTable)Dtgconten.DataSource).Clone();
                LimpiarVistaPRevia();
                foreach (DataGridViewRow item in Dtgconten.Rows)
                {
                    if (item.Cells[xDebeHaber.Name].Value.ToString().ToUpper() == "D") conD++;
                    if (item.Cells[xDebeHaber.Name].Value.ToString().ToUpper() == "H")
                    {
                        conH++;
                        glosa = item.Cells[xGlosa.Name].Value.ToString();
                        cuo = item.Cells[xCodAsientoCtble.Name].Value.ToString();
                    }
                    ///VALIDA QUE EXISTA LA CUENTA
                    if (item.Cells[xdescripcion.Name].Value.ToString() == "")
                    {
                        errord = true;
                        HPResergerFunciones.Utilitarios.ColorCeldaError(item.Cells[xdescripcion.Name]);
                        HPResergerFunciones.Utilitarios.ColorCeldaError(item.Cells[xCuentaContable.Name]);
                    }
                    else
                    {
                        HPResergerFunciones.Utilitarios.ColorCeldaDefecto(item.Cells[xdescripcion.Name]);
                        HPResergerFunciones.Utilitarios.ColorCeldaDefecto(item.Cells[xCuentaContable.Name]);
                    }
                    //VALIDA QUE LOS VALORES SE HAN  "D-h"
                    if ((item.Cells[xDebeHaber.Name].Value.ToString() == "D" || item.Cells[xDebeHaber.Name].Value.ToString() == "H"))
                    {
                        HPResergerFunciones.Utilitarios.ColorCeldaDefecto(item.Cells[xDebeHaber.Name]);
                    }
                    else { HPResergerFunciones.Utilitarios.ColorCeldaError(item.Cells[xDebeHaber.Name]); ErrorDH = true; }
                    if ((item.Cells[xImporteMN.Name].Value.ToString() == "" ? 0 : (decimal)item.Cells[xImporteMN.Name].Value) <= 0 && decimal.Parse(txttotalfac.Text) != 0)
                    {
                        ErrorM = true;
                        HPResergerFunciones.Utilitarios.ColorCeldaError(item.Cells[xImporteMN.Name]);
                    }
                    else HPResergerFunciones.Utilitarios.ColorCeldaDefecto(item.Cells[xImporteMN.Name]);
                    if ((item.Cells[xImporteME.Name].Value.ToString() == "" ? 0 : (decimal)item.Cells[xImporteME.Name].Value) <= 0 && decimal.Parse(txttotalfac.Text) != 0)
                    {
                        ErrorM = true;
                        HPResergerFunciones.Utilitarios.ColorCeldaError(item.Cells[xImporteME.Name]);
                    }
                    else HPResergerFunciones.Utilitarios.ColorCeldaDefecto(item.Cells[xImporteME.Name]);
                    if (_TipoDoc != 1)
                    {
                        if (_TipoDoc == 0 || _TipoDoc == 3)
                        {
                            if (item.Cells[xDebeHaber.Name].Value.ToString() == "D")
                                if (item.Cells[xTipoIgvg.Name].Value.ToString() == "")
                                {
                                    error = true;
                                    HPResergerFunciones.Utilitarios.ColorCeldaError(item.Cells[xTipoIgvg.Name]);
                                }
                                else HPResergerFunciones.Utilitarios.ColorCeldaDefecto(item.Cells[xTipoIgvg.Name]);
                        }
                        if (_TipoDoc == 2)
                        {
                            if (item.Cells[xDebeHaber.Name].Value.ToString() == "H")
                                if (item.Cells[xTipoIgvg.Name].Value.ToString() == "")
                                {
                                    error = true;
                                    HPResergerFunciones.Utilitarios.ColorCeldaError(item.Cells[xTipoIgvg.Name]);
                                }
                                else HPResergerFunciones.Utilitarios.ColorCeldaDefecto(item.Cells[xTipoIgvg.Name]);
                        }
                    }
                }
                string cadena = "";
                if (ErrorDH) { cadena += "Hay Errores en el Debe/Haber\n"; }
                if (conD == 0) { cadena += "No hay Cuenta Debe (Items)\n"; }
                if (conH == 0)
                {
                    if (_TipoDoc != 0) cadena += "No hay Cuenta Haber\n";
                    else cadena += "No hay Cuenta Haber (Factura por Pagar)\n";
                }
                if (error) { cadena += "Seleccion Tipo de IGV\n"; }
                if (errord) { cadena += "Hay Errores en las Cuentas\n"; }
                if (ErrorM) { cadena += "Hay Errores los Importe\n"; }
                /////VALIDACION
                if (conD == 0 || conH == 0 || error || errord || ErrorDH) { msgError(cadena); return; }
                if (!ProcesoMasivo)
                    if (ErrorM) return;
                ////FIN DE LAS VALIDACIONES
                /////CALCULO DE DETRACCIONES
                if (decimal.Parse(txtmontodetraccion.Text) > 0)
                {
                    DataTable Tprueba = CapaLogica.BuscarCuentas("DETRACCIONES POR PAGAR", 5);
                    if (Tprueba.Rows.Count == 0)
                    {
                        Tprueba = CapaLogica.BuscarCuentas("421%DETRACCIONES", 5);
                    }
                    if (Tprueba.Rows.Count > 0)
                    {
                        DataRow filita = Tprueba.Rows[0];
                        DataRow fila = TDatos.NewRow();
                        fila[xDebeHaber.DataPropertyName] = "H";
                        fila[xCuentaContable.DataPropertyName] = filita["idcuenta"].ToString();//.Substring(0, 7);
                        fila[xdescripcion.DataPropertyName] = filita["cuenta_contable"].ToString();
                        fila[xUsuario.DataPropertyName] = 999;///por defecto
                        fila[xGlosa.DataPropertyName] = glosa;
                        fila[xCodAsientoCtble.DataPropertyName] = cuo;
                        if ((int)cbomoneda.SelectedValue == 1)
                        {
                            fila[xImporteMN.DataPropertyName] = Redondear(decimal.Parse(txtmontodetraccion.Text));
                            fila[xImporteME.DataPropertyName] = Redondear(decimal.Parse(txtmontodetraccion.Text) / decimal.Parse(txttipocambio.Text));
                        }
                        if ((int)cbomoneda.SelectedValue == 2)
                        {
                            fila[xImporteME.DataPropertyName] = Redondear(decimal.Parse(txtmontodetraccion.Text));
                            fila[xImporteMN.DataPropertyName] = Redondear(decimal.Parse(txtmontodetraccion.Text) * decimal.Parse(txttipocambio.Text));
                        }
                        TDatos.Rows.Add(fila);

                    }
                } //////VAMOS CON EL IGV
                igvs = (decimal)(CapaLogica.ValorIGVactual(dtpfechaemision.Value))["Valor"];
                if (chkIGV.Checked)
                    igvs = NumIGV.Value / 100;
                else
                    NumIGV.Value = igvs * 100;

                string CuentaIgv = "4011101";
                string NamecuentaIGV = "4011101 - IGV - COMPRAS";
                DataTable Tpruebas = CapaLogica.BuscarCuentas("IGV % COM", 5);
                if (Tpruebas.Rows.Count > 0)
                {
                    CuentaIgv = (Tpruebas.Rows[0])["idcuenta"].ToString();
                    NamecuentaIGV = (Tpruebas.Rows[0])["cuenta_contable"].ToString();
                }
                Tpruebas = CapaLogica.BuscarCuentas("I.G.V.", 5);
                if (Tpruebas.Rows.Count > 0)
                {
                    CuentaIgv = (Tpruebas.Rows[0])["idcuenta"].ToString();
                    NamecuentaIGV = (Tpruebas.Rows[0])["cuenta_contable"].ToString();
                }
                /////CALCULO DE LOS REFLEJOS
                TotalIgv = 0;
                foreach (DataGridViewRow item in Dtgconten.Rows)
                {
                    if (chkQuitarDetraccionaFactura.Checked)
                        if (item.Cells[xCuentaContable.Name].Value.ToString().Substring(0, 3) == "421")
                        {
                            DataRow fila = TDatos.NewRow();
                            fila[xDebeHaber.DataPropertyName] = item.Cells[xDebeHaber.Name].Value.ToString() == "D" ? "H" : "D";//Volteamos el debe o haber 
                            fila[xCuentaContable.DataPropertyName] = item.Cells[xCuentaContable.Name].Value.ToString().ToString();
                            fila[xdescripcion.DataPropertyName] = item.Cells[xdescripcion.Name].Value.ToString();
                            fila[xUsuario.DataPropertyName] = 999;///por defecto
                            fila[xGlosa.DataPropertyName] = glosa;
                            fila[xCodAsientoCtble.DataPropertyName] = cuo;
                            if ((int)cbomoneda.SelectedValue == 1)
                            {
                                fila[xImporteMN.DataPropertyName] = Redondear(decimal.Parse(txtmontodetraccion.Text));
                                fila[xImporteME.DataPropertyName] = Redondear(decimal.Parse(txtmontodetraccion.Text) / decimal.Parse(txttipocambio.Text));
                            }
                            if ((int)cbomoneda.SelectedValue == 2)
                            {
                                fila[xImporteME.DataPropertyName] = Redondear(decimal.Parse(txtmontodetraccion.Text));
                                fila[xImporteMN.DataPropertyName] = Redondear(decimal.Parse(txtmontodetraccion.Text) * decimal.Parse(txttipocambio.Text));
                            }
                            TDatos.Rows.Add(fila);
                        }
                    if (_TipoDoc == 0 || _TipoDoc == 3 || _TipoDoc == 1)
                    {
                        string CuentaContableAgregada = item.Cells[xCuentaContable.Name].Value.ToString();
                        string CuentaContableDescripcion = item.Cells[xdescripcion.Name].Value.ToString();
                        // if (item.Cells[xDebeHaber.Name].Value.ToString().ToUpper() == "D" || CuentaContableAgregada == "4221201")
                        {
                            //REFLEJOS
                            DataTable Tprueba = CapaLogica.CuentasReflejo(item.Cells[xCuentaContable.Name].Value.ToString());
                            if (Tprueba.Rows.Count > 0)
                            {
                                DataRow filita = Tprueba.Rows[0];
                                if (filita["reflejadebe"].ToString() != "")
                                {
                                    DataRow fila = CLonarCOlumnas(Dtgconten.Rows[item.Index], TDatos);
                                    fila[xDebeHaber.DataPropertyName] = fila["debehaber"].ToString(); //MANTIENE EL ORIGEN "D" O "H"
                                    fila[xCuentaContable.DataPropertyName] = filita["reflejadebe"].ToString();
                                    fila[xdescripcion.DataPropertyName] = filita["Namedebe"].ToString();
                                    fila[xUsuario.DataPropertyName] = 998;///por defecto
                                    fila[xCodAsientoCtble.DataPropertyName] = cuo;
                                    TDatos.Rows.Add(fila);
                                    DataRow xfila = CLonarCOlumnas(Dtgconten.Rows[item.Index], TDatos);
                                    xfila[xDebeHaber.DataPropertyName] = fila["debehaber"].ToString() == "D" ? "H" : "D";//Volteamos el debe o haber 
                                    xfila[xCuentaContable.DataPropertyName] = filita["reflejahaber"].ToString();
                                    xfila[xdescripcion.DataPropertyName] = filita["Namehaber"].ToString();
                                    xfila[xUsuario.DataPropertyName] = 998;///por defecto
                                    xfila[xCodAsientoCtble.DataPropertyName] = cuo;
                                    TDatos.Rows.Add(xfila);
                                }
                            }
                            //// FACTURA BOLETAS OTROS NOTA DEBITO
                            if (_TipoDoc != 1)
                                if (item.Cells[xTipoIgvg.Name].Value.ToString() != "4" && item.Cells[xTipoIgvg.Name].Value.ToString() != "")
                                {
                                    DataRow filaIgv = CLonarCOlumnas(Dtgconten.Rows[item.Index], TDatos);
                                    filaIgv[xDebeHaber.DataPropertyName] = item.Cells[xDebeHaber.Name].Value.ToString();
                                    filaIgv[xCuentaContable.DataPropertyName] = CuentaIgv;//.Substring(0, 7);
                                    filaIgv[xdescripcion.DataPropertyName] = NamecuentaIGV;
                                    filaIgv[xUsuario.DataPropertyName] = 999;///por defecto
                                    filaIgv[xImporteME.DataPropertyName] = Redondear(Redondear((decimal)item.Cells[xImporteME.Name].Value * (1 + igvs)) / (1 + igvs) * igvs);
                                    filaIgv[xImporteMN.DataPropertyName] = Redondear(Redondear((decimal)item.Cells[xImporteMN.Name].Value * (1 + igvs)) / (1 + igvs) * igvs);
                                    ///soles
                                    if ((int)cbomoneda.SelectedValue == 1)
                                        TotalIgv += (CuentaContableAgregada == "4221201" ? -1 : 1) * Redondear(Redondear((decimal)item.Cells[xImporteMN.Name].Value * (1 + igvs)) / (1 + igvs) * igvs);
                                    else TotalIgv += (CuentaContableAgregada == "4221201" ? -1 : 1) * Redondear(Redondear((decimal)item.Cells[xImporteME.Name].Value * (1 + igvs)) / (1 + igvs) * igvs);
                                    filaIgv[xCentroCosto.DataPropertyName] = "";
                                    filaIgv[xCentroCostoDesc.DataPropertyName] = "";
                                    filaIgv[xCodAsientoCtble.DataPropertyName] = cuo;
                                    TDatos.Rows.Add(filaIgv);
                                }
                        }
                    }
                    ////NOTA CREDITO 
                    if (_TipoDoc == 2)
                    {
                        //if (item.Cells[xDebeHaber.Name].Value.ToString().ToUpper() == "H")
                        {
                            DataTable Tprueba = CapaLogica.CuentasReflejo(item.Cells[xCuentaContable.Name].Value.ToString());
                            if (Tprueba.Rows.Count > 0)
                            {
                                DataRow filita = Tprueba.Rows[0];
                                if (filita["reflejadebe"].ToString() != "")
                                {
                                    DataRow fila = CLonarCOlumnas(Dtgconten.Rows[item.Index], TDatos);
                                    fila[xDebeHaber.DataPropertyName] = fila["debehaber"].ToString(); //MANTIENE EL ORIGEN "D" O "H"
                                    fila[xCuentaContable.DataPropertyName] = filita["reflejadebe"].ToString();
                                    fila[xdescripcion.DataPropertyName] = filita["Namedebe"].ToString();
                                    fila[xUsuario.DataPropertyName] = 998;///por defecto
                                    fila[xCodAsientoCtble.DataPropertyName] = cuo;
                                    TDatos.Rows.Add(fila);
                                    DataRow xfila = CLonarCOlumnas(Dtgconten.Rows[item.Index], TDatos);
                                    xfila[xDebeHaber.DataPropertyName] = fila["debehaber"].ToString() == "D" ? "H" : "D";//Volteamos el debe o haber 
                                    xfila[xCuentaContable.DataPropertyName] = filita["reflejahaber"].ToString();
                                    xfila[xdescripcion.DataPropertyName] = filita["Namehaber"].ToString();
                                    xfila[xUsuario.DataPropertyName] = 998;///por defecto
                                    xfila[xCodAsientoCtble.DataPropertyName] = cuo;
                                    TDatos.Rows.Add(xfila);
                                }
                            }
                            if ((item.Cells[xTipoIgvg.Name].Value.ToString() == "" ? 4 : (int)item.Cells[xTipoIgvg.Name].Value) != 4)
                            {
                                DataRow filaIgv = CLonarCOlumnas(Dtgconten.Rows[item.Index], TDatos);
                                filaIgv[xDebeHaber.DataPropertyName] = item.Cells[xDebeHaber.Name].Value.ToString();
                                filaIgv[xCuentaContable.DataPropertyName] = CuentaIgv;//.Substring(0, 7);
                                filaIgv[xdescripcion.DataPropertyName] = NamecuentaIGV;
                                filaIgv[xUsuario.DataPropertyName] = 999;///por defecto
                                filaIgv[xImporteME.DataPropertyName] = Redondear(Redondear((decimal)item.Cells[xImporteME.Name].Value * (1 + igvs)) / (1 + igvs) * igvs);
                                filaIgv[xImporteMN.DataPropertyName] = Redondear(Redondear((decimal)item.Cells[xImporteMN.Name].Value * (1 + igvs)) / (1 + igvs) * igvs);
                                ///soles
                                if ((int)cbomoneda.SelectedValue == 1)
                                    TotalIgv += Redondear(Redondear((decimal)item.Cells[xImporteMN.Name].Value * (1 + igvs)) / (1 + igvs) * igvs);
                                else TotalIgv += Redondear(Redondear((decimal)item.Cells[xImporteME.Name].Value * (1 + igvs)) / (1 + igvs) * igvs);
                                filaIgv[xCentroCosto.DataPropertyName] = "";
                                filaIgv[xCentroCostoDesc.DataPropertyName] = "";
                                filaIgv[xCodAsientoCtble.DataPropertyName] = cuo;
                                TDatos.Rows.Add(filaIgv);
                            }
                        }
                    }
                }
                ((DataTable)Dtgconten.DataSource).Merge(TDatos);
                /////CALCULO DE REDONDO
                decimal conme = 0, conmn = 0;
                foreach (DataGridViewRow item in Dtgconten.Rows)
                {
                    if (item.Cells[xDebeHaber.Name].Value.ToString().ToUpper() == "D")
                    {
                        //conme += Redondear(decimal.Parse(((decimal)item.Cells[xImporteME.Name].Value).ToString("n2")));
                        //conmn += Redondear(decimal.Parse(((decimal)item.Cells[xImporteMN.Name].Value).ToString("n2")));
                        conme += Redondear((decimal)item.Cells[xImporteME.Name].Value);
                        conmn += Redondear((decimal)item.Cells[xImporteMN.Name].Value);

                    }
                    if (item.Cells[xDebeHaber.Name].Value.ToString().ToUpper() == "H")
                    {
                        //conme -= Redondear(decimal.Parse(((decimal)item.Cells[xImporteME.Name].Value).ToString("n2")));
                        //conmn -= Redondear(decimal.Parse(((decimal)item.Cells[xImporteMN.Name].Value).ToString("n2")));
                        conme -= Redondear((decimal)item.Cells[xImporteME.Name].Value);
                        conmn -= Redondear((decimal)item.Cells[xImporteMN.Name].Value);
                    }
                }

                TDatos = TDatos.Clone();
                // Msg($"hay diferencia {conme}  :  {conmn}");
                if (conme != 0 || conmn != 0)
                {
                    string CuentaRedondeo = "";
                    string DH = "";
                    DataTable Tpruebass = new DataTable();
                    if ((conme > 0 && (int)cbomoneda.SelectedValue == 2) || (conmn > 0 && (int)cbomoneda.SelectedValue == 1))
                    {
                        //Tpruebass = CapaLogica.BuscarCuentas("INGRESOS POR REDONDEO", 5); ajuste por redondeo
                        Tpruebass = CapaLogica.BuscarCuentas("INGRESOS POR REDONDEO", 5);
                        DH = "H";
                    }
                    else if ((conme < 0 && (int)cbomoneda.SelectedValue == 2) || (conmn < 0 && (int)cbomoneda.SelectedValue == 1))
                    {
                        DH = "D";
                        //Tpruebass = CapaLogica.BuscarCuentas("PERDIDAS POR REDONDEO", 5);
                        Tpruebass = CapaLogica.BuscarCuentas("ajuste por redondeo", 5);
                    }
                    else if (conme > 0 || (conmn > 0))
                    {
                        //Tpruebass = CapaLogica.BuscarCuentas("INGRESOS POR REDONDEO", 5); ajuste por redondeo
                        Tpruebass = CapaLogica.BuscarCuentas("INGRESOS POR REDONDEO", 5);
                        DH = "H";
                    }
                    else if (conme < 0 || (conmn < 0))
                    {
                        DH = "D";
                        //Tpruebass = CapaLogica.BuscarCuentas("PERDIDAS POR REDONDEO", 5);
                        Tpruebass = CapaLogica.BuscarCuentas("ajuste por redondeo", 5);
                    }
                    if (Tpruebass.Rows.Count > 0)
                    {
                        CuentaRedondeo = (Tpruebass.Rows[0])["cuenta_contable"].ToString();
                    }
                    else
                    {
                        string resultado = "";
                        resultado = DH == "H" ? "Ingreso por redondeo" : "Ajuste por Redondeo";
                        msgError($"No se Encontro Cuenta de :{resultado}");
                    }
                    DataRow filita = Tpruebass.Rows[0];
                    DataRow fila = TDatos.NewRow();
                    fila[xDebeHaber.DataPropertyName] = DH;
                    fila[xCuentaContable.DataPropertyName] = filita["idcuenta"].ToString();//.Substring(0, 7);
                    fila[xdescripcion.DataPropertyName] = filita["cuenta_contable"].ToString();
                    fila[xUsuario.DataPropertyName] = 999;///por defecto
                    fila[xGlosa.DataPropertyName] = "Redondeo en registro";
                    fila[xCentroCosto.DataPropertyName] = "9999 - 999";
                    if (DH == "D")
                    {
                        fila[xImporteME.DataPropertyName] = (conme) * -1;
                        fila[xImporteMN.DataPropertyName] = (conmn) * -1;
                    }
                    else
                    {
                        fila[xImporteME.DataPropertyName] = (conme);
                        fila[xImporteMN.DataPropertyName] = (conmn);
                    }
                    fila[xCodAsientoCtble.DataPropertyName] = cuo;
                    TDatos.Rows.Add(fila);
                }
                ((DataTable)Dtgconten.DataSource).Merge(TDatos);
                btnAceptar.Enabled = true;
            }
            else
            {
                msgError("No hay Filas");
                btnAceptar.Enabled = true;
            }
        }
        public decimal Redondear(decimal valor) { return Math.Round(valor, 2); }
        public DataRow CLonarCOlumnas(DataGridViewRow rowcito, DataTable tabla)
        {
            DataRow filita = tabla.NewRow();
            int x = 0;
            foreach (DataGridViewCell item in rowcito.Cells)
            {
                filita[x] = item.Value; x++;
            }
            return filita;
        }
        private void txtmontodetraccion_TextChanged(object sender, EventArgs e)
        {
            if (Dtgconten.RowCount > 0) btnAceptar.Enabled = false;
            CalcularDiferenciaTOtalDetra();
        }

        private void Dtgconten_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            int x = e.RowIndex, y = e.ColumnIndex;
            try
            {
                if (x >= 0)
                {
                    DataGridViewRow R = Dtgconten.Rows[x];
                    if (R.Cells[xUsuario.Name].Value != null)
                        if ((R.Cells[xUsuario.Name].Value.ToString() == "" ? 0 : (int)R.Cells[xUsuario.Name].Value) >= 998)
                            Dtgconten.Rows[x].DefaultCellStyle.ForeColor = Color.FromArgb(192, 80, 77);
                        else Dtgconten.Rows[x].DefaultCellStyle.ForeColor = Color.FromArgb(0, 0, 192);
                }
            }
            catch (Exception) { }
            //int x = e.RowIndex, y = e.ColumnIndex;
            //try
            //{
            //    if ((Dtgconten[xUsuario.Name, y].Value.ToString() == "" ? 0 : (int)Dtgconten[xUsuario.Name, y].Value) >= 998)
            //        Dtgconten.Rows[x].DefaultCellStyle.ForeColor = Color.FromArgb(192, 80, 77);
            //    else Dtgconten.Rows[x].DefaultCellStyle.ForeColor = Color.Black;
            //}
            //catch (Exception) { }
        }
        private void borrarImagenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (msgp("Desea Eliminar la Imagen") == DialogResult.Yes)
            {
                imgfactura = null; frmimagen.Imagen = null;
            }
        }
        private void cmsImagen_Opening(object sender, CancelEventArgs e)
        {
            if (Estado == 1 || Estado == 2)
            {
                if (frmimagen.Imagen == null) { e.Cancel = true; }
            }
            else e.Cancel = true;
        }
        private void btnmodificar_EnabledChanged(object sender, EventArgs e)
        {
            btneliminar.Enabled = btnmodificar.Enabled;
        }
        private void btneliminar_Click(object sender, EventArgs e)
        {
            if (_TipoDoc == 0 || _TipoDoc == 1) OpcionBusqueda = 1;
            if (_TipoDoc == 2 || _TipoDoc == 3) OpcionBusqueda = 2;
            if (dtgBusqueda.RowCount > 0)
            {
                if (Dtgconten.RowCount == 0)
                {
                    if (msgp("Seguro Desea Eliminar Factura") == DialogResult.Yes)
                    {
                        CapaLogica.FacturaManualCabeceraRemover((int)dtgBusqueda[yid.Name, dtgBusqueda.CurrentRow.Index].Value, OpcionBusqueda == 1 ? 3 : 300);
                        msgOK("Eliminado Con Éxito");
                        textBoxPer2_TextChanged(sender, e);
                    }
                }
                else
                {
                    if (msgp("Seguro Desea Eliminar Factura con su Asiento") == DialogResult.Yes)
                    {
                        DataTable TPrueba1 = CapaLogica.VerFacturasPagadasCompras(txtruc.Text, txtcodfactura.Text + '-' + txtnrofactura.Text, (int)cbotipodoc.SelectedValue);
                        DataTable TPrueba2 = CapaLogica.VerPeriodoAbierto((int)cboempresa.SelectedValue, dtpFechaContable.Value);
                        if (TPrueba1.Rows.Count > 0)
                        {
                            msgError("La Factura ya tiene un Pago.");
                            return;
                        }
                        else if (TPrueba2.Rows.Count == 0)
                        {
                            msgError("La Factura Pertenece a un Periodo Cerrado.");
                            return;
                        }
                        if (OldCuo != null)
                        {
                            CapaLogica.EliminarAsiento(OldCuo, OldEmpresa, OldFechaContable, 1);
                            CapaLogica.FacturaManualCabeceraRemover((int)dtgBusqueda[yid.Name, dtgBusqueda.CurrentRow.Index].Value, OpcionBusqueda == 1 ? 3 : 300);
                            CapaLogica.FacturaManualDetalleRemover(txtcodfactura.Text + "-" + txtnrofactura.Text, txtruc.Text, OpcionBusqueda == 1 ? 3 : 300, (int)cbotipodoc.SelectedValue);
                            msgOK("Eliminado Con Éxito");
                            textBoxPer2_TextChanged(sender, e);
                        }
                    }
                }
            }
        }
        int _TipoDoc;
        private int _idComprobante;
        private void cbomoneda_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            txttotalfac_TextChanged(sender, e);
        }
        private void txtNumRef_TextChanged(object sender, EventArgs e)
        {
            if (Estado == 1 || Estado == 2)
                BusquedaDocReferencia();
        }
        private void txtSerieRef_TextChanged(object sender, EventArgs e)
        {
            if (Estado == 1 || Estado == 2)
                BusquedaDocReferencia();
        }
        private void btnaplicar_Click(object sender, EventArgs e)
        {
            string NumDocRef = txtSerieRef.Text + "-" + txtNumRef.Text;
            int opcion = 0;
            if (rdbAnulacion.Checked) opcion = 1;
            else if (rdbDescuento.Checked) opcion = 2;
            else opcion = 3;
            TFacRefDetalle = CapaLogica.BuscarFacturasManualesToNcNdDEtalle(opcion, txtruc.Text, NumDocRef);
            Dtgconten.DataSource = TFacRefDetalle;
            btnaplicar.Enabled = false;
        }
        private void rdbAnulacion_CheckedChanged(object sender, EventArgs e)
        {
            if (Encontrado == 1) btnaplicar.Enabled = true;
        }
        private void rdbDescuento_CheckedChanged(object sender, EventArgs e)
        {
            if (Encontrado == 1) btnaplicar.Enabled = true;
        }
        frmReportedeFacturas frmreporfactu;
        private void btnFacturasIncompletas_Click(object sender, EventArgs e)
        {
            if (frmreporfactu == null)
            {
                frmreporfactu = new frmReportedeFacturas();
                frmreporfactu.MdiParent = this.MdiParent;
                frmreporfactu.FormClosed += new FormClosedEventHandler(cerrarfacturasincompletas);
                frmreporfactu.Show();
            }
            else
            {
                frmreporfactu.Activate();
            }
        }
        private void cerrarfacturasincompletas(object sender, FormClosedEventArgs e)
        {
            frmreporfactu = null;
        }

        private void chkfac_CheckedChanged(object sender, EventArgs e)
        {
            if (Estado == 1 || Estado == 2)
            {
                cbomoneda.Enabled = false;
                cboempresa.Enabled = cboproyecto.Enabled = cboetapa.Enabled = false;
                PanelNotaCredito.Visible = true; //txttipocambio.Enabled = false;
                if (chkfac.Checked)
                {
                    cbomoneda.Enabled = cboempresa.Enabled = cboproyecto.Enabled = cboetapa.Enabled = txttipocambio.Enabled = true;
                }
                //if (chkDocAnulado.Checked)
                //    if (Dtgconten.RowCount == 0)
                //    {
                //        ((DataTable)Dtgconten.DataSource).Rows.Add();
                //        ((DataTable)Dtgconten.DataSource).Rows.Add();
                //        Dtgconten[xDebeHaber.Name, 0].Value = "D"; Dtgconten[xDebeHaber.Name, 1].Value = "H";
                //        Dtgconten[xCuentaContable.Name, 0].Value = "1212101"; Dtgconten[xCuentaContable.Name, 1].Value = "1212101";
                //        Dtgconten[xImporteMN.Name, 0].Value = 0.00; Dtgconten[xImporteME.Name, 0].Value = 0.00;
                //        Dtgconten[xImporteMN.Name, 1].Value = 0.00; Dtgconten[xImporteME.Name, 1].Value = 0.00;
                //        btnAceptar.Enabled = true;
                //    }
            }
        }

        private void cbocompensa_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtNombreUsuarioCompensa.Visible = cbotipoidcompensa.Visible = txtnumdocompensa.Visible = lblcompensa.Visible = btnbususuacompesa.Visible = false;
            if (cbocompensa.SelectedValue != null)
                if ((new int[] { 1, 2, 3 }).Contains((int)cbocompensa.SelectedValue))
                {
                    txtNombreUsuarioCompensa.Visible = cbotipoidcompensa.Visible = txtnumdocompensa.Visible = lblcompensa.Visible = btnbususuacompesa.Visible = true;
                    //frmListarEmpleados frmlistar = new frmListarEmpleados();
                    //frmlistar.Text = "Seleccione Empleado para el Reembolso";
                    //frmlistar.ShowDialog();
                }
        }
        private void btnbususuacompesa_Click(object sender, EventArgs e)
        {
            frmListarEmpleados frmlisempleado = new frmListarEmpleados();
            if (cbotipoidcompensa.SelectedValue == null) cbotipoidcompensa.SelectedIndex = 0;
            frmlisempleado.TipoDocumento = (int)cbotipoidcompensa.SelectedValue;
            frmlisempleado.NumeroDocumento = txtnumdocompensa.Text;
            frmlisempleado.Text = "Seleccione Empleado para el Desembolso";
            if (frmlisempleado.ShowDialog() == DialogResult.OK && Estado != 0)
            {
                cbotipoidcompensa.SelectedValue = frmlisempleado.TipoDocumento;
                txtnumdocompensa.Text = frmlisempleado.NumeroDocumento;
                BuscarEmpleado();
            }
        }
        public void BuscarEmpleado()
        {
            txtNombreUsuarioCompensa.Text = "";
            if (cbotipoidcompensa.SelectedValue != null)
            {
                DataRow Filita = CapaLogica.DatosEmpleado((int)cbotipoidcompensa.SelectedValue, txtnumdocompensa.Text);
                if (Filita != null)
                {
                    txtNombreUsuarioCompensa.Text = Configuraciones.MayusculaCadaPalabra($"{Filita["NOMBRES"]} {Filita["APELLIDOPATERNO"]} {Filita["APELLIDOMATERNO"]}").Trim();
                }
            }
        }
        private void txtnumdocompensa_TextChanged(object sender, EventArgs e)
        {
            BuscarEmpleado();
        }
        private void cbotipoidcompensa_SelectedIndexChanged(object sender, EventArgs e)
        {
            BuscarEmpleado();
        }

        private void copiarIgvToolStripMenuItem_Click(object sender, EventArgs e)
        {
            decimal calculoigv = 0;
            decimal.TryParse(txttotalfac.Text, out calculoigv);
            calculoigv = calculoigv / (1 + igvs);
            Clipboard.SetText(calculoigv.ToString("n2"));
        }
        private void copiarIgvToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            decimal calculoigv = 0;
            decimal.TryParse(txttotalfac.Text, out calculoigv);
            calculoigv = calculoigv / (1 + igvs) * igvs;
            Clipboard.SetText(calculoigv.ToString("n2"));
        }
        private void copiarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(txttotalfac.Text);
        }
        ModuloContable.frmAddFormato82 FormLlenadoFormato82;
        private void btnFormato82_Click(object sender, EventArgs e)
        {
            if (FormLlenadoFormato82 == null)
            {
                //bloqueo de botonoes
                dtgBusqueda.Enabled = false;
                //
                FormLlenadoFormato82 = new ModuloContable.frmAddFormato82();
                FormLlenadoFormato82.Empresa = (int)cboempresa.SelectedValue;
                FormLlenadoFormato82.SerieFac = txtcodfactura.Text;
                FormLlenadoFormato82.NumFac = txtnrofactura.Text;
                FormLlenadoFormato82.Periodo = dtpFechaContable.Value;
                FormLlenadoFormato82.AnioDua = dtpfecharecep.Value.Year;

                FormLlenadoFormato82.idComprobante = int.Parse(cbotipodoc.Text.Substring(0, 2));
                FormLlenadoFormato82.Ruc = txtruc.Text;
                //
                FormLlenadoFormato82.RazonSocial = txtrazon.Text;
                FormLlenadoFormato82.NameDocumento = cbotipodoc.Text;
                FormLlenadoFormato82.FormClosed += FormLlenadoFormato82_FormClosed;
                FormLlenadoFormato82.MdiParent = this.MdiParent;
                FormLlenadoFormato82.Show();
            }
            else FormLlenadoFormato82.Activate();
        }
        private void FormLlenadoFormato82_FormClosed(object sender, FormClosedEventArgs e)
        {
            FormLlenadoFormato82 = null;
            dtgBusqueda.Enabled = true;
        }

        private void txtglosa_TextChanged(object sender, EventArgs e)
        {
            if (txtglosa.TextValido().Length > 0)
            {
                foreach (DataGridViewRow Fila in Dtgconten.Rows)
                {
                    string FilaGLosa = (Fila.Cells[xGlosa.Name].Value ?? "").ToString();
                    if (FilaGLosa == "" || FilaGLosa == GlosaAnterior)
                    {
                        Fila.Cells[xGlosa.Name].Value = txtglosa.Text;
                    }
                }
                GlosaAnterior = txtglosa.TextValido();
            }
        }

        private void btnFormato_Click(object sender, EventArgs e)
        {
            SaveFileDialog SF = new SaveFileDialog();
            SF.Filter = "Archivos de Excel *.xlsx|*.xlsx";
            SF.FileName = "Formato de Carga de Compras";
            var result = SF.ShowDialog();
            if (result == DialogResult.OK)
            {
                File.WriteAllBytes(SF.FileName, Resource1.LISTADO_DE_COMPRAS);
                System.Diagnostics.Process.Start(SF.FileName);
            }
        }
        string ResultadoMasivoTXT = "";
        Boolean ProcesoMasivo = false;
        public DialogResult msgp(string cadena) { return HPResergerFunciones.frmPregunta.MostrarDialogYesCancel(cadena); }
        private void btnCargar_Click(object sender, EventArgs e)
        {
            OpenFileDialog openfile = new OpenFileDialog();
            openfile.Filter = "Archivos de Excel *.xlsx|*.xlsx";
            DialogResult resultado = openfile.ShowDialog();
            if (resultado == DialogResult.OK)
            {
                if (File.Exists(openfile.FileName))
                {
                    if (CargarDatosDelExcel(openfile.FileName))
                    {
                        //VALIDAMOS LAS CUENTAS y numeros de ruc
                        List<String> ListaCuentas = new List<string>();
                        List<String> ListaRuc = new List<string>();
                        string CuentaContable = "", CuentaContableFac = "", NroRuc = "";
                        ResultadoMasivoTXT = "";
                        string cadenaResultado = "";

                        int i = 0;
                        foreach (DataRow item in TdatosExcel.Rows)
                        {
                            if (i > 0)
                            {
                                CuentaContable = item[21].ToString().Trim();  //CUENTA CONTABLE
                                CuentaContableFac = item[24].ToString().Trim();  //CUENTA CONTABLE
                                NroRuc = item[7].ToString().Trim(); //RUC PROVEEDOR
                                if (!ListaCuentas.Contains(CuentaContable)) ListaCuentas.Add(CuentaContable);
                                if (!ListaCuentas.Contains(CuentaContableFac)) ListaCuentas.Add(CuentaContableFac);
                                if (!ListaRuc.Contains(NroRuc)) ListaRuc.Add(NroRuc);
                                //validamos importe vacios
                                item[60] = item[60].ToString() == "" ? 0.00 : item[60];
                                item[59] = item[59].ToString() == "" ? 0.00 : item[59];
                                //Validamos notas
                                if (int.Parse(item[3].ToString()) == 7)
                                {
                                    if (item[28].ToString() == "")
                                        cadenaResultado += $"En la Fila:{i + 1}, debe Registrar el Numero Documento Referencia";
                                }
                                //VALIDACION DE FECHAS
                                DateTime Fechaprueba;
                                if (!DateTime.TryParse(item[2].ToString(), out Fechaprueba)) cadenaResultado += $"La Fecha del Voucher en la Fila:{i + 1}, es Incorrecta";
                                if (!DateTime.TryParse(item[5].ToString(), out Fechaprueba)) cadenaResultado += $"La Fecha de Emisión. en la Fila:{i + 1}, es Incorrecta";
                                if (!DateTime.TryParse(item[6].ToString(), out Fechaprueba)) cadenaResultado += $"La Fecha Vencimiento en la Fila:{i + 1}, es Incorrecta";
                                //
                                item[55] = item[55].ToString() == "" ? "" : int.Parse(item[55].ToString()).ToString("000");
                            }
                            i++;
                        }
                        //fin de cargas de listas
                        foreach (string Cuenta in ListaCuentas)
                        {
                            if (CapaDatos.BuscarCuentasQuery(Cuenta).Rows.Count == 0)
                                cadenaResultado += $"No existe la cuenta: {Cuenta}\n";
                        }
                        foreach (string ruc in ListaRuc)
                        {
                            if (CapaDatos.BuscarProveedorQuery(ruc).Rows.Count == 0)
                                cadenaResultado += $"No existe el proveedor: {ruc}\n";
                        }
                        if (cadenaResultado != "")
                        {
                            string path = $"{Application.CommonAppDataPath}";
                            //if (File.Exists(path)) File.Delete(path);
                            path = Path.Combine(path, "Resultado.txt");
                            File.WriteAllText(path, cadenaResultado);
                            System.Diagnostics.Process.Start(path);
                        }
                        //SI CADENA RESULTADO ES IGUAL A VACIO, ES PORQUE SI EXISTEN LOS DATOS A CARGAR
                        else
                        {
                            if (msgYesCancel("Se Cargo el Excel con exito, Desea proceder con los Registros") == DialogResult.Yes)
                            {
                                ProcesoMasivo = true;
                                //PROCEDEMOS CON LA CARGA MASIVA
                                i = 0;
                                foreach (DataRow item in TdatosExcel.Rows)
                                {
                                    if (i > 0)
                                    {
                                        btnnuevo.PerformClick();
                                        //CARGA DE LA CABECERA
                                        cbodetraccion.Text = "NO";
                                        txtruc.Text = item[7].ToString().Trim();
                                        dtpFechaContable.Value = DateTime.Parse(item[2].ToString());
                                        dtpfecharecep.Value = dtpfechaemision.Value = DateTime.Parse(item[5].ToString());
                                        dtpfechavence.Value = DateTime.Parse(item[6].ToString());
                                        //valos de ingreso
                                        item[8] = item[8].ToString() == "" ? "0" : item[8].ToString();
                                        item[11] = item[11].ToString() == "" ? "0" : item[11].ToString();
                                        item[13] = item[13].ToString() == "" ? "0" : item[13].ToString();
                                        string[] Valr = item[4].ToString().Trim().Split('-');
                                        txtcodfactura.Text = Valr[0];
                                        txtnrofactura.Text = Valr[1];
                                        cbomoneda.SelectedIndex = item[18].ToString() == "MN" ? 0 : 1;
                                        cbotipodoc.SelectedValue = 1 + int.Parse(item[3].ToString());
                                        //
                                        txttotalfac.Text = (Math.Abs(decimal.Parse(item[8].ToString())) + Math.Abs(decimal.Parse(item[11].ToString())) + decimal.Parse(item[13].ToString())).ToString("n2");
                                        txtglosa.Text = item[20].ToString() == "" ? "CARGA MASIVA" : item[20].ToString();
                                        //LAS DETRACCIONES
                                        txtdescdetraccion.Text = ""; detrac = "";
                                        chkQuitarDetraccionaFactura.Checked = item[58].ToString() == "" ? false : true;
                                        CodDetracciones = item[55].ToString();
                                        cbodetraccion.Text = item[55].ToString() == "" ? "NO" : "SI";
                                        chkActivoFijo.Checked = item[21].ToString().Substring(0, 2) == "33" ? true : false;
                                        string NDebe = "D", NHaber = "H";
                                        //CARGA DEL DETALLE
                                        //CUENTA DE GASTO QUE GRABA IGV
                                        int pos = -1;
                                        btnAdd.PerformClick();
                                        if (decimal.Parse(item[8].ToString()) != 0)
                                        {
                                            pos++;
                                            TContenendor.Rows.Add(TContenendor.NewRow());
                                            if ((int)cbotipodoc.SelectedValue == 8) //LAS NOTAS VOLTEAN LOS ORIGENES
                                            {
                                                NDebe = "H";
                                                NHaber = "D";
                                                string[] Numref = item[28].ToString().Split('-');
                                                txtSerieRef.Text = Numref[0];
                                                txtNumRef.Text = Numref[1];
                                                chkfac.Checked = true;
                                            }
                                            Dtgconten.Rows[pos].Cells[xDebeHaber.Name].Value = NDebe;
                                            Dtgconten.Rows[pos].Cells[xGlosa.Name].Value = txtglosa.TextValido();
                                            Dtgconten.Rows[pos].Cells[xCuentaContable.Name].Value = item[21].ToString().Trim();
                                            if (item[18].ToString() == "ME")
                                            {
                                                Dtgconten.Rows[pos].Cells[xImporteME.Name].Value = Math.Abs(decimal.Parse(item[8].ToString()));
                                            }
                                            else
                                            {
                                                Dtgconten.Rows[pos].Cells[xImporteMN.Name].Value = Math.Abs(decimal.Parse(item[8].ToString()));
                                            }
                                            Dtgconten.Rows[pos].Cells[xTipoIgvg.Name].Value = decimal.Parse(item[13].ToString()) > 0 ? 1 : 4;
                                            TContenendor.AcceptChanges();
                                        }
                                        if (decimal.Parse(item[11].ToString()) != 0 || (decimal.Parse(item[11].ToString()) == 0 && decimal.Parse(item[8].ToString()) == 0))
                                        {
                                            TContenendor.Rows.Add(TContenendor.NewRow());
                                            pos++;
                                            if ((int)cbotipodoc.SelectedValue == 8) //LAS NOTAS VOLTEAN LOS ORIGENES
                                            {
                                                NDebe = "H";
                                                NHaber = "D";
                                                string[] Numref = item[28].ToString().Split('-');
                                                txtSerieRef.Text = Numref[0];
                                                txtNumRef.Text = Numref[1];
                                                chkfac.Checked = true;
                                            }
                                            Dtgconten.Rows[pos].Cells[xDebeHaber.Name].Value = NDebe;
                                            Dtgconten.Rows[pos].Cells[xGlosa.Name].Value = txtglosa.TextValido();
                                            Dtgconten.Rows[pos].Cells[xCuentaContable.Name].Value = item[21].ToString().Trim();
                                            if (item[18].ToString() == "ME")
                                            {
                                                Dtgconten.Rows[pos].Cells[xImporteME.Name].Value = Math.Abs(decimal.Parse(item[11].ToString()));
                                            }
                                            else
                                            {
                                                Dtgconten.Rows[pos].Cells[xImporteMN.Name].Value = Math.Abs(decimal.Parse(item[11].ToString()));
                                            }
                                            Dtgconten.Rows[pos].Cells[xTipoIgvg.Name].Value = 4;
                                            TContenendor.AcceptChanges();
                                        }
                                        //
                                        i++;
                                        pos++;
                                        btnAdd.PerformClick();
                                        TContenendor.Rows.Add(TContenendor.NewRow());
                                        Dtgconten.Rows[pos].Cells[xDebeHaber.Name].Value = NHaber;
                                        Dtgconten.Rows[pos].Cells[xGlosa.Name].Value = txtglosa.TextValido();
                                        Dtgconten.Rows[pos].Cells[xCuentaContable.Name].Value = item[24].ToString();
                                        if (item[pos].ToString() == "ME")
                                        {
                                            Dtgconten.Rows[pos].Cells[xImporteME.Name].Value = Math.Abs(decimal.Parse(item[8].ToString()) + decimal.Parse(item[13].ToString()) + decimal.Parse(item[11].ToString()));
                                        }
                                        else
                                        {
                                            Dtgconten.Rows[pos].Cells[xImporteMN.Name].Value = Math.Abs(decimal.Parse(item[8].ToString()) + decimal.Parse(item[13].ToString()) + decimal.Parse(item[11].ToString()));
                                        }
                                        TContenendor.AcceptChanges();
                                        //btnAdd.PerformClick();
                                        //TContenendor.AcceptChanges();
                                        btnvistaPrevia_Click(sender, e);
                                        //btnvistaPrevia.PerformClick();
                                        TContenendor.AcceptChanges();
                                        //Grabado
                                        btnAceptar.PerformClick();
                                        //return;
                                    }
                                    i++;
                                }
                            }
                            if (ResultadoMasivoTXT.Length > 0)
                            {
                                string path = $"{Application.CommonAppDataPath}";
                                //if (File.Exists(path)) File.Delete(path);
                                path = Path.Combine(path, $"Reporte Facturas Compras {DateTime.Now.ToString("dd-MM-yy")}.txt");

                                File.WriteAllText(path, ResultadoMasivoTXT);
                                System.Diagnostics.Process.Start(path);
                            }
                            ProcesoMasivo = false;
                            CargarDatos();
                        }
                    }
                    else
                    {
                        msgError("No se puedo Cargar el Excel");
                    }
                }
                else
                {
                    msgError("Hubo un Problema con el Archivo");
                }
            }
        }
        DataTable TdatosExcel;
        private int _Tipo;

        private Boolean CargarDatosDelExcel(string Ruta)
        {
            TdatosExcel = HPResergerFunciones.Utilitarios.CargarDatosDeExcelAGrilla(Ruta, 1, 6, 11);
            if (TdatosExcel.Rows.Count == 0)
            {
                return false;
            }
            return true;
            //List<string> Listado = new List<string>();
            //foreach (string item in HPResergerFunciones.Utilitarios.ListarHojasDeunExcel(Ruta))
            //{
            //    Listado.Add(item);
            //}
            //dtgconten.DataSource = HPResergerFunciones.Utilitarios.CargarDatosDeExcelAGrilla(Ruta, Listado[0].ToString());
        }

        private void chkIGV_CheckedChanged(object sender, EventArgs e)
        {
            if (chkIGV.Checked)
            {
                NumIGV.Enabled = true;
            }
            else
                NumIGV.Enabled = false;
        }
        private void cbotipodoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            PanelRecibo.Visible = false;
            PanelFactura.Visible = false;
            PanelNotaCredito.Visible = false;
            Dtgconten.Columns[xTipoIgvg.Name].Visible = true;
            txtSerieRef.ReadOnly = txtNumRef.ReadOnly = true;
            lblcompensacion.Visible = cbocompensa.Visible = true;
            chkfac.Enabled = false;
            rdbInteres.Visible = rdbDescuento.Visible = rdbAnulacion.Visible = btnaplicar.Visible = false;
            _TipoDoc = 0;
            if (Estado == 1 || Estado == 2)
            {
                cbomoneda.Enabled = true;
                cboempresa.Enabled = cboproyecto.Enabled = cboetapa.Enabled = true;
                txttipocambio.Enabled = true;
            }
            ////TIPODOC = 1 RECIBO, 0 FACTURAS-OTROS-BOLETAS,2 NOTA CREDITO,3 NOTA DEBITO
            if (cbotipodoc.Text.Substring(3) == "RECIBO POR HONORARIOS")
            {
                //txtrenta.Visible = true;
                //lblrenta.Visible = true;
                _TipoDoc = 1;
                Dtgconten.Columns[xTipoIgvg.Name].Visible = false;
                btnCargarFoto.Text = "&Foto Recibo";
                PanelRecibo.Visible = true;
                //txtglosa.Text = txtglosa.TextoDefecto = "Ingrese La Glosa del Recibo por Honorarios";
            }
            if (cbotipodoc.Text.Substring(3) == "FACTURA" || cbotipodoc.Text.Substring(3) == "OTROS" || cbotipodoc.Text.Substring(3) == "BOLETA DE VENTA")
            {
                _TipoDoc = 0;
                btnCargarFoto.Text = "&Foto Factura";
                PanelFactura.Visible = true;
                // txtglosa.Text = txtglosa.TextoDefecto = "Ingrese La Glosa de la Factura";
            }
            if (string.Compare("NOTA DE CREDITO", cbotipodoc.Text.Substring(3), System.Globalization.CultureInfo.CurrentCulture, System.Globalization.CompareOptions.IgnoreNonSpace) == 0)
            {
                btnCargarFoto.Text = "&Foto N.Crédit.";
                _TipoDoc = 2;
                //lblcompensacion.Visible = cbocompensa.Visible = false;
                cbomoneda.Enabled = false;
                //txtglosa.Text = txtglosa.TextoDefecto = "Ingrese La Glosa de la Nota de Crédito";
                cboempresa.Enabled = cboproyecto.Enabled = cboetapa.Enabled = false;
                PanelNotaCredito.Visible = true; txttipocambio.Enabled = false;
                if (Estado == 1 || Estado == 2)
                {
                    rdbDescuento.Visible = rdbAnulacion.Visible = btnaplicar.Visible = true;
                    rdbAnulacion.Checked = true;
                    txtSerieRef.ReadOnly = txtNumRef.ReadOnly = false;
                    chkfac.Enabled = true;
                }
            }
            if (string.Compare("NOTA DE DEBITO", cbotipodoc.Text.Substring(3), System.Globalization.CultureInfo.CurrentCulture, System.Globalization.CompareOptions.IgnoreNonSpace) == 0)
            {
                btnCargarFoto.Text = "&Foto N.Débito";
                _TipoDoc = 3;
                //lblcompensacion.Visible = cbocompensa.Visible = false;
                cbomoneda.Enabled = false;
                // txtglosa.Text = txtglosa.TextoDefecto = "Ingrese La Glosa de la Nota de Débito";
                cboempresa.Enabled = cboproyecto.Enabled = cboetapa.Enabled = false;
                txttipocambio.Enabled = false;
                PanelNotaCredito.Visible = true;
                if (Estado == 1 || Estado == 2)
                {
                    rdbInteres.Visible = btnaplicar.Visible = true;
                    rdbInteres.Checked = true;
                    txtSerieRef.ReadOnly = txtNumRef.ReadOnly = false;
                    chkfac.Enabled = true;
                }
            }
            txttipocambio.Enabled = true;
            btnCargarFoto.BringToFront();
        }
    }
}
