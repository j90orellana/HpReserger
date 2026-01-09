using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;

namespace SISGEM.ModuloCompras
{
    public partial class frmAddOrdenCompra : DevExpress.XtraEditors.XtraForm
    {
        public frmAddOrdenCompra()
        {
            InitializeComponent();
        }
        public int EstadoOrden = 0;
        public int _idOrden = 0;
        public int _estadoOrden = 0;
        private void frmAddOrdenCompra_Load(object sender, EventArgs e)
        {
            EstadoOrden = 1;//Nuevo
            dtfechaEmision.EditValue = DateTime.Now;
            dtfechaPago.EditValue = DateTime.Now;
            dtfechaEntrega.EditValue = DateTime.Now.AddDays(30);
            // Agregar un botón adicional al SearchLookUpEdit
            cboProveedor.Properties.Buttons.Add(
                new DevExpress.XtraEditors.Controls.EditorButton(
                    DevExpress.XtraEditors.Controls.ButtonPredefines.Plus)
            );
            // Evento del botón
            cboProveedor.Properties.ButtonClick += CboProveedor_ButtonClick;

            var configuracionEmpresa = new HPResergerCapaLogica.Configuracion.ConfiguracionEmpresa();
            var configuracion1 = configuracionEmpresa.GetByTipo(3);

            //trabajarconPartidas = (configuracion1?.Valor ?? 0) != 0;
            //layoutControlItem12.Visibility = trabajarconPartidas ? DevExpress.XtraLayout.Utils.LayoutVisibility.Always : DevExpress.XtraLayout.Utils.LayoutVisibility.Never;

            CargarEmpresas();
            CargarProveedores();
            //CargarTipoComprobantes();
            CargarMoneda();
            CargarCentrosCosto();

            CargarAprobadores();

            HPResergerCapaLogica.Compras.OrdenCompra oClase = new HPResergerCapaLogica.Compras.OrdenCompra();
            if (_idOrden != 0)
            {
                DataTable dt = oClase.ObtenerPorID(_idOrden);

                if (dt.Rows.Count == 0)
                {
                    XtraMessageBox.Show("No se encontró la Orden.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                DataRow row = dt.Rows[0];

                // Asignar valores a controles
                cboEmpresa.EditValue = row["IdEmpresa"];
                cboaprobador.EditValue = row["Aprobador1"];
                cboaprobador2.EditValue = row["Aprobador2"];

                txtnroOrden.EditValue = row["NumOrden"];
                cbocentroCosto.EditValue = row["CentroCosto"];
                txtcondiciones.EditValue = row["Condiciones"];
                txtcotizacion.EditValue = row["Cotizacion"];
                txtobservaciones.EditValue = row["Observaciones"];
                txtcontactoSolicitante.EditValue = row["ContactoSolicitante"];
                txttelefonoSolicitante.EditValue = row["TelefonoSolicitante"];
                txtcorreoSolicitante.EditValue = row["CorreoSolicitante"];
                txtsubTotal.EditValue = row["Subtotal"];
                txtimpuesto.EditValue = row["Impuesto"];
                txttotal.EditValue = row["Total"];
                txtporcentaje.EditValue = row["Porcentaje"];
                txtterminos.EditValue = row["Terminos"];

                dtfechaEmision.EditValue = row["FechaEmision"];
                dtfechaEntrega.EditValue = row["FechaEntrega"];
                dtfechaPago.EditValue = row["FechaPago"];

                chkcompra.Checked = Convert.ToInt32(row["TipoOrden"]) == 1;
                chkservicio.Checked = Convert.ToInt32(row["TipoOrden"]) == 2;

                cboMoneda.EditValue = (int)row["moneda"];


                _rucProveedor = row["RucProveedor"].ToString();
                _tipoIdProveedor = Convert.ToInt32(row["TipoIdProveedor"]);

                cboProveedor.EditValue = row["rucProveedor"];

                txtnroOrden.EditValue = NumeroOrden((DateTime)dtfechaEmision.EditValue, _idOrden);

                // Estado para edición
                EstadoOrden = (int)row["estado"] == 0 ? 0 : 2;
                _estadoOrden = (int)row["estadoOrden"];
                if (EstadoOrden == 2)
                {
                    lblEstado.Caption = "Editando Orden de Compra";
                }
                else if (EstadoOrden == 0)
                {
                    lblEstado.Caption = "Orden de Compra Anulada";
                }

                if (_estadoOrden == 5)
                {
                    lblEstado.Caption = "Orden de Compra Factura";
                }

                //XtraMessageBox.Show("Orden cargada correctamente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

            Tdata = oClase.GetByOrden(_idOrden);
            gridControl1.DataSource = Tdata;


            //activar el boton de aprobar
            btnAprobar.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;

            if (oClase.OrdenDelUsuarioLogeado(_idOrden, HPReserger.frmLogin.CodigoUsuario).Rows.Count > 0)
            {
                btnAprobar.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
            }

        }

        private void CargarCentrosCosto()
        {
            HPResergerCapaLogica.Compras.FacturaManual cClase = new HPResergerCapaLogica.Compras.FacturaManual();

            DataTable tData = cClase.GetCentroCosto();
            cbocentroCosto.Properties.DataSource = tData;
            cbocentroCosto.Properties.DisplayMember = "centroCosto";
            cbocentroCosto.Properties.ValueMember = "codigo";

            // Limpiar y configurar columnas manualmente
            cbocentroCosto.Properties.Columns.Clear();

            // Agregar la columna "descripcion" y ocultar todas las demás
            foreach (DataColumn column in tData.Columns)
            {
                var lookupColumn = new DevExpress.XtraEditors.Controls.LookUpColumnInfo(column.ColumnName, column.ColumnName);
                lookupColumn.Visible = column.ColumnName == "centroCosto"; // Solo la columna "descripcion" será visible
                cbocentroCosto.Properties.Columns.Add(lookupColumn);
            }

            // Personalizar el encabezado de la columna visible
            cbocentroCosto.Properties.Columns["centroCosto"].Caption = "Centro Costo";

            // Seleccionar el primer registro si existen filas
            if (tData.Rows.Count > 0)
            {
                cbocentroCosto.EditValue = tData.Rows[0]["codigo"]; // Asigna el primer valor de "codigo"
            }
            else
                cbocentroCosto.Properties.DataSource = null;


            // Otras opciones de personalización
            cbocentroCosto.Properties.ShowHeader = true; // Mostrar encabezado de columnas
            cbocentroCosto.Properties.ShowFooter = false; // Ocultar pie de página
            cbocentroCosto.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup; // Ajustar ancho automático
        }

        public string NumeroOrden(DateTime Fecha, int numero)
        {
            return $"{Fecha.Year}{numero.ToString("00")}";
        }

        DataTable Tdata;
        private void CargarAprobadores()
        {
            HPResergerCapaLogica.Compras.FacturaManual cClase = new HPResergerCapaLogica.Compras.FacturaManual();

            DataTable tData = cClase.GetUsuariosActivos();
            DataTable tData2 = cClase.GetUsuariosActivos();

            cboaprobador.Properties.DataSource = tData;
            cboaprobador.Properties.DisplayMember = "nombre";
            cboaprobador.Properties.ValueMember = "id";

            // Limpiar y configurar columnas manualmente
            cboaprobador.Properties.Columns.Clear();

            // Agregar la columna "descripcion" y ocultar todas las demás
            foreach (DataColumn column in tData.Columns)
            {
                var lookupColumn = new DevExpress.XtraEditors.Controls.LookUpColumnInfo(column.ColumnName, column.ColumnName);
                lookupColumn.Visible = column.ColumnName == "nombre"; // Solo la columna "descripcion" será visible
                cboaprobador.Properties.Columns.Add(lookupColumn);
            }

            // Personalizar el encabezado de la columna visible
            cboaprobador.Properties.Columns["nombre"].Caption = "Nombre";

            // Seleccionar el primer registro si existen filas
            if (tData.Rows.Count > 0)
            {
                cboaprobador.EditValue = tData.Rows[0]["id"]; // Asigna el primer valor de "codigo"
            }
            else
                cboaprobador.Properties.DataSource = null;


            // Otras opciones de personalización
            cboaprobador.Properties.ShowHeader = true; // Mostrar encabezado de columnas
            cboaprobador.Properties.ShowFooter = false; // Ocultar pie de página
            cboaprobador.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup; // Ajustar ancho automático


            cboaprobador2.Properties.DataSource = tData2;
            cboaprobador2.Properties.DisplayMember = "nombre";
            cboaprobador2.Properties.ValueMember = "id";

            // Limpiar y configurar columnas manualmente
            cboaprobador2.Properties.Columns.Clear();

            // Agregar la columna "descripcion" y ocultar todas las demás
            foreach (DataColumn column in tData2.Columns)
            {
                var lookupColumn = new DevExpress.XtraEditors.Controls.LookUpColumnInfo(column.ColumnName, column.ColumnName);
                lookupColumn.Visible = column.ColumnName == "nombre"; // Solo la columna "descripcion" será visible
                cboaprobador2.Properties.Columns.Add(lookupColumn);
            }

            // Personalizar el encabezado de la columna visible
            cboaprobador2.Properties.Columns["nombre"].Caption = "Nombre";

            // Seleccionar el primer registro si existen filas
            if (tData2.Rows.Count > 0)
            {
                cboaprobador2.EditValue = tData2.Rows[0]["id"]; // Asigna el primer valor de "codigo"
            }
            else
                cboaprobador2.Properties.DataSource = null;


            // Otras opciones de personalización
            cboaprobador2.Properties.ShowHeader = true; // Mostrar encabezado de columnas
            cboaprobador2.Properties.ShowFooter = false; // Ocultar pie de página
            cboaprobador2.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup; // Ajustar ancho automático

        }

        private void CargarMoneda()
        {
            HPResergerCapaLogica.Compras.FacturaManual cClase = new HPResergerCapaLogica.Compras.FacturaManual();

            DataTable tData = cClase.GetMoneda();
            cboMoneda.Properties.DataSource = tData;
            cboMoneda.Properties.DisplayMember = "moneda";
            cboMoneda.Properties.ValueMember = "idMoneda";

            // Limpiar y configurar columnas manualmente
            cboMoneda.Properties.Columns.Clear();

            // Agregar la columna "descripcion" y ocultar todas las demás
            foreach (DataColumn column in tData.Columns)
            {
                var lookupColumn = new DevExpress.XtraEditors.Controls.LookUpColumnInfo(column.ColumnName, column.ColumnName);
                lookupColumn.Visible = column.ColumnName == "moneda"; // Solo la columna "descripcion" será visible
                cboMoneda.Properties.Columns.Add(lookupColumn);
            }

            // Personalizar el encabezado de la columna visible
            cboMoneda.Properties.Columns["moneda"].Caption = "Moneda";

            // Seleccionar el primer registro si existen filas
            if (tData.Rows.Count > 0)
            {
                cboMoneda.EditValue = tData.Rows[0]["idMoneda"]; // Asigna el primer valor de "codigo"
            }
            else
                cboMoneda.Properties.DataSource = null;


            // Otras opciones de personalización
            cboMoneda.Properties.ShowHeader = true; // Mostrar encabezado de columnas
            cboMoneda.Properties.ShowFooter = false; // Ocultar pie de página
            cboMoneda.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup; // Ajustar ancho automático
        }
        private void CargarEmpresas()
        {
            HPResergerCapaLogica.HPResergerCL oCL = new HPResergerCapaLogica.HPResergerCL();
            DataTable tData = oCL.Empresa();

            cboEmpresa.Properties.DataSource = tData;
            cboEmpresa.Properties.DisplayMember = "descripcion";
            cboEmpresa.Properties.ValueMember = "codigo";

            // Limpiar y configurar columnas manualmente
            cboEmpresa.Properties.Columns.Clear();

            // Agregar la columna "descripcion" y ocultar todas las demás
            foreach (DataColumn column in tData.Columns)
            {
                var lookupColumn = new DevExpress.XtraEditors.Controls.LookUpColumnInfo(column.ColumnName, column.ColumnName);
                lookupColumn.Visible = column.ColumnName == "descripcion"; // Solo la columna "descripcion" será visible
                cboEmpresa.Properties.Columns.Add(lookupColumn);
            }

            // Personalizar el encabezado de la columna visible
            cboEmpresa.Properties.Columns["descripcion"].Caption = "Empresa";

            // Seleccionar el primer registro si existen filas
            if (tData.Rows.Count > 0)
            {
                cboEmpresa.EditValue = tData.Rows[0]["codigo"]; // Asigna el primer valor de "codigo"
            }

            // Otras opciones de personalización
            cboEmpresa.Properties.ShowHeader = true; // Mostrar encabezado de columnas
            cboEmpresa.Properties.ShowFooter = false; // Ocultar pie de página
            cboEmpresa.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup; // Ajustar ancho automático
        }
        private void CboProveedor_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            // Si se presiona el botón adicional (refresh)
            if (e.Button.Kind == DevExpress.XtraEditors.Controls.ButtonPredefines.Plus)
            {
                // Llamas a tu función
                CargarProveedores();
            }
        }
        private void CargarProveedores()
        {
            HPResergerCapaLogica.Compras.ProveedorData cClase = new HPResergerCapaLogica.Compras.ProveedorData();
            DataTable Tdata = cClase.GetAll();
            cboProveedor.Properties.DataSource = Tdata;
            cboProveedor.Properties.DisplayMember = "proveedor";
            cboProveedor.Properties.ValueMember = "ruc";

            cboProveedor.EditValue = Tdata.Rows.Count > 0 ? Tdata.Rows[0]["ruc"] : null;

            // Limpiar columnas
            var view = cboProveedor.Properties.View;
            view.Columns.Clear();

            var colRuc = view.Columns.AddVisible("ruc", "RUC");
            var colRazon = view.Columns.AddVisible("razonSocial", "Razón Social");

            colRuc.Width = 100;
            colRuc.MinWidth = 100;
            colRuc.MaxWidth = 100;
            colRuc.OptionsColumn.FixedWidth = true;

            // Ajustar solo las demás columnas
            view.BestFitColumns();
        }

        private void checkEdit1_CheckedChanged(object sender, EventArgs e)
        {
            CheckEdit chk = sender as CheckEdit;

            // Solo actuar cuando se marca uno
            if (!chk.Checked)
            {
                // Evitar que el usuario desmarque el único activo
                if (chk == chkcompra && !chkservicio.Checked)
                    chkcompra.Checked = true;

                if (chk == chkservicio && !chkcompra.Checked)
                    chkservicio.Checked = true;

                return;
            }

            // Si uno se marca, desmarcar el otro
            if (chk == chkcompra)
                chkservicio.Checked = false;
            else if (chk == chkservicio)
                chkcompra.Checked = false;
        }

        private void cboEmpresa_EditValueChanged(object sender, EventArgs e)
        {
            LookUpEdit lookup = sender as LookUpEdit;
            if (lookup.EditValue == null)
                return;

            // Obtiene la fila completa vinculada al item seleccionado
            DataRowView row = lookup.GetSelectedDataRow() as DataRowView;

            if (row != null)
            {
                txtrucEmpresa.EditValue = row["RUC"].ToString();
                txtdireccionEmpresa.EditValue = row["Direccion"].ToString();
            }
        }
        string _rucProveedor = "";
        int _tipoIdProveedor = 0;
        private void cboProveedor_TextChanged(object sender, EventArgs e)
        {
            var view = cboProveedor.Properties.View;
            DataRow row = view.GetDataRow(view.FocusedRowHandle);
            if (row != null || cboProveedor.Text != "")
            {
                var rowx = ((DataTable)cboProveedor.Properties.DataSource).AsEnumerable()
            .FirstOrDefault(r => r.Field<string>("RUC") == cboProveedor.EditValue.ToString());

                txtrucProveedor.EditValue = rowx.Field<string>("ruc");
                txtdireccionProveedor.EditValue = rowx.Field<string>("direccion");
                txtcontacto.EditValue = rowx.Field<string>("contacto");
                _tipoIdProveedor = rowx.Field<int>("tipoId");
                _rucProveedor = rowx.Field<string>("ruc");
            }
        }

        private void dtfechaEntrega_EditValueChanged(object sender, EventArgs e)
        {
            if (EstadoOrden == 1)
            {
                dtfechaPago.EditValue = ((DateTime)dtfechaEntrega.EditValue).AddDays(15);
            }
        }

        private void btnGuardar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (EstadoOrden == 0)
            {
                XtraMessageBox.Show(
                      "Orden Anulada, no se puede Actualizar.", "Error al Guardar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (_estadoOrden == 5)
            {
                XtraMessageBox.Show(
                      "Orden Facturada, no se puede Actualizar.", "Error al Guardar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            List<string> errores = new List<string>();

            // Empresa
            if (cboEmpresa.EditValue == null)
                errores.Add("• Debe seleccionar la *Empresa*.");

            // Tipo de Proveedor
            if (cboProveedor.EditValue == null)
                errores.Add("• Debe seleccionar el *Proveedor*.");

            //// Número de Orden
            //if (string.IsNullOrWhiteSpace(Convert.ToString(txtNumOrden.EditValue)))
            //    errores.Add("• Debe ingresar el *Número de Orden*.");

            // Fecha Emisión
            if (dtfechaEmision.EditValue == null)
                errores.Add("• Debe ingresar la *Fecha de Emisión*.");
            if (dtfechaEntrega.EditValue == null)
                errores.Add("• Debe ingresar la *Fecha de Entrega*.");
            if (dtfechaPago.EditValue == null)
                errores.Add("• Debe ingresar la *Fecha de Pago*.");

            // Moneda
            if (cboMoneda.EditValue == null)
                errores.Add("• Debe seleccionar la *Moneda*.");

            //// Subtotal
            //if (string.IsNullOrWhiteSpace(Convert.ToString(txtSubtotal.EditValue)) ||
            //    Convert.ToDecimal(txtSubtotal.EditValue) <= 0)
            //    errores.Add("• El *Subtotal* debe ser mayor a cero.");

            //// Impuesto
            //if (string.IsNullOrWhiteSpace(Convert.ToString(txtImpuesto.EditValue)))
            //    errores.Add("• Debe ingresar el *Impuesto*.");

            //// Total
            //if (string.IsNullOrWhiteSpace(Convert.ToString(txtTotal.EditValue)) ||
            //    Convert.ToDecimal(txtTotal.EditValue) <= 0)
            //    errores.Add("• El *Total* debe ser mayor a cero.");

            // Contacto solicitante
            //if (string.IsNullOrWhiteSpace(Convert.ToString(txtContactoSolicitante.EditValue)))
            //    errores.Add("• Debe ingresar el *Contacto del Solicitante*.");

            //// Teléfono solicitante
            //if (string.IsNullOrWhiteSpace(Convert.ToString(txtTelefonoSolicitante.EditValue)))
            //    errores.Add("• Debe ingresar el *Teléfono del Solicitante*.");

            //// Correo solicitante
            //if (string.IsNullOrWhiteSpace(Convert.ToString(txtCorreoSolicitante.EditValue)))
            //    errores.Add("• Debe ingresar el *Correo del Solicitante*.");

            // Aprobador 1
            //if (cboAprobador1.EditValue == null)
            //    errores.Add("• Debe seleccionar el *Primer Aprobador*.");

            // -----------------------------
            // MOSTRAR ERRORES
            // -----------------------------
            if (errores.Count > 0)
            {
                string mensaje =
                    "Se encontraron los siguientes errores:\n\n" +
                    string.Join("\n", errores);

                XtraMessageBox.Show(
                    mensaje,
                    "Validación de Datos",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return; // no guardar
            }

            int idUsuario = HPReserger.frmLogin.CodigoUsuario;

            // ESTADO ORDEN COMPRA
            //0 Pendiente 
            //1 Aprobado por Aprobador1 
            //2 Aprobado por Aprobador2 
            //3 Rechazado


            if (EstadoOrden == 1) // nuevo
            {
                HPResergerCapaLogica.Compras.OrdenCompra.oOrdenCompra oObjeto = new HPResergerCapaLogica.Compras.OrdenCompra.oOrdenCompra();
                HPResergerCapaLogica.Compras.OrdenCompra oClase = new HPResergerCapaLogica.Compras.OrdenCompra();

                oObjeto.Aprobador1 = cboaprobador.EditValue is int vAprob1 ? vAprob1 : 0;
                oObjeto.Aprobador2 = cboaprobador2.EditValue is int vAprob2 ? vAprob2 : 0;

                oObjeto.CentroCosto = Convert.ToString(cbocentroCosto.EditValue) ?? "";
                oObjeto.Condiciones = Convert.ToString(txtcondiciones.EditValue) ?? "";
                oObjeto.ContactoSolicitante = Convert.ToString(txtcontactoSolicitante.EditValue) ?? "";
                oObjeto.CorreoSolicitante = Convert.ToString(txtcorreoSolicitante.EditValue) ?? "";
                oObjeto.Cotizacion = Convert.ToString(txtcotizacion.EditValue) ?? "";
                oObjeto.NumOrden = Convert.ToString(txtnroOrden.EditValue) ?? "";
                oObjeto.Observaciones = Convert.ToString(txtobservaciones.EditValue) ?? "";
                oObjeto.TelefonoSolicitante = Convert.ToString(txttelefonoSolicitante.EditValue) ?? "";
                oObjeto.Terminos = Convert.ToString(txtterminos.EditValue) ?? "";

                oObjeto.IdEmpresa = cboEmpresa.EditValue is int vEmp ? vEmp : 0;
                oObjeto.Moneda = cboMoneda.EditValue is int vMon ? vMon : 0;

                oObjeto.TipoOrden = chkcompra.Checked ? 1 : 2;
                oObjeto.TipoIdProveedor = _tipoIdProveedor;
                oObjeto.RucProveedor = _rucProveedor;

                oObjeto.Porcentaje = txtporcentaje.EditValue is int vPor ? vPor : 0;

                oObjeto.Subtotal = txtsubTotal.EditValue is decimal vSub ? vSub : 0;
                oObjeto.Impuesto = txtimpuesto.EditValue is decimal vImp ? vImp : 0;
                oObjeto.Total = txttotal.EditValue is decimal vTot ? vTot : 0;

                oObjeto.FechaEmision = dtfechaEmision.EditValue is DateTime f1 ? f1 : DateTime.Now;
                oObjeto.FechaEntrega = dtfechaEntrega.EditValue is DateTime f2 ? f2 : DateTime.Now;
                oObjeto.FechaPago = dtfechaPago.EditValue is DateTime f3 ? f3 : DateTime.Now;

                oObjeto.Aprobador1 = oObjeto.Aprobador1 < 0 ? 0 : oObjeto.Aprobador1;
                oObjeto.Aprobador2 = oObjeto.Aprobador2 < 0 ? 0 : oObjeto.Aprobador2;

                oObjeto.Estado = 1;
                oObjeto.EstadoOrden = _estadoOrden = 0;
                oObjeto.UsuarioCreador = idUsuario;

                _idOrden = oClase.Insertar(oObjeto);

                if (_idOrden != 0)
                {
                    int c = 1;
                    foreach (DataRow row in Tdata.Rows)
                    {
                        var oDetalle = new HPResergerCapaLogica.Compras.OrdenCompra.OrdenCompraDet();

                        oDetalle.IdOrdenCompra = _idOrden;
                        oDetalle.Item = c++;

                        oDetalle.Codigo = row["Codigo"]?.ToString() ?? "";
                        oDetalle.Descripcion = row["Descripcion"]?.ToString() ?? "";
                        oDetalle.Entrega = row["Entrega"]?.ToString() ?? "";

                        oDetalle.Unidad = ToInt(row["Unidad"]);
                        oDetalle.Cantidad = ToInt(row["Cantidad"]);
                        oDetalle.PrecioUnitario = ToDec(row["PrecioUnitario"]);
                        oDetalle.Descuento = ToDec(row["Descuento"]);
                        oDetalle.Total = ToDec(row["Total"]);

                        oDetalle.UsuarioCreador = idUsuario;
                        oDetalle.Fecha = DateTime.Now;

                        // Insertar detalle
                        oClase.Insert(oDetalle);
                    }
                }

                if (_idOrden == 0)
                {
                    XtraMessageBox.Show(
                        "Ocurrió un problema y la Order no se pudo guardar.\n" +
                        "Por favor, intente nuevamente o verifique los datos ingresados.", "Error al Guardar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    txtnroOrden.EditValue = NumeroOrden((DateTime)dtfechaEmision.EditValue, _idOrden);
                    oClase.ActualizarNumOrden(_idOrden, txtnroOrden.EditValue.ToString());
                    EstadoOrden = 2;
                    XtraMessageBox.Show($"La Order fue guardada correctamente. con ID: {txtnroOrden.EditValue}", "Registro Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            else if (EstadoOrden == 2) // actualizar
            {

                // Solo se permite modificar si la Orden está en estado Pendiente (0)

                if (_estadoOrden != 0)
                {
                    string estadoMsg = "";
                    switch (_estadoOrden)
                    {
                        case 1:
                            estadoMsg = "aprobada por el primer aprobador";
                            break;
                        case 2:
                            estadoMsg = "aprobada por el segundo aprobador";
                            break;
                        case 3:
                            estadoMsg = "rechazada";
                            break;
                        default:
                            estadoMsg = "en un estado no editable";
                            break;
                    }

                    XtraMessageBox.Show(
                        $"La Orden de Compra no se puede modificar porque ya fue {estadoMsg}.\n" +
                        "Solo las órdenes en estado *Pendiente* pueden ser editadas.",
                        "Edición no permitida",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    return;
                }

                HPResergerCapaLogica.Compras.OrdenCompra.oOrdenCompra oObjeto = new HPResergerCapaLogica.Compras.OrdenCompra.oOrdenCompra();
                HPResergerCapaLogica.Compras.OrdenCompra oClase = new HPResergerCapaLogica.Compras.OrdenCompra();

                // ===== Asignaciones seguras =====
                oObjeto.Id = _idOrden;

                oObjeto.Aprobador1 = cboaprobador.EditValue is int vA1 ? vA1 : 0;
                oObjeto.Aprobador2 = cboaprobador2.EditValue is int vA2 ? vA2 : 0;

                oObjeto.CentroCosto = Convert.ToString(cbocentroCosto.EditValue) ?? "";
                oObjeto.Condiciones = Convert.ToString(txtcondiciones.EditValue) ?? "";
                oObjeto.ContactoSolicitante = Convert.ToString(txtcontactoSolicitante.EditValue) ?? "";
                oObjeto.CorreoSolicitante = Convert.ToString(txtcorreoSolicitante.EditValue) ?? "";
                oObjeto.Cotizacion = Convert.ToString(txtcotizacion.EditValue) ?? "";
                oObjeto.NumOrden = Convert.ToString(txtnroOrden.EditValue) ?? "";
                oObjeto.Observaciones = Convert.ToString(txtobservaciones.EditValue) ?? "";
                oObjeto.TelefonoSolicitante = Convert.ToString(txttelefonoSolicitante.EditValue) ?? "";
                oObjeto.Terminos = Convert.ToString(txtterminos.EditValue) ?? "";
                oObjeto.Referencia = "";

                oObjeto.IdEmpresa = cboEmpresa.EditValue is int vEmp ? vEmp : 0;
                oObjeto.Moneda = cboMoneda.EditValue is int vMon ? vMon : 0;
                oObjeto.TipoOrden = chkcompra.Checked ? 1 : 2;

                oObjeto.Porcentaje = int.Parse(txtporcentaje.EditValue.ToString());
                oObjeto.Subtotal = txtsubTotal.EditValue is decimal vSub ? vSub : 0;
                oObjeto.Impuesto = txtimpuesto.EditValue is decimal vImp ? vImp : 0;
                oObjeto.Total = txttotal.EditValue is decimal vTot ? vTot : 0;

                oObjeto.FechaEmision = dtfechaEmision.EditValue is DateTime f1 ? f1 : DateTime.Now;
                oObjeto.FechaEntrega = dtfechaEntrega.EditValue is DateTime f2 ? f2 : DateTime.Now;
                oObjeto.FechaPago = dtfechaPago.EditValue is DateTime f3 ? f3 : DateTime.Now;

                oObjeto.RucProveedor = _rucProveedor;
                oObjeto.TipoIdProveedor = _tipoIdProveedor;

                oObjeto.EstadoOrden = _estadoOrden;
                oObjeto.Estado = 1;
                oObjeto.UsuarioModifica = idUsuario;

                int resultado = oClase.Actualizar(oObjeto);

                if (resultado <= 0)
                {
                    XtraMessageBox.Show(
                        "No se pudo actualizar la Orden de Compra.\n" +
                        "Verifique los datos e intente nuevamente.", "Error al Actualizar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Eliminar detalle anterior
                oClase.DeleteByOrden(_idOrden);

                // Insertar nuevo detalle
                int c = 1;
                foreach (DataRow row in Tdata.Rows)
                {
                    HPResergerCapaLogica.Compras.OrdenCompra.OrdenCompraDet det = new HPResergerCapaLogica.Compras.OrdenCompra.OrdenCompraDet();

                    det.IdOrdenCompra = _idOrden;
                    det.Item = c++;

                    det.Codigo = row["Codigo"]?.ToString() ?? "";
                    det.Descripcion = row["Descripcion"]?.ToString() ?? "";
                    det.Entrega = row["Entrega"]?.ToString() ?? "";

                    det.Unidad = ToInt(row["Unidad"]);
                    det.Cantidad = ToInt(row["Cantidad"]);
                    det.PrecioUnitario = ToDec(row["PrecioUnitario"]);
                    det.Descuento = ToDec(row["Descuento"]);
                    det.Total = ToDec(row["Total"]);

                    det.UsuarioCreador = idUsuario;
                    det.Fecha = DateTime.Now;

                    oClase.Insert(det);

                }

                txtnroOrden.EditValue = NumeroOrden((DateTime)dtfechaEmision.EditValue, _idOrden);
                oClase.ActualizarNumOrden(_idOrden, txtnroOrden.EditValue.ToString());
                XtraMessageBox.Show($"La Orden de Compra: {txtnroOrden.EditValue}, fue actualizada correctamente.", "Actualización Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void gridView1_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            if (e.Column.FieldName == "Cantidad" ||
         e.Column.FieldName == "PrecioUnitario" ||
         e.Column.FieldName == "Descuento")
            {
                GridView gv = sender as GridView;

                decimal precio = ToDec(gv.GetRowCellValue(e.RowHandle, "PrecioUnitario"));
                int cantidad = ToInt(gv.GetRowCellValue(e.RowHandle, "Cantidad"));
                decimal descuento = ToDec(gv.GetRowCellValue(e.RowHandle, "Descuento"));

                decimal total = (precio * cantidad) * (1 - descuento);

                gv.SetRowCellValue(e.RowHandle, "Total", total);

                CalcularTotalGeneral();
            }
        }
        private decimal ToDec(object v)
        {
            if (v == null || v == DBNull.Value) return 0;
            return Convert.ToDecimal(v);
        }

        private int ToInt(object v)
        {
            if (v == null || v == DBNull.Value) return 0;
            return Convert.ToInt32(v);
        }

        private void CalcularTotalGeneral()
        {
            decimal suma = 0;

            for (int i = 0; i < gridView1.RowCount; i++)
            {
                suma += ToDec(gridView1.GetRowCellValue(i, xtotal.FieldName));
            }

            txtsubTotal.EditValue = suma;
            txtimpuesto.EditValue = suma * (decimal)txtporcentaje.EditValue / 100;
            txttotal.EditValue = (decimal)txtsubTotal.EditValue + (decimal)txtimpuesto.EditValue;
        }

        private void txtporcentaje_EditValueChanged(object sender, EventArgs e)
        {
            CalcularTotalGeneral();
        }

        private void btnCerrar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void btnNuevo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            EstadoOrden = 1;
            _idOrden = 0;
            lblEstado.Caption = "Nueva Orden de Compra";
            txtnroOrden.EditValue = "";
            gridControl1.DataSource = null;
            txttotal.EditValue = "0.00";
            txtimpuesto.EditValue = "0.00";
            txtsubTotal.EditValue = "0.00";
            txtcotizacion.EditValue = "";
            cbocentroCosto.EditValue = "";
        }
        private void CalcularFila(GridView gv, int rowHandle)
        {
            decimal precio = ToDec(gv.GetRowCellValue(rowHandle, "PrecioUnitario"));
            int cantidad = ToInt(gv.GetRowCellValue(rowHandle, "Cantidad"));
            decimal descuento = ToDec(gv.GetRowCellValue(rowHandle, "Descuento"));

            decimal total = (precio * cantidad) - descuento;

            gv.SetRowCellValue(rowHandle, "Total", total);
        }

        private void gridView1_CellValueChanging(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            if (e.Column.FieldName == "Cantidad" ||
      e.Column.FieldName == "PrecioUnitario" ||
      e.Column.FieldName == "Descuento")
            {
                GridView gv = sender as GridView;

                if (gv.IsNewItemRow(e.RowHandle))
                {
                    // Actualiza valores en tiempo real
                    gv.SetRowCellValue(e.RowHandle, e.Column, e.Value);

                    CalcularFila(gv, e.RowHandle);
                    CalcularTotalGeneral();
                }
            }
        }

        private void repositoryItemButtonEdit1_Click(object sender, EventArgs e)
        {
            if (_estadoOrden == 0)
            {
                var Fila = gridView1.GetFocusedDataRow();
                if (Fila != null)
                {
                    Tdata.Rows.Remove(Fila);
                }
            }
            CalcularTotalGeneral();
        }

        private void btnAddFila_Click(object sender, EventArgs e)
        {
            if (_estadoOrden == 0)
            {
                Tdata.Rows.Add(Tdata.NewRow());
            }
            CalcularTotalGeneral();

        }

        private void btnAprobar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            // 1. Confirmación
            var r = XtraMessageBox.Show(
                "¿Está seguro que desea aprobar esta Orden de Compra?",
                "Confirmar Aprobación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (r != DialogResult.Yes)
                return;

            // 2. Solicitar comentario
            string comentario = XtraInputBox.Show(
                "Ingrese un comentario de aprobación:",
                "Comentario de Aprobación",
                ""
            );

            // Validar ingreso
            if (string.IsNullOrWhiteSpace(comentario))
            {
                XtraMessageBox.Show(
                    "Debe ingresar un comentario para aprobar.",
                    "Comentario Requerido",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }

            try
            {
                // 3. Actualizar estado por clase lógica
                HPResergerCapaLogica.Compras.OrdenCompra clase =
                    new HPResergerCapaLogica.Compras.OrdenCompra();

                bool ok = clase.AprobarOrden(_idOrden, HPReserger.frmLogin.CodigoUsuario, comentario) != 0;

                if (ok)
                {
                    XtraMessageBox.Show(
                        "Orden de Compra aprobada correctamente.",
                        "Aprobación Exitosa",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );

                    //CargarOrdenes(); // o el método que refresca tu grid
                }
                else
                {
                    XtraMessageBox.Show(
                        "No se pudo aprobar la Orden de Compra.",
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(
                    "Error al aprobar la OC:\n" + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }
    }
}