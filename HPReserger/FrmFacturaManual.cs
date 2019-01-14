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
        public DateTime OldFechaContable { get; private set; }
        public int OldId { get; private set; }

        private void FrmFacturaManual_Load(object sender, EventArgs e)
        {
            Estado = 0; _idempresa = 0; _proyecto = 0; _etapa = 0; coddet = "";
            CargarMoneda(); CargarTipoComprobante(); CargarDetracciones(); CargarEmpresa();
            CargarTablasDefecto();
            dtpfechaemision.Value = dtpfecharecep.Value = DateTime.Now;
            cbodetraccion.Text = "NO";
            cbograba.SelectedIndex = 0;
            ModoEdicion(false);
            LimpiarBusquedas();
            CargarDatos();
        }
        public void CargarDatos()
        {
            dtgBusqueda.DataSource = CapaLogica.FacturaManualBusqueda(txtbusproveedor.TextValido(), txtbusnrodoc.TextValido(), txtbuscaempresa.TextValido());
            btnmodificar.Enabled = false;
            if (dtgBusqueda.RowCount > 0) btnmodificar.Enabled = true;
            else
            {
                Dtgconten.DataSource = CapaLogica.FacturaManualDetalleBusqueda("", "");
                Limpiar();
            }
        }
        public void ModoEdicion(Boolean a)
        {
            ////combobox
            cboempresa.Enabled = cboproyecto.Enabled = cboetapa.Enabled = cbodetraccion.Enabled = cbograba.Enabled = cbomoneda.Enabled = cbotipodoc.Enabled = a;
            ///textbox user
            txtruc.ReadOnly = txttipocambio.ReadOnly = txttotalfac.ReadOnly = txtnrofactura.ReadOnly = txtcodfactura.ReadOnly = txtglosa.ReadOnly = !a;
            ///Botones
            btnCargarFoto.Enabled = btnbusproveedor.Enabled = btnAdd.Enabled = btnlimpiar.Enabled = a;
            ////checkbox
            chkCompensa.Enabled = a;
            ///datetimepicker
            dtpFechaContable.Enabled = dtpfechaemision.Enabled = dtpfecharecep.Enabled = dtpfechavence.Enabled = a;
            ///////////////////
            btncleanfind.Enabled = !a;
            txtbusnrodoc.ReadOnly = txtbuscaempresa.ReadOnly = txtbusproveedor.ReadOnly = a;
            dtgBusqueda.Enabled = !a; Dtgconten.ReadOnly = !a;
            btnnuevo.Enabled = !a; btnmodificar.Enabled = !a;
            btnmasdetracion.Enabled = !a;
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
            CapaLogica.TablaComprobantes(cbotipodoc);
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
        public void Msg(string cadena)
        {
            HPResergerFunciones.Utilitarios.msg(cadena);
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
        }
        frmTipodeCambio frmtipo;
        public void SacarTipoCambio()
        {
            DateTime FechaValidaBuscar = dtpfechaemision.Value;
            txttipocambio.Text = CapaLogica.TipoCambioDia("Venta", FechaValidaBuscar).ToString("n3");
            if (txttipocambio.Text == "0.000")
            {
                if (frmtipo == null)
                {
                    frmtipo = new frmTipodeCambio();
                    frmtipo.Show();
                    frmtipo.comboMesAño1.ActualizarMesAÑo(FechaValidaBuscar.Month.ToString(), FechaValidaBuscar.Year.ToString());
                    frmtipo.Buscar_Click(new object(), new EventArgs());
                    frmtipo.BusquedaExterna = false;
                    frmtipo.Hide();
                    if (frmtipo.BusquedaExterna)
                    {
                        frmtipo.Close();
                        frmtipo = null;
                        SacarTipoCambio();
                    }
                }
            }
        }
        private void dtpfechaemision_ValueChanged(object sender, EventArgs e)
        {
            SacarTipoCambio();
            if (Dtgconten.RowCount > 0) btnAceptar.Enabled = false;
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
                        detracion = decimal.Parse(txttotalfac.Text.ToString()) * (numdetraccion.Value / 100);
                }
                numdetraccion.Enabled = false;
                if (Estado == 1 || Estado == 2 || Estado == 10)
                    btnmasdetracion.Enabled = true;
                else btnmasdetracion.Enabled = false;

                txtmontodetraccion.Text = detracion.ToString("n2");
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
        }
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
            else Msg("No hay Empresas");
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
            else Msg("No Hay Proyectos");
        }
        public void CalcularDiferenciaTOtalDetra()
        {
            txtDifDetra.Text = (decimal.Parse(txttotalfac.Text) - decimal.Parse(txtmontodetraccion.Text)).ToString("n2");
        }
        private void txttotalfac_TextChanged(object sender, EventArgs e)
        {
            decimal resul = 0;
            decimal.TryParse(txttotalfac.Text, out resul);
            detracion = resul * (numdetraccion.Value / 100);
            txtmontodetraccion.Text = detracion.ToString("n2");
            if (Dtgconten.RowCount > 0) btnAceptar.Enabled = false;
            //CalcularDiferenciaTOtalDetra();
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
                combo.DisplayMember = "Descripcion";
                combo.ValueMember = "codigo";
                combo.AutoComplete = true;
                combo.DataSource = TGrava;
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
                        decimal Valor = 0;
                        decimal.TryParse(Dtgconten[xImporteME.Name, x].Value == null ? "0" : Dtgconten[xImporteME.Name, x].Value.ToString(), out Valor);
                        Dtgconten[xImporteMN.Name, x].Value = Valor * decimal.Parse(txttipocambio.Text == ".000" ? "1" : txttipocambio.Text == "" ? "1" : txttipocambio.Text);
                    }
                }
                else if (y == Dtgconten.Columns[xImporteMN.Name].Index)
                {
                    if (cbomoneda.SelectedValue.ToString() == "1")
                    {
                        decimal Valor = 0;
                        decimal.TryParse(Dtgconten[xImporteMN.Name, x].Value == null ? "0" : Dtgconten[xImporteMN.Name, x].Value.ToString(), out Valor);
                        Dtgconten[xImporteME.Name, x].Value = Valor / decimal.Parse(txttipocambio.Text == ".000" ? "1" : txttipocambio.Text == "" ? "1" : txttipocambio.Text);
                    }
                }
                else
                if (y == Dtgconten.Columns[xDebeHaber.Name].Index)
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
        public DialogResult msgyes(string cadena)
        {
            return HPResergerFunciones.Utilitarios.msgYesNo(cadena);
        }
        private void Dtgconten_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Delete || e.KeyData == Keys.Back)
                if (Estado == 1 || Estado == 2)
                    if (msgyes("Desea Eliminar Filas") == DialogResult.Yes)
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
        int FacturaEstado = 0;
        private void btnAceptar_Click_1(object sender, EventArgs e)
        {
            if (Estado == 10)
            {
                CapaLogica.FacturaManualCabecera(_idFac, imgfactura);
                Msg($"Imagen de la Factura Actualizada Con Éxito");
                btnvistaPrevia.Visible = false;
                Estado = 0;
                btnAceptar.Enabled = btnCargarFoto.Enabled = false;
                Limpiar();
                CargarDatos();
                return;
            }
            if (Estado == 1 || Estado == 2)
            {
                DataTable TPrueba2 = CapaLogica.VerPeriodoAbierto((int)cboempresa.SelectedValue, dtpFechaContable.Value);
                if (TPrueba2.Rows.Count == 0) { Msg("El Periodo está Cerrado cambie la Fecha Contable"); dtpFechaContable.Focus(); return; }
                if (cboempresa.Items.Count == 0) { Msg("No hay Empresa"); cboempresa.Focus(); return; }
                if (cboproyecto.Items.Count == 0) { Msg("No hay Proyecto"); cboproyecto.Focus(); return; }
                if (cboetapa.Items.Count == 0) { Msg("No hay Etapa"); cboetapa.Focus(); return; }
                if (cbomoneda.Items.Count == 0) { Msg("No hay Moneda"); cbomoneda.Focus(); return; }
                if (cbotipodoc.Items.Count == 0) { Msg("No hay Tipo"); cbotipodoc.Focus(); return; }
                if (txtcodfactura.Text.Length == 0) { Msg($"Ingrese Codigo de {cbotipodoc.Text}"); txtcodfactura.Focus(); return; }
                if (txtnrofactura.Text.Length == 0) { Msg($"Ingrese Número de {cbotipodoc.Text}"); txtnrofactura.Focus(); return; }
                if (!txttotalfac.EstaLLeno()) { Msg("Ingrese Total del Comprobante"); txttotalfac.Focus(); return; }
                if (!txtruc.EstaLLeno()) { Msg("Ingrese RUC del Comprobante"); txtruc.Focus(); return; }
                if (cbodetraccion.Text == "SI") if (!txtdescdetraccion.EstaLLeno()) { Msg("Seleccione la Detracción"); cbodetraccion.Focus(); return; }
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
                    if (errorc || ErrorDH) { Msg(cadena); return; }
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
                if (OldEmpresa == (int)cboempresa.SelectedValue)
                {
                    if (OldFechaContable.Month == dtpFechaContable.Value.Month && OldFechaContable.Year == dtpFechaContable.Value.Year)
                    {
                        cuo = OldCuo;
                        codigo = int.Parse(OldCuo.Substring(5));
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
                    CapaLogica.EliminarAsiento(OldCuo, OldEmpresa, OldFechaContable);
            }
            else
                CapaLogica.UltimoAsiento((int)cboempresa.SelectedValue, dtpFechaContable.Value, out codigo, out cuo);
            ///fin de revision de la modificacion
            /////los estados
            if (Estado == 1)
            {
                /////VALIDO SI EXISTE LA FACTURA            
                DataTable Tprueba = CapaLogica.FacturaManualCabecera(txtruc.Text, txtcodfactura.Text + "-" + txtnrofactura.Text);
                if (Tprueba.Rows.Count > 0) { Msg("Ya Existe esta Factura Registrada"); return; }
                /////INSERTANDO LA FACTURA
                CapaLogica.FacturaManualCabecera(1, 0, (int)cbotipodoc.SelectedValue, txtcodfactura.Text + "-" + txtnrofactura.Text, txtruc.Text, (int)cboempresa.SelectedValue, (int)cboproyecto.SelectedValue, (int)cboetapa.SelectedValue, chkCompensa.Checked ? 1 : 0, (int)cbomoneda.SelectedValue,
                   decimal.Parse(txttipocambio.Text), decimal.Parse(txttotalfac.Text), TotalIgv, cbograba.SelectedIndex, dtpfechaemision.Value, dtpfecharecep.Value, dtpfechavence.Value, dtpFechaContable.Value, FacturaEstado, 0, "", cbodetraccion.Text == "NO" ? "" : coddet, numdetraccion.Value,
                  decimal.Parse(txtmontodetraccion.Text), imgfactura, txtglosa.TextValido(), frmLogin.CodigoUsuario);
                ////INSERTANDO EL DETALLE DE LA FACTURA
                foreach (DataGridViewRow item in Dtgconten.Rows)
                {
                    //int usua; if (item.Cells[xUsuario.Name].Value.ToString() == "999" || item.Cells[xUsuario.Name].Value.ToString() == "998") usua = 999; else usua = frmLogin.CodigoUsuario;
                    CapaLogica.FacturaManualDetalle(1, 0, (int)cbotipodoc.SelectedValue, txtcodfactura.Text + "-" + txtnrofactura.Text, txtruc.Text, item.Cells[xDebeHaber.Name].Value.ToString(),
                        item.Cells[xCuentaContable.Name].Value.ToString(), item.Cells[xCentroCosto.Name].Value.ToString(), item.Cells[xTipoIgvg.Name].Value.ToString() == "" ? 0 : (int)item.Cells[xTipoIgvg.Name].Value,
                     (decimal)item.Cells[xImporteMN.Name].Value, (decimal)item.Cells[xImporteME.Name].Value, item.Cells[xGlosa.Name].Value.ToString(), cuo, item.Cells[xUsuario.Name].Value.ToString() == "" ? frmLogin.CodigoUsuario : (int)item.Cells[xUsuario.Name].Value);
                }
                ////INSERTAR ASIENTO DE CABECERA Y DETALLE
                int i = 1;
                foreach (DataGridViewRow item in Dtgconten.Rows)
                {
                    if (item.Cells[xUsuario.Name].Value.ToString() != "998")
                    {
                        double vdebe = 0, vhaber = 0;
                        if (item.Cells[xDebeHaber.Name].Value.ToString() == "D") vdebe = double.Parse(item.Cells[xImporteMN.Name].Value.ToString());
                        if (item.Cells[xDebeHaber.Name].Value.ToString() == "H") vhaber = double.Parse(item.Cells[xImporteMN.Name].Value.ToString());
                        CapaLogica.InsertarAsiento(i, codigo, DateTime.Now, item.Cells[xCuentaContable.Name].Value.ToString(), vdebe, vhaber, -1, 1, dtpFechaContable.Value, (int)cboproyecto.SelectedValue, (int)cboetapa.SelectedValue, txtglosa.Text, (int)cbomoneda.SelectedValue, decimal.Parse(txttipocambio.Text));
                        ////DETALLE ASIENTO                        
                        CapaLogica.DetalleAsientos(1, i, codigo, item.Cells[xCuentaContable.Name].Value.ToString(), 5, txtruc.Text, txtrazon.Text, (int)cbotipodoc.SelectedValue, txtcodfactura.Text, txtnrofactura.Text,
                         item.Cells[xidcc.Name].Value.ToString() == "" ? 0 : (int)item.Cells[xidcc.Name].Value, item.Cells[xGlosa.Name].Value.ToString(), dtpfechaemision.Value, dtpfechavence.Value, (decimal)item.Cells[xImporteMN.Name].Value, (decimal)item.Cells[xImporteME.Name].Value,
                        decimal.Parse(txttipocambio.Text), frmLogin.CodigoUsuario, (int)cboproyecto.SelectedValue, dtpfecharecep.Value, (int)cbomoneda.SelectedValue, dtpFechaContable.Value, 0, 0, "");
                        ////contador para next valor
                        i++;
                    }
                }
                if (FacturaEstado == 0) Msg($"Factura Guardada Con Éxito"); else Msg($"Factura Guardada \nGenerado sus Asiento : {cuo} \nCon Éxito");
            }
            //////ACTUALIZANDO
            if (Estado == 2)
            {
                /////VALIDO SI YA EXISTE LA FACTURA               
                DataTable Tprueba = CapaLogica.FacturaManualCabecera(txtruc.Text, txtcodfactura.Text + "-" + txtnrofactura.Text, _idFac);
                if (Tprueba.Rows.Count > 0) { Msg("Ya Existe esta Factura Registrada"); return; }
                //////ACTUALIZANDO LA FACTURA
                CapaLogica.FacturaManualCabecera(2, _idFac, (int)cbotipodoc.SelectedValue, txtcodfactura.Text + "-" + txtnrofactura.Text, txtruc.Text, (int)cboempresa.SelectedValue, (int)cboproyecto.SelectedValue, (int)cboetapa.SelectedValue, chkCompensa.Checked ? 1 : 0, (int)cbomoneda.SelectedValue,
                   decimal.Parse(txttipocambio.Text), decimal.Parse(txttotalfac.Text), TotalIgv, cbograba.SelectedIndex, dtpfechaemision.Value, dtpfecharecep.Value, dtpfechavence.Value, dtpFechaContable.Value, FacturaEstado, 0, "", cbodetraccion.Text == "NO" ? "" : coddet, numdetraccion.Value,
                  decimal.Parse(txtmontodetraccion.Text), imgfactura, txtglosa.TextValido(), frmLogin.CodigoUsuario);
                ///BORRAMOS LOS DATOS ANTERIOES
                CapaLogica.FacturaManualDetalleRemover(txtcodfactura.Text + "-" + txtnrofactura.Text, txtruc.Text);
                ////INSERTANDO EL DETALLE DE LA FACTURA
                foreach (DataGridViewRow item in Dtgconten.Rows)
                {
                    //int usua; if (item.Cells[xUsuario.Name].Value.ToString() == "999" || item.Cells[xUsuario.Name].Value.ToString() == "998") usua = 999; else usua = frmLogin.CodigoUsuario;
                    CapaLogica.FacturaManualDetalle(1, 0, (int)cbotipodoc.SelectedValue, txtcodfactura.Text + "-" + txtnrofactura.Text, txtruc.Text, item.Cells[xDebeHaber.Name].Value.ToString(),
                        item.Cells[xCuentaContable.Name].Value.ToString(), item.Cells[xCentroCosto.Name].Value.ToString(), item.Cells[xTipoIgvg.Name].Value.ToString() == "" ? 0 : (int)item.Cells[xTipoIgvg.Name].Value,
                     (decimal)item.Cells[xImporteMN.Name].Value, (decimal)item.Cells[xImporteME.Name].Value, item.Cells[xGlosa.Name].Value.ToString(), cuo, item.Cells[xUsuario.Name].Value.ToString() == "" ? frmLogin.CodigoUsuario : (int)item.Cells[xUsuario.Name].Value);
                }
                int i = 1;
                foreach (DataGridViewRow item in Dtgconten.Rows)
                {
                    if (item.Cells[xUsuario.Name].Value.ToString() != "998")
                    {

                        double vdebe = 0, vhaber = 0;
                        if (item.Cells[xDebeHaber.Name].Value.ToString() == "D") vdebe = double.Parse(item.Cells[xImporteMN.Name].Value.ToString());
                        if (item.Cells[xDebeHaber.Name].Value.ToString() == "H") vhaber = double.Parse(item.Cells[xImporteMN.Name].Value.ToString());
                        CapaLogica.InsertarAsiento(i, codigo, DateTime.Now, item.Cells[xCuentaContable.Name].Value.ToString(), vdebe, vhaber, -1, 1, dtpFechaContable.Value, (int)cboproyecto.SelectedValue, (int)cboetapa.SelectedValue, txtglosa.Text, (int)cbomoneda.SelectedValue, decimal.Parse(txttipocambio.Text));
                        ////DETALLE ASIENTO                        
                        CapaLogica.DetalleAsientos(1, i, codigo, item.Cells[xCuentaContable.Name].Value.ToString(), 5, txtruc.Text, txtrazon.Text, (int)cbotipodoc.SelectedValue, txtcodfactura.Text, txtnrofactura.Text,
                        item.Cells[xidcc.Name].Value.ToString() == "" ? 0 : (int)item.Cells[xidcc.Name].Value, item.Cells[xGlosa.Name].Value.ToString(), dtpfechaemision.Value, dtpfechavence.Value, (decimal)item.Cells[xImporteMN.Name].Value, (decimal)item.Cells[xImporteME.Name].Value,
                        decimal.Parse(txttipocambio.Text), frmLogin.CodigoUsuario, (int)cboproyecto.SelectedValue, dtpfecharecep.Value, (int)cbomoneda.SelectedValue, dtpFechaContable.Value, 0, 0, "");
                        ////contador para next valor
                        i++;
                    }
                }
                /////FIN DE LA PARTE DE LOS ASIENTOS
                if (FacturaEstado == 0) Msg($"Factura Actualizada Con Éxito"); else Msg($"Factura Actualizada \nGenerado sus Asiento : {cuo} \nCon Éxito");
            }
            btnvistaPrevia.Visible = false;
            Estado = 0;
            ModoEdicion(false);
            btnAceptar.Enabled = false;
            Limpiar();
            CargarDatos();
        }
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
            }
            else Close();
            Estado = 0; btnvistaPrevia.Visible = false;
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
        }
        private void btnnuevo_Click(object sender, EventArgs e)
        {
            Estado = 1;
            ModoEdicion(true);
            Limpiar();
            if (Dtgconten.DataSource != null)
                Dtgconten.DataSource = ((DataTable)Dtgconten.DataSource).Clone();
            else Dtgconten.DataSource = CapaLogica.FacturaManualDetalleBusqueda("", "");
            btnAceptar.Enabled = true;
            dtpfechaemision_ValueChanged(sender, e);
            dtpfechavence.Value = DateTime.Now;
            BloquearColumnas();
        }
        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            if (msgyes("Eliminar Todas Las Filas") == DialogResult.Yes)
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
        private void btnmodificar_Click(object sender, EventArgs e)
        {
            if (Dtgconten.RowCount > 0)
            {
                DataTable TPrueba1 = CapaLogica.VerFacturasPagadasCompras(txtruc.Text, txtcodfactura.Text + '-' + txtnrofactura.Text);
                DataTable TPrueba2 = CapaLogica.VerPeriodoAbierto((int)cboempresa.SelectedValue, dtpFechaContable.Value);
                if (TPrueba1.Rows.Count > 0)
                {
                    ///Actualizar solo imagen
                    Estado = 10;
                    ///bloquear Controles
                    btnCargarFoto.Enabled = btnAceptar.Enabled = true;
                    Msg("La Factura ya tiene un Pago. \nSolo se puede Actualizar la Imagen.");
                    ModoEdicionFoto(true);
                }
                else if (TPrueba2.Rows.Count == 0)
                {
                    btnCargarFoto.Enabled = btnAceptar.Enabled = true;
                    Estado = 10;
                    Msg("La Factura Pertenece a un Periodo Cerrado. \nSolo se puede Actualizar la Imagen.");
                    ModoEdicionFoto(true);
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
            btnAceptar.Enabled = true;
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
                txttotalfac.Text = R.Cells[yTotal.Name].Value.ToString();
                chkCompensa.Checked = ((int)R.Cells[yCompensacion.Name].Value) == 1 ? true : false;
                TotalIgv = (decimal)R.Cells[yigv.Name].Value;
                /////CARGAR IMAGEN DE LA FACTURA
                imgfactura = null; frmimagen.Imagen = null;
                if (R.Cells[yImgFactura.Name].Value != null)
                    if (R.Cells[yImgFactura.Name].Value.ToString().Length > 0)
                    {
                        imgfactura = (byte[])R.Cells[yImgFactura.Name].Value;
                        MemoryStream ms = new MemoryStream(imgfactura);
                        frmimagen.Imagen = Image.FromStream(ms);
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
                    txtmontodetraccion.Text = detracion.ToString("n2");
                }
                btnmasdetracion.Enabled = false;
                txtmontodetraccion.Text = R.Cells[yDetraccion.Name].Value.ToString();
                //////CARGA DEL DETALLE DE LA FACTURA MANUAL
                Dtgconten.DataSource = CapaLogica.FacturaManualDetalleBusqueda(R.Cells[yProveedor.Name].Value.ToString(), R.Cells[yNroComprobante.Name].Value.ToString());
                ////valores para saber si se modifico (cuo asiento fecha empresa)
                if (Dtgconten.RowCount > 0)
                {
                    OldCuo = Dtgconten[xCodAsientoCtble.Name, 0].Value.ToString();
                    OldEmpresa = (int)R.Cells[yfkempresa.Name].Value;
                    OldFechaContable = (DateTime)R.Cells[yfechacontable.Name].Value;
                    OldId = (int)R.Cells[yid.Name].Value;
                }
                else OldCuo = null;
            }
        }
        private void textBoxPer1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxPer2_TextChanged(object sender, EventArgs e)
        {
            /////proceso de Busqueda
            CargarDatos();
        }
        private void txtbusempresa_TextChanged(object sender, EventArgs e)
        {

        }
        public void LimpiarBusquedas()
        {
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
                        ErrorM = true;
                        HPResergerFunciones.Utilitarios.ColorCeldaError(item.Cells[xImporteMN.Name]);
                    }
                    else HPResergerFunciones.Utilitarios.ColorCeldaDefecto(item.Cells[xImporteMN.Name]);
                    if ((item.Cells[xImporteME.Name].Value.ToString() == "" ? 0 : (decimal)item.Cells[xImporteME.Name].Value) <= 0)
                    {
                        ErrorM = true;
                        HPResergerFunciones.Utilitarios.ColorCeldaError(item.Cells[xImporteME.Name]);
                    }
                    else HPResergerFunciones.Utilitarios.ColorCeldaDefecto(item.Cells[xImporteME.Name]);
                    if (item.Cells[xDebeHaber.Name].Value.ToString() == "D")
                        if (item.Cells[xTipoIgvg.Name].Value.ToString() == "")
                        {
                            error = true;
                            HPResergerFunciones.Utilitarios.ColorCeldaError(item.Cells[xTipoIgvg.Name]);
                        }
                        else HPResergerFunciones.Utilitarios.ColorCeldaDefecto(item.Cells[xTipoIgvg.Name]);
                }
                string cadena = "";
                if (ErrorDH) { cadena += "Hay Errores en el Debe/Haber\n"; }
                if (conD == 0) { cadena += "No hay Cuenta Debe (Items)\n"; }
                if (conH == 0) { cadena += "No hay Cuenta Haber (Factura por Pagar)\n"; }
                if (error) { cadena += "Seleccion Tipo de IGV\n"; }
                if (errord) { cadena += "Hay Errores en las Cuentas\n"; }
                if (ErrorM) { cadena += "Hay Errores los Importe\n"; }
                /////VALIDACION
                if (conD == 0 || conH == 0 || error || errord || ErrorM || ErrorDH) { Msg(cadena); return; }
                ////FIN DE LAS VALIDACIONES
                /////CALCULO DE DETRACCIONES
                if (decimal.Parse(txtmontodetraccion.Text) > 0)
                {
                    DataTable Tprueba = CapaLogica.BuscarCuentas("DETRACCIONES POR PAGAR", 5);
                    if (Tprueba.Rows.Count > 0)
                    {
                        DataRow filita = Tprueba.Rows[0];
                        DataRow fila = TDatos.NewRow();
                        fila[xDebeHaber.DataPropertyName] = "H";
                        fila[xCuentaContable.DataPropertyName] = filita["cuenta_contable"].ToString().Substring(0, 7);
                        fila[xdescripcion.DataPropertyName] = filita["cuenta_contable"].ToString();
                        fila[xUsuario.DataPropertyName] = 999;///por defecto
                        fila[xGlosa.DataPropertyName] = glosa;
                        fila[xCodAsientoCtble.DataPropertyName] = cuo;
                        if ((int)cbomoneda.SelectedValue == 1)
                        {
                            fila[xImporteMN.DataPropertyName] = decimal.Parse(txtmontodetraccion.Text);
                            fila[xImporteME.DataPropertyName] = decimal.Parse(txtmontodetraccion.Text) / decimal.Parse(txttipocambio.Text);
                        }
                        if ((int)cbomoneda.SelectedValue == 2)
                        {
                            fila[xImporteME.DataPropertyName] = decimal.Parse(txtmontodetraccion.Text);
                            fila[xImporteMN.DataPropertyName] = decimal.Parse(txtmontodetraccion.Text) * decimal.Parse(txttipocambio.Text);
                        }
                        TDatos.Rows.Add(fila);
                    }
                } //////VAMOS CON EL IGV
                decimal igvs = (decimal)(CapaLogica.ValorIGVactual(dtpfechaemision.Value))["Valor"];
                string CuentaIgv = "4011101";
                DataTable Tpruebas = CapaLogica.BuscarCuentas("IGV % COM", 5);
                if (Tpruebas.Rows.Count > 0)
                {
                    CuentaIgv = (Tpruebas.Rows[0])["cuenta_contable"].ToString();
                }
                /////CALCULO DE LOS REFLEJOS
                TotalIgv = 0;
                foreach (DataGridViewRow item in Dtgconten.Rows)
                {
                    if (item.Cells[xDebeHaber.Name].Value.ToString().ToUpper() == "D")
                    {
                        DataTable Tprueba = CapaLogica.CuentasReflejo(item.Cells[xCuentaContable.Name].Value.ToString());
                        if (Tprueba.Rows.Count > 0)
                        {
                            DataRow filita = Tprueba.Rows[0];
                            if (filita["reflejadebe"].ToString() != "")
                            {
                                DataRow fila = CLonarCOlumnas(Dtgconten.Rows[item.Index], TDatos);
                                fila[xDebeHaber.DataPropertyName] = "D";
                                fila[xCuentaContable.DataPropertyName] = filita["reflejadebe"].ToString();
                                fila[xdescripcion.DataPropertyName] = filita["Namedebe"].ToString();
                                fila[xUsuario.DataPropertyName] = 998;///por defecto
                                fila[xCodAsientoCtble.DataPropertyName] = cuo;
                                TDatos.Rows.Add(fila);
                                DataRow xfila = CLonarCOlumnas(Dtgconten.Rows[item.Index], TDatos);
                                xfila[xDebeHaber.DataPropertyName] = "H";
                                xfila[xCuentaContable.DataPropertyName] = filita["reflejahaber"].ToString();
                                xfila[xdescripcion.DataPropertyName] = filita["Namehaber"].ToString();
                                xfila[xUsuario.DataPropertyName] = 998;///por defecto
                                xfila[xCodAsientoCtble.DataPropertyName] = cuo;
                                TDatos.Rows.Add(xfila);
                            }
                        }
                        if ((int)item.Cells[xTipoIgvg.Name].Value != 4)
                        {
                            DataRow filaIgv = CLonarCOlumnas(Dtgconten.Rows[item.Index], TDatos);
                            filaIgv[xDebeHaber.DataPropertyName] = "D";
                            filaIgv[xCuentaContable.DataPropertyName] = CuentaIgv.Substring(0, 7);
                            filaIgv[xdescripcion.DataPropertyName] = CuentaIgv;
                            filaIgv[xUsuario.DataPropertyName] = 999;///por defecto
                            filaIgv[xImporteME.DataPropertyName] = (decimal)item.Cells[xImporteME.Name].Value * igvs;
                            filaIgv[xImporteMN.DataPropertyName] = (decimal)item.Cells[xImporteMN.Name].Value * igvs;
                            ///soles
                            if ((int)cbomoneda.SelectedValue == 1)
                                TotalIgv += (decimal)item.Cells[xImporteMN.Name].Value * igvs;
                            else TotalIgv += (decimal)item.Cells[xImporteME.Name].Value * igvs;
                            filaIgv[xCentroCosto.DataPropertyName] = "";
                            filaIgv[xCentroCostoDesc.DataPropertyName] = "";
                            filaIgv[xCodAsientoCtble.DataPropertyName] = cuo;
                            TDatos.Rows.Add(filaIgv);
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
                        conme += decimal.Parse(((decimal)item.Cells[xImporteME.Name].Value).ToString("n2"));
                        conmn += decimal.Parse(((decimal)item.Cells[xImporteMN.Name].Value).ToString("n2"));

                    }
                    if (item.Cells[xDebeHaber.Name].Value.ToString().ToUpper() == "H")
                    {
                        conme -= decimal.Parse(((decimal)item.Cells[xImporteME.Name].Value).ToString("n2"));
                        conmn -= decimal.Parse(((decimal)item.Cells[xImporteMN.Name].Value).ToString("n2"));
                    }
                }

                TDatos = TDatos.Clone();
                // Msg($"hay diferencia {conme}  :  {conmn}");
                if (conme != 0 || conmn != 0)
                {
                    string CuentaRedondeo = "";
                    string DH = "";
                    DataTable Tpruebass = new DataTable();
                    if (conme > 0 || conmn > 0)
                    {
                        Tpruebass = CapaLogica.BuscarCuentas("INGRESOS POR REDONDEO", 5);
                        DH = "H";
                    }
                    if (conme < 0 || conmn < 0)
                    {
                        DH = "D";
                        Tpruebass = CapaLogica.BuscarCuentas("PERDIDAS POR REDONDEO", 5);
                    }
                    if (Tpruebass.Rows.Count > 0)
                    {
                        CuentaRedondeo = (Tpruebass.Rows[0])["cuenta_contable"].ToString();
                    }
                    DataRow filita = Tpruebass.Rows[0];
                    DataRow fila = TDatos.NewRow();
                    fila[xDebeHaber.DataPropertyName] = DH;
                    fila[xCuentaContable.DataPropertyName] = filita["cuenta_contable"].ToString().Substring(0, 7);
                    fila[xdescripcion.DataPropertyName] = filita["cuenta_contable"].ToString();
                    fila[xUsuario.DataPropertyName] = 999;///por defecto
                    fila[xGlosa.DataPropertyName] = "Redondeo en registro";
                    fila[xCentroCosto.DataPropertyName] = "9999 - 999";
                    fila[xImporteME.DataPropertyName] = Math.Abs(conme);
                    fila[xImporteMN.DataPropertyName] = Math.Abs(conmn);
                    fila[xCodAsientoCtble.DataPropertyName] = cuo;
                    TDatos.Rows.Add(fila);
                }
                ((DataTable)Dtgconten.DataSource).Merge(TDatos);
                btnAceptar.Enabled = true;
            }
            else
            {
                Msg("No hay Filas");
            }
        }
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
            if (x >= 0)
            {
                DataGridViewRow R = Dtgconten.Rows[x];
                if (R.Cells[xUsuario.Name].Value != null)
                    if ((R.Cells[xUsuario.Name].Value.ToString() == "" ? 0 : (int)R.Cells[xUsuario.Name].Value) >= 998)
                        Dtgconten.Rows[x].DefaultCellStyle.ForeColor = Color.FromArgb(192, 80, 77);
                    else Dtgconten.Rows[x].DefaultCellStyle.ForeColor = Color.Black;
            }
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
            if (msgyes("Desea Eliminar la Imagen") == DialogResult.Yes)
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
            if (dtgBusqueda.RowCount > 0)
            {
                if (Dtgconten.RowCount == 0)
                {
                    if (msgyes("Seguro Desea Eliminar Factura") == DialogResult.Yes)
                    {
                        CapaLogica.FacturaManualCabeceraRemover((int)dtgBusqueda[yid.Name, dtgBusqueda.CurrentRow.Index].Value);
                        Msg("Eliminado Con Éxito");
                        textBoxPer2_TextChanged(sender, e);
                    }
                }
                else
                {
                    if (msgyes("Seguro Desea Eliminar Factura con su Asiento") == DialogResult.Yes)
                    {
                        DataTable TPrueba1 = CapaLogica.VerFacturasPagadasCompras(txtruc.Text, txtcodfactura.Text + '-' + txtnrofactura.Text);
                        DataTable TPrueba2 = CapaLogica.VerPeriodoAbierto((int)cboempresa.SelectedValue, dtpFechaContable.Value);
                        if (TPrueba1.Rows.Count > 0)
                        {
                            Msg("La Factura ya tiene un Pago.");
                            return;
                        }
                        else if (TPrueba2.Rows.Count == 0)
                        {
                            Msg("La Factura Pertenece a un Periodo Cerrado.");
                            return;
                        }
                        if (OldCuo != null)
                        {
                            CapaLogica.EliminarAsiento(OldCuo, OldEmpresa, OldFechaContable);
                            CapaLogica.FacturaManualCabeceraRemover((int)dtgBusqueda[yid.Name, dtgBusqueda.CurrentRow.Index].Value);
                            CapaLogica.FacturaManualDetalleRemover(txtcodfactura.Text + "-" + txtnrofactura.Text, txtruc.Text);
                            Msg("Eliminado Con Éxito");
                            textBoxPer2_TextChanged(sender, e);
                        }
                    }
                }
            }
        }
    }
}
