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
    public partial class frmCotizacionCliente : FormGradient
    {
        public frmCotizacionCliente()
        {
            InitializeComponent();
        }
        public int LengthTipoId
        {
            get { return txtnroid.MaxLength; }
            set { txtnroid.MaxLength = value; }
        }
        public void msg(string cadena) { HPResergerFunciones.frmInformativo.MostrarDialogError(cadena); }
        public void msgOK(string cadena) { HPResergerFunciones.frmInformativo.MostrarDialog(cadena); }
        HPResergerCapaLogica.HPResergerCL CapaLogica = new HPResergerCapaLogica.HPResergerCL();
        int estado = 0;
        DataTable Tproductos;
        DataTable TEmpresa;
        DataTable TDescuentos;
        int numero = 0;
        DataTable TEtapas;
        private void frmCotizacionCliente_Load(object sender, EventArgs e)
        {
            LimpiarTextBoxs();
            CargarCombitoTipoid();
            ModoMuestra();
            cbotipoid.Enabled = true;
            txtnroid.ReadOnly = false; CargarDescuentos(); CargarEtapas();
            Tproductos = CapaLogica.Proyecto_ProductosxCod(0).Clone();
            dtgconten.DataSource = Tproductos;
            dtfechaVen.MinDate = Hoy;
            txtNombreVendedor.CargarTextoporDefecto();
            DataRow filita = (CapaLogica.CotizacionDetalleNroCod(out numero)).Rows[0];
            //msg($"aqui esta el numero {numero}");
            txtnumcot.Text = ((int)filita["ultimo"]).ToString("00000");
            LimpiarBusqueda();
            CArgarBusqueda();
        }
        public void LimpiarBusqueda()
        {
            LimpiarBusquedas(txtbusnombrecliente, txtbusnrodoc, txtbusnumcot, txtbustipoid, txtcodvendedor);
        }
        public void LimpiarBusquedas(params TextBoxPer[] controles)
        {
            foreach (TextBoxPer control in controles)
                control.CargarTextoporDefecto();
        }
        public void CargarDescuentos()
        {
            TDescuentos = new DataTable();
            TDescuentos.Columns.Add("codigo", typeof(int));
            TDescuentos.Columns.Add("valor");
            TDescuentos.Rows.Add(0, "Porcentaje");
            TDescuentos.Rows.Add(1, "Monto");
        }
        public void CargarEtapas()
        {
            TEtapas = new DataTable();
            TEtapas.Columns.Add("codigo");
            TEtapas.Rows.Add("Preventa");
            TEtapas.Rows.Add("Venta");
        }
        public void LimpiarTextBoxs()
        {
            LimpiarControlesEdicion(txtdireccion, txtemail, txtnombre, txtnroid, txtocupacion, txttelcelular, txttelfijo);
        }
        public void ModoMuestra()
        {
            Configuraciones.Activar(dtgconten);
            Configuraciones.Desactivar(txtdireccion, txtemail, txtnombre, txtnroid, txtocupacion, txttelcelular, txttelfijo, txtubicacion);
        }
        public void ModoEdicion()
        {
            //proceso de edicion------
            Configuraciones.Activar(txtdireccion, txtemail, txtnombre, txtnroid, txtocupacion, txttelcelular, txttelfijo);
            Configuraciones.Desactivar(dtgconten);
        }
        public void CargarCombitoTipoid()
        {
            cbotipoid.ValueMember = "codigo";
            cbotipoid.DisplayMember = "valor";
            cbotipoid.DataSource = CapaLogica.TiposID(0, 0, "", 0);
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
        DataRow TiposId;
        private void cbotipoid_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbotipoid.SelectedIndex >= 0)
            {
                TiposId = (CapaLogica.TiposID((int)cbotipoid.SelectedValue)).Rows[0]; ////Length
                LengthTipoId = (int)TiposId["Length"];
            }
            txtnroid_TextChanged(sender, e);
        }
        DataTable TablaCLiente;
        private void txtnroid_TextChanged(object sender, EventArgs e)
        {
            ///PROCESO DE BUSQUEDA DE CLIENTE
            if (cbotipoid.SelectedIndex >= 0)
            {
                btncotizar.Enabled = false;
                TablaCLiente = CapaLogica.BuscarCliente((int)cbotipoid.SelectedValue, txtnroid.TextValido());
                if (TablaCLiente.Rows.Count != 0)
                {
                    DataRow filita = TablaCLiente.Rows[0];
                    //txtapemat.Text = filita["Apemat_Cli"].ToString();
                    //txtapetpat.Text = filita["Apepat_RazSoc_Cli"].ToString();
                    txtdireccion.Text = filita["Direccion"].ToString();
                    txtemail.Text = filita["E_mail"].ToString();
                    txtnombre.Text = filita["apellidos"].ToString();
                    txtocupacion.Text = filita["Ocupacion"].ToString();
                    txttelcelular.Text = filita["Telf_Celular"].ToString();
                    txttelfijo.Text = filita["Telf_Fijo"].ToString();
                    txtubicacion.Text = $"{Configuraciones.MayusculaCadaPalabra(filita["Ddepartamento"].ToString())} - {Configuraciones.MayusculaCadaPalabra(filita["dprovincia"].ToString())} - {Configuraciones.MayusculaCadaPalabra(filita["ddistrito"].ToString())} ";
                    btncotizar.Enabled = true;
                }
                else LimpiarControles(txtdireccion, txtemail, txtnombre, txtocupacion, txttelcelular, txttelfijo, txtubicacion);
            }
        }
        private void LimpiarControles(params object[] control)
        {
            foreach (object item in control)
            {
                if (((Control)item).AccessibilityObject.Role == AccessibleRole.ComboBox)
                    ((ComboBoxPer)item).SelectedIndex = -1;
                else
                {
                    ((TextBoxPer)item).CargarTextoporDefecto();
                }
            }
        }
        private void btnbuscar_Click(object sender, EventArgs e)
        {
            frmClientes frmclien = new frmClientes();
            //frmclien.rdnrodoc.Checked = true;
            frmclien.codigoid = (int)cbotipoid.SelectedValue;
            frmclien.CodigoDocBuscar = txtnroid.TextValido();
            frmclien.Buscando = true;
            if (frmclien.ShowDialog() == DialogResult.OK)
            {
                cbotipoid.SelectedValue = frmclien.codigoid;
                txtnroid.Text = frmclien.codigodoc;
                txtnroid_TextChanged(sender, e);
            }
            frmclien = null;
        }
        public void ProcesoDeCotizar(Boolean Cotizar)
        {
            cbotipoid.Enabled = !Cotizar;
            txtnroid.ReadOnly = Cotizar;
            btncotizar.Enabled = !Cotizar;
            btnaceptar.Enabled = Cotizar;
            btnbuscar.Enabled = !Cotizar;
            dtgconten.ReadOnly = !Cotizar;
        }
        private void btncotizar_Click(object sender, EventArgs e)
        {
            estado = 1;
            ProcesoDeCotizar(true);
            btnproductos.Enabled = true;
            PanelObservaciones.Enabled = true;
            LimpiarCabecera();
            numValidesdias_ValueChanged(sender, new EventArgs());
            MostrarColumnas(true);
        }
        public void LimpiarCabecera()
        {
            txtsubtotal.CargarTextoporDefecto();
            txtigv.CargarTextoporDefecto();
            txttotal.CargarTextoporDefecto();
            txttipocambioref.Text = "3.30";
            txtobservacion.CargarTextoporDefecto();
            txtValorInicial.CargarTextoporDefecto();
        }
        private void btncancelar_Click(object sender, EventArgs e)
        {
            if (estado == 0)
            {
                this.Close();
            }
            else if (estado == 1)
            {
                if (msgp("Serguro Desea Cancelar") == DialogResult.No) { return; }
                ProcesoDeCotizar(false);
            }
                    ((DataTable)(dtgconten.DataSource)).Rows.Clear();
            estado = 0; PanelObservaciones.Enabled = false;
            btnproductos.Enabled = false;
            LimpiarCabecera();
        }
        List<int> Lista = new List<int>();
        public void ReCargarLista()
        {
            Lista.Clear();
            foreach (DataGridViewRow item in dtgconten.Rows)
            {
                if (item.Cells[Producto.Name].Value.ToString() != "")
                {
                    int value = (int)item.Cells[Producto.Name].Value;
                    if (Lista.Find(cust => cust == value) == 0)
                    {
                        Lista.Add(value);
                    }
                }
            }
        }
        private void btnproductos_Click(object sender, EventArgs e)
        {
            frmListarProductosVenta frmlistproduc = new frmListarProductosVenta();
            frmlistproduc.ShowDialog();
            if (frmlistproduc.Codigos.Count > 0)
            {
                ReCargarLista();
                foreach (int item in frmlistproduc.Codigos)
                {
                    if (Lista.Find(cust => cust == item) == 0)
                    {
                        Lista.Add(item);
                        DataRow filita = (CapaLogica.Proyecto_ProductosxCod(item)).Rows[0];
                        filita["cantidad"] = 1;
                        Tproductos.ImportRow(filita);
                    }
                }
                foreach (DataGridViewRow item in dtgconten.Rows)
                {
                    CalcularMontos(item);
                }
                SacarTotales();
                RefreshPRoducts();
            }
        }
        public void RefreshPRoducts()
        {
            //proceso de refresh por carga de datos --da error en el datagrid
            foreach (DataGridViewRow item in dtgconten.Rows)
                dtgconten_RowEnter(new object(), new DataGridViewCellEventArgs(idempresa.Index, item.Index));
        }
        public class Productos
        {
            public int _CodProducto;
            public decimal _Cantidad;
            public string _NameProduc;
            public Productos(int codproduc, decimal cantidad)
            {
                _CodProducto = codproduc;
                _Cantidad = cantidad;
            }
            public Productos(int codproduc, decimal cantidad, string name)
            {
                _CodProducto = codproduc;
                _Cantidad = cantidad;
                _NameProduc = name;
            }
        }
        List<Productos> ListProduc;
        private void btnaceptar_Click(object sender, EventArgs e)
        {
            if (!txtnroid.EstaLLeno()) { txtnroid.Focus(); msg("Ingrese Numero Documento del Cliente"); return; }
            if (cbotipoid.SelectedIndex < 0) { cbotipoid.Focus(); msg("Seleccione Tipo de Documento del Cliente"); return; }
            Boolean prueba = false;
            Boolean _moneda = false;
            Boolean _empresa = false;
            string ValMoneda = dtgconten[monedon.Name, 0].Value.ToString();
            string ValEmpresa = dtgconten[idempresa.Name, 0].Value.ToString();
            foreach (DataGridViewRow item in dtgconten.Rows)
            {
                //CANTIDAD
                if (item.Cells[Cantidad.Name].Value.ToString() == "") { prueba = true; HPResergerFunciones.Utilitarios.ColorCeldaError(item.Cells[Cantidad.Name]); }
                else
                if ((decimal)item.Cells[Cantidad.Name].Value <= 0) { prueba = true; HPResergerFunciones.Utilitarios.ColorCeldaError(item.Cells[Cantidad.Name]); }
                else { HPResergerFunciones.Utilitarios.ColorCeldaDefecto(item.Cells[Cantidad.Name]); }
                //VALOR DESCUENTO
                if (item.Cells[VDesc.Name].Value.ToString() == "") { prueba = true; HPResergerFunciones.Utilitarios.ColorCeldaError(item.Cells[VDesc.Name]); }
                else
                if ((decimal)item.Cells[VDesc.Name].Value < 0) { prueba = true; HPResergerFunciones.Utilitarios.ColorCeldaError(item.Cells[VDesc.Name]); }
                else { HPResergerFunciones.Utilitarios.ColorCeldaDefecto(item.Cells[VDesc.Name]); }
                //PRECIO VENTA
                if (item.Cells[Precio_Base.Name].Value.ToString() == "") { prueba = true; HPResergerFunciones.Utilitarios.ColorCeldaError(item.Cells[Precio_Base.Name]); }
                else
                if ((decimal)item.Cells[Precio_Base.Name].Value <= 0) { prueba = true; HPResergerFunciones.Utilitarios.ColorCeldaError(item.Cells[Precio_Base.Name]); }
                else { HPResergerFunciones.Utilitarios.ColorCeldaDefecto(item.Cells[Precio_Base.Name]); }
                //PROYECTO
                if (item.Cells[idproyecto.Name].Value.ToString() == "") { prueba = true; HPResergerFunciones.Utilitarios.ColorCeldaError(item.Cells[idproyecto.Name]); }
                else { HPResergerFunciones.Utilitarios.ColorCeldaDefecto(item.Cells[idproyecto.Name]); }
                //PRODUCTO
                if (item.Cells[Producto.Name].Value.ToString() == "") { prueba = true; HPResergerFunciones.Utilitarios.ColorCeldaError(item.Cells[idarticulo.Name]); }
                else { HPResergerFunciones.Utilitarios.ColorCeldaDefecto(item.Cells[idarticulo.Name]); }
                //Moneda
                if (item.Cells[monedon.Name].Value.ToString() != ValMoneda) { prueba = true; _moneda = true; HPResergerFunciones.Utilitarios.ColorCeldaError(item.Cells[monedon.Name]); }
                else { HPResergerFunciones.Utilitarios.ColorCeldaDefecto(item.Cells[monedon.Name]); }
                //empresa
                if (item.Cells[idempresa.Name].Value.ToString() != ValEmpresa) { prueba = true; _empresa = true; HPResergerFunciones.Utilitarios.ColorCeldaError(item.Cells[idempresa.Name]); }
                else { HPResergerFunciones.Utilitarios.ColorCeldaDefecto(item.Cells[idmoneda.Name]); }
            }
            string cade1 = "", cade2 = "";
            if (_moneda) cade1 = "\nLos Productos deben tener una sola Moneda";
            if (_empresa) cade2 = "\nSolo puede Vender de una sola Empresa";
            if (prueba) { msg($"Hay Errores en la Grilla {cade1 + cade2}"); return; }
            if (VerificarStock()) { return; }
            if (!txtNombreVendedor.EstaLLeno()) { txtcodvendedor.Focus(); msg("Ingrese el Código del Vendedor Valido!"); return; }
            //PROCESO DE GRABACION EN LA BASE DE DATOS 
            ////LA CABECERA
            CapaLogica.CotizacionesCLienteCabecera(out numero, 1, int.Parse(txtcodvendedor.Text), dtfechaVen.Value, decimal.Parse(txtsubtotal.Text), decimal.Parse(txtigv.Text), decimal.Parse(txttotal.Text), (int)cbotipoid.SelectedValue, txtnroid.Text, 1, txtobservacion.Text, frmLogin.CodigoUsuario, decimal.Parse(txtValorInicial.Text));
            //DETALLE
            foreach (DataGridViewRow item in dtgconten.Rows)
            {
                CapaLogica.CotizacionesCLienteCabeceraDetalle(1, numero, (int)item.Cells[idempresa.Name].Value, (int)item.Cells[idproyecto.Name].Value, item.Cells[Etapa.Name].Value.ToString(), (int)item.Cells[Producto.Name].Value, (decimal)item.Cells[Cantidad.Name].Value, (decimal)item.Cells[Precio_Base.Name].Value, decimal.Parse(txttipocambioref.Text), (int)item.Cells[TDesc.Name].Value, (decimal)item.Cells[VDesc.Name].Value, (decimal)item.Cells[P_Coti.Name].Value, (decimal)item.Cells[xsubtotal.Name].Value, (decimal)item.Cells[xigv.Name].Value, (int)item.Cells[idmoneda.Name].Value, (decimal)item.Cells[PInicial.Name].Value, (int)item.Cells[tipo_inicial.Name].Value, (decimal)item.Cells[valor_inicial.Name].Value);
            }
            msgOK($"Cotización Nro: {numero.ToString("00000")}, Asociado Exitosamente ");
            //CIERRE
            ProcesoDeCotizar(false);
            ((DataTable)(dtgconten.DataSource)).Rows.Clear();
            estado = 0; PanelObservaciones.Enabled = false;
            btnproductos.Enabled = false;
            LimpiarCabecera();
            CArgarBusqueda();
            MostrarColumnas(true);
        }
        public void MostrarColumnas(Boolean a)
        {
            foreach (DataGridViewColumn item in dtgconten.Columns)
            {
                if (item.DataPropertyName == PInicial.DataPropertyName || item.DataPropertyName == Observacion.DataPropertyName || item.DataPropertyName == Precio_Base.DataPropertyName || item.DataPropertyName == P_Coti.DataPropertyName || item.DataPropertyName == xsubtotal.DataPropertyName || item.DataPropertyName == xigv.DataPropertyName || item.DataPropertyName == EstadoLetras.DataPropertyName || monedon.DataPropertyName == item.DataPropertyName)
                    item.ReadOnly = a;
            }
        }
        public Boolean VerificarStock()
        {
            ListProduc = new List<Productos>();
            foreach (DataGridViewRow item in dtgconten.Rows)
            {
                int code = (int)item.Cells[Producto.Name].Value;
                decimal canti = (decimal)item.Cells[Cantidad.Name].Value;
                string name = item.Cells[idarticulo.Name].Value.ToString();
                Productos aux = ListProduc.Find(cust => cust._CodProducto == code);
                if (aux == null)
                {
                    Productos pro = new Productos(code, canti, name);
                    ListProduc.Add(pro);
                }
                else
                {
                    aux._Cantidad += canti;
                }
            }
            //fin de carga de lista de productos
            string mensaje = "No hay Stock de los Siguientes Productos\n";
            Boolean prueba = false;
            //VALORES POR DEFECTO DE LAS CELDAS
            foreach (DataGridViewRow items in dtgconten.Rows)
            {
                HPResergerFunciones.Utilitarios.ColorCeldaDefecto(items.Cells[Cantidad.Name]);
                HPResergerFunciones.Utilitarios.ColorCeldaDefecto(items.Cells[Observacion.Name]);
            }
            //default
            foreach (Productos item in ListProduc)
            {
                DataTable Taux = CapaLogica.DetalleProducto(item._CodProducto);
                if (Taux.Rows.Count == 0)
                {
                    //buscar por que ya no existe
                    mensaje += $"{item._NameProduc}: 0 /{item._Cantidad}  \n";
                    foreach (DataGridViewRow items in dtgconten.Rows)
                    {
                        if ((int)items.Cells[Producto.Name].Value == item._CodProducto)
                        {
                            ///pintamos de colores
                            prueba = true;
                            HPResergerFunciones.Utilitarios.ColorCeldaError(items.Cells[Cantidad.Name]);
                            HPResergerFunciones.Utilitarios.ColorCeldaError(items.Cells[Observacion.Name]);
                        }
                    }
                }
                else
                {
                    DataRow filita = Taux.Rows[0];
                    if ((decimal)filita["cantidad"] < item._Cantidad)
                    {
                        ///no hay stock!!!!!!!!!
                        mensaje += $"{item._NameProduc}: {((decimal)filita["cantidad"]).ToString("n0")}/{item._Cantidad}\n";
                        foreach (DataGridViewRow items in dtgconten.Rows)
                        {
                            if ((int)items.Cells[Producto.Name].Value == item._CodProducto)
                            {
                                ///pintamos de colores
                                prueba = true;
                                HPResergerFunciones.Utilitarios.ColorCeldaError(items.Cells[Cantidad.Name]);
                                HPResergerFunciones.Utilitarios.ColorCeldaError(items.Cells[Observacion.Name]);
                            }
                        }
                    }
                }
            }
            if (mensaje != "No hay Stock de los Siguientes Productos\n") msg(cadena: mensaje);
            return prueba;
        }
        private void txttelcelular_TextChanged(object sender, EventArgs e)
        {
        }
        private void txtocupacion_TextChanged(object sender, EventArgs e)
        {
        }
        private void dtgconten_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            CargarTotales();
        }
        private void dtgconten_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            CargarTotales();
        }
        public void CargarTotales()
        {
            lblmsg.Text = $"Total de Registros: {dtgconten.RowCount}";
        }
        private void numValidesdias_ValueChanged(object sender, EventArgs e)
        {
            dtfechaVen.Value = Hoy.AddDays((double)numValidesdias.Value - 1);
        }
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            TimeSpan tp = new TimeSpan();
            DateTime dt = (dtfechaVen.Value.AddDays(1)).Date;

            tp = dt - Hoy.Date;
            numValidesdias.Value = tp.Days;
        }
        DataGridViewComboBoxColumn combo;
        private void dtgconten_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            int x = e.RowIndex, y = e.ColumnIndex;
            if (x >= 0)
            {
                //Empresas
                combo = dtgconten.Columns[idempresa.Name] as DataGridViewComboBoxColumn;
                TEmpresa = CapaLogica.ListarEmpresas();
                combo.DisplayMember = "empresa";
                combo.ValueMember = "id_empresa";
                combo.DataSource = TEmpresa;
                //Descuentos
                combo = dtgconten.Columns[TDesc.Name] as DataGridViewComboBoxColumn;
                combo.DisplayMember = "valor";
                combo.ValueMember = "codigo";
                combo.DataSource = TDescuentos;
                //Etapas
                combo = dtgconten.Columns[Etapa.Name] as DataGridViewComboBoxColumn;
                combo.DisplayMember = "codigo";
                combo.ValueMember = "codigo";
                combo.DataSource = TEtapas;
                //Proyectos
                DataGridViewComboBoxCell combox = dtgconten.Rows[x].Cells[idproyecto.Name] as DataGridViewComboBoxCell;
                combox.DisplayMember = "Proyecto";
                combox.ValueMember = "Id_Proyecto";
                combox.DataSource = CapaLogica.ListarProyectosEmpresa(dtgconten[idempresa.Name, x].Value.ToString());
                //productos
                DataGridViewComboBoxCell comboxs = dtgconten.Rows[x].Cells[Producto.Name] as DataGridViewComboBoxCell;
                comboxs.DisplayMember = "producto";
                comboxs.ValueMember = "idarticulo";
                if (dtgconten[idproyecto.Name, x].Value.ToString() != "")
                    comboxs.DataSource = CapaLogica.Proyecto_ProductosxProyecto((int)dtgconten[idproyecto.Name, x].Value);
            }
        }
        private void dtgconten_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            int x = e.RowIndex, y = e.ColumnIndex;
            if (dtgconten.RowCount > 0)
            {
                if (y == dtgconten.Columns[idempresa.Name].Index)
                {
                    DataGridViewComboBoxCell combox = dtgconten.Rows[x].Cells[idproyecto.Name] as DataGridViewComboBoxCell;
                    combox.DisplayMember = "Proyecto";
                    combox.ValueMember = "Id_Proyecto";
                    combox.DataSource = CapaLogica.ListarProyectosEmpresa(dtgconten[idempresa.Name, x].Value.ToString());
                }
                if (y == dtgconten.Columns[idproyecto.Name].Index)
                {
                    DataGridViewComboBoxCell combox = dtgconten.Rows[x].Cells[Producto.Name] as DataGridViewComboBoxCell;
                    combox.DisplayMember = "producto";
                    combox.ValueMember = "idarticulo";
                    combox.DataSource = CapaLogica.Proyecto_ProductosxProyecto((int)dtgconten[idproyecto.Name, x].Value);
                }
                //si se modifica el producto o la etapa
                if (y == dtgconten.Columns[Producto.Name].Index || y == dtgconten.Columns[Etapa.Name].Index || y == dtgconten.Columns[TDesc.Name].Index)
                {
                    if (dtgconten[Producto.Name, x].Value.ToString() != "")
                    {
                        int valor = (int)dtgconten[Producto.Name, x].Value;
                        string etapita = dtgconten[Etapa.Name, x].Value.ToString();
                        DataRow filita = (CapaLogica.Proyecto_ProductosxCod(valor, etapita)).Rows[0];
                        DataGridViewRow item = dtgconten.Rows[x];
                        item.Cells[idarticulo.Name].Value = filita["idarticulo"];
                        item.Cells[Observacion.Name].Value = Configuraciones.MayusculaCadaPalabra(filita["Observacion"].ToString());
                        item.Cells[Precio_Base.Name].Value = filita["PVta"];
                        item.Cells[Etapa.Name].Value = filita["Etapa"];
                        item.Cells[EstadoLetras.Name].Value = filita["EstadoLetras"];
                        if (item.Cells[TDesc.Name].Value.ToString() == "") { item.Cells[TDesc.Name].Value = 0; }
                        if (item.Cells[VDesc.Name].Value.ToString() == "") { item.Cells[VDesc.Name].Value = 0; }
                        item.Cells[idmoneda.Name].Value = filita["idmoneda"];
                        item.Cells[monedon.Name].Value = filita["moneda"];
                        item.Cells[Cantidad.Name].Value = 1;// item.Cells[Cantidad.Name].Value.ToString() == "" ? filita["cantidad"] : (decimal)item.Cells[Cantidad.Name].Value;
                        item.Cells[CantValido.Name].Value = 1;// filita["cantidadvalida"];
                        item.Cells[tipo_inicial.Name].Value = filita["tipo_inicial"];
                        item.Cells[valor_inicial.Name].Value = filita["valor_inicial"];
                        DataGridViewRow items = dtgconten.Rows[x];
                        CalcularMontos(items);
                        SacarTotales();
                    }
                }
                if (y == dtgconten.Columns[TDesc.Name].Index || y == dtgconten.Columns[Cantidad.Name].Index || y == dtgconten.Columns[VDesc.Name].Index || y == dtgconten.Columns[Precio_Base.Name].Index || y == dtgconten.Columns[Etapa.Name].Index)
                {
                    DataGridViewRow item = dtgconten.Rows[x];
                    CalcularMontos(item);
                    SacarTotales();
                }
            }
        }
        public void CalculoDeInicial(DataGridViewRow item)
        {
            /// 1 = monto  2=porcentaje
            if (item.Cells[tipo_inicial.Name].Value.ToString() != "" && item.Cells[idmoneda.Name].Value.ToString() != "")
            {
                if ((int)item.Cells[tipo_inicial.Name].Value == 1)
                {
                    //soles=1
                    item.Cells[PInicial.Name].Value = /*((decimal)item.Cells[P_Coti.Name].Value -*/ (decimal)item.Cells[valor_inicial.Name].Value;
                    //if ((int)item.Cells[idmoneda.Name].Value == 2) { item.Cells[PInicial.Name].Value = (decimal)item.Cells[T_ME.Name].Value - (decimal)item.Cells[valor_inicial.Name].Value; }
                }
                if ((int)item.Cells[tipo_inicial.Name].Value == 2)
                {
                    //soles=1
                    item.Cells[PInicial.Name].Value = ((decimal)item.Cells[P_Coti.Name].Value * (decimal)item.Cells[valor_inicial.Name].Value / 100);
                    //if ((int)item.Cells[idmoneda.Name].Value == 2) { item.Cells[PInicial.Name].Value = (decimal)item.Cells[T_ME.Name].Value * (decimal)item.Cells[valor_inicial.Name].Value / 100; }
                }
            }
        }
        public void SacarTotales()
        {
            decimal totalmm = 0, totalin = 0;
            decimal totalsub = 0, totaligv = 0;
            foreach (DataGridViewRow item in dtgconten.Rows)
            {
                //calculo de subtotal e igv
                item.Cells[xsubtotal.Name].Value = (item.Cells[P_Coti.Name].Value.ToString() == "" ? 0 : (decimal)item.Cells[P_Coti.Name].Value) / (1 + CapaLogica.Igv(DateTime.Now));
                item.Cells[xigv.Name].Value = (item.Cells[P_Coti.Name].Value.ToString() == "" ? 0 : (decimal)item.Cells[P_Coti.Name].Value) - (item.Cells[xsubtotal.Name].Value.ToString() == "" ? 0 : (decimal)item.Cells[xsubtotal.Name].Value);
                ////
                totalmm += item.Cells[P_Coti.Name].Value.ToString() == "" ? 0 : (decimal)item.Cells[P_Coti.Name].Value;
                //totalmn += item.Cells[T_MN.Name].Value.ToString() == "" ? 0 : (decimal)item.Cells[T_MN.Name].Value;
                totalin += item.Cells[PInicial.Name].Value.ToString() == "" ? 0 : (decimal)item.Cells[PInicial.Name].Value;
                totalsub += item.Cells[xsubtotal.Name].Value.ToString() == "" ? 0 : (decimal)item.Cells[xsubtotal.Name].Value;
                totaligv += item.Cells[xigv.Name].Value.ToString() == "" ? 0 : (decimal)item.Cells[xigv.Name].Value;
            }
            txtValorInicial.Text = totalin.ToString("n2");
            txttotal.Text = totalmm.ToString("n2");
            txtigv.Text = totaligv.ToString("n2");
            txtsubtotal.Text = totalsub.ToString("n2");
        }
        public void CalcularMontos(DataGridViewRow item)
        {
            if (item.Cells[idmoneda.Name].Value.ToString() != "")
            {
                int mon = (int)item.Cells[idmoneda.Name].Value;
                if (item.Cells[Cantidad.Name].Value.ToString() == "") item.Cells[Cantidad.Name].Value = 0;
                //porcentual+
                if (item.Cells[TDesc.Name].Value.ToString() == "") { item.Cells[TDesc.Name].Value = 0; }
                if ((int)item.Cells[TDesc.Name].Value == 0)
                {
                    item.Cells[P_Coti.Name].Value = ((decimal)item.Cells[Cantidad.Name].Value * (decimal)item.Cells[Precio_Base.Name].Value) * (100 - (item.Cells[VDesc.Name].Value.ToString() == "" ? 0 : (decimal)item.Cells[VDesc.Name].Value)) / 100;
                }
                //monto
                else
                {
                    item.Cells[P_Coti.Name].Value = ((decimal)item.Cells[Cantidad.Name].Value * (decimal)item.Cells[Precio_Base.Name].Value) - (decimal)item.Cells[VDesc.Name].Value;
                }
                decimal TipoCambio = decimal.Parse(txttipocambioref.Text == "" ? "3.30" : txttipocambioref.Text);
            }
            CalculoDeInicial(item);
        }
        private void dtgconten_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            //HPResergerFunciones.Utilitarios.msg($"Col {e.ColumnIndex} Row {e.RowIndex}   \n {e.Exception.Message}");
        }
        private void btnproductos_EnabledChanged(object sender, EventArgs e)
        {
            btnaddproducto.Enabled = btnproductos.Enabled;
        }
        private void btnaddproducto_Click(object sender, EventArgs e)
        {
            ((DataTable)dtgconten.DataSource).Rows.Add();
        }
        private void dtgconten_Sorted(object sender, EventArgs e)
        {
            RefreshPRoducts();
        }
        private void txtcodvendedor_TextChanged(object sender, EventArgs e)
        {
            if (txtcodvendedor.EstaLLeno())
            {
                DataTable Datos = CapaLogica.Vendedor(int.Parse(txtcodvendedor.Text));
                if (Datos.Rows.Count > 0)
                {
                    DataRow filita = Datos.Rows[0];
                    txtNombreVendedor.Text = Configuraciones.MayusculaCadaPalabra($"{filita["Nombres_Emp"]}, {filita["Apepat_Emp"]} {filita["Apemat_Emp"] }");
                }
                else txtNombreVendedor.CargarTextoporDefecto();
            }
            else txtNombreVendedor.CargarTextoporDefecto();
        }
        private void txttipocambioref_TextChanged(object sender, EventArgs e)
        {
            if (txttipocambioref.Text == (decimal.Parse(txttipocambioref.Text == "" ? txttipocambioref.TextoDefecto : txttipocambioref.Text)).ToString("0.0000"))
                foreach (DataGridViewRow item in dtgconten.Rows)
                    CalcularMontos(item);

        }
        public DialogResult msgp(string cadena)
        {
            return HPResergerFunciones.Utilitarios.msgYesNo(cadena);
        }
        private void dtgconten_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete || e.KeyCode == Keys.Back)
                if (msgp("Desea Quitar Producto") == DialogResult.Yes)
                {
                    dtgconten.Rows.RemoveAt(dtgconten.CurrentRow.Index);
                    SacarTotales();
                }
        }
        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            if (msgp("Seguro Desea Limpiar la Grilla") == DialogResult.Yes)
                ((DataTable)(dtgconten.DataSource)).Rows.Clear();
        }
        TextBox txt;
        private void dtgconten_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            int x = dtgconten.CurrentRow.Index, y = dtgconten.CurrentCell.ColumnIndex;
            if (y == dtgconten.Columns[VDesc.Name].Index || y == dtgconten.Columns[Cantidad.Name].Index)
            {
                txt = e.Control as TextBox;
                txt.KeyPress -= Txt_KeyPress;
                txt.KeyDown -= Txt_KeyDown;
                txt.KeyPress += Txt_KeyPress;
                txt.KeyDown += Txt_KeyDown;
            }
        }
        private void Txt_KeyDown(object sender, KeyEventArgs e)
        {
            HPResergerFunciones.Utilitarios.ValidarDinero(e, txt);
        }
        private void Txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            HPResergerFunciones.Utilitarios.SoloNumerosDecimales(e, txt.Text);
        }
        private void txtbusnumcot_TextChanged(object sender, EventArgs e)
        {
            CArgarBusqueda();
        }
        private void txtbustipoid_TextChanged(object sender, EventArgs e)
        {
            CArgarBusqueda();
        }
        private void txtbusnrodoc_TextChanged(object sender, EventArgs e)
        {
            CArgarBusqueda();
        }
        private void txtbusnombrecliente_TextChanged(object sender, EventArgs e)
        {
            CArgarBusqueda();
        }
        public void CArgarBusqueda()
        {
            DataTable tDATOS = CapaLogica.CotizacionCLiente(txtbusnumcot.TextValido(), txtbustipoid.TextValido(), txtbusnrodoc.TextValido(), txtbusnombrecliente.TextValido());
            dtgbuscare.DataSource = tDATOS;
            lblmsg2.Text = $"Total de Registros : {dtgbuscare.RowCount}";
        }
        frmlistarCotizacionesCLienteDEtalle frmlisclidet;
        private void dtgbuscare_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int x = e.RowIndex, y = e.ColumnIndex;
            if (x >= 0)
            {
                if (y == dtgbuscare.Columns[xdetalle.Name].Index)
                {
                    int ValorCot = (int)dtgbuscare[xnrocot.Name, x].Value;
                    if (frmlisclidet == null)
                    {
                        frmlisclidet = new frmlistarCotizacionesCLienteDEtalle(ValorCot, (int)cbotipoid.SelectedValue, dtgbuscare[xTipoDoc.Name, x].Value.ToString(), dtgbuscare[xnrodoc.Name, x].Value.ToString(), dtgbuscare[xCliente.Name, x].Value.ToString(), dtgbuscare[ytotal.Name, x].Value.ToString(), dtgbuscare[ysubtotal.Name, x].Value.ToString(), dtgbuscare[yigv.Name, x].Value.ToString());
                        frmlisclidet.NumCot = ValorCot;
                        frmlisclidet.inicial = ((decimal)dtgbuscare[ValorInicial.Name, x].Value).ToString("n2");
                        frmlisclidet.CodVen = (int)dtgbuscare[xidvend.Name, x].Value;
                        frmlisclidet.Separado = (int)dtgbuscare[xSeparado.Name, x].Value;
                        frmlisclidet.FormClosed += Frmlisclidet_FormClosed;
                        frmlisclidet.Show();
                    }
                    else frmlisclidet.Activate();
                }
            }
        }
        private void Frmlisclidet_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmlisclidet = null;
            CArgarBusqueda();
        }
        private void txttipocambioref_Leave(object sender, EventArgs e)
        {
            txttipocambioref.Text = (decimal.Parse(txttipocambioref.Text)).ToString("0.0000");
        }
        private void button1_Click(object sender, EventArgs e)
        {
            LimpiarBusqueda();
        }
        private void btnsalir_Click(object sender, EventArgs e)
        {
            if (estado == 0) this.Close();
        }

        private void txtmn_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtValorInicial_TextChanged(object sender, EventArgs e)
        {

        }

        private void label23_Click(object sender, EventArgs e)
        {

        }

        private void txtsubtotal_TextChanged(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void txtobservacion_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
