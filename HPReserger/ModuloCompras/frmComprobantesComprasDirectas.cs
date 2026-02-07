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
using System.Drawing.Imaging;
using System.IO;

namespace SISGEM.ModuloCompras
{
    public partial class frmComprobantesComprasDirectas : DevExpress.XtraEditors.XtraForm
    {
        public frmComprobantesComprasDirectas()
        {
            InitializeComponent();
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
        HPResergerCapaLogica.HPResergerCL CapaLogica = new HPResergerCapaLogica.HPResergerCL();
        private void cargarProyectos(int idEmpresa)
        {
            DataTable tData = CapaLogica.ListarProyectosEmpresa(idEmpresa.ToString());
            cboProyecto.Properties.DataSource = tData;
            cboProyecto.Properties.DisplayMember = "Proyecto";
            cboProyecto.Properties.ValueMember = "Id_Proyecto";

            // Limpiar y configurar columnas manualmente
            cboProyecto.Properties.Columns.Clear();

            // Agregar la columna "descripcion" y ocultar todas las demás
            foreach (DataColumn column in tData.Columns)
            {
                var lookupColumn = new DevExpress.XtraEditors.Controls.LookUpColumnInfo(column.ColumnName, column.ColumnName);
                lookupColumn.Visible = column.ColumnName == "Proyecto"; // Solo la columna "descripcion" será visible
                cboProyecto.Properties.Columns.Add(lookupColumn);
            }

            // Personalizar el encabezado de la columna visible
            //cboProyecto.Properties.Columns["descripcion"].Caption = "Proyecto";

            // Seleccionar el primer registro si existen filas
            if (tData.Rows.Count > 0)
            {
                cboProyecto.EditValue = tData.Rows[0]["Id_Proyecto"]; // Asigna el primer valor de "codigo"
            }
            else
            {
                cboProyecto.Properties.DataSource = null;
                cboEtapa.Properties.DataSource = null;
            }

            // Otras opciones de personalización
            cboProyecto.Properties.ShowHeader = true; // Mostrar encabezado de columnas
            cboProyecto.Properties.ShowFooter = false; // Ocultar pie de página
            cboProyecto.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup; // Ajustar ancho automático
        }
        private void cargarEtapas(int idProyecto)
        {
            DataTable tData = CapaLogica.ListarEtapasProyecto(idProyecto.ToString());
            cboEtapa.Properties.DataSource = tData;
            cboEtapa.Properties.DisplayMember = "descripcion";
            cboEtapa.Properties.ValueMember = "Id_etapa";

            // Limpiar y configurar columnas manualmente
            cboEtapa.Properties.Columns.Clear();

            // Agregar la columna "descripcion" y ocultar todas las demás
            foreach (DataColumn column in tData.Columns)
            {
                var lookupColumn = new DevExpress.XtraEditors.Controls.LookUpColumnInfo(column.ColumnName, column.ColumnName);
                lookupColumn.Visible = column.ColumnName == "descripcion"; // Solo la columna "descripcion" será visible
                cboEtapa.Properties.Columns.Add(lookupColumn);
            }

            // Personalizar el encabezado de la columna visible
            cboEtapa.Properties.Columns["descripcion"].Caption = "Etapa";

            // Seleccionar el primer registro si existen filas
            if (tData.Rows.Count > 0)
            {
                cboEtapa.EditValue = tData.Rows[0]["Id_etapa"]; // Asigna el primer valor de "codigo"
            }
            else
                cboEtapa.Properties.DataSource = null;


            // Otras opciones de personalización
            cboEtapa.Properties.ShowHeader = true; // Mostrar encabezado de columnas
            cboEtapa.Properties.ShowFooter = false; // Ocultar pie de página
            cboEtapa.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup; // Ajustar ancho automático
        }
        bool trabajarconPartidas = false;
        int _idFactura = 0;
        int _tipoFactura = 0;
        int Estado = 0;
        private void frmComprobantesComprasDirectas_Load(object sender, EventArgs e)
        {
            Estado = 1;//Nuevo
            dtpFechaEmision.EditValue = DateTime.Now;
            dtpfechaVencimiento.EditValue = DateTime.Now.AddDays(30);
            // Agregar un botón adicional al SearchLookUpEdit
            cboProveedor.Properties.Buttons.Add(
                new DevExpress.XtraEditors.Controls.EditorButton(
                    DevExpress.XtraEditors.Controls.ButtonPredefines.Plus)
            );
            // Evento del botón
            cboProveedor.Properties.ButtonClick += CboProveedor_ButtonClick;

            var configuracionEmpresa = new HPResergerCapaLogica.Configuracion.ConfiguracionEmpresa();
            var configuracion1 = configuracionEmpresa.GetByTipo(3);

            trabajarconPartidas = (configuracion1?.Valor ?? 0) != 0;
            layoutControlItem12.Visibility = trabajarconPartidas ? DevExpress.XtraLayout.Utils.LayoutVisibility.Always : DevExpress.XtraLayout.Utils.LayoutVisibility.Never;

            CargarEmpresas();
            CargarProveedores();
            CargarTipoComprobantes();
            CargarMoneda();
            //CargarPartidas();
        }

        private void CargarPartidas()
        {
            HPResergerCapaLogica.Compras.FacturaManual cClase = new HPResergerCapaLogica.Compras.FacturaManual();
            DataTable Tdata = cClase.GetTipoComprobantes();
            cboProveedor.Properties.DataSource = Tdata;
            cboProveedor.Properties.DisplayMember = "nombre";
            cboProveedor.Properties.ValueMember = "idComprobante";

            cboProveedor.EditValue = Tdata.Rows.Count > 0 ? Tdata.Rows[0]["idComprobante"] : null;

            // Limpiar columnas
            var view = cboProveedor.Properties.View;
            view.Columns.Clear();

            var colNombre = view.Columns.AddVisible("nombre", "Nombre del Comprobante de Pago");

            // Ajustar solo las demás columnas
            view.BestFitColumns();
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

        private void CargarTipoComprobantes()
        {
            HPResergerCapaLogica.Compras.FacturaManual cClase = new HPResergerCapaLogica.Compras.FacturaManual();
            DataTable Tdata = cClase.GetTipoComprobantes();
            cboTipoDocumento.Properties.DataSource = Tdata;
            cboTipoDocumento.Properties.DisplayMember = "nombre";
            cboTipoDocumento.Properties.ValueMember = "idComprobante";

            cboTipoDocumento.EditValue = Tdata.Rows.Count > 0 ? Tdata.Rows[0]["idComprobante"] : null;

            // Limpiar columnas
            var view = cboTipoDocumento.Properties.View;
            view.Columns.Clear();

            var colNombre = view.Columns.AddVisible("nombre", "Nombre del Comprobante de Pago");

            // Ajustar solo las demás columnas
            view.BestFitColumns();
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
        DataTable dtPresupuestos;
        private void CargarPresupuetos(int _idempresa)
        {
            if (trabajarconPartidas)
            {
                HPResergerCapaLogica.FlujoCaja.Partidas_Control cClase = new HPResergerCapaLogica.FlujoCaja.Partidas_Control();
                dtPresupuestos = cClase.GetAllxEmpresa(_idempresa);

                cboPartida.Properties.DisplayMember = "Nombre";
                cboPartida.Properties.ValueMember = "id";
                cboPartida.Properties.DataSource = dtPresupuestos; // Fuente de datos general

                cboPartida.Properties.View.Columns.Clear();
                cboPartida.Properties.View.Columns.AddVisible("Nombre", "Nombre del Presupuesto");
                cboPartida.Properties.View.OptionsView.ShowColumnHeaders = false; // Opcional: Ocultar encabezado de columna
                cboPartida.Properties.View.OptionsSelection.EnableAppearanceFocusedCell = false; // Evitar resaltado de celda seleccionada
                cboPartida.Properties.View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus; // Resaltar toda la fila
            }
        }
        private void cboEmpresa_EditValueChanged(object sender, EventArgs e)
        {
            if (cboEmpresa.EditValue != null)
            {
                cargarProyectos((int)cboEmpresa.EditValue);
                CargarPresupuetos((int)cboEmpresa.EditValue);
            }
        }

        private void cboProyecto_EditValueChanged(object sender, EventArgs e)
        {
            if (cboProyecto.EditValue != null)
                cargarEtapas((int)cboProyecto.EditValue);
        }
        string _ruc = "";
        int _tipoId = 0;
        private void cboProveedor_EditValueChanged(object sender, EventArgs e)
        {
            var view = cboProveedor.Properties.View;
            DataRow row = view.GetDataRow(view.FocusedRowHandle);

            if (row != null)
            {
                _ruc = row["ruc"].ToString();
                _tipoId = (int)row["tipoId"];

                //XtraMessageBox.Show($"tipoId {_tipoId } ruc {_ruc} ");
            }
        }

        private void pictureEdit1_DoubleClick(object sender, EventArgs e)
        {
            // Abrir la imagen en el visor
            pbFotoFactura.ShowImageEditorDialog();
            //pbFotoFactura.ShowTakePictureDialog();
        }
        string _nombreFile = "";
        string _extensionFile = "";
        byte[] _dataFile = null;

        private void btnSubirArchivo_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Seleccionar archivo adjunto";
            ofd.Filter = "Todos los archivos|*.*";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                // Leer archivo en bytes
                _dataFile = System.IO.File.ReadAllBytes(ofd.FileName);
                _nombreFile = System.IO.Path.GetFileName(ofd.FileName);
                _extensionFile = System.IO.Path.GetExtension(ofd.FileName);

                //XtraMessageBox.Show("Archivo subido correctamente.");
            }
        }
        private static string RutaDescarga = "";
        public void DescargarTodosArchivos(int tipoFactura, int idFactura, int tipo)
        {
            HPResergerCapaLogica.Compras.FacturaManual CClase = new HPResergerCapaLogica.Compras.FacturaManual();

            var archivos = CClase.GetArchivosFactura(tipoFactura, idFactura, tipo);

            if (archivos.Count == 0)
            {
                XtraMessageBox.Show("No hay archivos asociados para descargar.", "Sin Archivos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            using (var dlg = new FolderBrowserDialog())
            {
                if (RutaDescarga != "") dlg.SelectedPath = RutaDescarga;
                dlg.Description = "Seleccione la carpeta donde desea guardar los archivos adjuntos.";

                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    RutaDescarga = dlg.SelectedPath;
                    foreach (var file in archivos)
                    {
                        string filePath = System.IO.Path.Combine(dlg.SelectedPath, file.NombreArchivo + file.Extension);
                        System.IO.File.WriteAllBytes(filePath, file.Archivo);
                    }

                    XtraMessageBox.Show("Los archivos fueron descargados correctamente.", "Descarga Completa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    XtraMessageBox.Show("No se seleccionó ninguna carpeta.", "Operación Cancelada", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }

        }

        private void btnDescargar_Click(object sender, EventArgs e)
        {

            DescargarTodosArchivos(_tipoFactura, _idFactura, 1);
        }

        private void btnCerrar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void btnNuevo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Estado = 1;
            txtSerie.EditValue = null;
            txtNumeroComprobante.EditValue = null;
            txtGlosa.EditValue = null;
            pbFotoFactura.Image = null;

            _nombreFile = "";
            _nombreFileX = "";
            _idFactura = 0;
            lblEstado.Caption = "Nuevo Comprobante de Pago";
        }
        string _DatoPresupuesto = "";
        private void btnGuardar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            List<string> errores = new List<string>();

            // Validaciones
            if (cboEmpresa.EditValue == null)
                errores.Add("• Debe seleccionar la *Empresa*.");

            if (dtpFechaEmision.EditValue == null)
                errores.Add("• Debe ingresar *Fecha Emision*.");
            if (dtpfechaVencimiento.EditValue == null)
                errores.Add("• Debe ingresar *Fecha Vencimiento*.");

            if (cboProyecto.EditValue == null)
                errores.Add("• Debe seleccionar el *Proyecto*.");

            if (cboEtapa.EditValue == null)
                errores.Add("• Debe seleccionar la *Etapa*.");

            if (cboMoneda.EditValue == null)
                errores.Add("• Debe seleccionar la *Moneda*.");

            if (cboProveedor.EditValue == null)
                errores.Add("• Debe seleccionar un *Proveedor*.");

            if (cboTipoDocumento.EditValue == null)
                errores.Add("• Debe seleccionar el *Tipo de Documento*.");

            if (string.IsNullOrWhiteSpace(Convert.ToString(txtSerie.EditValue)))
                errores.Add("• Debe ingresar la *Serie*.");

            if (string.IsNullOrWhiteSpace(Convert.ToString(txtNumeroComprobante.EditValue)))
                errores.Add("• Debe ingresar el *Número del Comprobante*.");

            if (string.IsNullOrWhiteSpace(Convert.ToString(txtGlosa.EditValue)))
                errores.Add("• Debe ingresar la *Glosa*.");

            // Si hay errores → mostrarlos y detener guardar
            if (errores.Count > 0)
            {
                string mensaje = "Se encontraron los siguientes errores:\n\n" +
                                 string.Join("\n", errores);

                XtraMessageBox.Show(mensaje, "Validación de Datos", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return; // No continuar con el guardado
            }

            DataTable Tprueba = CapaLogica.FacturaManualCabecera(cboProveedor.EditValue.ToString().Trim(), txtSerie.EditValue.ToString() + "-" + txtNumeroComprobante.EditValue.ToString(), (int)cboTipoDocumento.EditValue);
            if (Tprueba.Rows.Count > 0) { XtraMessageBox.Show("No se puede Registrar, Este Documento Ya Existe"); return; }
            // Si no hay errores, continuar con el proceso de guardado

            if (_tipoFactura == 0 || _tipoFactura == 1) _tipoFactura = 1;
            if (_tipoFactura == 2 || _tipoFactura == 3) _tipoFactura = 2;


            if (_tipoFactura == 1) //FACTURA
            {
                HPResergerCapaLogica.Compras.oFacturaManual OfACTURA = new HPResergerCapaLogica.Compras.oFacturaManual();
                OfACTURA.ActivoFijo = 0;
                OfACTURA.Cod_Detraccion = "";
                OfACTURA.Compensacion = 0;
                OfACTURA.Detraccion = 0;
                OfACTURA.Empresa = (int)cboEmpresa.EditValue;
                OfACTURA.Estado = 0;
                OfACTURA.Etapa = (int)cboEtapa.EditValue;
                OfACTURA.FechaCompensacion = null;
                OfACTURA.FechaContable = (DateTime)dtpFechaEmision.EditValue;
                OfACTURA.FechaEmision = (DateTime)dtpFechaEmision.EditValue;
                OfACTURA.FechaModifica = (DateTime)dtpFechaEmision.EditValue;
                OfACTURA.FechaRecepcion = (DateTime)dtpFechaEmision.EditValue;
                OfACTURA.FechaVencimiento = (DateTime)dtpfechaVencimiento.EditValue;
                OfACTURA.Glosa = txtGlosa.EditValue.ToString().Trim();
                OfACTURA.GravaIgv = 0;
                OfACTURA.IdComprobante = (int)cboTipoDocumento.EditValue;
                OfACTURA.Igv = 0;
                OfACTURA.ImgFactura = pbFotoFactura.Image != null ? ImageToByteArray(pbFotoFactura.Image, ImageFormat.Png) : null;
                OfACTURA.Moneda = (int)cboMoneda.EditValue;
                OfACTURA.NroComprobante = txtSerie.EditValue.ToString().Trim() + "-" + txtNumeroComprobante.EditValue.ToString().Trim();
                OfACTURA.Nro_DocPago = "";
                OfACTURA.Porcentaje = 0.18m;
                OfACTURA.Proveedor = _ruc.Trim();
                OfACTURA.Proyecto = (int)cboProyecto.EditValue;
                OfACTURA.TC = 3m;
                OfACTURA.TipoPago = 0;
                OfACTURA.Total = (decimal)(txtMonto.EditValue ?? 0);
                OfACTURA.Usuario = HPReserger.frmLogin.CodigoUsuario;
                OfACTURA.UsuarioCompensacion = "";

                HPResergerCapaLogica.Compras.FacturaManualCompra cclase = new HPResergerCapaLogica.Compras.FacturaManualCompra();
                _idFactura = cclase.Insert(OfACTURA);

                if (_idFactura == 0)
                {
                    XtraMessageBox.Show(
                        "Ocurrió un problema y la factura no se pudo guardar.\n" +
                        "Por favor, intente nuevamente o verifique los datos ingresados.", "Error al Guardar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    XtraMessageBox.Show("La factura fue guardada correctamente.", "Registro Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            else if (_tipoFactura == 2) //NOTAS CREDITO DEBITO
            {
                HPResergerCapaLogica.Compras.oNC_ND_CompraManual oNota = new HPResergerCapaLogica.Compras.oNC_ND_CompraManual();
                //oNota.ActivoFijo = 0;
                //oNota.Cod_Detraccion = "";
                oNota.Compensacion = 0;
                //oNota.Detraccion = 0;
                oNota.Empresa = (int)cboEmpresa.EditValue;
                oNota.Estado = 0;
                oNota.Etapa = (int)cboEtapa.EditValue;
                oNota.FechaCompensacion = null;
                oNota.FechaContable = (DateTime)dtpFechaEmision.EditValue;
                oNota.FechaEmision = (DateTime)dtpFechaEmision.EditValue;
                oNota.FechaModifica = (DateTime)dtpFechaEmision.EditValue;
                oNota.FechaRecepcion = (DateTime)dtpFechaEmision.EditValue;
                oNota.FechaVencimiento = (DateTime)dtpfechaVencimiento.EditValue;
                oNota.Glosa = txtGlosa.EditValue.ToString().Trim();
                oNota.GravaIgv = 0;
                oNota.IdComprobante = (int)cboTipoDocumento.EditValue;
                oNota.Igv = 0;
                oNota.ImgFactura = pbFotoFactura.Image != null ? ImageToByteArray(pbFotoFactura.Image, ImageFormat.Png) : null;
                oNota.Moneda = (int)cboMoneda.EditValue;
                oNota.NroComprobante = txtSerie.EditValue.ToString().Trim() + "-" + txtNumeroComprobante.EditValue.ToString().Trim();

                oNota.NroComprobante_Ref = " ";

                //oNota.Nro_DocPago = "";
                //oNota.Porcentaje = 0.18m;
                oNota.Proveedor = _ruc.Trim();
                oNota.Proyecto = (int)cboProyecto.EditValue;
                oNota.TC = 3m;
                //oNota.TipoPago = 0;
                oNota.Total = (decimal)txtMonto.EditValue;
                oNota.Usuario = HPReserger.frmLogin.CodigoUsuario;
                oNota.UsuarioCompensacion = "";

                HPResergerCapaLogica.Compras.NC_ND_CompraManualCompra cclase = new HPResergerCapaLogica.Compras.NC_ND_CompraManualCompra();

                _idFactura = cclase.Insert(oNota);
                if (_idFactura == 0)
                {
                    XtraMessageBox.Show(
                        "Ocurrió un problema y la nota no se pudo guardar.\n" +
                        "Por favor, intente nuevamente o verifique los datos ingresados.", "Error al Guardar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    XtraMessageBox.Show("La nota fue guardada correctamente.", "Registro Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }



            _DatoPresupuesto = cboPartida.Text ?? "";
            if (_DatoPresupuesto != "")
            {
                HPResergerCapaLogica.FlujoCaja.FacturaPresupuesto oFacP = new HPResergerCapaLogica.FlujoCaja.FacturaPresupuesto();
                oFacP.InsertarxNombreyCodigo(_idFactura, _tipoFactura, (int)cboEmpresa.EditValue, cboPartida.EditValue.ToString());
            }

            if (_nombreFile != "") // 1 documento 2 sustento
            {
                HPResergerCapaLogica.Compras.FacturaManual ccalse = new HPResergerCapaLogica.Compras.FacturaManual();
                ccalse.GuardarAdjuntoSQL(_idFactura, _tipoFactura, 1, _nombreFile, _extensionFile, _dataFile);
            }
            if (_nombreFileX != "")
            {
                HPResergerCapaLogica.Compras.FacturaManual ccalse = new HPResergerCapaLogica.Compras.FacturaManual();
                ccalse.GuardarAdjuntoSQL(_idFactura, _tipoFactura, 2, _nombreFileX, _extensionFileX, _dataFileX);
            }

            Estado = 1;
            txtSerie.EditValue = null;
            txtNumeroComprobante.EditValue = null;
            txtGlosa.EditValue = null;
            pbFotoFactura.Image = null;

            _nombreFile = "";
            _nombreFileX = "";
            _idFactura = 0;

            //lblEstado.Caption = "Comprobante de Pago Guardado";

        }
        // Convierte Image -> byte[]
        private byte[] ImageToByteArray(Image image, ImageFormat format = null)
        {
            if (image == null) return null;
            if (format == null) format = ImageFormat.Png; // formato por defecto

            using (var ms = new MemoryStream())
            {
                image.Save(ms, format);
                return ms.ToArray();
            }
        }

        // Convierte byte[] -> Image
        private Image ByteArrayToImage(byte[] bytes)
        {
            if (bytes == null || bytes.Length == 0) return null;
            using (var ms = new MemoryStream(bytes))
            {
                return Image.FromStream(ms);
            }
        }
        private void cboTipoDocumento_EditValueChanged(object sender, EventArgs e)
        {
            _tipoFactura = 1;

            if (cboTipoDocumento.Text.ToString().Contains("NOTA"))
            {
                _tipoFactura = 2;
            }
        }
        string _nombreFileX = "";
        string _extensionFileX = "";
        byte[] _dataFileX = null;
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Seleccionar archivo adjunto";
            ofd.Filter = "Todos los archivos|*.*";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                // Leer archivo en bytes
                _dataFileX = System.IO.File.ReadAllBytes(ofd.FileName);
                _nombreFileX = System.IO.Path.GetFileName(ofd.FileName);
                _extensionFileX = System.IO.Path.GetExtension(ofd.FileName);

                //XtraMessageBox.Show("Archivo subido correctamente.");
            }
        }
         
    }
}