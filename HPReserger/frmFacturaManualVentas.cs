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
    public partial class frmFacturaManualVentas : FormGradient
    {
        public frmFacturaManualVentas()
        {
            InitializeComponent();
        }
        public decimal igvs { get; private set; }
        public int _PlazoPago { get; set; }
        public int _idempresa { get; set; }
        public int Estado { get; set; }
        public object _proyecto { get; set; }
        public int _etapa { get; set; }
        public string coddet { get; set; }
        public int _idFac { get; private set; }
        public decimal TotalIgv { get; private set; }
        public int TipoIdDoc { get { return (int)cbotipoid.SelectedValue; } set { cbotipoid.SelectedValue = value; } }
        HPResergerCapaLogica.HPResergerCL CapaLogica = new HPResergerCapaLogica.HPResergerCL();
        HPResergerCapaDatos.HPResergerCD CapaDatos = new HPResergerCapaDatos.HPResergerCD();
        public void msg(string cadena) { HPResergerFunciones.frmInformativo.MostrarDialogError(cadena); }
        public void msgOK(string cadena) { HPResergerFunciones.frmInformativo.MostrarDialog(cadena); }
        private void FacturaManualVentas_Load(object sender, EventArgs e)
        {
            Estado = 0; _idempresa = 0; _proyecto = 0; _etapa = 0; coddet = ""; TipoIdDoc = 1;
            CargarCombitoTipoid();
            CargarMoneda(); CargarTipoComprobante(); CargarDetracciones(); CargarEmpresa();
            CargarTablasDefecto();
            dtpFechaContable.Value = dtpfechaemision.Value = DateTime.Now;
            cbodetraccion.Text = "SI";
            ModoEdicion(false);
            LimpiarBusquedas();
            CargarDatos();
        }
        public void CargarCombitoTipoid()
        {
            cbotipoid.ValueMember = "codigo";
            cbotipoid.DisplayMember = "valor";
            cbotipoid.DataSource = CapaLogica.TiposID(0, 0, "", 0);
        }
        public void CargarDatos()
        {
            dtgBusqueda.DataSource = CapaLogica.FacturaManualVentaBusqueda(txtbusproveedor.TextValido(), txtbusnrodoc.TextValido(), txtbuscaempresa.TextValido());
            btnmodificar.Enabled = false;
            if (dtgBusqueda.RowCount > 0) btnmodificar.Enabled = true;
            else
            {
                Dtgconten.DataSource = CapaLogica.FacturaManualVentaDetalleBusqueda("", "", 0, 0);
                Limpiar();
            }
            DataRow Filon = CapaLogica.FacturaManualVentaBusquedaContadas();
            lblcontador.Text = $"Listado de Facturas Registradas: { dtgBusqueda.RowCount} / {Filon[0]} ";
        }
        public void LimpiarBusquedas()
        {
            txtbuscaempresa.CargarTextoporDefecto();
            txtbusnrodoc.CargarTextoporDefecto();
            txtbusproveedor.CargarTextoporDefecto();
        }
        public void ModoEdicion(Boolean a)
        {
            ////combobox
            cbotipoid.Enabled = cboempresa.Enabled = cboproyecto.Enabled = cboetapa.Enabled = cbodetraccion.Enabled = cbomoneda.Enabled = cbotipodoc.Enabled = a;
            ///textbox user
            txtdoc.ReadOnly = txttipocambio.ReadOnly = txttotalfac.ReadOnly = txtnrofactura.ReadOnly = txtcodfactura.ReadOnly = txtglosa.ReadOnly = !a;
            ///Botones
            btnCargarFoto.Enabled = btnbusproveedor.Enabled = btnAdd.Enabled = btnlimpiar.Enabled = a;
            ////checkbox
            chkDocAnulado.Enabled = a;
            //chkCompensa.Enabled = a;
            ///datetimepicker
            dtpFechaContable.Enabled = dtpfechaemision.Enabled = dtpfechavence.Enabled = a;
            ///////////////////
            btncleanfind.Enabled = !a;
            txtbusnrodoc.ReadOnly = txtbuscaempresa.ReadOnly = txtbusproveedor.ReadOnly = a;
            dtgBusqueda.Enabled = !a; Dtgconten.ReadOnly = !a;
            btnnuevo.Enabled = !a; btnmodificar.Enabled = !a;
            chkfac.Enabled = !a;
            //Cargar Masica
            btnCargar.Enabled = !a;
            btnFormato.Enabled = !a;
        }
        public void CargarEmpresa() { CapaLogica.TablaEmpresas(cboempresa); }
        public void CargarMoneda() { CapaLogica.TablaMoneda(cbomoneda); }
        public void CargarTipoComprobante() { CapaLogica.TablaComprobantesConCodigo(cbotipodoc); }
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
            TGrava.Rows.Add(4, "NGR");
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
        public DialogResult msgync(string cadena) { return HPResergerFunciones.frmPregunta.MostrarDialogYesNoCancel(cadena); }
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
            else msg("No hay Empresas");
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
            else msg("No Hay Proyectos");
        }

        private void btnbusproveedor_Click(object sender, EventArgs e)
        {
            frmClientes frmclien = new frmClientes();
            //frmclien.rdnrodoc.Checked = true;
            frmclien.codigoid = TipoIdDoc;
            frmclien.TipoDocBuscar = cbotipoid.Text;
            frmclien.CodigoDocBuscar = txtdoc.TextValido();
            frmclien.Buscando = true;
            if (frmclien.ShowDialog() == DialogResult.OK)
            {
                txtdoc.Text = frmclien.codigodoc;
                TipoIdDoc = frmclien.codigoid;
                txtdoc_TextChanged(sender, e);
            }
            frmclien = null;
        }
        DataTable TablaCLiente;
        private void txtdoc_TextChanged(object sender, EventArgs e)
        {
            TablaCLiente = CapaLogica.BuscarCliente(TipoIdDoc, txtdoc.TextValido());
            if (TablaCLiente.Rows.Count != 0)
            {
                DataRow filita = TablaCLiente.Rows[0];
                //txtapemat.Text = filita["Apemat_Cli"].ToString();
                //txtapetpat.Text = filita["Apepat_RazSoc_Cli"].ToString();
                //txtdireccion.Text = filita["Direccion"].ToString();
                //txtemail.Text = filita["E_mail"].ToString();
                txtrazon.Text = filita["apellidos"].ToString();
                //txtocupacion.Text = filita["Ocupacion"].ToString();
                //txttelcelular.Text = filita["Telf_Celular"].ToString();
                //txttelfijo.Text = filita["Telf_Fijo"].ToString();
                //txtubicacion.Text = $"{Configuraciones.MayusculaCadaPalabra(filita["Ddepartamento"].ToString())} - {Configuraciones.MayusculaCadaPalabra(filita["dprovincia"].ToString())} - {Configuraciones.MayusculaCadaPalabra(filita["ddistrito"].ToString())} ";

            }
            else txtrazon.CargarTextoporDefecto();
            if (Estado == 1 || Estado == 2) BusquedaDocReferencia();
        }
        private void LimpiarControlesEdicion(params object[] control)
        {
            foreach (object item in control)
            {
                if (!((TextBoxPer)item).EstaLLeno())
                {
                    //((TextBoxPer)item).Clear();
                    ((TextBoxPer)item).CargarTextoporDefecto();
                }
            }
        }

        private void btnnuevo_Click(object sender, EventArgs e)
        {
            //_IndicadorColumna = dtgBusqueda.CurrentCell == null ? 6 : dtgBusqueda.CurrentCell.ColumnIndex;
            if (dtgBusqueda.CurrentCell != null)
            {
                _IndicadorFila = dtgBusqueda.CurrentCell.RowIndex;
                _IndicadorColumna = dtgBusqueda.CurrentCell.ColumnIndex;
            }
            Estado = 1;
            ModoEdicion(true);
            Limpiar();
            if (Dtgconten.DataSource != null)
            {
                TContenendor = ((DataTable)Dtgconten.DataSource).Clone();
                Dtgconten.DataSource = TContenendor;
            }
            else
            {
                Dtgconten.DataSource = TContenendor;
                CapaLogica.FacturaManualVentaDetalleBusqueda("", "", 0, 0);
            }
            btnAceptar.Enabled = true;
            dtpfechaemision_ValueChanged(sender, e);
            cbotipodoc.Text = "BOLETA DE VENTA";
            cbomoneda.SelectedIndex = 0;
            cbodetraccion.Text = "SI";
            dtpfechavence.Value = DateTime.Now;
            BloquearColumnas();
            cbotipodoc_SelectedIndexChanged(sender, e);
            chkDocAnulado.Checked = false;
        }
        public byte[] imgfactura;
        MemoryStream _memoryStream = new MemoryStream();
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
            txtdoc.CargarTextoporDefecto();
            txtSerieRef.Text = txtNumRef.Text = "";
        }
        private void dtpfechaemision_ValueChanged(object sender, EventArgs e)
        {
            SacarTipoCambio();
            igvs = (decimal)(CapaLogica.ValorIGVactual(dtpfechaemision.Value))["Valor"];
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
        DataRow TiposId;
        public int LengthTipoId
        {
            get { return txtdoc.MaxLength; }
            set { txtdoc.MaxLength = value; }
        }
        public string OldCuo { get; set; }
        public int OldEmpresa { get; set; }
        public int OldProyecto { get; set; }
        public DateTime OldFechaContable { get; set; }
        public int OldId { get; set; }
        public string OldNumFac { get; private set; }
        public int OldIdComprobante { get; private set; }
        public string OldCliente { get; private set; }
        public int OldIdComprobanteSelect { get; private set; }
        public int NotasEstado { get; private set; }

        private void cbotipoid_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbotipoid.SelectedIndex >= 0)
            {
                TiposId = (CapaLogica.TiposID((int)cbotipoid.SelectedValue)).Rows[0]; ////Length
                LengthTipoId = (int)TiposId["Length"];
            }
            txtdoc_TextChanged(sender, e);
            if (Estado == 1 || Estado == 2) BusquedaDocReferencia();
        }
        private void cbotipoid_Click(object sender, EventArgs e)
        {
            if (cbotipoid.Items.Count > 0)
            {
                string cadena = cbotipoid.Text;
                cbotipoid.ValueMember = "codigo";
                cbotipoid.DisplayMember = "valor";
                cbotipoid.DataSource = CapaLogica.TiposID(0, 0, "", 0);
                cbotipoid.Text = cadena;
            }
        }
        private void btncancelar_Click(object sender, EventArgs e)
        {
            Dtgconten.AllowUserToAddRows = false;
            if (Estado != 0)
            {
                ModoEdicion(false);
                btnAceptar.Enabled = false;
                Limpiar();
                CargarDatos();
                if (Estado == 2 || Estado == 10 || Estado == 1)
                {
                    if (dtgBusqueda.RowCount < _IndicadorFila && dtgBusqueda.RowCount > 0)
                    {
                        _IndicadorFila = dtgBusqueda.RowCount - 1;
                        dtgBusqueda.CurrentCell = dtgBusqueda[_IndicadorColumna, _IndicadorFila];
                    }
                }
                Estado = 0;
                cbotipodoc_SelectedIndexChanged(sender, e);
            }
            else Close();
            Estado = 0; btnvistaPrevia.Visible = false;
        }

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
        public void OcultarDetraccion(Boolean a)
        {
            //lblporcentajedetraccion.Enabled = a;
            numdetraccion.Enabled = a;
            //txtdetraccion.Enabled = a;
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
                if (txtdescdetraccion.Text == "")
                {
                    DataRow filaS = CapaLogica.BuscarParametros("%DETRACCION VENTA%", dtpfechaemision.Value);
                    if (filaS != null)
                    {
                        string resul = filaS["Observacion"].ToString();
                        ////Fracionador
                        string[] div = resul.Split('-');
                        coddet = div[0].ToString();
                        txtdescdetraccion.Text = div[1].ToString();
                        numdetraccion.Value = ((decimal)filaS["Valor"]) * 100;
                        if (!string.IsNullOrWhiteSpace(txttotalfac.Text))
                            detracion = decimal.Parse(txttotalfac.Text.ToString()) * (numdetraccion.Value / 100);
                    }
                }
                if (txtdescdetraccion.Text != "")
                {
                    DataView dv = DatosDetracciones.AsDataView();
                    dv.RowFilter = $"desc_detraccion='{txtdescdetraccion.Text}'";
                    if (dv.Count != 0)
                    {
                        numdetraccion.Value = (decimal)dv[0]["porcentaje"];
                        coddet = dv[0]["cod_detraccion"].ToString();
                        if (!string.IsNullOrWhiteSpace(txttotalfac.Text))
                            detracion = decimal.Parse(txttotalfac.Text.ToString()) * (numdetraccion.Value / 100);
                    }
                }
                numdetraccion.Enabled = false;
                txtmontodetraccion.Text = detracion.ToString("n2");
                if (Estado == 1 || Estado == 2 || Estado == 10)
                    btnmasdetracion.Enabled = true;
                else btnmasdetracion.Enabled = false;
            }
            else
            {
                OcultarDetraccion(false);
                btnmasdetracion.Enabled = false;
                numdetraccion.Value = 0;
                txtdescdetraccion.Text = "NO APLICA";
                txtmontodetraccion.Text = "0.00";
                coddet = "000";
            }
            //if (cbograba.Text.ToString().ToUpper() == "GRAVA")
            //{
            //    Dtgconten.Columns[xTipoIgvng.Name].Visible = false;
            //}
            //if (cbograba.Text.ToString().ToUpper() == "NO GRAVA")
            //{
            //    Dtgconten.Columns[xTipoIgvg.Name].Visible = false;
            //    foreach (DataGridViewRow item in Dtgconten.Rows)
            //        item.Cells[xTipoIgvng.Name].Value = 4;
            //}            
            if (Dtgconten.RowCount > 0) btnAceptar.Enabled = false;
            txtmontodetraccion.Text = (decimal.Parse(txtmontodetraccion.Text)).ToString(txtmontodetraccion.Format);
        }
        public DialogResult msgp(string cadena) { return HPResergerFunciones.frmPregunta.MostrarDialogYesCancel(cadena); }
        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            if (msgp("Eliminar Todas Las Filas") == DialogResult.Yes)
                ((DataTable)Dtgconten.DataSource).Clear();
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
            //    DataRow factura = CapaLogica.BuscarFacturasVentas($"{txtcodfactura.Text}-{txtnrofactura.Text}");
            //    if (factura != null)
            //    {
            //        Msg("Nro Factura ya Existe");
            //    }
            //}
        }
        private void txtnrofactura_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Back)
                if (txtnrofactura.Text.Length == 0)
                    txtcodfactura.Focus();
        }
        int FacturaEstado = 0;
        int OpcionBusqueda = 0;
        string NumFac = "";
        string NumFacRef = "";
        int[] ListaIdNotas = { 8, 9 };
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (Estado == 10)
            {
                CapaLogica.FacturaManualVentaCabecera(_idFac, imgfactura, (int)cbotipoid.SelectedValue, cbotipoid.SelectedValue.ToString() + txtdoc.Text);
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
                        BusquedaDocReferencia(); btnaplicar.Enabled = false; if (Encontrado == 0) { msg("El Documento de Referencia no se ha Encontrado"); return; }
                    }
                }
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
                    msg("El Periodo Esta Cerrado, Cambie Fecha Contable"); dtpFechaContable.Focus(); return;
                }
                ////Verificamos si el periodo esta Abierto
                //DataTable TPrueba2 = CapaLogica.VerPeriodoAbierto((int)cboempresa.SelectedValue, dtpFechaContable.Value);
                //if (TPrueba2.Rows.Count == 0) { msg("El Periodo está Cerrado cambie la Fecha Contable"); dtpFechaContable.Focus(); return; }
                if (cboempresa.Items.Count == 0) { msg("No hay Empresa"); cboempresa.Focus(); return; }
                if (cboproyecto.Items.Count == 0) { msg("No hay Proyecto"); cboproyecto.Focus(); return; }
                if (cboetapa.Items.Count == 0) { msg("No hay Etapa"); cboetapa.Focus(); return; }
                if (cbomoneda.Items.Count == 0) { msg("No hay Moneda"); cbomoneda.Focus(); return; }
                if (cbotipodoc.Items.Count == 0) { msg("No hay Tipo Comprobante"); cbotipodoc.Focus(); return; }
                if (cbotipoid.Items.Count == 0) { msg("No hay Tipo Documento"); cbotipoid.Focus(); return; }
                if (txtcodfactura.Text.Length == 0) { msg($"Ingrese Codigo de {cbotipodoc.Text}"); txtcodfactura.Focus(); return; }
                if (txtnrofactura.Text.Length == 0) { msg($"Ingrese Número de {cbotipodoc.Text}"); txtnrofactura.Focus(); return; }
                if (!chkDocAnulado.Checked) if (!txttotalfac.EstaLLeno()) { msg("Ingrese Total del Comprobante"); txttotalfac.Focus(); return; }
                if (decimal.Parse(txttipocambio.TextValido()) == 0) { msg("El Tipo de Cambio debe ser Mayor a Cero"); txttipocambio.Focus(); return; }
                if (chkDocAnulado.Checked) { if (txttotalfac.EstaLLeno()) { msg("El Total del Comprobante debe ser Cero"); txttotalfac.Focus(); return; } }
                if (!txtdoc.EstaLLeno()) { msg("Ingrese Nro.Doc. del Cliente"); txtdoc.Focus(); return; }
                if (cbodetraccion.Text == "SI") if (!txtdescdetraccion.EstaLLeno()) { msg("Seleccione la Detracción"); cbodetraccion.Focus(); return; }
                if (!txtrazon.EstaLLeno()) { msg("No se Encontro Nombre del Cliente"); txtdoc.Focus(); return; }
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
                    if (errorc || ErrorDH) { msg(cadena); return; }
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
                        if (OldFechaContable.Month == dtpFechaContable.Value.Month && OldFechaContable.Year == dtpFechaContable.Value.Year)
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
            ///fin de revision de la modificacion
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
            /////los estados
            if (Estado == 1)
            {
                /////VALIDO SI EXISTE LA FACTURA            
                DataTable Tprueba = CapaLogica.FacturaManualVentaCabecera(txtcodfactura.Text + "-" + txtnrofactura.Text, OpcionBusqueda, (int)cboempresa.SelectedValue, (int)cbotipodoc.SelectedValue);
                if (Tprueba.Rows.Count > 0) { msg("Ya Existe esta Factura de Venta Registrada"); return; }
                /////INSERTANDO LA FACTURA
                CapaLogica.FacturaManualVentaCabecera(OpcionBusqueda == 1 ? 1 : 100, 0, (int)cbotipodoc.SelectedValue, NumFac, NumFacRef, (int)cbotipoid.SelectedValue, txtdoc.Text, (int)cboempresa.SelectedValue, (int)cboproyecto.SelectedValue, (int)cboetapa.SelectedValue, (int)cbomoneda.SelectedValue,
                    decimal.Parse(txttipocambio.Text), decimal.Parse(txttotalfac.Text), TotalIgv, dtpfechaemision.Value, dtpfechavence.Value, dtpFechaContable.Value, FacturaEstado, 0, "", cbodetraccion.Text == "NO" ? "" : coddet, numdetraccion.Value,
                    decimal.Parse(txtmontodetraccion.Text), imgfactura, txtglosa.TextValido(), frmLogin.CodigoUsuario);
                ////INSERTANDO EL DETALLE DE LA FACTURA
                foreach (DataGridViewRow item in Dtgconten.Rows)
                {
                    int usua; if (item.Cells[xUsuario.Name].Value.ToString() == "999" || item.Cells[xUsuario.Name].Value.ToString() == "998") usua = 999; else usua = frmLogin.CodigoUsuario;
                    CapaLogica.FacturaManualVentaDetalle(1, 0, (int)cbotipodoc.SelectedValue, txtcodfactura.Text + "-" + txtnrofactura.Text, (int)cbotipoid.SelectedValue, txtdoc.Text, item.Cells[xDebeHaber.Name].Value.ToString(),
                        item.Cells[xCuentaContable.Name].Value.ToString(), item.Cells[xTipoIgvg.Name].Value.ToString() == "" ? 0 : (int)item.Cells[xTipoIgvg.Name].Value, (decimal)item.Cells[xImporteMN.Name].Value, (decimal)item.Cells[xImporteME.Name].Value, item.Cells[xGlosa.Name].Value.ToString(), cuo, usua, (int)cboempresa.SelectedValue);
                }
                ////INSERTAR ASIENTO DE CABECERA Y DETALLE
                int i = 1;
                foreach (DataGridViewRow item in Dtgconten.Rows)
                {
                    if (item.Cells[xUsuario.Name].Value.ToString() != "998")
                    {
                        double vdebe = 0, vhaber = 0;
                        if (item.Cells[xDebeHaber.Name].Value.ToString() == "D") vdebe = double.Parse(((int)cbomoneda.SelectedValue) == 1 ? item.Cells[xImporteMN.Name].Value.ToString() : item.Cells[xImporteME.Name].Value.ToString());
                        if (item.Cells[xDebeHaber.Name].Value.ToString() == "H") vhaber = double.Parse(((int)cbomoneda.SelectedValue) == 1 ? item.Cells[xImporteMN.Name].Value.ToString() : item.Cells[xImporteME.Name].Value.ToString());
                        CapaLogica.InsertarAsiento(i, codigo, dtpfechaemision.Value, item.Cells[xCuentaContable.Name].Value.ToString(), vdebe, vhaber, -5, 1, dtpFechaContable.Value, (int)cboproyecto.SelectedValue, (int)cboetapa.SelectedValue, txtglosa.TextValido(), (int)cbomoneda.SelectedValue, decimal.Parse(txttipocambio.Text));
                        ////DETALLE ASIENTO    

                        int TIPOID = (int)cbotipoid.SelectedValue;
                        string RUC = txtdoc.Text;
                        string RAZON = txtrazon.Text;
                        string CUENTA = item.Cells[xCuentaContable.Name].Value.ToString();

                        if (CuentaNiubiz == CUENTA)
                        {
                            TIPOID = 5;
                            RUC = rucNiubiz;
                            RAZON = RazonNiubiz;
                        }

                        CapaLogica.DetalleAsientos(1, i, codigo, CUENTA, TIPOID, RUC, RAZON, (int)cbotipodoc.SelectedValue,/* OpcionBusqueda == 1 ?*/ txtcodfactura.Text/* : txtSerieRef.Text*/,/* OpcionBusqueda == 1 ?*/ txtnrofactura.Text /*: txtNumRef.Text*/,
                        0, item.Cells[xGlosa.Name].Value.ToString(), dtpfechaemision.Value, dtpfechavence.Value, (decimal)item.Cells[xImporteMN.Name].Value, (decimal)item.Cells[xImporteME.Name].Value,
                        decimal.Parse(txttipocambio.Text), frmLogin.CodigoUsuario, (int)cboproyecto.SelectedValue, dtpfechaemision.Value, (int)cbomoneda.SelectedValue, dtpFechaContable.Value, 0, "", VoucherPago, TipoPago);
                        ////contador para next valor
                        i++;
                    }
                }
                if (!ProcesoMasivo)
                    if (FacturaEstado == 0) msgOK($"Factura de Venta Guardada Con Éxito"); else msgOK($"Factura de Venta Guardada \nGenerado sus Asiento : {cuo} \nCon Éxito");
                else
                    ResultadoMasivoTXT += $"Documento Guardado:{cboempresa.Text};Ruc:{txtdoc.Text} Comprobante:{txtcodfactura.Text}-{txtnrofactura.Text}  Generado sus Asiento:{ cuo} \n";
            }
            //////ACTUALIZANDO
            if (Estado == 2)
            {
                /////VALIDO SI YA EXISTE LA FACTURA               
                DataTable Tprueba = CapaLogica.FacturaManualVentaCabecera(txtcodfactura.Text + "-" + txtnrofactura.Text, _idFac, OpcionBusqueda, (int)cboempresa.SelectedValue, (int)cbotipodoc.SelectedValue);
                if (Tprueba.Rows.Count > 0) { msg("Ya Existe esta Factura Registrada"); return; }
                //////ACTUALIZANDO LA FACTURA
                Boolean ResultOld = ListaIdNotas.Contains(OldIdComprobanteSelect);
                Boolean ResultNew = ListaIdNotas.Contains((int)cbotipodoc.SelectedValue);
                if (ResultOld != ResultNew)
                {
                    //Elimino la Cabecera Anterior
                    CapaLogica.FacturaManualVentaCabeceraRemover((int)dtgBusqueda[yid.Name, dtgBusqueda.CurrentRow.Index].Value, !ResultOld ? 3 : 300, OldIdComprobanteSelect, OldCliente);
                    //Inserto un Nuevo Registro
                    CapaLogica.FacturaManualVentaCabecera(OpcionBusqueda == 1 ? 1 : 100, 0, (int)cbotipodoc.SelectedValue, NumFac, NumFacRef, (int)cbotipoid.SelectedValue, txtdoc.Text, (int)cboempresa.SelectedValue, (int)cboproyecto.SelectedValue, (int)cboetapa.SelectedValue, (int)cbomoneda.SelectedValue,
                        decimal.Parse(txttipocambio.Text), decimal.Parse(txttotalfac.Text), TotalIgv, dtpfechaemision.Value, dtpfechavence.Value, dtpFechaContable.Value, OpcionBusqueda == 1 ? FacturaEstado : NotasEstado == 2 ? 2 : FacturaEstado, 0, "", cbodetraccion.Text == "NO" ? "" : coddet, numdetraccion.Value,
                        decimal.Parse(txtmontodetraccion.Text), imgfactura, txtglosa.TextValido(), frmLogin.CodigoUsuario);
                }
                else
                    CapaLogica.FacturaManualVentaCabecera(OpcionBusqueda == 1 ? 2 : 200, _idFac, (int)cbotipodoc.SelectedValue, NumFac, NumFacRef, (int)cbotipoid.SelectedValue, txtdoc.Text, (int)cboempresa.SelectedValue, (int)cboproyecto.SelectedValue, (int)cboetapa.SelectedValue, (int)cbomoneda.SelectedValue,
                        decimal.Parse(txttipocambio.Text), decimal.Parse(txttotalfac.Text), TotalIgv, dtpfechaemision.Value, dtpfechavence.Value, dtpFechaContable.Value, OpcionBusqueda == 1 ? FacturaEstado : NotasEstado == 2 ? 2 : FacturaEstado, 0, "", cbodetraccion.Text == "NO" ? "" : coddet, numdetraccion.Value,
                        decimal.Parse(txtmontodetraccion.Text), imgfactura, txtglosa.TextValido(), frmLogin.CodigoUsuario);

                ///BORRAMOS LOS DATOS ANTERIOES
                if (OldCuo != null)
                    CapaLogica.FacturaManualVentaDetalleRemover(OldNumFac, OldEmpresa, OpcionBusqueda == 1 ? 3 : 300, OldIdComprobanteSelect, OldCliente);
                ////INSERTANDO EL DETALLE DE LA FACTURA
                foreach (DataGridViewRow item in Dtgconten.Rows)
                {
                    int usua; if (item.Cells[xUsuario.Name].Value.ToString() == "999" || item.Cells[xUsuario.Name].Value.ToString() == "998") usua = 999; else usua = frmLogin.CodigoUsuario;
                    CapaLogica.FacturaManualVentaDetalle(1, 0, (int)cbotipodoc.SelectedValue, txtcodfactura.Text + "-" + txtnrofactura.Text, (int)cbotipoid.SelectedValue, txtdoc.Text, item.Cells[xDebeHaber.Name].Value.ToString(),
                        item.Cells[xCuentaContable.Name].Value.ToString(), item.Cells[xTipoIgvg.Name].Value.ToString() == "" ? 0 : (int)item.Cells[xTipoIgvg.Name].Value,
                     (decimal)item.Cells[xImporteMN.Name].Value, (decimal)item.Cells[xImporteME.Name].Value, item.Cells[xGlosa.Name].Value.ToString(), cuo, usua, (int)cboempresa.SelectedValue);
                }
                ////INSERTAR ASIENTO DE CABECERA Y DETALLE 
                int i = 1;
                foreach (DataGridViewRow item in Dtgconten.Rows)
                {
                    if (item.Cells[xUsuario.Name].Value.ToString() != "998")
                    {

                        double vdebe = 0, vhaber = 0;
                        if (item.Cells[xDebeHaber.Name].Value.ToString() == "D") vdebe = double.Parse(((int)cbomoneda.SelectedValue) == 1 ? item.Cells[xImporteMN.Name].Value.ToString() : item.Cells[xImporteME.Name].Value.ToString());
                        if (item.Cells[xDebeHaber.Name].Value.ToString() == "H") vhaber = double.Parse(((int)cbomoneda.SelectedValue) == 1 ? item.Cells[xImporteMN.Name].Value.ToString() : item.Cells[xImporteME.Name].Value.ToString());
                        CapaLogica.InsertarAsiento(i, codigo, dtpfechaemision.Value, item.Cells[xCuentaContable.Name].Value.ToString(), vdebe, vhaber, -5, 1, dtpFechaContable.Value, (int)cboproyecto.SelectedValue, (int)cboetapa.SelectedValue, txtglosa.TextValido(), (int)cbomoneda.SelectedValue, decimal.Parse(txttipocambio.Text));
                        ////DETALLE ASIENTO  

                        int TIPOID = (int)cbotipoid.SelectedValue;
                        string RUC = txtdoc.Text;
                        string RAZON = txtrazon.Text;
                        string CUENTA = item.Cells[xCuentaContable.Name].Value.ToString();

                        if (CuentaNiubiz == CUENTA)
                        {
                            TIPOID = 5;
                            RUC = rucNiubiz;
                            RAZON = RazonNiubiz;
                        }


                        CapaLogica.DetalleAsientos(1, i, codigo, CUENTA, TIPOID, RUC, RAZON, (int)cbotipodoc.SelectedValue, /*OpcionBusqueda == 1 ? */txtcodfactura.Text /*: txtSerieRef.Text*/, /*OpcionBusqueda == 1 ? */txtnrofactura.Text /*: txtNumRef.Text*/,
                       0, item.Cells[xGlosa.Name].Value.ToString(), dtpfechaemision.Value, dtpfechavence.Value, (decimal)item.Cells[xImporteMN.Name].Value, (decimal)item.Cells[xImporteME.Name].Value,
                        decimal.Parse(txttipocambio.Text), frmLogin.CodigoUsuario, (int)cboproyecto.SelectedValue, dtpfechaemision.Value, (int)cbomoneda.SelectedValue, dtpFechaContable.Value, 0, "", "", 0);
                        ////contador para next valor
                        i++;
                    }
                }
                if (FacturaEstado == 0) msgOK($"Factura Venta Actualizada Con Éxito"); else msgOK($"Factura Venta Actualizada \nGenerado sus Asiento : {cuo} \nCon Éxito");
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
                        if (dtgBusqueda.CurrentCell.RowIndex != item.Index)
                            dtgBusqueda.CurrentCell = dtgBusqueda[_IndicadorColumna, item.Index];
                        break;
                    }
                }
            }
            Estado = 0;
            cbotipodoc_SelectedIndexChanged(sender, e);
        }
        private void btncleanfind_Click(object sender, EventArgs e)
        {
            LimpiarBusquedas();
        }

        private void txtbusproveedor_TextChanged(object sender, EventArgs e)
        {
            txtbusnrodoc.Text = txtbusnrodoc.Text.Replace("\t", "-");
            //CargarDatos();
        }

        private void dtgBusqueda_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            int x = e.RowIndex, y = e.ColumnIndex;
            if (x >= 0)
            {
                DataGridViewRow R = dtgBusqueda.Rows[x];
                _idFac = (int)R.Cells[yid.Name].Value;
                /////datos de la empresa            
                cboempresa.SelectedValue = (int)R.Cells[yfkempresa.Name].Value;
                cboproyecto.SelectedValue = (int)R.Cells[yfkproyecto.Name].Value;
                cboetapa.SelectedValue = (int)R.Cells[yfkEtapa.Name].Value;
                ///datos de proveedor
                txtdoc.Text = R.Cells[ynroid.Name].Value.ToString();
                cbotipoid.SelectedValue = (int)R.Cells[ytipoid.Name].Value;
                ///datos de la factura
                cbotipodoc.SelectedValue = (int)R.Cells[yIdComprobante.Name].Value;
                string[] CodNrofac = R.Cells[yNroComprobante.Name].Value.ToString().Split('-'); txtcodfactura.Text = CodNrofac[0]; txtnrofactura.Text = CodNrofac[1];
                dtpfechaemision.Value = (DateTime)R.Cells[yFechaEmision.Name].Value;
                dtpfechavence.Value = (DateTime)R.Cells[yFechaVencimiento.Name].Value;
                dtpFechaContable.Value = (DateTime)R.Cells[yfechacontable.Name].Value;
                txtglosa.Text = R.Cells[yGlosa.Name].Value.ToString();
                cbomoneda.SelectedValue = (int)R.Cells[yfkMoneda.Name].Value;
                txttipocambio.Text = ((decimal)R.Cells[yTC.Name].Value).ToString("n3");
                txttotalfac.Text = ((decimal)R.Cells[yTotal.Name].Value).ToString("n2");
                if (!txttotalfac.EstaLLeno()) chkDocAnulado.Checked = true; else chkDocAnulado.Checked = false;
                TotalIgv = (decimal)R.Cells[yigv.Name].Value;
                string[] CodNroFacRef;
                string NumFacRefe = R.Cells[yNroComprobanteRef.Name].Value.ToString();
                if (NumFacRefe != "")
                {
                    CodNroFacRef = R.Cells[yNroComprobanteRef.Name].Value.ToString().Split('-'); txtSerieRef.Text = CodNroFacRef[0]; txtNumRef.Text = CodNroFacRef[1];
                }
                /////CARGAR IMAGEN DE LA FACTURA               
                DataTable TImagen = CapaLogica.BuscarImagenFacturasCompras((int)cbotipoid.SelectedValue + txtdoc.Text, txtcodfactura.Text + "-" + txtnrofactura.Text, NumFacRefe == "" ? 1 : 2, 2, (int)cboempresa.SelectedValue, (int)cbotipodoc.SelectedValue);
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
                        txtdescdetraccion.Text = filaS[0]["Desc_Detraccion"].ToString();
                        coddet = filaS[0]["Cod_Detraccion"].ToString();
                        //numdetraccion.Value = cbodetraccion.SelectedValue == null ? 0.0m : (decimal)cbodetraccion.SelectedValue;
                        numdetraccion.Value = Convert.ToDecimal(filaS[0]["Porcentaje"].ToString());
                        if (!string.IsNullOrWhiteSpace(txttotalfac.Text))
                            detracion = decimal.Parse(txttotalfac.Text.ToString()) * (numdetraccion.Value / 100);
                    }
                    numdetraccion.Enabled = false;
                    txtmontodetraccion.Text = detracion.ToString("n2");

                }
                txtmontodetraccion.Text = R.Cells[yDetraccion.Name].Value.ToString();
                //////CARGA DEL DETALLE DE LA FACTURA MANUAL
                Dtgconten.DataSource = CapaLogica.FacturaManualVentaDetalleBusqueda("", R.Cells[yNroComprobante.Name].Value.ToString(), (int)R.Cells[yfkempresa.Name].Value, (int)R.Cells[yIdComprobante.Name].Value);
                if (Dtgconten.RowCount > 0)
                {
                    OldCuo = Dtgconten[xCodAsientoCtble.Name, 0].Value.ToString();
                    OldEmpresa = (int)R.Cells[yfkempresa.Name].Value;
                    OldProyecto = (int)R.Cells[yfkproyecto.Name].Value;
                    OldFechaContable = (DateTime)R.Cells[yfechacontable.Name].Value;
                    OldId = (int)R.Cells[yid.Name].Value;
                    OldNumFac = txtcodfactura.Text + "-" + txtnrofactura.Text;
                    OldCliente = (int)cbotipoid.SelectedValue + "-" + txtdoc.Text;
                    OldIdComprobante = (int)cbotipodoc.SelectedValue;
                }
                else OldCuo = null;
            }
        }
        public void BloquearColumnas()
        {
            foreach (DataGridViewColumn item in Dtgconten.Columns)
            {
                var x = item.Name;
                if (x == xdescripcion.Name || x == xCodAsientoCtble.Name)
                    item.ReadOnly = true;
            }
            ///disparado
            cbomoneda_SelectedValueChanged(new object(), new EventArgs());
        }
        public void ModoEdicionFoto(Boolean a)
        {
            dtgBusqueda.Enabled = !a;
            txtbuscaempresa.ReadOnly = txtbusnrodoc.ReadOnly = txtbusproveedor.ReadOnly = a;
            btncleanfind.Enabled = btnnuevo.Enabled = btnmodificar.Enabled = !a;
        }
        int _IndicadorFila, _IndicadorColumna;
        string GlosaAnterior;
        private void btnmodificar_Click(object sender, EventArgs e)
        {
            GlosaAnterior = txtglosa.Text;
            _IndicadorFila = dtgBusqueda.CurrentCell.RowIndex;
            _IndicadorColumna = dtgBusqueda.CurrentCell.ColumnIndex;
            if (Dtgconten.RowCount > 0)
            {
                DataTable TPrueba1 = CapaLogica.VerFacturasPagadasVentas((int)cbotipoid.SelectedValue + "-" + txtdoc.Text, txtcodfactura.Text + '-' + txtnrofactura.Text, (int)cbotipodoc.SelectedValue, (int)cboempresa.SelectedValue);
                DataTable TPrueba2 = CapaLogica.VerPeriodoAbierto((int)cboempresa.SelectedValue, dtpFechaContable.Value);
                if (TPrueba1.Rows.Count > 0)
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
                    msg("La Factura Pertenece a un Periodo Cerrado. \nSolo se puede Actualizar la Imagen.");
                    ModoEdicionFoto(true);
                }
                else
                {
                    Estado = 2;
                    ModoEdicion(true);
                    BloquearColumnas();
                }
            }
            else
            {
                Estado = 2;
                ModoEdicion(true);
                BloquearColumnas();
            }
            btnAceptar.Enabled = true;
            OldIdComprobanteSelect = (int)cbotipodoc.SelectedValue;
            cbotipodoc_SelectedIndexChanged(sender, e);
            if (decimal.Parse(txttotalfac.Text) == 0) chkDocAnulado.Checked = true; else chkDocAnulado.Checked = false;
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
        public void LimpiarVistaPRevia()
        {
            for (int i = 0; i < Dtgconten.RowCount; i++)
                if (Dtgconten[xUsuario.Name, i].Value.ToString() == "999" || Dtgconten[xUsuario.Name, i].Value.ToString() == "998")
                {
                    Dtgconten.Rows.RemoveAt(i); i--;
                }
        }
        private void btnAdd_Click(object sender, EventArgs e)
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
                Boolean DocAnulado = chkDocAnulado.Checked;
                foreach (DataGridViewRow item in Dtgconten.Rows)
                {
                    if (item.Cells[xDebeHaber.Name].Value.ToString().ToUpper() == "D") conD++;
                    if (item.Cells[xDebeHaber.Name].Value.ToString().ToUpper() == "H")
                    {
                        conH++;
                        glosa = item.Cells[xGlosa.Name].Value.ToString();
                        cuo = item.Cells[xCodAsientoCtble.Name].Value.ToString();
                    }
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
                    if ((item.Cells[xDebeHaber.Name].Value.ToString() == "D" || item.Cells[xDebeHaber.Name].Value.ToString() == "H"))
                    {
                        HPResergerFunciones.Utilitarios.ColorCeldaDefecto(item.Cells[xDebeHaber.Name]);
                    }
                    else { HPResergerFunciones.Utilitarios.ColorCeldaError(item.Cells[xDebeHaber.Name]); ErrorDH = true; }
                    if ((item.Cells[xImporteMN.Name].Value.ToString() == "" ? 0 : (decimal)item.Cells[xImporteMN.Name].Value) <= 0)
                    {
                        item.Cells[xImporteMN.Name].Value = 0.00;
                        if (!DocAnulado)
                        {
                            ErrorM = true;
                            HPResergerFunciones.Utilitarios.ColorCeldaError(item.Cells[xImporteMN.Name]);
                        }
                    }
                    else HPResergerFunciones.Utilitarios.ColorCeldaDefecto(item.Cells[xImporteMN.Name]);
                    if ((item.Cells[xImporteME.Name].Value.ToString() == "" ? 0 : (decimal)item.Cells[xImporteME.Name].Value) <= 0)
                    {
                        item.Cells[xImporteME.Name].Value = 0.00;
                        if (!DocAnulado)
                        {
                            ErrorM = true;
                            HPResergerFunciones.Utilitarios.ColorCeldaError(item.Cells[xImporteME.Name]);
                        }
                    }
                    else HPResergerFunciones.Utilitarios.ColorCeldaDefecto(item.Cells[xImporteME.Name]);
                    if (_TipoDoc != 1)
                    {
                        if (_TipoDoc == 0 || _TipoDoc == 3)
                        {
                            if (item.Cells[xDebeHaber.Name].Value.ToString() == "H")
                                if (item.Cells[xTipoIgvg.Name].Value.ToString() == "")
                                {
                                    if (!DocAnulado)
                                    {
                                        error = true;
                                        HPResergerFunciones.Utilitarios.ColorCeldaError(item.Cells[xTipoIgvg.Name]);
                                    }
                                }
                                else HPResergerFunciones.Utilitarios.ColorCeldaDefecto(item.Cells[xTipoIgvg.Name]);
                        }
                        if (_TipoDoc == 2)
                        {
                            if (item.Cells[xDebeHaber.Name].Value.ToString() == "D")
                                if (item.Cells[xTipoIgvg.Name].Value.ToString() == "")
                                {
                                    if (!DocAnulado)
                                    {
                                        error = true;
                                        HPResergerFunciones.Utilitarios.ColorCeldaError(item.Cells[xTipoIgvg.Name]);
                                    }
                                }
                                else HPResergerFunciones.Utilitarios.ColorCeldaDefecto(item.Cells[xTipoIgvg.Name]);
                        }
                    }
                }
                string cadena = "";
                if (ErrorDH) { cadena += "Hay Errores en el Debe/Haber\n"; }
                if (conD == 0)
                {
                    if (_TipoDoc != 0) cadena += "No hay Cuenta Haber\n";
                    else cadena += "No hay Cuenta Debe (Cobrar a Terceros)\n";
                }
                if (conH == 0) { cadena += "No hay Cuenta Haber (Items)\n"; }
                if (error) { cadena += "Seleccione Tipo de IGV\n"; }
                if (errord) { cadena += "Hay Errores en las Cuentas\n"; }
                if (ErrorM) { cadena += "Hay Errores los Importe\n"; }
                /////VALIDACION
                if (conD == 0 || conH == 0 || error || errord || ErrorM || ErrorDH) { msg(cadena); return; }
                //////VAMOS CON EL IGV
                igvs = (decimal)(CapaLogica.ValorIGVactual(dtpfechaemision.Value))["Valor"];
                string CuentaIgv = "4011102";
                string NameCuentaIGV = "";
                DataTable Tpruebas = CapaLogica.BuscarCuentas("IGV %VENT", 5);
                if (Tpruebas.Rows.Count > 0)
                {
                    CuentaIgv = (Tpruebas.Rows[0])["IDCUENTA"].ToString();
                    NameCuentaIGV = (Tpruebas.Rows[0])["cuenta_contable"].ToString();
                }
                Tpruebas = CapaLogica.BuscarCuentas("I.G.V.", 5);
                if (Tpruebas.Rows.Count > 0)
                {
                    CuentaIgv = (Tpruebas.Rows[0])["idcuenta"].ToString();
                    NameCuentaIGV = (Tpruebas.Rows[0])["cuenta_contable"].ToString();
                }
                /////CALCULO DE LOS REFLEJOS
                TotalIgv = 0;
                foreach (DataGridViewRow item in Dtgconten.Rows)
                {
                    //REFLEJOS
                    DataTable Tprueba = CapaLogica.CuentasReflejo(item.Cells[xCuentaContable.Name].Value.ToString());
                    if (Tprueba.Rows.Count > 0)
                    {
                        DataRow filita = Tprueba.Rows[0];
                        if (filita["reflejadebe"].ToString() != "")
                        {
                            string debe = item.Cells[xDebeHaber.Name].Value.ToString();
                            string haber = debe == "D" ? "H" : "D";
                            DataRow fila = CLonarCOlumnas(Dtgconten.Rows[item.Index], TDatos);
                            fila[xDebeHaber.DataPropertyName] = debe; //"D";
                            fila[xCuentaContable.DataPropertyName] = filita["reflejadebe"].ToString();
                            fila[xdescripcion.DataPropertyName] = filita["Namedebe"].ToString();
                            fila[xUsuario.DataPropertyName] = 998;///por defecto
                            fila[xCodAsientoCtble.DataPropertyName] = cuo;
                            TDatos.Rows.Add(fila);
                            DataRow xfila = CLonarCOlumnas(Dtgconten.Rows[item.Index], TDatos);
                            xfila[xDebeHaber.DataPropertyName] = haber;//"H";
                            xfila[xCuentaContable.DataPropertyName] = filita["reflejahaber"].ToString();
                            xfila[xdescripcion.DataPropertyName] = filita["Namehaber"].ToString();
                            xfila[xUsuario.DataPropertyName] = 998;///por defecto
                            xfila[xCodAsientoCtble.DataPropertyName] = cuo;
                            TDatos.Rows.Add(xfila);
                        }
                    }
                    if (_TipoDoc == 0 || _TipoDoc == 3 || _TipoDoc == 1)
                    {
                        if (item.Cells[xTipoIgvg.Name].Value.ToString() != "")//item.Cells[xDebeHaber.Name].Value.ToString().ToUpper() == "H")
                        {
                            if (_TipoDoc != 1)
                                if (!DocAnulado)
                                    if ((int)item.Cells[xTipoIgvg.Name].Value == 1)
                                    {
                                        DataRow filaIgv = CLonarCOlumnas(Dtgconten.Rows[item.Index], TDatos);
                                        filaIgv[xDebeHaber.DataPropertyName] = item.Cells[xDebeHaber.Name].Value.ToString().ToUpper();
                                        filaIgv[xCuentaContable.DataPropertyName] = CuentaIgv;//.Substring(0, 7);
                                        filaIgv[xdescripcion.DataPropertyName] = NameCuentaIGV;
                                        filaIgv[xUsuario.DataPropertyName] = 999;///por defecto
                                        //if (_TipoDoc == 3)
                                        //{
                                        //    filaIgv[xImporteME.DataPropertyName] = Redondear((decimal)item.Cells[xImporteME.Name].Value / (1 + igvs));
                                        //    filaIgv[xImporteMN.DataPropertyName] = Redondear((decimal)item.Cells[xImporteMN.Name].Value / (1 + igvs));
                                        //}                                                                           
                                        filaIgv[xImporteME.DataPropertyName] = Redondear(Redondear((decimal)item.Cells[xImporteME.Name].Value * (1 + igvs)) / (1 + igvs) * igvs);
                                        filaIgv[xImporteMN.DataPropertyName] = Redondear(Redondear((decimal)item.Cells[xImporteMN.Name].Value * (1 + igvs)) / (1 + igvs) * igvs);
                                        ///soles                                        
                                        if ((int)cbomoneda.SelectedValue == 1)
                                            TotalIgv += Redondear((decimal)item.Cells[xImporteMN.Name].Value * igvs);
                                        else TotalIgv += Redondear((decimal)item.Cells[xImporteME.Name].Value * igvs);
                                        filaIgv[xCodAsientoCtble.DataPropertyName] = cuo;
                                        //}
                                        TDatos.Rows.Add(filaIgv);
                                    }
                        }
                    }
                    if (_TipoDoc == 2)
                    {
                        if (item.Cells[xDebeHaber.Name].Value.ToString().ToUpper() == "D")
                        {
                            if (!DocAnulado)
                                if ((int)item.Cells[xTipoIgvg.Name].Value == 1)
                                {
                                    DataRow filaIgv = CLonarCOlumnas(Dtgconten.Rows[item.Index], TDatos);
                                    filaIgv[xDebeHaber.DataPropertyName] = "D";
                                    filaIgv[xCuentaContable.DataPropertyName] = CuentaIgv;//.Substring(0, 7);
                                    filaIgv[xdescripcion.DataPropertyName] = NameCuentaIGV;
                                    filaIgv[xUsuario.DataPropertyName] = 999;///por defecto
                                    filaIgv[xImporteME.DataPropertyName] = Redondear((decimal)item.Cells[xImporteME.Name].Value * igvs);
                                    filaIgv[xImporteMN.DataPropertyName] = Redondear((decimal)item.Cells[xImporteMN.Name].Value * igvs);
                                    filaIgv[xCodAsientoCtble.DataPropertyName] = cuo;
                                    ///soles
                                    if ((int)cbomoneda.SelectedValue == 1)
                                        TotalIgv += Redondear((decimal)item.Cells[xImporteMN.Name].Value * igvs);
                                    else TotalIgv += Redondear((decimal)item.Cells[xImporteME.Name].Value * igvs);
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
                        conme += Redondear(decimal.Parse(((decimal)item.Cells[xImporteME.Name].Value).ToString("n2")));
                        conmn += Redondear(decimal.Parse(((decimal)item.Cells[xImporteMN.Name].Value).ToString("n2")));

                    }
                    if (item.Cells[xDebeHaber.Name].Value.ToString().ToUpper() == "H")
                    {
                        conme -= Redondear(decimal.Parse(((decimal)item.Cells[xImporteME.Name].Value).ToString("n2")));
                        conmn -= Redondear(decimal.Parse(((decimal)item.Cells[xImporteMN.Name].Value).ToString("n2")));
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
                        DH = "H";
                        //Tpruebass = CapaLogica.BuscarCuentas("INGRESOS POR REDONDEO", 5);
                        Tpruebass = CapaLogica.BuscarCuentas("INGRESOS POR REDONDEO", 5);
                    }
                    else if ((conme < 0 && (int)cbomoneda.SelectedValue == 2) || (conmn < 0 && (int)cbomoneda.SelectedValue == 1))
                    {
                        //Tpruebass = CapaLogica.BuscarCuentas("PERDIDAS POR REDONDEO", 5);
                        Tpruebass = CapaLogica.BuscarCuentas("ajuste por redondeo", 5);
                        DH = "D";
                    }
                    else if (conme > 0 || conmn > 0)
                    {
                        DH = "H";
                        //Tpruebass = CapaLogica.BuscarCuentas("INGRESOS POR REDONDEO", 5);
                        Tpruebass = CapaLogica.BuscarCuentas("INGRESOS POR REDONDEO", 5);
                    }
                    else if (conme < 0 || conmn < 0)
                    {
                        //Tpruebass = CapaLogica.BuscarCuentas("PERDIDAS POR REDONDEO", 5);
                        Tpruebass = CapaLogica.BuscarCuentas("ajuste por redondeo", 5);
                        DH = "D";
                    }
                    if (Tpruebass.Rows.Count > 0)
                    {
                        CuentaRedondeo = (Tpruebass.Rows[0])["cuenta_contable"].ToString();
                    }
                    DataRow filita = Tpruebass.Rows[0];
                    DataRow fila = TDatos.NewRow();
                    fila[xDebeHaber.DataPropertyName] = DH;
                    fila[xCuentaContable.DataPropertyName] = filita["idcuenta"].ToString();//.Substring(0, 7);
                    fila[xdescripcion.DataPropertyName] = filita["cuenta_contable"].ToString();
                    fila[xUsuario.DataPropertyName] = 999;///por defecto
                    fila[xGlosa.DataPropertyName] = "Redondeo en registro";
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
                msg("No hay Filas");
            }
        }
        public decimal Redondear(decimal valor) { return Math.Round(valor, 2); }
        public DataRow CLonarCOlumnas(DataGridViewRow rowcito, DataTable tabla)
        {
            DataRow filita = tabla.NewRow();
            int x = 0;
            foreach (DataGridViewCell item in rowcito.Cells)
            {
                filita[x] = item.Value ?? 1; x++;
            }
            return filita;
        }
        private void Dtgconten_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {
            lblmensaje.Text = $"Total de Registros: {Dtgconten.RowCount}";
        }
        DataGridViewComboBoxColumn combo;
        private void Dtgconten_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            int x = e.RowIndex, y = e.ColumnIndex;
            if (x >= 0)
            {
                combo = Dtgconten.Columns[xTipoIgvg.Name] as DataGridViewComboBoxColumn;
                combo.DisplayMember = "Descripcion";
                combo.ValueMember = "codigo";
                combo.DataSource = TGrava;
            }
        }
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
                                //Para no dividir por Cero
                                decimal TC = decimal.Parse(txttipocambio.Text == ".000" ? "1" : txttipocambio.Text == "" ? "1" : txttipocambio.Text);
                                TC = TC == 0 ? 1 : TC;
                                Dtgconten[xImporteME.Name, x].Value = Redondear(Valor / (TC));
                            }
                    }
                }
                else
                if (y == Dtgconten.Columns[xDebeHaber.Name].Index)
                {
                    Dtgconten[xDebeHaber.Name, x].Value = Dtgconten[xDebeHaber.Name, x].Value.ToString().ToUpper();
                    Dtgconten[xGlosa.Name, x].Value = txtglosa.TextValido();
                }
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
                        Dtgconten[xCuentaContable.Name, e.RowIndex].Value = cuentitas.codigo;
                        Dtgconten.EndEdit();
                        Dtgconten.RefreshEdit();

                    }
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

        private void Dtgconten_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            if (e.ColumnIndex == Dtgconten.Columns[xTipoIgvg.Name].Index)
            {
                //  Dtgconten[xTipoIgvg.Name, e.RowIndex].Value = 1;
            }
        }

        private void frmimagen_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Back || e.KeyCode == Keys.Delete)
            {
                if (msgp("Desea Eliminar la Imagen") == DialogResult.Yes)
                {
                    imgfactura = null; frmimagen.Imagen = null;
                }
            }
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

        private void txttotalfac_TextChanged(object sender, EventArgs e)
        {
            decimal resul = 0;
            decimal.TryParse(txttotalfac.Text, out resul);
            detracion = resul * (numdetraccion.Value / 100);
            txtmontodetraccion.Text = detracion.ToString(txtmontodetraccion.Format);
            if (Dtgconten.RowCount > 0) btnAceptar.Enabled = false;
            //CalcularDiferenciaTOtalDetra();
        }
        private void txttipocambio_TextChanged(object sender, EventArgs e)
        {
            ///actualizo el monto de ventas
            cbomoneda_SelectedValueChanged(sender, e);
        }
        private void btnmodificar_EnabledChanged(object sender, EventArgs e)
        {
            btneliminar.Enabled = btnmodificar.Enabled;
        }

        private void cbomoneda_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        int _TipoDoc;
        private void cbotipodoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            PanelNotaCredito.Visible = false;
            PanelFacturas.Visible = false;
            PanelNotaCredito.Visible = false;
            Dtgconten.Columns[xTipoIgvg.Name].Visible = true;
            txtSerieRef.ReadOnly = txtNumRef.ReadOnly = true;
            chkfac.Enabled = false;
            //chkCompensa.Visible = true;
            _TipoDoc = 0;
            rdbInteres.Visible = rdbDescuento.Visible = rdbAnulacion.Visible = btnaplicar.Visible = false;
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
                PanelFacturas.Visible = true;
                Dtgconten.Columns[xTipoIgvg.Name].Visible = false;
                btnCargarFoto.Text = "&Foto Recibo";
                //PanelRecibo.Visible = true;
                //txtglosa.Text = txtglosa.TextoDefecto = "Ingrese La Glosa del Recibo por Honorarios";
            }
            if (cbotipodoc.Text.Substring(3) == "FACTURA" || cbotipodoc.Text.Substring(3) == "OTROS" || cbotipodoc.Text.Substring(3) == "BOLETA DE VENTA")
            {
                _TipoDoc = 0;
                btnCargarFoto.Text = "&Foto Factura";
                PanelFacturas.Visible = true;
                //txtglosa.Text = txtglosa.TextoDefecto = "Ingrese La Glosa de la Factura";
            }
            if (string.Compare("NOTA DE CREDITO", cbotipodoc.Text.Substring(3), System.Globalization.CultureInfo.CurrentCulture, System.Globalization.CompareOptions.IgnoreNonSpace) == 0)
            {
                btnCargarFoto.Text = "&Foto N.Crédit.";
                _TipoDoc = 2;
                //chkCompensa.Visible = false;
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
                //chkCompensa.Visible = false;
                cbomoneda.Enabled = false;
                //txtglosa.Text = txtglosa.TextoDefecto = "Ingrese La Glosa de la Nota de Débito";
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
                TFacReferencia = CapaLogica.BuscarVentasManualesToNcNd(txtdoc.Text, (int)cbotipoid.SelectedValue, NumDocRef);
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

        private void txtNumRef_TextChanged(object sender, EventArgs e)
        {
            if (Estado == 1 || Estado == 2) BusquedaDocReferencia();
        }
        private void txtSerieRef_TextChanged(object sender, EventArgs e)
        {
            if (Estado == 1 || Estado == 2) BusquedaDocReferencia();
        }

        private void rdbAnulacion_CheckedChanged(object sender, EventArgs e)
        {
            if (Encontrado == 1) btnaplicar.Enabled = true;
        }
        private void rdbInteres_CheckedChanged(object sender, EventArgs e)
        {
            if (Encontrado == 1) btnaplicar.Enabled = true;
        }
        private void rdbDescuento_CheckedChanged(object sender, EventArgs e)
        {
            if (Encontrado == 1) btnaplicar.Enabled = true;
        }

        private void btnaplicar_Click(object sender, EventArgs e)
        {
            string NumDocRef = txtSerieRef.Text + "-" + txtNumRef.Text;
            int opcion = 0;
            if (rdbAnulacion.Checked) opcion = 1;
            else if (rdbDescuento.Checked) opcion = 2;
            else opcion = 3;
            TFacRefDetalle = CapaLogica.BuscarVentasManualesToNcNdDEtalle(opcion, txtdoc.Text, (int)cbotipoid.SelectedValue, NumDocRef);
            Dtgconten.DataSource = TFacRefDetalle;
            btnaplicar.Enabled = false;
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
                if (chkDocAnulado.Checked)
                    if (Dtgconten.RowCount == 0)
                    {
                        ((DataTable)Dtgconten.DataSource).Rows.Add();
                        ((DataTable)Dtgconten.DataSource).Rows.Add();
                        Dtgconten[xDebeHaber.Name, 0].Value = "D"; Dtgconten[xDebeHaber.Name, 1].Value = "H";
                        Dtgconten[xCuentaContable.Name, 0].Value = "1212101"; Dtgconten[xCuentaContable.Name, 1].Value = "1212101";
                        Dtgconten[xImporteMN.Name, 0].Value = 0.00; Dtgconten[xImporteME.Name, 0].Value = 0.00;
                        Dtgconten[xImporteMN.Name, 1].Value = 0.00; Dtgconten[xImporteME.Name, 1].Value = 0.00;
                        btnAceptar.Enabled = true;
                    }
            }
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
        frmdetracciones frdetracion;
        private void btnmasdetracion_Click_1(object sender, EventArgs e)
        {
            frdetracion = new frmdetracciones();
            frdetracion.FormClosed += Frdetracion_FormClosed;
            frdetracion.BuscarValor = true; frdetracion.detraccion = txtdescdetraccion.Text;
            frdetracion.btnaceptar.Enabled = true;
            frdetracion.AcceptButton = frdetracion.btnaceptar;
            frdetracion.ShowDialog();
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
            SF.FileName = "Formato de Carga de Ventas";
            var result = SF.ShowDialog();
            if (result == DialogResult.OK)
            {
                File.WriteAllBytes(SF.FileName, SISGEM.Resource1.LISTADO_DE_VENTAS);
                System.Diagnostics.Process.Start(SF.FileName);
            }
        }
        string ResultadoMasivoTXT = "";
        Boolean ProcesoMasivo = false;
        DataTable TdatosExcel;
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
        DataTable TContenendor;
        string CodDetracciones = "";
        private string rucNiubiz = "";
        private string RazonNiubiz = "";
        private string CuentaNiubiz;
        private string VoucherPago="";
        private int TipoPago;

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
                        List<String> ListaCLientesRuc = new List<string>();
                        List<String> ListaCLientesDni = new List<string>();
                        List<String> ListaRUC = new List<string>();
                        List<DateTime> ListaFechasEmision = new List<DateTime>();
                        List<String> ListaEmpresas = new List<string>();
                        //string CuentaContable =item[19].ToString();  //CUENTA CONTABLE 
                        string NroRuc = "";
                        ResultadoMasivoTXT = "";
                        string cadenaResultado = "";

                        int i = 0;
                        foreach (DataRow item in TdatosExcel.Rows)
                        {
                            if (i > 0)
                            {
                                if (item[0].ToString().Trim() == "")
                                {
                                    break;
                                }

                                string CuentaContable27 = item[27].ToString();  //CUENTA CONTABLE
                                string CuentaContable29 = item[29].ToString();  //CUENTA CONTABLE
                                string CuentaContable31 = item[31].ToString();  //CUENTA CONTABLE
                                string CuentaContable35 = item[35].ToString();  //CUENTA CONTABLE
                                string CuentaContable36 = item[36].ToString();  //CUENTA CONTABLE
                                string CuentaContable38 = item[38].ToString();  //CUENTA CONTABLE

                                string NombreEmpresa = item[0].ToString().Trim();  //NOMBRE DE LA EMPRESAS
                                DateTime fecha = (DateTime)item[8];

                                if (!ListaCuentas.Contains(CuentaContable27)) ListaCuentas.Add(CuentaContable27);
                                if (!ListaCuentas.Contains(CuentaContable29)) ListaCuentas.Add(CuentaContable29);
                                if (!ListaCuentas.Contains(CuentaContable31)) ListaCuentas.Add(CuentaContable31);
                                if (!ListaCuentas.Contains(CuentaContable35)) ListaCuentas.Add(CuentaContable35);
                                if (!ListaCuentas.Contains(CuentaContable36)) ListaCuentas.Add(CuentaContable36);
                                if (!ListaCuentas.Contains(CuentaContable38)) ListaCuentas.Add(CuentaContable38);

                                if (!ListaEmpresas.Contains(NombreEmpresa)) ListaEmpresas.Add(NombreEmpresa);

                                if (!ListaFechasEmision.Contains(fecha)) ListaFechasEmision.Add(fecha);

                                //validamos importe vacios
                                item[16] = item[16].ToString() == "" ? 0.00 : item[16];
                                item[17] = item[17].ToString() == "" ? 0.00 : item[17];
                                item[18] = item[18].ToString() == "" ? 0.00 : item[18];
                                item[19] = item[19].ToString() == "" ? 0.00 : item[19];
                                item[20] = item[20].ToString() == "" ? 0.00 : item[20];
                                item[21] = item[21].ToString() == "" ? 0.00 : item[21];
                                item[22] = item[22].ToString() == "" ? 0.00 : item[22];
                                item[23] = item[23].ToString() == "" ? 0.00 : item[23];
                                item[24] = item[24].ToString() == "" ? 0.00 : item[24];
                                item[25] = item[25].ToString() == "" ? 0.00 : item[25];
                                item[26] = item[26].ToString() == "" ? 0.00 : item[26];
                                item[27] = item[27].ToString() == "" ? 0.00 : item[27];
                                item[28] = item[28].ToString() == "" ? 0.00 : item[28];
                                item[29] = item[29].ToString() == "" ? 0.00 : item[29];
                                item[30] = item[30].ToString() == "" ? 0.00 : item[30];

                                if (item[28].ToString() != "0")
                                {
                                    NroRuc = item[48].ToString(); //RUC NIUBIZ  
                                    if (!ListaRUC.Contains(NroRuc)) ListaRUC.Add(NroRuc);
                                }
                                if (item[11].ToString() == "6")
                                {
                                    NroRuc = item[12].ToString(); //RUC CLIENTE  
                                    if (!ListaCLientesRuc.Contains(NroRuc)) ListaCLientesRuc.Add(NroRuc);
                                }
                                if (item[11].ToString() != "6")
                                {
                                    NroRuc = item[12].ToString(); //DNI CLIENTE
                                    if (!ListaCLientesDni.Contains(NroRuc)) ListaCLientesDni.Add(NroRuc);
                                }
                                if (item[6].ToString() == "")
                                    cadenaResultado += $"En la Columna Doc: Fila:{i + 1}, debe Registrar el Tipo de Documento del Comprobante\n";
                                if (item[7].ToString() == "")
                                    cadenaResultado += $"En la Columna Numero: Fila:{i + 1}, debe Registrar el Numero de Documento del Comprobante\n";

                                if (item[11].ToString() == "")
                                    cadenaResultado += $"En la Columna Tip.Doc.Iden: Fila:{i + 1}, debe Registrar Tipo Documento del Cliente\n";
                                if (item[12].ToString() == "")
                                    cadenaResultado += $"En la Columna RUC: Fila:{i + 1}, debe Registrar RUC del Cliente\n";

                                //validamos que no tenga documento repetidos el excel
                                string item0 = item[0].ToString().Trim();
                                string item6 = item[6].ToString().Trim();
                                string item7 = item[7].ToString();
                                foreach (DataRow Buscando in TdatosExcel.Rows)
                                {
                                    if (item != Buscando)
                                    {
                                        if (item0 == Buscando[0].ToString().Trim() && item6 == Buscando[6].ToString().Trim() && item7 == Buscando[7].ToString())
                                            cadenaResultado += $"En la Fila:{i + 1}, No se puede Registrar,{item[4].ToString().Trim()} Este Documento esta Duplicado en el Excel\n";
                                    }
                                }

                                //validamos documentos ya registrados                              
                                DataTable Tprueba = CapaDatos.FacturaManualVentaCabecera(item[0].ToString(), item[7].ToString(), int.Parse(item[6].ToString()));
                                if (Tprueba.Rows.Count > 0)
                                {
                                    cadenaResultado += $"En la Fila:{i + 1}, No se puede Registrar,{item[4].ToString().Trim()} Este Documento Ya Existe\n";
                                }

                                //validamos la moneda
                                string[] moneda = { "S", "D" };
                                if (!moneda.Contains(item[32].ToString()))
                                {
                                    cadenaResultado += $"En la Fila:{i + 1}, debe Registrar la moneda: S o D\n";
                                }
                                //Validamos notas
                                if (int.Parse(item[6].ToString()) == 7)
                                {
                                    if (item[45].ToString() == "" || item[46].ToString() == "" || item[47].ToString() == "")
                                        cadenaResultado += $"En la Fila:{i + 1}, debes Registrar datos del Documento de Referencia\n";
                                }
                                //validamos la fecha emision
                                if (DateTime.Parse(item[8].ToString()) > DateTime.Now)
                                {
                                    cadenaResultado += $"En la Fila:{i + 1}, la fecha de emision no puede ser mayor a hoy\n";
                                }
                                //VALIDACION DE FECHAS
                                DateTime Fechaprueba;
                                if (!DateTime.TryParse(item[8].ToString(), out Fechaprueba)) cadenaResultado += $"La Fecha de Emision en la Fila:{i + 1}, es Incorrecta \n";
                                if (!DateTime.TryParse(item[9].ToString(), out Fechaprueba)) cadenaResultado += $"La Fecha Contable en la Fila:{i + 1}, es Incorrecta \n";
                                if (!DateTime.TryParse(item[10].ToString(), out Fechaprueba)) cadenaResultado += $"La Fecha Vencimiento en la Fila:{i + 1}, es Incorrecta \n";

                            }
                            i++;
                        }
                        //fin de cargas de listas
                        foreach (string Cuenta in ListaCuentas)
                        {
                            if (CapaDatos.BuscarCuentasQuery(Cuenta).Rows.Count == 0)
                                cadenaResultado += $"No existe la cuenta: {Cuenta}\n";
                        }
                        foreach (string ruc in ListaCLientesRuc)
                        {
                            if (CapaDatos.BuscarClienteQuery(ruc).Rows.Count == 0)
                                cadenaResultado += $"No existe el RUC Cliente: {ruc}\n";
                        }
                        foreach (string ruc in ListaCLientesDni)
                        {
                            if (CapaDatos.BuscarClienteQuery(ruc).Rows.Count == 0)
                                cadenaResultado += $"No existe el DNI Cliente: {ruc}\n";
                        }
                        foreach (string ruc in ListaRUC)
                        {
                            if (CapaDatos.BuscarProveedorQuery(ruc).Rows.Count == 0)
                                cadenaResultado += $"No existe el proveedor NIUBIZ: {ruc}\n";
                        }
                        foreach (DateTime FechaEmision in ListaFechasEmision)
                        {
                            if (CapaDatos.BuscarTipodeCambioQuery(FechaEmision).Rows.Count == 0)
                                cadenaResultado += $"No existe Tipo de Cambio para la FechaEmision: {FechaEmision.ToShortDateString()}\n";
                        }

                        foreach (string Nempresas in ListaEmpresas)
                        {
                            if (CapaDatos.BuscarEmpresaQuery(Nempresas).Rows.Count == 0)
                                cadenaResultado += $"No existe el nombre de la empresa: {Nempresas}\n";
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
                            if (msgp("Se Cargo el Excel con exito, Desea proceder con los Registros") == DialogResult.Yes)
                            {
                                ProcesoMasivo = true;
                                //PROCEDEMOS CON LA CARGA MASIVA
                                i = 0;
                                foreach (DataRow item in TdatosExcel.Rows)
                                {
                                    if (i > 0)
                                    {
                                        if (item[0].ToString().Trim() == "")
                                        {
                                            break;
                                        }
                                        Cursor = Cursors.WaitCursor;
                                        btnnuevo.PerformClick();
                                        //CARGA DE LA CABECERA
                                        cbodetraccion.Text = "NO";
                                        txtmontodetraccion.Text = "0.00";

                                        int val = int.Parse(item[11].ToString());
                                        cbotipoid.SelectedValue = 1;  //DNI
                                        switch (val)
                                        {
                                            case 6: cbotipoid.SelectedValue = 5; break;
                                            case 4: cbotipoid.SelectedValue = 2; break;
                                            case 0: cbotipoid.SelectedValue = 6; break;
                                            case 1: cbotipoid.SelectedValue = 1; break;
                                            case 7: cbotipoid.SelectedValue = 3; break;
                                                //default:
                                                //    switch (item[28].ToString().Length)
                                                //    {
                                                //        case 11: cbotipoid.SelectedValue = 6; break;
                                                //        case 8: cbotipoid.SelectedValue = 1; break;
                                                //        default:
                                                //            cbotipoid.SelectedValue = 1; break;
                                                //    }
                                                //    break;
                                        }
                                        string NDebe = "D", NHaber = "H";
                                        txtdoc.Text = item[12].ToString(); //RUC
                                        dtpFechaContable.Value = DateTime.Parse(item[9].ToString()); //FECHACONTABLE
                                        dtpfechaemision.Value = DateTime.Parse(item[8].ToString()); //FECHA EMISION
                                        dtpfechavence.Value = DateTime.Parse(item[10].ToString()); //FECHAVENCE 
                                        string[] Valr = item[7].ToString().Split('-'); //CODIGO SERIE FACTURA
                                        txtcodfactura.Text = Valr[0];
                                        txtnrofactura.Text = Valr[1];
                                        cbomoneda.SelectedIndex = item[32].ToString() == "S" ? 0 : 1; //MONEDA
                                        cbotipodoc.SelectedValue = 1 + int.Parse(item[6].ToString()); //TIPO COMPROBANTE PAGO
                                                                                                      //
                                        txttotalfac.Text = (Math.Abs(decimal.Parse(item[19].ToString())+   decimal.Parse(item[16].ToString()) + decimal.Parse(item[26].ToString()))).ToString("n2"); //TOTAL FACTURA
                                        txtglosa.Text = item[34].ToString() == "" ? "CARGA MASIVA" : item[34].ToString(); //GLOSA
                                        //LAS DETRACCIONES
                                        txtdescdetraccion.Text = ""; detrac = "";
                                        CodDetracciones = item[62].ToString();
                                        cbodetraccion.Text = item[62].ToString() == "" ? "NO" : "SI";

                                        int POS = 0;
                                        TipoPago = 0;
                                        switch (item[15].ToString().Trim())
                                        {
                                            case "Transferencia": TipoPago = 3; break;
                                            case "Cheque": TipoPago = 7; break;
                                            case "Deposito en Cuenta": TipoPago = 1; break;
                                            case "Con tarjeta": TipoPago = 6; break;
                                            default: TipoPago = 0; break;
                                                //3 Transferencia
                                                //7 Cheque
                                                //1 Deposito en Cuenta
                                                //6 Con tarjeta
                                        }
                                        VoucherPago = item[14].ToString();

                                        //CARGA DEL DETALLE
                                        btnAdd.PerformClick();
                                        if ((int)cbotipodoc.SelectedValue == 8) //LAS NOTAS VOLTEAN LOS ORIGENES
                                        {
                                            NDebe = "H";
                                            NHaber = "D";
                                            string[] Numref = item[46].ToString().Split('-');
                                            txtSerieRef.Text = Numref[0];
                                            txtNumRef.Text = Numref[1];
                                            chkfac.Checked = true;
                                        }

                                        if (decimal.Parse(item[21].ToString()) != 0) //GRAVA IGV
                                        {
                                            TContenendor.Rows.Add(TContenendor.NewRow());
                                            Dtgconten.Rows[POS].Cells[xDebeHaber.Name].Value = NHaber;
                                            Dtgconten.Rows[POS].Cells[xGlosa.Name].Value = txtglosa.TextValido();
                                            Dtgconten.Rows[POS].Cells[xCuentaContable.Name].Value = item[35].ToString(); //CUENTA INGRESO
                                            if (item[32].ToString() == "S")
                                            {
                                                Dtgconten.Rows[POS].Cells[xImporteMN.Name].Value = Math.Abs(decimal.Parse(item[21].ToString()));
                                            }
                                            else
                                            {
                                                Dtgconten.Rows[POS].Cells[xImporteME.Name].Value = Math.Abs(decimal.Parse(item[21].ToString()));
                                            }
                                            Dtgconten.Rows[POS].Cells[xTipoIgvg.Name].Value = decimal.Parse(item[21].ToString()) != 0 ? 1 : 4;
                                            TContenendor.AcceptChanges();
                                            POS++;
                                        }

                                        if (decimal.Parse(item[22].ToString()) != 0) //  INAFECTO
                                        {
                                            TContenendor.Rows.Add(TContenendor.NewRow());
                                            Dtgconten.Rows[POS].Cells[xDebeHaber.Name].Value = NHaber;
                                            Dtgconten.Rows[POS].Cells[xGlosa.Name].Value = txtglosa.TextValido();
                                            Dtgconten.Rows[POS].Cells[xCuentaContable.Name].Value = item[35].ToString();//CUENTA INGRESO
                                            if (item[32].ToString() == "S")
                                            {
                                                Dtgconten.Rows[POS].Cells[xImporteMN.Name].Value = Math.Abs(decimal.Parse(item[22].ToString()));
                                            }
                                            else
                                            {
                                                Dtgconten.Rows[POS].Cells[xImporteME.Name].Value = Math.Abs(decimal.Parse(item[22].ToString()));
                                            }
                                            Dtgconten.Rows[POS].Cells[xTipoIgvg.Name].Value = 4;
                                            TContenendor.AcceptChanges();
                                            POS++;
                                        }

                                        if (decimal.Parse(item[26].ToString()) != 0) //  PENALIDAD
                                        {
                                            TContenendor.Rows.Add(TContenendor.NewRow());
                                            Dtgconten.Rows[POS].Cells[xDebeHaber.Name].Value = NDebe;
                                            Dtgconten.Rows[POS].Cells[xGlosa.Name].Value = txtglosa.TextValido();
                                            Dtgconten.Rows[POS].Cells[xCuentaContable.Name].Value = item[27].ToString();//CUENTA PENALIDAD
                                            if (item[32].ToString() == "S")
                                            {
                                                Dtgconten.Rows[POS].Cells[xImporteMN.Name].Value = Math.Abs(decimal.Parse(item[26].ToString()));
                                            }
                                            else
                                            {
                                                Dtgconten.Rows[POS].Cells[xImporteME.Name].Value = Math.Abs(decimal.Parse(item[26].ToString()));
                                            }
                                            Dtgconten.Rows[POS].Cells[xTipoIgvg.Name].Value = 0;
                                            TContenendor.AcceptChanges();
                                            POS++;
                                        }

                                        rucNiubiz = "";
                                        RazonNiubiz = "";
                                        CuentaNiubiz = "";

                                        if (decimal.Parse(item[28].ToString()) != 0) //  Comisión Nubiz
                                        {
                                            rucNiubiz = item[48].ToString();
                                            RazonNiubiz = item[49].ToString();
                                            CuentaNiubiz = item[29].ToString();

                                            TContenendor.Rows.Add(TContenendor.NewRow());
                                            Dtgconten.Rows[POS].Cells[xDebeHaber.Name].Value = NDebe;
                                            Dtgconten.Rows[POS].Cells[xGlosa.Name].Value = txtglosa.TextValido();
                                            Dtgconten.Rows[POS].Cells[xCuentaContable.Name].Value = item[29].ToString();//CUENTA Comisión Nubiz
                                            if (item[32].ToString() == "S")
                                            {
                                                Dtgconten.Rows[POS].Cells[xImporteMN.Name].Value = Math.Abs(decimal.Parse(item[28].ToString()));
                                            }
                                            else
                                            {
                                                Dtgconten.Rows[POS].Cells[xImporteME.Name].Value = Math.Abs(decimal.Parse(item[28].ToString()));
                                            }
                                            Dtgconten.Rows[POS].Cells[xTipoIgvg.Name].Value = 0;
                                            TContenendor.AcceptChanges();
                                            POS++;
                                        }
                                        if (decimal.Parse(item[30].ToString()) != 0) //   Separación
                                        {
                                            TContenendor.Rows.Add(TContenendor.NewRow());
                                            Dtgconten.Rows[POS].Cells[xDebeHaber.Name].Value = NDebe;
                                            Dtgconten.Rows[POS].Cells[xGlosa.Name].Value = txtglosa.TextValido();
                                            Dtgconten.Rows[POS].Cells[xCuentaContable.Name].Value = item[31].ToString();//CUENTA  Separación
                                            if (item[32].ToString() == "S")
                                            {
                                                Dtgconten.Rows[POS].Cells[xImporteMN.Name].Value = Math.Abs(decimal.Parse(item[30].ToString()));
                                            }
                                            else
                                            {
                                                Dtgconten.Rows[POS].Cells[xImporteME.Name].Value = Math.Abs(decimal.Parse(item[30].ToString()));
                                            }
                                            Dtgconten.Rows[POS].Cells[xTipoIgvg.Name].Value = 0;
                                            TContenendor.AcceptChanges();
                                            POS++;
                                        }

                                        //FIN CUENTA POR COBRAR
                                        i++;
                                        TContenendor.Rows.Add(TContenendor.NewRow());
                                        Dtgconten.Rows[POS].Cells[xDebeHaber.Name].Value = NDebe;
                                        Dtgconten.Rows[POS].Cells[xGlosa.Name].Value = txtglosa.TextValido();
                                        Dtgconten.Rows[POS].Cells[xCuentaContable.Name].Value = item[38].ToString(); //CUENTA X COBRAR
                                        if (item[32].ToString() == "S")
                                        {
                                            Dtgconten.Rows[POS].Cells[xImporteMN.Name].Value = Math.Abs(decimal.Parse(item[19].ToString()) + decimal.Parse(item[28].ToString())+ decimal.Parse(item[26].ToString()));
                                        }
                                        else
                                        {
                                            Dtgconten.Rows[POS].Cells[xImporteME.Name].Value = Math.Abs(decimal.Parse(item[19].ToString()) + decimal.Parse(item[28].ToString()) + decimal.Parse(item[26].ToString()));
                                        }


                                        TContenendor.AcceptChanges();
                                        btnAdd.PerformClick();
                                        //return;
                                        btnvistaPrevia.PerformClick();
                                        TContenendor.AcceptChanges();
                                        cboempresa.Text = item[0].ToString();
                                        //Grabado
                                        btnAceptar.PerformClick();
                                        //return;
                                    }
                                    i++;
                                }
                            }
                            VoucherPago = "";
                            rucNiubiz = "";
                            RazonNiubiz = "";
                            CuentaNiubiz = "";
                            TipoPago = 0;
                            Cursor = Cursors.Default;


                            if (ResultadoMasivoTXT.Length > 0)
                            {
                                string path = $"{Application.CommonAppDataPath}";
                                //if (File.Exists(path)) File.Delete(path);
                                path = Path.Combine(path, $"Reporte Facturas Ventas {DateTime.Now.ToString("dd-MM-yy")}.txt");
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
        public void msgError(string cadena) { HPResergerFunciones.frmInformativo.MostrarDialogError(cadena); }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void btnfiltrar_Click(object sender, EventArgs e)
        {
            LimpiarBusquedas();
            CargarDatos();
        }

        private void txtbusnrodoc_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                CargarDatos();
            }
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
                        CapaLogica.FacturaManualVentaCabeceraRemover((int)dtgBusqueda[yid.Name, dtgBusqueda.CurrentRow.Index].Value, OpcionBusqueda == 1 ? 3 : 300, (int)cbotipodoc.SelectedValue, cbotipoid.SelectedValue.ToString() + "-" + txtdoc.Text);
                        msgOK("Eliminado Con Éxito");
                        txtbusproveedor_TextChanged(sender, e);
                    }
                }
                else
                {
                    if (msgp("Seguro Desea Eliminar Factura con su Asiento") == DialogResult.Yes)
                    {
                        DataTable TPrueba1 = CapaLogica.VerFacturasPagadasVentas((int)cbotipoid.SelectedValue + "-" + txtdoc.Text, txtcodfactura.Text + '-' + txtnrofactura.Text, (int)cbotipodoc.SelectedValue, (int)cboempresa.SelectedValue);
                        DataTable TPrueba2 = CapaLogica.VerPeriodoAbierto((int)cboempresa.SelectedValue, dtpFechaContable.Value);
                        if (TPrueba1.Rows.Count > 0)
                        {
                            msg("La Factura ya tiene un Abono.");
                            return;
                        }
                        else if (TPrueba2.Rows.Count == 0)
                        {
                            msg("La Factura Pertenece a un Periodo Cerrado.");
                            return;
                        }
                        if (OldCuo != null)
                        {
                            CapaLogica.EliminarAsiento(OldCuo, OldEmpresa, OldFechaContable, 1);
                            CapaLogica.FacturaManualVentaCabeceraRemover((int)dtgBusqueda[yid.Name, dtgBusqueda.CurrentRow.Index].Value, OpcionBusqueda == 1 ? 3 : 300, (int)cbotipodoc.SelectedValue, cbotipoid.SelectedValue.ToString() + "-" + txtdoc.Text);
                            CapaLogica.FacturaManualVentaDetalleRemover(txtcodfactura.Text + "-" + txtnrofactura.Text, (int)cboempresa.SelectedValue, OpcionBusqueda == 1 ? 3 : 300, (int)cbotipodoc.SelectedValue, cbotipoid.SelectedValue.ToString() + "-" + txtdoc.Text);
                            msgOK("Eliminado Con Éxito");
                            txtbusproveedor_TextChanged(sender, e);
                        }
                    }
                }
            }
        }
    }
}
